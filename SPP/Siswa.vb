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
        cb_jkelamin.ResetText()
        dtp1.ResetText()
        tb_alamat.Text = ""
        tb_telpon.Text = ""
        cb_agama.Text = ""
        cb_agama.ResetText()
        cb_thMasuk.Text = ""
        cb_thMasuk.ResetText()
        tb_kodeKelas.Text = ""
        tb_namaKelas.Text = ""
        tb_nis.Enabled = False
        tb_nama.Enabled = False
        cb_jkelamin.Enabled = False
        dtp1.Enabled = False
        tb_telpon.Enabled = False
        tb_alamat.Enabled = False
        cb_agama.Enabled = False
        cb_thMasuk.Enabled = False
        tb_kodeKelas.Enabled = False
        tb_namaKelas.Enabled = False
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
    Private Sub FormSiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call kondisiawal()
    End Sub
    Sub fieldaktif()
        tb_nis.Enabled = True
        tb_nama.Enabled = True
        cb_jkelamin.Enabled = True
        dtp1.Enabled = True
        tb_alamat.Enabled = True
        tb_telpon.Enabled = True
        cb_agama.Enabled = True
        cb_thMasuk.Enabled = True
        tb_kodeKelas.Enabled = True
        tb_namaKelas.Enabled = True
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
            If tb_nis.Text = "" Or tb_nama.Text = "" Or cb_jkelamin.Text = "" Or tb_alamat.Text = "" Or tb_telpon.Text = "" Or cb_agama.Text = "" Or cb_thMasuk.Text = "" Or tb_kodeKelas.Text = "" Or tb_namaKelas.Text = "" Then
                MsgBox("Pastikan semua kolom terisi")
            Else
                Call koneksi()

                Dim inputdata As String = "insert into tbsiswa values('" & tb_nis.Text & "','" & tb_nama.Text & "','" & cb_jkelamin.Text & "','" & Format(dtp1.Value, "yyyy-MM-dd") & "','" & tb_alamat.Text & "','" & tb_telpon.Text & "','" & cb_agama.Text & "','" & cb_thMasuk.Text & "','" & tb_kodeKelas.Text & "','" & tb_namaKelas.Text & "')"
                cmd = New MySqlCommand(inputdata, con)
                cmd.ExecuteNonQuery()

                MsgBox("Input data berhasil")

                Call kondisiawal()
            End If
        End If
    End Sub

    Private Sub tb_nis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_nis.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()

            cmd = New MySqlCommand("select * from tbsiswa where nis ='" & tb_nis.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                tb_nis.Text = dr.Item("nis")
                tb_nama.Text = dr.Item("nama_siswa")
                cb_jkelamin.Text = dr.Item("jenis_kelamin")
                dtp1.Value = dr.Item("tanggal_lahir")
                tb_alamat.Text = dr.Item("alamat")
                tb_telpon.Text = dr.Item("telpon")
                cb_agama.Text = dr.Item("agama")
                cb_thMasuk.Text = dr.Item("tahun_masuk")
                tb_kodeKelas.Text = dr.Item("Kode_kelas")
                tb_namaKelas.Text = dr.Item("nama_kelas")
            Else
                MsgBox("Data tidak ada")
            End If
        End If
    End Sub

    Private Sub dgvSiswa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSiswa.CellClick
        tb_nis.Text = dgvSiswa.Rows(e.RowIndex).Cells(0).Value
        tb_nama.Text = dgvSiswa.Rows(e.RowIndex).Cells(1).Value
        cb_jkelamin.Text = dgvSiswa.Rows(e.RowIndex).Cells(2).Value
        dtp1.Value = dgvSiswa.Rows(e.RowIndex).Cells(3).Value
        tb_alamat.Text = dgvSiswa.Rows(e.RowIndex).Cells(4).Value
        tb_telpon.Text = dgvSiswa.Rows(e.RowIndex).Cells(5).Value
        cb_agama.Text = dgvSiswa.Rows(e.RowIndex).Cells(6).Value
        cb_thMasuk.Text = dgvSiswa.Rows(e.RowIndex).Cells(7).Value
        tb_kodeKelas.Text = dgvSiswa.Rows(e.RowIndex).Cells(8).Value
        tb_namaKelas.Text = dgvSiswa.Rows(e.RowIndex).Cells(9).Value
    End Sub

    Private Sub Btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If btn_edit.Text = "Edit" Then
            btn_edit.Text = "Update"

            btn_simpan.Enabled = False
            btn_hapus.Enabled = False
            btn_keluar.Text = "Batal"

            Call fieldaktif()
        Else
            If tb_nis.Text = "" Or tb_nama.Text = "" Or cb_jkelamin.Text = "" Or tb_alamat.Text = "" Or tb_telpon.Text = "" Or cb_agama.Text = "" Or cb_thMasuk.Text = "" Or tb_kodeKelas.Text = "" Or tb_namaKelas.Text = "" Then
                MsgBox("Pastikan semua kolom terisi penuh")
            Else
                Call koneksi()
                Dim editdata As String = "Update tbsiswa set nama_siswa ='" & tb_nama.Text & "', jenis_kelamin ='" & cb_jkelamin.Text & "', tanggal_lahir ='" & Format(dtp1.Value, ("yyyy-MM-dd")) & "', alamat ='" & tb_alamat.Text & "', telpon ='" & tb_telpon.Text & "', agama ='" & cb_agama.Text & "', tahun_masuk ='" & cb_thMasuk.Text & "', kode_kelas ='" & tb_kodeKelas.Text & "', nama_kelas ='" & tb_namaKelas.Text & "' Where nis ='" & tb_nis.Text & "'"
                cmd = New MySqlCommand(editdata, con)
                cmd.ExecuteNonQuery()

                MsgBox("Edit data berhasil")
                Call kondisiawal()
            End If
        End If
    End Sub

    Private Sub Btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        If btn_hapus.Text = "Hapus" Then
            btn_hapus.Text = "Delete"
            btn_simpan.Enabled = False
            btn_edit.Enabled = False
            btn_keluar.Text = "Batal"

            Call fieldaktif()
        Else
            If tb_nis.Text = "" Or tb_nama.Text = "" Or cb_jkelamin.Text = "" Or tb_alamat.Text = "" Or tb_telpon.Text = "" Or cb_agama.Text = "" Or cb_thMasuk.Text = "" Or tb_kodeKelas.Text = "" Or tb_namaKelas.Text = "" Then
                MsgBox("Pastika data yang akan dihapus terisi")
            Else
                Call koneksi()
                Dim hapusdata As String = "Delete from tbsiswa where nis = '" & tb_nis.Text & "'"
                cmd = New MySqlCommand(hapusdata, con)
                cmd.ExecuteNonQuery()

                MsgBox("Hapus data berhasil")

                Call kondisiawal()
            End If
        End If
    End Sub

    Private Sub Btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        If btn_keluar.Text = "Keluar" Then
            Me.Close()
        Else
            Call kondisiawal()
        End If
    End Sub

    Private Sub Btn_cari_Click(sender As Object, e As EventArgs) Handles btn_cari.Click
        Call koneksi()
        cmd = New MySqlCommand("select * from tbsiswa where nama_siswa like '%" & tb_cari.Text & "%'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Call koneksi()
            da = New MySqlDataAdapter("select * from tbsiswa where nama_siswa like '%" & tb_cari.Text & "%'", con)
            ds = New DataSet
            da.Fill(ds, "DataKetemu")
            dgvSiswa.DataSource = ds.Tables("DataKetemu")
            dgvSiswa.ReadOnly = True
        End If
    End Sub

    Private Sub tb_cari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_cari.KeyPress
        If e.KeyChar = Chr(13) Then
            btn_cari.PerformClick()
        End If
    End Sub
    Private Sub tb_kodeKelas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_kodeKelas.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()

            cmd = New MySqlCommand("select * from tbkelas where kode_kelas ='" & tb_kodeKelas.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                tb_kodeKelas.Text = dr.Item("Kode_kelas")
                tb_namaKelas.Text = dr.Item("nama_kelas")
            Else
                MsgBox("Data tidak ada")
            End If
        End If
    End Sub
    Private Sub tb_namaKelas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_namaKelas.KeyPress
        If e.KeyChar = Chr(13) Then
            btn_simpan.PerformClick()
        End If
        If e.KeyChar = Chr(13) Then
            btn_edit.PerformClick()
        End If
        If e.KeyChar = Chr(13) Then
            btn_hapus.PerformClick()
        End If
    End Sub
End Class