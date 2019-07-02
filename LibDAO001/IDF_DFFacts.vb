'------------------------------------------------------------------------------
' Clase IDF_DFFacts generada automáticamente con CrearClaseSQL
' de la tabla 'IDF_DFFacts' de la base 'Finanzas'
' Fecha: 11/May/2015 08:53:31
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
Public Class IDF_DFFacts
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _DFFactID As System.Int32
    Private _FactNum As System.String
    Private _Descripcion As System.String
    Private _CAI As System.String
    Private _Fecha As System.DateTime
    Private _EmpresaCodigo As System.String
    Private _SdNCodigo As System.String
    Private _TotalBruto As System.Decimal
    Private _DesctoMonto As System.Decimal
    Private _ImptoMonto As System.Decimal
    Private _TotalNeto As System.Decimal
    Private _TerminoCodigo As System.String
    Private _RetencionID As System.Int32
    Private _DFID As System.Int32
    Private _Estado As System.Int32
    Private _EstaImpreso As System.Boolean
    Private _Barco As System.String
    Private _Acuerdo As System.String
    Private _FechaEmbarque As System.DateTime
    Private _PuertoCarga As System.String
    Private _PuertoDescarga As System.String
    Private _ConocimEmbarque As System.String
    Private _FDA As System.String
    Private _CambioDolar As System.Double
    Private _TiposDoctoID As System.Int32
    Private _MonedaCodigo As System.String
    Private _UsuCreador As System.String
    Private _FechaCreacion As System.DateTime
    Private _UsuEditor As System.String
    Private _FechaEdicion As System.DateTime
    Private _UsuAnulacion As System.String
    Private _FechaAnulacion As System.DateTime
    Private _UsuImpresion As System.String
    Private _FechaImpresion As System.DateTime
    Private _NotificarA As System.String
    Private _TotalExento As System.Decimal
    Private _NumeroOrden As System.String
    Private _InfoExtra As System.String
    Private _NConstancia As System.String
    Private _NOCExenta As System.String
    Private _NSAG As System.String


    'Variables publicas
    Public Shared strQuery As String

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
    Public Property DFFactID() As System.Int32
        Get
            Return  _DFFactID
        End Get
        Set(value As System.Int32)
            _DFFactID = value
        End Set
    End Property
    Public Property FactNum() As System.String
        Get
            Return ajustarAncho(_FactNum,25)
        End Get
        Set(value As System.String)
            _FactNum = value
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
            Return ajustarAncho(_EmpresaCodigo,10)
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
    Public Property TotalBruto() As System.Decimal
        Get
            Return  _TotalBruto
        End Get
        Set(value As System.Decimal)
            _TotalBruto = value
        End Set
    End Property
    Public Property DesctoMonto() As System.Decimal
        Get
            Return  _DesctoMonto
        End Get
        Set(value As System.Decimal)
            _DesctoMonto = value
        End Set
    End Property
    Public Property ImptoMonto() As System.Decimal
        Get
            Return  _ImptoMonto
        End Get
        Set(value As System.Decimal)
            _ImptoMonto = value
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
    Public Property TerminoCodigo() As System.String
        Get
            Return ajustarAncho(_TerminoCodigo,10)
        End Get
        Set(value As System.String)
            _TerminoCodigo = value
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
    Public Property DFID() As System.Int32
        Get
            Return  _DFID
        End Get
        Set(value As System.Int32)
            _DFID = value
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
    Public Property EstaImpreso() As System.Boolean
        Get
            Return  _EstaImpreso
        End Get
        Set(value As System.Boolean)
            _EstaImpreso = value
        End Set
    End Property
    Public Property Barco() As System.String
        Get
            Return ajustarAncho(_Barco,50)
        End Get
        Set(value As System.String)
            _Barco = value
        End Set
    End Property
    Public Property Acuerdo() As System.String
        Get
            Return ajustarAncho(_Acuerdo,25)
        End Get
        Set(value As System.String)
            _Acuerdo = value
        End Set
    End Property
    Public Property FechaEmbarque() As System.DateTime
        Get
            Return  _FechaEmbarque
        End Get
        Set(value As System.DateTime)
            _FechaEmbarque = value
        End Set
    End Property
    Public Property PuertoCarga() As System.String
        Get
            Return ajustarAncho(_PuertoCarga,50)
        End Get
        Set(value As System.String)
            _PuertoCarga = value
        End Set
    End Property
    Public Property PuertoDescarga() As System.String
        Get
            Return ajustarAncho(_PuertoDescarga,50)
        End Get
        Set(value As System.String)
            _PuertoDescarga = value
        End Set
    End Property
    Public Property ConocimEmbarque() As System.String
        Get
            Return ajustarAncho(_ConocimEmbarque,50)
        End Get
        Set(value As System.String)
            _ConocimEmbarque = value
        End Set
    End Property
    Public Property FDA() As System.String
        Get
            Return ajustarAncho(_FDA,30)
        End Get
        Set(value As System.String)
            _FDA = value
        End Set
    End Property
    Public Property CambioDolar() As System.Double
        Get
            Return  _CambioDolar
        End Get
        Set(value As System.Double)
            _CambioDolar = value
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

    Public Property NotificarA() As System.String
        Get
            Return ajustarAncho(_NotificarA, 300)
        End Get
        Set(value As System.String)
            _NotificarA = value
        End Set
    End Property

    Public Property TotalExento() As System.Decimal
        Get
            Return _TotalExento
        End Get
        Set(value As System.Decimal)
            _TotalExento = value
        End Set
    End Property

    Public Property NumeroOrden() As System.String
        Get
            Return ajustarAncho(_NumeroOrden, 50)
        End Get
        Set(value As System.String)
            _NumeroOrden = value
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

    Public Property NConstancia() As System.String
        Get
            Return ajustarAncho(_NConstancia, 25)
        End Get
        Set(value As System.String)
            _NConstancia = value
        End Set
    End Property

    Public Property NOCExenta() As System.String
        Get
            Return ajustarAncho(_NOCExenta, 25)
        End Get
        Set(value As System.String)
            _NOCExenta = value
        End Set
    End Property

    Public Property NSAG() As System.String
        Get
            Return ajustarAncho(_NSAG, 25)
        End Get
        Set(value As System.String)
            _NSAG = value
        End Set
    End Property

    '
    Public Default Property Item(index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.DFFactID.ToString()
            ElseIf index = 1 Then
                Return Me.FactNum.ToString()
            ElseIf index = 2 Then
                Return Me.Descripcion.ToString()
            ElseIf index = 3 Then
                Return Me.CAI.ToString()
            ElseIf index = 4 Then
                Return Me.Fecha.ToString()
            ElseIf index = 5 Then
                Return Me.EmpresaCodigo.ToString()
            ElseIf index = 6 Then
                Return Me.SdNCodigo.ToString()
            ElseIf index = 7 Then
                Return Me.TotalBruto.ToString()
            ElseIf index = 8 Then
                Return Me.DesctoMonto.ToString()
            ElseIf index = 9 Then
                Return Me.ImptoMonto.ToString()
            ElseIf index = 10 Then
                Return Me.TotalNeto.ToString()
            ElseIf index = 11 Then
                Return Me.TerminoCodigo.ToString()
            ElseIf index = 12 Then
                Return Me.RetencionID.ToString()
            ElseIf index = 13 Then
                Return Me.DFID.ToString()
            ElseIf index = 14 Then
                Return Me.Estado.ToString()
            ElseIf index = 15 Then
                Return Me.EstaImpreso.ToString()
            ElseIf index = 16 Then
                Return Me.Barco.ToString()
            ElseIf index = 17 Then
                Return Me.Acuerdo.ToString()
            ElseIf index = 18 Then
                Return Me.FechaEmbarque.ToString()
            ElseIf index = 19 Then
                Return Me.PuertoCarga.ToString()
            ElseIf index = 20 Then
                Return Me.PuertoDescarga.ToString()
            ElseIf index = 21 Then
                Return Me.ConocimEmbarque.ToString()
            ElseIf index = 22 Then
                Return Me.FDA.ToString()
            ElseIf index = 23 Then
                Return Me.CambioDolar.ToString()
            ElseIf index = 24 Then
                Return Me.TiposDoctoID.ToString()
            ElseIf index = 25 Then
                Return Me.MonedaCodigo.ToString()
            ElseIf index = 26 Then
                Return Me.UsuCreador.ToString()
            ElseIf index = 27 Then
                Return Me.FechaCreacion.ToString()
            ElseIf index = 28 Then
                Return Me.UsuEditor.ToString()
            ElseIf index = 29 Then
                Return Me.FechaEdicion.ToString()
            ElseIf index = 30 Then
                Return Me.UsuAnulacion.ToString()
            ElseIf index = 31 Then
                Return Me.FechaAnulacion.ToString()
            ElseIf index = 32 Then
                Return Me.UsuImpresion.ToString()
            ElseIf index = 33 Then
                Return Me.FechaImpresion.ToString()
            ElseIf index = 34 Then
                Return Me.NotificarA.ToString()
            ElseIf index = 35 Then
                Return Me.TotalExento.ToString()
            ElseIf index = 36 Then
                Return Me.NumeroOrden.ToString()
            ElseIf index = 37 Then
                Return Me.InfoExtra.ToString()
            ElseIf index = 38 Then
                Return Me.NConstancia.ToString()
            ElseIf index = 39 Then
                Return Me.NOCExenta.ToString()
            ElseIf index = 40 Then
                Return Me.NSAG.ToString()

            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = 0 Then
                Try
                    Me.DFFactID = System.Int32.Parse("0" & value)
                Catch
                    Me.DFFactID = System.Int32.Parse("0")
                End Try
            ElseIf index = 1 Then
                Me.FactNum = value
            ElseIf index = 2 Then
                Me.Descripcion = value
            ElseIf index = 3 Then
                Me.CAI = value
            ElseIf index = 4 Then
                Try
                    Me.Fecha = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.Fecha = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.Fecha = System.DateTime.Now
                End Try
            ElseIf index = 5 Then
                Me.EmpresaCodigo = value
            ElseIf index = 6 Then
                Me.SdNCodigo = value
            ElseIf index = 7 Then
                Try
                    Me.TotalBruto = System.Decimal.Parse("0" & value)
                Catch
                    Me.TotalBruto = System.Decimal.Parse("0")
                End Try
            ElseIf index = 8 Then
                Try
                    Me.DesctoMonto = System.Decimal.Parse("0" & value)
                Catch
                    Me.DesctoMonto = System.Decimal.Parse("0")
                End Try
            ElseIf index = 9 Then
                Try
                    Me.ImptoMonto = System.Decimal.Parse("0" & value)
                Catch
                    Me.ImptoMonto = System.Decimal.Parse("0")
                End Try
            ElseIf index = 10 Then
                Try
                    Me.TotalNeto = System.Decimal.Parse("0" & value)
                Catch
                    Me.TotalNeto = System.Decimal.Parse("0")
                End Try
            ElseIf index = 11 Then
                Me.TerminoCodigo = value
            ElseIf index = 12 Then
                Try
                    Me.RetencionID = System.Int32.Parse("0" & value)
                Catch
                    Me.RetencionID = System.Int32.Parse("0")
                End Try
            ElseIf index = 13 Then
                Try
                    Me.DFID = System.Int32.Parse("0" & value)
                Catch
                    Me.DFID = System.Int32.Parse("0")
                End Try
            ElseIf index = 14 Then
                Try
                    Me.Estado = System.Int32.Parse("0" & value)
                Catch
                    Me.Estado = System.Int32.Parse("0")
                End Try
            ElseIf index = 15 Then
                Try
                    Me.EstaImpreso = System.Boolean.Parse(value)
                Catch
                    Me.EstaImpreso = False
                End Try
            ElseIf index = 16 Then
                Me.Barco = value
            ElseIf index = 17 Then
                Me.Acuerdo = value
            ElseIf index = 18 Then
                Try
                    Me.FechaEmbarque = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaEmbarque = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaEmbarque = System.DateTime.Now
                End Try
            ElseIf index = 19 Then
                Me.PuertoCarga = value
            ElseIf index = 20 Then
                Me.PuertoDescarga = value
            ElseIf index = 21 Then
                Me.ConocimEmbarque = value
            ElseIf index = 22 Then
                Me.FDA = value
            ElseIf index = 23 Then
                Try
                    Me.CambioDolar = System.Double.Parse("0" & value)
                Catch
                    Me.CambioDolar = System.Double.Parse("0")
                End Try
            ElseIf index = 24 Then
                Try
                    Me.TiposDoctoID = System.Int32.Parse("0" & value)
                Catch
                    Me.TiposDoctoID = System.Int32.Parse("0")
                End Try
            ElseIf index = 25 Then
                Me.MonedaCodigo = value
            ElseIf index = 26 Then
                Me.UsuCreador = value
            ElseIf index = 27 Then
                Try
                    Me.FechaCreacion = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaCreacion = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaCreacion = System.DateTime.Now
                End Try
            ElseIf index = 28 Then
                Me.UsuEditor = value
            ElseIf index = 29 Then
                Try
                    Me.FechaEdicion = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaEdicion = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaEdicion = System.DateTime.Now
                End Try
            ElseIf index = 30 Then
                Me.UsuAnulacion = value
            ElseIf index = 31 Then
                Try
                    Me.FechaAnulacion = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaAnulacion = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaAnulacion = System.DateTime.Now
                End Try
            ElseIf index = 32 Then
                Me.UsuImpresion = value
            ElseIf index = 33 Then
                Try
                    Me.FechaImpresion = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaImpresion = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaImpresion = System.DateTime.Now
                End Try
            ElseIf index = 34 Then
                Me.NotificarA = value
            ElseIf index = 35 Then
                Try
                    Me.TotalExento = System.Decimal.Parse("0" & value)
                Catch
                    Me.TotalExento = System.Decimal.Parse("0")
                End Try
            ElseIf index = 36 Then
                Me.NumeroOrden = value
            ElseIf index = 37 Then
                Me.InfoExtra = value
            ElseIf index = 38 Then
                Me.NConstancia = value
            ElseIf index = 39 Then
                Me.NOCExenta = value
            ElseIf index = 40 Then
                Me.NSAG = value
            End If
        End Set
    End Property
    Public Default Property Item(index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde al nombre de la columna)
        Get
            If index = "DFFactID" Then
                Return Me.DFFactID.ToString()
            ElseIf index = "FactNum" Then
                Return Me.FactNum.ToString()
            ElseIf index = "Descripcion" Then
                Return Me.Descripcion.ToString()
            ElseIf index = "CAI" Then
                Return Me.CAI.ToString()
            ElseIf index = "Fecha" Then
                Return Me.Fecha.ToString()
            ElseIf index = "EmpresaCodigo" Then
                Return Me.EmpresaCodigo.ToString()
            ElseIf index = "SdNCodigo" Then
                Return Me.SdNCodigo.ToString()
            ElseIf index = "TotalBruto" Then
                Return Me.TotalBruto.ToString()
            ElseIf index = "DesctoMonto" Then
                Return Me.DesctoMonto.ToString()
            ElseIf index = "ImptoMonto" Then
                Return Me.ImptoMonto.ToString()
            ElseIf index = "TotalNeto" Then
                Return Me.TotalNeto.ToString()
            ElseIf index = "TerminoCodigo" Then
                Return Me.TerminoCodigo.ToString()
            ElseIf index = "RetencionID" Then
                Return Me.RetencionID.ToString()
            ElseIf index = "DFID" Then
                Return Me.DFID.ToString()
            ElseIf index = "Estado" Then
                Return Me.Estado.ToString()
            ElseIf index = "EstaImpreso" Then
                Return Me.EstaImpreso.ToString()
            ElseIf index = "Barco" Then
                Return Me.Barco.ToString()
            ElseIf index = "Acuerdo" Then
                Return Me.Acuerdo.ToString()
            ElseIf index = "FechaEmbarque" Then
                Return Me.FechaEmbarque.ToString()
            ElseIf index = "PuertoCarga" Then
                Return Me.PuertoCarga.ToString()
            ElseIf index = "PuertoDescarga" Then
                Return Me.PuertoDescarga.ToString()
            ElseIf index = "ConocimEmbarque" Then
                Return Me.ConocimEmbarque.ToString()
            ElseIf index = "FDA" Then
                Return Me.FDA.ToString()
            ElseIf index = "CambioDolar" Then
                Return Me.CambioDolar.ToString()
            ElseIf index = "TiposDoctoID" Then
                Return Me.TiposDoctoID.ToString()
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
            ElseIf index = "NotificarA" Then
                Return Me.NotificarA.ToString()
            ElseIf index = "TotalExento" Then
                Return Me.TotalExento.ToString()
            ElseIf index = "NumeroOrden" Then
                Return Me.NumeroOrden.ToString()
            ElseIf index = "InfoExtra" Then
                Return Me.InfoExtra.ToString()
            ElseIf index = "NConstancia" Then
                Return Me.NConstancia.ToString()
            ElseIf index = "NOCExenta" Then
                Return Me.NOCExenta.ToString()
            ElseIf index = "NSAG" Then
                Return Me.NSAG.ToString()

            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = "DFFactID" Then
                Try
                    Me.DFFactID = System.Int32.Parse("0" & value)
                Catch
                    Me.DFFactID = System.Int32.Parse("0")
                End Try
            ElseIf index = "FactNum" Then
                Me.FactNum = value
            ElseIf index = "Descripcion" Then
                Me.Descripcion = value
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
            ElseIf index = "TotalBruto" Then
                Try
                    Me.TotalBruto = System.Decimal.Parse("0" & value)
                Catch
                    Me.TotalBruto = System.Decimal.Parse("0")
                End Try
            ElseIf index = "DesctoMonto" Then
                Try
                    Me.DesctoMonto = System.Decimal.Parse("0" & value)
                Catch
                    Me.DesctoMonto = System.Decimal.Parse("0")
                End Try
            ElseIf index = "ImptoMonto" Then
                Try
                    Me.ImptoMonto = System.Decimal.Parse("0" & value)
                Catch
                    Me.ImptoMonto = System.Decimal.Parse("0")
                End Try
            ElseIf index = "TotalNeto" Then
                Try
                    Me.TotalNeto = System.Decimal.Parse("0" & value)
                Catch
                    Me.TotalNeto = System.Decimal.Parse("0")
                End Try
            ElseIf index = "TerminoCodigo" Then
                Me.TerminoCodigo = value
            ElseIf index = "RetencionID" Then
                Try
                    Me.RetencionID = System.Int32.Parse("0" & value)
                Catch
                    Me.RetencionID = System.Int32.Parse("0")
                End Try
            ElseIf index = "DFID" Then
                Try
                    Me.DFID = System.Int32.Parse("0" & value)
                Catch
                    Me.DFID = System.Int32.Parse("0")
                End Try
            ElseIf index = "Estado" Then
                Try
                    Me.Estado = System.Int32.Parse("0" & value)
                Catch
                    Me.Estado = System.Int32.Parse("0")
                End Try
            ElseIf index = "EstaImpreso" Then
                Try
                    Me.EstaImpreso = System.Boolean.Parse(value)
                Catch
                    Me.EstaImpreso = False
                End Try
            ElseIf index = "Barco" Then
                Me.Barco = value
            ElseIf index = "Acuerdo" Then
                Me.Acuerdo = value
            ElseIf index = "FechaEmbarque" Then
                Try
                    Me.FechaEmbarque = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaEmbarque = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaEmbarque = System.DateTime.Now
                End Try
            ElseIf index = "PuertoCarga" Then
                Me.PuertoCarga = value
            ElseIf index = "PuertoDescarga" Then
                Me.PuertoDescarga = value
            ElseIf index = "ConocimEmbarque" Then
                Me.ConocimEmbarque = value
            ElseIf index = "FDA" Then
                Me.FDA = value
            ElseIf index = "CambioDolar" Then
                Try
                    Me.CambioDolar = System.Double.Parse("0" & value)
                Catch
                    Me.CambioDolar = System.Double.Parse("0")
                End Try
            ElseIf index = "TiposDoctoID" Then
                Try
                    Me.TiposDoctoID = System.Int32.Parse("0" & value)
                Catch
                    Me.TiposDoctoID = System.Int32.Parse("0")
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
            ElseIf index = "NotificarA" Then
                Me.NotificarA = value
            ElseIf index = "TotalExento" Then
                Try
                    Me.TotalExento = System.Decimal.Parse("0" & value)
                Catch
                    Me.TotalExento = System.Decimal.Parse("0")
                End Try
            ElseIf index = "NumeroOrdes" Then
                Me.NumeroOrden = value
            ElseIf index = "InfoExtra" Then
                Me.InfoExtra = value
            ElseIf index = "NConstancia" Then
                Me.NConstancia = value
            ElseIf index = "NOCExenta" Then
                Me.NOCExenta = value
            ElseIf index = "NSAG" Then
                Me.NSAG = value

            End If
        End Set
    End Property
    '
    ' Campos y métodos compartidos (estáticos) para gestionar la base de datos
    '
    ' La cadena de conexión a la base de datos
    Private Shared cadenaConexion As String = "Data Source=amigodb\amigodb; Initial Catalog=Finanzas; user id=rptuser; password=MiTo1380"
    ' La cadena de selección
    Public Shared CadenaSelect As String = "SELECT * FROM IDF_DFFacts"
    '
    Public Sub New()
    End Sub
    Public Sub New(conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto IDF_DFFacts
    Private Shared Function row2IDF_DFFacts(r As DataRow) As IDF_DFFacts
        ' asigna a un objeto IDF_DFFacts los datos del dataRow indicado
        Dim oIDF_DFFacts As New IDF_DFFacts
        '
        oIDF_DFFacts.DFFactID = System.Int32.Parse("0" & r("DFFactID").ToString())
        oIDF_DFFacts.FactNum = r("FactNum").ToString()
        oIDF_DFFacts.Descripcion = r("Descripcion").ToString()
        oIDF_DFFacts.CAI = r("CAI").ToString()
        Try
            oIDF_DFFacts.Fecha = DateTime.Parse(r("Fecha").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oIDF_DFFacts.Fecha = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oIDF_DFFacts.Fecha = DateTime.Now
        End Try
        oIDF_DFFacts.EmpresaCodigo = r("EmpresaCodigo").ToString()
        oIDF_DFFacts.SdNCodigo = r("SdNCodigo").ToString()
        oIDF_DFFacts.TotalBruto = System.Decimal.Parse("0" & r("TotalBruto").ToString())
        oIDF_DFFacts.DesctoMonto = System.Decimal.Parse("0" & r("DesctoMonto").ToString())
        oIDF_DFFacts.ImptoMonto = System.Decimal.Parse("0" & r("ImptoMonto").ToString())
        oIDF_DFFacts.TotalNeto = System.Decimal.Parse("0" & r("TotalNeto").ToString())
        oIDF_DFFacts.TerminoCodigo = r("TerminoCodigo").ToString()
        oIDF_DFFacts.RetencionID = System.Int32.Parse("0" & r("RetencionID").ToString())
        oIDF_DFFacts.DFID = System.Int32.Parse("0" & r("DFID").ToString())
        oIDF_DFFacts.Estado = System.Int32.Parse("0" & r("Estado").ToString())
        Try
            oIDF_DFFacts.EstaImpreso = System.Boolean.Parse(r("EstaImpreso").ToString())
        Catch
            oIDF_DFFacts.EstaImpreso = False
        End Try
        oIDF_DFFacts.Barco = r("Barco").ToString()
        oIDF_DFFacts.Acuerdo = r("Acuerdo").ToString()
        Try
            oIDF_DFFacts.FechaEmbarque = DateTime.Parse(r("FechaEmbarque").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oIDF_DFFacts.FechaEmbarque = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oIDF_DFFacts.FechaEmbarque = DateTime.Now
        End Try
        oIDF_DFFacts.PuertoCarga = r("PuertoCarga").ToString()
        oIDF_DFFacts.PuertoDescarga = r("PuertoDescarga").ToString()
        oIDF_DFFacts.ConocimEmbarque = r("ConocimEmbarque").ToString()
        oIDF_DFFacts.FDA = r("FDA").ToString()
        oIDF_DFFacts.CambioDolar = System.Double.Parse("0" & r("CambioDolar").ToString())
        oIDF_DFFacts.TiposDoctoID = System.Int32.Parse("0" & r("TiposDoctoID").ToString())
        oIDF_DFFacts.MonedaCodigo = r("MonedaCodigo").ToString()
        oIDF_DFFacts.UsuCreador = r("UsuCreador").ToString()
        Try
            oIDF_DFFacts.FechaCreacion = DateTime.Parse(r("FechaCreacion").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oIDF_DFFacts.FechaCreacion = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oIDF_DFFacts.FechaCreacion = DateTime.Now
        End Try
        oIDF_DFFacts.UsuEditor = r("UsuEditor").ToString()
        Try
            oIDF_DFFacts.FechaEdicion = DateTime.Parse(r("FechaEdicion").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oIDF_DFFacts.FechaEdicion = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oIDF_DFFacts.FechaEdicion = DateTime.Now
        End Try
        oIDF_DFFacts.UsuAnulacion = r("UsuAnulacion").ToString()
        Try
            oIDF_DFFacts.FechaAnulacion = DateTime.Parse(r("FechaAnulacion").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oIDF_DFFacts.FechaAnulacion = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oIDF_DFFacts.FechaAnulacion = DateTime.Now
        End Try
        oIDF_DFFacts.UsuImpresion = r("UsuImpresion").ToString()
        Try
            oIDF_DFFacts.FechaImpresion = DateTime.Parse(r("FechaImpresion").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oIDF_DFFacts.FechaImpresion = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oIDF_DFFacts.FechaImpresion = DateTime.Now
        End Try

        oIDF_DFFacts.NotificarA = r("NotificarA").ToString()
        oIDF_DFFacts.TotalExento = System.Decimal.Parse("0" & r("TotalExento").ToString())
        oIDF_DFFacts.NumeroOrden = r("NumeroOrden").ToString()
        oIDF_DFFacts.InfoExtra = r("InfoExtra").ToString()
        oIDF_DFFacts.NConstancia = r("NConstancia").ToString()
        oIDF_DFFacts.NOCExenta = r("NOCExenta").ToString()
        oIDF_DFFacts.NSAG = r("NSAG").ToString()
        '
        Return oIDF_DFFacts
    End Function
    '
    ' asigna un objeto IDF_DFFacts a la fila indicada
    Private Shared Sub IDF_DFFacts2Row(oIDF_DFFacts As IDF_DFFacts, r As DataRow)
        ' asigna un objeto IDF_DFFacts al dataRow indicado
        ' TODO: Comprueba si esta asignación debe hacerse
        '       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        'r("DFFactID") = oIDF_DFFacts.DFFactID
        r("FactNum") = oIDF_DFFacts.FactNum
        r("Descripcion") = oIDF_DFFacts.Descripcion
        r("CAI") = oIDF_DFFacts.CAI
        r("Fecha") = oIDF_DFFacts.Fecha
        r("EmpresaCodigo") = oIDF_DFFacts.EmpresaCodigo
        r("SdNCodigo") = oIDF_DFFacts.SdNCodigo
        r("TotalBruto") = oIDF_DFFacts.TotalBruto
        r("DesctoMonto") = oIDF_DFFacts.DesctoMonto
        r("ImptoMonto") = oIDF_DFFacts.ImptoMonto
        r("TotalNeto") = oIDF_DFFacts.TotalNeto
        r("TerminoCodigo") = oIDF_DFFacts.TerminoCodigo
        r("RetencionID") = oIDF_DFFacts.RetencionID
        r("DFID") = oIDF_DFFacts.DFID
        r("Estado") = oIDF_DFFacts.Estado
        r("EstaImpreso") = oIDF_DFFacts.EstaImpreso
        r("Barco") = oIDF_DFFacts.Barco
        r("Acuerdo") = oIDF_DFFacts.Acuerdo
        r("FechaEmbarque") = oIDF_DFFacts.FechaEmbarque
        r("PuertoCarga") = oIDF_DFFacts.PuertoCarga
        r("PuertoDescarga") = oIDF_DFFacts.PuertoDescarga
        r("ConocimEmbarque") = oIDF_DFFacts.ConocimEmbarque
        r("FDA") = oIDF_DFFacts.FDA
        r("CambioDolar") = oIDF_DFFacts.CambioDolar
        r("TiposDoctoID") = oIDF_DFFacts.TiposDoctoID
        r("MonedaCodigo") = oIDF_DFFacts.MonedaCodigo
        r("UsuCreador") = oIDF_DFFacts.UsuCreador
        r("FechaCreacion") = oIDF_DFFacts.FechaCreacion
        r("UsuEditor") = oIDF_DFFacts.UsuEditor
        r("FechaEdicion") = oIDF_DFFacts.FechaEdicion
        r("UsuAnulacion") = oIDF_DFFacts.UsuAnulacion
        r("FechaAnulacion") = oIDF_DFFacts.FechaAnulacion
        r("UsuImpresion") = oIDF_DFFacts.UsuImpresion
        r("FechaImpresion") = oIDF_DFFacts.FechaImpresion
        r("NotificarA") = oIDF_DFFacts.NotificarA
        r("TotalExento") = oIDF_DFFacts.TotalExento
        r("NumeroOrden") = oIDF_DFFacts.NumeroOrden
        r("InfoExtra") = oIDF_DFFacts.InfoExtra
        r("NConstancia") = oIDF_DFFacts.NConstancia
        r("NOCExenta") = oIDF_DFFacts.NOCExenta
        r("NSAG") = oIDF_DFFacts.NSAG
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto IDF_DFFacts
    Private Shared Sub nuevoIDF_DFFacts(dt As DataTable, oIDF_DFFacts As IDF_DFFacts)
        ' Crear un nuevo IDF_DFFacts
        Dim dr As DataRow = dt.NewRow()
        Dim oI As IDF_DFFacts = row2IDF_DFFacts(dr)
        '
        oI.DFFactID = oIDF_DFFacts.DFFactID
        oI.FactNum = oIDF_DFFacts.FactNum
        oI.Descripcion = oIDF_DFFacts.Descripcion
        oI.CAI = oIDF_DFFacts.CAI
        oI.Fecha = oIDF_DFFacts.Fecha
        oI.EmpresaCodigo = oIDF_DFFacts.EmpresaCodigo
        oI.SdNCodigo = oIDF_DFFacts.SdNCodigo
        oI.TotalBruto = oIDF_DFFacts.TotalBruto
        oI.DesctoMonto = oIDF_DFFacts.DesctoMonto
        oI.ImptoMonto = oIDF_DFFacts.ImptoMonto
        oI.TotalNeto = oIDF_DFFacts.TotalNeto
        oI.TerminoCodigo = oIDF_DFFacts.TerminoCodigo
        oI.RetencionID = oIDF_DFFacts.RetencionID
        oI.DFID = oIDF_DFFacts.DFID
        oI.Estado = oIDF_DFFacts.Estado
        oI.EstaImpreso = oIDF_DFFacts.EstaImpreso
        oI.Barco = oIDF_DFFacts.Barco
        oI.Acuerdo = oIDF_DFFacts.Acuerdo
        oI.FechaEmbarque = oIDF_DFFacts.FechaEmbarque
        oI.PuertoCarga = oIDF_DFFacts.PuertoCarga
        oI.PuertoDescarga = oIDF_DFFacts.PuertoDescarga
        oI.ConocimEmbarque = oIDF_DFFacts.ConocimEmbarque
        oI.FDA = oIDF_DFFacts.FDA
        oI.CambioDolar = oIDF_DFFacts.CambioDolar
        oI.TiposDoctoID = oIDF_DFFacts.TiposDoctoID
        oI.MonedaCodigo = oIDF_DFFacts.MonedaCodigo
        oI.UsuCreador = oIDF_DFFacts.UsuCreador
        oI.FechaCreacion = oIDF_DFFacts.FechaCreacion
        oI.UsuEditor = oIDF_DFFacts.UsuEditor
        oI.FechaEdicion = oIDF_DFFacts.FechaEdicion
        oI.UsuAnulacion = oIDF_DFFacts.UsuAnulacion
        oI.FechaAnulacion = oIDF_DFFacts.FechaAnulacion
        oI.UsuImpresion = oIDF_DFFacts.UsuImpresion
        oI.FechaImpresion = oIDF_DFFacts.FechaImpresion
        oI.NotificarA = oIDF_DFFacts.NotificarA
        oI.TotalExento = oIDF_DFFacts.TotalExento
        oI.NumeroOrden = oIDF_DFFacts.NumeroOrden
        oI.InfoExtra = oIDF_DFFacts.InfoExtra
        oI.NConstancia = oIDF_DFFacts.NConstancia
        oI.NOCExenta = oIDF_DFFacts.NOCExenta
        oI.NSAG = oIDF_DFFacts.NSAG
        '
        IDF_DFFacts2Row(oI, dr)
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
        ' devuelve una tabla con los datos de la tabla IDF_DFFacts
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_DFFacts")
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
    Public Shared Function Buscar(sWhere As String) As IDF_DFFacts
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oIDF_DFFacts As IDF_DFFacts = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_DFFacts")
        Dim sel As String = "SELECT * FROM IDF_DFFacts WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oIDF_DFFacts = row2IDF_DFFacts(dt.Rows(0))
        End If
        Return oIDF_DFFacts
    End Function
    '
    ' Actualizar: Actualiza los datos en la tabla usando la instancia actual
    '             Si la instancia no hace referencia a un registro existente, se creará uno nuevo
    '             Para comprobar si el objeto en memoria coincide con uno existente,
    '             se comprueba si el DFFactID existe en la tabla.
    '             TODO: Si en lugar de DFFactID usas otro campo, indicalo en la cadena SELECT
    '                   También puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    Public Function Actualizar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el DFFactID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_DFFacts WHERE DFFactID = " & Me.DFFactID.ToString()
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(sel As String) As String
        ' Actualiza los datos indicados
        ' El parámetro, que es una cadena de selección, indicará el criterio de actualización
        '
        ' En caso de error, devolverá la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_DFFacts")
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
        '       Yo compruebo que sea un campo llamado DFFactID, pero en tu caso puede ser otro
        '       Ese campo, (en mi caso DFFactID) será el que hay que poner al final junto al WHERE.
        sCommand = "UPDATE IDF_DFFacts SET FactNum = @FactNum, Descripcion = @Descripcion, CAI = @CAI, Fecha = @Fecha, EmpresaCodigo = @EmpresaCodigo, SdNCodigo = @SdNCodigo, TotalBruto = @TotalBruto, DesctoMonto = @DesctoMonto, ImptoMonto = @ImptoMonto, TotalNeto = @TotalNeto, TerminoCodigo = @TerminoCodigo, RetencionID = @RetencionID, DFID = @DFID, Estado = @Estado, EstaImpreso = @EstaImpreso, Barco = @Barco, Acuerdo = @Acuerdo, FechaEmbarque = @FechaEmbarque, PuertoCarga = @PuertoCarga, PuertoDescarga = @PuertoDescarga, ConocimEmbarque = @ConocimEmbarque, FDA = @FDA, CambioDolar = @CambioDolar, TiposDoctoID = @TiposDoctoID, MonedaCodigo = @MonedaCodigo, UsuCreador = @UsuCreador, FechaCreacion = @FechaCreacion, UsuEditor = @UsuEditor, FechaEdicion = @FechaEdicion, UsuAnulacion = @UsuAnulacion, FechaAnulacion = @FechaAnulacion, UsuImpresion = @UsuImpresion, FechaImpresion = @FechaImpresion, NotificarA = @NotificarA, TotalExento = @TotalExento , NumeroOrden = @NumeroOrden, InfoExtra = @InfoExtra, NConstancia=@NConstancia, NOCExenta=@NOCExenta, NSAG=@NSAG WHERE (DFFactID = @DFFactID)"
        da.UpdateCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@DFFactID", SqlDbType.Int, 0, "DFFactID")
        da.UpdateCommand.Parameters.Add("@FactNum", SqlDbType.NVarChar, 25, "FactNum")
        da.UpdateCommand.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 50, "Descripcion")
        da.UpdateCommand.Parameters.Add("@CAI", SqlDbType.NVarChar, 60, "CAI")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@Fecha", SqlDbType.DateTime, 0, "Fecha")
        da.UpdateCommand.Parameters.Add("@EmpresaCodigo", SqlDbType.NVarChar, 10, "EmpresaCodigo")
        da.UpdateCommand.Parameters.Add("@SdNCodigo", SqlDbType.NVarChar, 10, "SdNCodigo")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@TotalBruto", SqlDbType.Decimal, 0, "TotalBruto")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@DesctoMonto", SqlDbType.Decimal, 0, "DesctoMonto")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@ImptoMonto", SqlDbType.Decimal, 0, "ImptoMonto")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@TotalNeto", SqlDbType.Decimal, 0, "TotalNeto")
        da.UpdateCommand.Parameters.Add("@TerminoCodigo", SqlDbType.NVarChar, 10, "TerminoCodigo")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@RetencionID", SqlDbType.Int, 0, "RetencionID")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@DFID", SqlDbType.Int, 0, "DFID")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@Estado", SqlDbType.Int, 0, "Estado")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@EstaImpreso", SqlDbType.Bit, 0, "EstaImpreso")
        da.UpdateCommand.Parameters.Add("@Barco", SqlDbType.NVarChar, 50, "Barco")
        da.UpdateCommand.Parameters.Add("@Acuerdo", SqlDbType.NVarChar, 25, "Acuerdo")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@FechaEmbarque", SqlDbType.DateTime, 0, "FechaEmbarque")
        da.UpdateCommand.Parameters.Add("@PuertoCarga", SqlDbType.NVarChar, 50, "PuertoCarga")
        da.UpdateCommand.Parameters.Add("@PuertoDescarga", SqlDbType.NVarChar, 50, "PuertoDescarga")
        da.UpdateCommand.Parameters.Add("@ConocimEmbarque", SqlDbType.NVarChar, 50, "ConocimEmbarque")
        da.UpdateCommand.Parameters.Add("@FDA", SqlDbType.NVarChar, 30, "FDA")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@CambioDolar", SqlDbType.Float, 0, "CambioDolar")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@TiposDoctoID", SqlDbType.Int, 0, "TiposDoctoID")
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
        da.UpdateCommand.Parameters.Add("@NotificarA", SqlDbType.NVarChar, 300, "NotificarA")
        da.UpdateCommand.Parameters.Add("@TotalExento", SqlDbType.Decimal, 0, "TotalExento")
        da.UpdateCommand.Parameters.Add("@NumeroOrden", SqlDbType.NVarChar, 50, "NumeroOrden")
        da.UpdateCommand.Parameters.Add("@InfoExtra", SqlDbType.NVarChar, 800, "InfoExtra")
        da.UpdateCommand.Parameters.Add("@NConstancia", SqlDbType.NVarChar, 25, "NConstancia")
        da.UpdateCommand.Parameters.Add("@NOCExenta", SqlDbType.NVarChar, 25, "NOCExenta")
        da.UpdateCommand.Parameters.Add("@NSAG", SqlDbType.NVarChar, 25, "NSAG")

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
            IDF_DFFacts2Row(Me, dt.Rows(0))
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
        Dim dt As New DataTable("IDF_DFFacts")
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
        '       Yo compruebo que sea un campo llamado DFFactID, pero en tu caso puede ser otro
        'sCommand = "INSERT INTO IDF_DFFacts (FactNum, Descripcion, CAI, Fecha, EmpresaCodigo, SdNCodigo, TotalBruto, DesctoMonto, ImptoMonto, TotalNeto, TerminoCodigo, RetencionID, DFID, Estado, EstaImpreso, Barco, Acuerdo, FechaEmbarque, PuertoCarga, PuertoDescarga, ConocimEmbarque, FDA, CambioDolar, TiposDoctoID, MonedaCodigo, UsuCreador, FechaCreacion, UsuEditor, FechaEdicion, UsuAnulacion, FechaAnulacion, UsuImpresion, FechaImpresion,NotificarA,TotalExento,NumeroOrden,InfoExtra,NConstancia, NOCExenta, NSAG)  VALUES(@FactNum, @Descripcion, @CAI, @Fecha, @EmpresaCodigo, @SdNCodigo, @TotalBruto, @DesctoMonto, @ImptoMonto, @TotalNeto, @TerminoCodigo, @RetencionID, @DFID, @Estado, @EstaImpreso, @Barco, @Acuerdo, @FechaEmbarque, @PuertoCarga, @PuertoDescarga, @ConocimEmbarque, @FDA, @CambioDolar, @TiposDoctoID, @MonedaCodigo, @UsuCreador, @FechaCreacion, @UsuEditor, @FechaEdicion, @UsuAnulacion, @FechaAnulacion, @UsuImpresion, @FechaImpresion,@NotificarA,@TotalExento,@NumeroOrden,@InfoExtra, @NConstancia, @NOCExenta, @NSAG) "
        sCommand = "spIDF_DFFactsInsert" 'Cambio Ariel cabrera 17/6/2019  
        da.InsertCommand = New SqlCommand(sCommand, cnn)
        da.InsertCommand.CommandType = CommandType.StoredProcedure
        ' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@DFFactID", SqlDbType.Int, 0, "DFFactID")     '' Cambio    
        'da.InsertCommand.Parameters.Add("@FactNum", SqlDbType.NVarChar, 25, "FactNum") ''Cambio
        da.InsertCommand.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 50, "Descripcion")
        da.InsertCommand.Parameters.Add("@CAI", SqlDbType.NVarChar, 60, "CAI")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@Fecha", SqlDbType.DateTime, 0, "Fecha")
        da.InsertCommand.Parameters.Add("@EmpresaCodigo", SqlDbType.NVarChar, 10, "EmpresaCodigo")
        da.InsertCommand.Parameters.Add("@SdNCodigo", SqlDbType.NVarChar, 10, "SdNCodigo")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@TotalBruto", SqlDbType.Decimal, 0, "TotalBruto")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@DesctoMonto", SqlDbType.Decimal, 0, "DesctoMonto")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@ImptoMonto", SqlDbType.Decimal, 0, "ImptoMonto")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@TotalNeto", SqlDbType.Decimal, 0, "TotalNeto")
        da.InsertCommand.Parameters.Add("@TerminoCodigo", SqlDbType.NVarChar, 10, "TerminoCodigo")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@RetencionID", SqlDbType.Int, 0, "RetencionID")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@DFID", SqlDbType.Int, 0, "DFID")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@Estado", SqlDbType.Int, 0, "Estado")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@EstaImpreso", SqlDbType.Bit, 0, "EstaImpreso")
        da.InsertCommand.Parameters.Add("@Barco", SqlDbType.NVarChar, 50, "Barco")
        da.InsertCommand.Parameters.Add("@Acuerdo", SqlDbType.NVarChar, 25, "Acuerdo")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@FechaEmbarque", SqlDbType.DateTime, 0, "FechaEmbarque")
        da.InsertCommand.Parameters.Add("@PuertoCarga", SqlDbType.NVarChar, 50, "PuertoCarga")
        da.InsertCommand.Parameters.Add("@PuertoDescarga", SqlDbType.NVarChar, 50, "PuertoDescarga")
        da.InsertCommand.Parameters.Add("@ConocimEmbarque", SqlDbType.NVarChar, 50, "ConocimEmbarque")
        da.InsertCommand.Parameters.Add("@FDA", SqlDbType.NVarChar, 30, "FDA")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@CambioDolar", SqlDbType.Float, 0, "CambioDolar")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@TiposDoctoID", SqlDbType.Int, 0, "TiposDoctoID")
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
        da.InsertCommand.Parameters.Add("@NotificarA", SqlDbType.NVarChar, 300, "NotificarA")
        da.InsertCommand.Parameters.Add("@TotalExento", SqlDbType.Decimal, 0, "TotalExento")
        da.InsertCommand.Parameters.Add("@NumeroOrden", SqlDbType.NVarChar, 50, "NumeroOrden")
        da.InsertCommand.Parameters.Add("@InfoExtra", SqlDbType.NVarChar, 800, "InfoExtra")
        da.InsertCommand.Parameters.Add("@NConstancia", SqlDbType.NVarChar, 800, "NConstancia")
        da.InsertCommand.Parameters.Add("@NOCExenta", SqlDbType.NVarChar, 800, "NOCExenta")
        da.InsertCommand.Parameters.Add("@NSAG", SqlDbType.NVarChar, 800, "NSAG")

        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoIDF_DFFacts(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo IDF_DFFacts"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el DFFactID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_DFFacts WHERE DFFactID = " & Me.DFFactID.ToString()
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_DFFacts")
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
        '       Yo compruebo que sea un campo llamado DFFactID, pero en tu caso puede ser otro
        sCommand = "DELETE FROM IDF_DFFacts WHERE (DFFactID = @p1)"
        da.DeleteCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.DeleteCommand.Parameters.Add("@p1", SqlDbType.Int, 0, "DFFactID")
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
    Public Shared Function SigDFFact(nIntT As Integer, strEmpresa As String) As Integer
        Dim nRes = 0
        Try
            ' Busca en la tabla los datos indicados en el parámetro
            ' el parámetro contendrá lo que se usará después del WHERE
            Dim oIDF_DFFacts As IDF_DFFacts = Nothing
            Dim da As SqlDataAdapter
            Dim dt As New DataTable("IDF_DFFacts")
            Dim sel As String = "SELECT Top 1 FactNum FROM IDF_DFFacts Order by FactNum Desc "
            '
            If nIntT = 1 Or nIntT = 7 Then
                sel = "SELECT Top 1 FactNum FROM IDF_DFFacts Where TiposDoctoID in (1,7) and EmpresaCodigo = '" & strEmpresa & "' Order by FactNum Desc "
            End If

            If nIntT = 8 Then
                'Tratamiento para la boleta de venta
                sel = "SELECT Top 1 FactNum FROM IDF_DFFacts Where TiposDoctoID in (8) and EmpresaCodigo = '" & strEmpresa & "' Order by FactNum Desc "
            End If


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

    Public Shared Function SigDFFactCAI(nIntT As Integer,
                                        strEmpresa As String,
                                        strCAI As String) As Integer
        Dim nRes = 0
        Try
            ' Busca en la tabla los datos indicados en el parámetro
            ' el parámetro contendrá lo que se usará después del WHERE
            Dim oIDF_DFDescrip As IDF_DFDescrip = Nothing
            Dim da As SqlDataAdapter
            Dim dt As New DataTable("IDF_DFFacts")
            Dim sel As String

            'sel = "SELECT Top 1 DFNum FROM IDF_DFDescrip " & _
            '      "Where TiposDoctoID ='" & nIntT & _
            '      "' and EmpresaCodigo = '" & strEmpresa & _
            '      "' AND CAI = '" & strCAI & "'" & _
            '      " Order by DFNum Desc "
            '
            strQuery = ""
            If nIntT = 1 Or nIntT = 7 Then
                strQuery = "SELECT Top 1 FactNum FROM IDF_DFFacts " & _
                      "Where TiposDoctoID in (1,7) and EmpresaCodigo = '" & strEmpresa & _
                      "' AND CAI = '" & strCAI & "'" & _
                      " Order by FactNum Desc "
            End If

            If nIntT = 8 Then
                'Tratamiento para la boleta de venta
                strQuery = "SELECT Top 1 FactNum FROM IDF_DFFacts " & _
                      "Where TiposDoctoID in (8) and EmpresaCodigo = '" & strEmpresa & _
                      "' AND CAI = '" & strCAI & "'" & _
                      " Order by FactNum Desc "
            End If

            If nIntT = 9 Then
                'Tratamiento para la boleta de compra
                strQuery = "SELECT Top 1 FactNum FROM IDF_DFFacts " & _
                      "Where TiposDoctoID in (9) and EmpresaCodigo = '" & strEmpresa & _
                      "' AND CAI = '" & strCAI & "'" & _
                      " Order by FactNum Desc "
            End If

            da = New SqlDataAdapter(strQuery, cadenaConexion)
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
