Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class Data_Matkul

    Private ReadOnly conn As SqlConnection = New SqlConnection("Data Source=ANANABILLARIZKY; " &
                                                            "user id = sa; password=12; Integrated Security=True; " &
                                                            "database=SistemAkademik")

    Private ADP As SqlDataAdapter
    Private DS As New DataSet

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim sqlIns As String = "insert into matkul (id_matkul, nama_matkul, prodi) " &
                           "values (@id_matkul, @nama_matkul, @prodi)"

        Try
            conn.Open()
            Dim cmdInsert As SqlCommand = New SqlCommand(sqlIns, conn)
            cmdInsert.Parameters.AddWithValue("@id_matkul", id_matkul.Text)
            cmdInsert.Parameters.AddWithValue("@nama_matkul", nama_kuliah.Text)
            cmdInsert.Parameters.AddWithValue("@prodi", prodi.Text)
            cmdInsert.ExecuteNonQuery()
            ViewTable()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            conn.Close()
        End Try
    End Sub


    Private Sub ViewTable()
        ADP = New SqlDataAdapter("SELECT * FROM matkul", conn)
        DS = New DataSet
        id_matkul.Text = String.Empty
        nama_kuliah.Text = String.Empty
        prodi.Text = String.Empty
        id_matkul.Enabled = True
        ADP.Fill(DS, "Data Matkul")
        Dgvmatkul.DataSource = DS.Tables("Data Matkul")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If id_matkul.Text = "" Or nama_kuliah.Text = "" Or prodi.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            Try
                Dim sqlins As String = "update matkul set nama_matkul='" & nama_kuliah.Text & "',prodi='" & prodi.Text & "' where id_matkul='" & id_matkul.Text & "'"
                conn.Open()
                Dim cmdInsert As SqlCommand = New SqlCommand(sqlins, conn)
                cmdInsert.ExecuteNonQuery()
                ViewTable()

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub DgvBarang_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Dgvmatkul.CellMouseClick
        On Error Resume Next
        id_matkul.Text = Dgvmatkul.Rows(e.RowIndex).Cells(0).Value
        nama_kuliah.Text = Dgvmatkul.Rows(e.RowIndex).Cells(1).Value
        prodi.Text = Dgvmatkul.Rows(e.RowIndex).Cells(2).Value
        id_matkul.Enabled = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dasbor_Admin.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If id_matkul.Text = "" Then
            MsgBox("Data Tidak Ada")
            Exit Sub
        Else
            Try
                If MessageBox.Show("Anda Yakin Ingin Menghapus Data?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    conn.Open()
                    Dim sqlins As String = "Delete matkul where id_matkul='" & id_matkul.Text & "'"
                    Dim cmdInsert As SqlCommand = New SqlCommand(sqlins, conn)
                    cmdInsert.ExecuteNonQuery()
                    MsgBox("Data Telah Dihapus")
                    ViewTable()
                Else
                    MsgBox("Data tidak jadi dihapus")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim query As String = "SELECT * FROM matkul WHERE id_matkul LIKE '%" & SearchTxtBox.Text & "%' OR nama_matkul LIKE '%" & SearchTxtBox.Text & "%'"

        Dim adapter As New SqlDataAdapter(query, conn)
        Dim dataTable As New DataTable()

        adapter.Fill(dataTable)

        Dgvmatkul.DataSource = dataTable
    End Sub

    Private Sub SearchTxtBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTxtBox.TextChanged

    End Sub

    Private Sub LblCRUD_Click(sender As Object, e As EventArgs) Handles LblCRUD.Click

    End Sub
End Class