<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cajero_Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cajero_Principal))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.MenuEncargado = New System.Windows.Forms.MenuStrip()
        Me.Productos = New System.Windows.Forms.ToolStripMenuItem()
        Me.Cajeros = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajaClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BMisDatos = New System.Windows.Forms.Button()
        Me.BCerrarSesion = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.MenuEncargado.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.MenuEncargado)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(212, 611)
        Me.Panel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(212, 588)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(0, 23)
        Me.Panel4.TabIndex = 2
        '
        'MenuEncargado
        '
        Me.MenuEncargado.AutoSize = False
        Me.MenuEncargado.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MenuEncargado.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuEncargado.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuEncargado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Productos, Me.Cajeros, Me.BajaClientes, Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.MenuEncargado.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.MenuEncargado.Location = New System.Drawing.Point(0, 184)
        Me.MenuEncargado.Name = "MenuEncargado"
        Me.MenuEncargado.Padding = New System.Windows.Forms.Padding(6, 6, 0, 2)
        Me.MenuEncargado.Size = New System.Drawing.Size(212, 427)
        Me.MenuEncargado.TabIndex = 1
        '
        'Productos
        '
        Me.Productos.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu
        Me.Productos.Image = Global.Proyecto2023.My.Resources.Resources.Productos
        Me.Productos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Productos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Productos.ImageTransparentColor = System.Drawing.Color.White
        Me.Productos.Margin = New System.Windows.Forms.Padding(8)
        Me.Productos.Name = "Productos"
        Me.Productos.Size = New System.Drawing.Size(189, 76)
        Me.Productos.Text = "Productos"
        '
        'Cajeros
        '
        Me.Cajeros.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu
        Me.Cajeros.Image = CType(resources.GetObject("Cajeros.Image"), System.Drawing.Image)
        Me.Cajeros.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Cajeros.Margin = New System.Windows.Forms.Padding(8)
        Me.Cajeros.Name = "Cajeros"
        Me.Cajeros.Size = New System.Drawing.Size(189, 68)
        Me.Cajeros.Text = "Empleados"
        '
        'BajaClientes
        '
        Me.BajaClientes.Image = Global.Proyecto2023.My.Resources.Resources.team_people_man_woman_group_icon_193939
        Me.BajaClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BajaClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BajaClientes.Name = "BajaClientes"
        Me.BajaClientes.Size = New System.Drawing.Size(205, 76)
        Me.BajaClientes.Text = "Clientes"
        Me.BajaClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(205, 68)
        Me.ToolStripMenuItem1.Text = "Ventas"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(205, 4)
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(212, 184)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.BMisDatos)
        Me.Panel2.Controls.Add(Me.BCerrarSesion)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(655, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(178, 611)
        Me.Panel2.TabIndex = 1
        '
        'BMisDatos
        '
        Me.BMisDatos.BackColor = System.Drawing.Color.CadetBlue
        Me.BMisDatos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BMisDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.BMisDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BMisDatos.Image = CType(resources.GetObject("BMisDatos.Image"), System.Drawing.Image)
        Me.BMisDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BMisDatos.Location = New System.Drawing.Point(0, 47)
        Me.BMisDatos.Margin = New System.Windows.Forms.Padding(3, 40, 3, 3)
        Me.BMisDatos.Name = "BMisDatos"
        Me.BMisDatos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BMisDatos.Size = New System.Drawing.Size(178, 45)
        Me.BMisDatos.TabIndex = 4
        Me.BMisDatos.Text = "Datos de usuario"
        Me.BMisDatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BMisDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BMisDatos.UseVisualStyleBackColor = False
        '
        'BCerrarSesion
        '
        Me.BCerrarSesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BCerrarSesion.Dock = System.Windows.Forms.DockStyle.Top
        Me.BCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCerrarSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCerrarSesion.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BCerrarSesion.Image = Global.Proyecto2023.My.Resources.Resources.Logout
        Me.BCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BCerrarSesion.Location = New System.Drawing.Point(0, 0)
        Me.BCerrarSesion.Name = "BCerrarSesion"
        Me.BCerrarSesion.Size = New System.Drawing.Size(178, 47)
        Me.BCerrarSesion.TabIndex = 0
        Me.BCerrarSesion.Text = "Cerrar Sesión"
        Me.BCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BCerrarSesion.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(212, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(443, 611)
        Me.Panel3.TabIndex = 3
        '
        'Cajero_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(833, 611)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuEncargado
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cajero_Principal"
        Me.Opacity = 0.94R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú Encargado"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.MenuEncargado.ResumeLayout(False)
        Me.MenuEncargado.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuEncargado As MenuStrip
    Friend WithEvents Cajeros As ToolStripMenuItem
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BCerrarSesion As Button
    Friend WithEvents Productos As ToolStripMenuItem
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BajaClientes As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents BMisDatos As Button
End Class
