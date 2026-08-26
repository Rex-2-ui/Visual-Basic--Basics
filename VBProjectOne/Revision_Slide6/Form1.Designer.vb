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
        SelectedEmployeeListBox = New ListBox()
        GroupBox1 = New GroupBox()
        EmployeeNameTextBox = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        DepartmentComboBox = New ComboBox()
        TitleComboBox = New ComboBox()
        Label4 = New Label()
        AnnualSaleryTextBox = New TextBox()
        FileToolStripMenuItem = New ToolStripMenuItem()
        EmployeeToolStripMenuItem = New ToolStripMenuItem()
        DepartmentToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        CountToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        AddEmployeeToolStripMenuItem = New ToolStripMenuItem()
        ResetEmployeeToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        ClearEmployeeListToolStripMenuItem = New ToolStripMenuItem()
        DisplaySelectedEmployeeToolStripMenuItem = New ToolStripMenuItem()
        AddDepartmentToolStripMenuItem = New ToolStripMenuItem()
        CountDeparmentsToolStripMenuItem = New ToolStripMenuItem()
        RemoveDepartmentToolStripMenuItem = New ToolStripMenuItem()
        RemoveAtDepartmentToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, EmployeeToolStripMenuItem, DepartmentToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(847, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' SelectedEmployeeListBox
        ' 
        SelectedEmployeeListBox.FormattingEnabled = True
        SelectedEmployeeListBox.Location = New Point(51, 339)
        SelectedEmployeeListBox.Name = "SelectedEmployeeListBox"
        SelectedEmployeeListBox.Size = New Size(677, 124)
        SelectedEmployeeListBox.Sorted = True
        SelectedEmployeeListBox.TabIndex = 3
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(AnnualSaleryTextBox)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(EmployeeNameTextBox)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(DepartmentComboBox)
        GroupBox1.Controls.Add(TitleComboBox)
        GroupBox1.Location = New Point(37, 46)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(725, 237)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' EmployeeNameTextBox
        ' 
        EmployeeNameTextBox.Location = New Point(265, 48)
        EmployeeNameTextBox.Name = "EmployeeNameTextBox"
        EmployeeNameTextBox.Size = New Size(245, 27)
        EmployeeNameTextBox.TabIndex = 14
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(24, 154)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 20)
        Label3.TabIndex = 13
        Label3.Text = "Department"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(24, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 20)
        Label2.TabIndex = 12
        Label2.Text = "Title:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(24, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 20)
        Label1.TabIndex = 11
        Label1.Text = "Employee Name:"
        ' 
        ' DepartmentComboBox
        ' 
        DepartmentComboBox.FormattingEnabled = True
        DepartmentComboBox.Items.AddRange(New Object() {"", "Accounting", "CMIS", "Economics & Finance", "Management & Marketing"})
        DepartmentComboBox.Location = New Point(265, 146)
        DepartmentComboBox.Name = "DepartmentComboBox"
        DepartmentComboBox.Size = New Size(245, 28)
        DepartmentComboBox.Sorted = True
        DepartmentComboBox.TabIndex = 10
        ' 
        ' TitleComboBox
        ' 
        TitleComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        TitleComboBox.FormattingEnabled = True
        TitleComboBox.Items.AddRange(New Object() {"Assistant Professor", "Associate Professor", "Lecturer", "Professor"})
        TitleComboBox.Location = New Point(265, 97)
        TitleComboBox.Name = "TitleComboBox"
        TitleComboBox.Size = New Size(245, 28)
        TitleComboBox.Sorted = True
        TitleComboBox.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(24, 200)
        Label4.Name = "Label4"
        Label4.Size = New Size(102, 20)
        Label4.TabIndex = 15
        Label4.Text = "Annual Salary:"
        ' 
        ' AnnualSaleryTextBox
        ' 
        AnnualSaleryTextBox.Location = New Point(265, 197)
        AnnualSaleryTextBox.Name = "AnnualSaleryTextBox"
        AnnualSaleryTextBox.Size = New Size(245, 27)
        AnnualSaleryTextBox.TabIndex = 16
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CountToolStripMenuItem, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(46, 24)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' EmployeeToolStripMenuItem
        ' 
        EmployeeToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AddEmployeeToolStripMenuItem, ResetEmployeeToolStripMenuItem, ToolStripSeparator1, ClearEmployeeListToolStripMenuItem, DisplaySelectedEmployeeToolStripMenuItem})
        EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        EmployeeToolStripMenuItem.Size = New Size(89, 24)
        EmployeeToolStripMenuItem.Text = "Employee"
        ' 
        ' DepartmentToolStripMenuItem
        ' 
        DepartmentToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AddDepartmentToolStripMenuItem, CountDeparmentsToolStripMenuItem, RemoveDepartmentToolStripMenuItem, RemoveAtDepartmentToolStripMenuItem})
        DepartmentToolStripMenuItem.Name = "DepartmentToolStripMenuItem"
        DepartmentToolStripMenuItem.Size = New Size(103, 24)
        DepartmentToolStripMenuItem.Text = "Department"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AboutToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(55, 24)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' CountToolStripMenuItem
        ' 
        CountToolStripMenuItem.Name = "CountToolStripMenuItem"
        CountToolStripMenuItem.Size = New Size(224, 26)
        CountToolStripMenuItem.Text = "Count"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(224, 26)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' AddEmployeeToolStripMenuItem
        ' 
        AddEmployeeToolStripMenuItem.Name = "AddEmployeeToolStripMenuItem"
        AddEmployeeToolStripMenuItem.Size = New Size(272, 26)
        AddEmployeeToolStripMenuItem.Text = "Add Employee"
        ' 
        ' ResetEmployeeToolStripMenuItem
        ' 
        ResetEmployeeToolStripMenuItem.Name = "ResetEmployeeToolStripMenuItem"
        ResetEmployeeToolStripMenuItem.Size = New Size(272, 26)
        ResetEmployeeToolStripMenuItem.Text = "Reset Employee"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(269, 6)
        ' 
        ' ClearEmployeeListToolStripMenuItem
        ' 
        ClearEmployeeListToolStripMenuItem.Name = "ClearEmployeeListToolStripMenuItem"
        ClearEmployeeListToolStripMenuItem.Size = New Size(272, 26)
        ClearEmployeeListToolStripMenuItem.Text = "Clear Employee List"
        ' 
        ' DisplaySelectedEmployeeToolStripMenuItem
        ' 
        DisplaySelectedEmployeeToolStripMenuItem.Name = "DisplaySelectedEmployeeToolStripMenuItem"
        DisplaySelectedEmployeeToolStripMenuItem.Size = New Size(272, 26)
        DisplaySelectedEmployeeToolStripMenuItem.Text = "Display Selected Employee"
        ' 
        ' AddDepartmentToolStripMenuItem
        ' 
        AddDepartmentToolStripMenuItem.Name = "AddDepartmentToolStripMenuItem"
        AddDepartmentToolStripMenuItem.Size = New Size(255, 26)
        AddDepartmentToolStripMenuItem.Text = "Add Department"
        ' 
        ' CountDeparmentsToolStripMenuItem
        ' 
        CountDeparmentsToolStripMenuItem.Name = "CountDeparmentsToolStripMenuItem"
        CountDeparmentsToolStripMenuItem.Size = New Size(255, 26)
        CountDeparmentsToolStripMenuItem.Text = "Count Deparments"
        ' 
        ' RemoveDepartmentToolStripMenuItem
        ' 
        RemoveDepartmentToolStripMenuItem.Name = "RemoveDepartmentToolStripMenuItem"
        RemoveDepartmentToolStripMenuItem.Size = New Size(255, 26)
        RemoveDepartmentToolStripMenuItem.Text = "Remove Department"
        ' 
        ' RemoveAtDepartmentToolStripMenuItem
        ' 
        RemoveAtDepartmentToolStripMenuItem.Name = "RemoveAtDepartmentToolStripMenuItem"
        RemoveAtDepartmentToolStripMenuItem.Size = New Size(255, 26)
        RemoveAtDepartmentToolStripMenuItem.Text = "Remove At \Department"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(224, 26)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(847, 571)
        Controls.Add(GroupBox1)
        Controls.Add(SelectedEmployeeListBox)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SelectedEmployeeListBox As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents EmployeeNameTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DepartmentComboBox As ComboBox
    Friend WithEvents TitleComboBox As ComboBox
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepartmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnnualSaleryTextBox As TextBox
    Friend WithEvents CountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ClearEmployeeListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplaySelectedEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddDepartmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CountDeparmentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveDepartmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveAtDepartmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem

End Class
