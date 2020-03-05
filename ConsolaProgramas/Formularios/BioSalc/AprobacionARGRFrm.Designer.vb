<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AprobacionARGRFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.chkSelecionar = New DevExpress.XtraEditors.CheckEdit()
        Me.cmbZafra = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnMostrar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbQuitar = New System.Windows.Forms.RadioButton()
        Me.rbAprobar = New System.Windows.Forms.RadioButton()
        Me.gcMostrar = New DevExpress.XtraGrid.GridControl()
        Me.gvMostrar = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Seleccionar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Factura = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Empresa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Total = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Cobrar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Categoria = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbSitio = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbSemana = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.chkSelecionar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbZafra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.gcMostrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMostrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSitio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSemana.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(228, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Sitio:"
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(359, 384)
        Me.txtTotal.Multiline = True
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(160, 23)
        Me.txtTotal.TabIndex = 48
        Me.txtTotal.Text = "0.0"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkSelecionar
        '
        Me.chkSelecionar.Enabled = False
        Me.chkSelecionar.Location = New System.Drawing.Point(416, 124)
        Me.chkSelecionar.Name = "chkSelecionar"
        Me.chkSelecionar.Properties.Caption = "..."
        Me.chkSelecionar.Size = New System.Drawing.Size(100, 15)
        Me.chkSelecionar.TabIndex = 47
        '
        'cmbZafra
        '
        Me.cmbZafra.Location = New System.Drawing.Point(297, 17)
        Me.cmbZafra.Name = "cmbZafra"
        Me.cmbZafra.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbZafra.Properties.NullText = ""
        Me.cmbZafra.Size = New System.Drawing.Size(222, 20)
        Me.cmbZafra.TabIndex = 44
        '
        'btnAceptar
        '
        Me.btnAceptar.Enabled = False
        Me.btnAceptar.Location = New System.Drawing.Point(10, 384)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(200, 23)
        Me.btnAceptar.TabIndex = 43
        Me.btnAceptar.Text = "Aceptar"
        '
        'btnMostrar
        '
        Me.btnMostrar.Enabled = False
        Me.btnMostrar.Location = New System.Drawing.Point(10, 120)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(200, 23)
        Me.btnMostrar.TabIndex = 42
        Me.btnMostrar.Text = "Mostrar Información"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbQuitar)
        Me.GroupBox1.Controls.Add(Me.rbAprobar)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccionar Tipo de Transacción"
        '
        'rbQuitar
        '
        Me.rbQuitar.AutoSize = True
        Me.rbQuitar.Location = New System.Drawing.Point(16, 66)
        Me.rbQuitar.Name = "rbQuitar"
        Me.rbQuitar.Size = New System.Drawing.Size(110, 17)
        Me.rbQuitar.TabIndex = 3
        Me.rbQuitar.TabStop = True
        Me.rbQuitar.Text = "Quitar Aprobación"
        Me.rbQuitar.UseVisualStyleBackColor = True
        '
        'rbAprobar
        '
        Me.rbAprobar.AutoSize = True
        Me.rbAprobar.Location = New System.Drawing.Point(16, 25)
        Me.rbAprobar.Name = "rbAprobar"
        Me.rbAprobar.Size = New System.Drawing.Size(79, 17)
        Me.rbAprobar.TabIndex = 2
        Me.rbAprobar.TabStop = True
        Me.rbAprobar.Text = "Aprobación"
        Me.rbAprobar.UseVisualStyleBackColor = True
        '
        'gcMostrar
        '
        Me.gcMostrar.Location = New System.Drawing.Point(10, 149)
        Me.gcMostrar.MainView = Me.gvMostrar
        Me.gcMostrar.Name = "gcMostrar"
        Me.gcMostrar.Size = New System.Drawing.Size(509, 229)
        Me.gcMostrar.TabIndex = 40
        Me.gcMostrar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMostrar})
        '
        'gvMostrar
        '
        Me.gvMostrar.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Seleccionar, Me.Factura, Me.Empresa, Me.Total, Me.Cobrar, Me.Categoria})
        Me.gvMostrar.GridControl = Me.gcMostrar
        Me.gvMostrar.Name = "gvMostrar"
        Me.gvMostrar.OptionsView.ShowAutoFilterRow = True
        Me.gvMostrar.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gvMostrar.OptionsView.ShowGroupPanel = False
        '
        'Seleccionar
        '
        Me.Seleccionar.Caption = "Seleccionar"
        Me.Seleccionar.FieldName = "Selector"
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Seleccionar.Visible = True
        Me.Seleccionar.VisibleIndex = 0
        Me.Seleccionar.Width = 57
        '
        'Factura
        '
        Me.Factura.Caption = "Factura"
        Me.Factura.FieldName = "Factura"
        Me.Factura.Name = "Factura"
        Me.Factura.OptionsColumn.AllowEdit = False
        Me.Factura.OptionsColumn.ReadOnly = True
        Me.Factura.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Factura.Visible = True
        Me.Factura.VisibleIndex = 1
        Me.Factura.Width = 60
        '
        'Empresa
        '
        Me.Empresa.Caption = "Empresa"
        Me.Empresa.FieldName = "Empresa"
        Me.Empresa.Name = "Empresa"
        Me.Empresa.OptionsColumn.AllowEdit = False
        Me.Empresa.OptionsColumn.ReadOnly = True
        Me.Empresa.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Empresa.Visible = True
        Me.Empresa.VisibleIndex = 2
        Me.Empresa.Width = 60
        '
        'Total
        '
        Me.Total.Caption = "Total"
        Me.Total.DisplayFormat.FormatString = "{0:0,0.00}"
        Me.Total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Total.FieldName = "Total"
        Me.Total.Name = "Total"
        Me.Total.OptionsColumn.AllowEdit = False
        Me.Total.OptionsColumn.ReadOnly = True
        Me.Total.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Total.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.Total.Visible = True
        Me.Total.VisibleIndex = 3
        Me.Total.Width = 70
        '
        'Cobrar
        '
        Me.Cobrar.Caption = "Cobrar"
        Me.Cobrar.DisplayFormat.FormatString = "{0:0,0.00}"
        Me.Cobrar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Cobrar.FieldName = "TotalAdmon"
        Me.Cobrar.Name = "Cobrar"
        Me.Cobrar.OptionsColumn.AllowEdit = False
        Me.Cobrar.OptionsColumn.ReadOnly = True
        Me.Cobrar.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Cobrar.Visible = True
        Me.Cobrar.VisibleIndex = 4
        Me.Cobrar.Width = 70
        '
        'Categoria
        '
        Me.Categoria.Caption = "Categoria"
        Me.Categoria.FieldName = "Categ"
        Me.Categoria.Name = "Categoria"
        Me.Categoria.OptionsColumn.AllowEdit = False
        Me.Categoria.OptionsColumn.ReadOnly = True
        Me.Categoria.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Categoria.Visible = True
        Me.Categoria.VisibleIndex = 5
        Me.Categoria.Width = 70
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(231, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Semana:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(231, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Zafra:"
        '
        'cmbSitio
        '
        Me.cmbSitio.Location = New System.Drawing.Point(297, 69)
        Me.cmbSitio.Name = "cmbSitio"
        Me.cmbSitio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbSitio.Properties.NullText = ""
        Me.cmbSitio.Size = New System.Drawing.Size(222, 20)
        Me.cmbSitio.TabIndex = 50
        '
        'cmbSemana
        '
        Me.cmbSemana.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbSemana.Location = New System.Drawing.Point(297, 43)
        Me.cmbSemana.Name = "cmbSemana"
        Me.cmbSemana.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbSemana.Properties.NullText = ""
        Me.cmbSemana.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cmbSemana.Properties.View = Me.GridView1
        Me.cmbSemana.Size = New System.Drawing.Size(222, 20)
        Me.cmbSemana.TabIndex = 51
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GridView1.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'AprobacionARGRFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 418)
        Me.Controls.Add(Me.cmbSemana)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.chkSelecionar)
        Me.Controls.Add(Me.cmbZafra)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gcMostrar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbSitio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AprobacionARGRFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aprobación Facturas Riegos"
        CType(Me.chkSelecionar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbZafra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.gcMostrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMostrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSitio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSemana.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents chkSelecionar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmbZafra As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnMostrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbQuitar As System.Windows.Forms.RadioButton
    Friend WithEvents rbAprobar As System.Windows.Forms.RadioButton
    Friend WithEvents gcMostrar As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvMostrar As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbSitio As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbSemana As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Seleccionar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Factura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Empresa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Cobrar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Categoria As DevExpress.XtraGrid.Columns.GridColumn
End Class
