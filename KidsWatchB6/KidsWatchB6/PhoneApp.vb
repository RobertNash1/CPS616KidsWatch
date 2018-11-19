﻿Public Class PhoneApp

    Dim myPanels As List(Of Panel) = New List(Of Panel)
    Dim Panelocation As Point
    Public Sub DrawPanels()
        Panelocation.X = 15
        Panelocation.Y = 15

        myPanels.Add(ClockPanel)
        myPanels.Add(HomePanel)
        myPanels.Add(AppPanel)
        myPanels.Add(MessagePanel)

        myPanels(0).Location = Panelocation
        myPanels(1).Location = Panelocation
        myPanels(2).Location = Panelocation
        myPanels(3).Location = Panelocation

    End Sub
    Private Sub PhoneApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimeLabel.Text = TimeOfDay.ToString("hh:mm tt")
        DateLabel.Text = Date.Now().ToString("D")
        DrawPanels()
        HomePanel.Visible = False
        AppPanel.Visible = False
        MessagePanel.Visible = False
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

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        MessagePanel.Visible = True
        AppPanel.Visible = False
    End Sub
End Class