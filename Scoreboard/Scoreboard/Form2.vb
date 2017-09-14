Public Class Form2
    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Me.Close()
        Form1.Show()
    End Sub
End Class