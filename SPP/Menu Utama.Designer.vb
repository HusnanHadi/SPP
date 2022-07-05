<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_MenuUtama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_MenuUtama))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.file = New System.Windows.Forms.ToolStripMenuItem()
        Me.logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.login = New System.Windows.Forms.ToolStripMenuItem()
        Me.data_master = New System.Windows.Forms.ToolStripMenuItem()
        Me.siswa = New System.Windows.Forms.ToolStripMenuItem()
        Me.kelas = New System.Windows.Forms.ToolStripMenuItem()
        Me.data_transaksi = New System.Windows.Forms.ToolStripMenuItem()
        Me.pembayaran = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.file, Me.data_master, Me.data_transaksi})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(911, 32)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'file
        '
        Me.file.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.logout, Me.login})
        Me.file.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.file.Name = "file"
        Me.file.Size = New System.Drawing.Size(62, 28)
        Me.file.Text = "FILE"
        '
        'logout
        '
        Me.logout.Image = CType(resources.GetObject("logout.Image"), System.Drawing.Image)
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(146, 30)
        Me.logout.Text = "Logout"
        '
        'login
        '
        Me.login.Image = CType(resources.GetObject("login.Image"), System.Drawing.Image)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(146, 30)
        Me.login.Text = "Login"
        '
        'data_master
        '
        Me.data_master.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.siswa, Me.kelas})
        Me.data_master.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.data_master.Name = "data_master"
        Me.data_master.Size = New System.Drawing.Size(155, 28)
        Me.data_master.Text = "DATA MASTER"
        '
        'siswa
        '
        Me.siswa.Image = CType(resources.GetObject("siswa.Image"), System.Drawing.Image)
        Me.siswa.Name = "siswa"
        Me.siswa.Size = New System.Drawing.Size(141, 30)
        Me.siswa.Text = "Siswa"
        '
        'kelas
        '
        Me.kelas.Image = CType(resources.GetObject("kelas.Image"), System.Drawing.Image)
        Me.kelas.Name = "kelas"
        Me.kelas.Size = New System.Drawing.Size(141, 30)
        Me.kelas.Text = "Kelas"
        '
        'data_transaksi
        '
        Me.data_transaksi.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pembayaran})
        Me.data_transaksi.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.data_transaksi.Name = "data_transaksi"
        Me.data_transaksi.Size = New System.Drawing.Size(185, 28)
        Me.data_transaksi.Text = "DATA TRANSAKSI"
        '
        'pembayaran
        '
        Me.pembayaran.Image = CType(resources.GetObject("pembayaran.Image"), System.Drawing.Image)
        Me.pembayaran.Name = "pembayaran"
        Me.pembayaran.Size = New System.Drawing.Size(188, 30)
        Me.pembayaran.Text = "Pembayaran"
        '
        'Form_MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(911, 479)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
End Class
