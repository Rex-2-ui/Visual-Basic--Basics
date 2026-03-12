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
        components = New ComponentModel.Container()
        CustomerNameLabel = New Label()
        AdressLabel = New Label()
        CityLabel = New Label()
        CustomerNameTextBox = New TextBox()
        AddressTextBox = New TextBox()
        CityTextBox = New TextBox()
        ErrorProvider1 = New ErrorProvider(components)
        ErrorProvider2 = New ErrorProvider(components)
        ErrorProvider3 = New ErrorProvider(components)
        StateCodeTextBox = New TextBox()
        StateCodeLabel = New Label()
        ZipCodeTextBox = New TextBox()
        ZipCodeLabel = New Label()
        DescriptionTextBox = New TextBox()
        Label3 = New Label()
        PriceTextBox = New TextBox()
        Label1 = New Label()
        WeightTextBox = New TextBox()
        Label2 = New Label()
        QuantityTextBox = New TextBox()
        Label4 = New Label()
        ErrorProvider4 = New ErrorProvider(components)
        ErrorProvider5 = New ErrorProvider(components)
        ErrorProvider6 = New ErrorProvider(components)
        ErrorProvider7 = New ErrorProvider(components)
        ErrorProvider8 = New ErrorProvider(components)
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider2, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider3, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider4, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider5, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider6, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider7, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider8, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' CustomerNameLabel
        ' 
        CustomerNameLabel.AutoSize = True
        CustomerNameLabel.Location = New Point(71, 52)
        CustomerNameLabel.Name = "CustomerNameLabel"
        CustomerNameLabel.Size = New Size(117, 20)
        CustomerNameLabel.TabIndex = 0
        CustomerNameLabel.Text = "Customer name "
        ' 
        ' AdressLabel
        ' 
        AdressLabel.AutoSize = True
        AdressLabel.Enabled = False
        AdressLabel.Location = New Point(71, 101)
        AdressLabel.Name = "AdressLabel"
        AdressLabel.Size = New Size(62, 20)
        AdressLabel.TabIndex = 1
        AdressLabel.Text = "Address"
        ' 
        ' CityLabel
        ' 
        CityLabel.AutoSize = True
        CityLabel.Location = New Point(71, 150)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New Size(34, 20)
        CityLabel.TabIndex = 2
        CityLabel.Text = "City"
        ' 
        ' CustomerNameTextBox
        ' 
        CustomerNameTextBox.Location = New Point(210, 45)
        CustomerNameTextBox.Name = "CustomerNameTextBox"
        CustomerNameTextBox.Size = New Size(169, 27)
        CustomerNameTextBox.TabIndex = 3
        ' 
        ' AddressTextBox
        ' 
        AddressTextBox.Location = New Point(210, 94)
        AddressTextBox.Name = "AddressTextBox"
        AddressTextBox.Size = New Size(169, 27)
        AddressTextBox.TabIndex = 4
        ' 
        ' CityTextBox
        ' 
        CityTextBox.Location = New Point(210, 147)
        CityTextBox.Name = "CityTextBox"
        CityTextBox.Size = New Size(169, 27)
        CityTextBox.TabIndex = 5
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' ErrorProvider2
        ' 
        ErrorProvider2.ContainerControl = Me
        ' 
        ' ErrorProvider3
        ' 
        ErrorProvider3.ContainerControl = Me
        ' 
        ' StateCodeTextBox
        ' 
        StateCodeTextBox.Location = New Point(209, 198)
        StateCodeTextBox.Name = "StateCodeTextBox"
        StateCodeTextBox.Size = New Size(169, 27)
        StateCodeTextBox.TabIndex = 7
        ' 
        ' StateCodeLabel
        ' 
        StateCodeLabel.AutoSize = True
        StateCodeLabel.Location = New Point(71, 198)
        StateCodeLabel.Name = "StateCodeLabel"
        StateCodeLabel.Size = New Size(78, 20)
        StateCodeLabel.TabIndex = 6
        StateCodeLabel.Text = "StateCode"
        ' 
        ' ZipCodeTextBox
        ' 
        ZipCodeTextBox.Location = New Point(206, 250)
        ZipCodeTextBox.Name = "ZipCodeTextBox"
        ZipCodeTextBox.Size = New Size(169, 27)
        ZipCodeTextBox.TabIndex = 9
        ' 
        ' ZipCodeLabel
        ' 
        ZipCodeLabel.AutoSize = True
        ZipCodeLabel.Location = New Point(71, 253)
        ZipCodeLabel.Name = "ZipCodeLabel"
        ZipCodeLabel.Size = New Size(66, 20)
        ZipCodeLabel.TabIndex = 8
        ZipCodeLabel.Text = "ZipCode"
        ' 
        ' DescriptionTextBox
        ' 
        DescriptionTextBox.Location = New Point(210, 315)
        DescriptionTextBox.Name = "DescriptionTextBox"
        DescriptionTextBox.Size = New Size(169, 27)
        DescriptionTextBox.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(71, 318)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 20)
        Label3.TabIndex = 10
        Label3.Text = "Description"
        ' 
        ' PriceTextBox
        ' 
        PriceTextBox.Location = New Point(210, 366)
        PriceTextBox.Name = "PriceTextBox"
        PriceTextBox.Size = New Size(169, 27)
        PriceTextBox.TabIndex = 13
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(71, 368)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 20)
        Label1.TabIndex = 12
        Label1.Text = "Price"
        ' 
        ' WeightTextBox
        ' 
        WeightTextBox.Location = New Point(210, 426)
        WeightTextBox.Name = "WeightTextBox"
        WeightTextBox.Size = New Size(169, 27)
        WeightTextBox.TabIndex = 15
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(71, 429)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 20)
        Label2.TabIndex = 14
        Label2.Text = "Weight"
        ' 
        ' QuantityTextBox
        ' 
        QuantityTextBox.Location = New Point(203, 487)
        QuantityTextBox.Name = "QuantityTextBox"
        QuantityTextBox.Size = New Size(169, 27)
        QuantityTextBox.TabIndex = 17
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(64, 490)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 20)
        Label4.TabIndex = 16
        Label4.Text = "Quatity"
        ' 
        ' ErrorProvider4
        ' 
        ErrorProvider4.ContainerControl = Me
        ' 
        ' ErrorProvider5
        ' 
        ErrorProvider5.ContainerControl = Me
        ' 
        ' ErrorProvider6
        ' 
        ErrorProvider6.ContainerControl = Me
        ' 
        ' ErrorProvider7
        ' 
        ErrorProvider7.ContainerControl = Me
        ' 
        ' ErrorProvider8
        ' 
        ErrorProvider8.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1112, 696)
        Controls.Add(QuantityTextBox)
        Controls.Add(Label4)
        Controls.Add(WeightTextBox)
        Controls.Add(Label2)
        Controls.Add(PriceTextBox)
        Controls.Add(Label1)
        Controls.Add(DescriptionTextBox)
        Controls.Add(Label3)
        Controls.Add(ZipCodeTextBox)
        Controls.Add(ZipCodeLabel)
        Controls.Add(StateCodeTextBox)
        Controls.Add(StateCodeLabel)
        Controls.Add(CityTextBox)
        Controls.Add(AddressTextBox)
        Controls.Add(CustomerNameTextBox)
        Controls.Add(CityLabel)
        Controls.Add(AdressLabel)
        Controls.Add(CustomerNameLabel)
        Name = "Form1"
        Text = "Form1"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider2, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider3, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider4, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider5, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider6, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider7, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider8, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CustomerNameLabel As Label
    Friend WithEvents AdressLabel As Label
    Friend WithEvents CityLabel As Label
    Friend WithEvents CustomerNameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents ErrorProvider3 As ErrorProvider
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ZipCodeTextBox As TextBox
    Friend WithEvents ZipCodeLabel As Label
    Friend WithEvents StateCodeTextBox As TextBox
    Friend WithEvents StateCodeLabel As Label
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents WeightTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ErrorProvider4 As ErrorProvider
    Friend WithEvents ErrorProvider5 As ErrorProvider
    Friend WithEvents ErrorProvider6 As ErrorProvider
    Friend WithEvents ErrorProvider7 As ErrorProvider
    Friend WithEvents ErrorProvider8 As ErrorProvider

End Class
