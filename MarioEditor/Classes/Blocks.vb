<Serializable()> Public Structure Block
    Dim rectangle As Rectangle
    Dim X As Integer
    Dim Y As Integer
    Dim Width As Integer
    Dim Height As Integer
    Dim Slip As Boolean
    Dim Invisible As Boolean
    Dim ContainItem As Integer
    Dim ID As Integer
    Dim IMG As Image
    Dim Animated As Boolean
    Dim SourceRect As Rectangle
    Dim gfxWidth As Integer
    Dim gfxHeight As Integer
    Dim TotalFrames As Integer
    Dim FrameSpeed As Integer
    Dim SizeW As Integer
    Dim SizeH As Integer
    Dim Lava As Boolean
    Dim R As Integer
    Dim G As Integer
    Dim B As Integer
    Dim Glow As Integer
    Dim Breakable As Boolean
End Structure

Public Class Blocks
    Public Shared Invisible As Boolean = False
    Public Shared Slippery As Boolean = False
    Public Shared TileW As Integer
    Public Shared TileH As Integer
    Public Shared SizeW As Integer
    Public Shared SizeH As Integer
    Public Shared gfxWidth As Integer
    Public Shared gfxHeight As Integer
    Public Shared TotalFrames As Integer
    Public Shared TileSize As Integer = 32
    Public Shared Tiles As New List(Of Block)
    Public Shared Animated As Boolean
    Public Shared Lava As Boolean
    Public Shared Hurts As Boolean
    Public Shared Sizable As Boolean
    Public Shared FrameSpeed As Integer
    Public Shared ContainItem As Integer = 100
    Public Shared TileRects As New List(Of Rectangle)
    Public Shared FillRect As Rectangle
    Public Shared FillBlocks As New List(Of Block)
    Public Shared FillRects As New List(Of Rectangle)
    Public Shared FillList As New List(Of List(Of Block))
    Public Shared IsSlope As Boolean
    Public Shared SlopeType As Integer
    Public Shared Breakable As Boolean

    Public Shared StartRect As Rectangle
    Public Shared ScanRect As Rectangle

    Public Shared path As String

    Public Shared bmp As Bitmap

    Public Shared CreateBlock As Block

    Public Shared Sub FillBlock(X As Integer, Y As Integer, Width As Integer, Height As Integer)
        Dim fill As New Block

        Dim FilledX As Boolean = False
        Dim FilledY As Boolean = False

        FillBlocks.Clear()

        StartRect = New Rectangle(X, Y, Width, Height)
        ScanRect = StartRect

        Do Until FilledX = True And FilledY = True
            If TileRects.Contains(New Rectangle(ScanRect.X + ScanRect.Width, ScanRect.Y, ScanRect.Width, ScanRect.Height)) = False Then
                ScanRect.X += Width
            Else
                ScanRect.X = StartRect.X
                ScanRect.Y += Height

                Do Until TileRects.Contains(New Rectangle(ScanRect.X - ScanRect.Width, ScanRect.Y, ScanRect.Width, ScanRect.Height))
                    ScanRect.X -= ScanRect.Width
                Loop

                If TileRects.Contains(New Rectangle(ScanRect.X - ScanRect.Width, ScanRect.Y, ScanRect.Width, ScanRect.Height)) = False Then
                    ScanRect.X = StartRect.X - ScanRect.Width
                End If

                If TileRects.Contains(ScanRect) = True Then
                    ScanRect.Y = StartRect.Y

                    FilledX = True
                    FilledY = True
                    Form2.Fill = False
                End If
            End If

            fill.Animated = Animated
            fill.ContainItem = ContainItem
            fill.FrameSpeed = FrameSpeed
            fill.gfxHeight = gfxHeight
            fill.gfxWidth = gfxWidth
            fill.Height = Height
            fill.ID = Form2.SelectedBlock
            fill.IMG = Form2.TB.Image
            fill.Invisible = Invisible
            fill.rectangle = ScanRect
            fill.SizeH = SizeH
            fill.SizeW = SizeW
            fill.Slip = Slippery
            fill.TotalFrames = TotalFrames
            fill.Width = Width
            fill.X = X
            fill.Y = Y

            FillBlocks.Add(fill)
        Loop

        FilledX = False
        FilledY = False

        Do Until FilledX = True And FilledY = True
            If TileRects.Contains(New Rectangle(ScanRect.X - ScanRect.Width, ScanRect.Y, ScanRect.Width, ScanRect.Height)) = False Then
                ScanRect.X -= Width
            Else
                ScanRect.X = StartRect.X
                ScanRect.Y -= Height

                Do Until TileRects.Contains(New Rectangle(ScanRect.X + ScanRect.Width, ScanRect.Y, ScanRect.Width, ScanRect.Height))
                    ScanRect.X += ScanRect.Width
                Loop

                If TileRects.Contains(New Rectangle(ScanRect.X - ScanRect.Width, ScanRect.Y, ScanRect.Width, ScanRect.Height)) = False Then
                    ScanRect.X = StartRect.X - ScanRect.Width
                End If

                ScanRect.X = StartRect.X

                Do Until TileRects.Contains(New Rectangle(ScanRect.X + ScanRect.Width, ScanRect.Y, ScanRect.Width, ScanRect.Height))
                    ScanRect.X += ScanRect.Width
                Loop

                If TileRects.Contains(New Rectangle(ScanRect.X + ScanRect.Width, ScanRect.Y, ScanRect.Width, ScanRect.Height)) = False Then
                    ScanRect.X = StartRect.X + ScanRect.Width
                End If

                If TileRects.Contains(ScanRect) = True Then
                    ScanRect.Y = StartRect.Y

                    FilledX = True
                    FilledY = True
                    Form2.Fill = False
                End If
            End If

            fill.Animated = Animated
            fill.ContainItem = ContainItem
            fill.FrameSpeed = FrameSpeed
            fill.gfxHeight = gfxHeight
            fill.gfxWidth = gfxWidth
            fill.Height = Height
            fill.ID = Form2.SelectedBlock
            fill.IMG = Form2.TB.Image
            fill.Invisible = Invisible
            fill.rectangle = ScanRect
            fill.SizeH = SizeH
            fill.SizeW = SizeW
            fill.Slip = Slippery
            fill.TotalFrames = TotalFrames
            fill.Width = Width
            fill.X = X
            fill.Y = Y

            FillBlocks.Add(fill)

        Loop

        For i = 0 To FillBlocks.Count - 1
            Tiles.Add(FillBlocks(i))
            TileRects.Add(FillBlocks(i).rectangle)
        Next
    End Sub

    Public Shared Sub GetBlock(ByVal bID As Integer)
        bmp = Nothing

        TileW = 32
        TileH = 32
        gfxWidth = 32
        gfxHeight = 32
        TotalFrames = 0
        Animated = False
        FrameSpeed = 8
        Lava = False
        IsSlope = False
        SlopeType = 0
        Breakable = False

        'slope type 1 = 45* angle | left face
        'slope type 2 = 45* angle | right face
        'slope type 3 = 2 tile slope | left face
        'slope type 4 = 2 tile slope | right face
        'slope type 5 = long slope | left face
        'slope type 6 = long slope | right face
        'slope 7 = upside down 45* | left face
        'slope 8 = upside down 45* | right face
        'slope 9 = upside down 2 tile | left face
        'slope 10 = upside down 2 tile | right face

        Invisible = BlocksAndTiles.CheckBox1.CheckState

        Slippery = BlocksAndTiles.CheckBox2.CheckState

        Select Case bID
            Case 1
                path = Form1.FilePath & "\graphics\block\block-7.png"
            Case 2
                path = Form1.FilePath & "\graphics\block\block-3.png"
            Case 3
                path = Form1.FilePath & "\graphics\block\block-6.png"
            Case 4
                path = Form1.FilePath & "\graphics\block\block-128.png"
            Case 5
                path = Form1.FilePath & "\graphics\block\block-127.png"
            Case 6
                path = Form1.FilePath & "\graphics\block\block-129.png"
            Case 7
                path = Form1.FilePath & "\graphics\block\block-600.png"

                IsSlope = True
                SlopeType = 1
            Case 8
                path = Form1.FilePath & "\graphics\block\block-601.png"

                IsSlope = True
                SlopeType = 2
            Case 9
                path = Form1.FilePath & "\graphics\block\block-604.png"

                gfxWidth = 64
                TileW = 64

                IsSlope = True
                SlopeType = 3
            Case 10
                path = Form1.FilePath & "\graphics\block\block-605.png"

                gfxWidth = 64
                TileW = 64

                IsSlope = True
                SlopeType = 4
            Case 11
                path = Form1.FilePath & "\graphics\block\block-15.png"
            Case 12
                path = Form1.FilePath & "\graphics\block\block-16.png"
            Case 13
                path = Form1.FilePath & "\graphics\block\block-17.png"
            Case 14
                path = Form1.FilePath & "\graphics\block\block-1.png"
            Case 15
                path = Form1.FilePath & "\graphics\block\block-92.png"

                gfxWidth = 128
                gfxHeight = 128
                TileW = 128
                TileH = 128
            Case 16
                path = Form1.FilePath & "\graphics\block\block-602.png"
            Case 17
                path = Form1.FilePath & "\graphics\block\block-603.png"
            Case 18
                path = Form1.FilePath & "\graphics\block\block-606.png"
            Case 19
                path = Form1.FilePath & "\graphics\block\block-607.png"
            Case 20
                path = Form1.FilePath & "\graphics\block\block-274.png"
            Case 21
                path = Form1.FilePath & "\graphics\block\block-276.png"
            Case 22
                path = Form1.FilePath & "\graphics\block\block-275.png"
            Case 23
                path = Form1.FilePath & "\graphics\block\block-595.png"

                gfxHeight = 64
                TileH = 64
            Case 24
                path = Form1.FilePath & "\graphics\block\block-596.png"

                TileH = 64
                gfxHeight = 64
            Case 25
                path = Form1.FilePath & "\graphics\block\block-597.png"

                gfxHeight = 64
                TileH = 64
            Case 26
                path = Form1.FilePath & "\graphics\block\block-9.png"
            Case 27
                path = Form1.FilePath & "\graphics\block\block-10.png"
            Case 28
                path = Form1.FilePath & "\graphics\block\block-11.png"
            Case 29
                path = Form1.FilePath & "\graphics\block\block-305.png"

                IsSlope = True
                SlopeType = 1
            Case 30
                path = Form1.FilePath & "\graphics\block\block-307.png"

                IsSlope = True
                SlopeType = 2
            Case 31
                path = Form1.FilePath & "\graphics\block\block-306.png"

                gfxWidth = 64
                TileW = 64

                IsSlope = True
                SlopeType = 3
            Case 32
                path = Form1.FilePath & "\graphics\block\block-308.png"

                gfxWidth = 64
                TileW = 64

                IsSlope = True
                SlopeType = 4
            Case 33
                path = Form1.FilePath & "\graphics\block\block-18.png"
            Case 34
                path = Form1.FilePath & "\graphics\block\block-19.png"
            Case 35
                path = Form1.FilePath & "\graphics\block\block-20.png"
            Case 36
                path = Form1.FilePath & "\graphics\block\block-311.png"

                IsSlope = True
                SlopeType = 6
            Case 37
                path = Form1.FilePath & "\graphics\block\block-313.png"

                IsSlope = True
                SlopeType = 7
            Case 38
                path = Form1.FilePath & "\graphics\block\block-312.png"

                gfxWidth = 64
                TileW = 64

                IsSlope = True
                SlopeType = 8
            Case 39
                path = Form1.FilePath & "\graphics\block\block-314.png"

                gfxWidth = 64
                TileW = 64

                IsSlope = True
                SlopeType = 9
            Case 40
                path = Form1.FilePath & "\graphics\block\block-279.png"
            Case 41
                path = Form1.FilePath & "\graphics\block\block-278.png"
            Case 42
                path = Form1.FilePath & "\graphics\block\block-277.png"
            Case 43
                path = Form1.FilePath & "\graphics\block\block-12.png"
            Case 44
                path = Form1.FilePath & "\graphics\block\block-13.png"
            Case 45
                path = Form1.FilePath & "\graphics\block\block-14.png"
            Case 46
                path = Form1.FilePath & "\graphics\block\block-344.png"
            Case 47
                path = Form1.FilePath & "\graphics\block\block-345.png"
            Case 48
                path = Form1.FilePath & "\graphics\block\block-346.png"
            Case 49
                path = Form1.FilePath & "\graphics\block\block-353.png"
            Case 50
                path = Form1.FilePath & "\graphics\block\block-354.png"
            Case 51
                path = Form1.FilePath & "\graphics\block\block-358.png"

                IsSlope = True
                SlopeType = 1
            Case 52
                path = Form1.FilePath & "\graphics\block\block-359.png"


                IsSlope = True
                SlopeType = 2
            Case 53
                path = Form1.FilePath & "\graphics\block\block-357.png"

                gfxWidth = 64
                TileW = 64

                IsSlope = True
                SlopeType = 3
            Case 54
                path = Form1.FilePath & "\graphics\block\block-360.png"

                gfxWidth = 64
                TileW = 64

                IsSlope = True
                SlopeType = 4
            Case 55
                path = Form1.FilePath & "\graphics\block\block-347.png"
            Case 56
                path = Form1.FilePath & "\graphics\block\block-348.png"
            Case 57
                path = Form1.FilePath & "\graphics\block\block-349.png"
            Case 58
                path = Form1.FilePath & "\graphics\block\block-355.png"
            Case 59
                path = Form1.FilePath & "\graphics\block\block-356.png"
            Case 60
                path = Form1.FilePath & "\graphics\block\block-362.png"

                IsSlope = True
                SlopeType = 6
            Case 61
                path = Form1.FilePath & "\graphics\block\block-363.png"

                IsSlope = True
                SlopeType = 7
            Case 62
                path = Form1.FilePath & "\graphics\block\block-361.png"

                gfxWidth = 64
                TileW = 64

                IsSlope = True
                SlopeType = 8
            Case 63
                path = Form1.FilePath & "\graphics\block\block-364.png"

                gfxWidth = 64
                TileW = 64

                IsSlope = True
                SlopeType = 9
            Case 64
                path = Form1.FilePath & "\graphics\block\block-350.png"
            Case 65
                path = Form1.FilePath & "\graphics\block\block-351.png"
            Case 66
                path = Form1.FilePath & "\graphics\block\block-352.png"
            Case 67
                path = Form1.FilePath & "\graphics\block\block-94.png"
            Case 68
                path = Form1.FilePath & "\graphics\block\block-95.png"
            Case 69
                path = Form1.FilePath & "\graphics\block\block-96.png"
            Case 70
                path = Form1.FilePath & "\graphics\block\block-162.png"
            Case 71
                path = Form1.FilePath & "\graphics\block\block-163.png"
            Case 72
                path = Form1.FilePath & "\graphics\block\block-164.png"
            Case 73
                path = Form1.FilePath & "\graphics\block\block-635.png"

                IsSlope = True
                SlopeType = 1
            Case 74
                path = Form1.FilePath & "\graphics\block\block-637.png"

                IsSlope = True
                SlopeType = 2
            Case 75
                path = Form1.FilePath & "\graphics\block\block-97.png"
            Case 76
                path = Form1.FilePath & "\graphics\block\block-98.png"
            Case 77
                path = Form1.FilePath & "\graphics\block\block-99.png"
            Case 78
                path = Form1.FilePath & "\graphics\block\block-165.png"
            Case 79
                path = Form1.FilePath & "\graphics\block\block-166.png"
            Case 80
                path = Form1.FilePath & "\graphics\block\block-167.png"
            Case 81
                path = Form1.FilePath & "\graphics\block\block-636.png"

                gfxWidth = 64
                TileW = 64

                IsSlope = True
                SlopeType = 3
            Case 82
                path = Form1.FilePath & "\graphics\block\block-638.png"

                gfxWidth = 64
                TileW = 64

                IsSlope = True
                SlopeType = 4
            Case 83
                path = Form1.FilePath & "\graphics\block\block-100.png"
            Case 84
                path = Form1.FilePath & "\graphics\block\block-101.png"
            Case 85
                path = Form1.FilePath & "\graphics\block\block-102.png"
            Case 86
                path = Form1.FilePath & "\graphics\block\block-286.png"
            Case 87
                path = Form1.FilePath & "\graphics\block\block-285.png"
            Case 88
                path = Form1.FilePath & "\graphics\block\block-284.png"
            Case 89
                path = Form1.FilePath & "\graphics\block\block-183.png"
            Case 90
                path = Form1.FilePath & "\graphics\block\block-49.png"
            Case 91
                path = Form1.FilePath & "\graphics\block\block-52.png"
            Case 92
                path = Form1.FilePath & "\graphics\block\block-610.png"
            Case 93
                path = Form1.FilePath & "\graphics\block\block-50.png"
            Case 94
                path = Form1.FilePath & "\graphics\block\block-54.png"
            Case 95
                path = Form1.FilePath & "\graphics\block\block-47.png"
            Case 96
                path = Form1.FilePath & "\graphics\block\block-611.png"
            Case 97
                path = Form1.FilePath & "\graphics\block\block-612.png"
            Case 98
                path = Form1.FilePath & "\graphics\block\block-608.png"
            Case 99
                path = Form1.FilePath & "\graphics\block\block-48.png"
            Case 100
                path = Form1.FilePath & "\graphics\block\block-609.png"
            Case 101
                path = Form1.FilePath & "\graphics\block\block-51.png"
            Case 102
                path = Form1.FilePath & "\graphics\block\block-53.png"
            Case 103
                path = Form1.FilePath & "\graphics\block\block-219.png"
            Case 104
                path = Form1.FilePath & "\graphics\block\block-220.png"
            Case 105
                path = Form1.FilePath & "\graphics\block\block-221.png"
            Case 106
                path = Form1.FilePath & "\graphics\block\block-222.png"
            Case 107
                path = Form1.FilePath & "\graphics\block\block-217.png"
            Case 108
                path = Form1.FilePath & "\graphics\block\block-218.png"
            Case 109
                path = Form1.FilePath & "\graphics\block\block-29.png"
            Case 110
                path = Form1.FilePath & "\graphics\block\block-91.png"

                TileW = 64
                TileH = 64
                gfxWidth = 64
                gfxHeight = 64
            Case 111
                path = Form1.FilePath & "\graphics\block\block-126.png"
            Case 112
                path = Form1.FilePath & "\graphics\block\block-630.png"
            Case 113
                path = Form1.FilePath & "\graphics\block\block-136.png"
            Case 114
                path = Form1.FilePath & "\graphics\block\block-580.png"
            Case 115
                path = Form1.FilePath & "\graphics\block\block-581.png"
            Case 116
                path = Form1.FilePath & "\graphics\block\block-582.png"
            Case 117
                path = Form1.FilePath & "\graphics\block\block-586.png"
            Case 118
                path = Form1.FilePath & "\graphics\block\block-587.png"
            Case 119
                path = Form1.FilePath & "\graphics\block\block-588.png"
            Case 120
                path = Form1.FilePath & "\graphics\block\block-583.png"
            Case 121
                path = Form1.FilePath & "\graphics\block\block-584.png"
            Case 122
                path = Form1.FilePath & "\graphics\block\block-585.png"
            Case 123
                path = Form1.FilePath & "\graphics\block\block-589.png"
            Case 124
                path = Form1.FilePath & "\graphics\block\block-590.png"
            Case 125
                path = Form1.FilePath & "\graphics\block\block-591.png"
            Case 126
                path = Form1.FilePath & "\graphics\block\block-598.png"

                gfxHeight = 128
                Hurts = True
                Animated = True
            Case 127
                path = Form1.FilePath & "\graphics\block\block-578.png"
            Case 128
                path = Form1.FilePath & "\graphics\block\block-599.png"

                gfxWidth = 64
                TileW = 64
                gfxHeight = 64
                TileH = 64
            Case 129
                path = Form1.FilePath & "\graphics\block\block-592.png"
            Case 130
                path = Form1.FilePath & "\graphics\block\block-593.png"
            Case 131
                path = Form1.FilePath & "\graphics\block\block-594.png"
            Case 132
                path = Form1.FilePath & "\graphics\block\block-270.png"

                Slippery = True
            Case 133
                path = Form1.FilePath & "\graphics\block\block-272.png"

                Slippery = True
            Case 134
                path = Form1.FilePath & "\graphics\block\block-271.png"

                Slippery = True
            Case 135
                path = Form1.FilePath & "\graphics\block\block-633.png"
            Case 136
                path = Form1.FilePath & "\graphics\block\block-634.png"

                gfxWidth = 64
                TileW = 64
                gfxHeight = 64
                TileH = 64
            Case 137
                path = Form1.FilePath & "\graphics\block\block-73.png"
            Case 138
                path = Form1.FilePath & "\graphics\block\block-70.png"
            Case 139
                path = Form1.FilePath & "\graphics\block\block-71.png"
            Case 140
                path = Form1.FilePath & "\graphics\block\block-72.png"
            Case 141
                path = Form1.FilePath & "\graphics\block\block-74.png"
            Case 142
                path = Form1.FilePath & "\graphics\block\block-78.png"

                gfxWidth = 64
                TileW = 64
            Case 143
                path = Form1.FilePath & "\graphics\block\block-77.png"
            Case 144
                path = Form1.FilePath & "\graphics\block\block-185.png"

                gfxWidth = 128
                TileW = 128
            Case 145
                path = Form1.FilePath & "\graphics\block\block-75.png"
            Case 146
                path = Form1.FilePath & "\graphics\block\block-613.png"

                gfxWidth = 64
                TileW = 64
            Case 147
                path = Form1.FilePath & "\graphics\block\block-614.png"
            Case 148
                path = Form1.FilePath & "\graphics\block\block-76.png"
            Case 149
                path = Form1.FilePath & "\graphics\block\block-110.png"

                Hurts = True
            Case 150
                path = Form1.FilePath & "\graphics\block\block-30.png"

                gfxHeight = 128
                Lava = True
                Animated = True
            Case 151
                path = Form1.FilePath & "\graphics\block\block-109.png"

                gfxHeight = 256
                Hurts = True
                Animated = True
            Case 152
                path = Form1.FilePath & "\graphics\block\block-268.png"

                Hurts = True
            Case 153
                path = Form1.FilePath & "\graphics\block\block-406.png"

                Lava = True
            Case 154
                path = Form1.FilePath & "\graphics\block\block-269.png"

                Hurts = True
            Case 155
                path = Form1.FilePath & "\graphics\block\block-267.png"

                Hurts = True
            Case 156
                path = Form1.FilePath & "\graphics\block\block-21.png"

                gfxWidth = 64
                TileW = 64
            Case 157
                path = Form1.FilePath & "\graphics\block\block-34.png"

                gfxWidth = 64
                TileW = 64
            Case 158
                path = Form1.FilePath & "\graphics\block\block-36.png"

                gfxWidth = 64
                TileW = 64
            Case 159
                path = Form1.FilePath & "\graphics\block\block-103.png"

                gfxWidth = 64
                TileW = 64
            Case 160
                path = Form1.FilePath & "\graphics\block\block-23.png"

                gfxHeight = 64
                TileH = 64
            Case 161
                path = Form1.FilePath & "\graphics\block\block-24.png"

                gfxHeight = 64
                TileH = 64
            Case 162
                path = Form1.FilePath & "\graphics\block\block-22.png"

                gfxWidth = 64
                TileW = 64
            Case 163
                path = Form1.FilePath & "\graphics\block\block-35.png"

                gfxWidth = 64
                TileW = 64
            Case 164
                path = Form1.FilePath & "\graphics\block\block-37.png"

                gfxWidth = 64
                TileW = 64
            Case 165
                path = Form1.FilePath & "\graphics\block\block-104.png"

                gfxWidth = 64
                TileW = 64
            Case 166
                path = Form1.FilePath & "\graphics\block\block-295.png"
            Case 167
                path = Form1.FilePath & "\graphics\block\block-294.png"
            Case 168
                path = Form1.FilePath & "\graphics\block\block-571.png"

                gfxWidth = 64
                TileW = 64
                gfxHeight = 64
                TileH = 64
            Case 169
                path = Form1.FilePath & "\graphics\block\block-31.png"
            Case 170
                path = Form1.FilePath & "\graphics\block\block-32.png"
            Case 171
                path = Form1.FilePath & "\graphics\block\block-33.png"
            Case 172
                path = Form1.FilePath & "\graphics\block\block-182.png"

                gfxWidth = 96
                TileW = 96
                gfxHeight = 96
                TileH = 96
            Case 173
                path = Form1.FilePath & "\graphics\block\block-296.png"
            Case 174
                path = Form1.FilePath & "\graphics\block\block-569.png"

                gfxHeight = 64
                TileH = 64
            Case 175
                path = Form1.FilePath & "\graphics\block\block-570.png"

                gfxHeight = 64
                TileH = 64
            Case 176
                path = Form1.FilePath & "\graphics\block\block-25.png"

                gfxWidth = (SizeW * 32) + 32
                TileW = (SizeW * 32) + 32
                gfxHeight = (SizeH * 32) + 32
                TileH = (SizeH * 32) + 32
                Sizable = True
            Case 177
                path = Form1.FilePath & "\graphics\block\block-26.png"

                gfxWidth = (SizeW * 32) + 32
                TileW = (SizeW * 32) + 32
                gfxHeight = (SizeH * 32) + 32
                TileH = (SizeH * 32) + 32
                Sizable = True
            Case 178
                path = Form1.FilePath & "\graphics\block\block-240.png"

                gfxWidth = (SizeW * 32) + 32
                TileW = (SizeW * 32) + 32
                gfxHeight = (SizeH * 32) + 32
                TileH = (SizeH * 32) + 32
                Sizable = True
            Case 179
                path = Form1.FilePath & "\graphics\block\block-575.png"

                gfxWidth = (SizeW * 32) + 32
                TileW = (SizeW * 32) + 32
                gfxHeight = (SizeH * 32) + 32
                TileH = (SizeH * 32) + 32
                Sizable = True
            Case 180
                path = Form1.FilePath & "\graphics\block\block-27.png"

                gfxWidth = (SizeW * 32) + 32
                TileW = (SizeW * 32) + 32
                gfxHeight = (SizeH * 32) + 32
                TileH = (SizeH * 32) + 32
                Sizable = True
            Case 181
                path = Form1.FilePath & "\graphics\block\block-28.png"

                gfxWidth = (SizeW * 32) + 32
                TileW = (SizeW * 32) + 32
                gfxHeight = (SizeH * 32) + 32
                TileH = (SizeH * 32) + 32
                Sizable = True
            Case 182
                path = Form1.FilePath & "\graphics\block\block-241.png"

                gfxWidth = (SizeW * 32) + 32
                TileW = (SizeW * 32) + 32
                gfxHeight = (SizeH * 32) + 32
                TileH = (SizeH * 32) + 32
                Sizable = True
            Case 183
                path = Form1.FilePath & "\graphics\block\block-568.png"

                gfxWidth = (SizeW * 32) + 32
                TileW = (SizeW * 32) + 32
                gfxHeight = (SizeH * 32) + 32
                TileH = (SizeH * 32) + 32
                Sizable = True
            Case 184
                path = Form1.FilePath & "\graphics\block\block-108.png"

                gfxWidth = (SizeW * 32) + 32
                TileW = (SizeW * 32) + 32
                gfxHeight = (SizeH * 32) + 32
                TileH = (SizeH * 32) + 32
                Sizable = True
            Case 185
                path = Form1.FilePath & "\graphics\block\block-130.png"

                gfxWidth = (SizeW * 32) + 32
                TileW = (SizeW * 32) + 32
                gfxHeight = (SizeH * 32) + 32
                TileH = (SizeH * 32) + 32
                Sizable = True
            Case 186
                path = Form1.FilePath & "\graphics\block\block-260.png"

                gfxWidth = (SizeW * 32) + 32
                TileW = (SizeW * 32) + 32
                gfxHeight = (SizeH * 32) + 32
                TileH = (SizeH * 32) + 32
                Sizable = True
            Case 187
                path = Form1.FilePath & "\graphics\block\block-579.png"

                gfxWidth = (SizeW * 32) + 32
                TileW = (SizeW * 32) + 32
                gfxHeight = (SizeH * 32) + 32
                TileH = (SizeH * 32) + 32
                Sizable = True
            Case 188
                path = Form1.FilePath & "\graphics\block\block-8.png"
            Case 189
                path = Form1.FilePath & "\graphics\block\block-280.png"
            Case 190
                path = Form1.FilePath & "\graphics\block\block-187.png"

                gfxWidth = 128
                TileW = 128
                gfxHeight = 128
                TileH = 128
            Case 191
                path = Form1.FilePath & "\graphics\block\block-112.png"
            Case 192
                'invisble
                path = Form1.FilePath & "\graphics\block\block-458.png"
            Case 193
                path = Form1.FilePath & "\graphics\block\block-132.png"
            Case 194
                path = Form1.FilePath & "\graphics\block\block-290.png"
            Case 195
                path = Form1.FilePath & "\graphics\block\block-107.png"
            Case 196
                path = Form1.FilePath & "\graphics\block\block-289.png"
            Case 197
                path = Form1.FilePath & "\graphics\block\block-111.png"
            Case 198
                path = Form1.FilePath & "\graphics\block\block-160.png"
            Case 199
                path = Form1.FilePath & "\graphics\block\block-457.png"
            Case 200
                path = Form1.FilePath & "\graphics\block\block-106.png"
            Case 201
                path = Form1.FilePath & "\graphics\block\block-105.png"
            Case 202
                path = Form1.FilePath & "\graphics\block\block-168.png"
            Case 203
                path = Form1.FilePath & "\graphics\block\block-184.png"

                gfxWidth = 64
                TileW = 64
                gfxHeight = 64
                TileH = 64
            Case 204
                path = Form1.FilePath & "\graphics\block\block-223.png"
            Case 205
                path = Form1.FilePath & "\graphics\block\block-572.png"

                gfxWidth = 64
                TileW = 64
                gfxHeight = 64
                TileH = 64
            Case 206
                path = Form1.FilePath & "\graphics\block\block-5.png"

                gfxHeight = 128
                Animated = True
            Case 207
                path = Form1.FilePath & "\graphics\block\block-2.png"
            Case 208
                path = Form1.FilePath & "\graphics\block\block-4.png"

                gfxHeight = 128
                Animated = True
                Breakable = True
            Case 209
                path = Form1.FilePath & "\graphics\block\block-621.png"
            Case 210
                path = Form1.FilePath & "\graphics\block\block-224.png"

                gfxWidth = 64
                TileW = 64
                gfxHeight = 64
                TileH = 64
            Case 211
                path = Form1.FilePath & "\graphics\block\block-225.png"

                gfxWidth = 64
                TileW = 64
                gfxHeight = 64
                TileH = 64
            Case 212
                path = Form1.FilePath & "\graphics\block\block-226.png"

                gfxWidth = 64
                TileW = 64
                gfxHeight = 64
                TileH = 64
            Case 213
                path = Form1.FilePath & "\graphics\block\block-620.png"
            Case 214
                path = Form1.FilePath & "\graphics\block\block-55.png"

                gfxHeight = 128
                Animated = True
            Case 215
                path = Form1.FilePath & "\graphics\block\block-186.png"
            Case 216
                path = Form1.FilePath & "\graphics\block\block-159.png"
            Case 217
                path = Form1.FilePath & "\graphics\block\block-39.png"
            Case 218
                path = Form1.FilePath & "\graphics\block\block-40.png"
            Case 219
                path = Form1.FilePath & "\graphics\block\block-41.png"
            Case 220
                path = Form1.FilePath & "\graphics\block\block-45.png"
            Case 221
                path = Form1.FilePath & "\graphics\block\block-340.png"

                gfxWidth = 64
                TileW = 64

                IsSlope = True
                SlopeType = 3
            Case 222
                path = Form1.FilePath & "\graphics\block\block-342.png"

                gfxWidth = 64
                TileW = 64

                IsSlope = True
                SlopeType = 4
            Case 223
                path = Form1.FilePath & "\graphics\block\block-341.png"

                IsSlope = True
                SlopeType = 1
            Case 224
                path = Form1.FilePath & "\graphics\block\block-343.png"

                IsSlope = True
                SlopeType = 2
            Case 225
                path = Form1.FilePath & "\graphics\block\block-198.png"
            Case 226
                path = Form1.FilePath & "\graphics\block\block-200.png"
            Case 227
                path = Form1.FilePath & "\graphics\block\block-199.png"
            Case 228
                path = Form1.FilePath & "\graphics\block\block-46.png"
            Case 229
                path = Form1.FilePath & "\graphics\block\block-336.png"

                gfxWidth = 64
                TileW = 64
            Case 230
                path = Form1.FilePath & "\graphics\block\block-338.png"

                gfxWidth = 64
                TileW = 64
            Case 231
                path = Form1.FilePath & "\graphics\block\block-337.png"
            Case 232
                path = Form1.FilePath & "\graphics\block\block-339.png"
            Case 233
                path = Form1.FilePath & "\graphics\block\block-42.png"
            Case 234
                path = Form1.FilePath & "\graphics\block\block-43.png"
            Case 235
                path = Form1.FilePath & "\graphics\block\block-44.png"
            Case 236
                path = Form1.FilePath & "\graphics\block\block-207.png"
            Case 237
                path = Form1.FilePath & "\graphics\block\block-201.png"
            Case 238
                path = Form1.FilePath & "\graphics\block\block-208.png"
            Case 239
                path = Form1.FilePath & "\graphics\block\block-211.png"

                gfxHeight = 64
                TileH = 64
            Case 240
                path = Form1.FilePath & "\graphics\block\block-212.png"

                gfxHeight = 64
                TileH = 64
            Case 241
                path = Form1.FilePath & "\graphics\block\block-203.png"
            Case 242
                path = Form1.FilePath & "\graphics\block\block-205.png"
            Case 243
                path = Form1.FilePath & "\graphics\block\block-204.png"
            Case 244
                path = Form1.FilePath & "\graphics\block\block-216.png"
            Case 245
                path = Form1.FilePath & "\graphics\block\block-214.png"
            Case 246
                path = Form1.FilePath & "\graphics\block\block-213.png"

                gfxHeight = 64
                TileH = 64
            Case 247
                path = Form1.FilePath & "\graphics\block\block-215.png"
            Case 248
                path = Form1.FilePath & "\graphics\block\block-206.png"

                gfxWidth = 64
                TileW = 64
                gfxHeight = 64
                TileH = 64
            Case 249
                path = Form1.FilePath & "\graphics\block\block-38.png"

                gfxWidth = (SizeW * 32) + 32
                TileW = (SizeW * 32) + 32
                gfxHeight = (SizeH * 32) + 32
                TileH = (SizeH * 32) + 32
                Sizable = True
            Case 250
                path = Form1.FilePath & "\graphics\block\block-242.png"

                gfxWidth = (SizeW * 32) + 32
                TileW = (SizeW * 32) + 32
                gfxHeight = (SizeH * 32) + 32
                TileH = (SizeH * 32) + 32
                Sizable = True
            Case 251
                path = Form1.FilePath & "\graphics\block\block-243.png"

                gfxWidth = (SizeW * 32) + 32
                TileW = (SizeW * 32) + 32
                gfxHeight = (SizeH * 32) + 32
                TileH = (SizeH * 32) + 32
                Sizable = True
            Case 252
                path = Form1.FilePath & "\graphics\block\block-288.png"

                gfxWidth = (SizeW * 32) + 32
                TileW = (SizeW * 32) + 32
                gfxHeight = (SizeH * 32) + 32
                TileH = (SizeH * 32) + 32
                Sizable = True
            Case 253
                path = Form1.FilePath & "\graphics\block\block-293.png"
            Case 254
                path = Form1.FilePath & "\graphics\block\block-370.png"
            Case 255
                path = Form1.FilePath & "\graphics\block\block-209.png"
            Case 256
                path = Form1.FilePath & "\graphics\block\block-391.png"

                gfxHeight = 128
                Animated = True
            Case 257
                path = Form1.FilePath & "\graphics\block\block-392.png"

                gfxHeight = 128
                Animated = True
            Case 258
                path = Form1.FilePath & "\graphics\block\block-389.png"

                gfxHeight = 128
                Animated = True
            Case 259
                path = Form1.FilePath & "\graphics\block\block-573.png"
            Case 260
                path = Form1.FilePath & "\graphics\block\block-202.png"
            Case 261
                path = Form1.FilePath & "\graphics\block\block-297.png"
            Case 262
                path = Form1.FilePath & "\graphics\block\block-131.png"
            Case 263
                path = Form1.FilePath & "\graphics\block\block-505.png"

                gfxWidth = 64
                TileW = 64
            Case 264
                path = Form1.FilePath & "\graphics\block\block-574.png"
            Case 265
                path = Form1.FilePath & "\graphics\block\block-210.png"
            Case 266
                path = Form1.FilePath & "\graphics\block\block-298.png"
            Case 267
                path = Form1.FilePath & "\graphics\block\block-509.png"
            Case 268
                path = Form1.FilePath & "\graphics\block\block-492.png"
            Case 269
                path = Form1.FilePath & "\graphics\block\block-496.png"
            Case 270
                path = Form1.FilePath & "\graphics\block\block-501.png"
            Case 271
                path = Form1.FilePath & "\graphics\block\block-500.png"
            Case 272
                path = Form1.FilePath & "\graphics\block\block-493.png"
            Case 273
                path = Form1.FilePath & "\graphics\block\block-490.png"
            Case 274
                path = Form1.FilePath & "\graphics\block\block-499.png"
            Case 275
                path = Form1.FilePath & "\graphics\block\block-495.png"
            Case 276
                path = Form1.FilePath & "\graphics\block\block-503.png"
            Case 277
                path = Form1.FilePath & "\graphics\block\block-497.png"
            Case 278
                path = Form1.FilePath & "\graphics\block\block-494.png"
            Case 279
                path = Form1.FilePath & "\graphics\block\block-498.png"
            Case 280
                path = Form1.FilePath & "\graphics\block\block-511.png"

                gfxHeight = 128
                Animated = True
            Case 281
                path = Form1.FilePath & "\graphics\block\block-507.png"

                gfxWidth = 64
                TileW = 64
            Case 282
                path = Form1.FilePath & "\graphics\block\block-506.png"

                gfxWidth = 64
                TileW = 64
                gfxHeight = 64
                TileH = 64
            Case 283
                path = Form1.FilePath & "\graphics\block\block-508.png"

                gfxWidth = 64
                TileW = 64
            Case 284
                path = Form1.FilePath & "\graphics\block\block-491.png"
            Case 285
                path = Form1.FilePath & "\graphics\block\block-502.png"
            Case 286
                path = Form1.FilePath & "\graphics\block\block-504.png"
            Case 287
                path = Form1.FilePath & "\graphics\block\block-510.png"
            Case 288
                path = Form1.FilePath & "\graphics\block\block-62.png"
            Case 289
                path = Form1.FilePath & "\graphics\block\block-63.png"
            Case 290
                path = Form1.FilePath & "\graphics\block\block-64.png"
            Case 291
                path = Form1.FilePath & "\graphics\block\block-332.png"

                IsSlope = True
                SlopeType = 1
            Case 292
                path = Form1.FilePath & "\graphics\block\block-333.png"

                IsSlope = True
                SlopeType = 2
            Case 293
                path = Form1.FilePath & "\graphics\block\block-93.png"

                gfxWidth = 128
                TileW = 128
                gfxHeight = 128
                TileH = 128
            Case 294
                path = Form1.FilePath & "\graphics\block\block-189.png"
            Case 295
                path = Form1.FilePath & "\graphics\block\block-190.png"
            Case 296
                path = Form1.FilePath & "\graphics\block\block-191.png"
            Case 297
                path = Form1.FilePath & "\graphics\block\block-335.png"

                IsSlope = True
                SlopeType = 7
            Case 298
                path = Form1.FilePath & "\graphics\block\block-334.png"

                IsSlope = True
                SlopeType = 8
            Case 299
                path = Form1.FilePath & "\graphics\block\block-65.png"
            Case 300
                path = Form1.FilePath & "\graphics\block\block-56.png"
            Case 301
                path = Form1.FilePath & "\graphics\block\block-57.png"
            Case 302
                path = Form1.FilePath & "\graphics\block\block-58.png"
            Case 303
                path = Form1.FilePath & "\graphics\block\block-326.png"

                IsSlope = True
                SlopeType = 1
            Case 304
                path = Form1.FilePath & "\graphics\block\block-327.png"

                IsSlope = True
                SlopeType = 2
            Case 305
                path = Form1.FilePath & "\graphics\block\block-61.png"

                gfxWidth = 128
                TileW = 128
                gfxHeight = 128
                TileH = 128
            Case 306
                path = Form1.FilePath & "\graphics\block\block-331.png"
            Case 307
                path = Form1.FilePath & "\graphics\block\block-323.png"
            Case 308
                path = Form1.FilePath & "\graphics\block\block-330.png"
            Case 309
                path = Form1.FilePath & "\graphics\block\block-329.png"

                IsSlope = True
                SlopeType = 7
            Case 310
                path = Form1.FilePath & "\graphics\block\block-328.png"

                IsSlope = True
                SlopeType = 8
            Case 311
                path = Form1.FilePath & "\graphics\block\block-59.png"
            Case 312
                path = Form1.FilePath & "\graphics\block\block-324.png"

                gfxWidth = 64
                TileW = 64

                IsSlope = True
                SlopeType = 3
            Case 313
                path = Form1.FilePath & "\graphics\block\block-325.png"

                gfxWidth = 64
                TileW = 64

                IsSlope = True
                SlopeType = 4
            Case 314
                path = Form1.FilePath & "\graphics\block\block-287.png"

                gfxWidth = (SizeW * 32) + 32
                TileW = (SizeW * 32) + 32
                gfxHeight = (SizeH * 32) + 32
                TileH = (SizeH * 32) + 32
                Sizable = True
            Case 315
                path = Form1.FilePath & "\graphics\block\block-193.png"

                gfxHeight = 128
                Animated = True
            Case 316
                path = Form1.FilePath & "\graphics\block\block-192.png"
            Case 317
                path = Form1.FilePath & "\graphics\block\block-188.png"
            Case 318
                path = Form1.FilePath & "\graphics\block\block-60.png"
            Case 319
                path = Form1.FilePath & "\graphics\block\block-66.png"
            Case 320
                path = Form1.FilePath & "\graphics\block\block-67.png"
            Case 321
                path = Form1.FilePath & "\graphics\block\block-68.png"
            Case 322
                path = Form1.FilePath & "\graphics\block\block-69.png"
            Case 323
                path = Form1.FilePath & "\graphics\block\block-369.png"
            Case 324
                path = Form1.FilePath & "\graphics\block\block-388.png"
            Case 325
                path = Form1.FilePath & "\graphics\block\block-576.png"
            Case 326
                path = Form1.FilePath & "\graphics\block\block-577.png"
            Case 327
                path = Form1.FilePath & "\graphics\block\block-194.png"

                gfxWidth = 64
                TileW = 64
            Case 328
                path = Form1.FilePath & "\graphics\block\block-196.png"

                gfxWidth = 64
                TileW = 64
            Case 329
                path = Form1.FilePath & "\graphics\block\block-195.png"

                gfxWidth = 64
                TileW = 64
            Case 330
                path = Form1.FilePath & "\graphics\block\block-197.png"

                gfxWidth = 64
                TileW = 64
            Case 331
                path = Form1.FilePath & "\graphics\block\block-376.png"

                gfxHeight = 64
                TileH = 64
            Case 332
                path = Form1.FilePath & "\graphics\block\block-377.png"

                gfxHeight = 64
                TileH = 64
            Case 333
                path = Form1.FilePath & "\graphics\block\block-378.png"

                gfxWidth = 64
                TileW = 64
                gfxHeight = 64
                TileH = 64
            Case 334
                path = Form1.FilePath & "\graphics\block\block-396.png"
            Case 335
                path = Form1.FilePath & "\graphics\block\block-387.png"
            Case 336
                path = Form1.FilePath & "\graphics\block\block-402.png"
            Case 337
                path = Form1.FilePath & "\graphics\block\block-385.png"
            Case 338
                path = Form1.FilePath & "\graphics\block\block-403.png"
            Case 339
                path = Form1.FilePath & "\graphics\block\block-371.png"

                gfxHeight = 256
                Animated = True
            Case 340
                path = Form1.FilePath & "\graphics\block\block-401.png"
            Case 341
                path = Form1.FilePath & "\graphics\block\block-395.png"
            Case 342
                path = Form1.FilePath & "\graphics\block\block-394.png"
            Case 343
                path = Form1.FilePath & "\graphics\block\block-393.png"
            Case 344
                path = Form1.FilePath & "\graphics\block\block-384.png"
            Case 345
                path = Form1.FilePath & "\graphics\block\block-383.png"
            Case 346
                path = Form1.FilePath & "\graphics\block\block-405.png"
            Case 347
                path = Form1.FilePath & "\graphics\block\block-386.png"
            Case 348
                path = Form1.FilePath & "\graphics\block\block-397.png"
            Case 349
                path = Form1.FilePath & "\graphics\block\block-390.png"
            Case 350
                path = Form1.FilePath & "\graphics\block\block-399.png"
            Case 351
                path = Form1.FilePath & "\graphics\block\block-398.png"
            Case 352
                path = Form1.FilePath & "\graphics\block\block-400.png"
            Case 353
                path = Form1.FilePath & "\graphics\block\block-373.png"
            Case 354
                path = Form1.FilePath & "\graphics\block\block-374.png"
            Case 355
                path = Form1.FilePath & "\graphics\block\block-375.png"
            Case 356
                path = Form1.FilePath & "\graphics\block\block-372.png"
            Case 357
                path = Form1.FilePath & "\graphics\block\block-379.png"

                gfxHeight = 128
                Animated = True
            Case 358
                path = Form1.FilePath & "\graphics\block\block-380.png"

                gfxHeight = 128
                Animated = True
            Case 359
                path = Form1.FilePath & "\graphics\block\block-381.png"

                gfxHeight = 128
                Animated = True
            Case 360
                path = Form1.FilePath & "\graphics\block\block-382.png"

                gfxHeight = 128
                Animated = True
            Case 361
                path = Form1.FilePath & "\graphics\block\block-80.png"
            Case 362
                path = Form1.FilePath & "\graphics\block\block-81.png"
            Case 363
                path = Form1.FilePath & "\graphics\block\block-82.png"
            Case 364
                path = Form1.FilePath & "\graphics\block\block-273.png"
            Case 365
                path = Form1.FilePath & "\graphics\block\block-263.png"
            Case 366
                path = Form1.FilePath & "\graphics\block\block-299.png"

                IsSlope = True
                SlopeType = 1
            Case 367
                path = Form1.FilePath & "\graphics\block\block-300.png"

                IsSlope = True
                SlopeType = 2
            Case 368
                path = Form1.FilePath & "\graphics\block\block-302.png"

                gfxWidth = 128
                TileW = 128

                IsSlope = True
                SlopeType = 5
            Case 369
                path = Form1.FilePath & "\graphics\block\block-301.png"

                gfxWidth = 128
                TileW = 128

                IsSlope = True
                SlopeType = 6
            Case 370
                path = Form1.FilePath & "\graphics\block\block-83.png"
            Case 371
                path = Form1.FilePath & "\graphics\block\block-87.png"
            Case 372
                path = Form1.FilePath & "\graphics\block\block-84.png"
            Case 373
                path = Form1.FilePath & "\graphics\block\block-85.png"
            Case 374
                path = Form1.FilePath & "\graphics\block\block-86.png"
            Case 375
                path = Form1.FilePath & "\graphics\block\block-309.png"

                IsSlope = True
                SlopeType = 7
            Case 376
                path = Form1.FilePath & "\graphics\block\block-310.png"

                IsSlope = True
                SlopeType = 8
            Case 377
                path = Form1.FilePath & "\graphics\block\block-304.png"

                gfxWidth = 128
                TileW = 128
            Case 378
                path = Form1.FilePath & "\graphics\block\block-303.png"

                gfxWidth = 128
                TileW = 128
            Case 379
                path = Form1.FilePath & "\graphics\block\block-265.png"
            Case 380
                path = Form1.FilePath & "\graphics\block\block-264.png"
            Case 381
                path = Form1.FilePath & "\graphics\block\block-266.png"
            Case 382
                path = Form1.FilePath & "\graphics\block\block-488.png"
            Case 383
                path = Form1.FilePath & "\graphics\block\block-489.png"
            Case 384
                path = Form1.FilePath & "\graphics\block\block-616.png"

                gfxWidth = 64
                TileW = 64

                IsSlope = True
                SlopeType = 3
            Case 385
                path = Form1.FilePath & "\graphics\block\block-617.png"

                gfxWidth = 64
                TileW = 64

                IsSlope = True
                SlopeType = 4
            Case 386
                path = Form1.FilePath & "\graphics\block\block-619.png"
            Case 387
                path = Form1.FilePath & "\graphics\block\block-618.png"
            Case 389
                path = Form1.FilePath & "\graphics\block\block-246.png"
            Case 390
                path = Form1.FilePath & "\graphics\block\block-250.png"
            Case 391
                path = Form1.FilePath & "\graphics\block\block-247.png"
            Case 392
                path = Form1.FilePath & "\graphics\block\block-256.png"
            Case 393
                path = Form1.FilePath & "\graphics\block\block-255.png"
            Case 394
                path = Form1.FilePath & "\graphics\block\block-316.png"

                IsSlope = True
                SlopeType = 1
            Case 395
                path = Form1.FilePath & "\graphics\block\block-315.png"

                IsSlope = True
                SlopeType = 2
            Case 396
                path = Form1.FilePath & "\graphics\block\block-365.png"

                gfxWidth = 64
                TileW = 64

                IsSlope = True
                SlopeType = 3
            Case 397
                path = Form1.FilePath & "\graphics\block\block-366.png"

                gfxWidth = 64
                TileW = 64

                IsSlope = True
                SlopeType = 4
            Case 398
                path = Form1.FilePath & "\graphics\block\block-252.png"
            Case 399
                path = Form1.FilePath & "\graphics\block\block-251.png"
            Case 400
                path = Form1.FilePath & "\graphics\block\block-253.png"
            Case 401
                path = Form1.FilePath & "\graphics\block\block-257.png"
            Case 402
                path = Form1.FilePath & "\graphics\block\block-258.png"
            Case 403
                path = Form1.FilePath & "\graphics\block\block-317.png"

                IsSlope = True
                SlopeType = 7
            Case 404
                path = Form1.FilePath & "\graphics\block\block-318.png"

                IsSlope = True
                SlopeType = 8
            Case 405
                path = Form1.FilePath & "\graphics\block\block-368.png"

                gfxWidth = 64
                TileW = 64

                IsSlope = True
                SlopeType = 9
            Case 406
                path = Form1.FilePath & "\graphics\block\block-367.png"

                gfxWidth = 64
                TileW = 64

                IsSlope = True
                SlopeType = 10
            Case 407
                path = Form1.FilePath & "\graphics\block\block-248.png"
            Case 408
                path = Form1.FilePath & "\graphics\block\block-254.png"
            Case 409
                path = Form1.FilePath & "\graphics\block\block-249.png"
            Case 410
                path = Form1.FilePath & "\graphics\block\block-262.png"

                gfxWidth = 128
                TileW = 128
                gfxHeight = 128
                TileH = 128
            Case 411
                path = Form1.FilePath & "\graphics\block\block-321.png"

                IsSlope = True
                SlopeType = 5

                gfxWidth = 128
                TileW = 128
            Case 412
                path = Form1.FilePath & "\graphics\block\block-319.png"

                gfxWidth = 128
                TileW = 128

                IsSlope = True
                SlopeType = 6
            Case 413
                path = Form1.FilePath & "\graphics\block\block-322.png"

                gfxWidth = 128
                TileW = 128
            Case 414
                path = Form1.FilePath & "\graphics\block\block-320.png"

                gfxWidth = 128
                TileW = 128
            Case 415
                path = Form1.FilePath & "\graphics\block\block-116.png"
            Case 416
                path = Form1.FilePath & "\graphics\block\block-119.png"
            Case 417
                path = Form1.FilePath & "\graphics\block\block-117.png"
            Case 418
                path = Form1.FilePath & "\graphics\block\block-120.png"
            Case 419
                path = Form1.FilePath & "\graphics\block\block-118.png"
            Case 420
                path = Form1.FilePath & "\graphics\block\block-113.png"

                gfxWidth = 64
                TileW = 64
            Case 421
                path = Form1.FilePath & "\graphics\block\block-137.png"

                gfxWidth = 64
                TileW = 64
            Case 422
                path = Form1.FilePath & "\graphics\block\block-138.png"

                gfxWidth = 64
                TileW = 64
            Case 423
                path = Form1.FilePath & "\graphics\block\block-139.png"

                gfxWidth = 64
                TileW = 64
            Case 424
                path = Form1.FilePath & "\graphics\block\block-141.png"

                gfxWidth = 64
                TileW = 64
            Case 425
                path = Form1.FilePath & "\graphics\block\block-140.png"

                gfxWidth = 64
                TileW = 64
            Case 426
                path = Form1.FilePath & "\graphics\block\block-148.png"

                gfxHeight = 64
                TileH = 64
            Case 427
                path = Form1.FilePath & "\graphics\block\block-154.png"

                gfxHeight = 64
                TileH = 64
            Case 428
                path = Form1.FilePath & "\graphics\block\block-114.png"

                gfxWidth = 64
                TileW = 64
            Case 429
                path = Form1.FilePath & "\graphics\block\block-142.png"

                gfxWidth = 64
                TileW = 64
            Case 430
                path = Form1.FilePath & "\graphics\block\block-143.png"

                gfxWidth = 64
                TileW = 64
            Case 431
                path = Form1.FilePath & "\graphics\block\block-144.png"

                gfxWidth = 64
                TileW = 64
            Case 432
                path = Form1.FilePath & "\graphics\block\block-146.png"

                gfxWidth = 64
                TileW = 64
            Case 433
                path = Form1.FilePath & "\graphics\block\block-145.png"

                gfxWidth = 64
                TileW = 64
            Case 434
                path = Form1.FilePath & "\graphics\block\block-149.png"

                gfxHeight = 64
                TileH = 64
            Case 435
                path = Form1.FilePath & "\graphics\block\block-155.png"

                gfxHeight = 64
                TileH = 64
            Case 436
                path = Form1.FilePath & "\graphics\block\block-152.png"

                gfxHeight = 64
                TileH = 64
            Case 437
                path = Form1.FilePath & "\graphics\block\block-158.png"

                gfxHeight = 64
                TileH = 64
            Case 438
                path = Form1.FilePath & "\graphics\block\block-151.png"

                gfxHeight = 64
                TileH = 64
            Case 439
                path = Form1.FilePath & "\graphics\block\block-157.png"

                gfxHeight = 64
                TileH = 64
            Case 440
                path = Form1.FilePath & "\graphics\block\block-147.png"

                gfxHeight = 64
                TileH = 64
            Case 441
                path = Form1.FilePath & "\graphics\block\block-153.png"

                gfxHeight = 64
                TileH = 64
            Case 442
                path = Form1.FilePath & "\graphics\block\block-150.png"

                gfxHeight = 64
                TileH = 64
            Case 443
                path = Form1.FilePath & "\graphics\block\block-156.png"

                gfxHeight = 64
                TileH = 64
            Case 444
                path = Form1.FilePath & "\graphics\block\block-121.png"
            Case 445
                path = Form1.FilePath & "\graphics\block\block-122.png"
            Case 446
                path = Form1.FilePath & "\graphics\block\block-123.png"
            Case 447
                path = Form1.FilePath & "\graphics\block\block-125.png"

                gfxWidth = 64
                TileW = 64
                gfxHeight = 64
                TileH = 64
            Case 448
                path = Form1.FilePath & "\graphics\block\block-124.png"
            Case 449
                path = Form1.FilePath & "\graphics\block\block-435.png"
            Case 450
                path = Form1.FilePath & "\graphics\block\block-414.png"
            Case 451
                path = Form1.FilePath & "\graphics\block\block-434.png"
            Case 452
                path = Form1.FilePath & "\graphics\block\block-425.png"
            Case 453
                path = Form1.FilePath & "\graphics\block\block-424.png"
            Case 454
                path = Form1.FilePath & "\graphics\block\block-426.png"
            Case 455
                path = Form1.FilePath & "\graphics\block\block-418.png"
            Case 456
                path = Form1.FilePath & "\graphics\block\block-417.png"
            Case 457
                path = Form1.FilePath & "\graphics\block\block-452.png"

                IsSlope = True
                SlopeType = 1
            Case 458
                path = Form1.FilePath & "\graphics\block\block-451.png"

                IsSlope = True
                SlopeType = 2
            Case 459
                path = Form1.FilePath & "\graphics\block\block-412.png"
            Case 460
                path = Form1.FilePath & "\graphics\block\block-413.png"
            Case 461
                path = Form1.FilePath & "\graphics\block\block-411.png"
            Case 462
                path = Form1.FilePath & "\graphics\block\block-423.png"
            Case 463
                path = Form1.FilePath & "\graphics\block\block-422.png"
            Case 464
                path = Form1.FilePath & "\graphics\block\block-421.png"
            Case 465
                path = Form1.FilePath & "\graphics\block\block-416.png"
            Case 466
                path = Form1.FilePath & "\graphics\block\block-415.png"
            Case 467
                path = Form1.FilePath & "\graphics\block\block-450.png"
            Case 468
                path = Form1.FilePath & "\graphics\block\block-449.png"
            Case 469
                path = Form1.FilePath & "\graphics\block\block-433.png"
            Case 470
                path = Form1.FilePath & "\graphics\block\block-410.png"
            Case 471
                path = Form1.FilePath & "\graphics\block\block-432.png"
            Case 472
                path = Form1.FilePath & "\graphics\block\block-427.png"
            Case 473
                path = Form1.FilePath & "\graphics\block\block-419.png"
            Case 474
                path = Form1.FilePath & "\graphics\block\block-436.png"
            Case 475
                path = Form1.FilePath & "\graphics\block\block-455.png"
            Case 476
                path = Form1.FilePath & "\graphics\block\block-456.png"
            Case 477
                path = Form1.FilePath & "\graphics\block\block-453.png"
            Case 478
                path = Form1.FilePath & "\graphics\block\block-454.png"
            Case 479
                path = Form1.FilePath & "\graphics\block\block-466.png"

                gfxHeight = 128
                Lava = True
                Animated = True
            Case 480
                path = Form1.FilePath & "\graphics\block\block-459.png"

                gfxHeight = 128
                Lava = True
                Animated = True
            Case 481
                path = Form1.FilePath & "\graphics\block\block-460.png"

                gfxHeight = 128
                Lava = True
                Animated = True
            Case 482
                path = Form1.FilePath & "\graphics\block\block-471.png"

                gfxHeight = 128
                Lava = True
                Animated = True
            Case 483
                path = Form1.FilePath & "\graphics\block\block-468.png"

                gfxHeight = 128
                Lava = True
                Animated = True
            Case 484
                path = Form1.FilePath & "\graphics\block\block-472.png"

                gfxHeight = 128
                gfxWidth = 64
                TileW = 64

                IsSlope = True
                SlopeType = 3

                Lava = True
                Animated = True
            Case 485
                path = Form1.FilePath & "\graphics\block\block-474.png"

                gfxHeight = 128
                gfxWidth = 64
                TileW = 64

                IsSlope = True
                SlopeType = 4

                Lava = True
                Animated = True
            Case 486
                path = Form1.FilePath & "\graphics\block\block-480.png"

                gfxHeight = 128
                IsSlope = True
                SlopeType = 1

                Lava = True
                Animated = True
            Case 487
                path = Form1.FilePath & "\graphics\block\block-482.png"

                gfxHeight = 128
                IsSlope = True
                SlopeType = 2
                Lava = True
                Animated = True
            Case 488
                path = Form1.FilePath & "\graphics\block\block-484.png"

                gfxHeight = 128
                Lava = True
                Animated = True
            Case 489
                path = Form1.FilePath & "\graphics\block\block-487.png"

                gfxHeight = 128
                Lava = True
                Animated = True
            Case 490
                path = Form1.FilePath & "\graphics\block\block-463.png"

                gfxHeight = 128
                Lava = True
                Animated = True
            Case 491
                path = Form1.FilePath & "\graphics\block\block-467.png"

                Lava = True
            Case 492
                path = Form1.FilePath & "\graphics\block\block-461.png"

                gfxHeight = 128
                Lava = True
                Animated = True
            Case 493
                path = Form1.FilePath & "\graphics\block\block-470.png"

                gfxHeight = 128
                Lava = True
                Animated = True
            Case 494
                path = Form1.FilePath & "\graphics\block\block-469.png"

                gfxHeight = 128
                Lava = True
                Animated = True
            Case 495
                path = Form1.FilePath & "\graphics\block\block-476.png"

                gfxHeight = 128
                gfxWidth = 64
                TileW = 64

                IsSlope = True
                SlopeType = 9

                Lava = True
                Animated = True
            Case 496
                path = Form1.FilePath & "\graphics\block\block-479.png"

                gfxHeight = 128
                gfxWidth = 64
                TileW = 64
                IsSlope = True
                SlopeType = 10
                Lava = True
                Animated = True
            Case 497
                path = Form1.FilePath & "\graphics\block\block-486.png"

                gfxHeight = 128
                IsSlope = True
                SlopeType = 7
                Lava = True
                Animated = True
            Case 498
                path = Form1.FilePath & "\graphics\block\block-485.png"

                gfxHeight = 128
                IsSlope = True
                SlopeType = 8
                Lava = True
                Animated = True
            Case 499
                path = Form1.FilePath & "\graphics\block\block-483.png"

                gfxHeight = 128
                Lava = True
                Animated = True
            Case 500
                path = Form1.FilePath & "\graphics\block\block-481.png"

                gfxHeight = 128
                Lava = True
                Animated = True
            Case 501
                path = Form1.FilePath & "\graphics\block\block-465.png"

                gfxHeight = 128
                Lava = True
                Animated = True
            Case 502
                path = Form1.FilePath & "\graphics\block\block-462.png"

                gfxHeight = 128
                Lava = True
                Animated = True
            Case 503
                path = Form1.FilePath & "\graphics\block\block-464.png"

                gfxHeight = 128
                Lava = True
                Animated = True
            Case 504
                path = Form1.FilePath & "\graphics\block\block-473.png"

                gfxHeight = 128
                Lava = True
                Animated = True
            Case 505
                path = Form1.FilePath & "\graphics\block\block-475.png"

                gfxHeight = 128
                Lava = True
                Animated = True
            Case 506
                path = Form1.FilePath & "\graphics\block\block-477.png"

                gfxHeight = 128
                Lava = True
                Animated = True
            Case 507
                path = Form1.FilePath & "\graphics\block\block-478.png"

                gfxHeight = 128
                Lava = True
                Animated = True
            Case 508
                path = Form1.FilePath & "\graphics\block\block-404.png"

                gfxHeight = 128
                Lava = True
                Animated = True
            Case 509
                path = Form1.FilePath & "\graphics\block\block-420.png"

                Lava = True
            Case 510
                path = Form1.FilePath & "\graphics\block\block-170.png"

                gfxHeight = 128
                Animated = True
            Case 511
                path = Form1.FilePath & "\graphics\block\block-173.png"

                gfxHeight = 128
                Animated = True
            Case 512
                path = Form1.FilePath & "\graphics\block\block-176.png"

                gfxHeight = 128
                Animated = True
            Case 513
                path = Form1.FilePath & "\graphics\block\block-179.png"

                gfxHeight = 128
                Animated = True
            Case 514
                path = Form1.FilePath & "\graphics\block\block-171.png"
            Case 515
                path = Form1.FilePath & "\graphics\block\block-174.png"
            Case 516
                path = Form1.FilePath & "\graphics\block\block-177.png"
            Case 517
                path = Form1.FilePath & "\graphics\block\block-180.png"
            Case 518
                path = Form1.FilePath & "\graphics\block\block-172.png"
            Case 519
                path = Form1.FilePath & "\graphics\block\block-175.png"
            Case 520
                path = Form1.FilePath & "\graphics\block\block-178.png"
            Case 521
                path = Form1.FilePath & "\graphics\block\block-181.png"
            Case 522
                path = Form1.FilePath & "\graphics\block\block-227.png"
            Case 523
                path = Form1.FilePath & "\graphics\block\block-228.png"
            Case 524
                path = Form1.FilePath & "\graphics\block\block-229.png"
            Case 525
                path = Form1.FilePath & "\graphics\block\block-236.png"
            Case 526
                path = Form1.FilePath & "\graphics\block\block-237.png"
            Case 527
                path = Form1.FilePath & "\graphics\block\block-230.png"
            Case 528
                path = Form1.FilePath & "\graphics\block\block-231.png"
            Case 529
                path = Form1.FilePath & "\graphics\block\block-232.png"
            Case 530
                path = Form1.FilePath & "\graphics\block\block-239.png"
            Case 531
                path = Form1.FilePath & "\graphics\block\block-238.png"
            Case 532
                path = Form1.FilePath & "\graphics\block\block-233.png"
            Case 533
                path = Form1.FilePath & "\graphics\block\block-234.png"
            Case 534
                path = Form1.FilePath & "\graphics\block\block-235.png"
            Case 535
                path = Form1.FilePath & "\graphics\block\block-79.png"

                gfxWidth = (SizeW * 32) + 32
                TileW = (SizeW * 32) + 32
                gfxHeight = (SizeH * 32) + 32
                TileH = (SizeH * 32) + 32
                Sizable = True
            Case 536
                path = Form1.FilePath & "\graphics\block\block-244.png"

                gfxWidth = (SizeW * 32) + 32
                TileW = (SizeW * 32) + 32
                gfxHeight = (SizeH * 32) + 32
                TileH = (SizeH * 32) + 32
                Sizable = True
            Case 537
                path = Form1.FilePath & "\graphics\block\block-439.png"

                gfxWidth = (SizeW * 32) + 32
                TileW = (SizeW * 32) + 32
                gfxHeight = (SizeH * 32) + 32
                TileH = (SizeH * 32) + 32
                Sizable = True
            Case 538
                path = Form1.FilePath & "\graphics\block\block-440.png"

                gfxWidth = (SizeW * 32) + 32
                TileW = (SizeW * 32) + 32
                gfxHeight = (SizeH * 32) + 32
                TileH = (SizeH * 32) + 32
                Sizable = True
            Case 539
                path = Form1.FilePath & "\graphics\block\block-445.png"

                gfxWidth = (SizeW * 32) + 32
                TileW = (SizeW * 32) + 32
                gfxHeight = (SizeH * 32) + 32
                TileH = (SizeH * 32) + 32
                Sizable = True
            Case 540
                path = Form1.FilePath & "\graphics\block\block-161.png"

                gfxWidth = (SizeW * 32) + 32
                TileW = (SizeW * 32) + 32
                gfxHeight = (SizeH * 32) + 32
                TileH = (SizeH * 32) + 32
                Sizable = True
            Case 541
                path = Form1.FilePath & "\graphics\block\block-261.png"

                gfxWidth = (SizeW * 32) + 32
                TileW = (SizeW * 32) + 32
                gfxHeight = (SizeH * 32) + 32
                TileH = (SizeH * 32) + 32
                Sizable = True
            Case 542
                path = Form1.FilePath & "\graphics\block\block-437.png"

                gfxWidth = (SizeW * 32) + 32
                TileW = (SizeW * 32) + 32
                gfxHeight = (SizeH * 32) + 32
                TileH = (SizeH * 32) + 32
                Sizable = True
            Case 543
                path = Form1.FilePath & "\graphics\block\block-441.png"

                gfxWidth = (SizeW * 32) + 32
                TileW = (SizeW * 32) + 32
                gfxHeight = (SizeH * 32) + 32
                TileH = (SizeH * 32) + 32
                Sizable = True
            Case 544
                path = Form1.FilePath & "\graphics\block\block-444.png"

                gfxWidth = (SizeW * 32) + 32
                TileW = (SizeW * 32) + 32
                gfxHeight = (SizeH * 32) + 32
                TileH = (SizeH * 32) + 32
                Sizable = True
            Case 545
                path = Form1.FilePath & "\graphics\block\block-245.png"

                gfxWidth = (SizeW * 32) + 32
                TileW = (SizeW * 32) + 32
                gfxHeight = (SizeH * 32) + 32
                TileH = (SizeH * 32) + 32
                Sizable = True
            Case 546
                path = Form1.FilePath & "\graphics\block\block-259.png"

                gfxWidth = (SizeW * 32) + 32
                TileW = (SizeW * 32) + 32
                gfxHeight = (SizeH * 32) + 32
                TileH = (SizeH * 32) + 32
                Sizable = True
            Case 547
                path = Form1.FilePath & "\graphics\block\block-438.png"

                gfxWidth = (SizeW * 32) + 32
                TileW = (SizeW * 32) + 32
                gfxHeight = (SizeH * 32) + 32
                TileH = (SizeH * 32) + 32
                Sizable = True
            Case 548
                path = Form1.FilePath & "\graphics\block\block-442.png"

                gfxWidth = (SizeW * 32) + 32
                TileW = (SizeW * 32) + 32
                gfxHeight = (SizeH * 32) + 32
                TileH = (SizeH * 32) + 32
                Sizable = True
            Case 549
                path = Form1.FilePath & "\graphics\block\block-443.png"

                gfxWidth = (SizeW * 32) + 32
                TileW = (SizeW * 32) + 32
                gfxHeight = (SizeH * 32) + 32
                TileH = (SizeH * 32) + 32
                Sizable = True
            Case 550
                path = Form1.FilePath & "\graphics\block\block-133.png"
            Case 551
                path = Form1.FilePath & "\graphics\block\block-134.png"
            Case 552
                path = Form1.FilePath & "\graphics\block\block-135.png"
            Case 553
                path = Form1.FilePath & "\graphics\block\block-115.png"
            Case 554
                path = Form1.FilePath & "\graphics\block\block-447.png"
            Case 555
                path = Form1.FilePath & "\graphics\block\block-446.png"
            Case 556
                path = Form1.FilePath & "\graphics\block\block-448.png"
            Case 557
                path = Form1.FilePath & "\graphics\block\block-88.png"

                gfxHeight = 128
                Animated = True
            Case 558
                path = Form1.FilePath & "\graphics\block\block-89.png"
            Case 559
                path = Form1.FilePath & "\graphics\block\block-90.png"
            Case 560
                path = Form1.FilePath & "\graphics\block\block-169.png"

                gfxHeight = 128
                Animated = True
            Case 561
                path = Form1.FilePath & "\graphics\block\block-281.png"
            Case 562
                path = Form1.FilePath & "\graphics\block\block-282.png"
            Case 563
                path = Form1.FilePath & "\graphics\block\block-283.png"
            Case 564
                path = Form1.FilePath & "\graphics\block\block-615.png"

                gfxWidth = 64
                TileW = 64
            Case 565
                path = Form1.FilePath & "\graphics\block\block-408.png"

                Hurts = True
            Case 566
                path = Form1.FilePath & "\graphics\block\block-430.png"

                Hurts = True
            Case 567
                path = Form1.FilePath & "\graphics\block\block-409.png"
            Case 568
                path = Form1.FilePath & "\graphics\block\block-429.png"

                Hurts = True
            Case 569
                path = Form1.FilePath & "\graphics\block\block-428.png"

                Hurts = True
            Case 570
                path = Form1.FilePath & "\graphics\block\block-407.png"

                Hurts = True
            Case 571
                path = Form1.FilePath & "\graphics\block\block-431.png"

                Hurts = True
            Case 572
                path = Form1.FilePath & "\graphics\block\block-291.png"
            Case 573
                path = Form1.FilePath & "\graphics\block\block-292.png"
            Case 574
                path = Form1.FilePath & "\graphics\block\block-522.png"
            Case 575
                path = Form1.FilePath & "\graphics\block\block-528.png"
            Case 576
                path = Form1.FilePath & "\graphics\block\block-523.png"
            Case 577
                path = Form1.FilePath & "\graphics\block\block-530.png"

                gfxHeight = 128
                Animated = True
            Case 578
                path = Form1.FilePath & "\graphics\block\block-516.png"
            Case 579
                path = Form1.FilePath & "\graphics\block\block-517.png"
            Case 580
                path = Form1.FilePath & "\graphics\block\block-514.png"
            Case 581
                path = Form1.FilePath & "\graphics\block\block-518.png"
            Case 582
                path = Form1.FilePath & "\graphics\block\block-542.png"
            Case 583
                path = Form1.FilePath & "\graphics\block\block-541.png"
            Case 584
                path = Form1.FilePath & "\graphics\block\block-540.png"

                gfxWidth = 64
                TileW = 64
            Case 585
                path = Form1.FilePath & "\graphics\block\block-520.png"
            Case 586
                path = Form1.FilePath & "\graphics\block\block-526.png"
            Case 587
                path = Form1.FilePath & "\graphics\block\block-525.png"
            Case 588
                path = Form1.FilePath & "\graphics\block\block-527.png"

                gfxWidth = 64
                TileW = 64
                gfxHeight = 96
                TileH = 96
            Case 589
                path = Form1.FilePath & "\graphics\block\block-532.png"
            Case 590
                path = Form1.FilePath & "\graphics\block\block-515.png"
            Case 591
                path = Form1.FilePath & "\graphics\block\block-513.png"
            Case 592
                path = Form1.FilePath & "\graphics\block\block-533.png"
            Case 593
                path = Form1.FilePath & "\graphics\block\block-539.png"
            Case 594
                path = Form1.FilePath & "\graphics\block\block-534.png"

                gfxWidth = 48
                TileW = 48
                gfxHeight = 128
                TileH = 128
            Case 595
                path = Form1.FilePath & "\graphics\block\block-535.png"

                gfxWidth = 48
                TileW = 48
                gfxHeight = 128
                TileH = 128
            Case 596
                path = Form1.FilePath & "\graphics\block\block-519.png"
            Case 597
                path = Form1.FilePath & "\graphics\block\block-524.png"
            Case 598
                path = Form1.FilePath & "\graphics\block\block-521.png"
            Case 599
                path = Form1.FilePath & "\graphics\block\block-529.png"

                gfxHeight = 64
                TileH = 64
            Case 600
                path = Form1.FilePath & "\graphics\block\block-531.png"
            Case 601
                path = Form1.FilePath & "\graphics\block\block-538.png"
            Case 602
                path = Form1.FilePath & "\graphics\block\block-544.png"
            Case 603
                path = Form1.FilePath & "\graphics\block\block-543.png"
            Case 604
                path = Form1.FilePath & "\graphics\block\block-512.png"
            Case 605
                path = Form1.FilePath & "\graphics\block\block-536.png"

                gfxWidth = 128
                TileW = 128
                gfxHeight = 48
                TileH = 48
            Case 606
                path = Form1.FilePath & "\graphics\block\block-537.png"

                gfxWidth = 128
                TileW = 128
                gfxHeight = 48
                TileH = 48
            Case 607
                path = Form1.FilePath & "\graphics\block\block-550.png"
            Case 608
                path = Form1.FilePath & "\graphics\block\block-556.png"
            Case 609
                path = Form1.FilePath & "\graphics\block\block-561.png"
            Case 610
                path = Form1.FilePath & "\graphics\block\block-566.png"
            Case 611
                path = Form1.FilePath & "\graphics\block\block-564.png"
            Case 612
                path = Form1.FilePath & "\graphics\block\block-562.png"
            Case 613
                path = Form1.FilePath & "\graphics\block\block-547.png"
            Case 614
                path = Form1.FilePath & "\graphics\block\block-548.png"
            Case 615
                path = Form1.FilePath & "\graphics\block\block-565.png"
            Case 616
                path = Form1.FilePath & "\graphics\block\block-567.png"
            Case 617
                path = Form1.FilePath & "\graphics\block\block-551.png"
            Case 618
                path = Form1.FilePath & "\graphics\block\block-558.png"
            Case 619
                path = Form1.FilePath & "\graphics\block\block-555.png"
            Case 620
                path = Form1.FilePath & "\graphics\block\block-545.png"
            Case 621
                path = Form1.FilePath & "\graphics\block\block-546.png"
            Case 622
                path = Form1.FilePath & "\graphics\block\block-549.png"
            Case 623
                path = Form1.FilePath & "\graphics\block\block-553.png"
            Case 624
                path = Form1.FilePath & "\graphics\block\block-554.png"
            Case 625
                path = Form1.FilePath & "\graphics\block\block-563.png"
            Case 626
                path = Form1.FilePath & "\graphics\block\block-557.png"
            Case 627
                path = Form1.FilePath & "\graphics\block\block-552.png"
            Case 628
                path = Form1.FilePath & "\graphics\block\block-559.png"
            Case 629
                path = Form1.FilePath & "\graphics\block\block-560.png"
            Case 630
                path = Form1.FilePath & "\graphics\block\block-622.png"

                gfxHeight = 128
                Animated = True
            Case 631
                path = Form1.FilePath & "\graphics\block\block-623.png"

                gfxHeight = 128
                Animated = True
            Case 632
                path = Form1.FilePath & "\graphics\block\block-624.png"

                gfxHeight = 128
                Animated = True
            Case 633
                path = Form1.FilePath & "\graphics\block\block-625.png"

                gfxHeight = 128
                Animated = True
            Case 634
                path = Form1.FilePath & "\graphics\block\block-631.png"

                gfxHeight = 128
                Animated = True
            Case 635
                path = Form1.FilePath & "\graphics\block\block-626.png"
                'Animated = True
            Case 636
                path = Form1.FilePath & "\graphics\block\block-627.png"
            Case 637
                path = Form1.FilePath & "\graphics\block\block-628.png"
            Case 638
                path = Form1.FilePath & "\graphics\block\block-629.png"
            Case 639
                path = Form1.FilePath & "\graphics\block\block-632.png"
        End Select

        TotalFrames = gfxHeight / TileH

        LoadStream(path)

        Try
            Form2.TB = New TextureBrush(bmp)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Shared Sub LoadStream(StreamPath As String)
        If Sizable = True Then

            Dim fs As New System.IO.FileStream(StreamPath, System.IO.FileMode.Open)
            Dim graphic As Image

            graphic = Image.FromStream(fs)

            Dim SizeBMP As New Bitmap((SizeW * 32) + 32, (SizeH * 32) + 32)

            Dim g As Graphics = Graphics.FromImage(SizeBMP)

            g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
            For X = 1 To SizeW
                g.DrawImage(graphic, New Rectangle(X * 32, 0, 32, 32), New Rectangle(32, 0, 32, 32), GraphicsUnit.Pixel)
                g.DrawImage(graphic, New Rectangle(X * 32, SizeH * 32, 32, 32), New Rectangle(32, 64, 32, 32), GraphicsUnit.Pixel)
            Next
            For Y = 1 To SizeH
                g.DrawImage(graphic, New Rectangle(0, Y * 32, 32, 32), New Rectangle(0, 32, 32, 32), GraphicsUnit.Pixel)
                g.DrawImage(graphic, New Rectangle(SizeW * 32, Y * 32, 32, 32), New Rectangle(64, 32, 32, 32), GraphicsUnit.Pixel)
            Next
            For FillX = 1 To SizeW - 1
                For FillY = 1 To SizeH - 1
                    g.DrawImage(graphic, New Rectangle(FillX * 32, FillY * 32, 32, 32), New Rectangle(32, 32, 32, 32), GraphicsUnit.Pixel)
                Next
            Next
            g.DrawImage(graphic, New Rectangle((SizeW * 32), 0, 32, 32), New Rectangle(64, 0, 32, 32), GraphicsUnit.Pixel)
            g.DrawImage(graphic, New Rectangle(0, (SizeH * 32), 32, 32), New Rectangle(0, 64, 32, 32), GraphicsUnit.Pixel)
            g.DrawImage(graphic, New Rectangle((SizeW * 32), (SizeH * 32), 32, 32), New Rectangle(64, 64, 32, 32), GraphicsUnit.Pixel)

            bmp = New Bitmap(SizeBMP)

            fs.Close()
            fs.Dispose()
        Else
            Dim fs As New System.IO.FileStream(StreamPath, System.IO.FileMode.Open)

            Dim graphic As Image
            graphic = Image.FromStream(fs)
            bmp = New Bitmap(graphic)

            fs.Close()
            fs.Dispose()
        End If
    End Sub
End Class