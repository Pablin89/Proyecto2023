Public Class Cajero_Principal
    Private Sub BCerrarSesion_Click(sender As Object, e As EventArgs) Handles BCerrarSesion.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("Desea cerrar su sesión?", vbYesNo + vbInformation, "Cerrar Sesión")
        If (MsgBoxResult.Yes = ask) Then
            Me.Hide()
            Login.Show()
        End If

    End Sub

    Private Sub Productos_Click(sender As Object, e As EventArgs) Handles Productos.Click
        GestionProductos.ShowDialog()
    End Sub

    Private Sub Cajeros_Click(sender As Object, e As EventArgs) Handles Cajeros.Click
        Empleados.ShowDialog()
    End Sub





    Private Sub BajaClientes_Click(sender As Object, e As EventArgs) Handles BajaClientes.Click
        Baja_Cliente.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Baja_Ventas.ShowDialog()
    End Sub

    Private Sub BMisDatos_Click(sender As Object, e As EventArgs) Handles BMisDatos.Click

        Misdatos.BModificarP.Visible = True
        Misdatos.ShowDialog()
    End Sub
End Class