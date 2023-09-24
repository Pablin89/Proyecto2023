Public Class Informes_Productos

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If (ComboBox1.Text = "Productos por categorias") Then
            ComboBox2.Enabled = True
        Else
            ComboBox2.Enabled = False
        End If
    End Sub

    Private Sub Informes_Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox2.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (ComboBox1.Text = "") Then
            MsgBox("Seleccione un filtro para generar informe", MsgBoxStyle.Exclamation, "Atención")
        ElseIf (ComboBox1.Text = "Ultimos productos agregados") Then
            MsgBox("Seleccionaste buscar por 'Ultimos productos agregados'", MsgBoxStyle.Information, "Buscar")
        ElseIf (ComboBox1.Text = "Productos eliminados") Then
            MsgBox("Seleccionaste buscar por 'Productos eliminados'", MsgBoxStyle.Information, "Buscar")
        ElseIf (ComboBox1.Text = "Productos con bajo stock") Then
            MsgBox("Seleccionaste buscar por 'Productos con bajo stock'", MsgBoxStyle.Information, "Buscar")
        ElseIf (ComboBox1.Text = "Productos mas vendidos") Then
            MsgBox("Seleccionaste buscar por 'Productos mas vendidos'", MsgBoxStyle.Information, "Buscar")
        ElseIf (ComboBox1.Text = "Productos menos vendidos") Then
            MsgBox("Seleccionaste buscar por 'Productos menos vendidos'", MsgBoxStyle.Information, "Buscar")
        ElseIf (ComboBox1.Text = "Productos por categorias") Then
            If (ComboBox2.Text = "") Then
                MsgBox("Seleccione una categoria para generar informe", MsgBoxStyle.Exclamation, "Atención")
            ElseIf (ComboBox2.Text = "Bazar") Then
                MsgBox("Seleccionaste categoria 'Bazar'", MsgBoxStyle.Information, "Buscar")
            ElseIf (ComboBox2.Text = "Jugueteria") Then
                MsgBox("Seleccionaste categoria 'Jugueteria'", MsgBoxStyle.Information, "Buscar")
            ElseIf (ComboBox2.Text = "Ferreteria") Then
                MsgBox("Seleccionaste categoria 'Ferreteria'", MsgBoxStyle.Information, "Buscar")
            ElseIf (ComboBox2.Text = "Cotillon") Then
                MsgBox("Seleccionaste categoria 'Cotillon'", MsgBoxStyle.Information, "Buscar")
            End If
        End If
    End Sub
End Class