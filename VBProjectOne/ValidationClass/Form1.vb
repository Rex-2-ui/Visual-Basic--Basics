Imports System.ComponentModel

Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles CustomerNameLabel.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles CustomerNameTextBox.TextChanged

    End Sub

    Private Sub TextBox1_Validating(sender As Object, e As CancelEventArgs) Handles CustomerNameTextBox.Validating
        If CustomerNameTextBox.Text = "" Then
            e.Cancel = True
            ErrorProvider1.SetError(CustomerNameTextBox, "Customer Name cannot be empty, please enter a name")
        Else
            ErrorProvider1.SetError(CustomerNameTextBox, " ")

        End If
    End Sub

    Private Sub PriceTextBox_TextChanged(sender As Object, e As EventArgs) Handles AddressTextBox.TextChanged

    End Sub

    Private Sub AddressTextBox_Validating(sender As Object, e As CancelEventArgs) Handles AddressTextBox.Validating
        If AddressTextBox.Text = "" Then
            e.Cancel = True
            ErrorProvider2.SetError(CustomerNameTextBox, "Price cannot be empty")

        End If
    End Sub

    Private Sub PriceTextBox_Validating(sender As Object, e As CancelEventArgs) Handles PriceTextBox.Validating
        If Not IsNumeric(PriceTextBox.Text) Then
            e.Cancel = True
            ErrorProvider7.SetError(PriceTextBox, "Price has to be number")
        ElseIf PriceTextBox.Text <= 0 Then
            ErrorProvider7.SetError(PriceTextBox, "Price but be greater than 0")
        Else

            ErrorProvider7.SetError(PriceTextBox, "")

        End If
    End Sub

    Private Sub PriceLabel_Click(sender As Object, e As EventArgs) Handles AdressLabel.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CityTextBox_TextChanged(sender As Object, e As EventArgs) Handles CityTextBox.TextChanged

    End Sub

    Private Sub CityTextBox_Validating(sender As Object, e As CancelEventArgs) Handles CityTextBox.Validating
        If CityTextBox.Text = "" Then
            e.Cancel = True
            ErrorProvider2.SetError(CityTextBox, " Please Enter City")
        Else
            ErrorProvider2.SetError(CityTextBox, "")

        End If
    End Sub

    Private Sub StateCodeTextBox_TextChanged(sender As Object, e As EventArgs) Handles StateCodeTextBox.TextChanged

    End Sub

    Private Sub StateCodeTextBox_Validating(sender As Object, e As CancelEventArgs) Handles StateCodeTextBox.Validating
        'If CityTextBox.Text = "" Then
        '    e.Cancel = True
        '    ErrorProvider2.SetError(CityTextBox, " Please Enter City")
        'Else
        '    ErrorProvider2.SetError(CityTextBox, "")

        'End If
    End Sub

    Private Sub DescriptionTextBox_TextChanged(sender As Object, e As EventArgs) Handles DescriptionTextBox.TextChanged

    End Sub

    Private Sub DescriptionTextBox_Validating(sender As Object, e As CancelEventArgs) Handles DescriptionTextBox.Validating
        If DescriptionTextBox.Text = "" Then
            e.Cancel = True
            ErrorProvider6.SetError(DescriptionTextBox, " Please Enter City")
        Else
            ErrorProvider6.SetError(DescriptionTextBox, "")

        End If
    End Sub

    Private Sub PriceTextBox_TextChanged_1(sender As Object, e As EventArgs) Handles PriceTextBox.TextChanged

    End Sub

    Private Sub WeightTextBox_TextChanged(sender As Object, e As EventArgs) Handles WeightTextBox.TextChanged

    End Sub

    Private Sub WeightTextBox_Validating(sender As Object, e As CancelEventArgs) Handles WeightTextBox.Validating
        If Not IsNumeric(WeightTextBox.Text) Then
            e.Cancel = True
            ErrorProvider8.SetError(WeightTextBox, "Weight must be a number")
        ElseIf WeightTextBox.Text <= 0 Then
            ErrorProvider8.SetError(WeightTextBox, "Number must be greater than 0")
        Else
            ErrorProvider8.SetError(WeightTextBox, "")
        End If
    End Sub

    Private Sub ZipCodeTextBox_TextChanged(sender As Object, e As EventArgs) Handles ZipCodeTextBox.TextChanged

    End Sub

    Private Sub ZipCodeTextBox_Validating(sender As Object, e As CancelEventArgs) Handles ZipCodeTextBox.Validating
        If ZipCodeTextBox.Text = "" Then
            e.Cancel = True
            ErrorProvider5.SetError(ZipCodeTextBox, "Input cannot be empty")
        ElseIf Not IsNumeric(ZipCodeTextBox.Text) Then
            ErrorProvider5.SetError(ZipCodeTextBox, "Input must be numeric")
        ElseIf ZipCodeTextBox.Text.Length < 5 Then
            ErrorProvider5.SetError(ZipCodeTextBox, "Number must be at least 5 digits")
        ElseIf ZipCodeTextBox.Text Then
        Else
            ErrorProvider5.SetError(ZipCodeTextBox, "")
        End If
    End Sub

    Private Sub Form1_Validating(sender As Object, e As CancelEventArgs) Handles Me.Validating
        e.Cancel = False
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        e.Cancel = False
    End Sub
End Class
