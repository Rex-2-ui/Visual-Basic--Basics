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
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        InventoryToolStripMenuItem = New ToolStripMenuItem()
        AddToItemListingToolStripMenuItem = New ToolStripMenuItem()
        ClearItemListingToolStripMenuItem = New ToolStripMenuItem()
        CountItemListingToolStripMenuItem = New ToolStripMenuItem()
        AddItemToComboBoxToolStripMenuItem = New ToolStripMenuItem()
        DeleteComboBoxItemToolStripMenuItem = New ToolStripMenuItem()
        ColorsAndFontsToolStripMenuItem = New ToolStripMenuItem()
        SetBackgroundColorToolStripMenuItem = New ToolStripMenuItem()
        SetFontToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        GroupBox1 = New GroupBox()
        SelectItemComboBox = New ComboBox()
        QtyOfItemTextBox = New TextBox()
        WholeSaleTextBox = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label4 = New Label()
        InventoryItemListBox = New ListBox()
        Label5 = New Label()
        TotalValueTextBox = New TextBox()
        MenuStrip1.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.GradientActiveCaption
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, InventoryToolStripMenuItem, ColorsAndFontsToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(8, 2, 0, 2)
        MenuStrip1.Size = New Size(925, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(46, 24)
        FileToolStripMenuItem.Text = "&File"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(224, 26)
        ExitToolStripMenuItem.Text = " E&xit"
        ' 
        ' InventoryToolStripMenuItem
        ' 
        InventoryToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AddToItemListingToolStripMenuItem, ClearItemListingToolStripMenuItem, CountItemListingToolStripMenuItem, AddItemToComboBoxToolStripMenuItem, DeleteComboBoxItemToolStripMenuItem})
        InventoryToolStripMenuItem.Name = "InventoryToolStripMenuItem"
        InventoryToolStripMenuItem.Size = New Size(84, 24)
        InventoryToolStripMenuItem.Text = "&Inventory"
        ' 
        ' AddToItemListingToolStripMenuItem
        ' 
        AddToItemListingToolStripMenuItem.Name = "AddToItemListingToolStripMenuItem"
        AddToItemListingToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.A
        AddToItemListingToolStripMenuItem.Size = New Size(315, 26)
        AddToItemListingToolStripMenuItem.Text = "&Add to Item Listing"
        ' 
        ' ClearItemListingToolStripMenuItem
        ' 
        ClearItemListingToolStripMenuItem.Name = "ClearItemListingToolStripMenuItem"
        ClearItemListingToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.C
        ClearItemListingToolStripMenuItem.Size = New Size(315, 26)
        ClearItemListingToolStripMenuItem.Text = "&Clear Item Listing"
        ' 
        ' CountItemListingToolStripMenuItem
        ' 
        CountItemListingToolStripMenuItem.Name = "CountItemListingToolStripMenuItem"
        CountItemListingToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.O
        CountItemListingToolStripMenuItem.Size = New Size(315, 26)
        CountItemListingToolStripMenuItem.Text = "C&ount Item Listing "
        ' 
        ' AddItemToComboBoxToolStripMenuItem
        ' 
        AddItemToComboBoxToolStripMenuItem.Name = "AddItemToComboBoxToolStripMenuItem"
        AddItemToComboBoxToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.M
        AddItemToComboBoxToolStripMenuItem.Size = New Size(315, 26)
        AddItemToComboBoxToolStripMenuItem.Text = "A&dd Item To Combo Box "
        ' 
        ' DeleteComboBoxItemToolStripMenuItem
        ' 
        DeleteComboBoxItemToolStripMenuItem.Name = "DeleteComboBoxItemToolStripMenuItem"
        DeleteComboBoxItemToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.D
        DeleteComboBoxItemToolStripMenuItem.Size = New Size(315, 26)
        DeleteComboBoxItemToolStripMenuItem.Text = "&Delete Combo Box Item "
        ' 
        ' ColorsAndFontsToolStripMenuItem
        ' 
        ColorsAndFontsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SetBackgroundColorToolStripMenuItem, SetFontToolStripMenuItem})
        ColorsAndFontsToolStripMenuItem.Name = "ColorsAndFontsToolStripMenuItem"
        ColorsAndFontsToolStripMenuItem.Size = New Size(133, 24)
        ColorsAndFontsToolStripMenuItem.Text = "&Colors and Fonts"
        ' 
        ' SetBackgroundColorToolStripMenuItem
        ' 
        SetBackgroundColorToolStripMenuItem.Name = "SetBackgroundColorToolStripMenuItem"
        SetBackgroundColorToolStripMenuItem.Size = New Size(236, 26)
        SetBackgroundColorToolStripMenuItem.Text = "Set &Background Color"
        ' 
        ' SetFontToolStripMenuItem
        ' 
        SetFontToolStripMenuItem.Name = "SetFontToolStripMenuItem"
        SetFontToolStripMenuItem.Size = New Size(236, 26)
        SetFontToolStripMenuItem.Text = "Set &Font"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AboutToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(55, 24)
        HelpToolStripMenuItem.Text = "&Help"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(133, 26)
        AboutToolStripMenuItem.Text = "&About"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(SelectItemComboBox)
        GroupBox1.Controls.Add(QtyOfItemTextBox)
        GroupBox1.Controls.Add(WholeSaleTextBox)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.ForeColor = Color.MediumBlue
        GroupBox1.Location = New Point(74, 64)
        GroupBox1.Margin = New Padding(4, 3, 4, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 3, 4, 3)
        GroupBox1.Size = New Size(651, 212)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Inventory Data"
        ' 
        ' SelectItemComboBox
        ' 
        SelectItemComboBox.FormattingEnabled = True
        SelectItemComboBox.Items.AddRange(New Object() {"TaylorMade R7 Driver RH 10-degree", "TaylorMade R7 Driver LH 10-degree", "TaylorMade R7 Driver RH 9-degree", "Titleist 907D2 Driver RH 9.5-degree", "Titleist 907D2 Driver RH 10.5-degree", "King Cobra HS9 X Driver RH 9-degree", "King Cobra HS9 X Driver LH 9-degree", "Adams Redline RPM Driver RH 10-degree"})
        SelectItemComboBox.Location = New Point(244, 39)
        SelectItemComboBox.Name = "SelectItemComboBox"
        SelectItemComboBox.Size = New Size(388, 31)
        SelectItemComboBox.TabIndex = 0
        ' 
        ' QtyOfItemTextBox
        ' 
        QtyOfItemTextBox.Location = New Point(248, 147)
        QtyOfItemTextBox.Name = "QtyOfItemTextBox"
        QtyOfItemTextBox.Size = New Size(125, 30)
        QtyOfItemTextBox.TabIndex = 4
        QtyOfItemTextBox.Text = "1"
        QtyOfItemTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' WholeSaleTextBox
        ' 
        WholeSaleTextBox.Location = New Point(248, 89)
        WholeSaleTextBox.Name = "WholeSaleTextBox"
        WholeSaleTextBox.Size = New Size(125, 30)
        WholeSaleTextBox.TabIndex = 3
        WholeSaleTextBox.Text = "349.95"
        WholeSaleTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(37, 154)
        Label3.Name = "Label3"
        Label3.Size = New Size(142, 23)
        Label3.TabIndex = 2
        Label3.Text = "Quantity of Item:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(35, 96)
        Label2.Name = "Label2"
        Label2.Size = New Size(131, 23)
        Label2.TabIndex = 1
        Label2.Text = "Wholesale Cost:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(37, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(95, 23)
        Label1.TabIndex = 0
        Label1.Text = "Select Item"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(74, 302)
        Label4.Name = "Label4"
        Label4.Size = New Size(174, 23)
        Label4.TabIndex = 3
        Label4.Text = "Inentory Item Listing:"
        ' 
        ' InventoryItemListBox
        ' 
        InventoryItemListBox.FormattingEnabled = True
        InventoryItemListBox.Location = New Point(74, 328)
        InventoryItemListBox.Name = "InventoryItemListBox"
        InventoryItemListBox.Size = New Size(651, 119)
        InventoryItemListBox.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(388, 478)
        Label5.Name = "Label5"
        Label5.Size = New Size(177, 23)
        Label5.TabIndex = 5
        Label5.Text = "Total Inventory Value:"
        ' 
        ' TotalValueTextBox
        ' 
        TotalValueTextBox.Location = New Point(581, 475)
        TotalValueTextBox.Name = "TotalValueTextBox"
        TotalValueTextBox.ReadOnly = True
        TotalValueTextBox.Size = New Size(125, 30)
        TotalValueTextBox.TabIndex = 6
        TotalValueTextBox.TabStop = False
        TotalValueTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(925, 530)
        Controls.Add(TotalValueTextBox)
        Controls.Add(Label5)
        Controls.Add(InventoryItemListBox)
        Controls.Add(Label4)
        Controls.Add(GroupBox1)
        Controls.Add(MenuStrip1)
        Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MainMenuStrip = MenuStrip1
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorsAndFontsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents QtyOfItemTextBox As TextBox
    Friend WithEvents WholeSaleTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents InventoryItemListBox As ListBox
    Friend WithEvents SelectItemComboBox As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TotalValueTextBox As TextBox
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToItemListingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearItemListingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CountItemListingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddItemToComboBoxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteComboBoxItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SetBackgroundColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SetFontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem

End Class
