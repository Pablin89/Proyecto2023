Public Class DetalleVenta
    Private Sub Detalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim opcion As MsgBoxResult

        opcion = MsgBox("Generar factura?", vbYesNo + vbDefaultButton2 + vbInformation, "Facturar")

        If (opcion = DialogResult.Yes) Then
            imprimirFactura()
        End If
    End Sub

    Public Sub imprimirFactura()
        Dim miForm As New VentaRealizada
        Dim dfactura As New ReporteFactura
        dfactura.reporteFactura(Val(LNroVenta.Text))
        miForm.NombreReporte = "Proyecto2023.Venta.rdlc"
        miForm.Show()
    End Sub
End Class