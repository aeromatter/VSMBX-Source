Public Class IRC

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnConnect.Click
        If txtBoxChannel.Text.Trim() = "" Then
            lblChannel.ForeColor = Color.Red
            Return
        Else
            IRCclient.Channel = txtBoxChannel.Text.Trim() 'Always trim when spaces matter
        End If

        IRCclient.Pass = txtBoxPassword.Text.Trim() 'Optional

        If txtBoxUsername.Text.Trim() = "" Then
            lblUsername.ForeColor = Color.Red
            Return
        Else
            IRCclient.Nick = txtBoxUsername.Text.Trim() & "|VSMBX"
            IRCclient.User = txtBoxUsername.Text.Trim()
        End If
        
        IRCclient.Show()
        IRCclient.Focus()

        IRCclient.MdiParent = Form1
        IRCclient.Location = New Point(Form2.Width, 0)
    End Sub

    Private Sub IRC_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class