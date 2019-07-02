Imports LibDAO001
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class FinXtraBuscarFacCompras
    Public strUsuario, strPassword, StrEmpresa, SocioNegocioID As String
    Public IntTipoDocto As Integer

    Public ClsConexion As New ClsConexion
    Public ClsU As New ClsUtilitarios
    
    Public ClsAccesos As ClsVistas = Nothing
    Public dtOpciones, dtConfigxEmpresa, dtIDF_ConfigEmp002, dtCxE_Nuevo, dtBuscarFacCompras As DataTable
    Public contador, OpcionConsultar, OpcionModificar As Integer
    Public CAIXSdNID, RetencionID, FactCompID As Integer
    Public xCAI, xFecha, xCorrelativo As String
    Public msgResultado As MsgBoxResult = New MsgBoxResult()
    Public DialogoResult As DialogResult = New DialogResult()

    Public Sub FuncionInicial(strU As String, strP As String, StrE As String, IntT As Integer,
                             PerfilID As Integer, PrgID As Integer, FormID As Integer, SdN As String)
        strUsuario = strU
        strPassword = strP
        StrEmpresa = StrE
        IntTipoDocto = IntT
        SocioNegocioID = SdN
    End Sub

    Private Sub FinXtraBuscarFacCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Pendiente agregar formulario de busqueda
            contador = 2
            ClsAccesos = New ClsVistas()
            dtBuscarFacCompras = ClsAccesos.RetencionesBuscarFacturas(strUsuario, strPassword, 2,
                                                                      CInt(StrEmpresa), IntTipoDocto, "",
                                                                      SocioNegocioID)
            GrdConsulta.DataSource = dtBuscarFacCompras
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GrdConsulta_DoubleClick(sender As Object, e As EventArgs) Handles GrdConsulta.DoubleClick
        Try
            CAIXSdNID = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "CAIXSdNID")
            xCorrelativo = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "Correlativo")
            xCAI = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "CAI")
            xFecha = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "Fecha")
            RetencionID = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "RetencionID")
            FactCompID = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "FactCompID")
            contador = 1
            Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FinXtraBuscarFacCompras_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If contador = 1 Then
            contador = contador * 1
        Else
            contador = -1
        End If
    End Sub
End Class