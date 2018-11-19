Public Class WatchForm
    Dim myPanels As List(Of Panel) = New List(Of Panel)
    Dim Panelocation As Point
    Public Sub DrawPanels()
        Panelocation.X = 15
        Panelocation.Y = 15
        myPanels.Add(ClockPanel)
        myPanels.Add(ContactPanel)
        myPanels.Add(ContactPanel1)
        myPanels.Add(ContactPanel2)
        myPanels.Add(PaymentPanel)
        myPanels.Add(PaymentPanel1)
        myPanels.Add(PaymentPanel2)
        myPanels.Add(SchedulePanel)
        myPanels.Add(SchedulePanel1)
        myPanels.Add(GamesPanel)
        myPanels.Add(GamesPanel1)
        myPanels.Add(MusicPanel)
        myPanels.Add(MessagePanel)
        myPanels.Add(MessagePanel1)
        myPanels(0).Location = Panelocation
        myPanels(1).Location = Panelocation
        myPanels(2).Location = Panelocation
        myPanels(3).Location = Panelocation
        myPanels(4).Location = Panelocation
        myPanels(5).Location = Panelocation
        myPanels(6).Location = Panelocation
        myPanels(7).Location = Panelocation
        myPanels(8).Location = Panelocation
        myPanels(9).Location = Panelocation
        myPanels(10).Location = Panelocation
        myPanels(11).Location = Panelocation
        myPanels(12).Location = Panelocation
        myPanels(13).Location = Panelocation
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimeLabel.Text = TimeOfDay.ToString("hh:mm tt")
        DateLabel.Text = Date.Now().ToString("D")
        PhoneApp.Show()
        DrawPanels()
        'Make all other panels not visible
        ContactPanel.Visible = False
        ContactPanel1.Visible = False
        ContactPanel2.Visible = False
        PaymentPanel.Visible = False
        PaymentPanel1.Visible = False
        PaymentPanel2.Visible = False
        SchedulePanel.Visible = False
        SchedulePanel1.Visible = False
        GamesPanel.Visible = False
        GamesPanel1.Visible = False
        MusicPanel.Visible = False
        MessagePanel.Visible = False
        MessagePanel1.Visible = False
    End Sub

    Public Sub AddTask(e As String)
        TreeView1.Nodes.Add(1, "test")
    End Sub

    Private Sub RightButton_Click(sender As Object, e As EventArgs) Handles RightButton.Click
        ClockPanel.Visible = False
        ContactPanel.Visible = True
    End Sub

    Private Sub LeftButton_Click(sender As Object, e As EventArgs) Handles LeftButton.Click
        MusicPanel.Visible = True
        ClockPanel.Visible = False
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
        MessagePanel.Visible = True
    End Sub

    Private Sub MessageLeft_Click(sender As Object, e As EventArgs) Handles MessageLeft.Click
        PaymentPanel.Visible = True
        MessagePanel.Visible = False
    End Sub

    Private Sub MessageRight_Click(sender As Object, e As EventArgs) Handles MessageRight.Click
        SchedulePanel.Visible = True
        MessagePanel.Visible = False
    End Sub

    Private Sub ScheduleLeft_Click(sender As Object, e As EventArgs) Handles ScheduleLeft.Click
        SchedulePanel.Visible = False
        MessagePanel.Visible = True
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
        MusicPanel.Visible = True
    End Sub

    Private Sub MusicLeft_Click(sender As Object, e As EventArgs) Handles MusicLeft.Click
        GamesPanel.Visible = True
        MusicPanel.Visible = False
    End Sub
    Private Sub MusicRight_Click(sender As Object, e As EventArgs) Handles MusicRight.Click
        ClockPanel.Visible = True
        MusicPanel.Visible = False
    End Sub

    Private Sub ContactDown_Click(sender As Object, e As EventArgs) Handles ContactDown.Click
        ContactPanel.Visible = False
        ContactPanel1.Visible = True
    End Sub

    Private Sub ContactUp1_Click(sender As Object, e As EventArgs) Handles ContactUp1.Click
        ContactPanel.Visible = True
        ContactPanel1.Visible = False
    End Sub

    Private Sub ContactDown1_Click(sender As Object, e As EventArgs) Handles ContactDown1.Click
        ContactPanel1.Visible = False
        ContactPanel2.Visible = True
    End Sub

    Private Sub ContactUp2_Click(sender As Object, e As EventArgs) Handles ContactUp2.Click
        ContactPanel2.Visible = False
        ContactPanel1.Visible = True
    End Sub

    Private Sub PaymentDown_Click(sender As Object, e As EventArgs) Handles PaymentDown.Click
        PaymentPanel.Visible = False
        PaymentPanel1.Visible = True
    End Sub

    Private Sub PaymentUp1_Click(sender As Object, e As EventArgs) Handles PaymentUp1.Click
        PaymentPanel.Visible = True
        PaymentPanel1.Visible = False
    End Sub

    Private Sub ScheduleDown_Click(sender As Object, e As EventArgs) Handles ScheduleDown.Click
        SchedulePanel.Visible = False
        SchedulePanel1.Visible = True

        'Deal with Schedule items

    End Sub

    Private Sub ScheduleUp_Click(sender As Object, e As EventArgs) Handles ScheduleUp.Click
        SchedulePanel.Visible = True
        SchedulePanel1.Visible = False
    End Sub

    Private Sub GamesDown_Click(sender As Object, e As EventArgs) Handles GamesDown.Click
        GamesPanel.Visible = False
        GamesPanel1.Visible = True
    End Sub

    Private Sub GamesUp1_Click(sender As Object, e As EventArgs) Handles GamesUp1.Click
        GamesPanel.Visible = True
        GamesPanel1.Visible = False
    End Sub

    Private Sub PaymentDown1_Click(sender As Object, e As EventArgs) Handles PaymentDown1.Click
        PaymentPanel1.Visible = False
        PaymentPanel2.Visible = True
    End Sub

    Private Sub PaymentUp2_Click(sender As Object, e As EventArgs) Handles PaymentUp2.Click
        PaymentPanel2.Visible = False
        PaymentPanel1.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Test.Click
        AddTask("irrelevant")
    End Sub

    Private Sub MessageDown_Click(sender As Object, e As EventArgs) Handles MessageDown.Click
        MessagePanel.Visible = False
        MessagePanel1.Visible = True
    End Sub

    Private Sub MessageUp_Click(sender As Object, e As EventArgs) Handles MessageUp.Click
        MessagePanel.Visible = True
        MessagePanel1.Visible = False
    End Sub
End Class
