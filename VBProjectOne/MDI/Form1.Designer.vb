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
        CloseToolStripMenuItem1 = New ToolStripMenuItem()
        ExitToolStripMenuItem1 = New ToolStripMenuItem()
        DisplayToolStripMenuItem = New ToolStripMenuItem()
        Form2ToolStripMenuItem = New ToolStripMenuItem()
        Form3ToolStripMenuItem = New ToolStripMenuItem()
        Form4ToolStripMenuItem = New ToolStripMenuItem()
        WindowsToolStripMenuItem = New ToolStripMenuItem()
        CascadeToolStripMenuItem = New ToolStripMenuItem()
        TileToolStripMenuItem = New ToolStripMenuItem()
        HorizontalToolStripMenuItem = New ToolStripMenuItem()
        VerticalToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, DisplayToolStripMenuItem, WindowsToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(925, 28)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CloseToolStripMenuItem1, ExitToolStripMenuItem1})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(46, 24)
        FileToolStripMenuItem.Text = "&File"
        ' 
        ' CloseToolStripMenuItem1
        ' 
        CloseToolStripMenuItem1.Name = "CloseToolStripMenuItem1"
        CloseToolStripMenuItem1.Size = New Size(128, 26)
        CloseToolStripMenuItem1.Text = "Close"
        ' 
        ' ExitToolStripMenuItem1
        ' 
        ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        ExitToolStripMenuItem1.Size = New Size(128, 26)
        ExitToolStripMenuItem1.Text = "Exit"
        ' 
        ' DisplayToolStripMenuItem
        ' 
        DisplayToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {Form2ToolStripMenuItem, Form3ToolStripMenuItem, Form4ToolStripMenuItem})
        DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem"
        DisplayToolStripMenuItem.Size = New Size(72, 24)
        DisplayToolStripMenuItem.Text = "Display"
        ' 
        ' Form2ToolStripMenuItem
        ' 
        Form2ToolStripMenuItem.Name = "Form2ToolStripMenuItem"
        Form2ToolStripMenuItem.Size = New Size(134, 26)
        Form2ToolStripMenuItem.Text = "Form2"
        ' 
        ' Form3ToolStripMenuItem
        ' 
        Form3ToolStripMenuItem.Name = "Form3ToolStripMenuItem"
        Form3ToolStripMenuItem.Size = New Size(134, 26)
        Form3ToolStripMenuItem.Text = "Form3"
        ' 
        ' Form4ToolStripMenuItem
        ' 
        Form4ToolStripMenuItem.Name = "Form4ToolStripMenuItem"
        Form4ToolStripMenuItem.Size = New Size(134, 26)
        Form4ToolStripMenuItem.Text = "Form4"
        ' 
        ' WindowsToolStripMenuItem
        ' 
        WindowsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CascadeToolStripMenuItem, TileToolStripMenuItem})
        WindowsToolStripMenuItem.Name = "WindowsToolStripMenuItem"
        WindowsToolStripMenuItem.Size = New Size(84, 24)
        WindowsToolStripMenuItem.Text = "Windows"
        ' 
        ' CascadeToolStripMenuItem
        ' 
        CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        CascadeToolStripMenuItem.Size = New Size(224, 26)
        CascadeToolStripMenuItem.Text = "Cascade"
        ' 
        ' TileToolStripMenuItem
        ' 
        TileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {HorizontalToolStripMenuItem, VerticalToolStripMenuItem})
        TileToolStripMenuItem.Name = "TileToolStripMenuItem"
        TileToolStripMenuItem.Size = New Size(224, 26)
        TileToolStripMenuItem.Text = "Tile"
        ' 
        ' HorizontalToolStripMenuItem
        ' 
        HorizontalToolStripMenuItem.Name = "HorizontalToolStripMenuItem"
        HorizontalToolStripMenuItem.Size = New Size(224, 26)
        HorizontalToolStripMenuItem.Text = "Horizontal"
        ' 
        ' VerticalToolStripMenuItem
        ' 
        VerticalToolStripMenuItem.Name = "VerticalToolStripMenuItem"
        VerticalToolStripMenuItem.Size = New Size(224, 26)
        VerticalToolStripMenuItem.Text = "Vertical"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(925, 541)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DisplayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Form2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Form3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Form4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WindowsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HorizontalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerticalToolStripMenuItem As ToolStripMenuItem

End Class
