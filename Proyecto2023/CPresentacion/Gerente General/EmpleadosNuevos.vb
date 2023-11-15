Public Class EmpleadosNuevos
    Dim item As Integer

    'Lista de todos los empleados
    Public Sub verEmpleados()
        Try
            Dim ne As New NEmpleados
            Dim dt As DataTable = ne.verEmpleados()
            DataGridView2.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Lista de empleados sin usuario asignado
    Public Sub verEmpleadosSinUsuario()
        Try
            Dim ne As New NEmpleados
            Dim dt As DataTable = ne.verEmpleadosSinUsuario()
            DataGridView2.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub




    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

        Dim ask As MsgBoxResult
        Dim i As Integer
        i = DataGridView2.CurrentRow.Index

        ask = MsgBox("Ver detalle del Empleado: '" + Me.DataGridView2.Item(2, i).Value.ToString + "' ?", MsgBoxStyle.YesNo, "Ver")
        If (MsgBoxResult.Yes = ask) Then
            item = Me.DataGridView2.Item(0, i).Value
            seleccionarEmpleadoConsultar(item)
            BConfirmarPerfil.Visible = True
        End If
    End Sub

    Public Sub seleccionarEmpleadoConsultar(id As Integer)

        Try
            Dim de As New NEmpleados
            Dim dt As DataTable = de.seleccionarEmpleadoConsultar(id)

            'DataGridView2.DataSource = dt
            TApeynom.Text = dt.Rows(0)(1).ToString + " " + dt.Rows(0)(2).ToString
            TDni.Text = dt.Rows(0)(3).ToString
            TCorreo.Text = dt.Rows(0)(5).ToString
            TTelefono.Text = dt.Rows(0)(7).ToString


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Permisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BLimpiarFiltros.Visible = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        verEmpleadosSinUsuario()
        BConfirmarPerfil.Visible = False
    End Sub

    Private Sub BConfirmarPerfil_Click(sender As Object, e As EventArgs) Handles BConfirmarPerfil.Click
        agregarUsuario()

    End Sub

    Public Sub agregarUsuario()
        Dim nusuario As New NUsuarios()
        If nusuario.existeElUsuario(TNombreUsuario.Text) Then
            MsgBox("El usuario ya existe", MsgBoxStyle.Information, "Usuario Existente")
        Else
            Dim nombreUsuario As String = TNombreUsuario.Text
            Dim contraseña As String = TContraseña.Text
            Dim perfil As Integer
            If ComboBox1.Text = "Encargado" Then
                perfil = 3
            ElseIf ComboBox1.Text = "Cajero" Then
                perfil = 4
            ElseIf ComboBox1.Text = "Gerente" Then
                perfil = 2
            ElseIf ComboBox1.Text = "Gerente General" Then
                perfil = 1
            End If
            Try

                nusuario.agregarUsuario(nombreUsuario, contraseña, perfil, item)
            Catch ex As Exception

            End Try

            MsgBox("Se ha asignado correctamente el usuario al empleado seleccionado", MsgBoxStyle.Information, "Usuario Asignado")
            BConfirmarPerfil.Visible = False
        End If

    End Sub



    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If (CheckBox2.Checked) Then
            CheckBox1.Checked = False
            TextBox4.Enabled = True
            TextBox3.Enabled = False
            TextBox3.Clear()
        End If
    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked) Then
            CheckBox2.Checked = False
            TextBox4.Clear()
            TextBox4.Enabled = False
            TextBox3.Enabled = True
        End If

    End Sub

    Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click
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
                buscarEmpleadoNApellido(apellido)
            End If
        ElseIf (CheckBox2.Checked And Not CheckBox1.Checked) Then
            If (dni = "") Then
                MsgBox("Completa El Campo DNI", MsgBoxStyle.Critical, "Error")
            Else
                MsgBox("Buscar por 'DNI': " + dni, MsgBoxStyle.Information, "Buscar")
                buscarEmpleadoNDni(dni)
            End If
        Else
            MsgBox("No seleccionaste ninguna opción", MsgBoxStyle.Exclamation, "Advertencia")
        End If
        BLimpiarFiltros.Visible = True
    End Sub


    'busqueda diámica con dni consultar
    Public Sub buscarEmpleadoNDni(dni As String)
        Try
            Dim de As New NEmpleados
            Dim dt As DataTable = de.buscarEmpleadoNDni(dni)
            DataGridView2.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'busqueda diámica con apellido consultar
    Public Sub buscarEmpleadoNApellido(apellido As String)
        Try
            Dim de As New NEmpleados
            Dim dt As DataTable = de.buscarEmpleadoNApellido(apellido)
            DataGridView2.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BLimpiarFiltros_Click(sender As Object, e As EventArgs) Handles BLimpiarFiltros.Click
        verEmpleadosSinUsuario()
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        TextBox4.Clear()
        TextBox3.Clear()
        TextBox4.Enabled = False
        TextBox3.Enabled = False
    End Sub
End Class