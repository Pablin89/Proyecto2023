Public Class ReporteGeneral
    Private Sub ReporteGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("A su izquierda, arriba del documento posee opciones para imprimir o guardar este comprobante", MsgBoxStyle.Information, "Comprobante")

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class