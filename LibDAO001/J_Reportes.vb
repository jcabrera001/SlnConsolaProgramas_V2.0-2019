'------------------------------------------------------------------------------
' Clase J_Reportes generada automáticamente con CrearClaseSQL
' de la tabla 'J_Reportes' de la base 'Produccion'
' Fecha: 16/Apr/2015 08:38:10
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
Public Class J_Reportes
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _idReporte As System.Decimal
    Private _nombre As System.String
    Private _descripcion As System.String
    Private _jDataBase As System.String
    Private _jUser As System.String
    Private _pass As System.String
    Private _server As System.String
    Private _reporte As System.String
    Private _solicitar As System.Boolean
    Private _tipoobjeto As System.String
    Private _objeto As System.String
    Private _observaciones As System.String
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
    Public Property idReporte() As System.Decimal
        Get
            Return  _idReporte
        End Get
        Set(value As System.Decimal)
            _idReporte = value
        End Set
    End Property
    Public Property nombre() As System.String
        Get
            Return ajustarAncho(_nombre,80)
        End Get
        Set(value As System.String)
            _nombre = value
        End Set
    End Property
    Public Property descripcion() As System.String
        Get
            Return ajustarAncho(_descripcion,100)
        End Get
        Set(value As System.String)
            _descripcion = value
        End Set
    End Property
    Public Property jDataBase() As System.String
        Get
            Return ajustarAncho(_jDataBase,50)
        End Get
        Set(value As System.String)
            _jDataBase = value
        End Set
    End Property
    Public Property jUser() As System.String
        Get
            Return ajustarAncho(_jUser,50)
        End Get
        Set(value As System.String)
            _jUser = value
        End Set
    End Property
    Public Property pass() As System.String
        Get
            Return ajustarAncho(_pass,50)
        End Get
        Set(value As System.String)
            _pass = value
        End Set
    End Property
    Public Property server() As System.String
        Get
            Return ajustarAncho(_server,50)
        End Get
        Set(value As System.String)
            _server = value
        End Set
    End Property
    Public Property reporte() As System.String
        Get
            ' Seguramente sería mejor sin ajustar el ancho...
            'Return ajustarAncho(_reporte,2147483647)
            Return  _reporte
        End Get
        Set(value As System.String)
            _reporte = value
        End Set
    End Property
    Public Property solicitar() As System.Boolean
        Get
            Return  _solicitar
        End Get
        Set(value As System.Boolean)
            _solicitar = value
        End Set
    End Property
    Public Property tipoobjeto() As System.String
        Get
            Return ajustarAncho(_tipoobjeto,3)
        End Get
        Set(value As System.String)
            _tipoobjeto = value
        End Set
    End Property
    Public Property objeto() As System.String
        Get
            Return ajustarAncho(_objeto,100)
        End Get
        Set(value As System.String)
            _objeto = value
        End Set
    End Property
    Public Property observaciones() As System.String
        Get
            Return ajustarAncho(_observaciones,100)
        End Get
        Set(value As System.String)
            _observaciones = value
        End Set
    End Property
    '
    Public Default Property Item(index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.idReporte.ToString()
            ElseIf index = 1 Then
                Return Me.nombre.ToString()
            ElseIf index = 2 Then
                Return Me.descripcion.ToString()
            ElseIf index = 3 Then
                Return Me.jDataBase.ToString()
            ElseIf index = 4 Then
                Return Me.jUser.ToString()
            ElseIf index = 5 Then
                Return Me.pass.ToString()
            ElseIf index = 6 Then
                Return Me.server.ToString()
            ElseIf index = 7 Then
                Return Me.reporte.ToString()
            ElseIf index = 8 Then
                Return Me.solicitar.ToString()
            ElseIf index = 9 Then
                Return Me.tipoobjeto.ToString()
            ElseIf index = 10 Then
                Return Me.objeto.ToString()
            ElseIf index = 11 Then
                Return Me.observaciones.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = 0 Then
                Try
                    Me.idReporte = System.Decimal.Parse("0" & value)
                Catch
                    Me.idReporte = System.Decimal.Parse("0")
                End Try
            ElseIf index = 1 Then
                Me.nombre = value
            ElseIf index = 2 Then
                Me.descripcion = value
            ElseIf index = 3 Then
                Me.jDataBase = value
            ElseIf index = 4 Then
                Me.jUser = value
            ElseIf index = 5 Then
                Me.pass = value
            ElseIf index = 6 Then
                Me.server = value
            ElseIf index = 7 Then
                Me.reporte = value
            ElseIf index = 8 Then
                Try
                    Me.solicitar = System.Boolean.Parse(value)
                Catch
                    Me.solicitar = False
                End Try
            ElseIf index = 9 Then
                Me.tipoobjeto = value
            ElseIf index = 10 Then
                Me.objeto = value
            ElseIf index = 11 Then
                Me.observaciones = value
            End If
        End Set
    End Property
    Public Default Property Item(index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde al nombre de la columna)
        Get
            If index = "idReporte" Then
                Return Me.idReporte.ToString()
            ElseIf index = "nombre" Then
                Return Me.nombre.ToString()
            ElseIf index = "descripcion" Then
                Return Me.descripcion.ToString()
            ElseIf index = "jDataBase" Then
                Return Me.jDataBase.ToString()
            ElseIf index = "jUser" Then
                Return Me.jUser.ToString()
            ElseIf index = "pass" Then
                Return Me.pass.ToString()
            ElseIf index = "server" Then
                Return Me.server.ToString()
            ElseIf index = "reporte" Then
                Return Me.reporte.ToString()
            ElseIf index = "solicitar" Then
                Return Me.solicitar.ToString()
            ElseIf index = "tipoobjeto" Then
                Return Me.tipoobjeto.ToString()
            ElseIf index = "objeto" Then
                Return Me.objeto.ToString()
            ElseIf index = "observaciones" Then
                Return Me.observaciones.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = "idReporte" Then
                Try
                    Me.idReporte = System.Decimal.Parse("0" & value)
                Catch
                    Me.idReporte = System.Decimal.Parse("0")
                End Try
            ElseIf index = "nombre" Then
                Me.nombre = value
            ElseIf index = "descripcion" Then
                Me.descripcion = value
            ElseIf index = "jDataBase" Then
                Me.jDataBase = value
            ElseIf index = "jUser" Then
                Me.jUser = value
            ElseIf index = "pass" Then
                Me.pass = value
            ElseIf index = "server" Then
                Me.server = value
            ElseIf index = "reporte" Then
                Me.reporte = value
            ElseIf index = "solicitar" Then
                Try
                    Me.solicitar = System.Boolean.Parse(value)
                Catch
                    Me.solicitar = False
                End Try
            ElseIf index = "tipoobjeto" Then
                Me.tipoobjeto = value
            ElseIf index = "objeto" Then
                Me.objeto = value
            ElseIf index = "observaciones" Then
                Me.observaciones = value
            End If
        End Set
    End Property
    '
    ' Campos y métodos compartidos (estáticos) para gestionar la base de datos
    '
    ' La cadena de conexión a la base de datos
    Private Shared cadenaConexion As String = ""
    ' La cadena de selección
    Public Shared CadenaSelect As String = "SELECT * FROM J_Reportes"
    '
    Public Sub New()
    End Sub
    Public Sub New(conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto J_Reportes
    Private Shared Function row2J_Reportes(r As DataRow) As J_Reportes
        ' asigna a un objeto J_Reportes los datos del dataRow indicado
        Dim oJ_Reportes As New J_Reportes
        '
        oJ_Reportes.idReporte = System.Decimal.Parse("0" & r("idReporte").ToString())
        oJ_Reportes.nombre = r("nombre").ToString()
        oJ_Reportes.descripcion = r("descripcion").ToString()
        oJ_Reportes.jDataBase = r("jDataBase").ToString()
        oJ_Reportes.jUser = r("jUser").ToString()
        oJ_Reportes.pass = r("pass").ToString()
        oJ_Reportes.server = r("server").ToString()
        oJ_Reportes.reporte = r("reporte").ToString()
        Try
            oJ_Reportes.solicitar = System.Boolean.Parse(r("solicitar").ToString())
        Catch
            oJ_Reportes.solicitar = False
        End Try
        oJ_Reportes.tipoobjeto = r("tipoobjeto").ToString()
        oJ_Reportes.objeto = r("objeto").ToString()
        oJ_Reportes.observaciones = r("observaciones").ToString()
        '
        Return oJ_Reportes
    End Function
    '
    ' asigna un objeto J_Reportes a la fila indicada
    Private Shared Sub J_Reportes2Row(oJ_Reportes As J_Reportes, r As DataRow)
        ' asigna un objeto J_Reportes al dataRow indicado
        ' TODO: Comprueba si esta asignación debe hacerse
        '       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        'r("idReporte") = oJ_Reportes.idReporte
        r("nombre") = oJ_Reportes.nombre
        r("descripcion") = oJ_Reportes.descripcion
        r("jDataBase") = oJ_Reportes.jDataBase
        r("jUser") = oJ_Reportes.jUser
        r("pass") = oJ_Reportes.pass
        r("server") = oJ_Reportes.server
        r("reporte") = oJ_Reportes.reporte
        r("solicitar") = oJ_Reportes.solicitar
        r("tipoobjeto") = oJ_Reportes.tipoobjeto
        r("objeto") = oJ_Reportes.objeto
        r("observaciones") = oJ_Reportes.observaciones
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto J_Reportes
    Private Shared Sub nuevoJ_Reportes(dt As DataTable, oJ_Reportes As J_Reportes)
        ' Crear un nuevo J_Reportes
        Dim dr As DataRow = dt.NewRow()
        Dim oJ As J_Reportes = row2J_Reportes(dr)
        '
        oJ.idReporte = oJ_Reportes.idReporte
        oJ.nombre = oJ_Reportes.nombre
        oJ.descripcion = oJ_Reportes.descripcion
        oJ.jDataBase = oJ_Reportes.jDataBase
        oJ.jUser = oJ_Reportes.jUser
        oJ.pass = oJ_Reportes.pass
        oJ.server = oJ_Reportes.server
        oJ.reporte = oJ_Reportes.reporte
        oJ.solicitar = oJ_Reportes.solicitar
        oJ.tipoobjeto = oJ_Reportes.tipoobjeto
        oJ.objeto = oJ_Reportes.objeto
        oJ.observaciones = oJ_Reportes.observaciones
        '
        J_Reportes2Row(oJ, dr)
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
        ' devuelve una tabla con los datos de la tabla J_Reportes
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("J_Reportes")
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
    Public Shared Function Buscar(sWhere As String) As J_Reportes
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oJ_Reportes As J_Reportes = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("J_Reportes")
        Dim sel As String = "SELECT * FROM J_Reportes WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oJ_Reportes = row2J_Reportes(dt.Rows(0))
        End If
        Return oJ_Reportes
    End Function
    '
    ' Actualizar: Actualiza los datos en la tabla usando la instancia actual
    '             Si la instancia no hace referencia a un registro existente, se creará uno nuevo
    '             Para comprobar si el objeto en memoria coincide con uno existente,
    '             se comprueba si el idReporte existe en la tabla.
    '             TODO: Si en lugar de idReporte usas otro campo, indicalo en la cadena SELECT
    '                   También puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    Public Function Actualizar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el idReporte que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM J_Reportes WHERE idReporte = " & Me.idReporte.ToString()
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(sel As String) As String
        ' Actualiza los datos indicados
        ' El parámetro, que es una cadena de selección, indicará el criterio de actualización
        '
        ' En caso de error, devolverá la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("J_Reportes")
        '
        cnn = New SqlConnection(cadenaConexion)
        'da = New SqlDataAdapter(CadenaSelect, cnn)
        da = New SqlDataAdapter(sel, cnn)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        '
        '-------------------------------------------
        ' Esta no es la más óptima, pero funcionará
        '-------------------------------------------
        Dim cb As New SqlCommandBuilder(da)
        da.UpdateCommand = cb.GetUpdateCommand()
        '
        '--------------------------------------------------------------------
        ' Esta está más optimizada pero debes comprobar que funciona bien...
        '--------------------------------------------------------------------
        'Dim sCommand As String
        ''
        '' El comando UPDATE
        '' TODO: Comprobar cual es el campo de índice principal (sin duplicados)
        ''       Yo compruebo que sea un campo llamado idReporte, pero en tu caso puede ser otro
        ''       Ese campo, (en mi caso idReporte) será el que hay que poner al final junto al WHERE.
        'sCommand = "UPDATE J_Reportes SET nombre = @nombre, descripcion = @descripcion, jDataBase = @jDataBase, jUser = @jUser, pass = @pass, server = @server, reporte = @reporte, solicitar = @solicitar, tipoobjeto = @tipoobjeto, objeto = @objeto, observaciones = @observaciones  WHERE (idReporte = @idReporte)"
        'da.UpdateCommand = New SqlCommand(sCommand, cnn)
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@idReporte", SqlDbType.Decimal, 0, "idReporte")
        'da.UpdateCommand.Parameters.Add("@nombre", SqlDbType.NVarChar, 80, "nombre")
        'da.UpdateCommand.Parameters.Add("@descripcion", SqlDbType.NVarChar, 100, "descripcion")
        'da.UpdateCommand.Parameters.Add("@jDataBase", SqlDbType.NVarChar, 50, "jDataBase")
        'da.UpdateCommand.Parameters.Add("@jUser", SqlDbType.NVarChar, 50, "jUser")
        'da.UpdateCommand.Parameters.Add("@pass", SqlDbType.NVarChar, 50, "pass")
        'da.UpdateCommand.Parameters.Add("@server", SqlDbType.NVarChar, 50, "server")
        '' TODO: Este campo seguramente es MEMO y el valor debería ser cero en lugar de 2147483647
        ''da.UpdateCommand.Parameters.Add("@reporte", SqlDbType.NText, 2147483647, "reporte")
        'da.UpdateCommand.Parameters.Add("@reporte", SqlDbType.NText, 0, "reporte")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@solicitar", SqlDbType.Bit, 0, "solicitar")
        'da.UpdateCommand.Parameters.Add("@tipoobjeto", SqlDbType.NVarChar, 3, "tipoobjeto")
        'da.UpdateCommand.Parameters.Add("@objeto", SqlDbType.NVarChar, 100, "objeto")
        'da.UpdateCommand.Parameters.Add("@observaciones", SqlDbType.NVarChar, 100, "observaciones")
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
            J_Reportes2Row(Me, dt.Rows(0))
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
        Dim dt As New DataTable("J_Reportes")
        '
        cnn = New SqlConnection(cadenaConexion)
        da = New SqlDataAdapter(CadenaSelect, cnn)
        'da = New SqlDataAdapter(CadenaSelect, cadenaConexion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        '
        '-------------------------------------------
        ' Esta no es la más óptima, pero funcionará
        '-------------------------------------------
        Dim cb As New SqlCommandBuilder(da)
        da.InsertCommand = cb.GetInsertCommand()
        '
        '--------------------------------------------------------------------
        ' Esta está más optimizada pero debes comprobar que funciona bien...
        '--------------------------------------------------------------------
        'Dim sCommand As String
        ''
        '' El comando INSERT
        '' TODO: No incluir el campo de clave primaria incremental
        ''       Yo compruebo que sea un campo llamado idReporte, pero en tu caso puede ser otro
        'sCommand = "INSERT INTO J_Reportes (nombre, descripcion, jDataBase, jUser, pass, server, reporte, solicitar, tipoobjeto, objeto, observaciones)  VALUES(@nombre, @descripcion, @jDataBase, @jUser, @pass, @server, @reporte, @solicitar, @tipoobjeto, @objeto, @observaciones)"
        'da.InsertCommand = New SqlCommand(sCommand, cnn)
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@idReporte", SqlDbType.Decimal, 0, "idReporte")
        'da.InsertCommand.Parameters.Add("@nombre", SqlDbType.NVarChar, 80, "nombre")
        'da.InsertCommand.Parameters.Add("@descripcion", SqlDbType.NVarChar, 100, "descripcion")
        'da.InsertCommand.Parameters.Add("@jDataBase", SqlDbType.NVarChar, 50, "jDataBase")
        'da.InsertCommand.Parameters.Add("@jUser", SqlDbType.NVarChar, 50, "jUser")
        'da.InsertCommand.Parameters.Add("@pass", SqlDbType.NVarChar, 50, "pass")
        'da.InsertCommand.Parameters.Add("@server", SqlDbType.NVarChar, 50, "server")
        '' TODO: Este campo seguramente es MEMO y el valor debería ser cero en lugar de 2147483647
        ''da.InsertCommand.Parameters.Add("@reporte", SqlDbType.NText, 2147483647, "reporte")
        'da.InsertCommand.Parameters.Add("@reporte", SqlDbType.NText, 0, "reporte")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@solicitar", SqlDbType.Bit, 0, "solicitar")
        'da.InsertCommand.Parameters.Add("@tipoobjeto", SqlDbType.NVarChar, 3, "tipoobjeto")
        'da.InsertCommand.Parameters.Add("@objeto", SqlDbType.NVarChar, 100, "objeto")
        'da.InsertCommand.Parameters.Add("@observaciones", SqlDbType.NVarChar, 100, "observaciones")
        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoJ_Reportes(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo J_Reportes"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el idReporte que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM J_Reportes WHERE idReporte = " & Me.idReporte.ToString()
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("J_Reportes")
        '
        cnn = New SqlConnection(cadenaConexion)
        da = New SqlDataAdapter(sel, cnn)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        '
        '-------------------------------------------
        ' Esta no es la más óptima, pero funcionará
        '-------------------------------------------
        Dim cb As New SqlCommandBuilder(da)
        da.DeleteCommand = cb.GetDeleteCommand()
        '
        '
        '--------------------------------------------------------------------
        ' Esta está más optimizada pero debes comprobar que funciona bien...
        '--------------------------------------------------------------------
        'Dim sCommand As String
        ''
        '' El comando DELETE
        '' TODO: Sólo incluir el campo de clave primaria incremental
        ''       Yo compruebo que sea un campo llamado idReporte, pero en tu caso puede ser otro
        'sCommand = "DELETE FROM J_Reportes WHERE (idReporte = @p1)"
        'da.DeleteCommand = New SqlCommand(sCommand, cnn)
        '' TODO: Comprobar el tipo de datos a usar...
        'da.DeleteCommand.Parameters.Add("@p1", SqlDbType.Decimal, 0, "idReporte")
        'da.DeleteCommand.Parameters.Add("@p2", SqlDbType.Int, 0, "")
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
