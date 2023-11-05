Imports System.Data.SqlClient

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

End Class
