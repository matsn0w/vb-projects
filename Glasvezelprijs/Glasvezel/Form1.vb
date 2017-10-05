Public Class Form1
    ' Declare vars
    Dim LS As Integer
    Dim AH As Integer
    Dim AVS As Integer

    Dim TLG As Double
    Dim P As Double
    Dim K As Double
    Dim TP As Double

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Grab the values
        LS = tbxLS.Text
        AH = tbxAH.Text
        AVS = tbxAVS.Text

        ' Perform the calculations
        TLG = LS + (AH * 10) + AVS
        P = TLG * 3.25

        ' Calculate the discount
        If P > 250 And P <= 750 Then
            K = 0.05
        ElseIf P > 750 And P <= 1500 Then
            K = 0.075
        ElseIf P > 1500 And P <= 3000 Then
            K = 0.1
        ElseIf P > 3000 Then
            K = 0.15
        Else
            K = 0
        End If

        ' Calculate the totalprice including the discount
        TP = P * (1 - K)

        ' Round the prices
        P = Math.Round(P, 2)
        TP = Math.Round(TP, 2)

        ' Write the values to the boxes
        tbxTLG.Text = TLG & " m"
        tbxP.Text = "€ " & P
        tbxK.Text = K * 100 & "%"
        tbxTP.Text = "€ " & TP
    End Sub
End Class
