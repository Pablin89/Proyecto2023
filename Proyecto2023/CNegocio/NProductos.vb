Public Class NProductos
    Public Function insertarProducto(descripcion As String, nombre As String, codigo As Integer, stock As Integer, stock_minimo As Integer, precio As Double, id_estado_producto As Integer, id_categoria As Integer) As Boolean
        Dim dproducto As New DProductos(descripcion, nombre, codigo, stock, stock_minimo, precio, id_estado_producto, id_categoria)
        If (dproducto.insertarProducto(dproducto)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function existeNombreProducto(nombre As String) As Boolean
        Dim dproducto As New DProductos()
        If (dproducto.existeNombreProducto(nombre)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function existeCodigoProducto(codigo As Integer) As Boolean
        Dim dproducto As New DProductos()
        If (dproducto.existeCodigoProducto(codigo)) Then
            Return True
        Else
            Return False
        End If
    End Function


    'Verifica si hay productos con poco stock
    Public Function hayPocoStock() As Boolean
        Dim dproductos As New DProductos()
        If (dproductos.hayPocoStock()) Then
            Return True
        Else
            Return False
        End If
    End Function


    'Ver productos con poco stock
    Public Function verProductosPocoStock() As DataTable
        Try
            Dim dproducto As New DProductos
            Dim dt As DataTable = dproducto.verProductosPocoStock()
            Return dt

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function



    Public Function verProductosEditar() As DataTable
        Try
            Dim dproducto As New DProductos
            Dim dt As DataTable = dproducto.verProductosEditar()
            Return dt

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function seleccionarProductoEditar(id As Integer) As DataTable
        Try
            Dim dproducto As New DProductos
            Dim dt As DataTable = dproducto.seleccionarProductoEditar(id)
            Return dt

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function editarProducto(descripcion As String, nombre As String, codigo As Integer, stock As Integer, sock_minimo As Integer, precio As Double, id_estado_producto As Integer, id_categoria As Integer, id_producto As Integer) As Boolean
        Dim dproducto As New DProductos()
        If (dproducto.editarProducto(descripcion, nombre, codigo, stock, sock_minimo, precio, id_estado_producto, id_categoria, id_producto)) Then
            Return True
        Else
            Return False
        End If
    End Function

    'Busqueda por nombre de editar
    Public Function buscarProductoNombreE(nombre As String) As DataTable

        Try
            Dim dproducto As New DProductos()
            Dim dt As DataTable = dproducto.buscarProductoNombreE(nombre)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    'busqueda por código de editar
    Public Function buscarProductoCodigoE(codigo As Integer) As DataTable
        Try
            Dim dproducto As New DProductos()
            Dim dt As DataTable = dproducto.buscarProductoCodigoE(codigo)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    'busqueda por categoria de editar
    Public Function buscarProductoCategoriaE(categoria As String) As DataTable
        Try
            Dim dproducto As New DProductos()
            Dim dt As DataTable = dproducto.buscarProductoCategoriaE(categoria)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    'METODOS DE CONSULTAR -----------------------------------------------------------------------------------------------
    'Busqueda por nombre de consultar
    Public Function buscarProductoNombreC(nombre As String) As DataTable

        Try
            Dim dproducto As New DProductos()
            Dim dt As DataTable = dproducto.buscarProductoNombreC(nombre)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    'busqueda por código de consultar
    Public Function buscarProductoCodigoC(codigo As Integer) As DataTable
        Try
            Dim dproducto As New DProductos()
            Dim dt As DataTable = dproducto.buscarProductoCodigoC(codigo)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    'busqueda por categoria de consultar
    Public Function buscarProductoCategoriaC(categoria As String) As DataTable
        Try
            Dim dproducto As New DProductos()
            Dim dt As DataTable = dproducto.buscarProductoCategoriaC(categoria)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    'Listar todos los productos en consultar
    Public Function verProductosConsultar() As DataTable
        Try
            Dim dproducto As New DProductos
            Dim dt As DataTable = dproducto.verProductosConsultar()
            Return dt

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function seleccionarProductoConsultar(id As Integer) As DataTable
        Try
            Dim dproducto As New DProductos
            Dim dt As DataTable = dproducto.seleccionarProductoConsultar(id)
            Return dt

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    'FUNCIONES DEL EMPLEADO CAJERO---------------------------------------------------------------------------------
    'VER PRODUCTOS ACTIVOS
    Public Function verProductosActivos() As DataTable
        Try
            Dim dproducto As New DProductos
            Dim dt As DataTable = dproducto.verProductosActivos()
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    'buscar por codigo
    Public Function buscarProductoCajeroCodigo(codigo As String) As DataTable
        Try
            Dim dproducto As New DProductos()
            Dim dt As DataTable = dproducto.buscarProductoCajeroCodigo(codigo)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    'buscar productos por categoria
    Public Function buscarProductoCajeroCategoria(categoria As String) As DataTable
        Try
            Dim dproducto As New DProductos()
            Dim dt As DataTable = dproducto.buscarProductoCajeroCategoria(categoria)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    'Seleccionar un producto especifico 
    Public Function seleccionarProductoCajero(id As Integer) As DataTable
        Try
            Dim dproducto As New DProductos
            Dim dt As DataTable = dproducto.seleccionarProductoCajero(id)
            Return dt

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    'Actualizar el stock al realizar la compra
    Public Function actualizarStock(id_producto As Integer, stock As Integer) As Boolean
        Dim dproducto As New DProductos()
        If (dproducto.actualizarStock(id_producto, stock)) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
