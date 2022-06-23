Imports MySql.Data.MySqlClient
Public Class FormSPP
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
        tb_noPembayaran.Text = ""
        dtp2.ResetText()
        tb_nis.Text = ""
        cb_sppBulan.Text = ""
        tb_jmlhBayar.Text = ""
        tb_noPembayaran.Enabled = False
        dtp2.Enabled = False
        tb_nis.Enabled = False
        cb_sppBulan.Enabled = False
        tb_jmlhBayar.Enabled = False

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
        da = New MySqlDataAdapter("select * from tbspp", con)
        ds = New DataSet
        da.Fill(ds)
        dgvSPP.DataSource = ds.Tables(0)
        ModuleSPP.CloseConnection()
    End Sub
    Sub fieldaktif()
        tb_noPembayaran.Enabled = True
        dtp2.Enabled = True
        tb_nis.Enabled = True

        cb_sppBulan.Enabled = True
        tb_jmlhBayar.Enabled = True

        tb_noPembayaran.Focus()
    End Sub
    Private Sub FormSPP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_sppBulan.Items.Add("Januari")
        cb_sppBulan.Items.Add("Februari")
        cb_sppBulan.Items.Add("Maret")
        cb_sppBulan.Items.Add("April")
        cb_sppBulan.Items.Add("Mei")
        cb_sppBulan.Items.Add("Juni")
        cb_sppBulan.Items.Add("Juli")
        cb_sppBulan.Items.Add("Agustus")
        cb_sppBulan.Items.Add("September")
        cb_sppBulan.Items.Add("Oktober")
        cb_sppBulan.Items.Add("November")
        cb_sppBulan.Items.Add("Desember")
        Call kondisiawal()
    End Sub
    Private Sub tb_noPembayaran_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_noPembayaran.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()

            cmd = New MySqlCommand("select * from tbspp where no_pembayaran ='" & tb_noPembayaran.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                tb_noPembayaran.Text = dr.Item("no_pembayaran")
                tb_nis.Text = dr.Item("nis")
                dtp2.Value = dr.Item("tanggal_bayar")
                cb_sppBulan.Text = dr.Item("spp_bulan")
                tb_jmlhBayar.Text = dr.Item("jumlah")
            Else
                MsgBox("Data tidak ada")
            End If
        End If
    End Sub

    Private Sub Btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If btn_simpan.Text = "Input" Then
            btn_simpan.Text = "Simpan"

            btn_edit.Enabled = False
            btn_hapus.Enabled = False
            btn_keluar.Text = "Batal"

            Call fieldaktif()
        Else
            If tb_noPembayaran.Text = "" Or tb_nis.Text = "" Or cb_sppBulan.Text = "" Or tb_jmlhBayar.Text = "" Then
                MsgBox("Pastikan semua kolom terisi")
            Else
                Call koneksi()

                Dim inputdata As String = "insert into tbspp values('" & tb_noPembayaran.Text & "','" & cb_sppBulan.Text & "','" & Format(dtp2.Value, "yyyy-MM-dd") & "','" & tb_jmlhBayar.Text & "','" & tb_nis.Text & "')"
                cmd = New MySqlCommand(inputdata, con)
                cmd.ExecuteNonQuery()

                MsgBox("Input data berhasil")

                Call kondisiawal()
            End If
        End If
    End Sub

    Private Sub Btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If btn_edit.Text = "Edit" Then
            btn_edit.Text = "Update"

            btn_simpan.Enabled = False
            btn_hapus.Enabled = False
            btn_keluar.Text = "Batal"

            Call fieldaktif()
        Else
            If tb_noPembayaran.Text = "" Or tb_nis.Text = "" Or cb_sppBulan.Text = "" Or tb_jmlhBayar.Text = "" Then
                MsgBox("Pastikan semua kolom terisi penuh")
            Else
                Call koneksi()
                Dim editdata As String = "Update tbspp set spp_bulan ='" & cb_sppBulan.Text & "', tanggal_bayar ='" & Format(dtp2.Value, ("yyyy-MM-dd")) & "', jumlah ='" & tb_jmlhBayar.Text & "', nis ='" & tb_nis.Text & "' Where no_pembayaran ='" & tb_noPembayaran.Text & "'"
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
            If tb_noPembayaran.Text = "" Or tb_nis.Text = "" Or cb_sppBulan.Text = "" Or tb_jmlhBayar.Text = "" Then
                MsgBox("Pastika data yang akan dihapus terisi")
            Else
                Call koneksi()
                Dim hapusdata As String = "Delete from tbspp where no_pembayaran = '" & tb_noPembayaran.Text & "'"
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

    Private Sub dgvSPP_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSPP.CellClick
        tb_noPembayaran.Text = dgvSPP.Rows(e.RowIndex).Cells(0).Value
        cb_sppBulan.Text = dgvSPP.Rows(e.RowIndex).Cells(1).Value
        dtp2.Value = dgvSPP.Rows(e.RowIndex).Cells(2).Value
        tb_jmlhBayar.Text = dgvSPP.Rows(e.RowIndex).Cells(3).Value
        tb_nis.Text = dgvSPP.Rows(e.RowIndex).Cells(4).Value

    End Sub

    Private Sub Btn_cari_Click(sender As Object, e As EventArgs) Handles btn_cari.Click
        Call koneksi()
        cmd = New MySqlCommand("select * from tbspp where no_pembayaran like '%" & tb_cari.Text & "%'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Call koneksi()
            da = New MySqlDataAdapter("select * from tbspp where no_pembayaran like '%" & tb_cari.Text & "%'", con)
            ds = New DataSet
            da.Fill(ds, "DataKetemu")
            dgvSPP.DataSource = ds.Tables("DataKetemu")
            dgvSPP.ReadOnly = True
        End If
    End Sub

    Private Sub tb_cari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_cari.KeyPress
        If e.KeyChar = Chr(13) Then
            btn_cari.PerformClick()
        End If
    End Sub
End Class