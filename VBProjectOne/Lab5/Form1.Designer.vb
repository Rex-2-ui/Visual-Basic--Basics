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
        CoffeeComboBox = New ComboBox()
        GroupBox1 = New GroupBox()
        Label2 = New Label()
        Label1 = New Label()
        SyrupListBox = New ListBox()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        PriToolStripMenuItem = New ToolStripMenuItem()
        PrintAllFlavorsToolStripMenuItem = New ToolStripMenuItem()
        PrinterToolStripMenuItem = New ToolStripMenuItem()
        PrintPreviewToolStripMenuItem = New ToolStripMenuItem()
        PrintSelectedPrinterToolStripMenuItem = New ToolStripMenuItem()
        SelectedPrinterToolStripMenuItem = New ToolStripMenuItem()
        PrintPreviewToolStripMenuItem1 = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        EditToolStripMenuItem = New ToolStripMenuItem()
        AddCoffeeFlavorToolStripMenuItem = New ToolStripMenuItem()
        RemoveCoffeeFlavorToolStripMenuItem = New ToolStripMenuItem()
        ClearCoffeeListToolStripMenuItem = New ToolStripMenuItem()
        DisplayCoffeeCountToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        GroupBox1.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' CoffeeComboBox
        ' 
        CoffeeComboBox.FormattingEnabled = True
        CoffeeComboBox.Items.AddRange(New Object() {"Chocolate Almond ", "Espresso Roast", "Jamaica Blue Mountain ", "Kona Blend ", "Vanilla Nut "})
        CoffeeComboBox.Location = New Point(22, 127)
        CoffeeComboBox.Name = "CoffeeComboBox"
        CoffeeComboBox.Size = New Size(209, 31)
        CoffeeComboBox.Sorted = True
        CoffeeComboBox.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(SyrupListBox)
        GroupBox1.Controls.Add(CoffeeComboBox)
        GroupBox1.Location = New Point(14, 71)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(750, 362)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Reading and Refreshment"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        Label2.Location = New Point(442, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 23)
        Label2.TabIndex = 3
        Label2.Text = "Syrup"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        Label1.Location = New Point(84, 71)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 23)
        Label1.TabIndex = 2
        Label1.Text = "Coffee"
        ' 
        ' SyrupListBox
        ' 
        SyrupListBox.FormattingEnabled = True
        SyrupListBox.Items.AddRange(New Object() {"(None)", "Chocolate", "Hazelnut ", "Irish Cream ", "Orange"})
        SyrupListBox.Location = New Point(360, 127)
        SyrupListBox.Name = "SyrupListBox"
        SyrupListBox.Size = New Size(309, 142)
        SyrupListBox.Sorted = True
        SyrupListBox.TabIndex = 1
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, EditToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(7, 2, 0, 2)
        MenuStrip1.Size = New Size(1007, 28)
        MenuStrip1.TabIndex = 2
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PriToolStripMenuItem, ToolStripSeparator1, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(46, 24)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' PriToolStripMenuItem
        ' 
        PriToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PrintAllFlavorsToolStripMenuItem, PrintSelectedPrinterToolStripMenuItem})
        PriToolStripMenuItem.Name = "PriToolStripMenuItem"
        PriToolStripMenuItem.Size = New Size(224, 26)
        PriToolStripMenuItem.Text = "Print"
        ' 
        ' PrintAllFlavorsToolStripMenuItem
        ' 
        PrintAllFlavorsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PrinterToolStripMenuItem, PrintPreviewToolStripMenuItem})
        PrintAllFlavorsToolStripMenuItem.Name = "PrintAllFlavorsToolStripMenuItem"
        PrintAllFlavorsToolStripMenuItem.Size = New Size(233, 26)
        PrintAllFlavorsToolStripMenuItem.Text = "Print All Flavors"
        ' 
        ' PrinterToolStripMenuItem
        ' 
        PrinterToolStripMenuItem.Name = "PrinterToolStripMenuItem"
        PrinterToolStripMenuItem.Size = New Size(177, 26)
        PrinterToolStripMenuItem.Text = "Printer"
        ' 
        ' PrintPreviewToolStripMenuItem
        ' 
        PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        PrintPreviewToolStripMenuItem.Size = New Size(177, 26)
        PrintPreviewToolStripMenuItem.Text = "Print Preview"
        ' 
        ' PrintSelectedPrinterToolStripMenuItem
        ' 
        PrintSelectedPrinterToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SelectedPrinterToolStripMenuItem, PrintPreviewToolStripMenuItem1})
        PrintSelectedPrinterToolStripMenuItem.Name = "PrintSelectedPrinterToolStripMenuItem"
        PrintSelectedPrinterToolStripMenuItem.Size = New Size(233, 26)
        PrintSelectedPrinterToolStripMenuItem.Text = "Print Selected Flavors"
        ' 
        ' SelectedPrinterToolStripMenuItem
        ' 
        SelectedPrinterToolStripMenuItem.Name = "SelectedPrinterToolStripMenuItem"
        SelectedPrinterToolStripMenuItem.Size = New Size(224, 26)
        SelectedPrinterToolStripMenuItem.Text = "Printer "
        ' 
        ' PrintPreviewToolStripMenuItem1
        ' 
        PrintPreviewToolStripMenuItem1.Name = "PrintPreviewToolStripMenuItem1"
        PrintPreviewToolStripMenuItem1.Size = New Size(224, 26)
        PrintPreviewToolStripMenuItem1.Text = "Print Preview"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(221, 6)
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(224, 26)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AddCoffeeFlavorToolStripMenuItem, RemoveCoffeeFlavorToolStripMenuItem, ClearCoffeeListToolStripMenuItem, DisplayCoffeeCountToolStripMenuItem})
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(53, 24)
        EditToolStripMenuItem.Text = "Edit "
        ' 
        ' AddCoffeeFlavorToolStripMenuItem
        ' 
        AddCoffeeFlavorToolStripMenuItem.Name = "AddCoffeeFlavorToolStripMenuItem"
        AddCoffeeFlavorToolStripMenuItem.Size = New Size(238, 26)
        AddCoffeeFlavorToolStripMenuItem.Text = "Add Coffee Flavor"
        ' 
        ' RemoveCoffeeFlavorToolStripMenuItem
        ' 
        RemoveCoffeeFlavorToolStripMenuItem.Name = "RemoveCoffeeFlavorToolStripMenuItem"
        RemoveCoffeeFlavorToolStripMenuItem.Size = New Size(238, 26)
        RemoveCoffeeFlavorToolStripMenuItem.Text = "Remove Coffee Flavor"
        ' 
        ' ClearCoffeeListToolStripMenuItem
        ' 
        ClearCoffeeListToolStripMenuItem.Name = "ClearCoffeeListToolStripMenuItem"
        ClearCoffeeListToolStripMenuItem.Size = New Size(238, 26)
        ClearCoffeeListToolStripMenuItem.Text = "Clear Coffee List"
        ' 
        ' DisplayCoffeeCountToolStripMenuItem
        ' 
        DisplayCoffeeCountToolStripMenuItem.Name = "DisplayCoffeeCountToolStripMenuItem"
        DisplayCoffeeCountToolStripMenuItem.Size = New Size(238, 26)
        DisplayCoffeeCountToolStripMenuItem.Text = "Display Coffee Count"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AboutToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(55, 24)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(224, 26)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1007, 566)
        Controls.Add(GroupBox1)
        Controls.Add(MenuStrip1)
        Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CoffeeComboBox As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SyrupListBox As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintAllFlavorsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrinterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintSelectedPrinterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SelectedPrinterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddCoffeeFlavorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveCoffeeFlavorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearCoffeeListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayCoffeeCountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem

End Class
