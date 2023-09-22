Public Class Realizar_Venta
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Baja_Clientes.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Seleccionar_Producto.ShowDialog()
    End Sub
End Class