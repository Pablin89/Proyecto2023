Imports System.Data.SqlClient
Imports System.Xml

Public Class NEmpleados

    'METODOS DE GESTION DE EMPLEADOS PARA ENCARGADO -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    Public Function insertarEmpleado(dni As Integer,
                                       apellido As String,
                                       nombre As String,
                                       direccion As String,
                                       telefono As String,
                                       correo As String,
                                       fecha_nacimiento As Date,
                                       id_sexo As Integer,
                                       fecha_ingreso As Date) As Boolean

        Dim dempleado As New DEmpleados(dni, apellido, nombre, direccion, telefono, correo, fecha_nacimiento, id_sexo, fecha_ingreso)
        If (dempleado.insertarEmpleado(dempleado)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function editarEmpleado(dni As Integer,
                                       apellido As String,
                                       nombre As String,
                                       direccion As String,
                                       telefono As String,
                                       correo As String,
                                       fecha_nacimiento As Date,
                                       id_empleado As Integer) As Boolean
        Dim dempleado As New DEmpleados()
        If (dempleado.editarEmpleado(dni, apellido, nombre, direccion, telefono, correo, fecha_nacimiento, id_empleado)) Then
            Return True
        Else
            Return False
        End If
    End Function

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

    'Verificar si el empleado existe
    Public Function existeEmpleado(id As Integer) As Boolean
        Dim dempleado As New DEmpleados()
        If (dempleado.existeEmpleado(id)) Then
            Return True
        Else
            Return False
        End If
    End Function


End Class
