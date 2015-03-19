Imports System.Diagnostics

Public Class Debug
    Public Shared TotalBlocks As Integer = 0
    Public Shared TotalBGOs As Integer = 0
    Public Shared TotalNPCs As Integer = 0
    Public Memory As New PerformanceCounter("Memory", "Available MBytes")
    Public CPU As New PerformanceCounter("Processor", "% Processor Time", "_Total")

    Public Shared Sub MouseLoc(X As Integer, Y As Integer)
        Debug.Label7.Text = "X: " & X
        Debug.Label8.Text = "Y: " & Y
    End Sub

    Private Sub Debug_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Try
            Label1.Text = "Memory Available: " & Memory.NextValue() & "MB"
            Label2.Text = "CPU: " & Math.Round(CPU.NextValue()) & "%"

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
    End Sub
End Class