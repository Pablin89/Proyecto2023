Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Editar_Cliente
    Dim conexion As SqlConnection
    Dim comando As SqlCommand
    Dim item As Integer
    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress

        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("solo se permiten letras", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress

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
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        Dim ask As MsgBoxResult

        If ((TextBox3.Text <> "") And
            (TextBox2.Text <> "") And
            (TextBox1.Text <> "") And
            (TextBox4.Text <> "") And
            (TextBox5.Text <> "") And
            (TextBox6.Text <> "")
            ) Then

            If (EmailAddressCheck(TextBox6.Text)) Then
                ask = MsgBox("Seguro desea Editar El Cliente?", MsgBoxStyle.YesNo, "Confirmar")

                If ask = MsgBoxResult.Yes Then
                    'Verificar que el DNI sea distinto para hacer el control de existencia del registro
                    If (TextBox1.Text <> Me.DataGridView1.Item(7, i).Value.ToString()) Then

                        'Si no existe otro dni igual al ingresado edita
                        If (existeCliente() = False) Then
                            editarCliente()
                            verClientes()

                            MsgBox("Cliente Editado", MsgBoxStyle.OkOnly, "Editado")
                            TextBox3.Text = ""
                            TextBox2.Text = ""
                            TextBox1.Text = ""
                            TextBox4.Text = ""
                            TextBox5.Text = ""
                            TextBox6.Text = ""
                        Else
                            MsgBox("Ya existe un cliente con el dni: " + TextBox1.Text, MsgBoxStyle.Critical, "Error")
                        End If
                    Else
                        editarCliente()
                        verClientes()

                        MsgBox("Cliente Editado", MsgBoxStyle.OkOnly, "Editado")
                        TextBox3.Text = ""
                        TextBox2.Text = ""
                        TextBox1.Text = ""
                        TextBox4.Text = ""
                        TextBox5.Text = ""
                        TextBox6.Text = ""
                    End If

                Else
                    MsgBox("No se editó el cliente", MsgBoxStyle.OkOnly, "No Editado")

                End If

            Else
                MessageBox.Show("Formato de correo no válido. Formato permitido ej: 'usuario@gmail.com'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If




        Else

            MsgBox("Debe completar todos los campos", MsgBoxStyle.Exclamation, "Error")

        End If
    End Sub

    Public Sub editarCliente()
        Dim nombre As String = TextBox2.Text
        Dim apellido As String = TextBox3.Text
        Dim fecha_nacimiento As String = DateTimePicker2.Value
        Dim dni As String = Val(TextBox1.Text)
        Dim direccion As String = TextBox4.Text
        Dim telefono As String = Val(TextBox5.Text)
        Dim correo As String = TextBox6.Text
        Try
            Dim ccliente As New NClientes()
            ccliente.editarCliente(nombre, apellido, telefono, fecha_nacimiento, correo, direccion, dni, item)
        Catch ex As Exception

        End Try
    End Sub

    'Buscar por DNI
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox7.Text = "") Then
            MsgBox("Introduzca un DNI para la búsqueda", MsgBoxStyle.Exclamation, "Atención")
        Else
            buscarClienteDni(TextBox7.Text)
            MsgBox("Buscar por DNI: '" + TextBox7.Text, MsgBoxStyle.Information, "Buscar")
            TextBox7.Clear()
        End If
    End Sub

    Private Sub Editar_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'conexion = New SqlConnection("server = .\SQLEXPRESS; database = Proyecto2023; integrated security = true")
        DataGridView1.AllowUserToAddRows = False
        verClientes()
    End Sub

    Public Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim ask As MsgBoxResult
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        ask = MsgBox("Desea Seleccionar este cliente? " + Me.DataGridView1.Item(1, i).Value.ToString + " " + Me.DataGridView1.Item(2, i).Value.ToString, vbYesNo + vbInformation, "Agregar Producto")
        If (MsgBoxResult.Yes = ask) Then
            'La variable item me permite recoger el id del cliente para hacer la edición
            item = Me.DataGridView1.Item(0, i).Value
            TextBox3.Text = Me.DataGridView1.Item(1, i).Value.ToString
            TextBox2.Text = Me.DataGridView1.Item(2, i).Value.ToString()
            DateTimePicker2.Value = Me.DataGridView1.Item(4, i).Value
            TextBox1.Text = Me.DataGridView1.Item(7, i).Value.ToString()
            TextBox4.Text = Me.DataGridView1.Item(6, i).Value.ToString()
            TextBox5.Text = Me.DataGridView1.Item(3, i).Value.ToString()
            TextBox6.Text = Me.DataGridView1.Item(5, i).Value.ToString()
        End If

    End Sub

    Public Sub verClientes()
        Try
            Dim dc As New NClientes
            Dim dt As DataTable = dc.verClientes()
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function existeCliente()
        Dim dni As Integer = Val(TextBox1.Text)
        Try
            Dim cte As New NClientes()
            Return cte.existeCliente(dni)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function



    Public Sub buscarClienteDni(dni As String)
        Try
            Dim dc As New NClientes
            Dim dt As DataTable = dc.buscarClienteDni(dni)
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class