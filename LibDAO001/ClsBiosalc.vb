Option Strict On
Option Explicit On
'
Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class ClsBioSalc

    ' Creado objeto conexion del tipo Conexion para tener acceso al metodo conecta
    Public conexion As New ClsConexion()
    Public cnx As SqlConnection = Nothing
    Public da As SqlDataAdapter = Nothing
    Public cmd As SqlCommand = Nothing
    Public query, mensaje, dtNombre As String
    Public dsTem As DataSet = Nothing

    Public Function ObtenerEmbalajes(strUsuario As String, strPasswd As String,
                                     intIdxQuery As Integer) As DataTable
        Dim ds As New DataSet()
        'cnx = conexion.conectarAmigoDbBioSalcPrueba(strUsuario, strPasswd)
        cnx = conexion.conectarAmigoDbBioSalc(strUsuario, strPasswd)

        If (intIdxQuery = 1) Then
            query = "SELECT * " &
                    "FROM empaque ORDER BY COD_EMPAQUE "
        End If

        da = New SqlDataAdapter(query, cnx)
        'da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(ds, "datos")
        da.Dispose()
        cnx.Dispose()
        Return ds.Tables(0)
    End Function

    Public Function ObtenerOrdenPesoOtrosProductosBioSalc(strUsuario As String, strPasswd As String,
                                                          intIdxQuery As String, NumPesajeBioSalc As Integer) As DataTable
        Dim ds As New DataSet()
        'cnx = conexion.conectarAmigoDbBioSalcPrueba(strUsuario, strPasswd)
        cnx = conexion.conectarAmigoDbBioSalc(strUsuario, strPasswd)

        If (intIdxQuery = "vT") Then
            query = "SELECT COUNT(O.NUMERO) AS Numero " &
                   "FROM OPROD_MOV O, " &
                         "OPROD_MOV_PROD OP, " &
                         "CLIENTE C, " &
                         "VEICULOS V, " &
                         "MODEQUIP ME, " &
                         "GRUEQUIP GR " &
                   "WHERE O.NUMERO = OP.NUMERO " &
                   "AND O.CLIENTE = C.CODIGO " &
                   "AND V.CODIGO  = O.CABEZOTE " &
                   "AND ME.CODIGO = V.MODELO " &
                   "AND GR.CODIGO = ME.GRUPO " &
                   "AND O.STATUS IN ('A') " &
                   "AND O.TARA > 0 " &
                   "AND O.NUMERO IN (" + NumPesajeBioSalc.ToString() + ") "
        End If

        If (intIdxQuery = "T") Then
            query = "SELECT O.CLIENTE AS CodCliente," &
                    "C.NOME AS Cliente," &
                    "O.STATUS AS Estado," &
                    "O.ALMOXAGR AS CodBodega," &
                    "ISNULL((SELECT a.NOME FROM ALMOXAGR a " &
                             "WHERE a.CODIGO = O.ALMOXAGR),'') AS Bodega," &
                    "O.OBSERV   AS BodegaDestino," &
                   "O.FH_SAI   AS FechaSalida," &
                   "O.HORA_SAI AS HoraSalida," &
                   "O.TRANSACAO AS MotivoRemision, " &
                   "O.TRANSP AS TransportistaID," &
                   "O.CHOFER AS ConductorID," &
                   "O.CABEZOTE AS VehiculoID," &
                   "ME.GRUPO AS MarcaID, " &
                   "GR.NOME  AS MarcaVehiculo," &
                   "ISNULL(V.PLACA,'')  AS Placa, " &
                   "ISNULL(O.SELLO_I,0) AS SelloInicial, " &
                   "ISNULL(O.SELLO_F,0) AS SelloFinal," &
                   " (CAST(ISNULL(O.SELLO_I,0) AS NVARCHAR)+' AL '+CAST(ISNULL(O.SELLO_F,0) AS NVARCHAR)) AS RangoSelloCamion," &
                   "O.OBSERV2 AS SellosJumbosOtros," &
                   "OP.PROD AS CodProducto,		 " &
                   "OP.CANTIDAD AS Cantidad," &
                   "OP.UM AS UnidadMedidaID," &
                   "O.PESO_BRUTO AS PesoBrutoLbs," &
                   "O.TARA AS PesoTaraLbs," &
                   "O.PESO_NETO AS PesoNetoLbs," &
                   "(O.PESO_NETO  * (SELECT FATOR FROM CONV_UM WHERE CODIGO IN ('LBS_KG'))) AS PesoNetoKG," &
                   "((O.PESO_NETO * (SELECT FATOR FROM CONV_UM WHERE CODIGO IN ('LBS_KG')))/50) AS Sacos50KG,   " &
                   "O.NUMERO AS NumOrden," &
                   "O.DOC_INTERNO AS DocInterno1, " &
                   "ISNULL(O.DOC_INTERNO2,'') AS DocInterno2," &
                   "ISNULL(O.REMOLQUE,'') AS CodRemolque," &
                   "ISNULL(O.REMOLQUE2,'') AS PlacaRemolque," &
                   "OP.EMPAQUE AS CodEmpaque " &
                   "FROM OPROD_MOV O, " &
                         "OPROD_MOV_PROD OP, " &
                         "CLIENTE C, " &
                         "VEICULOS V, " &
                         "MODEQUIP ME, " &
                         "GRUEQUIP GR " &
                   "WHERE O.NUMERO = OP.NUMERO " &
                   "AND O.CLIENTE = C.CODIGO " &
                   "AND V.CODIGO  = O.CABEZOTE " &
                   "AND ME.CODIGO = V.MODELO " &
                   "AND GR.CODIGO = ME.GRUPO " &
                   "AND O.STATUS IN ('A') " &
                   "AND O.TARA > 0 " &
                   "AND O.NUMERO IN (" + NumPesajeBioSalc.ToString() + ") "
        End If

        If (intIdxQuery = "N") Then
            query = "SELECT O.CLIENTE AS CodCliente," &
                    "C.NOME AS Cliente," &
                    "O.STATUS AS Estado," &
                    "O.ALMOXAGR AS CodBodega," &
                    "ISNULL((SELECT a.NOME FROM ALMOXAGR a " &
                             "WHERE a.CODIGO = O.ALMOXAGR),'') AS Bodega," &
                    "O.OBSERV   AS BodegaDestino," &
                   "O.FH_SAI   AS FechaSalida," &
                   "O.HORA_SAI AS HoraSalida," &
                   "O.TRANSACAO AS MotivoRemision, " &
                   "O.TRANSP AS TransportistaID," &
                   "O.CHOFER AS ConductorID," &
                   "O.CABEZOTE AS VehiculoID," &
                   "ME.GRUPO AS MarcaID, " &
                   "GR.NOME  AS MarcaVehiculo," &
                   "ISNULL(V.PLACA,'')  AS Placa, " &
                   "ISNULL(O.SELLO_I,0) AS SelloInicial, " &
                   "ISNULL(O.SELLO_F,0) AS SelloFinal," &
                   " (CAST(ISNULL(O.SELLO_I,0) AS NVARCHAR)+' AL '+CAST(ISNULL(O.SELLO_F,0) AS NVARCHAR)) AS RangoSelloCamion," &
                   "O.OBSERV2 AS SellosJumbosOtros," &
                   "OP.PROD AS CodProducto,		 " &
                   "OP.CANTIDAD AS Cantidad," &
                   "OP.UM AS UnidadMedidaID," &
                   "O.PESO_BRUTO AS PesoBrutoLbs," &
                   "O.TARA AS PesoTaraLbs," &
                   "O.PESO_NETO AS PesoNetoLbs," &
                   "(O.PESO_NETO  * (SELECT FATOR FROM CONV_UM WHERE CODIGO IN ('LBS_KG'))) AS PesoNetoKG," &
                   "((O.PESO_NETO * (SELECT FATOR FROM CONV_UM WHERE CODIGO IN ('LBS_KG')))/50) AS Sacos50KG,   " &
                   "O.NUMERO AS NumOrden," &
                   "O.DOC_INTERNO AS DocInterno1, " &
                   "ISNULL(O.DOC_INTERNO2,'') AS DocInterno2," &
                   "ISNULL(O.REMOLQUE,'') AS CodRemolque," &
                   "ISNULL(O.REMOLQUE2,'') AS PlacaRemolque," &
                   "OP.EMPAQUE AS CodEmpaque " &
                   "FROM OPROD_MOV O, " &
                         "OPROD_MOV_PROD OP, " &
                         "CLIENTE C, " &
                         "VEICULOS V, " &
                         "MODEQUIP ME, " &
                         "GRUEQUIP GR " &
                   "WHERE O.NUMERO = OP.NUMERO " &
                   "AND O.CLIENTE = C.CODIGO " &
                   "AND V.CODIGO  = O.CABEZOTE " &
                   "AND ME.CODIGO = V.MODELO " &
                   "AND GR.CODIGO = ME.GRUPO " &
                   "AND O.STATUS IN ('A') " &
                   "AND O.PESO_NETO > 0 " &
                   "AND O.NUMERO IN (" + NumPesajeBioSalc.ToString() + ") "
        End If

        da = New SqlDataAdapter(query, cnx)
        'da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(ds, "datos")
        da.Dispose()
        cnx.Dispose()
        Return ds.Tables(0)
    End Function

    Public Function GuardarModificarOrdenPesoBioSalc_TARA(strUsuario As String, strPasswd As String,
                                                     intBandera As Boolean, CodEmpaque As String,
                                                     CodProducto As String, CodUM As String,
                                                     Ticket As Integer) As String
        Dim ds As New DataSet()
        Dim Mensaje As String = ""
        'cnx = conexion.conectarAmigoDbBioSalcPrueba(strUsuario, strPasswd)
        cnx = conexion.conectarAmigoDbBioSalc(strUsuario, strPasswd)

        If (intBandera = True) Then
            query = "UPDATE OPROD_MOV_PROD " &
                    "SET PESO_TEO = (SELECT EMPAQUE.PESO_EMB + EMPAQUE.PESO " &
                                    "FROM EMPAQUE " &
                                    "WHERE EMPAQUE.COD_EMPAQUE = '" & CodEmpaque & "' ) * CANTIDAD, " &
                        "EMPAQUE = '" & CodEmpaque & "', " &
                        "PROD    = '" & CodProducto & "' " &
                    "WHERE NUMERO = " & Ticket & " "

            Mensaje = "+Datos modificados satisfactoriamente"
        Else
            Mensaje = "+Datos insertados satisfactoriamente"
        End If
        cmd = New SqlCommand(query, cnx)
        cnx.Open()
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Mensaje = "-Error al guardar o modificar informacion del objeto OPROD_MOV_PROD en BioSalc. Favor verifique"
        Finally
            cnx.Close()
        End Try

        Return Mensaje
    End Function
End Class
