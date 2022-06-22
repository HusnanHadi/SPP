<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSiswa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.tb_kodeKelas = New System.Windows.Forms.TextBox()
        Me.tb_telpon = New System.Windows.Forms.TextBox()
        Me.tb_alamat = New System.Windows.Forms.TextBox()
        Me.tb_nama = New System.Windows.Forms.TextBox()
        Me.cb_thAjaran = New System.Windows.Forms.ComboBox()
        Me.cb_agama = New System.Windows.Forms.ComboBox()
        Me.cb_jkelamin = New System.Windows.Forms.ComboBox()
        Me.tb_nis = New System.Windows.Forms.TextBox()
        Me.dgvSiswa = New System.Windows.Forms.DataGridView()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_keluar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvSiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtp1)
        Me.GroupBox1.Controls.Add(Me.tb_kodeKelas)
        Me.GroupBox1.Controls.Add(Me.tb_telpon)
        Me.GroupBox1.Controls.Add(Me.tb_alamat)
        Me.GroupBox1.Controls.Add(Me.tb_nama)
        Me.GroupBox1.Controls.Add(Me.cb_thAjaran)
        Me.GroupBox1.Controls.Add(Me.cb_agama)
        Me.GroupBox1.Controls.Add(Me.cb_jkelamin)
        Me.GroupBox1.Controls.Add(Me.tb_nis)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(322, 340)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 260)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Tahun Ajaran"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 226)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Agama"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 295)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Kode Kelas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Telpon"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Alamat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Tanggal Lahir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIS"
        '
        'dtp1
        '
        Me.dtp1.Location = New System.Drawing.Point(134, 127)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(182, 26)
        Me.dtp1.TabIndex = 4
        '
        'tb_kodeKelas
        '
        Me.tb_kodeKelas.Location = New System.Drawing.Point(134, 292)
        Me.tb_kodeKelas.Name = "tb_kodeKelas"
        Me.tb_kodeKelas.Size = New System.Drawing.Size(182, 26)
        Me.tb_kodeKelas.TabIndex = 9
        '
        'tb_telpon
        '
        Me.tb_telpon.Location = New System.Drawing.Point(134, 191)
        Me.tb_telpon.Name = "tb_telpon"
        Me.tb_telpon.Size = New System.Drawing.Size(182, 26)
        Me.tb_telpon.TabIndex = 6
        '
        'tb_alamat
        '
        Me.tb_alamat.Location = New System.Drawing.Point(134, 159)
        Me.tb_alamat.Name = "tb_alamat"
        Me.tb_alamat.Size = New System.Drawing.Size(182, 26)
        Me.tb_alamat.TabIndex = 5
        '
        'tb_nama
        '
        Me.tb_nama.Location = New System.Drawing.Point(134, 61)
        Me.tb_nama.Name = "tb_nama"
        Me.tb_nama.Size = New System.Drawing.Size(182, 26)
        Me.tb_nama.TabIndex = 2
        '
        'cb_thAjaran
        '
        Me.cb_thAjaran.FormattingEnabled = True
        Me.cb_thAjaran.Location = New System.Drawing.Point(134, 257)
        Me.cb_thAjaran.Name = "cb_thAjaran"
        Me.cb_thAjaran.Size = New System.Drawing.Size(182, 28)
        Me.cb_thAjaran.TabIndex = 8
        '
        'cb_agama
        '
        Me.cb_agama.FormattingEnabled = True
        Me.cb_agama.Location = New System.Drawing.Point(134, 223)
        Me.cb_agama.Name = "cb_agama"
        Me.cb_agama.Size = New System.Drawing.Size(182, 28)
        Me.cb_agama.TabIndex = 7
        '
        'cb_jkelamin
        '
        Me.cb_jkelamin.FormattingEnabled = True
        Me.cb_jkelamin.Location = New System.Drawing.Point(134, 93)
        Me.cb_jkelamin.Name = "cb_jkelamin"
        Me.cb_jkelamin.Size = New System.Drawing.Size(182, 28)
        Me.cb_jkelamin.TabIndex = 3
        '
        'tb_nis
        '
        Me.tb_nis.Location = New System.Drawing.Point(134, 29)
        Me.tb_nis.Name = "tb_nis"
        Me.tb_nis.Size = New System.Drawing.Size(182, 26)
        Me.tb_nis.TabIndex = 1
        '
        'dgvSiswa
        '
        Me.dgvSiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSiswa.Location = New System.Drawing.Point(340, 12)
        Me.dgvSiswa.Name = "dgvSiswa"
        Me.dgvSiswa.RowTemplate.Height = 28
        Me.dgvSiswa.Size = New System.Drawing.Size(454, 286)
        Me.dgvSiswa.TabIndex = 4
        '
        'btn_simpan
        '
        Me.btn_simpan.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btn_simpan.Location = New System.Drawing.Point(340, 304)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(109, 48)
        Me.btn_simpan.TabIndex = 10
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = False
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btn_edit.Location = New System.Drawing.Point(455, 304)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(109, 48)
        Me.btn_edit.TabIndex = 11
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_hapus
        '
        Me.btn_hapus.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btn_hapus.Location = New System.Drawing.Point(570, 304)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(109, 48)
        Me.btn_hapus.TabIndex = 12
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = False
        '
        'btn_keluar
        '
        Me.btn_keluar.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btn_keluar.Location = New System.Drawing.Point(685, 304)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(109, 48)
        Me.btn_keluar.TabIndex = 13
        Me.btn_keluar.Text = "Keluar"
        Me.btn_keluar.UseVisualStyleBackColor = False
        '
        'FormSiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(811, 372)
        Me.Controls.Add(Me.btn_keluar)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.dgvSiswa)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormSiswa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Siswa"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvSiswa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tb_nis As TextBox
    Friend WithEvents cb_jkelamin As ComboBox
    Friend WithEvents dtp1 As DateTimePicker
    Friend WithEvents dgvSiswa As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_telpon As TextBox
    Friend WithEvents tb_alamat As TextBox
    Friend WithEvents tb_nama As TextBox
    Friend WithEvents cb_thAjaran As ComboBox
    Friend WithEvents cb_agama As ComboBox
    Friend WithEvents btn_simpan As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_keluar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents tb_kodeKelas As TextBox
End Class
