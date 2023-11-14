Imports System.Data.SqlClient

Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks







Public Class NUsuarios


    Public Function existeUsuario(us As String, con As String) As Boolean
        Dim dusuario As New DUsuarios()
        If (dusuario.existeUsuario(us, Convert.ToBase64String(Encoding.Unicode.GetBytes(con)))) Then
            Return True
        Else
            Return False
        End If
    End Function

    'return Encoding.Unicode.GetString(Convert.FromBase64String.(cadena))


    Public Function extraerPerfil(usuario As String) As Integer
        Dim dusuario As New DUsuarios
        Dim resultado As Integer = dusuario.extraerPerfil(usuario)
        Return resultado

    End Function


    Public Function existeElUsuario(us As String) As Boolean
        Dim dusuario As New DUsuarios()
        If (dusuario.existeElUsuario(us)) Then
            Return True
        Else
            Return False
        End If
    End Function



    Public Function agregarUsuario(nombre As String, contra As String, perfil As Integer, empleado As Integer) As Boolean

        Dim dusuarios As New DUsuarios
        If (dusuarios.agregarUsuario(nombre, Convert.ToBase64String(Encoding.Unicode.GetBytes(contra)), perfil, empleado)) Then
            Return True
        Else
            Return False
        End If
    End Function




    Public Function extraerDatos(usuario As String) As DataTable
        Try
            Dim dusuario As New DUsuarios()
            Dim dt As DataTable = dusuario.buscarDatosUsuario(usuario)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function seleccionarUsuarioConsultar(id As Integer) As DataTable
        Try
            Dim dusuario As New DUsuarios
            Dim dt As DataTable = dusuario.seleccionarUsuarioConsultar(id)
            Return dt

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function



    'Verifica si hay empleados sin usuarios
    Public Function hayEmpleadosSinUsuarios() As Boolean
        Dim dusuario As New DUsuarios()
        If (dusuario.hayEmpleadosSinUsuarios()) Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
