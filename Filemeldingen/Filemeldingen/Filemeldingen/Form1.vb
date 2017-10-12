Public Class Form1
    ' Declare vars
    Public route As String
    Public direction As String
    Public length As Integer
    Public cause As String
    Public sentence As String
    Public time As String

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        ' Grab the values from the boxes
        route = cbxRoute.Text
        direction = cbxDirection.Text
        length = nudLength.Value
        cause = cbxCause.Text

        ' Get the current time
        time = DateAndTime.Now.ToShortTimeString

        ' Build the notification
        sentence = time & ": " & length & " km file op de " & route & " in de richting van " & direction & ". Oorzaak: " & cause

        ' Push the notification to the notifications screen
        Form2.lbxNotifications.Items.Add(sentence)

        ' Remove the no jams sign
        If Form2.lbxNotifications.Items.Count > 0 Then
            Form2.lblNoJams.Visible = False
        End If
    End Sub

    Private Sub btnOpenNotifications_Click(sender As Object, e As EventArgs) Handles btnOpenNotifications.Click
        Form2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Remove selected item
        Form2.lbxNotifications.Items.Remove(Form2.lbxNotifications.SelectedItem)

        ' Add the no jams sign
        If Form2.lbxNotifications.Items.Count = 0 Then
            Form2.lblNoJams.Visible = True
        End If
    End Sub
End Class
