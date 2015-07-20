Public Structure NPCsets
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
    Dim AI As Integer
    Dim Direction As Integer
    Dim MSG As String
    Dim HasGravity As Boolean
    Dim MoveSpeed As Double
    Dim FrameStyle As Integer
    Dim CurFrame As Integer
    Dim MetroidGlass As Boolean

    Dim OnGround As Boolean
    Dim Testing As Boolean
    Dim isMoving As Boolean
    Dim hopHeight As Integer
    Dim totalJumps As Integer
    Dim isJumping As Integer
    Dim Delay As Integer
    Dim thwompRise As Boolean
    Dim thwompFall As Boolean
    Dim lakituThrow As Boolean
    Dim radius As Integer
    Dim angle As Integer
    Dim Friction As Double
    Dim Flutter As Double
    Dim playedSound As Boolean
    Dim totalFire As Integer
End Structure

Public Class ActiveNPC
    Public rectangle As Rectangle
    Public X As Integer
    Public Y As Integer
    Public Width As Integer
    Public Height As Integer
    Public ID As Integer
    Public IMG As Image
    Public Animated As Boolean
    Public SourceRect As Rectangle
    Public gfxWidth As Integer
    Public gfxHeight As Integer
    Public TotalFrames As Integer
    Public FrameSpeed As Integer
    Public AI As Integer
    Public Direction As Integer
    Public MSG As String
    Public HasGravity As Boolean
    Public MoveSpeed As Double
    Public FrameStyle As Integer
    Public CurFrame As Integer
    Public MetroidGlass As Boolean
End Class

Public Class NPC
    Public Shared NPCW As Integer = 32
    Public Shared NPCH As Integer = 32
    Public Shared Animated As Boolean
    Public Shared gfxWidth As Integer
    Public Shared gfxHeight As Integer
    Public Shared FrameSpeed As Integer
    Public Shared TotalFrames As Integer
    Public Shared NPCSize As Integer = 32
    Public Shared NPC As NPCsets
    Public Shared NPCsets As New List(Of NPCsets)
    Public Shared NPCrects As New List(Of Rectangle)
    Public Shared AI As Integer
    Public Shared Direction As Integer
    Public Shared Message As String
    Public Shared HasGravity As Boolean
    Public Shared MoveSpeed As Double
    Public Shared FrameStyle As Integer
    Public Shared MetroidGlass As Boolean

    Public Shared bmp As Bitmap

    Public posX As Integer
    Public posY As Integer

    Public Shared path As String
    Public Shared path2 As String

    Public Shared Sub GetNPC()
        
        bmp = Nothing

        NPCW = 32
        NPCH = 32
        Animated = False
        gfxWidth = 32
        gfxHeight = 32
        FrameSpeed = 8
        TotalFrames = 0
        AI = 0
        FrameStyle = 0
        MetroidGlass = False

        If NPCs.RadioButton1.Checked = True Then
            Direction = 2
        ElseIf NPCs.RadioButton2.Checked = True Then
            Direction = 0
        ElseIf NPCs.RadioButton3.Checked = True Then
            Direction = 1
        End If

        Message = ""
        HasGravity = True
        MoveSpeed = 1

        Select Case Form2.SelectedNPC
            Case 1
                path = Form1.FilePath & "\graphics\npc\npc-1.png"

                gfxHeight = 64
                Animated = True
                TotalFrames = 2
            Case 2
                path = Form1.FilePath & "\graphics\npc\npc-2.png"

                gfxHeight = 64
                Animated = True
                TotalFrames = 2
            Case 3
                path = Form1.FilePath & "\graphics\npc\npc-3.png"

                Animated = True
                TotalFrames = 2
                gfxWidth = 40
                gfxHeight = 96
                NPCW = 40
                NPCH = 48
                AI = 1
            Case 4
                path = Form1.FilePath & "\graphics\npc\npc-244.png"

                Animated = True
                TotalFrames = 2
                gfxWidth = 40
                gfxHeight = 96
                NPCW = 40
                NPCH = 48
                AI = 5
            Case 5
                path = Form1.FilePath & "\graphics\npc\npc-71.png"

                Animated = True
                TotalFrames = 2
                gfxWidth = 48
                gfxHeight = 92
                NPCW = 48
                NPCH = 46
            Case 6
                path = Form1.FilePath & "\graphics\npc\npc-37.png"

                HasGravity = False
                gfxWidth = 48
                gfxHeight = 64
                NPCW = 48
                NPCH = 64
                AI = 2
            Case 7
                path = Form1.FilePath & "\graphics\npc\npc-38.png"

                HasGravity = False
                AI = 3
                gfxHeight = 64
                FrameStyle = 1
            Case 8
                path = Form1.FilePath & "\graphics\npc\npc-6.png"

                Animated = True
                TotalFrames = 2
                FrameStyle = 1
                gfxHeight = 108
                NPCH = 54
                AI = 4
                FrameSpeed = 8
            Case 9
                path = Form1.FilePath & "\graphics\npc\npc-4.png"

                Animated = True
                TotalFrames = 2
                FrameStyle = 1
                gfxHeight = 108
                NPCH = 54
                FrameSpeed = 8
            Case 10
                path = Form1.FilePath & "\graphics\npc\npc-76.png"

                Animated = True
                TotalFrames = 4
                gfxHeight = 224
                FrameStyle = 1
                FrameSpeed = 7
                NPCH = 56
                AI = 5
            Case 11
                path = Form1.FilePath & "\graphics\npc\npc-161.png"

                Animated = True
                TotalFrames = 4
                gfxHeight = 224
                NPCH = 56
                FrameStyle = 1
                FrameSpeed = 3
                AI = 5
            Case 12
                path = Form1.FilePath & "\graphics\npc\npc-72.png"

                Animated = True
                TotalFrames = 2
                gfxWidth = 48
                gfxHeight = 124
                FrameStyle = 1
                FrameSpeed = 8
                NPCW = 48
                NPCH = 62
            Case 13
                path = Form1.FilePath & "\graphics\npc\npc-48.png"

                MoveSpeed = 5
                Animated = True
                TotalFrames = 2
                gfxHeight = 64
                FrameSpeed = 4
                AI = 6
            Case 14
                path = Form1.FilePath & "\graphics\npc\npc-47.png"

                MoveSpeed = 5
                gfxHeight = 64
                NPCH = 64
                AI = 7
            Case 15
                path = Form1.FilePath & "\graphics\npc\npc-12.png"

                Animated = True
                TotalFrames = 2
                gfxHeight = 64
                gfxWidth = 28
                NPCW = 28
                FrameSpeed = 3
                AI = 8
            Case 16
                path = Form1.FilePath & "\graphics\npc\npc-23.png"

                Animated = True
                TotalFrames = 2
                FrameStyle = 1
                FrameSpeed = 8
                gfxHeight = 64
            Case 17
                path = Form1.FilePath & "\graphics\npc\npc-17.png"

                gfxHeight = 28
                NPCH = 28
                AI = 9
                FrameStyle = 1
                MoveSpeed = 6
            Case 18
                path = Form1.FilePath & "\graphics\npc\npc-136.png"

                AI = 4
                Animated = True
                TotalFrames = 2
                gfxHeight = 64
                FrameStyle = 1
            Case 19
                path = Form1.FilePath & "\graphics\npc\npc-137.png"

                AI = 10
                gfxHeight = 168
                NPCH = 28
                Animated = True
                TotalFrames = 2
                FrameStyle = 1
            Case 20
                path = Form1.FilePath & "\graphics\npc\npc-53.png"

                Animated = True
                TotalFrames = 2
                gfxHeight = 64
                FrameSpeed = 8
            Case 21
                path = Form1.FilePath & "\graphics\npc\npc-54.png"

                AI = 11
            Case 22
                path = Form1.FilePath & "\graphics\npc\npc-36.png"

                Animated = True
                TotalFrames = 2
                gfxHeight = 64
                FrameStyle = 1
                FrameSpeed = 8
            Case 23
                path = Form1.FilePath & "\graphics\npc\npc-259.png"

                AI = 12
                Animated = True
                TotalFrames = 5
                gfxHeight = 160
                FrameSpeed = 2
            Case 24
                path = Form1.FilePath & "\graphics\npc\npc-15.png"

                gfxWidth = 68
                gfxHeight = 270
                NPCW = 68
                NPCH = 54
                AI = 13
                Animated = True
                TotalFrames = 5
                FrameSpeed = 5
                MoveSpeed = 4
            Case 25
                path = Form1.FilePath & "\graphics\npc\npc-267.png"

                gfxWidth = 84
                gfxHeight = 620
                NPCW = 84
                NPCH = 62
                AI = 14
                MoveSpeed = 4
                FrameStyle = 1
            Case 26
                path = Form1.FilePath & "\graphics\npc\npc-86.png"

                gfxWidth = 64
                gfxHeight = 1200
                NPCW = 64
                NPCH = 80
                FrameStyle = 3
            Case 27
                path = Form1.FilePath & "\graphics\npc\npc-73.png"

                gfxWidth = 44
                gfxHeight = 44
                NPCW = 44
                NPCH = 44
            Case 28
                path = Form1.FilePath & "\graphics\npc\npc-5.png"

                gfxWidth = 32
                gfxHeight = 32
                NPCW = 32
                NPCH = 32
            Case 29
                path = Form1.FilePath & "\graphics\npc\npc-7.png"

                gfxWidth = 32
                gfxHeight = 32
                NPCW = 32
                NPCH = 32
            Case 30
                path = Form1.FilePath & "\graphics\npc\npc-24.png"

            Case 31
                path = Form1.FilePath & "\graphics\npc\npc-21.png"

                AI = 10
                HasGravity = True
            Case 32
                path = Form1.FilePath & "\graphics\npc\npc-84.png"

                gfxHeight = 64
                NPCH = 64
                HasGravity = True
                FrameStyle = 1
                AI = 19
            Case 33
                path = Form1.FilePath & "\graphics\npc\npc-58.png"

                AI = 10
                HasGravity = True
            Case 34
                path = Form1.FilePath & "\graphics\npc\npc-69.png"

                gfxHeight = 128
                NPCH = 128
                HasGravity = True
                AI = 10
            Case 35
                path = Form1.FilePath & "\graphics\npc\npc-70.png"

                gfxHeight = 256
                NPCH = 256
                HasGravity = True
                AI = 10
            Case 36
                path = Form1.FilePath & "\graphics\npc\npc-81.png"

                gfxWidth = 128
                NPCW = 128
                HasGravity = False
            Case 37
                path = Form1.FilePath & "\graphics\npc\npc-80.png"

                gfxWidth = 128
                NPCW = 128
                HasGravity = False
            Case 38
                path = Form1.FilePath & "\graphics\npc\npc-82.png"

                gfxWidth = 128
                NPCW = 128
                HasGravity = False
            Case 39
                path = Form1.FilePath & "\graphics\npc\npc-67.png"

                gfxWidth = 128
                NPCW = 128
                AI = 10
            Case 40
                path = Form1.FilePath & "\graphics\npc\npc-68.png"

                gfxWidth = 256
                NPCW = 256
                AI = 10
            Case 41
                path = Form1.FilePath & "\graphics\npc\npc-160.png"

                gfxWidth = 316
                NPCW = 316
                gfxHeight = 128
                NPCH = 32
                Animated = True
                FrameStyle = 1
                HasGravity = False
                FrameSpeed = 4
            Case 42
                path = Form1.FilePath & "\graphics\npc\npc-83.png"

                gfxWidth = 256
                NPCW = 256
                HasGravity = False
            Case 43
                path = Form1.FilePath & "\graphics\npc\npc-79.png"

                gfxWidth = 64
                NPCW = 64
                HasGravity = False
            Case 44
                path = Form1.FilePath & "\graphics\npc\npc-78.png"

                gfxWidth = 128
                NPCW = 128
                gfxHeight = 96
                NPCH = 32
                Animated = True
                FrameStyle = 1
                HasGravity = False
                FrameSpeed = 5
            Case 45
                path = Form1.FilePath & "\graphics\npc\npc-45.png"

                gfxHeight = 128
                NPCH = 32
                Animated = True
                FrameSpeed = 8
                HasGravity = True
            Case 46
                path = Form1.FilePath & "\graphics\npc\npc-8.png"

                gfxHeight = 96
                NPCH = 48
                Animated = True
                FrameSpeed = 8
            Case 47
                path = Form1.FilePath & "\graphics\npc\npc-74.png"

                gfxWidth = 48
                NPCW = 48
                gfxHeight = 128
                NPCH = 64
                Animated = True
                FrameSpeed = 8
            Case 48
                path = Form1.FilePath & "\graphics\npc\npc-52.png"

                gfxWidth = 48
                NPCW = 48
                gfxHeight = 64
                NPCH = 32
                Animated = True
                FrameSpeed = 8
                FrameStyle = 1
            Case 49
                path = Form1.FilePath & "\graphics\npc\npc-51.png"

                gfxHeight = 128
                NPCH = 64
                Animated = True
                FrameSpeed = 8
            Case 50
                path = Form1.FilePath & "\graphics\npc\npc-245.png"

                gfxHeight = 128
                NPCH = 64
                FrameStyle = 1
            Case 51
                path = Form1.FilePath & "\graphics\npc\npc-261.png"

                gfxHeight = 128
                NPCH = 32
                Animated = True
                FrameSpeed = 8
                FrameStyle = 1
            Case 52
                path = Form1.FilePath & "\graphics\npc\npc-229.png"

                gfxHeight = 64
                NPCH = 32
                Animated = True
                FrameSpeed = 8
                FrameStyle = 1
            Case 53
                path = Form1.FilePath & "\graphics\npc\npc-230.png"

                gfxHeight = 64
                NPCH = 32
                Animated = True
                FrameSpeed = 8
                FrameStyle = 1
            Case 54
                path = Form1.FilePath & "\graphics\npc\npc-231.png"

            Case 55
                path = Form1.FilePath & "\graphics\npc\npc-75.png"

                gfxWidth = 38
                NPCW = 38
                gfxHeight = 174
                NPCH = 58
                FrameStyle = 1
            Case 56
                path = Form1.FilePath & "\graphics\npc\npc-198.png"

                gfxHeight = 64
                NPCH = 64
                FrameStyle = 1
                AI = 10
            Case 57
                path = Form1.FilePath & "\graphics\npc\npc-94.png"

                gfxHeight = 54
                NPCH = 54
                FrameStyle = 1
                AI = 10
            Case 58
                path = Form1.FilePath & "\graphics\npc\npc-101.png"

                gfxHeight = 62
                NPCH = 62
                FrameStyle = 1
                AI = 10
            Case 59
                path = Form1.FilePath & "\graphics\npc\npc-9.png"
                MoveSpeed = 3
            Case 60
                path = Form1.FilePath & "\graphics\npc\npc-14.png"

                AI = 10
            Case 61
                path = Form1.FilePath & "\graphics\npc\npc-34.png"

            Case 62
                path = Form1.FilePath & "\graphics\npc\npc-169.png"

                AI = 10
            Case 63
                path = Form1.FilePath & "\graphics\npc\npc-170.png"

                AI = 10
            Case 64
                path = Form1.FilePath & "\graphics\npc\npc-264.png"

                AI = 10
            Case 65
                path = Form1.FilePath & "\graphics\npc\npc-90.png"

                MoveSpeed = 4
            Case 66
                path = Form1.FilePath & "\graphics\npc\npc-10.png"

                Animated = True
                gfxHeight = 128
                FrameSpeed = 7
                HasGravity = False
                AI = 10
            Case 67
                path = Form1.FilePath & "\graphics\npc\npc-103.png"

                AI = 10
                Animated = True
                gfxHeight = 128
                FrameSpeed = 7
                HasGravity = False
            Case 68
                path = Form1.FilePath & "\graphics\npc\npc-35.png"

                AI = 10
                HasGravity = True
                gfxHeight = 64
                Animated = True
                FrameSpeed = 8
                FrameStyle = 1
            Case 69
                path = Form1.FilePath & "\graphics\npc\npc-191.png"

                AI = 10
                HasGravity = True
                gfxHeight = 64
                Animated = True
                FrameSpeed = 6
                FrameStyle = 1
            Case 70
                path = Form1.FilePath & "\graphics\npc\npc-193.png"


                gfxHeight = 64
                Animated = True
                FrameSpeed = 6
                FrameStyle = 1
            Case 71
                path = Form1.FilePath & "\graphics\npc\npc-22.png"

                AI = 10
                HasGravity = True
                gfxHeight = 160
                Animated = True
                FrameSpeed = 4
            Case 72
                path = Form1.FilePath & "\graphics\npc\npc-49.png"

                AI = 10
                HasGravity = True
                gfxHeight = 160
                NPCH = 32
                Animated = True
                FrameSpeed = 4
            Case 73
                path = Form1.FilePath & "\graphics\npc\npc-248.png"

                HasGravity = True
                AI = 10
            Case 74
                path = Form1.FilePath & "\graphics\npc\npc-238.png"

                AI = 10
                HasGravity = True
                Animated = True
                gfxHeight = 96
            Case 75
                path = Form1.FilePath & "\graphics\npc\npc-273.png"

                AI = 10
                HasGravity = True
            Case 76
                path = Form1.FilePath & "\graphics\npc\npc-287.png"

                AI = 10
                Animated = True
                gfxHeight = 64
            Case 77
                path = Form1.FilePath & "\graphics\npc\npc-226.png"


                Animated = True
                gfxHeight = 64
            Case 78
                path = Form1.FilePath & "\graphics\npc\npc-213.png"

                AI = 10
                HasGravity = False
            Case 79
                path = Form1.FilePath & "\graphics\npc\npc-225.png"


                Animated = True
                gfxHeight = 64
            Case 80
                path = Form1.FilePath & "\graphics\npc\npc-214.png"

                AI = 10
                Animated = True
                gfxHeight = 64
            Case 81
                path = Form1.FilePath & "\graphics\npc\npc-11.png"

                AI = 10
                Animated = True
                gfxHeight = 96
            Case 82
                path = Form1.FilePath & "\graphics\npc\npc-16.png"

            Case 83
                path = Form1.FilePath & "\graphics\npc\npc-97.png"

                Animated = True
                gfxHeight = 96
                FrameSpeed = 7
            Case 84
                path = Form1.FilePath & "\graphics\npc\npc-46.png"

            Case 85
                path = Form1.FilePath & "\graphics\npc\npc-212.png"

            Case 86
                path = Form1.FilePath & "\graphics\npc\npc-104.png"

                gfxWidth = 96
                NPCW = 96
            Case 87 'End of SMB3 Enemies
                path = Form1.FilePath & "\graphics\npc\npc-57.png"


                gfxHeight = 128
                Animated = True
                FrameSpeed = 1
            Case 88
                path = Form1.FilePath & "\graphics\npc\npc-20.png"


                gfxHeight = 64
                Animated = True
                FrameStyle = 1
            Case 89
                path = Form1.FilePath & "\graphics\npc\npc-25.png"


                gfxHeight = 256
                FrameStyle = 2
            Case 90
                path = Form1.FilePath & "\graphics\npc\npc-131.png"


                gfxHeight = 64
                Animated = True
                FrameStyle = 1
            Case 91
                path = Form1.FilePath & "\graphics\npc\npc-132.png"


                gfxHeight = 64
                Animated = True
                FrameStyle = 1
            Case 92
                path = Form1.FilePath & "\graphics\npc\npc-206.png"


                gfxHeight = 64
                Animated = True
            Case 93
                path = Form1.FilePath & "\graphics\npc\npc-272.png"


                gfxHeight = 64
                Animated = True
                FrameStyle = 1
            Case 94
                path = Form1.FilePath & "\graphics\npc\npc-19.png"


                gfxHeight = 64
                Animated = True
                FrameStyle = 1
            Case 95
                path = Form1.FilePath & "\graphics\npc\npc-129.png"


                gfxHeight = 64
                Animated = True
                FrameStyle = 1
            Case 96
                path = Form1.FilePath & "\graphics\npc\npc-130.png"


                gfxHeight = 64
                Animated = True
                FrameStyle = 1
            Case 97
                path = Form1.FilePath & "\graphics\npc\npc-135.png"


                gfxHeight = 64
                Animated = True
                FrameStyle = 1
            Case 98
                path = Form1.FilePath & "\graphics\npc\npc-247.png"


                gfxHeight = 128
                NPCH = 64
                Animated = True
            Case 99
                path = Form1.FilePath & "\graphics\npc\npc-147.png"


                gfxHeight = 64
                NPCH = 32
                Animated = True
            Case 100
                path = Form1.FilePath & "\graphics\npc\npc-92.png"

            Case 101
                path = Form1.FilePath & "\graphics\npc\npc-140.png"

            Case 102
                path = Form1.FilePath & "\graphics\npc\npc-142.png"

            Case 103
                path = Form1.FilePath & "\graphics\npc\npc-139.png"


                gfxWidth = 28
                NPCW = 28
            Case 104
                path = Form1.FilePath & "\graphics\npc\npc-145.png"


                gfxWidth = 24
                NPCW = 24
                gfxHeight = 28
                NPCH = 28
            Case 105
                path = Form1.FilePath & "\graphics\npc\npc-144.png"


                gfxWidth = 24
                NPCW = 24
                gfxHeight = 30
                NPCH = 30
            Case 106
                path = Form1.FilePath & "\graphics\npc\npc-141.png"


                gfxWidth = 28
                NPCW = 28
            Case 107
                path = Form1.FilePath & "\graphics\npc\npc-143.png"


                gfxWidth = 12
                NPCW = 12
                gfxHeight = 26
                NPCH = 26
            Case 108
                path = Form1.FilePath & "\graphics\npc\npc-146.png"


                gfxWidth = 20
                NPCW = 20
            Case 109
                path = Form1.FilePath & "\graphics\npc\npc-217.png"


                gfxHeight = 128
                Animated = True
            Case 110
                path = Form1.FilePath & "\graphics\npc\npc-215.png"


                gfxHeight = 128
                Animated = True
            Case 111
                path = Form1.FilePath & "\graphics\npc\npc-216.png"


                gfxHeight = 128
                Animated = True
            Case 112
                path = Form1.FilePath & "\graphics\npc\npc-220.png"


                gfxHeight = 128
                Animated = True
            Case 113
                path = Form1.FilePath & "\graphics\npc\npc-218.png"


                gfxHeight = 128
                Animated = True
            Case 114
                path = Form1.FilePath & "\graphics\npc\npc-219.png"


                gfxHeight = 128
                Animated = True
            Case 115
                path = Form1.FilePath & "\graphics\npc\npc-221.png"

            Case 116
                path = Form1.FilePath & "\graphics\npc\npc-154.png"

            Case 117
                path = Form1.FilePath & "\graphics\npc\npc-155.png"

            Case 118
                path = Form1.FilePath & "\graphics\npc\npc-156.png"

            Case 119
                path = Form1.FilePath & "\graphics\npc\npc-157.png"

            Case 120
                path = Form1.FilePath & "\graphics\npc\npc-138.png"


                gfxWidth = 28
                NPCW = 28
                gfxHeight = 224
                Animated = True
            Case 121
                path = Form1.FilePath & "\graphics\npc\npc-134.png"


                gfxWidth = 40
                NPCW = 40
                gfxHeight = 120
                NPCH = 40
                Animated = True
            Case 122
                path = Form1.FilePath & "\graphics\npc\npc-241.png"


                gfxHeight = 256
                Animated = True
            Case 123
                path = Form1.FilePath & "\graphics\npc\npc-240.png"

            Case 124
                path = Form1.FilePath & "\graphics\npc\npc-249.png"

            Case 125
                path = Form1.FilePath & "\graphics\npc\npc-41.png"


                gfxHeight = 256
                Animated = True
            Case 126
                path = Form1.FilePath & "\graphics\npc\npc-39.png"


                gfxHeight = 360
                NPCH = 72
                gfxWidth = 40
                NPCW = 40
                FrameStyle = 1
            Case 127
                path = Form1.FilePath & "\graphics\npc\npc-201.png"


                gfxHeight = 752
                NPCH = 94
                gfxWidth = 80
                NPCW = 80
                FrameStyle = 1
                'Animated = True
            Case 128
                path = Form1.FilePath & "\graphics\npc\npc-262.png"


                gfxHeight = 448
                NPCH = 64
                gfxWidth = 48
                NPCW = 48
                FrameStyle = 1
                'Animated = True
            Case 129
                path = Form1.FilePath & "\graphics\npc\npc-288.png"


                gfxHeight = 128
                Animated = True
            Case 130
                path = Form1.FilePath & "\graphics\npc\npc-289.png"


                gfxHeight = 64
                NPCH = 64
            Case 131
                path = Form1.FilePath & "\graphics\npc\npc-89.png"


                gfxHeight = 64
                Animated = True
            Case 132
                path = Form1.FilePath & "\graphics\npc\npc-27.png"


                gfxHeight = 64
                Animated = True
            Case 133
                path = Form1.FilePath & "\graphics\npc\npc-29.png"


                gfxHeight = 144
                NPCH = 48
                FrameStyle = 1
                Animated = True
            Case 134
                path = Form1.FilePath & "\graphics\npc\npc-153.png"

            Case 135
                path = Form1.FilePath & "\graphics\npc\npc-93.png"


                gfxHeight = 96
                NPCH = 48
                Animated = True
            Case 136
                path = Form1.FilePath & "\graphics\npc\npc-175.png"


                gfxHeight = 96
                NPCH = 48
                FrameStyle = 1
                Animated = True
            Case 137
                path = Form1.FilePath & "\graphics\npc\npc-177.png"


                gfxHeight = 96
                NPCH = 48
                FrameStyle = 1
                Animated = True
            Case 138
                path = Form1.FilePath & "\graphics\npc\npc-173.png"


                gfxHeight = 96
                NPCH = 48
                FrameStyle = 1
                Animated = True
            Case 139
                path = Form1.FilePath & "\graphics\npc\npc-176.png"


                gfxHeight = 96
                NPCH = 48
                FrameStyle = 1
                Animated = True
            Case 140
                path = Form1.FilePath & "\graphics\npc\npc-260.png"


                gfxWidth = 16
                NPCW = 16
                gfxHeight = 64
                NPCH = 16
                FrameSpeed = 4
                Animated = True
            Case 141
                path = Form1.FilePath & "\graphics\npc\npc-106.png"


                gfxHeight = 16
                NPCH = 16
                gfxWidth = 128
                NPCW = 128
            Case 142
                path = Form1.FilePath & "\graphics\npc\npc-200.png"


                gfxHeight = 360
                NPCH = 72
                gfxWidth = 64
                NPCW = 64
                FrameStyle = 1
                Animated = True
            Case 143
                path = Form1.FilePath & "\graphics\npc\npc-235.png"


                gfxHeight = 96
                NPCH = 48
                gfxWidth = 32
                NPCW = 32
            Case 144
                path = Form1.FilePath & "\graphics\npc\npc-233.png"


                gfxHeight = 64
                FrameStyle = 1
                Animated = True
            Case 145
                path = Form1.FilePath & "\graphics\npc\npc-28.png"


                gfxHeight = 64
                FrameStyle = 1
                Animated = True
            Case 146
                path = Form1.FilePath & "\graphics\npc\npc-184.png"

            Case 147
                path = Form1.FilePath & "\graphics\npc\npc-182.png"


                gfxHeight = 128
                Animated = True
            Case 148
                path = Form1.FilePath & "\graphics\npc\npc-88.png"


                gfxWidth = 20
                NPCW = 20
                gfxHeight = 128
                Animated = True
            Case 149
                path = Form1.FilePath & "\graphics\npc\npc-178.png"


                gfxHeight = 96
                Animated = True
            Case 150
                path = Form1.FilePath & "\graphics\npc\npc-186.png"

            Case 151
                path = Form1.FilePath & "\graphics\npc\npc-172.png"


                gfxHeight = 112
                NPCH = 28
            Case 152
                path = Form1.FilePath & "\graphics\npc\npc-174.png"


                gfxHeight = 112
                NPCH = 28
            Case 153
                path = Form1.FilePath & "\graphics\npc\npc-223.png"


                gfxHeight = 24
                NPCH = 24
            Case 154
                path = Form1.FilePath & "\graphics\npc\npc-222.png"

            Case 155
                path = Form1.FilePath & "\graphics\npc\npc-165.png"


                gfxHeight = 64

                Animated = True

                FrameStyle = 1
            Case 156
                path = Form1.FilePath & "\graphics\npc\npc-162.png"


                gfxWidth = 40
                NPCW = 40
                gfxHeight = 128
                NPCH = 64

                Animated = True

                FrameStyle = 1
            Case 157
                path = Form1.FilePath & "\graphics\npc\npc-43.png"

                gfxHeight = 64

                FrameStyle = 1
            Case 158
                path = Form1.FilePath & "\graphics\npc\npc-18.png"


                gfxWidth = 128
                NPCW = 128
                gfxHeight = 128
                NPCH = 128

                FrameStyle = 1
            Case 159
                path = Form1.FilePath & "\graphics\npc\npc-181.png"


                gfxWidth = 48
                NPCW = 48
                gfxHeight = 46
                NPCH = 46

                FrameStyle = 1
            Case 160
                path = Form1.FilePath & "\graphics\npc\npc-270.png"


                gfxHeight = 168
                NPCH = 42

                Animated = True
            Case 161
                path = Form1.FilePath & "\graphics\npc\npc-286.png"


                gfxHeight = 64

                Animated = True
            Case 162
                path = Form1.FilePath & "\graphics\npc\npc-271.png"

            Case 163
                path = Form1.FilePath & "\graphics\npc\npc-166.png"


                gfxHeight = 64

                Animated = True
                FrameStyle = 1
            Case 164
                path = Form1.FilePath & "\graphics\npc\npc-163.png"


                gfxHeight = 64
                NPCH = 32

                Animated = True
                FrameStyle = 1
            Case 165
                path = Form1.FilePath & "\graphics\npc\npc-42.png"


                gfxHeight = 64
                NPCH = 32

                Animated = True
                FrameStyle = 1
            Case 166
                path = Form1.FilePath & "\graphics\npc\npc-164.png"


                gfxHeight = 128
                NPCH = 64
                gfxWidth = 64
                NPCW = 64

                Animated = True
                FrameStyle = 1
            Case 167
                path = Form1.FilePath & "\graphics\npc\npc-179.png"


                gfxHeight = 128
                NPCH = 64
                gfxWidth = 64
                NPCW = 64

                Animated = True
            Case 168
                path = Form1.FilePath & "\graphics\npc\npc-207.png"


                gfxHeight = 64
                NPCH = 32

                Animated = True

                FrameStyle = 1
            Case 169
                path = Form1.FilePath & "\graphics\npc\npc-285.png"


                gfxHeight = 64
                NPCH = 32

                Animated = True

                FrameStyle = 1
            Case 170
                path = Form1.FilePath & "\graphics\npc\npc-167.png"


                gfxWidth = 66
                NPCW = 66
                gfxHeight = 200
                NPCH = 50

                Animated = True

                FrameStyle = 1
            Case 171
                path = Form1.FilePath & "\graphics\npc\npc-77.png"


                gfxHeight = 64

                Animated = True

                FrameStyle = 1
            Case 172
                path = Form1.FilePath & "\graphics\npc\npc-44.png"


                gfxWidth = 140
                NPCW = 140
                gfxHeight = 256
                NPCH = 128

                FrameStyle = 1
            Case 173
                path = Form1.FilePath & "\graphics\npc\npc-180.png"


                gfxWidth = 48
                NPCW = 48
                gfxHeight = 64
                NPCH = 64
            Case 174
                path = Form1.FilePath & "\graphics\npc\npc-189.png"


                gfxWidth = 48
                NPCW = 48
                gfxHeight = 128
                NPCH = 64

                Animated = True

                FrameStyle = 1
            Case 175
                path = Form1.FilePath & "\graphics\npc\npc-199.png"


                gfxWidth = 130
                NPCW = 130
                gfxHeight = 128
                NPCH = 64

                Animated = True

                FrameStyle = 1
            Case 176
                path = Form1.FilePath & "\graphics\npc\npc-275.png"


                gfxWidth = 64
                NPCW = 64
            Case 177
                path = Form1.FilePath & "\graphics\npc\npc-109.png"


                gfxHeight = 108
                NPCH = 54

                FrameStyle = 1

                Animated = True
            Case 178
                path = Form1.FilePath & "\graphics\npc\npc-110.png"


                gfxHeight = 108
                NPCH = 54

                FrameStyle = 1

                Animated = True
            Case 179
                path = Form1.FilePath & "\graphics\npc\npc-111.png"


                gfxHeight = 108
                NPCH = 54

                FrameStyle = 1

                Animated = True
            Case 180
                path = Form1.FilePath & "\graphics\npc\npc-112.png"


                gfxHeight = 108
                NPCH = 54

                FrameStyle = 1

                Animated = True
            Case 181
                path = Form1.FilePath & "\graphics\editor\npc-194.png"


                gfxHeight = 128

                Animated = True
            Case 182
                path = Form1.FilePath & "\graphics\npc\npc-113.png"

            Case 183
                path = Form1.FilePath & "\graphics\npc\npc-114.png"

            Case 184
                path = Form1.FilePath & "\graphics\npc\npc-115.png"

            Case 185
                path = Form1.FilePath & "\graphics\npc\npc-116.png"

            Case 186
                path = Form1.FilePath & "\graphics\npc\npc-121.png"


                gfxWidth = 56
                NPCW = 56
                gfxHeight = 112
                NPCH = 56

                FrameStyle = 1

                Animated = True
            Case 187
                path = Form1.FilePath & "\graphics\npc\npc-123.png"


                gfxWidth = 56
                NPCW = 56
                gfxHeight = 112
                NPCH = 56

                FrameStyle = 1

                Animated = True
            Case 188
                path = Form1.FilePath & "\graphics\npc\npc-117.png"


                gfxHeight = 160

                FrameStyle = 1
            Case 189
                path = Form1.FilePath & "\graphics\npc\npc-118.png"


                gfxHeight = 160

                FrameStyle = 1
            Case 190
                path = Form1.FilePath & "\graphics\npc\npc-119.png"


                gfxHeight = 160

                FrameStyle = 1
            Case 191
                path = Form1.FilePath & "\graphics\npc\npc-120.png"


                gfxHeight = 160

                FrameStyle = 1
            Case 192
                path = Form1.FilePath & "\graphics\npc\npc-122.png"


                gfxWidth = 56
                NPCW = 56
                gfxHeight = 112
                NPCH = 56

                FrameStyle = 1

                Animated = True
            Case 193
                path = Form1.FilePath & "\graphics\npc\npc-124.png"


                gfxWidth = 56
                NPCW = 56
                gfxHeight = 112
                NPCH = 56

                FrameStyle = 1

                Animated = True
            Case 194
                path = Form1.FilePath & "\graphics\npc\npc-60.png"


                gfxWidth = 96
                NPCW = 96

                FrameStyle = 1
            Case 195
                path = Form1.FilePath & "\graphics\npc\npc-64.png"


                gfxWidth = 96
                NPCW = 96

                FrameStyle = 1
            Case 196
                path = Form1.FilePath & "\graphics\npc\npc-62.png"


                gfxWidth = 96
                NPCW = 96

                FrameStyle = 1
            Case 197
                path = Form1.FilePath & "\graphics\npc\npc-66.png"


                gfxWidth = 96
                NPCW = 96

                FrameStyle = 1
            Case 198
                path = Form1.FilePath & "\graphics\npc\npc-105.png"


                gfxWidth = 128
                NPCW = 128
                gfxHeight = 22
            Case 199
                path = Form1.FilePath & "\graphics\npc\npc-190.png"


                gfxHeight = 64

                Animated = True
            Case 200
                path = Form1.FilePath & "\graphics\npc\npc-31.png"


                FrameStyle = 1
            Case 201
                path = Form1.FilePath & "\graphics\npc\npc-197.png"


                gfxWidth = 48
                NPCW = 48
                gfxHeight = 16
                NPCH = 16
            Case 202
                path = Form1.FilePath & "\graphics\npc\npc-196.png"


                gfxHeight = 64

                Animated = True
            Case 203
                path = Form1.FilePath & "\graphics\npc\npc-227.png"


                gfxHeight = 64

                Animated = True
            Case 204
                path = Form1.FilePath & "\graphics\npc\npc-224.png"

            Case 205
                path = Form1.FilePath & "\graphics\npc\npc-234.png"


                gfxWidth = 48
                NPCW = 48
                gfxHeight = 96

                Animated = True

                FrameStyle = 1
            Case 206
                path = Form1.FilePath & "\graphics\npc\npc-232.png"


                gfxHeight = 64

                Animated = True

                FrameStyle = 1
            Case 207
                path = Form1.FilePath & "\graphics\npc\npc-236.png"


                gfxHeight = 64

                Animated = True

                FrameStyle = 1
            Case 208
                path = Form1.FilePath & "\graphics\npc\npc-280.png"


                gfxWidth = 64
                NPCW = 64
                gfxHeight = 320
                NPCH = 64

                FrameStyle = 1
            Case 209
                path = Form1.FilePath & "\graphics\npc\npc-151.png"


                gfxWidth = 48
                NPCW = 48
                gfxWidth = 48
                NPCH = 48
            Case 210
                path = Form1.FilePath & "\graphics\npc\npc-192.png"

            Case 211
                path = Form1.FilePath & "\graphics\npc\npc-95.png"


                gfxWidth = 72
                NPCW = 72
                gfxHeight = 56
                NPCH = 56

                FrameStyle = 1
            Case 212
                path = Form1.FilePath & "\graphics\npc\npc-98.png"


                gfxWidth = 72
                NPCW = 72
                gfxHeight = 56
                NPCH = 56

                FrameStyle = 1
            Case 213
                path = Form1.FilePath & "\graphics\npc\npc-99.png"


                gfxWidth = 72
                NPCW = 72
                gfxHeight = 56
                NPCH = 56

                FrameStyle = 1
            Case 214
                path = Form1.FilePath & "\graphics\npc\npc-100.png"


                gfxWidth = 72
                NPCW = 72
                gfxHeight = 56
                NPCH = 56

                FrameStyle = 1
            Case 215
                path = Form1.FilePath & "\graphics\npc\npc-148.png"


                gfxWidth = 72
                NPCW = 72
                gfxHeight = 56
                NPCH = 56

                FrameStyle = 1
            Case 216
                path = Form1.FilePath & "\graphics\npc\npc-149.png"


                gfxWidth = 72
                NPCW = 72
                gfxHeight = 56
                NPCH = 56

                FrameStyle = 1
            Case 217
                path = Form1.FilePath & "\graphics\npc\npc-150.png"


                gfxWidth = 72
                NPCW = 72
                gfxHeight = 56
                NPCH = 56

                FrameStyle = 1
            Case 218
                path = Form1.FilePath & "\graphics\npc\npc-228.png"


                gfxWidth = 72
                NPCW = 72
                gfxHeight = 56
                NPCH = 56

                FrameStyle = 1
            Case 219
                path = Form1.FilePath & "\graphics\npc\npc-185.png"

            Case 220
                path = Form1.FilePath & "\graphics\npc\npc-183.png"


                gfxHeight = 64

                Animated = True
            Case 221
                path = Form1.FilePath & "\graphics\npc\npc-187.png"

            Case 222
                path = Form1.FilePath & "\graphics\npc\npc-188.png"

            Case 223
                path = Form1.FilePath & "\graphics\npc\npc-33.png"


                gfxWidth = 24
                NPCW = 24
                gfxHeight = 128

                Animated = True
            Case 224
                path = Form1.FilePath & "\graphics\npc\npc-258.png"


                gfxWidth = 24
                NPCW = 24
                gfxHeight = 128

                Animated = True
            Case 225
                path = Form1.FilePath & "\graphics\npc\npc-96.png"

            Case 226
                path = Form1.FilePath & "\graphics\npc\npc-26.png"

            Case 227
                path = Form1.FilePath & "\graphics\npc\npc-56.png"


                gfxWidth = 128
                NPCW = 128
                gfxHeight = 512
                NPCH = 128

                Animated = True

                FrameStyle = 1
            Case 228
                path = Form1.FilePath & "\graphics\editor\npc-195.png"


                gfxHeight = 128

                Animated = True
            Case 229
                path = Form1.FilePath & "\graphics\npc\npc-32.png"

            Case 230
                path = Form1.FilePath & "\graphics\npc\npc-239.png"

            Case 231
                path = Form1.FilePath & "\graphics\npc\npc-274.png"


                gfxHeight = 200
                NPCH = 50

                Animated = True
            Case 232
                path = Form1.FilePath & "\graphics\npc\npc-277.png"


                gfxHeight = 64

                Animated = True
            Case 233
                path = Form1.FilePath & "\graphics\npc\npc-278.png"


                gfxHeight = 176
                NPCH = 44

                Animated = True
            Case 234
                path = Form1.FilePath & "\graphics\npc\npc-279.png"


                gfxWidth = 96
                NPCW = 96
                gfxHeight = 176
                NPCH = 44

                Animated = True

                FrameStyle = 1
            Case 235
                path = Form1.FilePath & "\graphics\npc\npc-127.png"


                gfxHeight = 52
                NPCH = 26

                Animated = True
            Case 236
                path = Form1.FilePath & "\graphics\npc\npc-126.png"


                gfxHeight = 52
                NPCH = 26

                Animated = True
            Case 237
                path = Form1.FilePath & "\graphics\npc\npc-128.png"


                gfxHeight = 52
                NPCH = 26

                Animated = True
            Case 238
                path = Form1.FilePath & "\graphics\npc\npc-125.png"


                gfxWidth = 36
                NPCW = 36
                gfxHeight = 132
                NPCH = 66

                FrameStyle = 1
            Case 239
                path = Form1.FilePath & "\graphics\npc\npc-211.png"


                gfxHeight = 192

                Animated = True
            Case 240
                path = Form1.FilePath & "\graphics\npc\npc-242.png"


                gfxHeight = 64

                Animated = True
            Case 241
                path = Form1.FilePath & "\graphics\npc\npc-243.png"


                gfxWidth = 56
                NPCW = 56
                gfxHeight = 72
                NPCH = 36

                Animated = True
            Case 242
                path = Form1.FilePath & "\graphics\npc\npc-203.png"


                gfxWidth = 46
                NPCW = 46
                gfxHeight = 104
                NPCH = 26

                Animated = True

                FrameStyle = 1
            Case 243
                path = Form1.FilePath & "\graphics\npc\npc-204.png"


                gfxWidth = 112
                NPCW = 112
                gfxHeight = 112
                NPCH = 28

                Animated = True

                FrameStyle = 1
            Case 244
                path = Form1.FilePath & "\graphics\npc\npc-205.png"


                gfxWidth = 44
                NPCW = 44
                gfxHeight = 220
                NPCH = 44

                Animated = True
            Case 245
                path = Form1.FilePath & "\graphics\npc\npc-168.png"


                gfxHeight = 138
                NPCH = 46

                FrameStyle = 1
            Case 246
                path = Form1.FilePath & "\graphics\npc\npc-256.png"


                gfxWidth = 48
                NPCW = 48
                gfxHeight = 256
                NPCH = 128

                Animated = True
            Case 247
                path = Form1.FilePath & "\graphics\npc\npc-257.png"


                gfxWidth = 48
                NPCW = 48
                gfxHeight = 256
                NPCH = 128

                Animated = True
            Case 248
                path = Form1.FilePath & "\graphics\npc\npc-152.png"


                gfxHeight = 128

                Animated = True
            Case 249
                path = Form1.FilePath & "\graphics\npc\npc-250.png"

            Case 250
                path = Form1.FilePath & "\graphics\npc\npc-252.png"


                gfxWidth = 16
                NPCW = 16
                gfxHeight = 96

                Animated = True
            Case 251
                path = Form1.FilePath & "\graphics\npc\npc-254.png"

            Case 252
                path = Form1.FilePath & "\graphics\npc\npc-158.png"


                gfxHeight = 84
                NPCH = 42

                Animated = True

                FrameStyle = 1
            Case 253
                path = Form1.FilePath & "\graphics\npc\npc-251.png"


                gfxWidth = 16
                NPCW = 16
                gfxHeight = 96

                Animated = True
            Case 254
                path = Form1.FilePath & "\graphics\npc\npc-253.png"


                gfxWidth = 16
                NPCW = 16
                gfxHeight = 96

                Animated = True
            Case 255
                path = Form1.FilePath & "\graphics\npc\npc-255.png"


                gfxWidth = 20
                NPCW = 20
                gfxHeight = 96
                NPCH = 96
            Case 256
                path = Form1.FilePath & "\graphics\npc\npc-102.png"


                gfxHeight = 64
                NPCH = 64

                FrameStyle = 1
            Case 257
                path = Form1.FilePath & "\graphics\npc\npc-107.png"


                gfxWidth = 48
                NPCW = 48
                gfxHeight = 152
                NPCH = 38

                FrameStyle = 1
            Case 258
                path = Form1.FilePath & "\graphics\npc\npc-208.png"


                gfxWidth = 128
                NPCW = 128
                gfxHeight = 128
                NPCH = 128

                MetroidGlass = True
            Case 259
                path = Form1.FilePath & "\graphics\npc\npc-209.png"


                gfxWidth = 96
                NPCW = 96
                gfxHeight = 212
                NPCH = 106

                FrameStyle = 1
            Case 260
                path = Form1.FilePath & "\graphics\npc\npc-59.png"


                gfxHeight = 64

                Animated = True
            Case 261
                path = Form1.FilePath & "\graphics\npc\npc-61.png"

                gfxHeight = 64

                Animated = True
            Case 262
                path = Form1.FilePath & "\graphics\npc\npc-63.png"

                gfxHeight = 64

                Animated = True
            Case 263
                path = Form1.FilePath & "\graphics\npc\npc-65.png"


                gfxHeight = 64

                Animated = True
        End Select

        TotalFrames = gfxHeight / NPCH

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
