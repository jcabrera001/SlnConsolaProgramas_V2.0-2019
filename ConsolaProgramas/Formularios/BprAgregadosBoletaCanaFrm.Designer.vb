<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BprAgregadosBoletaCanaFrm
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
        Me.BtnActualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.ChkAutoSalvar = New DevExpress.XtraEditors.CheckButton()
        Me.TxtBoletaID = New DevExpress.XtraEditors.TextEdit()
        Me.TxtQuemaID = New DevExpress.XtraEditors.TextEdit()
        Me.TxtPochota = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.TxtBoletaID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtQuemaID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPochota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(35, 188)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(114, 23)
        Me.BtnActualizar.TabIndex = 4
        Me.BtnActualizar.Text = "Actualizar"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(160, 188)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(114, 23)
        Me.BtnLimpiar.TabIndex = 5
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.ToolTip = "Limpiar campos para realizar otra lectura"
        '
        'ChkAutoSalvar
        '
        Me.ChkAutoSalvar.Checked = True
        Me.ChkAutoSalvar.Location = New System.Drawing.Point(35, 147)
        Me.ChkAutoSalvar.Name = "ChkAutoSalvar"
        Me.ChkAutoSalvar.Size = New System.Drawing.Size(239, 23)
        Me.ChkAutoSalvar.TabIndex = 6
        Me.ChkAutoSalvar.Text = "Autosalvar"
        '
        'TxtBoletaID
        '
        Me.TxtBoletaID.EnterMoveNextControl = True
        Me.TxtBoletaID.Location = New System.Drawing.Point(123, 12)
        Me.TxtBoletaID.Name = "TxtBoletaID"
        Me.TxtBoletaID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.TxtBoletaID.Properties.Appearance.Options.UseFont = True
        Me.TxtBoletaID.Size = New System.Drawing.Size(151, 40)
        Me.TxtBoletaID.TabIndex = 1
        '
        'TxtQuemaID
        '
        Me.TxtQuemaID.Location = New System.Drawing.Point(123, 67)
        Me.TxtQuemaID.Name = "TxtQuemaID"
        Me.TxtQuemaID.Size = New System.Drawing.Size(151, 20)
        Me.TxtQuemaID.TabIndex = 2
        '
        'TxtPochota
        '
        Me.TxtPochota.Location = New System.Drawing.Point(123, 110)
        Me.TxtPochota.Name = "TxtPochota"
        Me.TxtPochota.Size = New System.Drawing.Size(151, 20)
        Me.TxtPochota.TabIndex = 3
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(76, 31)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "BoletaID"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(21, 70)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(96, 13)
        Me.LabelControl2.TabIndex = 7
        Me.LabelControl2.Text = "Orden de Quema ID"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(78, 113)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl3.TabIndex = 8
        Me.LabelControl3.Text = "Pochota"
        '
        'BprAgregadosBoletaCanaFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 233)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.TxtPochota)
        Me.Controls.Add(Me.TxtQuemaID)
        Me.Controls.Add(Me.TxtBoletaID)
        Me.Controls.Add(Me.ChkAutoSalvar)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Name = "BprAgregadosBoletaCanaFrm"
        Me.Text = "Agregado a Lectura de datos "
        CType(Me.TxtBoletaID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtQuemaID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPochota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ChkAutoSalvar As DevExpress.XtraEditors.CheckButton
    Friend WithEvents TxtBoletaID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtQuemaID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtPochota As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class
