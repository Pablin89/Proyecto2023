Imports System.Data.SqlClient
Imports System.Xml

Public Class NEmpleados

    Public Function verEmpleados() As DataTable
        Try
            Dim dempleado As New DEmpleados
            Dim dt As DataTable = dempleado.verEmpleados()
            Return dt

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function seleccionarEmpleadoConsultar(id As Integer) As DataTable
        Try
            Dim dempleado As New DEmpleados
            Dim dt As DataTable = dempleado.seleccionarEmpleadoConsultar(id)
            Return dt

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


End Class
