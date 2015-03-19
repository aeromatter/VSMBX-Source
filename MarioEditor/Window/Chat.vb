Imports System
Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Imports System.Text
Public Class Chat
    Public IPAddress As IPAddress = IPAddress.Any
    Public NS As NetworkStream
    Public TCPClient As TcpClient
    Public connected As Boolean = True
    Public TCPListener As TcpListener
    Public Clients As List(Of String)

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            Online.TCPClient = New TcpClient(Online.IP.ToString, Online.Port)
            Dim sw As New StreamWriter(Online.TCPClient.GetStream())
            sw.Write("<!msg> " & "<" & Online.Nick & ">" & TextBox1.Text & " <\>")
            sw.Flush()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        For Each client As String In Clients
            Try
                Online.TCPClient = New TcpClient(client, 8001)
                'MsgBox(CType(ServClient.Client.RemoteEndPoint, IPEndPoint).Address.ToString)
                Dim sw As New StreamWriter(Online.TCPClient.GetStream())
                sw.Write("<!msg> " & "<" & Online.Nick & ">" & TextBox1.Text & " <\>")
                sw.Flush()

                sw.Write("<mouse> " & Form2.mouselocX & ":" & Form2.mouselocY & "<\>")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            MsgBox(client)
        Next
    End Sub

    Private Sub Chat_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TCPListener = New TcpListener(IPAddress, 8001)
        TCPListener.Start()

        Clients = New List(Of String)
        RichTextBox1.Text += "Connected successfully to " & Online.IP.ToString & "!" & vbNewLine
    End Sub


    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Dim MSG As String = ""
        Dim Nick As String = ""

        Dim nStart As Integer
        Dim nLast As Integer
        If TcpListener.Pending = True Then
            TCPClient = TcpListener.AcceptTcpClient()

            Dim sr As New StreamReader(TCPClient.GetStream())
            While sr.Peek > -1
                MSG &= Convert.ToChar(sr.Read()).ToString
            End While
            If MSG.Contains("<!join>") Then
                nStart = InStr(MSG, "<!join>") + 8
                nLast = InStr(MSG, "<\>")
                Nick = Mid(MSG, nStart, nLast - nStart)
                MSG = Nick & "has joined the server!"
                Clients.Add(CType(TCPClient.Client.RemoteEndPoint, IPEndPoint).Address.ToString)
                ListBox1.Items.Add(Nick)
            ElseIf MSG.Contains("<!msg>") Then
                nStart = InStr(MSG, "<!msg>") + 7
                nLast = InStr(MSG, "<\>")
                MSG = Mid(MSG, nStart, nLast - nStart)
            End If

            RichTextBox1.Text += MSG & vbNewLine

        End If

        Try
            Online.TCPClient = New TcpClient(Online.IP.ToString, Online.Port)
            Dim sw As New StreamWriter(Online.TCPClient.GetStream())
            sw.Write("<mouse> " & "X: " & Form2.mouselocX & " Y: " & Form2.mouselocY & " <\>")
            sw.Flush()
        Catch ex As Exception
            MsgBox(ex.Message)
            Timer1.Stop()
        End Try
    End Sub
End Class