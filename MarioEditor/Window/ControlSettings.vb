Imports System.IO
Imports System.Windows.Input
Public Class ControlSettings

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub WriteControls(FPath As String)
        'Check if main.dat exists, to determine if a new file should be made or if it should be overrided.
        If File.Exists(FPath) = False Then
            Dim fs As New FileStream(FPath, FileMode.CreateNew)
            fs.Close()
            fs.Dispose()
        Else
            Dim fs As New FileStream(FPath, FileMode.Create)
            fs.Close()
            fs.Dispose()
        End If

        'Write controls to main.dat file.
        Dim sw As New StreamWriter(FPath)

        sw.WriteLine(PlayerC.LeftC)
        sw.WriteLine(PlayerC.RightC)
        sw.WriteLine(PlayerC.UpC)
        sw.WriteLine(PlayerC.DownC)
        sw.WriteLine(PlayerC.JumpC)
        sw.WriteLine(PlayerC.RunC)
        sw.WriteLine(PlayerC.SpinJumpC)

        sw.Close()
        sw.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim kc As New KeyConverter

            'Converts the text input into key codes.
            PlayerC.LeftC = kc.ConvertFrom(TextBox1.Text)
            PlayerC.RightC = kc.ConvertFrom(TextBox2.Text)
            PlayerC.UpC = kc.ConvertFrom(TextBox3.Text)
            PlayerC.DownC = kc.ConvertFrom(TextBox4.Text)
            PlayerC.JumpC = kc.ConvertFrom(TextBox5.Text)
            PlayerC.RunC = kc.ConvertFrom(TextBox6.Text)
            PlayerC.SpinJumpC = kc.ConvertFrom(TextBox7.Text)
            
            WriteControls(Form1.FilePath & "\main.dat")

            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class