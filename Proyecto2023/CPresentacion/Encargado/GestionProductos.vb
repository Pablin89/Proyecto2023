Public Class GestionProductos
    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress

        Call entradaDecimal(TextBox6, e)


    End Sub

    Public Sub entradaDecimal(sender As TextBox, e As KeyPressEventArgs)

        Dim cadena As String = sender.Text
        Dim filtro As String = "1234567890"

        If Len(cadena) > 0 Then
            filtro += "."
        End If


        For Each caracter In filtro
            If e.KeyChar = caracter Then
                e.Handled = False
                Exit For
            Else
                e.Handled = True
            End If
        Next

        If e.KeyChar = "0" And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then
            sender.Text = ""
            MessageBox.Show("solo se permiten un cero al principio", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf e.KeyChar <> "0" And e.KeyChar <> "." And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then
            sender.Text = ""
        End If





        If Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If


        If e.KeyChar = "." And Not cadena.IndexOf(".") Then
            e.Handled = True
            MessageBox.Show("ya ingresaste el punto decimal", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


    End Sub


    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress

        If (Char.IsNumber(e.KeyChar)) Then

            e.Handled = False

        ElseIf (Char.IsControl(e.KeyChar)) Then

            e.Handled = False

        Else

            e.Handled = True
            MessageBox.Show("solo se permiten numeros", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If


    End Sub

    Private Sub TextBox13_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox13.KeyPress

        If (Char.IsNumber(e.KeyChar)) Then

            e.Handled = False

        ElseIf (Char.IsControl(e.KeyChar)) Then

            e.Handled = False

        Else

            e.Handled = True
            MessageBox.Show("solo se permiten numeros", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If


    End Sub

    Private Sub TextBox12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox12.KeyPress

        If (Char.IsNumber(e.KeyChar)) Then

            e.Handled = False

        ElseIf (Char.IsControl(e.KeyChar)) Then

            e.Handled = False

        Else

            e.Handled = True
            MessageBox.Show("solo se permiten numeros", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ask As MsgBoxResult

        If ((TextBox5.Text <> "") And
            (TextBox6.Text <> "") And
            (ComboBox1.Text <> "") And
            (TextBox7.Text <> "") And
            (TextBox13.Text <> "") And
            (TextBox12.Text <> "") And
            (TDescripcion2.Text <> "") And
            (ComboBox1.Text <> "")
            ) Then



            ask = MsgBox("Seguro desea agregar producto?", MsgBoxStyle.YesNo, "Confirmar inserción")

            If ask = MsgBoxResult.Yes Then
                MsgBox("Nuevo producto agregado", MsgBoxStyle.OkOnly, "Cliente insertado")
                TextBox5.Text = ""
                TextBox6.Text = ""
                ComboBox1.Text = ""
                TextBox7.Text = ""
                TextBox13.Text = ""
                TextBox12.Text = ""
                TDescripcion2.Text = ""
                ComboBox1.Text = ""
            Else
                MsgBox("No se agregó el producto", MsgBoxStyle.OkOnly, "Cliente insertado")

            End If


        Else

            MsgBox("Debe completar todos los campos", MsgBoxStyle.Exclamation, "Error")

        End If

    End Sub
End Class