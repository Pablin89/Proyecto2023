Public Class Seleccionar_Producto
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Debe seleccionar un producto para agregar al carrito", MsgBoxStyle.Information, "Atencion")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (CBCateg.SelectedIndex.Equals(-1)) Then
            MsgBox("Selecciona un filtro de búsqueda", MsgBoxStyle.Information, "Atencion")
        ElseIf (CBCateg.SelectedIndex.Equals(0)) Then
            MsgBox("Seleccionaste buscar por 'Bazar'", MsgBoxStyle.Information, "Buscar")
        ElseIf (CBCateg.SelectedIndex.Equals(1)) Then
            MsgBox("Seleccionaste buscar por 'Libreria'", MsgBoxStyle.Information, "Buscar")
        ElseIf (CBCateg.SelectedIndex.Equals(2)) Then
            MsgBox("Seleccionaste buscar por 'Ferreteria'", MsgBoxStyle.Information, "Buscar")
        End If
    End Sub
End Class