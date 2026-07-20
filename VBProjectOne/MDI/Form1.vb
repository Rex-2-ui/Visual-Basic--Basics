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

        'Create an instance of Form3
        Dim aForm As New Form3

        'Assign MdiParent property to the child
        aForm.MdiParent = Me

        'Show the child form
        aForm.Show()
    End Sub

    Private Sub Form4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Form4ToolStripMenuItem.Click

        'Create an instance of Form4
        Dim aForm As New Form4

        'Assign MdiParent property to the child
        aForm.MdiParent = Me

        'Show the child form
        aForm.Show()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub CloseToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem1.Click
        'close an activ echild form if any
        If Not Me.ActiveMdiChild Is Nothing Then
            Me.ActiveMdiChild.Close()
        End If
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadeToolStripMenuItem.Click
        'Using the layoutMidMethod and the MdiLayout Enumeration
        'Cascading

        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub HorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorizontalToolStripMenuItem.Click
        'Using the layoutMidMethod and the MdiLayout Enumeration
        'Horizontal

        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub VerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerticalToolStripMenuItem.Click
        'Using the layoutMidMethod and the MdiLayout Enumeration
        'vertical

        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub
End Class
