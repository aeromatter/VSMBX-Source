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
    Public Shared PlayerW As Integer
    Public Shared PlayerH As Integer
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
    Public Shared IsStarman As Boolean = True

    Public Shared MoveSpeed As Integer = 6
    Public Shared JumpSpeed As Integer = 12
    Public Shared IsRunning As Boolean = False
    Public Shared IsJumping As Boolean = False
    Public Shared JumpHeight As Integer
    Public Shared JumpReleased As Boolean = True

    Public Shared HoverTime As Integer = 0

    Public Shared GravityLevel As Integer = 12

    Public Shared MarioW As Integer
    Public Shared MarioH As Integer
    Public Shared LuigiW As Integer
    Public Shared LuigiH As Integer
    Public Shared PeachW As Integer
    Public Shared PeachH As Integer
    Public Shared ToadW As Integer
    Public Shared ToadH As Integer

    Public Shared NPClocs As List(Of ActiveNPC)
    Public Shared ViewPort As Rectangle

    Public Shared Sub ShowHUD()
        HoldBoxLoc = New Rectangle((Form2.Width / 2) - My.Resources.HoldBox.Width, 16, My.Resources.HoldBox.Width, My.Resources.HoldBox.Height)
        ScoreLoc = New Point((HoldBoxLoc.X + HoldBoxLoc.Width) + 128, 48)
        CoinsLoc = New Point((HoldBoxLoc.X + HoldBoxLoc.Width) + 128, 24)
        LivesLoc = New Point((HoldBoxLoc.X - HoldBoxLoc.Width) - 64, 24)
    End Sub

    Public Shared Sub GetPlayer()
        Select Case MarioState
            Case 0
                Form2.Mario = New Bitmap(Form1.FilePath & "\graphics\mario\mario-1.png")

                PlayerW = 26
                PlayerH = 30
            Case 1
                Form2.Mario = New Bitmap(Form1.FilePath & "\graphics\mario\mario-2.png")

                PlayerW = 32
                PlayerH = 54
            Case 2
                Form2.Mario = New Bitmap(Form1.FilePath & "\graphics\mario\mario-3.png")

                PlayerW = 32
                PlayerH = 54
            Case 3
                Form2.Mario = New Bitmap(Form1.FilePath & "\graphics\mario\mario-7.png")

                PlayerW = 32
                PlayerH = 54
            Case 4
                Form2.Mario = New Bitmap(Form1.FilePath & "\graphics\mario\mario-4.png")

                PlayerW = 46
                PlayerH = 56
            Case 5
                Form2.Mario = New Bitmap(Form1.FilePath & "\graphics\mario\mario-5.png")

                PlayerW = 46
                PlayerH = 56
            Case 6
                Form2.Mario = New Bitmap(Form1.FilePath & "\graphics\mario\mario-6.png")

                PlayerW = 32
                PlayerH = 54
        End Select

        MarioW = PlayerW
        MarioH = PlayerH

        Select Case LuigiState
            Case 0
                Form2.Luigi = New Bitmap(Form1.FilePath & "\graphics\luigi\luigi-1.png")

                PlayerW = 30
                PlayerH = 32
            Case 1
                Form2.Luigi = New Bitmap(Form1.FilePath & "\graphics\luigi\luigi-2.png")

                PlayerW = 32
                PlayerH = 62
            Case 2
                Form2.Luigi = New Bitmap(Form1.FilePath & "\graphics\luigi\luigi-3.png")

                PlayerW = 32
                PlayerH = 62
            Case 3
                Form2.Luigi = New Bitmap(Form1.FilePath & "\graphics\luigi\luigi-7.png")

                PlayerW = 32
                PlayerH = 62
            Case 4
                Form2.Luigi = New Bitmap(Form1.FilePath & "\graphics\luigi\luigi-4.png")

                PlayerW = 46
                PlayerH = 64
            Case 5
                Form2.Luigi = New Bitmap(Form1.FilePath & "\graphics\luigi\luigi-5.png")

                PlayerW = 46
                PlayerH = 64
            Case 6
                Form2.Luigi = New Bitmap(Form1.FilePath & "\graphics\luigi\luigi-6.png")

                PlayerW = 32
                PlayerH = 62
        End Select

        LuigiW = PlayerW
        LuigiH = PlayerH

        Select Case PeachState
            Case 0
                Form2.Peach = New Bitmap(Form1.FilePath & "\graphics\peach\peach-1.png")

                PlayerW = 28
                PlayerH = 44
            Case 1
                Form2.Peach = New Bitmap(Form1.FilePath & "\graphics\peach\peach-2.png")

                PlayerW = 34
                PlayerH = 64
            Case 2
                Form2.Peach = New Bitmap(Form1.FilePath & "\graphics\peach\peach-3.png")

                PlayerW = 34
                PlayerH = 64
            Case 3
                Form2.Peach = New Bitmap(Form1.FilePath & "\graphics\peach\peach-7.png")

                PlayerW = 34
                PlayerH = 64
            Case 4
                Form2.Peach = New Bitmap(Form1.FilePath & "\graphics\peach\peach-4.png")

                PlayerW = 46
                PlayerH = 64
            Case 5
                Form2.Peach = New Bitmap(Form1.FilePath & "\graphics\peach\peach-5.png")

                PlayerW = 46
                PlayerH = 68
            Case 6
                Form2.Peach = New Bitmap(Form1.FilePath & "\graphics\peach\peach-6.png")

                PlayerW = 40
                PlayerH = 64
        End Select

        PeachW = PlayerW
        PeachH = PlayerH

        Select Case ToadState
            Case 0
                Form2.Toad = New Bitmap(Form1.FilePath & "\graphics\toad\toad-1.png")

                PlayerW = 30
                PlayerH = 38
            Case 1
                Form2.Toad = New Bitmap(Form1.FilePath & "\graphics\toad\toad-2.png")

                PlayerW = 34
                PlayerH = 54
            Case 2
                Form2.Toad = New Bitmap(Form1.FilePath & "\graphics\toad\toad-3.png")

                PlayerW = 34
                PlayerH = 54
            Case 3
                Form2.Toad = New Bitmap(Form1.FilePath & "\graphics\toad\toad-7.png")

                PlayerW = 34
                PlayerH = 54
            Case 4
                Form2.Toad = New Bitmap(Form1.FilePath & "\graphics\toad\toad-4.png")

                PlayerW = 46
                PlayerH = 54
            Case 5
                Form2.Toad = New Bitmap(Form1.FilePath & "\graphics\toad\toad-5.png")

                PlayerW = 46
                PlayerH = 54
            Case 6
                Form2.Toad = New Bitmap(Form1.FilePath & "\graphics\toad\toad-6.png")

                PlayerW = 36
                PlayerH = 52
        End Select

        ToadW = PlayerW
        ToadH = PlayerH

        PlayerBox = New Rectangle(PlayerX, PlayerY, PlayerW, PlayerH)

        MaintainLevelBounds()

        'If hurt = true and state > 0 then
        'mariostate = 1
        'else
        'playerdied = true
    End Sub

    Public Shared Sub UsePowerup()
        Select Case CurState
            Case 1

        End Select
    End Sub

    Public Shared Sub AI()

        For i = 0 To NPC.NPCsets.Count - 1
            Dim tempnpc = NPC.NPCsets(i)

            Select Case NPC.NPCsets(i).AI
                Case 0
                    If NPC.NPCsets(i).Direction = 0 Then
                        tempnpc.X -= NPC.NPCsets(i).MoveSpeed
                    ElseIf NPC.NPCsets(i).Direction = 2 Then
                        tempnpc.X += NPC.NPCsets(i).MoveSpeed
                    End If
                Case 1
                    tempnpc.Delay += 1

                    If NPC.NPCsets(i).Direction = 0 Then
                        tempnpc.X -= NPC.NPCsets(i).MoveSpeed
                    ElseIf NPC.NPCsets(i).Direction = 2 Then
                        tempnpc.X += NPC.NPCsets(i).MoveSpeed
                    End If

                    If tempnpc.Delay >= 64 And tempnpc.OnGround = True Then
                        If NPC.NPCsets(i).totalJumps <= 3 Then
                            tempnpc.TotalFrames = 4

                            tempnpc.isJumping = True

                            tempnpc.Y -= 1
                            tempnpc.hopHeight += 1

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
            End Select

            If NPC.NPCsets(i).HasGravity = True And tempnpc.isJumping = False Then
                tempnpc.OnGround = False

                For Each r As Rectangle In Blocks.TileRects.Where(Function(s) Play.ViewPort.Contains(s))
                    If New Rectangle(tempnpc.X, tempnpc.Y, tempnpc.Width, tempnpc.Height).IntersectsWith(New Rectangle(r.X, r.Y - GravityLevel, r.Width, r.Height)) Then

                        tempnpc.OnGround = True
                        tempnpc.Y = (r.Top - tempnpc.Height)
                    End If
                Next

                Select Case NPC.NPCsets(i).AI
                    Case 0
                        If tempnpc.OnGround = False Then
                            tempnpc.Y += GravityLevel
                        End If
                    Case 1
                        If tempnpc.OnGround = False Then
                            tempnpc.Y += GravityLevel / 2
                        End If
                End Select
                
            End If

            NPC.NPCsets(i) = tempnpc
        Next
    End Sub

    Public Shared Sub GetPlayerFrame()
        If IsDucking = False Then
            If CurPlayer = 1 Then
                Select Case Play.MarioState
                    Case 0
                        DrawH = 30
                    Case 1, 2, 3, 6
                        DrawH = 54
                    Case 4, 5
                        DrawW = 46
                        DrawH = 56
                End Select
            ElseIf CurPlayer = 2 Then
                Select Case Play.LuigiState
                    Case 0
                        DrawW = 28
                        DrawH = 32
                    Case 1, 2, 3, 6
                        DrawW = 32
                        DrawH = 62
                    Case 4, 5
                        DrawW = 46
                        DrawH = 64
                End Select
            ElseIf CurPlayer = 3 Then
                Select Case Play.PeachState
                    Case 0
                        DrawH = 44
                    Case 1, 2, 3, 6
                        DrawW = 32
                        DrawH = 64
                    Case 4
                        DrawW = 44
                        DrawH = 64
                    Case 5
                        DrawW = 44
                        DrawH = 68
                End Select
            ElseIf CurPlayer = 4 Then
                Select Case Play.ToadState
                    Case 0
                        DrawH = 38
                    Case 1, 2, 3, 6
                        DrawW = 32
                        DrawH = 54
                    Case 4
                        DrawW = 42
                        DrawH = 54
                    Case 5
                        DrawW = 40
                        DrawH = 54
                End Select
            End If
        Else
            If CurPlayer = 1 Then
                Select Case Play.MarioState
                    Case 0
                        DrawH = 30
                    Case 1, 2, 3, 6
                        DrawH = 36
                    Case 4, 5
                        DrawH = 36
                End Select
            ElseIf CurPlayer = 2 Then
                Select Case Play.LuigiState
                    Case 0
                        DrawW = 28
                        DrawH = 32
                    Case 1, 2, 3, 6
                        DrawH = 36
                    Case 4, 5
                        DrawH = 36
                End Select
            ElseIf CurPlayer = 3 Then
                Select Case Play.PeachState
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
                Select Case Play.ToadState
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
        PlayerCollide = New Rectangle(PlayerX, PlayerY, PlayerW, PlayerH)

        OnGround = False
        For Each r As Rectangle In Blocks.TileRects.Where(Function(s) Play.ViewPort.Contains(s))
            If PlayerCollide.IntersectsWith(New Rectangle(r.X, r.Y - GravityLevel, r.Width, r.Height)) And IsJumping = False Then

                OnGround = True
                CheckCollision()

                If CollideDir = 0 Then
                    PlayerCollide.Y = (r.Top - PlayerH)
                    PlayerY = (r.Top - PlayerH)
                    DrawY = (r.Top - PlayerH)
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
        If PlayerCollide.Top > Level.LevelH Then
            IsTesting = False
        End If

        CheckCollision()

        MaintainLevelBounds()
    End Sub

    Public Shared Sub Jump()
        Select Case CurPlayer
            Case 1, 3, 4
                If JumpHeight >= 128 Then
                    IsJumping = False
                End If
            Case 2
                If JumpHeight >= 160 Then
                    IsJumping = False
                End If
        End Select
    End Sub

    Public Shared Sub CheckCollision()
        PlayerCollide = New Rectangle(PlayerX, PlayerY, PlayerW, PlayerH)

        CollideDir = 0

        For Each r As Rectangle In Blocks.TileRects.Where(Function(s) Play.ViewPort.Contains(s)).ToList
            Select Case MoveDir
                Case 1
                    If ((PlayerCollide.Right = r.Left) Or PlayerCollide.IntersectsWith(New Rectangle(r.X - MoveSpeed, r.Y + 2, r.Width, r.Height))) And (r.Y < PlayerCollide.Bottom) And (r.Bottom > PlayerCollide.Top) Then
                        CollideDir = 1
                    ElseIf (PlayerCollide.Right >= ViewPort.Right - 32) Then
                        CollideDir = 1
                    End If
                Case 2
                    If ((PlayerCollide.Left = r.Right) Or PlayerCollide.IntersectsWith(New Rectangle(r.X + MoveSpeed, r.Y + 2, r.Width, r.Height))) And (r.Y < PlayerCollide.Bottom) And (r.Bottom > PlayerCollide.Top) Then
                        CollideDir = 2
                    ElseIf (PlayerCollide.Left <= ViewPort.Left) Then
                        CollideDir = 2
                    End If
            End Select

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

        If Not CollideDir = dir Then
            IsMoving = True
        End If

        MaintainLevelBounds()
    End Sub

    Public Shared Sub MaintainLevelBounds()
        'Keep player from leaving level
        If Level.LevelW > 640 Or (Level.LevelH > 608 And OnGround = False) Then
            ViewPort = New Rectangle(PlayerX - (Form2.Width / 2), PlayerY - (Form2.Height / 2), Form2.Width, Form2.Height - 56)

            If ViewPort.X < 0 Then
                ViewPort.X = 0
            ElseIf ViewPort.Right > (Level.LevelW + PlayerW) Then
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
    End Sub
End Class