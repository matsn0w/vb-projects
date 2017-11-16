' Import currency information
Imports System.Globalization

Public Class Form1
    ' Define vars
    Dim flength As Decimal
    Dim fwidth As Decimal
    Dim surface As Decimal
    Dim colorText As String
    Dim price As Decimal
    Dim discount As Decimal
    Dim discountpercentage As Decimal
    Dim totalprice As Decimal

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Grab the values
        Try
            flength = tbxInputLength.Text
            fwidth = tbxInputWidth.Text
            colorText = cbxInputColor.Text
            Exit Try
        Catch ex As Exception
            MessageBox.Show("Please fill out all fields!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' Calculate surface
        surface = flength * fwidth

        ' Calculate price
        If colorText = "Groen" Then
            price = surface * 15.75
        ElseIf colorText = "Paars" Then
            price = surface * 17
        Else
            MessageBox.Show("Please select a color!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' Calulate discount
        If price >= 25000 And price < 50000 Then
            discountpercentage = 0.05
        ElseIf price >= 50000 And price < 75000 Then
            discountpercentage = 0.075
        ElseIf price >= 75000 And price < 100000 Then
            discountpercentage = 0.1
        ElseIf price >= 100000 Then
            discountpercentage = 0.15
        Else
            discountpercentage = 0
        End If

        ' Calculate totalprice
        totalprice = price - (price * discountpercentage)

        ' Get discount
        If discountpercentage > 0 Then
            discount = price * discountpercentage
        End If

        ' Print values to the screen
        tbxOutputSurface.Text = surface
        tbxOutputColor.Text = colorText
        tbxOutputPrice.Text = price.ToString("C2", New CultureInfo("nl-NL"))
        tbxOutputDiscount.Text = discount.ToString("C2", New CultureInfo("nl-NL"))
        lblOutputDiscountPercentage.Text = "( " & (discountpercentage * 100) & "%)"
        tbxOutputTotalPrice.Text = totalprice.ToString("C2", New CultureInfo("nl-NL"))
    End Sub
End Class
