'------------------------------------------------------------------------------
' Clase IDF_DetConfigxEmp generada automáticamente con CrearClaseSQL
' de la tabla 'IDF_DetConfigxEmp' de la base 'Finanzas'
' Fecha: 23/Jan/2016 08:59:28
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
Public Class IDF_DetConfigxEmp
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _DetConfigxEmpID As System.Int32
    Private _PuntoEmision As System.String
    Private _TiposDoctoID As System.Int32
    Private _CantSol As System.Decimal
    Private _CantOtor As System.Decimal
    Private _NumInicial As System.Decimal
    Private _NumFinal As System.Decimal
    Private _NumActual As System.Decimal
    Private _esImprimirSimple As System.Boolean
    Private _CAI As System.String
    Private _PrefijoNum As System.String
    Private _CantMinima As System.Int32
    Private _EsActual As System.Boolean
    Private _EsExtendido As System.Boolean
    Private _FechaExtendida As System.DateTime
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
    Public Property DetConfigxEmpID() As System.Int32
        Get
            Return  _DetConfigxEmpID
        End Get
        Set(value As System.Int32)
            _DetConfigxEmpID = value
        End Set
    End Property
    Public Property PuntoEmision() As System.String
        Get
            Return ajustarAncho(_PuntoEmision,50)
        End Get
        Set(value As System.String)
            _PuntoEmision = value
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
    Public Property CantSol() As System.Decimal
        Get
            Return  _CantSol
        End Get
        Set(value As System.Decimal)
            _CantSol = value
        End Set
    End Property
    Public Property CantOtor() As System.Decimal
        Get
            Return  _CantOtor
        End Get
        Set(value As System.Decimal)
            _CantOtor = value
        End Set
    End Property
    Public Property NumInicial() As System.Decimal
        Get
            Return  _NumInicial
        End Get
        Set(value As System.Decimal)
            _NumInicial = value
        End Set
    End Property
    Public Property NumFinal() As System.Decimal
        Get
            Return  _NumFinal
        End Get
        Set(value As System.Decimal)
            _NumFinal = value
        End Set
    End Property
    Public Property NumActual() As System.Decimal
        Get
            Return  _NumActual
        End Get
        Set(value As System.Decimal)
            _NumActual = value
        End Set
    End Property
    Public Property esImprimirSimple() As System.Boolean
        Get
            Return  _esImprimirSimple
        End Get
        Set(value As System.Boolean)
            _esImprimirSimple = value
        End Set
    End Property
    Public Property CAI() As System.String
        Get
            Return ajustarAncho(_CAI,60)
        End Get
        Set(value As System.String)
            _CAI = value
        End Set
    End Property
    Public Property PrefijoNum() As System.String
        Get
            Return ajustarAncho(_PrefijoNum,25)
        End Get
        Set(value As System.String)
            _PrefijoNum = value
        End Set
    End Property
    Public Property CantMinima() As System.Int32
        Get
            Return  _CantMinima
        End Get
        Set(value As System.Int32)
            _CantMinima = value
        End Set
    End Property
    Public Property EsActual() As System.Boolean
        Get
            Return  _EsActual
        End Get
        Set(value As System.Boolean)
            _EsActual = value
        End Set
    End Property

    Public Property EsExtendida() As System.Boolean
        Get
            Return _EsExtendido
        End Get
        Set(value As System.Boolean)
            _EsExtendido = value
        End Set
    End Property

    Public Property FechaExtendida() As System.DateTime
        Get
            Return _FechaExtendida
        End Get
        Set(value As System.DateTime)
            _FechaExtendida = value
        End Set
    End Property
    '
    Public Default Property Item(index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.DetConfigxEmpID.ToString()
            ElseIf index = 1 Then
                Return Me.PuntoEmision.ToString()
            ElseIf index = 2 Then
                Return Me.TiposDoctoID.ToString()
            ElseIf index = 3 Then
                Return Me.CantSol.ToString()
            ElseIf index = 4 Then
                Return Me.CantOtor.ToString()
            ElseIf index = 5 Then
                Return Me.NumInicial.ToString()
            ElseIf index = 6 Then
                Return Me.NumFinal.ToString()
            ElseIf index = 7 Then
                Return Me.NumActual.ToString()
            ElseIf index = 8 Then
                Return Me.esImprimirSimple.ToString()
            ElseIf index = 9 Then
                Return Me.CAI.ToString()
            ElseIf index = 10 Then
                Return Me.PrefijoNum.ToString()
            ElseIf index = 11 Then
                Return Me.CantMinima.ToString()
            ElseIf index = 12 Then
                Return Me.EsActual.ToString()
            ElseIf index = 13 Then
                Return Me.EsExtendida.ToString()
            ElseIf index = 14 Then
                Return Me.FechaExtendida.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = 0 Then
                Try
                    Me.DetConfigxEmpID = System.Int32.Parse("0" & value)
                Catch
                    Me.DetConfigxEmpID = System.Int32.Parse("0")
                End Try
            ElseIf index = 1 Then
                Me.PuntoEmision = value
            ElseIf index = 2 Then
                Try
                    Me.TiposDoctoID = System.Int32.Parse("0" & value)
                Catch
                    Me.TiposDoctoID = System.Int32.Parse("0")
                End Try
            ElseIf index = 3 Then
                Try
                    Me.CantSol = System.Decimal.Parse("0" & value)
                Catch
                    Me.CantSol = System.Decimal.Parse("0")
                End Try
            ElseIf index = 4 Then
                Try
                    Me.CantOtor = System.Decimal.Parse("0" & value)
                Catch
                    Me.CantOtor = System.Decimal.Parse("0")
                End Try
            ElseIf index = 5 Then
                Try
                    Me.NumInicial = System.Decimal.Parse("0" & value)
                Catch
                    Me.NumInicial = System.Decimal.Parse("0")
                End Try
            ElseIf index = 6 Then
                Try
                    Me.NumFinal = System.Decimal.Parse("0" & value)
                Catch
                    Me.NumFinal = System.Decimal.Parse("0")
                End Try
            ElseIf index = 7 Then
                Try
                    Me.NumActual = System.Decimal.Parse("0" & value)
                Catch
                    Me.NumActual = System.Decimal.Parse("0")
                End Try
            ElseIf index = 8 Then
                Try
                    Me.esImprimirSimple = System.Boolean.Parse(value)
                Catch
                    Me.esImprimirSimple = False
                End Try
            ElseIf index = 9 Then
                Me.CAI = value
            ElseIf index = 10 Then
                Me.PrefijoNum = value
            ElseIf index = 11 Then
                Try
                    Me.CantMinima = System.Int32.Parse("0" & value)
                Catch
                    Me.CantMinima = System.Int32.Parse("0")
                End Try
            ElseIf index = 12 Then
                Try
                    Me.EsActual = System.Boolean.Parse(value)
                Catch
                    Me.EsActual = False
                End Try
            ElseIf index = 13 Then
                Try
                    Me.EsExtendida = System.Boolean.Parse(value)
                Catch
                    Me.EsExtendida = False
                End Try
            ElseIf index = 14 Then
                Try
                    Me.FechaExtendida = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaLimite = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaExtendida = System.DateTime.Now
                End Try
            End If

        End Set
    End Property
    Public Default Property Item(index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde al nombre de la columna)
        Get
            If index = "DetConfigxEmpID" Then
                Return Me.DetConfigxEmpID.ToString()
            ElseIf index = "PuntoEmision" Then
                Return Me.PuntoEmision.ToString()
            ElseIf index = "TiposDoctoID" Then
                Return Me.TiposDoctoID.ToString()
            ElseIf index = "CantSol" Then
                Return Me.CantSol.ToString()
            ElseIf index = "CantOtor" Then
                Return Me.CantOtor.ToString()
            ElseIf index = "NumInicial" Then
                Return Me.NumInicial.ToString()
            ElseIf index = "NumFinal" Then
                Return Me.NumFinal.ToString()
            ElseIf index = "NumActual" Then
                Return Me.NumActual.ToString()
            ElseIf index = "esImprimirSimple" Then
                Return Me.esImprimirSimple.ToString()
            ElseIf index = "CAI" Then
                Return Me.CAI.ToString()
            ElseIf index = "PrefijoNum" Then
                Return Me.PrefijoNum.ToString()
            ElseIf index = "CantMinima" Then
                Return Me.CantMinima.ToString()
            ElseIf index = "EsActual" Then
                Return Me.EsActual.ToString()
            ElseIf index = "EsExtendida" Then
                Return Me.EsExtendida.ToString()
            ElseIf index = "FechaExtendida" Then
                Return Me.EsExtendida.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = "DetConfigxEmpID" Then
                Try
                    Me.DetConfigxEmpID = System.Int32.Parse("0" & value)
                Catch
                    Me.DetConfigxEmpID = System.Int32.Parse("0")
                End Try
            ElseIf index = "PuntoEmision" Then
                Me.PuntoEmision = value
            ElseIf index = "TiposDoctoID" Then
                Try
                    Me.TiposDoctoID = System.Int32.Parse("0" & value)
                Catch
                    Me.TiposDoctoID = System.Int32.Parse("0")
                End Try
            ElseIf index = "CantSol" Then
                Try
                    Me.CantSol = System.Decimal.Parse("0" & value)
                Catch
                    Me.CantSol = System.Decimal.Parse("0")
                End Try
            ElseIf index = "CantOtor" Then
                Try
                    Me.CantOtor = System.Decimal.Parse("0" & value)
                Catch
                    Me.CantOtor = System.Decimal.Parse("0")
                End Try
            ElseIf index = "NumInicial" Then
                Try
                    Me.NumInicial = System.Decimal.Parse("0" & value)
                Catch
                    Me.NumInicial = System.Decimal.Parse("0")
                End Try
            ElseIf index = "NumFinal" Then
                Try
                    Me.NumFinal = System.Decimal.Parse("0" & value)
                Catch
                    Me.NumFinal = System.Decimal.Parse("0")
                End Try
            ElseIf index = "NumActual" Then
                Try
                    Me.NumActual = System.Decimal.Parse("0" & value)
                Catch
                    Me.NumActual = System.Decimal.Parse("0")
                End Try
            ElseIf index = "esImprimirSimple" Then
                Try
                    Me.esImprimirSimple = System.Boolean.Parse(value)
                Catch
                    Me.esImprimirSimple = False
                End Try
            ElseIf index = "CAI" Then
                Me.CAI = value
            ElseIf index = "PrefijoNum" Then
                Me.PrefijoNum = value
            ElseIf index = "CantMinima" Then
                Try
                    Me.CantMinima = System.Int32.Parse("0" & value)
                Catch
                    Me.CantMinima = System.Int32.Parse("0")
                End Try
            ElseIf index = "EsActual" Then
                Try
                    Me.EsActual = System.Boolean.Parse(value)
                Catch
                    Me.EsActual = False
                End Try
            ElseIf index = "EsExtendida" Then
                Try
                    Me.EsExtendida = System.Boolean.Parse(value)
                Catch
                    Me.EsExtendida = False
                End Try
            ElseIf index = "FechaExtendida" Then
                Try
                    Me.FechaExtendida = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaLimite = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaExtendida = System.DateTime.Now
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
    Public Shared CadenaSelect As String = "SELECT * FROM IDF_DetConfigxEmp"
    '
    Public Sub New()
    End Sub
    Public Sub New(conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto IDF_DetConfigxEmp
    Private Shared Function row2IDF_DetConfigxEmp(r As DataRow) As IDF_DetConfigxEmp
        ' asigna a un objeto IDF_DetConfigxEmp los datos del dataRow indicado
        Dim oIDF_DetConfigxEmp As New IDF_DetConfigxEmp
        '
        oIDF_DetConfigxEmp.DetConfigxEmpID = System.Int32.Parse("0" & r("DetConfigxEmpID").ToString())
        oIDF_DetConfigxEmp.PuntoEmision = r("PuntoEmision").ToString()
        oIDF_DetConfigxEmp.TiposDoctoID = System.Int32.Parse("0" & r("TiposDoctoID").ToString())
        oIDF_DetConfigxEmp.CantSol = System.Decimal.Parse("0" & r("CantSol").ToString())
        oIDF_DetConfigxEmp.CantOtor = System.Decimal.Parse("0" & r("CantOtor").ToString())
        oIDF_DetConfigxEmp.NumInicial = System.Decimal.Parse("0" & r("NumInicial").ToString())
        oIDF_DetConfigxEmp.NumFinal = System.Decimal.Parse("0" & r("NumFinal").ToString())
        oIDF_DetConfigxEmp.NumActual = System.Decimal.Parse("0" & r("NumActual").ToString())
        Try
            oIDF_DetConfigxEmp.esImprimirSimple = System.Boolean.Parse(r("esImprimirSimple").ToString())
        Catch
            oIDF_DetConfigxEmp.esImprimirSimple = False
        End Try
        oIDF_DetConfigxEmp.CAI = r("CAI").ToString()
        oIDF_DetConfigxEmp.PrefijoNum = r("PrefijoNum").ToString()
        oIDF_DetConfigxEmp.CantMinima = System.Int32.Parse("0" & r("CantMinima").ToString())
        Try
            oIDF_DetConfigxEmp.EsActual = System.Boolean.Parse(r("EsActual").ToString())
        Catch
            oIDF_DetConfigxEmp.EsActual = False
        End Try
        Try
            oIDF_DetConfigxEmp.EsExtendida = System.Boolean.Parse(r("EsExtendida").ToString())
        Catch
            oIDF_DetConfigxEmp.EsExtendida = False
        End Try
        Try
            oIDF_DetConfigxEmp.FechaExtendida = DateTime.Parse(r("FechaExtendida").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oIDF_ConfigxEmp.FechaLimite = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oIDF_DetConfigxEmp.FechaExtendida = DateTime.Now
        End Try
        '
        Return oIDF_DetConfigxEmp
    End Function
    '
    ' asigna un objeto IDF_DetConfigxEmp a la fila indicada
    Private Shared Sub IDF_DetConfigxEmp2Row(oIDF_DetConfigxEmp As IDF_DetConfigxEmp, r As DataRow)
        ' asigna un objeto IDF_DetConfigxEmp al dataRow indicado
        ' TODO: Comprueba si esta asignación debe hacerse
        '       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        r("DetConfigxEmpID") = oIDF_DetConfigxEmp.DetConfigxEmpID
        r("PuntoEmision") = oIDF_DetConfigxEmp.PuntoEmision
        r("TiposDoctoID") = oIDF_DetConfigxEmp.TiposDoctoID
        r("CantSol") = oIDF_DetConfigxEmp.CantSol
        r("CantOtor") = oIDF_DetConfigxEmp.CantOtor
        r("NumInicial") = oIDF_DetConfigxEmp.NumInicial
        r("NumFinal") = oIDF_DetConfigxEmp.NumFinal
        r("NumActual") = oIDF_DetConfigxEmp.NumActual
        r("esImprimirSimple") = oIDF_DetConfigxEmp.esImprimirSimple
        r("CAI") = oIDF_DetConfigxEmp.CAI
        r("PrefijoNum") = oIDF_DetConfigxEmp.PrefijoNum
        r("CantMinima") = oIDF_DetConfigxEmp.CantMinima
        r("EsActual") = oIDF_DetConfigxEmp.EsActual
        r("EsExtendido") = oIDF_DetConfigxEmp.EsExtendida
        r("FechaExtendida") = oIDF_DetConfigxEmp.FechaExtendida

    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto IDF_DetConfigxEmp
    Private Shared Sub nuevoIDF_DetConfigxEmp(dt As DataTable, oIDF_DetConfigxEmp As IDF_DetConfigxEmp)
        ' Crear un nuevo IDF_DetConfigxEmp
        Dim dr As DataRow = dt.NewRow()
        Dim oI As IDF_DetConfigxEmp = row2IDF_DetConfigxEmp(dr)
        '
        oI.DetConfigxEmpID = oIDF_DetConfigxEmp.DetConfigxEmpID
        oI.PuntoEmision = oIDF_DetConfigxEmp.PuntoEmision
        oI.TiposDoctoID = oIDF_DetConfigxEmp.TiposDoctoID
        oI.CantSol = oIDF_DetConfigxEmp.CantSol
        oI.CantOtor = oIDF_DetConfigxEmp.CantOtor
        oI.NumInicial = oIDF_DetConfigxEmp.NumInicial
        oI.NumFinal = oIDF_DetConfigxEmp.NumFinal
        oI.NumActual = oIDF_DetConfigxEmp.NumActual
        oI.esImprimirSimple = oIDF_DetConfigxEmp.esImprimirSimple
        oI.CAI = oIDF_DetConfigxEmp.CAI
        oI.PrefijoNum = oIDF_DetConfigxEmp.PrefijoNum
        oI.CantMinima = oIDF_DetConfigxEmp.CantMinima
        oI.EsActual = oIDF_DetConfigxEmp.EsActual
        oI.EsExtendida = oIDF_DetConfigxEmp.EsExtendida
        oI.FechaExtendida = oIDF_DetConfigxEmp.FechaExtendida

        '
        IDF_DetConfigxEmp2Row(oI, dr)
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
        ' devuelve una tabla con los datos de la tabla IDF_DetConfigxEmp
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_DetConfigxEmp")
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
    Public Shared Function Buscar(sWhere As String) As IDF_DetConfigxEmp
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oIDF_DetConfigxEmp As IDF_DetConfigxEmp = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_DetConfigxEmp")
        Dim sel As String = "SELECT * FROM IDF_DetConfigxEmp WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oIDF_DetConfigxEmp = row2IDF_DetConfigxEmp(dt.Rows(0))
        End If
        Return oIDF_DetConfigxEmp
    End Function

    Public Shared Function BuscarCAI(sWhere As String) As IDF_DetConfigxEmp
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oIDF_DetConfigxEmp As IDF_DetConfigxEmp = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_DetConfigxEmp")
        Dim sel As String = "SELECT A.* FROM IDF_DetConfigxEmp A Left Join IDF_ConfigXEmp B on A.CAI=B.CAI WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oIDF_DetConfigxEmp = row2IDF_DetConfigxEmp(dt.Rows(0))
        End If
        Return oIDF_DetConfigxEmp
    End Function
    '
    ' Actualizar: Actualiza los datos en la tabla usando la instancia actual
    '             Si la instancia no hace referencia a un registro existente, se creará uno nuevo
    '             Para comprobar si el objeto en memoria coincide con uno existente,
    '             se comprueba si el DetConfigxEmpID existe en la tabla.
    '             TODO: Si en lugar de DetConfigxEmpID usas otro campo, indicalo en la cadena SELECT
    '                   También puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    Public Function Actualizar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el DetConfigxEmpID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_DetConfigxEmp WHERE DetConfigxEmpID = " & Me.DetConfigxEmpID.ToString()
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(sel As String) As String
        ' Actualiza los datos indicados
        ' El parámetro, que es una cadena de selección, indicará el criterio de actualización
        '
        ' En caso de error, devolverá la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_DetConfigxEmp")
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
        '       Yo compruebo que sea un campo llamado DetConfigxEmpID, pero en tu caso puede ser otro
        '       Ese campo, (en mi caso DetConfigxEmpID) será el que hay que poner al final junto al WHERE.
        sCommand = "UPDATE IDF_DetConfigxEmp SET PuntoEmision = @PuntoEmision, TiposDoctoID = @TiposDoctoID, CantSol = @CantSol, CantOtor = @CantOtor, NumInicial = @NumInicial, NumFinal = @NumFinal, NumActual = @NumActual, esImprimirSimple = @esImprimirSimple, CAI = @CAI, PrefijoNum = @PrefijoNum, CantMinima = @CantMinima, EsActual = @EsActual  WHERE (DetConfigxEmpID = @DetConfigxEmpID)"
        da.UpdateCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@DetConfigxEmpID", SqlDbType.Int, 0, "DetConfigxEmpID")
        da.UpdateCommand.Parameters.Add("@PuntoEmision", SqlDbType.NVarChar, 50, "PuntoEmision")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@TiposDoctoID", SqlDbType.Int, 0, "TiposDoctoID")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@CantSol", SqlDbType.Decimal, 0, "CantSol")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@CantOtor", SqlDbType.Decimal, 0, "CantOtor")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@NumInicial", SqlDbType.Decimal, 0, "NumInicial")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@NumFinal", SqlDbType.Decimal, 0, "NumFinal")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@NumActual", SqlDbType.Decimal, 0, "NumActual")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@esImprimirSimple", SqlDbType.Bit, 0, "esImprimirSimple")
        da.UpdateCommand.Parameters.Add("@CAI", SqlDbType.NVarChar, 60, "CAI")
        da.UpdateCommand.Parameters.Add("@PrefijoNum", SqlDbType.NVarChar, 25, "PrefijoNum")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@CantMinima", SqlDbType.Int, 0, "CantMinima")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@EsActual", SqlDbType.Bit, 0, "EsActual")

        'EsExtendida = @EsExtendida, FechaExtendida = @FechaExtendida
        'da.UpdateCommand.Parameters.Add("@EsExtendida", SqlDbType.Bit, 0, "EsExtendida")
        'da.UpdateCommand.Parameters.Add("@FechaExtendida", SqlDbType.DateTime, 0, "FechaExtendida")

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
            IDF_DetConfigxEmp2Row(Me, dt.Rows(0))
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
        Dim dt As New DataTable("IDF_DetConfigxEmp")
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
        '       Yo compruebo que sea un campo llamado DetConfigxEmpID, pero en tu caso puede ser otro
        sCommand = "INSERT INTO IDF_DetConfigxEmp (PuntoEmision, TiposDoctoID, CantSol, CantOtor, NumInicial, NumFinal, NumActual, esImprimirSimple, CAI, PrefijoNum, CantMinima, EsActual, EsExtendido, FechaExtendida)  VALUES(@PuntoEmision, @TiposDoctoID, @CantSol, @CantOtor, @NumInicial, @NumFinal, @NumActual, @esImprimirSimple, @CAI, @PrefijoNum, @CantMinima, @EsActual, @EsExtendida, @FechaExtendida)"
        da.InsertCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@DetConfigxEmpID", SqlDbType.Int, 0, "DetConfigxEmpID")
        da.InsertCommand.Parameters.Add("@PuntoEmision", SqlDbType.NVarChar, 50, "PuntoEmision")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@TiposDoctoID", SqlDbType.Int, 0, "TiposDoctoID")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@CantSol", SqlDbType.Decimal, 0, "CantSol")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@CantOtor", SqlDbType.Decimal, 0, "CantOtor")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@NumInicial", SqlDbType.Decimal, 0, "NumInicial")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@NumFinal", SqlDbType.Decimal, 0, "NumFinal")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@NumActual", SqlDbType.Decimal, 0, "NumActual")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@esImprimirSimple", SqlDbType.Bit, 0, "esImprimirSimple")
        da.InsertCommand.Parameters.Add("@CAI", SqlDbType.NVarChar, 60, "CAI")
        da.InsertCommand.Parameters.Add("@PrefijoNum", SqlDbType.NVarChar, 25, "PrefijoNum")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@CantMinima", SqlDbType.Int, 0, "CantMinima")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@EsActual", SqlDbType.Bit, 0, "EsActual")
        da.InsertCommand.Parameters.Add("@EsExtendida", SqlDbType.Bit, 0, "EsExtendido")
        da.InsertCommand.Parameters.Add("@FechaExtendida", SqlDbType.Bit, 0, "FechaExtendida")
        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoIDF_DetConfigxEmp(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo IDF_DetConfigxEmp"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el DetConfigxEmpID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_DetConfigxEmp WHERE DetConfigxEmpID = " & Me.DetConfigxEmpID.ToString()
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_DetConfigxEmp")
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
        '       Yo compruebo que sea un campo llamado DetConfigxEmpID, pero en tu caso puede ser otro
        sCommand = "DELETE FROM IDF_DetConfigxEmp WHERE (DetConfigxEmpID = @p1)"
        da.DeleteCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.DeleteCommand.Parameters.Add("@p1", SqlDbType.Int, 0, "DetConfigxEmpID")
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
