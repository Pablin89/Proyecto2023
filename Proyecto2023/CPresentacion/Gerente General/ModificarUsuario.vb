Public Class ModificarUsuario
    Dim item As Integer
    Private Sub ModificarUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        verEmpleadosConUsuario()
        reiniciarBusqueda()
        BConfirmarPerfil.Visible = False
        TContraseña.Enabled = False
        ChBContraseña.Visible = True
    End Sub


    Public Sub reiniciarBusqueda()
        BConfirmarPerfil.Visible = False
        TextBox1.Clear()
        TextBox1.Enabled = False
        TextBox3.Enabled = False
        TextBox3.Clear()
        TextBox4.Enabled = False
        TextBox4.Clear()
        TContraseña.Enabled = False
        ChBContraseña.Visible = True
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
    End Sub


    Private Sub BConfirmarPerfil_Click(sender As Object, e As EventArgs) Handles BConfirmarPerfil.Click
        modificarUsuario()
    End Sub


    Public Sub modificarUsuario()
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
                If TContraseña.Text = "" Then
                    nusuario.modificarUsuarioSinContraseña(nombreUsuario, perfil, item)
                Else
                    nusuario.modificarUsuario(nombreUsuario, contraseña, perfil, item)
                End If

            Catch ex As Exception

            End Try

            MsgBox("Se ha modificado correctamente el usuario seleccionado", MsgBoxStyle.Information, "Usuario modificado")
            verEmpleadosConUsuario()
            reiniciarBusqueda()
        End If

    End Sub


    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

        Dim ask As MsgBoxResult
        Dim i As Integer
        i = DataGridView2.CurrentRow.Index

        ask = MsgBox("Ver detalle del Empleado: '" + Me.DataGridView2.Item(2, i).Value.ToString + "' ?", MsgBoxStyle.YesNo, "Ver")
        If (MsgBoxResult.Yes = ask) Then
            item = Me.DataGridView2.Item(0, i).Value
            seleccionarUsuarioConsultar(item)
            BConfirmarPerfil.Visible = True
            TContraseña.Visible = False
            ChBContraseña.Visible = True
        End If
    End Sub

    Public Sub seleccionarUsuarioConsultar(id As Integer)

        Try
            Dim nu As New NUsuarios
            Dim dt As DataTable = nu.seleccionarUsuarioConsultar(id)
            'DataGridView2.DataSource = dt
            TApeynom.Text = dt.Rows(0)(1).ToString + " " + dt.Rows(0)(2).ToString
            TDni.Text = dt.Rows(0)(3).ToString
            TCorreo.Text = dt.Rows(0)(5).ToString
            TTelefono.Text = dt.Rows(0)(7).ToString
            TNombreUsuario.Text = dt.Rows(0)(8).ToString
            ComboBox1.Text = dt.Rows(0)(9).ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Lista de empleados con usuario asignado
    Public Sub verEmpleadosConUsuario()
        Try
            Dim ne As New NEmpleados
            Dim dt As DataTable = ne.verEmpleadosConUsuario()
            DataGridView2.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ChBContraseña_CheckedChanged(sender As Object, e As EventArgs) Handles ChBContraseña.CheckedChanged
        Dim ask As MsgBoxResult

        If ChBContraseña.Checked Then
            ask = MsgBox("Si se activa este campo se debe ingresar una nueva contraseña para el usuario. Desea establecer una nueva contraseña para este usuario?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Contraseña nueva")
            If ask = MsgBoxResult.Yes Then
                ChBContraseña.Visible = False
                TContraseña.Visible = True
                TContraseña.Enabled = True

            Else
                ChBContraseña.Checked = False
            End If




        End If
    End Sub

    Private Sub ModificarUsuarios_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        TContraseña.Clear()
        TNombreUsuario.Clear()
        TApeynom.Clear()
        TTelefono.Clear()
        TCorreo.Clear()
        TDni.Clear()
        ComboBox1.SelectedIndex = -1
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If (CheckBox2.Checked) Then
            CheckBox1.Checked = False
            CheckBox3.Checked = False
            TextBox4.Enabled = True
            TextBox3.Enabled = False
            TextBox1.Enabled = False
            TextBox3.Clear()
            TextBox1.Clear()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked) Then
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            TextBox3.Enabled = True
            TextBox4.Enabled = False
            TextBox1.Enabled = False
            TextBox4.Clear()
            TextBox1.Clear()
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If (CheckBox3.Checked) Then
            CheckBox2.Checked = False
            CheckBox1.Checked = False
            TextBox1.Enabled = True
            TextBox4.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Clear()
            TextBox3.Clear()
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
                buscarUsuarioApellido(apellido)
            End If
        ElseIf (CheckBox2.Checked And Not CheckBox1.Checked) Then
            If (dni = "") Then
                MsgBox("Completa El Campo DNI", MsgBoxStyle.Critical, "Error")
            Else
                MsgBox("Buscar por 'DNI': " + dni, MsgBoxStyle.Information, "Buscar")
                buscarUsuarioDni(dni)
            End If
        Else
            MsgBox("No seleccionaste ninguna opción", MsgBoxStyle.Exclamation, "Advertencia")
        End If
        BLimpiarFiltros.Visible = True
    End Sub


    'busqueda diámica con dni consultar
    Public Sub buscarUsuarioDni(dni As String)
        Try
            Dim du As New NUsuarios
            Dim dt As DataTable = du.buscarUsuarioDni(dni)
            DataGridView2.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'busqueda diámica con apellido consultar
    Public Sub buscarUsuarioApellido(apellido As String)
        Try
            Dim du As New NUsuarios
            Dim dt As DataTable = du.buscarUsuarioApellido(apellido)
            DataGridView2.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BLimpiarFiltros_Click(sender As Object, e As EventArgs) Handles BLimpiarFiltros.Click
        verEmpleadosConUsuario()
        reiniciarBusqueda()
    End Sub


End Class