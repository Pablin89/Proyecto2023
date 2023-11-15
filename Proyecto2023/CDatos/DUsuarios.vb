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


    Public Function agregarUsuario(nombre As String, contra As String, perfil As Integer, empleado As Integer) As Boolean
        Try
            conectar()

            Dim query As String = "Insert into usuarios (id_usuario, nombre_usuario, contraseña, id_perfil, id_empleado) 
                                   values  (((select top 1 id_usuario from usuarios order by id_usuario desc) + 1),'" & nombre & "','" & contra & "'," & perfil & "," & empleado & ")"

            comando = New SqlCommand(query, conexion)

            If (comando.ExecuteNonQuery()) Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function



    Public Function modificarUsuario(nombre As String, contra As String, perfil As Integer, empleado As Integer) As Boolean
        Try
            conectar()

            Dim query As String = "update usuarios set nombre_usuario = '" & nombre & "', id_perfil = " & perfil & ", contraseña ='" & contra & "'
                                    from usuarios where id_empleado = " & empleado & ""

            comando = New SqlCommand(query, conexion)

            If (comando.ExecuteNonQuery()) Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


    Public Function modificarUsuarioSinContraseña(nombre As String, perfil As Integer, empleado As Integer) As Boolean
        Try
            conectar()

            Dim query As String = "update usuarios set nombre_usuario = '" & nombre & "', id_perfil = " & perfil & "
                                    from usuarios where id_empleado = " & empleado & ""

            comando = New SqlCommand(query, conexion)

            If (comando.ExecuteNonQuery()) Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


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



    'Verifica si existe el usuario antes de agregarlo
    Public Function existeElUsuario(us As String) As Boolean
        Dim resultado As Boolean = False
        Try
            conectar()

            Dim comando = New SqlCommand("select * from usuarios
                                            where nombre_usuario = '" & us & "'")

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



    Public Function seleccionarUsuarioConsultar(id As Integer) As DataTable
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
                                        us.nombre_usuario AS Usuario,
                                        pf.descripcion As Perfil
                                        from empleados em inner join usuarios us 
                                        on (em.id_empleado = us.id_empleado)
                                        inner join perfiles pf
                                        on (us.id_perfil = pf.id_perfil)
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



    'verifica si hay empleados sin usuario asignados
    Public Function hayEmpleadosSinUsuarios() As Boolean
        Dim resultado As Boolean = False
        Try
            conectar()

            Dim comando = New SqlCommand("select * from empleados where id_empleado not in (select id_empleado from usuarios)")

            comando.Connection = conexion

            dr = comando.ExecuteReader

            If (dr.Read) Then
                resultado = True
            End If
            dr.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        Return resultado
    End Function


    'Buscar usuario por Dni
    Public Function buscarUsuarioDni(dni As Integer) As DataTable
        Try
            conectar()
            Dim comando = New SqlCommand("select 
                                e.id_empleado As id,
                                e.apellido As Apellido,
                                e.nombre As Nombre,
                                u.nombre_usuario,
                                e.dni As DNI ,
                                e.correo As Mail,
                                e.telefono As Telefono,
                                p.descripcion As Perfil
                            from empleados e inner join usuarios u on e.id_empleado = u.id_empleado
                            inner join perfiles p on u.id_perfil = p.id_perfil
                            where dni like '" & dni & "%' and id_estado_empleado = 1")
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

    'Buscar usuario por apellido

    Public Function buscarUsuarioApellido(apellido As String) As DataTable
        Try
            conectar()
            Dim comando = New SqlCommand("select 
                                e.id_empleado As id,
                                e.apellido As Apellido,
                                e.nombre As Nombre,
                                u.nombre_usuario,
                                e.dni As DNI ,
                                e.correo As Mail,
                                e.telefono As Telefono,
                                p.descripcion As Perfil
                            from empleados e inner join usuarios u on e.id_empleado = u.id_empleado
                            inner join perfiles p on u.id_perfil = p.id_perfil
                            where apellido like '" & apellido & "%' and id_estado_empleado = 1")
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


    Public Function verEmpleadosConMasVentas() As DataTable
        Try
            conectar()
            Dim comando = New SqlCommand("select top 5
	             e.apellido ,
	             e.nombre,
				 u.nombre_usuario,
				 count(v.id_usuario) AS Ventas
				from empleados e INNER JOIN usuarios u on e.id_empleado = u.id_empleado
				inner join ventas v on v.id_usuario = u.Id_usuario
				group by e.apellido, e.nombre, u.nombre_usuario
				order by count(v.id_usuario)desc")
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


    Public Function verEmpleadosConMenosVentas() As DataTable
        Try
            conectar()
            Dim comando = New SqlCommand("select top 5
	             e.apellido ,
	             e.nombre,
				 u.nombre_usuario,
				 count(v.id_usuario) AS Ventas
				from empleados e INNER JOIN usuarios u on e.id_empleado = u.id_empleado
				inner join ventas v on v.id_usuario = u.Id_usuario
				group by e.apellido, e.nombre, u.nombre_usuario
				order by count(v.id_usuario)asc")
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
