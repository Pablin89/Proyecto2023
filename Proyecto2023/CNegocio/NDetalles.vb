﻿Public Class NDetalles
    Public Function insertarDetalle(id_venta As Integer, id_venta_detalle As Integer, id_producto As Integer, cantidad As Integer, precio As Double) As Boolean
        Dim ddetalle As New DDetalles(id_venta, id_venta_detalle, id_producto, cantidad, precio)
        If (ddetalle.insertarDetalle(ddetalle)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function verDetalle(id As Integer) As DataTable
        Try
            Dim dventa As New DDetalles
            Dim dt As DataTable = dventa.verDetalle(id)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
