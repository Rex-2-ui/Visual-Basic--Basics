Imports System.Data.OleDb

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Path to your Access database
        Dim dbPath As String = "C:\PathTo\YourDatabase.accdb"

        ' 2. Connection string
        Dim connStr As String = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=" & dbPath & ";"

        ' 3. Query your table (replace YourTableName with your actual table name)
        Dim query As String = "SELECT * FROM YourTableName"

        Try
            ' 4. Fill DataAdapter and bind to DataGridView
            Dim adapter As New OleDbDataAdapter(query, connStr)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

End Class