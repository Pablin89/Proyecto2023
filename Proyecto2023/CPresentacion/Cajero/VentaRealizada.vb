Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class VentaRealizada


    Private Sub VentaRealizada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ReportViewer1.RefreshReport()
        MsgBox("A su izquierda, arriba del documento posee opciones para imprimir o guardar este comprobante", MsgBoxStyle.Information, "Comprobante")
    End Sub


End Class