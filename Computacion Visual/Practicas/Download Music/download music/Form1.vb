Public Class Form1
    Const pricedownload As Decimal = 0.99D
    Private Sub Calculate_Click(sender As Object, e As EventArgs) Handles Calculate.Click
        Dim strSongcount As String
        Dim intSongcount As Integer
        Dim decTotal As Decimal

        strSongcount = Me.SongcountBox.Text
        intSongcount = Convert.ToInt32(strSongcount)
        decTotal = intSongcount * pricedownload
        Me.Total.Text = "$" & decTotal
    End Sub

    Private Sub BClear_Click(sender As Object, e As EventArgs) Handles BClear.Click
        Me.SongcountBox.Clear()
        Me.Total.Text = " "
        Me.SongcountBox.Focus()
    End Sub

    Private Sub Bexit_Click(sender As Object, e As EventArgs) Handles Bexit.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label2.Text = pricedownload.ToString("C") & " Per Download"
        Me.Total.Text = " "
        Me.SongcountBox.Focus()
    End Sub
End Class
