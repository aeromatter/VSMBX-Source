Imports System.IO

Public Class PlayerC
    Public Shared LeftC As Int16 = 65
    Public Shared RightC As Int16 = 68
    Public Shared UpC As Int16 = 87
    Public Shared DownC As Int16 = 83
    Public Shared JumpC As Int16 = 32
    Public Shared RunC As Int16 = 66
    Public Shared SpinJumpC As Int16 = 81

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
