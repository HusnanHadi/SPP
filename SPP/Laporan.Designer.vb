<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Laporan))
        Me.tbsppBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetLaporan = New SPP.DataSetLaporan()
        Me.rvLaporan = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.tbsppBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetLaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbsppBindingSource
        '
        Me.tbsppBindingSource.DataMember = "tbspp"
        Me.tbsppBindingSource.DataSource = Me.DataSetLaporan
        '
        'DataSetLaporan
        '
        Me.DataSetLaporan.DataSetName = "DataSetLaporan"
        Me.DataSetLaporan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rvLaporan
        '
        Me.rvLaporan.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tbsppBindingSource
        Me.rvLaporan.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvLaporan.LocalReport.ReportEmbeddedResource = "SPP.Report.rdlc"
        Me.rvLaporan.Location = New System.Drawing.Point(0, 0)
        Me.rvLaporan.Name = "rvLaporan"
        Me.rvLaporan.ServerReport.BearerToken = Nothing
        Me.rvLaporan.Size = New System.Drawing.Size(594, 365)
        Me.rvLaporan.TabIndex = 0
        '
        'Laporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 365)
        Me.Controls.Add(Me.rvLaporan)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Laporan"
        Me.Text = "Laporan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.tbsppBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetLaporan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rvLaporan As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbsppBindingSource As BindingSource
    Friend WithEvents DataSetLaporan As DataSetLaporan
End Class
