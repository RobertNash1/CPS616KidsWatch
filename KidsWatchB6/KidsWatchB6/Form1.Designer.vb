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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
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
        Me.ClockPanel.SuspendLayout()
        Me.ContactPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ContactPanel.Location = New System.Drawing.Point(219, 12)
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 187)
        Me.Controls.Add(Me.ContactPanel)
        Me.Controls.Add(Me.ClockPanel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ClockPanel.ResumeLayout(False)
        Me.ClockPanel.PerformLayout()
        Me.ContactPanel.ResumeLayout(False)
        Me.ContactPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
