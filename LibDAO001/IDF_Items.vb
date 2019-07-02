'------------------------------------------------------------------------------
' Clase IDF_Items generada automáticamente con CrearClaseSQL
' de la tabla 'IDF_Items' de la base 'Finanzas'
' Fecha: 10/Apr/2015 11:08:25
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
Public Class IDF_Items
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _ItemID As System.Int32
    Private _Descripcion As System.String
    Private _TiposDoctoID As System.Int32
    Private _ImptoCodigo As System.String
    Private _RetencionID As System.Int32
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
    Public Property ItemID() As System.Int32
        Get
            Return  _ItemID
        End Get
        Set(value As System.Int32)
            _ItemID = value
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
    Public Property TiposDoctoID() As System.Int32
        Get
            Return  _TiposDoctoID
        End Get
        Set(value As System.Int32)
            _TiposDoctoID = value
        End Set
    End Property
    Public Property ImptoCodigo() As System.String
        Get
            Return ajustarAncho(_ImptoCodigo,10)
        End Get
        Set(value As System.String)
            _ImptoCodigo = value
        End Set
    End Property
    Public Property RetencionID() As System.Int32
        Get
            Return  _RetencionID
        End Get
        Set(value As System.Int32)
            _RetencionID = value
        End Set
    End Property
    '
    Public Default Property Item(index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.ItemID.ToString()
            ElseIf index = 1 Then
                Return Me.Descripcion.ToString()
            ElseIf index = 2 Then
                Return Me.TiposDoctoID.ToString()
            ElseIf index = 3 Then
                Return Me.ImptoCodigo.ToString()
            ElseIf index = 4 Then
                Return Me.RetencionID.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = 0 Then
                Try
                    Me.ItemID = System.Int32.Parse("0" & value)
                Catch
                    Me.ItemID = System.Int32.Parse("0")
                End Try
            ElseIf index = 1 Then
                Me.Descripcion = value
            ElseIf index = 2 Then
                Try
                    Me.TiposDoctoID = System.Int32.Parse("0" & value)
                Catch
                    Me.TiposDoctoID = System.Int32.Parse("0")
                End Try
            ElseIf index = 3 Then
                Me.ImptoCodigo = value
            ElseIf index = 4 Then
                Try
                    Me.RetencionID = System.Int32.Parse("0" & value)
                Catch
                    Me.RetencionID = System.Int32.Parse("0")
                End Try
            End If
        End Set
    End Property
    Public Default Property Item(index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde al nombre de la columna)
        Get
            If index = "ItemID" Then
                Return Me.ItemID.ToString()
            ElseIf index = "Descripcion" Then
                Return Me.Descripcion.ToString()
            ElseIf index = "TiposDoctoID" Then
                Return Me.TiposDoctoID.ToString()
            ElseIf index = "ImptoCodigo" Then
                Return Me.ImptoCodigo.ToString()
            ElseIf index = "RetencionID" Then
                Return Me.RetencionID.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = "ItemID" Then
                Try
                    Me.ItemID = System.Int32.Parse("0" & value)
                Catch
                    Me.ItemID = System.Int32.Parse("0")
                End Try
            ElseIf index = "Descripcion" Then
                Me.Descripcion = value
            ElseIf index = "TiposDoctoID" Then
                Try
                    Me.TiposDoctoID = System.Int32.Parse("0" & value)
                Catch
                    Me.TiposDoctoID = System.Int32.Parse("0")
                End Try
            ElseIf index = "ImptoCodigo" Then
                Me.ImptoCodigo = value
            ElseIf index = "RetencionID" Then
                Try
                    Me.RetencionID = System.Int32.Parse("0" & value)
                Catch
                    Me.RetencionID = System.Int32.Parse("0")
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
    Public Shared CadenaSelect As String = "SELECT * FROM IDF_Items"
    '
    Public Sub New()
    End Sub
    Public Sub New(conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto IDF_Items
    Private Shared Function row2IDF_Items(r As DataRow) As IDF_Items
        ' asigna a un objeto IDF_Items los datos del dataRow indicado
        Dim oIDF_Items As New IDF_Items
        '
        oIDF_Items.ItemID = System.Int32.Parse("0" & r("ItemID").ToString())
        oIDF_Items.Descripcion = r("Descripcion").ToString()
        oIDF_Items.TiposDoctoID = System.Int32.Parse("0" & r("TiposDoctoID").ToString())
        oIDF_Items.ImptoCodigo = r("ImptoCodigo").ToString()
        oIDF_Items.RetencionID = System.Int32.Parse("0" & r("RetencionID").ToString())
        '
        Return oIDF_Items
    End Function
    '
    ' asigna un objeto IDF_Items a la fila indicada
    Private Shared Sub IDF_Items2Row(oIDF_Items As IDF_Items, r As DataRow)
        ' asigna un objeto IDF_Items al dataRow indicado
        r("ItemID") = oIDF_Items.ItemID
        r("Descripcion") = oIDF_Items.Descripcion
        r("TiposDoctoID") = oIDF_Items.TiposDoctoID
        r("ImptoCodigo") = oIDF_Items.ImptoCodigo
        r("RetencionID") = oIDF_Items.RetencionID
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto IDF_Items
    Private Shared Sub nuevoIDF_Items(dt As DataTable, oIDF_Items As IDF_Items)
        ' Crear un nuevo IDF_Items
        Dim dr As DataRow = dt.NewRow()
        Dim oI As IDF_Items = row2IDF_Items(dr)
        '
        oI.ItemID = oIDF_Items.ItemID
        oI.Descripcion = oIDF_Items.Descripcion
        oI.TiposDoctoID = oIDF_Items.TiposDoctoID
        oI.ImptoCodigo = oIDF_Items.ImptoCodigo
        oI.RetencionID = oIDF_Items.RetencionID
        '
        IDF_Items2Row(oI, dr)
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
        ' devuelve una tabla con los datos de la tabla IDF_Items
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_Items")
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
    Public Shared Function Buscar(sWhere As String) As IDF_Items
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oIDF_Items As IDF_Items = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_Items")
        Dim sel As String = "SELECT * FROM IDF_Items WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oIDF_Items = row2IDF_Items(dt.Rows(0))
        End If
        Return oIDF_Items
    End Function
    '
    ' Actualizar: Actualiza los datos en la tabla usando la instancia actual
    '             Si la instancia no hace referencia a un registro existente, se creará uno nuevo
    '             Para comprobar si el objeto en memoria coincide con uno existente,
    '             se comprueba si el ItemID existe en la tabla.
    '             TODO: Si en lugar de ItemID usas otro campo, indicalo en la cadena SELECT
    '                   También puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    Public Function Actualizar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el ItemID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_Items WHERE ItemID = " & Me.ItemID.ToString()
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(sel As String) As String
        ' Actualiza los datos indicados
        ' El parámetro, que es una cadena de selección, indicará el criterio de actualización
        '
        ' En caso de error, devolverá la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_Items")
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
        ''       Yo compruebo que sea un campo llamado ItemID, pero en tu caso puede ser otro
        ''       Ese campo, (en mi caso ItemID) será el que hay que poner al final junto al WHERE.
        'sCommand = "UPDATE IDF_Items SET Descripcion = @Descripcion, TiposDoctoID = @TiposDoctoID, ImptoCodigo = @ImptoCodigo, RetencionID = @RetencionID  WHERE (ItemID = @ItemID)"
        'da.UpdateCommand = New SqlCommand(sCommand, cnn)
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@ItemID", SqlDbType.Int, 0, "ItemID")
        'da.UpdateCommand.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 50, "Descripcion")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@TiposDoctoID", SqlDbType.Int, 0, "TiposDoctoID")
        'da.UpdateCommand.Parameters.Add("@ImptoCodigo", SqlDbType.NVarChar, 10, "ImptoCodigo")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@RetencionID", SqlDbType.Int, 0, "RetencionID")
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
            IDF_Items2Row(Me, dt.Rows(0))
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
        Dim dt As New DataTable("IDF_Items")
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
        ''       Yo compruebo que sea un campo llamado ItemID, pero en tu caso puede ser otro
        'sCommand = "INSERT INTO IDF_Items (ItemID, Descripcion, TiposDoctoID, ImptoCodigo, RetencionID)  VALUES(@ItemID, @Descripcion, @TiposDoctoID, @ImptoCodigo, @RetencionID)"
        'da.InsertCommand = New SqlCommand(sCommand, cnn)
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@ItemID", SqlDbType.Int, 0, "ItemID")
        'da.InsertCommand.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 50, "Descripcion")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@TiposDoctoID", SqlDbType.Int, 0, "TiposDoctoID")
        'da.InsertCommand.Parameters.Add("@ImptoCodigo", SqlDbType.NVarChar, 10, "ImptoCodigo")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@RetencionID", SqlDbType.Int, 0, "RetencionID")
        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoIDF_Items(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo IDF_Items"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el ItemID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_Items WHERE ItemID = " & Me.ItemID.ToString()
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_Items")
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
        ''       Yo compruebo que sea un campo llamado ItemID, pero en tu caso puede ser otro
        'sCommand = "DELETE FROM IDF_Items WHERE (ItemID = @p1)"
        'da.DeleteCommand = New SqlCommand(sCommand, cnn)
        '' TODO: Comprobar el tipo de datos a usar...
        'da.DeleteCommand.Parameters.Add("@p1", SqlDbType.Int, 0, "ItemID")
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
