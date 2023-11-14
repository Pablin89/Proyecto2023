Public Class GestionProductos
    Dim id As Integer
    Dim nombreProdEdit As String
    Dim codigoProdEdit As Integer

    'METODOS DE AGREGAR PRODUCTOS ------------------------------------------------------------------------------------------------------------------------------------------------------
    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress

        Call entradaDecimal(TextBox6, e)


    End Sub

    Public Sub entradaDecimal(sender As TextBox, e As KeyPressEventArgs)

        Dim cadena As String = sender.Text
        Dim filtro As String = "1234567890"

        If Len(cadena) > 0 Then
            filtro += "."
        End If


        For Each caracter In filtro
            If e.KeyChar = caracter Then
                e.Handled = False
                Exit For
            Else
                e.Handled = True
            End If
        Next

        If e.KeyChar = "0" And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then
            sender.Text = ""
            MessageBox.Show("solo se permiten un cero al principio", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf e.KeyChar <> "0" And e.KeyChar <> "." And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then
            sender.Text = ""
        End If





        If Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If


        If e.KeyChar = "." And Not cadena.IndexOf(".") Then
            e.Handled = True
            MessageBox.Show("ya ingresaste el punto decimal", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


    End Sub


    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress

        If (Char.IsNumber(e.KeyChar)) Then

            e.Handled = False

        ElseIf (Char.IsControl(e.KeyChar)) Then

            e.Handled = False

        Else

            e.Handled = True
            MessageBox.Show("solo se permiten numeros", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If


    End Sub

    Private Sub TextBox13_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox13.KeyPress

        If (Char.IsNumber(e.KeyChar)) Then

            e.Handled = False

        ElseIf (Char.IsControl(e.KeyChar)) Then

            e.Handled = False

        Else

            e.Handled = True
            MessageBox.Show("solo se permiten numeros", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If


    End Sub

    Private Sub TextBox12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox12.KeyPress

        If (Char.IsNumber(e.KeyChar)) Then

            e.Handled = False

        ElseIf (Char.IsControl(e.KeyChar)) Then

            e.Handled = False

        Else

            e.Handled = True
            MessageBox.Show("solo se permiten numeros", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ask As MsgBoxResult

        If ((TextBox5.Text <> "") And
            (TextBox6.Text <> "") And
            (ComboBox1.Text <> "") And
            (TextBox7.Text <> "") And
            (TextBox13.Text <> "") And
            (TextBox12.Text <> "") And
            (TDescripcion2.Text <> "") And
            (ComboBox2.Text <> "")
            ) Then



            ask = MsgBox("Seguro desea agregar producto?", MsgBoxStyle.YesNo, "Confirmar inserción")

            If ask = MsgBoxResult.Yes Then
                'Verifico de nuevo si existe el nombre del producto
                If (existeNombreProductoAdd(TextBox5.Text) = True) Then
                    MsgBox("El nombre del producto ya existe", MsgBoxStyle.Critical, "Error")
                Else
                    'Verifico si existe el código de producto
                    If (existeCodigoProductoAdd(TextBox12.Text) = True) Then
                        MsgBox("El código del producto ya existe", MsgBoxStyle.Critical, "Error")
                    Else
                        agregarProducto()
                        verProductosConsultar()
                        verProductosEditar()

                        MsgBox("Nuevo producto agregado", MsgBoxStyle.OkOnly, "Producto insertado")

                        restablecerTodo()
                    End If

                End If

            Else
                MsgBox("No se agregó el producto", MsgBoxStyle.OkOnly, "Producto no insertado")

            End If


        Else

            MsgBox("Debe completar todos los campos", MsgBoxStyle.Exclamation, "Error")

        End If

    End Sub

    Public Sub restablecerTodo()
        TCodigo.Clear()
        TNombreProd.Clear()
        'CBCateg
        ChBCategoria.Checked = False
        ChCodigo.Checked = False
        ChNombreProducto.Checked = False
        TCodigo.Enabled = False
        TNombreProd.Enabled = False

        ComboBox3.Enabled = False
        CBCateg.Enabled = False

        TCodigo.Clear()
        TNombreProd.Clear()
        'ComboBox3
        CheckBox1.Checked = False
        ChProducto.Checked = False
        ChBCategoria.Checked = False
        TextBox8.Enabled = False
        TextBox4.Enabled = False

        Panel4.Enabled = False

        Panel6.Visible = False
        Button3.Visible = False
        Button2.Visible = True
        Button9.Visible = False

        TStockEdit.Enabled = False
        DataGridView2.AllowUserToAddRows = False
        verProductosEditar()
        comboboxCategorias()
        comboboxCategoriasEditarBuscar()

        verProductosConsultar()
        comboboxCategoriasConsultarBuscar()
    End Sub

    'Busqueda de agregar producto
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (TextBox11.Text = "") Then
            MsgBox("Debe introducir un nombre para buscar", MsgBoxStyle.Exclamation, "Advertencia")
        Else

            If (existeNombreProductoAdd(TextBox11.Text) = True) Then
                MsgBox("El producto: " + TextBox11.Text + " ya existe en el sistema.", MsgBoxStyle.Information, "Buscar")
            Else
                MsgBox("Ningún producto tiene este nombre en el sistema, puede agregarlo.", MsgBoxStyle.Information, "Buscar")
                Panel6.Visible = True
                TextBox5.Text = TextBox11.Text
                TextBox5.Enabled = False
                Button3.Visible = True
                Button2.Visible = True
                TextBox11.Clear()
                Button2.Visible = False
                Button9.Visible = True
            End If
        End If
    End Sub

    Public Function existeNombreProductoAdd(nombre As String)
        Try
            Dim prod As New NProductos()
            Return prod.existeNombreProducto(nombre)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


    Public Function existeCodigoProductoAdd(codigo As Integer)
        'Dim codigo As Integer = TextBox12.Text
        Try
            Dim prod As New NProductos()
            Return prod.existeCodigoProducto(codigo)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Sub comboboxCategorias()
        Try
            Dim dc As New NCategorias
            Dim dt As DataTable = dc.verCategoriasCbx()
            ComboBox1.DataSource = dt
            ComboBox1.DisplayMember = "descripcion"
            ComboBox1.ValueMember = "id_categoria"
            ComboBox1.SelectedValue = -1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub agregarProducto()
        Dim descripcion As String = TDescripcion2.Text
        Dim nombre As String = TextBox5.Text
        Dim codigo As String = Val(TextBox12.Text)
        Dim stock As Integer = Val(TextBox7.Text)
        Dim stock_minimo As Integer = Val(TextBox13.Text)
        Dim precio As Double = Val(TextBox6.Text)

        Dim id_estado_producto As Integer
        If (ComboBox2.Text = "Activo") Then
            id_estado_producto = 1
        Else
            id_estado_producto = 0
        End If
        Dim id_categoria As Integer = Val(ComboBox1.SelectedValue.ToString)
        Try
            Dim cproducto As New NProductos()
            cproducto.insertarProducto(descripcion, nombre, codigo, stock, stock_minimo, precio, id_estado_producto, id_categoria)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'METODOS DE EDITAR PRODUCTOS ---------------------------------------------------------------------------------------------------------------

    'Configurar busqueda en editar

    Private Sub TextBox8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox8.KeyPress

        If (Char.IsNumber(e.KeyChar)) Then

            e.Handled = False

        ElseIf (Char.IsControl(e.KeyChar)) Then

            e.Handled = False

        Else

            e.Handled = True
            MessageBox.Show("solo se permiten numeros", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


    End Sub

    Public Sub comboboxCategoriasEditarBuscar()
        Try
            Dim dc As New NCategorias
            Dim dt As DataTable = dc.verCategoriasCbx()
            ComboBox3.DataSource = dt
            ComboBox3.DisplayMember = "descripcion"
            ComboBox3.ValueMember = "id_categoria"
            ComboBox3.SelectedValue = -1

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click
        Dim nombre As String
        Dim codigo As String
        Dim categoria As String
        codigo = TextBox8.Text
        nombre = TextBox4.Text
        categoria = ComboBox3.Text
        'If (CheckBox1.Checked And ChProducto.Checked And ChBCategoria.Checked) Then
        '    If (categoria = "" Or nombre = "" Or codigo = "") Then
        '        MsgBox("Completa los campos seleccionados", MsgBoxStyle.Critical, "Error")
        '    Else
        '        MsgBox("Buscar por 'codigo': " + codigo + " 'nombre': " + nombre + " y 'categoria:' " + categoria, MsgBoxStyle.Information, "Buscar")
        '    End If

        'ElseIf (Not CheckBox1.Checked And ChProducto.Checked And ChBCategoria.Checked) Then
        '    If (categoria = "" Or nombre = "") Then
        '        MsgBox("completa los capos seleccionados", MsgBoxStyle.Critical, "Error")
        '    Else
        '        MsgBox("Buscar por 'nombre': " + nombre + " y 'categoria': " + categoria, MsgBoxStyle.Information, "Buscar")
        '    End If

        'ElseIf (CheckBox1.Checked And Not ChProducto.Checked And ChBCategoria.Checked) Then
        '    If (categoria = "" Or codigo = "") Then
        '        MsgBox("completa los capos seleccionados", MsgBoxStyle.Critical, "Error")
        '    Else
        '        MsgBox("Buscar por 'codigo': " + codigo + " y 'categoria': " + categoria, MsgBoxStyle.Information, "Buscar")
        '    End If

        'ElseIf (CheckBox1.Checked And ChProducto.Checked And Not ChBCategoria.Checked) Then
        '    If (nombre = "" Or codigo = "") Then
        '        MsgBox("completa los capos seleccionados", MsgBoxStyle.Critical, "Error")
        '    Else
        '        MsgBox("Buscar por 'codigo': " + codigo + " y 'nombre': " + nombre, MsgBoxStyle.Information, "Buscar")
        '    End If

        'Else
        If (Not CheckBox1.Checked And Not ChProducto.Checked And ChBCategoria.Checked) Then
            If (categoria = "") Then
                MsgBox("elige una categoría", MsgBoxStyle.Critical, "Error")
            Else
                MsgBox("Seleccionaste buscar Producto por 'categoria': " + categoria, MsgBoxStyle.Information, "Buscar")
                'Panel4.Enabled = True
                buscarProductoCategoriaeE(categoria)
            End If

        ElseIf (Not CheckBox1.Checked And ChProducto.Checked And Not ChBCategoria.Checked) Then
            If (nombre = "") Then
                MsgBox("Completa el campo nombre", MsgBoxStyle.Critical, "Error")
            Else
                MsgBox("Seleccionaste buscar Producto por 'nombre': " + nombre, MsgBoxStyle.Information, "Buscar")
                'Panel4.Enabled = True
                buscarProductoNombreE(nombre)

            End If

        ElseIf (CheckBox1.Checked And Not ChProducto.Checked And Not ChBCategoria.Checked) Then
            If (codigo = "") Then
                MsgBox("Completa el campo codigo", MsgBoxStyle.Critical, "Error")
            Else
                MsgBox("Seleccionaste buscar Producto por 'codigo: '" + codigo, MsgBoxStyle.Information, "Buscar")
                'Panel4.Enabled = True
                buscarProductoCodigoeE(codigo)

            End If

        Else
            MsgBox("No seleccionaste ninguna opción", MsgBoxStyle.Exclamation, "Advertencia")
        End If
    End Sub

    'Listar todos los productos en el formulario editar
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        verProductosEditar()
    End Sub

    'Busqueda de producto por nombre del formulario editar
    Public Sub buscarProductoNombreE(nombre As String)
        Try
            Dim dp As New NProductos()
            Dim dt As DataTable = dp.buscarProductoNombreE(nombre)
            DataGridView2.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Busqueda de producto por codigo del formulario editar
    Public Sub buscarProductoCodigoeE(codigo As String)
        Try
            Dim dp As New NProductos()
            Dim dt As DataTable = dp.buscarProductoCodigoE(codigo)
            DataGridView2.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Busqueda de producto por categoria del formulario editar
    Public Sub buscarProductoCategoriaeE(categoria As String)
        Try
            Dim dp As New NProductos()
            Dim dt As DataTable = dp.buscarProductoCategoriaE(categoria)
            DataGridView2.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Elementos del Formulario editar
    Public Sub verProductosEditar()
        Try
            Dim dp As New NProductos
            Dim dt As DataTable = dp.verProductosEditar()
            DataGridView2.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    '
    Public Sub seleccionarProductoEditar(id As Integer)
        Try
            Dim dp As New NProductos
            Dim dt As DataTable = dp.seleccionarProductoEditar(id)


            'Asigno a nombreProdEditpara verificar si es distino y hacer el control si ya existe
            nombreProdEdit = dt.Rows(0)(1).ToString
            'Asigno a codigoProdEditpara verificar si es distino y hacer el control si ya existe
            codigoProdEdit = dt.Rows(0)(2).ToString

            TNombre.Text = dt.Rows(0)(1).ToString
            TextBox9.Text = dt.Rows(0)(2).ToString
            TDescripcion.Text = dt.Rows(0)(3).ToString
            categoriaSeleccionadaEdit(Val(dt.Rows(0)(4).ToString))
            TStockEdit.Text = dt.Rows(0)(6).ToString
            TextBox10.Text = dt.Rows(0)(7).ToString
            TPrecioEdit.Text = dt.Rows(0)(8).ToString
            estadoSeleccionadoEdit(Val(dt.Rows(0)(9).ToString))

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub categoriaSeleccionadaEdit(idcat As Integer)
        Try
            Dim dc As New NCategorias
            Dim dt As DataTable = dc.verCategoriasCbx()
            ComboBox4.DataSource = dt
            ComboBox4.DisplayMember = "descripcion"
            ComboBox4.ValueMember = "id_categoria"
            ComboBox4.SelectedValue = idcat
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub estadoSeleccionadoEdit(idestado As Integer)
        Try
            Dim de As New NEstados
            Dim dt As DataTable = de.verEstadoProductos()
            ComboBox5.DataSource = dt
            ComboBox5.DisplayMember = "descripcion"
            ComboBox5.ValueMember = "id_estado_producto"
            ComboBox5.SelectedValue = idestado
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub editarProducto()
        Dim descripcion As String = TDescripcion.Text
        Dim nombre As String = TNombre.Text
        Dim codigo As String = Val(TextBox9.Text)
        Dim stock As Integer = Val(TStockEdit.Text)
        Dim stock_minimo As Integer = Val(TextBox10.Text)
        Dim precio As Double = Val(TPrecioEdit.Text)
        Dim id_estado_producto As Integer = Val(ComboBox5.SelectedValue.ToString)
        Dim id_categoria As Integer = Val(ComboBox4.SelectedValue.ToString)
        Try
            Dim cproducto As New NProductos()
            cproducto.editarProducto(descripcion, nombre, codigo, stock, stock_minimo, precio, id_estado_producto, id_categoria, id)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

        Dim ask As MsgBoxResult
        Dim i As Integer
        i = DataGridView2.CurrentRow.Index

        ask = MsgBox("Editar el Producto '" + Me.DataGridView2.Item(2, i).Value.ToString + "' ?", MsgBoxStyle.YesNo, "Confirmar")

        If (MsgBoxResult.Yes = ask) Then

            id = Me.DataGridView2.Item(0, i).Value
            Panel4.Enabled = True

            seleccionarProductoEditar(id)
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

    Private Sub TDireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TStockEdit.KeyPress

        If (Char.IsNumber(e.KeyChar)) Then

            e.Handled = False

        ElseIf (Char.IsControl(e.KeyChar)) Then

            e.Handled = False

        Else

            e.Handled = True
            MessageBox.Show("solo se permiten numeros", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If


    End Sub

    Private Sub TextBox10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox10.KeyPress

        If (Char.IsNumber(e.KeyChar)) Then

            e.Handled = False

        ElseIf (Char.IsControl(e.KeyChar)) Then

            e.Handled = False

        Else

            e.Handled = True
            MessageBox.Show("solo se permiten numeros", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If


    End Sub

    Private Sub TTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TPrecioEdit.KeyPress

        Call entradaDecimal(TPrecioEdit, e)


    End Sub

    'Button para cancelar edición
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("Seguro desea Cancelar edición?", MsgBoxStyle.YesNo, "Cancelar Edición")

        If ask = MsgBoxResult.Yes Then
            vaciarCamposEdicion()
        End If

    End Sub

    Public Sub vaciarCamposEdicion()
        TNombre.Text = ""
        TextBox9.Text = ""
        TDescripcion.Text = ""
        ComboBox4.DataSource = Nothing
        TStockEdit.Text = ""
        TextBox10.Text = ""
        TPrecioEdit.Text = ""
        ComboBox5.DataSource = Nothing
        Panel4.Enabled = False
    End Sub

    'Button para editar
    Private Sub BCambios_Click(sender As Object, e As EventArgs) Handles BCambios.Click
        Dim ask As MsgBoxResult

        If ((TNombre.Text <> "") And
            (TextBox9.Text <> "") And
            (TDescripcion.Text <> "") And
            (TStockEdit.Text <> "") And
            (TextBox10.Text <> "") And
            (TPrecioEdit.Text <> "")
            ) Then



            ask = MsgBox("Seguro desea editar el producto?", MsgBoxStyle.YesNo, "Confirmar Edición")

            If ask = MsgBoxResult.Yes Then
                'Probar si modificamos el campo del codigo
                If (codigoProdEdit <> Val(TextBox9.Text)) Then
                    'Verifico si el código de producto ya existe
                    If (existeCodigoProductoAdd(TextBox9.Text) = True) Then
                        MsgBox("El código del producto ya existe", MsgBoxStyle.Critical, "Error")

                    Else
                        editarProducto()
                        verProductosEditar()
                        verProductosConsultar()
                        vaciarCamposEdicion()
                        MsgBox("Producto Editado", MsgBoxStyle.OkOnly, "Producto Editado")
                        restablecerTodo()
                    End If
                    'Probar si modificamos el campo nombre
                ElseIf (nombreProdEdit <> TNombre.Text) Then
                    'Verifico si el nombre de producto ya existe
                    If (existeNombreProductoAdd(TNombre.Text) = True) Then
                        MsgBox("El código del producto ya existe", MsgBoxStyle.Critical, "Error")
                    Else
                        editarProducto()
                        verProductosEditar()
                        verProductosConsultar()
                        vaciarCamposEdicion()
                        MsgBox("Producto Editado", MsgBoxStyle.OkOnly, "Producto Editado")

                    End If
                Else
                    editarProducto()
                    verProductosEditar()
                    verProductosConsultar()
                    vaciarCamposEdicion()
                    MsgBox("Producto Editado", MsgBoxStyle.OkOnly, "Producto Editado")

                End If

            Else
                MsgBox("No se Editó el producto", MsgBoxStyle.OkOnly, "Producto No Editado")

            End If


        Else

            MsgBox("Debe completar todos los campos", MsgBoxStyle.Exclamation, "Error")

        End If
    End Sub

    'METODOS DE CONSULTAR PRODUCTOS--------------------------------------------------------------------------------------------------------------
    'Elementos del Formulario editar
    Public Sub verProductosConsultar()
        Try
            Dim dp As New NProductos
            Dim dt As DataTable = dp.verProductosConsultar()
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Listar todos los productos en el formulario consultar
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        limpiarDetalles()
        verProductosConsultar()
    End Sub
    'Busqueda de producto por nombre del formulario consultar
    Public Sub buscarProductoNombreC(nombre As String)
        Try
            Dim dp As New NProductos()
            Dim dt As DataTable = dp.buscarProductoNombreC(nombre)
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Busqueda de producto por codigo del formulario consultar
    Public Sub buscarProductoCodigoC(codigo As String)
        Try
            Dim dp As New NProductos()
            Dim dt As DataTable = dp.buscarProductoCodigoC(codigo)
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Busqueda de producto por categoria del formulario consultar
    Public Sub buscarProductoCategoriaC(categoria As String)
        Try
            Dim dp As New NProductos()
            Dim dt As DataTable = dp.buscarProductoCategoriaC(categoria)
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    'Seleccionar un producto del datagrid haciendo click
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        Dim ask As MsgBoxResult
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        ask = MsgBox("Ver detalle del producto: '" + Me.DataGridView1.Item(2, i).Value.ToString + "' ?", MsgBoxStyle.YesNo, "Ver")
        If (MsgBoxResult.Yes = ask) Then
            id = Me.DataGridView1.Item(0, i).Value
            seleccionarProductoConsultar(id)
        End If
    End Sub

    Public Sub seleccionarProductoConsultar(id As Integer)
        Try
            Dim dp As New NProductos
            Dim dt As DataTable = dp.seleccionarProductoConsultar(id)

            'DataGridView2.DataSource = dt
            LRnombre.Text = dt.Rows(0)(1).ToString
            LRcodigo.Text = dt.Rows(0)(2).ToString
            LRdescripcion.Text = dt.Rows(0)(3).ToString
            LRcategoria.Text = dt.Rows(0)(4).ToString
            LRprecio.Text = dt.Rows(0)(5).ToString
            LRstock.Text = dt.Rows(0)(6).ToString
            LRstock_minimo.Text = dt.Rows(0)(7).ToString
            LRestado.Text = dt.Rows(0)(8).ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Limpiar los Labels del detalle
    Public Sub limpiarDetalles()
        LRnombre.Text = ""
        LRcodigo.Text = ""
        LRdescripcion.Text = ""
        LRcategoria.Text = ""
        LRprecio.Text = ""
        LRstock.Text = ""
        LRstock_minimo.Text = ""
        LRestado.Text = ""
    End Sub
    Private Sub TCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TCodigo.KeyPress

        If (Char.IsNumber(e.KeyChar)) Then

            e.Handled = False

        ElseIf (Char.IsControl(e.KeyChar)) Then

            e.Handled = False

        Else

            e.Handled = True
            MessageBox.Show("solo se permiten numeros", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


    End Sub

    Public Sub comboboxCategoriasConsultarBuscar()
        Try
            Dim dc As New NCategorias
            Dim dt As DataTable = dc.verCategoriasCbx()
            CBCateg.DataSource = dt
            CBCateg.DisplayMember = "descripcion"
            CBCateg.ValueMember = "id_categoria"
            CBCateg.SelectedValue = -1

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        limpiarDetalles()
        Dim nombre As String
        Dim codigo As String
        Dim categoria As String
        codigo = TCodigo.Text
        nombre = TNombreProd.Text
        categoria = CBCateg.Text
        If (ChCodigo.Checked And ChNombreProducto.Checked And ChCategoria.Checked) Then
            If (categoria = "" Or nombre = "" Or codigo = "") Then
                MsgBox("complete los campos seleccionados", MsgBoxStyle.Critical, "Error")
            Else
                MsgBox("Buscar por 'codigo': " + codigo + " 'nombre': " + nombre + " y 'categoria': " + categoria, MsgBoxStyle.Information, "Buscar")
            End If

        ElseIf (Not ChCodigo.Checked And ChNombreProducto.Checked And ChCategoria.Checked) Then
            If (categoria = "" Or nombre = "") Then
                MsgBox("complete los campos seleccionados", MsgBoxStyle.Critical, "Error")
            Else
                MsgBox("Buscar por 'nombre': " + nombre + " y 'categoria': " + categoria, MsgBoxStyle.Information, "Buscar")
            End If

        ElseIf (ChCodigo.Checked And Not ChNombreProducto.Checked And ChCategoria.Checked) Then
            If (categoria = "" Or codigo = "") Then
                MsgBox("complete los campos seleccionados", MsgBoxStyle.Critical, "Error")
            Else
                MsgBox("Buscar por 'codigo': " + codigo + " y 'categoria': " + categoria, MsgBoxStyle.Information, "Buscar")
            End If

        ElseIf (ChCodigo.Checked And ChNombreProducto.Checked And Not ChCategoria.Checked) Then
            If (codigo = "" Or nombre = "") Then
                MsgBox("Complete los campos seleccionados", MsgBoxStyle.Critical, "Error")
            Else
                MsgBox("Buscar por 'codigo': " + codigo + " y 'nombre': " + nombre, MsgBoxStyle.Information, "Buscar")
            End If

        ElseIf (Not ChCodigo.Checked And Not ChNombreProducto.Checked And ChCategoria.Checked) Then
            If (categoria = "") Then
                MsgBox("elige una categoría", MsgBoxStyle.Critical, "Error")
            Else
                MsgBox("Seleccionaste buscar Producto por 'categoria': " + categoria, MsgBoxStyle.Information, "Buscar")
                buscarProductoCategoriaC(categoria)
            End If

        ElseIf (Not ChCodigo.Checked And ChNombreProducto.Checked And Not ChCategoria.Checked) Then
            If (nombre = "") Then
                MsgBox("Campo nombre obligatorio", MsgBoxStyle.Critical, "Error")
            Else
                MsgBox("Seleccionaste buscar Producto por 'nombre': " + nombre, MsgBoxStyle.Information, "Buscar")
                buscarProductoNombreC(nombre)
            End If

        ElseIf (ChCodigo.Checked And Not ChNombreProducto.Checked And Not ChCategoria.Checked) Then
            If (codigo = "") Then
                MsgBox("Campo código obligatorio", MsgBoxStyle.Critical, "Error")
            Else
                MsgBox("Seleccionaste buscar Producto por 'codigo': " + codigo, MsgBoxStyle.Information, "Buscar")
                buscarProductoCodigoC(codigo)
            End If

        ElseIf CheckBox2.Checked Then
            buscarProductosPocoStock()

        Else
            MsgBox("No seleccionaste ninguna opción", MsgBoxStyle.Exclamation, "Advertencia")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AgregarStock.ShowDialog()
        'seleccionarProductoEditar(id)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Categoría.ShowDialog()
    End Sub

    Private Sub GestionProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TCodigo.Clear()
        TNombreProd.Clear()
        'CBCateg
        ChBCategoria.Checked = False
        ChCodigo.Checked = False
        ChNombreProducto.Checked = False
        TCodigo.Enabled = False
        TNombreProd.Enabled = False

        ComboBox3.Enabled = False
        CBCateg.Enabled = False

        TCodigo.Clear()
        TNombreProd.Clear()
        'ComboBox3
        CheckBox1.Checked = False
        ChProducto.Checked = False
        ChBCategoria.Checked = False
        TextBox8.Enabled = False
        TextBox4.Enabled = False

        Panel4.Enabled = False

        Panel6.Visible = False
        Button3.Visible = False
        Button2.Visible = True
        Button9.Visible = False

        TStockEdit.Enabled = False
        DataGridView2.AllowUserToAddRows = False
        verProductosEditar()
        comboboxCategorias()
        comboboxCategoriasEditarBuscar()

        verProductosConsultar()
        comboboxCategoriasConsultarBuscar()
    End Sub

    Private Sub ChCodigo_CheckedChanged(sender As Object, e As EventArgs) Handles ChCodigo.CheckedChanged
        If (ChCodigo.Checked) Then
            ChNombreProducto.Checked = False
            ChCategoria.Checked = False
            TNombreProd.Clear()
            TCodigo.Enabled = True
            TNombreProd.Enabled = False
            CBCateg.Enabled = False
            CBCateg.SelectedValue = -1
            CheckBox2.Checked = False
        End If
    End Sub

    Private Sub ChNombreProducto_CheckedChanged(sender As Object, e As EventArgs) Handles ChNombreProducto.CheckedChanged
        If (ChNombreProducto.Checked) Then
            TCodigo.Clear()
            ChCodigo.Checked = False
            ChCategoria.Checked = False
            TNombreProd.Enabled = True
            TCodigo.Enabled = False
            CBCateg.Enabled = False
            CBCateg.SelectedValue = -1
            CheckBox2.Checked = False
        End If
    End Sub

    Private Sub ChCategoria_CheckedChanged(sender As Object, e As EventArgs) Handles ChCategoria.CheckedChanged
        If (ChCategoria.Checked) Then
            TCodigo.Clear()
            ChCodigo.Checked = False
            ChNombreProducto.Checked = False
            TNombreProd.Clear()
            TCodigo.Enabled = False
            TNombreProd.Enabled = False
            CBCateg.Enabled = True
            CheckBox2.Checked = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked) Then
            TextBox4.Clear()
            ChProducto.Checked = False
            ChBCategoria.Checked = False
            TextBox8.Enabled = True
            TextBox4.Enabled = False
            ComboBox3.Enabled = False
            ComboBox3.SelectedValue = -1
        End If
    End Sub

    Private Sub ChProducto_CheckedChanged(sender As Object, e As EventArgs) Handles ChProducto.CheckedChanged
        If (ChProducto.Checked) Then
            TextBox8.Clear()
            CheckBox1.Checked = False
            ChBCategoria.Checked = False
            TextBox4.Enabled = True
            TextBox8.Enabled = False
            ComboBox3.Enabled = False
            ComboBox3.SelectedValue = -1
        End If
    End Sub

    Private Sub ChBCategoria_CheckedChanged(sender As Object, e As EventArgs) Handles ChBCategoria.CheckedChanged
        If (ChBCategoria.Checked) Then
            TextBox8.Clear()
            TextBox4.Clear()
            ComboBox3.Enabled = True
            CheckBox1.Checked = False
            ChProducto.Checked = False
            TextBox4.Enabled = False
            TextBox8.Enabled = False
        End If
    End Sub


    Public Sub reiniciarAgregar()

        Button9.Visible = False
        Panel6.Visible = False
        Button3.Visible = False
        Button2.Visible = True
        TextBox5.Clear()
        TextBox12.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox13.Clear()
        TDescripcion2.Clear()
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1


    End Sub


    Public Sub buscarProductosPocoStock()
        Try
            Dim dp As New NProductos
            Dim dt As DataTable = dp.verProductosPocoStock()
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("Desea volver a ingresar un nombre para agregar un producto distinto?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmación")
        If (ask = MsgBoxResult.Yes) Then
            reiniciarAgregar()
        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If (CheckBox2.Checked) Then
            TCodigo.Clear()
            TNombreProd.Clear()
            ChCodigo.Checked = False
            ChCategoria.Checked = False
            ChNombreProducto.Checked = False
            TNombreProd.Enabled = False
            TCodigo.Enabled = False
            CBCateg.Enabled = False
            CBCateg.SelectedValue = -1
        End If

    End Sub
End Class