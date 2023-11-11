Imports System.Data.SqlClient
Imports System.Text
Public Class ReporteFactura
    Public Shared conexion As New SqlConnection
    Private comando As SqlCommand
    Private dr As SqlDataReader


    Public Shared adaptador As New SqlDataAdapter
    Public Shared adaptador2 As New SqlDataAdapter

    Public Shared ds1 As DataSet
    Public Shared ds2 As DataSet
    Public Sub reporteFactura(ByVal id_venta As Integer)
        Try
            conexion = New SqlConnection
            conexion.ConnectionString = "server = .\SQLEXPRESS; database = Proyecto2023; integrated security = true"
            conexion.Open()

            adaptador = New SqlDataAdapter("SELECT detalle.id_venta_detalle, detalle.cantidad, detalle.precio, 
                                                   clientes.nombre, clientes.apellido, clientes.dni, clientes.telefono, 
                                                   Productos.nombre, Productos.codigo, Productos.precio, ventas.id_venta, ventas.fecha_compra, ventas.total 
                                                FROM detalle 
                                                INNER JOIN ventas   ON  ventas.id_venta = detalle.id_venta
                                                INNER JOIN clientes  ON ventas.id_cliente = clientes.id_cliente 
                                                INNER JOIN Productos ON  detalle.id_producto = Productos.id_producto 
												WHERE ventas.id_venta =" & id_venta, conexion)
            ds1 = New DataSet
            adaptador.Fill(ds1)

            adaptador2 = New SqlDataAdapter("select 
	                                            ventas.id_venta,
	                                            ventas.id_cliente,
	                                            Ventas.id_usuario,
	                                            ventas.total,
	                                            ventas.fecha_compra,
	                                            tipos_pagos.descripcion,
	                                            clientes.nombre,
	                                            clientes.apellido,
	                                            clientes.telefono,
	                                            clientes.direccion,
	                                            clientes.dni
                                            from ventas 
                                            inner join Clientes on (ventas.id_cliente=clientes.id_cliente)
                                            inner join tipos_pagos on (ventas.id_tipo_pago=tipos_pagos.id_tipo_pago)
												WHERE ventas.id_venta =" & id_venta, conexion)
            ds2 = New DataSet
            adaptador2.Fill(ds2)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
