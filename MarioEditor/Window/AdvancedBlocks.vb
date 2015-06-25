Public Class AdvancedBlocks
    Public Shared R As Integer = 255
    Public Shared G As Integer = 255
    Public Shared B As Integer = 255
    Public Shared Glow As Integer = 100
    Public Shared GraphicChanged As Boolean
    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Label3.Enabled = True
        Label4.Enabled = True

        TextBox3.Enabled = True
        TextBox4.Enabled = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Label3.Enabled = False
        Label4.Enabled = False

        TextBox3.Enabled = False
        TextBox4.Enabled = False
    End Sub

    Private Sub AdvancedBlocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If R & G & B = 255 And Glow = 100 Then
            GraphicChanged = False
        Else
            GraphicChanged = True
        End If
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        R = TrackBar1.Value
    End Sub

    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll
        G = TrackBar2.Value
    End Sub

    Private Sub TrackBar3_Scroll(sender As Object, e As EventArgs) Handles TrackBar3.Scroll
        B = TrackBar3.Value
    End Sub

    Private Sub TrackBar4_Scroll(sender As Object, e As EventArgs) Handles TrackBar4.Scroll
        Glow = TrackBar4.Value * 10
    End Sub
End Class