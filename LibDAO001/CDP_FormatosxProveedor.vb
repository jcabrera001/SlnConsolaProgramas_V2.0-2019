'------------------------------------------------------------------------------
' Clase CDP_FormatosxProveedor generada automáticamente con CrearClaseSQL
' de la tabla 'CDP_FormatosxProveedor' de la base 'Finanzas'
' Fecha: 17/Jun/2015 11:00:28
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
Public Class CDP_FormatosxProveedor
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
    Private _FormatoID As System.Int32
    Private _EmpresaCodigo As System.String
    Private _Descripcion As System.String
    Private _AplicaNumeracion As System.Boolean
    Private _AplicaCtaBancaria As System.Boolean
    Private _AplicaImpDespacho As System.Boolean
    Private _Especificaciones As System.String
    Private _Utilizacion As System.String
    Private _UsuarioResponsable As System.String
    Private _UsuarioSolicitador As System.String
    Private _UsuarioCreador As System.String
    Private _FechaCreacion As System.DateTime
    Private _UsuarioEditor As System.String
    Private _FechaEdicion As System.DateTime
    Private _FormatoxProveedorID As System.Int32
    Private _ProveedorCodigo As System.String
    Private _NumDesde As System.Int64
    Private _NumHasta As System.Int64
    Private _NumCantidad As System.Int64
    Private _NumCajas As System.Int32
    Private _UnidXCaja As System.Int64
    Private _Costo As System.Int64
    Private _FacturaReferencia As System.String
    Private _DFProteanFxP As System.Int32
    Private _PagoReferencia As System.String
    Private _DFProteanChk As System.Int32
    Private _FechaPedido As System.DateTime
    Private _FechaEntregaEstimada As System.DateTime
    Private _estaPedido As System.Boolean
    Private _estaRecibido As System.Boolean
    Private _estaConsumido As System.Boolean
    Private _CuentaBancariaID As System.Int32
    Private _UbicacionID As System.Int32
    Private _Observaciones As System.String
    Private _UsuarioReceptor As System.String
    Private _FechaRecibido As System.DateTime
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
    Public Property FormatoID() As System.Int32
        Get
            Return _FormatoID
        End Get
        Set(value As System.Int32)
            _FormatoID = value
        End Set
    End Property
    Public Property EmpresaCodigo() As System.String
        Get
            Return ajustarAncho(_EmpresaCodigo, 2)
        End Get
        Set(value As System.String)
            _EmpresaCodigo = value
        End Set
    End Property
    Public Property Descripcion() As System.String
        Get
            Return ajustarAncho(_Descripcion, 50)
        End Get
        Set(value As System.String)
            _Descripcion = value
        End Set
    End Property
    Public Property AplicaNumeracion() As System.Boolean
        Get
            Return _AplicaNumeracion
        End Get
        Set(value As System.Boolean)
            _AplicaNumeracion = value
        End Set
    End Property
    Public Property AplicaCtaBancaria() As System.Boolean
        Get
            Return _AplicaCtaBancaria
        End Get
        Set(value As System.Boolean)
            _AplicaCtaBancaria = value
        End Set
    End Property
    Public Property AplicaImpDespacho() As System.Boolean
        Get
            Return _AplicaImpDespacho
        End Get
        Set(value As System.Boolean)
            _AplicaImpDespacho = value
        End Set
    End Property
    Public Property Especificaciones() As System.String
        Get
            Return ajustarAncho(_Especificaciones, 200)
        End Get
        Set(value As System.String)
            _Especificaciones = value
        End Set
    End Property
    Public Property Utilizacion() As System.String
        Get
            Return ajustarAncho(_Utilizacion, 200)
        End Get
        Set(value As System.String)
            _Utilizacion = value
        End Set
    End Property
    Public Property UsuarioResponsable() As System.String
        Get
            Return ajustarAncho(_UsuarioResponsable, 25)
        End Get
        Set(value As System.String)
            _UsuarioResponsable = value
        End Set
    End Property
    Public Property UsuarioSolicitador() As System.String
        Get
            Return ajustarAncho(_UsuarioSolicitador, 25)
        End Get
        Set(value As System.String)
            _UsuarioSolicitador = value
        End Set
    End Property
    Public Property UsuarioCreador() As System.String
        Get
            Return ajustarAncho(_UsuarioCreador, 25)
        End Get
        Set(value As System.String)
            _UsuarioCreador = value
        End Set
    End Property
    Public Property FechaCreacion() As System.DateTime
        Get
            Return _FechaCreacion
        End Get
        Set(value As System.DateTime)
            _FechaCreacion = value
        End Set
    End Property
    Public Property UsuarioEditor() As System.String
        Get
            Return ajustarAncho(_UsuarioEditor, 25)
        End Get
        Set(value As System.String)
            _UsuarioEditor = value
        End Set
    End Property
    Public Property FechaEdicion() As System.DateTime
        Get
            Return _FechaEdicion
        End Get
        Set(value As System.DateTime)
            _FechaEdicion = value
        End Set
    End Property
    Public Property FormatoxProveedorID() As System.Int32
        Get
            Return _FormatoxProveedorID
        End Get
        Set(value As System.Int32)
            _FormatoxProveedorID = value
        End Set
    End Property
    Public Property ProveedorCodigo() As System.String
        Get
            Return ajustarAncho(_ProveedorCodigo, 6)
        End Get
        Set(value As System.String)
            _ProveedorCodigo = value
        End Set
    End Property
    Public Property NumDesde() As System.Int64
        Get
            Return _NumDesde
        End Get
        Set(value As System.Int64)
            _NumDesde = value
        End Set
    End Property
    Public Property NumHasta() As System.Int64
        Get
            Return _NumHasta
        End Get
        Set(value As System.Int64)
            _NumHasta = value
        End Set
    End Property
    Public Property NumCantidad() As System.Int64
        Get
            Return _NumCantidad
        End Get
        Set(value As System.Int64)
            _NumCantidad = value
        End Set
    End Property
    Public Property NumCajas() As System.Int32
        Get
            Return _NumCajas
        End Get
        Set(value As System.Int32)
            _NumCajas = value
        End Set
    End Property
    Public Property UnidXCaja() As System.Int64
        Get
            Return _UnidXCaja
        End Get
        Set(value As System.Int64)
            _UnidXCaja = value
        End Set
    End Property
    Public Property Costo() As System.Int64
        Get
            Return _Costo
        End Get
        Set(value As System.Int64)
            _Costo = value
        End Set
    End Property
    Public Property FacturaReferencia() As System.String
        Get
            Return ajustarAncho(_FacturaReferencia, 50)
        End Get
        Set(value As System.String)
            _FacturaReferencia = value
        End Set
    End Property
    Public Property DFProteanFxP() As System.Int32
        Get
            Return _DFProteanFxP
        End Get
        Set(value As System.Int32)
            _DFProteanFxP = value
        End Set
    End Property
    Public Property PagoReferencia() As System.String
        Get
            Return ajustarAncho(_PagoReferencia, 10)
        End Get
        Set(value As System.String)
            _PagoReferencia = value
        End Set
    End Property
    Public Property DFProteanChk() As System.Int32
        Get
            Return _DFProteanChk
        End Get
        Set(value As System.Int32)
            _DFProteanChk = value
        End Set
    End Property
    Public Property FechaPedido() As System.DateTime
        Get
            Return _FechaPedido
        End Get
        Set(value As System.DateTime)
            _FechaPedido = value
        End Set
    End Property
    Public Property FechaEntregaEstimada() As System.DateTime
        Get
            Return _FechaEntregaEstimada
        End Get
        Set(value As System.DateTime)
            _FechaEntregaEstimada = value
        End Set
    End Property
    Public Property estaPedido() As System.Boolean
        Get
            Return _estaPedido
        End Get
        Set(value As System.Boolean)
            _estaPedido = value
        End Set
    End Property
    Public Property estaRecibido() As System.Boolean
        Get
            Return _estaRecibido
        End Get
        Set(value As System.Boolean)
            _estaRecibido = value
        End Set
    End Property
    Public Property estaConsumido() As System.Boolean
        Get
            Return _estaConsumido
        End Get
        Set(value As System.Boolean)
            _estaConsumido = value
        End Set
    End Property
    Public Property CuentaBancariaID() As System.Int32
        Get
            Return _CuentaBancariaID
        End Get
        Set(value As System.Int32)
            _CuentaBancariaID = value
        End Set
    End Property
    Public Property UbicacionID() As System.Int32
        Get
            Return _UbicacionID
        End Get
        Set(value As System.Int32)
            _UbicacionID = value
        End Set
    End Property
    Public Property Observaciones() As System.String
        Get
            Return ajustarAncho(_Observaciones, 200)
        End Get
        Set(value As System.String)
            _Observaciones = value
        End Set
    End Property
    Public Property UsuarioReceptor() As System.String
        Get
            Return ajustarAncho(_UsuarioReceptor, 25)
        End Get
        Set(value As System.String)
            _UsuarioReceptor = value
        End Set
    End Property
    Public Property FechaRecibido() As System.DateTime
        Get
            Return _FechaRecibido
        End Get
        Set(value As System.DateTime)
            _FechaRecibido = value
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
            ElseIf index = 8 Then
                Return Me.FormatoID.ToString()
            ElseIf index = 9 Then
                Return Me.EmpresaCodigo.ToString()
            ElseIf index = 10 Then
                Return Me.Descripcion.ToString()
            ElseIf index = 11 Then
                Return Me.AplicaNumeracion.ToString()
            ElseIf index = 12 Then
                Return Me.AplicaCtaBancaria.ToString()
            ElseIf index = 13 Then
                Return Me.AplicaImpDespacho.ToString()
            ElseIf index = 14 Then
                Return Me.Especificaciones.ToString()
            ElseIf index = 15 Then
                Return Me.Utilizacion.ToString()
            ElseIf index = 16 Then
                Return Me.UsuarioResponsable.ToString()
            ElseIf index = 17 Then
                Return Me.UsuarioSolicitador.ToString()
            ElseIf index = 18 Then
                Return Me.UsuarioCreador.ToString()
            ElseIf index = 19 Then
                Return Me.FechaCreacion.ToString()
            ElseIf index = 20 Then
                Return Me.UsuarioEditor.ToString()
            ElseIf index = 21 Then
                Return Me.FechaEdicion.ToString()
            ElseIf index = 22 Then
                Return Me.FormatoxProveedorID.ToString()
            ElseIf index = 23 Then
                Return Me.ProveedorCodigo.ToString()
            ElseIf index = 24 Then
                Return Me.NumDesde.ToString()
            ElseIf index = 25 Then
                Return Me.NumHasta.ToString()
            ElseIf index = 26 Then
                Return Me.NumCantidad.ToString()
            ElseIf index = 27 Then
                Return Me.NumCajas.ToString()
            ElseIf index = 28 Then
                Return Me.UnidXCaja.ToString()
            ElseIf index = 29 Then
                Return Me.Costo.ToString()
            ElseIf index = 30 Then
                Return Me.FacturaReferencia.ToString()
            ElseIf index = 31 Then
                Return Me.DFProteanFxP.ToString()
            ElseIf index = 32 Then
                Return Me.PagoReferencia.ToString()
            ElseIf index = 33 Then
                Return Me.DFProteanChk.ToString()
            ElseIf index = 34 Then
                Return Me.FechaPedido.ToString()
            ElseIf index = 35 Then
                Return Me.FechaEntregaEstimada.ToString()
            ElseIf index = 36 Then
                Return Me.estaPedido.ToString()
            ElseIf index = 37 Then
                Return Me.estaRecibido.ToString()
            ElseIf index = 38 Then
                Return Me.estaConsumido.ToString()
            ElseIf index = 39 Then
                Return Me.CuentaBancariaID.ToString()
            ElseIf index = 40 Then
                Return Me.UbicacionID.ToString()
            ElseIf index = 41 Then
                Return Me.Observaciones.ToString()
            ElseIf index = 42 Then
                Return Me.UsuarioReceptor.ToString()
            ElseIf index = 43 Then
                Return Me.FechaRecibido.ToString()
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
            ElseIf index = 8 Then
                Try
                    Me.FormatoID = System.Int32.Parse("0" & value)
                Catch
                    Me.FormatoID = System.Int32.Parse("0")
                End Try
            ElseIf index = 9 Then
                Me.EmpresaCodigo = value
            ElseIf index = 10 Then
                Me.Descripcion = value
            ElseIf index = 11 Then
                Try
                    Me.AplicaNumeracion = System.Boolean.Parse(value)
                Catch
                    Me.AplicaNumeracion = False
                End Try
            ElseIf index = 12 Then
                Try
                    Me.AplicaCtaBancaria = System.Boolean.Parse(value)
                Catch
                    Me.AplicaCtaBancaria = False
                End Try
            ElseIf index = 13 Then
                Try
                    Me.AplicaImpDespacho = System.Boolean.Parse(value)
                Catch
                    Me.AplicaImpDespacho = False
                End Try
            ElseIf index = 14 Then
                Me.Especificaciones = value
            ElseIf index = 15 Then
                Me.Utilizacion = value
            ElseIf index = 16 Then
                Me.UsuarioResponsable = value
            ElseIf index = 17 Then
                Me.UsuarioSolicitador = value
            ElseIf index = 18 Then
                Me.UsuarioCreador = value
            ElseIf index = 19 Then
                Try
                    Me.FechaCreacion = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaCreacion = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaCreacion = System.DateTime.Now
                End Try
            ElseIf index = 20 Then
                Me.UsuarioEditor = value
            ElseIf index = 21 Then
                Try
                    Me.FechaEdicion = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaEdicion = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaEdicion = System.DateTime.Now
                End Try
            ElseIf index = 22 Then
                Try
                    Me.FormatoxProveedorID = System.Int32.Parse("0" & value)
                Catch
                    Me.FormatoxProveedorID = System.Int32.Parse("0")
                End Try
            ElseIf index = 23 Then
                Me.ProveedorCodigo = value
            ElseIf index = 24 Then
                Try
                    Me.NumDesde = System.Int64.Parse("0" & value)
                Catch
                    Me.NumDesde = System.Int64.Parse("0")
                End Try
            ElseIf index = 25 Then
                Try
                    Me.NumHasta = System.Int64.Parse("0" & value)
                Catch
                    Me.NumHasta = System.Int64.Parse("0")
                End Try
            ElseIf index = 26 Then
                Try
                    Me.NumCantidad = System.Int64.Parse("0" & value)
                Catch
                    Me.NumCantidad = System.Int64.Parse("0")
                End Try
            ElseIf index = 27 Then
                Try
                    Me.NumCajas = System.Int32.Parse("0" & value)
                Catch
                    Me.NumCajas = System.Int32.Parse("0")
                End Try
            ElseIf index = 28 Then
                Try
                    Me.UnidXCaja = System.Int64.Parse("0" & value)
                Catch
                    Me.UnidXCaja = System.Int64.Parse("0")
                End Try
            ElseIf index = 29 Then
                Try
                    Me.Costo = System.Int64.Parse("0" & value)
                Catch
                    Me.Costo = System.Int64.Parse("0")
                End Try
            ElseIf index = 30 Then
                Me.FacturaReferencia = value
            ElseIf index = 31 Then
                Try
                    Me.DFProteanFxP = System.Int32.Parse("0" & value)
                Catch
                    Me.DFProteanFxP = System.Int32.Parse("0")
                End Try
            ElseIf index = 32 Then
                Me.PagoReferencia = value
            ElseIf index = 33 Then
                Try
                    Me.DFProteanChk = System.Int32.Parse("0" & value)
                Catch
                    Me.DFProteanChk = System.Int32.Parse("0")
                End Try
            ElseIf index = 34 Then
                Try
                    Me.FechaPedido = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaPedido = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaPedido = System.DateTime.Now
                End Try
            ElseIf index = 35 Then
                Try
                    Me.FechaEntregaEstimada = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaEntregaEstimada = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaEntregaEstimada = System.DateTime.Now
                End Try
            ElseIf index = 36 Then
                Try
                    Me.estaPedido = System.Boolean.Parse(value)
                Catch
                    Me.estaPedido = False
                End Try
            ElseIf index = 37 Then
                Try
                    Me.estaRecibido = System.Boolean.Parse(value)
                Catch
                    Me.estaRecibido = False
                End Try
            ElseIf index = 38 Then
                Try
                    Me.estaConsumido = System.Boolean.Parse(value)
                Catch
                    Me.estaConsumido = False
                End Try
            ElseIf index = 39 Then
                Try
                    Me.CuentaBancariaID = System.Int32.Parse("0" & value)
                Catch
                    Me.CuentaBancariaID = System.Int32.Parse("0")
                End Try
            ElseIf index = 40 Then
                Try
                    Me.UbicacionID = System.Int32.Parse("0" & value)
                Catch
                    Me.UbicacionID = System.Int32.Parse("0")
                End Try
            ElseIf index = 41 Then
                Me.Observaciones = value
            ElseIf index = 42 Then
                Me.UsuarioReceptor = value
            ElseIf index = 43 Then
                Try
                    Me.FechaRecibido = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaRecibido = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaRecibido = System.DateTime.Now
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
            ElseIf index = "FormatoID" Then
                Return Me.FormatoID.ToString()
            ElseIf index = "EmpresaCodigo" Then
                Return Me.EmpresaCodigo.ToString()
            ElseIf index = "Descripcion" Then
                Return Me.Descripcion.ToString()
            ElseIf index = "AplicaNumeracion" Then
                Return Me.AplicaNumeracion.ToString()
            ElseIf index = "AplicaCtaBancaria" Then
                Return Me.AplicaCtaBancaria.ToString()
            ElseIf index = "AplicaImpDespacho" Then
                Return Me.AplicaImpDespacho.ToString()
            ElseIf index = "Especificaciones" Then
                Return Me.Especificaciones.ToString()
            ElseIf index = "Utilizacion" Then
                Return Me.Utilizacion.ToString()
            ElseIf index = "UsuarioResponsable" Then
                Return Me.UsuarioResponsable.ToString()
            ElseIf index = "UsuarioSolicitador" Then
                Return Me.UsuarioSolicitador.ToString()
            ElseIf index = "UsuarioCreador" Then
                Return Me.UsuarioCreador.ToString()
            ElseIf index = "FechaCreacion" Then
                Return Me.FechaCreacion.ToString()
            ElseIf index = "UsuarioEditor" Then
                Return Me.UsuarioEditor.ToString()
            ElseIf index = "FechaEdicion" Then
                Return Me.FechaEdicion.ToString()
            ElseIf index = "FormatoxProveedorID" Then
                Return Me.FormatoxProveedorID.ToString()
            ElseIf index = "ProveedorCodigo" Then
                Return Me.ProveedorCodigo.ToString()
            ElseIf index = "NumDesde" Then
                Return Me.NumDesde.ToString()
            ElseIf index = "NumHasta" Then
                Return Me.NumHasta.ToString()
            ElseIf index = "NumCantidad" Then
                Return Me.NumCantidad.ToString()
            ElseIf index = "NumCajas" Then
                Return Me.NumCajas.ToString()
            ElseIf index = "UnidXCaja" Then
                Return Me.UnidXCaja.ToString()
            ElseIf index = "Costo" Then
                Return Me.Costo.ToString()
            ElseIf index = "FacturaReferencia" Then
                Return Me.FacturaReferencia.ToString()
            ElseIf index = "DFProteanFxP" Then
                Return Me.DFProteanFxP.ToString()
            ElseIf index = "PagoReferencia" Then
                Return Me.PagoReferencia.ToString()
            ElseIf index = "DFProteanChk" Then
                Return Me.DFProteanChk.ToString()
            ElseIf index = "FechaPedido" Then
                Return Me.FechaPedido.ToString()
            ElseIf index = "FechaEntregaEstimada" Then
                Return Me.FechaEntregaEstimada.ToString()
            ElseIf index = "estaPedido" Then
                Return Me.estaPedido.ToString()
            ElseIf index = "estaRecibido" Then
                Return Me.estaRecibido.ToString()
            ElseIf index = "estaConsumido" Then
                Return Me.estaConsumido.ToString()
            ElseIf index = "CuentaBancariaID" Then
                Return Me.CuentaBancariaID.ToString()
            ElseIf index = "UbicacionID" Then
                Return Me.UbicacionID.ToString()
            ElseIf index = "Observaciones" Then
                Return Me.Observaciones.ToString()
            ElseIf index = "UsuarioReceptor" Then
                Return Me.UsuarioReceptor.ToString()
            ElseIf index = "FechaRecibido" Then
                Return Me.FechaRecibido.ToString()
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
            ElseIf index = "FormatoID" Then
                Try
                    Me.FormatoID = System.Int32.Parse("0" & value)
                Catch
                    Me.FormatoID = System.Int32.Parse("0")
                End Try
            ElseIf index = "EmpresaCodigo" Then
                Me.EmpresaCodigo = value
            ElseIf index = "Descripcion" Then
                Me.Descripcion = value
            ElseIf index = "AplicaNumeracion" Then
                Try
                    Me.AplicaNumeracion = System.Boolean.Parse(value)
                Catch
                    Me.AplicaNumeracion = False
                End Try
            ElseIf index = "AplicaCtaBancaria" Then
                Try
                    Me.AplicaCtaBancaria = System.Boolean.Parse(value)
                Catch
                    Me.AplicaCtaBancaria = False
                End Try
            ElseIf index = "AplicaImpDespacho" Then
                Try
                    Me.AplicaImpDespacho = System.Boolean.Parse(value)
                Catch
                    Me.AplicaImpDespacho = False
                End Try
            ElseIf index = "Especificaciones" Then
                Me.Especificaciones = value
            ElseIf index = "Utilizacion" Then
                Me.Utilizacion = value
            ElseIf index = "UsuarioResponsable" Then
                Me.UsuarioResponsable = value
            ElseIf index = "UsuarioSolicitador" Then
                Me.UsuarioSolicitador = value
            ElseIf index = "UsuarioCreador" Then
                Me.UsuarioCreador = value
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
            ElseIf index = "UsuarioEditor" Then
                Me.UsuarioEditor = value
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
            ElseIf index = "FormatoxProveedorID" Then
                Try
                    Me.FormatoxProveedorID = System.Int32.Parse("0" & value)
                Catch
                    Me.FormatoxProveedorID = System.Int32.Parse("0")
                End Try
            ElseIf index = "ProveedorCodigo" Then
                Me.ProveedorCodigo = value
            ElseIf index = "NumDesde" Then
                Try
                    Me.NumDesde = System.Int64.Parse("0" & value)
                Catch
                    Me.NumDesde = System.Int64.Parse("0")
                End Try
            ElseIf index = "NumHasta" Then
                Try
                    Me.NumHasta = System.Int64.Parse("0" & value)
                Catch
                    Me.NumHasta = System.Int64.Parse("0")
                End Try
            ElseIf index = "NumCantidad" Then
                Try
                    Me.NumCantidad = System.Int64.Parse("0" & value)
                Catch
                    Me.NumCantidad = System.Int64.Parse("0")
                End Try
            ElseIf index = "NumCajas" Then
                Try
                    Me.NumCajas = System.Int32.Parse("0" & value)
                Catch
                    Me.NumCajas = System.Int32.Parse("0")
                End Try
            ElseIf index = "UnidXCaja" Then
                Try
                    Me.UnidXCaja = System.Int64.Parse("0" & value)
                Catch
                    Me.UnidXCaja = System.Int64.Parse("0")
                End Try
            ElseIf index = "Costo" Then
                Try
                    Me.Costo = System.Int64.Parse("0" & value)
                Catch
                    Me.Costo = System.Int64.Parse("0")
                End Try
            ElseIf index = "FacturaReferencia" Then
                Me.FacturaReferencia = value
            ElseIf index = "DFProteanFxP" Then
                Try
                    Me.DFProteanFxP = System.Int32.Parse("0" & value)
                Catch
                    Me.DFProteanFxP = System.Int32.Parse("0")
                End Try
            ElseIf index = "PagoReferencia" Then
                Me.PagoReferencia = value
            ElseIf index = "DFProteanChk" Then
                Try
                    Me.DFProteanChk = System.Int32.Parse("0" & value)
                Catch
                    Me.DFProteanChk = System.Int32.Parse("0")
                End Try
            ElseIf index = "FechaPedido" Then
                Try
                    Me.FechaPedido = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaPedido = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaPedido = System.DateTime.Now
                End Try
            ElseIf index = "FechaEntregaEstimada" Then
                Try
                    Me.FechaEntregaEstimada = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaEntregaEstimada = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaEntregaEstimada = System.DateTime.Now
                End Try
            ElseIf index = "estaPedido" Then
                Try
                    Me.estaPedido = System.Boolean.Parse(value)
                Catch
                    Me.estaPedido = False
                End Try
            ElseIf index = "estaRecibido" Then
                Try
                    Me.estaRecibido = System.Boolean.Parse(value)
                Catch
                    Me.estaRecibido = False
                End Try
            ElseIf index = "estaConsumido" Then
                Try
                    Me.estaConsumido = System.Boolean.Parse(value)
                Catch
                    Me.estaConsumido = False
                End Try
            ElseIf index = "CuentaBancariaID" Then
                Try
                    Me.CuentaBancariaID = System.Int32.Parse("0" & value)
                Catch
                    Me.CuentaBancariaID = System.Int32.Parse("0")
                End Try
            ElseIf index = "UbicacionID" Then
                Try
                    Me.UbicacionID = System.Int32.Parse("0" & value)
                Catch
                    Me.UbicacionID = System.Int32.Parse("0")
                End Try
            ElseIf index = "Observaciones" Then
                Me.Observaciones = value
            ElseIf index = "UsuarioReceptor" Then
                Me.UsuarioReceptor = value
            ElseIf index = "FechaRecibido" Then
                Try
                    Me.FechaRecibido = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaRecibido = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaRecibido = System.DateTime.Now
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
    Public Shared CadenaSelect As String = "SELECT * FROM CDP_FormatosxProveedor"
    '
    Public Sub New()
    End Sub
    Public Sub New(conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto CDP_FormatosxProveedor
    Private Shared Function row2CDP_FormatosxProveedor(r As DataRow) As CDP_FormatosxProveedor
        ' asigna a un objeto CDP_FormatosxProveedor los datos del dataRow indicado
        Dim oCDP_FormatosxProveedor As New CDP_FormatosxProveedor
        '
        oCDP_FormatosxProveedor.EntregaID = System.Int32.Parse("0" & r("EntregaID").ToString())
        Try
            oCDP_FormatosxProveedor.Fecha = DateTime.Parse(r("Fecha").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oCDP_FormatosxProveedor.Fecha = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oCDP_FormatosxProveedor.Fecha = DateTime.Now
        End Try
        oCDP_FormatosxProveedor.EntregadoA = r("EntregadoA").ToString()
        oCDP_FormatosxProveedor.EntregadoPor = r("EntregadoPor").ToString()
        oCDP_FormatosxProveedor.AutorizadoPor = r("AutorizadoPor").ToString()
        oCDP_FormatosxProveedor.CantCajas = System.Decimal.Parse("0" & r("CantCajas").ToString())
        oCDP_FormatosxProveedor.CantFormas = System.Int64.Parse("0" & r("CantFormas").ToString())
        oCDP_FormatosxProveedor.ExistCajas = System.Decimal.Parse("0" & r("ExistCajas").ToString())
        oCDP_FormatosxProveedor.FormatoID = System.Int32.Parse("0" & r("FormatoID").ToString())
        oCDP_FormatosxProveedor.EmpresaCodigo = r("EmpresaCodigo").ToString()
        oCDP_FormatosxProveedor.Descripcion = r("Descripcion").ToString()
        Try
            oCDP_FormatosxProveedor.AplicaNumeracion = System.Boolean.Parse(r("AplicaNumeracion").ToString())
        Catch
            oCDP_FormatosxProveedor.AplicaNumeracion = False
        End Try
        Try
            oCDP_FormatosxProveedor.AplicaCtaBancaria = System.Boolean.Parse(r("AplicaCtaBancaria").ToString())
        Catch
            oCDP_FormatosxProveedor.AplicaCtaBancaria = False
        End Try
        Try
            oCDP_FormatosxProveedor.AplicaImpDespacho = System.Boolean.Parse(r("AplicaImpDespacho").ToString())
        Catch
            oCDP_FormatosxProveedor.AplicaImpDespacho = False
        End Try
        oCDP_FormatosxProveedor.Especificaciones = r("Especificaciones").ToString()
        oCDP_FormatosxProveedor.Utilizacion = r("Utilizacion").ToString()
        oCDP_FormatosxProveedor.UsuarioResponsable = r("UsuarioResponsable").ToString()
        oCDP_FormatosxProveedor.UsuarioSolicitador = r("UsuarioSolicitador").ToString()
        oCDP_FormatosxProveedor.UsuarioCreador = r("UsuarioCreador").ToString()
        Try
            oCDP_FormatosxProveedor.FechaCreacion = DateTime.Parse(r("FechaCreacion").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oCDP_FormatosxProveedor.FechaCreacion = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oCDP_FormatosxProveedor.FechaCreacion = DateTime.Now
        End Try
        oCDP_FormatosxProveedor.UsuarioEditor = r("UsuarioEditor").ToString()
        Try
            oCDP_FormatosxProveedor.FechaEdicion = DateTime.Parse(r("FechaEdicion").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oCDP_FormatosxProveedor.FechaEdicion = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oCDP_FormatosxProveedor.FechaEdicion = DateTime.Now
        End Try
        oCDP_FormatosxProveedor.FormatoxProveedorID = System.Int32.Parse("0" & r("FormatoxProveedorID").ToString())
        oCDP_FormatosxProveedor.ProveedorCodigo = r("ProveedorCodigo").ToString()
        oCDP_FormatosxProveedor.NumDesde = System.Int64.Parse("0" & r("NumDesde").ToString())
        oCDP_FormatosxProveedor.NumHasta = System.Int64.Parse("0" & r("NumHasta").ToString())
        oCDP_FormatosxProveedor.NumCantidad = System.Int64.Parse("0" & r("NumCantidad").ToString())
        oCDP_FormatosxProveedor.NumCajas = System.Int32.Parse("0" & r("NumCajas").ToString())
        oCDP_FormatosxProveedor.UnidXCaja = System.Int64.Parse("0" & r("UnidXCaja").ToString())
        oCDP_FormatosxProveedor.Costo = System.Int64.Parse("0" & r("Costo").ToString())
        oCDP_FormatosxProveedor.FacturaReferencia = r("FacturaReferencia").ToString()
        oCDP_FormatosxProveedor.DFProteanFxP = System.Int32.Parse("0" & r("DFProteanFxP").ToString())
        oCDP_FormatosxProveedor.PagoReferencia = r("PagoReferencia").ToString()
        oCDP_FormatosxProveedor.DFProteanChk = System.Int32.Parse("0" & r("DFProteanChk").ToString())
        Try
            oCDP_FormatosxProveedor.FechaPedido = DateTime.Parse(r("FechaPedido").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oCDP_FormatosxProveedor.FechaPedido = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oCDP_FormatosxProveedor.FechaPedido = DateTime.Now
        End Try
        Try
            oCDP_FormatosxProveedor.FechaEntregaEstimada = DateTime.Parse(r("FechaEntregaEstimada").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oCDP_FormatosxProveedor.FechaEntregaEstimada = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oCDP_FormatosxProveedor.FechaEntregaEstimada = DateTime.Now
        End Try
        Try
            oCDP_FormatosxProveedor.estaPedido = System.Boolean.Parse(r("estaPedido").ToString())
        Catch
            oCDP_FormatosxProveedor.estaPedido = False
        End Try
        Try
            oCDP_FormatosxProveedor.estaRecibido = System.Boolean.Parse(r("estaRecibido").ToString())
        Catch
            oCDP_FormatosxProveedor.estaRecibido = False
        End Try
        Try
            oCDP_FormatosxProveedor.estaConsumido = System.Boolean.Parse(r("estaConsumido").ToString())
        Catch
            oCDP_FormatosxProveedor.estaConsumido = False
        End Try
        oCDP_FormatosxProveedor.CuentaBancariaID = System.Int32.Parse("0" & r("CuentaBancariaID").ToString())
        oCDP_FormatosxProveedor.UbicacionID = System.Int32.Parse("0" & r("UbicacionID").ToString())
        oCDP_FormatosxProveedor.Observaciones = r("Observaciones").ToString()
        oCDP_FormatosxProveedor.UsuarioReceptor = r("UsuarioReceptor").ToString()
        Try
            oCDP_FormatosxProveedor.FechaRecibido = DateTime.Parse(r("FechaRecibido").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oCDP_FormatosxProveedor.FechaRecibido = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oCDP_FormatosxProveedor.FechaRecibido = DateTime.Now
        End Try
        '
        Return oCDP_FormatosxProveedor
    End Function
    '
    ' asigna un objeto CDP_FormatosxProveedor a la fila indicada
    Private Shared Sub CDP_FormatosxProveedor2Row(oCDP_FormatosxProveedor As CDP_FormatosxProveedor, r As DataRow)
        ' asigna un objeto CDP_FormatosxProveedor al dataRow indicado
        ' TODO: Comprueba si esta asignación debe hacerse
        '       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        'r("EntregaID") = oCDP_FormatosxProveedor.EntregaID
        r("Fecha") = oCDP_FormatosxProveedor.Fecha
        r("EntregadoA") = oCDP_FormatosxProveedor.EntregadoA
        r("EntregadoPor") = oCDP_FormatosxProveedor.EntregadoPor
        r("AutorizadoPor") = oCDP_FormatosxProveedor.AutorizadoPor
        r("CantCajas") = oCDP_FormatosxProveedor.CantCajas
        r("CantFormas") = oCDP_FormatosxProveedor.CantFormas
        r("ExistCajas") = oCDP_FormatosxProveedor.ExistCajas
        ' TODO: Comprueba si esta asignación debe hacerse
        '       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        'r("FormatoID") = oCDP_FormatosxProveedor.FormatoID
        r("EmpresaCodigo") = oCDP_FormatosxProveedor.EmpresaCodigo
        r("Descripcion") = oCDP_FormatosxProveedor.Descripcion
        r("AplicaNumeracion") = oCDP_FormatosxProveedor.AplicaNumeracion
        r("AplicaCtaBancaria") = oCDP_FormatosxProveedor.AplicaCtaBancaria
        r("AplicaImpDespacho") = oCDP_FormatosxProveedor.AplicaImpDespacho
        r("Especificaciones") = oCDP_FormatosxProveedor.Especificaciones
        r("Utilizacion") = oCDP_FormatosxProveedor.Utilizacion
        r("UsuarioResponsable") = oCDP_FormatosxProveedor.UsuarioResponsable
        r("UsuarioSolicitador") = oCDP_FormatosxProveedor.UsuarioSolicitador
        r("UsuarioCreador") = oCDP_FormatosxProveedor.UsuarioCreador
        r("FechaCreacion") = oCDP_FormatosxProveedor.FechaCreacion
        r("UsuarioEditor") = oCDP_FormatosxProveedor.UsuarioEditor
        r("FechaEdicion") = oCDP_FormatosxProveedor.FechaEdicion
        ' TODO: Comprueba si esta asignación debe hacerse
        '       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        'r("FormatoxProveedorID") = oCDP_FormatosxProveedor.FormatoxProveedorID
        r("ProveedorCodigo") = oCDP_FormatosxProveedor.ProveedorCodigo
        r("NumDesde") = oCDP_FormatosxProveedor.NumDesde
        r("NumHasta") = oCDP_FormatosxProveedor.NumHasta
        r("NumCantidad") = oCDP_FormatosxProveedor.NumCantidad
        r("NumCajas") = oCDP_FormatosxProveedor.NumCajas
        r("UnidXCaja") = oCDP_FormatosxProveedor.UnidXCaja
        r("Costo") = oCDP_FormatosxProveedor.Costo
        r("FacturaReferencia") = oCDP_FormatosxProveedor.FacturaReferencia
        r("DFProteanFxP") = oCDP_FormatosxProveedor.DFProteanFxP
        r("PagoReferencia") = oCDP_FormatosxProveedor.PagoReferencia
        r("DFProteanChk") = oCDP_FormatosxProveedor.DFProteanChk
        r("FechaPedido") = oCDP_FormatosxProveedor.FechaPedido
        r("FechaEntregaEstimada") = oCDP_FormatosxProveedor.FechaEntregaEstimada
        r("estaPedido") = oCDP_FormatosxProveedor.estaPedido
        r("estaRecibido") = oCDP_FormatosxProveedor.estaRecibido
        r("estaConsumido") = oCDP_FormatosxProveedor.estaConsumido
        r("CuentaBancariaID") = oCDP_FormatosxProveedor.CuentaBancariaID
        r("UbicacionID") = oCDP_FormatosxProveedor.UbicacionID
        r("Observaciones") = oCDP_FormatosxProveedor.Observaciones
        r("UsuarioReceptor") = oCDP_FormatosxProveedor.UsuarioReceptor
        r("FechaRecibido") = oCDP_FormatosxProveedor.FechaRecibido
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto CDP_FormatosxProveedor
    Private Shared Sub nuevoCDP_FormatosxProveedor(dt As DataTable, oCDP_FormatosxProveedor As CDP_FormatosxProveedor)
        ' Crear un nuevo CDP_FormatosxProveedor
        Dim dr As DataRow = dt.NewRow()
        Dim oC As CDP_FormatosxProveedor = row2CDP_FormatosxProveedor(dr)
        '
        oC.EntregaID = oCDP_FormatosxProveedor.EntregaID
        oC.Fecha = oCDP_FormatosxProveedor.Fecha
        oC.EntregadoA = oCDP_FormatosxProveedor.EntregadoA
        oC.EntregadoPor = oCDP_FormatosxProveedor.EntregadoPor
        oC.AutorizadoPor = oCDP_FormatosxProveedor.AutorizadoPor
        oC.CantCajas = oCDP_FormatosxProveedor.CantCajas
        oC.CantFormas = oCDP_FormatosxProveedor.CantFormas
        oC.ExistCajas = oCDP_FormatosxProveedor.ExistCajas
        oC.FormatoID = oCDP_FormatosxProveedor.FormatoID
        oC.EmpresaCodigo = oCDP_FormatosxProveedor.EmpresaCodigo
        oC.Descripcion = oCDP_FormatosxProveedor.Descripcion
        oC.AplicaNumeracion = oCDP_FormatosxProveedor.AplicaNumeracion
        oC.AplicaCtaBancaria = oCDP_FormatosxProveedor.AplicaCtaBancaria
        oC.AplicaImpDespacho = oCDP_FormatosxProveedor.AplicaImpDespacho
        oC.Especificaciones = oCDP_FormatosxProveedor.Especificaciones
        oC.Utilizacion = oCDP_FormatosxProveedor.Utilizacion
        oC.UsuarioResponsable = oCDP_FormatosxProveedor.UsuarioResponsable
        oC.UsuarioSolicitador = oCDP_FormatosxProveedor.UsuarioSolicitador
        oC.UsuarioCreador = oCDP_FormatosxProveedor.UsuarioCreador
        oC.FechaCreacion = oCDP_FormatosxProveedor.FechaCreacion
        oC.UsuarioEditor = oCDP_FormatosxProveedor.UsuarioEditor
        oC.FechaEdicion = oCDP_FormatosxProveedor.FechaEdicion
        oC.FormatoxProveedorID = oCDP_FormatosxProveedor.FormatoxProveedorID
        oC.ProveedorCodigo = oCDP_FormatosxProveedor.ProveedorCodigo
        oC.NumDesde = oCDP_FormatosxProveedor.NumDesde
        oC.NumHasta = oCDP_FormatosxProveedor.NumHasta
        oC.NumCantidad = oCDP_FormatosxProveedor.NumCantidad
        oC.NumCajas = oCDP_FormatosxProveedor.NumCajas
        oC.UnidXCaja = oCDP_FormatosxProveedor.UnidXCaja
        oC.Costo = oCDP_FormatosxProveedor.Costo
        oC.FacturaReferencia = oCDP_FormatosxProveedor.FacturaReferencia
        oC.DFProteanFxP = oCDP_FormatosxProveedor.DFProteanFxP
        oC.PagoReferencia = oCDP_FormatosxProveedor.PagoReferencia
        oC.DFProteanChk = oCDP_FormatosxProveedor.DFProteanChk
        oC.FechaPedido = oCDP_FormatosxProveedor.FechaPedido
        oC.FechaEntregaEstimada = oCDP_FormatosxProveedor.FechaEntregaEstimada
        oC.estaPedido = oCDP_FormatosxProveedor.estaPedido
        oC.estaRecibido = oCDP_FormatosxProveedor.estaRecibido
        oC.estaConsumido = oCDP_FormatosxProveedor.estaConsumido
        oC.CuentaBancariaID = oCDP_FormatosxProveedor.CuentaBancariaID
        oC.UbicacionID = oCDP_FormatosxProveedor.UbicacionID
        oC.Observaciones = oCDP_FormatosxProveedor.Observaciones
        oC.UsuarioReceptor = oCDP_FormatosxProveedor.UsuarioReceptor
        oC.FechaRecibido = oCDP_FormatosxProveedor.FechaRecibido
        '
        CDP_FormatosxProveedor2Row(oC, dr)
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
        ' devuelve una tabla con los datos de la tabla CDP_FormatosxProveedor
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("CDP_FormatosxProveedor")
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
    Public Shared Function Buscar(sWhere As String) As CDP_FormatosxProveedor
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oCDP_FormatosxProveedor As CDP_FormatosxProveedor = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("CDP_FormatosxProveedor")
        Dim sel As String = "SELECT * FROM CDP_FormatosxProveedor WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oCDP_FormatosxProveedor = row2CDP_FormatosxProveedor(dt.Rows(0))
        End If
        Return oCDP_FormatosxProveedor
    End Function
    '
    ' Actualizar: Actualiza los datos en la tabla usando la instancia actual
    '             Si la instancia no hace referencia a un registro existente, se creará uno nuevo
    '             Para comprobar si el objeto en memoria coincide con uno existente,
    '             se comprueba si el FormatoxProveedorID existe en la tabla.
    '             TODO: Si en lugar de FormatoxProveedorID usas otro campo, indicalo en la cadena SELECT
    '                   También puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    Public Function Actualizar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el FormatoxProveedorID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM CDP_FormatosxProveedor WHERE FormatoxProveedorID = " & Me.FormatoxProveedorID.ToString()
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(sel As String) As String
        ' Actualiza los datos indicados
        ' El parámetro, que es una cadena de selección, indicará el criterio de actualización
        '
        ' En caso de error, devolverá la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("CDP_FormatosxProveedor")
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
        '       Yo compruebo que sea un campo llamado FormatoxProveedorID, pero en tu caso puede ser otro
        '       Ese campo, (en mi caso FormatoxProveedorID) será el que hay que poner al final junto al WHERE.
        sCommand = "UPDATE CDP_FormatosxProveedor SET EntregaID = @EntregaID, Fecha = @Fecha, EntregadoA = @EntregadoA, EntregadoPor = @EntregadoPor, AutorizadoPor = @AutorizadoPor, CantCajas = @CantCajas, CantFormas = @CantFormas, ExistCajas = @ExistCajas, FormatoID = @FormatoID, EmpresaCodigo = @EmpresaCodigo, Descripcion = @Descripcion, AplicaNumeracion = @AplicaNumeracion, AplicaCtaBancaria = @AplicaCtaBancaria, AplicaImpDespacho = @AplicaImpDespacho, Especificaciones = @Especificaciones, Utilizacion = @Utilizacion, UsuarioResponsable = @UsuarioResponsable, UsuarioSolicitador = @UsuarioSolicitador, UsuarioCreador = @UsuarioCreador, FechaCreacion = @FechaCreacion, UsuarioEditor = @UsuarioEditor, FechaEdicion = @FechaEdicion, ProveedorCodigo = @ProveedorCodigo, NumDesde = @NumDesde, NumHasta = @NumHasta, NumCantidad = @NumCantidad, NumCajas = @NumCajas, UnidXCaja = @UnidXCaja, Costo = @Costo, FacturaReferencia = @FacturaReferencia, DFProteanFxP = @DFProteanFxP, PagoReferencia = @PagoReferencia, DFProteanChk = @DFProteanChk, FechaPedido = @FechaPedido, FechaEntregaEstimada = @FechaEntregaEstimada, estaPedido = @estaPedido, estaRecibido = @estaRecibido, estaConsumido = @estaConsumido, CuentaBancariaID = @CuentaBancariaID, UbicacionID = @UbicacionID, Observaciones = @Observaciones, UsuarioReceptor = @UsuarioReceptor, FechaRecibido = @FechaRecibido  WHERE (FormatoxProveedorID = @FormatoxProveedorID)"
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
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@FormatoID", SqlDbType.Int, 0, "FormatoID")
        da.UpdateCommand.Parameters.Add("@EmpresaCodigo", SqlDbType.NVarChar, 2, "EmpresaCodigo")
        da.UpdateCommand.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 50, "Descripcion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@AplicaNumeracion", SqlDbType.Bit, 0, "AplicaNumeracion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@AplicaCtaBancaria", SqlDbType.Bit, 0, "AplicaCtaBancaria")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@AplicaImpDespacho", SqlDbType.Bit, 0, "AplicaImpDespacho")
        da.UpdateCommand.Parameters.Add("@Especificaciones", SqlDbType.NVarChar, 200, "Especificaciones")
        da.UpdateCommand.Parameters.Add("@Utilizacion", SqlDbType.NVarChar, 200, "Utilizacion")
        da.UpdateCommand.Parameters.Add("@UsuarioResponsable", SqlDbType.NVarChar, 25, "UsuarioResponsable")
        da.UpdateCommand.Parameters.Add("@UsuarioSolicitador", SqlDbType.NVarChar, 25, "UsuarioSolicitador")
        da.UpdateCommand.Parameters.Add("@UsuarioCreador", SqlDbType.NVarChar, 25, "UsuarioCreador")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 0, "FechaCreacion")
        da.UpdateCommand.Parameters.Add("@UsuarioEditor", SqlDbType.NVarChar, 25, "UsuarioEditor")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@FechaEdicion", SqlDbType.DateTime, 0, "FechaEdicion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@FormatoxProveedorID", SqlDbType.Int, 0, "FormatoxProveedorID")
        da.UpdateCommand.Parameters.Add("@ProveedorCodigo", SqlDbType.NVarChar, 6, "ProveedorCodigo")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@NumDesde", SqlDbType.BigInt, 0, "NumDesde")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@NumHasta", SqlDbType.BigInt, 0, "NumHasta")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@NumCantidad", SqlDbType.BigInt, 0, "NumCantidad")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@NumCajas", SqlDbType.Int, 0, "NumCajas")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@UnidXCaja", SqlDbType.BigInt, 0, "UnidXCaja")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@Costo", SqlDbType.BigInt, 0, "Costo")
        da.UpdateCommand.Parameters.Add("@FacturaReferencia", SqlDbType.NVarChar, 50, "FacturaReferencia")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@DFProteanFxP", SqlDbType.Int, 0, "DFProteanFxP")
        da.UpdateCommand.Parameters.Add("@PagoReferencia", SqlDbType.NVarChar, 10, "PagoReferencia")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@DFProteanChk", SqlDbType.Int, 0, "DFProteanChk")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@FechaPedido", SqlDbType.DateTime, 0, "FechaPedido")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@FechaEntregaEstimada", SqlDbType.DateTime, 0, "FechaEntregaEstimada")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@estaPedido", SqlDbType.Bit, 0, "estaPedido")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@estaRecibido", SqlDbType.Bit, 0, "estaRecibido")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@estaConsumido", SqlDbType.Bit, 0, "estaConsumido")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@CuentaBancariaID", SqlDbType.Int, 0, "CuentaBancariaID")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@UbicacionID", SqlDbType.Int, 0, "UbicacionID")
        da.UpdateCommand.Parameters.Add("@Observaciones", SqlDbType.NVarChar, 200, "Observaciones")
        da.UpdateCommand.Parameters.Add("@UsuarioReceptor", SqlDbType.NVarChar, 25, "UsuarioReceptor")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@FechaRecibido", SqlDbType.DateTime, 0, "FechaRecibido")
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
            CDP_FormatosxProveedor2Row(Me, dt.Rows(0))
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
        Dim dt As New DataTable("CDP_FormatosxProveedor")
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
        '       Yo compruebo que sea un campo llamado FormatoxProveedorID, pero en tu caso puede ser otro
        sCommand = "INSERT INTO CDP_FormatosxProveedor (Fecha, EntregadoA, EntregadoPor, AutorizadoPor, CantCajas, CantFormas, ExistCajas, EmpresaCodigo, Descripcion, AplicaNumeracion, AplicaCtaBancaria, AplicaImpDespacho, Especificaciones, Utilizacion, UsuarioResponsable, UsuarioSolicitador, UsuarioCreador, FechaCreacion, UsuarioEditor, FechaEdicion, ProveedorCodigo, NumDesde, NumHasta, NumCantidad, NumCajas, UnidXCaja, Costo, FacturaReferencia, DFProteanFxP, PagoReferencia, DFProteanChk, FechaPedido, FechaEntregaEstimada, estaPedido, estaRecibido, estaConsumido, CuentaBancariaID, UbicacionID, Observaciones, UsuarioReceptor, FechaRecibido)  VALUES(@Fecha, @EntregadoA, @EntregadoPor, @AutorizadoPor, @CantCajas, @CantFormas, @ExistCajas, @EmpresaCodigo, @Descripcion, @AplicaNumeracion, @AplicaCtaBancaria, @AplicaImpDespacho, @Especificaciones, @Utilizacion, @UsuarioResponsable, @UsuarioSolicitador, @UsuarioCreador, @FechaCreacion, @UsuarioEditor, @FechaEdicion, @ProveedorCodigo, @NumDesde, @NumHasta, @NumCantidad, @NumCajas, @UnidXCaja, @Costo, @FacturaReferencia, @DFProteanFxP, @PagoReferencia, @DFProteanChk, @FechaPedido, @FechaEntregaEstimada, @estaPedido, @estaRecibido, @estaConsumido, @CuentaBancariaID, @UbicacionID, @Observaciones, @UsuarioReceptor, @FechaRecibido)"
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
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@FormatoID", SqlDbType.Int, 0, "FormatoID")
        da.InsertCommand.Parameters.Add("@EmpresaCodigo", SqlDbType.NVarChar, 2, "EmpresaCodigo")
        da.InsertCommand.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 50, "Descripcion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@AplicaNumeracion", SqlDbType.Bit, 0, "AplicaNumeracion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@AplicaCtaBancaria", SqlDbType.Bit, 0, "AplicaCtaBancaria")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@AplicaImpDespacho", SqlDbType.Bit, 0, "AplicaImpDespacho")
        da.InsertCommand.Parameters.Add("@Especificaciones", SqlDbType.NVarChar, 200, "Especificaciones")
        da.InsertCommand.Parameters.Add("@Utilizacion", SqlDbType.NVarChar, 200, "Utilizacion")
        da.InsertCommand.Parameters.Add("@UsuarioResponsable", SqlDbType.NVarChar, 25, "UsuarioResponsable")
        da.InsertCommand.Parameters.Add("@UsuarioSolicitador", SqlDbType.NVarChar, 25, "UsuarioSolicitador")
        da.InsertCommand.Parameters.Add("@UsuarioCreador", SqlDbType.NVarChar, 25, "UsuarioCreador")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 0, "FechaCreacion")
        da.InsertCommand.Parameters.Add("@UsuarioEditor", SqlDbType.NVarChar, 25, "UsuarioEditor")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@FechaEdicion", SqlDbType.DateTime, 0, "FechaEdicion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@FormatoxProveedorID", SqlDbType.Int, 0, "FormatoxProveedorID")
        da.InsertCommand.Parameters.Add("@ProveedorCodigo", SqlDbType.NVarChar, 6, "ProveedorCodigo")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@NumDesde", SqlDbType.BigInt, 0, "NumDesde")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@NumHasta", SqlDbType.BigInt, 0, "NumHasta")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@NumCantidad", SqlDbType.BigInt, 0, "NumCantidad")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@NumCajas", SqlDbType.Int, 0, "NumCajas")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@UnidXCaja", SqlDbType.BigInt, 0, "UnidXCaja")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@Costo", SqlDbType.BigInt, 0, "Costo")
        da.InsertCommand.Parameters.Add("@FacturaReferencia", SqlDbType.NVarChar, 50, "FacturaReferencia")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@DFProteanFxP", SqlDbType.Int, 0, "DFProteanFxP")
        da.InsertCommand.Parameters.Add("@PagoReferencia", SqlDbType.NVarChar, 10, "PagoReferencia")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@DFProteanChk", SqlDbType.Int, 0, "DFProteanChk")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@FechaPedido", SqlDbType.DateTime, 0, "FechaPedido")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@FechaEntregaEstimada", SqlDbType.DateTime, 0, "FechaEntregaEstimada")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@estaPedido", SqlDbType.Bit, 0, "estaPedido")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@estaRecibido", SqlDbType.Bit, 0, "estaRecibido")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@estaConsumido", SqlDbType.Bit, 0, "estaConsumido")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@CuentaBancariaID", SqlDbType.Int, 0, "CuentaBancariaID")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@UbicacionID", SqlDbType.Int, 0, "UbicacionID")
        da.InsertCommand.Parameters.Add("@Observaciones", SqlDbType.NVarChar, 200, "Observaciones")
        da.InsertCommand.Parameters.Add("@UsuarioReceptor", SqlDbType.NVarChar, 25, "UsuarioReceptor")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@FechaRecibido", SqlDbType.DateTime, 0, "FechaRecibido")
        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoCDP_FormatosxProveedor(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo CDP_FormatosxProveedor"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el FormatoxProveedorID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM CDP_FormatosxProveedor WHERE FormatoxProveedorID = " & Me.FormatoxProveedorID.ToString()
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("CDP_FormatosxProveedor")
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
        '       Yo compruebo que sea un campo llamado FormatoxProveedorID, pero en tu caso puede ser otro
        sCommand = "DELETE FROM CDP_FormatosxProveedor WHERE (FormatoxProveedorID = @p1)"
        da.DeleteCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.DeleteCommand.Parameters.Add("@p1", SqlDbType.Int, 0, "FormatoxProveedorID")
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
