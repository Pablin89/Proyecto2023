﻿Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Categoría
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (TextBox1.Text = "") Then
            MsgBox("ingrese la nueva categoría", MsgBoxStyle.Exclamation, "Atención")
        Else
            If existeCategoria() = True Then
                MsgBox("Ya existe: " + TextBox1.Text, MsgBoxStyle.Critical, "Error")
            Else
                MsgBox("Categoría: '" + TextBox1.Text + "' Agregada", MsgBoxStyle.Information, "Agregada")
                'GestionProductos.ComboBox1.Items.Add(TextBox1.Text)
                agregarCategoria()
                verCategorias()
                GestionProductos.comboboxCategorias()

            End If


            'Me.Close()
        End If
    End Sub

    Public Sub verCategorias()
        Try
            Dim dc As New NCategorias
            Dim dt As DataTable = dc.verCategorias()
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Categoría_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.AllowUserToAddRows = False
        verCategorias()
    End Sub

    Public Sub agregarCategoria()
        Dim descripcion As String = TextBox1.Text
        Try
            Dim ccateg As New NCategorias()
            ccateg.insertarCategoria(descripcion)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function existeCategoria()
        Dim descripcion As String = TextBox1.Text
        Try
            Dim ct As New NCategorias()
            Return ct.existeCategoria(descripcion)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

End Class