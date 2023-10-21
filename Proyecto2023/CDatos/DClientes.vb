﻿Imports System.Data.SqlClient

Public Class DClientes
    Inherits Conexion

    Private id_cliente As Integer
    Private apellido As String
    Private nombre As String
    Private telefono As Long
    Private fecha_nacimiento As Date
    Private correo As String
    Private direccion As String
    Private id_estado_cliente As Integer
    Private dni As Long

    Private comando As SqlCommand

    Public Sub New(ape As String, nom As String, tel As Long, fech_nac As Date, corr As String, dir As String, dnip As Long)

        apellido = ape
        nombre = nom
        telefono = tel
        fecha_nacimiento = fech_nac
        correo = corr
        direccion = dir
        id_estado_cliente = 1
        dni = dnip
    End Sub
    Public Sub New()

    End Sub

    Property CApellido As String
        Get
            Return apellido
        End Get
        Set(value As String)
            apellido = value
        End Set
    End Property
    Property CNombre As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property
    Property CTelefono As String
        Get
            Return telefono
        End Get
        Set(value As String)
            telefono = value
        End Set
    End Property
    Property CNacimiento As String
        Get
            Return fecha_nacimiento
        End Get
        Set(value As String)
            fecha_nacimiento = value
        End Set
    End Property

    Property CCorreo As String
        Get
            Return correo
        End Get
        Set(value As String)
            correo = value
        End Set
    End Property
    Property CDireccion As String
        Get
            Return direccion
        End Get
        Set(value As String)
            direccion = value
        End Set
    End Property
    Property CEstado As String
        Get
            Return id_estado_cliente
        End Get
        Set(value As String)
            id_estado_cliente = value
        End Set
    End Property

    Property CDni As String
        Get
            Return dni
        End Get
        Set(value As String)
            dni = value
        End Set
    End Property

    Public Function insertarCliente(dcliente As DClientes) As Boolean
        Try
            conectar()

            Dim query As String = "Insert into clientes (nombre,apellido,fecha_nacimiento,dni,direccion,telefono,correo,id_estado_cliente) values ('" & dcliente.CNombre & "','" & dcliente.CApellido & "','" & dcliente.CNacimiento & "'," & dcliente.CDni & ",'" & dcliente.CDireccion & "'," & dcliente.CTelefono & ",'" & dcliente.CCorreo & "'," & dcliente.CEstado & ")"

            comando = New SqlCommand(query, conexion)

            If (comando.ExecuteNonQuery()) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

End Class
