Public Class ReporteClientes


    Private Sub ReporteClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.clientesMasComprasTableAdapter.Connection.ConnectionString = "server = .\SQLEXPRESS; database = Proyecto2023; integrated security = true"
        Me.clientesMenosComprasTableAdapter.Connection.ConnectionString = "server = .\SQLEXPRESS; database = Proyecto2023; integrated security = true"
        Me.ultimosClientesTableAdapter.Connection.ConnectionString = "server = .\SQLEXPRESS; database = Proyecto2023; integrated security = true"
        'TODO: esta línea de código carga datos en la tabla 'Proyecto2023DataSet.clientesMasCompras' Puede moverla o quitarla según sea necesario.
        Me.clientesMasComprasTableAdapter.Fill(Me.Proyecto2023DataSet.clientesMasCompras)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto2023DataSet.clientesMenosCompras' Puede moverla o quitarla según sea necesario.
        Me.clientesMenosComprasTableAdapter.Fill(Me.Proyecto2023DataSet.clientesMenosCompras)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto2023DataSet.ultimosClientes' Puede moverla o quitarla según sea necesario.
        Me.ultimosClientesTableAdapter.Fill(Me.Proyecto2023DataSet.ultimosClientes)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class