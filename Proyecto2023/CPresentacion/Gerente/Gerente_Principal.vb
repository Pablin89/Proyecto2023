Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Gerente_Principal
    Private Sub Productos_Click(sender As Object, e As EventArgs) Handles Productos.Click
        Informes.LTitulo.Text = "Informes de Productos"
        Informes.ComboBox1.Items.Add("Productos más vendidos")
        Informes.ComboBox1.Items.Add("Productos menos vendidos")
        Informes.ComboBox1.Items.Add("Categorias mas vendidas")
        Informes.ComboBox1.Items.Add("Categorias menos vendidas")
        Informes.ShowDialog()
    End Sub

    Private Sub Cajeros_Click(sender As Object, e As EventArgs) Handles Cajeros.Click
        Informes.LTitulo.Text = "Informes de Empleados"
        Informes.ComboBox1.Items.Add("Empleados con mas ventas")
        Informes.ComboBox1.Items.Add("Empleados con menos ventas")
        Informes.ComboBox1.Items.Add("Últimos empleados añadidos")
        Informes.ShowDialog()
    End Sub

    Private Sub BajaClientes_Click(sender As Object, e As EventArgs) Handles InformesClientes.Click
        Informes.LTitulo.Text = "Informes de Clientes"
        Informes.ComboBox1.Items.Add("Clientes con mas compras")
        Informes.ComboBox1.Items.Add("Clientes con menos compras")
        Informes.ComboBox1.Items.Add("Ultimos clientes añadidos")
        Informes.ShowDialog()
    End Sub

    Private Sub BCerrarSesion_Click(sender As Object, e As EventArgs) Handles BCerrarSesion.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("Desea cerrar su sesión?", vbYesNo + vbInformation, "Cerrar Sesión")
        If (MsgBoxResult.Yes = ask) Then

            Login.Show()
            Me.Hide()
            Login.iniciarLogin()
        End If
    End Sub


    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles InformesFechas.Click
        Informes.LFechaDesde.Visible = True
        Informes.LFechaHasta.Visible = True
        Informes.DateTimeDesde.Visible = True
        Informes.DateTimeHasta.Visible = True
        Informes.LTitulo.Text = "Informes de Ventas"
        Informes.ComboBox1.Items.Add("Ventas por fechas")

        Informes.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Misdatos.BModificarP.Visible = False
        Misdatos.ShowDialog()
    End Sub


End Class