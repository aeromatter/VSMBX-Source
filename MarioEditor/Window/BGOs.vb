Public Class BGOs_Form
    Dim bmp As Bitmap
    Dim g As Graphics
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        g = Me.CreateGraphics
        smb_bgos.Visible = False
        smb2_bgos.Visible = False
        smb3_bgos.Visible = True
        smw_bgos.Visible = False
        misc_bgos.Visible = False
    End Sub

    Public Sub LoadSMB3bgos()
        Dim fs As New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-1.png", System.IO.FileMode.Open)
        Dim graphic As Image
        graphic = Image.FromStream(fs)
        Button6.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-7.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button7.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-2.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button8.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-6.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button9.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-10.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button10.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-114.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button11.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-3.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button12.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-8.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button13.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-4.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button14.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-5.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button15.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-9.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button16.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'block tiles
        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-64.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button17.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-39.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button18.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-40.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button19.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-14.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button20.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-15.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button21.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-79.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button22.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'water
        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-65.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 96), New Rectangle(0, 0, 32, 96), GraphicsUnit.Pixel)
        Button23.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-82.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button24.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-172.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button25.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-170.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button26.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        ''''
        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-165.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button27.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        ''''
        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-83.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button28.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-66.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button29.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-171.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button30.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        'smb3 misc
        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-89.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button31.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-94.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button32.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-46.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button33.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-93.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button34.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-36.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 64, 96), GraphicsUnit.Pixel)
        Button35.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-37.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button36.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-163.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button37.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-91.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button38.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-95.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button39.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-45.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button40.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-69.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button41.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-68.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 96, 64), GraphicsUnit.Pixel)
        Button42.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-38.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button43.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-90.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button44.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-96.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button45.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-97.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button46.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-99.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button47.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-101.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button48.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-103.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button49.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-80.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button50.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-67.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button51.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-81.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button52.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-106.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button53.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-102.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button54.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-162.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button55.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smb3 misc
        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-188.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button56.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-187.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button57.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-189.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button58.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-190.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button59.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        'Black and exit
        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-60.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(2, 2, 28, 28), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button60.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-12.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(4, 4, 24, 24), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button61.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-61.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(6, 6, 20, 20), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button62.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-11.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button63.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-33.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button64.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-34.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button65.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-13.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button66.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'Background Tiles
        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-75.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button67.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-76.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button68.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-78.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button69.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-77.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button70.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'Platform
        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-100.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button71.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        'Door
        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-107.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button72.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()
    End Sub

    Public Sub LoadSMB2bgos()
        'smb2 misc
        Dim fs As New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-62.png", System.IO.FileMode.Open)
        Dim graphic As Image
        graphic = Image.FromStream(fs)
        Button73.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-111.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button74.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-112.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button75.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-113.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button76.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-150.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button77.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-63.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button78.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-109.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button79.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-108.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button80.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-110.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button81.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-148.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button82.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-149.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button83.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smb2 water
        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-159.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button84.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-158.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button85.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        'smb2 door
        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-87.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button86.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-88.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button87.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()
    End Sub

    Public Sub LoadSMBbgos()
        'smb misc
        Dim fs As New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-23.png", System.IO.FileMode.Open)
        Dim graphic As Image
        graphic = Image.FromStream(fs)
        Button88.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-24.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button89.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-25.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button90.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-21.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button91.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-86.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button92.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-129.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button93.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-130.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button94.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-131.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button95.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-22.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button96.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-161.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 64, 48), GraphicsUnit.Pixel)
        Button97.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-127.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button98.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-128.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button99.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-85.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button100.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-84.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button101.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smb castle
        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-16.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button102.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-17.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button103.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smb grass
        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-18.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 6, 32, 22), New Rectangle(0, 0, 128, 32), GraphicsUnit.Pixel)
        Button104.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-19.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 6, 32, 22), New Rectangle(0, 0, 96, 32), GraphicsUnit.Pixel)
        Button105.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-20.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 6, 32, 22), New Rectangle(0, 0, 64, 32), GraphicsUnit.Pixel)
        Button106.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        'smb misc +
        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-147.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button107.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smb water
        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-26.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(7, 0, 18, 32), New Rectangle(0, 0, 32, 64), GraphicsUnit.Pixel)
        Button108.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-168.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 7, 32, 18), New Rectangle(0, 0, 64, 32), GraphicsUnit.Pixel)
        Button109.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-164.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button110.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-169.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button111.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()
    End Sub

    Public Sub LoadSMWbgos()
        'smw bushes
        Dim fs As New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-31.png", System.IO.FileMode.Open)
        Dim graphic As Image
        graphic = Image.FromStream(fs)
        Button112.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-32.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button113.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-27.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button114.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-28.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button115.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smw ghost
        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-49.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button116.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-50.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button117.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-51.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button118.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-43.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button119.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-140.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button120.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-47.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button121.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-48.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button122.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-44.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button123.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-146.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button124.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-139.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button125.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smw platform
        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-74.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button126.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-73.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button127.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-72.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button128.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-71.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button129.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-70.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button130.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        'smw fence
        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-178.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        bmp.MakeTransparent(Color.Black)
        Button131.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-179.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        bmp.MakeTransparent(Color.Black)
        Button132.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-180.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        bmp.MakeTransparent(Color.Black)
        Button133.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-174.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        bmp.MakeTransparent(Color.Black)
        Button134.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-175.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        bmp.MakeTransparent(Color.Black)
        Button135.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-181.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        bmp.MakeTransparent(Color.Black)
        Button136.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-182.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        bmp.MakeTransparent(Color.Black)
        Button137.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-183.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        bmp.MakeTransparent(Color.Black)
        Button138.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-176.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        bmp.MakeTransparent(Color.Black)
        Button139.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-177.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        bmp.MakeTransparent(Color.Black)
        Button140.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-184.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        bmp.MakeTransparent(Color.Black)
        Button141.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-185.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        bmp.MakeTransparent(Color.Black)
        Button142.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-186.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        bmp.MakeTransparent(Color.Black)
        Button143.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        'smw trees
        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-54.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button144.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-53.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button145.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-59.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button146.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-56.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button147.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-58.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button148.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-52.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button149.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-57.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button150.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-55.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(5, 6, 22, 22), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button151.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        'smw block tiles
        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-30.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button152.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-41.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button153.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-42.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button154.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smw misc
        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-29.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button155.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-132.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button156.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-133.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button157.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smw doors
        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-92.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button158.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-105.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button159.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-141.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button160.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-104.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button161.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smw checkpoint
        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-136.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button162.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-138.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button163.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-142.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button164.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-143.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button165.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-135.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button166.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-137.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button167.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-134.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button168.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-144.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button169.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-145.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button170.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smw water
        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-166.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button171.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-167.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button172.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-173.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 112, 120), GraphicsUnit.Pixel)
        Button173.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        'smw key
        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-35.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button174.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()
    End Sub

    Public Sub LoadMiscBGOs()
        'Zelda 2
        Dim fs As New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-122.png", System.IO.FileMode.Open)
        Dim graphic As Image
        graphic = Image.FromStream(fs)
        Button175.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-121.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button176.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-123.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button177.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-119.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button178.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-118.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button179.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-126.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button180.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-125.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(4, 0, 24, 32), New Rectangle(0, 0, 32, 64), GraphicsUnit.Pixel)
        Button181.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-124.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button182.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-120.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button183.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-115.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button184.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-116.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button185.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-117.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button186.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'misc metroid
        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-153.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button187.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-155.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button188.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-154.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button189.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-151.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button190.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-156.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button191.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-157.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button192.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Form1.FilePath & "\graphics\background\background-152.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button193.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()
    End Sub

    Private Sub BGOs_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadSMB3bgos()
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Form2.SelectedBGO = 1
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Form2.SelectedBGO = 2
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Form2.SelectedBGO = 3
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        Form2.SelectedBGO = 4
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        Form2.SelectedBGO = 5
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        Form2.SelectedBGO = 6
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        Form2.SelectedBGO = 7
    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        Form2.SelectedBGO = 8
    End Sub

    Private Sub Button14_Click(sender As System.Object, e As System.EventArgs) Handles Button14.Click
        Form2.SelectedBGO = 9
    End Sub

    Private Sub Button15_Click(sender As System.Object, e As System.EventArgs) Handles Button15.Click
        Form2.SelectedBGO = 10
    End Sub

    Private Sub Button16_Click(sender As System.Object, e As System.EventArgs) Handles Button16.Click
        Form2.SelectedBGO = 11
    End Sub

    Private Sub Button17_Click(sender As System.Object, e As System.EventArgs) Handles Button17.Click
        Form2.SelectedBGO = 12
    End Sub

    Private Sub Button18_Click(sender As System.Object, e As System.EventArgs) Handles Button18.Click
        Form2.SelectedBGO = 13
    End Sub

    Private Sub Button19_Click(sender As System.Object, e As System.EventArgs) Handles Button19.Click
        Form2.SelectedBGO = 14
    End Sub

    Private Sub Button20_Click(sender As System.Object, e As System.EventArgs) Handles Button20.Click
        Form2.SelectedBGO = 15
    End Sub

    Private Sub Button21_Click(sender As System.Object, e As System.EventArgs) Handles Button21.Click
        Form2.SelectedBGO = 16
    End Sub

    Private Sub Button22_Click(sender As System.Object, e As System.EventArgs) Handles Button22.Click
        Form2.SelectedBGO = 17
    End Sub

    Private Sub Button23_Click(sender As System.Object, e As System.EventArgs) Handles Button23.Click
        Form2.SelectedBGO = 18
    End Sub

    Private Sub Button24_Click(sender As System.Object, e As System.EventArgs) Handles Button24.Click
        Form2.SelectedBGO = 19
    End Sub

    Private Sub Button25_Click(sender As System.Object, e As System.EventArgs) Handles Button25.Click
        Form2.SelectedBGO = 20
    End Sub

    Private Sub Button26_Click(sender As System.Object, e As System.EventArgs) Handles Button26.Click
        Form2.SelectedBGO = 21
    End Sub

    Private Sub Button27_Click(sender As System.Object, e As System.EventArgs) Handles Button27.Click
        Form2.SelectedBGO = 22
    End Sub

    Private Sub Button28_Click(sender As System.Object, e As System.EventArgs) Handles Button28.Click
        Form2.SelectedBGO = 23
    End Sub

    Private Sub Button29_Click(sender As System.Object, e As System.EventArgs) Handles Button29.Click
        Form2.SelectedBGO = 24
    End Sub

    Private Sub Button30_Click(sender As System.Object, e As System.EventArgs) Handles Button30.Click
        Form2.SelectedBGO = 25
    End Sub

    Private Sub Button31_Click(sender As System.Object, e As System.EventArgs) Handles Button31.Click
        Form2.SelectedBGO = 26
    End Sub

    Private Sub Button32_Click(sender As System.Object, e As System.EventArgs) Handles Button32.Click
        Form2.SelectedBGO = 27
    End Sub

    Private Sub Button33_Click(sender As System.Object, e As System.EventArgs) Handles Button33.Click
        Form2.SelectedBGO = 28
    End Sub

    Private Sub Button34_Click(sender As System.Object, e As System.EventArgs) Handles Button34.Click
        Form2.SelectedBGO = 29
    End Sub

    Private Sub Button35_Click(sender As System.Object, e As System.EventArgs) Handles Button35.Click
        Form2.SelectedBGO = 30
    End Sub

    Private Sub Button36_Click(sender As System.Object, e As System.EventArgs) Handles Button36.Click
        Form2.SelectedBGO = 31
    End Sub

    Private Sub Button37_Click(sender As System.Object, e As System.EventArgs) Handles Button37.Click
        Form2.SelectedBGO = 32
    End Sub

    Private Sub Button38_Click(sender As System.Object, e As System.EventArgs) Handles Button38.Click
        Form2.SelectedBGO = 33
    End Sub

    Private Sub Button39_Click(sender As System.Object, e As System.EventArgs) Handles Button39.Click
        Form2.SelectedBGO = 34
    End Sub

    Private Sub Button40_Click(sender As System.Object, e As System.EventArgs) Handles Button40.Click
        Form2.SelectedBGO = 35
    End Sub

    Private Sub Button41_Click(sender As System.Object, e As System.EventArgs) Handles Button41.Click
        Form2.SelectedBGO = 36
    End Sub

    Private Sub Button42_Click(sender As System.Object, e As System.EventArgs) Handles Button42.Click
        Form2.SelectedBGO = 37
    End Sub

    Private Sub Button43_Click(sender As System.Object, e As System.EventArgs) Handles Button43.Click
        Form2.SelectedBGO = 38
    End Sub

    Private Sub Button44_Click(sender As System.Object, e As System.EventArgs) Handles Button44.Click
        Form2.SelectedBGO = 39
    End Sub

    Private Sub Button45_Click(sender As System.Object, e As System.EventArgs) Handles Button45.Click
        Form2.SelectedBGO = 40
    End Sub

    Private Sub Button46_Click(sender As System.Object, e As System.EventArgs) Handles Button46.Click
        Form2.SelectedBGO = 41
    End Sub

    Private Sub Button47_Click(sender As System.Object, e As System.EventArgs) Handles Button47.Click
        Form2.SelectedBGO = 42
    End Sub

    Private Sub Button48_Click(sender As System.Object, e As System.EventArgs) Handles Button48.Click
        Form2.SelectedBGO = 43
    End Sub

    Private Sub Button49_Click(sender As System.Object, e As System.EventArgs) Handles Button49.Click
        Form2.SelectedBGO = 44
    End Sub

    Private Sub Button50_Click(sender As System.Object, e As System.EventArgs) Handles Button50.Click
        Form2.SelectedBGO = 45
    End Sub

    Private Sub Button51_Click(sender As System.Object, e As System.EventArgs) Handles Button51.Click
        Form2.SelectedBGO = 46
    End Sub

    Private Sub Button52_Click(sender As System.Object, e As System.EventArgs) Handles Button52.Click
        Form2.SelectedBGO = 47
    End Sub

    Private Sub Button53_Click(sender As System.Object, e As System.EventArgs) Handles Button53.Click
        Form2.SelectedBGO = 48
    End Sub

    Private Sub Button54_Click(sender As System.Object, e As System.EventArgs) Handles Button54.Click
        Form2.SelectedBGO = 49
    End Sub

    Private Sub Button55_Click(sender As System.Object, e As System.EventArgs) Handles Button55.Click
        Form2.SelectedBGO = 50
    End Sub

    Private Sub Button56_Click(sender As System.Object, e As System.EventArgs) Handles Button56.Click
        Form2.SelectedBGO = 51
    End Sub

    Private Sub Button57_Click(sender As System.Object, e As System.EventArgs) Handles Button57.Click
        Form2.SelectedBGO = 52
    End Sub

    Private Sub Button58_Click(sender As System.Object, e As System.EventArgs) Handles Button58.Click
        Form2.SelectedBGO = 53
    End Sub

    Private Sub Button59_Click(sender As System.Object, e As System.EventArgs) Handles Button59.Click
        Form2.SelectedBGO = 54
    End Sub

    Private Sub Button60_Click(sender As System.Object, e As System.EventArgs) Handles Button60.Click
        Form2.SelectedBGO = 55
    End Sub

    Private Sub Button61_Click(sender As System.Object, e As System.EventArgs) Handles Button61.Click
        Form2.SelectedBGO = 56
    End Sub

    Private Sub Button62_Click(sender As System.Object, e As System.EventArgs) Handles Button62.Click
        Form2.SelectedBGO = 57
    End Sub

    Private Sub Button63_Click(sender As System.Object, e As System.EventArgs) Handles Button63.Click
        Form2.SelectedBGO = 58
    End Sub

    Private Sub Button64_Click(sender As System.Object, e As System.EventArgs) Handles Button64.Click
        Form2.SelectedBGO = 59
    End Sub

    Private Sub Button65_Click(sender As System.Object, e As System.EventArgs) Handles Button65.Click
        Form2.SelectedBGO = 60
    End Sub

    Private Sub Button66_Click(sender As System.Object, e As System.EventArgs) Handles Button66.Click
        Form2.SelectedBGO = 61
    End Sub

    Private Sub Button67_Click(sender As System.Object, e As System.EventArgs) Handles Button67.Click
        Form2.SelectedBGO = 62
    End Sub

    Private Sub Button68_Click(sender As System.Object, e As System.EventArgs) Handles Button68.Click
        Form2.SelectedBGO = 63
    End Sub

    Private Sub Button69_Click(sender As System.Object, e As System.EventArgs) Handles Button69.Click
        Form2.SelectedBGO = 64
    End Sub

    Private Sub Button70_Click(sender As System.Object, e As System.EventArgs) Handles Button70.Click
        Form2.SelectedBGO = 65
    End Sub

    Private Sub Button71_Click(sender As System.Object, e As System.EventArgs) Handles Button71.Click
        Form2.SelectedBGO = 66
    End Sub

    Private Sub Button72_Click(sender As System.Object, e As System.EventArgs) Handles Button72.Click
        Form2.SelectedBGO = 67
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        misc_bgos.Visible = False
        smw_bgos.Visible = False
        smb3_bgos.Visible = False
        smb2_bgos.Visible = True
        smb_bgos.Visible = False
        LoadSMB2bgos()
    End Sub

    Private Sub Button73_Click(sender As System.Object, e As System.EventArgs) Handles Button73.Click
        Form2.SelectedBGO = 68
    End Sub

    Private Sub Button74_Click(sender As System.Object, e As System.EventArgs) Handles Button74.Click
        Form2.SelectedBGO = 69
    End Sub

    Private Sub Button75_Click(sender As System.Object, e As System.EventArgs) Handles Button75.Click
        Form2.SelectedBGO = 70
    End Sub

    Private Sub Button76_Click(sender As System.Object, e As System.EventArgs) Handles Button76.Click
        Form2.SelectedBGO = 71
    End Sub

    Private Sub Button77_Click(sender As System.Object, e As System.EventArgs) Handles Button77.Click
        Form2.SelectedBGO = 72
    End Sub

    Private Sub Button78_Click(sender As System.Object, e As System.EventArgs) Handles Button78.Click
        Form2.SelectedBGO = 73
    End Sub

    Private Sub Button79_Click(sender As System.Object, e As System.EventArgs) Handles Button79.Click
        Form2.SelectedBGO = 74
    End Sub

    Private Sub Button80_Click(sender As System.Object, e As System.EventArgs) Handles Button80.Click
        Form2.SelectedBGO = 75
    End Sub

    Private Sub Button81_Click(sender As System.Object, e As System.EventArgs) Handles Button81.Click
        Form2.SelectedBGO = 76
    End Sub

    Private Sub Button82_Click(sender As System.Object, e As System.EventArgs) Handles Button82.Click
        Form2.SelectedBGO = 77
    End Sub

    Private Sub Button83_Click(sender As System.Object, e As System.EventArgs) Handles Button83.Click
        Form2.SelectedBGO = 78
    End Sub

    Private Sub Button84_Click(sender As System.Object, e As System.EventArgs) Handles Button84.Click
        Form2.SelectedBGO = 79
    End Sub

    Private Sub Button85_Click(sender As System.Object, e As System.EventArgs) Handles Button85.Click
        Form2.SelectedBGO = 80
    End Sub

    Private Sub Button86_Click(sender As System.Object, e As System.EventArgs) Handles Button86.Click
        Form2.SelectedBGO = 81
    End Sub

    Private Sub Button87_Click(sender As System.Object, e As System.EventArgs) Handles Button87.Click
        Form2.SelectedBGO = 82
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        LoadSMBbgos()
        smb_bgos.Visible = True
        smb2_bgos.Visible = False
        smb3_bgos.Visible = False
        smw_bgos.Visible = False
        misc_bgos.Visible = False
    End Sub

    Private Sub Button88_Click(sender As System.Object, e As System.EventArgs) Handles Button88.Click
        Form2.SelectedBGO = 83
    End Sub

    Private Sub Button89_Click(sender As System.Object, e As System.EventArgs) Handles Button89.Click
        Form2.SelectedBGO = 84
    End Sub

    Private Sub Button90_Click(sender As System.Object, e As System.EventArgs) Handles Button90.Click
        Form2.SelectedBGO = 85
    End Sub

    Private Sub Button91_Click(sender As System.Object, e As System.EventArgs) Handles Button91.Click
        Form2.SelectedBGO = 86
    End Sub

    Private Sub Button92_Click(sender As System.Object, e As System.EventArgs) Handles Button92.Click
        Form2.SelectedBGO = 87
    End Sub

    Private Sub Button93_Click(sender As System.Object, e As System.EventArgs) Handles Button93.Click
        Form2.SelectedBGO = 88
    End Sub

    Private Sub Button94_Click(sender As System.Object, e As System.EventArgs) Handles Button94.Click
        Form2.SelectedBGO = 89
    End Sub

    Private Sub Button95_Click(sender As System.Object, e As System.EventArgs) Handles Button95.Click
        Form2.SelectedBGO = 90
    End Sub

    Private Sub Button96_Click(sender As System.Object, e As System.EventArgs) Handles Button96.Click
        Form2.SelectedBGO = 91
    End Sub

    Private Sub Button97_Click(sender As System.Object, e As System.EventArgs) Handles Button97.Click
        Form2.SelectedBGO = 92
    End Sub

    Private Sub Button98_Click(sender As System.Object, e As System.EventArgs) Handles Button98.Click
        Form2.SelectedBGO = 93
    End Sub

    Private Sub Button99_Click(sender As System.Object, e As System.EventArgs) Handles Button99.Click
        Form2.SelectedBGO = 94
    End Sub

    Private Sub Button100_Click(sender As System.Object, e As System.EventArgs) Handles Button100.Click
        Form2.SelectedBGO = 95
    End Sub

    Private Sub Button101_Click(sender As System.Object, e As System.EventArgs) Handles Button101.Click
        Form2.SelectedBGO = 96
    End Sub

    Private Sub Button102_Click(sender As System.Object, e As System.EventArgs) Handles Button102.Click
        Form2.SelectedBGO = 97
    End Sub

    Private Sub Button103_Click(sender As System.Object, e As System.EventArgs) Handles Button103.Click
        Form2.SelectedBGO = 98
    End Sub

    Private Sub Button104_Click(sender As System.Object, e As System.EventArgs) Handles Button104.Click
        Form2.SelectedBGO = 99
    End Sub

    Private Sub Button105_Click(sender As System.Object, e As System.EventArgs) Handles Button105.Click
        Form2.SelectedBGO = 100
    End Sub

    Private Sub Button106_Click(sender As System.Object, e As System.EventArgs) Handles Button106.Click
        Form2.SelectedBGO = 101
    End Sub

    Private Sub Button107_Click(sender As System.Object, e As System.EventArgs) Handles Button107.Click
        Form2.SelectedBGO = 102
    End Sub

    Private Sub Button108_Click(sender As System.Object, e As System.EventArgs) Handles Button108.Click
        Form2.SelectedBGO = 103
    End Sub

    Private Sub Button109_Click(sender As System.Object, e As System.EventArgs) Handles Button109.Click
        Form2.SelectedBGO = 104
    End Sub

    Private Sub Button110_Click(sender As System.Object, e As System.EventArgs) Handles Button110.Click
        Form2.SelectedBGO = 105
    End Sub

    Private Sub Button111_Click(sender As System.Object, e As System.EventArgs) Handles Button111.Click
        Form2.SelectedBGO = 106
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        LoadSMWbgos()
        smb_bgos.Visible = False
        smb2_bgos.Visible = False
        smb3_bgos.Visible = False
        smw_bgos.Visible = True
        misc_bgos.Visible = False
    End Sub

    Private Sub Button112_Click(sender As System.Object, e As System.EventArgs) Handles Button112.Click
        Form2.SelectedBGO = 107
    End Sub

    Private Sub Button113_Click(sender As System.Object, e As System.EventArgs) Handles Button113.Click
        Form2.SelectedBGO = 108
    End Sub

    Private Sub Button114_Click(sender As System.Object, e As System.EventArgs) Handles Button114.Click
        Form2.SelectedBGO = 109
    End Sub

    Private Sub Button115_Click(sender As System.Object, e As System.EventArgs) Handles Button115.Click
        Form2.SelectedBGO = 110
    End Sub

    Private Sub Button116_Click(sender As System.Object, e As System.EventArgs) Handles Button116.Click
        Form2.SelectedBGO = 111
    End Sub

    Private Sub Button117_Click(sender As System.Object, e As System.EventArgs) Handles Button117.Click
        Form2.SelectedBGO = 112
    End Sub

    Private Sub Button118_Click(sender As System.Object, e As System.EventArgs) Handles Button118.Click
        Form2.SelectedBGO = 113
    End Sub

    Private Sub Button119_Click(sender As System.Object, e As System.EventArgs) Handles Button119.Click
        Form2.SelectedBGO = 114
    End Sub

    Private Sub Button120_Click(sender As System.Object, e As System.EventArgs) Handles Button120.Click
        Form2.SelectedBGO = 115
    End Sub

    Private Sub Button121_Click(sender As System.Object, e As System.EventArgs) Handles Button121.Click
        Form2.SelectedBGO = 116
    End Sub

    Private Sub Button122_Click(sender As System.Object, e As System.EventArgs) Handles Button122.Click
        Form2.SelectedBGO = 117
    End Sub

    Private Sub Button123_Click(sender As System.Object, e As System.EventArgs) Handles Button123.Click
        Form2.SelectedBGO = 118
    End Sub

    Private Sub Button124_Click(sender As System.Object, e As System.EventArgs) Handles Button124.Click
        Form2.SelectedBGO = 119
    End Sub

    Private Sub Button125_Click(sender As System.Object, e As System.EventArgs) Handles Button125.Click
        Form2.SelectedBGO = 120
    End Sub

    Private Sub Button126_Click(sender As System.Object, e As System.EventArgs) Handles Button126.Click
        Form2.SelectedBGO = 121
    End Sub

    Private Sub Button127_Click(sender As System.Object, e As System.EventArgs) Handles Button127.Click
        Form2.SelectedBGO = 122
    End Sub

    Private Sub Button128_Click(sender As System.Object, e As System.EventArgs) Handles Button128.Click
        Form2.SelectedBGO = 123
    End Sub

    Private Sub Button129_Click(sender As System.Object, e As System.EventArgs) Handles Button129.Click
        Form2.SelectedBGO = 124
    End Sub

    Private Sub Button130_Click(sender As System.Object, e As System.EventArgs) Handles Button130.Click
        Form2.SelectedBGO = 125
    End Sub

    Private Sub Button131_Click(sender As System.Object, e As System.EventArgs) Handles Button131.Click
        Form2.SelectedBGO = 126
    End Sub

    Private Sub Button132_Click(sender As System.Object, e As System.EventArgs) Handles Button132.Click
        Form2.SelectedBGO = 127
    End Sub

    Private Sub Button133_Click(sender As System.Object, e As System.EventArgs) Handles Button133.Click
        Form2.SelectedBGO = 128
    End Sub

    Private Sub Button134_Click(sender As System.Object, e As System.EventArgs) Handles Button134.Click
        Form2.SelectedBGO = 129
    End Sub

    Private Sub Button135_Click(sender As System.Object, e As System.EventArgs) Handles Button135.Click
        Form2.SelectedBGO = 130
    End Sub

    Private Sub Button136_Click(sender As System.Object, e As System.EventArgs) Handles Button136.Click
        Form2.SelectedBGO = 131
    End Sub

    Private Sub Button137_Click(sender As System.Object, e As System.EventArgs) Handles Button137.Click
        Form2.SelectedBGO = 132
    End Sub

    Private Sub Button138_Click(sender As System.Object, e As System.EventArgs) Handles Button138.Click
        Form2.SelectedBGO = 133
    End Sub

    Private Sub Button139_Click(sender As System.Object, e As System.EventArgs) Handles Button139.Click
        Form2.SelectedBGO = 134
    End Sub

    Private Sub Button140_Click(sender As System.Object, e As System.EventArgs) Handles Button140.Click
        Form2.SelectedBGO = 135
    End Sub

    Private Sub Button141_Click(sender As System.Object, e As System.EventArgs) Handles Button141.Click
        Form2.SelectedBGO = 136
    End Sub

    Private Sub Button142_Click(sender As System.Object, e As System.EventArgs) Handles Button142.Click
        Form2.SelectedBGO = 137
    End Sub

    Private Sub Button143_Click(sender As System.Object, e As System.EventArgs) Handles Button143.Click
        Form2.SelectedBGO = 138
    End Sub

    Private Sub Button144_Click(sender As System.Object, e As System.EventArgs) Handles Button144.Click
        Form2.SelectedBGO = 139
    End Sub

    Private Sub Button145_Click(sender As System.Object, e As System.EventArgs) Handles Button145.Click
        Form2.SelectedBGO = 140
    End Sub

    Private Sub Button146_Click(sender As System.Object, e As System.EventArgs) Handles Button146.Click
        Form2.SelectedBGO = 141
    End Sub

    Private Sub Button147_Click(sender As System.Object, e As System.EventArgs) Handles Button147.Click
        Form2.SelectedBGO = 142
    End Sub

    Private Sub Button148_Click(sender As System.Object, e As System.EventArgs) Handles Button148.Click
        Form2.SelectedBGO = 143
    End Sub

    Private Sub Button149_Click(sender As System.Object, e As System.EventArgs) Handles Button149.Click
        Form2.SelectedBGO = 144
    End Sub

    Private Sub Button150_Click(sender As System.Object, e As System.EventArgs) Handles Button150.Click
        Form2.SelectedBGO = 145
    End Sub

    Private Sub Button151_Click(sender As System.Object, e As System.EventArgs) Handles Button151.Click
        Form2.SelectedBGO = 146
    End Sub

    Private Sub Button152_Click(sender As System.Object, e As System.EventArgs) Handles Button152.Click
        Form2.SelectedBGO = 147
    End Sub

    Private Sub Button153_Click(sender As System.Object, e As System.EventArgs) Handles Button153.Click
        Form2.SelectedBGO = 148
    End Sub

    Private Sub Button154_Click(sender As System.Object, e As System.EventArgs) Handles Button154.Click
        Form2.SelectedBGO = 149
    End Sub

    Private Sub Button155_Click(sender As System.Object, e As System.EventArgs) Handles Button155.Click
        Form2.SelectedBGO = 150
    End Sub

    Private Sub Button156_Click(sender As System.Object, e As System.EventArgs) Handles Button156.Click
        Form2.SelectedBGO = 151
    End Sub

    Private Sub Button157_Click(sender As System.Object, e As System.EventArgs) Handles Button157.Click
        Form2.SelectedBGO = 152
    End Sub

    Private Sub Button158_Click(sender As System.Object, e As System.EventArgs) Handles Button158.Click
        Form2.SelectedBGO = 153
    End Sub

    Private Sub Button159_Click(sender As System.Object, e As System.EventArgs) Handles Button159.Click
        Form2.SelectedBGO = 154
    End Sub

    Private Sub Button160_Click(sender As System.Object, e As System.EventArgs) Handles Button160.Click
        Form2.SelectedBGO = 155
    End Sub

    Private Sub Button161_Click(sender As System.Object, e As System.EventArgs) Handles Button161.Click
        Form2.SelectedBGO = 156
    End Sub

    Private Sub Button162_Click(sender As System.Object, e As System.EventArgs) Handles Button162.Click
        Form2.SelectedBGO = 157
    End Sub

    Private Sub Button163_Click(sender As System.Object, e As System.EventArgs) Handles Button163.Click
        Form2.SelectedBGO = 158
    End Sub

    Private Sub Button164_Click(sender As System.Object, e As System.EventArgs) Handles Button164.Click
        Form2.SelectedBGO = 159
    End Sub

    Private Sub Button165_Click(sender As System.Object, e As System.EventArgs) Handles Button165.Click
        Form2.SelectedBGO = 160
    End Sub

    Private Sub Button166_Click(sender As System.Object, e As System.EventArgs) Handles Button166.Click
        Form2.SelectedBGO = 161
    End Sub

    Private Sub Button167_Click(sender As System.Object, e As System.EventArgs) Handles Button167.Click
        Form2.SelectedBGO = 162
    End Sub

    Private Sub Button168_Click(sender As System.Object, e As System.EventArgs) Handles Button168.Click
        Form2.SelectedBGO = 163
    End Sub

    Private Sub Button169_Click(sender As System.Object, e As System.EventArgs) Handles Button169.Click
        Form2.SelectedBGO = 164
    End Sub

    Private Sub Button170_Click(sender As System.Object, e As System.EventArgs) Handles Button170.Click
        Form2.SelectedBGO = 165
    End Sub

    Private Sub Button171_Click(sender As System.Object, e As System.EventArgs) Handles Button171.Click
        Form2.SelectedBGO = 166
    End Sub

    Private Sub Button172_Click(sender As System.Object, e As System.EventArgs) Handles Button172.Click
        Form2.SelectedBGO = 167
    End Sub

    Private Sub Button173_Click(sender As System.Object, e As System.EventArgs) Handles Button173.Click
        Form2.SelectedBGO = 168
    End Sub

    Private Sub Button174_Click(sender As System.Object, e As System.EventArgs) Handles Button174.Click
        Form2.SelectedBGO = 169
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        LoadMiscBGOs()
        smb_bgos.Visible = False
        smb2_bgos.Visible = False
        smb3_bgos.Visible = False
        smw_bgos.Visible = False
        misc_bgos.Visible = True
    End Sub

    Private Sub Button175_Click(sender As System.Object, e As System.EventArgs) Handles Button175.Click
        Form2.SelectedBGO = 170
    End Sub

    Private Sub Button176_Click(sender As System.Object, e As System.EventArgs) Handles Button176.Click
        Form2.SelectedBGO = 171
    End Sub

    Private Sub Button177_Click(sender As System.Object, e As System.EventArgs) Handles Button177.Click
        Form2.SelectedBGO = 172
    End Sub

    Private Sub Button178_Click(sender As System.Object, e As System.EventArgs) Handles Button178.Click
        Form2.SelectedBGO = 173
    End Sub

    Private Sub Button179_Click(sender As System.Object, e As System.EventArgs) Handles Button179.Click
        Form2.SelectedBGO = 174
    End Sub

    Private Sub Button180_Click(sender As System.Object, e As System.EventArgs) Handles Button180.Click
        Form2.SelectedBGO = 175
    End Sub

    Private Sub Button181_Click(sender As System.Object, e As System.EventArgs) Handles Button181.Click
        Form2.SelectedBGO = 176
    End Sub

    Private Sub Button182_Click(sender As System.Object, e As System.EventArgs) Handles Button182.Click
        Form2.SelectedBGO = 177
    End Sub

    Private Sub Button183_Click(sender As System.Object, e As System.EventArgs) Handles Button183.Click
        Form2.SelectedBGO = 178
    End Sub

    Private Sub Button184_Click(sender As System.Object, e As System.EventArgs) Handles Button184.Click
        Form2.SelectedBGO = 179
    End Sub

    Private Sub Button185_Click(sender As System.Object, e As System.EventArgs) Handles Button185.Click
        Form2.SelectedBGO = 180
    End Sub

    Private Sub Button186_Click(sender As System.Object, e As System.EventArgs) Handles Button186.Click
        Form2.SelectedBGO = 181
    End Sub

    Private Sub Button187_Click(sender As System.Object, e As System.EventArgs) Handles Button187.Click
        Form2.SelectedBGO = 182
    End Sub

    Private Sub Button188_Click(sender As System.Object, e As System.EventArgs) Handles Button188.Click
        Form2.SelectedBGO = 183
    End Sub

    Private Sub Button189_Click(sender As System.Object, e As System.EventArgs) Handles Button189.Click
        Form2.SelectedBGO = 184
    End Sub

    Private Sub Button190_Click(sender As System.Object, e As System.EventArgs) Handles Button190.Click
        Form2.SelectedBGO = 185
    End Sub

    Private Sub Button191_Click(sender As System.Object, e As System.EventArgs) Handles Button191.Click
        Form2.SelectedBGO = 186
    End Sub

    Private Sub Button192_Click(sender As System.Object, e As System.EventArgs) Handles Button192.Click
        Form2.SelectedBGO = 187
    End Sub

    Private Sub Button193_Click(sender As System.Object, e As System.EventArgs) Handles Button193.Click
        Form2.SelectedBGO = 188
    End Sub
End Class