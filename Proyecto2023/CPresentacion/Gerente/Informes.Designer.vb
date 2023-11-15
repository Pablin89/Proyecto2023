<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Informes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Informes))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LFiltro = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DateTimeHasta = New System.Windows.Forms.DateTimePicker()
        Me.DateTimeDesde = New System.Windows.Forms.DateTimePicker()
        Me.LFechaHasta = New System.Windows.Forms.Label()
        Me.LFechaDesde = New System.Windows.Forms.Label()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LFiltroSeleccionado = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LFiltro
        '
        Me.LFiltro.AutoSize = True
        Me.LFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFiltro.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LFiltro.Location = New System.Drawing.Point(69, 42)
        Me.LFiltro.Name = "LFiltro"
        Me.LFiltro.Size = New System.Drawing.Size(124, 16)
        Me.LFiltro.TabIndex = 17
        Me.LFiltro.Text = "Seleccionar un filtro"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(41, 75)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(215, 21)
        Me.ComboBox1.TabIndex = 16
        '
        'DateTimeHasta
        '
        Me.DateTimeHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimeHasta.Location = New System.Drawing.Point(382, 106)
        Me.DateTimeHasta.Name = "DateTimeHasta"
        Me.DateTimeHasta.Size = New System.Drawing.Size(197, 20)
        Me.DateTimeHasta.TabIndex = 14
        Me.DateTimeHasta.Value = New Date(2023, 11, 15, 0, 0, 0, 0)
        Me.DateTimeHasta.Visible = False
        '
        'DateTimeDesde
        '
        Me.DateTimeDesde.CustomFormat = ""
        Me.DateTimeDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimeDesde.Location = New System.Drawing.Point(382, 64)
        Me.DateTimeDesde.Name = "DateTimeDesde"
        Me.DateTimeDesde.Size = New System.Drawing.Size(197, 20)
        Me.DateTimeDesde.TabIndex = 13
        Me.DateTimeDesde.Value = New Date(2023, 11, 15, 0, 0, 0, 0)
        Me.DateTimeDesde.Visible = False
        '
        'LFechaHasta
        '
        Me.LFechaHasta.AutoSize = True
        Me.LFechaHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFechaHasta.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LFechaHasta.Location = New System.Drawing.Point(273, 110)
        Me.LFechaHasta.Name = "LFechaHasta"
        Me.LFechaHasta.Size = New System.Drawing.Size(82, 16)
        Me.LFechaHasta.TabIndex = 12
        Me.LFechaHasta.Text = "Fecha hasta"
        Me.LFechaHasta.Visible = False
        '
        'LFechaDesde
        '
        Me.LFechaDesde.AutoSize = True
        Me.LFechaDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFechaDesde.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LFechaDesde.Location = New System.Drawing.Point(273, 65)
        Me.LFechaDesde.Name = "LFechaDesde"
        Me.LFechaDesde.Size = New System.Drawing.Size(88, 16)
        Me.LFechaDesde.TabIndex = 11
        Me.LFechaDesde.Text = "Fecha desde"
        Me.LFechaDesde.Visible = False
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
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 144)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(805, 394)
        Me.Panel1.TabIndex = 20
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Teal
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(609, 326)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 45)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Generar Informe"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LFiltroSeleccionado)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.DateTimeDesde)
        Me.Panel2.Controls.Add(Me.LFiltro)
        Me.Panel2.Controls.Add(Me.ComboBox1)
        Me.Panel2.Controls.Add(Me.DateTimeHasta)
        Me.Panel2.Controls.Add(Me.LFechaDesde)
        Me.Panel2.Controls.Add(Me.LFechaHasta)
        Me.Panel2.Controls.Add(Me.LTitulo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(805, 144)
        Me.Panel2.TabIndex = 21
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SteelBlue
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(609, 65)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(157, 41)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Aplicar Filtros"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button2.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(101, 6)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Size = New System.Drawing.Size(596, 299)
        Me.DataGridView1.TabIndex = 22
        '
        'LFiltroSeleccionado
        '
        Me.LFiltroSeleccionado.AutoSize = True
        Me.LFiltroSeleccionado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFiltroSeleccionado.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LFiltroSeleccionado.Location = New System.Drawing.Point(106, 123)
        Me.LFiltroSeleccionado.Name = "LFiltroSeleccionado"
        Me.LFiltroSeleccionado.Size = New System.Drawing.Size(47, 18)
        Me.LFiltroSeleccionado.TabIndex = 21
        Me.LFiltroSeleccionado.Text = "Filtro"
        '
        'Informes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(805, 538)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Informes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informes_Cajeros"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents LFiltro As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimeHasta As DateTimePicker
    Friend WithEvents DateTimeDesde As DateTimePicker
    Friend WithEvents LFechaHasta As Label
    Friend WithEvents LFechaDesde As Label
    Friend WithEvents LTitulo As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LFiltroSeleccionado As Label
End Class
