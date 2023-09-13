Public Class GerenteGral_Principal
    Private Sub BCerrarSesion_Click(sender As Object, e As EventArgs) Handles BCerrarSesion.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Misdatos.ShowDialog()
    End Sub

    Private Sub Backup_Click(sender As Object, e As EventArgs) Handles Backup.Click
        Realizar_Backup.ShowDialog()
    End Sub

    Private Sub Informes_Click(sender As Object, e As EventArgs) Handles Informes.Click
        Restauracion.ShowDialog()
    End Sub

    Private Sub Productos_Click(sender As Object, e As EventArgs) Handles Productos.Click
        Permisos.ShowDialog()
    End Sub
End Class