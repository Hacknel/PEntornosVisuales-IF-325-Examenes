Imports System.Data.Sql
Imports System.Data.SqlClient

Module mduConexionesSQL

    Public conexion As SqlConnection = New SqlConnection("Data Source=HACKNEL;Initial Catalog=Tienda;Integrated Security=True")
    Public adaptadorDatos As SqlDataAdapter
    Public comandos As SqlCommand
    Public leerVariables As SqlDataReader
    Public tablasDatos As DataTable

    Sub probarConexion()
        Try
            conexion.Open()
            conexion.Close()
        Catch ex As Exception
            MsgBox("Error de Conexion", ex.ToString)
            conexion.Close()
        End Try
    End Sub

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

    Function comprobacionExiste(ByVal texto As String)
        Try
            conexion.Open()
            comandos = conexion.CreateCommand()
            comandos.CommandText = ("select idVenta from factura.Venta where idVenta = '" & Val(texto) & "'")
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


End Module
