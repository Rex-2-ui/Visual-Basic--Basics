<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        GroupBox1 = New GroupBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        WholeSaleCheckBox = New CheckBox()
        txtvehiclemake = New TextBox()
        TxtYear = New TextBox()
        TxtLotNumber = New TextBox()
        GroupBox2 = New GroupBox()
        BothRadioButton = New RadioButton()
        UndercoatRadioButton = New RadioButton()
        PainttouchupRadioButton = New RadioButton()
        NoneRadiobutton = New RadioButton()
        GroupBox3 = New GroupBox()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        txttotaldue = New TextBox()
        txttradein = New TextBox()
        txtsalestax = New TextBox()
        txtSubtotal = New TextBox()
        txtExtras = New TextBox()
        txtDiscount = New TextBox()
        txtPrice = New TextBox()
        ComputeButton = New Button()
        ResetButton = New Button()
        TotalsButton = New Button()
        ExitButton = New Button()
        GroupBox = New GroupBox()
        NewFloorMatsCheckBox = New CheckBox()
        BuiltinGPSCheckBox = New CheckBox()
        NewHDRadioCheckBox = New CheckBox()
        NewtiresCheckBox = New CheckBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(WholeSaleCheckBox)
        GroupBox1.Controls.Add(txtvehiclemake)
        GroupBox1.Controls.Add(TxtYear)
        GroupBox1.Controls.Add(TxtLotNumber)
        GroupBox1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(22, 24)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(733, 185)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Used Automative Information"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(36, 94)
        Label3.Name = "Label3"
        Label3.Size = New Size(168, 23)
        Label3.TabIndex = 5
        Label3.Text = "Vehicle Make/Model"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(434, 33)
        Label2.Name = "Label2"
        Label2.Size = New Size(47, 23)
        Label2.TabIndex = 4
        Label2.Text = "Year:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(36, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 23)
        Label1.TabIndex = 3
        Label1.Text = "Lot Number"
        ' 
        ' WholeSaleCheckBox
        ' 
        WholeSaleCheckBox.AutoSize = True
        WholeSaleCheckBox.Checked = True
        WholeSaleCheckBox.CheckState = CheckState.Checked
        WholeSaleCheckBox.Location = New Point(222, 139)
        WholeSaleCheckBox.Name = "WholeSaleCheckBox"
        WholeSaleCheckBox.Size = New Size(189, 27)
        WholeSaleCheckBox.TabIndex = 0
        WholeSaleCheckBox.Text = "Whole Sale Discount"
        WholeSaleCheckBox.UseVisualStyleBackColor = True
        ' 
        ' txtvehiclemake
        ' 
        txtvehiclemake.Location = New Point(222, 87)
        txtvehiclemake.Name = "txtvehiclemake"
        txtvehiclemake.Size = New Size(445, 30)
        txtvehiclemake.TabIndex = 2
        txtvehiclemake.Text = "Ford Escsape"
        ' 
        ' TxtYear
        ' 
        TxtYear.Location = New Point(542, 26)
        TxtYear.Name = "TxtYear"
        TxtYear.Size = New Size(125, 30)
        TxtYear.TabIndex = 1
        TxtYear.Text = "2010"
        ' 
        ' TxtLotNumber
        ' 
        TxtLotNumber.Location = New Point(222, 26)
        TxtLotNumber.Name = "TxtLotNumber"
        TxtLotNumber.Size = New Size(184, 30)
        TxtLotNumber.TabIndex = 0
        TxtLotNumber.Text = "779"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(BothRadioButton)
        GroupBox2.Controls.Add(UndercoatRadioButton)
        GroupBox2.Controls.Add(PainttouchupRadioButton)
        GroupBox2.Controls.Add(NoneRadiobutton)
        GroupBox2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(465, 236)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(290, 181)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Exterior Extras"
        ' 
        ' BothRadioButton
        ' 
        BothRadioButton.AutoSize = True
        BothRadioButton.Location = New Point(49, 139)
        BothRadioButton.Name = "BothRadioButton"
        BothRadioButton.Size = New Size(62, 24)
        BothRadioButton.TabIndex = 3
        BothRadioButton.Text = "Both"
        BothRadioButton.UseVisualStyleBackColor = True
        ' 
        ' UndercoatRadioButton
        ' 
        UndercoatRadioButton.AutoSize = True
        UndercoatRadioButton.Location = New Point(49, 109)
        UndercoatRadioButton.Name = "UndercoatRadioButton"
        UndercoatRadioButton.Size = New Size(102, 24)
        UndercoatRadioButton.TabIndex = 2
        UndercoatRadioButton.Text = "Undercoat"
        UndercoatRadioButton.UseVisualStyleBackColor = True
        ' 
        ' PainttouchupRadioButton
        ' 
        PainttouchupRadioButton.AutoSize = True
        PainttouchupRadioButton.Checked = True
        PainttouchupRadioButton.Location = New Point(49, 70)
        PainttouchupRadioButton.Name = "PainttouchupRadioButton"
        PainttouchupRadioButton.Size = New Size(136, 24)
        PainttouchupRadioButton.TabIndex = 1
        PainttouchupRadioButton.TabStop = True
        PainttouchupRadioButton.Text = "Paint Touch-Up"
        PainttouchupRadioButton.UseVisualStyleBackColor = True
        ' 
        ' NoneRadiobutton
        ' 
        NoneRadiobutton.AutoSize = True
        NoneRadiobutton.Location = New Point(49, 40)
        NoneRadiobutton.Name = "NoneRadiobutton"
        NoneRadiobutton.Size = New Size(68, 24)
        NoneRadiobutton.TabIndex = 0
        NoneRadiobutton.Text = "None"
        NoneRadiobutton.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Label10)
        GroupBox3.Controls.Add(Label9)
        GroupBox3.Controls.Add(Label8)
        GroupBox3.Controls.Add(Label7)
        GroupBox3.Controls.Add(Label6)
        GroupBox3.Controls.Add(Label5)
        GroupBox3.Controls.Add(Label4)
        GroupBox3.Controls.Add(txttotaldue)
        GroupBox3.Controls.Add(txttradein)
        GroupBox3.Controls.Add(txtsalestax)
        GroupBox3.Controls.Add(txtSubtotal)
        GroupBox3.Controls.Add(txtExtras)
        GroupBox3.Controls.Add(txtDiscount)
        GroupBox3.Controls.Add(txtPrice)
        GroupBox3.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox3.Location = New Point(22, 236)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(361, 368)
        GroupBox3.TabIndex = 1
        GroupBox3.TabStop = False
        GroupBox3.Text = "Sales Information"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(17, 338)
        Label10.Name = "Label10"
        Label10.Size = New Size(80, 23)
        Label10.TabIndex = 14
        Label10.Text = "Total due"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(17, 295)
        Label9.Name = "Label9"
        Label9.Size = New Size(73, 23)
        Label9.TabIndex = 13
        Label9.Text = "Trade-in"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(17, 243)
        Label8.Name = "Label8"
        Label8.Size = New Size(78, 23)
        Label8.TabIndex = 12
        Label8.Text = "Sales Tax"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(17, 193)
        Label7.Name = "Label7"
        Label7.Size = New Size(74, 23)
        Label7.TabIndex = 11
        Label7.Text = "Subtotal"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(17, 143)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 23)
        Label6.TabIndex = 10
        Label6.Text = "Extras"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(17, 94)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 23)
        Label5.TabIndex = 9
        Label5.Text = "Discount"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(17, 44)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 23)
        Label4.TabIndex = 8
        Label4.Text = "Price"
        ' 
        ' txttotaldue
        ' 
        txttotaldue.Location = New Point(129, 335)
        txttotaldue.Name = "txttotaldue"
        txttotaldue.Size = New Size(125, 30)
        txttotaldue.TabIndex = 7
        txttotaldue.Text = "$13.945.95"
        txttotaldue.TextAlign = HorizontalAlignment.Right
        ' 
        ' txttradein
        ' 
        txttradein.Location = New Point(129, 288)
        txttradein.Name = "txttradein"
        txttradein.Size = New Size(125, 30)
        txttradein.TabIndex = 6
        txttradein.Text = "0.00"
        txttradein.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtsalestax
        ' 
        txtsalestax.Location = New Point(129, 236)
        txtsalestax.Name = "txtsalestax"
        txtsalestax.ReadOnly = True
        txtsalestax.Size = New Size(125, 30)
        txtsalestax.TabIndex = 5
        txtsalestax.Text = "0.00"
        txtsalestax.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtSubtotal
        ' 
        txtSubtotal.Location = New Point(129, 186)
        txtSubtotal.Name = "txtSubtotal"
        txtSubtotal.ReadOnly = True
        txtSubtotal.Size = New Size(125, 30)
        txtSubtotal.TabIndex = 4
        txtSubtotal.Text = "0.00"
        txtSubtotal.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtExtras
        ' 
        txtExtras.Location = New Point(129, 136)
        txtExtras.Name = "txtExtras"
        txtExtras.ReadOnly = True
        txtExtras.Size = New Size(125, 30)
        txtExtras.TabIndex = 3
        txtExtras.Text = "945.95"
        txtExtras.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtDiscount
        ' 
        txtDiscount.AcceptsTab = True
        txtDiscount.Enabled = False
        txtDiscount.Location = New Point(129, 87)
        txtDiscount.Name = "txtDiscount"
        txtDiscount.ReadOnly = True
        txtDiscount.Size = New Size(125, 30)
        txtDiscount.TabIndex = 2
        txtDiscount.TabStop = False
        txtDiscount.Text = "3,250.00"
        txtDiscount.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(129, 37)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(125, 30)
        txtPrice.TabIndex = 1
        txtPrice.Text = "$16,250.00"
        txtPrice.TextAlign = HorizontalAlignment.Right
        ' 
        ' ComputeButton
        ' 
        ComputeButton.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComputeButton.Location = New Point(244, 659)
        ComputeButton.Name = "ComputeButton"
        ComputeButton.Size = New Size(111, 49)
        ComputeButton.TabIndex = 2
        ComputeButton.Text = "Compute "
        ComputeButton.UseVisualStyleBackColor = True
        ' 
        ' ResetButton
        ' 
        ResetButton.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ResetButton.Location = New Point(394, 659)
        ResetButton.Name = "ResetButton"
        ResetButton.Size = New Size(104, 49)
        ResetButton.TabIndex = 3
        ResetButton.Text = "Reset"
        ResetButton.UseVisualStyleBackColor = True
        ' 
        ' TotalsButton
        ' 
        TotalsButton.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TotalsButton.Location = New Point(543, 659)
        TotalsButton.Name = "TotalsButton"
        TotalsButton.Size = New Size(98, 49)
        TotalsButton.TabIndex = 4
        TotalsButton.Text = "Totals"
        TotalsButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ExitButton.Location = New Point(688, 659)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(102, 49)
        ExitButton.TabIndex = 5
        ExitButton.Text = "Exit"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' GroupBox
        ' 
        GroupBox.Controls.Add(NewFloorMatsCheckBox)
        GroupBox.Controls.Add(BuiltinGPSCheckBox)
        GroupBox.Controls.Add(NewHDRadioCheckBox)
        GroupBox.Controls.Add(NewtiresCheckBox)
        GroupBox.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox.Location = New Point(465, 429)
        GroupBox.Name = "GroupBox"
        GroupBox.Size = New Size(290, 196)
        GroupBox.TabIndex = 6
        GroupBox.TabStop = False
        GroupBox.Text = "Accessory Extras"
        ' 
        ' NewFloorMatsCheckBox
        ' 
        NewFloorMatsCheckBox.AutoSize = True
        NewFloorMatsCheckBox.Checked = True
        NewFloorMatsCheckBox.CheckState = CheckState.Checked
        NewFloorMatsCheckBox.Location = New Point(26, 151)
        NewFloorMatsCheckBox.Name = "NewFloorMatsCheckBox"
        NewFloorMatsCheckBox.Size = New Size(154, 27)
        NewFloorMatsCheckBox.TabIndex = 4
        NewFloorMatsCheckBox.Text = "New Floor Mats"
        NewFloorMatsCheckBox.UseVisualStyleBackColor = True
        ' 
        ' BuiltinGPSCheckBox
        ' 
        BuiltinGPSCheckBox.AutoSize = True
        BuiltinGPSCheckBox.Location = New Point(26, 113)
        BuiltinGPSCheckBox.Name = "BuiltinGPSCheckBox"
        BuiltinGPSCheckBox.Size = New Size(122, 27)
        BuiltinGPSCheckBox.TabIndex = 3
        BuiltinGPSCheckBox.Text = "Built-in GPS"
        BuiltinGPSCheckBox.UseVisualStyleBackColor = True
        ' 
        ' NewHDRadioCheckBox
        ' 
        NewHDRadioCheckBox.AutoSize = True
        NewHDRadioCheckBox.Checked = True
        NewHDRadioCheckBox.CheckState = CheckState.Checked
        NewHDRadioCheckBox.Location = New Point(26, 72)
        NewHDRadioCheckBox.Name = "NewHDRadioCheckBox"
        NewHDRadioCheckBox.Size = New Size(146, 27)
        NewHDRadioCheckBox.TabIndex = 2
        NewHDRadioCheckBox.Text = "New HD Radio"
        NewHDRadioCheckBox.UseVisualStyleBackColor = True
        ' 
        ' NewtiresCheckBox
        ' 
        NewtiresCheckBox.AutoSize = True
        NewtiresCheckBox.Checked = True
        NewtiresCheckBox.CheckState = CheckState.Checked
        NewtiresCheckBox.Location = New Point(26, 26)
        NewtiresCheckBox.Name = "NewtiresCheckBox"
        NewtiresCheckBox.Size = New Size(107, 27)
        NewtiresCheckBox.TabIndex = 1
        NewtiresCheckBox.Text = "New Tires"
        NewtiresCheckBox.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(840, 720)
        Controls.Add(GroupBox)
        Controls.Add(ExitButton)
        Controls.Add(TotalsButton)
        Controls.Add(ResetButton)
        Controls.Add(ComputeButton)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox.ResumeLayout(False)
        GroupBox.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtvehiclemake As TextBox
    Friend WithEvents TxtYear As TextBox
    Friend WithEvents TxtLotNumber As TextBox
    Friend WithEvents txtExtras As TextBox
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txttotaldue As TextBox
    Friend WithEvents txttradein As TextBox
    Friend WithEvents txtsalestax As TextBox
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents ComputeButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents TotalsButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents BothRadioButton As RadioButton
    Friend WithEvents UndercoatRadioButton As RadioButton
    Friend WithEvents PainttouchupRadioButton As RadioButton
    Friend WithEvents NoneRadiobutton As RadioButton
    Friend WithEvents BuiltinGPSCheckBox As CheckBox
    Friend WithEvents NewHDRadioCheckBox As CheckBox
    Friend WithEvents NewtiresCheckBox As CheckBox
    Friend WithEvents WholeSaleCheckBox As CheckBox
    Friend WithEvents NewFloorMatsCheckBox As CheckBox

End Class
