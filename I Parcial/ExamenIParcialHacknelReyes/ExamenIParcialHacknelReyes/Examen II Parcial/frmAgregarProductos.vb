Imports System.ComponentModel

Public Class frmAgregarProductos

    Private Sub frmAgregarProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenardataGrid(dgvProductos, "select idProducto as 'Id Producto', nombreProducto as 'Nombre Producto', descripcion as 'Descripcion Producto' from factura.producto")
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If Me.ValidateChildren And txtIdProducto.Text <> String.Empty Then
            If comprobacionExiste("select idProducto from factura.producto where idProducto = '" & Val(txtIdProducto.Text) & "'") = 1 Then
                llenarTextBox(txtNombreProd, "select nombreProducto from factura.producto where idProducto = '" & txtIdProducto.Text & "'", "nombreProducto")
                llenarTextBox(txtDesc, "select descripcion from factura.producto where idProducto = '" & txtIdProducto.Text & "'", "descripcion")
            Else
                MessageBox.Show("Este id de factura no existe en los registros!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Ingrese un ID a verificar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        llenardataGrid(dgvProductos, "select idProducto as 'Id Producto', nombreProducto as 'Nombre Producto', descripcion as 'Descripcion Producto' from factura.producto")
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If comprobaciones() = 0 Then
            ejecutarComando("update factura.producto set idProducto = '" & Val(txtIdProducto.Text) & "', nombreProducto = '" & txtNombreProd.Text & "', descripcion = '" & txtDesc.Text & "' where idProducto = '" & txtIdProducto.Text & "'")
            MessageBox.Show("Modificacion Realizada Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            llenardataGrid(dgvProductos, "select idProducto as 'Id Producto', nombreProducto as 'Nombre Producto', descripcion as 'Descripcion Producto' from factura.producto")
        Else
            MessageBox.Show("Modificacion No realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If comprobaciones() = 0 Then
            ejecutarComando("insert into factura.producto values ('" & Val(txtIdProducto.Text) & "','" & txtNombreProd.Text & "', '" & txtDesc.Text & "' )")
            MessageBox.Show("Insercion Realizada Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            llenardataGrid(dgvProductos, "select idProducto as 'Id Producto', nombreProducto as 'Nombre Producto', descripcion as 'Descripcion Producto' from factura.producto")

        Else
            MessageBox.Show("Insercion No realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If comprobaciones() = 0 Then
            ejecutarComando("delete from factura.producto where idProducto = '" & txtIdProducto.Text & "'")
            MessageBox.Show("Eliminacion Realizada Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            llenardataGrid(dgvProductos, "select idProducto as 'Id Producto', nombreProducto as 'Nombre Producto', descripcion as 'Descripcion Producto' from factura.producto")

        Else
            MessageBox.Show("Eliminacion No realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Function comprobaciones()
        If Me.ValidateChildren And txtIdProducto.Text <> String.Empty And txtNombreProd.Text <> String.Empty And txtDesc.Text <> String.Empty Then
            Return 0
        Else
            MessageBox.Show("Ingrese Valores Correctos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        End If
    End Function

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                control.Text = String.Empty
            End If
        Next
    End Sub

    Private Sub txtIdProducto_Validating(sender As Object, e As CancelEventArgs) Handles txtIdProducto.Validating
        If DirectCast(sender, TextBox).TextLength > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtNombreProd_Validating(sender As Object, e As CancelEventArgs) Handles txtNombreProd.Validating
        If DirectCast(sender, TextBox).TextLength > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtDesc_Validating(sender As Object, e As CancelEventArgs) Handles txtDesc.Validating
        If DirectCast(sender, TextBox).TextLength > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtIdProducto_MouseHover(sender As Object, e As EventArgs) Handles txtIdProducto.MouseHover
        ToolTip1.SetToolTip(txtIdProducto, "Introduzca el id del producto")
        ToolTip1.ToolTipTitle = "Ingrese Valores"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtNombreProd_MouseHover(sender As Object, e As EventArgs) Handles txtNombreProd.MouseHover
        ToolTip1.SetToolTip(txtNombreProd, "Introduzca el nombre del producto")
        ToolTip1.ToolTipTitle = "Ingrese Valores"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtDesc_MouseHover(sender As Object, e As EventArgs) Handles txtDesc.MouseHover
        ToolTip1.SetToolTip(txtDesc, "Introduzca la descripcion geneal del producto")
        ToolTip1.ToolTipTitle = "Ingrese Valores"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class