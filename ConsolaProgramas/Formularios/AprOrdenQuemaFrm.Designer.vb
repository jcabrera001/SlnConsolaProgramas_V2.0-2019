<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AprOrdenQuemaFrm
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
        Me.gcOrdenQuema = New DevExpress.XtraGrid.GridControl()
        Me.dgvDatos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcolOrdenCorte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolLote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolHora = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolFrente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolAccidental = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolCruda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolCortefrenteid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolPeriodoid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolDoble = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lblPeriodo = New DevExpress.XtraEditors.LabelControl()
        Me.cbxPeriodo = New System.Windows.Forms.ComboBox()
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.cmbNuevo = New System.Windows.Forms.ToolStripButton()
        Me.cmbModificar = New System.Windows.Forms.ToolStripButton()
        Me.cmbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.cmbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.gcolhoraOrden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolhoraBascula = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolhoraInicioArrastre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolhoraFinalArrastre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolcorteEstimadoTons = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolcorteEjecutadoTons = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolhoraPrebatey = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolareaEstimada = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcolareaEjecutada = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.gcOrdenQuema, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'gcOrdenQuema
        '
        Me.gcOrdenQuema.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcOrdenQuema.Location = New System.Drawing.Point(0, 81)
        Me.gcOrdenQuema.MainView = Me.dgvDatos
        Me.gcOrdenQuema.Name = "gcOrdenQuema"
        Me.gcOrdenQuema.Size = New System.Drawing.Size(780, 258)
        Me.gcOrdenQuema.TabIndex = 0
        Me.gcOrdenQuema.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dgvDatos})
        '
        'dgvDatos
        '
        Me.dgvDatos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcolOrdenCorte, Me.gcolCodigo, Me.gcolNombre, Me.gcolLote, Me.gcolFecha, Me.gcolHora, Me.gcolFrente, Me.gcolAccidental, Me.gcolCruda, Me.gcolCortefrenteid, Me.gcolPeriodoid, Me.gcolDoble, Me.gcolhoraOrden, Me.gcolhoraBascula, Me.gcolhoraInicioArrastre, Me.gcolhoraFinalArrastre, Me.gcolcorteEstimadoTons, Me.gcolcorteEjecutadoTons, Me.gcolhoraPrebatey, Me.gcolareaEstimada, Me.gcolareaEjecutada})
        Me.dgvDatos.GridControl = Me.gcOrdenQuema
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.OptionsView.ShowAutoFilterRow = True
        '
        'gcolOrdenCorte
        '
        Me.gcolOrdenCorte.Caption = "Orden Corte"
        Me.gcolOrdenCorte.FieldName = "OrdenQuema"
        Me.gcolOrdenCorte.Name = "gcolOrdenCorte"
        Me.gcolOrdenCorte.OptionsColumn.AllowEdit = False
        Me.gcolOrdenCorte.OptionsColumn.ReadOnly = True
        Me.gcolOrdenCorte.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolOrdenCorte.Visible = True
        Me.gcolOrdenCorte.VisibleIndex = 0
        '
        'gcolCodigo
        '
        Me.gcolCodigo.Caption = "Codigo"
        Me.gcolCodigo.FieldName = "Codigo"
        Me.gcolCodigo.Name = "gcolCodigo"
        Me.gcolCodigo.OptionsColumn.AllowEdit = False
        Me.gcolCodigo.OptionsColumn.ReadOnly = True
        Me.gcolCodigo.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolCodigo.Visible = True
        Me.gcolCodigo.VisibleIndex = 1
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
        Me.gcolNombre.VisibleIndex = 2
        '
        'gcolLote
        '
        Me.gcolLote.Caption = "Lote"
        Me.gcolLote.FieldName = "Lote"
        Me.gcolLote.Name = "gcolLote"
        Me.gcolLote.OptionsColumn.AllowEdit = False
        Me.gcolLote.OptionsColumn.ReadOnly = True
        Me.gcolLote.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolLote.Visible = True
        Me.gcolLote.VisibleIndex = 3
        '
        'gcolFecha
        '
        Me.gcolFecha.Caption = "Fecha"
        Me.gcolFecha.FieldName = "Fecha"
        Me.gcolFecha.Name = "gcolFecha"
        Me.gcolFecha.OptionsColumn.AllowEdit = False
        Me.gcolFecha.OptionsColumn.ReadOnly = True
        Me.gcolFecha.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolFecha.Visible = True
        Me.gcolFecha.VisibleIndex = 4
        '
        'gcolHora
        '
        Me.gcolHora.Caption = "Hora"
        Me.gcolHora.FieldName = "Hora"
        Me.gcolHora.Name = "gcolHora"
        Me.gcolHora.OptionsColumn.AllowEdit = False
        Me.gcolHora.OptionsColumn.ReadOnly = True
        Me.gcolHora.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.gcolHora.Visible = True
        Me.gcolHora.VisibleIndex = 5
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
        Me.gcolFrente.VisibleIndex = 6
        '
        'gcolAccidental
        '
        Me.gcolAccidental.Caption = "Accidental"
        Me.gcolAccidental.FieldName = "accidental"
        Me.gcolAccidental.Name = "gcolAccidental"
        '
        'gcolCruda
        '
        Me.gcolCruda.Caption = "Cruda"
        Me.gcolCruda.FieldName = "cruda"
        Me.gcolCruda.Name = "gcolCruda"
        '
        'gcolCortefrenteid
        '
        Me.gcolCortefrenteid.Caption = "CordeFrenteID"
        Me.gcolCortefrenteid.FieldName = "cortefrenteid"
        Me.gcolCortefrenteid.Name = "gcolCortefrenteid"
        '
        'gcolPeriodoid
        '
        Me.gcolPeriodoid.Caption = "PeriodoID"
        Me.gcolPeriodoid.FieldName = "periodoid"
        Me.gcolPeriodoid.Name = "gcolPeriodoid"
        '
        'gcolDoble
        '
        Me.gcolDoble.Caption = "Doble"
        Me.gcolDoble.FieldName = "doble"
        Me.gcolDoble.Name = "gcolDoble"
        '
        'lblPeriodo
        '
        Me.lblPeriodo.Location = New System.Drawing.Point(6, 57)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(40, 13)
        Me.lblPeriodo.TabIndex = 1
        Me.lblPeriodo.Text = "Periodo:"
        '
        'cbxPeriodo
        '
        Me.cbxPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPeriodo.FormattingEnabled = True
        Me.cbxPeriodo.Location = New System.Drawing.Point(52, 54)
        Me.cbxPeriodo.Name = "cbxPeriodo"
        Me.cbxPeriodo.Size = New System.Drawing.Size(366, 21)
        Me.cbxPeriodo.TabIndex = 2
        '
        'tsMenu
        '
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmbNuevo, Me.cmbModificar, Me.cmbImprimir, Me.cmbCancelar})
        Me.tsMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(779, 39)
        Me.tsMenu.TabIndex = 8
        '
        'cmbNuevo
        '
        Me.cmbNuevo.Image = Global.ConsolaProgramas.My.Resources.Resources.page
        Me.cmbNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbNuevo.Name = "cmbNuevo"
        Me.cmbNuevo.Size = New System.Drawing.Size(74, 36)
        Me.cmbNuevo.Text = "Nuevo"
        '
        'cmbModificar
        '
        Me.cmbModificar.Image = Global.ConsolaProgramas.My.Resources.Resources.page_edit
        Me.cmbModificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmbModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbModificar.Name = "cmbModificar"
        Me.cmbModificar.Size = New System.Drawing.Size(86, 36)
        Me.cmbModificar.Text = "Modificar"
        '
        'cmbImprimir
        '
        Me.cmbImprimir.Image = Global.ConsolaProgramas.My.Resources.Resources.printer
        Me.cmbImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbImprimir.Name = "cmbImprimir"
        Me.cmbImprimir.Size = New System.Drawing.Size(81, 36)
        Me.cmbImprimir.Text = "Imprimir"
        '
        'cmbCancelar
        '
        Me.cmbCancelar.Image = Global.ConsolaProgramas.My.Resources.Resources.cancel
        Me.cmbCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(85, 36)
        Me.cmbCancelar.Text = "Cancelar"
        '
        'gcolhoraOrden
        '
        Me.gcolhoraOrden.Caption = "horaOrden"
        Me.gcolhoraOrden.FieldName = "horaOrden"
        Me.gcolhoraOrden.Name = "gcolhoraOrden"
        '
        'gcolhoraBascula
        '
        Me.gcolhoraBascula.Caption = "horaBascula"
        Me.gcolhoraBascula.FieldName = "horaBascula"
        Me.gcolhoraBascula.Name = "gcolhoraBascula"
        '
        'gcolhoraInicioArrastre
        '
        Me.gcolhoraInicioArrastre.Caption = "horaInicioArrastre"
        Me.gcolhoraInicioArrastre.FieldName = "horaInicioArrastre"
        Me.gcolhoraInicioArrastre.Name = "gcolhoraInicioArrastre"
        '
        'gcolhoraFinalArrastre
        '
        Me.gcolhoraFinalArrastre.Caption = "horaFinalArrastre"
        Me.gcolhoraFinalArrastre.FieldName = "horaFinalArrastre"
        Me.gcolhoraFinalArrastre.Name = "gcolhoraFinalArrastre"
        '
        'gcolcorteEstimadoTons
        '
        Me.gcolcorteEstimadoTons.Caption = "corteEstimadoTons"
        Me.gcolcorteEstimadoTons.FieldName = "corteEstimadoTons"
        Me.gcolcorteEstimadoTons.Name = "gcolcorteEstimadoTons"
        '
        'gcolcorteEjecutadoTons
        '
        Me.gcolcorteEjecutadoTons.Caption = "corteEjecutadoTons"
        Me.gcolcorteEjecutadoTons.FieldName = "corteEjecutadoTons"
        Me.gcolcorteEjecutadoTons.Name = "gcolcorteEjecutadoTons"
        '
        'gcolhoraPrebatey
        '
        Me.gcolhoraPrebatey.Caption = "horaPrebatey"
        Me.gcolhoraPrebatey.FieldName = "horaPrebatey"
        Me.gcolhoraPrebatey.Name = "gcolhoraPrebatey"
        '
        'gcolareaEstimada
        '
        Me.gcolareaEstimada.Caption = "areaEstimada"
        Me.gcolareaEstimada.FieldName = "areaEstimada"
        Me.gcolareaEstimada.Name = "gcolareaEstimada"
        '
        'gcolareaEjecutada
        '
        Me.gcolareaEjecutada.Caption = "areaEjecutada"
        Me.gcolareaEjecutada.FieldName = "areaEjecutada"
        Me.gcolareaEjecutada.Name = "gcolareaEjecutada"
        '
        'AprOrdenQuemaFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 340)
        Me.Controls.Add(Me.tsMenu)
        Me.Controls.Add(Me.cbxPeriodo)
        Me.Controls.Add(Me.lblPeriodo)
        Me.Controls.Add(Me.gcOrdenQuema)
        Me.Name = "AprOrdenQuemaFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Orden de Corte"
        CType(Me.gcOrdenQuema, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gcOrdenQuema As DevExpress.XtraGrid.GridControl
    Friend WithEvents dgvDatos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcolOrdenCorte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolLote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolHora As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolFrente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblPeriodo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbxPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents cmbNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents gcolAccidental As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolCruda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolCortefrenteid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolPeriodoid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolDoble As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolhoraOrden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolhoraBascula As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolhoraInicioArrastre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolhoraFinalArrastre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolcorteEstimadoTons As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolcorteEjecutadoTons As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolhoraPrebatey As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolareaEstimada As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcolareaEjecutada As DevExpress.XtraGrid.Columns.GridColumn
End Class
