Public Class ReporteFechas
    Private Sub ReporteFechas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Proyecto2023DataSet.VentasFechas' Puede moverla o quitarla según sea necesario.
        Me.VentasFechasTableAdapter.Connection.ConnectionString = "server = .\SQLEXPRESS; database = Proyecto2023; integrated security = true"
        Me.VentasFechasTableAdapter.Fill(Me.Proyecto2023DataSet.VentasFechas)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class