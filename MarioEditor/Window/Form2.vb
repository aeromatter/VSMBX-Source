Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Threading
Imports System.Drawing.Text
Imports System.Text
Imports System.Windows.Input

Public Class Form2
    Public Shared EditMode As Integer = 0
    Public Shared IsSaved As Boolean = False

    'Mouse Location Variables
    Public Shared mouselocX As Integer
    Public Shared mouselocY As Integer
    Public mouseX As Integer
    Public mouseY As Integer

    'Placement IDs | Defaults Set
    Public Shared SelectedBlock As Integer = 14
    Public Shared SelectedBGO As Integer = 1
    Public Shared SelectedNPC As Integer = 1

    'Detect Mouse Inputs
    Public MouseIsDown As Boolean = False
    Public MouseIsMoving As Boolean = False

    'Fill Data
    Public Shared Fill As Boolean = False
    Public Shared FillMode As Integer = 0
    Public Shared FillPoint As Integer

    'Mouse Location relative to editor
    Public Shared r As Rectangle

    Dim f As Block
    Dim b As Block
    Dim Parallax As Double

    'Store selected object's graphic and mask
    Public Shared TB As TextureBrush

    Public Anim(16, 16) As Integer
    Public Anim2(16, 16) As Integer

    'Load stopwatch for animation.
    Dim stopw As New Stopwatch

    'Character Loctation image storage
    Public Shared PlayerGraphic As Bitmap
    Public Shared Player2Graphic As Bitmap

    Public PlayerFX As Integer
    Public PlayerFY As Integer

    Public Shared Draw As Graphics

    'Pointer boundries
    Public PointRec As Rectangle
    Public EraseRec As Rectangle

    Dim screen As New Rectangle(0, 0, 816, 632)
    Public Shared curscreen As Rectangle
    Public PFC As PrivateFontCollection
    Public SMB3font As Font

    Public Shared Online As Boolean = False
    Public Audio As Audio

    Public Shared Function GetKeyStates(key As Key) As KeyStates

    End Function
    Private Sub Form2_Deactivate(sender As Object, e As System.EventArgs) Handles Me.Deactivate
        Me.Focus()
    End Sub

    Public Sub ResetSpawn()
        Select Case Player.PlayerID
            Case 0, 1
                Play.PlayerX = Level.P1start.X - (Player.P1.PlayerW - 28)
                Play.DrawX = Play.PlayerX
                Play.PlayerY = Level.P1start.Y - (Player.P1.PlayerH - Level.P1start.Height)
                Play.DrawY = Play.PlayerY
            Case 2, 3
                Play.PlayerX = Level.P1start.X - (Player.P1.PlayerW - 32)
                Play.DrawX = Play.PlayerX
                Play.PlayerY = Level.P1start.Y - (Player.P1.PlayerH - Level.P1start.Height)
                Play.DrawY = Play.PlayerY
        End Select
    End Sub

    Public Sub KeyboardControl()
        'Begin Testing
        If (Keyboard.GetKeyStates(Key.F5) And KeyStates.Down) > 0 Then
            Select Case MsgBox("Do you want to save the level first? Any unsaved changes will be lost.", MsgBoxStyle.YesNoCancel)
                Case MsgBoxResult.Yes
                    Save()
                    'New Rectangle(Level.P1start.X - (Play.MarioW - 28), Level.P1start.Y - (Play.MarioH - Level.P1start.Height), Play.MarioW, Play.MarioH)
                    If IsSaved = True Then
                        Play.IsTesting = True

                        Play.ShowHUD()
                        Player.SetPlayer()
                        ResetSpawn()

                        Play.MoveDir = 1
                    End If

                    Audio = New Audio
                    Audio.PlaySound(5)

                Case MsgBoxResult.No
                    Play.IsTesting = True
                    Play.ShowHUD()
                    Player.SetPlayer()

                    ResetSpawn()

                    Play.MoveDir = 1

                    Audio = New Audio
                    Audio.PlaySound(5)

            End Select
        End If

        If (Keyboard.GetKeyStates(PlayerC.RunC) And KeyStates.Down) > 0 Then
            Play.IsRunning = True
        End If

        If (Keyboard.GetKeyStates(PlayerC.RightC) And KeyStates.Down) > 0 Then
            Play.Move(1)
        End If

        If (Keyboard.GetKeyStates(PlayerC.LeftC) And KeyStates.Down) > 0 Then
            Play.Move(2)
        End If

        If (Keyboard.GetKeyStates(PlayerC.JumpC) And KeyStates.Down) > 0 Then
            If Play.JumpHeight = 0 And Play.OnGround = True And Play.JumpReleased = True Then
                Play.CheckCollision()
                Play.IsJumping = True
                Play.JumpReleased = False
            End If
        End If

        If (Keyboard.GetKeyStates(PlayerC.DownC) And KeyStates.Down) > 0 Then
            Play.CheckCollision()
            Play.IsDucking = True
        End If

        If ((Keyboard.GetKeyStates(Key.LeftCtrl) And Keyboard.GetKeyStates(Key.Q)) And KeyStates.Down) > 0 Then
            Form1.Close()
        End If

        If (Keyboard.GetKeyStates(Key.Escape) And KeyStates.Down) > 0 Then
            Play.EndTesting()
        End If

        If ((Keyboard.GetKeyStates(Key.LeftCtrl) And Keyboard.GetKeyStates(Key.S)) And KeyStates.Down) > 0 Then
            Form1.SaveFileDialog1.Filter = "Level Files|*.vlvl"
            Form1.SaveFileDialog1.InitialDirectory = Form1.FilePath & "\Worlds\"
            Form1.SaveFileDialog1.Title = "Save Level"

            Form1.SaveFileDialog1.ShowDialog()
        End If

        If ((Keyboard.GetKeyStates(Key.LeftCtrl) And Keyboard.GetKeyStates(Key.O)) And KeyStates.Down) > 0 Then
            Form1.OpenFileDialog1.Filter = "Level Files|*.vlvl"
            Form1.OpenFileDialog1.InitialDirectory = Form1.FilePath & "\Worlds\"
            Form1.OpenFileDialog1.Title = "Open Level"
            Form1.OpenFileDialog1.FileName = ""

            Form1.OpenFileDialog1.ShowDialog()
        End If

        If ((Keyboard.GetKeyStates(Key.LeftCtrl) And Keyboard.GetKeyStates(Key.N)) And KeyStates.Down) > 0 Then
            Blocks.Tiles.Clear()
            Blocks.TileRects.Clear()
            Backgrounds.BGOs.Clear()
            Backgrounds.bgorects.Clear()
            NPC.NPCsets.Clear()
            NPC.NPCrects.Clear()
            LevelSettings.BGColor = Color.Black
            Level.BGtype = 0
            Level.BG = Nothing
            Level.BG2 = Nothing
            Level.Music = ""
            LevelSettings.PlayM.StopPlayback()
            Level.Song = ""
            Level.P1start = Nothing
            Level.P2start = Nothing
            Me.Invalidate()

            Audio = New Audio
            Audio.PlaySound(1)
        End If
    End Sub

    Private Sub Form2_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        KeyboardControl()
    End Sub

    Private Sub Form2_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If Play.IsTesting = True Then

            If (Keyboard.GetKeyStates(PlayerC.RightC) And KeyStates.Down) <= 0 Then
                Play.IsMoving = False
                Play.CollideDir = 0
            End If

            If (Keyboard.GetKeyStates(PlayerC.LeftC) And KeyStates.Down) <= 0 Then
                Play.IsMoving = False
                Play.CollideDir = 0
            End If

            If (Keyboard.GetKeyStates(PlayerC.RunC) And KeyStates.Down) <= 0 Then
                Play.IsRunning = False
            End If

            If (Keyboard.GetKeyStates(PlayerC.DownC) And KeyStates.Down) <= 0 Then
                Play.IsDucking = False
            End If

            If (Keyboard.GetKeyStates(PlayerC.JumpC) And KeyStates.Down) <= 0 Then
                Play.IsJumping = False
                Play.JumpReleased = True
            End If
        End If
    End Sub

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Set drawing settings
        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)

        Me.Show()
        Me.Focus()

        Me.AutoScrollMinSize = New Size(Level.LevelW, Level.LevelH)
        Me.ResizeRedraw = True

        Try
            Blocks.GetBlock(SelectedBlock)

            PFC = New PrivateFontCollection
            PFC.AddFontFile(Form1.FilePath & "\Fonts\SMB3.ttf")
            SMB3font = New Font(PFC.Families.First, 14, FontStyle.Regular)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

        Audio = New Audio

        PlayerC.LoadControls()

        Player.SetPlayer()

        Player.P1.PlayerID = Player.PlayerID
        Player.P1.PlayerState = Player.PlayerState
        Player.P1.PlayerW = Player.PlayerW
        Player.P1.PlayerH = Player.PlayerH
        Player.P1.Graphic = Player.Graphic

        Player.PlayerID = 1

        Player.SetPlayer()

        Player.P2.PlayerID = Player.PlayerID
        Player.P2.PlayerState = Player.PlayerState
        Player.P2.PlayerW = Player.PlayerW
        Player.P2.PlayerH = Player.PlayerH
        Player.P2.Graphic = Player.Graphic

        Player.PlayerID = 0

        Audio.PlaySound(3)
    End Sub

    Public Sub AddObject()
        'Object placement
        Select Case EditMode
            Case 0
                Dim OverLap As Boolean

                If MouseIsDown = True And screen.Contains(mouselocX, mouselocY) = True Then
                    r = New Rectangle((mouseX * Blocks.TileSize), (mouseY * Blocks.TileSize) - (Blocks.TileH - Blocks.TileSize), Blocks.TileW, Blocks.TileH)

                    b.rectangle = r
                    b.X = mouseX * Blocks.TileSize
                    b.Y = mouseY * Blocks.TileSize
                End If

                If MouseIsDown = True Then
                    For i = 0 To Blocks.Tiles.Count - 1
                        If r.IntersectsWith(Blocks.Tiles(i).rectangle) And Blocks.Sizable = False Then
                            OverLap = True
                        End If
                    Next

                    For i = 0 To NPC.NPCsets.Count - 1
                        If r.IntersectsWith(NPC.NPCsets(i).rectangle) And NPC.NPCsets(i).MetroidGlass = False Then
                            OverLap = True
                        End If
                    Next
                End If

                If Blocks.Tiles.Contains(b) = False And OverLap = False And screen.Contains(mouselocX, mouselocY) = True And Fill = False And MouseIsDown = True Then
                    If b.Width > 0 And b.Height > 0 And b.ID > 0 Then
                        Blocks.TileRects.Add(b.rectangle)
                        Blocks.Tiles.Add(b)
                    End If
                ElseIf Blocks.Tiles.Contains(b) = False And OverLap = False And screen.Contains(mouselocX, mouselocY) = True And Fill = True And MouseIsDown = True Then
                    If b.Width > 0 And b.Height > 0 And b.ID > 0 Then
                        Blocks.FillBlock(b.X, b.Y, b.Width, b.Height)
                    End If
                End If

                If Fill = True Then
                    BlocksAndTiles.Button39.Text = "Fill: On"
                Else
                    BlocksAndTiles.Button39.Text = "Fill: Off"
                End If
            Case 1
                r = New Rectangle(mouseX * Blocks.TileSize, mouseY * Blocks.TileSize, Blocks.TileW, Blocks.TileH)

                If Play.IsTesting = False Then
                    If MouseIsDown = True Then
                        For Each i As Block In Blocks.Tiles.ToList
                            If i.rectangle.Contains(r) Or r.IntersectsWith(i.rectangle) Then

                                Blocks.Tiles.Remove(i)
                                Blocks.TileRects.Remove(i.rectangle)
                                Audio.PlaySound(0)
                                Me.Invalidate()
                            End If
                        Next
                    End If

                    If MouseIsDown = True Then
                        For Each bg As BGO In Backgrounds.BGOs.ToList
                            If bg.rectangle.Contains(r) Or r.IntersectsWith(bg.rectangle) Then

                                Backgrounds.BGOs.Remove(bg)
                                Backgrounds.bgorects.Remove(bg.rectangle)
                                Audio.PlaySound(1)
                                Me.Invalidate()
                            End If
                        Next
                    End If

                    If MouseIsDown = True Then
                        For Each i As NPCsets In NPC.NPCsets.ToList
                            If i.rectangle.Contains(r) Or r.IntersectsWith(i.rectangle) Then

                                NPC.NPCsets.Remove(i)
                                NPC.NPCrects.Remove(i.rectangle)
                                Audio.PlaySound(2)
                                Me.Invalidate()
                            End If
                        Next
                    End If

                ElseIf Play.IsTesting = True Then
                    If MouseIsDown = True Then
                        For Each i As Block In Blocks.Tiles.ToList
                            If i.rectangle.Contains(r) Or r.IntersectsWith(i.rectangle) Then
                                Blocks.Tiles.Remove(i)
                                Blocks.TileRects.Remove(i.rectangle)
                                Audio.PlaySound(0)
                                Me.Invalidate()
                            End If
                        Next
                    End If

                    If MouseIsDown = True Then
                        For Each bg As BGO In Backgrounds.BGOs.ToList
                            If bg.rectangle.Contains(r) Or r.IntersectsWith(bg.rectangle) Then

                                Backgrounds.BGOs.Remove(bg)
                                Backgrounds.bgorects.Remove(bg.rectangle)
                                Audio.PlaySound(1)
                                Me.Invalidate()
                            End If
                        Next
                    End If

                    If MouseIsDown = True Then
                        For Each i As NPCsets In NPC.NPCsets.ToList
                            If New Rectangle(i.X, i.Y, i.Width, i.Height).Contains(r) Or r.IntersectsWith(New Rectangle(i.X, i.Y, i.Width, i.Height)) Then

                                NPC.NPCsets.Remove(i)
                                NPC.NPCrects.Remove(New Rectangle(i.X, i.Y, i.Width, i.Height))
                                Audio.PlaySound(2)
                                Me.Invalidate()
                            End If
                        Next
                    End If
                End If

                Form1.Focus()
            Case 2
                Dim bgorect As New Rectangle

                If MouseIsDown = True And screen.Contains(mouselocX, mouselocY) = True Then
                    r = New Rectangle(mouseX * Backgrounds.BGOSize, mouseY * Backgrounds.BGOSize, Backgrounds.BGOW, Backgrounds.BGOH)
                    Backgrounds.bgo.rectangle = New Rectangle(mouseX * Backgrounds.BGOSize, mouseY * Backgrounds.BGOSize, Backgrounds.BGOW, Backgrounds.BGOH)
                    Backgrounds.bgo.X = mouseX * Backgrounds.BGOSize
                    Backgrounds.bgo.Y = mouseY * Backgrounds.BGOSize
                End If

                If MouseIsDown = True Then
                    For Each rect As Rectangle In Backgrounds.bgorects
                        bgorect = rect
                    Next
                End If

                If Backgrounds.BGOs.Contains(Backgrounds.bgo) = False And bgorect.IntersectsWith(r) = False And r.IntersectsWith(bgorect) = False And Backgrounds.bgorects.Contains(Backgrounds.bgo.rectangle) = False And screen.Contains(mouselocX, mouselocY) = True And MouseIsDown = True Then
                    Backgrounds.bgorects.Add(Backgrounds.bgo.rectangle)
                    Backgrounds.BGOs.Add(Backgrounds.bgo)
                End If
            Case 3
                r = New Rectangle(mouseX * 4, (mouseY * 32) - (Player.P1.PlayerH - 32), Player.P1.PlayerW, Player.P1.PlayerH)

                Dim OverLap As Boolean = False

                If MouseIsDown = True Then
                    For i = 0 To Blocks.TileRects.Count - 1
                        If r.IntersectsWith(Blocks.TileRects(i)) Then
                            OverLap = r.IntersectsWith(Blocks.TileRects(i))
                        End If
                    Next

                    If Level.P1start.Contains(r) = False And OverLap = False And screen.Contains(mouselocX, mouselocY) = True And Player.P1.Graphic IsNot Nothing Then
                        Level.P1start = r
                        Dim graphic As Graphics = Me.CreateGraphics()
                        graphic.DrawImage(Player.P1.Graphic, Level.P1start, New Rectangle(500, 0, Player.P1.PlayerW, Player.P1.PlayerH), GraphicsUnit.Pixel)
                    End If
                End If

            Case 4
                r = New Rectangle(mouseX * 4, (mouseY * 32) - (Player.P1.PlayerH - 32), Player.P1.PlayerW, Player.P1.PlayerH)

                Dim OverLap As Boolean = False

                If MouseIsDown = True Then
                    For i = 0 To Blocks.TileRects.Count - 1
                        If r.IntersectsWith(Blocks.TileRects(i)) Then
                            OverLap = True
                        End If
                    Next

                    If Level.P2start.Contains(r) = False And OverLap = False And screen.Contains(mouselocX, mouselocY) = True And Player.P2.Graphic IsNot Nothing Then
                        Level.P2start = r
                        Dim graphic As Graphics = Me.CreateGraphics()
                        graphic.DrawImage(Player.P2.Graphic, Level.P2start, New Rectangle(500, 0, Player.P1.PlayerW, Player.P1.PlayerH), GraphicsUnit.Pixel)
                    End If
                End If

            Case 5
                Dim OverLap As Boolean = False

                If MouseIsDown = True And screen.Contains(mouselocX, mouselocY) = True Then
                    r = New Rectangle((mouseX * NPC.NPCSize) - (NPC.NPCW - NPC.NPCSize), (mouseY * NPC.NPCSize) - (NPC.NPCH - NPC.NPCSize), NPC.NPCW, NPC.NPCH)
                    NPC.NPC.rectangle = New Rectangle(mouseX * NPC.NPCSize, (mouseY * NPC.NPCSize) - (NPC.NPCH - NPC.NPCSize), NPC.NPCW, NPC.NPCH)
                    NPC.NPC.X = mouseX * NPC.NPCSize
                    NPC.NPC.Y = mouseY * NPC.NPCSize

                End If

                If MouseIsDown = True Then
                    For i = 0 To NPC.NPCsets.Count - 1
                        If r.IntersectsWith(NPC.NPCsets(i).rectangle) And NPC.NPCsets(i).MetroidGlass = False And r.IntersectsWith(New Rectangle(NPC.NPC.X, NPC.NPC.Y, NPC.NPC.Width, NPC.NPC.Height)) Then
                            OverLap = True
                            NPC.NPC.rectangle = Nothing
                        End If
                    Next

                    For i = 0 To Blocks.TileRects.Count - 1
                        If r.IntersectsWith(Blocks.TileRects(i)) Then
                            OverLap = True
                            NPC.NPC.rectangle = Nothing
                        End If
                    Next
                End If


                If NPC.NPCsets.Contains(NPC.NPC) = False And OverLap = False And screen.Contains(mouselocX, mouselocY) = True And MouseIsDown = True Then
                    If NPC.NPC.Width > 0 And NPC.NPC.Height > 0 And NPC.NPC.ID > 0 And NPC.NPC.rectangle.IsEmpty = False Then
                        NPC.NPCrects.Add(NPC.NPC.rectangle)
                        NPC.NPCsets.Add(NPC.NPC)
                    End If
                End If
            Case 6
                r = New Rectangle(mouseX * Blocks.TileSize, mouseY * Blocks.TileSize, Blocks.TileW, Blocks.TileH)

                If MouseIsDown = True Then
                    For Each i As Block In Blocks.Tiles.ToList
                        If i.rectangle.Contains(r) Then
                            SelectedBlock = i.ID
                            AdvancedBlocks.R = i.R
                            AdvancedBlocks.G = i.G
                            AdvancedBlocks.B = i.B
                            AdvancedBlocks.Glow = i.Glow
                            Blocks.GetBlock(SelectedBlock)
                            Blocks.Tiles.Remove(i)
                            Blocks.TileRects.Remove(i.rectangle)
                            Audio.PlaySound(4)
                            Me.Invalidate()
                            EditMode = 0
                        End If
                    Next
                End If

                If MouseIsDown = True Then
                    For Each bg As BGO In Backgrounds.BGOs.ToList
                        If bg.rectangle.Contains(r) Then
                            SelectedBGO = bg.ID
                            Backgrounds.GetBGO()
                            Backgrounds.BGOs.Remove(bg)
                            Backgrounds.bgorects.Remove(bg.rectangle)
                            Audio.PlaySound(4)
                            Me.Invalidate()
                            EditMode = 2
                        End If
                    Next
                End If

                If MouseIsDown = True Then
                    For Each i As NPCsets In NPC.NPCsets.ToList
                        If i.rectangle.Contains(r) Then

                            SelectedNPC = i.ID
                            NPC.GetNPC()
                            NPC.NPCsets.Remove(i)
                            NPC.NPCrects.Remove(i.rectangle)
                            Audio.PlaySound(4)
                            Me.Invalidate()
                            EditMode = 5
                        End If
                    Next
                End If
        End Select

        PointRec = New Rectangle(mouselocX, mouselocY, My.Resources.Pointer.Width, My.Resources.Pointer.Height)
        EraseRec = New Rectangle(mouselocX, mouselocY, My.Resources.Eraser.Width, My.Resources.Eraser.Height)

        Debug.MouseLoc(mouseX, mouseY)
    End Sub

    Private Sub Form2_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        AddObject()
    End Sub

    Private Sub Form2_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        MouseIsDown = True
    End Sub

    Private Sub Form2_MouseEnter(sender As Object, e As System.EventArgs) Handles Me.MouseEnter
        'Reset pointer
        Cursor.Hide()
        r = Nothing
        b.rectangle = Nothing
        Backgrounds.bgo.rectangle = Nothing

        'Get BGO mode
        Backgrounds.ForeGround = Not BGOs_Form.RadioButton1.Checked

        Backgrounds.ForeGround = BGOs_Form.RadioButton3.Checked

        If BGOs_Form.RadioButton2.Checked = True Then
            Backgrounds.ForeGround = (SelectedBGO = 51 Or SelectedBGO = 52)
        End If

        Select Case EditMode
            Case 0
                'Get currently selected block and its settings.
                Blocks.GetBlock(SelectedBlock)

                b.IMG = TB.Image
                b.Width = Blocks.TileW
                b.Height = Blocks.TileH
                b.ID = SelectedBlock
                b.gfxWidth = Blocks.gfxWidth
                b.gfxHeight = Blocks.gfxHeight
                b.TotalFrames = Blocks.TotalFrames
                b.SizeW = Blocks.SizeW
                b.SizeH = Blocks.SizeH
                b.FrameSpeed = Blocks.FrameSpeed
                b.Lava = Blocks.Lava
                b.R = AdvancedBlocks.R
                b.G = AdvancedBlocks.G
                b.B = AdvancedBlocks.B
                b.Glow = AdvancedBlocks.Glow
                b.Breakable = Blocks.Breakable

                b.Animated = Blocks.Animated
                b.Invisible = Blocks.Invisible
                b.Slip = Blocks.Slippery

                'Maintain positive integer only data for sizeables
                Try
                    If Convert.ToInt32(BlocksAndTiles.TextBox2.Text) > 0 And Convert.ToInt32(BlocksAndTiles.TextBox3.Text) > 0 Then
                        Blocks.SizeW = Convert.ToInt32(BlocksAndTiles.TextBox2.Text)
                        Blocks.SizeH = Convert.ToInt32(BlocksAndTiles.TextBox3.Text)
                    Else
                        MsgBox("Sizable blocks must have positive values.", MsgBoxStyle.Exclamation)
                        BlocksAndTiles.TextBox2.Text = 1 And BlocksAndTiles.TextBox3.Text = 1
                        Blocks.SizeW = 1 And Blocks.SizeH = 1
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message & vbNewLine & "Sizable block size has been reset.", MsgBoxStyle.Exclamation)
                    BlocksAndTiles.TextBox2.Text = 1 And BlocksAndTiles.TextBox3.Text = 1
                    Blocks.SizeW = 1 And Blocks.SizeH = 1
                End Try
            Case 2
                'Get currently selected BGO and its settings.
                Backgrounds.GetBGO()

                Backgrounds.bgo.IMG = TB.Image
                Backgrounds.bgo.Width = Backgrounds.BGOW
                Backgrounds.bgo.Height = Backgrounds.BGOH
                Backgrounds.bgo.ID = SelectedBGO
                Backgrounds.bgo.gfxWidth = Backgrounds.gfxWidth
                Backgrounds.bgo.gfxHeight = Backgrounds.gfxHeight
                Backgrounds.bgo.TotalFrames = Backgrounds.TotalFrames
                Backgrounds.bgo.FrameSpeed = Backgrounds.FrameSpeed
                Backgrounds.bgo.ForeGround = Backgrounds.ForeGround

                Backgrounds.bgo.Animated = Backgrounds.Animated
            Case 5
                'Get currently selected NPC and its settings.
                NPC.GetNPC()

                NPC.NPC.IMG = TB.Image
                NPC.NPC.Width = NPC.NPCW
                NPC.NPC.Height = NPC.NPCH
                NPC.NPC.ID = SelectedNPC
                NPC.NPC.gfxWidth = NPC.gfxWidth
                NPC.NPC.gfxHeight = NPC.gfxHeight
                NPC.NPC.TotalFrames = NPC.TotalFrames
                NPC.NPC.FrameSpeed = NPC.FrameSpeed
                NPC.NPC.FrameStyle = NPC.FrameStyle
                NPC.NPC.AI = NPC.AI
                NPC.NPC.Animated = NPC.Animated
                NPC.NPC.Direction = NPC.Direction
                NPC.NPC.HasGravity = NPC.HasGravity
                NPC.NPC.MSG = NPC.Message
                NPC.NPC.MoveSpeed = NPC.MoveSpeed
                NPC.NPC.MetroidGlass = NPC.MetroidGlass
                NPC.NPC.Testing = Play.IsTesting
                NPC.NPC.NPCcollide = NPC.NPCcollide
        End Select
    End Sub

    Private Sub Form2_MouseLeave(sender As Object, e As System.EventArgs) Handles Me.MouseLeave
        'Reset windows cursor
        Cursor.Show()
    End Sub

    Private Sub Form2_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        MouseIsMoving = True
        'Get mouse data relative to windows
        mouselocX = e.X
        mouselocY = e.Y

        'Get mouse data relative to level
        If Play.IsTesting = False Then
            Select Case EditMode
                Case 0, 1, 2, 5, 6, 7
                    mouseX = Math.Floor((mouselocX + (Me.AutoScrollPosition.X * -1)) / 32)
                    mouseY = Math.Floor((mouselocY + (Me.AutoScrollPosition.Y * -1)) / 32)
                Case Else
                    mouseX = Math.Floor((mouselocX + (Me.AutoScrollPosition.X * -1)) / 4)
                    mouseY = Math.Floor((mouselocY + (Me.AutoScrollPosition.Y * -1)) / 32)
            End Select
        Else
            Select Case EditMode
                Case 0, 1, 2, 5, 6, 7
                    mouseX = Math.Floor((mouselocX + (Play.ViewPort.X)) / 32)
                    mouseY = Math.Floor((mouselocY + (Play.ViewPort.Y)) / 32)
                Case Else
                    mouseX = Math.Floor((mouselocX + (Play.ViewPort.X)) / 4)
                    mouseY = Math.Floor((mouselocY + (Play.ViewPort.Y)) / 32)
            End Select
        End If

        AddObject()
    End Sub

    Private Sub Form2_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        MouseIsDown = False
    End Sub

    Protected Overrides Sub OnLostFocus(e As System.EventArgs)
        MyBase.OnLostFocus(e)
    End Sub

    Private Sub Form2_MouseWheel(sender As Object, e As Windows.Forms.MouseEventArgs) Handles Me.MouseWheel
        'Get mouse data relative to level
        If Play.IsTesting = False Then
            Select Case EditMode
                Case 0, 1, 2, 5, 6, 7
                    mouseX = Math.Floor((mouselocX + (Me.AutoScrollPosition.X * -1)) / 32)
                    mouseY = Math.Floor((mouselocY + (Me.AutoScrollPosition.Y * -1)) / 32)
                Case Else
                    mouseX = Math.Floor((mouselocX + (Me.AutoScrollPosition.X * -1)) / 4)
                    mouseY = Math.Floor((mouselocY + (Me.AutoScrollPosition.Y * -1)) / 32)
            End Select
        Else
            Select Case EditMode
                Case 0, 1, 2, 5, 6, 7
                    mouseX = Math.Floor((mouselocX + (Play.ViewPort.X)) / 32)
                    mouseY = Math.Floor((mouselocY + (Play.ViewPort.Y)) / 32)
                Case Else
                    mouseX = Math.Floor((mouselocX + (Play.ViewPort.X)) / 4)
                    mouseY = Math.Floor((mouselocY + (Play.ViewPort.Y)) / 32)
            End Select
        End If

        AddObject()
    End Sub

    Private Sub Form2_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Draw = e.Graphics
        'Set Rendering
        Draw.CompositingQuality = Drawing2D.CompositingQuality.HighSpeed
        Draw.SmoothingMode = Drawing2D.SmoothingMode.HighSpeed
        Draw.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighSpeed
        Draw.InterpolationMode = Drawing2D.InterpolationMode.Low

        'Clear OverDraw
        Draw.Clear(LevelSettings.BGColor)

        'BG Orientation
        Dim bg As Graphics = Draw

        If Play.IsTesting = True Then
            bg.TranslateTransform(Play.ViewPort.X * -1, Play.ViewPort.Y * -1, Drawing2D.MatrixOrder.Prepend)
        Else
            If Not Level.BGtype = 6 Then
                bg.TranslateTransform(Me.AutoScrollPosition.X, Me.AutoScrollPosition.Y)
            Else
                bg.TranslateTransform(0, Me.AutoScrollPosition.Y)
            End If
        End If

        Dim ImgA As New ImageAttributes

        If Level.Brightness < 100 Then
            Dim CM As ColorMatrix = New ColorMatrix(New Single()() _
            { _
            New Single() {Level.Brightness / 100, 0.0, 0.0, 0.0, 0.0}, _
            New Single() {0.0, Level.Brightness / 100, 0.0, 0.0, 0.0}, _
            New Single() {0.0, 0.0, Level.Brightness / 100, 0.0, 0.0}, _
            New Single() {0.0, 0.0, 0.0, 1.0, 0.0}, _
            New Single() {0.0, 0.0, 0.0, 0.0, 1.0}})

            ImgA.SetColorMatrix(CM)
        End If

        Select Case Level.BGtype
            Case 1
                For x = 0 To (Level.LevelW / Level.BG.Width) + (Level.LevelW / Level.BG.Width)
                    If Draw.IsVisible(New Rectangle(x * Level.BG.Width, Level.LevelH - (Level.BG.Height), Level.BG.Width, Level.BG.Height)) = True Then
                        bg.DrawImage(Level.BG, New Rectangle(x * Level.BG.Width, Level.LevelH - (Level.BG.Height), Level.BG.Width, Level.BG.Height), 0, 0, Level.BG.Width, Level.BG.Height, GraphicsUnit.Pixel, ImgA)
                    End If
                Next
                For x = 0 To (Level.LevelW / Level.BG2.Width) + (Level.LevelW / Level.BG2.Width)
                    If Draw.IsVisible(New Rectangle(x * Level.BG2.Width, Level.LevelH - ((Level.BG.Height + Level.BG2.Height)), Level.BG2.Width, Level.BG2.Height)) = True Then
                        bg.DrawImage(Level.BG2, New Rectangle(x * Level.BG2.Width, Level.LevelH - ((Level.BG.Height + Level.BG2.Height)), Level.BG2.Width, Level.BG2.Height), 0, 0, Level.BG2.Width, Level.BG2.Height, GraphicsUnit.Pixel, ImgA)
                    End If
                Next
            Case 2
                For x = 0 To (Level.LevelW / Level.BG.Width) + (Level.LevelW / Level.BG.Width)
                    If Draw.IsVisible(New Rectangle(x * Level.BG.Width, Level.LevelH - (Level.BG.Height), Level.BG.Width, Level.BG.Height)) = True Then
                        bg.DrawImage(Level.BG, New Rectangle(x * Level.BG.Width, Level.LevelH - (Level.BG.Height), Level.BG.Width, Level.BG.Height), 0, 0, Level.BG.Width, Level.BG.Height, GraphicsUnit.Pixel, ImgA)
                    End If
                Next
            Case 3
                For x = 0 To (Level.LevelW / Level.BG.Width) + (Level.LevelW / Level.BG.Width)
                    If Draw.IsVisible(New Rectangle(x * Level.BG.Width, Level.LevelH - (Level.BG.Height / 4), Level.BG.Width, Level.BG.Height / 4)) = True Then
                        bg.DrawImage(Level.BG, New Rectangle(x * Level.BG.Width, Level.LevelH - (Level.BG.Height / 4), Level.BG.Width, Level.BG.Height / 4), 0, Convert.ToInt32((Level.BG.Height / 4) * Anim(8, 4)), Level.BG.Width, Convert.ToInt32(Level.BG.Height / 4), GraphicsUnit.Pixel, ImgA)
                    End If

                    If Draw.IsVisible(New Rectangle(x * Level.BG2.Width, Level.LevelH - (((Level.BG.Height / 4) + Level.BG2.Height)), Level.BG2.Width, Level.BG2.Height)) = True Then
                        bg.DrawImage(Level.BG2, New Rectangle(x * Level.BG2.Width, Level.LevelH - (((Level.BG.Height / 4) + Level.BG2.Height)), Level.BG2.Width, Level.BG2.Height), 0, 0, Level.BG2.Width, Level.BG2.Height, GraphicsUnit.Pixel, ImgA)
                    End If
                Next
            Case 4
                For x = 0 To (Level.LevelW / Level.BG.Width) + (Level.LevelW / Level.BG.Width)
                    For y = 0 To (Level.LevelH / Level.BG.Height) + (Level.LevelH / Level.BG.Height)
                        If Draw.IsVisible(New Rectangle(x * Level.BG.Width, y * Level.BG.Height, Level.BG.Width, Level.BG.Height)) = True Then
                            bg.DrawImage(Level.BG, New Rectangle(x * Level.BG.Width, y * Level.BG.Height, Level.BG.Width, Level.BG.Height), 0, 0, Level.BG.Width, Level.BG.Height, GraphicsUnit.Pixel, ImgA)
                        End If
                    Next
                Next
            Case 5
                For x = 0 To (Level.LevelW / Level.BG.Width) + (Level.LevelW / Level.BG.Width)
                    For y = 0 To (Level.LevelH / (Level.BG.Height / 2)) + (Level.LevelH / (Level.BG.Height / 2))
                        If Draw.IsVisible(New Rectangle(x * Level.BG.Width, 0, Level.BG.Width, Level.BG.Height / 2)) = True Then
                            bg.DrawImage(Level.BG, New Rectangle(x * Level.BG.Width, 0, Level.BG.Width, Level.BG.Height / 2), 0, 0, Level.BG.Width, Level.BG.Height, GraphicsUnit.Pixel, ImgA)
                        End If

                        If Draw.IsVisible(New Rectangle(x * Level.BG.Width, y * (Level.BG.Height / 2), Level.BG.Width, Level.BG.Height / 2)) = True Then
                            bg.DrawImage(Level.BG, New Rectangle(x * Level.BG.Width, y * (Level.BG.Height / 2), Level.BG.Width, Level.BG.Height / 2), 0, 0, Level.BG.Width, Level.BG.Height, GraphicsUnit.Pixel, ImgA)
                        End If
                    Next
                Next
            Case 6
                For x = 0 To (Level.LevelW / Level.BG.Width) + (Level.LevelW / Level.BG.Width)
                    If Draw.IsVisible(New Rectangle(x * Level.BG.Width, ((Level.LevelH - Level.BG.Height) / (Level.HeightInc * 32)) * Math.Abs(Me.AutoScrollPosition.Y), Level.BG.Width, Level.BG.Height)) = True And HorizontalScroll.Visible = True Then
                        bg.DrawImage(Level.BG, New Rectangle(x * Level.BG.Width, ((Level.LevelH - Level.BG.Height) / (Level.HeightInc * 32)) * Math.Abs(Me.AutoScrollPosition.Y), Level.BG.Width, Level.BG.Height), 0, 0, Level.BG.Width, Level.BG.Height, GraphicsUnit.Pixel, ImgA)
                    ElseIf Draw.IsVisible(New Rectangle(x * Level.BG.Width, (Level.BG.Height - Me.Height) / Level.LevelH, Level.BG.Width, Level.BG.Height)) = True And HorizontalScroll.Visible = False Then
                        bg.DrawImage(Level.BG, New Rectangle(x * Level.BG.Width, (Level.BG.Height - Me.Height) / Level.LevelH, Level.BG.Width, Level.BG.Height), 0, 0, Level.BG.Width, Level.BG.Height, GraphicsUnit.Pixel, ImgA)
                    End If
                Next
                'Label1.Text = Level.HeightInc * 32
            Case 7
                For x = 0 To (Level.LevelW / Level.BG.Width) + (Level.LevelW / Level.BG.Width)
                    If Draw.IsVisible(New Rectangle(x * Level.BG.Width, Level.LevelH - ((Level.BG.Height + Level.BG.Height)), Level.BG.Width, Level.BG.Height)) = True Then
                        bg.DrawImage(Level.BG, New Rectangle(x * Level.BG.Width, Level.LevelH - ((Level.BG.Height + Level.BG.Height)), Level.BG.Width, Level.BG.Height), 0, 0, Level.BG.Width, Level.BG.Height, GraphicsUnit.Pixel, ImgA)
                    End If
                Next
                For x = 0 To (Level.LevelW / Level.BG2.Width) + (Level.LevelW / Level.BG.Width)
                    If Draw.IsVisible(New Rectangle(x * Level.BG2.Width, Parallax / ((Level.LevelH / 32) / (Level.BG.Height / (Level.LevelH / 32))), Level.BG2.Width, Level.BG2.Height)) = True Then
                        bg.DrawImage(Level.BG2, New Rectangle(x * Level.BG2.Width, Parallax / ((Level.LevelH / 32) / (Level.BG.Height / (Level.LevelH / 32))), Level.BG2.Width, Level.BG2.Height), 0, 0, Level.BG2.Width, Level.BG2.Height, GraphicsUnit.Pixel, ImgA)
                    End If
                Next
            Case 8
                For x = 0 To (Level.LevelW / Level.BG.Width) + (Level.LevelW / Level.BG.Width)
                    If Draw.IsVisible(New Rectangle(x * Level.BG.Width, Me.AutoScrollPosition.Y * ((((Level.BG.Height / 4) - Me.Height) + 34) / ((14 + SystemInformation.HorizontalScrollBarHeight) + (Level.HeightInc * 32))), Level.BG.Width, Level.BG.Height / 4)) = True And HorizontalScroll.Visible = True Then
                        bg.DrawImage(Level.BG, New Rectangle(x * Level.BG.Width, Me.AutoScrollPosition.Y * ((((Level.BG.Height / 4) - Me.Height) + 34) / ((14 + SystemInformation.HorizontalScrollBarHeight) + (Level.HeightInc * 32))), Level.BG.Width, Level.BG.Height / 4), New Rectangle(0, (Level.BG.Height / 4) * Anim(8, 4), Level.BG.Width, (Level.BG.Height / 4)), GraphicsUnit.Pixel)
                    ElseIf Draw.IsVisible(New Rectangle(x * Level.BG.Width, Me.AutoScrollPosition.Y * ((((Level.BG.Height / 4) - Me.Height) + 34) / (14 + (Level.HeightInc * 32))), Level.BG.Width, Level.BG.Height / 4)) = True And HorizontalScroll.Visible = False Then
                        bg.DrawImage(Level.BG, New Rectangle(x * Level.BG.Width, Me.AutoScrollPosition.Y * ((((Level.BG.Height / 4) - Me.Height) + 34) / (14 + (Level.HeightInc * 32))), Level.BG.Width, Level.BG.Height / 4), 0, Convert.ToInt32((Level.BG.Height / 4) * Anim(8, 4)), Level.BG.Width, Convert.ToInt32(Level.BG.Height / 4), GraphicsUnit.Pixel, ImgA)
                    End If
                Next
        End Select

        ImgA.Dispose()
        bg.ResetTransform()

        If Grid.GridOn = True Then
            For X = 0 To Math.Ceiling(Me.Width / 32)
                For Y = 0 To Math.Ceiling(Me.Height / 32)
                    Dim penc As New Pen(Grid.GColor)
                    Draw.DrawRectangle(penc, New Rectangle(X * 32, Y * 32, 32, 32))
                Next
            Next
        End If

        Dim graphic As Graphics = Draw

        If Play.IsTesting = True Then
            graphic.TranslateTransform(Play.ViewPort.X * -1, Play.ViewPort.Y * -1, Drawing2D.MatrixOrder.Prepend)
        Else
            graphic.TranslateTransform(Me.AutoScrollPosition.X, Me.AutoScrollPosition.Y, Drawing2D.MatrixOrder.Prepend)
        End If

        'BG BGOs
        For Each i As BGO In Backgrounds.BGOs.ToList
            If graphic.IsVisible(i.rectangle) = True And i.ForeGround = False Then

                If i.Animated = True Then
                    graphic.DrawImage(i.IMG, i.rectangle, New Rectangle(0, i.Height * Anim(i.FrameSpeed, i.TotalFrames), i.gfxWidth, i.Height), GraphicsUnit.Pixel)
                Else
                    graphic.DrawImage(i.IMG, i.rectangle, New Rectangle(0, 0, i.gfxWidth, i.gfxHeight), GraphicsUnit.Pixel)
                End If

            End If
        Next

        'Draw Player Spawn
        If Play.IsTesting = False Then

            If Player.P1.Graphic IsNot Nothing And Level.P1start.IsEmpty = False Then
                Select Case Player.PlayerID
                    Case 0, 1
                        graphic.DrawImage(Player.P1.Graphic, New Rectangle(Level.P1start.X - (Player.P1.PlayerW - 28), Level.P1start.Y - (Player.P1.PlayerH - Level.P1start.Height), Player.P1.PlayerW, Player.P1.PlayerH), New Rectangle(500, 0, Player.P1.PlayerW, Player.P1.PlayerH), GraphicsUnit.Pixel)
                    Case 2, 3
                        graphic.DrawImage(Player.P1.Graphic, New Rectangle(Level.P1start.X - (Player.P1.PlayerW - 32), Level.P1start.Y - (Player.P1.PlayerH - Level.P1start.Height), Player.P1.PlayerW, Player.P1.PlayerH), New Rectangle(500, 0, Player.P1.PlayerW, Player.P1.PlayerH), GraphicsUnit.Pixel)
                End Select
            End If

            If Player.P2.Graphic IsNot Nothing And Level.P2start.IsEmpty = False Then
                Select Case Player.Player2ID
                    Case 0, 1
                        graphic.DrawImage(Player.P2.Graphic, New Rectangle(Level.P2start.X - (Player.P2.PlayerW - 28), Level.P2start.Y - (Player.P2.PlayerH - Level.P2start.Height), Player.P2.PlayerW, Player.P2.PlayerH), New Rectangle(500, 0, Player.P2.PlayerW, Player.P2.PlayerH), GraphicsUnit.Pixel)
                    Case 2, 3
                        graphic.DrawImage(Player.P2.Graphic, New Rectangle(Level.P2start.X - (Player.P2.PlayerW - 32), Level.P2start.Y - (Player.P2.PlayerH - Level.P2start.Height), Player.P2.PlayerW, Player.P2.PlayerH), New Rectangle(500, 0, Player.P2.PlayerW, Player.P2.PlayerH), GraphicsUnit.Pixel)
                End Select
            End If

        End If

        'Draw/Animate Blocks

        For Each i As Block In Blocks.Tiles.ToList
            If graphic.IsVisible(i.rectangle) = True Then
                Dim ImgB As New ImageAttributes
                Dim CM2 As ColorMatrix = New ColorMatrix(New Single()() _
                { _
                New Single() {i.R / 255, 0.0, 0.0, 0.0, 0.0}, _
                New Single() {0.0, i.G / 255, 0.0, 0.0, 0.0}, _
                New Single() {0.0, 0.0, i.B / 255, 0.0, 0.0}, _
                New Single() {0.0, 0.0, 0.0, i.Glow / 100, 0.0}, _
                New Single() {0.0, 0.0, 0.0, 0.0, 0.2}})
                ImgB.SetColorMatrix(CM2)

                Select Case i.Invisible
                    Case False
                        If AdvancedBlocks.GraphicChanged = False Then
                            If i.Animated = True Then
                                graphic.DrawImage(i.IMG, i.rectangle, New Rectangle(0, i.Height * Anim(i.FrameSpeed, i.TotalFrames), i.gfxWidth, i.Height), GraphicsUnit.Pixel)
                            Else
                                graphic.DrawImage(i.IMG, i.rectangle, New Rectangle(0, 0, i.gfxWidth, i.gfxHeight), GraphicsUnit.Pixel)
                            End If
                        Else
                            If i.Animated = True Then
                                graphic.DrawImage(i.IMG, i.rectangle, 0, Convert.ToInt32(i.Height * Anim(i.FrameSpeed, i.TotalFrames)), i.gfxWidth, i.Height, GraphicsUnit.Pixel, ImgB)
                            Else
                                graphic.DrawImage(i.IMG, i.rectangle, 0, 0, i.gfxWidth, i.gfxHeight, GraphicsUnit.Pixel, ImgB)
                            End If
                        End If
                    Case True
                        If Play.IsTesting = False Then
                            If AdvancedBlocks.GraphicChanged = False Then
                                If i.Animated = True Then
                                    graphic.DrawImage(i.IMG, i.rectangle, New Rectangle(0, i.Height * Anim(i.FrameSpeed, i.TotalFrames), i.gfxWidth, i.Height), GraphicsUnit.Pixel)
                                Else
                                    graphic.DrawImage(i.IMG, i.rectangle, New Rectangle(0, 0, i.gfxWidth, i.gfxHeight), GraphicsUnit.Pixel)
                                End If
                            Else
                                If i.Animated = True Then
                                    graphic.DrawImage(i.IMG, i.rectangle, 0, Convert.ToInt32(i.Height * Anim(i.FrameSpeed, i.TotalFrames)), i.gfxWidth, i.Height, GraphicsUnit.Pixel, ImgB)
                                Else
                                    graphic.DrawImage(i.IMG, i.rectangle, 0, 0, i.gfxWidth, i.gfxHeight, GraphicsUnit.Pixel, ImgB)
                                End If
                            End If
                        End If
                End Select
            End If
        Next

        Debug.TotalObjBlocks = Blocks.TileRects.Where(Function(c) e.Graphics.IsVisible(c)).Count

        'Animate NPCs
        For Each i As NPCsets In NPC.NPCsets
            If graphic.IsVisible(New Rectangle(i.X, i.Y, i.Width, i.Height)) = True Then
                If i.Animated = True Then
                    If Play.IsTesting = False Then
                        Select Case i.FrameStyle
                            Case 0
                                graphic.DrawImage(i.IMG, i.rectangle, New Rectangle(0, i.Height * Anim(i.FrameSpeed, i.TotalFrames), i.gfxWidth, i.Height), GraphicsUnit.Pixel)
                            Case 1
                                If i.Direction = 2 Then
                                    graphic.DrawImage(i.IMG, i.rectangle, New Rectangle(0, i.Height * Anim(i.FrameSpeed, i.TotalFrames), i.gfxWidth, i.Height), GraphicsUnit.Pixel)
                                End If

                                If i.Direction = 1 Then
                                    graphic.DrawImage(i.IMG, i.rectangle, New Rectangle(0, i.Height * Anim2(i.FrameSpeed, i.TotalFrames), i.gfxWidth, i.Height), GraphicsUnit.Pixel)
                                End If
                            Case 2

                        End Select
                    ElseIf Play.IsTesting = True Then
                        Select Case i.FrameStyle
                            Case 0
                                graphic.DrawImage(i.IMG, New Rectangle(i.X, i.Y, i.Width, i.Height), New Rectangle(0, i.Height * Anim(i.FrameSpeed, i.TotalFrames), i.gfxWidth, i.Height), GraphicsUnit.Pixel)
                            Case 1
                                If i.Direction = 2 Then
                                    graphic.DrawImage(i.IMG, New Rectangle(i.X, i.Y, i.Width, i.Height), New Rectangle(0, i.Height * Anim(i.FrameSpeed, i.TotalFrames), i.gfxWidth, i.Height), GraphicsUnit.Pixel)
                                End If

                                If i.Direction = 1 Then
                                    graphic.DrawImage(i.IMG, New Rectangle(i.X, i.Y, i.Width, i.Height), New Rectangle(0, i.Height * Anim2(i.FrameSpeed, i.TotalFrames), i.gfxWidth, i.Height), GraphicsUnit.Pixel)
                                End If
                            Case 2

                        End Select
                    End If
                ElseIf i.ID >= 1 And i.Animated = False Then
                    If Play.IsTesting = False Then
                        Select Case i.FrameStyle
                            Case 0
                                graphic.DrawImage(i.IMG, i.rectangle, New Rectangle(0, 0, i.gfxWidth, i.Height), GraphicsUnit.Pixel)
                            Case 1
                                If i.Direction = 2 Then
                                    graphic.DrawImage(i.IMG, i.rectangle, New Rectangle(0, 0, i.gfxWidth, i.Height), GraphicsUnit.Pixel)
                                ElseIf i.Direction = 1 Then
                                    graphic.DrawImage(i.IMG, i.rectangle, New Rectangle(0, i.gfxHeight, i.gfxWidth, i.Height), GraphicsUnit.Pixel)
                                End If
                            Case 2
                                If i.Direction = 2 Then
                                    graphic.DrawImage(i.IMG, i.rectangle, New Rectangle(0, 0, i.gfxWidth, i.Height), GraphicsUnit.Pixel)
                                ElseIf i.Direction = 1 Then
                                    graphic.DrawImage(i.IMG, i.rectangle, New Rectangle(0, (i.gfxHeight / 2) / 2, i.gfxWidth, i.Height), GraphicsUnit.Pixel)
                                End If
                            Case 3
                                If i.Direction = 2 Then
                                    graphic.DrawImage(i.IMG, i.rectangle, New Rectangle(0, 0, i.gfxWidth, i.Height), GraphicsUnit.Pixel)
                                ElseIf i.Direction = 1 Then
                                    graphic.DrawImage(i.IMG, i.rectangle, New Rectangle(0, i.gfxHeight / 3, i.gfxWidth, i.Height), GraphicsUnit.Pixel)
                                End If
                        End Select
                    ElseIf Play.IsTesting = True Then
                        Select Case i.FrameStyle
                            Case 0
                                graphic.DrawImage(i.IMG, New Rectangle(i.X, i.Y, i.Width, i.Height), New Rectangle(0, 0, i.Width, i.Height), GraphicsUnit.Pixel)
                            Case 1
                                If i.Direction = 2 Then
                                    graphic.DrawImage(i.IMG, New Rectangle(i.X, i.Y, i.Width, i.Height), New Rectangle(0, 0, i.Width, i.Height), GraphicsUnit.Pixel)
                                ElseIf i.Direction = 1 Then
                                    graphic.DrawImage(i.IMG, New Rectangle(i.X, i.Y, i.Width, i.Height), New Rectangle(0, i.Height, i.Width, i.Height), GraphicsUnit.Pixel)
                                End If
                            Case 2
                                If i.Direction = 2 Then
                                    graphic.DrawImage(i.IMG, New Rectangle(i.X, i.Y, i.Width, i.Height), New Rectangle(0, 0, i.gfxWidth, i.Height), GraphicsUnit.Pixel)
                                ElseIf i.Direction = 1 Then
                                    graphic.DrawImage(i.IMG, New Rectangle(i.X, i.Y, i.Width, i.Height), New Rectangle(0, (i.gfxHeight / 2) / 2, i.gfxWidth, i.Height), GraphicsUnit.Pixel)
                                End If
                            Case 3
                                If i.Direction = 2 Then
                                    graphic.DrawImage(i.IMG, New Rectangle(i.X, i.Y, i.Width, i.Height), New Rectangle(0, 0, i.gfxWidth, i.Height), GraphicsUnit.Pixel)
                                ElseIf i.Direction = 1 Then
                                    graphic.DrawImage(i.IMG, New Rectangle(i.X, i.Y, i.Width, i.Height), New Rectangle(0, i.gfxHeight / 3, i.gfxWidth, i.Height), GraphicsUnit.Pixel)
                                End If
                        End Select
                    End If
                End If
            End If
        Next

        Debug.TotalObjNPCs = NPC.NPCrects.Where(Function(c) e.Graphics.IsVisible(c)).Count

        graphic.ResetTransform()
        Draw.ResetTransform()

        Draw.TranslateTransform(Play.ViewPort.X * -1, Play.ViewPort.Y * -1, Drawing2D.MatrixOrder.Prepend)

        If Play.IsTesting = True Then
            Dim ImgC As New ImageAttributes

            If Play.IsStarman = True Then
                Dim col As New Random
                Dim CM3 As ColorMatrix = New ColorMatrix(New Single()() _
                { _
                New Single() {Math.Abs(col.Next(1, 255) / 80), 0.0, 0.0, 0.0, 0.0}, _
                New Single() {0.0, Math.Abs(col.Next(1, 255) / 80), 0.0, 0.0, 0.0}, _
                New Single() {0.0, 0.0, Math.Abs(col.Next(1, 255) / 60), 0.0, 0.0}, _
                New Single() {0.0, 0.0, 0.0, 1.0, 0.0}, _
                New Single() {0.0, 0.0, 0.0, 0.0, 1.0}})
                ImgC.SetColorMatrix(CM3)
            End If

            Draw.ResetTransform()
            Draw.TranslateTransform(Play.ViewPort.X * -1, Play.ViewPort.Y * -1, Drawing2D.MatrixOrder.Prepend)

            If Player.P1.Graphic IsNot Nothing Then
                Draw.DrawImage(Player.P1.Graphic, New Rectangle(Play.DrawX, Play.DrawY + (Player.P1.PlayerH - Play.DrawH), Player.P1.PlayerW, Play.DrawH), PlayerFX, PlayerFY, Player.P1.PlayerW, Play.DrawH, GraphicsUnit.Pixel, ImgC)
            Else
                Player.SetPlayer()
            End If

        End If
        Draw.ResetTransform()

        'FG BGOs
        If Play.IsTesting = True Then
            graphic.TranslateTransform(Play.ViewPort.X * -1, Play.ViewPort.Y * -1, Drawing2D.MatrixOrder.Prepend)
        Else
            graphic.TranslateTransform(Me.AutoScrollPosition.X, Me.AutoScrollPosition.Y, Drawing2D.MatrixOrder.Prepend)
        End If

        For Each i As BGO In Backgrounds.BGOs.ToList
            If graphic.IsVisible(i.rectangle) = True Then
                If i.Animated = True And i.ForeGround = True Then
                    graphic.DrawImage(i.IMG, i.rectangle, New Rectangle(0, i.Height * Anim(i.FrameSpeed, i.TotalFrames), i.gfxWidth, i.Height), GraphicsUnit.Pixel)
                End If

                If i.Animated = False And i.ID > 0 And i.ForeGround = True Then
                    graphic.DrawImage(i.IMG, i.rectangle, New Rectangle(0, 0, i.gfxWidth, i.gfxHeight), GraphicsUnit.Pixel)
                End If
            End If
        Next

        If MouseIsMoving = True Then
            Select Case EditMode
                Case 0
                    r = New Rectangle((mouseX * Blocks.TileSize), (mouseY * Blocks.TileSize) - (Blocks.TileH - Blocks.TileSize), Blocks.TileW, Blocks.TileH)

                    If Blocks.Animated = True Then
                        graphic.DrawImage(TB.Image, r, New Rectangle(0, Blocks.TileH * Anim(Blocks.FrameSpeed, Blocks.TotalFrames), Blocks.gfxWidth, Blocks.TileH), GraphicsUnit.Pixel)
                    Else
                        graphic.DrawImage(TB.Image, r, New Rectangle(0, 0, Blocks.gfxWidth, Blocks.gfxHeight), GraphicsUnit.Pixel)
                    End If
                Case 2
                    r = New Rectangle(mouseX * 32, mouseY * 32, Backgrounds.BGOW, Backgrounds.BGOH)

                    If Backgrounds.Animated = True Then
                        graphic.DrawImage(TB.Image, r, New Rectangle(0, Backgrounds.BGOH * Anim(Backgrounds.FrameSpeed, Backgrounds.TotalFrames), Backgrounds.gfxWidth, Backgrounds.BGOH), GraphicsUnit.Pixel)
                    Else
                        graphic.DrawImage(TB.Image, r, New Rectangle(0, 0, Backgrounds.gfxWidth, Backgrounds.gfxHeight), GraphicsUnit.Pixel)
                    End If
                Case 3
                    If Player.P1.Graphic IsNot Nothing Then
                        graphic.DrawImage(Player.P1.Graphic, New Rectangle((mouseX * 4), (mouseY * 32) - (Player.P1.PlayerH - 32), Player.P1.PlayerW, Player.P1.PlayerH), New Rectangle(500, 0, Player.P1.PlayerW, Player.P1.PlayerH), GraphicsUnit.Pixel)

                        Else
                            Player.SetPlayer()
                        End If
                Case 4
                    If Player.P2.Graphic IsNot Nothing Then
                        graphic.DrawImage(Player.P2.Graphic, New Rectangle((mouseX * 4), (mouseY * 32) - (Player.P2.PlayerH - 32), Player.P2.PlayerW, Player.P2.PlayerH), New Rectangle(500, 0, Player.P2.PlayerW, Player.P2.PlayerH), GraphicsUnit.Pixel)
                        Else
                            Player.SetPlayer()
                        End If
                Case 5
                    r = New Rectangle(((mouseX * NPC.NPCSize)) - (NPC.NPCW - NPC.NPCSize), (mouseY * NPC.NPCSize) - (NPC.NPCH - NPC.NPCSize), NPC.NPCW, NPC.NPCH)

                    If NPC.Animated = True Then
                        Select Case NPC.FrameStyle
                            Case 0
                                graphic.DrawImage(TB.Image, r, New Rectangle(0, NPC.NPCH * Anim(NPC.FrameSpeed, NPC.TotalFrames), NPC.gfxWidth, NPC.NPCH), GraphicsUnit.Pixel)
                            Case 1
                                If NPC.Direction = 2 Then
                                    graphic.DrawImage(TB.Image, r, New Rectangle(0, NPC.NPCH * Anim(NPC.FrameSpeed, NPC.TotalFrames), NPC.gfxWidth, NPC.NPCH), GraphicsUnit.Pixel)
                                ElseIf NPC.Direction = 1 Then
                                    graphic.DrawImage(TB.Image, r, New Rectangle(0, NPC.NPCH * Anim2(NPC.FrameSpeed, NPC.TotalFrames), NPC.gfxWidth, NPC.NPCH), GraphicsUnit.Pixel)
                                End If
                            Case 2

                        End Select
                    Else
                        Select Case NPC.FrameStyle
                            Case 0
                                graphic.DrawImage(TB.Image, r, New Rectangle(0, 0, NPC.gfxWidth, NPC.NPCH), GraphicsUnit.Pixel)
                            Case 1
                                If NPC.Direction = 2 Then
                                    graphic.DrawImage(TB.Image, r, New Rectangle(0, 0, NPC.gfxWidth, NPC.NPCH), GraphicsUnit.Pixel)
                                ElseIf NPC.Direction = 1 Then
                                    graphic.DrawImage(TB.Image, r, New Rectangle(0, NPC.gfxHeight, NPC.gfxWidth, NPC.NPCH), GraphicsUnit.Pixel)
                                End If
                            Case 2
                                If NPC.Direction = 2 Then
                                    graphic.DrawImage(TB.Image, r, New Rectangle(0, 0, NPC.gfxWidth, NPC.NPCH), GraphicsUnit.Pixel)
                                ElseIf NPC.Direction = 1 Then
                                    graphic.DrawImage(TB.Image, r, New Rectangle(0, ((NPC.gfxHeight) / 2) / 2, NPC.gfxWidth, NPC.NPCH), GraphicsUnit.Pixel)
                                End If
                            Case 3
                                If NPC.Direction = 2 Then
                                    graphic.DrawImage(TB.Image, r, New Rectangle(0, 0, NPC.gfxWidth, NPC.NPCH), GraphicsUnit.Pixel)
                                ElseIf NPC.Direction = 1 Then
                                    graphic.DrawImage(TB.Image, r, New Rectangle(0, NPC.gfxHeight / 3, NPC.gfxWidth, NPC.NPCH), GraphicsUnit.Pixel)
                                End If
                        End Select
                    End If
            End Select
        End If

        Debug.TotalObjBGOs = Backgrounds.bgorects.Where(Function(c) e.Graphics.IsVisible(c)).Count

        graphic.ResetTransform()

        If EditMode <> 1 Then
            Draw.DrawImage(My.Resources.Pointer, PointRec)
        Else
            Draw.DrawImage(My.Resources.Eraser, EraseRec)
        End If

        If Play.IsTesting = True Then
            Draw.DrawImage(My.Resources.HoldBox, Play.HoldBoxLoc)

            Draw.DrawString(Play.Score, SMB3font, Brushes.White, Play.ScoreLoc)

            Draw.DrawImage(My.Resources.CoinCount, New Point(Play.CoinsLoc.X - 64, Play.CoinsLoc.Y + 4))
            Draw.DrawString(Play.Coins, SMB3font, Brushes.White, Play.CoinsLoc)

            Draw.DrawImage(My.Resources.LifeCount, New Point(Play.LivesLoc.X - 64, Play.LivesLoc.Y + 4))
            Draw.DrawString(Play.Lives, SMB3font, Brushes.White, Play.LivesLoc)
        End If

        Draw.ResetTransform()
    End Sub

    Public Sub Save()
        Dim RC As RectangleConverter
        RC = New RectangleConverter

        If Directory.Exists(Form1.FilePath & "\worlds\") = False Then
            Directory.CreateDirectory(Form1.FilePath & "\worlds\")
        End If

        Dim SavePath As String = Level.LevelPath
        Dim sw As StreamWriter

        Try
            sw = New StreamWriter(SavePath, False)

            sw.WriteLine(Level.Music)
            sw.WriteLine(Level.BGid)
            sw.WriteLine(Level.LevelW)
            sw.WriteLine(Level.LevelH)
            sw.WriteLine(Level.LevelWrap.ToString())
            sw.WriteLine(Level.NoTurnBack.ToString())
            sw.WriteLine(Level.OffscreenExit.ToString())
            sw.WriteLine(Level.Underwater.ToString())
            sw.WriteLine(RC.ConvertToString(Level.P1start))
            sw.WriteLine(RC.ConvertToString(Level.P2start))
            sw.WriteLine(Level.Time)
            sw.WriteLine(Play.GravityLevel)
            sw.WriteLine(Level.Brightness)

            sw.WriteLine("[BLOCK]")

            For Each i As Block In Blocks.Tiles.ToList
                sw.WriteLine(i.Animated.ToString())
                sw.WriteLine(i.ContainItem)
                sw.WriteLine(i.FrameSpeed)
                sw.WriteLine(i.gfxHeight)
                sw.WriteLine(i.gfxWidth)
                sw.WriteLine(i.Height)
                sw.WriteLine(i.Width)
                sw.WriteLine(i.ID)
                sw.WriteLine(i.Invisible.ToString())
                sw.WriteLine(i.Lava.ToString())
                sw.WriteLine(RC.ConvertToString(i.rectangle))
                sw.WriteLine(i.SizeH)
                sw.WriteLine(i.SizeW)
                sw.WriteLine(i.Slip.ToString())
                sw.WriteLine(i.TotalFrames)
                sw.WriteLine(i.X)
                sw.WriteLine(i.Y)
                sw.WriteLine(i.R)
                sw.WriteLine(i.G)
                sw.WriteLine(i.B)
                sw.WriteLine(i.Glow)
                sw.WriteLine(i.Breakable)
            Next

            sw.WriteLine("[BGO]")

            For Each i As BGO In Backgrounds.BGOs.ToList
                sw.WriteLine(i.Animated.ToString())
                sw.WriteLine(i.ForeGround.ToString())
                sw.WriteLine(i.FrameSpeed)
                sw.WriteLine(i.gfxHeight)
                sw.WriteLine(i.gfxWidth)
                sw.WriteLine(i.Height)
                sw.WriteLine(i.Width)
                sw.WriteLine(i.ID)
                sw.WriteLine(RC.ConvertToString(i.rectangle))
                sw.WriteLine(i.TotalFrames)
                sw.WriteLine(i.X)
                sw.WriteLine(i.Y)
            Next

            sw.WriteLine("[NPC]")

            For Each i As NPCsets In NPC.NPCsets.ToList
                sw.WriteLine(i.AI)
                sw.WriteLine(i.Animated.ToString())
                sw.WriteLine(i.Direction)
                sw.WriteLine(i.FrameSpeed)
                sw.WriteLine(i.FrameStyle)
                sw.WriteLine(i.gfxHeight)
                sw.WriteLine(i.gfxWidth)
                sw.WriteLine(i.HasGravity.ToString())
                sw.WriteLine(i.Height)
                sw.WriteLine(i.Width)
                sw.WriteLine(i.ID)
                sw.WriteLine(i.MSG)
                sw.WriteLine(i.MetroidGlass.ToString())
                sw.WriteLine(i.MoveSpeed)
                sw.WriteLine(RC.ConvertToString(i.rectangle))
                sw.WriteLine(i.TotalFrames)
                sw.WriteLine(i.X)
                sw.WriteLine(i.Y)
                sw.WriteLine(i.NPCcollide)
            Next

            sw.Close()
            sw.Dispose()

            IsSaved = True
        Catch ex As Exception
            MsgBox("You must save or load your level before testing!", MsgBoxStyle.Information)

            IsSaved = False
        End Try
    End Sub

    Public Sub SetBG()
        Dim fs As System.IO.FileStream
        Dim fs2 As System.IO.FileStream
        Select Case Level.BGid
            Case 1
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-1.png"
                Level.BG2path = Form1.FilePath & "\graphics\background2\background2-2.png"
                Level.BGtype = 1
                LevelSettings.BGColor = Color.FromArgb(255, 104, 152, 248)
            Case 2
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-3.png"
                Level.BG2path = Form1.FilePath & "\graphics\background2\background2-2.png"
                Level.BGtype = 1
                LevelSettings.BGColor = Color.FromArgb(255, 104, 152, 248)
            Case 3
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-4.png"
                Level.BGtype = 6
                LevelSettings.BGColor = Color.FromArgb(255, 48, 64, 48)
            Case 4
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-5.png"
                Level.BGtype = 4
            Case 5
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-7.png"
                Level.BGtype = 4
            Case 6
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-2.png"
                Level.BGtype = 2
                LevelSettings.BGColor = Color.FromArgb(255, 104, 152, 248)
            Case 7
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-36.png"
                Level.BGtype = 2
                LevelSettings.BGColor = Color.FromArgb(255, 152, 144, 248)
            Case 8
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-14.png"
                Level.BGtype = 2
            Case 9
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-15.png"
                Level.BGtype = 4
            Case 10
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-17.png"
                Level.BGtype = 6
            Case 11
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-20.png"
                Level.BGtype = 2
                LevelSettings.BGColor = Color.Black
            Case 12
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-21.png"
                Level.BGtype = 5
            Case 13
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-22.png"
                Level.BG2path = Form1.FilePath & "\graphics\background2\background2-2.png"
                Level.BGtype = 3
                LevelSettings.BGColor = Color.FromArgb(255, 104, 152, 248)
            Case 14
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-23.png"
                Level.BGtype = 2
                LevelSettings.BGColor = Color.FromArgb(255, 0, 0, 24)
            Case 15
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-24.png"
                Level.BGtype = 4
            Case 16
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-26.png"
                Level.BGtype = 5
            Case 17
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-27.png"
                Level.BGtype = 6
            Case 18
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-35.png"
                Level.BG2path = Form1.FilePath & "\graphics\background2\background2-36.png"
                Level.BGtype = 1
                LevelSettings.BGColor = Color.FromArgb(255, 152, 144, 248)
            Case 19
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-37.png"
                Level.BG2path = Form1.FilePath & "\graphics\background2\background2-36.png"
                Level.BGtype = 1
                LevelSettings.BGColor = Color.FromArgb(255, 152, 144, 248)
            Case 20
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-38.png"
                Level.BGtype = 2
                LevelSettings.BGColor = Color.FromArgb(255, 216, 240, 248)
            Case 21
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-39.png"
                Level.BGtype = 4
            Case 22
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-56.png"
                Level.BGtype = 6
                LevelSettings.BGColor = Color.FromArgb(255, 8, 0, 96)
            Case 23
                Dim path As String = Form1.FilePath & "\graphics\background2\background2-11.png"
                Level.BGtype = 2
                LevelSettings.BGColor = Color.FromArgb(255, 80, 136, 160)
            Case 24
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-8.png"
                Level.BGtype = 4
            Case 25
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-9.png"
                Level.BGtype = 6
                LevelSettings.BGColor = Color.FromArgb(255, 80, 136, 160)
            Case 26
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-10.png"
                Level.BG2path = Form1.FilePath & "\graphics\background2\background2-9.png"
                Level.BGtype = 7
                LevelSettings.BGColor = Color.FromArgb(255, 104, 152, 248)
            Case 27
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-41.png"
                Level.BGtype = 6
                LevelSettings.BGColor = Color.FromArgb(255, 80, 136, 160)
            Case 28
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-50.png"
                Level.BGtype = 6
                LevelSettings.BGColor = Color.FromArgb(255, 80, 136, 160)
            Case 29
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-51.png"
                Level.BGtype = 6
                LevelSettings.BGColor = Color.FromArgb(255, 80, 136, 160)
            Case 30
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-6.png"
                Level.BGtype = 6
                LevelSettings.BGColor = Color.FromArgb(255, 80, 136, 160)
            Case 31
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-25.png"
                Level.BGtype = 4
            Case 32
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-44.png"
                Level.BGtype = 6
                LevelSettings.BGColor = Color.FromArgb(255, 80, 136, 160)
            Case 33
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-48.png"
                Level.BGtype = 6
                LevelSettings.BGColor = Color.FromArgb(255, 80, 136, 160)
            Case 34
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-49.png"
                Level.BGtype = 6
                LevelSettings.BGColor = Color.FromArgb(255, 80, 136, 160)
            Case 35
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-52.png"
                Level.BGtype = 6
                LevelSettings.BGColor = Color.FromArgb(255, 80, 136, 160)
            Case 36
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-53.png"
                Level.BGtype = 6
                LevelSettings.BGColor = Color.FromArgb(255, 80, 136, 160)
            Case 37
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-54.png"
                Level.BGtype = 6
                LevelSettings.BGColor = Color.FromArgb(255, 80, 136, 160)
            Case 38
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-57.png"
                Level.BGtype = 6
                LevelSettings.BGColor = Color.FromArgb(255, 80, 136, 160)
            Case 39
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-12.png"
                Level.BGtype = 6
                LevelSettings.BGColor = Color.FromArgb(255, 80, 136, 160)
            Case 40
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-32.png"
                Level.BGtype = 6
                LevelSettings.BGColor = Color.FromArgb(255, 80, 136, 160)
            Case 41
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-34.png"
                Level.BGtype = 6
                LevelSettings.BGColor = Color.FromArgb(255, 80, 136, 160)
            Case 42
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-33.png"
                Level.BGtype = 6
                LevelSettings.BGColor = Color.FromArgb(255, 80, 136, 160)
            Case 43
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-31.png"
                Level.BGtype = 6
                LevelSettings.BGColor = Color.FromArgb(255, 80, 136, 160)
            Case 44
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-18.png"
                Level.BGtype = 8
                LevelSettings.BGColor = Color.Black
            Case 45
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-19.png"
                Level.BGtype = 6
                LevelSettings.BGColor = Color.FromArgb(255, 80, 136, 160)
            Case 46
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-13.png"
                Level.BGtype = 6
                LevelSettings.BGColor = Color.FromArgb(255, 80, 136, 160)
            Case 47
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-29.png"
                Level.BGtype = 8
                LevelSettings.BGColor = Color.FromArgb(255, 80, 136, 160)
            Case 48
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-30.png"
                Level.BGtype = 8
                LevelSettings.BGColor = Color.FromArgb(255, 80, 136, 160)
            Case 49
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-42.png"
                Level.BGtype = 8
                LevelSettings.BGColor = Color.FromArgb(255, 80, 136, 160)
            Case 50
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-43.png"
                Level.BGtype = 6
                LevelSettings.BGColor = Color.FromArgb(255, 80, 136, 160)
            Case 51
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-28.png"
                Level.BGtype = 4
            Case 52
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-55.png"
                Level.BGtype = 8
                LevelSettings.BGColor = Color.FromArgb(255, 80, 136, 160)
            Case 53
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-58.png"
                Level.BGtype = 8
                LevelSettings.BGColor = Color.FromArgb(255, 80, 136, 160)
            Case 54
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-16.png"
                Level.BGtype = 4
            Case 55
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-45.png"
                Level.BGtype = 4
            Case 56
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-46.png"
                Level.BGtype = 4
            Case 57
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-47.png"
                Level.BGtype = 4
            Case 58
                Level.BGpath = Form1.FilePath & "\graphics\background2\background2-40.png"
                Level.BGtype = 6
        End Select

        Try
            fs = New FileStream(Level.BGpath, FileMode.Open)
            Level.BG = Image.FromStream(fs)

            fs.Close()
            fs.Dispose()
        Catch ex As Exception
            Me.BackColor = Color.Black
        End Try

        If Not Level.BG2path = "" Then
            fs2 = New FileStream(Level.BG2path, FileMode.Open)
            Level.BG2 = Image.FromStream(fs2)

            fs2.Close()
            fs2.Dispose()
        End If

        Me.Refresh()
        Me.Update()
    End Sub

    Public Sub LoadLevel()

        Dim RC As RectangleConverter
        RC = New RectangleConverter

        Blocks.Tiles.Clear()
        Blocks.TileRects.Clear()
        Backgrounds.BGOs.Clear()
        Backgrounds.bgorects.Clear()
        NPC.NPCsets.Clear()
        NPC.NPCrects.Clear()

        Dim g As Graphics = Me.CreateGraphics()
        g.Clear(Color.Black)

        Dim OpenPath As String = Level.LevelPath

        Dim fs As New System.IO.FileStream(OpenPath, FileMode.Open)

        Dim CurTag As String = ""

        Dim sr As New StreamReader(fs)

        Level.Music = sr.ReadLine()
        Level.BGid = sr.ReadLine()

        LevelSettings.PlayM.StopPlayback()
        Level.Song = "custom"
        LevelSettings.SetLevelMusic()

        Level.LevelW = sr.ReadLine()
        Level.LevelH = sr.ReadLine()

        Level.HeightInc = ((Level.LevelH - (19 * 32)) + 32) / 32

        SetBG()

        Me.AutoScrollMinSize = New Size(Level.LevelW, Level.LevelH)

        Level.LevelWrap = sr.ReadLine()
        Level.NoTurnBack = sr.ReadLine()
        Level.OffscreenExit = sr.ReadLine()
        Level.Underwater = sr.ReadLine()

        If Player.P1.Graphic Is Nothing And Directory.Exists(Form1.FilePath & "\graphics\mario\") Then
            Player.P1.Graphic = New Bitmap(Form1.FilePath & "\graphics\mario\mario-2.png")
        ElseIf Player.P2.Graphic Is Nothing And Directory.Exists(Form1.FilePath & "\graphics\luigi") Then
            Player.P2.Graphic = New Bitmap(Form1.FilePath & "\graphics\luigi\luigi-2.png")
        End If

        Level.P1start = RC.ConvertFromString(sr.ReadLine())

        Play.DrawX = Level.P1start.X
        Play.DrawY = Level.P1start.Y

        Level.P2start = RC.ConvertFromString(sr.ReadLine())
        Level.Time = sr.ReadLine()
        Play.GravityLevel = sr.ReadLine()
        Level.Brightness = sr.ReadLine()

        Dim CurLine As String = ""

        Dim b As New Block
        Dim bg As New BGO
        Dim n As New NPCsets

        CurLine = sr.ReadLine().ToString()
        If CurLine = "[BLOCK]" Then
            CurTag = "[BLOCK]"
        End If

        If CurTag = "[BLOCK]" Then
            Do While CurTag = "[BLOCK]"

                Try
                    b.Animated = sr.ReadLine()
                    b.ContainItem = sr.ReadLine()
                    b.FrameSpeed = sr.ReadLine()
                    b.gfxHeight = sr.ReadLine()
                    b.gfxWidth = sr.ReadLine()
                    b.Height = sr.ReadLine()
                    b.Width = sr.ReadLine()
                    b.ID = sr.ReadLine()
                    b.Invisible = sr.ReadLine()
                    b.Lava = sr.ReadLine()
                    b.rectangle = RC.ConvertFromString(sr.ReadLine())
                    b.SizeH = sr.ReadLine()
                    b.SizeW = sr.ReadLine()
                    b.Slip = sr.ReadLine()
                    b.TotalFrames = sr.ReadLine()
                    b.X = sr.ReadLine()
                    b.Y = sr.ReadLine()
                    b.R = sr.ReadLine()
                    b.G = sr.ReadLine()
                    b.B = sr.ReadLine()
                    b.Glow = sr.ReadLine()
                    b.Breakable = sr.ReadLine()

                    Blocks.GetBlock(b.ID)

                    b.IMG = TB.Image

                    Blocks.Tiles.Add(b)
                    Blocks.TileRects.Add(b.rectangle)
                Catch ex As Exception
                    CurTag = "[BGO]"
                    Exit Do
                End Try
            Loop
        End If

        If CurTag = "[BGO]" Then
            Do While CurTag = "[BGO]"
                Try
                    bg.Animated = sr.ReadLine()
                    bg.ForeGround = sr.ReadLine()
                    bg.FrameSpeed = sr.ReadLine()
                    bg.gfxHeight = sr.ReadLine()
                    bg.gfxWidth = sr.ReadLine()
                    bg.Height = sr.ReadLine()
                    bg.Width = sr.ReadLine()
                    bg.ID = sr.ReadLine()
                    bg.rectangle = RC.ConvertFromString(sr.ReadLine())
                    bg.TotalFrames = sr.ReadLine()
                    bg.X = sr.ReadLine()
                    bg.Y = sr.ReadLine()

                    If bg.ID >= 1 Then
                        SelectedBGO = bg.ID
                        Backgrounds.GetBGO()

                        bg.IMG = TB.Image

                        Backgrounds.BGOs.Add(bg)
                        Backgrounds.bgorects.Add(bg.rectangle)
                    End If
                Catch ex As Exception
                    CurTag = "[NPC]"
                    Exit Do
                End Try
            Loop
        End If

        Do While sr.Peek() > -1
            If CurTag = "[NPC]" Then
                n.AI = sr.ReadLine()
                n.Animated = sr.ReadLine()
                n.Direction = sr.ReadLine()
                n.FrameSpeed = sr.ReadLine()
                n.FrameStyle = sr.ReadLine()
                n.gfxHeight = sr.ReadLine()
                n.gfxWidth = sr.ReadLine()
                n.HasGravity = sr.ReadLine()
                n.Height = sr.ReadLine()
                n.Width = sr.ReadLine()
                n.ID = sr.ReadLine()
                n.MSG = sr.ReadLine()
                n.MetroidGlass = sr.ReadLine()
                n.MoveSpeed = sr.ReadLine()
                n.rectangle = RC.ConvertFromString(sr.ReadLine())
                n.TotalFrames = sr.ReadLine()
                n.X = sr.ReadLine()
                n.Y = sr.ReadLine()
                n.NPCcollide = sr.ReadLine()

                If n.ID >= 1 Then
                    SelectedNPC = n.ID
                    NPC.GetNPC()

                    n.IMG = TB.Image

                    NPC.NPCsets.Add(n)
                    NPC.NPCrects.Add(n.rectangle)
                End If
            End If
        Loop

        sr.Close()
        sr.Dispose()
    End Sub

    Private Sub Form2_Scroll(sender As Object, e As System.Windows.Forms.ScrollEventArgs) Handles Me.Scroll
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then
            Parallax += (e.OldValue - e.NewValue)
            Me.Refresh()
        End If
    End Sub

    Private Sub Animation_Tick(sender As System.Object, e As System.EventArgs) Handles Animation.Tick
        stopw.Start()

        Dim elapsed As TimeSpan = Me.stopw.Elapsed

        If elapsed.TotalMilliseconds >= 12 Then
            Anim(1, 2) += 1

            If Anim(1, 2) >= 2 Then
                Anim(1, 2) = 0
            End If

            For x = 3 To 8
                Anim(1, x) += 1

                If Anim(1, x) >= x Then
                    Anim(1, x) = 0
                End If
            Next

            For x = 4 To 8
                Anim2(1, x) += 1

                If Anim2(1, x) >= x Then
                    Anim2(1, x) = x
                End If
            Next
        End If

        If elapsed.TotalMilliseconds >= 25 Then
            Anim(2, 2) += 1

            If Anim(2, 2) >= 2 Then
                Anim(2, 2) = 0
            End If

            For x = 3 To 8
                Anim(2, x) += 1

                If Anim(2, x) >= x Then
                    Anim(2, x) = 0
                End If
            Next

            For x = 4 To 8
                Anim2(2, x) += 1

                If Anim2(2, x) >= x * 2 Then
                    Anim2(2, x) = x
                End If
            Next
        End If

        If elapsed.TotalMilliseconds >= 37 Then
            Anim(3, 2) += 1

            If Anim(3, 2) >= 2 Then
                Anim(3, 2) = 0
            End If

            For x = 3 To 8
                Anim(3, x) += 1

                If Anim(3, x) >= x Then
                    Anim(3, x) = 0
                End If
            Next

            Anim2(3, 2) += 1

            If Anim2(3, 2) >= 4 Then
                Anim2(3, 2) = 2
            End If

            For x = 3 To 8
                Anim2(3, x) += 1

                If Anim2(3, x) >= x * 2 Then
                    Anim2(3, x) = x
                End If
            Next
        End If

        If elapsed.TotalMilliseconds >= 50 Then
            Anim(4, 2) += 1

            If Anim(4, 2) >= 2 Then
                Anim(4, 2) = 0
            End If

            For x = 3 To 8
                Anim(4, x) += 1

                If Anim(4, x) >= x Then
                    Anim(4, x) = 0
                End If
            Next

            Anim2(4, 2) += 1

            If Anim2(4, 2) >= 4 Then
                Anim2(4, 2) = 2
            End If

            For x = 3 To 8
                Anim2(4, x) += 1

                If Anim2(4, x) >= x * 2 Then
                    Anim2(4, x) = x
                End If
            Next
        End If

        If elapsed.TotalMilliseconds >= 62 Then
            Anim(5, 2) += 1

            If Anim(5, 2) >= 2 Then
                Anim(5, 2) = 0
            End If

            For x = 3 To 8
                Anim(5, x) += 1

                If Anim(5, x) >= x Then
                    Anim(5, x) = 0
                End If
            Next

            Anim2(5, 2) += 1

            If Anim2(5, 2) >= 4 Then
                Anim2(5, 2) = 2
            End If

            For x = 3 To 8
                Anim2(5, x) += 1

                If Anim2(5, x) >= x * 2 Then
                    Anim2(5, x) = x
                End If
            Next
        End If

        If elapsed.TotalMilliseconds >= 75 Then
            Anim(6, 2) += 1

            If Anim(6, 2) >= 2 Then
                Anim(6, 2) = 0
            End If

            For x = 3 To 8
                Anim(6, x) += 1

                If Anim(6, x) >= x Then
                    Anim(6, x) = 0
                End If
            Next

            Anim2(6, 2) += 1

            If Anim2(6, 2) >= 4 Then
                Anim2(6, 2) = 2
            End If

            For x = 3 To 8
                Anim2(6, x) += 1

                If Anim2(6, x) >= x * 2 Then
                    Anim2(6, x) = x
                End If
            Next

        End If

        If elapsed.TotalMilliseconds >= 88 Then
            Anim(7, 2) += 1

            If Anim(7, 2) >= 2 Then
                Anim(7, 2) = 0
            End If

            For x = 3 To 8
                Anim(7, x) += 1

                If Anim(7, x) >= x Then
                    Anim(7, x) = 0
                End If
            Next

            Anim2(7, 2) += 1

            If Anim2(7, 2) >= 4 Then
                Anim2(7, 2) = 2
            End If

            For x = 3 To 8
                Anim2(7, x) += 1

                If Anim2(7, x) >= x * 2 Then
                    Anim2(7, x) = x
                End If
            Next

        End If

        If elapsed.TotalMilliseconds >= 100 Then
            Anim(8, 2) += 1

            If Anim(8, 2) >= 2 Then
                Anim(8, 2) = 0
            End If

            For x = 3 To 8
                Anim(8, x) += 1

                If Anim(8, x) >= x Then
                    Anim(8, x) = 0
                End If
            Next

            Anim2(8, 2) += 1

            If Anim2(8, 2) >= 4 Then
                Anim2(8, 2) = 2
            End If

            For x = 3 To 8
                Anim2(8, x) += 1

                If Anim2(8, x) >= x * 2 Then
                    Anim2(8, x) = x
                End If
            Next

            If Play.IsTesting = True Then
                Play.GetPlayerFrame()
            End If

            stopw.Reset()
        End If

        Me.Update()

        If Play.IsTesting = True Then
            Play.Gravity()
            Play.AI()
            KeyboardControl()
        End If

        If MouseIsMoving Then
            Me.Invalidate(Cursor.Clip)
        End If

        curscreen = New Rectangle(Me.AutoScrollPosition.X * -1, Me.AutoScrollPosition.Y * -1, 800, 672)
    End Sub

    Private Sub Form2_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        screen = New Rectangle(0, 0, Me.Width, Me.Height)

        Play.HoldBoxLoc = New Rectangle((Me.Width / 2) - My.Resources.HoldBox.Width, 16, My.Resources.HoldBox.Width, My.Resources.HoldBox.Height)
        Play.ScoreLoc = New Point((Play.HoldBoxLoc.X + Play.HoldBoxLoc.Width) + 128, 48)
        Play.CoinsLoc = New Point((Play.HoldBoxLoc.X + Play.HoldBoxLoc.Width) + 128, 24)
        Play.LivesLoc = New Point((Play.HoldBoxLoc.X - Play.HoldBoxLoc.Width) - 64, 24)

        If Me.Width > Level.LevelW + 32 Then
            Me.Width = Level.LevelW + 32
        ElseIf Me.Height > Level.LevelH + 32 Then
            Me.Height = Level.LevelH + 32
        End If
    End Sub
End Class