﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Realizar_Backup
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
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.LRuta = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LTitulo
        '
        Me.LTitulo.AutoSize = True
        Me.LTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.Location = New System.Drawing.Point(330, 26)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(140, 20)
        Me.LTitulo.TabIndex = 0
        Me.LTitulo.Text = "Realizar Backup"
        '
        'LRuta
        '
        Me.LRuta.AutoSize = True
        Me.LRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LRuta.Location = New System.Drawing.Point(104, 165)
        Me.LRuta.Name = "LRuta"
        Me.LRuta.Size = New System.Drawing.Size(171, 16)
        Me.LRuta.TabIndex = 1
        Me.LRuta.Text = "Ingresar Ruta de Guardado"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(292, 164)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(342, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(346, 232)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 38)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Realizar Backup"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(640, 157)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 32)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Buscar ruta"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Realizar_Backup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LRuta)
        Me.Controls.Add(Me.LTitulo)
        Me.Name = "Realizar_Backup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Backup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LTitulo As Label
    Friend WithEvents LRuta As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class