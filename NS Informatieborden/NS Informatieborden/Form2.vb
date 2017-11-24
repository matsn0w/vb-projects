Public Class Form2
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Form1.delay.ToString("mm") <> "00" Then
            If lblDelay.Visible = True Then
                lblDelay.Visible = False
            Else
                lblDelay.Visible = True
            End If
        Else
            lblDelay.Visible = False
        End If
    End Sub
End Class