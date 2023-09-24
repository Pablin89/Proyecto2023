<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Informes_Cajeros
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.LFiltro = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalVendido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroVentas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateTimeHasta = New System.Windows.Forms.DateTimePicker()
        Me.DateTimeDesde = New System.Windows.Forms.DateTimePicker()
        Me.LFechaHasta = New System.Windows.Forms.Label()
        Me.LFechaDesde = New System.Windows.Forms.Label()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(341, 354)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Generar Informe"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(510, 21)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(300, 300)
        Me.Chart1.TabIndex = 18
        Me.Chart1.Text = "Chart1"
        '
        'LFiltro
        '
        Me.LFiltro.AutoSize = True
        Me.LFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFiltro.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LFiltro.Location = New System.Drawing.Point(48, 53)
        Me.LFiltro.Name = "LFiltro"
        Me.LFiltro.Size = New System.Drawing.Size(123, 16)
        Me.LFiltro.TabIndex = 17
        Me.LFiltro.Text = "Seleccionar un filtro"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Cajeros con mas ventas", "Cajeros con menos ventas", "Ultimos cajeros añadidos"})
        Me.ComboBox1.Location = New System.Drawing.Point(51, 72)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(230, 21)
        Me.ComboBox1.TabIndex = 16
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Usuario, Me.TotalVendido, Me.NroVentas})
        Me.DataGridView1.Location = New System.Drawing.Point(0, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(492, 300)
        Me.DataGridView1.TabIndex = 15
        '
        'Usuario
        '
        Me.Usuario.HeaderText = "Usuario"
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Width = 200
        '
        'TotalVendido
        '
        Me.TotalVendido.HeaderText = "Total vendido"
        Me.TotalVendido.Name = "TotalVendido"
        Me.TotalVendido.Width = 150
        '
        'NroVentas
        '
        Me.NroVentas.HeaderText = "Cantidad de Ventas"
        Me.NroVentas.Name = "NroVentas"
        '
        'DateTimeHasta
        '
        Me.DateTimeHasta.Location = New System.Drawing.Point(537, 49)
        Me.DateTimeHasta.Name = "DateTimeHasta"
        Me.DateTimeHasta.Size = New System.Drawing.Size(209, 20)
        Me.DateTimeHasta.TabIndex = 14
        '
        'DateTimeDesde
        '
        Me.DateTimeDesde.Location = New System.Drawing.Point(537, 107)
        Me.DateTimeDesde.Name = "DateTimeDesde"
        Me.DateTimeDesde.Size = New System.Drawing.Size(209, 20)
        Me.DateTimeDesde.TabIndex = 13
        '
        'LFechaHasta
        '
        Me.LFechaHasta.AutoSize = True
        Me.LFechaHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFechaHasta.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LFechaHasta.Location = New System.Drawing.Point(438, 53)
        Me.LFechaHasta.Name = "LFechaHasta"
        Me.LFechaHasta.Size = New System.Drawing.Size(81, 16)
        Me.LFechaHasta.TabIndex = 12
        Me.LFechaHasta.Text = "Fecha hasta"
        '
        'LFechaDesde
        '
        Me.LFechaDesde.AutoSize = True
        Me.LFechaDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFechaDesde.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LFechaDesde.Location = New System.Drawing.Point(432, 111)
        Me.LFechaDesde.Name = "LFechaDesde"
        Me.LFechaDesde.Size = New System.Drawing.Size(87, 16)
        Me.LFechaDesde.TabIndex = 11
        Me.LFechaDesde.Text = "Fecha desde"
        '
        'LTitulo
        '
        Me.LTitulo.AutoSize = True
        Me.LTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LTitulo.Location = New System.Drawing.Point(331, 9)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(161, 18)
        Me.LTitulo.TabIndex = 10
        Me.LTitulo.Text = "Informes de Cajeros"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Chart1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 144)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(822, 394)
        Me.Panel1.TabIndex = 20
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LFiltro)
        Me.Panel2.Controls.Add(Me.ComboBox1)
        Me.Panel2.Controls.Add(Me.DateTimeHasta)
        Me.Panel2.Controls.Add(Me.LFechaDesde)
        Me.Panel2.Controls.Add(Me.LFechaHasta)
        Me.Panel2.Controls.Add(Me.LTitulo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(822, 144)
        Me.Panel2.TabIndex = 21
        '
        'Informes_Cajeros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(822, 538)
        Me.Controls.Add(Me.DateTimeDesde)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Name = "Informes_Cajeros"
        Me.Text = "Informes_Cajeros"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents LFiltro As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DateTimeHasta As DateTimePicker
    Friend WithEvents DateTimeDesde As DateTimePicker
    Friend WithEvents LFechaHasta As Label
    Friend WithEvents LFechaDesde As Label
    Friend WithEvents LTitulo As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Usuario As DataGridViewTextBoxColumn
    Friend WithEvents TotalVendido As DataGridViewTextBoxColumn
    Friend WithEvents NroVentas As DataGridViewTextBoxColumn
End Class
