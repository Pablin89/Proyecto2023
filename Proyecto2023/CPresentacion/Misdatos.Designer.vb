﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Misdatos
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BModificarP = New System.Windows.Forms.Button()
        Me.LFechaNac = New System.Windows.Forms.Label()
        Me.LDireccion = New System.Windows.Forms.Label()
        Me.LTelefono = New System.Windows.Forms.Label()
        Me.LDni = New System.Windows.Forms.Label()
        Me.LCorreo = New System.Windows.Forms.Label()
        Me.LNombreyApellido = New System.Windows.Forms.Label()
        Me.LTitulo1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LTipo = New System.Windows.Forms.Label()
        Me.LContrasena = New System.Windows.Forms.Label()
        Me.LUsuario = New System.Windows.Forms.Label()
        Me.LTitulo2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.BModificarP)
        Me.Panel1.Controls.Add(Me.LFechaNac)
        Me.Panel1.Controls.Add(Me.LDireccion)
        Me.Panel1.Controls.Add(Me.LTelefono)
        Me.Panel1.Controls.Add(Me.LDni)
        Me.Panel1.Controls.Add(Me.LCorreo)
        Me.Panel1.Controls.Add(Me.LNombreyApellido)
        Me.Panel1.Controls.Add(Me.LTitulo1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(814, 314)
        Me.Panel1.TabIndex = 0
        '
        'BModificarP
        '
        Me.BModificarP.Location = New System.Drawing.Point(298, 269)
        Me.BModificarP.Name = "BModificarP"
        Me.BModificarP.Size = New System.Drawing.Size(190, 30)
        Me.BModificarP.TabIndex = 7
        Me.BModificarP.Text = "Modificar datos personales"
        Me.BModificarP.UseVisualStyleBackColor = True
        '
        'LFechaNac
        '
        Me.LFechaNac.AutoSize = True
        Me.LFechaNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFechaNac.Location = New System.Drawing.Point(412, 211)
        Me.LFechaNac.Name = "LFechaNac"
        Me.LFechaNac.Size = New System.Drawing.Size(133, 16)
        Me.LFechaNac.TabIndex = 6
        Me.LFechaNac.Text = "Fecha de nacimiento"
        '
        'LDireccion
        '
        Me.LDireccion.AutoSize = True
        Me.LDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDireccion.Location = New System.Drawing.Point(466, 154)
        Me.LDireccion.Name = "LDireccion"
        Me.LDireccion.Size = New System.Drawing.Size(65, 16)
        Me.LDireccion.TabIndex = 5
        Me.LDireccion.Text = "Direccion"
        '
        'LTelefono
        '
        Me.LTelefono.AutoSize = True
        Me.LTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTelefono.Location = New System.Drawing.Point(469, 91)
        Me.LTelefono.Name = "LTelefono"
        Me.LTelefono.Size = New System.Drawing.Size(62, 16)
        Me.LTelefono.TabIndex = 4
        Me.LTelefono.Text = "Telefono"
        '
        'LDni
        '
        Me.LDni.AutoSize = True
        Me.LDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDni.Location = New System.Drawing.Point(135, 155)
        Me.LDni.Name = "LDni"
        Me.LDni.Size = New System.Drawing.Size(28, 16)
        Me.LDni.TabIndex = 3
        Me.LDni.Text = "Dni"
        '
        'LCorreo
        '
        Me.LCorreo.AutoSize = True
        Me.LCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCorreo.Location = New System.Drawing.Point(114, 211)
        Me.LCorreo.Name = "LCorreo"
        Me.LCorreo.Size = New System.Drawing.Size(49, 16)
        Me.LCorreo.TabIndex = 2
        Me.LCorreo.Text = "Correo"
        '
        'LNombreyApellido
        '
        Me.LNombreyApellido.AutoSize = True
        Me.LNombreyApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombreyApellido.Location = New System.Drawing.Point(44, 92)
        Me.LNombreyApellido.Name = "LNombreyApellido"
        Me.LNombreyApellido.Size = New System.Drawing.Size(119, 16)
        Me.LNombreyApellido.TabIndex = 1
        Me.LNombreyApellido.Text = "Nombre y apellido"
        '
        'LTitulo1
        '
        Me.LTitulo1.AutoSize = True
        Me.LTitulo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo1.Location = New System.Drawing.Point(79, 18)
        Me.LTitulo1.Name = "LTitulo1"
        Me.LTitulo1.Size = New System.Drawing.Size(151, 20)
        Me.LTitulo1.TabIndex = 0
        Me.LTitulo1.Text = "Datos Personales"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.LTipo)
        Me.Panel2.Controls.Add(Me.LContrasena)
        Me.Panel2.Controls.Add(Me.LUsuario)
        Me.Panel2.Controls.Add(Me.LTitulo2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 320)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(814, 301)
        Me.Panel2.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(298, 266)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(190, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Modificar datos de usuario"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LTipo
        '
        Me.LTipo.AutoSize = True
        Me.LTipo.Location = New System.Drawing.Point(44, 207)
        Me.LTipo.Name = "LTipo"
        Me.LTipo.Size = New System.Drawing.Size(80, 13)
        Me.LTipo.TabIndex = 5
        Me.LTipo.Text = "Tipo de usuario"
        '
        'LContrasena
        '
        Me.LContrasena.AutoSize = True
        Me.LContrasena.Location = New System.Drawing.Point(44, 156)
        Me.LContrasena.Name = "LContrasena"
        Me.LContrasena.Size = New System.Drawing.Size(61, 13)
        Me.LContrasena.TabIndex = 4
        Me.LContrasena.Text = "Contraseña"
        '
        'LUsuario
        '
        Me.LUsuario.AutoSize = True
        Me.LUsuario.Location = New System.Drawing.Point(44, 111)
        Me.LUsuario.Name = "LUsuario"
        Me.LUsuario.Size = New System.Drawing.Size(96, 13)
        Me.LUsuario.TabIndex = 3
        Me.LUsuario.Text = "Nombre de usuario"
        '
        'LTitulo2
        '
        Me.LTitulo2.AutoSize = True
        Me.LTitulo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo2.Location = New System.Drawing.Point(79, 37)
        Me.LTitulo2.Name = "LTitulo2"
        Me.LTitulo2.Size = New System.Drawing.Size(149, 20)
        Me.LTitulo2.TabIndex = 2
        Me.LTitulo2.Text = "Datos de Usuario"
        '
        'Misdatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(814, 621)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Misdatos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Misdatos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BModificarP As Button
    Friend WithEvents LFechaNac As Label
    Friend WithEvents LDireccion As Label
    Friend WithEvents LTelefono As Label
    Friend WithEvents LDni As Label
    Friend WithEvents LCorreo As Label
    Friend WithEvents LNombreyApellido As Label
    Friend WithEvents LTitulo1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents LTipo As Label
    Friend WithEvents LContrasena As Label
    Friend WithEvents LUsuario As Label
    Friend WithEvents LTitulo2 As Label
End Class
