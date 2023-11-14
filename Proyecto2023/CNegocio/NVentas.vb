Imports System.Net
Imports System.Security.Cryptography

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
    Public Function ventasPorDni(id_usuario, dni) As DataTable
        Try
            Dim dventa As New DVentas
            Dim dt As DataTable = dventa.ventasPorDni(id_usuario, dni)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    'Lista ventas según el tipo de pago
    Public Function ventasPorTipoDePago(id_usuario, id) As DataTable
        Try
            Dim dventa As New DVentas
            Dim dt As DataTable = dventa.ventasPorTipoDePago(id_usuario, id)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    'Listar ventas por rango de fecha
    Public Function ventasPorFecha(id_usuario, desde, hasta) As DataTable
        Try
            Dim dventa As New DVentas
            Dim dt As DataTable = dventa.ventasPorFecha(id_usuario, desde, hasta)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    'Seleccionar una venta para el encabezado del detalle
    Public Function seleccionarVenta(id As Integer) As DataTable
        Try
            Dim dventa As New DVentas
            Dim dt As DataTable = dventa.seleccionarVenta(id)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    'METODOS DE VENTAS PARA ENCARGADO --------------------------------------------------------------------------------------------------------
    'Listar las ventas de los empleados
    Public Function listarTodasLasVentas() As DataTable
        Try
            Dim dventa As New DVentas
            Dim dt As DataTable = dventa.listarTodasLasVentas()
            Return dt

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    'Ventas por cliente especifico dni
    Public Function buscarPorCliente(dni As Integer) As DataTable
        Try
            Dim dventa As New DVentas
            Dim dt As DataTable = dventa.buscarPorCliente(dni)
            Return dt

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    'Ventas por empleado especifico dni
    Public Function buscarPorEmpleado(dni As Integer) As DataTable
        Try
            Dim dventa As New DVentas
            Dim dt As DataTable = dventa.buscarPorEmpleado(dni)
            Return dt

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    'Ventas por tipo de pago
    Public Function buscarPorTipoPago(id_pago As Integer) As DataTable
        Try
            Dim dventa As New DVentas
            Dim dt As DataTable = dventa.buscarPorTipoPago(id_pago)
            Return dt

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    'Ventas por fecha
    Public Function buscarPorFecha(desde As Date, hasta As Date) As DataTable
        Try
            Dim dventa As New DVentas
            Dim dt As DataTable = dventa.buscarPorFecha(desde, hasta)
            Return dt

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    'Dar de baja una venta
    Public Function desactivarVenta(id As Integer) As Boolean
        Dim dventa As New DVentas
        If (dventa.desactivarVenta(id)) Then
            Return True
        Else
            Return False
        End If
    End Function

    'Dar de alta una venta
    Public Function activarVenta(id As Integer) As Boolean
        Dim dventa As New DVentas
        If (dventa.activarVenta(id)) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
