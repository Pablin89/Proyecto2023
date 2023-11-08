Public Class AgregarStock
    Dim Prod As New NProductos
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

        If (Char.IsNumber(e.KeyChar)) Then

            e.Handled = False

        ElseIf (Char.IsControl(e.KeyChar)) Then

            e.Handled = False

        Else

            e.Handled = True
            MessageBox.Show("solo se permiten numeros", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id_producto As Integer = 1
        If (TextBox1.Text = "") Then
            MsgBox("Debe ingresar un stock", MsgBoxStyle.Critical, "Atención")
        Else

            Prod.actualizarStock(id_producto, Convert.ToInt32(TextBox1.Text))
            MsgBox("Stock agregado", MsgBoxStyle.Information, "Agregado")
            Me.Close()
        End If
    End Sub
End Class