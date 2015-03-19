Public Class NPCs
    Dim bmp As Bitmap
    Dim g As Graphics

    Public FStream As System.IO.FileStream
    Public NPCimg As Image
    Public Cimg As Bitmap
    Public Prefix As String = Form1.FilePath & "\graphics\npc\npc-"
    Public NPCid As Integer
    Public SMB3ids As String = "1,2,3,244,71,37,38,6,4,76,161,72,48,47,12,23,17,136,137,53,54,36,259,15,267,86,73,5,7,24,21,84,58,69,70,81,80,82,67,68,160,83,79,78,45,8,74,52,51,245,261,229,230,231,75,198,94,101,9,14,34,169,170,264,90,10,103,35,191,193,22,49,248,238,273,287,226,213,225,214,11,16,97,46,212,104,57"
    Public SMB2ids As String = "20,25,131,132,206,272,19,129,130,135,247,147,92,140,142,139,145,144,141,143,146,217,215,216,220,218,219,221,154,155,156,157,138,134,241,240,249,41,39,201,262,288,289"
    Public SMBids As String = "89,27,29,153,93,175,177,173,176,260,106,200,235,233,28,184,182,88,178,186,172,174,223,222"
    Public SMWids As String = "165,162,43,18,181,270,286,271,166,163,42,164,179,207,285,167,77,44,180,189,199,275,109,110,111,112,194,113,114,115,116,121,123,117,118,119,120,122,124,60,64,62,66,105,190,31,197,196,227,224,234,232,236,280,151,192,95,98,99,100,148,149,150,228,185,183,187,188,33,258,96,26,56,195,32,239,274,277,278,279"
    Public MiscIds As String = "127,126,128,125,211,242,243,203,204,205,168,256,257,152,250,252,254,158,251,253,255,102,107,208,209,59,61,63,65"
    Public sr As System.IO.StringReader

    Private Sub NPCs_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        g = Me.CreateGraphics()

        LoadSMBNPCs()
        LoadSMB2NPCs()
        LoadSMB3NPCs()
        LoadSMWNPCs()
        LoadMiscNPCs()
    End Sub

    Public Sub LoadSMB3NPCs()
        sr = New System.IO.StringReader(SMB3ids)

        Dim split() As String
        Dim count As Integer
        split = SMB3ids.Split(",")
        For count = 0 To split.Length - 1
            NPCid = CInt(split(count))

            FStream = New System.IO.FileStream(Prefix & NPCid & ".png", System.IO.FileMode.Open)
            NPCimg = Image.FromStream(FStream)
            Cimg = New Bitmap(32, 32)

            g = Graphics.FromImage(Cimg)

            Select Case count + 1
                Case 1
                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button19.BackgroundImage = Cimg
                Case 2
                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button20.BackgroundImage = Cimg
                Case 3
                    g.DrawImage(NPCimg, New Rectangle(0, -8, 32, 40), New Rectangle(0, 0, 40, 48), GraphicsUnit.Pixel)
                    Button21.BackgroundImage = Cimg
                Case 4
                    g.DrawImage(NPCimg, New Rectangle(0, -8, 32, 40), New Rectangle(0, 0, 40, 48), GraphicsUnit.Pixel)
                    Button22.BackgroundImage = Cimg
                Case 5
                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 48, 46), GraphicsUnit.Pixel)
                    Button41.BackgroundImage = Cimg
                Case 6
                    g.DrawImage(NPCimg, New Rectangle(4, 0, 24, 32), New Rectangle(0, 0, 48, 64), GraphicsUnit.Pixel)
                    Button23.BackgroundImage = Cimg
                Case 7
                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button24.BackgroundImage = Cimg
                Case 8
                    g.DrawImage(NPCimg, New Rectangle(5, -2, 22, 34), New Rectangle(0, 0, 32, 54), GraphicsUnit.Pixel)
                    Button25.BackgroundImage = Cimg
                Case 9
                    g.DrawImage(NPCimg, New Rectangle(5, -2, 22, 34), New Rectangle(0, 0, 32, 54), GraphicsUnit.Pixel)
                    Button26.BackgroundImage = Cimg
                Case 10

                    g.DrawImage(NPCimg, New Rectangle(5, -3, 22, 36), New Rectangle(0, 0, 32, 56), GraphicsUnit.Pixel)
                    Button27.BackgroundImage = Cimg
                Case 11

                    g.DrawImage(NPCimg, New Rectangle(5, -3, 22, 36), New Rectangle(0, 0, 32, 56), GraphicsUnit.Pixel)
                    Button28.BackgroundImage = Cimg
                Case 12

                    g.DrawImage(NPCimg, New Rectangle(2, 0, 28, 32), New Rectangle(0, 0, 48, 62), GraphicsUnit.Pixel)
                    Button29.BackgroundImage = Cimg
                Case 13

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button30.BackgroundImage = Cimg
                Case 14

                    g.DrawImage(NPCimg, New Rectangle(6, 0, 20, 32), New Rectangle(0, 0, 32, 64), GraphicsUnit.Pixel)
                    Button31.BackgroundImage = Cimg
                Case 15

                    g.DrawImage(NPCimg, New Rectangle(2, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button32.BackgroundImage = Cimg
                Case 16

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button33.BackgroundImage = Cimg
                Case 17

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 28), GraphicsUnit.Pixel)
                    Button34.BackgroundImage = Cimg
                Case 18

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button35.BackgroundImage = Cimg
                Case 19

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 28), GraphicsUnit.Pixel)
                    Button36.BackgroundImage = Cimg
                Case 20

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button37.BackgroundImage = Cimg
                Case 21

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button38.BackgroundImage = Cimg
                Case 22

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button39.BackgroundImage = Cimg
                Case 23

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button40.BackgroundImage = Cimg
                Case 24

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 68, 54), GraphicsUnit.Pixel)
                    Button1.BackgroundImage = Cimg
                Case 25

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 84, 62), GraphicsUnit.Pixel)
                    Button2.BackgroundImage = Cimg
                Case 26

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 64, 80), GraphicsUnit.Pixel)
                    Button3.BackgroundImage = Cimg
                Case 27

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 44, 44), GraphicsUnit.Pixel)
                    Button42.BackgroundImage = Cimg
                Case 28

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button43.BackgroundImage = Cimg
                Case 29

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button44.BackgroundImage = Cimg
                Case 30

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button45.BackgroundImage = Cimg
                Case 31

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button46.BackgroundImage = Cimg
                Case 32

                    g.DrawImage(NPCimg, New Rectangle(8, 0, 16, 32), New Rectangle(0, 0, 32, 64), GraphicsUnit.Pixel)
                    Button47.BackgroundImage = Cimg
                Case 33

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button48.BackgroundImage = Cimg
                Case 34

                    g.DrawImage(NPCimg, New Rectangle(11, 0, 10, 32), New Rectangle(0, 0, 32, 128), GraphicsUnit.Pixel)
                    Button49.BackgroundImage = Cimg
                Case 35

                    g.DrawImage(NPCimg, New Rectangle(12, 0, 6, 32), New Rectangle(0, 0, 32, 256), GraphicsUnit.Pixel)
                    Button50.BackgroundImage = Cimg
                Case 36

                    g.DrawImage(NPCimg, New Rectangle(0, 12, 32, 10), New Rectangle(0, 0, 128, 32), GraphicsUnit.Pixel)
                    Button51.BackgroundImage = Cimg
                Case 37

                    g.DrawImage(NPCimg, New Rectangle(0, 12, 32, 10), New Rectangle(0, 0, 128, 32), GraphicsUnit.Pixel)
                    Button52.BackgroundImage = Cimg
                Case 38

                    g.DrawImage(NPCimg, New Rectangle(0, 12, 32, 10), New Rectangle(0, 0, 128, 32), GraphicsUnit.Pixel)
                    Button53.BackgroundImage = Cimg
                Case 39

                    g.DrawImage(NPCimg, New Rectangle(0, 12, 32, 10), New Rectangle(0, 0, 128, 32), GraphicsUnit.Pixel)
                    Button54.BackgroundImage = Cimg
                Case 40

                    g.DrawImage(NPCimg, New Rectangle(0, 12, 32, 10), New Rectangle(0, 0, 256, 32), GraphicsUnit.Pixel)
                    Button55.BackgroundImage = Cimg
                Case 41

                    g.DrawImage(NPCimg, New Rectangle(0, 14, 32, 6), New Rectangle(96, 0, 220, 32), GraphicsUnit.Pixel)
                    Button56.BackgroundImage = Cimg
                Case 42

                    g.DrawImage(NPCimg, New Rectangle(0, 12, 32, 8), New Rectangle(0, 0, 256, 32), GraphicsUnit.Pixel)
                    Button57.BackgroundImage = Cimg
                Case 43

                    g.DrawImage(NPCimg, New Rectangle(0, 8, 32, 16), New Rectangle(0, 0, 64, 32), GraphicsUnit.Pixel)
                    Button58.BackgroundImage = Cimg
                Case 44

                    g.DrawImage(NPCimg, New Rectangle(0, 12, 32, 10), New Rectangle(0, 0, 128, 32), GraphicsUnit.Pixel)
                    Button59.BackgroundImage = Cimg
                Case 45

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button60.BackgroundImage = Cimg
                Case 46

                    g.DrawImage(NPCimg, New Rectangle(6, 0, 20, 32), New Rectangle(0, 0, 32, 48), GraphicsUnit.Pixel)
                    Button61.BackgroundImage = Cimg
                Case 47

                    g.DrawImage(NPCimg, New Rectangle(5, 0, 22, 32), New Rectangle(0, 64, 48, 64), GraphicsUnit.Pixel)
                    Button62.BackgroundImage = Cimg
                Case 48

                    g.DrawImage(NPCimg, New Rectangle(0, 6, 32, 20), New Rectangle(0, 32, 48, 32), GraphicsUnit.Pixel)
                    Button63.BackgroundImage = Cimg
                Case 49

                    g.DrawImage(NPCimg, New Rectangle(6, 0, 20, 32), New Rectangle(0, 64, 32, 64), GraphicsUnit.Pixel)
                    Button64.BackgroundImage = Cimg
                Case 50

                    g.DrawImage(NPCimg, New Rectangle(6, 0, 20, 32), New Rectangle(0, 0, 32, 64), GraphicsUnit.Pixel)
                    Button65.BackgroundImage = Cimg
                Case 51

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button66.BackgroundImage = Cimg
                Case 52

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button67.BackgroundImage = Cimg
                Case 53

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button68.BackgroundImage = Cimg
                Case 54

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button69.BackgroundImage = Cimg
                Case 55

                    g.DrawImage(NPCimg, New Rectangle(6, 0, 22, 32), New Rectangle(0, 116, 38, 58), GraphicsUnit.Pixel)
                    Button70.BackgroundImage = Cimg
                Case 56

                    g.DrawImage(NPCimg, New Rectangle(8, 0, 16, 32), New Rectangle(0, 0, 32, 64), GraphicsUnit.Pixel)
                    Button71.BackgroundImage = Cimg
                Case 57

                    g.DrawImage(NPCimg, New Rectangle(8, 0, 16, 32), New Rectangle(0, 0, 32, 54), GraphicsUnit.Pixel)
                    Button72.BackgroundImage = Cimg
                Case 58

                    g.DrawImage(NPCimg, New Rectangle(8, 0, 16, 32), New Rectangle(0, 0, 32, 62), GraphicsUnit.Pixel)
                    Button73.BackgroundImage = Cimg
                Case 59

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button74.BackgroundImage = Cimg
                Case 60

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button75.BackgroundImage = Cimg
                Case 61

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button76.BackgroundImage = Cimg
                Case 62

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button77.BackgroundImage = Cimg
                Case 63

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button78.BackgroundImage = Cimg
                Case 64

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button79.BackgroundImage = Cimg
                Case 65

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button80.BackgroundImage = Cimg
                Case 66

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button81.BackgroundImage = Cimg
                Case 67

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button82.BackgroundImage = Cimg
                Case 68

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button83.BackgroundImage = Cimg
                Case 69

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button84.BackgroundImage = Cimg
                Case 70

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button85.BackgroundImage = Cimg
                Case 71

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button86.BackgroundImage = Cimg
                Case 72

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button87.BackgroundImage = Cimg
                Case 73

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button88.BackgroundImage = Cimg
                Case 74

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button89.BackgroundImage = Cimg
                Case 75

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button90.BackgroundImage = Cimg
                Case 76

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button91.BackgroundImage = Cimg
                Case 77

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button92.BackgroundImage = Cimg
                Case 78

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button93.BackgroundImage = Cimg
                Case 79

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button94.BackgroundImage = Cimg
                Case 80

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button95.BackgroundImage = Cimg
                Case 81

                    g.DrawImage(NPCimg, New Rectangle(8, 0, 16, 16), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    g.DrawImage(NPCimg, New Rectangle(0, 16, 16, 16), New Rectangle(0, 64, 32, 32), GraphicsUnit.Pixel)
                    g.DrawImage(NPCimg, New Rectangle(16, 16, 16, 16), New Rectangle(0, 32, 32, 32), GraphicsUnit.Pixel)
                    Button96.BackgroundImage = Cimg
                Case 82

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button97.BackgroundImage = Cimg
                Case 83

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button98.BackgroundImage = Cimg
                Case 84

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button99.BackgroundImage = Cimg
                Case 85

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button100.BackgroundImage = Cimg
                Case 86

                    g.DrawImage(NPCimg, New Rectangle(0, 10, 32, 12), New Rectangle(0, 0, 96, 32), GraphicsUnit.Pixel)
                    Button101.BackgroundImage = Cimg
                Case 87

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button102.BackgroundImage = Cimg
            End Select

            FStream.Close()
            FStream.Dispose()
        Next
    End Sub

    Public Sub LoadSMB2NPCs()
        sr = New System.IO.StringReader(SMB3ids)

        Dim split() As String
        Dim count As Integer
        split = SMB2ids.Split(",")
        For count = 0 To split.Length - 1
            NPCid = CInt(split(count))

            FStream = New System.IO.FileStream(Prefix & NPCid & ".png", System.IO.FileMode.Open)
            NPCimg = Image.FromStream(FStream)
            Cimg = New Bitmap(32, 32)

            g = Graphics.FromImage(Cimg)

            Select Case count + 1
                Case 1

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button103.BackgroundImage = Cimg
                Case 2

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button104.BackgroundImage = Cimg
                Case 3

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button105.BackgroundImage = Cimg
                Case 4

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button106.BackgroundImage = Cimg
                Case 5

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button107.BackgroundImage = Cimg
                Case 6

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button108.BackgroundImage = Cimg
                Case 7

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button109.BackgroundImage = Cimg
                Case 8

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button110.BackgroundImage = Cimg
                Case 9

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button111.BackgroundImage = Cimg
                Case 10

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button112.BackgroundImage = Cimg
                Case 11

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button113.BackgroundImage = Cimg
                Case 12

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button114.BackgroundImage = Cimg
                Case 13

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button115.BackgroundImage = Cimg
                Case 14

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button116.BackgroundImage = Cimg
                Case 15

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button117.BackgroundImage = Cimg
                Case 16

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 28, 32), GraphicsUnit.Pixel)
                    Button118.BackgroundImage = Cimg
                Case 17

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 24, 28), GraphicsUnit.Pixel)
                    Button119.BackgroundImage = Cimg
                Case 18

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 24, 30), GraphicsUnit.Pixel)
                    Button120.BackgroundImage = Cimg
                Case 19

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 28, 32), GraphicsUnit.Pixel)
                    Button121.BackgroundImage = Cimg
                Case 20

                    g.DrawImage(NPCimg, New Rectangle(8, 0, 16, 32), New Rectangle(0, 0, 12, 26), GraphicsUnit.Pixel)
                    Button122.BackgroundImage = Cimg
                Case 21

                    g.DrawImage(NPCimg, New Rectangle(8, 0, 16, 32), New Rectangle(0, 0, 20, 32), GraphicsUnit.Pixel)
                    Button123.BackgroundImage = Cimg
                Case 22

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button124.BackgroundImage = Cimg
                Case 23

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button125.BackgroundImage = Cimg
                Case 24

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button126.BackgroundImage = Cimg
                Case 25

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button127.BackgroundImage = Cimg
                Case 26

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button128.BackgroundImage = Cimg
                Case 27

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button129.BackgroundImage = Cimg
                Case 28

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button130.BackgroundImage = Cimg
                Case 29

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button131.BackgroundImage = Cimg
                Case 30

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button132.BackgroundImage = Cimg
                Case 31

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button133.BackgroundImage = Cimg
                Case 32

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button134.BackgroundImage = Cimg
                Case 33

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 28, 32), GraphicsUnit.Pixel)
                    Button135.BackgroundImage = Cimg
                Case 34

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 80, 32, 40), GraphicsUnit.Pixel)
                    Button136.BackgroundImage = Cimg
                Case 35

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 128, 32, 32), GraphicsUnit.Pixel)
                    Button137.BackgroundImage = Cimg
                Case 36

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button138.BackgroundImage = Cimg
                Case 37

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button139.BackgroundImage = Cimg
                Case 38

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button140.BackgroundImage = Cimg
                Case 39

                    g.DrawImage(NPCimg, New Rectangle(8, 0, 16, 32), New Rectangle(0, 0, 32, 72), GraphicsUnit.Pixel)
                    Button141.BackgroundImage = Cimg
                Case 40

                    g.DrawImage(NPCimg, New Rectangle(4, 0, 24, 32), New Rectangle(0, 0, 80, 94), GraphicsUnit.Pixel)
                    Button142.BackgroundImage = Cimg
                Case 41

                    g.DrawImage(NPCimg, New Rectangle(8, 0, 18, 32), New Rectangle(0, 0, 48, 64), GraphicsUnit.Pixel)
                    Button143.BackgroundImage = Cimg
                Case 42

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button144.BackgroundImage = Cimg
                Case 43

                    g.DrawImage(NPCimg, New Rectangle(8, 0, 16, 32), New Rectangle(0, 0, 32, 64), GraphicsUnit.Pixel)
                    Button145.BackgroundImage = Cimg
            End Select

            FStream.Close()
            FStream.Dispose()
        Next
    End Sub

    Public Sub LoadSMBNPCs()
        sr = New System.IO.StringReader(SMB3ids)

        Dim split() As String
        Dim count As Integer
        split = SMBids.Split(",")
        For count = 0 To split.Length - 1
            NPCid = CInt(split(count))

            FStream = New System.IO.FileStream(Prefix & NPCid & ".png", System.IO.FileMode.Open)
            NPCimg = Image.FromStream(FStream)
            Cimg = New Bitmap(32, 32)

            g = Graphics.FromImage(Cimg)

            Select Case count + 1
                Case 1
                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button146.BackgroundImage = Cimg
                Case 2
                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button147.BackgroundImage = Cimg
                Case 3
                    g.DrawImage(NPCimg, New Rectangle(8, 0, 16, 32), New Rectangle(0, 0, 32, 48), GraphicsUnit.Pixel)
                    Button148.BackgroundImage = Cimg
                Case 4
                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button149.BackgroundImage = Cimg
                Case 5
                    g.DrawImage(NPCimg, New Rectangle(8, 0, 16, 32), New Rectangle(0, 0, 32, 48), GraphicsUnit.Pixel)
                    Button150.BackgroundImage = Cimg
                Case 6
                    g.DrawImage(NPCimg, New Rectangle(8, 0, 16, 32), New Rectangle(0, 0, 32, 48), GraphicsUnit.Pixel)
                    Button151.BackgroundImage = Cimg
                Case 7
                    g.DrawImage(NPCimg, New Rectangle(8, 0, 16, 32), New Rectangle(0, 0, 32, 48), GraphicsUnit.Pixel)
                    Button152.BackgroundImage = Cimg
                Case 8
                    g.DrawImage(NPCimg, New Rectangle(8, 0, 16, 32), New Rectangle(0, 0, 32, 48), GraphicsUnit.Pixel)
                    Button153.BackgroundImage = Cimg
                Case 9
                    g.DrawImage(NPCimg, New Rectangle(8, 0, 16, 32), New Rectangle(0, 0, 32, 48), GraphicsUnit.Pixel)
                    Button154.BackgroundImage = Cimg
                Case 10
                    g.DrawImage(NPCimg, New Rectangle(8, 8, 16, 16), New Rectangle(0, 0, 16, 16), GraphicsUnit.Pixel)
                    Button155.BackgroundImage = Cimg
                Case 11
                    g.DrawImage(NPCimg, New Rectangle(0, 14, 32, 6), New Rectangle(0, 0, 128, 16), GraphicsUnit.Pixel)
                    Button156.BackgroundImage = Cimg
                Case 12
                    g.DrawImage(NPCimg, New Rectangle(4, 0, 24, 32), New Rectangle(0, 0, 64, 72), GraphicsUnit.Pixel)
                    Button157.BackgroundImage = Cimg
                Case 13
                    g.DrawImage(NPCimg, New Rectangle(4, 0, 24, 32), New Rectangle(0, 0, 32, 48), GraphicsUnit.Pixel)
                    Button158.BackgroundImage = Cimg
                Case 14
                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button159.BackgroundImage = Cimg
                Case 15
                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button160.BackgroundImage = Cimg
                Case 16
                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button161.BackgroundImage = Cimg
                Case 17
                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button162.BackgroundImage = Cimg
                Case 18
                    g.DrawImage(NPCimg, New Rectangle(6, 0, 20, 32), New Rectangle(0, 0, 20, 32), GraphicsUnit.Pixel)
                    Button163.BackgroundImage = Cimg
                Case 19
                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button164.BackgroundImage = Cimg
                Case 20
                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button165.BackgroundImage = Cimg
                Case 21
                    g.DrawImage(NPCimg, New Rectangle(0, 2, 32, 28), New Rectangle(0, 0, 32, 28), GraphicsUnit.Pixel)
                    Button166.BackgroundImage = Cimg
                Case 22
                    g.DrawImage(NPCimg, New Rectangle(0, 2, 32, 28), New Rectangle(0, 0, 32, 28), GraphicsUnit.Pixel)
                    Button167.BackgroundImage = Cimg
                Case 23
                    g.DrawImage(NPCimg, New Rectangle(0, 6, 32, 24), New Rectangle(0, 0, 32, 24), GraphicsUnit.Pixel)
                    Button168.BackgroundImage = Cimg
                Case 24
                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button169.BackgroundImage = Cimg
            End Select

            FStream.Close()
            FStream.Dispose()
        Next
    End Sub

    Public Sub LoadSMWNPCs()
        sr = New System.IO.StringReader(SMB3ids)

        Dim split() As String
        Dim count As Integer
        split = SMWids.Split(",")
        For count = 0 To split.Length - 1
            NPCid = CInt(split(count))

            FStream = New System.IO.FileStream(Prefix & NPCid & ".png", System.IO.FileMode.Open)
            NPCimg = Image.FromStream(FStream)
            Cimg = New Bitmap(32, 32)

            g = Graphics.FromImage(Cimg)

            Select Case count + 1
                Case 1

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button170.BackgroundImage = Cimg
                Case 2

                    g.DrawImage(NPCimg, New Rectangle(8, 0, 16, 32), New Rectangle(0, 0, 32, 64), GraphicsUnit.Pixel)
                    Button171.BackgroundImage = Cimg
                Case 3

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button172.BackgroundImage = Cimg
                Case 4

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 128, 128), GraphicsUnit.Pixel)
                    Button173.BackgroundImage = Cimg
                Case 5

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 48, 46), GraphicsUnit.Pixel)
                    Button174.BackgroundImage = Cimg
                Case 6

                    g.DrawImage(NPCimg, New Rectangle(4, 0, 24, 32), New Rectangle(0, 0, 32, 42), GraphicsUnit.Pixel)
                    Button175.BackgroundImage = Cimg
                Case 7

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button176.BackgroundImage = Cimg
                Case 8

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 32, 32, 32), GraphicsUnit.Pixel)
                    Button177.BackgroundImage = Cimg
                Case 9

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 32, 32, 32), GraphicsUnit.Pixel)
                    Button178.BackgroundImage = Cimg
                Case 10

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button179.BackgroundImage = Cimg
                Case 11

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button180.BackgroundImage = Cimg
                Case 12

                    g.DrawImage(NPCimg, New Rectangle(4, 0, 24, 32), New Rectangle(0, 0, 64, 64), GraphicsUnit.Pixel)
                    Button181.BackgroundImage = Cimg
                Case 13

                    g.DrawImage(NPCimg, New Rectangle(4, 0, 24, 32), New Rectangle(0, 0, 64, 64), GraphicsUnit.Pixel)
                    Button182.BackgroundImage = Cimg
                Case 14

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button183.BackgroundImage = Cimg
                Case 15

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button184.BackgroundImage = Cimg
                Case 16

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 66, 50), GraphicsUnit.Pixel)
                    Button185.BackgroundImage = Cimg
                Case 17

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button186.BackgroundImage = Cimg
                Case 18

                    g.DrawImage(NPCimg, New Rectangle(0, 2, 32, 28), New Rectangle(0, 0, 140, 128), GraphicsUnit.Pixel)
                    Button187.BackgroundImage = Cimg
                Case 19

                    g.DrawImage(NPCimg, New Rectangle(2, 0, 28, 32), New Rectangle(0, 0, 48, 64), GraphicsUnit.Pixel)
                    Button188.BackgroundImage = Cimg
                Case 20

                    g.DrawImage(NPCimg, New Rectangle(2, 0, 28, 32), New Rectangle(0, 0, 48, 64), GraphicsUnit.Pixel)
                    Button189.BackgroundImage = Cimg
                Case 21

                    g.DrawImage(NPCimg, New Rectangle(-4, 6, 32, 20), New Rectangle(0, 0, 130, 64), GraphicsUnit.Pixel)
                    Button190.BackgroundImage = Cimg
                Case 22

                    g.DrawImage(NPCimg, New Rectangle(0, 8, 32, 16), New Rectangle(0, 0, 64, 32), GraphicsUnit.Pixel)
                    Button191.BackgroundImage = Cimg
                Case 23

                    g.DrawImage(NPCimg, New Rectangle(4, 0, 24, 32), New Rectangle(0, 0, 32, 54), GraphicsUnit.Pixel)
                    Button192.BackgroundImage = Cimg
                Case 24

                    g.DrawImage(NPCimg, New Rectangle(4, 0, 24, 32), New Rectangle(0, 0, 32, 54), GraphicsUnit.Pixel)
                    Button193.BackgroundImage = Cimg
                Case 25

                    g.DrawImage(NPCimg, New Rectangle(4, 0, 24, 32), New Rectangle(0, 0, 32, 54), GraphicsUnit.Pixel)
                    Button194.BackgroundImage = Cimg
                Case 26

                    g.DrawImage(NPCimg, New Rectangle(4, 0, 24, 32), New Rectangle(0, 0, 32, 54), GraphicsUnit.Pixel)
                    Button195.BackgroundImage = Cimg
                Case 27

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button196.BackgroundImage = Cimg
                Case 28

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button197.BackgroundImage = Cimg
                Case 29

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button198.BackgroundImage = Cimg
                Case 30

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button199.BackgroundImage = Cimg
                Case 31

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button200.BackgroundImage = Cimg
                Case 32

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 30, 32), New Rectangle(0, 0, 56, 56), GraphicsUnit.Pixel)
                    Button201.BackgroundImage = Cimg
                Case 33

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 30, 32), New Rectangle(0, 0, 56, 56), GraphicsUnit.Pixel)
                    Button202.BackgroundImage = Cimg
                Case 34

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button203.BackgroundImage = Cimg
                Case 35

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button204.BackgroundImage = Cimg
                Case 36

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button205.BackgroundImage = Cimg
                Case 37

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button206.BackgroundImage = Cimg
                Case 38

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 30, 32), New Rectangle(0, 0, 56, 56), GraphicsUnit.Pixel)
                    Button207.BackgroundImage = Cimg
                Case 39

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 30, 32), New Rectangle(0, 0, 56, 56), GraphicsUnit.Pixel)
                    Button208.BackgroundImage = Cimg
                Case 40
                    Cimg = New Bitmap(42, 42)

                    g.DrawImage(NPCimg, New Rectangle(0, 14, 42, 16), New Rectangle(0, 0, 96, 32), GraphicsUnit.Pixel)
                    Button209.BackgroundImage = Cimg
                Case 41
                    Cimg = New Bitmap(42, 42)

                    g.DrawImage(NPCimg, New Rectangle(0, 14, 42, 16), New Rectangle(0, 0, 96, 32), GraphicsUnit.Pixel)
                    Button210.BackgroundImage = Cimg
                Case 42
                    Cimg = New Bitmap(42, 42)

                    g.DrawImage(NPCimg, New Rectangle(0, 14, 42, 16), New Rectangle(0, 0, 96, 32), GraphicsUnit.Pixel)
                    Button211.BackgroundImage = Cimg
                Case 43
                    Cimg = New Bitmap(42, 42)

                    g.DrawImage(NPCimg, New Rectangle(0, 14, 42, 16), New Rectangle(0, 0, 96, 32), GraphicsUnit.Pixel)
                    Button212.BackgroundImage = Cimg
                Case 44

                    g.DrawImage(NPCimg, New Rectangle(0, 10, 32, 8), New Rectangle(0, 0, 128, 22), GraphicsUnit.Pixel)
                    Button213.BackgroundImage = Cimg
                Case 45

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button214.BackgroundImage = Cimg
                Case 46

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button215.BackgroundImage = Cimg
                Case 47

                    g.DrawImage(NPCimg, New Rectangle(0, 8, 32, 16), New Rectangle(0, 0, 48, 16), GraphicsUnit.Pixel)
                    Button216.BackgroundImage = Cimg
                Case 48

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button217.BackgroundImage = Cimg
                Case 49

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button218.BackgroundImage = Cimg
                Case 50

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button219.BackgroundImage = Cimg
                Case 51

                    g.DrawImage(NPCimg, New Rectangle(0, 4, 32, 24), New Rectangle(0, 0, 48, 32), GraphicsUnit.Pixel)
                    Button220.BackgroundImage = Cimg
                Case 52

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button221.BackgroundImage = Cimg
                Case 53

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button222.BackgroundImage = Cimg
                Case 54

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 64, 64), GraphicsUnit.Pixel)
                    Button223.BackgroundImage = Cimg
                Case 55

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 48, 48), GraphicsUnit.Pixel)
                    Button224.BackgroundImage = Cimg
                Case 56

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button225.BackgroundImage = Cimg
                Case 57

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 48, 56), GraphicsUnit.Pixel)
                    Button226.BackgroundImage = Cimg
                Case 58

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 48, 56), GraphicsUnit.Pixel)
                    Button227.BackgroundImage = Cimg
                Case 59

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 48, 56), GraphicsUnit.Pixel)
                    Button228.BackgroundImage = Cimg
                Case 60

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 48, 56), GraphicsUnit.Pixel)
                    Button229.BackgroundImage = Cimg
                Case 61

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 48, 56), GraphicsUnit.Pixel)
                    Button230.BackgroundImage = Cimg
                Case 62

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 48, 56), GraphicsUnit.Pixel)
                    Button231.BackgroundImage = Cimg
                Case 63

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 48, 56), GraphicsUnit.Pixel)
                    Button232.BackgroundImage = Cimg
                Case 64

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 48, 56), GraphicsUnit.Pixel)
                    Button233.BackgroundImage = Cimg
                Case 65

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button234.BackgroundImage = Cimg
                Case 66

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button235.BackgroundImage = Cimg
                Case 67

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button236.BackgroundImage = Cimg
                Case 68

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button237.BackgroundImage = Cimg
                Case 69

                    g.DrawImage(NPCimg, New Rectangle(4, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button238.BackgroundImage = Cimg
                Case 70

                    g.DrawImage(NPCimg, New Rectangle(4, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button239.BackgroundImage = Cimg
                Case 71

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button240.BackgroundImage = Cimg
                Case 72

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button241.BackgroundImage = Cimg
                Case 73

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 128, 128), GraphicsUnit.Pixel)
                    Button242.BackgroundImage = Cimg
                Case 74

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 96, 32, 32), GraphicsUnit.Pixel)
                    Button243.BackgroundImage = Cimg
                Case 75

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button244.BackgroundImage = Cimg
                Case 76

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button245.BackgroundImage = Cimg
                Case 77

                    g.DrawImage(NPCimg, New Rectangle(4, 0, 24, 32), New Rectangle(0, 0, 32, 50), GraphicsUnit.Pixel)
                    Button246.BackgroundImage = Cimg
                Case 78

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button247.BackgroundImage = Cimg
                Case 79

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 44), GraphicsUnit.Pixel)
                    Button248.BackgroundImage = Cimg
                Case 80

                    g.DrawImage(NPCimg, New Rectangle(0, 4, 32, 24), New Rectangle(32, 176, 64, 44), GraphicsUnit.Pixel)
                    Button249.BackgroundImage = Cimg
            End Select

            FStream.Close()
            FStream.Dispose()
        Next

    End Sub

    Public Sub LoadMiscNPCs()
        sr = New System.IO.StringReader(SMB3ids)

        Dim split() As String
        Dim count As Integer
        split = MiscIds.Split(",")
        For count = 0 To split.Length - 1
            NPCid = CInt(split(count))

            FStream = New System.IO.FileStream(Prefix & NPCid & ".png", System.IO.FileMode.Open)
            NPCimg = Image.FromStream(FStream)
            Cimg = New Bitmap(32, 32)

            g = Graphics.FromImage(Cimg)

            Select Case count + 1
                Case 1

                    g.DrawImage(NPCimg, New Rectangle(0, 2, 32, 28), New Rectangle(0, 0, 32, 26), GraphicsUnit.Pixel)
                    Button250.BackgroundImage = Cimg
                Case 2

                    g.DrawImage(NPCimg, New Rectangle(0, 2, 32, 28), New Rectangle(0, 0, 32, 26), GraphicsUnit.Pixel)
                    Button251.BackgroundImage = Cimg
                Case 3

                    g.DrawImage(NPCimg, New Rectangle(0, 2, 32, 28), New Rectangle(0, 0, 32, 26), GraphicsUnit.Pixel)
                    Button252.BackgroundImage = Cimg
                Case 4

                    g.DrawImage(NPCimg, New Rectangle(7, 0, 18, 32), New Rectangle(0, 0, 36, 66), GraphicsUnit.Pixel)
                    Button253.BackgroundImage = Cimg
                Case 5

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button254.BackgroundImage = Cimg
                Case 6

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button255.BackgroundImage = Cimg
                Case 7

                    g.DrawImage(NPCimg, New Rectangle(0, 4, 32, 24), New Rectangle(0, 0, 56, 36), GraphicsUnit.Pixel)
                    Button256.BackgroundImage = Cimg
                Case 8

                    g.DrawImage(NPCimg, New Rectangle(0, 6, 32, 20), New Rectangle(0, 0, 46, 26), GraphicsUnit.Pixel)
                    Button257.BackgroundImage = Cimg
                Case 9

                    g.DrawImage(NPCimg, New Rectangle(0, 8, 32, 14), New Rectangle(34, 0, 78, 28), GraphicsUnit.Pixel)
                    Button258.BackgroundImage = Cimg
                Case 10

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 44, 44), GraphicsUnit.Pixel)
                    Button259.BackgroundImage = Cimg
                Case 11

                    g.DrawImage(NPCimg, New Rectangle(4, 0, 24, 32), New Rectangle(0, 0, 26, 46), GraphicsUnit.Pixel)
                    Button260.BackgroundImage = Cimg
                Case 12

                    g.DrawImage(NPCimg, New Rectangle(8, 0, 14, 32), New Rectangle(0, 0, 48, 128), GraphicsUnit.Pixel)
                    Button261.BackgroundImage = Cimg
                Case 13

                    g.DrawImage(NPCimg, New Rectangle(8, 0, 14, 32), New Rectangle(0, 0, 48, 128), GraphicsUnit.Pixel)
                    Button262.BackgroundImage = Cimg
                Case 14

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button263.BackgroundImage = Cimg
                Case 15

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button264.BackgroundImage = Cimg
                Case 16

                    g.DrawImage(NPCimg, New Rectangle(8, 0, 16, 32), New Rectangle(0, 0, 16, 32), GraphicsUnit.Pixel)
                    Button265.BackgroundImage = Cimg
                Case 17

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button266.BackgroundImage = Cimg
                Case 18

                    g.DrawImage(NPCimg, New Rectangle(4, 0, 24, 32), New Rectangle(0, 0, 32, 42), GraphicsUnit.Pixel)
                    Button267.BackgroundImage = Cimg
                Case 19

                    g.DrawImage(NPCimg, New Rectangle(8, 0, 16, 32), New Rectangle(0, 0, 16, 32), GraphicsUnit.Pixel)
                    Button268.BackgroundImage = Cimg
                Case 20

                    g.DrawImage(NPCimg, New Rectangle(8, 0, 16, 32), New Rectangle(0, 0, 16, 32), GraphicsUnit.Pixel)
                    Button269.BackgroundImage = Cimg
                Case 21

                    g.DrawImage(NPCimg, New Rectangle(12, 0, 8, 32), New Rectangle(0, 0, 20, 96), GraphicsUnit.Pixel)
                    Button270.BackgroundImage = Cimg
                Case 22

                    g.DrawImage(NPCimg, New Rectangle(8, 0, 16, 32), New Rectangle(0, 0, 32, 64), GraphicsUnit.Pixel)
                    Button271.BackgroundImage = Cimg
                Case 23

                    g.DrawImage(NPCimg, New Rectangle(-4, 0, 32, 32), New Rectangle(0, 0, 48, 38), GraphicsUnit.Pixel)
                    Button272.BackgroundImage = Cimg
                Case 24

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 128, 128), GraphicsUnit.Pixel)
                    Button273.BackgroundImage = Cimg
                Case 25

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 96, 106), GraphicsUnit.Pixel)
                    Button274.BackgroundImage = Cimg
                Case 26

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button275.BackgroundImage = Cimg
                Case 27

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button276.BackgroundImage = Cimg
                Case 28

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button277.BackgroundImage = Cimg
                Case 29

                    g.DrawImage(NPCimg, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
                    Button278.BackgroundImage = Cimg
            End Select

            FStream.Close()
            FStream.Dispose()

        Next
    End Sub

    Private Sub Button19_Click(sender As System.Object, e As System.EventArgs) Handles Button19.Click
        Form2.SelectedNPC = 1
    End Sub

    Private Sub Button20_Click(sender As System.Object, e As System.EventArgs) Handles Button20.Click
        Form2.SelectedNPC = 2
    End Sub

    Private Sub Button21_Click(sender As System.Object, e As System.EventArgs) Handles Button21.Click
        Form2.SelectedNPC = 3
    End Sub

    Private Sub Button22_Click(sender As System.Object, e As System.EventArgs) Handles Button22.Click
        Form2.SelectedNPC = 4
    End Sub

    Private Sub Button41_Click(sender As System.Object, e As System.EventArgs) Handles Button41.Click
        Form2.SelectedNPC = 5
    End Sub

    Private Sub Button23_Click(sender As System.Object, e As System.EventArgs) Handles Button23.Click
        Form2.SelectedNPC = 6
    End Sub

    Private Sub Button24_Click(sender As System.Object, e As System.EventArgs) Handles Button24.Click
        Form2.SelectedNPC = 7
    End Sub

    Private Sub Button25_Click(sender As System.Object, e As System.EventArgs) Handles Button25.Click
        Form2.SelectedNPC = 8
    End Sub

    Private Sub Button26_Click(sender As System.Object, e As System.EventArgs) Handles Button26.Click
        Form2.SelectedNPC = 9
    End Sub

    Private Sub Button27_Click(sender As System.Object, e As System.EventArgs) Handles Button27.Click
        Form2.SelectedNPC = 10
    End Sub

    Private Sub Button28_Click(sender As System.Object, e As System.EventArgs) Handles Button28.Click
        Form2.SelectedNPC = 11
    End Sub

    Private Sub Button29_Click(sender As System.Object, e As System.EventArgs) Handles Button29.Click
        Form2.SelectedNPC = 12
    End Sub

    Private Sub Button30_Click(sender As System.Object, e As System.EventArgs) Handles Button30.Click
        Form2.SelectedNPC = 13
    End Sub

    Private Sub Button31_Click(sender As System.Object, e As System.EventArgs) Handles Button31.Click
        Form2.SelectedNPC = 14
    End Sub

    Private Sub Button32_Click(sender As System.Object, e As System.EventArgs) Handles Button32.Click
        Form2.SelectedNPC = 15
    End Sub

    Private Sub Button33_Click(sender As System.Object, e As System.EventArgs) Handles Button33.Click
        Form2.SelectedNPC = 16
    End Sub

    Private Sub Button34_Click(sender As System.Object, e As System.EventArgs) Handles Button34.Click
        Form2.SelectedNPC = 17
    End Sub

    Private Sub Button35_Click(sender As System.Object, e As System.EventArgs) Handles Button35.Click
        Form2.SelectedNPC = 18
    End Sub

    Private Sub Button36_Click(sender As System.Object, e As System.EventArgs) Handles Button36.Click
        Form2.SelectedNPC = 19
    End Sub

    Private Sub Button37_Click(sender As System.Object, e As System.EventArgs) Handles Button37.Click
        Form2.SelectedNPC = 20
    End Sub

    Private Sub Button38_Click(sender As System.Object, e As System.EventArgs) Handles Button38.Click
        Form2.SelectedNPC = 21
    End Sub

    Private Sub Button39_Click(sender As System.Object, e As System.EventArgs) Handles Button39.Click
        Form2.SelectedNPC = 22
    End Sub

    Private Sub Button40_Click(sender As System.Object, e As System.EventArgs) Handles Button40.Click
        Form2.SelectedNPC = 23
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Form2.SelectedNPC = 24
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Form2.SelectedNPC = 25
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Form2.SelectedNPC = 26
    End Sub

    Private Sub Button42_Click(sender As System.Object, e As System.EventArgs) Handles Button42.Click
        Form2.SelectedNPC = 27
    End Sub

    Private Sub Button43_Click(sender As System.Object, e As System.EventArgs) Handles Button43.Click
        Form2.SelectedNPC = 28
    End Sub

    Private Sub Button44_Click(sender As System.Object, e As System.EventArgs) Handles Button44.Click
        Form2.SelectedNPC = 29
    End Sub

    Private Sub Button45_Click(sender As System.Object, e As System.EventArgs) Handles Button45.Click
        Form2.SelectedNPC = 30
    End Sub

    Private Sub Button46_Click(sender As System.Object, e As System.EventArgs) Handles Button46.Click
        Form2.SelectedNPC = 31
    End Sub

    Private Sub Button47_Click(sender As System.Object, e As System.EventArgs) Handles Button47.Click
        Form2.SelectedNPC = 32
    End Sub

    Private Sub Button48_Click(sender As System.Object, e As System.EventArgs) Handles Button48.Click
        Form2.SelectedNPC = 33
    End Sub

    Private Sub Button49_Click(sender As System.Object, e As System.EventArgs) Handles Button49.Click
        Form2.SelectedNPC = 34
    End Sub

    Private Sub Button50_Click(sender As System.Object, e As System.EventArgs) Handles Button50.Click
        Form2.SelectedNPC = 35
    End Sub

    Private Sub Button51_Click(sender As System.Object, e As System.EventArgs) Handles Button51.Click
        Form2.SelectedNPC = 36
    End Sub

    Private Sub Button52_Click(sender As System.Object, e As System.EventArgs) Handles Button52.Click
        Form2.SelectedNPC = 37
    End Sub

    Private Sub Button53_Click(sender As System.Object, e As System.EventArgs) Handles Button53.Click
        Form2.SelectedNPC = 38
    End Sub

    Private Sub Button54_Click(sender As System.Object, e As System.EventArgs) Handles Button54.Click
        Form2.SelectedNPC = 39
    End Sub

    Private Sub Button55_Click(sender As System.Object, e As System.EventArgs) Handles Button55.Click
        Form2.SelectedNPC = 40
    End Sub

    Private Sub Button56_Click(sender As System.Object, e As System.EventArgs) Handles Button56.Click
        Form2.SelectedNPC = 41
    End Sub

    Private Sub Button57_Click(sender As System.Object, e As System.EventArgs) Handles Button57.Click
        Form2.SelectedNPC = 42
    End Sub

    Private Sub Button58_Click(sender As System.Object, e As System.EventArgs) Handles Button58.Click
        Form2.SelectedNPC = 43
    End Sub

    Private Sub Button59_Click(sender As System.Object, e As System.EventArgs) Handles Button59.Click
        Form2.SelectedNPC = 44
    End Sub

    Private Sub Button60_Click(sender As System.Object, e As System.EventArgs) Handles Button60.Click
        Form2.SelectedNPC = 45
    End Sub

    Private Sub Button61_Click(sender As System.Object, e As System.EventArgs) Handles Button61.Click
        Form2.SelectedNPC = 46
    End Sub

    Private Sub Button62_Click(sender As System.Object, e As System.EventArgs) Handles Button62.Click
        Form2.SelectedNPC = 47
    End Sub

    Private Sub Button63_Click(sender As System.Object, e As System.EventArgs) Handles Button63.Click
        Form2.SelectedNPC = 48
    End Sub

    Private Sub Button64_Click(sender As System.Object, e As System.EventArgs) Handles Button64.Click
        Form2.SelectedNPC = 49
    End Sub

    Private Sub Button65_Click(sender As System.Object, e As System.EventArgs) Handles Button65.Click
        Form2.SelectedNPC = 50
    End Sub

    Private Sub Button66_Click(sender As System.Object, e As System.EventArgs) Handles Button66.Click
        Form2.SelectedNPC = 51
    End Sub

    Private Sub Button67_Click(sender As System.Object, e As System.EventArgs) Handles Button67.Click
        Form2.SelectedNPC = 52
    End Sub

    Private Sub Button68_Click(sender As System.Object, e As System.EventArgs) Handles Button68.Click
        Form2.SelectedNPC = 53
    End Sub

    Private Sub Button69_Click(sender As System.Object, e As System.EventArgs) Handles Button69.Click
        Form2.SelectedNPC = 54
    End Sub

    Private Sub Button70_Click(sender As System.Object, e As System.EventArgs) Handles Button70.Click
        Form2.SelectedNPC = 55
    End Sub

    Private Sub Button71_Click(sender As System.Object, e As System.EventArgs) Handles Button71.Click
        Form2.SelectedNPC = 56
    End Sub

    Private Sub Button72_Click(sender As System.Object, e As System.EventArgs) Handles Button72.Click
        Form2.SelectedNPC = 57
    End Sub

    Private Sub Button73_Click(sender As System.Object, e As System.EventArgs) Handles Button73.Click
        Form2.SelectedNPC = 58
    End Sub

    Private Sub Button74_Click(sender As System.Object, e As System.EventArgs) Handles Button74.Click
        Form2.SelectedNPC = 59
    End Sub

    Private Sub Button75_Click(sender As System.Object, e As System.EventArgs) Handles Button75.Click
        Form2.SelectedNPC = 60
    End Sub

    Private Sub Button76_Click(sender As System.Object, e As System.EventArgs) Handles Button76.Click
        Form2.SelectedNPC = 61
    End Sub

    Private Sub Button77_Click(sender As System.Object, e As System.EventArgs) Handles Button77.Click
        Form2.SelectedNPC = 62
    End Sub

    Private Sub Button78_Click(sender As System.Object, e As System.EventArgs) Handles Button78.Click
        Form2.SelectedNPC = 63
    End Sub

    Private Sub Button79_Click(sender As System.Object, e As System.EventArgs) Handles Button79.Click
        Form2.SelectedNPC = 64
    End Sub

    Private Sub Button80_Click(sender As System.Object, e As System.EventArgs) Handles Button80.Click
        Form2.SelectedNPC = 65
    End Sub

    Private Sub Button81_Click(sender As System.Object, e As System.EventArgs) Handles Button81.Click
        Form2.SelectedNPC = 66
    End Sub

    Private Sub Button82_Click(sender As System.Object, e As System.EventArgs) Handles Button82.Click
        Form2.SelectedNPC = 67
    End Sub

    Private Sub Button83_Click(sender As System.Object, e As System.EventArgs) Handles Button83.Click
        Form2.SelectedNPC = 68
    End Sub

    Private Sub Button84_Click(sender As System.Object, e As System.EventArgs) Handles Button84.Click
        Form2.SelectedNPC = 69
    End Sub

    Private Sub Button85_Click(sender As System.Object, e As System.EventArgs) Handles Button85.Click
        Form2.SelectedNPC = 70
    End Sub

    Private Sub Button86_Click(sender As System.Object, e As System.EventArgs) Handles Button86.Click
        Form2.SelectedNPC = 71
    End Sub

    Private Sub Button87_Click(sender As System.Object, e As System.EventArgs) Handles Button87.Click
        Form2.SelectedNPC = 72
    End Sub

    Private Sub Button88_Click(sender As System.Object, e As System.EventArgs) Handles Button88.Click
        Form2.SelectedNPC = 73
    End Sub

    Private Sub Button89_Click(sender As System.Object, e As System.EventArgs) Handles Button89.Click
        Form2.SelectedNPC = 74
    End Sub

    Private Sub Button90_Click(sender As System.Object, e As System.EventArgs) Handles Button90.Click
        Form2.SelectedNPC = 75
    End Sub

    Private Sub Button91_Click(sender As System.Object, e As System.EventArgs) Handles Button91.Click
        Form2.SelectedNPC = 76
    End Sub

    Private Sub Button92_Click(sender As System.Object, e As System.EventArgs) Handles Button92.Click
        Form2.SelectedNPC = 77
    End Sub

    Private Sub Button93_Click(sender As System.Object, e As System.EventArgs) Handles Button93.Click
        Form2.SelectedNPC = 78
    End Sub

    Private Sub Button94_Click(sender As System.Object, e As System.EventArgs) Handles Button94.Click
        Form2.SelectedNPC = 79
    End Sub

    Private Sub Button95_Click(sender As System.Object, e As System.EventArgs) Handles Button95.Click
        Form2.SelectedNPC = 80
    End Sub

    Private Sub Button96_Click(sender As System.Object, e As System.EventArgs) Handles Button96.Click
        Form2.SelectedNPC = 81
    End Sub

    Private Sub Button97_Click(sender As System.Object, e As System.EventArgs) Handles Button97.Click
        Form2.SelectedNPC = 82
    End Sub

    Private Sub Button98_Click(sender As System.Object, e As System.EventArgs) Handles Button98.Click
        Form2.SelectedNPC = 83
    End Sub

    Private Sub Button99_Click(sender As System.Object, e As System.EventArgs) Handles Button99.Click
        Form2.SelectedNPC = 84
    End Sub

    Private Sub Button100_Click(sender As System.Object, e As System.EventArgs) Handles Button100.Click
        Form2.SelectedNPC = 85
    End Sub

    Private Sub Button101_Click(sender As System.Object, e As System.EventArgs) Handles Button101.Click
        Form2.SelectedNPC = 86
    End Sub

    Private Sub Button102_Click(sender As System.Object, e As System.EventArgs) Handles Button102.Click
        Form2.SelectedNPC = 87
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        smb_npcs.Visible = False
        smb2_npcs.Visible = True
        smb3_npcs.Visible = False
        smw_npcs.Visible = False
        misc_npcs.Visible = False
        'LoadSMB2NPCs()
    End Sub

    Private Sub Button103_Click(sender As System.Object, e As System.EventArgs) Handles Button103.Click
        Form2.SelectedNPC = 88
    End Sub

    Private Sub Button104_Click(sender As System.Object, e As System.EventArgs) Handles Button104.Click
        Form2.SelectedNPC = 89
    End Sub

    Private Sub Button105_Click(sender As System.Object, e As System.EventArgs) Handles Button105.Click
        Form2.SelectedNPC = 90
    End Sub

    Private Sub Button106_Click(sender As System.Object, e As System.EventArgs) Handles Button106.Click
        Form2.SelectedNPC = 91
    End Sub

    Private Sub Button107_Click(sender As System.Object, e As System.EventArgs) Handles Button107.Click
        Form2.SelectedNPC = 92
    End Sub

    Private Sub Button108_Click(sender As System.Object, e As System.EventArgs) Handles Button108.Click
        Form2.SelectedNPC = 93
    End Sub

    Private Sub Button109_Click(sender As System.Object, e As System.EventArgs) Handles Button109.Click
        Form2.SelectedNPC = 94
    End Sub

    Private Sub Button110_Click(sender As System.Object, e As System.EventArgs) Handles Button110.Click
        Form2.SelectedNPC = 95
    End Sub

    Private Sub Button111_Click(sender As System.Object, e As System.EventArgs) Handles Button111.Click
        Form2.SelectedNPC = 96
    End Sub

    Private Sub Button112_Click(sender As System.Object, e As System.EventArgs) Handles Button112.Click
        Form2.SelectedNPC = 97
    End Sub

    Private Sub Button113_Click(sender As System.Object, e As System.EventArgs) Handles Button113.Click
        Form2.SelectedNPC = 98
    End Sub

    Private Sub Button114_Click(sender As System.Object, e As System.EventArgs) Handles Button114.Click
        Form2.SelectedNPC = 99
    End Sub

    Private Sub Button115_Click(sender As System.Object, e As System.EventArgs) Handles Button115.Click
        Form2.SelectedNPC = 100
    End Sub

    Private Sub Button116_Click(sender As System.Object, e As System.EventArgs) Handles Button116.Click
        Form2.SelectedNPC = 101
    End Sub

    Private Sub Button117_Click(sender As System.Object, e As System.EventArgs) Handles Button117.Click
        Form2.SelectedNPC = 102
    End Sub

    Private Sub Button118_Click(sender As System.Object, e As System.EventArgs) Handles Button118.Click
        Form2.SelectedNPC = 103
    End Sub

    Private Sub Button119_Click(sender As System.Object, e As System.EventArgs) Handles Button119.Click
        Form2.SelectedNPC = 104
    End Sub

    Private Sub Button120_Click(sender As System.Object, e As System.EventArgs) Handles Button120.Click
        Form2.SelectedNPC = 105
    End Sub

    Private Sub Button121_Click(sender As System.Object, e As System.EventArgs) Handles Button121.Click
        Form2.SelectedNPC = 106
    End Sub

    Private Sub Button122_Click(sender As System.Object, e As System.EventArgs) Handles Button122.Click
        Form2.SelectedNPC = 107
    End Sub

    Private Sub Button123_Click(sender As System.Object, e As System.EventArgs) Handles Button123.Click
        Form2.SelectedNPC = 108
    End Sub

    Private Sub Button124_Click(sender As System.Object, e As System.EventArgs) Handles Button124.Click
        Form2.SelectedNPC = 109
    End Sub

    Private Sub Button125_Click(sender As System.Object, e As System.EventArgs) Handles Button125.Click
        Form2.SelectedNPC = 110
    End Sub

    Private Sub Button126_Click(sender As System.Object, e As System.EventArgs) Handles Button126.Click
        Form2.SelectedNPC = 111
    End Sub

    Private Sub Button127_Click(sender As System.Object, e As System.EventArgs) Handles Button127.Click
        Form2.SelectedNPC = 112
    End Sub

    Private Sub Button128_Click(sender As System.Object, e As System.EventArgs) Handles Button128.Click
        Form2.SelectedNPC = 113
    End Sub

    Private Sub Button129_Click(sender As System.Object, e As System.EventArgs) Handles Button129.Click
        Form2.SelectedNPC = 114
    End Sub

    Private Sub Button130_Click(sender As System.Object, e As System.EventArgs) Handles Button130.Click
        Form2.SelectedNPC = 115
    End Sub

    Private Sub Button131_Click(sender As System.Object, e As System.EventArgs) Handles Button131.Click
        Form2.SelectedNPC = 116
    End Sub

    Private Sub Button132_Click(sender As System.Object, e As System.EventArgs) Handles Button132.Click
        Form2.SelectedNPC = 117
    End Sub

    Private Sub Button133_Click(sender As System.Object, e As System.EventArgs) Handles Button133.Click
        Form2.SelectedNPC = 118
    End Sub

    Private Sub Button134_Click(sender As System.Object, e As System.EventArgs) Handles Button134.Click
        Form2.SelectedNPC = 119
    End Sub

    Private Sub Button135_Click(sender As System.Object, e As System.EventArgs) Handles Button135.Click
        Form2.SelectedNPC = 120
    End Sub

    Private Sub Button136_Click(sender As System.Object, e As System.EventArgs) Handles Button136.Click
        Form2.SelectedNPC = 121
    End Sub

    Private Sub Button137_Click(sender As System.Object, e As System.EventArgs) Handles Button137.Click
        Form2.SelectedNPC = 122
    End Sub

    Private Sub Button138_Click(sender As System.Object, e As System.EventArgs) Handles Button138.Click
        Form2.SelectedNPC = 123
    End Sub

    Private Sub Button139_Click(sender As System.Object, e As System.EventArgs) Handles Button139.Click
        Form2.SelectedNPC = 124
    End Sub

    Private Sub Button140_Click(sender As System.Object, e As System.EventArgs) Handles Button140.Click
        Form2.SelectedNPC = 125
    End Sub

    Private Sub Button141_Click(sender As System.Object, e As System.EventArgs) Handles Button141.Click
        Form2.SelectedNPC = 126
    End Sub

    Private Sub Button142_Click(sender As System.Object, e As System.EventArgs) Handles Button142.Click
        Form2.SelectedNPC = 127
    End Sub

    Private Sub Button143_Click(sender As System.Object, e As System.EventArgs) Handles Button143.Click
        Form2.SelectedNPC = 128
    End Sub

    Private Sub Button144_Click(sender As System.Object, e As System.EventArgs) Handles Button144.Click
        Form2.SelectedNPC = 129
    End Sub

    Private Sub Button145_Click(sender As System.Object, e As System.EventArgs) Handles Button145.Click
        Form2.SelectedNPC = 130
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        smb3_npcs.Visible = True
        smb2_npcs.Visible = False
        smb_npcs.Visible = False
        smw_npcs.Visible = False
        misc_npcs.Visible = False
        'LoadSMB3NPCs()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        smb_npcs.Visible = True
        smb2_npcs.Visible = False
        smb3_npcs.Visible = False
        smw_npcs.Visible = False
        misc_npcs.Visible = False
        'LoadSMBNPCs()
    End Sub

    Private Sub Button146_Click(sender As System.Object, e As System.EventArgs) Handles Button146.Click
        Form2.SelectedNPC = 131
    End Sub

    Private Sub Button147_Click(sender As System.Object, e As System.EventArgs) Handles Button147.Click
        Form2.SelectedNPC = 132
    End Sub

    Private Sub Button148_Click(sender As System.Object, e As System.EventArgs) Handles Button148.Click
        Form2.SelectedNPC = 133
    End Sub

    Private Sub Button149_Click(sender As System.Object, e As System.EventArgs) Handles Button149.Click
        Form2.SelectedNPC = 134
    End Sub

    Private Sub Button150_Click(sender As System.Object, e As System.EventArgs) Handles Button150.Click
        Form2.SelectedNPC = 135
    End Sub

    Private Sub Button151_Click(sender As System.Object, e As System.EventArgs) Handles Button151.Click
        Form2.SelectedNPC = 136
    End Sub

    Private Sub Button152_Click(sender As System.Object, e As System.EventArgs) Handles Button152.Click
        Form2.SelectedNPC = 137
    End Sub

    Private Sub Button153_Click(sender As System.Object, e As System.EventArgs) Handles Button153.Click
        Form2.SelectedNPC = 138
    End Sub

    Private Sub Button154_Click(sender As System.Object, e As System.EventArgs) Handles Button154.Click
        Form2.SelectedNPC = 139
    End Sub

    Private Sub Button155_Click(sender As System.Object, e As System.EventArgs) Handles Button155.Click
        Form2.SelectedNPC = 140
    End Sub

    Private Sub Button156_Click(sender As System.Object, e As System.EventArgs) Handles Button156.Click
        Form2.SelectedNPC = 141
    End Sub

    Private Sub Button157_Click(sender As System.Object, e As System.EventArgs) Handles Button157.Click
        Form2.SelectedNPC = 142
    End Sub

    Private Sub Button158_Click(sender As System.Object, e As System.EventArgs) Handles Button158.Click
        Form2.SelectedNPC = 143
    End Sub

    Private Sub Button159_Click(sender As System.Object, e As System.EventArgs) Handles Button159.Click
        Form2.SelectedNPC = 144
    End Sub

    Private Sub Button160_Click(sender As System.Object, e As System.EventArgs) Handles Button160.Click
        Form2.SelectedNPC = 145
    End Sub

    Private Sub Button161_Click(sender As System.Object, e As System.EventArgs) Handles Button161.Click
        Form2.SelectedNPC = 146
    End Sub

    Private Sub Button162_Click(sender As System.Object, e As System.EventArgs) Handles Button162.Click
        Form2.SelectedNPC = 147
    End Sub

    Private Sub Button163_Click(sender As System.Object, e As System.EventArgs) Handles Button163.Click
        Form2.SelectedNPC = 148
    End Sub

    Private Sub Button164_Click(sender As System.Object, e As System.EventArgs) Handles Button164.Click
        Form2.SelectedNPC = 149
    End Sub

    Private Sub Button165_Click(sender As System.Object, e As System.EventArgs) Handles Button165.Click
        Form2.SelectedNPC = 150
    End Sub

    Private Sub Button166_Click(sender As System.Object, e As System.EventArgs) Handles Button166.Click
        Form2.SelectedNPC = 151
    End Sub

    Private Sub Button167_Click(sender As System.Object, e As System.EventArgs) Handles Button167.Click
        Form2.SelectedNPC = 152
    End Sub

    Private Sub Button168_Click(sender As System.Object, e As System.EventArgs) Handles Button168.Click
        Form2.SelectedNPC = 153
    End Sub

    Private Sub Button169_Click(sender As System.Object, e As System.EventArgs) Handles Button169.Click
        Form2.SelectedNPC = 154
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        smb_npcs.Visible = False
        smb2_npcs.Visible = False
        smb3_npcs.Visible = False
        misc_npcs.Visible = False
        smw_npcs.Visible = True
        'LoadSMWNPCs()
    End Sub

    Private Sub Button170_Click(sender As System.Object, e As System.EventArgs) Handles Button170.Click
        Form2.SelectedNPC = 155
    End Sub

    Private Sub Button171_Click(sender As System.Object, e As System.EventArgs) Handles Button171.Click
        Form2.SelectedNPC = 156
    End Sub

    Private Sub Button172_Click(sender As System.Object, e As System.EventArgs) Handles Button172.Click
        Form2.SelectedNPC = 157
    End Sub

    Private Sub Button173_Click(sender As System.Object, e As System.EventArgs) Handles Button173.Click
        Form2.SelectedNPC = 158
    End Sub

    Private Sub Button174_Click(sender As System.Object, e As System.EventArgs) Handles Button174.Click
        Form2.SelectedNPC = 159
    End Sub

    Private Sub Button175_Click(sender As System.Object, e As System.EventArgs) Handles Button175.Click
        Form2.SelectedNPC = 160
    End Sub

    Private Sub Button176_Click(sender As System.Object, e As System.EventArgs) Handles Button176.Click
        Form2.SelectedNPC = 161
    End Sub

    Private Sub Button177_Click(sender As System.Object, e As System.EventArgs) Handles Button177.Click
        Form2.SelectedNPC = 162
    End Sub

    Private Sub Button178_Click(sender As System.Object, e As System.EventArgs) Handles Button178.Click
        Form2.SelectedNPC = 163
    End Sub

    Private Sub Button179_Click(sender As System.Object, e As System.EventArgs) Handles Button179.Click
        Form2.SelectedNPC = 164
    End Sub

    Private Sub Button180_Click(sender As System.Object, e As System.EventArgs) Handles Button180.Click
        Form2.SelectedNPC = 165
    End Sub

    Private Sub Button181_Click(sender As System.Object, e As System.EventArgs) Handles Button181.Click
        Form2.SelectedNPC = 166
    End Sub

    Private Sub Button182_Click(sender As System.Object, e As System.EventArgs) Handles Button182.Click
        Form2.SelectedNPC = 167
    End Sub

    Private Sub Button183_Click(sender As System.Object, e As System.EventArgs) Handles Button183.Click
        Form2.SelectedNPC = 168
    End Sub

    Private Sub Button184_Click(sender As System.Object, e As System.EventArgs) Handles Button184.Click
        Form2.SelectedNPC = 169
    End Sub

    Private Sub Button185_Click(sender As System.Object, e As System.EventArgs) Handles Button185.Click
        Form2.SelectedNPC = 170
    End Sub

    Private Sub Button186_Click(sender As System.Object, e As System.EventArgs) Handles Button186.Click
        Form2.SelectedNPC = 171
    End Sub

    Private Sub Button187_Click(sender As System.Object, e As System.EventArgs) Handles Button187.Click
        Form2.SelectedNPC = 172
    End Sub

    Private Sub Button188_Click(sender As System.Object, e As System.EventArgs) Handles Button188.Click
        Form2.SelectedNPC = 173
    End Sub

    Private Sub Button189_Click(sender As System.Object, e As System.EventArgs) Handles Button189.Click
        Form2.SelectedNPC = 174
    End Sub

    Private Sub Button190_Click(sender As System.Object, e As System.EventArgs) Handles Button190.Click
        Form2.SelectedNPC = 175
    End Sub

    Private Sub Button191_Click(sender As System.Object, e As System.EventArgs) Handles Button191.Click
        Form2.SelectedNPC = 176
    End Sub

    Private Sub Button192_Click(sender As System.Object, e As System.EventArgs) Handles Button192.Click
        Form2.SelectedNPC = 177
    End Sub

    Private Sub Button193_Click(sender As System.Object, e As System.EventArgs) Handles Button193.Click
        Form2.SelectedNPC = 178
    End Sub

    Private Sub Button194_Click(sender As System.Object, e As System.EventArgs) Handles Button194.Click
        Form2.SelectedNPC = 179
    End Sub

    Private Sub Button195_Click(sender As System.Object, e As System.EventArgs) Handles Button195.Click
        Form2.SelectedNPC = 180
    End Sub

    Private Sub Button196_Click(sender As System.Object, e As System.EventArgs) Handles Button196.Click
        Form2.SelectedNPC = 181
    End Sub

    Private Sub Button197_Click(sender As System.Object, e As System.EventArgs) Handles Button197.Click
        Form2.SelectedNPC = 182
    End Sub

    Private Sub Button198_Click(sender As System.Object, e As System.EventArgs) Handles Button198.Click
        Form2.SelectedNPC = 183
    End Sub

    Private Sub Button199_Click(sender As System.Object, e As System.EventArgs) Handles Button199.Click
        Form2.SelectedNPC = 184
    End Sub

    Private Sub Button200_Click(sender As System.Object, e As System.EventArgs) Handles Button200.Click
        Form2.SelectedNPC = 185
    End Sub

    Private Sub Button201_Click(sender As System.Object, e As System.EventArgs) Handles Button201.Click
        Form2.SelectedNPC = 186
    End Sub

    Private Sub Button202_Click(sender As System.Object, e As System.EventArgs) Handles Button202.Click
        Form2.SelectedNPC = 187
    End Sub

    Private Sub Button203_Click(sender As System.Object, e As System.EventArgs) Handles Button203.Click
        Form2.SelectedNPC = 188
    End Sub

    Private Sub Button204_Click(sender As System.Object, e As System.EventArgs) Handles Button204.Click
        Form2.SelectedNPC = 189
    End Sub

    Private Sub Button205_Click(sender As System.Object, e As System.EventArgs) Handles Button205.Click
        Form2.SelectedNPC = 190
    End Sub

    Private Sub Button206_Click(sender As System.Object, e As System.EventArgs) Handles Button206.Click
        Form2.SelectedNPC = 191
    End Sub

    Private Sub Button207_Click(sender As System.Object, e As System.EventArgs) Handles Button207.Click
        Form2.SelectedNPC = 192
    End Sub

    Private Sub Button208_Click(sender As System.Object, e As System.EventArgs) Handles Button208.Click
        Form2.SelectedNPC = 193
    End Sub

    Private Sub Button209_Click(sender As System.Object, e As System.EventArgs) Handles Button209.Click
        Form2.SelectedNPC = 194
    End Sub

    Private Sub Button210_Click(sender As System.Object, e As System.EventArgs) Handles Button210.Click
        Form2.SelectedNPC = 195
    End Sub

    Private Sub Button211_Click(sender As System.Object, e As System.EventArgs) Handles Button211.Click
        Form2.SelectedNPC = 196
    End Sub

    Private Sub Button212_Click(sender As System.Object, e As System.EventArgs) Handles Button212.Click
        Form2.SelectedNPC = 197
    End Sub

    Private Sub Button213_Click(sender As System.Object, e As System.EventArgs) Handles Button213.Click
        Form2.SelectedNPC = 198
    End Sub

    Private Sub Button214_Click(sender As System.Object, e As System.EventArgs) Handles Button214.Click
        Form2.SelectedNPC = 199
    End Sub

    Private Sub Button215_Click(sender As System.Object, e As System.EventArgs) Handles Button215.Click
        Form2.SelectedNPC = 200
    End Sub

    Private Sub Button216_Click(sender As System.Object, e As System.EventArgs) Handles Button216.Click
        Form2.SelectedNPC = 201
    End Sub

    Private Sub Button217_Click(sender As System.Object, e As System.EventArgs) Handles Button217.Click
        Form2.SelectedNPC = 202
    End Sub

    Private Sub Button218_Click(sender As System.Object, e As System.EventArgs) Handles Button218.Click
        Form2.SelectedNPC = 203
    End Sub

    Private Sub Button219_Click(sender As System.Object, e As System.EventArgs) Handles Button219.Click
        Form2.SelectedNPC = 204
    End Sub

    Private Sub Button220_Click(sender As System.Object, e As System.EventArgs) Handles Button220.Click
        Form2.SelectedNPC = 205
    End Sub

    Private Sub Button221_Click(sender As System.Object, e As System.EventArgs) Handles Button221.Click
        Form2.SelectedNPC = 206
    End Sub

    Private Sub Button222_Click(sender As System.Object, e As System.EventArgs) Handles Button222.Click
        Form2.SelectedNPC = 207
    End Sub

    Private Sub Button223_Click(sender As System.Object, e As System.EventArgs) Handles Button223.Click
        Form2.SelectedNPC = 208
    End Sub

    Private Sub Button224_Click(sender As System.Object, e As System.EventArgs) Handles Button224.Click
        Form2.SelectedNPC = 209
    End Sub

    Private Sub Button225_Click(sender As System.Object, e As System.EventArgs) Handles Button225.Click
        Form2.SelectedNPC = 210
    End Sub

    Private Sub Button226_Click(sender As System.Object, e As System.EventArgs) Handles Button226.Click
        Form2.SelectedNPC = 211
    End Sub

    Private Sub Button227_Click(sender As System.Object, e As System.EventArgs) Handles Button227.Click
        Form2.SelectedNPC = 212
    End Sub

    Private Sub Button228_Click(sender As System.Object, e As System.EventArgs) Handles Button228.Click
        Form2.SelectedNPC = 213
    End Sub

    Private Sub Button229_Click(sender As System.Object, e As System.EventArgs) Handles Button229.Click
        Form2.SelectedNPC = 214
    End Sub

    Private Sub Button230_Click(sender As System.Object, e As System.EventArgs) Handles Button230.Click
        Form2.SelectedNPC = 215
    End Sub

    Private Sub Button231_Click(sender As System.Object, e As System.EventArgs) Handles Button231.Click
        Form2.SelectedNPC = 216
    End Sub

    Private Sub Button232_Click(sender As System.Object, e As System.EventArgs) Handles Button232.Click
        Form2.SelectedNPC = 217
    End Sub

    Private Sub Button233_Click(sender As System.Object, e As System.EventArgs) Handles Button233.Click
        Form2.SelectedNPC = 218
    End Sub

    Private Sub Button234_Click(sender As System.Object, e As System.EventArgs) Handles Button234.Click
        Form2.SelectedNPC = 219
    End Sub

    Private Sub Button235_Click(sender As System.Object, e As System.EventArgs) Handles Button235.Click
        Form2.SelectedNPC = 220
    End Sub

    Private Sub Button236_Click(sender As System.Object, e As System.EventArgs) Handles Button236.Click
        Form2.SelectedNPC = 221
    End Sub

    Private Sub Button237_Click(sender As System.Object, e As System.EventArgs) Handles Button237.Click
        Form2.SelectedNPC = 222
    End Sub

    Private Sub Button238_Click(sender As System.Object, e As System.EventArgs) Handles Button238.Click
        Form2.SelectedNPC = 223
    End Sub

    Private Sub Button239_Click(sender As System.Object, e As System.EventArgs) Handles Button239.Click
        Form2.SelectedNPC = 224
    End Sub

    Private Sub Button240_Click(sender As System.Object, e As System.EventArgs) Handles Button240.Click
        Form2.SelectedNPC = 225
    End Sub

    Private Sub Button241_Click(sender As System.Object, e As System.EventArgs) Handles Button241.Click
        Form2.SelectedNPC = 226
    End Sub

    Private Sub Button242_Click(sender As System.Object, e As System.EventArgs) Handles Button242.Click
        Form2.SelectedNPC = 227
    End Sub

    Private Sub Button243_Click(sender As System.Object, e As System.EventArgs) Handles Button243.Click
        Form2.SelectedNPC = 228
    End Sub

    Private Sub Button244_Click(sender As System.Object, e As System.EventArgs) Handles Button244.Click
        Form2.SelectedNPC = 229
    End Sub

    Private Sub Button245_Click(sender As System.Object, e As System.EventArgs) Handles Button245.Click
        Form2.SelectedNPC = 230
    End Sub

    Private Sub Button246_Click(sender As System.Object, e As System.EventArgs) Handles Button246.Click
        Form2.SelectedNPC = 231
    End Sub

    Private Sub Button247_Click(sender As System.Object, e As System.EventArgs) Handles Button247.Click
        Form2.SelectedNPC = 232
    End Sub

    Private Sub Button248_Click(sender As System.Object, e As System.EventArgs) Handles Button248.Click
        Form2.SelectedNPC = 233
    End Sub

    Private Sub Button249_Click(sender As System.Object, e As System.EventArgs) Handles Button249.Click
        Form2.SelectedNPC = 234
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        'LoadMiscNPCs()
        smb_npcs.Visible = False
        smb2_npcs.Visible = False
        smb3_npcs.Visible = False
        smw_npcs.Visible = False
        misc_npcs.Visible = True
    End Sub

    Private Sub Button250_Click(sender As System.Object, e As System.EventArgs) Handles Button250.Click
        Form2.SelectedNPC = 235
    End Sub

    Private Sub Button251_Click(sender As System.Object, e As System.EventArgs) Handles Button251.Click
        Form2.SelectedNPC = 236
    End Sub

    Private Sub Button252_Click(sender As System.Object, e As System.EventArgs) Handles Button252.Click
        Form2.SelectedNPC = 237
    End Sub

    Private Sub Button253_Click(sender As System.Object, e As System.EventArgs) Handles Button253.Click
        Form2.SelectedNPC = 238
    End Sub

    Private Sub Button254_Click(sender As System.Object, e As System.EventArgs) Handles Button254.Click
        Form2.SelectedNPC = 239
    End Sub

    Private Sub Button255_Click(sender As System.Object, e As System.EventArgs) Handles Button255.Click
        Form2.SelectedNPC = 240
    End Sub

    Private Sub Button256_Click(sender As System.Object, e As System.EventArgs) Handles Button256.Click
        Form2.SelectedNPC = 241
    End Sub

    Private Sub Button257_Click(sender As System.Object, e As System.EventArgs) Handles Button257.Click
        Form2.SelectedNPC = 242
    End Sub

    Private Sub Button258_Click(sender As System.Object, e As System.EventArgs) Handles Button258.Click
        Form2.SelectedNPC = 243
    End Sub

    Private Sub Button259_Click(sender As System.Object, e As System.EventArgs) Handles Button259.Click
        Form2.SelectedNPC = 244
    End Sub

    Private Sub Button260_Click(sender As System.Object, e As System.EventArgs) Handles Button260.Click
        Form2.SelectedNPC = 245
    End Sub

    Private Sub Button261_Click(sender As System.Object, e As System.EventArgs) Handles Button261.Click
        Form2.SelectedNPC = 246
    End Sub

    Private Sub Button262_Click(sender As System.Object, e As System.EventArgs) Handles Button262.Click
        Form2.SelectedNPC = 247
    End Sub

    Private Sub Button263_Click(sender As System.Object, e As System.EventArgs) Handles Button263.Click
        Form2.SelectedNPC = 248
    End Sub

    Private Sub Button264_Click(sender As System.Object, e As System.EventArgs) Handles Button264.Click
        Form2.SelectedNPC = 249
    End Sub

    Private Sub Button265_Click(sender As System.Object, e As System.EventArgs) Handles Button265.Click
        Form2.SelectedNPC = 250
    End Sub

    Private Sub Button266_Click(sender As System.Object, e As System.EventArgs) Handles Button266.Click
        Form2.SelectedNPC = 251
    End Sub

    Private Sub Button267_Click(sender As System.Object, e As System.EventArgs) Handles Button267.Click
        Form2.SelectedNPC = 252
    End Sub

    Private Sub Button268_Click(sender As System.Object, e As System.EventArgs) Handles Button268.Click
        Form2.SelectedNPC = 253
    End Sub

    Private Sub Button269_Click(sender As System.Object, e As System.EventArgs) Handles Button269.Click
        Form2.SelectedNPC = 254
    End Sub

    Private Sub Button270_Click(sender As System.Object, e As System.EventArgs) Handles Button270.Click
        Form2.SelectedNPC = 255
    End Sub

    Private Sub Button271_Click(sender As System.Object, e As System.EventArgs) Handles Button271.Click
        Form2.SelectedNPC = 256
    End Sub

    Private Sub Button272_Click(sender As System.Object, e As System.EventArgs) Handles Button272.Click
        Form2.SelectedNPC = 257
    End Sub

    Private Sub Button273_Click(sender As System.Object, e As System.EventArgs) Handles Button273.Click
        Form2.SelectedNPC = 258
    End Sub

    Private Sub Button274_Click(sender As System.Object, e As System.EventArgs) Handles Button274.Click
        Form2.SelectedNPC = 259
    End Sub

    Private Sub Button275_Click(sender As System.Object, e As System.EventArgs) Handles Button275.Click
        Form2.SelectedNPC = 260
    End Sub

    Private Sub Button276_Click(sender As System.Object, e As System.EventArgs) Handles Button276.Click
        Form2.SelectedNPC = 261
    End Sub

    Private Sub Button277_Click(sender As System.Object, e As System.EventArgs) Handles Button277.Click
        Form2.SelectedNPC = 262
    End Sub

    Private Sub Button278_Click(sender As System.Object, e As System.EventArgs) Handles Button278.Click
        Form2.SelectedNPC = 263
    End Sub
End Class