﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKelas
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
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_namaKelas = New System.Windows.Forms.TextBox()
        Me.tb_kodeKelas = New System.Windows.Forms.TextBox()
        Me.dgvKelas = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_keluar = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvKelas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_simpan
        '
        Me.btn_simpan.Location = New System.Drawing.Point(6, 42)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(163, 40)
        Me.btn_simpan.TabIndex = 0
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tb_namaKelas)
        Me.GroupBox1.Controls.Add(Me.tb_kodeKelas)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(361, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nama Kelas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Kode Kelas"
        '
        'tb_namaKelas
        '
        Me.tb_namaKelas.Location = New System.Drawing.Point(161, 57)
        Me.tb_namaKelas.Name = "tb_namaKelas"
        Me.tb_namaKelas.Size = New System.Drawing.Size(167, 26)
        Me.tb_namaKelas.TabIndex = 2
        '
        'tb_kodeKelas
        '
        Me.tb_kodeKelas.Location = New System.Drawing.Point(161, 19)
        Me.tb_kodeKelas.Name = "tb_kodeKelas"
        Me.tb_kodeKelas.Size = New System.Drawing.Size(167, 26)
        Me.tb_kodeKelas.TabIndex = 2
        '
        'dgvKelas
        '
        Me.dgvKelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKelas.Location = New System.Drawing.Point(22, 118)
        Me.dgvKelas.Name = "dgvKelas"
        Me.dgvKelas.RowTemplate.Height = 28
        Me.dgvKelas.Size = New System.Drawing.Size(415, 174)
        Me.dgvKelas.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_keluar)
        Me.GroupBox2.Controls.Add(Me.btn_hapus)
        Me.GroupBox2.Controls.Add(Me.btn_edit)
        Me.GroupBox2.Controls.Add(Me.btn_simpan)
        Me.GroupBox2.Location = New System.Drawing.Point(443, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(175, 280)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "NAVIGATOR"
        '
        'btn_keluar
        '
        Me.btn_keluar.Location = New System.Drawing.Point(6, 180)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(163, 40)
        Me.btn_keluar.TabIndex = 0
        Me.btn_keluar.Text = "Keluar"
        Me.btn_keluar.UseVisualStyleBackColor = True
        '
        'btn_hapus
        '
        Me.btn_hapus.Location = New System.Drawing.Point(6, 134)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(163, 40)
        Me.btn_hapus.TabIndex = 0
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(6, 88)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(163, 40)
        Me.btn_edit.TabIndex = 0
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'FormKelas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 311)
        Me.Controls.Add(Me.dgvKelas)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormKelas"
        Me.Text = "Kelas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvKelas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_simpan As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_namaKelas As TextBox
    Friend WithEvents tb_kodeKelas As TextBox
    Friend WithEvents dgvKelas As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_keluar As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_edit As Button
End Class
