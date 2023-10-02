Public Class Misdatos
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub BModificarP_Click(sender As Object, e As EventArgs) Handles BModificarP.Click
        BModificarP.Visible = False
        BConfirmarModificaciones.Visible = True

        TNomYApe.Enabled = True
        TDni.Enabled = True
        TCorreo.Enabled = True
        TTelefono.Enabled = True
        TDireccion.Enabled = True
        DTFechaNac.Enabled = True
    End Sub

    Private Sub BConfirmarModificaciones_Click(sender As Object, e As EventArgs) Handles BConfirmarModificaciones.Click
        BModificarP.Visible = True
        BConfirmarModificaciones.Visible = False

        TNomYApe.Enabled = False
        TDni.Enabled = False
        TCorreo.Enabled = False
        TTelefono.Enabled = False
        TDireccion.Enabled = False
        DTFechaNac.Enabled = False
        TUsuario.Enabled = False
        TTipoUsuario.Enabled = False
    End Sub
End Class