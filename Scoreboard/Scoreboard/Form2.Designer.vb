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
        Me.lblGoal = New System.Windows.Forms.Label()
        Me.lblGoalTeam = New System.Windows.Forms.Label()
        Me.lblTip = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblGoal
        '
        Me.lblGoal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblGoal.BackColor = System.Drawing.Color.Transparent
        Me.lblGoal.Font = New System.Drawing.Font("Microsoft Sans Serif", 150.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGoal.ForeColor = System.Drawing.Color.White
        Me.lblGoal.Location = New System.Drawing.Point(0, 0)
        Me.lblGoal.Name = "lblGoal"
        Me.lblGoal.Size = New System.Drawing.Size(1280, 360)
        Me.lblGoal.TabIndex = 0
        Me.lblGoal.Text = "GOAL!!!"
        Me.lblGoal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGoalTeam
        '
        Me.lblGoalTeam.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblGoalTeam.BackColor = System.Drawing.Color.Transparent
        Me.lblGoalTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGoalTeam.ForeColor = System.Drawing.Color.White
        Me.lblGoalTeam.Location = New System.Drawing.Point(0, 360)
        Me.lblGoalTeam.Name = "lblGoalTeam"
        Me.lblGoalTeam.Size = New System.Drawing.Size(1280, 360)
        Me.lblGoalTeam.TabIndex = 1
        Me.lblGoalTeam.Text = "DUMMY"
        Me.lblGoalTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTip
        '
        Me.lblTip.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTip.BackColor = System.Drawing.Color.Transparent
        Me.lblTip.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTip.ForeColor = System.Drawing.Color.White
        Me.lblTip.Location = New System.Drawing.Point(0, 600)
        Me.lblTip.Name = "lblTip"
        Me.lblTip.Size = New System.Drawing.Size(1280, 30)
        Me.lblTip.TabIndex = 2
        Me.lblTip.Text = "Press any key to continue..."
        Me.lblTip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.lblTip)
        Me.Controls.Add(Me.lblGoalTeam)
        Me.Controls.Add(Me.lblGoal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.ShowInTaskbar = False
        Me.Text = "Goal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblGoal As Label
    Friend WithEvents lblGoalTeam As Label
    Friend WithEvents lblTip As Label
End Class
