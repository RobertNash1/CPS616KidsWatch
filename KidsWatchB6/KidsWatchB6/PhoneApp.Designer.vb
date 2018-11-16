<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PhoneApp
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
        Me.ClockPanel = New System.Windows.Forms.Panel()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.ClockPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ClockPanel
        '
        Me.ClockPanel.Controls.Add(Me.DateLabel)
        Me.ClockPanel.Controls.Add(Me.TimeLabel)
        Me.ClockPanel.Location = New System.Drawing.Point(13, 13)
        Me.ClockPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.ClockPanel.Name = "ClockPanel"
        Me.ClockPanel.Size = New System.Drawing.Size(318, 424)
        Me.ClockPanel.TabIndex = 1
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.Location = New System.Drawing.Point(83, 92)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(73, 17)
        Me.DateLabel.TabIndex = 1
        Me.DateLabel.Text = "DateLabel"
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLabel.Location = New System.Drawing.Point(80, 61)
        Me.TimeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(140, 31)
        Me.TimeLabel.TabIndex = 0
        Me.TimeLabel.Text = "TimeLabel"
        '
        'PhoneApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 450)
        Me.Controls.Add(Me.ClockPanel)
        Me.Name = "PhoneApp"
        Me.Text = "PhoneApp"
        Me.ClockPanel.ResumeLayout(False)
        Me.ClockPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ClockPanel As Panel
    Friend WithEvents DateLabel As Label
    Friend WithEvents TimeLabel As Label
End Class
