'------------------------------------------------------------------------------
' Clase IDF_CatProductos generada automáticamente con CrearClaseSQL
' de la tabla 'IDF_CatProductos' de la base 'Finanzas'
' Fecha: 17/Jun/2015 10:50:26
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
Public Class IDF_CatProductos
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _CategoriaID As System.Int32
    Private _Descripcion As System.String
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
    Public Property CategoriaID() As System.Int32
        Get
            Return _CategoriaID
        End Get
        Set(value As System.Int32)
            _CategoriaID = value
        End Set
    End Property
    Public Property Descripcion() As System.String
        Get
            Return ajustarAncho(_Descripcion, 100)
        End Get
        Set(value As System.String)
            _Descripcion = value
        End Set
    End Property
    '
    Default Public Property Item(index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.CategoriaID.ToString()
            ElseIf index = 1 Then
                Return Me.Descripcion.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = 0 Then
                Try
                    Me.CategoriaID = System.Int32.Parse("0" & value)
                Catch
                    Me.CategoriaID = System.Int32.Parse("0")
                End Try
            ElseIf index = 1 Then
                Me.Descripcion = value
            End If
        End Set
    End Property
    Default Public Property Item(index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde al nombre de la columna)
        Get
            If index = "CategoriaID" Then
                Return Me.CategoriaID.ToString()
            ElseIf index = "Descripcion" Then
                Return Me.Descripcion.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = "CategoriaID" Then
                Try
                    Me.CategoriaID = System.Int32.Parse("0" & value)
                Catch
                    Me.CategoriaID = System.Int32.Parse("0")
                End Try
            ElseIf index = "Descripcion" Then
                Me.Descripcion = value
            End If
        End Set
    End Property
    '
    ' Campos y métodos compartidos (estáticos) para gestionar la base de datos
    '
    ' La cadena de conexión a la base de datos
    Private Shared cadenaConexion As String = ""
    ' La cadena de selección
    Public Shared CadenaSelect As String = "SELECT * FROM IDF_CatProductos"
    '
    Public Sub New()
    End Sub
    Public Sub New(conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto IDF_CatProductos
    Private Shared Function row2IDF_CatProductos(r As DataRow) As IDF_CatProductos
        ' asigna a un objeto IDF_CatProductos los datos del dataRow indicado
        Dim oIDF_CatProductos As New IDF_CatProductos
        '
        oIDF_CatProductos.CategoriaID = System.Int32.Parse("0" & r("CategoriaID").ToString())
        oIDF_CatProductos.Descripcion = r("Descripcion").ToString()
        '
        Return oIDF_CatProductos
    End Function
    '
    ' asigna un objeto IDF_CatProductos a la fila indicada
    Private Shared Sub IDF_CatProductos2Row(oIDF_CatProductos As IDF_CatProductos, r As DataRow)
        ' asigna un objeto IDF_CatProductos al dataRow indicado
        ' TODO: Comprueba si esta asignación debe hacerse
        '       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        'r("CategoriaID") = oIDF_CatProductos.CategoriaID
        r("Descripcion") = oIDF_CatProductos.Descripcion
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto IDF_CatProductos
    Private Shared Sub nuevoIDF_CatProductos(dt As DataTable, oIDF_CatProductos As IDF_CatProductos)
        ' Crear un nuevo IDF_CatProductos
        Dim dr As DataRow = dt.NewRow()
        Dim oI As IDF_CatProductos = row2IDF_CatProductos(dr)
        '
        oI.CategoriaID = oIDF_CatProductos.CategoriaID
        oI.Descripcion = oIDF_CatProductos.Descripcion
        '
        IDF_CatProductos2Row(oI, dr)
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
        ' devuelve una tabla con los datos de la tabla IDF_CatProductos
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_CatProductos")
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
    Public Shared Function Buscar(sWhere As String) As IDF_CatProductos
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oIDF_CatProductos As IDF_CatProductos = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_CatProductos")
        Dim sel As String = "SELECT * FROM IDF_CatProductos WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oIDF_CatProductos = row2IDF_CatProductos(dt.Rows(0))
        End If
        Return oIDF_CatProductos
    End Function
    '
    ' Actualizar: Actualiza los datos en la tabla usando la instancia actual
    '             Si la instancia no hace referencia a un registro existente, se creará uno nuevo
    '             Para comprobar si el objeto en memoria coincide con uno existente,
    '             se comprueba si el CategoriaID existe en la tabla.
    '             TODO: Si en lugar de CategoriaID usas otro campo, indicalo en la cadena SELECT
    '                   También puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    Public Function Actualizar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el CategoriaID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_CatProductos WHERE CategoriaID = " & Me.CategoriaID.ToString()
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(sel As String) As String
        ' Actualiza los datos indicados
        ' El parámetro, que es una cadena de selección, indicará el criterio de actualización
        '
        ' En caso de error, devolverá la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_CatProductos")
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
        '       Yo compruebo que sea un campo llamado CategoriaID, pero en tu caso puede ser otro
        '       Ese campo, (en mi caso CategoriaID) será el que hay que poner al final junto al WHERE.
        sCommand = "UPDATE IDF_CatProductos SET Descripcion = @Descripcion  WHERE (CategoriaID = @CategoriaID)"
        da.UpdateCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@CategoriaID", SqlDbType.Int, 0, "CategoriaID")
        da.UpdateCommand.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 100, "Descripcion")
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
            IDF_CatProductos2Row(Me, dt.Rows(0))
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
        Dim dt As New DataTable("IDF_CatProductos")
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
        '       Yo compruebo que sea un campo llamado CategoriaID, pero en tu caso puede ser otro
        sCommand = "INSERT INTO IDF_CatProductos (Descripcion)  VALUES(@Descripcion)"
        da.InsertCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@CategoriaID", SqlDbType.Int, 0, "CategoriaID")
        da.InsertCommand.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 100, "Descripcion")
        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoIDF_CatProductos(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo IDF_CatProductos"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el CategoriaID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_CatProductos WHERE CategoriaID = " & Me.CategoriaID.ToString()
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_CatProductos")
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
        '       Yo compruebo que sea un campo llamado CategoriaID, pero en tu caso puede ser otro
        sCommand = "DELETE FROM IDF_CatProductos WHERE (CategoriaID = @p1)"
        da.DeleteCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.DeleteCommand.Parameters.Add("@p1", SqlDbType.Int, 0, "CategoriaID")
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

