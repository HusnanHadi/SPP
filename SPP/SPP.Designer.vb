<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSPP
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp2 = New System.Windows.Forms.DateTimePicker()
        Me.cb_jkelamin = New System.Windows.Forms.ComboBox()
        Me.cb_bulanBayar = New System.Windows.Forms.ComboBox()
        Me.cb_thajaran = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_totalBayar = New System.Windows.Forms.TextBox()
        Me.tb_denda = New System.Windows.Forms.TextBox()
        Me.tb_jmlhBayar = New System.Windows.Forms.TextBox()
        Me.tb_namaKelas = New System.Windows.Forms.TextBox()
        Me.tb_kodeKelas = New System.Windows.Forms.TextBox()
        Me.tb_nama = New System.Windows.Forms.TextBox()
        Me.tb_nis = New System.Windows.Forms.TextBox()
        Me.tb_noPembayaran = New System.Windows.Forms.TextBox()
        Me.dgvSPP = New System.Windows.Forms.DataGridView()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.tb_pencarian = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_keluar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvSPP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtp2)
        Me.GroupBox1.Controls.Add(Me.cb_jkelamin)
        Me.GroupBox1.Controls.Add(Me.cb_bulanBayar)
        Me.GroupBox1.Controls.Add(Me.cb_thajaran)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tb_totalBayar)
        Me.GroupBox1.Controls.Add(Me.tb_denda)
        Me.GroupBox1.Controls.Add(Me.tb_jmlhBayar)
        Me.GroupBox1.Controls.Add(Me.tb_namaKelas)
        Me.GroupBox1.Controls.Add(Me.tb_kodeKelas)
        Me.GroupBox1.Controls.Add(Me.tb_nama)
        Me.GroupBox1.Controls.Add(Me.tb_nis)
        Me.GroupBox1.Controls.Add(Me.tb_noPembayaran)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(345, 438)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 395)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 20)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Total Bayar"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 363)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 20)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Denda"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 331)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 20)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Jumlah Bayar"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 297)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(143, 20)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Bulan Pembayaran"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 265)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 20)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Nama Kelas"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 233)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Kode Kelas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Tahun Ajaran"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Jenis Kelamin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "NIS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Tanggal Bayar"
        '
        'dtp2
        '
        Me.dtp2.Location = New System.Drawing.Point(177, 66)
        Me.dtp2.Name = "dtp2"
        Me.dtp2.Size = New System.Drawing.Size(162, 26)
        Me.dtp2.TabIndex = 4
        '
        'cb_jkelamin
        '
        Me.cb_jkelamin.FormattingEnabled = True
        Me.cb_jkelamin.Location = New System.Drawing.Point(177, 162)
        Me.cb_jkelamin.Name = "cb_jkelamin"
        Me.cb_jkelamin.Size = New System.Drawing.Size(162, 28)
        Me.cb_jkelamin.TabIndex = 2
        '
        'cb_bulanBayar
        '
        Me.cb_bulanBayar.FormattingEnabled = True
        Me.cb_bulanBayar.Location = New System.Drawing.Point(177, 294)
        Me.cb_bulanBayar.Name = "cb_bulanBayar"
        Me.cb_bulanBayar.Size = New System.Drawing.Size(162, 28)
        Me.cb_bulanBayar.TabIndex = 2
        '
        'cb_thajaran
        '
        Me.cb_thajaran.FormattingEnabled = True
        Me.cb_thajaran.Location = New System.Drawing.Point(177, 196)
        Me.cb_thajaran.Name = "cb_thajaran"
        Me.cb_thajaran.Size = New System.Drawing.Size(162, 28)
        Me.cb_thajaran.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "No Pembayaran"
        '
        'tb_totalBayar
        '
        Me.tb_totalBayar.Location = New System.Drawing.Point(177, 392)
        Me.tb_totalBayar.Name = "tb_totalBayar"
        Me.tb_totalBayar.Size = New System.Drawing.Size(162, 26)
        Me.tb_totalBayar.TabIndex = 1
        '
        'tb_denda
        '
        Me.tb_denda.Location = New System.Drawing.Point(177, 360)
        Me.tb_denda.Name = "tb_denda"
        Me.tb_denda.Size = New System.Drawing.Size(162, 26)
        Me.tb_denda.TabIndex = 1
        '
        'tb_jmlhBayar
        '
        Me.tb_jmlhBayar.Location = New System.Drawing.Point(177, 328)
        Me.tb_jmlhBayar.Name = "tb_jmlhBayar"
        Me.tb_jmlhBayar.Size = New System.Drawing.Size(162, 26)
        Me.tb_jmlhBayar.TabIndex = 1
        '
        'tb_namaKelas
        '
        Me.tb_namaKelas.Location = New System.Drawing.Point(177, 262)
        Me.tb_namaKelas.Name = "tb_namaKelas"
        Me.tb_namaKelas.Size = New System.Drawing.Size(162, 26)
        Me.tb_namaKelas.TabIndex = 1
        '
        'tb_kodeKelas
        '
        Me.tb_kodeKelas.Location = New System.Drawing.Point(177, 230)
        Me.tb_kodeKelas.Name = "tb_kodeKelas"
        Me.tb_kodeKelas.Size = New System.Drawing.Size(162, 26)
        Me.tb_kodeKelas.TabIndex = 1
        '
        'tb_nama
        '
        Me.tb_nama.Location = New System.Drawing.Point(177, 130)
        Me.tb_nama.Name = "tb_nama"
        Me.tb_nama.Size = New System.Drawing.Size(162, 26)
        Me.tb_nama.TabIndex = 1
        '
        'tb_nis
        '
        Me.tb_nis.Location = New System.Drawing.Point(177, 98)
        Me.tb_nis.Name = "tb_nis"
        Me.tb_nis.Size = New System.Drawing.Size(162, 26)
        Me.tb_nis.TabIndex = 1
        '
        'tb_noPembayaran
        '
        Me.tb_noPembayaran.Location = New System.Drawing.Point(177, 34)
        Me.tb_noPembayaran.Name = "tb_noPembayaran"
        Me.tb_noPembayaran.Size = New System.Drawing.Size(162, 26)
        Me.tb_noPembayaran.TabIndex = 1
        '
        'dgvSPP
        '
        Me.dgvSPP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSPP.Location = New System.Drawing.Point(363, 54)
        Me.dgvSPP.Name = "dgvSPP"
        Me.dgvSPP.RowTemplate.Height = 28
        Me.dgvSPP.Size = New System.Drawing.Size(430, 334)
        Me.dgvSPP.TabIndex = 3
        '
        'btn_simpan
        '
        Me.btn_simpan.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btn_simpan.Location = New System.Drawing.Point(363, 394)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(103, 46)
        Me.btn_simpan.TabIndex = 5
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = False
        '
        'tb_pencarian
        '
        Me.tb_pencarian.Location = New System.Drawing.Point(631, 12)
        Me.tb_pencarian.Name = "tb_pencarian"
        Me.tb_pencarian.Size = New System.Drawing.Size(162, 26)
        Me.tb_pencarian.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(460, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(119, 20)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Pencarian Data"
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btn_edit.Location = New System.Drawing.Point(472, 394)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(103, 46)
        Me.btn_edit.TabIndex = 5
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_hapus
        '
        Me.btn_hapus.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btn_hapus.Location = New System.Drawing.Point(581, 394)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(103, 46)
        Me.btn_hapus.TabIndex = 5
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = False
        '
        'btn_keluar
        '
        Me.btn_keluar.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btn_keluar.Location = New System.Drawing.Point(690, 394)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(103, 46)
        Me.btn_keluar.TabIndex = 5
        Me.btn_keluar.Text = "Keluar"
        Me.btn_keluar.UseVisualStyleBackColor = False
        '
        'FormSPP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(810, 505)
        Me.Controls.Add(Me.btn_keluar)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.dgvSPP)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.tb_pencarian)
        Me.Name = "FormSPP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SPP"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvSPP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tb_noPembayaran As TextBox
    Friend WithEvents cb_thajaran As ComboBox
    Friend WithEvents dgvSPP As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents dtp2 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_nama As TextBox
    Friend WithEvents tb_nis As TextBox
    Friend WithEvents btn_simpan As Button
    Friend WithEvents cb_jkelamin As ComboBox
    Friend WithEvents tb_kodeKelas As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cb_bulanBayar As ComboBox
    Friend WithEvents tb_totalBayar As TextBox
    Friend WithEvents tb_denda As TextBox
    Friend WithEvents tb_jmlhBayar As TextBox
    Friend WithEvents tb_namaKelas As TextBox
    Friend WithEvents tb_pencarian As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_keluar As Button
End Class
