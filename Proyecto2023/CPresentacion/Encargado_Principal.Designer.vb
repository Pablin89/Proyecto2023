<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Encargado_Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Encargado_Principal))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuEncargado = New System.Windows.Forms.MenuStrip()
        Me.Productos = New System.Windows.Forms.ToolStripMenuItem()
        Me.Cajeros = New System.Windows.Forms.ToolStripMenuItem()
        Me.Informes = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BCerrarSesion = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.MenuEncargado.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.MenuEncargado)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(179, 450)
        Me.Panel1.TabIndex = 0
        '
        'MenuEncargado
        '
        Me.MenuEncargado.AutoSize = False
        Me.MenuEncargado.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MenuEncargado.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuEncargado.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuEncargado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Productos, Me.Cajeros, Me.Informes})
        Me.MenuEncargado.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.MenuEncargado.Location = New System.Drawing.Point(0, 167)
        Me.MenuEncargado.Name = "MenuEncargado"
        Me.MenuEncargado.Padding = New System.Windows.Forms.Padding(6, 6, 0, 2)
        Me.MenuEncargado.Size = New System.Drawing.Size(179, 283)
        Me.MenuEncargado.TabIndex = 1
        '
        'Productos
        '
        Me.Productos.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu
        Me.Productos.Image = Global.Proyecto2023.My.Resources.Resources.product_document_file_1512
        Me.Productos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Productos.ImageTransparentColor = System.Drawing.Color.White
        Me.Productos.Margin = New System.Windows.Forms.Padding(8)
        Me.Productos.Name = "Productos"
        Me.Productos.Size = New System.Drawing.Size(156, 30)
        Me.Productos.Text = "Productos"
        '
        'Cajeros
        '
        Me.Cajeros.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu
        Me.Cajeros.Image = Global.Proyecto2023.My.Resources.Resources.cashier_machine_cash_register_pos_icon_225168
        Me.Cajeros.Margin = New System.Windows.Forms.Padding(8)
        Me.Cajeros.Name = "Cajeros"
        Me.Cajeros.Size = New System.Drawing.Size(156, 30)
        Me.Cajeros.Text = "Cajeros"
        '
        'Informes
        '
        Me.Informes.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu
        Me.Informes.Image = Global.Proyecto2023.My.Resources.Resources.statistic_icon_129319
        Me.Informes.Margin = New System.Windows.Forms.Padding(8)
        Me.Informes.Name = "Informes"
        Me.Informes.Size = New System.Drawing.Size(156, 30)
        Me.Informes.Text = "Informes"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(179, 167)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BCerrarSesion)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(653, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(147, 450)
        Me.Panel2.TabIndex = 1
        '
        'BCerrarSesion
        '
        Me.BCerrarSesion.Dock = System.Windows.Forms.DockStyle.Top
        Me.BCerrarSesion.Location = New System.Drawing.Point(0, 0)
        Me.BCerrarSesion.Name = "BCerrarSesion"
        Me.BCerrarSesion.Size = New System.Drawing.Size(147, 23)
        Me.BCerrarSesion.TabIndex = 0
        Me.BCerrarSesion.Text = "Cerrar Sesión"
        Me.BCerrarSesion.UseVisualStyleBackColor = True
        '
        'Encargado_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuEncargado
        Me.Name = "Encargado_Principal"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Encargado"
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
    Friend WithEvents Informes As ToolStripMenuItem
End Class
