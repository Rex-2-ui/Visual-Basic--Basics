
Option Strict On
Public Class Form1

#Region "Validation"
    Private Function ValidData() As Boolean
        ' Rule #1: Name required
        If String.IsNullOrWhiteSpace(NameTextBox.Text) Then
            MessageBox.Show("Customer name is required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            NameTextBox.Focus()
            NameTextBox.SelectAll()
            Return False
        End If

        ' Rule #2: Address required
        If String.IsNullOrWhiteSpace(AddressTextBox.Text) Then
            MessageBox.Show("Address is required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            AddressTextBox.Focus()
            AddressTextBox.SelectAll()
            Return False
        End If

        ' Rule #3: City required
        If String.IsNullOrWhiteSpace(CityTextBox.Text) Then
            MessageBox.Show("City is required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CityTextBox.Focus()
            CityTextBox.SelectAll()
            Return False
        End If

        ' Rule #4: State code must be 2 chars
        Dim state As String = StateTextBox.Text.Trim().ToUpper()
        If state.Length <> 2 Then
            MessageBox.Show("State code must be 2 characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            StateTextBox.Focus()
            StateTextBox.SelectAll()
            Return False
        End If

        ' Rule #5: Zip must have 5 digits
        If ZipTextBox.Text.Trim().Length < 5 Then
            MessageBox.Show("Zip code must have at least 5 digits.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ZipTextBox.Focus()
            ZipTextBox.SelectAll()
            Return False
        End If

        ' Rule #6: Description required
        If String.IsNullOrWhiteSpace(DescriptionTextBox.Text) Then
            MessageBox.Show("Description is required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DescriptionTextBox.Focus()
            DescriptionTextBox.SelectAll()
            Return False
        End If

        ' Rule #7: Price > 0
        Dim price As Decimal
        If Not Decimal.TryParse(PriceTextBox.Text, price) OrElse price <= 0D Then
            MessageBox.Show("Price must be a number greater than zero.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PriceTextBox.Focus()
            PriceTextBox.SelectAll()
            Return False
        End If

        ' Rule #8: Weight > 0
        Dim weight As Decimal
        If Not Decimal.TryParse(WeightTextBox.Text, weight) OrElse weight <= 0D Then
            MessageBox.Show("Weight must be a number greater than zero.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            WeightTextBox.Focus()
            WeightTextBox.SelectAll()
            Return False
        End If

        ' Rule #9: Quantity > 0
        Dim qty As Integer
        If Not Integer.TryParse(QuantityTextBox.Text, qty) OrElse qty <= 0 Then
            MessageBox.Show("Quantity must be a number greater than zero.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            QuantityTextBox.Focus()
            QuantityTextBox.SelectAll()
            Return False
        End If

        Return True
    End Function
#End Region

#Region "Computation"
    Private Function ComputeSalesTaxDue(cost As Decimal, state As String, wholesale As Boolean) As Decimal
        If wholesale Then Return 0D
        Select Case state
            Case "IL" : Return Math.Round(cost * 0.07D, 2)
            Case "NY", "CA" : Return Math.Round(cost * 0.08D, 2)
            Case Else : Return 0D
        End Select
    End Function

    Private Function ComputeTransportHandling(weight As Decimal, qty As Integer, method As String, state As String) As Decimal
        Dim rate As Decimal
        Select Case method
            Case "Postal" : rate = 0.15D
            Case "PostalAir" : rate = 0.5D
            Case "FedEx2ndDay" : rate = 0.75D
            Case "FedExOvernight" : rate = 1D
        End Select

        Dim transport = weight * qty * rate
        Dim handling As Decimal = 0D
        If Not (state = "MO" Or state = "IL" Or state = "KY") Then
            handling = 5D * qty
        End If

        Return transport + handling
    End Function
#End Region

#Region "Event Handlers"
    Private Sub ComputeButton_Click(sender As Object, e As EventArgs) Handles ComputeButton.Click
        If Not ValidData() Then Exit Sub

        Dim price As Decimal = Decimal.Parse(PriceTextBox.Text)
        Dim qty As Integer = Integer.Parse(QuantityTextBox.Text)
        Dim weight As Decimal = Decimal.Parse(WeightTextBox.Text)
        Dim state As String = StateTextBox.Text.Trim().ToUpper()
        Dim wholesale As Boolean = WholeSaleCheckBox.Checked

        Dim cost As Decimal = Math.Round(price * qty, 2)
        Dim tax As Decimal = ComputeSalesTaxDue(cost, state, wholesale)

        Dim method As String = "Postal"
        If USPostalAirRadioButton.Checked Then method = "PostalAir"
        If FedXDayRadioButton.Checked Then method = "FedEx2ndDay"
        If FedXOvernightRadioButton.Checked Then method = "FedExOvernight"

        Dim shippingHandling As Decimal = ComputeTransportHandling(weight, qty, method, state)
        Dim total As Decimal = cost + tax + shippingHandling

        CostTextBox.Text = cost.ToString("C2")
        TaxDueTextBox.Text = tax.ToString("C2")
        ShippingTextBox.Text = shippingHandling.ToString("C2")
        TotalTextBox.Text = total.ToString("C2")
    End Sub


    Private Sub NewOrderButton_Click(sender As Object, e As EventArgs) Handles NewOrderButton.Click
        ' Clear all TextBox and MaskedTextBox controls inside the form
        For Each grp As GroupBox In Me.Controls.OfType(Of GroupBox)()
            For Each ctrl As Control In grp.Controls
                If TypeOf ctrl Is TextBox Then
                    CType(ctrl, TextBox).Clear()
                ElseIf TypeOf ctrl Is MaskedTextBox Then
                    CType(ctrl, MaskedTextBox).Clear()
                End If
            Next
        Next

        ' Reset Wholesale checkbox
        WholeSaleCheckBox.Checked = False

        ' Reset transport method to default (U.S. Postal)
        USPostalRadioButton.Checked = True

        ' Bring focus back to NameTextBox
        NameTextBox.Focus()
    End Sub



    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim result = MessageBox.Show("Exit application?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load









    End Sub
#End Region

End Class

