Imports System.Data.SqlClient
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Public Class Login

    Dim U As New NUsuarios
    Dim datos As New DataTable

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        iniciarLogin()
    End Sub

    Public Sub iniciarLogin()

        CajeroPrincipal.Close()
        Cajero_Principal.Close()
        GerenteGral_Principal.Close()
        Gerente_Principal.Close()
        TUsuario.Focus()
        datos.Clear()
    End Sub



    Private Sub Blogin_Click(sender As Object, e As EventArgs) Handles BLogin.Click
        Dim perfil As Integer
        If ((TUsuario.Text = "") And (TContraseña.Text = "")) Then
            MessageBox.Show("Completa los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Show()
        ElseIf U.existeUsuario(TUsuario.Text, TContraseña.Text) Then
            perfil = U.extraerPerfil(TUsuario.Text)
            datos = U.extraerDatos(TUsuario.Text)

            MsgBox("Usuario correcto", MsgBoxStyle.Information, "correcto")
            If (perfil = 4) Then

                Me.Hide()
                cargarMisDatos()
                CajeroPrincipal.Show()
                Realizar_Venta.LCajero.Text = "Cajero: " + (datos.Rows(0)("apellido").ToString)
            ElseIf (perfil = 1) Then

                Me.Hide()
                cargarMisDatos()

                GerenteGral_Principal.Show()
            ElseIf (perfil = 2) Then

                Me.Hide()
                cargarMisDatos()
                cargarIdVentas()
                Gerente_Principal.Show()
            ElseIf (perfil = 3) Then

                Me.Hide()
                cargarMisDatos()

                Cajero_Principal.Show()

            End If


        Else

            MsgBox("Usuario incorrecto", MsgBoxStyle.Critical, "Error")
        End If
        TUsuario.Clear()
        TContraseña.Clear()
    End Sub


    Public Sub cargarMisDatos()
        Realizar_Venta.idUsuario = datos.Rows(0)("id_usuario")
        Misdatos.TNomYApe.Text = (datos.Rows(0)("apellido").ToString) + " " + (datos.Rows(0)("nombre").ToString)
        Misdatos.TDni.Text = datos.Rows(0)("dni").ToString
        Misdatos.TCorreo.Text = (datos.Rows(0)("correo").ToString)
        Misdatos.TDireccion.Text = (datos.Rows(0)("direccion").ToString)
        Misdatos.TTelefono.Text = (datos.Rows(0)("telefono").ToString)
        Misdatos.TUsuario.Text = (datos.Rows(0)("nombre_usuario").ToString)
        Misdatos.TTipoUsuario.Text = (datos.Rows(0)("descripcion").ToString)
        Misdatos.DTFechaNac.Text = (datos.Rows(0)("fecha_nacimiento").ToString)

    End Sub


    Public Sub cargarIdVentas()
        Mis_ventas.id = datos.Rows(0)("id_usuario")
    End Sub




End Class