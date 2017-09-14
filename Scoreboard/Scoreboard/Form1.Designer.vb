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
        Me.components = New System.ComponentModel.Container()
        Me.lblScoreHome = New System.Windows.Forms.Label()
        Me.NUDScoreHome = New System.Windows.Forms.NumericUpDown()
        Me.lblScoreGuests = New System.Windows.Forms.Label()
        Me.NUDScoreGuests = New System.Windows.Forms.NumericUpDown()
        Me.lblHome = New System.Windows.Forms.Label()
        Me.lblGuests = New System.Windows.Forms.Label()
        Me.lblDash = New System.Windows.Forms.Label()
        Me.lblClockMinutes = New System.Windows.Forms.Label()
        Me.lblClockSeconds = New System.Windows.Forms.Label()
        Me.lblClockSeparator = New System.Windows.Forms.Label()
        Me.btnClockStart = New System.Windows.Forms.Button()
        Me.btnClockStop = New System.Windows.Forms.Button()
        Me.btnClockReset = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.NUDScoreHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUDScoreGuests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblScoreHome
        '
        Me.lblScoreHome.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblScoreHome.AutoSize = True
        Me.lblScoreHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 99.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreHome.ForeColor = System.Drawing.Color.White
        Me.lblScoreHome.Location = New System.Drawing.Point(-4, 55)
        Me.lblScoreHome.Name = "lblScoreHome"
        Me.lblScoreHome.Size = New System.Drawing.Size(215, 152)
        Me.lblScoreHome.TabIndex = 0
        Me.lblScoreHome.Text = "00"
        '
        'NUDScoreHome
        '
        Me.NUDScoreHome.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NUDScoreHome.Location = New System.Drawing.Point(12, 281)
        Me.NUDScoreHome.Name = "NUDScoreHome"
        Me.NUDScoreHome.Size = New System.Drawing.Size(113, 20)
        Me.NUDScoreHome.TabIndex = 1
        '
        'lblScoreGuests
        '
        Me.lblScoreGuests.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblScoreGuests.AutoSize = True
        Me.lblScoreGuests.Font = New System.Drawing.Font("Microsoft Sans Serif", 99.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreGuests.ForeColor = System.Drawing.Color.White
        Me.lblScoreGuests.Location = New System.Drawing.Point(301, 55)
        Me.lblScoreGuests.Name = "lblScoreGuests"
        Me.lblScoreGuests.Size = New System.Drawing.Size(215, 152)
        Me.lblScoreGuests.TabIndex = 2
        Me.lblScoreGuests.Text = "00"
        '
        'NUDScoreGuests
        '
        Me.NUDScoreGuests.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NUDScoreGuests.Location = New System.Drawing.Point(374, 281)
        Me.NUDScoreGuests.Name = "NUDScoreGuests"
        Me.NUDScoreGuests.Size = New System.Drawing.Size(116, 20)
        Me.NUDScoreGuests.TabIndex = 3
        '
        'lblHome
        '
        Me.lblHome.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHome.AutoSize = True
        Me.lblHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHome.ForeColor = System.Drawing.Color.White
        Me.lblHome.Location = New System.Drawing.Point(12, 9)
        Me.lblHome.Name = "lblHome"
        Me.lblHome.Size = New System.Drawing.Size(157, 55)
        Me.lblHome.TabIndex = 4
        Me.lblHome.Text = "Home"
        '
        'lblGuests
        '
        Me.lblGuests.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGuests.AutoSize = True
        Me.lblGuests.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuests.ForeColor = System.Drawing.Color.White
        Me.lblGuests.Location = New System.Drawing.Point(308, 9)
        Me.lblGuests.Name = "lblGuests"
        Me.lblGuests.Size = New System.Drawing.Size(182, 55)
        Me.lblGuests.TabIndex = 5
        Me.lblGuests.Text = "Guests"
        '
        'lblDash
        '
        Me.lblDash.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDash.AutoSize = True
        Me.lblDash.Font = New System.Drawing.Font("Microsoft Sans Serif", 99.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDash.ForeColor = System.Drawing.Color.White
        Me.lblDash.Location = New System.Drawing.Point(202, 55)
        Me.lblDash.Name = "lblDash"
        Me.lblDash.Size = New System.Drawing.Size(110, 152)
        Me.lblDash.TabIndex = 6
        Me.lblDash.Text = "-"
        Me.lblDash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblClockMinutes
        '
        Me.lblClockMinutes.AutoSize = True
        Me.lblClockMinutes.BackColor = System.Drawing.Color.Transparent
        Me.lblClockMinutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClockMinutes.ForeColor = System.Drawing.Color.White
        Me.lblClockMinutes.Location = New System.Drawing.Point(188, 207)
        Me.lblClockMinutes.Name = "lblClockMinutes"
        Me.lblClockMinutes.Size = New System.Drawing.Size(55, 37)
        Me.lblClockMinutes.TabIndex = 7
        Me.lblClockMinutes.Text = "00"
        '
        'lblClockSeconds
        '
        Me.lblClockSeconds.AutoSize = True
        Me.lblClockSeconds.BackColor = System.Drawing.Color.Transparent
        Me.lblClockSeconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClockSeconds.ForeColor = System.Drawing.Color.White
        Me.lblClockSeconds.Location = New System.Drawing.Point(257, 207)
        Me.lblClockSeconds.Name = "lblClockSeconds"
        Me.lblClockSeconds.Size = New System.Drawing.Size(55, 37)
        Me.lblClockSeconds.TabIndex = 8
        Me.lblClockSeconds.Text = "00"
        '
        'lblClockSeparator
        '
        Me.lblClockSeparator.AutoSize = True
        Me.lblClockSeparator.BackColor = System.Drawing.Color.Transparent
        Me.lblClockSeparator.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClockSeparator.ForeColor = System.Drawing.Color.White
        Me.lblClockSeparator.Location = New System.Drawing.Point(237, 207)
        Me.lblClockSeparator.Name = "lblClockSeparator"
        Me.lblClockSeparator.Size = New System.Drawing.Size(27, 37)
        Me.lblClockSeparator.TabIndex = 9
        Me.lblClockSeparator.Text = ":"
        '
        'btnClockStart
        '
        Me.btnClockStart.Location = New System.Drawing.Point(131, 281)
        Me.btnClockStart.Name = "btnClockStart"
        Me.btnClockStart.Size = New System.Drawing.Size(75, 23)
        Me.btnClockStart.TabIndex = 10
        Me.btnClockStart.Text = "Start"
        Me.btnClockStart.UseVisualStyleBackColor = True
        '
        'btnClockStop
        '
        Me.btnClockStop.Location = New System.Drawing.Point(212, 281)
        Me.btnClockStop.Name = "btnClockStop"
        Me.btnClockStop.Size = New System.Drawing.Size(75, 23)
        Me.btnClockStop.TabIndex = 11
        Me.btnClockStop.Text = "Stop"
        Me.btnClockStop.UseVisualStyleBackColor = True
        '
        'btnClockReset
        '
        Me.btnClockReset.Location = New System.Drawing.Point(293, 281)
        Me.btnClockReset.Name = "btnClockReset"
        Me.btnClockReset.Size = New System.Drawing.Size(75, 23)
        Me.btnClockReset.TabIndex = 12
        Me.btnClockReset.Text = "Reset"
        Me.btnClockReset.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(502, 316)
        Me.Controls.Add(Me.btnClockReset)
        Me.Controls.Add(Me.btnClockStop)
        Me.Controls.Add(Me.btnClockStart)
        Me.Controls.Add(Me.lblClockSeparator)
        Me.Controls.Add(Me.lblClockSeconds)
        Me.Controls.Add(Me.lblClockMinutes)
        Me.Controls.Add(Me.lblDash)
        Me.Controls.Add(Me.lblGuests)
        Me.Controls.Add(Me.lblHome)
        Me.Controls.Add(Me.NUDScoreGuests)
        Me.Controls.Add(Me.lblScoreGuests)
        Me.Controls.Add(Me.NUDScoreHome)
        Me.Controls.Add(Me.lblScoreHome)
        Me.Name = "Form1"
        Me.Text = "Scoreboard"
        CType(Me.NUDScoreHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUDScoreGuests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblScoreHome As Label
    Friend WithEvents NUDScoreHome As NumericUpDown
    Friend WithEvents lblScoreGuests As Label
    Friend WithEvents NUDScoreGuests As NumericUpDown
    Friend WithEvents lblHome As Label
    Friend WithEvents lblGuests As Label
    Friend WithEvents lblDash As Label
    Friend WithEvents lblClockMinutes As Label
    Friend WithEvents lblClockSeconds As Label
    Friend WithEvents lblClockSeparator As Label
    Friend WithEvents btnClockStart As Button
    Friend WithEvents btnClockStop As Button
    Friend WithEvents btnClockReset As Button
    Friend WithEvents Timer1 As Timer
End Class
