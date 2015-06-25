Public Class Level
    Public Shared BGpath As String
    Public Shared BG2path As String
    Public Shared BG As Image
    Public Shared BG2 As Image
    Public Shared BGid As Integer
    Public Shared BGtype As Integer
    Public Shared Music As String = ""
    Public Shared Song As String = ""
    Public Shared LevelWrap As Boolean = False
    Public Shared OffscreenExit As Boolean = False
    Public Shared NoTurnBack As Boolean = False
    Public Shared Underwater As Boolean = False
    Public Shared LevelW As Integer = 25 * 32
    Public Shared LevelH As Integer = 19 * 32
    Public Shared HeightInc As Integer = 1
    Public Shared Time As Integer
    Public Shared TimeLeft As Integer
    Public Shared LevelPath As String = Form1.FilePath & "\worlds\"
    Public Shared P1start As Rectangle
    Public Shared P2start As Rectangle
    Public Shared Brightness As Integer = 100
End Class
