Imports Microsoft.Reporting.WinForms

Public Class Informes
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ask As MsgBoxResult
        If ComboBox1.Items.Contains("Productos más vendidos") Then



            ask = MsgBox("Se realizará un reporte con datos generales de los productos", vbYesNo + vbInformation, "Informe")
            If ask = MsgBoxResult.Yes Then
                ReporteProductos.ShowDialog()
            End If
        ElseIf ComboBox1.Items.Contains("Empleados con mas ventas") Then

            ask = MsgBox("Se realizará un reporte con datos generales de los Empleados. (Se tiene en cuenta el último mes a partir de la fecha de realizacion del informe)", vbYesNo + vbInformation, "Informe")
            If ask = MsgBoxResult.Yes Then
                ReporteEmpleados.ShowDialog()
            End If
        ElseIf ComboBox1.Items.Contains("Ventas por fechas") Then
            Dim dt1 As Date
            dt1 = DateTimeDesde.Text
            Dim dt2 As Date
            dt2 = DateTimeHasta.Text

            Dim p As New ReportParameter("FechaDesde", dt1.Date)
            ReporteFechas.ReportViewer1.LocalReport.SetParameters(p)

            p = New ReportParameter("FechaHasta", dt2.Date)
            ReporteFechas.ReportViewer1.LocalReport.SetParameters(p)



            ask = MsgBox("Se realizará un reporte con las ventas realizadas en el rango de fecha seleccionado", vbYesNo + vbInformation, "Informe")
            If ask = MsgBoxResult.Yes Then
                ReporteFechas.ShowDialog()
            End If
        ElseIf ComboBox1.Items.Contains("Clientes con mas compras") Then

            ask = MsgBox("Se realizará un reporte con datos generales de los Clientes. (Se tiene en cuenta el último mes a partir de la fecha de realizacion del informe)", vbYesNo + vbInformation, "Informe")
            If ask = MsgBoxResult.Yes Then
                ReporteClientes.ShowDialog()
            End If

        End If




    End Sub

    Private Sub Informes_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Informes_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        LFechaDesde.Visible = False
        LFechaHasta.Visible = False
        DateTimeDesde.Visible = False
        DateTimeHasta.Visible = False
        ComboBox1.Items.Clear()
        ComboBox1.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim filtro As String = ComboBox1.Text
        Select Case filtro
            Case "Productos más vendidos"
                verProductosMasVendidos()
                LFiltroSeleccionado.Text = "Productos más vendidos"
            Case "Productos menos vendidos"
                verProductosMenosVendidos()
                LFiltroSeleccionado.Text = "Productos menos vendidos"
            Case "Categorias mas vendidas"
                verCategoriasMasVendidas()
                LFiltroSeleccionado.Text = "Categorias mas vendidas"
            Case "Categorias menos vendidas"
                verCategoriasMenosVendidas()
                LFiltroSeleccionado.Text = "Categorias menos vendidas"
            Case "Empleados con mas ventas"
                verEmpleadosConMasVentas()
                LFiltroSeleccionado.Text = "Empleados con mas ventas"
            Case "Empleados con menos ventas"
                verEmpleadosConMasVentas()
                LFiltroSeleccionado.Text = "Empleados con menos ventas"
            Case "Últimos empleados añadidos"
                verUltimosEmpleados()
                LFiltroSeleccionado.Text = "Últimos empleados añadidos"
            Case "Clientes con mas compras"
                verClientesMasCompras()
                LFiltroSeleccionado.Text = "Clientes con mas compras"
            Case "Clientes con menos compras"
                verClientesMenosCompras()
                LFiltroSeleccionado.Text = "Clientes con menos compras"
            Case "Ultimos clientes añadidos"
                verUltimosClientes()
                LFiltroSeleccionado.Text = "Ultimos clientes añadidos"
            Case "Ventas por fechas"
                ventasPorFechas()
                LFiltroSeleccionado.Text = "Ventas por fechas"
        End Select
    End Sub


    Public Sub verProductosMasVendidos()
        Try
            Dim np As New NProductos
            Dim dt As DataTable = np.verProductosMasVendidos()
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub verProductosMenosVendidos()
        Try
            Dim np As New NProductos
            Dim dt As DataTable = np.verProductosMenosVendidos()
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub verCategoriasMasVendidas()
        Try
            Dim np As New NProductos
            Dim dt As DataTable = np.verCategoriasMasVendidas()
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub verCategoriasMenosVendidas()
        Try
            Dim np As New NProductos
            Dim dt As DataTable = np.verCategoriasMenosVendidas()
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub verEmpleadosConMasVentas()
        Try
            Dim nu As New NUsuarios
            Dim dt As DataTable = nu.verEmpleadosConMasVentas()
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub verEmpleadosConMenosVentas()
        Try
            Dim nu As New NUsuarios
            Dim dt As DataTable = nu.verEmpleadosConMenosVentas()
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub verUltimosEmpleados()
        Try
            Dim ne As New NEmpleados
            Dim dt As DataTable = ne.verUltimosEmpleados()
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub verClientesMasCompras()
        Try
            Dim nc As New NClientes
            Dim dt As DataTable = nc.verClientesMasCompras()
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub verClientesMenosCompras()
        Try
            Dim nc As New NClientes
            Dim dt As DataTable = nc.verClientesMenosCompras()
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub verUltimosClientes()
        Try
            Dim nc As New NClientes
            Dim dt As DataTable = nc.verUltimosClientes()
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub ventasPorFechas()
        Dim desde As Date = DateTimeDesde.Value.ToString("yyyy-MM-dd")
        Dim hasta As Date = DateTimeHasta.Value.ToString("yyyy-MM-dd")

        Try
            Dim nv As New NVentas
            Dim dt As DataTable = nv.ventasPorFechasGerente(desde, hasta)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class