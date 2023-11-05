<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Realizar_Venta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Realizar_Venta))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.BAgregarAlCarrito = New System.Windows.Forms.Button()
        Me.TIdProd = New System.Windows.Forms.TextBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LCajero = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BRealizarVenta = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.LFecha1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.TDni = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BVaciarCarrito = New System.Windows.Forms.Button()
        Me.BBuscarProducto = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LHora = New System.Windows.Forms.Label()
        Me.LFecha = New System.Windows.Forms.Label()
        Me.LValorTotal = New System.Windows.Forms.Label()
        Me.TCodigoProd = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TPrecioProd = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TNombreProd = New System.Windows.Forms.TextBox()
        Me.PProducto = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PProducto.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.Nombre, Me.Precio, Me.Cantidad, Me.Subtotal, Me.Eliminar})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.Location = New System.Drawing.Point(12, 311)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.Size = New System.Drawing.Size(796, 236)
        Me.DataGridView1.TabIndex = 0
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        '
        'Nombre
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre.DefaultCellStyle = DataGridViewCellStyle3
        Me.Nombre.HeaderText = "Producto"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 210
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 80
        '
        'Subtotal
        '
        Me.Subtotal.HeaderText = "Subtotal"
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.ReadOnly = True
        Me.Subtotal.Width = 150
        '
        'Eliminar
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.Eliminar.DefaultCellStyle = DataGridViewCellStyle4
        Me.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Eliminar.HeaderText = "Elminar Producto"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Text = "Eliminar Producto"
        Me.Eliminar.Width = 120
        '
        'BAgregarAlCarrito
        '
        Me.BAgregarAlCarrito.BackColor = System.Drawing.Color.Honeydew
        Me.BAgregarAlCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BAgregarAlCarrito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAgregarAlCarrito.ForeColor = System.Drawing.Color.Black
        Me.BAgregarAlCarrito.Image = CType(resources.GetObject("BAgregarAlCarrito.Image"), System.Drawing.Image)
        Me.BAgregarAlCarrito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BAgregarAlCarrito.Location = New System.Drawing.Point(587, 79)
        Me.BAgregarAlCarrito.Name = "BAgregarAlCarrito"
        Me.BAgregarAlCarrito.Size = New System.Drawing.Size(166, 58)
        Me.BAgregarAlCarrito.TabIndex = 1
        Me.BAgregarAlCarrito.Text = "Agregar producto al carrito"
        Me.BAgregarAlCarrito.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BAgregarAlCarrito.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BAgregarAlCarrito.UseVisualStyleBackColor = False
        '
        'TIdProd
        '
        Me.TIdProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TIdProd.Location = New System.Drawing.Point(365, 11)
        Me.TIdProd.Name = "TIdProd"
        Me.TIdProd.Size = New System.Drawing.Size(210, 22)
        Me.TIdProd.TabIndex = 2
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(659, 12)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(93, 22)
        Me.NumericUpDown1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(583, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Cantidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(329, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "ID"
        '
        'LCajero
        '
        Me.LCajero.AutoSize = True
        Me.LCajero.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCajero.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LCajero.Location = New System.Drawing.Point(24, 14)
        Me.LCajero.Name = "LCajero"
        Me.LCajero.Size = New System.Drawing.Size(63, 18)
        Me.LCajero.TabIndex = 8
        Me.LCajero.Text = "Cajero:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(518, 571)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Total: $ "
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(182, 570)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(210, 21)
        Me.ComboBox1.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(9, 571)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(167, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Seleccionar tipo de pago"
        '
        'BRealizarVenta
        '
        Me.BRealizarVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BRealizarVenta.Image = CType(resources.GetObject("BRealizarVenta.Image"), System.Drawing.Image)
        Me.BRealizarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BRealizarVenta.Location = New System.Drawing.Point(662, 621)
        Me.BRealizarVenta.Name = "BRealizarVenta"
        Me.BRealizarVenta.Size = New System.Drawing.Size(146, 45)
        Me.BRealizarVenta.TabIndex = 19
        Me.BRealizarVenta.Text = "Realizar Venta"
        Me.BRealizarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BRealizarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BRealizarVenta.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.Proyecto2023.My.Resources.Resources.search_find_client_user_16693__1_
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(4, 17)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(161, 39)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Seleccionar Cliente"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button3.UseVisualStyleBackColor = True
        '
        'LFecha1
        '
        Me.LFecha1.AutoSize = True
        Me.LFecha1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFecha1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LFecha1.Location = New System.Drawing.Point(321, 9)
        Me.LFecha1.Name = "LFecha1"
        Me.LFecha1.Size = New System.Drawing.Size(0, 20)
        Me.LFecha1.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(185, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 15)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Nombre:"
        '
        'TNombre
        '
        Me.TNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TNombre.Location = New System.Drawing.Point(253, 25)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(250, 22)
        Me.TNombre.TabIndex = 28
        '
        'TDni
        '
        Me.TDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDni.Location = New System.Drawing.Point(563, 25)
        Me.TDni.Name = "TDni"
        Me.TDni.Size = New System.Drawing.Size(189, 22)
        Me.TDni.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(516, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 15)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "DNI:"
        '
        'BVaciarCarrito
        '
        Me.BVaciarCarrito.BackColor = System.Drawing.Color.White
        Me.BVaciarCarrito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVaciarCarrito.ForeColor = System.Drawing.Color.Red
        Me.BVaciarCarrito.Image = CType(resources.GetObject("BVaciarCarrito.Image"), System.Drawing.Image)
        Me.BVaciarCarrito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BVaciarCarrito.Location = New System.Drawing.Point(12, 621)
        Me.BVaciarCarrito.Name = "BVaciarCarrito"
        Me.BVaciarCarrito.Size = New System.Drawing.Size(138, 45)
        Me.BVaciarCarrito.TabIndex = 30
        Me.BVaciarCarrito.Text = "Vaciar Carrito"
        Me.BVaciarCarrito.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BVaciarCarrito.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BVaciarCarrito.UseVisualStyleBackColor = False
        '
        'BBuscarProducto
        '
        Me.BBuscarProducto.BackColor = System.Drawing.Color.Gainsboro
        Me.BBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BBuscarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBuscarProducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BBuscarProducto.Image = Global.Proyecto2023.My.Resources.Resources.search_good_icon_icons_com_51027__1_
        Me.BBuscarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BBuscarProducto.Location = New System.Drawing.Point(5, 42)
        Me.BBuscarProducto.Name = "BBuscarProducto"
        Me.BBuscarProducto.Size = New System.Drawing.Size(173, 47)
        Me.BBuscarProducto.TabIndex = 22
        Me.BBuscarProducto.Text = "Buscar Producto"
        Me.BBuscarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BBuscarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BBuscarProducto.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'LHora
        '
        Me.LHora.AutoSize = True
        Me.LHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LHora.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LHora.Location = New System.Drawing.Point(656, 14)
        Me.LHora.Name = "LHora"
        Me.LHora.Size = New System.Drawing.Size(50, 18)
        Me.LHora.TabIndex = 31
        Me.LHora.Text = "Hora:"
        '
        'LFecha
        '
        Me.LFecha.AutoSize = True
        Me.LFecha.BackColor = System.Drawing.Color.Transparent
        Me.LFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFecha.ForeColor = System.Drawing.SystemColors.Control
        Me.LFecha.Location = New System.Drawing.Point(309, 14)
        Me.LFecha.Name = "LFecha"
        Me.LFecha.Size = New System.Drawing.Size(54, 18)
        Me.LFecha.TabIndex = 32
        Me.LFecha.Text = "Fecha"
        '
        'LValorTotal
        '
        Me.LValorTotal.AutoSize = True
        Me.LValorTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LValorTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LValorTotal.Location = New System.Drawing.Point(610, 571)
        Me.LValorTotal.Name = "LValorTotal"
        Me.LValorTotal.Size = New System.Drawing.Size(0, 20)
        Me.LValorTotal.TabIndex = 33
        '
        'TCodigoProd
        '
        Me.TCodigoProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCodigoProd.Location = New System.Drawing.Point(365, 46)
        Me.TCodigoProd.Name = "TCodigoProd"
        Me.TCodigoProd.Size = New System.Drawing.Size(210, 22)
        Me.TCodigoProd.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(203, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(148, 16)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Código del producto"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(287, 121)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Precio $"
        '
        'TPrecioProd
        '
        Me.TPrecioProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPrecioProd.Location = New System.Drawing.Point(365, 118)
        Me.TPrecioProd.Name = "TPrecioProd"
        Me.TPrecioProd.Size = New System.Drawing.Size(210, 22)
        Me.TPrecioProd.TabIndex = 38
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(198, 86)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(153, 16)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Nombre del producto"
        '
        'TNombreProd
        '
        Me.TNombreProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TNombreProd.Location = New System.Drawing.Point(365, 83)
        Me.TNombreProd.Name = "TNombreProd"
        Me.TNombreProd.Size = New System.Drawing.Size(210, 22)
        Me.TNombreProd.TabIndex = 36
        '
        'PProducto
        '
        Me.PProducto.BackColor = System.Drawing.Color.CadetBlue
        Me.PProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PProducto.Controls.Add(Me.Label8)
        Me.PProducto.Controls.Add(Me.TPrecioProd)
        Me.PProducto.Controls.Add(Me.Label9)
        Me.PProducto.Controls.Add(Me.TNombreProd)
        Me.PProducto.Controls.Add(Me.Label6)
        Me.PProducto.Controls.Add(Me.TCodigoProd)
        Me.PProducto.Controls.Add(Me.BBuscarProducto)
        Me.PProducto.Controls.Add(Me.Label4)
        Me.PProducto.Controls.Add(Me.TIdProd)
        Me.PProducto.Controls.Add(Me.Label2)
        Me.PProducto.Controls.Add(Me.NumericUpDown1)
        Me.PProducto.Controls.Add(Me.BAgregarAlCarrito)
        Me.PProducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PProducto.Location = New System.Drawing.Point(27, 129)
        Me.PProducto.Name = "PProducto"
        Me.PProducto.Size = New System.Drawing.Size(770, 158)
        Me.PProducto.TabIndex = 40
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TNombre)
        Me.Panel1.Controls.Add(Me.TDni)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Location = New System.Drawing.Point(27, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(770, 77)
        Me.Panel1.TabIndex = 41
        '
        'Realizar_Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(820, 688)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PProducto)
        Me.Controls.Add(Me.LValorTotal)
        Me.Controls.Add(Me.LFecha)
        Me.Controls.Add(Me.LHora)
        Me.Controls.Add(Me.BVaciarCarrito)
        Me.Controls.Add(Me.LFecha1)
        Me.Controls.Add(Me.BRealizarVenta)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LCajero)
        Me.Controls.Add(Me.DataGridView1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Realizar_Venta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Realizar Venta"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PProducto.ResumeLayout(False)
        Me.PProducto.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BAgregarAlCarrito As Button
    Friend WithEvents TIdProd As TextBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LCajero As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BRealizarVenta As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents BBuscarProducto As Button
    Friend WithEvents LFecha1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TNombre As TextBox
    Friend WithEvents TDni As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents BVaciarCarrito As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LFecha As Label
    Friend WithEvents LHora As Label
    Friend WithEvents LValorTotal As Label
    Friend WithEvents TCodigoProd As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As DataGridViewButtonColumn
    Friend WithEvents Label8 As Label
    Friend WithEvents TPrecioProd As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TNombreProd As TextBox
    Friend WithEvents PProducto As Panel
    Friend WithEvents Panel1 As Panel
End Class
