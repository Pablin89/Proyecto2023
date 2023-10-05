Public Class Empleados
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BRCambios.Click
        BRCambios.Visible = False
        BCambios.Visible = True
        TApellidoYNombre.Enabled = True
        TDireccion.Enabled = True
        TDni.Enabled = True
        TCorreo.Enabled = True
        TTelefono.Enabled = True
        DTFechaNac.Enabled = True
    End Sub



    Private Sub Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TApellidoYNombre.Enabled = False
        TDireccion.Enabled = False
        TDni.Enabled = False
        TCorreo.Enabled = False
        TTelefono.Enabled = False
        DTFechaNac.Enabled = False
    End Sub

    Private Sub Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TApellidoYNombre.Enabled = False
        TDireccion.Enabled = False
        TDni.Enabled = False
        TCorreo.Enabled = False
        TTelefono.Enabled = False
        DTFechaNac.Enabled = False
    End Sub
End Class