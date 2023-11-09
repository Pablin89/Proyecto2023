Imports System.Data.SqlClient

Public Class DSexos
    Inherits Conexion
    Private comando As SqlCommand
    Private dr As SqlDataReader

    Public Function verSexos() As DataTable
        Try
            conectar()
            Dim comando = New SqlCommand("select id_sexo, descripcion from Sexos")
            comando.Connection = conexion

            If (comando.ExecuteNonQuery) Then
                Dim dt As New DataTable
                Dim adaptador As New SqlDataAdapter(comando)
                adaptador.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
