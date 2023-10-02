<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Restauracion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Restauracion))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TRestaurar = New System.Windows.Forms.TextBox()
        Me.LRuta = New System.Windows.Forms.Label()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(340, 249)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 38)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Restaurar Backup"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TRestaurar
        '
        Me.TRestaurar.Location = New System.Drawing.Point(261, 181)
        Me.TRestaurar.Name = "TRestaurar"
        Me.TRestaurar.Size = New System.Drawing.Size(342, 20)
        Me.TRestaurar.TabIndex = 7
        '
        'LRuta
        '
        Me.LRuta.AutoSize = True
        Me.LRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LRuta.Location = New System.Drawing.Point(65, 182)
        Me.LRuta.Name = "LRuta"
        Me.LRuta.Size = New System.Drawing.Size(190, 16)
        Me.LRuta.TabIndex = 6
        Me.LRuta.Text = "Ingresar Ruta de Restauración"
        '
        'LTitulo
        '
        Me.LTitulo.AutoSize = True
        Me.LTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.Location = New System.Drawing.Point(324, 43)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(154, 20)
        Me.LTitulo.TabIndex = 5
        Me.LTitulo.Text = "Restaurar Backup"
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(609, 170)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 40)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Buscar ruta"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button2.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Restauracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TRestaurar)
        Me.Controls.Add(Me.LRuta)
        Me.Controls.Add(Me.LTitulo)
        Me.Name = "Restauracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Restauracion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents TRestaurar As TextBox
    Friend WithEvents LRuta As Label
    Friend WithEvents LTitulo As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
