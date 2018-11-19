Public Class PhoneApp

    Dim myPanels As List(Of Panel) = New List(Of Panel)
    Dim Panelocation As Point
    Public Sub DrawPanels()
        Panelocation.X = 15
        Panelocation.Y = 15

        myPanels.Add(ClockPanel)
        myPanels.Add(AddMoneyPanel)
        myPanels.Add(HomePanel)
        myPanels.Add(AppPanel)
        myPanels.Add(MessagePanel)
        myPanels.Add(SchedulePanel)
        myPanels.Add(SchedulePanel1)
        For index As Integer = 0 To 6
            myPanels(index).Location = Panelocation
        Next

    End Sub
    Private Sub PhoneApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimeLabel.Text = TimeOfDay.ToString("hh:mm tt")
        DateLabel.Text = Date.Now().ToString("D")
        'Make all other panels not visible
        DrawPanels()
        HomePanel.Visible = False
        AppPanel.Visible = False
        MessagePanel.Visible = False
        SchedulePanel.Visible = False
        SchedulePanel.Visible = False
        SchedulePanel1.Visible = False
        AddMoneyPanel.Visible = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        HomePanel.Visible = False
        AppPanel.Visible = True
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        If HScrollBar1.Value > 69 Then
            ClockPanel.Visible = False
            HomePanel.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        HomePanel.Visible = True
        AppPanel.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles MessageBackButton.Click
        MessagePanel.Visible = False
        AppPanel.Visible = True
    End Sub


    Private Sub KidMessage_Click(sender As Object, e As EventArgs) Handles KidMessage.Click
        MessagePanel.Visible = True
        AppPanel.Visible = False
    End Sub

    Private Sub KidSchedule_Click(sender As Object, e As EventArgs) Handles KidSchedule.Click
        SchedulePanel.Visible = True
        AppPanel.Visible = False

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles AddNewSchedule.Click
        SchedulePanel.Visible = False
        SchedulePanel1.Visible = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Schedule2BackButton.Click
        SchedulePanel.Visible = True
        SchedulePanel1.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ScheduleBackButton.Click
        SchedulePanel.Visible = False
        AppPanel.Visible = True
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TimeLabel2.Text = TimeOfDay.ToString("hh:mm tt")
        TimeLabel3.Text = TimeOfDay.ToString("hh:mm tt")
        TimeLabel4.Text = TimeOfDay.ToString("hh:mm tt")
        TimeLabel5.Text = TimeOfDay.ToString("hh:mm tt")
        TimeLabel6.Text = TimeOfDay.ToString("hh:mm tt")
    End Sub

    Private Sub KidMoney_Click(sender As Object, e As EventArgs) Handles KidMoney.Click
        AddMoneyPanel.Visible = True
        AppPanel.Visible = False
    End Sub
End Class