Imports System.IO
Imports System.Net
Imports System.Net.Sockets

Public Class IRCclient
    Public TCPClient As TcpClient
    Public NS As NetworkStream
    Public sr As StreamReader
    Public sw As StreamWriter

    Public TCPListener As TcpListener
    Public TCPClient2 As TcpClient
    Public NS2 As NetworkStream
    Public sr2 As StreamReader

    Public Shared Channel As String
    Public Shared Nick As String
    Public Shared User As String
    Public Shared Pass As String
    Public Server As String = "irc.stardustfields.net"
    Public Port As Integer = 6667
    Public CanJoin As Boolean = False
    Public CMD As String = ""
    Dim AddNames As Boolean = False
    Public ReadTopic As Boolean = False
    Public Joined As Boolean = False
    Public ReadMSG As Boolean = False

    Private Sub IRCclient_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TCPClient = New TcpClient(Server, Port)

        NS = TCPClient.GetStream
        sr = New StreamReader(NS)
        sw = New StreamWriter(NS)

        sw.WriteLine(String.Format("USER " & "vsmbxuser" & " " & """" & """" & " " & """" & Dns.GetHostName & """" & " " & "VSMBX_USER" & vbCrLf))
        sw.Flush()

        sw.WriteLine(String.Format("NICK " & Nick & vbCrLf))
        sw.Flush()

        sw.WriteLine(String.Format("JOIN " & Channel & vbCrLf))
        sw.Flush()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        sr = New StreamReader(NS)
        sw = New StreamWriter(NS)

        If NS.DataAvailable = True Then
            While sr.Peek > -1
                RichTextBox1.AppendText(Convert.ToChar(sr.Read()).ToString)
            End While
        End If

        If CanJoin = False And RichTextBox1.Text.Contains("End of /MOTD command.") Then
            CanJoin = True
            sw.WriteLine(String.Format("JOIN " & Channel & vbCrLf))
            sw.Flush()
            Timer1.Stop()
            RichTextBox1.Clear()

            Timer2.Start()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        sr = New StreamReader(NS)
        sw = New StreamWriter(NS)

        If NS.DataAvailable = True Then
            While sr.Peek > -1
                RichTextBox2.AppendText(Convert.ToChar(sr.Read()).ToString)
            End While
        End If

        RichTextBox2.Text = RichTextBox2.Text.Trim() & vbNewLine

        Dim lastmsg As String = RichTextBox2.Lines(RichTextBox2.Lines.Length - 2)

        For Each line As String In RichTextBox2.Lines
            If line.Contains("353") And AddNames = False Then
                Dim ping As String = line.Split(":").Last
                ping = ping.TrimEnd(Chr(0))
                ListBox1.Items.AddRange(ping.Split(" "c))

                AddNames = True

                ListBox1.Sorted = True
            End If

            If line.Contains("JOIN") And Joined = False Then
                RichTextBox1.Text += "Now talking in " & Channel & vbNewLine
                Joined = True
            ElseIf line.Contains("332") And ReadTopic = False Then
                RichTextBox1.Text += line.Replace(":irc.stardustfields.net 332 " & Nick & " " & Channel & " :", "Topic for " & Channel & " is: ")
                RichTextBox1.Text += vbNewLine
                ReadTopic = True
            End If
        Next

        If lastmsg.Contains("PING") Then
            Dim ping As String = lastmsg.Split(":").Last
            ping = ping.TrimEnd(Chr(0))

            sw.WriteLine(String.Format("PONG " & ping & vbCrLf))
            sw.Flush()

            RichTextBox2.AppendText(String.Format("PONG " & ping & vbCrLf))
        ElseIf lastmsg.Contains("PRIVMSG") And ReadMSG = False Then
            Dim Name() As String
            Name = lastmsg.Split("!")

            Dim msg As String = lastmsg.Substring(lastmsg.LastIndexOf(":") + 1)

            RichTextBox1.Text += "<" & Name(0).Replace(":", "") & "> " & msg & vbNewLine

            RichTextBox2.Text += "Read Message"
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text.StartsWith("/") = True Then
            CMD = TextBox1.Text.Substring(1, TextBox1.Text.IndexOf(" "))

            MsgBox(CMD)
            Select Case CMD
                Case "NICK "
                    sw.WriteLine(String.Format(CMD & " " & TextBox1.Text & vbCrLf))
                    sw.Flush()
                Case "MODE "
                    sw.WriteLine(String.Format(CMD & " " & TextBox1.Text & vbCrLf))
                    sw.Flush()
            End Select
        Else
            sw.WriteLine(String.Format("PRIVMSG " & Channel & " :" & TextBox1.Text & vbCrLf))
            sw.Flush()

            RichTextBox1.AppendText("<" & Nick & "> " & TextBox1.Text & vbCrLf)
            TextBox1.Clear()
        End If

    End Sub

    Private Sub RichTextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles RichTextBox2.TextChanged

    End Sub
End Class