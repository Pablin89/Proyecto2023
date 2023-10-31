Imports System.Data.SqlClient

Public Class DTiposPagos
    Inherits Conexion
    Private comando As SqlCommand
    Private dr As SqlDataReader
    Public Function verTipoPagosCbx() As DataTable
        Try
            conectar()
            Dim comando = New SqlCommand("select 
                                id_tipo_pago,
                                descripcion
                          from tipos_pagos")
            comando.Connection = conexion

            If (comando.ExecuteNonQuery) Then
                Dim dt As New DataTable
                Dim adaptador As New SqlDataAdapter(comando)
                adaptador.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
