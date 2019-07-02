Option Strict On
Option Explicit On
'
Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class ClsAPR
    ' Creado objeto conexion del tipo Conexion para tener acceso al metodo conecta
    Public conexion As New ClsConexion()
    Public cnx As SqlConnection = Nothing
    Public da As SqlDataAdapter = Nothing
    Public cmd As SqlCommand = Nothing
    Public query, mensaje, dtNombre As String
    Public EntidadAPR As ClsEntiAPR.CPR_EstimadoProduccion = Nothing
    Public dsTem As DataSet = Nothing

#Region "Formulario OrdenQuema"
    Public Function ObtenerDatos(strUsuario As String, strPasswd As String, intIdxQuery As Integer, periodoid As Integer) As DataSet
        Dim ds As New DataSet()
        cnx = conexion.conectar(strUsuario, strPasswd)

        If (intIdxQuery = 1) Then 'Query para llenar combos de Periodos
            query = "SELECT periodoid,titulo " +
                                "FROM SynAPRvPeriodo " +
                                "WHERE xactual = 'x' "
        End If

        If (intIdxQuery = 2) Then 'Query para llenar gridControl de Orden de Quema por Frente
            query = "SELECT quemaid AS OrdenQuema,fincaid AS Codigo,nombre AS Nombre,loteid AS Lote," & _
                    "CONVERT(NVARCHAR(MAX),fecha,103) AS Fecha,CONVERT(NVARCHAR(MAX),fecha,108) AS Hora,frente AS Frente,accidental,cruda,cortefrenteid,periodoid,doble," & _
                    "CONVERT(NVARCHAR(MAX),horaOrden,103) + ' ' + CONVERT(NVARCHAR(MAX),horaOrden,108) AS horaOrden," & _
                    "CONVERT(NVARCHAR(MAX),horaBascula,103) + ' ' + CONVERT(NVARCHAR(MAX),HoraBascula,108) AS horaBascula," & _
                    "CONVERT(NVARCHAR(MAX),horaInicioArrastre,103) + ' ' + CONVERT(NVARCHAR(MAX),horaInicioArrastre,108) AS horaInicioArrastre," & _
                    "CONVERT(NVARCHAR(MAX),horaFinalArrastre,103) + ' ' + CONVERT(NVARCHAR(MAX),horaFinalArrastre,108) AS horaFinalArrastre," & _
                    "corteEstimadoTons,corteEjecutadoTons," & _
                    "CONVERT(NVARCHAR(MAX),horaPrebatey,103) + ' ' + CONVERT(NVARCHAR(MAX),horaPrebatey,108) AS horaPrebatey," & _
                    "areaEstimada,areaEjecutada " & _
                    "FROM SynAPRvQuema " & _
                    "WHERE periodoid = " & periodoid & " "
        End If

        da = New SqlDataAdapter(query, cnx)
        'da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(ds, "datos")
        da.Dispose()
        cnx.Dispose()
        Return ds
    End Function
    Public Function ObtenerPeriodo(strUsuario As String, strPasswd As String, intIdxQuery As Integer) As DataSet
        Dim ds As New DataSet()
        cnx = conexion.conectar(strUsuario, strPasswd)

        If (intIdxQuery = 1) Then
            query = "SELECT CAST(periodoid AS NVARCHAR(MAX))+' '+sitio AS sitio,titulo " +
                                 "FROM SynAPRvPeriodo " +
                                 "WHERE xactual = 'x' "
        End If
        If intIdxQuery = 2 Then
            query = "SELECT periodoid AS sitio,titulo " +
                               "FROM SynAPRvPeriodo " +
                               "WHERE xactual = 'x' "
        End If

        da = New SqlDataAdapter(query, cnx)
        'da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(ds, "datos")
        da.Dispose()
        cnx.Dispose()
        Return ds
    End Function
    Public Function ObtenerFrentes(strUsuario As String, strPasswd As String, intIdxQuery As Integer, FrenteID As Integer, EmpresaID As Integer) As DataSet
        Dim ds As New DataSet()
        cnx = conexion.conectar(strUsuario, strPasswd)

        If (intIdxQuery = 1) Then
            query = "SELECT frenteid AS FrenteID,CAST(frenteid as nvarchar(max)) + ' - ' + nombre AS Nombre " & _
                    "FROM SynAPRvFrente " & _
                    "ORDER BY 1 "
        End If
        If intIdxQuery = 2 Then
            query = "SELECT a.* " & _
                    "from CPR_Frentes a " & _
                    "WHERE a.FrenteID = " & FrenteID & " "
        End If
        If intIdxQuery = 3 Then
            query = "SELECT frenteid AS FrenteID,CAST(frenteid as nvarchar(max)) + ' - ' + Descripcion AS Nombre " & _
                    "FROM CPR_Frentes " & _
                    "WHERE EmpresaID = " & EmpresaID & " "
        End If

        da = New SqlDataAdapter(query, cnx)
        'da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(ds, "datos")
        da.Dispose()
        cnx.Dispose()
        Return ds
    End Function
    Public Function ObtenerFinca(strUsuario As String, strPasswd As String, intIdxQuery As Integer, sitio As String) As DataSet
        Dim ds As New DataSet()
        cnx = conexion.conectar(strUsuario, strPasswd)

        If (intIdxQuery = 1) Then
            query = "SELECT c.fincaid,('['+CAST(c.fincaid AS NVARCHAR(MAX))+'] ' + c.nombre) AS nombre " & _
                    "FROM SynAPRDistrito a " & _
                    "LEFT JOIN SynAPREmpresa b " & _
                    "ON a.SitioID = b.Sitio " & _
                    "LEFT JOIN SynAPRvFinca c " & _
                    "ON c.distritoid = a.DistritoID " & _
                    "WHERE a.SitioID = '" & sitio & "' " & _
                    "AND   c.fincaid not in('120') "
        End If
        If intIdxQuery = 2 Then
            Dim distritoID As String = sitio
            query = "SELECT a.FincaID,a.Descripcion " & _
                    "FROM FIN_Fincas a " & _
                    "WHERE DistritoID = '" & distritoID & "' "
        End If
        da = New SqlDataAdapter(query, cnx)
        'da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(ds, "datos")
        da.Dispose()
        cnx.Dispose()
        Return ds
    End Function
    Public Function ObtenerLotes(strUsuario As String, strPasswd As String, intIdxQuery As Integer, strFinca As String) As DataSet
        Dim ds As New DataSet()
        cnx = conexion.conectar(strUsuario, strPasswd)

        If (intIdxQuery = 1) Then
            query = "SELECT LoteID,Area " & _
                    "FROM SynAPRLote " & _
                    "WHERE FincaID = '" & strFinca & "' "
        End If

        da = New SqlDataAdapter(query, cnx)
        'da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(ds, "datos")
        da.Dispose()
        cnx.Dispose()
        Return ds
    End Function
    Public Function ObtenerMaximoQuemaID(strUsuario As String, strPasswd As String) As Integer
        Dim maximo As Integer = 0
        Try
            Dim ds As New DataSet()
            cnx = conexion.conectar(strUsuario, strPasswd)
            query = "SELECT MAX(quemaid) FROM SynAPRQuema"
            da = New SqlDataAdapter(query, cnx)
            da.Fill(ds, "datos")
            da.Dispose()
            cnx.Dispose()
            If (ds.Tables(0).Rows.Count > 0) Then
                maximo = CInt(ds.Tables(0).Rows(0)(0).ToString()) + 1
            End If
        Catch ex As Exception
            maximo = -1
        End Try
        Return maximo
    End Function
    Public Function GuardarModificarOrdenCorte(strUsuario As String, strPasswd As String,
                                                intBandera As Boolean, EntiAPR As ClsEntiAPR.ClsAprGenerarOdtQuema) As String
        Dim ds As New DataSet()
        Dim Mensaje As String = ""
        cnx = conexion.conectar(strUsuario, strPasswd)

        Dim xperiodoid As Int32 = EntiAPR.PeriodoID
        Dim xfincaid As String = EntiAPR.FincaID
        Dim xloteid As String = EntiAPR.LoteID
        Dim xfecha As String = EntiAPR.Fecha
        Dim xaccidental As Int32 = EntiAPR.Accidental
        Dim xquemaid As Int32 = EntiAPR.QuemaID
        Dim xcruda As Int32 = EntiAPR.Cruda
        Dim xarea As Double = EntiAPR.Area
        Dim xcortefrenteid As Int32 = EntiAPR.CorteFrenteID
        Dim xdoble As Int32 = EntiAPR.Doble

        'Indicadores de Rendimiento
        Dim horaOrden As String = EntiAPR.horaOrden
        Dim horaBascula As String = EntiAPR.horaBascula
        Dim horaIArrastre As String = EntiAPR.horaInicioArrastre
        Dim horaFArrastre As String = EntiAPR.horaFinalArrastre
        Dim corteEsTons As Decimal = EntiAPR.corteEstimadoTons
        Dim corteEjTons As Decimal = EntiAPR.corteEjecutadoTons
        Dim horaPrebatey As String = EntiAPR.horaHoraPreBatey
        Dim areaEstimada As Decimal = EntiAPR.areaEstimada
        Dim areaEjecutado As Decimal = EntiAPR.areaEjecutado

        If (intBandera = True) Then
            query = "UPDATE SynAPRQuema " & _
                    "SET CorteFrenteID = " & xcortefrenteid & "," & _
                    "Fecha = '" & xfecha + "'," & _
                    "Accidental = " & xaccidental & "," & _
                    "Cruda = " & xcruda & "," & _
                    "Doble = " & xdoble & "," & _
                    "horaOrden = '" & horaOrden & "'," & _
                    "horaBascula = '" & horaBascula & "'," & _
                    "horaInicioArrastre = '" & horaIArrastre & "'," & _
                    "horaFinalArrastre  = '" & horaFArrastre & "'," & _
                    "corteEstimadoTons  = " & corteEsTons & "," & _
                    "corteEjecutadoTons = " & corteEjTons & "," & _
                    "horaPrebatey = '" & horaPrebatey & "'," & _
                    "areaEstimada = " & areaEstimada & "," & _
                    "areaEjecutada = " & areaEjecutado & " " & _
                    "WHERE PeriodoID = " & xperiodoid & " " & _
                    "AND   FincaID   = '" & xfincaid & "' " & _
                    "AND   QuemaID   = " & xquemaid & ""
            Mensaje = "+Datos modificados satisfactoriamente"
        Else
            query = "INSERT INTO SynAPRQuema (PeriodoID,FincaID,LoteID,Fecha,Activo,Accidental,QuemaID,Cruda,Usuario,Area,CorteFrenteID,Doble," & _
                     "horaOrden,horaBascula,horaInicioArrastre,horaFinalArrastre,corteEstimadoTons,corteEjecutadoTons,horaPrebatey,areaEstimada,areaEjecutada) " & _
                    "VALUES (" & xperiodoid & ",'" & xfincaid & "','" & xloteid & "','" & xfecha & "',1," & xaccidental & "," & xquemaid & "," & _
                    "" & xcruda & ",'" & strUsuario & "',NULL," & xcortefrenteid & "," & xdoble & _
                    ",'" & horaOrden & "','" & horaBascula & "','" & horaIArrastre & "','" & horaFArrastre & "'," & corteEsTons & "," & corteEjTons & ",'" & _
                    horaPrebatey & "'," & areaEstimada & "," & areaEjecutado & ")"
            Mensaje = "+Datos insertados satisfactoriamente"
        End If
        cmd = New SqlCommand(query, cnx)
        cnx.Open()
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Mensaje = "-Error al guardar o modificar informacion del objeto SysAPRQuema. Favor verifique"
        Finally
            cnx.Close()
        End Try

        Return Mensaje
    End Function
#End Region

#Region "Formulario Avance de Cosecha"
    Public Function ObtenerAvanceCosecha(strUsuario As String, strPasswd As String, intIdxQuery As Integer, periodoid As Integer, fecha As String) As DataSet
        Dim ds As New DataSet()
        cnx = conexion.conectarAmigoDbBioSalc(strUsuario, strPasswd)
        Try

            dtNombre = ""
            If (intIdxQuery = 1) Then 'Query para llenar combos de Periodos
                query = "SELECT quemaid AS OrdenCorte,loteid AS Lote,fecha AS FechaQuema,0 AS TiempoTranscurrido,10 AS Viajes,0 AS EnCampo,0 AS EnTransito,0 AS EnPatio,100 AS Molidas,((quemaid/100)-100) AS PorcAvance " &
                                    "FROM SynAPRvQuema " & _
                                    "WHERE periodoid = " & periodoid & ""
            End If

            If (intIdxQuery = 2) Then 'Query para llenar Avance de Cosecha desde servidor de Pruebas - Base de datos BioSalc
                fecha = ArmarFecha(2, fecha)
                query = "SELECT LIB AS OrdenCorte,FRENTE AS Frente,NMB_FINCA AS Finca,LOTE AS Lote,FECHA_QUEMA_CORTA AS FechaQuema," & _
                        "HORASLIB  AS TiempoTranscurrido,VIAJES AS Viajes,Cast(TONENCAMPO As Numeric(10)) AS EnCampo,CAST(TONTRANSITO AS NUMERIC(10)) AS EnTransito," & _
                        "CAST(CAÑAENPATIO AS NUMERIC(10)) AS EnPatio," & _
                        "CAST(CAÑAMOLIDA AS NUMERIC(10)) AS Molidas,AVANCE AS PorcAvance,INACTIVIDAD AS Inactividad,AVANCE AS NumPorcAvance " & _
                        "FROM VW_CANAAVANCECOS " & _
                        "WHERE CONVERT(NVARCHAR(10),FECHA_QUEMA,121) >= '" & fecha & "' ORDER BY CODIGO_FRENTE,LIB DESC"

                dtNombre = "VW_CANAAVANCECOS"
                da = New SqlDataAdapter(query, cnx)
                da.Fill(ds, dtNombre)
            End If

            If (intIdxQuery = 3) Then
                query = "SELECT LIB AS OrdenCorte,TONEST AS TonsEstimadas,AREAMZ AS AreaLiberada, DISTANCIA AS Distancia," & _
                        "AREAPEN AS AreaPendiente,HORA_QUEIMA AS HoraQuema,MINVIAJ AS MinutosViaje " & _
                        "FROM VW_CANAAVANCECOSDETALLE "
                dtNombre = "VW_CANAAVANCECOSDETALLE"
                da = New SqlDataAdapter(query, cnx)
                da.Fill(ds, dtNombre)
            End If

            If (intIdxQuery = 4) Then 'Ejecutar procedimiento almacenado
                fecha = ArmarFecha(2, fecha)
                cnx.Open()
                da = New SqlDataAdapter("spRptAvanceCosecha", cnx)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.Add("@fecha", SqlDbType.Date).Value = fecha
                dtNombre = "VW_CANAAVANCECOS"
                da.Fill(ds, dtNombre)
                cnx.Close()
            End If

            da.Dispose()
            cnx.Dispose()
            Return ds
        Catch ex As Exception
            Return ds
        End Try
    End Function

    Public Function ObtenerMoliendaCaña(strUsuario As String, strPasswd As String, intIdxQuery As Integer, fecha As String) As DataTable
        Dim ds As New DataSet
        Try
            cnx = conexion.conectarAmigoDbBascula(strUsuario, strPasswd)
            cnx.Open()
            da = New SqlDataAdapter("spAvanceCosechaMoliendaxhora", cnx)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@idx", SqlDbType.Int).Value = intIdxQuery
            da.SelectCommand.Parameters.Add("@restarDias", SqlDbType.Int).Value = 0
            da.Fill(ds)
            cnx.Close()
            Return ds.Tables(0)
        Catch ex As Exception
            Return ds.Tables(0)
        End Try
    End Function

#End Region

#Region "Formulario Programacion de Cosecha"
    Public Function ObtenerProgramas(strUsuario As String, strPasswd As String, intIdxQuery As Integer, programaID As Integer, empresaID As Integer) As DataSet
        Dim ds As New DataSet()
        cnx = conexion.conectar(strUsuario, strPasswd)

        If (intIdxQuery = 1) Then 'Query para llenar combo Programas
            'query = "SELECT b.ProgramaID,(a.Descripcion + ' - ' + B.Descripcion) AS Descripcion " & _
            '        "FROM CPR_Grupos a " & _
            '        "INNER JOIN  CPR_Programas b ON a.GrupoID = b.GrupoID " & _
            '        "ORDER BY 1"
            'query = "SELECT dbo.CPR_Programas.ProgramaID,(CPR_Grupos.Descripcion + ' (GrupoID:' + CAST(CPR_Grupos.GrupoID AS NVARCHAR(MAX)) + ') - ' +  dbo.CPR_Programas.Descripcion) AS Descripcion " & _
            '        "FROM dbo.CPR_Estimados INNER JOIN " & _
            '        "     dbo.FIN_Sitios INNER JOIN " & _
            '        "     dbo.FIN_Empresas ON dbo.FIN_Sitios.EmpresaID = dbo.FIN_Empresas.EmpresaID INNER JOIN " & _
            '        "     dbo.SynGenZafras ON dbo.FIN_Sitios.SitioID = dbo.SynGenZafras.Sitio AND dbo.FIN_Sitios.EmpresaID = CAST(dbo.SynGenZafras.Empresa AS Int) ON " & _
            '        "     dbo.CPR_Estimados.ZafraID = dbo.SynGenZafras.IDZafra INNER JOIN " & _
            '        "     dbo.CPR_Grupos ON dbo.CPR_Estimados.EstimadoID = dbo.CPR_Grupos.EstimadoID INNER JOIN " & _
            '        "     dbo.CPR_Programas ON dbo.CPR_Grupos.GrupoID = dbo.CPR_Programas.GrupoID " & _
            '        "WHERE(dbo.FIN_Empresas.EmpresaID = " & empresaID & ") "

            query = "SELECT [ProgramaID],[Descripcion] " & _
                    "FROM [Produccion].[dbo].[vwCPRObtenerProgramasxEmpresa] " & _
                    "WHERE EmpresaID = " & empresaID & " "
        End If
        If (intIdxQuery = 2) Then
            'query = "SELECT p.TipoProgramaID,tp.Descripcion,p.EstadoProgramaID,ep.Descripcion," & _
            '        "p.TipoPeriodoID, tpe.Descripcion, p.ZafraID, z.Descripcion, " & _
            '        "CONVERT(NVARCHAR(MAX),p.FechaCreacion,103) + ' ' + CONVERT(NVARCHAR(MAX),p.FechaCreacion,108) AS FechaCreacion,p.UsuarioCreador,p.Desde,p.Hasta,p.DistanciaMeta " & _
            '        "FROM CPR_Programas p " & _
            '        "LEFT JOIN CPR_TipoProgramas tp ON tp.TipoProgramaID = p.TipoPeriodoID " & _
            '        "LEFT JOIN CPR_EstadoProgramas ep ON ep.EstadoProgramaID = p.EstadoProgramaID " & _
            '        "LEFT JOIN CPR_TipoPeriodos tpe ON tpe.TipoPeriodoID = p.TipoPeriodoID " & _
            '        "LEFT JOIN SynGENZafras z ON z.YZafraID = p.ZafraID " & _
            '        "WHERE p.ProgramaID = " & programaID & " "
            query = "SELECT [TipoProgramaID],[Descripcion],[EstadoProgramaID],[Expr1] AS Descripcion,[TipoPeriodoID] " & _
                    ",[Expr2] AS Periodo,[ZafraID],[FechaCreacion],[UsuarioCreador],[Desde],[Hasta],[DistanciaMeta] " & _
                    ",[ProgramaID] " & _
                    "FROM [Produccion].[dbo].[vwCPRInfoProgramasxEmpresa] " & _
                    "WHERE ProgramaID = " & programaID & " "
        End If
        da = New SqlDataAdapter(query, cnx)
        da.Fill(ds, "datos")
        da.Dispose()
        cnx.Dispose()
        Return ds
    End Function
    Public Function ObtenerDetalleProgramas(strUsuario As String, strPasswd As String, intIdxQuery As Integer, programaID As Integer) As DataSet
        Dim ds As New DataSet()
        cnx = conexion.conectar(strUsuario, strPasswd)

        If (intIdxQuery = 1) Then 'Query Detalle de Programas
            query = "SELECT CAST(Seleccionar AS bit) AS Seleccionar, CAST(estaAprobado AS Bit) AS estaAprobado, Descripcion, " & _
                    "CONVERT(NVARCHAR(MAX),FechaEstimada,103) AS FechaEstimada, ToneladasEstimadas," & _
                    "DistritoID, FincaID, LoteID, DistanciaIngenio, VariedadID, VariedadDescrip," & _
                    "CicloID, CicloDescrip, TexturaID, TexturaDescrip, DrenajeID, DrenajeDescrip," & _
                    "Rendimiento, DistanciaID, DistanciaSiembraDescrip, Frente, PromedioPonderado," & _
                    "DetalleProgramaID, programaID,EstimadoProduccionID,EstimadoGrupoID " & _
                    "FROM dbo.vwCPR_DetalleProgramas " & _
                    "WHERE programaID = " & programaID & " " & _
                    "ORDER BY 1 DESC "
        End If
       
        da = New SqlDataAdapter(query, cnx)
        da.Fill(ds, "datos")
        da.Dispose()
        cnx.Dispose()
        Return ds
    End Function
    Public Function ObtenerCategoriasResultados(strUsuario As String, strPasswd As String, intIdxQuery As Integer) As DataSet
        Dim ds As New DataSet()
        cnx = conexion.conectar(strUsuario, strPasswd)

        If (intIdxQuery = 1) Then 'Query para llenar combo Programas
            query = "SELECT a.ResultadoID,a.Descripcion " & _
                    "FROM CPR_Resultados a "
        End If
        da = New SqlDataAdapter(query, cnx)
        da.Fill(ds, "datos")
        da.Dispose()
        cnx.Dispose()
        Return ds
    End Function
    Public Function ActualizarDetPrg_y_EstimadosProd(strUsuario As String, strPasswd As String,
                                              intBandera As Integer, strFecha As String, ResultadoID As Integer,
                                              renProLab As Decimal, area As Decimal, tonsReales As Decimal,
                                              estimadoGrupoID As Integer, loteid As String, DetPrgID As Integer) As String
        dsTem = New DataSet()
        Dim tryIdx As Integer = 0
        Dim estimadoProduccionID As Integer = 0
        Try
            'Obtener el EstimadoProduccionID-----------------------------------------
            cnx = conexion.conectar(strUsuario, strPasswd)
            If (intBandera = 1) Then
                query = "SELECT x.EstimadoProduccionID " & _
                        "FROM   CPR_EstimadoGrupo x " & _
                        "WHERE  x.EstimadoGrupoID = " & estimadoGrupoID & " "
            End If

            da = New SqlDataAdapter(query, cnx)
            da.Fill(dsTem, "datos")
            da.Dispose()
            cnx.Dispose()

            estimadoProduccionID = CInt(dsTem.Tables(0).Rows(0)(0))
            tryIdx = 1
        Catch ex As Exception
            tryIdx = -1
            mensaje = ex.Message & " El sistema ha detectado la siguiente excepcion: " & query
        End Try

        '-------------------------------------------------------------------------
        If tryIdx = 1 Then
            Try
                'Actualizar-----------------------------------------------
                cnx = conexion.conectar(strUsuario, strPasswd)
                If (intBandera = 1) Then
                    query = "UPDATE CPR_DetalleProgramas " & _
                            "SET UsuarioEditor = '" & strUsuario & "'," & _
                            "FechaModificacion = GETDATE()," & _
                            "ToneladasReales = " & tonsReales & "," & _
                            "FechaCortada = '" & strFecha & "'," & _
                            "AreaEjecutada = " & area & "," & _
                            "ResultadoID = " & ResultadoID & " " & _
                            "WHERE DetalleProgramaID = " & DetPrgID & "; "

                    query = query &
                            "UPDATE CPR_EstimadoProduccion " & _
                            "SET UsuarioEditor = '" & strUsuario & "'," & _
                             "FechaModificacion = GETDATE()," & _
                             "AreaEjecutada = " & area & "," & _
                             "RendimientoLab = " & renProLab & " " & _
                             "WHERE LoteID = '" & loteid & "' " & _
                             "AND   EstimadoProduccionID = " & estimadoProduccionID & "; "

                    mensaje = "+Datos actualizados satisfactoriamente"
                End If
                cmd = New SqlCommand(query, cnx)
                cnx.Open()
                cmd.ExecuteNonQuery()
                '---------------------------------------------------------
            Catch ex As Exception
                mensaje = "-Error al guardar o modificar informacion del siguiente query: " & ex.Message & " - " & query & ". Favor verifique"
            Finally
                cnx.Close()
            End Try
        Else

        End If

        Return mensaje
    End Function
#End Region

#Region "Formulario Consulta de Lotes (Cosecha)"
    Public Function ObtenerDistritos(strUsuario As String, strPasswd As String, intIdxQuery As Integer, empresaid As Integer) As DataSet
        Dim ds As New DataSet()
        cnx = conexion.conectar(strUsuario, strPasswd)

        If (intIdxQuery = 1) Then 'Query Detalle de Programas
            query = "SELECT di.DistritoID,di.Descripcion " & _
                    "FROM FIN_Distritos di " & _
                    "LEFT JOIN FIN_Sitios si ON si.SitioID = di.SitioID " & _
                    "LEFT JOIN FIN_Empresas em ON em.EmpresaID = si.EmpresaID " & _
                    "WHERE em.EmpresaID = " & empresaid & " "
        End If

        da = New SqlDataAdapter(query, cnx)
        da.Fill(ds, "datos")
        da.Dispose()
        cnx.Dispose()
        Return ds
    End Function

    Public Function ObtenerZonas(strUsuario As String, strPasswd As String, intIdxQuery As Integer, empresaid As Integer) As DataSet
        Dim ds As New DataSet()
        cnx = conexion.conectar(strUsuario, strPasswd)

        If (intIdxQuery = 1) Then
            query = "SELECT a.ZonaID,a.Descripcion " & _
                    "FROM CPR_Zonas a " & _
                    "WHERE a.empresaid = " & empresaid & " "
        End If

        da = New SqlDataAdapter(query, cnx)
        da.Fill(ds, "datos")
        da.Dispose()
        cnx.Dispose()
        Return ds
    End Function

    Public Function ObtenerVariedadesCaña(strUsuario As String, strPasswd As String, intIdxQuery As Integer) As DataSet
        Dim ds As New DataSet()
        cnx = conexion.conectar(strUsuario, strPasswd)

        If (intIdxQuery = 1) Then
            query = "SELECT a.TipoCanaID,a.Variedad " & _
                    "FROM FIN_TipoCanas a " & _
                    "ORDER BY 1 "
        End If

        da = New SqlDataAdapter(query, cnx)
        da.Fill(ds, "datos")
        da.Dispose()
        cnx.Dispose()
        Return ds
    End Function

    Public Function ObtenerCiclos(strUsuario As String, strPasswd As String, intIdxQuery As Integer) As DataSet
        Dim ds As New DataSet()
        cnx = conexion.conectar(strUsuario, strPasswd)

        If (intIdxQuery = 1) Then
            query = "SELECT a.CicloID, a.Descripcion " & _
                    "FROM CPR_Ciclos a " & _
                    "ORDER BY 1 "
        End If

        da = New SqlDataAdapter(query, cnx)
        da.Fill(ds, "datos")
        da.Dispose()
        cnx.Dispose()
        Return ds
    End Function

    Public Function ObtenerTexturas(strUsuario As String, strPasswd As String, intIdxQuery As Integer) As DataSet
        Dim ds As New DataSet()
        cnx = conexion.conectar(strUsuario, strPasswd)

        If (intIdxQuery = 1) Then
            query = "SELECT a.TipoSueloID,a.Descripcion " & _
                    "FROM FIN_TipoSuelos a " & _
                    "ORDER BY 1 "
        End If

        da = New SqlDataAdapter(query, cnx)
        da.Fill(ds, "datos")
        da.Dispose()
        cnx.Dispose()
        Return ds
    End Function

    Public Function ObtenerDrenajes(strUsuario As String, strPasswd As String, intIdxQuery As Integer) As DataSet
        Dim ds As New DataSet()
        cnx = conexion.conectar(strUsuario, strPasswd)

        If (intIdxQuery = 1) Then
            query = "SELECT a.DrenajeID,a.Descripcion " & _
                    "FROM CPR_Drenajes a " & _
                    "ORDER BY 1 "
        End If

        da = New SqlDataAdapter(query, cnx)
        da.Fill(ds, "datos")
        da.Dispose()
        cnx.Dispose()
        Return ds
    End Function

    Public Function ObtenerEstimadoProduccion(strUsuario As String, strPasswd As String, intIdxQuery As Integer, entidad As ClsEntiAPR.CPR_EstimadoProduccion, StrEmpresaID As String, intPID As Integer) As DataSet
        Dim ds As New DataSet()
        Try
        cnx = conexion.conectar(strUsuario, strPasswd)

        If entidad.FDistrito = 0 Then
            entidad.DistritoID = "-1"
        End If
        If entidad.FDrenaje = 0 Then
            entidad.DrenajeID = -1
        End If
        If entidad.Fzona = 0 Then
            entidad.ZonaID = -1
        End If
        If entidad.FFinca = 0 Then
            entidad.FincaID = "-1"
        End If
        If entidad.FCiclo = 0 Then
            entidad.Ciclo1 = "-1"
            entidad.Ciclo2 = "-1"
        End If
        If entidad.FDistancia = 0 Then
            entidad.Distancia1 = -1
            entidad.Distancia2 = -1
        End If
        If entidad.FFecE = 0 Then
            entidad.FecE1 = "-1"
            entidad.FecE2 = "-1"
        End If
        If entidad.FEdad = 0 Then
            entidad.Edad1 = -1
            entidad.Edad2 = -1
        End If
        If entidad.FRendi = 0 Then
            entidad.Rendi1 = -1
            entidad.Rendi2 = -1
        End If
        If entidad.FVariedad = 0 Then
            entidad.Variedad = "-1"
        End If
        If entidad.FTextura = 0 Then
            entidad.Textura = "-1"
        End If

        If (intIdxQuery = 1) Then
                query = "SELECT a.EstimadoProduccionID,CAST(a.Seleccion AS Bit) AS Seleccion,a.DistritoID,a.FincaID,a.Finca,a.LoteID,a.AreaEstimada," & _
                        "a.AreaEjecutada,a.AreaReal,a.Rendimiento,a.ToneladasEstimadas,a.DistanciaIngenio,a.VariedadID," & _
                        "a.VariedadDescrip,a.CicloID,a.CicloDescrip,a.TexturaID,a.TexturaDescrip,a.DrenajeID,a.DrenajeDescrip," & _
                        "a.DistanciaID,a.DistanciaSiembraDescrip,CONVERT(NVARCHAR(MAX),a.FechaEstimada,103) AS FechaEstimada," & _
                        "a.PeriodoZafra,CAST(DATEDIFF(day, a.FechaCorte, '" & entidad.FechaCorte & "') * .0333 AS Decimal(18, 2)) AS EdadCana,a.ZonaID,a.Zona,a.EmpresaID,a.estaProgramado,a.estaMuestreado," & _
                        "a.EstaTerminado,a.DetalleProgramaID,a.ProgramaID,a.GrupoID,a.EstimadoGrupoID,a.LoteTerminado " & _
                        "FROM vwCPR_EstimadoProduccion a " & _
                        "WHERE 1=1 " & _
                         "AND a.EstimadoGrupoID NOT IN (SELECT x.EstimadoGrupoID " & _
                                                      "FROM CPR_DetalleProgramas x " & _
                                                      "WHERE x.ProgramaID = a.ProgramaID AND ISNULL(x.ResultadoID,-1) NOT IN (2) ) " & _
                        "AND CAST(a.EmpresaID AS Int) = " & CInt(StrEmpresaID)
                '" AND a.GrupoID IS NULL " & _
                '" "
                '"AND a.ResultadoID NOT IN (2) "
            '"AND   x.ProgramaID = " & intPID & ") " & _
        End If
        If (intIdxQuery = 2) Then
                query = "SELECT a.EstimadoProduccionID,CAST(a.Seleccion AS Bit) AS Seleccion,a.DistritoID,a.FincaID,a.Finca,a.LoteID,a.AreaEstimada," & _
                        "a.AreaEjecutada,a.AreaReal,a.Rendimiento,a.ToneladasEstimadas,a.DistanciaIngenio,a.VariedadID," & _
                        "a.VariedadDescrip,a.CicloID,a.CicloDescrip,a.TexturaID,a.TexturaDescrip,a.DrenajeID,a.DrenajeDescrip," & _
                        "a.DistanciaID,a.DistanciaSiembraDescrip,CONVERT(NVARCHAR(MAX),a.FechaEstimada,103) AS FechaEstimada," & _
                        "a.PeriodoZafra,CAST(DATEDIFF(day, a.FechaCorte, '" & entidad.FechaCorte & "') * .0333 AS Decimal(18, 2)) AS EdadCana,a.ZonaID,a.Zona,a.EmpresaID,a.estaProgramado,a.estaMuestreado," & _
                        "a.EstaTerminado,a.DetalleProgramaID,a.ProgramaID,a.GrupoID,a.EstimadoGrupoID,a.LoteTerminado " & _
                        "FROM vwCPR_EstimadoProduccion a " & _
                        "WHERE 1=1 " & _
                        "AND a.EstimadoGrupoID NOT IN (SELECT x.EstimadoGrupoID " & _
                                                      "FROM CPR_DetalleProgramas x " & _
                                                      "WHERE x.ProgramaID = a.ProgramaID AND ISNULL(x.ResultadoID,-1) NOT IN(2) ) " & _
                        "AND CAST(a.EmpresaID AS Int) = " & CInt(StrEmpresaID) & " " & _
                        "AND a.DistritoID = '" & entidad.DistritoID & "' " & _
                        "AND a.ZonaID = " & entidad.ZonaID & " " & _
                        "AND a.FincaID = '" & entidad.FincaID & "' " & _
                        "AND CAST(DATEDIFF(day, a.FechaCorte, '" & entidad.FechaCorte & "') * .0333 AS Decimal(18, 2)) >= " & entidad.Edad1 & " AND CAST(DATEDIFF(day, a.FechaCorte, '" & entidad.FechaCorte & "') * .0333 AS Decimal(18, 2)) <= " & entidad.Edad2 & " " & _
                        "AND a.Rendimiento >= " & entidad.Rendi1 & " AND a.Rendimiento <= " & entidad.Rendi2 & " " & _
                        "AND a.VariedadID IN (" & entidad.Variedad & ") " & _
                        "AND a.CicloID >= " & CInt(entidad.Ciclo1) & " AND a.CicloID <= " & CInt(entidad.Ciclo2) & " " & _
                        "AND a.TexturaID IN (" & entidad.Textura & ") " & _
                        "AND a.DrenajeID = " & entidad.DrenajeID & " " & _
                        "AND a.DistanciaIngenio >= " & entidad.Distancia1 & " AND a.DistanciaIngenio <= " & entidad.Distancia2 & " " & _
                        "AND CONVERT(NVARCHAR(MAX),a.FechaEstimada,103) >= '" & entidad.FecE1 & "' " & _
                        "AND CONVERT(NVARCHAR(MAX),a.FechaEstimada,103) <= '" & entidad.FecE2 & "' "
            '"AND   x.ProgramaID = " & intPID & ") " & _
            'Reemplazar query
            If entidad.FDistrito = 0 Then
                query = query.Replace("AND a.DistritoID = '-1'", "")
            End If
            If entidad.FDrenaje = 0 Then
                query = query.Replace("AND a.DrenajeID = -1", "")
            End If
            If entidad.Fzona = 0 Then
                query = query.Replace("AND a.ZonaID = -1", "")
            End If
            If entidad.FFinca = 0 Then
                query = query.Replace("AND a.FincaID = '-1'", "")
            End If
            If entidad.FCiclo = 0 Then
                query = query.Replace("AND a.CicloID >= -1 AND a.CicloID <= -1", "")
            End If
            If entidad.FDistancia = 0 Then
                query = query.Replace("AND a.DistanciaIngenio >= -1 AND a.DistanciaIngenio <= -1", "")
            End If
            If entidad.FFecE = 0 Then
                query = query.Replace("AND CONVERT(NVARCHAR(MAX),a.FechaEstimada,103) >= '-1' AND CONVERT(NVARCHAR(MAX),a.FechaEstimada,103) <= '-1'", "")
            End If
            If entidad.FEdad = 0 Then
                    query = query.Replace("AND CAST(DATEDIFF(day, a.FechaCorte, '" & entidad.FechaCorte & "') * .0333 AS Decimal(18, 2)) >= -1 AND CAST(DATEDIFF(day, a.FechaCorte, '" & entidad.FechaCorte & "') * .0333 AS Decimal(18, 2)) <= -1", "")
            End If
            If entidad.FRendi = 0 Then
                query = query.Replace("AND a.Rendimiento >= -1 AND a.Rendimiento <= -1", "")
            End If
            If entidad.FVariedad = 0 Then
                query = query.Replace("AND a.VariedadID IN (-1)", "")
            End If
            If entidad.FTextura = 0 Then
                query = query.Replace("AND a.TexturaID IN (-1)", "")
            End If
        End If

        da = New SqlDataAdapter(query, cnx)
        da.Fill(ds, "datos")
        da.Dispose()
            cnx.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message & " " & query, MsgBoxStyle.Critical, "Error:")
        End Try
        Return ds
    End Function

    Public Function ObtenerTotalesxEmpresa(strUsuario As String, strPasswd As String, intIdxQuery As Integer, empresaid As Integer, intPID As Integer) As DataTable
        Dim ds As New DataSet()
        Try
            cnx = conexion.conectar(strUsuario, strPasswd)

            If (intIdxQuery = 1) Then
                query = "SELECT ISNULL(SUM(a.ToneladasEstimadas),0) AS TotalTonsPend,COUNT(a.loteid) TotalRegPendientes, " & _
                         "(SELECT COUNT(z.DetalleProgramaID) " & _
                        "FROM CPR_DetalleProgramas z " & _
                        "WHERE z.ProgramaID = " & intPID & ") AS TotalRegProcesados, " & _
                         "(SELECT ISNULL(SUM(z.ToneladasEstimadas),0) " & _
                        "FROM CPR_DetalleProgramas z " & _
                        "WHERE z.ProgramaID = " & intPID & ") AS TotalTonsProcesados " & _
                        "FROM vwCPR_EstimadoProduccion a " & _
                        "WHERE 1=1 " & _
                        "AND a.EstimadoGrupoID NOT IN (SELECT x.EstimadoGrupoID " & _
                                                      "FROM CPR_DetalleProgramas x " & _
                                                      "WHERE x.ProgramaID = a.ProgramaID) " & _
                        "AND CAST(a.EmpresaID AS Int) = " & empresaid & " "
            End If
            '"AND   x.ProgramaID = " & intPID & ") " & _
            da = New SqlDataAdapter(query, cnx)
            da.Fill(ds, "datos")
            da.Dispose()
            cnx.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message & query, MsgBoxStyle.Critical, "Error:")
        End Try
        Return ds.Tables(0)
    End Function

    Public Function ActualizarPredeterminados(strUsuario As String, strPasswd As String,
                                               intBandera As Integer, strFecha As String) As String
        'Dim ds As New DataSet()
        cnx = conexion.conectar(strUsuario, strPasswd)
        If (intBandera = 1) Then
            query = "UPDATE CPR_Predeterminados " &
                    "SET FechaCalculo = '" & strFecha & "' " &
                    "WHERE PredeterminadoID = 4 "
            mensaje = "+Datos insertados satisfactoriamente"
        End If
        cmd = New SqlCommand(query, cnx)
        cnx.Open()
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            mensaje = ex.Message & "-Error al guardar o modificar informacion del objeto CPR_Predeterminado. Favor verifique"
            MsgBox(mensaje, MsgBoxStyle.Critical, "Error:")
        Finally
            cnx.Close()
        End Try

        Return mensaje
    End Function

    Public Function InsertarDetProgramas(strUsuario As String, strPassword As String, intBandera As Integer, dt As DataTable) As String
        Dim ds As New DataSet()
        Try
            cnx = conexion.conectar(strUsuario, strPassword)
            query = "spCPR_DetProgramas"
            da = New SqlDataAdapter(query, cnx)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@bandera", SqlDbType.Int).Value = intBandera
            da.SelectCommand.Parameters.AddWithValue("@udtdetprograma", dt)
            da.Fill(ds, "datos")
            da.Dispose()
            cnx.Dispose()

            query = ds.Tables(0).Rows(0)(0).ToString()
        Catch ex As Exception
            query = "-Error: Al insertar lotes en el detalle del Programa. (" & ex.Message & "). Favor comunicarse con el departamento de IT"
        End Try

        Return query
    End Function

    Public Function ActualizarAprobacionDetProgramas(strUsuario As String, strPasswd As String,
                                              intBandera As Integer, intProgramaID As Integer, strDPID As String, marca As Integer) As String
        'Dim ds As New DataSet()
        cnx = conexion.conectar(strUsuario, strPasswd)
        If (intBandera = 1) Then
            query = "UPDATE CPR_DetalleProgramas " & _
                    "SET estaAprobado = " & marca & " " & _
                    "WHERE ProgramaID = " & intProgramaID & " " & _
                    "AND DetalleProgramaID IN (" & strDPID & ") "
            mensaje = "+Datos acttualizados satisfactoriamente"
        End If
        cmd = New SqlCommand(query, cnx)
        cnx.Open()
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            mensaje = ex.Message & "-Error al guardar o modificar informacion del objeto CPR_DetalleProgramas. Favor verifique. Query: [" & query & "] "
            MsgBox(mensaje, MsgBoxStyle.Critical, "Error:")
        Finally
            cnx.Close()
        End Try

        Return mensaje
    End Function

    Public Function EliminarLoteDetallexPrograma(strUsuario As String, strPasswd As String,
                                              intBandera As Integer, intProgramaID As Integer, strDPID As String) As String
        'Dim ds As New DataSet()
        cnx = conexion.conectar(strUsuario, strPasswd)
        If (intBandera = 1) Then
            query = "DELETE FROM CPR_DetalleProgramas " & _
                    "WHERE ProgramaID = " & intProgramaID & " " & _
                    "AND   DetalleProgramaID IN (" & strDPID & ") " & _
                    "AND   estaAprobado = 0 "
            mensaje = "+Lotes eliminados satisfactoriamente"
        End If
        cmd = New SqlCommand(query, cnx)
        cnx.Open()
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            mensaje = ex.Message & "-Error al eliminar informacion del objeto CPR_DetalleProgramas. Favor verifique. Query: [" & query & "] "
            'MsgBox(mensaje, MsgBoxStyle.Critical, "Error:")
        Finally
            cnx.Close()
        End Try

        Return mensaje
    End Function

#End Region

#Region "Formulario Mantenimiento de Planes de Cosecha (Grupos)"
    Public Function EventosPlanesCosecha(strUsuario As String, strPasswd As String, intIdxQuery As Integer, eGrupo As ClsEntiAPR.CPR_Grupos) As DataSet
        Dim ds As New DataSet()
        cnx = conexion.conectar(strUsuario, strPasswd)

        If (intIdxQuery = 1) Then 'Obtener
            query = "SELECT dbo.CPR_Grupos.GrupoID, dbo.CPR_Grupos.Descripcion, dbo.CPR_Grupos.EstimadoID, dbo.CPR_Estimados.Descripcion AS Estimado " & _
                    "FROM   dbo.CPR_Estimados INNER JOIN " & _
                    "dbo.SynGenZafras ON dbo.CPR_Estimados.ZafraID = dbo.SynGenZafras.IDZafra INNER JOIN " & _
                    "dbo.CPR_Grupos ON dbo.CPR_Estimados.EstimadoID = dbo.CPR_Grupos.EstimadoID INNER JOIN " & _
                    "dbo.FIN_Empresas INNER JOIN " & _
                    "dbo.FIN_Sitios ON dbo.FIN_Empresas.EmpresaID = dbo.FIN_Sitios.EmpresaID ON dbo.SynGenZafras.Sitio = dbo.FIN_Sitios.SitioID " & _
                    "ORDER BY dbo.CPR_Grupos.GrupoID "
        End If

        Dim descripcion As String = eGrupo.Descripcion
        Dim EstimadoID As Integer = eGrupo.EstimadoID
        If intIdxQuery = 2 Then 'Nuevo
            query = "INSERT INTO CPR_Grupos(GrupoID,Descripcion,EstimadoID,) " &
                    "VALUES()"
        End If

        da = New SqlDataAdapter(query, cnx)
        da.Fill(ds, "datos")
        da.Dispose()
        cnx.Dispose()
        Return ds
    End Function

    Public Function O(strUsuario As String, strPasswd As String, intIdxQuery As Integer) As DataSet
        Dim ds As New DataSet()
        cnx = conexion.conectar(strUsuario, strPasswd)

        If (intIdxQuery = 1) Then 'Obtener
            query = "SELECT dbo.CPR_Grupos.GrupoID, dbo.CPR_Grupos.Descripcion, dbo.CPR_Grupos.EstimadoID, dbo.CPR_Estimados.Descripcion AS Estimado " & _
                    "FROM   dbo.CPR_Estimados INNER JOIN " & _
                    "dbo.SynGenZafras ON dbo.CPR_Estimados.ZafraID = dbo.SynGenZafras.IDZafra INNER JOIN " & _
                    "dbo.CPR_Grupos ON dbo.CPR_Estimados.EstimadoID = dbo.CPR_Grupos.EstimadoID INNER JOIN " & _
                    "dbo.FIN_Empresas INNER JOIN " & _
                    "dbo.FIN_Sitios ON dbo.FIN_Empresas.EmpresaID = dbo.FIN_Sitios.EmpresaID ON dbo.SynGenZafras.Sitio = dbo.FIN_Sitios.SitioID " & _
                    "ORDER BY dbo.CPR_Grupos.GrupoID "
        End If
        If intIdxQuery = 2 Then 'Nuevo

        End If

        da = New SqlDataAdapter(query, cnx)
        da.Fill(ds, "datos")
        da.Dispose()
        cnx.Dispose()
        Return ds
    End Function
#End Region

#Region "Formulario Agregados BoletaCana"
    Public Function ObtenerInfoBoleta(strUsuario As String, strPasswd As String, intIdxQuery As Integer, strBoletaID As String) As DataTable
        Dim ds As New DataSet()
        cnx = conexion.conectar(strUsuario, strPasswd)
        query = ""
        If intIdxQuery = 1 Then
            query = "Select QuemaID, Bulteo From BoletaCana Where BoletaID = '" & strBoletaID & "'"
        End If

        da = New SqlDataAdapter(query, cnx)
        da.Fill(ds, "datos")
        da.Dispose()
        cnx.Dispose()
        Return ds.Tables(0)
    End Function

    Public Function ActualizarBoletaCana(strUsuario As String, strPasswd As String,
                                             intBandera As Integer, strBoletaID As String, strQuemaID As String, strPochota As String) As String
        dsTem = New DataSet()

        If intBandera = 1 Then
            Try
                'Actualizar-----------------------------------------------
                cnx = conexion.conectar(strUsuario, strPasswd)
                If (intBandera = 1) Then
                    query = "UPDATE BoletaCana SET QuemaID = '" & strQuemaID & "', Bulteo = '" & strPochota & "' From BoletaCana Where BoletaID = '" & strBoletaID & "'"
                    mensaje = "+Datos actualizados satisfactoriamente"
                End If
                cmd = New SqlCommand(query, cnx)
                cnx.Open()
                cmd.ExecuteNonQuery()
                '---------------------------------------------------------
            Catch ex As Exception
                mensaje = "-Error al guardar o modificar informacion del siguiente query: " & ex.Message & " - " & query & ". Favor verifique"
            Finally
                cnx.Close()
            End Try
        End If

        Return mensaje
    End Function
#End Region

#Region "Utilitario"
    Public Function ArmarFecha(idx As Integer, fechaFormatoEspañol As String) As String
        If idx = 1 Then
            query = fechaFormatoEspañol
            Dim ArregloFechaIngles() As String = Split(query, " ")
            Dim fechaIngles1 As Date = CDate(ArregloFechaIngles(0))

            Dim fecha As DateTime = Convert.ToDateTime(query.Replace("p.m.", "PM").Replace("a.m.", "AM"))
            query = Format(fecha, "dd/MM/yyyy HH:mm:ss")
            query = query.Replace("/", " ")
            Dim TestArray() As String = Split(query, " ")
            query = TestArray(2) + "-" + TestArray(1) + "-" + TestArray(0)
            query = query & " " & TestArray(3)
        End If
        If idx = 2 Then
            query = fechaFormatoEspañol
            query = query.Replace("/", " ")
            Dim TestArray() As String = Split(query, " ")
            query = TestArray(2) + "-" + TestArray(1) + "-" + TestArray(0)
        End If
        If idx = 3 Then
            query = fechaFormatoEspañol
            Dim TestArray() As String = Split(query, " ") 'Separar fecha y hora en arreglo
            query = TestArray(0).Replace("/", " ")
            Dim FormatoFecha() As String = Split(query, " ")
            query = FormatoFecha(2) + "-" + FormatoFecha(1) + "-" + FormatoFecha(0)
            query = query + " " + TestArray(1)
        End If

        Return query
    End Function

#End Region

End Class

#Region "CODIGO_FUENTE_UTIL_REUTILIZACION"
'    'Armar la fecha en Formato Año-mes-dia hh:mm:ss.000'
'    strFecha = txtFecha.Text
'    strHora = txtHora.Text
'    strFecha = strFecha.Replace("/", "-")
'    Dim TestArray() As String = Split(strFecha, "-")
'    strFecha = TestArray(2) + "-" + TestArray(1) + "-" + TestArray(0)
'    'strFecha = strFecha + " " + strHora
'    'strFecha = strFecha + " " + strHora.Replace("AM", "").Replace("PM", "")
'    strHora = strHora.Replace(" ", "")
'    Dim date1 As Date = Convert.ToDateTime(strHora)
'ElseIf idx = 2 Then
'    strFecha = fechaFormatoEspañol
'    Dim TestArray() As String = Split(strFecha, "/")

#End Region