' Import currency information
Imports System.Globalization

Public Class Form1
    ' Declare the vars
    Dim car As Integer
    Dim time As Integer
    Dim startDay As DateTime
    Dim endDay As DateTime
    Dim price As Decimal

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Grab the values
        car = cbxCar.SelectedIndex
        time = DateDiff(DateInterval.Day, MonthCalendar1.SelectionStart, MonthCalendar2.SelectionStart)
        startDay = MonthCalendar1.SelectionStart
        endDay = MonthCalendar2.SelectionStart

        ' Check if the second date is greater then the first date
        If startDay > endDay Then
            MessageBox.Show("De einddatum moet later zijn dan de begindatum!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MonthCalendar1.SetDate(Today)
            MonthCalendar2.SetDate(Today)
        End If

        ' Calculate the price
        Select Case car
            Case 0
                price = 15.49 * time
            Case 1
                price = 17.99 * time
            Case 2
                price = 22.29 * time
            Case 3
                price = 23.59 * time
            Case 4
                price = 26.55 * time
            Case Else
                MessageBox.Show("Invalid price!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select

        ' Print the values
        tbxResultCar.Text = car
        tbxResultTime.Text = time & " dagen"
        tbxResultStart.Text = MonthCalendar1.SelectionStart.ToLongDateString
        tbxResultEnd.Text = MonthCalendar2.SelectionStart.ToLongDateString
        tbxResultPrice.Text = price.ToString("C2", New CultureInfo("nl-NL")) ' Display the price in euros
    End Sub
End Class
