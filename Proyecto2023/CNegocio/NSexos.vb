Public Class NSexos
    Public Function verSexos() As DataTable
        Try
            Dim dsexo As New DSexos
            Dim dt As DataTable = dsexo.verSexos()
            Return dt

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
