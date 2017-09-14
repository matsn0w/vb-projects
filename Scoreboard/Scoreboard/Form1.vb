Public Class Form1
    ' Declare vars
    Dim minutes, seconds As Integer

    Private Sub NUDScoreHome_ValueChanged(sender As Object, e As EventArgs) Handles NUDScoreHome.ValueChanged
        ' Set NUDScoreHome's value to lblScoreHome
        If NUDScoreHome.Value < 10 Then
            lblScoreHome.Text = "0" & NUDScoreHome.Value
        Else
            lblScoreHome.Text = NUDScoreHome.Value
        End If

        Form2.Show()
        Form2.lblGoalTeam.Text = "Home scored!"
    End Sub

    Private Sub NUDScoreGuests_ValueChanged(sender As Object, e As EventArgs) Handles NUDScoreGuests.ValueChanged
        ' Set NUDScoreGuests's value to lblScoreGuests
        If NUDScoreGuests.Value < 10 Then
            lblScoreGuests.Text = "0" & NUDScoreGuests.Value
        Else
            lblScoreGuests.Text = NUDScoreGuests.Value
        End If

        Form2.Show()
        Form2.lblGoalTeam.Text = "Guest scored!"
    End Sub

    Private Sub btnClockStart_Click(sender As Object, e As EventArgs) Handles btnClockStart.Click
        ' Start the timer
        Timer1.Enabled = True
    End Sub

    Private Sub btnClockStop_Click(sender As Object, e As EventArgs) Handles btnClockStop.Click
        ' Stop the timer
        Timer1.Enabled = False
    End Sub

    Private Sub btnClockReset_Click(sender As Object, e As EventArgs) Handles btnClockReset.Click
        ' Stop the timer
        Timer1.Enabled = False

        ' Reset the values
        seconds = 0
        minutes = 0

        ' Update the labels
        lblClockSeconds.Text = "00"
        lblClockMinutes.Text = "00"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Set up clock
        seconds = seconds + 1
        lblClockSeconds.Text = seconds

        ' Handle minutes
        If seconds = 59 Then
            minutes = minutes + 1
            lblClockMinutes.Text = minutes
            seconds = 0
        End If

        ' Handle the leading zero's
        If seconds < 10 Then
            lblClockSeconds.Text = "0" & seconds
        End If

        If minutes < 10 Then
            lblClockMinutes.Text = "0" & minutes
        End If
    End Sub
End Class
