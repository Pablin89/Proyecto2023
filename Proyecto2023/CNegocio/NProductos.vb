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
End Class
