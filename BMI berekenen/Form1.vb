Public Class Form1
    ' Declare vars
    Dim length As Integer
    Dim weight As Integer
    Dim BMI As Double
    Dim explanation As String

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Grab the input from the user and store it in the vars
        length = tbxLength.Text
        weight = tbxWeight.Text

        ' Calculate the BMI
        ' BMI = weight / (length^2)
        BMI = weight / (length * length)

        ' Round the BMI
        BMI = Math.Round(BMI, 1)

        ' Print the result to the screen
        lblResult.Text = "Uw BMI is: " & BMI
        lblResult.Show()

        ' Explanation
        If BMI <= 18.5 Then
            explanation = "U heeft ondergewicht!"
        End If

        If BMI >= 5 And BMI <= 25 Then
            explanation = "U heeft een gezond gewicht!"
        End If

        If BMI >= 25 And BMI <= 30 Then
            explanation = "U heeft overgewicht!"
        End If

        If BMI >= 30 And BMI <= 40 Then
            explanation = "U heeft obesitas!"
        End If

        If BMI > 40 Then
            explanation = "U heeft morbide obesitas!"
        End If

        lblExplanation.Text = "Toelichting: " + explanation
        lblExplanation.Show()
    End Sub
End Class
