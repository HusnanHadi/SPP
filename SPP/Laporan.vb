Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class Laporan
    Dim da As MySqlDataAdapter
    Dim ds As DataSet
    Private Sub Laporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call loadlaporan()
        Me.rvLaporan.RefreshReport()
    End Sub
    Sub loadlaporan()
        rvLaporan.RefreshReport()
        Dim datalaporan As ReportDataSource
        With rvLaporan.LocalReport
            .ReportPath = ""
            .DataSources.Clear()
        End With

        da = New MySqlDataAdapter("select * from tbspp", CONN)
        ds = New DataSet
        da.Fill(ds, "tbspp")

        datalaporan = New ReportDataSource("DataSet1", ds.Tables("tbspp"))
        rvLaporan.LocalReport.DataSources.Add(datalaporan)
        rvLaporan.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
    End Sub
    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles rvLaporan.Load

    End Sub
End Class