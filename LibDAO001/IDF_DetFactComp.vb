'------------------------------------------------------------------------------
' Clase IDF_DetFactComp generada automáticamente con CrearClaseSQL
' de la tabla 'IDF_DetFactComp' de la base 'Finanzas'
' Fecha: 26/Feb/2016 13:50:29
'
' ©Guillermo 'guille' Som, 2004-2016
'------------------------------------------------------------------------------
Option Strict On
Option Explicit On
'
Imports System
Imports System.Data
Imports System.Data.SqlClient
'
Public Class IDF_DetFactComp
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _DetFactCompID As System.Int32
    Private _FactCompID As System.Int32
    Private _ImpuestoCodigo As System.String
    Private _MontoGravado As System.Decimal
    Private _Porcentaje As System.Double
    Private _ImpuestoMonto As System.Decimal
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
    Public Property DetFactCompID() As System.Int32
        Get
            Return  _DetFactCompID
        End Get
        Set(value As System.Int32)
            _DetFactCompID = value
        End Set
    End Property
    Public Property FactCompID() As System.Int32
        Get
            Return  _FactCompID
        End Get
        Set(value As System.Int32)
            _FactCompID = value
        End Set
    End Property
    Public Property ImpuestoCodigo() As System.String
        Get
            Return ajustarAncho(_ImpuestoCodigo,30)
        End Get
        Set(value As System.String)
            _ImpuestoCodigo = value
        End Set
    End Property
    Public Property MontoGravado() As System.Decimal
        Get
            Return  _MontoGravado
        End Get
        Set(value As System.Decimal)
            _MontoGravado = value
        End Set
    End Property
    Public Property Porcentaje() As System.Double
        Get
            Return  _Porcentaje
        End Get
        Set(value As System.Double)
            _Porcentaje = value
        End Set
    End Property
    Public Property ImpuestoMonto() As System.Decimal
        Get
            Return  _ImpuestoMonto
        End Get
        Set(value As System.Decimal)
            _ImpuestoMonto = value
        End Set
    End Property
    '
    Public Default Property Item(index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.DetFactCompID.ToString()
            ElseIf index = 1 Then
                Return Me.FactCompID.ToString()
            ElseIf index = 2 Then
                Return Me.ImpuestoCodigo.ToString()
            ElseIf index = 3 Then
                Return Me.MontoGravado.ToString()
            ElseIf index = 4 Then
                Return Me.Porcentaje.ToString()
            ElseIf index = 5 Then
                Return Me.ImpuestoMonto.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = 0 Then
                Try
                    Me.DetFactCompID = System.Int32.Parse("0" & value)
                Catch
                    Me.DetFactCompID = System.Int32.Parse("0")
                End Try
            ElseIf index = 1 Then
                Try
                    Me.FactCompID = System.Int32.Parse("0" & value)
                Catch
                    Me.FactCompID = System.Int32.Parse("0")
                End Try
            ElseIf index = 2 Then
                Me.ImpuestoCodigo = value
            ElseIf index = 3 Then
                Try
                    Me.MontoGravado = System.Decimal.Parse("0" & value)
                Catch
                    Me.MontoGravado = System.Decimal.Parse("0")
                End Try
            ElseIf index = 4 Then
                Try
                    Me.Porcentaje = System.Double.Parse("0" & value)
                Catch
                    Me.Porcentaje = System.Double.Parse("0")
                End Try
            ElseIf index = 5 Then
                Try
                    Me.ImpuestoMonto = System.Decimal.Parse("0" & value)
                Catch
                    Me.ImpuestoMonto = System.Decimal.Parse("0")
                End Try
            End If
        End Set
    End Property
    Public Default Property Item(index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde al nombre de la columna)
        Get
            If index = "DetFactCompID" Then
                Return Me.DetFactCompID.ToString()
            ElseIf index = "FactCompID" Then
                Return Me.FactCompID.ToString()
            ElseIf index = "ImpuestoCodigo" Then
                Return Me.ImpuestoCodigo.ToString()
            ElseIf index = "MontoGravado" Then
                Return Me.MontoGravado.ToString()
            ElseIf index = "Porcentaje" Then
                Return Me.Porcentaje.ToString()
            ElseIf index = "ImpuestoMonto" Then
                Return Me.ImpuestoMonto.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = "DetFactCompID" Then
                Try
                    Me.DetFactCompID = System.Int32.Parse("0" & value)
                Catch
                    Me.DetFactCompID = System.Int32.Parse("0")
                End Try
            ElseIf index = "FactCompID" Then
                Try
                    Me.FactCompID = System.Int32.Parse("0" & value)
                Catch
                    Me.FactCompID = System.Int32.Parse("0")
                End Try
            ElseIf index = "ImpuestoCodigo" Then
                Me.ImpuestoCodigo = value
            ElseIf index = "MontoGravado" Then
                Try
                    Me.MontoGravado = System.Decimal.Parse("0" & value)
                Catch
                    Me.MontoGravado = System.Decimal.Parse("0")
                End Try
            ElseIf index = "Porcentaje" Then
                Try
                    Me.Porcentaje = System.Double.Parse("0" & value)
                Catch
                    Me.Porcentaje = System.Double.Parse("0")
                End Try
            ElseIf index = "ImpuestoMonto" Then
                Try
                    Me.ImpuestoMonto = System.Decimal.Parse("0" & value)
                Catch
                    Me.ImpuestoMonto = System.Decimal.Parse("0")
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
    Public Shared CadenaSelect As String = "SELECT * FROM IDF_DetFactComp"
    '
    Public Sub New()
    End Sub
    Public Sub New(conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto IDF_DetFactComp
    Private Shared Function row2IDF_DetFactComp(r As DataRow) As IDF_DetFactComp
        ' asigna a un objeto IDF_DetFactComp los datos del dataRow indicado
        Dim oIDF_DetFactComp As New IDF_DetFactComp
        '
        oIDF_DetFactComp.DetFactCompID = System.Int32.Parse("0" & r("DetFactCompID").ToString())
        oIDF_DetFactComp.FactCompID = System.Int32.Parse("0" & r("FactCompID").ToString())
        oIDF_DetFactComp.ImpuestoCodigo = r("ImpuestoCodigo").ToString()
        oIDF_DetFactComp.MontoGravado = System.Decimal.Parse("0" & r("MontoGravado").ToString())
        oIDF_DetFactComp.Porcentaje = System.Double.Parse("0" & r("Porcentaje").ToString())
        oIDF_DetFactComp.ImpuestoMonto = System.Decimal.Parse("0" & r("ImpuestoMonto").ToString())
        '
        Return oIDF_DetFactComp
    End Function
    '
    ' asigna un objeto IDF_DetFactComp a la fila indicada
    Private Shared Sub IDF_DetFactComp2Row(oIDF_DetFactComp As IDF_DetFactComp, r As DataRow)
        ' asigna un objeto IDF_DetFactComp al dataRow indicado
        ' TODO: Comprueba si esta asignación debe hacerse
        '       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        'r("DetFactCompID") = oIDF_DetFactComp.DetFactCompID
        r("FactCompID") = oIDF_DetFactComp.FactCompID
        r("ImpuestoCodigo") = oIDF_DetFactComp.ImpuestoCodigo
        r("MontoGravado") = oIDF_DetFactComp.MontoGravado
        r("Porcentaje") = oIDF_DetFactComp.Porcentaje
        r("ImpuestoMonto") = oIDF_DetFactComp.ImpuestoMonto
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto IDF_DetFactComp
    Private Shared Sub nuevoIDF_DetFactComp(dt As DataTable, oIDF_DetFactComp As IDF_DetFactComp)
        ' Crear un nuevo IDF_DetFactComp
        Dim dr As DataRow = dt.NewRow()
        Dim oI As IDF_DetFactComp = row2IDF_DetFactComp(dr)
        '
        oI.DetFactCompID = oIDF_DetFactComp.DetFactCompID
        oI.FactCompID = oIDF_DetFactComp.FactCompID
        oI.ImpuestoCodigo = oIDF_DetFactComp.ImpuestoCodigo
        oI.MontoGravado = oIDF_DetFactComp.MontoGravado
        oI.Porcentaje = oIDF_DetFactComp.Porcentaje
        oI.ImpuestoMonto = oIDF_DetFactComp.ImpuestoMonto
        '
        IDF_DetFactComp2Row(oI, dr)
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
        ' devuelve una tabla con los datos de la tabla IDF_DetFactComp
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_DetFactComp")
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
    Public Shared Function Buscar(sWhere As String) As IDF_DetFactComp
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oIDF_DetFactComp As IDF_DetFactComp = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_DetFactComp")
        Dim sel As String = "SELECT * FROM IDF_DetFactComp WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oIDF_DetFactComp = row2IDF_DetFactComp(dt.Rows(0))
        End If
        Return oIDF_DetFactComp
    End Function
    '
    ' Actualizar: Actualiza los datos en la tabla usando la instancia actual
    '             Si la instancia no hace referencia a un registro existente, se creará uno nuevo
    '             Para comprobar si el objeto en memoria coincide con uno existente,
    '             se comprueba si el DetFactCompID existe en la tabla.
    '             TODO: Si en lugar de DetFactCompID usas otro campo, indicalo en la cadena SELECT
    '                   También puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    Public Function Actualizar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el DetFactCompID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_DetFactComp WHERE DetFactCompID = " & Me.DetFactCompID.ToString()
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(sel As String) As String
        ' Actualiza los datos indicados
        ' El parámetro, que es una cadena de selección, indicará el criterio de actualización
        '
        ' En caso de error, devolverá la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_DetFactComp")
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
        '       Yo compruebo que sea un campo llamado DetFactCompID, pero en tu caso puede ser otro
        '       Ese campo, (en mi caso DetFactCompID) será el que hay que poner al final junto al WHERE.
        sCommand = "UPDATE IDF_DetFactComp SET FactCompID = @FactCompID, ImpuestoCodigo = @ImpuestoCodigo, MontoGravado = @MontoGravado, Porcentaje = @Porcentaje, ImpuestoMonto = @ImpuestoMonto  WHERE (DetFactCompID = @DetFactCompID)"
        da.UpdateCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@DetFactCompID", SqlDbType.Int, 0, "DetFactCompID")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@FactCompID", SqlDbType.Int, 0, "FactCompID")
        da.UpdateCommand.Parameters.Add("@ImpuestoCodigo", SqlDbType.NVarChar, 30, "ImpuestoCodigo")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@MontoGravado", SqlDbType.Decimal, 0, "MontoGravado")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@Porcentaje", SqlDbType.Float, 0, "Porcentaje")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@ImpuestoMonto", SqlDbType.Decimal, 0, "ImpuestoMonto")
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
            IDF_DetFactComp2Row(Me, dt.Rows(0))
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
        Dim dt As New DataTable("IDF_DetFactComp")
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
        '       Yo compruebo que sea un campo llamado DetFactCompID, pero en tu caso puede ser otro
        sCommand = "INSERT INTO IDF_DetFactComp (FactCompID, ImpuestoCodigo, MontoGravado, Porcentaje, ImpuestoMonto)  VALUES(@FactCompID, @ImpuestoCodigo, @MontoGravado, @Porcentaje, @ImpuestoMonto)"
        da.InsertCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@DetFactCompID", SqlDbType.Int, 0, "DetFactCompID")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@FactCompID", SqlDbType.Int, 0, "FactCompID")
        da.InsertCommand.Parameters.Add("@ImpuestoCodigo", SqlDbType.NVarChar, 30, "ImpuestoCodigo")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@MontoGravado", SqlDbType.Decimal, 0, "MontoGravado")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@Porcentaje", SqlDbType.Float, 0, "Porcentaje")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@ImpuestoMonto", SqlDbType.Decimal, 0, "ImpuestoMonto")
        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoIDF_DetFactComp(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo IDF_DetFactComp"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el DetFactCompID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_DetFactComp WHERE DetFactCompID = " & Me.DetFactCompID.ToString()
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_DetFactComp")
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
        '       Yo compruebo que sea un campo llamado DetFactCompID, pero en tu caso puede ser otro
        sCommand = "DELETE FROM IDF_DetFactComp WHERE (DetFactCompID = @p1)"
        da.DeleteCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.DeleteCommand.Parameters.Add("@p1", SqlDbType.Int, 0, "DetFactCompID")
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
