Public Class PhoneApp
    Dim myPanels As List(Of Panel) = New List(Of Panel)
    Dim Panelocation As Point
    Dim test As Integer
    Dim counter As Integer
    Dim allowance As Double
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
        myPanels.Add(CallPanel)
        myPanels.Add(CallPanel1)
        myPanels.Add(SOSPanel)
        myPanels.Add(VoiceMailPanel)
        myPanels.Add(MapPanel)
        For index As Integer = 0 To 11
            myPanels(index).Location = Panelocation
        Next
    End Sub
    Private Sub PhoneApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimeLabel.Text = TimeOfDay.ToString("hh:mm tt")
        TimeLabel2.Text = TimeOfDay.ToString("hh:mm tt")
        TimeLabel3.Text = TimeOfDay.ToString("hh:mm tt")
        TimeLabel4.Text = TimeOfDay.ToString("hh:mm tt")
        TimeLabel5.Text = TimeOfDay.ToString("hh:mm tt")
        TimeLabel6.Text = TimeOfDay.ToString("hh:mm tt")
        TimeLabel7.Text = TimeOfDay.ToString("hh:mm tt")
        TimeLabel8.Text = TimeOfDay.ToString("hh:mm tt")
        TimeLabel9.Text = TimeOfDay.ToString("hh:mm tt")
        TimeLabel10.Text = TimeOfDay.ToString("hh:mm tt")
        TimeLabel11.Text = TimeOfDay.ToString("hh:mm tt")
        TimeLabel12.Text = TimeOfDay.ToString("hh:mm tt")
        Timer1.Start()
        DateLabel.Text = Date.Now().ToString("D")
        AddVerification.Text = ""
        allowance = 5
        AllowanceAmtLabel.Text = Format(allowance, "0.00")
        'Make all other panels not visible
        DrawPanels()
        HomePanel.Visible = False
        AppPanel.Visible = False
        MessagePanel.Visible = False
        SchedulePanel.Visible = False
        SchedulePanel.Visible = False
        SchedulePanel1.Visible = False
        AddMoneyPanel.Visible = False
        CallPanel.Visible = False
        CallPanel1.Visible = False
        SOSPanel.Visible = False
        VoiceMailPanel.Visible = False
        MapPanel.Visible = False
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

    Private Sub MessageBackButton_Click(sender As Object, e As EventArgs) Handles MessageBackButton.Click, ScheduleBackButton.Click, CancelMoney.Click
        MessagePanel.Visible = False
        SchedulePanel.Visible = False
        AddMoneyPanel.Visible = False
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TimeLabel.Text = TimeOfDay.ToString("hh:mm tt")
        TimeLabel2.Text = TimeOfDay.ToString("hh:mm tt")
        TimeLabel3.Text = TimeOfDay.ToString("hh:mm tt")
        TimeLabel4.Text = TimeOfDay.ToString("hh:mm tt")
        TimeLabel5.Text = TimeOfDay.ToString("hh:mm tt")
        TimeLabel6.Text = TimeOfDay.ToString("hh:mm tt")
        TimeLabel7.Text = TimeOfDay.ToString("hh:mm tt")
        TimeLabel8.Text = TimeOfDay.ToString("hh:mm tt")
        TimeLabel9.Text = TimeOfDay.ToString("hh:mm tt")
        TimeLabel10.Text = TimeOfDay.ToString("hh:mm tt")
        TimeLabel11.Text = TimeOfDay.ToString("hh:mm tt")
        TimeLabel12.Text = TimeOfDay.ToString("hh:mm tt")

    End Sub

    Private Sub KidMoney_Click(sender As Object, e As EventArgs) Handles KidMoney.Click
        AddMoneyPanel.Visible = True
        AppPanel.Visible = False
        CurrBalanceLabel.Text = WatchForm.getBalance
    End Sub

    Private Sub AddMoney_Click(sender As Object, e As EventArgs) Handles AddMoney.Click
        WatchForm.addBalance(CDbl(Val(AmountBox.Text)))
        CurrBalanceLabel.Text = WatchForm.getBalance
        If AmountBox.Text.Length > 0 Then
            AddVerification.Text = "You have added " & AmountBox.Text & " dollars!"
        Else
            AddVerification.Text = ""
        End If
        AmountBox.Text = ""
    End Sub

    Private Sub Send_Click(sender As Object, e As EventArgs) Handles Send.Click
        SentMsg.AppendText(MessagesBox.Text & Environment.NewLine)
        WatchForm.setMessage(SentMsg.Text)
        MessagesBox.Text = ""

    End Sub

    Private Sub ClearMSG_Click(sender As Object, e As EventArgs) Handles ClearMSG.Click
        SentMsg.Text = ""
        WatchForm.setMessage(SentMsg.Text)

    End Sub

    Private Sub UpdateSchedule_Click(sender As Object, e As EventArgs) Handles UpdateSchedule.Click
        counter += 1
        countSchedule.Text = CStr(counter) & " Existing"
        ExistingS.AppendText(ScheduleBoxDate.Text & Environment.NewLine & ScheduleBoxTime.Text & Environment.NewLine & ScheduleBox.Text & Environment.NewLine & Environment.NewLine)
        WatchForm.setSchedule(ExistingS.Text)
        ScheduleBox.Text = ""
        ScheduleBoxDate.Text = ""
        ScheduleBoxTime.Text = ""
    End Sub

    Private Sub CallEndPicture_Click(sender As Object, e As EventArgs) Handles CallEndPicture.Click
        CallPanel.Visible = False
        Dim CallID = WatchForm.getCallID

        If CallID = "Mom" Then
            WatchForm.CallPanel.Visible = False
            WatchForm.ContactPanel1.Visible = True
        ElseIf CallID = "Dad" Then
            WatchForm.CallPanel.Visible = False
            WatchForm.ContactPanel2.Visible = True
        End If
    End Sub

    Private Sub countSchedule_Click(sender As Object, e As EventArgs) Handles countSchedule.Click
        SchedulePanel1.Visible = True
        SchedulePanel.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SchedulePanel1.Visible = False
        SchedulePanel.Visible = True
        If ExistingS.TextLength < 2 Then
            counter = 0
        End If
    End Sub

    Private Sub ClearAll_Click(sender As Object, e As EventArgs) Handles ClearAll.Click
        ExistingS.Text = ""
        countSchedule.Text = "None Existing"
        WatchForm.ScheduleBox.Text = ExistingS.Text
    End Sub

    Public Sub SetVoiceMail()
        VoiceMailPicture.Visible = True
    End Sub

    Public Sub SetPhoneLabel()
        Dim CallID = WatchForm.getCallID
        ParentLabel.Text = "***" & CallID & " Phone"
    End Sub

    Private Sub RejectCall_Click(sender As Object, e As EventArgs) Handles RejectCall.Click
        CallPanel1.Visible = False
        Dim CallID = WatchForm.getCallID

        If CallID = "Mom" Then
            WatchForm.RingPanel.Visible = False
            WatchForm.CallOptionPanel.Visible = True
        ElseIf CallID = "Dad" Then
            WatchForm.RingPanel.Visible = False
            WatchForm.CallOptionPanel.Visible = True
        End If
        WatchForm.setHangup()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles AcceptCall.Click
        CallPanel1.Visible = False
        CallPanel.Visible = True
        WatchForm.RingPanel.Visible = False
        WatchForm.CallPanel.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SOSPanel.Visible = False
    End Sub

    Private Sub VoiceMailPicture_Click(sender As Object, e As EventArgs) Handles VoiceMailPicture.Click
        VoiceMailPicture.Visible = False
        VoiceMailPanel.Visible = True
    End Sub

    Private Sub CallEndPicture2_Click(sender As Object, e As EventArgs) Handles CallEndPicture2.Click
        VoiceMailPanel.Visible = False
        AppPanel.Visible = True
    End Sub

    Private Sub SetAllowance_Click(sender As Object, e As EventArgs) Handles SetAllowance.Click
        allowance = CDbl(Val(AllowanceBox.Text))
        AllowanceBox.Text = ""
        AllowanceAmtLabel.Text = Format(allowance, "0.00")
    End Sub

    Private Sub AddAllowance_Click(sender As Object, e As EventArgs) Handles AddAllowance.Click
        WatchForm.addBalance(allowance)
        AddVerification.Text = "You have added " & Format(allowance, "0.00") & " dollars!"
        CurrBalanceLabel.Text = WatchForm.getBalance
    End Sub

    Private Sub MapPicture_Click(sender As Object, e As EventArgs) Handles MapPicture.Click
        MapPanel.Visible = True
        AppPanel.Visible = False
    End Sub

    Private Sub BackButtonMap_Click(sender As Object, e As EventArgs) Handles BackButtonMap.Click
        MapPanel.Visible = False
        AppPanel.Visible = True
    End Sub
End Class