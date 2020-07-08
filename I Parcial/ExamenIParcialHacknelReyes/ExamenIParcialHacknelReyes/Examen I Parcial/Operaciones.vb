Imports System.ComponentModel

Public Class Operaciones
    'Declaracion de variables globales
    Dim totalPruebas(17), totalPositivos(17), totalActivos(17), totalRecuperados(17), totalMuertos(17), totalNegativos(17) As Integer
    Dim contador As Integer = 0
    Dim totalPositivosG, totalActivosG, totalRecuperadosG, totalMuertosG, totalNegativosG As Integer

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        'Declaracion de varibales locales
        Dim nombre, municipio, miniDescrip, sexo As String
        Dim edad As Integer
        'Permite 100 valores en el historial para efectos de prueba, aumentable...
        Dim paraHistorial(100) As String

        Try
            'Comprueba que los textbox no es esten vacios y algunos checkbox tengan seleccion
            If txtNombre.Text <> String.Empty And mtxtEdad.Text <> String.Empty And cmBDepartamento.Text <> String.Empty And txtMunicipio.Text <> String.Empty And (chbHombre.Checked = True Or chbMujer.Checked = True) And rtxtDescripcion.Text <> String.Empty Then
                'Se asignan los valores a las variables
                nombre = txtNombre.Text
                edad = mtxtEdad.Text
                municipio = txtMunicipio.Text
                miniDescrip = rtxtDescripcion.Text
                'Dependiedno de la seleccion se hara asignacion
                If chbHombre.Checked = True Then
                    sexo = "Hombre"
                Else
                    sexo = "Mujer"
                End If
                'Ciclo que recorre y asigna las posiciones del arreglo dependiendo del departamento
                For i = 0 To 17 Step 1
                    If i = cmBDepartamento.SelectedIndex Then
                        '---------------------------Parte operativa que realiza las respectivas asignaciones e impresiones de los valores dados---------------------------------------------------
                        If chbPositivo.Checked = True Then
                            totalPruebas(i) += 1
                            totalPositivos(i) += 1
                            totalPositivosG += 1
                            txtPositivosG.Text = totalPositivosG
                            If chbActivo.Checked = True Then
                                contador += 1
                                totalActivosG += 1
                                txtActivosG.Text = totalActivosG
                                txtTotalPruebasG.Text = contador
                                totalActivos(i) += 1
                                paraHistorial(contador) = contador.ToString + ". " + nombre + "     " + sexo + " " + edad.ToString + " años" + "       " + municipio + ", " + cmBDepartamento.SelectedItem.ToString + "     R. Prueba: Positivo" + "    Estado: Activo"
                                rtxtHistorial.AppendText(vbCrLf & paraHistorial(contador) & vbCrLf & " Descripcion paciente: " & miniDescrip)

                            ElseIf chbRecu.Checked = True Then
                                contador += 1
                                totalRecuperadosG += 1
                                txtRecuG.Text = totalRecuperadosG
                                txtTotalPruebasG.Text = contador
                                totalRecuperados(i) += 1
                                paraHistorial(contador) = contador.ToString + ". " + nombre + "     " + sexo + " " + edad.ToString + " años" + "       " + municipio + ", " + cmBDepartamento.SelectedItem.ToString + "     R. Prueba: Positivo" + "    Estado: Recuperado"
                                rtxtHistorial.AppendText(vbCrLf & paraHistorial(contador) & vbCrLf & " Descripcion paciente: " & miniDescrip)

                            ElseIf chbMuerto.Checked = True Then
                                contador += 1
                                totalMuertosG += 1
                                txtMuertosG.Text = totalMuertosG
                                txtTotalPruebasG.Text = contador
                                totalMuertos(i) += 1
                                paraHistorial(contador) = contador.ToString + ". " + nombre + "     " + sexo + " " + edad.ToString + " años" + "       " + municipio + ", " + cmBDepartamento.SelectedItem.ToString + "     R Prueba: Positivo" + "    Estado: Muerto"
                                rtxtHistorial.AppendText(vbCrLf & paraHistorial(contador) & vbCrLf & " Descripcion paciente: " & miniDescrip)
                            Else
                                MessageBox.Show("Se requiere un estado de paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If

                        ElseIf chbNegativo.Checked = True Then
                            totalPruebas(i) += 1
                            totalNegativosG += 1
                            txtNegativosG.Text = totalNegativosG
                            contador += 1
                            txtTotalPruebasG.Text = contador
                            totalNegativos(i) += 1
                            paraHistorial(contador) = contador.ToString + ". " + nombre + "     " + sexo + " " + edad.ToString + " años" + "       " + municipio + ", " + cmBDepartamento.SelectedItem.ToString + "     R Prueba: Negativo" + "    Estado: Negativo"
                            rtxtHistorial.AppendText(vbCrLf & paraHistorial(contador) & vbCrLf & " Descripcion paciente: " & miniDescrip)
                        Else
                            MessageBox.Show("Todos los campos son requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                Next
            Else
                MessageBox.Show("Todos los campos son requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cmBDepartamentosTotales_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmBDepartamentosTotales.SelectedIndexChanged
        'Impresion de los datos del arreglo dependienod del departamento seleccionado
        For i = 0 To 17 Step 1
            If i = cmBDepartamentosTotales.SelectedIndex Then
                txtTotalPrubas.Text = totalPruebas(i)
                txtPositivos.Text = totalPositivos(i)
                txtActivos.Text = totalActivos(i)
                txtRecupe.Text = totalRecuperados(i)
                txtMuertos.Text = totalMuertos(i)
                txtNegativos.Text = totalNegativos(i)

            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        'Salir de manera segura y confirmada
        If MsgBox("Esta seguro que desea salir", vbQuestion + vbYesNo, "Advertencia") = vbYes Then
            Me.Close()
            End
        End If
    End Sub

    Private Sub Operaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ordenamiento de checkBox
        chbMuerto.Enabled = False
        chbActivo.Enabled = False
        chbRecu.Enabled = False

    End Sub

    Private Sub chbPositivo_CheckedChanged(sender As Object, e As EventArgs) Handles chbPositivo.CheckedChanged
        'ordenamiento de checkBox
        If chbPositivo.Checked = True Then
            chbNegativo.Enabled = False
            chbNegativo.Checked = False
            chbActivo.Enabled = True
            chbRecu.Enabled = True
            chbMuerto.Enabled = True
        Else
            chbNegativo.Enabled = True
            chbRecu.Checked = False
            chbMuerto.Checked = False
            chbActivo.Checked = False
            chbActivo.Enabled = False
            chbRecu.Enabled = False
            chbMuerto.Enabled = False
        End If

    End Sub

    Private Sub chbActivo_CheckedChanged(sender As Object, e As EventArgs) Handles chbActivo.CheckedChanged
        'ordenamiento de checkBox
        If chbActivo.Checked = True Then
            chbRecu.Enabled = False
            chbMuerto.Enabled = False
        Else
            chbRecu.Enabled = True
            chbMuerto.Enabled = True
        End If
    End Sub

    Private Sub chbRecu_CheckedChanged(sender As Object, e As EventArgs) Handles chbRecu.CheckedChanged
        'ordenamiento de checkBox
        If chbRecu.Checked = True Then
            chbActivo.Enabled = False
            chbMuerto.Enabled = False
        Else
            chbActivo.Enabled = True
            chbMuerto.Enabled = True
        End If
    End Sub

    Private Sub chbMuerto_CheckedChanged(sender As Object, e As EventArgs) Handles chbMuerto.CheckedChanged
        'ordenamiento de checkBox
        If chbMuerto.Checked = True Then
            chbRecu.Enabled = False
            chbActivo.Enabled = False
        Else
            chbRecu.Enabled = True
            chbActivo.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        'Limpiar valores
        For Each control As Control In GroupBox1.Controls
            If TypeOf control Is TextBox Then
                control.Text = ""
            End If
        Next
        mtxtEdad.Clear()
        rtxtDescripcion.Clear()
        chbActivo.Checked = False
        chbHombre.Checked = False
        chbNegativo.Checked = False
        chbMujer.Checked = False
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        'Boton volver al incio
        Me.Close()
        InicioAcceso.Show()
    End Sub

    Private Sub chbNegativo_CheckedChanged(sender As Object, e As EventArgs) Handles chbNegativo.CheckedChanged
        'ordenamiento de checkBox
        If chbNegativo.Checked = True Then
            chbPositivo.Checked = False
            chbPositivo.Enabled = False
        Else
            chbPositivo.Enabled = True
        End If
    End Sub

    Private Sub chbHombre_CheckedChanged(sender As Object, e As EventArgs) Handles chbHombre.CheckedChanged
        'ordenamiento de checkBox
        If chbHombre.Checked = True Then
            chbMujer.Checked = False
            chbMujer.Enabled = False
        Else
            chbMujer.Enabled = True
        End If
    End Sub

    Private Sub chbMujer_CheckedChanged(sender As Object, e As EventArgs) Handles chbMujer.CheckedChanged
        'ordenamiento de checkBox
        If chbMujer.Checked = True Then
            chbHombre.Checked = False
            chbHombre.Enabled = False
        Else
            chbHombre.Enabled = True
        End If
    End Sub
    '-----------------------------------------------Parte de validaciones y etiquetas de cajas de texto-----------------------------
    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).TextLength > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtMunicipio_Validating(sender As Object, e As CancelEventArgs) Handles txtMunicipio.Validating
        If DirectCast(sender, TextBox).TextLength > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover
        ToolTip1.SetToolTip(txtNombre, "Introduzca el nombre del paciente")
        ToolTip1.ToolTipTitle = "Nombre"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub mtxtEdad_MouseHover(sender As Object, e As EventArgs) Handles mtxtEdad.MouseHover
        ToolTip1.SetToolTip(mtxtEdad, "Introduzca la edad en años del paciente")
        ToolTip1.ToolTipTitle = "Edad"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmBDepartamento_MouseHover(sender As Object, e As EventArgs) Handles cmBDepartamento.MouseHover
        ToolTip1.SetToolTip(cmBDepartamento, "Seleccione uno de los departamentos")
        ToolTip1.ToolTipTitle = "Departamentos"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtMunicipio_MouseHover(sender As Object, e As EventArgs) Handles txtMunicipio.MouseHover
        ToolTip1.SetToolTip(txtMunicipio, "Introduzca el municipio de origen del paciente")
        ToolTip1.ToolTipTitle = "Municipio"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub rtxtDescripcion_MouseHover(sender As Object, e As EventArgs) Handles rtxtDescripcion.MouseHover
        ToolTip1.SetToolTip(rtxtDescripcion, "Introduzca una breve descripcion del estado del paciente | Grave | Estable | UCI | ")
        ToolTip1.ToolTipTitle = "Descripcion"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

End Class