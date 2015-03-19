Public Class TestSettings

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            ComboBox1.Items.Clear()

            ComboBox1.Items.Add("Mario")
            ComboBox1.Items.Add("Super Mario")
            ComboBox1.Items.Add("Fire Mario")
            ComboBox1.Items.Add("Ice Mario")
            ComboBox1.Items.Add("Racoon Mario")
            ComboBox1.Items.Add("Tanooki Mario")
            ComboBox1.Items.Add("Hammer Mario")

            ComboBox2.Items.Clear()

            ComboBox2.Items.Add("None")
            ComboBox2.Items.Add("Green Yoshi")
            ComboBox2.Items.Add("Blue Yoshi")
            ComboBox2.Items.Add("Yellow Yoshi")
            ComboBox2.Items.Add("Red Yoshi")
            ComboBox2.Items.Add("Black Yoshi")
            ComboBox2.Items.Add("Purple Yoshi")
            ComboBox2.Items.Add("Pink Yoshi")
            ComboBox2.Items.Add("Ice Yoshi")
            ComboBox2.Items.Add("Kuribo's Shoe")
            ComboBox2.Items.Add("Podoboo's Shoe")
            ComboBox2.Items.Add("Lakitu's Shoe")
        End If

        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
    End Sub

    Private Sub TestSettings_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0

        ComboBox3.SelectedIndex = 0
        ComboBox4.SelectedIndex = 0

        RadioButton1.Checked = True
        RadioButton7.Checked = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            ComboBox1.Items.Clear()

            ComboBox1.Items.Add("Luigi")
            ComboBox1.Items.Add("Super Luigi")
            ComboBox1.Items.Add("Fire Luigi")
            ComboBox1.Items.Add("Ice Luigi")
            ComboBox1.Items.Add("Racoon Luigi")
            ComboBox1.Items.Add("Tanooki Luigi")
            ComboBox1.Items.Add("Hammer Luigi")

            ComboBox2.Items.Clear()

            ComboBox2.Items.Add("None")
            ComboBox2.Items.Add("Green Yoshi")
            ComboBox2.Items.Add("Blue Yoshi")
            ComboBox2.Items.Add("Yellow Yoshi")
            ComboBox2.Items.Add("Red Yoshi")
            ComboBox2.Items.Add("Black Yoshi")
            ComboBox2.Items.Add("Purple Yoshi")
            ComboBox2.Items.Add("Pink Yoshi")
            ComboBox2.Items.Add("Ice Yoshi")
            ComboBox2.Items.Add("Kuribo's Shoe")
            ComboBox2.Items.Add("Podoboo's Shoe")
            ComboBox2.Items.Add("Lakitu's Shoe")
        End If

        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            ComboBox1.Items.Clear()

            ComboBox1.Items.Add("Peach")
            ComboBox1.Items.Add("Super Peach")
            ComboBox1.Items.Add("Fire Peach")
            ComboBox1.Items.Add("Ice Peach")
            ComboBox1.Items.Add("Racoon Peach")
            ComboBox1.Items.Add("Tanooki Peach")
            ComboBox1.Items.Add("Bomb Peach")

            ComboBox2.Items.Clear()

            ComboBox2.Items.Add("None")
            ComboBox2.Items.Add("Kuribo's Shoe")
            ComboBox2.Items.Add("Podoboo's Shoe")
            ComboBox2.Items.Add("Lakitu's Shoe")
        End If

        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            ComboBox1.Items.Clear()

            ComboBox1.Items.Add("Toad")
            ComboBox1.Items.Add("Super Toad")
            ComboBox1.Items.Add("Fire Toad")
            ComboBox1.Items.Add("Ice Toad")
            ComboBox1.Items.Add("Racoon Toad")
            ComboBox1.Items.Add("Tanooki Toad")
            ComboBox1.Items.Add("Boomerang Toad")

            ComboBox2.Items.Clear()

            ComboBox2.Items.Add("None")
            ComboBox2.Items.Add("Kuribo's Shoe")
            ComboBox2.Items.Add("Podoboo's Shoe")
            ComboBox2.Items.Add("Lakitu's Shoe")
        End If

        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            ComboBox1.Items.Clear()

            ComboBox1.Items.Add("Link (1 HP)")
            ComboBox1.Items.Add("Link (2 HP)")
            ComboBox1.Items.Add("Fire Link")
            ComboBox1.Items.Add("Ice Link")
            ComboBox1.Items.Add("Fairy Link")
            ComboBox1.Items.Add("Gold Link")
            ComboBox1.Items.Add("Shadow Link")

            ComboBox2.Items.Clear()

            ComboBox2.Items.Add("None")
        End If

        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            ComboBox4.Items.Clear()

            ComboBox4.Items.Add("Mario")
            ComboBox4.Items.Add("Super Mario")
            ComboBox4.Items.Add("Fire Mario")
            ComboBox4.Items.Add("Ice Mario")
            ComboBox4.Items.Add("Racoon Mario")
            ComboBox4.Items.Add("Tanooki Mario")
            ComboBox4.Items.Add("Hammer Mario")

            ComboBox3.Items.Clear()

            ComboBox3.Items.Add("None")
            ComboBox3.Items.Add("Green Yoshi")
            ComboBox3.Items.Add("Blue Yoshi")
            ComboBox3.Items.Add("Yellow Yoshi")
            ComboBox3.Items.Add("Red Yoshi")
            ComboBox3.Items.Add("Black Yoshi")
            ComboBox3.Items.Add("Purple Yoshi")
            ComboBox3.Items.Add("Pink Yoshi")
            ComboBox3.Items.Add("Ice Yoshi")
            ComboBox3.Items.Add("Kuribo's Shoe")
            ComboBox3.Items.Add("Podoboo's Shoe")
            ComboBox3.Items.Add("Lakitu's Shoe")
        End If

        ComboBox4.SelectedIndex = 0
        ComboBox3.SelectedIndex = 0
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked = True Then
            ComboBox4.Items.Clear()

            ComboBox4.Items.Add("Luigi")
            ComboBox4.Items.Add("Super Luigi")
            ComboBox4.Items.Add("Fire Luigi")
            ComboBox4.Items.Add("Ice Luigi")
            ComboBox4.Items.Add("Racoon Luigi")
            ComboBox4.Items.Add("Tanooki Luigi")
            ComboBox4.Items.Add("Hammer Luigi")

            ComboBox3.Items.Clear()

            ComboBox3.Items.Add("None")
            ComboBox3.Items.Add("Green Yoshi")
            ComboBox3.Items.Add("Blue Yoshi")
            ComboBox3.Items.Add("Yellow Yoshi")
            ComboBox3.Items.Add("Red Yoshi")
            ComboBox3.Items.Add("Black Yoshi")
            ComboBox3.Items.Add("Purple Yoshi")
            ComboBox3.Items.Add("Pink Yoshi")
            ComboBox3.Items.Add("Ice Yoshi")
            ComboBox3.Items.Add("Kuribo's Shoe")
            ComboBox3.Items.Add("Podoboo's Shoe")
            ComboBox3.Items.Add("Lakitu's Shoe")
        End If

        ComboBox4.SelectedIndex = 0
        ComboBox3.SelectedIndex = 0
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton8.CheckedChanged
        If RadioButton8.Checked = True Then
            ComboBox4.Items.Clear()

            ComboBox4.Items.Add("Peach")
            ComboBox4.Items.Add("Super Peach")
            ComboBox4.Items.Add("Fire Peach")
            ComboBox4.Items.Add("Ice Peach")
            ComboBox4.Items.Add("Racoon Peach")
            ComboBox4.Items.Add("Tanooki Peach")
            ComboBox4.Items.Add("Bomb Peach")

            ComboBox3.Items.Clear()

            ComboBox3.Items.Add("None")
            ComboBox3.Items.Add("Kuribo's Shoe")
            ComboBox3.Items.Add("Podoboo's Shoe")
            ComboBox3.Items.Add("Lakitu's Shoe")
        End If

        ComboBox4.SelectedIndex = 0
        ComboBox3.SelectedIndex = 0
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton9.CheckedChanged
        If RadioButton9.Checked = True Then
            ComboBox4.Items.Clear()

            ComboBox4.Items.Add("Toad")
            ComboBox4.Items.Add("Super Toad")
            ComboBox4.Items.Add("Fire Toad")
            ComboBox4.Items.Add("Ice Toad")
            ComboBox4.Items.Add("Racoon Toad")
            ComboBox4.Items.Add("Tanooki Toad")
            ComboBox4.Items.Add("Boomerang Toad")

            ComboBox3.Items.Clear()

            ComboBox3.Items.Add("None")
            ComboBox3.Items.Add("Kuribo's Shoe")
            ComboBox3.Items.Add("Podoboo's Shoe")
            ComboBox3.Items.Add("Lakitu's Shoe")
        End If

        ComboBox4.SelectedIndex = 0
        ComboBox3.SelectedIndex = 0
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton10.CheckedChanged
        If RadioButton10.Checked = True Then
            ComboBox4.Items.Clear()

            ComboBox4.Items.Add("Link (1 HP)")
            ComboBox4.Items.Add("Link (2 HP)")
            ComboBox4.Items.Add("Fire Link")
            ComboBox4.Items.Add("Ice Link")
            ComboBox4.Items.Add("Fairy Link")
            ComboBox4.Items.Add("Gold Link")
            ComboBox4.Items.Add("Shadow Link")

            ComboBox3.Items.Clear()

            ComboBox3.Items.Add("None")
        End If

        ComboBox4.SelectedIndex = 0
        ComboBox3.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            Play.CurPlayer = 1
            Play.P1 = 1
            Play.MarioState = ComboBox1.SelectedIndex
        ElseIf RadioButton2.Checked = True Then
            Play.CurPlayer = 2
            Play.P1 = 2
            Play.LuigiState = ComboBox1.SelectedIndex
        ElseIf RadioButton3.Checked = True Then
            Play.CurPlayer = 3
            Play.P1 = 3
            Play.PeachState = ComboBox1.SelectedIndex
        ElseIf RadioButton4.Checked = True Then
            Play.CurPlayer = 4
            Play.P1 = 4
            Play.ToadState = ComboBox1.SelectedIndex
        End If

        Play.GetPlayer()

        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ControlSettings.Show()
    End Sub
End Class