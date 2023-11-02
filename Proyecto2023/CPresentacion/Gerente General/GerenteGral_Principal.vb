Public Class GerenteGral_Principal
    Private Sub BCerrarSesion_Click(sender As Object, e As EventArgs) Handles BCerrarSesion.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("Desea cerrar su sesión?", vbYesNo + vbInformation, "Cerrar Sesión")
        If (MsgBoxResult.Yes = ask) Then
            Login.Show()
            Me.Hide()
            Login.iniciarLogin()
        End If
    End Sub



    Private Sub Backup_Click(sender As Object, e As EventArgs) Handles Backup.Click
        RBackup.ShowDialog()
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

    Private Sub GerenteGral_Principal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        End

    End Sub
End Class