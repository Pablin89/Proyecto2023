<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mis_ventas
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabVentasFecha = New System.Windows.Forms.TabPage()
        Me.TabVentasClientes = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabVentasGeneral = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.TabVentasFecha.SuspendLayout()
        Me.TabVentasClientes.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabVentasGeneral.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(270, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar una venta realizada"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabVentasGeneral)
        Me.TabControl1.Controls.Add(Me.TabVentasFecha)
        Me.TabControl1.Controls.Add(Me.TabVentasClientes)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(800, 377)
        Me.TabControl1.TabIndex = 1
        '
        'TabVentasFecha
        '
        Me.TabVentasFecha.Controls.Add(Me.Panel5)
        Me.TabVentasFecha.Controls.Add(Me.Panel4)
        Me.TabVentasFecha.Controls.Add(Me.Panel3)
        Me.TabVentasFecha.Location = New System.Drawing.Point(4, 22)
        Me.TabVentasFecha.Name = "TabVentasFecha"
        Me.TabVentasFecha.Padding = New System.Windows.Forms.Padding(3)
        Me.TabVentasFecha.Size = New System.Drawing.Size(792, 351)
        Me.TabVentasFecha.TabIndex = 0
        Me.TabVentasFecha.Text = "Ventas por fecha"
        Me.TabVentasFecha.UseVisualStyleBackColor = True
        '
        'TabVentasClientes
        '
        Me.TabVentasClientes.Controls.Add(Me.DataGridView3)
        Me.TabVentasClientes.Controls.Add(Me.Panel8)
        Me.TabVentasClientes.Controls.Add(Me.Panel7)
        Me.TabVentasClientes.Location = New System.Drawing.Point(4, 22)
        Me.TabVentasClientes.Name = "TabVentasClientes"
        Me.TabVentasClientes.Padding = New System.Windows.Forms.Padding(3)
        Me.TabVentasClientes.Size = New System.Drawing.Size(792, 351)
        Me.TabVentasClientes.TabIndex = 1
        Me.TabVentasClientes.Text = "Ventas por clientes"
        Me.TabVentasClientes.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 73)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 377)
        Me.Panel1.TabIndex = 2
        '
        'TabVentasGeneral
        '
        Me.TabVentasGeneral.Controls.Add(Me.DataGridView1)
        Me.TabVentasGeneral.Controls.Add(Me.Panel2)
        Me.TabVentasGeneral.Controls.Add(Me.Panel6)
        Me.TabVentasGeneral.Location = New System.Drawing.Point(4, 22)
        Me.TabVentasGeneral.Name = "TabVentasGeneral"
        Me.TabVentasGeneral.Size = New System.Drawing.Size(792, 351)
        Me.TabVentasGeneral.TabIndex = 2
        Me.TabVentasGeneral.Text = "Ventas generales"
        Me.TabVentasGeneral.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(786, 100)
        Me.Panel3.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.DataGridView2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(3, 103)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(399, 245)
        Me.Panel4.TabIndex = 1
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(399, 245)
        Me.DataGridView2.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(408, 103)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(381, 245)
        Me.Panel5.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(792, 100)
        Me.Panel6.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(411, 100)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(381, 251)
        Me.Panel2.TabIndex = 3
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Black
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(3, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(786, 96)
        Me.Panel7.TabIndex = 0
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel8.Location = New System.Drawing.Point(408, 99)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(381, 249)
        Me.Panel8.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 100)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(411, 251)
        Me.DataGridView1.TabIndex = 4
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView3.Location = New System.Drawing.Point(3, 99)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(405, 249)
        Me.DataGridView3.TabIndex = 4
        '
        'Mis_ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Mis_ventas"
        Me.Text = "Mis_ventas"
        Me.TabControl1.ResumeLayout(False)
        Me.TabVentasFecha.ResumeLayout(False)
        Me.TabVentasClientes.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TabVentasGeneral.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabVentasGeneral As TabPage
    Friend WithEvents TabVentasFecha As TabPage
    Friend WithEvents TabVentasClientes As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel7 As Panel
End Class
