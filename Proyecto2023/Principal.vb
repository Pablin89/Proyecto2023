Public Class Principal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TUsuario.Text = "Encargado" Then
            Me.Hide()
            Encargado_Principal.Show()

        End If
    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TUsuario.Focus()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TContraseña.TextChanged

    End Sub
End Class
