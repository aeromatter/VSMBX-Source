Imports System.Diagnostics
Imports System.Windows.Input
Public Class Debug
    Public Shared TotalBlocks As Integer = 0
    Public Shared TotalBGOs As Integer = 0
    Public Shared TotalNPCs As Integer = 0
    Public Shared TotalObjBlocks As Integer = 0
    Public Shared TotalObjBGOs As Integer = 0
    Public Shared TotalObjNPCs As Integer = 0
    Public Memory As New PerformanceCounter("Memory", "Available MBytes", True)
    Public CPU As New PerformanceCounter("Process", "% Processor Time", Process.GetCurrentProcess().ProcessName, True)

    Public Shared Sub MouseLoc(X As Integer, Y As Integer)
        Debug.Label7.Text = "X: " & X
        Debug.Label8.Text = "Y: " & Y
    End Sub

    Private Sub Debug_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Try
            Label1.Text = "Memory Available: " & Math.Round(Memory.NextValue() / 1024, 2) & " GB"
            Label2.Text = "CPU: " & Math.Round(CPU.NextValue() * 0.5) & "%"

            Select Case Form2.EditMode
                Case 0
                    Label3.Text = "Select Mode: Block"
                Case 1
                    Label3.Text = "Select Mode: Eraser"
                Case 2
                    Label3.Text = "Select Mode: BGO"
                Case 3 Or 4
                    Label3.Text = "Select Mode: Player"
                Case 5
                    Label3.Text = "Select Mode: NPC"
                Case 6
                    Label3.Text = "Select Mode: Selection"
            End Select

            Label4.Text = "Block ID: " & Form2.SelectedBlock
            Label5.Text = "BGO ID: " & Form2.SelectedBGO
            Label6.Text = "NPC ID: " & Form2.SelectedNPC

            Dim kc As New KeyConverter

            Label21.Text = "Left: " & kc.ConvertToString(PlayerC.LeftC)
            Label22.Text = "Right: " & kc.ConvertToString(PlayerC.RightC)
            Label23.Text = "Up: " & kc.ConvertToString(PlayerC.UpC)
            Label24.Text = "Down: " & kc.ConvertToString(PlayerC.DownC)
            Label25.Text = "Jump: " & kc.ConvertToString(PlayerC.JumpC)
            Label26.Text = "Run: " & kc.ConvertToString(PlayerC.RunC)

            Label27.Text = CStr(Form2.FPScounter)
            Form2.FPScounter = 0
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        TotalBlocks = Blocks.Tiles.Count
        TotalBGOs = Backgrounds.BGOs.Count
        TotalNPCs = NPC.NPCsets.Count

        Label9.Text = "Blocks: " & TotalBlocks
        Label10.Text = "BGOs: " & TotalBGOs
        Label11.Text = "NPCs: " & TotalNPCs

        Label12.Text = "X: " & Play.PlayerX
        Label13.Text = "Y: " & Play.PlayerY
        Label14.Text = "DrawX: " & Play.DrawX
        Label15.Text = "DrawY: " & Play.DrawY

        Label16.Text = "Collision Dir: " & Play.CollideDir
        Label17.Text = "Move Dir: " & Play.MoveDir

        Label18.Text = "OS Blocks: " & TotalObjBlocks
        Label19.Text = "OS BGOs: " & TotalObjBGOs
        Label20.Text = "OS NPCs: " & TotalObjNPCs
    End Sub
End Class