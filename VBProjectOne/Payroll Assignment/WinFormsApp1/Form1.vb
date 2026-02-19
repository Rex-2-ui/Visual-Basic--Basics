Public Class Form1
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        EmployeeNameTextBox.Clear()
        NumberofPiecesTextBox.Clear()
        PricePerPieceTextbox.Clear()
        AmountEarnedTextbox.Clear()
        TotalPayTextBox.Clear()

    End Sub

    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles EmployeeNameTextBox.TextChanged

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Close()
    End Sub
End Class
