<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Seleccion_Clientes
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBuscarDni = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TBuscarCorreo = New System.Windows.Forms.TextBox()
        Me.TBuscarapellido = New System.Windows.Forms.TextBox()
        Me.RBCorreo = New System.Windows.Forms.RadioButton()
        Me.RBApellido = New System.Windows.Forms.RadioButton()
        Me.RBDni = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BSeleccionar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(294, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccionar un Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(118, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Buscar por:"
        '
        'TBuscarDni
        '
        Me.TBuscarDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBuscarDni.Location = New System.Drawing.Point(227, 118)
        Me.TBuscarDni.Name = "TBuscarDni"
        Me.TBuscarDni.Size = New System.Drawing.Size(285, 21)
        Me.TBuscarDni.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(800, 273)
        Me.DataGridView1.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.TBuscarCorreo)
        Me.Panel1.Controls.Add(Me.TBuscarapellido)
        Me.Panel1.Controls.Add(Me.RBCorreo)
        Me.Panel1.Controls.Add(Me.RBApellido)
        Me.Panel1.Controls.Add(Me.RBDni)
        Me.Panel1.Controls.Add(Me.ButtonBuscar)
        Me.Panel1.Controls.Add(Me.TBuscarDni)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 235)
        Me.Panel1.TabIndex = 8
        '
        'TBuscarCorreo
        '
        Me.TBuscarCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBuscarCorreo.Location = New System.Drawing.Point(227, 192)
        Me.TBuscarCorreo.Name = "TBuscarCorreo"
        Me.TBuscarCorreo.Size = New System.Drawing.Size(285, 21)
        Me.TBuscarCorreo.TabIndex = 11
        '
        'TBuscarapellido
        '
        Me.TBuscarapellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBuscarapellido.Location = New System.Drawing.Point(227, 156)
        Me.TBuscarapellido.Name = "TBuscarapellido"
        Me.TBuscarapellido.Size = New System.Drawing.Size(285, 21)
        Me.TBuscarapellido.TabIndex = 10
        '
        'RBCorreo
        '
        Me.RBCorreo.AutoSize = True
        Me.RBCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBCorreo.Location = New System.Drawing.Point(121, 194)
        Me.RBCorreo.Name = "RBCorreo"
        Me.RBCorreo.Size = New System.Drawing.Size(62, 19)
        Me.RBCorreo.TabIndex = 9
        Me.RBCorreo.TabStop = True
        Me.RBCorreo.Text = "Correo"
        Me.RBCorreo.UseVisualStyleBackColor = True
        '
        'RBApellido
        '
        Me.RBApellido.AutoSize = True
        Me.RBApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBApellido.Location = New System.Drawing.Point(121, 156)
        Me.RBApellido.Name = "RBApellido"
        Me.RBApellido.Size = New System.Drawing.Size(69, 19)
        Me.RBApellido.TabIndex = 8
        Me.RBApellido.TabStop = True
        Me.RBApellido.Text = "Apellido"
        Me.RBApellido.UseVisualStyleBackColor = True
        '
        'RBDni
        '
        Me.RBDni.AutoSize = True
        Me.RBDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBDni.Location = New System.Drawing.Point(121, 120)
        Me.RBDni.Name = "RBDni"
        Me.RBDni.Size = New System.Drawing.Size(46, 19)
        Me.RBDni.TabIndex = 7
        Me.RBDni.TabStop = True
        Me.RBDni.Text = "DNI"
        Me.RBDni.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 235)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 273)
        Me.Panel2.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.Controls.Add(Me.BSeleccionar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 195)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(800, 78)
        Me.Panel3.TabIndex = 8
        '
        'BSeleccionar
        '
        Me.BSeleccionar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BSeleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSeleccionar.ForeColor = System.Drawing.Color.White
        Me.BSeleccionar.Location = New System.Drawing.Point(319, 19)
        Me.BSeleccionar.Name = "BSeleccionar"
        Me.BSeleccionar.Size = New System.Drawing.Size(167, 47)
        Me.BSeleccionar.TabIndex = 0
        Me.BSeleccionar.Text = "Seleccionar Cliente"
        Me.BSeleccionar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Image = Global.Proyecto2023.My.Resources.Resources.businessapplication_edit
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(566, 180)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 46)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Editar Cliente"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonBuscar.Image = Global.Proyecto2023.My.Resources.Resources.search_find_client_user_16693__1_
        Me.ButtonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonBuscar.Location = New System.Drawing.Point(566, 118)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(132, 46)
        Me.ButtonBuscar.TabIndex = 6
        Me.ButtonBuscar.Text = "Buscar Cliente"
        Me.ButtonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ButtonBuscar.UseVisualStyleBackColor = True
        '
        'Seleccion_Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 508)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Name = "Seleccion_Clientes"
        Me.Text = "Seleccion de Clientes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TBuscarDni As TextBox
    Friend WithEvents ButtonBuscar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BSeleccionar As Button
    Friend WithEvents RBCorreo As RadioButton
    Friend WithEvents RBApellido As RadioButton
    Friend WithEvents RBDni As RadioButton
    Friend WithEvents TBuscarCorreo As TextBox
    Friend WithEvents TBuscarapellido As TextBox
    Friend WithEvents Button1 As Button
End Class
