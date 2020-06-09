Public Class Operaciones
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim totalDepaActivoFM, totalDepaActivoCM, totalDepaRecuFM, totalDepaRecuCM, totalDepaMuertoFM, totalDepaMuertoCM As Integer
        Dim nombre, municipio, miniDescrip As String
        Dim edad As Integer
        Dim idDepCmb As Integer
        Dim paraHistorial As String

        If txtNombre.Text <> String.Empty And mtxtEdad.Text <> String.Empty And cmBDepartamento.Text <> String.Empty And txtMunicipio.Text <> String.Empty Then
            nombre = txtNombre.Text
            edad = mtxtEdad.Text
            idDepCmb = cmBDepartamento.SelectedIndex
            municipio = txtMunicipio.Text
            miniDescrip = rtxtDescripcion.Text

            If idDepCmb = 0 Then
                If chbPositivo.Checked = True Then
                    If chbActivo.Checked = True Then

                        paraHistorial = nombre + " " + edad.ToString + " " + cmBDepartamento.SelectedItem.ToString + " " + municipio + " Positivo " + " Activo"
                        rtxtHistorial.AppendText(paraHistorial & vbCrLf)
                    End If

                End If
            End If

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("Esta seguro que desea salir", vbQuestion + vbYesNo, "Advertencia") = vbYes Then
            End
        End If
    End Sub

    Private Sub Operaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'chbPositivo.Enabled = False
        chbMuerto.Enabled = False
        'chbNegativo.Enabled = False
        chbActivo.Enabled = False
        chbRecu.Enabled = False
    End Sub

    Private Sub chbNegativo_CheckedChanged(sender As Object, e As EventArgs) Handles chbNegativo.CheckedChanged

    End Sub

    Private Sub chbPositivo_CheckedChanged(sender As Object, e As EventArgs) Handles chbPositivo.CheckedChanged
        chbNegativo.Checked = False
        chbActivo.Enabled = True
        chbRecu.Enabled = True
        chbMuerto.Enabled = True
    End Sub

    Private Sub chbActivo_CheckedChanged(sender As Object, e As EventArgs) Handles chbActivo.CheckedChanged
        chbRecu.Enabled = False
        chbMuerto.Enabled = False
    End Sub
End Class