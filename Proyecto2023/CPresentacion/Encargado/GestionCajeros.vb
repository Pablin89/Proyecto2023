Imports System.Net.Mime.MediaTypeNames
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
End Class