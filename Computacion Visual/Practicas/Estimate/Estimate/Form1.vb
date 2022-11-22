Public Class Form1
    ' Option Strict On
    Private Sub calculate_Click(sender As Object, e As EventArgs) Handles calculate.Click
        Dim decLinearFeet As Decimal
        Dim decCostperfoot As Decimal
        Dim decCostExtimate As Decimal
        Dim decpinecost As Decimal = 100D
        Dim decoakcost As Decimal = 150D
        Dim deccherrycost As Decimal = 250D

        If IsNumeric(Me.txtlinearfeet.Text) Then
            decLinearFeet = Convert.ToDecimal(Me.txtlinearfeet.Text)
            If decLinearFeet > 0 Then
                If Me.pine.Checked Then
                    decCostperfoot = decpinecost
                ElseIf Me.oak.Checked Then
                    decCostperfoot = decoakcost
                ElseIf Me.cherry.Checked Then
                    decCostperfoot = deccherrycost
                End If
                decCostExtimate = decLinearFeet * decCostperfoot
                Me.lblEstimate.Text = decCostExtimate.ToString("C")
            Else
                MsgBox("You Enterd " & decLinearFeet.ToString() & ". Enter a Number Greater Than Zero.", , "Input Error")
                Me.txtlinearfeet.Text = ""
                Me.txtlinearfeet.Focus()
            End If
        Else
            MsgBox("Enter the Linear Feet of the Cabinets.", , "Input Error")
            Me.txtlinearfeet.Text = ""
            Me.txtlinearfeet.Focus()
        End If
    End Sub

    Private Sub bclear_Click(sender As Object, e As EventArgs) Handles bclear.Click
        Me.txtlinearfeet.Text = ""
        Me.lblEstimate.Text = ""
        Me.pine.Checked = True
        Me.cherry.Checked = False
        Me.oak.Checked = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtlinearfeet.Focus()
        lblEstimate.Text = ""
    End Sub
End Class
