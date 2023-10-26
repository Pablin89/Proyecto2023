Public Class NCategorias
    Public Function insertarCategoria(descripcion As String) As Boolean
        Dim dcateg As New DCategorias(descripcion)
        If (dcateg.insertarCategoria(dcateg)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function verCategorias() As DataTable
        Try
            Dim dcateg As New DCategorias
            Dim dt As DataTable = dcateg.verCategorias()
            Return dt

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function verCategoriasCbx() As DataTable
        Try
            Dim dcateg As New DCategorias
            Dim dt As DataTable = dcateg.verCategoriasCbx()
            Return dt

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function existeCategoria(descripcion As String) As Boolean
        Dim dcateg As New DCategorias()
        If (dcateg.existeCategoria(descripcion)) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
