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

End Class
