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
        Me.components = New System.ComponentModel.Container()
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
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Sexo = New System.Windows.Forms.Label()
        Me.chbMujer = New System.Windows.Forms.CheckBox()
        Me.chbHombre = New System.Windows.Forms.CheckBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.rtxtHistorial = New System.Windows.Forms.RichTextBox()
        Me.cmBDepartamentosTotales = New System.Windows.Forms.ComboBox()
        Me.txtActivos = New System.Windows.Forms.TextBox()
        Me.txtRecupe = New System.Windows.Forms.TextBox()
        Me.txtMuertos = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Positivos = New System.Windows.Forms.Label()
        Me.txtPositivos = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtNegativos = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtTotalPrubas = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNegativosG = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtPositivosG = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtMuertosG = New System.Windows.Forms.TextBox()
        Me.txtRecuG = New System.Windows.Forms.TextBox()
        Me.txtActivosG = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtTotalPruebasG = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(469, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(326, 72)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Plataforma de Registro y Consulta" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Emergencia Pandemia COVID-19" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    Control Est" &
    "adistico de Casos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre Completo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(183, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Edad"
        '
        'cmBDepartamento
        '
        Me.cmBDepartamento.FormattingEnabled = True
        Me.cmBDepartamento.Items.AddRange(New Object() {"Atlántida", "Choluteca", "Colón", "Comayagua", "Copán", "Cortes", "El Paraíso", "Francisco Morazán", "Gracias a Dios", "Intibucá", "Islas de la Bahía", "La Paz", "Lempira", "Ocotepeque", "Olancho", "Santa Bárbara", "Valle", "Yoro"})
        Me.cmBDepartamento.Location = New System.Drawing.Point(254, 48)
        Me.cmBDepartamento.Name = "cmBDepartamento"
        Me.cmBDepartamento.Size = New System.Drawing.Size(146, 21)
        Me.cmBDepartamento.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(453, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Municipio"
        '
        'chbPositivo
        '
        Me.chbPositivo.AutoSize = True
        Me.chbPositivo.Location = New System.Drawing.Point(30, 143)
        Me.chbPositivo.Name = "chbPositivo"
        Me.chbPositivo.Size = New System.Drawing.Size(63, 17)
        Me.chbPositivo.TabIndex = 7
        Me.chbPositivo.Text = "Positivo"
        Me.chbPositivo.UseVisualStyleBackColor = True
        '
        'chbNegativo
        '
        Me.chbNegativo.AutoSize = True
        Me.chbNegativo.Location = New System.Drawing.Point(102, 143)
        Me.chbNegativo.Name = "chbNegativo"
        Me.chbNegativo.Size = New System.Drawing.Size(69, 17)
        Me.chbNegativo.TabIndex = 8
        Me.chbNegativo.Text = "Negativo"
        Me.chbNegativo.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(17, 48)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(137, 20)
        Me.txtNombre.TabIndex = 9
        '
        'txtMunicipio
        '
        Me.txtMunicipio.Location = New System.Drawing.Point(432, 48)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(89, 20)
        Me.txtMunicipio.TabIndex = 11
        '
        'rtxtDescripcion
        '
        Me.rtxtDescripcion.Location = New System.Drawing.Point(119, 259)
        Me.rtxtDescripcion.Name = "rtxtDescripcion"
        Me.rtxtDescripcion.Size = New System.Drawing.Size(281, 81)
        Me.rtxtDescripcion.TabIndex = 12
        Me.rtxtDescripcion.Text = ""
        '
        'chbActivo
        '
        Me.chbActivo.AutoSize = True
        Me.chbActivo.Location = New System.Drawing.Point(30, 198)
        Me.chbActivo.Name = "chbActivo"
        Me.chbActivo.Size = New System.Drawing.Size(56, 17)
        Me.chbActivo.TabIndex = 13
        Me.chbActivo.Text = "Activo"
        Me.chbActivo.UseVisualStyleBackColor = True
        '
        'chbRecu
        '
        Me.chbRecu.AutoSize = True
        Me.chbRecu.Location = New System.Drawing.Point(102, 198)
        Me.chbRecu.Name = "chbRecu"
        Me.chbRecu.Size = New System.Drawing.Size(85, 17)
        Me.chbRecu.TabIndex = 14
        Me.chbRecu.Text = "Recuperado"
        Me.chbRecu.UseVisualStyleBackColor = True
        '
        'chbMuerto
        '
        Me.chbMuerto.AutoSize = True
        Me.chbMuerto.Location = New System.Drawing.Point(193, 198)
        Me.chbMuerto.Name = "chbMuerto"
        Me.chbMuerto.Size = New System.Drawing.Size(59, 17)
        Me.chbMuerto.TabIndex = 15
        Me.chbMuerto.Text = "Muerto"
        Me.chbMuerto.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(287, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Departamento"
        '
        'mtxtEdad
        '
        Me.mtxtEdad.Location = New System.Drawing.Point(186, 48)
        Me.mtxtEdad.Mask = "99"
        Me.mtxtEdad.Name = "mtxtEdad"
        Me.mtxtEdad.Size = New System.Drawing.Size(27, 20)
        Me.mtxtEdad.TabIndex = 17
        Me.mtxtEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.Sexo)
        Me.GroupBox1.Controls.Add(Me.chbMujer)
        Me.GroupBox1.Controls.Add(Me.chbHombre)
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
        Me.GroupBox1.Size = New System.Drawing.Size(548, 393)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de Datos"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(318, 360)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(109, 27)
        Me.btnLimpiar.TabIndex = 33
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Sexo
        '
        Me.Sexo.AutoSize = True
        Me.Sexo.Location = New System.Drawing.Point(445, 82)
        Me.Sexo.Name = "Sexo"
        Me.Sexo.Size = New System.Drawing.Size(31, 13)
        Me.Sexo.TabIndex = 32
        Me.Sexo.Text = "Sexo"
        '
        'chbMujer
        '
        Me.chbMujer.AutoSize = True
        Me.chbMujer.Location = New System.Drawing.Point(483, 104)
        Me.chbMujer.Name = "chbMujer"
        Me.chbMujer.Size = New System.Drawing.Size(52, 17)
        Me.chbMujer.TabIndex = 31
        Me.chbMujer.Text = "Mujer"
        Me.chbMujer.UseVisualStyleBackColor = True
        '
        'chbHombre
        '
        Me.chbHombre.AutoSize = True
        Me.chbHombre.Location = New System.Drawing.Point(414, 104)
        Me.chbHombre.Name = "chbHombre"
        Me.chbHombre.Size = New System.Drawing.Size(63, 17)
        Me.chbHombre.TabIndex = 30
        Me.chbHombre.Text = "Hombre"
        Me.chbHombre.UseVisualStyleBackColor = True
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(433, 360)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(109, 27)
        Me.btnIngresar.TabIndex = 29
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(199, 233)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Descripcion Paciente"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Estado Paciente"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Estado de Prueba"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(1115, 654)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(137, 35)
        Me.btnSalir.TabIndex = 19
        Me.btnSalir.Text = "Salir Sistema"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'rtxtHistorial
        '
        Me.rtxtHistorial.Location = New System.Drawing.Point(8, 29)
        Me.rtxtHistorial.Name = "rtxtHistorial"
        Me.rtxtHistorial.Size = New System.Drawing.Size(651, 214)
        Me.rtxtHistorial.TabIndex = 20
        Me.rtxtHistorial.Text = ""
        '
        'cmBDepartamentosTotales
        '
        Me.cmBDepartamentosTotales.FormattingEnabled = True
        Me.cmBDepartamentosTotales.Items.AddRange(New Object() {"Atlántida", "Choluteca", "Colón", "Comayagua", "Copán", "Cortes", "El Paraíso", "Francisco Morazán", "Gracias a Dios", "Intibucá", "Islas de la Bahía", "La Paz", "Lempira", "Ocotepeque", "Olancho", "Santa Bárbara", "Valle", "Yoro"})
        Me.cmBDepartamentosTotales.Location = New System.Drawing.Point(216, 287)
        Me.cmBDepartamentosTotales.Name = "cmBDepartamentosTotales"
        Me.cmBDepartamentosTotales.Size = New System.Drawing.Size(241, 21)
        Me.cmBDepartamentosTotales.TabIndex = 22
        '
        'txtActivos
        '
        Me.txtActivos.Location = New System.Drawing.Point(297, 350)
        Me.txtActivos.Name = "txtActivos"
        Me.txtActivos.Size = New System.Drawing.Size(45, 20)
        Me.txtActivos.TabIndex = 23
        '
        'txtRecupe
        '
        Me.txtRecupe.Location = New System.Drawing.Point(383, 350)
        Me.txtRecupe.Name = "txtRecupe"
        Me.txtRecupe.Size = New System.Drawing.Size(45, 20)
        Me.txtRecupe.TabIndex = 24
        '
        'txtMuertos
        '
        Me.txtMuertos.Location = New System.Drawing.Point(463, 350)
        Me.txtMuertos.Name = "txtMuertos"
        Me.txtMuertos.Size = New System.Drawing.Size(45, 20)
        Me.txtMuertos.TabIndex = 25
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(294, 327)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(42, 13)
        Me.label10.TabIndex = 26
        Me.label10.Text = "Activos"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(371, 326)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Recuperados"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(460, 326)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Muertos"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(224, 262)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(233, 13)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Consulte los valores de casos por departamento"
        '
        'Positivos
        '
        Me.Positivos.AutoSize = True
        Me.Positivos.Location = New System.Drawing.Point(218, 326)
        Me.Positivos.Name = "Positivos"
        Me.Positivos.Size = New System.Drawing.Size(49, 13)
        Me.Positivos.TabIndex = 32
        Me.Positivos.Text = "Positivos"
        '
        'txtPositivos
        '
        Me.txtPositivos.Location = New System.Drawing.Point(221, 350)
        Me.txtPositivos.Name = "txtPositivos"
        Me.txtPositivos.Size = New System.Drawing.Size(45, 20)
        Me.txtPositivos.TabIndex = 31
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(536, 327)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 13)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "Negativos"
        '
        'txtNegativos
        '
        Me.txtNegativos.Location = New System.Drawing.Point(539, 350)
        Me.txtNegativos.Name = "txtNegativos"
        Me.txtNegativos.Size = New System.Drawing.Size(45, 20)
        Me.txtNegativos.TabIndex = 33
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtTotalPrubas)
        Me.GroupBox2.Controls.Add(Me.txtNegativos)
        Me.GroupBox2.Controls.Add(Me.Positivos)
        Me.GroupBox2.Controls.Add(Me.txtPositivos)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.label10)
        Me.GroupBox2.Controls.Add(Me.txtMuertos)
        Me.GroupBox2.Controls.Add(Me.txtRecupe)
        Me.GroupBox2.Controls.Add(Me.txtActivos)
        Me.GroupBox2.Controls.Add(Me.cmBDepartamentosTotales)
        Me.GroupBox2.Controls.Add(Me.rtxtHistorial)
        Me.GroupBox2.Location = New System.Drawing.Point(594, 135)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(665, 392)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Consulta de Datos"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(78, 327)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(128, 13)
        Me.Label20.TabIndex = 50
        Me.Label20.Text = "Total Pruebas Realizadas"
        '
        'txtTotalPrubas
        '
        Me.txtTotalPrubas.Location = New System.Drawing.Point(117, 350)
        Me.txtTotalPrubas.Name = "txtTotalPrubas"
        Me.txtTotalPrubas.Size = New System.Drawing.Size(45, 20)
        Me.txtTotalPrubas.TabIndex = 49
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(533, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Negativos"
        '
        'txtNegativosG
        '
        Me.txtNegativosG.Location = New System.Drawing.Point(536, 45)
        Me.txtNegativosG.Name = "txtNegativosG"
        Me.txtNegativosG.Size = New System.Drawing.Size(45, 20)
        Me.txtNegativosG.TabIndex = 43
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(215, 21)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 13)
        Me.Label14.TabIndex = 42
        Me.Label14.Text = "Positivos"
        '
        'txtPositivosG
        '
        Me.txtPositivosG.Location = New System.Drawing.Point(218, 45)
        Me.txtPositivosG.Name = "txtPositivosG"
        Me.txtPositivosG.Size = New System.Drawing.Size(45, 20)
        Me.txtPositivosG.TabIndex = 41
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(457, 21)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 13)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "Muertos"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(368, 21)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(71, 13)
        Me.Label17.TabIndex = 39
        Me.Label17.Text = "Recuperados"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(291, 22)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(42, 13)
        Me.Label18.TabIndex = 38
        Me.Label18.Text = "Activos"
        '
        'txtMuertosG
        '
        Me.txtMuertosG.Location = New System.Drawing.Point(460, 45)
        Me.txtMuertosG.Name = "txtMuertosG"
        Me.txtMuertosG.Size = New System.Drawing.Size(45, 20)
        Me.txtMuertosG.TabIndex = 37
        '
        'txtRecuG
        '
        Me.txtRecuG.Location = New System.Drawing.Point(380, 45)
        Me.txtRecuG.Name = "txtRecuG"
        Me.txtRecuG.Size = New System.Drawing.Size(45, 20)
        Me.txtRecuG.TabIndex = 36
        '
        'txtActivosG
        '
        Me.txtActivosG.Location = New System.Drawing.Point(294, 45)
        Me.txtActivosG.Name = "txtActivosG"
        Me.txtActivosG.Size = New System.Drawing.Size(45, 20)
        Me.txtActivosG.TabIndex = 35
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.txtTotalPruebasG)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtNegativosG)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txtPositivosG)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.txtRecuG)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.txtActivosG)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.txtMuertosG)
        Me.GroupBox3.Location = New System.Drawing.Point(597, 545)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(655, 84)
        Me.GroupBox3.TabIndex = 45
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos Globales"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(75, 22)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(128, 13)
        Me.Label19.TabIndex = 48
        Me.Label19.Text = "Total Pruebas Realizadas"
        '
        'txtTotalPruebasG
        '
        Me.txtTotalPruebasG.Location = New System.Drawing.Point(114, 45)
        Me.txtTotalPruebasG.Name = "txtTotalPruebasG"
        Me.txtTotalPruebasG.Size = New System.Drawing.Size(45, 20)
        Me.txtTotalPruebasG.TabIndex = 47
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(949, 654)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 35)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "Regresar al Menu de Inicio"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.ExamenIParcialHacknelReyes.My.Resources.Resources.unnamed
        Me.PictureBox1.Location = New System.Drawing.Point(1043, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(209, 103)
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'Operaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ExamenIParcialHacknelReyes.My.Resources.Resources.Fondo
        Me.ClientSize = New System.Drawing.Size(1271, 701)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Operaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Operaciones"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents cmBDepartamentosTotales As ComboBox
    Friend WithEvents txtActivos As TextBox
    Friend WithEvents txtRecupe As TextBox
    Friend WithEvents txtMuertos As TextBox
    Friend WithEvents label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnIngresar As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Positivos As Label
    Friend WithEvents txtPositivos As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtNegativos As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Sexo As Label
    Friend WithEvents chbMujer As CheckBox
    Friend WithEvents chbHombre As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNegativosG As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtPositivosG As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtMuertosG As TextBox
    Friend WithEvents txtRecuG As TextBox
    Friend WithEvents txtActivosG As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtTotalPruebasG As TextBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label20 As Label
    Friend WithEvents txtTotalPrubas As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ErrorProvider2 As ErrorProvider
End Class
