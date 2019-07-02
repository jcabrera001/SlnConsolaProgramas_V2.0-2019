<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CPRCargarEstimadoProduccion
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
        Me.gcDatos = New DevExpress.XtraGrid.GridControl()
        Me.dgvDatos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcolEstimadoProduccionID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolEstimadoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolLoteID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolTipoCanaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolCicloID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolTipoSueloID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolDrenajeID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolDistanciaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolArea = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolAreaEjecutada = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolRendimiento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolTonsEstimadas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolFechaCorte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolFechaEstimada = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolZonaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.cmbNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmbImportarExcel = New System.Windows.Forms.ToolStripButton()
        Me.cmbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmbSalir = New System.Windows.Forms.ToolStripButton()
        Me.gbxEncabezado = New DevExpress.XtraEditors.GroupControl()
        Me.cmbGuardar = New System.Windows.Forms.ToolStripButton()
        CType(Me.gcDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenu.SuspendLayout()
        CType(Me.gbxEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gcDatos
        '
        Me.gcDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcDatos.Location = New System.Drawing.Point(7, 161)
        Me.gcDatos.MainView = Me.dgvDatos
        Me.gcDatos.Name = "gcDatos"
        Me.gcDatos.Size = New System.Drawing.Size(1078, 307)
        Me.gcDatos.TabIndex = 0
        Me.gcDatos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dgvDatos})
        '
        'dgvDatos
        '
        Me.dgvDatos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcolEstimadoProduccionID, Me.gcolEstimadoID, Me.gcolLoteID, Me.gcolTipoCanaID, Me.gcolCicloID, Me.gcolTipoSueloID, Me.gcolDrenajeID, Me.gcolDistanciaID, Me.gcolArea, Me.gcolAreaEjecutada, Me.gcolRendimiento, Me.gcolTonsEstimadas, Me.gcolFechaCorte, Me.gcolFechaEstimada, Me.gcolZonaID})
        Me.dgvDatos.GridControl = Me.gcDatos
        Me.dgvDatos.Name = "dgvDatos"
        '
        'gcolEstimadoProduccionID
        '
        Me.gcolEstimadoProduccionID.Caption = "EstimadoProduccionID"
        Me.gcolEstimadoProduccionID.FieldName = "EstimadoProduccionID"
        Me.gcolEstimadoProduccionID.Name = "gcolEstimadoProduccionID"
        Me.gcolEstimadoProduccionID.OptionsColumn.AllowEdit = False
        Me.gcolEstimadoProduccionID.OptionsColumn.ReadOnly = True
        Me.gcolEstimadoProduccionID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'gcolEstimadoID
        '
        Me.gcolEstimadoID.Caption = "EstimadoID"
        Me.gcolEstimadoID.FieldName = "EstimadoID"
        Me.gcolEstimadoID.Name = "gcolEstimadoID"
        Me.gcolEstimadoID.OptionsColumn.AllowEdit = False
        Me.gcolEstimadoID.OptionsColumn.ReadOnly = True
        Me.gcolEstimadoID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolEstimadoID.Visible = True
        Me.gcolEstimadoID.VisibleIndex = 0
        '
        'gcolLoteID
        '
        Me.gcolLoteID.Caption = "LoteID"
        Me.gcolLoteID.Name = "gcolLoteID"
        Me.gcolLoteID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolLoteID.Visible = True
        Me.gcolLoteID.VisibleIndex = 1
        '
        'gcolTipoCanaID
        '
        Me.gcolTipoCanaID.Caption = "Tipo Caña"
        Me.gcolTipoCanaID.FieldName = "TipoCanaID"
        Me.gcolTipoCanaID.Name = "gcolTipoCanaID"
        Me.gcolTipoCanaID.Visible = True
        Me.gcolTipoCanaID.VisibleIndex = 2
        '
        'gcolCicloID
        '
        Me.gcolCicloID.Caption = "Ciclo"
        Me.gcolCicloID.FieldName = "CicloID"
        Me.gcolCicloID.Name = "gcolCicloID"
        Me.gcolCicloID.Visible = True
        Me.gcolCicloID.VisibleIndex = 3
        '
        'gcolTipoSueloID
        '
        Me.gcolTipoSueloID.Caption = "Tipo Suelo"
        Me.gcolTipoSueloID.FieldName = "TipoSueloID"
        Me.gcolTipoSueloID.Name = "gcolTipoSueloID"
        Me.gcolTipoSueloID.Visible = True
        Me.gcolTipoSueloID.VisibleIndex = 4
        '
        'gcolDrenajeID
        '
        Me.gcolDrenajeID.Caption = "Drenaje"
        Me.gcolDrenajeID.FieldName = "DrenajeID"
        Me.gcolDrenajeID.Name = "gcolDrenajeID"
        Me.gcolDrenajeID.Visible = True
        Me.gcolDrenajeID.VisibleIndex = 5
        '
        'gcolDistanciaID
        '
        Me.gcolDistanciaID.Caption = "Distancia"
        Me.gcolDistanciaID.FieldName = "DistanciaID"
        Me.gcolDistanciaID.Name = "gcolDistanciaID"
        Me.gcolDistanciaID.Visible = True
        Me.gcolDistanciaID.VisibleIndex = 6
        '
        'gcolArea
        '
        Me.gcolArea.Caption = "Area"
        Me.gcolArea.FieldName = "Area"
        Me.gcolArea.Name = "gcolArea"
        Me.gcolArea.Visible = True
        Me.gcolArea.VisibleIndex = 7
        '
        'gcolAreaEjecutada
        '
        Me.gcolAreaEjecutada.Caption = "Area Ejecutada"
        Me.gcolAreaEjecutada.FieldName = "AreaEjecutada"
        Me.gcolAreaEjecutada.Name = "gcolAreaEjecutada"
        '
        'gcolRendimiento
        '
        Me.gcolRendimiento.Caption = "Rendimiento"
        Me.gcolRendimiento.FieldName = "Rendimiento"
        Me.gcolRendimiento.Name = "gcolRendimiento"
        Me.gcolRendimiento.Visible = True
        Me.gcolRendimiento.VisibleIndex = 8
        '
        'gcolTonsEstimadas
        '
        Me.gcolTonsEstimadas.Caption = "Tons. Estimadas"
        Me.gcolTonsEstimadas.FieldName = "TonsEstimadas"
        Me.gcolTonsEstimadas.Name = "gcolTonsEstimadas"
        Me.gcolTonsEstimadas.Visible = True
        Me.gcolTonsEstimadas.VisibleIndex = 9
        '
        'gcolFechaCorte
        '
        Me.gcolFechaCorte.Caption = "Fecha Corte"
        Me.gcolFechaCorte.FieldName = "FechaCorte"
        Me.gcolFechaCorte.Name = "gcolFechaCorte"
        Me.gcolFechaCorte.Visible = True
        Me.gcolFechaCorte.VisibleIndex = 10
        '
        'gcolFechaEstimada
        '
        Me.gcolFechaEstimada.Caption = "Fecha Estimada"
        Me.gcolFechaEstimada.Name = "gcolFechaEstimada"
        Me.gcolFechaEstimada.Visible = True
        Me.gcolFechaEstimada.VisibleIndex = 11
        '
        'gcolZonaID
        '
        Me.gcolZonaID.Caption = "Zona"
        Me.gcolZonaID.FieldName = "ZonaID"
        Me.gcolZonaID.Name = "gcolZonaID"
        Me.gcolZonaID.Visible = True
        Me.gcolZonaID.VisibleIndex = 12
        '
        'tsMenu
        '
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmbNuevo, Me.cmbGuardar, Me.ToolStripSeparator1, Me.cmbImportarExcel, Me.cmbCancelar, Me.ToolStripSeparator2, Me.cmbSalir})
        Me.tsMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(1085, 52)
        Me.tsMenu.TabIndex = 13
        '
        'cmbNuevo
        '
        Me.cmbNuevo.Image = Global.ConsolaProgramas.My.Resources.Resources.page
        Me.cmbNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbNuevo.Name = "cmbNuevo"
        Me.cmbNuevo.Size = New System.Drawing.Size(42, 49)
        Me.cmbNuevo.Text = "Nuevo"
        Me.cmbNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 52)
        '
        'cmbImportarExcel
        '
        Me.cmbImportarExcel.Image = Global.ConsolaProgramas.My.Resources.Resources.page_excel
        Me.cmbImportarExcel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmbImportarExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbImportarExcel.Name = "cmbImportarExcel"
        Me.cmbImportarExcel.Size = New System.Drawing.Size(113, 49)
        Me.cmbImportarExcel.Text = "Importar desde Excel"
        Me.cmbImportarExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 52)
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
        'gbxEncabezado
        '
        Me.gbxEncabezado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxEncabezado.Location = New System.Drawing.Point(7, 55)
        Me.gbxEncabezado.Name = "gbxEncabezado"
        Me.gbxEncabezado.Size = New System.Drawing.Size(1078, 100)
        Me.gbxEncabezado.TabIndex = 14
        Me.gbxEncabezado.Text = "Encabezado del Estimado de Produccion"
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
        'CPRCargarEstimadoProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1085, 480)
        Me.Controls.Add(Me.gbxEncabezado)
        Me.Controls.Add(Me.tsMenu)
        Me.Controls.Add(Me.gcDatos)
        Me.Name = "CPRCargarEstimadoProduccion"
        Me.Text = "CPRCargarEstimadoProduccion"
        CType(Me.gcDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        CType(Me.gbxEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gcDatos As DevExpress.XtraGrid.GridControl
    Friend WithEvents dgvDatos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents cmbImportarExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents gbxEncabezado As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gcolEstimadoProduccionID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolEstimadoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolLoteID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolTipoCanaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolCicloID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolTipoSueloID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolDrenajeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolDistanciaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolArea As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolAreaEjecutada As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolRendimiento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolTonsEstimadas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolFechaCorte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolFechaEstimada As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolZonaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmbGuardar As System.Windows.Forms.ToolStripButton
End Class
