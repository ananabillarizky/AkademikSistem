Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class Data_Dosen

    Private ReadOnly conn As SqlConnection = New SqlConnection("Data Source=ANANABILLARIZKY; " &
                                                                "user id = sa; password=12; Integrated Security=True; " &
                                                                "database=SistemAkademik")

    Private ADP As SqlDataAdapter
    Private DS As New DataSet

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LblCRUD.Click

    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Dim sqlins As String = "insert into dosen (NIP, nama_dosen, Matkul) " &
                "values(@nip, @nama_dosen, @matkul)"

        Try
            conn.Open()
            Dim cmdInsert As SqlCommand = New SqlCommand(sqlins, conn)
            cmdInsert.Parameters.AddWithValue("@nip", NIP.Text)
            cmdInsert.Parameters.AddWithValue("@nama_dosen", nama_dosen.Text)
            cmdInsert.Parameters.AddWithValue("@matkul", Matkul.Text)
            cmdInsert.ExecuteNonQuery()
            ViewTable()

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            conn.Close()
        End Try
    End Sub
    Sub ViewTable()
        ADP = New SqlDataAdapter("Select * From dosen", conn)
        DS = New DataSet
        NIP.Text = String.Empty
        nama_dosen.Text = String.Empty
        Matkul.Text = String.Empty
        NIP.Enabled = True
        ADP.Fill(DS, "Data Dosen")
        DgvBarang.DataSource = DS.Tables("Data Dosen")
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If NIP.Text = "" Or nama_dosen.Text = "" Or Matkul.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            Try
                Dim sqlins As String = "update dosen set nama_dosen='" & nama_dosen.Text & "',matkul='" & Matkul.Text & "' where nip='" & NIP.Text & "'"
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

    Private Sub DgvBarang_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvBarang.CellMouseClick
        On Error Resume Next
        NIP.Text = DgvBarang.Rows(e.RowIndex).Cells(0).Value
        nama_dosen.Text = DgvBarang.Rows(e.RowIndex).Cells(1).Value
        Matkul.Text = DgvBarang.Rows(e.RowIndex).Cells(2).Value
        NIP.Enabled = False

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If NIP.Text = "" Then
            MsgBox("Data Tidak Ada")
            Exit Sub
        Else
            Try
                If MessageBox.Show("Anda Yakin Ingin Menghapus Data?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    conn.Open()
                    Dim sqlins As String = "Delete dosen where nip='" & NIP.Text & "'"
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dasbor_Admin.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim query As String = "SELECT * FROM dosen WHERE nip LIKE '%" & SearchTxtBox.Text & "%' OR nama_dosen LIKE '%" & SearchTxtBox.Text & "%'"

        Dim adapter As New SqlDataAdapter(query, conn)
        Dim dataTable As New DataTable()

        adapter.Fill(dataTable)

        DgvBarang.DataSource = dataTable
    End Sub

End Class