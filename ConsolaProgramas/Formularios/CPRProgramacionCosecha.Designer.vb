<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CPRProgramacionCosecha
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
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.cmbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.cmbBuscarLotes = New System.Windows.Forms.ToolStripButton()
        Me.cmbLimpiar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmbMarcarTodos = New System.Windows.Forms.ToolStripButton()
        Me.cmbQuitarTodos = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmbAprobarTodos = New System.Windows.Forms.ToolStripButton()
        Me.cmbDesaprobarTodos = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmbBorrarMarcados = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmbSalir = New System.Windows.Forms.ToolStripButton()
        Me.gbxDatosPrograma = New DevExpress.XtraEditors.GroupControl()
        Me.cmbVerDetalle = New System.Windows.Forms.Button()
        Me.txtDistanciaMeta = New DevExpress.XtraEditors.TextEdit()
        Me.lblDistanciaMeta = New DevExpress.XtraEditors.LabelControl()
        Me.txtHasta = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDesde = New DevExpress.XtraEditors.TextEdit()
        Me.lblDesde = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtFecha = New DevExpress.XtraEditors.DateEdit()
        Me.lblFechaCreacion = New DevExpress.XtraEditors.LabelControl()
        Me.txtUsuario = New DevExpress.XtraEditors.TextEdit()
        Me.lblUsuarioCreacion = New DevExpress.XtraEditors.LabelControl()
        Me.txtTipoPrograma = New DevExpress.XtraEditors.TextEdit()
        Me.lblTipoPrograma = New DevExpress.XtraEditors.LabelControl()
        Me.txtTipoPeriodo = New DevExpress.XtraEditors.TextEdit()
        Me.lblTipoPeriodo = New DevExpress.XtraEditors.LabelControl()
        Me.txtZafra = New DevExpress.XtraEditors.TextEdit()
        Me.lblZafra = New DevExpress.XtraEditors.LabelControl()
        Me.txtDescripcion = New DevExpress.XtraEditors.TextEdit()
        Me.lblDescripcion = New DevExpress.XtraEditors.LabelControl()
        Me.txtProgramaID = New DevExpress.XtraEditors.TextEdit()
        Me.lblProgramaID = New DevExpress.XtraEditors.LabelControl()
        Me.lblPrograma = New DevExpress.XtraEditors.LabelControl()
        Me.cbxProgramas = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcolProgramaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcDatos = New DevExpress.XtraGrid.GridControl()
        Me.dgvDatos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcolSeleccionar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemChkSeleccionar = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.gcolEstaAprobado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemChkAprobado = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.gcolDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolFechaEstimada = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolToneladasEstimadas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolDistritoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolxFincaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolLoteID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolDistanciaIngenio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolVariedadID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolVariedadDescrip = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolCicloID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolCicloDescrip = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolTexturaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolTexturaDescrip = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolDrenajeID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolDrenajeDescrip = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolRendimiento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolDistanciaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolDistanciaSiembraDescrip = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolFrente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolPromedioPonderado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolDetalleProgramaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolProgramaIDE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolEstimadoProduccionID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolEstimadoGrupoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gbxModificacion = New DevExpress.XtraEditors.GroupControl()
        Me.txtFechaEDesde = New DevExpress.XtraEditors.DateEdit()
        Me.txtToneladasReales = New DevExpress.XtraEditors.TextEdit()
        Me.txtAreaCosecha = New DevExpress.XtraEditors.TextEdit()
        Me.cbxCategoria = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcolResultadoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolxDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtRendProLab = New DevExpress.XtraEditors.TextEdit()
        Me.lblToneladasReales = New DevExpress.XtraEditors.LabelControl()
        Me.lblAreaCosecha = New DevExpress.XtraEditors.LabelControl()
        Me.lblCategoria = New DevExpress.XtraEditors.LabelControl()
        Me.lblRenProLab = New DevExpress.XtraEditors.LabelControl()
        Me.lblFechaCosecha = New DevExpress.XtraEditors.LabelControl()
        Me.tsMenu.SuspendLayout()
        CType(Me.gbxDatosPrograma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDatosPrograma.SuspendLayout()
        CType(Me.txtDistanciaMeta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipoPrograma.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipoPeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtZafra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProgramaID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxProgramas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemChkSeleccionar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemChkAprobado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbxModificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxModificacion.SuspendLayout()
        CType(Me.txtFechaEDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaEDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToneladasReales.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAreaCosecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxCategoria.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRendProLab.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsMenu
        '
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmbGuardar, Me.cmbBuscarLotes, Me.cmbLimpiar, Me.ToolStripSeparator1, Me.cmbMarcarTodos, Me.cmbQuitarTodos, Me.ToolStripSeparator2, Me.cmbAprobarTodos, Me.cmbDesaprobarTodos, Me.ToolStripSeparator4, Me.cmbBorrarMarcados, Me.ToolStripSeparator3, Me.cmbSalir})
        Me.tsMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(1028, 52)
        Me.tsMenu.TabIndex = 9
        '
        'cmbGuardar
        '
        Me.cmbGuardar.Image = Global.ConsolaProgramas.My.Resources.Resources.page_save
        Me.cmbGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbGuardar.Name = "cmbGuardar"
        Me.cmbGuardar.Size = New System.Drawing.Size(50, 49)
        Me.cmbGuardar.Text = "Guardar"
        Me.cmbGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmbBuscarLotes
        '
        Me.cmbBuscarLotes.Enabled = False
        Me.cmbBuscarLotes.Image = Global.ConsolaProgramas.My.Resources.Resources.table_relationship
        Me.cmbBuscarLotes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmbBuscarLotes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbBuscarLotes.Name = "cmbBuscarLotes"
        Me.cmbBuscarLotes.Size = New System.Drawing.Size(72, 49)
        Me.cmbBuscarLotes.Text = "Buscar Lotes"
        Me.cmbBuscarLotes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmbLimpiar
        '
        Me.cmbLimpiar.Image = Global.ConsolaProgramas.My.Resources.Resources.application_form
        Me.cmbLimpiar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmbLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbLimpiar.Name = "cmbLimpiar"
        Me.cmbLimpiar.Size = New System.Drawing.Size(44, 49)
        Me.cmbLimpiar.Text = "Limpiar"
        Me.cmbLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        Me.cmbQuitarTodos.Image = Global.ConsolaProgramas.My.Resources.Resources.application1
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
        'cmbAprobarTodos
        '
        Me.cmbAprobarTodos.Image = Global.ConsolaProgramas.My.Resources.Resources.accept
        Me.cmbAprobarTodos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmbAprobarTodos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbAprobarTodos.Name = "cmbAprobarTodos"
        Me.cmbAprobarTodos.Size = New System.Drawing.Size(99, 49)
        Me.cmbAprobarTodos.Text = "Aprobar Marcados"
        Me.cmbAprobarTodos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmbDesaprobarTodos
        '
        Me.cmbDesaprobarTodos.Image = Global.ConsolaProgramas.My.Resources.Resources.delete
        Me.cmbDesaprobarTodos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmbDesaprobarTodos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbDesaprobarTodos.Name = "cmbDesaprobarTodos"
        Me.cmbDesaprobarTodos.Size = New System.Drawing.Size(116, 49)
        Me.cmbDesaprobarTodos.Text = "Desaprobar Marcados"
        Me.cmbDesaprobarTodos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 52)
        '
        'cmbBorrarMarcados
        '
        Me.cmbBorrarMarcados.Image = Global.ConsolaProgramas.My.Resources.Resources.cancel
        Me.cmbBorrarMarcados.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmbBorrarMarcados.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbBorrarMarcados.Name = "cmbBorrarMarcados"
        Me.cmbBorrarMarcados.Size = New System.Drawing.Size(90, 49)
        Me.cmbBorrarMarcados.Text = "Borrar Marcados"
        Me.cmbBorrarMarcados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'gbxDatosPrograma
        '
        Me.gbxDatosPrograma.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxDatosPrograma.Controls.Add(Me.cmbVerDetalle)
        Me.gbxDatosPrograma.Controls.Add(Me.txtDistanciaMeta)
        Me.gbxDatosPrograma.Controls.Add(Me.lblDistanciaMeta)
        Me.gbxDatosPrograma.Controls.Add(Me.txtHasta)
        Me.gbxDatosPrograma.Controls.Add(Me.LabelControl1)
        Me.gbxDatosPrograma.Controls.Add(Me.txtDesde)
        Me.gbxDatosPrograma.Controls.Add(Me.lblDesde)
        Me.gbxDatosPrograma.Controls.Add(Me.GroupControl1)
        Me.gbxDatosPrograma.Controls.Add(Me.txtTipoPrograma)
        Me.gbxDatosPrograma.Controls.Add(Me.lblTipoPrograma)
        Me.gbxDatosPrograma.Controls.Add(Me.txtTipoPeriodo)
        Me.gbxDatosPrograma.Controls.Add(Me.lblTipoPeriodo)
        Me.gbxDatosPrograma.Controls.Add(Me.txtZafra)
        Me.gbxDatosPrograma.Controls.Add(Me.lblZafra)
        Me.gbxDatosPrograma.Controls.Add(Me.txtDescripcion)
        Me.gbxDatosPrograma.Controls.Add(Me.lblDescripcion)
        Me.gbxDatosPrograma.Controls.Add(Me.txtProgramaID)
        Me.gbxDatosPrograma.Controls.Add(Me.lblProgramaID)
        Me.gbxDatosPrograma.Controls.Add(Me.lblPrograma)
        Me.gbxDatosPrograma.Controls.Add(Me.cbxProgramas)
        Me.gbxDatosPrograma.Location = New System.Drawing.Point(0, 56)
        Me.gbxDatosPrograma.Name = "gbxDatosPrograma"
        Me.gbxDatosPrograma.Size = New System.Drawing.Size(1028, 151)
        Me.gbxDatosPrograma.TabIndex = 10
        Me.gbxDatosPrograma.Text = "Datos del Programa"
        '
        'cmbVerDetalle
        '
        Me.cmbVerDetalle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbVerDetalle.Enabled = False
        Me.cmbVerDetalle.Image = Global.ConsolaProgramas.My.Resources.Resources.zoom_in
        Me.cmbVerDetalle.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cmbVerDetalle.Location = New System.Drawing.Point(683, 29)
        Me.cmbVerDetalle.Name = "cmbVerDetalle"
        Me.cmbVerDetalle.Size = New System.Drawing.Size(98, 23)
        Me.cmbVerDetalle.TabIndex = 39
        Me.cmbVerDetalle.Text = "Ver Detalle"
        Me.cmbVerDetalle.UseVisualStyleBackColor = True
        '
        'txtDistanciaMeta
        '
        Me.txtDistanciaMeta.EditValue = ""
        Me.txtDistanciaMeta.Location = New System.Drawing.Point(775, 122)
        Me.txtDistanciaMeta.Name = "txtDistanciaMeta"
        Me.txtDistanciaMeta.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtDistanciaMeta.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtDistanciaMeta.Properties.Appearance.Options.UseBackColor = True
        Me.txtDistanciaMeta.Properties.ReadOnly = True
        Me.txtDistanciaMeta.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDistanciaMeta.Size = New System.Drawing.Size(125, 20)
        Me.txtDistanciaMeta.TabIndex = 38
        '
        'lblDistanciaMeta
        '
        Me.lblDistanciaMeta.Location = New System.Drawing.Point(685, 126)
        Me.lblDistanciaMeta.Name = "lblDistanciaMeta"
        Me.lblDistanciaMeta.Size = New System.Drawing.Size(74, 13)
        Me.lblDistanciaMeta.TabIndex = 37
        Me.lblDistanciaMeta.Text = "Distancia Meta:"
        '
        'txtHasta
        '
        Me.txtHasta.EditValue = ""
        Me.txtHasta.Location = New System.Drawing.Point(775, 91)
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtHasta.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtHasta.Properties.Appearance.Options.UseBackColor = True
        Me.txtHasta.Properties.ReadOnly = True
        Me.txtHasta.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtHasta.Size = New System.Drawing.Size(125, 20)
        Me.txtHasta.TabIndex = 36
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(683, 96)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl1.TabIndex = 35
        Me.LabelControl1.Text = "Hasta:"
        '
        'txtDesde
        '
        Me.txtDesde.EditValue = ""
        Me.txtDesde.Location = New System.Drawing.Point(775, 63)
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtDesde.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtDesde.Properties.Appearance.Options.UseBackColor = True
        Me.txtDesde.Properties.ReadOnly = True
        Me.txtDesde.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDesde.Size = New System.Drawing.Size(125, 20)
        Me.txtDesde.TabIndex = 34
        '
        'lblDesde
        '
        Me.lblDesde.Location = New System.Drawing.Point(683, 64)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(34, 13)
        Me.lblDesde.TabIndex = 33
        Me.lblDesde.Text = "Desde:"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtFecha)
        Me.GroupControl1.Controls.Add(Me.lblFechaCreacion)
        Me.GroupControl1.Controls.Add(Me.txtUsuario)
        Me.GroupControl1.Controls.Add(Me.lblUsuarioCreacion)
        Me.GroupControl1.Location = New System.Drawing.Point(924, 27)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(165, 115)
        Me.GroupControl1.TabIndex = 32
        Me.GroupControl1.Text = "Datos de Registro"
        '
        'txtFecha
        '
        Me.txtFecha.EditValue = Nothing
        Me.txtFecha.Enabled = False
        Me.txtFecha.EnterMoveNextControl = True
        Me.txtFecha.Location = New System.Drawing.Point(55, 86)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtFecha.Properties.Appearance.Options.UseBackColor = True
        Me.txtFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFecha.Properties.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.txtFecha.Properties.EditFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.txtFecha.Properties.Mask.BeepOnError = True
        Me.txtFecha.Properties.Mask.EditMask = "dd/MM/yyyy HH:mm:ss"
        Me.txtFecha.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtFecha.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Style3D
        Me.txtFecha.Properties.ReadOnly = True
        Me.txtFecha.Properties.ShowWeekNumbers = True
        Me.txtFecha.Size = New System.Drawing.Size(101, 20)
        Me.txtFecha.TabIndex = 33
        '
        'lblFechaCreacion
        '
        Me.lblFechaCreacion.Location = New System.Drawing.Point(16, 89)
        Me.lblFechaCreacion.Name = "lblFechaCreacion"
        Me.lblFechaCreacion.Size = New System.Drawing.Size(33, 13)
        Me.lblFechaCreacion.TabIndex = 34
        Me.lblFechaCreacion.Text = "Fecha:"
        '
        'txtUsuario
        '
        Me.txtUsuario.EditValue = ""
        Me.txtUsuario.Location = New System.Drawing.Point(55, 32)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtUsuario.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtUsuario.Properties.Appearance.Options.UseBackColor = True
        Me.txtUsuario.Properties.ReadOnly = True
        Me.txtUsuario.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtUsuario.Size = New System.Drawing.Size(101, 20)
        Me.txtUsuario.TabIndex = 33
        '
        'lblUsuarioCreacion
        '
        Me.lblUsuarioCreacion.Location = New System.Drawing.Point(9, 35)
        Me.lblUsuarioCreacion.Name = "lblUsuarioCreacion"
        Me.lblUsuarioCreacion.Size = New System.Drawing.Size(40, 13)
        Me.lblUsuarioCreacion.TabIndex = 33
        Me.lblUsuarioCreacion.Text = "Usuario:"
        '
        'txtTipoPrograma
        '
        Me.txtTipoPrograma.EditValue = ""
        Me.txtTipoPrograma.Location = New System.Drawing.Point(535, 119)
        Me.txtTipoPrograma.Name = "txtTipoPrograma"
        Me.txtTipoPrograma.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtTipoPrograma.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtTipoPrograma.Properties.Appearance.Options.UseBackColor = True
        Me.txtTipoPrograma.Properties.ReadOnly = True
        Me.txtTipoPrograma.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTipoPrograma.Size = New System.Drawing.Size(125, 20)
        Me.txtTipoPrograma.TabIndex = 31
        '
        'lblTipoPrograma
        '
        Me.lblTipoPrograma.Location = New System.Drawing.Point(425, 122)
        Me.lblTipoPrograma.Name = "lblTipoPrograma"
        Me.lblTipoPrograma.Size = New System.Drawing.Size(73, 13)
        Me.lblTipoPrograma.TabIndex = 30
        Me.lblTipoPrograma.Text = "Tipo Programa:"
        '
        'txtTipoPeriodo
        '
        Me.txtTipoPeriodo.EditValue = ""
        Me.txtTipoPeriodo.Location = New System.Drawing.Point(535, 63)
        Me.txtTipoPeriodo.Name = "txtTipoPeriodo"
        Me.txtTipoPeriodo.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtTipoPeriodo.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtTipoPeriodo.Properties.Appearance.Options.UseBackColor = True
        Me.txtTipoPeriodo.Properties.ReadOnly = True
        Me.txtTipoPeriodo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTipoPeriodo.Size = New System.Drawing.Size(125, 20)
        Me.txtTipoPeriodo.TabIndex = 29
        '
        'lblTipoPeriodo
        '
        Me.lblTipoPeriodo.Location = New System.Drawing.Point(425, 64)
        Me.lblTipoPeriodo.Name = "lblTipoPeriodo"
        Me.lblTipoPeriodo.Size = New System.Drawing.Size(63, 13)
        Me.lblTipoPeriodo.TabIndex = 28
        Me.lblTipoPeriodo.Text = "Tipo Periodo:"
        '
        'txtZafra
        '
        Me.txtZafra.EditValue = ""
        Me.txtZafra.Location = New System.Drawing.Point(182, 119)
        Me.txtZafra.Name = "txtZafra"
        Me.txtZafra.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtZafra.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtZafra.Properties.Appearance.Options.UseBackColor = True
        Me.txtZafra.Properties.ReadOnly = True
        Me.txtZafra.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtZafra.Size = New System.Drawing.Size(125, 20)
        Me.txtZafra.TabIndex = 27
        '
        'lblZafra
        '
        Me.lblZafra.Location = New System.Drawing.Point(21, 122)
        Me.lblZafra.Name = "lblZafra"
        Me.lblZafra.Size = New System.Drawing.Size(30, 13)
        Me.lblZafra.TabIndex = 26
        Me.lblZafra.Text = "Zafra:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.EditValue = ""
        Me.txtDescripcion.Location = New System.Drawing.Point(182, 89)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtDescripcion.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtDescripcion.Properties.Appearance.Options.UseBackColor = True
        Me.txtDescripcion.Properties.ReadOnly = True
        Me.txtDescripcion.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDescripcion.Size = New System.Drawing.Size(478, 20)
        Me.txtDescripcion.TabIndex = 25
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Location = New System.Drawing.Point(21, 92)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(58, 13)
        Me.lblDescripcion.TabIndex = 24
        Me.lblDescripcion.Text = "Descripcion:"
        '
        'txtProgramaID
        '
        Me.txtProgramaID.EditValue = ""
        Me.txtProgramaID.Location = New System.Drawing.Point(182, 61)
        Me.txtProgramaID.Name = "txtProgramaID"
        Me.txtProgramaID.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtProgramaID.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtProgramaID.Properties.Appearance.Options.UseBackColor = True
        Me.txtProgramaID.Properties.ReadOnly = True
        Me.txtProgramaID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtProgramaID.Size = New System.Drawing.Size(125, 20)
        Me.txtProgramaID.TabIndex = 23
        '
        'lblProgramaID
        '
        Me.lblProgramaID.Location = New System.Drawing.Point(21, 64)
        Me.lblProgramaID.Name = "lblProgramaID"
        Me.lblProgramaID.Size = New System.Drawing.Size(64, 13)
        Me.lblProgramaID.TabIndex = 22
        Me.lblProgramaID.Text = "Programa ID:"
        '
        'lblPrograma
        '
        Me.lblPrograma.Location = New System.Drawing.Point(21, 34)
        Me.lblPrograma.Name = "lblPrograma"
        Me.lblPrograma.Size = New System.Drawing.Size(155, 13)
        Me.lblPrograma.TabIndex = 20
        Me.lblPrograma.Text = "Programa de cosecha existente:"
        '
        'cbxProgramas
        '
        Me.cbxProgramas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxProgramas.EditValue = "Seleccionar "
        Me.cbxProgramas.Location = New System.Drawing.Point(182, 31)
        Me.cbxProgramas.Name = "cbxProgramas"
        Me.cbxProgramas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxProgramas.Properties.NullText = "Seleccionar datos..."
        Me.cbxProgramas.Properties.View = Me.GridLookUpEdit1View
        Me.cbxProgramas.Size = New System.Drawing.Size(482, 20)
        Me.cbxProgramas.TabIndex = 21
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcolProgramaID, Me.gcolNombre})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'gcolProgramaID
        '
        Me.gcolProgramaID.Caption = "Programa ID"
        Me.gcolProgramaID.FieldName = "ProgramaID"
        Me.gcolProgramaID.Name = "gcolProgramaID"
        Me.gcolProgramaID.OptionsColumn.AllowEdit = False
        Me.gcolProgramaID.OptionsColumn.ReadOnly = True
        Me.gcolProgramaID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolProgramaID.Visible = True
        Me.gcolProgramaID.VisibleIndex = 0
        Me.gcolProgramaID.Width = 92
        '
        'gcolNombre
        '
        Me.gcolNombre.Caption = "Descripcion"
        Me.gcolNombre.FieldName = "Descripcion"
        Me.gcolNombre.Name = "gcolNombre"
        Me.gcolNombre.OptionsColumn.AllowEdit = False
        Me.gcolNombre.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolNombre.Visible = True
        Me.gcolNombre.VisibleIndex = 1
        Me.gcolNombre.Width = 583
        '
        'gcDatos
        '
        Me.gcDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcDatos.Location = New System.Drawing.Point(0, 308)
        Me.gcDatos.MainView = Me.dgvDatos
        Me.gcDatos.Name = "gcDatos"
        Me.gcDatos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemChkSeleccionar, Me.RepItemChkAprobado})
        Me.gcDatos.Size = New System.Drawing.Size(1028, 341)
        Me.gcDatos.TabIndex = 11
        Me.gcDatos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dgvDatos})
        '
        'dgvDatos
        '
        Me.dgvDatos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcolSeleccionar, Me.gcolEstaAprobado, Me.gcolDescripcion, Me.gcolFechaEstimada, Me.gcolToneladasEstimadas, Me.gcolDistritoID, Me.gcolxFincaID, Me.gcolLoteID, Me.gcolDistanciaIngenio, Me.gcolVariedadID, Me.gcolVariedadDescrip, Me.gcolCicloID, Me.gcolCicloDescrip, Me.gcolTexturaID, Me.gcolTexturaDescrip, Me.gcolDrenajeID, Me.gcolDrenajeDescrip, Me.gcolRendimiento, Me.gcolDistanciaID, Me.gcolDistanciaSiembraDescrip, Me.gcolFrente, Me.gcolPromedioPonderado, Me.gcolDetalleProgramaID, Me.gcolProgramaIDE, Me.gcolEstimadoProduccionID, Me.gcolEstimadoGrupoID})
        Me.dgvDatos.GridControl = Me.gcDatos
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.OptionsView.ShowAutoFilterRow = True
        Me.dgvDatos.OptionsView.ShowFooter = True
        '
        'gcolSeleccionar
        '
        Me.gcolSeleccionar.Caption = "Seleccionar"
        Me.gcolSeleccionar.ColumnEdit = Me.RepItemChkSeleccionar
        Me.gcolSeleccionar.FieldName = "Seleccionar"
        Me.gcolSeleccionar.Name = "gcolSeleccionar"
        Me.gcolSeleccionar.Visible = True
        Me.gcolSeleccionar.VisibleIndex = 0
        '
        'RepItemChkSeleccionar
        '
        Me.RepItemChkSeleccionar.AutoHeight = False
        Me.RepItemChkSeleccionar.Caption = "Check"
        Me.RepItemChkSeleccionar.Name = "RepItemChkSeleccionar"
        '
        'gcolEstaAprobado
        '
        Me.gcolEstaAprobado.Caption = "¿Aprobado?"
        Me.gcolEstaAprobado.ColumnEdit = Me.RepItemChkAprobado
        Me.gcolEstaAprobado.FieldName = "estaAprobado"
        Me.gcolEstaAprobado.Name = "gcolEstaAprobado"
        Me.gcolEstaAprobado.Visible = True
        Me.gcolEstaAprobado.VisibleIndex = 1
        '
        'RepItemChkAprobado
        '
        Me.RepItemChkAprobado.AutoHeight = False
        Me.RepItemChkAprobado.Caption = "Check"
        Me.RepItemChkAprobado.Name = "RepItemChkAprobado"
        '
        'gcolDescripcion
        '
        Me.gcolDescripcion.Caption = "Descripcion"
        Me.gcolDescripcion.FieldName = "Descripcion"
        Me.gcolDescripcion.Name = "gcolDescripcion"
        Me.gcolDescripcion.OptionsColumn.AllowEdit = False
        Me.gcolDescripcion.OptionsColumn.ReadOnly = True
        Me.gcolDescripcion.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'gcolFechaEstimada
        '
        Me.gcolFechaEstimada.Caption = "Fecha Estimada"
        Me.gcolFechaEstimada.FieldName = "FechaEstimada"
        Me.gcolFechaEstimada.Name = "gcolFechaEstimada"
        Me.gcolFechaEstimada.OptionsColumn.AllowEdit = False
        Me.gcolFechaEstimada.OptionsColumn.ReadOnly = True
        Me.gcolFechaEstimada.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolFechaEstimada.Visible = True
        Me.gcolFechaEstimada.VisibleIndex = 2
        '
        'gcolToneladasEstimadas
        '
        Me.gcolToneladasEstimadas.Caption = "Tons. Estimadas"
        Me.gcolToneladasEstimadas.FieldName = "ToneladasEstimadas"
        Me.gcolToneladasEstimadas.Name = "gcolToneladasEstimadas"
        Me.gcolToneladasEstimadas.OptionsColumn.AllowEdit = False
        Me.gcolToneladasEstimadas.OptionsColumn.ReadOnly = True
        Me.gcolToneladasEstimadas.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolToneladasEstimadas.Visible = True
        Me.gcolToneladasEstimadas.VisibleIndex = 3
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
        Me.gcolDistritoID.VisibleIndex = 4
        '
        'gcolxFincaID
        '
        Me.gcolxFincaID.Caption = "Finca ID"
        Me.gcolxFincaID.FieldName = "FincaID"
        Me.gcolxFincaID.Name = "gcolxFincaID"
        Me.gcolxFincaID.OptionsColumn.AllowEdit = False
        Me.gcolxFincaID.OptionsColumn.ReadOnly = True
        Me.gcolxFincaID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolxFincaID.Visible = True
        Me.gcolxFincaID.VisibleIndex = 5
        '
        'gcolLoteID
        '
        Me.gcolLoteID.Caption = "Lote ID"
        Me.gcolLoteID.FieldName = "LoteID"
        Me.gcolLoteID.Name = "gcolLoteID"
        Me.gcolLoteID.OptionsColumn.AllowEdit = False
        Me.gcolLoteID.OptionsColumn.ReadOnly = True
        Me.gcolLoteID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolLoteID.Visible = True
        Me.gcolLoteID.VisibleIndex = 6
        '
        'gcolDistanciaIngenio
        '
        Me.gcolDistanciaIngenio.Caption = "Distancia Ingenio"
        Me.gcolDistanciaIngenio.FieldName = "DistanciaIngenio"
        Me.gcolDistanciaIngenio.Name = "gcolDistanciaIngenio"
        Me.gcolDistanciaIngenio.OptionsColumn.AllowEdit = False
        Me.gcolDistanciaIngenio.OptionsColumn.ReadOnly = True
        Me.gcolDistanciaIngenio.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolDistanciaIngenio.Visible = True
        Me.gcolDistanciaIngenio.VisibleIndex = 7
        '
        'gcolVariedadID
        '
        Me.gcolVariedadID.Caption = "Variedad ID"
        Me.gcolVariedadID.FieldName = "VariedadID"
        Me.gcolVariedadID.Name = "gcolVariedadID"
        Me.gcolVariedadID.OptionsColumn.AllowEdit = False
        Me.gcolVariedadID.OptionsColumn.ReadOnly = True
        Me.gcolVariedadID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'gcolVariedadDescrip
        '
        Me.gcolVariedadDescrip.Caption = "Variedad"
        Me.gcolVariedadDescrip.FieldName = "VariedadDescrip"
        Me.gcolVariedadDescrip.Name = "gcolVariedadDescrip"
        Me.gcolVariedadDescrip.Visible = True
        Me.gcolVariedadDescrip.VisibleIndex = 11
        '
        'gcolCicloID
        '
        Me.gcolCicloID.Caption = "Ciclo ID"
        Me.gcolCicloID.FieldName = "CicloID"
        Me.gcolCicloID.Name = "gcolCicloID"
        Me.gcolCicloID.OptionsColumn.AllowEdit = False
        Me.gcolCicloID.OptionsColumn.ReadOnly = True
        Me.gcolCicloID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'gcolCicloDescrip
        '
        Me.gcolCicloDescrip.Caption = "Ciclo"
        Me.gcolCicloDescrip.FieldName = "CicloDescrip"
        Me.gcolCicloDescrip.Name = "gcolCicloDescrip"
        Me.gcolCicloDescrip.OptionsColumn.AllowEdit = False
        Me.gcolCicloDescrip.OptionsColumn.ReadOnly = True
        Me.gcolCicloDescrip.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolCicloDescrip.Visible = True
        Me.gcolCicloDescrip.VisibleIndex = 12
        '
        'gcolTexturaID
        '
        Me.gcolTexturaID.Caption = "Textura ID"
        Me.gcolTexturaID.FieldName = "TexturaID"
        Me.gcolTexturaID.Name = "gcolTexturaID"
        Me.gcolTexturaID.OptionsColumn.AllowEdit = False
        Me.gcolTexturaID.OptionsColumn.ReadOnly = True
        Me.gcolTexturaID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'gcolTexturaDescrip
        '
        Me.gcolTexturaDescrip.Caption = "Textura"
        Me.gcolTexturaDescrip.FieldName = "TexturaDescrip"
        Me.gcolTexturaDescrip.Name = "gcolTexturaDescrip"
        Me.gcolTexturaDescrip.OptionsColumn.AllowEdit = False
        Me.gcolTexturaDescrip.OptionsColumn.ReadOnly = True
        Me.gcolTexturaDescrip.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolTexturaDescrip.Visible = True
        Me.gcolTexturaDescrip.VisibleIndex = 13
        '
        'gcolDrenajeID
        '
        Me.gcolDrenajeID.Caption = "Drenaje ID"
        Me.gcolDrenajeID.FieldName = "DrenajeID"
        Me.gcolDrenajeID.Name = "gcolDrenajeID"
        Me.gcolDrenajeID.OptionsColumn.AllowEdit = False
        Me.gcolDrenajeID.OptionsColumn.ReadOnly = True
        Me.gcolDrenajeID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'gcolDrenajeDescrip
        '
        Me.gcolDrenajeDescrip.Caption = "Drenaje"
        Me.gcolDrenajeDescrip.FieldName = "DrenajeDescrip"
        Me.gcolDrenajeDescrip.Name = "gcolDrenajeDescrip"
        Me.gcolDrenajeDescrip.OptionsColumn.AllowEdit = False
        Me.gcolDrenajeDescrip.OptionsColumn.ReadOnly = True
        Me.gcolDrenajeDescrip.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolDrenajeDescrip.Visible = True
        Me.gcolDrenajeDescrip.VisibleIndex = 14
        '
        'gcolRendimiento
        '
        Me.gcolRendimiento.Caption = "Rendimiento"
        Me.gcolRendimiento.FieldName = "Rendimiento"
        Me.gcolRendimiento.Name = "gcolRendimiento"
        Me.gcolRendimiento.OptionsColumn.AllowEdit = False
        Me.gcolRendimiento.OptionsColumn.ReadOnly = True
        Me.gcolRendimiento.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolRendimiento.Visible = True
        Me.gcolRendimiento.VisibleIndex = 8
        '
        'gcolDistanciaID
        '
        Me.gcolDistanciaID.Caption = "Distancia ID"
        Me.gcolDistanciaID.FieldName = "DistanciaID"
        Me.gcolDistanciaID.Name = "gcolDistanciaID"
        Me.gcolDistanciaID.OptionsColumn.AllowEdit = False
        Me.gcolDistanciaID.OptionsColumn.ReadOnly = True
        Me.gcolDistanciaID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'gcolDistanciaSiembraDescrip
        '
        Me.gcolDistanciaSiembraDescrip.Caption = "Distancia Siembra"
        Me.gcolDistanciaSiembraDescrip.FieldName = "DistanciaSiembraDescrip"
        Me.gcolDistanciaSiembraDescrip.Name = "gcolDistanciaSiembraDescrip"
        Me.gcolDistanciaSiembraDescrip.OptionsColumn.AllowEdit = False
        Me.gcolDistanciaSiembraDescrip.OptionsColumn.ReadOnly = True
        Me.gcolDistanciaSiembraDescrip.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolDistanciaSiembraDescrip.Visible = True
        Me.gcolDistanciaSiembraDescrip.VisibleIndex = 15
        '
        'gcolFrente
        '
        Me.gcolFrente.Caption = "Frente"
        Me.gcolFrente.FieldName = "Frente"
        Me.gcolFrente.Name = "gcolFrente"
        Me.gcolFrente.OptionsColumn.AllowEdit = False
        Me.gcolFrente.OptionsColumn.ReadOnly = True
        Me.gcolFrente.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolFrente.Visible = True
        Me.gcolFrente.VisibleIndex = 9
        '
        'gcolPromedioPonderado
        '
        Me.gcolPromedioPonderado.Caption = "Promedio Ponderado"
        Me.gcolPromedioPonderado.FieldName = "PromedioPonderado"
        Me.gcolPromedioPonderado.Name = "gcolPromedioPonderado"
        Me.gcolPromedioPonderado.OptionsColumn.AllowEdit = False
        Me.gcolPromedioPonderado.OptionsColumn.ReadOnly = True
        Me.gcolPromedioPonderado.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolPromedioPonderado.Visible = True
        Me.gcolPromedioPonderado.VisibleIndex = 10
        '
        'gcolDetalleProgramaID
        '
        Me.gcolDetalleProgramaID.Caption = "Detalle Programa ID"
        Me.gcolDetalleProgramaID.FieldName = "DetalleProgramaID"
        Me.gcolDetalleProgramaID.Name = "gcolDetalleProgramaID"
        '
        'gcolProgramaIDE
        '
        Me.gcolProgramaIDE.Caption = "Programa ID"
        Me.gcolProgramaIDE.FieldName = "ProgramaID"
        Me.gcolProgramaIDE.Name = "gcolProgramaIDE"
        '
        'gcolEstimadoProduccionID
        '
        Me.gcolEstimadoProduccionID.Caption = "Estimado Produccion ID"
        Me.gcolEstimadoProduccionID.FieldName = "EstimadoProduccionID"
        Me.gcolEstimadoProduccionID.Name = "gcolEstimadoProduccionID"
        '
        'gcolEstimadoGrupoID
        '
        Me.gcolEstimadoGrupoID.Caption = "EstimadoGrupoID"
        Me.gcolEstimadoGrupoID.FieldName = "EstimadoGrupoID"
        Me.gcolEstimadoGrupoID.Name = "gcolEstimadoGrupoID"
        Me.gcolEstimadoGrupoID.OptionsColumn.AllowEdit = False
        Me.gcolEstimadoGrupoID.OptionsColumn.ReadOnly = True
        Me.gcolEstimadoGrupoID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'gbxModificacion
        '
        Me.gbxModificacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxModificacion.Controls.Add(Me.txtFechaEDesde)
        Me.gbxModificacion.Controls.Add(Me.txtToneladasReales)
        Me.gbxModificacion.Controls.Add(Me.txtAreaCosecha)
        Me.gbxModificacion.Controls.Add(Me.cbxCategoria)
        Me.gbxModificacion.Controls.Add(Me.txtRendProLab)
        Me.gbxModificacion.Controls.Add(Me.lblToneladasReales)
        Me.gbxModificacion.Controls.Add(Me.lblAreaCosecha)
        Me.gbxModificacion.Controls.Add(Me.lblCategoria)
        Me.gbxModificacion.Controls.Add(Me.lblRenProLab)
        Me.gbxModificacion.Controls.Add(Me.lblFechaCosecha)
        Me.gbxModificacion.Enabled = False
        Me.gbxModificacion.Location = New System.Drawing.Point(0, 213)
        Me.gbxModificacion.Name = "gbxModificacion"
        Me.gbxModificacion.Size = New System.Drawing.Size(1028, 89)
        Me.gbxModificacion.TabIndex = 12
        Me.gbxModificacion.Text = "Modificacion de Registros"
        '
        'txtFechaEDesde
        '
        Me.txtFechaEDesde.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtFechaEDesde.EditValue = Nothing
        Me.txtFechaEDesde.EnterMoveNextControl = True
        Me.txtFechaEDesde.Location = New System.Drawing.Point(95, 23)
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
        Me.txtFechaEDesde.Size = New System.Drawing.Size(232, 20)
        Me.txtFechaEDesde.TabIndex = 74
        '
        'txtToneladasReales
        '
        Me.txtToneladasReales.EditValue = ""
        Me.txtToneladasReales.Location = New System.Drawing.Point(818, 23)
        Me.txtToneladasReales.Name = "txtToneladasReales"
        Me.txtToneladasReales.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtToneladasReales.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtToneladasReales.Properties.Appearance.Options.UseBackColor = True
        Me.txtToneladasReales.Properties.Mask.BeepOnError = True
        Me.txtToneladasReales.Properties.Mask.EditMask = "n2"
        Me.txtToneladasReales.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtToneladasReales.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtToneladasReales.Size = New System.Drawing.Size(225, 20)
        Me.txtToneladasReales.TabIndex = 47
        '
        'txtAreaCosecha
        '
        Me.txtAreaCosecha.EditValue = ""
        Me.txtAreaCosecha.Location = New System.Drawing.Point(439, 57)
        Me.txtAreaCosecha.Name = "txtAreaCosecha"
        Me.txtAreaCosecha.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtAreaCosecha.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtAreaCosecha.Properties.Appearance.Options.UseBackColor = True
        Me.txtAreaCosecha.Properties.Mask.BeepOnError = True
        Me.txtAreaCosecha.Properties.Mask.EditMask = "n2"
        Me.txtAreaCosecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAreaCosecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtAreaCosecha.Size = New System.Drawing.Size(225, 20)
        Me.txtAreaCosecha.TabIndex = 46
        '
        'cbxCategoria
        '
        Me.cbxCategoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxCategoria.EditValue = "Seleccionar "
        Me.cbxCategoria.Location = New System.Drawing.Point(439, 23)
        Me.cbxCategoria.Name = "cbxCategoria"
        Me.cbxCategoria.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxCategoria.Properties.NullText = "Seleccionar datos..."
        Me.cbxCategoria.Properties.View = Me.GridView1
        Me.cbxCategoria.Size = New System.Drawing.Size(225, 20)
        Me.cbxCategoria.TabIndex = 40
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcolResultadoID, Me.gcolxDescripcion})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'gcolResultadoID
        '
        Me.gcolResultadoID.Caption = "Codigo"
        Me.gcolResultadoID.FieldName = "ResultadoID"
        Me.gcolResultadoID.Name = "gcolResultadoID"
        Me.gcolResultadoID.OptionsColumn.AllowEdit = False
        Me.gcolResultadoID.OptionsColumn.ReadOnly = True
        Me.gcolResultadoID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolResultadoID.Visible = True
        Me.gcolResultadoID.VisibleIndex = 0
        '
        'gcolxDescripcion
        '
        Me.gcolxDescripcion.Caption = "Descripcion"
        Me.gcolxDescripcion.FieldName = "Descripcion"
        Me.gcolxDescripcion.Name = "gcolxDescripcion"
        Me.gcolxDescripcion.OptionsColumn.AllowEdit = False
        Me.gcolxDescripcion.OptionsColumn.ReadOnly = True
        Me.gcolxDescripcion.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolxDescripcion.Visible = True
        Me.gcolxDescripcion.VisibleIndex = 1
        '
        'txtRendProLab
        '
        Me.txtRendProLab.EditValue = ""
        Me.txtRendProLab.Location = New System.Drawing.Point(95, 57)
        Me.txtRendProLab.Name = "txtRendProLab"
        Me.txtRendProLab.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtRendProLab.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtRendProLab.Properties.Appearance.Options.UseBackColor = True
        Me.txtRendProLab.Properties.Mask.EditMask = "n2"
        Me.txtRendProLab.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtRendProLab.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtRendProLab.Size = New System.Drawing.Size(232, 20)
        Me.txtRendProLab.TabIndex = 40
        '
        'lblToneladasReales
        '
        Me.lblToneladasReales.Location = New System.Drawing.Point(724, 24)
        Me.lblToneladasReales.Name = "lblToneladasReales"
        Me.lblToneladasReales.Size = New System.Drawing.Size(88, 13)
        Me.lblToneladasReales.TabIndex = 44
        Me.lblToneladasReales.Text = "Toneladas Reales:"
        '
        'lblAreaCosecha
        '
        Me.lblAreaCosecha.Location = New System.Drawing.Point(368, 60)
        Me.lblAreaCosecha.Name = "lblAreaCosecha"
        Me.lblAreaCosecha.Size = New System.Drawing.Size(71, 13)
        Me.lblAreaCosecha.TabIndex = 43
        Me.lblAreaCosecha.Text = "Area Cosecha:"
        '
        'lblCategoria
        '
        Me.lblCategoria.Location = New System.Drawing.Point(368, 24)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(51, 13)
        Me.lblCategoria.TabIndex = 42
        Me.lblCategoria.Text = "Categoria:"
        '
        'lblRenProLab
        '
        Me.lblRenProLab.Location = New System.Drawing.Point(12, 60)
        Me.lblRenProLab.Name = "lblRenProLab"
        Me.lblRenProLab.Size = New System.Drawing.Size(80, 13)
        Me.lblRenProLab.TabIndex = 41
        Me.lblRenProLab.Text = "Rend. Pro. Lab.:"
        '
        'lblFechaCosecha
        '
        Me.lblFechaCosecha.Location = New System.Drawing.Point(12, 24)
        Me.lblFechaCosecha.Name = "lblFechaCosecha"
        Me.lblFechaCosecha.Size = New System.Drawing.Size(77, 13)
        Me.lblFechaCosecha.TabIndex = 40
        Me.lblFechaCosecha.Text = "Fecha Cosecha:"
        '
        'CPRProgramacionCosecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 652)
        Me.Controls.Add(Me.gbxModificacion)
        Me.Controls.Add(Me.gcDatos)
        Me.Controls.Add(Me.gbxDatosPrograma)
        Me.Controls.Add(Me.tsMenu)
        Me.Name = "CPRProgramacionCosecha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Programacion de Cosecha"
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        CType(Me.gbxDatosPrograma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDatosPrograma.ResumeLayout(False)
        Me.gbxDatosPrograma.PerformLayout()
        CType(Me.txtDistanciaMeta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipoPrograma.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipoPeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtZafra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProgramaID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxProgramas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemChkSeleccionar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemChkAprobado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbxModificacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxModificacion.ResumeLayout(False)
        Me.gbxModificacion.PerformLayout()
        CType(Me.txtFechaEDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaEDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToneladasReales.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAreaCosecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxCategoria.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRendProLab.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents cmbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbLimpiar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbMarcarTodos As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbQuitarTodos As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmbAprobarTodos As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbBorrarMarcados As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents gbxDatosPrograma As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblPrograma As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbxProgramas As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcolProgramaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblProgramaID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtProgramaID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDescripcion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtZafra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblZafra As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbBuscarLotes As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtTipoPeriodo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTipoPeriodo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTipoPrograma As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTipoPrograma As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtUsuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblUsuarioCreacion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblFechaCreacion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtDesde As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDesde As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDistanciaMeta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDistanciaMeta As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtHasta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gcDatos As DevExpress.XtraGrid.GridControl
    Friend WithEvents dgvDatos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcolSeleccionar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolEstaAprobado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolFechaEstimada As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolToneladasEstimadas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolDistritoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolxFincaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolLoteID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolDistanciaIngenio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolVariedadID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolCicloID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolTexturaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolDrenajeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolRendimiento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolDistanciaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolFrente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolPromedioPonderado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbVerDetalle As System.Windows.Forms.Button
    Friend WithEvents gcolVariedadDescrip As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolCicloDescrip As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolTexturaDescrip As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolDrenajeDescrip As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolDistanciaSiembraDescrip As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolDetalleProgramaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolProgramaIDE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolEstimadoProduccionID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gbxModificacion As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblToneladasReales As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblAreaCosecha As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCategoria As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblRenProLab As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblFechaCosecha As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRendProLab As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbxCategoria As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcolResultadoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolxDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtAreaCosecha As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtToneladasReales As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RepItemChkSeleccionar As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepItemChkAprobado As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents gcolEstimadoGrupoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtFechaEDesde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbDesaprobarTodos As System.Windows.Forms.ToolStripButton
End Class
