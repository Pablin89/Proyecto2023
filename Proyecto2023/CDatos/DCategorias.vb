Imports System.Data.SqlClient
Imports System.Net

Public Class DCategorias
    Inherits Conexion
    Private id_categoria As Integer
    Private descripcion As String

    Private comando As SqlCommand
    Private dr As SqlDataReader

    Public Sub New(desc As String)
        descripcion = desc
    End Sub
    Public Sub New()

    End Sub

    Property CIdCategoria As String
        Get
            Return id_categoria
        End Get
        Set(value As String)
            id_categoria = value
        End Set
    End Property
    Property CDescripcion As String
        Get
            Return descripcion
        End Get
        Set(value As String)
            descripcion = value
        End Set
    End Property

    Public Function insertarCategoria(dcateg As DCategorias) As Boolean
        Try
            conectar()

            Dim query As String = "Insert into Categorias (descripcion) values ('" & dcateg.CDescripcion & "')"

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

    Public Function verCategorias() As DataTable
        Try
            conectar()
            Dim comando = New SqlCommand("select 
                                id_categoria As ID,
                                descripcion As DESCRIPCIÓN
                          from Categorias")
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

    Public Function editarCategoria(descripcion As String, id As Integer) As Boolean
        Try
            conectar()

            Dim query As String = "update Categorias set descripcion = '" & descripcion & "' where id_categoria = " & id & ""

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

    Public Function existeCategoria(descripcion As String) As Boolean
        Dim resultado As Boolean = False
        Try
            conectar()

            Dim comando = New SqlCommand("select * from Categorias where descripcion = '" & descripcion & "'")

            comando.Connection = conexion

            dr = comando.ExecuteReader

            If (dr.Read) Then
                resultado = True
            End If
            dr.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        Return resultado
    End Function
End Class
