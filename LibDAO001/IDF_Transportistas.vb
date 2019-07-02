'------------------------------------------------------------------------------
' Clase IDF_Transportistas generada automáticamente con CrearClaseSQL
' de la tabla 'IDF_Transportistas' de la base 'Finanzas'
' Fecha: 06/May/2015 08:54:59
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
Public Class IDF_Transportistas
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _TransportistaID As System.Int32
    Private _Descripcion As System.String
    Private _Identificacion As System.String
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
    Public Property TransportistaID() As System.Int32
        Get
            Return  _TransportistaID
        End Get
        Set(value As System.Int32)
            _TransportistaID = value
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
    '
    Public Default Property Item(index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.TransportistaID.ToString()
            ElseIf index = 1 Then
                Return Me.Descripcion.ToString()
            ElseIf index = 2 Then
                Return Me.Identificacion.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = 0 Then
                Try
                    Me.TransportistaID = System.Int32.Parse("0" & value)
                Catch
                    Me.TransportistaID = System.Int32.Parse("0")
                End Try
            ElseIf index = 1 Then
                Me.Descripcion = value
            ElseIf index = 2 Then
                Me.Identificacion = value
            End If
        End Set
    End Property
    Public Default Property Item(index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde al nombre de la columna)
        Get
            If index = "TransportistaID" Then
                Return Me.TransportistaID.ToString()
            ElseIf index = "Descripcion" Then
                Return Me.Descripcion.ToString()
            ElseIf index = "Identificacion" Then
                Return Me.Identificacion.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = "TransportistaID" Then
                Try
                    Me.TransportistaID = System.Int32.Parse("0" & value)
                Catch
                    Me.TransportistaID = System.Int32.Parse("0")
                End Try
            ElseIf index = "Descripcion" Then
                Me.Descripcion = value
            ElseIf index = "Identificacion" Then
                Me.Identificacion = value
            End If
        End Set
    End Property
    '
    ' Campos y métodos compartidos (estáticos) para gestionar la base de datos
    '
    ' La cadena de conexión a la base de datos
    Private Shared cadenaConexion As String = "Data Source=amigodb\amigodb; Initial Catalog=Finanzas; user id=rptuser; password=MiTo1380"
    ' La cadena de selección
    Public Shared CadenaSelect As String = "SELECT * FROM IDF_Transportistas"
    '
    Public Sub New()
    End Sub
    Public Sub New(conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto IDF_Transportistas
    Private Shared Function row2IDF_Transportistas(r As DataRow) As IDF_Transportistas
        ' asigna a un objeto IDF_Transportistas los datos del dataRow indicado
        Dim oIDF_Transportistas As New IDF_Transportistas
        '
        oIDF_Transportistas.TransportistaID = System.Int32.Parse("0" & r("TransportistaID").ToString())
        oIDF_Transportistas.Descripcion = r("Descripcion").ToString()
        oIDF_Transportistas.Identificacion = r("Identificacion").ToString()
        '
        Return oIDF_Transportistas
    End Function
    '
    ' asigna un objeto IDF_Transportistas a la fila indicada
    Private Shared Sub IDF_Transportistas2Row(oIDF_Transportistas As IDF_Transportistas, r As DataRow)
        ' asigna un objeto IDF_Transportistas al dataRow indicado
        ' TODO: Comprueba si esta asignación debe hacerse
        '       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        'r("TransportistaID") = oIDF_Transportistas.TransportistaID
        r("Descripcion") = oIDF_Transportistas.Descripcion
        r("Identificacion") = oIDF_Transportistas.Identificacion
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto IDF_Transportistas
    Private Shared Sub nuevoIDF_Transportistas(dt As DataTable, oIDF_Transportistas As IDF_Transportistas)
        ' Crear un nuevo IDF_Transportistas
        Dim dr As DataRow = dt.NewRow()
        Dim oI As IDF_Transportistas = row2IDF_Transportistas(dr)
        '
        oI.TransportistaID = oIDF_Transportistas.TransportistaID
        oI.Descripcion = oIDF_Transportistas.Descripcion
        oI.Identificacion = oIDF_Transportistas.Identificacion
        '
        IDF_Transportistas2Row(oI, dr)
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
        ' devuelve una tabla con los datos de la tabla IDF_Transportistas
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_Transportistas")
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
    Public Shared Function Buscar(sWhere As String) As IDF_Transportistas
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oIDF_Transportistas As IDF_Transportistas = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_Transportistas")
        Dim sel As String = "SELECT * FROM IDF_Transportistas WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oIDF_Transportistas = row2IDF_Transportistas(dt.Rows(0))
        End If
        Return oIDF_Transportistas
    End Function
    '
    ' Actualizar: Actualiza los datos en la tabla usando la instancia actual
    '             Si la instancia no hace referencia a un registro existente, se creará uno nuevo
    '             Para comprobar si el objeto en memoria coincide con uno existente,
    '             se comprueba si el TransportistaID existe en la tabla.
    '             TODO: Si en lugar de TransportistaID usas otro campo, indicalo en la cadena SELECT
    '                   También puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    Public Function Actualizar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el TransportistaID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_Transportistas WHERE TransportistaID = " & Me.TransportistaID.ToString()
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(sel As String) As String
        ' Actualiza los datos indicados
        ' El parámetro, que es una cadena de selección, indicará el criterio de actualización
        '
        ' En caso de error, devolverá la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_Transportistas")
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
        '       Yo compruebo que sea un campo llamado TransportistaID, pero en tu caso puede ser otro
        '       Ese campo, (en mi caso TransportistaID) será el que hay que poner al final junto al WHERE.
        sCommand = "UPDATE IDF_Transportistas SET Descripcion = @Descripcion, Identificacion = @Identificacion  WHERE (TransportistaID = @TransportistaID)"
        da.UpdateCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@TransportistaID", SqlDbType.Int, 0, "TransportistaID")
        da.UpdateCommand.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 50, "Descripcion")
        da.UpdateCommand.Parameters.Add("@Identificacion", SqlDbType.NVarChar, 25, "Identificacion")
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
            IDF_Transportistas2Row(Me, dt.Rows(0))
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
        Dim dt As New DataTable("IDF_Transportistas")
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
        '       Yo compruebo que sea un campo llamado TransportistaID, pero en tu caso puede ser otro
        sCommand = "INSERT INTO IDF_Transportistas (Descripcion, Identificacion)  VALUES(@Descripcion, @Identificacion)"
        da.InsertCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@TransportistaID", SqlDbType.Int, 0, "TransportistaID")
        da.InsertCommand.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 50, "Descripcion")
        da.InsertCommand.Parameters.Add("@Identificacion", SqlDbType.NVarChar, 25, "Identificacion")
        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoIDF_Transportistas(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo IDF_Transportistas"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el TransportistaID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_Transportistas WHERE TransportistaID = " & Me.TransportistaID.ToString()
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_Transportistas")
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
        '       Yo compruebo que sea un campo llamado TransportistaID, pero en tu caso puede ser otro
        sCommand = "DELETE FROM IDF_Transportistas WHERE (TransportistaID = @p1)"
        da.DeleteCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.DeleteCommand.Parameters.Add("@p1", SqlDbType.Int, 0, "TransportistaID")
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
