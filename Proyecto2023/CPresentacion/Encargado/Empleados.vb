
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Empleados

    Dim item As Integer
    Private Sub BRCambios_Click(sender As Object, e As EventArgs) Handles BRCambios.Click
        BRCambios.Visible = False
        BCambios.Visible = True
        TApellidos.Enabled = True
        TNombres.Enabled = True
        TDireccion.Enabled = True
        TDni.Enabled = True
        TCorreo.Enabled = True
        TTelefono.Enabled = True
        DTFechaNac.Enabled = True
    End Sub

    Public Sub cargarConsultar()
        TextBox4.Clear()
        TextBox3.Clear()
        TextBox4.Enabled = False
        TextBox3.Enabled = False
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        BLimpiarFiltros.Visible = False
        verEmpleados()
        LApeyNom.Text = ""
        LCorreo2.Text = ""
        LDireccion2.Text = ""
        LDni2.Text = ""
        LFechaNac2.Text = ""
        LEstado2.Text = ""
        LTelefono2.Text = ""
        DataGridView2.Columns(0).Visible = False
        DataGridView2.Columns(1).Width = 200
        DataGridView2.Columns(2).Width = 200
        DataGridView2.Columns(4).Visible = False
        DataGridView2.Columns(5).Visible = False
        DataGridView2.Columns(6).Visible = False
        DataGridView2.Columns(7).Visible = False

    End Sub


    Public Sub cargarEditar()
        TNombres.Clear()
        TDireccion.Clear()
        TDni.Clear()
        TCorreo.Clear()
        TTelefono.Clear()
        TApellidos.Enabled = False
        TNombres.Enabled = False
        TDireccion.Enabled = False
        TDni.Enabled = False
        TCorreo.Enabled = False
        TTelefono.Enabled = False
        DTFechaNac.Enabled = False
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        ChBApellido.Checked = False
        ChBDni.Checked = False
        verEmpleadosEditar()
        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(1).Width = 200
        DataGridView1.Columns(2).Width = 200
        DataGridView1.Columns(4).Visible = False
        DataGridView1.Columns(5).Visible = False
        DataGridView1.Columns(6).Visible = False
        DataGridView1.Columns(7).Visible = False
        BRCambios.Visible = True
        BCambios.Visible = False
    End Sub


    Public Sub cargarAgregar()

        Button9.Visible = False
        Panel6.Visible = False
        Button3.Visible = False
        Button2.Visible = True
        TextBox11.Enabled = True
        TextBox11.Clear()
    End Sub



    Private Sub Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarConsultar()
        cargarEditar()
        cargarAgregar()

        DataGridView2.AllowUserToAddRows = False
        DataGridView1.AllowUserToAddRows = False

        'comboboxs en agregar 
        comboboxSexosAdd()
    End Sub





    'Seccion Agregar empleado -------------------------------------------------------------------------------------------------------------------------------------
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
            If (existeEmpleadoAdd(Val(TextBox11.Text))) Then
                MsgBox("El empleado el DNI " + TextBox11.Text + " ya existe en el sistema.", MsgBoxStyle.Information, "Buscar")
            Else
                MsgBox("Este DNI no existe en el sistema, puede agregar el empleado.", MsgBoxStyle.Information, "Buscar")
                Panel6.Visible = True
                TextBox7.Text = TextBox11.Text
                TextBox7.Enabled = False
                Button3.Visible = True
                Button2.Visible = True
                Button9.Visible = True
                TextBox11.Clear()
            End If
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

    'Cargar en el combobox los sexos del empleado
    Public Sub comboboxSexosAdd()
        Try
            Dim dc As New NSexos
            Dim dt As DataTable = dc.verSexos()
            CbxSexoAdd.DataSource = dt
            CbxSexoAdd.DisplayMember = "descripcion"
            CbxSexoAdd.ValueMember = "id_sexo"
            CbxSexoAdd.SelectedValue = -1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Verificar si el Dni del empleado existe en agregar
    Public Function existeEmpleadoAdd(dni)
        Try
            Dim cte As New NEmpleados()
            Return cte.existeEmpleado(dni)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    'Metodo Para insertar un nuevo empleado
    Private Sub agregarEmpleado()

        Dim dni As Integer = Val(TextBox7.Text)
        Dim apellido As String = TextBox5.Text
        Dim nombre As String = TextBox6.Text
        Dim direccion As String = TextBox8.Text
        Dim telefono As String = TextBox9.Text
        Dim correo As String = TextBox10.Text
        Dim fecha_nacimiento As String = DTFechaNacimiento.Value
        Dim id_sexo As Integer = Val(CbxSexoAdd.SelectedValue.ToString)
        Try
            Dim cempleado As New NEmpleados()
            cempleado.insertarEmpleado(dni, apellido, nombre, direccion, telefono, correo, fecha_nacimiento, id_sexo)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ask As MsgBoxResult

        If ((TextBox5.Text <> "") And
            (TextBox6.Text <> "") And
            (TextBox7.Text <> "") And
            (TextBox8.Text <> "") And
            (TextBox9.Text <> "") And
            (TextBox10.Text <> "") And
            (CbxSexoAdd.Text <> "")
            ) Then

            If (EmailAddressCheck(TextBox10.Text)) Then
                ask = MsgBox("Seguro desea Agregar Empleado?", MsgBoxStyle.YesNo, "Confirmar")

                If ask = MsgBoxResult.Yes Then
                    agregarEmpleado()
                    verEmpleados()
                    verEmpleadosEditar()
                    MsgBox("Empleado Agregado", MsgBoxStyle.OkOnly, "Agregado")
                    TextBox5.Text = ""
                    TextBox6.Text = ""
                    TextBox7.Text = ""
                    TextBox8.Text = ""
                    TextBox9.Text = ""
                    TextBox10.Text = ""
                    CbxSexoAdd.Text = ""
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

    'Area Editar Empleados ------------------------------------------------------------------------------------------------------------------------------------------------------
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
                buscarEmpleadoApellidoEdit(apellido)
            End If
        ElseIf (ChBDni.Checked And Not ChBApellido.Checked) Then
            If (dni = "") Then
                MsgBox("Completa El Campo DNI", MsgBoxStyle.Critical, "Error")
            Else
                MsgBox("Buscar por 'DNI': " + dni, MsgBoxStyle.Information, "Buscar")
                buscarEmpleadoDniEdit(dni)
            End If
        Else
            MsgBox("No seleccionaste ninguna opción", MsgBoxStyle.Exclamation, "Advertencia")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cargarConsultar()
        cargarEditar()
    End Sub

    'Restricciones de editar empleado
    Private Sub TApellidoYNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNombres.KeyPress

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

    Public Sub verEmpleadosEditar()
        Try
            Dim ne As New NEmpleados
            Dim dt As DataTable = ne.verEmpleados()
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'busqueda diámica con dni editar
    Public Sub buscarEmpleadoDniEdit(dni As String)
        Try
            Dim de As New NEmpleados
            Dim dt As DataTable = de.buscarEmpleadoDni(dni)
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'busqueda diámica con apellido editar
    Public Sub buscarEmpleadoApellidoEdit(apellido As String)
        Try
            Dim de As New NEmpleados
            Dim dt As DataTable = de.buscarEmpleadoApellido(apellido)
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Activar los campos para editar el empleado seleccionado
    Public Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim ask As MsgBoxResult
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        ask = MsgBox("Desea Seleccionar este Empleado? " + Me.DataGridView1.Item(1, i).Value.ToString + " " + Me.DataGridView1.Item(2, i).Value.ToString, vbYesNo + vbInformation, "Seleccionar")
        If (MsgBoxResult.Yes = ask) Then
            'La variable item me permite recoger el id del cliente para hacer la edición
            item = Me.DataGridView1.Item(0, i).Value
            TApellidos.Text = Me.DataGridView1.Item(1, i).Value.ToString()
            TNombres.Text = Me.DataGridView1.Item(2, i).Value.ToString()
            DTFechaNac.Value = Me.DataGridView1.Item(4, i).Value
            TTelefono.Text = Me.DataGridView1.Item(7, i).Value.ToString()
            TDireccion.Text = Me.DataGridView1.Item(6, i).Value.ToString()
            TDni.Text = Me.DataGridView1.Item(3, i).Value.ToString()
            TCorreo.Text = Me.DataGridView1.Item(5, i).Value.ToString()
        End If

    End Sub


    'Boton para editar empleado
    Private Sub BCambios_Click(sender As Object, e As EventArgs) Handles BCambios.Click
        BRCambios.Visible = False
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        Dim ask As MsgBoxResult

        If ((TNombres.Text <> "") And
            (TApellidos.Text <> "") And
            (TDireccion.Text <> "") And
            (TDni.Text <> "") And
            (TCorreo.Text <> "") And
            (TTelefono.Text <> "")
            ) Then

            If (EmailAddressCheck(TCorreo.Text)) Then
                ask = MsgBox("Seguro desea Editar Empleado?", MsgBoxStyle.YesNo, "Confirmar")

                If ask = MsgBoxResult.Yes Then
                    'Si se ingresó un DNI distinto verifica que no exista
                    If (TDni.Text <> Me.DataGridView1.Item(3, i).Value.ToString()) Then

                        'Si no existe otro dni igual al ingresado edita
                        If (existeEmpleadoAdd(Val(TDni.Text)) = False) Then
                            editarEmpleado()
                            verEmpleados()
                            verEmpleadosEditar()

                            MsgBox("Empleado Editado", MsgBoxStyle.OkOnly, "Editado")
                            TNombres.Text = ""
                            TApellidos.Text = ""
                            TDireccion.Text = ""
                            TDni.Text = ""
                            TCorreo.Text = ""
                            TTelefono.Text = ""
                            BRCambios.Visible = True
                            BCambios.Visible = False
                            TApellidos.Enabled = False
                            TNombres.Enabled = False
                            TDireccion.Enabled = False
                            TDni.Enabled = False
                            TCorreo.Enabled = False
                            TTelefono.Enabled = False
                            DTFechaNac.Enabled = False
                        Else
                            MsgBox("Ya existe un Empleado con el dni: " + TextBox1.Text, MsgBoxStyle.Critical, "Error")
                        End If
                    Else
                        'Si no se ingresó un DNI distinto no verifica y edita sin problemas
                        editarEmpleado()
                        verEmpleados()
                        verEmpleadosEditar()
                        MsgBox("Empleado Editado", MsgBoxStyle.OkOnly, "Editado")
                        TNombres.Text = ""
                        TApellidos.Text = ""
                        TDireccion.Text = ""
                        TDni.Text = ""
                        TCorreo.Text = ""
                        TTelefono.Text = ""
                        BRCambios.Visible = True
                        BCambios.Visible = False
                        TApellidos.Enabled = False
                        TNombres.Enabled = False
                        TDireccion.Enabled = False
                        TDni.Enabled = False
                        TCorreo.Enabled = False
                        TTelefono.Enabled = False
                        DTFechaNac.Enabled = False

                    End If

                Else
                    MsgBox("No se Editó el Empleado", MsgBoxStyle.OkOnly, "No Editado")

                End If

            Else
                MessageBox.Show("Formato de correo no válido. Formato permitido ej: 'usuario@gmail.com'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If




        Else

            MsgBox("Debe completar todos los campos", MsgBoxStyle.Exclamation, "Error")

        End If
    End Sub

    'Metodo que edita un empleado
    Public Sub editarEmpleado()
        Dim nombre As String = TNombres.Text
        Dim apellido As String = TApellidos.Text
        Dim fecha_nacimiento As String = DTFechaNac.Value
        Dim dni As String = Val(TDni.Text)
        Dim direccion As String = TDireccion.Text
        Dim telefono As String = TTelefono.Text
        Dim correo As String = TCorreo.Text
        Try
            Dim cempleado As New NEmpleados()
            cempleado.editarEmpleado(dni, apellido, nombre, direccion, telefono, correo, fecha_nacimiento, item)
        Catch ex As Exception

        End Try
    End Sub



    'SECCION CONSULTAR EMPLEADOS ---------------------------------------------------------------------------------------------------------------------------------
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
                buscarEmpleadoApellido(apellido)
            End If
        ElseIf (CheckBox2.Checked And Not CheckBox1.Checked) Then
            If (dni = "") Then
                MsgBox("Completa El Campo DNI", MsgBoxStyle.Critical, "Error")
            Else
                MsgBox("Buscar por 'DNI': " + dni, MsgBoxStyle.Information, "Buscar")
                buscarEmpleadoDni(dni)
            End If
        Else
            MsgBox("No seleccionaste ninguna opción", MsgBoxStyle.Exclamation, "Advertencia")
        End If
        BLimpiarFiltros.Visible = True
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If (CheckBox2.Checked) Then
            CheckBox1.Checked = False
            TextBox3.Clear()
            TextBox3.Enabled = False
            TextBox4.Enabled = True
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

    Private Sub ChBDni_CheckedChanged(sender As Object, e As EventArgs) Handles ChBDni.CheckedChanged
        If (ChBDni.Checked) Then
            ChBApellido.Checked = False
            TextBox2.Clear()
            TextBox2.Enabled = False
            TextBox1.Enabled = True
        End If
    End Sub

    Private Sub ChBApellido_CheckedChanged(sender As Object, e As EventArgs) Handles ChBApellido.CheckedChanged
        If (ChBApellido.Checked) Then
            ChBDni.Checked = False
            TextBox1.Clear()
            TextBox1.Enabled = False
            TextBox2.Enabled = True
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("Desea volver a ingresar un nombre para agregar un empleado distinto?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmación")
        If (ask = MsgBoxResult.Yes) Then
            reiniciarAgregar()
        End If
    End Sub

    'Reinicio de valores textbox y combobox al elegir modificar el nombre del empleado.
    Public Sub reiniciarAgregar()

        Button9.Visible = False
        Panel6.Visible = False
        Button3.Visible = False
        Button2.Visible = True
        TextBox5.Clear()
        TextBox8.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        CbxSexoAdd.SelectedIndex = -1

    End Sub

    'Listar todos los empleados
    Public Sub verEmpleados()
        Try
            Dim ne As New NEmpleados
            Dim dt As DataTable = ne.verEmpleados()
            DataGridView2.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'busqueda diámica con dni consultar
    Public Sub buscarEmpleadoDni(dni As String)
        Try
            Dim de As New NEmpleados
            Dim dt As DataTable = de.buscarEmpleadoDni(dni)
            DataGridView2.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'busqueda diámica con apellido consultar
    Public Sub buscarEmpleadoApellido(apellido As String)
        Try
            Dim de As New NEmpleados
            Dim dt As DataTable = de.buscarEmpleadoApellido(apellido)
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
        End If
    End Sub



    Public Sub seleccionarEmpleadoConsultar(id As Integer)

        Try
            Dim de As New NEmpleados
            Dim dt As DataTable = de.seleccionarEmpleadoConsultar(id)

            'DataGridView2.DataSource = dt
            LApeyNom.Text = dt.Rows(0)(1).ToString + " " + dt.Rows(0)(2).ToString
            LDni2.Text = dt.Rows(0)(3).ToString
            LFechaNac2.Text = dt.Rows(0)(4).ToString
            LCorreo2.Text = dt.Rows(0)(5).ToString
            LDireccion2.Text = dt.Rows(0)(6).ToString
            LTelefono2.Text = dt.Rows(0)(7).ToString
            LEstado2.Text = dt.Rows(0)(8).ToString

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles BLimpiarFiltros.Click
        cargarConsultar()
        cargarEditar()
    End Sub

End Class