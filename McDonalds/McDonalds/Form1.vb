Public Class Form1
    ' Define vars
    Dim burgers As String
    Dim frites As String
    Dim drinks As String
    Dim totalprice As Decimal

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Grab the values
        For Each c As CheckBox In Me.gbxBurger.Controls
            If c.Checked = True Then
                burgers += c.Text
                Exit For
            End If
        Next

        ' Print results
        lblResultBurgers.Visible = True
        lblResultBurgers.Text = burgers
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lblResultBurgers.Text = ""
        burgers = ""
        frites = ""
        drinks = ""
        totalprice = 0
    End Sub
End Class
