Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Baja_Clientes
    Dim conexion As SqlConnection
    Dim comando As SqlCommand
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

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        'Button1.Enabled = False
    End Sub



    Private Sub Baja_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.AllowUserToAddRows = False
        conexion = New SqlConnection("server = DIEGO\SQLEXPRESS; database = Proyecto2023; integrated security = true")
        verClientes()
    End Sub
    Public Sub verClientes()
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
    End Sub

    Public Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim ask As MsgBoxResult
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        ask = MsgBox("Desea Seleccionar este cliente? " + Me.DataGridView1.Item(1, i).Value.ToString + " " + Me.DataGridView1.Item(2, i).Value.ToString, vbYesNo + vbInformation, "Agregar Producto")
        If (MsgBoxResult.Yes = ask) Then
            Realizar_Venta.TextBox5.Text = Me.DataGridView1.Item(1, i).Value.ToString + " " + Me.DataGridView1.Item(2, i).Value.ToString
            Realizar_Venta.TextBox6.Text = Me.DataGridView1.Item(7, i).Value.ToString
            Me.Close()
        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        AgregarCliente.ShowDialog()
    End Sub
End Class