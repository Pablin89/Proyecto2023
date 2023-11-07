Imports System.Data.SqlClient

Public Class DDetalles
    Inherits Conexion
    Private id_venta As Integer
    Private id_venta_detalle As Integer
    Private id_producto As Integer
    Private cantidad As Integer
    Private precio As Double

    Private comando As SqlCommand
    Private dr As SqlDataReader

    Public Sub New()

    End Sub

    Public Sub New(id_vta As Integer, id_det As Integer, id_prod As Integer, cant As Integer, prec As Double)
        id_venta = id_vta
        id_venta_detalle = id_det
        id_producto = id_prod
        cantidad = cant
        precio = prec
    End Sub

    Property CIdVenta As String
        Get
            Return id_venta
        End Get
        Set(value As String)
            id_venta = value
        End Set
    End Property

    Property CIdVentaDetalle As String
        Get
            Return id_venta_detalle
        End Get
        Set(value As String)
            id_venta_detalle = value
        End Set
    End Property
    Property CIdProducto As String
        Get
            Return id_producto
        End Get
        Set(value As String)
            id_producto = value
        End Set
    End Property
    Property CCantidad As String
        Get
            Return cantidad
        End Get
        Set(value As String)
            cantidad = value
        End Set
    End Property
    Property CPrecio As String
        Get
            Return precio
        End Get
        Set(value As String)
            precio = value
        End Set
    End Property

    Public Function insertarDetalle(ddet As DDetalles) As Boolean
        Try
            conectar()

            Dim query As String = "Insert into detalle (id_venta,id_venta_detalle,id_producto,cantidad,precio) values (" & ddet.CIdVenta & "," & ddet.CIdVentaDetalle & "," & ddet.CIdProducto & "," & ddet.CCantidad & "," & ddet.CPrecio & ")"

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

    Public Function verDetalle(id As Integer) As DataTable
        Try
            conectar()
            Dim comando = New SqlCommand("select
	                                        Productos.nombre As 'Producto',
	                                        '$'+str(detalle.precio) As 'Precio',
	                                        detalle.cantidad As 'Cantidad',
	                                        '$'+str(detalle.cantidad*detalle.precio) As 'Subtotal'
                                        from detalle
	                                        inner join ventas on (detalle.id_venta = ventas.id_venta)
	                                        inner join Productos on (detalle.id_producto = Productos.id_producto)
                                        where detalle.id_venta =" & id & "")
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
