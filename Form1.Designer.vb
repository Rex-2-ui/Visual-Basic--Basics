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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        GroupBox1 = New GroupBox()
        Label3 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox1 = New TextBox()
        GroupBox2 = New GroupBox()
        RadioButton6 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        CheckBox1 = New CheckBox()
        PictureBox1 = New PictureBox()
        GroupBox4 = New GroupBox()
        RadioButton5 = New RadioButton()
        RadioButton4 = New RadioButton()
        TextBox4 = New TextBox()
        Label4 = New Label()
        DisplayButton = New ToolTip(components)
        ExitButton = New ToolTip(components)
        ResetButton = New ToolTip(components)
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = SystemColors.HotTrack
        GroupBox1.Location = New Point(30, 25)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(414, 164)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Student Information"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = SystemColors.Desktop
        Label3.Location = New Point(33, 127)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 20)
        Label3.TabIndex = 9
        Label3.Text = "Phone:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = SystemColors.Desktop
        Label1.Location = New Point(33, 75)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 20)
        Label1.TabIndex = 7
        Label1.Text = "Major:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = SystemColors.ControlText
        Label2.Location = New Point(33, 23)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 20)
        Label2.TabIndex = 8
        Label2.Text = "Name:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(118, 127)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(205, 27)
        TextBox2.TabIndex = 2
        TextBox2.Text = "(618) 850-2424"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(118, 26)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(205, 27)
        TextBox3.TabIndex = 3
        TextBox3.Text = "Tom Thumb"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(118, 72)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(205, 27)
        TextBox1.TabIndex = 1
        TextBox1.Text = "Philosophy and History"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(RadioButton6)
        GroupBox2.Controls.Add(RadioButton3)
        GroupBox2.Controls.Add(RadioButton2)
        GroupBox2.Controls.Add(RadioButton1)
        GroupBox2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.ForeColor = SystemColors.HotTrack
        GroupBox2.Location = New Point(512, 25)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(243, 164)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Background"
        ' 
        ' RadioButton6
        ' 
        RadioButton6.AutoSize = True
        RadioButton6.ForeColor = SystemColors.ControlText
        RadioButton6.Location = New Point(31, 125)
        RadioButton6.Name = "RadioButton6"
        RadioButton6.Size = New Size(60, 24)
        RadioButton6.TabIndex = 3
        RadioButton6.Text = "Blue"
        RadioButton6.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.ForeColor = SystemColors.ControlText
        RadioButton3.Location = New Point(30, 86)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(60, 24)
        RadioButton3.TabIndex = 2
        RadioButton3.Text = "Blue"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.ForeColor = SystemColors.ControlText
        RadioButton2.Location = New Point(30, 56)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(56, 24)
        RadioButton2.TabIndex = 1
        RadioButton2.Text = "Red"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Checked = True
        RadioButton1.ForeColor = SystemColors.ControlText
        RadioButton1.Location = New Point(30, 26)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(62, 24)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Gray"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Checked = True
        CheckBox1.CheckState = CheckState.Checked
        CheckBox1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckBox1.Location = New Point(136, 344)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(153, 27)
        CheckBox1.TabIndex = 3
        CheckBox1.Text = "Message Visible"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ControlText
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.ErrorImage = Nothing
        PictureBox1.InitialImage = Nothing
        PictureBox1.Location = New Point(12, 416)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(200, 125)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = SystemColors.Info
        GroupBox4.Controls.Add(RadioButton5)
        GroupBox4.Controls.Add(RadioButton4)
        GroupBox4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox4.ForeColor = SystemColors.HotTrack
        GroupBox4.Location = New Point(512, 229)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(250, 98)
        GroupBox4.TabIndex = 5
        GroupBox4.TabStop = False
        GroupBox4.Text = "Text Color"
        GroupBox4.UseWaitCursor = True
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.Checked = True
        RadioButton5.ForeColor = SystemColors.ControlText
        RadioButton5.Location = New Point(30, 26)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(66, 24)
        RadioButton5.TabIndex = 4
        RadioButton5.TabStop = True
        RadioButton5.Text = "Black"
        RadioButton5.UseVisualStyleBackColor = False
        RadioButton5.UseWaitCursor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.ForeColor = SystemColors.Desktop
        RadioButton4.Location = New Point(30, 56)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(70, 24)
        RadioButton4.TabIndex = 3
        RadioButton4.Text = "White"
        RadioButton4.UseVisualStyleBackColor = True
        RadioButton4.UseWaitCursor = True
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = SystemColors.Info
        TextBox4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(136, 229)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.ScrollBars = ScrollBars.Vertical
        TextBox4.Size = New Size(258, 80)
        TextBox4.TabIndex = 6
        TextBox4.Text = vbCrLf & vbCrLf
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(63, 232)
        Label4.Name = "Label4"
        Label4.Size = New Size(73, 23)
        Label4.TabIndex = 8
        Label4.Text = "Output:"
        ' 
        ' DisplayButton
        ' 
        DisplayButton.BackColor = Color.Black
        DisplayButton.ForeColor = Color.WhiteSmoke
        DisplayButton.IsBalloon = True
        DisplayButton.OwnerDraw = True
        DisplayButton.ToolTipTitle = "Click to display a message to the output text box"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Cyan
        Button1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.Desktop
        Button1.Location = New Point(443, 430)
        Button1.Name = "Button1"
        Button1.Size = New Size(151, 63)
        Button1.TabIndex = 9
        Button1.Text = "Display Message"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Cyan
        Button2.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(600, 430)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 63)
        Button2.TabIndex = 10
        Button2.Text = "Reset"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Cyan
        Button3.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(731, 430)
        Button3.Name = "Button3"
        Button3.Size = New Size(112, 63)
        Button3.TabIndex = 11
        Button3.Text = "Exit"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(855, 536)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(TextBox4)
        Controls.Add(GroupBox4)
        Controls.Add(PictureBox1)
        Controls.Add(CheckBox1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DisplayButton As ToolTip
    Friend WithEvents ExitButton As ToolTip
    Friend WithEvents ResetButton As ToolTip
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button

End Class
