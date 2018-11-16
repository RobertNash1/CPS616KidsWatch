Public Class PhoneApp
    Private Sub PhoneApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimeLabel.Text = TimeOfDay.ToString("hh:mm tt")
        DateLabel.Text = Date.Now().ToString("D")
    End Sub
End Class