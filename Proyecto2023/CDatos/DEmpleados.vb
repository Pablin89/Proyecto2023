Imports System.Data.SqlClient

Public Class DEmpleados
    Inherits Conexion

    Public Function verEmpleados() As DataTable
        Try
            conectar()
            Dim comando = New SqlCommand("select 
                                id_empleado As id,
                                apellido As Apellido,
                                nombre As Nombre,
                                dni As DNI ,
                                fecha_nacimiento As Nacimiento,
                                correo As Mail,
                                direccion As Dirección,
                                telefono As Telefono
                          from empleados where id_estado_empleado = 1")
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

    Public Function seleccionarEmpleadoConsultar(id As Integer) As DataTable
        Try
            conectar()
            Dim comando = New SqlCommand("select 
                                em.id_empleado As id,
                                em.apellido As Apellido,
                                em.nombre As Nombre,
                                em.dni As DNI ,
                                em.fecha_nacimiento As Nacimiento,
                                em.correo As Mail,
                                em.direccion As Dirección,
                                em.telefono As Telefono,
                                es.descripcion AS Estado
                          from empleados em inner join estados_empleados es 
                            on (em.id_estado_empleado = es.id_estado_empleado)
                            where em.id_empleado =" & id & "")

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
