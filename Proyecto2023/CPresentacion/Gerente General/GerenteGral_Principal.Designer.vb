﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GerenteGral_Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GerenteGral_Principal))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuEncargado = New System.Windows.Forms.MenuStrip()
        Me.UsuariosNuevos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarUs = New System.Windows.Forms.ToolStripMenuItem()
        Me.Backup = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
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
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.MenuEncargado)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(209, 620)
        Me.Panel1.TabIndex = 0
        '
        'MenuEncargado
        '
        Me.MenuEncargado.AutoSize = False
        Me.MenuEncargado.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MenuEncargado.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuEncargado.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuEncargado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosNuevos, Me.ModificarUs, Me.Backup})
        Me.MenuEncargado.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.MenuEncargado.Location = New System.Drawing.Point(0, 184)
        Me.MenuEncargado.Name = "MenuEncargado"
        Me.MenuEncargado.Padding = New System.Windows.Forms.Padding(6, 6, 0, 2)
        Me.MenuEncargado.Size = New System.Drawing.Size(209, 436)
        Me.MenuEncargado.TabIndex = 2
        '
        'UsuariosNuevos
        '
        Me.UsuariosNuevos.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu
        Me.UsuariosNuevos.Image = Global.Proyecto2023.My.Resources.Resources.business_man_user_support_supportfortheuser_aquestion_theclient_2330__2_
        Me.UsuariosNuevos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UsuariosNuevos.ImageTransparentColor = System.Drawing.Color.White
        Me.UsuariosNuevos.Margin = New System.Windows.Forms.Padding(8)
        Me.UsuariosNuevos.Name = "UsuariosNuevos"
        Me.UsuariosNuevos.Size = New System.Drawing.Size(186, 89)
        Me.UsuariosNuevos.Text = "Empleados nuevos"
        Me.UsuariosNuevos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ModificarUs
        '
        Me.ModificarUs.Image = CType(resources.GetObject("ModificarUs.Image"), System.Drawing.Image)
        Me.ModificarUs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ModificarUs.Name = "ModificarUs"
        Me.ModificarUs.Size = New System.Drawing.Size(202, 89)
        Me.ModificarUs.Text = "Modificar Usuarios"
        Me.ModificarUs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Backup
        '
        Me.Backup.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu
        Me.Backup.Image = Global.Proyecto2023.My.Resources.Resources.Drive_Backup_23188
        Me.Backup.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Backup.Margin = New System.Windows.Forms.Padding(8)
        Me.Backup.Name = "Backup"
        Me.Backup.Size = New System.Drawing.Size(186, 73)
        Me.Backup.Text = "Backup de Base de Datos"
        Me.Backup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.BCerrarSesion)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(600, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 620)
        Me.Panel2.TabIndex = 1
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
        Me.Button2.Size = New System.Drawing.Size(200, 45)
        Me.Button2.TabIndex = 5
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
        Me.BCerrarSesion.Size = New System.Drawing.Size(200, 47)
        Me.BCerrarSesion.TabIndex = 2
        Me.BCerrarSesion.Text = "Cerrar Sesión"
        Me.BCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BCerrarSesion.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(209, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(391, 620)
        Me.Panel3.TabIndex = 1
        '
        'GerenteGral_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 620)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "GerenteGral_Principal"
        Me.Opacity = 0.94R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerente General"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.MenuEncargado.ResumeLayout(False)
        Me.MenuEncargado.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuEncargado As MenuStrip
    Friend WithEvents UsuariosNuevos As ToolStripMenuItem
    Friend WithEvents Backup As ToolStripMenuItem
    Friend WithEvents BCerrarSesion As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ModificarUs As ToolStripMenuItem
End Class
