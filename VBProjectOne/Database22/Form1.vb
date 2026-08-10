Public Class Form1
    Private Sub DEPARTMENTBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DEPARTMENTBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DEPARTMENTBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.COMPANYDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'COMPANYDataSet.DEPARTMENT' table. You can move, or remove it, as needed.
        Me.DEPARTMENTTableAdapter.Fill(Me.COMPANYDataSet.DEPARTMENT)

    End Sub
End Class
