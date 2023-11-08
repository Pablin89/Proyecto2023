<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RBackup
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtServidor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboBaseDatos = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNom_Backup = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDirPathBackup = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtServidor)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboBaseDatos)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNom_Backup)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtDirPathBackup)
        Me.GroupBox1.Location = New System.Drawing.Point(93, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(614, 184)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacion del Backup"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(37, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(538, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Observación: por cuestiones de seguridad la carpeta de destino de los archivos de" &
    " backup está predeterminada."
        '
        'txtServidor
        '
        Me.txtServidor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServidor.Location = New System.Drawing.Point(83, 40)
        Me.txtServidor.Name = "txtServidor"
        Me.txtServidor.Size = New System.Drawing.Size(207, 22)
        Me.txtServidor.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Servidor:"
        '
        'cboBaseDatos
        '
        Me.cboBaseDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBaseDatos.FormattingEnabled = True
        Me.cboBaseDatos.Location = New System.Drawing.Point(397, 38)
        Me.cboBaseDatos.Margin = New System.Windows.Forms.Padding(2)
        Me.cboBaseDatos.Name = "cboBaseDatos"
        Me.cboBaseDatos.Size = New System.Drawing.Size(188, 24)
        Me.cboBaseDatos.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(301, 43)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 16)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Base de dato:"
        '
        'txtNom_Backup
        '
        Me.txtNom_Backup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNom_Backup.Location = New System.Drawing.Point(148, 109)
        Me.txtNom_Backup.MaxLength = 20
        Me.txtNom_Backup.Name = "txtNom_Backup"
        Me.txtNom_Backup.Size = New System.Drawing.Size(437, 22)
        Me.txtNom_Backup.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 16)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Directorio destino:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 16)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Nombre del Backup:"
        '
        'txtDirPathBackup
        '
        Me.txtDirPathBackup.Enabled = False
        Me.txtDirPathBackup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirPathBackup.Location = New System.Drawing.Point(136, 73)
        Me.txtDirPathBackup.Name = "txtDirPathBackup"
        Me.txtDirPathBackup.Size = New System.Drawing.Size(449, 22)
        Me.txtDirPathBackup.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(339, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 18)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Backup"
        '
        'btnBackup
        '
        Me.btnBackup.BackColor = System.Drawing.Color.Teal
        Me.btnBackup.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBackup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackup.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBackup.Image = Global.Proyecto2023.My.Resources.Resources.Drive_Backup_23188
        Me.btnBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBackup.Location = New System.Drawing.Point(301, 339)
        Me.btnBackup.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(185, 60)
        Me.btnBackup.TabIndex = 35
        Me.btnBackup.Text = "Crear Backup"
        Me.btnBackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnBackup.UseVisualStyleBackColor = False
        '
        'RBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnBackup)
        Me.Controls.Add(Me.Label5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RBackup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "RBackup"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtServidor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboBaseDatos As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNom_Backup As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDirPathBackup As TextBox
    Friend WithEvents btnBackup As Button
    Friend WithEvents Label5 As Label
End Class
