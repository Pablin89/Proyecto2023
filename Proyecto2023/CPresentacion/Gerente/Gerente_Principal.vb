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
        Dim ask As MsgBoxResult
        ask = MsgBox("Desea cerrar su sesión?", vbYesNo + vbInformation, "Cerrar Sesión")
        If (MsgBoxResult.Yes = ask) Then
            Me.Hide()
            Login.Show()
        End If
    End Sub


    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Informes_General.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Misdatos.ShowDialog()
    End Sub
End Class