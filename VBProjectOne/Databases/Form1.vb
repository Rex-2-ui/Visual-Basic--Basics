Imports System.Data.SqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Connection string to SQL Server
        ' Replace with your actual server name, database name, and authentication details
        Dim connStr As String = "Server=.;Database=COMPANY;Trusted_Connection=True;"
        ' If using SQL authentication:
        ' Dim connStr As String = "Server=YOUR_SERVER_NAME;Database=YOUR_DATABASE_NAME;User Id=YOUR_USERNAME;Password=YOUR_PASSWORD;"

        ' 2. Query your table
        Dim query As String = "SELECT * FROM EMPLOYEE"

        Try
            Using conn As New SqlConnection(connStr)
                Dim adapter As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                DataGridView1.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class
