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
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.LFechaDesde = New System.Windows.Forms.Label()
        Me.LFechaHasta = New System.Windows.Forms.Label()
        Me.DateTimeDesde = New System.Windows.Forms.DateTimePicker()
        Me.DateTimeHasta = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LTitulo
        '
        Me.LTitulo.AutoSize = True
        Me.LTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LTitulo.Location = New System.Drawing.Point(295, 9)
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
        Me.LFechaDesde.Location = New System.Drawing.Point(427, 109)
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
        Me.LFechaHasta.Location = New System.Drawing.Point(433, 62)
        Me.LFechaHasta.Name = "LFechaHasta"
        Me.LFechaHasta.Size = New System.Drawing.Size(82, 16)
        Me.LFechaHasta.TabIndex = 2
        Me.LFechaHasta.Text = "Fecha hasta"
        '
        'DateTimeDesde
        '
        Me.DateTimeDesde.Location = New System.Drawing.Point(521, 105)
        Me.DateTimeDesde.Name = "DateTimeDesde"
        Me.DateTimeDesde.Size = New System.Drawing.Size(209, 20)
        Me.DateTimeDesde.TabIndex = 3
        '
        'DateTimeHasta
        '
        Me.DateTimeHasta.Location = New System.Drawing.Point(521, 58)
        Me.DateTimeHasta.Name = "DateTimeHasta"
        Me.DateTimeHasta.Size = New System.Drawing.Size(209, 20)
        Me.DateTimeHasta.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 227)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(438, 241)
        Me.DataGridView1.TabIndex = 5
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Ultimos productos agregados", "Productos eliminados", "Productos con bajo stock", "Productos mas vendidos", "Productos menos vendidos"})
        Me.ComboBox1.Location = New System.Drawing.Point(106, 57)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(230, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'Informes_Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(799, 498)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.DateTimeHasta)
        Me.Controls.Add(Me.DateTimeDesde)
        Me.Controls.Add(Me.LFechaHasta)
        Me.Controls.Add(Me.LFechaDesde)
        Me.Controls.Add(Me.LTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Informes_Productos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Informes_Productos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LTitulo As Label
    Friend WithEvents LFechaDesde As Label
    Friend WithEvents LFechaHasta As Label
    Friend WithEvents DateTimeDesde As DateTimePicker
    Friend WithEvents DateTimeHasta As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
End Class
