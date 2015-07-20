Imports System.IO
Imports System.Drawing
Imports System.Media
Imports MarioEditor.libZPlay
Public Class Form1

    Public Shared FilePath As String = Path.GetDirectoryName(Application.ExecutablePath)

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CheckBox1.Checked = True

        Form2.MdiParent = Me
        Form2.Show()

        AdvancedBlocks.MdiParent = Me
        AdvancedBlocks.Location = New Point(Form2.Width, 0)

        If Directory.Exists(Form1.FilePath & "\screenshots\") = False Then
            Directory.CreateDirectory(Form1.FilePath & "\screenshots\")
        ElseIf Directory.Exists(Form1.FilePath & "\worlds\") = False Then
            Directory.CreateDirectory(Form1.FilePath & "\worlds\")
        ElseIf Directory.Exists(Form1.FilePath & "\battle\") = False Then
            Directory.CreateDirectory(Form1.FilePath & "\battle\")
        End If

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Form2.EditMode = 0

        BlocksAndTiles.MdiParent = Me
        BlocksAndTiles.Location = New Point(0, Form2.Height)

        'Form2.Cursor = New Cursor(My.Resources.Pointer.GetHicon)

        LevelSettings.Hide()
        BlocksAndTiles.Show()
        BGOs_Form.Hide()
        NPCs.Hide()
        BlocksAndTiles.Focus()
    End Sub

    Private Sub DebuggerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DebuggerToolStripMenuItem.Click
        Debug.MdiParent = Me
        Debug.Show()
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Level.LevelPath = SaveFileDialog1.FileName
        Form2.Save()

        Dim Audio = New Audio
        Audio.PlaySound(5)
    End Sub

    Private Sub OpenToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles OpenToolStripMenuItem3.Click
        OpenFileDialog1.Filter = "Level Files|*.vlvl"
        OpenFileDialog1.InitialDirectory = Form1.FilePath & "\worlds\"
        OpenFileDialog1.Title = "Open Level"

        OpenFileDialog1.FileName = ""

        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub SaveToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles SaveToolStripMenuItem3.Click
        SaveFileDialog1.Filter = "Level Files|*.vlvl"
        SaveFileDialog1.InitialDirectory = Form1.FilePath & "\worlds\"
        SaveFileDialog1.Title = "Save Level"

        SaveFileDialog1.FileName = ""

        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Level.LevelPath = OpenFileDialog1.FileName
        Form2.LoadLevel()
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Form2.EditMode = 7
        LevelSettings.MdiParent = Me

        If Form2.PlayerGraphic Is Nothing And Form2.Player2Graphic Is Nothing And Directory.Exists(Form1.FilePath & "\graphics\mario\") And Directory.Exists(Form1.FilePath & "\graphics\luigi\") Then
            Form2.PlayerGraphic = New Bitmap(Form1.FilePath & "\graphics\mario\mario-2.png")
            Form2.Player2Graphic = New Bitmap(Form1.FilePath & "\graphics\luigi\luigi-2.png")
        End If

        LevelSettings.Location = New Point(0, Form2.Height)
        LevelSettings.Show()

        BlocksAndTiles.Hide()
        BGOs_Form.Hide()
        NPCs.Hide()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Form2.EditMode = 1
        LevelSettings.Hide()
        BlocksAndTiles.Hide()
        BGOs_Form.Hide()
        NPCs.Hide()

        ActiveControl = Form2
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        BGOs_Form.MdiParent = Me
        BGOs_Form.Location = New Point(0, Form2.Height)

        LevelSettings.Hide()
        BlocksAndTiles.Hide()
        BGOs_Form.Show()
        NPCs.Hide()
        Form2.EditMode = 2
    End Sub

    Private Sub NewToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles NewToolStripMenuItem3.Click
        Blocks.Tiles.Clear()
        Blocks.TileRects.Clear()
        Backgrounds.BGOs.Clear()
        Backgrounds.bgorects.Clear()
    End Sub

    Private Sub ExitToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem3.Click
        Me.Close()
    End Sub

    Private Sub JoinServerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles JoinServerToolStripMenuItem.Click
        Online.Show()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        NPCs.MdiParent = Me
        NPCs.Location = New Point(0, Form2.Height)

        LevelSettings.Hide()
        BlocksAndTiles.Hide()
        BGOs_Form.Hide()
        NPCs.Show()
        Form2.EditMode = 5
    End Sub

    Private Sub JoinIRCToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles JoinIRCToolStripMenuItem.Click
        IRC.Show()

        IRC.MdiParent = Me
        IRC.Location = New Point(Form2.Width, 0)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Form2.EditMode = 6

        LevelSettings.Hide()
        BlocksAndTiles.Hide()
        BGOs_Form.Hide()
        NPCs.Hide()
    End Sub

    Private Sub TestLevel1upF5ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TestLevel1upF5ToolStripMenuItem.Click
        Select Case MsgBox("Do you want to save the level first? Any unsaved changes will be lost.", MsgBoxStyle.YesNoCancel)
            Case MsgBoxResult.Yes
                Play.IsTesting = True
                Play.ShowHUD()
                Player.SetPlayer()

                Form2.ResetSpawn()

                Play.MoveDir = 1

                Play.ViewPort = New Rectangle(Play.PlayerX - (Form2.Width / 2), Play.PlayerY - (Form2.Height / 2), Form2.Width, Form2.Height)

                Dim Audio = New Audio
                Audio.PlaySound(5)

                'save level
            Case MsgBoxResult.No
                Play.IsTesting = True
                Play.ShowHUD()
                Player.SetPlayer()

                Form2.ResetSpawn()

                Play.MoveDir = 1

                Play.ViewPort = New Rectangle(Play.PlayerX - (Form2.Width / 2), Play.PlayerY - (Form2.Height / 2), Form2.Width, Form2.Height)

                Dim Audio = New Audio
                Audio.PlaySound(5)
            Case MsgBoxResult.Cancel

        End Select
    End Sub

    Private Sub DebuggerCtrlDToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DebuggerCtrlDToolStripMenuItem.Click
        Debug.MdiParent = Me
        Debug.Location = New Point(Form2.Width, 0)

        Debug.Show()
    End Sub

    Private Sub TestSettingsCtrlTToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TestSettingsCtrlTToolStripMenuItem.Click
        TestSettings.MdiParent = Me
        TestSettings.Location = New Point(Form2.Width, 0)

        TestSettings.Show()
    End Sub

    Private Sub GridCtrlGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GridCtrlGToolStripMenuItem.Click
        Grid.Show()
    End Sub
End Class
