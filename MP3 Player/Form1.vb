Imports System.IO
Imports System.Reflection.Emit
Imports WMPLib
Imports Shell32
Imports System.Net.Security
Public Class Form1
    Dim Player As WindowsMediaPlayer = New WindowsMediaPlayer
    Dim SongID As Integer = 1
    Dim directory As String = ""
    Dim dirList(0) As String
    Dim mainDirectory As String = ""
    Dim PlaylistLen As Integer = 0
    Dim progressSong As Byte = 1
    Dim renamingFile As Boolean = False
    Private Sub UpdateProgressBounds()
        TrackBar1.Minimum = 0
        TrackBar1.Maximum = Player.currentMedia.duration
    End Sub
    Private Sub UpdateProgress()
        Try
            TrackBar1.Value = Player.controls.currentPosition
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BackToStartBtn_Click(sender As Object, e As EventArgs) Handles BackToStartBtn.Click
        If SongID > 1 Then
            SongID -= 1
        Else
            SongID = PlaylistLen
        End If
        TrackNoBox.Text = SongID
        Player.controls.stop()
        displayName.Text = pathFromIndex(True)
        Player.URL = pathFromIndex(False)
        Player.controls.play()
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
        displayName.Text = pathFromIndex(True)
        Player.URL = pathFromIndex(False)
        Player.controls.play()
        Timer1.Start()
    End Sub

    Private Sub Restart_Click(sender As Object, e As EventArgs) Handles RestartBtn.Click
        Player.controls.stop()
        displayName.Text = pathFromIndex(True)
        Player.URL = pathFromIndex(False)
        Player.controls.play()
        Timer1.Start()
    End Sub


    Public Function pathFromIndex(displayName As Boolean) As String
        Try
BeforeDecrement:
            If SongID < 1 Then
                SongID = 1
            End If
            Dim songs() As String = File.ReadAllLines(directory)
            PlaylistLen = songs.GetUpperBound(0) - 4
            Dim song() As String = songs(SongID + 4).Split(";")
            If displayName Then
                If song.Length = 1 And File.Exists(Strings.Left(directory, Strings.InStrRev(directory, "\")) & "\" & song(0)) Then
                    renamingFile = True
                    Dim currentSongID As Integer = SongID
                    Dim promptTitle As String = ""
                    Dim Properties As Dictionary(Of Integer, KeyValuePair(Of String, String)) = GetFileProperties(Strings.Left(directory, Strings.InStrRev(directory, "\")) & "\" & song(0))
                    For Each FileProperty As KeyValuePair(Of Integer, KeyValuePair(Of String, String)) In Properties
                        If FileProperty.Value.Key = "Title" Then
                            promptTitle = FileProperty.Value.Value
                        End If
                    Next
                    Dim newTitle As String = InputBox("Song title for """ & song(0) & """:", "Song missing title", promptTitle)
                    songs(currentSongID + 4) = newTitle & ";" & song(0)
                    File.WriteAllLines(directory, songs)
                    renamingFile = False
                    GoTo BeforeDecrement
                Else
                    Return song(0)
                End If
            ElseIf song.Length = 1 Then
                MsgBox("Filepath missing for : """ & song(0) & """ in """ & directory & """")
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
    Public Function GetFileProperties(ByVal FileName As String) As Dictionary(Of Integer, KeyValuePair(Of String, String))
        Dim Shell As New Shell
        Dim Folder As Folder = Shell.[NameSpace](Path.GetDirectoryName(FileName))
        Dim File As FolderItem = Folder.ParseName(Path.GetFileName(FileName))
        Dim Properties As New Dictionary(Of Integer, KeyValuePair(Of String, String))()
        Dim Index As Integer
        Dim Keys As Integer = Folder.GetDetailsOf(File, 0).Count
        For Index = 0 To Keys - 1
            Dim CurrentKey As String = Folder.GetDetailsOf(Nothing, Index)
            Dim CurrentValue As String = Folder.GetDetailsOf(File, Index)
            If CurrentValue <> "" Then
                Properties.Add(Index, New KeyValuePair(Of String, String)(CurrentKey, CurrentValue))
            End If
        Next
        Return Properties
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mainPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\MP3Radio\"
        If File.Exists(mainPath & "Directory.dir") Then
            mainDirectory = mainPath & "Directory.dir"
        Else
            IO.Directory.CreateDirectory(mainPath)
            File.Create(mainPath & "Directory.dir")
            mainDirectory = mainPath & "Directory.dir"
        End If
        Dim directories() As String = File.ReadAllLines(mainDirectory)
        For Each value In directories
            dirList(dirList.GetUpperBound(0)) = value
            ReDim Preserve dirList(dirList.GetUpperBound(0) + 1)
            If IO.Path.GetExtension(value) = ".txt" Then
                'DomainUpDown1.Items.Add(IO.Path.GetFileNameWithoutExtension(value))
            End If
            populateToolStripMenu(SelectDirectoryToolStripMenuItem, value)
        Next
    End Sub
    Private Sub populateToolStripMenu(parentToolStripMenu As ToolStripMenuItem, path As String)
        Dim newToolStripMenuItem As New ToolStripMenuItem(IO.Path.GetFileNameWithoutExtension(path))
        If IO.Path.GetExtension(path) = ".dir" Then
            Dim directories() As String = File.ReadAllLines(path)
            For Each value In directories
                populateToolStripMenu(newToolStripMenuItem, value)
            Next
        Else
            newToolStripMenuItem.Checked = False
            newToolStripMenuItem.Tag = path
            AddHandler newToolStripMenuItem.Click, AddressOf toolStripClickHandler
        End If
        parentToolStripMenu.DropDownItems.Add(newToolStripMenuItem)
    End Sub
    Private Sub toolStripClickHandler(sender As Object, e As EventArgs)
        Dim toolstrip As ToolStripMenuItem = sender
        If toolstrip.Tag <> directory Then
            Try
                If File.Exists(toolstrip.Tag) Then
                    directory = toolstrip.Tag

                    displayName.Enabled = True
                    BackToStartBtn.Enabled = True
                    StopBtn.Enabled = True
                    PlayBtn.Enabled = True
                    SkipBtn.Enabled = True
                    RestartBtn.Enabled = True
                    Label1.Enabled = True
                    TrackNoBox.Enabled = True
                    Volume.Enabled = True
                    TrackBar1.Enabled = True
                    displayName.Text = pathFromIndex(True)
                    Player.URL = pathFromIndex(False)
                    Player.controls.stop()
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
            SongID = 0
            If Not Player.playState = 3 Then
                Player.controls.play()
                Timer1.Start()
            End If
        End If
    End Sub
    Private Sub Volume_Scroll(sender As Object, e As EventArgs) Handles Volume.Scroll
        Player.settings.volume = Volume.Value
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        UpdateProgressBounds()
        UpdateProgress()
        If Player.playState = 10 Or Player.playState = 1 And Not renamingFile Then
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
            displayName.Text = pathFromIndex(True)
            Player.URL = pathFromIndex(False)
            Player.controls.play()
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

    'Private Sub DomainUpDown1_SelectedItemChanged(sender As Object, e As EventArgs)
    '    Try
    '        If File.Exists(dirList(DomainUpDown1.SelectedIndex)) Then
    '            directory = dirList(DomainUpDown1.SelectedIndex)

    '            displayName.Enabled = True
    '            BackToStartBtn.Enabled = True
    '            StopBtn.Enabled = True
    '            PlayBtn.Enabled = True
    '            SkipBtn.Enabled = True
    '            RestartBtn.Enabled = True
    '            Label1.Enabled = True
    '            TrackNoBox.Enabled = True
    '            Volume.Enabled = True
    '            displayName.Text = pathFromIndex(True)
    '            Player.URL = pathFromIndex(False)
    '            Player.controls.stop()
    '        Else
    '            displayName.Enabled = False
    '            BackToStartBtn.Enabled = False
    '            StopBtn.Enabled = False
    '            PlayBtn.Enabled = False
    '            SkipBtn.Enabled = False
    '            RestartBtn.Enabled = False
    '            Label1.Enabled = False
    '            TrackNoBox.Enabled = False
    '            Volume.Enabled = False
    '        End If
    '    Catch ex As Exception
    '    End Try
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("notepad", """""" & mainDirectory & """""")
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            progressSong = 0
        Else
            progressSong = 1
        End If
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Player.controls.currentPosition = TrackBar1.Value
    End Sub
End Class
