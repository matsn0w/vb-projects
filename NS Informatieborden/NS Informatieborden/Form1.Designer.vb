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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpLeavetime = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxTrain = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbxDestination = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbxVia = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.dtpDelay = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vertrektijd:"
        '
        'dtpLeavetime
        '
        Me.dtpLeavetime.CustomFormat = "HH:mm"
        Me.dtpLeavetime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpLeavetime.Location = New System.Drawing.Point(132, 12)
        Me.dtpLeavetime.Name = "dtpLeavetime"
        Me.dtpLeavetime.ShowUpDown = True
        Me.dtpLeavetime.Size = New System.Drawing.Size(140, 20)
        Me.dtpLeavetime.TabIndex = 2
        Me.dtpLeavetime.Value = New Date(2017, 11, 23, 12, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Treinsoort:"
        '
        'cbxTrain
        '
        Me.cbxTrain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTrain.FormattingEnabled = True
        Me.cbxTrain.Items.AddRange(New Object() {"Intercity", "Sprinter", "ICE"})
        Me.cbxTrain.Location = New System.Drawing.Point(132, 38)
        Me.cbxTrain.Name = "cbxTrain"
        Me.cbxTrain.Size = New System.Drawing.Size(140, 21)
        Me.cbxTrain.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Bestemming:"
        '
        'tbxDestination
        '
        Me.tbxDestination.Location = New System.Drawing.Point(132, 65)
        Me.tbxDestination.Name = "tbxDestination"
        Me.tbxDestination.Size = New System.Drawing.Size(140, 20)
        Me.tbxDestination.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Via:"
        '
        'tbxVia
        '
        Me.tbxVia.Location = New System.Drawing.Point(132, 91)
        Me.tbxVia.Name = "tbxVia"
        Me.tbxVia.Size = New System.Drawing.Size(140, 20)
        Me.tbxVia.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Vertraging:"
        '
        'btnSubmit
        '
        Me.btnSubmit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSubmit.Location = New System.Drawing.Point(197, 145)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 11
        Me.btnSubmit.Text = "&Verzend"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'dtpDelay
        '
        Me.dtpDelay.CustomFormat = "mm"
        Me.dtpDelay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDelay.Location = New System.Drawing.Point(132, 117)
        Me.dtpDelay.Name = "dtpDelay"
        Me.dtpDelay.ShowUpDown = True
        Me.dtpDelay.Size = New System.Drawing.Size(140, 20)
        Me.dtpDelay.TabIndex = 13
        Me.dtpDelay.Value = New Date(2017, 11, 23, 12, 0, 0, 0)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 180)
        Me.Controls.Add(Me.dtpDelay)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbxVia)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbxDestination)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbxTrain)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpLeavetime)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(10, 10)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "NS Informatiebord"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dtpLeavetime As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents cbxTrain As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbxDestination As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbxVia As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents dtpDelay As DateTimePicker
End Class
