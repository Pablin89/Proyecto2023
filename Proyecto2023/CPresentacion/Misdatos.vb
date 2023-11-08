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

    Private Sub TDni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDni.KeyPress
        If (Char.IsNumber(e.KeyChar)) Then
            e.Handled = False
            TDni.MaxLength = 8

            If (TDni.Text.Length > 7) Then
                MessageBox.Show("El DNI tiene un máximo de 8 digitos", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        ElseIf (Char.IsControl(e.KeyChar)) Then

            e.Handled = False

        Else

            e.Handled = True
            MessageBox.Show("solo se permiten numeros", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
    End Sub

    Private Sub TNomYApe_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNomYApe.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("solo se permiten letras", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class