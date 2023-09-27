Public Class Categoría
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (TextBox1.Text = "") Then
            MsgBox("ingrese la nueva categoría", MsgBoxStyle.Exclamation, "Atención")
        Else
            MsgBox("Categoría: '" + TextBox1.Text + "' Agregada", MsgBoxStyle.Information, "Agregada")
            GestionProductos.ComboBox1.Items.Add(TextBox1.Text)
            Me.Close()
        End If
    End Sub
End Class