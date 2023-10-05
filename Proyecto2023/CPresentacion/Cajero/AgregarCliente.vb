Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class AgregarCliente
    Dim conexion As SqlConnection
    Dim comando As SqlCommand
    'BUSCAR POR DNI
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
        Dim dni As String
        dni = TextBox11.Text
        If (TextBox11.Text = "") Then
            MsgBox("Completa el campo de búsqueda", MsgBoxStyle.Information, "Atencion")
        Else
            'If (TextBox11.Text = "11111111") Then
            'MsgBox("Ya existe un cliente con el dni: " + dni, MsgBoxStyle.Information, "Buscar")
            'Else
            'MsgBox("No existe un cliente con el dni: " + dni + " , puede agregarlo como nuevo cliente", MsgBoxStyle.Information, "Buscar")
            'Panel6.Visible = True
            'Button3.Visible = True
            'Button2.Visible = False
            'TextBox11.Enabled = False
            'End If
            MsgBox("buscar Si existe el cliente con DNI: " + dni, MsgBoxStyle.Information, "Buscar")

        End If
    End Sub

    'AGREGAR CLIENTE METODOS

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
                ask = MsgBox("Seguro desea Agregar cliente?", MsgBoxStyle.YesNo, "Confirmar")

                If ask = MsgBoxResult.Yes Then
                    agregarCliente()
                    MsgBox("Cliente Agregado", MsgBoxStyle.OkOnly, "Agregado")
                    TextBox5.Text = ""
                    TextBox6.Text = ""
                    TextBox7.Text = ""
                    TextBox8.Text = ""
                    TextBox9.Text = ""
                    TextBox10.Text = ""
                    If (MsgBoxResult.Ok = True) Then
                        Baja_Clientes.ShowDialog()
                    End If
                Else
                    MsgBox("No se agregó el cliente", MsgBoxStyle.OkOnly, "No Agregado")

                End If

            Else
                MessageBox.Show("Formato de correo no válido. Formato permitido ej: 'usuario@gmail.com'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If




        Else

            MsgBox("Debe completar todos los campos", MsgBoxStyle.Exclamation, "Error")

        End If
    End Sub

    Private Sub agregarCliente()
        Dim nombre As String = TextBox6.Text
        Dim apellido As String = TextBox5.Text
        Dim fecha_nacimiento As String = DateTimePicker1.Value
        Dim dni As String = Val(TextBox7.Text)
        Dim direccion As String = TextBox8.Text
        Dim telefono As String = Val(TextBox9.Text)
        Dim correo As String = TextBox10.Text
        Dim id_estado_cliente As Integer = 1

        Dim query As String = "Insert into clientes (nombre,apellido,fecha_nacimiento,dni,direccion,telefono,correo,id_estado_cliente) values (@nombre,@apellido,@fecha_nacimiento,@dni,@direccion,@telefono,@correo,@id_estado_cliente)"

        Using comando = New SqlCommand(query, conexion)
            comando.Parameters.AddWithValue("@nombre", nombre)
            comando.Parameters.AddWithValue("@apellido", apellido)
            comando.Parameters.AddWithValue("@fecha_nacimiento", fecha_nacimiento)
            comando.Parameters.AddWithValue("@dni", dni)
            comando.Parameters.AddWithValue("@direccion", direccion)
            comando.Parameters.AddWithValue("@telefono", telefono)
            comando.Parameters.AddWithValue("@correo", correo)
            comando.Parameters.AddWithValue("@id_estado_cliente", id_estado_cliente)
            conexion.Open()
            comando.ExecuteNonQuery()
            Baja_Clientes.verClientes()
            conexion.Close()
        End Using
    End Sub

    Private Sub AgregarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New SqlConnection("server = .\SQLEXPRESS; database = Proyecto2023; integrated security = true")
        'Panel6.Visible = False
        'Button3.Visible = False
        'Button2.Visible = True
        'TextBox11.Enabled = True
    End Sub
End Class