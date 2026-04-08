Public Class Form1

    ' Module-level variables
    Private TotalQuantityInteger As Integer
    Private TotalSalesDecimal As Decimal

    ' COMPUTE BUTTON
    Private Sub ComputeButton_Click(sender As Object, e As EventArgs) Handles ComputeButton.Click
        Try
            Const SALES_TAX_RATE As Decimal = 0.0725
            Dim SubtotalDecimal, SalesTaxDecimal, TotalDueDecimal As Decimal

            ' Convert input from textboxes
            Dim PriceDecimal As Decimal = Decimal.Parse(PriceTextBox.Text, Globalization.NumberStyles.Currency)
            Dim QuantityInteger As Integer = Integer.Parse(QuantityTextBox.Text, Globalization.NumberStyles.Number)

            ' Compute values
            SubtotalDecimal = PriceDecimal * QuantityInteger
            SalesTaxDecimal = Decimal.Round(SubtotalDecimal * SALES_TAX_RATE, 2)
            TotalDueDecimal = SubtotalDecimal + SalesTaxDecimal

            ' Display outputs
            SubtotalTextBox.Text = SubtotalDecimal.ToString("C")
            SalesaTaxTextBox.Text = SalesTaxDecimal.ToString("C")
            TotalDueTextBox.Text = TotalDueDecimal.ToString("C")

            ' Enable/disable buttons
            ComputeButton.Enabled = False
            ResetButton.Enabled = True

            ' Accumulate totals
            TotalQuantityInteger += QuantityInteger
            TotalSalesDecimal += TotalDueDecimal

        Catch ex As Exception
            MessageBox.Show("Error in either Book Price or Quantity Purchased", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PriceTextBox.Focus()
        End Try
    End Sub

    ' RESET BUTTON
    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ComputeButton.Click
        TextBox1.Clear()
        TextBox2.Clear()
        PriceTextBox.Clear()
        QuantityTextBox.Clear()
        SubtotalTextBox.Clear()
        SalesaTaxTextBox.Clear()
        TotalDueTextBox.Clear()

        ComputeButton.Enabled = True
        ResetButton.Enabled = False

        TextBox1.Focus()
    End Sub

    ' EXIT BUTTON
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    ' TOTALS BUTTON
    Private Sub TotalsButton_Click(sender As Object, e As EventArgs) Handles TotalsButton.Click
        Try
            Dim AverageSaleDecimal As Decimal = TotalSalesDecimal / TotalQuantityInteger
            Dim messageString As String =
                "Total Sales: " & TotalSalesDecimal.ToString("C") & vbCrLf &
                "Total Books Sold: " & TotalQuantityInteger.ToString("N0") & vbCrLf &
                "Average Book Value: " & AverageSaleDecimal.ToString("C")

            MessageBox.Show(messageString, "Totals and Averages", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch exArithmetic As ArithmeticException
            MessageBox.Show("No books have been sold yet", "Zero Sales Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Unexpected Error – inform the system administrator", "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' OPTIONAL: TextBox4 change event
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles QuantityTextBox.TextChanged
        ' Leave empty or add validation logic here if needed
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles PriceTextBox.TextChanged

    End Sub

    Private Sub ResetButton_Click_1(sender As Object, e As EventArgs) Handles ResetButton.Click

    End Sub
End Class
