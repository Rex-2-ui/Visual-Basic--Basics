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
        Label2 = New Label()
        Label3 = New Label()
        Label = New Label()
        InitialApproxP0TextBox = New TextBox()
        InitialApprox1TextBox = New TextBox()
        MaxIterarationTextBox = New TextBox()
        ToleranceTextBox = New TextBox()
        NewtonButton = New Button()
        SecantButton = New Button()
        ResultsTextBox = New TextBox()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(74, 52)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(195, 23)
        Label1.TabIndex = 0
        Label1.Text = "Initial Approximation P0"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(72, 150)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(193, 23)
        Label2.TabIndex = 1
        Label2.Text = "Initial Approximation P1"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(514, 56)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(128, 23)
        Label3.TabIndex = 2
        Label3.Text = "Tolerance (TOL)"
        ' 
        ' Label
        ' 
        Label.AutoSize = True
        Label.Location = New Point(514, 154)
        Label.Margin = New Padding(4, 0, 4, 0)
        Label.Name = "Label"
        Label.Size = New Size(153, 23)
        Label.TabIndex = 3
        Label.Text = "Max Iteration (N0)"
        ' 
        ' InitialApproxP0TextBox
        ' 
        InitialApproxP0TextBox.Location = New Point(277, 52)
        InitialApproxP0TextBox.Margin = New Padding(4, 3, 4, 3)
        InitialApproxP0TextBox.Name = "InitialApproxP0TextBox"
        InitialApproxP0TextBox.Size = New Size(200, 30)
        InitialApproxP0TextBox.TabIndex = 4
        InitialApproxP0TextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' InitialApprox1TextBox
        ' 
        InitialApprox1TextBox.Location = New Point(277, 150)
        InitialApprox1TextBox.Margin = New Padding(4, 3, 4, 3)
        InitialApprox1TextBox.Name = "InitialApprox1TextBox"
        InitialApprox1TextBox.Size = New Size(200, 30)
        InitialApprox1TextBox.TabIndex = 5
        InitialApprox1TextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' MaxIterarationTextBox
        ' 
        MaxIterarationTextBox.Location = New Point(695, 141)
        MaxIterarationTextBox.Margin = New Padding(4, 3, 4, 3)
        MaxIterarationTextBox.Name = "MaxIterarationTextBox"
        MaxIterarationTextBox.Size = New Size(188, 30)
        MaxIterarationTextBox.TabIndex = 7
        MaxIterarationTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' ToleranceTextBox
        ' 
        ToleranceTextBox.Location = New Point(695, 52)
        ToleranceTextBox.Margin = New Padding(4, 3, 4, 3)
        ToleranceTextBox.Name = "ToleranceTextBox"
        ToleranceTextBox.Size = New Size(188, 30)
        ToleranceTextBox.TabIndex = 6
        ToleranceTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' NewtonButton
        ' 
        NewtonButton.ForeColor = Color.Black
        NewtonButton.Location = New Point(158, 243)
        NewtonButton.Margin = New Padding(4, 3, 4, 3)
        NewtonButton.Name = "NewtonButton"
        NewtonButton.Size = New Size(319, 33)
        NewtonButton.TabIndex = 8
        NewtonButton.Text = "Newton-Raphson Method"
        NewtonButton.UseVisualStyleBackColor = True
        ' 
        ' SecantButton
        ' 
        SecantButton.Location = New Point(620, 243)
        SecantButton.Margin = New Padding(4, 3, 4, 3)
        SecantButton.Name = "SecantButton"
        SecantButton.Size = New Size(319, 33)
        SecantButton.TabIndex = 9
        SecantButton.Text = "Secant Method"
        SecantButton.UseVisualStyleBackColor = True
        ' 
        ' ResultsTextBox
        ' 
        ResultsTextBox.Location = New Point(344, 322)
        ResultsTextBox.Multiline = True
        ResultsTextBox.Name = "ResultsTextBox"
        ResultsTextBox.Size = New Size(412, 199)
        ResultsTextBox.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(219, 341)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 23)
        Label4.TabIndex = 11
        Label4.Text = "Results"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1123, 550)
        Controls.Add(Label4)
        Controls.Add(ResultsTextBox)
        Controls.Add(SecantButton)
        Controls.Add(NewtonButton)
        Controls.Add(MaxIterarationTextBox)
        Controls.Add(ToleranceTextBox)
        Controls.Add(InitialApprox1TextBox)
        Controls.Add(InitialApproxP0TextBox)
        Controls.Add(Label)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label As Label
    Friend WithEvents InitialApproxP0TextBox As TextBox
    Friend WithEvents InitialApprox1TextBox As TextBox
    Friend WithEvents MaxIterarationTextBox As TextBox
    Friend WithEvents ToleranceTextBox As TextBox
    Friend WithEvents NewtonButton As Button
    Friend WithEvents SecantButton As Button
    Friend WithEvents ResultsTextBox As TextBox
    Friend WithEvents Label4 As Label

End Class
