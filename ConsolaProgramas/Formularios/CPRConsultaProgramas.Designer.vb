<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CPRConsultaProgramas
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
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.cmbConsultar = New System.Windows.Forms.ToolStripButton()
        Me.cmbRestablecer = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmbMarcarTodos = New System.Windows.Forms.ToolStripButton()
        Me.cmbQuitarTodos = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmbRecalcular = New System.Windows.Forms.ToolStripButton()
        Me.cmbVerFiltros = New System.Windows.Forms.ToolStripButton()
        Me.cmbSeleccionar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmbSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblTotalToneladas = New System.Windows.Forms.ToolStripLabel()
        Me.lblToneladas = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.lblRegistros = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblRefFechaCalculoEdadCaña = New System.Windows.Forms.ToolStripLabel()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.gcDatos = New DevExpress.XtraGrid.GridControl()
        Me.dgvDatos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEstimadoProduccionID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSeleccion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemChkSeleccion = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colDistritoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFincaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFinca = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLoteID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAreaEstimada = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAreaEjecutada = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAreaReal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRendimiento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colToneladasEstimadas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDistanciaIngenio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVariedadID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVariedadDescrip = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCicloID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCicloDescrip = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTexturaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTexturaDescrip = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrenajeID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDrenajeDescrip = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDistanciaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDistanciaSiembra = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaEstimada = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPeriodoZafra = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEdadCaña = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colZonaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colZona = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmpresaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colestaProgramado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colestaMuestreado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colestaTerminado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDetalleProgramaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGrupoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstimadoGrupoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolLoteTerminado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gbxParametros = New DevExpress.XtraEditors.GroupControl()
        Me.listaTextura = New System.Windows.Forms.CheckedListBox()
        Me.listaVariedades = New System.Windows.Forms.CheckedListBox()
        Me.txtFechaEHasta = New DevExpress.XtraEditors.DateEdit()
        Me.txtFechaEDesde = New DevExpress.XtraEditors.DateEdit()
        Me.cbxCicloHasta = New System.Windows.Forms.ComboBox()
        Me.cbxCicloDesde = New System.Windows.Forms.ComboBox()
        Me.cbxFrente = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcolFrenteID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lblFrente = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.chkFechaEstimada = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDistanciaHasta = New DevExpress.XtraEditors.TextEdit()
        Me.txtDistanciaDesde = New DevExpress.XtraEditors.TextEdit()
        Me.chkDistancia = New DevExpress.XtraEditors.CheckEdit()
        Me.cbxDrenaje = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcolDrenajeID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolDescripcionDrenaje = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkDrenaje = New DevExpress.XtraEditors.CheckEdit()
        Me.chkTextura = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.chkCiclo = New DevExpress.XtraEditors.CheckEdit()
        Me.chkVariedades = New DevExpress.XtraEditors.CheckEdit()
        Me.lbly2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRendimientoHasta = New DevExpress.XtraEditors.TextEdit()
        Me.txtRendimientoDesde = New DevExpress.XtraEditors.TextEdit()
        Me.chkRendimiento = New DevExpress.XtraEditors.CheckEdit()
        Me.lbly1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEdadHasta = New DevExpress.XtraEditors.TextEdit()
        Me.txtEdadDesde = New DevExpress.XtraEditors.TextEdit()
        Me.chkEdadCaña = New DevExpress.XtraEditors.CheckEdit()
        Me.cbxFinca = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcolFincaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkFinca = New DevExpress.XtraEditors.CheckEdit()
        Me.cbxZona = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcolZonaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolDescripcionZona = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkZona = New DevExpress.XtraEditors.CheckEdit()
        Me.cbxDistrito = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcolDistritoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolDistrito = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkDistrito = New DevExpress.XtraEditors.CheckEdit()
        Me.txtFecha = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblMinutaFrente = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTotalMinutaFrente = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblPai1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTituloTotalTonsxPrg = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTotalTonsxPrg = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblPai2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTituloTotalTonsAProcesar = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTotalTonsAProcesar = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblPai3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTituloTotalLotesAProcesar = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTotalLotesAProcesar = New System.Windows.Forms.ToolStripStatusLabel()
        Me.XtraScrollableControl1 = New DevExpress.XtraEditors.XtraScrollableControl()
        Me.tsMenu.SuspendLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemChkSeleccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbxParametros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxParametros.SuspendLayout()
        CType(Me.txtFechaEHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaEHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaEDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaEDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxFrente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkFechaEstimada.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDistanciaHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDistanciaDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDistancia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxDrenaje.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDrenaje.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTextura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCiclo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkVariedades.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRendimientoHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRendimientoDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkRendimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEdadHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEdadDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEdadCaña.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxFinca.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkFinca.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxZona.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkZona.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxDistrito.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDistrito.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.XtraScrollableControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsMenu
        '
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmbConsultar, Me.cmbRestablecer, Me.ToolStripSeparator1, Me.cmbMarcarTodos, Me.cmbQuitarTodos, Me.ToolStripSeparator2, Me.cmbRecalcular, Me.cmbVerFiltros, Me.cmbSeleccionar, Me.ToolStripSeparator3, Me.cmbSalir, Me.ToolStripSeparator4, Me.lblTotalToneladas, Me.lblToneladas, Me.ToolStripSeparator5, Me.ToolStripLabel1, Me.lblRegistros, Me.ToolStripSeparator6, Me.lblRefFechaCalculoEdadCaña})
        Me.tsMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(1284, 52)
        Me.tsMenu.TabIndex = 10
        '
        'cmbConsultar
        '
        Me.cmbConsultar.Image = Global.ConsolaProgramas.My.Resources.Resources.zoom_refresh
        Me.cmbConsultar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmbConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbConsultar.Name = "cmbConsultar"
        Me.cmbConsultar.Size = New System.Drawing.Size(57, 49)
        Me.cmbConsultar.Text = "Consultar"
        Me.cmbConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmbRestablecer
        '
        Me.cmbRestablecer.Image = Global.ConsolaProgramas.My.Resources.Resources.application1
        Me.cmbRestablecer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmbRestablecer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbRestablecer.Name = "cmbRestablecer"
        Me.cmbRestablecer.Size = New System.Drawing.Size(85, 49)
        Me.cmbRestablecer.Text = "Limpiar Pantalla"
        Me.cmbRestablecer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 52)
        '
        'cmbMarcarTodos
        '
        Me.cmbMarcarTodos.Image = Global.ConsolaProgramas.My.Resources.Resources.wishlist_add
        Me.cmbMarcarTodos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmbMarcarTodos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbMarcarTodos.Name = "cmbMarcarTodos"
        Me.cmbMarcarTodos.Size = New System.Drawing.Size(76, 49)
        Me.cmbMarcarTodos.Text = "Marcar Todos"
        Me.cmbMarcarTodos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmbQuitarTodos
        '
        Me.cmbQuitarTodos.Image = Global.ConsolaProgramas.My.Resources.Resources.cross
        Me.cmbQuitarTodos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmbQuitarTodos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbQuitarTodos.Name = "cmbQuitarTodos"
        Me.cmbQuitarTodos.Size = New System.Drawing.Size(73, 49)
        Me.cmbQuitarTodos.Text = "Quitar Todos"
        Me.cmbQuitarTodos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 52)
        '
        'cmbRecalcular
        '
        Me.cmbRecalcular.Image = Global.ConsolaProgramas.My.Resources.Resources.table_gear
        Me.cmbRecalcular.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmbRecalcular.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbRecalcular.Name = "cmbRecalcular"
        Me.cmbRecalcular.Size = New System.Drawing.Size(60, 49)
        Me.cmbRecalcular.Text = "Recalcular"
        Me.cmbRecalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmbVerFiltros
        '
        Me.cmbVerFiltros.Image = Global.ConsolaProgramas.My.Resources.Resources.filter
        Me.cmbVerFiltros.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmbVerFiltros.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbVerFiltros.Name = "cmbVerFiltros"
        Me.cmbVerFiltros.Size = New System.Drawing.Size(59, 49)
        Me.cmbVerFiltros.Text = "Ver Filtros"
        Me.cmbVerFiltros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmbVerFiltros.Visible = False
        '
        'cmbSeleccionar
        '
        Me.cmbSeleccionar.Image = Global.ConsolaProgramas.My.Resources.Resources.page_white_put
        Me.cmbSeleccionar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmbSeleccionar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbSeleccionar.Name = "cmbSeleccionar"
        Me.cmbSeleccionar.Size = New System.Drawing.Size(71, 49)
        Me.cmbSeleccionar.Text = "Asignar Lote"
        Me.cmbSeleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 52)
        '
        'cmbSalir
        '
        Me.cmbSalir.Image = Global.ConsolaProgramas.My.Resources.Resources.door_out
        Me.cmbSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbSalir.Name = "cmbSalir"
        Me.cmbSalir.Size = New System.Drawing.Size(36, 49)
        Me.cmbSalir.Text = "Salir"
        Me.cmbSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 52)
        '
        'lblTotalToneladas
        '
        Me.lblTotalToneladas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblTotalToneladas.Name = "lblTotalToneladas"
        Me.lblTotalToneladas.Size = New System.Drawing.Size(117, 49)
        Me.lblTotalToneladas.Text = "Total de Toneladas:"
        '
        'lblToneladas
        '
        Me.lblToneladas.Name = "lblToneladas"
        Me.lblToneladas.Size = New System.Drawing.Size(29, 49)
        Me.lblToneladas.Text = "0.00"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 52)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(130, 49)
        Me.ToolStripLabel1.Text = "Registros Pendientes:"
        '
        'lblRegistros
        '
        Me.lblRegistros.Name = "lblRegistros"
        Me.lblRegistros.Size = New System.Drawing.Size(13, 49)
        Me.lblRegistros.Text = "0"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 52)
        '
        'lblRefFechaCalculoEdadCaña
        '
        Me.lblRefFechaCalculoEdadCaña.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.lblRefFechaCalculoEdadCaña.ForeColor = System.Drawing.Color.Red
        Me.lblRefFechaCalculoEdadCaña.Name = "lblRefFechaCalculoEdadCaña"
        Me.lblRefFechaCalculoEdadCaña.Size = New System.Drawing.Size(15, 49)
        Me.lblRefFechaCalculoEdadCaña.Text = "--"
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.MaxItemId = 2
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemGridLookUpEdit1})
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1284, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 705)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1284, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 705)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1284, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 705)
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        '
        'gcDatos
        '
        Me.gcDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcDatos.Location = New System.Drawing.Point(312, 56)
        Me.gcDatos.MainView = Me.dgvDatos
        Me.gcDatos.MenuManager = Me.BarManager1
        Me.gcDatos.Name = "gcDatos"
        Me.gcDatos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemChkSeleccion})
        Me.gcDatos.Size = New System.Drawing.Size(971, 620)
        Me.gcDatos.TabIndex = 16
        Me.gcDatos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dgvDatos})
        '
        'dgvDatos
        '
        Me.dgvDatos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEstimadoProduccionID, Me.colSeleccion, Me.colDistritoID, Me.colFincaID, Me.colFinca, Me.colLoteID, Me.colAreaEstimada, Me.colAreaEjecutada, Me.colAreaReal, Me.colRendimiento, Me.colToneladasEstimadas, Me.colDistanciaIngenio, Me.colVariedadID, Me.colVariedadDescrip, Me.colCicloID, Me.colCicloDescrip, Me.colTexturaID, Me.colTexturaDescrip, Me.colDrenajeID, Me.colDrenajeDescrip, Me.colDistanciaID, Me.colDistanciaSiembra, Me.colFechaEstimada, Me.colPeriodoZafra, Me.colEdadCaña, Me.colZonaID, Me.colZona, Me.colEmpresaID, Me.colestaProgramado, Me.colestaMuestreado, Me.colestaTerminado, Me.colDetalleProgramaID, Me.colProgramaID, Me.colGrupoID, Me.colEstimadoGrupoID, Me.gcolLoteTerminado})
        Me.dgvDatos.GridControl = Me.gcDatos
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.OptionsBehavior.AllowIncrementalSearch = True
        Me.dgvDatos.OptionsView.ShowAutoFilterRow = True
        Me.dgvDatos.OptionsView.ShowFooter = True
        '
        'colEstimadoProduccionID
        '
        Me.colEstimadoProduccionID.Caption = "EstimadoProduccionID"
        Me.colEstimadoProduccionID.FieldName = "EstimadoProduccionID"
        Me.colEstimadoProduccionID.Name = "colEstimadoProduccionID"
        '
        'colSeleccion
        '
        Me.colSeleccion.Caption = "Seleccion"
        Me.colSeleccion.ColumnEdit = Me.RepItemChkSeleccion
        Me.colSeleccion.FieldName = "Seleccion"
        Me.colSeleccion.Name = "colSeleccion"
        Me.colSeleccion.Visible = True
        Me.colSeleccion.VisibleIndex = 0
        '
        'RepItemChkSeleccion
        '
        Me.RepItemChkSeleccion.AutoHeight = False
        Me.RepItemChkSeleccion.Caption = "Check"
        Me.RepItemChkSeleccion.Name = "RepItemChkSeleccion"
        '
        'colDistritoID
        '
        Me.colDistritoID.Caption = "DistritoID"
        Me.colDistritoID.FieldName = "DistritoID"
        Me.colDistritoID.Name = "colDistritoID"
        Me.colDistritoID.OptionsColumn.AllowEdit = False
        Me.colDistritoID.OptionsColumn.FixedWidth = True
        Me.colDistritoID.OptionsColumn.ReadOnly = True
        Me.colDistritoID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colDistritoID.Visible = True
        Me.colDistritoID.VisibleIndex = 1
        '
        'colFincaID
        '
        Me.colFincaID.Caption = "FincaID"
        Me.colFincaID.FieldName = "FincaID"
        Me.colFincaID.Name = "colFincaID"
        Me.colFincaID.OptionsColumn.AllowEdit = False
        Me.colFincaID.OptionsColumn.ReadOnly = True
        Me.colFincaID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'colFinca
        '
        Me.colFinca.Caption = "Finca"
        Me.colFinca.FieldName = "Finca"
        Me.colFinca.Name = "colFinca"
        Me.colFinca.OptionsColumn.AllowEdit = False
        Me.colFinca.OptionsColumn.ReadOnly = True
        Me.colFinca.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'colLoteID
        '
        Me.colLoteID.Caption = "LoteID"
        Me.colLoteID.FieldName = "LoteID"
        Me.colLoteID.Name = "colLoteID"
        Me.colLoteID.OptionsColumn.AllowEdit = False
        Me.colLoteID.OptionsColumn.ReadOnly = True
        Me.colLoteID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colLoteID.Visible = True
        Me.colLoteID.VisibleIndex = 2
        '
        'colAreaEstimada
        '
        Me.colAreaEstimada.Caption = "AreaEstimada"
        Me.colAreaEstimada.FieldName = "AreaEstimada"
        Me.colAreaEstimada.Name = "colAreaEstimada"
        Me.colAreaEstimada.OptionsColumn.AllowEdit = False
        Me.colAreaEstimada.OptionsColumn.ReadOnly = True
        Me.colAreaEstimada.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'colAreaEjecutada
        '
        Me.colAreaEjecutada.Caption = "AreaEjecutada"
        Me.colAreaEjecutada.FieldName = "AreaEjecutada"
        Me.colAreaEjecutada.Name = "colAreaEjecutada"
        Me.colAreaEjecutada.OptionsColumn.AllowEdit = False
        Me.colAreaEjecutada.OptionsColumn.ReadOnly = True
        Me.colAreaEjecutada.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'colAreaReal
        '
        Me.colAreaReal.Caption = "AreaReal"
        Me.colAreaReal.FieldName = "AreaReal"
        Me.colAreaReal.Name = "colAreaReal"
        Me.colAreaReal.OptionsColumn.AllowEdit = False
        Me.colAreaReal.OptionsColumn.ReadOnly = True
        Me.colAreaReal.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colAreaReal.Visible = True
        Me.colAreaReal.VisibleIndex = 3
        '
        'colRendimiento
        '
        Me.colRendimiento.Caption = "Rendimiento"
        Me.colRendimiento.FieldName = "Rendimiento"
        Me.colRendimiento.Name = "colRendimiento"
        Me.colRendimiento.OptionsColumn.AllowEdit = False
        Me.colRendimiento.OptionsColumn.ReadOnly = True
        Me.colRendimiento.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colRendimiento.Visible = True
        Me.colRendimiento.VisibleIndex = 4
        '
        'colToneladasEstimadas
        '
        Me.colToneladasEstimadas.Caption = "ToneladasEstimadas"
        Me.colToneladasEstimadas.FieldName = "ToneladasEstimadas"
        Me.colToneladasEstimadas.Name = "colToneladasEstimadas"
        Me.colToneladasEstimadas.OptionsColumn.AllowEdit = False
        Me.colToneladasEstimadas.OptionsColumn.ReadOnly = True
        Me.colToneladasEstimadas.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colToneladasEstimadas.Visible = True
        Me.colToneladasEstimadas.VisibleIndex = 5
        '
        'colDistanciaIngenio
        '
        Me.colDistanciaIngenio.Caption = "DistanciaIngenio"
        Me.colDistanciaIngenio.FieldName = "DistanciaIngenio"
        Me.colDistanciaIngenio.Name = "colDistanciaIngenio"
        Me.colDistanciaIngenio.OptionsColumn.AllowEdit = False
        Me.colDistanciaIngenio.OptionsColumn.ReadOnly = True
        Me.colDistanciaIngenio.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colDistanciaIngenio.Visible = True
        Me.colDistanciaIngenio.VisibleIndex = 6
        '
        'colVariedadID
        '
        Me.colVariedadID.Caption = "VariedadID"
        Me.colVariedadID.FieldName = "VariedadID"
        Me.colVariedadID.Name = "colVariedadID"
        Me.colVariedadID.OptionsColumn.AllowEdit = False
        Me.colVariedadID.OptionsColumn.ReadOnly = True
        Me.colVariedadID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'colVariedadDescrip
        '
        Me.colVariedadDescrip.Caption = "VariedadDescrip"
        Me.colVariedadDescrip.FieldName = "VariedadDescrip"
        Me.colVariedadDescrip.Name = "colVariedadDescrip"
        Me.colVariedadDescrip.OptionsColumn.AllowEdit = False
        Me.colVariedadDescrip.OptionsColumn.ReadOnly = True
        Me.colVariedadDescrip.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colVariedadDescrip.Visible = True
        Me.colVariedadDescrip.VisibleIndex = 7
        '
        'colCicloID
        '
        Me.colCicloID.Caption = "CicloID"
        Me.colCicloID.FieldName = "CicloID"
        Me.colCicloID.Name = "colCicloID"
        Me.colCicloID.OptionsColumn.AllowEdit = False
        Me.colCicloID.OptionsColumn.ReadOnly = True
        Me.colCicloID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'colCicloDescrip
        '
        Me.colCicloDescrip.Caption = "CicloDescrip"
        Me.colCicloDescrip.FieldName = "CicloDescrip"
        Me.colCicloDescrip.Name = "colCicloDescrip"
        Me.colCicloDescrip.OptionsColumn.AllowEdit = False
        Me.colCicloDescrip.OptionsColumn.ReadOnly = True
        Me.colCicloDescrip.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colCicloDescrip.Visible = True
        Me.colCicloDescrip.VisibleIndex = 8
        '
        'colTexturaID
        '
        Me.colTexturaID.Caption = "TexturaID"
        Me.colTexturaID.FieldName = "TexturaID"
        Me.colTexturaID.Name = "colTexturaID"
        Me.colTexturaID.OptionsColumn.AllowEdit = False
        Me.colTexturaID.OptionsColumn.ReadOnly = True
        Me.colTexturaID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'colTexturaDescrip
        '
        Me.colTexturaDescrip.Caption = "TexturaDescrip"
        Me.colTexturaDescrip.FieldName = "TexturaDescrip"
        Me.colTexturaDescrip.Name = "colTexturaDescrip"
        Me.colTexturaDescrip.OptionsColumn.AllowEdit = False
        Me.colTexturaDescrip.OptionsColumn.ReadOnly = True
        Me.colTexturaDescrip.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colTexturaDescrip.Visible = True
        Me.colTexturaDescrip.VisibleIndex = 9
        '
        'colDrenajeID
        '
        Me.colDrenajeID.Caption = "DrenajeID"
        Me.colDrenajeID.FieldName = "DrenajeID"
        Me.colDrenajeID.Name = "colDrenajeID"
        Me.colDrenajeID.OptionsColumn.AllowEdit = False
        Me.colDrenajeID.OptionsColumn.ReadOnly = True
        Me.colDrenajeID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'colDrenajeDescrip
        '
        Me.colDrenajeDescrip.Caption = "DrenajeDescrip"
        Me.colDrenajeDescrip.FieldName = "DrenajeDescrip"
        Me.colDrenajeDescrip.Name = "colDrenajeDescrip"
        Me.colDrenajeDescrip.OptionsColumn.AllowEdit = False
        Me.colDrenajeDescrip.OptionsColumn.ReadOnly = True
        Me.colDrenajeDescrip.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colDrenajeDescrip.Visible = True
        Me.colDrenajeDescrip.VisibleIndex = 10
        '
        'colDistanciaID
        '
        Me.colDistanciaID.Caption = "DistanciaID"
        Me.colDistanciaID.FieldName = "DistanciaID"
        Me.colDistanciaID.Name = "colDistanciaID"
        Me.colDistanciaID.OptionsColumn.AllowEdit = False
        Me.colDistanciaID.OptionsColumn.ReadOnly = True
        Me.colDistanciaID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'colDistanciaSiembra
        '
        Me.colDistanciaSiembra.Caption = "DistanciaSiembra"
        Me.colDistanciaSiembra.FieldName = "DistanciaSiembraDescrip"
        Me.colDistanciaSiembra.Name = "colDistanciaSiembra"
        Me.colDistanciaSiembra.OptionsColumn.AllowEdit = False
        Me.colDistanciaSiembra.OptionsColumn.ReadOnly = True
        Me.colDistanciaSiembra.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colDistanciaSiembra.Visible = True
        Me.colDistanciaSiembra.VisibleIndex = 11
        '
        'colFechaEstimada
        '
        Me.colFechaEstimada.Caption = "FechaEstimada"
        Me.colFechaEstimada.FieldName = "FechaEstimada"
        Me.colFechaEstimada.Name = "colFechaEstimada"
        Me.colFechaEstimada.OptionsColumn.AllowEdit = False
        Me.colFechaEstimada.OptionsColumn.ReadOnly = True
        Me.colFechaEstimada.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colFechaEstimada.Visible = True
        Me.colFechaEstimada.VisibleIndex = 12
        '
        'colPeriodoZafra
        '
        Me.colPeriodoZafra.Caption = "PeriodoZafra"
        Me.colPeriodoZafra.FieldName = "PeriodoZafra"
        Me.colPeriodoZafra.Name = "colPeriodoZafra"
        Me.colPeriodoZafra.OptionsColumn.AllowEdit = False
        Me.colPeriodoZafra.OptionsColumn.ReadOnly = True
        Me.colPeriodoZafra.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'colEdadCaña
        '
        Me.colEdadCaña.Caption = "EdadCaña"
        Me.colEdadCaña.FieldName = "EdadCana"
        Me.colEdadCaña.Name = "colEdadCaña"
        Me.colEdadCaña.OptionsColumn.AllowEdit = False
        Me.colEdadCaña.OptionsColumn.ReadOnly = True
        Me.colEdadCaña.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colEdadCaña.Visible = True
        Me.colEdadCaña.VisibleIndex = 13
        '
        'colZonaID
        '
        Me.colZonaID.Caption = "ZonaID"
        Me.colZonaID.FieldName = "ZonaID"
        Me.colZonaID.Name = "colZonaID"
        Me.colZonaID.OptionsColumn.AllowEdit = False
        Me.colZonaID.OptionsColumn.ReadOnly = True
        Me.colZonaID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'colZona
        '
        Me.colZona.Caption = "Zona"
        Me.colZona.FieldName = "Zona"
        Me.colZona.Name = "colZona"
        Me.colZona.OptionsColumn.AllowEdit = False
        Me.colZona.OptionsColumn.ReadOnly = True
        Me.colZona.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colZona.Visible = True
        Me.colZona.VisibleIndex = 14
        '
        'colEmpresaID
        '
        Me.colEmpresaID.Caption = "EmpresaID"
        Me.colEmpresaID.FieldName = "EmpresaID"
        Me.colEmpresaID.Name = "colEmpresaID"
        Me.colEmpresaID.OptionsColumn.AllowEdit = False
        Me.colEmpresaID.OptionsColumn.ReadOnly = True
        Me.colEmpresaID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'colestaProgramado
        '
        Me.colestaProgramado.Caption = "estaProgramado"
        Me.colestaProgramado.FieldName = "estaProgramado"
        Me.colestaProgramado.Name = "colestaProgramado"
        Me.colestaProgramado.OptionsColumn.AllowEdit = False
        Me.colestaProgramado.OptionsColumn.ReadOnly = True
        Me.colestaProgramado.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'colestaMuestreado
        '
        Me.colestaMuestreado.Caption = "estaMuestreado"
        Me.colestaMuestreado.FieldName = "estaMuestreado"
        Me.colestaMuestreado.Name = "colestaMuestreado"
        Me.colestaMuestreado.OptionsColumn.AllowEdit = False
        Me.colestaMuestreado.OptionsColumn.ReadOnly = True
        Me.colestaMuestreado.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'colestaTerminado
        '
        Me.colestaTerminado.Caption = "estaTerminado"
        Me.colestaTerminado.FieldName = "estaTerminado"
        Me.colestaTerminado.Name = "colestaTerminado"
        Me.colestaTerminado.OptionsColumn.AllowEdit = False
        Me.colestaTerminado.OptionsColumn.ReadOnly = True
        Me.colestaTerminado.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'colDetalleProgramaID
        '
        Me.colDetalleProgramaID.Caption = "DetalleProgramaID"
        Me.colDetalleProgramaID.FieldName = "DetalleProgramaID"
        Me.colDetalleProgramaID.Name = "colDetalleProgramaID"
        Me.colDetalleProgramaID.OptionsColumn.AllowEdit = False
        Me.colDetalleProgramaID.OptionsColumn.ReadOnly = True
        Me.colDetalleProgramaID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'colProgramaID
        '
        Me.colProgramaID.Caption = "ProgramaID"
        Me.colProgramaID.FieldName = "ProgramaID"
        Me.colProgramaID.Name = "colProgramaID"
        Me.colProgramaID.OptionsColumn.AllowEdit = False
        Me.colProgramaID.OptionsColumn.ReadOnly = True
        Me.colProgramaID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'colGrupoID
        '
        Me.colGrupoID.Caption = "GrupoID"
        Me.colGrupoID.FieldName = "GrupoID"
        Me.colGrupoID.Name = "colGrupoID"
        Me.colGrupoID.OptionsColumn.AllowEdit = False
        Me.colGrupoID.OptionsColumn.ReadOnly = True
        Me.colGrupoID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'colEstimadoGrupoID
        '
        Me.colEstimadoGrupoID.Caption = "EstimadoGrupoID"
        Me.colEstimadoGrupoID.FieldName = "EstimadoGrupoID"
        Me.colEstimadoGrupoID.Name = "colEstimadoGrupoID"
        '
        'gcolLoteTerminado
        '
        Me.gcolLoteTerminado.Caption = "LoteTerminado"
        Me.gcolLoteTerminado.FieldName = "LoteTerminado"
        Me.gcolLoteTerminado.Name = "gcolLoteTerminado"
        '
        'gbxParametros
        '
        Me.gbxParametros.Controls.Add(Me.listaTextura)
        Me.gbxParametros.Controls.Add(Me.listaVariedades)
        Me.gbxParametros.Controls.Add(Me.txtFechaEHasta)
        Me.gbxParametros.Controls.Add(Me.txtFechaEDesde)
        Me.gbxParametros.Controls.Add(Me.cbxCicloHasta)
        Me.gbxParametros.Controls.Add(Me.cbxCicloDesde)
        Me.gbxParametros.Controls.Add(Me.cbxFrente)
        Me.gbxParametros.Controls.Add(Me.lblFrente)
        Me.gbxParametros.Controls.Add(Me.LabelControl6)
        Me.gbxParametros.Controls.Add(Me.chkFechaEstimada)
        Me.gbxParametros.Controls.Add(Me.LabelControl5)
        Me.gbxParametros.Controls.Add(Me.txtDistanciaHasta)
        Me.gbxParametros.Controls.Add(Me.txtDistanciaDesde)
        Me.gbxParametros.Controls.Add(Me.chkDistancia)
        Me.gbxParametros.Controls.Add(Me.cbxDrenaje)
        Me.gbxParametros.Controls.Add(Me.chkDrenaje)
        Me.gbxParametros.Controls.Add(Me.chkTextura)
        Me.gbxParametros.Controls.Add(Me.LabelControl4)
        Me.gbxParametros.Controls.Add(Me.chkCiclo)
        Me.gbxParametros.Controls.Add(Me.chkVariedades)
        Me.gbxParametros.Controls.Add(Me.lbly2)
        Me.gbxParametros.Controls.Add(Me.txtRendimientoHasta)
        Me.gbxParametros.Controls.Add(Me.txtRendimientoDesde)
        Me.gbxParametros.Controls.Add(Me.chkRendimiento)
        Me.gbxParametros.Controls.Add(Me.lbly1)
        Me.gbxParametros.Controls.Add(Me.txtEdadHasta)
        Me.gbxParametros.Controls.Add(Me.txtEdadDesde)
        Me.gbxParametros.Controls.Add(Me.chkEdadCaña)
        Me.gbxParametros.Controls.Add(Me.cbxFinca)
        Me.gbxParametros.Controls.Add(Me.chkFinca)
        Me.gbxParametros.Controls.Add(Me.cbxZona)
        Me.gbxParametros.Controls.Add(Me.chkZona)
        Me.gbxParametros.Controls.Add(Me.cbxDistrito)
        Me.gbxParametros.Controls.Add(Me.chkDistrito)
        Me.gbxParametros.Controls.Add(Me.txtFecha)
        Me.gbxParametros.Controls.Add(Me.LabelControl1)
        Me.gbxParametros.FireScrollEventOnMouseWheel = True
        Me.gbxParametros.Location = New System.Drawing.Point(0, 3)
        Me.gbxParametros.Name = "gbxParametros"
        Me.gbxParametros.Size = New System.Drawing.Size(288, 730)
        Me.gbxParametros.TabIndex = 17
        Me.gbxParametros.Text = "Parametros de Busqueda"
        '
        'listaTextura
        '
        Me.listaTextura.CheckOnClick = True
        Me.listaTextura.Cursor = System.Windows.Forms.Cursors.Hand
        Me.listaTextura.FormattingEnabled = True
        Me.listaTextura.Location = New System.Drawing.Point(32, 487)
        Me.listaTextura.Name = "listaTextura"
        Me.listaTextura.ScrollAlwaysVisible = True
        Me.listaTextura.Size = New System.Drawing.Size(243, 100)
        Me.listaTextura.TabIndex = 76
        '
        'listaVariedades
        '
        Me.listaVariedades.CheckOnClick = True
        Me.listaVariedades.Cursor = System.Windows.Forms.Cursors.Hand
        Me.listaVariedades.FormattingEnabled = True
        Me.listaVariedades.Location = New System.Drawing.Point(32, 325)
        Me.listaVariedades.Name = "listaVariedades"
        Me.listaVariedades.ScrollAlwaysVisible = True
        Me.listaVariedades.Size = New System.Drawing.Size(243, 100)
        Me.listaVariedades.TabIndex = 75
        '
        'txtFechaEHasta
        '
        Me.txtFechaEHasta.EditValue = Nothing
        Me.txtFechaEHasta.EnterMoveNextControl = True
        Me.txtFechaEHasta.Location = New System.Drawing.Point(175, 691)
        Me.txtFechaEHasta.Name = "txtFechaEHasta"
        Me.txtFechaEHasta.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtFechaEHasta.Properties.Appearance.Options.UseBackColor = True
        Me.txtFechaEHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaEHasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaEHasta.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.txtFechaEHasta.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.txtFechaEHasta.Properties.Mask.BeepOnError = True
        Me.txtFechaEHasta.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.txtFechaEHasta.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtFechaEHasta.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Style3D
        Me.txtFechaEHasta.Properties.ShowWeekNumbers = True
        Me.txtFechaEHasta.Size = New System.Drawing.Size(97, 20)
        Me.txtFechaEHasta.TabIndex = 74
        '
        'txtFechaEDesde
        '
        Me.txtFechaEDesde.EditValue = Nothing
        Me.txtFechaEDesde.EnterMoveNextControl = True
        Me.txtFechaEDesde.Location = New System.Drawing.Point(32, 691)
        Me.txtFechaEDesde.Name = "txtFechaEDesde"
        Me.txtFechaEDesde.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtFechaEDesde.Properties.Appearance.Options.UseBackColor = True
        Me.txtFechaEDesde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaEDesde.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaEDesde.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.txtFechaEDesde.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.txtFechaEDesde.Properties.Mask.BeepOnError = True
        Me.txtFechaEDesde.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.txtFechaEDesde.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtFechaEDesde.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Style3D
        Me.txtFechaEDesde.Properties.ShowWeekNumbers = True
        Me.txtFechaEDesde.Size = New System.Drawing.Size(90, 20)
        Me.txtFechaEDesde.TabIndex = 73
        '
        'cbxCicloHasta
        '
        Me.cbxCicloHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCicloHasta.FormattingEnabled = True
        Me.cbxCicloHasta.Location = New System.Drawing.Point(188, 441)
        Me.cbxCicloHasta.Name = "cbxCicloHasta"
        Me.cbxCicloHasta.Size = New System.Drawing.Size(84, 21)
        Me.cbxCicloHasta.TabIndex = 72
        '
        'cbxCicloDesde
        '
        Me.cbxCicloDesde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCicloDesde.FormattingEnabled = True
        Me.cbxCicloDesde.Location = New System.Drawing.Point(74, 441)
        Me.cbxCicloDesde.Name = "cbxCicloDesde"
        Me.cbxCicloDesde.Size = New System.Drawing.Size(84, 21)
        Me.cbxCicloDesde.TabIndex = 71
        '
        'cbxFrente
        '
        Me.cbxFrente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxFrente.Location = New System.Drawing.Point(13, 43)
        Me.cbxFrente.MenuManager = Me.BarManager1
        Me.cbxFrente.Name = "cbxFrente"
        Me.cbxFrente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxFrente.Properties.NullText = ""
        Me.cbxFrente.Properties.View = Me.GridView2
        Me.cbxFrente.Size = New System.Drawing.Size(263, 20)
        Me.cbxFrente.TabIndex = 70
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcolFrenteID, Me.gcolNombre})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowAutoFilterRow = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'gcolFrenteID
        '
        Me.gcolFrenteID.Caption = "FrenteID"
        Me.gcolFrenteID.FieldName = "FrenteID"
        Me.gcolFrenteID.Name = "gcolFrenteID"
        Me.gcolFrenteID.OptionsColumn.AllowEdit = False
        Me.gcolFrenteID.OptionsColumn.ReadOnly = True
        Me.gcolFrenteID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolFrenteID.Visible = True
        Me.gcolFrenteID.VisibleIndex = 0
        '
        'gcolNombre
        '
        Me.gcolNombre.Caption = "Nombre"
        Me.gcolNombre.FieldName = "Nombre"
        Me.gcolNombre.Name = "gcolNombre"
        Me.gcolNombre.OptionsColumn.AllowEdit = False
        Me.gcolNombre.OptionsColumn.ReadOnly = True
        Me.gcolNombre.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolNombre.Visible = True
        Me.gcolNombre.VisibleIndex = 1
        '
        'lblFrente
        '
        Me.lblFrente.Location = New System.Drawing.Point(13, 24)
        Me.lblFrente.Name = "lblFrente"
        Me.lblFrente.Size = New System.Drawing.Size(36, 13)
        Me.lblFrente.TabIndex = 69
        Me.lblFrente.Text = "Frente:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(151, 698)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(6, 13)
        Me.LabelControl6.TabIndex = 67
        Me.LabelControl6.Text = "y"
        '
        'chkFechaEstimada
        '
        Me.chkFechaEstimada.Location = New System.Drawing.Point(13, 670)
        Me.chkFechaEstimada.MenuManager = Me.BarManager1
        Me.chkFechaEstimada.Name = "chkFechaEstimada"
        Me.chkFechaEstimada.Properties.Caption = "Fecha estimada de corte:"
        Me.chkFechaEstimada.Size = New System.Drawing.Size(200, 15)
        Me.chkFechaEstimada.TabIndex = 65
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(151, 652)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(6, 13)
        Me.LabelControl5.TabIndex = 64
        Me.LabelControl5.Text = "y"
        '
        'txtDistanciaHasta
        '
        Me.txtDistanciaHasta.Location = New System.Drawing.Point(175, 645)
        Me.txtDistanciaHasta.MenuManager = Me.BarManager1
        Me.txtDistanciaHasta.Name = "txtDistanciaHasta"
        Me.txtDistanciaHasta.Properties.Mask.BeepOnError = True
        Me.txtDistanciaHasta.Properties.Mask.EditMask = "n2"
        Me.txtDistanciaHasta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDistanciaHasta.Properties.NullText = "0.00"
        Me.txtDistanciaHasta.Properties.NullValuePrompt = "0.00"
        Me.txtDistanciaHasta.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtDistanciaHasta.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDistanciaHasta.Size = New System.Drawing.Size(100, 20)
        Me.txtDistanciaHasta.TabIndex = 63
        '
        'txtDistanciaDesde
        '
        Me.txtDistanciaDesde.Location = New System.Drawing.Point(31, 645)
        Me.txtDistanciaDesde.MenuManager = Me.BarManager1
        Me.txtDistanciaDesde.Name = "txtDistanciaDesde"
        Me.txtDistanciaDesde.Properties.Mask.BeepOnError = True
        Me.txtDistanciaDesde.Properties.Mask.EditMask = "n2"
        Me.txtDistanciaDesde.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDistanciaDesde.Properties.NullText = "0.00"
        Me.txtDistanciaDesde.Properties.NullValuePrompt = "0.00"
        Me.txtDistanciaDesde.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtDistanciaDesde.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDistanciaDesde.Size = New System.Drawing.Size(100, 20)
        Me.txtDistanciaDesde.TabIndex = 62
        '
        'chkDistancia
        '
        Me.chkDistancia.Location = New System.Drawing.Point(12, 627)
        Me.chkDistancia.MenuManager = Me.BarManager1
        Me.chkDistancia.Name = "chkDistancia"
        Me.chkDistancia.Properties.Caption = "Distancia al ingenio en kms. entre:"
        Me.chkDistancia.Size = New System.Drawing.Size(200, 15)
        Me.chkDistancia.TabIndex = 61
        '
        'cbxDrenaje
        '
        Me.cbxDrenaje.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxDrenaje.Location = New System.Drawing.Point(78, 601)
        Me.cbxDrenaje.MenuManager = Me.BarManager1
        Me.cbxDrenaje.Name = "cbxDrenaje"
        Me.cbxDrenaje.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxDrenaje.Properties.NullText = ""
        Me.cbxDrenaje.Properties.View = Me.GridView6
        Me.cbxDrenaje.Size = New System.Drawing.Size(198, 20)
        Me.cbxDrenaje.TabIndex = 60
        '
        'GridView6
        '
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcolDrenajeID, Me.gcolDescripcionDrenaje})
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowAutoFilterRow = True
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'gcolDrenajeID
        '
        Me.gcolDrenajeID.Caption = "DrenajeID"
        Me.gcolDrenajeID.FieldName = "DrenajeID"
        Me.gcolDrenajeID.Name = "gcolDrenajeID"
        Me.gcolDrenajeID.OptionsColumn.AllowEdit = False
        Me.gcolDrenajeID.OptionsColumn.ReadOnly = True
        Me.gcolDrenajeID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolDrenajeID.Visible = True
        Me.gcolDrenajeID.VisibleIndex = 0
        '
        'gcolDescripcionDrenaje
        '
        Me.gcolDescripcionDrenaje.Caption = "Descripcion"
        Me.gcolDescripcionDrenaje.FieldName = "Descripcion"
        Me.gcolDescripcionDrenaje.Name = "gcolDescripcionDrenaje"
        Me.gcolDescripcionDrenaje.OptionsColumn.AllowEdit = False
        Me.gcolDescripcionDrenaje.OptionsColumn.ReadOnly = True
        Me.gcolDescripcionDrenaje.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolDescripcionDrenaje.Visible = True
        Me.gcolDescripcionDrenaje.VisibleIndex = 1
        '
        'chkDrenaje
        '
        Me.chkDrenaje.Location = New System.Drawing.Point(13, 600)
        Me.chkDrenaje.MenuManager = Me.BarManager1
        Me.chkDrenaje.Name = "chkDrenaje"
        Me.chkDrenaje.Properties.Caption = "Drenaje:"
        Me.chkDrenaje.Size = New System.Drawing.Size(75, 15)
        Me.chkDrenaje.TabIndex = 59
        '
        'chkTextura
        '
        Me.chkTextura.Location = New System.Drawing.Point(13, 466)
        Me.chkTextura.MenuManager = Me.BarManager1
        Me.chkTextura.Name = "chkTextura"
        Me.chkTextura.Properties.Caption = "Textura:"
        Me.chkTextura.Size = New System.Drawing.Size(160, 15)
        Me.chkTextura.TabIndex = 57
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(170, 444)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(6, 13)
        Me.LabelControl4.TabIndex = 54
        Me.LabelControl4.Text = "y"
        '
        'chkCiclo
        '
        Me.chkCiclo.Location = New System.Drawing.Point(13, 440)
        Me.chkCiclo.MenuManager = Me.BarManager1
        Me.chkCiclo.Name = "chkCiclo"
        Me.chkCiclo.Properties.Caption = "Ciclo:"
        Me.chkCiclo.Size = New System.Drawing.Size(55, 15)
        Me.chkCiclo.TabIndex = 51
        '
        'chkVariedades
        '
        Me.chkVariedades.Location = New System.Drawing.Point(13, 303)
        Me.chkVariedades.MenuManager = Me.BarManager1
        Me.chkVariedades.Name = "chkVariedades"
        Me.chkVariedades.Properties.Caption = "Variedades:"
        Me.chkVariedades.Size = New System.Drawing.Size(160, 15)
        Me.chkVariedades.TabIndex = 49
        '
        'lbly2
        '
        Me.lbly2.Location = New System.Drawing.Point(152, 280)
        Me.lbly2.Name = "lbly2"
        Me.lbly2.Size = New System.Drawing.Size(6, 13)
        Me.lbly2.TabIndex = 48
        Me.lbly2.Text = "y"
        '
        'txtRendimientoHasta
        '
        Me.txtRendimientoHasta.Location = New System.Drawing.Point(176, 273)
        Me.txtRendimientoHasta.MenuManager = Me.BarManager1
        Me.txtRendimientoHasta.Name = "txtRendimientoHasta"
        Me.txtRendimientoHasta.Properties.Mask.BeepOnError = True
        Me.txtRendimientoHasta.Properties.Mask.EditMask = "n2"
        Me.txtRendimientoHasta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtRendimientoHasta.Properties.NullText = "0.00"
        Me.txtRendimientoHasta.Properties.NullValuePrompt = "0.00"
        Me.txtRendimientoHasta.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtRendimientoHasta.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtRendimientoHasta.Size = New System.Drawing.Size(100, 20)
        Me.txtRendimientoHasta.TabIndex = 47
        '
        'txtRendimientoDesde
        '
        Me.txtRendimientoDesde.Location = New System.Drawing.Point(32, 273)
        Me.txtRendimientoDesde.MenuManager = Me.BarManager1
        Me.txtRendimientoDesde.Name = "txtRendimientoDesde"
        Me.txtRendimientoDesde.Properties.Mask.BeepOnError = True
        Me.txtRendimientoDesde.Properties.Mask.EditMask = "n2"
        Me.txtRendimientoDesde.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtRendimientoDesde.Properties.NullText = "0.00"
        Me.txtRendimientoDesde.Properties.NullValuePrompt = "0.00"
        Me.txtRendimientoDesde.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtRendimientoDesde.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtRendimientoDesde.Size = New System.Drawing.Size(100, 20)
        Me.txtRendimientoDesde.TabIndex = 46
        '
        'chkRendimiento
        '
        Me.chkRendimiento.Location = New System.Drawing.Point(13, 255)
        Me.chkRendimiento.MenuManager = Me.BarManager1
        Me.chkRendimiento.Name = "chkRendimiento"
        Me.chkRendimiento.Properties.Caption = "Rendimiento ente:"
        Me.chkRendimiento.Size = New System.Drawing.Size(160, 15)
        Me.chkRendimiento.TabIndex = 45
        '
        'lbly1
        '
        Me.lbly1.Location = New System.Drawing.Point(152, 232)
        Me.lbly1.Name = "lbly1"
        Me.lbly1.Size = New System.Drawing.Size(6, 13)
        Me.lbly1.TabIndex = 44
        Me.lbly1.Text = "y"
        '
        'txtEdadHasta
        '
        Me.txtEdadHasta.Location = New System.Drawing.Point(176, 225)
        Me.txtEdadHasta.MenuManager = Me.BarManager1
        Me.txtEdadHasta.Name = "txtEdadHasta"
        Me.txtEdadHasta.Properties.Mask.BeepOnError = True
        Me.txtEdadHasta.Properties.Mask.EditMask = "n2"
        Me.txtEdadHasta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtEdadHasta.Properties.NullText = "0.00"
        Me.txtEdadHasta.Properties.NullValuePrompt = "0.00"
        Me.txtEdadHasta.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtEdadHasta.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtEdadHasta.Size = New System.Drawing.Size(100, 20)
        Me.txtEdadHasta.TabIndex = 43
        '
        'txtEdadDesde
        '
        Me.txtEdadDesde.Location = New System.Drawing.Point(32, 225)
        Me.txtEdadDesde.MenuManager = Me.BarManager1
        Me.txtEdadDesde.Name = "txtEdadDesde"
        Me.txtEdadDesde.Properties.Mask.BeepOnError = True
        Me.txtEdadDesde.Properties.Mask.EditMask = "n2"
        Me.txtEdadDesde.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtEdadDesde.Properties.NullText = "0.00"
        Me.txtEdadDesde.Properties.NullValuePrompt = "0.00"
        Me.txtEdadDesde.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtEdadDesde.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtEdadDesde.Size = New System.Drawing.Size(100, 20)
        Me.txtEdadDesde.TabIndex = 42
        '
        'chkEdadCaña
        '
        Me.chkEdadCaña.Location = New System.Drawing.Point(13, 207)
        Me.chkEdadCaña.MenuManager = Me.BarManager1
        Me.chkEdadCaña.Name = "chkEdadCaña"
        Me.chkEdadCaña.Properties.Caption = "Edad de la caña entre:"
        Me.chkEdadCaña.Size = New System.Drawing.Size(160, 15)
        Me.chkEdadCaña.TabIndex = 41
        '
        'cbxFinca
        '
        Me.cbxFinca.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxFinca.Location = New System.Drawing.Point(78, 178)
        Me.cbxFinca.MenuManager = Me.BarManager1
        Me.cbxFinca.Name = "cbxFinca"
        Me.cbxFinca.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxFinca.Properties.NullText = ""
        Me.cbxFinca.Properties.View = Me.GridView5
        Me.cbxFinca.Size = New System.Drawing.Size(198, 20)
        Me.cbxFinca.TabIndex = 40
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcolFincaID, Me.gcolDescripcion})
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowAutoFilterRow = True
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'gcolFincaID
        '
        Me.gcolFincaID.Caption = "FincaID"
        Me.gcolFincaID.FieldName = "FincaID"
        Me.gcolFincaID.Name = "gcolFincaID"
        Me.gcolFincaID.OptionsColumn.AllowEdit = False
        Me.gcolFincaID.OptionsColumn.ReadOnly = True
        Me.gcolFincaID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolFincaID.Visible = True
        Me.gcolFincaID.VisibleIndex = 0
        '
        'gcolDescripcion
        '
        Me.gcolDescripcion.Caption = "Descripcion"
        Me.gcolDescripcion.FieldName = "Descripcion"
        Me.gcolDescripcion.Name = "gcolDescripcion"
        Me.gcolDescripcion.OptionsColumn.AllowEdit = False
        Me.gcolDescripcion.OptionsColumn.ReadOnly = True
        Me.gcolDescripcion.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolDescripcion.Visible = True
        Me.gcolDescripcion.VisibleIndex = 1
        '
        'chkFinca
        '
        Me.chkFinca.Location = New System.Drawing.Point(13, 177)
        Me.chkFinca.MenuManager = Me.BarManager1
        Me.chkFinca.Name = "chkFinca"
        Me.chkFinca.Properties.Caption = "Finca:"
        Me.chkFinca.Size = New System.Drawing.Size(75, 15)
        Me.chkFinca.TabIndex = 39
        '
        'cbxZona
        '
        Me.cbxZona.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxZona.Location = New System.Drawing.Point(78, 151)
        Me.cbxZona.MenuManager = Me.BarManager1
        Me.cbxZona.Name = "cbxZona"
        Me.cbxZona.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxZona.Properties.NullText = ""
        Me.cbxZona.Properties.View = Me.GridView4
        Me.cbxZona.Size = New System.Drawing.Size(198, 20)
        Me.cbxZona.TabIndex = 38
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcolZonaID, Me.gcolDescripcionZona})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowAutoFilterRow = True
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'gcolZonaID
        '
        Me.gcolZonaID.Caption = "ZonaID"
        Me.gcolZonaID.FieldName = "ZonaID"
        Me.gcolZonaID.Name = "gcolZonaID"
        Me.gcolZonaID.OptionsColumn.AllowEdit = False
        Me.gcolZonaID.OptionsColumn.ReadOnly = True
        Me.gcolZonaID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolZonaID.Visible = True
        Me.gcolZonaID.VisibleIndex = 0
        '
        'gcolDescripcionZona
        '
        Me.gcolDescripcionZona.Caption = "Descripcion"
        Me.gcolDescripcionZona.FieldName = "Descripcion"
        Me.gcolDescripcionZona.Name = "gcolDescripcionZona"
        Me.gcolDescripcionZona.OptionsColumn.AllowEdit = False
        Me.gcolDescripcionZona.OptionsColumn.ReadOnly = True
        Me.gcolDescripcionZona.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolDescripcionZona.Visible = True
        Me.gcolDescripcionZona.VisibleIndex = 1
        '
        'chkZona
        '
        Me.chkZona.Location = New System.Drawing.Point(13, 150)
        Me.chkZona.MenuManager = Me.BarManager1
        Me.chkZona.Name = "chkZona"
        Me.chkZona.Properties.Caption = "Zona:"
        Me.chkZona.Size = New System.Drawing.Size(75, 15)
        Me.chkZona.TabIndex = 37
        '
        'cbxDistrito
        '
        Me.cbxDistrito.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxDistrito.Location = New System.Drawing.Point(78, 120)
        Me.cbxDistrito.MenuManager = Me.BarManager1
        Me.cbxDistrito.Name = "cbxDistrito"
        Me.cbxDistrito.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxDistrito.Properties.NullText = ""
        Me.cbxDistrito.Properties.View = Me.GridView3
        Me.cbxDistrito.Size = New System.Drawing.Size(198, 20)
        Me.cbxDistrito.TabIndex = 36
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcolDistritoID, Me.gcolDistrito})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowAutoFilterRow = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'gcolDistritoID
        '
        Me.gcolDistritoID.Caption = "Distrito ID"
        Me.gcolDistritoID.FieldName = "DistritoID"
        Me.gcolDistritoID.Name = "gcolDistritoID"
        Me.gcolDistritoID.OptionsColumn.AllowEdit = False
        Me.gcolDistritoID.OptionsColumn.ReadOnly = True
        Me.gcolDistritoID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolDistritoID.Visible = True
        Me.gcolDistritoID.VisibleIndex = 0
        '
        'gcolDistrito
        '
        Me.gcolDistrito.Caption = "Descripcion"
        Me.gcolDistrito.FieldName = "Descripcion"
        Me.gcolDistrito.Name = "gcolDistrito"
        Me.gcolDistrito.OptionsColumn.AllowEdit = False
        Me.gcolDistrito.OptionsColumn.ReadOnly = True
        Me.gcolDistrito.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolDistrito.Visible = True
        Me.gcolDistrito.VisibleIndex = 1
        '
        'chkDistrito
        '
        Me.chkDistrito.Location = New System.Drawing.Point(13, 119)
        Me.chkDistrito.MenuManager = Me.BarManager1
        Me.chkDistrito.Name = "chkDistrito"
        Me.chkDistrito.Properties.Caption = "Distrito:"
        Me.chkDistrito.Size = New System.Drawing.Size(75, 15)
        Me.chkDistrito.TabIndex = 35
        '
        'txtFecha
        '
        Me.txtFecha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtFecha.EditValue = Nothing
        Me.txtFecha.EnterMoveNextControl = True
        Me.txtFecha.Location = New System.Drawing.Point(13, 93)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtFecha.Properties.Appearance.Options.UseBackColor = True
        Me.txtFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFecha.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.txtFecha.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.txtFecha.Properties.Mask.BeepOnError = True
        Me.txtFecha.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.txtFecha.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtFecha.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Style3D
        Me.txtFecha.Properties.ShowWeekNumbers = True
        Me.txtFecha.Size = New System.Drawing.Size(263, 20)
        Me.txtFecha.TabIndex = 34
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(13, 74)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(92, 13)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Ubicar fecha como:"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblMinutaFrente, Me.lblTotalMinutaFrente, Me.lblPai1, Me.lblTituloTotalTonsxPrg, Me.lblTotalTonsxPrg, Me.lblPai2, Me.lblTituloTotalTonsAProcesar, Me.lblTotalTonsAProcesar, Me.lblPai3, Me.lblTituloTotalLotesAProcesar, Me.lblTotalLotesAProcesar})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 683)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1284, 22)
        Me.StatusStrip1.TabIndex = 22
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblMinutaFrente
        '
        Me.lblMinutaFrente.BackColor = System.Drawing.Color.Transparent
        Me.lblMinutaFrente.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblMinutaFrente.Name = "lblMinutaFrente"
        Me.lblMinutaFrente.Size = New System.Drawing.Size(119, 17)
        Me.lblMinutaFrente.Text = "Minuta del Frente:"
        '
        'lblTotalMinutaFrente
        '
        Me.lblTotalMinutaFrente.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalMinutaFrente.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblTotalMinutaFrente.Name = "lblTotalMinutaFrente"
        Me.lblTotalMinutaFrente.Size = New System.Drawing.Size(14, 17)
        Me.lblTotalMinutaFrente.Text = "0"
        '
        'lblPai1
        '
        Me.lblPai1.BackColor = System.Drawing.Color.Transparent
        Me.lblPai1.Name = "lblPai1"
        Me.lblPai1.Size = New System.Drawing.Size(11, 17)
        Me.lblPai1.Text = "|"
        '
        'lblTituloTotalTonsxPrg
        '
        Me.lblTituloTotalTonsxPrg.BackColor = System.Drawing.Color.Transparent
        Me.lblTituloTotalTonsxPrg.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTituloTotalTonsxPrg.ForeColor = System.Drawing.Color.Blue
        Me.lblTituloTotalTonsxPrg.Name = "lblTituloTotalTonsxPrg"
        Me.lblTituloTotalTonsxPrg.Size = New System.Drawing.Size(198, 17)
        Me.lblTituloTotalTonsxPrg.Text = "Total de Toneladas procesadas:"
        '
        'lblTotalTonsxPrg
        '
        Me.lblTotalTonsxPrg.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalTonsxPrg.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblTotalTonsxPrg.Name = "lblTotalTonsxPrg"
        Me.lblTotalTonsxPrg.Size = New System.Drawing.Size(32, 17)
        Me.lblTotalTonsxPrg.Text = "0.00"
        '
        'lblPai2
        '
        Me.lblPai2.BackColor = System.Drawing.Color.Transparent
        Me.lblPai2.Name = "lblPai2"
        Me.lblPai2.Size = New System.Drawing.Size(11, 17)
        Me.lblPai2.Text = "|"
        '
        'lblTituloTotalTonsAProcesar
        '
        Me.lblTituloTotalTonsAProcesar.BackColor = System.Drawing.Color.Transparent
        Me.lblTituloTotalTonsAProcesar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTituloTotalTonsAProcesar.ForeColor = System.Drawing.Color.Green
        Me.lblTituloTotalTonsAProcesar.Name = "lblTituloTotalTonsAProcesar"
        Me.lblTituloTotalTonsAProcesar.Size = New System.Drawing.Size(193, 17)
        Me.lblTituloTotalTonsAProcesar.Text = "Total de Toneladas a Procesar:"
        '
        'lblTotalTonsAProcesar
        '
        Me.lblTotalTonsAProcesar.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalTonsAProcesar.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblTotalTonsAProcesar.Name = "lblTotalTonsAProcesar"
        Me.lblTotalTonsAProcesar.Size = New System.Drawing.Size(32, 17)
        Me.lblTotalTonsAProcesar.Text = "0.00"
        '
        'lblPai3
        '
        Me.lblPai3.BackColor = System.Drawing.Color.Transparent
        Me.lblPai3.Name = "lblPai3"
        Me.lblPai3.Size = New System.Drawing.Size(11, 17)
        Me.lblPai3.Text = "|"
        '
        'lblTituloTotalLotesAProcesar
        '
        Me.lblTituloTotalLotesAProcesar.BackColor = System.Drawing.Color.Transparent
        Me.lblTituloTotalLotesAProcesar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTituloTotalLotesAProcesar.ForeColor = System.Drawing.Color.Green
        Me.lblTituloTotalLotesAProcesar.Name = "lblTituloTotalLotesAProcesar"
        Me.lblTituloTotalLotesAProcesar.Size = New System.Drawing.Size(166, 17)
        Me.lblTituloTotalLotesAProcesar.Text = "Total de Lotes a Procesar:"
        '
        'lblTotalLotesAProcesar
        '
        Me.lblTotalLotesAProcesar.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalLotesAProcesar.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblTotalLotesAProcesar.Name = "lblTotalLotesAProcesar"
        Me.lblTotalLotesAProcesar.Size = New System.Drawing.Size(14, 17)
        Me.lblTotalLotesAProcesar.Text = "0"
        '
        'XtraScrollableControl1
        '
        Me.XtraScrollableControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.XtraScrollableControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.XtraScrollableControl1.Appearance.Options.UseBackColor = True
        Me.XtraScrollableControl1.Controls.Add(Me.gbxParametros)
        Me.XtraScrollableControl1.Location = New System.Drawing.Point(4, 57)
        Me.XtraScrollableControl1.Name = "XtraScrollableControl1"
        Me.XtraScrollableControl1.ScrollBarSmallChange = 10
        Me.XtraScrollableControl1.Size = New System.Drawing.Size(303, 619)
        Me.XtraScrollableControl1.TabIndex = 27
        '
        'CPRConsultaProgramas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 705)
        Me.Controls.Add(Me.XtraScrollableControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.gcDatos)
        Me.Controls.Add(Me.tsMenu)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "CPRConsultaProgramas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario de Seleccion de Lotes pendientes de Programar"
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemChkSeleccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbxParametros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxParametros.ResumeLayout(False)
        Me.gbxParametros.PerformLayout()
        CType(Me.txtFechaEHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaEHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaEDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaEDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxFrente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkFechaEstimada.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDistanciaHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDistanciaDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDistancia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxDrenaje.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDrenaje.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTextura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCiclo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkVariedades.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRendimientoHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRendimientoDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkRendimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEdadHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEdadDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEdadCaña.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxFinca.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkFinca.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxZona.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkZona.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxDistrito.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDistrito.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.XtraScrollableControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents cmbConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbRestablecer As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbRecalcular As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmbMarcarTodos As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbQuitarTodos As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmbVerFiltros As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbSeleccionar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents gcDatos As DevExpress.XtraGrid.GridControl
    Friend WithEvents dgvDatos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gbxParametros As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents chkEdadCaña As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cbxFinca As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents chkFinca As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cbxZona As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents chkZona As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cbxDistrito As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents chkDistrito As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lbly1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEdadHasta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEdadDesde As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbly2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRendimientoHasta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRendimientoDesde As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkRendimiento As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkVariedades As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkCiclo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDistanciaHasta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDistanciaDesde As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkDistancia As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cbxDrenaje As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents chkDrenaje As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkTextura As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkFechaEstimada As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbxFrente As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblFrente As DevExpress.XtraEditors.LabelControl
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents gcolDistritoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolDistrito As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolFrenteID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolFincaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolZonaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolDescripcionZona As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbxCicloHasta As System.Windows.Forms.ComboBox
    Friend WithEvents cbxCicloDesde As System.Windows.Forms.ComboBox
    Friend WithEvents gcolDrenajeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolDescripcionDrenaje As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtFechaEHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtFechaEDesde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents colSeleccion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDistritoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFincaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFinca As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLoteID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAreaEstimada As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAreaEjecutada As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAreaReal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRendimiento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colToneladasEstimadas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDistanciaIngenio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVariedadID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVariedadDescrip As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCicloID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCicloDescrip As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTexturaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTexturaDescrip As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrenajeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDrenajeDescrip As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDistanciaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDistanciaSiembra As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaEstimada As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPeriodoZafra As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEdadCaña As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colZonaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colZona As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmpresaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colestaProgramado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colestaMuestreado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colestaTerminado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetalleProgramaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGrupoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents listaTextura As System.Windows.Forms.CheckedListBox
    Friend WithEvents listaVariedades As System.Windows.Forms.CheckedListBox
    Friend WithEvents lblMinutaFrente As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblTotalMinutaFrente As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblTotalToneladas As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lblToneladas As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lblRegistros As System.Windows.Forms.ToolStripLabel
    Friend WithEvents RepItemChkSeleccion As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblRefFechaCalculoEdadCaña As System.Windows.Forms.ToolStripLabel
    Friend WithEvents colEstimadoGrupoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblPai1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblTituloTotalTonsxPrg As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblTotalTonsxPrg As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents XtraScrollableControl1 As DevExpress.XtraEditors.XtraScrollableControl
    Friend WithEvents lblPai2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblTituloTotalTonsAProcesar As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblTotalTonsAProcesar As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblPai3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblTituloTotalLotesAProcesar As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblTotalLotesAProcesar As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents colEstimadoProduccionID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolLoteTerminado As DevExpress.XtraGrid.Columns.GridColumn
End Class
