Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles viewhour.Click
        Me.week.Visible = True
        Me.hour.Visible = True
        Me.viewhour.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles leave.Click
        Me.Close()
    End Sub
End Class
