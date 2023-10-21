﻿Imports System.Data.SqlClient

Public Class NClientes

    Public Function insertarCliente(nombre As String, apellido As String, telefono As Long, fecha_nacimiento As Date, correo As String, direccion As String, dni As Long) As Boolean
        Dim dcliente As New DClientes(nombre, apellido, telefono, fecha_nacimiento, correo, direccion, dni)
        If (dcliente.insertarCliente(dcliente)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function verClientes() As DataTable
        Try
            Dim dcliente As New DClientes
            Dim dt As DataTable = dcliente.verClientes()
            Return dt

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

End Class
