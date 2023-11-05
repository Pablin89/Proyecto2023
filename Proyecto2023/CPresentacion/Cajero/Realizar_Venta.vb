Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Realizar_Venta
    'con la variable stock voy a obtener el stock de cada producto para hacer el control
    Public stock As Integer
    'Variables para recoger los id
    Public idCliente As Integer
    'Variable idVenta recoge el último id para hacer el detalle
    Public idVenta As Integer
    'Variable idUsuario recoge el id del cajero que hace la venta
    Public idUsuario As Integer

    'Restricciones
    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNombre.KeyPress

        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("solo se permiten letras", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDni.KeyPress

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
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Baja_Clientes.ShowDialog()
        If TNombre.Text <> "" Then
            BAgregarAlCarrito.Enabled = True
            BBuscarProducto.Enabled = True

        End If
    End Sub

    Private Sub BBuscarProducto_Click(sender As Object, e As EventArgs) Handles BBuscarProducto.Click
        Seleccionar_Producto.ShowDialog()
        If TIdProd.Text <> "" Then
            NumericUpDown1.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LFecha.Text = DateAndTime.Today.ToLongDateString
        LHora.Text = DateAndTime.TimeOfDay
    End Sub

    Private Sub Realizar_Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TNombre.Enabled = False
        TDni.Enabled = False
        TIdProd.Enabled = False
        TCodigoProd.Enabled = False
        TNombreProd.Enabled = False
        TPrecioProd.Enabled = False
        NumericUpDown1.Enabled = False
        BAgregarAlCarrito.Enabled = False
        BBuscarProducto.Enabled = False
        Timer1.Start()
        DataGridView1.AllowUserToAddRows = False
        LValorTotal.Text = "0"

        listarTiposPagoCbx()
    End Sub

    'listar tipos de pago 
    Public Sub listarTiposPagoCbx()
        Try
            Dim dp As New NTiposPagos
            Dim dt As DataTable = dp.verTipoPagosCbx()
            ComboBox1.DataSource = dt
            ComboBox1.DisplayMember = "descripcion"
            ComboBox1.ValueMember = "id_tipo_pago"
            ComboBox1.SelectedValue = -1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub




    'Eliminar elemento
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim col As Integer = DataGridView1.CurrentCell.ColumnIndex
        Dim opcion As MsgBoxResult
        Dim i = DataGridView1.CurrentRow.Index

        If (col = 5) Then
            opcion = MsgBox("Esta seguro que desea eliminar " + DataGridView1.Item(1, i).Value.ToString + " de la compra?", vbYesNo + vbDefaultButton2 + vbCritical, "Eliminar")
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
            reinicarVenta()
            calcularTotal()
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
        Dim precio As Integer = Val(TPrecioProd.Text)



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
                If DataGridView1.Item(1, j).Value = TNombreProd.Text() Then
                    'controlo el stock
                    If (DataGridView1.Item(3, j).Value + NumericUpDown1.Value > stock) Then
                        MsgBox("Cantidad mayor a " + stock.ToString + " que quedan en stock")
                        carga = True
                    Else
                        'cuando cargamos un producto se activa la carga
                        carga = True
                        nombreExistente = DataGridView1.Item(2, j).Value.ToString
                        nuevaCantidad = DataGridView1.Item(3, j).Value + NumericUpDown1.Value
                        nuevoSubtotal = nuevaCantidad * precio

                        DataGridView1.Item(3, j).Value = nuevaCantidad
                        DataGridView1.Item(4, j).Value = nuevoSubtotal
                        calcularTotal()
                        MsgBox(NumericUpDown1.Text + " unidades del producto '" + TNombreProd.Text + "' fueron agregados", vbOKOnly + vbInformation, "Producto")
                    End If

                End If
            Next
            DataGridView1.ClearSelection()
        End If




        If (TNombreProd.Text = "" Or NumericUpDown1.Text = 0) Then
            MsgBox("Debe seleccionar un producto o agregar stock", MsgBoxStyle.Critical, "Atención")
        Else
            'Variable cantidad para verificar el stock
            Dim cantidad As Integer
            For j = 0 To (DataGridView1.Rows.Count - 1)
                If DataGridView1.Item(1, j).Value <> TNombreProd.Text() Then
                    cantidad = NumericUpDown1.Value
                    NumericUpDown1.Value = cantidad
                End If
            Next
            cantidad = NumericUpDown1.Value
            If (carga = False) Then
                'Si la cantidad es mayor que el stock disponible no me permite agregar
                If (cantidad > stock) Then
                    'MsgBox("Stock > " + stock.ToString)
                    MsgBox("Cantidad > a " + stock.ToString + " que quedan en stock")
                    DataGridView1.ClearSelection()

                Else

                    ask = MsgBox("Desea agregar el producto?", vbYesNo + vbInformation, "Agregar Producto")

                    If (MsgBoxResult.Yes = ask) Then

                        DataGridView1.Rows.Add(TIdProd.Text, TNombreProd.Text, precio, NumericUpDown1.Text, precio * NumericUpDown1.Text, "Eliminar")
                        MsgBox(NumericUpDown1.Text + " unidades del producto '" + TNombreProd.Text + "' fueron agregados", vbOKOnly + vbInformation, "Producto")
                        calcularTotal()

                    End If

                End If
            End If

        End If






    End Sub

    Public Sub calcularTotal()
        'CALCULAR EL TOTAL
        LValorTotal.Text = "0"
        If DataGridView1.Rows.Count > 0 Then
            For j = 0 To (DataGridView1.Rows.Count - 1)
                LValorTotal.Text += Val(DataGridView1.Item(4, j).Value)
            Next
        End If
    End Sub



    Public Sub reinicarVenta()
        NumericUpDown1.Text = 0
        TIdProd.Text = ""
        TNombreProd.Text = ""
        TCodigoProd.Text = ""
        TPrecioProd.Text = ""
        ComboBox1.Text = ""
        TNombre.Text = ""
        TDni.Text = ""
        LValorTotal.Text = "0"
        NumericUpDown1.Enabled = False
        BAgregarAlCarrito.Enabled = False
        BBuscarProducto.Enabled = False
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
                    nuevaVenta()
                    agregarDetalles()
                    MsgBox("GRACIAS POR SU COMPRA!!!", MsgBoxStyle.Information, "GRACIAS")
                    VentaRealizada.ShowDialog()
                    listarTiposPagoCbx()
                    vaciarCarrito()
                    reinicarVenta()
                End If
            End If
        End If
    End Sub

    'Metodos dinámicos para la venta----------------------------------------------------------------
    'insertar una venta 
    Public Sub nuevaVenta()
        Dim id_cliente As Integer = idCliente
        'Se modificará cuando existan inicios de seión id_usuario 
        Dim id_usuario As Integer = idUsuario
        Dim total As Double = Val(LValorTotal.Text)
        Dim fecha_compra As Date = Today
        Dim id_tipo_pago As Integer = Val(ComboBox1.SelectedValue.ToString)
        Try
            Dim cventa As New NVentas()
            cventa.insertarVenta(id_cliente, id_usuario, total, fecha_compra, id_tipo_pago)
            ultimoId()
            actualizarStock()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Recoger el ultimo id_venta y asignar a idVenta
    Public Sub ultimoId()
        Try
            Dim vt As New NVentas
            Dim dt As DataTable = vt.ultimoId()
            idVenta = Val(dt.Rows(0)(0).ToString)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'actualiza los stocks de los productos seleccionados
    Public Sub actualizarStock()
        For j = 0 To (DataGridView1.Rows.Count - 1)
            'Selecciono los productos para poder recuperar el stock actual de cada uno
            Seleccionar_Producto.seleccionarProductoCajero(DataGridView1.Item(0, j).Value)
            'Descuenta los valores del stock actual y los guarda en nuevo_stock
            Dim nuevo_stock As Integer = stock - DataGridView1.Item(3, j).Value
            Try
                Dim cproducto As New NProductos()
                'envio el id del producto y el nuevo stock para hacer la actualización
                cproducto.actualizarStock(DataGridView1.Item(0, j).Value, nuevo_stock)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next
    End Sub

    'insertar los detalles de la venta
    Public Sub agregarDetalles()
        Dim id_venta_detalle As Integer = DataGridView1.CurrentRow.Index
        Dim id_venta As Integer
        Dim id_Producto As Integer
        Dim cantidad As Integer
        Dim precio As Double
        For j = 0 To (DataGridView1.Rows.Count - 1)

            id_venta = idVenta
            id_venta_detalle = id_venta_detalle + 1
            id_Producto = DataGridView1.Item(0, j).Value
            cantidad = DataGridView1.Item(3, j).Value
            precio = DataGridView1.Item(2, j).Value
            Try
                Dim cdetalle As New NDetalles
                cdetalle.insertarDetalle(id_venta, id_venta_detalle, id_Producto, cantidad, precio)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next
    End Sub
    'Fin Metodos dinámicos para la venta----------------------------------------------------------------
    Private Sub Realizar_Venta_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        reinicarVenta()
        If (DataGridView1.Rows.Count > 0) Then
            For Each Fila As DataGridViewRow In DataGridView1.Rows
                DataGridView1.Rows.Clear()
                'DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
            Next
        End If
    End Sub


End Class