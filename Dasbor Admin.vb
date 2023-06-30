Public Class Dasbor_Admin
    Private Sub BtnMahasiswa_Click(sender As Object, e As EventArgs) Handles BtnMahasiswa.Click
        Data_Mahasiswa.Show()
        Me.Hide()
    End Sub

    Private Sub BtnMatkul_Click(sender As Object, e As EventArgs) Handles BtnMatkul.Click
        Data_Matkul.Show()
        Me.Hide()
    End Sub

    Private Sub BtnNilai_Click(sender As Object, e As EventArgs) Handles BtnNilai.Click
        Data_Nilai.Show()
        Me.Hide()
    End Sub

    Private Sub BtnDosen_Click(sender As Object, e As EventArgs) Handles BtnDosen.Click
        Data_Dosen.Show()
        Me.Hide()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles back.Click
        Login.Show()
        Me.Hide()
    End Sub
End Class