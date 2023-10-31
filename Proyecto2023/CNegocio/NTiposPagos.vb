Public Class NTiposPagos
    Public Function verTipoPagosCbx() As DataTable
        Try
            Dim dtipos As New DTiposPagos
            Dim dt As DataTable = dtipos.verTipoPagosCbx()
            Return dt

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
