Imports LibDAO001
Public Class AprGenerarOdtQuema

    Public apr As ClsAPR = New ClsAPR()
    Public EntiAPR As ClsEntiAPR.ClsAprGenerarOdtQuema = New ClsEntiAPR.ClsAprGenerarOdtQuema()
    Public strUsuario, strPassword, strSitio, strFinca, strArea, strLoteID, strFecha, strHora, strMensaje, strIdxMensaje, FechaHoy As String
    Public idxPeriodo, flagTipoCaña, flagAccidental, flagDoble, intPeriodoId, FrenteID, flagCargar As Integer
    Public flagGuardarModificar As Boolean

    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
    End Sub

    Public Sub FuncionInicial(strU As String, strP As String)
        strUsuario = strU
        strPassword = strP
    End Sub
    Private Sub AprGenerarOdtQuema_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatos(2)
        If flagGuardarModificar Then
            cmbGuardar.Text = "Modificar"
            CargarDatos(5)
            LlenarCampos()
        Else
            CargarDatos(1)
            cmbGuardar.Text = "Guardar"
        End If
        lblUsuario.Text = strUsuario
        InicializarValores()
    End Sub

    Sub LlenarCampos()
        cbxPeriodo.Enabled = False
        cbxFinca.Enabled = False
        cbxLote.Enabled = False
        cbxPeriodo.SelectedValue = intPeriodoId
        txtNoOrden.Text = EntiAPR.QuemaID.ToString()
        cbxFinca.Properties.NullText = strFinca
        cbxLote.Properties.NullText = EntiAPR.LoteID
        txtFecha.Text = strFecha
        txtHora.Text = strHora
        If flagAccidental = 1 Then
            chkAccidental.Checked = True
        Else
            chkAccidental.Checked = False
        End If
        If flagTipoCaña = 1 Then
            chkTipoCaña.Checked = True
        Else
            chkTipoCaña.Checked = False
        End If
        If flagDoble = 1 Then
            chkDoble.Checked = True
        Else
            chkDoble.Checked = False
        End If

        'Indicadores de Rendimiento - Torre de Control
        txtHoraOrden.Text = EntiAPR.horaOrden
        txtHrsBascula.Text = EntiAPR.horaBascula
        txtHrsIArrastre.Text = EntiAPR.horaInicioArrastre
        txtHrsFArrastre.Text = EntiAPR.horaFinalArrastre
        txtCorteEstiTons.Text = EntiAPR.corteEstimadoTons.ToString()
        txtCorteEjecTons.Text = EntiAPR.corteEjecutadoTons.ToString()
        txtHrsPreBatey.Text = EntiAPR.horaHoraPreBatey
        txtAreaEstimada.Text = EntiAPR.areaEstimada.ToString()
        txtAreaEjecutada.Text = EntiAPR.areaEjecutado.ToString()
        '---------------------------------------------

    End Sub

    Sub InicializarValores()
        FechaHoy = Format(Date.Now, "dd/MM/yyyy HH:mm:ss")
        If flagGuardarModificar = False Then
            txtHoraOrden.Text = FechaHoy
            txtHrsBascula.Text = FechaHoy
            txtHrsIArrastre.Text = FechaHoy
            txtHrsFArrastre.Text = FechaHoy
            txtHrsPreBatey.Text = FechaHoy
            txtFecha.Text = Date.Now.ToShortDateString()
            txtHora.Text = Date.Now.ToShortTimeString()
        End If
    End Sub

    Public Sub CargarDatos(tipo As Integer)
        Dim ds As DataSet
        If tipo = 1 Then 'Obtener Periodos
            ds = apr.ObtenerPeriodo(strUsuario, strPassword, 1)
            cbxPeriodo.DataSource = ds.Tables(0)
            cbxPeriodo.DisplayMember = "titulo"
            cbxPeriodo.ValueMember = "sitio"
        End If
        If tipo = 2 Then 'Obtener Frentes
            ds = apr.ObtenerFrentes(strUsuario, strPassword, 1, 0, 0)
            cbxFrente.Properties.DataSource = ds.Tables(0)
            cbxFrente.Properties.ValueMember = ds.Tables(0).Columns(0).ToString()
            cbxFrente.Properties.DisplayMember = ds.Tables(0).Columns(1).ToString()
        End If
        If tipo = 3 Then 'Obtener Fincas
            ds = apr.ObtenerFinca(strUsuario, strPassword, 1, strSitio)
            cbxFinca.Properties.DataSource = ds.Tables(0)
            cbxFinca.Properties.ValueMember = ds.Tables(0).Columns(0).ToString()
            cbxFinca.Properties.DisplayMember = ds.Tables(0).Columns(1).ToString()
        End If
        If tipo = 4 Then 'Obtener Lotes
            ds = apr.ObtenerLotes(strUsuario, strPassword, 1, strFinca)
            cbxLote.Properties.DataSource = ds.Tables(0)
            cbxLote.Properties.ValueMember = ds.Tables(0).Columns(1).ToString()
            cbxLote.Properties.DisplayMember = ds.Tables(0).Columns(0).ToString()
        End If
        If tipo = 5 Then 'Obtener Periodos
            ds = apr.ObtenerPeriodo(strUsuario, strPassword, 2)
            cbxPeriodo.DataSource = ds.Tables(0)
            cbxPeriodo.DisplayMember = "titulo"
            cbxPeriodo.ValueMember = "sitio"
        End If
    End Sub

    Private Sub cmbSalir_Click(sender As Object, e As EventArgs) Handles cmbSalir.Click
        Me.Close()
    End Sub

    ' Assumes that the class implements IDisposable
    Public Sub xDispose() 'Implements IDisposable.Dispose
        'myWidget.Dispose()
        'myWidget = Nothing
        ' Insert additional code.
        cbxPeriodo.Dispose()
        'cbxPeriodo = Nothing
        cbxFrente.Dispose()
        'cbxFrente = Nothing
        cbxFinca.Dispose()
        'cbxFinca = Nothing
        cbxLote.Dispose()
        'cbxLote = Nothing
        txtArea.Dispose()
        'txtArea = Nothing
        txtFecha.Dispose()
        'txtFecha = Nothing
        txtHora.Dispose()
        'txtHora = Nothing
        txtNoOrden.Dispose()
        'txtNoOrden = Nothing
        chkDoble.Dispose()
        'chkDoble = Nothing
        chkAccidental.Dispose()
        'chkAccidental = Nothing
        chkTipoCaña.Dispose()
        'chkTipoCaña = Nothing
    End Sub

    Private Sub cbxPeriodo_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbxPeriodo.SelectedValueChanged
        Try
            strSitio = cbxPeriodo.SelectedValue.ToString()
            If (strSitio.Equals("System.Data.DataRowView") = False) Then
                Dim TestArray() As String = Split(strSitio)
                intPeriodoId = CInt(TestArray(0))
                strSitio = TestArray(1)
                CargarDatos(3)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbxFinca_EditValueChanged(sender As Object, e As EventArgs) Handles cbxFinca.EditValueChanged
        strFinca = cbxFinca.EditValue.ToString()
        CargarDatos(4)
    End Sub

    Private Sub cbxLote_EditValueChanged(sender As Object, e As EventArgs) Handles cbxLote.EditValueChanged
        If flagGuardarModificar = False Then
            strArea = cbxLote.EditValue.ToString()
            txtArea.Text = strArea

            Dim edit As DevExpress.XtraEditors.GridLookUpEdit = CType(sender, DevExpress.XtraEditors.GridLookUpEdit)
            Dim row As DataRow = edit.Properties.View.GetDataRow(edit.Properties.View.FocusedRowHandle)
            strLoteID = row(0).ToString()
        End If
    End Sub

    Private Sub cmbGuardar_Click(sender As Object, e As EventArgs) Handles cmbGuardar.Click
        Try
            Dim validacion As String = VerificarCampos()
        If validacion.Equals("C") Then
            GuardarModificarDatos()
        Else
            MsgBox(validacion, MsgBoxStyle.Critical, "Error:")
        End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error:")
        End Try
    End Sub

    Sub GuardarModificarDatos()
        If flagGuardarModificar = False Then
            EntiAPR.PeriodoID = intPeriodoId
            EntiAPR.FincaID = strFinca
            EntiAPR.LoteID = strLoteID
            EntiAPR.QuemaID = apr.ObtenerMaximoQuemaID(strUsuario, strPassword)
        End If

        EntiAPR.Fecha = apr.ArmarFecha(1, txtFecha.Text)

        EntiAPR.Accidental = flagAccidental
        EntiAPR.Cruda = flagTipoCaña
        EntiAPR.Doble = flagDoble
        EntiAPR.Area = 0
        EntiAPR.CorteFrenteID = FrenteID

        'Tab Indicadores de Rendimiento------------------------
        EntiAPR.horaOrden = apr.ArmarFecha(1, txtHoraOrden.Text)
        EntiAPR.horaBascula = apr.ArmarFecha(1, txtHrsBascula.Text)
        EntiAPR.horaInicioArrastre = apr.ArmarFecha(1, txtHrsIArrastre.Text)
        EntiAPR.horaFinalArrastre = apr.ArmarFecha(1, txtHrsFArrastre.Text)
        EntiAPR.horaHoraPreBatey = apr.ArmarFecha(1, txtHrsPreBatey.Text)

        EntiAPR.corteEstimadoTons = Convert.ToDecimal(txtCorteEstiTons.Text)
        EntiAPR.corteEjecutadoTons = Convert.ToDecimal(txtCorteEjecTons.Text)
        EntiAPR.areaEstimada = Convert.ToDecimal(txtAreaEstimada.Text)
        EntiAPR.areaEjecutado = Convert.ToDecimal(txtAreaEjecutada.Text)
        '------------------------------------------------------
        If (EntiAPR.QuemaID > 0) Then
            strMensaje = apr.GuardarModificarOrdenCorte(strUsuario, strPassword, flagGuardarModificar, EntiAPR)
            strIdxMensaje = strMensaje.Substring(0, 1)
            strMensaje = strMensaje.Replace(strIdxMensaje, "")
            If (strIdxMensaje.Equals("+")) Then
                MsgBox(strMensaje, MsgBoxStyle.Information, "Sistema:")
            Else
                MsgBox(strMensaje, MsgBoxStyle.Critical, "Error:")
            End If
        Else
            MsgBox("Error al seleccionar el maximo valor de QuemaID de la tabla Quema... Favor verifique!", MsgBoxStyle.Critical, "Error:")
        End If
    End Sub

    Function VerificarCampos() As String
        Dim resultado As String
        If flagGuardarModificar = False Then
            If String.IsNullOrEmpty(cbxFrente.EditValue.ToString) Then
                resultado = "Error al seleccionar el campo Frente. Favor, intente de nuevo"
            ElseIf String.IsNullOrEmpty(cbxFinca.EditValue.ToString) Then
                resultado = "Error al seleccionar el campo Finca. Favor, intente de nuevo"
            ElseIf String.IsNullOrEmpty(cbxLote.EditValue.ToString) Then
                resultado = "Error al seleccionar el campo Lote. Favor, intente de nuevo"
            ElseIf Convert.ToDecimal(txtCorteEstiTons.Text) = 0 Then
                resultado = "Error al ingresar el campo Corte Estimado Toneladas. No se permite valores en cero"
            ElseIf Convert.ToDecimal(txtCorteEjecTons.Text) = 0 Then
                resultado = "Error al ingresar el campo Corte Ejecutado Toneladas. No se permite valores en cero"
            ElseIf Convert.ToDecimal(txtAreaEstimada.Text) = 0 Then
                resultado = "Error al ingresar el campo Area Estimada. No se permite valores en cero"
            ElseIf Convert.ToDecimal(txtAreaEjecutada.Text) = 0 Then
                resultado = "Error al ingresar el campo Area Ejecutada. No se permite valores en cero"
            Else
                resultado = "C"
            End If
        Else
            If String.IsNullOrEmpty(cbxFrente.EditValue.ToString) Then
                resultado = "Error al seleccionar el campo Frente. Favor, intente de nuevo"
            ElseIf Convert.ToDecimal(txtCorteEstiTons.Text) = 0 Then
                resultado = "Error al ingresar el campo Corte Estimado Toneladas. No se permite valores en cero"
            ElseIf Convert.ToDecimal(txtCorteEjecTons.Text) = 0 Then
                resultado = "Error al ingresar el campo Corte Ejecutado Toneladas. No se permite valores en cero"
            ElseIf Convert.ToDecimal(txtAreaEstimada.Text) = 0 Then
                resultado = "Error al ingresar el campo Area Estimada. No se permite valores en cero"
            ElseIf Convert.ToDecimal(txtAreaEjecutada.Text) = 0 Then
                resultado = "Error al ingresar el campo Area Ejecutada. No se permite valores en cero"
            ElseIf String.IsNullOrEmpty(txtFecha.Text) Then
                resultado = "Error al ingresar el campo Fecha de Corte. No se permite valores vacios o nulos."
            ElseIf String.IsNullOrEmpty(txtHrsBascula.Text) Then
                resultado = "Error al ingresar el campo Fecha/Hora Bascula. No se permite valores vacios o nulos."
            ElseIf String.IsNullOrEmpty(txtHrsIArrastre.Text) Then
                resultado = "Error al ingresar el campo Fecha/Hora Inicio de Arrastre. No se permite valores vacios o nulos."
            ElseIf String.IsNullOrEmpty(txtHrsFArrastre.Text) Then
                resultado = "Error al ingresar el campo Fecha/Hora Final de Arrastre. No se permite valores vacios o nulos."
            ElseIf String.IsNullOrEmpty(txtHrsPreBatey.Text) Then
                resultado = "Error al ingresar el campo Fecha/Hora Prebatey. No se permite valores vacios o nulos."
            Else
                resultado = "C"
            End If
        End If
        Return resultado
    End Function

    Private Sub chkTipoCaña_CheckedChanged(sender As Object, e As EventArgs) Handles chkTipoCaña.CheckedChanged
        If chkTipoCaña.Checked Then
            flagTipoCaña = 1 'Caña Cruda
        Else
            flagTipoCaña = 0 'Caña Quemada
        End If
    End Sub

    Private Sub chkAccidental_CheckedChanged(sender As Object, e As EventArgs) Handles chkAccidental.CheckedChanged
        If chkAccidental.Checked Then
            flagAccidental = 1 'Si
        Else
            flagAccidental = 0 'No
        End If
    End Sub

    Private Sub chkDoble_CheckedChanged(sender As Object, e As EventArgs) Handles chkDoble.CheckedChanged
        If chkDoble.Checked Then
            flagDoble = 1 'Si
        Else
            flagDoble = 0 'No
        End If
    End Sub

    Private Sub cbxFrente_EditValueChanged(sender As Object, e As EventArgs) Handles cbxFrente.EditValueChanged
        Try
            FrenteID = CInt(cbxFrente.EditValue.ToString())
        Catch ex As Exception

        End Try
    End Sub

    Private Sub XtraTabControl1_Click(sender As Object, e As EventArgs) Handles XtraTabControl1.Click
        Dim idx As Integer = XtraTabControl1.SelectedTabPageIndex
        'If idx = 1 Then
        '    'Dim xfecha As String = DateTime.Now.ToShortDateString()
        '    'Dim xhora As String = DateTime.Now.ToShortTimeString()
        '    'txtHoraOrden.Text = xfecha & " " & xhora
        '    txtHoraOrden.Text = Format(Date.Now, "dd/MM/yyyy HH:mm:ss")
        'End If
    End Sub

    Private Sub txtHrsBascula_Properties_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtHrsBascula.Properties.Validating
        'If String.IsNullOrEmpty(txtHrsBascula.Text) Then
        txtHrsBascula.Properties.NullText = FechaHoy
        txtHrsBascula.Properties.NullValuePrompt = FechaHoy
        'Else
        '    txtHrsBascula.Text = FechaHoy
        'End If
    End Sub

    Private Sub txtHrsIArrastre_Properties_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtHrsIArrastre.Properties.Validating
        txtHrsIArrastre.Properties.NullText = FechaHoy
        txtHrsIArrastre.Properties.NullValuePrompt = FechaHoy
    End Sub

    Private Sub txtHrsFArrastre_Properties_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtHrsFArrastre.Properties.Validating
        txtHrsFArrastre.Properties.NullText = FechaHoy
        txtHrsFArrastre.Properties.NullValuePrompt = FechaHoy
    End Sub

    Private Sub txtHrsPreBatey_Properties_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtHrsPreBatey.Properties.Validating
        txtHrsPreBatey.Properties.NullText = FechaHoy
        txtHrsPreBatey.Properties.NullValuePrompt = FechaHoy
    End Sub

    Private Sub txtFecha_Properties_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtFecha.Properties.Validating
        txtFecha.Properties.NullText = FechaHoy
        txtFecha.Properties.NullValuePrompt = FechaHoy
    End Sub


End Class