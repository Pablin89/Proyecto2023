Public Class NVentas
    Public Function insertarVenta(id_cliente As Integer, id_usuario As Integer, total As Double, fecha_compra As Date, id_tipo_pago As Integer) As Boolean
        Dim dventa As New DVentas(id_cliente, id_usuario, total, fecha_compra, id_tipo_pago)
        If (dventa.insertarVenta(dventa)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function ultimoId() As DataTable
        Try
            Dim dventa As New DVentas
            Dim dt As DataTable = dventa.ultimoId()
            Return dt

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    'Lista las ventas del Cajero
    Public Function verMisVentas(id) As DataTable
        Try
            Dim dventa As New DVentas
            Dim dt As DataTable = dventa.verMisVentas(id)
            Return dt

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    'Lista ventas por DNI de cliente
    Public Function ventasPorDni(dni) As DataTable
        Try
            Dim dventa As New DVentas
            Dim dt As DataTable = dventa.ventasPorDni(dni)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    'Lista ventas según el tipo de pago
    Public Function ventasPorTipoDePago(id) As DataTable
        Try
            Dim dventa As New DVentas
            Dim dt As DataTable = dventa.ventasPorTipoDePago(id)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    'Listar ventas por rango de fecha
    Public Function ventasPorFecha(desde, hasta) As DataTable
        Try
            Dim dventa As New DVentas
            Dim dt As DataTable = dventa.ventasPorFecha(desde, hasta)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

End Class
