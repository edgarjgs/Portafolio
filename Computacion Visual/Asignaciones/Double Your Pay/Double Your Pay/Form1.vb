Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Days.Text = ""
        Me.display.Text = ""
        Me.display2.Text = ""
        Me.newEmployeeButton.Checked = True
        Me.expEmployeeButton.Checked = False
    End Sub

    Private Sub calculate_Click(sender As Object, e As EventArgs) Handles calculate.Click
        Dim days As String
        Dim calculate As Decimal
        Dim daysCount As String = 1
        Dim newEmployee As Decimal = 0.01
        Dim expEmployee As Decimal = 0.05

        If IsNumeric(Me.Days.Text) Then
            days = Convert.ToString(Me.Days.Text)
            If days > 22 Then
                MsgBox("You Enterd " & days & " days. The Limit is 22 days for all Employees.",, "Input Error")
            Else

                If newEmployeeButton.Checked Then
                    If days >= 19 Then
                        calculate = newEmployee
                        Do Until daysCount = days
                            calculate = calculate * 2
                            daysCount = daysCount + 1
                        Loop
                        Me.display.Text = "The Total Pay ammount for " & days & " days is:"
                        Me.display2.Text = "$" & calculate
                    Else
                        MsgBox("You Enterd " & days & " days. The Minimum is 19 days for new employees.",, "Input Error")
                    End If

                ElseIf expEmployeeButton.Checked Then
                    If days >= 16 Then
                        calculate = expEmployee
                        Do Until daysCount = days
                            calculate = calculate * 2
                            daysCount = daysCount + 1
                        Loop
                        Me.display.Text = "The Total Pay ammount for " & days & " days is:"
                        Me.display2.Text = "$" & calculate
                    Else
                        MsgBox("You Enterd " & days & " days. The Minimum is 16 days for experienced employees.",, "Input Error")
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        Me.Days.Text = ""
        Me.display.Text = ""
        Me.display2.Text = ""
        Me.newEmployeeButton.Checked = True
        Me.expEmployeeButton.Checked = False
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
