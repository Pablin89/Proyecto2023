<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CajeroPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CajeroPrincipal))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuEncargado = New System.Windows.Forms.MenuStrip()
        Me.RealizarVenta = New System.Windows.Forms.ToolStripMenuItem()
        Me.MisVentas = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarUsuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarCliente = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BCerrarSesion = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MenuEncargado.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.BCerrarSesion)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(600, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 620)
        Me.Panel2.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.CadetBlue
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.Font = New System.Drawing.Font("Leelawadee", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(0, 47)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 40, 3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button1.Size = New System.Drawing.Size(200, 29)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Datos de usuario"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(600, 620)
        Me.Panel3.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.MenuEncargado)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(209, 620)
        Me.Panel1.TabIndex = 1
        '
        'MenuEncargado
        '
        Me.MenuEncargado.AutoSize = False
        Me.MenuEncargado.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MenuEncargado.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuEncargado.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuEncargado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RealizarVenta, Me.MisVentas, Me.AgregarUsuario, Me.ConsultarCliente})
        Me.MenuEncargado.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.MenuEncargado.Location = New System.Drawing.Point(0, 184)
        Me.MenuEncargado.Name = "MenuEncargado"
        Me.MenuEncargado.Padding = New System.Windows.Forms.Padding(6, 6, 0, 2)
        Me.MenuEncargado.Size = New System.Drawing.Size(209, 436)
        Me.MenuEncargado.TabIndex = 2
        '
        'RealizarVenta
        '
        Me.RealizarVenta.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu
        Me.RealizarVenta.Image = Global.Proyecto2023.My.Resources.Resources.buy_13374
        Me.RealizarVenta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RealizarVenta.ImageTransparentColor = System.Drawing.Color.White
        Me.RealizarVenta.Margin = New System.Windows.Forms.Padding(8)
        Me.RealizarVenta.Name = "RealizarVenta"
        Me.RealizarVenta.Size = New System.Drawing.Size(186, 73)
        Me.RealizarVenta.Text = "Realizar Venta"
        Me.RealizarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'MisVentas
        '
        Me.MisVentas.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu
        Me.MisVentas.Image = Global.Proyecto2023.My.Resources.Resources.chart_marketing_report_shop_graph_business_sales_shopping_analytics_finance_icon_231909
        Me.MisVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MisVentas.Margin = New System.Windows.Forms.Padding(8)
        Me.MisVentas.Name = "MisVentas"
        Me.MisVentas.Size = New System.Drawing.Size(186, 73)
        Me.MisVentas.Text = "Consultar Ventas"
        Me.MisVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'AgregarUsuario
        '
        Me.AgregarUsuario.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu
        Me.AgregarUsuario.Image = Global.Proyecto2023.My.Resources.Resources.new_add_user_16734
        Me.AgregarUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AgregarUsuario.Margin = New System.Windows.Forms.Padding(8)
        Me.AgregarUsuario.Name = "AgregarUsuario"
        Me.AgregarUsuario.Size = New System.Drawing.Size(186, 73)
        Me.AgregarUsuario.Text = "Agregar Cliente"
        Me.AgregarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ConsultarCliente
        '
        Me.ConsultarCliente.Image = Global.Proyecto2023.My.Resources.Resources.business_man_user_support_supportfortheuser_aquestion_theclient_2330__2_
        Me.ConsultarCliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ConsultarCliente.Name = "ConsultarCliente"
        Me.ConsultarCliente.Size = New System.Drawing.Size(202, 89)
        Me.ConsultarCliente.Text = "Consultar Clientes"
        Me.ConsultarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(209, 184)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'BCerrarSesion
        '
        Me.BCerrarSesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BCerrarSesion.Dock = System.Windows.Forms.DockStyle.Top
        Me.BCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCerrarSesion.Font = New System.Drawing.Font("Leelawadee", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCerrarSesion.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BCerrarSesion.Image = Global.Proyecto2023.My.Resources.Resources.Logout
        Me.BCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BCerrarSesion.Location = New System.Drawing.Point(0, 0)
        Me.BCerrarSesion.Name = "BCerrarSesion"
        Me.BCerrarSesion.Size = New System.Drawing.Size(200, 47)
        Me.BCerrarSesion.TabIndex = 2
        Me.BCerrarSesion.Text = "Cerrar Sesión"
        Me.BCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BCerrarSesion.UseVisualStyleBackColor = False
        '
        'CajeroPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 620)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.IsMdiContainer = True
        Me.Name = "CajeroPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CajeroPrincipal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.MenuEncargado.ResumeLayout(False)
        Me.MenuEncargado.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents BCerrarSesion As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuEncargado As MenuStrip
    Friend WithEvents RealizarVenta As ToolStripMenuItem
    Friend WithEvents MisVentas As ToolStripMenuItem
    Friend WithEvents AgregarUsuario As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ConsultarCliente As ToolStripMenuItem
End Class
