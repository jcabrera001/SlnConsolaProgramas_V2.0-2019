<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenFacturasFrm
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
        Dim CmbRegCancelar As DevExpress.XtraEditors.SimpleButton
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GenFacturasFrm))
        Dim CmbRegActualizar As DevExpress.XtraEditors.SimpleButton
        Me.XTTEmpaginacion = New DevExpress.XtraTab.XtraTabControl()
        Me.XTTPagina1 = New DevExpress.XtraTab.XtraTabPage()
        Me.gc = New DevExpress.XtraGrid.GridControl()
        Me.gv = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CmbNuevo = New System.Windows.Forms.ToolStripButton()
        Me.CmbActualizarConsulta = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CmbEditar = New System.Windows.Forms.ToolStripButton()
        Me.cmbPrint = New System.Windows.Forms.ToolStripButton()
        Me.cmbAnular = New System.Windows.Forms.ToolStripButton()
        Me.XTTPagina2 = New DevExpress.XtraTab.XtraTabPage()
        Me.XTTDatos = New DevExpress.XtraTab.XtraTabControl()
        Me.XTPBasico = New DevExpress.XtraTab.XtraTabPage()
        Me.txtDescripcion = New System.Windows.Forms.RichTextBox()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbDepto = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEntidad = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtOt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.dtFecha = New DevExpress.XtraEditors.DateEdit()
        Me.txtUsuario = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.GrpRegistro = New System.Windows.Forms.GroupBox()
        Me.XtraTabControl2 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.cmbLabor = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtCuentaDet = New DevExpress.XtraEditors.TextEdit()
        Me.lblCuenta = New DevExpress.XtraEditors.LabelControl()
        Me.txtObservaciones = New System.Windows.Forms.RichTextBox()
        Me.txtCantidad = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbLaborTest = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.FlaFacturaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Codigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Descripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Cuenta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Tarifa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCosto = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEditDetail = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDetail = New DevExpress.XtraEditors.SimpleButton()
        Me.gcDetalle = New DevExpress.XtraGrid.GridControl()
        Me.gvDetalle = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.gcOT = New DevExpress.XtraGrid.GridControl()
        Me.GVOT = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtOTCuenta = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtOTEntidad = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtOTDescrip = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.chkContabilizado = New DevExpress.XtraEditors.CheckEdit()
        Me.chkAprobado = New DevExpress.XtraEditors.CheckEdit()
        Me.txtCodigo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LblCodigo = New DevExpress.XtraEditors.LabelControl()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.CmbGrabarNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CmbGrabarSalir = New System.Windows.Forms.ToolStripButton()
        Me.CmbRegresarConsulta = New System.Windows.Forms.ToolStripButton()
        Me.ProduccionDataSet = New ConsolaProgramas.ProduccionDataSet()
        CmbRegCancelar = New DevExpress.XtraEditors.SimpleButton()
        CmbRegActualizar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.XTTEmpaginacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTTEmpaginacion.SuspendLayout()
        Me.XTTPagina1.SuspendLayout()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenu.SuspendLayout()
        Me.XTTPagina2.SuspendLayout()
        CType(Me.XTTDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTTDatos.SuspendLayout()
        Me.XTPBasico.SuspendLayout()
        CType(Me.cmbDepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEntidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.GrpRegistro.SuspendLayout()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl2.SuspendLayout()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.cmbLabor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuentaDet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLaborTest.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCosto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.gcOT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVOT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOTCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOTEntidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOTDescrip.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkContabilizado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAprobado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.ProduccionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbRegCancelar
        '
        CmbRegCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CmbRegCancelar.ImageOptions.Image = CType(resources.GetObject("CmbRegCancelar.ImageOptions.Image"), System.Drawing.Image)
        CmbRegCancelar.Location = New System.Drawing.Point(616, 81)
        CmbRegCancelar.Name = "CmbRegCancelar"
        CmbRegCancelar.Size = New System.Drawing.Size(50, 50)
        CmbRegCancelar.TabIndex = 20
        CmbRegCancelar.ToolTip = "Cancelar cambios"
        AddHandler CmbRegCancelar.Click, AddressOf Me.CmbRegCancelar_Click
        '
        'CmbRegActualizar
        '
        CmbRegActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CmbRegActualizar.ImageOptions.Image = CType(resources.GetObject("CmbRegActualizar.ImageOptions.Image"), System.Drawing.Image)
        CmbRegActualizar.Location = New System.Drawing.Point(616, 25)
        CmbRegActualizar.Name = "CmbRegActualizar"
        CmbRegActualizar.Size = New System.Drawing.Size(50, 50)
        CmbRegActualizar.TabIndex = 19
        CmbRegActualizar.ToolTip = "Actualizar cambios"
        AddHandler CmbRegActualizar.Click, AddressOf Me.CmbRegActualizar_Click
        '
        'XTTEmpaginacion
        '
        Me.XTTEmpaginacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XTTEmpaginacion.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.XTTEmpaginacion.Location = New System.Drawing.Point(0, 13)
        Me.XTTEmpaginacion.Name = "XTTEmpaginacion"
        Me.XTTEmpaginacion.SelectedTabPage = Me.XTTPagina1
        Me.XTTEmpaginacion.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[False]
        Me.XTTEmpaginacion.Size = New System.Drawing.Size(916, 658)
        Me.XTTEmpaginacion.TabIndex = 14
        Me.XTTEmpaginacion.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XTTPagina1, Me.XTTPagina2})
        '
        'XTTPagina1
        '
        Me.XTTPagina1.Controls.Add(Me.gc)
        Me.XTTPagina1.Controls.Add(Me.tsMenu)
        Me.XTTPagina1.Name = "XTTPagina1"
        Me.XTTPagina1.Size = New System.Drawing.Size(914, 656)
        '
        'gc
        '
        Me.gc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gc.Location = New System.Drawing.Point(0, 56)
        Me.gc.MainView = Me.gv
        Me.gc.Name = "gc"
        Me.gc.Size = New System.Drawing.Size(904, 593)
        Me.gc.TabIndex = 11
        Me.gc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv})
        '
        'gv
        '
        Me.gv.GridControl = Me.gc
        Me.gv.Name = "gv"
        Me.gv.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.gv.OptionsFilter.UseNewCustomFilterDialog = True
        Me.gv.OptionsView.ShowAutoFilterRow = True
        Me.gv.OptionsView.ShowFooter = True
        Me.gv.OptionsView.ShowGroupPanel = False
        '
        'tsMenu
        '
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.CmbNuevo, Me.CmbActualizarConsulta, Me.ToolStripSeparator3, Me.CmbEditar, Me.cmbPrint, Me.cmbAnular})
        Me.tsMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(914, 53)
        Me.tsMenu.TabIndex = 10
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
        Me.CmbNuevo.Image = Global.ConsolaProgramas.My.Resources.Resources.page
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
        Me.CmbActualizarConsulta.Image = Global.ConsolaProgramas.My.Resources.Resources.arrow_refresh1
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
        'CmbEditar
        '
        Me.CmbEditar.AutoSize = False
        Me.CmbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmbEditar.Image = Global.ConsolaProgramas.My.Resources.Resources.page_edit
        Me.CmbEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmbEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmbEditar.Name = "CmbEditar"
        Me.CmbEditar.Size = New System.Drawing.Size(50, 50)
        Me.CmbEditar.Text = "Editar"
        '
        'cmbPrint
        '
        Me.cmbPrint.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmbPrint.AutoSize = False
        Me.cmbPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmbPrint.Image = Global.ConsolaProgramas.My.Resources.Resources.printer
        Me.cmbPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmbPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbPrint.Name = "cmbPrint"
        Me.cmbPrint.Size = New System.Drawing.Size(50, 50)
        Me.cmbPrint.Text = "Eliminar"
        '
        'cmbAnular
        '
        Me.cmbAnular.AutoToolTip = False
        Me.cmbAnular.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmbAnular.Image = Global.ConsolaProgramas.My.Resources.Resources.cancel1
        Me.cmbAnular.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmbAnular.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbAnular.Name = "cmbAnular"
        Me.cmbAnular.Size = New System.Drawing.Size(36, 50)
        Me.cmbAnular.Text = "ToolStripButton1"
        '
        'XTTPagina2
        '
        Me.XTTPagina2.Controls.Add(Me.XTTDatos)
        Me.XTTPagina2.Controls.Add(Me.ToolStrip1)
        Me.XTTPagina2.Name = "XTTPagina2"
        Me.XTTPagina2.Size = New System.Drawing.Size(914, 656)
        Me.XTTPagina2.Text = "XtraTabPage2"
        '
        'XTTDatos
        '
        Me.XTTDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XTTDatos.Location = New System.Drawing.Point(4, 56)
        Me.XTTDatos.Name = "XTTDatos"
        Me.XTTDatos.SelectedTabPage = Me.XTPBasico
        Me.XTTDatos.Size = New System.Drawing.Size(900, 593)
        Me.XTTDatos.TabIndex = 12
        Me.XTTDatos.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XTPBasico})
        '
        'XTPBasico
        '
        Me.XTPBasico.Controls.Add(Me.txtDescripcion)
        Me.XTPBasico.Controls.Add(Me.LabelControl9)
        Me.XTPBasico.Controls.Add(Me.cmbDepto)
        Me.XTPBasico.Controls.Add(Me.LabelControl1)
        Me.XTPBasico.Controls.Add(Me.txtEntidad)
        Me.XTPBasico.Controls.Add(Me.LabelControl5)
        Me.XTPBasico.Controls.Add(Me.txtOt)
        Me.XTPBasico.Controls.Add(Me.LabelControl4)
        Me.XTPBasico.Controls.Add(Me.dtFecha)
        Me.XTPBasico.Controls.Add(Me.txtUsuario)
        Me.XTPBasico.Controls.Add(Me.LabelControl3)
        Me.XTPBasico.Controls.Add(Me.XtraTabControl1)
        Me.XTPBasico.Controls.Add(Me.chkContabilizado)
        Me.XTPBasico.Controls.Add(Me.chkAprobado)
        Me.XTPBasico.Controls.Add(Me.txtCodigo)
        Me.XTPBasico.Controls.Add(Me.LabelControl2)
        Me.XTPBasico.Controls.Add(Me.LblCodigo)
        Me.XTPBasico.Name = "XTPBasico"
        Me.XTPBasico.Size = New System.Drawing.Size(898, 568)
        Me.XTPBasico.Text = "Básico"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(87, 57)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(628, 32)
        Me.txtDescripcion.TabIndex = 31
        Me.txtDescripcion.Text = ""
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(10, 61)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl9.TabIndex = 23
        Me.LabelControl9.Text = "Observaciones"
        '
        'cmbDepto
        '
        Me.cmbDepto.Location = New System.Drawing.Point(481, 3)
        Me.cmbDepto.Name = "cmbDepto"
        Me.cmbDepto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDepto.Size = New System.Drawing.Size(143, 20)
        Me.cmbDepto.TabIndex = 20
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(440, 7)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl1.TabIndex = 21
        Me.LabelControl1.Text = "Depto."
        '
        'txtEntidad
        '
        Me.txtEntidad.Location = New System.Drawing.Point(481, 32)
        Me.txtEntidad.Name = "txtEntidad"
        Me.txtEntidad.Size = New System.Drawing.Size(143, 20)
        Me.txtEntidad.TabIndex = 18
        Me.txtEntidad.Visible = False
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(434, 36)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl5.TabIndex = 19
        Me.LabelControl5.Text = "Entidad"
        Me.LabelControl5.Visible = False
        '
        'txtOt
        '
        Me.txtOt.Location = New System.Drawing.Point(283, 31)
        Me.txtOt.Name = "txtOt"
        Me.txtOt.Size = New System.Drawing.Size(143, 20)
        Me.txtOt.TabIndex = 16
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(261, 35)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(14, 13)
        Me.LabelControl4.TabIndex = 17
        Me.LabelControl4.Text = "OT"
        '
        'dtFecha
        '
        Me.dtFecha.EditValue = Nothing
        Me.dtFecha.Location = New System.Drawing.Point(87, 31)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFecha.Size = New System.Drawing.Size(139, 20)
        Me.dtFecha.TabIndex = 15
        '
        'txtUsuario
        '
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(283, 2)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(143, 20)
        Me.txtUsuario.TabIndex = 13
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(239, 6)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl3.TabIndex = 14
        Me.LabelControl3.Text = "Usuario"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(7, 95)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(888, 470)
        Me.XtraTabControl1.TabIndex = 10
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GrpRegistro)
        Me.XtraTabPage1.Controls.Add(Me.btnDelete)
        Me.XtraTabPage1.Controls.Add(Me.btnEditDetail)
        Me.XtraTabPage1.Controls.Add(Me.btnDetail)
        Me.XtraTabPage1.Controls.Add(Me.gcDetalle)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(886, 445)
        Me.XtraTabPage1.Text = "Detalle"
        '
        'GrpRegistro
        '
        Me.GrpRegistro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GrpRegistro.Controls.Add(CmbRegCancelar)
        Me.GrpRegistro.Controls.Add(CmbRegActualizar)
        Me.GrpRegistro.Controls.Add(Me.XtraTabControl2)
        Me.GrpRegistro.Location = New System.Drawing.Point(3, 296)
        Me.GrpRegistro.Name = "GrpRegistro"
        Me.GrpRegistro.Size = New System.Drawing.Size(674, 146)
        Me.GrpRegistro.TabIndex = 20
        Me.GrpRegistro.TabStop = False
        Me.GrpRegistro.Text = "Registro"
        Me.GrpRegistro.Visible = False
        '
        'XtraTabControl2
        '
        Me.XtraTabControl2.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Right
        Me.XtraTabControl2.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal
        Me.XtraTabControl2.Location = New System.Drawing.Point(8, 20)
        Me.XtraTabControl2.Name = "XtraTabControl2"
        Me.XtraTabControl2.SelectedTabPage = Me.XtraTabPage4
        Me.XtraTabControl2.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabControl2.Size = New System.Drawing.Size(602, 120)
        Me.XtraTabControl2.TabIndex = 0
        Me.XtraTabControl2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage4})
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.cmbLabor)
        Me.XtraTabPage4.Controls.Add(Me.txtCuentaDet)
        Me.XtraTabPage4.Controls.Add(Me.lblCuenta)
        Me.XtraTabPage4.Controls.Add(Me.txtObservaciones)
        Me.XtraTabPage4.Controls.Add(Me.txtCantidad)
        Me.XtraTabPage4.Controls.Add(Me.LabelControl10)
        Me.XtraTabPage4.Controls.Add(Me.cmbLaborTest)
        Me.XtraTabPage4.Controls.Add(Me.LabelControl11)
        Me.XtraTabPage4.Controls.Add(Me.txtCosto)
        Me.XtraTabPage4.Controls.Add(Me.LabelControl12)
        Me.XtraTabPage4.Controls.Add(Me.LabelControl13)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(552, 118)
        Me.XtraTabPage4.Text = "Detalle"
        '
        'cmbLabor
        '
        Me.cmbLabor.EditValue = ""
        Me.cmbLabor.Location = New System.Drawing.Point(84, 11)
        Me.cmbLabor.Name = "cmbLabor"
        Me.cmbLabor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbLabor.Properties.NullText = "Labores"
        Me.cmbLabor.Properties.PopupFormSize = New System.Drawing.Size(700, 0)
        Me.cmbLabor.Properties.PopupView = Me.GridView1
        Me.cmbLabor.Size = New System.Drawing.Size(441, 20)
        Me.cmbLabor.TabIndex = 33
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5})
        Me.GridView1.DetailHeight = 10000
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsEditForm.PopupEditFormWidth = 10000
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "FlaFacturaID"
        Me.GridColumn1.FieldName = "FlaFacturaID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Width = 65
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Codigo"
        Me.GridColumn2.FieldName = "Codigo"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 90
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Descripcion"
        Me.GridColumn3.FieldName = "Descripcion"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 100
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Cuenta"
        Me.GridColumn4.FieldName = "Cuenta"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        Me.GridColumn4.Width = 90
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Tarifa"
        Me.GridColumn5.FieldName = "Tarifa"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        Me.GridColumn5.Width = 104
        '
        'txtCuentaDet
        '
        Me.txtCuentaDet.Enabled = False
        Me.txtCuentaDet.Location = New System.Drawing.Point(234, 42)
        Me.txtCuentaDet.Name = "txtCuentaDet"
        Me.txtCuentaDet.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuentaDet.Size = New System.Drawing.Size(117, 20)
        Me.txtCuentaDet.TabIndex = 31
        '
        'lblCuenta
        '
        Me.lblCuenta.Location = New System.Drawing.Point(198, 46)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(35, 13)
        Me.lblCuenta.TabIndex = 32
        Me.lblCuenta.Text = "Cuenta"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(88, 70)
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(437, 40)
        Me.txtObservaciones.TabIndex = 30
        Me.txtObservaciones.Text = ""
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(426, 42)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCantidad.Size = New System.Drawing.Size(99, 20)
        Me.txtCantidad.TabIndex = 29
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(367, 46)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl10.TabIndex = 28
        Me.LabelControl10.Text = "Cantidad"
        '
        'cmbLaborTest
        '
        Me.cmbLaborTest.EditValue = "Labores"
        Me.cmbLaborTest.Location = New System.Drawing.Point(67, 56)
        Me.cmbLaborTest.Name = "cmbLaborTest"
        Me.cmbLaborTest.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbLaborTest.Properties.PopupView = Me.GridLookUpEdit1View
        Me.cmbLaborTest.Size = New System.Drawing.Size(437, 20)
        Me.cmbLaborTest.TabIndex = 1
        Me.cmbLaborTest.Visible = False
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.FlaFacturaID, Me.Codigo, Me.Descripcion, Me.Cuenta, Me.Tarifa})
        Me.GridLookUpEdit1View.DetailHeight = 10000
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsEditForm.PopupEditFormWidth = 10000
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'FlaFacturaID
        '
        Me.FlaFacturaID.Caption = "FlaFacturaID"
        Me.FlaFacturaID.FieldName = "FlaFacturaID"
        Me.FlaFacturaID.Name = "FlaFacturaID"
        '
        'Codigo
        '
        Me.Codigo.Caption = "Código"
        Me.Codigo.FieldName = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Codigo.Visible = True
        Me.Codigo.VisibleIndex = 0
        Me.Codigo.Width = 87
        '
        'Descripcion
        '
        Me.Descripcion.Caption = "Descripcion"
        Me.Descripcion.FieldName = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Descripcion.Visible = True
        Me.Descripcion.VisibleIndex = 1
        Me.Descripcion.Width = 170
        '
        'Cuenta
        '
        Me.Cuenta.Caption = "Cuenta"
        Me.Cuenta.FieldName = "Cuenta"
        Me.Cuenta.Name = "Cuenta"
        Me.Cuenta.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Cuenta.Visible = True
        Me.Cuenta.VisibleIndex = 2
        Me.Cuenta.Width = 100
        '
        'Tarifa
        '
        Me.Tarifa.Caption = "Tarifa"
        Me.Tarifa.FieldName = "Tarifa"
        Me.Tarifa.Name = "Tarifa"
        Me.Tarifa.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Tarifa.Visible = True
        Me.Tarifa.VisibleIndex = 3
        Me.Tarifa.Width = 90
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(7, 82)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl11.TabIndex = 27
        Me.LabelControl11.Text = "Observaciones"
        '
        'txtCosto
        '
        Me.txtCosto.Enabled = False
        Me.txtCosto.Location = New System.Drawing.Point(88, 42)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCosto.Size = New System.Drawing.Size(99, 20)
        Me.txtCosto.TabIndex = 11
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(50, 46)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl12.TabIndex = 14
        Me.LabelControl12.Text = "Tarifa"
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(51, 14)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl13.TabIndex = 5
        Me.LabelControl13.Text = "Labor"
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.ImageOptions.Image = CType(resources.GetObject("btnDelete.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDelete.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnDelete.Location = New System.Drawing.Point(828, 110)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(55, 50)
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.ToolTip = "Eliminar item"
        '
        'btnEditDetail
        '
        Me.btnEditDetail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditDetail.ImageOptions.Image = CType(resources.GetObject("btnEditDetail.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEditDetail.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnEditDetail.Location = New System.Drawing.Point(828, 57)
        Me.btnEditDetail.Name = "btnEditDetail"
        Me.btnEditDetail.Size = New System.Drawing.Size(55, 50)
        Me.btnEditDetail.TabIndex = 16
        Me.btnEditDetail.ToolTip = "Modificar item"
        '
        'btnDetail
        '
        Me.btnDetail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDetail.ImageOptions.Image = CType(resources.GetObject("btnDetail.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDetail.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnDetail.Location = New System.Drawing.Point(828, 4)
        Me.btnDetail.Name = "btnDetail"
        Me.btnDetail.Size = New System.Drawing.Size(55, 50)
        Me.btnDetail.TabIndex = 15
        Me.btnDetail.ToolTip = "Agregar item"
        '
        'gcDetalle
        '
        Me.gcDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcDetalle.Location = New System.Drawing.Point(3, 3)
        Me.gcDetalle.MainView = Me.gvDetalle
        Me.gcDetalle.Name = "gcDetalle"
        Me.gcDetalle.Size = New System.Drawing.Size(824, 287)
        Me.gcDetalle.TabIndex = 0
        Me.gcDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDetalle})
        '
        'gvDetalle
        '
        Me.gvDetalle.GridControl = Me.gcDetalle
        Me.gvDetalle.Name = "gvDetalle"
        Me.gvDetalle.OptionsView.ShowFooter = True
        Me.gvDetalle.OptionsView.ShowGroupPanel = False
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.gcOT)
        Me.XtraTabPage2.Controls.Add(Me.txtOTCuenta)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl8)
        Me.XtraTabPage2.Controls.Add(Me.txtOTEntidad)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl7)
        Me.XtraTabPage2.Controls.Add(Me.txtOTDescrip)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl6)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(886, 445)
        Me.XtraTabPage2.Text = "Detalle OT"
        '
        'gcOT
        '
        Me.gcOT.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcOT.Location = New System.Drawing.Point(3, 31)
        Me.gcOT.MainView = Me.GVOT
        Me.gcOT.Name = "gcOT"
        Me.gcOT.Size = New System.Drawing.Size(880, 403)
        Me.gcOT.TabIndex = 7
        Me.gcOT.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVOT})
        '
        'GVOT
        '
        Me.GVOT.GridControl = Me.gcOT
        Me.GVOT.Name = "GVOT"
        Me.GVOT.OptionsView.ShowGroupPanel = False
        '
        'txtOTCuenta
        '
        Me.txtOTCuenta.Enabled = False
        Me.txtOTCuenta.Location = New System.Drawing.Point(476, 5)
        Me.txtOTCuenta.Name = "txtOTCuenta"
        Me.txtOTCuenta.Size = New System.Drawing.Size(143, 20)
        Me.txtOTCuenta.TabIndex = 5
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(436, 9)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl8.TabIndex = 6
        Me.LabelControl8.Text = "Cuenta"
        '
        'txtOTEntidad
        '
        Me.txtOTEntidad.Enabled = False
        Me.txtOTEntidad.Location = New System.Drawing.Point(270, 4)
        Me.txtOTEntidad.Name = "txtOTEntidad"
        Me.txtOTEntidad.Size = New System.Drawing.Size(153, 20)
        Me.txtOTEntidad.TabIndex = 3
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(231, 8)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl7.TabIndex = 4
        Me.LabelControl7.Text = "Entidad"
        '
        'txtOTDescrip
        '
        Me.txtOTDescrip.Enabled = False
        Me.txtOTDescrip.Location = New System.Drawing.Point(67, 3)
        Me.txtOTDescrip.Name = "txtOTDescrip"
        Me.txtOTDescrip.Size = New System.Drawing.Size(153, 20)
        Me.txtOTDescrip.TabIndex = 1
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(10, 7)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl6.TabIndex = 2
        Me.LabelControl6.Text = "Descripción"
        '
        'chkContabilizado
        '
        Me.chkContabilizado.Enabled = False
        Me.chkContabilizado.Location = New System.Drawing.Point(640, 33)
        Me.chkContabilizado.Name = "chkContabilizado"
        Me.chkContabilizado.Properties.Caption = "Contabilizado"
        Me.chkContabilizado.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.chkContabilizado.Size = New System.Drawing.Size(75, 20)
        Me.chkContabilizado.TabIndex = 9
        '
        'chkAprobado
        '
        Me.chkAprobado.Enabled = False
        Me.chkAprobado.Location = New System.Drawing.Point(640, 4)
        Me.chkAprobado.Name = "chkAprobado"
        Me.chkAprobado.Properties.Caption = "Aprobado"
        Me.chkAprobado.Size = New System.Drawing.Size(75, 20)
        Me.chkAprobado.TabIndex = 8
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(87, 2)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(139, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(47, 35)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Fecha"
        '
        'LblCodigo
        '
        Me.LblCodigo.Location = New System.Drawing.Point(43, 6)
        Me.LblCodigo.Name = "LblCodigo"
        Me.LblCodigo.Size = New System.Drawing.Size(33, 13)
        Me.LblCodigo.TabIndex = 0
        Me.LblCodigo.Text = "Código"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CmbGrabarNuevo, Me.ToolStripSeparator2, Me.CmbGrabarSalir, Me.CmbRegresarConsulta})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(914, 53)
        Me.ToolStrip1.TabIndex = 11
        '
        'CmbGrabarNuevo
        '
        Me.CmbGrabarNuevo.AutoSize = False
        Me.CmbGrabarNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmbGrabarNuevo.Image = Global.ConsolaProgramas.My.Resources.Resources.page_save
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
        Me.CmbGrabarSalir.Image = Global.ConsolaProgramas.My.Resources.Resources.disk
        Me.CmbGrabarSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmbGrabarSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmbGrabarSalir.Name = "CmbGrabarSalir"
        Me.CmbGrabarSalir.Size = New System.Drawing.Size(50, 50)
        Me.CmbGrabarSalir.Text = "Grabar cambios"
        Me.CmbGrabarSalir.Visible = False
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
        'ProduccionDataSet
        '
        Me.ProduccionDataSet.DataSetName = "ProduccionDataSet"
        Me.ProduccionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GenFacturasFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 683)
        Me.Controls.Add(Me.XTTEmpaginacion)
        Me.Name = "GenFacturasFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generación de Facturas"
        CType(Me.XTTEmpaginacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTTEmpaginacion.ResumeLayout(False)
        Me.XTTPagina1.ResumeLayout(False)
        Me.XTTPagina1.PerformLayout()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.XTTPagina2.ResumeLayout(False)
        Me.XTTPagina2.PerformLayout()
        CType(Me.XTTDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTTDatos.ResumeLayout(False)
        Me.XTPBasico.ResumeLayout(False)
        Me.XTPBasico.PerformLayout()
        CType(Me.cmbDepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEntidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.GrpRegistro.ResumeLayout(False)
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl2.ResumeLayout(False)
        Me.XtraTabPage4.ResumeLayout(False)
        Me.XtraTabPage4.PerformLayout()
        CType(Me.cmbLabor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuentaDet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLaborTest.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCosto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.gcOT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVOT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOTCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOTEntidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOTDescrip.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkContabilizado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAprobado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ProduccionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XTTEmpaginacion As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XTTPagina1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gc As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents CmbEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CmbNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents CmbActualizarConsulta As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmbPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents XTTPagina2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XTTDatos As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XTPBasico As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtUsuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gcDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDetalle As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents chkContabilizado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkAprobado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblCodigo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents CmbGrabarNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CmbGrabarSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents CmbRegresarConsulta As System.Windows.Forms.ToolStripButton
    Friend WithEvents dtFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtEntidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtOt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gcOT As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVOT As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtOTCuenta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtOTEntidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtOTDescrip As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbDepto As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditDetail As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDetail As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GrpRegistro As System.Windows.Forms.GroupBox
    Friend WithEvents XtraTabControl2 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtObservaciones As System.Windows.Forms.RichTextBox
    Friend WithEvents txtCantidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCosto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCuentaDet As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCuenta As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbLaborTest As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ProduccionDataSet As ConsolaProgramas.ProduccionDataSet
    Friend WithEvents FlaFacturaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Codigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Descripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Cuenta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Tarifa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbAnular As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtDescripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbLabor As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
End Class
