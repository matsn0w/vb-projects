<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gbxCar = New System.Windows.Forms.GroupBox()
        Me.cbxCar = New System.Windows.Forms.ComboBox()
        Me.gbxRent = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblResultTime = New System.Windows.Forms.Label()
        Me.lblResultCar = New System.Windows.Forms.Label()
        Me.lblResultPrice = New System.Windows.Forms.Label()
        Me.tbxResultCar = New System.Windows.Forms.TextBox()
        Me.tbxResultTime = New System.Windows.Forms.TextBox()
        Me.tbxResultPrice = New System.Windows.Forms.TextBox()
        Me.gbxResult = New System.Windows.Forms.GroupBox()
        Me.tbxResultEnd = New System.Windows.Forms.TextBox()
        Me.lblResultEnd = New System.Windows.Forms.Label()
        Me.tbxResultStart = New System.Windows.Forms.TextBox()
        Me.lblResultStart = New System.Windows.Forms.Label()
        Me.MonthCalendar2 = New System.Windows.Forms.MonthCalendar()
        Me.gbxCar.SuspendLayout()
        Me.gbxRent.SuspendLayout()
        Me.gbxResult.SuspendLayout()
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
        Me.gbxRent.Controls.Add(Me.Label2)
        Me.gbxRent.Controls.Add(Me.Label1)
        Me.gbxRent.Controls.Add(Me.MonthCalendar1)
        Me.gbxRent.Location = New System.Drawing.Point(13, 71)
        Me.gbxRent.Name = "gbxRent"
        Me.gbxRent.Size = New System.Drawing.Size(413, 202)
        Me.gbxRent.TabIndex = 1
        Me.gbxRent.TabStop = False
        Me.gbxRent.Text = "Huur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(287, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Einddatum"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Startdatum"
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
        Me.btnCalculate.Location = New System.Drawing.Point(339, 279)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(87, 23)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "&Bereken"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblResultTime
        '
        Me.lblResultTime.AutoSize = True
        Me.lblResultTime.Location = New System.Drawing.Point(4, 98)
        Me.lblResultTime.Name = "lblResultTime"
        Me.lblResultTime.Size = New System.Drawing.Size(53, 13)
        Me.lblResultTime.TabIndex = 4
        Me.lblResultTime.Text = "Tijdsduur:"
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
        Me.lblResultPrice.Location = New System.Drawing.Point(6, 178)
        Me.lblResultPrice.Name = "lblResultPrice"
        Me.lblResultPrice.Size = New System.Drawing.Size(29, 13)
        Me.lblResultPrice.TabIndex = 7
        Me.lblResultPrice.Text = "Prijs:"
        '
        'tbxResultCar
        '
        Me.tbxResultCar.Location = New System.Drawing.Point(154, 19)
        Me.tbxResultCar.Name = "tbxResultCar"
        Me.tbxResultCar.ReadOnly = True
        Me.tbxResultCar.Size = New System.Drawing.Size(248, 20)
        Me.tbxResultCar.TabIndex = 8
        Me.tbxResultCar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbxResultTime
        '
        Me.tbxResultTime.Location = New System.Drawing.Point(154, 95)
        Me.tbxResultTime.Name = "tbxResultTime"
        Me.tbxResultTime.ReadOnly = True
        Me.tbxResultTime.Size = New System.Drawing.Size(248, 20)
        Me.tbxResultTime.TabIndex = 8
        Me.tbxResultTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbxResultPrice
        '
        Me.tbxResultPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbxResultPrice.Location = New System.Drawing.Point(154, 175)
        Me.tbxResultPrice.Name = "tbxResultPrice"
        Me.tbxResultPrice.ReadOnly = True
        Me.tbxResultPrice.Size = New System.Drawing.Size(248, 20)
        Me.tbxResultPrice.TabIndex = 8
        Me.tbxResultPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'gbxResult
        '
        Me.gbxResult.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbxResult.Controls.Add(Me.tbxResultEnd)
        Me.gbxResult.Controls.Add(Me.lblResultEnd)
        Me.gbxResult.Controls.Add(Me.tbxResultStart)
        Me.gbxResult.Controls.Add(Me.lblResultStart)
        Me.gbxResult.Controls.Add(Me.lblResultPrice)
        Me.gbxResult.Controls.Add(Me.tbxResultPrice)
        Me.gbxResult.Controls.Add(Me.tbxResultCar)
        Me.gbxResult.Controls.Add(Me.lblResultTime)
        Me.gbxResult.Controls.Add(Me.lblResultCar)
        Me.gbxResult.Controls.Add(Me.tbxResultTime)
        Me.gbxResult.Location = New System.Drawing.Point(12, 330)
        Me.gbxResult.Name = "gbxResult"
        Me.gbxResult.Size = New System.Drawing.Size(408, 201)
        Me.gbxResult.TabIndex = 9
        Me.gbxResult.TabStop = False
        Me.gbxResult.Text = "Resultaat"
        '
        'tbxResultEnd
        '
        Me.tbxResultEnd.Location = New System.Drawing.Point(154, 71)
        Me.tbxResultEnd.Name = "tbxResultEnd"
        Me.tbxResultEnd.ReadOnly = True
        Me.tbxResultEnd.Size = New System.Drawing.Size(248, 20)
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
        Me.tbxResultStart.Size = New System.Drawing.Size(248, 20)
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 543)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbxCar As GroupBox
    Friend WithEvents cbxCar As ComboBox
    Friend WithEvents gbxRent As GroupBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblResultTime As Label
    Friend WithEvents lblResultCar As Label
    Friend WithEvents lblResultPrice As Label
    Friend WithEvents tbxResultCar As TextBox
    Friend WithEvents tbxResultTime As TextBox
    Friend WithEvents tbxResultPrice As TextBox
    Friend WithEvents gbxResult As GroupBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbxResultEnd As TextBox
    Friend WithEvents lblResultEnd As Label
    Friend WithEvents tbxResultStart As TextBox
    Friend WithEvents lblResultStart As Label
    Friend WithEvents MonthCalendar2 As MonthCalendar
End Class
