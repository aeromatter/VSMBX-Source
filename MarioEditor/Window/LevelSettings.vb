Imports System.Drawing
Imports MarioEditor.libZPlay

Public Class LevelSettings
    Public Shared BGColor As Color
    Public Shared PlayM As New ZPlay()

    Public Shared startpos As New TStreamTime()
    Public Shared endpos As New TStreamTime()
    Public Shared endtime As New TStreamInfo()

    Private Sub Button26_Click(sender As System.Object, e As System.EventArgs) Handles Button26.Click
        'SMB3 Blocks BG
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-1.png"
        Level.BG2path = Form1.FilePath & "\graphics\background2\background2-2.png"

        Level.BGtype = 1
        BGColor = Color.FromArgb(255, 104, 152, 248)
        Level.BGid = 1

        SetLevelBG()
    End Sub

    Private Sub Button27_Click(sender As System.Object, e As System.EventArgs) Handles Button27.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-3.png"
        Level.BG2path = Form1.FilePath & "\graphics\background2\background2-2.png"

        Level.BGtype = 1
        BGColor = Color.FromArgb(255, 104, 152, 248)
        Level.BGid = 1

        SetLevelBG()
        'REPEATING BOTTOM
    End Sub

    Private Sub Button28_Click(sender As System.Object, e As System.EventArgs) Handles Button28.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-4.png"
        
        Level.BGtype = 6
        BGColor = Color.FromArgb(255, 48, 64, 48)
        Level.BGid = 3

        SetLevelBG()
    End Sub

    Private Sub Button29_Click(sender As System.Object, e As System.EventArgs) Handles Button29.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-5.png"
        
        Level.BGtype = 4
        Level.BGid = 4

        SetLevelBG() 
    End Sub

    Private Sub Button30_Click(sender As System.Object, e As System.EventArgs) Handles Button30.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-7.png"
        
        Level.BGtype = 4
        Level.BGid = 5
        
        SetLevelBG()
    End Sub

    Private Sub Button31_Click(sender As System.Object, e As System.EventArgs) Handles Button31.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-2.png"
        
        Level.BGtype = 2
        BGColor = Color.FromArgb(255, 104, 152, 248)
        Level.BGid = 6

        SetLevelBG()
    End Sub

    Private Sub Button32_Click(sender As System.Object, e As System.EventArgs) Handles Button32.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-36.png"
        
        Level.BGtype = 2
        BGColor = Color.FromArgb(255, 152, 144, 248)
        Level.BGid = 7

        SetLevelBG()
    End Sub

    Private Sub Button33_Click(sender As System.Object, e As System.EventArgs) Handles Button33.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-14.png"
        
        Level.BGtype = 2
        BGColor = Color.FromArgb(255, 240, 120, 64)
        Level.BGid = 8
        
        SetLevelBG()
    End Sub

    Private Sub Button34_Click(sender As System.Object, e As System.EventArgs) Handles Button34.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-15.png"
        
        Level.BGtype = 4
        Level.BGid = 9
        
        SetLevelBG()
    End Sub

    Private Sub Button35_Click(sender As System.Object, e As System.EventArgs) Handles Button35.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-17.png"
        
        Level.BGtype = 6
        Level.BGid = 10
        
        SetLevelBG()
        'REPEATING BOTTOM
    End Sub

    Private Sub Button36_Click(sender As System.Object, e As System.EventArgs) Handles Button36.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-20.png"
        
        Level.BGtype = 2
        BGColor = Color.Black
        Level.BGid = 11
        
        SetLevelBG()
    End Sub

    Private Sub Button37_Click(sender As System.Object, e As System.EventArgs) Handles Button37.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-21.png"
        
        Level.BGtype = 5
        Level.BGid = 12

        SetLevelBG()
    End Sub

    Private Sub Button38_Click(sender As System.Object, e As System.EventArgs) Handles Button38.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-22.png"
        Level.BG2path = Form1.FilePath & "\graphics\background2\background2-2.png"
       
        Level.BGtype = 3
        BGColor = Color.FromArgb(255, 104, 152, 248)
        Level.BGid = 13
        
        SetLevelBG()
    End Sub

    Private Sub Button39_Click(sender As System.Object, e As System.EventArgs) Handles Button39.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-23.png"

        Level.BGtype = 2
        BGColor = Color.FromArgb(255, 0, 0, 24)
        Level.BGid = 14
        
        SetLevelBG()
    End Sub

    Private Sub Button40_Click(sender As System.Object, e As System.EventArgs) Handles Button40.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-24.png"
        
        Level.BGtype = 4
        Level.BGid = 15
        
        SetLevelBG()
    End Sub

    Private Sub Button41_Click(sender As System.Object, e As System.EventArgs) Handles Button41.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-26.png"
        
        Level.BGtype = 5
        Level.BGid = 16
        
        SetLevelBG()
    End Sub

    Private Sub Button42_Click(sender As System.Object, e As System.EventArgs) Handles Button42.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-27.png"
        
        Level.BGtype = 6
        Level.BGid = 17
        
        SetLevelBG()
    End Sub

    Private Sub Button43_Click(sender As System.Object, e As System.EventArgs) Handles Button43.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-35.png"
        Level.BG2path = Form1.FilePath & "\graphics\background2\background2-36.png"
        
        Level.BGtype = 1
        BGColor = Color.FromArgb(255, 152, 144, 248)
        Level.BGid = 18
        
        SetLevelBG()
    End Sub

    Private Sub Button44_Click(sender As System.Object, e As System.EventArgs) Handles Button44.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-37.png"
        Level.BG2path = Form1.FilePath & "\graphics\background2\background2-36.png"

        Level.BGtype = 1
        BGColor = Color.FromArgb(255, 152, 144, 248)
        Level.BGid = 19
        
        SetLevelBG()
    End Sub

    Private Sub Button45_Click(sender As System.Object, e As System.EventArgs) Handles Button45.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-38.png"
        
        Level.BGtype = 2
        BGColor = Color.FromArgb(255, 216, 240, 248)
        Level.BGid = 20
        
        SetLevelBG()
        'REPEATING BOTTOM
    End Sub

    Private Sub Button46_Click(sender As System.Object, e As System.EventArgs) Handles Button46.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-39.png"
        
        Level.BGtype = 4
        Level.BGid = 21
        
        SetLevelBG()
    End Sub

    Private Sub Button47_Click(sender As System.Object, e As System.EventArgs) Handles Button47.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-56.png"
        
        Level.BGtype = 6
        BGColor = Color.FromArgb(255, 8, 0, 96)
        Level.BGid = 22
        
        SetLevelBG()
    End Sub

    Private Sub Button19_Click(sender As System.Object, e As System.EventArgs) Handles Button19.Click
        Level.Music = Form1.FilePath & "\music\smb3-overworld.ogg"
        
        SetLevelMusic()
    End Sub

    Private Sub Button20_Click(sender As System.Object, e As System.EventArgs) Handles Button20.Click
        Level.Music = Form1.FilePath & "\music\smb3-sky.ogg"
        
        SetLevelMusic()
    End Sub

    Private Sub Button21_Click(sender As System.Object, e As System.EventArgs) Handles Button21.Click
        Level.Music = Form1.FilePath & "\music\smb3-underground.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button22_Click(sender As System.Object, e As System.EventArgs) Handles Button22.Click
        Level.Music = Form1.FilePath & "\music\smb3-castle.ogg"
        
        SetLevelMusic()
    End Sub

    Private Sub Button23_Click(sender As System.Object, e As System.EventArgs) Handles Button23.Click
        Level.Music = Form1.FilePath & "\music\smb3-boss.ogg"
        
        SetLevelMusic()
    End Sub

    Private Sub Button24_Click(sender As System.Object, e As System.EventArgs) Handles Button24.Click
        Level.Music = Form1.FilePath & "\music\smb3-water.ogg"
        
        SetLevelMusic()
    End Sub

    Private Sub Button25_Click(sender As System.Object, e As System.EventArgs) Handles Button25.Click
        Level.Music = Form1.FilePath & "\music\smb3-hammer.ogg"
        
        SetLevelMusic()
    End Sub

    Private Sub Button61_Click(sender As System.Object, e As System.EventArgs) Handles Button61.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-11.png"
        
        Level.BGtype = 2
        BGColor = Color.FromArgb(255, 80, 136, 160)
        Level.BGid = 23
        
        SetLevelBG()
    End Sub

    Private Sub LevelSettings_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TextBox2.Text = Level.LevelW / 32
        TextBox3.Text = Level.LevelH / 32

        TextBox4.Text = Play.GravityLevel.ToString
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Try
            If Convert.ToInt32(TextBox2.Text) * 32 > Form2.Width / 32 And Convert.ToInt32(TextBox3.Text) * 32 > Form2.Height / 32 Then
                Level.LevelW = Convert.ToInt32(TextBox2.Text) * 32
                Level.LevelH = Convert.ToInt32(TextBox3.Text) * 32

                Form2.AutoScrollMinSize = New Size(Level.LevelW, Level.LevelH)

                Level.HeightInc = (Level.LevelH - (19 * 32)) / 32
                Form2.Update()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Button62_Click(sender As System.Object, e As System.EventArgs) Handles Button62.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-8.png"
        
        Level.BGtype = 4
        Level.BGid = 24
        
        SetLevelBG()
    End Sub

    Private Sub Button63_Click(sender As System.Object, e As System.EventArgs) Handles Button63.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-9.png"
        
        Level.BGtype = 6
        BGColor = Color.FromArgb(255, 80, 136, 160)
        Level.BGid = 25
        
        SetLevelBG()
    End Sub

    Private Sub Button64_Click(sender As System.Object, e As System.EventArgs) Handles Button64.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-10.png"
        Level.BG2path = Form1.FilePath & "\graphics\background2\background2-9.png"
        
        Level.BGtype = 7
        BGColor = Color.FromArgb(255, 104, 152, 248)
        Level.BGid = 26
        
        SetLevelBG()
    End Sub

    Private Sub Button65_Click(sender As System.Object, e As System.EventArgs) Handles Button65.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-41.png"
        
        Level.BGtype = 6
        BGColor = Color.FromArgb(255, 80, 136, 160)
        Level.BGid = 27
        
        SetLevelBG()
    End Sub

    Private Sub Button66_Click(sender As System.Object, e As System.EventArgs) Handles Button66.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-50.png"
        
        Level.BGtype = 6
        BGColor = Color.FromArgb(255, 80, 136, 160)
        Level.BGid = 28
        
        SetLevelBG()
    End Sub

    Private Sub Button67_Click(sender As System.Object, e As System.EventArgs) Handles Button67.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-51.png"
        
        Level.BGtype = 6
        BGColor = Color.FromArgb(255, 80, 136, 160)
        Level.BGid = 29
        
        SetLevelBG()
    End Sub

    Private Sub Button68_Click(sender As System.Object, e As System.EventArgs) Handles Button68.Click
        Level.Music = Form1.FilePath & "\music\smb-overworld.ogg"
        
        SetLevelMusic()
    End Sub

    Private Sub Button69_Click(sender As System.Object, e As System.EventArgs) Handles Button69.Click
        Level.Music = Form1.FilePath & "\music\smb-underground.ogg"
        
        SetLevelMusic()
    End Sub

    Private Sub Button70_Click(sender As System.Object, e As System.EventArgs) Handles Button70.Click
        Level.Music = Form1.FilePath & "\music\smb-castle.ogg"
        
        SetLevelMusic()
    End Sub

    Private Sub Button71_Click(sender As System.Object, e As System.EventArgs) Handles Button71.Click
        Level.Music = Form1.FilePath & "\music\smb-water.ogg"
        
        SetLevelMusic()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        smb_settings.Visible = True
        smb2_settings.Visible = False
        smb3_settings.Visible = False
        smw_settings.Visible = False
        mariorpg_settings.Visible = False
        mario64_settings.Visible = False
        misc_settings.Visible = False
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        smb_settings.Visible = False
        smb2_settings.Visible = False
        smb3_settings.Visible = True
        smw_settings.Visible = False
        mariorpg_settings.Visible = False
        mario64_settings.Visible = False
        misc_settings.Visible = False
    End Sub

    Private Sub Button48_Click(sender As System.Object, e As System.EventArgs) Handles Button48.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-6.png"
        
        Level.BGtype = 6
        BGColor = Color.FromArgb(255, 80, 136, 160)
        Level.BGid = 30
        
        SetLevelBG()
    End Sub

    Private Sub Button49_Click(sender As System.Object, e As System.EventArgs) Handles Button49.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-25.png"
        
        Level.BGtype = 4
        Level.BGid = 31
        
        SetLevelBG()
    End Sub

    Private Sub Button50_Click(sender As System.Object, e As System.EventArgs) Handles Button50.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-44.png"
        
        Level.BGtype = 6
        BGColor = Color.FromArgb(255, 80, 136, 160)
        Level.BGid = 32
        
        SetLevelBG()
    End Sub

    Private Sub Button51_Click(sender As System.Object, e As System.EventArgs) Handles Button51.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-48.png"
        
        Level.BGtype = 6
        BGColor = Color.FromArgb(255, 80, 136, 160)
        Level.BGid = 33

        SetLevelBG()
    End Sub

    Private Sub Button52_Click(sender As System.Object, e As System.EventArgs) Handles Button52.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-49.png"
        
        Level.BGtype = 6
        BGColor = Color.FromArgb(255, 80, 136, 160)
        Level.BGid = 34
        
        SetLevelBG()
    End Sub

    Private Sub Button53_Click(sender As System.Object, e As System.EventArgs) Handles Button53.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-52.png"
        
        Level.BGtype = 6
        BGColor = Color.FromArgb(255, 80, 136, 160)
        Level.BGid = 35
        
        SetLevelBG()
    End Sub

    Private Sub Button54_Click(sender As System.Object, e As System.EventArgs) Handles Button54.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-53.png"
        
        Level.BGtype = 6
        BGColor = Color.FromArgb(255, 80, 136, 160)
        Level.BGid = 36
        
        SetLevelBG()
    End Sub

    Private Sub Button55_Click(sender As System.Object, e As System.EventArgs) Handles Button55.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-54.png"
        
        Level.BGtype = 6
        BGColor = Color.FromArgb(255, 80, 136, 160)
        Level.BGid = 37
        
        SetLevelBG()
    End Sub

    Private Sub Button56_Click(sender As System.Object, e As System.EventArgs) Handles Button56.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-57.png"
        
        Level.BGtype = 6
        BGColor = Color.FromArgb(255, 80, 136, 160)
        Level.BGid = 38
        
        SetLevelBG()
    End Sub

    Private Sub Button57_Click(sender As System.Object, e As System.EventArgs) Handles Button57.Click
        Level.Music = Form1.FilePath & "\music\smb2-overworld.ogg"
        
        SetLevelMusic()
    End Sub

    Private Sub Button58_Click(sender As System.Object, e As System.EventArgs) Handles Button58.Click
        Level.Music = Form1.FilePath & "\music\smb2-underground.ogg"
        
        SetLevelMusic()
    End Sub

    Private Sub Button59_Click(sender As System.Object, e As System.EventArgs) Handles Button59.Click
        Level.Music = Form1.FilePath & "\music\smb2-boss.ogg"
        
        SetLevelMusic()
    End Sub

    Private Sub Button60_Click(sender As System.Object, e As System.EventArgs) Handles Button60.Click
        Level.Music = Form1.FilePath & "\music\smb2-wart.ogg"
        
        SetLevelMusic()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        smb_settings.Visible = False
        smb2_settings.Visible = True
        smb3_settings.Visible = False
        smw_settings.Visible = False
        mariorpg_settings.Visible = False
        mario64_settings.Visible = False
        misc_settings.Visible = False
    End Sub

    Private Sub Button72_Click(sender As System.Object, e As System.EventArgs) Handles Button72.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-12.png"
        
        Level.BGtype = 6
        BGColor = Color.FromArgb(255, 80, 136, 160)
        Level.BGid = 39
        
        SetLevelBG()
    End Sub

    Private Sub Button73_Click(sender As System.Object, e As System.EventArgs) Handles Button73.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-32.png"
        
        Level.BGtype = 6
        BGColor = Color.FromArgb(255, 80, 136, 160)
        Level.BGid = 40
        
        SetLevelBG()
    End Sub

    Private Sub Button74_Click(sender As System.Object, e As System.EventArgs) Handles Button74.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-34.png"
        
        Level.BGtype = 6
        BGColor = Color.FromArgb(255, 80, 136, 160)
        Level.BGid = 41
        
        SetLevelBG()
    End Sub

    Private Sub Button75_Click(sender As System.Object, e As System.EventArgs) Handles Button75.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-33.png"
        
        Level.BGtype = 6
        BGColor = Color.FromArgb(255, 80, 136, 160)
        Level.BGid = 42
        
        SetLevelBG()
    End Sub

    Private Sub Button76_Click(sender As System.Object, e As System.EventArgs) Handles Button76.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-31.png"
        
        Level.BGtype = 6
        BGColor = Color.FromArgb(255, 80, 136, 160)
        Level.BGid = 43
        
        SetLevelBG()
    End Sub

    Private Sub Button77_Click(sender As System.Object, e As System.EventArgs) Handles Button77.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-18.png"
        
        Level.BGtype = 8
        BGColor = Color.FromArgb(255, 80, 136, 160)
        Level.BGid = 44
        
        SetLevelBG()
    End Sub

    Private Sub Button78_Click(sender As System.Object, e As System.EventArgs) Handles Button78.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-19.png"
        
        Level.BGtype = 6
        BGColor = Color.FromArgb(255, 80, 136, 160)
        Level.BGid = 45
        
        SetLevelBG()
    End Sub

    Private Sub Button79_Click(sender As System.Object, e As System.EventArgs) Handles Button79.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-13.png"

        Level.BGtype = 6
        BGColor = Color.FromArgb(255, 80, 136, 160)
        Level.BGid = 46
        
        SetLevelBG()
    End Sub

    Private Sub Button80_Click(sender As System.Object, e As System.EventArgs) Handles Button80.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-29.png"
        
        Level.BGtype = 8
        BGColor = Color.FromArgb(255, 80, 136, 160)
        Level.BGid = 47
        
        SetLevelBG()
    End Sub

    Private Sub Button81_Click(sender As System.Object, e As System.EventArgs) Handles Button81.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-30.png"
        
        Level.BGtype = 8
        BGColor = Color.FromArgb(255, 80, 136, 160)
        Level.BGid = 48
        
        SetLevelBG()
    End Sub

    Private Sub Button82_Click(sender As System.Object, e As System.EventArgs) Handles Button82.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-42.png"
        
        Level.BGtype = 8
        BGColor = Color.FromArgb(255, 80, 136, 160)
        Level.BGid = 49
        
        SetLevelBG()
    End Sub

    Private Sub Button83_Click(sender As System.Object, e As System.EventArgs) Handles Button83.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-43.png"
        
        Level.BGtype = 6
        BGColor = Color.FromArgb(255, 80, 136, 160)
        Level.BGid = 50
        
        SetLevelBG()
    End Sub

    Private Sub Button84_Click(sender As System.Object, e As System.EventArgs) Handles Button84.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-28.png"
        
        Level.BGtype = 4
        Level.BGid = 51
        
        SetLevelBG()
    End Sub

    Private Sub Button85_Click(sender As System.Object, e As System.EventArgs) Handles Button85.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-55.png"
        
        Level.BGtype = 8
        BGColor = Color.FromArgb(255, 80, 136, 160)
        Level.BGid = 52
        
        SetLevelBG()
    End Sub

    Private Sub Button86_Click(sender As System.Object, e As System.EventArgs) Handles Button86.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-58.png"
        
        Level.BGtype = 8
        BGColor = Color.FromArgb(255, 80, 136, 160)
        Level.BGid = 53
        
        SetLevelBG()
    End Sub

    Private Sub Button87_Click(sender As System.Object, e As System.EventArgs) Handles Button87.Click
        Level.Music = Form1.FilePath & "\music\smw-overworld.ogg"
        
        SetLevelMusic()
    End Sub

    Private Sub Button88_Click(sender As System.Object, e As System.EventArgs) Handles Button88.Click
        Level.Music = Form1.FilePath & "\music\smw-sky.ogg"
        
        SetLevelMusic()
    End Sub

    Private Sub Button89_Click(sender As System.Object, e As System.EventArgs) Handles Button89.Click
        Level.Music = Form1.FilePath & "\music\smw-cave.ogg"
        
        SetLevelMusic()
    End Sub

    Private Sub Button90_Click(sender As System.Object, e As System.EventArgs) Handles Button90.Click
        Level.Music = Form1.FilePath & "\music\smw-ghosthouse.ogg"
        
        SetLevelMusic()
    End Sub

    Private Sub Button91_Click(sender As System.Object, e As System.EventArgs) Handles Button91.Click
        Level.Music = Form1.FilePath & "\music\smw-castle.ogg"
        
        SetLevelMusic()
    End Sub

    Private Sub Button92_Click(sender As System.Object, e As System.EventArgs) Handles Button92.Click
        Level.Music = Form1.FilePath & "\music\smw-water.ogg"
        
        SetLevelMusic()
    End Sub

    Private Sub Button93_Click(sender As System.Object, e As System.EventArgs) Handles Button93.Click
        Level.Music = Form1.FilePath & "\music\smw-boss.ogg"
        
        SetLevelMusic()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        smb_settings.Visible = False
        smb2_settings.Visible = False
        smb3_settings.Visible = False
        smw_settings.Visible = True
        mariorpg_settings.Visible = False
        mario64_settings.Visible = False
        misc_settings.Visible = False
    End Sub

    Private Sub Button94_Click(sender As System.Object, e As System.EventArgs) Handles Button94.Click
        Level.Music = Form1.FilePath & "\music\mariorpg-forestmaze.ogg"
        
        SetLevelMusic()
    End Sub

    Private Sub Button95_Click(sender As System.Object, e As System.EventArgs) Handles Button95.Click
        Level.Music = Form1.FilePath & "\music\mariorpg-mariospad.ogg"
        
        SetLevelMusic()
    End Sub

    Private Sub Button96_Click(sender As System.Object, e As System.EventArgs) Handles Button96.Click
        Level.Music = Form1.FilePath & "\music\mariorpg-seasidetown.ogg"
        
        SetLevelMusic()
    End Sub

    Private Sub Button97_Click(sender As System.Object, e As System.EventArgs) Handles Button97.Click
        Level.Music = Form1.FilePath & "\music\mariorpg-bowser.ogg"
        
        SetLevelMusic()
    End Sub

    Private Sub Button98_Click(sender As System.Object, e As System.EventArgs) Handles Button98.Click
        Level.Music = Form1.FilePath & "\music\mariorpg-rosetown.ogg"
        
        SetLevelMusic()
    End Sub

    Private Sub Button99_Click(sender As System.Object, e As System.EventArgs) Handles Button99.Click
        Level.Music = Form1.FilePath & "\music\mariorpg-nimbusland.ogg"
        
        SetLevelMusic()
    End Sub

    Private Sub Button100_Click(sender As System.Object, e As System.EventArgs) Handles Button100.Click
        Level.Music = Form1.FilePath & "\music\mariorpg-tadpolepond.ogg"
        
        SetLevelMusic()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        smb_settings.Visible = False
        smb2_settings.Visible = False
        smb3_settings.Visible = False
        smw_settings.Visible = False
        mariorpg_settings.Visible = True
        mario64_settings.Visible = False
        misc_settings.Visible = False
    End Sub

    Private Sub Button101_Click(sender As System.Object, e As System.EventArgs) Handles Button101.Click
        Level.Music = Form1.FilePath & "\music\mario64-maintheme.ogg"
        
        SetLevelMusic()
    End Sub

    Private Sub Button102_Click(sender As System.Object, e As System.EventArgs) Handles Button102.Click
        Level.Music = Form1.FilePath & "\music\mario64-castle.ogg"
        
        SetLevelMusic()
    End Sub

    Private Sub Button103_Click(sender As System.Object, e As System.EventArgs) Handles Button103.Click
        Level.Music = Form1.FilePath & "\music\sm64-desert.ogg"
        
        SetLevelMusic()
    End Sub

    Private Sub Button104_Click(sender As System.Object, e As System.EventArgs) Handles Button104.Click
        Level.Music = Form1.FilePath & "\music\mario64-snowmountain.ogg"
        
        SetLevelMusic()
    End Sub

    Private Sub Button105_Click(sender As System.Object, e As System.EventArgs) Handles Button105.Click
        Level.Music = Form1.FilePath & "\music\mario64-boss.ogg"
        
        SetLevelMusic()
    End Sub

    Private Sub Button106_Click(sender As System.Object, e As System.EventArgs) Handles Button106.Click
        Level.Music = Form1.FilePath & "\music\mario64-water.ogg"
        
        SetLevelMusic()
    End Sub

    Private Sub Button107_Click(sender As System.Object, e As System.EventArgs) Handles Button107.Click
        Level.Music = Form1.FilePath & "\music\mario64-cave.ogg"
        
        SetLevelMusic()
    End Sub

    Private Sub Button108_Click(sender As System.Object, e As System.EventArgs) Handles Button108.Click
        Level.Music = Form1.FilePath & "\music\smg-star-reactor.ogg"
        
        SetLevelMusic()
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        smb_settings.Visible = False
        smb2_settings.Visible = False
        smb3_settings.Visible = False
        smw_settings.Visible = False
        mariorpg_settings.Visible = False
        mario64_settings.Visible = True
        misc_settings.Visible = False
    End Sub

    Private Sub Button109_Click(sender As System.Object, e As System.EventArgs) Handles Button109.Click
        Level.BGtype = 0
        BGColor = Color.Black
        Level.BG = Nothing
        Level.BG2 = Nothing
    End Sub

    Private Sub Button110_Click(sender As System.Object, e As System.EventArgs) Handles Button110.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-16.png"
        
        Level.BGtype = 4
        Level.BGid = 54
        
        SetLevelBG()
    End Sub

    Private Sub Button111_Click(sender As System.Object, e As System.EventArgs) Handles Button111.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-45.png"
        
        Level.BGtype = 4
        Level.BGid = 55
        
        SetLevelBG()
    End Sub

    Private Sub Button112_Click(sender As System.Object, e As System.EventArgs) Handles Button112.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-46.png"
        
        Level.BGtype = 4
        Level.BGid = 56
        
        SetLevelBG()
    End Sub

    Private Sub Button113_Click(sender As System.Object, e As System.EventArgs) Handles Button113.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-47.png"
        
        Level.BGtype = 4
        Level.BGid = 57
        
        SetLevelBG()
    End Sub

    Private Sub Button114_Click(sender As System.Object, e As System.EventArgs) Handles Button114.Click
        Level.BGpath = Form1.FilePath & "\graphics\background2\background2-40.png"
        
        Level.BGtype = 6
        Level.BGid = 58
        
        SetLevelBG()
    End Sub

    Private Sub Button115_Click(sender As System.Object, e As System.EventArgs) Handles Button115.Click
        PlayM.StopPlayback()
    End Sub

    Private Sub Button116_Click(sender As System.Object, e As System.EventArgs) Handles Button116.Click
        Level.Music = Form1.FilePath & "\music\sm-crateria.ogg"
        
        SetLevelMusic()
    End Sub

    Private Sub Button117_Click(sender As System.Object, e As System.EventArgs) Handles Button117.Click
        Level.Music = Form1.FilePath & "\music\sm-brinstar.ogg"
        
        SetLevelMusic()
    End Sub

    Private Sub Button118_Click(sender As System.Object, e As System.EventArgs) Handles Button118.Click
        Level.Music = Form1.FilePath & "\music\tds-metroid-charge.ogg"
        
        SetLevelMusic()
    End Sub

    Private Sub Button119_Click(sender As System.Object, e As System.EventArgs) Handles Button119.Click
        Level.Music = Form1.FilePath & "\music\sm-itemroom.ogg"
        
        SetLevelMusic()
    End Sub

    Private Sub Button120_Click(sender As System.Object, e As System.EventArgs) Handles Button120.Click
        Level.Music = Form1.FilePath & "\music\sm-brain.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button121_Click(sender As System.Object, e As System.EventArgs) Handles Button121.Click
        Level.Music = IO.Path.GetDirectoryName(Level.LevelPath) & "\" & TextBox1.Text

        SetLevelMusic()
    End Sub

    Private Sub Button122_Click(sender As System.Object, e As System.EventArgs) Handles Button122.Click
        Level.Music = Form1.FilePath & "\music\nsmb-overworld.ogg"
        
        SetLevelMusic()
    End Sub

    Private Sub Button123_Click(sender As System.Object, e As System.EventArgs) Handles Button123.Click
        Level.Music = Form1.FilePath & "\music\ssbb-airship.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button124_Click(sender As System.Object, e As System.EventArgs) Handles Button124.Click
        Level.Music = Form1.FilePath & "\music\mkwii-mushroom-gorge.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button125_Click(sender As System.Object, e As System.EventArgs) Handles Button125.Click
        Level.Music = Form1.FilePath & "\music\smg-beach-bowl-galaxy.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button126_Click(sender As System.Object, e As System.EventArgs) Handles Button126.Click
        Level.Music = Form1.FilePath & "\music\ssbb-zelda2.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button127_Click(sender As System.Object, e As System.EventArgs) Handles Button127.Click
        Level.Music = Form1.FilePath & "\music\pm-yoshis-village.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button128_Click(sender As System.Object, e As System.EventArgs) Handles Button128.Click
        Level.Music = Form1.FilePath & "\music\pm-shiver-mountain.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button129_Click(sender As System.Object, e As System.EventArgs) Handles Button129.Click
        Level.Music = Form1.FilePath & "\music\ssbb-meta.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button130_Click(sender As System.Object, e As System.EventArgs) Handles Button130.Click
        Level.Music = Form1.FilePath & "\music\z3-lost-woods.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        smb_settings.Visible = False
        smb2_settings.Visible = False
        smb3_settings.Visible = False
        smw_settings.Visible = False
        mariorpg_settings.Visible = False
        mario64_settings.Visible = False
        misc_settings.Visible = True
    End Sub

    Private Sub Button131_Click(sender As System.Object, e As System.EventArgs) Handles Button131.Click
        Level.Music = Form1.FilePath & "\music\sf-corneria.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button132_Click(sender As System.Object, e As System.EventArgs) Handles Button132.Click
        Level.Music = Form1.FilePath & "\music\ssbb-underground.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button133_Click(sender As System.Object, e As System.EventArgs) Handles Button133.Click
        Level.Music = Form1.FilePath & "\music\ssbb-waluigi.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button134_Click(sender As System.Object, e As System.EventArgs) Handles Button134.Click
        Level.Music = Form1.FilePath & "\music\smg2-fg.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        Form2.EditMode = 3
    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        Form2.EditMode = 4
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        If Convert.ToInt32(TextBox4.Text) > -1 Then
            Play.GravityLevel = CInt(TextBox4.Text)
        Else
            TextBox4.Text = 12
            MsgBox("The minimum gravity level is 0. Gravity has been reset to its default value.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        TextBox4.Text = 12
    End Sub

    Public Shared Sub SetLevelMusic()
        PlayM.StopPlayback()

        PlayM.GetPosition(startpos)
        PlayM.GetStreamInfo(endtime)

        endpos.sec = endtime.Length.sec

        PlayM.OpenFile(Level.Music, TStreamFormat.sfOgg)
        PlayM.PlayLoop(TTimeFormat.tfSecond, startpos, TTimeFormat.tfSecond, endpos, 1000, True)
    End Sub

    Public Sub SetLevelBG()
        Dim g As Graphics = Form2.CreateGraphics()

        Select Case Level.BGtype
            Case 1, 3, 7
                Dim fs As New System.IO.FileStream(Level.BGpath, System.IO.FileMode.Open)
                Level.BG = Image.FromStream(fs)

                g.DrawImage(Level.BG, New Rectangle(0, Form2.Height - 538, Level.BG.Width, Level.BG.Height))

                fs.Close()
                fs.Dispose()

                fs = New System.IO.FileStream(Level.BG2path, System.IO.FileMode.Open)
                Level.BG2 = Image.FromStream(fs)
                g.DrawImage(Level.BG2, New Rectangle(0, Level.BG.Height - Level.BG2.Height, Level.BG2.Width, Level.BG2.Height))

                fs.Close()
                fs.Dispose()
            Case 2, 4, 5, 6, 8
                Dim fs As New System.IO.FileStream(Level.BGpath, System.IO.FileMode.Open)
                Level.BG = Image.FromStream(fs)
                g.DrawImage(Level.BG, New Rectangle(0, Form2.Height - 538, Level.BG.Width, Level.BG.Height))

                fs.Close()
                fs.Dispose()
        End Select

        Form2.Refresh()
    End Sub
End Class