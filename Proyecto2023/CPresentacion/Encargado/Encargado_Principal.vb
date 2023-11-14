Public Class Cajero_Principal
    Private Sub BCerrarSesion_Click(sender As Object, e As EventArgs) Handles BCerrarSesion.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("Desea cerrar su sesión?", vbYesNo + vbInformation, "Cerrar Sesión")
        If (MsgBoxResult.Yes = ask) Then
            Login.Show()
            Me.Close()
            Login.iniciarLogin()
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

    Private Sub Cajero_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If hayPocoStock() Then
            MsgBox("Atencion! existen productos con poco stock, para ver los productos ir a la sección de productos del menú principal.", vbOKOnly + vbInformation, "Poco stock")
        Else

        End If
    End Sub

    Public Function hayPocoStock() As Boolean
        Dim np As New NProductos()
        If np.hayPocoStock() Then
            Return True
        Else
            Return False
        End If
    End Function




End Class