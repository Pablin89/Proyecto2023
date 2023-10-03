Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Mis_ventas

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




    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        If (ComboBox1.Text = "Cliente especifico") Then
            TDni.Visible = True
            LDni.Visible = True
        Else
            TDni.Visible = False
            LDni.Visible = False
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (ComboBox1.SelectedIndex.Equals(-1)) Then
            MsgBox("Selecciona un filtro de búsqueda", MsgBoxStyle.Information, "Atencion")
        ElseIf (ComboBox1.SelectedIndex.Equals(0)) Then
            MsgBox("Seleccionaste buscar por 'Todos las ventas'", MsgBoxStyle.Information, "Buscar")
        ElseIf (ComboBox1.SelectedIndex.Equals(1)) Then
            If (TDni.Text = "") Then
                MsgBox("Introduzca un DNI", MsgBoxStyle.Exclamation, "Atencion")
            Else
                MsgBox("Seleccionaste buscar por 'Cliente especifico': " + TDni.Text, MsgBoxStyle.Information, "Buscar")
            End If
        ElseIf (ComboBox1.SelectedIndex.Equals(2)) Then
            MsgBox("Seleccionaste buscar por 'Ventas con tarjeta'", MsgBoxStyle.Information, "Buscar")
        ElseIf (ComboBox1.SelectedIndex.Equals(3)) Then
            MsgBox("Seleccionaste buscar por 'Ventas con Mercado Pago'", MsgBoxStyle.Information, "Buscar")
        ElseIf (ComboBox1.SelectedIndex.Equals(4)) Then
            MsgBox("Seleccionaste buscar por 'Ventas en efectivo'", MsgBoxStyle.Information, "Buscar")
        End If
    End Sub
End Class