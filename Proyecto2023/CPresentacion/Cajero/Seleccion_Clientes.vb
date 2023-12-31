﻿Imports System.Data.SqlClient
Imports System.Net
Imports System.Text.RegularExpressions

Public Class Baja_Clientes
    Dim conexion As SqlConnection
    Dim comando As SqlCommand
    Private Sub TBuscarDni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBuscarDni.KeyPress

        If (Char.IsNumber(e.KeyChar)) Then
            e.Handled = False
            TBuscarDni.MaxLength = 8

            If (TBuscarDni.Text.Length > 7) Then
                MessageBox.Show("El DNI tiene un máximo de 8 digitos", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        ElseIf (Char.IsControl(e.KeyChar)) Then

            e.Handled = False

        Else

            e.Handled = True
            MessageBox.Show("solo se permiten numeros", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If


    End Sub

    Private Sub TBuscarapellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBuscarapellido.KeyPress

        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("solo se permiten letras", "Avdertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Function EmailAddressCheck(ByVal emailaddress As String) As Boolean
        Dim pattern As String = "\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
        Dim emailAddressMatch As Match = Regex.Match(emailaddress, pattern)
        If emailAddressMatch.Success Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        verClientes()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        'Button1.Enabled = False
    End Sub



    Private Sub Baja_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBuscarapellido.Enabled = False
        TBuscarCorreo.Enabled = False
        TBuscarDni.Enabled = False
        DataGridView1.AllowUserToAddRows = False
        'Esta linea se quitará cuando se realizan las busquedas por cada campo
        'conexion = New SqlConnection("server = .\SQLEXPRESS; database = Proyecto2023; integrated security = true")
        verClientes()
    End Sub
    Public Sub verClientes()
        Try
            Dim nc As New NClientes
            Dim dt As DataTable = nc.verClientes()
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim ask As MsgBoxResult
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        ask = MsgBox("Desea Seleccionar este cliente? " + Me.DataGridView1.Item(1, i).Value.ToString + " " + Me.DataGridView1.Item(2, i).Value.ToString, vbYesNo + vbInformation, "Agregar Producto")
        If (MsgBoxResult.Yes = ask) Then
            Realizar_Venta.idCliente = Me.DataGridView1.Item(0, i).Value
            Realizar_Venta.TNombre.Text = Me.DataGridView1.Item(1, i).Value.ToString + " " + Me.DataGridView1.Item(2, i).Value.ToString
            Realizar_Venta.TDni.Text = Me.DataGridView1.Item(7, i).Value.ToString
            Me.Close()
        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        AgregarCliente.ShowDialog()
    End Sub

    'busqueda diámica con dni
    Public Sub buscarClienteDni(dni As String)
        Try
            Dim dc As New NClientes
            Dim dt As DataTable = dc.buscarClienteDni(dni)
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub buscarClienteApellido(apellido As String)
        Try
            Dim dc As New NClientes
            Dim dt As DataTable = dc.buscarClienteApellido(apellido)
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub buscarClienteCorreo(correo As String)
        Try
            Dim dc As New NClientes
            Dim dt As DataTable = dc.buscarClienteCorreo(correo)
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub RBDni_CheckedChanged(sender As Object, e As EventArgs) Handles RBDni.CheckedChanged
        If (RBDni.Checked) Then
            TBuscarapellido.Clear()
            TBuscarapellido.Enabled = False
            TBuscarCorreo.Clear()
            TBuscarCorreo.Enabled = False
            TBuscarDni.Enabled = True
        End If
    End Sub

    Private Sub RBApellido_CheckedChanged(sender As Object, e As EventArgs) Handles RBApellido.CheckedChanged
        If (RBApellido.Checked) Then

            TBuscarapellido.Enabled = True
            TBuscarCorreo.Enabled = False
            TBuscarCorreo.Clear()
            TBuscarDni.Enabled = False
            TBuscarDni.Clear()
        End If
    End Sub

    Private Sub RBCorreo_CheckedChanged(sender As Object, e As EventArgs) Handles RBCorreo.CheckedChanged
        If (RBCorreo.Checked) Then

            TBuscarDni.Clear()
            RBApellido.Checked = False
            TBuscarapellido.Clear()
            TBuscarapellido.Enabled = False
            TBuscarCorreo.Enabled = True
            TBuscarDni.Enabled = False
        End If
    End Sub

    Private Sub TBuscarDni_TextChanged(sender As Object, e As EventArgs) Handles TBuscarDni.TextChanged
        If TBuscarDni.Text <> "" Then
            listarPorDni(TBuscarDni.Text)
        Else
            verClientes()
        End If
    End Sub

    Public Sub listarPorDni(dni As String)
        Try
            Dim dc As New NClientes()
            Dim dt As DataTable = dc.buscarClienteDni(dni)
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TBuscarapellido_TextChanged(sender As Object, e As EventArgs) Handles TBuscarapellido.TextChanged
        If TBuscarapellido.Text <> "" Then
            buscarPorApellido(TBuscarapellido.Text)
        Else
            verClientes()
        End If
    End Sub

    Public Sub buscarPorApellido(apellido As String)
        Try
            Dim dc As New NClientes()
            Dim dt As DataTable = dc.buscarClienteApellido(apellido)
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TBuscarCorreo_TextChanged(sender As Object, e As EventArgs) Handles TBuscarCorreo.TextChanged
        If TBuscarCorreo.Text <> "" Then
            buscarPorCorreo(TBuscarCorreo.Text)
        Else
            verClientes()
        End If
    End Sub

    Public Sub buscarPorCorreo(correo As String)
        Try
            Dim dc As New NClientes()
            Dim dt As DataTable = dc.buscarClienteCorreo(correo)
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
