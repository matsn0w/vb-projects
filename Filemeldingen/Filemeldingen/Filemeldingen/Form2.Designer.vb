<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbxNotifications = New System.Windows.Forms.ListBox()
        Me.lblNoJams = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(171, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Actuele meldingen"
        '
        'lbxNotifications
        '
        Me.lbxNotifications.FormattingEnabled = True
        Me.lbxNotifications.Location = New System.Drawing.Point(13, 41)
        Me.lbxNotifications.Name = "lbxNotifications"
        Me.lbxNotifications.Size = New System.Drawing.Size(495, 212)
        Me.lbxNotifications.TabIndex = 1
        '
        'lblNoJams
        '
        Me.lblNoJams.AutoSize = True
        Me.lblNoJams.BackColor = System.Drawing.Color.White
        Me.lblNoJams.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoJams.ForeColor = System.Drawing.Color.Silver
        Me.lblNoJams.Location = New System.Drawing.Point(208, 135)
        Me.lblNoJams.Name = "lblNoJams"
        Me.lblNoJams.Size = New System.Drawing.Size(104, 25)
        Me.lblNoJams.TabIndex = 2
        Me.lblNoJams.Text = "Geen files!"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 262)
        Me.Controls.Add(Me.lblNoJams)
        Me.Controls.Add(Me.lbxNotifications)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.Text = "Actuele meldingen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbxNotifications As ListBox
    Friend WithEvents lblNoJams As Label
End Class
