<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class GenLoginFrm
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.cbxUsuarios = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUsuarioID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxEmpresasxUsuario = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxUsuarios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxEmpresasxUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogoPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(331, 221)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'UsernameLabel
        '
        Me.UsernameLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(7, 3)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(80, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&Usuario:"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(7, 65)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(71, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Contraseña"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(87, 191)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(98, 20)
        Me.txtUsuario.TabIndex = 1
        Me.txtUsuario.Visible = False
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(5, 89)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(319, 20)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(5, 191)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(56, 23)
        Me.OK.TabIndex = 4
        Me.OK.Text = "&Aceptar"
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(266, 191)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(58, 23)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "Ca&ncelar"
        '
        'cbxUsuarios
        '
        Me.cbxUsuarios.EditValue = ""
        Me.cbxUsuarios.Location = New System.Drawing.Point(5, 29)
        Me.cbxUsuarios.Name = "cbxUsuarios"
        Me.cbxUsuarios.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxUsuarios.Properties.NullText = ""
        Me.cbxUsuarios.Properties.View = Me.GridLookUpEdit1View
        Me.cbxUsuarios.Size = New System.Drawing.Size(319, 20)
        Me.cbxUsuarios.TabIndex = 6
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUsuarioID, Me.colNombre})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowFooter = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
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
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Empresa:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbxEmpresasxUsuario
        '
        Me.cbxEmpresasxUsuario.Location = New System.Drawing.Point(5, 154)
        Me.cbxEmpresasxUsuario.Name = "cbxEmpresasxUsuario"
        Me.cbxEmpresasxUsuario.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxEmpresasxUsuario.Properties.NullText = ""
        Me.cbxEmpresasxUsuario.Properties.View = Me.GridView1
        Me.cbxEmpresasxUsuario.Size = New System.Drawing.Size(319, 20)
        Me.cbxEmpresasxUsuario.TabIndex = 8
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GenLoginFrm
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(331, 221)
        Me.ControlBox = False
        Me.Controls.Add(Me.cbxEmpresasxUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxUsuarios)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GenLoginFrm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Acceso a Consola de Programas"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxUsuarios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxEmpresasxUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxUsuarios As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxEmpresasxUsuario As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUsuarioID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn

End Class
