Imports System.Data.SqlClient

Public Class DProductos
    Inherits Conexion
    Private id_producto As Integer
    Private descripcion As String
    Private nombre As String
    Private codigo As Integer
    Private stock As Integer
    Private stock_minimo As Integer
    Private precio As Double
    Private id_estado_producto As Integer
    Private id_categoria As Integer
    Private comando As SqlCommand
    Private dr As SqlDataReader
    Public Sub New()

    End Sub

    Public Sub New(desc As String, nom As String, cod As Integer, stk As Integer, stk_min As Integer, prec As Double, id_est As Integer, id_cat As Integer)
        descripcion = desc
        nombre = nom
        codigo = cod
        stock = stk
        stock_minimo = stk_min
        precio = prec
        id_estado_producto = id_est
        id_categoria = id_cat
    End Sub

    Property CIdProducto As String
        Get
            Return id_producto
        End Get
        Set(value As String)
            id_producto = value
        End Set
    End Property

    Property CDescripcion As String
        Get
            Return descripcion
        End Get
        Set(value As String)
            descripcion = value
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

    Property CCodigo As String
        Get
            Return codigo
        End Get
        Set(value As String)
            codigo = value
        End Set
    End Property

    Property CStock As String
        Get
            Return stock
        End Get
        Set(value As String)
            stock = value
        End Set
    End Property

    Property CStockMinimo As String
        Get
            Return stock_minimo
        End Get
        Set(value As String)
            stock_minimo = value
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

    Property CIdEstadoProducto As String
        Get
            Return id_estado_producto
        End Get
        Set(value As String)
            id_estado_producto = value
        End Set
    End Property

    Property CIdCategoria As String
        Get
            Return id_categoria
        End Get
        Set(value As String)
            id_categoria = value
        End Set
    End Property

    Public Function insertarProducto(dproducto As DProductos) As Boolean
        Try
            conectar()

            Dim query As String = "Insert into productos (descripcion,nombre,codigo,stock,sock_minimo,precio,id_estado_producto,id_categoria) values ('" & dproducto.descripcion & "','" & dproducto.CNombre & "','" & dproducto.CCodigo & "'," & dproducto.CStock & ",'" & dproducto.CStockMinimo & "'," & dproducto.CPrecio & ",'" & dproducto.CIdEstadoProducto & "'," & dproducto.CIdCategoria & ")"

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

    Public Function existeNombreProducto(nombre As String) As Boolean
        Dim resultado As Boolean = False
        Try
            conectar()

            Dim comando = New SqlCommand("select * from productos where nombre = '" & nombre & "'")

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

    Public Function existeCodigoProducto(codigo As Integer) As Boolean
        Dim resultado As Boolean = False
        Try
            conectar()

            Dim comando = New SqlCommand("select * from productos where codigo = " & codigo & "")

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

    Public Function verProductosEditar() As DataTable
        Try
            conectar()
            Dim comando = New SqlCommand("select 
	                                            Productos.id_producto As ID,
	                                            Productos.codigo As CÓDIGO,
	                                            Productos.nombre As NOMBRE,
	                                            Categorias.descripcion As CATEGORIA
                                            from Productos
	                                            INNER JOIN Categorias ON(Categorias.id_categoria = Productos.id_categoria)")
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

    Public Function seleccionarProductoEditar(id As Integer) As DataTable
        Try
            conectar()
            Dim comando = New SqlCommand("select 
	                                            id_producto,
	                                            nombre,
                                                codigo,
	                                            descripcion,
	                                            id_categoria,
	                                            stock,
	                                            sock_minimo,
	                                            precio,
	                                            id_estado_producto
                                            from Productos where id_producto =" & id & "")
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
