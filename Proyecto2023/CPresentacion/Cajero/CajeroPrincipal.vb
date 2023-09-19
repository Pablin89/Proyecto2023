Public Class CajeroPrincipal

    Private Sub BCerrarSesion_Click(sender As Object, e As EventArgs) Handles BCerrarSesion.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Misdatos.ShowDialog()
    End Sub

    Private Sub RealizarVenta_Click(sender As Object, e As EventArgs) Handles RealizarVenta.Click
        Realizar_Venta.ShowDialog()
    End Sub

    Private Sub AgregarUsuario_Click(sender As Object, e As EventArgs) Handles AgregarUsuario.Click
        Seleccion_Clientes.ShowDialog()
    End Sub
End Class