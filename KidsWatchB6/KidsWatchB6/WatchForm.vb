Public Class WatchForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimeLabel.Text = TimeOfDay.ToString("hh:mm tt")
        DateLabel.Text = TimeOfDay.ToString("D")
        PhoneApp.Show()
        'Make all other panels not visible
        ContactPanel.Visible = False
        PaymentPanel.Visible = False
        SchedulePanel.Visible = False
        GamesPanel.Visible = False
        MusicPanel.Visible = False
    End Sub

    Private Sub RightButton_Click(sender As Object, e As EventArgs) Handles RightButton.Click
        ClockPanel.Visible = False
        ContactPanel.Visible = True
    End Sub

    Private Sub ContactLeft_Click(sender As Object, e As EventArgs) Handles ContactLeft.Click
        ClockPanel.Visible = True
        ContactPanel.Visible = False
    End Sub

    Private Sub ContactRight_Click(sender As Object, e As EventArgs) Handles ContactRight.Click
        ContactPanel.Visible = False
        PaymentPanel.Visible = True
    End Sub

    Private Sub PaymentLeft_Click(sender As Object, e As EventArgs) Handles PaymentLeft.Click
        PaymentPanel.Visible = False
        ContactPanel.Visible = True
    End Sub

    Private Sub PaymentRight_Click(sender As Object, e As EventArgs) Handles PaymentRight.Click
        PaymentPanel.Visible = False
        SchedulePanel.Visible = True
    End Sub

    Private Sub ScheduleLeft_Click(sender As Object, e As EventArgs) Handles ScheduleLeft.Click
        SchedulePanel.Visible = False
        PaymentPanel.Visible = True
    End Sub
    Private Sub ScheduleRight_Click(sender As Object, e As EventArgs) Handles ScheduleRight.Click
        SchedulePanel.Visible = False
        GamesPanel.Visible = True
    End Sub
    Private Sub GamesLeft_Click(sender As Object, e As EventArgs) Handles GamesLeft.Click
        SchedulePanel.Visible = True
        GamesPanel.Visible = False
    End Sub

    Private Sub GamesRight_Click(sender As Object, e As EventArgs) Handles GamesRight.Click
        GamesPanel.Visible = False
    End Sub


End Class
