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
        Me.GestionarProductos = New System.Windows.Forms.TabControl()
        Me.ConsultarProductos = New System.Windows.Forms.TabPage()
        Me.ChNombreProducto = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LStock = New System.Windows.Forms.Label()
        Me.LPrecio = New System.Windows.Forms.Label()
        Me.LDescripcion = New System.Windows.Forms.Label()
        Me.LNombrepro = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EditarProductos = New System.Windows.Forms.TabPage()
        Me.AgregarProductos = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ChCategoria = New System.Windows.Forms.CheckBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.LCategoria = New System.Windows.Forms.Label()
        Me.LEstado = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BCambios = New System.Windows.Forms.Button()
        Me.TCorreo = New System.Windows.Forms.TextBox()
        Me.TTelefono = New System.Windows.Forms.TextBox()
        Me.TDireccion = New System.Windows.Forms.TextBox()
        Me.TFechaNac = New System.Windows.Forms.TextBox()
        Me.TDni = New System.Windows.Forms.TextBox()
        Me.TApellidoYNombre = New System.Windows.Forms.TextBox()
        Me.LEstado1 = New System.Windows.Forms.Label()
        Me.LPrecio1 = New System.Windows.Forms.Label()
        Me.LStock1 = New System.Windows.Forms.Label()
        Me.LCtaegoria1 = New System.Windows.Forms.Label()
        Me.LDescripcion1 = New System.Windows.Forms.Label()
        Me.LNombreProducto = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ChBCategoria = New System.Windows.Forms.CheckBox()
        Me.ChProducto = New System.Windows.Forms.CheckBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.LBuscarProducto = New System.Windows.Forms.Label()
        Me.TDescripcion2 = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.LEstadoInicial = New System.Windows.Forms.Label()
        Me.LDescripcion2 = New System.Windows.Forms.Label()
        Me.LStockInicial = New System.Windows.Forms.Label()
        Me.LCategoria2 = New System.Windows.Forms.Label()
        Me.LPrecio2 = New System.Windows.Forms.Label()
        Me.LNombre2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.GestionarProductos.SuspendLayout()
        Me.ConsultarProductos.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EditarProductos.SuspendLayout()
        Me.AgregarProductos.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
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
        Me.GestionarProductos.Size = New System.Drawing.Size(814, 621)
        Me.GestionarProductos.TabIndex = 0
        '
        'ConsultarProductos
        '
        Me.ConsultarProductos.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ConsultarProductos.Controls.Add(Me.LTitulo)
        Me.ConsultarProductos.Controls.Add(Me.TextBox2)
        Me.ConsultarProductos.Controls.Add(Me.ChCategoria)
        Me.ConsultarProductos.Controls.Add(Me.TextBox1)
        Me.ConsultarProductos.Controls.Add(Me.ChNombreProducto)
        Me.ConsultarProductos.Controls.Add(Me.Panel1)
        Me.ConsultarProductos.Location = New System.Drawing.Point(4, 28)
        Me.ConsultarProductos.Name = "ConsultarProductos"
        Me.ConsultarProductos.Padding = New System.Windows.Forms.Padding(3)
        Me.ConsultarProductos.Size = New System.Drawing.Size(806, 589)
        Me.ConsultarProductos.TabIndex = 0
        Me.ConsultarProductos.Text = "Consultar Productos"
        '
        'ChNombreProducto
        '
        Me.ChNombreProducto.AutoSize = True
        Me.ChNombreProducto.Location = New System.Drawing.Point(179, 91)
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
        Me.Panel1.Location = New System.Drawing.Point(3, 235)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 351)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.Controls.Add(Me.LEstado)
        Me.Panel2.Controls.Add(Me.LCategoria)
        Me.Panel2.Controls.Add(Me.LStock)
        Me.Panel2.Controls.Add(Me.LPrecio)
        Me.Panel2.Controls.Add(Me.LDescripcion)
        Me.Panel2.Controls.Add(Me.LNombrepro)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(366, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(434, 351)
        Me.Panel2.TabIndex = 1
        '
        'LStock
        '
        Me.LStock.AutoSize = True
        Me.LStock.Location = New System.Drawing.Point(18, 259)
        Me.LStock.Name = "LStock"
        Me.LStock.Size = New System.Drawing.Size(47, 16)
        Me.LStock.TabIndex = 3
        Me.LStock.Text = "Stock"
        '
        'LPrecio
        '
        Me.LPrecio.AutoSize = True
        Me.LPrecio.Location = New System.Drawing.Point(18, 203)
        Me.LPrecio.Name = "LPrecio"
        Me.LPrecio.Size = New System.Drawing.Size(53, 16)
        Me.LPrecio.TabIndex = 2
        Me.LPrecio.Text = "Precio"
        '
        'LDescripcion
        '
        Me.LDescripcion.AutoSize = True
        Me.LDescripcion.Location = New System.Drawing.Point(18, 73)
        Me.LDescripcion.Name = "LDescripcion"
        Me.LDescripcion.Size = New System.Drawing.Size(91, 16)
        Me.LDescripcion.TabIndex = 1
        Me.LDescripcion.Text = "Descripcion"
        '
        'LNombrepro
        '
        Me.LNombrepro.AutoSize = True
        Me.LNombrepro.Location = New System.Drawing.Point(18, 15)
        Me.LNombrepro.Name = "LNombrepro"
        Me.LNombrepro.Size = New System.Drawing.Size(67, 16)
        Me.LNombrepro.TabIndex = 0
        Me.LNombrepro.Text = "Nombre "
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
        Me.DataGridView1.Size = New System.Drawing.Size(360, 351)
        Me.DataGridView1.TabIndex = 0
        '
        'EditarProductos
        '
        Me.EditarProductos.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.EditarProductos.Controls.Add(Me.Label1)
        Me.EditarProductos.Controls.Add(Me.TextBox3)
        Me.EditarProductos.Controls.Add(Me.TextBox4)
        Me.EditarProductos.Controls.Add(Me.BBuscar)
        Me.EditarProductos.Controls.Add(Me.Panel3)
        Me.EditarProductos.Controls.Add(Me.ChBCategoria)
        Me.EditarProductos.Controls.Add(Me.ChProducto)
        Me.EditarProductos.Location = New System.Drawing.Point(4, 28)
        Me.EditarProductos.Name = "EditarProductos"
        Me.EditarProductos.Padding = New System.Windows.Forms.Padding(3)
        Me.EditarProductos.Size = New System.Drawing.Size(806, 589)
        Me.EditarProductos.TabIndex = 1
        Me.EditarProductos.Text = "Editar Productos"
        '
        'AgregarProductos
        '
        Me.AgregarProductos.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.AgregarProductos.Controls.Add(Me.Panel5)
        Me.AgregarProductos.Controls.Add(Me.Button3)
        Me.AgregarProductos.Controls.Add(Me.Button2)
        Me.AgregarProductos.Controls.Add(Me.TextBox11)
        Me.AgregarProductos.Controls.Add(Me.LBuscarProducto)
        Me.AgregarProductos.Controls.Add(Me.Panel6)
        Me.AgregarProductos.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.AgregarProductos.Location = New System.Drawing.Point(4, 28)
        Me.AgregarProductos.Name = "AgregarProductos"
        Me.AgregarProductos.Padding = New System.Windows.Forms.Padding(3)
        Me.AgregarProductos.Size = New System.Drawing.Size(806, 589)
        Me.AgregarProductos.TabIndex = 2
        Me.AgregarProductos.Text = "Agregar nuevos productos"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(359, 89)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(225, 22)
        Me.TextBox1.TabIndex = 2
        '
        'ChCategoria
        '
        Me.ChCategoria.AutoSize = True
        Me.ChCategoria.Location = New System.Drawing.Point(179, 149)
        Me.ChCategoria.Name = "ChCategoria"
        Me.ChCategoria.Size = New System.Drawing.Size(99, 20)
        Me.ChCategoria.TabIndex = 3
        Me.ChCategoria.Text = "Categoría "
        Me.ChCategoria.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(359, 147)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(225, 22)
        Me.TextBox2.TabIndex = 4
        '
        'LTitulo
        '
        Me.LTitulo.AutoSize = True
        Me.LTitulo.Location = New System.Drawing.Point(261, 31)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(240, 16)
        Me.LTitulo.TabIndex = 8
        Me.LTitulo.Text = "Seleccionar un filtro de búsqueda"
        '
        'LCategoria
        '
        Me.LCategoria.AutoSize = True
        Me.LCategoria.Location = New System.Drawing.Point(18, 141)
        Me.LCategoria.Name = "LCategoria"
        Me.LCategoria.Size = New System.Drawing.Size(76, 16)
        Me.LCategoria.TabIndex = 4
        Me.LCategoria.Text = "Categoria"
        '
        'LEstado
        '
        Me.LEstado.AutoSize = True
        Me.LEstado.Location = New System.Drawing.Point(18, 312)
        Me.LEstado.Name = "LEstado"
        Me.LEstado.Size = New System.Drawing.Size(57, 16)
        Me.LEstado.TabIndex = 5
        Me.LEstado.Text = "Estado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(270, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Seleccionar un filtro de búsqueda"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(367, 137)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(214, 22)
        Me.TextBox3.TabIndex = 13
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(367, 85)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(214, 22)
        Me.TextBox4.TabIndex = 12
        '
        'BBuscar
        '
        Me.BBuscar.Location = New System.Drawing.Point(321, 213)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(177, 28)
        Me.BBuscar.TabIndex = 11
        Me.BBuscar.Text = "Buscar Producto"
        Me.BBuscar.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.DataGridView2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(3, 261)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(800, 325)
        Me.Panel3.TabIndex = 10
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.BCambios)
        Me.Panel4.Controls.Add(Me.TCorreo)
        Me.Panel4.Controls.Add(Me.TTelefono)
        Me.Panel4.Controls.Add(Me.TDireccion)
        Me.Panel4.Controls.Add(Me.TFechaNac)
        Me.Panel4.Controls.Add(Me.TDni)
        Me.Panel4.Controls.Add(Me.TApellidoYNombre)
        Me.Panel4.Controls.Add(Me.LEstado1)
        Me.Panel4.Controls.Add(Me.LPrecio1)
        Me.Panel4.Controls.Add(Me.LStock1)
        Me.Panel4.Controls.Add(Me.LCtaegoria1)
        Me.Panel4.Controls.Add(Me.LDescripcion1)
        Me.Panel4.Controls.Add(Me.LNombreProducto)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(394, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(406, 325)
        Me.Panel4.TabIndex = 1
        '
        'BCambios
        '
        Me.BCambios.Location = New System.Drawing.Point(147, 281)
        Me.BCambios.Name = "BCambios"
        Me.BCambios.Size = New System.Drawing.Size(172, 23)
        Me.BCambios.TabIndex = 12
        Me.BCambios.Text = "Confirmar Cambios"
        Me.BCambios.UseVisualStyleBackColor = True
        '
        'TCorreo
        '
        Me.TCorreo.Location = New System.Drawing.Point(192, 232)
        Me.TCorreo.Name = "TCorreo"
        Me.TCorreo.Size = New System.Drawing.Size(199, 22)
        Me.TCorreo.TabIndex = 11
        '
        'TTelefono
        '
        Me.TTelefono.Location = New System.Drawing.Point(192, 193)
        Me.TTelefono.Name = "TTelefono"
        Me.TTelefono.Size = New System.Drawing.Size(199, 22)
        Me.TTelefono.TabIndex = 10
        '
        'TDireccion
        '
        Me.TDireccion.Location = New System.Drawing.Point(192, 149)
        Me.TDireccion.Name = "TDireccion"
        Me.TDireccion.Size = New System.Drawing.Size(199, 22)
        Me.TDireccion.TabIndex = 9
        '
        'TFechaNac
        '
        Me.TFechaNac.Location = New System.Drawing.Point(192, 106)
        Me.TFechaNac.Name = "TFechaNac"
        Me.TFechaNac.Size = New System.Drawing.Size(199, 22)
        Me.TFechaNac.TabIndex = 8
        '
        'TDni
        '
        Me.TDni.Location = New System.Drawing.Point(192, 67)
        Me.TDni.Name = "TDni"
        Me.TDni.Size = New System.Drawing.Size(199, 22)
        Me.TDni.TabIndex = 7
        '
        'TApellidoYNombre
        '
        Me.TApellidoYNombre.Location = New System.Drawing.Point(192, 24)
        Me.TApellidoYNombre.Name = "TApellidoYNombre"
        Me.TApellidoYNombre.Size = New System.Drawing.Size(199, 22)
        Me.TApellidoYNombre.TabIndex = 6
        '
        'LEstado1
        '
        Me.LEstado1.AutoSize = True
        Me.LEstado1.Location = New System.Drawing.Point(121, 235)
        Me.LEstado1.Name = "LEstado1"
        Me.LEstado1.Size = New System.Drawing.Size(61, 16)
        Me.LEstado1.TabIndex = 5
        Me.LEstado1.Text = "Estado:"
        '
        'LPrecio1
        '
        Me.LPrecio1.AutoSize = True
        Me.LPrecio1.Location = New System.Drawing.Point(125, 193)
        Me.LPrecio1.Name = "LPrecio1"
        Me.LPrecio1.Size = New System.Drawing.Size(57, 16)
        Me.LPrecio1.TabIndex = 4
        Me.LPrecio1.Text = "Precio:"
        '
        'LStock1
        '
        Me.LStock1.AutoSize = True
        Me.LStock1.Location = New System.Drawing.Point(131, 152)
        Me.LStock1.Name = "LStock1"
        Me.LStock1.Size = New System.Drawing.Size(51, 16)
        Me.LStock1.TabIndex = 3
        Me.LStock1.Text = "Stock:"
        '
        'LCtaegoria1
        '
        Me.LCtaegoria1.AutoSize = True
        Me.LCtaegoria1.Location = New System.Drawing.Point(102, 112)
        Me.LCtaegoria1.Name = "LCtaegoria1"
        Me.LCtaegoria1.Size = New System.Drawing.Size(80, 16)
        Me.LCtaegoria1.TabIndex = 2
        Me.LCtaegoria1.Text = "Categoria:"
        '
        'LDescripcion1
        '
        Me.LDescripcion1.AutoSize = True
        Me.LDescripcion1.Location = New System.Drawing.Point(87, 67)
        Me.LDescripcion1.Name = "LDescripcion1"
        Me.LDescripcion1.Size = New System.Drawing.Size(95, 16)
        Me.LDescripcion1.TabIndex = 1
        Me.LDescripcion1.Text = "Descripcion:"
        '
        'LNombreProducto
        '
        Me.LNombreProducto.AutoSize = True
        Me.LNombreProducto.Location = New System.Drawing.Point(24, 27)
        Me.LNombreProducto.Name = "LNombreProducto"
        Me.LNombreProducto.Size = New System.Drawing.Size(158, 16)
        Me.LNombreProducto.TabIndex = 0
        Me.LNombreProducto.Text = "Nombre del producto:"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Left
        Me.DataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(388, 325)
        Me.DataGridView2.TabIndex = 0
        '
        'ChBCategoria
        '
        Me.ChBCategoria.AutoSize = True
        Me.ChBCategoria.Location = New System.Drawing.Point(238, 137)
        Me.ChBCategoria.Name = "ChBCategoria"
        Me.ChBCategoria.Size = New System.Drawing.Size(95, 20)
        Me.ChBCategoria.TabIndex = 9
        Me.ChBCategoria.Text = "Categoria"
        Me.ChBCategoria.UseVisualStyleBackColor = True
        '
        'ChProducto
        '
        Me.ChProducto.AutoSize = True
        Me.ChProducto.Location = New System.Drawing.Point(174, 85)
        Me.ChProducto.Name = "ChProducto"
        Me.ChProducto.Size = New System.Drawing.Size(174, 20)
        Me.ChProducto.TabIndex = 8
        Me.ChProducto.Text = "Nombre del Producto"
        Me.ChProducto.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel5.Controls.Add(Me.TextBox12)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel5.Location = New System.Drawing.Point(3, 554)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(800, 32)
        Me.Panel5.TabIndex = 30
        '
        'TextBox12
        '
        Me.TextBox12.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TextBox12.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox12.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox12.Enabled = False
        Me.TextBox12.Font = New System.Drawing.Font("Microsoft Uighur", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.ForeColor = System.Drawing.Color.Red
        Me.TextBox12.Location = New System.Drawing.Point(0, 0)
        Me.TextBox12.Multiline = True
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(800, 200)
        Me.TextBox12.TabIndex = 20
        Me.TextBox12.Text = "Una vez confirmados los datos, el Gerente General se encargará de asignar usuario" &
    " y contraseña al nuevo cajero."
        Me.TextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button3
        '
        Me.Button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.Location = New System.Drawing.Point(310, 427)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(188, 34)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "Confirmar Datos"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(609, 37)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 28)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox11
        '
        Me.TextBox11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox11.Location = New System.Drawing.Point(129, 40)
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
        'TDescripcion2
        '
        Me.TDescripcion2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TDescripcion2.Location = New System.Drawing.Point(534, 78)
        Me.TDescripcion2.Multiline = True
        Me.TDescripcion2.Name = "TDescripcion2"
        Me.TDescripcion2.Size = New System.Drawing.Size(237, 112)
        Me.TDescripcion2.TabIndex = 23
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
        Me.Panel6.Location = New System.Drawing.Point(8, 82)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(790, 289)
        Me.Panel6.TabIndex = 31
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
        Me.TextBox7.Location = New System.Drawing.Point(194, 210)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(198, 22)
        Me.TextBox7.TabIndex = 12
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(194, 122)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(198, 22)
        Me.TextBox6.TabIndex = 11
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(194, 78)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(198, 22)
        Me.TextBox5.TabIndex = 10
        '
        'LEstadoInicial
        '
        Me.LEstadoInicial.AutoSize = True
        Me.LEstadoInicial.Location = New System.Drawing.Point(426, 210)
        Me.LEstadoInicial.Name = "LEstadoInicial"
        Me.LEstadoInicial.Size = New System.Drawing.Size(102, 16)
        Me.LEstadoInicial.TabIndex = 7
        Me.LEstadoInicial.Text = "Estado inicial"
        '
        'LDescripcion2
        '
        Me.LDescripcion2.AutoSize = True
        Me.LDescripcion2.Location = New System.Drawing.Point(437, 81)
        Me.LDescripcion2.Name = "LDescripcion2"
        Me.LDescripcion2.Size = New System.Drawing.Size(91, 16)
        Me.LDescripcion2.TabIndex = 4
        Me.LDescripcion2.Text = "Descripcion"
        '
        'LStockInicial
        '
        Me.LStockInicial.AutoSize = True
        Me.LStockInicial.Location = New System.Drawing.Point(79, 210)
        Me.LStockInicial.Name = "LStockInicial"
        Me.LStockInicial.Size = New System.Drawing.Size(92, 16)
        Me.LStockInicial.TabIndex = 3
        Me.LStockInicial.Text = "Stock Inicial"
        '
        'LCategoria2
        '
        Me.LCategoria2.AutoSize = True
        Me.LCategoria2.Location = New System.Drawing.Point(95, 169)
        Me.LCategoria2.Name = "LCategoria2"
        Me.LCategoria2.Size = New System.Drawing.Size(76, 16)
        Me.LCategoria2.TabIndex = 2
        Me.LCategoria2.Text = "Categoria"
        '
        'LPrecio2
        '
        Me.LPrecio2.AutoSize = True
        Me.LPrecio2.Location = New System.Drawing.Point(118, 125)
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
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Bazar", "Libreria", "Ferreteria"})
        Me.ComboBox1.Location = New System.Drawing.Point(194, 166)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(198, 24)
        Me.ComboBox1.TabIndex = 14
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.ComboBox2.Location = New System.Drawing.Point(534, 207)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(237, 24)
        Me.ComboBox2.TabIndex = 26
        '
        'GestionProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 621)
        Me.Controls.Add(Me.GestionarProductos)
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
        Me.AgregarProductos.ResumeLayout(False)
        Me.AgregarProductos.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents LTitulo As Label
    Friend WithEvents LEstado As Label
    Friend WithEvents LCategoria As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents BBuscar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BCambios As Button
    Friend WithEvents TCorreo As TextBox
    Friend WithEvents TTelefono As TextBox
    Friend WithEvents TDireccion As TextBox
    Friend WithEvents TFechaNac As TextBox
    Friend WithEvents TDni As TextBox
    Friend WithEvents TApellidoYNombre As TextBox
    Friend WithEvents LEstado1 As Label
    Friend WithEvents LPrecio1 As Label
    Friend WithEvents LStock1 As Label
    Friend WithEvents LCtaegoria1 As Label
    Friend WithEvents LDescripcion1 As Label
    Friend WithEvents LNombreProducto As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents ChBCategoria As CheckBox
    Friend WithEvents ChProducto As CheckBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents Button3 As Button
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
End Class
