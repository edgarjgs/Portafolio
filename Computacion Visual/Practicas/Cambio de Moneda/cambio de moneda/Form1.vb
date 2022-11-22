Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Text = Val(TextBox1.Text) * 0.90205 'euro
        TextBox3.Text = Val(TextBox1.Text) * 0.76372 'british  
        TextBox4.Text = Val(TextBox1.Text) * 109.93 'japan
    End Sub
End Class
