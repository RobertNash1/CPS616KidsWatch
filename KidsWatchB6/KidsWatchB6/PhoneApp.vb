﻿Public Class PhoneApp
    Dim myPanels As List(Of Panel) = New List(Of Panel)
    Dim Panelocation As Point
    Dim test As Integer
    Public Sub DrawPanels()
        Panelocation.X = 15
        Panelocation.Y = 15
        myPanels.Add(ClockPanel)
        myPanels.Add(AddMoneyPanel)
        myPanels.Add(HomePanel)
        myPanels.Add(AppPanel)
        myPanels.Add(MessagePanel)
        myPanels.Add(SchedulePanel)
        myPanels.Add(CallPanel)
        For index As Integer = 0 To 6
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
        Timer1.Start()
        DateLabel.Text = Date.Now().ToString("D")
        AddVerification.Text = ""
        'Make all other panels not visible
        DrawPanels()
        HomePanel.Visible = False
        AppPanel.Visible = False
        MessagePanel.Visible = False
        SchedulePanel.Visible = False
        SchedulePanel.Visible = False
        AddMoneyPanel.Visible = False
        CallPanel.Visible = False
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        TimeLabel2.Text = TimeOfDay.ToString("hh:mm tt")
        TimeLabel3.Text = TimeOfDay.ToString("hh:mm tt")
        TimeLabel4.Text = TimeOfDay.ToString("hh:mm tt")
        TimeLabel5.Text = TimeOfDay.ToString("hh:mm tt")
        TimeLabel6.Text = TimeOfDay.ToString("hh:mm tt")
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
        WatchForm.setMessage(MessageBox.Text)
        SentMsg.AppendText(MessageBox.Text & Environment.NewLine)

        MessageBox.Text = ""

    End Sub

    Private Sub UpdateSchedule_Click(sender As Object, e As EventArgs) Handles UpdateSchedule.Click
        WatchForm.setSchedule(ScheduleBox.Text)
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

    Private Sub ScheduleBox_TextChanged(sender As Object, e As EventArgs) Handles ScheduleBox.TextChanged

    End Sub
End Class