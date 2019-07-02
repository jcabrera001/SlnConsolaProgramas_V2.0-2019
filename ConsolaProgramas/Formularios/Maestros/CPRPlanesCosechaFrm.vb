Imports LibDAO001
Public Class CPRPlanesCosechaFrm
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
    Private Sub CPRPlanesCosechaFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrupos()
        CargarEstimados()
    End Sub

    Sub CargarGrupos()
        ds = New DataSet()
        ds = apr.EventosPlanesCosecha(strUsuario, strPassword, 1, EntiAPR)
        gcDatos.DataSource = ds.Tables(0)
    End Sub

    Sub CargarEstimados()
        ds = New DataSet()
        ds = apr.ObtenerProgramas(strUsuario, strPassword, 1, 0, 2)
        cbxEstimados.Properties.DataSource = ds.Tables(0)
        cbxEstimados.Properties.ValueMember = ds.Tables(0).Columns(0).ToString()
        cbxEstimados.Properties.DisplayMember = ds.Tables(0).Columns(1).ToString()
    End Sub

    Private Sub dgvDatos_DoubleClick(sender As Object, e As EventArgs) Handles dgvDatos.DoubleClick

    End Sub

    Private Sub cmbGuardar_Click(sender As Object, e As EventArgs) Handles cmbGuardar.Click
        If flagGuardarModificar Then 'Registro nuevo

        End If
    End Sub
End Class