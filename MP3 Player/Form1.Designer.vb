<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Volume = New System.Windows.Forms.TrackBar()
        Me.RestartBtn = New System.Windows.Forms.Button()
        Me.TrackNoBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SkipBtn = New System.Windows.Forms.Button()
        Me.PlayBtn = New System.Windows.Forms.Button()
        Me.StopBtn = New System.Windows.Forms.Button()
        Me.BackToStartBtn = New System.Windows.Forms.Button()
        Me.displayName = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SelectDirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.Volume, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(147, 82)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(76, 17)
        Me.CheckBox1.TabIndex = 23
        Me.CheckBox1.Text = "Loop song"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(109, 77)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Edit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Volume
        '
        Me.Volume.Enabled = False
        Me.Volume.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Volume.LargeChange = 10
        Me.Volume.Location = New System.Drawing.Point(3, 47)
        Me.Volume.Maximum = 100
        Me.Volume.Name = "Volume"
        Me.Volume.Size = New System.Drawing.Size(225, 45)
        Me.Volume.SmallChange = 5
        Me.Volume.TabIndex = 21
        Me.Volume.TickFrequency = 10
        Me.Volume.Value = 50
        '
        'RestartBtn
        '
        Me.RestartBtn.BackgroundImage = Global.MP3_Player.My.Resources.Resources.Restart
        Me.RestartBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RestartBtn.Enabled = False
        Me.RestartBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RestartBtn.Location = New System.Drawing.Point(70, 23)
        Me.RestartBtn.Name = "RestartBtn"
        Me.RestartBtn.Size = New System.Drawing.Size(23, 23)
        Me.RestartBtn.TabIndex = 20
        Me.RestartBtn.UseVisualStyleBackColor = True
        '
        'TrackNoBox
        '
        Me.TrackNoBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrackNoBox.Enabled = False
        Me.TrackNoBox.Location = New System.Drawing.Point(177, 25)
        Me.TrackNoBox.Name = "TrackNoBox"
        Me.TrackNoBox.ReadOnly = True
        Me.TrackNoBox.Size = New System.Drawing.Size(48, 20)
        Me.TrackNoBox.TabIndex = 18
        Me.TrackNoBox.Text = "1"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(116, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Track No."
        '
        'SkipBtn
        '
        Me.SkipBtn.BackgroundImage = Global.MP3_Player.My.Resources.Resources.Skip
        Me.SkipBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SkipBtn.Enabled = False
        Me.SkipBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.SkipBtn.Location = New System.Drawing.Point(93, 24)
        Me.SkipBtn.Name = "SkipBtn"
        Me.SkipBtn.Size = New System.Drawing.Size(23, 23)
        Me.SkipBtn.TabIndex = 17
        Me.SkipBtn.UseVisualStyleBackColor = True
        '
        'PlayBtn
        '
        Me.PlayBtn.BackgroundImage = Global.MP3_Player.My.Resources.Resources.Play
        Me.PlayBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PlayBtn.Enabled = False
        Me.PlayBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PlayBtn.Location = New System.Drawing.Point(47, 23)
        Me.PlayBtn.Name = "PlayBtn"
        Me.PlayBtn.Size = New System.Drawing.Size(23, 23)
        Me.PlayBtn.TabIndex = 16
        Me.PlayBtn.UseVisualStyleBackColor = True
        '
        'StopBtn
        '
        Me.StopBtn.BackgroundImage = Global.MP3_Player.My.Resources.Resources.Pause
        Me.StopBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StopBtn.Enabled = False
        Me.StopBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.StopBtn.Location = New System.Drawing.Point(24, 23)
        Me.StopBtn.Name = "StopBtn"
        Me.StopBtn.Size = New System.Drawing.Size(23, 23)
        Me.StopBtn.TabIndex = 15
        Me.StopBtn.UseVisualStyleBackColor = True
        '
        'BackToStartBtn
        '
        Me.BackToStartBtn.BackgroundImage = Global.MP3_Player.My.Resources.Resources.Rewind
        Me.BackToStartBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BackToStartBtn.Enabled = False
        Me.BackToStartBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BackToStartBtn.Location = New System.Drawing.Point(1, 23)
        Me.BackToStartBtn.Name = "BackToStartBtn"
        Me.BackToStartBtn.Size = New System.Drawing.Size(23, 23)
        Me.BackToStartBtn.TabIndex = 13
        Me.BackToStartBtn.UseVisualStyleBackColor = True
        '
        'displayName
        '
        Me.displayName.Enabled = False
        Me.displayName.Location = New System.Drawing.Point(0, 2)
        Me.displayName.Name = "displayName"
        Me.displayName.ReadOnly = True
        Me.displayName.Size = New System.Drawing.Size(232, 20)
        Me.displayName.TabIndex = 12
        Me.displayName.Text = "Off"
        '
        'Timer1
        '
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectDirectoryToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(-1, 76)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(108, 24)
        Me.MenuStrip1.TabIndex = 24
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SelectDirectoryToolStripMenuItem
        '
        Me.SelectDirectoryToolStripMenuItem.Name = "SelectDirectoryToolStripMenuItem"
        Me.SelectDirectoryToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.SelectDirectoryToolStripMenuItem.Text = "Select directory"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(232, 103)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Volume)
        Me.Controls.Add(Me.RestartBtn)
        Me.Controls.Add(Me.TrackNoBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SkipBtn)
        Me.Controls.Add(Me.PlayBtn)
        Me.Controls.Add(Me.StopBtn)
        Me.Controls.Add(Me.BackToStartBtn)
        Me.Controls.Add(Me.displayName)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(248, 142)
        Me.MinimumSize = New System.Drawing.Size(248, 142)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "MP3 Player"
        CType(Me.Volume, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Volume As TrackBar
    Friend WithEvents RestartBtn As Button
    Friend WithEvents TrackNoBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SkipBtn As Button
    Friend WithEvents PlayBtn As Button
    Friend WithEvents StopBtn As Button
    Friend WithEvents BackToStartBtn As Button
    Friend WithEvents displayName As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SelectDirectoryToolStripMenuItem As ToolStripMenuItem
End Class
