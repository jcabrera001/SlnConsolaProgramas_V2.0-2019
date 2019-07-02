<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CPRPlanesCosechaFrm
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
        Me.gbxDatos = New DevExpress.XtraEditors.GroupControl()
        Me.cbxEstimados = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEstimadoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoEstimadoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoEstimado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lblEstimados = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDescripcion = New DevExpress.XtraEditors.TextEdit()
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.cmbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.cmbEliminar = New System.Windows.Forms.ToolStripButton()
        Me.cmbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.cmbSalir = New System.Windows.Forms.ToolStripButton()
        Me.gcDatos = New DevExpress.XtraGrid.GridControl()
        Me.dgvDatos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcolGrupoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolEstimadoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolEstimado = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.gbxDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDatos.SuspendLayout()
        CType(Me.cbxEstimados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenu.SuspendLayout()
        CType(Me.gcDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxDatos
        '
        Me.gbxDatos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxDatos.Controls.Add(Me.cbxEstimados)
        Me.gbxDatos.Controls.Add(Me.lblEstimados)
        Me.gbxDatos.Controls.Add(Me.LabelControl1)
        Me.gbxDatos.Controls.Add(Me.txtDescripcion)
        Me.gbxDatos.Location = New System.Drawing.Point(4, 265)
        Me.gbxDatos.Name = "gbxDatos"
        Me.gbxDatos.Size = New System.Drawing.Size(557, 104)
        Me.gbxDatos.TabIndex = 13
        Me.gbxDatos.Text = "Informacion de Planes de Cosecha"
        '
        'cbxEstimados
        '
        Me.cbxEstimados.EditValue = "Seleccionar "
        Me.cbxEstimados.Location = New System.Drawing.Point(76, 35)
        Me.cbxEstimados.Name = "cbxEstimados"
        Me.cbxEstimados.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxEstimados.Properties.NullText = "Seleccionar datos..."
        Me.cbxEstimados.Properties.View = Me.GridLookUpEdit1View
        Me.cbxEstimados.Size = New System.Drawing.Size(471, 20)
        Me.cbxEstimados.TabIndex = 22
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEstimadoID, Me.colDescripcion, Me.colTipoEstimadoID, Me.colTipoEstimado})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colEstimadoID
        '
        Me.colEstimadoID.Caption = "EstimadoID"
        Me.colEstimadoID.FieldName = "EstimadoID"
        Me.colEstimadoID.Name = "colEstimadoID"
        Me.colEstimadoID.OptionsColumn.AllowEdit = False
        Me.colEstimadoID.OptionsColumn.ReadOnly = True
        Me.colEstimadoID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colEstimadoID.Visible = True
        Me.colEstimadoID.VisibleIndex = 0
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripcion"
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.OptionsColumn.AllowEdit = False
        Me.colDescripcion.OptionsColumn.ReadOnly = True
        Me.colDescripcion.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 1
        '
        'colTipoEstimadoID
        '
        Me.colTipoEstimadoID.Caption = "TipoEstimadoID"
        Me.colTipoEstimadoID.FieldName = "TipoEstimadoID"
        Me.colTipoEstimadoID.Name = "colTipoEstimadoID"
        Me.colTipoEstimadoID.OptionsColumn.AllowEdit = False
        Me.colTipoEstimadoID.OptionsColumn.ReadOnly = True
        Me.colTipoEstimadoID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'colTipoEstimado
        '
        Me.colTipoEstimado.Caption = "Tipo Estimado"
        Me.colTipoEstimado.FieldName = "TipoEstimado"
        Me.colTipoEstimado.Name = "colTipoEstimado"
        Me.colTipoEstimado.OptionsColumn.AllowEdit = False
        Me.colTipoEstimado.OptionsColumn.ReadOnly = True
        Me.colTipoEstimado.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colTipoEstimado.Visible = True
        Me.colTipoEstimado.VisibleIndex = 2
        '
        'lblEstimados
        '
        Me.lblEstimados.Location = New System.Drawing.Point(12, 35)
        Me.lblEstimados.Name = "lblEstimados"
        Me.lblEstimados.Size = New System.Drawing.Size(47, 13)
        Me.lblEstimados.TabIndex = 4
        Me.lblEstimados.Text = "Estimado:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 76)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Descripcion:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcion.Location = New System.Drawing.Point(76, 73)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(471, 20)
        Me.txtDescripcion.TabIndex = 2
        '
        'tsMenu
        '
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmbGuardar, Me.cmbEliminar, Me.cmbCancelar, Me.cmbSalir})
        Me.tsMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(562, 52)
        Me.tsMenu.TabIndex = 12
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
        'cmbEliminar
        '
        Me.cmbEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbEliminar.Name = "cmbEliminar"
        Me.cmbEliminar.Size = New System.Drawing.Size(47, 49)
        Me.cmbEliminar.Text = "Eliminar"
        Me.cmbEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmbEliminar.Visible = False
        '
        'cmbCancelar
        '
        Me.cmbCancelar.Image = Global.ConsolaProgramas.My.Resources.Resources.application1
        Me.cmbCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(44, 49)
        Me.cmbCancelar.Text = "Limpiar"
        Me.cmbCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'gcDatos
        '
        Me.gcDatos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcDatos.Location = New System.Drawing.Point(4, 56)
        Me.gcDatos.MainView = Me.dgvDatos
        Me.gcDatos.Name = "gcDatos"
        Me.gcDatos.Size = New System.Drawing.Size(557, 203)
        Me.gcDatos.TabIndex = 11
        Me.gcDatos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dgvDatos})
        '
        'dgvDatos
        '
        Me.dgvDatos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcolGrupoID, Me.gcolDescripcion, Me.gcolEstimadoID, Me.gcolEstimado})
        Me.dgvDatos.GridControl = Me.gcDatos
        Me.dgvDatos.GroupPanelText = "Lista de Areas de Trabajo"
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.OptionsView.ShowAutoFilterRow = True
        '
        'gcolGrupoID
        '
        Me.gcolGrupoID.Caption = "GrupoID"
        Me.gcolGrupoID.FieldName = "GrupoID"
        Me.gcolGrupoID.MinWidth = 10
        Me.gcolGrupoID.Name = "gcolGrupoID"
        Me.gcolGrupoID.OptionsColumn.AllowEdit = False
        Me.gcolGrupoID.OptionsColumn.ReadOnly = True
        Me.gcolGrupoID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolGrupoID.Visible = True
        Me.gcolGrupoID.VisibleIndex = 0
        Me.gcolGrupoID.Width = 92
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
        Me.gcolDescripcion.Width = 228
        '
        'gcolEstimadoID
        '
        Me.gcolEstimadoID.Caption = "EstimadoID"
        Me.gcolEstimadoID.FieldName = "EstimadoID"
        Me.gcolEstimadoID.Name = "gcolEstimadoID"
        Me.gcolEstimadoID.OptionsColumn.AllowEdit = False
        Me.gcolEstimadoID.OptionsColumn.ReadOnly = True
        Me.gcolEstimadoID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolEstimadoID.Width = 231
        '
        'gcolEstimado
        '
        Me.gcolEstimado.Caption = "Estimado"
        Me.gcolEstimado.FieldName = "Estimado"
        Me.gcolEstimado.Name = "gcolEstimado"
        Me.gcolEstimado.OptionsColumn.AllowEdit = False
        Me.gcolEstimado.OptionsColumn.ReadOnly = True
        Me.gcolEstimado.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolEstimado.Visible = True
        Me.gcolEstimado.VisibleIndex = 2
        '
        'CPRPlanesCosechaFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 372)
        Me.Controls.Add(Me.gbxDatos)
        Me.Controls.Add(Me.tsMenu)
        Me.Controls.Add(Me.gcDatos)
        Me.Name = "CPRPlanesCosechaFrm"
        Me.Text = "Mantenimiento de Planes de Cosecha"
        CType(Me.gbxDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDatos.ResumeLayout(False)
        Me.gbxDatos.PerformLayout()
        CType(Me.cbxEstimados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        CType(Me.gcDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbxDatos As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents cmbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents gcDatos As DevExpress.XtraGrid.GridControl
    Friend WithEvents dgvDatos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcolGrupoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolEstimadoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblEstimados As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbxEstimados As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colEstimadoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolEstimado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoEstimadoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoEstimado As DevExpress.XtraGrid.Columns.GridColumn
End Class
