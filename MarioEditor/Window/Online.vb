Imports System
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.IO
Public Class Online
    Public Shared TCPClient As TcpClient
    Public Shared IP As IPAddress
    Public Shared Port As Integer = 8000
    Public Shared Nick As String = "Anonymous"
    Public Shared NS As NetworkStream

    Private Sub Online_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TextBox2.Text = Port
        TextBox4.Text = Nick
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        IP = IPAddress.Parse(TextBox1.Text)
        Port = TextBox2.Text
        Nick = TextBox4.Text

        Try
            TCPClient = New TcpClient(IP.ToString, Port)
            Dim sw As New StreamWriter(TCPClient.GetStream())
            sw.Write("<!join> " & Nick & " <\>")
            sw.Flush()

            Form2.Online = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Chat.Show()
    End Sub
End Class