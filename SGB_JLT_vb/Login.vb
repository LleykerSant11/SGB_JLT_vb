Public Class Login
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btn_ingresar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click
        Dim frmInicio As New Inicio()
        frmInicio.Show()
        Me.Hide()
    End Sub

    Private Sub btn_ver_Click(sender As Object, e As EventArgs) Handles btn_ver.Click
        txt_contraseña.PasswordChar = ""
        btn_ver.Visible = False
        btn_ocultar.Visible = True
    End Sub

    Private Sub btn_ocultar_Click(sender As Object, e As EventArgs) Handles btn_ocultar.Click
        txt_contraseña.PasswordChar = "*"
        btn_ocultar.Visible = False
        btn_ver.Visible = True
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
End Class
