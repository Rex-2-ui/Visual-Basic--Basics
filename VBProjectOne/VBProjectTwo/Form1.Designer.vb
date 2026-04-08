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
        TotalDueTextBox = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        SalesaTaxTextBox = New TextBox()
        SubtotalTextBox = New TextBox()
        QuantityTextBox = New TextBox()
        PriceTextBox = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        ComputeButton = New Button()
        ResetButton = New Button()
        TotalsButton = New Button()
        ExitButton = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.Control
        GroupBox1.Controls.Add(TotalDueTextBox)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(SalesaTaxTextBox)
        GroupBox1.Controls.Add(SubtotalTextBox)
        GroupBox1.Controls.Add(QuantityTextBox)
        GroupBox1.Controls.Add(PriceTextBox)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = SystemColors.MenuHighlight
        GroupBox1.Location = New Point(30, 40)
        GroupBox1.Margin = New Padding(4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4)
        GroupBox1.Size = New Size(748, 477)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Textbook Sale Information"
        ' 
        ' TotalDueTextBox
        ' 
        TotalDueTextBox.Location = New Point(326, 429)
        TotalDueTextBox.Margin = New Padding(4)
        TotalDueTextBox.Name = "TotalDueTextBox"
        TotalDueTextBox.ReadOnly = True
        TotalDueTextBox.Size = New Size(155, 30)
        TotalDueTextBox.TabIndex = 13
        TotalDueTextBox.TabStop = False
        TotalDueTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = SystemColors.InactiveCaptionText
        Label7.Location = New Point(62, 429)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(82, 23)
        Label7.TabIndex = 12
        Label7.Text = "Due Total"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = SystemColors.InfoText
        Label6.Location = New Point(64, 369)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(78, 23)
        Label6.TabIndex = 11
        Label6.Text = "Sales Tax"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = SystemColors.InactiveCaptionText
        Label5.Location = New Point(62, 306)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(74, 23)
        Label5.TabIndex = 10
        Label5.Text = "Subtotal"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = SystemColors.InfoText
        Label4.Location = New Point(62, 248)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 23)
        Label4.TabIndex = 9
        Label4.Text = "Quantity"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = SystemColors.InfoText
        Label3.Location = New Point(62, 192)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 23)
        Label3.TabIndex = 8
        Label3.Text = "Price"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = SystemColors.InfoText
        Label2.Location = New Point(62, 132)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(133, 23)
        Label2.TabIndex = 7
        Label2.Text = "ISBN (Identifier)"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = SystemColors.InactiveCaptionText
        Label1.Location = New Point(62, 70)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 23)
        Label1.TabIndex = 6
        Label1.Text = "Book Title"
        ' 
        ' SalesaTaxTextBox
        ' 
        SalesaTaxTextBox.Location = New Point(326, 370)
        SalesaTaxTextBox.Margin = New Padding(4)
        SalesaTaxTextBox.Name = "SalesaTaxTextBox"
        SalesaTaxTextBox.ReadOnly = True
        SalesaTaxTextBox.Size = New Size(155, 30)
        SalesaTaxTextBox.TabIndex = 5
        SalesaTaxTextBox.TabStop = False
        SalesaTaxTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' SubtotalTextBox
        ' 
        SubtotalTextBox.Location = New Point(326, 306)
        SubtotalTextBox.Margin = New Padding(4)
        SubtotalTextBox.Name = "SubtotalTextBox"
        SubtotalTextBox.ReadOnly = True
        SubtotalTextBox.Size = New Size(155, 30)
        SubtotalTextBox.TabIndex = 4
        SubtotalTextBox.TabStop = False
        SubtotalTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' QuantityTextBox
        ' 
        QuantityTextBox.Location = New Point(326, 248)
        QuantityTextBox.Margin = New Padding(4)
        QuantityTextBox.Name = "QuantityTextBox"
        QuantityTextBox.Size = New Size(155, 30)
        QuantityTextBox.TabIndex = 3
        QuantityTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' PriceTextBox
        ' 
        PriceTextBox.Location = New Point(326, 189)
        PriceTextBox.Margin = New Padding(4)
        PriceTextBox.Name = "PriceTextBox"
        PriceTextBox.Size = New Size(155, 30)
        PriceTextBox.TabIndex = 2
        PriceTextBox.Text = "$29.99"
        PriceTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(326, 124)
        TextBox2.Margin = New Padding(4)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(260, 30)
        TextBox2.TabIndex = 1
        TextBox2.Text = "0-256-07677-4"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(326, 61)
        TextBox1.Margin = New Padding(4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(386, 30)
        TextBox1.TabIndex = 0
        TextBox1.Text = "SQL Programming by Bruce Wanye"
        ' 
        ' ComputeButton
        ' 
        ComputeButton.Location = New Point(60, 549)
        ComputeButton.Margin = New Padding(4)
        ComputeButton.Name = "ComputeButton"
        ComputeButton.Size = New Size(118, 36)
        ComputeButton.TabIndex = 1
        ComputeButton.Text = "Compute"
        ComputeButton.UseVisualStyleBackColor = True
        ' 
        ' ResetButton
        ' 
        ResetButton.Location = New Point(189, 549)
        ResetButton.Margin = New Padding(4)
        ResetButton.Name = "ResetButton"
        ResetButton.Size = New Size(118, 36)
        ResetButton.TabIndex = 2
        ResetButton.Text = "Reset "
        ResetButton.UseVisualStyleBackColor = True
        ' 
        ' TotalsButton
        ' 
        TotalsButton.Location = New Point(314, 549)
        TotalsButton.Margin = New Padding(4)
        TotalsButton.Name = "TotalsButton"
        TotalsButton.Size = New Size(118, 36)
        TotalsButton.TabIndex = 3
        TotalsButton.Text = "Totals"
        TotalsButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(456, 549)
        ExitButton.Margin = New Padding(4)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(118, 36)
        ExitButton.TabIndex = 4
        ExitButton.Text = "Exit"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1000, 635)
        Controls.Add(ExitButton)
        Controls.Add(TotalsButton)
        Controls.Add(ResetButton)
        Controls.Add(ComputeButton)
        Controls.Add(GroupBox1)
        Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SalesaTaxTextBox As TextBox
    Friend WithEvents SubtotalTextBox As TextBox
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComputeButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents TotalsButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TotalDueTextBox As TextBox

End Class
