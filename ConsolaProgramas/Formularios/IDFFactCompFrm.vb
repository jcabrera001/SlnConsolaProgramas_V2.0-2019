Imports LibDAO001
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class IDFFactCompFrm
    Public ClsCAIXSdN As IDF_CAIXSdN
    Public ClsProductos As IDF_Productos
    Public ClsEmpresas As IDF_Empresas
    Public ClsEmpresasAnexo As IDF_EmpresasAnexo
    Public ClsFactComp As IDF_FactComp
    Public ClsImpuestos As IDF_Impuestos
    Public ClsSdNs As IDF_SdNs
    Public ClsSdNsAnexo As IDF_ClientesAnexo
    Public ClsRetenciones As IDF_Retenciones

    Public strUsuario, strPassword, StrEmpresa, query As String
    Public IntTipoDocto As Integer
    Public ClsConexion As New ClsConexion
    Public ClsU As New ClsUtilitarios

    Public ClsAccesos As ClsVistas = Nothing
    Public ClsVista As ClsVistas = Nothing
    Public aplicaGenAutoRetenciones As Boolean
    Public dtOpciones, dtConfigxEmpresa, dtEmpresasAnexo As DataTable
    Public contador, OpcionConsultar, OpcionModificar, nRespuesta, xEstado As Integer
    Public esOtroComprobante As Boolean
    Public msgResultado As MsgBoxResult = New MsgBoxResult()
    Public DialogoResult As DialogResult = New DialogResult()

    Public Sub FuncionInicial(strU As String, strP As String, StrE As String, IntT As Integer,
                               PerfilID As Integer, PrgID As Integer, FormID As Integer)
        strUsuario = strU
        strPassword = strP
        StrEmpresa = StrE
        IntTipoDocto = IntT

    End Sub

    Private Sub CmbActualizarConsulta_Click(sender As Object, e As EventArgs) Handles CmbActualizarConsulta.Click
        CargarConsulta()
        CargarRegistros()
        Personalizar()
    End Sub

    Private Sub CmbNuevo_Click(sender As Object, e As EventArgs) Handles CmbNuevo.Click
        Me.XTTDatos.SelectedTabPage = Me.XTPEncBasico
        VerificarEliminarDetalleRemEnZero()
        Nuevo()
        CargarItems()
    End Sub
    Private Sub CmbEditar_Click(sender As Object, e As EventArgs) Handles CmbEditar.Click
        Me.XTTDatos.SelectedTabPage = Me.XTPEncBasico

        Dim nCAIXSdNID As String
        nCAIXSdNID = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "FactCompID")

        Try
            Editar(nCAIXSdNID)
            CargarItems()
            BuscarCAI()

            'Verifica si la factura del proveedor tiene asignado un comprobante de retencion.
            'En el caso que el usuario necesite agregar mas lineas debera de anular la retencion.
            ClsVista = New ClsVistas()
            Dim dtRetenciones As New DataTable()
            Dim xCAIComprobante As String = TxtCAIXSdNID.Text
            Dim xCorrelativo As String = TxtNDFEstab.Text & "-" & TxtNDFPuntoEm.Text & "-" & TxtNDFTipoDoc.Text & "-" & TxtNDFCorrelat.Text
            dtRetenciones = ClsVista.VerificarRetencionDeFacturaCompra(strUsuario, strPassword,
                                     1, StrEmpresa, 5, xCAIComprobante, xCorrelativo, "")
            contador = 0
            contador = dtRetenciones.Rows(0)(0)
            Dim aplicaGenAutoRetenciones As Boolean = Convert.ToBoolean(dtRetenciones.Rows(0)(1))

            'Habilitar botones
            TxtCAIXSdNID.Enabled = True
            TxtFecha.Enabled = True
            CmbNuevoCAI.Enabled = True
            TxtNDFEstab.Enabled = True
            TxtNDFPuntoEm.Enabled = True
            TxtNDFTipoDoc.Enabled = True
            TxtNDFCorrelat.Enabled = True
            CmbNuevoItem.Enabled = True
            CmbEliminarItem.Enabled = True
            cmbModificarItem.Enabled = True
            CmbGrabarNuevo.Enabled = True
            CmbGrabarSalir.Enabled = True
            chkAplicaRetencion.Enabled = True

            If xEstado = 1 Then '1 = Anulado, para facturas por compras, demas documentos fiscales 2 = Anulado
                'Bloquear botones
                TxtCAIXSdNID.Enabled = False
                TxtFecha.Enabled = False
                CmbNuevoCAI.Enabled = False
                TxtNDFEstab.Enabled = False
                TxtNDFPuntoEm.Enabled = False
                TxtNDFTipoDoc.Enabled = False
                TxtNDFCorrelat.Enabled = False
                CmbNuevoItem.Enabled = False
                CmbEliminarItem.Enabled = False
                cmbModificarItem.Enabled = False
                CmbGrabarNuevo.Enabled = False
                CmbGrabarSalir.Enabled = False
                chkAplicaRetencion.Enabled = False
            End If

            If LblAccion.Text.Equals("Edición de datos.") And contador > 0 And aplicaGenAutoRetenciones = True Then
                ClsU.NotaCompleta("Error: No tiene permisos para modificar el detalle de la factura del proveedor.\n" & _
                                   "Motivo: Este documento tiene asignado un Comprobante de Retención.\n" & _
                                   "Solución: Debera de anular el comprobante de retencion", 16)
                'Bloquear botones
                TxtCAIXSdNID.Enabled = False
                TxtFecha.Enabled = False
                CmbNuevoCAI.Enabled = False
                TxtNDFEstab.Enabled = False
                TxtNDFPuntoEm.Enabled = False
                TxtNDFTipoDoc.Enabled = False
                TxtNDFCorrelat.Enabled = False
                CmbNuevoItem.Enabled = False
                CmbEliminarItem.Enabled = False
                cmbModificarItem.Enabled = False
                CmbGrabarNuevo.Enabled = False
                CmbGrabarSalir.Enabled = False
                chkAplicaRetencion.Enabled = False
            End If

        Catch ex As Exception
            ClsU.NotaCompleta("Debe de elegir un registro para editar. " & ex.Message, 16)
        End Try

    End Sub

    Private Sub CmbNuevoItem_Click(sender As Object, e As EventArgs) Handles CmbNuevoItem.Click
        NuevoItem()
    End Sub
    Private Sub CmbEliminarItem_Click(sender As Object, e As EventArgs) Handles CmbEliminarItem.Click
        Try
            Dim nDetFactCompID As Integer
            nDetFactCompID = Me.GrdVwItems.GetRowCellValue(Me.GrdVwItems.FocusedRowHandle, "DetFactCompID")

            'Impresion multiples filas
            nRespuesta = ClsU.NotaCompletaPregunta("¿Esta seguro que desea eliminar esta linea? " & _
                                                   "¿Desea continuar?", 128)

            If nRespuesta = 7 Then
                Exit Sub
            End If
            EliminarItem(nDetFactCompID)
            CargarItems()

        Catch ex As Exception
            ClsU.NotaCompleta("Debe de elegir un registro para eliminar. [" & ex.Message & "]", 16)
        End Try
    End Sub
    Private Sub cmbModificarItem_Click(sender As Object, e As EventArgs) Handles cmbModificarItem.Click
        Try
            Dim nDetFactCompID As Integer
            nDetFactCompID = Me.GrdVwItems.GetRowCellValue(Me.GrdVwItems.FocusedRowHandle, "DetFactCompID")

            ModificarItem(nDetFactCompID)

        Catch ex As Exception

            ClsU.NotaCompleta("Debe de elegir un registro para modificar. [" & ex.Message & "]", 16)

        End Try
    End Sub
    Private Sub CmbRegActualizar_Click(sender As Object, e As EventArgs) Handles CmbRegActualizar.Click
        'Intento para salvar el encabezado de la factura, solo cuando el RemisionID=0
        Try

            If Me.TxtFactCompID.EditValue = 0 Then
                Grabar(Me.LblAccion.Text)
            End If

            GrabarItem(Me.GrpRegistro.Text)
            CargarItems()

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al actualizar registro. [" & ex.Message & "]", 16)
        End Try

    End Sub

    Private Sub CmbRegCancelar_Click(sender As Object, e As EventArgs) Handles CmbRegCancelar.Click
        CancelarItem()
    End Sub

    Private Sub GrdConsulta_DoubleClick(sender As Object, e As EventArgs) Handles GrdConsulta.DoubleClick
        Dim nFactCompID As Integer
        nFactCompID = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "FactCompID")

        Try
            Editar(nFactCompID)
            CargarItems()
        Catch ex As Exception
            ClsU.NotaCompleta("Debe de elegir un registro para editar. " & ex.Message, 16)
        End Try
    End Sub

    Private Sub CmbRegresarConsulta_Click(sender As Object, e As EventArgs) Handles CmbRegresarConsulta.Click
        RegresarConsulta()
    End Sub

    Private Sub CmbGrabarNuevo_Click(sender As Object, e As EventArgs) Handles CmbGrabarNuevo.Click
        Grabar(Me.LblAccion.Text)
        Nuevo()
        CargarItems()
    End Sub

    Private Sub CmbGrabarSalir_Click(sender As Object, e As EventArgs) Handles CmbGrabarSalir.Click
        Dim resultado_mensaje As String = VerificarCamposObligatorios()
        If resultado_mensaje.Equals("1") Then
            Grabar(Me.LblAccion.Text)
        Else
            ClsU.NotaCompleta(resultado_mensaje, 16)
            TxtNDFPuntoEm.BackColor = Color.White
            TxtNDFEstab.BackColor = Color.White
            TxtNDFTipoDoc.BackColor = Color.White
            TxtNDFCorrelat.BackColor = Color.White

        End If
    End Sub

    Public Function VerificarCamposObligatorios() As String
        Dim strMensaje As String = ""
        If (TxtNDFPuntoEm.Text.Length < TxtNDFPuntoEm.MaxLength) Then
            strMensaje = "Error en campo de texto Punto de Emision, tamaño permitido de caracteres = " & TxtNDFPuntoEm.MaxLength.ToString & ". Favor intente de nuevo..."
            TxtNDFPuntoEm.BackColor = Color.Red
        ElseIf TxtNDFEstab.Text.Length < TxtNDFEstab.MaxLength Then
            strMensaje = "Error en campo de texto Establecimiento, tamaño permitido de caracteres = " & TxtNDFEstab.MaxLength.ToString & ". Favor intente de nuevo..."
            TxtNDFEstab.BackColor = Color.Red
        ElseIf (TxtNDFTipoDoc.Text.Length < TxtNDFTipoDoc.MaxLength) And
               esOtroComprobante = False Then
            strMensaje = "Error en campo de texto Tipo de Documento, tamaño permitido de caracteres = " & TxtNDFTipoDoc.MaxLength & ". Favor intente de nuevo..."
            TxtNDFTipoDoc.BackColor = Color.Red
        ElseIf TxtNDFCorrelat.Text.Length < TxtNDFCorrelat.MaxLength Then
            strMensaje = "Error en campo de texto Correlativo, tamaño permitido de caracteres = " & TxtNDFCorrelat.MaxLength & ". Favor intente de nuevo..."
            TxtNDFCorrelat.BackColor = Color.Red
        ElseIf txtAnioAReportar.EditValue = 0 Then
            strMensaje = "Error en campo de texto Año a Reportar, valor = 0. Verifique o intente de nuevo"
        Else
            strMensaje = "1"
        End If

        Return strMensaje
    End Function

    Private Sub CmbAnular_Click(sender As Object, e As EventArgs) Handles CmbAnular.Click
        msgResultado = ClsU.NotaCompletaPregunta("¿Desea anular este documento?", 128)
        If msgResultado = MsgBoxResult.Yes Then
            Dim nFactCompID As Integer
            nFactCompID = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "FactCompID")

            Try
                'Verifica si la factura del proveedor tiene asignado un comprobante de retencion.
                'En el caso que el usuario necesite agregar mas lineas debera de anular la retencion.
                ClsVista = New ClsVistas()
                Dim dtRetenciones As New DataTable()
                Dim xCAIComprobante As String = TxtCAIXSdNID.Text
                Dim xCorrelativo As String = TxtNDFEstab.Text & "-" & TxtNDFPuntoEm.Text & "-" & TxtNDFTipoDoc.Text & "-" & TxtNDFCorrelat.Text
                dtRetenciones = ClsVista.VerificarRetencionDeFacturaCompra(strUsuario, strPassword,
                                         1, StrEmpresa, 5, xCAIComprobante, xCorrelativo, "")
                contador = 0
                contador = dtRetenciones.Rows(0)(0)

                'Habilitar botones
                TxtCAIXSdNID.Enabled = True
                TxtFecha.Enabled = True
                CmbNuevoCAI.Enabled = True
                TxtNDFEstab.Enabled = True
                TxtNDFPuntoEm.Enabled = True
                TxtNDFTipoDoc.Enabled = True
                TxtNDFCorrelat.Enabled = True
                CmbNuevoItem.Enabled = True
                CmbEliminarItem.Enabled = True
                cmbModificarItem.Enabled = True
                CmbGrabarNuevo.Enabled = True
                CmbGrabarNuevo.Enabled = True

                If contador > 0 Then
                    ClsU.NotaCompleta("Error: No tiene permisos para anular esta factura del proveedor.\n" & _
                                       "Motivo: Este documento tiene asignado un Comprobante de Retención.\n" & _
                                       "Solución: Debera de anular el comprobante de retencion", 16)
                    'Habilitar botones
                    TxtCAIXSdNID.Enabled = False
                    TxtFecha.Enabled = False
                    CmbNuevoCAI.Enabled = False
                    TxtNDFEstab.Enabled = False
                    TxtNDFPuntoEm.Enabled = False
                    TxtNDFTipoDoc.Enabled = False
                    TxtNDFCorrelat.Enabled = False
                    CmbNuevoItem.Enabled = False
                    CmbEliminarItem.Enabled = False
                    cmbModificarItem.Enabled = False
                    CmbGrabarNuevo.Enabled = False
                    CmbGrabarNuevo.Enabled = False
                Else
                    Anular(nFactCompID, 2) '2=Anulado
                End If
            Catch ex As Exception
                ClsU.NotaCompleta("Debe de elegir un registro para anular. " & ex.Message, 16)
            End Try
        End If
    End Sub

    Private Sub FinDFFactsFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargarRegistros()
        Personalizar()
    End Sub

    Sub VerificarEliminarDetalleRemEnZero()
        'Si existe detalle de remisiones con remisionId = 0
        ClsVista = New ClsVistas()
        Dim dt As DataTable = New DataTable()
        dt = ClsVista.VerificarRemisionIDDetalleZero(strUsuario, strPassword, 1, 0, 0)
        Dim intCount As Integer = Integer.Parse(dt.Rows(0)(0).ToString)
        If intCount = 0 Then
            Dim dt1 As DataTable = New DataTable()
            dt1 = ClsVista.VerificarRemisionIDDetalleZero(strUsuario, strPassword, 2, 0, 0)
        End If
    End Sub

    Private Sub ChkEsOCE_CheckedChanged(sender As Object, e As EventArgs) Handles ChkEsOCE.CheckedChanged
        If Me.ChkEsOCE.Checked = True Then
            Me.TxtOCEFecha.Enabled = True
            Me.TxtOceResolucion.Enabled = True
        Else
            Me.TxtOCEFecha.Enabled = False
            Me.TxtOceResolucion.Enabled = False
        End If
    End Sub

    Private Sub CmbNuevoCAI_Click(sender As Object, e As EventArgs) Handles CmbNuevoCAI.Click
        Me.TxtCAIXSdNID.Tag = My.Computer.Clipboard.GetText

        Dim FrmIDFCAIXSdN As IDFCAIXSdNFrm = New IDFCAIXSdNFrm
        FrmIDFCAIXSdN.FuncionInicial(strUsuario, strPassword, StrEmpresa)
        FrmIDFCAIXSdN.Nuevo()
        FrmIDFCAIXSdN.TxtCAI.Text = Me.TxtCAIXSdNID.Tag
        FrmIDFCAIXSdN.ShowDialog()

        CargarRegistros()

        Me.TxtCAIXSdNID.EditValue = My.Computer.Clipboard.GetText
    End Sub

    Private Sub TxtCAIXSdNID_LostFocus(sender As Object, e As EventArgs) Handles TxtCAIXSdNID.LostFocus, TxtRetencionID.LostFocus

        My.Computer.Clipboard.SetText(Me.TxtCAIXSdNID.Text)

    End Sub

    Private Sub TxtCAIXSdNID_Validated(sender As Object, e As EventArgs) Handles TxtCAIXSdNID.Validated, TxtRetencionID.Validated

        BuscarCAI()

    End Sub

    Private Sub TxtRegMontoGravado_EditValueChanged(sender As Object, e As EventArgs) Handles TxtRegMontoGravado.EditValueChanged
        Try
            CalculoImpuesto()
        Catch ex As Exception

        End Try

    End Sub
    'Private Sub TxtRegImpuestoCodigo_LostFocus(sender As Object, e As EventArgs) Handles TxtRegImpuestoCodigo.LostFocus

    'End Sub


#Region "Procedimientos Definidos por el usuario"
    Public Sub Personalizar()

    End Sub
    Public Sub UbicarImpuesto()
        If String.IsNullOrEmpty(strUsuario) = False Then
            Dim oRegImp As New IDF_Impuestos(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
            oRegImp = IDF_Impuestos.Buscar("TaxCat='" & Me.TxtRegImpuestoCodigo.EditValue & "'")

            Try
                'Validar si el item es RETENCIONES
                Dim ideRET As Integer = InStr(TxtRegImpuestoCodigo.EditValue.ToString(), "RET", CompareMethod.Text)
                If ideRET >= 1 Then
                    Dim oRegRet As New IDF_Retenciones(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
                    Dim RetencionID As String = TxtRegImpuestoCodigo.EditValue.ToString()
                    RetencionID = RetencionID.Replace("RET", "")
                    oRegRet = IDF_Retenciones.Buscar("RetencionID=" & RetencionID & "")
                    Me.TxtRegPorcentaje.EditValue = oRegRet.Porcentaje
                    TxtRegMontoGravado.Enabled = False
                Else
                    TxtRegMontoGravado.Enabled = True
                    Me.TxtRegPorcentaje.EditValue = oRegImp.Percentage
                End If

            Catch ex As Exception

            End Try
        End If

    End Sub
    Public Sub CalculoImpuesto()
        Me.TxtRegImpuestoMonto.EditValue = Me.TxtRegMontoGravado.EditValue * Me.TxtRegPorcentaje.EditValue
    End Sub
    Public Sub CargarConsulta()

        Dim DtDatosDFFacts As New DataTable

        ClsFactComp = New IDF_FactComp(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Try
            Dim qry As String = "Select FactCompID, B.SdN, B.CAI, A.Fecha, A.EsOCE, A.MontoTotal," & _
            "A.NDFEstab + '-' + A.NDFPuntoEm + '-' + A.NDFTipoDoc + '-' + A.NDFCorrelat As NumDocto, " & _
            "CASE WHEN A.Estado = 0 THEN 'En proceso' WHEN A.Estado = 1 THEN 'Anulado' WHEN A.Estado = 2 THEN '' END AS EstadoDescripcion,A.UsuCreacion " & _
            "From IDF_FactComp A Left Join IDF_CAIXSdN B on A.CAIXSdNID=B.CAIXSdNID " & _
            "Where A.EmpresaCodigo = '" & StrEmpresa & "' Order by A.Fecha"
            DtDatosDFFacts = IDF_FactComp.Tabla(qry)

            Me.GrdConsulta.DataSource = DtDatosDFFacts

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Documentos Fuente. " & ex.Message, 16)
        End Try

    End Sub

    Public Sub CargarRegistros()
        CmbOpcImpresion.SelectedIndex = 0

        Dim DtDatosCAIXSdN As New DataTable
        Dim DtDatosImpuestos As New DataTable
        Dim DtDatosEmpresas As New DataTable
        Dim DtDatosRetenciones As New DataTable

        ClsCAIXSdN = New IDF_CAIXSdN(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        ClsImpuestos = New IDF_Impuestos(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        ClsEmpresas = New IDF_Empresas(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        ClsEmpresasAnexo = New IDF_EmpresasAnexo(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        ClsRetenciones = New IDF_Retenciones(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Try
            DtDatosCAIXSdN = IDF_CAIXSdN.Tabla("Select *, B.Description As SdNDescrip From IDF_CAIXSdN A Left Join IDF_SdNs B on A.SdN = B.TP")
            Me.TxtCAIXSdNID.Properties.DataSource = DtDatosCAIXSdN
            Me.TxtCAIXSdNID.Properties.ValueMember = DtDatosCAIXSdN.Columns(0).ToString()
            Me.TxtCAIXSdNID.Properties.DisplayMember = DtDatosCAIXSdN.Columns(2).ToString()

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Codigos de Auto Impresor. " & ex.Message, 16)
        End Try

        Try
            dtEmpresasAnexo = New DataTable()
            dtEmpresasAnexo = IDF_EmpresasAnexo.Tabla("Select * From IDF_EmpresasAnexo Where EmpresaCodigo='" & StrEmpresa & "'")
            aplicaGenAutoRetenciones = Convert.ToBoolean(dtEmpresasAnexo.Rows(0)(10))
            If aplicaGenAutoRetenciones Then
                '    'Bloqueado por Ing. Manuel Ortega - Lunes, 01/08/2016 - 03:00pm
                '    'Agregar validacion de lista de retenciones
                query = "Select * From IDF_Impuestos Where TaxCat in ('ISV0','ISV" & StrEmpresa & "') " & _
                                                       "UNION ALL " & _
                                                       "SELECT 'RET0'+CAST(r.RetencionID AS NVARCHAR) AS TaxCat, " & _
                                                       "r.Descripcion,r.Porcentaje " & _
                                                       "FROM IDF_Retenciones r "
            Else
                'Por los momentos solo se debe de obtener los impuestos
                query = "Select * From IDF_Impuestos Where TaxCat in ('ISV0','ISV" & StrEmpresa & "') "
            End If

            DtDatosImpuestos = IDF_Impuestos.Tabla(query)
            Me.TxtRegImpuestoCodigo.Properties.DataSource = DtDatosImpuestos
            Me.TxtRegImpuestoCodigo.Properties.ValueMember = DtDatosImpuestos.Columns(0).ToString()
            Me.TxtRegImpuestoCodigo.Properties.DisplayMember = DtDatosImpuestos.Columns(1).ToString()

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Impuestos. " & ex.Message, 16)
        End Try

        Try
            DtDatosEmpresas = IDF_Empresas.Tabla()
            Me.TxtEmpresaCodigo.Properties.DataSource = DtDatosEmpresas
            Me.TxtEmpresaCodigo.Properties.ValueMember = DtDatosEmpresas.Columns(0).ToString()
            Me.TxtEmpresaCodigo.Properties.DisplayMember = DtDatosEmpresas.Columns(1).ToString()

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Empresas. " & ex.Message, 16)
        End Try

        Try
            DtDatosRetenciones = IDF_Retenciones.Tabla()
            Me.TxtRetencionID.Properties.DataSource = DtDatosRetenciones
            Me.TxtRetencionID.Properties.ValueMember = DtDatosRetenciones.Columns(0).ToString()
            Me.TxtRetencionID.Properties.DisplayMember = DtDatosRetenciones.Columns(1).ToString()

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Retenciones. " & ex.Message, 16)
        End Try

        TxtFecha.EditValue = DateTime.Now

    End Sub
    Public Sub CargarItems()

        Dim DtDatosDetalle As New DataTable

        Try
            DtDatosDetalle = IDF_DetFactComp.Tabla("Select * From IDF_DetFactComp Where FactCompID='" & Me.TxtFactCompID.EditValue.ToString & "'")
            Me.GrdItems.DataSource = DtDatosDetalle

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Líneas de impuestos de la Compra. " & ex.Message, 16)
        End Try

        DtDatosDetalle = IDF_DetFactComp.Tabla("Select Sum(MontoGravado+ImpuestoMonto) As MontoTotal From IDF_DetFactComp Where FactCompID='" & Me.TxtFactCompID.EditValue.ToString & "'")
        Me.TxtMontoTotal.EditValue = DtDatosDetalle.Rows(0).Item(0).ToString

    End Sub

    Public Sub Nuevo()

        Me.lblEstado.Text = "En Proceso"
        Me.LblAccion.Text = "Nuevo registro."
        Me.LblCodigoValor.Text = "<NuevoValor>"
        Me.XTTEmpaginacion.SelectedTabPage = XTTPagina2

        Dim oRegNuevo As New IDF_FactComp(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Me.TxtFactCompID.Text = oRegNuevo.FactCompID
        Me.TxtEmpresaCodigo.Text = StrEmpresa
        Me.TxtNDFEstab.Text = oRegNuevo.NDFEstab
        Me.TxtNDFPuntoEm.Text = oRegNuevo.NDFPuntoEm
        Me.TxtNDFTipoDoc.Text = oRegNuevo.NDFTipoDoc
        Me.TxtNDFCorrelat.Text = oRegNuevo.NDFCorrelat
        Me.TxtFecha.Text = Now()
        Me.TxtRetencionID.EditValue = oRegNuevo.RetencionID
        Me.TxtCAIXSdNID.Text = oRegNuevo.CAIXSdNID
        Me.TxtCAEE.Text = oRegNuevo.CAEE
        Me.TxtMontoTotal.EditValue = oRegNuevo.MontoTotal
        Me.ChkEsOCE.Checked = False
        Me.TxtOceResolucion.Text = oRegNuevo.OCEResolucion
        Me.TxtOCEFecha.Text = Now()
        Me.lblEstado.Tag = 0
        'Inicializar año y mes a reportar
        txtAnioAReportar.EditValue = Today.Year
        cbxMesAReportar.SelectedIndex = Today.Month - 1

        Me.CmbNuevoItem.Enabled = True
        Me.CmbEliminarItem.Enabled = False
        Me.cmbModificarItem.Enabled = False

    End Sub
    Public Sub Editar(nDato As Integer)

        Me.LblAccion.Text = "Edición de datos."

        Dim oRegEdicion As New IDF_FactComp(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        oRegEdicion = IDF_FactComp.Buscar("FactCompID='" & nDato & "'")

        Me.LblCodigoValor.Text = oRegEdicion.NDFEstab + "-" + oRegEdicion.NDFPuntoEm + "-" + oRegEdicion.NDFTipoDoc + "-" + oRegEdicion.NDFCorrelat

        Me.TxtFactCompID.Text = oRegEdicion.FactCompID
        Me.TxtFactCompID.Enabled = False

        Me.TxtEmpresaCodigo.Text = oRegEdicion.EmpresaCodigo
        Me.TxtNDFEstab.Text = oRegEdicion.NDFEstab
        Me.TxtNDFPuntoEm.Text = oRegEdicion.NDFPuntoEm
        Me.TxtNDFTipoDoc.Text = oRegEdicion.NDFTipoDoc
        Me.TxtNDFCorrelat.Text = oRegEdicion.NDFCorrelat
        Me.TxtFecha.Text = oRegEdicion.Fecha
        Me.TxtRetencionID.EditValue = oRegEdicion.RetencionID
        Me.TxtCAIXSdNID.Text = oRegEdicion.CAIXSdNID
        Me.TxtCAEE.Text = oRegEdicion.CAEE
        Me.TxtMontoTotal.EditValue = oRegEdicion.MontoTotal
        Me.ChkEsOCE.Checked = IIf(oRegEdicion.EsOCE = 0, False, True)
        Me.TxtOceResolucion.Text = oRegEdicion.OCEResolucion
        Me.TxtOCEFecha.Text = oRegEdicion.OCEFecha
        Me.txtAnioAReportar.EditValue = oRegEdicion.AnioAReportar
        Dim Mes As Integer = oRegEdicion.MesAReportar - 1
        If Mes < 0 Then
            Mes = 0
        End If
        Me.cbxMesAReportar.SelectedIndex = Mes
        Me.chkAplicaRetencion.Checked = IIf(oRegEdicion.AplicaRetencion = 0, False, True)

        Me.lblEstado.Text = IIf(oRegEdicion.Estado = 0, "En Proceso", IIf(oRegEdicion.Estado = 1, "Aprobado", "Anulado"))
        xEstado = Convert.ToInt32(oRegEdicion.Estado)
        Me.XTTEmpaginacion.SelectedTabPage = XTTPagina2

    End Sub

    Public Sub NuevoItem()
        Me.XTTDetalle.SelectedTabPage = XTTRegPagina1
        Me.GrpRegistro.Text = "Nuevo registro."

        Dim RegNuevo As New IDF_DetFactComp(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Me.TxtRegDetFactCompID.Text = RegNuevo.DetFactCompID
        Me.TxtRegFactCompID.Text = Me.TxtFactCompID.EditValue
        Me.TxtRegImpuestoCodigo.EditValue = "ISV" + StrEmpresa
        Me.TxtRegMontoGravado.EditValue = RegNuevo.MontoGravado
        Me.TxtRegPorcentaje.EditValue = RegNuevo.Porcentaje
        Me.TxtRegImpuestoMonto.EditValue = RegNuevo.ImpuestoMonto

        UbicarImpuesto()
        ActivarItem()
    End Sub

    Public Sub EliminarItem(nDato As Integer)
        Dim oRegDet As New IDF_DetFactComp(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        oRegDet.DetFactCompID = nDato

        Try
            oRegDet.Borrar()
        Catch ex As Exception
            ClsU.NotaCompleta("Debe de elegir un registro para eliminar. " & ex.Message, 16)
        End Try

        CargarItems()

    End Sub

    Public Sub ModificarItem(nDato As Integer)
        Me.GrpRegistro.Text = "Edición de datos."
        ActivarItem()

        Dim oDetReg As New IDF_DetFactComp(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        oDetReg = IDF_DetFactComp.Buscar("DetFactCompID='" & nDato & "'")

        Me.TxtRegDetFactCompID.Text = oDetReg.DetFactCompID
        Me.TxtFactCompID.Text = oDetReg.FactCompID
        Me.TxtRegImpuestoCodigo.EditValue = oDetReg.ImpuestoCodigo
        Me.TxtRegMontoGravado.EditValue = oDetReg.MontoGravado
        Me.TxtRegPorcentaje.EditValue = oDetReg.Porcentaje
        Me.TxtRegImpuestoMonto.EditValue = oDetReg.ImpuestoMonto

    End Sub

    Public Sub ActivarItem()
        GrpRegistro.Visible = True

        CmbNuevoItem.Enabled = False
        cmbModificarItem.Enabled = False
        CmbEliminarItem.Enabled = False

        CmbRegresarConsulta.Enabled = False
        CmbGrabarNuevo.Enabled = False
        CmbGrabarSalir.Enabled = False
    End Sub

    Public Sub CancelarItem()
        GrpRegistro.Visible = False

        CmbNuevoItem.Enabled = True
        cmbModificarItem.Enabled = True
        CmbEliminarItem.Enabled = True

        CmbRegresarConsulta.Enabled = True
        CmbGrabarNuevo.Enabled = True
        CmbGrabarSalir.Enabled = True
    End Sub

    Public Sub RegresarConsulta()
        Me.XTTEmpaginacion.SelectedTabPage = XTTPagina1
    End Sub

    Public Sub Grabar(cAccion As String)

        Dim cResultado As String

        Dim oRegistro As New IDF_FactComp(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        Dim oRegistroCopia As New IDF_FactComp(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        If Me.TxtNDFEstab.Text.Length = 0 Then
            ClsU.NotaCompleta("Se requiere un Número de factura válido.", 16)
            Me.TxtNDFEstab.Focus()
            Exit Sub
        End If

        If Me.TxtNDFPuntoEm.Text.Length = 0 Then
            ClsU.NotaCompleta("Se requiere un Número de factura válido.", 16)
            Me.TxtNDFPuntoEm.Focus()
            Exit Sub
        End If

        If Me.TxtNDFTipoDoc.Text.Length = 0 Then
            ClsU.NotaCompleta("Se requiere un Número de factura válido.", 16)
            Me.TxtNDFTipoDoc.Focus()
            Exit Sub
        End If

        If Me.TxtNDFCorrelat.Text.Length = 0 Then
            ClsU.NotaCompleta("Se requiere un Número de factura válido.", 16)
            Me.TxtNDFCorrelat.Focus()
            Exit Sub
        End If

        If Me.TxtCAIXSdNID.EditValue = 0 Then
            ClsU.NotaCompleta("Se requiere un Número de CAI válido.", 16)
            Me.TxtCAIXSdNID.Focus()
            Exit Sub
        End If

        oRegistro.FactCompID = Me.TxtFactCompID.EditValue
        oRegistro.NDFEstab = Me.TxtNDFEstab.Text
        oRegistro.NDFPuntoEm = Me.TxtNDFPuntoEm.Text
        oRegistro.NDFTipoDoc = Me.TxtNDFTipoDoc.Text
        oRegistro.NDFCorrelat = Me.TxtNDFCorrelat.Text
        oRegistro.Fecha = Me.TxtFecha.EditValue
        oRegistro.RetencionID = Me.TxtRetencionID.EditValue
        oRegistro.EmpresaCodigo = Me.TxtEmpresaCodigo.EditValue
        oRegistro.CAIXSdNID = Me.TxtCAIXSdNID.EditValue
        oRegistro.CAEE = Me.TxtCAEE.Text
        oRegistro.MontoTotal = Val(Me.TxtMontoTotal.EditValue)
        oRegistro.Estado = Me.lblEstado.Tag
        oRegistro.EsOCE = IIf(Me.ChkEsOCE.Checked, 1, 0)
        oRegistro.OCEResolucion = Me.TxtOceResolucion.Text
        oRegistro.OCEFecha = Me.TxtOCEFecha.EditValue
        oRegistro.AnioAReportar = Me.txtAnioAReportar.EditValue
        contador = Me.cbxMesAReportar.SelectedIndex + 1
        oRegistro.MesAReportar = contador
        oRegistro.AplicaRetencion = IIf(Me.chkAplicaRetencion.Checked, 1, 0)

        If cAccion = "Edición de datos." Then

            Try
                oRegistro.UsuEdicion = strUsuario
                oRegistro.FechaEdicion = Now()

                'Recuperar el RemisionID para seguir registrando productos bajo ese código
                oRegistroCopia = IDF_FactComp.Buscar("FactCompID='" & oRegistro.FactCompID & "'")
                oRegistro.UsuCreacion = oRegistroCopia.UsuCreacion
                oRegistro.FechaCreacion = oRegistroCopia.FechaCreacion
                oRegistro.UsuAnulacion = oRegistroCopia.UsuAnulacion
                oRegistro.FechaAnulacion = oRegistroCopia.FechaAnulacion

                cResultado = oRegistro.Actualizar()
                Dim xResultado As Integer = InStr(cResultado, "ERROR", CompareMethod.Text)
                If xResultado > 0 Then
                    ClsU.NotaCompleta("No se pudo actualizar el nuevo registro [" & cResultado & "]", 16)
                    Return
                End If
                'If cResultado Like "ERROR%" Then
                '    ClsU.NotaCompleta("No se pudo actualizar el nuevo registro [" & cResultado & "]", 16)
                '    Return
                'End If

                ClsU.NotaCompleta("Registro actualizado satisfactoriamente!", 64)
            Catch ex As Exception
                ClsU.NotaCompleta("Error en la actualización. " + ex.Message, 16)
            End Try
        End If

        If cAccion = "Nuevo registro." Then
            Try

                oRegistro.UsuCreacion = strUsuario
                oRegistro.FechaCreacion = Now()
                oRegistro.UsuEdicion = strUsuario
                oRegistro.FechaEdicion = Now()
                oRegistro.UsuAnulacion = ""
                oRegistro.FechaAnulacion = Now()

                cResultado = oRegistro.Crear()
                Dim xResultado As Integer = InStr(cResultado, "ERROR", CompareMethod.Text)
                If xResultado > 0 Then
                    ClsU.NotaCompleta("No se pudo crear el nuevo registro [" & cResultado & "]", 16)
                    Return
                End If
                'If cResultado Like "ERROR%" Then
                '    ClsU.NotaCompleta("No se pudo crear el nuevo registro [" & cResultado & "]", 16)
                '    Return
                'End If

                'Recuperar el RemisionID para seguir registrando productos bajo ese código
                oRegistroCopia = IDF_FactComp.Buscar("CAIXSdNID='" & oRegistro.CAIXSdNID & "' and NDFCorrelat = '" & oRegistro.NDFCorrelat & "'")
                Me.TxtFactCompID.EditValue = oRegistroCopia.FactCompID

                ClsU.NotaCompleta("Registro creado satisfactoriamente!", 64)

                Me.CmbNuevoItem.Enabled = True
                Me.CmbEliminarItem.Enabled = True
                Me.cmbModificarItem.Enabled = True

                Editar(oRegistroCopia.FactCompID)

            Catch ex As Exception
                ClsU.NotaCompleta("Error en la creación del registro. " + ex.Message, 16)
            End Try
        End If

        Me.LblCodigoValor.Text = oRegistro.NDFEstab + "-" + oRegistro.NDFPuntoEm + "-" + oRegistro.NDFTipoDoc + "-" + oRegistro.NDFCorrelat

    End Sub

    Public Sub GrabarItem(cAccion As String)
        Dim oDetRegistro As New IDF_DetFactComp(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        Dim oFactComp As New IDF_FactComp(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Dim DtDatosDetalle As New DataTable

        If Len(Me.TxtFactCompID.Text) = 0 Then
            ClsU.NotaCompleta("Se requiere un Número de Factura válido.", 16)
            Me.TxtFactCompID.Focus()
            Exit Sub
        End If

        oDetRegistro.DetFactCompID = Me.TxtRegDetFactCompID.EditValue
        oDetRegistro.FactCompID = Me.TxtFactCompID.EditValue
        oDetRegistro.ImpuestoCodigo = Me.TxtRegImpuestoCodigo.EditValue
        oDetRegistro.MontoGravado = Val(Me.TxtRegMontoGravado.EditValue)
        oDetRegistro.Porcentaje = Me.TxtRegPorcentaje.EditValue
        oDetRegistro.ImpuestoMonto = Val(Me.TxtRegImpuestoMonto.EditValue)

        If cAccion = "Edición de datos." Then

            Try
                oDetRegistro.Actualizar()
            Catch ex As Exception
                ClsU.NotaCompleta("Error en la actualización. " & ex.Message, 16)
            End Try
        End If

        If cAccion = "Nuevo registro." Then
            Try
                oDetRegistro.Crear()
            Catch ex As Exception
                ClsU.NotaCompleta("Error en la creación del registro. " & ex.Message, 16)
            End Try
        End If


        Try
            DtDatosDetalle = IDF_DetFactComp.Tabla("Select Sum(MontoGravado+ImpuestoMonto) As MontoTotal From IDF_DetFactComp Where FactCompID='" & oDetRegistro.FactCompID.ToString & "'")

            'Actualizar el total en la tabla principal
            oFactComp = IDF_FactComp.Buscar("FactCompID=" & oDetRegistro.FactCompID.ToString)
            oFactComp.MontoTotal = Val(DtDatosDetalle.Rows(0).Item(0).ToString)

            oFactComp.Actualizar()
        Catch ex As Exception

        End Try


        CancelarItem()

    End Sub

    Public Sub Anular(nFactCompID As Integer, nEstado As Integer)
        Dim oRegistro As New IDF_FactComp(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        oRegistro.FactCompID = nFactCompID

        Try
            oRegistro = IDF_FactComp.Buscar("FactCompID='" & nFactCompID & "'")
            oRegistro.Estado = nEstado

            oRegistro.Actualizar()
        Catch ex As Exception
            ClsU.NotaCompleta("Debe de elegir un registro para eliminar. " & ex.Message, 16)
        End Try

        CargarItems()

    End Sub


    Public Sub BuscarCAI()
        Try
            Dim oSdN As New IDF_SdNs(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
            Dim oSdNAnexo As New IDF_ClientesAnexo(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
            Dim oCAIXSdN As New IDF_CAIXSdN(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

            'Llenar los valores de el nombre del proveedor y el RTN
            oCAIXSdN = IDF_CAIXSdN.Buscar("CAIXSdNID='" & Me.TxtCAIXSdNID.EditValue & "'")
            oSdN = IDF_SdNs.Buscar("TP='" & oCAIXSdN.SdN & "'")
            oSdNAnexo = IDF_ClientesAnexo.Buscar("TP='" & oCAIXSdN.SdN & "'")

            Me.TxtSdNCodigo.Text = oSdN.TP
            Me.TxtProveedor.Text = oSdN.Description

            esOtroComprobante = Convert.ToBoolean(oSdNAnexo.EsOtrosComp)

            If oSdNAnexo Is Nothing Then
                Me.TxtRTN.Text = ""
            Else
                Me.TxtRTN.Text = oSdNAnexo.RTN
            End If
        Catch ex As Exception

        End Try

    End Sub

#End Region

    Private Sub TxtRegImpuestoCodigo_EditValueChanged(sender As Object, e As EventArgs) Handles TxtRegImpuestoCodigo.EditValueChanged
        If TxtRegImpuestoCodigo.EditValue.ToString().Length > 0 Then
            UbicarImpuesto()
        End If
    End Sub
End Class