<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Informes_Productos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Informes_Productos))
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.LFechaDesde = New System.Windows.Forms.Label()
        Me.LFechaHasta = New System.Windows.Forms.Label()
        Me.DateTimeDesde = New System.Windows.Forms.DateTimePicker()
        Me.DateTimeHasta = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CBFiltro = New System.Windows.Forms.ComboBox()
        Me.LFiltro = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LCategoria = New System.Windows.Forms.Label()
        Me.CBCategoria = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroVentas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LTitulo
        '
        Me.LTitulo.AutoSize = True
        Me.LTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LTitulo.Location = New System.Drawing.Point(308, 9)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(180, 18)
        Me.LTitulo.TabIndex = 0
        Me.LTitulo.Text = "Informes de Productos"
        '
        'LFechaDesde
        '
        Me.LFechaDesde.AutoSize = True
        Me.LFechaDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFechaDesde.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LFechaDesde.Location = New System.Drawing.Point(284, 128)
        Me.LFechaDesde.Name = "LFechaDesde"
        Me.LFechaDesde.Size = New System.Drawing.Size(88, 16)
        Me.LFechaDesde.TabIndex = 1
        Me.LFechaDesde.Text = "Fecha desde"
        '
        'LFechaHasta
        '
        Me.LFechaHasta.AutoSize = True
        Me.LFechaHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFechaHasta.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LFechaHasta.Location = New System.Drawing.Point(290, 81)
        Me.LFechaHasta.Name = "LFechaHasta"
        Me.LFechaHasta.Size = New System.Drawing.Size(82, 16)
        Me.LFechaHasta.TabIndex = 2
        Me.LFechaHasta.Text = "Fecha hasta"
        '
        'DateTimeDesde
        '
        Me.DateTimeDesde.Location = New System.Drawing.Point(378, 124)
        Me.DateTimeDesde.Name = "DateTimeDesde"
        Me.DateTimeDesde.Size = New System.Drawing.Size(209, 20)
        Me.DateTimeDesde.TabIndex = 3
        '
        'DateTimeHasta
        '
        Me.DateTimeHasta.Location = New System.Drawing.Point(378, 81)
        Me.DateTimeHasta.Name = "DateTimeHasta"
        Me.DateTimeHasta.Size = New System.Drawing.Size(209, 20)
        Me.DateTimeHasta.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Categoria, Me.Stock, Me.NroVentas})
        Me.DataGridView1.Location = New System.Drawing.Point(27, 18)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(743, 300)
        Me.DataGridView1.TabIndex = 5
        '
        'CBFiltro
        '
        Me.CBFiltro.FormattingEnabled = True
        Me.CBFiltro.Items.AddRange(New Object() {"Ultimos productos agregados", "Productos eliminados", "Productos con bajo stock", "Productos mas/menos vendidos", "Productos por categorias"})
        Me.CBFiltro.Location = New System.Drawing.Point(27, 80)
        Me.CBFiltro.Name = "CBFiltro"
        Me.CBFiltro.Size = New System.Drawing.Size(232, 21)
        Me.CBFiltro.TabIndex = 6
        '
        'LFiltro
        '
        Me.LFiltro.AutoSize = True
        Me.LFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFiltro.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LFiltro.Location = New System.Drawing.Point(71, 61)
        Me.LFiltro.Name = "LFiltro"
        Me.LFiltro.Size = New System.Drawing.Size(124, 16)
        Me.LFiltro.TabIndex = 7
        Me.LFiltro.Text = "Seleccionar un filtro"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Teal
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(616, 334)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 42)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Generar Informe"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LCategoria
        '
        Me.LCategoria.AutoSize = True
        Me.LCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCategoria.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LCategoria.Location = New System.Drawing.Point(71, 104)
        Me.LCategoria.Name = "LCategoria"
        Me.LCategoria.Size = New System.Drawing.Size(140, 16)
        Me.LCategoria.TabIndex = 10
        Me.LCategoria.Text = "Seleccionar categoria"
        '
        'CBCategoria
        '
        Me.CBCategoria.FormattingEnabled = True
        Me.CBCategoria.Items.AddRange(New Object() {"Bazar", "Jugueteria", "Ferreteria", "Cotillon"})
        Me.CBCategoria.Location = New System.Drawing.Point(51, 123)
        Me.CBCategoria.Name = "CBCategoria"
        Me.CBCategoria.Size = New System.Drawing.Size(191, 21)
        Me.CBCategoria.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.CBCategoria)
        Me.Panel1.Controls.Add(Me.LCategoria)
        Me.Panel1.Controls.Add(Me.LFiltro)
        Me.Panel1.Controls.Add(Me.CBFiltro)
        Me.Panel1.Controls.Add(Me.DateTimeHasta)
        Me.Panel1.Controls.Add(Me.DateTimeDesde)
        Me.Panel1.Controls.Add(Me.LFechaHasta)
        Me.Panel1.Controls.Add(Me.LFechaDesde)
        Me.Panel1.Controls.Add(Me.LTitulo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(799, 175)
        Me.Panel1.TabIndex = 12
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 175)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(799, 397)
        Me.Panel2.TabIndex = 13
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre del Producto"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 300
        '
        'Categoria
        '
        Me.Categoria.HeaderText = "Categoria"
        Me.Categoria.Name = "Categoria"
        Me.Categoria.Width = 200
        '
        'Stock
        '
        Me.Stock.HeaderText = "Stock"
        Me.Stock.Name = "Stock"
        '
        'NroVentas
        '
        Me.NroVentas.HeaderText = "Cantidad de Ventas"
        Me.NroVentas.Name = "NroVentas"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SteelBlue
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(616, 92)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(154, 41)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Aplicar Filtros"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(27, 333)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(152, 45)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "Limpiar Filtros"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Informes_Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(799, 572)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Informes_Productos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Informes_Productos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LTitulo As Label
    Friend WithEvents LFechaDesde As Label
    Friend WithEvents LFechaHasta As Label
    Friend WithEvents DateTimeDesde As DateTimePicker
    Friend WithEvents DateTimeHasta As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CBFiltro As ComboBox
    Friend WithEvents LFiltro As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents LCategoria As Label
    Friend WithEvents CBCategoria As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Categoria As DataGridViewTextBoxColumn
    Friend WithEvents Stock As DataGridViewTextBoxColumn
    Friend WithEvents NroVentas As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
