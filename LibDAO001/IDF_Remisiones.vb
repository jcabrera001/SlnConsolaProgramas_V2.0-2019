'------------------------------------------------------------------------------
' Clase IDF_Remisiones generada automáticamente con CrearClaseSQL
' de la tabla 'IDF_Remisiones' de la base 'Finanzas'
' Fecha: 06/May/2015 08:53:44
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
Public Class IDF_Remisiones
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _RemisionID As System.Int32
    Private _RemNum As System.String
    Private _CAI As System.String
    Private _Fecha As System.DateTime
    Private _EmpresaCodigo As System.String
    Private _SdNCodigo As System.String
    Private _DFFactID As System.Int32
    Private _Estado As System.Int32
    Private _UsuCreador As System.String
    Private _FechaCreacion As System.DateTime
    Private _UsuEditor As System.String
    Private _FechaEdicion As System.DateTime
    Private _UsuAnulacion As System.String
    Private _FechaAnulacion As System.DateTime
    Private _UsuImpresion As System.String
    Private _FechaImpresion As System.DateTime
    Private _estaImpreso As System.Boolean
    Private _PuntoPartida As System.String
    Private _PuntoDestino As System.String
    Private _FechaInicio As System.DateTime
    Private _FechaFinal As System.DateTime
    Private _Motivo As System.Int32
    Private _OtroMotivo As System.String
    Private _TransportistaID As System.Int32
    Private _ConductorID As System.Int32
    Private _Marca As System.String
    Private _Placa As System.String
    Private _Licencia As System.String
    Private _Identidad As System.String
    Private _Marchamo1 As System.String
    Private _Marchamo2 As System.String
    Private _Marchamo3 As System.String
    Private _Marchamo4 As System.String
    Private _TiposDoctoID As System.Int32
    Private _NumCabezal As System.String
    Private _EstadoPesaje As System.String
    Private _NumOrdenPesoBioSalc As System.Int32
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
    Public Property RemisionID() As System.Int32
        Get
            Return  _RemisionID
        End Get
        Set(value As System.Int32)
            _RemisionID = value
        End Set
    End Property
    Public Property RemNum() As System.String
        Get
            Return ajustarAncho(_RemNum,25)
        End Get
        Set(value As System.String)
            _RemNum = value
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
            Return ajustarAncho(_EmpresaCodigo,5)
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
    Public Property DFFactID() As System.Int32
        Get
            Return  _DFFactID
        End Get
        Set(value As System.Int32)
            _DFFactID = value
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
    Public Property PuntoPartida() As System.String
        Get
            Return ajustarAncho(_PuntoPartida,100)
        End Get
        Set(value As System.String)
            _PuntoPartida = value
        End Set
    End Property
    Public Property PuntoDestino() As System.String
        Get
            Return ajustarAncho(_PuntoDestino,100)
        End Get
        Set(value As System.String)
            _PuntoDestino = value
        End Set
    End Property
    Public Property FechaInicio() As System.DateTime
        Get
            Return  _FechaInicio
        End Get
        Set(value As System.DateTime)
            _FechaInicio = value
        End Set
    End Property
    Public Property FechaFinal() As System.DateTime
        Get
            Return  _FechaFinal
        End Get
        Set(value As System.DateTime)
            _FechaFinal = value
        End Set
    End Property
    Public Property Motivo() As System.Int32
        Get
            Return  _Motivo
        End Get
        Set(value As System.Int32)
            _Motivo = value
        End Set
    End Property
    Public Property OtroMotivo() As System.String
        Get
            Return ajustarAncho(_OtroMotivo,25)
        End Get
        Set(value As System.String)
            _OtroMotivo = value
        End Set
    End Property
    Public Property TransportistaID() As System.Int32
        Get
            Return  _TransportistaID
        End Get
        Set(value As System.Int32)
            _TransportistaID = value
        End Set
    End Property
    Public Property ConductorID() As System.Int32
        Get
            Return  _ConductorID
        End Get
        Set(value As System.Int32)
            _ConductorID = value
        End Set
    End Property
    Public Property Marca() As System.String
        Get
            Return ajustarAncho(_Marca, 50)
        End Get
        Set(value As System.String)
            _Marca = value
        End Set
    End Property
    Public Property Placa() As System.String
        Get
            Return ajustarAncho(_Placa, 30)
        End Get
        Set(value As System.String)
            _Placa = value
        End Set
    End Property
    Public Property Licencia() As System.String
        Get
            Return ajustarAncho(_Licencia,25)
        End Get
        Set(value As System.String)
            _Licencia = value
        End Set
    End Property
    Public Property Identidad() As System.String
        Get
            Return ajustarAncho(_Identidad,25)
        End Get
        Set(value As System.String)
            _Identidad = value
        End Set
    End Property
    Public Property Marchamo1() As System.String
        Get
            Return ajustarAncho(_Marchamo1,25)
        End Get
        Set(value As System.String)
            _Marchamo1 = value
        End Set
    End Property
    Public Property Marchamo2() As System.String
        Get
            Return ajustarAncho(_Marchamo2,25)
        End Get
        Set(value As System.String)
            _Marchamo2 = value
        End Set
    End Property
    Public Property Marchamo3() As System.String
        Get
            Return ajustarAncho(_Marchamo3,25)
        End Get
        Set(value As System.String)
            _Marchamo3 = value
        End Set
    End Property
    Public Property Marchamo4() As System.String
        Get
            Return ajustarAncho(_Marchamo4,25)
        End Get
        Set(value As System.String)
            _Marchamo4 = value
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
    Public Property NumCabezal() As System.String
        Get
            Return _NumCabezal
        End Get
        Set(value As System.String)
            _NumCabezal = value
        End Set
    End Property
    Public Property EstadoPesaje() As System.String
        Get
            Return ajustarAncho(_EstadoPesaje, 10)
        End Get
        Set(value As System.String)
            _EstadoPesaje = value
        End Set
    End Property
    Public Property NumOrdenPesoBioSalc() As System.Int32
        Get
            Return _NumOrdenPesoBioSalc
        End Get
        Set(value As System.Int32)
            _NumOrdenPesoBioSalc = value
        End Set
    End Property
    '
    Public Default Property Item(index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.RemisionID.ToString()
            ElseIf index = 1 Then
                Return Me.RemNum.ToString()
            ElseIf index = 2 Then
                Return Me.CAI.ToString()
            ElseIf index = 3 Then
                Return Me.Fecha.ToString()
            ElseIf index = 4 Then
                Return Me.EmpresaCodigo.ToString()
            ElseIf index = 5 Then
                Return Me.SdNCodigo.ToString()
            ElseIf index = 6 Then
                Return Me.DFFactID.ToString()
            ElseIf index = 7 Then
                Return Me.Estado.ToString()
            ElseIf index = 8 Then
                Return Me.UsuCreador.ToString()
            ElseIf index = 9 Then
                Return Me.FechaCreacion.ToString()
            ElseIf index = 10 Then
                Return Me.UsuEditor.ToString()
            ElseIf index = 11 Then
                Return Me.FechaEdicion.ToString()
            ElseIf index = 12 Then
                Return Me.UsuAnulacion.ToString()
            ElseIf index = 13 Then
                Return Me.FechaAnulacion.ToString()
            ElseIf index = 14 Then
                Return Me.UsuImpresion.ToString()
            ElseIf index = 15 Then
                Return Me.FechaImpresion.ToString()
            ElseIf index = 16 Then
                Return Me.estaImpreso.ToString()
            ElseIf index = 17 Then
                Return Me.PuntoPartida.ToString()
            ElseIf index = 18 Then
                Return Me.PuntoDestino.ToString()
            ElseIf index = 19 Then
                Return Me.FechaInicio.ToString()
            ElseIf index = 20 Then
                Return Me.FechaFinal.ToString()
            ElseIf index = 21 Then
                Return Me.Motivo.ToString()
            ElseIf index = 22 Then
                Return Me.OtroMotivo.ToString()
            ElseIf index = 23 Then
                Return Me.TransportistaID.ToString()
            ElseIf index = 24 Then
                Return Me.ConductorID.ToString()
            ElseIf index = 25 Then
                Return Me.Marca.ToString()
            ElseIf index = 26 Then
                Return Me.Placa.ToString()
            ElseIf index = 27 Then
                Return Me.Licencia.ToString()
            ElseIf index = 28 Then
                Return Me.Identidad.ToString()
            ElseIf index = 29 Then
                Return Me.Marchamo1.ToString()
            ElseIf index = 30 Then
                Return Me.Marchamo2.ToString()
            ElseIf index = 31 Then
                Return Me.Marchamo3.ToString()
            ElseIf index = 32 Then
                Return Me.Marchamo4.ToString()
            ElseIf index = 33 Then
                Return Me.TiposDoctoID.ToString()
            ElseIf index = 34 Then
                Return Me.NumCabezal.ToString()
            ElseIf index = 35 Then
                Return Me.EstadoPesaje.ToString()
            ElseIf index = 36 Then
                Return Me.NumOrdenPesoBioSalc.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = 0 Then
                Try
                    Me.RemisionID = System.Int32.Parse("0" & value)
                Catch
                    Me.RemisionID = System.Int32.Parse("0")
                End Try
            ElseIf index = 1 Then
                Me.RemNum = value
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
                    Me.DFFactID = System.Int32.Parse("0" & value)
                Catch
                    Me.DFFactID = System.Int32.Parse("0")
                End Try
            ElseIf index = 7 Then
                Try
                    Me.Estado = System.Int32.Parse("0" & value)
                Catch
                    Me.Estado = System.Int32.Parse("0")
                End Try
            ElseIf index = 8 Then
                Me.UsuCreador = value
            ElseIf index = 9 Then
                Try
                    Me.FechaCreacion = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaCreacion = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaCreacion = System.DateTime.Now
                End Try
            ElseIf index = 10 Then
                Me.UsuEditor = value
            ElseIf index = 11 Then
                Try
                    Me.FechaEdicion = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaEdicion = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaEdicion = System.DateTime.Now
                End Try
            ElseIf index = 12 Then
                Me.UsuAnulacion = value
            ElseIf index = 13 Then
                Try
                    Me.FechaAnulacion = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaAnulacion = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaAnulacion = System.DateTime.Now
                End Try
            ElseIf index = 14 Then
                Me.UsuImpresion = value
            ElseIf index = 15 Then
                Try
                    Me.FechaImpresion = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaImpresion = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaImpresion = System.DateTime.Now
                End Try
            ElseIf index = 16 Then
                Try
                    Me.estaImpreso = System.Boolean.Parse(value)
                Catch
                    Me.estaImpreso = False
                End Try
            ElseIf index = 17 Then
                Me.PuntoPartida = value
            ElseIf index = 18 Then
                Me.PuntoDestino = value
            ElseIf index = 19 Then
                Try
                    Me.FechaInicio = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaInicio = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaInicio = System.DateTime.Now
                End Try
            ElseIf index = 20 Then
                Try
                    Me.FechaFinal = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaFinal = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaFinal = System.DateTime.Now
                End Try
            ElseIf index = 21 Then
                Try
                    Me.Motivo = System.Int32.Parse("0" & value)
                Catch
                    Me.Motivo = System.Int32.Parse("0")
                End Try
            ElseIf index = 22 Then
                Me.OtroMotivo = value
            ElseIf index = 23 Then
                Try
                    Me.TransportistaID = System.Int32.Parse("0" & value)
                Catch
                    Me.TransportistaID = System.Int32.Parse("0")
                End Try
            ElseIf index = 24 Then
                Try
                    Me.ConductorID = System.Int32.Parse("0" & value)
                Catch
                    Me.ConductorID = System.Int32.Parse("0")
                End Try
            ElseIf index = 25 Then
                Me.Marca = value
            ElseIf index = 26 Then
                Me.Placa = value
            ElseIf index = 27 Then
                Me.Licencia = value
            ElseIf index = 28 Then
                Me.Identidad = value
            ElseIf index = 29 Then
                Me.Marchamo1 = value
            ElseIf index = 30 Then
                Me.Marchamo2 = value
            ElseIf index = 31 Then
                Me.Marchamo3 = value
            ElseIf index = 32 Then
                Me.Marchamo4 = value
            ElseIf index = 33 Then
                Try
                    Me.TiposDoctoID = System.Int32.Parse("0" & value)
                Catch
                    Me.TiposDoctoID = System.Int32.Parse("0")
                End Try
            ElseIf index = 34 Then
                Me.NumCabezal = value
            ElseIf index = 35 Then
                Me.EstadoPesaje = value
            ElseIf index = 36 Then
                Try
                    Me.NumOrdenPesoBioSalc = System.Int32.Parse("0" & value)
                Catch
                    Me.NumOrdenPesoBioSalc = System.Int32.Parse("0")
                End Try
            End If
        End Set
    End Property
    Public Default Property Item(index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde al nombre de la columna)
        Get
            If index = "RemisionID" Then
                Return Me.RemisionID.ToString()
            ElseIf index = "RemNum" Then
                Return Me.RemNum.ToString()
            ElseIf index = "CAI" Then
                Return Me.CAI.ToString()
            ElseIf index = "Fecha" Then
                Return Me.Fecha.ToString()
            ElseIf index = "EmpresaCodigo" Then
                Return Me.EmpresaCodigo.ToString()
            ElseIf index = "SdNCodigo" Then
                Return Me.SdNCodigo.ToString()
            ElseIf index = "DFFactID" Then
                Return Me.DFFactID.ToString()
            ElseIf index = "Estado" Then
                Return Me.Estado.ToString()
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
            ElseIf index = "PuntoPartida" Then
                Return Me.PuntoPartida.ToString()
            ElseIf index = "PuntoDestino" Then
                Return Me.PuntoDestino.ToString()
            ElseIf index = "FechaInicio" Then
                Return Me.FechaInicio.ToString()
            ElseIf index = "FechaFinal" Then
                Return Me.FechaFinal.ToString()
            ElseIf index = "Motivo" Then
                Return Me.Motivo.ToString()
            ElseIf index = "OtroMotivo" Then
                Return Me.OtroMotivo.ToString()
            ElseIf index = "TransportistaID" Then
                Return Me.TransportistaID.ToString()
            ElseIf index = "ConductorID" Then
                Return Me.ConductorID.ToString()
            ElseIf index = "Marca" Then
                Return Me.Marca.ToString()
            ElseIf index = "Placa" Then
                Return Me.Placa.ToString()
            ElseIf index = "Licencia" Then
                Return Me.Licencia.ToString()
            ElseIf index = "Identidad" Then
                Return Me.Identidad.ToString()
            ElseIf index = "Marchamo1" Then
                Return Me.Marchamo1.ToString()
            ElseIf index = "Marchamo2" Then
                Return Me.Marchamo2.ToString()
            ElseIf index = "Marchamo3" Then
                Return Me.Marchamo3.ToString()
            ElseIf index = "Marchamo4" Then
                Return Me.Marchamo4.ToString()
            ElseIf index = "TiposDoctoID" Then
                Return Me.TiposDoctoID.ToString()
            ElseIf index = "NumCabezal" Then
                Return Me.NumCabezal.ToString()
            ElseIf index = "EstadoPesaje" Then
                Return Me.EstadoPesaje.ToString()
            ElseIf index = "NumOrdenPesoBioSalc" Then
                Return Me.NumOrdenPesoBioSalc.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = "RemisionID" Then
                Try
                    Me.RemisionID = System.Int32.Parse("0" & value)
                Catch
                    Me.RemisionID = System.Int32.Parse("0")
                End Try
            ElseIf index = "RemNum" Then
                Me.RemNum = value
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
            ElseIf index = "DFFactID" Then
                Try
                    Me.DFFactID = System.Int32.Parse("0" & value)
                Catch
                    Me.DFFactID = System.Int32.Parse("0")
                End Try
            ElseIf index = "Estado" Then
                Try
                    Me.Estado = System.Int32.Parse("0" & value)
                Catch
                    Me.Estado = System.Int32.Parse("0")
                End Try
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
            ElseIf index = "PuntoPartida" Then
                Me.PuntoPartida = value
            ElseIf index = "PuntoDestino" Then
                Me.PuntoDestino = value
            ElseIf index = "FechaInicio" Then
                Try
                    Me.FechaInicio = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaInicio = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaInicio = System.DateTime.Now
                End Try
            ElseIf index = "FechaFinal" Then
                Try
                    Me.FechaFinal = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaFinal = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaFinal = System.DateTime.Now
                End Try
            ElseIf index = "Motivo" Then
                Try
                    Me.Motivo = System.Int32.Parse("0" & value)
                Catch
                    Me.Motivo = System.Int32.Parse("0")
                End Try
            ElseIf index = "OtroMotivo" Then
                Me.OtroMotivo = value
            ElseIf index = "TransportistaID" Then
                Try
                    Me.TransportistaID = System.Int32.Parse("0" & value)
                Catch
                    Me.TransportistaID = System.Int32.Parse("0")
                End Try
            ElseIf index = "ConductorID" Then
                Try
                    Me.ConductorID = System.Int32.Parse("0" & value)
                Catch
                    Me.ConductorID = System.Int32.Parse("0")
                End Try
            ElseIf index = "Marca" Then
                Me.Marca = value
            ElseIf index = "Placa" Then
                Me.Placa = value
            ElseIf index = "Licencia" Then
                Me.Licencia = value
            ElseIf index = "Identidad" Then
                Me.Identidad = value
            ElseIf index = "Marchamo1" Then
                Me.Marchamo1 = value
            ElseIf index = "Marchamo2" Then
                Me.Marchamo2 = value
            ElseIf index = "Marchamo3" Then
                Me.Marchamo3 = value
            ElseIf index = "Marchamo4" Then
                Me.Marchamo4 = value
            ElseIf index = "TiposDoctoID" Then
                Try
                    Me.TiposDoctoID = System.Int32.Parse("0" & value)
                Catch
                    Me.TiposDoctoID = System.Int32.Parse("0")
                End Try
            ElseIf index = "NumCabezal" Then
                Me.NumCabezal = value
            ElseIf index = "EstadoPesaje" Then
                Me.EstadoPesaje = value
            ElseIf index = "NumOrdenPesoBioSalc" Then
                Try
                    Me.NumOrdenPesoBioSalc = System.Int32.Parse("0" & value)
                Catch
                    Me.NumOrdenPesoBioSalc = System.Int32.Parse("0")
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
    Public Shared CadenaSelect As String = "SELECT * FROM IDF_Remisiones"
    '
    Public Sub New()
    End Sub
    Public Sub New(conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto IDF_Remisiones
    Private Shared Function row2IDF_Remisiones(r As DataRow) As IDF_Remisiones
        ' asigna a un objeto IDF_Remisiones los datos del dataRow indicado
        Dim oIDF_Remisiones As New IDF_Remisiones
        '
        oIDF_Remisiones.RemisionID = System.Int32.Parse("0" & r("RemisionID").ToString())
        oIDF_Remisiones.RemNum = r("RemNum").ToString()
        oIDF_Remisiones.CAI = r("CAI").ToString()
        Try
            oIDF_Remisiones.Fecha = DateTime.Parse(r("Fecha").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oIDF_Remisiones.Fecha = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oIDF_Remisiones.Fecha = DateTime.Now
        End Try
        oIDF_Remisiones.EmpresaCodigo = r("EmpresaCodigo").ToString()
        oIDF_Remisiones.SdNCodigo = r("SdNCodigo").ToString()
        oIDF_Remisiones.DFFactID = System.Int32.Parse("0" & r("DFFactID").ToString())
        oIDF_Remisiones.Estado = System.Int32.Parse("0" & r("Estado").ToString())
        oIDF_Remisiones.UsuCreador = r("UsuCreador").ToString()
        Try
            oIDF_Remisiones.FechaCreacion = DateTime.Parse(r("FechaCreacion").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oIDF_Remisiones.FechaCreacion = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oIDF_Remisiones.FechaCreacion = DateTime.Now
        End Try
        oIDF_Remisiones.UsuEditor = r("UsuEditor").ToString()
        Try
            oIDF_Remisiones.FechaEdicion = DateTime.Parse(r("FechaEdicion").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oIDF_Remisiones.FechaEdicion = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oIDF_Remisiones.FechaEdicion = DateTime.Now
        End Try
        oIDF_Remisiones.UsuAnulacion = r("UsuAnulacion").ToString()
        Try
            oIDF_Remisiones.FechaAnulacion = DateTime.Parse(r("FechaAnulacion").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oIDF_Remisiones.FechaAnulacion = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oIDF_Remisiones.FechaAnulacion = DateTime.Now
        End Try
        oIDF_Remisiones.UsuImpresion = r("UsuImpresion").ToString()
        Try
            oIDF_Remisiones.FechaImpresion = DateTime.Parse(r("FechaImpresion").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oIDF_Remisiones.FechaImpresion = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oIDF_Remisiones.FechaImpresion = DateTime.Now
        End Try
        Try
            oIDF_Remisiones.estaImpreso = System.Boolean.Parse(r("estaImpreso").ToString())
        Catch
            oIDF_Remisiones.estaImpreso = False
        End Try
        oIDF_Remisiones.PuntoPartida = r("PuntoPartida").ToString()
        oIDF_Remisiones.PuntoDestino = r("PuntoDestino").ToString()
        Try
            oIDF_Remisiones.FechaInicio = DateTime.Parse(r("FechaInicio").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oIDF_Remisiones.FechaInicio = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oIDF_Remisiones.FechaInicio = DateTime.Now
        End Try
        Try
            oIDF_Remisiones.FechaFinal = DateTime.Parse(r("FechaFinal").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oIDF_Remisiones.FechaFinal = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oIDF_Remisiones.FechaFinal = DateTime.Now
        End Try
        oIDF_Remisiones.Motivo = System.Int32.Parse("0" & r("Motivo").ToString())
        oIDF_Remisiones.OtroMotivo = r("OtroMotivo").ToString()
        oIDF_Remisiones.TransportistaID = System.Int32.Parse("0" & r("TransportistaID").ToString())
        oIDF_Remisiones.ConductorID = System.Int32.Parse("0" & r("ConductorID").ToString())
        oIDF_Remisiones.Marca = r("Marca").ToString()
        oIDF_Remisiones.Placa = r("Placa").ToString()
        oIDF_Remisiones.Licencia = r("Licencia").ToString()
        oIDF_Remisiones.Identidad = r("Identidad").ToString()
        oIDF_Remisiones.Marchamo1 = r("Marchamo1").ToString()
        oIDF_Remisiones.Marchamo2 = r("Marchamo2").ToString()
        oIDF_Remisiones.Marchamo3 = r("Marchamo3").ToString()
        oIDF_Remisiones.Marchamo4 = r("Marchamo4").ToString()
        oIDF_Remisiones.TiposDoctoID = System.Int32.Parse("0" & r("TiposDoctoID").ToString())
        oIDF_Remisiones.NumCabezal = r("NumCabezal").ToString()
        oIDF_Remisiones.EstadoPesaje = r("EstadoPesaje").ToString()
        oIDF_Remisiones.NumOrdenPesoBioSalc = System.Int32.Parse("0" & r("NumOrdenPesoBioSalc").ToString())
        '
        Return oIDF_Remisiones
    End Function
    '
    ' asigna un objeto IDF_Remisiones a la fila indicada
    Private Shared Sub IDF_Remisiones2Row(oIDF_Remisiones As IDF_Remisiones, r As DataRow)
        ' asigna un objeto IDF_Remisiones al dataRow indicado
        ' TODO: Comprueba si esta asignación debe hacerse
        '       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        'r("RemisionID") = oIDF_Remisiones.RemisionID
        r("RemNum") = oIDF_Remisiones.RemNum
        r("CAI") = oIDF_Remisiones.CAI
        r("Fecha") = oIDF_Remisiones.Fecha
        r("EmpresaCodigo") = oIDF_Remisiones.EmpresaCodigo
        r("SdNCodigo") = oIDF_Remisiones.SdNCodigo
        r("DFFactID") = oIDF_Remisiones.DFFactID
        r("Estado") = oIDF_Remisiones.Estado
        r("UsuCreador") = oIDF_Remisiones.UsuCreador
        r("FechaCreacion") = oIDF_Remisiones.FechaCreacion
        r("UsuEditor") = oIDF_Remisiones.UsuEditor
        r("FechaEdicion") = oIDF_Remisiones.FechaEdicion
        r("UsuAnulacion") = oIDF_Remisiones.UsuAnulacion
        r("FechaAnulacion") = oIDF_Remisiones.FechaAnulacion
        r("UsuImpresion") = oIDF_Remisiones.UsuImpresion
        r("FechaImpresion") = oIDF_Remisiones.FechaImpresion
        r("estaImpreso") = oIDF_Remisiones.estaImpreso
        r("PuntoPartida") = oIDF_Remisiones.PuntoPartida
        r("PuntoDestino") = oIDF_Remisiones.PuntoDestino
        r("FechaInicio") = oIDF_Remisiones.FechaInicio
        r("FechaFinal") = oIDF_Remisiones.FechaFinal
        r("Motivo") = oIDF_Remisiones.Motivo
        r("OtroMotivo") = oIDF_Remisiones.OtroMotivo
        r("TransportistaID") = oIDF_Remisiones.TransportistaID
        r("ConductorID") = oIDF_Remisiones.ConductorID
        r("Marca") = oIDF_Remisiones.Marca
        r("Placa") = oIDF_Remisiones.Placa
        r("Licencia") = oIDF_Remisiones.Licencia
        r("Identidad") = oIDF_Remisiones.Identidad
        r("Marchamo1") = oIDF_Remisiones.Marchamo1
        r("Marchamo2") = oIDF_Remisiones.Marchamo2
        r("Marchamo3") = oIDF_Remisiones.Marchamo3
        r("Marchamo4") = oIDF_Remisiones.Marchamo4
        r("TiposDoctoID") = oIDF_Remisiones.TiposDoctoID
        r("NumCabezal") = oIDF_Remisiones.NumCabezal
        r("EstadoPesaje") = oIDF_Remisiones.EstadoPesaje
        r("NumOrdenPesoBioSalc") = oIDF_Remisiones.NumOrdenPesoBioSalc
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto IDF_Remisiones
    Private Shared Sub nuevoIDF_Remisiones(dt As DataTable, oIDF_Remisiones As IDF_Remisiones)
        ' Crear un nuevo IDF_Remisiones
        Dim dr As DataRow = dt.NewRow()
        Dim oI As IDF_Remisiones = row2IDF_Remisiones(dr)
        '
        oI.RemisionID = oIDF_Remisiones.RemisionID
        oI.RemNum = oIDF_Remisiones.RemNum
        oI.CAI = oIDF_Remisiones.CAI
        oI.Fecha = oIDF_Remisiones.Fecha
        oI.EmpresaCodigo = oIDF_Remisiones.EmpresaCodigo
        oI.SdNCodigo = oIDF_Remisiones.SdNCodigo
        oI.DFFactID = oIDF_Remisiones.DFFactID
        oI.Estado = oIDF_Remisiones.Estado
        oI.UsuCreador = oIDF_Remisiones.UsuCreador
        oI.FechaCreacion = oIDF_Remisiones.FechaCreacion
        oI.UsuEditor = oIDF_Remisiones.UsuEditor
        oI.FechaEdicion = oIDF_Remisiones.FechaEdicion
        oI.UsuAnulacion = oIDF_Remisiones.UsuAnulacion
        oI.FechaAnulacion = oIDF_Remisiones.FechaAnulacion
        oI.UsuImpresion = oIDF_Remisiones.UsuImpresion
        oI.FechaImpresion = oIDF_Remisiones.FechaImpresion
        oI.estaImpreso = oIDF_Remisiones.estaImpreso
        oI.PuntoPartida = oIDF_Remisiones.PuntoPartida
        oI.PuntoDestino = oIDF_Remisiones.PuntoDestino
        oI.FechaInicio = oIDF_Remisiones.FechaInicio
        oI.FechaFinal = oIDF_Remisiones.FechaFinal
        oI.Motivo = oIDF_Remisiones.Motivo
        oI.OtroMotivo = oIDF_Remisiones.OtroMotivo
        oI.TransportistaID = oIDF_Remisiones.TransportistaID
        oI.ConductorID = oIDF_Remisiones.ConductorID
        oI.Marca = oIDF_Remisiones.Marca
        oI.Placa = oIDF_Remisiones.Placa
        oI.Licencia = oIDF_Remisiones.Licencia
        oI.Identidad = oIDF_Remisiones.Identidad
        oI.Marchamo1 = oIDF_Remisiones.Marchamo1
        oI.Marchamo2 = oIDF_Remisiones.Marchamo2
        oI.Marchamo3 = oIDF_Remisiones.Marchamo3
        oI.Marchamo4 = oIDF_Remisiones.Marchamo4
        oI.TiposDoctoID = oIDF_Remisiones.TiposDoctoID
        oI.NumCabezal = oIDF_Remisiones.NumCabezal
        oI.EstadoPesaje = oIDF_Remisiones.EstadoPesaje
        oI.NumOrdenPesoBioSalc = oIDF_Remisiones.NumOrdenPesoBioSalc
        '
        IDF_Remisiones2Row(oI, dr)
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
        ' devuelve una tabla con los datos de la tabla IDF_Remisiones
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_Remisiones")
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
    Public Shared Function Buscar(sWhere As String) As IDF_Remisiones
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oIDF_Remisiones As IDF_Remisiones = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_Remisiones")
        Dim sel As String = "SELECT * FROM IDF_Remisiones WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oIDF_Remisiones = row2IDF_Remisiones(dt.Rows(0))
        End If
        Return oIDF_Remisiones
    End Function
    '
    ' Actualizar: Actualiza los datos en la tabla usando la instancia actual
    '             Si la instancia no hace referencia a un registro existente, se creará uno nuevo
    '             Para comprobar si el objeto en memoria coincide con uno existente,
    '             se comprueba si el RemisionID existe en la tabla.
    '             TODO: Si en lugar de RemisionID usas otro campo, indicalo en la cadena SELECT
    '                   También puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    Public Function Actualizar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el RemisionID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_Remisiones WHERE RemisionID = " & Me.RemisionID.ToString()
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(sel As String) As String
        ' Actualiza los datos indicados
        ' El parámetro, que es una cadena de selección, indicará el criterio de actualización
        '
        ' En caso de error, devolverá la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_Remisiones")
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
        '       Yo compruebo que sea un campo llamado RemisionID, pero en tu caso puede ser otro
        '       Ese campo, (en mi caso RemisionID) será el que hay que poner al final junto al WHERE.
        sCommand = "UPDATE IDF_Remisiones SET RemNum = @RemNum, CAI = @CAI, Fecha = @Fecha, EmpresaCodigo = @EmpresaCodigo, SdNCodigo = @SdNCodigo, DFFactID = @DFFactID, Estado = @Estado, UsuCreador = @UsuCreador, FechaCreacion = @FechaCreacion, UsuEditor = @UsuEditor, FechaEdicion = @FechaEdicion, UsuAnulacion = @UsuAnulacion, FechaAnulacion = @FechaAnulacion, UsuImpresion = @UsuImpresion, FechaImpresion = @FechaImpresion, estaImpreso = @estaImpreso, PuntoPartida = @PuntoPartida, PuntoDestino = @PuntoDestino, FechaInicio = @FechaInicio, FechaFinal = @FechaFinal, Motivo = @Motivo, OtroMotivo = @OtroMotivo, TransportistaID = @TransportistaID, ConductorID = @ConductorID, Marca = @Marca, Placa = @Placa, Licencia = @Licencia, Identidad = @Identidad, Marchamo1 = @Marchamo1, Marchamo2 = @Marchamo2, Marchamo3 = @Marchamo3, Marchamo4 = @Marchamo4, TiposDoctoID = @TiposDoctoID, NumCabezal = @NumCabezal, EstadoPesaje = @EstadoPesaje, NumOrdenPesoBioSalc = @NumOrdenPesoBioSalc  WHERE (RemisionID = @RemisionID)"
        da.UpdateCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@RemisionID", SqlDbType.Int, 0, "RemisionID")
        da.UpdateCommand.Parameters.Add("@RemNum", SqlDbType.NVarChar, 25, "RemNum")
        da.UpdateCommand.Parameters.Add("@CAI", SqlDbType.NVarChar, 60, "CAI")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@Fecha", SqlDbType.DateTime, 0, "Fecha")
        da.UpdateCommand.Parameters.Add("@EmpresaCodigo", SqlDbType.NVarChar, 5, "EmpresaCodigo")
        da.UpdateCommand.Parameters.Add("@SdNCodigo", SqlDbType.NVarChar, 10, "SdNCodigo")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@DFFactID", SqlDbType.Int, 0, "DFFactID")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@Estado", SqlDbType.Int, 0, "Estado")
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
        da.UpdateCommand.Parameters.Add("@PuntoPartida", SqlDbType.NVarChar, 100, "PuntoPartida")
        da.UpdateCommand.Parameters.Add("@PuntoDestino", SqlDbType.NVarChar, 100, "PuntoDestino")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@FechaInicio", SqlDbType.DateTime, 0, "FechaInicio")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@FechaFinal", SqlDbType.DateTime, 0, "FechaFinal")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@Motivo", SqlDbType.Int, 0, "Motivo")
        da.UpdateCommand.Parameters.Add("@OtroMotivo", SqlDbType.NVarChar, 25, "OtroMotivo")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@TransportistaID", SqlDbType.Int, 0, "TransportistaID")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@ConductorID", SqlDbType.Int, 0, "ConductorID")
        da.UpdateCommand.Parameters.Add("@Marca", SqlDbType.NVarChar, 25, "Marca")
        da.UpdateCommand.Parameters.Add("@Placa", SqlDbType.NVarChar, 12, "Placa")
        da.UpdateCommand.Parameters.Add("@Licencia", SqlDbType.NVarChar, 25, "Licencia")
        da.UpdateCommand.Parameters.Add("@Identidad", SqlDbType.NVarChar, 25, "Identidad")
        da.UpdateCommand.Parameters.Add("@Marchamo1", SqlDbType.NVarChar, 25, "Marchamo1")
        da.UpdateCommand.Parameters.Add("@Marchamo2", SqlDbType.NVarChar, 25, "Marchamo2")
        da.UpdateCommand.Parameters.Add("@Marchamo3", SqlDbType.NVarChar, 25, "Marchamo3")
        da.UpdateCommand.Parameters.Add("@Marchamo4", SqlDbType.NVarChar, 25, "Marchamo4")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@TiposDoctoID", SqlDbType.Int, 0, "TiposDoctoID")
        da.UpdateCommand.Parameters.Add("@EstadoPesaje", SqlDbType.NVarChar, 10, "EstadoPesaje")
        da.UpdateCommand.Parameters.Add("@NumCabezal", SqlDbType.NVarChar, 0, "NumCabezal")
        da.UpdateCommand.Parameters.Add("@NumOrdenPesoBioSalc", SqlDbType.Int, 0, "NumOrdenPesoBioSalc")
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
            IDF_Remisiones2Row(Me, dt.Rows(0))
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
        Dim dt As New DataTable("IDF_Remisiones")
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
        '       Yo compruebo que sea un campo llamado RemisionID, pero en tu caso puede ser otro
        sCommand = "IDF_RemisionesInsert" '"INSERT INTO IDF_Remisiones (RemNum, CAI, Fecha, EmpresaCodigo, SdNCodigo, DFFactID, Estado, UsuCreador, FechaCreacion, UsuEditor, FechaEdicion, UsuAnulacion, FechaAnulacion, UsuImpresion, FechaImpresion, estaImpreso, PuntoPartida, PuntoDestino, FechaInicio, FechaFinal, Motivo, OtroMotivo, TransportistaID, ConductorID, Marca, Placa, Licencia, Identidad, Marchamo1, Marchamo2, Marchamo3, Marchamo4, TiposDoctoID, NumCabezal)  VALUES(@RemNum, @CAI, @Fecha, @EmpresaCodigo, @SdNCodigo, @DFFactID, @Estado, @UsuCreador, @FechaCreacion, @UsuEditor, @FechaEdicion, @UsuAnulacion, @FechaAnulacion, @UsuImpresion, @FechaImpresion, @estaImpreso, @PuntoPartida, @PuntoDestino, @FechaInicio, @FechaFinal, @Motivo, @OtroMotivo, @TransportistaID, @ConductorID, @Marca, @Placa, @Licencia, @Identidad, @Marchamo1, @Marchamo2, @Marchamo3, @Marchamo4, @TiposDoctoID, @NumCabezal)"
        da.InsertCommand = New SqlCommand(sCommand, cnn)
        da.InsertCommand.CommandType = CommandType.StoredProcedure

        ' Ariel Cabrera, evitar que se duplique un numero.
        'da.InsertCommand.Parameters.Add("@RemisionID", SqlDbType.Int, 0, "RemisionID")
        'da.InsertCommand.Parameters.Add("@RemNum", SqlDbType.NVarChar, 25, "RemNum")

        da.InsertCommand.Parameters.Add("@CAI", SqlDbType.NVarChar, 60, "CAI")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@Fecha", SqlDbType.DateTime, 100, "Fecha")
        da.InsertCommand.Parameters.Add("@EmpresaCodigo", SqlDbType.NVarChar, 5, "EmpresaCodigo")
        da.InsertCommand.Parameters.Add("@SdNCodigo", SqlDbType.NVarChar, 10, "SdNCodigo")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@DFFactID", SqlDbType.Int, 0, "DFFactID")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@Estado", SqlDbType.Int, 0, "Estado")
        da.InsertCommand.Parameters.Add("@UsuCreador", SqlDbType.NVarChar, 25, "UsuCreador")
        ' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 0, "FechaCreacion")
        'da.InsertCommand.Parameters.Add("@UsuEditor", SqlDbType.NVarChar, 25, "UsuEditor")
        ' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@FechaEdicion", SqlDbType.DateTime, 0, "FechaEdicion")
        'da.InsertCommand.Parameters.Add("@UsuAnulacion", SqlDbType.NVarChar, 25, "UsuAnulacion")
        ' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@FechaAnulacion", SqlDbType.DateTime, 0, "FechaAnulacion")
        'da.InsertCommand.Parameters.Add("@UsuImpresion", SqlDbType.NVarChar, 25, "UsuImpresion")
        ' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@FechaImpresion", SqlDbType.DateTime, 0, "FechaImpresion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@estaImpreso", SqlDbType.Bit, 0, "estaImpreso")
        da.InsertCommand.Parameters.Add("@PuntoPartida", SqlDbType.NVarChar, 100, "PuntoPartida")
        da.InsertCommand.Parameters.Add("@PuntoDestino", SqlDbType.NVarChar, 100, "PuntoDestino")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@FechaInicio", SqlDbType.DateTime, 0, "FechaInicio")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@FechaFinal", SqlDbType.DateTime, 0, "FechaFinal")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@Motivo", SqlDbType.Int, 0, "Motivo")
        da.InsertCommand.Parameters.Add("@OtroMotivo", SqlDbType.NVarChar, 25, "OtroMotivo")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@TransportistaID", SqlDbType.Int, 0, "TransportistaID")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@ConductorID", SqlDbType.Int, 0, "ConductorID")
        da.InsertCommand.Parameters.Add("@Marca", SqlDbType.NVarChar, 25, "Marca")
        da.InsertCommand.Parameters.Add("@Placa", SqlDbType.NVarChar, 12, "Placa")
        da.InsertCommand.Parameters.Add("@Licencia", SqlDbType.NVarChar, 25, "Licencia")
        da.InsertCommand.Parameters.Add("@Identidad", SqlDbType.NVarChar, 25, "Identidad")
        da.InsertCommand.Parameters.Add("@Marchamo1", SqlDbType.NVarChar, 25, "Marchamo1")
        da.InsertCommand.Parameters.Add("@Marchamo2", SqlDbType.NVarChar, 25, "Marchamo2")
        da.InsertCommand.Parameters.Add("@Marchamo3", SqlDbType.NVarChar, 25, "Marchamo3")
        da.InsertCommand.Parameters.Add("@Marchamo4", SqlDbType.NVarChar, 25, "Marchamo4")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@TiposDoctoID", SqlDbType.Int, 0, "TiposDoctoID")
        da.InsertCommand.Parameters.Add("@NumCabezal", SqlDbType.NVarChar, 0, "NumCabezal")
        da.InsertCommand.Parameters.Add("@EstadoPesaje", SqlDbType.NVarChar, 10, "EstadoPesaje")
        da.InsertCommand.Parameters.Add("@NumOrdenPesoBioSalc", SqlDbType.Int, 0, "NumOrdenPesoBioSalc")
        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoIDF_Remisiones(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo IDF_Remisiones"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el RemisionID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_Remisiones WHERE RemisionID = " & Me.RemisionID.ToString()
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_Remisiones")
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
        '       Yo compruebo que sea un campo llamado RemisionID, pero en tu caso puede ser otro
        sCommand = "DELETE FROM IDF_Remisiones WHERE (RemisionID = @p1)"
        da.DeleteCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.DeleteCommand.Parameters.Add("@p1", SqlDbType.Int, 0, "RemisionID")
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
    Public Shared Function SigRemision(nIntT As Integer, strEmpresa As String) As Integer
        Dim nRes = 0
        Try
            ' Busca en la tabla los datos indicados en el parámetro
            ' el parámetro contendrá lo que se usará después del WHERE
            Dim oIDF_Remisiones As IDF_Remisiones = Nothing
            Dim da As SqlDataAdapter
            Dim dt As New DataTable("IDF_Remisiones")
            Dim sel As String = ""
            '
            sel = "SELECT Top 1 RemNum FROM IDF_Remisiones " & _
                "Where TiposDoctoID in (4) and EmpresaCodigo = '" & strEmpresa & "' Order by RemNum Desc "

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

    Public Shared Function SigRemisionCAI(nIntT As Integer,
                                       strEmpresa As String,
                                       strCAI As String) As Integer
        Dim nRes = 0
        Try
            ' Busca en la tabla los datos indicados en el parámetro
            ' el parámetro contendrá lo que se usará después del WHERE
            Dim oIDF_DFDescrip As IDF_DFDescrip = Nothing
            Dim da As SqlDataAdapter
            Dim dt As New DataTable("IDF_Remisiones")
            Dim sel As String

            sel = "SELECT Top 1 RemNum FROM IDF_Remisiones " & _
                  "Where TiposDoctoID in (4) and EmpresaCodigo = '" & strEmpresa & _
                  "' AND CAI = '" & strCAI & "'" & _
                  " Order by RemNum Desc "

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
