﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gerente_Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gerente_Principal))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BCerrarSesion = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.MenuEncargado = New System.Windows.Forms.MenuStrip()
        Me.Productos = New System.Windows.Forms.ToolStripMenuItem()
        Me.Cajeros = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformesClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformesFechas = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MenuEncargado.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.BCerrarSesion)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(658, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(189, 620)
        Me.Panel2.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.CadetBlue
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(0, 47)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 40, 3, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button2.Size = New System.Drawing.Size(189, 45)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Datos de usuario"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button2.UseVisualStyleBackColor = False
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
        Me.BCerrarSesion.Size = New System.Drawing.Size(189, 47)
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
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(658, 620)
        Me.Panel3.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.MenuEncargado)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(215, 620)
        Me.Panel1.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(214, 597)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1, 23)
        Me.Panel4.TabIndex = 2
        '
        'MenuEncargado
        '
        Me.MenuEncargado.AutoSize = False
        Me.MenuEncargado.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MenuEncargado.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuEncargado.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuEncargado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Productos, Me.Cajeros, Me.InformesClientes, Me.InformesFechas})
        Me.MenuEncargado.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.MenuEncargado.Location = New System.Drawing.Point(0, 184)
        Me.MenuEncargado.Name = "MenuEncargado"
        Me.MenuEncargado.Padding = New System.Windows.Forms.Padding(6, 6, 0, 2)
        Me.MenuEncargado.Size = New System.Drawing.Size(214, 436)
        Me.MenuEncargado.TabIndex = 1
        '
        'Productos
        '
        Me.Productos.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu
        Me.Productos.Image = CType(resources.GetObject("Productos.Image"), System.Drawing.Image)
        Me.Productos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Productos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Productos.ImageTransparentColor = System.Drawing.Color.White
        Me.Productos.Margin = New System.Windows.Forms.Padding(8)
        Me.Productos.Name = "Productos"
        Me.Productos.Size = New System.Drawing.Size(191, 52)
        Me.Productos.Text = "Informes de Productos"
        '
        'Cajeros
        '
        Me.Cajeros.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu
        Me.Cajeros.Image = CType(resources.GetObject("Cajeros.Image"), System.Drawing.Image)
        Me.Cajeros.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Cajeros.Margin = New System.Windows.Forms.Padding(8)
        Me.Cajeros.Name = "Cajeros"
        Me.Cajeros.Size = New System.Drawing.Size(191, 52)
        Me.Cajeros.Text = "Informes de Empleados"
        '
        'InformesClientes
        '
        Me.InformesClientes.Image = CType(resources.GetObject("InformesClientes.Image"), System.Drawing.Image)
        Me.InformesClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.InformesClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.InformesClientes.Name = "InformesClientes"
        Me.InformesClientes.Size = New System.Drawing.Size(207, 52)
        Me.InformesClientes.Text = "Informes de clientes"
        Me.InformesClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'InformesFechas
        '
        Me.InformesFechas.Image = CType(resources.GetObject("InformesFechas.Image"), System.Drawing.Image)
        Me.InformesFechas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.InformesFechas.Name = "InformesFechas"
        Me.InformesFechas.Size = New System.Drawing.Size(207, 52)
        Me.InformesFechas.Text = "Informes por fechas"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(215, 184)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Gerente_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 620)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Gerente_Principal"
        Me.Text = "Gerente_Principal"
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
    Friend WithEvents BCerrarSesion As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents MenuEncargado As MenuStrip
    Friend WithEvents Productos As ToolStripMenuItem
    Friend WithEvents Cajeros As ToolStripMenuItem
    Friend WithEvents InformesClientes As ToolStripMenuItem
    Friend WithEvents InformesFechas As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
End Class
