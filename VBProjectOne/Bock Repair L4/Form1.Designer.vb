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
        WholeSaleCheckBox = New CheckBox()
        StateTextBox = New TextBox()
        ZipTextBox = New TextBox()
        CityTextBox = New TextBox()
        AddressTextBox = New TextBox()
        NameTextBox = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        FedXOvernightRadioButton = New RadioButton()
        FedXDayRadioButton = New RadioButton()
        USPostalAirRadioButton = New RadioButton()
        USPostalRadioButton = New RadioButton()
        GroupBox3 = New GroupBox()
        QuantityTextBox = New TextBox()
        Label = New Label()
        DescriptionTextBox = New TextBox()
        PriceTextBox = New TextBox()
        WeightTextBox = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        GroupBox4 = New GroupBox()
        CostTextBox = New TextBox()
        TaxDueTextBox = New TextBox()
        ShippingTextBox = New TextBox()
        TotalTextBox = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        ComputeButton = New Button()
        NewOrderButton = New Button()
        ExitButton = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(WholeSaleCheckBox)
        GroupBox1.Controls.Add(StateTextBox)
        GroupBox1.Controls.Add(ZipTextBox)
        GroupBox1.Controls.Add(CityTextBox)
        GroupBox1.Controls.Add(AddressTextBox)
        GroupBox1.Controls.Add(NameTextBox)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(35, 47)
        GroupBox1.Margin = New Padding(4, 3, 4, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 3, 4, 3)
        GroupBox1.Size = New Size(488, 201)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Customer Information"
        ' 
        ' WholeSaleCheckBox
        ' 
        WholeSaleCheckBox.AutoSize = True
        WholeSaleCheckBox.Location = New Point(309, 163)
        WholeSaleCheckBox.Name = "WholeSaleCheckBox"
        WholeSaleCheckBox.Size = New Size(116, 27)
        WholeSaleCheckBox.TabIndex = 9
        WholeSaleCheckBox.Text = "WholeSale:"
        WholeSaleCheckBox.UseVisualStyleBackColor = True
        ' 
        ' StateTextBox
        ' 
        StateTextBox.Location = New Point(350, 122)
        StateTextBox.Name = "StateTextBox"
        StateTextBox.Size = New Size(52, 30)
        StateTextBox.TabIndex = 8
        ' 
        ' ZipTextBox
        ' 
        ZipTextBox.Location = New Point(142, 161)
        ZipTextBox.Name = "ZipTextBox"
        ZipTextBox.Size = New Size(144, 30)
        ZipTextBox.TabIndex = 7
        ' 
        ' CityTextBox
        ' 
        CityTextBox.Location = New Point(142, 122)
        CityTextBox.Name = "CityTextBox"
        CityTextBox.Size = New Size(202, 30)
        CityTextBox.TabIndex = 6
        ' 
        ' AddressTextBox
        ' 
        AddressTextBox.Location = New Point(142, 78)
        AddressTextBox.Name = "AddressTextBox"
        AddressTextBox.Size = New Size(260, 30)
        AddressTextBox.TabIndex = 5
        ' 
        ' NameTextBox
        ' 
        NameTextBox.Location = New Point(142, 27)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.Size = New Size(260, 30)
        NameTextBox.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(25, 168)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 23)
        Label4.TabIndex = 3
        Label4.Text = "Zip Code"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(24, 131)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 23)
        Label3.TabIndex = 2
        Label3.Text = "City - State:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(24, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 23)
        Label2.TabIndex = 1
        Label2.Text = "Address:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(24, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 23)
        Label1.TabIndex = 0
        Label1.Text = "Name:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(FedXOvernightRadioButton)
        GroupBox2.Controls.Add(FedXDayRadioButton)
        GroupBox2.Controls.Add(USPostalAirRadioButton)
        GroupBox2.Controls.Add(USPostalRadioButton)
        GroupBox2.Location = New Point(546, 47)
        GroupBox2.Margin = New Padding(4, 3, 4, 3)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(4, 3, 4, 3)
        GroupBox2.Size = New Size(458, 173)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Tansportation"
        ' 
        ' FedXOvernightRadioButton
        ' 
        FedXOvernightRadioButton.AutoSize = True
        FedXOvernightRadioButton.Location = New Point(228, 96)
        FedXOvernightRadioButton.Name = "FedXOvernightRadioButton"
        FedXOvernightRadioButton.Size = New Size(164, 27)
        FedXOvernightRadioButton.TabIndex = 3
        FedXOvernightRadioButton.TabStop = True
        FedXOvernightRadioButton.Text = "Fed Ex Overnight"
        FedXOvernightRadioButton.UseVisualStyleBackColor = True
        ' 
        ' FedXDayRadioButton
        ' 
        FedXDayRadioButton.AutoSize = True
        FedXDayRadioButton.Location = New Point(228, 40)
        FedXDayRadioButton.Name = "FedXDayRadioButton"
        FedXDayRadioButton.Size = New Size(151, 27)
        FedXDayRadioButton.TabIndex = 2
        FedXDayRadioButton.TabStop = True
        FedXDayRadioButton.Text = "Fed Ex 2nd Day"
        FedXDayRadioButton.UseVisualStyleBackColor = True
        ' 
        ' USPostalAirRadioButton
        ' 
        USPostalAirRadioButton.AutoSize = True
        USPostalAirRadioButton.Checked = True
        USPostalAirRadioButton.Location = New Point(32, 98)
        USPostalAirRadioButton.Name = "USPostalAirRadioButton"
        USPostalAirRadioButton.Size = New Size(128, 27)
        USPostalAirRadioButton.TabIndex = 1
        USPostalAirRadioButton.TabStop = True
        USPostalAirRadioButton.Text = "US Postal Air"
        USPostalAirRadioButton.UseVisualStyleBackColor = True
        ' 
        ' USPostalRadioButton
        ' 
        USPostalRadioButton.AutoSize = True
        USPostalRadioButton.Location = New Point(32, 40)
        USPostalRadioButton.Name = "USPostalRadioButton"
        USPostalRadioButton.Size = New Size(102, 27)
        USPostalRadioButton.TabIndex = 0
        USPostalRadioButton.TabStop = True
        USPostalRadioButton.Text = "US Postal"
        USPostalRadioButton.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(QuantityTextBox)
        GroupBox3.Controls.Add(Label)
        GroupBox3.Controls.Add(DescriptionTextBox)
        GroupBox3.Controls.Add(PriceTextBox)
        GroupBox3.Controls.Add(WeightTextBox)
        GroupBox3.Controls.Add(Label5)
        GroupBox3.Controls.Add(Label6)
        GroupBox3.Controls.Add(Label7)
        GroupBox3.Location = New Point(35, 269)
        GroupBox3.Margin = New Padding(4, 3, 4, 3)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(4, 3, 4, 3)
        GroupBox3.Size = New Size(488, 165)
        GroupBox3.TabIndex = 1
        GroupBox3.TabStop = False
        GroupBox3.Text = "Parts Information"
        ' 
        ' QuantityTextBox
        ' 
        QuantityTextBox.Location = New Point(397, 124)
        QuantityTextBox.Name = "QuantityTextBox"
        QuantityTextBox.Size = New Size(84, 30)
        QuantityTextBox.TabIndex = 12
        QuantityTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label
        ' 
        Label.AutoSize = True
        Label.Location = New Point(312, 127)
        Label.Name = "Label"
        Label.Size = New Size(77, 23)
        Label.TabIndex = 11
        Label.Text = "Quantity"
        ' 
        ' DescriptionTextBox
        ' 
        DescriptionTextBox.Location = New Point(181, 36)
        DescriptionTextBox.Name = "DescriptionTextBox"
        DescriptionTextBox.Size = New Size(260, 30)
        DescriptionTextBox.TabIndex = 10
        ' 
        ' PriceTextBox
        ' 
        PriceTextBox.Location = New Point(181, 77)
        PriceTextBox.Name = "PriceTextBox"
        PriceTextBox.Size = New Size(202, 30)
        PriceTextBox.TabIndex = 9
        PriceTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' WeightTextBox
        ' 
        WeightTextBox.Location = New Point(181, 120)
        WeightTextBox.Name = "WeightTextBox"
        WeightTextBox.Size = New Size(111, 30)
        WeightTextBox.TabIndex = 8
        WeightTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(25, 39)
        Label5.Name = "Label5"
        Label5.Size = New Size(100, 23)
        Label5.TabIndex = 7
        Label5.Text = "Description:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(25, 80)
        Label6.Name = "Label6"
        Label6.Size = New Size(116, 23)
        Label6.TabIndex = 6
        Label6.Text = "Price Per Part:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(25, 119)
        Label7.Name = "Label7"
        Label7.Size = New Size(134, 23)
        Label7.TabIndex = 5
        Label7.Text = "Weight Per Part:"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(CostTextBox)
        GroupBox4.Controls.Add(TaxDueTextBox)
        GroupBox4.Controls.Add(ShippingTextBox)
        GroupBox4.Controls.Add(TotalTextBox)
        GroupBox4.Controls.Add(Label8)
        GroupBox4.Controls.Add(Label9)
        GroupBox4.Controls.Add(Label10)
        GroupBox4.Controls.Add(Label11)
        GroupBox4.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox4.Location = New Point(546, 237)
        GroupBox4.Margin = New Padding(4, 3, 4, 3)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Padding = New Padding(4, 3, 4, 3)
        GroupBox4.Size = New Size(458, 214)
        GroupBox4.TabIndex = 1
        GroupBox4.TabStop = False
        GroupBox4.Text = "Output"
        ' 
        ' CostTextBox
        ' 
        CostTextBox.Location = New Point(235, 25)
        CostTextBox.Name = "CostTextBox"
        CostTextBox.RightToLeft = RightToLeft.Yes
        CostTextBox.Size = New Size(144, 30)
        CostTextBox.TabIndex = 11
        CostTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' TaxDueTextBox
        ' 
        TaxDueTextBox.Location = New Point(235, 73)
        TaxDueTextBox.Name = "TaxDueTextBox"
        TaxDueTextBox.RightToLeft = RightToLeft.Yes
        TaxDueTextBox.Size = New Size(144, 30)
        TaxDueTextBox.TabIndex = 10
        TaxDueTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' ShippingTextBox
        ' 
        ShippingTextBox.Location = New Point(235, 121)
        ShippingTextBox.Name = "ShippingTextBox"
        ShippingTextBox.RightToLeft = RightToLeft.Yes
        ShippingTextBox.Size = New Size(144, 30)
        ShippingTextBox.TabIndex = 9
        ShippingTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' TotalTextBox
        ' 
        TotalTextBox.Location = New Point(235, 167)
        TotalTextBox.Name = "TotalTextBox"
        TotalTextBox.RightToLeft = RightToLeft.Yes
        TotalTextBox.Size = New Size(144, 30)
        TotalTextBox.TabIndex = 8
        TotalTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(26, 32)
        Label8.Name = "Label8"
        Label8.Size = New Size(48, 23)
        Label8.TabIndex = 7
        Label8.Text = "Cost:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(26, 73)
        Label9.Name = "Label9"
        Label9.Size = New Size(75, 23)
        Label9.TabIndex = 6
        Label9.Text = "Tax Due:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(26, 128)
        Label10.Name = "Label10"
        Label10.Size = New Size(158, 23)
        Label10.TabIndex = 5
        Label10.Text = "Shipping/Handling:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(26, 174)
        Label11.Name = "Label11"
        Label11.Size = New Size(50, 23)
        Label11.TabIndex = 4
        Label11.Text = "Total:"
        ' 
        ' ComputeButton
        ' 
        ComputeButton.Location = New Point(35, 457)
        ComputeButton.Margin = New Padding(4, 3, 4, 3)
        ComputeButton.Name = "ComputeButton"
        ComputeButton.Size = New Size(117, 34)
        ComputeButton.TabIndex = 2
        ComputeButton.Text = "Compute"
        ComputeButton.UseVisualStyleBackColor = True
        ' 
        ' NewOrderButton
        ' 
        NewOrderButton.Location = New Point(230, 457)
        NewOrderButton.Margin = New Padding(4, 3, 4, 3)
        NewOrderButton.Name = "NewOrderButton"
        NewOrderButton.Size = New Size(117, 34)
        NewOrderButton.TabIndex = 3
        NewOrderButton.Text = "New Order"
        NewOrderButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(723, 467)
        ExitButton.Margin = New Padding(4, 3, 4, 3)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(117, 34)
        ExitButton.TabIndex = 4
        ExitButton.Text = "Exit"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1151, 567)
        Controls.Add(ExitButton)
        Controls.Add(NewOrderButton)
        Controls.Add(ComputeButton)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ComputeButton As Button
    Friend WithEvents NewOrderButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents WholeSaleCheckBox As CheckBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents ZipTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents FedXOvernightRadioButton As RadioButton
    Friend WithEvents FedXDayRadioButton As RadioButton
    Friend WithEvents USPostalAirRadioButton As RadioButton
    Friend WithEvents USPostalRadioButton As RadioButton
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents Label As Label
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents WeightTextBox As TextBox
    Friend WithEvents CostTextBox As TextBox
    Friend WithEvents TaxDueTextBox As TextBox
    Friend WithEvents ShippingTextBox As TextBox
    Friend WithEvents TotalTextBox As TextBox

End Class
