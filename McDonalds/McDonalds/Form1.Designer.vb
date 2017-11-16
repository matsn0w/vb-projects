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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.gbxBurger = New System.Windows.Forms.GroupBox()
        Me.nudBurgersBigTastyBacon = New System.Windows.Forms.NumericUpDown()
        Me.nudBurgersMcChicken = New System.Windows.Forms.NumericUpDown()
        Me.nudBurgersBigMac = New System.Windows.Forms.NumericUpDown()
        Me.lblBurgersBigTastyBacon = New System.Windows.Forms.Label()
        Me.lblBurgersMcChicken = New System.Windows.Forms.Label()
        Me.lblBurgersBigMac = New System.Windows.Forms.Label()
        Me.gbxFriet = New System.Windows.Forms.GroupBox()
        Me.rbtnFritesLarge = New System.Windows.Forms.RadioButton()
        Me.rbtnFritesMedium = New System.Windows.Forms.RadioButton()
        Me.gbxDrinks = New System.Windows.Forms.GroupBox()
        Me.cbxDrinksSize = New System.Windows.Forms.ComboBox()
        Me.rbtnDrinksSprite = New System.Windows.Forms.RadioButton()
        Me.rbtnDrinksFanta = New System.Windows.Forms.RadioButton()
        Me.rbtnDrinksCoke = New System.Windows.Forms.RadioButton()
        Me.gbxResult = New System.Windows.Forms.GroupBox()
        Me.tbxTotalPrice = New System.Windows.Forms.TextBox()
        Me.tbxPriceDrinks = New System.Windows.Forms.TextBox()
        Me.tbxPriceFrites = New System.Windows.Forms.TextBox()
        Me.tbxPriceBurgers = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblPriceDrinks = New System.Windows.Forms.Label()
        Me.lblPriceFrites = New System.Windows.Forms.Label()
        Me.lblPriceBurgers = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.gbxBurger.SuspendLayout()
        CType(Me.nudBurgersBigTastyBacon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudBurgersMcChicken, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudBurgersBigMac, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxFriet.SuspendLayout()
        Me.gbxDrinks.SuspendLayout()
        Me.gbxResult.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxBurger
        '
        Me.gbxBurger.Controls.Add(Me.nudBurgersBigTastyBacon)
        Me.gbxBurger.Controls.Add(Me.nudBurgersMcChicken)
        Me.gbxBurger.Controls.Add(Me.nudBurgersBigMac)
        Me.gbxBurger.Controls.Add(Me.lblBurgersBigTastyBacon)
        Me.gbxBurger.Controls.Add(Me.lblBurgersMcChicken)
        Me.gbxBurger.Controls.Add(Me.lblBurgersBigMac)
        Me.gbxBurger.Location = New System.Drawing.Point(12, 12)
        Me.gbxBurger.Name = "gbxBurger"
        Me.gbxBurger.Size = New System.Drawing.Size(264, 107)
        Me.gbxBurger.TabIndex = 0
        Me.gbxBurger.TabStop = False
        Me.gbxBurger.Text = "Burger"
        '
        'nudBurgersBigTastyBacon
        '
        Me.nudBurgersBigTastyBacon.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.nudBurgersBigTastyBacon.Location = New System.Drawing.Point(137, 70)
        Me.nudBurgersBigTastyBacon.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudBurgersBigTastyBacon.Name = "nudBurgersBigTastyBacon"
        Me.nudBurgersBigTastyBacon.Size = New System.Drawing.Size(120, 20)
        Me.nudBurgersBigTastyBacon.TabIndex = 5
        '
        'nudBurgersMcChicken
        '
        Me.nudBurgersMcChicken.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.nudBurgersMcChicken.Location = New System.Drawing.Point(137, 44)
        Me.nudBurgersMcChicken.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudBurgersMcChicken.Name = "nudBurgersMcChicken"
        Me.nudBurgersMcChicken.Size = New System.Drawing.Size(120, 20)
        Me.nudBurgersMcChicken.TabIndex = 4
        '
        'nudBurgersBigMac
        '
        Me.nudBurgersBigMac.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.nudBurgersBigMac.Location = New System.Drawing.Point(137, 18)
        Me.nudBurgersBigMac.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudBurgersBigMac.Name = "nudBurgersBigMac"
        Me.nudBurgersBigMac.Size = New System.Drawing.Size(120, 20)
        Me.nudBurgersBigMac.TabIndex = 3
        '
        'lblBurgersBigTastyBacon
        '
        Me.lblBurgersBigTastyBacon.AutoSize = True
        Me.lblBurgersBigTastyBacon.Location = New System.Drawing.Point(6, 72)
        Me.lblBurgersBigTastyBacon.Name = "lblBurgersBigTastyBacon"
        Me.lblBurgersBigTastyBacon.Size = New System.Drawing.Size(108, 13)
        Me.lblBurgersBigTastyBacon.TabIndex = 2
        Me.lblBurgersBigTastyBacon.Text = "Big Tasty met Bacon:"
        '
        'lblBurgersMcChicken
        '
        Me.lblBurgersMcChicken.AutoSize = True
        Me.lblBurgersMcChicken.Location = New System.Drawing.Point(6, 46)
        Me.lblBurgersMcChicken.Name = "lblBurgersMcChicken"
        Me.lblBurgersMcChicken.Size = New System.Drawing.Size(64, 13)
        Me.lblBurgersMcChicken.TabIndex = 1
        Me.lblBurgersMcChicken.Text = "McChicken:"
        '
        'lblBurgersBigMac
        '
        Me.lblBurgersBigMac.AutoSize = True
        Me.lblBurgersBigMac.Location = New System.Drawing.Point(6, 20)
        Me.lblBurgersBigMac.Name = "lblBurgersBigMac"
        Me.lblBurgersBigMac.Size = New System.Drawing.Size(49, 13)
        Me.lblBurgersBigMac.TabIndex = 0
        Me.lblBurgersBigMac.Text = "Big Mac:"
        '
        'gbxFriet
        '
        Me.gbxFriet.Controls.Add(Me.rbtnFritesLarge)
        Me.gbxFriet.Controls.Add(Me.rbtnFritesMedium)
        Me.gbxFriet.Location = New System.Drawing.Point(12, 125)
        Me.gbxFriet.Name = "gbxFriet"
        Me.gbxFriet.Size = New System.Drawing.Size(264, 71)
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
        Me.rbtnFritesLarge.Text = "Large"
        Me.rbtnFritesLarge.UseVisualStyleBackColor = True
        '
        'rbtnFritesMedium
        '
        Me.rbtnFritesMedium.AutoSize = True
        Me.rbtnFritesMedium.Checked = True
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
        Me.gbxDrinks.Controls.Add(Me.cbxDrinksSize)
        Me.gbxDrinks.Controls.Add(Me.rbtnDrinksSprite)
        Me.gbxDrinks.Controls.Add(Me.rbtnDrinksFanta)
        Me.gbxDrinks.Controls.Add(Me.rbtnDrinksCoke)
        Me.gbxDrinks.Location = New System.Drawing.Point(12, 202)
        Me.gbxDrinks.Name = "gbxDrinks"
        Me.gbxDrinks.Size = New System.Drawing.Size(264, 90)
        Me.gbxDrinks.TabIndex = 3
        Me.gbxDrinks.TabStop = False
        Me.gbxDrinks.Text = "Drinken"
        '
        'cbxDrinksSize
        '
        Me.cbxDrinksSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDrinksSize.FormattingEnabled = True
        Me.cbxDrinksSize.Items.AddRange(New Object() {"Small", "Medium", "Large"})
        Me.cbxDrinksSize.Location = New System.Drawing.Point(136, 19)
        Me.cbxDrinksSize.Name = "cbxDrinksSize"
        Me.cbxDrinksSize.Size = New System.Drawing.Size(121, 21)
        Me.cbxDrinksSize.TabIndex = 7
        '
        'rbtnDrinksSprite
        '
        Me.rbtnDrinksSprite.AutoSize = True
        Me.rbtnDrinksSprite.Location = New System.Drawing.Point(6, 65)
        Me.rbtnDrinksSprite.Name = "rbtnDrinksSprite"
        Me.rbtnDrinksSprite.Size = New System.Drawing.Size(52, 17)
        Me.rbtnDrinksSprite.TabIndex = 5
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
        Me.rbtnDrinksFanta.Text = "Fanta"
        Me.rbtnDrinksFanta.UseVisualStyleBackColor = True
        '
        'rbtnDrinksCoke
        '
        Me.rbtnDrinksCoke.AutoSize = True
        Me.rbtnDrinksCoke.Checked = True
        Me.rbtnDrinksCoke.Location = New System.Drawing.Point(7, 19)
        Me.rbtnDrinksCoke.Name = "rbtnDrinksCoke"
        Me.rbtnDrinksCoke.Size = New System.Drawing.Size(46, 17)
        Me.rbtnDrinksCoke.TabIndex = 3
        Me.rbtnDrinksCoke.TabStop = True
        Me.rbtnDrinksCoke.Text = "Cola"
        Me.rbtnDrinksCoke.UseVisualStyleBackColor = True
        '
        'gbxResult
        '
        Me.gbxResult.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxResult.Controls.Add(Me.tbxTotalPrice)
        Me.gbxResult.Controls.Add(Me.tbxPriceDrinks)
        Me.gbxResult.Controls.Add(Me.tbxPriceFrites)
        Me.gbxResult.Controls.Add(Me.tbxPriceBurgers)
        Me.gbxResult.Controls.Add(Me.Label14)
        Me.gbxResult.Controls.Add(Me.lblPriceDrinks)
        Me.gbxResult.Controls.Add(Me.lblPriceFrites)
        Me.gbxResult.Controls.Add(Me.lblPriceBurgers)
        Me.gbxResult.Location = New System.Drawing.Point(282, 12)
        Me.gbxResult.Name = "gbxResult"
        Me.gbxResult.Size = New System.Drawing.Size(248, 133)
        Me.gbxResult.TabIndex = 4
        Me.gbxResult.TabStop = False
        Me.gbxResult.Text = "Prijs"
        '
        'tbxTotalPrice
        '
        Me.tbxTotalPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxTotalPrice.Location = New System.Drawing.Point(133, 107)
        Me.tbxTotalPrice.Name = "tbxTotalPrice"
        Me.tbxTotalPrice.ReadOnly = True
        Me.tbxTotalPrice.Size = New System.Drawing.Size(109, 20)
        Me.tbxTotalPrice.TabIndex = 17
        Me.tbxTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbxPriceDrinks
        '
        Me.tbxPriceDrinks.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxPriceDrinks.Location = New System.Drawing.Point(133, 63)
        Me.tbxPriceDrinks.Name = "tbxPriceDrinks"
        Me.tbxPriceDrinks.ReadOnly = True
        Me.tbxPriceDrinks.Size = New System.Drawing.Size(109, 20)
        Me.tbxPriceDrinks.TabIndex = 16
        Me.tbxPriceDrinks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbxPriceFrites
        '
        Me.tbxPriceFrites.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxPriceFrites.Location = New System.Drawing.Point(133, 40)
        Me.tbxPriceFrites.Name = "tbxPriceFrites"
        Me.tbxPriceFrites.ReadOnly = True
        Me.tbxPriceFrites.Size = New System.Drawing.Size(109, 20)
        Me.tbxPriceFrites.TabIndex = 15
        Me.tbxPriceFrites.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbxPriceBurgers
        '
        Me.tbxPriceBurgers.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxPriceBurgers.Location = New System.Drawing.Point(133, 17)
        Me.tbxPriceBurgers.Name = "tbxPriceBurgers"
        Me.tbxPriceBurgers.ReadOnly = True
        Me.tbxPriceBurgers.Size = New System.Drawing.Size(109, 20)
        Me.tbxPriceBurgers.TabIndex = 14
        Me.tbxPriceBurgers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 110)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Totaalprijs:"
        '
        'lblPriceDrinks
        '
        Me.lblPriceDrinks.AutoSize = True
        Me.lblPriceDrinks.Location = New System.Drawing.Point(6, 66)
        Me.lblPriceDrinks.Name = "lblPriceDrinks"
        Me.lblPriceDrinks.Size = New System.Drawing.Size(47, 13)
        Me.lblPriceDrinks.TabIndex = 2
        Me.lblPriceDrinks.Text = "Drinken:"
        '
        'lblPriceFrites
        '
        Me.lblPriceFrites.AutoSize = True
        Me.lblPriceFrites.Location = New System.Drawing.Point(6, 43)
        Me.lblPriceFrites.Name = "lblPriceFrites"
        Me.lblPriceFrites.Size = New System.Drawing.Size(30, 13)
        Me.lblPriceFrites.TabIndex = 1
        Me.lblPriceFrites.Text = "Friet:"
        '
        'lblPriceBurgers
        '
        Me.lblPriceBurgers.AutoSize = True
        Me.lblPriceBurgers.Location = New System.Drawing.Point(6, 20)
        Me.lblPriceBurgers.Name = "lblPriceBurgers"
        Me.lblPriceBurgers.Size = New System.Drawing.Size(52, 13)
        Me.lblPriceBurgers.TabIndex = 0
        Me.lblPriceBurgers.Text = "Burger(s):"
        '
        'btnCalculate
        '
        Me.btnCalculate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCalculate.Location = New System.Drawing.Point(455, 151)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Reken af"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReset.Location = New System.Drawing.Point(374, 151)
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
        Me.ClientSize = New System.Drawing.Size(542, 304)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.gbxResult)
        Me.Controls.Add(Me.gbxDrinks)
        Me.Controls.Add(Me.gbxFriet)
        Me.Controls.Add(Me.gbxBurger)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "McDonald's"
        Me.gbxBurger.ResumeLayout(False)
        Me.gbxBurger.PerformLayout()
        CType(Me.nudBurgersBigTastyBacon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudBurgersMcChicken, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudBurgersBigMac, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxFriet.ResumeLayout(False)
        Me.gbxFriet.PerformLayout()
        Me.gbxDrinks.ResumeLayout(False)
        Me.gbxDrinks.PerformLayout()
        Me.gbxResult.ResumeLayout(False)
        Me.gbxResult.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxBurger As GroupBox
    Friend WithEvents gbxFriet As GroupBox
    Friend WithEvents gbxDrinks As GroupBox
    Friend WithEvents rbtnDrinksSprite As RadioButton
    Friend WithEvents rbtnDrinksFanta As RadioButton
    Friend WithEvents rbtnDrinksCoke As RadioButton
    Friend WithEvents rbtnFritesLarge As RadioButton
    Friend WithEvents rbtnFritesMedium As RadioButton
    Friend WithEvents gbxResult As GroupBox
    Friend WithEvents lblPriceDrinks As Label
    Friend WithEvents lblPriceFrites As Label
    Friend WithEvents lblPriceBurgers As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents tbxTotalPrice As TextBox
    Friend WithEvents tbxPriceDrinks As TextBox
    Friend WithEvents tbxPriceFrites As TextBox
    Friend WithEvents tbxPriceBurgers As TextBox
    Friend WithEvents cbxDrinksSize As ComboBox
    Friend WithEvents nudBurgersBigTastyBacon As NumericUpDown
    Friend WithEvents nudBurgersMcChicken As NumericUpDown
    Friend WithEvents nudBurgersBigMac As NumericUpDown
    Friend WithEvents lblBurgersBigTastyBacon As Label
    Friend WithEvents lblBurgersMcChicken As Label
    Friend WithEvents lblBurgersBigMac As Label
End Class
