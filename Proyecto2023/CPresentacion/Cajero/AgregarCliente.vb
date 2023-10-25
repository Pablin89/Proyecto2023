Imports System.Data.SqlClient
Imports System.Net
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
        Dim dni As Integer
        dni = TextBox11.Text
        If (TextBox11.Text = "") Then
            MsgBox("Completa el campo de búsqueda", MsgBoxStyle.Information, "Atencion")
        Else
            If (existeCliente() = True) Then
                MsgBox("Ya existe un cliente con el dni: " + dni.ToString, MsgBoxStyle.Information, "Buscar")
            Else
                MsgBox("No existe un cliente con el dni: " + dni.ToString + " , puede agregarlo como nuevo cliente", MsgBoxStyle.Information, "Buscar")
                TextBox7.Text = dni
                Panel6.Visible = True
                Button3.Visible = True
                Button2.Visible = False
                Label8.Text = "AGREGAR NUEVO CLIENTE: "
                TextBox11.Visible = False
            End If
            'MsgBox("buscar Si existe el cliente con DNI: " + dni, MsgBoxStyle.Information, "Buscar")

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

                    'Verifico nuevamente si ya existe el DNI 
                    If (existeClienteR() = False) Then
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
                        MsgBox("Ya existe un cliente con el dni: " + TextBox7.Text, MsgBoxStyle.Critical, "Error")
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
        Try
            Dim ccliente As New NClientes()
            ccliente.insertarCliente(nombre, apellido, telefono, fecha_nacimiento, correo, direccion, dni)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function existeCliente()
        Dim dni As Integer = Val(TextBox11.Text)
        Try
            Dim cte As New NClientes()
            Return cte.existeCliente(dni)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    'Repreguntar si existe el cliente con el textbox7 del formulario
    Public Function existeClienteR()
        Dim dni As Integer = Val(TextBox7.Text)
        Try
            Dim cte As New NClientes()
            Return cte.existeCliente(dni)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Sub AgregarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'conexion = New SqlConnection("server = .\SQLEXPRESS; database = Proyecto2023; integrated security = true")
        Panel6.Visible = False
        Button3.Visible = False
        Button2.Visible = True
        TextBox11.Visible = True
        TextBox11.Text = ""
        Label8.Visible = True
        Label8.Text = "Ingresar DNI del nuevo cliente para comprobar que  no existe en el sistema"
    End Sub
End Class