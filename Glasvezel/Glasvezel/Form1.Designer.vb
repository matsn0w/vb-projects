﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbxLS = New System.Windows.Forms.TextBox()
        Me.tbxAH = New System.Windows.Forms.TextBox()
        Me.tbxAVS = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbxTP = New System.Windows.Forms.TextBox()
        Me.tbxK = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbxP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbxTLG = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lengte straat (m):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Aantal aftakkingen:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Afstand tot verdeelstation (m):"
        '
        'tbxLS
        '
        Me.tbxLS.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxLS.Location = New System.Drawing.Point(187, 17)
        Me.tbxLS.Name = "tbxLS"
        Me.tbxLS.Size = New System.Drawing.Size(135, 20)
        Me.tbxLS.TabIndex = 1
        '
        'tbxAH
        '
        Me.tbxAH.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxAH.Location = New System.Drawing.Point(187, 44)
        Me.tbxAH.Name = "tbxAH"
        Me.tbxAH.Size = New System.Drawing.Size(135, 20)
        Me.tbxAH.TabIndex = 2
        '
        'tbxAVS
        '
        Me.tbxAVS.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxAVS.Location = New System.Drawing.Point(187, 71)
        Me.tbxAVS.Name = "tbxAVS"
        Me.tbxAVS.Size = New System.Drawing.Size(135, 20)
        Me.tbxAVS.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCalc)
        Me.GroupBox1.Controls.Add(Me.tbxLS)
        Me.GroupBox1.Controls.Add(Me.tbxAVS)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbxAH)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 125)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Invoer"
        '
        'btnCalc
        '
        Me.btnCalc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCalc.Location = New System.Drawing.Point(247, 98)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 4
        Me.btnCalc.Text = "Bereken"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.tbxTP)
        Me.GroupBox2.Controls.Add(Me.tbxK)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.tbxP)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.tbxTLG)
        Me.GroupBox2.Location = New System.Drawing.Point(347, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(267, 125)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Uitvoer"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Totaalprijs"
        '
        'tbxTP
        '
        Me.tbxTP.Location = New System.Drawing.Point(131, 95)
        Me.tbxTP.Name = "tbxTP"
        Me.tbxTP.ReadOnly = True
        Me.tbxTP.Size = New System.Drawing.Size(125, 20)
        Me.tbxTP.TabIndex = 10
        Me.tbxTP.TabStop = False
        Me.tbxTP.Text = "€ 0,00"
        Me.tbxTP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbxK
        '
        Me.tbxK.Location = New System.Drawing.Point(131, 69)
        Me.tbxK.Name = "tbxK"
        Me.tbxK.ReadOnly = True
        Me.tbxK.Size = New System.Drawing.Size(125, 20)
        Me.tbxK.TabIndex = 9
        Me.tbxK.TabStop = False
        Me.tbxK.Text = "0%"
        Me.tbxK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Korting"
        '
        'tbxP
        '
        Me.tbxP.Location = New System.Drawing.Point(131, 43)
        Me.tbxP.Name = "tbxP"
        Me.tbxP.ReadOnly = True
        Me.tbxP.Size = New System.Drawing.Size(125, 20)
        Me.tbxP.TabIndex = 7
        Me.tbxP.TabStop = False
        Me.tbxP.Text = "€ 0,00"
        Me.tbxP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Prijs"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Totale lengte glasvezel:"
        '
        'tbxTLG
        '
        Me.tbxTLG.Location = New System.Drawing.Point(131, 17)
        Me.tbxTLG.Name = "tbxTLG"
        Me.tbxTLG.ReadOnly = True
        Me.tbxTLG.Size = New System.Drawing.Size(125, 20)
        Me.tbxTLG.TabIndex = 0
        Me.tbxTLG.TabStop = False
        Me.tbxTLG.Text = "0 m"
        Me.tbxTLG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 150)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Glasvezel"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbxLS As TextBox
    Friend WithEvents tbxAH As TextBox
    Friend WithEvents tbxAVS As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents tbxTP As TextBox
    Friend WithEvents tbxK As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbxP As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbxTLG As TextBox
End Class
