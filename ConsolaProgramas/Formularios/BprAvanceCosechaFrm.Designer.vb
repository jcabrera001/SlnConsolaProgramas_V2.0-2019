<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BprAvanceCosechaFrm
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
        Me.components = New System.ComponentModel.Container()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BprAvanceCosechaFrm))
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.dgvDatos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcolOrdenCorte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolFrente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolFinca = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolLote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolFechaQuema = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolTiempoTranscurrido = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolViajes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolEnCampo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolEnTransito = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolEnPatio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolMolidas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolPorcentajeAvance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemNumPorAvance = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.gcolInactividad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolNumPorAvance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.repItemAvance = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemMarqueeProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar()
        Me.LayoutView1 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
        Me.gcolLiberacion = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_gcolLiberacion = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.gcolTonsEstimadas = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_gcolTonsEstimadas = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.LayoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
        Me.BandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gcolQuemaID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gcolxTonsEstimadas = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gcolAreaLiberada = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gcolDistancia = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gcolAreaPendiente = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gcolHoraQuema = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gcolMinutosViaje = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmbRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.cmbFrecuencia = New System.Windows.Forms.ToolStripButton()
        Me.cmbCambiarFecha = New System.Windows.Forms.ToolStripButton()
        Me.cmbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmbSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.gbxParametros = New DevExpress.XtraEditors.GroupControl()
        Me.SpinVisualizacion = New DevExpress.XtraEditors.SpinEdit()
        Me.lblTonsFecha2 = New DevExpress.XtraEditors.LabelControl()
        Me.lblContador = New System.Windows.Forms.Label()
        Me.lblAcumuladoDiario2 = New DevExpress.XtraEditors.LabelControl()
        Me.lblProyeccionDiaria2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFecha = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.lblFecha = New DevExpress.XtraEditors.LabelControl()
        Me.lblPeriodo = New DevExpress.XtraEditors.LabelControl()
        Me.cbxPeriodo = New System.Windows.Forms.ComboBox()
        Me.txtTonsFecha = New DevExpress.XtraEditors.TextEdit()
        Me.txtProyeccionDiaria = New DevExpress.XtraEditors.TextEdit()
        Me.txtAcumuladoDiario = New DevExpress.XtraEditors.TextEdit()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SplitControl = New DevExpress.XtraEditors.SplitContainerControl()
        Me.gbxDatosMolienda = New DevExpress.XtraEditors.GroupControl()
        Me.lblToneladasFecha = New DevExpress.XtraEditors.LabelControl()
        Me.LblProyeccionDiaria = New DevExpress.XtraEditors.LabelControl()
        Me.lblAcumuladoDiario = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemNumPorAvance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repItemAvance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMarqueeProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_gcolLiberacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_gcolTonsEstimadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenu.SuspendLayout()
        CType(Me.gbxParametros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxParametros.SuspendLayout()
        CType(Me.SpinVisualizacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTonsFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProyeccionDiaria.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAcumuladoDiario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitControl.SuspendLayout()
        CType(Me.gbxDatosMolienda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDatosMolienda.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AutoExpandAllGroups = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.GridColumn1.AppearanceHeader.Options.UseFont = True
        Me.GridColumn1.Caption = "Orden Corte"
        Me.GridColumn1.FieldName = "OrdenCorte"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.GridColumn2.AppearanceCell.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.Caption = "Toneladas Estimadas"
        Me.GridColumn2.FieldName = "TonsEstimadas"
        Me.GridColumn2.Image = Global.ConsolaProgramas.My.Resources.Resources.workspace
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 155
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.GridColumn3.AppearanceCell.Options.UseFont = True
        Me.GridColumn3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.GridColumn3.AppearanceHeader.Options.UseFont = True
        Me.GridColumn3.Caption = "Area Liberada"
        Me.GridColumn3.FieldName = "AreaLiberada"
        Me.GridColumn3.Image = Global.ConsolaProgramas.My.Resources.Resources.arrow_out
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 125
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.GridColumn4.AppearanceCell.Options.UseFont = True
        Me.GridColumn4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.GridColumn4.AppearanceHeader.Options.UseFont = True
        Me.GridColumn4.Caption = "Distancia"
        Me.GridColumn4.FieldName = "Distancia"
        Me.GridColumn4.Image = Global.ConsolaProgramas.My.Resources.Resources.zoom_extend
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        Me.GridColumn4.Width = 156
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.GridColumn5.AppearanceCell.Options.UseFont = True
        Me.GridColumn5.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.GridColumn5.AppearanceHeader.Options.UseFont = True
        Me.GridColumn5.Caption = "Area Pendiente"
        Me.GridColumn5.FieldName = "AreaPendiente"
        Me.GridColumn5.Image = Global.ConsolaProgramas.My.Resources.Resources.vector_delete
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        Me.GridColumn5.Width = 129
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.GridColumn6.AppearanceCell.Options.UseFont = True
        Me.GridColumn6.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.GridColumn6.AppearanceHeader.Options.UseFont = True
        Me.GridColumn6.Caption = "Hora Quema"
        Me.GridColumn6.FieldName = "HoraQuema"
        Me.GridColumn6.Image = Global.ConsolaProgramas.My.Resources.Resources.timeline
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
        Me.GridColumn6.Width = 174
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.GridColumn7.AppearanceCell.Options.UseFont = True
        Me.GridColumn7.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.GridColumn7.AppearanceHeader.Options.UseFont = True
        Me.GridColumn7.Caption = "Minutos Viaje"
        Me.GridColumn7.FieldName = "MinutosViaje"
        Me.GridColumn7.Image = Global.ConsolaProgramas.My.Resources.Resources.stopwatch_start
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 5
        Me.GridColumn7.Width = 267
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Enabled = False
        Me.GridControl1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        GridLevelNode1.LevelTemplate = Me.GridView1
        GridLevelNode1.RelationName = "Detalle"
        Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.dgvDatos
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repItemAvance, Me.RepositoryItemNumPorAvance, Me.RepositoryItemMarqueeProgressBar1, Me.RepositoryItemTextEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(1024, 287)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dgvDatos, Me.LayoutView1, Me.BandedGridView1, Me.GridView1})
        '
        'dgvDatos
        '
        Me.dgvDatos.Appearance.FocusedRow.Options.UseFont = True
        Me.dgvDatos.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 24.75!, System.Drawing.FontStyle.Bold)
        Me.dgvDatos.Appearance.Row.Options.UseFont = True
        Me.dgvDatos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcolOrdenCorte, Me.gcolFrente, Me.gcolFinca, Me.gcolLote, Me.gcolFechaQuema, Me.gcolTiempoTranscurrido, Me.gcolViajes, Me.gcolEnCampo, Me.gcolEnTransito, Me.gcolEnPatio, Me.gcolMolidas, Me.gcolPorcentajeAvance, Me.gcolInactividad, Me.gcolNumPorAvance})
        Me.dgvDatos.GridControl = Me.GridControl1
        Me.dgvDatos.GroupCount = 1
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.OptionsBehavior.AutoExpandAllGroups = True
        Me.dgvDatos.OptionsPrint.PrintDetails = True
        Me.dgvDatos.OptionsPrint.PrintFilterInfo = True
        Me.dgvDatos.OptionsView.ShowAutoFilterRow = True
        Me.dgvDatos.OptionsView.ShowFooter = True
        Me.dgvDatos.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.gcolFinca, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'gcolOrdenCorte
        '
        Me.gcolOrdenCorte.AppearanceCell.Options.UseTextOptions = True
        Me.gcolOrdenCorte.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcolOrdenCorte.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.gcolOrdenCorte.AppearanceHeader.Options.UseFont = True
        Me.gcolOrdenCorte.Caption = "Lib."
        Me.gcolOrdenCorte.FieldName = "OrdenCorte"
        Me.gcolOrdenCorte.Image = CType(resources.GetObject("gcolOrdenCorte.Image"), System.Drawing.Image)
        Me.gcolOrdenCorte.Name = "gcolOrdenCorte"
        Me.gcolOrdenCorte.OptionsColumn.AllowEdit = False
        Me.gcolOrdenCorte.OptionsColumn.ReadOnly = True
        Me.gcolOrdenCorte.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolOrdenCorte.Visible = True
        Me.gcolOrdenCorte.VisibleIndex = 0
        Me.gcolOrdenCorte.Width = 83
        '
        'gcolFrente
        '
        Me.gcolFrente.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.gcolFrente.AppearanceHeader.Options.UseFont = True
        Me.gcolFrente.Caption = "Frente"
        Me.gcolFrente.FieldName = "Frente"
        Me.gcolFrente.Image = CType(resources.GetObject("gcolFrente.Image"), System.Drawing.Image)
        Me.gcolFrente.Name = "gcolFrente"
        Me.gcolFrente.OptionsColumn.AllowEdit = False
        Me.gcolFrente.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolFrente.Visible = True
        Me.gcolFrente.VisibleIndex = 1
        Me.gcolFrente.Width = 36
        '
        'gcolFinca
        '
        Me.gcolFinca.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.gcolFinca.AppearanceHeader.Options.UseFont = True
        Me.gcolFinca.Caption = "Finca"
        Me.gcolFinca.FieldName = "Finca"
        Me.gcolFinca.Image = CType(resources.GetObject("gcolFinca.Image"), System.Drawing.Image)
        Me.gcolFinca.Name = "gcolFinca"
        Me.gcolFinca.OptionsColumn.AllowEdit = False
        Me.gcolFinca.OptionsColumn.ReadOnly = True
        Me.gcolFinca.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolFinca.Visible = True
        Me.gcolFinca.VisibleIndex = 2
        Me.gcolFinca.Width = 76
        '
        'gcolLote
        '
        Me.gcolLote.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.gcolLote.AppearanceHeader.Options.UseFont = True
        Me.gcolLote.Caption = "Lote"
        Me.gcolLote.FieldName = "Lote"
        Me.gcolLote.Image = CType(resources.GetObject("gcolLote.Image"), System.Drawing.Image)
        Me.gcolLote.Name = "gcolLote"
        Me.gcolLote.OptionsColumn.AllowEdit = False
        Me.gcolLote.OptionsColumn.ReadOnly = True
        Me.gcolLote.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolLote.Visible = True
        Me.gcolLote.VisibleIndex = 2
        Me.gcolLote.Width = 85
        '
        'gcolFechaQuema
        '
        Me.gcolFechaQuema.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.gcolFechaQuema.AppearanceHeader.Options.UseFont = True
        Me.gcolFechaQuema.Caption = "Quema"
        Me.gcolFechaQuema.FieldName = "FechaQuema"
        Me.gcolFechaQuema.Image = CType(resources.GetObject("gcolFechaQuema.Image"), System.Drawing.Image)
        Me.gcolFechaQuema.Name = "gcolFechaQuema"
        Me.gcolFechaQuema.OptionsColumn.AllowEdit = False
        Me.gcolFechaQuema.OptionsColumn.ReadOnly = True
        Me.gcolFechaQuema.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolFechaQuema.Visible = True
        Me.gcolFechaQuema.VisibleIndex = 3
        Me.gcolFechaQuema.Width = 67
        '
        'gcolTiempoTranscurrido
        '
        Me.gcolTiempoTranscurrido.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.gcolTiempoTranscurrido.AppearanceHeader.Options.UseFont = True
        Me.gcolTiempoTranscurrido.Caption = "T. Trans."
        Me.gcolTiempoTranscurrido.FieldName = "TiempoTranscurrido"
        Me.gcolTiempoTranscurrido.Image = CType(resources.GetObject("gcolTiempoTranscurrido.Image"), System.Drawing.Image)
        Me.gcolTiempoTranscurrido.Name = "gcolTiempoTranscurrido"
        Me.gcolTiempoTranscurrido.OptionsColumn.AllowEdit = False
        Me.gcolTiempoTranscurrido.OptionsColumn.ReadOnly = True
        Me.gcolTiempoTranscurrido.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolTiempoTranscurrido.Visible = True
        Me.gcolTiempoTranscurrido.VisibleIndex = 4
        Me.gcolTiempoTranscurrido.Width = 65
        '
        'gcolViajes
        '
        Me.gcolViajes.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.gcolViajes.AppearanceHeader.Options.UseFont = True
        Me.gcolViajes.Caption = "Viajes"
        Me.gcolViajes.FieldName = "Viajes"
        Me.gcolViajes.Image = CType(resources.GetObject("gcolViajes.Image"), System.Drawing.Image)
        Me.gcolViajes.Name = "gcolViajes"
        Me.gcolViajes.OptionsColumn.AllowEdit = False
        Me.gcolViajes.OptionsColumn.ReadOnly = True
        Me.gcolViajes.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolViajes.Visible = True
        Me.gcolViajes.VisibleIndex = 5
        Me.gcolViajes.Width = 38
        '
        'gcolEnCampo
        '
        Me.gcolEnCampo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.gcolEnCampo.AppearanceHeader.Options.UseFont = True
        Me.gcolEnCampo.Caption = "En Campo"
        Me.gcolEnCampo.FieldName = "EnCampo"
        Me.gcolEnCampo.Image = CType(resources.GetObject("gcolEnCampo.Image"), System.Drawing.Image)
        Me.gcolEnCampo.Name = "gcolEnCampo"
        Me.gcolEnCampo.OptionsColumn.AllowEdit = False
        Me.gcolEnCampo.OptionsColumn.ReadOnly = True
        Me.gcolEnCampo.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolEnCampo.Visible = True
        Me.gcolEnCampo.VisibleIndex = 6
        Me.gcolEnCampo.Width = 60
        '
        'gcolEnTransito
        '
        Me.gcolEnTransito.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.gcolEnTransito.AppearanceHeader.Options.UseFont = True
        Me.gcolEnTransito.Caption = "En Transito"
        Me.gcolEnTransito.FieldName = "EnTransito"
        Me.gcolEnTransito.Image = CType(resources.GetObject("gcolEnTransito.Image"), System.Drawing.Image)
        Me.gcolEnTransito.Name = "gcolEnTransito"
        Me.gcolEnTransito.OptionsColumn.AllowEdit = False
        Me.gcolEnTransito.OptionsColumn.ReadOnly = True
        Me.gcolEnTransito.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolEnTransito.Visible = True
        Me.gcolEnTransito.VisibleIndex = 7
        Me.gcolEnTransito.Width = 53
        '
        'gcolEnPatio
        '
        Me.gcolEnPatio.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.gcolEnPatio.AppearanceHeader.Options.UseFont = True
        Me.gcolEnPatio.Caption = "En Patio"
        Me.gcolEnPatio.FieldName = "EnPatio"
        Me.gcolEnPatio.Image = CType(resources.GetObject("gcolEnPatio.Image"), System.Drawing.Image)
        Me.gcolEnPatio.Name = "gcolEnPatio"
        Me.gcolEnPatio.OptionsColumn.AllowEdit = False
        Me.gcolEnPatio.OptionsColumn.ReadOnly = True
        Me.gcolEnPatio.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolEnPatio.Width = 68
        '
        'gcolMolidas
        '
        Me.gcolMolidas.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.gcolMolidas.AppearanceHeader.Options.UseFont = True
        Me.gcolMolidas.Caption = "Molidas"
        Me.gcolMolidas.FieldName = "Molidas"
        Me.gcolMolidas.Image = CType(resources.GetObject("gcolMolidas.Image"), System.Drawing.Image)
        Me.gcolMolidas.Name = "gcolMolidas"
        Me.gcolMolidas.OptionsColumn.AllowEdit = False
        Me.gcolMolidas.OptionsColumn.ReadOnly = True
        Me.gcolMolidas.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolMolidas.Visible = True
        Me.gcolMolidas.VisibleIndex = 8
        Me.gcolMolidas.Width = 59
        '
        'gcolPorcentajeAvance
        '
        Me.gcolPorcentajeAvance.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.gcolPorcentajeAvance.AppearanceHeader.Options.UseFont = True
        Me.gcolPorcentajeAvance.Caption = "Avance"
        Me.gcolPorcentajeAvance.ColumnEdit = Me.RepositoryItemNumPorAvance
        Me.gcolPorcentajeAvance.FieldName = "PorcAvance"
        Me.gcolPorcentajeAvance.Image = Global.ConsolaProgramas.My.Resources.Resources.chart_bar1
        Me.gcolPorcentajeAvance.Name = "gcolPorcentajeAvance"
        Me.gcolPorcentajeAvance.OptionsColumn.AllowEdit = False
        Me.gcolPorcentajeAvance.OptionsColumn.ReadOnly = True
        Me.gcolPorcentajeAvance.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolPorcentajeAvance.Visible = True
        Me.gcolPorcentajeAvance.VisibleIndex = 10
        Me.gcolPorcentajeAvance.Width = 66
        '
        'RepositoryItemNumPorAvance
        '
        Me.RepositoryItemNumPorAvance.Name = "RepositoryItemNumPorAvance"
        Me.RepositoryItemNumPorAvance.ShowTitle = True
        '
        'gcolInactividad
        '
        Me.gcolInactividad.Caption = "Inactividad"
        Me.gcolInactividad.FieldName = "Inactividad"
        Me.gcolInactividad.Name = "gcolInactividad"
        Me.gcolInactividad.OptionsColumn.AllowEdit = False
        Me.gcolInactividad.OptionsColumn.ReadOnly = True
        '
        'gcolNumPorAvance
        '
        Me.gcolNumPorAvance.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.gcolNumPorAvance.AppearanceHeader.Options.UseFont = True
        Me.gcolNumPorAvance.Caption = "% Avance"
        Me.gcolNumPorAvance.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.gcolNumPorAvance.FieldName = "NumPorcAvance"
        Me.gcolNumPorAvance.Image = Global.ConsolaProgramas.My.Resources.Resources.chart_line
        Me.gcolNumPorAvance.Name = "gcolNumPorAvance"
        Me.gcolNumPorAvance.Visible = True
        Me.gcolNumPorAvance.VisibleIndex = 9
        Me.gcolNumPorAvance.Width = 63
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'repItemAvance
        '
        Me.repItemAvance.AutoHeight = False
        Me.repItemAvance.DisplayFormat.FormatString = "P"
        Me.repItemAvance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.repItemAvance.Mask.BeepOnError = True
        Me.repItemAvance.Mask.EditMask = "P"
        Me.repItemAvance.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.repItemAvance.Name = "repItemAvance"
        '
        'RepositoryItemMarqueeProgressBar1
        '
        Me.RepositoryItemMarqueeProgressBar1.Name = "RepositoryItemMarqueeProgressBar1"
        Me.RepositoryItemMarqueeProgressBar1.ShowTitle = True
        Me.RepositoryItemMarqueeProgressBar1.TextOrientation = DevExpress.Utils.Drawing.TextOrientation.Horizontal
        '
        'LayoutView1
        '
        Me.LayoutView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() {Me.gcolLiberacion, Me.gcolTonsEstimadas})
        Me.LayoutView1.GridControl = Me.GridControl1
        Me.LayoutView1.Name = "LayoutView1"
        Me.LayoutView1.TemplateCard = Me.LayoutViewCard1
        '
        'gcolLiberacion
        '
        Me.gcolLiberacion.Caption = "Orden Corte"
        Me.gcolLiberacion.FieldName = "ordenCorte"
        Me.gcolLiberacion.LayoutViewField = Me.layoutViewField_gcolLiberacion
        Me.gcolLiberacion.Name = "gcolLiberacion"
        '
        'layoutViewField_gcolLiberacion
        '
        Me.layoutViewField_gcolLiberacion.EditorPreferredWidth = 91
        Me.layoutViewField_gcolLiberacion.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_gcolLiberacion.Name = "layoutViewField_gcolLiberacion"
        Me.layoutViewField_gcolLiberacion.Size = New System.Drawing.Size(203, 24)
        Me.layoutViewField_gcolLiberacion.TextSize = New System.Drawing.Size(104, 13)
        '
        'gcolTonsEstimadas
        '
        Me.gcolTonsEstimadas.Caption = "Toneladas Estimadas"
        Me.gcolTonsEstimadas.FieldName = "TonsEstimadas"
        Me.gcolTonsEstimadas.LayoutViewField = Me.layoutViewField_gcolTonsEstimadas
        Me.gcolTonsEstimadas.Name = "gcolTonsEstimadas"
        '
        'layoutViewField_gcolTonsEstimadas
        '
        Me.layoutViewField_gcolTonsEstimadas.EditorPreferredWidth = 91
        Me.layoutViewField_gcolTonsEstimadas.Location = New System.Drawing.Point(0, 24)
        Me.layoutViewField_gcolTonsEstimadas.Name = "layoutViewField_gcolTonsEstimadas"
        Me.layoutViewField_gcolTonsEstimadas.Size = New System.Drawing.Size(203, 24)
        Me.layoutViewField_gcolTonsEstimadas.TextSize = New System.Drawing.Size(104, 13)
        '
        'LayoutViewCard1
        '
        'Me.LayoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.LayoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_gcolLiberacion, Me.layoutViewField_gcolTonsEstimadas})
        Me.LayoutViewCard1.Name = "layoutViewTemplateCard"
        '
        'BandedGridView1
        '
        Me.BandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.BandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.gcolQuemaID, Me.gcolxTonsEstimadas, Me.gcolAreaLiberada, Me.gcolDistancia, Me.gcolAreaPendiente, Me.gcolHoraQuema, Me.gcolMinutosViaje})
        Me.BandedGridView1.GridControl = Me.GridControl1
        Me.BandedGridView1.Name = "BandedGridView1"
        Me.BandedGridView1.OptionsView.ShowGroupPanel = False
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "GridBand1"
        Me.GridBand1.Columns.Add(Me.gcolQuemaID)
        Me.GridBand1.Columns.Add(Me.gcolxTonsEstimadas)
        Me.GridBand1.Columns.Add(Me.gcolAreaLiberada)
        Me.GridBand1.Columns.Add(Me.gcolDistancia)
        Me.GridBand1.Columns.Add(Me.gcolAreaPendiente)
        Me.GridBand1.Columns.Add(Me.gcolHoraQuema)
        Me.GridBand1.Columns.Add(Me.gcolMinutosViaje)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.VisibleIndex = 0
        Me.GridBand1.Width = 525
        '
        'gcolQuemaID
        '
        Me.gcolQuemaID.Caption = "Orden Corte"
        Me.gcolQuemaID.FieldName = "OrdenCorte"
        Me.gcolQuemaID.Name = "gcolQuemaID"
        Me.gcolQuemaID.OptionsColumn.AllowEdit = False
        Me.gcolQuemaID.OptionsColumn.ReadOnly = True
        Me.gcolQuemaID.Visible = True
        '
        'gcolxTonsEstimadas
        '
        Me.gcolxTonsEstimadas.Caption = "Toneladas Estimadas"
        Me.gcolxTonsEstimadas.FieldName = "TonsEstimadas"
        Me.gcolxTonsEstimadas.Name = "gcolxTonsEstimadas"
        Me.gcolxTonsEstimadas.OptionsColumn.AllowEdit = False
        Me.gcolxTonsEstimadas.OptionsColumn.ReadOnly = True
        Me.gcolxTonsEstimadas.Visible = True
        '
        'gcolAreaLiberada
        '
        Me.gcolAreaLiberada.Caption = "Area Liberada"
        Me.gcolAreaLiberada.FieldName = "AreaLiberada"
        Me.gcolAreaLiberada.Name = "gcolAreaLiberada"
        Me.gcolAreaLiberada.OptionsColumn.AllowEdit = False
        Me.gcolAreaLiberada.OptionsColumn.ReadOnly = True
        Me.gcolAreaLiberada.Visible = True
        '
        'gcolDistancia
        '
        Me.gcolDistancia.Caption = "Distancia"
        Me.gcolDistancia.FieldName = "Distancia"
        Me.gcolDistancia.Name = "gcolDistancia"
        Me.gcolDistancia.OptionsColumn.AllowEdit = False
        Me.gcolDistancia.OptionsColumn.ReadOnly = True
        Me.gcolDistancia.Visible = True
        '
        'gcolAreaPendiente
        '
        Me.gcolAreaPendiente.Caption = "Area Pendiente"
        Me.gcolAreaPendiente.FieldName = "AreaPendiente"
        Me.gcolAreaPendiente.Name = "gcolAreaPendiente"
        Me.gcolAreaPendiente.OptionsColumn.AllowEdit = False
        Me.gcolAreaPendiente.OptionsColumn.ReadOnly = True
        Me.gcolAreaPendiente.Visible = True
        '
        'gcolHoraQuema
        '
        Me.gcolHoraQuema.Caption = "Hora Quema"
        Me.gcolHoraQuema.FieldName = "HoraQuema"
        Me.gcolHoraQuema.Name = "gcolHoraQuema"
        Me.gcolHoraQuema.OptionsColumn.AllowEdit = False
        Me.gcolHoraQuema.OptionsColumn.ReadOnly = True
        Me.gcolHoraQuema.Visible = True
        '
        'gcolMinutosViaje
        '
        Me.gcolMinutosViaje.Caption = "Minutos Viaje"
        Me.gcolMinutosViaje.FieldName = "MinutosViaje"
        Me.gcolMinutosViaje.Name = "gcolMinutosViaje"
        Me.gcolMinutosViaje.OptionsColumn.AllowEdit = False
        Me.gcolMinutosViaje.OptionsColumn.ReadOnly = True
        Me.gcolMinutosViaje.Visible = True
        '
        'tsMenu
        '
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2, Me.cmbRefrescar, Me.cmbFrecuencia, Me.cmbCambiarFecha, Me.cmbImprimir, Me.ToolStripSeparator1, Me.cmbSalir, Me.ToolStripSeparator3})
        Me.tsMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(1028, 52)
        Me.tsMenu.TabIndex = 8
        Me.tsMenu.Tag = "60010"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 52)
        '
        'cmbRefrescar
        '
        Me.cmbRefrescar.Image = CType(resources.GetObject("cmbRefrescar.Image"), System.Drawing.Image)
        Me.cmbRefrescar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmbRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbRefrescar.Name = "cmbRefrescar"
        Me.cmbRefrescar.Size = New System.Drawing.Size(58, 49)
        Me.cmbRefrescar.Text = "Refrescar"
        Me.cmbRefrescar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmbFrecuencia
        '
        Me.cmbFrecuencia.Image = CType(resources.GetObject("cmbFrecuencia.Image"), System.Drawing.Image)
        Me.cmbFrecuencia.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmbFrecuencia.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbFrecuencia.Name = "cmbFrecuencia"
        Me.cmbFrecuencia.Size = New System.Drawing.Size(130, 49)
        Me.cmbFrecuencia.Text = "Actualizacion Automatica"
        Me.cmbFrecuencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmbCambiarFecha
        '
        Me.cmbCambiarFecha.Image = CType(resources.GetObject("cmbCambiarFecha.Image"), System.Drawing.Image)
        Me.cmbCambiarFecha.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmbCambiarFecha.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbCambiarFecha.Name = "cmbCambiarFecha"
        Me.cmbCambiarFecha.Size = New System.Drawing.Size(82, 49)
        Me.cmbCambiarFecha.Text = "Cambiar Fecha"
        Me.cmbCambiarFecha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmbImprimir
        '
        Me.cmbImprimir.Image = Global.ConsolaProgramas.My.Resources.Resources.printer
        Me.cmbImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbImprimir.Name = "cmbImprimir"
        Me.cmbImprimir.Size = New System.Drawing.Size(49, 49)
        Me.cmbImprimir.Text = "Imprimir"
        Me.cmbImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 52)
        '
        'cmbSalir
        '
        Me.cmbSalir.Image = CType(resources.GetObject("cmbSalir.Image"), System.Drawing.Image)
        Me.cmbSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbSalir.Name = "cmbSalir"
        Me.cmbSalir.Size = New System.Drawing.Size(36, 49)
        Me.cmbSalir.Text = "Salir"
        Me.cmbSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 52)
        '
        'gbxParametros
        '
        Me.gbxParametros.Controls.Add(Me.SpinVisualizacion)
        Me.gbxParametros.Controls.Add(Me.lblTonsFecha2)
        Me.gbxParametros.Controls.Add(Me.lblContador)
        Me.gbxParametros.Controls.Add(Me.lblAcumuladoDiario2)
        Me.gbxParametros.Controls.Add(Me.lblProyeccionDiaria2)
        Me.gbxParametros.Controls.Add(Me.txtFecha)
        Me.gbxParametros.Controls.Add(Me.LabelControl1)
        Me.gbxParametros.Controls.Add(Me.lblFecha)
        Me.gbxParametros.Controls.Add(Me.lblPeriodo)
        Me.gbxParametros.Controls.Add(Me.cbxPeriodo)
        Me.gbxParametros.Enabled = False
        Me.gbxParametros.Location = New System.Drawing.Point(5, 3)
        Me.gbxParametros.Name = "gbxParametros"
        Me.gbxParametros.Size = New System.Drawing.Size(460, 106)
        Me.gbxParametros.TabIndex = 9
        Me.gbxParametros.Text = "Parametros de Busqueda"
        '
        'SpinVisualizacion
        '
        Me.SpinVisualizacion.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SpinVisualizacion.Location = New System.Drawing.Point(93, 67)
        Me.SpinVisualizacion.Name = "SpinVisualizacion"
        Me.SpinVisualizacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinVisualizacion.Properties.Mask.BeepOnError = True
        Me.SpinVisualizacion.Properties.Mask.EditMask = "n0"
        Me.SpinVisualizacion.Properties.MaxLength = 2
        Me.SpinVisualizacion.Properties.MaxValue = New Decimal(New Integer() {99, 0, 0, 0})
        Me.SpinVisualizacion.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SpinVisualizacion.Properties.NullText = "1"
        Me.SpinVisualizacion.Properties.NullValuePrompt = "1"
        Me.SpinVisualizacion.Properties.NullValuePromptShowForEmptyValue = True
        Me.SpinVisualizacion.Size = New System.Drawing.Size(100, 20)
        Me.SpinVisualizacion.TabIndex = 29
        '
        'lblTonsFecha2
        '
        Me.lblTonsFecha2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTonsFecha2.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTonsFecha2.Location = New System.Drawing.Point(379, 54)
        Me.lblTonsFecha2.Name = "lblTonsFecha2"
        Me.lblTonsFecha2.Size = New System.Drawing.Size(53, 29)
        Me.lblTonsFecha2.TabIndex = 7
        Me.lblTonsFecha2.Text = "0.00"
        Me.lblTonsFecha2.Visible = False
        '
        'lblContador
        '
        Me.lblContador.AutoSize = True
        Me.lblContador.Location = New System.Drawing.Point(199, 70)
        Me.lblContador.Name = "lblContador"
        Me.lblContador.Size = New System.Drawing.Size(48, 13)
        Me.lblContador.TabIndex = 28
        Me.lblContador.Text = "Minutos:"
        '
        'lblAcumuladoDiario2
        '
        Me.lblAcumuladoDiario2.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblAcumuladoDiario2.Location = New System.Drawing.Point(379, 55)
        Me.lblAcumuladoDiario2.Name = "lblAcumuladoDiario2"
        Me.lblAcumuladoDiario2.Size = New System.Drawing.Size(53, 29)
        Me.lblAcumuladoDiario2.TabIndex = 5
        Me.lblAcumuladoDiario2.Text = "0.00"
        Me.lblAcumuladoDiario2.Visible = False
        '
        'lblProyeccionDiaria2
        '
        Me.lblProyeccionDiaria2.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblProyeccionDiaria2.Location = New System.Drawing.Point(379, 55)
        Me.lblProyeccionDiaria2.Name = "lblProyeccionDiaria2"
        Me.lblProyeccionDiaria2.Size = New System.Drawing.Size(53, 29)
        Me.lblProyeccionDiaria2.TabIndex = 6
        Me.lblProyeccionDiaria2.Text = "0.00"
        Me.lblProyeccionDiaria2.Visible = False
        '
        'txtFecha
        '
        Me.txtFecha.EditValue = Nothing
        Me.txtFecha.Location = New System.Drawing.Point(92, 29)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFecha.Properties.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.txtFecha.Properties.EditFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.txtFecha.Properties.Mask.BeepOnError = True
        Me.txtFecha.Properties.Mask.EditMask = "dd/MM/yyyy HH:mm:ss"
        Me.txtFecha.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtFecha.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtFecha.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Style3D
        Me.txtFecha.Properties.ShowWeekNumbers = True
        Me.txtFecha.Size = New System.Drawing.Size(356, 20)
        Me.txtFecha.TabIndex = 25
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(20, 70)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl1.TabIndex = 24
        Me.LabelControl1.Text = "Visualización:"
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(19, 32)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(63, 13)
        Me.lblFecha.TabIndex = 24
        Me.lblFecha.Text = "Fecha Corte:"
        '
        'lblPeriodo
        '
        Me.lblPeriodo.Location = New System.Drawing.Point(291, 73)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(40, 13)
        Me.lblPeriodo.TabIndex = 17
        Me.lblPeriodo.Text = "Periodo:"
        Me.lblPeriodo.Visible = False
        '
        'cbxPeriodo
        '
        Me.cbxPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPeriodo.FormattingEnabled = True
        Me.cbxPeriodo.Location = New System.Drawing.Point(337, 70)
        Me.cbxPeriodo.Name = "cbxPeriodo"
        Me.cbxPeriodo.Size = New System.Drawing.Size(24, 21)
        Me.cbxPeriodo.TabIndex = 18
        Me.cbxPeriodo.Visible = False
        '
        'txtTonsFecha
        '
        Me.txtTonsFecha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTonsFecha.Location = New System.Drawing.Point(370, 53)
        Me.txtTonsFecha.Name = "txtTonsFecha"
        Me.txtTonsFecha.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtTonsFecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtTonsFecha.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtTonsFecha.Properties.Appearance.Options.UseBackColor = True
        Me.txtTonsFecha.Properties.Appearance.Options.UseFont = True
        Me.txtTonsFecha.Properties.Appearance.Options.UseForeColor = True
        Me.txtTonsFecha.Properties.Mask.BeepOnError = True
        Me.txtTonsFecha.Properties.Mask.EditMask = "n2"
        Me.txtTonsFecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTonsFecha.Properties.NullText = "0.00"
        Me.txtTonsFecha.Properties.ReadOnly = True
        Me.txtTonsFecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTonsFecha.Size = New System.Drawing.Size(173, 36)
        Me.txtTonsFecha.TabIndex = 5
        '
        'txtProyeccionDiaria
        '
        Me.txtProyeccionDiaria.Location = New System.Drawing.Point(134, 65)
        Me.txtProyeccionDiaria.Name = "txtProyeccionDiaria"
        Me.txtProyeccionDiaria.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtProyeccionDiaria.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtProyeccionDiaria.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtProyeccionDiaria.Properties.Appearance.Options.UseBackColor = True
        Me.txtProyeccionDiaria.Properties.Appearance.Options.UseFont = True
        Me.txtProyeccionDiaria.Properties.Appearance.Options.UseForeColor = True
        Me.txtProyeccionDiaria.Properties.Mask.BeepOnError = True
        Me.txtProyeccionDiaria.Properties.Mask.EditMask = "n2"
        Me.txtProyeccionDiaria.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtProyeccionDiaria.Properties.NullText = "0.00"
        Me.txtProyeccionDiaria.Properties.ReadOnly = True
        Me.txtProyeccionDiaria.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtProyeccionDiaria.Size = New System.Drawing.Size(195, 36)
        Me.txtProyeccionDiaria.TabIndex = 3
        '
        'txtAcumuladoDiario
        '
        Me.txtAcumuladoDiario.Location = New System.Drawing.Point(134, 23)
        Me.txtAcumuladoDiario.Name = "txtAcumuladoDiario"
        Me.txtAcumuladoDiario.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtAcumuladoDiario.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtAcumuladoDiario.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtAcumuladoDiario.Properties.Appearance.Options.UseBackColor = True
        Me.txtAcumuladoDiario.Properties.Appearance.Options.UseFont = True
        Me.txtAcumuladoDiario.Properties.Appearance.Options.UseForeColor = True
        Me.txtAcumuladoDiario.Properties.Mask.BeepOnError = True
        Me.txtAcumuladoDiario.Properties.Mask.EditMask = "n2"
        Me.txtAcumuladoDiario.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAcumuladoDiario.Properties.NullText = "0.00"
        Me.txtAcumuladoDiario.Properties.ReadOnly = True
        Me.txtAcumuladoDiario.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtAcumuladoDiario.Size = New System.Drawing.Size(195, 36)
        Me.txtAcumuladoDiario.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'SplitControl
        '
        Me.SplitControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.SplitControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitControl.Horizontal = False
        Me.SplitControl.Location = New System.Drawing.Point(0, 52)
        Me.SplitControl.Name = "SplitControl"
        Me.SplitControl.Panel1.Controls.Add(Me.gbxDatosMolienda)
        Me.SplitControl.Panel1.Controls.Add(Me.gbxParametros)
        Me.SplitControl.Panel1.Text = "Panel1"
        Me.SplitControl.Panel2.Controls.Add(Me.GridControl1)
        Me.SplitControl.Panel2.Text = "Panel2"
        Me.SplitControl.Size = New System.Drawing.Size(1028, 406)
        Me.SplitControl.SplitterPosition = 110
        Me.SplitControl.TabIndex = 10
        Me.SplitControl.Text = "SplitContainerControl1"
        '
        'gbxDatosMolienda
        '
        Me.gbxDatosMolienda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxDatosMolienda.Controls.Add(Me.txtTonsFecha)
        Me.gbxDatosMolienda.Controls.Add(Me.txtProyeccionDiaria)
        Me.gbxDatosMolienda.Controls.Add(Me.lblToneladasFecha)
        Me.gbxDatosMolienda.Controls.Add(Me.LblProyeccionDiaria)
        Me.gbxDatosMolienda.Controls.Add(Me.txtAcumuladoDiario)
        Me.gbxDatosMolienda.Controls.Add(Me.lblAcumuladoDiario)
        Me.gbxDatosMolienda.Enabled = False
        Me.gbxDatosMolienda.Location = New System.Drawing.Point(471, 4)
        Me.gbxDatosMolienda.Name = "gbxDatosMolienda"
        Me.gbxDatosMolienda.Size = New System.Drawing.Size(550, 105)
        Me.gbxDatosMolienda.TabIndex = 10
        Me.gbxDatosMolienda.Text = "Datos de Molienda"
        '
        'lblToneladasFecha
        '
        Me.lblToneladasFecha.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblToneladasFecha.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lblToneladasFecha.Location = New System.Drawing.Point(370, 28)
        Me.lblToneladasFecha.Name = "lblToneladasFecha"
        Me.lblToneladasFecha.Size = New System.Drawing.Size(138, 16)
        Me.lblToneladasFecha.TabIndex = 4
        Me.lblToneladasFecha.Text = "Toneladas a la Fecha:"
        '
        'LblProyeccionDiaria
        '
        Me.LblProyeccionDiaria.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LblProyeccionDiaria.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LblProyeccionDiaria.Location = New System.Drawing.Point(11, 70)
        Me.LblProyeccionDiaria.Name = "LblProyeccionDiaria"
        Me.LblProyeccionDiaria.Size = New System.Drawing.Size(117, 16)
        Me.LblProyeccionDiaria.TabIndex = 1
        Me.LblProyeccionDiaria.Text = "Proyeccion Diaria:"
        '
        'lblAcumuladoDiario
        '
        Me.lblAcumuladoDiario.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblAcumuladoDiario.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lblAcumuladoDiario.Location = New System.Drawing.Point(11, 30)
        Me.lblAcumuladoDiario.Name = "lblAcumuladoDiario"
        Me.lblAcumuladoDiario.Size = New System.Drawing.Size(117, 16)
        Me.lblAcumuladoDiario.TabIndex = 0
        Me.lblAcumuladoDiario.Text = "Acumulado Diario:"
        '
        'BprAvanceCosechaFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 458)
        Me.Controls.Add(Me.SplitControl)
        Me.Controls.Add(Me.tsMenu)
        Me.Name = "BprAvanceCosechaFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Avance de Cosecha"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemNumPorAvance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repItemAvance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMarqueeProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_gcolLiberacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_gcolTonsEstimadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        CType(Me.gbxParametros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxParametros.ResumeLayout(False)
        Me.gbxParametros.PerformLayout()
        CType(Me.SpinVisualizacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTonsFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProyeccionDiaria.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAcumuladoDiario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitControl.ResumeLayout(False)
        CType(Me.gbxDatosMolienda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDatosMolienda.ResumeLayout(False)
        Me.gbxDatosMolienda.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents dgvDatos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents cmbRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents gcolOrdenCorte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolLote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolFechaQuema As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolTiempoTranscurrido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolViajes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolEnCampo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolEnTransito As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolEnPatio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolMolidas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolPorcentajeAvance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemNumPorAvance As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents repItemAvance As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents gbxParametros As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblPeriodo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbxPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents txtFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblFecha As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbFrecuencia As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SplitControl As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents gcolFinca As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolFrente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblContador As System.Windows.Forms.Label
    Friend WithEvents cmbCambiarFecha As System.Windows.Forms.ToolStripButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SpinVisualizacion As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutView1 As DevExpress.XtraGrid.Views.Layout.LayoutView
    Friend WithEvents gcolLiberacion As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_gcolLiberacion As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents gcolTonsEstimadas As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_gcolTonsEstimadas As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
    Friend WithEvents BandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gcolQuemaID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gcolxTonsEstimadas As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gcolAreaLiberada As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gcolDistancia As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gcolAreaPendiente As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gcolHoraQuema As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gcolMinutosViaje As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolInactividad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents gbxDatosMolienda As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LblProyeccionDiaria As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblAcumuladoDiario As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTonsFecha As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblToneladasFecha As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtProyeccionDiaria As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAcumuladoDiario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblTonsFecha2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblProyeccionDiaria2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblAcumuladoDiario2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RepositoryItemMarqueeProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar
    Friend WithEvents gcolNumPorAvance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
