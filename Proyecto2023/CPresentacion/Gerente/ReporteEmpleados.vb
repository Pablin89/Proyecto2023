Public Class ReporteEmpleados
    Private Sub ReporteCajeros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EmpleadoMenosTableAdapter.Connection.ConnectionString = "server = .\SQLEXPRESS; database = Proyecto2023; integrated security = true"
        Me.EmpleadoMasVentasTableAdapter.Connection.ConnectionString = "server = .\SQLEXPRESS; database = Proyecto2023; integrated security = true"
        Me.UltimosEmpleadosTableAdapter.Connection.ConnectionString = "server = .\SQLEXPRESS; database = Proyecto2023; integrated security = true"
        'TODO: esta línea de código carga datos en la tabla 'Proyecto2023DataSet.EmpleadoMenos' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoMenosTableAdapter.Fill(Me.Proyecto2023DataSet.EmpleadoMenos)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto2023DataSet.EmpleadoMasVentas' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoMasVentasTableAdapter.Fill(Me.Proyecto2023DataSet.EmpleadoMasVentas)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto2023DataSet.UltimosEmpleados' Puede moverla o quitarla según sea necesario.
        Me.UltimosEmpleadosTableAdapter.Fill(Me.Proyecto2023DataSet.UltimosEmpleados)
        MsgBox("A su izquierda, arriba del documento posee opciones para imprimir o guardar este comprobante", MsgBoxStyle.Information, "Comprobante")

        'Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class