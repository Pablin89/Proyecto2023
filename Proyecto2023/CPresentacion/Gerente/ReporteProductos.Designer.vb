<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteProductos
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.CategoriasMasVendidasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Proyecto2023DataSet = New Proyecto2023.Proyecto2023DataSet()
        Me.CategoriasMenosVendidasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.productosMasVendidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.productosMenosVendidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriasMasVendidasTableAdapter = New Proyecto2023.Proyecto2023DataSetTableAdapters.CategoriasMasVendidasTableAdapter()
        Me.CategoriasMenosVendidasTableAdapter = New Proyecto2023.Proyecto2023DataSetTableAdapters.CategoriasMenosVendidasTableAdapter()
        Me.productosMasVendidosTableAdapter = New Proyecto2023.Proyecto2023DataSetTableAdapters.productosMasVendidosTableAdapter()
        Me.productosMenosVendidosTableAdapter = New Proyecto2023.Proyecto2023DataSetTableAdapters.productosMenosVendidosTableAdapter()
        CType(Me.CategoriasMasVendidasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Proyecto2023DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriasMenosVendidasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productosMasVendidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productosMenosVendidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "CategoriasMas"
        ReportDataSource1.Value = Me.CategoriasMasVendidasBindingSource
        ReportDataSource2.Name = "CategoriasMenos"
        ReportDataSource2.Value = Me.CategoriasMenosVendidasBindingSource
        ReportDataSource3.Name = "ProductosMas"
        ReportDataSource3.Value = Me.productosMasVendidosBindingSource
        ReportDataSource4.Name = "ProductosMenos"
        ReportDataSource4.Value = Me.productosMenosVendidosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto2023.Productos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.ShowBackButton = False
        Me.ReportViewer1.ShowContextMenu = False
        Me.ReportViewer1.ShowCredentialPrompts = False
        Me.ReportViewer1.ShowDocumentMapButton = False
        Me.ReportViewer1.ShowExportButton = False
        Me.ReportViewer1.ShowFindControls = False
        Me.ReportViewer1.ShowPageNavigationControls = False
        Me.ReportViewer1.ShowParameterPrompts = False
        Me.ReportViewer1.ShowProgress = False
        Me.ReportViewer1.ShowPromptAreaButton = False
        Me.ReportViewer1.ShowRefreshButton = False
        Me.ReportViewer1.ShowStopButton = False
        Me.ReportViewer1.ShowZoomControl = False
        Me.ReportViewer1.Size = New System.Drawing.Size(839, 748)
        Me.ReportViewer1.TabIndex = 0
        '
        'CategoriasMasVendidasBindingSource
        '
        Me.CategoriasMasVendidasBindingSource.DataMember = "CategoriasMasVendidas"
        Me.CategoriasMasVendidasBindingSource.DataSource = Me.Proyecto2023DataSet
        '
        'Proyecto2023DataSet
        '
        Me.Proyecto2023DataSet.DataSetName = "Proyecto2023DataSet"
        Me.Proyecto2023DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CategoriasMenosVendidasBindingSource
        '
        Me.CategoriasMenosVendidasBindingSource.DataMember = "CategoriasMenosVendidas"
        Me.CategoriasMenosVendidasBindingSource.DataSource = Me.Proyecto2023DataSet
        '
        'productosMasVendidosBindingSource
        '
        Me.productosMasVendidosBindingSource.DataMember = "productosMasVendidos"
        Me.productosMasVendidosBindingSource.DataSource = Me.Proyecto2023DataSet
        '
        'productosMenosVendidosBindingSource
        '
        Me.productosMenosVendidosBindingSource.DataMember = "productosMenosVendidos"
        Me.productosMenosVendidosBindingSource.DataSource = Me.Proyecto2023DataSet
        '
        'CategoriasMasVendidasTableAdapter
        '
        Me.CategoriasMasVendidasTableAdapter.ClearBeforeFill = True
        '
        'CategoriasMenosVendidasTableAdapter
        '
        Me.CategoriasMenosVendidasTableAdapter.ClearBeforeFill = True
        '
        'productosMasVendidosTableAdapter
        '
        Me.productosMasVendidosTableAdapter.ClearBeforeFill = True
        '
        'productosMenosVendidosTableAdapter
        '
        Me.productosMenosVendidosTableAdapter.ClearBeforeFill = True
        '
        'ReporteProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 748)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReporteProductos"
        Me.Text = "ReporteGeneral"
        CType(Me.CategoriasMasVendidasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Proyecto2023DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriasMenosVendidasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productosMasVendidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productosMenosVendidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CategoriasMasVendidasBindingSource As BindingSource
    Friend WithEvents Proyecto2023DataSet As Proyecto2023DataSet
    Friend WithEvents CategoriasMenosVendidasBindingSource As BindingSource
    Friend WithEvents productosMasVendidosBindingSource As BindingSource
    Friend WithEvents productosMenosVendidosBindingSource As BindingSource
    Friend WithEvents CategoriasMasVendidasTableAdapter As Proyecto2023DataSetTableAdapters.CategoriasMasVendidasTableAdapter
    Friend WithEvents CategoriasMenosVendidasTableAdapter As Proyecto2023DataSetTableAdapters.CategoriasMenosVendidasTableAdapter
    Friend WithEvents productosMasVendidosTableAdapter As Proyecto2023DataSetTableAdapters.productosMasVendidosTableAdapter
    Friend WithEvents productosMenosVendidosTableAdapter As Proyecto2023DataSetTableAdapters.productosMenosVendidosTableAdapter
End Class
