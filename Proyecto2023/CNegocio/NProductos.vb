Public Class NProductos
    Public Function insertarProducto(descripcion As String, nombre As String, codigo As Integer, stock As Integer, stock_minimo As Integer, precio As Double, id_estado_producto As Integer, id_categoria As Integer) As Boolean
        Dim dproducto As New DProductos(descripcion, nombre, codigo, stock, stock_minimo, precio, id_estado_producto, id_categoria)
        If (dproducto.insertarProducto(dproducto)) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
