Public Class List
    Private Sub LIBROSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles LIBROSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.LIBROSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BIBLIOTECADataSet)
    End Sub

    Private Sub List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BIBLIOTECADataSet.LIBROS' table. You can move, or remove it, as needed.
        Me.LIBROSTableAdapter.Fill(Me.BIBLIOTECADataSet.LIBROS)
    End Sub

    Private Sub HomeLabel_Click(sender As Object, e As EventArgs) Handles HomeLabel.Click
        Me.Hide()
        Dim home As New Home
        home.ShowDialog()
        ' home.Show()
        Me.Close()
    End Sub

    Private Sub SingleLabel_Click(sender As Object, e As EventArgs) Handles SingleLabel.Click
        Me.Hide()
        Dim tab As New View
        tab.ShowDialog()
        '  tab.Show()
        Me.Close()
    End Sub

    Private Sub ExitLabel_Click(sender As Object, e As EventArgs) Handles ExitLabel.Click
        Me.Close()
    End Sub
End Class