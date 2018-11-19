Public Class PhoneApp

    Dim myPanels As List(Of Panel) = New List(Of Panel)
    Dim Panelocation As Point
    Public Sub DrawPanels()
        Panelocation.X = 15
        Panelocation.Y = 15

        myPanels.Add(ClockPanel)
        myPanels.Add(HomePanel)
        myPanels.Add(AppPanel)
        myPanels.Add(MessagePanel)
        myPanels.Add(SchedulePanel)
        myPanels.Add(SchedulePanel1)
        myPanels(0).Location = Panelocation
        myPanels(1).Location = Panelocation
        myPanels(2).Location = Panelocation
        myPanels(3).Location = Panelocation
        myPanels(4).Location = Panelocation
        myPanels(5).Location = Panelocation
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

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click

    End Sub

    Private Sub HomePanel_Paint(sender As Object, e As PaintEventArgs) Handles HomePanel.Paint
        TimeLabel2.Text = TimeOfDay.ToString("hh:mm tt")
    End Sub

    Private Sub AppPanel_Paint(sender As Object, e As PaintEventArgs) Handles AppPanel.Paint
        TimeLabel3.Text = TimeOfDay.ToString("hh:mm tt")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessagePanel.Visible = False
        AppPanel.Visible = True
    End Sub



    Private Sub MessagePanel_Paint(sender As Object, e As PaintEventArgs) Handles MessagePanel.Paint
        Label23.Text = TimeOfDay.ToString("hh:mm tt")
    End Sub

    Private Sub KidMessage_Click(sender As Object, e As EventArgs) Handles KidMessage.Click
        MessagePanel.Visible = True
        AppPanel.Visible = False
    End Sub

    Private Sub KidSchedule_Click(sender As Object, e As EventArgs) Handles KidSchedule.Click
        SchedulePanel.Visible = True
        AppPanel.Visible = False

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SchedulePanel.Visible = False
        SchedulePanel1.Visible = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        SchedulePanel.Visible = True
        SchedulePanel1.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SchedulePanel.Visible = False
        AppPanel.Visible = True
    End Sub

    Private Sub SchedulePanel_Paint(sender As Object, e As PaintEventArgs) Handles SchedulePanel.Paint
        Label17.Text = TimeOfDay.ToString("hh:mm tt")
    End Sub

    Private Sub SchedulePanel1_Paint(sender As Object, e As PaintEventArgs) Handles SchedulePanel1.Paint
        Label19.Text = TimeOfDay.ToString("hh:mm tt")
    End Sub
End Class