'------------------------------------------------------------------------------
' Clase IDF_Conductores generada automáticamente con CrearClaseSQL
' de la tabla 'IDF_Conductores' de la base 'Finanzas'
' Fecha: 06/May/2015 09:03:39
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
Public Class IDF_Conductores
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _ConductorID As System.Int32
    Private _Descripcion As System.String
    Private _Identificacion As System.String
    Private _Licencia As System.String
    Private _MarcaPred As System.String
    Private _PlacaPred As System.String
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
    Public Property ConductorID() As System.Int32
        Get
            Return  _ConductorID
        End Get
        Set(value As System.Int32)
            _ConductorID = value
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
    Public Property Identificacion() As System.String
        Get
            Return ajustarAncho(_Identificacion,25)
        End Get
        Set(value As System.String)
            _Identificacion = value
        End Set
    End Property
    Public Property Licencia() As System.String
        Get
            Return ajustarAncho(_Licencia,25)
        End Get
        Set(value As System.String)
            _Licencia = value
        End Set
    End Property
    Public Property MarcaPred() As System.String
        Get
            Return ajustarAncho(_MarcaPred,25)
        End Get
        Set(value As System.String)
            _MarcaPred = value
        End Set
    End Property
    Public Property PlacaPred() As System.String
        Get
            Return ajustarAncho(_PlacaPred,12)
        End Get
        Set(value As System.String)
            _PlacaPred = value
        End Set
    End Property
    '
    Public Default Property Item(index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.ConductorID.ToString()
            ElseIf index = 1 Then
                Return Me.Descripcion.ToString()
            ElseIf index = 2 Then
                Return Me.Identificacion.ToString()
            ElseIf index = 3 Then
                Return Me.Licencia.ToString()
            ElseIf index = 4 Then
                Return Me.MarcaPred.ToString()
            ElseIf index = 5 Then
                Return Me.PlacaPred.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = 0 Then
                Try
                    Me.ConductorID = System.Int32.Parse("0" & value)
                Catch
                    Me.ConductorID = System.Int32.Parse("0")
                End Try
            ElseIf index = 1 Then
                Me.Descripcion = value
            ElseIf index = 2 Then
                Me.Identificacion = value
            ElseIf index = 3 Then
                Me.Licencia = value
            ElseIf index = 4 Then
                Me.MarcaPred = value
            ElseIf index = 5 Then
                Me.PlacaPred = value
            End If
        End Set
    End Property
    Public Default Property Item(index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde al nombre de la columna)
        Get
            If index = "ConductorID" Then
                Return Me.ConductorID.ToString()
            ElseIf index = "Descripcion" Then
                Return Me.Descripcion.ToString()
            ElseIf index = "Identificacion" Then
                Return Me.Identificacion.ToString()
            ElseIf index = "Licencia" Then
                Return Me.Licencia.ToString()
            ElseIf index = "MarcaPred" Then
                Return Me.MarcaPred.ToString()
            ElseIf index = "PlacaPred" Then
                Return Me.PlacaPred.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = "ConductorID" Then
                Try
                    Me.ConductorID = System.Int32.Parse("0" & value)
                Catch
                    Me.ConductorID = System.Int32.Parse("0")
                End Try
            ElseIf index = "Descripcion" Then
                Me.Descripcion = value
            ElseIf index = "Identificacion" Then
                Me.Identificacion = value
            ElseIf index = "Licencia" Then
                Me.Licencia = value
            ElseIf index = "MarcaPred" Then
                Me.MarcaPred = value
            ElseIf index = "PlacaPred" Then
                Me.PlacaPred = value
            End If
        End Set
    End Property
    '
    ' Campos y métodos compartidos (estáticos) para gestionar la base de datos
    '
    ' La cadena de conexión a la base de datos
    Private Shared cadenaConexion As String = "Data Source=amigodb\amigodb; Initial Catalog=Finanzas; user id=rptuser; password=MiTo1380"
    ' La cadena de selección
    Public Shared CadenaSelect As String = "SELECT * FROM IDF_Conductores"
    '
    Public Sub New()
    End Sub
    Public Sub New(conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto IDF_Conductores
    Private Shared Function row2IDF_Conductores(r As DataRow) As IDF_Conductores
        ' asigna a un objeto IDF_Conductores los datos del dataRow indicado
        Dim oIDF_Conductores As New IDF_Conductores
        '
        oIDF_Conductores.ConductorID = System.Int32.Parse("0" & r("ConductorID").ToString())
        oIDF_Conductores.Descripcion = r("Descripcion").ToString()
        oIDF_Conductores.Identificacion = r("Identificacion").ToString()
        oIDF_Conductores.Licencia = r("Licencia").ToString()
        oIDF_Conductores.MarcaPred = r("MarcaPred").ToString()
        oIDF_Conductores.PlacaPred = r("PlacaPred").ToString()
        '
        Return oIDF_Conductores
    End Function
    '
    ' asigna un objeto IDF_Conductores a la fila indicada
    Private Shared Sub IDF_Conductores2Row(oIDF_Conductores As IDF_Conductores, r As DataRow)
        ' asigna un objeto IDF_Conductores al dataRow indicado
        ' TODO: Comprueba si esta asignación debe hacerse
        '       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        'r("ConductorID") = oIDF_Conductores.ConductorID
        r("Descripcion") = oIDF_Conductores.Descripcion
        r("Identificacion") = oIDF_Conductores.Identificacion
        r("Licencia") = oIDF_Conductores.Licencia
        r("MarcaPred") = oIDF_Conductores.MarcaPred
        r("PlacaPred") = oIDF_Conductores.PlacaPred
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto IDF_Conductores
    Private Shared Sub nuevoIDF_Conductores(dt As DataTable, oIDF_Conductores As IDF_Conductores)
        ' Crear un nuevo IDF_Conductores
        Dim dr As DataRow = dt.NewRow()
        Dim oI As IDF_Conductores = row2IDF_Conductores(dr)
        '
        oI.ConductorID = oIDF_Conductores.ConductorID
        oI.Descripcion = oIDF_Conductores.Descripcion
        oI.Identificacion = oIDF_Conductores.Identificacion
        oI.Licencia = oIDF_Conductores.Licencia
        oI.MarcaPred = oIDF_Conductores.MarcaPred
        oI.PlacaPred = oIDF_Conductores.PlacaPred
        '
        IDF_Conductores2Row(oI, dr)
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
        ' devuelve una tabla con los datos de la tabla IDF_Conductores
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_Conductores")
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
    Public Shared Function Buscar(sWhere As String) As IDF_Conductores
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oIDF_Conductores As IDF_Conductores = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_Conductores")
        Dim sel As String = "SELECT * FROM IDF_Conductores WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oIDF_Conductores = row2IDF_Conductores(dt.Rows(0))
        End If
        Return oIDF_Conductores
    End Function
    '
    ' Actualizar: Actualiza los datos en la tabla usando la instancia actual
    '             Si la instancia no hace referencia a un registro existente, se creará uno nuevo
    '             Para comprobar si el objeto en memoria coincide con uno existente,
    '             se comprueba si el ConductorID existe en la tabla.
    '             TODO: Si en lugar de ConductorID usas otro campo, indicalo en la cadena SELECT
    '                   También puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    Public Function Actualizar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el ConductorID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_Conductores WHERE ConductorID = " & Me.ConductorID.ToString()
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(sel As String) As String
        ' Actualiza los datos indicados
        ' El parámetro, que es una cadena de selección, indicará el criterio de actualización
        '
        ' En caso de error, devolverá la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_Conductores")
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
        '       Yo compruebo que sea un campo llamado ConductorID, pero en tu caso puede ser otro
        '       Ese campo, (en mi caso ConductorID) será el que hay que poner al final junto al WHERE.
        sCommand = "UPDATE IDF_Conductores SET Descripcion = @Descripcion, Identificacion = @Identificacion, Licencia = @Licencia, MarcaPred = @MarcaPred, PlacaPred = @PlacaPred  WHERE (ConductorID = @ConductorID)"
        da.UpdateCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@ConductorID", SqlDbType.Int, 0, "ConductorID")
        da.UpdateCommand.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 50, "Descripcion")
        da.UpdateCommand.Parameters.Add("@Identificacion", SqlDbType.NVarChar, 25, "Identificacion")
        da.UpdateCommand.Parameters.Add("@Licencia", SqlDbType.NVarChar, 25, "Licencia")
        da.UpdateCommand.Parameters.Add("@MarcaPred", SqlDbType.NVarChar, 25, "MarcaPred")
        da.UpdateCommand.Parameters.Add("@PlacaPred", SqlDbType.NVarChar, 12, "PlacaPred")
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
            IDF_Conductores2Row(Me, dt.Rows(0))
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
        Dim dt As New DataTable("IDF_Conductores")
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
        '       Yo compruebo que sea un campo llamado ConductorID, pero en tu caso puede ser otro
        sCommand = "INSERT INTO IDF_Conductores (Descripcion, Identificacion, Licencia, MarcaPred, PlacaPred)  VALUES(@Descripcion, @Identificacion, @Licencia, @MarcaPred, @PlacaPred)"
        da.InsertCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@ConductorID", SqlDbType.Int, 0, "ConductorID")
        da.InsertCommand.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 50, "Descripcion")
        da.InsertCommand.Parameters.Add("@Identificacion", SqlDbType.NVarChar, 25, "Identificacion")
        da.InsertCommand.Parameters.Add("@Licencia", SqlDbType.NVarChar, 25, "Licencia")
        da.InsertCommand.Parameters.Add("@MarcaPred", SqlDbType.NVarChar, 25, "MarcaPred")
        da.InsertCommand.Parameters.Add("@PlacaPred", SqlDbType.NVarChar, 12, "PlacaPred")
        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoIDF_Conductores(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo IDF_Conductores"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el ConductorID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_Conductores WHERE ConductorID = " & Me.ConductorID.ToString()
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_Conductores")
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
        '       Yo compruebo que sea un campo llamado ConductorID, pero en tu caso puede ser otro
        sCommand = "DELETE FROM IDF_Conductores WHERE (ConductorID = @p1)"
        da.DeleteCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.DeleteCommand.Parameters.Add("@p1", SqlDbType.Int, 0, "ConductorID")
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
