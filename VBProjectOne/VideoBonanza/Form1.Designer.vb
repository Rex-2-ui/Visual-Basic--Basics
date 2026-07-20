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
        MovieTitleTextBox = New TextBox()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        VideoTapeRadioButton = New RadioButton()
        DVDRadioButton = New RadioButton()
        MemberCheckBox = New CheckBox()
        NewReleasesCheckBox = New CheckBox()
        CalculateButton = New Button()
        ClearItemButton = New Button()
        OrderCompleteButton = New Button()
        SummaryButton = New Button()
        ExitButton = New Button()
        ItemAmountTextBox = New TextBox()
        SubTotalTextBox = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        SummaryToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        EditToolStripMenuItem = New ToolStripMenuItem()
        CalculateToolStripMenuItem = New ToolStripMenuItem()
        ClearForNextItemToolStripMenuItem = New ToolStripMenuItem()
        OrderCompleteToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        FontToolStripMenuItem = New ToolStripMenuItem()
        ColorToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        GroupBox1.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MovieTitleTextBox
        ' 
        MovieTitleTextBox.Location = New Point(242, 49)
        MovieTitleTextBox.Margin = New Padding(4, 3, 4, 3)
        MovieTitleTextBox.Name = "MovieTitleTextBox"
        MovieTitleTextBox.Size = New Size(268, 30)
        MovieTitleTextBox.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(55, 49)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 23)
        Label1.TabIndex = 1
        Label1.Text = "Movie Ttle"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(VideoTapeRadioButton)
        GroupBox1.Controls.Add(DVDRadioButton)
        GroupBox1.Location = New Point(35, 118)
        GroupBox1.Margin = New Padding(4, 3, 4, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 3, 4, 3)
        GroupBox1.Size = New Size(312, 144)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Format"
        ' 
        ' VideoTapeRadioButton
        ' 
        VideoTapeRadioButton.AutoSize = True
        VideoTapeRadioButton.Location = New Point(11, 100)
        VideoTapeRadioButton.Margin = New Padding(4, 3, 4, 3)
        VideoTapeRadioButton.Name = "VideoTapeRadioButton"
        VideoTapeRadioButton.Size = New Size(115, 27)
        VideoTapeRadioButton.TabIndex = 1
        VideoTapeRadioButton.TabStop = True
        VideoTapeRadioButton.Text = "Video Tape"
        VideoTapeRadioButton.UseVisualStyleBackColor = True
        ' 
        ' DVDRadioButton
        ' 
        DVDRadioButton.AutoSize = True
        DVDRadioButton.Location = New Point(16, 45)
        DVDRadioButton.Margin = New Padding(4, 3, 4, 3)
        DVDRadioButton.Name = "DVDRadioButton"
        DVDRadioButton.Size = New Size(66, 27)
        DVDRadioButton.TabIndex = 0
        DVDRadioButton.TabStop = True
        DVDRadioButton.Text = "DVD"
        DVDRadioButton.UseVisualStyleBackColor = True
        ' 
        ' MemberCheckBox
        ' 
        MemberCheckBox.AutoSize = True
        MemberCheckBox.Location = New Point(448, 139)
        MemberCheckBox.Margin = New Padding(4, 3, 4, 3)
        MemberCheckBox.Name = "MemberCheckBox"
        MemberCheckBox.Size = New Size(214, 27)
        MemberCheckBox.TabIndex = 3
        MemberCheckBox.Text = "Member (10% discount)"
        MemberCheckBox.UseVisualStyleBackColor = True
        ' 
        ' NewReleasesCheckBox
        ' 
        NewReleasesCheckBox.AutoSize = True
        NewReleasesCheckBox.Location = New Point(448, 217)
        NewReleasesCheckBox.Margin = New Padding(4, 3, 4, 3)
        NewReleasesCheckBox.Name = "NewReleasesCheckBox"
        NewReleasesCheckBox.Size = New Size(137, 27)
        NewReleasesCheckBox.TabIndex = 4
        NewReleasesCheckBox.Text = "New Releases"
        NewReleasesCheckBox.UseVisualStyleBackColor = True
        ' 
        ' CalculateButton
        ' 
        CalculateButton.Location = New Point(12, 398)
        CalculateButton.Name = "CalculateButton"
        CalculateButton.Size = New Size(94, 29)
        CalculateButton.TabIndex = 5
        CalculateButton.Text = "Calculate"
        CalculateButton.UseVisualStyleBackColor = True
        ' 
        ' ClearItemButton
        ' 
        ClearItemButton.Location = New Point(136, 398)
        ClearItemButton.Name = "ClearItemButton"
        ClearItemButton.Size = New Size(134, 29)
        ClearItemButton.TabIndex = 6
        ClearItemButton.Text = "Clear Item"
        ClearItemButton.UseVisualStyleBackColor = True
        ' 
        ' OrderCompleteButton
        ' 
        OrderCompleteButton.Location = New Point(298, 398)
        OrderCompleteButton.Name = "OrderCompleteButton"
        OrderCompleteButton.Size = New Size(94, 29)
        OrderCompleteButton.TabIndex = 7
        OrderCompleteButton.Text = "Order Complete"
        OrderCompleteButton.UseVisualStyleBackColor = True
        ' 
        ' SummaryButton
        ' 
        SummaryButton.Location = New Point(448, 398)
        SummaryButton.Name = "SummaryButton"
        SummaryButton.Size = New Size(94, 29)
        SummaryButton.TabIndex = 8
        SummaryButton.Text = "Summary"
        SummaryButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(581, 398)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(94, 29)
        ExitButton.TabIndex = 9
        ExitButton.Text = "Exit"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' ItemAmountTextBox
        ' 
        ItemAmountTextBox.Location = New Point(207, 320)
        ItemAmountTextBox.Name = "ItemAmountTextBox"
        ItemAmountTextBox.ReadOnly = True
        ItemAmountTextBox.Size = New Size(125, 30)
        ItemAmountTextBox.TabIndex = 10
        ' 
        ' SubTotalTextBox
        ' 
        SubTotalTextBox.Location = New Point(550, 316)
        SubTotalTextBox.Name = "SubTotalTextBox"
        SubTotalTextBox.ReadOnly = True
        SubTotalTextBox.Size = New Size(125, 30)
        SubTotalTextBox.TabIndex = 11
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(35, 323)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 23)
        Label2.TabIndex = 12
        Label2.Text = "Item Amount"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(422, 323)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 23)
        Label3.TabIndex = 13
        Label3.Text = "SubTotal"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, EditToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(956, 31)
        MenuStrip1.TabIndex = 14
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SummaryToolStripMenuItem, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.F
        FileToolStripMenuItem.Size = New Size(50, 27)
        FileToolStripMenuItem.Text = "&File"
        ' 
        ' SummaryToolStripMenuItem
        ' 
        SummaryToolStripMenuItem.Name = "SummaryToolStripMenuItem"
        SummaryToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.S
        SummaryToolStripMenuItem.Size = New Size(226, 28)
        SummaryToolStripMenuItem.Text = "&Summary"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.E
        ExitToolStripMenuItem.Size = New Size(226, 28)
        ExitToolStripMenuItem.Text = "&Exit"
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CalculateToolStripMenuItem, ClearForNextItemToolStripMenuItem, OrderCompleteToolStripMenuItem, ToolStripSeparator1, FontToolStripMenuItem, ColorToolStripMenuItem})
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(53, 27)
        EditToolStripMenuItem.Text = "&Edit"
        ' 
        ' CalculateToolStripMenuItem
        ' 
        CalculateToolStripMenuItem.Name = "CalculateToolStripMenuItem"
        CalculateToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.A
        CalculateToolStripMenuItem.Size = New Size(305, 28)
        CalculateToolStripMenuItem.Text = "C&alculate"
        ' 
        ' ClearForNextItemToolStripMenuItem
        ' 
        ClearForNextItemToolStripMenuItem.Name = "ClearForNextItemToolStripMenuItem"
        ClearForNextItemToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.A
        ClearForNextItemToolStripMenuItem.Size = New Size(305, 28)
        ClearForNextItemToolStripMenuItem.Text = "C&lear For Next Item"
        ' 
        ' OrderCompleteToolStripMenuItem
        ' 
        OrderCompleteToolStripMenuItem.Name = "OrderCompleteToolStripMenuItem"
        OrderCompleteToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.O
        OrderCompleteToolStripMenuItem.Size = New Size(305, 28)
        OrderCompleteToolStripMenuItem.Text = "&Order Complete"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(242, 6)
        ' 
        ' FontToolStripMenuItem
        ' 
        FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        FontToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.F
        FontToolStripMenuItem.Size = New Size(305, 28)
        FontToolStripMenuItem.Text = "&Font"
        ' 
        ' ColorToolStripMenuItem
        ' 
        ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        ColorToolStripMenuItem.ShortcutKeys = Keys.Alt Or Keys.C
        ColorToolStripMenuItem.Size = New Size(305, 28)
        ColorToolStripMenuItem.Text = "&Color"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AboutToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.ShortcutKeys = Keys.Alt Or Keys.A
        HelpToolStripMenuItem.Size = New Size(60, 27)
        HelpToolStripMenuItem.Text = "&Help"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(141, 28)
        AboutToolStripMenuItem.Text = "&About"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(956, 526)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(SubTotalTextBox)
        Controls.Add(ItemAmountTextBox)
        Controls.Add(ExitButton)
        Controls.Add(SummaryButton)
        Controls.Add(OrderCompleteButton)
        Controls.Add(ClearItemButton)
        Controls.Add(CalculateButton)
        Controls.Add(NewReleasesCheckBox)
        Controls.Add(MemberCheckBox)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Controls.Add(MovieTitleTextBox)
        Controls.Add(MenuStrip1)
        Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MainMenuStrip = MenuStrip1
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MovieTitleTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents VideoTapeRadioButton As RadioButton
    Friend WithEvents DVDRadioButton As RadioButton
    Friend WithEvents MemberCheckBox As CheckBox
    Friend WithEvents NewReleasesCheckBox As CheckBox
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ClearItemButton As Button
    Friend WithEvents OrderCompleteButton As Button
    Friend WithEvents SummaryButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ItemAmountTextBox As TextBox
    Friend WithEvents SubTotalTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SummaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearForNextItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrderCompleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem

End Class
