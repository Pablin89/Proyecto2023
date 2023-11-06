Public Class ReporteClientes
    Private Sub ReporteClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MsgBox("A su izquierda, arriba del documento posee opciones para imprimir o guardar este comprobante", MsgBoxStyle.Information, "Comprobante")
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class