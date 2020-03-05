Imports LibDAO001
Imports System.Data.SqlClient
Public Class CoFInteresesCanerosFrm
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
        Dim cEmpresa As String
        Dim cFecha As Date

        Dim oConexion As New ClsConexion
        oConexion.conectarAmigoDbFinanzas(strUsuario, strPassword)

        Dim oParam1, oParam2 As New SqlParameter
        Dim oComando As New SqlCommand("_spIntereses")

        cEmpresa = Me.TxtEmpresa.EditValue
        cFecha = Me.TxtFechaGenerar.EditValue.ToString.Substring(1, 10)

        Try

            oComando.Connection = oConexion.Abrir()
            oComando.CommandType = CommandType.StoredProcedure

            oComando.Parameters.Add("@Empresa", SqlDbType.VarChar, 2).Value = cEmpresa
            oComando.Parameters.Add("@Fecha", SqlDbType.SmallDateTime).Value = cFecha

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

    'Private Sub PerformLayout()
    '    Throw New NotImplementedException
    'End Sub

End Class