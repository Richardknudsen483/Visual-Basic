
    Private Sub WeeklyPay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim intColum0Width As Integer
        intColum0Width = Me.Width - frmPayRoll.Columns(1).Width - frmPayRoll.Columns(2).Width - 12
        If intColum0Width > 0 Then
            frmPayRoll.Columns(0).Width = intColum0Width
        End If
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        'Display dialog box for each entry
        'total todaty, Display diolog box until user enters a despription of entry
        Dim objAddItemForm As New WeeklyDataForm
        objAddItemForm.ShowDialog()
        Do Until objAddItemForm.txtEmployeeName.Text = ""
            Dim LvlTodaysSales As New ListViewItem(objAddItemForm.txtEmployeeName.Text)


            LvlTodaysSales.SubItems.Add((objAddItemForm.nudHours.Value))
            LvlTodaysSales.SubItems.Add(Format$(objAddItemForm.txtRate.Text, "Currency"))
            frmPayRoll.Items.Add(LvlTodaysSales)
            objAddItemForm.ShowDialog()
        Loop

    End Sub
    Private Sub lstTodaysSales_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles frmPayRoll.KeyDown
        If e.KeyCode = Keys.Delete And frmPayRoll.SelectedIndices.Count > 0 Then
            frmPayRoll.Items.RemoveAt(frmPayRoll.SelectedIndices(0))

        End If
    End Sub

    Private Sub btnTotalPayRoll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotalPayRoll.Click
        Dim intIndex, intListCount As Integer
        Dim sngTotalSales As Single = 0
        Dim sngTotalWorkerPay As Single = 0
        Dim strPayRate As Single
        Dim sngHours As Single
        Dim strResults As String, strHours As String

        intListCount = Convert.ToInt32(frmPayRoll.Items.Count)
        For intIndex = 0 To intListCount - 1
            strHours = frmPayRoll.Items(intIndex).SubItems(1).Text
            strPayRate = frmPayRoll.Items(intIndex).SubItems(2).Text
            strHours = strHours.Replace("$", "0")
            sngHours = Convert.ToString(strHours)
            sngTotalSales += sngHours
            sngTotalWorkerPay += sngHours * strPayRate
        Next
        strResults = "Total Hours Worked: " & (sngTotalSales) & ControlChars.NewLine
        strResults &= "Total  Pay: " & Format$(sngTotalWorkerPay, "Currency")
        MessageBox.Show(strResults, "Total Hours Paid")
    End Sub
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        frmPayRoll.Items.Clear()
    End Sub
End Class

