﻿Public Class NEstados
    Public Function verEstadoProductos() As DataTable
        Try
            Dim dEstadoProd As New DEstados
            Dim dt As DataTable = dEstadoProd.verEstadoProductos()
            Return dt

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function verEstadoEmpleados() As DataTable
        Try
            Dim dEestadoEmpl As New DEstados
            Dim dt As DataTable = dEestadoEmpl.verEstadoEmpleados()
            Return dt

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
