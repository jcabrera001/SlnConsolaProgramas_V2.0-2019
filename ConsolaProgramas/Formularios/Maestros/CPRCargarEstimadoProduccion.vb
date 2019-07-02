Imports LibDAO001
Public Class CPRCargarEstimadoProduccion
    Public apr As ClsAPR = New ClsAPR()
    Public EntiAPR As ClsEntiAPR.CPR_Grupos = New ClsEntiAPR.CPR_Grupos()
    Public strUsuario, strPassword, strSitio, strFinca, strArea, strLoteID, strFecha, strHora, strMensaje, strIdxMensaje, FechaHoy As String
    Public flagGuardarModificar, contadorV, EstimadoGrupoID, DetalleProgramaID, banderaDesaprobar As Integer
    Public ds As DataSet = Nothing

    Public Sub FuncionInicial(strU As String, strP As String)
        flagGuardarModificar = True
        strUsuario = strU
        strPassword = strP
    End Sub

    Private Sub cmbSalir_Click(sender As Object, e As EventArgs) Handles cmbSalir.Click
        Close()
    End Sub

    Private Sub CPRCargarEstimadoProduccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class