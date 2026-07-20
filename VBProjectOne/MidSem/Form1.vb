Public Class Form1

    ' Module-level variable to accumulate Order Total
    Private orderTotal As Decimal = 0D

    ' Add handlers via Handles clause (controls declared WithEvents in Designer)
    Private Sub exitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles exitToolStripMenuItem.Click
        Dim result = MessageBox.Show("Are you sure you want to exit the application?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub addPartToComboToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles addPartToComboToolStripMenuItem.Click
        ' Prompt the user for a new part name and add to the ComboBox items at runtime
        Dim newPart = Microsoft.VisualBasic.Interaction.InputBox("Enter new part description:", "Add Part to ComboBox", "")
        If Not String.IsNullOrWhiteSpace(newPart) Then
            cmbDescription.Items.Add(newPart.Trim())
            MessageBox.Show($"Part '{newPart.Trim()}' added to the ComboBox.", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub deletePartFromComboToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles deletePartFromComboToolStripMenuItem.Click
        If cmbDescription.SelectedIndex >= 0 Then
            Dim toDelete = cmbDescription.SelectedItem.ToString()
            If MessageBox.Show($"Delete '{toDelete}' from the ComboBox?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                cmbDescription.Items.RemoveAt(cmbDescription.SelectedIndex)
            End If
        Else
            MessageBox.Show("No part is selected in the Description ComboBox to delete.", "Delete Part", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub addPartToListBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles addPartToListBoxToolStripMenuItem.Click
        ' Business rule #1: part must be selected
        If String.IsNullOrWhiteSpace(cmbDescription.Text) Or cmbDescription.SelectedIndex = -1 Then
            MessageBox.Show("Please select an auto part from the Description ComboBox.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbDescription.Focus()
            Return
        End If

        ' Business rule #2: Price must be numeric > 0
        Dim price As Decimal
        If Not Decimal.TryParse(txtPrice.Text.Trim(), Globalization.NumberStyles.Currency Or Globalization.NumberStyles.Number, Globalization.CultureInfo.CurrentCulture, price) OrElse price <= 0D Then
            MessageBox.Show("Please enter a numeric Price greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPrice.Focus()
            Return
        End If

        ' Business rule #3: Quantity must be numeric > 0
        Dim quantity As Integer
        If Not Integer.TryParse(txtQuantity.Text.Trim(), quantity) OrElse quantity <= 0 Then
            MessageBox.Show("Please enter a numeric Quantity greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtQuantity.Focus()
            Return
        End If

        ' Compute line total and add to ListBox
        Dim lineTotal As Decimal = price * quantity
        ' Format: Description (left), Price (currency), Quantity, LineTotal (currency)
        Dim displayString As String = String.Format("{0,-20} {1,12:C2} {2,8} {3,14:C2}", cmbDescription.Text, price, quantity, lineTotal)
        lstParts.Items.Add(displayString)

        ' Accumulate order total and update textbox
        orderTotal += lineTotal
        txtOrderTotal.Text = orderTotal.ToString("C2")

        ' Clear input controls and set focus to Description ComboBox
        cmbDescription.SelectedIndex = -1
        cmbDescription.Text = ""
        txtPrice.Clear()
        txtQuantity.Clear()
        cmbDescription.Focus()
    End Sub

    Private Sub countPartsInListBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles countPartsInListBoxToolStripMenuItem.Click
        Dim count = lstParts.Items.Count
        MessageBox.Show($"There are {count} item(s) in the Parts list.", "Count Parts", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub clearPartListBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles clearPartListBoxToolStripMenuItem.Click
        Dim result = MessageBox.Show("Clear all parts from the Part ListBox for a new order?", "Confirm Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            ' Unselect and clear combo and textboxes, clear listbox and reset order total
            cmbDescription.SelectedIndex = -1
            cmbDescription.Text = ""
            txtPrice.Clear()
            txtQuantity.Clear()
            lstParts.Items.Clear()
            orderTotal = 0D
            txtOrderTotal.Text = ""
            cmbDescription.Focus()
        End If
    End Sub

    Private Sub aboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles aboutToolStripMenuItem.Click
        MessageBox.Show("Auto Parts Order application" & vbCrLf & "Implemented per assignment requirements.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
