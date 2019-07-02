<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XGenLogin
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
        Me.cbxEmpresasxUsuario = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbxUsuarios = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.colEmpresaCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmpresa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUsuarioID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPerfil = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.cbxEmpresasxUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxUsuarios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbxEmpresasxUsuario
        '
        Me.cbxEmpresasxUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxEmpresasxUsuario.Location = New System.Drawing.Point(5, 151)
        Me.cbxEmpresasxUsuario.Name = "cbxEmpresasxUsuario"
        Me.cbxEmpresasxUsuario.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxEmpresasxUsuario.Properties.NullText = ""
        Me.cbxEmpresasxUsuario.Properties.View = Me.GridView1
        Me.cbxEmpresasxUsuario.Size = New System.Drawing.Size(265, 20)
        Me.cbxEmpresasxUsuario.TabIndex = 3
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEmpresaCodigo, Me.colEmpresa})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GridView1.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'cbxUsuarios
        '
        Me.cbxUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxUsuarios.EditValue = ""
        Me.cbxUsuarios.Location = New System.Drawing.Point(5, 26)
        Me.cbxUsuarios.Name = "cbxUsuarios"
        Me.cbxUsuarios.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxUsuarios.Properties.NullText = ""
        Me.cbxUsuarios.Properties.View = Me.GridLookUpEdit1View
        Me.cbxUsuarios.Size = New System.Drawing.Size(265, 20)
        Me.cbxUsuarios.TabIndex = 1
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUsuarioID, Me.colNombre, Me.colPerfil})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowFooter = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtPassword.Location = New System.Drawing.Point(5, 86)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(265, 22)
        Me.txtPassword.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Location = New System.Drawing.Point(5, 6)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl1.TabIndex = 18
        Me.LabelControl1.Text = "Usuario:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Location = New System.Drawing.Point(5, 67)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl2.TabIndex = 19
        Me.LabelControl2.Text = "Contraseña:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Location = New System.Drawing.Point(5, 132)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl3.TabIndex = 20
        Me.LabelControl3.Text = "Empresa:"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAceptar.Location = New System.Drawing.Point(5, 185)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAceptar.TabIndex = 21
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCancelar.Location = New System.Drawing.Point(195, 185)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancelar.TabIndex = 22
        Me.cmdCancelar.Text = "Cancelar"
        '
        'colEmpresaCodigo
        '
        Me.colEmpresaCodigo.Caption = "Codigo"
        Me.colEmpresaCodigo.FieldName = "EmpresaCodigo"
        Me.colEmpresaCodigo.Name = "colEmpresaCodigo"
        Me.colEmpresaCodigo.OptionsColumn.AllowFocus = False
        Me.colEmpresaCodigo.OptionsColumn.ReadOnly = True
        Me.colEmpresaCodigo.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colEmpresaCodigo.Visible = True
        Me.colEmpresaCodigo.VisibleIndex = 0
        '
        'colEmpresa
        '
        Me.colEmpresa.Caption = "Empresa"
        Me.colEmpresa.FieldName = "Empresa"
        Me.colEmpresa.Name = "colEmpresa"
        Me.colEmpresa.OptionsColumn.AllowEdit = False
        Me.colEmpresa.OptionsColumn.ReadOnly = True
        Me.colEmpresa.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colEmpresa.Visible = True
        Me.colEmpresa.VisibleIndex = 1
        '
        'colUsuarioID
        '
        Me.colUsuarioID.Caption = "UsuarioID"
        Me.colUsuarioID.FieldName = "UsuarioID"
        Me.colUsuarioID.Name = "colUsuarioID"
        Me.colUsuarioID.OptionsColumn.AllowEdit = False
        Me.colUsuarioID.OptionsColumn.ReadOnly = True
        Me.colUsuarioID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colUsuarioID.Visible = True
        Me.colUsuarioID.VisibleIndex = 0
        '
        'colNombre
        '
        Me.colNombre.Caption = "Nombre"
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.OptionsColumn.AllowEdit = False
        Me.colNombre.OptionsColumn.ReadOnly = True
        Me.colNombre.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 1
        '
        'colPerfil
        '
        Me.colPerfil.Caption = "Perfil"
        Me.colPerfil.FieldName = "Perfil"
        Me.colPerfil.Name = "colPerfil"
        Me.colPerfil.OptionsColumn.AllowEdit = False
        Me.colPerfil.OptionsColumn.ReadOnly = True
        Me.colPerfil.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colPerfil.Visible = True
        Me.colPerfil.VisibleIndex = 2
        '
        'XGenLogin
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 210)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cbxEmpresasxUsuario)
        Me.Controls.Add(Me.cbxUsuarios)
        Me.Controls.Add(Me.txtPassword)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "XGenLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acceso a Consola de Programas"
        CType(Me.cbxEmpresasxUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxUsuarios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxEmpresasxUsuario As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbxUsuarios As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUsuarioID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colEmpresaCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmpresa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colPerfil As DevExpress.XtraGrid.Columns.GridColumn
End Class
