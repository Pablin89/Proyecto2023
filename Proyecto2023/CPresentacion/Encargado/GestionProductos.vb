Public Class GestionProductos

    'Metodos para agregar producto
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
                MsgBox("Nuevo producto agregado", MsgBoxStyle.OkOnly, "Producto insertado")
                TextBox5.Text = ""
                TextBox6.Text = ""
                ComboBox1.Text = ""
                TextBox7.Text = ""
                TextBox13.Text = ""
                TextBox12.Text = ""
                TDescripcion2.Text = ""
                ComboBox2.Text = ""
            Else
                MsgBox("No se agregó el producto", MsgBoxStyle.OkOnly, "Producto no insertado")

            End If


        Else

            MsgBox("Debe completar todos los campos", MsgBoxStyle.Exclamation, "Error")

        End If

    End Sub

    'Busqueda de agregar producto
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (TextBox11.Text = "") Then
            MsgBox("Debe introducir un nombre para buscar", MsgBoxStyle.Exclamation, "Advertencia")
        Else

            If (existeNombreProductoA() = True) Then
                MsgBox("El producto: " + TextBox11.Text + " ya existe en el sistema.", MsgBoxStyle.Information, "Buscar")
            Else
                MsgBox("Ningún producto tiene este nombre en el sistema, puede agregarlo.", MsgBoxStyle.Information, "Buscar")
                Panel6.Visible = True
                TextBox5.Text = TextBox11.Text
                Button3.Visible = True
                Button2.Visible = True
                TextBox11.Clear()
            End If
        End If
    End Sub

    Public Function existeNombreProductoA()
        Dim nombre As String = TextBox11.Text
        Try
            Dim prod As New NProductos()
            Return prod.existeNombreProducto(nombre)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function existeCodigoProductoA()
        Dim codigo As Integer = TextBox12.Text
        Try
            Dim prod As New NProductos()
            Return prod.existeCodigoProducto(codigo)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    'Metodos Formulario Editar producto

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
                Panel4.Enabled = True
            End If

        ElseIf (Not CheckBox1.Checked And ChProducto.Checked And Not ChBCategoria.Checked) Then
                If (nombre = "") Then
                    MsgBox("Completa el campo nombre", MsgBoxStyle.Critical, "Error")
                Else
                    MsgBox("Seleccionaste buscar Producto por 'nombre': " + nombre, MsgBoxStyle.Information, "Buscar")
                Panel4.Enabled = True
            End If

        ElseIf (CheckBox1.Checked And Not ChProducto.Checked And Not ChBCategoria.Checked) Then
                If (codigo = "") Then
                    MsgBox("Completa el campo codigo", MsgBoxStyle.Critical, "Error")
                Else
                    MsgBox("Seleccionaste buscar Producto por 'codigo: '" + codigo, MsgBoxStyle.Information, "Buscar")
                Panel4.Enabled = True
            End If

        Else
                MsgBox("No seleccionaste ninguna opción", MsgBoxStyle.Exclamation, "Advertencia")
        End If
    End Sub

    'Elementos del Formulario editar

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

    Private Sub TDireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDireccion.KeyPress

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

    Private Sub TTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TTelefono.KeyPress

        Call entradaDecimal(TTelefono, e)


    End Sub

    Private Sub BCambios_Click(sender As Object, e As EventArgs) Handles BCambios.Click
        Dim ask As MsgBoxResult

        If ((TNombre.Text <> "") And
            (TextBox9.Text <> "") And
            (TDescripcion.Text <> "") And
            (TFechaNac.Text <> "") And
            (TDireccion.Text <> "") And
            (TextBox10.Text <> "") And
            (TTelefono.Text <> "") And
            (TCorreo.Text <> "")
            ) Then



            ask = MsgBox("Seguro desea editar el producto?", MsgBoxStyle.YesNo, "Confirmar Edición")

            If ask = MsgBoxResult.Yes Then
                MsgBox("Producto Editado", MsgBoxStyle.OkOnly, "Producto Editado")
                TNombre.Text = ""
                TextBox9.Text = ""
                TDescripcion.Text = ""
                TFechaNac.Text = ""
                TDireccion.Text = ""
                TextBox10.Text = ""
                TTelefono.Text = ""
                TCorreo.Text = ""
            Else
                MsgBox("No se Editó el producto", MsgBoxStyle.OkOnly, "Producto No Editado")

            End If


        Else

            MsgBox("Debe completar todos los campos", MsgBoxStyle.Exclamation, "Error")

        End If
    End Sub

    'Metodos de Consultar productos

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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
            End If

        ElseIf (Not ChCodigo.Checked And ChNombreProducto.Checked And Not ChCategoria.Checked) Then
            If (nombre = "") Then
                MsgBox("Campo nombre obligatorio", MsgBoxStyle.Critical, "Error")
            Else
                MsgBox("Seleccionaste buscar Producto por 'nombre': " + nombre, MsgBoxStyle.Information, "Buscar")
            End If

        ElseIf (ChCodigo.Checked And Not ChNombreProducto.Checked And Not ChCategoria.Checked) Then
            If (codigo = "") Then
                MsgBox("Campo código obligatorio", MsgBoxStyle.Critical, "Error")
            Else
                MsgBox("Seleccionaste buscar Producto por 'codigo': " + codigo, MsgBoxStyle.Information, "Buscar")
            End If

        Else
            MsgBox("No seleccionaste ninguna opción", MsgBoxStyle.Exclamation, "Advertencia")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AgregarStock.ShowDialog()
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

    End Sub

    Private Sub ChCodigo_CheckedChanged(sender As Object, e As EventArgs) Handles ChCodigo.CheckedChanged
        If (ChCodigo.Checked) Then
            ChNombreProducto.Checked = False
            ChCategoria.Checked = False
            TNombreProd.Clear()
            TCodigo.Enabled = True
            TNombreProd.Enabled = False
            CBCateg.Enabled = False
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

End Class