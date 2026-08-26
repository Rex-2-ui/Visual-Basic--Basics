Public Class Form1
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SelectedEmployeeListBox.SelectedIndexChanged

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
End Class
