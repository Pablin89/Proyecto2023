﻿Public Class Login

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciarLogin()
    End Sub

    Public Sub iniciarLogin()
        'CajeroPrincipal.Close()
        'Cajero_Principal.Close()
        'GerenteGral_Principal.Close()
        'Gerente_Principal.Close()
        TUsuario.Focus()
    End Sub



    Private Sub Blogin_Click(sender As Object, e As EventArgs) Handles BLogin.Click

        If ((TUsuario.Text = "") And (TContraseña.Text = "")) Then
            MessageBox.Show("Completa los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Show()
        ElseIf TUsuario.Text = "Encargado" Then
            Me.Hide()
            Cajero_Principal.Show()

        ElseIf TUsuario.Text = "GerenteGral" Then
            Me.Hide()
            GerenteGral_Principal.Show()
        ElseIf TUsuario.Text = "Cajero" Then
            Me.Hide()
            CajeroPrincipal.Show()

        ElseIf TUsuario.Text = "Gerente" Then
            Me.Hide()
            Gerente_Principal.Show()
        Else
            MsgBox("Usuario incorrecto", MsgBoxStyle.Critical, "Error")
        End If
        TUsuario.Clear()

    End Sub


End Class