Public Class Form_MenuUtama
    Sub terkonci()
        login.Enabled = True
        logout.Enabled = False
        data_master.Enabled = False
        data_transaksi.Enabled = False

    End Sub
    Private Sub Form_MenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call terkonci()
    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles login.Click
        FormLogin.ShowDialog()
    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Call terkonci()
    End Sub

    Private Sub Kelas_Click(sender As Object, e As EventArgs) Handles kelas.Click
        FormKelas.ShowDialog()
    End Sub

    Private Sub Siswa_Click(sender As Object, e As EventArgs) Handles siswa.Click
        FormSiswa.ShowDialog()
    End Sub

    Private Sub Pembayaran_Click(sender As Object, e As EventArgs) Handles pembayaran.Click
        FormSPP.ShowDialog()
    End Sub
End Class
