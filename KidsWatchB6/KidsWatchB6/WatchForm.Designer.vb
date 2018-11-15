<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WatchForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WatchForm))
        Me.ClockPanel = New System.Windows.Forms.Panel()
        Me.LeftButton = New System.Windows.Forms.Button()
        Me.RightButton = New System.Windows.Forms.Button()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.ContactPanel = New System.Windows.Forms.Panel()
        Me.ContactDown = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ContactLeft = New System.Windows.Forms.Button()
        Me.ContactRight = New System.Windows.Forms.Button()
        Me.ContactLabel = New System.Windows.Forms.Label()
        Me.PaymentPanel = New System.Windows.Forms.Panel()
        Me.PaymentDown = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PaymentLeft = New System.Windows.Forms.Button()
        Me.PaymentRight = New System.Windows.Forms.Button()
        Me.PaymentLabel = New System.Windows.Forms.Label()
        Me.SchedulePanel = New System.Windows.Forms.Panel()
        Me.ScheduleDown = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ScheduleLeft = New System.Windows.Forms.Button()
        Me.ScheduleRight = New System.Windows.Forms.Button()
        Me.ScheduleLabel = New System.Windows.Forms.Label()
        Me.GamesPanel = New System.Windows.Forms.Panel()
        Me.GamesDown = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.GamesLeft = New System.Windows.Forms.Button()
        Me.GamesRight = New System.Windows.Forms.Button()
        Me.GamesLabel = New System.Windows.Forms.Label()
        Me.MusicPanel = New System.Windows.Forms.Panel()
        Me.MusicDown = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.MusicLeft = New System.Windows.Forms.Button()
        Me.MusicRight = New System.Windows.Forms.Button()
        Me.MusicLabel = New System.Windows.Forms.Label()
        Me.ClockPanel.SuspendLayout()
        Me.ContactPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PaymentPanel.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SchedulePanel.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GamesPanel.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MusicPanel.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClockPanel
        '
        Me.ClockPanel.Controls.Add(Me.LeftButton)
        Me.ClockPanel.Controls.Add(Me.RightButton)
        Me.ClockPanel.Controls.Add(Me.DateLabel)
        Me.ClockPanel.Controls.Add(Me.TimeLabel)
        Me.ClockPanel.Location = New System.Drawing.Point(16, 15)
        Me.ClockPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ClockPanel.Name = "ClockPanel"
        Me.ClockPanel.Size = New System.Drawing.Size(247, 201)
        Me.ClockPanel.TabIndex = 0
        '
        'LeftButton
        '
        Me.LeftButton.Location = New System.Drawing.Point(4, 90)
        Me.LeftButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LeftButton.Name = "LeftButton"
        Me.LeftButton.Size = New System.Drawing.Size(32, 28)
        Me.LeftButton.TabIndex = 3
        Me.LeftButton.Text = "<"
        Me.LeftButton.UseVisualStyleBackColor = True
        '
        'RightButton
        '
        Me.RightButton.Location = New System.Drawing.Point(211, 90)
        Me.RightButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RightButton.Name = "RightButton"
        Me.RightButton.Size = New System.Drawing.Size(32, 28)
        Me.RightButton.TabIndex = 2
        Me.RightButton.Text = ">"
        Me.RightButton.UseVisualStyleBackColor = True
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.Location = New System.Drawing.Point(35, 65)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(73, 17)
        Me.DateLabel.TabIndex = 1
        Me.DateLabel.Text = "DateLabel"
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLabel.Location = New System.Drawing.Point(32, 34)
        Me.TimeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(140, 31)
        Me.TimeLabel.TabIndex = 0
        Me.TimeLabel.Text = "TimeLabel"
        '
        'ContactPanel
        '
        Me.ContactPanel.Controls.Add(Me.ContactDown)
        Me.ContactPanel.Controls.Add(Me.PictureBox1)
        Me.ContactPanel.Controls.Add(Me.ContactLeft)
        Me.ContactPanel.Controls.Add(Me.ContactRight)
        Me.ContactPanel.Controls.Add(Me.ContactLabel)
        Me.ContactPanel.Location = New System.Drawing.Point(271, 15)
        Me.ContactPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ContactPanel.Name = "ContactPanel"
        Me.ContactPanel.Size = New System.Drawing.Size(247, 201)
        Me.ContactPanel.TabIndex = 1
        '
        'ContactDown
        '
        Me.ContactDown.Location = New System.Drawing.Point(104, 169)
        Me.ContactDown.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ContactDown.Name = "ContactDown"
        Me.ContactDown.Size = New System.Drawing.Size(36, 28)
        Me.ContactDown.TabIndex = 5
        Me.ContactDown.Text = "\/"
        Me.ContactDown.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(44, 11)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(159, 123)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'ContactLeft
        '
        Me.ContactLeft.Location = New System.Drawing.Point(4, 90)
        Me.ContactLeft.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ContactLeft.Name = "ContactLeft"
        Me.ContactLeft.Size = New System.Drawing.Size(32, 28)
        Me.ContactLeft.TabIndex = 3
        Me.ContactLeft.Text = "<"
        Me.ContactLeft.UseVisualStyleBackColor = True
        '
        'ContactRight
        '
        Me.ContactRight.Location = New System.Drawing.Point(211, 90)
        Me.ContactRight.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ContactRight.Name = "ContactRight"
        Me.ContactRight.Size = New System.Drawing.Size(32, 28)
        Me.ContactRight.TabIndex = 2
        Me.ContactRight.Text = ">"
        Me.ContactRight.UseVisualStyleBackColor = True
        '
        'ContactLabel
        '
        Me.ContactLabel.AutoSize = True
        Me.ContactLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactLabel.Location = New System.Drawing.Point(71, 142)
        Me.ContactLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ContactLabel.Name = "ContactLabel"
        Me.ContactLabel.Size = New System.Drawing.Size(90, 25)
        Me.ContactLabel.TabIndex = 0
        Me.ContactLabel.Text = "Contacts"
        '
        'PaymentPanel
        '
        Me.PaymentPanel.Controls.Add(Me.PaymentDown)
        Me.PaymentPanel.Controls.Add(Me.PictureBox2)
        Me.PaymentPanel.Controls.Add(Me.PaymentLeft)
        Me.PaymentPanel.Controls.Add(Me.PaymentRight)
        Me.PaymentPanel.Controls.Add(Me.PaymentLabel)
        Me.PaymentPanel.Location = New System.Drawing.Point(525, 15)
        Me.PaymentPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PaymentPanel.Name = "PaymentPanel"
        Me.PaymentPanel.Size = New System.Drawing.Size(247, 201)
        Me.PaymentPanel.TabIndex = 2
        '
        'PaymentDown
        '
        Me.PaymentDown.Location = New System.Drawing.Point(104, 169)
        Me.PaymentDown.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PaymentDown.Name = "PaymentDown"
        Me.PaymentDown.Size = New System.Drawing.Size(36, 28)
        Me.PaymentDown.TabIndex = 5
        Me.PaymentDown.Text = "\/"
        Me.PaymentDown.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(44, 11)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(159, 123)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PaymentLeft
        '
        Me.PaymentLeft.Location = New System.Drawing.Point(4, 90)
        Me.PaymentLeft.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PaymentLeft.Name = "PaymentLeft"
        Me.PaymentLeft.Size = New System.Drawing.Size(32, 28)
        Me.PaymentLeft.TabIndex = 3
        Me.PaymentLeft.Text = "<"
        Me.PaymentLeft.UseVisualStyleBackColor = True
        '
        'PaymentRight
        '
        Me.PaymentRight.Location = New System.Drawing.Point(211, 90)
        Me.PaymentRight.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PaymentRight.Name = "PaymentRight"
        Me.PaymentRight.Size = New System.Drawing.Size(32, 28)
        Me.PaymentRight.TabIndex = 2
        Me.PaymentRight.Text = ">"
        Me.PaymentRight.UseVisualStyleBackColor = True
        '
        'PaymentLabel
        '
        Me.PaymentLabel.AutoSize = True
        Me.PaymentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentLabel.Location = New System.Drawing.Point(71, 142)
        Me.PaymentLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PaymentLabel.Name = "PaymentLabel"
        Me.PaymentLabel.Size = New System.Drawing.Size(109, 25)
        Me.PaymentLabel.TabIndex = 0
        Me.PaymentLabel.Text = "Mobile Pay"
        '
        'SchedulePanel
        '
        Me.SchedulePanel.Controls.Add(Me.ScheduleDown)
        Me.SchedulePanel.Controls.Add(Me.PictureBox3)
        Me.SchedulePanel.Controls.Add(Me.ScheduleLeft)
        Me.SchedulePanel.Controls.Add(Me.ScheduleRight)
        Me.SchedulePanel.Controls.Add(Me.ScheduleLabel)
        Me.SchedulePanel.Location = New System.Drawing.Point(781, 15)
        Me.SchedulePanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SchedulePanel.Name = "SchedulePanel"
        Me.SchedulePanel.Size = New System.Drawing.Size(247, 201)
        Me.SchedulePanel.TabIndex = 3
        '
        'ScheduleDown
        '
        Me.ScheduleDown.Location = New System.Drawing.Point(104, 169)
        Me.ScheduleDown.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ScheduleDown.Name = "ScheduleDown"
        Me.ScheduleDown.Size = New System.Drawing.Size(36, 28)
        Me.ScheduleDown.TabIndex = 5
        Me.ScheduleDown.Text = "\/"
        Me.ScheduleDown.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(44, 11)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(159, 123)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'ScheduleLeft
        '
        Me.ScheduleLeft.Location = New System.Drawing.Point(4, 90)
        Me.ScheduleLeft.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ScheduleLeft.Name = "ScheduleLeft"
        Me.ScheduleLeft.Size = New System.Drawing.Size(32, 28)
        Me.ScheduleLeft.TabIndex = 3
        Me.ScheduleLeft.Text = "<"
        Me.ScheduleLeft.UseVisualStyleBackColor = True
        '
        'ScheduleRight
        '
        Me.ScheduleRight.Location = New System.Drawing.Point(211, 90)
        Me.ScheduleRight.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ScheduleRight.Name = "ScheduleRight"
        Me.ScheduleRight.Size = New System.Drawing.Size(32, 28)
        Me.ScheduleRight.TabIndex = 2
        Me.ScheduleRight.Text = ">"
        Me.ScheduleRight.UseVisualStyleBackColor = True
        '
        'ScheduleLabel
        '
        Me.ScheduleLabel.AutoSize = True
        Me.ScheduleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScheduleLabel.Location = New System.Drawing.Point(71, 142)
        Me.ScheduleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ScheduleLabel.Name = "ScheduleLabel"
        Me.ScheduleLabel.Size = New System.Drawing.Size(95, 25)
        Me.ScheduleLabel.TabIndex = 0
        Me.ScheduleLabel.Text = "Schedule"
        '
        'GamesPanel
        '
        Me.GamesPanel.Controls.Add(Me.GamesDown)
        Me.GamesPanel.Controls.Add(Me.PictureBox4)
        Me.GamesPanel.Controls.Add(Me.GamesLeft)
        Me.GamesPanel.Controls.Add(Me.GamesRight)
        Me.GamesPanel.Controls.Add(Me.GamesLabel)
        Me.GamesPanel.Location = New System.Drawing.Point(1036, 15)
        Me.GamesPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.GamesPanel.Name = "GamesPanel"
        Me.GamesPanel.Size = New System.Drawing.Size(247, 201)
        Me.GamesPanel.TabIndex = 6
        '
        'GamesDown
        '
        Me.GamesDown.Location = New System.Drawing.Point(104, 169)
        Me.GamesDown.Margin = New System.Windows.Forms.Padding(4)
        Me.GamesDown.Name = "GamesDown"
        Me.GamesDown.Size = New System.Drawing.Size(36, 28)
        Me.GamesDown.TabIndex = 5
        Me.GamesDown.Text = "\/"
        Me.GamesDown.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(44, 11)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(159, 123)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'GamesLeft
        '
        Me.GamesLeft.Location = New System.Drawing.Point(4, 90)
        Me.GamesLeft.Margin = New System.Windows.Forms.Padding(4)
        Me.GamesLeft.Name = "GamesLeft"
        Me.GamesLeft.Size = New System.Drawing.Size(32, 28)
        Me.GamesLeft.TabIndex = 3
        Me.GamesLeft.Text = "<"
        Me.GamesLeft.UseVisualStyleBackColor = True
        '
        'GamesRight
        '
        Me.GamesRight.Location = New System.Drawing.Point(211, 90)
        Me.GamesRight.Margin = New System.Windows.Forms.Padding(4)
        Me.GamesRight.Name = "GamesRight"
        Me.GamesRight.Size = New System.Drawing.Size(32, 28)
        Me.GamesRight.TabIndex = 2
        Me.GamesRight.Text = ">"
        Me.GamesRight.UseVisualStyleBackColor = True
        '
        'GamesLabel
        '
        Me.GamesLabel.AutoSize = True
        Me.GamesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GamesLabel.Location = New System.Drawing.Point(86, 142)
        Me.GamesLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GamesLabel.Name = "GamesLabel"
        Me.GamesLabel.Size = New System.Drawing.Size(75, 25)
        Me.GamesLabel.TabIndex = 0
        Me.GamesLabel.Text = "Games"
        '
        'MusicPanel
        '
        Me.MusicPanel.Controls.Add(Me.MusicDown)
        Me.MusicPanel.Controls.Add(Me.PictureBox5)
        Me.MusicPanel.Controls.Add(Me.MusicLeft)
        Me.MusicPanel.Controls.Add(Me.MusicRight)
        Me.MusicPanel.Controls.Add(Me.MusicLabel)
        Me.MusicPanel.Location = New System.Drawing.Point(1291, 15)
        Me.MusicPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.MusicPanel.Name = "MusicPanel"
        Me.MusicPanel.Size = New System.Drawing.Size(247, 201)
        Me.MusicPanel.TabIndex = 7
        '
        'MusicDown
        '
        Me.MusicDown.Location = New System.Drawing.Point(104, 169)
        Me.MusicDown.Margin = New System.Windows.Forms.Padding(4)
        Me.MusicDown.Name = "MusicDown"
        Me.MusicDown.Size = New System.Drawing.Size(36, 28)
        Me.MusicDown.TabIndex = 5
        Me.MusicDown.Text = "\/"
        Me.MusicDown.UseVisualStyleBackColor = True
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(44, 11)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(159, 123)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 4
        Me.PictureBox5.TabStop = False
        '
        'MusicLeft
        '
        Me.MusicLeft.Location = New System.Drawing.Point(4, 90)
        Me.MusicLeft.Margin = New System.Windows.Forms.Padding(4)
        Me.MusicLeft.Name = "MusicLeft"
        Me.MusicLeft.Size = New System.Drawing.Size(32, 28)
        Me.MusicLeft.TabIndex = 3
        Me.MusicLeft.Text = "<"
        Me.MusicLeft.UseVisualStyleBackColor = True
        '
        'MusicRight
        '
        Me.MusicRight.Location = New System.Drawing.Point(211, 90)
        Me.MusicRight.Margin = New System.Windows.Forms.Padding(4)
        Me.MusicRight.Name = "MusicRight"
        Me.MusicRight.Size = New System.Drawing.Size(32, 28)
        Me.MusicRight.TabIndex = 2
        Me.MusicRight.Text = ">"
        Me.MusicRight.UseVisualStyleBackColor = True
        '
        'MusicLabel
        '
        Me.MusicLabel.AutoSize = True
        Me.MusicLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MusicLabel.Location = New System.Drawing.Point(86, 142)
        Me.MusicLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MusicLabel.Name = "MusicLabel"
        Me.MusicLabel.Size = New System.Drawing.Size(64, 25)
        Me.MusicLabel.TabIndex = 0
        Me.MusicLabel.Text = "Music"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1582, 450)
        Me.Controls.Add(Me.MusicPanel)
        Me.Controls.Add(Me.GamesPanel)
        Me.Controls.Add(Me.SchedulePanel)
        Me.Controls.Add(Me.PaymentPanel)
        Me.Controls.Add(Me.ContactPanel)
        Me.Controls.Add(Me.ClockPanel)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ClockPanel.ResumeLayout(False)
        Me.ClockPanel.PerformLayout()
        Me.ContactPanel.ResumeLayout(False)
        Me.ContactPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PaymentPanel.ResumeLayout(False)
        Me.PaymentPanel.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SchedulePanel.ResumeLayout(False)
        Me.SchedulePanel.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GamesPanel.ResumeLayout(False)
        Me.GamesPanel.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MusicPanel.ResumeLayout(False)
        Me.MusicPanel.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ClockPanel As Panel
    Friend WithEvents TimeLabel As Label
    Friend WithEvents DateLabel As Label
    Friend WithEvents LeftButton As Button
    Friend WithEvents RightButton As Button
    Friend WithEvents ContactPanel As Panel
    Friend WithEvents ContactDown As Button
    Friend WithEvents ContactLeft As Button
    Friend WithEvents ContactRight As Button
    Friend WithEvents ContactLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PaymentPanel As Panel
    Friend WithEvents PaymentDown As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PaymentLeft As Button
    Friend WithEvents PaymentRight As Button
    Friend WithEvents PaymentLabel As Label
    Friend WithEvents SchedulePanel As Panel
    Friend WithEvents ScheduleDown As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ScheduleLeft As Button
    Friend WithEvents ScheduleRight As Button
    Friend WithEvents ScheduleLabel As Label
    Friend WithEvents GamesPanel As Panel
    Friend WithEvents GamesDown As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents GamesLeft As Button
    Friend WithEvents GamesRight As Button
    Friend WithEvents GamesLabel As Label
    Friend WithEvents MusicPanel As Panel
    Friend WithEvents MusicDown As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents MusicLeft As Button
    Friend WithEvents MusicRight As Button
    Friend WithEvents MusicLabel As Label
End Class
