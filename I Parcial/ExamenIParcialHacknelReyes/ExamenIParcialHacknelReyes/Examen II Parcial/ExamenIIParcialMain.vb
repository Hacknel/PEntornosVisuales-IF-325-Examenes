Imports System.ComponentModel
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Public Class ExamenIIParcialMain
    '-------------------------Funciones Esteticas
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub ExamenIIParcialMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        probarConexion()
        '----se llena el DGV principal
        llenardataGrid(dgvFacturaDatos, "select ve.idVenta as 'Id Venta', cl.nombre as 'Nombre', cl.apellido as 'Apellidos', pr.nombreProducto as 'Nombre Producto', ve.cantidad as 'Cantidad Producto', ve.precio as 'Precio Venta', ve.fechaVenta as 'Fecha de Venta' from factura.cliente cl inner join factura.Venta ve on cl.idCliente = ve.idCliente inner join factura.producto pr on pr.idProducto = ve.idProducto")
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        'Se comprueba y muestra los valores de la base de datos dependiendo del id que se pida
        If txtidVenta.Text <> String.Empty Then
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
        'Funcion opcional de refrescar la BD
        llenardataGrid(dgvFacturaDatos, "select ve.idVenta as 'Id Venta',  cl.nombre as 'Nombre', cl.apellido as 'Apellidos', pr.nombreProducto as 'Nombre Producto', ve.cantidad as 'Cantidad Producto', ve.precio as 'Precio Venta', ve.fechaVenta as 'Fecha de Venta' from factura.cliente cl inner join factura.Venta ve on cl.idCliente = ve.idCliente inner join factura.producto pr on pr.idProducto = ve.idProducto")

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        'Funcion para modificar los valores de la base de datos
        Try
            'comprueba que los datos se hayan ingresado bien
            If comprobaciones() = 0 Then
                'comprruban que existan valores de id en la BD
                If obtenerVariable("select * from factura.cliente", "idCliente", Val(txtidCliente.Text)) = 1 Then
                    If obtenerVariable("select * from factura.producto", "idProducto", Val(txtIdProducto.Text)) = 1 Then
                        '-----------Funcion Procedidmiento almacenado que modifica
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
                    ElseIf MessageBox.Show("No se encuentra el registro ID " + txtIdProducto.Text + " en productos ¿Desea entrar al mantemiento de productos? ", "CONSULTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                        frmAgregarProductos.Show()
                    Else
                        limpiar(Me)
                    End If

                ElseIf MessageBox.Show("No se encuentra el registro ID " + txtidCliente.Text + " en clientes ¿Desea entrar al mantemiento de clientes?", "CONSULTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                    frmAgregarCliente.Show()
                Else
                    limpiar(Me)
                    mtxtFecha.Clear()
                End If

            End If
        Catch ex As Exception
            MsgBox("Error de Ejecucion de Modificar", ex.ToString)
            conexion.Close()
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        'Funcion que elimina los registros de la base de datos segun ID
        If comprobaciones() = 0 Then
            ejecutarComando("delete from factura.Venta where idVenta = '" & txtidVenta.Text & "'")
            llenardataGrid(dgvFacturaDatos, "select ve.idVenta as 'Id Venta',  cl.nombre as 'Nombre', cl.apellido as 'Apellidos', pr.nombreProducto as 'Nombre Producto', ve.cantidad as 'Cantidad Producto', ve.precio as 'Precio Venta', ve.fechaVenta as 'Fecha de Venta' from factura.cliente cl inner join factura.Venta ve on cl.idCliente = ve.idCliente inner join factura.producto pr on pr.idProducto = ve.idProducto")
            MessageBox.Show("Eliminacion Realizada Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    '------------------------------------------------------------------------De igual manera que la funucion de modificar, solo que esta realliza la operacion de insercion
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try
            If comprobaciones() = 0 Then
                If obtenerVariable("select * from factura.cliente", "idCliente", Val(txtidCliente.Text)) = 1 Then
                    If obtenerVariable("select * from factura.producto", "idProducto", Val(txtIdProducto.Text)) = 1 Then
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
                    ElseIf MessageBox.Show("No se encuentra el registro ID " + txtIdProducto.Text + " en productos ¿Desea entrar al mantemiento de productos? ", "CONSULTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                        frmAgregarProductos.Show()
                    Else
                        limpiar(Me)
                        mtxtFecha.Clear()
                    End If

                ElseIf MessageBox.Show("No se encuentra el registro ID " + txtidCliente.Text + " en clientes ¿Desea entrar al mantemiento de clientes?", "CONSULTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                    frmAgregarCliente.Show()
                Else
                    limpiar(Me)
                End If
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

    '----------------------------------Comprobaciones, sugerencias y validacion con errorProvide y toolTip
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

    Private Sub mtxtFecha_Validating(sender As Object, e As CancelEventArgs)
        If DirectCast(sender, MaskedTextBox).TextLength > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub mtxtFecha_MouseHover(sender As Object, e As EventArgs)
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

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MessageBox.Show("¿Esta seguro de salir? ", "CONSULTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class