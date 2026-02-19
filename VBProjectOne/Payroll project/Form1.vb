Public Class Form1

    Dim TotalSalesCount As Integer = 0
    Dim TotalRevenue As Integer = 0D

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter, GroupBox1.Enter

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox.Enter

    End Sub

    Private Sub ComputeButton_Click(sender As Object, e As EventArgs) Handles ComputeButton.Click


        Dim price As Decimal = 0
        Dim tradeIn As Decimal = 0
        Dim discount As Decimal = 0
        Dim extras As Decimal = 0
        Dim subtotal As Decimal
        Dim salesTax As Decimal
        Dim totalDue As Decimal
        Const TAX_RATE As Decimal = 0.05D ' 5% Tax
        Const DISCOUNT_RATE As Decimal = 0.2D ' 20% Wholesale Discount

        ' 1. Get User Input (Price and Trade-in)
        Decimal.TryParse(txtPrice.Text, price)
        Decimal.TryParse(txttradein.Text, tradeIn)

        ' 2. Calculate Wholesale Discount (if checkbox is checked)
        If WholeSaleCheckBox.Checked Then
            discount = price * DISCOUNT_RATE
        End If

        ' 3. Calculate Exterior Extras (Radio Buttons)
        If PainttouchupRadioButton.Checked Then
            extras += 500 ' Example price for Paint
        ElseIf UndercoatRadioButton.Checked Then
            extras += 400 ' Example price for Undercoat
        ElseIf BothRadioButton.Checked Then
            extras += 900
        End If

        ' 4. Calculate Accessory Extras (Checkboxes)
        If NewtiresCheckBox.Checked Then extras += 600
        If NewHDRadioCheckBox.Checked Then extras += 200
        If BuiltinGPSCheckBox.Checked Then extras += 500
        If NewFloorMatsCheckBox.Checked Then extras += 100

        ' 5. Final Calculations
        subtotal = (price - discount + extras)
        salesTax = subtotal * TAX_RATE
        totalDue = (subtotal + salesTax) - tradeIn

        ' 6. Display results
        txtDiscount.Text = discount.ToString("C")
        txtExtras.Text = extras.ToString("C")
        txtSubtotal.Text = subtotal.ToString("C")
        txtsalestax.Text = salesTax.ToString("C")
        txttotaldue.Text = totalDue.ToString("C")


        TotalSalesCount += 1
        TotalRevenue += totalDue
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged

    End Sub

    Private Sub txttradein_TextChanged(sender As Object, e As EventArgs) Handles txttradein.TextChanged

    End Sub





    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click


        ' Clear input
        TxtLotNumber.Clear()
        TxtYear.Clear()
        txtvehiclemake.Clear()
        txtPrice.Clear()

        ' Trade-in reset to 0.00
        txttradein.Text = "0.00"

        ' Clear output
        txtDiscount.Clear()
        txtExtras.Clear()
        txtSubtotal.Clear()
        txtsalestax.Clear()
        txttotaldue.Clear()

        ' Uncheck checkboxes
        WholeSaleCheckBox.Checked = False
        NewtiresCheckBox.Checked = False
        NewHDRadioCheckBox.Checked = False
        BuiltinGPSCheckBox.Checked = False
        NewFloorMatsCheckBox.Checked = False

        ' Reset RadioButtons
        NoneRadiobutton.Checked = True

        ' Set focus
        TxtLotNumber.Focus()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles TotalsButton.Click

        MessageBox.Show("Total Vehicles Processed: " & TotalSalesCount.ToString() & vbCrLf &
                    "Total Revenue: " & TotalRevenue.ToString("C"), "Sales Summary")
    End Sub
End Class
