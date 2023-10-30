Imports System.Runtime.Remoting.Proxies

Public Class Seleccionar_Producto
    Dim idProducto As Integer
    Private Sub TcodigoProd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TcodigoProd.KeyPress

        If (Char.IsNumber(e.KeyChar)) Then

            e.Handled = False

        ElseIf (Char.IsControl(e.KeyChar)) Then

            e.Handled = False

        Else

            e.Handled = True
            MessageBox.Show("solo se permiten numeros", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If


    End Sub

    'Botón listar por categoria
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (CBCateg.Text = "") Then
            MsgBox("Selecciona un filtro de búsqueda", MsgBoxStyle.Information, "Atencion")
        Else
            MsgBox("Seleccionaste buscar por categoria: '" + CBCateg.Text + "'", MsgBoxStyle.Information, "Buscar")
            listarPorCategoria(CBCateg.Text)
        End If
    End Sub
    'Boton listar todos
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        verProductosActivos()
    End Sub
    'VER LOS PRODUCTOS ACTIVOS
    Public Sub verProductosActivos()
        Try
            Dim pv As New NProductos
            Dim dt As DataTable = pv.verProductosActivos()
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'LISTAR CATEGORIAS
    Public Sub verCategoriasCbx()
        Try
            Dim dc As New NCategorias
            Dim dt As DataTable = dc.verCategoriasCbx()
            CBCateg.DataSource = dt
            CBCateg.DisplayMember = "descripcion"
            CBCateg.ValueMember = "id_categoria"
            CBCateg.SelectedValue = -1

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'BUSCAR PRODUCTOS POR CODIGO
    Public Sub listarPorCodigo(codigo As String)
        Try
            Dim dp As New NProductos()
            Dim dt As DataTable = dp.buscarProductoCajeroCodigo(codigo)
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'LISTAR PRODUCTOS POR CATEGORIA
    Public Sub listarPorCategoria(categoria As String)
        Try
            Dim dp As New NProductos()
            Dim dt As DataTable = dp.buscarProductoCajeroCategoria(categoria)
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub TcodigoProd_TextChanged(sender As Object, e As EventArgs) Handles TcodigoProd.TextChanged

        listarPorCodigo(TcodigoProd.Text)
    End Sub

    Private Sub Seleccionar_Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.AllowUserToAddRows = False
        verProductosActivos()
        verCategoriasCbx()
    End Sub

    'Metodos para seleccionar el producto
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim ask As MsgBoxResult
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        ask = MsgBox("Seleccionar el Producto : '" + Me.DataGridView1.Item(2, i).Value.ToString + "' ?", MsgBoxStyle.YesNo, "Ver")
        If (MsgBoxResult.Yes = ask) Then
            idProducto = Me.DataGridView1.Item(0, i).Value
            seleccionarProductoCajero(idProducto)
            Me.Close()
        End If
    End Sub

    Public Sub seleccionarProductoCajero(id As Integer)
        Try
            Dim dp As New NProductos
            Dim dt As DataTable = dp.seleccionarProductoCajero(id)

            Realizar_Venta.TIdProd.Text = dt.Rows(0)(0).ToString
            Realizar_Venta.TNombreProd.Text = dt.Rows(0)(1).ToString
            Realizar_Venta.TCodigoProd.Text = dt.Rows(0)(2).ToString
            Realizar_Venta.TPrecioProd.Text = dt.Rows(0)(5).ToString
            Realizar_Venta.stock = Val(dt.Rows(0)(6).ToString)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class