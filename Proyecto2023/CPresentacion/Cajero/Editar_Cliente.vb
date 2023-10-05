Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Editar_Cliente
    Dim conexion As SqlConnection
    Dim comando As SqlCommand
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
                    MsgBox("Cliente Editado", MsgBoxStyle.OkOnly, "Editado")
                    TextBox3.Text = ""
                    TextBox2.Text = ""
                    TextBox1.Text = ""
                    TextBox4.Text = ""
                    TextBox5.Text = ""
                    TextBox6.Text = ""
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
            buscarCliente(TextBox7.Text)
            MsgBox("Buscar por DNI: '" + TextBox7.Text, MsgBoxStyle.Information, "Buscar")
            TextBox7.Clear()
        End If
    End Sub

    Private Sub Editar_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New SqlConnection("server = .\SQLEXPRESS; database = Proyecto2023; integrated security = true")
        DataGridView1.AllowUserToAddRows = False
        verClientes()
    End Sub

    Public Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim ask As MsgBoxResult
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        ask = MsgBox("Desea Seleccionar este cliente? " + Me.DataGridView1.Item(1, i).Value.ToString + " " + Me.DataGridView1.Item(2, i).Value.ToString, vbYesNo + vbInformation, "Agregar Producto")
        If (MsgBoxResult.Yes = ask) Then
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
            Dim query As String = "select 
                                id_cliente As id,
                                apellido As Apellido,
                                nombre As Nombre,
                                telefono As Telefono,
                                fecha_nacimiento As Nacimiento,
                                correo As Mail,
                                direccion As Dirección,
                                dni As DNI
                          from clientes"
            Dim adaptador As New SqlDataAdapter(query, conexion)
            Dim dt As New DataTable
            adaptador.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Public Sub buscarCliente(dni As String)
        Try
            Dim query As String = "select 
                                id_cliente As id,
                                apellido As Apellido,
                                nombre As Nombre,
                                telefono As Telefono,
                                fecha_nacimiento As Nacimiento,
                                correo As Mail,
                                direccion As Dirección,
                                dni As DNI
                                from clientes where dni like '" & dni & "%'"
            Dim adaptador As New SqlDataAdapter(query, conexion)
            Dim dt As New DataTable
            adaptador.Fill(dt)
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class