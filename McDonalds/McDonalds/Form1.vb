' Import currency info
Imports System.Globalization

Public Class Form1
    ' Declare vars
    Dim bigmac As Integer
    Dim mcchicken As Integer
    Dim bigtastybacon As Integer
    Dim frites As String
    Dim drinks As String
    Dim drinksize As String
    Dim priceBigMac As Decimal
    Dim priceMcChicken As Decimal
    Dim priceBigTastyBacon As Decimal
    Dim priceBurgers As Decimal
    Dim priceFrites As Decimal
    Dim priceDrinks As Decimal
    Dim price As Decimal

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Grab values
        bigmac = nudBurgersBigMac.Value
        mcchicken = nudBurgersMcChicken.Value
        bigtastybacon = nudBurgersBigTastyBacon.Value

        For Each rb In gbxFriet.Controls
            If rb.Checked = True Then
                frites = rb.Text
            End If
        Next

        For Each drink In gbxDrinks.Controls.OfType(Of RadioButton)
            If drink.Checked = True Then
                drinks = drink.Text
            End If
        Next

        drinksize = cbxDrinksSize.Text

        ' Calculate prices
        priceBigMac = nudBurgersBigMac.Value * 1.8
        priceMcChicken = nudBurgersMcChicken.Value * 1.65
        priceBigTastyBacon = nudBurgersBigTastyBacon.Value * 3.95

        priceBurgers = priceBigMac + priceMcChicken + priceBigTastyBacon

        If frites = "Medium" Then
            priceFrites = 1.8
        ElseIf frites = "Large" Then
            priceFrites = 2.25
        End If

        If drinksize = "Small" Then
            priceDrinks = 1.25
        ElseIf drinksize = "Medium" Then
            priceDrinks = 1.75
        ElseIf drinksize = "Large" Then
            priceDrinks = 2
        End If

        price = priceBurgers + priceFrites + priceDrinks

        ' Output values to the screen
        tbxPriceBurgers.Text = priceBurgers.ToString("C2", New CultureInfo("nl-NL"))
        tbxPriceFrites.Text = priceFrites.ToString("C2", New CultureInfo("nl-NL"))
        tbxPriceDrinks.Text = priceDrinks.ToString("C2", New CultureInfo("nl-NL"))
        tbxTotalPrice.Text = price.ToString("C2", New CultureInfo("nl-NL"))
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        For Each nud In gbxBurger.Controls.OfType(Of NumericUpDown)
            nud.Value = 0
        Next

        rbtnFritesMedium.Checked = True
        rbtnFritesLarge.Checked = False
        rbtnDrinksCoke.Checked = True
        rbtnDrinksFanta.Checked = False
        rbtnDrinksSprite.Checked = False
        cbxDrinksSize.SelectedIndex = -1

        priceBurgers = 0
        priceFrites = 0
        priceDrinks = 0
        priceBigMac = 0
        priceMcChicken = 0
        priceBigTastyBacon = 0
        price = 0

        For Each tbx In gbxResult.Controls.OfType(Of TextBox)
            tbx.Text = ""
        Next
    End Sub
End Class
