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
        Label1 = New Label()
        NameTextBox = New TextBox()
        MajorTextBox = New TextBox()
        Label2 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        ResetButton = New Button()
        PrintButton = New Button()
        ExitButton = New Button()
        PrintDocument1 = New Printing.PrintDocument()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(42, 49)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(141, 25)
        Label1.TabIndex = 0
        Label1.Text = "Student Name: "
        ' 
        ' NameTextBox
        ' 
        NameTextBox.Location = New Point(264, 45)
        NameTextBox.Margin = New Padding(4)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.Size = New Size(292, 31)
        NameTextBox.TabIndex = 1
        ' 
        ' MajorTextBox
        ' 
        MajorTextBox.Location = New Point(264, 129)
        MajorTextBox.Margin = New Padding(4)
        MajorTextBox.Name = "MajorTextBox"
        MajorTextBox.Size = New Size(292, 31)
        MajorTextBox.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(42, 132)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(150, 25)
        Label2.TabIndex = 2
        Label2.Text = "Academic Major:"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(125, 250)
        Button1.Margin = New Padding(4)
        Button1.Name = "Button1"
        Button1.Size = New Size(118, 65)
        Button1.TabIndex = 4
        Button1.Text = "Display Student #&1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(264, 250)
        Button2.Margin = New Padding(4)
        Button2.Name = "Button2"
        Button2.Size = New Size(118, 65)
        Button2.TabIndex = 5
        Button2.Text = "Display Student #&2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(410, 250)
        Button3.Margin = New Padding(4)
        Button3.Name = "Button3"
        Button3.Size = New Size(146, 65)
        Button3.TabIndex = 6
        Button3.Text = "Display Student #&3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' ResetButton
        ' 
        ResetButton.Location = New Point(125, 341)
        ResetButton.Margin = New Padding(4)
        ResetButton.Name = "ResetButton"
        ResetButton.Size = New Size(118, 36)
        ResetButton.TabIndex = 9
        ResetButton.Text = "Reset Form"
        ResetButton.UseVisualStyleBackColor = True
        ' 
        ' PrintButton
        ' 
        PrintButton.Location = New Point(264, 341)
        PrintButton.Margin = New Padding(4)
        PrintButton.Name = "PrintButton"
        PrintButton.Size = New Size(118, 36)
        PrintButton.TabIndex = 8
        PrintButton.Text = "Print Form"
        PrintButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(438, 341)
        ExitButton.Margin = New Padding(4)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(118, 36)
        ExitButton.TabIndex = 7
        ExitButton.Text = "Exit"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1000, 562)
        Controls.Add(ResetButton)
        Controls.Add(PrintButton)
        Controls.Add(ExitButton)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(MajorTextBox)
        Controls.Add(Label2)
        Controls.Add(NameTextBox)
        Controls.Add(Label1)
        Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents MajorTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents PrintButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument

End Class
