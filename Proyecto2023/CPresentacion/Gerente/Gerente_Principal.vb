Public Class Gerente_Principal
    Private Sub Productos_Click(sender As Object, e As EventArgs) Handles Productos.Click
        Informes_Productos.ShowDialog
    End Sub

    Private Sub Cajeros_Click(sender As Object, e As EventArgs) Handles Cajeros.Click
        Informes_Cajeros.ShowDialog()
    End Sub

    Private Sub BajaClientes_Click(sender As Object, e As EventArgs) Handles BajaClientes.Click
        Informes_Clientes.ShowDialog()
    End Sub

    Private Sub BCerrarSesion_Click(sender As Object, e As EventArgs) Handles BCerrarSesion.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Misdatos.ShowDialog()
    End Sub
End Class