'------------------------------------------------------------------------------
' <auto-generated>
'    Este código se generó a partir de una plantilla.
'
'    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Usuarios
    Public Property Id_usuario As Integer
    Public Property nombre_usuario As String
    Public Property contraseña As String
    Public Property id_empleado As Integer
    Public Property id_perfil As Integer

    Public Overridable Property Empleados As Empleados
    Public Overridable Property Perfiles As Perfiles
    Public Overridable Property ventas As ICollection(Of ventas) = New HashSet(Of ventas)

End Class
