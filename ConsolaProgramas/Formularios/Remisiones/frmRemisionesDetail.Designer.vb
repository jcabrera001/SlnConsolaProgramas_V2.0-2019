<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRemisionesDetail
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRemisionesDetail))
        Me.XTTDatos = New DevExpress.XtraTab.XtraTabControl()
        Me.XTPEncBasico = New DevExpress.XtraTab.XtraTabPage()
        Me.btnProcesarOrdenBioSalc = New System.Windows.Forms.Button()
        Me.txtOrdenPeso = New DevExpress.XtraEditors.TextEdit()
        Me.txtNumeroRemision = New DevExpress.XtraEditors.TextEdit()
        Me.LblConductorID = New DevExpress.XtraEditors.LabelControl()
        Me.LblTransportistaID = New DevExpress.XtraEditors.LabelControl()
        Me.LblSdN = New DevExpress.XtraEditors.LabelControl()
        Me.LblFecha = New DevExpress.XtraEditors.LabelControl()
        Me.LblFactNum = New DevExpress.XtraEditors.LabelControl()
        Me.cmbCliente = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GLEClientes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dtpFecha = New DevExpress.XtraEditors.DateEdit()
        Me.cmbConductor = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn42 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn43 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidentificacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collicencia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmarcapred = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colplacapred = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmbTransportista = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XTPEncAvanzado = New DevExpress.XtraTab.XtraTabPage()
        Me.LblEmpresaCodigo = New DevExpress.XtraEditors.LabelControl()
        Me.txtCai = New DevExpress.XtraEditors.TextEdit()
        Me.LblTipoDoctoID = New DevExpress.XtraEditors.LabelControl()
        Me.LblDFID = New DevExpress.XtraEditors.LabelControl()
        Me.LblCAI = New DevExpress.XtraEditors.LabelControl()
        Me.txtRemisionID = New DevExpress.XtraEditors.TextEdit()
        Me.LblRemisionID = New DevExpress.XtraEditors.LabelControl()
        Me.cmbFactura = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn30 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn31 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn32 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn33 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn34 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn35 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn36 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn37 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn38 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmbEmpresa = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn27 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmbTipoDoc = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn40 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn41 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XTPEncTransporte = New DevExpress.XtraTab.XtraTabPage()
        Me.txtCabezal = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LblMontoImpuesto = New DevExpress.XtraEditors.LabelControl()
        Me.LblMontoDescto = New DevExpress.XtraEditors.LabelControl()
        Me.LblTotalNeto = New DevExpress.XtraEditors.LabelControl()
        Me.LblMarchamos = New DevExpress.XtraEditors.LabelControl()
        Me.LblTotalBruto = New DevExpress.XtraEditors.LabelControl()
        Me.txtIdentidad = New DevExpress.XtraEditors.TextEdit()
        Me.txtSello1 = New DevExpress.XtraEditors.TextEdit()
        Me.txtSello2 = New DevExpress.XtraEditors.TextEdit()
        Me.txtMarca = New DevExpress.XtraEditors.TextEdit()
        Me.txtSello4 = New DevExpress.XtraEditors.TextEdit()
        Me.txtSello3 = New DevExpress.XtraEditors.TextEdit()
        Me.txtPlaca = New DevExpress.XtraEditors.TextEdit()
        Me.txtLicencia = New DevExpress.XtraEditors.TextEdit()
        Me.XTPEncMotivo = New DevExpress.XtraTab.XtraTabPage()
        Me.TxtOtroMotivo = New DevExpress.XtraEditors.TextEdit()
        Me.LblDescripcion = New DevExpress.XtraEditors.LabelControl()
        Me.rbtMotivo = New DevExpress.XtraEditors.RadioGroup()
        Me.XTPEncOtros = New DevExpress.XtraTab.XtraTabPage()
        Me.LblFechaFinal = New DevExpress.XtraEditors.LabelControl()
        Me.LblPuntoDestino = New DevExpress.XtraEditors.LabelControl()
        Me.LblFechaInicio = New DevExpress.XtraEditors.LabelControl()
        Me.LblPuntoPartida = New DevExpress.XtraEditors.LabelControl()
        Me.dtpInicio = New DevExpress.XtraEditors.DateEdit()
        Me.dtpTerminacion = New DevExpress.XtraEditors.DateEdit()
        Me.txtPuntoPartida = New DevExpress.XtraEditors.MemoEdit()
        Me.txtPuntoDestino = New DevExpress.XtraEditors.MemoEdit()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEditar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.gbDetalle = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnInsertar = New DevExpress.XtraEditors.SimpleButton()
        Me.Tab1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XTTRegPagina1 = New DevExpress.XtraTab.XtraTabPage()
        Me.cmbUnidades = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmbEmbalaje = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcolcod_empaque = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcoldesc_empaque = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolpeso_emb = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LblRegDescrip1 = New DevExpress.XtraEditors.LabelControl()
        Me.LblRegUnidMedCodigo = New DevExpress.XtraEditors.LabelControl()
        Me.LblRegCantidad = New DevExpress.XtraEditors.LabelControl()
        Me.LblRegProdCodigo = New DevExpress.XtraEditors.LabelControl()
        Me.cmbProductos = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtCantidad = New DevExpress.XtraEditors.CalcEdit()
        Me.txtDes = New DevExpress.XtraEditors.MemoEdit()
        Me.txtDes2 = New DevExpress.XtraEditors.MemoEdit()
        Me.XTTRegPagina2 = New DevExpress.XtraTab.XtraTabPage()
        Me.txtProxRemID = New DevExpress.XtraEditors.TextEdit()
        Me.LblProdXFactID = New DevExpress.XtraEditors.LabelControl()
        Me.gcDetalle = New DevExpress.XtraGrid.GridControl()
        Me.gvDetalle = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TlSNotas = New System.Windows.Forms.ToolStrip()
        Me.CmbGrabarNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSalvar = New System.Windows.Forms.ToolStripButton()
        Me.btnSalir = New System.Windows.Forms.ToolStripButton()
        CType(Me.XTTDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTTDatos.SuspendLayout()
        Me.XTPEncBasico.SuspendLayout()
        CType(Me.txtOrdenPeso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroRemision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GLEClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbConductor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTransportista.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTPEncAvanzado.SuspendLayout()
        CType(Me.txtCai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemisionID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFactura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbEmpresa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTipoDoc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTPEncTransporte.SuspendLayout()
        CType(Me.txtCabezal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdentidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSello1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSello2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMarca.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSello4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSello3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPlaca.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLicencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTPEncMotivo.SuspendLayout()
        CType(Me.TxtOtroMotivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbtMotivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTPEncOtros.SuspendLayout()
        CType(Me.dtpInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpTerminacion.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpTerminacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPuntoPartida.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPuntoDestino.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDetalle.SuspendLayout()
        CType(Me.Tab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab1.SuspendLayout()
        Me.XTTRegPagina1.SuspendLayout()
        CType(Me.cmbUnidades.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbEmbalaje.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProductos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDes2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTTRegPagina2.SuspendLayout()
        CType(Me.txtProxRemID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TlSNotas.SuspendLayout()
        Me.SuspendLayout()
        '
        'XTTDatos
        '
        Me.XTTDatos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XTTDatos.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom
        Me.XTTDatos.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal
        Me.XTTDatos.Location = New System.Drawing.Point(10, 58)
        Me.XTTDatos.Name = "XTTDatos"
        Me.XTTDatos.SelectedTabPage = Me.XTPEncBasico
        Me.XTTDatos.Size = New System.Drawing.Size(738, 118)
        Me.XTTDatos.TabIndex = 13
        Me.XTTDatos.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XTPEncBasico, Me.XTPEncAvanzado, Me.XTPEncTransporte, Me.XTPEncMotivo, Me.XTPEncOtros})
        '
        'XTPEncBasico
        '
        Me.XTPEncBasico.Controls.Add(Me.btnProcesarOrdenBioSalc)
        Me.XTPEncBasico.Controls.Add(Me.txtOrdenPeso)
        Me.XTPEncBasico.Controls.Add(Me.txtNumeroRemision)
        Me.XTPEncBasico.Controls.Add(Me.LblConductorID)
        Me.XTPEncBasico.Controls.Add(Me.LblTransportistaID)
        Me.XTPEncBasico.Controls.Add(Me.LblSdN)
        Me.XTPEncBasico.Controls.Add(Me.LblFecha)
        Me.XTPEncBasico.Controls.Add(Me.LblFactNum)
        Me.XTPEncBasico.Controls.Add(Me.cmbCliente)
        Me.XTPEncBasico.Controls.Add(Me.dtpFecha)
        Me.XTPEncBasico.Controls.Add(Me.cmbConductor)
        Me.XTPEncBasico.Controls.Add(Me.cmbTransportista)
        Me.XTPEncBasico.Name = "XTPEncBasico"
        Me.XTPEncBasico.Size = New System.Drawing.Size(736, 93)
        Me.XTPEncBasico.Text = "Básico"
        '
        'btnProcesarOrdenBioSalc
        '
        Me.btnProcesarOrdenBioSalc.Location = New System.Drawing.Point(221, 58)
        Me.btnProcesarOrdenBioSalc.Name = "btnProcesarOrdenBioSalc"
        Me.btnProcesarOrdenBioSalc.Size = New System.Drawing.Size(114, 23)
        Me.btnProcesarOrdenBioSalc.TabIndex = 107
        Me.btnProcesarOrdenBioSalc.Text = "Procesar Orden"
        Me.btnProcesarOrdenBioSalc.UseVisualStyleBackColor = True
        '
        'txtOrdenPeso
        '
        Me.txtOrdenPeso.Location = New System.Drawing.Point(60, 60)
        Me.txtOrdenPeso.Name = "txtOrdenPeso"
        Me.txtOrdenPeso.Size = New System.Drawing.Size(155, 20)
        Me.txtOrdenPeso.TabIndex = 106
        '
        'txtNumeroRemision
        '
        Me.txtNumeroRemision.Location = New System.Drawing.Point(60, 7)
        Me.txtNumeroRemision.Name = "txtNumeroRemision"
        Me.txtNumeroRemision.Properties.ReadOnly = True
        Me.txtNumeroRemision.Size = New System.Drawing.Size(275, 20)
        Me.txtNumeroRemision.TabIndex = 0
        '
        'LblConductorID
        '
        Me.LblConductorID.Location = New System.Drawing.Point(398, 68)
        Me.LblConductorID.Name = "LblConductorID"
        Me.LblConductorID.Size = New System.Drawing.Size(50, 13)
        Me.LblConductorID.TabIndex = 3
        Me.LblConductorID.Text = "Conductor"
        '
        'LblTransportistaID
        '
        Me.LblTransportistaID.Location = New System.Drawing.Point(398, 38)
        Me.LblTransportistaID.Name = "LblTransportistaID"
        Me.LblTransportistaID.Size = New System.Drawing.Size(64, 13)
        Me.LblTransportistaID.TabIndex = 3
        Me.LblTransportistaID.Text = "Transportista"
        '
        'LblSdN
        '
        Me.LblSdN.Location = New System.Drawing.Point(398, 7)
        Me.LblSdN.Name = "LblSdN"
        Me.LblSdN.Size = New System.Drawing.Size(37, 13)
        Me.LblSdN.TabIndex = 2
        Me.LblSdN.Text = "Cliente:"
        '
        'LblFecha
        '
        Me.LblFecha.Location = New System.Drawing.Point(7, 37)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(29, 13)
        Me.LblFecha.TabIndex = 1
        Me.LblFecha.Text = "Fecha"
        '
        'LblFactNum
        '
        Me.LblFactNum.Location = New System.Drawing.Point(7, 10)
        Me.LblFactNum.Name = "LblFactNum"
        Me.LblFactNum.Size = New System.Drawing.Size(42, 13)
        Me.LblFactNum.TabIndex = 0
        Me.LblFactNum.Text = "Remision"
        '
        'cmbCliente
        '
        Me.cmbCliente.Location = New System.Drawing.Point(495, 7)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbCliente.Properties.NullText = ""
        Me.cmbCliente.Properties.PopupView = Me.GLEClientes
        Me.cmbCliente.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbCliente.Size = New System.Drawing.Size(230, 20)
        Me.cmbCliente.TabIndex = 2
        '
        'GLEClientes
        '
        Me.GLEClientes.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn5, Me.GridColumn6, Me.GridColumn13})
        Me.GLEClientes.DetailHeight = 10000
        Me.GLEClientes.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GLEClientes.Name = "GLEClientes"
        Me.GLEClientes.OptionsEditForm.PopupEditFormWidth = 10000
        Me.GLEClientes.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GLEClientes.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GLEClientes.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GLEClientes.OptionsView.ShowAutoFilterRow = True
        Me.GLEClientes.OptionsView.ShowGroupPanel = False
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Código"
        Me.GridColumn5.FieldName = "TP"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        Me.GridColumn5.Width = 125
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Descripción"
        Me.GridColumn6.FieldName = "Description"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        Me.GridColumn6.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 1
        Me.GridColumn6.Width = 200
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Conocido como"
        Me.GridColumn13.FieldName = "KnownAsName"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.AllowEdit = False
        Me.GridColumn13.OptionsColumn.ReadOnly = True
        Me.GridColumn13.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 2
        Me.GridColumn13.Width = 150
        '
        'dtpFecha
        '
        Me.dtpFecha.EditValue = Nothing
        Me.dtpFecha.Location = New System.Drawing.Point(60, 34)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFecha.Properties.Mask.EditMask = ""
        Me.dtpFecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.dtpFecha.Size = New System.Drawing.Size(275, 20)
        Me.dtpFecha.TabIndex = 1
        '
        'cmbConductor
        '
        Me.cmbConductor.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.cmbConductor.Location = New System.Drawing.Point(495, 65)
        Me.cmbConductor.Name = "cmbConductor"
        Me.cmbConductor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbConductor.Properties.NullText = ""
        Me.cmbConductor.Properties.PopupView = Me.GridView8
        Me.cmbConductor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbConductor.Size = New System.Drawing.Size(230, 20)
        Me.cmbConductor.TabIndex = 4
        '
        'GridView8
        '
        Me.GridView8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn42, Me.GridColumn43, Me.colidentificacion, Me.collicencia, Me.colmarcapred, Me.colplacapred})
        Me.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GridView8.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridView8.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView8.OptionsView.ShowAutoFilterRow = True
        Me.GridView8.OptionsView.ShowGroupPanel = False
        '
        'GridColumn42
        '
        Me.GridColumn42.Caption = "Código"
        Me.GridColumn42.FieldName = "ConductorID"
        Me.GridColumn42.Name = "GridColumn42"
        Me.GridColumn42.OptionsColumn.AllowEdit = False
        Me.GridColumn42.OptionsColumn.ReadOnly = True
        Me.GridColumn42.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn42.Visible = True
        Me.GridColumn42.VisibleIndex = 0
        Me.GridColumn42.Width = 150
        '
        'GridColumn43
        '
        Me.GridColumn43.Caption = "Descripción"
        Me.GridColumn43.FieldName = "Descripcion"
        Me.GridColumn43.Name = "GridColumn43"
        Me.GridColumn43.OptionsColumn.AllowEdit = False
        Me.GridColumn43.OptionsColumn.ReadOnly = True
        Me.GridColumn43.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn43.Visible = True
        Me.GridColumn43.VisibleIndex = 1
        Me.GridColumn43.Width = 227
        '
        'colidentificacion
        '
        Me.colidentificacion.Caption = "Identificacion"
        Me.colidentificacion.FieldName = "Identificacion"
        Me.colidentificacion.Name = "colidentificacion"
        Me.colidentificacion.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'collicencia
        '
        Me.collicencia.Caption = "Licencia"
        Me.collicencia.FieldName = "Licencia"
        Me.collicencia.Name = "collicencia"
        Me.collicencia.OptionsColumn.AllowEdit = False
        Me.collicencia.OptionsColumn.ReadOnly = True
        Me.collicencia.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'colmarcapred
        '
        Me.colmarcapred.Caption = "Marca Pred."
        Me.colmarcapred.FieldName = "MarcaPred"
        Me.colmarcapred.Name = "colmarcapred"
        Me.colmarcapred.OptionsColumn.AllowEdit = False
        Me.colmarcapred.OptionsColumn.ReadOnly = True
        Me.colmarcapred.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'colplacapred
        '
        Me.colplacapred.Caption = "Placa Pred."
        Me.colplacapred.FieldName = "PlacaPred"
        Me.colplacapred.Name = "colplacapred"
        Me.colplacapred.OptionsColumn.AllowEdit = False
        Me.colplacapred.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'cmbTransportista
        '
        Me.cmbTransportista.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.cmbTransportista.Location = New System.Drawing.Point(495, 35)
        Me.cmbTransportista.Name = "cmbTransportista"
        Me.cmbTransportista.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbTransportista.Properties.NullText = ""
        Me.cmbTransportista.Properties.PopupView = Me.GridView2
        Me.cmbTransportista.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbTransportista.Size = New System.Drawing.Size(230, 20)
        Me.cmbTransportista.TabIndex = 3
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn18, Me.GridColumn19})
        Me.GridView2.DetailHeight = 10000
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GridView2.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowAutoFilterRow = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Código"
        Me.GridColumn18.FieldName = "TransportistaID"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.OptionsColumn.AllowEdit = False
        Me.GridColumn18.OptionsColumn.ReadOnly = True
        Me.GridColumn18.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 0
        Me.GridColumn18.Width = 150
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "Descripción"
        Me.GridColumn19.FieldName = "Descripcion"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.OptionsColumn.AllowEdit = False
        Me.GridColumn19.OptionsColumn.ReadOnly = True
        Me.GridColumn19.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 1
        Me.GridColumn19.Width = 227
        '
        'XTPEncAvanzado
        '
        Me.XTPEncAvanzado.Controls.Add(Me.LblEmpresaCodigo)
        Me.XTPEncAvanzado.Controls.Add(Me.txtCai)
        Me.XTPEncAvanzado.Controls.Add(Me.LblTipoDoctoID)
        Me.XTPEncAvanzado.Controls.Add(Me.LblDFID)
        Me.XTPEncAvanzado.Controls.Add(Me.LblCAI)
        Me.XTPEncAvanzado.Controls.Add(Me.txtRemisionID)
        Me.XTPEncAvanzado.Controls.Add(Me.LblRemisionID)
        Me.XTPEncAvanzado.Controls.Add(Me.cmbFactura)
        Me.XTPEncAvanzado.Controls.Add(Me.cmbEmpresa)
        Me.XTPEncAvanzado.Controls.Add(Me.cmbTipoDoc)
        Me.XTPEncAvanzado.Name = "XTPEncAvanzado"
        Me.XTPEncAvanzado.Size = New System.Drawing.Size(736, 93)
        Me.XTPEncAvanzado.Text = "Avanzado"
        '
        'LblEmpresaCodigo
        '
        Me.LblEmpresaCodigo.Location = New System.Drawing.Point(10, 39)
        Me.LblEmpresaCodigo.Name = "LblEmpresaCodigo"
        Me.LblEmpresaCodigo.Size = New System.Drawing.Size(41, 13)
        Me.LblEmpresaCodigo.TabIndex = 9
        Me.LblEmpresaCodigo.Text = "Empresa"
        '
        'txtCai
        '
        Me.txtCai.Location = New System.Drawing.Point(107, 61)
        Me.txtCai.Name = "txtCai"
        Me.txtCai.Properties.ReadOnly = True
        Me.txtCai.Size = New System.Drawing.Size(230, 20)
        Me.txtCai.TabIndex = 20
        '
        'LblTipoDoctoID
        '
        Me.LblTipoDoctoID.Location = New System.Drawing.Point(382, 39)
        Me.LblTipoDoctoID.Name = "LblTipoDoctoID"
        Me.LblTipoDoctoID.Size = New System.Drawing.Size(91, 13)
        Me.LblTipoDoctoID.TabIndex = 9
        Me.LblTipoDoctoID.Text = "Tipo de documento"
        '
        'LblDFID
        '
        Me.LblDFID.Location = New System.Drawing.Point(382, 65)
        Me.LblDFID.Name = "LblDFID"
        Me.LblDFID.Size = New System.Drawing.Size(37, 13)
        Me.LblDFID.TabIndex = 9
        Me.LblDFID.Text = "Factura"
        '
        'LblCAI
        '
        Me.LblCAI.Location = New System.Drawing.Point(10, 65)
        Me.LblCAI.Name = "LblCAI"
        Me.LblCAI.Size = New System.Drawing.Size(18, 13)
        Me.LblCAI.TabIndex = 9
        Me.LblCAI.Text = "CAI"
        '
        'txtRemisionID
        '
        Me.txtRemisionID.Location = New System.Drawing.Point(107, 9)
        Me.txtRemisionID.Name = "txtRemisionID"
        Me.txtRemisionID.Properties.ReadOnly = True
        Me.txtRemisionID.Size = New System.Drawing.Size(230, 20)
        Me.txtRemisionID.TabIndex = 8
        '
        'LblRemisionID
        '
        Me.LblRemisionID.Location = New System.Drawing.Point(10, 13)
        Me.LblRemisionID.Name = "LblRemisionID"
        Me.LblRemisionID.Size = New System.Drawing.Size(85, 13)
        Me.LblRemisionID.TabIndex = 7
        Me.LblRemisionID.Text = "ID del Documento"
        '
        'cmbFactura
        '
        Me.cmbFactura.Location = New System.Drawing.Point(479, 61)
        Me.cmbFactura.Name = "cmbFactura"
        Me.cmbFactura.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbFactura.Properties.NullText = ""
        Me.cmbFactura.Properties.PopupFormSize = New System.Drawing.Size(1000, 500)
        Me.cmbFactura.Properties.PopupView = Me.GridView4
        Me.cmbFactura.Size = New System.Drawing.Size(230, 20)
        Me.cmbFactura.TabIndex = 23
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn30, Me.GridColumn31, Me.GridColumn32, Me.GridColumn33, Me.GridColumn34, Me.GridColumn35, Me.GridColumn36, Me.GridColumn37, Me.GridColumn38})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsEditForm.PopupEditFormWidth = 1000
        Me.GridView4.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GridView4.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowAutoFilterRow = True
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'GridColumn30
        '
        Me.GridColumn30.Caption = "Documento Fuente"
        Me.GridColumn30.FieldName = "SrcDoc"
        Me.GridColumn30.Name = "GridColumn30"
        Me.GridColumn30.OptionsColumn.AllowEdit = False
        Me.GridColumn30.OptionsColumn.ReadOnly = True
        Me.GridColumn30.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn30.Visible = True
        Me.GridColumn30.VisibleIndex = 0
        '
        'GridColumn31
        '
        Me.GridColumn31.Caption = "Descripción"
        Me.GridColumn31.FieldName = "Description"
        Me.GridColumn31.Name = "GridColumn31"
        Me.GridColumn31.OptionsColumn.AllowEdit = False
        Me.GridColumn31.OptionsColumn.ReadOnly = True
        Me.GridColumn31.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn31.Visible = True
        Me.GridColumn31.VisibleIndex = 1
        '
        'GridColumn32
        '
        Me.GridColumn32.Caption = "ID Interno"
        Me.GridColumn32.FieldName = "ObjectID"
        Me.GridColumn32.Name = "GridColumn32"
        '
        'GridColumn33
        '
        Me.GridColumn33.Caption = "Fecha"
        Me.GridColumn33.FieldName = "DocDate"
        Me.GridColumn33.Name = "GridColumn33"
        Me.GridColumn33.OptionsColumn.AllowEdit = False
        Me.GridColumn33.OptionsColumn.ReadOnly = True
        Me.GridColumn33.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn33.Visible = True
        Me.GridColumn33.VisibleIndex = 2
        '
        'GridColumn34
        '
        Me.GridColumn34.Caption = "Monto"
        Me.GridColumn34.FieldName = "DocAmt"
        Me.GridColumn34.Name = "GridColumn34"
        Me.GridColumn34.OptionsColumn.AllowEdit = False
        Me.GridColumn34.OptionsColumn.ReadOnly = True
        Me.GridColumn34.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn34.Visible = True
        Me.GridColumn34.VisibleIndex = 3
        '
        'GridColumn35
        '
        Me.GridColumn35.Caption = "Creador"
        Me.GridColumn35.FieldName = "Creator"
        Me.GridColumn35.Name = "GridColumn35"
        '
        'GridColumn36
        '
        Me.GridColumn36.Caption = "Receptor"
        Me.GridColumn36.FieldName = "Recipient"
        Me.GridColumn36.Name = "GridColumn36"
        '
        'GridColumn37
        '
        Me.GridColumn37.Caption = "Nota"
        Me.GridColumn37.FieldName = "Memo"
        Me.GridColumn37.Name = "GridColumn37"
        '
        'GridColumn38
        '
        Me.GridColumn38.Caption = "Empresa"
        Me.GridColumn38.FieldName = "Company"
        Me.GridColumn38.Name = "GridColumn38"
        '
        'cmbEmpresa
        '
        Me.cmbEmpresa.Enabled = False
        Me.cmbEmpresa.Location = New System.Drawing.Point(107, 35)
        Me.cmbEmpresa.Name = "cmbEmpresa"
        Me.cmbEmpresa.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbEmpresa.Properties.NullText = ""
        Me.cmbEmpresa.Properties.PopupView = Me.GridView5
        Me.cmbEmpresa.Properties.ReadOnly = True
        Me.cmbEmpresa.Size = New System.Drawing.Size(230, 20)
        Me.cmbEmpresa.TabIndex = 5
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn26, Me.GridColumn27})
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowAutoFilterRow = True
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'GridColumn26
        '
        Me.GridColumn26.Caption = "Código"
        Me.GridColumn26.FieldName = "TP"
        Me.GridColumn26.Name = "GridColumn26"
        Me.GridColumn26.Visible = True
        Me.GridColumn26.VisibleIndex = 0
        '
        'GridColumn27
        '
        Me.GridColumn27.Caption = "Descripción"
        Me.GridColumn27.FieldName = "Description"
        Me.GridColumn27.Name = "GridColumn27"
        Me.GridColumn27.Visible = True
        Me.GridColumn27.VisibleIndex = 1
        '
        'cmbTipoDoc
        '
        Me.cmbTipoDoc.Location = New System.Drawing.Point(479, 35)
        Me.cmbTipoDoc.Name = "cmbTipoDoc"
        Me.cmbTipoDoc.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbTipoDoc.Properties.NullText = ""
        Me.cmbTipoDoc.Properties.PopupView = Me.GridView1
        Me.cmbTipoDoc.Properties.ReadOnly = True
        Me.cmbTipoDoc.Size = New System.Drawing.Size(230, 20)
        Me.cmbTipoDoc.TabIndex = 22
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn40, Me.GridColumn41})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn40
        '
        Me.GridColumn40.Caption = "Código"
        Me.GridColumn40.FieldName = "TiposDoctoID"
        Me.GridColumn40.Name = "GridColumn40"
        Me.GridColumn40.Visible = True
        Me.GridColumn40.VisibleIndex = 0
        '
        'GridColumn41
        '
        Me.GridColumn41.Caption = "Descripción"
        Me.GridColumn41.FieldName = "Descripcion"
        Me.GridColumn41.Name = "GridColumn41"
        Me.GridColumn41.Visible = True
        Me.GridColumn41.VisibleIndex = 1
        '
        'XTPEncTransporte
        '
        Me.XTPEncTransporte.Controls.Add(Me.txtCabezal)
        Me.XTPEncTransporte.Controls.Add(Me.LabelControl1)
        Me.XTPEncTransporte.Controls.Add(Me.LblMontoImpuesto)
        Me.XTPEncTransporte.Controls.Add(Me.LblMontoDescto)
        Me.XTPEncTransporte.Controls.Add(Me.LblTotalNeto)
        Me.XTPEncTransporte.Controls.Add(Me.LblMarchamos)
        Me.XTPEncTransporte.Controls.Add(Me.LblTotalBruto)
        Me.XTPEncTransporte.Controls.Add(Me.txtIdentidad)
        Me.XTPEncTransporte.Controls.Add(Me.txtSello1)
        Me.XTPEncTransporte.Controls.Add(Me.txtSello2)
        Me.XTPEncTransporte.Controls.Add(Me.txtMarca)
        Me.XTPEncTransporte.Controls.Add(Me.txtSello4)
        Me.XTPEncTransporte.Controls.Add(Me.txtSello3)
        Me.XTPEncTransporte.Controls.Add(Me.txtPlaca)
        Me.XTPEncTransporte.Controls.Add(Me.txtLicencia)
        Me.XTPEncTransporte.Name = "XTPEncTransporte"
        Me.XTPEncTransporte.Size = New System.Drawing.Size(736, 93)
        Me.XTPEncTransporte.Text = "Transporte"
        '
        'txtCabezal
        '
        Me.txtCabezal.Location = New System.Drawing.Point(346, 62)
        Me.txtCabezal.Name = "txtCabezal"
        Me.txtCabezal.Size = New System.Drawing.Size(154, 20)
        Me.txtCabezal.TabIndex = 4
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(301, 66)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl1.TabIndex = 44
        Me.LabelControl1.Text = "Cabezal"
        '
        'LblMontoImpuesto
        '
        Me.LblMontoImpuesto.Location = New System.Drawing.Point(8, 66)
        Me.LblMontoImpuesto.Name = "LblMontoImpuesto"
        Me.LblMontoImpuesto.Size = New System.Drawing.Size(37, 13)
        Me.LblMontoImpuesto.TabIndex = 38
        Me.LblMontoImpuesto.Text = "Licencia"
        '
        'LblMontoDescto
        '
        Me.LblMontoDescto.Location = New System.Drawing.Point(20, 41)
        Me.LblMontoDescto.Name = "LblMontoDescto"
        Me.LblMontoDescto.Size = New System.Drawing.Size(25, 13)
        Me.LblMontoDescto.TabIndex = 39
        Me.LblMontoDescto.Text = "Placa"
        '
        'LblTotalNeto
        '
        Me.LblTotalNeto.Location = New System.Drawing.Point(293, 16)
        Me.LblTotalNeto.Name = "LblTotalNeto"
        Me.LblTotalNeto.Size = New System.Drawing.Size(46, 13)
        Me.LblTotalNeto.TabIndex = 36
        Me.LblTotalNeto.Text = "Identidad"
        '
        'LblMarchamos
        '
        Me.LblMarchamos.Location = New System.Drawing.Point(520, 7)
        Me.LblMarchamos.Name = "LblMarchamos"
        Me.LblMarchamos.Size = New System.Drawing.Size(27, 13)
        Me.LblMarchamos.TabIndex = 37
        Me.LblMarchamos.Text = "Sellos"
        '
        'LblTotalBruto
        '
        Me.LblTotalBruto.Location = New System.Drawing.Point(16, 16)
        Me.LblTotalBruto.Name = "LblTotalBruto"
        Me.LblTotalBruto.Size = New System.Drawing.Size(29, 13)
        Me.LblTotalBruto.TabIndex = 37
        Me.LblTotalBruto.Text = "Marca"
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Location = New System.Drawing.Point(346, 12)
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.Size = New System.Drawing.Size(154, 20)
        Me.txtIdentidad.TabIndex = 3
        '
        'txtSello1
        '
        Me.txtSello1.Location = New System.Drawing.Point(553, 3)
        Me.txtSello1.Name = "txtSello1"
        Me.txtSello1.Size = New System.Drawing.Size(174, 20)
        Me.txtSello1.TabIndex = 5
        '
        'txtSello2
        '
        Me.txtSello2.Location = New System.Drawing.Point(553, 25)
        Me.txtSello2.Name = "txtSello2"
        Me.txtSello2.Size = New System.Drawing.Size(174, 20)
        Me.txtSello2.TabIndex = 6
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(51, 12)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(220, 20)
        Me.txtMarca.TabIndex = 0
        '
        'txtSello4
        '
        Me.txtSello4.Location = New System.Drawing.Point(553, 67)
        Me.txtSello4.Name = "txtSello4"
        Me.txtSello4.Size = New System.Drawing.Size(174, 20)
        Me.txtSello4.TabIndex = 8
        '
        'txtSello3
        '
        Me.txtSello3.Location = New System.Drawing.Point(553, 46)
        Me.txtSello3.Name = "txtSello3"
        Me.txtSello3.Size = New System.Drawing.Size(174, 20)
        Me.txtSello3.TabIndex = 7
        '
        'txtPlaca
        '
        Me.txtPlaca.Location = New System.Drawing.Point(51, 37)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Size = New System.Drawing.Size(220, 20)
        Me.txtPlaca.TabIndex = 1
        '
        'txtLicencia
        '
        Me.txtLicencia.Location = New System.Drawing.Point(51, 62)
        Me.txtLicencia.Name = "txtLicencia"
        Me.txtLicencia.Size = New System.Drawing.Size(220, 20)
        Me.txtLicencia.TabIndex = 2
        '
        'XTPEncMotivo
        '
        Me.XTPEncMotivo.Controls.Add(Me.TxtOtroMotivo)
        Me.XTPEncMotivo.Controls.Add(Me.LblDescripcion)
        Me.XTPEncMotivo.Controls.Add(Me.rbtMotivo)
        Me.XTPEncMotivo.Name = "XTPEncMotivo"
        Me.XTPEncMotivo.Size = New System.Drawing.Size(736, 93)
        Me.XTPEncMotivo.Text = "Motivo"
        '
        'TxtOtroMotivo
        '
        Me.TxtOtroMotivo.Location = New System.Drawing.Point(491, 64)
        Me.TxtOtroMotivo.Name = "TxtOtroMotivo"
        Me.TxtOtroMotivo.Properties.MaxLength = 50
        Me.TxtOtroMotivo.Size = New System.Drawing.Size(230, 20)
        Me.TxtOtroMotivo.TabIndex = 8
        '
        'LblDescripcion
        '
        Me.LblDescripcion.Location = New System.Drawing.Point(453, 67)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(32, 13)
        Me.LblDescripcion.TabIndex = 9
        Me.LblDescripcion.Text = "Motivo"
        '
        'rbtMotivo
        '
        Me.rbtMotivo.Location = New System.Drawing.Point(3, 4)
        Me.rbtMotivo.Name = "rbtMotivo"
        Me.rbtMotivo.Properties.Columns = 3
        Me.rbtMotivo.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Venta"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Consignación"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Exportación"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Compra"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Importación"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Devolución"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Traslado entre establecimientos"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Traslado de bienes para transformación"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Traslado de bienes para reparación"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Traslado por venta emisor móvil"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Exhibición o demostración"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Participación en ferias"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Otros, especificar")})
        Me.rbtMotivo.Size = New System.Drawing.Size(731, 83)
        Me.rbtMotivo.TabIndex = 10
        '
        'XTPEncOtros
        '
        Me.XTPEncOtros.Controls.Add(Me.LblFechaFinal)
        Me.XTPEncOtros.Controls.Add(Me.LblPuntoDestino)
        Me.XTPEncOtros.Controls.Add(Me.LblFechaInicio)
        Me.XTPEncOtros.Controls.Add(Me.LblPuntoPartida)
        Me.XTPEncOtros.Controls.Add(Me.dtpInicio)
        Me.XTPEncOtros.Controls.Add(Me.dtpTerminacion)
        Me.XTPEncOtros.Controls.Add(Me.txtPuntoPartida)
        Me.XTPEncOtros.Controls.Add(Me.txtPuntoDestino)
        Me.XTPEncOtros.Name = "XTPEncOtros"
        Me.XTPEncOtros.Size = New System.Drawing.Size(736, 93)
        Me.XTPEncOtros.Text = "Otros"
        '
        'LblFechaFinal
        '
        Me.LblFechaFinal.Location = New System.Drawing.Point(423, 39)
        Me.LblFechaFinal.Name = "LblFechaFinal"
        Me.LblFechaFinal.Size = New System.Drawing.Size(102, 13)
        Me.LblFechaFinal.TabIndex = 46
        Me.LblFechaFinal.Text = "Fecha de terminación"
        '
        'LblPuntoDestino
        '
        Me.LblPuntoDestino.Location = New System.Drawing.Point(15, 50)
        Me.LblPuntoDestino.Name = "LblPuntoDestino"
        Me.LblPuntoDestino.Size = New System.Drawing.Size(82, 13)
        Me.LblPuntoDestino.TabIndex = 47
        Me.LblPuntoDestino.Text = "Punto de Destino"
        '
        'LblFechaInicio
        '
        Me.LblFechaInicio.Location = New System.Drawing.Point(423, 10)
        Me.LblFechaInicio.Name = "LblFechaInicio"
        Me.LblFechaInicio.Size = New System.Drawing.Size(72, 13)
        Me.LblFechaInicio.TabIndex = 44
        Me.LblFechaInicio.Text = "Fecha de Inicio"
        '
        'LblPuntoPartida
        '
        Me.LblPuntoPartida.Location = New System.Drawing.Point(15, 8)
        Me.LblPuntoPartida.Name = "LblPuntoPartida"
        Me.LblPuntoPartida.Size = New System.Drawing.Size(80, 13)
        Me.LblPuntoPartida.TabIndex = 45
        Me.LblPuntoPartida.Text = "Punto de Partida"
        '
        'dtpInicio
        '
        Me.dtpInicio.EditValue = Nothing
        Me.dtpInicio.Location = New System.Drawing.Point(531, 10)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpInicio.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpInicio.Properties.Mask.EditMask = ""
        Me.dtpInicio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.dtpInicio.Size = New System.Drawing.Size(159, 20)
        Me.dtpInicio.TabIndex = 51
        '
        'dtpTerminacion
        '
        Me.dtpTerminacion.EditValue = Nothing
        Me.dtpTerminacion.Location = New System.Drawing.Point(531, 36)
        Me.dtpTerminacion.Name = "dtpTerminacion"
        Me.dtpTerminacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpTerminacion.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpTerminacion.Properties.Mask.EditMask = ""
        Me.dtpTerminacion.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.dtpTerminacion.Size = New System.Drawing.Size(159, 20)
        Me.dtpTerminacion.TabIndex = 50
        '
        'txtPuntoPartida
        '
        Me.txtPuntoPartida.Location = New System.Drawing.Point(100, 5)
        Me.txtPuntoPartida.Name = "txtPuntoPartida"
        Me.txtPuntoPartida.Properties.MaxLength = 100
        Me.txtPuntoPartida.Size = New System.Drawing.Size(277, 31)
        Me.txtPuntoPartida.TabIndex = 48
        '
        'txtPuntoDestino
        '
        Me.txtPuntoDestino.Location = New System.Drawing.Point(100, 47)
        Me.txtPuntoDestino.Name = "txtPuntoDestino"
        Me.txtPuntoDestino.Properties.MaxLength = 100
        Me.txtPuntoDestino.Size = New System.Drawing.Size(277, 35)
        Me.txtPuntoDestino.TabIndex = 49
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.ImageOptions.Image = CType(resources.GetObject("btnEliminar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(707, 237)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(50, 50)
        Me.btnEliminar.TabIndex = 19
        Me.btnEliminar.ToolTip = "Eliminar item"
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditar.ImageOptions.Image = CType(resources.GetObject("btnEditar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEditar.Location = New System.Drawing.Point(707, 294)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(50, 50)
        Me.btnEditar.TabIndex = 20
        Me.btnEditar.ToolTip = "Modificar item"
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.ImageOptions.Image = CType(resources.GetObject("btnNuevo.ImageOptions.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(707, 184)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(50, 50)
        Me.btnNuevo.TabIndex = 18
        Me.btnNuevo.ToolTip = "Agregar item"
        '
        'gbDetalle
        '
        Me.gbDetalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbDetalle.Controls.Add(Me.btnCancelar)
        Me.gbDetalle.Controls.Add(Me.btnInsertar)
        Me.gbDetalle.Controls.Add(Me.Tab1)
        Me.gbDetalle.Location = New System.Drawing.Point(10, 345)
        Me.gbDetalle.Name = "gbDetalle"
        Me.gbDetalle.Size = New System.Drawing.Size(755, 163)
        Me.gbDetalle.TabIndex = 21
        Me.gbDetalle.TabStop = False
        Me.gbDetalle.Text = "Registro"
        Me.gbDetalle.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.ImageOptions.Image = CType(resources.GetObject("btnCancelar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(697, 76)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(50, 50)
        Me.btnCancelar.TabIndex = 15
        Me.btnCancelar.ToolTip = "Cancelar cambios"
        '
        'btnInsertar
        '
        Me.btnInsertar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInsertar.ImageOptions.Image = CType(resources.GetObject("btnInsertar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnInsertar.Location = New System.Drawing.Point(697, 20)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(50, 50)
        Me.btnInsertar.TabIndex = 14
        Me.btnInsertar.ToolTip = "Actualizar cambios"
        '
        'Tab1
        '
        Me.Tab1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tab1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Right
        Me.Tab1.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal
        Me.Tab1.Location = New System.Drawing.Point(6, 20)
        Me.Tab1.Name = "Tab1"
        Me.Tab1.SelectedTabPage = Me.XTTRegPagina1
        Me.Tab1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[True]
        Me.Tab1.Size = New System.Drawing.Size(683, 129)
        Me.Tab1.TabIndex = 0
        Me.Tab1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XTTRegPagina1, Me.XTTRegPagina2})
        '
        'XTTRegPagina1
        '
        Me.XTTRegPagina1.Controls.Add(Me.cmbUnidades)
        Me.XTTRegPagina1.Controls.Add(Me.cmbEmbalaje)
        Me.XTTRegPagina1.Controls.Add(Me.LabelControl2)
        Me.XTTRegPagina1.Controls.Add(Me.LblRegDescrip1)
        Me.XTTRegPagina1.Controls.Add(Me.LblRegUnidMedCodigo)
        Me.XTTRegPagina1.Controls.Add(Me.LblRegCantidad)
        Me.XTTRegPagina1.Controls.Add(Me.LblRegProdCodigo)
        Me.XTTRegPagina1.Controls.Add(Me.cmbProductos)
        Me.XTTRegPagina1.Controls.Add(Me.txtCantidad)
        Me.XTTRegPagina1.Controls.Add(Me.txtDes)
        Me.XTTRegPagina1.Controls.Add(Me.txtDes2)
        Me.XTTRegPagina1.Name = "XTTRegPagina1"
        Me.XTTRegPagina1.Size = New System.Drawing.Size(598, 127)
        Me.XTTRegPagina1.Text = "Detalle"
        '
        'cmbUnidades
        '
        Me.cmbUnidades.EditValue = ""
        Me.cmbUnidades.Location = New System.Drawing.Point(113, 41)
        Me.cmbUnidades.Name = "cmbUnidades"
        Me.cmbUnidades.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbUnidades.Properties.NullText = ""
        Me.cmbUnidades.Properties.PopupView = Me.GridView7
        Me.cmbUnidades.Size = New System.Drawing.Size(237, 20)
        Me.cmbUnidades.TabIndex = 2
        '
        'GridView7
        '
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.GridColumn4})
        Me.GridView7.DetailHeight = 9000
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsEditForm.PopupEditFormWidth = 1500
        Me.GridView7.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView7.OptionsView.ShowGroupPanel = False
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Código"
        Me.GridColumn3.FieldName = "UnidMedCodigo"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        Me.GridColumn3.Width = 100
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Descripcion"
        Me.GridColumn4.FieldName = "Descripcion"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        Me.GridColumn4.Width = 500
        '
        'cmbEmbalaje
        '
        Me.cmbEmbalaje.Location = New System.Drawing.Point(426, 44)
        Me.cmbEmbalaje.Name = "cmbEmbalaje"
        Me.cmbEmbalaje.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbEmbalaje.Properties.NullText = ""
        Me.cmbEmbalaje.Properties.PopupView = Me.GridView3
        Me.cmbEmbalaje.Size = New System.Drawing.Size(157, 20)
        Me.cmbEmbalaje.TabIndex = 26
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcolcod_empaque, Me.gcoldesc_empaque, Me.gcolpeso_emb})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GridView3.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowAutoFilterRow = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'gcolcod_empaque
        '
        Me.gcolcod_empaque.Caption = "Código"
        Me.gcolcod_empaque.FieldName = "COD_EMPAQUE"
        Me.gcolcod_empaque.Name = "gcolcod_empaque"
        Me.gcolcod_empaque.OptionsColumn.AllowEdit = False
        Me.gcolcod_empaque.OptionsColumn.ReadOnly = True
        Me.gcolcod_empaque.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolcod_empaque.Visible = True
        Me.gcolcod_empaque.VisibleIndex = 0
        '
        'gcoldesc_empaque
        '
        Me.gcoldesc_empaque.Caption = "Descripción"
        Me.gcoldesc_empaque.FieldName = "DESC_EMPAQUE"
        Me.gcoldesc_empaque.Name = "gcoldesc_empaque"
        Me.gcoldesc_empaque.OptionsColumn.AllowEdit = False
        Me.gcoldesc_empaque.OptionsColumn.ReadOnly = True
        Me.gcoldesc_empaque.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcoldesc_empaque.Visible = True
        Me.gcoldesc_empaque.VisibleIndex = 1
        '
        'gcolpeso_emb
        '
        Me.gcolpeso_emb.Caption = "Peso Tara KG"
        Me.gcolpeso_emb.FieldName = "PESO_EMB"
        Me.gcolpeso_emb.Name = "gcolpeso_emb"
        Me.gcolpeso_emb.OptionsColumn.AllowEdit = False
        Me.gcolpeso_emb.OptionsColumn.ReadOnly = True
        Me.gcolpeso_emb.Visible = True
        Me.gcolpeso_emb.VisibleIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(366, 47)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl2.TabIndex = 25
        Me.LabelControl2.Text = "Embalaje:"
        '
        'LblRegDescrip1
        '
        Me.LblRegDescrip1.Location = New System.Drawing.Point(16, 73)
        Me.LblRegDescrip1.Name = "LblRegDescrip1"
        Me.LblRegDescrip1.Size = New System.Drawing.Size(54, 13)
        Me.LblRegDescrip1.TabIndex = 21
        Me.LblRegDescrip1.Text = "Descripción"
        '
        'LblRegUnidMedCodigo
        '
        Me.LblRegUnidMedCodigo.Location = New System.Drawing.Point(16, 44)
        Me.LblRegUnidMedCodigo.Name = "LblRegUnidMedCodigo"
        Me.LblRegUnidMedCodigo.Size = New System.Drawing.Size(85, 13)
        Me.LblRegUnidMedCodigo.TabIndex = 7
        Me.LblRegUnidMedCodigo.Text = "Unidad de Medida"
        '
        'LblRegCantidad
        '
        Me.LblRegCantidad.Location = New System.Drawing.Point(366, 14)
        Me.LblRegCantidad.Name = "LblRegCantidad"
        Me.LblRegCantidad.Size = New System.Drawing.Size(43, 13)
        Me.LblRegCantidad.TabIndex = 5
        Me.LblRegCantidad.Text = "Cantidad"
        '
        'LblRegProdCodigo
        '
        Me.LblRegProdCodigo.Location = New System.Drawing.Point(16, 14)
        Me.LblRegProdCodigo.Name = "LblRegProdCodigo"
        Me.LblRegProdCodigo.Size = New System.Drawing.Size(43, 13)
        Me.LblRegProdCodigo.TabIndex = 5
        Me.LblRegProdCodigo.Text = "Producto"
        '
        'cmbProductos
        '
        Me.cmbProductos.Location = New System.Drawing.Point(113, 14)
        Me.cmbProductos.Name = "cmbProductos"
        Me.cmbProductos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbProductos.Properties.NullText = ""
        Me.cmbProductos.Properties.PopupFormSize = New System.Drawing.Size(500, 0)
        Me.cmbProductos.Properties.PopupView = Me.GridView6
        Me.cmbProductos.Size = New System.Drawing.Size(237, 20)
        Me.cmbProductos.TabIndex = 9
        '
        'GridView6
        '
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17})
        Me.GridView6.DetailHeight = 10000
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GridView6.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowAutoFilterRow = True
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Código"
        Me.GridColumn14.FieldName = "ProdCodigo"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.AllowEdit = False
        Me.GridColumn14.OptionsColumn.ReadOnly = True
        Me.GridColumn14.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 0
        Me.GridColumn14.Width = 60
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Descripción"
        Me.GridColumn15.FieldName = "Descripcion"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.AllowEdit = False
        Me.GridColumn15.OptionsColumn.ReadOnly = True
        Me.GridColumn15.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 1
        Me.GridColumn15.Width = 185
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Unidad de Medida"
        Me.GridColumn16.FieldName = "UnidMed"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.OptionsColumn.AllowEdit = False
        Me.GridColumn16.OptionsColumn.ReadOnly = True
        Me.GridColumn16.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 2
        Me.GridColumn16.Width = 64
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Precio"
        Me.GridColumn17.DisplayFormat.FormatString = "###,###,###.##"
        Me.GridColumn17.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn17.FieldName = "Precio"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.OptionsColumn.AllowEdit = False
        Me.GridColumn17.OptionsColumn.ReadOnly = True
        Me.GridColumn17.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn17.ShowUnboundExpressionMenu = True
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 3
        Me.GridColumn17.Width = 68
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(426, 14)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCantidad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtCantidad.Size = New System.Drawing.Size(157, 20)
        Me.txtCantidad.TabIndex = 11
        '
        'txtDes
        '
        Me.txtDes.Location = New System.Drawing.Point(113, 70)
        Me.txtDes.Name = "txtDes"
        Me.txtDes.Properties.MaxLength = 100
        Me.txtDes.Size = New System.Drawing.Size(237, 45)
        Me.txtDes.TabIndex = 20
        '
        'txtDes2
        '
        Me.txtDes2.Location = New System.Drawing.Point(366, 70)
        Me.txtDes2.Name = "txtDes2"
        Me.txtDes2.Properties.MaxLength = 100
        Me.txtDes2.Size = New System.Drawing.Size(217, 45)
        Me.txtDes2.TabIndex = 22
        '
        'XTTRegPagina2
        '
        Me.XTTRegPagina2.Controls.Add(Me.txtProxRemID)
        Me.XTTRegPagina2.Controls.Add(Me.LblProdXFactID)
        Me.XTTRegPagina2.Name = "XTTRegPagina2"
        Me.XTTRegPagina2.Size = New System.Drawing.Size(598, 127)
        Me.XTTRegPagina2.Text = "Generalidades"
        '
        'txtProxRemID
        '
        Me.txtProxRemID.Location = New System.Drawing.Point(73, 10)
        Me.txtProxRemID.Name = "txtProxRemID"
        Me.txtProxRemID.Properties.ReadOnly = True
        Me.txtProxRemID.Size = New System.Drawing.Size(166, 20)
        Me.txtProxRemID.TabIndex = 16
        '
        'LblProdXFactID
        '
        Me.LblProdXFactID.Location = New System.Drawing.Point(13, 10)
        Me.LblProdXFactID.Name = "LblProdXFactID"
        Me.LblProdXFactID.Size = New System.Drawing.Size(48, 13)
        Me.LblProdXFactID.TabIndex = 7
        Me.LblProdXFactID.Text = "ID interno"
        '
        'gcDetalle
        '
        Me.gcDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcDetalle.Location = New System.Drawing.Point(10, 180)
        Me.gcDetalle.MainView = Me.gvDetalle
        Me.gcDetalle.Name = "gcDetalle"
        Me.gcDetalle.Size = New System.Drawing.Size(691, 314)
        Me.gcDetalle.TabIndex = 17
        Me.gcDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDetalle})
        '
        'gvDetalle
        '
        Me.gvDetalle.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn12, Me.GridColumn7, Me.GridColumn1, Me.GridColumn2, Me.GridColumn8, Me.GridColumn10})
        Me.gvDetalle.GridControl = Me.gcDetalle
        Me.gvDetalle.Name = "gvDetalle"
        Me.gvDetalle.OptionsView.ShowGroupPanel = False
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "ProdXRemID"
        Me.GridColumn12.FieldName = "ProdxRemID"
        Me.GridColumn12.Name = "GridColumn12"
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "ProdCodigo"
        Me.GridColumn7.FieldName = "ProdCodigo"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 0
        Me.GridColumn7.Width = 95
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Producto"
        Me.GridColumn1.FieldName = "nomProducto"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 280
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Unidad"
        Me.GridColumn2.FieldName = "nomUnidad"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        Me.GridColumn2.Width = 227
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Unidad de medida"
        Me.GridColumn8.FieldName = "UnidMedCodigo"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.Width = 222
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Cantidad"
        Me.GridColumn10.DisplayFormat.FormatString = "###,###,###.##"
        Me.GridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn10.FieldName = "Cantidad"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 3
        Me.GridColumn10.Width = 64
        '
        'TlSNotas
        '
        Me.TlSNotas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CmbGrabarNuevo, Me.ToolStripSeparator2, Me.btnSalvar, Me.btnSalir})
        Me.TlSNotas.Location = New System.Drawing.Point(0, 0)
        Me.TlSNotas.Name = "TlSNotas"
        Me.TlSNotas.Size = New System.Drawing.Size(773, 53)
        Me.TlSNotas.TabIndex = 23
        '
        'CmbGrabarNuevo
        '
        Me.CmbGrabarNuevo.AutoSize = False
        Me.CmbGrabarNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmbGrabarNuevo.Enabled = False
        Me.CmbGrabarNuevo.Image = CType(resources.GetObject("CmbGrabarNuevo.Image"), System.Drawing.Image)
        Me.CmbGrabarNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmbGrabarNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmbGrabarNuevo.Name = "CmbGrabarNuevo"
        Me.CmbGrabarNuevo.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.CmbGrabarNuevo.Size = New System.Drawing.Size(50, 50)
        Me.CmbGrabarNuevo.Tag = "5"
        Me.CmbGrabarNuevo.Text = "Grabar y crear nuevo registro vacío"
        Me.CmbGrabarNuevo.Visible = False
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 53)
        '
        'btnSalvar
        '
        Me.btnSalvar.AutoSize = False
        Me.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(50, 50)
        Me.btnSalvar.Tag = "5"
        Me.btnSalvar.Text = "Grabar cambios"
        '
        'btnSalir
        '
        Me.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSalir.AutoSize = False
        Me.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(50, 50)
        Me.btnSalir.Text = "Volver a la consulta"
        '
        'frmRemisionesDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 519)
        Me.Controls.Add(Me.TlSNotas)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.gbDetalle)
        Me.Controls.Add(Me.gcDetalle)
        Me.Controls.Add(Me.XTTDatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRemisionesDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Remisiones"
        CType(Me.XTTDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTTDatos.ResumeLayout(False)
        Me.XTPEncBasico.ResumeLayout(False)
        Me.XTPEncBasico.PerformLayout()
        CType(Me.txtOrdenPeso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroRemision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GLEClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbConductor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTransportista.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTPEncAvanzado.ResumeLayout(False)
        Me.XTPEncAvanzado.PerformLayout()
        CType(Me.txtCai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemisionID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFactura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbEmpresa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTipoDoc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTPEncTransporte.ResumeLayout(False)
        Me.XTPEncTransporte.PerformLayout()
        CType(Me.txtCabezal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdentidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSello1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSello2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMarca.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSello4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSello3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPlaca.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLicencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTPEncMotivo.ResumeLayout(False)
        Me.XTPEncMotivo.PerformLayout()
        CType(Me.TxtOtroMotivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbtMotivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTPEncOtros.ResumeLayout(False)
        Me.XTPEncOtros.PerformLayout()
        CType(Me.dtpInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpTerminacion.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpTerminacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPuntoPartida.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPuntoDestino.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDetalle.ResumeLayout(False)
        CType(Me.Tab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab1.ResumeLayout(False)
        Me.XTTRegPagina1.ResumeLayout(False)
        Me.XTTRegPagina1.PerformLayout()
        CType(Me.cmbUnidades.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbEmbalaje.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProductos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDes2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTTRegPagina2.ResumeLayout(False)
        Me.XTTRegPagina2.PerformLayout()
        CType(Me.txtProxRemID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TlSNotas.ResumeLayout(False)
        Me.TlSNotas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents XTTDatos As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XTPEncBasico As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnProcesarOrdenBioSalc As Button
    Friend WithEvents txtOrdenPeso As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNumeroRemision As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblConductorID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblTransportistaID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblSdN As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblFecha As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblFactNum As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbCliente As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GLEClientes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtpFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbConductor As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn42 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn43 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidentificacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collicencia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmarcapred As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colplacapred As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbTransportista As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XTPEncAvanzado As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LblEmpresaCodigo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCai As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblTipoDoctoID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblDFID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblCAI As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRemisionID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblRemisionID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbFactura As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn30 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn31 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn32 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn33 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn34 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn35 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn36 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn37 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn38 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbEmpresa As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn27 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbTipoDoc As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn40 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn41 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XTPEncTransporte As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtCabezal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblMontoImpuesto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblMontoDescto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblTotalNeto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblMarchamos As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblTotalBruto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIdentidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSello1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSello2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMarca As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSello4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSello3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPlaca As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtLicencia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents XTPEncMotivo As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TxtOtroMotivo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblDescripcion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rbtMotivo As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents XTPEncOtros As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LblFechaFinal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblPuntoDestino As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblFechaInicio As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblPuntoPartida As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtpInicio As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtpTerminacion As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtPuntoPartida As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtPuntoDestino As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gbDetalle As GroupBox
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnInsertar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Tab1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XTTRegPagina1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cmbEmbalaje As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcolcod_empaque As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcoldesc_empaque As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolpeso_emb As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblRegDescrip1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblRegUnidMedCodigo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblRegCantidad As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblRegProdCodigo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbProductos As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtCantidad As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents txtDes As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtDes2 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents XTTRegPagina2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtProxRemID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblProdXFactID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gcDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDetalle As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbUnidades As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TlSNotas As ToolStrip
    Friend WithEvents CmbGrabarNuevo As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btnSalvar As ToolStripButton
    Friend WithEvents btnSalir As ToolStripButton
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
End Class
