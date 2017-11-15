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
        Me.gbxBurger = New System.Windows.Forms.GroupBox()
        Me.cbxBurgersBigTastyBacon = New System.Windows.Forms.CheckBox()
        Me.cbxBurgersMcChicken = New System.Windows.Forms.CheckBox()
        Me.cbxBurgersBigMac = New System.Windows.Forms.CheckBox()
        Me.gbxFriet = New System.Windows.Forms.GroupBox()
        Me.rbtnFritesLarge = New System.Windows.Forms.RadioButton()
        Me.rbtnFritesMedium = New System.Windows.Forms.RadioButton()
        Me.gbxDrinks = New System.Windows.Forms.GroupBox()
        Me.rbtnDrinksSprite = New System.Windows.Forms.RadioButton()
        Me.rbtnDrinksFanta = New System.Windows.Forms.RadioButton()
        Me.rbtnDrinksCoke = New System.Windows.Forms.RadioButton()
        Me.cbxDrinksLarge = New System.Windows.Forms.CheckBox()
        Me.cbxDrinksMedium = New System.Windows.Forms.CheckBox()
        Me.cbxDrinksSmall = New System.Windows.Forms.CheckBox()
        Me.gbxResult = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblResultBurgers = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.gbxBurger.SuspendLayout()
        Me.gbxFriet.SuspendLayout()
        Me.gbxDrinks.SuspendLayout()
        Me.gbxResult.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxBurger
        '
        Me.gbxBurger.Controls.Add(Me.cbxBurgersBigTastyBacon)
        Me.gbxBurger.Controls.Add(Me.cbxBurgersMcChicken)
        Me.gbxBurger.Controls.Add(Me.cbxBurgersBigMac)
        Me.gbxBurger.Location = New System.Drawing.Point(12, 12)
        Me.gbxBurger.Name = "gbxBurger"
        Me.gbxBurger.Size = New System.Drawing.Size(225, 91)
        Me.gbxBurger.TabIndex = 0
        Me.gbxBurger.TabStop = False
        Me.gbxBurger.Text = "Burger"
        '
        'cbxBurgersBigTastyBacon
        '
        Me.cbxBurgersBigTastyBacon.AutoSize = True
        Me.cbxBurgersBigTastyBacon.Location = New System.Drawing.Point(7, 66)
        Me.cbxBurgersBigTastyBacon.Name = "cbxBurgersBigTastyBacon"
        Me.cbxBurgersBigTastyBacon.Size = New System.Drawing.Size(124, 17)
        Me.cbxBurgersBigTastyBacon.TabIndex = 2
        Me.cbxBurgersBigTastyBacon.Text = "Big Tasty met Bacon"
        Me.cbxBurgersBigTastyBacon.UseVisualStyleBackColor = True
        '
        'cbxBurgersMcChicken
        '
        Me.cbxBurgersMcChicken.AutoSize = True
        Me.cbxBurgersMcChicken.Location = New System.Drawing.Point(6, 43)
        Me.cbxBurgersMcChicken.Name = "cbxBurgersMcChicken"
        Me.cbxBurgersMcChicken.Size = New System.Drawing.Size(80, 17)
        Me.cbxBurgersMcChicken.TabIndex = 1
        Me.cbxBurgersMcChicken.Text = "McChicken"
        Me.cbxBurgersMcChicken.UseVisualStyleBackColor = True
        '
        'cbxBurgersBigMac
        '
        Me.cbxBurgersBigMac.AutoSize = True
        Me.cbxBurgersBigMac.Location = New System.Drawing.Point(7, 20)
        Me.cbxBurgersBigMac.Name = "cbxBurgersBigMac"
        Me.cbxBurgersBigMac.Size = New System.Drawing.Size(65, 17)
        Me.cbxBurgersBigMac.TabIndex = 0
        Me.cbxBurgersBigMac.Text = "Big Mac"
        Me.cbxBurgersBigMac.UseVisualStyleBackColor = True
        '
        'gbxFriet
        '
        Me.gbxFriet.Controls.Add(Me.rbtnFritesLarge)
        Me.gbxFriet.Controls.Add(Me.rbtnFritesMedium)
        Me.gbxFriet.Location = New System.Drawing.Point(13, 109)
        Me.gbxFriet.Name = "gbxFriet"
        Me.gbxFriet.Size = New System.Drawing.Size(226, 71)
        Me.gbxFriet.TabIndex = 3
        Me.gbxFriet.TabStop = False
        Me.gbxFriet.Text = "Friet"
        '
        'rbtnFritesLarge
        '
        Me.rbtnFritesLarge.AutoSize = True
        Me.rbtnFritesLarge.Location = New System.Drawing.Point(8, 42)
        Me.rbtnFritesLarge.Name = "rbtnFritesLarge"
        Me.rbtnFritesLarge.Size = New System.Drawing.Size(52, 17)
        Me.rbtnFritesLarge.TabIndex = 1
        Me.rbtnFritesLarge.TabStop = True
        Me.rbtnFritesLarge.Text = "Large"
        Me.rbtnFritesLarge.UseVisualStyleBackColor = True
        '
        'rbtnFritesMedium
        '
        Me.rbtnFritesMedium.AutoSize = True
        Me.rbtnFritesMedium.Location = New System.Drawing.Point(6, 19)
        Me.rbtnFritesMedium.Name = "rbtnFritesMedium"
        Me.rbtnFritesMedium.Size = New System.Drawing.Size(62, 17)
        Me.rbtnFritesMedium.TabIndex = 0
        Me.rbtnFritesMedium.TabStop = True
        Me.rbtnFritesMedium.Text = "Medium"
        Me.rbtnFritesMedium.UseVisualStyleBackColor = True
        '
        'gbxDrinks
        '
        Me.gbxDrinks.Controls.Add(Me.rbtnDrinksSprite)
        Me.gbxDrinks.Controls.Add(Me.rbtnDrinksFanta)
        Me.gbxDrinks.Controls.Add(Me.rbtnDrinksCoke)
        Me.gbxDrinks.Controls.Add(Me.cbxDrinksLarge)
        Me.gbxDrinks.Controls.Add(Me.cbxDrinksMedium)
        Me.gbxDrinks.Controls.Add(Me.cbxDrinksSmall)
        Me.gbxDrinks.Location = New System.Drawing.Point(12, 186)
        Me.gbxDrinks.Name = "gbxDrinks"
        Me.gbxDrinks.Size = New System.Drawing.Size(226, 90)
        Me.gbxDrinks.TabIndex = 3
        Me.gbxDrinks.TabStop = False
        Me.gbxDrinks.Text = "Drinken"
        '
        'rbtnDrinksSprite
        '
        Me.rbtnDrinksSprite.AutoSize = True
        Me.rbtnDrinksSprite.Location = New System.Drawing.Point(6, 65)
        Me.rbtnDrinksSprite.Name = "rbtnDrinksSprite"
        Me.rbtnDrinksSprite.Size = New System.Drawing.Size(52, 17)
        Me.rbtnDrinksSprite.TabIndex = 5
        Me.rbtnDrinksSprite.TabStop = True
        Me.rbtnDrinksSprite.Text = "Sprite"
        Me.rbtnDrinksSprite.UseVisualStyleBackColor = True
        '
        'rbtnDrinksFanta
        '
        Me.rbtnDrinksFanta.AutoSize = True
        Me.rbtnDrinksFanta.Location = New System.Drawing.Point(7, 42)
        Me.rbtnDrinksFanta.Name = "rbtnDrinksFanta"
        Me.rbtnDrinksFanta.Size = New System.Drawing.Size(52, 17)
        Me.rbtnDrinksFanta.TabIndex = 4
        Me.rbtnDrinksFanta.TabStop = True
        Me.rbtnDrinksFanta.Text = "Fanta"
        Me.rbtnDrinksFanta.UseVisualStyleBackColor = True
        '
        'rbtnDrinksCoke
        '
        Me.rbtnDrinksCoke.AutoSize = True
        Me.rbtnDrinksCoke.Location = New System.Drawing.Point(7, 19)
        Me.rbtnDrinksCoke.Name = "rbtnDrinksCoke"
        Me.rbtnDrinksCoke.Size = New System.Drawing.Size(46, 17)
        Me.rbtnDrinksCoke.TabIndex = 3
        Me.rbtnDrinksCoke.TabStop = True
        Me.rbtnDrinksCoke.Text = "Cola"
        Me.rbtnDrinksCoke.UseVisualStyleBackColor = True
        '
        'cbxDrinksLarge
        '
        Me.cbxDrinksLarge.AutoSize = True
        Me.cbxDrinksLarge.Location = New System.Drawing.Point(144, 65)
        Me.cbxDrinksLarge.Name = "cbxDrinksLarge"
        Me.cbxDrinksLarge.Size = New System.Drawing.Size(53, 17)
        Me.cbxDrinksLarge.TabIndex = 2
        Me.cbxDrinksLarge.Text = "Large"
        Me.cbxDrinksLarge.UseVisualStyleBackColor = True
        '
        'cbxDrinksMedium
        '
        Me.cbxDrinksMedium.AutoSize = True
        Me.cbxDrinksMedium.Location = New System.Drawing.Point(144, 42)
        Me.cbxDrinksMedium.Name = "cbxDrinksMedium"
        Me.cbxDrinksMedium.Size = New System.Drawing.Size(63, 17)
        Me.cbxDrinksMedium.TabIndex = 1
        Me.cbxDrinksMedium.Text = "Medium"
        Me.cbxDrinksMedium.UseVisualStyleBackColor = True
        '
        'cbxDrinksSmall
        '
        Me.cbxDrinksSmall.AutoSize = True
        Me.cbxDrinksSmall.Location = New System.Drawing.Point(144, 19)
        Me.cbxDrinksSmall.Name = "cbxDrinksSmall"
        Me.cbxDrinksSmall.Size = New System.Drawing.Size(51, 17)
        Me.cbxDrinksSmall.TabIndex = 0
        Me.cbxDrinksSmall.Text = "Small"
        Me.cbxDrinksSmall.UseVisualStyleBackColor = True
        '
        'gbxResult
        '
        Me.gbxResult.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxResult.Controls.Add(Me.Label14)
        Me.gbxResult.Controls.Add(Me.Label13)
        Me.gbxResult.Controls.Add(Me.Label12)
        Me.gbxResult.Controls.Add(Me.Label11)
        Me.gbxResult.Controls.Add(Me.Label10)
        Me.gbxResult.Controls.Add(Me.Label7)
        Me.gbxResult.Controls.Add(Me.Label6)
        Me.gbxResult.Controls.Add(Me.Label5)
        Me.gbxResult.Controls.Add(Me.lblResultBurgers)
        Me.gbxResult.Controls.Add(Me.Label3)
        Me.gbxResult.Controls.Add(Me.Label2)
        Me.gbxResult.Controls.Add(Me.Label1)
        Me.gbxResult.Location = New System.Drawing.Point(245, 13)
        Me.gbxResult.Name = "gbxResult"
        Me.gbxResult.Size = New System.Drawing.Size(437, 132)
        Me.gbxResult.TabIndex = 4
        Me.gbxResult.TabStop = False
        Me.gbxResult.Text = "Prijs"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 96)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Totaalprijs:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(320, 96)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "DUMMY"
        Me.Label13.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(320, 66)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "DUMMY"
        Me.Label12.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(320, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "DUMMY"
        Me.Label11.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(320, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "DUMMY"
        Me.Label10.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(171, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "DUMMY"
        Me.Label7.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(117, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "DUMMY"
        Me.Label6.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(117, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "DUMMY"
        Me.Label5.Visible = False
        '
        'lblResultBurgers
        '
        Me.lblResultBurgers.AutoSize = True
        Me.lblResultBurgers.Location = New System.Drawing.Point(117, 20)
        Me.lblResultBurgers.Name = "lblResultBurgers"
        Me.lblResultBurgers.Size = New System.Drawing.Size(48, 13)
        Me.lblResultBurgers.TabIndex = 3
        Me.lblResultBurgers.Text = "DUMMY"
        Me.lblResultBurgers.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Drinken:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Friet:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Burger(s):"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(607, 249)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 5
        Me.btnCalc.Text = "Reken af"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(526, 249)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 284)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.gbxResult)
        Me.Controls.Add(Me.gbxDrinks)
        Me.Controls.Add(Me.gbxFriet)
        Me.Controls.Add(Me.gbxBurger)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "McDonalds"
        Me.gbxBurger.ResumeLayout(False)
        Me.gbxBurger.PerformLayout()
        Me.gbxFriet.ResumeLayout(False)
        Me.gbxFriet.PerformLayout()
        Me.gbxDrinks.ResumeLayout(False)
        Me.gbxDrinks.PerformLayout()
        Me.gbxResult.ResumeLayout(False)
        Me.gbxResult.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxBurger As GroupBox
    Friend WithEvents cbxBurgersBigTastyBacon As CheckBox
    Friend WithEvents cbxBurgersMcChicken As CheckBox
    Friend WithEvents cbxBurgersBigMac As CheckBox
    Friend WithEvents gbxFriet As GroupBox
    Friend WithEvents gbxDrinks As GroupBox
    Friend WithEvents cbxDrinksLarge As CheckBox
    Friend WithEvents cbxDrinksMedium As CheckBox
    Friend WithEvents cbxDrinksSmall As CheckBox
    Friend WithEvents rbtnDrinksSprite As RadioButton
    Friend WithEvents rbtnDrinksFanta As RadioButton
    Friend WithEvents rbtnDrinksCoke As RadioButton
    Friend WithEvents rbtnFritesLarge As RadioButton
    Friend WithEvents rbtnFritesMedium As RadioButton
    Friend WithEvents gbxResult As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblResultBurgers As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnReset As Button
End Class
