Imports System.Text
Imports System.Data.SqlClient


Public Class RBackup
    Public m As New DBackup
    Dim nombre As String = "Copia_" + Date.Today.Day.ToString + "-" + Date.Today.Month.ToString + "-" + Date.Today.Year.ToString + "_" + Date.Now.Hour.ToString + "." + Date.Now.Minute.ToString

    Private Sub btnBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackup.Click


        If crear_backup() = True Then
            MsgBox("El backup fué realizado con el nombre de " + nombre + "", vbOKOnly + vbInformation, "Realizar Backup")
            txtDirPathBackup.Text = "E:\Copias de Seguridad\Proyecto2023"
        Else
            MsgBox("No se puede realizar el backup", vbOKOnly + vbCritical, "Realizar Backup")
        End If


    End Sub

    Private Function crear_backup() As Boolean

        Dim conecsb As New SqlConnectionStringBuilder
        conecsb.DataSource = Me.txtServidor.Text
        conecsb.InitialCatalog = "master"
        conecsb.IntegratedSecurity = True

        If txtDirPathBackup.Text.Length <> 3 Then
            txtDirPathBackup.Text = txtDirPathBackup.Text + "\" + txtNom_Backup.Text + ".bak"
        Else
            txtDirPathBackup.Text = txtDirPathBackup.Text + txtNom_Backup.Text + ".bak"
        End If

        Using con As New SqlConnection(conecsb.ConnectionString)
            Try
                con.Open()
                Dim sCmd As New StringBuilder

                sCmd.Append("BACKUP DATABASE [" + cboBaseDatos.Text + "] TO  DISK = N'" + txtDirPathBackup.Text + "' ")
                sCmd.Append("WITH DESCRIPTION = N'', NOFORMAT, NOINIT, ")
                sCmd.Append("NAME = N'" + txtNom_Backup.Text + "', SKIP, NOREWIND, NOUNLOAD,  STATS = 10")
                Dim cmd As New SqlCommand(sCmd.ToString, con)
                cmd.ExecuteNonQuery()
                crear_backup = True
            Catch ex As Exception
                crear_backup = False
                MessageBox.Show(ex.Message)
            Finally
                con.Close()
            End Try
        End Using



    End Function



    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtServidor.Text = ".\SQLEXPRESS"
        txtServidor.Enabled = False
        cboBaseDatos.Text = "Proyecto2023"
        cboBaseDatos.Enabled = False
        txtDirPathBackup.Text = "E:\Copias de Seguridad\Proyecto2023"
        txtDirPathBackup.Enabled = False
        txtNom_Backup.Enabled = False
        txtNom_Backup.Text = nombre
    End Sub


End Class