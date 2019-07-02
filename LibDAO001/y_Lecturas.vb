'------------------------------------------------------------------------------
' Clase y_Lecturas generada automáticamente con CrearClaseSQL
' de la tabla 'y_Lecturas' de la base 'Produccion'
' Fecha: 17/Nov/2015 14:21:14
'
' ©Guillermo 'guille' Som, 2004-2015
'------------------------------------------------------------------------------
Option Strict On
Option Explicit On
'
Imports System
Imports System.Data
Imports System.Data.SqlClient
'
Public Class y_Lecturas
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _idLectura As System.Decimal
    Private _idPluviometro As System.Int32
    Private _idUsuario As System.Int32
    Private _lectura As System.Double
    Private _evaporacion As System.Double
    Private _fecha As System.DateTime
    Private _idUsuarioModif As System.Int32
    Private _observacion As System.String
    Private _FechaCreacion As System.DateTime
    Private _FechaModificacion As System.DateTime
    Private _UsuarioCreador As System.String
    Private _UsuarioEditor As System.String
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
    Public Property idLectura() As System.Decimal
        Get
            Return  _idLectura
        End Get
        Set(value As System.Decimal)
            _idLectura = value
        End Set
    End Property
    Public Property idPluviometro() As System.Int32
        Get
            Return  _idPluviometro
        End Get
        Set(value As System.Int32)
            _idPluviometro = value
        End Set
    End Property
    Public Property idUsuario() As System.Int32
        Get
            Return  _idUsuario
        End Get
        Set(value As System.Int32)
            _idUsuario = value
        End Set
    End Property
    Public Property lectura() As System.Double
        Get
            Return  _lectura
        End Get
        Set(value As System.Double)
            _lectura = value
        End Set
    End Property
    Public Property evaporacion() As System.Double
        Get
            Return  _evaporacion
        End Get
        Set(value As System.Double)
            _evaporacion = value
        End Set
    End Property
    Public Property fecha() As System.DateTime
        Get
            Return  _fecha
        End Get
        Set(value As System.DateTime)
            _fecha = value
        End Set
    End Property
    Public Property idUsuarioModif() As System.Int32
        Get
            Return  _idUsuarioModif
        End Get
        Set(value As System.Int32)
            _idUsuarioModif = value
        End Set
    End Property
    Public Property observacion() As System.String
        Get
            ' Seguramente sería mejor sin ajustar el ancho...
            'Return ajustarAncho(_observacion,2147483647)
            Return  _observacion
        End Get
        Set(value As System.String)
            _observacion = value
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
    Public Property FechaModificacion() As System.DateTime
        Get
            Return  _FechaModificacion
        End Get
        Set(value As System.DateTime)
            _FechaModificacion = value
        End Set
    End Property
    Public Property UsuarioCreador() As System.String
        Get
            Return ajustarAncho(_UsuarioCreador,50)
        End Get
        Set(value As System.String)
            _UsuarioCreador = value
        End Set
    End Property
    Public Property UsuarioEditor() As System.String
        Get
            Return ajustarAncho(_UsuarioEditor,50)
        End Get
        Set(value As System.String)
            _UsuarioEditor = value
        End Set
    End Property
    '
    Public Default Property Item(index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.idLectura.ToString()
            ElseIf index = 1 Then
                Return Me.idPluviometro.ToString()
            ElseIf index = 2 Then
                Return Me.idUsuario.ToString()
            ElseIf index = 3 Then
                Return Me.lectura.ToString()
            ElseIf index = 4 Then
                Return Me.evaporacion.ToString()
            ElseIf index = 5 Then
                Return Me.fecha.ToString()
            ElseIf index = 6 Then
                Return Me.idUsuarioModif.ToString()
            ElseIf index = 7 Then
                Return Me.observacion.ToString()
            ElseIf index = 8 Then
                Return Me.FechaCreacion.ToString()
            ElseIf index = 9 Then
                Return Me.FechaModificacion.ToString()
            ElseIf index = 10 Then
                Return Me.UsuarioCreador.ToString()
            ElseIf index = 11 Then
                Return Me.UsuarioEditor.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = 0 Then
                Try
                    Me.idLectura = System.Decimal.Parse("0" & value)
                Catch
                    Me.idLectura = System.Decimal.Parse("0")
                End Try
            ElseIf index = 1 Then
                Try
                    Me.idPluviometro = System.Int32.Parse("0" & value)
                Catch
                    Me.idPluviometro = System.Int32.Parse("0")
                End Try
            ElseIf index = 2 Then
                Try
                    Me.idUsuario = System.Int32.Parse("0" & value)
                Catch
                    Me.idUsuario = System.Int32.Parse("0")
                End Try
            ElseIf index = 3 Then
                Try
                    Me.lectura = System.Double.Parse("0" & value)
                Catch
                    Me.lectura = System.Double.Parse("0")
                End Try
            ElseIf index = 4 Then
                Try
                    Me.evaporacion = System.Double.Parse("0" & value)
                Catch
                    Me.evaporacion = System.Double.Parse("0")
                End Try
            ElseIf index = 5 Then
                Try
                    Me.fecha = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.fecha = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.fecha = System.DateTime.Now
                End Try
            ElseIf index = 6 Then
                Try
                    Me.idUsuarioModif = System.Int32.Parse("0" & value)
                Catch
                    Me.idUsuarioModif = System.Int32.Parse("0")
                End Try
            ElseIf index = 7 Then
                Me.observacion = value
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
                    Me.FechaModificacion = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaModificacion = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaModificacion = System.DateTime.Now
                End Try
            ElseIf index = 10 Then
                Me.UsuarioCreador = value
            ElseIf index = 11 Then
                Me.UsuarioEditor = value
            End If
        End Set
    End Property
    Public Default Property Item(index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde al nombre de la columna)
        Get
            If index = "idLectura" Then
                Return Me.idLectura.ToString()
            ElseIf index = "idPluviometro" Then
                Return Me.idPluviometro.ToString()
            ElseIf index = "idUsuario" Then
                Return Me.idUsuario.ToString()
            ElseIf index = "lectura" Then
                Return Me.lectura.ToString()
            ElseIf index = "evaporacion" Then
                Return Me.evaporacion.ToString()
            ElseIf index = "fecha" Then
                Return Me.fecha.ToString()
            ElseIf index = "idUsuarioModif" Then
                Return Me.idUsuarioModif.ToString()
            ElseIf index = "observacion" Then
                Return Me.observacion.ToString()
            ElseIf index = "FechaCreacion" Then
                Return Me.FechaCreacion.ToString()
            ElseIf index = "FechaModificacion" Then
                Return Me.FechaModificacion.ToString()
            ElseIf index = "UsuarioCreador" Then
                Return Me.UsuarioCreador.ToString()
            ElseIf index = "UsuarioEditor" Then
                Return Me.UsuarioEditor.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = "idLectura" Then
                Try
                    Me.idLectura = System.Decimal.Parse("0" & value)
                Catch
                    Me.idLectura = System.Decimal.Parse("0")
                End Try
            ElseIf index = "idPluviometro" Then
                Try
                    Me.idPluviometro = System.Int32.Parse("0" & value)
                Catch
                    Me.idPluviometro = System.Int32.Parse("0")
                End Try
            ElseIf index = "idUsuario" Then
                Try
                    Me.idUsuario = System.Int32.Parse("0" & value)
                Catch
                    Me.idUsuario = System.Int32.Parse("0")
                End Try
            ElseIf index = "lectura" Then
                Try
                    Me.lectura = System.Double.Parse("0" & value)
                Catch
                    Me.lectura = System.Double.Parse("0")
                End Try
            ElseIf index = "evaporacion" Then
                Try
                    Me.evaporacion = System.Double.Parse("0" & value)
                Catch
                    Me.evaporacion = System.Double.Parse("0")
                End Try
            ElseIf index = "fecha" Then
                Try
                    Me.fecha = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.fecha = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.fecha = System.DateTime.Now
                End Try
            ElseIf index = "idUsuarioModif" Then
                Try
                    Me.idUsuarioModif = System.Int32.Parse("0" & value)
                Catch
                    Me.idUsuarioModif = System.Int32.Parse("0")
                End Try
            ElseIf index = "observacion" Then
                Me.observacion = value
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
            ElseIf index = "FechaModificacion" Then
                Try
                    Me.FechaModificacion = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaModificacion = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaModificacion = System.DateTime.Now
                End Try
            ElseIf index = "UsuarioCreador" Then
                Me.UsuarioCreador = value
            ElseIf index = "UsuarioEditor" Then
                Me.UsuarioEditor = value
            End If
        End Set
    End Property
    '
    ' Campos y métodos compartidos (estáticos) para gestionar la base de datos
    '
    ' La cadena de conexión a la base de datos
    Private Shared cadenaConexion As String = ""
    ' La cadena de selección
    Public Shared CadenaSelect As String = "SELECT * FROM y_Lecturas"
    '
    Public Sub New()
    End Sub
    Public Sub New(conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto y_Lecturas
    Private Shared Function row2y_Lecturas(r As DataRow) As y_Lecturas
        ' asigna a un objeto y_Lecturas los datos del dataRow indicado
        Dim oy_Lecturas As New y_Lecturas
        '
        oy_Lecturas.idLectura = System.Decimal.Parse("0" & r("idLectura").ToString())
        oy_Lecturas.idPluviometro = System.Int32.Parse("0" & r("idPluviometro").ToString())
        oy_Lecturas.idUsuario = System.Int32.Parse("0" & r("idUsuario").ToString())
        oy_Lecturas.lectura = System.Double.Parse("0" & r("lectura").ToString())
        oy_Lecturas.evaporacion = System.Double.Parse("0" & r("evaporacion").ToString())
        Try
            oy_Lecturas.fecha = DateTime.Parse(r("fecha").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oy_Lecturas.fecha = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oy_Lecturas.fecha = DateTime.Now
        End Try
        oy_Lecturas.idUsuarioModif = System.Int32.Parse("0" & r("idUsuarioModif").ToString())
        oy_Lecturas.observacion = r("observacion").ToString()
        Try
            oy_Lecturas.FechaCreacion = DateTime.Parse(r("FechaCreacion").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oy_Lecturas.FechaCreacion = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oy_Lecturas.FechaCreacion = DateTime.Now
        End Try
        Try
            oy_Lecturas.FechaModificacion = DateTime.Parse(r("FechaModificacion").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oy_Lecturas.FechaModificacion = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oy_Lecturas.FechaModificacion = DateTime.Now
        End Try
        oy_Lecturas.UsuarioCreador = r("UsuarioCreador").ToString()
        oy_Lecturas.UsuarioEditor = r("UsuarioEditor").ToString()
        '
        Return oy_Lecturas
    End Function
    '
    ' asigna un objeto y_Lecturas a la fila indicada
    Private Shared Sub y_Lecturas2Row(oy_Lecturas As y_Lecturas, r As DataRow)
        ' asigna un objeto y_Lecturas al dataRow indicado
        ' TODO: Comprueba si esta asignación debe hacerse
        '       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        'r("idLectura") = oy_Lecturas.idLectura
        r("idPluviometro") = oy_Lecturas.idPluviometro
        r("idUsuario") = oy_Lecturas.idUsuario
        r("lectura") = oy_Lecturas.lectura
        r("evaporacion") = oy_Lecturas.evaporacion
        r("fecha") = oy_Lecturas.fecha
        r("idUsuarioModif") = oy_Lecturas.idUsuarioModif
        r("observacion") = oy_Lecturas.observacion
        r("FechaCreacion") = oy_Lecturas.FechaCreacion
        r("FechaModificacion") = oy_Lecturas.FechaModificacion
        r("UsuarioCreador") = oy_Lecturas.UsuarioCreador
        r("UsuarioEditor") = oy_Lecturas.UsuarioEditor
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto y_Lecturas
    Private Shared Sub nuevoy_Lecturas(dt As DataTable, oy_Lecturas As y_Lecturas)
        ' Crear un nuevo y_Lecturas
        Dim dr As DataRow = dt.NewRow()
        Dim oy As y_Lecturas = row2y_Lecturas(dr)
        '
        oy.idLectura = oy_Lecturas.idLectura
        oy.idPluviometro = oy_Lecturas.idPluviometro
        oy.idUsuario = oy_Lecturas.idUsuario
        oy.lectura = oy_Lecturas.lectura
        oy.evaporacion = oy_Lecturas.evaporacion
        oy.fecha = oy_Lecturas.fecha
        oy.idUsuarioModif = oy_Lecturas.idUsuarioModif
        oy.observacion = oy_Lecturas.observacion
        oy.FechaCreacion = oy_Lecturas.FechaCreacion
        oy.FechaModificacion = oy_Lecturas.FechaModificacion
        oy.UsuarioCreador = oy_Lecturas.UsuarioCreador
        oy.UsuarioEditor = oy_Lecturas.UsuarioEditor
        '
        y_Lecturas2Row(oy, dr)
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
        ' devuelve una tabla con los datos de la tabla y_Lecturas
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("y_Lecturas")
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
    Public Shared Function Buscar(sWhere As String) As y_Lecturas
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oy_Lecturas As y_Lecturas = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("y_Lecturas")
        Dim sel As String = "SELECT * FROM y_Lecturas WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oy_Lecturas = row2y_Lecturas(dt.Rows(0))
        End If
        Return oy_Lecturas
    End Function
    '
    ' Actualizar: Actualiza los datos en la tabla usando la instancia actual
    '             Si la instancia no hace referencia a un registro existente, se creará uno nuevo
    '             Para comprobar si el objeto en memoria coincide con uno existente,
    '             se comprueba si el idLectura existe en la tabla.
    '             TODO: Si en lugar de idLectura usas otro campo, indicalo en la cadena SELECT
    '                   También puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    Public Function Actualizar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el idLectura que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM y_Lecturas WHERE idLectura = " & Me.idLectura.ToString()
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(sel As String) As String
        ' Actualiza los datos indicados
        ' El parámetro, que es una cadena de selección, indicará el criterio de actualización
        '
        ' En caso de error, devolverá la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("y_Lecturas")
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
        '       Yo compruebo que sea un campo llamado idLectura, pero en tu caso puede ser otro
        '       Ese campo, (en mi caso idLectura) será el que hay que poner al final junto al WHERE.
        sCommand = "UPDATE y_Lecturas SET idPluviometro = @idPluviometro, idUsuario = @idUsuario, lectura = @lectura, evaporacion = @evaporacion, fecha = @fecha, idUsuarioModif = @idUsuarioModif, observacion = @observacion, FechaCreacion = @FechaCreacion, FechaModificacion = @FechaModificacion, UsuarioCreador = @UsuarioCreador, UsuarioEditor = @UsuarioEditor  WHERE (idLectura = @idLectura)"
        da.UpdateCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@idLectura", SqlDbType.Decimal, 0, "idLectura")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@idPluviometro", SqlDbType.Int, 0, "idPluviometro")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@idUsuario", SqlDbType.Int, 0, "idUsuario")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@lectura", SqlDbType.Float, 0, "lectura")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@evaporacion", SqlDbType.Float, 0, "evaporacion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 0, "fecha")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@idUsuarioModif", SqlDbType.Int, 0, "idUsuarioModif")
        ' TODO: Este campo seguramente es MEMO y el valor debería ser cero en lugar de 2147483647
        'da.UpdateCommand.Parameters.Add("@observacion", SqlDbType.NText, 2147483647, "observacion")
        da.UpdateCommand.Parameters.Add("@observacion", SqlDbType.NText, 0, "observacion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 0, "FechaCreacion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 0, "FechaModificacion")
        da.UpdateCommand.Parameters.Add("@UsuarioCreador", SqlDbType.NVarChar, 50, "UsuarioCreador")
        da.UpdateCommand.Parameters.Add("@UsuarioEditor", SqlDbType.NVarChar, 50, "UsuarioEditor")
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
            y_Lecturas2Row(Me, dt.Rows(0))
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
        Dim dt As New DataTable("y_Lecturas")
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
        '       Yo compruebo que sea un campo llamado idLectura, pero en tu caso puede ser otro
        sCommand = "INSERT INTO y_Lecturas (idPluviometro, idUsuario, lectura, evaporacion, fecha, idUsuarioModif, observacion, FechaCreacion, FechaModificacion, UsuarioCreador, UsuarioEditor)  VALUES(@idPluviometro, @idUsuario, @lectura, @evaporacion, @fecha, @idUsuarioModif, @observacion, @FechaCreacion, @FechaModificacion, @UsuarioCreador, @UsuarioEditor)"
        da.InsertCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@idLectura", SqlDbType.Decimal, 0, "idLectura")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@idPluviometro", SqlDbType.Int, 0, "idPluviometro")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@idUsuario", SqlDbType.Int, 0, "idUsuario")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@lectura", SqlDbType.Float, 0, "lectura")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@evaporacion", SqlDbType.Float, 0, "evaporacion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 0, "fecha")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@idUsuarioModif", SqlDbType.Int, 0, "idUsuarioModif")
        ' TODO: Este campo seguramente es MEMO y el valor debería ser cero en lugar de 2147483647
        'da.InsertCommand.Parameters.Add("@observacion", SqlDbType.NText, 2147483647, "observacion")
        da.InsertCommand.Parameters.Add("@observacion", SqlDbType.NText, 0, "observacion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 0, "FechaCreacion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 0, "FechaModificacion")
        da.InsertCommand.Parameters.Add("@UsuarioCreador", SqlDbType.NVarChar, 50, "UsuarioCreador")
        da.InsertCommand.Parameters.Add("@UsuarioEditor", SqlDbType.NVarChar, 50, "UsuarioEditor")
        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoy_Lecturas(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo y_Lecturas"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el idLectura que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM y_Lecturas WHERE idLectura = " & Me.idLectura.ToString()
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("y_Lecturas")
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
        '       Yo compruebo que sea un campo llamado idLectura, pero en tu caso puede ser otro
        sCommand = "DELETE FROM y_Lecturas WHERE (idLectura = @p1)"
        da.DeleteCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.DeleteCommand.Parameters.Add("@p1", SqlDbType.Decimal, 0, "idLectura")
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
