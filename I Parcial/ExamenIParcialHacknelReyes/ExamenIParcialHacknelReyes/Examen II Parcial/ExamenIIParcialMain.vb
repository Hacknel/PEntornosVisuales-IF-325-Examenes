Imports System.ComponentModel
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class ExamenIIParcialMain
    Private Sub ExamenIIParcialMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenardataGrid(dgvFacturaDatos, "select cl.nombre as 'Nombre', cl.apellido as 'Apellidos', pr.nombreProducto as 'Nombre Producto', ve.cantidad as 'Cantidad Producto', ve.precio as 'Precio Venta', ve.fechaVenta as 'Fecha de Venta' from factura.cliente cl inner join factura.Venta ve on cl.idCliente = ve.idCliente inner join factura.producto pr on pr.idProducto = ve.idProducto")
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If comprobacionExiste(txtidVenta.Text) = 1 Then
            llenarTextBox(mtxtFecha, "select fechaVenta from factura.Venta where idVenta = '" & txtidVenta.Text & "'", "fechaVenta")
            llenarTextBox(txtPrecio, "select precio from factura.Venta where idVenta = '" & txtidVenta.Text & "'", "precio")
            llenarTextBox(txtCantidad, "select cantidad from factura.Venta where idVenta = '" & txtidVenta.Text & "'", "cantidad")
            llenarTextBox(txtidCliente, "select idCliente from factura.Venta where idVenta = '" & txtidVenta.Text & "'", "idCliente")
            llenarTextBox(txtIdProducto, "select idProducto from factura.Venta where idVenta = '" & txtidVenta.Text & "'", "idProducto")
        Else
            MessageBox.Show("Este id de factura no existe en los registros!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        llenardataGrid(dgvFacturaDatos, "select cl.nombre as 'Nombre', cl.apellido as 'Apellidos', pr.nombreProducto as 'Nombre Producto', ve.cantidad as 'Cantidad Producto', ve.precio as 'Precio Venta', ve.fechaVenta as 'Fecha de Venta' from factura.cliente cl inner join factura.Venta ve on cl.idCliente = ve.idCliente inner join factura.producto pr on pr.idProducto = ve.idProducto")

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
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
            Else
                conexion.Close()
                MessageBox.Show("Modificacion No realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox("Error de Ejecucion de Modificar", ex.ToString)
            conexion.Close()
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ejecutarComando("delete from factura.Venta where idVenta = '" & txtidVenta.Text & "'")
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
        Next
    End Sub

    Private Sub txtidVenta_Validating(sender As Object, e As CancelEventArgs) Handles txtidVenta.Validating
        If DirectCast(txt) Then
    End Sub
End Class