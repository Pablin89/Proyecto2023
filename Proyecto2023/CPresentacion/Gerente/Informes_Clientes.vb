Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Informes_Clientes
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'If (ComboBox2.Text = "") Then
        '    MsgBox("Debe seleccionar un filtro", MsgBoxStyle.Critical, "Atención")
        'ElseIf (ComboBox2.Text = "Clientes con mas compras") Then
        '    MsgBox("Seleccionaste buscar por 'Clientes con mas compras'", MsgBoxStyle.Information, "Buscar")
        'ElseIf (ComboBox2.Text = "Clientes con menos compras") Then
        '    MsgBox("Seleccionaste buscar por 'Clientes con menos compras'", MsgBoxStyle.Information, "Buscar")
        'End If
        ReporteClientes.ShowDialog()
        MsgBox("Actualmente no se puede generar el informe por que no hay datos disponibles'", MsgBoxStyle.Exclamation, "Informe")
    End Sub

    Private Sub Informes_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class