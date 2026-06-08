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
        TextBox2 = New TextBox()
        ComboBox2 = New ComboBox()
        ComboBox1 = New ComboBox()
        TextBox1 = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        ListBox1 = New ListBox()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        EmployeeToolStripMenuItem = New ToolStripMenuItem()
        DepartmeToolStripMenuItem = New ToolStripMenuItem()
        CountToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        AddEmployeeToolStripMenuItem = New ToolStripMenuItem()
        ResetEmployeeToolStripMenuItem = New ToolStripMenuItem()
        ClearEmployeeListToolStripMenuItem = New ToolStripMenuItem()
        DisplayToolStripMenuItem = New ToolStripMenuItem()
        AddDepartmentToolStripMenuItem = New ToolStripMenuItem()
        CountDeparmentToolStripMenuItem = New ToolStripMenuItem()
        RemoveDToolStripMenuItem = New ToolStripMenuItem()
        RemoveAtDepartmentToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(ComboBox2)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(44, 37)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(532, 241)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "New Employee Information"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(197, 192)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(194, 27)
        TextBox2.TabIndex = 7
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(197, 144)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(194, 28)
        ComboBox2.TabIndex = 6
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(197, 95)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(194, 28)
        ComboBox1.TabIndex = 5
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(197, 38)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(194, 27)
        TextBox1.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(58, 192)
        Label4.Name = "Label4"
        Label4.Size = New Size(102, 20)
        Label4.TabIndex = 3
        Label4.Text = "Annual Salary:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(58, 144)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 20)
        Label3.TabIndex = 2
        Label3.Text = "Department"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(58, 95)
        Label2.Name = "Label2"
        Label2.Size = New Size(38, 20)
        Label2.TabIndex = 1
        Label2.Text = "Title"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(58, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 20)
        Label1.TabIndex = 0
        Label1.Text = "Employee Name"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(ListBox1)
        GroupBox2.Location = New Point(44, 301)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(472, 138)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Selected Employee"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(30, 28)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(361, 104)
        ListBox1.TabIndex = 0
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, EmployeeToolStripMenuItem, DepartmeToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(712, 28)
        MenuStrip1.TabIndex = 2
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CountToolStripMenuItem, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(46, 24)
        FileToolStripMenuItem.Text = "&File"
        ' 
        ' EmployeeToolStripMenuItem
        ' 
        EmployeeToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AddEmployeeToolStripMenuItem, ResetEmployeeToolStripMenuItem, ClearEmployeeListToolStripMenuItem, DisplayToolStripMenuItem})
        EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        EmployeeToolStripMenuItem.Size = New Size(89, 24)
        EmployeeToolStripMenuItem.Text = "&Employee"
        ' 
        ' DepartmeToolStripMenuItem
        ' 
        DepartmeToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AddDepartmentToolStripMenuItem, CountDeparmentToolStripMenuItem, RemoveDToolStripMenuItem, RemoveAtDepartmentToolStripMenuItem})
        DepartmeToolStripMenuItem.Name = "DepartmeToolStripMenuItem"
        DepartmeToolStripMenuItem.Size = New Size(103, 24)
        DepartmeToolStripMenuItem.Text = "&Department"
        ' 
        ' CountToolStripMenuItem
        ' 
        CountToolStripMenuItem.Name = "CountToolStripMenuItem"
        CountToolStripMenuItem.Size = New Size(224, 26)
        CountToolStripMenuItem.Text = "&Count"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(224, 26)
        ExitToolStripMenuItem.Text = "E&xit"
        ' 
        ' AddEmployeeToolStripMenuItem
        ' 
        AddEmployeeToolStripMenuItem.Name = "AddEmployeeToolStripMenuItem"
        AddEmployeeToolStripMenuItem.Size = New Size(272, 26)
        AddEmployeeToolStripMenuItem.Text = "&Add Employee"
        ' 
        ' ResetEmployeeToolStripMenuItem
        ' 
        ResetEmployeeToolStripMenuItem.Name = "ResetEmployeeToolStripMenuItem"
        ResetEmployeeToolStripMenuItem.Size = New Size(272, 26)
        ResetEmployeeToolStripMenuItem.Text = "&Reset Employee"
        ' 
        ' ClearEmployeeListToolStripMenuItem
        ' 
        ClearEmployeeListToolStripMenuItem.Name = "ClearEmployeeListToolStripMenuItem"
        ClearEmployeeListToolStripMenuItem.Size = New Size(272, 26)
        ClearEmployeeListToolStripMenuItem.Text = "Clear Employee List"
        ' 
        ' DisplayToolStripMenuItem
        ' 
        DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem"
        DisplayToolStripMenuItem.Size = New Size(272, 26)
        DisplayToolStripMenuItem.Text = "Display &Selected Employee"
        ' 
        ' AddDepartmentToolStripMenuItem
        ' 
        AddDepartmentToolStripMenuItem.Name = "AddDepartmentToolStripMenuItem"
        AddDepartmentToolStripMenuItem.Size = New Size(224, 26)
        AddDepartmentToolStripMenuItem.Text = "&Add Department"
        ' 
        ' CountDeparmentToolStripMenuItem
        ' 
        CountDeparmentToolStripMenuItem.Name = "CountDeparmentToolStripMenuItem"
        CountDeparmentToolStripMenuItem.Size = New Size(224, 26)
        CountDeparmentToolStripMenuItem.Text = "&Count Department"
        ' 
        ' RemoveDToolStripMenuItem
        ' 
        RemoveDToolStripMenuItem.Name = "RemoveDToolStripMenuItem"
        RemoveDToolStripMenuItem.Size = New Size(249, 26)
        RemoveDToolStripMenuItem.Text = "&Remove Department"
        ' 
        ' RemoveAtDepartmentToolStripMenuItem
        ' 
        RemoveAtDepartmentToolStripMenuItem.Name = "RemoveAtDepartmentToolStripMenuItem"
        RemoveAtDepartmentToolStripMenuItem.Size = New Size(249, 26)
        RemoveAtDepartmentToolStripMenuItem.Text = "Remove &At Department"
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
        AboutToolStripMenuItem.Size = New Size(224, 26)
        AboutToolStripMenuItem.Text = "&About"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(712, 468)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepartmeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearEmployeeListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddDepartmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CountDeparmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveAtDepartmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem

End Class
