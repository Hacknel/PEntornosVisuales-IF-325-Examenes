<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrearUsuario
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
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(132, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Crear Usuario"
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(170, 174)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(100, 20)
        Me.txtContrasena.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(103, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Contraseña"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(170, 132)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuario.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(103, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Usuario"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(323, 344)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Salir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(161, 235)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 37)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Ingresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(231, 344)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 25)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Volver a Inicio"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'CrearUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 381)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CrearUsuario"
        Me.Text = "CrearUsuario"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ToolTip1 As ToolTip
End Class
