Imports LibDAO001
Public Class CPRProgramacionCosecha
    Public apr As ClsAPR = New ClsAPR()
    Public EntiAPR As ClsEntiAPR.ClsAprGenerarOdtQuema = New ClsEntiAPR.ClsAprGenerarOdtQuema()
    Public strUsuario, strPassword, strSitio, strFinca, strArea, strLoteID, strFecha, strHora, strMensaje, strIdxMensaje, FechaHoy As String
    Public idxPeriodo, flagTipoCaña, flagAccidental, flagDoble, intPeriodoId, FrenteID, flagCargar As Integer
    Public ProgramaID, TipoProgramaID, EstadoProgramaID, TipoPeriodoID, empresaid, ResultadoID As Integer
    Public ZafraID, concatenarDetPrgID, MensajeError, mensajes As String
    Public flagGuardarModificar, contadorV, EstimadoGrupoID, DetalleProgramaID, banderaDesaprobar As Integer
    Public ds As DataSet = Nothing
    Public Sub FuncionInicial(strU As String, strP As String, empresa As Integer)
        strUsuario = strU
        strPassword = strP
        empresaid = empresa
    End Sub
    Private Sub cmbSalir_Click(sender As Object, e As EventArgs) Handles cmbSalir.Click
        Close()
    End Sub

    Private Sub txtFecha_Properties_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtFecha.Properties.Validating, txtFechaEDesde.Properties.Validating
        txtFecha.Properties.NullText = FechaHoy
        txtFecha.Properties.NullValuePrompt = FechaHoy
    End Sub

    Private Sub CPRProgramacionCosecha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        flagGuardarModificar = -1
        ResultadoID = -1
        CargarProgramas()
        CargarCategorias()
        InicializarValores()
    End Sub

    Sub InicializarValores()
        FechaHoy = Format(Date.Now, "dd/MM/yyyy")
        'If flagGuardarModificar = False Then
        txtFechaEDesde.Text = Date.Now.ToShortDateString()
        'End If
    End Sub

    Sub CargarCategorias()
        ds = New DataSet()
        ds = apr.ObtenerCategoriasResultados(strUsuario, strPassword, 1)
        cbxCategoria.Properties.DataSource = ds.Tables(0)
        cbxCategoria.Properties.ValueMember = ds.Tables(0).Columns(0).ToString()
        cbxCategoria.Properties.DisplayMember = ds.Tables(0).Columns(1).ToString()
    End Sub

    Sub CargarProgramas()
        ds = New DataSet()
        ds = apr.ObtenerProgramas(strUsuario, strPassword, 1, 0, empresaid)
        cbxProgramas.Properties.DataSource = ds.Tables(0)
        cbxProgramas.Properties.ValueMember = ds.Tables(0).Columns(0).ToString()
        cbxProgramas.Properties.DisplayMember = ds.Tables(0).Columns(1).ToString()
    End Sub

    Private Sub cbxProgramas_EditValueChanged(sender As Object, e As EventArgs) Handles cbxProgramas.EditValueChanged
        Try
            Dim dsPrg As DataSet = New DataSet()
            ProgramaID = CInt(cbxProgramas.EditValue.ToString())
            txtProgramaID.Text = ProgramaID.ToString()
            txtDescripcion.Text = cbxProgramas.Text
            dsPrg = apr.ObtenerProgramas(strUsuario, strPassword, 2, ProgramaID, empresaid)
            txtTipoPrograma.Text = dsPrg.Tables(0).Rows(0)(1).ToString
            txtTipoPeriodo.Text = dsPrg.Tables(0).Rows(0)(5).ToString
            txtZafra.Text = dsPrg.Tables(0).Rows(0)(6).ToString '& "  " & dsPrg.Tables(0).Rows(0)(7).ToString
            txtUsuario.Text = dsPrg.Tables(0).Rows(0)(8).ToString
            txtFecha.Text = dsPrg.Tables(0).Rows(0)(7).ToString
            'Dim hasta As String
            'txtDesde.Text = dsPrg.Tables(0).Rows(0)(10).ToString
            'txtHasta.Text = dsPrg.Tables(0).Rows(0)(11).ToString
            txtDistanciaMeta.Text = dsPrg.Tables(0).Rows(0)(11).ToString

            cmbVerDetalle.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbVerDetalle_Click(sender As Object, e As EventArgs) Handles cmbVerDetalle.Click
        CargarDatosDetallexPrograma()
    End Sub

    Sub CargarDatosDetallexPrograma()
        Dim dsDatos As DataSet = New DataSet()
        dsDatos = apr.ObtenerDetalleProgramas(strUsuario, strPassword, 1, ProgramaID)
        flagCargar = dsDatos.Tables(0).Rows.Count
        'If flagCargar > 0 Then
        gcDatos.DataSource = dsDatos.Tables(0)
        cmbBuscarLotes.Enabled = True
        'Else
        '    cmbBuscarLotes.Enabled = False
        'End If
    End Sub

    Private Sub cmbBuscarLotes_Click(sender As Object, e As EventArgs) Handles cmbBuscarLotes.Click
        Dim BuscarLotes As CPRConsultaProgramas = New CPRConsultaProgramas()
        BuscarLotes.FuncionInicial(strUsuario, strPassword, empresaid, ProgramaID, cbxProgramas.Text)
        BuscarLotes.ShowDialog()
        If BuscarLotes.flagAutomatico = 1 Then
            cmbVerDetalle_Click(sender, e)
        End If
    End Sub

    Private Sub dgvDatos_DoubleClick(sender As Object, e As EventArgs) Handles dgvDatos.DoubleClick
        Try
            If dgvDatos.RowCount > 0 Then
                flagGuardarModificar = 1 'Cuando el usuario desee modificar una fila del gridView
                gbxModificacion.Enabled = True
                Dim EGID As String = dgvDatos.GetRowCellValue(dgvDatos.FocusedRowHandle, gcolEstimadoGrupoID).ToString
                EstimadoGrupoID = CInt(EGID)
                strLoteID = dgvDatos.GetRowCellValue(dgvDatos.FocusedRowHandle, gcolLoteID).ToString
                Dim DPID As String = dgvDatos.GetRowCellValue(dgvDatos.FocusedRowHandle, gcolDetalleProgramaID).ToString
                DetalleProgramaID = CInt(DPID)
            Else
                MsgBox("No existen datos para procesar esta accion. Favor, intente de nuevo. Si el problema, persiste, comuniquese de inmediato con el Departamento de Tecnologias de la Informacion", MsgBoxStyle.Critical, "Mensaje:")
            End If
        Catch ex As Exception
            'gbxModificacion.Enabled = False
            MsgBox("El sistema ha detectado la siguiente excepcion: " & ex.Message, MsgBoxStyle.Critical, "Mensaje:")
        End Try

    End Sub

    Private Sub cmbLimpiar_Click(sender As Object, e As EventArgs) Handles cmbLimpiar.Click
        LimpiarCampos()
    End Sub

    Sub LimpiarCampos()
        txtRendProLab.Text = "0.00"
        txtAreaCosecha.Text = "0.00"
        txtToneladasReales.Text = "0.00"
        gbxModificacion.Enabled = False
    End Sub

    Private Sub cmbMarcarTodos_Click(sender As Object, e As EventArgs) Handles cmbMarcarTodos.Click
        MarcarDesmarcarTodos(1)
    End Sub
    Private Sub cmbQuitarTodos_Click(sender As Object, e As EventArgs) Handles cmbQuitarTodos.Click
        MarcarDesmarcarTodos(2)
    End Sub
    Sub MarcarDesmarcarTodos(bandera As Integer)
        flagCargar = dgvDatos.RowCount
        Dim mca As Boolean
        For fila As Integer = 0 To flagCargar - 1
            If bandera = 1 Then 'Marcar todos
                mca = True
            End If
            If bandera = 2 Then 'Desmarcar todos
                mca = False
            End If
            dgvDatos.SetRowCellValue(fila, gcolSeleccionar, mca)
            dgvDatos.SetRowCellValue(fila, gcolEstaAprobado, mca)
        Next
    End Sub

    Private Sub cmbAprobarTodos_Click(sender As Object, e As EventArgs) Handles cmbAprobarTodos.Click
        banderaDesaprobar = 1
        ObtenerDetalleProgramaIDLocal(1)
    End Sub

    Private Sub cmbBorrarMarcados_Click(sender As Object, e As EventArgs) Handles cmbBorrarMarcados.Click
        ' Define the message you want to see inside the message box. 
        Dim msg = "¿Esta seguro de eliminar estos datos? Recuerde, que este proceso, solo eliminara aquellos lotes que aun no estan Aprobados..."

        ' Define a title for the message box. 
        Dim title = "Advertencia:"

        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or _
                    MsgBoxStyle.Critical

        ' Display the message box and save the response, Yes or No. 
        Dim response = MsgBox(msg, style, title)

        ' Take some action based on the response. 
        If response = MsgBoxResult.Yes Then
            ObtenerDetalleProgramaIDLocal(2)
        Else
            MsgBox("¡Operacion cancelada!", MsgBoxStyle.Information, "Mensaje:")
        End If

    End Sub

    Sub ObtenerDetalleProgramaIDLocal(bandera As Integer)
        flagDoble = dgvDatos.RowCount
        concatenarDetPrgID = ""
        If flagDoble > 0 Then
            For fila As Integer = 0 To flagDoble - 1
                Dim marca As Boolean
                If bandera = 1 Or bandera = 3 Then
                    marca = dgvDatos.GetRowCellValue(fila, gcolEstaAprobado)
                End If
                If bandera = 2 Then
                    marca = dgvDatos.GetRowCellValue(fila, gcolSeleccionar)
                End If
                If marca = True Then
                    concatenarDetPrgID = concatenarDetPrgID & dgvDatos.GetRowCellValue(fila, gcolDetalleProgramaID).ToString() & ","
                End If
                If bandera = 3 Then
                    If marca = False Then
                        concatenarDetPrgID = concatenarDetPrgID & dgvDatos.GetRowCellValue(fila, gcolDetalleProgramaID).ToString() & ","
                    End If
                End If
            Next
            Dim ArregloV() As String = Split(concatenarDetPrgID, ",")
            concatenarDetPrgID = ""
            contadorV = 0
            Dim cArregloV As Integer = ArregloV.Length - 1
            For fila = 0 To cArregloV
                If String.IsNullOrEmpty(ArregloV(fila)) = False Then
                    contadorV = contadorV + 1
                    If contadorV < (cArregloV) Then
                        ArregloV(fila) = ArregloV(fila) & ","
                    End If
                End If
            Next
            For fila = 0 To cArregloV
                If String.IsNullOrEmpty(ArregloV(fila)) = False Then
                    concatenarDetPrgID = concatenarDetPrgID + ArregloV(fila)
                End If
            Next

            If bandera = 1 Or bandera = 3 Then
                'Actualizar campo 'estaAprobado' 
                strMensaje = apr.ActualizarAprobacionDetProgramas(strUsuario, strPassword, 1, ProgramaID, concatenarDetPrgID, banderaDesaprobar)
            End If
            If bandera = 2 Then
                strMensaje = apr.EliminarLoteDetallexPrograma(strUsuario, strPassword, 1, ProgramaID, concatenarDetPrgID)
            End If

            strIdxMensaje = strMensaje.Substring(0, 1)
            strMensaje = strMensaje.Replace(strIdxMensaje, "")
            If strIdxMensaje.Equals("+") Then
                CargarDatosDetallexPrograma()
                MsgBox(strMensaje, MsgBoxStyle.Information, "Mensaje:")
            Else
                MsgBox(strMensaje, MsgBoxStyle.Critical, "Mensaje:")
            End If
        Else
            MsgBox("No existen datos para procesar esta accion. Favor, intente de nuevo. Si el problema, persiste, comuniquese de inmediato con el Departamento de Tecnologias de la Informacion", MsgBoxStyle.Critical, "Mensaje:")
        End If
    End Sub

    Private Sub cmbGuardar_Click(sender As Object, e As EventArgs) Handles cmbGuardar.Click
        Try
            If flagGuardarModificar = 1 Then
                ValidarTextBox()
                If MensajeError.Equals("1") Then
                    Dim fechaCosecha As String = txtFechaEDesde.Text
                    fechaCosecha = apr.ArmarFecha(1, fechaCosecha)
                    Dim rendProLab As Decimal = Convert.ToDecimal(txtRendProLab.Text)
                    Dim areaCosecha As Decimal = Convert.ToDecimal(txtAreaCosecha.Text)
                    Dim toneladasReales As Decimal = Convert.ToDecimal(txtToneladasReales.Text)

                    mensajes = apr.ActualizarDetPrg_y_EstimadosProd(strUsuario, strPassword, 1, fechaCosecha, ResultadoID, rendProLab, areaCosecha, toneladasReales, EstimadoGrupoID, strLoteID, DetalleProgramaID)
                    strIdxMensaje = mensajes.Substring(0, 1)
                    mensajes = mensajes.Replace(strIdxMensaje, "")
                    If strIdxMensaje.Equals("+") Then
                        cmbVerDetalle_Click(sender, e)
                        MsgBox(mensajes, MsgBoxStyle.Information, "Mensaje:")
                    Else
                        MsgBox(mensajes, MsgBoxStyle.Critical, "Mensaje:")
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Sub ValidarTextBox()
        If Convert.ToDecimal(txtRendProLab.Text) = 0 Then
            MensajeError = "No se permiten valores en cero en el campo Ren. Pro. Lab. Favor intente de nuevo"
        ElseIf Convert.ToDecimal(txtAreaCosecha.Text) = 0 Then
            MensajeError = "No se permiten valores en cero en el campo Area Cosecha. Favor intente de nuevo"
        ElseIf Convert.ToDecimal(txtToneladasReales.Text) = 0 Then
            MensajeError = "No se permiten valores en cero en el campo Toneladas Reales. Favor intente de nuevo"
        ElseIf String.IsNullOrEmpty(txtFechaEDesde.Text) Then
            MensajeError = "Error en el campo de Fecha de Cosecha. No se permiten valores vacios y/o nulos. Favor intente de nuevo"
        Else
            MensajeError = "1"
        End If
    End Sub

    Private Sub cbxCategoria_EditValueChanged(sender As Object, e As EventArgs) Handles cbxCategoria.EditValueChanged
        Try
            ResultadoID = CInt(cbxCategoria.EditValue.ToString())
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbDesaprobarTodos_Click(sender As Object, e As EventArgs) Handles cmbDesaprobarTodos.Click
        banderaDesaprobar = 0
        ObtenerDetalleProgramaIDLocal(3)
    End Sub
End Class