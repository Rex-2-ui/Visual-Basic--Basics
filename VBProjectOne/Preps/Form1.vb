Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NameTextBox.Text = "Douglas Bock"
        MajorTextBox.Text = "Computer Science"
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        NameTextBox.Text = ""
        MajorTextBox.Text = " "
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        NameTextBox.Text = "Samuel Oppong"
        MajorTextBox.Text = "Computer Management"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        NameTextBox.Text = "John Mensah"
        MajorTextBox.Text = "Computer Science"
    End Sub
End Class
