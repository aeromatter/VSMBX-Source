Imports System.IO

Public Class ControlSettings

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PlayerC.LeftC = Asc(TextBox1.Text)
        PlayerC.RightC = Asc(TextBox2.Text)
        PlayerC.UpC = Asc(TextBox3.Text)
        PlayerC.DownC = Asc(TextBox4.Text)
        PlayerC.JumpC = Asc(TextBox5.Text)
        PlayerC.RunC = Asc(TextBox6.Text)
        PlayerC.SpinJumpC = Asc(TextBox7.Text)

        Dim sw As StreamWriter

        If File.Exists(Form1.FilePath & "\main.dat") = False Then
            Dim fs As New FileStream(Form1.FilePath & "\main.dat", FileMode.Create)
            sw = New StreamWriter(Form1.FilePath & "\main.dat")

            sw.WriteLine(PlayerC.LeftC)
            sw.WriteLine(PlayerC.RightC)
            sw.WriteLine(PlayerC.UpC)
            sw.WriteLine(PlayerC.DownC)
            sw.WriteLine(PlayerC.JumpC)
            sw.WriteLine(PlayerC.RunC)
            sw.WriteLine(PlayerC.SpinJumpC)

        End If
    End Sub
End Class