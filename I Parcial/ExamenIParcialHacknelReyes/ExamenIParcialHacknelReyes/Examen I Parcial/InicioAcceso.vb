Imports System.ComponentModel

Public Class InicioAcceso

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Comprobacion de los valors que ingresa el usuario con los que se crearon en la creacion del usuario
        If txtUsuario.Text <> String.Empty And txtContrasena.Text <> String.Empty Then
            If IsNumeric(txtUsuario.Text) = False And IsNumeric(txtContrasena.Text) = False Then
                'Se utiliza la funcion strComp para no diferenciar entre mayusculas y minsuculas
                If StrComp(txtUsuario.Text, usuario, vbTextCompare) = 0 And txtContrasena.Text = contrasena Then
                    Operaciones.Show()
                Else
                    MessageBox.Show("Contraseña o usuario Incorrecto!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("No se permiten valores numericos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Introduzca Valores!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    '--------------------------------------------Comprobacion de errores y etiquetas de textbox---------------------------------------
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
        ToolTip1.SetToolTip(txtUsuario, "Introduzca el usuario, sin espacios")
        ToolTip1.ToolTipTitle = "Usuario"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtContrasena_MouseHover(sender As Object, e As EventArgs) Handles txtContrasena.MouseHover
        ToolTip1.SetToolTip(txtContrasena, "Introduzca la contrasena, sin espacios")
        ToolTip1.ToolTipTitle = "Contrasena"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCrearUsuario.Click
        'Crear el usuario
        CrearUsuario.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("Esta seguro que desea salir", vbQuestion + vbYesNo, "Advertencia") = vbYes Then
            End
        End If
    End Sub

End Class
