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
            (ComboBox1.Text <> "")
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
                ComboBox1.Text = ""
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
            MsgBox("Cuando existan productos en el sitema aparecerán en un datagridView", MsgBoxStyle.Exclamation, "Advertencia")
        End If
    End Sub

    'Metodos Formulario Editar producto

    'Configurar busqueda en editar
    Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click
        If (CheckBox1.Checked And ChProducto.Checked And ChBCategoria.Checked) Then
            MsgBox("Seleccionaste buscar Producto por 'código', 'nombre' y 'categoria'", MsgBoxStyle.Information, "Buscar")
        ElseIf (CheckBox1.Checked And ChProducto.Checked And Not ChBCategoria.Checked) Then
            MsgBox("Seleccionaste buscar Producto por 'código' y 'nombre'", MsgBoxStyle.Information, "Buscar")
        ElseIf (CheckBox1.Checked And Not ChProducto.Checked And ChBCategoria.Checked) Then
            MsgBox("Seleccionaste buscar Producto por 'código' y 'categoria'", MsgBoxStyle.Information, "Buscar")
        ElseIf (Not CheckBox1.Checked And ChProducto.Checked And ChBCategoria.Checked) Then
            MsgBox("Seleccionaste buscar Producto por 'nombre' y 'categoria'", MsgBoxStyle.Information, "Buscar")
        ElseIf (Not CheckBox1.Checked And Not ChProducto.Checked And ChBCategoria.Checked) Then
            MsgBox("Seleccionaste buscar Producto por 'categoria'", MsgBoxStyle.Information, "Buscar")
        ElseIf (Not CheckBox1.Checked And ChProducto.Checked And Not ChBCategoria.Checked) Then
            MsgBox("Seleccionaste buscar Producto por 'nombre'", MsgBoxStyle.Information, "Buscar")
        ElseIf (CheckBox1.Checked And Not ChProducto.Checked And Not ChBCategoria.Checked) Then
            MsgBox("Seleccionaste buscar Producto por 'codigo'", MsgBoxStyle.Information, "Buscar")
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

        If ((TApellidoYNombre.Text <> "") And
            (TextBox9.Text <> "") And
            (TDni.Text <> "") And
            (TFechaNac.Text <> "") And
            (TDireccion.Text <> "") And
            (TextBox10.Text <> "") And
            (TTelefono.Text <> "") And
            (TCorreo.Text <> "")
            ) Then



            ask = MsgBox("Seguro desea editar el producto?", MsgBoxStyle.YesNo, "Confirmar Edición")

            If ask = MsgBoxResult.Yes Then
                MsgBox("Producto Editado", MsgBoxStyle.OkOnly, "Producto Editado")
                TApellidoYNombre.Text = ""
                TextBox9.Text = ""
                TDni.Text = ""
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (ChCodigo.Checked And ChNombreProducto.Checked And ChCategoria.Checked) Then
            MsgBox("Seleccionaste buscar Producto por 'código', 'nombre' y 'categoria'", MsgBoxStyle.Information, "Buscar")
        ElseIf (ChCodigo.Checked And ChNombreProducto.Checked And Not ChCategoria.Checked) Then
            MsgBox("Seleccionaste buscar Producto por 'código' y 'nombre'", MsgBoxStyle.Information, "Buscar")
        ElseIf (ChCodigo.Checked And Not ChNombreProducto.Checked And ChCategoria.Checked) Then
            MsgBox("Seleccionaste buscar Producto por 'código' y 'categoria'", MsgBoxStyle.Information, "Buscar")
        ElseIf (Not ChCodigo.Checked And ChNombreProducto.Checked And ChCategoria.Checked) Then
            MsgBox("Seleccionaste buscar Producto por 'nombre' y 'categoria'", MsgBoxStyle.Information, "Buscar")
        ElseIf (Not ChCodigo.Checked And Not ChNombreProducto.Checked And ChCategoria.Checked) Then
            MsgBox("Seleccionaste buscar Producto por 'categoria'", MsgBoxStyle.Information, "Buscar")
        ElseIf (Not ChCodigo.Checked And ChNombreProducto.Checked And Not ChCategoria.Checked) Then
            MsgBox("Seleccionaste buscar Producto por 'nombre'", MsgBoxStyle.Information, "Buscar")
        ElseIf (ChCodigo.Checked And Not ChNombreProducto.Checked And Not ChCategoria.Checked) Then
            MsgBox("Seleccionaste buscar Producto por 'codigo'", MsgBoxStyle.Information, "Buscar")
        Else
            MsgBox("No seleccionaste ninguna opción", MsgBoxStyle.Exclamation, "Advertencia")
        End If
    End Sub

End Class