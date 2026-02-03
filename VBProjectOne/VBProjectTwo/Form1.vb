Public Class Form1

    ' Module-level variables
    Private TotalQuantityInteger As Integer
    Private TotalSalesDecimal As Decimal

    ' COMPUTE BUTTON
    Private Sub ComputeButton_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Const SALES_TAX_RATE As Decimal = 0.0725
            Dim SubtotalDecimal, SalesTaxDecimal, TotalDueDecimal As Decimal

            ' Convert input from textboxes
            Dim PriceDecimal As Decimal = Decimal.Parse(TextBox3.Text)
            Dim QuantityInteger As Integer = Integer.Parse(TextBox4.Text)

            ' Compute values
            SubtotalDecimal = PriceDecimal * QuantityInteger
            SalesTaxDecimal = Math.Round(SubtotalDecimal * SALES_TAX_RATE, 2)
            TotalDueDecimal = SubtotalDecimal + SalesTaxDecimal

            ' Display outputs
            TextBox5.Text = SubtotalDecimal.ToString("C")
            TextBox6.Text = SalesTaxDecimal.ToString("C")
            TextBox7.Text = TotalDueDecimal.ToString("C")

            ' Enable/disable buttons
            Button1.Enabled = False
            Button2.Enabled = True

            ' Accumulate totals
            TotalQuantityInteger += QuantityInteger
            TotalSalesDecimal += TotalDueDecimal

        Catch ex As Exception
            MessageBox.Show("Error in either Book Price or Quantity Purchased", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox3.Focus()
        End Try
    End Sub

    ' RESET BUTTON
    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()

        Button1.Enabled = True
        Button2.Enabled = False

        TextBox1.Focus()
    End Sub

    ' EXIT BUTTON
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    ' TOTALS BUTTON
    Private Sub TotalsButton_Click(sender As Object, e As EventArgs) Handles Button3.Click
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
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        ' Leave empty or add validation logic here if needed
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
