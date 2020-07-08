Imports System.Data.Sql
Imports System.Data.SqlClient

Module mduConexionesSQL
    'Declaracion de la variable requerida para conectar la BD
    Public conexion As SqlConnection = New SqlConnection("Data Source=HACKNEL;Initial Catalog=Tienda;Integrated Security=True")
    'declaracion de variables necesarias para la operacion de BD
    Public adaptadorDatos As SqlDataAdapter
    Public comandos As SqlCommand
    Public leerVariables As SqlDataReader
    Public tablasDatos As DataTable

    'Al arranqcar el programa hace una comprobacion de que la conexion con la BD este correcta
    Sub probarConexion()
        Try
            conexion.Open()
            conexion.Close()
        Catch ex As Exception
            MsgBox("Error de Conexion", ex.ToString)
            conexion.Close()
        End Try
    End Sub

    'Funcion para enviar comandos SQL a la base de datos
    Function ejecutarComando(ByVal instruccion As String)
        Try
            conexion.Open()
            comandos = New SqlCommand(instruccion, conexion)
            If comandos.ExecuteNonQuery() Then
                conexion.Close()
                Return 0
            Else
                conexion.Close()
                Return -1
            End If
        Catch ex As Exception
            MsgBox("Error de Ejecucion de Comando", ex.ToString)
            conexion.Close()
            Return -1
        End Try
    End Function

    'Funcion que llena el DGV que se le envie, segun una instruccion especifica
    Function llenardataGrid(ByVal dgv As DataGridView, ByVal instruccion As String)
        Try
            conexion.Open()
            adaptadorDatos = New SqlDataAdapter(instruccion, conexion)
            tablasDatos = New DataTable
            adaptadorDatos.Fill(tablasDatos)
            dgv.DataSource = tablasDatos
            conexion.Close()
        Catch ex As Exception
            MsgBox("Error de Ejecucion de DGV", ex.ToString)
            conexion.Close()
            Return -1
        End Try
    End Function

    'Comprueba que un valor exista o tengo un valor en registro
    Function comprobacionExiste(ByVal instruccion As String)
        Try
            conexion.Open()
            comandos = conexion.CreateCommand()
            comandos.CommandText = (instruccion)
            Dim cr As Integer = CInt(comandos.ExecuteScalar())
            If cr > 0 Then
                conexion.Close()
                Return 1
            Else
                conexion.Close()
                Return -1
            End If
        Catch ex As Exception
            MsgBox("Error de Ejecucion de Comprobacion", ex.ToString)
            conexion.Close()
            Return -1
        End Try
    End Function

    'Funcion que llena instancias de control como textBox o maskedTextBox
    Function llenarTextBox(ByVal textB As Object, ByVal instruccion As String, ByVal columnas As String)
        Try
            conexion.Open()
            comandos = New SqlCommand(instruccion, conexion)
            leerVariables = comandos.ExecuteReader
            If leerVariables.Read Then
                textB.text = Convert.ToString(leerVariables(columnas))
                conexion.Close()
                Return 1
            Else
                conexion.Close()
                Return -1
            End If
        Catch ex As Exception
            MsgBox("Error de Ejecucion de Llenar TextBox", ex.ToString)
            conexion.Close()
            Return -1
        End Try
    End Function

    'Funcion para obtener variables operacionales de la base de datos
    Function obtenerVariable(ByVal instruccion As String, ByVal columna As String, ByVal compro As Integer)
        Try
            conexion.Open()
            comandos = New SqlCommand(instruccion, conexion)
            leerVariables = comandos.ExecuteReader
            While leerVariables.Read()
                If Convert.ToInt16(leerVariables(columna)) = compro Then
                    conexion.Close()
                    Return 1
                End If
            End While
            Return -1
        Catch ex As Exception
            MsgBox("Error de Lectura Variable", ex.ToString)
            conexion.Close()
            Return -1
        End Try
    End Function

    'Funcion que limpia los textbox en un determinado control
    Sub limpiar(ByVal a As Object)
        For Each control As Control In a.Controls
            If TypeOf control Is TextBox Then
                control.Text = String.Empty
            End If
        Next
    End Sub


End Module
