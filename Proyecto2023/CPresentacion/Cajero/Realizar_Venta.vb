Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Realizar_Venta

    'Restricciones
    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress

        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("solo se permiten letras", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress

        If (Char.IsNumber(e.KeyChar)) Then
            e.Handled = False
            TextBox6.MaxLength = 8

            If (TextBox6.Text.Length > 7) Then
                MessageBox.Show("El DNI tiene un máximo de 8 digitos", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        ElseIf (Char.IsControl(e.KeyChar)) Then

            e.Handled = False

        Else

            e.Handled = True
            MessageBox.Show("solo se permiten numeros", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If


    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Baja_Clientes.ShowDialog()
    End Sub

    Private Sub BBuscarProducto_Click(sender As Object, e As EventArgs) Handles BBuscarProducto.Click
        Seleccionar_Producto.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LFecha.Text = DateAndTime.Today.ToLongDateString
        LHora.Text = DateAndTime.TimeOfDay
    End Sub

    Private Sub Realizar_Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        DataGridView1.AllowUserToAddRows = False
        LValorTotal.Text = "0"
    End Sub


    'Eliminar elemento
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim col As Integer = DataGridView1.CurrentCell.ColumnIndex
        Dim opcion As MsgBoxResult
        Dim i = DataGridView1.CurrentRow.Index

        If (col = 4) Then
            opcion = MsgBox("Esta seguro que desea eliminar " + DataGridView1.Item(0, i).Value.ToString + " de la compra?", vbYesNo + vbDefaultButton2 + vbCritical, "Eliminar")
            If (opcion = DialogResult.Yes) Then
                DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
                calcularTotal()
            End If
        End If
    End Sub

    'vaciar carrito
    Private Sub BVaciarCarrito_Click(sender As Object, e As EventArgs) Handles BVaciarCarrito.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("Desea cancelar la compra y vaciar el carrito?", vbYesNo + vbInformation, "Vaciar Carrito")

        If (MsgBoxResult.Yes = ask) Then
            vaciarCarrito()
            calcularTotal()
            vaciartextoCarrito()
        End If

    End Sub

    Public Sub vaciarCarrito()

        If (DataGridView1.Rows.Count > 0) Then
            For Each Fila As DataGridViewRow In DataGridView1.Rows
                DataGridView1.Rows.Clear()
                'DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
            Next
        Else
            MsgBox(" El carrito se encuentra vacío.", vbOKOnly + vbCritical, "Vaciar Carrito")
        End If



    End Sub

    Private Sub BAgregarAlCarrito_Click(sender As Object, e As EventArgs) Handles BAgregarAlCarrito.Click
        Dim precio As Integer = 500

        Select Case TextBox1.Text
            Case "Bombilla"
                precio = 300
            Case "bombilla"
                precio = 300
            Case "vaso"
                precio = 400
            Case "Vaso"
                precio = 400
            Case "Ropa"
                precio = 800
            Case "ropa"
                precio = 800
            Case Else
                precio = 500
        End Select


        Dim ask As MsgBoxResult
        Dim j As Integer
        Dim carga As Boolean = False
        'Para comprobar la existencia del producto
        Dim nombreExistente As String
        Dim nuevaCantidad As String
        Dim nuevoSubtotal As String


        'SI EL PRODUCTO EXISTE SE ACTUALIZA LA CANTIDAD Y EL SUBTOTAL
        If DataGridView1.Rows.Count > 0 Then
            For j = 0 To (DataGridView1.Rows.Count - 1)
                If DataGridView1.Item(0, j).Value = TextBox1.Text() Then
                    'cuando cargamos un producto se activa la carga
                    carga = True
                    nombreExistente = DataGridView1.Item(0, j).Value.ToString
                    nuevaCantidad = DataGridView1.Item(2, j).Value + NumericUpDown1.Value
                    nuevoSubtotal = nuevaCantidad * precio

                    DataGridView1.Item(2, j).Value = nuevaCantidad
                    DataGridView1.Item(3, j).Value = nuevoSubtotal

                End If
            Next
            DataGridView1.ClearSelection()
        End If



        If (carga = False) Then
            ask = MsgBox("Desea agregar el producto?", vbYesNo + vbInformation, "Agregar Producto")

            If (MsgBoxResult.Yes = ask And TextBox1.Text <> "" And NumericUpDown1.Text <> 0) Then

                DataGridView1.Rows.Add(TextBox1.Text(), precio, NumericUpDown1.Text, precio * NumericUpDown1.Text, "Eliminar")
                calcularTotal()
            Else
                MsgBox("Debe seleccionar un producto", MsgBoxStyle.Critical, "Atención")
            End If
        Else
            MsgBox("Sumamos " + NumericUpDown1.Text + " unidades más al producto '" + TextBox1.Text + "'", vbOKOnly + vbCritical, "Producto")
            calcularTotal()
        End If

    End Sub

    Public Sub calcularTotal()
        'CALCULAR EL TOTAL
        LValorTotal.Text = "0"
        If DataGridView1.Rows.Count > 0 Then
            For j = 0 To (DataGridView1.Rows.Count - 1)
                LValorTotal.Text += Val(DataGridView1.Item(3, j).Value)
            Next
        End If
    End Sub

    Public Sub vaciarTexto()
        NumericUpDown1.Text = 0
        TextBox1.Text = ""
        ComboBox1.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        LValorTotal.Text = "0"
    End Sub

    Public Sub vaciartextoCarrito()
        NumericUpDown1.Text = 0
        TextBox1.Text = ""
        ComboBox1.Text = ""
        LValorTotal.Text = "0"
    End Sub

    Private Sub BRealizarVenta_Click(sender As Object, e As EventArgs) Handles BRealizarVenta.Click
        Dim ask As MsgBoxResult
        If (DataGridView1.RowCount.ToString() = 0) Then
            MsgBox("Agrega algún producto a la compra", MsgBoxStyle.Critical, "Atención")
        Else
            If (ComboBox1.Text = "") Then
                MsgBox("Selecciona  tipo de pago", MsgBoxStyle.Critical, "Atención")
            Else
                ask = MsgBox("Confirmar compra?", vbYesNo + vbInformation, "Confirmar")
                If (MsgBoxResult.Yes = ask) Then
                    MsgBox("GRACIAS POR SU COMPRA!!!", MsgBoxStyle.Information, "GRACIAS")
                    vaciartextoCarrito()
                    vaciarTexto()
                End If
            End If
        End If
    End Sub

End Class