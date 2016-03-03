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
    Friend WithEvents numInitMoney As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblInitMoney As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblHalfDollars As System.Windows.Forms.Label
    Friend WithEvents lblQuarters As System.Windows.Forms.Label
    Friend WithEvents lblDimes As System.Windows.Forms.Label
    Friend WithEvents lblNickels As System.Windows.Forms.Label
    Friend WithEvents lblPennies As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMain))
        Me.numInitMoney = New System.Windows.Forms.NumericUpDown
        Me.lblInitMoney = New System.Windows.Forms.Label
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.lblHalfDollars = New System.Windows.Forms.Label
        Me.lblQuarters = New System.Windows.Forms.Label
        Me.lblDimes = New System.Windows.Forms.Label
        Me.lblNickels = New System.Windows.Forms.Label
        Me.lblPennies = New System.Windows.Forms.Label
        CType(Me.numInitMoney, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'numInitMoney
        '
        Me.numInitMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numInitMoney.DecimalPlaces = 2
        Me.numInitMoney.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.numInitMoney.Location = New System.Drawing.Point(160, 8)
        Me.numInitMoney.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numInitMoney.Name = "numInitMoney"
        Me.numInitMoney.Size = New System.Drawing.Size(56, 26)
        Me.numInitMoney.TabIndex = 0
        Me.numInitMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblInitMoney
        '
        Me.lblInitMoney.Location = New System.Drawing.Point(8, 8)
        Me.lblInitMoney.Name = "lblInitMoney"
        Me.lblInitMoney.Size = New System.Drawing.Size(152, 23)
        Me.lblInitMoney.TabIndex = 1
        Me.lblInitMoney.Text = "Insert Money Here:"
        '
        'btnCalculate
        '
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculate.Location = New System.Drawing.Point(56, 40)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(112, 24)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Enter"
        '
        'lblHalfDollars
        '
        Me.lblHalfDollars.Location = New System.Drawing.Point(56, 72)
        Me.lblHalfDollars.Name = "lblHalfDollars"
        Me.lblHalfDollars.Size = New System.Drawing.Size(120, 23)
        Me.lblHalfDollars.TabIndex = 3
        Me.lblHalfDollars.Text = "Half Dollars: 0"
        Me.lblHalfDollars.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblQuarters
        '
        Me.lblQuarters.Location = New System.Drawing.Point(56, 96)
        Me.lblQuarters.Name = "lblQuarters"
        Me.lblQuarters.Size = New System.Drawing.Size(120, 23)
        Me.lblQuarters.TabIndex = 4
        Me.lblQuarters.Text = "Quarters: 0"
        Me.lblQuarters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDimes
        '
        Me.lblDimes.Location = New System.Drawing.Point(56, 120)
        Me.lblDimes.Name = "lblDimes"
        Me.lblDimes.Size = New System.Drawing.Size(120, 23)
        Me.lblDimes.TabIndex = 5
        Me.lblDimes.Text = "Dimes: 0"
        Me.lblDimes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNickels
        '
        Me.lblNickels.Location = New System.Drawing.Point(56, 144)
        Me.lblNickels.Name = "lblNickels"
        Me.lblNickels.Size = New System.Drawing.Size(120, 23)
        Me.lblNickels.TabIndex = 6
        Me.lblNickels.Text = "Nickels: 0"
        Me.lblNickels.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPennies
        '
        Me.lblPennies.Location = New System.Drawing.Point(56, 168)
        Me.lblPennies.Name = "lblPennies"
        Me.lblPennies.Size = New System.Drawing.Size(120, 23)
        Me.lblPennies.TabIndex = 7
        Me.lblPennies.Text = "Pennies: 0"
        Me.lblPennies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 19)
        Me.ClientSize = New System.Drawing.Size(226, 194)
        Me.Controls.Add(Me.lblPennies)
        Me.Controls.Add(Me.lblNickels)
        Me.Controls.Add(Me.lblDimes)
        Me.Controls.Add(Me.lblQuarters)
        Me.Controls.Add(Me.lblHalfDollars)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblInitMoney)
        Me.Controls.Add(Me.numInitMoney)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(232, 222)
        Me.MinimumSize = New System.Drawing.Size(232, 222)
        Me.Name = "frmMain"
        Me.Text = "Change Calculator"
        CType(Me.numInitMoney, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click

        'sets the total amount of money to a variable
        Dim dcmMoneyLeft As Decimal = (1 - numInitMoney.Value)
        'sets all of the different coins
        Dim intHalfDollar As Integer = 0
        Dim intQuarter As Integer = 0
        Dim intDime As Integer = 0
        Dim intNickel As Integer = 0
        Dim intPenny As Integer = 0

        'Calculates the number of each coin
        Do While dcmMoneyLeft >= 0.5

            dcmMoneyLeft = dcmMoneyLeft - 0.5
            intHalfDollar = intHalfDollar + 1

        Loop
        Do While dcmMoneyLeft >= 0.25

            dcmMoneyLeft = dcmMoneyLeft - 0.25
            intQuarter = intQuarter + 1

        Loop
        Do While dcmMoneyLeft >= 0.1

            dcmMoneyLeft = dcmMoneyLeft - 0.1
            intDime = intDime + 1

        Loop
        Do While dcmMoneyLeft >= 0.05

            dcmMoneyLeft = dcmMoneyLeft - 0.05
            intNickel = intNickel + 1

        Loop
        Do While dcmMoneyLeft > 0

            dcmMoneyLeft = dcmMoneyLeft - 0.01
            intPenny = intPenny + 1

        Loop

        'Assigns the text boxes
        lblHalfDollars.Text = ("Half Dollars: " & intHalfDollar)
        lblQuarters.Text = ("Quarters: " & intQuarter)
        lblDimes.Text = ("Dimes: " & intDime)
        lblNickels.Text = ("Nickels: " & intNickel)
        lblPennies.Text = ("Pennies: " & intPenny)

    End Sub

End Class
