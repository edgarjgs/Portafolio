Public Class Home
    Private Sub TableButton_Click(sender As Object, e As EventArgs) Handles TableButton.Click
        Me.Hide()
        Dim tab As New List
        tab.ShowDialog()
        ' tab.Show()
        Me.Close()
    End Sub

    Private Sub ViewButton_Click(sender As Object, e As EventArgs) Handles ViewButton.Click
        Me.Hide()
        Dim tab As New View
        tab.ShowDialog()
        'tab.Show()
        Me.Close()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
End Class