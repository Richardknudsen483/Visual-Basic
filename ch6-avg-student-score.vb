 Public Class frmMain
        Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

        Public Sub New()
            MyBase.New()

            'This call is required by the Windows Form Designer.
            InitializeComponent()

            'Add any initialization after the InitializeComponent() call

        End Sub

        'Form overrides dispose to clean up the component list.
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not (components Is Nothing) Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        Friend WithEvents clmStudent As System.Windows.Forms.ColumnHeader
        Friend WithEvents clmScore As System.Windows.Forms.ColumnHeader
        Friend WithEvents lstStudentInfo As System.Windows.Forms.ListView
        Friend WithEvents btnLoadForm As System.Windows.Forms.Button
        Friend WithEvents btnDisplayData As System.Windows.Forms.Button
        Friend WithEvents btnClearForm As System.Windows.Forms.Button
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMain))
            Me.lstStudentInfo = New System.Windows.Forms.ListView
            Me.clmStudent = New System.Windows.Forms.ColumnHeader
            Me.clmScore = New System.Windows.Forms.ColumnHeader
            Me.btnLoadForm = New System.Windows.Forms.Button
            Me.btnDisplayData = New System.Windows.Forms.Button
            Me.btnClearForm = New System.Windows.Forms.Button
            Me.SuspendLayout()
            '
            'lstStudentInfo
            '
            Me.lstStudentInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lstStudentInfo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmStudent, Me.clmScore})
            Me.lstStudentInfo.GridLines = True
            Me.lstStudentInfo.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
            Me.lstStudentInfo.Location = New System.Drawing.Point(0, 0)
            Me.lstStudentInfo.Name = "lstStudentInfo"
            Me.lstStudentInfo.Size = New System.Drawing.Size(384, 328)
            Me.lstStudentInfo.TabIndex = 0
            Me.lstStudentInfo.View = System.Windows.Forms.View.Details
            '
            'clmStudent
            '
            Me.clmStudent.Text = "Student Name"
            Me.clmStudent.Width = 308
            '
            'clmScore
            '
            Me.clmScore.Text = "Score"
            Me.clmScore.Width = 76
            '
            'btnLoadForm
            '
            Me.btnLoadForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLoadForm.Location = New System.Drawing.Point(8, 336)
            Me.btnLoadForm.Name = "btnLoadForm"
            Me.btnLoadForm.Size = New System.Drawing.Size(116, 68)
            Me.btnLoadForm.TabIndex = 1
            Me.btnLoadForm.Text = "Enter Student Info"
            '
            'btnDisplayData
            '
            Me.btnDisplayData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnDisplayData.Location = New System.Drawing.Point(132, 336)
            Me.btnDisplayData.Name = "btnDisplayData"
            Me.btnDisplayData.Size = New System.Drawing.Size(120, 68)
            Me.btnDisplayData.TabIndex = 2
            Me.btnDisplayData.Text = "Display Data"
            '
            'btnClearForm
            '
            Me.btnClearForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClearForm.Location = New System.Drawing.Point(260, 336)
            Me.btnClearForm.Name = "btnClearForm"
            Me.btnClearForm.Size = New System.Drawing.Size(116, 68)
            Me.btnClearForm.TabIndex = 3
            Me.btnClearForm.Text = "Clear Form"
            '
            'frmMain
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(8, 19)
            Me.ClientSize = New System.Drawing.Size(384, 410)
            Me.Controls.Add(Me.btnClearForm)
            Me.Controls.Add(Me.btnDisplayData)
            Me.Controls.Add(Me.btnLoadForm)
            Me.Controls.Add(Me.lstStudentInfo)
            Me.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MaximumSize = New System.Drawing.Size(400, 448)
            Me.MinimumSize = New System.Drawing.Size(400, 448)
            Me.Name = "frmMain"
            Me.Text = "Average Student Scores"
            Me.ResumeLayout(False)

        End Sub

#End Region

        'Clears the chart
        Private Sub btnClearForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearForm.Click

            lstStudentInfo.Items.Clear()

        End Sub

        Private Sub btnLoadForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadForm.Click


            'Creates a new form
            Dim studentForm As New frmInputStudentInfo

            'Shows the new form
            studentForm.ShowDialog()

            'Creates a new dataset for student data
            'Adds the name to the dataset
            Dim studentData As New ListViewItem(studentForm.txtName.Text)

            'Adds the test score to the set
            studentData.SubItems.Add(studentForm.numScore.Value & "%")

            'Checks to see that there is no null data
            If Not studentForm.txtName.Text = "" Then

                lstStudentInfo.Items.Add(studentData)

            End If

        End Sub

        'Displays a message box with data
        Private Sub btnDisplayData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayData.Click

            Dim counter As Integer
            Dim strResults As String = ""
            Dim sngScores As Single = 0
            Dim sngAverage As Single = 0
            Dim sngListCount As Single = 0

            'The number of items on the list is assigned to intListCount
            sngListCount = Convert.ToSingle(lstStudentInfo.Items.Count)

            'This for loop will iterate through each item in the list
            For counter = 0 To sngListCount - 1

                'Converts the student's score at the location of counter in the list and removes the percent sign
                sngScores = Convert.ToSingle(lstStudentInfo.Items(counter).SubItems(1).Text.Replace("%", ""))
                'Adds the scores to the average
                sngAverage += sngScores

            Next

            'Sets the average
            sngAverage = sngAverage / sngListCount

            'Outputs the results to a message box 
            strResults = "The average score is: " & Format(sngAverage, "0.00") & "%" & ControlChars.NewLine
            strResults &= "The number of scores: " & sngListCount
            MessageBox.Show(strResults, "Average Score")

        End Sub

    End Class
    'End of the Main Form
    'Input Student Info Form Code
    Public Class frmInputStudentInfo
        Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

        Public Sub New()
            MyBase.New()

            'This call is required by the Windows Form Designer.
            InitializeComponent()

            'Add any initialization after the InitializeComponent() call

        End Sub

        'Form overrides dispose to clean up the component list.
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not (components Is Nothing) Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        Friend WithEvents lblName As System.Windows.Forms.Label
        Friend WithEvents txtName As System.Windows.Forms.TextBox
        Friend WithEvents lblScore As System.Windows.Forms.Label
        Friend WithEvents numScore As System.Windows.Forms.NumericUpDown
        Friend WithEvents btnOK As System.Windows.Forms.Button
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmInputStudentInfo))
            Me.lblName = New System.Windows.Forms.Label
            Me.txtName = New System.Windows.Forms.TextBox
            Me.lblScore = New System.Windows.Forms.Label
            Me.numScore = New System.Windows.Forms.NumericUpDown
            Me.btnOK = New System.Windows.Forms.Button
            CType(Me.numScore, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'lblName
            '
            Me.lblName.Location = New System.Drawing.Point(8, 8)
            Me.lblName.Name = "lblName"
            Me.lblName.Size = New System.Drawing.Size(120, 23)
            Me.lblName.TabIndex = 0
            Me.lblName.Text = "Student Name:"
            '
            'txtName
            '
            Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtName.Location = New System.Drawing.Point(128, 8)
            Me.txtName.Name = "txtName"
            Me.txtName.Size = New System.Drawing.Size(184, 26)
            Me.txtName.TabIndex = 1
            Me.txtName.Text = ""
            Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'lblScore
            '
            Me.lblScore.Location = New System.Drawing.Point(8, 40)
            Me.lblScore.Name = "lblScore"
            Me.lblScore.Size = New System.Drawing.Size(96, 23)
            Me.lblScore.TabIndex = 2
            Me.lblScore.Text = "Test Score:"
            '
            'numScore
            '
            Me.numScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.numScore.DecimalPlaces = 2
            Me.numScore.Increment = New Decimal(New Integer() {10, 0, 0, 0})
            Me.numScore.Location = New System.Drawing.Point(184, 40)
            Me.numScore.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
            Me.numScore.Name = "numScore"
            Me.numScore.Size = New System.Drawing.Size(72, 26)
            Me.numScore.TabIndex = 3
            Me.numScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'btnOK
            '
            Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnOK.Location = New System.Drawing.Point(104, 88)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(112, 23)
            Me.btnOK.TabIndex = 4
            Me.btnOK.Text = "OK"
            '
            'frmInputStudentInfo
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(8, 19)
            Me.ClientSize = New System.Drawing.Size(330, 128)
            Me.Controls.Add(Me.btnOK)
            Me.Controls.Add(Me.numScore)
            Me.Controls.Add(Me.lblScore)
            Me.Controls.Add(Me.txtName)
            Me.Controls.Add(Me.lblName)
            Me.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MaximumSize = New System.Drawing.Size(336, 152)
            Me.MinimumSize = New System.Drawing.Size(336, 152)
            Me.Name = "frmInputStudentInfo"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Input Student Information"
            CType(Me.numScore, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        'Closes the form
        Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

            Me.Close()

        End Sub

    End Class

