Public Class ClsEntiAPR
    Public Class ClsAprGenerarOdtQuema
        ' Las variables privadas
        ' TODO: Revisar los tipos de los campos
        Private _PeriodoID As System.Int32
        Private _FincaID As System.String
        Private _LoteID As System.String
        Private _Fecha As System.String
        Private _Activo As System.Int32
        Private _Accidental As System.Int32
        Private _QuemaID As System.Int32
        Private _Cruda As System.Int32
        Private _Usuario As System.String
        Private _Area As System.Double
        Private _CorteFrenteID As System.Int32
        Private _Doble As System.Int32

        Private _horaOrden As System.String
        Private _horaBascula As System.String
        Private _horaInicioArrastre As System.String
        Private _horaFinalArrastre As System.String
        Private _corteEstimadoTons As System.Decimal
        Private _corteEjecutadoTons As System.Decimal
        Private _horaPreBatey As System.String
        Private _areaEstimada As System.Decimal
        Private _areaEjecutado As System.Decimal

        ' Este método se usará para ajustar los anchos de las propiedades
        Private Function ajustarAncho(cadena As String, ancho As Integer) As String
            Dim sb As New System.Text.StringBuilder(New String(" "c, ancho))
            ' devolver la cadena quitando los espacios en blanco
            ' esto asegura que no se devolverá un tamaño mayor ni espacios "extras"
            Return (cadena & sb.ToString()).Substring(0, ancho).Trim()
        End Function

        ' Las propiedades públicas
        ' TODO: Revisar los tipos de las propiedades
        Public Property PeriodoID() As System.Int32
            Get
                Return _PeriodoID
            End Get
            Set(value As System.Int32)
                _PeriodoID = value
            End Set
        End Property
        Public Property FincaID() As System.String
            Get
                Return ajustarAncho(_FincaID, 10)
            End Get
            Set(value As System.String)
                _FincaID = value
            End Set
        End Property
        Public Property LoteID() As System.String
            Get
                Return ajustarAncho(_LoteID, 10)
            End Get
            Set(value As System.String)
                _LoteID = value
            End Set
        End Property
        Public Property Fecha() As System.String
            Get
                Return _Fecha
            End Get
            Set(value As System.String)
                _Fecha = value
            End Set
        End Property
        Public Property Activo() As System.Boolean
            Get
                Return _Activo
            End Get
            Set(value As System.Boolean)
                _Activo = value
            End Set
        End Property
        Public Property Accidental() As System.Int32
            Get
                Return _Accidental
            End Get
            Set(value As System.Int32)
                _Accidental = value
            End Set
        End Property
        Public Property QuemaID() As System.Int32
            Get
                Return _QuemaID
            End Get
            Set(value As System.Int32)
                _QuemaID = value
            End Set
        End Property
        Public Property Cruda() As System.Int32
            Get
                Return _Cruda
            End Get
            Set(value As System.Int32)
                _Cruda = value
            End Set
        End Property
        Public Property Usuario() As System.String
            Get
                Return ajustarAncho(_Usuario, 11)
            End Get
            Set(value As System.String)
                _Usuario = value
            End Set
        End Property
        Public Property Area() As System.Double
            Get
                Return _Area
            End Get
            Set(value As System.Double)
                _Area = value
            End Set
        End Property
        Public Property CorteFrenteID() As System.Int32
            Get
                Return _CorteFrenteID
            End Get
            Set(value As System.Int32)
                _CorteFrenteID = value
            End Set
        End Property
        Public Property Doble() As System.Int32
            Get
                Return _Doble
            End Get
            Set(value As System.Int32)
                _Doble = value
            End Set
        End Property

        Public Property horaOrden() As System.String
            Get
                Return _horaOrden
            End Get
            Set(value As System.String)
                _horaOrden = value
            End Set
        End Property
        Public Property horaBascula() As System.String
            Get
                Return _horaBascula
            End Get
            Set(value As System.String)
                _horaBascula = value
            End Set
        End Property
        Public Property horaInicioArrastre() As System.String
            Get
                Return _horaInicioArrastre
            End Get
            Set(value As System.String)
                _horaInicioArrastre = value
            End Set
        End Property
        Public Property horaFinalArrastre() As System.String
            Get
                Return _horaFinalArrastre
            End Get
            Set(value As System.String)
                _horaFinalArrastre = value
            End Set
        End Property
        Public Property corteEstimadoTons() As System.Decimal
            Get
                Return _corteEstimadoTons
            End Get
            Set(value As System.Decimal)
                _corteEstimadoTons = value
            End Set
        End Property
        Public Property corteEjecutadoTons() As System.Decimal
            Get
                Return _corteEjecutadoTons
            End Get
            Set(value As System.Decimal)
                _corteEjecutadoTons = value
            End Set
        End Property
        Public Property horaHoraPreBatey() As System.String
            Get
                Return _horaPreBatey
            End Get
            Set(value As System.String)
                _horaPreBatey = value
            End Set
        End Property
        Public Property areaEstimada() As System.Decimal
            Get
                Return _areaEstimada
            End Get
            Set(value As System.Decimal)
                _areaEstimada = value
            End Set
        End Property
        Public Property areaEjecutado() As System.Decimal
            Get
                Return _areaEjecutado
            End Get
            Set(value As System.Decimal)
                _areaEjecutado = value
            End Set
        End Property
    End Class

    Public Class ClsBprAvanceCosecha
        ' Las variables privadas
        ' TODO: Revisar los tipos de los campos
        Private _PeriodoID As System.Int32
        Private _Fecha As System.String

        ' Este método se usará para ajustar los anchos de las propiedades
        Private Function ajustarAncho(cadena As String, ancho As Integer) As String
            Dim sb As New System.Text.StringBuilder(New String(" "c, ancho))
            ' devolver la cadena quitando los espacios en blanco
            ' esto asegura que no se devolverá un tamaño mayor ni espacios "extras"
            Return (cadena & sb.ToString()).Substring(0, ancho).Trim()
        End Function

        ' Las propiedades públicas
        ' TODO: Revisar los tipos de las propiedades
        Public Property PeriodoID() As System.Int32
            Get
                Return _PeriodoID
            End Get
            Set(value As System.Int32)
                _PeriodoID = value
            End Set
        End Property
       
        Public Property Fecha() As System.String
            Get
                Return _Fecha
            End Get
            Set(value As System.String)
                _Fecha = value
            End Set
        End Property
    End Class

    Public Class CPR_EstimadoProduccion
        ' Las variables privadas
        ' TODO: Revisar los tipos de los campos
        Private _EstimadoProduccionID As System.Int32
        Private _EstimadoID As System.Int32
        Private _LoteID As System.String
        Private _TipoCanaID As System.Int32
        Private _CicloID As System.Int32
        Private _TipoSueloID As System.Int32
        Private _DrenajeID As System.Int32
        Private _DistanciaID As System.Int32
        Private _Area As System.Double
        Private _AreaEjecutada As System.Double
        Private _Rendimiento As System.Double
        Private _TonsEstimadas As System.Double
        Private _RendimientoLab As System.Double
        Private _Comentario As System.String
        Private _FechaCorte As System.String
        Private _FechaEstimada As System.DateTime
        Private _FechaCreacion As System.DateTime
        Private _FechaModificacion As System.DateTime
        Private _UsuarioCreador As System.String
        Private _UsuarioEditor As System.String
        Private _IDZafra As System.Int32
        Private _TipoEstimadoID As System.Int32
        Private _ZonaID As System.Int32
        Private _EstaTerminado As System.Boolean
        Private _FincaID As System.String
        Private _DistritoID As System.String
        Private _Edad1 As Decimal
        Private _Edad2 As Decimal
        Private _Rendi1 As Decimal
        Private _Rendi2 As Decimal
        Private _Ciclo1 As System.String
        Private _Ciclo2 As System.String
        Private _Distancia1 As Decimal
        Private _Distancia2 As Decimal
        Private _FecE1 As System.String
        Private _FecE2 As System.String
        Private _Variedad As System.String
        Private _Textura As System.String
        Private _fDistrito As System.Int32
        Private _fDrenaje As System.Int32
        Private _fZona As System.Int32
        Private _fFinca As System.Int32
        Private _fCiclo As System.Int32
        Private _fDistancia As System.Int32
        Private _fFecE As System.Int32
        Private _fEdad As System.Int32
        Private _fRendi As System.Int32
        Private _fVariedad As System.Int32
        Private _fTextura As System.Int32
        Private _FrenteID As System.Int32
        Private _FechaProyeccion As System.String

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
        Public Property EstimadoProduccionID() As System.Int32
            Get
                Return _EstimadoProduccionID
            End Get
            Set(value As System.Int32)
                _EstimadoProduccionID = value
            End Set
        End Property
        Public Property EstimadoID() As System.Int32
            Get
                Return _EstimadoID
            End Get
            Set(value As System.Int32)
                _EstimadoID = value
            End Set
        End Property
        Public Property LoteID() As System.String
            Get
                Return ajustarAncho(_LoteID, 6)
            End Get
            Set(value As System.String)
                _LoteID = value
            End Set
        End Property
        Public Property TipoCanaID() As System.Int32
            Get
                Return _TipoCanaID
            End Get
            Set(value As System.Int32)
                _TipoCanaID = value
            End Set
        End Property
        Public Property CicloID() As System.Int32
            Get
                Return _CicloID
            End Get
            Set(value As System.Int32)
                _CicloID = value
            End Set
        End Property
        Public Property TipoSueloID() As System.Int32
            Get
                Return _TipoSueloID
            End Get
            Set(value As System.Int32)
                _TipoSueloID = value
            End Set
        End Property
        Public Property DrenajeID() As System.Int32
            Get
                Return _DrenajeID
            End Get
            Set(value As System.Int32)
                _DrenajeID = value
            End Set
        End Property
        Public Property DistanciaID() As System.Int32
            Get
                Return _DistanciaID
            End Get
            Set(value As System.Int32)
                _DistanciaID = value
            End Set
        End Property
        Public Property Area() As System.Double
            Get
                Return _Area
            End Get
            Set(value As System.Double)
                _Area = value
            End Set
        End Property
        Public Property AreaEjecutada() As System.Double
            Get
                Return _AreaEjecutada
            End Get
            Set(value As System.Double)
                _AreaEjecutada = value
            End Set
        End Property
        Public Property Rendimiento() As System.Double
            Get
                Return _Rendimiento
            End Get
            Set(value As System.Double)
                _Rendimiento = value
            End Set
        End Property
        Public Property TonsEstimadas() As System.Double
            Get
                Return _TonsEstimadas
            End Get
            Set(value As System.Double)
                _TonsEstimadas = value
            End Set
        End Property
        Public Property RendimientoLab() As System.Double
            Get
                Return _RendimientoLab
            End Get
            Set(value As System.Double)
                _RendimientoLab = value
            End Set
        End Property
        Public Property Comentario() As System.String
            Get
                Return ajustarAncho(_Comentario, 100)
            End Get
            Set(value As System.String)
                _Comentario = value
            End Set
        End Property
        Public Property FechaCorte() As System.String
            Get
                Return _FechaCorte
            End Get
            Set(value As System.String)
                _FechaCorte = value
            End Set
        End Property
        Public Property FechaEstimada() As System.DateTime
            Get
                Return _FechaEstimada
            End Get
            Set(value As System.DateTime)
                _FechaEstimada = value
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
        Public Property FechaModificacion() As System.DateTime
            Get
                Return _FechaModificacion
            End Get
            Set(value As System.DateTime)
                _FechaModificacion = value
            End Set
        End Property
        Public Property UsuarioCreador() As System.String
            Get
                Return ajustarAncho(_UsuarioCreador, 50)
            End Get
            Set(value As System.String)
                _UsuarioCreador = value
            End Set
        End Property
        Public Property UsuarioEditor() As System.String
            Get
                Return ajustarAncho(_UsuarioEditor, 50)
            End Get
            Set(value As System.String)
                _UsuarioEditor = value
            End Set
        End Property
        Public Property IDZafra() As System.Int32
            Get
                Return _IDZafra
            End Get
            Set(value As System.Int32)
                _IDZafra = value
            End Set
        End Property
        Public Property TipoEstimadoID() As System.Int32
            Get
                Return _TipoEstimadoID
            End Get
            Set(value As System.Int32)
                _TipoEstimadoID = value
            End Set
        End Property
        Public Property ZonaID() As System.Int32
            Get
                Return _ZonaID
            End Get
            Set(value As System.Int32)
                _ZonaID = value
            End Set
        End Property
        Public Property EstaTerminado() As System.Boolean
            Get
                Return _EstaTerminado
            End Get
            Set(value As System.Boolean)
                _EstaTerminado = value
            End Set
        End Property
        Public Property FincaID() As System.String
            Get
                Return ajustarAncho(_FincaID, 10)
            End Get
            Set(value As System.String)
                _FincaID = value
            End Set
        End Property
        Public Property DistritoID() As System.String
            Get
                Return _DistritoID
            End Get
            Set(value As System.String)
                _DistritoID = value
            End Set
        End Property
        Public Property Edad1() As System.Decimal
            Get
                Return _Edad1
            End Get
            Set(value As System.Decimal)
                _Edad1 = value
            End Set
        End Property
        Public Property Edad2() As System.Decimal
            Get
                Return _Edad2
            End Get
            Set(value As System.Decimal)
                _Edad2 = value
            End Set
        End Property
        Public Property Rendi1() As System.Decimal
            Get
                Return _Rendi1
            End Get
            Set(value As System.Decimal)
                _Rendi1 = value
            End Set
        End Property
        Public Property Rendi2() As System.Decimal
            Get
                Return _Rendi2
            End Get
            Set(value As System.Decimal)
                _Rendi2 = value
            End Set
        End Property
        Public Property Ciclo1() As System.String
            Get
                Return _Ciclo1
            End Get
            Set(value As System.String)
                _Ciclo1 = value
            End Set
        End Property
        Public Property Ciclo2() As System.String
            Get
                Return _Ciclo2
            End Get
            Set(value As System.String)
                _Ciclo2 = value
            End Set
        End Property
        Public Property Distancia1() As System.Decimal
            Get
                Return _Distancia1
            End Get
            Set(value As System.Decimal)
                _Distancia1 = value
            End Set
        End Property
        Public Property Distancia2() As System.Decimal
            Get
                Return _Distancia2
            End Get
            Set(value As System.Decimal)
                _Distancia2 = value
            End Set
        End Property
        Public Property FecE1() As System.String
            Get
                Return _FecE1
            End Get
            Set(value As System.String)
                _FecE1 = value
            End Set
        End Property
        Public Property FecE2() As System.String
            Get
                Return _FecE2
            End Get
            Set(value As System.String)
                _FecE2 = value
            End Set
        End Property
        Public Property Variedad() As System.String
            Get
                Return _Variedad
            End Get
            Set(value As System.String)
                _Variedad = value
            End Set
        End Property
        Public Property Textura() As System.String
            Get
                Return _Textura
            End Get
            Set(value As System.String)
                _Textura = value
            End Set
        End Property

        Public Property FDistrito() As System.Int32
            Get
                Return _fDistrito
            End Get
            Set(value As System.Int32)
                _fDistrito = value
            End Set
        End Property
        Public Property FDrenaje() As System.Int32
            Get
                Return _fDrenaje
            End Get
            Set(value As System.Int32)
                _fDrenaje = value
            End Set
        End Property
        Public Property Fzona() As System.Int32
            Get
                Return _fZona
            End Get
            Set(value As System.Int32)
                _fZona = value
            End Set
        End Property
        Public Property FFinca() As System.Int32
            Get
                Return _fFinca
            End Get
            Set(value As System.Int32)
                _fFinca = value
            End Set
        End Property
        Public Property FCiclo() As System.Int32
            Get
                Return _fCiclo
            End Get
            Set(value As System.Int32)
                _fCiclo = value
            End Set
        End Property
        Public Property FDistancia() As System.Int32
            Get
                Return _fDistancia
            End Get
            Set(value As System.Int32)
                _fDistancia = value
            End Set
        End Property
        Public Property FFecE() As System.Int32
            Get
                Return _fFecE
            End Get
            Set(value As System.Int32)
                _fFecE = value
            End Set
        End Property
        Public Property FEdad() As System.Int32
            Get
                Return _fEdad
            End Get
            Set(value As System.Int32)
                _fEdad = value
            End Set
        End Property
        Public Property FRendi() As System.Int32
            Get
                Return _fRendi
            End Get
            Set(value As System.Int32)
                _fRendi = value
            End Set
        End Property
        Public Property FVariedad() As System.Int32
            Get
                Return _fVariedad
            End Get
            Set(value As System.Int32)
                _fVariedad = value
            End Set
        End Property
        Public Property FTextura() As System.Int32
            Get
                Return _fTextura
            End Get
            Set(value As System.Int32)
                _fTextura = value
            End Set
        End Property
        Public Property FrenteID() As System.Int32
            Get
                Return _FrenteID
            End Get
            Set(value As System.Int32)
                _FrenteID = value
            End Set
        End Property
        Public Property FechaProyeccion() As System.String
            Get
                Return _FechaProyeccion
            End Get
            Set(value As System.String)
                _FechaProyeccion = value
            End Set
        End Property
    End Class

    Public Class CPR_Grupos
        ' Las variables privadas
        ' TODO: Revisar los tipos de los campos
        Private _GrupoID As System.Int32
        Private _Descripcion As System.String
        Private _EstimadoID As System.Int32
        Private _EmpresaID As System.Int32
        Private _FechaCreacion As System.DateTime
        Private _FechaModificacion As System.DateTime
        Private _UsuarioCreador As System.String
        Private _UsuarioEditor As System.String
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
        Public Property GrupoID() As System.Int32
            Get
                Return _GrupoID
            End Get
            Set(value As System.Int32)
                _GrupoID = value
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
        Public Property EstimadoID() As System.Int32
            Get
                Return _EstimadoID
            End Get
            Set(value As System.Int32)
                _EstimadoID = value
            End Set
        End Property
        Public Property EmpresaID() As System.Int32
            Get
                Return _EmpresaID
            End Get
            Set(value As System.Int32)
                _EmpresaID = value
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
        Public Property FechaModificacion() As System.DateTime
            Get
                Return _FechaModificacion
            End Get
            Set(value As System.DateTime)
                _FechaModificacion = value
            End Set
        End Property
        Public Property UsuarioCreador() As System.String
            Get
                Return ajustarAncho(_UsuarioCreador, 50)
            End Get
            Set(value As System.String)
                _UsuarioCreador = value
            End Set
        End Property
        Public Property UsuarioEditor() As System.String
            Get
                Return ajustarAncho(_UsuarioEditor, 50)
            End Get
            Set(value As System.String)
                _UsuarioEditor = value
            End Set
        End Property
    End Class


End Class
