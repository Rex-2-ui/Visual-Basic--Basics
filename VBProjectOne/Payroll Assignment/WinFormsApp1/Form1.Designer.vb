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
        EmployeeNameLabel = New Label()
        NumberofPiecesLabel = New Label()
        NumberofPiecesTextBox = New TextBox()
        EmployeeNameTextBox = New TextBox()
        CalculateButton = New Button()
        SumaryButton = New Button()
        ClearButton = New Button()
        CloseButton = New Button()
        EmployeeInformationGroupBox = New GroupBox()
        SalesInformationGroupBox = New GroupBox()
        TotalPayLabel = New Label()
        TotalPayTextBox = New TextBox()
        PricePerPieceLabel = New Label()
        AmountEarnedLabel = New Label()
        PricePerPieceTextbox = New TextBox()
        AmountEarnedTextbox = New TextBox()
        EmployeeInformationGroupBox.SuspendLayout()
        SalesInformationGroupBox.SuspendLayout()
        SuspendLayout()
        ' 
        ' EmployeeNameLabel
        ' 
        EmployeeNameLabel.AutoSize = True
        EmployeeNameLabel.Location = New Point(43, 38)
        EmployeeNameLabel.Name = "EmployeeNameLabel"
        EmployeeNameLabel.Size = New Size(125, 20)
        EmployeeNameLabel.TabIndex = 0
        EmployeeNameLabel.Text = "Employee Name:"
        ' 
        ' NumberofPiecesLabel
        ' 
        NumberofPiecesLabel.AutoSize = True
        NumberofPiecesLabel.Location = New Point(43, 93)
        NumberofPiecesLabel.Name = "NumberofPiecesLabel"
        NumberofPiecesLabel.Size = New Size(134, 20)
        NumberofPiecesLabel.TabIndex = 1
        NumberofPiecesLabel.Text = "Number of Pieces:"
        ' 
        ' NumberofPiecesTextBox
        ' 
        NumberofPiecesTextBox.Location = New Point(225, 86)
        NumberofPiecesTextBox.Name = "NumberofPiecesTextBox"
        NumberofPiecesTextBox.Size = New Size(269, 27)
        NumberofPiecesTextBox.TabIndex = 2
        ' 
        ' EmployeeNameTextBox
        ' 
        EmployeeNameTextBox.Location = New Point(225, 26)
        EmployeeNameTextBox.Name = "EmployeeNameTextBox"
        EmployeeNameTextBox.Size = New Size(269, 27)
        EmployeeNameTextBox.TabIndex = 3
        ' 
        ' CalculateButton
        ' 
        CalculateButton.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CalculateButton.Location = New Point(305, 472)
        CalculateButton.Name = "CalculateButton"
        CalculateButton.Size = New Size(94, 29)
        CalculateButton.TabIndex = 4
        CalculateButton.Text = "Calculate"
        CalculateButton.UseVisualStyleBackColor = True
        ' 
        ' SumaryButton
        ' 
        SumaryButton.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SumaryButton.Location = New Point(422, 472)
        SumaryButton.Name = "SumaryButton"
        SumaryButton.Size = New Size(94, 29)
        SumaryButton.TabIndex = 5
        SumaryButton.Text = "Summary"
        SumaryButton.UseVisualStyleBackColor = True
        ' 
        ' ClearButton
        ' 
        ClearButton.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ClearButton.Location = New Point(533, 472)
        ClearButton.Name = "ClearButton"
        ClearButton.Size = New Size(94, 29)
        ClearButton.TabIndex = 6
        ClearButton.Text = "Clear"
        ClearButton.UseVisualStyleBackColor = True
        ' 
        ' CloseButton
        ' 
        CloseButton.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CloseButton.Location = New Point(666, 472)
        CloseButton.Name = "CloseButton"
        CloseButton.Size = New Size(94, 29)
        CloseButton.TabIndex = 7
        CloseButton.Text = "Close"
        CloseButton.UseVisualStyleBackColor = True
        ' 
        ' EmployeeInformationGroupBox
        ' 
        EmployeeInformationGroupBox.Controls.Add(EmployeeNameLabel)
        EmployeeInformationGroupBox.Controls.Add(NumberofPiecesLabel)
        EmployeeInformationGroupBox.Controls.Add(EmployeeNameTextBox)
        EmployeeInformationGroupBox.Controls.Add(NumberofPiecesTextBox)
        EmployeeInformationGroupBox.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        EmployeeInformationGroupBox.Location = New Point(35, 46)
        EmployeeInformationGroupBox.Name = "EmployeeInformationGroupBox"
        EmployeeInformationGroupBox.Size = New Size(606, 146)
        EmployeeInformationGroupBox.TabIndex = 8
        EmployeeInformationGroupBox.TabStop = False
        EmployeeInformationGroupBox.Text = "Employee Information"
        ' 
        ' SalesInformationGroupBox
        ' 
        SalesInformationGroupBox.Controls.Add(TotalPayLabel)
        SalesInformationGroupBox.Controls.Add(TotalPayTextBox)
        SalesInformationGroupBox.Controls.Add(PricePerPieceLabel)
        SalesInformationGroupBox.Controls.Add(AmountEarnedLabel)
        SalesInformationGroupBox.Controls.Add(PricePerPieceTextbox)
        SalesInformationGroupBox.Controls.Add(AmountEarnedTextbox)
        SalesInformationGroupBox.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SalesInformationGroupBox.Location = New Point(35, 231)
        SalesInformationGroupBox.Name = "SalesInformationGroupBox"
        SalesInformationGroupBox.Size = New Size(481, 202)
        SalesInformationGroupBox.TabIndex = 9
        SalesInformationGroupBox.TabStop = False
        SalesInformationGroupBox.Text = "Sales Information"
        ' 
        ' TotalPayLabel
        ' 
        TotalPayLabel.AutoSize = True
        TotalPayLabel.Location = New Point(43, 141)
        TotalPayLabel.Name = "TotalPayLabel"
        TotalPayLabel.Size = New Size(79, 20)
        TotalPayLabel.TabIndex = 5
        TotalPayLabel.Text = "Total Pay: "
        ' 
        ' TotalPayTextBox
        ' 
        TotalPayTextBox.Location = New Point(195, 134)
        TotalPayTextBox.Name = "TotalPayTextBox"
        TotalPayTextBox.ReadOnly = True
        TotalPayTextBox.Size = New Size(199, 27)
        TotalPayTextBox.TabIndex = 4
        TotalPayTextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' PricePerPieceLabel
        ' 
        PricePerPieceLabel.AutoSize = True
        PricePerPieceLabel.Location = New Point(43, 42)
        PricePerPieceLabel.Name = "PricePerPieceLabel"
        PricePerPieceLabel.Size = New Size(113, 20)
        PricePerPieceLabel.TabIndex = 0
        PricePerPieceLabel.Text = "Price Per Piece:"
        ' 
        ' AmountEarnedLabel
        ' 
        AmountEarnedLabel.AutoSize = True
        AmountEarnedLabel.Location = New Point(43, 89)
        AmountEarnedLabel.Name = "AmountEarnedLabel"
        AmountEarnedLabel.Size = New Size(120, 20)
        AmountEarnedLabel.TabIndex = 1
        AmountEarnedLabel.Text = "Amount Earned:"
        ' 
        ' PricePerPieceTextbox
        ' 
        PricePerPieceTextbox.Location = New Point(195, 35)
        PricePerPieceTextbox.Name = "PricePerPieceTextbox"
        PricePerPieceTextbox.ReadOnly = True
        PricePerPieceTextbox.Size = New Size(239, 27)
        PricePerPieceTextbox.TabIndex = 3
        PricePerPieceTextbox.TextAlign = HorizontalAlignment.Right
        ' 
        ' AmountEarnedTextbox
        ' 
        AmountEarnedTextbox.Location = New Point(195, 82)
        AmountEarnedTextbox.Name = "AmountEarnedTextbox"
        AmountEarnedTextbox.ReadOnly = True
        AmountEarnedTextbox.Size = New Size(199, 27)
        AmountEarnedTextbox.TabIndex = 2
        AmountEarnedTextbox.TextAlign = HorizontalAlignment.Right
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(844, 523)
        Controls.Add(SalesInformationGroupBox)
        Controls.Add(EmployeeInformationGroupBox)
        Controls.Add(CloseButton)
        Controls.Add(ClearButton)
        Controls.Add(SumaryButton)
        Controls.Add(CalculateButton)
        Name = "Form1"
        Text = "Form1"
        EmployeeInformationGroupBox.ResumeLayout(False)
        EmployeeInformationGroupBox.PerformLayout()
        SalesInformationGroupBox.ResumeLayout(False)
        SalesInformationGroupBox.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents EmployeeNameLabel As Label
    Friend WithEvents NumberofPiecesLabel As Label
    Friend WithEvents NumberofPiecesTextBox As TextBox
    Friend WithEvents EmployeeNameTextBox As TextBox
    Friend WithEvents CalculateButton As Button
    Friend WithEvents SumaryButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents EmployeeInformationGroupBox As GroupBox
    Friend WithEvents SalesInformationGroupBox As GroupBox
    Friend WithEvents TotalPayLabel As Label
    Friend WithEvents TotalPayTextBox As TextBox
    Friend WithEvents PricePerPieceLabel As Label
    Friend WithEvents AmountEarnedLabel As Label
    Friend WithEvents PricePerPieceTextbox As TextBox
    Friend WithEvents AmountEarnedTextbox As TextBox

End Class
