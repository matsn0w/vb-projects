Public Class Form1
    ' Declare the vars
    Dim red As Integer
    Dim green As Integer
    Dim blue As Integer

    Private Sub VSRed_Scroll(sender As Object, e As ScrollEventArgs) Handles VSRed.Scroll
        red = VSRed.Value
        SHRed.Text = red
        SHColor.BackColor = Color.FromArgb(red, green, blue)
    End Sub

    Private Sub VSGreen_Scroll(sender As Object, e As ScrollEventArgs) Handles VSGreen.Scroll
        green = VSGreen.Value
        SHGreen.Text = green
        SHColor.BackColor = Color.FromArgb(red, green, blue)
    End Sub

    Private Sub VSBlue_Scroll(sender As Object, e As ScrollEventArgs) Handles VSBlue.Scroll
        blue = VSBlue.Value
        SHBlue.Text = blue
        SHColor.BackColor = Color.FromArgb(red, green, blue)
    End Sub

    Private Sub SHColor_BackColorChanged(sender As Object, e As EventArgs) Handles SHColor.BackColorChanged
        SHColor.Text = ColorTranslator.ToHtml(Color.FromArgb(red, green, blue))
    End Sub
End Class
