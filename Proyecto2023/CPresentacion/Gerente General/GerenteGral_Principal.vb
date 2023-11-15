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



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Misdatos.BModificarP.Visible = False
        Misdatos.ShowDialog()
    End Sub





    Private Sub GerenteGral_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If hayEmpleadosSinUsuarios() Then
            MsgBox("Atencion! existen empleados sin usuarios asignados. Para asignar usuarios hacer click en el boton ""Empleados Nuevos""", vbOKOnly + vbInformation, "Empleados sin usuario")
        Else

        End If
    End Sub

    Public Function hayEmpleadosSinUsuarios() As Boolean
        Dim nu As New NUsuarios()
        If nu.hayEmpleadosSinUsuarios() Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub ModificarUs_Click(sender As Object, e As EventArgs) Handles ModificarUs.Click
        ModificarUsuario.ShowDialog()
    End Sub

    Private Sub UsuariosNuevos_Click(sender As Object, e As EventArgs) Handles UsuariosNuevos.Click
        EmpleadosNuevos.ShowDialog()
    End Sub
End Class