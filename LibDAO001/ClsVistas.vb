Option Strict On
Option Explicit On
'
Imports System
Imports System.Data
Imports System.Data.SqlClient
'Imports System.Windows.Forms

Public Class ClsVistas

    ' Creado objeto conexion del tipo Conexion para tener acceso al metodo conecta
    Public conexion As New ClsConexion()
    Public cnx As SqlConnection = Nothing
    Public da As SqlDataAdapter = Nothing
    Public cmd As SqlCommand = Nothing
    Public qry As String
    Public dllUtil As ClsUtilitarios.ControlAccesoIni = Nothing

#Region "Funciones Proceso de Carga de Perfiles de Usuario y Reportes"
    ' Funcion para cargar los reportes disponibles por Perfil/Usuario
    Public Function BuscarRepxUsuario(bandera As Int16, perfil As String, strUs As String, strPw As String) As DataSet
        Dim ds As New DataSet()
        cnx = conexion.conectar(strUs, strPw)

        Dim qry As String = "SELECT R.nombre as Nombre, R.descripcion as Descripcion, R.reporte as Reporte, " +
                            "R.jdatabase AS basedatos,R.juser AS usuario,R.pass AS passwd,R.server AS servidor, " +
                            "'Admin' AS perfil, G.nombre AS nombre1, A.nombre AS nombre2, R.solicitar AS solicitar,R.idReporte AS idreporte " +
                            "FROM J_Reportes R " +
                            "INNER JOIN J_ReporteArea RA on R.idReporte = RA.idReporte " +
                            "INNER JOIN J_Area A on A.idArea = RA.idArea " +
                            "INNER JOIN J_Grupo G on A.idArea = G.idArea " +
                            "INNER join J_Usuarios U on G.idGrupo = u.idgrupo " +
                            "WHERE a.nombre = '" + perfil + "' " +
                            "GROUP BY R.nombre, R.descripcion,R.reporte ,r.jDataBase ,r.jUser ,r.pass ,r.server, " +
                                      "g.nombre ,a.nombre ,r.solicitar,R.idReporte"

        'If (bandera = 2) Then 'Query para seleccionar reportes x usuarios
        '    qry = qry.Replace("'Admin' AS perfil,", "U.Usuarios AS perfil,")
        'End If

        da = New SqlDataAdapter(qry, cnx)
        'da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(ds, "tabla")
        da.Dispose()
        cnx.Dispose()
        Return ds
    End Function

    ' Funcion para cargar sitios por usuario
    Public Function CargarSitiosxUsuario(idusuario As Int32, strUs As String, strPw As String) As DataSet
        Dim ds As New DataSet()
        cnx = conexion.conectar(strUs, strPw)
        Dim qry As String = "SELECT CASE WHEN LEN(sitios) = 0 THEN '-TODOS-' ELSE sitios END  AS Sitios " +
                            "FROM J_Usuarios " +
                            "WHERE idusuario = " + idusuario.ToString
        da = New SqlDataAdapter(qry, cnx)
        'da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(ds, "sitios")
        da.Dispose()
        cnx.Dispose()
        Return ds
    End Function

    ' Funcion para cargar sitios por usuario
    Public Function CargarPerfiles(strUs As String, strPw As String) As DataSet
        Dim ds As New DataSet()
        cnx = conexion.conectar(strUs, strPw)
        Dim qry As String = "SELECT nombre AS 'Perfil de Usuario',descripcion AS Descripcion FROM J_Area ORDER BY 1"
        da = New SqlDataAdapter(qry, cnx)
        'da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(ds, "areas")
        da.Dispose()
        cnx.Dispose()
        Return ds
    End Function

    ' Funcion para verificar si existe usuario en base de datos
    Public Function VerificarUsuario(strUsuario As String, strPasswd As String) As DataTable
        Dim ds As New DataSet()
        cnx = conexion.conectar(strUsuario, strPasswd)
        Dim qry As String = "SELECT a.idgrupo,b.nombre AS Grupo,b.idarea,c.nombre AS Area,a.idusuario,a.usuario,a.clave " +
                            "FROM j_usuarios a, j_grupo b, j_area c " +
                            "WHERE b.idgrupo = a.idgrupo " +
                            "AND   b.idarea = c.idarea " +
                            "AND   a.usuario = '" + strUsuario + "' "
        ' AND clave = '" + strPasswd + "' "
        da = New SqlDataAdapter(qry, cnx)
        'da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(ds, "existe")
        da.Dispose()
        cnx.Dispose()
        Return ds.Tables(0)
    End Function

#End Region

#Region "Funciones Proceso de Envio de Mensajeria Interna Sistema AMIGO"
    ' Funcion para crear el mensaje para envio de correo interno
    Public Function CrearMensajexEmisor(strUsuario As String, strPasswd As String,
                                        strAsunto As String, strCuerpo As String, strResponderA As String) As Int32
        Dim ds As New DataSet()
        Dim IDMensaje As Int32 = 0
        strResponderA = strResponderA + "@cahsa.hn"
        cnx = conexion.conectar(strUsuario, strPasswd)
        Dim qry As String = "INSERT INTO Produccion.dbo.CEMensajes(Emisor,Asunto,Cuerpo,EstaEnviado,FechaEnvio,ProgramarEnvio, ResponderA) " +
                           " VALUES ('" & strUsuario & "','" + strAsunto + "','" + strCuerpo + "','0',GETDATE(),DATEADD(minute,2,GETDATE()),'" + strResponderA + "')"

        cmd = New SqlCommand(qry, cnx)
        cnx.Open()
        Try
            cmd.ExecuteNonQuery()
            IDMensaje = 1
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error al Operar la Base de Datos")
            IDMensaje = -1
        Finally
            cnx.Close()
        End Try

        'Si el proceso de insercion es un exito, se prosigue a validar dicho estado
        If IDMensaje = 1 Then
            'Obtener el ID del Mensaje
            IDMensaje = ObtenerIDMensajeEmisor(strUsuario, strPasswd)

            'Agregar direccion de correo electronico del emisor
            Dim rta As String = AgregarCorreoUsuxMensaje(strUsuario, strPasswd, IDMensaje)
            If (rta.Substring(0, 1).Equals("-")) Then
                IDMensaje = -1
            End If
        End If

        Return IDMensaje
    End Function

    ' Funcion para registrar correo electronico del emisor
    Public Function AgregarCorreoUsuxMensaje(strUsuario As String, strPasswd As String, intIDMss As Int32) As String
        Dim ds As New DataSet()
        Dim Mensaje As String = strUsuario + "@cahsa.hn"
        cnx = conexion.conectar(strUsuario, strPasswd)
        Dim qry As String = "INSERT INTO Produccion.dbo.CEUsuXMensaje (Mensaje,Email) VALUES (" & intIDMss & ",'" & Mensaje & "')"
        cmd = New SqlCommand(qry, cnx)
        cnx.Open()
        Try
            cmd.ExecuteNonQuery()
            Mensaje = "+1"
        Catch ex As Exception
            'MsgBox(Err.Description, MsgBoxStyle.Critical, "Error al Operar la Base de Datos")
            Mensaje = "-Error al insertar la informacion en la tabla CEUsuXMensaje. Favor verifique"
        Finally
            cnx.Close()
        End Try

        Return Mensaje
    End Function

    ' Funcion para obtener el ID de Mensaje del Emisor
    Public Function ObtenerIDMensajeEmisor(strUsuario As String, strPasswd As String) As Int32
        Dim ds As New DataSet()
        cnx = conexion.conectar(strUsuario, strPasswd)
        Dim qry As String = "SELECT ID FROM Produccion.dbo.CEMensajes WHERE emisor = '" & strUsuario & "' ORDER BY ID DESC"
        da = New SqlDataAdapter(qry, cnx)
        'da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(ds, "existe")
        da.Dispose()
        cnx.Dispose()
        Dim xID As Int32 = CInt(ds.Tables(0).Rows(0).Item(0))
        Return xID
    End Function

    ' Funcion para registrar bitacora de insercion de mensajes enviados
    Public Function CrearLogMensajes(strUsuario As String, strPasswd As String, intIDMss As Int32, strServerDestino As String) As String
        Dim ds As New DataSet()
        Dim MensajeError As String = ""
        cnx = conexion.conectar(strUsuario, strPasswd)
        Dim qry As String = "INSERT INTO Produccion.dbo.CEArchXMensaje (Mensaje,Archivo) VALUES (" & intIDMss & ",'" & strServerDestino & "')"
        cmd = New SqlCommand(qry, cnx)
        cnx.Open()
        Try
            cmd.ExecuteNonQuery()
            MensajeError = "+1"
        Catch ex As Exception
            'MsgBox(Err.Description, MsgBoxStyle.Critical, "Error al Operar la Base de Datos")
            MensajeError = "-Error al insertar la informacion en la tabla CEArchXMensaje. Favor verifique"
        Finally
            cnx.Close()
        End Try

        Return MensajeError
    End Function
#End Region

#Region "Formulario Areas de Trabajo"
    ' Funcion para obtener todas las areas de trabajo disponibles
    Public Function ObtenerAreasTrabajo(strUsuario As String, strPasswd As String) As DataSet
        Dim ds As New DataSet()
        cnx = conexion.conectar(strUsuario, strPasswd)
        Dim qry As String = "SELECT a.idarea,a.nombre,a.descripcion " +
                            "FROM J_Area a "

        da = New SqlDataAdapter(qry, cnx)
        'da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(ds, "areas")
        da.Dispose()
        cnx.Dispose()
        Return ds
    End Function

    ' Funcion para Guardar y/o modificar la informacion de la area de trabajo
    Public Function GuardarModificarAreasTrabajo(strUsuario As String, strPasswd As String,
                                                 intIDArea As Int32, intBandera As Boolean, strNombre As String, strDescri As String) As String
        Dim ds As New DataSet()
        Dim Mensaje As String = ""
        cnx = conexion.conectar(strUsuario, strPasswd)
        Dim qry As String
        If (intBandera = True) Then
            qry = "UPDATE Produccion.dbo.J_Area " &
                  "SET nombre  = '" + strNombre + "', " &
                  "descripcion = '" + strDescri + "' " &
                  "WHERE idarea = " & intIDArea
            Mensaje = "+Datos modificados satisfactoriamente"
        Else
            qry = "INSERT INTO Produccion.dbo.J_Area (Nombre,Descripcion) VALUES ('" + strNombre + "','" + strDescri + "')"
            Mensaje = "+Datos insertados satisfactoriamente"
        End If
        cmd = New SqlCommand(qry, cnx)
        cnx.Open()
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Mensaje = "-Error al guardar o modificar informacion en la tabla J_Area. Favor verifique"
        Finally
            cnx.Close()
        End Try

        Return Mensaje
    End Function

    ' Funcion para eliminar el ID Area
    Public Function EliminarAreasTrabajo(strUsuario As String, strPasswd As String,
                                                 intIDArea As Int32) As String
        Dim ds As New DataSet()
        Dim Mensaje As String = ""
        Dim qry As String = "DELETE FROM J_Area WHERE idarea = " & intIDArea
        cnx = conexion.conectar(strUsuario, strPasswd)
        cmd = New SqlCommand(qry, cnx)
        cnx.Open()
        Try
            cmd.ExecuteNonQuery()
            Mensaje = "+Area de Trabajo eliminado satisfactoriamente."
        Catch ex As Exception
            Mensaje = "-Error al eliminar informacion de la tabla J_Area. Excepcion: " + ex.Message
        Finally
            cnx.Close()
        End Try
        Return Mensaje
    End Function

    ' Funcion para verificar si el area pertenece a grupos de trabajos
    Public Function VerificarAreasGruposTrabajo(strUsuario As String, strPasswd As String, intIDArea As Int32) As Integer
        Dim ds As New DataSet()
        cnx = conexion.conectar(strUsuario, strPasswd)
        Dim qry As String = "SELECT A.nombre FROM J_Area A INNER JOIN J_Grupo G ON A.idArea = G.idArea WHERE A.idArea = " & intIDArea
        da = New SqlDataAdapter(qry, cnx)
        da.Fill(ds, "hay")
        da.Dispose()
        cnx.Dispose()
        Dim xcount As Integer = ds.Tables(0).Rows.Count
        Return xcount
    End Function
#End Region

#Region "Formulario Calenderizar Reporte"
    ' Funcion para Obtener parametros del reporte
    Public Function ObtenerParametrosxReporte(strUsuario As String, strPasswd As String,
                                              intIdReporte As Int32, strBD As String) As DataSet
        Dim ds As New DataSet()
        '"SELECT a.idReporte,a.jDataBase,a.reporte,a.tipoobjeto,a.objeto," +
        cnx = conexion.conectar(strUsuario, strPasswd)
        Dim qry As String = "SELECT b.ORDINAL_POSITION AS Secuencia,b.PARAMETER_NAME AS Parametro," +
                            "b.DATA_TYPE AS TipoDato,b.CHARACTER_MAXIMUM_LENGTH AS Maximo,'' AS Valor " +
                            "FROM J_Reportes a, " + strBD + ".information_schema.parameters b " +
                            "WHERE a.objeto COLLATE DATABASE_DEFAULT = b.SPECIFIC_NAME COLLATE DATABASE_DEFAULT " +
                            "AND   b.SPECIFIC_CATALOG COLLATE DATABASE_DEFAULT = a.jDataBase COLLATE DATABASE_DEFAULT " +
                            "AND   a.idReporte = " & intIdReporte & " " +
                            "ORDER BY a.idReporte "

        da = New SqlDataAdapter(qry, cnx)
        'da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(ds, "parametros")
        da.Dispose()
        cnx.Dispose()
        Return ds
    End Function
#End Region

#Region "Utilidades"
    'Funcion para obtener
    Public Function ObtenerLongitudColTabla(strUsuario As String, strPasswd As String, strTabla As String, strCol As String) As DataTable
        Dim ds As New DataSet()
        cnx = conexion.conectar(strUsuario, strPasswd)
        Dim qry As String = "SELECT sc.column_id AS ID, sc.name AS Columna,sc.max_length AS Maximo " &
                            "FROM sys.objects SO INNER JOIN sys.columns SC " &
                            "ON SO.OBJECT_ID = SC.OBJECT_ID " &
                            "WHERE SO.TYPE = 'U' " &
                            "AND SO.name = '" + strTabla + "' " +
                            "AND sc.name = '" + strCol + "'"
        If (strCol = "-1") Then
            qry = qry.Replace("AND sc.name = '-1'", "")
        End If
        da = New SqlDataAdapter(qry, cnx)
        da.Fill(ds, strTabla)
        da.Dispose()
        cnx.Dispose()
        Return ds.Tables(0)
    End Function

    'Funcion para actualizar informacion complementaria de cada reporte en la tabla J_Reportes
    Public Function ActualizarCamposAdicionalesRep(strUsuario As String, strPasswd As String, intIdreporte As Int32,
                                                   strTipo As String, strObjeto As String, strObserv As String) As String
        Dim ds As New DataSet()
        Dim Mensaje As String = ""
        cnx = conexion.conectar(strUsuario, strPasswd)
        Dim qry As String
        qry = "UPDATE Produccion.dbo.J_Reportes " &
                  "SET tipoobjeto  = '" + strTipo + "', " &
                  "objeto = '" + strObjeto + "', " &
                  "observaciones = '" + strObserv + "' " &
                  "WHERE idreporte = " & intIdreporte & ""
        Mensaje = "+"
        cmd = New SqlCommand(qry, cnx)
        cnx.Open()
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Mensaje = "-Error al guardar o modificar informacion en la tabla J_Reportes. Favor verifique"
        Finally
            cnx.Close()
        End Try

        Return Mensaje
    End Function
#End Region

#Region "Accesos perfiles de usuario tablas AAA_ en base de datos Produccion"
    ' Funcion para obtener informacion de los usuarios
    Public Function ObtenerInfoUsuarios(strUsuario As String, strPasswd As String, idx As Integer) As DataSet
        Dim ds As New DataSet()
       
        If idx = 1 Then
            qry = "SELECT a.*,'[' + CAST(p.PerfilID AS NVARCHAR(4)) + '] ' + p.Descripcion AS Perfil " & _
                  "FROM AAA_ListaUsuarios a, AAA_ListaPerfiles p " & _
                  "WHERE p.PerfilID = a.PerfilID " & _
                  "AND   a.Activo = 1 " & _
                  "AND a.usuarioid = '" & strUsuario & "' "
        End If
        If idx = 2 Then
            qry = "SELECT a.UsuarioID,a.Nombre,'[' + CAST(p.PerfilID AS NVARCHAR(4)) + '] ' + p.Descripcion AS Perfil " & _
                  "FROM AAA_ListaUsuarios a, AAA_ListaPerfiles p " & _
                  "WHERE p.PerfilID = a.PerfilID " & _
                  "AND   a.Activo = 1 " & _
                  "ORDER BY a.UsuarioID "
            dllUtil = New ClsUtilitarios.ControlAccesoIni()
            strPasswd = dllUtil.FnxProcDC001(strPasswd)
        End If

        If idx = 3 Then
            qry = "SELECT a.UsuarioID, a.Nombre " & _
                  "FROM AAA_ListaUsuarios a " & _
                  "ORDER BY a.UsuarioID "
        End If

        cnx = conexion.conectar(strUsuario, strPasswd)
        da = New SqlDataAdapter(qry, cnx)
        da.Fill(ds, "datos")
        da.Dispose()
        cnx.Dispose()
        Return ds
    End Function

    ' Funcion para obtener las empresas por usuario
    Public Function ObtenerEmpresasxUsuario(strUsuario As String, strPasswd As String, strUsuarioID As String, idx As Integer) As DataSet
        Dim ds As New DataSet()
        dllUtil = New ClsUtilitarios.ControlAccesoIni()
        strPasswd = dllUtil.FnxProcDC001(strPasswd)
        cnx = conexion.conectar(strUsuario, strPasswd)

        If idx = 1 Then
            qry = "SELECT e.TP AS EmpresaCodigo,e.Description AS Empresa " & _
                  "FROM AAA_EmpresaXUsuario exu, " & _
                  "Finanzas.dbo.IDF_Empresas e " & _
                  "WHERE exu.EmpresaID = e.TP " & _
                  "AND   exu.UsuarioID = '" & strUsuarioID & "' ORDER BY e.TP "
        End If

        da = New SqlDataAdapter(qry, cnx)
        da.Fill(ds, "datos")
        da.Dispose()
        cnx.Dispose()
        Return ds
    End Function

    ' Funcion para obtener formularios por Perfil
    Public Function ObtenerFormxPerfil(strUsuario As String, strPasswd As String, idx As Integer, PerfilID As Integer) As DataTable
        Dim ds As New DataSet()

        If idx = 1 Then
            qry = "SELECT a.PerfilID,a.ProgramaID,a.FormularioID " & _
                  "FROM AAA_PermisosxPerfil a " & _
                  "WHERE a.PerfilID = " & PerfilID &
                  " GROUP BY a.PerfilID,a.ProgramaID,a.FormularioID "
        End If
      
        cnx = conexion.conectar(strUsuario, strPasswd)
        da = New SqlDataAdapter(qry, cnx)
        da.Fill(ds, "datos")
        da.Dispose()
        cnx.Dispose()
        Return ds.Tables(0)
    End Function

    ' Funcion para obtener opciones segun formulario por Perfil
    Public Function ObtenerOpcionesxForm(strUsuario As String, strPasswd As String, idx As Integer,
                                         PerfilID As Integer, PrgID As Integer, FormID As Integer) As DataTable
        Dim ds As New DataSet()

        If idx = 1 Then
            qry = "SELECT a.* " & _
                  "FROM AAA_PermisosxPerfil a " & _
                  "WHERE a.PerfilID = " & PerfilID & " " & _
                  "AND a.ProgramaID = " & PrgID & " " & _
                  "AND a.FormularioID = " & FormID & " "
        End If

        cnx = conexion.conectar(strUsuario, strPasswd)
        da = New SqlDataAdapter(qry, cnx)
        da.Fill(ds, "datos")
        da.Dispose()
        cnx.Dispose()
        Return ds.Tables(0)
    End Function


#End Region

#Region "Configuracion por Empresa"
    ' Funcion para obtener informacion: Configuracion de Empresasa (CAI)
    Public Function ObtenerInfoConfigxEmpresa(strUsuario As String, strPasswd As String,
                                              idx As Integer, EmpresaID As Integer, td As Integer) As DataTable
        Dim ds As New DataSet()

        If idx = 1 Then
            qry = "SELECT dce.* " & _
                  "FROM IDF_ConfigxEmp ece,IDF_DetConfigxEmp dce " & _
                  "WHERE ece.CAI = dce.CAI " & _
                  "AND   dce.esActual = 1 " & _
                  "AND   ece.EmpresaCodigo = " & EmpresaID & " " & _
                  "AND   dce.TiposDoctoID = " & td & ""
        End If

        cnx = conexion.CadenaFinanzasSQLConnection(strUsuario, strPasswd)
        da = New SqlDataAdapter(qry, cnx)
        da.Fill(ds, "datos")
        da.Dispose()
        cnx.Dispose()
        Return ds.Tables(0)
    End Function

    Public Function ObtenerInfoConfigxEmpresa2_Fac(strUsuario As String, strPasswd As String,
                                              idx As Integer, EmpresaID As Integer, td As Integer) As DataTable
        Dim ds As New DataSet()

        If idx = 1 Then 'Facturas locales, boleta de venta, exportacion
            If td = 7 Then 'Facturas x Exportacion
                td = 1
            End If
            '(SELECT COUNT(fac.DFFactID) " & _
            '                    "FROM IDF_DFFacts fac " & _
            '                    "WHERE fac.EmpresaCodigo = ece.EmpresaCodigo " & _
            '                    "AND   fac.CAI = ece.CAI)
            qry = "SELECT dce.*,1 AS FechasEmitidas " & _
                  "FROM IDF_ConfigxEmp ece,IDF_DetConfigxEmp dce " & _
                  "WHERE ece.CAI = dce.CAI " & _
                  "AND   dce.esActual = 1 " & _
                  "AND   ece.EmpresaCodigo = " & EmpresaID & " " & _
                  "AND   dce.TiposDoctoID = " & td & ""
        End If
        If idx = 2 Then
            qry = "SELECT dce.*,(SELECT COUNT(x.DFDescripID) " & _
                               "FROM IDF_DFDescrip x " & _
                               "WHERE x.EmpresaCodigo = ece.EmpresaCodigo " & _
                               "AND   x.CAI = ece.CAI " & _
                               "AND   x.TiposDoctoID = " & td & ") AS FechasEmitidas " & _
                 "FROM IDF_ConfigxEmp ece,IDF_DetConfigxEmp dce " & _
                 "WHERE ece.CAI = dce.CAI " & _
                 "AND   ece.esActual = 1 " & _
                 "AND   ece.EmpresaCodigo = " & EmpresaID & " " & _
                 "AND   dce.TiposDoctoID = " & td & ""
        End If

        cnx = conexion.CadenaFinanzasSQLConnection(strUsuario, strPasswd)
        da = New SqlDataAdapter(qry, cnx)
        da.Fill(ds, "datos")
        da.Dispose()
        cnx.Dispose()
        Return ds.Tables(0)
    End Function

    Public Function ObtenerInfoConfigxEmpresa2_OtrosDoctos(strUsuario As String, strPasswd As String,
                                            idx As Integer, EmpresaID As Integer, td As Integer) As DataTable
        Dim ds As New DataSet()

        If idx = 1 Then
            qry = "SELECT dce.*,(SELECT COUNT(fac.DFFactID) " & _
                                "FROM IDF_DFDescrip fac " & _
                                "WHERE fac.EmpresaCodigo = ece.EmpresaCodigo " & _
                                "AND   fac.CAI = ece.CAI) AS FechasEmitidas " & _
                  "FROM IDF_ConfigxEmp ece,IDF_DetConfigxEmp dce " & _
                  "WHERE ece.CAI = dce.CAI " & _
                  "AND   ece.esActual = 1 " & _
                  "AND   ece.EmpresaCodigo = " & EmpresaID & " " & _
                  "AND   dce.TiposDoctoID = " & td & ""
        End If

        cnx = conexion.CadenaFinanzasSQLConnection(strUsuario, strPasswd)
        da = New SqlDataAdapter(qry, cnx)
        da.Fill(ds, "datos")
        da.Dispose()
        cnx.Dispose()
        Return ds.Tables(0)
    End Function

    Public Function ObtenerInfoIDF_ConfigxEmp(strUsuario As String, strPasswd As String,
                                              idx As Integer, EmpresaID As Integer,
                                              strCAI As String, intTipoDoctoID As Integer) As DataTable
        Dim ds As New DataSet()

        If idx = 1 Then
            qry = "SELECT x.EmpresaCodigo,x.esActual,x.CAI,CONVERT(NVARCHAR(10),x.FechaLimite,103) AS FechaLimite, " & _
                  "CONVERT(NVARCHAR(10),GETDATE(),103) AS FechaHoy, " & _
                  "CASE " & _
                    "WHEN CONVERT(NVARCHAR(10),GETDATE()+0,102) <= CONVERT(NVARCHAR(10),x.FechaLimite,102) THEN 0 " & _
                    "ELSE 1 " & _
                  "END AS FechaLimiteCaducada, " & _
                  "EsExtendido,FechaExtendida," & _
                  "CASE " & _
                    "WHEN CONVERT(NVARCHAR(10),GETDATE()+0,102) <= CONVERT(NVARCHAR(10),d.FechaExtendida,102) THEN 0 " & _
                    "ELSE 1 " & _
                  "END AS FechaLimiteExtendidaCaducada " & _
                  "FROM IDF_ConfigxEmp x, IDF_DetConfigxEmp d " & _
                  "WHERE x.CAI = d.CAI " & _
                  "AND CAST(x.EmpresaCodigo AS INT) = " & EmpresaID & " " & _
                  "AND x.CAI = '" & strCAI & "' " & _
                  "AND d.TiposDoctoID = " & intTipoDoctoID & " "
        End If

        cnx = conexion.CadenaFinanzasSQLConnection(strUsuario, strPasswd)
        da = New SqlDataAdapter(qry, cnx)
        da.Fill(ds, "datos")
        da.Dispose()
        cnx.Dispose()
        Return ds.Tables(0)
    End Function

    Public Function ObtenerMaximoDocxEmpresa(strUsuario As String, strPasswd As String,
                                             idx As Integer, EmpresaID As Integer, td As Integer,
                                             StrCAI As String) As DataTable
        Dim ds As New DataSet()

        If idx = 1 Then
            qry = "SELECT ISNULL(COUNT(f.DFFactID),0) AS Cantidad " & _
                  "FROM IDF_DFFacts f " & _
                  "WHERE CAST(f.EmpresaCodigo AS INT) = " & EmpresaID & " " & _
                  "AND   f.CAI = '" & StrCAI & "' "
        End If
        If idx = 2 Then
            qry = "SELECT ISNULL(COUNT(d.DFDescripID),0) AS Cantidad " & _
                  "FROM IDF_DFDescrip d " & _
                  "WHERE CAST(d.EmpresaCodigo AS INT) = " & EmpresaID & " " & _
                  "AND   d.TiposDoctoID = " & td & " " & _
                  "AND   d.CAI = '" & StrCAI & "' "
        End If
        cnx = conexion.CadenaFinanzasSQLConnection(strUsuario, strPasswd)
        da = New SqlDataAdapter(qry, cnx)
        da.Fill(ds, "datos")
        da.Dispose()
        cnx.Dispose()
        Return ds.Tables(0)
    End Function

    Public Function obtenerInformacionAnexoPorEmpresa(strUsuario As String, strPasswd As String,
                                             idx As Integer, EmpresaID As Integer) As DataTable
        Dim ds As New DataSet()

        If idx = 1 Then
            qry = "SELECT ae.* " & _
                  "FROM IDF_EmpresasAnexo ae " & _
                  "WHERE CAST(ae.EmpresaCodigo AS INT) = " & EmpresaID.ToString() & " "
        End If

        cnx = conexion.CadenaFinanzasSQLConnection(strUsuario, strPasswd)
        da = New SqlDataAdapter(qry, cnx)
        da.Fill(ds, "datos")
        da.Dispose()
        cnx.Dispose()
        Return ds.Tables(0)
    End Function


#End Region

#Region "Formulario Remisiones"
    Public Function VerificarRemisionIDDetalleZero(strUsuario As String,
                                                   strPasswd As String,
                                                   idx As Integer,
                                                   EmpresaID As Integer,
                                                   td As Integer) As DataTable
        Dim ds As New DataSet()

        If idx = 1 Then 'Select
            qry = "SELECT COUNT(*) AS Cantidad " & _
                  "FROM IDF_ProdxRem " & _
                  "WHERE RemisionID = 0 "
        End If
        If idx = 2 Then
            qry = "DELETE FROM IDF_ProdxRem WHERE RemisionID = 0; SELECT 0 AS Exito "
        End If

        cnx = conexion.CadenaFinanzasSQLConnection(strUsuario, strPasswd)
        da = New SqlDataAdapter(qry, cnx)
        da.Fill(ds, "datos")
        da.Dispose()
        cnx.Dispose()
        Return ds.Tables(0)
    End Function

#End Region

#Region "Formulario Formulario Comprobante de Retencion"
    Public Function RetencionesBuscarFacturas(strUsuario As String,
                                              strPasswd As String,
                                              idx As Integer,
                                              EmpresaID As Integer,
                                              td As Integer,
                                              Correlativo As String,
                                              SocioNegocioID As String) As DataTable
        Dim ds As New DataSet()

        'split
        Dim TestString As String = Correlativo
        Dim TestArray() As String = Split(TestString, "-")

        If idx = 1 Then 'Select
            qry = "SELECT f.* " & _
                  "FROM IDF_FactComp f " & _
                  "WHERE CAST(f.EmpresaCodigo AS INT) = " + EmpresaID.ToString + " " & _
                  "AND   f.NDFEstab = '" + TestArray(0) + "' " & _
                  "AND   f.NDFPuntoEm = '" + TestArray(1) + "' " & _
                  "AND   f.NDFTipoDoc = '" + TestArray(2) + "' " & _
                  "AND   f.NDFCorrelat = '" + TestArray(3) + "' "
        ElseIf idx = 2 Then
            qry = "SELECT fc.CAIXSdNID,cxs.SdN,s.Description,cxs.CAI, " & _
                  "(fc.NDFEstab + '-' + NDFPuntoEm + '-' + NDFTipoDoc + '-' + NDFCorrelat) AS Correlativo," & _
                  "CONVERT(NVARCHAR(10),fc.Fecha,103) AS Fecha, fc.RetencionID,fc.FactCompID " & _
                  "FROM IDF_FactComp fc,IDF_CAIXSdN cxs, IDF_SdNs s " & _
                  "WHERE 1=1 " & _
                  "AND s.TP = cxs.SdN " & _
                  "AND fc.CAIXSdNID = cxs.CAIXSdNID " & _
                  "AND CAST(fc.EmpresaCodigo AS INT) = " + EmpresaID.ToString + " " & _
                  "AND s.TP = '" & SocioNegocioID & "' " & _
                  "AND fc.aplicaRetencion = 1 " & _
                  "AND NOT EXISTS(SELECT od.* " & _
                                 "FROM   dbo.vwIDF_OtrosDoctos4 od " & _
                                 "WHERE  CAST(od.EmpresaCodigo AS INT) = " & EmpresaID.ToString + " " & _
                                 "AND    od.TiposDoctoID = 5 " & _
                                 "AND    od.CAIComprobante = cxs.CAI " & _
                                 "AND    od.NumComprobante = (fc.NDFEstab + '-' + NDFPuntoEm + '-' + NDFTipoDoc + '-' + NDFCorrelat) " & _
                                 "AND    od.ClienteCodigo = cxs.SdN " & _
                                 "AND    od.Estado IN (0)) " & _
                  "ORDER BY cxs.SdN "
        End If

        cnx = conexion.CadenaFinanzasSQLConnection(strUsuario, strPasswd)
        da = New SqlDataAdapter(qry, cnx)
        da.Fill(ds, "datos")
        da.Dispose()
        cnx.Dispose()
        Return ds.Tables(0)
    End Function

    Public Function obtenerDetalleFacCompras(strUsuario As String,
                                             strPasswd As String,
                                             idx As Integer,
                                             FactCompID As Integer) As DataTable
        Dim ds As New DataSet()

        If idx = 1 Then 'Select
            qry = "SELECT det.* FROM IDF_DetFactComp det WHERE det.FactCompID = " & FactCompID & " "
        End If

        cnx = conexion.CadenaFinanzasSQLConnection(strUsuario, strPasswd)
        da = New SqlDataAdapter(qry, cnx)
        da.Fill(ds, "datos")
        da.Dispose()
        cnx.Dispose()
        Return ds.Tables(0)
    End Function
#End Region

#Region "Formulario Ingreso de Facturas DEI"
    Public Function obtenerCantidadBarrilesDesdeBascula(strUsuario As String,
                                            strPasswd As String,
                                            idx As Integer,
                                            BoletaID As String) As DataTable
        Dim ds As New DataSet()

        If idx = 1 Then 'Select
            qry = "SELECT CONVERT(NUMERIC(25, 2),Round(((b.Bruto - b.Tara)/640), 2, 1)) AS Neto,b.ProductoID, " & _
                         "(SELECT x.ProdCodigo " & _
                         "FROM Finanzas.dbo.IDF_Productos x " & _
                         "WHERE x.BasculaProductoID = b.ProductoID) AS ProdCodigo " & _
                  "FROM  BasculaBoleta.dbo.Boleta b " & _
                  "WHERE b.BoletaID IN ('" & BoletaID & "') "
        End If

        cnx = conexion.CadenaFinanzasSQLConnection(strUsuario, strPasswd)
        da = New SqlDataAdapter(qry, cnx)
        da.Fill(ds, "datos")
        da.Dispose()
        cnx.Dispose()
        Return ds.Tables(0)
    End Function

    Public Function verificarNumeroOrdenAsignadoAFactura(strUsuario As String,
                                                        strPasswd As String,
                                                        idx As Integer,
                                                        EmpresaID As Integer,
                                                        BoletaID As String) As Boolean
        Dim ds As New DataSet()

        If idx = 1 Then 'Select
            qry = "SELECT COUNT(x.DFFactID) AS ExisteFacturaID " & _
                  "FROM IDF_DFFacts x " & _
                  "WHERE CAST(x.EmpresaCodigo AS INT) = " & EmpresaID & " " & _
                  "AND x.Estado IN (0) " & _
                  "AND x.NumeroOrden IN ('" & BoletaID & "') "
        End If

        cnx = conexion.CadenaFinanzasSQLConnection(strUsuario, strPasswd)
        da = New SqlDataAdapter(qry, cnx)
        da.Fill(ds, "datos")
        da.Dispose()
        cnx.Dispose()

        Dim ConteoFactura As Integer = 0
        ConteoFactura = CInt(ds.Tables(0).Rows(0)(0).ToString)
        If ConteoFactura = 1 Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region

#Region "Formulario Ingreso de Compras (Facturas de Proveedores)"
    Public Function VerificarRetencionDeFacturaCompra(strUsuario As String,
                                             strPasswd As String,
                                             idx As Integer,
                                             EmpresaID As Integer,
                                             td As Integer,
                                             CAIComprobante As String,
                                             Correlativo As String,
                                             SocioNegocioID As String) As DataTable
        Dim ds As New DataSet()

        'split
        'Dim TestString As String = Correlativo
        'Dim TestArray() As String = Split(TestString, "-")

        If idx = 1 Then 'Select
            qry = "SELECT ISNULL(COUNT(r.DFDescripID),0) AS Existe, " & _
                  "(SELECT aplicaGenAutoRetenciones " & _
                    "FROM IDF_EmpresasAnexo " & _
                    "WHERE CAST(EmpresaCodigo AS INT) = " & EmpresaID.ToString & " ) AS aplicaGenAutoRetenciones " & _
                  "FROM IDF_DFDescrip r " & _
                  "WHERE CAST(r.EmpresaCodigo AS INT) = " + EmpresaID.ToString + " " & _
                  "AND   r.Estado IN (0) " & _
                  "AND   r.CAIComprobante = '" + CAIComprobante + "' " & _
                  "AND   r.NumComprobante = '" + Correlativo + "' "

        End If
        cnx = conexion.CadenaFinanzasSQLConnection(strUsuario, strPasswd)
        da = New SqlDataAdapter(qry, cnx)
        da.Fill(ds, "datos")
        da.Dispose()
        cnx.Dispose()
        Return ds.Tables(0)
    End Function

    Public Function obtenerPorcentajeRetencion(strUsuario As String,
                                               strPasswd As String,
                                               idx As Integer,
                                               CodigoRetencion As String) As DataTable
        Dim ds As New DataSet()

        If idx = 1 Then 'Select
            qry = "SELECT * FROM IDF_Retenciones"
        End If

        cnx = conexion.CadenaFinanzasSQLConnection(strUsuario, strPasswd)
        da = New SqlDataAdapter(qry, cnx)
        da.Fill(ds, "datos")
        da.Dispose()
        cnx.Dispose()
        Return ds.Tables(0)
    End Function
#End Region
End Class

#Region "instrucciones_utiles"
'Dim qry As String = "SELECT nombrereporte AS Nombre,descripcionreporte AS Descripcion,nombrearchivo AS Reporte, " +
'                    "FROM " + strTabla +
'                    " WHERE " + strWhere
#End Region