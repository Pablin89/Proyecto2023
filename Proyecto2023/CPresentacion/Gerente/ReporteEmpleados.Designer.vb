<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReporteEmpleados
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Proyecto2023DataSet = New Proyecto2023.Proyecto2023DataSet()
        Me.EmpleadoMenosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadoMenosTableAdapter = New Proyecto2023.Proyecto2023DataSetTableAdapters.EmpleadoMenosTableAdapter()
        Me.EmpleadoMasVentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadoMasVentasTableAdapter = New Proyecto2023.Proyecto2023DataSetTableAdapters.EmpleadoMasVentasTableAdapter()
        Me.UltimosEmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UltimosEmpleadosTableAdapter = New Proyecto2023.Proyecto2023DataSetTableAdapters.UltimosEmpleadosTableAdapter()
        CType(Me.Proyecto2023DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoMenosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoMasVentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltimosEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "EmpleadoMenos"
        ReportDataSource1.Value = Me.EmpleadoMenosBindingSource
        ReportDataSource2.Name = "EmpleadoMas"
        ReportDataSource2.Value = Me.EmpleadoMasVentasBindingSource
        ReportDataSource3.Name = "UltimosEmpleados"
        ReportDataSource3.Value = Me.UltimosEmpleadosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto2023.Empleados.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(681, 618)
        Me.ReportViewer1.TabIndex = 0
        '
        'Proyecto2023DataSet
        '
        Me.Proyecto2023DataSet.DataSetName = "Proyecto2023DataSet"
        Me.Proyecto2023DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpleadoMenosBindingSource
        '
        Me.EmpleadoMenosBindingSource.DataMember = "EmpleadoMenos"
        Me.EmpleadoMenosBindingSource.DataSource = Me.Proyecto2023DataSet
        '
        'EmpleadoMenosTableAdapter
        '
        Me.EmpleadoMenosTableAdapter.ClearBeforeFill = True
        '
        'EmpleadoMasVentasBindingSource
        '
        Me.EmpleadoMasVentasBindingSource.DataMember = "EmpleadoMasVentas"
        Me.EmpleadoMasVentasBindingSource.DataSource = Me.Proyecto2023DataSet
        '
        'EmpleadoMasVentasTableAdapter
        '
        Me.EmpleadoMasVentasTableAdapter.ClearBeforeFill = True
        '
        'UltimosEmpleadosBindingSource
        '
        Me.UltimosEmpleadosBindingSource.DataMember = "UltimosEmpleados"
        Me.UltimosEmpleadosBindingSource.DataSource = Me.Proyecto2023DataSet
        '
        'UltimosEmpleadosTableAdapter
        '
        Me.UltimosEmpleadosTableAdapter.ClearBeforeFill = True
        '
        'ReporteEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 618)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ReporteEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ReporteCajeros"
        CType(Me.Proyecto2023DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoMenosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoMasVentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltimosEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents EmpleadoMenosBindingSource As BindingSource
    Friend WithEvents Proyecto2023DataSet As Proyecto2023DataSet
    Friend WithEvents EmpleadoMasVentasBindingSource As BindingSource
    Friend WithEvents UltimosEmpleadosBindingSource As BindingSource
    Friend WithEvents EmpleadoMenosTableAdapter As Proyecto2023DataSetTableAdapters.EmpleadoMenosTableAdapter
    Friend WithEvents EmpleadoMasVentasTableAdapter As Proyecto2023DataSetTableAdapters.EmpleadoMasVentasTableAdapter
    Friend WithEvents UltimosEmpleadosTableAdapter As Proyecto2023DataSetTableAdapters.UltimosEmpleadosTableAdapter
End Class
