<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinEmpresasAnexoFrm
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
        Dim CmbRegActualizar As DevExpress.XtraEditors.SimpleButton
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FinEmpresasAnexoFrm))
        Dim CmbRegCancelar As DevExpress.XtraEditors.SimpleButton
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.XTTEmpaginacion = New DevExpress.XtraTab.XtraTabControl()
        Me.XTTPagina1 = New DevExpress.XtraTab.XtraTabPage()
        Me.GrdConsulta = New DevExpress.XtraGrid.GridControl()
        Me.GrdConsultaView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLogoEmpresa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.CmbEditar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CmbNuevo = New System.Windows.Forms.ToolStripButton()
        Me.CmbActualizarConsulta = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CmbEliminar = New System.Windows.Forms.ToolStripButton()
        Me.XTTPagina2 = New DevExpress.XtraTab.XtraTabPage()
        Me.PCTEncabezado = New DevExpress.XtraEditors.PanelControl()
        Me.LblCodigoValor = New DevExpress.XtraEditors.LabelControl()
        Me.LblCodigoRotulo = New DevExpress.XtraEditors.LabelControl()
        Me.LblAccion = New DevExpress.XtraEditors.LabelControl()
        Me.XTTDatos = New DevExpress.XtraTab.XtraTabControl()
        Me.XTPBasico = New DevExpress.XtraTab.XtraTabPage()
        Me.gbxInfo = New DevExpress.XtraEditors.GroupControl()
        Me.memoTxtNotaDoc1 = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LblDireccion = New DevExpress.XtraEditors.LabelControl()
        Me.CmbCargaLogo = New System.Windows.Forms.Button()
        Me.txtPathLogo = New DevExpress.XtraEditors.TextEdit()
        Me.LblPathLogo = New DevExpress.XtraEditors.LabelControl()
        Me.TxtRetencionID = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Código = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Descripción = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LblRTN = New DevExpress.XtraEditors.LabelControl()
        Me.lblFDA = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblRetencion = New DevExpress.XtraEditors.LabelControl()
        Me.LblLogoEmpresa = New DevExpress.XtraEditors.LabelControl()
        Me.TxtDireccion = New DevExpress.XtraEditors.TextEdit()
        Me.TxtEmailCliente1 = New DevExpress.XtraEditors.TextEdit()
        Me.TxtRTN = New DevExpress.XtraEditors.TextEdit()
        Me.LblEmailCliente1 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtFDA = New DevExpress.XtraEditors.TextEdit()
        Me.TxtTelCliente1 = New DevExpress.XtraEditors.TextEdit()
        Me.LblTelCliente1 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtDescription = New DevExpress.XtraEditors.TextEdit()
        Me.TxtEmpresaCodigo = New DevExpress.XtraEditors.TextEdit()
        Me.LblDescripcion = New DevExpress.XtraEditors.LabelControl()
        Me.lblComentario = New DevExpress.XtraEditors.LabelControl()
        Me.LblEmpresaCodigo = New DevExpress.XtraEditors.LabelControl()
        Me.XTPConfiguracion = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbAnular = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbModificarItem = New DevExpress.XtraEditors.SimpleButton()
        Me.CmbNuevoItem = New DevExpress.XtraEditors.SimpleButton()
        Me.GrdDetalle = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TipoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrdItems = New DevExpress.XtraGrid.GridControl()
        Me.GrdVwItems = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.CmbGrabarNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CmbGrabarSalir = New System.Windows.Forms.ToolStripButton()
        Me.CmbRegresarConsulta = New System.Windows.Forms.ToolStripButton()
        Me.XTTPagina3 = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LblCai = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.lblAccionCAI = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.dtRecepcion = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.GrpRegistro = New System.Windows.Forms.GroupBox()
        Me.XTTDetalle = New DevExpress.XtraTab.XtraTabControl()
        Me.XTTRegPagina1 = New DevExpress.XtraTab.XtraTabPage()
        Me.chk = New System.Windows.Forms.CheckBox()
        Me.txtPrefijo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPunto = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.cbxTipo = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtIni = New DevExpress.XtraEditors.TextEdit()
        Me.txtFina = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSoli = New DevExpress.XtraEditors.TextEdit()
        Me.txtOtor = New DevExpress.XtraEditors.TextEdit()
        Me.lblOrtorgado = New DevExpress.XtraEditors.LabelControl()
        Me.lblSolicitado = New DevExpress.XtraEditors.LabelControl()
        Me.lblTipo = New DevExpress.XtraEditors.LabelControl()
        Me.btnDeleteDetail = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEditDetail = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDetail = New DevExpress.XtraEditors.SimpleButton()
        Me.gcDet = New DevExpress.XtraGrid.GridControl()
        Me.GvDet = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtDeclaracion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.dtFecha = New DevExpress.XtraEditors.DateEdit()
        Me.txtCAI = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LblTP = New DevExpress.XtraEditors.LabelControl()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.SaveCAI = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CmbRegActualizar = New DevExpress.XtraEditors.SimpleButton()
        CmbRegCancelar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XTTEmpaginacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTTEmpaginacion.SuspendLayout()
        Me.XTTPagina1.SuspendLayout()
        CType(Me.GrdConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdConsultaView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenu.SuspendLayout()
        Me.XTTPagina2.SuspendLayout()
        CType(Me.PCTEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PCTEncabezado.SuspendLayout()
        CType(Me.XTTDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTTDatos.SuspendLayout()
        Me.XTPBasico.SuspendLayout()
        CType(Me.gbxInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxInfo.SuspendLayout()
        CType(Me.memoTxtNotaDoc1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPathLogo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtRetencionID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDireccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtEmailCliente1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtRTN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFDA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTelCliente1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtEmpresaCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTPConfiguracion.SuspendLayout()
        CType(Me.GrdDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdVwItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.XTTPagina3.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.dtRecepcion.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtRecepcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpRegistro.SuspendLayout()
        CType(Me.XTTDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTTDetalle.SuspendLayout()
        Me.XTTRegPagina1.SuspendLayout()
        CType(Me.txtPrefijo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPunto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIni.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFina.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSoli.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOtor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcDet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvDet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDeclaracion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCAI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CmbRegActualizar
        '
        CmbRegActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CmbRegActualizar.Image = CType(resources.GetObject("CmbRegActualizar.Image"), System.Drawing.Image)
        CmbRegActualizar.Location = New System.Drawing.Point(557, 20)
        CmbRegActualizar.Name = "CmbRegActualizar"
        CmbRegActualizar.Size = New System.Drawing.Size(50, 50)
        CmbRegActualizar.TabIndex = 17
        CmbRegActualizar.ToolTip = "Actualizar cambios"
        AddHandler CmbRegActualizar.Click, AddressOf Me.CmbRegActualizar_Click
        '
        'CmbRegCancelar
        '
        CmbRegCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CmbRegCancelar.Image = CType(resources.GetObject("CmbRegCancelar.Image"), System.Drawing.Image)
        CmbRegCancelar.Location = New System.Drawing.Point(557, 76)
        CmbRegCancelar.Name = "CmbRegCancelar"
        CmbRegCancelar.Size = New System.Drawing.Size(50, 50)
        CmbRegCancelar.TabIndex = 18
        CmbRegCancelar.ToolTip = "Cancelar cambios"
        AddHandler CmbRegCancelar.Click, AddressOf Me.CmbRegCancelar_Click
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        '
        'XTTEmpaginacion
        '
        Me.XTTEmpaginacion.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.XTTEmpaginacion.Location = New System.Drawing.Point(12, 12)
        Me.XTTEmpaginacion.Name = "XTTEmpaginacion"
        Me.XTTEmpaginacion.SelectedTabPage = Me.XTTPagina1
        Me.XTTEmpaginacion.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[False]
        Me.XTTEmpaginacion.Size = New System.Drawing.Size(689, 556)
        Me.XTTEmpaginacion.TabIndex = 15
        Me.XTTEmpaginacion.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XTTPagina1, Me.XTTPagina2, Me.XTTPagina3})
        '
        'XTTPagina1
        '
        Me.XTTPagina1.Controls.Add(Me.GrdConsulta)
        Me.XTTPagina1.Controls.Add(Me.tsMenu)
        Me.XTTPagina1.Name = "XTTPagina1"
        Me.XTTPagina1.Size = New System.Drawing.Size(683, 550)
        '
        'GrdConsulta
        '
        Me.GrdConsulta.Location = New System.Drawing.Point(0, 56)
        Me.GrdConsulta.MainView = Me.GrdConsultaView
        Me.GrdConsulta.Name = "GrdConsulta"
        Me.GrdConsulta.Size = New System.Drawing.Size(680, 484)
        Me.GrdConsulta.TabIndex = 11
        Me.GrdConsulta.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GrdConsultaView})
        '
        'GrdConsultaView
        '
        Me.GrdConsultaView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn6, Me.colLogoEmpresa})
        Me.GrdConsultaView.GridControl = Me.GrdConsulta
        Me.GrdConsultaView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "ProdCodigo", Me.GridColumn1, "###,###", 0)})
        Me.GrdConsultaView.Name = "GrdConsultaView"
        Me.GrdConsultaView.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GrdConsultaView.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GrdConsultaView.OptionsView.ShowAutoFilterRow = True
        Me.GrdConsultaView.OptionsView.ShowFooter = True
        Me.GrdConsultaView.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Codigo"
        Me.GridColumn1.FieldName = "EmpresaCodigo"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Nombre"
        Me.GridColumn2.FieldName = "Description"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Teléfono"
        Me.GridColumn3.FieldName = "Telefono"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "RTN"
        Me.GridColumn6.FieldName = "RTN"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 3
        '
        'colLogoEmpresa
        '
        Me.colLogoEmpresa.Caption = "LogoEmpresa"
        Me.colLogoEmpresa.ColumnEdit = Me.RepositoryItemPictureEdit1
        Me.colLogoEmpresa.FieldName = "LogoEmpresa"
        Me.colLogoEmpresa.Name = "colLogoEmpresa"
        '
        'tsMenu
        '
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CmbEditar, Me.ToolStripSeparator1, Me.CmbNuevo, Me.CmbActualizarConsulta, Me.ToolStripSeparator3, Me.CmbEliminar})
        Me.tsMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(683, 53)
        Me.tsMenu.TabIndex = 10
        '
        'CmbEditar
        '
        Me.CmbEditar.AutoSize = False
        Me.CmbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmbEditar.Image = CType(resources.GetObject("CmbEditar.Image"), System.Drawing.Image)
        Me.CmbEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmbEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmbEditar.Name = "CmbEditar"
        Me.CmbEditar.Size = New System.Drawing.Size(50, 50)
        Me.CmbEditar.Text = "Editar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 53)
        '
        'CmbNuevo
        '
        Me.CmbNuevo.AutoSize = False
        Me.CmbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmbNuevo.Image = CType(resources.GetObject("CmbNuevo.Image"), System.Drawing.Image)
        Me.CmbNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmbNuevo.Name = "CmbNuevo"
        Me.CmbNuevo.Size = New System.Drawing.Size(50, 50)
        Me.CmbNuevo.Text = "Nuevo"
        '
        'CmbActualizarConsulta
        '
        Me.CmbActualizarConsulta.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.CmbActualizarConsulta.AutoSize = False
        Me.CmbActualizarConsulta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmbActualizarConsulta.Image = CType(resources.GetObject("CmbActualizarConsulta.Image"), System.Drawing.Image)
        Me.CmbActualizarConsulta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmbActualizarConsulta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmbActualizarConsulta.Name = "CmbActualizarConsulta"
        Me.CmbActualizarConsulta.Size = New System.Drawing.Size(50, 50)
        Me.CmbActualizarConsulta.Text = "Actualizar Consulta"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 53)
        '
        'CmbEliminar
        '
        Me.CmbEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.CmbEliminar.AutoSize = False
        Me.CmbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmbEliminar.Enabled = False
        Me.CmbEliminar.Image = CType(resources.GetObject("CmbEliminar.Image"), System.Drawing.Image)
        Me.CmbEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmbEliminar.Name = "CmbEliminar"
        Me.CmbEliminar.Size = New System.Drawing.Size(50, 50)
        Me.CmbEliminar.Text = "Eliminar"
        '
        'XTTPagina2
        '
        Me.XTTPagina2.Controls.Add(Me.PCTEncabezado)
        Me.XTTPagina2.Controls.Add(Me.XTTDatos)
        Me.XTTPagina2.Controls.Add(Me.ToolStrip1)
        Me.XTTPagina2.Name = "XTTPagina2"
        Me.XTTPagina2.Size = New System.Drawing.Size(683, 550)
        Me.XTTPagina2.Text = "XtraTabPage2"
        '
        'PCTEncabezado
        '
        Me.PCTEncabezado.Controls.Add(Me.LblCodigoValor)
        Me.PCTEncabezado.Controls.Add(Me.LblCodigoRotulo)
        Me.PCTEncabezado.Controls.Add(Me.LblAccion)
        Me.PCTEncabezado.Location = New System.Drawing.Point(4, 57)
        Me.PCTEncabezado.Name = "PCTEncabezado"
        Me.PCTEncabezado.Size = New System.Drawing.Size(755, 48)
        Me.PCTEncabezado.TabIndex = 13
        '
        'LblCodigoValor
        '
        Me.LblCodigoValor.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblCodigoValor.Location = New System.Drawing.Point(51, 26)
        Me.LblCodigoValor.Name = "LblCodigoValor"
        Me.LblCodigoValor.Size = New System.Drawing.Size(82, 13)
        Me.LblCodigoValor.TabIndex = 2
        Me.LblCodigoValor.Text = "<NuevoValor>"
        '
        'LblCodigoRotulo
        '
        Me.LblCodigoRotulo.Location = New System.Drawing.Point(8, 26)
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
        Me.XTTDatos.Location = New System.Drawing.Point(4, 111)
        Me.XTTDatos.Name = "XTTDatos"
        Me.XTTDatos.SelectedTabPage = Me.XTPBasico
        Me.XTTDatos.Size = New System.Drawing.Size(676, 437)
        Me.XTTDatos.TabIndex = 12
        Me.XTTDatos.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XTPBasico, Me.XTPConfiguracion})
        '
        'XTPBasico
        '
        Me.XTPBasico.Controls.Add(Me.gbxInfo)
        Me.XTPBasico.Controls.Add(Me.TxtDescription)
        Me.XTPBasico.Controls.Add(Me.TxtEmpresaCodigo)
        Me.XTPBasico.Controls.Add(Me.LblDescripcion)
        Me.XTPBasico.Controls.Add(Me.lblComentario)
        Me.XTPBasico.Controls.Add(Me.LblEmpresaCodigo)
        Me.XTPBasico.Name = "XTPBasico"
        Me.XTPBasico.Size = New System.Drawing.Size(670, 409)
        Me.XTPBasico.Text = "Básico"
        '
        'gbxInfo
        '
        Me.gbxInfo.Controls.Add(Me.memoTxtNotaDoc1)
        Me.gbxInfo.Controls.Add(Me.LabelControl3)
        Me.gbxInfo.Controls.Add(Me.LblDireccion)
        Me.gbxInfo.Controls.Add(Me.CmbCargaLogo)
        Me.gbxInfo.Controls.Add(Me.txtPathLogo)
        Me.gbxInfo.Controls.Add(Me.LblPathLogo)
        Me.gbxInfo.Controls.Add(Me.TxtRetencionID)
        Me.gbxInfo.Controls.Add(Me.LblRTN)
        Me.gbxInfo.Controls.Add(Me.lblFDA)
        Me.gbxInfo.Controls.Add(Me.PictureBox1)
        Me.gbxInfo.Controls.Add(Me.lblRetencion)
        Me.gbxInfo.Controls.Add(Me.LblLogoEmpresa)
        Me.gbxInfo.Controls.Add(Me.TxtDireccion)
        Me.gbxInfo.Controls.Add(Me.TxtEmailCliente1)
        Me.gbxInfo.Controls.Add(Me.TxtRTN)
        Me.gbxInfo.Controls.Add(Me.LblEmailCliente1)
        Me.gbxInfo.Controls.Add(Me.TxtFDA)
        Me.gbxInfo.Controls.Add(Me.TxtTelCliente1)
        Me.gbxInfo.Controls.Add(Me.LblTelCliente1)
        Me.gbxInfo.Enabled = False
        Me.gbxInfo.Location = New System.Drawing.Point(7, 78)
        Me.gbxInfo.Name = "gbxInfo"
        Me.gbxInfo.Size = New System.Drawing.Size(561, 323)
        Me.gbxInfo.TabIndex = 14
        Me.gbxInfo.Text = "Información"
        '
        'memoTxtNotaDoc1
        '
        Me.memoTxtNotaDoc1.Location = New System.Drawing.Point(277, 225)
        Me.memoTxtNotaDoc1.Name = "memoTxtNotaDoc1"
        Me.memoTxtNotaDoc1.Properties.MaxLength = 250
        Me.memoTxtNotaDoc1.Size = New System.Drawing.Size(267, 64)
        Me.memoTxtNotaDoc1.TabIndex = 15
        Me.memoTxtNotaDoc1.UseOptimizedRendering = True
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(276, 205)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl3.TabIndex = 14
        Me.LabelControl3.Text = "Nota Pie de Pag.:"
        '
        'LblDireccion
        '
        Me.LblDireccion.Location = New System.Drawing.Point(10, 34)
        Me.LblDireccion.Name = "LblDireccion"
        Me.LblDireccion.Size = New System.Drawing.Size(43, 13)
        Me.LblDireccion.TabIndex = 1
        Me.LblDireccion.Text = "Dirección"
        '
        'CmbCargaLogo
        '
        Me.CmbCargaLogo.Location = New System.Drawing.Point(276, 295)
        Me.CmbCargaLogo.Name = "CmbCargaLogo"
        Me.CmbCargaLogo.Size = New System.Drawing.Size(268, 23)
        Me.CmbCargaLogo.TabIndex = 11
        Me.CmbCargaLogo.Text = "Cargar"
        Me.CmbCargaLogo.UseVisualStyleBackColor = True
        '
        'txtPathLogo
        '
        Me.txtPathLogo.Location = New System.Drawing.Point(102, 292)
        Me.txtPathLogo.Name = "txtPathLogo"
        Me.txtPathLogo.Properties.ReadOnly = True
        Me.txtPathLogo.Size = New System.Drawing.Size(48, 20)
        Me.txtPathLogo.TabIndex = 12
        Me.txtPathLogo.Visible = False
        '
        'LblPathLogo
        '
        Me.LblPathLogo.Location = New System.Drawing.Point(70, 295)
        Me.LblPathLogo.Name = "LblPathLogo"
        Me.LblPathLogo.Size = New System.Drawing.Size(26, 13)
        Me.LblPathLogo.TabIndex = 13
        Me.LblPathLogo.Text = "Path:"
        Me.LblPathLogo.Visible = False
        '
        'TxtRetencionID
        '
        Me.TxtRetencionID.Location = New System.Drawing.Point(70, 170)
        Me.TxtRetencionID.Name = "TxtRetencionID"
        Me.TxtRetencionID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtRetencionID.Properties.NullText = ""
        Me.TxtRetencionID.Properties.View = Me.GridLookUpEdit1View
        Me.TxtRetencionID.Size = New System.Drawing.Size(474, 20)
        Me.TxtRetencionID.TabIndex = 8
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Código, Me.Descripción})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GridLookUpEdit1View.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'Código
        '
        Me.Código.Caption = "Codigo"
        Me.Código.FieldName = "RetencionID"
        Me.Código.Name = "Código"
        Me.Código.OptionsColumn.AllowEdit = False
        Me.Código.OptionsColumn.ReadOnly = True
        Me.Código.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Código.Visible = True
        Me.Código.VisibleIndex = 0
        '
        'Descripción
        '
        Me.Descripción.Caption = "Descripción"
        Me.Descripción.FieldName = "Descripcion"
        Me.Descripción.Name = "Descripción"
        Me.Descripción.OptionsColumn.AllowEdit = False
        Me.Descripción.OptionsColumn.ReadOnly = True
        Me.Descripción.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Descripción.Visible = True
        Me.Descripción.VisibleIndex = 1
        '
        'LblRTN
        '
        Me.LblRTN.Location = New System.Drawing.Point(10, 112)
        Me.LblRTN.Name = "LblRTN"
        Me.LblRTN.Size = New System.Drawing.Size(20, 13)
        Me.LblRTN.TabIndex = 1
        Me.LblRTN.Text = "RTN"
        '
        'lblFDA
        '
        Me.lblFDA.Location = New System.Drawing.Point(10, 142)
        Me.lblFDA.Name = "lblFDA"
        Me.lblFDA.Size = New System.Drawing.Size(20, 13)
        Me.lblFDA.TabIndex = 1
        Me.lblFDA.Text = "FDA"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(70, 205)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 113)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'lblRetencion
        '
        Me.lblRetencion.Location = New System.Drawing.Point(10, 173)
        Me.lblRetencion.Name = "lblRetencion"
        Me.lblRetencion.Size = New System.Drawing.Size(48, 13)
        Me.lblRetencion.TabIndex = 1
        Me.lblRetencion.Text = "Retención"
        '
        'LblLogoEmpresa
        '
        Me.LblLogoEmpresa.Location = New System.Drawing.Point(10, 205)
        Me.LblLogoEmpresa.Name = "LblLogoEmpresa"
        Me.LblLogoEmpresa.Size = New System.Drawing.Size(27, 13)
        Me.LblLogoEmpresa.TabIndex = 9
        Me.LblLogoEmpresa.Text = "Logo:"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(70, 31)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(474, 20)
        Me.TxtDireccion.TabIndex = 3
        '
        'TxtEmailCliente1
        '
        Me.TxtEmailCliente1.Location = New System.Drawing.Point(70, 83)
        Me.TxtEmailCliente1.Name = "TxtEmailCliente1"
        Me.TxtEmailCliente1.Size = New System.Drawing.Size(474, 20)
        Me.TxtEmailCliente1.TabIndex = 5
        '
        'TxtRTN
        '
        Me.TxtRTN.Location = New System.Drawing.Point(70, 109)
        Me.TxtRTN.Name = "TxtRTN"
        Me.TxtRTN.Size = New System.Drawing.Size(474, 20)
        Me.TxtRTN.TabIndex = 6
        '
        'LblEmailCliente1
        '
        Me.LblEmailCliente1.Location = New System.Drawing.Point(10, 86)
        Me.LblEmailCliente1.Name = "LblEmailCliente1"
        Me.LblEmailCliente1.Size = New System.Drawing.Size(24, 13)
        Me.LblEmailCliente1.TabIndex = 1
        Me.LblEmailCliente1.Text = "Email"
        '
        'TxtFDA
        '
        Me.TxtFDA.Location = New System.Drawing.Point(70, 139)
        Me.TxtFDA.Name = "TxtFDA"
        Me.TxtFDA.Size = New System.Drawing.Size(474, 20)
        Me.TxtFDA.TabIndex = 7
        '
        'TxtTelCliente1
        '
        Me.TxtTelCliente1.Location = New System.Drawing.Point(70, 57)
        Me.TxtTelCliente1.Name = "TxtTelCliente1"
        Me.TxtTelCliente1.Size = New System.Drawing.Size(474, 20)
        Me.TxtTelCliente1.TabIndex = 4
        '
        'LblTelCliente1
        '
        Me.LblTelCliente1.Location = New System.Drawing.Point(10, 60)
        Me.LblTelCliente1.Name = "LblTelCliente1"
        Me.LblTelCliente1.Size = New System.Drawing.Size(42, 13)
        Me.LblTelCliente1.TabIndex = 1
        Me.LblTelCliente1.Text = "Teléfono"
        '
        'TxtDescription
        '
        Me.TxtDescription.Location = New System.Drawing.Point(67, 46)
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.Size = New System.Drawing.Size(501, 20)
        Me.TxtDescription.TabIndex = 2
        '
        'TxtEmpresaCodigo
        '
        Me.TxtEmpresaCodigo.Location = New System.Drawing.Point(67, 17)
        Me.TxtEmpresaCodigo.Name = "TxtEmpresaCodigo"
        Me.TxtEmpresaCodigo.Size = New System.Drawing.Size(230, 20)
        Me.TxtEmpresaCodigo.TabIndex = 1
        '
        'LblDescripcion
        '
        Me.LblDescripcion.Location = New System.Drawing.Point(7, 49)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(37, 13)
        Me.LblDescripcion.TabIndex = 1
        Me.LblDescripcion.Text = "Nombre"
        '
        'lblComentario
        '
        Me.lblComentario.Location = New System.Drawing.Point(313, 20)
        Me.lblComentario.Name = "lblComentario"
        Me.lblComentario.Size = New System.Drawing.Size(255, 13)
        Me.lblComentario.TabIndex = 0
        Me.lblComentario.Text = "*El código será buscado en la información de Protean"
        '
        'LblEmpresaCodigo
        '
        Me.LblEmpresaCodigo.Location = New System.Drawing.Point(7, 20)
        Me.LblEmpresaCodigo.Name = "LblEmpresaCodigo"
        Me.LblEmpresaCodigo.Size = New System.Drawing.Size(33, 13)
        Me.LblEmpresaCodigo.TabIndex = 0
        Me.LblEmpresaCodigo.Text = "Código"
        '
        'XTPConfiguracion
        '
        Me.XTPConfiguracion.Controls.Add(Me.LabelControl2)
        Me.XTPConfiguracion.Controls.Add(Me.LabelControl1)
        Me.XTPConfiguracion.Controls.Add(Me.cmbAnular)
        Me.XTPConfiguracion.Controls.Add(Me.cmbModificarItem)
        Me.XTPConfiguracion.Controls.Add(Me.CmbNuevoItem)
        Me.XTPConfiguracion.Controls.Add(Me.GrdDetalle)
        Me.XTPConfiguracion.Controls.Add(Me.GrdItems)
        Me.XTPConfiguracion.Name = "XTPConfiguracion"
        Me.XTPConfiguracion.PageVisible = False
        Me.XTPConfiguracion.Size = New System.Drawing.Size(670, 409)
        Me.XTPConfiguracion.Text = "Configuración"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(3, 240)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(286, 13)
        Me.LabelControl2.TabIndex = 12
        Me.LabelControl2.Text = "Detalle de límites otorgados para Codigos de AutoImpresión"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(3, 16)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(144, 13)
        Me.LabelControl1.TabIndex = 12
        Me.LabelControl1.Text = "Configuraciones por Empresa:"
        '
        'cmbAnular
        '
        Me.cmbAnular.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbAnular.Image = CType(resources.GetObject("cmbAnular.Image"), System.Drawing.Image)
        Me.cmbAnular.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmbAnular.Location = New System.Drawing.Point(617, 220)
        Me.cmbAnular.Name = "cmbAnular"
        Me.cmbAnular.Size = New System.Drawing.Size(50, 38)
        Me.cmbAnular.TabIndex = 10
        Me.cmbAnular.ToolTip = "Anulación de documento"
        '
        'cmbModificarItem
        '
        Me.cmbModificarItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbModificarItem.Image = CType(resources.GetObject("cmbModificarItem.Image"), System.Drawing.Image)
        Me.cmbModificarItem.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmbModificarItem.Location = New System.Drawing.Point(617, 4)
        Me.cmbModificarItem.Name = "cmbModificarItem"
        Me.cmbModificarItem.Size = New System.Drawing.Size(50, 38)
        Me.cmbModificarItem.TabIndex = 11
        Me.cmbModificarItem.ToolTip = "Modificar item"
        '
        'CmbNuevoItem
        '
        Me.CmbNuevoItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbNuevoItem.Image = CType(resources.GetObject("CmbNuevoItem.Image"), System.Drawing.Image)
        Me.CmbNuevoItem.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.CmbNuevoItem.Location = New System.Drawing.Point(565, 4)
        Me.CmbNuevoItem.Name = "CmbNuevoItem"
        Me.CmbNuevoItem.Size = New System.Drawing.Size(50, 38)
        Me.CmbNuevoItem.TabIndex = 9
        Me.CmbNuevoItem.ToolTip = "Agregar item"
        '
        'GrdDetalle
        '
        Me.GrdDetalle.Location = New System.Drawing.Point(3, 259)
        Me.GrdDetalle.MainView = Me.GridView1
        Me.GrdDetalle.Name = "GrdDetalle"
        Me.GrdDetalle.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.GrdDetalle.Size = New System.Drawing.Size(664, 147)
        Me.GrdDetalle.TabIndex = 6
        Me.GrdDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn5, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn11, Me.TipoID, Me.GridColumn17})
        Me.GridView1.GridControl = Me.GrdDetalle
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "DetConfigXEmpID"
        Me.GridColumn4.FieldName = "DetConfigXEmpID"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Punto de Emisión"
        Me.GridColumn5.FieldName = "PuntoEmision"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Tipo de Documento"
        Me.GridColumn13.FieldName = "TiposDoctoDescrip"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.AllowEdit = False
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 1
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Cantidad solicitada"
        Me.GridColumn14.FieldName = "CantSol"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.AllowEdit = False
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 2
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Inicial"
        Me.GridColumn15.FieldName = "NumInicial"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.AllowEdit = False
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 3
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Final"
        Me.GridColumn16.FieldName = "NumFinal"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.OptionsColumn.AllowEdit = False
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 4
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Número Actual"
        Me.GridColumn11.FieldName = "NumActual"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.OptionsColumn.ReadOnly = True
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 5
        '
        'TipoID
        '
        Me.TipoID.Caption = "GridColumn17"
        Me.TipoID.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.TipoID.FieldName = "TiposDoctoID"
        Me.TipoID.Name = "TipoID"
        Me.TipoID.OptionsColumn.AllowEdit = False
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Estado"
        Me.GridColumn17.FieldName = "Estado"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.OptionsColumn.AllowEdit = False
        Me.GridColumn17.OptionsColumn.ReadOnly = True
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 6
        '
        'GrdItems
        '
        Me.GrdItems.Location = New System.Drawing.Point(3, 46)
        Me.GrdItems.MainView = Me.GrdVwItems
        Me.GrdItems.Name = "GrdItems"
        Me.GrdItems.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.GrdItems.Size = New System.Drawing.Size(664, 169)
        Me.GrdItems.TabIndex = 6
        Me.GrdItems.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GrdVwItems})
        '
        'GrdVwItems
        '
        Me.GrdVwItems.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn12, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10})
        Me.GrdVwItems.GridControl = Me.GrdItems
        Me.GrdVwItems.Name = "GrdVwItems"
        Me.GrdVwItems.OptionsView.ShowGroupPanel = False
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "ConfigXEmpID"
        Me.GridColumn12.FieldName = "ConfigXEmpID"
        Me.GridColumn12.Name = "GridColumn12"
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "..."
        Me.GridColumn7.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GridColumn7.FieldName = "esActual"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 0
        Me.GridColumn7.Width = 20
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Actual"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "CAI"
        Me.GridColumn8.FieldName = "CAI"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 1
        Me.GridColumn8.Width = 217
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Fecha Límite"
        Me.GridColumn9.FieldName = "FechaLimite"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 2
        Me.GridColumn9.Width = 217
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Declaración"
        Me.GridColumn10.FieldName = "Declaracion"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 3
        Me.GridColumn10.Width = 219
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CmbGrabarNuevo, Me.ToolStripSeparator2, Me.CmbGrabarSalir, Me.CmbRegresarConsulta})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(683, 53)
        Me.ToolStrip1.TabIndex = 11
        '
        'CmbGrabarNuevo
        '
        Me.CmbGrabarNuevo.AutoSize = False
        Me.CmbGrabarNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmbGrabarNuevo.Image = CType(resources.GetObject("CmbGrabarNuevo.Image"), System.Drawing.Image)
        Me.CmbGrabarNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmbGrabarNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmbGrabarNuevo.Name = "CmbGrabarNuevo"
        Me.CmbGrabarNuevo.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.CmbGrabarNuevo.Size = New System.Drawing.Size(50, 50)
        Me.CmbGrabarNuevo.Text = "Grabar y crear nuevo registro"
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
        Me.CmbGrabarSalir.Image = CType(resources.GetObject("CmbGrabarSalir.Image"), System.Drawing.Image)
        Me.CmbGrabarSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmbGrabarSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmbGrabarSalir.Name = "CmbGrabarSalir"
        Me.CmbGrabarSalir.Size = New System.Drawing.Size(50, 50)
        Me.CmbGrabarSalir.Text = "Grabar cambios"
        '
        'CmbRegresarConsulta
        '
        Me.CmbRegresarConsulta.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.CmbRegresarConsulta.AutoSize = False
        Me.CmbRegresarConsulta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmbRegresarConsulta.Image = CType(resources.GetObject("CmbRegresarConsulta.Image"), System.Drawing.Image)
        Me.CmbRegresarConsulta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmbRegresarConsulta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmbRegresarConsulta.Name = "CmbRegresarConsulta"
        Me.CmbRegresarConsulta.Size = New System.Drawing.Size(50, 50)
        Me.CmbRegresarConsulta.Text = "Volver a la consulta"
        '
        'XTTPagina3
        '
        Me.XTTPagina3.Controls.Add(Me.PanelControl1)
        Me.XTTPagina3.Controls.Add(Me.XtraTabControl1)
        Me.XTTPagina3.Controls.Add(Me.ToolStrip2)
        Me.XTTPagina3.Name = "XTTPagina3"
        Me.XTTPagina3.Size = New System.Drawing.Size(683, 550)
        Me.XTTPagina3.Text = "XTTPagina3"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LblCai)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.lblAccionCAI)
        Me.PanelControl1.Location = New System.Drawing.Point(4, 57)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(671, 48)
        Me.PanelControl1.TabIndex = 16
        '
        'LblCai
        '
        Me.LblCai.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblCai.Location = New System.Drawing.Point(51, 26)
        Me.LblCai.Name = "LblCai"
        Me.LblCai.Size = New System.Drawing.Size(82, 13)
        Me.LblCai.TabIndex = 2
        Me.LblCai.Text = "<NuevoValor>"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(8, 26)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl5.TabIndex = 1
        Me.LabelControl5.Text = "Código:"
        '
        'lblAccionCAI
        '
        Me.lblAccionCAI.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblAccionCAI.Location = New System.Drawing.Point(8, 6)
        Me.lblAccionCAI.Name = "lblAccionCAI"
        Me.lblAccionCAI.Size = New System.Drawing.Size(37, 13)
        Me.lblAccionCAI.TabIndex = 0
        Me.lblAccionCAI.Text = "Acción"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(4, 111)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(676, 439)
        Me.XtraTabControl1.TabIndex = 15
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.dtRecepcion)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl10)
        Me.XtraTabPage1.Controls.Add(Me.GrpRegistro)
        Me.XtraTabPage1.Controls.Add(Me.btnDeleteDetail)
        Me.XtraTabPage1.Controls.Add(Me.btnEditDetail)
        Me.XtraTabPage1.Controls.Add(Me.btnDetail)
        Me.XtraTabPage1.Controls.Add(Me.gcDet)
        Me.XtraTabPage1.Controls.Add(Me.txtDeclaracion)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl4)
        Me.XtraTabPage1.Controls.Add(Me.dtFecha)
        Me.XtraTabPage1.Controls.Add(Me.txtCAI)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl11)
        Me.XtraTabPage1.Controls.Add(Me.LblTP)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(670, 411)
        Me.XtraTabPage1.Text = "Registro CAI"
        '
        'dtRecepcion
        '
        Me.dtRecepcion.EditValue = Nothing
        Me.dtRecepcion.Location = New System.Drawing.Point(421, 8)
        Me.dtRecepcion.Name = "dtRecepcion"
        Me.dtRecepcion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtRecepcion.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtRecepcion.Size = New System.Drawing.Size(99, 20)
        Me.dtRecepcion.TabIndex = 5
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(366, 11)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl10.TabIndex = 18
        Me.LabelControl10.Text = "Recepcion"
        '
        'GrpRegistro
        '
        Me.GrpRegistro.Controls.Add(CmbRegCancelar)
        Me.GrpRegistro.Controls.Add(CmbRegActualizar)
        Me.GrpRegistro.Controls.Add(Me.XTTDetalle)
        Me.GrpRegistro.Location = New System.Drawing.Point(7, 265)
        Me.GrpRegistro.Name = "GrpRegistro"
        Me.GrpRegistro.Size = New System.Drawing.Size(615, 146)
        Me.GrpRegistro.TabIndex = 17
        Me.GrpRegistro.TabStop = False
        Me.GrpRegistro.Text = "Registro"
        Me.GrpRegistro.Visible = False
        '
        'XTTDetalle
        '
        Me.XTTDetalle.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Right
        Me.XTTDetalle.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal
        Me.XTTDetalle.Location = New System.Drawing.Point(8, 20)
        Me.XTTDetalle.Name = "XTTDetalle"
        Me.XTTDetalle.SelectedTabPage = Me.XTTRegPagina1
        Me.XTTDetalle.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[True]
        Me.XTTDetalle.Size = New System.Drawing.Size(543, 116)
        Me.XTTDetalle.TabIndex = 0
        Me.XTTDetalle.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XTTRegPagina1})
        '
        'XTTRegPagina1
        '
        Me.XTTRegPagina1.Controls.Add(Me.chk)
        Me.XTTRegPagina1.Controls.Add(Me.txtPrefijo)
        Me.XTTRegPagina1.Controls.Add(Me.LabelControl9)
        Me.XTTRegPagina1.Controls.Add(Me.txtPunto)
        Me.XTTRegPagina1.Controls.Add(Me.LabelControl8)
        Me.XTTRegPagina1.Controls.Add(Me.cbxTipo)
        Me.XTTRegPagina1.Controls.Add(Me.txtIni)
        Me.XTTRegPagina1.Controls.Add(Me.txtFina)
        Me.XTTRegPagina1.Controls.Add(Me.LabelControl6)
        Me.XTTRegPagina1.Controls.Add(Me.LabelControl7)
        Me.XTTRegPagina1.Controls.Add(Me.txtSoli)
        Me.XTTRegPagina1.Controls.Add(Me.txtOtor)
        Me.XTTRegPagina1.Controls.Add(Me.lblOrtorgado)
        Me.XTTRegPagina1.Controls.Add(Me.lblSolicitado)
        Me.XTTRegPagina1.Controls.Add(Me.lblTipo)
        Me.XTTRegPagina1.Name = "XTTRegPagina1"
        Me.XTTRegPagina1.Size = New System.Drawing.Size(490, 110)
        Me.XTTRegPagina1.Text = "Detalle"
        '
        'chk
        '
        Me.chk.AutoSize = True
        Me.chk.Location = New System.Drawing.Point(331, 14)
        Me.chk.Name = "chk"
        Me.chk.Size = New System.Drawing.Size(136, 17)
        Me.chk.TabIndex = 16
        Me.chk.Text = "Establecer como actual"
        Me.chk.UseVisualStyleBackColor = True
        '
        'txtPrefijo
        '
        Me.txtPrefijo.Location = New System.Drawing.Point(362, 75)
        Me.txtPrefijo.Name = "txtPrefijo"
        Me.txtPrefijo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrefijo.Size = New System.Drawing.Size(99, 20)
        Me.txtPrefijo.TabIndex = 15
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(325, 77)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl9.TabIndex = 27
        Me.LabelControl9.Text = "Prefijo"
        '
        'txtPunto
        '
        Me.txtPunto.Location = New System.Drawing.Point(362, 43)
        Me.txtPunto.Name = "txtPunto"
        Me.txtPunto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPunto.Size = New System.Drawing.Size(99, 20)
        Me.txtPunto.TabIndex = 14
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(331, 45)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl8.TabIndex = 25
        Me.LabelControl8.Text = "Punto"
        '
        'cbxTipo
        '
        Me.cbxTipo.Location = New System.Drawing.Point(69, 11)
        Me.cbxTipo.Name = "cbxTipo"
        Me.cbxTipo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxTipo.Properties.NullText = ""
        Me.cbxTipo.Size = New System.Drawing.Size(244, 20)
        Me.cbxTipo.TabIndex = 9
        '
        'txtIni
        '
        Me.txtIni.Location = New System.Drawing.Point(214, 43)
        Me.txtIni.Name = "txtIni"
        Me.txtIni.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIni.Size = New System.Drawing.Size(99, 20)
        Me.txtIni.TabIndex = 12
        '
        'txtFina
        '
        Me.txtFina.Location = New System.Drawing.Point(214, 75)
        Me.txtFina.Name = "txtFina"
        Me.txtFina.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFina.Size = New System.Drawing.Size(99, 20)
        Me.txtFina.TabIndex = 13
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(183, 78)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl6.TabIndex = 21
        Me.LabelControl6.Text = "Final"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(183, 45)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl7.TabIndex = 20
        Me.LabelControl7.Text = "Inicial"
        '
        'txtSoli
        '
        Me.txtSoli.Location = New System.Drawing.Point(69, 42)
        Me.txtSoli.Name = "txtSoli"
        Me.txtSoli.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSoli.Size = New System.Drawing.Size(99, 20)
        Me.txtSoli.TabIndex = 10
        '
        'txtOtor
        '
        Me.txtOtor.Location = New System.Drawing.Point(69, 74)
        Me.txtOtor.Name = "txtOtor"
        Me.txtOtor.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOtor.Size = New System.Drawing.Size(99, 20)
        Me.txtOtor.TabIndex = 11
        '
        'lblOrtorgado
        '
        Me.lblOrtorgado.Location = New System.Drawing.Point(10, 77)
        Me.lblOrtorgado.Name = "lblOrtorgado"
        Me.lblOrtorgado.Size = New System.Drawing.Size(46, 13)
        Me.lblOrtorgado.TabIndex = 14
        Me.lblOrtorgado.Text = "Otorgado"
        '
        'lblSolicitado
        '
        Me.lblSolicitado.Location = New System.Drawing.Point(10, 44)
        Me.lblSolicitado.Name = "lblSolicitado"
        Me.lblSolicitado.Size = New System.Drawing.Size(45, 13)
        Me.lblSolicitado.TabIndex = 7
        Me.lblSolicitado.Text = "Solicitado"
        '
        'lblTipo
        '
        Me.lblTipo.Location = New System.Drawing.Point(10, 14)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(54, 13)
        Me.lblTipo.TabIndex = 5
        Me.lblTipo.Text = "Documento"
        '
        'btnDeleteDetail
        '
        Me.btnDeleteDetail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteDetail.Image = CType(resources.GetObject("btnDeleteDetail.Image"), System.Drawing.Image)
        Me.btnDeleteDetail.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnDeleteDetail.Location = New System.Drawing.Point(564, 188)
        Me.btnDeleteDetail.Name = "btnDeleteDetail"
        Me.btnDeleteDetail.Size = New System.Drawing.Size(58, 50)
        Me.btnDeleteDetail.TabIndex = 14
        Me.btnDeleteDetail.ToolTip = "Eliminar item"
        Me.btnDeleteDetail.Visible = False
        '
        'btnEditDetail
        '
        Me.btnEditDetail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditDetail.Image = CType(resources.GetObject("btnEditDetail.Image"), System.Drawing.Image)
        Me.btnEditDetail.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnEditDetail.Location = New System.Drawing.Point(564, 135)
        Me.btnEditDetail.Name = "btnEditDetail"
        Me.btnEditDetail.Size = New System.Drawing.Size(58, 50)
        Me.btnEditDetail.TabIndex = 8
        Me.btnEditDetail.ToolTip = "Modificar item"
        '
        'btnDetail
        '
        Me.btnDetail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDetail.Image = CType(resources.GetObject("btnDetail.Image"), System.Drawing.Image)
        Me.btnDetail.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnDetail.Location = New System.Drawing.Point(564, 82)
        Me.btnDetail.Name = "btnDetail"
        Me.btnDetail.Size = New System.Drawing.Size(58, 50)
        Me.btnDetail.TabIndex = 7
        Me.btnDetail.ToolTip = "Agregar item"
        '
        'gcDet
        '
        Me.gcDet.Location = New System.Drawing.Point(11, 68)
        Me.gcDet.MainView = Me.GvDet
        Me.gcDet.Name = "gcDet"
        Me.gcDet.Size = New System.Drawing.Size(547, 191)
        Me.gcDet.TabIndex = 19
        Me.gcDet.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvDet})
        '
        'GvDet
        '
        Me.GvDet.GridControl = Me.gcDet
        Me.GvDet.Name = "GvDet"
        Me.GvDet.OptionsBehavior.Editable = False
        Me.GvDet.OptionsCustomization.AllowFilter = False
        Me.GvDet.OptionsCustomization.AllowSort = False
        Me.GvDet.OptionsEditForm.EditFormColumnCount = 0
        Me.GvDet.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GvDet.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GvDet.OptionsView.ShowGroupPanel = False
        '
        'txtDeclaracion
        '
        Me.txtDeclaracion.Location = New System.Drawing.Point(72, 7)
        Me.txtDeclaracion.Name = "txtDeclaracion"
        Me.txtDeclaracion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDeclaracion.Size = New System.Drawing.Size(129, 20)
        Me.txtDeclaracion.TabIndex = 2
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(13, 10)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Declaración"
        '
        'dtFecha
        '
        Me.dtFecha.EditValue = Nothing
        Me.dtFecha.Location = New System.Drawing.Point(242, 7)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFecha.Size = New System.Drawing.Size(103, 20)
        Me.dtFecha.TabIndex = 4
        '
        'txtCAI
        '
        Me.txtCAI.Location = New System.Drawing.Point(72, 40)
        Me.txtCAI.Name = "txtCAI"
        Me.txtCAI.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCAI.Size = New System.Drawing.Size(448, 20)
        Me.txtCAI.TabIndex = 6
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(211, 11)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl11.TabIndex = 1
        Me.LabelControl11.Text = "Limite"
        '
        'LblTP
        '
        Me.LblTP.Location = New System.Drawing.Point(50, 43)
        Me.LblTP.Name = "LblTP"
        Me.LblTP.Size = New System.Drawing.Size(18, 13)
        Me.LblTP.TabIndex = 0
        Me.LblTP.Text = "CAI"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveCAI, Me.ToolStripButton3})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(683, 53)
        Me.ToolStrip2.TabIndex = 14
        '
        'SaveCAI
        '
        Me.SaveCAI.AutoSize = False
        Me.SaveCAI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveCAI.Image = CType(resources.GetObject("SaveCAI.Image"), System.Drawing.Image)
        Me.SaveCAI.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SaveCAI.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveCAI.Name = "SaveCAI"
        Me.SaveCAI.Size = New System.Drawing.Size(50, 50)
        Me.SaveCAI.Text = "Grabar cambios"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton3.AutoSize = False
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(50, 50)
        Me.ToolStripButton3.Text = "Volver a la consulta"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = """PNG files (*.png)|*.png|JPEG files (*.jpg)|*.jpg|GIF files (*.gif)|*.gif|All fil" & _
    "es (*.*)|*.*"""
        '
        'FinEmpresasAnexoFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 565)
        Me.Controls.Add(Me.XTTEmpaginacion)
        Me.Name = "FinEmpresasAnexoFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anexo de información de Empresas"
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XTTEmpaginacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTTEmpaginacion.ResumeLayout(False)
        Me.XTTPagina1.ResumeLayout(False)
        Me.XTTPagina1.PerformLayout()
        CType(Me.GrdConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdConsultaView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.XTTPagina2.ResumeLayout(False)
        Me.XTTPagina2.PerformLayout()
        CType(Me.PCTEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PCTEncabezado.ResumeLayout(False)
        Me.PCTEncabezado.PerformLayout()
        CType(Me.XTTDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTTDatos.ResumeLayout(False)
        Me.XTPBasico.ResumeLayout(False)
        Me.XTPBasico.PerformLayout()
        CType(Me.gbxInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxInfo.ResumeLayout(False)
        Me.gbxInfo.PerformLayout()
        CType(Me.memoTxtNotaDoc1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPathLogo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtRetencionID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDireccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtEmailCliente1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtRTN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFDA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTelCliente1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtEmpresaCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTPConfiguracion.ResumeLayout(False)
        Me.XTPConfiguracion.PerformLayout()
        CType(Me.GrdDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdVwItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.XTTPagina3.ResumeLayout(False)
        Me.XTTPagina3.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.dtRecepcion.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtRecepcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpRegistro.ResumeLayout(False)
        CType(Me.XTTDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTTDetalle.ResumeLayout(False)
        Me.XTTRegPagina1.ResumeLayout(False)
        Me.XTTRegPagina1.PerformLayout()
        CType(Me.txtPrefijo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPunto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIni.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFina.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSoli.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOtor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcDet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvDet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDeclaracion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCAI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XTTEmpaginacion As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XTTPagina1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GrdConsulta As DevExpress.XtraGrid.GridControl
    Friend WithEvents GrdConsultaView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents CmbEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CmbNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents CmbActualizarConsulta As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CmbEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents XTTPagina2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PCTEncabezado As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LblCodigoValor As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblCodigoRotulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblAccion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XTTDatos As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XTPBasico As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TxtEmailCliente1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblEmailCliente1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtTelCliente1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblTelCliente1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtRTN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtDireccion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblRTN As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblDireccion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtEmpresaCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblDescripcion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblComentario As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblEmpresaCodigo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents CmbGrabarNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CmbGrabarSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents CmbRegresarConsulta As System.Windows.Forms.ToolStripButton
    Friend WithEvents TxtFDA As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblFDA As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblRetencion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtRetencionID As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Código As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Descripción As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XTPConfiguracion As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GrdItems As DevExpress.XtraGrid.GridControl
    Friend WithEvents GrdVwItems As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbAnular As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbModificarItem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CmbNuevoItem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GrdDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents LblLogoEmpresa As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CmbCargaLogo As System.Windows.Forms.Button
    Friend WithEvents LblPathLogo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPathLogo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents colLogoEmpresa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gbxInfo As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents memoTxtNotaDoc1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents XTTPagina3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LblCai As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblAccionCAI As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents SaveCAI As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GrpRegistro As System.Windows.Forms.GroupBox
    Friend WithEvents XTTDetalle As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XTTRegPagina1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lblOrtorgado As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSolicitado As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTipo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnDeleteDetail As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditDetail As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDetail As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcDet As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvDet As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtDeclaracion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtCAI As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblTP As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSoli As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtOtor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtIni As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFina As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents cbxTipo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtPrefijo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPunto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtRecepcion As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chk As System.Windows.Forms.CheckBox
    Friend WithEvents TipoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
End Class
