<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IDFImportFrm
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
        Me.XTTEmpaginacion = New DevExpress.XtraTab.XtraTabControl()
        Me.XTTPagina1 = New DevExpress.XtraTab.XtraTabPage()
        Me.GrdConsulta = New DevExpress.XtraGrid.GridControl()
        Me.GrdConsultaView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.TxtExoNum = New DevExpress.XtraEditors.TextEdit()
        Me.LblExoNum = New DevExpress.XtraEditors.LabelControl()
        Me.TxtNumLiq = New DevExpress.XtraEditors.TextEdit()
        Me.LblNumLiq = New DevExpress.XtraEditors.LabelControl()
        Me.LblFecha = New DevExpress.XtraEditors.LabelControl()
        Me.TxtNumDUA = New DevExpress.XtraEditors.TextEdit()
        Me.LblNumDua = New DevExpress.XtraEditors.LabelControl()
        Me.LblExoFec = New DevExpress.XtraEditors.LabelControl()
        Me.TxtImportID = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LblImportID = New DevExpress.XtraEditors.LabelControl()
        Me.TxtSdN = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TxtFecha = New DevExpress.XtraEditors.DateEdit()
        Me.TxtExoFec = New DevExpress.XtraEditors.DateEdit()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.CmbGrabarNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CmbGrabarSalir = New System.Windows.Forms.ToolStripButton()
        Me.CmbRegresarConsulta = New System.Windows.Forms.ToolStripButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtAnioAReportar = New DevExpress.XtraEditors.SpinEdit()
        Me.cbxMesAReportar = New DevExpress.XtraScheduler.UI.MonthEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
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
        CType(Me.TxtExoNum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNumLiq.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNumDUA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtImportID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSdN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtExoFec.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtExoFec.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtAnioAReportar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxMesAReportar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.XTTEmpaginacion.TabIndex = 13
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
        Me.GrdConsulta.Location = New System.Drawing.Point(0, 56)
        Me.GrdConsulta.MainView = Me.GrdConsultaView
        Me.GrdConsulta.Name = "GrdConsulta"
        Me.GrdConsulta.Size = New System.Drawing.Size(762, 484)
        Me.GrdConsulta.TabIndex = 11
        Me.GrdConsulta.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GrdConsultaView})
        '
        'GrdConsultaView
        '
        Me.GrdConsultaView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn5, Me.GridColumn6, Me.GridColumn4, Me.GridColumn7})
        Me.GrdConsultaView.GridControl = Me.GrdConsulta
        Me.GrdConsultaView.Name = "GrdConsultaView"
        Me.GrdConsultaView.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GrdConsultaView.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GrdConsultaView.OptionsView.ShowAutoFilterRow = True
        Me.GrdConsultaView.OptionsView.ShowFooter = True
        Me.GrdConsultaView.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "ImportID"
        Me.GridColumn1.FieldName = "ImportID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Socio de Negocios"
        Me.GridColumn2.FieldName = "SdN"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Descripción"
        Me.GridColumn3.FieldName = "SdNDescrip"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Número de DUA"
        Me.GridColumn5.FieldName = "NumDua"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 2
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Número de Liquidación"
        Me.GridColumn6.FieldName = "NumLiq"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 3
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Exoneración Resolución"
        Me.GridColumn4.FieldName = "ExoNum"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 4
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Exoneración Fecha Vencimiento"
        Me.GridColumn7.FieldName = "ExoFec"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 5
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
        Me.PCTEncabezado.Size = New System.Drawing.Size(672, 48)
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
        Me.XTTDatos.Size = New System.Drawing.Size(677, 394)
        Me.XTTDatos.TabIndex = 12
        Me.XTTDatos.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XTPBasico})
        '
        'XTPBasico
        '
        Me.XTPBasico.Controls.Add(Me.GroupControl1)
        Me.XTPBasico.Controls.Add(Me.TxtExoNum)
        Me.XTPBasico.Controls.Add(Me.LblExoNum)
        Me.XTPBasico.Controls.Add(Me.TxtNumLiq)
        Me.XTPBasico.Controls.Add(Me.LblNumLiq)
        Me.XTPBasico.Controls.Add(Me.LblFecha)
        Me.XTPBasico.Controls.Add(Me.TxtNumDUA)
        Me.XTPBasico.Controls.Add(Me.LblNumDua)
        Me.XTPBasico.Controls.Add(Me.LblExoFec)
        Me.XTPBasico.Controls.Add(Me.TxtImportID)
        Me.XTPBasico.Controls.Add(Me.LabelControl2)
        Me.XTPBasico.Controls.Add(Me.LblImportID)
        Me.XTPBasico.Controls.Add(Me.TxtSdN)
        Me.XTPBasico.Controls.Add(Me.TxtFecha)
        Me.XTPBasico.Controls.Add(Me.TxtExoFec)
        Me.XTPBasico.Name = "XTPBasico"
        Me.XTPBasico.Size = New System.Drawing.Size(671, 366)
        Me.XTPBasico.Text = "Básico"
        '
        'TxtExoNum
        '
        Me.TxtExoNum.Location = New System.Drawing.Point(135, 207)
        Me.TxtExoNum.Name = "TxtExoNum"
        Me.TxtExoNum.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtExoNum.Properties.Mask.EditMask = "[0-9A-F]{6}-[0-9A-F]{6}-[0-9A-F]{6}-[0-9A-F]{6}-[0-9A-F]{6}-[0-9A-F]{2}"
        Me.TxtExoNum.Size = New System.Drawing.Size(230, 20)
        Me.TxtExoNum.TabIndex = 11
        '
        'LblExoNum
        '
        Me.LblExoNum.Location = New System.Drawing.Point(7, 209)
        Me.LblExoNum.Name = "LblExoNum"
        Me.LblExoNum.Size = New System.Drawing.Size(106, 13)
        Me.LblExoNum.TabIndex = 10
        Me.LblExoNum.Text = "Número de Resolución"
        '
        'TxtNumLiq
        '
        Me.TxtNumLiq.Location = New System.Drawing.Point(135, 172)
        Me.TxtNumLiq.Name = "TxtNumLiq"
        Me.TxtNumLiq.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNumLiq.Properties.Mask.EditMask = "[0-9A-F]{6}-[0-9A-F]{6}-[0-9A-F]{6}-[0-9A-F]{6}-[0-9A-F]{6}-[0-9A-F]{2}"
        Me.TxtNumLiq.Size = New System.Drawing.Size(230, 20)
        Me.TxtNumLiq.TabIndex = 11
        '
        'LblNumLiq
        '
        Me.LblNumLiq.Location = New System.Drawing.Point(7, 174)
        Me.LblNumLiq.Name = "LblNumLiq"
        Me.LblNumLiq.Size = New System.Drawing.Size(107, 13)
        Me.LblNumLiq.TabIndex = 10
        Me.LblNumLiq.Text = "Número de Liquidación"
        '
        'LblFecha
        '
        Me.LblFecha.Location = New System.Drawing.Point(7, 136)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(79, 13)
        Me.LblFecha.TabIndex = 10
        Me.LblFecha.Text = "Fecha de la DUA"
        '
        'TxtNumDUA
        '
        Me.TxtNumDUA.Location = New System.Drawing.Point(135, 98)
        Me.TxtNumDUA.Name = "TxtNumDUA"
        Me.TxtNumDUA.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNumDUA.Properties.Mask.EditMask = "[0-9A-F]{6}-[0-9A-F]{6}-[0-9A-F]{6}-[0-9A-F]{6}-[0-9A-F]{6}-[0-9A-F]{2}"
        Me.TxtNumDUA.Size = New System.Drawing.Size(230, 20)
        Me.TxtNumDUA.TabIndex = 11
        '
        'LblNumDua
        '
        Me.LblNumDua.Location = New System.Drawing.Point(7, 100)
        Me.LblNumDua.Name = "LblNumDua"
        Me.LblNumDua.Size = New System.Drawing.Size(76, 13)
        Me.LblNumDua.TabIndex = 10
        Me.LblNumDua.Text = "Número de DUA"
        '
        'LblExoFec
        '
        Me.LblExoFec.Location = New System.Drawing.Point(7, 245)
        Me.LblExoFec.Name = "LblExoFec"
        Me.LblExoFec.Size = New System.Drawing.Size(89, 13)
        Me.LblExoFec.TabIndex = 9
        Me.LblExoFec.Text = "Fecha vencimiento"
        '
        'TxtImportID
        '
        Me.TxtImportID.Location = New System.Drawing.Point(135, 20)
        Me.TxtImportID.Name = "TxtImportID"
        Me.TxtImportID.Size = New System.Drawing.Size(230, 20)
        Me.TxtImportID.TabIndex = 4
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(7, 60)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(85, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Socio de negocios"
        '
        'LblImportID
        '
        Me.LblImportID.Location = New System.Drawing.Point(7, 20)
        Me.LblImportID.Name = "LblImportID"
        Me.LblImportID.Size = New System.Drawing.Size(71, 13)
        Me.LblImportID.TabIndex = 0
        Me.LblImportID.Text = "Importación ID"
        '
        'TxtSdN
        '
        Me.TxtSdN.Location = New System.Drawing.Point(135, 59)
        Me.TxtSdN.Name = "TxtSdN"
        Me.TxtSdN.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtSdN.Properties.NullText = ""
        Me.TxtSdN.Properties.View = Me.GridLookUpEdit1View
        Me.TxtSdN.Size = New System.Drawing.Size(394, 20)
        Me.TxtSdN.TabIndex = 5
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'TxtFecha
        '
        Me.TxtFecha.EditValue = Nothing
        Me.TxtFecha.Location = New System.Drawing.Point(135, 133)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtFecha.Properties.Mask.EditMask = ""
        Me.TxtFecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.TxtFecha.Size = New System.Drawing.Size(230, 20)
        Me.TxtFecha.TabIndex = 12
        '
        'TxtExoFec
        '
        Me.TxtExoFec.EditValue = Nothing
        Me.TxtExoFec.Location = New System.Drawing.Point(135, 242)
        Me.TxtExoFec.Name = "TxtExoFec"
        Me.TxtExoFec.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtExoFec.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtExoFec.Properties.Mask.EditMask = ""
        Me.TxtExoFec.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.TxtExoFec.Size = New System.Drawing.Size(230, 20)
        Me.TxtExoFec.TabIndex = 12
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
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtAnioAReportar)
        Me.GroupControl1.Controls.Add(Me.cbxMesAReportar)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Location = New System.Drawing.Point(135, 287)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(371, 51)
        Me.GroupControl1.TabIndex = 112
        Me.GroupControl1.Text = "Periodo a Reportar:"
        '
        'txtAnioAReportar
        '
        Me.txtAnioAReportar.EditValue = New Decimal(New Integer() {2012, 0, 0, 0})
        Me.txtAnioAReportar.Location = New System.Drawing.Point(41, 26)
        Me.txtAnioAReportar.Name = "txtAnioAReportar"
        Me.txtAnioAReportar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAnioAReportar.Properties.Mask.EditMask = "f0"
        Me.txtAnioAReportar.Properties.MaxValue = New Decimal(New Integer() {2050, 0, 0, 0})
        Me.txtAnioAReportar.Properties.MinValue = New Decimal(New Integer() {2012, 0, 0, 0})
        Me.txtAnioAReportar.Size = New System.Drawing.Size(100, 20)
        Me.txtAnioAReportar.TabIndex = 113
        '
        'cbxMesAReportar
        '
        Me.cbxMesAReportar.Location = New System.Drawing.Point(208, 26)
        Me.cbxMesAReportar.Name = "cbxMesAReportar"
        Me.cbxMesAReportar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxMesAReportar.Size = New System.Drawing.Size(156, 20)
        Me.cbxMesAReportar.TabIndex = 112
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(185, 26)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl1.TabIndex = 110
        Me.LabelControl1.Text = "Mes"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 26)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl3.TabIndex = 108
        Me.LabelControl3.Text = "Año:"
        '
        'IDFImportFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.Controls.Add(Me.XTTEmpaginacion)
        Me.Name = "IDFImportFrm"
        Me.Text = "Importaciones"
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
        CType(Me.TxtExoNum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNumLiq.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNumDUA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtImportID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSdN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtExoFec.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtExoFec.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtAnioAReportar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxMesAReportar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XTTEmpaginacion As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XTTPagina1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GrdConsulta As DevExpress.XtraGrid.GridControl
    Friend WithEvents GrdConsultaView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents TxtNumDUA As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblNumDua As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblExoFec As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtImportID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblImportID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtSdN As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TxtExoFec As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents CmbGrabarNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CmbGrabarSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents CmbRegresarConsulta As System.Windows.Forms.ToolStripButton
    Friend WithEvents TxtExoNum As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblExoNum As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtNumLiq As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblNumLiq As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblFecha As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtAnioAReportar As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents cbxMesAReportar As DevExpress.XtraScheduler.UI.MonthEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class
