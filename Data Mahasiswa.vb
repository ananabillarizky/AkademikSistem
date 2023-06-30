Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class Data_Mahasiswa

    Private ReadOnly conn As SqlConnection = New SqlConnection("Data Source=ANANABILLARIZKY; " &
                                                                "user id = sa; password=12; Integrated Security=True; " &
                                                                "database=SistemAkademik")

    Private ADP As SqlDataAdapter
    Private DS As New DataSet
    Private Sub BtnSimpan_Click_1(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Dim gender As String

        ' Periksa status CheckBox Laki-laki dan Perempuan
        If chekboxLaki.Checked Then
            gender = "Laki-laki"
        ElseIf chekboxPerempuan.Checked Then
            gender = "Perempuan"
        Else
            gender = "" ' Atau dapat diganti dengan nilai NULL atau nilai default yang sesuai
        End If

        Dim sqlins As String = "INSERT INTO Mahasiswa (NIM, nama, kelas, prodi, gender) " &
                "VALUES (@NIM, @Nama, @Kelas, @Prodi, @Gender)"

        Try
            conn.Open()
            Dim cmdInsert As SqlCommand = New SqlCommand(sqlins, conn)
            cmdInsert.Parameters.AddWithValue("@NIM", NIM.Text)
            cmdInsert.Parameters.AddWithValue("@Nama", nama.Text)
            cmdInsert.Parameters.AddWithValue("@Kelas", kelas.Text)
            cmdInsert.Parameters.AddWithValue("@Prodi", prodi.Text)
            cmdInsert.Parameters.AddWithValue("@Gender", gender)
            cmdInsert.ExecuteNonQuery()
            ViewTable()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Sub ViewTable()
        DS = New DataSet()
        NIM.Text = String.Empty
        nama.Text = String.Empty
        kelas.Text = String.Empty
        prodi.Text = String.Empty
        chekboxLaki.Checked = False
        chekboxPerempuan.Checked = False
        NIM.Enabled = True

        ADP = New SqlDataAdapter("SELECT * FROM Mahasiswa", conn)
        ADP.Fill(DS, "Data Mahasiswa")
        Dgvmatkul.DataSource = DS.Tables("Data Mahasiswa")
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles back.Click
        Dasbor_Admin.Show()
        Me.Hide()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If NIM.Text = "" Then
            MsgBox("Data Tidak Ada")
            Exit Sub
        Else
            Try
                If MessageBox.Show("Anda Yakin Ingin Menghapus Data?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    conn.Open()
                    Dim sqlins As String = "Delete Mahasiswa where NIM='" & NIM.Text & "'"
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

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If NIM.Text = "" Or nama.Text = "" Or kelas.Text = "" Or prodi.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            Try
                Dim gender As String = ""
                If chekboxLaki.Checked Then
                    gender = "Laki-laki"
                ElseIf chekboxPerempuan.Checked Then
                    gender = "Perempuan"
                End If
                Dim sqlins As String = "UPDATE Mahasiswa SET nama='" & nama.Text & "', Kelas='" & kelas.Text & "', prodi='" & prodi.Text & "', gender='" & gender & "' WHERE NIM='" & NIM.Text & "'"
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
        NIM.Text = Dgvmatkul.Rows(e.RowIndex).Cells(0).Value
        nama.Text = Dgvmatkul.Rows(e.RowIndex).Cells(1).Value
        kelas.Text = Dgvmatkul.Rows(e.RowIndex).Cells(2).Value
        prodi.Text = Dgvmatkul.Rows(e.RowIndex).Cells(3).Value
        Dim genderValue As String = Dgvmatkul.Rows(e.RowIndex).Cells(4).Value.ToString()
        If genderValue = "Laki-laki" Then
            chekboxLaki.Checked = True
            chekboxPerempuan.Checked = False
        ElseIf genderValue = "Perempuan" Then
            chekboxLaki.Checked = False
            chekboxPerempuan.Checked = True
        Else
            chekboxLaki.Checked = False
            chekboxPerempuan.Checked = False
        End If
        NIM.Enabled = False
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Dim searchForm As New Search_Mahasiswa()
        searchForm.Show()
        Me.Hide()

    End Sub
End Class