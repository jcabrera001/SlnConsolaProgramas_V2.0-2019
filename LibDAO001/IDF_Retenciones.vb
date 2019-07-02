'------------------------------------------------------------------------------
' Clase IDF_Retenciones generada automáticamente con CrearClaseSQL
' de la tabla 'IDF_Retenciones' de la base 'Finanzas'
' Fecha: 24/Mar/2015 10:08:25
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
Public Class IDF_Retenciones
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _RetencionID As System.Int32
    Private _Descripcion As System.String
    Private _Porcentaje As System.Decimal
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
    Public Property RetencionID() As System.Int32
        Get
            Return  _RetencionID
        End Get
        Set(value As System.Int32)
            _RetencionID = value
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
    Public Property Porcentaje() As System.Decimal
        Get
            Return  _Porcentaje
        End Get
        Set(value As System.Decimal)
            _Porcentaje = value
        End Set
    End Property
    '
    Public Default Property Item(index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.RetencionID.ToString()
            ElseIf index = 1 Then
                Return Me.Descripcion.ToString()
            ElseIf index = 2 Then
                Return Me.Porcentaje.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = 0 Then
                Try
                    Me.RetencionID = System.Int32.Parse("0" & value)
                Catch
                    Me.RetencionID = System.Int32.Parse("0")
                End Try
            ElseIf index = 1 Then
                Me.Descripcion = value
            ElseIf index = 2 Then
                Try
                    Me.Porcentaje = System.Decimal.Parse("0" & value)
                Catch
                    Me.Porcentaje = System.Decimal.Parse("0")
                End Try
            End If
        End Set
    End Property
    Public Default Property Item(index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde al nombre de la columna)
        Get
            If index = "RetencionID" Then
                Return Me.RetencionID.ToString()
            ElseIf index = "Descripcion" Then
                Return Me.Descripcion.ToString()
            ElseIf index = "Porcentaje" Then
                Return Me.Porcentaje.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = "RetencionID" Then
                Try
                    Me.RetencionID = System.Int32.Parse("0" & value)
                Catch
                    Me.RetencionID = System.Int32.Parse("0")
                End Try
            ElseIf index = "Descripcion" Then
                Me.Descripcion = value
            ElseIf index = "Porcentaje" Then
                Try
                    Me.Porcentaje = System.Decimal.Parse("0" & value)
                Catch
                    Me.Porcentaje = System.Decimal.Parse("0")
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
    Public Shared CadenaSelect As String = "SELECT * FROM IDF_Retenciones"
    '
    Public Sub New()
    End Sub
    Public Sub New(conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto IDF_Retenciones
    Private Shared Function row2IDF_Retenciones(r As DataRow) As IDF_Retenciones
        ' asigna a un objeto IDF_Retenciones los datos del dataRow indicado
        Dim oIDF_Retenciones As New IDF_Retenciones
        '
        oIDF_Retenciones.RetencionID = System.Int32.Parse("0" & r("RetencionID").ToString())
        oIDF_Retenciones.Descripcion = r("Descripcion").ToString()
        oIDF_Retenciones.Porcentaje = System.Decimal.Parse("0" & r("Porcentaje").ToString())
        '
        Return oIDF_Retenciones
    End Function
    '
    ' asigna un objeto IDF_Retenciones a la fila indicada
    Private Shared Sub IDF_Retenciones2Row(oIDF_Retenciones As IDF_Retenciones, r As DataRow)
        ' asigna un objeto IDF_Retenciones al dataRow indicado
        ' TODO: Comprueba si esta asignación debe hacerse
        '       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        'r("RetencionID") = oIDF_Retenciones.RetencionID
        r("Descripcion") = oIDF_Retenciones.Descripcion
        r("Porcentaje") = oIDF_Retenciones.Porcentaje
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto IDF_Retenciones
    Private Shared Sub nuevoIDF_Retenciones(dt As DataTable, oIDF_Retenciones As IDF_Retenciones)
        ' Crear un nuevo IDF_Retenciones
        Dim dr As DataRow = dt.NewRow()
        Dim oI As IDF_Retenciones = row2IDF_Retenciones(dr)
        '
        oI.RetencionID = oIDF_Retenciones.RetencionID
        oI.Descripcion = oIDF_Retenciones.Descripcion
        oI.Porcentaje = oIDF_Retenciones.Porcentaje
        '
        IDF_Retenciones2Row(oI, dr)
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
        ' devuelve una tabla con los datos de la tabla IDF_Retenciones
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_Retenciones")
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
    Public Shared Function Buscar(sWhere As String) As IDF_Retenciones
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oIDF_Retenciones As IDF_Retenciones = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_Retenciones")
        Dim sel As String = "SELECT * FROM IDF_Retenciones WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oIDF_Retenciones = row2IDF_Retenciones(dt.Rows(0))
        End If
        Return oIDF_Retenciones
    End Function
    '
    ' Actualizar: Actualiza los datos en la tabla usando la instancia actual
    '             Si la instancia no hace referencia a un registro existente, se creará uno nuevo
    '             Para comprobar si el objeto en memoria coincide con uno existente,
    '             se comprueba si el RetencionID existe en la tabla.
    '             TODO: Si en lugar de RetencionID usas otro campo, indicalo en la cadena SELECT
    '                   También puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    Public Function Actualizar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el RetencionID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_Retenciones WHERE RetencionID = " & Me.RetencionID.ToString()
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(sel As String) As String
        ' Actualiza los datos indicados
        ' El parámetro, que es una cadena de selección, indicará el criterio de actualización
        '
        ' En caso de error, devolverá la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_Retenciones")
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
        ''       Yo compruebo que sea un campo llamado RetencionID, pero en tu caso puede ser otro
        ''       Ese campo, (en mi caso RetencionID) será el que hay que poner al final junto al WHERE.
        'sCommand = "UPDATE IDF_Retenciones SET Descripcion = @Descripcion, Porcentaje = @Porcentaje  WHERE (RetencionID = @RetencionID)"
        'da.UpdateCommand = New SqlCommand(sCommand, cnn)
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@RetencionID", SqlDbType.Int, 0, "RetencionID")
        'da.UpdateCommand.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 50, "Descripcion")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@Porcentaje", SqlDbType.Decimal, 0, "Porcentaje")
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
            IDF_Retenciones2Row(Me, dt.Rows(0))
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
        Dim dt As New DataTable("IDF_Retenciones")
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
        ''       Yo compruebo que sea un campo llamado RetencionID, pero en tu caso puede ser otro
        'sCommand = "INSERT INTO IDF_Retenciones (Descripcion, Porcentaje)  VALUES(@Descripcion, @Porcentaje)"
        'da.InsertCommand = New SqlCommand(sCommand, cnn)
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@RetencionID", SqlDbType.Int, 0, "RetencionID")
        'da.InsertCommand.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 50, "Descripcion")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@Porcentaje", SqlDbType.Decimal, 0, "Porcentaje")
        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoIDF_Retenciones(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo IDF_Retenciones"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el RetencionID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_Retenciones WHERE RetencionID = " & Me.RetencionID.ToString()
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_Retenciones")
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
        ''       Yo compruebo que sea un campo llamado RetencionID, pero en tu caso puede ser otro
        'sCommand = "DELETE FROM IDF_Retenciones WHERE (RetencionID = @p1)"
        'da.DeleteCommand = New SqlCommand(sCommand, cnn)
        '' TODO: Comprobar el tipo de datos a usar...
        'da.DeleteCommand.Parameters.Add("@p1", SqlDbType.Int, 0, "RetencionID")
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
