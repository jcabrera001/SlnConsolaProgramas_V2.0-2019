<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenGuiasRemisionFrm
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
        Me.cbxEmpresa = New DevExpress.XtraEditors.LookUpEdit()
        Me.dtpInicio = New DevExpress.XtraEditors.DateEdit()
        Me.dtpFinal = New DevExpress.XtraEditors.DateEdit()
        Me.Empresa = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtCantidad = New DevExpress.XtraEditors.TextEdit()
        CType(Me.cbxEmpresa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFinal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbxEmpresa
        '
        Me.cbxEmpresa.Location = New System.Drawing.Point(79, 12)
        Me.cbxEmpresa.Name = "cbxEmpresa"
        Me.cbxEmpresa.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxEmpresa.Properties.NullText = ""
        Me.cbxEmpresa.Size = New System.Drawing.Size(169, 20)
        Me.cbxEmpresa.TabIndex = 0
        '
        'dtpInicio
        '
        Me.dtpInicio.EditValue = Nothing
        Me.dtpInicio.Location = New System.Drawing.Point(79, 44)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpInicio.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpInicio.Properties.Mask.EditMask = "mm/dd/yyyy"
        Me.dtpInicio.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Simple
        Me.dtpInicio.Size = New System.Drawing.Size(169, 20)
        Me.dtpInicio.TabIndex = 1
        '
        'dtpFinal
        '
        Me.dtpFinal.EditValue = Nothing
        Me.dtpFinal.Location = New System.Drawing.Point(79, 76)
        Me.dtpFinal.Name = "dtpFinal"
        Me.dtpFinal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFinal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFinal.Size = New System.Drawing.Size(169, 20)
        Me.dtpFinal.TabIndex = 2
        '
        'Empresa
        '
        Me.Empresa.AutoSize = True
        Me.Empresa.Location = New System.Drawing.Point(18, 16)
        Me.Empresa.Name = "Empresa"
        Me.Empresa.Size = New System.Drawing.Size(48, 13)
        Me.Empresa.TabIndex = 4
        Me.Empresa.Text = "Empresa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Fecha Inicio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Fecha Final"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Cantidad"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(79, 143)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(82, 27)
        Me.cmdAceptar.TabIndex = 4
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(166, 143)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(82, 27)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Text = "Cancelar"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(79, 109)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(169, 20)
        Me.txtCantidad.TabIndex = 3
        '
        'GenGuiasRemisionFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(260, 181)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Empresa)
        Me.Controls.Add(Me.dtpFinal)
        Me.Controls.Add(Me.dtpInicio)
        Me.Controls.Add(Me.cbxEmpresa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GenGuiasRemisionFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generador de Guias de Remisión"
        CType(Me.cbxEmpresa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFinal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxEmpresa As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents dtpInicio As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtpFinal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Empresa As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCantidad As DevExpress.XtraEditors.TextEdit
End Class
