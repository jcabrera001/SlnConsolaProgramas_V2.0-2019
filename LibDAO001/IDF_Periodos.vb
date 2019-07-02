'------------------------------------------------------------------------------
' Clase IDF_Periodos generada automáticamente con CrearClaseSQL
' de la tabla 'IDF_Periodos' de la base 'Finanzas'
' Fecha: 07/Sep/2015 14:40:20
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
Public Class IDF_Periodos
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _PeriodoID As System.Int32
    Private _Descripcion As System.String
    Private _Desde As System.DateTime
    Private _Hasta As System.DateTime
    Private _UsuarioCreador As System.String
    Private _UsuarioEditor As System.String
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
    Public Property PeriodoID() As System.Int32
        Get
            Return  _PeriodoID
        End Get
        Set(value As System.Int32)
            _PeriodoID = value
        End Set
    End Property
    Public Property Descripcion() As System.String
        Get
            Return ajustarAncho(_Descripcion,50)
        End Get
        Set(value As System.String)
            _Descripcion = value
        End Set
    End Property
    Public Property Desde() As System.DateTime
        Get
            Return  _Desde
        End Get
        Set(value As System.DateTime)
            _Desde = value
        End Set
    End Property
    Public Property Hasta() As System.DateTime
        Get
            Return  _Hasta
        End Get
        Set(value As System.DateTime)
            _Hasta = value
        End Set
    End Property
    Public Property UsuarioCreador() As System.String
        Get
            Return ajustarAncho(_UsuarioCreador,25)
        End Get
        Set(value As System.String)
            _UsuarioCreador = value
        End Set
    End Property
    Public Property UsuarioEditor() As System.String
        Get
            Return ajustarAncho(_UsuarioEditor,25)
        End Get
        Set(value As System.String)
            _UsuarioEditor = value
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
                Return Me.PeriodoID.ToString()
            ElseIf index = 1 Then
                Return Me.Descripcion.ToString()
            ElseIf index = 2 Then
                Return Me.Desde.ToString()
            ElseIf index = 3 Then
                Return Me.Hasta.ToString()
            ElseIf index = 4 Then
                Return Me.UsuarioCreador.ToString()
            ElseIf index = 5 Then
                Return Me.UsuarioEditor.ToString()
            ElseIf index = 6 Then
                Return Me.FechaCreacion.ToString()
            ElseIf index = 7 Then
                Return Me.FechaEdicion.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = 0 Then
                Try
                    Me.PeriodoID = System.Int32.Parse("0" & value)
                Catch
                    Me.PeriodoID = System.Int32.Parse("0")
                End Try
            ElseIf index = 1 Then
                Me.Descripcion = value
            ElseIf index = 2 Then
                Try
                    Me.Desde = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.Desde = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.Desde = System.DateTime.Now
                End Try
            ElseIf index = 3 Then
                Try
                    Me.Hasta = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.Hasta = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.Hasta = System.DateTime.Now
                End Try
            ElseIf index = 4 Then
                Me.UsuarioCreador = value
            ElseIf index = 5 Then
                Me.UsuarioEditor = value
            ElseIf index = 6 Then
                Try
                    Me.FechaCreacion = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaCreacion = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaCreacion = System.DateTime.Now
                End Try
            ElseIf index = 7 Then
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
            If index = "PeriodoID" Then
                Return Me.PeriodoID.ToString()
            ElseIf index = "Descripcion" Then
                Return Me.Descripcion.ToString()
            ElseIf index = "Desde" Then
                Return Me.Desde.ToString()
            ElseIf index = "Hasta" Then
                Return Me.Hasta.ToString()
            ElseIf index = "UsuarioCreador" Then
                Return Me.UsuarioCreador.ToString()
            ElseIf index = "UsuarioEditor" Then
                Return Me.UsuarioEditor.ToString()
            ElseIf index = "FechaCreacion" Then
                Return Me.FechaCreacion.ToString()
            ElseIf index = "FechaEdicion" Then
                Return Me.FechaEdicion.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = "PeriodoID" Then
                Try
                    Me.PeriodoID = System.Int32.Parse("0" & value)
                Catch
                    Me.PeriodoID = System.Int32.Parse("0")
                End Try
            ElseIf index = "Descripcion" Then
                Me.Descripcion = value
            ElseIf index = "Desde" Then
                Try
                    Me.Desde = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.Desde = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.Desde = System.DateTime.Now
                End Try
            ElseIf index = "Hasta" Then
                Try
                    Me.Hasta = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.Hasta = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.Hasta = System.DateTime.Now
                End Try
            ElseIf index = "UsuarioCreador" Then
                Me.UsuarioCreador = value
            ElseIf index = "UsuarioEditor" Then
                Me.UsuarioEditor = value
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
    Public Shared CadenaSelect As String = "SELECT * FROM IDF_Periodos"
    '
    Public Sub New()
    End Sub
    Public Sub New(conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto IDF_Periodos
    Private Shared Function row2IDF_Periodos(r As DataRow) As IDF_Periodos
        ' asigna a un objeto IDF_Periodos los datos del dataRow indicado
        Dim oIDF_Periodos As New IDF_Periodos
        '
        oIDF_Periodos.PeriodoID = System.Int32.Parse("0" & r("PeriodoID").ToString())
        oIDF_Periodos.Descripcion = r("Descripcion").ToString()
        Try
            oIDF_Periodos.Desde = DateTime.Parse(r("Desde").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oIDF_Periodos.Desde = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oIDF_Periodos.Desde = DateTime.Now
        End Try
        Try
            oIDF_Periodos.Hasta = DateTime.Parse(r("Hasta").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oIDF_Periodos.Hasta = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oIDF_Periodos.Hasta = DateTime.Now
        End Try
        oIDF_Periodos.UsuarioCreador = r("UsuarioCreador").ToString()
        oIDF_Periodos.UsuarioEditor = r("UsuarioEditor").ToString()
        Try
            oIDF_Periodos.FechaCreacion = DateTime.Parse(r("FechaCreacion").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oIDF_Periodos.FechaCreacion = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oIDF_Periodos.FechaCreacion = DateTime.Now
        End Try
        Try
            oIDF_Periodos.FechaEdicion = DateTime.Parse(r("FechaEdicion").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oIDF_Periodos.FechaEdicion = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oIDF_Periodos.FechaEdicion = DateTime.Now
        End Try
        '
        Return oIDF_Periodos
    End Function
    '
    ' asigna un objeto IDF_Periodos a la fila indicada
    Private Shared Sub IDF_Periodos2Row(oIDF_Periodos As IDF_Periodos, r As DataRow)
        ' asigna un objeto IDF_Periodos al dataRow indicado
        ' TODO: Comprueba si esta asignación debe hacerse
        '       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        'r("PeriodoID") = oIDF_Periodos.PeriodoID
        r("Descripcion") = oIDF_Periodos.Descripcion
        r("Desde") = oIDF_Periodos.Desde
        r("Hasta") = oIDF_Periodos.Hasta
        r("UsuarioCreador") = oIDF_Periodos.UsuarioCreador
        r("UsuarioEditor") = oIDF_Periodos.UsuarioEditor
        r("FechaCreacion") = oIDF_Periodos.FechaCreacion
        r("FechaEdicion") = oIDF_Periodos.FechaEdicion
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto IDF_Periodos
    Private Shared Sub nuevoIDF_Periodos(dt As DataTable, oIDF_Periodos As IDF_Periodos)
        ' Crear un nuevo IDF_Periodos
        Dim dr As DataRow = dt.NewRow()
        Dim oI As IDF_Periodos = row2IDF_Periodos(dr)
        '
        oI.PeriodoID = oIDF_Periodos.PeriodoID
        oI.Descripcion = oIDF_Periodos.Descripcion
        oI.Desde = oIDF_Periodos.Desde
        oI.Hasta = oIDF_Periodos.Hasta
        oI.UsuarioCreador = oIDF_Periodos.UsuarioCreador
        oI.UsuarioEditor = oIDF_Periodos.UsuarioEditor
        oI.FechaCreacion = oIDF_Periodos.FechaCreacion
        oI.FechaEdicion = oIDF_Periodos.FechaEdicion
        '
        IDF_Periodos2Row(oI, dr)
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
        ' devuelve una tabla con los datos de la tabla IDF_Periodos
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_Periodos")
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
    Public Shared Function Buscar(sWhere As String) As IDF_Periodos
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oIDF_Periodos As IDF_Periodos = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_Periodos")
        Dim sel As String = "SELECT * FROM IDF_Periodos WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oIDF_Periodos = row2IDF_Periodos(dt.Rows(0))
        End If
        Return oIDF_Periodos
    End Function
    '
    ' Actualizar: Actualiza los datos en la tabla usando la instancia actual
    '             Si la instancia no hace referencia a un registro existente, se creará uno nuevo
    '             Para comprobar si el objeto en memoria coincide con uno existente,
    '             se comprueba si el PeriodoID existe en la tabla.
    '             TODO: Si en lugar de PeriodoID usas otro campo, indicalo en la cadena SELECT
    '                   También puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    Public Function Actualizar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el PeriodoID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_Periodos WHERE PeriodoID = " & Me.PeriodoID.ToString()
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(sel As String) As String
        ' Actualiza los datos indicados
        ' El parámetro, que es una cadena de selección, indicará el criterio de actualización
        '
        ' En caso de error, devolverá la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_Periodos")
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
        '       Yo compruebo que sea un campo llamado PeriodoID, pero en tu caso puede ser otro
        '       Ese campo, (en mi caso PeriodoID) será el que hay que poner al final junto al WHERE.
        sCommand = "UPDATE IDF_Periodos SET Descripcion = @Descripcion, Desde = @Desde, Hasta = @Hasta, UsuarioCreador = @UsuarioCreador, UsuarioEditor = @UsuarioEditor, FechaCreacion = @FechaCreacion, FechaEdicion = @FechaEdicion  WHERE (PeriodoID = @PeriodoID)"
        da.UpdateCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@PeriodoID", SqlDbType.Int, 0, "PeriodoID")
        da.UpdateCommand.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 50, "Descripcion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@Desde", SqlDbType.DateTime, 0, "Desde")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@Hasta", SqlDbType.DateTime, 0, "Hasta")
        da.UpdateCommand.Parameters.Add("@UsuarioCreador", SqlDbType.NVarChar, 25, "UsuarioCreador")
        da.UpdateCommand.Parameters.Add("@UsuarioEditor", SqlDbType.NVarChar, 25, "UsuarioEditor")
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
            IDF_Periodos2Row(Me, dt.Rows(0))
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
        Dim dt As New DataTable("IDF_Periodos")
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
        '       Yo compruebo que sea un campo llamado PeriodoID, pero en tu caso puede ser otro
        sCommand = "INSERT INTO IDF_Periodos (Descripcion, Desde, Hasta, UsuarioCreador, UsuarioEditor, FechaCreacion, FechaEdicion)  VALUES(@Descripcion, @Desde, @Hasta, @UsuarioCreador, @UsuarioEditor, @FechaCreacion, @FechaEdicion)"
        da.InsertCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@PeriodoID", SqlDbType.Int, 0, "PeriodoID")
        da.InsertCommand.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 50, "Descripcion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@Desde", SqlDbType.DateTime, 0, "Desde")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@Hasta", SqlDbType.DateTime, 0, "Hasta")
        da.InsertCommand.Parameters.Add("@UsuarioCreador", SqlDbType.NVarChar, 25, "UsuarioCreador")
        da.InsertCommand.Parameters.Add("@UsuarioEditor", SqlDbType.NVarChar, 25, "UsuarioEditor")
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
        nuevoIDF_Periodos(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo IDF_Periodos"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el PeriodoID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_Periodos WHERE PeriodoID = " & Me.PeriodoID.ToString()
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_Periodos")
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
        '       Yo compruebo que sea un campo llamado PeriodoID, pero en tu caso puede ser otro
        sCommand = "DELETE FROM IDF_Periodos WHERE (PeriodoID = @p1)"
        da.DeleteCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.DeleteCommand.Parameters.Add("@p1", SqlDbType.Int, 0, "PeriodoID")
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
