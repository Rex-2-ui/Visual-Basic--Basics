Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Form2ToolStripMenuItem.Click

        'Create an instance of Form2
        Dim aForm As New Form2

        'Assign MdiParent property to the child
        aForm.MdiParent = Me

        'Show the child form
        aForm.Show()
    End Sub

    Private Sub Form3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Form3ToolStripMenuItem.Click

        'Create an instance of Form2
        Dim aForm As New Form3

        'Assign MdiParent property to the child
        aForm.MdiParent = Me

        'Show the child form
        aForm.Show()
    End Sub
End Class
