Public Class Informes_Productos

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBFiltro.SelectedIndexChanged
        If (CBFiltro.Text = "Productos por categorias") Then
            LCategoria.Visible = True
            CBCategoria.Visible = True
        Else
            LCategoria.Visible = False
            CBCategoria.Visible = False
        End If
    End Sub

    Private Sub Informes_Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBCategoria.Visible = False
        LCategoria.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (CBFiltro.Text = "") Then
            MsgBox("Seleccione un filtro para generar informe", MsgBoxStyle.Exclamation, "Atención")
        ElseIf (CBFiltro.Text = "Ultimos productos agregados") Then
            MsgBox("Seleccionaste buscar por 'Ultimos productos agregados'", MsgBoxStyle.Information, "Buscar")
            MsgBox("Actualmente no se puede generar el informe por que no hay datos disponibles'", MsgBoxStyle.Exclamation, "Informe")
        ElseIf (CBFiltro.Text = "Productos eliminados") Then
            MsgBox("Seleccionaste buscar por 'Productos eliminados'", MsgBoxStyle.Information, "Buscar")
            MsgBox("Actualmente no se puede generar el informe por que no hay datos disponibles'", MsgBoxStyle.Exclamation, "Informe")
        ElseIf (CBFiltro.Text = "Productos con bajo stock") Then
            MsgBox("Seleccionaste buscar por 'Productos con bajo stock'", MsgBoxStyle.Information, "Buscar")
            MsgBox("Actualmente no se puede generar el informe por que no hay datos disponibles'", MsgBoxStyle.Exclamation, "Informe")
        ElseIf (CBFiltro.Text = "Productos mas vendidos") Then
            MsgBox("Seleccionaste buscar por 'Productos mas vendidos'", MsgBoxStyle.Information, "Buscar")
            MsgBox("Actualmente no se puede generar el informe por que no hay datos disponibles'", MsgBoxStyle.Exclamation, "Informe")
        ElseIf (CBFiltro.Text = "Productos menos vendidos") Then
            MsgBox("Seleccionaste buscar por 'Productos menos vendidos'", MsgBoxStyle.Information, "Buscar")
            MsgBox("Actualmente no se puede generar el informe por que no hay datos disponibles'", MsgBoxStyle.Exclamation, "Informe")
        ElseIf (CBFiltro.Text = "Productos por categorias") Then
            If (CBCategoria.Text = "") Then
                MsgBox("Seleccione una categoria para generar informe", MsgBoxStyle.Exclamation, "Atención")
            ElseIf (CBCategoria.Text = "Bazar") Then
                MsgBox("Seleccionaste categoria 'Bazar'", MsgBoxStyle.Information, "Buscar")
                MsgBox("Actualmente no se puede generar el informe por que no hay datos disponibles'", MsgBoxStyle.Exclamation, "Informe")
            ElseIf (CBCategoria.Text = "Jugueteria") Then
                MsgBox("Seleccionaste categoria 'Jugueteria'", MsgBoxStyle.Information, "Buscar")
                MsgBox("Actualmente no se puede generar el informe por que no hay datos disponibles'", MsgBoxStyle.Exclamation, "Informe")
            ElseIf (CBCategoria.Text = "Ferreteria") Then
                MsgBox("Seleccionaste categoria 'Ferreteria'", MsgBoxStyle.Information, "Buscar")
                MsgBox("Actualmente no se puede generar el informe por que no hay datos disponibles'", MsgBoxStyle.Exclamation, "Informe")
            ElseIf (CBCategoria.Text = "Cotillon") Then
                MsgBox("Seleccionaste categoria 'Cotillon'", MsgBoxStyle.Information, "Buscar")
                MsgBox("Actualmente no se puede generar el informe por que no hay datos disponibles'", MsgBoxStyle.Exclamation, "Informe")
            End If
        End If

    End Sub


End Class