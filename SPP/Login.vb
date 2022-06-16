Public Class FormLogin
    Sub terbuka()
        Form_MenuUtama.login.Enabled = False
        Form_MenuUtama.logout.Enabled = True
        Form_MenuUtama.data_master.Enabled = True
        Form_MenuUtama.data_transaksi.Enabled = True
        Form_MenuUtama.laporan.Enabled = True
    End Sub

    Private Sub Btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If tb_username.Text = "" Or tb_password.Text = "" Then
            MsgBox("Semua kolom tidak boleh kosong", vbCritical, "Warning")
            tb_username.Focus()
        Else
            If tb_username.Text = "user" And tb_password.Text = "user" Then
                Me.Close()
                Call terbuka()
            Else
                MsgBox("Username atau Password anda salah", vbCritical, "Warning")
                tb_username.Clear()
                tb_password.Clear()
                tb_username.Focus()
            End If
        End If
    End Sub
End Class