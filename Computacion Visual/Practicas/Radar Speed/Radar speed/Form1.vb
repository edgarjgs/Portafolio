Public Class Form1
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btbEnterSpeed.Click
        Dim strVehicleSpeed As String
        Dim decVehicleSpeed As Decimal
        Dim DecAvarageSpeed As Decimal
        Dim decTotalOfAllSpeeds As Decimal = 0D
        Dim strInputBoxMessage As String = "Enter the speed of Vehicle #"
        Dim strInputBoxHeading As String = "Radar Speed"
        Dim strNormalBoxMessage As String = "Enter the speed of Vehicle #"
        Dim strNonNumeric As String = "Error - Enter a positive number for the speed of vehicle #"
        Dim strNegative As String = "Error - Enter a positive number for vehicle #"

        Dim strCancelButtonClicked As String = ""
        Dim intMaxNumberOfEntries As Integer = 10
        Dim intNumberOfEntries As Integer = 1


        strVehicleSpeed = InputBox(strInputBoxMessage & intNumberOfEntries, strInputBoxHeading, "")

        Do Until intNumberOfEntries > intMaxNumberOfEntries Or strVehicleSpeed = strCancelButtonClicked
            If IsNumeric(strVehicleSpeed) Then
                decVehicleSpeed = Convert.ToDecimal(strVehicleSpeed)
                If decVehicleSpeed > 0 Then
                    Me.ListRadarSpeed.Items.Add(decVehicleSpeed)
                    decTotalOfAllSpeeds += decVehicleSpeed
                    intNumberOfEntries += 1
                    strInputBoxMessage = strNormalBoxMessage
                Else
                    strInputBoxMessage = strNegative
                End If
            Else
                strInputBoxMessage = strNonNumeric
            End If
            If intNumberOfEntries <= intMaxNumberOfEntries Then
                strVehicleSpeed = InputBox(strInputBoxMessage & intNumberOfEntries, strInputBoxHeading, "")
            End If
        Loop
        Me.lblAvarageSpeed.Visible = True
        If intNumberOfEntries > 1 Then
            DecAvarageSpeed = decTotalOfAllSpeeds / (intNumberOfEntries - 1)
            Me.lblAvarageSpeed.Text = "Avarage speed at checkpoint is " & DecAvarageSpeed.ToString("F1") & " mph"
        Else
            Me.lblAvarageSpeed.Text = "No speed entered"
        End If
        Me.btbEnterSpeed.Enabled = False
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        Me.ListRadarSpeed.Items.Clear()
        Me.lblAvarageSpeed.Visible = False
        Me.btbEnterSpeed.Enabled = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblAvarageSpeed.Text = ""
    End Sub
End Class
