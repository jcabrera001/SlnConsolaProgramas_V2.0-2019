'------------------------------------------------------------------------------
' Clase IDF_Import generada automáticamente con CrearClaseSQL
' de la tabla 'IDF_Import' de la base 'Finanzas'
' Fecha: 10/Mar/2016 08:24:55
'
' ©Guillermo 'guille' Som, 2004-2016
'------------------------------------------------------------------------------
Option Strict On
Option Explicit On
'
Imports System
Imports System.Data
Imports System.Data.SqlClient
'
Public Class IDF_Import
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _ImportID As System.Int32
    Private _EmpresaCodigo As System.String
    Private _Fecha As System.DateTime
    Private _SdN As System.String
    Private _NumDua As System.String
    Private _NumLiq As System.String
    Private _ExoNum As System.String
    Private _ExoFec As System.DateTime
    Private _UsuCreacion As System.String
    Private _FechaCreacion As System.DateTime
    Private _UsuEdicion As System.String
    Private _FechaEdicion As System.DateTime
    Private _AnioAReportar As System.Int32
    Private _MesAReportar As System.Int32
    '
    ' Este método se usará para ajustar los anchos de las propiedades
    Private Function ajustarAncho(cadena As String, ancho As Integer) As String
        Dim sb As New System.Text.StringBuilder(New String(" "c, ancho))
        ' devolver la cadena quitando los espacios en blanco
        ' esto asegura que no se devolverá un tamaño mayor ni espacios "extras"
        Return (cadena & sb.ToString()).Substring(0, ancho).Trim()
    End Function
    '
    ' Las propiedades públicas
    ' TODO: Revisar los tipos de las propiedades
    Public Property ImportID() As System.Int32
        Get
            Return  _ImportID
        End Get
        Set(value As System.Int32)
            _ImportID = value
        End Set
    End Property
    Public Property EmpresaCodigo() As System.String
        Get
            Return ajustarAncho(_EmpresaCodigo,10)
        End Get
        Set(value As System.String)
            _EmpresaCodigo = value
        End Set
    End Property
    Public Property Fecha() As System.DateTime
        Get
            Return  _Fecha
        End Get
        Set(value As System.DateTime)
            _Fecha = value
        End Set
    End Property
    Public Property SdN() As System.String
        Get
            Return ajustarAncho(_SdN,25)
        End Get
        Set(value As System.String)
            _SdN = value
        End Set
    End Property
    Public Property NumDua() As System.String
        Get
            Return ajustarAncho(_NumDua,25)
        End Get
        Set(value As System.String)
            _NumDua = value
        End Set
    End Property
    Public Property NumLiq() As System.String
        Get
            Return ajustarAncho(_NumLiq,25)
        End Get
        Set(value As System.String)
            _NumLiq = value
        End Set
    End Property
    Public Property ExoNum() As System.String
        Get
            Return ajustarAncho(_ExoNum,25)
        End Get
        Set(value As System.String)
            _ExoNum = value
        End Set
    End Property
    Public Property ExoFec() As System.DateTime
        Get
            Return  _ExoFec
        End Get
        Set(value As System.DateTime)
            _ExoFec = value
        End Set
    End Property
    Public Property UsuCreacion() As System.String
        Get
            Return ajustarAncho(_UsuCreacion,25)
        End Get
        Set(value As System.String)
            _UsuCreacion = value
        End Set
    End Property
    Public Property FechaCreacion() As System.DateTime
        Get
            Return  _FechaCreacion
        End Get
        Set(value As System.DateTime)
            _FechaCreacion = value
        End Set
    End Property
    Public Property UsuEdicion() As System.String
        Get
            Return ajustarAncho(_UsuEdicion,25)
        End Get
        Set(value As System.String)
            _UsuEdicion = value
        End Set
    End Property
    Public Property FechaEdicion() As System.DateTime
        Get
            Return  _FechaEdicion
        End Get
        Set(value As System.DateTime)
            _FechaEdicion = value
        End Set
    End Property

    Public Property AnioAReportar() As System.Int32
        Get
            Return _AnioAReportar
        End Get
        Set(value As System.Int32)
            _AnioAReportar = value
        End Set
    End Property

    Public Property MesAReportar() As System.Int32
        Get
            Return _MesAReportar
        End Get
        Set(value As System.Int32)
            _MesAReportar = value
        End Set
    End Property
    '
    Public Default Property Item(index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.ImportID.ToString()
            ElseIf index = 1 Then
                Return Me.EmpresaCodigo.ToString()
            ElseIf index = 2 Then
                Return Me.Fecha.ToString()
            ElseIf index = 3 Then
                Return Me.SdN.ToString()
            ElseIf index = 4 Then
                Return Me.NumDua.ToString()
            ElseIf index = 5 Then
                Return Me.NumLiq.ToString()
            ElseIf index = 6 Then
                Return Me.ExoNum.ToString()
            ElseIf index = 7 Then
                Return Me.ExoFec.ToString()
            ElseIf index = 8 Then
                Return Me.UsuCreacion.ToString()
            ElseIf index = 9 Then
                Return Me.FechaCreacion.ToString()
            ElseIf index = 10 Then
                Return Me.UsuEdicion.ToString()
            ElseIf index = 11 Then
                Return Me.FechaEdicion.ToString()
            ElseIf index = 12 Then
                Return Me.AnioAReportar.ToString()
            ElseIf index = 13 Then
                Return Me.MesAReportar.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = 0 Then
                Try
                    Me.ImportID = System.Int32.Parse("0" & value)
                Catch
                    Me.ImportID = System.Int32.Parse("0")
                End Try
            ElseIf index = 1 Then
                Me.EmpresaCodigo = value
            ElseIf index = 2 Then
                Try
                    Me.Fecha = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.Fecha = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.Fecha = System.DateTime.Now
                End Try
            ElseIf index = 3 Then
                Me.SdN = value
            ElseIf index = 4 Then
                Me.NumDua = value
            ElseIf index = 5 Then
                Me.NumLiq = value
            ElseIf index = 6 Then
                Me.ExoNum = value
            ElseIf index = 7 Then
                Try
                    Me.ExoFec = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.ExoFec = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.ExoFec = System.DateTime.Now
                End Try
            ElseIf index = 8 Then
                Me.UsuCreacion = value
            ElseIf index = 9 Then
                Try
                    Me.FechaCreacion = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaCreacion = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaCreacion = System.DateTime.Now
                End Try
            ElseIf index = 10 Then
                Me.UsuEdicion = value
            ElseIf index = 11 Then
                Try
                    Me.FechaEdicion = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaEdicion = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaEdicion = System.DateTime.Now
                End Try
            ElseIf index = 12 Then
                Me.AnioAReportar = System.Int32.Parse(value)
            ElseIf index = 13 Then
                Me.MesAReportar = System.Int32.Parse(value)
            End If
        End Set
    End Property
    Public Default Property Item(index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde al nombre de la columna)
        Get
            If index = "ImportID" Then
                Return Me.ImportID.ToString()
            ElseIf index = "EmpresaCodigo" Then
                Return Me.EmpresaCodigo.ToString()
            ElseIf index = "Fecha" Then
                Return Me.Fecha.ToString()
            ElseIf index = "SdN" Then
                Return Me.SdN.ToString()
            ElseIf index = "NumDua" Then
                Return Me.NumDua.ToString()
            ElseIf index = "NumLiq" Then
                Return Me.NumLiq.ToString()
            ElseIf index = "ExoNum" Then
                Return Me.ExoNum.ToString()
            ElseIf index = "ExoFec" Then
                Return Me.ExoFec.ToString()
            ElseIf index = "UsuCreacion" Then
                Return Me.UsuCreacion.ToString()
            ElseIf index = "FechaCreacion" Then
                Return Me.FechaCreacion.ToString()
            ElseIf index = "UsuEdicion" Then
                Return Me.UsuEdicion.ToString()
            ElseIf index = "FechaEdicion" Then
                Return Me.FechaEdicion.ToString()
            ElseIf index = "AnioAReportar" Then
                Return Me.AnioAReportar.ToString()
            ElseIf index = "MesAReportar" Then
                Return Me.MesAReportar.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = "ImportID" Then
                Try
                    Me.ImportID = System.Int32.Parse("0" & value)
                Catch
                    Me.ImportID = System.Int32.Parse("0")
                End Try
            ElseIf index = "EmpresaCodigo" Then
                Me.EmpresaCodigo = value
            ElseIf index = "Fecha" Then
                Try
                    Me.Fecha = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.Fecha = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.Fecha = System.DateTime.Now
                End Try
            ElseIf index = "SdN" Then
                Me.SdN = value
            ElseIf index = "NumDua" Then
                Me.NumDua = value
            ElseIf index = "NumLiq" Then
                Me.NumLiq = value
            ElseIf index = "ExoNum" Then
                Me.ExoNum = value
            ElseIf index = "ExoFec" Then
                Try
                    Me.ExoFec = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.ExoFec = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.ExoFec = System.DateTime.Now
                End Try
            ElseIf index = "UsuCreacion" Then
                Me.UsuCreacion = value
            ElseIf index = "FechaCreacion" Then
                Try
                    Me.FechaCreacion = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaCreacion = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaCreacion = System.DateTime.Now
                End Try
            ElseIf index = "UsuEdicion" Then
                Me.UsuEdicion = value
            ElseIf index = "FechaEdicion" Then
                Try
                    Me.FechaEdicion = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaEdicion = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaEdicion = System.DateTime.Now
                End Try
            ElseIf index = "AnioAReportar" Then
                Me.AnioAReportar = System.Int32.Parse(value)
            ElseIf index = "MesAReportar" Then
                Me.MesAReportar = System.Int32.Parse(value)
            End If
        End Set
    End Property
    '
    ' Campos y métodos compartidos (estáticos) para gestionar la base de datos
    '
    ' La cadena de conexión a la base de datos
    Private Shared cadenaConexion As String = "Data Source=amigodb\amigodb; Initial Catalog=Finanzas; user id=rptuser; password=MiTo1380"
    ' La cadena de selección
    Public Shared CadenaSelect As String = "SELECT * FROM IDF_Import"
    '
    Public Sub New()
    End Sub
    Public Sub New(conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto IDF_Import
    Private Shared Function row2IDF_Import(r As DataRow) As IDF_Import
        ' asigna a un objeto IDF_Import los datos del dataRow indicado
        Dim oIDF_Import As New IDF_Import
        '
        oIDF_Import.ImportID = System.Int32.Parse("0" & r("ImportID").ToString())
        oIDF_Import.EmpresaCodigo = r("EmpresaCodigo").ToString()
        Try
            oIDF_Import.Fecha = DateTime.Parse(r("Fecha").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oIDF_Import.Fecha = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oIDF_Import.Fecha = DateTime.Now
        End Try
        oIDF_Import.SdN = r("SdN").ToString()
        oIDF_Import.NumDua = r("NumDua").ToString()
        oIDF_Import.NumLiq = r("NumLiq").ToString()
        oIDF_Import.ExoNum = r("ExoNum").ToString()
        Try
            oIDF_Import.ExoFec = DateTime.Parse(r("ExoFec").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oIDF_Import.ExoFec = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oIDF_Import.ExoFec = DateTime.Now
        End Try
        oIDF_Import.UsuCreacion = r("UsuCreacion").ToString()
        Try
            oIDF_Import.FechaCreacion = DateTime.Parse(r("FechaCreacion").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oIDF_Import.FechaCreacion = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oIDF_Import.FechaCreacion = DateTime.Now
        End Try
        oIDF_Import.UsuEdicion = r("UsuEdicion").ToString()
        Try
            oIDF_Import.FechaEdicion = DateTime.Parse(r("FechaEdicion").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oIDF_Import.FechaEdicion = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oIDF_Import.FechaEdicion = DateTime.Now
        End Try
        oIDF_Import.AnioAReportar = Int32.Parse(r("AnioAReportar").ToString())
        oIDF_Import.MesAReportar = Int32.Parse(r("MesAReportar").ToString())
        '
        Return oIDF_Import
    End Function
    '
    ' asigna un objeto IDF_Import a la fila indicada
    Private Shared Sub IDF_Import2Row(oIDF_Import As IDF_Import, r As DataRow)
        ' asigna un objeto IDF_Import al dataRow indicado
        ' TODO: Comprueba si esta asignación debe hacerse
        '       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        'r("ImportID") = oIDF_Import.ImportID
        r("EmpresaCodigo") = oIDF_Import.EmpresaCodigo
        r("Fecha") = oIDF_Import.Fecha
        r("SdN") = oIDF_Import.SdN
        r("NumDua") = oIDF_Import.NumDua
        r("NumLiq") = oIDF_Import.NumLiq
        r("ExoNum") = oIDF_Import.ExoNum
        r("ExoFec") = oIDF_Import.ExoFec
        r("UsuCreacion") = oIDF_Import.UsuCreacion
        r("FechaCreacion") = oIDF_Import.FechaCreacion
        r("UsuEdicion") = oIDF_Import.UsuEdicion
        r("FechaEdicion") = oIDF_Import.FechaEdicion
        r("AnioAReportar") = oIDF_Import.AnioAReportar
        r("MesAReportar") = oIDF_Import.MesAReportar
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto IDF_Import
    Private Shared Sub nuevoIDF_Import(dt As DataTable, oIDF_Import As IDF_Import)
        ' Crear un nuevo IDF_Import
        Dim dr As DataRow = dt.NewRow()
        Dim oI As IDF_Import = row2IDF_Import(dr)
        '
        oI.ImportID = oIDF_Import.ImportID
        oI.EmpresaCodigo = oIDF_Import.EmpresaCodigo
        oI.Fecha = oIDF_Import.Fecha
        oI.SdN = oIDF_Import.SdN
        oI.NumDua = oIDF_Import.NumDua
        oI.NumLiq = oIDF_Import.NumLiq
        oI.ExoNum = oIDF_Import.ExoNum
        oI.ExoFec = oIDF_Import.ExoFec
        oI.UsuCreacion = oIDF_Import.UsuCreacion
        oI.FechaCreacion = oIDF_Import.FechaCreacion
        oI.UsuEdicion = oIDF_Import.UsuEdicion
        oI.FechaEdicion = oIDF_Import.FechaEdicion
        oI.AnioAReportar = oIDF_Import.AnioAReportar
        oI.MesAReportar = oIDF_Import.MesAReportar
        '
        IDF_Import2Row(oI, dr)
        '
        dt.Rows.Add(dr)
    End Sub
    '
    ' Métodos públicos
    '
    ' devuelve una tabla con los datos indicados en la cadena de selección
    Public Shared Function Tabla() As DataTable
        Return Tabla(CadenaSelect)
    End Function
    Public Shared Function Tabla(sel As String) As DataTable
        ' devuelve una tabla con los datos de la tabla IDF_Import
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_Import")
        '
        Try
            da = New SqlDataAdapter(sel, cadenaConexion)
            da.Fill(dt)
        Catch
            Return Nothing
        End Try
        '
        Return dt
    End Function
    '
    Public Shared Function Buscar(sWhere As String) As IDF_Import
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oIDF_Import As IDF_Import = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_Import")
        Dim sel As String = "SELECT * FROM IDF_Import WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oIDF_Import = row2IDF_Import(dt.Rows(0))
        End If
        Return oIDF_Import
    End Function
    '
    ' Actualizar: Actualiza los datos en la tabla usando la instancia actual
    '             Si la instancia no hace referencia a un registro existente, se creará uno nuevo
    '             Para comprobar si el objeto en memoria coincide con uno existente,
    '             se comprueba si el ImportID existe en la tabla.
    '             TODO: Si en lugar de ImportID usas otro campo, indicalo en la cadena SELECT
    '                   También puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    Public Function Actualizar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el ImportID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_Import WHERE ImportID = " & Me.ImportID.ToString()
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(sel As String) As String
        ' Actualiza los datos indicados
        ' El parámetro, que es una cadena de selección, indicará el criterio de actualización
        '
        ' En caso de error, devolverá la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_Import")
        '
        cnn = New SqlConnection(cadenaConexion)
        'da = New SqlDataAdapter(CadenaSelect, cnn)
        da = New SqlDataAdapter(sel, cnn)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        '
        '-------------------------------------------
        ' Esta no es la más óptima, pero funcionará
        '-------------------------------------------
        'Dim cb As New SqlCommandBuilder(da)
        'da.UpdateCommand = cb.GetUpdateCommand()
        '
        '--------------------------------------------------------------------
        ' Esta está más optimizada pero debes comprobar que funciona bien...
        '--------------------------------------------------------------------
        Dim sCommand As String
        '
        ' El comando UPDATE
        ' TODO: Comprobar cual es el campo de índice principal (sin duplicados)
        '       Yo compruebo que sea un campo llamado ImportID, pero en tu caso puede ser otro
        '       Ese campo, (en mi caso ImportID) será el que hay que poner al final junto al WHERE.
        sCommand = "UPDATE IDF_Import SET EmpresaCodigo = @EmpresaCodigo, Fecha = @Fecha, SdN = @SdN, NumDua = @NumDua, NumLiq = @NumLiq, ExoNum = @ExoNum, ExoFec = @ExoFec, UsuCreacion = @UsuCreacion, FechaCreacion = @FechaCreacion, UsuEdicion = @UsuEdicion, FechaEdicion = @FechaEdicion, AnioAReportar = @AnioAReportar, MesAReportar = @MesAReportar  WHERE (ImportID = @ImportID)"
        da.UpdateCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@ImportID", SqlDbType.Int, 0, "ImportID")
        da.UpdateCommand.Parameters.Add("@EmpresaCodigo", SqlDbType.NVarChar, 10, "EmpresaCodigo")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@Fecha", SqlDbType.DateTime, 0, "Fecha")
        da.UpdateCommand.Parameters.Add("@SdN", SqlDbType.NVarChar, 25, "SdN")
        da.UpdateCommand.Parameters.Add("@NumDua", SqlDbType.NVarChar, 25, "NumDua")
        da.UpdateCommand.Parameters.Add("@NumLiq", SqlDbType.NVarChar, 25, "NumLiq")
        da.UpdateCommand.Parameters.Add("@ExoNum", SqlDbType.NVarChar, 25, "ExoNum")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@ExoFec", SqlDbType.DateTime, 0, "ExoFec")
        da.UpdateCommand.Parameters.Add("@UsuCreacion", SqlDbType.NVarChar, 25, "UsuCreacion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 0, "FechaCreacion")
        da.UpdateCommand.Parameters.Add("@UsuEdicion", SqlDbType.NVarChar, 25, "UsuEdicion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@FechaEdicion", SqlDbType.DateTime, 0, "FechaEdicion")
        da.UpdateCommand.Parameters.Add("@AnioAReportar", SqlDbType.Int, 0, "AnioAReportar")
        da.UpdateCommand.Parameters.Add("@MesAReportar", SqlDbType.Int, 0, "MesAReportar")
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        If dt.Rows.Count = 0 Then
            ' crear uno nuevo
            Return Crear()
        Else
            IDF_Import2Row(Me, dt.Rows(0))
        End If
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Actualizado correctamente"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Crear() As String
        ' Crear un nuevo registro
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_Import")
        '
        cnn = New SqlConnection(cadenaConexion)
        da = New SqlDataAdapter(CadenaSelect, cnn)
        'da = New SqlDataAdapter(CadenaSelect, cadenaConexion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        '
        '-------------------------------------------
        ' Esta no es la más óptima, pero funcionará
        '-------------------------------------------
        'Dim cb As New SqlCommandBuilder(da)
        'da.InsertCommand = cb.GetInsertCommand()
        '
        '--------------------------------------------------------------------
        ' Esta está más optimizada pero debes comprobar que funciona bien...
        '--------------------------------------------------------------------
        Dim sCommand As String
        '
        ' El comando INSERT
        ' TODO: No incluir el campo de clave primaria incremental
        '       Yo compruebo que sea un campo llamado ImportID, pero en tu caso puede ser otro
        sCommand = "INSERT INTO IDF_Import (EmpresaCodigo, Fecha, SdN, NumDua, NumLiq, ExoNum, ExoFec, UsuCreacion, FechaCreacion, UsuEdicion, FechaEdicion, AnioAReportar, MesAReportar)  VALUES(@EmpresaCodigo, @Fecha, @SdN, @NumDua, @NumLiq, @ExoNum, @ExoFec, @UsuCreacion, @FechaCreacion, @UsuEdicion, @FechaEdicion, @AnioAReportar, @MesAReportar)"
        da.InsertCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@ImportID", SqlDbType.Int, 0, "ImportID")
        da.InsertCommand.Parameters.Add("@EmpresaCodigo", SqlDbType.NVarChar, 10, "EmpresaCodigo")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@Fecha", SqlDbType.DateTime, 0, "Fecha")
        da.InsertCommand.Parameters.Add("@SdN", SqlDbType.NVarChar, 25, "SdN")
        da.InsertCommand.Parameters.Add("@NumDua", SqlDbType.NVarChar, 25, "NumDua")
        da.InsertCommand.Parameters.Add("@NumLiq", SqlDbType.NVarChar, 25, "NumLiq")
        da.InsertCommand.Parameters.Add("@ExoNum", SqlDbType.NVarChar, 25, "ExoNum")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@ExoFec", SqlDbType.DateTime, 0, "ExoFec")
        da.InsertCommand.Parameters.Add("@UsuCreacion", SqlDbType.NVarChar, 25, "UsuCreacion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 0, "FechaCreacion")
        da.InsertCommand.Parameters.Add("@UsuEdicion", SqlDbType.NVarChar, 25, "UsuEdicion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@FechaEdicion", SqlDbType.DateTime, 0, "FechaEdicion")
        da.InsertCommand.Parameters.Add("@AnioAReportar", SqlDbType.Int, 0, "AnioAReportar")
        da.InsertCommand.Parameters.Add("@MesAReportar", SqlDbType.Int, 0, "MesAReportar")
        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoIDF_Import(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo IDF_Import"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el ImportID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_Import WHERE ImportID = " & Me.ImportID.ToString()
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_Import")
        '
        cnn = New SqlConnection(cadenaConexion)
        da = New SqlDataAdapter(sel, cnn)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        '
        '-------------------------------------------
        ' Esta no es la más óptima, pero funcionará
        '-------------------------------------------
        'Dim cb As New SqlCommandBuilder(da)
        'da.DeleteCommand = cb.GetDeleteCommand()
        '
        '
        '--------------------------------------------------------------------
        ' Esta está más optimizada pero debes comprobar que funciona bien...
        '--------------------------------------------------------------------
        Dim sCommand As String
        '
        ' El comando DELETE
        ' TODO: Sólo incluir el campo de clave primaria incremental
        '       Yo compruebo que sea un campo llamado ImportID, pero en tu caso puede ser otro
        sCommand = "DELETE FROM IDF_Import WHERE (ImportID = @p1)"
        da.DeleteCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.DeleteCommand.Parameters.Add("@p1", SqlDbType.Int, 0, "ImportID")
        da.DeleteCommand.Parameters.Add("@p2", SqlDbType.Int, 0, "")
        '
        '
        da.Fill(dt)
        '
        If dt.Rows.Count = 0 Then
            Return "ERROR: No hay datos"
        Else
            dt.Rows(0).Delete()
        End If
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Borrado satisfactoriamente"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
End Class
