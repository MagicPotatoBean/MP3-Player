Imports System.IO
Imports System.Reflection.Emit
Imports WMPLib

Public Class Form1
    Dim Player As WindowsMediaPlayer = New WindowsMediaPlayer
    Dim SongID As Integer = 1
    Dim directory As String = ""
    Dim dirList(0) As String
    Dim mainDirectory As String = ""
    Dim PlaylistLen As Integer = 0
    Dim progressSong As Byte = 1
    Private Sub BackToStartBtn_Click(sender As Object, e As EventArgs) Handles BackToStartBtn.Click
        If SongID > 1 Then
            SongID -= 1
        Else
            SongID = PlaylistLen
        End If
        TrackNoBox.Text = SongID
        Player.controls.stop()
        Player.URL = pathFromIndex(False)
        Player.controls.play()
        displayName.Text = pathFromIndex(True)
        Timer1.Start()
    End Sub

    Private Sub StopBtn_Click(sender As Object, e As EventArgs) Handles StopBtn.Click
        If Player.playState = 3 Then
            Player.controls.pause()
            Timer1.Stop()
        End If
    End Sub

    Private Sub PlayBtn_Click(sender As Object, e As EventArgs) Handles PlayBtn.Click
        If Not Player.playState = 3 Then
            Player.controls.play()
            Timer1.Start()
        End If
    End Sub

    Private Sub SkipBtn_Click(sender As Object, e As EventArgs) Handles SkipBtn.Click
        SongID += 1
        TrackNoBox.Text = SongID
        Player.controls.stop()
        Player.URL = pathFromIndex(False)
        Player.controls.play()
        displayName.Text = pathFromIndex(True)
        Timer1.Start()
    End Sub

    Private Sub Restart_Click(sender As Object, e As EventArgs) Handles RestartBtn.Click
        Player.controls.stop()
        Player.URL = pathFromIndex(False)
        Player.controls.play()
        displayName.Text = pathFromIndex(True)
        Timer1.Start()
    End Sub


    Public Function pathFromIndex(displayName As Boolean) As String
        Try
BeforeDecrement:
            Dim songs() As String = File.ReadAllLines(directory)
            PlaylistLen = songs.GetUpperBound(0) - 4
            Dim song() As String = songs(SongID + 4).Split(";")
            If displayName Then
                Return song(0)
            Else

                If File.Exists(Strings.Left(directory, Strings.InStrRev(directory, "\")) & "\" & song(1)) Then
                    Return Strings.Left(directory, Strings.InStrRev(directory, "\")) & "\" & song(1)
                Else
                    MsgBox("File " & Strings.Left(directory, Strings.InStrRev(directory, "\")) & "\" & song(1) & " does not exist, so has been removed from the directory.")
                    File.WriteAllLines((Strings.Left(directory, Strings.InStrRev(directory, "\")) & "\" & "Directory.txt"), removeItem(songs, SongID + 4))
                    GoTo BeforeDecrement
                End If
            End If
        Catch ex As Exception
            SongID = 1
            TrackNoBox.Text = SongID
            GoTo BeforeDecrement
        End Try
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mainPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\MP3Radio\"
        If File.Exists(mainPath & "Directory.txt") Then
            mainDirectory = mainPath & "Directory.txt"
        Else
            IO.Directory.CreateDirectory(mainPath)
            File.Create(mainPath & "Directory.txt")
            mainDirectory = mainPath & "Directory.txt"
        End If
        Dim songs() As String = File.ReadAllLines(mainDirectory)
        For Each value In songs
            dirList(dirList.GetUpperBound(0)) = value
            ReDim Preserve dirList(dirList.GetUpperBound(0) + 1)
            DomainUpDown1.Items.Add(IO.Path.GetFileName(value))
        Next


    End Sub
    Private Sub Volume_Scroll(sender As Object, e As EventArgs) Handles Volume.Scroll
        Player.settings.volume = Volume.Value
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If Player.playState = 10 Or Player.playState = 1 Then
            Select Case SongID
                Case Is < 1
                    SongID = 1
                Case Is >= PlaylistLen
                    If progressSong = 0 Then
                        SongID += progressSong
                    Else
                        SongID = 1
                    End If
                Case Else
                    SongID += progressSong
            End Select
            TrackNoBox.Text = SongID
            Player.controls.stop()
            Player.URL = pathFromIndex(False)
            Player.controls.play()
            displayName.Text = pathFromIndex(True)
        End If

    End Sub

    Public Function removeItem(array() As String, index As Integer) As String()
        Dim newArray(array.GetUpperBound(0) - 1) As String
        If array.GetUpperBound(0) > 0 Then
            For ai = index + 1 To array.GetUpperBound(0)
                array(ai - 1) = array(ai)
            Next
            For ai = 0 To array.GetUpperBound(0) - 1
                newArray(ai) = array(ai)
            Next
            Return newArray
        Else
            MsgBox("Directory file empty")
            Application.Exit()
            Dim str As String() = {""}
            Return str
        End If
    End Function

    Private Sub DomainUpDown1_SelectedItemChanged(sender As Object, e As EventArgs) Handles DomainUpDown1.SelectedItemChanged
        Try
            If File.Exists(dirList(DomainUpDown1.SelectedIndex)) Then
                directory = dirList(DomainUpDown1.SelectedIndex)

                displayName.Enabled = True
                BackToStartBtn.Enabled = True
                StopBtn.Enabled = True
                PlayBtn.Enabled = True
                SkipBtn.Enabled = True
                RestartBtn.Enabled = True
                Label1.Enabled = True
                TrackNoBox.Enabled = True
                Volume.Enabled = True
                Player.URL = pathFromIndex(False)
                Player.controls.stop()
                displayName.Text = pathFromIndex(True)
            Else
                displayName.Enabled = False
                BackToStartBtn.Enabled = False
                StopBtn.Enabled = False
                PlayBtn.Enabled = False
                SkipBtn.Enabled = False
                RestartBtn.Enabled = False
                Label1.Enabled = False
                TrackNoBox.Enabled = False
                Volume.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("cmd", "/c start " & """""" & mainDirectory & """""")
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            progressSong = 0
        Else
            progressSong = 1
        End If
    End Sub
End Class
