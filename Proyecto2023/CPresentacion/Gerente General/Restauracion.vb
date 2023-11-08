


Public Class Restauracion
    Dim back = New DBackup
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenFileDialog1.ShowDialog()
        TRestaurar.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ask As MsgBoxResult
        If (TRestaurar.Text = "") Then
            MsgBox("Selecciona el archivo de restaruacion del backup", MsgBoxStyle.Critical, "Atención")
        Else
            ask = MsgBox("Desea restaurar el backup desde la ruta seleccionada?", vbYesNo + vbInformation, "Confirmar")
            If (MsgBoxResult.Yes = ask) Then
                If back.restaurarDatos(TRestaurar.Text) Then

                    MsgBox("Restauración realizada con exito!", MsgBoxStyle.Information, "Restauración")
                    TRestaurar.Clear()
                Else
                    MsgBox("Restauracion incompleta", vbYes + MsgBoxStyle.Exclamation, "Restauración")

                End If

            End If
        End If

    End Sub

End Class