Public Class Realizar_Venta
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Baja_Clientes.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BBuscarProducto.Click
        Seleccionar_Producto.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LFecha.Text = DateAndTime.Today.ToLongDateString
        LHora.Text = DateAndTime.TimeOfDay
    End Sub

    Private Sub Realizar_Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub


End Class