<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_username = New System.Windows.Forms.TextBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_password = New System.Windows.Forms.TextBox()
        Me.cb_tmplPassword = New System.Windows.Forms.CheckBox()
        Me.btn_keluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SELAMAT DATANG"
        '
        'tb_username
        '
        Me.tb_username.Location = New System.Drawing.Point(124, 117)
        Me.tb_username.Name = "tb_username"
        Me.tb_username.Size = New System.Drawing.Size(173, 26)
        Me.tb_username.TabIndex = 1
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btn_login.Location = New System.Drawing.Point(124, 232)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(173, 40)
        Me.btn_login.TabIndex = 4
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(120, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(120, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Password"
        '
        'tb_password
        '
        Me.tb_password.Location = New System.Drawing.Point(124, 169)
        Me.tb_password.Name = "tb_password"
        Me.tb_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_password.Size = New System.Drawing.Size(173, 26)
        Me.tb_password.TabIndex = 2
        '
        'cb_tmplPassword
        '
        Me.cb_tmplPassword.AutoSize = True
        Me.cb_tmplPassword.Location = New System.Drawing.Point(124, 202)
        Me.cb_tmplPassword.Name = "cb_tmplPassword"
        Me.cb_tmplPassword.Size = New System.Drawing.Size(180, 24)
        Me.cb_tmplPassword.TabIndex = 3
        Me.cb_tmplPassword.Text = "Tampilkan Password"
        Me.cb_tmplPassword.UseVisualStyleBackColor = True
        '
        'btn_keluar
        '
        Me.btn_keluar.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btn_keluar.Location = New System.Drawing.Point(124, 278)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(173, 40)
        Me.btn_keluar.TabIndex = 5
        Me.btn_keluar.Text = "Keluar"
        Me.btn_keluar.UseVisualStyleBackColor = False
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(416, 378)
        Me.Controls.Add(Me.cb_tmplPassword)
        Me.Controls.Add(Me.btn_keluar)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.tb_password)
        Me.Controls.Add(Me.tb_username)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tb_username As TextBox
    Friend WithEvents btn_login As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_password As TextBox
    Friend WithEvents cb_tmplPassword As CheckBox
    Friend WithEvents btn_keluar As Button
End Class
