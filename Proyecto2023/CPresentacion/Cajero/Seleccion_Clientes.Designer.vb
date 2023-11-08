<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Baja_Clientes
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBuscarDni = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TBuscarCorreo = New System.Windows.Forms.TextBox()
        Me.TBuscarapellido = New System.Windows.Forms.TextBox()
        Me.RBCorreo = New System.Windows.Forms.RadioButton()
        Me.RBApellido = New System.Windows.Forms.RadioButton()
        Me.RBDni = New System.Windows.Forms.RadioButton()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(313, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccionar un Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(117, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Buscar por:"
        '
        'TBuscarDni
        '
        Me.TBuscarDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBuscarDni.Location = New System.Drawing.Point(226, 97)
        Me.TBuscarDni.Name = "TBuscarDni"
        Me.TBuscarDni.Size = New System.Drawing.Size(285, 21)
        Me.TBuscarDni.TabIndex = 5
        '
        'Panel1
        '
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
        Me.Panel1.Size = New System.Drawing.Size(827, 235)
        Me.Panel1.TabIndex = 8
        '
        'TBuscarCorreo
        '
        Me.TBuscarCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBuscarCorreo.Location = New System.Drawing.Point(226, 171)
        Me.TBuscarCorreo.Name = "TBuscarCorreo"
        Me.TBuscarCorreo.Size = New System.Drawing.Size(285, 21)
        Me.TBuscarCorreo.TabIndex = 11
        '
        'TBuscarapellido
        '
        Me.TBuscarapellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBuscarapellido.Location = New System.Drawing.Point(226, 135)
        Me.TBuscarapellido.Name = "TBuscarapellido"
        Me.TBuscarapellido.Size = New System.Drawing.Size(285, 21)
        Me.TBuscarapellido.TabIndex = 10
        '
        'RBCorreo
        '
        Me.RBCorreo.AutoSize = True
        Me.RBCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBCorreo.Location = New System.Drawing.Point(120, 173)
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
        Me.RBApellido.Location = New System.Drawing.Point(120, 135)
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
        Me.RBDni.Location = New System.Drawing.Point(120, 99)
        Me.RBDni.Name = "RBDni"
        Me.RBDni.Size = New System.Drawing.Size(46, 19)
        Me.RBDni.TabIndex = 7
        Me.RBDni.TabStop = True
        Me.RBDni.Text = "DNI"
        Me.RBDni.UseVisualStyleBackColor = True
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonBuscar.Image = Global.Proyecto2023.My.Resources.Resources.search_find_client_user_16693__1_
        Me.ButtonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonBuscar.Location = New System.Drawing.Point(571, 122)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(190, 46)
        Me.ButtonBuscar.TabIndex = 6
        Me.ButtonBuscar.Text = "Mostrar todos los clientes"
        Me.ButtonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ButtonBuscar.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 195)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(827, 78)
        Me.Panel3.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(225, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(361, 16)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Para seleccionar un cliente, haz doble clic sobre él"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 235)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(827, 273)
        Me.Panel2.TabIndex = 9
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InfoText
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(827, 273)
        Me.DataGridView1.TabIndex = 7
        '
        'Baja_Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(827, 508)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Baja_Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Seleccion de Clientes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TBuscarDni As TextBox
    Friend WithEvents ButtonBuscar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RBCorreo As RadioButton
    Friend WithEvents RBApellido As RadioButton
    Friend WithEvents RBDni As RadioButton
    Friend WithEvents TBuscarCorreo As TextBox
    Friend WithEvents TBuscarapellido As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
End Class
