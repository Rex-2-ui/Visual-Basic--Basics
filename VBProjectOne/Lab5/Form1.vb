Public Class Form1


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        CoffeeComboBox.Sorted = True



        SyrupListBox.Sorted = True
    End Sub

    ' === Edit Menu ===
    Private Sub AddCoffeeFlavorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddCoffeeFlavorToolStripMenuItem.Click
        Dim newFlavor As String = InputBox("Enter a new coffee flavor:")
        If newFlavor <> "" Then
            If Not CoffeeComboBox.Items.Contains(newFlavor) Then
                CoffeeComboBox.Items.Add(newFlavor)
            Else
                MessageBox.Show("This flavor already exists!", "Duplicate Entry")
            End If
        End If
    End Sub

    Private Sub RemoveCoffeeFlavorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveCoffeeFlavorToolStripMenuItem.Click
        If CoffeeComboBox.SelectedItem IsNot Nothing Then
            CoffeeComboBox.Items.Remove(CoffeeComboBox.SelectedItem)
        Else
            MessageBox.Show("Select a coffee flavor to remove.")
        End If
    End Sub

    Private Sub ClearCoffeeListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearCoffeeListToolStripMenuItem.Click
        CoffeeComboBox.Items.Clear()
    End Sub

    Private Sub DisplayCoffeeCountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayCoffeeCountToolStripMenuItem.Click
        MessageBox.Show("Total coffee flavors: " & CoffeeComboBox.Items.Count.ToString(), "Coffee Count")
    End Sub




    Private Sub PrintSelectedFlavorPrintPreviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintSelectedFlavorsPrintPreviewToolStripMenuItem1.Click
        Dim coffee As String = If(CoffeeComboBox.SelectedItem, "(None)").ToString()
        Dim syrup As String = If(SyrupListBox.SelectedItem, "(None)").ToString()
        MessageBox.Show("Selected Coffee: " & coffee & vbCrLf & "Selected Syrup: " & syrup, "Print Selected ")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim aboutForm As New AboutForm()
        aboutForm.ShowDialog()



    End Sub
    Private Sub PrintAllFlavorsPrintPreviwToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintAllFlavorsPrintPreviewToolStripMenuItem.Click
        Dim output As String = "Coffee Flavors:" & vbCrLf
        For Each flavor As String In CoffeeComboBox.Items
            output &= flavor & vbCrLf
        Next

        output &= vbCrLf & "Syrup Flavors:" & vbCrLf
        For Each syrup As String In SyrupListBox.Items
            output &= syrup & vbCrLf
        Next

        MessageBox.Show(output, "All Flavors")
    End Sub



End Class
