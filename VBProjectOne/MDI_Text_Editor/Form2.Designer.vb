<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        RichTextBox1 = New RichTextBox()
        SuspendLayout()
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(12, 2)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(487, 259)
        RichTextBox1.TabIndex = 0
        RichTextBox1.Text = ""
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(RichTextBox1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
End Class
