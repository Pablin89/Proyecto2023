Public Class GerenteGral_Principal
    Private Sub BCerrarSesion_Click(sender As Object, e As EventArgs) Handles BCerrarSesion.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Misdatos.ShowDialog()
    End Sub
End Class