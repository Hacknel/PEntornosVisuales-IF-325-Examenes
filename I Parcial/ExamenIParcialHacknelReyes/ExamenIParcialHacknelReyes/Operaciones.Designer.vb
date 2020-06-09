<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Operaciones
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmBDepartamento = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chbPositivo = New System.Windows.Forms.CheckBox()
        Me.chbNegativo = New System.Windows.Forms.CheckBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtMunicipio = New System.Windows.Forms.TextBox()
        Me.rtxtDescripcion = New System.Windows.Forms.RichTextBox()
        Me.chbActivo = New System.Windows.Forms.CheckBox()
        Me.chbRecu = New System.Windows.Forms.CheckBox()
        Me.chbMuerto = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.mtxtEdad = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.rtxtHistorial = New System.Windows.Forms.RichTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmBDepartamentosTotales = New System.Windows.Forms.ComboBox()
        Me.txtActivos = New System.Windows.Forms.TextBox()
        Me.txtRecupe = New System.Windows.Forms.TextBox()
        Me.txtMuertos = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(202, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ingreso de Datos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre Completo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(165, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Edad"
        '
        'cmBDepartamento
        '
        Me.cmBDepartamento.FormattingEnabled = True
        Me.cmBDepartamento.Items.AddRange(New Object() {"Comayagua", "Francisco Morazán"})
        Me.cmBDepartamento.Location = New System.Drawing.Point(236, 48)
        Me.cmBDepartamento.Name = "cmBDepartamento"
        Me.cmBDepartamento.Size = New System.Drawing.Size(146, 21)
        Me.cmBDepartamento.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(435, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Municipio"
        '
        'chbPositivo
        '
        Me.chbPositivo.AutoSize = True
        Me.chbPositivo.Location = New System.Drawing.Point(27, 111)
        Me.chbPositivo.Name = "chbPositivo"
        Me.chbPositivo.Size = New System.Drawing.Size(63, 17)
        Me.chbPositivo.TabIndex = 7
        Me.chbPositivo.Text = "Positivo"
        Me.chbPositivo.UseVisualStyleBackColor = True
        '
        'chbNegativo
        '
        Me.chbNegativo.AutoSize = True
        Me.chbNegativo.Location = New System.Drawing.Point(99, 111)
        Me.chbNegativo.Name = "chbNegativo"
        Me.chbNegativo.Size = New System.Drawing.Size(69, 17)
        Me.chbNegativo.TabIndex = 8
        Me.chbNegativo.Text = "Negativo"
        Me.chbNegativo.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(28, 48)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(108, 20)
        Me.txtNombre.TabIndex = 9
        '
        'txtMunicipio
        '
        Me.txtMunicipio.Location = New System.Drawing.Point(414, 48)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(89, 20)
        Me.txtMunicipio.TabIndex = 11
        '
        'rtxtDescripcion
        '
        Me.rtxtDescripcion.Location = New System.Drawing.Point(116, 227)
        Me.rtxtDescripcion.Name = "rtxtDescripcion"
        Me.rtxtDescripcion.Size = New System.Drawing.Size(281, 81)
        Me.rtxtDescripcion.TabIndex = 12
        Me.rtxtDescripcion.Text = ""
        '
        'chbActivo
        '
        Me.chbActivo.AutoSize = True
        Me.chbActivo.Location = New System.Drawing.Point(27, 166)
        Me.chbActivo.Name = "chbActivo"
        Me.chbActivo.Size = New System.Drawing.Size(56, 17)
        Me.chbActivo.TabIndex = 13
        Me.chbActivo.Text = "Activo"
        Me.chbActivo.UseVisualStyleBackColor = True
        '
        'chbRecu
        '
        Me.chbRecu.AutoSize = True
        Me.chbRecu.Location = New System.Drawing.Point(99, 166)
        Me.chbRecu.Name = "chbRecu"
        Me.chbRecu.Size = New System.Drawing.Size(85, 17)
        Me.chbRecu.TabIndex = 14
        Me.chbRecu.Text = "Recuperado"
        Me.chbRecu.UseVisualStyleBackColor = True
        '
        'chbMuerto
        '
        Me.chbMuerto.AutoSize = True
        Me.chbMuerto.Location = New System.Drawing.Point(190, 166)
        Me.chbMuerto.Name = "chbMuerto"
        Me.chbMuerto.Size = New System.Drawing.Size(59, 17)
        Me.chbMuerto.TabIndex = 15
        Me.chbMuerto.Text = "Muerto"
        Me.chbMuerto.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(269, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Departamento"
        '
        'mtxtEdad
        '
        Me.mtxtEdad.Location = New System.Drawing.Point(168, 48)
        Me.mtxtEdad.Mask = "99"
        Me.mtxtEdad.Name = "mtxtEdad"
        Me.mtxtEdad.Size = New System.Drawing.Size(27, 20)
        Me.mtxtEdad.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnIngresar)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.mtxtEdad)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.chbMuerto)
        Me.GroupBox1.Controls.Add(Me.chbRecu)
        Me.GroupBox1.Controls.Add(Me.chbActivo)
        Me.GroupBox1.Controls.Add(Me.rtxtDescripcion)
        Me.GroupBox1.Controls.Add(Me.txtMunicipio)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.chbNegativo)
        Me.GroupBox1.Controls.Add(Me.chbPositivo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmBDepartamento)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 135)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(537, 368)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de Datos"
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(422, 335)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(109, 27)
        Me.btnIngresar.TabIndex = 29
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(196, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Descripcion Paciente"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Estado Paciente"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Estado de Prueba"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(375, 598)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(137, 27)
        Me.btnSalir.TabIndex = 19
        Me.btnSalir.Text = "Salir Formulario"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'rtxtHistorial
        '
        Me.rtxtHistorial.Location = New System.Drawing.Point(568, 164)
        Me.rtxtHistorial.Name = "rtxtHistorial"
        Me.rtxtHistorial.Size = New System.Drawing.Size(305, 339)
        Me.rtxtHistorial.TabIndex = 20
        Me.rtxtHistorial.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(695, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Historial"
        '
        'cmBDepartamentosTotales
        '
        Me.cmBDepartamentosTotales.FormattingEnabled = True
        Me.cmBDepartamentosTotales.Items.AddRange(New Object() {"Comayagua", "Francisco Morazán"})
        Me.cmBDepartamentosTotales.Location = New System.Drawing.Point(601, 521)
        Me.cmBDepartamentosTotales.Name = "cmBDepartamentosTotales"
        Me.cmBDepartamentosTotales.Size = New System.Drawing.Size(241, 21)
        Me.cmBDepartamentosTotales.TabIndex = 22
        '
        'txtActivos
        '
        Me.txtActivos.Location = New System.Drawing.Point(601, 587)
        Me.txtActivos.Name = "txtActivos"
        Me.txtActivos.Size = New System.Drawing.Size(45, 20)
        Me.txtActivos.TabIndex = 23
        '
        'txtRecupe
        '
        Me.txtRecupe.Location = New System.Drawing.Point(694, 587)
        Me.txtRecupe.Name = "txtRecupe"
        Me.txtRecupe.Size = New System.Drawing.Size(45, 20)
        Me.txtRecupe.TabIndex = 24
        '
        'txtMuertos
        '
        Me.txtMuertos.Location = New System.Drawing.Point(786, 587)
        Me.txtMuertos.Name = "txtMuertos"
        Me.txtMuertos.Size = New System.Drawing.Size(45, 20)
        Me.txtMuertos.TabIndex = 25
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(598, 563)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(42, 13)
        Me.label10.TabIndex = 26
        Me.label10.Text = "Activos"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(691, 563)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Recuperados"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(783, 563)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Muertos"
        '
        'Operaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 637)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.txtMuertos)
        Me.Controls.Add(Me.txtRecupe)
        Me.Controls.Add(Me.txtActivos)
        Me.Controls.Add(Me.cmBDepartamentosTotales)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.rtxtHistorial)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Operaciones"
        Me.Text = "Operaciones"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmBDepartamento As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents chbPositivo As CheckBox
    Friend WithEvents chbNegativo As CheckBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtMunicipio As TextBox
    Friend WithEvents rtxtDescripcion As RichTextBox
    Friend WithEvents chbActivo As CheckBox
    Friend WithEvents chbRecu As CheckBox
    Friend WithEvents chbMuerto As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents mtxtEdad As MaskedTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents rtxtHistorial As RichTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmBDepartamentosTotales As ComboBox
    Friend WithEvents txtActivos As TextBox
    Friend WithEvents txtRecupe As TextBox
    Friend WithEvents txtMuertos As TextBox
    Friend WithEvents label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnIngresar As Button
End Class
