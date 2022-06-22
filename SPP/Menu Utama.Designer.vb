<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_MenuUtama
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.file = New System.Windows.Forms.ToolStripMenuItem()
        Me.logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.login = New System.Windows.Forms.ToolStripMenuItem()
        Me.data_master = New System.Windows.Forms.ToolStripMenuItem()
        Me.siswa = New System.Windows.Forms.ToolStripMenuItem()
        Me.kelas = New System.Windows.Forms.ToolStripMenuItem()
        Me.data_transaksi = New System.Windows.Forms.ToolStripMenuItem()
        Me.pembayaran = New System.Windows.Forms.ToolStripMenuItem()
        Me.laporan = New System.Windows.Forms.ToolStripMenuItem()
        Me.laporan_siswa = New System.Windows.Forms.ToolStripMenuItem()
        Me.laporan_kelas = New System.Windows.Forms.ToolStripMenuItem()
        Me.laporan_pembayaran = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.file, Me.data_master, Me.data_transaksi, Me.laporan})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(911, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'file
        '
        Me.file.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.logout, Me.login})
        Me.file.Name = "file"
        Me.file.Size = New System.Drawing.Size(55, 29)
        Me.file.Text = "FILE"
        '
        'logout
        '
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(153, 30)
        Me.logout.Text = "Logout"
        '
        'login
        '
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(153, 30)
        Me.login.Text = "Login"
        '
        'data_master
        '
        Me.data_master.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.siswa, Me.kelas})
        Me.data_master.Name = "data_master"
        Me.data_master.Size = New System.Drawing.Size(140, 29)
        Me.data_master.Text = "DATA MASTER"
        '
        'siswa
        '
        Me.siswa.Name = "siswa"
        Me.siswa.Size = New System.Drawing.Size(252, 30)
        Me.siswa.Text = "Siswa"
        '
        'kelas
        '
        Me.kelas.Name = "kelas"
        Me.kelas.Size = New System.Drawing.Size(252, 30)
        Me.kelas.Text = "Kelas"
        '
        'data_transaksi
        '
        Me.data_transaksi.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pembayaran})
        Me.data_transaksi.Name = "data_transaksi"
        Me.data_transaksi.Size = New System.Drawing.Size(165, 29)
        Me.data_transaksi.Text = "DATA TRANSAKSI"
        '
        'pembayaran
        '
        Me.pembayaran.Name = "pembayaran"
        Me.pembayaran.Size = New System.Drawing.Size(252, 30)
        Me.pembayaran.Text = "Pembayaran"
        '
        'laporan
        '
        Me.laporan.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.laporan_siswa, Me.laporan_kelas, Me.laporan_pembayaran})
        Me.laporan.Name = "laporan"
        Me.laporan.Size = New System.Drawing.Size(105, 29)
        Me.laporan.Text = "LAPORAN"
        '
        'laporan_siswa
        '
        Me.laporan_siswa.Name = "laporan_siswa"
        Me.laporan_siswa.Size = New System.Drawing.Size(262, 30)
        Me.laporan_siswa.Text = "Laporan Siswa"
        '
        'laporan_kelas
        '
        Me.laporan_kelas.Name = "laporan_kelas"
        Me.laporan_kelas.Size = New System.Drawing.Size(262, 30)
        Me.laporan_kelas.Text = "Laporan Kelas"
        '
        'laporan_pembayaran
        '
        Me.laporan_pembayaran.Name = "laporan_pembayaran"
        Me.laporan_pembayaran.Size = New System.Drawing.Size(262, 30)
        Me.laporan_pembayaran.Text = "Laporan Pembayaran"
        '
        'Form_MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(911, 479)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form_MenuUtama"
        Me.Text = "Menu Utama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents file As ToolStripMenuItem
    Friend WithEvents login As ToolStripMenuItem
    Friend WithEvents logout As ToolStripMenuItem
    Friend WithEvents data_master As ToolStripMenuItem
    Friend WithEvents siswa As ToolStripMenuItem
    Friend WithEvents kelas As ToolStripMenuItem
    Friend WithEvents data_transaksi As ToolStripMenuItem
    Friend WithEvents pembayaran As ToolStripMenuItem
    Friend WithEvents laporan As ToolStripMenuItem
    Friend WithEvents laporan_siswa As ToolStripMenuItem
    Friend WithEvents laporan_kelas As ToolStripMenuItem
    Friend WithEvents laporan_pembayaran As ToolStripMenuItem
End Class
