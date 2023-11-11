Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Reporting.WinForms
Imports System.IO
Imports System.Data.SqlClient

Public Class VentaRealizada

    Public NombreReporte As String = "Proyecto2023.Venta.rdlc"
    Public FormaReporte As String = "Normal"

    Private Sub VentaRealizada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        facturar()
        'MsgBox("A su izquierda, arriba del documento posee opciones para imprimir o guardar este comprobante", MsgBoxStyle.Information, "Comprobante")
    End Sub

    Public Sub facturar()
        Dim dt As New DataTable
        Dim dt2 As New DataTable

        Try

            ReporteFactura.adaptador.Fill(dt)
            Dim rds As ReportDataSource = New ReportDataSource
            rds.Name = "dsDetalleFactura"
            rds.Value = dt

            ReporteFactura.adaptador2.Fill(dt2)
            Dim rds2 As ReportDataSource = New ReportDataSource
            rds2.Name = "dsEncabezadoFactura"
            rds2.Value = dt2

            ReportViewer1.Reset()
            ReportViewer1.LocalReport.ReportEmbeddedResource = NombreReporte
            ReportViewer1.LocalReport.EnableExternalImages = True

            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(rds)
            ReportViewer1.LocalReport.DataSources.Add(rds2)

            Dim newPageSettings As New System.Drawing.Printing.PageSettings
            newPageSettings.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)

            If FormaReporte = "Acostado" Then
                newPageSettings.Landscape = True
            End If
            ReportViewer1.SetPageSettings(newPageSettings)
            Me.ReportViewer1.RefreshReport()

        Catch ex As Exception
            Console.WriteLine(Err.Description)
        End Try
    End Sub
End Class