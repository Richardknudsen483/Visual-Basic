'Take Home Pay Calculator
    'Programer:     Richard Knudsen
    'Date:          Nov 5, 2015
    'Purpose:       This app will calculate a worker's take home pay
    
      Private Sub calculateTakeHomePay()

        Dim dblSocial, dblFed, dblState, dblMedicare, dblWeeklyPay As Double
        Dim dblRetirement, dblInsurance, dblTakeHomePay As Double

        'Calculate gross paycheck amount
        dblWeeklyPay = Convert.ToDouble(salaryList.Value) / 52.0

        'Calculate individual decuctions from gross paycheck amount
        dblSocial = dblWeeklyPay * 0.062
        dblFed = dblWeeklyPay * 0.18
        dblState = dblWeeklyPay * 0.025
        dblMedicare = dblWeeklyPay * 0.0145

        'Calculate retirement contribution from user input
        dblRetirement = dblWeeklyPay * (trackBarValue.Value / 100)

        'Determine insurance cost based on user input
        If radioButtonNone.Checked = True Then
            dblInsurance = 0
        ElseIf radioButtonIndividual.Checked = True Then
            dblInsurance = 20.0
        Else
            dblInsurance = 30.0
        End If

        'Subtract all decutions from the gross paycheck amount and display the results
        dblTakeHomePay = dblWeeklyPay - dblSocial - dblFed - dblState - dblMedicare - dblRetirement - dblInsurance

        labelTakeHomePay.Text = Format(dblTakeHomePay, "Currency")

    End Sub
    
    Private Sub salaryList_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salaryList.ValueChanged
        calculateTakeHomePay()
    End Sub

    Private Sub trackBarValue_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trackBarValue.Scroll
        calculateTakeHomePay()
    End Sub

    Private Sub radioButtonNone_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioButtonNone.CheckedChanged
        calculateTakeHomePay()
    End Sub

    Private Sub radioButtonIndividual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioButtonIndividual.CheckedChanged
        calculateTakeHomePay()
    End Sub

    Private Sub radioButtonFamily_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioButtonFamily.CheckedChanged
        calculateTakeHomePay()
    End Sub
