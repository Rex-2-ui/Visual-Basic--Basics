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
        MovieTitleTextBox = New TextBox()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        DVDRadioButton = New RadioButton()
        VideoTape = New RadioButton()
        MemberCheckBox = New CheckBox()
        NewReleasesCheckBox = New CheckBox()
        CalculateButton = New Button()
        ClearItemButton = New Button()
        OrderCompleteButton = New Button()
        SummaryButton = New Button()
        ExitButton = New Button()
        ItemAmountTextBox = New TextBox()
        SubTotalTextBox = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MovieTitleTextBox
        ' 
        MovieTitleTextBox.Location = New Point(242, 49)
        MovieTitleTextBox.Margin = New Padding(4, 3, 4, 3)
        MovieTitleTextBox.Name = "MovieTitleTextBox"
        MovieTitleTextBox.Size = New Size(268, 30)
        MovieTitleTextBox.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(55, 49)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 23)
        Label1.TabIndex = 1
        Label1.Text = "Movie Ttle"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(VideoTape)
        GroupBox1.Controls.Add(DVDRadioButton)
        GroupBox1.Location = New Point(35, 118)
        GroupBox1.Margin = New Padding(4, 3, 4, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 3, 4, 3)
        GroupBox1.Size = New Size(312, 144)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Format"
        ' 
        ' DVDRadioButton
        ' 
        DVDRadioButton.AutoSize = True
        DVDRadioButton.Location = New Point(16, 45)
        DVDRadioButton.Margin = New Padding(4, 3, 4, 3)
        DVDRadioButton.Name = "DVDRadioButton"
        DVDRadioButton.Size = New Size(66, 27)
        DVDRadioButton.TabIndex = 0
        DVDRadioButton.TabStop = True
        DVDRadioButton.Text = "DVD"
        DVDRadioButton.UseVisualStyleBackColor = True
        ' 
        ' VideoTape
        ' 
        VideoTape.AutoSize = True
        VideoTape.Location = New Point(11, 100)
        VideoTape.Margin = New Padding(4, 3, 4, 3)
        VideoTape.Name = "VideoTape"
        VideoTape.Size = New Size(136, 27)
        VideoTape.TabIndex = 1
        VideoTape.TabStop = True
        VideoTape.Text = "RadioButton2"
        VideoTape.UseVisualStyleBackColor = True
        ' 
        ' MemberCheckBox
        ' 
        MemberCheckBox.AutoSize = True
        MemberCheckBox.Location = New Point(448, 139)
        MemberCheckBox.Margin = New Padding(4, 3, 4, 3)
        MemberCheckBox.Name = "MemberCheckBox"
        MemberCheckBox.Size = New Size(214, 27)
        MemberCheckBox.TabIndex = 3
        MemberCheckBox.Text = "Member (10% discount)"
        MemberCheckBox.UseVisualStyleBackColor = True
        ' 
        ' NewReleasesCheckBox
        ' 
        NewReleasesCheckBox.AutoSize = True
        NewReleasesCheckBox.Location = New Point(448, 217)
        NewReleasesCheckBox.Margin = New Padding(4, 3, 4, 3)
        NewReleasesCheckBox.Name = "NewReleasesCheckBox"
        NewReleasesCheckBox.Size = New Size(137, 27)
        NewReleasesCheckBox.TabIndex = 4
        NewReleasesCheckBox.Text = "New Releases"
        NewReleasesCheckBox.UseVisualStyleBackColor = True
        ' 
        ' CalculateButton
        ' 
        CalculateButton.Location = New Point(12, 398)
        CalculateButton.Name = "CalculateButton"
        CalculateButton.Size = New Size(94, 29)
        CalculateButton.TabIndex = 5
        CalculateButton.Text = "Calculate"
        CalculateButton.UseVisualStyleBackColor = True
        ' 
        ' ClearItemButton
        ' 
        ClearItemButton.Location = New Point(136, 398)
        ClearItemButton.Name = "ClearItemButton"
        ClearItemButton.Size = New Size(134, 29)
        ClearItemButton.TabIndex = 6
        ClearItemButton.Text = "Clear Item"
        ClearItemButton.UseVisualStyleBackColor = True
        ' 
        ' OrderCompleteButton
        ' 
        OrderCompleteButton.Location = New Point(298, 398)
        OrderCompleteButton.Name = "OrderCompleteButton"
        OrderCompleteButton.Size = New Size(94, 29)
        OrderCompleteButton.TabIndex = 7
        OrderCompleteButton.Text = "Order Complete"
        OrderCompleteButton.UseVisualStyleBackColor = True
        ' 
        ' SummaryButton
        ' 
        SummaryButton.Location = New Point(448, 398)
        SummaryButton.Name = "SummaryButton"
        SummaryButton.Size = New Size(94, 29)
        SummaryButton.TabIndex = 8
        SummaryButton.Text = "Summary"
        SummaryButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(581, 398)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(94, 29)
        ExitButton.TabIndex = 9
        ExitButton.Text = "Exit"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' ItemAmountTextBox
        ' 
        ItemAmountTextBox.Location = New Point(207, 320)
        ItemAmountTextBox.Name = "ItemAmountTextBox"
        ItemAmountTextBox.ReadOnly = True
        ItemAmountTextBox.Size = New Size(125, 30)
        ItemAmountTextBox.TabIndex = 10
        ' 
        ' SubTotalTextBox
        ' 
        SubTotalTextBox.Location = New Point(550, 316)
        SubTotalTextBox.Name = "SubTotalTextBox"
        SubTotalTextBox.ReadOnly = True
        SubTotalTextBox.Size = New Size(125, 30)
        SubTotalTextBox.TabIndex = 11
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(35, 323)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 23)
        Label2.TabIndex = 12
        Label2.Text = "Item Amount"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(422, 323)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 23)
        Label3.TabIndex = 13
        Label3.Text = "SubTotal"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1050, 526)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(SubTotalTextBox)
        Controls.Add(ItemAmountTextBox)
        Controls.Add(ExitButton)
        Controls.Add(SummaryButton)
        Controls.Add(OrderCompleteButton)
        Controls.Add(ClearItemButton)
        Controls.Add(CalculateButton)
        Controls.Add(NewReleasesCheckBox)
        Controls.Add(MemberCheckBox)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Controls.Add(MovieTitleTextBox)
        Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MovieTitleTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents VideoTape As RadioButton
    Friend WithEvents DVDRadioButton As RadioButton
    Friend WithEvents MemberCheckBox As CheckBox
    Friend WithEvents NewReleasesCheckBox As CheckBox
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ClearItemButton As Button
    Friend WithEvents OrderCompleteButton As Button
    Friend WithEvents SummaryButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ItemAmountTextBox As TextBox
    Friend WithEvents SubTotalTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class
