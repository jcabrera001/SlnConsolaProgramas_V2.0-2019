<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CoFRemMasFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CoFRemMasFrm))
        Me.CmdGenerar = New DevExpress.XtraEditors.SimpleButton()
        Me.LblEmpresa = New DevExpress.XtraEditors.LabelControl()
        Me.LblPuntoPartida = New DevExpress.XtraEditors.LabelControl()
        Me.TxtEmpresa = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.MemoProceso = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtFechaGenerar = New DevExpress.XtraEditors.TextEdit()
        Me.LblFechaInicio = New DevExpress.XtraEditors.LabelControl()
        Me.LblFechaFinal = New DevExpress.XtraEditors.LabelControl()
        Me.LblCantidad = New DevExpress.XtraEditors.LabelControl()
        Me.TxtFechaInicio = New DevExpress.XtraEditors.DateEdit()
        Me.TxtFechaFinal = New DevExpress.XtraEditors.DateEdit()
        Me.TxtCantidad = New DevExpress.XtraEditors.CalcEdit()
        CType(Me.TxtEmpresa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoProceso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFechaGenerar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFechaInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFechaFinal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFechaFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCantidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmdGenerar
        '
        Me.CmdGenerar.Appearance.Options.UseTextOptions = True
        Me.CmdGenerar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.CmdGenerar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.CmdGenerar.Location = New System.Drawing.Point(347, 464)
        Me.CmdGenerar.Name = "CmdGenerar"
        Me.CmdGenerar.Size = New System.Drawing.Size(150, 50)
        Me.CmdGenerar.TabIndex = 15
        Me.CmdGenerar.Text = "Generar "
        '
        'LblEmpresa
        '
        Me.LblEmpresa.Location = New System.Drawing.Point(116, 211)
        Me.LblEmpresa.Name = "LblEmpresa"
        Me.LblEmpresa.Size = New System.Drawing.Size(45, 13)
        Me.LblEmpresa.TabIndex = 11
        Me.LblEmpresa.Text = "Empresa:"
        '
        'LblPuntoPartida
        '
        Me.LblPuntoPartida.Location = New System.Drawing.Point(116, 262)
        Me.LblPuntoPartida.Name = "LblPuntoPartida"
        Me.LblPuntoPartida.Size = New System.Drawing.Size(84, 13)
        Me.LblPuntoPartida.TabIndex = 12
        Me.LblPuntoPartida.Text = "Punto de partida:"
        '
        'TxtEmpresa
        '
        Me.TxtEmpresa.Location = New System.Drawing.Point(285, 208)
        Me.TxtEmpresa.Name = "TxtEmpresa"
        Me.TxtEmpresa.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtEmpresa.Size = New System.Drawing.Size(321, 20)
        Me.TxtEmpresa.TabIndex = 14
        '
        'MemoProceso
        '
        Me.MemoProceso.EditValue = resources.GetString("MemoProceso.EditValue")
        Me.MemoProceso.Location = New System.Drawing.Point(12, 31)
        Me.MemoProceso.Name = "MemoProceso"
        Me.MemoProceso.Properties.ReadOnly = True
        Me.MemoProceso.Size = New System.Drawing.Size(751, 146)
        Me.MemoProceso.TabIndex = 17
        Me.MemoProceso.UseOptimizedRendering = True
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(94, 13)
        Me.LabelControl1.TabIndex = 16
        Me.LabelControl1.Text = "Proceso del cálculo:"
        '
        'TxtFechaGenerar
        '
        Me.TxtFechaGenerar.Location = New System.Drawing.Point(285, 258)
        Me.TxtFechaGenerar.Name = "TxtFechaGenerar"
        Me.TxtFechaGenerar.Properties.Mask.EditMask = "d"
        Me.TxtFechaGenerar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.TxtFechaGenerar.Size = New System.Drawing.Size(321, 20)
        Me.TxtFechaGenerar.TabIndex = 13
        '
        'LblFechaInicio
        '
        Me.LblFechaInicio.Location = New System.Drawing.Point(116, 310)
        Me.LblFechaInicio.Name = "LblFechaInicio"
        Me.LblFechaInicio.Size = New System.Drawing.Size(74, 13)
        Me.LblFechaInicio.TabIndex = 12
        Me.LblFechaInicio.Text = "Fecha de inicio:"
        '
        'LblFechaFinal
        '
        Me.LblFechaFinal.Location = New System.Drawing.Point(116, 364)
        Me.LblFechaFinal.Name = "LblFechaFinal"
        Me.LblFechaFinal.Size = New System.Drawing.Size(56, 13)
        Me.LblFechaFinal.TabIndex = 12
        Me.LblFechaFinal.Text = "Fecha final:"
        '
        'LblCantidad
        '
        Me.LblCantidad.Location = New System.Drawing.Point(116, 415)
        Me.LblCantidad.Name = "LblCantidad"
        Me.LblCantidad.Size = New System.Drawing.Size(97, 13)
        Me.LblCantidad.TabIndex = 12
        Me.LblCantidad.Text = "Cantidad a generar:"
        '
        'TxtFechaInicio
        '
        Me.TxtFechaInicio.EditValue = Nothing
        Me.TxtFechaInicio.Location = New System.Drawing.Point(285, 306)
        Me.TxtFechaInicio.Name = "TxtFechaInicio"
        Me.TxtFechaInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtFechaInicio.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtFechaInicio.Size = New System.Drawing.Size(212, 20)
        Me.TxtFechaInicio.TabIndex = 13
        '
        'TxtFechaFinal
        '
        Me.TxtFechaFinal.EditValue = Nothing
        Me.TxtFechaFinal.Location = New System.Drawing.Point(285, 360)
        Me.TxtFechaFinal.Name = "TxtFechaFinal"
        Me.TxtFechaFinal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtFechaFinal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtFechaFinal.Size = New System.Drawing.Size(212, 20)
        Me.TxtFechaFinal.TabIndex = 13
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(285, 411)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtCantidad.Properties.Mask.EditMask = "d"
        Me.TxtCantidad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.TxtCantidad.Size = New System.Drawing.Size(212, 20)
        Me.TxtCantidad.TabIndex = 13
        '
        'CoFRemMasFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.Controls.Add(Me.MemoProceso)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.CmdGenerar)
        Me.Controls.Add(Me.LblEmpresa)
        Me.Controls.Add(Me.LblCantidad)
        Me.Controls.Add(Me.LblFechaFinal)
        Me.Controls.Add(Me.LblFechaInicio)
        Me.Controls.Add(Me.LblPuntoPartida)
        Me.Controls.Add(Me.TxtEmpresa)
        Me.Controls.Add(Me.TxtFechaGenerar)
        Me.Controls.Add(Me.TxtFechaInicio)
        Me.Controls.Add(Me.TxtFechaFinal)
        Me.Controls.Add(Me.TxtCantidad)
        Me.Name = "CoFRemMasFrm"
        Me.Text = "Generación Masiva de Boletas de Remisión"
        CType(Me.TxtEmpresa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoProceso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFechaGenerar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFechaInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFechaFinal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFechaFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCantidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmdGenerar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LblEmpresa As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblPuntoPartida As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtEmpresa As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents MemoProceso As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtFechaGenerar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblFechaInicio As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblFechaFinal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblCantidad As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtFechaInicio As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TxtFechaFinal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TxtCantidad As DevExpress.XtraEditors.CalcEdit
End Class
