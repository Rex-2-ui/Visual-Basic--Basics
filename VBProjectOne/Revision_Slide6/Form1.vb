Public Class Form1
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EmployeeListBox.SelectedIndexChanged

    End Sub

    Private Sub AddDepartmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddDepartmentToolStripMenuItem.Click
        If DepartmentComboBox.Text <> String.Empty Then
            'Ok to add
            DepartmentComboBox.Items.Add(DepartmentComboBox.Text)
        Else
            'Cannot add
            MessageBox.Show("You must type a new department name.", "Name Missing Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DepartmentComboBox.Focus()
        End If

    End Sub

    Private Sub AddEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddEmployeeToolStripMenuItem.Click
        'Build the string to add
        Dim NewEmployeeString As String = EmployeeNameTextBox.Text & ", " & TitleComboBox.Text & ", " & DepartmentComboBox.Text & ", " & AnnualSalaryTextBox.Text

        'Add string to ListBox
        EmployeeListBox.Items.Add(NewEmployeeString)

        'Clear the form - ready to add another employee
        EmployeeNameTextBox.Clear()
        TitleComboBox.SelectedIndex = -1
        DepartmentComboBox.SelectedIndex = -1
        AnnualSalaryTextBox.Clear()

        'Set focus
        EmployeeNameTextBox.Focus()

    End Sub

    Private Sub ClearEmployeeListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearEmployeeListToolStripMenuItem.Click
        Dim ResponseDialogResult As DialogResult = MessageBox.Show("Clear employee listing Y/N?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        'Test to confirm whether to clear listing
        If ResponseDialogResult = DialogResult.Yes Then
            EmployeeListBox.Items.Clear()
        End If
    End Sub
End Class
