Public Class Informes_Cajeros
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'If (ComboBox1.Text = "") Then
        '    MsgBox("Debe seleccionar un filtro", MsgBoxStyle.Critical, "Atención")
        'ElseIf (ComboBox1.Text = "Cajeros con mas ventas") Then
        '    MsgBox("Seleccionaste buscar por 'Cajeros con mas ventas'", MsgBoxStyle.Information, "Buscar")
        'ElseIf (ComboBox1.Text = "Cajeros con menos ventas") Then
        '    MsgBox("Seleccionaste buscar por 'Cajeros con menos ventas'", MsgBoxStyle.Information, "Buscar")
        'ElseIf (ComboBox1.Text = "Ultimos cajeros añadidos") Then
        '    MsgBox("Seleccionaste buscar por 'Ultimos cajeros añadidos'", MsgBoxStyle.Information, "Buscar")
        'End If
        ReporteCajeros.ShowDialog()
    End Sub
End Class