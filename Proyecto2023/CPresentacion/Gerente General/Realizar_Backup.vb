Public Class Realizar_Backup
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenFileDialog1.ShowDialog()
        TBackup.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ask As MsgBoxResult
        If (TBackup.Text = "") Then
            MsgBox("Selecciona un destino para guardar el backup", MsgBoxStyle.Critical, "Atención")
        Else
            ask = MsgBox("Desea realizar el backup en la ruta seleccionada?", vbYesNo + vbInformation, "Confirmar")
            If (MsgBoxResult.Yes = ask) Then
                MsgBox("Backup realizado con exito!", MsgBoxStyle.Information, "Backup")
                TBackup.Clear()
            End If
        End If

    End Sub
End Class