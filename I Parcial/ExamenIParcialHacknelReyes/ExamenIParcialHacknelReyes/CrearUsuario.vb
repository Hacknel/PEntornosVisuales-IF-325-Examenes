Imports System.ComponentModel

Public Class CrearUsuario
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click

        If txtUsuario.Text <> String.Empty And txtContrasena.Text <> String.Empty Then
            If IsNumeric(txtUsuario.Text) = False And IsNumeric(txtContrasena.Text) = False Then
                usuario = txtUsuario.Text
                contrasena = txtContrasena.Text
                MessageBox.Show("Usuario Creado Exitosamente", "Crear Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Timer1.Start()
            Else
                MessageBox.Show("No se permiten valores numericos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Introduzca Valores!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub txtUsuario_Validating(sender As Object, e As CancelEventArgs) Handles txtUsuario.Validating
        If DirectCast(sender, TextBox).TextLength > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtContrasena_Validating(sender As Object, e As CancelEventArgs) Handles txtContrasena.Validating
        If DirectCast(sender, TextBox).TextLength > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtUsuario_MouseHover(sender As Object, e As EventArgs) Handles txtUsuario.MouseHover
        ToolTip1.SetToolTip(txtUsuario, "Introduzca el usuario deseado, sin espacios")
        ToolTip1.ToolTipTitle = "Usuario"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtContrasena_MouseHover(sender As Object, e As EventArgs) Handles txtContrasena.MouseHover
        ToolTip1.SetToolTip(txtContrasena, "Introduzca la contrasena deseada, sin espacios")
        ToolTip1.ToolTipTitle = "Contrasena"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        InicioAcceso.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox("Esta seguro que desea salir", vbQuestion + vbYesNo, "Advertencia") = vbYes Then
            End
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Me.Close()
    End Sub
End Class