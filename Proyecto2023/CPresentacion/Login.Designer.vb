<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.BLogin = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TUsuario = New System.Windows.Forms.TextBox()
        Me.TContraseña = New System.Windows.Forms.TextBox()
        Me.LContraseña = New System.Windows.Forms.Label()
        Me.LUsuario = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BLogin
        '
        Me.BLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BLogin.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BLogin.Image = Global.Proyecto2023.My.Resources.Resources.Login
        Me.BLogin.Location = New System.Drawing.Point(83, 124)
        Me.BLogin.Name = "BLogin"
        Me.BLogin.Size = New System.Drawing.Size(110, 42)
        Me.BLogin.TabIndex = 1
        Me.BLogin.Text = "Ingresar"
        Me.BLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BLogin.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TUsuario)
        Me.Panel2.Controls.Add(Me.TContraseña)
        Me.Panel2.Controls.Add(Me.LContraseña)
        Me.Panel2.Controls.Add(Me.LUsuario)
        Me.Panel2.Controls.Add(Me.BLogin)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 271)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(281, 179)
        Me.Panel2.TabIndex = 3
        '
        'TUsuario
        '
        Me.TUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TUsuario.Location = New System.Drawing.Point(100, 28)
        Me.TUsuario.Name = "TUsuario"
        Me.TUsuario.Size = New System.Drawing.Size(151, 21)
        Me.TUsuario.TabIndex = 1
        '
        'TContraseña
        '
        Me.TContraseña.Location = New System.Drawing.Point(100, 76)
        Me.TContraseña.Name = "TContraseña"
        Me.TContraseña.Size = New System.Drawing.Size(151, 20)
        Me.TContraseña.TabIndex = 5
        Me.TContraseña.UseSystemPasswordChar = True
        '
        'LContraseña
        '
        Me.LContraseña.AutoSize = True
        Me.LContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LContraseña.Location = New System.Drawing.Point(17, 77)
        Me.LContraseña.Name = "LContraseña"
        Me.LContraseña.Size = New System.Drawing.Size(77, 16)
        Me.LContraseña.TabIndex = 3
        Me.LContraseña.Text = "Contraseña"
        '
        'LUsuario
        '
        Me.LUsuario.AutoSize = True
        Me.LUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LUsuario.Location = New System.Drawing.Point(39, 29)
        Me.LUsuario.Name = "LUsuario"
        Me.LUsuario.Size = New System.Drawing.Size(55, 16)
        Me.LUsuario.TabIndex = 2
        Me.LUsuario.Text = "Usuario"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Proyecto2023.My.Resources.Resources.Logo
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(281, 265)
        Me.Panel1.TabIndex = 2
        '
        'Login
        '
        Me.AcceptButton = Me.BLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BLogin As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TContraseña As TextBox
    Friend WithEvents LContraseña As Label
    Friend WithEvents LUsuario As Label
    Friend WithEvents TUsuario As TextBox
End Class
