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
End Class