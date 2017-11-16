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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.gbxInput = New System.Windows.Forms.GroupBox()
        Me.cbxInputColor = New System.Windows.Forms.ComboBox()
        Me.lblInputColor = New System.Windows.Forms.Label()
        Me.lblInputMeters2 = New System.Windows.Forms.Label()
        Me.lblInputMeters1 = New System.Windows.Forms.Label()
        Me.tbxInputWidth = New System.Windows.Forms.TextBox()
        Me.tbxInputLength = New System.Windows.Forms.TextBox()
        Me.lblInputWidth = New System.Windows.Forms.Label()
        Me.lblInputLength = New System.Windows.Forms.Label()
        Me.gbxOutput = New System.Windows.Forms.GroupBox()
        Me.lblOutputColor = New System.Windows.Forms.Label()
        Me.lblOutputSquareMeters = New System.Windows.Forms.Label()
        Me.tbxOutputSurface = New System.Windows.Forms.TextBox()
        Me.lblOutputSurface = New System.Windows.Forms.Label()
        Me.tbxOutputColor = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.tbxOutputPrice = New System.Windows.Forms.TextBox()
        Me.tbxOutputDiscount = New System.Windows.Forms.TextBox()
        Me.lblOutputDiscount = New System.Windows.Forms.Label()
        Me.tbxOutputTotalPrice = New System.Windows.Forms.TextBox()
        Me.lblOutputTotalPrice = New System.Windows.Forms.Label()
        Me.gbxInput.SuspendLayout()
        Me.gbxOutput.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxInput
        '
        Me.gbxInput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxInput.Controls.Add(Me.cbxInputColor)
        Me.gbxInput.Controls.Add(Me.lblInputColor)
        Me.gbxInput.Controls.Add(Me.lblInputMeters2)
        Me.gbxInput.Controls.Add(Me.lblInputMeters1)
        Me.gbxInput.Controls.Add(Me.tbxInputWidth)
        Me.gbxInput.Controls.Add(Me.tbxInputLength)
        Me.gbxInput.Controls.Add(Me.lblInputWidth)
        Me.gbxInput.Controls.Add(Me.lblInputLength)
        Me.gbxInput.Location = New System.Drawing.Point(13, 13)
        Me.gbxInput.Name = "gbxInput"
        Me.gbxInput.Size = New System.Drawing.Size(259, 104)
        Me.gbxInput.TabIndex = 0
        Me.gbxInput.TabStop = False
        Me.gbxInput.Text = "Invoer"
        '
        'cbxInputColor
        '
        Me.cbxInputColor.FormattingEnabled = True
        Me.cbxInputColor.Items.AddRange(New Object() {"Groen", "Paars"})
        Me.cbxInputColor.Location = New System.Drawing.Point(93, 72)
        Me.cbxInputColor.Name = "cbxInputColor"
        Me.cbxInputColor.Size = New System.Drawing.Size(121, 21)
        Me.cbxInputColor.TabIndex = 7
        '
        'lblInputColor
        '
        Me.lblInputColor.AutoSize = True
        Me.lblInputColor.Location = New System.Drawing.Point(6, 75)
        Me.lblInputColor.Name = "lblInputColor"
        Me.lblInputColor.Size = New System.Drawing.Size(34, 13)
        Me.lblInputColor.TabIndex = 6
        Me.lblInputColor.Text = "Kleur:"
        '
        'lblInputMeters2
        '
        Me.lblInputMeters2.AutoSize = True
        Me.lblInputMeters2.Location = New System.Drawing.Point(220, 48)
        Me.lblInputMeters2.Name = "lblInputMeters2"
        Me.lblInputMeters2.Size = New System.Drawing.Size(33, 13)
        Me.lblInputMeters2.TabIndex = 5
        Me.lblInputMeters2.Text = "meter"
        '
        'lblInputMeters1
        '
        Me.lblInputMeters1.AutoSize = True
        Me.lblInputMeters1.Location = New System.Drawing.Point(220, 22)
        Me.lblInputMeters1.Name = "lblInputMeters1"
        Me.lblInputMeters1.Size = New System.Drawing.Size(33, 13)
        Me.lblInputMeters1.TabIndex = 4
        Me.lblInputMeters1.Text = "meter"
        '
        'tbxInputWidth
        '
        Me.tbxInputWidth.Location = New System.Drawing.Point(93, 45)
        Me.tbxInputWidth.Name = "tbxInputWidth"
        Me.tbxInputWidth.Size = New System.Drawing.Size(121, 20)
        Me.tbxInputWidth.TabIndex = 3
        '
        'tbxInputLength
        '
        Me.tbxInputLength.Location = New System.Drawing.Point(93, 19)
        Me.tbxInputLength.Name = "tbxInputLength"
        Me.tbxInputLength.Size = New System.Drawing.Size(121, 20)
        Me.tbxInputLength.TabIndex = 2
        '
        'lblInputWidth
        '
        Me.lblInputWidth.AutoSize = True
        Me.lblInputWidth.Location = New System.Drawing.Point(6, 48)
        Me.lblInputWidth.Name = "lblInputWidth"
        Me.lblInputWidth.Size = New System.Drawing.Size(47, 13)
        Me.lblInputWidth.TabIndex = 1
        Me.lblInputWidth.Text = "Breedte:"
        '
        'lblInputLength
        '
        Me.lblInputLength.AutoSize = True
        Me.lblInputLength.Location = New System.Drawing.Point(6, 22)
        Me.lblInputLength.Name = "lblInputLength"
        Me.lblInputLength.Size = New System.Drawing.Size(43, 13)
        Me.lblInputLength.TabIndex = 0
        Me.lblInputLength.Text = "Lengte:"
        '
        'gbxOutput
        '
        Me.gbxOutput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxOutput.Controls.Add(Me.lblOutputTotalPrice)
        Me.gbxOutput.Controls.Add(Me.tbxOutputTotalPrice)
        Me.gbxOutput.Controls.Add(Me.lblOutputDiscount)
        Me.gbxOutput.Controls.Add(Me.tbxOutputDiscount)
        Me.gbxOutput.Controls.Add(Me.tbxOutputPrice)
        Me.gbxOutput.Controls.Add(Me.lblPrice)
        Me.gbxOutput.Controls.Add(Me.tbxOutputColor)
        Me.gbxOutput.Controls.Add(Me.lblOutputColor)
        Me.gbxOutput.Controls.Add(Me.lblOutputSquareMeters)
        Me.gbxOutput.Controls.Add(Me.tbxOutputSurface)
        Me.gbxOutput.Controls.Add(Me.lblOutputSurface)
        Me.gbxOutput.Location = New System.Drawing.Point(13, 123)
        Me.gbxOutput.Name = "gbxOutput"
        Me.gbxOutput.Size = New System.Drawing.Size(259, 170)
        Me.gbxOutput.TabIndex = 1
        Me.gbxOutput.TabStop = False
        Me.gbxOutput.Text = "Resultaat"
        '
        'lblOutputColor
        '
        Me.lblOutputColor.AutoSize = True
        Me.lblOutputColor.Location = New System.Drawing.Point(6, 48)
        Me.lblOutputColor.Name = "lblOutputColor"
        Me.lblOutputColor.Size = New System.Drawing.Size(34, 13)
        Me.lblOutputColor.TabIndex = 9
        Me.lblOutputColor.Text = "Kleur:"
        '
        'lblOutputSquareMeters
        '
        Me.lblOutputSquareMeters.AutoSize = True
        Me.lblOutputSquareMeters.Location = New System.Drawing.Point(220, 22)
        Me.lblOutputSquareMeters.Name = "lblOutputSquareMeters"
        Me.lblOutputSquareMeters.Size = New System.Drawing.Size(18, 13)
        Me.lblOutputSquareMeters.TabIndex = 8
        Me.lblOutputSquareMeters.Text = "m²"
        '
        'tbxOutputSurface
        '
        Me.tbxOutputSurface.Location = New System.Drawing.Point(93, 19)
        Me.tbxOutputSurface.Name = "tbxOutputSurface"
        Me.tbxOutputSurface.Size = New System.Drawing.Size(121, 20)
        Me.tbxOutputSurface.TabIndex = 8
        '
        'lblOutputSurface
        '
        Me.lblOutputSurface.AutoSize = True
        Me.lblOutputSurface.Location = New System.Drawing.Point(6, 22)
        Me.lblOutputSurface.Name = "lblOutputSurface"
        Me.lblOutputSurface.Size = New System.Drawing.Size(68, 13)
        Me.lblOutputSurface.TabIndex = 0
        Me.lblOutputSurface.Text = "Oppervlakte:"
        '
        'tbxOutputColor
        '
        Me.tbxOutputColor.Location = New System.Drawing.Point(93, 45)
        Me.tbxOutputColor.Name = "tbxOutputColor"
        Me.tbxOutputColor.Size = New System.Drawing.Size(121, 20)
        Me.tbxOutputColor.TabIndex = 10
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(6, 74)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(29, 13)
        Me.lblPrice.TabIndex = 11
        Me.lblPrice.Text = "Prijs:"
        '
        'tbxOutputPrice
        '
        Me.tbxOutputPrice.Location = New System.Drawing.Point(93, 71)
        Me.tbxOutputPrice.Name = "tbxOutputPrice"
        Me.tbxOutputPrice.Size = New System.Drawing.Size(121, 20)
        Me.tbxOutputPrice.TabIndex = 12
        '
        'tbxOutputDiscount
        '
        Me.tbxOutputDiscount.Location = New System.Drawing.Point(93, 97)
        Me.tbxOutputDiscount.Name = "tbxOutputDiscount"
        Me.tbxOutputDiscount.Size = New System.Drawing.Size(121, 20)
        Me.tbxOutputDiscount.TabIndex = 13
        '
        'lblOutputDiscount
        '
        Me.lblOutputDiscount.AutoSize = True
        Me.lblOutputDiscount.Location = New System.Drawing.Point(6, 100)
        Me.lblOutputDiscount.Name = "lblOutputDiscount"
        Me.lblOutputDiscount.Size = New System.Drawing.Size(43, 13)
        Me.lblOutputDiscount.TabIndex = 14
        Me.lblOutputDiscount.Text = "Korting:"
        '
        'tbxOutputTotalPrice
        '
        Me.tbxOutputTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxOutputTotalPrice.Location = New System.Drawing.Point(93, 144)
        Me.tbxOutputTotalPrice.Name = "tbxOutputTotalPrice"
        Me.tbxOutputTotalPrice.Size = New System.Drawing.Size(121, 20)
        Me.tbxOutputTotalPrice.TabIndex = 15
        '
        'lblOutputTotalPrice
        '
        Me.lblOutputTotalPrice.AutoSize = True
        Me.lblOutputTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutputTotalPrice.Location = New System.Drawing.Point(6, 147)
        Me.lblOutputTotalPrice.Name = "lblOutputTotalPrice"
        Me.lblOutputTotalPrice.Size = New System.Drawing.Size(70, 13)
        Me.lblOutputTotalPrice.TabIndex = 16
        Me.lblOutputTotalPrice.Text = "Totaalprijs:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 305)
        Me.Controls.Add(Me.gbxOutput)
        Me.Controls.Add(Me.gbxInput)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Kunstgras"
        Me.gbxInput.ResumeLayout(False)
        Me.gbxInput.PerformLayout()
        Me.gbxOutput.ResumeLayout(False)
        Me.gbxOutput.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxInput As GroupBox
    Friend WithEvents cbxInputColor As ComboBox
    Friend WithEvents lblInputColor As Label
    Friend WithEvents lblInputMeters2 As Label
    Friend WithEvents lblInputMeters1 As Label
    Friend WithEvents tbxInputWidth As TextBox
    Friend WithEvents tbxInputLength As TextBox
    Friend WithEvents lblInputWidth As Label
    Friend WithEvents lblInputLength As Label
    Friend WithEvents gbxOutput As GroupBox
    Friend WithEvents lblOutputColor As Label
    Friend WithEvents lblOutputSquareMeters As Label
    Friend WithEvents tbxOutputSurface As TextBox
    Friend WithEvents lblOutputSurface As Label
    Friend WithEvents tbxOutputColor As TextBox
    Friend WithEvents tbxOutputPrice As TextBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblOutputDiscount As Label
    Friend WithEvents tbxOutputDiscount As TextBox
    Friend WithEvents lblOutputTotalPrice As Label
    Friend WithEvents tbxOutputTotalPrice As TextBox
End Class
