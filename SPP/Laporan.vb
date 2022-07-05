Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class Laporan
    Dim da As MySqlDataAdapter
    Dim ds As DataSet
    Private Sub Laporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call loadlaporan()
        Me.rpLaporan.RefreshReport()
    End Sub
    Sub loadlaporan()
        rpLaporan.RefreshReport()
        Dim datalaporan As ReportDataSource
        With rpLaporan.LocalReport
            .ReportPath = ""
            .DataSources.Clear()
        End With

        da = New MySqlDataAdapter("select * from tbspp", CONN)
        ds = New DataSet
        da.Fill(ds, "tbspp")

        datalaporan = New ReportDataSource("DataSet1", ds.Tables("tbspp"))
        rpLaporan.LocalReport.DataSources.Add(datalaporan)
        rpLaporan.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
    End Sub
    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles rpLaporan.Load

    End Sub
End Class