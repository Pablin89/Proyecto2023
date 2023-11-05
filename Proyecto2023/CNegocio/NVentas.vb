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
End Class
