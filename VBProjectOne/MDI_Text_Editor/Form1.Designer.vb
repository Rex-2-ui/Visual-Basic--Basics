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
        FormatToolStripMenuItem = New ToolStripMenuItem()
        FontSizeToolStripMenuItem = New ToolStripMenuItem()
        FontColorToolStripMenuItem = New ToolStripMenuItem()
        FontToolStripMenuItem = New ToolStripMenuItem()
        FileToolStripMenuItem = New ToolStripMenuItem()
        NewToolStripMenuItem = New ToolStripMenuItem()
        CloseToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        DisplayToolStripMenuItem = New ToolStripMenuItem()
        CascadeToolStripMenuItem = New ToolStripMenuItem()
        TileToolStripMenuItem = New ToolStripMenuItem()
        HorizontalToolStripMenuItem = New ToolStripMenuItem()
        VerticalToolStripMenuItem = New ToolStripMenuItem()
        DisplayToolStripMenuItem1 = New ToolStripMenuItem()
        Form2ToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FormatToolStripMenuItem, FileToolStripMenuItem, DisplayToolStripMenuItem, DisplayToolStripMenuItem1})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FormatToolStripMenuItem
        ' 
        FormatToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {FontSizeToolStripMenuItem, FontColorToolStripMenuItem, FontToolStripMenuItem})
        FormatToolStripMenuItem.Name = "FormatToolStripMenuItem"
        FormatToolStripMenuItem.Size = New Size(70, 24)
        FormatToolStripMenuItem.Text = "Format"
        ' 
        ' FontSizeToolStripMenuItem
        ' 
        FontSizeToolStripMenuItem.Name = "FontSizeToolStripMenuItem"
        FontSizeToolStripMenuItem.Size = New Size(224, 26)
        FontSizeToolStripMenuItem.Text = "Font Size"
        ' 
        ' FontColorToolStripMenuItem
        ' 
        FontColorToolStripMenuItem.Name = "FontColorToolStripMenuItem"
        FontColorToolStripMenuItem.Size = New Size(224, 26)
        FontColorToolStripMenuItem.Text = "Font Color"
        ' 
        ' FontToolStripMenuItem
        ' 
        FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        FontToolStripMenuItem.Size = New Size(224, 26)
        FontToolStripMenuItem.Text = "Font Type"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewToolStripMenuItem, CloseToolStripMenuItem, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(46, 24)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' NewToolStripMenuItem
        ' 
        NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        NewToolStripMenuItem.Size = New Size(128, 26)
        NewToolStripMenuItem.Text = "New"
        ' 
        ' CloseToolStripMenuItem
        ' 
        CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        CloseToolStripMenuItem.Size = New Size(128, 26)
        CloseToolStripMenuItem.Text = "Close"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(128, 26)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' DisplayToolStripMenuItem
        ' 
        DisplayToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CascadeToolStripMenuItem, TileToolStripMenuItem})
        DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem"
        DisplayToolStripMenuItem.Size = New Size(84, 24)
        DisplayToolStripMenuItem.Text = "Windows"
        ' 
        ' CascadeToolStripMenuItem
        ' 
        CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        CascadeToolStripMenuItem.Size = New Size(147, 26)
        CascadeToolStripMenuItem.Text = "Cascade"
        ' 
        ' TileToolStripMenuItem
        ' 
        TileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {HorizontalToolStripMenuItem, VerticalToolStripMenuItem})
        TileToolStripMenuItem.Name = "TileToolStripMenuItem"
        TileToolStripMenuItem.Size = New Size(147, 26)
        TileToolStripMenuItem.Text = "Tile"
        ' 
        ' HorizontalToolStripMenuItem
        ' 
        HorizontalToolStripMenuItem.Name = "HorizontalToolStripMenuItem"
        HorizontalToolStripMenuItem.Size = New Size(162, 26)
        HorizontalToolStripMenuItem.Text = "Horizontal"
        ' 
        ' VerticalToolStripMenuItem
        ' 
        VerticalToolStripMenuItem.Name = "VerticalToolStripMenuItem"
        VerticalToolStripMenuItem.Size = New Size(162, 26)
        VerticalToolStripMenuItem.Text = "Vertical"
        ' 
        ' DisplayToolStripMenuItem1
        ' 
        DisplayToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {Form2ToolStripMenuItem})
        DisplayToolStripMenuItem1.Name = "DisplayToolStripMenuItem1"
        DisplayToolStripMenuItem1.Size = New Size(72, 24)
        DisplayToolStripMenuItem1.Text = "Display"
        ' 
        ' Form2ToolStripMenuItem
        ' 
        Form2ToolStripMenuItem.Name = "Form2ToolStripMenuItem"
        Form2ToolStripMenuItem.Size = New Size(224, 26)
        Form2ToolStripMenuItem.Text = "Form2"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FormatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontSizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HorizontalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerticalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Form2ToolStripMenuItem As ToolStripMenuItem

End Class
