Imports System
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Graphics

Public Class Play
    Public Shared Score As Integer = 0
    Public Shared Lives As Integer = 3
    Public Shared Coins As Integer = 0
    Public Shared CurPlayer As Integer = 1
    Public Shared P1 As Integer = 1
    Public Shared P2 As Integer = 2
    Public Shared Stars As Integer = 0
    Public Shared HoldItem As Integer = 0
    Public Shared ScoreLoc As Point
    Public Shared LivesLoc As Point
    Public Shared CoinsLoc As Point
    Public Shared StarsLoc As Point
    Public Shared TimeLeftLoc As Rectangle
    Public Shared HoldItemLoc As Rectangle
    Public Shared HoldBoxLoc As Rectangle
    Public Shared IsTesting As Boolean = False

    Public Shared TotalProjectiles As Integer
    Public Shared MaxProjectiles As Integer = 2

    Public Shared PlayerX As Integer
    Public Shared PlayerY As Integer

    Public Shared DrawW As Integer
    Public Shared DrawH As Integer
    Public Shared DrawX As Integer
    Public Shared DrawY As Integer

    Public Shared PlayerBox As Rectangle
    Public Shared OnYoshi As Boolean

    Public Shared MarioState As Integer = 1
    Public Shared LuigiState As Integer = 1
    Public Shared PeachState As Integer = 1
    Public Shared ToadState As Integer = 1

    Public Shared CurState As Integer = 1
    Public Shared RunFrame As Integer = 1
    Public Shared IsMoving As Boolean = False
    Public Shared MoveDir As Integer
    Public Shared Collide As Boolean = False
    Public Shared CollideDir As Integer
    Public Shared OnGround As Boolean = False
    Public Shared PlayerCollide As Rectangle
    Public Shared IsDucking As Boolean = False
    Public Shared IsStarman As Boolean = False

    Public Shared MoveSpeed As Integer = 6
    Public Shared JumpSpeed As Integer = 12
    Public Shared IsRunning As Boolean = False
    Public Shared IsJumping As Boolean = False
    Public Shared JumpHeight As Integer
    Public Shared JumpReleased As Boolean = True

    Public Shared HoverTime As Integer = 0

    Public Shared GravityLevel As Integer = 12

    Public Shared ViewPort As Rectangle

    Public Shared NPCground As Rectangle

    Public Shared Sub ShowHUD()
        HoldBoxLoc = New Rectangle((Form2.Width / 2) - My.Resources.HoldBox.Width, 16, My.Resources.HoldBox.Width, My.Resources.HoldBox.Height)
        ScoreLoc = New Point((HoldBoxLoc.X + HoldBoxLoc.Width) + 128, 48)
        CoinsLoc = New Point((HoldBoxLoc.X + HoldBoxLoc.Width) + 128, 24)
        LivesLoc = New Point((HoldBoxLoc.X - HoldBoxLoc.Width) - 64, 24)
    End Sub

    Public Shared Sub UsePowerup()
        Select Case CurState
            Case 1

        End Select
    End Sub

    Public Shared Sub EndTesting()
        Play.IsTesting = False
        Play.IsRunning = False
        Play.IsMoving = False

        Form2.ResetSpawn()

        Play.Collide = False
        Play.OnGround = False
        Play.CollideDir = 0

        For Each i As NPCsets In NPC.NPCsets.Where(Function(d) d.Testing = True).ToList

            NPC.NPCrects.RemoveAt(NPC.NPCsets.IndexOf(i))
            NPC.NPCsets.Remove(i)

        Next

        For n = 0 To NPC.NPCsets.Count - 1

            Dim tempnpc As NPCsets
            tempnpc = NPC.NPCsets(n)

            tempnpc.X = NPC.NPCsets(n).rectangle.X
            tempnpc.Y = NPC.NPCsets(n).rectangle.Y

            NPC.NPCsets(n) = tempnpc

        Next
    End Sub

    Public Shared Sub AI()
        For i = 0 To NPC.NPCsets.Count - 1
            Dim tempnpc = NPC.NPCsets(i)

            If NPC.NPCsets(i).isMoving = True Then
                If NPC.NPCsets(i).Direction = 2 Then
                    tempnpc.X -= NPC.NPCsets(i).MoveSpeed
                ElseIf NPC.NPCsets(i).Direction = 1 Then
                    tempnpc.X += NPC.NPCsets(i).MoveSpeed
                End If

                For Each r As Rectangle In Blocks.TileRects
                    Select Case tempnpc.Direction
                        Case 1
                            If (((tempnpc.X + tempnpc.Width) = r.Left) Or New Rectangle(tempnpc.X, tempnpc.Y, tempnpc.Width, tempnpc.Height).IntersectsWith(New Rectangle(r.X - tempnpc.MoveSpeed, r.Y + 2, r.Width, r.Height))) And (r.Y < (tempnpc.Y + tempnpc.Height)) And (r.Bottom > tempnpc.Y) Then
                                tempnpc.Direction = 2
                            End If
                        Case 2
                            If ((tempnpc.X = r.Right) Or New Rectangle(tempnpc.X, tempnpc.Y, tempnpc.Width, tempnpc.Height).IntersectsWith(New Rectangle(r.X + tempnpc.MoveSpeed, r.Y + 2, r.Width, r.Height))) And (r.Y < (tempnpc.Y + tempnpc.Height)) And (r.Bottom > tempnpc.Y) Then
                                tempnpc.Direction = 1
                            End If
                    End Select
                Next          
            End If

            Select Case NPC.NPCsets(i).AI
                Case 0
                    tempnpc.isMoving = True
                Case 1
                    tempnpc.Delay += 1

                    tempnpc.isMoving = True

                    If tempnpc.Delay >= 64 Then
                        If NPC.NPCsets(i).totalJumps <= 3 Then
                            If tempnpc.OnGround = True Then
                                tempnpc.TotalFrames = 4

                                tempnpc.isJumping = True
                            End If

                            If tempnpc.isJumping = True Then
                                tempnpc.Y -= 1
                                tempnpc.hopHeight += 1
                            End If                            

                            If tempnpc.hopHeight >= 12 Then
                                tempnpc.isJumping = False
                                tempnpc.hopHeight = 0

                                tempnpc.totalJumps += 1
                            End If
                        ElseIf NPC.NPCsets(i).totalJumps >= 4 Then
                            tempnpc.isJumping = True

                            tempnpc.Y -= 2
                            tempnpc.hopHeight += 2

                            If tempnpc.hopHeight >= 64 Then
                                tempnpc.isJumping = False
                                tempnpc.hopHeight = 0

                                tempnpc.totalJumps = 0
                                tempnpc.Delay = 0

                                tempnpc.TotalFrames = 2
                            End If
                        End If
                    End If
                Case 2
                    If ((PlayerCollide.X >= tempnpc.X) And (PlayerCollide.Right <= tempnpc.rectangle.Right)) And tempnpc.thwompRise = False Then
                        tempnpc.HasGravity = True
                        'tempnpc.thwompFall = True
                    Else
                        If (New Rectangle(tempnpc.X, tempnpc.Y, tempnpc.Width, tempnpc.Height).Top > tempnpc.rectangle.Top) And tempnpc.thwompRise = True Then
                            tempnpc.HasGravity = False
                        ElseIf (New Rectangle(tempnpc.X, tempnpc.Y, tempnpc.Width, tempnpc.Height).Top = tempnpc.rectangle.Top) Then
                            tempnpc.thwompRise = False
                            tempnpc.playedSound = False
                        End If
                    End If

                    If tempnpc.thwompRise = True Then
                        tempnpc.Y -= 2
                    End If
                Case 3
                    If (PlayerCollide.X < tempnpc.X) Then
                        tempnpc.Direction = 2

                        If MoveDir = tempnpc.Direction Then
                            tempnpc.X -= 1

                            If PlayerCollide.Y > tempnpc.Y Then
                                tempnpc.Y += 1
                            ElseIf PlayerCollide.Y < tempnpc.Y Then
                                tempnpc.Y -= 1
                            End If
                            tempnpc.SourceRect = New Rectangle(0, tempnpc.Height, tempnpc.Width, tempnpc.Height)
                        Else
                            tempnpc.SourceRect = New Rectangle(0, 0, tempnpc.Width, tempnpc.Height)
                        End If
                    Else
                        tempnpc.Direction = 1

                        If MoveDir = tempnpc.Direction Then
                            tempnpc.X += 1

                            If PlayerCollide.Y > tempnpc.Y Then
                                tempnpc.Y += 2
                            ElseIf PlayerCollide.Y < tempnpc.Y Then
                                tempnpc.Y -= 2
                            End If
                            tempnpc.SourceRect = New Rectangle(0, tempnpc.Height * 3, tempnpc.Width, tempnpc.Height)
                        Else
                            tempnpc.SourceRect = New Rectangle(0, tempnpc.gfxHeight, tempnpc.Width, tempnpc.Height)
                        End If
                    End If
                Case 4
                    Select Case tempnpc.Direction
                        Case 1
                            tempnpc.X += tempnpc.MoveSpeed
                        Case 2
                            tempnpc.X -= tempnpc.MoveSpeed
                    End Select
                Case 5
                    tempnpc.isMoving = True

                    If tempnpc.hopHeight < 144 Then
                        If tempnpc.OnGround = True Then
                            tempnpc.isJumping = True
                        End If

                        If tempnpc.isJumping = True Then
                            tempnpc.Y -= 6
                            tempnpc.hopHeight += 6
                        End If
                    Else
                        tempnpc.isJumping = False
                        tempnpc.hopHeight = 0
                    End If
                Case 6
                    tempnpc.isMoving = True

                    If (PlayerCollide.X - tempnpc.X) >= 64 And tempnpc.Direction = 2 Then
                        tempnpc.Direction = 1
                    ElseIf (tempnpc.X - PlayerCollide.Right) >= 64 And tempnpc.Direction = 1 Then
                        tempnpc.Direction = 2
                    End If
                Case 7
                    If NPC.NPCsets(i).Direction = 2 Then
                        tempnpc.X -= NPC.NPCsets(i).MoveSpeed
                        tempnpc.Y -= (NPC.NPCsets(i).MoveSpeed / 6)
                    ElseIf NPC.NPCsets(i).Direction = 1 Then
                        tempnpc.X += NPC.NPCsets(i).MoveSpeed
                        tempnpc.Y += (NPC.NPCsets(i).MoveSpeed / 6)
                    End If

                    If (PlayerCollide.X - tempnpc.X) >= 128 And tempnpc.Direction = 2 Then
                        tempnpc.Direction = 1
                    ElseIf (tempnpc.X - PlayerCollide.Right) >= 128 And tempnpc.Direction = 1 Then
                        tempnpc.Direction = 2
                    End If

                    If tempnpc.lakituThrow = False And tempnpc.Delay < 600 Then
                        tempnpc.Delay += 1

                        tempnpc.Animated = False
                        tempnpc.gfxHeight = 64

                        tempnpc.SourceRect = New Rectangle(0, 0, tempnpc.Width, tempnpc.Height)
                    ElseIf tempnpc.Delay >= 600 Then
                        tempnpc.Delay = 0
                        tempnpc.lakituThrow = True
                    End If

                    If tempnpc.lakituThrow = True Then
                        tempnpc.Animated = True
                        tempnpc.gfxHeight = 384

                        tempnpc.Delay += 1

                        If tempnpc.Delay >= 100 Then
                            tempnpc.lakituThrow = False
                            tempnpc.Delay = 0
                        End If
                    End If
                Case 8
                    If tempnpc.Delay < 100 And tempnpc.hopHeight = 0 Then
                        tempnpc.Delay += 1
                    Else
                        If tempnpc.hopHeight < 128 Then
                            tempnpc.Y -= 6
                            tempnpc.hopHeight += 6
                        Else
                            If tempnpc.Y < tempnpc.rectangle.Y Then
                                tempnpc.Y += GravityLevel
                            Else
                                tempnpc.hopHeight = 0
                                tempnpc.Delay = 0
                            End If
                        End If
                    End If
                Case 9
                    If NPC.NPCsets(i).Direction = 2 Then
                        tempnpc.X -= NPC.NPCsets(i).MoveSpeed
                        tempnpc.SourceRect = New Rectangle(0, 0, tempnpc.Width, tempnpc.Height)
                    ElseIf NPC.NPCsets(i).Direction = 1 Then
                        tempnpc.X += NPC.NPCsets(i).MoveSpeed
                        tempnpc.SourceRect = New Rectangle(0, tempnpc.Height, tempnpc.Width, tempnpc.Height)
                    End If
                Case 10

                Case 11
                    tempnpc.Delay += 1

                    If tempnpc.Delay >= 64 And tempnpc.OnGround = True Then
                        tempnpc.isJumping = True

                        tempnpc.Y -= 2
                        tempnpc.hopHeight += 2

                        tempnpc.TotalFrames = 2
                        tempnpc.Animated = True

                        If NPC.NPCsets(i).Direction = 2 Then
                            tempnpc.X -= NPC.NPCsets(i).MoveSpeed * 2
                        ElseIf NPC.NPCsets(i).Direction = 1 Then
                            tempnpc.X += NPC.NPCsets(i).MoveSpeed * 2
                        End If

                        If tempnpc.hopHeight >= 64 Then
                            tempnpc.isJumping = False
                            tempnpc.hopHeight = 0

                            tempnpc.totalJumps = 0
                            tempnpc.Delay = 0

                            tempnpc.Animated = False
                            tempnpc.SourceRect = New Rectangle(0, 0, tempnpc.Width, tempnpc.Height)
                        End If
                    Else
                        tempnpc.SourceRect = New Rectangle(0, 0, tempnpc.Width, tempnpc.Height)
                    End If
                Case 12
                    If tempnpc.angle < 360 Then
                        tempnpc.angle += 1
                    ElseIf tempnpc.angle >= 360 Then
                        tempnpc.angle = 0
                    End If

                    If tempnpc.radius <= 0 Then
                        tempnpc.radius = 96
                    End If

                    If NPC.NPCsets(i).Direction = 2 Then
                        tempnpc.X = tempnpc.rectangle.X + Math.Sin(tempnpc.angle / 8) * tempnpc.radius
                        tempnpc.Y = (tempnpc.rectangle.Y - tempnpc.radius) + Math.Cos(tempnpc.angle / 8) * tempnpc.radius
                    ElseIf NPC.NPCsets(i).Direction = 1 Then
                        tempnpc.X = tempnpc.rectangle.X - Math.Sin(tempnpc.angle / 8) * tempnpc.radius
                        tempnpc.Y = (tempnpc.rectangle.Y + tempnpc.radius) - Math.Cos(tempnpc.angle / 8) * tempnpc.radius
                    End If
                Case 13
                    If tempnpc.Delay < 500 Then
                        If NPC.NPCsets(i).Direction = 2 Then
                            tempnpc.X -= NPC.NPCsets(i).MoveSpeed
                        ElseIf NPC.NPCsets(i).Direction = 1 Then
                            tempnpc.X += NPC.NPCsets(i).MoveSpeed
                        End If

                        tempnpc.Delay += 1
                    Else
                        tempnpc.Animated = False
                        tempnpc.SourceRect = New Rectangle(0, tempnpc.Height * Math.Floor((tempnpc.Delay / 100)), tempnpc.Width, tempnpc.Height)

                        If tempnpc.Friction < tempnpc.MoveSpeed Then
                            tempnpc.Friction += 0.01
                        End If

                        If NPC.NPCsets(i).Direction = 2 Then
                            tempnpc.X -= (NPC.NPCsets(i).MoveSpeed - tempnpc.Friction)
                        ElseIf NPC.NPCsets(i).Direction = 1 Then
                            tempnpc.X += (NPC.NPCsets(i).MoveSpeed - tempnpc.Friction)
                        End If

                        tempnpc.Delay += 1

                        If tempnpc.Delay >= 600 Then
                            tempnpc.Delay = 0
                            tempnpc.Animated = True
                            tempnpc.Friction = 0
                        End If
                    End If
                Case 14
                    Select Case tempnpc.Direction
                        Case 1
                            tempnpc.SourceRect = New Rectangle(0, 0, tempnpc.Width, tempnpc.Height)
                        Case 2
                            tempnpc.SourceRect = New Rectangle(0, tempnpc.gfxHeight, tempnpc.Width, tempnpc.Height)
                    End Select

                    If (tempnpc.totalJumps = 1 And tempnpc.totalFire = 0) Then
                        If tempnpc.Delay > 100 Then
                            tempnpc.Delay = 0
                            tempnpc.totalFire += 1
                            tempnpc.isJumping = False
                        Else
                            tempnpc.Delay += 1
                        End If
                    ElseIf tempnpc.totalJumps = 3 Then
                        If tempnpc.Delay > 100 Then
                            tempnpc.Delay = 0
                            tempnpc.totalFire += 1
                            tempnpc.totalJumps = 0
                            tempnpc.totalFire = 0
                            tempnpc.isJumping = False
                        Else
                            tempnpc.Delay += 1
                        End If
                    ElseIf (tempnpc.totalJumps < 3) Then
                        If tempnpc.Delay > 200 Then
                            If tempnpc.hopHeight >= 128 Then
                                tempnpc.isJumping = False
                                tempnpc.Delay = 0
                                tempnpc.totalJumps += 1
                                tempnpc.hopHeight = 0
                            Else
                                tempnpc.isJumping = True

                                If tempnpc.isJumping = True Then
                                    tempnpc.Y -= 2
                                    tempnpc.hopHeight += 2
                                End If


                                tempnpc.isMoving = True
                            End If
                        Else
                            tempnpc.Delay += 1
                            tempnpc.isJumping = False
                            tempnpc.isMoving = True

                            If (PlayerCollide.X - tempnpc.X) >= 96 And tempnpc.Direction = 2 Then
                                tempnpc.Direction = 1
                            ElseIf (tempnpc.X - PlayerCollide.Right) >= 96 And tempnpc.Direction = 1 Then
                                tempnpc.Direction = 2
                            End If
                        End If
                    End If
                Case 15
                    '5 Jumps - Jump Height: 16
                    '2-3 Fireballs
                    'Long Jump - Jump Height: 272
                    '2 Jumps
                    'Ground Pound or Fireballs

                    If tempnpc.totalJumps < 6 Then
                        If tempnpc.OnGround = True Then
                            tempnpc.isJumping = True
                        End If

                        If tempnpc.isJumping = True Then
                            If tempnpc.hopHeight < 16 Then
                                tempnpc.isJumping = True

                                If tempnpc.isJumping = True Then
                                    tempnpc.Y -= 1
                                    tempnpc.hopHeight += 1
                                End If
                                
                            Else
                                tempnpc.isJumping = False
                                tempnpc.hopHeight = 0
                                tempnpc.totalJumps += 1
                            End If
                        End If
                    Else
                        If tempnpc.Delay >= 150 Then

                            If tempnpc.OnGround = True Then
                                tempnpc.isJumping = True
                            End If

                            If tempnpc.isJumping = True Then
                                If tempnpc.hopHeight < 272 Then
                                    tempnpc.Y -= 6
                                    tempnpc.hopHeight += 6
                                Else
                                    tempnpc.isJumping = False
                                    tempnpc.hopHeight = 0
                                    tempnpc.totalJumps = 0
                                    tempnpc.Delay = 0
                                End If
                            End If
                        End If
                        tempnpc.Delay += 1
                    End If
                Case 16
                    If PlayerCollide.IntersectsWith(New Rectangle(tempnpc.X, tempnpc.Y - JumpSpeed, tempnpc.Width, tempnpc.Height)) Then
                        If tempnpc.isMoving = False Then
                            tempnpc.isMoving = True
                            tempnpc.Direction = MoveDir
                        ElseIf tempnpc.isMoving = True And OnGround = False Then
                            tempnpc.isMoving = False
                        End If
                    End If
            End Select

            'Gravity
            tempnpc.OnGround = False

            If tempnpc.AI <> 4 Then
                For Each r As Rectangle In Blocks.TileRects
                    'Checks if bottom of NPC is contained in a tile.
                    If (r.Contains(New Point(tempnpc.X + 2, tempnpc.Y + tempnpc.Height)) = True Or r.Contains(New Point((tempnpc.X + tempnpc.Width) - 2, tempnpc.Y + tempnpc.Height)) = True) And (tempnpc.HasGravity = True And tempnpc.isJumping = False) Then

                        tempnpc.OnGround = True
                        tempnpc.Y = (r.Top - tempnpc.Height)

                        If tempnpc.AI = 2 And tempnpc.playedSound = False Then
                            Audio.PlaySound(6)
                            tempnpc.playedSound = True
                            tempnpc.thwompRise = True
                        End If
                    End If
                Next

            Else
                Select Case tempnpc.Direction
                    Case 1
                        For Each r As Rectangle In Blocks.TileRects.Where(Function(s) New Rectangle(tempnpc.X - tempnpc.Width, tempnpc.Y - tempnpc.Height, tempnpc.Width * 4, tempnpc.Height * 4).Contains(s))
                            If New Rectangle(tempnpc.X + tempnpc.Width, tempnpc.Y, tempnpc.Width, tempnpc.Height).IntersectsWith(New Rectangle(r.X, r.Y - GravityLevel, r.Width, r.Height)) Then

                                tempnpc.OnGround = True
                                If tempnpc.Y >= r.Top - GravityLevel Then
                                    tempnpc.Y = (r.Top - tempnpc.Height)
                                End If

                            End If
                        Next
                    Case 2
                        For Each r As Rectangle In Blocks.TileRects.Where(Function(s) New Rectangle(tempnpc.X - tempnpc.Width, tempnpc.Y - tempnpc.Height, tempnpc.Width * 4, tempnpc.Height * 4).Contains(s))
                            If New Rectangle(tempnpc.X - tempnpc.Width, tempnpc.Y, tempnpc.Width, tempnpc.Height).IntersectsWith(New Rectangle(r.X, r.Y - GravityLevel, r.Width, r.Height)) Then

                                tempnpc.OnGround = True
                                If tempnpc.Y >= r.Top - GravityLevel Then
                                    tempnpc.Y = (r.Top - tempnpc.Height)
                                End If

                            End If
                        Next
                End Select
            End If

            If tempnpc.OnGround = False And (tempnpc.HasGravity = True And tempnpc.isJumping = False) Then
                Select Case NPC.NPCsets(i).AI
                    Case 0, 2, 6, 10, 11, 13, 14, 15, 16
                        tempnpc.Y += GravityLevel
                    Case 1, 5
                        tempnpc.Y += GravityLevel / 2
                    Case 4
                        Select Case tempnpc.Direction
                            Case 1
                                tempnpc.Direction = 2
                            Case 2
                                tempnpc.Direction = 1
                        End Select

                        tempnpc.Y += GravityLevel
                End Select
            End If

            'NPC Collision Checking
            tempnpc.CollRect = New Rectangle(tempnpc.X, tempnpc.Y, tempnpc.Width, tempnpc.Height)

            If NPC.NPCsets(i).NPCcollide = True And tempnpc.OnGround = True And Not tempnpc.AI = 16 Then
                Dim f As Integer = i
                For Each n As NPCsets In NPC.NPCsets.Where(Function(a) Not a.Equals(NPC.NPCsets(f)))
                    Select Case tempnpc.Direction
                        Case 1
                            'Changes direction when colliding, as long as the NPC won't get stuck.
                            If ((tempnpc.CollRect.Right >= n.CollRect.Left) And tempnpc.CollRect.IntersectsWith(n.CollRect)) And ((tempnpc.CollRect.Contains(n.CollRect) = False)) Then
                                Dim BoxSize As Rectangle = Rectangle.Intersect(tempnpc.CollRect, n.CollRect)

                                If Not BoxSize.Width > 4 Then
                                    tempnpc.Direction = 2
                                End If

                            End If
                        Case 2
                            If ((tempnpc.X <= n.CollRect.Right) And tempnpc.CollRect.IntersectsWith(n.CollRect)) And ((tempnpc.CollRect.Contains(n.CollRect) = False)) Then
                                Dim BoxSize As Rectangle = Rectangle.Intersect(tempnpc.CollRect, n.CollRect)

                                If Not BoxSize.Width > 4 Then
                                    tempnpc.Direction = 1
                                End If
                            End If
                    End Select
                Next
            End If

            NPC.NPCsets(i) = tempnpc
        Next


    End Sub

    Public Shared Sub GetPlayerFrame()
        If IsDucking = False Then
            DrawW = Player.P1.PlayerW
            DrawH = Player.P1.PlayerH
        Else
            If CurPlayer = 1 Then
                Select Case Player.P1.PlayerState
                    Case 0
                        DrawH = 30
                    Case 1, 2, 3, 6
                        DrawH = 36
                    Case 4, 5
                        DrawH = 36
                End Select
            ElseIf CurPlayer = 2 Then
                Select Case Player.P1.PlayerState
                    Case 0
                        DrawW = 28
                        DrawH = 32
                    Case 1, 2, 3, 6
                        DrawH = 36
                    Case 4, 5
                        DrawH = 36
                End Select
            ElseIf CurPlayer = 3 Then
                Select Case Player.P1.PlayerState
                    Case 0
                        DrawH = 38
                    Case 1, 2, 3, 6
                        DrawW = 32
                        DrawH = 32
                    Case 4
                        DrawW = 32
                        DrawH = 34
                    Case 5
                        DrawW = 32
                        DrawH = 38
                End Select
            ElseIf CurPlayer = 4 Then
                Select Case Player.P1.PlayerState
                    Case 0
                        DrawH = 28
                    Case 1, 2, 3, 6
                        DrawW = 32
                        DrawH = 32
                    Case 4
                        DrawW = 32
                        DrawH = 32
                    Case 5
                        DrawW = 32
                        DrawH = 34
                End Select
            End If
        End If

        If IsMoving = True Then
            IsDucking = False

            If CurState > 0 Then
                If OnGround = True And IsDucking = False Then
                    Select Case MoveDir
                        Case 1
                            Form2.PlayerFX = 500
                            If RunFrame = 1 Then
                                RunFrame = 2
                                Form2.PlayerFY = 200
                            ElseIf RunFrame = 2 Then
                                RunFrame = 1
                                Form2.PlayerFY = 100
                            End If
                        Case 2
                            Form2.PlayerFX = 400
                            If RunFrame = 1 Then
                                RunFrame = 2
                                Form2.PlayerFY = 700
                            ElseIf RunFrame = 2 Then
                                RunFrame = 1
                                Form2.PlayerFY = 600
                            End If
                    End Select
                ElseIf IsDucking = False And OnGround = False Then
                    Select Case MoveDir
                        Case 1
                            If CurState > 0 Then
                                Form2.PlayerFX = 500
                                Form2.PlayerFY = 300
                            Else
                                Form2.PlayerFX = 500
                                Form2.PlayerFY = 200
                            End If
                        Case 2
                            If CurState > 0 Then
                                Form2.PlayerFX = 400
                                Form2.PlayerFY = 500
                            Else
                                Form2.PlayerFX = 400
                                Form2.PlayerFY = 600
                            End If
                    End Select
                End If
            Else
                If OnGround = True And IsDucking = False Then
                    Select Case MoveDir
                        Case 1
                            Form2.PlayerFX = 500
                            If RunFrame = 1 Then
                                RunFrame = 2
                                Form2.PlayerFY = 100
                            ElseIf RunFrame = 2 Then
                                RunFrame = 1
                                Form2.PlayerFY = 0
                            End If
                        Case 2
                            Form2.PlayerFX = 400
                            If RunFrame = 1 Then
                                RunFrame = 2
                                Form2.PlayerFY = 800
                            ElseIf RunFrame = 2 Then
                                RunFrame = 1
                                Form2.PlayerFY = 700
                            End If
                    End Select
                End If
            End If
        Else
            If IsDucking = False And OnGround = True Then
                Select Case MoveDir
                    Case 1
                        Form2.PlayerFX = 500
                        Form2.PlayerFY = 0
                    Case 2
                        Form2.PlayerFX = 400
                        Form2.PlayerFY = 800
                End Select
            ElseIf IsDucking = False And OnGround = False Then
                Select Case MoveDir
                    Case 1
                        If CurState > 0 Then
                            Form2.PlayerFX = 500
                            Form2.PlayerFY = 300
                        Else
                            Form2.PlayerFX = 500
                            Form2.PlayerFY = 200
                        End If
                    Case 2
                        If CurState > 0 Then
                            Form2.PlayerFX = 400
                            Form2.PlayerFY = 500
                        Else
                            Form2.PlayerFX = 400
                            Form2.PlayerFY = 600
                        End If
                End Select
            ElseIf IsDucking = True And OnGround = True Then
                Select Case MoveDir
                    Case 1
                        Form2.PlayerFX = 500
                        Form2.PlayerFY = 600
                    Case 2
                        Form2.PlayerFX = 400
                        Form2.PlayerFY = 200
                End Select
            End If
        End If
    End Sub

    Public Shared Sub Gravity()
        PlayerCollide = New Rectangle(PlayerX, PlayerY, Player.P1.PlayerW, Player.P1.PlayerH)

        OnGround = False

        For Each r As Rectangle In Blocks.TileRects.Where(Function(s) Play.ViewPort.Contains(s))
            If PlayerCollide.IntersectsWith(New Rectangle(r.X, r.Y - GravityLevel, r.Width, r.Height)) And IsJumping = False Then

                OnGround = True
                CheckCollision()

                If CollideDir = 0 Then
                    PlayerCollide.Y = (r.Top - Player.P1.PlayerH)
                    PlayerY = (r.Top - Player.P1.PlayerH)
                    DrawY = (r.Top - Player.P1.PlayerH)
                End If
            End If
        Next

        If OnGround = False And IsJumping = False Then
            PlayerCollide.Y += GravityLevel
            PlayerY += GravityLevel
            DrawY += GravityLevel
        End If

        If IsJumping = False And IsMoving = False Then
            If JumpHeight > 0 Then
                JumpHeight = 0
            End If
        ElseIf IsJumping = False And IsMoving = True Then
            If JumpHeight > 0 Then
                JumpHeight = 0
            End If

            CheckCollision()

            Select Case MoveDir
                Case 1
                    If Not CollideDir = 1 Then
                        PlayerX += Play.MoveSpeed
                        DrawX += Play.MoveSpeed
                    End If
                Case 2
                    If Not CollideDir = 2 Then
                        PlayerX -= Play.MoveSpeed
                        DrawX -= Play.MoveSpeed
                    End If
            End Select
        ElseIf IsJumping = True And IsMoving = True Then
            PlayerY -= JumpSpeed
            DrawY -= JumpSpeed
            JumpHeight += JumpSpeed

            Jump()
            CheckCollision()

            Select Case MoveDir
                Case 1
                    If Not CollideDir = 1 Then
                        PlayerX += Play.MoveSpeed
                        DrawX += Play.MoveSpeed
                    End If
                Case 2
                    If Not CollideDir = 2 Then
                        PlayerX -= Play.MoveSpeed
                        DrawX -= Play.MoveSpeed
                    End If
            End Select

        ElseIf IsJumping = True And IsMoving = False Then
            PlayerY -= JumpSpeed
            DrawY -= JumpSpeed
            JumpHeight += JumpSpeed

            Jump()
        End If

        'End Testing when player falls in pit
        IsTesting = Not PlayerCollide.Top > Level.LevelH

        If IsTesting = False Then
            EndTesting()
        End If

        CheckCollision()

        MaintainLevelBounds()
    End Sub

    Public Shared Sub Jump()
        'Sets maxium jump heights based on player ID that is testing.
        Select Case CurPlayer
            Case 0, 2, 3
                If JumpHeight >= 128 Then
                    IsJumping = False
                End If
            Case 1
                If JumpHeight >= 160 Then
                    IsJumping = False
                End If
        End Select
    End Sub

    Public Shared Sub CheckCollision()
        PlayerCollide = New Rectangle(PlayerX, PlayerY, Player.P1.PlayerW, Player.P1.PlayerH)

        CollideDir = 0

        For Each r As Rectangle In Blocks.TileRects.Where(Function(s) Play.ViewPort.Contains(s)).ToList
            Select Case MoveDir
                Case 1
                    'Check for collision on left side of block.
                    If ((PlayerCollide.Right = r.Left) Or PlayerCollide.IntersectsWith(New Rectangle(r.X - MoveSpeed, r.Y + 2, r.Width, r.Height))) And (r.Y < PlayerCollide.Bottom) And (r.Bottom > PlayerCollide.Top) Then
                        CollideDir = 1
                    ElseIf (PlayerCollide.Right >= ViewPort.Right - 32) Then
                        CollideDir = 1
                    End If
                Case 2
                    'Check for collision on right side of block.
                    If ((PlayerCollide.Left = r.Right) Or PlayerCollide.IntersectsWith(New Rectangle(r.X + MoveSpeed, r.Y + 2, r.Width, r.Height))) And (r.Y < PlayerCollide.Bottom) And (r.Bottom > PlayerCollide.Top) Then
                        CollideDir = 2
                    ElseIf (PlayerCollide.Left <= ViewPort.Left) Then
                        CollideDir = 2
                    End If
            End Select

            'Check if player hit block from below.
            If PlayerCollide.IntersectsWith(New Rectangle(r.X, r.Y + JumpSpeed, r.Width, r.Height)) = True And IsJumping = True Then
                IsJumping = False

                PlayerCollide.Y = (r.Bottom + 2)
                PlayerY = (r.Bottom + 2)
                DrawY = (r.Bottom + 2)

                If CurState > 0 And Blocks.Tiles.Item(Blocks.TileRects.IndexOf(r)).Breakable = True Then
                    Blocks.Tiles.RemoveAt(Blocks.TileRects.IndexOf(r))
                    Blocks.TileRects.Remove(r)
                End If
            End If
        Next

        If IsRunning = False Then
            MoveSpeed = 4
        Else
            MoveSpeed = 8
        End If

        If IsStarman = True Then
            MoveSpeed += 4
        End If
    End Sub

    Public Shared Sub Move(dir As Integer)
        MoveDir = dir

        CheckCollision()

        IsMoving = Not CollideDir = dir

        MaintainLevelBounds()
    End Sub

    Public Shared Sub MaintainLevelBounds()
        'Keep player from leaving level
        If Level.LevelW > 640 Or (Level.LevelH > 608 And OnGround = False) Then
            ViewPort = New Rectangle(PlayerX - (Form2.Width / 2), PlayerY - (Form2.Height / 2), Form2.Width, Form2.Height - 56)

            If ViewPort.X < 0 Then
                ViewPort.X = 0
            ElseIf ViewPort.Right > (Level.LevelW + Player.P1.PlayerW) Then
                ViewPort.X = (Level.LevelW - Form2.Width) + 32
            End If

            If PlayerX < 0 Then
                PlayerX = 0
            ElseIf PlayerCollide.Right > ViewPort.Right Then
                PlayerCollide.X = ViewPort.Right - PlayerCollide.Width
            End If

            If ViewPort.Y < 0 Then
                ViewPort.Y = 0
            ElseIf ViewPort.Bottom > Level.LevelH Then
                ViewPort.Y = Level.LevelH - ViewPort.Height
            End If
        ElseIf Level.LevelW <= 640 Then
            ViewPort.X = 0
        ElseIf Level.LevelH <= 608 Then
            ViewPort.Y = 0
        End If

        'Keeps mouse in correct position in relation to the level.

        Select Case Form2.EditMode
            Case 0, 1, 2, 5, 6, 7
                Form2.mouseX = Math.Floor((Form2.mouselocX + (ViewPort.X)) / 32)
                Form2.mouseY = Math.Floor((Form2.mouselocY + (ViewPort.Y)) / 32)
            Case Else
                Form2.mouseX = Math.Floor((Form2.mouselocX + (ViewPort.X)) / 4)
                Form2.mouseY = Math.Floor((Form2.mouselocY + (ViewPort.Y)) / 32)
        End Select

        Form2.AddObject()
    End Sub
End Class