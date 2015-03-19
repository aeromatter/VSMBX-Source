Public Class AdvancedBlocks

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Label3.Enabled = True
        Label4.Enabled = True

        TextBox3.Enabled = True
        TextBox4.Enabled = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Label3.Enabled = False
        Label4.Enabled = False

        TextBox3.Enabled = False
        TextBox4.Enabled = False
    End Sub
End Class