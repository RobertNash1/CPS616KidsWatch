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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
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
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ClockPanel
        '
        Me.ClockPanel.Controls.Add(Me.LeftButton)
        Me.ClockPanel.Controls.Add(Me.RightButton)
        Me.ClockPanel.Controls.Add(Me.DateLabel)
        Me.ClockPanel.Controls.Add(Me.TimeLabel)
        Me.ClockPanel.Location = New System.Drawing.Point(12, 12)
        Me.ClockPanel.Name = "ClockPanel"
        Me.ClockPanel.Size = New System.Drawing.Size(185, 163)
        Me.ClockPanel.TabIndex = 0
        '
        'LeftButton
        '
        Me.LeftButton.Location = New System.Drawing.Point(3, 73)
        Me.LeftButton.Name = "LeftButton"
        Me.LeftButton.Size = New System.Drawing.Size(24, 23)
        Me.LeftButton.TabIndex = 3
        Me.LeftButton.Text = "<"
        Me.LeftButton.UseVisualStyleBackColor = True
        '
        'RightButton
        '
        Me.RightButton.Location = New System.Drawing.Point(158, 73)
        Me.RightButton.Name = "RightButton"
        Me.RightButton.Size = New System.Drawing.Size(24, 23)
        Me.RightButton.TabIndex = 2
        Me.RightButton.Text = ">"
        Me.RightButton.UseVisualStyleBackColor = True
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.Location = New System.Drawing.Point(26, 53)
        Me.DateLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(56, 13)
        Me.DateLabel.TabIndex = 1
        Me.DateLabel.Text = "DateLabel"
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLabel.Location = New System.Drawing.Point(24, 28)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(112, 25)
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
        Me.ContactPanel.Location = New System.Drawing.Point(203, 12)
        Me.ContactPanel.Name = "ContactPanel"
        Me.ContactPanel.Size = New System.Drawing.Size(185, 163)
        Me.ContactPanel.TabIndex = 1
        '
        'ContactDown
        '
        Me.ContactDown.Location = New System.Drawing.Point(78, 137)
        Me.ContactDown.Name = "ContactDown"
        Me.ContactDown.Size = New System.Drawing.Size(27, 23)
        Me.ContactDown.TabIndex = 5
        Me.ContactDown.Text = "\/"
        Me.ContactDown.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(33, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'ContactLeft
        '
        Me.ContactLeft.Location = New System.Drawing.Point(3, 73)
        Me.ContactLeft.Name = "ContactLeft"
        Me.ContactLeft.Size = New System.Drawing.Size(24, 23)
        Me.ContactLeft.TabIndex = 3
        Me.ContactLeft.Text = "<"
        Me.ContactLeft.UseVisualStyleBackColor = True
        '
        'ContactRight
        '
        Me.ContactRight.Location = New System.Drawing.Point(158, 73)
        Me.ContactRight.Name = "ContactRight"
        Me.ContactRight.Size = New System.Drawing.Size(24, 23)
        Me.ContactRight.TabIndex = 2
        Me.ContactRight.Text = ">"
        Me.ContactRight.UseVisualStyleBackColor = True
        '
        'ContactLabel
        '
        Me.ContactLabel.AutoSize = True
        Me.ContactLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactLabel.Location = New System.Drawing.Point(53, 115)
        Me.ContactLabel.Name = "ContactLabel"
        Me.ContactLabel.Size = New System.Drawing.Size(73, 20)
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
        Me.PaymentPanel.Location = New System.Drawing.Point(394, 12)
        Me.PaymentPanel.Name = "PaymentPanel"
        Me.PaymentPanel.Size = New System.Drawing.Size(185, 163)
        Me.PaymentPanel.TabIndex = 2
        '
        'PaymentDown
        '
        Me.PaymentDown.Location = New System.Drawing.Point(78, 137)
        Me.PaymentDown.Name = "PaymentDown"
        Me.PaymentDown.Size = New System.Drawing.Size(27, 23)
        Me.PaymentDown.TabIndex = 5
        Me.PaymentDown.Text = "\/"
        Me.PaymentDown.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(33, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(119, 100)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PaymentLeft
        '
        Me.PaymentLeft.Location = New System.Drawing.Point(3, 73)
        Me.PaymentLeft.Name = "PaymentLeft"
        Me.PaymentLeft.Size = New System.Drawing.Size(24, 23)
        Me.PaymentLeft.TabIndex = 3
        Me.PaymentLeft.Text = "<"
        Me.PaymentLeft.UseVisualStyleBackColor = True
        '
        'PaymentRight
        '
        Me.PaymentRight.Location = New System.Drawing.Point(158, 73)
        Me.PaymentRight.Name = "PaymentRight"
        Me.PaymentRight.Size = New System.Drawing.Size(24, 23)
        Me.PaymentRight.TabIndex = 2
        Me.PaymentRight.Text = ">"
        Me.PaymentRight.UseVisualStyleBackColor = True
        '
        'PaymentLabel
        '
        Me.PaymentLabel.AutoSize = True
        Me.PaymentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentLabel.Location = New System.Drawing.Point(53, 115)
        Me.PaymentLabel.Name = "PaymentLabel"
        Me.PaymentLabel.Size = New System.Drawing.Size(85, 20)
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
        Me.SchedulePanel.Location = New System.Drawing.Point(586, 12)
        Me.SchedulePanel.Name = "SchedulePanel"
        Me.SchedulePanel.Size = New System.Drawing.Size(185, 163)
        Me.SchedulePanel.TabIndex = 3
        '
        'ScheduleDown
        '
        Me.ScheduleDown.Location = New System.Drawing.Point(78, 137)
        Me.ScheduleDown.Name = "ScheduleDown"
        Me.ScheduleDown.Size = New System.Drawing.Size(27, 23)
        Me.ScheduleDown.TabIndex = 5
        Me.ScheduleDown.Text = "\/"
        Me.ScheduleDown.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(33, 9)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(119, 100)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'ScheduleLeft
        '
        Me.ScheduleLeft.Location = New System.Drawing.Point(3, 73)
        Me.ScheduleLeft.Name = "ScheduleLeft"
        Me.ScheduleLeft.Size = New System.Drawing.Size(24, 23)
        Me.ScheduleLeft.TabIndex = 3
        Me.ScheduleLeft.Text = "<"
        Me.ScheduleLeft.UseVisualStyleBackColor = True
        '
        'ScheduleRight
        '
        Me.ScheduleRight.Location = New System.Drawing.Point(158, 73)
        Me.ScheduleRight.Name = "ScheduleRight"
        Me.ScheduleRight.Size = New System.Drawing.Size(24, 23)
        Me.ScheduleRight.TabIndex = 2
        Me.ScheduleRight.Text = ">"
        Me.ScheduleRight.UseVisualStyleBackColor = True
        '
        'ScheduleLabel
        '
        Me.ScheduleLabel.AutoSize = True
        Me.ScheduleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScheduleLabel.Location = New System.Drawing.Point(53, 115)
        Me.ScheduleLabel.Name = "ScheduleLabel"
        Me.ScheduleLabel.Size = New System.Drawing.Size(76, 20)
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
        Me.GamesPanel.Location = New System.Drawing.Point(777, 12)
        Me.GamesPanel.Name = "GamesPanel"
        Me.GamesPanel.Size = New System.Drawing.Size(185, 163)
        Me.GamesPanel.TabIndex = 6
        '
        'GamesDown
        '
        Me.GamesDown.Location = New System.Drawing.Point(78, 137)
        Me.GamesDown.Name = "GamesDown"
        Me.GamesDown.Size = New System.Drawing.Size(27, 23)
        Me.GamesDown.TabIndex = 5
        Me.GamesDown.Text = "\/"
        Me.GamesDown.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(33, 9)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(119, 100)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'GamesLeft
        '
        Me.GamesLeft.Location = New System.Drawing.Point(3, 73)
        Me.GamesLeft.Name = "GamesLeft"
        Me.GamesLeft.Size = New System.Drawing.Size(24, 23)
        Me.GamesLeft.TabIndex = 3
        Me.GamesLeft.Text = "<"
        Me.GamesLeft.UseVisualStyleBackColor = True
        '
        'GamesRight
        '
        Me.GamesRight.Location = New System.Drawing.Point(158, 73)
        Me.GamesRight.Name = "GamesRight"
        Me.GamesRight.Size = New System.Drawing.Size(24, 23)
        Me.GamesRight.TabIndex = 2
        Me.GamesRight.Text = ">"
        Me.GamesRight.UseVisualStyleBackColor = True
        '
        'GamesLabel
        '
        Me.GamesLabel.AutoSize = True
        Me.GamesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GamesLabel.Location = New System.Drawing.Point(64, 115)
        Me.GamesLabel.Name = "GamesLabel"
        Me.GamesLabel.Size = New System.Drawing.Size(61, 20)
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
        Me.MusicPanel.Location = New System.Drawing.Point(968, 12)
        Me.MusicPanel.Name = "MusicPanel"
        Me.MusicPanel.Size = New System.Drawing.Size(185, 163)
        Me.MusicPanel.TabIndex = 7
        '
        'MusicDown
        '
        Me.MusicDown.Location = New System.Drawing.Point(78, 137)
        Me.MusicDown.Name = "MusicDown"
        Me.MusicDown.Size = New System.Drawing.Size(27, 23)
        Me.MusicDown.TabIndex = 5
        Me.MusicDown.Text = "\/"
        Me.MusicDown.UseVisualStyleBackColor = True
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(33, 9)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(119, 100)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 4
        Me.PictureBox5.TabStop = False
        '
        'MusicLeft
        '
        Me.MusicLeft.Location = New System.Drawing.Point(3, 73)
        Me.MusicLeft.Name = "MusicLeft"
        Me.MusicLeft.Size = New System.Drawing.Size(24, 23)
        Me.MusicLeft.TabIndex = 3
        Me.MusicLeft.Text = "<"
        Me.MusicLeft.UseVisualStyleBackColor = True
        '
        'MusicRight
        '
        Me.MusicRight.Location = New System.Drawing.Point(158, 73)
        Me.MusicRight.Name = "MusicRight"
        Me.MusicRight.Size = New System.Drawing.Size(24, 23)
        Me.MusicRight.TabIndex = 2
        Me.MusicRight.Text = ">"
        Me.MusicRight.UseVisualStyleBackColor = True
        '
        'MusicLabel
        '
        Me.MusicLabel.AutoSize = True
        Me.MusicLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MusicLabel.Location = New System.Drawing.Point(64, 115)
        Me.MusicLabel.Name = "MusicLabel"
        Me.MusicLabel.Size = New System.Drawing.Size(50, 20)
        Me.MusicLabel.TabIndex = 0
        Me.MusicLabel.Text = "Music"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(203, 178)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(185, 163)
        Me.Panel1.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(78, 137)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "\/"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mom"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(394, 181)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(185, 163)
        Me.Panel2.TabIndex = 9
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(78, 137)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(27, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "\/"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Balance:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(47, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "$00.00"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Location = New System.Drawing.Point(394, 350)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(185, 163)
        Me.Panel3.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(53, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Pay Now"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(78, 15)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(27, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "^"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(78, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(27, 23)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "^"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(78, 6)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(27, 23)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "^"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(141, 66)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(41, 23)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "Call >"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Button8)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Location = New System.Drawing.Point(585, 181)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(185, 163)
        Me.Panel4.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Today:"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(79, 3)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(27, 23)
        Me.Button8.TabIndex = 8
        Me.Button8.Text = "^"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(54, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "No Plans."
        '
        'WatchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1186, 599)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MusicPanel)
        Me.Controls.Add(Me.GamesPanel)
        Me.Controls.Add(Me.SchedulePanel)
        Me.Controls.Add(Me.PaymentPanel)
        Me.Controls.Add(Me.ContactPanel)
        Me.Controls.Add(Me.ClockPanel)
        Me.Name = "WatchForm"
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
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Label5 As Label
End Class
