Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Realizar_Venta

    'Restricciones
    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress

        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("solo se permiten letras", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress

        If (Char.IsNumber(e.KeyChar)) Then
            e.Handled = False
            TextBox6.MaxLength = 8

            If (TextBox6.Text.Length > 7) Then
                MessageBox.Show("El DNI tiene un máximo de 8 digitos", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        ElseIf (Char.IsControl(e.KeyChar)) Then

            e.Handled = False

        Else

            e.Handled = True
            MessageBox.Show("solo se permiten numeros", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If


    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Baja_Clientes.ShowDialog()
    End Sub

    Private Sub BBuscarProducto_Click(sender As Object, e As EventArgs) Handles BBuscarProducto.Click
        Seleccionar_Producto.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LFecha.Text = DateAndTime.Today.ToLongDateString
        LHora.Text = DateAndTime.TimeOfDay
    End Sub

    Private Sub Realizar_Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        DataGridView1.AllowUserToAddRows = False
    End Sub

    Private Sub BRealizarVenta_Click(sender As Object, e As EventArgs) Handles BRealizarVenta.Click
        If (DataGridView1.RowCount.ToString() = 0) Then
            MsgBox("Agrega algún producto a la compra", MsgBoxStyle.Critical, "Atención")
        End If
    End Sub

    Private Sub BVaciarCarrito_Click(sender As Object, e As EventArgs) Handles BVaciarCarrito.Click
        If (DataGridView1.Rows.Count > 0) Then
            For Each Fila As DataGridViewRow In DataGridView1.Rows
                DataGridView1.Rows.Clear()
                'DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
            Next
        End If
    End Sub

    Private Sub BAgregarAlCarrito_Click(sender As Object, e As EventArgs) Handles BAgregarAlCarrito.Click
        Dim vasoPrecio As Integer = 500
        Dim bombillaPrecio As Integer = 300
        If (TextBox1.Text = "" Or NumericUpDown1.Text = 0) Then
            MsgBox("Debe seleccionar un producto", MsgBoxStyle.Critical, "Atención")
        ElseIf (TextBox1.Text = "vaso" Or TextBox1.Text = "Vaso") Then
            DataGridView1.Rows.Add(TextBox1.Text, vasoPrecio, NumericUpDown1.Text, NumericUpDown1.Text * vasoPrecio, "Eliminar")
        ElseIf (TextBox1.Text = "Bombilla" Or TextBox1.Text = "bombilla") Then
            DataGridView1.Rows.Add(TextBox1.Text, bombillaPrecio, NumericUpDown1.Text, NumericUpDown1.Text * bombillaPrecio, "Eliminar")
        End If
    End Sub
End Class