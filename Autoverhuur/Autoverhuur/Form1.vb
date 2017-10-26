Public Class Form1
    ' Declare vars
    Dim car As String
    Dim days As Integer
    Dim weeks As Integer

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Grab the info
        car = cbxCar.Text
        days = DateDiff(DateInterval.Day, MonthCalendar1.SelectionStart, MonthCalendar2.SelectionEnd)

        ' Print info to the screen
        tbxResultCar.Text = car
        ' Calculate the weeks, if 
        If days Mod 7 = 0 Then
            weeks = days / 7
            tbxResultWeeks.Text = weeks.ToString
        ElseIf days > 7 Then 'dunno
            weeks = weeks + 1
            days = days - 7
        End If

        tbxResultDays.Text = days

        ' Calculate the price

    End Sub
End Class
