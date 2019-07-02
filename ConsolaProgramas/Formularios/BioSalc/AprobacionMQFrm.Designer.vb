<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AprobacionMQFrm
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
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.chkSelecionar = New DevExpress.XtraEditors.CheckEdit()
        Me.cmbCategoria = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbZafra = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnMostrar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbQuitar = New System.Windows.Forms.RadioButton()
        Me.rbAprobar = New System.Windows.Forms.RadioButton()
        Me.gcMostrar = New DevExpress.XtraGrid.GridControl()
        Me.gvMostrar = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbSitio = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbSemana = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.chkSelecionar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCategoria.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbZafra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.gcMostrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMostrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSitio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSemana.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(359, 386)
        Me.txtTotal.Multiline = True
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(160, 23)
        Me.txtTotal.TabIndex = 34
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkSelecionar
        '
        Me.chkSelecionar.Enabled = False
        Me.chkSelecionar.Location = New System.Drawing.Point(416, 126)
        Me.chkSelecionar.Name = "chkSelecionar"
        Me.chkSelecionar.Properties.Caption = "..."
        Me.chkSelecionar.Size = New System.Drawing.Size(100, 15)
        Me.chkSelecionar.TabIndex = 33
        '
        'cmbCategoria
        '
        Me.cmbCategoria.Location = New System.Drawing.Point(297, 13)
        Me.cmbCategoria.Name = "cmbCategoria"
        Me.cmbCategoria.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbCategoria.Properties.NullText = ""
        Me.cmbCategoria.Size = New System.Drawing.Size(222, 20)
        Me.cmbCategoria.TabIndex = 31
        '
        'cmbZafra
        '
        Me.cmbZafra.Location = New System.Drawing.Point(297, 39)
        Me.cmbZafra.Name = "cmbZafra"
        Me.cmbZafra.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbZafra.Properties.NullText = ""
        Me.cmbZafra.Size = New System.Drawing.Size(222, 20)
        Me.cmbZafra.TabIndex = 29
        '
        'btnAceptar
        '
        Me.btnAceptar.Enabled = False
        Me.btnAceptar.Location = New System.Drawing.Point(10, 386)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(200, 23)
        Me.btnAceptar.TabIndex = 28
        Me.btnAceptar.Text = "Aceptar"
        '
        'btnMostrar
        '
        Me.btnMostrar.Enabled = False
        Me.btnMostrar.Location = New System.Drawing.Point(10, 122)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(200, 23)
        Me.btnMostrar.TabIndex = 27
        Me.btnMostrar.Text = "Mostrar Información"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbQuitar)
        Me.GroupBox1.Controls.Add(Me.rbAprobar)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 26
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
        Me.gcMostrar.Location = New System.Drawing.Point(10, 151)
        Me.gcMostrar.MainView = Me.gvMostrar
        Me.gcMostrar.Name = "gcMostrar"
        Me.gcMostrar.Size = New System.Drawing.Size(509, 229)
        Me.gcMostrar.TabIndex = 25
        Me.gcMostrar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMostrar})
        '
        'gvMostrar
        '
        Me.gvMostrar.GridControl = Me.gcMostrar
        Me.gvMostrar.Name = "gvMostrar"
        Me.gvMostrar.OptionsView.ShowGroupPanel = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(231, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Semana:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(231, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Zafra:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(231, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Categoria:"
        '
        'cmbSitio
        '
        Me.cmbSitio.Enabled = False
        Me.cmbSitio.Location = New System.Drawing.Point(297, 91)
        Me.cmbSitio.Name = "cmbSitio"
        Me.cmbSitio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbSitio.Properties.NullText = ""
        Me.cmbSitio.Size = New System.Drawing.Size(222, 20)
        Me.cmbSitio.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(228, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Sitio:"
        '
        'cmbSemana
        '
        Me.cmbSemana.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbSemana.Location = New System.Drawing.Point(297, 65)
        Me.cmbSemana.Name = "cmbSemana"
        Me.cmbSemana.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbSemana.Properties.NullText = ""
        Me.cmbSemana.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cmbSemana.Properties.View = Me.GridView1
        Me.cmbSemana.Size = New System.Drawing.Size(222, 20)
        Me.cmbSemana.TabIndex = 53
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
        'AprobacionMQFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 418)
        Me.Controls.Add(Me.cmbSemana)
        Me.Controls.Add(Me.cmbSitio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.chkSelecionar)
        Me.Controls.Add(Me.cmbCategoria)
        Me.Controls.Add(Me.cmbZafra)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gcMostrar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AprobacionMQFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aprobación Maquinaria Contratada"
        CType(Me.chkSelecionar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCategoria.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents chkSelecionar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmbCategoria As DevExpress.XtraEditors.LookUpEdit
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbSitio As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbSemana As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
