<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionCajeros
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
        Me.GestionarCajeros = New System.Windows.Forms.TabControl()
        Me.ConsultarCajeros = New System.Windows.Forms.TabPage()
        Me.EditarCajeros = New System.Windows.Forms.TabPage()
        Me.AgregarCajeros = New System.Windows.Forms.TabPage()
        Me.GestionarCajeros.SuspendLayout()
        Me.SuspendLayout()
        '
        'GestionarCajeros
        '
        Me.GestionarCajeros.Controls.Add(Me.ConsultarCajeros)
        Me.GestionarCajeros.Controls.Add(Me.EditarCajeros)
        Me.GestionarCajeros.Controls.Add(Me.AgregarCajeros)
        Me.GestionarCajeros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GestionarCajeros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GestionarCajeros.Location = New System.Drawing.Point(0, 0)
        Me.GestionarCajeros.Name = "GestionarCajeros"
        Me.GestionarCajeros.SelectedIndex = 0
        Me.GestionarCajeros.Size = New System.Drawing.Size(814, 621)
        Me.GestionarCajeros.TabIndex = 0
        '
        'ConsultarCajeros
        '
        Me.ConsultarCajeros.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ConsultarCajeros.Location = New System.Drawing.Point(4, 25)
        Me.ConsultarCajeros.Name = "ConsultarCajeros"
        Me.ConsultarCajeros.Padding = New System.Windows.Forms.Padding(3)
        Me.ConsultarCajeros.Size = New System.Drawing.Size(806, 592)
        Me.ConsultarCajeros.TabIndex = 0
        Me.ConsultarCajeros.Text = "Consultar Cajeros"
        '
        'EditarCajeros
        '
        Me.EditarCajeros.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.EditarCajeros.Location = New System.Drawing.Point(4, 25)
        Me.EditarCajeros.Name = "EditarCajeros"
        Me.EditarCajeros.Padding = New System.Windows.Forms.Padding(3)
        Me.EditarCajeros.Size = New System.Drawing.Size(792, 421)
        Me.EditarCajeros.TabIndex = 1
        Me.EditarCajeros.Text = "Editar Cajeros"
        '
        'AgregarCajeros
        '
        Me.AgregarCajeros.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.AgregarCajeros.Location = New System.Drawing.Point(4, 25)
        Me.AgregarCajeros.Name = "AgregarCajeros"
        Me.AgregarCajeros.Size = New System.Drawing.Size(792, 421)
        Me.AgregarCajeros.TabIndex = 2
        Me.AgregarCajeros.Text = "Agregar Cajeros"
        '
        'GestionCajeros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 621)
        Me.Controls.Add(Me.GestionarCajeros)
        Me.Name = "GestionCajeros"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion de Cajeros"
        Me.GestionarCajeros.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GestionarCajeros As TabControl
    Friend WithEvents ConsultarCajeros As TabPage
    Friend WithEvents EditarCajeros As TabPage
    Friend WithEvents AgregarCajeros As TabPage
End Class
