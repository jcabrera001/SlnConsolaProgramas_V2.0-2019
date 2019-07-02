'------------------------------------------------------------------------------
' Clase IDF_CAIXSdN generada automáticamente con CrearClaseSQL
' de la tabla 'IDF_CAIXSdN' de la base 'Finanzas'
' Fecha: 26/Feb/2016 09:28:44
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
Public Class IDF_CAIXSdN
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _CAIXSdNID As System.Int32
    Private _SdN As System.String
    Private _CAI As System.String
    Private _FechaLimite As System.DateTime
    Private _RangoIni As System.Int32
    Private _RangoFin As System.Int32
    Private _UsuCreacion As System.String
    Private _UsuEdicion As System.String
    Private _FechaCreacion As System.DateTime
    Private _FechaEdicion As System.DateTime
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
    Public Property CAIXSdNID() As System.Int32
        Get
            Return  _CAIXSdNID
        End Get
        Set(value As System.Int32)
            _CAIXSdNID = value
        End Set
    End Property
    Public Property SdN() As System.String
        Get
            Return ajustarAncho(_SdN,30)
        End Get
        Set(value As System.String)
            _SdN = value
        End Set
    End Property
    Public Property CAI() As System.String
        Get
            Return ajustarAncho(_CAI,60)
        End Get
        Set(value As System.String)
            _CAI = value
        End Set
    End Property
    Public Property FechaLimite() As System.DateTime
        Get
            Return  _FechaLimite
        End Get
        Set(value As System.DateTime)
            _FechaLimite = value
        End Set
    End Property
    Public Property RangoIni() As System.Int32
        Get
            Return  _RangoIni
        End Get
        Set(value As System.Int32)
            _RangoIni = value
        End Set
    End Property
    Public Property RangoFin() As System.Int32
        Get
            Return  _RangoFin
        End Get
        Set(value As System.Int32)
            _RangoFin = value
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
    Public Property UsuEdicion() As System.String
        Get
            Return ajustarAncho(_UsuEdicion,25)
        End Get
        Set(value As System.String)
            _UsuEdicion = value
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
    Public Property FechaEdicion() As System.DateTime
        Get
            Return  _FechaEdicion
        End Get
        Set(value As System.DateTime)
            _FechaEdicion = value
        End Set
    End Property
    '
    Public Default Property Item(index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.CAIXSdNID.ToString()
            ElseIf index = 1 Then
                Return Me.SdN.ToString()
            ElseIf index = 2 Then
                Return Me.CAI.ToString()
            ElseIf index = 3 Then
                Return Me.FechaLimite.ToString()
            ElseIf index = 4 Then
                Return Me.RangoIni.ToString()
            ElseIf index = 5 Then
                Return Me.RangoFin.ToString()
            ElseIf index = 6 Then
                Return Me.UsuCreacion.ToString()
            ElseIf index = 7 Then
                Return Me.UsuEdicion.ToString()
            ElseIf index = 8 Then
                Return Me.FechaCreacion.ToString()
            ElseIf index = 9 Then
                Return Me.FechaEdicion.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = 0 Then
                Try
                    Me.CAIXSdNID = System.Int32.Parse("0" & value)
                Catch
                    Me.CAIXSdNID = System.Int32.Parse("0")
                End Try
            ElseIf index = 1 Then
                Me.SdN = value
            ElseIf index = 2 Then
                Me.CAI = value
            ElseIf index = 3 Then
                Try
                    Me.FechaLimite = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaLimite = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaLimite = System.DateTime.Now
                End Try
            ElseIf index = 4 Then
                Try
                    Me.RangoIni = System.Int32.Parse("0" & value)
                Catch
                    Me.RangoIni = System.Int32.Parse("0")
                End Try
            ElseIf index = 5 Then
                Try
                    Me.RangoFin = System.Int32.Parse("0" & value)
                Catch
                    Me.RangoFin = System.Int32.Parse("0")
                End Try
            ElseIf index = 6 Then
                Me.UsuCreacion = value
            ElseIf index = 7 Then
                Me.UsuEdicion = value
            ElseIf index = 8 Then
                Try
                    Me.FechaCreacion = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaCreacion = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaCreacion = System.DateTime.Now
                End Try
            ElseIf index = 9 Then
                Try
                    Me.FechaEdicion = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaEdicion = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaEdicion = System.DateTime.Now
                End Try
            End If
        End Set
    End Property
    Public Default Property Item(index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde al nombre de la columna)
        Get
            If index = "CAIXSdNID" Then
                Return Me.CAIXSdNID.ToString()
            ElseIf index = "SdN" Then
                Return Me.SdN.ToString()
            ElseIf index = "CAI" Then
                Return Me.CAI.ToString()
            ElseIf index = "FechaLimite" Then
                Return Me.FechaLimite.ToString()
            ElseIf index = "RangoIni" Then
                Return Me.RangoIni.ToString()
            ElseIf index = "RangoFin" Then
                Return Me.RangoFin.ToString()
            ElseIf index = "UsuCreacion" Then
                Return Me.UsuCreacion.ToString()
            ElseIf index = "UsuEdicion" Then
                Return Me.UsuEdicion.ToString()
            ElseIf index = "FechaCreacion" Then
                Return Me.FechaCreacion.ToString()
            ElseIf index = "FechaEdicion" Then
                Return Me.FechaEdicion.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = "CAIXSdNID" Then
                Try
                    Me.CAIXSdNID = System.Int32.Parse("0" & value)
                Catch
                    Me.CAIXSdNID = System.Int32.Parse("0")
                End Try
            ElseIf index = "SdN" Then
                Me.SdN = value
            ElseIf index = "CAI" Then
                Me.CAI = value
            ElseIf index = "FechaLimite" Then
                Try
                    Me.FechaLimite = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaLimite = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaLimite = System.DateTime.Now
                End Try
            ElseIf index = "RangoIni" Then
                Try
                    Me.RangoIni = System.Int32.Parse("0" & value)
                Catch
                    Me.RangoIni = System.Int32.Parse("0")
                End Try
            ElseIf index = "RangoFin" Then
                Try
                    Me.RangoFin = System.Int32.Parse("0" & value)
                Catch
                    Me.RangoFin = System.Int32.Parse("0")
                End Try
            ElseIf index = "UsuCreacion" Then
                Me.UsuCreacion = value
            ElseIf index = "UsuEdicion" Then
                Me.UsuEdicion = value
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
            End If
        End Set
    End Property
    '
    ' Campos y métodos compartidos (estáticos) para gestionar la base de datos
    '
    ' La cadena de conexión a la base de datos
    Private Shared cadenaConexion As String = "Data Source=amigodb\amigodb; Initial Catalog=Finanzas; user id=rptuser; password=MiTo1380"
    ' La cadena de selección
    Public Shared CadenaSelect As String = "SELECT * FROM IDF_CAIXSdN"
    '
    Public Sub New()
    End Sub
    Public Sub New(conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto IDF_CAIXSdN
    Private Shared Function row2IDF_CAIXSdN(r As DataRow) As IDF_CAIXSdN
        ' asigna a un objeto IDF_CAIXSdN los datos del dataRow indicado
        Dim oIDF_CAIXSdN As New IDF_CAIXSdN
        '
        oIDF_CAIXSdN.CAIXSdNID = System.Int32.Parse("0" & r("CAIXSdNID").ToString())
        oIDF_CAIXSdN.SdN = r("SdN").ToString()
        oIDF_CAIXSdN.CAI = r("CAI").ToString()
        Try
            oIDF_CAIXSdN.FechaLimite = DateTime.Parse(r("FechaLimite").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oIDF_CAIXSdN.FechaLimite = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oIDF_CAIXSdN.FechaLimite = DateTime.Now
        End Try
        oIDF_CAIXSdN.RangoIni = System.Int32.Parse("0" & r("RangoIni").ToString())
        oIDF_CAIXSdN.RangoFin = System.Int32.Parse("0" & r("RangoFin").ToString())
        oIDF_CAIXSdN.UsuCreacion = r("UsuCreacion").ToString()
        oIDF_CAIXSdN.UsuEdicion = r("UsuEdicion").ToString()
        Try
            oIDF_CAIXSdN.FechaCreacion = DateTime.Parse(r("FechaCreacion").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oIDF_CAIXSdN.FechaCreacion = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oIDF_CAIXSdN.FechaCreacion = DateTime.Now
        End Try
        Try
            oIDF_CAIXSdN.FechaEdicion = DateTime.Parse(r("FechaEdicion").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oIDF_CAIXSdN.FechaEdicion = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oIDF_CAIXSdN.FechaEdicion = DateTime.Now
        End Try
        '
        Return oIDF_CAIXSdN
    End Function
    '
    ' asigna un objeto IDF_CAIXSdN a la fila indicada
    Private Shared Sub IDF_CAIXSdN2Row(oIDF_CAIXSdN As IDF_CAIXSdN, r As DataRow)
        ' asigna un objeto IDF_CAIXSdN al dataRow indicado
        ' TODO: Comprueba si esta asignación debe hacerse
        '       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        'r("CAIXSdNID") = oIDF_CAIXSdN.CAIXSdNID
        r("SdN") = oIDF_CAIXSdN.SdN
        r("CAI") = oIDF_CAIXSdN.CAI
        r("FechaLimite") = oIDF_CAIXSdN.FechaLimite
        r("RangoIni") = oIDF_CAIXSdN.RangoIni
        r("RangoFin") = oIDF_CAIXSdN.RangoFin
        r("UsuCreacion") = oIDF_CAIXSdN.UsuCreacion
        r("UsuEdicion") = oIDF_CAIXSdN.UsuEdicion
        r("FechaCreacion") = oIDF_CAIXSdN.FechaCreacion
        r("FechaEdicion") = oIDF_CAIXSdN.FechaEdicion
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto IDF_CAIXSdN
    Private Shared Sub nuevoIDF_CAIXSdN(dt As DataTable, oIDF_CAIXSdN As IDF_CAIXSdN)
        ' Crear un nuevo IDF_CAIXSdN
        Dim dr As DataRow = dt.NewRow()
        Dim oI As IDF_CAIXSdN = row2IDF_CAIXSdN(dr)
        '
        oI.CAIXSdNID = oIDF_CAIXSdN.CAIXSdNID
        oI.SdN = oIDF_CAIXSdN.SdN
        oI.CAI = oIDF_CAIXSdN.CAI
        oI.FechaLimite = oIDF_CAIXSdN.FechaLimite
        oI.RangoIni = oIDF_CAIXSdN.RangoIni
        oI.RangoFin = oIDF_CAIXSdN.RangoFin
        oI.UsuCreacion = oIDF_CAIXSdN.UsuCreacion
        oI.UsuEdicion = oIDF_CAIXSdN.UsuEdicion
        oI.FechaCreacion = oIDF_CAIXSdN.FechaCreacion
        oI.FechaEdicion = oIDF_CAIXSdN.FechaEdicion
        '
        IDF_CAIXSdN2Row(oI, dr)
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
        ' devuelve una tabla con los datos de la tabla IDF_CAIXSdN
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_CAIXSdN")
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
    Public Shared Function Buscar(sWhere As String) As IDF_CAIXSdN
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oIDF_CAIXSdN As IDF_CAIXSdN = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_CAIXSdN")
        Dim sel As String = "SELECT * FROM IDF_CAIXSdN WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oIDF_CAIXSdN = row2IDF_CAIXSdN(dt.Rows(0))
        End If
        Return oIDF_CAIXSdN
    End Function
    '
    ' Actualizar: Actualiza los datos en la tabla usando la instancia actual
    '             Si la instancia no hace referencia a un registro existente, se creará uno nuevo
    '             Para comprobar si el objeto en memoria coincide con uno existente,
    '             se comprueba si el CAIXSdNID existe en la tabla.
    '             TODO: Si en lugar de CAIXSdNID usas otro campo, indicalo en la cadena SELECT
    '                   También puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    Public Function Actualizar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el CAIXSdNID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_CAIXSdN WHERE CAIXSdNID = " & Me.CAIXSdNID.ToString()
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(sel As String) As String
        ' Actualiza los datos indicados
        ' El parámetro, que es una cadena de selección, indicará el criterio de actualización
        '
        ' En caso de error, devolverá la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_CAIXSdN")
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
        '       Yo compruebo que sea un campo llamado CAIXSdNID, pero en tu caso puede ser otro
        '       Ese campo, (en mi caso CAIXSdNID) será el que hay que poner al final junto al WHERE.
        sCommand = "UPDATE IDF_CAIXSdN SET SdN = @SdN, CAI = @CAI, FechaLimite = @FechaLimite, RangoIni = @RangoIni, RangoFin = @RangoFin, UsuCreacion = @UsuCreacion, UsuEdicion = @UsuEdicion, FechaCreacion = @FechaCreacion, FechaEdicion = @FechaEdicion  WHERE (CAIXSdNID = @CAIXSdNID)"
        da.UpdateCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@CAIXSdNID", SqlDbType.Int, 0, "CAIXSdNID")
        da.UpdateCommand.Parameters.Add("@SdN", SqlDbType.NVarChar, 30, "SdN")
        da.UpdateCommand.Parameters.Add("@CAI", SqlDbType.NVarChar, 60, "CAI")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@FechaLimite", SqlDbType.DateTime, 0, "FechaLimite")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@RangoIni", SqlDbType.Int, 0, "RangoIni")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@RangoFin", SqlDbType.Int, 0, "RangoFin")
        da.UpdateCommand.Parameters.Add("@UsuCreacion", SqlDbType.NVarChar, 25, "UsuCreacion")
        da.UpdateCommand.Parameters.Add("@UsuEdicion", SqlDbType.NVarChar, 25, "UsuEdicion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 0, "FechaCreacion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@FechaEdicion", SqlDbType.DateTime, 0, "FechaEdicion")
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
            IDF_CAIXSdN2Row(Me, dt.Rows(0))
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
        Dim dt As New DataTable("IDF_CAIXSdN")
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
        '       Yo compruebo que sea un campo llamado CAIXSdNID, pero en tu caso puede ser otro
        sCommand = "INSERT INTO IDF_CAIXSdN (SdN, CAI, FechaLimite, RangoIni, RangoFin, UsuCreacion, UsuEdicion, FechaCreacion, FechaEdicion)  VALUES(@SdN, @CAI, @FechaLimite, @RangoIni, @RangoFin, @UsuCreacion, @UsuEdicion, @FechaCreacion, @FechaEdicion)"
        da.InsertCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@CAIXSdNID", SqlDbType.Int, 0, "CAIXSdNID")
        da.InsertCommand.Parameters.Add("@SdN", SqlDbType.NVarChar, 30, "SdN")
        da.InsertCommand.Parameters.Add("@CAI", SqlDbType.NVarChar, 60, "CAI")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@FechaLimite", SqlDbType.DateTime, 0, "FechaLimite")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@RangoIni", SqlDbType.Int, 0, "RangoIni")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@RangoFin", SqlDbType.Int, 0, "RangoFin")
        da.InsertCommand.Parameters.Add("@UsuCreacion", SqlDbType.NVarChar, 25, "UsuCreacion")
        da.InsertCommand.Parameters.Add("@UsuEdicion", SqlDbType.NVarChar, 25, "UsuEdicion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 0, "FechaCreacion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@FechaEdicion", SqlDbType.DateTime, 0, "FechaEdicion")
        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoIDF_CAIXSdN(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo IDF_CAIXSdN"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el CAIXSdNID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_CAIXSdN WHERE CAIXSdNID = " & Me.CAIXSdNID.ToString()
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_CAIXSdN")
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
        '       Yo compruebo que sea un campo llamado CAIXSdNID, pero en tu caso puede ser otro
        sCommand = "DELETE FROM IDF_CAIXSdN WHERE (CAIXSdNID = @p1)"
        da.DeleteCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.DeleteCommand.Parameters.Add("@p1", SqlDbType.Int, 0, "CAIXSdNID")
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
