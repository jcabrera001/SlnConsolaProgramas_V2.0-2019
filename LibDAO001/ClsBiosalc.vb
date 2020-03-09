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
            query = "spRemisionBiosalcVT" ' & NumPesajeBioSalc.ToString() & "'"
        ElseIf (intIdxQuery = "T") Then
            query = "spRemisionBiosalcT" ' & NumPesajeBioSalc.ToString() & "'"
        ElseIf (intIdxQuery = "N") Then
            query = "spRemisionBiosalcN" ' & NumPesajeBioSalc.ToString() & "'"
        End If

        da = New SqlDataAdapter(query, cnx)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.Parameters.AddWithValue("@num", NumPesajeBioSalc.ToString())

        cnx.Open()
        Dim cmd As New SqlCommand(query, cnx)
        cnx.Close()


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
