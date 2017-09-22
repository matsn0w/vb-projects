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
        Me.gbGender = New System.Windows.Forms.GroupBox()
        Me.rbnWomen = New System.Windows.Forms.RadioButton()
        Me.rbnMen = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbnAngry = New System.Windows.Forms.RadioButton()
        Me.rbnSad = New System.Windows.Forms.RadioButton()
        Me.rbnHappy = New System.Windows.Forms.RadioButton()
        Me.rbnDepri = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbnEating = New System.Windows.Forms.RadioButton()
        Me.rbnSleeping = New System.Windows.Forms.RadioButton()
        Me.rbnGaming = New System.Windows.Forms.RadioButton()
        Me.rbnFootball = New System.Windows.Forms.RadioButton()
        Me.btnTransmit = New System.Windows.Forms.Button()
        Me.tbxResult = New System.Windows.Forms.TextBox()
        Me.cbxShowVideo = New System.Windows.Forms.CheckBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.gbGender.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbGender
        '
        Me.gbGender.Controls.Add(Me.rbnWomen)
        Me.gbGender.Controls.Add(Me.rbnMen)
        Me.gbGender.Location = New System.Drawing.Point(10, 10)
        Me.gbGender.Name = "gbGender"
        Me.gbGender.Size = New System.Drawing.Size(159, 116)
        Me.gbGender.TabIndex = 0
        Me.gbGender.TabStop = False
        Me.gbGender.Text = "Geslacht"
        '
        'rbnWomen
        '
        Me.rbnWomen.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rbnWomen.AutoSize = True
        Me.rbnWomen.Location = New System.Drawing.Point(7, 44)
        Me.rbnWomen.Name = "rbnWomen"
        Me.rbnWomen.Size = New System.Drawing.Size(55, 17)
        Me.rbnWomen.TabIndex = 1
        Me.rbnWomen.TabStop = True
        Me.rbnWomen.Text = "Vrouw"
        Me.rbnWomen.UseVisualStyleBackColor = True
        '
        'rbnMen
        '
        Me.rbnMen.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rbnMen.AutoSize = True
        Me.rbnMen.Location = New System.Drawing.Point(7, 20)
        Me.rbnMen.Name = "rbnMen"
        Me.rbnMen.Size = New System.Drawing.Size(46, 17)
        Me.rbnMen.TabIndex = 0
        Me.rbnMen.TabStop = True
        Me.rbnMen.Text = "Man"
        Me.rbnMen.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbnAngry)
        Me.GroupBox1.Controls.Add(Me.rbnSad)
        Me.GroupBox1.Controls.Add(Me.rbnHappy)
        Me.GroupBox1.Controls.Add(Me.rbnDepri)
        Me.GroupBox1.Location = New System.Drawing.Point(175, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(159, 116)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Emotie"
        '
        'rbnAngry
        '
        Me.rbnAngry.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rbnAngry.AutoSize = True
        Me.rbnAngry.Location = New System.Drawing.Point(7, 90)
        Me.rbnAngry.Name = "rbnAngry"
        Me.rbnAngry.Size = New System.Drawing.Size(49, 17)
        Me.rbnAngry.TabIndex = 3
        Me.rbnAngry.TabStop = True
        Me.rbnAngry.Text = "Boos"
        Me.rbnAngry.UseVisualStyleBackColor = True
        '
        'rbnSad
        '
        Me.rbnSad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rbnSad.AutoSize = True
        Me.rbnSad.Location = New System.Drawing.Point(7, 67)
        Me.rbnSad.Name = "rbnSad"
        Me.rbnSad.Size = New System.Drawing.Size(69, 17)
        Me.rbnSad.TabIndex = 2
        Me.rbnSad.TabStop = True
        Me.rbnSad.Text = "Verdrietig"
        Me.rbnSad.UseVisualStyleBackColor = True
        '
        'rbnHappy
        '
        Me.rbnHappy.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rbnHappy.AutoSize = True
        Me.rbnHappy.Location = New System.Drawing.Point(7, 44)
        Me.rbnHappy.Name = "rbnHappy"
        Me.rbnHappy.Size = New System.Drawing.Size(38, 17)
        Me.rbnHappy.TabIndex = 1
        Me.rbnHappy.TabStop = True
        Me.rbnHappy.Text = "Blij"
        Me.rbnHappy.UseVisualStyleBackColor = True
        '
        'rbnDepri
        '
        Me.rbnDepri.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rbnDepri.AutoSize = True
        Me.rbnDepri.Location = New System.Drawing.Point(7, 20)
        Me.rbnDepri.Name = "rbnDepri"
        Me.rbnDepri.Size = New System.Drawing.Size(50, 17)
        Me.rbnDepri.TabIndex = 0
        Me.rbnDepri.TabStop = True
        Me.rbnDepri.Text = "Depri"
        Me.rbnDepri.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbnEating)
        Me.GroupBox2.Controls.Add(Me.rbnSleeping)
        Me.GroupBox2.Controls.Add(Me.rbnGaming)
        Me.GroupBox2.Controls.Add(Me.rbnFootball)
        Me.GroupBox2.Location = New System.Drawing.Point(340, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(159, 116)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Hobby's"
        '
        'rbnEating
        '
        Me.rbnEating.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rbnEating.AutoSize = True
        Me.rbnEating.Location = New System.Drawing.Point(7, 90)
        Me.rbnEating.Name = "rbnEating"
        Me.rbnEating.Size = New System.Drawing.Size(47, 17)
        Me.rbnEating.TabIndex = 3
        Me.rbnEating.TabStop = True
        Me.rbnEating.Text = "Eten"
        Me.rbnEating.UseVisualStyleBackColor = True
        '
        'rbnSleeping
        '
        Me.rbnSleeping.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rbnSleeping.AutoSize = True
        Me.rbnSleeping.Location = New System.Drawing.Point(7, 67)
        Me.rbnSleeping.Name = "rbnSleeping"
        Me.rbnSleeping.Size = New System.Drawing.Size(58, 17)
        Me.rbnSleeping.TabIndex = 2
        Me.rbnSleeping.TabStop = True
        Me.rbnSleeping.Text = "Slapen"
        Me.rbnSleeping.UseVisualStyleBackColor = True
        '
        'rbnGaming
        '
        Me.rbnGaming.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rbnGaming.AutoSize = True
        Me.rbnGaming.Location = New System.Drawing.Point(7, 44)
        Me.rbnGaming.Name = "rbnGaming"
        Me.rbnGaming.Size = New System.Drawing.Size(59, 17)
        Me.rbnGaming.TabIndex = 1
        Me.rbnGaming.TabStop = True
        Me.rbnGaming.Text = "Gamen"
        Me.rbnGaming.UseVisualStyleBackColor = True
        '
        'rbnFootball
        '
        Me.rbnFootball.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rbnFootball.AutoSize = True
        Me.rbnFootball.Location = New System.Drawing.Point(7, 20)
        Me.rbnFootball.Name = "rbnFootball"
        Me.rbnFootball.Size = New System.Drawing.Size(61, 17)
        Me.rbnFootball.TabIndex = 0
        Me.rbnFootball.TabStop = True
        Me.rbnFootball.Text = "Voetbal"
        Me.rbnFootball.UseVisualStyleBackColor = True
        '
        'btnTransmit
        '
        Me.btnTransmit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTransmit.Location = New System.Drawing.Point(11, 133)
        Me.btnTransmit.Name = "btnTransmit"
        Me.btnTransmit.Size = New System.Drawing.Size(488, 23)
        Me.btnTransmit.TabIndex = 4
        Me.btnTransmit.Text = "Verwerk data"
        Me.btnTransmit.UseVisualStyleBackColor = True
        '
        'tbxResult
        '
        Me.tbxResult.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxResult.Location = New System.Drawing.Point(11, 163)
        Me.tbxResult.Name = "tbxResult"
        Me.tbxResult.ReadOnly = True
        Me.tbxResult.Size = New System.Drawing.Size(488, 24)
        Me.tbxResult.TabIndex = 5
        Me.tbxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbxShowVideo
        '
        Me.cbxShowVideo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbxShowVideo.AutoSize = True
        Me.cbxShowVideo.Location = New System.Drawing.Point(417, 193)
        Me.cbxShowVideo.Name = "cbxShowVideo"
        Me.cbxShowVideo.Size = New System.Drawing.Size(80, 17)
        Me.cbxShowVideo.TabIndex = 7
        Me.cbxShowVideo.Text = "Toon video"
        Me.cbxShowVideo.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.Location = New System.Drawing.Point(12, 217)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScrollBarsEnabled = False
        Me.WebBrowser1.Size = New System.Drawing.Size(486, 344)
        Me.WebBrowser1.TabIndex = 8
        Me.WebBrowser1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 573)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.cbxShowVideo)
        Me.Controls.Add(Me.tbxResult)
        Me.Controls.Add(Me.btnTransmit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbGender)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Wie ben ik?"
        Me.gbGender.ResumeLayout(False)
        Me.gbGender.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbGender As GroupBox
    Friend WithEvents rbnWomen As RadioButton
    Friend WithEvents rbnMen As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbnHappy As RadioButton
    Friend WithEvents rbnDepri As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbnGaming As RadioButton
    Friend WithEvents rbnFootball As RadioButton
    Friend WithEvents rbnAngry As RadioButton
    Friend WithEvents rbnSad As RadioButton
    Friend WithEvents rbnEating As RadioButton
    Friend WithEvents rbnSleeping As RadioButton
    Friend WithEvents btnTransmit As Button
    Friend WithEvents tbxResult As TextBox
    Friend WithEvents cbxShowVideo As CheckBox
    Friend WithEvents WebBrowser1 As WebBrowser
End Class
