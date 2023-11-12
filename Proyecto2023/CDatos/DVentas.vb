Imports System.Data.SqlClient
Imports System.Net

Public Class DVentas
    Inherits Conexion
    Private id_venta As Integer
    Private id_cliente As Integer
    Private id_usuario As Integer
    Private total As Double
    Private fecha_compra As Date
    Private id_estado_venta As Integer
    Private id_tipo_pago
    Private comando As SqlCommand
    Private dr As SqlDataReader

    Public Sub New(id_cte As Integer, tot As Double, fech As Date, id_tipo As Integer)
        id_cliente = id_cte
        id_usuario = 1
        total = tot
        fecha_compra = fech
        id_estado_venta = 1
        id_tipo_pago = id_tipo

    End Sub

    Public Sub New(id_cte As Integer, id_us As Integer, tot As Double, fech As Date, id_tipo As Integer)
        id_cliente = id_cte
        id_usuario = id_us
        total = tot
        fecha_compra = fech
        id_estado_venta = 1
        id_tipo_pago = id_tipo

    End Sub

    Public Sub New()

    End Sub

    Property CIdVenta As String
        Get
            Return id_venta
        End Get
        Set(value As String)
            id_venta = value
        End Set
    End Property
    Property CIdCliente As String
        Get
            Return id_cliente
        End Get
        Set(value As String)
            id_cliente = value
        End Set
    End Property
    Property CIdUsuario As String
        Get
            Return id_usuario
        End Get
        Set(value As String)
            id_usuario = value
        End Set
    End Property

    Property CTotatl As String
        Get
            Return total
        End Get
        Set(value As String)
            total = value
        End Set
    End Property
    Property CFechaCompra As String
        Get
            Return fecha_compra
        End Get
        Set(value As String)
            fecha_compra = value
        End Set
    End Property
    Property CIdEstadoVenta As String
        Get
            Return id_estado_venta
        End Get
        Set(value As String)
            id_estado_venta = value
        End Set
    End Property
    Property CIdTipoPago As String
        Get
            Return id_tipo_pago
        End Get
        Set(value As String)
            id_tipo_pago = value
        End Set
    End Property
    'METODOS PARA CAJERO -----------------------------------------------------------------------------------------
    'AGREGAR UNA VENTA
    Public Function insertarVenta(dventa As DVentas) As Boolean
        Try
            conectar()

            Dim query As String = "Insert into ventas (id_cliente,id_usuario,total,fecha_compra,id_estado_venta,id_tipo_pago) values (" & dventa.CIdCliente & "," & dventa.CIdUsuario & "," & dventa.CTotatl & ",'" & dventa.CFechaCompra & "'," & dventa.CIdEstadoVenta & "," & dventa.id_tipo_pago & ")"

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

    Public Function ultimoId() As DataTable
        Try
            conectar()
            Dim comando = New SqlCommand("select max(id_venta) from ventas")
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

    'Listar las ventas del cajero
    Public Function verMisVentas(id) As DataTable
        Try
            conectar()
            Dim comando = New SqlCommand("select 
	                                        ventas.id_venta As 'ID',
	                                        fecha_compra As 'Fecha de Compra',
	                                        '$'+STR(total) As 'Total',
	                                        tipos_pagos.descripcion As 'Tipo de Pago',
	                                        clientes.nombre + ' ' + Clientes.apellido + ': ' +Convert(varchar(50),clientes.dni) As 'Cliente'
                                        from ventas 
                                        inner join Clientes on (ventas.id_cliente=clientes.id_cliente)
                                        inner join tipos_pagos on (ventas.id_tipo_pago=tipos_pagos.id_tipo_pago)
                                        where  ventas.id_usuario =" & id & "")
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

    'Listar ventas por DNI del cliente
    Public Function ventasPorDni(dni As Integer) As DataTable
        Try
            conectar()
            Dim comando = New SqlCommand("select 
	                                        ventas.id_venta As 'ID',
	                                        fecha_compra As 'Fecha de Compra',
	                                        '$'+STR(total) As 'Total',
	                                        tipos_pagos.descripcion As 'Tipo de Pago',
	                                        clientes.nombre + ' ' + Clientes.apellido + ': ' +Convert(varchar(50),clientes.dni) As 'Cliente'
                                        from ventas 
                                        inner join Clientes on (ventas.id_cliente=clientes.id_cliente)
                                        inner join tipos_pagos on (ventas.id_tipo_pago=tipos_pagos.id_tipo_pago)
                                        where  Clientes.dni like '%" & dni & "%'")
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

    Public Function ventasPorTipoDePago(id_tipo_pago As Integer) As DataTable
        Try
            conectar()
            Dim comando = New SqlCommand("select 
	                                        ventas.id_venta As 'ID',
	                                        fecha_compra As 'Fecha de Compra',
	                                        '$'+STR(total) As 'Total',
	                                        tipos_pagos.descripcion As 'Tipo de Pago',
	                                        clientes.nombre + ' ' + Clientes.apellido + ': ' +Convert(varchar(50),clientes.dni) As 'Cliente'
                                        from ventas 
                                        inner join Clientes on (ventas.id_cliente=clientes.id_cliente)
                                        inner join tipos_pagos on (ventas.id_tipo_pago=tipos_pagos.id_tipo_pago)
                                        where  tipos_pagos.id_tipo_pago = " & id_tipo_pago & "")
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

    'Listar ventas por rango de fecha
    Public Function ventasPorFecha(desde As Date, hasta As Date) As DataTable
        Try
            conectar()
            Dim comando = New SqlCommand("select 
	                                        ventas.id_venta As 'ID',
	                                        fecha_compra As 'Fecha de Compra',
	                                        '$'+STR(total) As 'Total',
	                                        tipos_pagos.descripcion As 'Tipo de Pago',
	                                        clientes.nombre + ' ' + Clientes.apellido + ': ' +Convert(varchar(50),clientes.dni) As 'Cliente'
                                        from ventas 
                                        inner join Clientes on (ventas.id_cliente=clientes.id_cliente)
                                        inner join tipos_pagos on (ventas.id_tipo_pago=tipos_pagos.id_tipo_pago)
                                        where fecha_compra between '" & desde & "' and '" & hasta & "'")
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

    'Seleccionar una venta para el encabezado del detalle
    Public Function seleccionarVenta(id As Integer) As DataTable
        Try
            conectar()
            Dim comando = New SqlCommand("select 
	                                        ventas.id_venta,
	                                        fecha_compra,
	                                        total,
	                                        tipos_pagos.descripcion,
	                                        clientes.nombre,
                                            clientes.apellido,
                                            clientes.dni
                                        from ventas 
                                        inner join Clientes on (ventas.id_cliente=clientes.id_cliente)
                                        inner join tipos_pagos on (ventas.id_tipo_pago=tipos_pagos.id_tipo_pago)
                                        where  ventas.id_venta=" & id & "")
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

    'METODOS DE VENTAS PARA ENCARGADO --------------------------------------------------------------------------------------------------------
    'Listar las ventas de los empleados
    Public Function listarTodasLasVentas() As DataTable
        Try
            conectar()
            Dim comando = New SqlCommand("select 
	                                        ventas.id_venta As 'ID',
	                                        Empleados.apellido + ': ' +Convert(varchar(50),Empleados.dni) As 'Empleado',
	                                        fecha_compra As 'Fecha de Compra',
	                                        clientes.apellido + ': ' +Convert(varchar(50),clientes.dni) As 'Cliente',
	                                        tipos_pagos.descripcion As 'Tipo de Pago',
	                                        Estados_ventas.descripcion As 'Estado'
                                        from ventas
                                        inner join Estados_ventas on (ventas.id_estado_venta=Estados_ventas.id_estado_venta)
                                        inner join Clientes on (ventas.id_cliente=clientes.id_cliente)
                                        inner join tipos_pagos on (ventas.id_tipo_pago=tipos_pagos.id_tipo_pago)
                                        inner join Usuarios on (ventas.id_usuario = Usuarios.Id_usuario)
                                        inner join Empleados on (Usuarios.id_empleado = Empleados.id_empleado)
                                        ")
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

    'Ventas por cliente especifico dni
    Public Function buscarPorCliente(dni As Integer) As DataTable
        Try
            conectar()
            Dim comando = New SqlCommand("select 
	                                        ventas.id_venta As 'ID',
	                                        Empleados.apellido + ': ' +Convert(varchar(50),Empleados.dni) As 'Empleado',
	                                        fecha_compra As 'Fecha de Compra',
	                                        clientes.apellido + ': ' +Convert(varchar(50),clientes.dni) As 'Cliente',
	                                        tipos_pagos.descripcion As 'Tipo de Pago',
	                                        Estados_ventas.descripcion As 'Estado'
                                        from ventas
                                        inner join Estados_ventas on (ventas.id_estado_venta=Estados_ventas.id_estado_venta)
                                        inner join Clientes on (ventas.id_cliente=clientes.id_cliente)
                                        inner join tipos_pagos on (ventas.id_tipo_pago=tipos_pagos.id_tipo_pago)
                                        inner join Usuarios on (ventas.id_usuario = Usuarios.Id_usuario)
                                        inner join Empleados on (Usuarios.id_empleado = Empleados.id_empleado)
                                        where clientes.dni like '" & dni & "%'")
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
    'Ventas por empleado especifico dni
    Public Function buscarPorEmpleado(dni As Integer) As DataTable
        Try
            conectar()
            Dim comando = New SqlCommand("select 
	                                        ventas.id_venta As 'ID',
	                                        Empleados.apellido + ': ' +Convert(varchar(50),Empleados.dni) As 'Empleado',
	                                        fecha_compra As 'Fecha de Compra',
	                                        clientes.apellido + ': ' +Convert(varchar(50),clientes.dni) As 'Cliente',
	                                        tipos_pagos.descripcion As 'Tipo de Pago',
	                                        Estados_ventas.descripcion As 'Estado'
                                        from ventas
                                        inner join Estados_ventas on (ventas.id_estado_venta=Estados_ventas.id_estado_venta)
                                        inner join Clientes on (ventas.id_cliente=clientes.id_cliente)
                                        inner join tipos_pagos on (ventas.id_tipo_pago=tipos_pagos.id_tipo_pago)
                                        inner join Usuarios on (ventas.id_usuario = Usuarios.Id_usuario)
                                        inner join Empleados on (Usuarios.id_empleado = Empleados.id_empleado)
                                        where Empleados.dni like '" & dni & "%'")
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

    'Ventas por tipo de pago
    Public Function buscarPorTipoPago(id_pago As Integer) As DataTable
        Try
            conectar()
            Dim comando = New SqlCommand("select 
	                                        ventas.id_venta As 'ID',
	                                        Empleados.apellido + ': ' +Convert(varchar(50),Empleados.dni) As 'Empleado',
	                                        fecha_compra As 'Fecha de Compra',
	                                        clientes.apellido + ': ' +Convert(varchar(50),clientes.dni) As 'Cliente',
	                                        tipos_pagos.descripcion As 'Tipo de Pago',
	                                        Estados_ventas.descripcion As 'Estado'
                                        from ventas
                                        inner join Estados_ventas on (ventas.id_estado_venta=Estados_ventas.id_estado_venta)
                                        inner join Clientes on (ventas.id_cliente=clientes.id_cliente)
                                        inner join tipos_pagos on (ventas.id_tipo_pago=tipos_pagos.id_tipo_pago)
                                        inner join Usuarios on (ventas.id_usuario = Usuarios.Id_usuario)
                                        inner join Empleados on (Usuarios.id_empleado = Empleados.id_empleado)
                                        where tipos_pagos.id_tipo_pago = " & id_pago & "")
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

    'Ventas por fecha
    Public Function buscarPorFecha(desde As Date, hasta As Date) As DataTable
        Try
            conectar()
            Dim comando = New SqlCommand("select 
	                                        ventas.id_venta As 'ID',
	                                        Empleados.apellido + ': ' +Convert(varchar(50),Empleados.dni) As 'Empleado',
	                                        fecha_compra As 'Fecha de Compra',
	                                        clientes.apellido + ': ' +Convert(varchar(50),clientes.dni) As 'Cliente',
	                                        tipos_pagos.descripcion As 'Tipo de Pago',
	                                        Estados_ventas.descripcion As 'Estado'
                                        from ventas
                                        inner join Estados_ventas on (ventas.id_estado_venta=Estados_ventas.id_estado_venta)
                                        inner join Clientes on (ventas.id_cliente=clientes.id_cliente)
                                        inner join tipos_pagos on (ventas.id_tipo_pago=tipos_pagos.id_tipo_pago)
                                        inner join Usuarios on (ventas.id_usuario = Usuarios.Id_usuario)
                                        inner join Empleados on (Usuarios.id_empleado = Empleados.id_empleado)
                                        where fecha_compra between '" & desde & "' and '" & hasta & "'
                                        order by fecha_compra desc")
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

    'Dar de baja una venta
    Public Function desactivarVenta(id As Integer) As Boolean
        Try
            conectar()

            Dim query As String = "update ventas set id_estado_venta = 0 where id_venta = " & id & ""

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

    'Dar de alta una venta
    Public Function activarVenta(id As Integer) As Boolean
        Try
            conectar()

            Dim query As String = "update ventas set id_estado_venta = 1 where id_venta = " & id & ""

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
End Class
