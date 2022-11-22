Public Class Form1
    Private Sub Bclear_Click(sender As Object, e As EventArgs) Handles Bclear.Click
        Me.MainlandUSButton.Checked = True
        Me.AlaskaButton.Checked = False
        Me.HawaiiButton.Checked = False
        Me.PoundsBox.Text = ""
        Me.Cost.Text = "$00.00"
        Me.PoundsBox.Focus()
    End Sub
    Private Sub Calculate_Click(sender As Object, e As EventArgs) Handles Calculate.Click
        Dim decBox As Decimal
        Const ALselect As Decimal = 0.26
        Dim total As Decimal
        Const Haselect As Decimal = 0.2
        Dim p2 As Decimal = 3.69D
        Dim p4 As Decimal = 4.86D
        Dim p6 As Decimal = 5.63D
        Dim p8 As Decimal = 5.98D
        Dim p10 As Decimal = 6.28D
        Dim p30 As Decimal = 15.72D
        If IsNumeric(Me.PoundsBox.Text) Then
            decBox = Convert.ToDecimal(Me.PoundsBox.Text)
            If decBox > 0 Then
                If Me.MainlandUSButton.Checked Then
                    If decBox <= 2 Then
                        Me.Cost.Text = p2.ToString("C")
                    ElseIf decBox <= 4 Then
                        Me.Cost.Text = p4.ToString("C")
                    ElseIf decBox <= 6 Then
                        Me.Cost.Text = p6.ToString("C")
                    ElseIf decBox <= 8 Then
                        Me.Cost.Text = p8.ToString("C")
                    ElseIf decBox <= 10 Then
                        Me.Cost.Text = p10.ToString("C")
                    ElseIf decBox <= 30 Then
                        Me.Cost.Text = p30.ToString("C")
                    ElseIf decBox > 30 Then
                        MsgBox("You Enterd " & decBox & ". The Limit is 30 Pounds.",, "Input Error")
                    End If
                ElseIf Me.AlaskaButton.Checked Then
                    If decBox <= 2 Then
                        total = p2 * ALselect
                        total = total + p2
                        Me.Cost.Text = total.ToString("C")
                    ElseIf decBox <= 4 Then
                        total = p4 * ALselect
                        total = total + p4
                        Me.Cost.Text = total.ToString("C")
                    ElseIf decBox <= 6 Then
                        total = p6 * ALselect
                        total = total + p6
                        Me.Cost.Text = total.ToString("C")
                    ElseIf decBox <= 8 Then
                        total = p8 * ALselect
                        total = total + p8
                        Me.Cost.Text = total.ToString("C")
                    ElseIf decBox <= 10 Then
                        total = p10 * ALselect
                        total = total + p10
                        Me.Cost.Text = total.ToString("C")
                    ElseIf decBox <= 30 Then
                        total = p30 * ALselect
                        total = total + p30
                        Me.Cost.Text = total.ToString("C")
                    ElseIf decBox > 30 Then
                        MsgBox("You Enterd " & decBox & ". The Limit is 30 Pounds.",, "Input Error")
                    End If
                ElseIf Me.HawaiiButton.Checked Then
                    If decBox <= 2 Then
                        total = p2 * Haselect
                        total = total + p2
                        Me.Cost.Text = total.ToString("C")
                    ElseIf decBox <= 4 Then
                        total = p4 * Haselect
                        total = total + p4
                        Me.Cost.Text = total.ToString("C")
                    ElseIf decBox <= 6 Then
                        total = p6 * Haselect
                        total = total + p6
                        Me.Cost.Text = total.ToString("C")
                    ElseIf decBox <= 8 Then
                        total = p8 * Haselect
                        total = total + p8
                        Me.Cost.Text = total.ToString("C")
                    ElseIf decBox <= 10 Then
                        total = p10 * Haselect
                        total = total + p10
                        Me.Cost.Text = total.ToString("C")
                    ElseIf decBox <= 30 Then
                        total = p30 * Haselect
                        total = total + p30
                        Me.Cost.Text = total.ToString("C")
                    ElseIf decBox > 30 Then
                        MsgBox("You Enterd " & decBox & ". The Limit is 30 Pounds.",, "Input Error")
                    End If
                End If
            End If
        Else
            MsgBox("You Enterd a invalid input. Write a Number",, "Input Error")
        End If
    End Sub
End Class