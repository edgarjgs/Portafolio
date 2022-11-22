Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.PictureBox1.Visible = True
        Me.PictureBox2.Visible = False
        Me.Button3.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.PictureBox1.Visible = False
        Me.PictureBox2.Visible = True
        Me.Button3.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Button1.Enabled = False
        Me.Button2.Enabled = False
        Me.Button3.Enabled = False
        Me.Label2.Visible = False
        Me.Label3.Visible = True
        Me.Button4.Enabled = True
    End Sub
End Class
