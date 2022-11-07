Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Text = (TextBox1.Text / (60 * 24))
        TextBox3.Text = Math.Round(TextBox1.Text / 525949.2)
    End Sub
End Class
