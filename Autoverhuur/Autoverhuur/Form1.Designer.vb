<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.gbxCar = New System.Windows.Forms.GroupBox()
        Me.cbxCar = New System.Windows.Forms.ComboBox()
        Me.gbxRent = New System.Windows.Forms.GroupBox()
        Me.MonthCalendar2 = New System.Windows.Forms.MonthCalendar()
        Me.lblEndDay = New System.Windows.Forms.Label()
        Me.lblStartDay = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblResultWeeks = New System.Windows.Forms.Label()
        Me.lblResultCar = New System.Windows.Forms.Label()
        Me.lblResultPrice = New System.Windows.Forms.Label()
        Me.tbxResultCar = New System.Windows.Forms.TextBox()
        Me.tbxResultWeeks = New System.Windows.Forms.TextBox()
        Me.tbxResultPrice = New System.Windows.Forms.TextBox()
        Me.gbxResult = New System.Windows.Forms.GroupBox()
        Me.tbxResultDistance = New System.Windows.Forms.TextBox()
        Me.lblResultDistance = New System.Windows.Forms.Label()
        Me.tbxResultEnd = New System.Windows.Forms.TextBox()
        Me.lblResultEnd = New System.Windows.Forms.Label()
        Me.tbxResultStart = New System.Windows.Forms.TextBox()
        Me.lblResultStart = New System.Windows.Forms.Label()
        Me.gbxDistance = New System.Windows.Forms.GroupBox()
        Me.lblDistance = New System.Windows.Forms.Label()
        Me.nudDistance = New System.Windows.Forms.NumericUpDown()
        Me.tbxResultAllowance = New System.Windows.Forms.TextBox()
        Me.lblResultAllowance = New System.Windows.Forms.Label()
        Me.lblResultInsurance = New System.Windows.Forms.Label()
        Me.tbxResultInsurance = New System.Windows.Forms.TextBox()
        Me.tbxResultBasePrice = New System.Windows.Forms.TextBox()
        Me.lblResultBasePrice = New System.Windows.Forms.Label()
        Me.tbxResultDays = New System.Windows.Forms.TextBox()
        Me.lblResultDays = New System.Windows.Forms.Label()
        Me.gbxCar.SuspendLayout()
        Me.gbxRent.SuspendLayout()
        Me.gbxResult.SuspendLayout()
        Me.gbxDistance.SuspendLayout()
        CType(Me.nudDistance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxCar
        '
        Me.gbxCar.Controls.Add(Me.cbxCar)
        Me.gbxCar.Location = New System.Drawing.Point(13, 12)
        Me.gbxCar.Name = "gbxCar"
        Me.gbxCar.Size = New System.Drawing.Size(413, 53)
        Me.gbxCar.TabIndex = 0
        Me.gbxCar.TabStop = False
        Me.gbxCar.Text = "Auto"
        '
        'cbxCar
        '
        Me.cbxCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCar.FormattingEnabled = True
        Me.cbxCar.Items.AddRange(New Object() {"Compact", "Middenklasse", "Luxe", "Terreinwagen", "SUV"})
        Me.cbxCar.Location = New System.Drawing.Point(6, 19)
        Me.cbxCar.Name = "cbxCar"
        Me.cbxCar.Size = New System.Drawing.Size(401, 21)
        Me.cbxCar.TabIndex = 0
        '
        'gbxRent
        '
        Me.gbxRent.Controls.Add(Me.MonthCalendar2)
        Me.gbxRent.Controls.Add(Me.lblEndDay)
        Me.gbxRent.Controls.Add(Me.lblStartDay)
        Me.gbxRent.Controls.Add(Me.MonthCalendar1)
        Me.gbxRent.Location = New System.Drawing.Point(13, 71)
        Me.gbxRent.Name = "gbxRent"
        Me.gbxRent.Size = New System.Drawing.Size(413, 202)
        Me.gbxRent.TabIndex = 1
        Me.gbxRent.TabStop = False
        Me.gbxRent.Text = "Huur"
        '
        'MonthCalendar2
        '
        Me.MonthCalendar2.Location = New System.Drawing.Point(208, 37)
        Me.MonthCalendar2.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.MonthCalendar2.MaxSelectionCount = 1
        Me.MonthCalendar2.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.MonthCalendar2.Name = "MonthCalendar2"
        Me.MonthCalendar2.ShowWeekNumbers = True
        Me.MonthCalendar2.TabIndex = 4
        '
        'lblEndDay
        '
        Me.lblEndDay.AutoSize = True
        Me.lblEndDay.Location = New System.Drawing.Point(287, 16)
        Me.lblEndDay.Name = "lblEndDay"
        Me.lblEndDay.Size = New System.Drawing.Size(57, 13)
        Me.lblEndDay.TabIndex = 3
        Me.lblEndDay.Text = "Einddatum"
        '
        'lblStartDay
        '
        Me.lblStartDay.AutoSize = True
        Me.lblStartDay.Location = New System.Drawing.Point(79, 16)
        Me.lblStartDay.Name = "lblStartDay"
        Me.lblStartDay.Size = New System.Drawing.Size(58, 13)
        Me.lblStartDay.TabIndex = 2
        Me.lblStartDay.Text = "Startdatum"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(12, 37)
        Me.MonthCalendar1.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.MonthCalendar1.MaxSelectionCount = 1
        Me.MonthCalendar1.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.ShowWeekNumbers = True
        Me.MonthCalendar1.TabIndex = 0
        '
        'btnCalculate
        '
        Me.btnCalculate.AutoSize = True
        Me.btnCalculate.Location = New System.Drawing.Point(339, 337)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(87, 23)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "&Bereken"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblResultWeeks
        '
        Me.lblResultWeeks.AutoSize = True
        Me.lblResultWeeks.Location = New System.Drawing.Point(6, 100)
        Me.lblResultWeeks.Name = "lblResultWeeks"
        Me.lblResultWeeks.Size = New System.Drawing.Size(45, 13)
        Me.lblResultWeeks.TabIndex = 4
        Me.lblResultWeeks.Text = "Weken:"
        '
        'lblResultCar
        '
        Me.lblResultCar.AutoSize = True
        Me.lblResultCar.Location = New System.Drawing.Point(6, 22)
        Me.lblResultCar.Name = "lblResultCar"
        Me.lblResultCar.Size = New System.Drawing.Size(32, 13)
        Me.lblResultCar.TabIndex = 5
        Me.lblResultCar.Text = "Auto:"
        '
        'lblResultPrice
        '
        Me.lblResultPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblResultPrice.AutoSize = True
        Me.lblResultPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultPrice.Location = New System.Drawing.Point(6, 270)
        Me.lblResultPrice.Name = "lblResultPrice"
        Me.lblResultPrice.Size = New System.Drawing.Size(122, 13)
        Me.lblResultPrice.TabIndex = 7
        Me.lblResultPrice.Text = "Prijs incl. toeslagen:"
        '
        'tbxResultCar
        '
        Me.tbxResultCar.Location = New System.Drawing.Point(154, 19)
        Me.tbxResultCar.Name = "tbxResultCar"
        Me.tbxResultCar.ReadOnly = True
        Me.tbxResultCar.Size = New System.Drawing.Size(254, 20)
        Me.tbxResultCar.TabIndex = 8
        Me.tbxResultCar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbxResultWeeks
        '
        Me.tbxResultWeeks.Location = New System.Drawing.Point(154, 97)
        Me.tbxResultWeeks.Name = "tbxResultWeeks"
        Me.tbxResultWeeks.ReadOnly = True
        Me.tbxResultWeeks.Size = New System.Drawing.Size(254, 20)
        Me.tbxResultWeeks.TabIndex = 8
        Me.tbxResultWeeks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbxResultPrice
        '
        Me.tbxResultPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbxResultPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxResultPrice.Location = New System.Drawing.Point(154, 268)
        Me.tbxResultPrice.Name = "tbxResultPrice"
        Me.tbxResultPrice.ReadOnly = True
        Me.tbxResultPrice.Size = New System.Drawing.Size(254, 20)
        Me.tbxResultPrice.TabIndex = 8
        Me.tbxResultPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'gbxResult
        '
        Me.gbxResult.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbxResult.Controls.Add(Me.lblResultDays)
        Me.gbxResult.Controls.Add(Me.tbxResultDays)
        Me.gbxResult.Controls.Add(Me.lblResultBasePrice)
        Me.gbxResult.Controls.Add(Me.tbxResultBasePrice)
        Me.gbxResult.Controls.Add(Me.tbxResultInsurance)
        Me.gbxResult.Controls.Add(Me.lblResultInsurance)
        Me.gbxResult.Controls.Add(Me.lblResultAllowance)
        Me.gbxResult.Controls.Add(Me.tbxResultAllowance)
        Me.gbxResult.Controls.Add(Me.tbxResultDistance)
        Me.gbxResult.Controls.Add(Me.lblResultDistance)
        Me.gbxResult.Controls.Add(Me.tbxResultEnd)
        Me.gbxResult.Controls.Add(Me.lblResultEnd)
        Me.gbxResult.Controls.Add(Me.tbxResultStart)
        Me.gbxResult.Controls.Add(Me.lblResultStart)
        Me.gbxResult.Controls.Add(Me.lblResultPrice)
        Me.gbxResult.Controls.Add(Me.tbxResultPrice)
        Me.gbxResult.Controls.Add(Me.tbxResultCar)
        Me.gbxResult.Controls.Add(Me.lblResultWeeks)
        Me.gbxResult.Controls.Add(Me.lblResultCar)
        Me.gbxResult.Controls.Add(Me.tbxResultWeeks)
        Me.gbxResult.Location = New System.Drawing.Point(12, 366)
        Me.gbxResult.Name = "gbxResult"
        Me.gbxResult.Size = New System.Drawing.Size(414, 294)
        Me.gbxResult.TabIndex = 9
        Me.gbxResult.TabStop = False
        Me.gbxResult.Text = "Resultaat"
        '
        'tbxResultDistance
        '
        Me.tbxResultDistance.Location = New System.Drawing.Point(154, 149)
        Me.tbxResultDistance.Name = "tbxResultDistance"
        Me.tbxResultDistance.ReadOnly = True
        Me.tbxResultDistance.Size = New System.Drawing.Size(254, 20)
        Me.tbxResultDistance.TabIndex = 14
        Me.tbxResultDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblResultDistance
        '
        Me.lblResultDistance.AutoSize = True
        Me.lblResultDistance.Location = New System.Drawing.Point(6, 152)
        Me.lblResultDistance.Name = "lblResultDistance"
        Me.lblResultDistance.Size = New System.Drawing.Size(101, 13)
        Me.lblResultDistance.TabIndex = 13
        Me.lblResultDistance.Text = "Gereden kilometers:"
        '
        'tbxResultEnd
        '
        Me.tbxResultEnd.Location = New System.Drawing.Point(154, 71)
        Me.tbxResultEnd.Name = "tbxResultEnd"
        Me.tbxResultEnd.ReadOnly = True
        Me.tbxResultEnd.Size = New System.Drawing.Size(254, 20)
        Me.tbxResultEnd.TabIndex = 12
        Me.tbxResultEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblResultEnd
        '
        Me.lblResultEnd.AutoSize = True
        Me.lblResultEnd.Location = New System.Drawing.Point(6, 74)
        Me.lblResultEnd.Name = "lblResultEnd"
        Me.lblResultEnd.Size = New System.Drawing.Size(57, 13)
        Me.lblResultEnd.TabIndex = 11
        Me.lblResultEnd.Text = "Einddatum"
        '
        'tbxResultStart
        '
        Me.tbxResultStart.Location = New System.Drawing.Point(154, 45)
        Me.tbxResultStart.Name = "tbxResultStart"
        Me.tbxResultStart.ReadOnly = True
        Me.tbxResultStart.Size = New System.Drawing.Size(254, 20)
        Me.tbxResultStart.TabIndex = 10
        Me.tbxResultStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblResultStart
        '
        Me.lblResultStart.AutoSize = True
        Me.lblResultStart.Location = New System.Drawing.Point(6, 48)
        Me.lblResultStart.Name = "lblResultStart"
        Me.lblResultStart.Size = New System.Drawing.Size(63, 13)
        Me.lblResultStart.TabIndex = 9
        Me.lblResultStart.Text = "Begindatum"
        '
        'gbxDistance
        '
        Me.gbxDistance.Controls.Add(Me.lblDistance)
        Me.gbxDistance.Controls.Add(Me.nudDistance)
        Me.gbxDistance.Location = New System.Drawing.Point(19, 280)
        Me.gbxDistance.Name = "gbxDistance"
        Me.gbxDistance.Size = New System.Drawing.Size(407, 51)
        Me.gbxDistance.TabIndex = 10
        Me.gbxDistance.TabStop = False
        Me.gbxDistance.Text = "Afstand"
        '
        'lblDistance
        '
        Me.lblDistance.AutoSize = True
        Me.lblDistance.Location = New System.Drawing.Point(352, 22)
        Me.lblDistance.Name = "lblDistance"
        Me.lblDistance.Size = New System.Drawing.Size(49, 13)
        Me.lblDistance.TabIndex = 1
        Me.lblDistance.Text = "kilometer"
        '
        'nudDistance
        '
        Me.nudDistance.Location = New System.Drawing.Point(6, 20)
        Me.nudDistance.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.nudDistance.Name = "nudDistance"
        Me.nudDistance.Size = New System.Drawing.Size(340, 20)
        Me.nudDistance.TabIndex = 0
        '
        'tbxResultAllowance
        '
        Me.tbxResultAllowance.Location = New System.Drawing.Point(154, 175)
        Me.tbxResultAllowance.Name = "tbxResultAllowance"
        Me.tbxResultAllowance.ReadOnly = True
        Me.tbxResultAllowance.Size = New System.Drawing.Size(254, 20)
        Me.tbxResultAllowance.TabIndex = 15
        Me.tbxResultAllowance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblResultAllowance
        '
        Me.lblResultAllowance.AutoSize = True
        Me.lblResultAllowance.Location = New System.Drawing.Point(6, 178)
        Me.lblResultAllowance.Name = "lblResultAllowance"
        Me.lblResultAllowance.Size = New System.Drawing.Size(48, 13)
        Me.lblResultAllowance.TabIndex = 16
        Me.lblResultAllowance.Text = "Toeslag:"
        '
        'lblResultInsurance
        '
        Me.lblResultInsurance.AutoSize = True
        Me.lblResultInsurance.Location = New System.Drawing.Point(6, 204)
        Me.lblResultInsurance.Name = "lblResultInsurance"
        Me.lblResultInsurance.Size = New System.Drawing.Size(66, 13)
        Me.lblResultInsurance.TabIndex = 17
        Me.lblResultInsurance.Text = "Verzekering:"
        '
        'tbxResultInsurance
        '
        Me.tbxResultInsurance.Location = New System.Drawing.Point(154, 201)
        Me.tbxResultInsurance.Name = "tbxResultInsurance"
        Me.tbxResultInsurance.ReadOnly = True
        Me.tbxResultInsurance.Size = New System.Drawing.Size(254, 20)
        Me.tbxResultInsurance.TabIndex = 18
        Me.tbxResultInsurance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbxResultBasePrice
        '
        Me.tbxResultBasePrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbxResultBasePrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxResultBasePrice.Location = New System.Drawing.Point(154, 242)
        Me.tbxResultBasePrice.Name = "tbxResultBasePrice"
        Me.tbxResultBasePrice.ReadOnly = True
        Me.tbxResultBasePrice.Size = New System.Drawing.Size(254, 20)
        Me.tbxResultBasePrice.TabIndex = 19
        Me.tbxResultBasePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblResultBasePrice
        '
        Me.lblResultBasePrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblResultBasePrice.AutoSize = True
        Me.lblResultBasePrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultBasePrice.Location = New System.Drawing.Point(6, 244)
        Me.lblResultBasePrice.Name = "lblResultBasePrice"
        Me.lblResultBasePrice.Size = New System.Drawing.Size(53, 13)
        Me.lblResultBasePrice.TabIndex = 20
        Me.lblResultBasePrice.Text = "Basisprijs:"
        '
        'tbxResultDays
        '
        Me.tbxResultDays.Location = New System.Drawing.Point(154, 123)
        Me.tbxResultDays.Name = "tbxResultDays"
        Me.tbxResultDays.ReadOnly = True
        Me.tbxResultDays.Size = New System.Drawing.Size(254, 20)
        Me.tbxResultDays.TabIndex = 21
        Me.tbxResultDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblResultDays
        '
        Me.lblResultDays.AutoSize = True
        Me.lblResultDays.Location = New System.Drawing.Point(6, 126)
        Me.lblResultDays.Name = "lblResultDays"
        Me.lblResultDays.Size = New System.Drawing.Size(42, 13)
        Me.lblResultDays.TabIndex = 22
        Me.lblResultDays.Text = "Dagen:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 672)
        Me.Controls.Add(Me.gbxDistance)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.gbxRent)
        Me.Controls.Add(Me.gbxCar)
        Me.Controls.Add(Me.gbxResult)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Autoverhuur"
        Me.gbxCar.ResumeLayout(False)
        Me.gbxRent.ResumeLayout(False)
        Me.gbxRent.PerformLayout()
        Me.gbxResult.ResumeLayout(False)
        Me.gbxResult.PerformLayout()
        Me.gbxDistance.ResumeLayout(False)
        Me.gbxDistance.PerformLayout()
        CType(Me.nudDistance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbxCar As GroupBox
    Friend WithEvents cbxCar As ComboBox
    Friend WithEvents gbxRent As GroupBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblResultWeeks As Label
    Friend WithEvents lblResultCar As Label
    Friend WithEvents lblResultPrice As Label
    Friend WithEvents tbxResultCar As TextBox
    Friend WithEvents tbxResultWeeks As TextBox
    Friend WithEvents tbxResultPrice As TextBox
    Friend WithEvents gbxResult As GroupBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents lblEndDay As Label
    Friend WithEvents lblStartDay As Label
    Friend WithEvents tbxResultEnd As TextBox
    Friend WithEvents lblResultEnd As Label
    Friend WithEvents tbxResultStart As TextBox
    Friend WithEvents lblResultStart As Label
    Friend WithEvents MonthCalendar2 As MonthCalendar
    Friend WithEvents tbxResultDistance As TextBox
    Friend WithEvents lblResultDistance As Label
    Friend WithEvents gbxDistance As GroupBox
    Friend WithEvents lblDistance As Label
    Friend WithEvents nudDistance As NumericUpDown
    Friend WithEvents tbxResultInsurance As TextBox
    Friend WithEvents lblResultInsurance As Label
    Friend WithEvents lblResultAllowance As Label
    Friend WithEvents tbxResultAllowance As TextBox
    Friend WithEvents lblResultBasePrice As Label
    Friend WithEvents tbxResultBasePrice As TextBox
    Friend WithEvents lblResultDays As Label
    Friend WithEvents tbxResultDays As TextBox
End Class
