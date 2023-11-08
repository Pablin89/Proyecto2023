Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Mis_ventas
    Public id As Integer
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDni.KeyPress

        If (Char.IsNumber(e.KeyChar)) Then
            e.Handled = False
            TDni.MaxLength = 8

            If (TDni.Text.Length > 7) Then
                MessageBox.Show("El DNI tiene un máximo de 8 digitos", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        ElseIf (Char.IsControl(e.KeyChar)) Then

            e.Handled = False

        Else

            e.Handled = True
            MessageBox.Show("solo se permiten numeros", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If


    End Sub
    Private Sub Mis_ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TDni.Visible = False
        LDni.Visible = False
        DateTimePicker1.Enabled = False
        DateTimePicker2.Enabled = False
        DataGridView1.AllowUserToAddRows = False
        verMisVentas(id)


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        If (ComboBox1.Text = "Cliente especifico") Then
            TDni.Visible = True
            LDni.Visible = True
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False

        ElseIf (ComboBox1.Text = "Por Rango de Fechas") Then
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True
            TDni.Visible = False
            LDni.Visible = False
        Else
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False
            TDni.Visible = False
            LDni.Visible = False
        End If

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (ComboBox1.SelectedIndex.Equals(-1)) Then
            MsgBox("Selecciona un filtro de búsqueda", MsgBoxStyle.Information, "Atencion")
        ElseIf (ComboBox1.SelectedIndex.Equals(0)) Then
            'MsgBox("Seleccionaste buscar por 'Todos las ventas'", MsgBoxStyle.Information, "Buscar")

            verMisVentas(id)
        ElseIf (ComboBox1.SelectedIndex.Equals(1)) Then
            If (TDni.Text = "") Then
                MsgBox("Introduzca un DNI", MsgBoxStyle.Exclamation, "Atencion")
            Else

                ventasPorDni(Val(TDni.Text))
                'MsgBox("Seleccionaste buscar por 'Cliente especifico': " + TDni.Text, MsgBoxStyle.Information, "Buscar")
            End If
        ElseIf (ComboBox1.SelectedIndex.Equals(2)) Then

            ventasPorTipoDePago(1)
            'MsgBox("Seleccionaste buscar por 'Efectivo'", MsgBoxStyle.Information, "Buscar")
        ElseIf (ComboBox1.SelectedIndex.Equals(3)) Then

            ventasPorTipoDePago(2)
            'MsgBox("Seleccionaste buscar por 'Débito'", MsgBoxStyle.Information, "Buscar")
        ElseIf (ComboBox1.SelectedIndex.Equals(4)) Then

            ventasPorTipoDePago(3)
            'MsgBox("Seleccionaste buscar por 'Crédito'", MsgBoxStyle.Information, "Buscar")
        ElseIf (ComboBox1.SelectedIndex.Equals(5)) Then

            ventasPorTipoDePago(4)
            'MsgBox("Seleccionaste buscar por 'Mercado Pago'", MsgBoxStyle.Information, "Buscar")
        ElseIf (ComboBox1.SelectedIndex.Equals(6)) Then

            ventasPorFecha(DateTimePicker1.Text, DateTimePicker2.Text)
            'MsgBox("Seleccionaste buscar por 'Rango de Fechas'", MsgBoxStyle.Information, "Buscar")
        End If
    End Sub

    'Listar todas las ventas
    Public Sub verMisVentas(id As Integer)
        Try
            DataGridView1.Rows.Clear()
            Dim nv As New NVentas
            Dim dt As DataTable = nv.verMisVentas(id)
            'DataGridView1.DataSource = dt
            For j = 0 To (dt.Rows.Count - 1)
                DataGridView1.Rows.Add(dt.Rows(j)(0), Format(dt.Rows(j)(1).Date, "dd-MM-yyyy"), dt.Rows(j)(2).ToString, dt.Rows(j)(3).ToString, dt.Rows(j)(4).ToString, "Detalle")
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Listar las ventas por DNI del cliente
    Public Sub ventasPorDni(dni As Integer)
        Try
            DataGridView1.Rows.Clear()
            Dim nv As New NVentas
            Dim dt As DataTable = nv.ventasPorDni(dni)
            'DataGridView1.DataSource = dt
            For j = 0 To (dt.Rows.Count - 1)
                DataGridView1.Rows.Add(dt.Rows(j)(0), Format(dt.Rows(j)(1).Date, "dd-MM-yyyy"), dt.Rows(j)(2).ToString, dt.Rows(j)(3).ToString, dt.Rows(j)(4).ToString, "Detalle")
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Listar ventas por tipo de Pago
    Public Sub ventasPorTipoDePago(id_tipo As Integer)
        Try
            DataGridView1.Rows.Clear()
            Dim nv As New NVentas
            Dim dt As DataTable = nv.ventasPorTipoDePago(id_tipo)

            For j = 0 To (dt.Rows.Count - 1)
                DataGridView1.Rows.Add(dt.Rows(j)(0), Format(dt.Rows(j)(1).Date, "dd-MM-yyyy"), dt.Rows(j)(2).ToString, dt.Rows(j)(3).ToString, dt.Rows(j)(4).ToString, "Detalle")
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Listar ventas por rango de fecha
    Public Sub ventasPorFecha(desde As Date, hasta As Date)
        Try
            DataGridView1.Rows.Clear()
            Dim nv As New NVentas
            Dim dt As DataTable = nv.ventasPorFecha(desde, hasta)

            For j = 0 To (dt.Rows.Count - 1)
                DataGridView1.Rows.Add(dt.Rows(j)(0), Format(dt.Rows(j)(1).Date, "dd-MM-yyyy"), dt.Rows(j)(2).ToString, dt.Rows(j)(3).ToString, dt.Rows(j)(4).ToString, "Detalle")
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim col As Integer = DataGridView1.CurrentCell.ColumnIndex
        Dim opcion As MsgBoxResult

        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        If (col = 5) Then
            opcion = MsgBox("Ver detalle de la venta?", vbYesNo + vbDefaultButton2 + vbInformation, "Detalle")
            If (opcion = DialogResult.Yes) Then

                Dim id_vta As Integer = Me.DataGridView1.Item(0, i).Value

                seleccionarVenta(id_vta)
                verDetalle(id_vta)

                DetalleVenta.Show()
            End If
        End If
    End Sub

    'METODOS PARA MOSTRAR EL DETALLE DE LA VENTA---------------------------------------------------------------------------------------------------------------
    'Metodo para el encabezado de la venta
    Public Sub seleccionarVenta(id As Integer)
        Try
            Dim dv As New NVentas
            Dim dt As DataTable = dv.seleccionarVenta(id)

            DetalleVenta.LNroVenta.Text = dt.Rows(0)(0).ToString
            DetalleVenta.LFechaCompra.Text = Format(dt.Rows(0)(1), "dd-MM-yyyy")
            DetalleVenta.LTotal.Text = dt.Rows(0)(2).ToString
            DetalleVenta.LTipoPago.Text = dt.Rows(0)(3).ToString
            DetalleVenta.LCliente.Text = dt.Rows(0)(4).ToString + " " + dt.Rows(0)(5).ToString + " DNI: " + dt.Rows(0)(6).ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ' Ver detalle de la venta
    Public Sub verDetalle(id As Integer)
        Try
            Dim dd As New NDetalles
            Dim dt As DataTable = dd.verDetalle(id)
            DetalleVenta.DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class