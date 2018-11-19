<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PhoneApp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PhoneApp))
        Me.ClockPanel = New System.Windows.Forms.Panel()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.HomePanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TimeLabel2 = New System.Windows.Forms.Label()
        Me.AppPanel = New System.Windows.Forms.Panel()
        Me.KidSchedule = New System.Windows.Forms.PictureBox()
        Me.KidMessage = New System.Windows.Forms.PictureBox()
        Me.KidMoney = New System.Windows.Forms.PictureBox()
        Me.KidPhone = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Contacts = New System.Windows.Forms.Label()
        Me.TimeLabel3 = New System.Windows.Forms.Label()
        Me.MessagePanel = New System.Windows.Forms.Panel()
        Me.Send = New System.Windows.Forms.Button()
        Me.MessageBox = New System.Windows.Forms.RichTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.MessageBackButton = New System.Windows.Forms.Button()
        Me.TimeLabel4 = New System.Windows.Forms.Label()
        Me.SchedulePanel = New System.Windows.Forms.Panel()
        Me.ScheduleBox = New System.Windows.Forms.RichTextBox()
        Me.UpdateSchedule = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ScheduleBackButton = New System.Windows.Forms.Button()
        Me.TimeLabel5 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.AddMoneyPanel = New System.Windows.Forms.Panel()
        Me.AddVerification = New System.Windows.Forms.Label()
        Me.AmountBox = New System.Windows.Forms.TextBox()
        Me.CurrBalanceLabel = New System.Windows.Forms.Label()
        Me.CancelMoney = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.AddMoney = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.CallPanel = New System.Windows.Forms.Panel()
        Me.CallEndPicture = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TimeLabel6 = New System.Windows.Forms.Label()
        Me.ClockPanel.SuspendLayout()
        Me.HomePanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AppPanel.SuspendLayout()
        CType(Me.KidSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KidMessage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KidMoney, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KidPhone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MessagePanel.SuspendLayout()
        Me.SchedulePanel.SuspendLayout()
        Me.AddMoneyPanel.SuspendLayout()
        Me.CallPanel.SuspendLayout()
        CType(Me.CallEndPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClockPanel
        '
        Me.ClockPanel.Controls.Add(Me.HScrollBar1)
        Me.ClockPanel.Controls.Add(Me.DateLabel)
        Me.ClockPanel.Controls.Add(Me.TimeLabel)
        Me.ClockPanel.Location = New System.Drawing.Point(10, 11)
        Me.ClockPanel.Name = "ClockPanel"
        Me.ClockPanel.Size = New System.Drawing.Size(238, 344)
        Me.ClockPanel.TabIndex = 1
        '
        'HScrollBar1
        '
        Me.HScrollBar1.LargeChange = 30
        Me.HScrollBar1.Location = New System.Drawing.Point(0, 260)
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(236, 61)
        Me.HScrollBar1.TabIndex = 2
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.Location = New System.Drawing.Point(62, 75)
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
        Me.TimeLabel.Location = New System.Drawing.Point(60, 50)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(112, 25)
        Me.TimeLabel.TabIndex = 0
        Me.TimeLabel.Text = "TimeLabel"
        '
        'HomePanel
        '
        Me.HomePanel.Controls.Add(Me.Label1)
        Me.HomePanel.Controls.Add(Me.PictureBox1)
        Me.HomePanel.Controls.Add(Me.TimeLabel2)
        Me.HomePanel.Location = New System.Drawing.Point(254, 12)
        Me.HomePanel.Name = "HomePanel"
        Me.HomePanel.Size = New System.Drawing.Size(238, 344)
        Me.HomePanel.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "SmartWatchApp"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(18, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'TimeLabel2
        '
        Me.TimeLabel2.AutoSize = True
        Me.TimeLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLabel2.Location = New System.Drawing.Point(157, 9)
        Me.TimeLabel2.Name = "TimeLabel2"
        Me.TimeLabel2.Size = New System.Drawing.Size(71, 18)
        Me.TimeLabel2.TabIndex = 0
        Me.TimeLabel2.Text = "12:59 PM"
        '
        'AppPanel
        '
        Me.AppPanel.Controls.Add(Me.KidSchedule)
        Me.AppPanel.Controls.Add(Me.KidMessage)
        Me.AppPanel.Controls.Add(Me.KidMoney)
        Me.AppPanel.Controls.Add(Me.KidPhone)
        Me.AppPanel.Controls.Add(Me.Label12)
        Me.AppPanel.Controls.Add(Me.PictureBox12)
        Me.AppPanel.Controls.Add(Me.Label13)
        Me.AppPanel.Controls.Add(Me.PictureBox13)
        Me.AppPanel.Controls.Add(Me.Label14)
        Me.AppPanel.Controls.Add(Me.Label11)
        Me.AppPanel.Controls.Add(Me.Label10)
        Me.AppPanel.Controls.Add(Me.PictureBox10)
        Me.AppPanel.Controls.Add(Me.Button1)
        Me.AppPanel.Controls.Add(Me.Label7)
        Me.AppPanel.Controls.Add(Me.Label8)
        Me.AppPanel.Controls.Add(Me.Contacts)
        Me.AppPanel.Controls.Add(Me.TimeLabel3)
        Me.AppPanel.Location = New System.Drawing.Point(498, 12)
        Me.AppPanel.Name = "AppPanel"
        Me.AppPanel.Size = New System.Drawing.Size(238, 344)
        Me.AppPanel.TabIndex = 3
        '
        'KidSchedule
        '
        Me.KidSchedule.Image = CType(resources.GetObject("KidSchedule.Image"), System.Drawing.Image)
        Me.KidSchedule.Location = New System.Drawing.Point(18, 268)
        Me.KidSchedule.Name = "KidSchedule"
        Me.KidSchedule.Size = New System.Drawing.Size(60, 52)
        Me.KidSchedule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.KidSchedule.TabIndex = 25
        Me.KidSchedule.TabStop = False
        '
        'KidMessage
        '
        Me.KidMessage.Image = CType(resources.GetObject("KidMessage.Image"), System.Drawing.Image)
        Me.KidMessage.Location = New System.Drawing.Point(168, 187)
        Me.KidMessage.Name = "KidMessage"
        Me.KidMessage.Size = New System.Drawing.Size(60, 52)
        Me.KidMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.KidMessage.TabIndex = 23
        Me.KidMessage.TabStop = False
        '
        'KidMoney
        '
        Me.KidMoney.Image = CType(resources.GetObject("KidMoney.Image"), System.Drawing.Image)
        Me.KidMoney.Location = New System.Drawing.Point(93, 187)
        Me.KidMoney.Name = "KidMoney"
        Me.KidMoney.Size = New System.Drawing.Size(60, 52)
        Me.KidMoney.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.KidMoney.TabIndex = 23
        Me.KidMoney.TabStop = False
        '
        'KidPhone
        '
        Me.KidPhone.Enabled = False
        Me.KidPhone.Image = CType(resources.GetObject("KidPhone.Image"), System.Drawing.Image)
        Me.KidPhone.Location = New System.Drawing.Point(18, 187)
        Me.KidPhone.Name = "KidPhone"
        Me.KidPhone.Size = New System.Drawing.Size(60, 52)
        Me.KidPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.KidPhone.TabIndex = 24
        Me.KidPhone.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(173, 323)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Settings"
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = CType(resources.GetObject("PictureBox12.Image"), System.Drawing.Image)
        Me.PictureBox12.Location = New System.Drawing.Point(168, 268)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(60, 52)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox12.TabIndex = 27
        Me.PictureBox12.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(102, 323)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 13)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Health"
        '
        'PictureBox13
        '
        Me.PictureBox13.Image = CType(resources.GetObject("PictureBox13.Image"), System.Drawing.Image)
        Me.PictureBox13.Location = New System.Drawing.Point(93, 268)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(60, 52)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox13.TabIndex = 25
        Me.PictureBox13.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(26, 323)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 13)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Schedule"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 152)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(222, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "How would you like to take care of your child:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(111, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Welcome To KidWatch!"
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(18, 55)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(78, 76)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox10.TabIndex = 21
        Me.PictureBox10.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(173, 242)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Message"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(102, 242)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Money"
        '
        'Contacts
        '
        Me.Contacts.AutoSize = True
        Me.Contacts.Location = New System.Drawing.Point(12, 242)
        Me.Contacts.Name = "Contacts"
        Me.Contacts.Size = New System.Drawing.Size(75, 13)
        Me.Contacts.TabIndex = 14
        Me.Contacts.Text = "Child Contacts"
        '
        'TimeLabel3
        '
        Me.TimeLabel3.AutoSize = True
        Me.TimeLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLabel3.Location = New System.Drawing.Point(157, 9)
        Me.TimeLabel3.Name = "TimeLabel3"
        Me.TimeLabel3.Size = New System.Drawing.Size(71, 18)
        Me.TimeLabel3.TabIndex = 0
        Me.TimeLabel3.Text = "12:59 PM"
        '
        'MessagePanel
        '
        Me.MessagePanel.Controls.Add(Me.Send)
        Me.MessagePanel.Controls.Add(Me.MessageBox)
        Me.MessagePanel.Controls.Add(Me.Label15)
        Me.MessagePanel.Controls.Add(Me.MessageBackButton)
        Me.MessagePanel.Controls.Add(Me.TimeLabel4)
        Me.MessagePanel.Location = New System.Drawing.Point(10, 362)
        Me.MessagePanel.Name = "MessagePanel"
        Me.MessagePanel.Size = New System.Drawing.Size(238, 344)
        Me.MessagePanel.TabIndex = 4
        '
        'Send
        '
        Me.Send.Location = New System.Drawing.Point(84, 205)
        Me.Send.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Send.Name = "Send"
        Me.Send.Size = New System.Drawing.Size(56, 19)
        Me.Send.TabIndex = 23
        Me.Send.Text = "Send"
        Me.Send.UseVisualStyleBackColor = True
        '
        'MessageBox
        '
        Me.MessageBox.Location = New System.Drawing.Point(17, 104)
        Me.MessageBox.Name = "MessageBox"
        Me.MessageBox.Size = New System.Drawing.Size(199, 96)
        Me.MessageBox.TabIndex = 22
        Me.MessageBox.Text = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(14, 74)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 13)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Messages:"
        '
        'MessageBackButton
        '
        Me.MessageBackButton.Location = New System.Drawing.Point(3, 26)
        Me.MessageBackButton.Name = "MessageBackButton"
        Me.MessageBackButton.Size = New System.Drawing.Size(75, 23)
        Me.MessageBackButton.TabIndex = 20
        Me.MessageBackButton.Text = "Back"
        Me.MessageBackButton.UseVisualStyleBackColor = True
        '
        'TimeLabel4
        '
        Me.TimeLabel4.AutoSize = True
        Me.TimeLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLabel4.Location = New System.Drawing.Point(157, 9)
        Me.TimeLabel4.Name = "TimeLabel4"
        Me.TimeLabel4.Size = New System.Drawing.Size(71, 18)
        Me.TimeLabel4.TabIndex = 0
        Me.TimeLabel4.Text = "12:59 PM"
        '
        'SchedulePanel
        '
        Me.SchedulePanel.Controls.Add(Me.ScheduleBox)
        Me.SchedulePanel.Controls.Add(Me.UpdateSchedule)
        Me.SchedulePanel.Controls.Add(Me.Label16)
        Me.SchedulePanel.Controls.Add(Me.ScheduleBackButton)
        Me.SchedulePanel.Controls.Add(Me.TimeLabel5)
        Me.SchedulePanel.Location = New System.Drawing.Point(254, 362)
        Me.SchedulePanel.Name = "SchedulePanel"
        Me.SchedulePanel.Size = New System.Drawing.Size(238, 344)
        Me.SchedulePanel.TabIndex = 5
        '
        'ScheduleBox
        '
        Me.ScheduleBox.Location = New System.Drawing.Point(16, 104)
        Me.ScheduleBox.Name = "ScheduleBox"
        Me.ScheduleBox.Size = New System.Drawing.Size(199, 96)
        Me.ScheduleBox.TabIndex = 24
        Me.ScheduleBox.Text = ""
        '
        'UpdateSchedule
        '
        Me.UpdateSchedule.Location = New System.Drawing.Point(51, 206)
        Me.UpdateSchedule.Name = "UpdateSchedule"
        Me.UpdateSchedule.Size = New System.Drawing.Size(118, 23)
        Me.UpdateSchedule.TabIndex = 23
        Me.UpdateSchedule.Text = "Update Schedule"
        Me.UpdateSchedule.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(14, 74)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 13)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Schedule:"
        '
        'ScheduleBackButton
        '
        Me.ScheduleBackButton.Location = New System.Drawing.Point(3, 26)
        Me.ScheduleBackButton.Name = "ScheduleBackButton"
        Me.ScheduleBackButton.Size = New System.Drawing.Size(75, 23)
        Me.ScheduleBackButton.TabIndex = 20
        Me.ScheduleBackButton.Text = "Back"
        Me.ScheduleBackButton.UseVisualStyleBackColor = True
        '
        'TimeLabel5
        '
        Me.TimeLabel5.AutoSize = True
        Me.TimeLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLabel5.Location = New System.Drawing.Point(157, 9)
        Me.TimeLabel5.Name = "TimeLabel5"
        Me.TimeLabel5.Size = New System.Drawing.Size(71, 18)
        Me.TimeLabel5.TabIndex = 0
        Me.TimeLabel5.Text = "12:59 PM"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'AddMoneyPanel
        '
        Me.AddMoneyPanel.Controls.Add(Me.AddVerification)
        Me.AddMoneyPanel.Controls.Add(Me.AmountBox)
        Me.AddMoneyPanel.Controls.Add(Me.CurrBalanceLabel)
        Me.AddMoneyPanel.Controls.Add(Me.CancelMoney)
        Me.AddMoneyPanel.Controls.Add(Me.Label17)
        Me.AddMoneyPanel.Controls.Add(Me.AddMoney)
        Me.AddMoneyPanel.Controls.Add(Me.Label19)
        Me.AddMoneyPanel.Controls.Add(Me.Label22)
        Me.AddMoneyPanel.Location = New System.Drawing.Point(498, 362)
        Me.AddMoneyPanel.Name = "AddMoneyPanel"
        Me.AddMoneyPanel.Size = New System.Drawing.Size(238, 344)
        Me.AddMoneyPanel.TabIndex = 30
        '
        'AddVerification
        '
        Me.AddVerification.AutoSize = True
        Me.AddVerification.Location = New System.Drawing.Point(16, 147)
        Me.AddVerification.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.AddVerification.Name = "AddVerification"
        Me.AddVerification.Size = New System.Drawing.Size(59, 13)
        Me.AddVerification.TabIndex = 32
        Me.AddVerification.Text = "Verification"
        '
        'AmountBox
        '
        Me.AmountBox.Location = New System.Drawing.Point(100, 98)
        Me.AmountBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AmountBox.Name = "AmountBox"
        Me.AmountBox.Size = New System.Drawing.Size(76, 20)
        Me.AmountBox.TabIndex = 31
        '
        'CurrBalanceLabel
        '
        Me.CurrBalanceLabel.AutoSize = True
        Me.CurrBalanceLabel.Location = New System.Drawing.Point(100, 68)
        Me.CurrBalanceLabel.Name = "CurrBalanceLabel"
        Me.CurrBalanceLabel.Size = New System.Drawing.Size(28, 13)
        Me.CurrBalanceLabel.TabIndex = 30
        Me.CurrBalanceLabel.Text = "0.00"
        '
        'CancelMoney
        '
        Me.CancelMoney.Location = New System.Drawing.Point(153, 309)
        Me.CancelMoney.Name = "CancelMoney"
        Me.CancelMoney.Size = New System.Drawing.Size(75, 23)
        Me.CancelMoney.TabIndex = 29
        Me.CancelMoney.Text = "Cancel"
        Me.CancelMoney.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(12, 102)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(84, 13)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = "Amount To Add:"
        '
        'AddMoney
        '
        Me.AddMoney.Location = New System.Drawing.Point(14, 309)
        Me.AddMoney.Name = "AddMoney"
        Me.AddMoney.Size = New System.Drawing.Size(75, 23)
        Me.AddMoney.TabIndex = 24
        Me.AddMoney.Text = "Add"
        Me.AddMoney.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(9, 68)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(86, 13)
        Me.Label19.TabIndex = 21
        Me.Label19.Text = "Current Balance:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(157, 9)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(71, 18)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "12:59 PM"
        '
        'CallPanel
        '
        Me.CallPanel.Controls.Add(Me.CallEndPicture)
        Me.CallPanel.Controls.Add(Me.Label2)
        Me.CallPanel.Controls.Add(Me.PictureBox2)
        Me.CallPanel.Controls.Add(Me.TimeLabel6)
        Me.CallPanel.Location = New System.Drawing.Point(748, 12)
        Me.CallPanel.Name = "CallPanel"
        Me.CallPanel.Size = New System.Drawing.Size(238, 344)
        Me.CallPanel.TabIndex = 31
        '
        'CallEndPicture
        '
        Me.CallEndPicture.Image = CType(resources.GetObject("CallEndPicture.Image"), System.Drawing.Image)
        Me.CallEndPicture.Location = New System.Drawing.Point(80, 275)
        Me.CallEndPicture.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CallEndPicture.Name = "CallEndPicture"
        Me.CallEndPicture.Size = New System.Drawing.Size(63, 55)
        Me.CallEndPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CallEndPicture.TabIndex = 3
        Me.CallEndPicture.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Your Kid"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(18, 49)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(198, 207)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'TimeLabel6
        '
        Me.TimeLabel6.AutoSize = True
        Me.TimeLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLabel6.Location = New System.Drawing.Point(157, 9)
        Me.TimeLabel6.Name = "TimeLabel6"
        Me.TimeLabel6.Size = New System.Drawing.Size(71, 18)
        Me.TimeLabel6.TabIndex = 0
        Me.TimeLabel6.Text = "12:59 PM"
        '
        'PhoneApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(253, 361)
        Me.Controls.Add(Me.CallPanel)
        Me.Controls.Add(Me.AddMoneyPanel)
        Me.Controls.Add(Me.SchedulePanel)
        Me.Controls.Add(Me.MessagePanel)
        Me.Controls.Add(Me.AppPanel)
        Me.Controls.Add(Me.HomePanel)
        Me.Controls.Add(Me.ClockPanel)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "PhoneApp"
        Me.Text = "PhoneApp"
        Me.ClockPanel.ResumeLayout(False)
        Me.ClockPanel.PerformLayout()
        Me.HomePanel.ResumeLayout(False)
        Me.HomePanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AppPanel.ResumeLayout(False)
        Me.AppPanel.PerformLayout()
        CType(Me.KidSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KidMessage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KidMoney, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KidPhone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MessagePanel.ResumeLayout(False)
        Me.MessagePanel.PerformLayout()
        Me.SchedulePanel.ResumeLayout(False)
        Me.SchedulePanel.PerformLayout()
        Me.AddMoneyPanel.ResumeLayout(False)
        Me.AddMoneyPanel.PerformLayout()
        Me.CallPanel.ResumeLayout(False)
        Me.CallPanel.PerformLayout()
        CType(Me.CallEndPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ClockPanel As Panel
    Friend WithEvents DateLabel As Label
    Friend WithEvents TimeLabel As Label
    Friend WithEvents HomePanel As Panel
    Friend WithEvents TimeLabel2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents AppPanel As Panel
    Friend WithEvents TimeLabel3 As Label
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Contacts As Label
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents MessagePanel As Panel
    Friend WithEvents MessageBox As RichTextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents MessageBackButton As Button
    Friend WithEvents TimeLabel4 As Label
    Friend WithEvents SchedulePanel As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents ScheduleBackButton As Button
    Friend WithEvents TimeLabel5 As Label
    Friend WithEvents UpdateSchedule As Button
    Friend WithEvents KidMessage As PictureBox
    Friend WithEvents KidMoney As PictureBox
    Friend WithEvents KidPhone As PictureBox
    Friend WithEvents KidSchedule As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents AddMoneyPanel As Panel
    Friend WithEvents CancelMoney As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents AddMoney As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents CurrBalanceLabel As Label
    Friend WithEvents AmountBox As TextBox
    Friend WithEvents AddVerification As Label
    Friend WithEvents Send As Button
    Friend WithEvents ScheduleBox As RichTextBox
    Friend WithEvents CallPanel As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TimeLabel6 As Label
    Friend WithEvents CallEndPicture As PictureBox
End Class
