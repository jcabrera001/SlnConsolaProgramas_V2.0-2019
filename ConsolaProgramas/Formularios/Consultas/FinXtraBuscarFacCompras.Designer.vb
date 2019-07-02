<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinXtraBuscarFacCompras
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
        Me.GrdConsulta = New DevExpress.XtraGrid.GridControl()
        Me.GrdConsultaView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GrdConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdConsultaView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrdConsulta
        '
        Me.GrdConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrdConsulta.Location = New System.Drawing.Point(0, 0)
        Me.GrdConsulta.MainView = Me.GrdConsultaView
        Me.GrdConsulta.Name = "GrdConsulta"
        Me.GrdConsulta.Size = New System.Drawing.Size(690, 273)
        Me.GrdConsulta.TabIndex = 12
        Me.GrdConsulta.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GrdConsultaView})
        '
        'GrdConsultaView
        '
        Me.GrdConsultaView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn6, Me.GridColumn5, Me.GridColumn7, Me.GridColumn8})
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
        Me.GridColumn1.Caption = "ID"
        Me.GridColumn1.FieldName = "CAIXSdNID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "SocioNegocioID"
        Me.GridColumn2.FieldName = "SdN"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Socio Negocio"
        Me.GridColumn3.FieldName = "Description"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "CAI"
        Me.GridColumn4.FieldName = "CAI"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Fecha"
        Me.GridColumn6.FieldName = "Fecha"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Correlativo"
        Me.GridColumn5.FieldName = "Correlativo"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "RetencionID"
        Me.GridColumn7.FieldName = "RetencionID"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "FactCompID"
        Me.GridColumn8.FieldName = "FactCompID"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        '
        'FinXtraBuscarFacCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 273)
        Me.Controls.Add(Me.GrdConsulta)
        Me.Name = "FinXtraBuscarFacCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de Facturas de proveedores..."
        CType(Me.GrdConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdConsultaView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrdConsulta As DevExpress.XtraGrid.GridControl
    Friend WithEvents GrdConsultaView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
End Class
