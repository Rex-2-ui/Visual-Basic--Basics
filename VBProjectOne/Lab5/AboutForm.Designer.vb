<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutForm
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
        Label1 = New Label()
        OKButton = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(197, 136)
        Label1.Name = "Label1"
        Label1.Size = New Size(232, 80)
        Label1.TabIndex = 0
        Label1.Text = "R 'n R-for Reading 'n Refreshment" & vbCrLf & "Programming Lab Project" & vbCrLf & "Version 1.0" & vbCrLf & "Created by Batman" & vbCrLf
        ' 
        ' OKButton
        ' 
        OKButton.Location = New Point(430, 270)
        OKButton.Name = "OKButton"
        OKButton.Size = New Size(94, 29)
        OKButton.TabIndex = 1
        OKButton.Text = "OK"
        OKButton.UseVisualStyleBackColor = True
        ' 
        ' AboutForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(OKButton)
        Controls.Add(Label1)
        Name = "AboutForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents OKButton As Button
End Class
