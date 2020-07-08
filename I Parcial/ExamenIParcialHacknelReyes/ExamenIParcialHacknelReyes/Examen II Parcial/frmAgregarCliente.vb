Imports System.ComponentModel

Public Class frmAgregarCliente
    Private Sub frmAgregarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenardataGrid(dgvClientes, "select idCliente as 'Id Cliente', nombre as 'Nombre', apellido as 'Apellidos', direccion as 'Direccion' from factura.cliente")
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If Me.ValidateChildren And txtidCliente.Text <> String.Empty Then
            If comprobacionExiste("select idCliente from factura.cliente where idCliente = '" & Val(txtidCliente.Text) & "'") = 1 Then
                llenarTextBox(txtNombre, "select nombre from factura.cliente where idCliente = '" & txtidCliente.Text & "'", "nombre")
                llenarTextBox(txtApellidos, "select apellido from factura.cliente where idCliente = '" & txtidCliente.Text & "'", "apellido")
                llenarTextBox(txtDireccion, "select direccion from factura.cliente where idCliente = '" & txtidCliente.Text & "'", "direccion")
            Else
                MessageBox.Show("Este id de factura no existe en los registros!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Ingrese un ID a verificar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        llenardataGrid(dgvClientes, "select nombre as 'Nombre', apellido as 'Apellidos', direccion as 'Direccion' from factura.cliente")
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If comprobaciones() = 0 Then
            ejecutarComando("update factura.cliente set idCliente = '" & Val(txtidCliente.Text) & "', nombre = '" & txtNombre.Text & "', apellido = '" & txtApellidos.Text & "', direccion = '" & txtDireccion.Text & "' where idCliente = '" & txtidCliente.Text & "'")
            MessageBox.Show("Modificacion Realizada Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            llenardataGrid(dgvClientes, "select idCliente as 'Id Cliente', nombre as 'Nombre', apellido as 'Apellidos', direccion as 'Direccion' from factura.cliente")

        Else
            MessageBox.Show("Modificacion No realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Function comprobaciones()
        If Me.ValidateChildren And txtidCliente.Text <> String.Empty And txtNombre.Text <> String.Empty And txtApellidos.Text <> String.Empty And txtDireccion.Text <> String.Empty Then
            Return 0
        Else
            MessageBox.Show("Ingrese Valores Correctos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        End If
    End Function

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If comprobaciones() = 0 Then
            ejecutarComando("insert into factura.cliente values ('" & Val(txtidCliente.Text) & "','" & txtNombre.Text & "', '" & txtApellidos.Text & "', '" & txtDireccion.Text & "')")
            MessageBox.Show("Insercion Realizada Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            llenardataGrid(dgvClientes, "select idCliente as 'Id Cliente', nombre as 'Nombre', apellido as 'Apellidos', direccion as 'Direccion' from factura.cliente")

        Else
            MessageBox.Show("Insercion No realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If comprobaciones() = 0 Then
            ejecutarComando("delete from factura.cliente where idCliente = '" & txtidCliente.Text & "'")
            MessageBox.Show("Eliminacion Realizada Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            llenardataGrid(dgvClientes, "select idCliente as 'Id Cliente', nombre as 'Nombre', apellido as 'Apellidos', direccion as 'Direccion' from factura.cliente")

        Else
            MessageBox.Show("Eliminacion No realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                control.Text = String.Empty
            End If
        Next
    End Sub

    Private Sub txtidCliente_Validating(sender As Object, e As CancelEventArgs) Handles txtidCliente.Validating
        If DirectCast(sender, TextBox).TextLength > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).TextLength > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtApellidos_Validating(sender As Object, e As CancelEventArgs) Handles txtApellidos.Validating
        If DirectCast(sender, TextBox).TextLength > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtDireccion_Validating(sender As Object, e As CancelEventArgs) Handles txtDireccion.Validating
        If DirectCast(sender, TextBox).TextLength > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtApellidos_MouseHover(sender As Object, e As EventArgs) Handles txtApellidos.MouseHover
        ToolTip1.SetToolTip(txtApellidos, "Introduzca los apellidos del cliente")
        ToolTip1.ToolTipTitle = "Ingrese Valores"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtDireccion_MouseHover(sender As Object, e As EventArgs) Handles txtDireccion.MouseHover
        ToolTip1.SetToolTip(txtDireccion, "Introduzca la direccion del cliente")
        ToolTip1.ToolTipTitle = "Ingrese Valores"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtidCliente_MouseHover(sender As Object, e As EventArgs) Handles txtidCliente.MouseHover
        ToolTip1.SetToolTip(txtidCliente, "Introduzca el id del cliente")
        ToolTip1.ToolTipTitle = "Ingrese Valores"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover
        ToolTip1.SetToolTip(txtNombre, "Introduzca el nombre del cliente")
        ToolTip1.ToolTipTitle = "Ingrese Valores"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class