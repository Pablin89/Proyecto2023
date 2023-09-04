Public Class Principal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TUsuario.Text = "" Or TUsuario.Text = "") Then
            MessageBox.Show("Complete los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Show()
        Else
            If TUsuario.Text = "Encargado" And TContraseña.Text = "encargado" Then
                Me.Hide()
                Encargado_Principal.Show()
            Else
                MessageBox.Show("usuario o contraseña incorrectos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Show()
            End If
        End If
    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TUsuario.Focus()
    End Sub

    Private Sub TUsuario_TextChanged(sender As Object, e As EventArgs) Handles TUsuario.TextChanged

    End Sub
End Class
