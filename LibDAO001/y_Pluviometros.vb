'------------------------------------------------------------------------------
' Clase y_Pluviometros generada automáticamente con CrearClaseSQL
' de la tabla 'y_Pluviometros' de la base 'Produccion'
' Fecha: 18/Nov/2015 09:26:32
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
Public Class y_Pluviometros
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _idPluviometro As System.Int32
    Private _idLote As System.Int32
    Private _nombre As System.String
    Private _descripcion As System.String
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
    Public Property idPluviometro() As System.Int32
        Get
            Return  _idPluviometro
        End Get
        Set(value As System.Int32)
            _idPluviometro = value
        End Set
    End Property
    Public Property idLote() As System.Int32
        Get
            Return  _idLote
        End Get
        Set(value As System.Int32)
            _idLote = value
        End Set
    End Property
    Public Property nombre() As System.String
        Get
            ' Seguramente sería mejor sin ajustar el ancho...
            'Return ajustarAncho(_nombre,2147483647)
            Return  _nombre
        End Get
        Set(value As System.String)
            _nombre = value
        End Set
    End Property
    Public Property descripcion() As System.String
        Get
            ' Seguramente sería mejor sin ajustar el ancho...
            'Return ajustarAncho(_descripcion,2147483647)
            Return  _descripcion
        End Get
        Set(value As System.String)
            _descripcion = value
        End Set
    End Property
    '
    Public Default Property Item(index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.idPluviometro.ToString()
            ElseIf index = 1 Then
                Return Me.idLote.ToString()
            ElseIf index = 2 Then
                Return Me.nombre.ToString()
            ElseIf index = 3 Then
                Return Me.descripcion.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = 0 Then
                Try
                    Me.idPluviometro = System.Int32.Parse("0" & value)
                Catch
                    Me.idPluviometro = System.Int32.Parse("0")
                End Try
            ElseIf index = 1 Then
                Try
                    Me.idLote = System.Int32.Parse("0" & value)
                Catch
                    Me.idLote = System.Int32.Parse("0")
                End Try
            ElseIf index = 2 Then
                Me.nombre = value
            ElseIf index = 3 Then
                Me.descripcion = value
            End If
        End Set
    End Property
    Public Default Property Item(index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde al nombre de la columna)
        Get
            If index = "idPluviometro" Then
                Return Me.idPluviometro.ToString()
            ElseIf index = "idLote" Then
                Return Me.idLote.ToString()
            ElseIf index = "nombre" Then
                Return Me.nombre.ToString()
            ElseIf index = "descripcion" Then
                Return Me.descripcion.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = "idPluviometro" Then
                Try
                    Me.idPluviometro = System.Int32.Parse("0" & value)
                Catch
                    Me.idPluviometro = System.Int32.Parse("0")
                End Try
            ElseIf index = "idLote" Then
                Try
                    Me.idLote = System.Int32.Parse("0" & value)
                Catch
                    Me.idLote = System.Int32.Parse("0")
                End Try
            ElseIf index = "nombre" Then
                Me.nombre = value
            ElseIf index = "descripcion" Then
                Me.descripcion = value
            End If
        End Set
    End Property
    '
    ' Campos y métodos compartidos (estáticos) para gestionar la base de datos
    '
    ' La cadena de conexión a la base de datos
    Private Shared cadenaConexion As String = ""
    ' La cadena de selección
    Public Shared CadenaSelect As String = "SELECT * FROM y_Pluviometros"
    '
    Public Sub New()
    End Sub
    Public Sub New(conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto y_Pluviometros
    Private Shared Function row2y_Pluviometros(r As DataRow) As y_Pluviometros
        ' asigna a un objeto y_Pluviometros los datos del dataRow indicado
        Dim oy_Pluviometros As New y_Pluviometros
        '
        oy_Pluviometros.idPluviometro = System.Int32.Parse("0" & r("idPluviometro").ToString())
        oy_Pluviometros.idLote = System.Int32.Parse("0" & r("idLote").ToString())
        oy_Pluviometros.nombre = r("nombre").ToString()
        oy_Pluviometros.descripcion = r("descripcion").ToString()
        '
        Return oy_Pluviometros
    End Function
    '
    ' asigna un objeto y_Pluviometros a la fila indicada
    Private Shared Sub y_Pluviometros2Row(oy_Pluviometros As y_Pluviometros, r As DataRow)
        ' asigna un objeto y_Pluviometros al dataRow indicado
        r("idPluviometro") = oy_Pluviometros.idPluviometro
        r("idLote") = oy_Pluviometros.idLote
        r("nombre") = oy_Pluviometros.nombre
        r("descripcion") = oy_Pluviometros.descripcion
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto y_Pluviometros
    Private Shared Sub nuevoy_Pluviometros(dt As DataTable, oy_Pluviometros As y_Pluviometros)
        ' Crear un nuevo y_Pluviometros
        Dim dr As DataRow = dt.NewRow()
        Dim oy As y_Pluviometros = row2y_Pluviometros(dr)
        '
        oy.idPluviometro = oy_Pluviometros.idPluviometro
        oy.idLote = oy_Pluviometros.idLote
        oy.nombre = oy_Pluviometros.nombre
        oy.descripcion = oy_Pluviometros.descripcion
        '
        y_Pluviometros2Row(oy, dr)
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
        ' devuelve una tabla con los datos de la tabla y_Pluviometros
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("y_Pluviometros")
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
    Public Shared Function Buscar(sWhere As String) As y_Pluviometros
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oy_Pluviometros As y_Pluviometros = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("y_Pluviometros")
        Dim sel As String = "SELECT * FROM y_Pluviometros WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oy_Pluviometros = row2y_Pluviometros(dt.Rows(0))
        End If
        Return oy_Pluviometros
    End Function
    '
    ' Actualizar: Actualiza los datos en la tabla usando la instancia actual
    '             Si la instancia no hace referencia a un registro existente, se creará uno nuevo
    '             Para comprobar si el objeto en memoria coincide con uno existente,
    '             se comprueba si el idPluviometro existe en la tabla.
    '             TODO: Si en lugar de idPluviometro usas otro campo, indicalo en la cadena SELECT
    '                   También puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    Public Function Actualizar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el idPluviometro que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM y_Pluviometros WHERE idPluviometro = " & Me.idPluviometro.ToString()
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(sel As String) As String
        ' Actualiza los datos indicados
        ' El parámetro, que es una cadena de selección, indicará el criterio de actualización
        '
        ' En caso de error, devolverá la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("y_Pluviometros")
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
        '       Yo compruebo que sea un campo llamado idPluviometro, pero en tu caso puede ser otro
        '       Ese campo, (en mi caso idPluviometro) será el que hay que poner al final junto al WHERE.
        sCommand = "UPDATE y_Pluviometros SET idLote = @idLote, nombre = @nombre, descripcion = @descripcion  WHERE (idPluviometro = @idPluviometro)"
        da.UpdateCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@idPluviometro", SqlDbType.Int, 0, "idPluviometro")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@idLote", SqlDbType.Int, 0, "idLote")
        ' TODO: Este campo seguramente es MEMO y el valor debería ser cero en lugar de 2147483647
        'da.UpdateCommand.Parameters.Add("@nombre", SqlDbType.NText, 2147483647, "nombre")
        da.UpdateCommand.Parameters.Add("@nombre", SqlDbType.NText, 0, "nombre")
        ' TODO: Este campo seguramente es MEMO y el valor debería ser cero en lugar de 2147483647
        'da.UpdateCommand.Parameters.Add("@descripcion", SqlDbType.NText, 2147483647, "descripcion")
        da.UpdateCommand.Parameters.Add("@descripcion", SqlDbType.NText, 0, "descripcion")
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
            y_Pluviometros2Row(Me, dt.Rows(0))
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
        Dim dt As New DataTable("y_Pluviometros")
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
        '       Yo compruebo que sea un campo llamado idPluviometro, pero en tu caso puede ser otro
        sCommand = "INSERT INTO y_Pluviometros (idPluviometro, idLote, nombre, descripcion)  VALUES(@idPluviometro, @idLote, @nombre, @descripcion)"
        da.InsertCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@idPluviometro", SqlDbType.Int, 0, "idPluviometro")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@idLote", SqlDbType.Int, 0, "idLote")
        ' TODO: Este campo seguramente es MEMO y el valor debería ser cero en lugar de 2147483647
        'da.InsertCommand.Parameters.Add("@nombre", SqlDbType.NText, 2147483647, "nombre")
        da.InsertCommand.Parameters.Add("@nombre", SqlDbType.NText, 0, "nombre")
        ' TODO: Este campo seguramente es MEMO y el valor debería ser cero en lugar de 2147483647
        'da.InsertCommand.Parameters.Add("@descripcion", SqlDbType.NText, 2147483647, "descripcion")
        da.InsertCommand.Parameters.Add("@descripcion", SqlDbType.NText, 0, "descripcion")
        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoy_Pluviometros(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo y_Pluviometros"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el idPluviometro que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM y_Pluviometros WHERE idPluviometro = " & Me.idPluviometro.ToString()
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("y_Pluviometros")
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
        '       Yo compruebo que sea un campo llamado idPluviometro, pero en tu caso puede ser otro
        sCommand = "DELETE FROM y_Pluviometros WHERE (idPluviometro = @p1)"
        da.DeleteCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.DeleteCommand.Parameters.Add("@p1", SqlDbType.Int, 0, "idPluviometro")
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
