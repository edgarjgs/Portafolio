Public Class Form1
    Const taxRate As Decimal = 0.0775
    Private Sub Calculate_Click(sender As Object, e As EventArgs) Handles Calculate.Click
        Dim deccost As Decimal
        Dim taxtotal As Decimal

        itemname.Text = "Item Name: " & itembox.Text
        deccost = Me.costbox.Text
        Me.cost.Text = "Cost: $" & Math.Round(Val(deccost), 2)
        Me.tax.Text = "Tax: " & Math.Round(Val(costbox.Text * taxRate), 2)
        taxtotal = costbox.Text * taxRate
        Me.total.Text = "Total: " & Math.Round(Val(deccost + taxtotal), 2)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.itemname.Text = " "
        Me.cost.Text = " "
        Me.total.Text = " "
        Me.tax.Text = " "
    End Sub

    Private Sub BClear_Click(sender As Object, e As EventArgs) Handles BClear.Click
        Me.itembox.Text = " "
        Me.costbox.Text = " "
        Me.itemname.Text = " "
        Me.cost.Text = " "
        Me.total.Text = " "
        Me.tax.Text = " "
    End Sub

    Private Sub Bexit_Click(sender As Object, e As EventArgs) Handles Bexit.Click
        Me.Close()
    End Sub
End Class
