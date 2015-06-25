Imports System.IO
Imports System.Windows.Input

Public Class PlayerC
    Public Shared LeftC As Key = Key.A
    Public Shared RightC As Key = Key.D
    Public Shared UpC As Key = Key.Up
    Public Shared DownC As Key = Key.Down
    Public Shared JumpC As Key = Key.Space
    Public Shared RunC As Key = Key.B
    Public Shared SpinJumpC As Key = Key.W
    Public Shared Sub LoadControls()
        Try
            Dim sr As StreamReader

            sr = New StreamReader(Form1.FilePath & "\main.dat")

            LeftC = sr.ReadLine()
            RightC = sr.ReadLine()
            UpC = sr.ReadLine()
            DownC = sr.ReadLine()
            JumpC = sr.ReadLine()
            RunC = sr.ReadLine()
            SpinJumpC = sr.ReadLine()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
