'------------------------------------------------------------------------------
' Clase IDF_Monedas generada automáticamente con CrearClaseSQL
' de la tabla 'IDF_Monedas' de la base 'Finanzas'
' Fecha: 24/Apr/2015 14:20:40
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
Public Class IDF_Monedas
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _MonedaCodigo As System.String
    Private _Descripcion As System.String
    Private _esDolar As System.Boolean
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
    Public Property MonedaCodigo() As System.String
        Get
            Return ajustarAncho(_MonedaCodigo,3)
        End Get
        Set(value As System.String)
            _MonedaCodigo = value
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
    Public Property esDolar() As System.Boolean
        Get
            Return  _esDolar
        End Get
        Set(value As System.Boolean)
            _esDolar = value
        End Set
    End Property
    '
    Public Default Property Item(index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.MonedaCodigo.ToString()
            ElseIf index = 1 Then
                Return Me.Descripcion.ToString()
            ElseIf index = 2 Then
                Return Me.esDolar.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = 0 Then
                Me.MonedaCodigo = value
            ElseIf index = 1 Then
                Me.Descripcion = value
            ElseIf index = 2 Then
                Try
                    Me.esDolar = System.Boolean.Parse(value)
                Catch
                    Me.esDolar = False
                End Try
            End If
        End Set
    End Property
    Public Default Property Item(index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde al nombre de la columna)
        Get
            If index = "MonedaCodigo" Then
                Return Me.MonedaCodigo.ToString()
            ElseIf index = "Descripcion" Then
                Return Me.Descripcion.ToString()
            ElseIf index = "esDolar" Then
                Return Me.esDolar.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = "MonedaCodigo" Then
                Me.MonedaCodigo = value
            ElseIf index = "Descripcion" Then
                Me.Descripcion = value
            ElseIf index = "esDolar" Then
                Try
                    Me.esDolar = System.Boolean.Parse(value)
                Catch
                    Me.esDolar = False
                End Try
            End If
        End Set
    End Property
    '
    ' Campos y métodos compartidos (estáticos) para gestionar la base de datos
    '
    ' La cadena de conexión a la base de datos
    Private Shared cadenaConexion As String = ""
    ' La cadena de selección
    Public Shared CadenaSelect As String = "SELECT * FROM IDF_Monedas"
    '
    Public Sub New()
    End Sub
    Public Sub New(conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto IDF_Monedas
    Private Shared Function row2IDF_Monedas(r As DataRow) As IDF_Monedas
        ' asigna a un objeto IDF_Monedas los datos del dataRow indicado
        Dim oIDF_Monedas As New IDF_Monedas
        '
        oIDF_Monedas.MonedaCodigo = r("MonedaCodigo").ToString()
        oIDF_Monedas.Descripcion = r("Descripcion").ToString()
        Try
            oIDF_Monedas.esDolar = System.Boolean.Parse(r("esDolar").ToString())
        Catch
            oIDF_Monedas.esDolar = False
        End Try
        '
        Return oIDF_Monedas
    End Function
    '
    ' asigna un objeto IDF_Monedas a la fila indicada
    Private Shared Sub IDF_Monedas2Row(oIDF_Monedas As IDF_Monedas, r As DataRow)
        ' asigna un objeto IDF_Monedas al dataRow indicado
        r("MonedaCodigo") = oIDF_Monedas.MonedaCodigo
        r("Descripcion") = oIDF_Monedas.Descripcion
        r("esDolar") = oIDF_Monedas.esDolar
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto IDF_Monedas
    Private Shared Sub nuevoIDF_Monedas(dt As DataTable, oIDF_Monedas As IDF_Monedas)
        ' Crear un nuevo IDF_Monedas
        Dim dr As DataRow = dt.NewRow()
        Dim oI As IDF_Monedas = row2IDF_Monedas(dr)
        '
        oI.MonedaCodigo = oIDF_Monedas.MonedaCodigo
        oI.Descripcion = oIDF_Monedas.Descripcion
        oI.esDolar = oIDF_Monedas.esDolar
        '
        IDF_Monedas2Row(oI, dr)
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
        ' devuelve una tabla con los datos de la tabla IDF_Monedas
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_Monedas")
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
    Public Shared Function Buscar(sWhere As String) As IDF_Monedas
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oIDF_Monedas As IDF_Monedas = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_Monedas")
        Dim sel As String = "SELECT * FROM IDF_Monedas WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oIDF_Monedas = row2IDF_Monedas(dt.Rows(0))
        End If
        Return oIDF_Monedas
    End Function
    '
    ' Actualizar: Actualiza los datos en la tabla usando la instancia actual
    '             Si la instancia no hace referencia a un registro existente, se creará uno nuevo
    '             Para comprobar si el objeto en memoria coincide con uno existente,
    '             se comprueba si el MonedaCodigo existe en la tabla.
    '             TODO: Si en lugar de MonedaCodigo usas otro campo, indicalo en la cadena SELECT
    '                   También puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    Public Function Actualizar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el MonedaCodigo que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_Monedas WHERE MonedaCodigo = '" & Me.MonedaCodigo & "'"
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(sel As String) As String
        ' Actualiza los datos indicados
        ' El parámetro, que es una cadena de selección, indicará el criterio de actualización
        '
        ' En caso de error, devolverá la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_Monedas")
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
        ''       Yo compruebo que sea un campo llamado MonedaCodigo, pero en tu caso puede ser otro
        ''       Ese campo, (en mi caso MonedaCodigo) será el que hay que poner al final junto al WHERE.
        'sCommand = "UPDATE IDF_Monedas SET Descripcion = @Descripcion, esDolar = @esDolar  WHERE (MonedaCodigo = @MonedaCodigo)"
        'da.UpdateCommand = New SqlCommand(sCommand, cnn)
        'da.UpdateCommand.Parameters.Add("@MonedaCodigo", SqlDbType.NVarChar, 3, "MonedaCodigo")
        'da.UpdateCommand.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 50, "Descripcion")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@esDolar", SqlDbType.Bit, 0, "esDolar")
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
            IDF_Monedas2Row(Me, dt.Rows(0))
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
        Dim dt As New DataTable("IDF_Monedas")
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
        ''       Yo compruebo que sea un campo llamado MonedaCodigo, pero en tu caso puede ser otro
        'sCommand = "INSERT INTO IDF_Monedas (MonedaCodigo, Descripcion, esDolar)  VALUES(@MonedaCodigo, @Descripcion, @esDolar)"
        'da.InsertCommand = New SqlCommand(sCommand, cnn)
        'da.InsertCommand.Parameters.Add("@MonedaCodigo", SqlDbType.NVarChar, 3, "MonedaCodigo")
        'da.InsertCommand.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 50, "Descripcion")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@esDolar", SqlDbType.Bit, 0, "esDolar")
        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoIDF_Monedas(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo IDF_Monedas"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el MonedaCodigo que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_Monedas WHERE MonedaCodigo = '" & Me.MonedaCodigo & "'"
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_Monedas")
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
        ''       Yo compruebo que sea un campo llamado MonedaCodigo, pero en tu caso puede ser otro
        'sCommand = "DELETE FROM IDF_Monedas WHERE (MonedaCodigo = @p1)"
        'da.DeleteCommand = New SqlCommand(sCommand, cnn)
        'da.DeleteCommand.Parameters.Add("@p1", SqlDbType.NVarChar, 3, "MonedaCodigo")
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
