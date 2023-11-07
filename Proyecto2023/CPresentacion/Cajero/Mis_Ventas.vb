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
            DataGridView1.Rows.Clear()
            verMisVentas(id)
        ElseIf (ComboBox1.SelectedIndex.Equals(1)) Then
            If (TDni.Text = "") Then
                MsgBox("Introduzca un DNI", MsgBoxStyle.Exclamation, "Atencion")
            Else
                DataGridView1.Rows.Clear()
                ventasPorDni(Val(TDni.Text))
                'MsgBox("Seleccionaste buscar por 'Cliente especifico': " + TDni.Text, MsgBoxStyle.Information, "Buscar")
            End If
        ElseIf (ComboBox1.SelectedIndex.Equals(2)) Then
            DataGridView1.Rows.Clear()
            ventasPorTipoDePago(1)
            'MsgBox("Seleccionaste buscar por 'Efectivo'", MsgBoxStyle.Information, "Buscar")
        ElseIf (ComboBox1.SelectedIndex.Equals(3)) Then
            DataGridView1.Rows.Clear()
            ventasPorTipoDePago(2)
            'MsgBox("Seleccionaste buscar por 'Débito'", MsgBoxStyle.Information, "Buscar")
        ElseIf (ComboBox1.SelectedIndex.Equals(4)) Then
            DataGridView1.Rows.Clear()
            ventasPorTipoDePago(3)
            'MsgBox("Seleccionaste buscar por 'Crédito'", MsgBoxStyle.Information, "Buscar")
        ElseIf (ComboBox1.SelectedIndex.Equals(5)) Then
            DataGridView1.Rows.Clear()
            ventasPorTipoDePago(4)
            'MsgBox("Seleccionaste buscar por 'Mercado Pago'", MsgBoxStyle.Information, "Buscar")
        ElseIf (ComboBox1.SelectedIndex.Equals(6)) Then
            DataGridView1.Rows.Clear()
            ventasPorFecha(DateTimePicker1.Text, DateTimePicker2.Text)
            'MsgBox("Seleccionaste buscar por 'Rango de Fechas'", MsgBoxStyle.Information, "Buscar")
        End If
    End Sub

    'Listar todas las ventas
    Public Sub verMisVentas(id As Integer)
        Try
            Dim nv As New NVentas
            Dim dt As DataTable = nv.verMisVentas(id)
            'DataGridView1.DataSource = dt
            For j = 0 To (dt.Rows.Count - 1)
                DataGridView1.Rows.Add(dt.Rows(j)(0), Format(dt.Rows(j)(1).Date, "dd-mm-yyyy"), dt.Rows(j)(2).ToString, dt.Rows(j)(3).ToString, dt.Rows(j)(4).ToString, "Detalle")
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Listar las ventas por DNI del cliente
    Public Sub ventasPorDni(dni As Integer)
        Try
            Dim nv As New NVentas
            Dim dt As DataTable = nv.ventasPorDni(dni)
            'DataGridView1.DataSource = dt
            For j = 0 To (dt.Rows.Count - 1)
                DataGridView1.Rows.Add(dt.Rows(j)(0), Format(dt.Rows(j)(1).Date, "dd-mm-yyyy"), dt.Rows(j)(2).ToString, dt.Rows(j)(3).ToString, dt.Rows(j)(4).ToString, "Detalle")
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Listar ventas por tipo de Pago
    Public Sub ventasPorTipoDePago(id_tipo As Integer)
        Try
            Dim nv As New NVentas
            Dim dt As DataTable = nv.ventasPorTipoDePago(id_tipo)

            For j = 0 To (dt.Rows.Count - 1)
                DataGridView1.Rows.Add(dt.Rows(j)(0), Format(dt.Rows(j)(1).Date, "dd-mm-yyyy"), dt.Rows(j)(2).ToString, dt.Rows(j)(3).ToString, dt.Rows(j)(4).ToString, "Detalle")
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Listar ventas por rango de fecha
    Public Sub ventasPorFecha(desde As Date, hasta As Date)
        Try
            Dim nv As New NVentas
            Dim dt As DataTable = nv.ventasPorFecha(desde, hasta)

            For j = 0 To (dt.Rows.Count - 1)
                DataGridView1.Rows.Add(dt.Rows(j)(0), Format(dt.Rows(j)(1).Date, "dd-mm-yyyy"), dt.Rows(j)(2).ToString, dt.Rows(j)(3).ToString, dt.Rows(j)(4).ToString, "Detalle")
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim col As Integer = DataGridView1.CurrentCell.ColumnIndex
        Dim opcion As MsgBoxResult

        If (col = 5) Then
            opcion = MsgBox("Ver detalle de la venta?", vbYesNo + vbDefaultButton2 + vbInformation, "Detalle")
            If (opcion = DialogResult.Yes) Then
                'DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
                MsgBox("Se mostrará el detalle de la venta")
            End If
        End If
    End Sub
End Class