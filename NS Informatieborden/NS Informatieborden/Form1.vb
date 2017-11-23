Public Class Form1
    ' Declare vars
    Public leavetime As Date
    Public train As String
    Public destination As String
    Public via As String
    Public delay As Date

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Grab values
        Try
            leavetime = dtpLeavetime.Value
            train = cbxTrain.SelectedItem.ToString
            destination = tbxDestination.Text
            via = tbxVia.Text
            delay = dtpDelay.Value
        Catch ex As Exception
            MessageBox.Show("Vul alle velden in!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' Open form
        Form2.Show()
    End Sub
End Class
