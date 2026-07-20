Public Class Form1
    ' Module-level variables
    Private Subtotal As Decimal = 0D
    Private CustomerCount As Integer = 0
    Private RentalSum As Decimal = 0D

    ' Calculate button
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click, CalculateToolStripMenuItem.Click
        If MovieTitleTextBox.Text.Trim() = "" OrElse (Not DVDRadioButton.Checked AndAlso Not VideoTapeRadioButton.Checked) Then
            MessageBox.Show("Please enter a movie title and select a format.", "Missing Data")
            Exit Sub
        End If

        Dim price As Decimal
        If DVDRadioButton.Checked Then
            price = If(NewReleasesCheckBox.Checked, 3D, 2.5D)
        ElseIf VideoTapeRadioButton.Checked Then
            price = If(NewReleasesCheckBox.Checked, 2D, 1.8D)
        End If

        ItemAmountTextBox.Text = price.ToString("C")
        Subtotal += price
        SubTotalTextBox.Text = Subtotal.ToString("C")
    End Sub

    ' Clear for Next Item
    Private Sub btnClearItem_Click(sender As Object, e As EventArgs) Handles ClearItemButton.Click, ClearForNextItemToolStripMenuItem.Click
        MovieTitleTextBox.Clear()
        DVDRadioButton.Checked = False
        VideoTapeRadioButton.Checked = False
        NewReleasesCheckBox.Checked = False
        ItemAmountTextBox.Clear()
        MovieTitleTextBox.Focus()
        SubTotalTextBox.Clear()
        MemberCheckBox.Checked = False
    End Sub

    ' Order Complete
    Private Sub btnOrderComplete_Click(sender As Object, e As EventArgs) Handles OrderCompleteButton.Click, OrderCompleteToolStripMenuItem.Click
        Dim confirm = MessageBox.Show("Complete this order?", "Confirm", MessageBoxButtons.YesNo)
        If confirm = DialogResult.Yes Then
            If MemberCheckBox.Checked Then
                Subtotal *= 0.9D ' Apply 10% discount
            End If

            RentalSum += Subtotal
            CustomerCount += 1

            ' Reset for next customer
            MovieTitleTextBox.Clear()
            DVDRadioButton.Checked = False
            VideoTapeRadioButton.Checked = False
            NewReleasesCheckBox.Checked = False
            MemberCheckBox.Checked = False
            ItemAmountTextBox.Clear()
            SubTotalTextBox.Clear()
            Subtotal = 0D
        End If
    End Sub

    ' Summary
    Private Sub btnSummary_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click, SummaryToolStripMenuItem.Click
        MessageBox.Show("Customers: " & CustomerCount &
                        vbCrLf & "Total Rentals: " & RentalSum.ToString("C"),
                        "Summary")
    End Sub

    ' Exit
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub About_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Movie Rental Program" & vbCrLf &
                        "Programmer: Rex & Abeiku" & vbCrLf &
                        "Mid-Sem Revision - Menus & Function Procedure",
                        "About")
    End Sub

End Class

