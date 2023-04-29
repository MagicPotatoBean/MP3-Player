<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DomainUpDown1 = New System.Windows.Forms.DomainUpDown()
        Me.Volume = New System.Windows.Forms.TrackBar()
        Me.RestartBtn = New System.Windows.Forms.Button()
        Me.TrackNoBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SkipBtn = New System.Windows.Forms.Button()
        Me.PlayBtn = New System.Windows.Forms.Button()
        Me.StopBtn = New System.Windows.Forms.Button()
        Me.BackToStartBtn = New System.Windows.Forms.Button()
        Me.displayName = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Volume, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.DomainUpDown1)
        Me.GroupBox1.Controls.Add(Me.Volume)
        Me.GroupBox1.Controls.Add(Me.RestartBtn)
        Me.GroupBox1.Controls.Add(Me.TrackNoBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.SkipBtn)
        Me.GroupBox1.Controls.Add(Me.PlayBtn)
        Me.GroupBox1.Controls.Add(Me.StopBtn)
        Me.GroupBox1.Controls.Add(Me.BackToStartBtn)
        Me.GroupBox1.Controls.Add(Me.displayName)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(232, 120)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(109, 94)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Edit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DomainUpDown1
        '
        Me.DomainUpDown1.Location = New System.Drawing.Point(6, 95)
        Me.DomainUpDown1.Name = "DomainUpDown1"
        Me.DomainUpDown1.Size = New System.Drawing.Size(97, 20)
        Me.DomainUpDown1.TabIndex = 10
        Me.DomainUpDown1.Text = "Select Directory"
        '
        'Volume
        '
        Me.Volume.Enabled = False
        Me.Volume.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Volume.LargeChange = 10
        Me.Volume.Location = New System.Drawing.Point(3, 60)
        Me.Volume.Maximum = 100
        Me.Volume.Name = "Volume"
        Me.Volume.Size = New System.Drawing.Size(225, 45)
        Me.Volume.SmallChange = 5
        Me.Volume.TabIndex = 9
        Me.Volume.TickFrequency = 10
        Me.Volume.Value = 50
        '
        'RestartBtn
        '
        Me.RestartBtn.BackgroundImage = Global.MP3_Player.My.Resources.Resources.Play
        Me.RestartBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RestartBtn.Enabled = False
        Me.RestartBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RestartBtn.Location = New System.Drawing.Point(72, 36)
        Me.RestartBtn.Name = "RestartBtn"
        Me.RestartBtn.Size = New System.Drawing.Size(23, 23)
        Me.RestartBtn.TabIndex = 8
        Me.RestartBtn.UseVisualStyleBackColor = True
        '
        'TrackNoBox
        '
        Me.TrackNoBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrackNoBox.Enabled = False
        Me.TrackNoBox.Location = New System.Drawing.Point(178, 38)
        Me.TrackNoBox.Name = "TrackNoBox"
        Me.TrackNoBox.ReadOnly = True
        Me.TrackNoBox.Size = New System.Drawing.Size(48, 20)
        Me.TrackNoBox.TabIndex = 5
        Me.TrackNoBox.Text = "1"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(123, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Track No."
        '
        'SkipBtn
        '
        Me.SkipBtn.BackgroundImage = Global.MP3_Player.My.Resources.Resources.Skip
        Me.SkipBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SkipBtn.Enabled = False
        Me.SkipBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.SkipBtn.Location = New System.Drawing.Point(95, 36)
        Me.SkipBtn.Name = "SkipBtn"
        Me.SkipBtn.Size = New System.Drawing.Size(23, 23)
        Me.SkipBtn.TabIndex = 4
        Me.SkipBtn.UseVisualStyleBackColor = True
        '
        'PlayBtn
        '
        Me.PlayBtn.BackgroundImage = Global.MP3_Player.My.Resources.Resources.Restart
        Me.PlayBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PlayBtn.Enabled = False
        Me.PlayBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PlayBtn.Location = New System.Drawing.Point(49, 36)
        Me.PlayBtn.Name = "PlayBtn"
        Me.PlayBtn.Size = New System.Drawing.Size(23, 23)
        Me.PlayBtn.TabIndex = 3
        Me.PlayBtn.UseVisualStyleBackColor = True
        '
        'StopBtn
        '
        Me.StopBtn.BackgroundImage = Global.MP3_Player.My.Resources.Resources.Pause
        Me.StopBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StopBtn.Enabled = False
        Me.StopBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.StopBtn.Location = New System.Drawing.Point(26, 36)
        Me.StopBtn.Name = "StopBtn"
        Me.StopBtn.Size = New System.Drawing.Size(23, 23)
        Me.StopBtn.TabIndex = 2
        Me.StopBtn.UseVisualStyleBackColor = True
        '
        'BackToStartBtn
        '
        Me.BackToStartBtn.BackgroundImage = Global.MP3_Player.My.Resources.Resources.Rewind
        Me.BackToStartBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BackToStartBtn.Enabled = False
        Me.BackToStartBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BackToStartBtn.Location = New System.Drawing.Point(3, 36)
        Me.BackToStartBtn.Name = "BackToStartBtn"
        Me.BackToStartBtn.Size = New System.Drawing.Size(23, 23)
        Me.BackToStartBtn.TabIndex = 1
        Me.BackToStartBtn.UseVisualStyleBackColor = True
        '
        'displayName
        '
        Me.displayName.Dock = System.Windows.Forms.DockStyle.Top
        Me.displayName.Enabled = False
        Me.displayName.Location = New System.Drawing.Point(3, 16)
        Me.displayName.Name = "displayName"
        Me.displayName.ReadOnly = True
        Me.displayName.Size = New System.Drawing.Size(226, 20)
        Me.displayName.TabIndex = 0
        Me.displayName.Text = "Off"
        '
        'Timer1
        '
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(147, 98)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(76, 17)
        Me.CheckBox1.TabIndex = 11
        Me.CheckBox1.Text = "Loop song"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(232, 120)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximumSize = New System.Drawing.Size(248, 159)
        Me.MinimumSize = New System.Drawing.Size(248, 159)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "MP3 Player"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Volume, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DomainUpDown1 As DomainUpDown
    Friend WithEvents Volume As TrackBar
    Friend WithEvents RestartBtn As Button
    Friend WithEvents TrackNoBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SkipBtn As Button
    Friend WithEvents PlayBtn As Button
    Friend WithEvents StopBtn As Button
    Friend WithEvents BackToStartBtn As Button
    Friend WithEvents displayName As TextBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents CheckBox1 As CheckBox
End Class
