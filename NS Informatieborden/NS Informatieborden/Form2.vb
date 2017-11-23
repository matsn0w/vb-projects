Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblLeaveTime.Text = Form1.leavetime.ToString("HH:mm")
        lblTrain.Text = Form1.train
        lblDestination.Text = Form1.destination
        lblVia.Text = "Via " & Form1.via
        lblDelay.Text = "+" & Form1.delay.ToString("mm") & " minuten"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Form1.delay.ToString("mm") <> "00" Then
            lblDelay.Visible = Not lblDelay.Visible
        Else
            lblDelay.Visible = Not lblDelay.Visible
            Timer1.Stop()
        End If
    End Sub
End Class