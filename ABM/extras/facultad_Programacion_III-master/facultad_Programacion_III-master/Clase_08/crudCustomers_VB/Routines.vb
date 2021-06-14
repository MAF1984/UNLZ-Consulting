'Clases de Input Output, para el Manejo de Archivos
Imports System.IO
'Clases para ADO, para la Conexion con la DB
Imports System.Data.SqlClient
'Clases para Envio y Recepcion de Mails.
Imports System.Net.Mail
Module Routines
    'Funccion que se encarga de leer el Archivo donde se encuentra la Direecion del Servidor de la DB
    Function LeerHostDb(ByVal archivo As String) As String
        'En le archivo hostDb.txt poner la instancia de SQL p. ej: BAUBYTE-NOTE\SQLEXPRESS14
        If File.Exists("C:\Connections\hostDb.txt") = True Then
            'Abrimos el Archivo y Guaardamos el contenido en SR
            Dim SR As StreamReader = File.OpenText("C:\Connections\hostDb.txt")
            'Leemos las lineas hasta el enter y guardamos en Line
            Dim Line As String = SR.ReadLine()
            'Cerramos el archivo
            SR.Close()
            'Devolvemos la linea que leida
            Return Line
        End If
    End Function
    'Para comprobar si existe en la DB
    Function YaExisteSql(ByVal sql As String) As Boolean
        'Le pasamos un SELECT de SQL que en teoria busca algo, por ejemplo un numero de cheque, si hay registros la Funcion devuelve 
        'True, estilo "el cheque ya existe", si no esta, devuelve False
        Dim ar As String
        Dim connection As New SqlConnection("data source=" & CStr(LeerHostDb(ar)) & "; initial catalog=Northwind; integrated security=true")
        Dim dataAdapter As New SqlDataAdapter(sql, connection)
        Dim dataSet As New DataSet
        dataAdapter.Fill(dataSet, "existe")
        If dataSet.Tables("existe").Rows.Count < 1 Then
            Return False
        Else
            Return True
        End If
    End Function
    'Para convertir los String o Num
    Function Vnum(ByVal NTexto As String) As Decimal
        'transforma un texto con algo, que puede ser un numero con coma o punto o perro, y devuelve un valor decimal siempre
        Return CDec(Val(NTexto.Trim.Replace(",", ".")))
    End Function
    'Ejecuta las distintas acciones del ABM
    Function SqlAccion(ByVal SqlDeAccion As String) As Boolean
        'Ejecuta la consulta de accion 'SqlDeAccion' abriendo la conexion automaticamente
        'se da cuenta si es de insert, update o delete, porque mira dentro de la sentencia que se le pasa
        'devuelve true si se pudo hacer, y false si hubo algún error
        Dim ar As String
        Dim connection As New SqlConnection("data source=" & CStr(LeerHostDb(ar)) & "; initial catalog=Northwind; integrated security=true")
        'Para despues idicarle las consultas o un store procedure de SQL
        Dim dataAdapter As New SqlDataAdapter
        'Para ver si hubo o no error en la ejecucion
        Dim salida As Boolean = True

        Try
            connection.Open()
            'Buscamos en el contenido con IndexOf si tiene algunas de las acciones
            If SqlDeAccion.ToUpper.IndexOf("INSERT") Then
                dataAdapter.InsertCommand = New SqlCommand(SqlDeAccion, connection)
                dataAdapter.InsertCommand.ExecuteNonQuery()
            Else
                If SqlDeAccion.ToUpper.IndexOf("UPDATE") Then
                    dataAdapter.UpdateCommand = New SqlCommand(SqlDeAccion, connection)
                    dataAdapter.UpdateCommand.ExecuteNonQuery()
                Else
                    If SqlDeAccion.ToUpper.IndexOf("DELETE") Then
                        dataAdapter.DeleteCommand = New SqlCommand(SqlDeAccion, connection)
                        dataAdapter.DeleteCommand.ExecuteNonQuery()
                    Else
                        'esta mal la sintaxis porque no hay ni insert, ni delete ni update
                        salida = False
                    End If
                End If
            End If
            'Capturamos el Error
        Catch ex As Exception
            'Mostaramos el Error y Devolvemos False en la salida es decir que todo salio mal
            MsgBox(ex.Message)
            salida = False
        End Try
        'Cerramos la Conexion y Devolvemos True en la salida es decir que todo salio bien
        connection.Close()
        Return salida
    End Function
    'Para convertir los Numeros en el formato correcto para SQL 
    Function NumSql(ByVal numero As String) As String
        'Recibe un número desde un textbox por ejemplo, lo verifica como número válido, 
        'y luego le cambia la coma por punto para que sea válido en una sentencia de sql,
        'luego lo devuelve
        Return CStr(Vnum(numero)).Trim.Replace(",", ".")
    End Function
    'Para Rellenar los Numeros con la cantidad que necesitemos
    Function RellenaNum(ByVal numero As Integer, ByVal cantidad As Integer) As String
        'Rellena con 0s adelante el numero. Ideal para dias y meses:
        'RellenaNum(3,2)---> "03" RellenaNum(3,4)--->"0003"
        Dim snum As String = CStr(numero).Trim
        Return "00000000000000000000".Substring(0, cantidad - snum.Length) & snum
    End Function
    'Para Formatear las Fechas en el formato correcto para SQL 
    Function FechaSql(ByVal fecha As Date) As String
        'Devuelve fecha en el formato 'AAAAMMDD'
        Return "'" & RellenaNum(Year(fecha), 4) & RellenaNum(Month(fecha), 2) & RellenaNum(fecha.Day, 2) & "'"
    End Function
End Module
