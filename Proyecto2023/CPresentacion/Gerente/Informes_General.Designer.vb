<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Informes_General
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DateTimeDesde = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.DateTimeDesde)
        Me.Panel3.Controls.Add(Me.DateTimePicker1)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(781, 284)
        Me.Panel3.TabIndex = 23
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.CheckBox7)
        Me.Panel2.Controls.Add(Me.CheckBox8)
        Me.Panel2.Controls.Add(Me.CheckBox5)
        Me.Panel2.Controls.Add(Me.CheckBox6)
        Me.Panel2.Controls.Add(Me.CheckBox3)
        Me.Panel2.Controls.Add(Me.CheckBox4)
        Me.Panel2.Controls.Add(Me.CheckBox2)
        Me.Panel2.Controls.Add(Me.CheckBox1)
        Me.Panel2.Location = New System.Drawing.Point(53, 82)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(452, 184)
        Me.Panel2.TabIndex = 28
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox7.Location = New System.Drawing.Point(250, 148)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(181, 20)
        Me.CheckBox7.TabIndex = 26
        Me.CheckBox7.Text = "Categoria menos vendida"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox8.Location = New System.Drawing.Point(250, 105)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(166, 20)
        Me.CheckBox8.TabIndex = 25
        Me.CheckBox8.Text = "Categoria mas vendida"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox5.Location = New System.Drawing.Point(250, 59)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(192, 20)
        Me.CheckBox5.TabIndex = 24
        Me.CheckBox5.Text = "Cliente con menos compras"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox6.Location = New System.Drawing.Point(250, 16)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(177, 20)
        Me.CheckBox6.TabIndex = 23
        Me.CheckBox6.Text = "Cliente con mas compras"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.Location = New System.Drawing.Point(13, 148)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(176, 20)
        Me.CheckBox3.TabIndex = 22
        Me.CheckBox3.Text = "Producto menos vendido"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox4.Location = New System.Drawing.Point(13, 105)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(161, 20)
        Me.CheckBox4.TabIndex = 21
        Me.CheckBox4.Text = "Producto mas vendido"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(13, 59)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(201, 20)
        Me.CheckBox2.TabIndex = 20
        Me.CheckBox2.Text = "Empleado con menos ventas"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(13, 16)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(186, 20)
        Me.CheckBox1.TabIndex = 19
        Me.CheckBox1.Text = "Empleado con mas ventas"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(532, 154)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(193, 33)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Generar Informe"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DateTimeDesde
        '
        Me.DateTimeDesde.Location = New System.Drawing.Point(155, 49)
        Me.DateTimeDesde.Name = "DateTimeDesde"
        Me.DateTimeDesde.Size = New System.Drawing.Size(209, 20)
        Me.DateTimeDesde.TabIndex = 18
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(516, 49)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(209, 20)
        Me.DateTimePicker1.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(50, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Fecha desde"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(435, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Fecha hasta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(331, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Informes Generales"
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 284)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(781, 166)
        Me.Panel1.TabIndex = 24
        '
        'Informes_General
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(781, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "Informes_General"
        Me.Text = "Informes_General"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents DateTimeDesde As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
End Class
