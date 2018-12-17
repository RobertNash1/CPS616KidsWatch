Public Class WatchForm
    Dim myPanels As List(Of Panel) = New List(Of Panel)
    Dim Panelocation As Point
    Dim Balance As Double
    Dim Message As String
    Dim Schedule As String
    Dim CallID As String
    Public Sub DrawPanels()
        Panelocation.X = 31
        Panelocation.Y = 30
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
        myPanels.Add(MusicPanel1)
        myPanels.Add(MusicPanel2)
        myPanels.Add(MusicPanel3)
        myPanels.Add(MessagePanel)
        myPanels.Add(MessagePanel1)
        myPanels.Add(CallPanel)
        myPanels.Add(RingPanel)
        myPanels.Add(HelpPanel)
        myPanels.Add(HelpPanel1)
        myPanels.Add(CallOptionPanel)
        myPanels.Add(VoiceMailPanel)
        myPanels.Add(MapPanel)
        myPanels.Add(LocationPanel)
        For index As Integer = 0 To 24
            myPanels(index).Location = Panelocation
        Next
    End Sub

    Private Sub ReDrawHomePicture(Alert As Boolean)
        Dim PictureLoc As Point
        PictureLoc.X = 30
        PictureLoc.Y = 50
        If Alert = True Then
            HomePicture.Size.Height.Equals(75)
            HomePicture.Size.Width.Equals(80)
        Else
            MessageBox.Show("Error")
            HomePicture.Size.Height.Equals(75)
            HomePicture.Size.Width.Equals(125)

        End If
        HomePicture.Location = PictureLoc
        HomePicture.Refresh()
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
        CallOptionPanel.Visible = False
        VoiceMailPanel.Visible = False
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
        MusicPanel1.Visible = False
        MusicPanel2.Visible = False
        MusicPanel3.Visible = False
        MessagePanel.Visible = False
        MessagePanel1.Visible = False
        CallPanel.Visible = False
        RingPanel.Visible = False
        HelpPanel.Visible = False
        HelpPanel1.Visible = False
        GamesPanel1.Visible = False
        MapPanel.Visible = False
        LocationPanel.Visible = False
    End Sub

    Private Sub RightButton_Click(sender As Object, e As EventArgs) Handles RightButton.Click
        ClockPanel.Visible = False
        ContactPanel.Visible = True
    End Sub

    Private Sub LeftButton_Click(sender As Object, e As EventArgs) Handles LeftButton.Click
        MapPanel.Visible = True
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
    Private Sub MapLeft_Click(sender As Object, e As EventArgs) Handles MapLeft.Click
        MapPanel.Visible = False
        MusicPanel.Visible = True
    End Sub
    Private Sub MapRight_Click(sender As Object, e As EventArgs) Handles MapRight.Click
        MapPanel.Visible = False
        ClockPanel.Visible = True
    End Sub

    Private Sub MusicRight_Click(sender As Object, e As EventArgs) Handles MusicRight.Click
        MapPanel.Visible = True
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
        BalanceLabel.Text = Format(Balance, "0.00")
    End Sub

    Private Sub PaymentUp1_Click(sender As Object, e As EventArgs) Handles PaymentUp1.Click
        PaymentPanel.Visible = True
        PaymentPanel1.Visible = False
    End Sub

    Private Sub ScheduleDown_Click(sender As Object, e As EventArgs) Handles ScheduleDown.Click, NewScheduleItem.Click
        SchedulePanel.Visible = False
        SchedulePanel1.Visible = True
        NewScheduleItem.Visible = False
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

    Private Sub MessageDown_Click(sender As Object, e As EventArgs) Handles MessageDown.Click, NewMessageItem.Click
        MessagePanel.Visible = False
        MessagePanel1.Visible = True
        NewMessageItem.Visible = False
        'MessageBox
        If Message.Length > 0 Then
            MessagesBox.Text = Message
        Else
            MessagesBox.Text = ""
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

    Public Sub setHangup()
        OptionLabel.Text = CallID & " Hung Up"
    End Sub

    Public Sub setMessage(msg As String)
        Message = msg
        MessagesBox.Text = Message
        NewMessageItem.Visible = True
    End Sub
    Public Function getSchedule()
        Return Schedule
    End Function

    Public Sub setSchedule(msg As String)
        Schedule = msg
        ScheduleBox.AppendText(Schedule & Environment.NewLine)
        NewScheduleItem.Visible = True
    End Sub

    Private Sub TapToPay_Click(sender As Object, e As EventArgs) Handles TapToPay.Click
        PaymentPanel2.Visible = False
        PaymentPanel1.Visible = True
        Balance = Balance - 8
        BalanceLabel.Text = Balance
    End Sub

    Private Sub MomPicture_Click(sender As Object, e As EventArgs) Handles MomPicture.Click, MomCallButton.Click, CallMom.Click
        CallID = "Mom"
        PhoneApp.SetPhoneLabel()
        IDLabel.Text = CallID
        RingPanel.Visible = True
        ContactPanel1.Visible = False
        PhoneApp.CallPanel1.Visible = True
    End Sub

    Private Sub DadPicture_Click(sender As Object, e As EventArgs) Handles DadPicture.Click, DadCallButton.Click, CallDad.Click
        CallID = "Dad"
        PhoneApp.SetPhoneLabel()
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

    Private Sub RingPanelButtonUp_Click(sender As Object, e As EventArgs) Handles RingPanelButtonUp.Click
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

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click

        If RingPanel.Visible = True Then
            PhoneApp.CallPanel1.Visible = False
        End If
        If CallPanel.Visible = True Then
            PhoneApp.CallPanel.Visible = False
        End If

        ClockPanel.Visible = True
        CallOptionPanel.Visible = False
        VoiceMailPanel.Visible = False
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
        MusicPanel1.Visible = False
        MusicPanel2.Visible = False
        MusicPanel3.Visible = False
        MessagePanel.Visible = False
        MessagePanel1.Visible = False
        CallPanel.Visible = False
        RingPanel.Visible = False
        HelpPanel.Visible = False
        HelpPanel1.Visible = False
        GamesPanel1.Visible = False
        MapPanel.Visible = False
        LocationPanel.Visible = False
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        PhoneApp.SOSPanel.Visible = True
        HelpPanel.Visible = False
        HelpPanel1.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        HelpPanel.Visible = True
        ContactPanel2.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ContactPanel2.Visible = True
        HelpPanel.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ContactPanel.Visible = True
        HelpPanel1.Visible = False
    End Sub

    Private Sub GamesDown_Click(sender As Object, e As EventArgs) Handles GamesDown.Click
        GamesPanel.Visible = False
        GamesPanel1.Visible = True
    End Sub

    Private Sub GamesUp_Click(sender As Object, e As EventArgs) Handles GamesUp.Click
        GamesPanel.Visible = True
        GamesPanel1.Visible = False
    End Sub

    Private Sub HangUpPicture_Click(sender As Object, e As EventArgs) Handles HangUpPicture.Click, HangUpPicture2.Click, OptionPanelUpButton.Click, VoiceMailPanelUpButton.Click
        CallOptionPanel.Visible = False
        VoiceMailPanel.Visible = False
        ContactPanel.Visible = True
    End Sub

    Private Sub VoiceMessagePicture_Click(sender As Object, e As EventArgs) Handles VoiceMessagePicture.Click
        VoiceMailPanel.Visible = True
        CallOptionPanel.Visible = False
        PhoneApp.SetVoiceMail()
    End Sub

    Private Sub MusicDown_Click(sender As Object, e As EventArgs) Handles MusicDown.Click
        MusicPanel.Visible = False
        MusicPanel1.Visible = True
    End Sub

    Private Sub MusicDown1_Click(sender As Object, e As EventArgs) Handles MusicDown1.Click
        MusicPanel1.Visible = False
        MusicPanel2.Visible = True
    End Sub

    Private Sub MusicUp1_Click(sender As Object, e As EventArgs) Handles MusicUp1.Click
        MusicPanel1.Visible = False
        MusicPanel.Visible = True
    End Sub

    Private Sub MusicUp2_Click(sender As Object, e As EventArgs) Handles MusicUp2.Click
        MusicPanel2.Visible = False
        MusicPanel1.Visible = True
    End Sub

    Private Sub MusicDown2_Click(sender As Object, e As EventArgs) Handles MusicDown2.Click
        MusicPanel2.Visible = False
        MusicPanel3.Visible = True
    End Sub

    Private Sub MusicUp3_Click(sender As Object, e As EventArgs) Handles MusicUp3.Click
        MusicPanel3.Visible = False
        MusicPanel2.Visible = True
    End Sub

    Private Sub Song1_Click(sender As Object, e As EventArgs) Handles Song1.Click
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play(My.Resources.DesiJourney, AudioPlayMode.Background)
    End Sub

    Private Sub Song2_Click(sender As Object, e As EventArgs) Handles Song2.Click
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play(My.Resources.Shake, AudioPlayMode.Background)
    End Sub

    Private Sub Song3_Click(sender As Object, e As EventArgs) Handles Song3.Click
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play(My.Resources.UpbeatFunk, AudioPlayMode.Background)
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        My.Computer.Audio.Stop()
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        My.Computer.Audio.Stop()
    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        My.Computer.Audio.Stop()
    End Sub

    Private Sub MapButtonDown_Click(sender As Object, e As EventArgs) Handles MapButtonDown.Click
        MapPanel.Visible = False
        LocationPanel.Visible = True
    End Sub

    Private Sub HereButtonUp_Click(sender As Object, e As EventArgs) Handles HereButtonUp.Click
        MapPanel.Visible = True
        LocationPanel.Visible = False
    End Sub

    Private Sub VolumeDown_Click(sender As Object, e As EventArgs) Handles VolumeDown.Click

    End Sub
End Class
