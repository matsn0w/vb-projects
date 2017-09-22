Public Class Form1
    ' Declare vars
    Dim gender As String
    Dim emotion As String
    Dim hobby As String
    Dim sentence As String

    Private Sub rbnMen_CheckedChanged(sender As Object, e As EventArgs) Handles rbnMen.CheckedChanged
        If rbnMen.Checked = True Then
            gender = "Ik ben een man, "
        End If
    End Sub

    Private Sub rbnWomen_CheckedChanged(sender As Object, e As EventArgs) Handles rbnWomen.CheckedChanged
        If rbnWomen.Checked = True Then
            gender = "Ik ben een vrouw, "
        End If
    End Sub

    Private Sub rbnDepri_CheckedChanged(sender As Object, e As EventArgs) Handles rbnDepri.CheckedChanged
        If rbnDepri.Checked = True Then
            emotion = "depri en "
        End If
    End Sub

    Private Sub rbnHappy_CheckedChanged(sender As Object, e As EventArgs) Handles rbnHappy.CheckedChanged
        If rbnHappy.Checked = True Then
            emotion = "blij en "
        End If
    End Sub

    Private Sub rbnSad_CheckedChanged(sender As Object, e As EventArgs) Handles rbnSad.CheckedChanged
        If rbnSad.Checked = True Then
            emotion = "verdrietig en "
        End If
    End Sub

    Private Sub rbnAngry_CheckedChanged(sender As Object, e As EventArgs) Handles rbnAngry.CheckedChanged
        If rbnAngry.Checked = True Then
            emotion = "boos en "
        End If
    End Sub

    Private Sub rbnFootball_CheckedChanged(sender As Object, e As EventArgs) Handles rbnFootball.CheckedChanged
        If rbnFootball.Checked = True Then
            hobby = "ik speel graag voetbal!"
        End If
    End Sub

    Private Sub rbnGaming_CheckedChanged(sender As Object, e As EventArgs) Handles rbnGaming.CheckedChanged
        If rbnGaming.Checked = True Then
            hobby = "ik speel graag games!"
        End If
    End Sub

    Private Sub rbnSleeping_CheckedChanged(sender As Object, e As EventArgs) Handles rbnSleeping.CheckedChanged
        If rbnSleeping.Checked = True Then
            hobby = "ik slaap graag!"
        End If
    End Sub

    Private Sub rbnEating_CheckedChanged(sender As Object, e As EventArgs) Handles rbnEating.CheckedChanged
        If rbnEating.Checked = True Then
            hobby = "ik eet graag!"
        End If
    End Sub

    Private Sub btnTransmit_Click(sender As Object, e As EventArgs) Handles btnTransmit.Click
        sentence = gender & emotion & hobby
        tbxResult.Text = sentence
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbxShowVideo.CheckedChanged
        If cbxShowVideo.Checked = True Then
            WebBrowser1.Visible = True
            WebBrowser1.Navigate("https://youtu.be/FJVg2TsIgsw")
        End If

        If cbxShowVideo.Checked = False Then
            WebBrowser1.Visible = False
        End If
    End Sub
End Class
