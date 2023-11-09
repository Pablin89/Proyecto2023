Imports System.Data.SqlClient

Public Class DEstados
    Inherits Conexion
    Private comando As SqlCommand
    Private dr As SqlDataReader

    Public Function verEstadoProductos() As DataTable
        Try
            conectar()
            Dim comando = New SqlCommand("select id_estado_producto, descripcion from Estados_productos")
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

    Public Function verEstadoEmpleados() As DataTable
        Try
            conectar()
            Dim comando = New SqlCommand("select id_estado_empleado, descripcion from Estados_empleados")
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
