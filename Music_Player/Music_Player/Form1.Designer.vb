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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.preview_btn = New System.Windows.Forms.Button()
        Me.next_btn = New System.Windows.Forms.Button()
        Me.Play_btn = New System.Windows.Forms.Button()
        Me.pause_btn = New System.Windows.Forms.Button()
        Me.stop_btn = New System.Windows.Forms.Button()
        Me.open_btn = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.player = New AxWMPLib.AxWindowsMediaPlayer()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'preview_btn
        '
        Me.preview_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.preview_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.preview_btn.ForeColor = System.Drawing.Color.White
        Me.preview_btn.Location = New System.Drawing.Point(12, 316)
        Me.preview_btn.Name = "preview_btn"
        Me.preview_btn.Size = New System.Drawing.Size(91, 30)
        Me.preview_btn.TabIndex = 0
        Me.preview_btn.Text = "Preview"
        Me.preview_btn.UseVisualStyleBackColor = True
        '
        'next_btn
        '
        Me.next_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.next_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.next_btn.ForeColor = System.Drawing.Color.White
        Me.next_btn.Location = New System.Drawing.Point(118, 316)
        Me.next_btn.Name = "next_btn"
        Me.next_btn.Size = New System.Drawing.Size(91, 30)
        Me.next_btn.TabIndex = 1
        Me.next_btn.Text = "Next"
        Me.next_btn.UseVisualStyleBackColor = True
        '
        'Play_btn
        '
        Me.Play_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Play_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Play_btn.ForeColor = System.Drawing.Color.White
        Me.Play_btn.Location = New System.Drawing.Point(224, 311)
        Me.Play_btn.Name = "Play_btn"
        Me.Play_btn.Size = New System.Drawing.Size(100, 40)
        Me.Play_btn.TabIndex = 2
        Me.Play_btn.Text = "Play"
        Me.Play_btn.UseVisualStyleBackColor = True
        '
        'pause_btn
        '
        Me.pause_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pause_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pause_btn.ForeColor = System.Drawing.Color.White
        Me.pause_btn.Location = New System.Drawing.Point(339, 316)
        Me.pause_btn.Name = "pause_btn"
        Me.pause_btn.Size = New System.Drawing.Size(91, 30)
        Me.pause_btn.TabIndex = 3
        Me.pause_btn.Text = "Pause"
        Me.pause_btn.UseVisualStyleBackColor = True
        '
        'stop_btn
        '
        Me.stop_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.stop_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stop_btn.ForeColor = System.Drawing.Color.White
        Me.stop_btn.Location = New System.Drawing.Point(447, 316)
        Me.stop_btn.Name = "stop_btn"
        Me.stop_btn.Size = New System.Drawing.Size(91, 30)
        Me.stop_btn.TabIndex = 4
        Me.stop_btn.Text = "Stop"
        Me.stop_btn.UseVisualStyleBackColor = True
        '
        'open_btn
        '
        Me.open_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.open_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.open_btn.ForeColor = System.Drawing.Color.White
        Me.open_btn.Location = New System.Drawing.Point(553, 316)
        Me.open_btn.Name = "open_btn"
        Me.open_btn.Size = New System.Drawing.Size(165, 30)
        Me.open_btn.TabIndex = 5
        Me.open_btn.Text = "Open"
        Me.open_btn.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Lime
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 288)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(706, 10)
        Me.ProgressBar1.TabIndex = 6
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.Black
        Me.ListBox1.ForeColor = System.Drawing.Color.White
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(201, 106)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(466, 160)
        Me.ListBox1.TabIndex = 7
        '
        'player
        '
        Me.player.Dock = System.Windows.Forms.DockStyle.Top
        Me.player.Enabled = True
        Me.player.Location = New System.Drawing.Point(0, 0)
        Me.player.Name = "player"
        Me.player.OcxState = CType(resources.GetObject("player.OcxState"), System.Windows.Forms.AxHost.State)
        Me.player.Size = New System.Drawing.Size(730, 83)
        Me.player.TabIndex = 9
        '
        'TrackBar1
        '
        Me.TrackBar1.BackColor = System.Drawing.Color.Black
        Me.TrackBar1.Location = New System.Drawing.Point(673, 122)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar1.Size = New System.Drawing.Size(45, 128)
        Me.TrackBar1.TabIndex = 10
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(670, 253)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Volume"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(670, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "100%"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Niagara Engraved", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(26, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 34)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "00:00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Niagara Engraved", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Lime
        Me.Label4.Location = New System.Drawing.Point(647, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 34)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "00:00"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Multiselect = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Music_Player.My.Resources.Resources.b74aa9afaabaf39e7b3bac5ce94ad6d2
        Me.PictureBox1.Location = New System.Drawing.Point(0, 89)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(197, 193)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(730, 358)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.player)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.open_btn)
        Me.Controls.Add(Me.stop_btn)
        Me.Controls.Add(Me.pause_btn)
        Me.Controls.Add(Me.Play_btn)
        Me.Controls.Add(Me.next_btn)
        Me.Controls.Add(Me.preview_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DP Music Player"
        CType(Me.player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents preview_btn As Button
    Friend WithEvents next_btn As Button
    Friend WithEvents Play_btn As Button
    Friend WithEvents pause_btn As Button
    Friend WithEvents stop_btn As Button
    Friend WithEvents open_btn As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents player As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Timer1 As Timer
End Class
