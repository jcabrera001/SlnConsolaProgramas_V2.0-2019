<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CoFInteresesCanerosFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CoFInteresesCanerosFrm))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.MemoProceso = New DevExpress.XtraEditors.MemoEdit()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.CmdGenerar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtFechaGenerar = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtEmpresa = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.TxtDescripcion = New DevExpress.XtraEditors.TextEdit()
        Me.TxtLibroDiario = New DevExpress.XtraEditors.TextEdit()
        Me.CmdCargarProtean = New DevExpress.XtraEditors.SimpleButton()
        Me.LblTipoSaldo = New DevExpress.XtraEditors.LabelControl()
        Me.LblMoneda = New DevExpress.XtraEditors.LabelControl()
        Me.LblFecha = New DevExpress.XtraEditors.LabelControl()
        Me.LblDescripcion = New DevExpress.XtraEditors.LabelControl()
        Me.LblLibroDiario = New DevExpress.XtraEditors.LabelControl()
        Me.TxtFecha = New DevExpress.XtraEditors.DateEdit()
        Me.TxtMoneda = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.TxtTipoSaldo = New DevExpress.XtraEditors.ComboBoxEdit()
        CType(Me.MemoProceso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.TxtFechaGenerar.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFechaGenerar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtEmpresa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.TxtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtLibroDiario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTipoSaldo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(94, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Proceso del cálculo:"
        '
        'MemoProceso
        '
        Me.MemoProceso.EditValue = resources.GetString("MemoProceso.EditValue")
        Me.MemoProceso.Location = New System.Drawing.Point(12, 31)
        Me.MemoProceso.Name = "MemoProceso"
        Me.MemoProceso.Properties.ReadOnly = True
        Me.MemoProceso.Size = New System.Drawing.Size(751, 146)
        Me.MemoProceso.TabIndex = 2
        Me.MemoProceso.UseOptimizedRendering = True
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(12, 184)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(751, 356)
        Me.XtraTabControl1.TabIndex = 3
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.CmdGenerar)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage1.Controls.Add(Me.TxtFechaGenerar)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage1.Controls.Add(Me.TxtEmpresa)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(745, 328)
        Me.XtraTabPage1.Text = "XtraTabPage1"
        '
        'CmdGenerar
        '
        Me.CmdGenerar.Appearance.Options.UseTextOptions = True
        Me.CmdGenerar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.CmdGenerar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.CmdGenerar.Location = New System.Drawing.Point(538, 140)
        Me.CmdGenerar.Name = "CmdGenerar"
        Me.CmdGenerar.Size = New System.Drawing.Size(150, 50)
        Me.CmdGenerar.TabIndex = 10
        Me.CmdGenerar.Text = "Generar intereses"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(42, 107)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl3.TabIndex = 6
        Me.LabelControl3.Text = "Empresa:"
        '
        'TxtFechaGenerar
        '
        Me.TxtFechaGenerar.EditValue = Nothing
        Me.TxtFechaGenerar.Location = New System.Drawing.Point(211, 154)
        Me.TxtFechaGenerar.Name = "TxtFechaGenerar"
        Me.TxtFechaGenerar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtFechaGenerar.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtFechaGenerar.Size = New System.Drawing.Size(321, 20)
        Me.TxtFechaGenerar.TabIndex = 8
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(42, 158)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(132, 13)
        Me.LabelControl2.TabIndex = 7
        Me.LabelControl2.Text = "Fecha de cierre de período:"
        '
        'TxtEmpresa
        '
        Me.TxtEmpresa.Location = New System.Drawing.Point(211, 104)
        Me.TxtEmpresa.Name = "TxtEmpresa"
        Me.TxtEmpresa.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtEmpresa.Size = New System.Drawing.Size(321, 20)
        Me.TxtEmpresa.TabIndex = 9
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GridControl1)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl4)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(745, 328)
        Me.XtraTabPage2.Text = "XtraTabPage2"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(13, 35)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(714, 273)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn5, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "ID"
        Me.GridColumn5.Name = "GridColumn5"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Cuenta"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Monto"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Débito/Crédito"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Descripción"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl4.Location = New System.Drawing.Point(13, 15)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(393, 13)
        Me.LabelControl4.TabIndex = 0
        Me.LabelControl4.Text = "El proceso de cálculo de intereses se ha generado satisfactoriamente!"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.TxtDescripcion)
        Me.XtraTabPage3.Controls.Add(Me.TxtLibroDiario)
        Me.XtraTabPage3.Controls.Add(Me.CmdCargarProtean)
        Me.XtraTabPage3.Controls.Add(Me.LblTipoSaldo)
        Me.XtraTabPage3.Controls.Add(Me.LblMoneda)
        Me.XtraTabPage3.Controls.Add(Me.LblFecha)
        Me.XtraTabPage3.Controls.Add(Me.LblDescripcion)
        Me.XtraTabPage3.Controls.Add(Me.LblLibroDiario)
        Me.XtraTabPage3.Controls.Add(Me.TxtFecha)
        Me.XtraTabPage3.Controls.Add(Me.TxtMoneda)
        Me.XtraTabPage3.Controls.Add(Me.TxtTipoSaldo)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(745, 328)
        Me.XtraTabPage3.Text = "XtraTabPage3"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(242, 75)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(329, 20)
        Me.TxtDescripcion.TabIndex = 2
        '
        'TxtLibroDiario
        '
        Me.TxtLibroDiario.Location = New System.Drawing.Point(242, 28)
        Me.TxtLibroDiario.Name = "TxtLibroDiario"
        Me.TxtLibroDiario.Size = New System.Drawing.Size(150, 20)
        Me.TxtLibroDiario.TabIndex = 2
        '
        'CmdCargarProtean
        '
        Me.CmdCargarProtean.Location = New System.Drawing.Point(294, 238)
        Me.CmdCargarProtean.Name = "CmdCargarProtean"
        Me.CmdCargarProtean.Size = New System.Drawing.Size(150, 50)
        Me.CmdCargarProtean.TabIndex = 1
        Me.CmdCargarProtean.Text = "Cargar en Protean"
        '
        'LblTipoSaldo
        '
        Me.LblTipoSaldo.Location = New System.Drawing.Point(81, 192)
        Me.LblTipoSaldo.Name = "LblTipoSaldo"
        Me.LblTipoSaldo.Size = New System.Drawing.Size(64, 13)
        Me.LblTipoSaldo.TabIndex = 0
        Me.LblTipoSaldo.Text = "Tipo de Saldo"
        '
        'LblMoneda
        '
        Me.LblMoneda.Location = New System.Drawing.Point(80, 154)
        Me.LblMoneda.Name = "LblMoneda"
        Me.LblMoneda.Size = New System.Drawing.Size(38, 13)
        Me.LblMoneda.TabIndex = 0
        Me.LblMoneda.Text = "Moneda"
        '
        'LblFecha
        '
        Me.LblFecha.Location = New System.Drawing.Point(80, 119)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(29, 13)
        Me.LblFecha.TabIndex = 0
        Me.LblFecha.Text = "Fecha"
        '
        'LblDescripcion
        '
        Me.LblDescripcion.Location = New System.Drawing.Point(81, 79)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(54, 13)
        Me.LblDescripcion.TabIndex = 0
        Me.LblDescripcion.Text = "Descripción"
        '
        'LblLibroDiario
        '
        Me.LblLibroDiario.Location = New System.Drawing.Point(81, 32)
        Me.LblLibroDiario.Name = "LblLibroDiario"
        Me.LblLibroDiario.Size = New System.Drawing.Size(53, 13)
        Me.LblLibroDiario.TabIndex = 0
        Me.LblLibroDiario.Text = "Libro Diario"
        '
        'TxtFecha
        '
        Me.TxtFecha.EditValue = Nothing
        Me.TxtFecha.Location = New System.Drawing.Point(242, 115)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtFecha.Properties.Mask.EditMask = ""
        Me.TxtFecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.TxtFecha.Size = New System.Drawing.Size(150, 20)
        Me.TxtFecha.TabIndex = 2
        '
        'TxtMoneda
        '
        Me.TxtMoneda.Location = New System.Drawing.Point(242, 150)
        Me.TxtMoneda.Name = "TxtMoneda"
        Me.TxtMoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtMoneda.Size = New System.Drawing.Size(150, 20)
        Me.TxtMoneda.TabIndex = 2
        '
        'TxtTipoSaldo
        '
        Me.TxtTipoSaldo.Location = New System.Drawing.Point(242, 188)
        Me.TxtTipoSaldo.Name = "TxtTipoSaldo"
        Me.TxtTipoSaldo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtTipoSaldo.Size = New System.Drawing.Size(150, 20)
        Me.TxtTipoSaldo.TabIndex = 2
        '
        'CoFInteresesCanerosFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.MemoProceso)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "CoFInteresesCanerosFrm"
        Me.Text = "Intereses Cañeros Independientes"
        CType(Me.MemoProceso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.TxtFechaGenerar.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFechaGenerar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtEmpresa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage3.PerformLayout()
        CType(Me.TxtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtLibroDiario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTipoSaldo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MemoProceso As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents CmdGenerar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtFechaGenerar As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtEmpresa As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents CmdCargarProtean As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LblTipoSaldo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblMoneda As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblFecha As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblDescripcion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblLibroDiario As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtDescripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtLibroDiario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TxtMoneda As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents TxtTipoSaldo As DevExpress.XtraEditors.ComboBoxEdit

End Class
