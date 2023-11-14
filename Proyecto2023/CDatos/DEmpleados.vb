Imports System.Data.SqlClient

Public Class DEmpleados
    Inherits Conexion
    Private id_empleado As Integer
    Private dni As Integer
    Private apellido As String
    Private nombre As String
    Private direccion As String
    Private telefono As String
    Private correo As String
    Private fecha_nacimiento As Date
    Private id_sexo As Integer
    Private id_estado_empleado As Integer


    Private comando As SqlCommand
    Private dr As SqlDataReader

    Public Sub New(dnie As Integer,
                   apellidoe As String,
                   nombree As String,
                   direccione As String,
                   telefonoe As String,
                   correoe As String,
                   fecha_nacimientoe As Date,
                   id_sexoe As Integer)
        dni = dnie
        apellido = apellidoe
        nombre = nombree
        direccion = direccione
        telefono = telefonoe
        correo = correoe
        fecha_nacimiento = fecha_nacimientoe
        id_sexo = id_sexoe
        id_estado_empleado = 1

    End Sub

    Public Sub New()

    End Sub

    Property CIdEmpleado As String
        Get
            Return id_empleado
        End Get
        Set(value As String)
            id_empleado = value
        End Set
    End Property

    Property CDni As String
        Get
            Return dni
        End Get
        Set(value As String)
            dni = value
        End Set
    End Property

    Property CApellido As String
        Get
            Return apellido
        End Get
        Set(value As String)
            apellido = value
        End Set
    End Property
    Property CNombre As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property
    Property CTelefono As String
        Get
            Return telefono
        End Get
        Set(value As String)
            telefono = value
        End Set
    End Property
    Property CNacimiento As String
        Get
            Return fecha_nacimiento
        End Get
        Set(value As String)
            fecha_nacimiento = value
        End Set
    End Property

    Property CCorreo As String
        Get
            Return correo
        End Get
        Set(value As String)
            correo = value
        End Set
    End Property
    Property CDireccion As String
        Get
            Return direccion
        End Get
        Set(value As String)
            direccion = value
        End Set
    End Property

    Property CIdEstadoEmpleado As String
        Get
            Return id_estado_empleado
        End Get
        Set(value As String)
            id_estado_empleado = value
        End Set
    End Property

    Property CIdSexo As String
        Get
            Return id_sexo
        End Get
        Set(value As String)
            id_sexo = value
        End Set
    End Property



    'METODOS DE GESTION DE EMPLEADOS PARA ENCARGADO -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    Public Function insertarEmpleado(dempleado As DEmpleados) As Boolean
        Try
            conectar()

            Dim query As String = "Insert into Empleados (dni,apellido,nombre,direccion,telefono,correo,fecha_nacimiento,id_sexo,id_estado_empleado,fecha_ingreso) 
                                   values 
                                  (" & dempleado.CDni & ",'" & dempleado.CApellido & "','" & dempleado.CNombre & "','" & dempleado.CDireccion & "','" & dempleado.CTelefono & "','" & dempleado.CCorreo & "','" & dempleado.CNacimiento & "'," & dempleado.CIdSexo & "," & dempleado.CIdEstadoEmpleado & ", getDate())"

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

    Public Function editarEmpleado(dni As Integer,
                                       apellido As String,
                                       nombre As String,
                                       direccion As String,
                                       telefono As String,
                                       correo As String,
                                       fecha_nacimiento As Date,
                                       id_empleado As Integer) As Boolean
        Try
            conectar()

            Dim query As String = "update Empleados set nombre = '" & nombre & "',apellido = '" & apellido & "',fecha_nacimiento = '" & fecha_nacimiento & "',dni = " & dni & ",direccion = '" & direccion & "',telefono = '" & telefono & "',correo = '" & correo & "' where id_empleado = " & id_empleado & ""

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


    'Ver empleados sin usuario asignado
    Public Function verEmpleadosSinUsuario() As DataTable
        Try
            conectar()
            Dim comando = New SqlCommand("select * from empleados where id_empleado not in (select id_empleado from usuarios)")
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


    'Ver empleados con usuario asignado
    Public Function verEmpleadosConUsuario() As DataTable
        Try
            conectar()
            Dim comando = New SqlCommand("select * from empleados where id_empleado in (select id_empleado from usuarios)")
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

    'verifica si ya existe el empleado con el mismo dni
    Public Function existeEmpleado(dni As Integer) As Boolean
        Dim resultado As Boolean = False
        Try
            conectar()

            Dim comando = New SqlCommand("select * from Empleados where dni = " & dni & "")

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

    'Buscar empleado por Dni
    Public Function buscarEmpleadoDni(dni As Integer) As DataTable
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
                          from empleados where dni like '" & dni & "%' and id_estado_empleado = 1")
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

    'Buscar empleado por apellido

    Public Function buscarEmpleadoApellido(apellido As String) As DataTable
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
                          from empleados where apellido like '" & apellido & "%' and id_estado_empleado = 1")
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






    'Buscar empleado sin usuario por Dni
    Public Function buscarEmpleadoNDni(dni As Integer) As DataTable
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
                          from empleados where dni like '" & dni & "%' and id_estado_empleado = 1 and id_Empleado not in(select id_empleado from usuarios)")
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

    'Buscar empleado sin usuario por apellido

    Public Function buscarEmpleadoNApellido(apellido As String) As DataTable
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
                          from empleados where apellido like '" & apellido & "%' and id_estado_empleado = 1 and id_Empleado not in(select id_empleado from usuarios)")
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
