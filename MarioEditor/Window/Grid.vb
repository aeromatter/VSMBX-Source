Imports System.Drawing

Public Class Grid
    Public Shared GColor As Color
    Public Shared GridOn As Boolean = False

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GColor = Color.Black
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GColor = Color.Red
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GColor = Color.Yellow
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GColor = Color.Green
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        GColor = Color.Blue
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        GColor = Color.Orange
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        GColor = Color.Purple
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        GColor = Color.Pink
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Try
            GColor = Color.FromArgb(CInt(TextBox1.Text), CInt(TextBox2.Text), CInt(TextBox3.Text))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            TextBox1.Text = "255"
            TextBox2.Text = "255"
            TextBox3.Text = "255"
        End Try

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        GridOn = RadioButton1.Checked
    End Sub
End Class