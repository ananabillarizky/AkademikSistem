Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class Search_Mahasiswa
    Private ReadOnly conn As SqlConnection = New SqlConnection("Data Source=ANANABILLARIZKY; " &
                                                                "user id = sa; password=12; Integrated Security=True; " &
                                                                "database=SistemAkademik")
    Private ADP As SqlDataAdapter
    Private DS As New DataSet

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim query As String = "SELECT * FROM Mahasiswa WHERE NIM LIKE '%" & SearchTxtBox.Text & "%' OR nama LIKE '%" & SearchTxtBox.Text & "%'"


        Dim adapter As New SqlDataAdapter(query, conn)
        Dim dataTable As New DataTable()

        adapter.Fill(dataTable)

        Dgvmatkul.DataSource = dataTable
    End Sub


End Class