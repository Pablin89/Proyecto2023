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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Informes_Productos))
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.LFechaDesde = New System.Windows.Forms.Label()
        Me.LFechaHasta = New System.Windows.Forms.Label()
        Me.DateTimeDesde = New System.Windows.Forms.DateTimePicker()
        Me.DateTimeHasta = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroVentas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CBFiltro = New System.Windows.Forms.ComboBox()
        Me.LFiltro = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LCategoria = New System.Windows.Forms.Label()
        Me.CBCategoria = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LFechaDesde.Location = New System.Drawing.Point(434, 128)
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
        Me.LFechaHasta.Location = New System.Drawing.Point(440, 81)
        Me.LFechaHasta.Name = "LFechaHasta"
        Me.LFechaHasta.Size = New System.Drawing.Size(82, 16)
        Me.LFechaHasta.TabIndex = 2
        Me.LFechaHasta.Text = "Fecha hasta"
        '
        'DateTimeDesde
        '
        Me.DateTimeDesde.Location = New System.Drawing.Point(528, 124)
        Me.DateTimeDesde.Name = "DateTimeDesde"
        Me.DateTimeDesde.Size = New System.Drawing.Size(209, 20)
        Me.DateTimeDesde.TabIndex = 3
        '
        'DateTimeHasta
        '
        Me.DateTimeHasta.Location = New System.Drawing.Point(528, 77)
        Me.DateTimeHasta.Name = "DateTimeHasta"
        Me.DateTimeHasta.Size = New System.Drawing.Size(209, 20)
        Me.DateTimeHasta.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Categoria, Me.Stock, Me.NroVentas})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 18)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(453, 300)
        Me.DataGridView1.TabIndex = 5
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 120
        '
        'Categoria
        '
        Me.Categoria.HeaderText = "Categoria"
        Me.Categoria.Name = "Categoria"
        '
        'Stock
        '
        Me.Stock.HeaderText = "Stock"
        Me.Stock.Name = "Stock"
        Me.Stock.Width = 80
        '
        'NroVentas
        '
        Me.NroVentas.HeaderText = "Cantidad de Ventas"
        Me.NroVentas.Name = "NroVentas"
        '
        'CBFiltro
        '
        Me.CBFiltro.FormattingEnabled = True
        Me.CBFiltro.Items.AddRange(New Object() {"Ultimos productos agregados", "Productos eliminados", "Productos con bajo stock", "Productos mas vendidos", "Productos menos vendidos", "Productos por categorias"})
        Me.CBFiltro.Location = New System.Drawing.Point(64, 76)
        Me.CBFiltro.Name = "CBFiltro"
        Me.CBFiltro.Size = New System.Drawing.Size(334, 21)
        Me.CBFiltro.TabIndex = 6
        '
        'LFiltro
        '
        Me.LFiltro.AutoSize = True
        Me.LFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFiltro.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LFiltro.Location = New System.Drawing.Point(61, 51)
        Me.LFiltro.Name = "LFiltro"
        Me.LFiltro.Size = New System.Drawing.Size(124, 16)
        Me.LFiltro.TabIndex = 7
        Me.LFiltro.Text = "Seleccionar un filtro"
        '
        'Chart1
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(487, 18)
        Me.Chart1.Name = "Chart1"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(300, 300)
        Me.Chart1.TabIndex = 8
        Me.Chart1.Text = "Chart1"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Teal
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(334, 340)
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
        Me.LCategoria.Location = New System.Drawing.Point(61, 124)
        Me.LCategoria.Name = "LCategoria"
        Me.LCategoria.Size = New System.Drawing.Size(140, 16)
        Me.LCategoria.TabIndex = 10
        Me.LCategoria.Text = "Seleccionar categoria"
        '
        'CBCategoria
        '
        Me.CBCategoria.FormattingEnabled = True
        Me.CBCategoria.Items.AddRange(New Object() {"Bazar", "Jugueteria", "Ferreteria", "Cotillon"})
        Me.CBCategoria.Location = New System.Drawing.Point(207, 123)
        Me.CBCategoria.Name = "CBCategoria"
        Me.CBCategoria.Size = New System.Drawing.Size(191, 21)
        Me.CBCategoria.TabIndex = 11
        '
        'Panel1
        '
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
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Chart1)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 175)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(799, 397)
        Me.Panel2.TabIndex = 13
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
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Button1 As Button
    Friend WithEvents LCategoria As Label
    Friend WithEvents CBCategoria As ComboBox
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Categoria As DataGridViewTextBoxColumn
    Friend WithEvents Stock As DataGridViewTextBoxColumn
    Friend WithEvents NroVentas As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
