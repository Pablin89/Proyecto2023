﻿Imports System.Net.Mime.MediaTypeNames
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class GestionCajeros
    'METODOS DE CONSULTA CAJEROS
    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress

        If (Char.IsNumber(e.KeyChar)) Then

            e.Handled = False
            TextBox4.MaxLength = 8

            If (TextBox4.Text.Length > 7) Then
                MessageBox.Show("El DNI tiene un máximo de 8 digitos", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        ElseIf (Char.IsControl(e.KeyChar)) Then

            e.Handled = False

        Else

            e.Handled = True
            MessageBox.Show("solo se permiten numeros", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If


    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress

        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("solo se permiten letras", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dni As String
        Dim apellido As String

        If (CheckBox2.Checked And CheckBox1.Checked) Then
            'MsgBox("Seleccionaste buscar Cajero por 'DNI' y 'apellido'", MsgBoxStyle.Information, "Buscar")

            If (TextBox4.Text = "" And TextBox3.Text = "") Then
                MsgBox("Completa los campos 'DNI' y 'apellido'", MsgBoxStyle.Information, "Atencion")
            ElseIf (TextBox4.Text <> "" And TextBox3.Text = "") Then
                MsgBox("Completa el campo 'apellido'", MsgBoxStyle.Information, "Atencion")
            ElseIf (TextBox4.Text = "" And TextBox3.Text <> "") Then
                MsgBox("Completa el campo 'DNI'", MsgBoxStyle.Information, "Atencion")
            Else
                dni = TextBox4.Text
                apellido = TextBox3.Text
                MsgBox("Seleccionaste buscar Cajero por 'DNI': " + dni + " y 'Apellido': " + apellido, MsgBoxStyle.Information, "Buscar")
            End If

        ElseIf (CheckBox2.Checked And Not CheckBox1.Checked) Then
            'MsgBox("Seleccionaste buscar Cajero por 'DNI'", MsgBoxStyle.Information, "Buscar")
            If (TextBox4.Text = "") Then
                MsgBox("Completa el campo 'DNI'", MsgBoxStyle.Information, "Atencion")
            Else
                dni = TextBox4.Text
                MsgBox("Seleccionaste buscar Cajero por 'DNI': " + dni, MsgBoxStyle.Information, "Buscar")
            End If
        ElseIf (Not CheckBox2.Checked And CheckBox1.Checked) Then
            'MsgBox("Seleccionaste buscar Cajero por 'apellido'", MsgBoxStyle.Information, "Buscar")
            If (TextBox3.Text = "") Then
                MsgBox("Completa el campo 'apellido'", MsgBoxStyle.Information, "Atencion")
            Else
                apellido = TextBox3.Text
                MsgBox("Seleccionaste buscar Cajero por 'Apellido': " + apellido, MsgBoxStyle.Information, "Buscar")
            End If
        Else
            MsgBox("No seleccionaste ninguna búsqueda", MsgBoxStyle.Exclamation, "Atención")
        End If
    End Sub

    'METODOS EDITAR CAJEROS
    '(BUSCAR)
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

        If (Char.IsNumber(e.KeyChar)) Then

            e.Handled = False
            TextBox1.MaxLength = 8

            If (TextBox1.Text.Length > 7) Then
                MessageBox.Show("El DNI tiene un máximo de 8 digitos", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        ElseIf (Char.IsControl(e.KeyChar)) Then

            e.Handled = False

        Else

            e.Handled = True
            MessageBox.Show("solo se permiten numeros", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If


    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress

        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("solo se permiten letras", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click
        Dim dni As String
        Dim apellido As String

        If (ChBDni.Checked And ChBApellido.Checked) Then
            'MsgBox("Seleccionaste buscar Cajero por 'DNI' y 'apellido'", MsgBoxStyle.Information, "Buscar")

            If (TextBox1.Text = "" And TextBox2.Text = "") Then
                MsgBox("Completa los campos 'DNI' y 'apellido'", MsgBoxStyle.Information, "Atencion")
            ElseIf (TextBox1.Text <> "" And TextBox2.Text = "") Then
                MsgBox("Completa el campo 'apellido'", MsgBoxStyle.Information, "Atencion")
            ElseIf (TextBox1.Text = "" And TextBox2.Text <> "") Then
                MsgBox("Completa el campo 'DNI'", MsgBoxStyle.Information, "Atencion")
            Else
                dni = TextBox1.Text
                apellido = TextBox2.Text
                MsgBox("Seleccionaste buscar Cajero por 'DNI': " + dni + " y 'Apellido': " + apellido, MsgBoxStyle.Information, "Buscar")
            End If

        ElseIf (ChBDni.Checked And Not ChBApellido.Checked) Then
            'MsgBox("Seleccionaste buscar Cajero por 'DNI'", MsgBoxStyle.Information, "Buscar")
            If (TextBox1.Text = "") Then
                MsgBox("Completa el campo 'DNI'", MsgBoxStyle.Information, "Atencion")
            Else
                dni = TextBox1.Text
                MsgBox("Seleccionaste buscar Cajero por 'DNI': " + dni, MsgBoxStyle.Information, "Buscar")
            End If
        ElseIf (Not ChBDni.Checked And ChBApellido.Checked) Then
            'MsgBox("Seleccionaste buscar Cajero por 'apellido'", MsgBoxStyle.Information, "Buscar")
            If (TextBox2.Text = "") Then
                MsgBox("Completa el campo 'apellido'", MsgBoxStyle.Information, "Atencion")
            Else
                apellido = TextBox2.Text
                MsgBox("Seleccionaste buscar Cajero por 'Apellido': " + apellido, MsgBoxStyle.Information, "Buscar")
            End If
        Else
            MsgBox("No seleccionaste ninguna búsqueda", MsgBoxStyle.Exclamation, "Atención")
        End If
    End Sub

    '(Edición de cajeros)
    Private Sub TTDni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDni.KeyPress

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

    Private Sub TTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TTelefono.KeyPress

        If (Char.IsNumber(e.KeyChar)) Then

            e.Handled = False

        ElseIf (Char.IsControl(e.KeyChar)) Then

            e.Handled = False

        Else

            e.Handled = True
            MessageBox.Show("solo se permiten numeros", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

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

    Private Sub BCambios_Click(sender As Object, e As EventArgs) Handles BCambios.Click
        Dim ask As MsgBoxResult

        If ((TApellidoYNombre.Text <> "") And
            (TDni.Text <> "") And
            (TFechaNac.Text <> "") And
            (TDireccion.Text <> "") And
            (TTelefono.Text <> "") And
            (TCorreo.Text <> "")
            ) Then

            If (EmailAddressCheck(TCorreo.Text)) Then
                ask = MsgBox("Seguro desea Editar Cajero?", MsgBoxStyle.YesNo, "Confirmar Edición")

                If ask = MsgBoxResult.Yes Then
                    MsgBox("Cajero Editado", MsgBoxStyle.OkOnly, "Editado")
                    TApellidoYNombre.Text = ""
                    TDni.Text = ""
                    TFechaNac.Text = ""
                    TDireccion.Text = ""
                    TTelefono.Text = ""
                    TCorreo.Text = ""
                Else
                    MsgBox("No se Editó el cajero", MsgBoxStyle.OkOnly, "No Editado")

                End If

            Else
                MessageBox.Show("Formato de correo no válido. Formato permitido ej: 'usuario@gmail.com'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If




        Else

            MsgBox("Debe completar todos los campos", MsgBoxStyle.Exclamation, "Error")

        End If
    End Sub



End Class