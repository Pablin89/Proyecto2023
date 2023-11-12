Imports System.Net

Public Class Baja_Ventas
    'Recoger el id de la venta
    Dim idVenta
    Private Sub Baja_Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Visible = False
        Label2.Visible = False
        Label6.Visible = False
        DateTimePicker1.Enabled = False
        DateTimePicker2.Enabled = False
        ComboBox1.SelectedIndex = -1

        DataGridView1.AllowUserToAddRows = False
        listarTodasLasVentas()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

        If (Char.IsNumber(e.KeyChar)) Then
            e.Handled = False
            TextBox1.MaxLength = 8

            If (TextBox1.Text.Length > 7) Then
                MessageBox.Show("El DNI tiene un máximo de 8 digitos", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        ElseIf (Char.IsControl(e.KeyChar)) Then

            e.Handled = False

        Else

            e.Handled = True
            MessageBox.Show("solo se permiten numeros", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        If (ComboBox1.Text = "Cliente especifico") Then
            TextBox1.Visible = True
            Label2.Visible = True
            Label6.Visible = False
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False
        ElseIf (ComboBox1.Text = "Empleado específico") Then
            TextBox1.Visible = True
            Label2.Visible = False
            Label6.Visible = True
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False
        ElseIf (ComboBox1.Text = "Por Fechas") Then
            TextBox1.Visible = False
            Label2.Visible = False
            Label6.Visible = False
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True
        Else
            TextBox1.Visible = False
            Label2.Visible = False
            Label6.Visible = False
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (ComboBox1.SelectedIndex.Equals(-1)) Then
            MsgBox("Selecciona un filtro de búsqueda", MsgBoxStyle.Information, "Atencion")
        ElseIf (ComboBox1.SelectedIndex.Equals(0)) Then
            listarTodasLasVentas()
            'MsgBox("Seleccionaste buscar por 'Todos las ventas'", MsgBoxStyle.Information, "Buscar")
        ElseIf (ComboBox1.SelectedIndex.Equals(1)) Then
            If (TextBox1.Text = "") Then
                MsgBox("Introduzca un DNI", MsgBoxStyle.Exclamation, "Atencion")
            Else
                buscarPorCliente(Val(TextBox1.Text))
                'MsgBox("Seleccionaste buscar por 'Cliente especifico': " + TextBox1.Text, MsgBoxStyle.Information, "Buscar")
            End If
        ElseIf (ComboBox1.SelectedIndex.Equals(2)) Then
            If (TextBox1.Text = "") Then
                MsgBox("Introduzca un DNI", MsgBoxStyle.Exclamation, "Atencion")
            Else
                buscarPorEmpleado(Val(TextBox1.Text))
                'MsgBox("Seleccionaste buscar 'Por Empleado especifico': " + TextBox1.Text, MsgBoxStyle.Information, "Buscar")
            End If
        ElseIf (ComboBox1.SelectedIndex.Equals(3)) Then
            buscarPorTipoPago(1)
            'MsgBox("Seleccionaste buscar por 'Ventas en Efectivo'", MsgBoxStyle.Information, "Buscar")
        ElseIf (ComboBox1.SelectedIndex.Equals(4)) Then
            buscarPorTipoPago(2)
            'MsgBox("Seleccionaste buscar por 'Ventas con Débito'", MsgBoxStyle.Information, "Buscar")
        ElseIf (ComboBox1.SelectedIndex.Equals(5)) Then
            buscarPorTipoPago(3)
            'MsgBox("Seleccionaste buscar por 'Ventas en Crédito'", MsgBoxStyle.Information, "Buscar")
        ElseIf (ComboBox1.SelectedIndex.Equals(6)) Then
            buscarPorTipoPago(4)
            'MsgBox("Seleccionaste buscar por 'Ventas con Mercado Pago'", MsgBoxStyle.Information, "Buscar")
        ElseIf (ComboBox1.SelectedIndex.Equals(7)) Then
            buscarPorFecha(DateTimePicker1.Text, DateTimePicker2.Text)
            'MsgBox("Seleccionaste buscar por 'Ventas por Fecha'", MsgBoxStyle.Information, "Buscar")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        MsgBox("No Seleccionaste ninguna venta para cancelar", MsgBoxStyle.Critical, "Error")
    End Sub

    'METODOS DE VENTAS PARA ENCARGADO --------------------------------------------------------------------------------------------------------
    'Listar las ventas de los empleados
    Public Sub listarTodasLasVentas()
        Try
            DataGridView1.Rows.Clear()
            Dim nv As New NVentas
            Dim dt As DataTable = nv.listarTodasLasVentas()
            'DataGridView1.DataSource = dt
            For j = 0 To (dt.Rows.Count - 1)

                If (dt.Rows(j)(5).ToString = "Activo") Then

                    DataGridView1.Rows.Add(dt.Rows(j)(0), dt.Rows(j)(1).ToString, Format(dt.Rows(j)(2).Date, "dd-MM-yyyy"), dt.Rows(j)(3).ToString, dt.Rows(j)(4).ToString, "Desactivar", "Detalle")

                Else

                    DataGridView1.Rows.Add(dt.Rows(j)(0), dt.Rows(j)(1).ToString, Format(dt.Rows(j)(2).Date, "dd-MM-yyyy"), dt.Rows(j)(3).ToString, dt.Rows(j)(4).ToString, "Activar", "Detalle")

                End If

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub buscarPorCliente(dni)
        Try
            DataGridView1.Rows.Clear()
            Dim nv As New NVentas
            Dim dt As DataTable = nv.buscarPorCliente(dni)
            'DataGridView1.DataSource = dt
            For j = 0 To (dt.Rows.Count - 1)

                If (dt.Rows(j)(5).ToString = "Activo") Then

                    DataGridView1.Rows.Add(dt.Rows(j)(0), dt.Rows(j)(1).ToString, Format(dt.Rows(j)(2).Date, "dd-MM-yyyy"), dt.Rows(j)(3).ToString, dt.Rows(j)(4).ToString, "Desactivar", "Detalle")

                Else

                    DataGridView1.Rows.Add(dt.Rows(j)(0), dt.Rows(j)(1).ToString, Format(dt.Rows(j)(2).Date, "dd-MM-yyyy"), dt.Rows(j)(3).ToString, dt.Rows(j)(4).ToString, "Activar", "Detalle")

                End If

            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub buscarPorEmpleado(dni)
        Try
            DataGridView1.Rows.Clear()
            Dim nv As New NVentas
            Dim dt As DataTable = nv.buscarPorEmpleado(dni)
            'DataGridView1.DataSource = dt
            For j = 0 To (dt.Rows.Count - 1)

                If (dt.Rows(j)(5).ToString = "Activo") Then

                    DataGridView1.Rows.Add(dt.Rows(j)(0), dt.Rows(j)(1).ToString, Format(dt.Rows(j)(2).Date, "dd-MM-yyyy"), dt.Rows(j)(3).ToString, dt.Rows(j)(4).ToString, "Desactivar", "Detalle")

                Else

                    DataGridView1.Rows.Add(dt.Rows(j)(0), dt.Rows(j)(1).ToString, Format(dt.Rows(j)(2).Date, "dd-MM-yyyy"), dt.Rows(j)(3).ToString, dt.Rows(j)(4).ToString, "Activar", "Detalle")

                End If

            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub buscarPorTipoPago(id_pago)
        Try
            DataGridView1.Rows.Clear()
            Dim nv As New NVentas
            Dim dt As DataTable = nv.buscarPorTipoPago(id_pago)
            'DataGridView1.DataSource = dt
            For j = 0 To (dt.Rows.Count - 1)

                If (dt.Rows(j)(5).ToString = "Activo") Then

                    DataGridView1.Rows.Add(dt.Rows(j)(0), dt.Rows(j)(1).ToString, Format(dt.Rows(j)(2).Date, "dd-MM-yyyy"), dt.Rows(j)(3).ToString, dt.Rows(j)(4).ToString, "Desactivar", "Detalle")

                Else

                    DataGridView1.Rows.Add(dt.Rows(j)(0), dt.Rows(j)(1).ToString, Format(dt.Rows(j)(2).Date, "dd-MM-yyyy"), dt.Rows(j)(3).ToString, dt.Rows(j)(4).ToString, "Activar", "Detalle")

                End If

            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub buscarPorFecha(desde, hasta)
        Try
            DataGridView1.Rows.Clear()
            Dim nv As New NVentas
            Dim dt As DataTable = nv.buscarPorFecha(desde, hasta)
            'DataGridView1.DataSource = dt
            For j = 0 To (dt.Rows.Count - 1)

                If (dt.Rows(j)(5).ToString = "Activo") Then

                    DataGridView1.Rows.Add(dt.Rows(j)(0), dt.Rows(j)(1).ToString, Format(dt.Rows(j)(2).Date, "dd-MM-yyyy"), dt.Rows(j)(3).ToString, dt.Rows(j)(4).ToString, "Desactivar", "Detalle")

                Else

                    DataGridView1.Rows.Add(dt.Rows(j)(0), dt.Rows(j)(1).ToString, Format(dt.Rows(j)(2).Date, "dd-MM-yyyy"), dt.Rows(j)(3).ToString, dt.Rows(j)(4).ToString, "Activar", "Detalle")

                End If

            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub activarVenta(idVenta)
        Try
            Dim nv As New NVentas
            nv.activarVenta(idVenta)
            listarTodasLasVentas()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub desactivarVenta(idVenta)
        Try
            Dim nv As New NVentas
            nv.desactivarVenta(idVenta)
            listarTodasLasVentas()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim col As Integer = DataGridView1.CurrentCell.ColumnIndex
        Dim opcion As MsgBoxResult

        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        If (col = 6) Then
            opcion = MsgBox("Ver detalle de la venta?", vbYesNo + vbDefaultButton2 + vbInformation, "Detalle")
            If (opcion = DialogResult.Yes) Then

                Dim id_vta As Integer = Me.DataGridView1.Item(0, i).Value

                Mis_ventas.seleccionarVenta(id_vta)
                Mis_ventas.verDetalle(id_vta)
                DetalleVenta.Button1.Visible = False

                DetalleVenta.Show()

            End If
        End If

        If (col = 5) Then

            If (Me.DataGridView1.Item(5, i).Value.ToString = "Desactivar") Then

                opcion = MsgBox("quiere Desactivar la venta?", vbYesNo + vbDefaultButton2 + vbInformation, "Desactivar")
                If (opcion = DialogResult.Yes) Then

                    Dim id_vta As Integer = Me.DataGridView1.Item(0, i).Value

                    desactivarVenta(id_vta)
                    MsgBox("La venta se Nº " + id_vta.ToString + " desactivó correctamente", MsgBoxStyle.Information, "Ok")
                End If

            Else

                opcion = MsgBox("quiere Activar la venta?", vbYesNo + vbDefaultButton2 + vbInformation, "Desactivar")
                If (opcion = DialogResult.Yes) Then

                    Dim id_vta As Integer = Me.DataGridView1.Item(0, i).Value

                    activarVenta(id_vta)
                    MsgBox("La venta Nº " + id_vta.ToString + " se activó correctamente", MsgBoxStyle.Information, "Ok")
                End If

            End If

        End If
    End Sub


End Class