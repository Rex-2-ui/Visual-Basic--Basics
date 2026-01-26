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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        GroupBox2 = New GroupBox()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        CheckBox1 = New CheckBox()
        PictureBox1 = New PictureBox()
        GroupBox4 = New GroupBox()
        RadioButton4 = New RadioButton()
        RadioButton5 = New RadioButton()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        RadioButton6 = New RadioButton()
        TextBox4 = New TextBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.ForeColor = SystemColors.HotTrack
        GroupBox1.Location = New Point(30, 25)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(414, 164)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(169, 75)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(205, 27)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(169, 122)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(205, 27)
        TextBox2.TabIndex = 2
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(169, 26)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(205, 27)
        TextBox3.TabIndex = 3
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(RadioButton6)
        GroupBox2.Controls.Add(RadioButton3)
        GroupBox2.Controls.Add(RadioButton2)
        GroupBox2.Controls.Add(RadioButton1)
        GroupBox2.ForeColor = SystemColors.HotTrack
        GroupBox2.Location = New Point(512, 25)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(243, 164)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Background"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Checked = True
        RadioButton1.ForeColor = SystemColors.ControlText
        RadioButton1.Location = New Point(30, 26)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(60, 24)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Gray"
        RadioButton1.UseVisualStyleBackColor = True
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
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.ForeColor = SystemColors.ControlText
        RadioButton3.Location = New Point(30, 86)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(59, 24)
        RadioButton3.TabIndex = 2
        RadioButton3.Text = "Blue"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Checked = True
        CheckBox1.CheckState = CheckState.Checked
        CheckBox1.Font = New Font("Segoe UI", 10F)
        CheckBox1.Location = New Point(136, 344)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(152, 27)
        CheckBox1.TabIndex = 3
        CheckBox1.Text = "Message Visible"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(12, 407)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(136, 84)
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = SystemColors.Control
        GroupBox4.Controls.Add(RadioButton5)
        GroupBox4.Controls.Add(RadioButton4)
        GroupBox4.ForeColor = SystemColors.HotTrack
        GroupBox4.Location = New Point(512, 229)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(250, 98)
        GroupBox4.TabIndex = 5
        GroupBox4.TabStop = False
        GroupBox4.Text = "Text Color"
        GroupBox4.UseWaitCursor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.ForeColor = SystemColors.Desktop
        RadioButton4.Location = New Point(30, 56)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(69, 24)
        RadioButton4.TabIndex = 3
        RadioButton4.Text = "White"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.Checked = True
        RadioButton5.ForeColor = SystemColors.ControlText
        RadioButton5.Location = New Point(30, 26)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(65, 24)
        RadioButton5.TabIndex = 4
        RadioButton5.TabStop = True
        RadioButton5.Text = "Black"
        RadioButton5.UseVisualStyleBackColor = False
        RadioButton5.UseWaitCursor = True
        ' 
        ' RadioButton6
        ' 
        RadioButton6.AutoSize = True
        RadioButton6.ForeColor = SystemColors.ControlText
        RadioButton6.Location = New Point(31, 125)
        RadioButton6.Name = "RadioButton6"
        RadioButton6.Size = New Size(59, 24)
        RadioButton6.TabIndex = 3
        RadioButton6.Text = "Blue"
        RadioButton6.UseVisualStyleBackColor = True
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(136, 229)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.ScrollBars = ScrollBars.Both
        TextBox4.Size = New Size(308, 98)
        TextBox4.TabIndex = 6
        TextBox4.Text = "My Name: Tom Thumb" & vbCrLf & "Major: Philosophy and History" & vbCrLf & "Local phone: (618) 850-2424" & vbCrLf & vbCrLf
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(863, 552)
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
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents TextBox4 As TextBox

End Class
