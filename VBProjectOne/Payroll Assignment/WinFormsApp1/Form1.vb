Public Class Form1

    Dim TotalPieces As Integer = 0
    Dim TotalPay As Decimal = 0
    Dim NumberOfEntries As Integer = 0

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        EmployeeNameTextBox.Clear()
        NumberofPiecesTextBox.Clear()
        PricePerPieceTextbox.Clear()
        AmountEarnedTextbox.Clear()
        TotalPayTextBox.Clear()

        EmployeeNameTextBox.Focus()
        ClearButton.Enabled = False

    End Sub

    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles EmployeeNameTextBox.TextChanged

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Dim MessageString As String = "Are you sure you want to close the application?"
        Dim MessageTitle As String = "Close Application"
        Dim MessageButton As MessageBoxButtons = MessageBoxButtons.YesNo
        Dim MessageIcon As MessageBoxIcon = MessageBoxIcon.Question
        Dim MessageResult As DialogResult
        MessageResult = MessageBox.Show(MessageString, MessageTitle, MessageButton, MessageIcon)
        If MessageResult = DialogResult.Yes Then

            Me.Close()
            Exit Sub
        End If

    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim PricePerPiece As Integer
        Dim NumberOfPieces As Integer
        Dim AmountEarned As Decimal


        If String.IsNullOrWhiteSpace(EmployeeNameTextBox.Text) Then
            MessageBox.Show("Please enter the employee's name.", "Missing Name", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            EmployeeNameTextBox.Focus()
            Return
        End If


        If Integer.TryParse(NumberofPiecesTextBox.Text, NumberOfPieces) Then
            If NumberOfPieces >= 1 And NumberOfPieces <= 200 Then
                PricePerPiece = 60
            ElseIf NumberOfPieces >= 201 And NumberOfPieces <= 400 Then
                PricePerPiece = 65
            ElseIf NumberOfPieces >= 401 And NumberOfPieces <= 600 Then
                PricePerPiece = 70
            ElseIf NumberOfPieces > 600 Then
                PricePerPiece = 75
            Else MessageBox.Show("Please enter a valid number of pieces between 1 and 600.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
                NumberofPiecesTextBox.Focus()
                Return
            End If
        End If

        AmountEarned = (PricePerPiece * NumberOfPieces)

        PricePerPieceTextbox.Text = PricePerPiece.ToString("C")
        AmountEarnedTextbox.Text = AmountEarned.ToString("C")
        TotalPieces += NumberOfPieces
        TotalPay += AmountEarned
        TotalPayTextBox.Text = TotalPay.ToString("C")
        NumberOfEntries += 1

    End Sub

    Private Sub SumaryButton_Click(sender As Object, e As EventArgs) Handles SumaryButton.Click
        Dim AveragePay As Decimal = 0
        If NumberOfEntries > 0 Then
            AveragePay = TotalPay / NumberOfEntries
        End If

        ' Display the summary
        MessageBox.Show("Total Pieces: " & TotalPieces.ToString() & vbCrLf &
                        "Total Pay: " & TotalPay.ToString("C") & vbCrLf &
                        "Average Pay per Person: " & AveragePay.ToString("C"),
                        "Summary",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CalculateButton.Enabled = True
        ClearButton.Enabled = True
    End Sub
End Class
