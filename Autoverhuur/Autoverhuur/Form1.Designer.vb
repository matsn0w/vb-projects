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
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblResultDays = New System.Windows.Forms.Label()
        Me.lblResultCar = New System.Windows.Forms.Label()
        Me.lblResultWeeks = New System.Windows.Forms.Label()
        Me.lblResultPrice = New System.Windows.Forms.Label()
        Me.tbxResultCar = New System.Windows.Forms.TextBox()
        Me.tbxResultDays = New System.Windows.Forms.TextBox()
        Me.tbxResultWeeks = New System.Windows.Forms.TextBox()
        Me.tbxResultPrice = New System.Windows.Forms.TextBox()
        Me.gbxResult = New System.Windows.Forms.GroupBox()
        Me.MonthCalendar2 = New System.Windows.Forms.MonthCalendar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbxCar.SuspendLayout()
        Me.gbxRent.SuspendLayout()
        Me.gbxResult.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxCar
        '
        Me.gbxCar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbxCar.Controls.Add(Me.cbxCar)
        Me.gbxCar.Location = New System.Drawing.Point(13, 12)
        Me.gbxCar.Name = "gbxCar"
        Me.gbxCar.Size = New System.Drawing.Size(375, 53)
        Me.gbxCar.TabIndex = 0
        Me.gbxCar.TabStop = False
        Me.gbxCar.Text = "Auto"
        '
        'cbxCar
        '
        Me.cbxCar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbxCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCar.FormattingEnabled = True
        Me.cbxCar.Items.AddRange(New Object() {"Compact", "Middenklasse", "Luxe", "Terreinwagen", "SUV"})
        Me.cbxCar.Location = New System.Drawing.Point(6, 19)
        Me.cbxCar.Name = "cbxCar"
        Me.cbxCar.Size = New System.Drawing.Size(363, 21)
        Me.cbxCar.TabIndex = 0
        '
        'gbxRent
        '
        Me.gbxRent.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbxRent.Controls.Add(Me.Label2)
        Me.gbxRent.Controls.Add(Me.Label1)
        Me.gbxRent.Controls.Add(Me.MonthCalendar2)
        Me.gbxRent.Controls.Add(Me.MonthCalendar1)
        Me.gbxRent.Location = New System.Drawing.Point(13, 71)
        Me.gbxRent.Name = "gbxRent"
        Me.gbxRent.Size = New System.Drawing.Size(375, 202)
        Me.gbxRent.TabIndex = 1
        Me.gbxRent.TabStop = False
        Me.gbxRent.Text = "Huur"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MonthCalendar1.Location = New System.Drawing.Point(12, 37)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'btnCalculate
        '
        Me.btnCalculate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCalculate.AutoSize = True
        Me.btnCalculate.Location = New System.Drawing.Point(301, 282)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(87, 23)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Bereken"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblResultDays
        '
        Me.lblResultDays.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblResultDays.AutoSize = True
        Me.lblResultDays.Location = New System.Drawing.Point(6, 48)
        Me.lblResultDays.Name = "lblResultDays"
        Me.lblResultDays.Size = New System.Drawing.Size(73, 13)
        Me.lblResultDays.TabIndex = 4
        Me.lblResultDays.Text = "Aantal dagen:"
        '
        'lblResultCar
        '
        Me.lblResultCar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblResultCar.AutoSize = True
        Me.lblResultCar.Location = New System.Drawing.Point(6, 22)
        Me.lblResultCar.Name = "lblResultCar"
        Me.lblResultCar.Size = New System.Drawing.Size(32, 13)
        Me.lblResultCar.TabIndex = 5
        Me.lblResultCar.Text = "Auto:"
        '
        'lblResultWeeks
        '
        Me.lblResultWeeks.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblResultWeeks.AutoSize = True
        Me.lblResultWeeks.Location = New System.Drawing.Point(6, 74)
        Me.lblResultWeeks.Name = "lblResultWeeks"
        Me.lblResultWeeks.Size = New System.Drawing.Size(75, 13)
        Me.lblResultWeeks.TabIndex = 6
        Me.lblResultWeeks.Text = "Aantal weken:"
        '
        'lblResultPrice
        '
        Me.lblResultPrice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblResultPrice.AutoSize = True
        Me.lblResultPrice.Location = New System.Drawing.Point(6, 108)
        Me.lblResultPrice.Name = "lblResultPrice"
        Me.lblResultPrice.Size = New System.Drawing.Size(29, 13)
        Me.lblResultPrice.TabIndex = 7
        Me.lblResultPrice.Text = "Prijs:"
        '
        'tbxResultCar
        '
        Me.tbxResultCar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbxResultCar.Location = New System.Drawing.Point(154, 19)
        Me.tbxResultCar.Name = "tbxResultCar"
        Me.tbxResultCar.ReadOnly = True
        Me.tbxResultCar.Size = New System.Drawing.Size(216, 20)
        Me.tbxResultCar.TabIndex = 8
        '
        'tbxResultDays
        '
        Me.tbxResultDays.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbxResultDays.Location = New System.Drawing.Point(154, 45)
        Me.tbxResultDays.Name = "tbxResultDays"
        Me.tbxResultDays.ReadOnly = True
        Me.tbxResultDays.Size = New System.Drawing.Size(216, 20)
        Me.tbxResultDays.TabIndex = 8
        '
        'tbxResultWeeks
        '
        Me.tbxResultWeeks.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbxResultWeeks.Location = New System.Drawing.Point(154, 71)
        Me.tbxResultWeeks.Name = "tbxResultWeeks"
        Me.tbxResultWeeks.ReadOnly = True
        Me.tbxResultWeeks.Size = New System.Drawing.Size(216, 20)
        Me.tbxResultWeeks.TabIndex = 8
        '
        'tbxResultPrice
        '
        Me.tbxResultPrice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbxResultPrice.Location = New System.Drawing.Point(154, 105)
        Me.tbxResultPrice.Name = "tbxResultPrice"
        Me.tbxResultPrice.ReadOnly = True
        Me.tbxResultPrice.Size = New System.Drawing.Size(216, 20)
        Me.tbxResultPrice.TabIndex = 8
        '
        'gbxResult
        '
        Me.gbxResult.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxResult.Controls.Add(Me.lblResultWeeks)
        Me.gbxResult.Controls.Add(Me.lblResultPrice)
        Me.gbxResult.Controls.Add(Me.tbxResultPrice)
        Me.gbxResult.Controls.Add(Me.tbxResultCar)
        Me.gbxResult.Controls.Add(Me.lblResultDays)
        Me.gbxResult.Controls.Add(Me.lblResultCar)
        Me.gbxResult.Controls.Add(Me.tbxResultWeeks)
        Me.gbxResult.Controls.Add(Me.tbxResultDays)
        Me.gbxResult.Location = New System.Drawing.Point(12, 330)
        Me.gbxResult.Name = "gbxResult"
        Me.gbxResult.Size = New System.Drawing.Size(376, 131)
        Me.gbxResult.TabIndex = 9
        Me.gbxResult.TabStop = False
        Me.gbxResult.Text = "Resultaat"
        '
        'MonthCalendar2
        '
        Me.MonthCalendar2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MonthCalendar2.Location = New System.Drawing.Point(192, 37)
        Me.MonthCalendar2.Name = "MonthCalendar2"
        Me.MonthCalendar2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Startdatum"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(249, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Einddatum"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 473)
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
    Friend WithEvents lblResultDays As Label
    Friend WithEvents lblResultCar As Label
    Friend WithEvents lblResultWeeks As Label
    Friend WithEvents lblResultPrice As Label
    Friend WithEvents tbxResultCar As TextBox
    Friend WithEvents tbxResultDays As TextBox
    Friend WithEvents tbxResultWeeks As TextBox
    Friend WithEvents tbxResultPrice As TextBox
    Friend WithEvents gbxResult As GroupBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MonthCalendar2 As MonthCalendar
End Class
