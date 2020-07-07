<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExamenIIParcialMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.dgvFacturaDatos = New System.Windows.Forms.DataGridView()
        Me.txtidVenta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdProducto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtidCliente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.label = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.mtxtFecha = New System.Windows.Forms.MaskedTextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnRefrescar = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.dgvFacturaDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvFacturaDatos
        '
        Me.dgvFacturaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFacturaDatos.Location = New System.Drawing.Point(12, 247)
        Me.dgvFacturaDatos.Name = "dgvFacturaDatos"
        Me.dgvFacturaDatos.Size = New System.Drawing.Size(692, 185)
        Me.dgvFacturaDatos.TabIndex = 0
        '
        'txtidVenta
        '
        Me.txtidVenta.Location = New System.Drawing.Point(285, 113)
        Me.txtidVenta.Name = "txtidVenta"
        Me.txtidVenta.Size = New System.Drawing.Size(100, 20)
        Me.txtidVenta.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(282, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Id Venta"
        '
        'txtIdProducto
        '
        Me.txtIdProducto.Location = New System.Drawing.Point(524, 166)
        Me.txtIdProducto.Name = "txtIdProducto"
        Me.txtIdProducto.Size = New System.Drawing.Size(100, 20)
        Me.txtIdProducto.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(521, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Id Producto"
        '
        'txtidCliente
        '
        Me.txtidCliente.Location = New System.Drawing.Point(418, 166)
        Me.txtidCliente.Name = "txtidCliente"
        Me.txtidCliente.Size = New System.Drawing.Size(100, 20)
        Me.txtidCliente.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(415, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Id Cliente"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(312, 166)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 9
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(309, 150)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(49, 13)
        Me.label.TabIndex = 12
        Me.label.Text = "Cantidad"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(206, 166)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(207, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Precio"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(97, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Fecha de Venta"
        '
        'mtxtFecha
        '
        Me.mtxtFecha.Location = New System.Drawing.Point(100, 166)
        Me.mtxtFecha.Mask = "00/00/0000"
        Me.mtxtFecha.Name = "mtxtFecha"
        Me.mtxtFecha.Size = New System.Drawing.Size(80, 20)
        Me.mtxtFecha.TabIndex = 16
        Me.mtxtFecha.ValidatingType = GetType(Date)
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(391, 111)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 17
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnRefrescar
        '
        Me.btnRefrescar.Location = New System.Drawing.Point(182, 217)
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.Size = New System.Drawing.Size(75, 23)
        Me.btnRefrescar.TabIndex = 18
        Me.btnRefrescar.Text = "Refrescar"
        Me.btnRefrescar.UseVisualStyleBackColor = True
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(363, 218)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(75, 23)
        Me.btnIngresar.TabIndex = 19
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(453, 218)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 20
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(273, 218)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 21
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(628, 218)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 22
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(244, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(261, 25)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Tienda Deportiva Messi"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ExamenIIParcialMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 444)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.btnRefrescar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.mtxtFecha)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtidCliente)
        Me.Controls.Add(Me.txtIdProducto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtidVenta)
        Me.Controls.Add(Me.dgvFacturaDatos)
        Me.Name = "ExamenIIParcialMain"
        Me.Text = "ExamenIIParcialMain"
        CType(Me.dgvFacturaDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvFacturaDatos As DataGridView
    Friend WithEvents txtidVenta As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdProducto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtidCliente As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents label As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents mtxtFecha As MaskedTextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnRefrescar As Button
    Friend WithEvents btnIngresar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
