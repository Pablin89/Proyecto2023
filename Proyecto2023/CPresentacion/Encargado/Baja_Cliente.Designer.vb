<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Baja_Cliente
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
        Me.TBuscarCorreo = New System.Windows.Forms.TextBox()
        Me.TBuscarapellido = New System.Windows.Forms.TextBox()
        Me.RBCorreo = New System.Windows.Forms.RadioButton()
        Me.RBApellido = New System.Windows.Forms.RadioButton()
        Me.RBDni = New System.Windows.Forms.RadioButton()
        Me.TBuscarDni = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.BSeleccionar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TBuscarCorreo
        '
        Me.TBuscarCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBuscarCorreo.Location = New System.Drawing.Point(226, 173)
        Me.TBuscarCorreo.Name = "TBuscarCorreo"
        Me.TBuscarCorreo.Size = New System.Drawing.Size(285, 21)
        Me.TBuscarCorreo.TabIndex = 21
        '
        'TBuscarapellido
        '
        Me.TBuscarapellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBuscarapellido.Location = New System.Drawing.Point(226, 137)
        Me.TBuscarapellido.Name = "TBuscarapellido"
        Me.TBuscarapellido.Size = New System.Drawing.Size(285, 21)
        Me.TBuscarapellido.TabIndex = 20
        '
        'RBCorreo
        '
        Me.RBCorreo.AutoSize = True
        Me.RBCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBCorreo.Location = New System.Drawing.Point(120, 175)
        Me.RBCorreo.Name = "RBCorreo"
        Me.RBCorreo.Size = New System.Drawing.Size(62, 19)
        Me.RBCorreo.TabIndex = 19
        Me.RBCorreo.TabStop = True
        Me.RBCorreo.Text = "Correo"
        Me.RBCorreo.UseVisualStyleBackColor = True
        '
        'RBApellido
        '
        Me.RBApellido.AutoSize = True
        Me.RBApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBApellido.Location = New System.Drawing.Point(120, 137)
        Me.RBApellido.Name = "RBApellido"
        Me.RBApellido.Size = New System.Drawing.Size(69, 19)
        Me.RBApellido.TabIndex = 18
        Me.RBApellido.TabStop = True
        Me.RBApellido.Text = "Apellido"
        Me.RBApellido.UseVisualStyleBackColor = True
        '
        'RBDni
        '
        Me.RBDni.AutoSize = True
        Me.RBDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBDni.Location = New System.Drawing.Point(120, 101)
        Me.RBDni.Name = "RBDni"
        Me.RBDni.Size = New System.Drawing.Size(46, 19)
        Me.RBDni.TabIndex = 17
        Me.RBDni.TabStop = True
        Me.RBDni.Text = "DNI"
        Me.RBDni.UseVisualStyleBackColor = True
        '
        'TBuscarDni
        '
        Me.TBuscarDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBuscarDni.Location = New System.Drawing.Point(226, 99)
        Me.TBuscarDni.Name = "TBuscarDni"
        Me.TBuscarDni.Size = New System.Drawing.Size(285, 21)
        Me.TBuscarDni.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(117, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Buscar por:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(291, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Seleccionar un Cliente"
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonBuscar.Image = Global.Proyecto2023.My.Resources.Resources.search_find_client_user_16693__1_
        Me.ButtonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonBuscar.Location = New System.Drawing.Point(553, 124)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(132, 46)
        Me.ButtonBuscar.TabIndex = 16
        Me.ButtonBuscar.Text = "Buscar Cliente"
        Me.ButtonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ButtonBuscar.UseVisualStyleBackColor = True
        '
        'BSeleccionar
        '
        Me.BSeleccionar.BackColor = System.Drawing.Color.IndianRed
        Me.BSeleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSeleccionar.ForeColor = System.Drawing.Color.White
        Me.BSeleccionar.Location = New System.Drawing.Point(316, 410)
        Me.BSeleccionar.Name = "BSeleccionar"
        Me.BSeleccionar.Size = New System.Drawing.Size(175, 47)
        Me.BSeleccionar.TabIndex = 23
        Me.BSeleccionar.Text = "Dar de baja al cliente"
        Me.BSeleccionar.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 218)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(800, 186)
        Me.DataGridView1.TabIndex = 24
        '
        'Baja_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 469)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BSeleccionar)
        Me.Controls.Add(Me.TBuscarCorreo)
        Me.Controls.Add(Me.TBuscarapellido)
        Me.Controls.Add(Me.RBCorreo)
        Me.Controls.Add(Me.RBApellido)
        Me.Controls.Add(Me.RBDni)
        Me.Controls.Add(Me.ButtonBuscar)
        Me.Controls.Add(Me.TBuscarDni)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Baja_Cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Baja_Cliente"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TBuscarCorreo As TextBox
    Friend WithEvents TBuscarapellido As TextBox
    Friend WithEvents RBCorreo As RadioButton
    Friend WithEvents RBApellido As RadioButton
    Friend WithEvents RBDni As RadioButton
    Friend WithEvents ButtonBuscar As Button
    Friend WithEvents TBuscarDni As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BSeleccionar As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
