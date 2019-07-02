'------------------------------------------------------------------------------
' Clase IDF_DFDescrip generada automáticamente con CrearClaseSQL
' de la tabla 'IDF_DFDescrip' de la base 'Finanzas'
' Fecha: 11/May/2015 08:53:53
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
Public Class IDF_DFDescrip
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _DFDescripID As System.Int32
    Private _DFNum As System.String
    Private _CAI As System.String
    Private _Fecha As System.DateTime
    Private _EmpresaCodigo As System.String
    Private _SdNCodigo As System.String
    Private _Concepto As System.Int32
    Private _Descripcion As System.String
    Private _TiposDoctoID As System.Int32
    Private _Estado As System.Int32
    Private _TotalNeto As System.Decimal
    Private _MonedaCodigo As System.String
    Private _UsuCreador As System.String
    Private _FechaCreacion As System.DateTime
    Private _UsuEditor As System.String
    Private _FechaEdicion As System.DateTime
    Private _UsuAnulacion As System.String
    Private _FechaAnulacion As System.DateTime
    Private _UsuImpresion As System.String
    Private _FechaImpresion As System.DateTime
    Private _estaImpreso As System.Boolean
    Private _CAIComprobante As System.String
    Private _NumComprobante As System.String
    Private _FechaEmisionComp As System.DateTime
    Private _InfoExtra As System.String
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
    Public Property DFDescripID() As System.Int32
        Get
            Return  _DFDescripID
        End Get
        Set(value As System.Int32)
            _DFDescripID = value
        End Set
    End Property
    Public Property DFNum() As System.String
        Get
            Return ajustarAncho(_DFNum,25)
        End Get
        Set(value As System.String)
            _DFNum = value
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
    Public Property Fecha() As System.DateTime
        Get
            Return  _Fecha
        End Get
        Set(value As System.DateTime)
            _Fecha = value
        End Set
    End Property
    Public Property EmpresaCodigo() As System.String
        Get
            Return ajustarAncho(_EmpresaCodigo,3)
        End Get
        Set(value As System.String)
            _EmpresaCodigo = value
        End Set
    End Property
    Public Property SdNCodigo() As System.String
        Get
            Return ajustarAncho(_SdNCodigo,10)
        End Get
        Set(value As System.String)
            _SdNCodigo = value
        End Set
    End Property
    Public Property Concepto() As System.Int32
        Get
            Return  _Concepto
        End Get
        Set(value As System.Int32)
            _Concepto = value
        End Set
    End Property
    Public Property Descripcion() As System.String
        Get
            Return ajustarAncho(_Descripcion,200)
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
    Public Property Estado() As System.Int32
        Get
            Return  _Estado
        End Get
        Set(value As System.Int32)
            _Estado = value
        End Set
    End Property
    Public Property TotalNeto() As System.Decimal
        Get
            Return  _TotalNeto
        End Get
        Set(value As System.Decimal)
            _TotalNeto = value
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
    Public Property UsuCreador() As System.String
        Get
            Return ajustarAncho(_UsuCreador,25)
        End Get
        Set(value As System.String)
            _UsuCreador = value
        End Set
    End Property
    Public Property FechaCreacion() As System.DateTime
        Get
            Return  _FechaCreacion
        End Get
        Set(value As System.DateTime)
            _FechaCreacion = value
        End Set
    End Property
    Public Property UsuEditor() As System.String
        Get
            Return ajustarAncho(_UsuEditor,25)
        End Get
        Set(value As System.String)
            _UsuEditor = value
        End Set
    End Property
    Public Property FechaEdicion() As System.DateTime
        Get
            Return  _FechaEdicion
        End Get
        Set(value As System.DateTime)
            _FechaEdicion = value
        End Set
    End Property
    Public Property UsuAnulacion() As System.String
        Get
            Return ajustarAncho(_UsuAnulacion,25)
        End Get
        Set(value As System.String)
            _UsuAnulacion = value
        End Set
    End Property
    Public Property FechaAnulacion() As System.DateTime
        Get
            Return  _FechaAnulacion
        End Get
        Set(value As System.DateTime)
            _FechaAnulacion = value
        End Set
    End Property
    Public Property UsuImpresion() As System.String
        Get
            Return ajustarAncho(_UsuImpresion,25)
        End Get
        Set(value As System.String)
            _UsuImpresion = value
        End Set
    End Property
    Public Property FechaImpresion() As System.DateTime
        Get
            Return  _FechaImpresion
        End Get
        Set(value As System.DateTime)
            _FechaImpresion = value
        End Set
    End Property
    Public Property estaImpreso() As System.Boolean
        Get
            Return  _estaImpreso
        End Get
        Set(value As System.Boolean)
            _estaImpreso = value
        End Set
    End Property
    Public Property CAIComprobante() As System.String
        Get
            Return ajustarAncho(_CAIComprobante,60)
        End Get
        Set(value As System.String)
            _CAIComprobante = value
        End Set
    End Property
    Public Property NumComprobante() As System.String
        Get
            Return ajustarAncho(_NumComprobante,20)
        End Get
        Set(value As System.String)
            _NumComprobante = value
        End Set
    End Property
    Public Property FechaEmisionComp() As System.DateTime
        Get
            Return  _FechaEmisionComp
        End Get
        Set(value As System.DateTime)
            _FechaEmisionComp = value
        End Set
    End Property

    Public Property InfoExtra() As System.String
        Get
            Return ajustarAncho(_InfoExtra, 800)
        End Get
        Set(value As System.String)
            _InfoExtra = value
        End Set
    End Property
    '
    Public Default Property Item(index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.DFDescripID.ToString()
            ElseIf index = 1 Then
                Return Me.DFNum.ToString()
            ElseIf index = 2 Then
                Return Me.CAI.ToString()
            ElseIf index = 3 Then
                Return Me.Fecha.ToString()
            ElseIf index = 4 Then
                Return Me.EmpresaCodigo.ToString()
            ElseIf index = 5 Then
                Return Me.SdNCodigo.ToString()
            ElseIf index = 6 Then
                Return Me.Concepto.ToString()
            ElseIf index = 7 Then
                Return Me.Descripcion.ToString()
            ElseIf index = 8 Then
                Return Me.TiposDoctoID.ToString()
            ElseIf index = 9 Then
                Return Me.Estado.ToString()
            ElseIf index = 10 Then
                Return Me.TotalNeto.ToString()
            ElseIf index = 11 Then
                Return Me.MonedaCodigo.ToString()
            ElseIf index = 12 Then
                Return Me.UsuCreador.ToString()
            ElseIf index = 13 Then
                Return Me.FechaCreacion.ToString()
            ElseIf index = 14 Then
                Return Me.UsuEditor.ToString()
            ElseIf index = 15 Then
                Return Me.FechaEdicion.ToString()
            ElseIf index = 16 Then
                Return Me.UsuAnulacion.ToString()
            ElseIf index = 17 Then
                Return Me.FechaAnulacion.ToString()
            ElseIf index = 18 Then
                Return Me.UsuImpresion.ToString()
            ElseIf index = 19 Then
                Return Me.FechaImpresion.ToString()
            ElseIf index = 20 Then
                Return Me.estaImpreso.ToString()
            ElseIf index = 21 Then
                Return Me.CAIComprobante.ToString()
            ElseIf index = 22 Then
                Return Me.NumComprobante.ToString()
            ElseIf index = 23 Then
                Return Me.FechaEmisionComp.ToString()
            ElseIf index = 24 Then
                Return Me.InfoExtra.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = 0 Then
                Try
                    Me.DFDescripID = System.Int32.Parse("0" & value)
                Catch
                    Me.DFDescripID = System.Int32.Parse("0")
                End Try
            ElseIf index = 1 Then
                Me.DFNum = value
            ElseIf index = 2 Then
                Me.CAI = value
            ElseIf index = 3 Then
                Try
                    Me.Fecha = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.Fecha = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.Fecha = System.DateTime.Now
                End Try
            ElseIf index = 4 Then
                Me.EmpresaCodigo = value
            ElseIf index = 5 Then
                Me.SdNCodigo = value
            ElseIf index = 6 Then
                Try
                    Me.Concepto = System.Int32.Parse("0" & value)
                Catch
                    Me.Concepto = System.Int32.Parse("0")
                End Try
            ElseIf index = 7 Then
                Me.Descripcion = value
            ElseIf index = 8 Then
                Try
                    Me.TiposDoctoID = System.Int32.Parse("0" & value)
                Catch
                    Me.TiposDoctoID = System.Int32.Parse("0")
                End Try
            ElseIf index = 9 Then
                Try
                    Me.Estado = System.Int32.Parse("0" & value)
                Catch
                    Me.Estado = System.Int32.Parse("0")
                End Try
            ElseIf index = 10 Then
                Try
                    Me.TotalNeto = System.Decimal.Parse("0" & value)
                Catch
                    Me.TotalNeto = System.Decimal.Parse("0")
                End Try
            ElseIf index = 11 Then
                Me.MonedaCodigo = value
            ElseIf index = 12 Then
                Me.UsuCreador = value
            ElseIf index = 13 Then
                Try
                    Me.FechaCreacion = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaCreacion = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaCreacion = System.DateTime.Now
                End Try
            ElseIf index = 14 Then
                Me.UsuEditor = value
            ElseIf index = 15 Then
                Try
                    Me.FechaEdicion = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaEdicion = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaEdicion = System.DateTime.Now
                End Try
            ElseIf index = 16 Then
                Me.UsuAnulacion = value
            ElseIf index = 17 Then
                Try
                    Me.FechaAnulacion = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaAnulacion = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaAnulacion = System.DateTime.Now
                End Try
            ElseIf index = 18 Then
                Me.UsuImpresion = value
            ElseIf index = 19 Then
                Try
                    Me.FechaImpresion = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaImpresion = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaImpresion = System.DateTime.Now
                End Try
            ElseIf index = 20 Then
                Try
                    Me.estaImpreso = System.Boolean.Parse(value)
                Catch
                    Me.estaImpreso = False
                End Try
            ElseIf index = 21 Then
                Me.CAIComprobante = value
            ElseIf index = 22 Then
                Me.NumComprobante = value
            ElseIf index = 23 Then
                Try
                    Me.FechaEmisionComp = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaEmisionComp = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaEmisionComp = System.DateTime.Now
                End Try
            ElseIf index = 24 Then
                Me.InfoExtra = value
            End If
        End Set
    End Property
    Public Default Property Item(index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde al nombre de la columna)
        Get
            If index = "DFDescripID" Then
                Return Me.DFDescripID.ToString()
            ElseIf index = "DFNum" Then
                Return Me.DFNum.ToString()
            ElseIf index = "CAI" Then
                Return Me.CAI.ToString()
            ElseIf index = "Fecha" Then
                Return Me.Fecha.ToString()
            ElseIf index = "EmpresaCodigo" Then
                Return Me.EmpresaCodigo.ToString()
            ElseIf index = "SdNCodigo" Then
                Return Me.SdNCodigo.ToString()
            ElseIf index = "Concepto" Then
                Return Me.Concepto.ToString()
            ElseIf index = "Descripcion" Then
                Return Me.Descripcion.ToString()
            ElseIf index = "TiposDoctoID" Then
                Return Me.TiposDoctoID.ToString()
            ElseIf index = "Estado" Then
                Return Me.Estado.ToString()
            ElseIf index = "TotalNeto" Then
                Return Me.TotalNeto.ToString()
            ElseIf index = "MonedaCodigo" Then
                Return Me.MonedaCodigo.ToString()
            ElseIf index = "UsuCreador" Then
                Return Me.UsuCreador.ToString()
            ElseIf index = "FechaCreacion" Then
                Return Me.FechaCreacion.ToString()
            ElseIf index = "UsuEditor" Then
                Return Me.UsuEditor.ToString()
            ElseIf index = "FechaEdicion" Then
                Return Me.FechaEdicion.ToString()
            ElseIf index = "UsuAnulacion" Then
                Return Me.UsuAnulacion.ToString()
            ElseIf index = "FechaAnulacion" Then
                Return Me.FechaAnulacion.ToString()
            ElseIf index = "UsuImpresion" Then
                Return Me.UsuImpresion.ToString()
            ElseIf index = "FechaImpresion" Then
                Return Me.FechaImpresion.ToString()
            ElseIf index = "estaImpreso" Then
                Return Me.estaImpreso.ToString()
            ElseIf index = "CAIComprobante" Then
                Return Me.CAIComprobante.ToString()
            ElseIf index = "NumComprobante" Then
                Return Me.NumComprobante.ToString()
            ElseIf index = "FechaEmisionComp" Then
                Return Me.FechaEmisionComp.ToString()
            ElseIf index = "InfoExtra" Then
                Return Me.InfoExtra.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = "DFDescripID" Then
                Try
                    Me.DFDescripID = System.Int32.Parse("0" & value)
                Catch
                    Me.DFDescripID = System.Int32.Parse("0")
                End Try
            ElseIf index = "DFNum" Then
                Me.DFNum = value
            ElseIf index = "CAI" Then
                Me.CAI = value
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
            ElseIf index = "EmpresaCodigo" Then
                Me.EmpresaCodigo = value
            ElseIf index = "SdNCodigo" Then
                Me.SdNCodigo = value
            ElseIf index = "Concepto" Then
                Try
                    Me.Concepto = System.Int32.Parse("0" & value)
                Catch
                    Me.Concepto = System.Int32.Parse("0")
                End Try
            ElseIf index = "Descripcion" Then
                Me.Descripcion = value
            ElseIf index = "TiposDoctoID" Then
                Try
                    Me.TiposDoctoID = System.Int32.Parse("0" & value)
                Catch
                    Me.TiposDoctoID = System.Int32.Parse("0")
                End Try
            ElseIf index = "Estado" Then
                Try
                    Me.Estado = System.Int32.Parse("0" & value)
                Catch
                    Me.Estado = System.Int32.Parse("0")
                End Try
            ElseIf index = "TotalNeto" Then
                Try
                    Me.TotalNeto = System.Decimal.Parse("0" & value)
                Catch
                    Me.TotalNeto = System.Decimal.Parse("0")
                End Try
            ElseIf index = "MonedaCodigo" Then
                Me.MonedaCodigo = value
            ElseIf index = "UsuCreador" Then
                Me.UsuCreador = value
            ElseIf index = "FechaCreacion" Then
                Try
                    Me.FechaCreacion = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaCreacion = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaCreacion = System.DateTime.Now
                End Try
            ElseIf index = "UsuEditor" Then
                Me.UsuEditor = value
            ElseIf index = "FechaEdicion" Then
                Try
                    Me.FechaEdicion = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaEdicion = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaEdicion = System.DateTime.Now
                End Try
            ElseIf index = "UsuAnulacion" Then
                Me.UsuAnulacion = value
            ElseIf index = "FechaAnulacion" Then
                Try
                    Me.FechaAnulacion = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaAnulacion = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaAnulacion = System.DateTime.Now
                End Try
            ElseIf index = "UsuImpresion" Then
                Me.UsuImpresion = value
            ElseIf index = "FechaImpresion" Then
                Try
                    Me.FechaImpresion = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaImpresion = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaImpresion = System.DateTime.Now
                End Try
            ElseIf index = "estaImpreso" Then
                Try
                    Me.estaImpreso = System.Boolean.Parse(value)
                Catch
                    Me.estaImpreso = False
                End Try
            ElseIf index = "CAIComprobante" Then
                Me.CAIComprobante = value
            ElseIf index = "NumComprobante" Then
                Me.NumComprobante = value
            ElseIf index = "FechaEmisionComp" Then
                Try
                    Me.FechaEmisionComp = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaEmisionComp = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaEmisionComp = System.DateTime.Now
                End Try
            ElseIf index = "InfoExtra" Then
                Me.InfoExtra = value
            End If
        End Set
    End Property
    '
    ' Campos y métodos compartidos (estáticos) para gestionar la base de datos
    '
    ' La cadena de conexión a la base de datos
    Private Shared cadenaConexion As String = "Data Source=amigodb\amigodb; Initial Catalog=Finanzas; user id=rptuser; password=MiTo1380"
    ' La cadena de selección
    Public Shared CadenaSelect As String = "SELECT * FROM IDF_DFDescrip"
    '
    Public Sub New()
    End Sub
    Public Sub New(conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto IDF_DFDescrip
    Private Shared Function row2IDF_DFDescrip(r As DataRow) As IDF_DFDescrip
        ' asigna a un objeto IDF_DFDescrip los datos del dataRow indicado
        Dim oIDF_DFDescrip As New IDF_DFDescrip
        '
        oIDF_DFDescrip.DFDescripID = System.Int32.Parse("0" & r("DFDescripID").ToString())
        oIDF_DFDescrip.DFNum = r("DFNum").ToString()
        oIDF_DFDescrip.CAI = r("CAI").ToString()
        Try
            oIDF_DFDescrip.Fecha = DateTime.Parse(r("Fecha").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oIDF_DFDescrip.Fecha = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oIDF_DFDescrip.Fecha = DateTime.Now
        End Try
        oIDF_DFDescrip.EmpresaCodigo = r("EmpresaCodigo").ToString()
        oIDF_DFDescrip.SdNCodigo = r("SdNCodigo").ToString()
        oIDF_DFDescrip.Concepto = System.Int32.Parse("0" & r("Concepto").ToString())
        oIDF_DFDescrip.Descripcion = r("Descripcion").ToString()
        oIDF_DFDescrip.TiposDoctoID = System.Int32.Parse("0" & r("TiposDoctoID").ToString())
        oIDF_DFDescrip.Estado = System.Int32.Parse("0" & r("Estado").ToString())
        oIDF_DFDescrip.TotalNeto = System.Decimal.Parse("0" & r("TotalNeto").ToString())
        oIDF_DFDescrip.MonedaCodigo = r("MonedaCodigo").ToString()
        oIDF_DFDescrip.UsuCreador = r("UsuCreador").ToString()
        Try
            oIDF_DFDescrip.FechaCreacion = DateTime.Parse(r("FechaCreacion").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oIDF_DFDescrip.FechaCreacion = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oIDF_DFDescrip.FechaCreacion = DateTime.Now
        End Try
        oIDF_DFDescrip.UsuEditor = r("UsuEditor").ToString()
        Try
            oIDF_DFDescrip.FechaEdicion = DateTime.Parse(r("FechaEdicion").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oIDF_DFDescrip.FechaEdicion = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oIDF_DFDescrip.FechaEdicion = DateTime.Now
        End Try
        oIDF_DFDescrip.UsuAnulacion = r("UsuAnulacion").ToString()
        Try
            oIDF_DFDescrip.FechaAnulacion = DateTime.Parse(r("FechaAnulacion").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oIDF_DFDescrip.FechaAnulacion = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oIDF_DFDescrip.FechaAnulacion = DateTime.Now
        End Try
        oIDF_DFDescrip.UsuImpresion = r("UsuImpresion").ToString()
        Try
            oIDF_DFDescrip.FechaImpresion = DateTime.Parse(r("FechaImpresion").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oIDF_DFDescrip.FechaImpresion = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oIDF_DFDescrip.FechaImpresion = DateTime.Now
        End Try
        Try
            oIDF_DFDescrip.estaImpreso = System.Boolean.Parse(r("estaImpreso").ToString())
        Catch
            oIDF_DFDescrip.estaImpreso = False
        End Try
        oIDF_DFDescrip.CAIComprobante = r("CAIComprobante").ToString()
        oIDF_DFDescrip.NumComprobante = r("NumComprobante").ToString()
        Try
            oIDF_DFDescrip.FechaEmisionComp = DateTime.Parse(r("FechaEmisionComp").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oIDF_DFDescrip.FechaEmisionComp = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oIDF_DFDescrip.FechaEmisionComp = DateTime.Now
        End Try
        oIDF_DFDescrip.InfoExtra = r("InfoExtra").ToString()
        '
        Return oIDF_DFDescrip
    End Function
    '
    ' asigna un objeto IDF_DFDescrip a la fila indicada
    Private Shared Sub IDF_DFDescrip2Row(oIDF_DFDescrip As IDF_DFDescrip, r As DataRow)
        ' asigna un objeto IDF_DFDescrip al dataRow indicado
        ' TODO: Comprueba si esta asignación debe hacerse
        '       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        'r("DFDescripID") = oIDF_DFDescrip.DFDescripID
        r("DFNum") = oIDF_DFDescrip.DFNum
        r("CAI") = oIDF_DFDescrip.CAI
        r("Fecha") = oIDF_DFDescrip.Fecha
        r("EmpresaCodigo") = oIDF_DFDescrip.EmpresaCodigo
        r("SdNCodigo") = oIDF_DFDescrip.SdNCodigo
        r("Concepto") = oIDF_DFDescrip.Concepto
        r("Descripcion") = oIDF_DFDescrip.Descripcion
        r("TiposDoctoID") = oIDF_DFDescrip.TiposDoctoID
        r("Estado") = oIDF_DFDescrip.Estado
        r("TotalNeto") = oIDF_DFDescrip.TotalNeto
        r("MonedaCodigo") = oIDF_DFDescrip.MonedaCodigo
        r("UsuCreador") = oIDF_DFDescrip.UsuCreador
        r("FechaCreacion") = oIDF_DFDescrip.FechaCreacion
        r("UsuEditor") = oIDF_DFDescrip.UsuEditor
        r("FechaEdicion") = oIDF_DFDescrip.FechaEdicion
        r("UsuAnulacion") = oIDF_DFDescrip.UsuAnulacion
        r("FechaAnulacion") = oIDF_DFDescrip.FechaAnulacion
        r("UsuImpresion") = oIDF_DFDescrip.UsuImpresion
        r("FechaImpresion") = oIDF_DFDescrip.FechaImpresion
        r("estaImpreso") = oIDF_DFDescrip.estaImpreso
        r("CAIComprobante") = oIDF_DFDescrip.CAIComprobante
        r("NumComprobante") = oIDF_DFDescrip.NumComprobante
        r("FechaEmisionComp") = oIDF_DFDescrip.FechaEmisionComp
        r("InfoExtra") = oIDF_DFDescrip.InfoExtra

    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto IDF_DFDescrip
    Private Shared Sub nuevoIDF_DFDescrip(dt As DataTable, oIDF_DFDescrip As IDF_DFDescrip)
        ' Crear un nuevo IDF_DFDescrip
        Dim dr As DataRow = dt.NewRow()
        Dim oI As IDF_DFDescrip = row2IDF_DFDescrip(dr)
        '
        oI.DFDescripID = oIDF_DFDescrip.DFDescripID
        oI.DFNum = oIDF_DFDescrip.DFNum
        oI.CAI = oIDF_DFDescrip.CAI
        oI.Fecha = oIDF_DFDescrip.Fecha
        oI.EmpresaCodigo = oIDF_DFDescrip.EmpresaCodigo
        oI.SdNCodigo = oIDF_DFDescrip.SdNCodigo
        oI.Concepto = oIDF_DFDescrip.Concepto
        oI.Descripcion = oIDF_DFDescrip.Descripcion
        oI.TiposDoctoID = oIDF_DFDescrip.TiposDoctoID
        oI.Estado = oIDF_DFDescrip.Estado
        oI.TotalNeto = oIDF_DFDescrip.TotalNeto
        oI.MonedaCodigo = oIDF_DFDescrip.MonedaCodigo
        oI.UsuCreador = oIDF_DFDescrip.UsuCreador
        oI.FechaCreacion = oIDF_DFDescrip.FechaCreacion
        oI.UsuEditor = oIDF_DFDescrip.UsuEditor
        oI.FechaEdicion = oIDF_DFDescrip.FechaEdicion
        oI.UsuAnulacion = oIDF_DFDescrip.UsuAnulacion
        oI.FechaAnulacion = oIDF_DFDescrip.FechaAnulacion
        oI.UsuImpresion = oIDF_DFDescrip.UsuImpresion
        oI.FechaImpresion = oIDF_DFDescrip.FechaImpresion
        oI.estaImpreso = oIDF_DFDescrip.estaImpreso
        oI.CAIComprobante = oIDF_DFDescrip.CAIComprobante
        oI.NumComprobante = oIDF_DFDescrip.NumComprobante
        oI.FechaEmisionComp = oIDF_DFDescrip.FechaEmisionComp
        oI.InfoExtra = oIDF_DFDescrip.InfoExtra
        '
        IDF_DFDescrip2Row(oI, dr)
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
        ' devuelve una tabla con los datos de la tabla IDF_DFDescrip
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_DFDescrip")
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
    Public Shared Function Buscar(sWhere As String) As IDF_DFDescrip
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oIDF_DFDescrip As IDF_DFDescrip = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_DFDescrip")
        Dim sel As String = "SELECT * FROM IDF_DFDescrip WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oIDF_DFDescrip = row2IDF_DFDescrip(dt.Rows(0))
        End If
        Return oIDF_DFDescrip
    End Function
    '
    ' Actualizar: Actualiza los datos en la tabla usando la instancia actual
    '             Si la instancia no hace referencia a un registro existente, se creará uno nuevo
    '             Para comprobar si el objeto en memoria coincide con uno existente,
    '             se comprueba si el DFDescripID existe en la tabla.
    '             TODO: Si en lugar de DFDescripID usas otro campo, indicalo en la cadena SELECT
    '                   También puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    Public Function Actualizar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el DFDescripID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_DFDescrip WHERE DFDescripID = " & Me.DFDescripID.ToString()
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(sel As String) As String
        ' Actualiza los datos indicados
        ' El parámetro, que es una cadena de selección, indicará el criterio de actualización
        '
        ' En caso de error, devolverá la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_DFDescrip")
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
        '       Yo compruebo que sea un campo llamado DFDescripID, pero en tu caso puede ser otro
        '       Ese campo, (en mi caso DFDescripID) será el que hay que poner al final junto al WHERE.
        sCommand = "UPDATE IDF_DFDescrip SET DFNum = @DFNum, CAI = @CAI, Fecha = @Fecha, EmpresaCodigo = @EmpresaCodigo, SdNCodigo = @SdNCodigo, Concepto = @Concepto, Descripcion = @Descripcion, TiposDoctoID = @TiposDoctoID, Estado = @Estado, TotalNeto = @TotalNeto, MonedaCodigo = @MonedaCodigo, UsuCreador = @UsuCreador, FechaCreacion = @FechaCreacion, UsuEditor = @UsuEditor, FechaEdicion = @FechaEdicion, UsuAnulacion = @UsuAnulacion, FechaAnulacion = @FechaAnulacion, UsuImpresion = @UsuImpresion, FechaImpresion = @FechaImpresion, estaImpreso = @estaImpreso, CAIComprobante = @CAIComprobante, NumComprobante = @NumComprobante, FechaEmisionComp = @FechaEmisionComp, InfoExtra = @InfoExtra  WHERE (DFDescripID = @DFDescripID)"
        da.UpdateCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@DFDescripID", SqlDbType.Int, 0, "DFDescripID")
        da.UpdateCommand.Parameters.Add("@DFNum", SqlDbType.NVarChar, 25, "DFNum")
        da.UpdateCommand.Parameters.Add("@CAI", SqlDbType.NVarChar, 60, "CAI")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@Fecha", SqlDbType.DateTime, 0, "Fecha")
        da.UpdateCommand.Parameters.Add("@EmpresaCodigo", SqlDbType.NVarChar, 3, "EmpresaCodigo")
        da.UpdateCommand.Parameters.Add("@SdNCodigo", SqlDbType.NVarChar, 10, "SdNCodigo")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@Concepto", SqlDbType.Int, 0, "Concepto")
        da.UpdateCommand.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 200, "Descripcion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@TiposDoctoID", SqlDbType.Int, 0, "TiposDoctoID")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@Estado", SqlDbType.Int, 0, "Estado")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@TotalNeto", SqlDbType.Decimal, 0, "TotalNeto")
        da.UpdateCommand.Parameters.Add("@MonedaCodigo", SqlDbType.NVarChar, 3, "MonedaCodigo")
        da.UpdateCommand.Parameters.Add("@UsuCreador", SqlDbType.NVarChar, 25, "UsuCreador")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 0, "FechaCreacion")
        da.UpdateCommand.Parameters.Add("@UsuEditor", SqlDbType.NVarChar, 25, "UsuEditor")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@FechaEdicion", SqlDbType.DateTime, 0, "FechaEdicion")
        da.UpdateCommand.Parameters.Add("@UsuAnulacion", SqlDbType.NVarChar, 25, "UsuAnulacion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@FechaAnulacion", SqlDbType.DateTime, 0, "FechaAnulacion")
        da.UpdateCommand.Parameters.Add("@UsuImpresion", SqlDbType.NVarChar, 25, "UsuImpresion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@FechaImpresion", SqlDbType.DateTime, 0, "FechaImpresion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@estaImpreso", SqlDbType.Bit, 0, "estaImpreso")
        da.UpdateCommand.Parameters.Add("@CAIComprobante", SqlDbType.NVarChar, 60, "CAIComprobante")
        da.UpdateCommand.Parameters.Add("@NumComprobante", SqlDbType.NVarChar, 20, "NumComprobante")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@FechaEmisionComp", SqlDbType.DateTime, 0, "FechaEmisionComp")
        da.UpdateCommand.Parameters.Add("@InfoExtra", SqlDbType.NVarChar, 800, "InfoExtra")
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
            IDF_DFDescrip2Row(Me, dt.Rows(0))
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
        Dim dt As New DataTable("IDF_DFDescrip")
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
        '       Yo compruebo que sea un campo llamado DFDescripID, pero en tu caso puede ser otro
        sCommand = "INSERT INTO IDF_DFDescrip (DFNum, CAI, Fecha, EmpresaCodigo, SdNCodigo, Concepto, Descripcion, TiposDoctoID, Estado, TotalNeto, MonedaCodigo, UsuCreador, FechaCreacion, UsuEditor, FechaEdicion, UsuAnulacion, FechaAnulacion, UsuImpresion, FechaImpresion, estaImpreso, CAIComprobante, NumComprobante, FechaEmisionComp, InfoExtra)  VALUES(@DFNum, @CAI, @Fecha, @EmpresaCodigo, @SdNCodigo, @Concepto, @Descripcion, @TiposDoctoID, @Estado, @TotalNeto, @MonedaCodigo, @UsuCreador, @FechaCreacion, @UsuEditor, @FechaEdicion, @UsuAnulacion, @FechaAnulacion, @UsuImpresion, @FechaImpresion, @estaImpreso, @CAIComprobante, @NumComprobante, @FechaEmisionComp, @InfoExtra) "
        da.InsertCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@DFDescripID", SqlDbType.Int, 0, "DFDescripID")
        da.InsertCommand.Parameters.Add("@DFNum", SqlDbType.NVarChar, 25, "DFNum")
        da.InsertCommand.Parameters.Add("@CAI", SqlDbType.NVarChar, 60, "CAI")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@Fecha", SqlDbType.DateTime, 0, "Fecha")
        da.InsertCommand.Parameters.Add("@EmpresaCodigo", SqlDbType.NVarChar, 3, "EmpresaCodigo")
        da.InsertCommand.Parameters.Add("@SdNCodigo", SqlDbType.NVarChar, 10, "SdNCodigo")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@Concepto", SqlDbType.Int, 0, "Concepto")
        da.InsertCommand.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 200, "Descripcion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@TiposDoctoID", SqlDbType.Int, 0, "TiposDoctoID")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@Estado", SqlDbType.Int, 0, "Estado")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@TotalNeto", SqlDbType.Decimal, 0, "TotalNeto")
        da.InsertCommand.Parameters.Add("@MonedaCodigo", SqlDbType.NVarChar, 3, "MonedaCodigo")
        da.InsertCommand.Parameters.Add("@UsuCreador", SqlDbType.NVarChar, 25, "UsuCreador")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 0, "FechaCreacion")
        da.InsertCommand.Parameters.Add("@UsuEditor", SqlDbType.NVarChar, 25, "UsuEditor")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@FechaEdicion", SqlDbType.DateTime, 0, "FechaEdicion")
        da.InsertCommand.Parameters.Add("@UsuAnulacion", SqlDbType.NVarChar, 25, "UsuAnulacion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@FechaAnulacion", SqlDbType.DateTime, 0, "FechaAnulacion")
        da.InsertCommand.Parameters.Add("@UsuImpresion", SqlDbType.NVarChar, 25, "UsuImpresion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@FechaImpresion", SqlDbType.DateTime, 0, "FechaImpresion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@estaImpreso", SqlDbType.Bit, 0, "estaImpreso")
        da.InsertCommand.Parameters.Add("@CAIComprobante", SqlDbType.NVarChar, 60, "CAIComprobante")
        da.InsertCommand.Parameters.Add("@NumComprobante", SqlDbType.NVarChar, 20, "NumComprobante")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@FechaEmisionComp", SqlDbType.DateTime, 0, "FechaEmisionComp")
        da.InsertCommand.Parameters.Add("@InfoExtra", SqlDbType.NVarChar, 800, "InfoExtra")
        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoIDF_DFDescrip(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo IDF_DFDescrip"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el DFDescripID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_DFDescrip WHERE DFDescripID = " & Me.DFDescripID.ToString()
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_DFDescrip")
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
        '       Yo compruebo que sea un campo llamado DFDescripID, pero en tu caso puede ser otro
        sCommand = "DELETE FROM IDF_DFDescrip WHERE (DFDescripID = @p1)"
        da.DeleteCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.DeleteCommand.Parameters.Add("@p1", SqlDbType.Int, 0, "DFDescripID")
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
    Public Shared Function SigDFDescrip(nIntT As Integer, strEmpresa As String) As Integer
        Dim nRes = 0
        Try
            ' Busca en la tabla los datos indicados en el parámetro
            ' el parámetro contendrá lo que se usará después del WHERE
            Dim oIDF_DFDescrip As IDF_DFDescrip = Nothing
            Dim da As SqlDataAdapter
            Dim dt As New DataTable("IDF_DFDescrip")
            Dim sel As String

            sel = "SELECT Top 1 DFNum FROM IDF_DFDescrip Where TiposDoctoID ='" & nIntT & "' and EmpresaCodigo = '" & strEmpresa & "' Order by DFNum Desc "

            '
            da = New SqlDataAdapter(sel, cadenaConexion)
            da.Fill(dt)
            '
            If dt.Rows.Count > 0 Then
                nRes = CInt(Val(dt.Rows(0).Item(0))) + 1
            Else
                nRes = 1
            End If

        Catch ex As Exception

        End Try

        Return nRes
    End Function

    Public Shared Function SigDFDescripCAI(nIntT As Integer,
                                        strEmpresa As String,
                                        strCAI As String) As Integer
        Dim nRes = 0
        Try
            ' Busca en la tabla los datos indicados en el parámetro
            ' el parámetro contendrá lo que se usará después del WHERE
            Dim oIDF_DFDescrip As IDF_DFDescrip = Nothing
            Dim da As SqlDataAdapter
            Dim dt As New DataTable("IDF_DFDescrip")
            Dim sel As String

            sel = "SELECT Top 1 DFNum FROM IDF_DFDescrip " & _
                  "Where TiposDoctoID ='" & nIntT & _
                  "' and EmpresaCodigo = '" & strEmpresa & _
                  "' AND CAI = '" & strCAI & "'" & _
                  " Order by DFNum Desc "

            '
            da = New SqlDataAdapter(sel, cadenaConexion)
            da.Fill(dt)
            '
            If dt.Rows.Count > 0 Then
                nRes = CInt(Val(dt.Rows(0).Item(0))) + 1
            Else
                sel = ""
                sel = "SELECT NumInicial,NumFinal " & _
                      "FROM [Finanzas].[dbo].[IDF_DetConfigxEmp] " & _
                      "WHERE CAI = '" & strCAI & "' " & _
                      "AND   TiposDoctoID = " & nIntT & " "
                Dim dt2 As New DataTable("IDF_DFDescrip2")
                Dim da2 As SqlDataAdapter
                da2 = New SqlDataAdapter(sel, cadenaConexion)
                da2.Fill(dt2)
                If dt2.Rows.Count > 0 Then
                    nRes = CInt(Val(dt2.Rows(0).Item(0)))
                Else
                    nRes = 0
                End If
            End If

        Catch ex As Exception

        End Try

        Return nRes
    End Function
End Class
