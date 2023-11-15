Imports System.Data.SqlClient
Imports System.Xml

Public Class NClientes

    Public Function insertarCliente(nombre As String, apellido As String, telefono As Long, fecha_nacimiento As Date, correo As String, direccion As String, dni As Long) As Boolean
        Dim dcliente As New DClientes(nombre, apellido, telefono, fecha_nacimiento, correo, direccion, dni)
        If (dcliente.insertarCliente(dcliente)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function existeCliente(id As Integer) As Boolean
        Dim dcliente As New DClientes()
        If (dcliente.existeCliente(id)) Then
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

    Public Function verClientesMasCompras() As DataTable
        Try
            Dim dcliente As New DClientes
            Dim dt As DataTable = dcliente.verClientesMasCompras()
            Return dt

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function verClientesMenosCompras() As DataTable
        Try
            Dim dcliente As New DClientes
            Dim dt As DataTable = dcliente.verClientesMenosCompras()
            Return dt

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function verUltimosClientes() As DataTable
        Try
            Dim dcliente As New DClientes
            Dim dt As DataTable = dcliente.verUltimosClientes()
            Return dt

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function




    Public Function editarCliente(nombre As String, apellido As String, telefono As Long, fecha_nacimiento As Date, correo As String, direccion As String, dni As Long, id_cliente As Integer) As Boolean
        Dim dcliente As New DClientes()
        If (dcliente.editarCliente(nombre, apellido, telefono, fecha_nacimiento, correo, direccion, dni, id_cliente)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function buscarClienteDni(dni As Integer) As DataTable

        Try
            Dim dcliente As New DClientes
            Dim dt As DataTable = dcliente.buscarClienteDni(dni)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function buscarClienteApellido(apellido As String) As DataTable

        Try
            Dim dcliente As New DClientes
            Dim dt As DataTable = dcliente.buscarClienteApellido(apellido)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function buscarClienteCorreo(correo As String) As DataTable

        Try
            Dim dcliente As New DClientes
            Dim dt As DataTable = dcliente.buscarClienteCorreo(correo)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    'Funciones para Encargado
    Public Function verClientesE() As DataTable
        Try
            Dim dcliente As New DClientes
            Dim dt As DataTable = dcliente.verClientesE()
            Return dt

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function buscarClienteDniE(dni As Integer) As DataTable

        Try
            Dim dcliente As New DClientes
            Dim dt As DataTable = dcliente.buscarClienteDniE(dni)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function buscarClienteApellidoE(apellido As String) As DataTable

        Try
            Dim dcliente As New DClientes
            Dim dt As DataTable = dcliente.buscarClienteApellidoE(apellido)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function buscarClienteCorreoE(correo As String) As DataTable

        Try
            Dim dcliente As New DClientes
            Dim dt As DataTable = dcliente.buscarClienteCorreoE(correo)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function bajaCliente(id As Integer) As Boolean
        Dim dcliente As New DClientes
        If (dcliente.bajaCliente(id)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function altaCliente(id As Integer) As Boolean
        Dim dcliente As New DClientes
        If (dcliente.altaCliente(id)) Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
