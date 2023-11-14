Public Class ReporteProductos
    Private Sub ReporteGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'TODO: esta línea de código carga datos en la tabla 'Proyecto2023DataSet.CategoriasMasVendidas' Puede moverla o quitarla según sea necesario.
        Me.CategoriasMasVendidasTableAdapter.Fill(Me.Proyecto2023DataSet.CategoriasMasVendidas)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto2023DataSet.CategoriasMenosVendidas' Puede moverla o quitarla según sea necesario.
        Me.CategoriasMenosVendidasTableAdapter.Fill(Me.Proyecto2023DataSet.CategoriasMenosVendidas)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto2023DataSet.productosMasVendidos' Puede moverla o quitarla según sea necesario.
        Me.productosMasVendidosTableAdapter.Fill(Me.Proyecto2023DataSet.productosMasVendidos)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto2023DataSet.productosMenosVendidos' Puede moverla o quitarla según sea necesario.
        Me.productosMenosVendidosTableAdapter.Fill(Me.Proyecto2023DataSet.productosMenosVendidos)
        MsgBox("A su izquierda, arriba del documento posee opciones para imprimir o guardar este comprobante", MsgBoxStyle.Information, "Comprobante")

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub
End Class