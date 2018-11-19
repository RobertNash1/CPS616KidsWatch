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
        Me.TimeLabel3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.ClockPanel.SuspendLayout()
        Me.HomePanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AppPanel.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.HScrollBar1.Size = New System.Drawing.Size(238, 61)
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
        Me.HomePanel.Controls.Add(Me.PictureBox6)
        Me.HomePanel.Controls.Add(Me.Label4)
        Me.HomePanel.Controls.Add(Me.PictureBox4)
        Me.HomePanel.Controls.Add(Me.Label5)
        Me.HomePanel.Controls.Add(Me.PictureBox5)
        Me.HomePanel.Controls.Add(Me.Label6)
        Me.HomePanel.Controls.Add(Me.Label3)
        Me.HomePanel.Controls.Add(Me.PictureBox3)
        Me.HomePanel.Controls.Add(Me.Label2)
        Me.HomePanel.Controls.Add(Me.PictureBox2)
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
        Me.AppPanel.Controls.Add(Me.TimeLabel3)
        Me.AppPanel.Location = New System.Drawing.Point(498, 12)
        Me.AppPanel.Name = "AppPanel"
        Me.AppPanel.Size = New System.Drawing.Size(238, 344)
        Me.AppPanel.TabIndex = 3
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
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(93, 49)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(60, 52)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(98, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Facebook"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(173, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Twitter"
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(168, 49)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(60, 52)
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Location = New System.Drawing.Point(93, 132)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(60, 52)
        Me.PictureBox5.TabIndex = 9
        Me.PictureBox5.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Phone"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(173, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Browser"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(111, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Text"
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(168, 132)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(60, 52)
        Me.PictureBox4.TabIndex = 11
        Me.PictureBox4.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Location = New System.Drawing.Point(18, 132)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(60, 52)
        Me.PictureBox6.TabIndex = 13
        Me.PictureBox6.TabStop = False
        '
        'PhoneApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 366)
        Me.Controls.Add(Me.AppPanel)
        Me.Controls.Add(Me.HomePanel)
        Me.Controls.Add(Me.ClockPanel)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "PhoneApp"
        Me.Text = "PhoneApp"
        Me.ClockPanel.ResumeLayout(False)
        Me.ClockPanel.PerformLayout()
        Me.HomePanel.ResumeLayout(False)
        Me.HomePanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AppPanel.ResumeLayout(False)
        Me.AppPanel.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
