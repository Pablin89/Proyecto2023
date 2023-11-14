Public Class ModificarUsuario
    Dim item As Integer
    Private Sub ModificarUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        verEmpleadosConUsuario()
        BConfirmarPerfil.Visible = False
        TContraseña.Enabled = False
        ChBContraseña.Visible = False
    End Sub

    Private Sub BConfirmarPerfil_Click(sender As Object, e As EventArgs) Handles BConfirmarPerfil.Click
        MsgBox("Se ha asignado correctamente el perfil al empleado", MsgBoxStyle.Information, "Perfil Asignado")
        BConfirmarPerfil.Visible = False
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

        Dim ask As MsgBoxResult
        Dim i As Integer
        i = DataGridView2.CurrentRow.Index

        ask = MsgBox("Ver detalle del Empleado: '" + Me.DataGridView2.Item(2, i).Value.ToString + "' ?", MsgBoxStyle.YesNo, "Ver")
        If (MsgBoxResult.Yes = ask) Then
            item = Me.DataGridView2.Item(0, i).Value
            seleccionarUsuarioConsultar(item)
            BConfirmarPerfil.Visible = True
            TContraseña.Visible = False
            ChBContraseña.Visible = True
        End If
    End Sub

    Public Sub seleccionarUsuarioConsultar(id As Integer)

        Try
            Dim nu As New NUsuarios
            Dim dt As DataTable = nu.seleccionarUsuarioConsultar(id)
            'DataGridView2.DataSource = dt
            TApeynom.Text = dt.Rows(0)(1).ToString + " " + dt.Rows(0)(2).ToString
            TDni.Text = dt.Rows(0)(3).ToString
            TCorreo.Text = dt.Rows(0)(5).ToString
            TTelefono.Text = dt.Rows(0)(7).ToString
            TNombreUsuario.Text = dt.Rows(0)(8).ToString
            ComboBox1.Text = dt.Rows(0)(9).ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Lista de empleados con usuario asignado
    Public Sub verEmpleadosConUsuario()
        Try
            Dim ne As New NEmpleados
            Dim dt As DataTable = ne.verEmpleadosConUsuario()
            DataGridView2.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ChBContraseña_CheckedChanged(sender As Object, e As EventArgs) Handles ChBContraseña.CheckedChanged
        Dim ask As MsgBoxResult

        If ChBContraseña.Checked Then
            ask = MsgBox("Si se activa este campo se debe ingresar una nueva contraseña para el usuario. Desea establecer una nueva contraseña para este usuario?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Contraseña nueva")
            If ask = MsgBoxResult.Yes Then
                ChBContraseña.Visible = False
                TContraseña.Visible = True
                TContraseña.Enabled = True

            Else
                ChBContraseña.Checked = False
            End If




        End If
    End Sub

    Private Sub ModificarUsuarios_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        TContraseña.Clear()
        TNombreUsuario.Clear()
        TApeynom.Clear()
        TTelefono.Clear()
        TCorreo.Clear()
        TDni.Clear()
        ComboBox1.SelectedIndex = -1
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If (CheckBox2.Checked) Then
            CheckBox1.Checked = False
            CheckBox3.Checked = False
            TextBox4.Enabled = True
            TextBox3.Enabled = False
            TextBox1.Enabled = False
            TextBox3.Clear()
            TextBox1.Clear()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked) Then
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            TextBox3.Enabled = True
            TextBox4.Enabled = False
            TextBox1.Enabled = False
            TextBox4.Clear()
            TextBox1.Clear()
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If (CheckBox3.Checked) Then
            CheckBox2.Checked = False
            CheckBox1.Checked = False
            TextBox1.Enabled = True
            TextBox4.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Clear()
            TextBox3.Clear()
        End If
    End Sub

    Private Sub TDni_TextChanged(sender As Object, e As EventArgs) Handles TDni.TextChanged

    End Sub

    Private Sub TCorreo_TextChanged(sender As Object, e As EventArgs) Handles TCorreo.TextChanged

    End Sub

    Private Sub TTelefono_TextChanged(sender As Object, e As EventArgs) Handles TTelefono.TextChanged

    End Sub

    Private Sub TApeynom_TextChanged(sender As Object, e As EventArgs) Handles TApeynom.TextChanged

    End Sub

    Private Sub TContraseña_TextChanged(sender As Object, e As EventArgs) Handles TContraseña.TextChanged

    End Sub

    Private Sub TNombreUsuario_TextChanged(sender As Object, e As EventArgs) Handles TNombreUsuario.TextChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub LContraseña_Click(sender As Object, e As EventArgs) Handles LContraseña.Click

    End Sub

    Private Sub LNombreUsuario_Click(sender As Object, e As EventArgs) Handles LNombreUsuario.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class