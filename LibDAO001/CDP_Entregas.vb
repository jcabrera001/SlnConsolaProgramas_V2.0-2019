'------------------------------------------------------------------------------
' Clase CDP_Entregas generada automáticamente con CrearClaseSQL
' de la tabla 'CDP_Entregas' de la base 'Finanzas'
' Fecha: 17/Jun/2015 10:56:51
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
Public Class CDP_Entregas
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _EntregaID As System.Int32
    Private _Fecha As System.DateTime
    Private _EntregadoA As System.String
    Private _EntregadoPor As System.String
    Private _AutorizadoPor As System.String
    Private _CantCajas As System.Decimal
    Private _CantFormas As System.Int64
    Private _ExistCajas As System.Decimal
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
    Public Property EntregaID() As System.Int32
        Get
            Return _EntregaID
        End Get
        Set(value As System.Int32)
            _EntregaID = value
        End Set
    End Property
    Public Property Fecha() As System.DateTime
        Get
            Return _Fecha
        End Get
        Set(value As System.DateTime)
            _Fecha = value
        End Set
    End Property
    Public Property EntregadoA() As System.String
        Get
            Return ajustarAncho(_EntregadoA, 50)
        End Get
        Set(value As System.String)
            _EntregadoA = value
        End Set
    End Property
    Public Property EntregadoPor() As System.String
        Get
            Return ajustarAncho(_EntregadoPor, 25)
        End Get
        Set(value As System.String)
            _EntregadoPor = value
        End Set
    End Property
    Public Property AutorizadoPor() As System.String
        Get
            Return ajustarAncho(_AutorizadoPor, 50)
        End Get
        Set(value As System.String)
            _AutorizadoPor = value
        End Set
    End Property
    Public Property CantCajas() As System.Decimal
        Get
            Return _CantCajas
        End Get
        Set(value As System.Decimal)
            _CantCajas = value
        End Set
    End Property
    Public Property CantFormas() As System.Int64
        Get
            Return _CantFormas
        End Get
        Set(value As System.Int64)
            _CantFormas = value
        End Set
    End Property
    Public Property ExistCajas() As System.Decimal
        Get
            Return _ExistCajas
        End Get
        Set(value As System.Decimal)
            _ExistCajas = value
        End Set
    End Property
    '
    Default Public Property Item(index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.EntregaID.ToString()
            ElseIf index = 1 Then
                Return Me.Fecha.ToString()
            ElseIf index = 2 Then
                Return Me.EntregadoA.ToString()
            ElseIf index = 3 Then
                Return Me.EntregadoPor.ToString()
            ElseIf index = 4 Then
                Return Me.AutorizadoPor.ToString()
            ElseIf index = 5 Then
                Return Me.CantCajas.ToString()
            ElseIf index = 6 Then
                Return Me.CantFormas.ToString()
            ElseIf index = 7 Then
                Return Me.ExistCajas.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = 0 Then
                Try
                    Me.EntregaID = System.Int32.Parse("0" & value)
                Catch
                    Me.EntregaID = System.Int32.Parse("0")
                End Try
            ElseIf index = 1 Then
                Try
                    Me.Fecha = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.Fecha = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.Fecha = System.DateTime.Now
                End Try
            ElseIf index = 2 Then
                Me.EntregadoA = value
            ElseIf index = 3 Then
                Me.EntregadoPor = value
            ElseIf index = 4 Then
                Me.AutorizadoPor = value
            ElseIf index = 5 Then
                Try
                    Me.CantCajas = System.Decimal.Parse("0" & value)
                Catch
                    Me.CantCajas = System.Decimal.Parse("0")
                End Try
            ElseIf index = 6 Then
                Try
                    Me.CantFormas = System.Int64.Parse("0" & value)
                Catch
                    Me.CantFormas = System.Int64.Parse("0")
                End Try
            ElseIf index = 7 Then
                Try
                    Me.ExistCajas = System.Decimal.Parse("0" & value)
                Catch
                    Me.ExistCajas = System.Decimal.Parse("0")
                End Try
            End If
        End Set
    End Property
    Default Public Property Item(index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde al nombre de la columna)
        Get
            If index = "EntregaID" Then
                Return Me.EntregaID.ToString()
            ElseIf index = "Fecha" Then
                Return Me.Fecha.ToString()
            ElseIf index = "EntregadoA" Then
                Return Me.EntregadoA.ToString()
            ElseIf index = "EntregadoPor" Then
                Return Me.EntregadoPor.ToString()
            ElseIf index = "AutorizadoPor" Then
                Return Me.AutorizadoPor.ToString()
            ElseIf index = "CantCajas" Then
                Return Me.CantCajas.ToString()
            ElseIf index = "CantFormas" Then
                Return Me.CantFormas.ToString()
            ElseIf index = "ExistCajas" Then
                Return Me.ExistCajas.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = "EntregaID" Then
                Try
                    Me.EntregaID = System.Int32.Parse("0" & value)
                Catch
                    Me.EntregaID = System.Int32.Parse("0")
                End Try
            ElseIf index = "Fecha" Then
                Try
                    Me.Fecha = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.Fecha = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.Fecha = System.DateTime.Now
                End Try
            ElseIf index = "EntregadoA" Then
                Me.EntregadoA = value
            ElseIf index = "EntregadoPor" Then
                Me.EntregadoPor = value
            ElseIf index = "AutorizadoPor" Then
                Me.AutorizadoPor = value
            ElseIf index = "CantCajas" Then
                Try
                    Me.CantCajas = System.Decimal.Parse("0" & value)
                Catch
                    Me.CantCajas = System.Decimal.Parse("0")
                End Try
            ElseIf index = "CantFormas" Then
                Try
                    Me.CantFormas = System.Int64.Parse("0" & value)
                Catch
                    Me.CantFormas = System.Int64.Parse("0")
                End Try
            ElseIf index = "ExistCajas" Then
                Try
                    Me.ExistCajas = System.Decimal.Parse("0" & value)
                Catch
                    Me.ExistCajas = System.Decimal.Parse("0")
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
    Public Shared CadenaSelect As String = "SELECT * FROM CDP_Entregas"
    '
    Public Sub New()
    End Sub
    Public Sub New(conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto CDP_Entregas
    Private Shared Function row2CDP_Entregas(r As DataRow) As CDP_Entregas
        ' asigna a un objeto CDP_Entregas los datos del dataRow indicado
        Dim oCDP_Entregas As New CDP_Entregas
        '
        oCDP_Entregas.EntregaID = System.Int32.Parse("0" & r("EntregaID").ToString())
        Try
            oCDP_Entregas.Fecha = DateTime.Parse(r("Fecha").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oCDP_Entregas.Fecha = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oCDP_Entregas.Fecha = DateTime.Now
        End Try
        oCDP_Entregas.EntregadoA = r("EntregadoA").ToString()
        oCDP_Entregas.EntregadoPor = r("EntregadoPor").ToString()
        oCDP_Entregas.AutorizadoPor = r("AutorizadoPor").ToString()
        oCDP_Entregas.CantCajas = System.Decimal.Parse("0" & r("CantCajas").ToString())
        oCDP_Entregas.CantFormas = System.Int64.Parse("0" & r("CantFormas").ToString())
        oCDP_Entregas.ExistCajas = System.Decimal.Parse("0" & r("ExistCajas").ToString())
        '
        Return oCDP_Entregas
    End Function
    '
    ' asigna un objeto CDP_Entregas a la fila indicada
    Private Shared Sub CDP_Entregas2Row(oCDP_Entregas As CDP_Entregas, r As DataRow)
        ' asigna un objeto CDP_Entregas al dataRow indicado
        ' TODO: Comprueba si esta asignación debe hacerse
        '       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        'r("EntregaID") = oCDP_Entregas.EntregaID
        r("Fecha") = oCDP_Entregas.Fecha
        r("EntregadoA") = oCDP_Entregas.EntregadoA
        r("EntregadoPor") = oCDP_Entregas.EntregadoPor
        r("AutorizadoPor") = oCDP_Entregas.AutorizadoPor
        r("CantCajas") = oCDP_Entregas.CantCajas
        r("CantFormas") = oCDP_Entregas.CantFormas
        r("ExistCajas") = oCDP_Entregas.ExistCajas
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto CDP_Entregas
    Private Shared Sub nuevoCDP_Entregas(dt As DataTable, oCDP_Entregas As CDP_Entregas)
        ' Crear un nuevo CDP_Entregas
        Dim dr As DataRow = dt.NewRow()
        Dim oC As CDP_Entregas = row2CDP_Entregas(dr)
        '
        oC.EntregaID = oCDP_Entregas.EntregaID
        oC.Fecha = oCDP_Entregas.Fecha
        oC.EntregadoA = oCDP_Entregas.EntregadoA
        oC.EntregadoPor = oCDP_Entregas.EntregadoPor
        oC.AutorizadoPor = oCDP_Entregas.AutorizadoPor
        oC.CantCajas = oCDP_Entregas.CantCajas
        oC.CantFormas = oCDP_Entregas.CantFormas
        oC.ExistCajas = oCDP_Entregas.ExistCajas
        '
        CDP_Entregas2Row(oC, dr)
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
        ' devuelve una tabla con los datos de la tabla CDP_Entregas
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("CDP_Entregas")
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
    Public Shared Function Buscar(sWhere As String) As CDP_Entregas
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oCDP_Entregas As CDP_Entregas = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("CDP_Entregas")
        Dim sel As String = "SELECT * FROM CDP_Entregas WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oCDP_Entregas = row2CDP_Entregas(dt.Rows(0))
        End If
        Return oCDP_Entregas
    End Function
    '
    ' Actualizar: Actualiza los datos en la tabla usando la instancia actual
    '             Si la instancia no hace referencia a un registro existente, se creará uno nuevo
    '             Para comprobar si el objeto en memoria coincide con uno existente,
    '             se comprueba si el EntregaID existe en la tabla.
    '             TODO: Si en lugar de EntregaID usas otro campo, indicalo en la cadena SELECT
    '                   También puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    Public Function Actualizar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el EntregaID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM CDP_Entregas WHERE EntregaID = " & Me.EntregaID.ToString()
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(sel As String) As String
        ' Actualiza los datos indicados
        ' El parámetro, que es una cadena de selección, indicará el criterio de actualización
        '
        ' En caso de error, devolverá la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("CDP_Entregas")
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
        '       Yo compruebo que sea un campo llamado EntregaID, pero en tu caso puede ser otro
        '       Ese campo, (en mi caso EntregaID) será el que hay que poner al final junto al WHERE.
        sCommand = "UPDATE CDP_Entregas SET Fecha = @Fecha, EntregadoA = @EntregadoA, EntregadoPor = @EntregadoPor, AutorizadoPor = @AutorizadoPor, CantCajas = @CantCajas, CantFormas = @CantFormas, ExistCajas = @ExistCajas  WHERE (EntregaID = @EntregaID)"
        da.UpdateCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@EntregaID", SqlDbType.Int, 0, "EntregaID")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@Fecha", SqlDbType.DateTime, 0, "Fecha")
        da.UpdateCommand.Parameters.Add("@EntregadoA", SqlDbType.NVarChar, 50, "EntregadoA")
        da.UpdateCommand.Parameters.Add("@EntregadoPor", SqlDbType.NVarChar, 25, "EntregadoPor")
        da.UpdateCommand.Parameters.Add("@AutorizadoPor", SqlDbType.NVarChar, 50, "AutorizadoPor")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@CantCajas", SqlDbType.Decimal, 0, "CantCajas")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@CantFormas", SqlDbType.BigInt, 0, "CantFormas")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@ExistCajas", SqlDbType.Decimal, 0, "ExistCajas")
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
            CDP_Entregas2Row(Me, dt.Rows(0))
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
        Dim dt As New DataTable("CDP_Entregas")
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
        '       Yo compruebo que sea un campo llamado EntregaID, pero en tu caso puede ser otro
        sCommand = "INSERT INTO CDP_Entregas (Fecha, EntregadoA, EntregadoPor, AutorizadoPor, CantCajas, CantFormas, ExistCajas)  VALUES(@Fecha, @EntregadoA, @EntregadoPor, @AutorizadoPor, @CantCajas, @CantFormas, @ExistCajas)"
        da.InsertCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@EntregaID", SqlDbType.Int, 0, "EntregaID")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@Fecha", SqlDbType.DateTime, 0, "Fecha")
        da.InsertCommand.Parameters.Add("@EntregadoA", SqlDbType.NVarChar, 50, "EntregadoA")
        da.InsertCommand.Parameters.Add("@EntregadoPor", SqlDbType.NVarChar, 25, "EntregadoPor")
        da.InsertCommand.Parameters.Add("@AutorizadoPor", SqlDbType.NVarChar, 50, "AutorizadoPor")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@CantCajas", SqlDbType.Decimal, 0, "CantCajas")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@CantFormas", SqlDbType.BigInt, 0, "CantFormas")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@ExistCajas", SqlDbType.Decimal, 0, "ExistCajas")
        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoCDP_Entregas(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo CDP_Entregas"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el EntregaID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM CDP_Entregas WHERE EntregaID = " & Me.EntregaID.ToString()
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("CDP_Entregas")
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
        '       Yo compruebo que sea un campo llamado EntregaID, pero en tu caso puede ser otro
        sCommand = "DELETE FROM CDP_Entregas WHERE (EntregaID = @p1)"
        da.DeleteCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.DeleteCommand.Parameters.Add("@p1", SqlDbType.Int, 0, "EntregaID")
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

