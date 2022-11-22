Public Class Form1

    Private intTwoHours As Integer = 2
    Private intThreeHours As Integer = 3
    Private intFourHours As Integer = 4
    Private intEightHours As Integer = 8
    Private strDeepSeaFishing As String = "Deep Sea Fishing"
    Private strKayaking As String = "Kayaking"
    Private strScuba As String = "Scuba"
    Private strSnorkeling As String = "Snorkeling"
    Private strGlassBottomBoat As String = "Glass Bottom Boat"
    Private strParasailing As String = "Parasailing"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Threading.Thread.Sleep(5000)
        Me.cboIsland.Text = "Select Island Location"
        Me.txtNumberInParty.Clear()
        Me.lstTours.Items.Clear()
        Me.lblTourType.Text = ""
        Me.lblCost.Text = ""
        Me.lblLength.Text = ""
        Me.lblParty.Visible = False
        Me.txtNumberInParty.Visible = False
        Me.lblSelect.Visible = False
        Me.lstTours.Visible = False
        Me.btnFindCost.Visible = False
        Me.btnClear.Visible = False
        Me.lblTourType.Visible = False
        Me.lblCost.Visible = False
        Me.lblLength.Visible = False
    End Sub

    Private Sub btnFindCost_Click(sender As Object, e As EventArgs) Handles btnFindCost.Click

        Dim intGroupSize As Integer
        Dim blnNumberInPartyIsValid As Boolean = False
        Dim blnTourIsSelected As Boolean = False
        Dim intTourChoice As Integer
        Dim strSelectedTour As String = ""
        Dim intIslandChoice As Integer
        Dim intLengthOfTour As Integer = 0
        Dim decTotalCost As Decimal

        blnNumberInPartyIsValid = ValidateNumberInParty()
        intTourChoice = ValidateTourSelection(blnTourIsSelected, strSelectedTour)

        If (blnNumberInPartyIsValid And blnTourIsSelected) Then
            intGroupSize = Convert.ToInt32(Me.txtNumberInParty.Text)
            intIslandChoice = Me.cboIsland.SelectedIndex
            Select Case intIslandChoice
                Case 0
                    decTotalCost = ArubaFindCost(intTourChoice, intGroupSize, intLengthOfTour)
                Case 1
                    decTotalCost = JamaicaFindCost(intTourChoice, intGroupSize, intLengthOfTour)
                Case 2
                    decTotalCost = KeyWestFindCost(intTourChoice, intGroupSize, intLengthOfTour)
            End Select
            Me.lblTourType.Text = "Tour: " & strSelectedTour
            Me.lblCost.Text = "Cost: " & decTotalCost.ToString("C")
            Me.lblLength.Text = "Length: " & intLengthOfTour.ToString() & " hours"

        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Me.cboIsland.Text = "Select Island Location"
        Me.txtNumberInParty.Clear()
        Me.lstTours.Items.Clear()
        Me.lblTourType.Text = ""
        Me.lblCost.Text = ""
        Me.lblLength.Text = ""
        Me.lblParty.Visible = False
        Me.txtNumberInParty.Visible = False
        Me.lblSelect.Visible = False
        Me.lstTours.Visible = False
        Me.btnFindCost.Visible = False
        Me.btnClear.Visible = False
        Me.lblTourType.Visible = False
        Me.lblCost.Visible = False
        Me.lblLength.Visible = False
    End Sub

    Private Sub cboIsland_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboIsland.SelectedIndexChanged
        Dim intIslandChoice As Integer

        intIslandChoice = Me.cboIsland.SelectedIndex
        Me.lstTours.Items.Clear()
        Select Case intIslandChoice
            Case 0
                ArubaTours()
            Case 1
                JamaicaTours()
            Case 2
                KeyWestTours()
        End Select
        Me.lblParty.Visible = True
        Me.txtNumberInParty.Visible = True
        Me.lblSelect.Visible = True
        Me.lstTours.Visible = True
        Me.btnFindCost.Visible = True
        Me.btnClear.Visible = True
        Me.lblTourType.Visible = True
        Me.lblCost.Visible = True
        Me.lblLength.Visible = True
        Me.lblTourType.Text = ""
        Me.lblCost.Text = ""
        Me.lblLength.Text = ""
        Me.txtNumberInParty.Focus()

    End Sub

    Private Sub ArubaTours()

        Me.lstTours.Items.Add(strDeepSeaFishing)
        Me.lstTours.Items.Add(strKayaking)
        Me.lstTours.Items.Add(strScuba)
        Me.lstTours.Items.Add(strSnorkeling)

    End Sub

    Private Sub JamaicaTours()

        Me.lstTours.Items.Add(strGlassBottomBoat)
        Me.lstTours.Items.Add(strParasailing)
        Me.lstTours.Items.Add(strSnorkeling)

    End Sub

    Private Sub KeyWestTours()

        Me.lstTours.Items.Add(strDeepSeaFishing)
        Me.lstTours.Items.Add(strGlassBottomBoat)
        Me.lstTours.Items.Add(strScuba)
        Me.lstTours.Items.Add(strSnorkeling)

    End Sub

    Private Function ValidateNumberInParty() As Boolean

        Dim intPartyNumber As Integer
        Dim blnValidityCheck As Boolean = False
        Dim strNumberInPartyErrorMessage As String = "Please enter the number of people in your party (1-99)"
        Dim strMessageBoxTitle As String = "Error"

        Try
            intPartyNumber = Convert.ToInt32(Me.txtNumberInParty.Text)
            If intPartyNumber > 0 And intPartyNumber < 100 Then
                blnValidityCheck = True
            Else
                MessageBox.Show(strNumberInPartyErrorMessage, strMessageBoxTitle)
                Me.txtNumberInParty.Focus()
                Me.txtNumberInParty.Clear()
            End If
        Catch Exception As FormatException
            MessageBox.Show(strNumberInPartyErrorMessage, strMessageBoxTitle)
            Me.txtNumberInParty.Focus()
            Me.txtNumberInParty.Clear()
        Catch Exception As OverflowException
            MessageBox.Show(strNumberInPartyErrorMessage, strMessageBoxTitle)
            Me.txtNumberInParty.Focus()
            Me.txtNumberInParty.Clear()
        Catch Exception As SystemException
            MessageBox.Show(strNumberInPartyErrorMessage, strMessageBoxTitle)
            Me.txtNumberInParty.Focus()
            Me.txtNumberInParty.Clear()
        End Try

        Return blnValidityCheck

    End Function

    Private Function ValidateTourSelection(ByRef blnTour As Boolean, ByRef strTour As String) As Integer

        Dim intOceanTour As Integer
        Try
            intOceanTour = Convert.ToInt32(Me.lstTours.SelectedIndex)
            strTour = Me.lstTours.SelectedItem.ToString()
            blnTour = True
        Catch Exception As SystemException
            MessageBox.Show("Select an Ocean Tour", "Error")
            blnTour = False
        End Try
        Return intOceanTour

    End Function

    Private Function ArubaFindCost(ByVal intTourSelection As Integer, ByVal intGroupSize As Integer, ByRef intTourLength As Integer) As Decimal

        Dim decTourCost As Decimal
        Dim decFinalCost As Decimal
        Dim decArubaDeepSeaCost As Decimal = 199D
        Dim decArubaKayakCost As Decimal = 89D
        Dim decArubaScubaCost As Decimal = 119D
        Dim decArubaSnorkelCost As Decimal = 89D

        Select Case intTourSelection
            Case 0
                decTourCost = decArubaDeepSeaCost
                intTourLength = intEightHours
            Case 1
                decTourCost = decArubaKayakCost
                intTourLength = intTwoHours
            Case 2
                decTourCost = decArubaScubaCost
                intTourLength = intThreeHours
            Case 3
                decTourCost = decArubaSnorkelCost
                intTourLength = intFourHours
        End Select

        decFinalCost = decTourCost * intGroupSize
        Return decFinalCost

    End Function

    Private Function JamaicaFindCost(ByVal intTourSelection As Integer, ByVal intGroupSize As Integer, ByRef intTourLength As Integer) As Decimal

        Dim decTourCost As Decimal
        Dim decFinalCost As Decimal
        Dim decJamaicaGlassBottomCost As Decimal = 39D
        Dim decJamaicaParasailCost As Decimal = 119D
        Dim decJamaicaSnorkelCost As Decimal = 59D
        Select Case intTourSelection
            Case 0
                decTourCost = decJamaicaGlassBottomCost
                intTourLength = intTwoHours
            Case 1
                decTourCost = decJamaicaParasailCost
                intTourLength = intTwoHours
            Case 2
                decTourCost = decJamaicaSnorkelCost
                intTourLength = intThreeHours
        End Select
        decFinalCost = decTourCost * intGroupSize
        Return decFinalCost

    End Function

    Private Function KeyWestFindCost(ByVal intTourSelection As Integer, ByVal intGroupSize As Integer, ByRef intTourLength As Integer) As Decimal

        Dim decTourCost As Decimal
        Dim decFinalCost As Decimal
        Dim decKeyWestDeepSeaCost As Decimal = 89D
        Dim decKeyWestGlassBottomCost As Decimal = 29D
        Dim decKeyWestScubaCost As Decimal = 119D
        Dim decKeyWestSnorkelCost As Decimal = 59D

        Select Case intTourSelection
            Case 0
                decTourCost = decKeyWestDeepSeaCost
                intTourLength = intFourHours
            Case 1
                decTourCost = decKeyWestGlassBottomCost
                intTourLength = intTwoHours
            Case 2
                decTourCost = decKeyWestScubaCost
                intTourLength = intThreeHours
            Case 3
                decTourCost = decKeyWestSnorkelCost
                intTourLength = intThreeHours
        End Select
        decFinalCost = decTourCost * intGroupSize
        Return decFinalCost

    End Function
End Class