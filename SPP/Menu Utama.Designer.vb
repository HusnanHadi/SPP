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
        Me.MasterDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SiswaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KelasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DATATRANSAKSIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembayaranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LAPORANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanSiswaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KelasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LAPORANToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanSiswaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanKelasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPembayaranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterDataToolStripMenuItem, Me.DATATRANSAKSIToolStripMenuItem, Me.LAPORANToolStripMenuItem, Me.LAPORANToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(911, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterDataToolStripMenuItem
        '
        Me.MasterDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SiswaToolStripMenuItem, Me.KelasToolStripMenuItem})
        Me.MasterDataToolStripMenuItem.Name = "MasterDataToolStripMenuItem"
        Me.MasterDataToolStripMenuItem.Size = New System.Drawing.Size(55, 29)
        Me.MasterDataToolStripMenuItem.Text = "FILE"
        '
        'SiswaToolStripMenuItem
        '
        Me.SiswaToolStripMenuItem.Name = "SiswaToolStripMenuItem"
        Me.SiswaToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.SiswaToolStripMenuItem.Text = "Login"
        '
        'KelasToolStripMenuItem
        '
        Me.KelasToolStripMenuItem.Name = "KelasToolStripMenuItem"
        Me.KelasToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.KelasToolStripMenuItem.Text = "Logout"
        '
        'DATATRANSAKSIToolStripMenuItem
        '
        Me.DATATRANSAKSIToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PembayaranToolStripMenuItem, Me.KelasToolStripMenuItem1})
        Me.DATATRANSAKSIToolStripMenuItem.Name = "DATATRANSAKSIToolStripMenuItem"
        Me.DATATRANSAKSIToolStripMenuItem.Size = New System.Drawing.Size(140, 29)
        Me.DATATRANSAKSIToolStripMenuItem.Text = "DATA MASTER"
        '
        'PembayaranToolStripMenuItem
        '
        Me.PembayaranToolStripMenuItem.Name = "PembayaranToolStripMenuItem"
        Me.PembayaranToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.PembayaranToolStripMenuItem.Text = "Siswa"
        '
        'LAPORANToolStripMenuItem
        '
        Me.LAPORANToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanSiswaToolStripMenuItem})
        Me.LAPORANToolStripMenuItem.Name = "LAPORANToolStripMenuItem"
        Me.LAPORANToolStripMenuItem.Size = New System.Drawing.Size(165, 29)
        Me.LAPORANToolStripMenuItem.Text = "DATA TRANSAKSI"
        '
        'LaporanSiswaToolStripMenuItem
        '
        Me.LaporanSiswaToolStripMenuItem.Name = "LaporanSiswaToolStripMenuItem"
        Me.LaporanSiswaToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.LaporanSiswaToolStripMenuItem.Text = "Pembayaran"
        '
        'KelasToolStripMenuItem1
        '
        Me.KelasToolStripMenuItem1.Name = "KelasToolStripMenuItem1"
        Me.KelasToolStripMenuItem1.Size = New System.Drawing.Size(252, 30)
        Me.KelasToolStripMenuItem1.Text = "Kelas"
        '
        'LAPORANToolStripMenuItem1
        '
        Me.LAPORANToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanSiswaToolStripMenuItem1, Me.LaporanKelasToolStripMenuItem, Me.LaporanPembayaranToolStripMenuItem})
        Me.LAPORANToolStripMenuItem1.Name = "LAPORANToolStripMenuItem1"
        Me.LAPORANToolStripMenuItem1.Size = New System.Drawing.Size(105, 29)
        Me.LAPORANToolStripMenuItem1.Text = "LAPORAN"
        '
        'LaporanSiswaToolStripMenuItem1
        '
        Me.LaporanSiswaToolStripMenuItem1.Name = "LaporanSiswaToolStripMenuItem1"
        Me.LaporanSiswaToolStripMenuItem1.Size = New System.Drawing.Size(262, 30)
        Me.LaporanSiswaToolStripMenuItem1.Text = "Laporan Siswa"
        '
        'LaporanKelasToolStripMenuItem
        '
        Me.LaporanKelasToolStripMenuItem.Name = "LaporanKelasToolStripMenuItem"
        Me.LaporanKelasToolStripMenuItem.Size = New System.Drawing.Size(262, 30)
        Me.LaporanKelasToolStripMenuItem.Text = "Laporan Kelas"
        '
        'LaporanPembayaranToolStripMenuItem
        '
        Me.LaporanPembayaranToolStripMenuItem.Name = "LaporanPembayaranToolStripMenuItem"
        Me.LaporanPembayaranToolStripMenuItem.Size = New System.Drawing.Size(262, 30)
        Me.LaporanPembayaranToolStripMenuItem.Text = "Laporan Pembayaran"
        '
        'Form_MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 480)
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
    Friend WithEvents MasterDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SiswaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KelasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DATATRANSAKSIToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PembayaranToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KelasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LAPORANToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanSiswaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LAPORANToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LaporanSiswaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LaporanKelasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanPembayaranToolStripMenuItem As ToolStripMenuItem
End Class
