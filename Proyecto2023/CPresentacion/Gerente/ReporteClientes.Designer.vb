<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteClientes
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Proyecto2023DataSet = New Proyecto2023.Proyecto2023DataSet()
        Me.clientesMasComprasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.clientesMasComprasTableAdapter = New Proyecto2023.Proyecto2023DataSetTableAdapters.clientesMasComprasTableAdapter()
        Me.clientesMenosComprasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.clientesMenosComprasTableAdapter = New Proyecto2023.Proyecto2023DataSetTableAdapters.clientesMenosComprasTableAdapter()
        Me.ultimosClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ultimosClientesTableAdapter = New Proyecto2023.Proyecto2023DataSetTableAdapters.ultimosClientesTableAdapter()
        CType(Me.Proyecto2023DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clientesMasComprasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clientesMenosComprasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ultimosClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "ClientesMas"
        ReportDataSource1.Value = Me.clientesMasComprasBindingSource
        ReportDataSource2.Name = "ClientesMenos"
        ReportDataSource2.Value = Me.clientesMenosComprasBindingSource
        ReportDataSource3.Name = "ClientesUltimos"
        ReportDataSource3.Value = Me.ultimosClientesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto2023.ReporteClientes.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'Proyecto2023DataSet
        '
        Me.Proyecto2023DataSet.DataSetName = "Proyecto2023DataSet"
        Me.Proyecto2023DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'clientesMasComprasBindingSource
        '
        Me.clientesMasComprasBindingSource.DataMember = "clientesMasCompras"
        Me.clientesMasComprasBindingSource.DataSource = Me.Proyecto2023DataSet
        '
        'clientesMasComprasTableAdapter
        '
        Me.clientesMasComprasTableAdapter.ClearBeforeFill = True
        '
        'clientesMenosComprasBindingSource
        '
        Me.clientesMenosComprasBindingSource.DataMember = "clientesMenosCompras"
        Me.clientesMenosComprasBindingSource.DataSource = Me.Proyecto2023DataSet
        '
        'clientesMenosComprasTableAdapter
        '
        Me.clientesMenosComprasTableAdapter.ClearBeforeFill = True
        '
        'ultimosClientesBindingSource
        '
        Me.ultimosClientesBindingSource.DataMember = "ultimosClientes"
        Me.ultimosClientesBindingSource.DataSource = Me.Proyecto2023DataSet
        '
        'ultimosClientesTableAdapter
        '
        Me.ultimosClientesTableAdapter.ClearBeforeFill = True
        '
        'ReporteClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ReporteClientes"
        Me.Text = "ReporteClientes"
        CType(Me.Proyecto2023DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clientesMasComprasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clientesMenosComprasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ultimosClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents clientesMasComprasBindingSource As BindingSource
    Friend WithEvents Proyecto2023DataSet As Proyecto2023DataSet
    Friend WithEvents clientesMenosComprasBindingSource As BindingSource
    Friend WithEvents ultimosClientesBindingSource As BindingSource
    Friend WithEvents clientesMasComprasTableAdapter As Proyecto2023DataSetTableAdapters.clientesMasComprasTableAdapter
    Friend WithEvents clientesMenosComprasTableAdapter As Proyecto2023DataSetTableAdapters.clientesMenosComprasTableAdapter
    Friend WithEvents ultimosClientesTableAdapter As Proyecto2023DataSetTableAdapters.ultimosClientesTableAdapter
End Class
