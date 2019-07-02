Imports LibDAO001
Public Class AprOrdenQuemaFrm

    Public apr As ClsAPR = New ClsAPR()
    Public strUsuario, strPassword, temp As String
    Public idxPeriodo As Integer
    Public flag As Boolean
    Public xflagNull? As Boolean

    Public Sub FuncionInicial(strU As String, strP As String)
        strUsuario = strU
        strPassword = strP
    End Sub

    Private Sub AprOrdenQuemaFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarComboPeriodos()
    End Sub

    Public Sub CargarComboPeriodos()
        Dim ds As DataSet
        ds = apr.ObtenerDatos(strUsuario, strPassword, 1, 0)
        cbxPeriodo.DataSource = ds.Tables(0)
        cbxPeriodo.DisplayMember = "titulo"
        cbxPeriodo.ValueMember = "periodoid"
    End Sub

    Private Sub cbxPeriodo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxPeriodo.SelectedIndexChanged

        Try
            idxPeriodo = CInt(cbxPeriodo.SelectedValue.ToString())
            'Cargar gridView
            CargarDatosxPeriodo()
        Catch ex As Exception

        End Try
    End Sub

    Sub CargarDatosxPeriodo()
        Dim dsDatos As DataSet = New DataSet()
        dsDatos = apr.ObtenerDatos(strUsuario, strPassword, 2, idxPeriodo)
        gcOrdenQuema.DataSource = dsDatos.Tables(0)
    End Sub

    Private Sub cmbNuevo_Click(sender As Object, e As EventArgs) Handles cmbNuevo.Click
        Dim GenerarOdtCorte As AprGenerarOdtQuema = New AprGenerarOdtQuema()
        GenerarOdtCorte.FuncionInicial(strUsuario, strPassword)
        GenerarOdtCorte.flagGuardarModificar = False
        GenerarOdtCorte.ShowDialog()
    End Sub

    Private Sub cmbCancelar_Click(sender As Object, e As EventArgs) Handles cmbCancelar.Click
        Close()
    End Sub

    Private Sub cmbModificar_Click(sender As Object, e As EventArgs) Handles cmbModificar.Click
        Try
            Dim GenerarOdtCorte As AprGenerarOdtQuema = New AprGenerarOdtQuema()
            GenerarOdtCorte.FuncionInicial(strUsuario, strPassword)
            GenerarOdtCorte.flagGuardarModificar = True
            GenerarOdtCorte.EntiAPR.QuemaID = CInt(dgvDatos.GetRowCellValue(dgvDatos.FocusedRowHandle, gcolOrdenCorte).ToString())
            GenerarOdtCorte.EntiAPR.PeriodoID = CInt(dgvDatos.GetRowCellValue(dgvDatos.FocusedRowHandle, gcolPeriodoid).ToString())
            GenerarOdtCorte.EntiAPR.FincaID = dgvDatos.GetRowCellValue(dgvDatos.FocusedRowHandle, gcolCodigo).ToString()
            GenerarOdtCorte.strFinca = "[" + dgvDatos.GetRowCellValue(dgvDatos.FocusedRowHandle, gcolCodigo).ToString() + "] " & _
                                             dgvDatos.GetRowCellValue(dgvDatos.FocusedRowHandle, gcolNombre).ToString()
            GenerarOdtCorte.EntiAPR.LoteID = dgvDatos.GetRowCellValue(dgvDatos.FocusedRowHandle, gcolLote).ToString()
            GenerarOdtCorte.EntiAPR.Fecha = dgvDatos.GetRowCellValue(dgvDatos.FocusedRowHandle, gcolFecha).ToString()
            GenerarOdtCorte.strHora = dgvDatos.GetRowCellValue(dgvDatos.FocusedRowHandle, gcolHora).ToString()
            flag = Convert.ToBoolean(dgvDatos.GetRowCellValue(dgvDatos.FocusedRowHandle, gcolAccidental))
            If (flag) Then
                GenerarOdtCorte.flagAccidental = 1
            Else
                GenerarOdtCorte.flagAccidental = 0
            End If
            flag = Convert.ToBoolean(dgvDatos.GetRowCellValue(dgvDatos.FocusedRowHandle, gcolCruda))
            If flag Then
                GenerarOdtCorte.flagTipoCaña = 1
            Else
                GenerarOdtCorte.flagTipoCaña = 0
            End If
            temp = dgvDatos.GetRowCellValue(dgvDatos.FocusedRowHandle, gcolDoble).ToString()
            If String.IsNullOrEmpty(temp) Then
                flag = False
            Else
                flag = True
            End If
            If flag Then
                GenerarOdtCorte.flagDoble = 1
            Else
                GenerarOdtCorte.flagDoble = 0
            End If

            'Indicadores de Rendimiento
            GenerarOdtCorte.EntiAPR.horaOrden = dgvDatos.GetRowCellValue(dgvDatos.FocusedRowHandle, gcolhoraOrden).ToString()
            GenerarOdtCorte.EntiAPR.horaBascula = dgvDatos.GetRowCellValue(dgvDatos.FocusedRowHandle, gcolhoraBascula).ToString()
            GenerarOdtCorte.EntiAPR.horaInicioArrastre = dgvDatos.GetRowCellValue(dgvDatos.FocusedRowHandle, gcolhoraInicioArrastre).ToString()
            GenerarOdtCorte.EntiAPR.horaFinalArrastre = dgvDatos.GetRowCellValue(dgvDatos.FocusedRowHandle, gcolhoraFinalArrastre).ToString()
            GenerarOdtCorte.EntiAPR.corteEstimadoTons = Convert.ToDecimal(dgvDatos.GetRowCellValue(dgvDatos.FocusedRowHandle, gcolcorteEstimadoTons).ToString())
            GenerarOdtCorte.EntiAPR.corteEjecutadoTons = Convert.ToDecimal(dgvDatos.GetRowCellValue(dgvDatos.FocusedRowHandle, gcolcorteEjecutadoTons).ToString())
            GenerarOdtCorte.EntiAPR.horaHoraPreBatey = dgvDatos.GetRowCellValue(dgvDatos.FocusedRowHandle, gcolhoraPrebatey).ToString()
            GenerarOdtCorte.EntiAPR.areaEstimada = Convert.ToDecimal(dgvDatos.GetRowCellValue(dgvDatos.FocusedRowHandle, gcolareaEstimada).ToString())
            GenerarOdtCorte.EntiAPR.areaEjecutado = Convert.ToDecimal(dgvDatos.GetRowCellValue(dgvDatos.FocusedRowHandle, gcolareaEjecutada).ToString())
            '--------------------------------------------------

            GenerarOdtCorte.ShowDialog()

            'Actualizar/cargar registros del GridControl obteniendo los datos mas recientes
            idxPeriodo = GenerarOdtCorte.EntiAPR.PeriodoID
            CargarDatosxPeriodo()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error:")
        End Try
    End Sub

    Private Sub dgvDatos_DoubleClick(sender As Object, e As EventArgs) Handles dgvDatos.DoubleClick
        Try
            cmbModificar_Click(sender, e)
        Catch ex As Exception

        End Try
    End Sub
End Class