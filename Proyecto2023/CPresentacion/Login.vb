Public Class Login


    Private Sub Blogin_Click(sender As Object, e As EventArgs) Handles BLogin.Click

        If ((TUsuario.Text = "") And (TContraseña.Text = "")) Then
            MessageBox.Show("Completa los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Show()
        Else
            If TUsuario.Text = "Encargado" And TContraseña.Text = "encargado" Then
                Me.Hide()
                Encargado_Principal.Show()
            Else
                MessageBox.Show("usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Show()
            End If


        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TUsuario.Focus()
    End Sub

End Class