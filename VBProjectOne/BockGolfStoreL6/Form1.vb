Option Strict On
Public Class Form1


    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SelectItemComboBox.SelectedIndexChanged

    End Sub



    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?",
                                                 "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub


    ' Module-level variable to track total inventory value
    Private totalInventoryValue As Decimal = 0D

    Private Sub AddToItemListingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToItemListingToolStripMenuItem.Click
        If ValidData() Then
            ' Parse values
            Dim cost As Decimal = Decimal.Parse(WholeSaleTextBox.Text)
            Dim qty As Integer = Integer.Parse(QtyOfItemTextBox.Text)

            ' Compute item value
            Dim itemValue As Decimal = cost * qty

            ' Add item string to ListBox (Item + Item Value)
            Dim itemInfo As String = SelectItemComboBox.Text & " - Value: " & itemValue.ToString("C")
            InventoryItemListBox.Items.Add(itemInfo)

            ' Accumulate running total
            totalInventoryValue += itemValue
            TotalValueTextBox.Text = totalInventoryValue.ToString("C")

            ' Clear input controls
            SelectItemComboBox.SelectedIndex = -1
            WholeSaleTextBox.Clear()
            QtyOfItemTextBox.Clear()

            ' Reset focus
            SelectItemComboBox.Focus()
        End If
    End Sub

    Private Function ValidData() As Boolean
        ' Rule #1: Item selected
        If String.IsNullOrWhiteSpace(SelectItemComboBox.Text) Then
            MessageBox.Show("Please select an inventory item.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        ' Rule #2: Wholesale cost numeric > 0
        Dim cost As Decimal
        If Not Decimal.TryParse(WholeSaleTextBox.Text, cost) OrElse cost <= 0D Then
            MessageBox.Show("Wholesale cost must be a numeric value greater than zero and Not a decimal", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        ' Rule #3: Quantity numeric > 0
        Dim qty As Integer
        If Not Integer.TryParse(QtyOfItemTextBox.Text, qty) OrElse qty <= 0 Then
            MessageBox.Show("Quantity must be a numeric value greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    Private Sub ClearItemListingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearItemListingToolStripMenuItem.Click
        ' Ask user to confirm clearing
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to clear the item listing?",
                                                 "Confirm Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ' Default = No

        If result = DialogResult.Yes Then
            ' Unselect ComboBox item
            SelectItemComboBox.SelectedIndex = -1
            SelectItemComboBox.Text = String.Empty

            ' Clear TextBoxes
            WholeSaleTextBox.Clear()
            QtyOfItemTextBox.Clear()

            ' Clear ListBox
            InventoryItemListBox.Items.Clear()

            ' Reset total inventory value
            totalInventoryValue = 0D
            TotalValueTextBox.Text = totalInventoryValue.ToString("C")

            ' Reset focus
            SelectItemComboBox.Focus()
        End If
    End Sub
    Private Sub CountItemsInListingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CountItemsListingToolStripMenuItem.Click
        ' Count how many items are in the ComboBox
        Dim itemCount As Integer = SelectItemComboBox.Items.Count

        ' Show message box with appropriate title, icon, and buttons
        MessageBox.Show("There are " & itemCount.ToString() & " different inventory items available.",
                    "Inventory Item Count",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information)
    End Sub
    Private Sub AddItemToComboBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddItemToComboBoxToolStripMenuItem.Click
        Dim newItem As String = SelectItemComboBox.Text.Trim()

        ' Rule #1: No blank entries
        If String.IsNullOrEmpty(newItem) Then
            MessageBox.Show("Please type an item name before adding.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Rule #2: No duplicates (case-insensitive)
        For Each existingItem As String In SelectItemComboBox.Items
            If String.Equals(existingItem, newItem, StringComparison.OrdinalIgnoreCase) Then
                MessageBox.Show("This item already exists in the list.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Next

        ' Rule #3: Add item and keep sorted order
        SelectItemComboBox.Items.Add(newItem)
        SelectItemComboBox.Sorted = True

        ' Clear the ComboBox text and reset focus for next entry
        SelectItemComboBox.Text = String.Empty
        SelectItemComboBox.Focus()
    End Sub

    Private Sub DeleteComboBoxItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteComboBoxItemToolStripMenuItem.Click
        ' Check if an item is selected
        If SelectItemComboBox.SelectedIndex = -1 OrElse String.IsNullOrWhiteSpace(SelectItemComboBox.Text) Then
            MessageBox.Show("Please select an item to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Delete the selected item
        SelectItemComboBox.Items.RemoveAt(SelectItemComboBox.SelectedIndex)

        ' Clear the ComboBox text
        SelectItemComboBox.Text = String.Empty
    End Sub

    Private Sub SetFormBackgroundColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetBackgroundColorToolStripMenuItem.Click
        Dim colorDialog As New ColorDialog()

        If colorDialog.ShowDialog() = DialogResult.OK Then
            Me.BackColor = colorDialog.Color
        End If
    End Sub
    Private Sub SetFormFontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetFontToolStripMenuItem.Click
        Dim fontDialog As New FontDialog()

        If fontDialog.ShowDialog() = DialogResult.OK Then
            ' Apply font to the form itself
            Me.Font = fontDialog.Font

            ' Apply font to all controls on the form
            For Each ctrl As Control In Me.Controls
                ctrl.Font = fontDialog.Font
            Next

            ' Apply font to the MenuStrip explicitly
            MenuStrip1.Font = fontDialog.Font
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim aboutMessage As String = "Ali" & Environment.NewLine & DateTime.Now.ToString()
        MessageBox.Show(aboutMessage, "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Declare the ContextMenuStrip at the form level
    Private contextMenu As New ContextMenuStrip()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SelectItemComboBox.Focus()
        ' Build the context menu
        Dim colorItem As New ToolStripMenuItem("Color")
        Dim fontItem As New ToolStripMenuItem("Font")
        Dim exitItem As New ToolStripMenuItem("Exit")

        ' Add items with separator
        contextMenu.Items.Add(colorItem)
        contextMenu.Items.Add(fontItem)
        contextMenu.Items.Add(New ToolStripSeparator())
        contextMenu.Items.Add(exitItem)

        ' Assign handlers
        AddHandler colorItem.Click, AddressOf SetFormBackgroundColorToolStripMenuItem_Click
        AddHandler fontItem.Click, AddressOf SetFormFontToolStripMenuItem_Click
        AddHandler exitItem.Click, AddressOf ExitToolStripMenuItem_Click

        ' Attach context menu to the form
        Me.ContextMenuStrip = contextMenu
    End Sub


End Class
