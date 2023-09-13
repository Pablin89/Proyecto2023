<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Seleccion_Clientes
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ChDni = New System.Windows.Forms.CheckBox()
        Me.ChApellido = New System.Windows.Forms.CheckBox()
        Me.ChCorreo = New System.Windows.Forms.CheckBox()
        Me.TBusqueda = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BSeleccionar = New System.Windows.Forms.Button()
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
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Buscar por:"
        '
        'ChDni
        '
        Me.ChDni.AutoSize = True
        Me.ChDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChDni.Location = New System.Drawing.Point(121, 120)
        Me.ChDni.Name = "ChDni"
        Me.ChDni.Size = New System.Drawing.Size(47, 20)
        Me.ChDni.TabIndex = 2
        Me.ChDni.Text = "Dni"
        Me.ChDni.UseVisualStyleBackColor = True
        '
        'ChApellido
        '
        Me.ChApellido.AutoSize = True
        Me.ChApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChApellido.Location = New System.Drawing.Point(121, 158)
        Me.ChApellido.Name = "ChApellido"
        Me.ChApellido.Size = New System.Drawing.Size(77, 20)
        Me.ChApellido.TabIndex = 3
        Me.ChApellido.Text = "Apellido"
        Me.ChApellido.UseVisualStyleBackColor = True
        '
        'ChCorreo
        '
        Me.ChCorreo.AutoSize = True
        Me.ChCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChCorreo.Location = New System.Drawing.Point(121, 193)
        Me.ChCorreo.Name = "ChCorreo"
        Me.ChCorreo.Size = New System.Drawing.Size(68, 20)
        Me.ChCorreo.TabIndex = 4
        Me.ChCorreo.Text = "Correo"
        Me.ChCorreo.UseVisualStyleBackColor = True
        '
        'TBusqueda
        '
        Me.TBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBusqueda.Location = New System.Drawing.Point(298, 120)
        Me.TBusqueda.Name = "TBusqueda"
        Me.TBusqueda.Size = New System.Drawing.Size(213, 21)
        Me.TBusqueda.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Image = Global.Proyecto2023.My.Resources.Resources.search_find_client_user_16693__1_
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(539, 106)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 46)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Buscar Cliente"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = True
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
        Me.Panel1.Controls.Add(Me.TBusqueda)
        Me.Panel1.Controls.Add(Me.ChCorreo)
        Me.Panel1.Controls.Add(Me.ChApellido)
        Me.Panel1.Controls.Add(Me.ChDni)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 235)
        Me.Panel1.TabIndex = 8
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
    Friend WithEvents ChDni As CheckBox
    Friend WithEvents ChApellido As CheckBox
    Friend WithEvents ChCorreo As CheckBox
    Friend WithEvents TBusqueda As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BSeleccionar As Button
End Class
