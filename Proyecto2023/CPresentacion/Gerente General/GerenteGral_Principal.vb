Public Class GerenteGral_Principal
    Private Sub BCerrarSesion_Click(sender As Object, e As EventArgs) Handles BCerrarSesion.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("Desea cerrar su sesión?", vbYesNo + vbInformation, "Cerrar Sesión")
        If (MsgBoxResult.Yes = ask) Then
            Me.Hide()
            Login.Show()
        End If
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Misdatos.BModificarP.Visible = False
        Misdatos.ShowDialog()
    End Sub
End Class