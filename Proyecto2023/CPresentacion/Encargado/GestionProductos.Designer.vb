<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionProductos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionProductos))
        Me.GestionarProductos = New System.Windows.Forms.TabControl()
        Me.ConsultarProductos = New System.Windows.Forms.TabPage()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBCateg = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TCodigo = New System.Windows.Forms.TextBox()
        Me.ChCodigo = New System.Windows.Forms.CheckBox()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.ChCategoria = New System.Windows.Forms.CheckBox()
        Me.TNombreProd = New System.Windows.Forms.TextBox()
        Me.ChNombreProducto = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LRestado = New System.Windows.Forms.Label()
        Me.LRstock_minimo = New System.Windows.Forms.Label()
        Me.LRstock = New System.Windows.Forms.Label()
        Me.LRprecio = New System.Windows.Forms.Label()
        Me.LRcategoria = New System.Windows.Forms.Label()
        Me.LRdescripcion = New System.Windows.Forms.Label()
        Me.LRcodigo = New System.Windows.Forms.Label()
        Me.LRnombre = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LStockMinimo = New System.Windows.Forms.Label()
        Me.LCodigo = New System.Windows.Forms.Label()
        Me.LEstado = New System.Windows.Forms.Label()
        Me.LCategoria = New System.Windows.Forms.Label()
        Me.LStock = New System.Windows.Forms.Label()
        Me.LPrecio = New System.Windows.Forms.Label()
        Me.LDescripcion = New System.Windows.Forms.Label()
        Me.LNombrepro = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EditarProductos = New System.Windows.Forms.TabPage()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.LStockMinimo1 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.LCódigo1 = New System.Windows.Forms.Label()
        Me.BCambios = New System.Windows.Forms.Button()
        Me.TPrecioEdit = New System.Windows.Forms.TextBox()
        Me.TStockEdit = New System.Windows.Forms.TextBox()
        Me.TDescripcion = New System.Windows.Forms.TextBox()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.LEstado1 = New System.Windows.Forms.Label()
        Me.LPrecio1 = New System.Windows.Forms.Label()
        Me.LStock1 = New System.Windows.Forms.Label()
        Me.LCtaegoria1 = New System.Windows.Forms.Label()
        Me.LDescripcion1 = New System.Windows.Forms.Label()
        Me.LNombreProducto = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ChBCategoria = New System.Windows.Forms.CheckBox()
        Me.ChProducto = New System.Windows.Forms.CheckBox()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.AgregarProductos = New System.Windows.Forms.TabPage()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.LBuscarProducto = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.LStockMinimo2 = New System.Windows.Forms.Label()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.LCódigo2 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TDescripcion2 = New System.Windows.Forms.TextBox()
        Me.LEstadoInicial = New System.Windows.Forms.Label()
        Me.LDescripcion2 = New System.Windows.Forms.Label()
        Me.LStockInicial = New System.Windows.Forms.Label()
        Me.LCategoria2 = New System.Windows.Forms.Label()
        Me.LPrecio2 = New System.Windows.Forms.Label()
        Me.LNombre2 = New System.Windows.Forms.Label()
        Me.GestionarProductos.SuspendLayout()
        Me.ConsultarProductos.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EditarProductos.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AgregarProductos.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GestionarProductos
        '
        Me.GestionarProductos.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.GestionarProductos.Controls.Add(Me.ConsultarProductos)
        Me.GestionarProductos.Controls.Add(Me.EditarProductos)
        Me.GestionarProductos.Controls.Add(Me.AgregarProductos)
        Me.GestionarProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GestionarProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GestionarProductos.ItemSize = New System.Drawing.Size(180, 24)
        Me.GestionarProductos.Location = New System.Drawing.Point(0, 0)
        Me.GestionarProductos.Multiline = True
        Me.GestionarProductos.Name = "GestionarProductos"
        Me.GestionarProductos.SelectedIndex = 0
        Me.GestionarProductos.Size = New System.Drawing.Size(843, 636)
        Me.GestionarProductos.TabIndex = 0
        '
        'ConsultarProductos
        '
        Me.ConsultarProductos.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ConsultarProductos.Controls.Add(Me.Button8)
        Me.ConsultarProductos.Controls.Add(Me.Label2)
        Me.ConsultarProductos.Controls.Add(Me.CBCateg)
        Me.ConsultarProductos.Controls.Add(Me.Button1)
        Me.ConsultarProductos.Controls.Add(Me.TCodigo)
        Me.ConsultarProductos.Controls.Add(Me.ChCodigo)
        Me.ConsultarProductos.Controls.Add(Me.LTitulo)
        Me.ConsultarProductos.Controls.Add(Me.ChCategoria)
        Me.ConsultarProductos.Controls.Add(Me.TNombreProd)
        Me.ConsultarProductos.Controls.Add(Me.ChNombreProducto)
        Me.ConsultarProductos.Controls.Add(Me.Panel1)
        Me.ConsultarProductos.Location = New System.Drawing.Point(4, 28)
        Me.ConsultarProductos.Name = "ConsultarProductos"
        Me.ConsultarProductos.Padding = New System.Windows.Forms.Padding(3)
        Me.ConsultarProductos.Size = New System.Drawing.Size(835, 604)
        Me.ConsultarProductos.TabIndex = 0
        Me.ConsultarProductos.Text = "Consultar Productos"
        '
        'Button8
        '
        Me.Button8.Image = Global.Proyecto2023.My.Resources.Resources.search_good_icon_icons_com_51027__1_
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(239, 182)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(167, 37)
        Me.Button8.TabIndex = 15
        Me.Button8.Text = "Listar Todos"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(290, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Click sobre el producto para ver detalles"
        '
        'CBCateg
        '
        Me.CBCateg.FormattingEnabled = True
        Me.CBCateg.Location = New System.Drawing.Point(374, 143)
        Me.CBCateg.Name = "CBCateg"
        Me.CBCateg.Size = New System.Drawing.Size(225, 24)
        Me.CBCateg.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Image = Global.Proyecto2023.My.Resources.Resources.search_good_icon_icons_com_51027__1_
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(422, 182)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(177, 37)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Buscar Producto"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TCodigo
        '
        Me.TCodigo.Location = New System.Drawing.Point(374, 55)
        Me.TCodigo.Name = "TCodigo"
        Me.TCodigo.Size = New System.Drawing.Size(225, 22)
        Me.TCodigo.TabIndex = 10
        '
        'ChCodigo
        '
        Me.ChCodigo.AutoSize = True
        Me.ChCodigo.Location = New System.Drawing.Point(194, 57)
        Me.ChCodigo.Name = "ChCodigo"
        Me.ChCodigo.Size = New System.Drawing.Size(169, 20)
        Me.ChCodigo.TabIndex = 9
        Me.ChCodigo.Text = "Código del Producto"
        Me.ChCodigo.UseVisualStyleBackColor = True
        '
        'LTitulo
        '
        Me.LTitulo.AutoSize = True
        Me.LTitulo.Location = New System.Drawing.Point(263, 17)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(240, 16)
        Me.LTitulo.TabIndex = 8
        Me.LTitulo.Text = "Seleccionar un filtro de búsqueda"
        '
        'ChCategoria
        '
        Me.ChCategoria.AutoSize = True
        Me.ChCategoria.Location = New System.Drawing.Point(194, 143)
        Me.ChCategoria.Name = "ChCategoria"
        Me.ChCategoria.Size = New System.Drawing.Size(99, 20)
        Me.ChCategoria.TabIndex = 3
        Me.ChCategoria.Text = "Categoría "
        Me.ChCategoria.UseVisualStyleBackColor = True
        '
        'TNombreProd
        '
        Me.TNombreProd.Location = New System.Drawing.Point(374, 99)
        Me.TNombreProd.Name = "TNombreProd"
        Me.TNombreProd.Size = New System.Drawing.Size(225, 22)
        Me.TNombreProd.TabIndex = 2
        '
        'ChNombreProducto
        '
        Me.ChNombreProducto.AutoSize = True
        Me.ChNombreProducto.Location = New System.Drawing.Point(194, 101)
        Me.ChNombreProducto.Name = "ChNombreProducto"
        Me.ChNombreProducto.Size = New System.Drawing.Size(174, 20)
        Me.ChNombreProducto.TabIndex = 1
        Me.ChNombreProducto.Text = "Nombre del Producto"
        Me.ChNombreProducto.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(3, 250)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(829, 351)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.LRestado)
        Me.Panel2.Controls.Add(Me.LRstock_minimo)
        Me.Panel2.Controls.Add(Me.LRstock)
        Me.Panel2.Controls.Add(Me.LRprecio)
        Me.Panel2.Controls.Add(Me.LRcategoria)
        Me.Panel2.Controls.Add(Me.LRdescripcion)
        Me.Panel2.Controls.Add(Me.LRcodigo)
        Me.Panel2.Controls.Add(Me.LRnombre)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.LStockMinimo)
        Me.Panel2.Controls.Add(Me.LCodigo)
        Me.Panel2.Controls.Add(Me.LEstado)
        Me.Panel2.Controls.Add(Me.LCategoria)
        Me.Panel2.Controls.Add(Me.LStock)
        Me.Panel2.Controls.Add(Me.LPrecio)
        Me.Panel2.Controls.Add(Me.LDescripcion)
        Me.Panel2.Controls.Add(Me.LNombrepro)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(426, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(403, 351)
        Me.Panel2.TabIndex = 1
        '
        'LRestado
        '
        Me.LRestado.AutoSize = True
        Me.LRestado.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.LRestado.Location = New System.Drawing.Point(141, 324)
        Me.LRestado.Name = "LRestado"
        Me.LRestado.Size = New System.Drawing.Size(44, 16)
        Me.LRestado.TabIndex = 16
        Me.LRestado.Text = "         "
        '
        'LRstock_minimo
        '
        Me.LRstock_minimo.AutoSize = True
        Me.LRstock_minimo.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.LRstock_minimo.Location = New System.Drawing.Point(141, 288)
        Me.LRstock_minimo.Name = "LRstock_minimo"
        Me.LRstock_minimo.Size = New System.Drawing.Size(44, 16)
        Me.LRstock_minimo.TabIndex = 15
        Me.LRstock_minimo.Text = "         "
        '
        'LRstock
        '
        Me.LRstock.AutoSize = True
        Me.LRstock.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.LRstock.Location = New System.Drawing.Point(141, 253)
        Me.LRstock.Name = "LRstock"
        Me.LRstock.Size = New System.Drawing.Size(44, 16)
        Me.LRstock.TabIndex = 14
        Me.LRstock.Text = "         "
        '
        'LRprecio
        '
        Me.LRprecio.AutoSize = True
        Me.LRprecio.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.LRprecio.Location = New System.Drawing.Point(141, 217)
        Me.LRprecio.Name = "LRprecio"
        Me.LRprecio.Size = New System.Drawing.Size(56, 16)
        Me.LRprecio.TabIndex = 13
        Me.LRprecio.Text = "$          "
        '
        'LRcategoria
        '
        Me.LRcategoria.AutoSize = True
        Me.LRcategoria.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.LRcategoria.Location = New System.Drawing.Point(141, 173)
        Me.LRcategoria.Name = "LRcategoria"
        Me.LRcategoria.Size = New System.Drawing.Size(44, 16)
        Me.LRcategoria.TabIndex = 12
        Me.LRcategoria.Text = "         "
        '
        'LRdescripcion
        '
        Me.LRdescripcion.AutoSize = True
        Me.LRdescripcion.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.LRdescripcion.Location = New System.Drawing.Point(141, 137)
        Me.LRdescripcion.Name = "LRdescripcion"
        Me.LRdescripcion.Size = New System.Drawing.Size(44, 16)
        Me.LRdescripcion.TabIndex = 11
        Me.LRdescripcion.Text = "         "
        '
        'LRcodigo
        '
        Me.LRcodigo.AutoSize = True
        Me.LRcodigo.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.LRcodigo.Location = New System.Drawing.Point(141, 100)
        Me.LRcodigo.Name = "LRcodigo"
        Me.LRcodigo.Size = New System.Drawing.Size(44, 16)
        Me.LRcodigo.TabIndex = 10
        Me.LRcodigo.Text = "         "
        '
        'LRnombre
        '
        Me.LRnombre.AutoSize = True
        Me.LRnombre.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.LRnombre.Location = New System.Drawing.Point(141, 65)
        Me.LRnombre.Name = "LRnombre"
        Me.LRnombre.Size = New System.Drawing.Size(44, 16)
        Me.LRnombre.TabIndex = 9
        Me.LRnombre.Text = "         "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(124, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Detalle del Producto"
        '
        'LStockMinimo
        '
        Me.LStockMinimo.AutoSize = True
        Me.LStockMinimo.Location = New System.Drawing.Point(31, 288)
        Me.LStockMinimo.Name = "LStockMinimo"
        Me.LStockMinimo.Size = New System.Drawing.Size(104, 16)
        Me.LStockMinimo.TabIndex = 7
        Me.LStockMinimo.Text = "Stock Mínimo:"
        '
        'LCodigo
        '
        Me.LCodigo.AutoSize = True
        Me.LCodigo.Location = New System.Drawing.Point(69, 100)
        Me.LCodigo.Name = "LCodigo"
        Me.LCodigo.Size = New System.Drawing.Size(66, 16)
        Me.LCodigo.TabIndex = 6
        Me.LCodigo.Text = "Codigo: "
        '
        'LEstado
        '
        Me.LEstado.AutoSize = True
        Me.LEstado.Location = New System.Drawing.Point(70, 324)
        Me.LEstado.Name = "LEstado"
        Me.LEstado.Size = New System.Drawing.Size(65, 16)
        Me.LEstado.TabIndex = 5
        Me.LEstado.Text = "Estado: "
        '
        'LCategoria
        '
        Me.LCategoria.AutoSize = True
        Me.LCategoria.Location = New System.Drawing.Point(51, 173)
        Me.LCategoria.Name = "LCategoria"
        Me.LCategoria.Size = New System.Drawing.Size(84, 16)
        Me.LCategoria.TabIndex = 4
        Me.LCategoria.Text = "Categoria: "
        '
        'LStock
        '
        Me.LStock.AutoSize = True
        Me.LStock.Location = New System.Drawing.Point(80, 253)
        Me.LStock.Name = "LStock"
        Me.LStock.Size = New System.Drawing.Size(55, 16)
        Me.LStock.TabIndex = 3
        Me.LStock.Text = "Stock: "
        '
        'LPrecio
        '
        Me.LPrecio.AutoSize = True
        Me.LPrecio.Location = New System.Drawing.Point(74, 217)
        Me.LPrecio.Name = "LPrecio"
        Me.LPrecio.Size = New System.Drawing.Size(61, 16)
        Me.LPrecio.TabIndex = 2
        Me.LPrecio.Text = "Precio: "
        '
        'LDescripcion
        '
        Me.LDescripcion.AutoSize = True
        Me.LDescripcion.Location = New System.Drawing.Point(36, 137)
        Me.LDescripcion.Name = "LDescripcion"
        Me.LDescripcion.Size = New System.Drawing.Size(99, 16)
        Me.LDescripcion.TabIndex = 1
        Me.LDescripcion.Text = "Descripcion: "
        '
        'LNombrepro
        '
        Me.LNombrepro.AutoSize = True
        Me.LNombrepro.Location = New System.Drawing.Point(60, 65)
        Me.LNombrepro.Name = "LNombrepro"
        Me.LNombrepro.Size = New System.Drawing.Size(75, 16)
        Me.LNombrepro.TabIndex = 0
        Me.LNombrepro.Text = "Nombre : "
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Left
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(430, 351)
        Me.DataGridView1.TabIndex = 0
        '
        'EditarProductos
        '
        Me.EditarProductos.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.EditarProductos.Controls.Add(Me.Button7)
        Me.EditarProductos.Controls.Add(Me.ComboBox3)
        Me.EditarProductos.Controls.Add(Me.TextBox8)
        Me.EditarProductos.Controls.Add(Me.CheckBox1)
        Me.EditarProductos.Controls.Add(Me.Label1)
        Me.EditarProductos.Controls.Add(Me.TextBox4)
        Me.EditarProductos.Controls.Add(Me.Panel3)
        Me.EditarProductos.Controls.Add(Me.ChBCategoria)
        Me.EditarProductos.Controls.Add(Me.ChProducto)
        Me.EditarProductos.Controls.Add(Me.BBuscar)
        Me.EditarProductos.Location = New System.Drawing.Point(4, 28)
        Me.EditarProductos.Name = "EditarProductos"
        Me.EditarProductos.Padding = New System.Windows.Forms.Padding(3)
        Me.EditarProductos.Size = New System.Drawing.Size(835, 604)
        Me.EditarProductos.TabIndex = 1
        Me.EditarProductos.Text = "Editar Productos"
        '
        'Button7
        '
        Me.Button7.Image = Global.Proyecto2023.My.Resources.Resources.search_good_icon_icons_com_51027__1_
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(220, 162)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(177, 37)
        Me.Button7.TabIndex = 18
        Me.Button7.Text = "Listar Todos"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button7.UseVisualStyleBackColor = True
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(376, 132)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(225, 24)
        Me.ComboBox3.TabIndex = 17
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(376, 52)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(225, 22)
        Me.TextBox8.TabIndex = 16
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(184, 52)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(169, 20)
        Me.CheckBox1.TabIndex = 15
        Me.CheckBox1.Text = "Código del Producto"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(272, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Seleccionar un filtro de búsqueda"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(376, 93)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(225, 22)
        Me.TextBox4.TabIndex = 12
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.DataGridView2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(3, 224)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(829, 377)
        Me.Panel3.TabIndex = 10
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Button6)
        Me.Panel4.Controls.Add(Me.ComboBox5)
        Me.Panel4.Controls.Add(Me.ComboBox4)
        Me.Panel4.Controls.Add(Me.Button4)
        Me.Panel4.Controls.Add(Me.TextBox10)
        Me.Panel4.Controls.Add(Me.LStockMinimo1)
        Me.Panel4.Controls.Add(Me.TextBox9)
        Me.Panel4.Controls.Add(Me.LCódigo1)
        Me.Panel4.Controls.Add(Me.BCambios)
        Me.Panel4.Controls.Add(Me.TPrecioEdit)
        Me.Panel4.Controls.Add(Me.TStockEdit)
        Me.Panel4.Controls.Add(Me.TDescripcion)
        Me.Panel4.Controls.Add(Me.TNombre)
        Me.Panel4.Controls.Add(Me.LEstado1)
        Me.Panel4.Controls.Add(Me.LPrecio1)
        Me.Panel4.Controls.Add(Me.LStock1)
        Me.Panel4.Controls.Add(Me.LCtaegoria1)
        Me.Panel4.Controls.Add(Me.LDescripcion1)
        Me.Panel4.Controls.Add(Me.LNombreProducto)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(446, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(383, 377)
        Me.Panel4.TabIndex = 1
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Image = Global.Proyecto2023.My.Resources.Resources.ic_cancel_128_28318
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(18, 321)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(150, 41)
        Me.Button6.TabIndex = 20
        Me.Button6.Text = "Cancelar"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button6.UseVisualStyleBackColor = True
        '
        'ComboBox5
        '
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(168, 291)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(209, 24)
        Me.ComboBox5.TabIndex = 19
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(166, 144)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(204, 24)
        Me.ComboBox4.TabIndex = 18
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(257, 173)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(118, 44)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "Agregar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Stock"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox10
        '
        Me.TextBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(168, 225)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(209, 21)
        Me.TextBox10.TabIndex = 16
        '
        'LStockMinimo1
        '
        Me.LStockMinimo1.AutoSize = True
        Me.LStockMinimo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LStockMinimo1.Location = New System.Drawing.Point(70, 225)
        Me.LStockMinimo1.Name = "LStockMinimo1"
        Me.LStockMinimo1.Size = New System.Drawing.Size(98, 15)
        Me.LStockMinimo1.TabIndex = 15
        Me.LStockMinimo1.Text = "Stock minimo:"
        '
        'TextBox9
        '
        Me.TextBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(166, 43)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(209, 21)
        Me.TextBox9.TabIndex = 14
        '
        'LCódigo1
        '
        Me.LCódigo1.AutoSize = True
        Me.LCódigo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCódigo1.Location = New System.Drawing.Point(14, 45)
        Me.LCódigo1.Name = "LCódigo1"
        Me.LCódigo1.Size = New System.Drawing.Size(140, 15)
        Me.LCódigo1.TabIndex = 13
        Me.LCódigo1.Text = "Código del producto:"
        '
        'BCambios
        '
        Me.BCambios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCambios.Image = Global.Proyecto2023.My.Resources.Resources.sign_check_icon_34365
        Me.BCambios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BCambios.Location = New System.Drawing.Point(190, 321)
        Me.BCambios.Name = "BCambios"
        Me.BCambios.Size = New System.Drawing.Size(180, 41)
        Me.BCambios.TabIndex = 12
        Me.BCambios.Text = "Confirmar Cambios"
        Me.BCambios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BCambios.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BCambios.UseVisualStyleBackColor = True
        '
        'TPrecioEdit
        '
        Me.TPrecioEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPrecioEdit.Location = New System.Drawing.Point(168, 258)
        Me.TPrecioEdit.Name = "TPrecioEdit"
        Me.TPrecioEdit.Size = New System.Drawing.Size(209, 21)
        Me.TPrecioEdit.TabIndex = 10
        '
        'TStockEdit
        '
        Me.TStockEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TStockEdit.Location = New System.Drawing.Point(166, 186)
        Me.TStockEdit.Name = "TStockEdit"
        Me.TStockEdit.Size = New System.Drawing.Size(85, 21)
        Me.TStockEdit.TabIndex = 9
        '
        'TDescripcion
        '
        Me.TDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDescripcion.Location = New System.Drawing.Point(166, 76)
        Me.TDescripcion.Multiline = True
        Me.TDescripcion.Name = "TDescripcion"
        Me.TDescripcion.Size = New System.Drawing.Size(209, 60)
        Me.TDescripcion.TabIndex = 7
        '
        'TNombre
        '
        Me.TNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TNombre.Location = New System.Drawing.Point(166, 10)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(209, 21)
        Me.TNombre.TabIndex = 6
        '
        'LEstado1
        '
        Me.LEstado1.AutoSize = True
        Me.LEstado1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEstado1.Location = New System.Drawing.Point(113, 291)
        Me.LEstado1.Name = "LEstado1"
        Me.LEstado1.Size = New System.Drawing.Size(55, 15)
        Me.LEstado1.TabIndex = 5
        Me.LEstado1.Text = "Estado:"
        '
        'LPrecio1
        '
        Me.LPrecio1.AutoSize = True
        Me.LPrecio1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPrecio1.Location = New System.Drawing.Point(117, 258)
        Me.LPrecio1.Name = "LPrecio1"
        Me.LPrecio1.Size = New System.Drawing.Size(52, 15)
        Me.LPrecio1.TabIndex = 4
        Me.LPrecio1.Text = "Precio:"
        '
        'LStock1
        '
        Me.LStock1.AutoSize = True
        Me.LStock1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LStock1.Location = New System.Drawing.Point(121, 186)
        Me.LStock1.Name = "LStock1"
        Me.LStock1.Size = New System.Drawing.Size(46, 15)
        Me.LStock1.TabIndex = 3
        Me.LStock1.Text = "Stock:"
        '
        'LCtaegoria1
        '
        Me.LCtaegoria1.AutoSize = True
        Me.LCtaegoria1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCtaegoria1.Location = New System.Drawing.Point(92, 147)
        Me.LCtaegoria1.Name = "LCtaegoria1"
        Me.LCtaegoria1.Size = New System.Drawing.Size(73, 15)
        Me.LCtaegoria1.TabIndex = 2
        Me.LCtaegoria1.Text = "Categoria:"
        '
        'LDescripcion1
        '
        Me.LDescripcion1.AutoSize = True
        Me.LDescripcion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDescripcion1.Location = New System.Drawing.Point(77, 76)
        Me.LDescripcion1.Name = "LDescripcion1"
        Me.LDescripcion1.Size = New System.Drawing.Size(87, 15)
        Me.LDescripcion1.TabIndex = 1
        Me.LDescripcion1.Text = "Descripción:"
        '
        'LNombreProducto
        '
        Me.LNombreProducto.AutoSize = True
        Me.LNombreProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombreProducto.Location = New System.Drawing.Point(14, 10)
        Me.LNombreProducto.Name = "LNombreProducto"
        Me.LNombreProducto.Size = New System.Drawing.Size(146, 15)
        Me.LNombreProducto.TabIndex = 0
        Me.LNombreProducto.Text = "Nombre del producto:"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Left
        Me.DataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(449, 377)
        Me.DataGridView2.TabIndex = 0
        '
        'ChBCategoria
        '
        Me.ChBCategoria.AutoSize = True
        Me.ChBCategoria.Location = New System.Drawing.Point(258, 134)
        Me.ChBCategoria.Name = "ChBCategoria"
        Me.ChBCategoria.Size = New System.Drawing.Size(95, 20)
        Me.ChBCategoria.TabIndex = 9
        Me.ChBCategoria.Text = "Categoria"
        Me.ChBCategoria.UseVisualStyleBackColor = True
        '
        'ChProducto
        '
        Me.ChProducto.AutoSize = True
        Me.ChProducto.Location = New System.Drawing.Point(179, 93)
        Me.ChProducto.Name = "ChProducto"
        Me.ChProducto.Size = New System.Drawing.Size(174, 20)
        Me.ChProducto.TabIndex = 8
        Me.ChProducto.Text = "Nombre del Producto"
        Me.ChProducto.UseVisualStyleBackColor = True
        '
        'BBuscar
        '
        Me.BBuscar.Image = Global.Proyecto2023.My.Resources.Resources.search_good_icon_icons_com_51027__1_
        Me.BBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BBuscar.Location = New System.Drawing.Point(421, 162)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(177, 37)
        Me.BBuscar.TabIndex = 11
        Me.BBuscar.Text = "Buscar Producto"
        Me.BBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BBuscar.UseVisualStyleBackColor = True
        '
        'AgregarProductos
        '
        Me.AgregarProductos.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.AgregarProductos.Controls.Add(Me.Button9)
        Me.AgregarProductos.Controls.Add(Me.Button3)
        Me.AgregarProductos.Controls.Add(Me.Button2)
        Me.AgregarProductos.Controls.Add(Me.TextBox11)
        Me.AgregarProductos.Controls.Add(Me.LBuscarProducto)
        Me.AgregarProductos.Controls.Add(Me.Panel6)
        Me.AgregarProductos.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.AgregarProductos.Location = New System.Drawing.Point(4, 28)
        Me.AgregarProductos.Name = "AgregarProductos"
        Me.AgregarProductos.Padding = New System.Windows.Forms.Padding(3)
        Me.AgregarProductos.Size = New System.Drawing.Size(835, 604)
        Me.AgregarProductos.TabIndex = 2
        Me.AgregarProductos.Text = "Agregar nuevos productos"
        '
        'Button9
        '
        Me.Button9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button9.Image = CType(resources.GetObject("Button9.Image"), System.Drawing.Image)
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.Location = New System.Drawing.Point(30, 507)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(221, 49)
        Me.Button9.TabIndex = 32
        Me.Button9.Text = "Volver para cambiar el nombre del producto"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.Image = Global.Proyecto2023.My.Resources.Resources.sign_check_icon_34365
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(611, 513)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(188, 43)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "Confirmar Datos"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Image = Global.Proyecto2023.My.Resources.Resources.searchcircularbutton_79274
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(579, 37)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 46)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Buscar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox11
        '
        Me.TextBox11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox11.Location = New System.Drawing.Point(129, 49)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(433, 22)
        Me.TextBox11.TabIndex = 27
        '
        'LBuscarProducto
        '
        Me.LBuscarProducto.AutoSize = True
        Me.LBuscarProducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LBuscarProducto.Location = New System.Drawing.Point(126, 15)
        Me.LBuscarProducto.Name = "LBuscarProducto"
        Me.LBuscarProducto.Size = New System.Drawing.Size(573, 16)
        Me.LBuscarProducto.TabIndex = 26
        Me.LBuscarProducto.Text = "Ingresar nombre del nuevo  producto para comprobar que  no existe en el sistema"
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Button5)
        Me.Panel6.Controls.Add(Me.TextBox13)
        Me.Panel6.Controls.Add(Me.LStockMinimo2)
        Me.Panel6.Controls.Add(Me.TextBox12)
        Me.Panel6.Controls.Add(Me.LCódigo2)
        Me.Panel6.Controls.Add(Me.ComboBox2)
        Me.Panel6.Controls.Add(Me.ComboBox1)
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Controls.Add(Me.TextBox7)
        Me.Panel6.Controls.Add(Me.TextBox6)
        Me.Panel6.Controls.Add(Me.TextBox5)
        Me.Panel6.Controls.Add(Me.TDescripcion2)
        Me.Panel6.Controls.Add(Me.LEstadoInicial)
        Me.Panel6.Controls.Add(Me.LDescripcion2)
        Me.Panel6.Controls.Add(Me.LStockInicial)
        Me.Panel6.Controls.Add(Me.LCategoria2)
        Me.Panel6.Controls.Add(Me.LPrecio2)
        Me.Panel6.Controls.Add(Me.LNombre2)
        Me.Panel6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel6.Location = New System.Drawing.Point(9, 115)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(790, 364)
        Me.Panel6.TabIndex = 31
        '
        'Button5
        '
        Me.Button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button5.Image = Global.Proyecto2023.My.Resources.Resources.add
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(332, 185)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(42, 43)
        Me.Button5.TabIndex = 31
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(176, 317)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(198, 22)
        Me.TextBox13.TabIndex = 30
        '
        'LStockMinimo2
        '
        Me.LStockMinimo2.AutoSize = True
        Me.LStockMinimo2.Location = New System.Drawing.Point(71, 320)
        Me.LStockMinimo2.Name = "LStockMinimo2"
        Me.LStockMinimo2.Size = New System.Drawing.Size(100, 16)
        Me.LStockMinimo2.TabIndex = 29
        Me.LStockMinimo2.Text = "Stock Mínimo"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(556, 75)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(207, 22)
        Me.TextBox12.TabIndex = 28
        '
        'LCódigo2
        '
        Me.LCódigo2.AutoSize = True
        Me.LCódigo2.Location = New System.Drawing.Point(401, 78)
        Me.LCódigo2.Name = "LCódigo2"
        Me.LCódigo2.Size = New System.Drawing.Size(149, 16)
        Me.LCódigo2.TabIndex = 27
        Me.LCódigo2.Text = "Código del producto"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.ComboBox2.Location = New System.Drawing.Point(552, 315)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(211, 24)
        Me.ComboBox2.TabIndex = 26
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(177, 195)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(149, 24)
        Me.ComboBox1.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(193, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(447, 18)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Completar los campos para el registro del nuevo producto"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(177, 257)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(198, 22)
        Me.TextBox7.TabIndex = 12
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(177, 135)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(198, 22)
        Me.TextBox6.TabIndex = 11
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(177, 75)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(198, 22)
        Me.TextBox5.TabIndex = 10
        '
        'TDescripcion2
        '
        Me.TDescripcion2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TDescripcion2.Location = New System.Drawing.Point(552, 135)
        Me.TDescripcion2.Multiline = True
        Me.TDescripcion2.Name = "TDescripcion2"
        Me.TDescripcion2.Size = New System.Drawing.Size(211, 144)
        Me.TDescripcion2.TabIndex = 23
        '
        'LEstadoInicial
        '
        Me.LEstadoInicial.AutoSize = True
        Me.LEstadoInicial.Location = New System.Drawing.Point(444, 320)
        Me.LEstadoInicial.Name = "LEstadoInicial"
        Me.LEstadoInicial.Size = New System.Drawing.Size(102, 16)
        Me.LEstadoInicial.TabIndex = 7
        Me.LEstadoInicial.Text = "Estado inicial"
        '
        'LDescripcion2
        '
        Me.LDescripcion2.AutoSize = True
        Me.LDescripcion2.Location = New System.Drawing.Point(455, 138)
        Me.LDescripcion2.Name = "LDescripcion2"
        Me.LDescripcion2.Size = New System.Drawing.Size(91, 16)
        Me.LDescripcion2.TabIndex = 4
        Me.LDescripcion2.Text = "Descripción"
        '
        'LStockInicial
        '
        Me.LStockInicial.AutoSize = True
        Me.LStockInicial.Location = New System.Drawing.Point(79, 260)
        Me.LStockInicial.Name = "LStockInicial"
        Me.LStockInicial.Size = New System.Drawing.Size(92, 16)
        Me.LStockInicial.TabIndex = 3
        Me.LStockInicial.Text = "Stock Inicial"
        '
        'LCategoria2
        '
        Me.LCategoria2.AutoSize = True
        Me.LCategoria2.Location = New System.Drawing.Point(95, 198)
        Me.LCategoria2.Name = "LCategoria2"
        Me.LCategoria2.Size = New System.Drawing.Size(76, 16)
        Me.LCategoria2.TabIndex = 2
        Me.LCategoria2.Text = "Categoria"
        '
        'LPrecio2
        '
        Me.LPrecio2.AutoSize = True
        Me.LPrecio2.Location = New System.Drawing.Point(117, 138)
        Me.LPrecio2.Name = "LPrecio2"
        Me.LPrecio2.Size = New System.Drawing.Size(53, 16)
        Me.LPrecio2.TabIndex = 1
        Me.LPrecio2.Text = "Precio"
        '
        'LNombre2
        '
        Me.LNombre2.AutoSize = True
        Me.LNombre2.Location = New System.Drawing.Point(17, 78)
        Me.LNombre2.Name = "LNombre2"
        Me.LNombre2.Size = New System.Drawing.Size(154, 16)
        Me.LNombre2.TabIndex = 0
        Me.LNombre2.Text = "Nombre del producto"
        '
        'GestionProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 636)
        Me.Controls.Add(Me.GestionarProductos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GestionProductos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion de Productos"
        Me.GestionarProductos.ResumeLayout(False)
        Me.ConsultarProductos.ResumeLayout(False)
        Me.ConsultarProductos.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EditarProductos.ResumeLayout(False)
        Me.EditarProductos.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AgregarProductos.ResumeLayout(False)
        Me.AgregarProductos.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GestionarProductos As TabControl
    Friend WithEvents ConsultarProductos As TabPage
    Friend WithEvents EditarProductos As TabPage
    Friend WithEvents AgregarProductos As TabPage
    Friend WithEvents ChNombreProducto As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LStock As Label
    Friend WithEvents LPrecio As Label
    Friend WithEvents LDescripcion As Label
    Friend WithEvents LNombrepro As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ChCategoria As CheckBox
    Friend WithEvents TNombreProd As TextBox
    Friend WithEvents LTitulo As Label
    Friend WithEvents LEstado As Label
    Friend WithEvents LCategoria As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents BBuscar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BCambios As Button
    Friend WithEvents TPrecioEdit As TextBox
    Friend WithEvents TStockEdit As TextBox
    Friend WithEvents TDescripcion As TextBox
    Friend WithEvents TNombre As TextBox
    Friend WithEvents LEstado1 As Label
    Friend WithEvents LPrecio1 As Label
    Friend WithEvents LStock1 As Label
    Friend WithEvents LCtaegoria1 As Label
    Friend WithEvents LDescripcion1 As Label
    Friend WithEvents LNombreProducto As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents ChBCategoria As CheckBox
    Friend WithEvents ChProducto As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents LBuscarProducto As Label
    Friend WithEvents TDescripcion2 As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents LEstadoInicial As Label
    Friend WithEvents LDescripcion2 As Label
    Friend WithEvents LStockInicial As Label
    Friend WithEvents LCategoria2 As Label
    Friend WithEvents LPrecio2 As Label
    Friend WithEvents LNombre2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TCodigo As TextBox
    Friend WithEvents ChCodigo As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents LCodigo As Label
    Friend WithEvents LStockMinimo As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents LStockMinimo1 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents LCódigo1 As Label
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents LStockMinimo2 As Label
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents LCódigo2 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents CBCateg As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents LRnombre As Label
    Friend WithEvents LRcategoria As Label
    Friend WithEvents LRdescripcion As Label
    Friend WithEvents LRcodigo As Label
    Friend WithEvents LRestado As Label
    Friend WithEvents LRstock_minimo As Label
    Friend WithEvents LRstock As Label
    Friend WithEvents LRprecio As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents Button3 As Button
End Class
