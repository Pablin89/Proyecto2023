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

Partial Public Class Productos
    Public Property id_producto As Integer
    Public Property descripcion As String
    Public Property nombre As String
    Public Property codigo As Nullable(Of Integer)
    Public Property stock As Nullable(Of Integer)
    Public Property sock_minimo As Nullable(Of Integer)
    Public Property precio As Nullable(Of Decimal)
    Public Property id_estado_producto As Nullable(Of Integer)
    Public Property id_categoria As Nullable(Of Integer)

    Public Overridable Property Categorias As Categorias
    Public Overridable Property detalle As ICollection(Of DetalleVenta) = New HashSet(Of DetalleVenta)
    Public Overridable Property Estados_productos As Estados_productos

End Class
