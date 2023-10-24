Imports System.Data.SqlClient
Imports System.Net.Configuration

Public Class Conexion
    Protected conexion = New SqlConnection("server = .\SQLEXPRESS; database = Proyecto2023; integrated security = true")

    Public Function conectar() As Boolean
        Try
            conexion.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Sub desconectar()
        Try
            If (conexion.State = ConnectionState.Open) Then
                conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
