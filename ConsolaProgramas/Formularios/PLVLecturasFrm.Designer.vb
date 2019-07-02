<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PLVLecturasFrm
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.XTTEmpaginacion = New DevExpress.XtraTab.XtraTabControl()
        Me.XTTPagina1 = New DevExpress.XtraTab.XtraTabPage()
        Me.GrdConsulta = New DevExpress.XtraGrid.GridControl()
        Me.GrdConsultaView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.LblFecha = New DevExpress.XtraEditors.LabelControl()
        Me.TxtEvaporacion = New DevExpress.XtraEditors.TextEdit()
        Me.LblEvaporacion = New DevExpress.XtraEditors.LabelControl()
        Me.TxtLectura = New DevExpress.XtraEditors.TextEdit()
        Me.LblLectura = New DevExpress.XtraEditors.LabelControl()
        Me.TxtObservaciones = New DevExpress.XtraEditors.TextEdit()
        Me.LblObservacion = New DevExpress.XtraEditors.LabelControl()
        Me.LbPluviometro = New DevExpress.XtraEditors.LabelControl()
        Me.TxtFecha = New DevExpress.XtraEditors.DateEdit()
        Me.TxtIDPluviometro = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GrdIDPluviometro = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XTPAvanzado = New DevExpress.XtraTab.XtraTabPage()
        Me.LblFechaEdicion = New DevExpress.XtraEditors.LabelControl()
        Me.LblFechaCreacion = New DevExpress.XtraEditors.LabelControl()
        Me.TxtIDUsuario = New DevExpress.XtraEditors.TextEdit()
        Me.LblIDUsuario = New DevExpress.XtraEditors.LabelControl()
        Me.TxtUsuarioEditor = New DevExpress.XtraEditors.TextEdit()
        Me.LblUsuarioEditor = New DevExpress.XtraEditors.LabelControl()
        Me.TxtUsuarioCreador = New DevExpress.XtraEditors.TextEdit()
        Me.LblUsuarioCreador = New DevExpress.XtraEditors.LabelControl()
        Me.TxtIDLectura = New DevExpress.XtraEditors.TextEdit()
        Me.LblIDLectura = New DevExpress.XtraEditors.LabelControl()
        Me.TxtFechaEdicion = New DevExpress.XtraEditors.DateEdit()
        Me.TxtFechaCreacion = New DevExpress.XtraEditors.DateEdit()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.CmbGrabarNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CmbGrabarSalir = New System.Windows.Forms.ToolStripButton()
        Me.CmbRegresarConsulta = New System.Windows.Forms.ToolStripButton()
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
        CType(Me.TxtEvaporacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtLectura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtObservaciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtIDPluviometro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdIDPluviometro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTPAvanzado.SuspendLayout()
        CType(Me.TxtIDUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUsuarioEditor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUsuarioCreador.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtIDLectura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFechaEdicion.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFechaEdicion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFechaCreacion.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFechaCreacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
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
        Me.XTTEmpaginacion.Size = New System.Drawing.Size(768, 549)
        Me.XTTEmpaginacion.TabIndex = 16
        Me.XTTEmpaginacion.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XTTPagina1, Me.XTTPagina2})
        '
        'XTTPagina1
        '
        Me.XTTPagina1.Controls.Add(Me.GrdConsulta)
        Me.XTTPagina1.Controls.Add(Me.tsMenu)
        Me.XTTPagina1.Name = "XTTPagina1"
        Me.XTTPagina1.Size = New System.Drawing.Size(762, 543)
        '
        'GrdConsulta
        '
        Me.GrdConsulta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        GridLevelNode1.RelationName = "Level1"
        Me.GrdConsulta.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GrdConsulta.Location = New System.Drawing.Point(0, 56)
        Me.GrdConsulta.MainView = Me.GrdConsultaView
        Me.GrdConsulta.Name = "GrdConsulta"
        Me.GrdConsulta.Size = New System.Drawing.Size(762, 484)
        Me.GrdConsulta.TabIndex = 11
        Me.GrdConsulta.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GrdConsultaView})
        '
        'GrdConsultaView
        '
        Me.GrdConsultaView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn6, Me.GridColumn4, Me.GridColumn5})
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
        Me.GridColumn1.Caption = "Lectura ID"
        Me.GridColumn1.FieldName = "idLectura"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Pluviómetro"
        Me.GridColumn2.FieldName = "idPluviometro"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Fecha"
        Me.GridColumn3.FieldName = "fecha"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Lectura"
        Me.GridColumn6.FieldName = "lectura"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        Me.GridColumn6.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 3
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Evaporación"
        Me.GridColumn4.FieldName = "evaporacion"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 4
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Observación"
        Me.GridColumn5.FieldName = "observacion"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 5
        '
        'tsMenu
        '
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CmbEditar, Me.ToolStripSeparator1, Me.CmbNuevo, Me.CmbActualizarConsulta, Me.ToolStripSeparator3, Me.CmbEliminar})
        Me.tsMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(762, 53)
        Me.tsMenu.TabIndex = 10
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
        'CmbEliminar
        '
        Me.CmbEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.CmbEliminar.AutoSize = False
        Me.CmbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmbEliminar.Enabled = False
        Me.CmbEliminar.Image = Global.ConsolaProgramas.My.Resources.Resources.delete1
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
        Me.XTTPagina2.Size = New System.Drawing.Size(762, 543)
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
        Me.XTTDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XTTDatos.Location = New System.Drawing.Point(4, 111)
        Me.XTTDatos.Name = "XTTDatos"
        Me.XTTDatos.SelectedTabPage = Me.XTPBasico
        Me.XTTDatos.Size = New System.Drawing.Size(755, 432)
        Me.XTTDatos.TabIndex = 12
        Me.XTTDatos.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XTPBasico, Me.XTPAvanzado})
        '
        'XTPBasico
        '
        Me.XTPBasico.Controls.Add(Me.LblFecha)
        Me.XTPBasico.Controls.Add(Me.TxtEvaporacion)
        Me.XTPBasico.Controls.Add(Me.LblEvaporacion)
        Me.XTPBasico.Controls.Add(Me.TxtLectura)
        Me.XTPBasico.Controls.Add(Me.LblLectura)
        Me.XTPBasico.Controls.Add(Me.TxtObservaciones)
        Me.XTPBasico.Controls.Add(Me.LblObservacion)
        Me.XTPBasico.Controls.Add(Me.LbPluviometro)
        Me.XTPBasico.Controls.Add(Me.TxtFecha)
        Me.XTPBasico.Controls.Add(Me.TxtIDPluviometro)
        Me.XTPBasico.Name = "XTPBasico"
        Me.XTPBasico.Size = New System.Drawing.Size(749, 404)
        Me.XTPBasico.Text = "Básico"
        '
        'LblFecha
        '
        Me.LblFecha.Location = New System.Drawing.Point(20, 50)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(29, 13)
        Me.LblFecha.TabIndex = 3
        Me.LblFecha.Text = "Fecha"
        '
        'TxtEvaporacion
        '
        Me.TxtEvaporacion.Location = New System.Drawing.Point(150, 140)
        Me.TxtEvaporacion.Name = "TxtEvaporacion"
        Me.TxtEvaporacion.Size = New System.Drawing.Size(215, 20)
        Me.TxtEvaporacion.TabIndex = 2
        '
        'LblEvaporacion
        '
        Me.LblEvaporacion.Location = New System.Drawing.Point(20, 140)
        Me.LblEvaporacion.Name = "LblEvaporacion"
        Me.LblEvaporacion.Size = New System.Drawing.Size(59, 13)
        Me.LblEvaporacion.TabIndex = 1
        Me.LblEvaporacion.Text = "Evaporación"
        '
        'TxtLectura
        '
        Me.TxtLectura.Location = New System.Drawing.Point(150, 110)
        Me.TxtLectura.Name = "TxtLectura"
        Me.TxtLectura.Size = New System.Drawing.Size(215, 20)
        Me.TxtLectura.TabIndex = 2
        '
        'LblLectura
        '
        Me.LblLectura.Location = New System.Drawing.Point(20, 110)
        Me.LblLectura.Name = "LblLectura"
        Me.LblLectura.Size = New System.Drawing.Size(36, 13)
        Me.LblLectura.TabIndex = 1
        Me.LblLectura.Text = "Lectura"
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.Location = New System.Drawing.Point(150, 170)
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.Size = New System.Drawing.Size(437, 20)
        Me.TxtObservaciones.TabIndex = 2
        '
        'LblObservacion
        '
        Me.LblObservacion.Location = New System.Drawing.Point(20, 170)
        Me.LblObservacion.Name = "LblObservacion"
        Me.LblObservacion.Size = New System.Drawing.Size(60, 13)
        Me.LblObservacion.TabIndex = 1
        Me.LblObservacion.Text = "Observación"
        '
        'LbPluviometro
        '
        Me.LbPluviometro.Location = New System.Drawing.Point(20, 80)
        Me.LbPluviometro.Name = "LbPluviometro"
        Me.LbPluviometro.Size = New System.Drawing.Size(56, 13)
        Me.LbPluviometro.TabIndex = 1
        Me.LbPluviometro.Text = "Pluviometro"
        '
        'TxtFecha
        '
        Me.TxtFecha.EditValue = Nothing
        Me.TxtFecha.Location = New System.Drawing.Point(150, 50)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtFecha.Properties.Mask.EditMask = ""
        Me.TxtFecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.TxtFecha.Size = New System.Drawing.Size(207, 20)
        Me.TxtFecha.TabIndex = 4
        '
        'TxtIDPluviometro
        '
        Me.TxtIDPluviometro.Location = New System.Drawing.Point(150, 80)
        Me.TxtIDPluviometro.Name = "TxtIDPluviometro"
        Me.TxtIDPluviometro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtIDPluviometro.Properties.NullText = ""
        Me.TxtIDPluviometro.Properties.View = Me.GrdIDPluviometro
        Me.TxtIDPluviometro.Size = New System.Drawing.Size(437, 20)
        Me.TxtIDPluviometro.TabIndex = 2
        '
        'GrdIDPluviometro
        '
        Me.GrdIDPluviometro.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GrdIDPluviometro.Name = "GrdIDPluviometro"
        Me.GrdIDPluviometro.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GrdIDPluviometro.OptionsView.ShowGroupPanel = False
        '
        'XTPAvanzado
        '
        Me.XTPAvanzado.Controls.Add(Me.LblFechaEdicion)
        Me.XTPAvanzado.Controls.Add(Me.LblFechaCreacion)
        Me.XTPAvanzado.Controls.Add(Me.TxtIDUsuario)
        Me.XTPAvanzado.Controls.Add(Me.LblIDUsuario)
        Me.XTPAvanzado.Controls.Add(Me.TxtUsuarioEditor)
        Me.XTPAvanzado.Controls.Add(Me.LblUsuarioEditor)
        Me.XTPAvanzado.Controls.Add(Me.TxtUsuarioCreador)
        Me.XTPAvanzado.Controls.Add(Me.LblUsuarioCreador)
        Me.XTPAvanzado.Controls.Add(Me.TxtIDLectura)
        Me.XTPAvanzado.Controls.Add(Me.LblIDLectura)
        Me.XTPAvanzado.Controls.Add(Me.TxtFechaEdicion)
        Me.XTPAvanzado.Controls.Add(Me.TxtFechaCreacion)
        Me.XTPAvanzado.Name = "XTPAvanzado"
        Me.XTPAvanzado.Size = New System.Drawing.Size(749, 404)
        Me.XTPAvanzado.Text = "Avanzado"
        '
        'LblFechaEdicion
        '
        Me.LblFechaEdicion.Location = New System.Drawing.Point(20, 200)
        Me.LblFechaEdicion.Name = "LblFechaEdicion"
        Me.LblFechaEdicion.Size = New System.Drawing.Size(96, 13)
        Me.LblFechaEdicion.TabIndex = 2
        Me.LblFechaEdicion.Text = "Fecha última edición"
        '
        'LblFechaCreacion
        '
        Me.LblFechaCreacion.Location = New System.Drawing.Point(20, 170)
        Me.LblFechaCreacion.Name = "LblFechaCreacion"
        Me.LblFechaCreacion.Size = New System.Drawing.Size(89, 13)
        Me.LblFechaCreacion.TabIndex = 2
        Me.LblFechaCreacion.Text = "Fecha de Creación"
        '
        'TxtIDUsuario
        '
        Me.TxtIDUsuario.Location = New System.Drawing.Point(150, 140)
        Me.TxtIDUsuario.Name = "TxtIDUsuario"
        Me.TxtIDUsuario.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtIDUsuario.Size = New System.Drawing.Size(230, 20)
        Me.TxtIDUsuario.TabIndex = 3
        '
        'LblIDUsuario
        '
        Me.LblIDUsuario.Location = New System.Drawing.Point(20, 140)
        Me.LblIDUsuario.Name = "LblIDUsuario"
        Me.LblIDUsuario.Size = New System.Drawing.Size(99, 13)
        Me.LblIDUsuario.TabIndex = 2
        Me.LblIDUsuario.Text = "Usuario de Muestreo"
        '
        'TxtUsuarioEditor
        '
        Me.TxtUsuarioEditor.Location = New System.Drawing.Point(150, 110)
        Me.TxtUsuarioEditor.Name = "TxtUsuarioEditor"
        Me.TxtUsuarioEditor.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtUsuarioEditor.Size = New System.Drawing.Size(230, 20)
        Me.TxtUsuarioEditor.TabIndex = 3
        '
        'LblUsuarioEditor
        '
        Me.LblUsuarioEditor.Location = New System.Drawing.Point(20, 114)
        Me.LblUsuarioEditor.Name = "LblUsuarioEditor"
        Me.LblUsuarioEditor.Size = New System.Drawing.Size(67, 13)
        Me.LblUsuarioEditor.TabIndex = 2
        Me.LblUsuarioEditor.Text = "Usuario Editor"
        '
        'TxtUsuarioCreador
        '
        Me.TxtUsuarioCreador.Location = New System.Drawing.Point(150, 80)
        Me.TxtUsuarioCreador.Name = "TxtUsuarioCreador"
        Me.TxtUsuarioCreador.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtUsuarioCreador.Size = New System.Drawing.Size(230, 20)
        Me.TxtUsuarioCreador.TabIndex = 3
        '
        'LblUsuarioCreador
        '
        Me.LblUsuarioCreador.Location = New System.Drawing.Point(20, 80)
        Me.LblUsuarioCreador.Name = "LblUsuarioCreador"
        Me.LblUsuarioCreador.Size = New System.Drawing.Size(78, 13)
        Me.LblUsuarioCreador.TabIndex = 2
        Me.LblUsuarioCreador.Text = "Usuario Creador"
        '
        'TxtIDLectura
        '
        Me.TxtIDLectura.Location = New System.Drawing.Point(150, 50)
        Me.TxtIDLectura.Name = "TxtIDLectura"
        Me.TxtIDLectura.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtIDLectura.Size = New System.Drawing.Size(230, 20)
        Me.TxtIDLectura.TabIndex = 3
        '
        'LblIDLectura
        '
        Me.LblIDLectura.Location = New System.Drawing.Point(20, 50)
        Me.LblIDLectura.Name = "LblIDLectura"
        Me.LblIDLectura.Size = New System.Drawing.Size(70, 13)
        Me.LblIDLectura.TabIndex = 2
        Me.LblIDLectura.Text = "Código interno"
        '
        'TxtFechaEdicion
        '
        Me.TxtFechaEdicion.EditValue = Nothing
        Me.TxtFechaEdicion.Location = New System.Drawing.Point(150, 200)
        Me.TxtFechaEdicion.Name = "TxtFechaEdicion"
        Me.TxtFechaEdicion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtFechaEdicion.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtFechaEdicion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtFechaEdicion.Properties.Mask.EditMask = ""
        Me.TxtFechaEdicion.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.TxtFechaEdicion.Size = New System.Drawing.Size(230, 20)
        Me.TxtFechaEdicion.TabIndex = 3
        '
        'TxtFechaCreacion
        '
        Me.TxtFechaCreacion.EditValue = Nothing
        Me.TxtFechaCreacion.Location = New System.Drawing.Point(150, 170)
        Me.TxtFechaCreacion.Name = "TxtFechaCreacion"
        Me.TxtFechaCreacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtFechaCreacion.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtFechaCreacion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtFechaCreacion.Properties.Mask.EditMask = ""
        Me.TxtFechaCreacion.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.TxtFechaCreacion.Size = New System.Drawing.Size(230, 20)
        Me.TxtFechaCreacion.TabIndex = 3
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CmbGrabarNuevo, Me.ToolStripSeparator2, Me.CmbGrabarSalir, Me.CmbRegresarConsulta})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(762, 53)
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
        'PLVLecturasFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.Controls.Add(Me.XTTEmpaginacion)
        Me.Name = "PLVLecturasFrm"
        Me.Text = "Lecturas de pluviómetros"
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
        CType(Me.TxtEvaporacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtLectura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtObservaciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtIDPluviometro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdIDPluviometro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTPAvanzado.ResumeLayout(False)
        Me.XTPAvanzado.PerformLayout()
        CType(Me.TxtIDUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUsuarioEditor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUsuarioCreador.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtIDLectura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFechaEdicion.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFechaEdicion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFechaCreacion.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFechaCreacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
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
    Friend WithEvents LblFecha As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LbPluviometro As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents XTPAvanzado As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LblFechaEdicion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblFechaCreacion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtIDUsuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblIDUsuario As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtUsuarioEditor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblUsuarioEditor As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtUsuarioCreador As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblUsuarioCreador As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtIDLectura As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblIDLectura As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtFechaEdicion As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TxtFechaCreacion As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents CmbGrabarNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CmbGrabarSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents CmbRegresarConsulta As System.Windows.Forms.ToolStripButton
    Friend WithEvents TxtLectura As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblLectura As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtEvaporacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblEvaporacion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtObservaciones As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblObservacion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtIDPluviometro As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GrdIDPluviometro As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
End Class
