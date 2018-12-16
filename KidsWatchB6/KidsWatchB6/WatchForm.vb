Public Class WatchForm
    Dim myPanels As List(Of Panel) = New List(Of Panel)
    Dim Panelocation As Point
    Dim Balance As Double
    Dim Message As String
    Dim Schedule As String
    Dim CallID As String
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
        myPanels.Add(MusicPanel)
        myPanels.Add(MessagePanel)
        myPanels.Add(MessagePanel1)
        myPanels.Add(CallPanel)
        myPanels.Add(RingPanel)
        For index As Integer = 0 To 14
            myPanels(index).Location = Panelocation
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimeLabel.Text = TimeOfDay.ToString("hh:mm tt")
        DateLabel.Text = Date.Now().ToString("D")
        Timer1.Start()
        Balance = 5
        Message = ""
        Schedule = ""
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
        MusicPanel.Visible = False
        MessagePanel.Visible = False
        MessagePanel1.Visible = False
        CallPanel.Visible = False
        RingPanel.Visible = False
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
        BalanceLabel.Text = Balance
    End Sub

    Private Sub PaymentUp1_Click(sender As Object, e As EventArgs) Handles PaymentUp1.Click
        PaymentPanel.Visible = True
        PaymentPanel1.Visible = False
    End Sub

    Private Sub ScheduleDown_Click(sender As Object, e As EventArgs) Handles ScheduleDown.Click
        SchedulePanel.Visible = False
        SchedulePanel1.Visible = True
        If Schedule.Length > 0 Then
            ScheduleBox.Text = Schedule
        Else
            ScheduleBox.Text = ""
            '  ScheduleBox.Text = "You have nothing scheduled for today."
        End If
    End Sub

    Private Sub ScheduleUp_Click(sender As Object, e As EventArgs) Handles ScheduleUp.Click
        SchedulePanel.Visible = True
        SchedulePanel1.Visible = False
    End Sub

    Private Sub PaymentDown1_Click(sender As Object, e As EventArgs) Handles PaymentDown1.Click
        PaymentPanel1.Visible = False
        PaymentPanel2.Visible = True
    End Sub

    Private Sub PaymentUp2_Click(sender As Object, e As EventArgs) Handles PaymentUp2.Click
        PaymentPanel2.Visible = False
        PaymentPanel1.Visible = True
    End Sub

    Private Sub MessageDown_Click(sender As Object, e As EventArgs) Handles MessageDown.Click
        MessagePanel.Visible = False
        MessagePanel1.Visible = True
        'MessageBox
        If Message.Length > 0 Then
            MessageBox.Text = Message
        Else
            MessageBox.Text = ""
            '    MessageBox.Text = "You have no messages."
        End If
    End Sub

    Private Sub MessageUp_Click(sender As Object, e As EventArgs) Handles MessageUp.Click
        MessagePanel.Visible = True
        MessagePanel1.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TimeLabel.Text = TimeOfDay.ToString("hh:mm tt")
    End Sub

    Public Sub addBalance(amt As Double)
        Balance = Balance + amt
        BalanceLabel.Text = Balance
    End Sub
    Public Function getBalance()
        Return Balance
    End Function

    Public Function getMessages()
        Return Message
    End Function

    Public Sub setMessage(msg As String)
        Message = msg
        MessageBox.AppendText(Message & Environment.NewLine)

    End Sub
    Public Function getSchedule()
        Return Schedule
    End Function

    Public Sub setSchedule(msg As String)
        Schedule = msg
        ScheduleBox.AppendText(Schedule & Environment.NewLine)
    End Sub

    Private Sub TapToPay_Click(sender As Object, e As EventArgs) Handles TapToPay.Click
        PaymentPanel2.Visible = False
        PaymentPanel1.Visible = True
        Balance = Balance - 8.63
        BalanceLabel.Text = Balance
    End Sub

    Private Sub MomPicture_Click(sender As Object, e As EventArgs) Handles MomPicture.Click, MomCallButton.Click
        CallID = "Mom"
        IDLabel.Text = CallID
        RingPanel.Visible = True
        ContactPanel1.Visible = False
        PhoneApp.CallPanel1.Visible = True
    End Sub

    Private Sub DadPicture_Click(sender As Object, e As EventArgs) Handles DadPicture.Click, DadCallButton.Click
        CallID = "Dad"
        IDLabel.Text = CallID
        RingPanel.Visible = True
        ContactPanel2.Visible = False
        PhoneApp.CallPanel1.Visible = True
    End Sub

    Private Sub CallEndButton_Click(sender As Object, e As EventArgs) Handles CallEndButton.Click, CallPicture.Click
        If CallID = "Mom" Then
            CallPanel.Visible = False
            ContactPanel1.Visible = True
            PhoneApp.CallPanel.Visible = False
        ElseIf CallID = "Dad" Then
            CallPanel.Visible = False
            ContactPanel2.Visible = True
            PhoneApp.CallPanel.Visible = False
        End If
    End Sub

    Public Function getCallID()
        Return CallID
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CallID = "Mom" Then
            RingPanel.Visible = False
            ContactPanel1.Visible = True
            PhoneApp.CallPanel1.Visible = False
        ElseIf CallID = "Dad" Then
            RingPanel.Visible = False
            ContactPanel2.Visible = True
            PhoneApp.CallPanel1.Visible = False
        End If
    End Sub
End Class
