<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinDFDescripFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FinDFDescripFrm))
        Me.XTTEmpaginacion = New DevExpress.XtraTab.XtraTabControl()
        Me.XTTPagina1 = New DevExpress.XtraTab.XtraTabPage()
        Me.GrdConsulta = New DevExpress.XtraGrid.GridControl()
        Me.GrdConsultaView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSelector = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkSelector = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colDFDescripID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.CmbNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CmbEditar = New System.Windows.Forms.ToolStripButton()
        Me.CmbActualizarConsulta = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CmbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.CmbAnular = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblTipoProcesoImpresion = New System.Windows.Forms.ToolStripLabel()
        Me.CmbOpcImpresion = New System.Windows.Forms.ToolStripComboBox()
        Me.lblFrecuenciaImpresion = New System.Windows.Forms.ToolStripLabel()
        Me.txtFrecuenciaImpresion = New System.Windows.Forms.ToolStripTextBox()
        Me.lblTituloSegundos = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.CmbSelectorTodos = New System.Windows.Forms.ToolStripButton()
        Me.CmbQuitarSelector = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.XTTPagina2 = New DevExpress.XtraTab.XtraTabPage()
        Me.CmbEliminarItem = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbModificarItem = New DevExpress.XtraEditors.SimpleButton()
        Me.CmbNuevoItem = New DevExpress.XtraEditors.SimpleButton()
        Me.GrpRegistro = New System.Windows.Forms.GroupBox()
        Me.CmbRegCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.CmbRegActualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.XTTDetalle = New DevExpress.XtraTab.XtraTabControl()
        Me.XTTRegPagina1 = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LblRegTotalBruto = New DevExpress.XtraEditors.LabelControl()
        Me.TxtRegTotalBruto = New DevExpress.XtraEditors.CalcEdit()
        Me.LblRegImptoMonto = New DevExpress.XtraEditors.LabelControl()
        Me.LblImptoCodigo = New DevExpress.XtraEditors.LabelControl()
        Me.TxtRegImptoCodigo = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TxtRegImptoMonto = New DevExpress.XtraEditors.CalcEdit()
        Me.LblRegRetencionID = New DevExpress.XtraEditors.LabelControl()
        Me.LblRegTotalNeto = New DevExpress.XtraEditors.LabelControl()
        Me.LblRegRetencionMonto = New DevExpress.XtraEditors.LabelControl()
        Me.LblRegItemID = New DevExpress.XtraEditors.LabelControl()
        Me.TxtRegRetencionID = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TxtRegItemID = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TxtRegRetencionMonto = New DevExpress.XtraEditors.CalcEdit()
        Me.TxtRegTotalNeto = New DevExpress.XtraEditors.CalcEdit()
        Me.XTTRegPagina2 = New DevExpress.XtraTab.XtraTabPage()
        Me.LblRegDescrip1 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtRegDescrip1 = New DevExpress.XtraEditors.MemoEdit()
        Me.TxtRegItemsXDFID = New DevExpress.XtraEditors.TextEdit()
        Me.LblProdXFactID = New DevExpress.XtraEditors.LabelControl()
        Me.GrdItems = New DevExpress.XtraGrid.GridControl()
        Me.GrdVwItems = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ItemsxDFID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PCTEncabezado = New DevExpress.XtraEditors.PanelControl()
        Me.lblEstado = New DevExpress.XtraEditors.LabelControl()
        Me.LblCodigoValor = New DevExpress.XtraEditors.LabelControl()
        Me.LblCodigoRotulo = New DevExpress.XtraEditors.LabelControl()
        Me.LblAccion = New DevExpress.XtraEditors.LabelControl()
        Me.XTTDatos = New DevExpress.XtraTab.XtraTabControl()
        Me.XTPEncBasico = New DevExpress.XtraTab.XtraTabPage()
        Me.CmbBuscarFacturas = New DevExpress.XtraEditors.SimpleButton()
        Me.CmbGenerarAutoRetenciones = New DevExpress.XtraEditors.SimpleButton()
        Me.LblFechaEmisionComp = New DevExpress.XtraEditors.LabelControl()
        Me.TxtNumComprobante = New DevExpress.XtraEditors.TextEdit()
        Me.LblNumComprobante = New DevExpress.XtraEditors.LabelControl()
        Me.TxtCAIComprobante = New DevExpress.XtraEditors.TextEdit()
        Me.LblComentario = New DevExpress.XtraEditors.LabelControl()
        Me.LblCAIComprobante = New DevExpress.XtraEditors.LabelControl()
        Me.TxtDescripcion = New DevExpress.XtraEditors.TextEdit()
        Me.LblDescripcion = New DevExpress.XtraEditors.LabelControl()
        Me.TxtDFNum = New DevExpress.XtraEditors.TextEdit()
        Me.LblSdN = New DevExpress.XtraEditors.LabelControl()
        Me.LblFecha = New DevExpress.XtraEditors.LabelControl()
        Me.LblDFNum = New DevExpress.XtraEditors.LabelControl()
        Me.TxtSdNCodigo = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GLEClientes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TxtFecha = New DevExpress.XtraEditors.DateEdit()
        Me.TxtFechaEmisionComp = New DevExpress.XtraEditors.DateEdit()
        Me.XTPEncAvanzado = New DevExpress.XtraTab.XtraTabPage()
        Me.memoTxtInfoExtra = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LblMonedaCodigo = New DevExpress.XtraEditors.LabelControl()
        Me.TxtMonedaCodigo = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn42 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn43 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TxtConcepto = New DevExpress.XtraEditors.RadioGroup()
        Me.LblEmpresaCodigo = New DevExpress.XtraEditors.LabelControl()
        Me.TxtCAI = New DevExpress.XtraEditors.TextEdit()
        Me.LblTipoDoctoID = New DevExpress.XtraEditors.LabelControl()
        Me.LblDFID = New DevExpress.XtraEditors.LabelControl()
        Me.LblCAI = New DevExpress.XtraEditors.LabelControl()
        Me.TxtDFDescripID = New DevExpress.XtraEditors.TextEdit()
        Me.LblDFFactID = New DevExpress.XtraEditors.LabelControl()
        Me.TxtDFID = New DevExpress.XtraEditors.GridLookUpEdit()
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
        Me.TxtEmpresaCodigo = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn27 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TxtTiposDoctoID = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn40 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn41 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XTPEncTotales = New DevExpress.XtraTab.XtraTabPage()
        Me.LblTotalNeto = New DevExpress.XtraEditors.LabelControl()
        Me.TxtTotalNeto = New DevExpress.XtraEditors.CalcEdit()
        Me.TlSNotas = New System.Windows.Forms.ToolStrip()
        Me.CmbGrabarNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CmbGrabarSalir = New System.Windows.Forms.ToolStripButton()
        Me.CmbRegresarConsulta = New System.Windows.Forms.ToolStripButton()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.XTTEmpaginacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTTEmpaginacion.SuspendLayout()
        Me.XTTPagina1.SuspendLayout()
        CType(Me.GrdConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdConsultaView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSelector, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenu.SuspendLayout()
        Me.XTTPagina2.SuspendLayout()
        Me.GrpRegistro.SuspendLayout()
        CType(Me.XTTDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTTDetalle.SuspendLayout()
        Me.XTTRegPagina1.SuspendLayout()
        CType(Me.TxtRegTotalBruto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtRegImptoCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtRegImptoMonto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtRegRetencionID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtRegItemID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtRegRetencionMonto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtRegTotalNeto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTTRegPagina2.SuspendLayout()
        CType(Me.TxtRegDescrip1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtRegItemsXDFID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdVwItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCTEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PCTEncabezado.SuspendLayout()
        CType(Me.XTTDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTTDatos.SuspendLayout()
        Me.XTPEncBasico.SuspendLayout()
        CType(Me.TxtNumComprobante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCAIComprobante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDFNum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSdNCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GLEClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFechaEmisionComp.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFechaEmisionComp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTPEncAvanzado.SuspendLayout()
        CType(Me.memoTxtInfoExtra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMonedaCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtConcepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCAI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDFDescripID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDFID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtEmpresaCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTiposDoctoID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTPEncTotales.SuspendLayout()
        CType(Me.TxtTotalNeto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TlSNotas.SuspendLayout()
        Me.SuspendLayout()
        '
        'XTTEmpaginacion
        '
        Me.XTTEmpaginacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XTTEmpaginacion.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.XTTEmpaginacion.Location = New System.Drawing.Point(12, 12)
        Me.XTTEmpaginacion.Name = "XTTEmpaginacion"
        Me.XTTEmpaginacion.SelectedTabPage = Me.XTTPagina1
        Me.XTTEmpaginacion.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[False]
        Me.XTTEmpaginacion.Size = New System.Drawing.Size(826, 549)
        Me.XTTEmpaginacion.TabIndex = 12
        Me.XTTEmpaginacion.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XTTPagina1, Me.XTTPagina2})
        '
        'XTTPagina1
        '
        Me.XTTPagina1.Controls.Add(Me.GrdConsulta)
        Me.XTTPagina1.Controls.Add(Me.tsMenu)
        Me.XTTPagina1.Name = "XTTPagina1"
        Me.XTTPagina1.Size = New System.Drawing.Size(820, 543)
        '
        'GrdConsulta
        '
        Me.GrdConsulta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdConsulta.Location = New System.Drawing.Point(0, 56)
        Me.GrdConsulta.MainView = Me.GrdConsultaView
        Me.GrdConsulta.Name = "GrdConsulta"
        Me.GrdConsulta.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.chkSelector})
        Me.GrdConsulta.Size = New System.Drawing.Size(820, 484)
        Me.GrdConsulta.TabIndex = 11
        Me.GrdConsulta.Tag = "0"
        Me.GrdConsulta.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GrdConsultaView})
        '
        'GrdConsultaView
        '
        Me.GrdConsultaView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSelector, Me.colDFDescripID, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn4})
        Me.GrdConsultaView.GridControl = Me.GrdConsulta
        Me.GrdConsultaView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "ProdCodigo", Me.GridColumn1, "###,###", 0)})
        Me.GrdConsultaView.Name = "GrdConsultaView"
        Me.GrdConsultaView.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GrdConsultaView.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GrdConsultaView.OptionsView.ShowAutoFilterRow = True
        Me.GrdConsultaView.OptionsView.ShowFooter = True
        Me.GrdConsultaView.OptionsView.ShowGroupPanel = False
        '
        'colSelector
        '
        Me.colSelector.Caption = "Seleccionar"
        Me.colSelector.ColumnEdit = Me.chkSelector
        Me.colSelector.FieldName = "Seleccionar"
        Me.colSelector.Name = "colSelector"
        Me.colSelector.Visible = True
        Me.colSelector.VisibleIndex = 0
        '
        'chkSelector
        '
        Me.chkSelector.AutoHeight = False
        Me.chkSelector.Caption = "Check"
        Me.chkSelector.Name = "chkSelector"
        '
        'colDFDescripID
        '
        Me.colDFDescripID.Caption = "DFDescripID"
        Me.colDFDescripID.FieldName = "DFDescripID"
        Me.colDFDescripID.Name = "colDFDescripID"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Documento Fuente"
        Me.GridColumn1.FieldName = "DFNum"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Fecha"
        Me.GridColumn2.FieldName = "Fecha"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Cliente"
        Me.GridColumn3.FieldName = "SdNCodigo"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Descripcion"
        Me.GridColumn16.FieldName = "Descripcion"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.OptionsColumn.AllowEdit = False
        Me.GridColumn16.OptionsColumn.ReadOnly = True
        Me.GridColumn16.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 4
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Estado"
        Me.GridColumn17.FieldName = "EstadoDescripcion"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.OptionsColumn.AllowEdit = False
        Me.GridColumn17.OptionsColumn.ReadOnly = True
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 5
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Creado por"
        Me.GridColumn18.FieldName = "UsuCreador"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.OptionsColumn.AllowEdit = False
        Me.GridColumn18.OptionsColumn.ReadOnly = True
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 7
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Total Neto"
        Me.GridColumn4.FieldName = "TotalNeto"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 6
        '
        'tsMenu
        '
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CmbNuevo, Me.ToolStripSeparator1, Me.CmbEditar, Me.CmbActualizarConsulta, Me.ToolStripSeparator3, Me.CmbImprimir, Me.CmbAnular, Me.ToolStripSeparator4, Me.lblTipoProcesoImpresion, Me.CmbOpcImpresion, Me.lblFrecuenciaImpresion, Me.txtFrecuenciaImpresion, Me.lblTituloSegundos, Me.ToolStripSeparator6, Me.CmbSelectorTodos, Me.CmbQuitarSelector, Me.ToolStripSeparator5})
        Me.tsMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(820, 53)
        Me.tsMenu.TabIndex = 10
        Me.tsMenu.Tag = "0"
        '
        'CmbNuevo
        '
        Me.CmbNuevo.AutoSize = False
        Me.CmbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmbNuevo.Enabled = False
        Me.CmbNuevo.Image = Global.ConsolaProgramas.My.Resources.Resources.page
        Me.CmbNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmbNuevo.Name = "CmbNuevo"
        Me.CmbNuevo.Size = New System.Drawing.Size(50, 50)
        Me.CmbNuevo.Tag = "2"
        Me.CmbNuevo.Text = "Nuevo documento"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 53)
        '
        'CmbEditar
        '
        Me.CmbEditar.AutoSize = False
        Me.CmbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmbEditar.Enabled = False
        Me.CmbEditar.Image = Global.ConsolaProgramas.My.Resources.Resources.page_edit
        Me.CmbEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmbEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmbEditar.Name = "CmbEditar"
        Me.CmbEditar.Size = New System.Drawing.Size(50, 50)
        Me.CmbEditar.Tag = "3"
        Me.CmbEditar.Text = "Editar documento"
        '
        'CmbActualizarConsulta
        '
        Me.CmbActualizarConsulta.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.CmbActualizarConsulta.AutoSize = False
        Me.CmbActualizarConsulta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmbActualizarConsulta.Enabled = False
        Me.CmbActualizarConsulta.Image = Global.ConsolaProgramas.My.Resources.Resources.arrow_refresh1
        Me.CmbActualizarConsulta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmbActualizarConsulta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmbActualizarConsulta.Name = "CmbActualizarConsulta"
        Me.CmbActualizarConsulta.Size = New System.Drawing.Size(50, 50)
        Me.CmbActualizarConsulta.Tag = "1"
        Me.CmbActualizarConsulta.Text = "Actualizar Consulta"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 53)
        '
        'CmbImprimir
        '
        Me.CmbImprimir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.CmbImprimir.AutoSize = False
        Me.CmbImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmbImprimir.Enabled = False
        Me.CmbImprimir.Image = Global.ConsolaProgramas.My.Resources.Resources.printer
        Me.CmbImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmbImprimir.Name = "CmbImprimir"
        Me.CmbImprimir.Size = New System.Drawing.Size(50, 50)
        Me.CmbImprimir.Tag = "6"
        Me.CmbImprimir.Text = "Imprimir documento"
        '
        'CmbAnular
        '
        Me.CmbAnular.AutoSize = False
        Me.CmbAnular.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmbAnular.Enabled = False
        Me.CmbAnular.Image = Global.ConsolaProgramas.My.Resources.Resources.layout_delete
        Me.CmbAnular.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmbAnular.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmbAnular.Name = "CmbAnular"
        Me.CmbAnular.Size = New System.Drawing.Size(50, 50)
        Me.CmbAnular.Tag = "8"
        Me.CmbAnular.Text = "Anular documento"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 53)
        '
        'lblTipoProcesoImpresion
        '
        Me.lblTipoProcesoImpresion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblTipoProcesoImpresion.Name = "lblTipoProcesoImpresion"
        Me.lblTipoProcesoImpresion.Size = New System.Drawing.Size(116, 50)
        Me.lblTipoProcesoImpresion.Text = "Proceso Impresión:"
        '
        'CmbOpcImpresion
        '
        Me.CmbOpcImpresion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbOpcImpresion.DropDownWidth = 150
        Me.CmbOpcImpresion.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CmbOpcImpresion.IntegralHeight = False
        Me.CmbOpcImpresion.Items.AddRange(New Object() {"Una fila", "Multiples filas"})
        Me.CmbOpcImpresion.Name = "CmbOpcImpresion"
        Me.CmbOpcImpresion.Size = New System.Drawing.Size(150, 53)
        '
        'lblFrecuenciaImpresion
        '
        Me.lblFrecuenciaImpresion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblFrecuenciaImpresion.Name = "lblFrecuenciaImpresion"
        Me.lblFrecuenciaImpresion.Size = New System.Drawing.Size(52, 50)
        Me.lblFrecuenciaImpresion.Text = "Tiempo:"
        '
        'txtFrecuenciaImpresion
        '
        Me.txtFrecuenciaImpresion.MaxLength = 1
        Me.txtFrecuenciaImpresion.Name = "txtFrecuenciaImpresion"
        Me.txtFrecuenciaImpresion.Size = New System.Drawing.Size(40, 53)
        Me.txtFrecuenciaImpresion.Text = "1"
        '
        'lblTituloSegundos
        '
        Me.lblTituloSegundos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblTituloSegundos.Name = "lblTituloSegundos"
        Me.lblTituloSegundos.Size = New System.Drawing.Size(31, 50)
        Me.lblTituloSegundos.Text = "Seg."
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 53)
        '
        'CmbSelectorTodos
        '
        Me.CmbSelectorTodos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmbSelectorTodos.Enabled = False
        Me.CmbSelectorTodos.Image = Global.ConsolaProgramas.My.Resources.Resources.wishlist_add
        Me.CmbSelectorTodos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmbSelectorTodos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmbSelectorTodos.Name = "CmbSelectorTodos"
        Me.CmbSelectorTodos.Size = New System.Drawing.Size(36, 50)
        Me.CmbSelectorTodos.Text = "Seleccionar Todos"
        '
        'CmbQuitarSelector
        '
        Me.CmbQuitarSelector.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmbQuitarSelector.Enabled = False
        Me.CmbQuitarSelector.Image = Global.ConsolaProgramas.My.Resources.Resources.application_side_boxes
        Me.CmbQuitarSelector.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmbQuitarSelector.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmbQuitarSelector.Name = "CmbQuitarSelector"
        Me.CmbQuitarSelector.Size = New System.Drawing.Size(36, 50)
        Me.CmbQuitarSelector.Text = "Quitar Todos"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 53)
        '
        'XTTPagina2
        '
        Me.XTTPagina2.Controls.Add(Me.CmbEliminarItem)
        Me.XTTPagina2.Controls.Add(Me.cmbModificarItem)
        Me.XTTPagina2.Controls.Add(Me.CmbNuevoItem)
        Me.XTTPagina2.Controls.Add(Me.GrpRegistro)
        Me.XTTPagina2.Controls.Add(Me.GrdItems)
        Me.XTTPagina2.Controls.Add(Me.PCTEncabezado)
        Me.XTTPagina2.Controls.Add(Me.XTTDatos)
        Me.XTTPagina2.Controls.Add(Me.TlSNotas)
        Me.XTTPagina2.Name = "XTTPagina2"
        Me.XTTPagina2.Size = New System.Drawing.Size(820, 543)
        Me.XTTPagina2.Text = "XtraTabPage2"
        '
        'CmbEliminarItem
        '
        Me.CmbEliminarItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbEliminarItem.Image = Global.ConsolaProgramas.My.Resources.Resources.delete1
        Me.CmbEliminarItem.Location = New System.Drawing.Point(710, 295)
        Me.CmbEliminarItem.Name = "CmbEliminarItem"
        Me.CmbEliminarItem.Size = New System.Drawing.Size(50, 50)
        Me.CmbEliminarItem.TabIndex = 7
        Me.CmbEliminarItem.ToolTip = "Eliminar item"
        '
        'cmbModificarItem
        '
        Me.cmbModificarItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbModificarItem.Image = Global.ConsolaProgramas.My.Resources.Resources.script_edit
        Me.cmbModificarItem.Location = New System.Drawing.Point(710, 351)
        Me.cmbModificarItem.Name = "cmbModificarItem"
        Me.cmbModificarItem.Size = New System.Drawing.Size(50, 50)
        Me.cmbModificarItem.TabIndex = 8
        Me.cmbModificarItem.ToolTip = "Modificar item"
        '
        'CmbNuevoItem
        '
        Me.CmbNuevoItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbNuevoItem.Image = Global.ConsolaProgramas.My.Resources.Resources.add
        Me.CmbNuevoItem.Location = New System.Drawing.Point(710, 239)
        Me.CmbNuevoItem.Name = "CmbNuevoItem"
        Me.CmbNuevoItem.Size = New System.Drawing.Size(50, 50)
        Me.CmbNuevoItem.TabIndex = 6
        Me.CmbNuevoItem.ToolTip = "Agregar item"
        '
        'GrpRegistro
        '
        Me.GrpRegistro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpRegistro.Controls.Add(Me.CmbRegCancelar)
        Me.GrpRegistro.Controls.Add(Me.CmbRegActualizar)
        Me.GrpRegistro.Controls.Add(Me.XTTDetalle)
        Me.GrpRegistro.Location = New System.Drawing.Point(4, 403)
        Me.GrpRegistro.Name = "GrpRegistro"
        Me.GrpRegistro.Size = New System.Drawing.Size(755, 137)
        Me.GrpRegistro.TabIndex = 16
        Me.GrpRegistro.TabStop = False
        Me.GrpRegistro.Text = "Registro"
        Me.GrpRegistro.Visible = False
        '
        'CmbRegCancelar
        '
        Me.CmbRegCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbRegCancelar.Image = Global.ConsolaProgramas.My.Resources.Resources.arrow_undo
        Me.CmbRegCancelar.Location = New System.Drawing.Point(697, 76)
        Me.CmbRegCancelar.Name = "CmbRegCancelar"
        Me.CmbRegCancelar.Size = New System.Drawing.Size(50, 50)
        Me.CmbRegCancelar.TabIndex = 15
        Me.CmbRegCancelar.ToolTip = "Cancelar cambios"
        '
        'CmbRegActualizar
        '
        Me.CmbRegActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbRegActualizar.Image = Global.ConsolaProgramas.My.Resources.Resources.database_save
        Me.CmbRegActualizar.Location = New System.Drawing.Point(697, 20)
        Me.CmbRegActualizar.Name = "CmbRegActualizar"
        Me.CmbRegActualizar.Size = New System.Drawing.Size(50, 50)
        Me.CmbRegActualizar.TabIndex = 14
        Me.CmbRegActualizar.ToolTip = "Actualizar cambios"
        '
        'XTTDetalle
        '
        Me.XTTDetalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XTTDetalle.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Right
        Me.XTTDetalle.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal
        Me.XTTDetalle.Location = New System.Drawing.Point(8, 20)
        Me.XTTDetalle.Name = "XTTDetalle"
        Me.XTTDetalle.SelectedTabPage = Me.XTTRegPagina1
        Me.XTTDetalle.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[True]
        Me.XTTDetalle.Size = New System.Drawing.Size(683, 111)
        Me.XTTDetalle.TabIndex = 0
        Me.XTTDetalle.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XTTRegPagina1, Me.XTTRegPagina2})
        '
        'XTTRegPagina1
        '
        Me.XTTRegPagina1.Controls.Add(Me.LabelControl1)
        Me.XTTRegPagina1.Controls.Add(Me.LblRegTotalBruto)
        Me.XTTRegPagina1.Controls.Add(Me.TxtRegTotalBruto)
        Me.XTTRegPagina1.Controls.Add(Me.LblRegImptoMonto)
        Me.XTTRegPagina1.Controls.Add(Me.LblImptoCodigo)
        Me.XTTRegPagina1.Controls.Add(Me.TxtRegImptoCodigo)
        Me.XTTRegPagina1.Controls.Add(Me.TxtRegImptoMonto)
        Me.XTTRegPagina1.Controls.Add(Me.LblRegRetencionID)
        Me.XTTRegPagina1.Controls.Add(Me.LblRegTotalNeto)
        Me.XTTRegPagina1.Controls.Add(Me.LblRegRetencionMonto)
        Me.XTTRegPagina1.Controls.Add(Me.LblRegItemID)
        Me.XTTRegPagina1.Controls.Add(Me.TxtRegRetencionID)
        Me.XTTRegPagina1.Controls.Add(Me.TxtRegItemID)
        Me.XTTRegPagina1.Controls.Add(Me.TxtRegRetencionMonto)
        Me.XTTRegPagina1.Controls.Add(Me.TxtRegTotalNeto)
        Me.XTTRegPagina1.Name = "XTTRegPagina1"
        Me.XTTRegPagina1.Size = New System.Drawing.Size(595, 105)
        Me.XTTRegPagina1.Text = "Detalle"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Location = New System.Drawing.Point(312, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(308, 13)
        Me.LabelControl1.TabIndex = 26
        Me.LabelControl1.Text = "Para digtar la descripcion favor ir a Generalidades --->"
        '
        'LblRegTotalBruto
        '
        Me.LblRegTotalBruto.Location = New System.Drawing.Point(8, 86)
        Me.LblRegTotalBruto.Name = "LblRegTotalBruto"
        Me.LblRegTotalBruto.Size = New System.Drawing.Size(53, 13)
        Me.LblRegTotalBruto.TabIndex = 24
        Me.LblRegTotalBruto.Text = "Total Bruto"
        '
        'TxtRegTotalBruto
        '
        Me.TxtRegTotalBruto.Location = New System.Drawing.Point(68, 82)
        Me.TxtRegTotalBruto.Name = "TxtRegTotalBruto"
        Me.TxtRegTotalBruto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtRegTotalBruto.Properties.Mask.EditMask = "n"
        Me.TxtRegTotalBruto.Size = New System.Drawing.Size(237, 20)
        Me.TxtRegTotalBruto.TabIndex = 25
        '
        'LblRegImptoMonto
        '
        Me.LblRegImptoMonto.Location = New System.Drawing.Point(330, 60)
        Me.LblRegImptoMonto.Name = "LblRegImptoMonto"
        Me.LblRegImptoMonto.Size = New System.Drawing.Size(78, 13)
        Me.LblRegImptoMonto.TabIndex = 21
        Me.LblRegImptoMonto.Text = "Impuesto Monto"
        '
        'LblImptoCodigo
        '
        Me.LblImptoCodigo.Location = New System.Drawing.Point(8, 60)
        Me.LblImptoCodigo.Name = "LblImptoCodigo"
        Me.LblImptoCodigo.Size = New System.Drawing.Size(45, 13)
        Me.LblImptoCodigo.TabIndex = 20
        Me.LblImptoCodigo.Text = "Impuesto"
        '
        'TxtRegImptoCodigo
        '
        Me.TxtRegImptoCodigo.Location = New System.Drawing.Point(68, 56)
        Me.TxtRegImptoCodigo.Name = "TxtRegImptoCodigo"
        Me.TxtRegImptoCodigo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtRegImptoCodigo.Properties.NullText = ""
        Me.TxtRegImptoCodigo.Properties.View = Me.GridView7
        Me.TxtRegImptoCodigo.Size = New System.Drawing.Size(237, 20)
        Me.TxtRegImptoCodigo.TabIndex = 23
        '
        'GridView7
        '
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn23, Me.GridColumn24, Me.GridColumn25})
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GridView7.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridView7.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView7.OptionsView.ShowAutoFilterRow = True
        Me.GridView7.OptionsView.ShowGroupPanel = False
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "Código"
        Me.GridColumn23.FieldName = "TaxCat"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.OptionsColumn.AllowEdit = False
        Me.GridColumn23.OptionsColumn.ReadOnly = True
        Me.GridColumn23.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn23.Visible = True
        Me.GridColumn23.VisibleIndex = 0
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "Descripción"
        Me.GridColumn24.FieldName = "Description"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.OptionsColumn.AllowEdit = False
        Me.GridColumn24.OptionsColumn.ReadOnly = True
        Me.GridColumn24.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn24.Visible = True
        Me.GridColumn24.VisibleIndex = 1
        '
        'GridColumn25
        '
        Me.GridColumn25.Caption = "Porcentaje"
        Me.GridColumn25.FieldName = "Percentage"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.OptionsColumn.AllowEdit = False
        Me.GridColumn25.OptionsColumn.ReadOnly = True
        Me.GridColumn25.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn25.Visible = True
        Me.GridColumn25.VisibleIndex = 2
        '
        'TxtRegImptoMonto
        '
        Me.TxtRegImptoMonto.Location = New System.Drawing.Point(416, 56)
        Me.TxtRegImptoMonto.Name = "TxtRegImptoMonto"
        Me.TxtRegImptoMonto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtRegImptoMonto.Properties.Mask.EditMask = "n"
        Me.TxtRegImptoMonto.Properties.ReadOnly = True
        Me.TxtRegImptoMonto.Size = New System.Drawing.Size(161, 20)
        Me.TxtRegImptoMonto.TabIndex = 22
        '
        'LblRegRetencionID
        '
        Me.LblRegRetencionID.Location = New System.Drawing.Point(8, 32)
        Me.LblRegRetencionID.Name = "LblRegRetencionID"
        Me.LblRegRetencionID.Size = New System.Drawing.Size(48, 13)
        Me.LblRegRetencionID.TabIndex = 7
        Me.LblRegRetencionID.Text = "Retención"
        '
        'LblRegTotalNeto
        '
        Me.LblRegTotalNeto.Location = New System.Drawing.Point(330, 86)
        Me.LblRegTotalNeto.Name = "LblRegTotalNeto"
        Me.LblRegTotalNeto.Size = New System.Drawing.Size(50, 13)
        Me.LblRegTotalNeto.TabIndex = 5
        Me.LblRegTotalNeto.Text = "Total Neto"
        '
        'LblRegRetencionMonto
        '
        Me.LblRegRetencionMonto.Location = New System.Drawing.Point(330, 32)
        Me.LblRegRetencionMonto.Name = "LblRegRetencionMonto"
        Me.LblRegRetencionMonto.Size = New System.Drawing.Size(81, 13)
        Me.LblRegRetencionMonto.TabIndex = 5
        Me.LblRegRetencionMonto.Text = "Retención Monto"
        '
        'LblRegItemID
        '
        Me.LblRegItemID.Location = New System.Drawing.Point(8, 7)
        Me.LblRegItemID.Name = "LblRegItemID"
        Me.LblRegItemID.Size = New System.Drawing.Size(46, 13)
        Me.LblRegItemID.TabIndex = 5
        Me.LblRegItemID.Text = "Concepto"
        '
        'TxtRegRetencionID
        '
        Me.TxtRegRetencionID.Location = New System.Drawing.Point(68, 28)
        Me.TxtRegRetencionID.Name = "TxtRegRetencionID"
        Me.TxtRegRetencionID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtRegRetencionID.Properties.NullText = ""
        Me.TxtRegRetencionID.Properties.View = Me.GridLookUpEdit1View
        Me.TxtRegRetencionID.Size = New System.Drawing.Size(237, 20)
        Me.TxtRegRetencionID.TabIndex = 10
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn21, Me.GridColumn22})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GridLookUpEdit1View.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "Código"
        Me.GridColumn21.FieldName = "UnidMedCodigo"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.OptionsColumn.AllowEdit = False
        Me.GridColumn21.OptionsColumn.ReadOnly = True
        Me.GridColumn21.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 0
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "Descripción"
        Me.GridColumn22.FieldName = "Descripcion"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.OptionsColumn.AllowEdit = False
        Me.GridColumn22.OptionsColumn.ReadOnly = True
        Me.GridColumn22.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 1
        '
        'TxtRegItemID
        '
        Me.TxtRegItemID.Location = New System.Drawing.Point(68, 3)
        Me.TxtRegItemID.Name = "TxtRegItemID"
        Me.TxtRegItemID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtRegItemID.Properties.NullText = ""
        Me.TxtRegItemID.Properties.View = Me.GridView6
        Me.TxtRegItemID.Size = New System.Drawing.Size(237, 20)
        Me.TxtRegItemID.TabIndex = 9
        '
        'GridView6
        '
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn14, Me.GridColumn15})
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
        Me.GridColumn14.Caption = "Item"
        Me.GridColumn14.FieldName = "ItemID"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.AllowEdit = False
        Me.GridColumn14.OptionsColumn.ReadOnly = True
        Me.GridColumn14.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 0
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
        '
        'TxtRegRetencionMonto
        '
        Me.TxtRegRetencionMonto.Location = New System.Drawing.Point(416, 28)
        Me.TxtRegRetencionMonto.Name = "TxtRegRetencionMonto"
        Me.TxtRegRetencionMonto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtRegRetencionMonto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.TxtRegRetencionMonto.Properties.ReadOnly = True
        Me.TxtRegRetencionMonto.Size = New System.Drawing.Size(161, 20)
        Me.TxtRegRetencionMonto.TabIndex = 11
        '
        'TxtRegTotalNeto
        '
        Me.TxtRegTotalNeto.Location = New System.Drawing.Point(416, 82)
        Me.TxtRegTotalNeto.Name = "TxtRegTotalNeto"
        Me.TxtRegTotalNeto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtRegTotalNeto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.TxtRegTotalNeto.Properties.ReadOnly = True
        Me.TxtRegTotalNeto.Size = New System.Drawing.Size(161, 20)
        Me.TxtRegTotalNeto.TabIndex = 13
        '
        'XTTRegPagina2
        '
        Me.XTTRegPagina2.Controls.Add(Me.LblRegDescrip1)
        Me.XTTRegPagina2.Controls.Add(Me.TxtRegDescrip1)
        Me.XTTRegPagina2.Controls.Add(Me.TxtRegItemsXDFID)
        Me.XTTRegPagina2.Controls.Add(Me.LblProdXFactID)
        Me.XTTRegPagina2.Name = "XTTRegPagina2"
        Me.XTTRegPagina2.Size = New System.Drawing.Size(595, 105)
        Me.XTTRegPagina2.Text = "Generalidades"
        '
        'LblRegDescrip1
        '
        Me.LblRegDescrip1.Location = New System.Drawing.Point(3, 45)
        Me.LblRegDescrip1.Name = "LblRegDescrip1"
        Me.LblRegDescrip1.Size = New System.Drawing.Size(54, 13)
        Me.LblRegDescrip1.TabIndex = 21
        Me.LblRegDescrip1.Text = "Descripción"
        '
        'TxtRegDescrip1
        '
        Me.TxtRegDescrip1.Location = New System.Drawing.Point(65, 41)
        Me.TxtRegDescrip1.Name = "TxtRegDescrip1"
        Me.TxtRegDescrip1.Properties.MaxLength = 250
        Me.TxtRegDescrip1.Size = New System.Drawing.Size(387, 61)
        Me.TxtRegDescrip1.TabIndex = 20
        Me.TxtRegDescrip1.UseOptimizedRendering = True
        '
        'TxtRegItemsXDFID
        '
        Me.TxtRegItemsXDFID.Location = New System.Drawing.Point(65, 3)
        Me.TxtRegItemsXDFID.Name = "TxtRegItemsXDFID"
        Me.TxtRegItemsXDFID.Properties.ReadOnly = True
        Me.TxtRegItemsXDFID.Size = New System.Drawing.Size(166, 20)
        Me.TxtRegItemsXDFID.TabIndex = 16
        '
        'LblProdXFactID
        '
        Me.LblProdXFactID.Location = New System.Drawing.Point(5, 3)
        Me.LblProdXFactID.Name = "LblProdXFactID"
        Me.LblProdXFactID.Size = New System.Drawing.Size(48, 13)
        Me.LblProdXFactID.TabIndex = 7
        Me.LblProdXFactID.Text = "ID interno"
        '
        'GrdItems
        '
        Me.GrdItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdItems.Location = New System.Drawing.Point(4, 263)
        Me.GrdItems.MainView = Me.GrdVwItems
        Me.GrdItems.Name = "GrdItems"
        Me.GrdItems.Size = New System.Drawing.Size(691, 263)
        Me.GrdItems.TabIndex = 5
        Me.GrdItems.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GrdVwItems})
        '
        'GrdVwItems
        '
        Me.GrdVwItems.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ItemsxDFID, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11})
        Me.GrdVwItems.GridControl = Me.GrdItems
        Me.GrdVwItems.Name = "GrdVwItems"
        Me.GrdVwItems.OptionsView.ShowGroupPanel = False
        '
        'ItemsxDFID
        '
        Me.ItemsxDFID.Caption = "ItemsxDFID"
        Me.ItemsxDFID.FieldName = "ItemsxDFID"
        Me.ItemsxDFID.Name = "ItemsxDFID"
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Concepto"
        Me.GridColumn7.FieldName = "ItemID"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 0
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Descripción"
        Me.GridColumn8.FieldName = "Descripcion1"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 1
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Total Bruto"
        Me.GridColumn9.FieldName = "TotalBruto"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 2
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Impuesto"
        Me.GridColumn10.FieldName = "ImpuestoMonto"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 3
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Retención"
        Me.GridColumn11.FieldName = "RetencionMonto"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 4
        '
        'PCTEncabezado
        '
        Me.PCTEncabezado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PCTEncabezado.Controls.Add(Me.lblEstado)
        Me.PCTEncabezado.Controls.Add(Me.LblCodigoValor)
        Me.PCTEncabezado.Controls.Add(Me.LblCodigoRotulo)
        Me.PCTEncabezado.Controls.Add(Me.LblAccion)
        Me.PCTEncabezado.Location = New System.Drawing.Point(4, 57)
        Me.PCTEncabezado.Name = "PCTEncabezado"
        Me.PCTEncabezado.Size = New System.Drawing.Size(808, 24)
        Me.PCTEncabezado.TabIndex = 13
        '
        'lblEstado
        '
        Me.lblEstado.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblEstado.Location = New System.Drawing.Point(662, 5)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(61, 13)
        Me.lblEstado.TabIndex = 4
        Me.lblEstado.Text = "En proceso"
        '
        'LblCodigoValor
        '
        Me.LblCodigoValor.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblCodigoValor.Location = New System.Drawing.Point(228, 6)
        Me.LblCodigoValor.Name = "LblCodigoValor"
        Me.LblCodigoValor.Size = New System.Drawing.Size(82, 13)
        Me.LblCodigoValor.TabIndex = 2
        Me.LblCodigoValor.Text = "<NuevoValor>"
        '
        'LblCodigoRotulo
        '
        Me.LblCodigoRotulo.Location = New System.Drawing.Point(150, 6)
        Me.LblCodigoRotulo.Name = "LblCodigoRotulo"
        Me.LblCodigoRotulo.Size = New System.Drawing.Size(37, 13)
        Me.LblCodigoRotulo.TabIndex = 1
        Me.LblCodigoRotulo.Text = "Código:"
        '
        'LblAccion
        '
        Me.LblAccion.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblAccion.Location = New System.Drawing.Point(8, 6)
        Me.LblAccion.Name = "LblAccion"
        Me.LblAccion.Size = New System.Drawing.Size(37, 13)
        Me.LblAccion.TabIndex = 0
        Me.LblAccion.Text = "Acción"
        '
        'XTTDatos
        '
        Me.XTTDatos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XTTDatos.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom
        Me.XTTDatos.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal
        Me.XTTDatos.Location = New System.Drawing.Point(4, 87)
        Me.XTTDatos.Name = "XTTDatos"
        Me.XTTDatos.SelectedTabPage = Me.XTPEncBasico
        Me.XTTDatos.Size = New System.Drawing.Size(813, 170)
        Me.XTTDatos.TabIndex = 12
        Me.XTTDatos.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XTPEncBasico, Me.XTPEncAvanzado, Me.XTPEncTotales})
        '
        'XTPEncBasico
        '
        Me.XTPEncBasico.Controls.Add(Me.CmbBuscarFacturas)
        Me.XTPEncBasico.Controls.Add(Me.CmbGenerarAutoRetenciones)
        Me.XTPEncBasico.Controls.Add(Me.LblFechaEmisionComp)
        Me.XTPEncBasico.Controls.Add(Me.TxtNumComprobante)
        Me.XTPEncBasico.Controls.Add(Me.LblNumComprobante)
        Me.XTPEncBasico.Controls.Add(Me.TxtCAIComprobante)
        Me.XTPEncBasico.Controls.Add(Me.LblComentario)
        Me.XTPEncBasico.Controls.Add(Me.LblCAIComprobante)
        Me.XTPEncBasico.Controls.Add(Me.TxtDescripcion)
        Me.XTPEncBasico.Controls.Add(Me.LblDescripcion)
        Me.XTPEncBasico.Controls.Add(Me.TxtDFNum)
        Me.XTPEncBasico.Controls.Add(Me.LblSdN)
        Me.XTPEncBasico.Controls.Add(Me.LblFecha)
        Me.XTPEncBasico.Controls.Add(Me.LblDFNum)
        Me.XTPEncBasico.Controls.Add(Me.TxtSdNCodigo)
        Me.XTPEncBasico.Controls.Add(Me.TxtFecha)
        Me.XTPEncBasico.Controls.Add(Me.TxtFechaEmisionComp)
        Me.XTPEncBasico.Name = "XTPEncBasico"
        Me.XTPEncBasico.Size = New System.Drawing.Size(807, 142)
        Me.XTPEncBasico.Text = "Básico"
        '
        'CmbBuscarFacturas
        '
        Me.CmbBuscarFacturas.Enabled = False
        Me.CmbBuscarFacturas.Location = New System.Drawing.Point(661, 22)
        Me.CmbBuscarFacturas.Name = "CmbBuscarFacturas"
        Me.CmbBuscarFacturas.Size = New System.Drawing.Size(85, 23)
        Me.CmbBuscarFacturas.TabIndex = 104
        Me.CmbBuscarFacturas.Text = "Buscar Facturas"
        '
        'CmbGenerarAutoRetenciones
        '
        Me.CmbGenerarAutoRetenciones.Enabled = False
        Me.CmbGenerarAutoRetenciones.Location = New System.Drawing.Point(353, 87)
        Me.CmbGenerarAutoRetenciones.Name = "CmbGenerarAutoRetenciones"
        Me.CmbGenerarAutoRetenciones.Size = New System.Drawing.Size(302, 23)
        Me.CmbGenerarAutoRetenciones.TabIndex = 103
        Me.CmbGenerarAutoRetenciones.Text = "Generar Comp. de Retención a Facturas por Compras..."
        '
        'LblFechaEmisionComp
        '
        Me.LblFechaEmisionComp.Location = New System.Drawing.Point(353, 68)
        Me.LblFechaEmisionComp.Name = "LblFechaEmisionComp"
        Me.LblFechaEmisionComp.Size = New System.Drawing.Size(67, 13)
        Me.LblFechaEmisionComp.TabIndex = 102
        Me.LblFechaEmisionComp.Text = "Fecha emisión"
        '
        'TxtNumComprobante
        '
        Me.TxtNumComprobante.Location = New System.Drawing.Point(425, 22)
        Me.TxtNumComprobante.Name = "TxtNumComprobante"
        Me.TxtNumComprobante.Properties.MaxLength = 50
        Me.TxtNumComprobante.Size = New System.Drawing.Size(230, 20)
        Me.TxtNumComprobante.TabIndex = 101
        '
        'LblNumComprobante
        '
        Me.LblNumComprobante.Location = New System.Drawing.Point(353, 26)
        Me.LblNumComprobante.Name = "LblNumComprobante"
        Me.LblNumComprobante.Size = New System.Drawing.Size(37, 13)
        Me.LblNumComprobante.TabIndex = 102
        Me.LblNumComprobante.Text = "Número"
        '
        'TxtCAIComprobante
        '
        Me.TxtCAIComprobante.Location = New System.Drawing.Point(425, 43)
        Me.TxtCAIComprobante.Name = "TxtCAIComprobante"
        Me.TxtCAIComprobante.Properties.MaxLength = 50
        Me.TxtCAIComprobante.Size = New System.Drawing.Size(230, 20)
        Me.TxtCAIComprobante.TabIndex = 101
        '
        'LblComentario
        '
        Me.LblComentario.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblComentario.Location = New System.Drawing.Point(353, 3)
        Me.LblComentario.Name = "LblComentario"
        Me.LblComentario.Size = New System.Drawing.Size(168, 13)
        Me.LblComentario.TabIndex = 102
        Me.LblComentario.Text = "Comprobante al cual se aplica"
        '
        'LblCAIComprobante
        '
        Me.LblCAIComprobante.Location = New System.Drawing.Point(353, 47)
        Me.LblCAIComprobante.Name = "LblCAIComprobante"
        Me.LblCAIComprobante.Size = New System.Drawing.Size(18, 13)
        Me.LblCAIComprobante.TabIndex = 102
        Me.LblCAIComprobante.Text = "CAI"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(104, 46)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Properties.MaxLength = 50
        Me.TxtDescripcion.Size = New System.Drawing.Size(230, 20)
        Me.TxtDescripcion.TabIndex = 2
        '
        'LblDescripcion
        '
        Me.LblDescripcion.Location = New System.Drawing.Point(6, 50)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(54, 13)
        Me.LblDescripcion.TabIndex = 5
        Me.LblDescripcion.Text = "Descripción"
        '
        'TxtDFNum
        '
        Me.TxtDFNum.Location = New System.Drawing.Point(104, 2)
        Me.TxtDFNum.Name = "TxtDFNum"
        Me.TxtDFNum.Properties.ReadOnly = True
        Me.TxtDFNum.Size = New System.Drawing.Size(230, 20)
        Me.TxtDFNum.TabIndex = 100
        '
        'LblSdN
        '
        Me.LblSdN.Location = New System.Drawing.Point(6, 71)
        Me.LblSdN.Name = "LblSdN"
        Me.LblSdN.Size = New System.Drawing.Size(85, 13)
        Me.LblSdN.TabIndex = 2
        Me.LblSdN.Text = "Socio de negocios"
        '
        'LblFecha
        '
        Me.LblFecha.Location = New System.Drawing.Point(6, 28)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(29, 13)
        Me.LblFecha.TabIndex = 1
        Me.LblFecha.Text = "Fecha"
        '
        'LblDFNum
        '
        Me.LblDFNum.Location = New System.Drawing.Point(6, 6)
        Me.LblDFNum.Name = "LblDFNum"
        Me.LblDFNum.Size = New System.Drawing.Size(94, 13)
        Me.LblDFNum.TabIndex = 0
        Me.LblDFNum.Text = "Número de la forma"
        '
        'TxtSdNCodigo
        '
        Me.TxtSdNCodigo.Location = New System.Drawing.Point(104, 67)
        Me.TxtSdNCodigo.Name = "TxtSdNCodigo"
        Me.TxtSdNCodigo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtSdNCodigo.Properties.NullText = ""
        Me.TxtSdNCodigo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtSdNCodigo.Properties.View = Me.GLEClientes
        Me.TxtSdNCodigo.Size = New System.Drawing.Size(230, 20)
        Me.TxtSdNCodigo.TabIndex = 3
        '
        'GLEClientes
        '
        Me.GLEClientes.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn5, Me.GridColumn6, Me.GridColumn13, Me.GridColumn12})
        Me.GLEClientes.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GLEClientes.Name = "GLEClientes"
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
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Conocido como"
        Me.GridColumn13.FieldName = "KnownAsName"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.AllowEdit = False
        Me.GridColumn13.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 2
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Tipo"
        Me.GridColumn12.FieldName = "Tipo"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 3
        '
        'TxtFecha
        '
        Me.TxtFecha.EditValue = Nothing
        Me.TxtFecha.Location = New System.Drawing.Point(104, 24)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtFecha.Properties.Mask.EditMask = ""
        Me.TxtFecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.TxtFecha.Size = New System.Drawing.Size(230, 20)
        Me.TxtFecha.TabIndex = 1
        '
        'TxtFechaEmisionComp
        '
        Me.TxtFechaEmisionComp.EditValue = Nothing
        Me.TxtFechaEmisionComp.Location = New System.Drawing.Point(425, 64)
        Me.TxtFechaEmisionComp.Name = "TxtFechaEmisionComp"
        Me.TxtFechaEmisionComp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtFechaEmisionComp.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtFechaEmisionComp.Properties.Mask.EditMask = "g"
        Me.TxtFechaEmisionComp.Properties.MaxLength = 50
        Me.TxtFechaEmisionComp.Size = New System.Drawing.Size(230, 20)
        Me.TxtFechaEmisionComp.TabIndex = 101
        '
        'XTPEncAvanzado
        '
        Me.XTPEncAvanzado.Controls.Add(Me.memoTxtInfoExtra)
        Me.XTPEncAvanzado.Controls.Add(Me.LabelControl3)
        Me.XTPEncAvanzado.Controls.Add(Me.LblMonedaCodigo)
        Me.XTPEncAvanzado.Controls.Add(Me.TxtMonedaCodigo)
        Me.XTPEncAvanzado.Controls.Add(Me.TxtConcepto)
        Me.XTPEncAvanzado.Controls.Add(Me.LblEmpresaCodigo)
        Me.XTPEncAvanzado.Controls.Add(Me.TxtCAI)
        Me.XTPEncAvanzado.Controls.Add(Me.LblTipoDoctoID)
        Me.XTPEncAvanzado.Controls.Add(Me.LblDFID)
        Me.XTPEncAvanzado.Controls.Add(Me.LblCAI)
        Me.XTPEncAvanzado.Controls.Add(Me.TxtDFDescripID)
        Me.XTPEncAvanzado.Controls.Add(Me.LblDFFactID)
        Me.XTPEncAvanzado.Controls.Add(Me.TxtDFID)
        Me.XTPEncAvanzado.Controls.Add(Me.TxtEmpresaCodigo)
        Me.XTPEncAvanzado.Controls.Add(Me.TxtTiposDoctoID)
        Me.XTPEncAvanzado.Name = "XTPEncAvanzado"
        Me.XTPEncAvanzado.Size = New System.Drawing.Size(807, 142)
        Me.XTPEncAvanzado.Text = "Avanzado"
        '
        'memoTxtInfoExtra
        '
        Me.memoTxtInfoExtra.Location = New System.Drawing.Point(71, 75)
        Me.memoTxtInfoExtra.Name = "memoTxtInfoExtra"
        Me.memoTxtInfoExtra.Properties.MaxLength = 600
        Me.memoTxtInfoExtra.Size = New System.Drawing.Size(515, 56)
        Me.memoTxtInfoExtra.TabIndex = 37
        Me.memoTxtInfoExtra.UseOptimizedRendering = True
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(8, 74)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl3.TabIndex = 36
        Me.LabelControl3.Text = "Info. Extra:"
        '
        'LblMonedaCodigo
        '
        Me.LblMonedaCodigo.Location = New System.Drawing.Point(308, 55)
        Me.LblMonedaCodigo.Name = "LblMonedaCodigo"
        Me.LblMonedaCodigo.Size = New System.Drawing.Size(38, 13)
        Me.LblMonedaCodigo.TabIndex = 26
        Me.LblMonedaCodigo.Text = "Moneda"
        '
        'TxtMonedaCodigo
        '
        Me.TxtMonedaCodigo.Location = New System.Drawing.Point(405, 48)
        Me.TxtMonedaCodigo.Name = "TxtMonedaCodigo"
        Me.TxtMonedaCodigo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtMonedaCodigo.Properties.MaxLength = 50
        Me.TxtMonedaCodigo.Properties.NullText = ""
        Me.TxtMonedaCodigo.Properties.View = Me.GridView8
        Me.TxtMonedaCodigo.Size = New System.Drawing.Size(181, 20)
        Me.TxtMonedaCodigo.TabIndex = 25
        '
        'GridView8
        '
        Me.GridView8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn42, Me.GridColumn43})
        Me.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView8.OptionsView.ShowGroupPanel = False
        '
        'GridColumn42
        '
        Me.GridColumn42.Caption = "Moneda"
        Me.GridColumn42.FieldName = "MonedaCodigo"
        Me.GridColumn42.Name = "GridColumn42"
        Me.GridColumn42.Visible = True
        Me.GridColumn42.VisibleIndex = 0
        '
        'GridColumn43
        '
        Me.GridColumn43.Caption = "Descripcion"
        Me.GridColumn43.FieldName = "Descripcion"
        Me.GridColumn43.Name = "GridColumn43"
        Me.GridColumn43.Visible = True
        Me.GridColumn43.VisibleIndex = 1
        '
        'TxtConcepto
        '
        Me.TxtConcepto.AutoSizeInLayoutControl = True
        Me.TxtConcepto.EditValue = CType(4, Short)
        Me.TxtConcepto.Location = New System.Drawing.Point(308, 5)
        Me.TxtConcepto.Name = "TxtConcepto"
        Me.TxtConcepto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtConcepto.Properties.Columns = 4
        Me.TxtConcepto.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(1, Short), "Es Anulación"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(2, Short), "Es Devolución"), New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Es Descuento"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(4, Short), "Es otro concepto")})
        Me.TxtConcepto.Size = New System.Drawing.Size(484, 27)
        Me.TxtConcepto.TabIndex = 24
        '
        'LblEmpresaCodigo
        '
        Me.LblEmpresaCodigo.Location = New System.Drawing.Point(10, 29)
        Me.LblEmpresaCodigo.Name = "LblEmpresaCodigo"
        Me.LblEmpresaCodigo.Size = New System.Drawing.Size(41, 13)
        Me.LblEmpresaCodigo.TabIndex = 9
        Me.LblEmpresaCodigo.Text = "Empresa"
        '
        'TxtCAI
        '
        Me.TxtCAI.Location = New System.Drawing.Point(61, 48)
        Me.TxtCAI.Name = "TxtCAI"
        Me.TxtCAI.Properties.ReadOnly = True
        Me.TxtCAI.Size = New System.Drawing.Size(230, 20)
        Me.TxtCAI.TabIndex = 20
        '
        'LblTipoDoctoID
        '
        Me.LblTipoDoctoID.Location = New System.Drawing.Point(611, 55)
        Me.LblTipoDoctoID.Name = "LblTipoDoctoID"
        Me.LblTipoDoctoID.Size = New System.Drawing.Size(91, 13)
        Me.LblTipoDoctoID.TabIndex = 9
        Me.LblTipoDoctoID.Text = "Tipo de documento"
        '
        'LblDFID
        '
        Me.LblDFID.Location = New System.Drawing.Point(611, 97)
        Me.LblDFID.Name = "LblDFID"
        Me.LblDFID.Size = New System.Drawing.Size(91, 13)
        Me.LblDFID.TabIndex = 9
        Me.LblDFID.Text = "Documento Fuente"
        '
        'LblCAI
        '
        Me.LblCAI.Location = New System.Drawing.Point(10, 52)
        Me.LblCAI.Name = "LblCAI"
        Me.LblCAI.Size = New System.Drawing.Size(18, 13)
        Me.LblCAI.TabIndex = 9
        Me.LblCAI.Text = "CAI"
        '
        'TxtDFDescripID
        '
        Me.TxtDFDescripID.Location = New System.Drawing.Point(61, 3)
        Me.TxtDFDescripID.Name = "TxtDFDescripID"
        Me.TxtDFDescripID.Properties.ReadOnly = True
        Me.TxtDFDescripID.Size = New System.Drawing.Size(230, 20)
        Me.TxtDFDescripID.TabIndex = 8
        '
        'LblDFFactID
        '
        Me.LblDFFactID.Location = New System.Drawing.Point(10, 7)
        Me.LblDFFactID.Name = "LblDFFactID"
        Me.LblDFFactID.Size = New System.Drawing.Size(15, 13)
        Me.LblDFFactID.TabIndex = 7
        Me.LblDFFactID.Text = "ID."
        '
        'TxtDFID
        '
        Me.TxtDFID.Location = New System.Drawing.Point(611, 111)
        Me.TxtDFID.Name = "TxtDFID"
        Me.TxtDFID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtDFID.Properties.NullText = ""
        Me.TxtDFID.Properties.PopupFormSize = New System.Drawing.Size(1000, 500)
        Me.TxtDFID.Properties.View = Me.GridView4
        Me.TxtDFID.Size = New System.Drawing.Size(181, 20)
        Me.TxtDFID.TabIndex = 23
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
        'TxtEmpresaCodigo
        '
        Me.TxtEmpresaCodigo.Enabled = False
        Me.TxtEmpresaCodigo.Location = New System.Drawing.Point(61, 25)
        Me.TxtEmpresaCodigo.Name = "TxtEmpresaCodigo"
        Me.TxtEmpresaCodigo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtEmpresaCodigo.Properties.NullText = ""
        Me.TxtEmpresaCodigo.Properties.ReadOnly = True
        Me.TxtEmpresaCodigo.Properties.View = Me.GridView5
        Me.TxtEmpresaCodigo.Size = New System.Drawing.Size(230, 20)
        Me.TxtEmpresaCodigo.TabIndex = 5
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
        'TxtTiposDoctoID
        '
        Me.TxtTiposDoctoID.Location = New System.Drawing.Point(611, 74)
        Me.TxtTiposDoctoID.Name = "TxtTiposDoctoID"
        Me.TxtTiposDoctoID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtTiposDoctoID.Properties.NullText = ""
        Me.TxtTiposDoctoID.Properties.ReadOnly = True
        Me.TxtTiposDoctoID.Properties.View = Me.GridView1
        Me.TxtTiposDoctoID.Size = New System.Drawing.Size(181, 20)
        Me.TxtTiposDoctoID.TabIndex = 22
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
        'XTPEncTotales
        '
        Me.XTPEncTotales.Controls.Add(Me.LblTotalNeto)
        Me.XTPEncTotales.Controls.Add(Me.TxtTotalNeto)
        Me.XTPEncTotales.Name = "XTPEncTotales"
        Me.XTPEncTotales.Size = New System.Drawing.Size(807, 142)
        Me.XTPEncTotales.Text = "Totales"
        '
        'LblTotalNeto
        '
        Me.LblTotalNeto.Location = New System.Drawing.Point(6, 14)
        Me.LblTotalNeto.Name = "LblTotalNeto"
        Me.LblTotalNeto.Size = New System.Drawing.Size(81, 13)
        Me.LblTotalNeto.TabIndex = 5
        Me.LblTotalNeto.Text = "Total Documento"
        '
        'TxtTotalNeto
        '
        Me.TxtTotalNeto.Location = New System.Drawing.Point(103, 14)
        Me.TxtTotalNeto.Name = "TxtTotalNeto"
        Me.TxtTotalNeto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtTotalNeto.Properties.Mask.EditMask = "n2"
        Me.TxtTotalNeto.Properties.ReadOnly = True
        Me.TxtTotalNeto.Size = New System.Drawing.Size(230, 20)
        Me.TxtTotalNeto.TabIndex = 35
        '
        'TlSNotas
        '
        Me.TlSNotas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CmbGrabarNuevo, Me.ToolStripSeparator2, Me.CmbGrabarSalir, Me.CmbRegresarConsulta})
        Me.TlSNotas.Location = New System.Drawing.Point(0, 0)
        Me.TlSNotas.Name = "TlSNotas"
        Me.TlSNotas.Size = New System.Drawing.Size(820, 53)
        Me.TlSNotas.TabIndex = 11
        '
        'CmbGrabarNuevo
        '
        Me.CmbGrabarNuevo.AutoSize = False
        Me.CmbGrabarNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmbGrabarNuevo.Enabled = False
        Me.CmbGrabarNuevo.Image = Global.ConsolaProgramas.My.Resources.Resources.page_save
        Me.CmbGrabarNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmbGrabarNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmbGrabarNuevo.Name = "CmbGrabarNuevo"
        Me.CmbGrabarNuevo.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.CmbGrabarNuevo.Size = New System.Drawing.Size(50, 50)
        Me.CmbGrabarNuevo.Tag = "5"
        Me.CmbGrabarNuevo.Text = "Grabar y crear nuevo registro vacío"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 53)
        '
        'CmbGrabarSalir
        '
        Me.CmbGrabarSalir.AutoSize = False
        Me.CmbGrabarSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmbGrabarSalir.Enabled = False
        Me.CmbGrabarSalir.Image = Global.ConsolaProgramas.My.Resources.Resources.disk
        Me.CmbGrabarSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmbGrabarSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmbGrabarSalir.Name = "CmbGrabarSalir"
        Me.CmbGrabarSalir.Size = New System.Drawing.Size(50, 50)
        Me.CmbGrabarSalir.Tag = "5"
        Me.CmbGrabarSalir.Text = "Grabar cambios"
        '
        'CmbRegresarConsulta
        '
        Me.CmbRegresarConsulta.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.CmbRegresarConsulta.AutoSize = False
        Me.CmbRegresarConsulta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmbRegresarConsulta.Image = Global.ConsolaProgramas.My.Resources.Resources.arrow_rotate_clockwise
        Me.CmbRegresarConsulta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmbRegresarConsulta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmbRegresarConsulta.Name = "CmbRegresarConsulta"
        Me.CmbRegresarConsulta.Size = New System.Drawing.Size(50, 50)
        Me.CmbRegresarConsulta.Text = "Volver a la consulta"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'FinDFDescripFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 573)
        Me.Controls.Add(Me.XTTEmpaginacion)
        Me.Name = "FinDFDescripFrm"
        Me.Text = "Documentos Fuente:"
        CType(Me.XTTEmpaginacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTTEmpaginacion.ResumeLayout(False)
        Me.XTTPagina1.ResumeLayout(False)
        Me.XTTPagina1.PerformLayout()
        CType(Me.GrdConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdConsultaView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSelector, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.XTTPagina2.ResumeLayout(False)
        Me.XTTPagina2.PerformLayout()
        Me.GrpRegistro.ResumeLayout(False)
        CType(Me.XTTDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTTDetalle.ResumeLayout(False)
        Me.XTTRegPagina1.ResumeLayout(False)
        Me.XTTRegPagina1.PerformLayout()
        CType(Me.TxtRegTotalBruto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtRegImptoCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtRegImptoMonto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtRegRetencionID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtRegItemID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtRegRetencionMonto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtRegTotalNeto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTTRegPagina2.ResumeLayout(False)
        Me.XTTRegPagina2.PerformLayout()
        CType(Me.TxtRegDescrip1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtRegItemsXDFID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdVwItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCTEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PCTEncabezado.ResumeLayout(False)
        Me.PCTEncabezado.PerformLayout()
        CType(Me.XTTDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTTDatos.ResumeLayout(False)
        Me.XTPEncBasico.ResumeLayout(False)
        Me.XTPEncBasico.PerformLayout()
        CType(Me.TxtNumComprobante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCAIComprobante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDFNum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSdNCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GLEClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFechaEmisionComp.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFechaEmisionComp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTPEncAvanzado.ResumeLayout(False)
        Me.XTPEncAvanzado.PerformLayout()
        CType(Me.memoTxtInfoExtra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMonedaCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtConcepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCAI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDFDescripID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDFID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtEmpresaCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTiposDoctoID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTPEncTotales.ResumeLayout(False)
        Me.XTPEncTotales.PerformLayout()
        CType(Me.TxtTotalNeto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TlSNotas.ResumeLayout(False)
        Me.TlSNotas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XTTEmpaginacion As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XTTPagina1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GrdConsulta As DevExpress.XtraGrid.GridControl
    Friend WithEvents GrdConsultaView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDFDescripID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents CmbNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CmbEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents CmbActualizarConsulta As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CmbImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents CmbAnular As System.Windows.Forms.ToolStripButton
    Friend WithEvents XTTPagina2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents CmbEliminarItem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbModificarItem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CmbNuevoItem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GrpRegistro As System.Windows.Forms.GroupBox
    Friend WithEvents CmbRegCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CmbRegActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XTTDetalle As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XTTRegPagina1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LblRegRetencionID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblRegTotalNeto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblRegRetencionMonto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblRegItemID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtRegRetencionID As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TxtRegItemID As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TxtRegRetencionMonto As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents TxtRegTotalNeto As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents XTTRegPagina2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TxtRegItemsXDFID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblProdXFactID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GrdItems As DevExpress.XtraGrid.GridControl
    Friend WithEvents GrdVwItems As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ItemsxDFID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PCTEncabezado As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblEstado As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblCodigoValor As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblCodigoRotulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblAccion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XTTDatos As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XTPEncBasico As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TxtDescripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblDescripcion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtDFNum As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblSdN As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblFecha As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblDFNum As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtSdNCodigo As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GLEClientes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TxtFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents XTPEncAvanzado As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LblEmpresaCodigo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtCAI As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblTipoDoctoID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblDFID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblCAI As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtDFDescripID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblDFFactID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtDFID As DevExpress.XtraEditors.GridLookUpEdit
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
    Friend WithEvents TxtEmpresaCodigo As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn27 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TxtTiposDoctoID As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn40 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn41 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XTPEncTotales As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TlSNotas As System.Windows.Forms.ToolStrip
    Friend WithEvents CmbGrabarNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CmbGrabarSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents CmbRegresarConsulta As System.Windows.Forms.ToolStripButton
    Friend WithEvents LblTotalNeto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtTotalNeto As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LblRegTotalBruto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtRegTotalBruto As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LblRegImptoMonto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblImptoCodigo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtRegImptoCodigo As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TxtRegImptoMonto As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents TxtConcepto As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LblFechaEmisionComp As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtNumComprobante As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblNumComprobante As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtCAIComprobante As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblCAIComprobante As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblComentario As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtFechaEmisionComp As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LblMonedaCodigo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtMonedaCodigo As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn42 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn43 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LblRegDescrip1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtRegDescrip1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CmbGenerarAutoRetenciones As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CmbBuscarFacturas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblTipoProcesoImpresion As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CmbOpcImpresion As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents lblFrecuenciaImpresion As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtFrecuenciaImpresion As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents lblTituloSegundos As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CmbSelectorTodos As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CmbQuitarSelector As System.Windows.Forms.ToolStripButton
    Friend WithEvents colSelector As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkSelector As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents memoTxtInfoExtra As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class
