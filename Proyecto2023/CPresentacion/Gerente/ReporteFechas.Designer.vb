<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteFechas
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Proyecto2023DataSet = New Proyecto2023.Proyecto2023DataSet()
        Me.VentasFechasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentasFechasTableAdapter = New Proyecto2023.Proyecto2023DataSetTableAdapters.VentasFechasTableAdapter()
        CType(Me.Proyecto2023DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasFechasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "Fechas"
        ReportDataSource2.Value = Me.VentasFechasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto2023.ReporteFechas.rdlc"
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
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'Proyecto2023DataSet
        '
        Me.Proyecto2023DataSet.DataSetName = "Proyecto2023DataSet"
        Me.Proyecto2023DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VentasFechasBindingSource
        '
        Me.VentasFechasBindingSource.DataMember = "VentasFechas"
        Me.VentasFechasBindingSource.DataSource = Me.Proyecto2023DataSet
        '
        'VentasFechasTableAdapter
        '
        Me.VentasFechasTableAdapter.ClearBeforeFill = True
        '
        'ReporteFechas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReporteFechas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ReporteFechas"
        CType(Me.Proyecto2023DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasFechasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents VentasFechasBindingSource As BindingSource
    Friend WithEvents Proyecto2023DataSet As Proyecto2023DataSet
    Friend WithEvents VentasFechasTableAdapter As Proyecto2023DataSetTableAdapters.VentasFechasTableAdapter
End Class
