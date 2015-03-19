Public Structure BGO
    Dim rectangle As Rectangle
    Dim X As Integer
    Dim Y As Integer
    Dim Width As Integer
    Dim Height As Integer
    Dim ID As Integer
    Dim IMG As Image
    Dim Animated As Boolean
    Dim SourceRect As Rectangle
    Dim gfxWidth As Integer
    Dim gfxHeight As Integer
    Dim TotalFrames As Integer
    Dim FrameSpeed As Integer
    Dim ForeGround As Boolean
End Structure

Public Class Backgrounds
    Public Shared BGOW As Integer = 32
    Public Shared BGOH As Integer = 32
    Public Shared Animated As Boolean
    Public Shared gfxWidth As Integer
    Public Shared gfxHeight As Integer
    Public Shared FrameSpeed As Integer
    Public Shared TotalFrames As Integer
    Public Shared ForeGround As Boolean = False
    Public Shared BGOSize As Integer = 32
    Public Shared bgo As BGO
    Public Shared BGOs As New List(Of BGO)
    Public Shared bgorects As New List(Of Rectangle)

    Public Shared path As String

    Public Shared bmp As Bitmap

    Public Shared Sub GetBGO()
        bmp = Nothing

        BGOW = 32
        BGOH = 32
        gfxWidth = 32
        gfxHeight = 32
        Animated = False
        FrameSpeed = 8

        Select Case Form2.SelectedBGO
            Case 1
                path = Form1.FilePath & "\graphics\background\background-1.png"
            Case 2
                path = Form1.FilePath & "\graphics\background\background-7.png"

                gfxWidth = 256
                BGOW = 256
                gfxHeight = 128
                BGOH = 128
            Case 3
                path = Form1.FilePath & "\graphics\background\background-2.png"

                gfxWidth = 126
                BGOW = 126
                gfxHeight = 96
                BGOH = 96
            Case 4
                path = Form1.FilePath & "\graphics\background\background-6.png"

                gfxWidth = 192
                BGOW = 192
                gfxHeight = 130
                BGOH = 130
            Case 5
                path = Form1.FilePath & "\graphics\background\background-10.png"

                gfxWidth = 98
                BGOW = 98
                gfxHeight = 98
                BGOH = 98
            Case 6
                path = Form1.FilePath & "\graphics\background\background-114.png"

                gfxWidth = 96
                BGOW = 96
                gfxHeight = 36
                BGOH = 36
            Case 7
                path = Form1.FilePath & "\graphics\background\background-3.png"

                gfxWidth = 254
                BGOW = 254
                gfxHeight = 128
                BGOH = 128
            Case 8
                path = Form1.FilePath & "\graphics\background\background-8.png"

                gfxWidth = 192
                BGOW = 192
                gfxHeight = 256
                BGOH = 256
            Case 9
                path = Form1.FilePath & "\graphics\background\background-4.png"

                gfxWidth = 64
                BGOW = 64
                gfxHeight = 34
                BGOH = 34
            Case 10
                path = Form1.FilePath & "\graphics\background\background-5.png"

                gfxWidth = 128
                BGOW = 128
                gfxHeight = 34
                BGOH = 34
            Case 11
                path = Form1.FilePath & "\graphics\background\background-9.png"

                gfxWidth = 162
                BGOW = 162
                gfxHeight = 194
                BGOH = 194
            Case 12
                path = Form1.FilePath & "\graphics\background\background-64.png"

                gfxWidth = 96
                BGOW = 96
                gfxHeight = 96
                BGOH = 96
            Case 13
                path = Form1.FilePath & "\graphics\background\background-39.png"

                gfxWidth = 64
                BGOW = 64
                gfxHeight = 64
                BGOH = 64
            Case 14
                path = Form1.FilePath & "\graphics\background\background-40.png"

                gfxWidth = 128
                BGOW = 128
                gfxHeight = 128
                BGOH = 128
            Case 15
                path = Form1.FilePath & "\graphics\background\background-14.png"

                gfxWidth = 64
                BGOW = 64
                gfxHeight = 64
                BGOH = 64
            Case 16
                path = Form1.FilePath & "\graphics\background\background-15.png"

                gfxWidth = 128
                BGOW = 128
                gfxHeight = 128
                BGOH = 128
            Case 17
                path = Form1.FilePath & "\graphics\background\background-79.png"
            Case 18
                path = Form1.FilePath & "\graphics\background\background-65.png"

                Animated = True

                gfxWidth = 32
                BGOW = 32
                gfxHeight = 384
                BGOH = 96
            Case 19
                path = Form1.FilePath & "\graphics\background\background-82.png"

                gfxHeight = 128
                Animated = True
            Case 20
                path = Form1.FilePath & "\graphics\background\background-172.png"

                gfxHeight = 128
                Animated = True
            Case 21
                path = Form1.FilePath & "\graphics\background\background-170.png"

                gfxHeight = 128
                Animated = True
            Case 22
                path = Form1.FilePath & "\graphics\background\background-165.png"
            Case 23
                path = Form1.FilePath & "\graphics\background\background-83.png"
            Case 24
                path = Form1.FilePath & "\graphics\background\background-66.png"

                gfxHeight = 128
                Animated = True
            Case 25
                path = Form1.FilePath & "\graphics\background\background-171.png"

                gfxHeight = 128
                Animated = True
            Case 26
                path = Form1.FilePath & "\graphics\background\background-89.png"
            Case 27
                path = Form1.FilePath & "\graphics\background\background-94.png"
            Case 28
                path = Form1.FilePath & "\graphics\background\background-46.png"
            Case 29
                path = Form1.FilePath & "\graphics\background\background-93.png"
            Case 30
                path = Form1.FilePath & "\graphics\background\background-36.png"

                gfxWidth = 64
                BGOW = 64
                gfxHeight = 384
                BGOH = 96

                Animated = True
            Case 31
                path = Form1.FilePath & "\graphics\background\background-37.png"
            Case 32
                path = Form1.FilePath & "\graphics\background\background-163.png"

                gfxWidth = 64
                BGOW = 64
            Case 33
                path = Form1.FilePath & "\graphics\background\background-91.png"
            Case 34
                path = Form1.FilePath & "\graphics\background\background-95.png"
            Case 35
                path = Form1.FilePath & "\graphics\background\background-45.png"
            Case 36
                path = Form1.FilePath & "\graphics\background\background-69.png"
            Case 37
                path = Form1.FilePath & "\graphics\background\background-68.png"

                Animated = True

                gfxWidth = 96
                BGOW = 96
                gfxHeight = 256
                BGOH = 64
            Case 38
                path = Form1.FilePath & "\graphics\background\background-38.png"

                gfxWidth = 64
                BGOW = 64
                gfxHeight = 132
                BGOH = 132
            Case 39
                path = Form1.FilePath & "\graphics\background\background-90.png"
            Case 40
                path = Form1.FilePath & "\graphics\background\background-96.png"
            Case 41
                path = Form1.FilePath & "\graphics\background\background-97.png"
            Case 42
                path = Form1.FilePath & "\graphics\background\background-99.png"
            Case 43
                path = Form1.FilePath & "\graphics\background\background-101.png"
            Case 44
                path = Form1.FilePath & "\graphics\background\background-103.png"

                gfxWidth = 60
                BGOW = 60
                gfxHeight = 96
                BGOH = 96
            Case 45
                path = Form1.FilePath & "\graphics\background\background-80.png"
            Case 46
                path = Form1.FilePath & "\graphics\background\background-67.png"
            Case 47
                path = Form1.FilePath & "\graphics\background\background-81.png"
            Case 48
                path = Form1.FilePath & "\graphics\background\background-106.png"
            Case 49
                path = Form1.FilePath & "\graphics\background\background-102.png"
            Case 50
                path = Form1.FilePath & "\graphics\background\background-162.png"
            Case 51
                path = Form1.FilePath & "\graphics\background\background-188.png"

                gfxHeight = 128
                Animated = True
            Case 52
                path = Form1.FilePath & "\graphics\background\background-187.png"

                gfxHeight = 128
                Animated = True
            Case 53
                path = Form1.FilePath & "\graphics\background\background-189.png"

                gfxHeight = 128
                Animated = True
            Case 54
                path = Form1.FilePath & "\graphics\background\background-190.png"

                gfxHeight = 128
                Animated = True
            Case 55
                path = Form1.FilePath & "\graphics\background\background-60.png"

                gfxWidth = 128
                BGOW = 128
                gfxHeight = 128
                BGOH = 128
            Case 56
                path = Form1.FilePath & "\graphics\background\background-12.png"

                gfxWidth = 64
                BGOW = 64
                gfxHeight = 64
                BGOH = 64
            Case 57
                path = Form1.FilePath & "\graphics\background\background-61.png"
            Case 58
                path = Form1.FilePath & "\graphics\background\background-11.png"

                gfxWidth = 64
                BGOW = 64
                gfxHeight = 64
                BGOH = 64
            Case 59
                path = Form1.FilePath & "\graphics\background\background-33.png"

                gfxWidth = 64
                BGOW = 64
            Case 60
                path = Form1.FilePath & "\graphics\background\background-34.png"

                gfxWidth = 30
                BGOW = 30
                gfxHeight = 14
                BGOH = 14
            Case 61
                path = Form1.FilePath & "\graphics\background\background-13.png"

                gfxWidth = 56
                BGOW = 56
                gfxHeight = 56
                BGOH = 56
            Case 62
                path = Form1.FilePath & "\graphics\background\background-75.png"

                gfxWidth = 96
                BGOW = 96
                gfxHeight = 96
                BGOH = 96
            Case 63
                path = Form1.FilePath & "\graphics\background\background-76.png"

                gfxWidth = 64
                BGOW = 64
                gfxHeight = 64
                BGOH = 64
            Case 64
                path = Form1.FilePath & "\graphics\background\background-78.png"

                gfxWidth = 64
                BGOW = 64
                gfxHeight = 64
                BGOH = 64
            Case 65
                path = Form1.FilePath & "\graphics\background\background-77.png"

                gfxWidth = 96
                BGOW = 96
                gfxHeight = 96
                BGOH = 96
            Case 66
                path = Form1.FilePath & "\graphics\background\background-100.png"

                gfxHeight = 128
                Animated = True
            Case 67
                path = Form1.FilePath & "\graphics\background\background-107.png"

                gfxHeight = 64
                BGOH = 64
            Case 68
                path = Form1.FilePath & "\graphics\background\background-62.png"
            Case 69
                path = Form1.FilePath & "\graphics\background\background-111.png"
            Case 70
                path = Form1.FilePath & "\graphics\background\background-112.png"
            Case 71
                path = Form1.FilePath & "\graphics\background\background-113.png"
            Case 72
                path = Form1.FilePath & "\graphics\background\background-150.png"
            Case 73
                path = Form1.FilePath & "\graphics\background\background-63.png"
            Case 74
                path = Form1.FilePath & "\graphics\background\background-109.png"
            Case 75
                path = Form1.FilePath & "\graphics\background\background-108.png"
            Case 76
                path = Form1.FilePath & "\graphics\background\background-110.png"

                gfxHeight = 96
                BGOH = 96
            Case 77
                path = Form1.FilePath & "\graphics\background\background-148.png"

                gfxWidth = 64
                BGOW = 64
                gfxHeight = 64
                BGOH = 64
            Case 78
                path = Form1.FilePath & "\graphics\background\background-149.png"

                gfxWidth = 64
                BGOW = 64
                gfxHeight = 64
                BGOH = 64
            Case 79
                path = Form1.FilePath & "\graphics\background\background-159.png"

                gfxHeight = 256
                Animated = True
            Case 80
                path = Form1.FilePath & "\graphics\background\background-158.png"

                gfxHeight = 128
                Animated = True
            Case 81
                path = Form1.FilePath & "\graphics\background\background-87.png"

                gfxHeight = 64
                BGOH = 64
            Case 82
                path = Form1.FilePath & "\graphics\background\background-88.png"

                gfxHeight = 64
                BGOH = 64
            Case 83
                path = Form1.FilePath & "\graphics\background\background-23.png"
            Case 84
                path = Form1.FilePath & "\graphics\background\background-24.png"
            Case 85
                path = Form1.FilePath & "\graphics\background\background-25.png"
            Case 86
                path = Form1.FilePath & "\graphics\background\background-21.png"
            Case 87
                path = Form1.FilePath & "\graphics\background\background-86.png"
            Case 88
                path = Form1.FilePath & "\graphics\background\background-129.png"
            Case 89
                path = Form1.FilePath & "\graphics\background\background-130.png"
            Case 90
                path = Form1.FilePath & "\graphics\background\background-131.png"
            Case 91
                path = Form1.FilePath & "\graphics\background\background-22.png"
            Case 92
                path = Form1.FilePath & "\graphics\background\background-161.png"

                Animated = True

                gfxWidth = 64
                BGOW = 64
                gfxHeight = 192
                BGOH = 48
            Case 93
                path = Form1.FilePath & "\graphics\background\background-127.png"

                gfxHeight = 64
                BGOH = 64
            Case 94
                path = Form1.FilePath & "\graphics\background\background-128.png"

                gfxHeight = 96
                BGOH = 96
            Case 95
                path = Form1.FilePath & "\graphics\background\background-85.png"

                gfxHeight = 96
                BGOH = 96
            Case 96
                path = Form1.FilePath & "\graphics\background\background-84.png"

                gfxHeight = 64
                BGOH = 64
            Case 97
                path = Form1.FilePath & "\graphics\background\background-16.png"

                gfxWidth = 188
                BGOW = 188
                gfxHeight = 160
                BGOH = 160
            Case 98
                path = Form1.FilePath & "\graphics\background\background-17.png"

                gfxWidth = 316
                BGOW = 316
                gfxHeight = 352
                BGOH = 352
            Case 99
                path = Form1.FilePath & "\graphics\background\background-18.png"

                gfxHeight = 128
                gfxWidth = 128
                BGOW = 128
                Animated = True
            Case 100
                path = Form1.FilePath & "\graphics\background\background-19.png"

                gfxHeight = 128
                gfxWidth = 96
                BGOW = 96
                Animated = True
            Case 101
                path = Form1.FilePath & "\graphics\background\background-20.png"

                gfxHeight = 128
                gfxWidth = 64
                BGOW = 64
                Animated = True
            Case 102
                path = Form1.FilePath & "\graphics\background\background-147.png"
            Case 103
                path = Form1.FilePath & "\graphics\background\background-26.png"

                gfxHeight = 512
                BGOH = 64
                Animated = True
            Case 104
                path = Form1.FilePath & "\graphics\background\background-168.png"

                gfxHeight = 256
                gfxWidth = 64
                BGOW = 64
                Animated = True
            Case 105
                path = Form1.FilePath & "\graphics\background\background-164.png"
            Case 106
                path = Form1.FilePath & "\graphics\background\background-169.png"
            Case 107
                path = Form1.FilePath & "\graphics\background\background-31.png"

                gfxWidth = 288
                BGOW = 288
                gfxHeight = 160
                BGOH = 160
            Case 108
                path = Form1.FilePath & "\graphics\background\background-32.png"

                gfxWidth = 192
                BGOW = 192
                gfxHeight = 128
                BGOH = 128
            Case 109
                path = Form1.FilePath & "\graphics\background\background-27.png"

                gfxWidth = 96
                BGOW = 96
            Case 110
                path = Form1.FilePath & "\graphics\background\background-28.png"

                gfxWidth = 128
                BGOW = 128
            Case 111
                path = Form1.FilePath & "\graphics\background\background-49.png"

                BGOH = 64
                gfxHeight = 64
            Case 112
                path = Form1.FilePath & "\graphics\background\background-50.png"

                gfxHeight = 64
                BGOH = 64
            Case 113
                path = Form1.FilePath & "\graphics\background\background-51.png"

                BGOH = 64
                gfxHeight = 64
            Case 114
                path = Form1.FilePath & "\graphics\background\background-43.png"
            Case 115
                path = Form1.FilePath & "\graphics\background\background-140.png"
                gfxWidth = 576
                BGOW = 576
                gfxHeight = 192
                BGOH = 192
            Case 116
                path = Form1.FilePath & "\graphics\background\background-47.png"
                gfxWidth = 64
                BGOW = 64
                gfxHeight = 64
                BGOH = 64
            Case 117
                path = Form1.FilePath & "\graphics\background\background-48.png"

                gfxWidth = 64
                BGOW = 64
                gfxHeight = 64
                BGOH = 64
            Case 118
                path = Form1.FilePath & "\graphics\background\background-44.png"
            Case 119
                path = Form1.FilePath & "\graphics\background\background-146.png"

                gfxWidth = 576
                BGOW = 576
                gfxHeight = 192
                BGOH = 192
            Case 120
                path = Form1.FilePath & "\graphics\background\background-139.png"

                gfxWidth = 576
                BGOW = 576
                gfxHeight = 192
                BGOH = 192
            Case 121
                path = Form1.FilePath & "\graphics\background\background-74.png"
            Case 122
                path = Form1.FilePath & "\graphics\background\background-73.png"
            Case 123
                path = Form1.FilePath & "\graphics\background\background-72.png"
            Case 124
                path = Form1.FilePath & "\graphics\background\background-71.png"
            Case 125
                path = Form1.FilePath & "\graphics\background\background-70.png"

                gfxHeight = 128
                Animated = True
            Case 126
                path = Form1.FilePath & "\graphics\background\background-178.png"
            Case 127
                path = Form1.FilePath & "\graphics\background\background-179.png"
            Case 128
                path = Form1.FilePath & "\graphics\background\background-180.png"
            Case 129
                path = Form1.FilePath & "\graphics\background\background-174.png"
            Case 130
                path = Form1.FilePath & "\graphics\background\background-175.png"
            Case 131
                path = Form1.FilePath & "\graphics\background\background-181.png"
            Case 132
                path = Form1.FilePath & "\graphics\background\background-182.png"
            Case 133
                path = Form1.FilePath & "\graphics\background\background-183.png"
            Case 134
                path = Form1.FilePath & "\graphics\background\background-176.png"
            Case 135
                path = Form1.FilePath & "\graphics\background\background-177.png"
            Case 136
                path = Form1.FilePath & "\graphics\background\background-184.png"
            Case 137
                path = Form1.FilePath & "\graphics\background\background-185.png"
            Case 138
                path = Form1.FilePath & "\graphics\background\background-186.png"
            Case 139
                path = Form1.FilePath & "\graphics\background\background-54.png"

                gfxHeight = 64
                BGOH = 64
            Case 140
                path = Form1.FilePath & "\graphics\background\background-53.png"
            Case 141
                path = Form1.FilePath & "\graphics\background\background-59.png"

                gfxHeight = 64
                BGOH = 64
            Case 142
                path = Form1.FilePath & "\graphics\background\background-56.png"
                gfxWidth = 64
                BGOW = 64
                gfxHeight = 64
                BGOH = 64
            Case 143
                path = Form1.FilePath & "\graphics\background\background-58.png"
            Case 144
                path = Form1.FilePath & "\graphics\background\background-52.png"
                gfxHeight = 64
                BGOH = 64
            Case 145
                path = Form1.FilePath & "\graphics\background\background-57.png"
            Case 146
                path = Form1.FilePath & "\graphics\background\background-55.png"
            Case 147
                path = Form1.FilePath & "\graphics\background\background-30.png"

                gfxWidth = 96
                BGOW = 96
                gfxHeight = 96
                BGOH = 96
            Case 148
                path = Form1.FilePath & "\graphics\background\background-41.png"
                gfxWidth = 64
                BGOW = 64
                gfxHeight = 64
                BGOH = 64
            Case 149
                path = Form1.FilePath & "\graphics\background\background-42.png"
            Case 150
                path = Form1.FilePath & "\graphics\background\background-29.png"

                gfxWidth = 64
                BGOW = 64
                gfxHeight = 64
                BGOH = 64
            Case 151
                path = Form1.FilePath & "\graphics\background\background-132.png"
            Case 152
                path = Form1.FilePath & "\graphics\background\background-133.png"
            Case 153
                path = Form1.FilePath & "\graphics\background\background-92.png"

                gfxHeight = 64
                BGOH = 64
            Case 154
                path = Form1.FilePath & "\graphics\background\background-105.png"

                gfxHeight = 64
                BGOH = 64
            Case 155
                path = Form1.FilePath & "\graphics\background\background-141.png"
                gfxWidth = 64
                BGOW = 64
                gfxHeight = 96
                BGOH = 96
            Case 156
                path = Form1.FilePath & "\graphics\background\background-104.png"

                gfxWidth = 64
                BGOW = 64
                gfxHeight = 96
                BGOH = 96
            Case 157
                path = Form1.FilePath & "\graphics\background\background-136.png"

                gfxHeight = 128
                Animated = True
            Case 158
                path = Form1.FilePath & "\graphics\background\background-138.png"

                gfxHeight = 128
                Animated = True
            Case 159
                path = Form1.FilePath & "\graphics\background\background-142.png"
            Case 160
                path = Form1.FilePath & "\graphics\background\background-143.png"
            Case 161
                path = Form1.FilePath & "\graphics\background\background-135.png"

                gfxHeight = 128
                Animated = True
            Case 162
                path = Form1.FilePath & "\graphics\background\background-137.png"

                gfxHeight = 128
                Animated = True
            Case 163
                path = Form1.FilePath & "\graphics\background\background-134.png"

                gfxHeight = 128
                Animated = True
            Case 164
                path = Form1.FilePath & "\graphics\background\background-144.png"
            Case 165
                path = Form1.FilePath & "\graphics\background\background-145.png"
            Case 166
                path = Form1.FilePath & "\graphics\background\background-166.png"
            Case 167
                path = Form1.FilePath & "\graphics\background\background-167.png"
            Case 168
                path = Form1.FilePath & "\graphics\background\background-173.png"

                gfxWidth = 112
                BGOW = 112
                gfxHeight = 240
                BGOH = 120
                Animated = True
            Case 169
                path = Form1.FilePath & "\graphics\background\background-35.png"
            Case 170
                path = Form1.FilePath & "\graphics\background\background-122.png"
            Case 171
                path = Form1.FilePath & "\graphics\background\background-121.png"
            Case 172
                path = Form1.FilePath & "\graphics\background\background-123.png"
            Case 173
                path = Form1.FilePath & "\graphics\background\background-119.png"
            Case 174
                path = Form1.FilePath & "\graphics\background\background-118.png"
            Case 175
                path = Form1.FilePath & "\graphics\background\background-126.png"

                gfxWidth = 64
                BGOW = 64
            Case 176
                path = Form1.FilePath & "\graphics\background\background-125.png"

                gfxHeight = 128
                BGOH = 64
                Animated = True
            Case 177
                path = Form1.FilePath & "\graphics\background\background-124.png"
            Case 178
                path = Form1.FilePath & "\graphics\background\background-120.png"
            Case 179
                path = Form1.FilePath & "\graphics\background\background-115.png"
            Case 180
                path = Form1.FilePath & "\graphics\background\background-116.png"
            Case 181
                path = Form1.FilePath & "\graphics\background\background-117.png"
            Case 182
                path = Form1.FilePath & "\graphics\background\background-153.png"
            Case 183
                path = Form1.FilePath & "\graphics\background\background-155.png"

                gfxHeight = 48
                BGOH = 48
            Case 184
                path = Form1.FilePath & "\graphics\background\background-154.png"

                gfxHeight = 48
                BGOH = 48
            Case 185
                path = Form1.FilePath & "\graphics\background\background-151.png"
            Case 186
                path = Form1.FilePath & "\graphics\background\background-156.png"

                gfxHeight = 48
                BGOH = 48
            Case 187
                path = Form1.FilePath & "\graphics\background\background-157.png"

                gfxHeight = 48
                BGOH = 48
            Case 188
                path = Form1.FilePath & "\graphics\background\background-152.png"
        End Select

        TotalFrames = gfxHeight / BGOH
        LoadStream(path)

        Try
            Form2.TB = New TextureBrush(bmp)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Shared Sub LoadStream(StreamPath As String)
        Dim fs As New System.IO.FileStream(StreamPath, System.IO.FileMode.Open)

        Dim graphic As Image
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(graphic)

        fs.Close()
        fs.Dispose()
    End Sub
End Class