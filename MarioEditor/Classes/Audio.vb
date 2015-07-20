Imports System.Drawing
Imports MarioEditor.libZPlay
Public Class Audio

    Public Shared PlaySFX As New ZPlay()

    Public Shared Sub PlaySound(ID As Integer)
        Select Case ID
            Case 0
                PlayAudio(Form1.FilePath & "\sound\block-smash.ogg")
            Case 1
                PlayAudio(Form1.FilePath & "\sound\smash.ogg")
            Case 2
                PlayAudio(Form1.FilePath & "\sound\shell-hit.ogg")
            Case 3
                PlayAudio(Form1.FilePath & "\sound\level-select.ogg")
            Case 4
                PlayAudio(Form1.FilePath & "\sound\grab.ogg")
            Case 5
                PlayAudio(Form1.FilePath & "\sound\has-item.ogg")
            Case 6
                'Needs Conversion
                PlayAudio(Form1.FilePath & "\sound\thwomp.ogg")
        End Select
    End Sub

    Public Shared Sub PlayAudio(sound As String)
        PlaySFX.StopPlayback()
        PlaySFX.OpenFile(sound, TStreamFormat.sfAutodetect)
        PlaySFX.StartPlayback()
    End Sub
End Class
