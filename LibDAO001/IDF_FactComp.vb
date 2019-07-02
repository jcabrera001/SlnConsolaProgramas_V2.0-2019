'------------------------------------------------------------------------------
' Clase IDF_FactComp generada automáticamente con CrearClaseSQL
' de la tabla 'IDF_FactComp' de la base 'Finanzas'
' Fecha: 30/Jun/2016 10:34:06
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
Public Class IDF_FactComp
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _FactCompID As System.Int32
    Private _EmpresaCodigo As System.String
    Private _CAIXSdNID As System.Int32
    Private _NDFEstab As System.String
    Private _NDFPuntoEm As System.String
    Private _NDFTipoDoc As System.String
    Private _NDFCorrelat As System.String
    Private _Fecha As System.DateTime
    Private _RetencionID As System.Int32
    Private _CAEE As System.String
    Private _MontoTotal As System.Decimal
    Private _Estado As System.Boolean
    Private _EsOCE As System.Boolean
    Private _OCEResolucion As System.String
    Private _OCEFecha As System.DateTime
    Private _UsuCreacion As System.String
    Private _UsuEdicion As System.String
    Private _UsuAnulacion As System.String
    Private _FechaCreacion As System.DateTime
    Private _FechaEdicion As System.DateTime
    Private _FechaAnulacion As System.DateTime
    Private _AnioAReportar As System.Int32
    Private _MesAReportar As System.Int32
    Private _aplicaRetencion As System.Boolean
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
    Public Property FactCompID() As System.Int32
        Get
            Return  _FactCompID
        End Get
        Set(value As System.Int32)
            _FactCompID = value
        End Set
    End Property
    Public Property EmpresaCodigo() As System.String
        Get
            Return ajustarAncho(_EmpresaCodigo,10)
        End Get
        Set(value As System.String)
            _EmpresaCodigo = value
        End Set
    End Property
    Public Property CAIXSdNID() As System.Int32
        Get
            Return  _CAIXSdNID
        End Get
        Set(value As System.Int32)
            _CAIXSdNID = value
        End Set
    End Property
    Public Property NDFEstab() As System.String
        Get
            Return ajustarAncho(_NDFEstab,5)
        End Get
        Set(value As System.String)
            _NDFEstab = value
        End Set
    End Property
    Public Property NDFPuntoEm() As System.String
        Get
            Return ajustarAncho(_NDFPuntoEm,5)
        End Get
        Set(value As System.String)
            _NDFPuntoEm = value
        End Set
    End Property
    Public Property NDFTipoDoc() As System.String
        Get
            Return ajustarAncho(_NDFTipoDoc,5)
        End Get
        Set(value As System.String)
            _NDFTipoDoc = value
        End Set
    End Property
    Public Property NDFCorrelat() As System.String
        Get
            Return ajustarAncho(_NDFCorrelat,8)
        End Get
        Set(value As System.String)
            _NDFCorrelat = value
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
    Public Property RetencionID() As System.Int32
        Get
            Return  _RetencionID
        End Get
        Set(value As System.Int32)
            _RetencionID = value
        End Set
    End Property
    Public Property CAEE() As System.String
        Get
            Return ajustarAncho(_CAEE,25)
        End Get
        Set(value As System.String)
            _CAEE = value
        End Set
    End Property
    Public Property MontoTotal() As System.Decimal
        Get
            Return  _MontoTotal
        End Get
        Set(value As System.Decimal)
            _MontoTotal = value
        End Set
    End Property
    Public Property Estado() As System.Boolean
        Get
            Return  _Estado
        End Get
        Set(value As System.Boolean)
            _Estado = value
        End Set
    End Property
    Public Property EsOCE() As System.Boolean
        Get
            Return  _EsOCE
        End Get
        Set(value As System.Boolean)
            _EsOCE = value
        End Set
    End Property
    Public Property OCEResolucion() As System.String
        Get
            Return ajustarAncho(_OCEResolucion,25)
        End Get
        Set(value As System.String)
            _OCEResolucion = value
        End Set
    End Property
    Public Property OCEFecha() As System.DateTime
        Get
            Return  _OCEFecha
        End Get
        Set(value As System.DateTime)
            _OCEFecha = value
        End Set
    End Property
    Public Property UsuCreacion() As System.String
        Get
            Return ajustarAncho(_UsuCreacion,25)
        End Get
        Set(value As System.String)
            _UsuCreacion = value
        End Set
    End Property
    Public Property UsuEdicion() As System.String
        Get
            Return ajustarAncho(_UsuEdicion,25)
        End Get
        Set(value As System.String)
            _UsuEdicion = value
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
    Public Property FechaCreacion() As System.DateTime
        Get
            Return  _FechaCreacion
        End Get
        Set(value As System.DateTime)
            _FechaCreacion = value
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
    Public Property FechaAnulacion() As System.DateTime
        Get
            Return  _FechaAnulacion
        End Get
        Set(value As System.DateTime)
            _FechaAnulacion = value
        End Set
    End Property

    Public Property AnioAReportar() As System.Int32
        Get
            Return _AnioAReportar
        End Get
        Set(value As System.Int32)
            _AnioAReportar = value
        End Set
    End Property
    Public Property MesAReportar() As System.Int32
        Get
            Return _MesAReportar
        End Get
        Set(value As System.Int32)
            _MesAReportar = value
        End Set
    End Property

    Public Property AplicaRetencion() As System.Boolean
        Get
            Return _aplicaRetencion
        End Get
        Set(value As System.Boolean)
            _aplicaRetencion = value
        End Set
    End Property
    '
    Public Default Property Item(index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.FactCompID.ToString()
            ElseIf index = 1 Then
                Return Me.EmpresaCodigo.ToString()
            ElseIf index = 2 Then
                Return Me.CAIXSdNID.ToString()
            ElseIf index = 3 Then
                Return Me.NDFEstab.ToString()
            ElseIf index = 4 Then
                Return Me.NDFPuntoEm.ToString()
            ElseIf index = 5 Then
                Return Me.NDFTipoDoc.ToString()
            ElseIf index = 6 Then
                Return Me.NDFCorrelat.ToString()
            ElseIf index = 7 Then
                Return Me.Fecha.ToString()
            ElseIf index = 8 Then
                Return Me.RetencionID.ToString()
            ElseIf index = 9 Then
                Return Me.CAEE.ToString()
            ElseIf index = 10 Then
                Return Me.MontoTotal.ToString()
            ElseIf index = 11 Then
                Return Me.Estado.ToString()
            ElseIf index = 12 Then
                Return Me.EsOCE.ToString()
            ElseIf index = 13 Then
                Return Me.OCEResolucion.ToString()
            ElseIf index = 14 Then
                Return Me.OCEFecha.ToString()
            ElseIf index = 15 Then
                Return Me.UsuCreacion.ToString()
            ElseIf index = 16 Then
                Return Me.UsuEdicion.ToString()
            ElseIf index = 17 Then
                Return Me.UsuAnulacion.ToString()
            ElseIf index = 18 Then
                Return Me.FechaCreacion.ToString()
            ElseIf index = 19 Then
                Return Me.FechaEdicion.ToString()
            ElseIf index = 20 Then
                Return Me.FechaAnulacion.ToString()
            ElseIf index = 21 Then
                Return Me._AnioAReportar.ToString()
            ElseIf index = 22 Then
                Return Me.MesAReportar.ToString()
            ElseIf index = 23 Then
                Return Me.AplicaRetencion.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = 0 Then
                Try
                    Me.FactCompID = System.Int32.Parse("0" & value)
                Catch
                    Me.FactCompID = System.Int32.Parse("0")
                End Try
            ElseIf index = 1 Then
                Me.EmpresaCodigo = value
            ElseIf index = 2 Then
                Try
                    Me.CAIXSdNID = System.Int32.Parse("0" & value)
                Catch
                    Me.CAIXSdNID = System.Int32.Parse("0")
                End Try
            ElseIf index = 3 Then
                Me.NDFEstab = value
            ElseIf index = 4 Then
                Me.NDFPuntoEm = value
            ElseIf index = 5 Then
                Me.NDFTipoDoc = value
            ElseIf index = 6 Then
                Me.NDFCorrelat = value
            ElseIf index = 7 Then
                Try
                    Me.Fecha = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.Fecha = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.Fecha = System.DateTime.Now
                End Try
            ElseIf index = 8 Then
                Try
                    Me.RetencionID = System.Int32.Parse("0" & value)
                Catch
                    Me.RetencionID = System.Int32.Parse("0")
                End Try
            ElseIf index = 9 Then
                Me.CAEE = value
            ElseIf index = 10 Then
                Try
                    Me.MontoTotal = System.Decimal.Parse("0" & value)
                Catch
                    Me.MontoTotal = System.Decimal.Parse("0")
                End Try
            ElseIf index = 11 Then
                Try
                    Me.Estado = System.Boolean.Parse(value)
                Catch
                    Me.Estado = False
                End Try
            ElseIf index = 12 Then
                Try
                    Me.EsOCE = System.Boolean.Parse(value)
                Catch
                    Me.EsOCE = False
                End Try
            ElseIf index = 13 Then
                Me.OCEResolucion = value
            ElseIf index = 14 Then
                Try
                    Me.OCEFecha = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.OCEFecha = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.OCEFecha = System.DateTime.Now
                End Try
            ElseIf index = 15 Then
                Me.UsuCreacion = value
            ElseIf index = 16 Then
                Me.UsuEdicion = value
            ElseIf index = 17 Then
                Me.UsuAnulacion = value
            ElseIf index = 18 Then
                Try
                    Me.FechaCreacion = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaCreacion = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaCreacion = System.DateTime.Now
                End Try
            ElseIf index = 19 Then
                Try
                    Me.FechaEdicion = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaEdicion = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaEdicion = System.DateTime.Now
                End Try
            ElseIf index = 20 Then
                Try
                    Me.FechaAnulacion = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaAnulacion = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaAnulacion = System.DateTime.Now
                End Try
            ElseIf index = 21 Then
                Try
                    Me.AnioAReportar = System.Int32.Parse("0" & value)
                Catch
                    Me.AnioAReportar = System.Int32.Parse("0")
                End Try
            ElseIf index = 22 Then
                Try
                    Me.MesAReportar = System.Int32.Parse("0" & value)
                Catch
                    Me.MesAReportar = System.Int32.Parse("0")
                End Try
            ElseIf index = 23 Then
                Try
                    Me.AplicaRetencion = System.Boolean.Parse(value)
                Catch
                    Me.AplicaRetencion = False
                End Try
            End If
        End Set
    End Property
    Public Default Property Item(index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde al nombre de la columna)
        Get
            If index = "FactCompID" Then
                Return Me.FactCompID.ToString()
            ElseIf index = "EmpresaCodigo" Then
                Return Me.EmpresaCodigo.ToString()
            ElseIf index = "CAIXSdNID" Then
                Return Me.CAIXSdNID.ToString()
            ElseIf index = "NDFEstab" Then
                Return Me.NDFEstab.ToString()
            ElseIf index = "NDFPuntoEm" Then
                Return Me.NDFPuntoEm.ToString()
            ElseIf index = "NDFTipoDoc" Then
                Return Me.NDFTipoDoc.ToString()
            ElseIf index = "NDFCorrelat" Then
                Return Me.NDFCorrelat.ToString()
            ElseIf index = "Fecha" Then
                Return Me.Fecha.ToString()
            ElseIf index = "RetencionID" Then
                Return Me.RetencionID.ToString()
            ElseIf index = "CAEE" Then
                Return Me.CAEE.ToString()
            ElseIf index = "MontoTotal" Then
                Return Me.MontoTotal.ToString()
            ElseIf index = "Estado" Then
                Return Me.Estado.ToString()
            ElseIf index = "EsOCE" Then
                Return Me.EsOCE.ToString()
            ElseIf index = "OCEResolucion" Then
                Return Me.OCEResolucion.ToString()
            ElseIf index = "OCEFecha" Then
                Return Me.OCEFecha.ToString()
            ElseIf index = "UsuCreacion" Then
                Return Me.UsuCreacion.ToString()
            ElseIf index = "UsuEdicion" Then
                Return Me.UsuEdicion.ToString()
            ElseIf index = "UsuAnulacion" Then
                Return Me.UsuAnulacion.ToString()
            ElseIf index = "FechaCreacion" Then
                Return Me.FechaCreacion.ToString()
            ElseIf index = "FechaEdicion" Then
                Return Me.FechaEdicion.ToString()
            ElseIf index = "FechaAnulacion" Then
                Return Me.FechaAnulacion.ToString()
            ElseIf index = "AnioAReportar" Then
                Return Me.AnioAReportar.ToString()
            ElseIf index = "MesAReportar" Then
                Return Me.MesAReportar.ToString()
            ElseIf index = "aplicaRetencion" Then
                Return Me.AplicaRetencion.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = "FactCompID" Then
                Try
                    Me.FactCompID = System.Int32.Parse("0" & value)
                Catch
                    Me.FactCompID = System.Int32.Parse("0")
                End Try
            ElseIf index = "EmpresaCodigo" Then
                Me.EmpresaCodigo = value
            ElseIf index = "CAIXSdNID" Then
                Try
                    Me.CAIXSdNID = System.Int32.Parse("0" & value)
                Catch
                    Me.CAIXSdNID = System.Int32.Parse("0")
                End Try
            ElseIf index = "NDFEstab" Then
                Me.NDFEstab = value
            ElseIf index = "NDFPuntoEm" Then
                Me.NDFPuntoEm = value
            ElseIf index = "NDFTipoDoc" Then
                Me.NDFTipoDoc = value
            ElseIf index = "NDFCorrelat" Then
                Me.NDFCorrelat = value
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
            ElseIf index = "RetencionID" Then
                Try
                    Me.RetencionID = System.Int32.Parse("0" & value)
                Catch
                    Me.RetencionID = System.Int32.Parse("0")
                End Try
            ElseIf index = "CAEE" Then
                Me.CAEE = value
            ElseIf index = "MontoTotal" Then
                Try
                    Me.MontoTotal = System.Decimal.Parse("0" & value)
                Catch
                    Me.MontoTotal = System.Decimal.Parse("0")
                End Try
            ElseIf index = "Estado" Then
                Try
                    Me.Estado = System.Boolean.Parse(value)
                Catch
                    Me.Estado = False
                End Try
            ElseIf index = "EsOCE" Then
                Try
                    Me.EsOCE = System.Boolean.Parse(value)
                Catch
                    Me.EsOCE = False
                End Try
            ElseIf index = "OCEResolucion" Then
                Me.OCEResolucion = value
            ElseIf index = "OCEFecha" Then
                Try
                    Me.OCEFecha = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.OCEFecha = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.OCEFecha = System.DateTime.Now
                End Try
            ElseIf index = "UsuCreacion" Then
                Me.UsuCreacion = value
            ElseIf index = "UsuEdicion" Then
                Me.UsuEdicion = value
            ElseIf index = "UsuAnulacion" Then
                Me.UsuAnulacion = value
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
            ElseIf index = "AnioAReportar" Then
                Try
                    Me.AnioAReportar = System.Int32.Parse("0" & value)
                Catch
                    Me.AnioAReportar = System.Int32.Parse("0")
                End Try
            ElseIf index = "MesAReportar" Then
                Try
                    Me.MesAReportar = System.Int32.Parse("0" & value)
                Catch
                    Me.MesAReportar = System.Int32.Parse("0")
                End Try
            ElseIf index = "aplicaRetencion" Then
                Try
                    Me.AplicaRetencion = System.Boolean.Parse(value)
                Catch
                    Me.AplicaRetencion = False
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
    Public Shared CadenaSelect As String = "SELECT * FROM IDF_FactComp"
    '
    Public Sub New()
    End Sub
    Public Sub New(conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto IDF_FactComp
    Private Shared Function row2IDF_FactComp(r As DataRow) As IDF_FactComp
        ' asigna a un objeto IDF_FactComp los datos del dataRow indicado
        Dim oIDF_FactComp As New IDF_FactComp
        '
        oIDF_FactComp.FactCompID = System.Int32.Parse("0" & r("FactCompID").ToString())
        oIDF_FactComp.EmpresaCodigo = r("EmpresaCodigo").ToString()
        oIDF_FactComp.CAIXSdNID = System.Int32.Parse("0" & r("CAIXSdNID").ToString())
        oIDF_FactComp.NDFEstab = r("NDFEstab").ToString()
        oIDF_FactComp.NDFPuntoEm = r("NDFPuntoEm").ToString()
        oIDF_FactComp.NDFTipoDoc = r("NDFTipoDoc").ToString()
        oIDF_FactComp.NDFCorrelat = r("NDFCorrelat").ToString()
        Try
            oIDF_FactComp.Fecha = DateTime.Parse(r("Fecha").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oIDF_FactComp.Fecha = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oIDF_FactComp.Fecha = DateTime.Now
        End Try
        oIDF_FactComp.RetencionID = System.Int32.Parse("0" & r("RetencionID").ToString())
        oIDF_FactComp.CAEE = r("CAEE").ToString()
        oIDF_FactComp.MontoTotal = System.Decimal.Parse("0" & r("MontoTotal").ToString())
        Try
            oIDF_FactComp.Estado = System.Boolean.Parse(r("Estado").ToString())
        Catch
            oIDF_FactComp.Estado = False
        End Try
        Try
            oIDF_FactComp.EsOCE = System.Boolean.Parse(r("EsOCE").ToString())
        Catch
            oIDF_FactComp.EsOCE = False
        End Try
        oIDF_FactComp.OCEResolucion = r("OCEResolucion").ToString()
        Try
            oIDF_FactComp.OCEFecha = DateTime.Parse(r("OCEFecha").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oIDF_FactComp.OCEFecha = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oIDF_FactComp.OCEFecha = DateTime.Now
        End Try
        oIDF_FactComp.UsuCreacion = r("UsuCreacion").ToString()
        oIDF_FactComp.UsuEdicion = r("UsuEdicion").ToString()
        oIDF_FactComp.UsuAnulacion = r("UsuAnulacion").ToString()
        Try
            oIDF_FactComp.FechaCreacion = DateTime.Parse(r("FechaCreacion").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oIDF_FactComp.FechaCreacion = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oIDF_FactComp.FechaCreacion = DateTime.Now
        End Try
        Try
            oIDF_FactComp.FechaEdicion = DateTime.Parse(r("FechaEdicion").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oIDF_FactComp.FechaEdicion = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oIDF_FactComp.FechaEdicion = DateTime.Now
        End Try
        Try
            oIDF_FactComp.FechaAnulacion = DateTime.Parse(r("FechaAnulacion").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oIDF_FactComp.FechaAnulacion = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oIDF_FactComp.FechaAnulacion = DateTime.Now
        End Try
        oIDF_FactComp.AnioAReportar = System.Int32.Parse("0" & r("AnioAReportar").ToString())
        oIDF_FactComp.MesAReportar = System.Int32.Parse("0" & r("MesAReportar").ToString())

        Try
            oIDF_FactComp.AplicaRetencion = System.Boolean.Parse(r("aplicaRetencion").ToString())
        Catch
            oIDF_FactComp.AplicaRetencion = False
        End Try
        '
        Return oIDF_FactComp
    End Function
    '
    ' asigna un objeto IDF_FactComp a la fila indicada
    Private Shared Sub IDF_FactComp2Row(oIDF_FactComp As IDF_FactComp, r As DataRow)
        ' asigna un objeto IDF_FactComp al dataRow indicado
        ' TODO: Comprueba si esta asignación debe hacerse
        '       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        'r("FactCompID") = oIDF_FactComp.FactCompID
        r("EmpresaCodigo") = oIDF_FactComp.EmpresaCodigo
        r("CAIXSdNID") = oIDF_FactComp.CAIXSdNID
        r("NDFEstab") = oIDF_FactComp.NDFEstab
        r("NDFPuntoEm") = oIDF_FactComp.NDFPuntoEm
        r("NDFTipoDoc") = oIDF_FactComp.NDFTipoDoc
        r("NDFCorrelat") = oIDF_FactComp.NDFCorrelat
        r("Fecha") = oIDF_FactComp.Fecha
        r("RetencionID") = oIDF_FactComp.RetencionID
        r("CAEE") = oIDF_FactComp.CAEE
        r("MontoTotal") = oIDF_FactComp.MontoTotal
        r("Estado") = oIDF_FactComp.Estado
        r("EsOCE") = oIDF_FactComp.EsOCE
        r("OCEResolucion") = oIDF_FactComp.OCEResolucion
        r("OCEFecha") = oIDF_FactComp.OCEFecha
        r("UsuCreacion") = oIDF_FactComp.UsuCreacion
        r("UsuEdicion") = oIDF_FactComp.UsuEdicion
        r("UsuAnulacion") = oIDF_FactComp.UsuAnulacion
        r("FechaCreacion") = oIDF_FactComp.FechaCreacion
        r("FechaEdicion") = oIDF_FactComp.FechaEdicion
        r("FechaAnulacion") = oIDF_FactComp.FechaAnulacion
        r("AnioAReportar") = oIDF_FactComp.AnioAReportar
        r("MesAReportar") = oIDF_FactComp.MesAReportar
        r("aplicaRetencion") = oIDF_FactComp.AplicaRetencion
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto IDF_FactComp
    Private Shared Sub nuevoIDF_FactComp(dt As DataTable, oIDF_FactComp As IDF_FactComp)
        ' Crear un nuevo IDF_FactComp
        Dim dr As DataRow = dt.NewRow()
        Dim oI As IDF_FactComp = row2IDF_FactComp(dr)
        '
        oI.FactCompID = oIDF_FactComp.FactCompID
        oI.EmpresaCodigo = oIDF_FactComp.EmpresaCodigo
        oI.CAIXSdNID = oIDF_FactComp.CAIXSdNID
        oI.NDFEstab = oIDF_FactComp.NDFEstab
        oI.NDFPuntoEm = oIDF_FactComp.NDFPuntoEm
        oI.NDFTipoDoc = oIDF_FactComp.NDFTipoDoc
        oI.NDFCorrelat = oIDF_FactComp.NDFCorrelat
        oI.Fecha = oIDF_FactComp.Fecha
        oI.RetencionID = oIDF_FactComp.RetencionID
        oI.CAEE = oIDF_FactComp.CAEE
        oI.MontoTotal = oIDF_FactComp.MontoTotal
        oI.Estado = oIDF_FactComp.Estado
        oI.EsOCE = oIDF_FactComp.EsOCE
        oI.OCEResolucion = oIDF_FactComp.OCEResolucion
        oI.OCEFecha = oIDF_FactComp.OCEFecha
        oI.UsuCreacion = oIDF_FactComp.UsuCreacion
        oI.UsuEdicion = oIDF_FactComp.UsuEdicion
        oI.UsuAnulacion = oIDF_FactComp.UsuAnulacion
        oI.FechaCreacion = oIDF_FactComp.FechaCreacion
        oI.FechaEdicion = oIDF_FactComp.FechaEdicion
        oI.FechaAnulacion = oIDF_FactComp.FechaAnulacion
        oI.AnioAReportar = oIDF_FactComp.AnioAReportar
        oI.MesAReportar = oIDF_FactComp.MesAReportar
        oI.AplicaRetencion = oIDF_FactComp.AplicaRetencion
        '
        IDF_FactComp2Row(oI, dr)
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
        ' devuelve una tabla con los datos de la tabla IDF_FactComp
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_FactComp")
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
    Public Shared Function Buscar(sWhere As String) As IDF_FactComp
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oIDF_FactComp As IDF_FactComp = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_FactComp")
        Dim sel As String = "SELECT * FROM IDF_FactComp WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oIDF_FactComp = row2IDF_FactComp(dt.Rows(0))
        End If
        Return oIDF_FactComp
    End Function
    '
    ' Actualizar: Actualiza los datos en la tabla usando la instancia actual
    '             Si la instancia no hace referencia a un registro existente, se creará uno nuevo
    '             Para comprobar si el objeto en memoria coincide con uno existente,
    '             se comprueba si el FactCompID existe en la tabla.
    '             TODO: Si en lugar de FactCompID usas otro campo, indicalo en la cadena SELECT
    '                   También puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    Public Function Actualizar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el FactCompID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_FactComp WHERE FactCompID = " & Me.FactCompID.ToString()
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(sel As String) As String
        ' Actualiza los datos indicados
        ' El parámetro, que es una cadena de selección, indicará el criterio de actualización
        '
        ' En caso de error, devolverá la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_FactComp")
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
        '       Yo compruebo que sea un campo llamado FactCompID, pero en tu caso puede ser otro
        '       Ese campo, (en mi caso FactCompID) será el que hay que poner al final junto al WHERE.
        sCommand = "UPDATE IDF_FactComp SET EmpresaCodigo = @EmpresaCodigo, CAIXSdNID = @CAIXSdNID, NDFEstab = @NDFEstab, NDFPuntoEm = @NDFPuntoEm, NDFTipoDoc = @NDFTipoDoc, NDFCorrelat = @NDFCorrelat, Fecha = @Fecha, RetencionID = @RetencionID, CAEE = @CAEE, MontoTotal = @MontoTotal, Estado = @Estado, EsOCE = @EsOCE, OCEResolucion = @OCEResolucion, OCEFecha = @OCEFecha, UsuCreacion = @UsuCreacion, UsuEdicion = @UsuEdicion, UsuAnulacion = @UsuAnulacion, FechaCreacion = @FechaCreacion, FechaEdicion = @FechaEdicion, FechaAnulacion = @FechaAnulacion, AnioAReportar = @AnioAReportar, MesAReportar = @MesAReportar, aplicaRetencion = @aplicaRetencion  WHERE (FactCompID = @FactCompID)"
        da.UpdateCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@FactCompID", SqlDbType.Int, 0, "FactCompID")
        da.UpdateCommand.Parameters.Add("@EmpresaCodigo", SqlDbType.NVarChar, 10, "EmpresaCodigo")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@CAIXSdNID", SqlDbType.Int, 0, "CAIXSdNID")
        da.UpdateCommand.Parameters.Add("@NDFEstab", SqlDbType.NVarChar, 5, "NDFEstab")
        da.UpdateCommand.Parameters.Add("@NDFPuntoEm", SqlDbType.NVarChar, 5, "NDFPuntoEm")
        da.UpdateCommand.Parameters.Add("@NDFTipoDoc", SqlDbType.NVarChar, 5, "NDFTipoDoc")
        da.UpdateCommand.Parameters.Add("@NDFCorrelat", SqlDbType.NVarChar, 8, "NDFCorrelat")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@Fecha", SqlDbType.DateTime, 0, "Fecha")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@RetencionID", SqlDbType.Int, 0, "RetencionID")
        da.UpdateCommand.Parameters.Add("@CAEE", SqlDbType.NVarChar, 25, "CAEE")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@MontoTotal", SqlDbType.Decimal, 0, "MontoTotal")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@Estado", SqlDbType.Bit, 0, "Estado")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@EsOCE", SqlDbType.Bit, 0, "EsOCE")
        da.UpdateCommand.Parameters.Add("@OCEResolucion", SqlDbType.NVarChar, 25, "OCEResolucion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@OCEFecha", SqlDbType.DateTime, 0, "OCEFecha")
        da.UpdateCommand.Parameters.Add("@UsuCreacion", SqlDbType.NVarChar, 25, "UsuCreacion")
        da.UpdateCommand.Parameters.Add("@UsuEdicion", SqlDbType.NVarChar, 25, "UsuEdicion")
        da.UpdateCommand.Parameters.Add("@UsuAnulacion", SqlDbType.NVarChar, 25, "UsuAnulacion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 0, "FechaCreacion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@FechaEdicion", SqlDbType.DateTime, 0, "FechaEdicion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@FechaAnulacion", SqlDbType.DateTime, 0, "FechaAnulacion")
        da.UpdateCommand.Parameters.Add("@AnioAReportar", SqlDbType.Int, 0, "AnioAReportar")
        da.UpdateCommand.Parameters.Add("@MesAReportar", SqlDbType.Int, 0, "MesAReportar")
        da.UpdateCommand.Parameters.Add("@aplicaRetencion", SqlDbType.Bit, 0, "aplicaRetencion")
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
            IDF_FactComp2Row(Me, dt.Rows(0))
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
        Dim dt As New DataTable("IDF_FactComp")
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
        '       Yo compruebo que sea un campo llamado FactCompID, pero en tu caso puede ser otro
        sCommand = "INSERT INTO IDF_FactComp (EmpresaCodigo, CAIXSdNID, NDFEstab, NDFPuntoEm, NDFTipoDoc, NDFCorrelat, Fecha, RetencionID, CAEE, MontoTotal, Estado, EsOCE, OCEResolucion, OCEFecha, UsuCreacion, UsuEdicion, UsuAnulacion, FechaCreacion, FechaEdicion, FechaAnulacion, AnioAReportar, MesAReportar, aplicaRetencion)  VALUES(@EmpresaCodigo, @CAIXSdNID, @NDFEstab, @NDFPuntoEm, @NDFTipoDoc, @NDFCorrelat, @Fecha, @RetencionID, @CAEE, @MontoTotal, @Estado, @EsOCE, @OCEResolucion, @OCEFecha, @UsuCreacion, @UsuEdicion, @UsuAnulacion, @FechaCreacion, @FechaEdicion, @FechaAnulacion, @AnioAReportar, @MesAReportar, @aplicaRetencion)"
        da.InsertCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@FactCompID", SqlDbType.Int, 0, "FactCompID")
        da.InsertCommand.Parameters.Add("@EmpresaCodigo", SqlDbType.NVarChar, 10, "EmpresaCodigo")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@CAIXSdNID", SqlDbType.Int, 0, "CAIXSdNID")
        da.InsertCommand.Parameters.Add("@NDFEstab", SqlDbType.NVarChar, 5, "NDFEstab")
        da.InsertCommand.Parameters.Add("@NDFPuntoEm", SqlDbType.NVarChar, 5, "NDFPuntoEm")
        da.InsertCommand.Parameters.Add("@NDFTipoDoc", SqlDbType.NVarChar, 5, "NDFTipoDoc")
        da.InsertCommand.Parameters.Add("@NDFCorrelat", SqlDbType.NVarChar, 8, "NDFCorrelat")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@Fecha", SqlDbType.DateTime, 0, "Fecha")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@RetencionID", SqlDbType.Int, 0, "RetencionID")
        da.InsertCommand.Parameters.Add("@CAEE", SqlDbType.NVarChar, 25, "CAEE")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@MontoTotal", SqlDbType.Decimal, 0, "MontoTotal")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@Estado", SqlDbType.Bit, 0, "Estado")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@EsOCE", SqlDbType.Bit, 0, "EsOCE")
        da.InsertCommand.Parameters.Add("@OCEResolucion", SqlDbType.NVarChar, 25, "OCEResolucion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@OCEFecha", SqlDbType.DateTime, 0, "OCEFecha")
        da.InsertCommand.Parameters.Add("@UsuCreacion", SqlDbType.NVarChar, 25, "UsuCreacion")
        da.InsertCommand.Parameters.Add("@UsuEdicion", SqlDbType.NVarChar, 25, "UsuEdicion")
        da.InsertCommand.Parameters.Add("@UsuAnulacion", SqlDbType.NVarChar, 25, "UsuAnulacion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 0, "FechaCreacion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@FechaEdicion", SqlDbType.DateTime, 0, "FechaEdicion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@FechaAnulacion", SqlDbType.DateTime, 0, "FechaAnulacion")
        da.InsertCommand.Parameters.Add("@AnioAReportar", SqlDbType.Int, 0, "AnioAReportar")
        da.InsertCommand.Parameters.Add("@MesAReportar", SqlDbType.Int, 0, "MesAReportar")
        da.InsertCommand.Parameters.Add("@aplicaRetencion", SqlDbType.Bit, 0, "aplicaRetencion")
        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoIDF_FactComp(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo IDF_FactComp"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el FactCompID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_FactComp WHERE FactCompID = " & Me.FactCompID.ToString()
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_FactComp")
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
        '       Yo compruebo que sea un campo llamado FactCompID, pero en tu caso puede ser otro
        sCommand = "DELETE FROM IDF_FactComp WHERE (FactCompID = @p1)"
        da.DeleteCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.DeleteCommand.Parameters.Add("@p1", SqlDbType.Int, 0, "FactCompID")
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
