<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AprobacionMOFrm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gcMostrar = New DevExpress.XtraGrid.GridControl()
        Me.gvMostrar = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbQuitar = New System.Windows.Forms.RadioButton()
        Me.rbAprobar = New System.Windows.Forms.RadioButton()
        Me.btnMostrar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbSitio = New DevExpress.XtraEditors.LookUpEdit()
        Me.chkSelecionar = New DevExpress.XtraEditors.CheckEdit()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.cmbZafra = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbSemana = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmbContratista = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ContratistaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Nombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Seleccionar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Distrito = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FincaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Finca = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Lote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Total = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.gcMostrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMostrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cmbSitio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSelecionar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbZafra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSemana.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbContratista.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(233, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sitio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(233, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contratista:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(233, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Zafra:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(233, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Semana:"
        '
        'gcMostrar
        '
        Me.gcMostrar.Location = New System.Drawing.Point(12, 150)
        Me.gcMostrar.MainView = Me.gvMostrar
        Me.gcMostrar.Name = "gcMostrar"
        Me.gcMostrar.Size = New System.Drawing.Size(509, 229)
        Me.gcMostrar.TabIndex = 9
        Me.gcMostrar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMostrar})
        '
        'gvMostrar
        '
        Me.gvMostrar.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Seleccionar, Me.Distrito, Me.FincaID, Me.Finca, Me.Lote, Me.Total})
        Me.gvMostrar.GridControl = Me.gcMostrar
        Me.gvMostrar.Name = "gvMostrar"
        Me.gvMostrar.OptionsView.ShowAutoFilterRow = True
        Me.gvMostrar.OptionsView.ShowGroupPanel = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbQuitar)
        Me.GroupBox1.Controls.Add(Me.rbAprobar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 10
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
        'btnMostrar
        '
        Me.btnMostrar.Enabled = False
        Me.btnMostrar.Location = New System.Drawing.Point(12, 121)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(200, 23)
        Me.btnMostrar.TabIndex = 11
        Me.btnMostrar.Text = "Mostrar Información"
        '
        'btnAceptar
        '
        Me.btnAceptar.Enabled = False
        Me.btnAceptar.Location = New System.Drawing.Point(12, 385)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(200, 23)
        Me.btnAceptar.TabIndex = 12
        Me.btnAceptar.Text = "Aceptar"
        '
        'cmbSitio
        '
        Me.cmbSitio.Location = New System.Drawing.Point(299, 9)
        Me.cmbSitio.Name = "cmbSitio"
        Me.cmbSitio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbSitio.Properties.NullText = ""
        Me.cmbSitio.Size = New System.Drawing.Size(222, 20)
        Me.cmbSitio.TabIndex = 17
        '
        'chkSelecionar
        '
        Me.chkSelecionar.Enabled = False
        Me.chkSelecionar.Location = New System.Drawing.Point(418, 125)
        Me.chkSelecionar.Name = "chkSelecionar"
        Me.chkSelecionar.Properties.Caption = "Aprobar Todos"
        Me.chkSelecionar.Size = New System.Drawing.Size(100, 15)
        Me.chkSelecionar.TabIndex = 19
        Me.chkSelecionar.Visible = False
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(402, 385)
        Me.txtTotal.Multiline = True
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(119, 23)
        Me.txtTotal.TabIndex = 20
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbZafra
        '
        Me.cmbZafra.Location = New System.Drawing.Point(299, 66)
        Me.cmbZafra.Name = "cmbZafra"
        Me.cmbZafra.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbZafra.Properties.NullText = ""
        Me.cmbZafra.Size = New System.Drawing.Size(222, 20)
        Me.cmbZafra.TabIndex = 15
        '
        'cmbSemana
        '
        Me.cmbSemana.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbSemana.Location = New System.Drawing.Point(299, 95)
        Me.cmbSemana.Name = "cmbSemana"
        Me.cmbSemana.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbSemana.Properties.NullText = ""
        Me.cmbSemana.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cmbSemana.Properties.View = Me.GridView1
        Me.cmbSemana.Size = New System.Drawing.Size(222, 20)
        Me.cmbSemana.TabIndex = 52
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
        'cmbContratista
        '
        Me.cmbContratista.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbContratista.Location = New System.Drawing.Point(299, 37)
        Me.cmbContratista.Name = "cmbContratista"
        Me.cmbContratista.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbContratista.Properties.NullText = ""
        Me.cmbContratista.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cmbContratista.Properties.View = Me.GridView2
        Me.cmbContratista.Size = New System.Drawing.Size(222, 20)
        Me.cmbContratista.TabIndex = 53
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ContratistaID, Me.Nombre})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GridView2.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowAutoFilterRow = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'ContratistaID
        '
        Me.ContratistaID.Caption = "Código"
        Me.ContratistaID.FieldName = "ContratistaID"
        Me.ContratistaID.Name = "ContratistaID"
        Me.ContratistaID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.ContratistaID.Visible = True
        Me.ContratistaID.VisibleIndex = 0
        '
        'Nombre
        '
        Me.Nombre.Caption = "Nombre"
        Me.Nombre.FieldName = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Nombre.Visible = True
        Me.Nombre.VisibleIndex = 1
        '
        'Seleccionar
        '
        Me.Seleccionar.Caption = "Seleccionar"
        Me.Seleccionar.FieldName = "Selector"
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.OptionsColumn.ReadOnly = True
        Me.Seleccionar.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Seleccionar.Visible = True
        Me.Seleccionar.VisibleIndex = 0
        Me.Seleccionar.Width = 50
        '
        'Distrito
        '
        Me.Distrito.Caption = "Distrito"
        Me.Distrito.FieldName = "DistritoID"
        Me.Distrito.Name = "Distrito"
        Me.Distrito.OptionsColumn.AllowEdit = False
        Me.Distrito.OptionsColumn.ReadOnly = True
        Me.Distrito.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Distrito.Visible = True
        Me.Distrito.VisibleIndex = 1
        Me.Distrito.Width = 50
        '
        'FincaID
        '
        Me.FincaID.Caption = "FincaID"
        Me.FincaID.FieldName = "FincaID"
        Me.FincaID.Name = "FincaID"
        Me.FincaID.OptionsColumn.AllowEdit = False
        Me.FincaID.OptionsColumn.ReadOnly = True
        Me.FincaID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.FincaID.Visible = True
        Me.FincaID.VisibleIndex = 2
        Me.FincaID.Width = 60
        '
        'Finca
        '
        Me.Finca.Caption = "Finca"
        Me.Finca.FieldName = "Finca"
        Me.Finca.Name = "Finca"
        Me.Finca.OptionsColumn.AllowEdit = False
        Me.Finca.OptionsColumn.ReadOnly = True
        Me.Finca.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Finca.Visible = True
        Me.Finca.VisibleIndex = 3
        Me.Finca.Width = 140
        '
        'Lote
        '
        Me.Lote.Caption = "Lote"
        Me.Lote.FieldName = "LoteID"
        Me.Lote.Name = "Lote"
        Me.Lote.OptionsColumn.AllowEdit = False
        Me.Lote.OptionsColumn.ReadOnly = True
        Me.Lote.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Lote.Visible = True
        Me.Lote.VisibleIndex = 4
        Me.Lote.Width = 50
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
        Me.Total.Visible = True
        Me.Total.VisibleIndex = 5
        Me.Total.Width = 70
        '
        'AprobacionMOFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 420)
        Me.Controls.Add(Me.cmbContratista)
        Me.Controls.Add(Me.cmbSemana)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.chkSelecionar)
        Me.Controls.Add(Me.cmbSitio)
        Me.Controls.Add(Me.cmbZafra)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gcMostrar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AprobacionMOFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aprobación Mano de Obra"
        CType(Me.gcMostrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMostrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cmbSitio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSelecionar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbZafra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSemana.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbContratista.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gcMostrar As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvMostrar As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbQuitar As System.Windows.Forms.RadioButton
    Friend WithEvents rbAprobar As System.Windows.Forms.RadioButton
    Friend WithEvents btnMostrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbSitio As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents chkSelecionar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents cmbZafra As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbSemana As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmbContratista As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ContratistaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Seleccionar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Distrito As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FincaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Finca As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Lote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Total As DevExpress.XtraGrid.Columns.GridColumn
End Class
