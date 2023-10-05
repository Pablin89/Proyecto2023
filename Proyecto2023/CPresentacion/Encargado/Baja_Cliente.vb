Imports System.Text.RegularExpressions

Public Class Baja_Cliente
    Private Sub TBuscarDni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBuscarDni.KeyPress

        If (Char.IsNumber(e.KeyChar)) Then
            e.Handled = False
            TBuscarDni.MaxLength = 8

            If (TBuscarDni.Text.Length > 7) Then
                MessageBox.Show("El DNI tiene un máximo de 8 digitos", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        ElseIf (Char.IsControl(e.KeyChar)) Then

            e.Handled = False

        Else

            e.Handled = True
            MessageBox.Show("solo se permiten numeros", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If


    End Sub

    Private Sub TBuscarapellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBuscarapellido.KeyPress

        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("solo se permiten letras", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Function EmailAddressCheck(ByVal emailaddress As String) As Boolean
        Dim pattern As String = "\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
        Dim emailAddressMatch As Match = Regex.Match(emailaddress, pattern)
        If emailAddressMatch.Success Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        Dim dni As String = TBuscarDni.Text
        Dim apellido As String = TBuscarapellido.Text
        Dim correo As String = TBuscarCorreo.Text
        If (RBDni.Checked) Then

            If (dni = "") Then
                MsgBox("Introduzca un DNI", MsgBoxStyle.Critical, "Error")
            Else
                MsgBox("Seleccionaste buscar por DNI: " + dni, MsgBoxStyle.Information, "Buscar")
            End If
        ElseIf (RBApellido.Checked) Then


            If (apellido = "") Then
                MsgBox("Introduzca un apellido", MsgBoxStyle.Critical, "Error")
            Else
                MsgBox("Seleccionaste buscar por Apellido: " + apellido, MsgBoxStyle.Information, "Buscar")
            End If
        ElseIf (RBCorreo.Checked) Then


            If (correo = "") Then
                MsgBox("Introduzca un correo", MsgBoxStyle.Critical, "Error")
            ElseIf (EmailAddressCheck(correo)) Then
                MsgBox("Seleccionaste buscar por Correo: " + correo, MsgBoxStyle.Information, "Buscar")
            Else
                MsgBox("Formato de correo no válido. Formato permitido ej: 'usuario@gmail.com'", MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox("No Seleccionaste ninguna busqueda", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub BSeleccionar_Click(sender As Object, e As EventArgs) Handles BSeleccionar.Click
        MsgBox("No Seleccionaste ningun cliente para dar de baja", MsgBoxStyle.Critical, "Error")
    End Sub

    Private Sub Baja_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBuscarapellido.Enabled = False
        TBuscarCorreo.Enabled = False
        TBuscarDni.Enabled = False
    End Sub

    Private Sub RBDni_CheckedChanged(sender As Object, e As EventArgs) Handles RBDni.CheckedChanged
        If (RBDni.Checked) Then
            TBuscarapellido.Clear()
            TBuscarapellido.Enabled = False
            TBuscarCorreo.Clear()
            TBuscarCorreo.Enabled = False
            TBuscarDni.Enabled = True
        End If
    End Sub

    Private Sub RBApellido_CheckedChanged(sender As Object, e As EventArgs) Handles RBApellido.CheckedChanged
        If (RBApellido.Checked) Then

            TBuscarapellido.Enabled = True
            TBuscarCorreo.Enabled = False
            TBuscarCorreo.Clear()
            TBuscarDni.Enabled = False
            TBuscarDni.Clear()
        End If
    End Sub

    Private Sub RBCorreo_CheckedChanged(sender As Object, e As EventArgs) Handles RBCorreo.CheckedChanged
        If (RBCorreo.Checked) Then

            TBuscarDni.Clear()
            RBApellido.Checked = False
            TBuscarapellido.Clear()
            TBuscarapellido.Enabled = False
            TBuscarCorreo.Enabled = True
            TBuscarDni.Enabled = False
        End If
    End Sub
End Class