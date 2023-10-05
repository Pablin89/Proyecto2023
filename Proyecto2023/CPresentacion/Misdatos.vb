Public Class Misdatos
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub BModificarP_Click(sender As Object, e As EventArgs) Handles BModificarP.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("Desea modificar sus datos? ", vbYesNo + vbDefaultButton2 + vbCritical, "Modificaciones")
        If (MsgBoxResult.Yes = ask) Then

            BModificarP.Visible = False
            BConfirmarModificaciones.Visible = True

            TNomYApe.Enabled = True
            TDni.Enabled = True
            TCorreo.Enabled = True
            TTelefono.Enabled = True
            TDireccion.Enabled = True
            DTFechaNac.Enabled = True
            MsgBox(" Ya puede modificar sus datos.", vbOKOnly + vbInformation, "Modificaciones")
        End If
    End Sub

    Private Sub BConfirmarModificaciones_Click(sender As Object, e As EventArgs) Handles BConfirmarModificaciones.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("Desea confirmar las modificaciones de sus datos? ", vbYesNo + vbDefaultButton2 + vbCritical, "Confirmar Modificaciones")
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
        If (MsgBoxResult.Yes = ask) Then
            MsgBox(" Las modificaciones se realizaron correctamente.", vbOKOnly + vbInformation, "Modificaciones")
        Else
            MsgBox(" No se realizaron modificaciones.", vbOKOnly + vbInformation, "Modificaciones")
        End If
    End Sub
End Class