Imports System.Text.RegularExpressions

Public Class Empleados
    Private Sub BRCambios_Click(sender As Object, e As EventArgs) Handles BRCambios.Click
        BRCambios.Visible = False
        BCambios.Visible = True
        TApellidoYNombre.Enabled = True
        TDireccion.Enabled = True
        TDni.Enabled = True
        TCorreo.Enabled = True
        TTelefono.Enabled = True
        DTFechaNac.Enabled = True
    End Sub

    Private Sub Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TApellidoYNombre.Enabled = False
        TDireccion.Enabled = False
        TDni.Enabled = False
        TCorreo.Enabled = False
        TTelefono.Enabled = False
        DTFechaNac.Enabled = False
    End Sub

    'Seccion Agregar empleado
    'restricciones(Busqueda)
    Private Sub TextBox11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox11.KeyPress

        If (Char.IsNumber(e.KeyChar)) Then
            e.Handled = False
            TextBox11.MaxLength = 8

            If (TextBox11.Text.Length > 7) Then
                MessageBox.Show("El DNI tiene un máximo de 8 digitos", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        ElseIf (Char.IsControl(e.KeyChar)) Then

            e.Handled = False

        Else

            e.Handled = True
            MessageBox.Show("solo se permiten numeros", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (TextBox11.Text = "") Then
            MsgBox("Introduzca un DNI para la búsqueda", MsgBoxStyle.Exclamation, "Atención")
        Else
            MsgBox("Buscar empleado por DNI: " + TextBox11.Text, MsgBoxStyle.Information, "Buscar")
        End If
    End Sub

    'Restricciones(Agregar Empleado)
    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress

        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("solo se permiten letras", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub
    Private Sub TextBo6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress

        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("solo se permiten letras", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub
    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress

        If (Char.IsNumber(e.KeyChar)) Then
            e.Handled = False
            TextBox7.MaxLength = 8

            If (TextBox7.Text.Length > 7) Then
                MessageBox.Show("El DNI tiene un máximo de 8 digitos", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        ElseIf (Char.IsControl(e.KeyChar)) Then

            e.Handled = False

        Else

            e.Handled = True
            MessageBox.Show("solo se permiten numeros", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If


    End Sub

    Private Sub TextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress

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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ask As MsgBoxResult

        If ((TextBox5.Text <> "") And
            (TextBox6.Text <> "") And
            (TextBox7.Text <> "") And
            (TextBox8.Text <> "") And
            (TextBox9.Text <> "") And
            (TextBox10.Text <> "")
            ) Then

            If (EmailAddressCheck(TextBox10.Text)) Then
                ask = MsgBox("Seguro desea Agregar Empleado?", MsgBoxStyle.YesNo, "Confirmar")

                If ask = MsgBoxResult.Yes Then
                    MsgBox("Empleado Agregado", MsgBoxStyle.OkOnly, "Agregado")
                    TextBox5.Text = ""
                    TextBox6.Text = ""
                    TextBox7.Text = ""
                    TextBox8.Text = ""
                    TextBox9.Text = ""
                    TextBox10.Text = ""
                Else
                    MsgBox("No se agregó el Empleado", MsgBoxStyle.OkOnly, "No Agregado")

                End If

            Else
                MessageBox.Show("Formato de correo no válido. Formato permitido ej: 'usuario@gmail.com'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If




        Else

            MsgBox("Debe completar todos los campos", MsgBoxStyle.Exclamation, "Error")

        End If
    End Sub

    'Area Editar Empleados
    'Filtros de Busqueda
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
        Dim dni As String = TextBox1.Text
        Dim apellido As String = TextBox2.Text
        If (ChBDni.Checked And ChBApellido.Checked) Then
            If (dni = "" Or apellido = "") Then
                MsgBox("Completa los campos seleccionados", MsgBoxStyle.Critical, "Error")
            Else
                MsgBox("Buscar por 'DNI': " + dni + " 'Apellido': " + apellido, MsgBoxStyle.Information, "Buscar")
            End If
        ElseIf (Not ChBDni.Checked And ChBApellido.Checked) Then
            If (apellido = "") Then
                MsgBox("Completa El Campo Apellido", MsgBoxStyle.Critical, "Error")
            Else
                MsgBox("Buscar por 'Apellido': " + apellido, MsgBoxStyle.Information, "Buscar")
            End If
        ElseIf (ChBDni.Checked And Not ChBApellido.Checked) Then
            If (dni = "") Then
                MsgBox("Completa El Campo DNI", MsgBoxStyle.Critical, "Error")
            Else
                MsgBox("Buscar por 'DNI': " + dni, MsgBoxStyle.Information, "Buscar")
            End If
        Else
            MsgBox("No seleccionaste ninguna opción", MsgBoxStyle.Exclamation, "Advertencia")
        End If
    End Sub

    'Restricciones de editar empleado
    Private Sub TApellidoYNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TApellidoYNombre.KeyPress

        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("solo se permiten letras", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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

    Private Sub BCambios_Click(sender As Object, e As EventArgs) Handles BCambios.Click
        BRCambios.Visible = False


        Dim ask As MsgBoxResult

        If ((TApellidoYNombre.Text <> "") And
            (TDireccion.Text <> "") And
            (TDni.Text <> "") And
            (TCorreo.Text <> "") And
            (TTelefono.Text <> "")
            ) Then

            If (EmailAddressCheck(TCorreo.Text)) Then
                ask = MsgBox("Seguro desea Editar Empleado?", MsgBoxStyle.YesNo, "Confirmar")

                If ask = MsgBoxResult.Yes Then
                    MsgBox("Empleado Editado", MsgBoxStyle.OkOnly, "Agregado")
                    TApellidoYNombre.Text = ""
                    TDireccion.Text = ""
                    TDni.Text = ""
                    TCorreo.Text = ""
                    TTelefono.Text = ""
                    BRCambios.Visible = True
                    BCambios.Visible = False
                    TApellidoYNombre.Enabled = False
                    TDireccion.Enabled = False
                    TDni.Enabled = False
                    TCorreo.Enabled = False
                    TTelefono.Enabled = False
                    DTFechaNac.Enabled = False
                Else
                    MsgBox("No se Editó el Empleado", MsgBoxStyle.OkOnly, "No Agregado")

                End If

            Else
                MessageBox.Show("Formato de correo no válido. Formato permitido ej: 'usuario@gmail.com'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If




        Else

            MsgBox("Debe completar todos los campos", MsgBoxStyle.Exclamation, "Error")

        End If
    End Sub

    'SECCION CONSULTAR EMPLEADOS
    'Restricciones
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
        Dim dni As String = TextBox4.Text
        Dim apellido As String = TextBox3.Text
        If (CheckBox2.Checked And CheckBox1.Checked) Then
            If (dni = "" Or apellido = "") Then
                MsgBox("Completa los campos seleccionados", MsgBoxStyle.Critical, "Error")
            Else
                MsgBox("Buscar por 'DNI': " + dni + " 'Apellido': " + apellido, MsgBoxStyle.Information, "Buscar")
            End If
        ElseIf (Not CheckBox2.Checked And CheckBox1.Checked) Then
            If (apellido = "") Then
                MsgBox("Completa El Campo Apellido", MsgBoxStyle.Critical, "Error")
            Else
                MsgBox("Buscar por 'Apellido': " + apellido, MsgBoxStyle.Information, "Buscar")
            End If
        ElseIf (CheckBox2.Checked And Not CheckBox1.Checked) Then
            If (dni = "") Then
                MsgBox("Completa El Campo DNI", MsgBoxStyle.Critical, "Error")
            Else
                MsgBox("Buscar por 'DNI': " + dni, MsgBoxStyle.Information, "Buscar")
            End If
        Else
            MsgBox("No seleccionaste ninguna opción", MsgBoxStyle.Exclamation, "Advertencia")
        End If
    End Sub
End Class