Public Class Login
    Sub KosongkanField()
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        If txtUsername.Text = "" And txtPassword.Text = "" Then
            MsgBox("Masukan User dan Password!!")
        ElseIf txtUsername.Text = "Admin" And txtPassword.Text = "admin" Then
            Dasbor_Admin.Show()
            Call KosongkanField()
            Me.Hide()

        ElseIf txtUsername.Text = "Mahasiswa" And txtPassword.Text = "1234" Then
            Dasbor_Mahasiswa.Show()
            Call KosongkanField()
            Me.Hide()
        Else
            MsgBox("User dan Password salah!! ")
            txtUsername.Text = ""
            txtPassword.Text = ""
        End If
    End Sub
End Class
