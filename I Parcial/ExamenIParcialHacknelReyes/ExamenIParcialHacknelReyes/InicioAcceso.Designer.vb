<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InicioAcceso
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
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCrearUsuario = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(197, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingreso al Sistema"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(88, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Usuario"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(155, 152)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuario.TabIndex = 2
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(155, 197)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(100, 20)
        Me.txtContrasena.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(88, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Contraseña"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(279, 166)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 37)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Ingresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnCrearUsuario
        '
        Me.btnCrearUsuario.Location = New System.Drawing.Point(12, 336)
        Me.btnCrearUsuario.Name = "btnCrearUsuario"
        Me.btnCrearUsuario.Size = New System.Drawing.Size(86, 37)
        Me.btnCrearUsuario.TabIndex = 6
        Me.btnCrearUsuario.Text = "Crear Usuario"
        Me.btnCrearUsuario.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(438, 336)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(86, 37)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'InicioAcceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 385)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCrearUsuario)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "InicioAcceso"
        Me.Text = "Form1"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnCrearUsuario As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ToolTip1 As ToolTip
End Class
