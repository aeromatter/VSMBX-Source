Public Structure Player1Data
    Public PlayerID As Integer
    Public PlayerW As Integer
    Public PlayerH As Integer
    Public Graphic As Image
    Public PlayerState As Integer
End Structure

Public Structure Player2Data
    Public PlayerID As Integer
    Public PlayerW As Integer
    Public PlayerH As Integer
    Public Graphic As Image
    Public PlayerState As Integer
End Structure

Public Class Player
    Public Shared PlayerID As Integer = 0
    Public Shared Player2ID As Integer = 1
    Public Shared Graphic As Image
    Public Shared Graphic2 As Image
    Public Shared PlayerW As Integer
    Public Shared Player2W As Integer
    Public Shared PlayerH As Integer
    Public Shared Player2H As Integer
    Public MoveSpeed As Integer
    Public Shared PlayerState As Integer = 2
    Public Shared Player2State As Integer = 2
    Public PlayerMount As Integer
    Public JumpHeight As Integer
    Public JumpSpeed As Integer

    Public Shared P1 As Player1Data
    Public Shared P2 As Player2Data

    Public Shared Sub SetPlayer()
        Select Case PlayerID
            Case 0
                'Mario
                Graphic = New Bitmap(Form1.FilePath & "\graphics\mario\mario-" & PlayerState & ".png")
            Case 1
                'Luigi
                Graphic = New Bitmap(Form1.FilePath & "\graphics\luigi\luigi-" & PlayerState & ".png")
            Case 2
                'Peach
                Graphic = New Bitmap(Form1.FilePath & "\graphics\peach\peach-" & PlayerState & ".png")
            Case 3
                'Toad
                Graphic = New Bitmap(Form1.FilePath & "\graphics\toad\toad-" & PlayerState & ".png")
            Case 4
                'Link
                Graphic = New Bitmap(Form1.FilePath & "\graphics\link\link-" & PlayerState & ".png")
        End Select

        Select Case PlayerState
            Case 1
                'Small
                If PlayerID = 0 Then
                    PlayerW = 26
                    PlayerH = 30
                ElseIf PlayerID = 1 Then
                    PlayerW = 30
                    PlayerH = 32
                ElseIf PlayerID = 2 Then
                    PlayerW = 28
                    PlayerH = 44
                ElseIf PlayerID = 3 Then
                    PlayerW = 30
                    PlayerH = 38
                ElseIf PlayerID = 4 Then

                End If
            Case 2
                'Super
                If PlayerID = 0 Then
                    PlayerW = 32
                    PlayerH = 54
                ElseIf PlayerID = 1 Then
                    PlayerW = 32
                    PlayerH = 62
                ElseIf PlayerID = 2 Then
                    PlayerW = 34
                    PlayerH = 64
                ElseIf PlayerID = 3 Then
                    PlayerW = 34
                    PlayerH = 54
                ElseIf PlayerID = 4 Then

                End If
            Case 3
                'Fire
                If PlayerID = 0 Then
                    PlayerW = 32
                    PlayerH = 54
                ElseIf PlayerID = 1 Then
                    PlayerW = 32
                    PlayerH = 62
                ElseIf PlayerID = 2 Then
                    PlayerW = 34
                    PlayerH = 64
                ElseIf PlayerID = 3 Then
                    PlayerW = 34
                    PlayerH = 54
                ElseIf PlayerID = 4 Then

                End If
            Case 4
                'Leaf
                If PlayerID = 0 Then
                    PlayerW = 46
                    PlayerH = 56
                ElseIf PlayerID = 1 Then
                    PlayerW = 46
                    PlayerH = 64
                ElseIf PlayerID = 2 Then
                    PlayerW = 46
                    PlayerH = 64
                ElseIf PlayerID = 3 Then
                    PlayerW = 46
                    PlayerH = 54
                ElseIf PlayerID = 4 Then

                End If
            Case 5
                'Tanooki
                If PlayerID = 0 Then
                    PlayerW = 46
                    PlayerH = 56
                ElseIf PlayerID = 1 Then
                    PlayerW = 46
                    PlayerH = 64
                ElseIf PlayerID = 2 Then
                    PlayerW = 46
                    PlayerH = 68
                ElseIf PlayerID = 3 Then
                    PlayerW = 46
                    PlayerH = 54
                ElseIf PlayerID = 4 Then

                End If
            Case 6
                'Hammer
                If PlayerID = 0 Then
                    PlayerW = 46
                    PlayerH = 56
                ElseIf PlayerID = 1 Then
                    PlayerW = 32
                    PlayerH = 62
                ElseIf PlayerID = 2 Then
                    PlayerW = 40
                    PlayerH = 64
                ElseIf PlayerID = 3 Then
                    PlayerW = 36
                    PlayerH = 52
                ElseIf PlayerID = 4 Then

                End If
            Case 7
                'Ice
                If PlayerID = 0 Then
                    PlayerW = 32
                    PlayerH = 54
                ElseIf PlayerID = 1 Then
                    PlayerW = 32
                    PlayerH = 62
                ElseIf PlayerID = 2 Then
                    PlayerW = 34
                    PlayerH = 64
                ElseIf PlayerID = 3 Then
                    PlayerW = 34
                    PlayerH = 54
                ElseIf PlayerID = 4 Then

                End If
        End Select

        Play.PlayerBox = New Rectangle(Play.PlayerX, Play.PlayerY, PlayerW, PlayerH)
        Play.MaintainLevelBounds()
    End Sub

End Class
