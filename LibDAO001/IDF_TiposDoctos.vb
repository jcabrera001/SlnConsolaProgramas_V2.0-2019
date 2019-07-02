'------------------------------------------------------------------------------
' Clase IDF_TiposDoctos generada automáticamente con CrearClaseSQL
' de la tabla 'IDF_TiposDoctos' de la base 'Finanzas'
' Fecha: 24/Apr/2015 14:29:24
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
Public Class IDF_TiposDoctos
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _TiposDoctoID As System.Int32
    Private _Descripcion As System.String
    Private _esFacturaxVta As System.Boolean
    Private _esCompret As System.Boolean
    Private _esNCredito As System.Boolean
    Private _esNDebito As System.Boolean
    Private _esGuiaRem As System.Boolean
    Private _esFactxCompra As System.Boolean
    Private _MonedaCodigo As System.String
    Private _esFactExp As System.Boolean
    Private _idReporte As System.Int32
    Private _tieneDetalle As System.Boolean
    Private _esBoletaVta As System.Boolean
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
    Public Property TiposDoctoID() As System.Int32
        Get
            Return  _TiposDoctoID
        End Get
        Set(value As System.Int32)
            _TiposDoctoID = value
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
    Public Property esFacturaxVta() As System.Boolean
        Get
            Return  _esFacturaxVta
        End Get
        Set(value As System.Boolean)
            _esFacturaxVta = value
        End Set
    End Property
    Public Property esCompret() As System.Boolean
        Get
            Return  _esCompret
        End Get
        Set(value As System.Boolean)
            _esCompret = value
        End Set
    End Property
    Public Property esNCredito() As System.Boolean
        Get
            Return  _esNCredito
        End Get
        Set(value As System.Boolean)
            _esNCredito = value
        End Set
    End Property
    Public Property esNDebito() As System.Boolean
        Get
            Return  _esNDebito
        End Get
        Set(value As System.Boolean)
            _esNDebito = value
        End Set
    End Property
    Public Property esGuiaRem() As System.Boolean
        Get
            Return  _esGuiaRem
        End Get
        Set(value As System.Boolean)
            _esGuiaRem = value
        End Set
    End Property
    Public Property esFactxCompra() As System.Boolean
        Get
            Return  _esFactxCompra
        End Get
        Set(value As System.Boolean)
            _esFactxCompra = value
        End Set
    End Property
    Public Property MonedaCodigo() As System.String
        Get
            Return ajustarAncho(_MonedaCodigo,3)
        End Get
        Set(value As System.String)
            _MonedaCodigo = value
        End Set
    End Property
    Public Property esFactExp() As System.Boolean
        Get
            Return  _esFactExp
        End Get
        Set(value As System.Boolean)
            _esFactExp = value
        End Set
    End Property
    Public Property idReporte() As System.Int32
        Get
            Return  _idReporte
        End Get
        Set(value As System.Int32)
            _idReporte = value
        End Set
    End Property
    Public Property tieneDetalle() As System.Boolean
        Get
            Return  _tieneDetalle
        End Get
        Set(value As System.Boolean)
            _tieneDetalle = value
        End Set
    End Property
    Public Property esBoletaVta() As System.Boolean
        Get
            Return  _esBoletaVta
        End Get
        Set(value As System.Boolean)
            _esBoletaVta = value
        End Set
    End Property
    '
    Public Default Property Item(index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.TiposDoctoID.ToString()
            ElseIf index = 1 Then
                Return Me.Descripcion.ToString()
            ElseIf index = 2 Then
                Return Me.esFacturaxVta.ToString()
            ElseIf index = 3 Then
                Return Me.esCompret.ToString()
            ElseIf index = 4 Then
                Return Me.esNCredito.ToString()
            ElseIf index = 5 Then
                Return Me.esNDebito.ToString()
            ElseIf index = 6 Then
                Return Me.esGuiaRem.ToString()
            ElseIf index = 7 Then
                Return Me.esFactxCompra.ToString()
            ElseIf index = 8 Then
                Return Me.MonedaCodigo.ToString()
            ElseIf index = 9 Then
                Return Me.esFactExp.ToString()
            ElseIf index = 10 Then
                Return Me.idReporte.ToString()
            ElseIf index = 11 Then
                Return Me.tieneDetalle.ToString()
            ElseIf index = 12 Then
                Return Me.esBoletaVta.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = 0 Then
                Try
                    Me.TiposDoctoID = System.Int32.Parse("0" & value)
                Catch
                    Me.TiposDoctoID = System.Int32.Parse("0")
                End Try
            ElseIf index = 1 Then
                Me.Descripcion = value
            ElseIf index = 2 Then
                Try
                    Me.esFacturaxVta = System.Boolean.Parse(value)
                Catch
                    Me.esFacturaxVta = False
                End Try
            ElseIf index = 3 Then
                Try
                    Me.esCompret = System.Boolean.Parse(value)
                Catch
                    Me.esCompret = False
                End Try
            ElseIf index = 4 Then
                Try
                    Me.esNCredito = System.Boolean.Parse(value)
                Catch
                    Me.esNCredito = False
                End Try
            ElseIf index = 5 Then
                Try
                    Me.esNDebito = System.Boolean.Parse(value)
                Catch
                    Me.esNDebito = False
                End Try
            ElseIf index = 6 Then
                Try
                    Me.esGuiaRem = System.Boolean.Parse(value)
                Catch
                    Me.esGuiaRem = False
                End Try
            ElseIf index = 7 Then
                Try
                    Me.esFactxCompra = System.Boolean.Parse(value)
                Catch
                    Me.esFactxCompra = False
                End Try
            ElseIf index = 8 Then
                Me.MonedaCodigo = value
            ElseIf index = 9 Then
                Try
                    Me.esFactExp = System.Boolean.Parse(value)
                Catch
                    Me.esFactExp = False
                End Try
            ElseIf index = 10 Then
                Try
                    Me.idReporte = System.Int32.Parse("0" & value)
                Catch
                    Me.idReporte = System.Int32.Parse("0")
                End Try
            ElseIf index = 11 Then
                Try
                    Me.tieneDetalle = System.Boolean.Parse(value)
                Catch
                    Me.tieneDetalle = False
                End Try
            ElseIf index = 12 Then
                Try
                    Me.esBoletaVta = System.Boolean.Parse(value)
                Catch
                    Me.esBoletaVta = False
                End Try
            End If
        End Set
    End Property
    Public Default Property Item(index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde al nombre de la columna)
        Get
            If index = "TiposDoctoID" Then
                Return Me.TiposDoctoID.ToString()
            ElseIf index = "Descripcion" Then
                Return Me.Descripcion.ToString()
            ElseIf index = "esFacturaxVta" Then
                Return Me.esFacturaxVta.ToString()
            ElseIf index = "esCompret" Then
                Return Me.esCompret.ToString()
            ElseIf index = "esNCredito" Then
                Return Me.esNCredito.ToString()
            ElseIf index = "esNDebito" Then
                Return Me.esNDebito.ToString()
            ElseIf index = "esGuiaRem" Then
                Return Me.esGuiaRem.ToString()
            ElseIf index = "esFactxCompra" Then
                Return Me.esFactxCompra.ToString()
            ElseIf index = "MonedaCodigo" Then
                Return Me.MonedaCodigo.ToString()
            ElseIf index = "esFactExp" Then
                Return Me.esFactExp.ToString()
            ElseIf index = "idReporte" Then
                Return Me.idReporte.ToString()
            ElseIf index = "tieneDetalle" Then
                Return Me.tieneDetalle.ToString()
            ElseIf index = "esBoletaVta" Then
                Return Me.esBoletaVta.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = "TiposDoctoID" Then
                Try
                    Me.TiposDoctoID = System.Int32.Parse("0" & value)
                Catch
                    Me.TiposDoctoID = System.Int32.Parse("0")
                End Try
            ElseIf index = "Descripcion" Then
                Me.Descripcion = value
            ElseIf index = "esFacturaxVta" Then
                Try
                    Me.esFacturaxVta = System.Boolean.Parse(value)
                Catch
                    Me.esFacturaxVta = False
                End Try
            ElseIf index = "esCompret" Then
                Try
                    Me.esCompret = System.Boolean.Parse(value)
                Catch
                    Me.esCompret = False
                End Try
            ElseIf index = "esNCredito" Then
                Try
                    Me.esNCredito = System.Boolean.Parse(value)
                Catch
                    Me.esNCredito = False
                End Try
            ElseIf index = "esNDebito" Then
                Try
                    Me.esNDebito = System.Boolean.Parse(value)
                Catch
                    Me.esNDebito = False
                End Try
            ElseIf index = "esGuiaRem" Then
                Try
                    Me.esGuiaRem = System.Boolean.Parse(value)
                Catch
                    Me.esGuiaRem = False
                End Try
            ElseIf index = "esFactxCompra" Then
                Try
                    Me.esFactxCompra = System.Boolean.Parse(value)
                Catch
                    Me.esFactxCompra = False
                End Try
            ElseIf index = "MonedaCodigo" Then
                Me.MonedaCodigo = value
            ElseIf index = "esFactExp" Then
                Try
                    Me.esFactExp = System.Boolean.Parse(value)
                Catch
                    Me.esFactExp = False
                End Try
            ElseIf index = "idReporte" Then
                Try
                    Me.idReporte = System.Int32.Parse("0" & value)
                Catch
                    Me.idReporte = System.Int32.Parse("0")
                End Try
            ElseIf index = "tieneDetalle" Then
                Try
                    Me.tieneDetalle = System.Boolean.Parse(value)
                Catch
                    Me.tieneDetalle = False
                End Try
            ElseIf index = "esBoletaVta" Then
                Try
                    Me.esBoletaVta = System.Boolean.Parse(value)
                Catch
                    Me.esBoletaVta = False
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
    Public Shared CadenaSelect As String = "SELECT * FROM IDF_TiposDoctos"
    '
    Public Sub New()
    End Sub
    Public Sub New(conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto IDF_TiposDoctos
    Private Shared Function row2IDF_TiposDoctos(r As DataRow) As IDF_TiposDoctos
        ' asigna a un objeto IDF_TiposDoctos los datos del dataRow indicado
        Dim oIDF_TiposDoctos As New IDF_TiposDoctos
        '
        oIDF_TiposDoctos.TiposDoctoID = System.Int32.Parse("0" & r("TiposDoctoID").ToString())
        oIDF_TiposDoctos.Descripcion = r("Descripcion").ToString()
        Try
            oIDF_TiposDoctos.esFacturaxVta = System.Boolean.Parse(r("esFacturaxVta").ToString())
        Catch
            oIDF_TiposDoctos.esFacturaxVta = False
        End Try
        Try
            oIDF_TiposDoctos.esCompret = System.Boolean.Parse(r("esCompret").ToString())
        Catch
            oIDF_TiposDoctos.esCompret = False
        End Try
        Try
            oIDF_TiposDoctos.esNCredito = System.Boolean.Parse(r("esNCredito").ToString())
        Catch
            oIDF_TiposDoctos.esNCredito = False
        End Try
        Try
            oIDF_TiposDoctos.esNDebito = System.Boolean.Parse(r("esNDebito").ToString())
        Catch
            oIDF_TiposDoctos.esNDebito = False
        End Try
        Try
            oIDF_TiposDoctos.esGuiaRem = System.Boolean.Parse(r("esGuiaRem").ToString())
        Catch
            oIDF_TiposDoctos.esGuiaRem = False
        End Try
        Try
            oIDF_TiposDoctos.esFactxCompra = System.Boolean.Parse(r("esFactxCompra").ToString())
        Catch
            oIDF_TiposDoctos.esFactxCompra = False
        End Try
        oIDF_TiposDoctos.MonedaCodigo = r("MonedaCodigo").ToString()
        Try
            oIDF_TiposDoctos.esFactExp = System.Boolean.Parse(r("esFactExp").ToString())
        Catch
            oIDF_TiposDoctos.esFactExp = False
        End Try
        oIDF_TiposDoctos.idReporte = System.Int32.Parse("0" & r("idReporte").ToString())
        Try
            oIDF_TiposDoctos.tieneDetalle = System.Boolean.Parse(r("tieneDetalle").ToString())
        Catch
            oIDF_TiposDoctos.tieneDetalle = False
        End Try
        Try
            oIDF_TiposDoctos.esBoletaVta = System.Boolean.Parse(r("esBoletaVta").ToString())
        Catch
            oIDF_TiposDoctos.esBoletaVta = False
        End Try
        '
        Return oIDF_TiposDoctos
    End Function
    '
    ' asigna un objeto IDF_TiposDoctos a la fila indicada
    Private Shared Sub IDF_TiposDoctos2Row(oIDF_TiposDoctos As IDF_TiposDoctos, r As DataRow)
        ' asigna un objeto IDF_TiposDoctos al dataRow indicado
        r("TiposDoctoID") = oIDF_TiposDoctos.TiposDoctoID
        r("Descripcion") = oIDF_TiposDoctos.Descripcion
        r("esFacturaxVta") = oIDF_TiposDoctos.esFacturaxVta
        r("esCompret") = oIDF_TiposDoctos.esCompret
        r("esNCredito") = oIDF_TiposDoctos.esNCredito
        r("esNDebito") = oIDF_TiposDoctos.esNDebito
        r("esGuiaRem") = oIDF_TiposDoctos.esGuiaRem
        r("esFactxCompra") = oIDF_TiposDoctos.esFactxCompra
        r("MonedaCodigo") = oIDF_TiposDoctos.MonedaCodigo
        r("esFactExp") = oIDF_TiposDoctos.esFactExp
        r("idReporte") = oIDF_TiposDoctos.idReporte
        r("tieneDetalle") = oIDF_TiposDoctos.tieneDetalle
        r("esBoletaVta") = oIDF_TiposDoctos.esBoletaVta
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto IDF_TiposDoctos
    Private Shared Sub nuevoIDF_TiposDoctos(dt As DataTable, oIDF_TiposDoctos As IDF_TiposDoctos)
        ' Crear un nuevo IDF_TiposDoctos
        Dim dr As DataRow = dt.NewRow()
        Dim oI As IDF_TiposDoctos = row2IDF_TiposDoctos(dr)
        '
        oI.TiposDoctoID = oIDF_TiposDoctos.TiposDoctoID
        oI.Descripcion = oIDF_TiposDoctos.Descripcion
        oI.esFacturaxVta = oIDF_TiposDoctos.esFacturaxVta
        oI.esCompret = oIDF_TiposDoctos.esCompret
        oI.esNCredito = oIDF_TiposDoctos.esNCredito
        oI.esNDebito = oIDF_TiposDoctos.esNDebito
        oI.esGuiaRem = oIDF_TiposDoctos.esGuiaRem
        oI.esFactxCompra = oIDF_TiposDoctos.esFactxCompra
        oI.MonedaCodigo = oIDF_TiposDoctos.MonedaCodigo
        oI.esFactExp = oIDF_TiposDoctos.esFactExp
        oI.idReporte = oIDF_TiposDoctos.idReporte
        oI.tieneDetalle = oIDF_TiposDoctos.tieneDetalle
        oI.esBoletaVta = oIDF_TiposDoctos.esBoletaVta
        '
        IDF_TiposDoctos2Row(oI, dr)
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
        ' devuelve una tabla con los datos de la tabla IDF_TiposDoctos
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_TiposDoctos")
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
    Public Shared Function Buscar(sWhere As String) As IDF_TiposDoctos
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oIDF_TiposDoctos As IDF_TiposDoctos = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_TiposDoctos")
        Dim sel As String = "SELECT * FROM IDF_TiposDoctos WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oIDF_TiposDoctos = row2IDF_TiposDoctos(dt.Rows(0))
        End If
        Return oIDF_TiposDoctos
    End Function
    '
    ' Actualizar: Actualiza los datos en la tabla usando la instancia actual
    '             Si la instancia no hace referencia a un registro existente, se creará uno nuevo
    '             Para comprobar si el objeto en memoria coincide con uno existente,
    '             se comprueba si el TiposDoctoID existe en la tabla.
    '             TODO: Si en lugar de TiposDoctoID usas otro campo, indicalo en la cadena SELECT
    '                   También puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    Public Function Actualizar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el TiposDoctoID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_TiposDoctos WHERE TiposDoctoID = " & Me.TiposDoctoID.ToString()
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(sel As String) As String
        ' Actualiza los datos indicados
        ' El parámetro, que es una cadena de selección, indicará el criterio de actualización
        '
        ' En caso de error, devolverá la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_TiposDoctos")
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
        ''       Yo compruebo que sea un campo llamado TiposDoctoID, pero en tu caso puede ser otro
        ''       Ese campo, (en mi caso TiposDoctoID) será el que hay que poner al final junto al WHERE.
        'sCommand = "UPDATE IDF_TiposDoctos SET Descripcion = @Descripcion, esFacturaxVta = @esFacturaxVta, esCompret = @esCompret, esNCredito = @esNCredito, esNDebito = @esNDebito, esGuiaRem = @esGuiaRem, esFactxCompra = @esFactxCompra, MonedaCodigo = @MonedaCodigo, esFactExp = @esFactExp, idReporte = @idReporte, tieneDetalle = @tieneDetalle, esBoletaVta = @esBoletaVta  WHERE (TiposDoctoID = @TiposDoctoID)"
        'da.UpdateCommand = New SqlCommand(sCommand, cnn)
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@TiposDoctoID", SqlDbType.Int, 0, "TiposDoctoID")
        'da.UpdateCommand.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 50, "Descripcion")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@esFacturaxVta", SqlDbType.Bit, 0, "esFacturaxVta")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@esCompret", SqlDbType.Bit, 0, "esCompret")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@esNCredito", SqlDbType.Bit, 0, "esNCredito")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@esNDebito", SqlDbType.Bit, 0, "esNDebito")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@esGuiaRem", SqlDbType.Bit, 0, "esGuiaRem")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@esFactxCompra", SqlDbType.Bit, 0, "esFactxCompra")
        'da.UpdateCommand.Parameters.Add("@MonedaCodigo", SqlDbType.NVarChar, 3, "MonedaCodigo")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@esFactExp", SqlDbType.Bit, 0, "esFactExp")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@idReporte", SqlDbType.Int, 0, "idReporte")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@tieneDetalle", SqlDbType.Bit, 0, "tieneDetalle")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@esBoletaVta", SqlDbType.Bit, 0, "esBoletaVta")
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
            IDF_TiposDoctos2Row(Me, dt.Rows(0))
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
        Dim dt As New DataTable("IDF_TiposDoctos")
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
        ''       Yo compruebo que sea un campo llamado TiposDoctoID, pero en tu caso puede ser otro
        'sCommand = "INSERT INTO IDF_TiposDoctos (TiposDoctoID, Descripcion, esFacturaxVta, esCompret, esNCredito, esNDebito, esGuiaRem, esFactxCompra, MonedaCodigo, esFactExp, idReporte, tieneDetalle, esBoletaVta)  VALUES(@TiposDoctoID, @Descripcion, @esFacturaxVta, @esCompret, @esNCredito, @esNDebito, @esGuiaRem, @esFactxCompra, @MonedaCodigo, @esFactExp, @idReporte, @tieneDetalle, @esBoletaVta)"
        'da.InsertCommand = New SqlCommand(sCommand, cnn)
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@TiposDoctoID", SqlDbType.Int, 0, "TiposDoctoID")
        'da.InsertCommand.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 50, "Descripcion")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@esFacturaxVta", SqlDbType.Bit, 0, "esFacturaxVta")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@esCompret", SqlDbType.Bit, 0, "esCompret")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@esNCredito", SqlDbType.Bit, 0, "esNCredito")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@esNDebito", SqlDbType.Bit, 0, "esNDebito")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@esGuiaRem", SqlDbType.Bit, 0, "esGuiaRem")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@esFactxCompra", SqlDbType.Bit, 0, "esFactxCompra")
        'da.InsertCommand.Parameters.Add("@MonedaCodigo", SqlDbType.NVarChar, 3, "MonedaCodigo")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@esFactExp", SqlDbType.Bit, 0, "esFactExp")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@idReporte", SqlDbType.Int, 0, "idReporte")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@tieneDetalle", SqlDbType.Bit, 0, "tieneDetalle")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@esBoletaVta", SqlDbType.Bit, 0, "esBoletaVta")
        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoIDF_TiposDoctos(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo IDF_TiposDoctos"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el TiposDoctoID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_TiposDoctos WHERE TiposDoctoID = " & Me.TiposDoctoID.ToString()
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_TiposDoctos")
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
        ''       Yo compruebo que sea un campo llamado TiposDoctoID, pero en tu caso puede ser otro
        'sCommand = "DELETE FROM IDF_TiposDoctos WHERE (TiposDoctoID = @p1)"
        'da.DeleteCommand = New SqlCommand(sCommand, cnn)
        '' TODO: Comprobar el tipo de datos a usar...
        'da.DeleteCommand.Parameters.Add("@p1", SqlDbType.Int, 0, "TiposDoctoID")
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
