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
        Me.EditarProductos = New System.Windows.Forms.TabPage()
        Me.AgregarProductos = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LNombrepro = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GestionarProductos.SuspendLayout()
        Me.ConsultarProductos.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
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
        Me.ConsultarProductos.Controls.Add(Me.CheckBox1)
        Me.ConsultarProductos.Controls.Add(Me.Panel1)
        Me.ConsultarProductos.Location = New System.Drawing.Point(4, 28)
        Me.ConsultarProductos.Name = "ConsultarProductos"
        Me.ConsultarProductos.Padding = New System.Windows.Forms.Padding(3)
        Me.ConsultarProductos.Size = New System.Drawing.Size(806, 589)
        Me.ConsultarProductos.TabIndex = 0
        Me.ConsultarProductos.Text = "Consultar Productos"
        '
        'EditarProductos
        '
        Me.EditarProductos.BackColor = System.Drawing.SystemColors.ActiveCaption
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
        Me.AgregarProductos.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.AgregarProductos.Location = New System.Drawing.Point(4, 28)
        Me.AgregarProductos.Name = "AgregarProductos"
        Me.AgregarProductos.Padding = New System.Windows.Forms.Padding(3)
        Me.AgregarProductos.Size = New System.Drawing.Size(806, 589)
        Me.AgregarProductos.TabIndex = 2
        Me.AgregarProductos.Text = "Agregar nuevos productos"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(3, 260)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 326)
        Me.Panel1.TabIndex = 0
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
        Me.DataGridView1.Size = New System.Drawing.Size(360, 326)
        Me.DataGridView1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.LNombrepro)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(366, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(434, 326)
        Me.Panel2.TabIndex = 1
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Descripcion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Precio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Stock"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(180, 97)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(174, 20)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "Nombre del Producto"
        Me.CheckBox1.UseVisualStyleBackColor = True
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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GestionarProductos As TabControl
    Friend WithEvents ConsultarProductos As TabPage
    Friend WithEvents EditarProductos As TabPage
    Friend WithEvents AgregarProductos As TabPage
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LNombrepro As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
