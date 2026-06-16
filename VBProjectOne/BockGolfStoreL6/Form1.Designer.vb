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
        InventoryToolStripMenuItem = New ToolStripMenuItem()
        ColorsAndFontsToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        GroupBox1 = New GroupBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        MenuStrip1.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, InventoryToolStripMenuItem, ColorsAndFontsToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(8, 2, 0, 2)
        MenuStrip1.Size = New Size(1074, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(46, 24)
        FileToolStripMenuItem.Text = "&File"
        ' 
        ' InventoryToolStripMenuItem
        ' 
        InventoryToolStripMenuItem.Name = "InventoryToolStripMenuItem"
        InventoryToolStripMenuItem.Size = New Size(84, 24)
        InventoryToolStripMenuItem.Text = "&Inventory"
        ' 
        ' ColorsAndFontsToolStripMenuItem
        ' 
        ColorsAndFontsToolStripMenuItem.Name = "ColorsAndFontsToolStripMenuItem"
        ColorsAndFontsToolStripMenuItem.Size = New Size(133, 24)
        ColorsAndFontsToolStripMenuItem.Text = "&Colors and Fonts"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(55, 24)
        HelpToolStripMenuItem.Text = "&Help"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.ForeColor = Color.MediumBlue
        GroupBox1.Location = New Point(74, 64)
        GroupBox1.Margin = New Padding(4, 3, 4, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 3, 4, 3)
        GroupBox1.Size = New Size(659, 198)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Inventory Data"
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
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(74, 300)
        Label4.Name = "Label4"
        Label4.Size = New Size(174, 23)
        Label4.TabIndex = 3
        Label4.Text = "Inentory Item Listing:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(248, 89)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 30)
        TextBox1.TabIndex = 3
        TextBox1.Text = "349.95"
        TextBox1.TextAlign = HorizontalAlignment.Right
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(248, 147)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 30)
        TextBox2.TabIndex = 4
        TextBox2.Text = "1"
        TextBox2.TextAlign = HorizontalAlignment.Right
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1074, 530)
        Controls.Add(Label4)
        Controls.Add(GroupBox1)
        Controls.Add(MenuStrip1)
        Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MainMenuStrip = MenuStrip1
        Margin = New Padding(4, 3, 4, 3)
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
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorsAndFontsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label

End Class
