Public Class IRC

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        IRCclient.Channel = TextBox1.Text
        IRCclient.Pass = TextBox3.Text
        IRCclient.Nick = TextBox4.Text & "|VSMBX"
        IRCclient.User = TextBox4.Text

        IRCclient.Show()
        IRCclient.Focus()
    End Sub

    Private Sub IRC_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class