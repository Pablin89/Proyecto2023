<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionProductos
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
        Me.GestionarProductos = New System.Windows.Forms.TabControl()
        Me.ConsultarProductos = New System.Windows.Forms.TabPage()
        Me.EditarProductos = New System.Windows.Forms.TabPage()
        Me.AgregarProductos = New System.Windows.Forms.TabPage()
        Me.GestionarProductos.SuspendLayout()
        Me.SuspendLayout()
        '
        'GestionarProductos
        '
        Me.GestionarProductos.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.GestionarProductos.Controls.Add(Me.ConsultarProductos)
        Me.GestionarProductos.Controls.Add(Me.EditarProductos)
        Me.GestionarProductos.Controls.Add(Me.AgregarProductos)
        Me.GestionarProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GestionarProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GestionarProductos.ItemSize = New System.Drawing.Size(180, 24)
        Me.GestionarProductos.Location = New System.Drawing.Point(0, 0)
        Me.GestionarProductos.Multiline = True
        Me.GestionarProductos.Name = "GestionarProductos"
        Me.GestionarProductos.SelectedIndex = 0
        Me.GestionarProductos.Size = New System.Drawing.Size(814, 621)
        Me.GestionarProductos.TabIndex = 0
        '
        'ConsultarProductos
        '
        Me.ConsultarProductos.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ConsultarProductos.Location = New System.Drawing.Point(4, 28)
        Me.ConsultarProductos.Name = "ConsultarProductos"
        Me.ConsultarProductos.Padding = New System.Windows.Forms.Padding(3)
        Me.ConsultarProductos.Size = New System.Drawing.Size(806, 589)
        Me.ConsultarProductos.TabIndex = 0
        Me.ConsultarProductos.Text = "Consultar Productos"
        '
        'EditarProductos
        '
        Me.EditarProductos.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.EditarProductos.Location = New System.Drawing.Point(4, 28)
        Me.EditarProductos.Name = "EditarProductos"
        Me.EditarProductos.Padding = New System.Windows.Forms.Padding(3)
        Me.EditarProductos.Size = New System.Drawing.Size(792, 418)
        Me.EditarProductos.TabIndex = 1
        Me.EditarProductos.Text = "Editar Productos"
        '
        'AgregarProductos
        '
        Me.AgregarProductos.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.AgregarProductos.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.AgregarProductos.Location = New System.Drawing.Point(4, 28)
        Me.AgregarProductos.Name = "AgregarProductos"
        Me.AgregarProductos.Padding = New System.Windows.Forms.Padding(3)
        Me.AgregarProductos.Size = New System.Drawing.Size(792, 418)
        Me.AgregarProductos.TabIndex = 2
        Me.AgregarProductos.Text = "Agregar nuevos productos"
        '
        'GestionProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 621)
        Me.Controls.Add(Me.GestionarProductos)
        Me.Name = "GestionProductos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion de Productos"
        Me.GestionarProductos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GestionarProductos As TabControl
    Friend WithEvents ConsultarProductos As TabPage
    Friend WithEvents EditarProductos As TabPage
    Friend WithEvents AgregarProductos As TabPage
End Class
