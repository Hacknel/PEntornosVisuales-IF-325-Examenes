Imports System.ComponentModel
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class ExamenIIParcialMain
    Private Sub ExamenIIParcialMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenardataGrid(dgvFacturaDatos, "select ve.idVenta as 'Id Venta', cl.nombre as 'Nombre', cl.apellido as 'Apellidos', pr.nombreProducto as 'Nombre Producto', ve.cantidad as 'Cantidad Producto', ve.precio as 'Precio Venta', ve.fechaVenta as 'Fecha de Venta' from factura.cliente cl inner join factura.Venta ve on cl.idCliente = ve.idCliente inner join factura.producto pr on pr.idProducto = ve.idProducto")
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If Me.ValidateChildren And txtidVenta.Text <> String.Empty Then
            If comprobacionExiste("select idVenta from factura.Venta where idVenta = '" & Val(txtidVenta.Text) & "'") = 1 Then
                llenarTextBox(mtxtFecha, "select fechaVenta from factura.Venta where idVenta = '" & txtidVenta.Text & "'", "fechaVenta")
                llenarTextBox(txtPrecio, "select precio from factura.Venta where idVenta = '" & txtidVenta.Text & "'", "precio")
                llenarTextBox(txtCantidad, "select cantidad from factura.Venta where idVenta = '" & txtidVenta.Text & "'", "cantidad")
                llenarTextBox(txtidCliente, "select idCliente from factura.Venta where idVenta = '" & txtidVenta.Text & "'", "idCliente")
                llenarTextBox(txtIdProducto, "select idProducto from factura.Venta where idVenta = '" & txtidVenta.Text & "'", "idProducto")
            Else
                MessageBox.Show("Este id de factura no existe en los registros!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Inserte un valor a evaluar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        llenardataGrid(dgvFacturaDatos, "select ve.idVenta as 'Id Venta',  cl.nombre as 'Nombre', cl.apellido as 'Apellidos', pr.nombreProducto as 'Nombre Producto', ve.cantidad as 'Cantidad Producto', ve.precio as 'Precio Venta', ve.fechaVenta as 'Fecha de Venta' from factura.cliente cl inner join factura.Venta ve on cl.idCliente = ve.idCliente inner join factura.producto pr on pr.idProducto = ve.idProducto")

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            If comprobaciones() = 0 Then
                conexion.Open()
                Dim comandos As SqlCommand = conexion.CreateCommand()
                comandos.CommandText = "modificar"
                comandos.CommandType = CommandType.StoredProcedure
                comandos.Parameters.AddWithValue("@idVenta", Val(txtidVenta.Text))
                comandos.Parameters.AddWithValue("@fechaVenta", mtxtFecha.Text)
                comandos.Parameters.AddWithValue("@precio", Val(txtPrecio.Text))
                comandos.Parameters.AddWithValue("@cantidad", Val(txtCantidad.Text))
                comandos.Parameters.AddWithValue("@idCliente", Val(txtidCliente.Text))
                comandos.Parameters.AddWithValue("@idProducto", Val(txtIdProducto.Text))

                If comandos.ExecuteNonQuery() Then
                    conexion.Close()
                    MessageBox.Show("Modificacion Realizada Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    llenardataGrid(dgvFacturaDatos, "select ve.idVenta as 'Id Venta',  cl.nombre as 'Nombre', cl.apellido as 'Apellidos', pr.nombreProducto as 'Nombre Producto', ve.cantidad as 'Cantidad Producto', ve.precio as 'Precio Venta', ve.fechaVenta as 'Fecha de Venta' from factura.cliente cl inner join factura.Venta ve on cl.idCliente = ve.idCliente inner join factura.producto pr on pr.idProducto = ve.idProducto")

                Else
                    conexion.Close()
                    MessageBox.Show("Modificacion No realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MsgBox("Error de Ejecucion de Modificar", ex.ToString)
            conexion.Close()
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If comprobaciones() = 0 Then
            ejecutarComando("delete from factura.Venta where idVenta = '" & txtidVenta.Text & "'")
            llenardataGrid(dgvFacturaDatos, "select ve.idVenta as 'Id Venta',  cl.nombre as 'Nombre', cl.apellido as 'Apellidos', pr.nombreProducto as 'Nombre Producto', ve.cantidad as 'Cantidad Producto', ve.precio as 'Precio Venta', ve.fechaVenta as 'Fecha de Venta' from factura.cliente cl inner join factura.Venta ve on cl.idCliente = ve.idCliente inner join factura.producto pr on pr.idProducto = ve.idProducto")
        End If

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try
            conexion.Open()
            Dim comandos As SqlCommand = conexion.CreateCommand()
            comandos.CommandText = "insertar"
            comandos.CommandType = CommandType.StoredProcedure
            comandos.Parameters.AddWithValue("@idVenta", Val(txtidVenta.Text))
            comandos.Parameters.AddWithValue("@fechaVenta", mtxtFecha.Text)
            comandos.Parameters.AddWithValue("@precio", Val(txtPrecio.Text))
            comandos.Parameters.AddWithValue("@cantidad", Val(txtCantidad.Text))
            comandos.Parameters.AddWithValue("@idCliente", Val(txtidCliente.Text))
            comandos.Parameters.AddWithValue("@idProducto", Val(txtIdProducto.Text))

            If comandos.ExecuteNonQuery() Then
                conexion.Close()
                MessageBox.Show("Ingreso Realizado Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                llenardataGrid(dgvFacturaDatos, "select ve.idVenta as 'Id Venta',  cl.nombre as 'Nombre', cl.apellido as 'Apellidos', pr.nombreProducto as 'Nombre Producto', ve.cantidad as 'Cantidad Producto', ve.precio as 'Precio Venta', ve.fechaVenta as 'Fecha de Venta' from factura.cliente cl inner join factura.Venta ve on cl.idCliente = ve.idCliente inner join factura.producto pr on pr.idProducto = ve.idProducto")

            Else
                conexion.Close()
                MessageBox.Show("Ingreso No realizado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox("Error de Ejecucion de Insercion", ex.ToString)
            conexion.Close()
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                control.Text = String.Empty
            End If
            mtxtFecha.Clear()
        Next
    End Sub

    Function comprobaciones()
        If Me.ValidateChildren And txtidVenta.Text <> String.Empty And mtxtFecha.Text <> String.Empty And txtPrecio.Text <> String.Empty And txtidCliente.Text <> String.Empty And txtIdProducto.Text <> String.Empty Then
            Return 0
        Else
            MessageBox.Show("Ingrese Valores Correctos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        End If
    End Function

    Private Sub txtidVenta_Validating(sender As Object, e As CancelEventArgs) Handles txtidVenta.Validating
        If DirectCast(sender, TextBox).TextLength > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtidVenta_MouseHover(sender As Object, e As EventArgs) Handles txtidVenta.MouseHover
        ToolTip1.SetToolTip(txtidCliente, "Introduzca el numero de factura/venta")
        ToolTip1.ToolTipTitle = "Ingrese Valores"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub mtxtFecha_Validating(sender As Object, e As CancelEventArgs) Handles mtxtFecha.Validating
        If DirectCast(sender, MaskedTextBox).TextLength > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub mtxtFecha_MouseHover(sender As Object, e As EventArgs) Handles mtxtFecha.MouseHover
        ToolTip1.SetToolTip(mtxtFecha, "Introduzca la fecha de venta")
        ToolTip1.ToolTipTitle = "Ingrese Valores"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtPrecio_Validating(sender As Object, e As CancelEventArgs) Handles txtPrecio.Validating
        If DirectCast(sender, TextBox).TextLength > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtPrecio_MouseHover(sender As Object, e As EventArgs) Handles txtPrecio.MouseHover
        ToolTip1.SetToolTip(txtPrecio, "Introduzca el precio de venta")
        ToolTip1.ToolTipTitle = "Ingrese Valores"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtCantidad_Validating(sender As Object, e As CancelEventArgs) Handles txtCantidad.Validating
        If DirectCast(sender, TextBox).TextLength > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtCantidad_MouseHover(sender As Object, e As EventArgs) Handles txtCantidad.MouseHover
        ToolTip1.SetToolTip(txtCantidad, "Introduzca la cantidad de productos")
        ToolTip1.ToolTipTitle = "Ingrese Valores"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtIdProducto_Validating(sender As Object, e As CancelEventArgs) Handles txtIdProducto.Validating
        If DirectCast(sender, TextBox).TextLength > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtIdProducto_MouseHover(sender As Object, e As EventArgs) Handles txtIdProducto.MouseHover
        ToolTip1.SetToolTip(txtCantidad, "Introduzca el codigo de producto")
        ToolTip1.ToolTipTitle = "Ingrese Valores"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click
        frmAgregarCliente.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmAgregarProductos.Show()
    End Sub
End Class