'------------------------------------------------------------------------------
' Clase IDF_PeriodosXEmpresa generada automáticamente con CrearClaseSQL
' de la tabla 'IDF_PeriodosXEmpresa' de la base 'Finanzas'
' Fecha: 07/Sep/2015 14:41:49
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
Public Class IDF_PeriodosXEmpresa
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _PeriodoXEmpresaID As System.Int32
    Private _EmpresaCodigo As System.String
    Private _PeriodoID As System.Int32
    Private _EstaAbierto As System.Boolean
    Private _FechaAbierto As System.DateTime
    Private _UsuarioAbierto As System.String
    Private _EstaCerrado As System.Boolean
    Private _FechaCerrado As System.DateTime
    Private _UsuarioCerrado As System.String
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
    Public Property PeriodoXEmpresaID() As System.Int32
        Get
            Return  _PeriodoXEmpresaID
        End Get
        Set(value As System.Int32)
            _PeriodoXEmpresaID = value
        End Set
    End Property
    Public Property EmpresaCodigo() As System.String
        Get
            Return ajustarAncho(_EmpresaCodigo,2)
        End Get
        Set(value As System.String)
            _EmpresaCodigo = value
        End Set
    End Property
    Public Property PeriodoID() As System.Int32
        Get
            Return  _PeriodoID
        End Get
        Set(value As System.Int32)
            _PeriodoID = value
        End Set
    End Property
    Public Property EstaAbierto() As System.Boolean
        Get
            Return  _EstaAbierto
        End Get
        Set(value As System.Boolean)
            _EstaAbierto = value
        End Set
    End Property
    Public Property FechaAbierto() As System.DateTime
        Get
            Return  _FechaAbierto
        End Get
        Set(value As System.DateTime)
            _FechaAbierto = value
        End Set
    End Property
    Public Property UsuarioAbierto() As System.String
        Get
            Return ajustarAncho(_UsuarioAbierto,25)
        End Get
        Set(value As System.String)
            _UsuarioAbierto = value
        End Set
    End Property
    Public Property EstaCerrado() As System.Boolean
        Get
            Return  _EstaCerrado
        End Get
        Set(value As System.Boolean)
            _EstaCerrado = value
        End Set
    End Property
    Public Property FechaCerrado() As System.DateTime
        Get
            Return  _FechaCerrado
        End Get
        Set(value As System.DateTime)
            _FechaCerrado = value
        End Set
    End Property
    Public Property UsuarioCerrado() As System.String
        Get
            Return ajustarAncho(_UsuarioCerrado,25)
        End Get
        Set(value As System.String)
            _UsuarioCerrado = value
        End Set
    End Property
    '
    Public Default Property Item(index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.PeriodoXEmpresaID.ToString()
            ElseIf index = 1 Then
                Return Me.EmpresaCodigo.ToString()
            ElseIf index = 2 Then
                Return Me.PeriodoID.ToString()
            ElseIf index = 3 Then
                Return Me.EstaAbierto.ToString()
            ElseIf index = 4 Then
                Return Me.FechaAbierto.ToString()
            ElseIf index = 5 Then
                Return Me.UsuarioAbierto.ToString()
            ElseIf index = 6 Then
                Return Me.EstaCerrado.ToString()
            ElseIf index = 7 Then
                Return Me.FechaCerrado.ToString()
            ElseIf index = 8 Then
                Return Me.UsuarioCerrado.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = 0 Then
                Try
                    Me.PeriodoXEmpresaID = System.Int32.Parse("0" & value)
                Catch
                    Me.PeriodoXEmpresaID = System.Int32.Parse("0")
                End Try
            ElseIf index = 1 Then
                Me.EmpresaCodigo = value
            ElseIf index = 2 Then
                Try
                    Me.PeriodoID = System.Int32.Parse("0" & value)
                Catch
                    Me.PeriodoID = System.Int32.Parse("0")
                End Try
            ElseIf index = 3 Then
                Try
                    Me.EstaAbierto = System.Boolean.Parse(value)
                Catch
                    Me.EstaAbierto = False
                End Try
            ElseIf index = 4 Then
                Try
                    Me.FechaAbierto = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaAbierto = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaAbierto = System.DateTime.Now
                End Try
            ElseIf index = 5 Then
                Me.UsuarioAbierto = value
            ElseIf index = 6 Then
                Try
                    Me.EstaCerrado = System.Boolean.Parse(value)
                Catch
                    Me.EstaCerrado = False
                End Try
            ElseIf index = 7 Then
                Try
                    Me.FechaCerrado = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaCerrado = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaCerrado = System.DateTime.Now
                End Try
            ElseIf index = 8 Then
                Me.UsuarioCerrado = value
            End If
        End Set
    End Property
    Public Default Property Item(index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde al nombre de la columna)
        Get
            If index = "PeriodoXEmpresaID" Then
                Return Me.PeriodoXEmpresaID.ToString()
            ElseIf index = "EmpresaCodigo" Then
                Return Me.EmpresaCodigo.ToString()
            ElseIf index = "PeriodoID" Then
                Return Me.PeriodoID.ToString()
            ElseIf index = "EstaAbierto" Then
                Return Me.EstaAbierto.ToString()
            ElseIf index = "FechaAbierto" Then
                Return Me.FechaAbierto.ToString()
            ElseIf index = "UsuarioAbierto" Then
                Return Me.UsuarioAbierto.ToString()
            ElseIf index = "EstaCerrado" Then
                Return Me.EstaCerrado.ToString()
            ElseIf index = "FechaCerrado" Then
                Return Me.FechaCerrado.ToString()
            ElseIf index = "UsuarioCerrado" Then
                Return Me.UsuarioCerrado.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = "PeriodoXEmpresaID" Then
                Try
                    Me.PeriodoXEmpresaID = System.Int32.Parse("0" & value)
                Catch
                    Me.PeriodoXEmpresaID = System.Int32.Parse("0")
                End Try
            ElseIf index = "EmpresaCodigo" Then
                Me.EmpresaCodigo = value
            ElseIf index = "PeriodoID" Then
                Try
                    Me.PeriodoID = System.Int32.Parse("0" & value)
                Catch
                    Me.PeriodoID = System.Int32.Parse("0")
                End Try
            ElseIf index = "EstaAbierto" Then
                Try
                    Me.EstaAbierto = System.Boolean.Parse(value)
                Catch
                    Me.EstaAbierto = False
                End Try
            ElseIf index = "FechaAbierto" Then
                Try
                    Me.FechaAbierto = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaAbierto = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaAbierto = System.DateTime.Now
                End Try
            ElseIf index = "UsuarioAbierto" Then
                Me.UsuarioAbierto = value
            ElseIf index = "EstaCerrado" Then
                Try
                    Me.EstaCerrado = System.Boolean.Parse(value)
                Catch
                    Me.EstaCerrado = False
                End Try
            ElseIf index = "FechaCerrado" Then
                Try
                    Me.FechaCerrado = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaCerrado = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaCerrado = System.DateTime.Now
                End Try
            ElseIf index = "UsuarioCerrado" Then
                Me.UsuarioCerrado = value
            End If
        End Set
    End Property
    '
    ' Campos y métodos compartidos (estáticos) para gestionar la base de datos
    '
    ' La cadena de conexión a la base de datos
    Private Shared cadenaConexion As String = "Data Source=amigodb\amigodb; Initial Catalog=Finanzas; user id=rptuser; password=MiTo1380"
    ' La cadena de selección
    Public Shared CadenaSelect As String = "SELECT * FROM IDF_PeriodosXEmpresa"
    '
    Public Sub New()
    End Sub
    Public Sub New(conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto IDF_PeriodosXEmpresa
    Private Shared Function row2IDF_PeriodosXEmpresa(r As DataRow) As IDF_PeriodosXEmpresa
        ' asigna a un objeto IDF_PeriodosXEmpresa los datos del dataRow indicado
        Dim oIDF_PeriodosXEmpresa As New IDF_PeriodosXEmpresa
        '
        oIDF_PeriodosXEmpresa.PeriodoXEmpresaID = System.Int32.Parse("0" & r("PeriodoXEmpresaID").ToString())
        oIDF_PeriodosXEmpresa.EmpresaCodigo = r("EmpresaCodigo").ToString()
        oIDF_PeriodosXEmpresa.PeriodoID = System.Int32.Parse("0" & r("PeriodoID").ToString())
        Try
            oIDF_PeriodosXEmpresa.EstaAbierto = System.Boolean.Parse(r("EstaAbierto").ToString())
        Catch
            oIDF_PeriodosXEmpresa.EstaAbierto = False
        End Try
        Try
            oIDF_PeriodosXEmpresa.FechaAbierto = DateTime.Parse(r("FechaAbierto").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oIDF_PeriodosXEmpresa.FechaAbierto = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oIDF_PeriodosXEmpresa.FechaAbierto = DateTime.Now
        End Try
        oIDF_PeriodosXEmpresa.UsuarioAbierto = r("UsuarioAbierto").ToString()
        Try
            oIDF_PeriodosXEmpresa.EstaCerrado = System.Boolean.Parse(r("EstaCerrado").ToString())
        Catch
            oIDF_PeriodosXEmpresa.EstaCerrado = False
        End Try
        Try
            oIDF_PeriodosXEmpresa.FechaCerrado = DateTime.Parse(r("FechaCerrado").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oIDF_PeriodosXEmpresa.FechaCerrado = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oIDF_PeriodosXEmpresa.FechaCerrado = DateTime.Now
        End Try
        oIDF_PeriodosXEmpresa.UsuarioCerrado = r("UsuarioCerrado").ToString()
        '
        Return oIDF_PeriodosXEmpresa
    End Function
    '
    ' asigna un objeto IDF_PeriodosXEmpresa a la fila indicada
    Private Shared Sub IDF_PeriodosXEmpresa2Row(oIDF_PeriodosXEmpresa As IDF_PeriodosXEmpresa, r As DataRow)
        ' asigna un objeto IDF_PeriodosXEmpresa al dataRow indicado
        ' TODO: Comprueba si esta asignación debe hacerse
        '       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        'r("PeriodoXEmpresaID") = oIDF_PeriodosXEmpresa.PeriodoXEmpresaID
        r("EmpresaCodigo") = oIDF_PeriodosXEmpresa.EmpresaCodigo
        r("PeriodoID") = oIDF_PeriodosXEmpresa.PeriodoID
        r("EstaAbierto") = oIDF_PeriodosXEmpresa.EstaAbierto
        r("FechaAbierto") = oIDF_PeriodosXEmpresa.FechaAbierto
        r("UsuarioAbierto") = oIDF_PeriodosXEmpresa.UsuarioAbierto
        r("EstaCerrado") = oIDF_PeriodosXEmpresa.EstaCerrado
        r("FechaCerrado") = oIDF_PeriodosXEmpresa.FechaCerrado
        r("UsuarioCerrado") = oIDF_PeriodosXEmpresa.UsuarioCerrado
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto IDF_PeriodosXEmpresa
    Private Shared Sub nuevoIDF_PeriodosXEmpresa(dt As DataTable, oIDF_PeriodosXEmpresa As IDF_PeriodosXEmpresa)
        ' Crear un nuevo IDF_PeriodosXEmpresa
        Dim dr As DataRow = dt.NewRow()
        Dim oI As IDF_PeriodosXEmpresa = row2IDF_PeriodosXEmpresa(dr)
        '
        oI.PeriodoXEmpresaID = oIDF_PeriodosXEmpresa.PeriodoXEmpresaID
        oI.EmpresaCodigo = oIDF_PeriodosXEmpresa.EmpresaCodigo
        oI.PeriodoID = oIDF_PeriodosXEmpresa.PeriodoID
        oI.EstaAbierto = oIDF_PeriodosXEmpresa.EstaAbierto
        oI.FechaAbierto = oIDF_PeriodosXEmpresa.FechaAbierto
        oI.UsuarioAbierto = oIDF_PeriodosXEmpresa.UsuarioAbierto
        oI.EstaCerrado = oIDF_PeriodosXEmpresa.EstaCerrado
        oI.FechaCerrado = oIDF_PeriodosXEmpresa.FechaCerrado
        oI.UsuarioCerrado = oIDF_PeriodosXEmpresa.UsuarioCerrado
        '
        IDF_PeriodosXEmpresa2Row(oI, dr)
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
        ' devuelve una tabla con los datos de la tabla IDF_PeriodosXEmpresa
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_PeriodosXEmpresa")
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
    Public Shared Function Buscar(sWhere As String) As IDF_PeriodosXEmpresa
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oIDF_PeriodosXEmpresa As IDF_PeriodosXEmpresa = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_PeriodosXEmpresa")
        Dim sel As String = "SELECT * FROM IDF_PeriodosXEmpresa WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oIDF_PeriodosXEmpresa = row2IDF_PeriodosXEmpresa(dt.Rows(0))
        End If
        Return oIDF_PeriodosXEmpresa
    End Function
    '
    ' Actualizar: Actualiza los datos en la tabla usando la instancia actual
    '             Si la instancia no hace referencia a un registro existente, se creará uno nuevo
    '             Para comprobar si el objeto en memoria coincide con uno existente,
    '             se comprueba si el PeriodoXEmpresaID existe en la tabla.
    '             TODO: Si en lugar de PeriodoXEmpresaID usas otro campo, indicalo en la cadena SELECT
    '                   También puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    Public Function Actualizar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el PeriodoXEmpresaID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_PeriodosXEmpresa WHERE PeriodoXEmpresaID = " & Me.PeriodoXEmpresaID.ToString()
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(sel As String) As String
        ' Actualiza los datos indicados
        ' El parámetro, que es una cadena de selección, indicará el criterio de actualización
        '
        ' En caso de error, devolverá la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_PeriodosXEmpresa")
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
        '       Yo compruebo que sea un campo llamado PeriodoXEmpresaID, pero en tu caso puede ser otro
        '       Ese campo, (en mi caso PeriodoXEmpresaID) será el que hay que poner al final junto al WHERE.
        sCommand = "UPDATE IDF_PeriodosXEmpresa SET EmpresaCodigo = @EmpresaCodigo, PeriodoID = @PeriodoID, EstaAbierto = @EstaAbierto, FechaAbierto = @FechaAbierto, UsuarioAbierto = @UsuarioAbierto, EstaCerrado = @EstaCerrado, FechaCerrado = @FechaCerrado, UsuarioCerrado = @UsuarioCerrado  WHERE (PeriodoXEmpresaID = @PeriodoXEmpresaID)"
        da.UpdateCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@PeriodoXEmpresaID", SqlDbType.Int, 0, "PeriodoXEmpresaID")
        da.UpdateCommand.Parameters.Add("@EmpresaCodigo", SqlDbType.NVarChar, 2, "EmpresaCodigo")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@PeriodoID", SqlDbType.Int, 0, "PeriodoID")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@EstaAbierto", SqlDbType.Bit, 0, "EstaAbierto")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@FechaAbierto", SqlDbType.DateTime, 0, "FechaAbierto")
        da.UpdateCommand.Parameters.Add("@UsuarioAbierto", SqlDbType.NVarChar, 25, "UsuarioAbierto")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@EstaCerrado", SqlDbType.Bit, 0, "EstaCerrado")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@FechaCerrado", SqlDbType.DateTime, 0, "FechaCerrado")
        da.UpdateCommand.Parameters.Add("@UsuarioCerrado", SqlDbType.NVarChar, 25, "UsuarioCerrado")
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
            IDF_PeriodosXEmpresa2Row(Me, dt.Rows(0))
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
        Dim dt As New DataTable("IDF_PeriodosXEmpresa")
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
        '       Yo compruebo que sea un campo llamado PeriodoXEmpresaID, pero en tu caso puede ser otro
        sCommand = "INSERT INTO IDF_PeriodosXEmpresa (EmpresaCodigo, PeriodoID, EstaAbierto, FechaAbierto, UsuarioAbierto, EstaCerrado, FechaCerrado, UsuarioCerrado)  VALUES(@EmpresaCodigo, @PeriodoID, @EstaAbierto, @FechaAbierto, @UsuarioAbierto, @EstaCerrado, @FechaCerrado, @UsuarioCerrado)"
        da.InsertCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@PeriodoXEmpresaID", SqlDbType.Int, 0, "PeriodoXEmpresaID")
        da.InsertCommand.Parameters.Add("@EmpresaCodigo", SqlDbType.NVarChar, 2, "EmpresaCodigo")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@PeriodoID", SqlDbType.Int, 0, "PeriodoID")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@EstaAbierto", SqlDbType.Bit, 0, "EstaAbierto")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@FechaAbierto", SqlDbType.DateTime, 0, "FechaAbierto")
        da.InsertCommand.Parameters.Add("@UsuarioAbierto", SqlDbType.NVarChar, 25, "UsuarioAbierto")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@EstaCerrado", SqlDbType.Bit, 0, "EstaCerrado")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@FechaCerrado", SqlDbType.DateTime, 0, "FechaCerrado")
        da.InsertCommand.Parameters.Add("@UsuarioCerrado", SqlDbType.NVarChar, 25, "UsuarioCerrado")
        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoIDF_PeriodosXEmpresa(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo IDF_PeriodosXEmpresa"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el PeriodoXEmpresaID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_PeriodosXEmpresa WHERE PeriodoXEmpresaID = " & Me.PeriodoXEmpresaID.ToString()
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_PeriodosXEmpresa")
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
        '       Yo compruebo que sea un campo llamado PeriodoXEmpresaID, pero en tu caso puede ser otro
        sCommand = "DELETE FROM IDF_PeriodosXEmpresa WHERE (PeriodoXEmpresaID = @p1)"
        da.DeleteCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.DeleteCommand.Parameters.Add("@p1", SqlDbType.Int, 0, "PeriodoXEmpresaID")
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
