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
        Me.VSRed = New System.Windows.Forms.VScrollBar()
        Me.VSBlue = New System.Windows.Forms.VScrollBar()
        Me.VSGreen = New System.Windows.Forms.VScrollBar()
        Me.Process1 = New System.Diagnostics.Process()
        Me.SHRed = New System.Windows.Forms.Label()
        Me.SHGreen = New System.Windows.Forms.Label()
        Me.SHBlue = New System.Windows.Forms.Label()
        Me.SHColor = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'VSRed
        '
        Me.VSRed.Location = New System.Drawing.Point(4, 9)
        Me.VSRed.Maximum = 264
        Me.VSRed.Name = "VSRed"
        Me.VSRed.Size = New System.Drawing.Size(90, 213)
        Me.VSRed.TabIndex = 0
        '
        'VSBlue
        '
        Me.VSBlue.Location = New System.Drawing.Point(186, 9)
        Me.VSBlue.Maximum = 264
        Me.VSBlue.Name = "VSBlue"
        Me.VSBlue.Size = New System.Drawing.Size(91, 213)
        Me.VSBlue.TabIndex = 1
        '
        'VSGreen
        '
        Me.VSGreen.Location = New System.Drawing.Point(94, 9)
        Me.VSGreen.Maximum = 264
        Me.VSGreen.Name = "VSGreen"
        Me.VSGreen.Size = New System.Drawing.Size(90, 213)
        Me.VSGreen.TabIndex = 2
        '
        'Process1
        '
        Me.Process1.StartInfo.Domain = ""
        Me.Process1.StartInfo.LoadUserProfile = False
        Me.Process1.StartInfo.Password = Nothing
        Me.Process1.StartInfo.StandardErrorEncoding = Nothing
        Me.Process1.StartInfo.StandardOutputEncoding = Nothing
        Me.Process1.StartInfo.UserName = ""
        Me.Process1.SynchronizingObject = Me
        '
        'SHRed
        '
        Me.SHRed.BackColor = System.Drawing.Color.Red
        Me.SHRed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SHRed.ForeColor = System.Drawing.Color.White
        Me.SHRed.Location = New System.Drawing.Point(4, 222)
        Me.SHRed.Name = "SHRed"
        Me.SHRed.Size = New System.Drawing.Size(90, 27)
        Me.SHRed.TabIndex = 3
        Me.SHRed.Text = "RED"
        Me.SHRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SHGreen
        '
        Me.SHGreen.BackColor = System.Drawing.Color.Lime
        Me.SHGreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SHGreen.ForeColor = System.Drawing.Color.White
        Me.SHGreen.Location = New System.Drawing.Point(94, 222)
        Me.SHGreen.Name = "SHGreen"
        Me.SHGreen.Size = New System.Drawing.Size(90, 27)
        Me.SHGreen.TabIndex = 4
        Me.SHGreen.Text = "GREEN"
        Me.SHGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SHBlue
        '
        Me.SHBlue.BackColor = System.Drawing.Color.Blue
        Me.SHBlue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SHBlue.ForeColor = System.Drawing.Color.White
        Me.SHBlue.Location = New System.Drawing.Point(183, 222)
        Me.SHBlue.Name = "SHBlue"
        Me.SHBlue.Size = New System.Drawing.Size(90, 27)
        Me.SHBlue.TabIndex = 5
        Me.SHBlue.Text = "BLUE"
        Me.SHBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SHColor
        '
        Me.SHColor.BackColor = System.Drawing.Color.Yellow
        Me.SHColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SHColor.ForeColor = System.Drawing.Color.Black
        Me.SHColor.Location = New System.Drawing.Point(4, 260)
        Me.SHColor.Name = "SHColor"
        Me.SHColor.Size = New System.Drawing.Size(269, 95)
        Me.SHColor.TabIndex = 6
        Me.SHColor.Text = "COLOR"
        Me.SHColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 364)
        Me.Controls.Add(Me.SHBlue)
        Me.Controls.Add(Me.SHGreen)
        Me.Controls.Add(Me.SHRed)
        Me.Controls.Add(Me.VSGreen)
        Me.Controls.Add(Me.VSBlue)
        Me.Controls.Add(Me.VSRed)
        Me.Controls.Add(Me.SHColor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "RGB Kleurenmenger"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents VSRed As VScrollBar
    Friend WithEvents VSBlue As VScrollBar
    Friend WithEvents VSGreen As VScrollBar
    Friend WithEvents Process1 As Process
    Friend WithEvents SHColor As Label
    Friend WithEvents SHBlue As Label
    Friend WithEvents SHGreen As Label
    Friend WithEvents SHRed As Label
End Class
