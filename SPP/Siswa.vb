Imports MySql.Data.MySqlClient
Public Class FormSiswa
    Dim con As MySqlConnection
    Dim cmd As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim dr As MySqlDataReader
    Dim ds As DataSet
    Dim myDB As String
    Sub koneksi()
        myDB = "Database=project;Server=localhost;uid=root;password="
        con = New MySqlConnection(myDB)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub
    Sub kondisiawal()
        tb_nis.Text = ""
        tb_nama.Text = ""
        cb_jkelamin.Text = ""
        tb_alamat.Text = ""
        tb_telpon.Text = ""
        cb_agama.Text = ""
        cb_thAjaran.Text = ""
        tb_nis.Enabled = False
        tb_nama.Enabled = False
        cb_jkelamin.Enabled = False
        tb_telpon.Enabled = False
        tb_alamat.Enabled = False
        dtp1.Enabled = False
        cb_agama.Enabled = False
        cb_thAjaran.Enabled = False

        btn_simpan.Text = "Input"
        btn_edit.Text = "Edit"
        btn_hapus.Text = "Hapus"
        btn_keluar.Text = "Keluar"

        btn_simpan.Enabled = True
        btn_edit.Enabled = True
        btn_hapus.Enabled = True
        btn_keluar.Enabled = True

        Call koneksi()
        ModuleSPP.OpenConnection()
        da = New MySqlDataAdapter("select * from tbsiswa", con)
        ds = New DataSet
        da.Fill(ds)
        dgvSiswa.DataSource = ds.Tables(0)
        ModuleSPP.CloseConnection()
    End Sub


    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        Call kondisiawal()
    End Sub
    Sub fieldaktif()
        tb_nis.Enabled = True
        tb_nama.Enabled = True
        cb_jkelamin.Enabled = True
        tb_alamat.Enabled = True
        tb_telpon.Enabled = True
        dtp1.Enabled = True
        cb_thAjaran.Enabled = True
        cb_agama.Enabled = True
        tb_nis.Focus()
    End Sub

    Private Sub Btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If btn_simpan.Text = "Input" Then
            btn_simpan.Text = "Simpan"

            btn_edit.Enabled = False
            btn_hapus.Enabled = False
            btn_keluar.Text = "Batal"

            Call fieldaktif()
        Else
            If tb_nis.Text = "" Or tb_nama.Text = "" Or cb_jkelamin.Text = "" Or tb_alamat.Text = "" Or tb_telpon.Text = "" Or cb_agama.Text = "" Or cb_thAjaran.Text = "" Then

                MsgBox("Pastikan semua kolom terisi")
            Else
                Call koneksi()

                Dim inputdata As String = "insert into tbsiswa values('" & tb_nis.Text & "','" & tb_nama.Text & "','" & cb_jkelamin.Text & "','" & tb_alamat.Text & "','" & tb_telpon.Text & "','" & cb_agama.Text & "','" & cb_thAjaran.Text & "')"
                cmd = New MySqlCommand(inputdata, con)
                cmd.ExecuteNonQuery()

                MsgBox("Input data berhasil")

                Call kondisiawal()
            End If
        End If
    End Sub

    Private Sub tb_nis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_nis.KeyPress

    End Sub
End Class