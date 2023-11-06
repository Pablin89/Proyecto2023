<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Empleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Empleados))
        Me.GestionarEmpleados = New System.Windows.Forms.TabControl()
        Me.ConsultarEmpleados = New System.Windows.Forms.TabPage()
        Me.BLimpiarFiltros = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LEstado2 = New System.Windows.Forms.Label()
        Me.LEstado = New System.Windows.Forms.Label()
        Me.LCorreo2 = New System.Windows.Forms.Label()
        Me.LTelefono2 = New System.Windows.Forms.Label()
        Me.LDireccion2 = New System.Windows.Forms.Label()
        Me.LFechaNac2 = New System.Windows.Forms.Label()
        Me.LDni2 = New System.Windows.Forms.Label()
        Me.LApeyNom = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.EditarEmpleados = New System.Windows.Forms.TabPage()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TApellidos = New System.Windows.Forms.TextBox()
        Me.LApellidos = New System.Windows.Forms.Label()
        Me.DTFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.BRCambios = New System.Windows.Forms.Button()
        Me.BCambios = New System.Windows.Forms.Button()
        Me.TCorreo = New System.Windows.Forms.TextBox()
        Me.TTelefono = New System.Windows.Forms.TextBox()
        Me.TDireccion = New System.Windows.Forms.TextBox()
        Me.TDni = New System.Windows.Forms.TextBox()
        Me.TNombres = New System.Windows.Forms.TextBox()
        Me.LCorreo = New System.Windows.Forms.Label()
        Me.LTelefono = New System.Windows.Forms.Label()
        Me.LDirección = New System.Windows.Forms.Label()
        Me.LFechaNac = New System.Windows.Forms.Label()
        Me.LDni = New System.Windows.Forms.Label()
        Me.LNombres = New System.Windows.Forms.Label()
        Me.ChBApellido = New System.Windows.Forms.CheckBox()
        Me.ChBDni = New System.Windows.Forms.CheckBox()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.AgregarEmpleados = New System.Windows.Forms.TabPage()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.DTFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.DTFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.LSexo = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.LCorreo1 = New System.Windows.Forms.Label()
        Me.LTelefono1 = New System.Windows.Forms.Label()
        Me.LDireccion1 = New System.Windows.Forms.Label()
        Me.LDNI1 = New System.Windows.Forms.Label()
        Me.LFechaNacimiento = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GestionarEmpleados.SuspendLayout()
        Me.ConsultarEmpleados.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EditarEmpleados.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.AgregarEmpleados.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GestionarEmpleados
        '
        Me.GestionarEmpleados.Controls.Add(Me.ConsultarEmpleados)
        Me.GestionarEmpleados.Controls.Add(Me.EditarEmpleados)
        Me.GestionarEmpleados.Controls.Add(Me.AgregarEmpleados)
        Me.GestionarEmpleados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GestionarEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GestionarEmpleados.Location = New System.Drawing.Point(0, 0)
        Me.GestionarEmpleados.Name = "GestionarEmpleados"
        Me.GestionarEmpleados.SelectedIndex = 0
        Me.GestionarEmpleados.Size = New System.Drawing.Size(966, 576)
        Me.GestionarEmpleados.TabIndex = 1
        '
        'ConsultarEmpleados
        '
        Me.ConsultarEmpleados.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ConsultarEmpleados.Controls.Add(Me.Label12)
        Me.ConsultarEmpleados.Controls.Add(Me.BLimpiarFiltros)
        Me.ConsultarEmpleados.Controls.Add(Me.Label1)
        Me.ConsultarEmpleados.Controls.Add(Me.TextBox3)
        Me.ConsultarEmpleados.Controls.Add(Me.TextBox4)
        Me.ConsultarEmpleados.Controls.Add(Me.Button1)
        Me.ConsultarEmpleados.Controls.Add(Me.Panel3)
        Me.ConsultarEmpleados.Controls.Add(Me.CheckBox1)
        Me.ConsultarEmpleados.Controls.Add(Me.CheckBox2)
        Me.ConsultarEmpleados.Location = New System.Drawing.Point(4, 25)
        Me.ConsultarEmpleados.Name = "ConsultarEmpleados"
        Me.ConsultarEmpleados.Padding = New System.Windows.Forms.Padding(3)
        Me.ConsultarEmpleados.Size = New System.Drawing.Size(958, 547)
        Me.ConsultarEmpleados.TabIndex = 0
        Me.ConsultarEmpleados.Text = "Consultar Empelados"
        '
        'BLimpiarFiltros
        '
        Me.BLimpiarFiltros.Image = CType(resources.GetObject("BLimpiarFiltros.Image"), System.Drawing.Image)
        Me.BLimpiarFiltros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BLimpiarFiltros.Location = New System.Drawing.Point(269, 167)
        Me.BLimpiarFiltros.Name = "BLimpiarFiltros"
        Me.BLimpiarFiltros.Size = New System.Drawing.Size(421, 42)
        Me.BLimpiarFiltros.TabIndex = 16
        Me.BLimpiarFiltros.Text = "Limpiar Filtros y mostrar todos los resultados"
        Me.BLimpiarFiltros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BLimpiarFiltros.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BLimpiarFiltros.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(356, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Seleccionar un filtro de búsqueda"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(308, 117)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(214, 22)
        Me.TextBox3.TabIndex = 13
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(308, 69)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(214, 22)
        Me.TextBox4.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(553, 80)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(194, 48)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Buscar Empleado"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.DataGridView2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(3, 252)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(952, 292)
        Me.Panel3.TabIndex = 10
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel4.Controls.Add(Me.LEstado2)
        Me.Panel4.Controls.Add(Me.LEstado)
        Me.Panel4.Controls.Add(Me.LCorreo2)
        Me.Panel4.Controls.Add(Me.LTelefono2)
        Me.Panel4.Controls.Add(Me.LDireccion2)
        Me.Panel4.Controls.Add(Me.LFechaNac2)
        Me.Panel4.Controls.Add(Me.LDni2)
        Me.Panel4.Controls.Add(Me.LApeyNom)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(549, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(403, 292)
        Me.Panel4.TabIndex = 1
        '
        'LEstado2
        '
        Me.LEstado2.AutoSize = True
        Me.LEstado2.Location = New System.Drawing.Point(196, 264)
        Me.LEstado2.Name = "LEstado2"
        Me.LEstado2.Size = New System.Drawing.Size(56, 16)
        Me.LEstado2.TabIndex = 13
        Me.LEstado2.Text = "            "
        '
        'LEstado
        '
        Me.LEstado.AutoSize = True
        Me.LEstado.Location = New System.Drawing.Point(109, 264)
        Me.LEstado.Name = "LEstado"
        Me.LEstado.Size = New System.Drawing.Size(61, 16)
        Me.LEstado.TabIndex = 12
        Me.LEstado.Text = "Estado:"
        '
        'LCorreo2
        '
        Me.LCorreo2.AutoSize = True
        Me.LCorreo2.Location = New System.Drawing.Point(196, 230)
        Me.LCorreo2.Name = "LCorreo2"
        Me.LCorreo2.Size = New System.Drawing.Size(56, 16)
        Me.LCorreo2.TabIndex = 11
        Me.LCorreo2.Text = "            "
        '
        'LTelefono2
        '
        Me.LTelefono2.AutoSize = True
        Me.LTelefono2.Location = New System.Drawing.Point(196, 190)
        Me.LTelefono2.Name = "LTelefono2"
        Me.LTelefono2.Size = New System.Drawing.Size(56, 16)
        Me.LTelefono2.TabIndex = 10
        Me.LTelefono2.Text = "            "
        '
        'LDireccion2
        '
        Me.LDireccion2.AutoSize = True
        Me.LDireccion2.Location = New System.Drawing.Point(196, 150)
        Me.LDireccion2.Name = "LDireccion2"
        Me.LDireccion2.Size = New System.Drawing.Size(56, 16)
        Me.LDireccion2.TabIndex = 9
        Me.LDireccion2.Text = "            "
        '
        'LFechaNac2
        '
        Me.LFechaNac2.AutoSize = True
        Me.LFechaNac2.Location = New System.Drawing.Point(196, 110)
        Me.LFechaNac2.Name = "LFechaNac2"
        Me.LFechaNac2.Size = New System.Drawing.Size(56, 16)
        Me.LFechaNac2.TabIndex = 8
        Me.LFechaNac2.Text = "            "
        '
        'LDni2
        '
        Me.LDni2.AutoSize = True
        Me.LDni2.Location = New System.Drawing.Point(196, 70)
        Me.LDni2.Name = "LDni2"
        Me.LDni2.Size = New System.Drawing.Size(56, 16)
        Me.LDni2.TabIndex = 7
        Me.LDni2.Text = "            "
        '
        'LApeyNom
        '
        Me.LApeyNom.AutoSize = True
        Me.LApeyNom.Location = New System.Drawing.Point(196, 30)
        Me.LApeyNom.Name = "LApeyNom"
        Me.LApeyNom.Size = New System.Drawing.Size(56, 16)
        Me.LApeyNom.TabIndex = 6
        Me.LApeyNom.Text = "            "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(111, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Correo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(96, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Teléfono:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(96, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Dirección:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Fecha de Nacimiento:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(136, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 16)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "DNI:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Apellido y nombre:"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Left
        Me.DataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(543, 292)
        Me.DataGridView2.TabIndex = 0
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(207, 119)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(85, 20)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Apellido"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(207, 69)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(50, 20)
        Me.CheckBox2.TabIndex = 8
        Me.CheckBox2.Text = "Dni"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'EditarEmpleados
        '
        Me.EditarEmpleados.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.EditarEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EditarEmpleados.Controls.Add(Me.Label11)
        Me.EditarEmpleados.Controls.Add(Me.LTitulo)
        Me.EditarEmpleados.Controls.Add(Me.TextBox2)
        Me.EditarEmpleados.Controls.Add(Me.TextBox1)
        Me.EditarEmpleados.Controls.Add(Me.Panel1)
        Me.EditarEmpleados.Controls.Add(Me.ChBApellido)
        Me.EditarEmpleados.Controls.Add(Me.ChBDni)
        Me.EditarEmpleados.Controls.Add(Me.BBuscar)
        Me.EditarEmpleados.Location = New System.Drawing.Point(4, 25)
        Me.EditarEmpleados.Name = "EditarEmpleados"
        Me.EditarEmpleados.Padding = New System.Windows.Forms.Padding(3)
        Me.EditarEmpleados.Size = New System.Drawing.Size(958, 547)
        Me.EditarEmpleados.TabIndex = 1
        Me.EditarEmpleados.Text = "Editar Empleados"
        '
        'LTitulo
        '
        Me.LTitulo.AutoSize = True
        Me.LTitulo.Location = New System.Drawing.Point(357, 15)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(240, 16)
        Me.LTitulo.TabIndex = 7
        Me.LTitulo.Text = "Seleccionar un filtro de búsqueda"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(312, 99)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(214, 22)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(312, 56)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(214, 22)
        Me.TextBox1.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(3, 168)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(950, 374)
        Me.Panel1.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Left
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(543, 374)
        Me.DataGridView1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel2.Controls.Add(Me.TApellidos)
        Me.Panel2.Controls.Add(Me.LApellidos)
        Me.Panel2.Controls.Add(Me.DTFechaNac)
        Me.Panel2.Controls.Add(Me.BRCambios)
        Me.Panel2.Controls.Add(Me.BCambios)
        Me.Panel2.Controls.Add(Me.TCorreo)
        Me.Panel2.Controls.Add(Me.TTelefono)
        Me.Panel2.Controls.Add(Me.TDireccion)
        Me.Panel2.Controls.Add(Me.TDni)
        Me.Panel2.Controls.Add(Me.TNombres)
        Me.Panel2.Controls.Add(Me.LCorreo)
        Me.Panel2.Controls.Add(Me.LTelefono)
        Me.Panel2.Controls.Add(Me.LDirección)
        Me.Panel2.Controls.Add(Me.LFechaNac)
        Me.Panel2.Controls.Add(Me.LDni)
        Me.Panel2.Controls.Add(Me.LNombres)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(549, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(401, 374)
        Me.Panel2.TabIndex = 1
        '
        'TApellidos
        '
        Me.TApellidos.Location = New System.Drawing.Point(189, 12)
        Me.TApellidos.Name = "TApellidos"
        Me.TApellidos.Size = New System.Drawing.Size(199, 22)
        Me.TApellidos.TabIndex = 16
        '
        'LApellidos
        '
        Me.LApellidos.AutoSize = True
        Me.LApellidos.Location = New System.Drawing.Point(96, 15)
        Me.LApellidos.Name = "LApellidos"
        Me.LApellidos.Size = New System.Drawing.Size(83, 16)
        Me.LApellidos.TabIndex = 15
        Me.LApellidos.Text = "Apellido/s:"
        '
        'DTFechaNac
        '
        Me.DTFechaNac.Location = New System.Drawing.Point(188, 131)
        Me.DTFechaNac.Name = "DTFechaNac"
        Me.DTFechaNac.Size = New System.Drawing.Size(200, 22)
        Me.DTFechaNac.TabIndex = 14
        '
        'BRCambios
        '
        Me.BRCambios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BRCambios.Image = CType(resources.GetObject("BRCambios.Image"), System.Drawing.Image)
        Me.BRCambios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BRCambios.Location = New System.Drawing.Point(12, 311)
        Me.BRCambios.Name = "BRCambios"
        Me.BRCambios.Size = New System.Drawing.Size(172, 48)
        Me.BRCambios.TabIndex = 13
        Me.BRCambios.Text = "Realizar Cambios"
        Me.BRCambios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BRCambios.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BRCambios.UseVisualStyleBackColor = True
        '
        'BCambios
        '
        Me.BCambios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCambios.Image = Global.Proyecto2023.My.Resources.Resources.sign_check_icon_34365
        Me.BCambios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BCambios.Location = New System.Drawing.Point(212, 311)
        Me.BCambios.Name = "BCambios"
        Me.BCambios.Size = New System.Drawing.Size(176, 48)
        Me.BCambios.TabIndex = 12
        Me.BCambios.Text = "Confirmar Cambios"
        Me.BCambios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BCambios.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BCambios.UseVisualStyleBackColor = True
        Me.BCambios.Visible = False
        '
        'TCorreo
        '
        Me.TCorreo.Location = New System.Drawing.Point(189, 259)
        Me.TCorreo.Name = "TCorreo"
        Me.TCorreo.Size = New System.Drawing.Size(199, 22)
        Me.TCorreo.TabIndex = 11
        '
        'TTelefono
        '
        Me.TTelefono.Location = New System.Drawing.Point(189, 220)
        Me.TTelefono.Name = "TTelefono"
        Me.TTelefono.Size = New System.Drawing.Size(199, 22)
        Me.TTelefono.TabIndex = 10
        '
        'TDireccion
        '
        Me.TDireccion.Location = New System.Drawing.Point(189, 176)
        Me.TDireccion.Name = "TDireccion"
        Me.TDireccion.Size = New System.Drawing.Size(199, 22)
        Me.TDireccion.TabIndex = 9
        '
        'TDni
        '
        Me.TDni.Location = New System.Drawing.Point(189, 94)
        Me.TDni.Name = "TDni"
        Me.TDni.Size = New System.Drawing.Size(199, 22)
        Me.TDni.TabIndex = 7
        '
        'TNombres
        '
        Me.TNombres.Location = New System.Drawing.Point(189, 55)
        Me.TNombres.Name = "TNombres"
        Me.TNombres.Size = New System.Drawing.Size(199, 22)
        Me.TNombres.TabIndex = 6
        '
        'LCorreo
        '
        Me.LCorreo.AutoSize = True
        Me.LCorreo.Location = New System.Drawing.Point(120, 262)
        Me.LCorreo.Name = "LCorreo"
        Me.LCorreo.Size = New System.Drawing.Size(59, 16)
        Me.LCorreo.TabIndex = 5
        Me.LCorreo.Text = "Correo:"
        '
        'LTelefono
        '
        Me.LTelefono.AutoSize = True
        Me.LTelefono.Location = New System.Drawing.Point(105, 223)
        Me.LTelefono.Name = "LTelefono"
        Me.LTelefono.Size = New System.Drawing.Size(74, 16)
        Me.LTelefono.TabIndex = 4
        Me.LTelefono.Text = "Teléfono:"
        '
        'LDirección
        '
        Me.LDirección.AutoSize = True
        Me.LDirección.Location = New System.Drawing.Point(101, 179)
        Me.LDirección.Name = "LDirección"
        Me.LDirección.Size = New System.Drawing.Size(78, 16)
        Me.LDirección.TabIndex = 3
        Me.LDirección.Text = "Dirección:"
        '
        'LFechaNac
        '
        Me.LFechaNac.AutoSize = True
        Me.LFechaNac.Location = New System.Drawing.Point(20, 136)
        Me.LFechaNac.Name = "LFechaNac"
        Me.LFechaNac.Size = New System.Drawing.Size(159, 16)
        Me.LFechaNac.TabIndex = 2
        Me.LFechaNac.Text = "Fecha de Nacimiento:"
        '
        'LDni
        '
        Me.LDni.AutoSize = True
        Me.LDni.Location = New System.Drawing.Point(141, 97)
        Me.LDni.Name = "LDni"
        Me.LDni.Size = New System.Drawing.Size(38, 16)
        Me.LDni.TabIndex = 1
        Me.LDni.Text = "DNI:"
        '
        'LNombres
        '
        Me.LNombres.AutoSize = True
        Me.LNombres.Location = New System.Drawing.Point(99, 58)
        Me.LNombres.Name = "LNombres"
        Me.LNombres.Size = New System.Drawing.Size(80, 16)
        Me.LNombres.TabIndex = 0
        Me.LNombres.Text = "Nombre/s:"
        '
        'ChBApellido
        '
        Me.ChBApellido.AutoSize = True
        Me.ChBApellido.Location = New System.Drawing.Point(211, 101)
        Me.ChBApellido.Name = "ChBApellido"
        Me.ChBApellido.Size = New System.Drawing.Size(85, 20)
        Me.ChBApellido.TabIndex = 2
        Me.ChBApellido.Text = "Apellido"
        Me.ChBApellido.UseVisualStyleBackColor = True
        '
        'ChBDni
        '
        Me.ChBDni.AutoSize = True
        Me.ChBDni.Location = New System.Drawing.Point(211, 58)
        Me.ChBDni.Name = "ChBDni"
        Me.ChBDni.Size = New System.Drawing.Size(50, 20)
        Me.ChBDni.TabIndex = 1
        Me.ChBDni.Text = "Dni"
        Me.ChBDni.UseVisualStyleBackColor = True
        '
        'BBuscar
        '
        Me.BBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BBuscar.ForeColor = System.Drawing.SystemColors.Control
        Me.BBuscar.Image = CType(resources.GetObject("BBuscar.Image"), System.Drawing.Image)
        Me.BBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BBuscar.Location = New System.Drawing.Point(564, 58)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(195, 55)
        Me.BBuscar.TabIndex = 4
        Me.BBuscar.Text = "Buscar Empleado"
        Me.BBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BBuscar.UseVisualStyleBackColor = False
        '
        'AgregarEmpleados
        '
        Me.AgregarEmpleados.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.AgregarEmpleados.Controls.Add(Me.Button9)
        Me.AgregarEmpleados.Controls.Add(Me.Button3)
        Me.AgregarEmpleados.Controls.Add(Me.Button2)
        Me.AgregarEmpleados.Controls.Add(Me.TextBox11)
        Me.AgregarEmpleados.Controls.Add(Me.Label8)
        Me.AgregarEmpleados.Controls.Add(Me.Panel6)
        Me.AgregarEmpleados.Location = New System.Drawing.Point(4, 25)
        Me.AgregarEmpleados.Name = "AgregarEmpleados"
        Me.AgregarEmpleados.Size = New System.Drawing.Size(958, 547)
        Me.AgregarEmpleados.TabIndex = 2
        Me.AgregarEmpleados.Text = "Agregar Empleados"
        '
        'Button9
        '
        Me.Button9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button9.Image = CType(resources.GetObject("Button9.Image"), System.Drawing.Image)
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.Location = New System.Drawing.Point(83, 457)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(221, 49)
        Me.Button9.TabIndex = 33
        Me.Button9.Text = "Volver para cambiar el nombre del producto"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.Proyecto2023.My.Resources.Resources.sign_check_icon_34365
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(694, 459)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(188, 45)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Confirmar Datos"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.Proyecto2023.My.Resources.Resources.searchcircularbutton_79274
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(660, 51)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 42)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Buscar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(660, 23)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(198, 22)
        Me.TextBox11.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(102, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(552, 16)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Ingresar DNI del nuevo empleado para comprobar que  no existe en el sistema"
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.ComboBox2)
        Me.Panel6.Controls.Add(Me.DTFechaIngreso)
        Me.Panel6.Controls.Add(Me.Label10)
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Controls.Add(Me.TextBox7)
        Me.Panel6.Controls.Add(Me.TextBox6)
        Me.Panel6.Controls.Add(Me.TextBox5)
        Me.Panel6.Controls.Add(Me.DTFechaNacimiento)
        Me.Panel6.Controls.Add(Me.TextBox10)
        Me.Panel6.Controls.Add(Me.TextBox9)
        Me.Panel6.Controls.Add(Me.LSexo)
        Me.Panel6.Controls.Add(Me.TextBox8)
        Me.Panel6.Controls.Add(Me.LCorreo1)
        Me.Panel6.Controls.Add(Me.LTelefono1)
        Me.Panel6.Controls.Add(Me.LDireccion1)
        Me.Panel6.Controls.Add(Me.LDNI1)
        Me.Panel6.Controls.Add(Me.LFechaNacimiento)
        Me.Panel6.Controls.Add(Me.LNombre)
        Me.Panel6.Controls.Add(Me.LApellido)
        Me.Panel6.Location = New System.Drawing.Point(83, 113)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(799, 310)
        Me.Panel6.TabIndex = 22
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Hombre", "Mujer", "Indefinido"})
        Me.ComboBox2.Location = New System.Drawing.Point(545, 208)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(226, 24)
        Me.ComboBox2.TabIndex = 27
        '
        'DTFechaIngreso
        '
        Me.DTFechaIngreso.Location = New System.Drawing.Point(191, 255)
        Me.DTFechaIngreso.Name = "DTFechaIngreso"
        Me.DTFechaIngreso.Size = New System.Drawing.Size(198, 22)
        Me.DTFechaIngreso.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(39, 260)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(129, 16)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Fecha de Ingreso"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(171, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(453, 18)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Completar los campos para el registro del nuevo empleado"
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
        'DTFechaNacimiento
        '
        Me.DTFechaNacimiento.Location = New System.Drawing.Point(194, 164)
        Me.DTFechaNacimiento.Name = "DTFechaNacimiento"
        Me.DTFechaNacimiento.Size = New System.Drawing.Size(198, 22)
        Me.DTFechaNacimiento.TabIndex = 9
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(545, 163)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(227, 22)
        Me.TextBox10.TabIndex = 15
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(545, 119)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(227, 22)
        Me.TextBox9.TabIndex = 14
        '
        'LSexo
        '
        Me.LSexo.AutoSize = True
        Me.LSexo.Location = New System.Drawing.Point(495, 213)
        Me.LSexo.Name = "LSexo"
        Me.LSexo.Size = New System.Drawing.Size(43, 16)
        Me.LSexo.TabIndex = 7
        Me.LSexo.Text = "Sexo"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(545, 78)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(227, 22)
        Me.TextBox8.TabIndex = 13
        '
        'LCorreo1
        '
        Me.LCorreo1.AutoSize = True
        Me.LCorreo1.Location = New System.Drawing.Point(484, 169)
        Me.LCorreo1.Name = "LCorreo1"
        Me.LCorreo1.Size = New System.Drawing.Size(55, 16)
        Me.LCorreo1.TabIndex = 6
        Me.LCorreo1.Text = "Correo"
        '
        'LTelefono1
        '
        Me.LTelefono1.AutoSize = True
        Me.LTelefono1.Location = New System.Drawing.Point(469, 125)
        Me.LTelefono1.Name = "LTelefono1"
        Me.LTelefono1.Size = New System.Drawing.Size(70, 16)
        Me.LTelefono1.TabIndex = 5
        Me.LTelefono1.Text = "Telefono"
        '
        'LDireccion1
        '
        Me.LDireccion1.AutoSize = True
        Me.LDireccion1.Location = New System.Drawing.Point(465, 81)
        Me.LDireccion1.Name = "LDireccion1"
        Me.LDireccion1.Size = New System.Drawing.Size(74, 16)
        Me.LDireccion1.TabIndex = 4
        Me.LDireccion1.Text = "Direccion"
        '
        'LDNI1
        '
        Me.LDNI1.AutoSize = True
        Me.LDNI1.Location = New System.Drawing.Point(137, 213)
        Me.LDNI1.Name = "LDNI1"
        Me.LDNI1.Size = New System.Drawing.Size(34, 16)
        Me.LDNI1.TabIndex = 3
        Me.LDNI1.Text = "DNI"
        '
        'LFechaNacimiento
        '
        Me.LFechaNacimiento.AutoSize = True
        Me.LFechaNacimiento.Location = New System.Drawing.Point(19, 166)
        Me.LFechaNacimiento.Name = "LFechaNacimiento"
        Me.LFechaNacimiento.Size = New System.Drawing.Size(152, 16)
        Me.LFechaNacimiento.TabIndex = 2
        Me.LFechaNacimiento.Text = "Fecha de nacimiento"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Location = New System.Drawing.Point(95, 125)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(76, 16)
        Me.LNombre.TabIndex = 1
        Me.LNombre.Text = "Nombre/s"
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.Location = New System.Drawing.Point(105, 81)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(66, 16)
        Me.LApellido.TabIndex = 0
        Me.LApellido.Text = "Apellido"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(7, 149)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(398, 16)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Para seleccionar un empleado, hacer doble click sobre el mismo."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label12.Location = New System.Drawing.Point(8, 233)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(398, 16)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Para seleccionar un empleado, hacer doble click sobre el mismo."
        '
        'Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 576)
        Me.Controls.Add(Me.GestionarEmpleados)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Empleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Empleados"
        Me.GestionarEmpleados.ResumeLayout(False)
        Me.ConsultarEmpleados.ResumeLayout(False)
        Me.ConsultarEmpleados.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EditarEmpleados.ResumeLayout(False)
        Me.EditarEmpleados.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.AgregarEmpleados.ResumeLayout(False)
        Me.AgregarEmpleados.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GestionarEmpleados As TabControl
    Friend WithEvents ConsultarEmpleados As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents EditarEmpleados As TabPage
    Friend WithEvents LTitulo As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BBuscar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BCambios As Button
    Friend WithEvents TCorreo As TextBox
    Friend WithEvents TTelefono As TextBox
    Friend WithEvents TDireccion As TextBox
    Friend WithEvents TDni As TextBox
    Friend WithEvents TNombres As TextBox
    Friend WithEvents LCorreo As Label
    Friend WithEvents LTelefono As Label
    Friend WithEvents LDirección As Label
    Friend WithEvents LFechaNac As Label
    Friend WithEvents LDni As Label
    Friend WithEvents LNombres As Label
    Friend WithEvents ChBApellido As CheckBox
    Friend WithEvents ChBDni As CheckBox
    Friend WithEvents AgregarEmpleados As TabPage
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents DTFechaNacimiento As DateTimePicker
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents LSexo As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents LCorreo1 As Label
    Friend WithEvents LTelefono1 As Label
    Friend WithEvents LDireccion1 As Label
    Friend WithEvents LDNI1 As Label
    Friend WithEvents LFechaNacimiento As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents LApellido As Label
    Friend WithEvents BRCambios As Button
    Friend WithEvents DTFechaNac As DateTimePicker
    Friend WithEvents DTFechaIngreso As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TApellidos As TextBox
    Friend WithEvents LApellidos As Label
    Friend WithEvents LApeyNom As Label
    Friend WithEvents LDni2 As Label
    Friend WithEvents LCorreo2 As Label
    Friend WithEvents LTelefono2 As Label
    Friend WithEvents LDireccion2 As Label
    Friend WithEvents LFechaNac2 As Label
    Friend WithEvents LEstado2 As Label
    Friend WithEvents LEstado As Label
    Friend WithEvents BLimpiarFiltros As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
End Class
