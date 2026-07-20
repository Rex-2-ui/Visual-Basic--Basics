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

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        exitToolStripMenuItem = New ToolStripMenuItem()
        maintainPartsToolStripMenuItem = New ToolStripMenuItem()
        addPartToComboToolStripMenuItem = New ToolStripMenuItem()
        deletePartFromComboToolStripMenuItem = New ToolStripMenuItem()
        addPartToListBoxToolStripMenuItem = New ToolStripMenuItem()
        clearPartListBoxToolStripMenuItem = New ToolStripMenuItem()
        countPartsInListBoxToolStripMenuItem = New ToolStripMenuItem()
        helpToolStripMenuItem = New ToolStripMenuItem()
        aboutToolStripMenuItem = New ToolStripMenuItem()
        lstParts = New ListBox()
        lblOrderTotal = New Label()
        txtOrderTotal = New TextBox()
        GroupBox1 = New GroupBox()
        txtQuantity = New TextBox()
        lblQuantity = New Label()
        txtPrice = New TextBox()
        lblPrice = New Label()
        cmbDescription = New ComboBox()
        lblDescription = New Label()
        MenuStrip1.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, maintainPartsToolStripMenuItem, helpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(760, 31)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {exitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(50, 27)
        FileToolStripMenuItem.Text = "&File"
        ' 
        ' exitToolStripMenuItem
        ' 
        exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        exitToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.X
        exitToolStripMenuItem.Size = New Size(182, 28)
        exitToolStripMenuItem.Text = "E&xit"
        ' 
        ' maintainPartsToolStripMenuItem
        ' 
        maintainPartsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {addPartToComboToolStripMenuItem, deletePartFromComboToolStripMenuItem, addPartToListBoxToolStripMenuItem, clearPartListBoxToolStripMenuItem, countPartsInListBoxToolStripMenuItem})
        maintainPartsToolStripMenuItem.Name = "maintainPartsToolStripMenuItem"
        maintainPartsToolStripMenuItem.Size = New Size(135, 27)
        maintainPartsToolStripMenuItem.Text = "&Maintain Parts"
        ' 
        ' addPartToComboToolStripMenuItem
        ' 
        addPartToComboToolStripMenuItem.Name = "addPartToComboToolStripMenuItem"
        addPartToComboToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.M
        addPartToComboToolStripMenuItem.Size = New Size(372, 28)
        addPartToComboToolStripMenuItem.Text = "Add Part to Co&mboBox"
        ' 
        ' deletePartFromComboToolStripMenuItem
        ' 
        deletePartFromComboToolStripMenuItem.Name = "deletePartFromComboToolStripMenuItem"
        deletePartFromComboToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.D
        deletePartFromComboToolStripMenuItem.Size = New Size(372, 28)
        deletePartFromComboToolStripMenuItem.Text = "&Delete Part from ComboBox"
        ' 
        ' addPartToListBoxToolStripMenuItem
        ' 
        addPartToListBoxToolStripMenuItem.Name = "addPartToListBoxToolStripMenuItem"
        addPartToListBoxToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.A
        addPartToListBoxToolStripMenuItem.Size = New Size(372, 28)
        addPartToListBoxToolStripMenuItem.Text = "&Add Part to ListBox"
        ' 
        ' clearPartListBoxToolStripMenuItem
        ' 
        clearPartListBoxToolStripMenuItem.Name = "clearPartListBoxToolStripMenuItem"
        clearPartListBoxToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.C
        clearPartListBoxToolStripMenuItem.Size = New Size(372, 28)
        clearPartListBoxToolStripMenuItem.Text = "&Clear Part ListBox"
        ' 
        ' countPartsInListBoxToolStripMenuItem
        ' 
        countPartsInListBoxToolStripMenuItem.Name = "countPartsInListBoxToolStripMenuItem"
        countPartsInListBoxToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.O
        countPartsInListBoxToolStripMenuItem.Size = New Size(372, 28)
        countPartsInListBoxToolStripMenuItem.Text = "C&ount Parts in ListBox"
        ' 
        ' helpToolStripMenuItem
        ' 
        helpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {aboutToolStripMenuItem})
        helpToolStripMenuItem.Name = "helpToolStripMenuItem"
        helpToolStripMenuItem.Size = New Size(60, 27)
        helpToolStripMenuItem.Text = "&Help"
        ' 
        ' aboutToolStripMenuItem
        ' 
        aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
        aboutToolStripMenuItem.Size = New Size(141, 28)
        aboutToolStripMenuItem.Text = "&About"
        ' 
        ' lstParts
        ' 
        lstParts.Font = New Font("Consolas", 9.0F)
        lstParts.FormattingEnabled = True
        lstParts.HorizontalScrollbar = True
        lstParts.Location = New Point(18, 188)
        lstParts.Name = "lstParts"
        lstParts.Size = New Size(720, 184)
        lstParts.TabIndex = 7
        ' 
        ' lblOrderTotal
        ' 
        lblOrderTotal.AutoSize = True
        lblOrderTotal.Location = New Point(433, 401)
        lblOrderTotal.Name = "lblOrderTotal"
        lblOrderTotal.Size = New Size(95, 23)
        lblOrderTotal.TabIndex = 8
        lblOrderTotal.Text = "Order Total"
        ' 
        ' txtOrderTotal
        ' 
        txtOrderTotal.Location = New Point(550, 391)
        txtOrderTotal.Name = "txtOrderTotal"
        txtOrderTotal.ReadOnly = True
        txtOrderTotal.Size = New Size(140, 30)
        txtOrderTotal.TabIndex = 9
        txtOrderTotal.TabStop = False
        txtOrderTotal.TextAlign = HorizontalAlignment.Right
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtQuantity)
        GroupBox1.Controls.Add(lblQuantity)
        GroupBox1.Controls.Add(txtPrice)
        GroupBox1.Controls.Add(lblPrice)
        GroupBox1.Controls.Add(cmbDescription)
        GroupBox1.Controls.Add(lblDescription)
        GroupBox1.Location = New Point(18, 49)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(720, 133)
        GroupBox1.TabIndex = 10
        GroupBox1.TabStop = False
        GroupBox1.Text = "Part and Order Information"
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(571, 69)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(120, 30)
        txtQuantity.TabIndex = 12
        txtQuantity.TextAlign = HorizontalAlignment.Right
        ' 
        ' lblQuantity
        ' 
        lblQuantity.AutoSize = True
        lblQuantity.Location = New Point(378, 69)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(191, 23)
        lblQuantity.TabIndex = 11
        lblQuantity.Text = "Quantity to be shipped:"
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(160, 69)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(120, 30)
        txtPrice.TabIndex = 10
        txtPrice.TextAlign = HorizontalAlignment.Right
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.Location = New Point(30, 69)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(90, 23)
        lblPrice.TabIndex = 9
        lblPrice.Text = "Sales Price"
        ' 
        ' cmbDescription
        ' 
        cmbDescription.FormattingEnabled = True
        cmbDescription.Items.AddRange(New Object() {"Brake Pads", "Engine", "Injector", "Oil Filter", "Tire", "Transmission", "Wheel Rim"})
        cmbDescription.Location = New Point(160, 26)
        cmbDescription.Name = "cmbDescription"
        cmbDescription.Size = New Size(531, 31)
        cmbDescription.TabIndex = 8
        ' 
        ' lblDescription
        ' 
        lblDescription.AutoSize = True
        lblDescription.Location = New Point(30, 29)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(96, 23)
        lblDescription.TabIndex = 7
        lblDescription.Text = "Description"
        ' 
        ' Form1
        ' 
        ClientSize = New Size(760, 430)
        Controls.Add(GroupBox1)
        Controls.Add(txtOrderTotal)
        Controls.Add(lblOrderTotal)
        Controls.Add(lstParts)
        Controls.Add(MenuStrip1)
        Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Auto Parts Order"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents exitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents maintainPartsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents addPartToComboToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents deletePartFromComboToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents addPartToListBoxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents clearPartListBoxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents countPartsInListBoxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents helpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents aboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lstParts As ListBox
    Friend WithEvents lblOrderTotal As Label
    Friend WithEvents txtOrderTotal As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents cmbDescription As ComboBox
    Friend WithEvents lblDescription As Label
End Class
