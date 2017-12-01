Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If pbRed1.Visible = True Then
            pbRed1.Visible = False
            pbOrange1.Visible = False
            pbGreen1.Visible = True
        ElseIf pbOrange1.Visible = True Then
            pbRed1.Visible = True
            pbOrange1.Visible = False
            pbGreen1.Visible = False
        ElseIf pbGreen1.Visible = True Then
            pbRed1.Visible = False
            pbOrange1.Visible = True
            pbGreen1.Visible = False
        End If

        If pbRed2.Visible = True Then
            pbRed2.Visible = False
            pbOrange2.Visible = False
            pbGreen2.Visible = True
        ElseIf pbOrange2.Visible = True Then
            pbRed2.Visible = True
            pbOrange2.Visible = False
            pbGreen2.Visible = False
        ElseIf pbGreen2.Visible = True Then
            pbRed2.Visible = False
            pbOrange2.Visible = True
            pbGreen2.Visible = False
        End If

        If pbRed3.Visible = True Then
            pbRed3.Visible = False
            pbOrange3.Visible = False
            pbGreen3.Visible = True
        ElseIf pbOrange3.Visible = True Then
            pbRed3.Visible = True
            pbOrange3.Visible = False
            pbGreen3.Visible = False
        ElseIf pbGreen3.Visible = True Then
            pbRed3.Visible = False
            pbOrange3.Visible = True
            pbGreen3.Visible = False
        End If

        If pbRed4.Visible = True Then
            pbRed4.Visible = False
            pbOrange4.Visible = False
            pbGreen4.Visible = True
        ElseIf pbOrange4.Visible = True Then
            pbRed4.Visible = True
            pbOrange4.Visible = False
            pbGreen4.Visible = False
        ElseIf pbGreen4.Visible = True Then
            pbRed4.Visible = False
            pbOrange4.Visible = True
            pbGreen4.Visible = False
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
