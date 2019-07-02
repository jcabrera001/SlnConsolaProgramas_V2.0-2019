Imports LibDAO001
Imports System.Data.SqlClient
Public Class CoFRemMasFrm
    Public ClsU As New ClsUtilitarios

    Public strUsuario As String
    Public strPassword As String
    Public strEmpresa As String

    Public Sub FuncionInicial(strU As String, strP As String, strE As String)
        strUsuario = strU
        strPassword = strP
        strEmpresa = strE

        Me.TxtEmpresa.EditValue = strEmpresa
        Me.TxtFechaGenerar.EditValue = Now
    End Sub

    Private Sub CmdGenerar_Click(sender As Object, e As EventArgs) Handles CmdGenerar.Click
        Dim cEmpresa, cPuntoPartida As String
        Dim cFechaInicio, cFechaFinal As Date
        Dim cCantidad As Integer

        Dim oConexion As New ClsConexion
        oConexion.conectarAmigoDbFinanzas(strUsuario, strPassword)

        Dim oParam1, oParam2 As New SqlParameter
        Dim oComando As New SqlCommand("_IDFGenGr")

        cEmpresa = Me.TxtEmpresa.EditValue
        cPuntoPartida = Me.TxtPuntoPartida.EditValue
        cFecha = Me.TxtFechaGenerar.EditValue.ToString.Substring(1, 10)

        Try

            oComando.Connection = oConexion.Abrir()
            oComando.CommandType = CommandType.StoredProcedure

            oComando.Parameters.Add("@Empresa", SqlDbType.VarChar, 2).Value = cEmpresa
            oComando.Parameters.Add("@PuntoPartida", SqlDbType.VarChar, 60).Value = cEmpresa
            oComando.Parameters.Add("@FechaInicio", SqlDbType.SmallDateTime).Value = cFecha
            oComando.Parameters.Add("@FechaFinal", SqlDbType.SmallDateTime).Value = cFecha
            oComando.Parameters.Add("@Cantidad", SqlDbType.Int).Value = cFecha

            Dim oReader As SqlDataReader = oComando.ExecuteReader
            Try
                While oReader.Read
                    MsgBox(oReader(0))
                End While
            Finally
                oReader.Close()
            End Try

        Catch ex As Exception
            ClsU.Nota("Error al abrir la base de datos")
            Exit Sub
        End Try
    End Sub
End Class