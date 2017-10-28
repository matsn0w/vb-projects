' Import currency information
Imports System.Globalization

Public Class Form1
    ' Declare the vars
    Dim car As String
    Dim carIndex As Integer
    Dim time As Integer
    Dim weeks As Integer
    Dim days As Integer
    Dim newTime As Integer
    Dim distance As Integer
    Dim startDay As DateTime
    Dim endDay As DateTime
    Dim allowance As Decimal
    Dim insurance As Decimal
    Dim basePrice As Decimal
    Dim price As Decimal

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Grab the values
        car = cbxCar.Text
        carIndex = cbxCar.SelectedIndex
        time = DateDiff(DateInterval.Day, MonthCalendar1.SelectionStart, MonthCalendar2.SelectionStart) + 1
        distance = nudDistance.Value
        startDay = MonthCalendar1.SelectionStart
        endDay = MonthCalendar2.SelectionStart

        ' Check if the second date is greater then the first date
        If startDay > endDay Then
            MessageBox.Show("De einddatum moet later zijn dan de begindatum!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MonthCalendar1.SetDate(Today)
            MonthCalendar2.SetDate(Today)
        End If

        ' Check if there are weeks
        If time Mod 7 = 0 Then
            days = 0
            weeks = time / 7
        Else
            days = time Mod 7
            weeks = (time - days) / 7
        End If

        ' Calculate baseprice
        Select Case carIndex
            Case 0
                basePrice = (15.49 * days) + (99.99 * weeks)
            Case 1
                basePrice = (17.99 * days) + (109.99 * weeks)
            Case 2
                basePrice = (22.29 * days) + (149.99 * weeks)
            Case 3
                basePrice = (23.59 * days) + (162.37 * weeks)
            Case 4
                basePrice = (26.55 * days) + (179.49 * weeks)
            Case Else
                MessageBox.Show("Ongeldig voertuig!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select

        ' Calculate allowance
        If distance > 200 Then
            Select Case carIndex
                Case 0
                    allowance = 0.025 * (distance - 200)
                Case 1
                    allowance = 0.03 * (distance - 200)
                Case 2
                    allowance = 0.04 * (distance - 200)
                Case 3
                    allowance = 0.05 * (distance - 200)
                Case 4
                    allowance = 0.05 * (distance - 200)
                Case Else
                    MessageBox.Show("Ongeldig voertuig!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        ElseIf distance <= 200 Then
            allowance = 0
        End If

        ' Calculate insurance
        Select Case carIndex
            Case 0
                insurance = 2.99 * time
            Case 1
                insurance = 4.19 * time
            Case 2
                insurance = 4.99 * time
            Case 3
                insurance = 5.59 * time
            Case 4
                insurance = 5.59 * time
        End Select

        ' Calculate final price
        price = basePrice + allowance + insurance

        ' Print the results
        tbxResultCar.Text = car
        tbxResultWeeks.Text = weeks
        tbxResultDays.Text = days
        tbxResultStart.Text = MonthCalendar1.SelectionStart.ToLongDateString
        tbxResultEnd.Text = MonthCalendar2.SelectionStart.ToLongDateString
        tbxResultDistance.Text = distance & " kilometer"
        tbxResultAllowance.Text = allowance.ToString("C2", New CultureInfo("nl-NL"))    ' Display in euros
        tbxResultInsurance.Text = insurance.ToString("C2", New CultureInfo("nl-NL"))    ' Display in euros
        tbxResultBasePrice.Text = basePrice.ToString("C2", New CultureInfo("nl-NL"))    ' Display in euros
        tbxResultPrice.Text = price.ToString("C2", New CultureInfo("nl-NL"))            ' Display in euros
    End Sub
End Class
