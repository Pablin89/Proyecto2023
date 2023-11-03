Imports System.Data.SqlClient

Public Class DUsuarios
    Inherits Conexion

    Private id_usuario As Integer
    Private nombre_usuario As String
    Private contraseña As String
    Private id_empleado As Integer
    Private id_perfil As Integer

    Private comando As SqlCommand
    Private dr As SqlDataReader



    Property CIdUsuario As String
        Get
            Return id_usuario
        End Get
        Set(value As String)
            id_usuario = value
        End Set
    End Property
    Property CNombreUsuario As String
        Get
            Return nombre_usuario
        End Get
        Set(value As String)
            nombre_usuario = value
        End Set
    End Property
    Property CContraseña As String
        Get
            Return contraseña
        End Get
        Set(value As String)
            contraseña = value
        End Set
    End Property

    Property CIdEmpleado As String
        Get
            Return id_empleado
        End Get
        Set(value As String)
            id_empleado = value
        End Set
    End Property

    Property CIdPerfil As String
        Get
            Return id_perfil
        End Get
        Set(value As String)
            id_perfil = value
        End Set
    End Property



    Public Function existeUsuario(us As String, con As String) As Boolean
        Dim resultado As Boolean = False
        Try
            conectar()

            Dim comando = New SqlCommand("select * from usuarios u inner join empleados e on
                                            u.id_empleado = e.id_empleado
                                            where nombre_usuario = '" & us & "' and u.
                                        contraseña = '" & con & "' and e.id_estado_empleado = 1")

            comando.Connection = conexion

            dr = comando.ExecuteReader

            If (dr.HasRows) Then
                resultado = True
            End If
            dr.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        Return resultado
    End Function

    Public Function extraerPerfil(us As String) As Integer
        Dim resultado As Integer = 0

        Try
            conectar()
            Dim comando = New SqlCommand("select id_perfil from usuarios where nombre_usuario = '" & us & "'")
            'e.apellido As Apellido,
            'e.nombre As Nombre,
            'e.telefono As Telefono,
            'p.descripcion As Perfil,
            'correo As Mail,
            'direccion As Dirección,
            'dni As DNI,
            'from usuarios u inner join empleados e on u.id_empelado = e.id_empleado
            'inner join perfiles p on u.id_perfil = p.id_perfil


            comando.Connection = conexion
            dr = comando.ExecuteReader

            If (dr.Read) Then
                resultado = dr.Item("id_perfil")

            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Return resultado
    End Function

    Public Function buscarDatosUsuario(us As String) As DataTable
        Try
            conectar()
            Dim comando = New SqlCommand("select 
	                                            u.id_usuario,
	                                            u.nombre_usuario,
	                                            p.descripcion,
	                                            e.apellido,
                                                e.nombre ,
                                                e.dni ,
                                                e.telefono,
                                                e.correo ,
                                                e.direccion ,
                                                e.fecha_nacimiento 
                                            from usuarios u
	                                            INNER JOIN Empleados e ON u.id_empleado = e.id_empleado
                                                INNER JOIN Perfiles p ON u.id_perfil = p.id_perfil
                                            where u.nombre_usuario like '%" & us & "%'")
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
