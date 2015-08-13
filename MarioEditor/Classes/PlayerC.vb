Imports System.IO
Imports System.Windows.Input

Public Class PlayerC
    'Set default controls.
    Public Shared LeftC As Key = Key.A
    Public Shared RightC As Key = Key.D
    Public Shared UpC As Key = Key.W
    Public Shared DownC As Key = Key.S
    Public Shared JumpC As Key = Key.Space
    Public Shared RunC As Key = Key.B
    Public Shared SpinJumpC As Key = Key.Q
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

            sr.Close()
            sr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
