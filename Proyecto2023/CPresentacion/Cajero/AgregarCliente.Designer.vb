<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarCliente
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.LCorreo1 = New System.Windows.Forms.Label()
        Me.LTelefono1 = New System.Windows.Forms.Label()
        Me.LDireccion1 = New System.Windows.Forms.Label()
        Me.LDNI1 = New System.Windows.Forms.Label()
        Me.LFechaNacimiento = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.Proyecto2023.My.Resources.Resources.searchcircularbutton_79274
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(478, 48)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 47)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Buscar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox11
        '
        Me.TextBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(239, 62)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(233, 22)
        Me.TextBox11.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(152, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(527, 16)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Ingresar DNI del nuevo cliente para comprobar que  no existe en el sistema"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(545, 282)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(227, 20)
        Me.TextBox10.TabIndex = 25
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(545, 235)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(227, 20)
        Me.TextBox9.TabIndex = 24
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(545, 197)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(227, 20)
        Me.TextBox8.TabIndex = 23
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Controls.Add(Me.TextBox7)
        Me.Panel6.Controls.Add(Me.TextBox6)
        Me.Panel6.Controls.Add(Me.TextBox5)
        Me.Panel6.Controls.Add(Me.DateTimePicker1)
        Me.Panel6.Controls.Add(Me.LCorreo1)
        Me.Panel6.Controls.Add(Me.LTelefono1)
        Me.Panel6.Controls.Add(Me.LDireccion1)
        Me.Panel6.Controls.Add(Me.LDNI1)
        Me.Panel6.Controls.Add(Me.LFechaNacimiento)
        Me.Panel6.Controls.Add(Me.LNombre)
        Me.Panel6.Controls.Add(Me.LApellido)
        Me.Panel6.Location = New System.Drawing.Point(5, 116)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(790, 289)
        Me.Panel6.TabIndex = 29
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(191, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(429, 18)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Completar los campos para el registro del nuevo cliente"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(194, 210)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(198, 20)
        Me.TextBox7.TabIndex = 12
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(194, 122)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(198, 20)
        Me.TextBox6.TabIndex = 11
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(194, 78)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(198, 20)
        Me.TextBox5.TabIndex = 10
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(194, 164)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(198, 20)
        Me.DateTimePicker1.TabIndex = 9
        '
        'LCorreo1
        '
        Me.LCorreo1.AutoSize = True
        Me.LCorreo1.Location = New System.Drawing.Point(484, 169)
        Me.LCorreo1.Name = "LCorreo1"
        Me.LCorreo1.Size = New System.Drawing.Size(38, 13)
        Me.LCorreo1.TabIndex = 6
        Me.LCorreo1.Text = "Correo"
        '
        'LTelefono1
        '
        Me.LTelefono1.AutoSize = True
        Me.LTelefono1.Location = New System.Drawing.Point(469, 125)
        Me.LTelefono1.Name = "LTelefono1"
        Me.LTelefono1.Size = New System.Drawing.Size(49, 13)
        Me.LTelefono1.TabIndex = 5
        Me.LTelefono1.Text = "Telefono"
        '
        'LDireccion1
        '
        Me.LDireccion1.AutoSize = True
        Me.LDireccion1.Location = New System.Drawing.Point(465, 81)
        Me.LDireccion1.Name = "LDireccion1"
        Me.LDireccion1.Size = New System.Drawing.Size(52, 13)
        Me.LDireccion1.TabIndex = 4
        Me.LDireccion1.Text = "Direccion"
        '
        'LDNI1
        '
        Me.LDNI1.AutoSize = True
        Me.LDNI1.Location = New System.Drawing.Point(137, 213)
        Me.LDNI1.Name = "LDNI1"
        Me.LDNI1.Size = New System.Drawing.Size(26, 13)
        Me.LDNI1.TabIndex = 3
        Me.LDNI1.Text = "DNI"
        '
        'LFechaNacimiento
        '
        Me.LFechaNacimiento.AutoSize = True
        Me.LFechaNacimiento.Location = New System.Drawing.Point(16, 169)
        Me.LFechaNacimiento.Name = "LFechaNacimiento"
        Me.LFechaNacimiento.Size = New System.Drawing.Size(108, 13)
        Me.LFechaNacimiento.TabIndex = 2
        Me.LFechaNacimiento.Text = "Fecha de Nacimiento"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Location = New System.Drawing.Point(95, 125)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(54, 13)
        Me.LNombre.TabIndex = 1
        Me.LNombre.Text = "Nombre/s"
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.Location = New System.Drawing.Point(105, 81)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(44, 13)
        Me.LApellido.TabIndex = 0
        Me.LApellido.Text = "Apellido"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button3.Image = Global.Proyecto2023.My.Resources.Resources.sign_check_icon_34365
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(335, 450)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(188, 44)
        Me.Button3.TabIndex = 30
        Me.Button3.Text = "Confirmar Datos"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button3.UseVisualStyleBackColor = False
        '
        'AgregarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(800, 528)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Panel6)
        Me.Name = "AgregarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AgregarCliente"
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents LCorreo1 As Label
    Friend WithEvents LTelefono1 As Label
    Friend WithEvents LDireccion1 As Label
    Friend WithEvents LDNI1 As Label
    Friend WithEvents LFechaNacimiento As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents LApellido As Label
    Friend WithEvents Button3 As Button
End Class
