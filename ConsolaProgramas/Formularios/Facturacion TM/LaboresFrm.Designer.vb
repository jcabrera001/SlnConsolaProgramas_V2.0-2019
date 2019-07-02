<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaboresFrm
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
        Me.XTTEmpaginacion = New DevExpress.XtraTab.XtraTabControl()
        Me.XTTPagina1 = New DevExpress.XtraTab.XtraTabPage()
        Me.gc = New DevExpress.XtraGrid.GridControl()
        Me.gv = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.CmbEditar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CmbNuevo = New System.Windows.Forms.ToolStripButton()
        Me.CmbActualizarConsulta = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CmbEliminar = New System.Windows.Forms.ToolStripButton()
        Me.XTTPagina2 = New DevExpress.XtraTab.XtraTabPage()
        Me.PCTEncabezado = New DevExpress.XtraEditors.PanelControl()
        Me.LblCodigoValor = New DevExpress.XtraEditors.LabelControl()
        Me.LblCodigoRotulo = New DevExpress.XtraEditors.LabelControl()
        Me.LblAccion = New DevExpress.XtraEditors.LabelControl()
        Me.XTTDatos = New DevExpress.XtraTab.XtraTabControl()
        Me.XTPBasico = New DevExpress.XtraTab.XtraTabPage()
        Me.txtTarifa = New DevExpress.XtraEditors.TextEdit()
        Me.txtCuenta = New DevExpress.XtraEditors.TextEdit()
        Me.txtSitio = New DevExpress.XtraEditors.TextEdit()
        Me.txtDescripcion = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigo = New DevExpress.XtraEditors.TextEdit()
        Me.Sitio = New DevExpress.XtraEditors.LabelControl()
        Me.LblValoresPredeterminados = New DevExpress.XtraEditors.LabelControl()
        Me.Cuenta = New DevExpress.XtraEditors.LabelControl()
        Me.tarifa = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LblCodigo = New DevExpress.XtraEditors.LabelControl()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.CmbGrabarNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CmbGrabarSalir = New System.Windows.Forms.ToolStripButton()
        Me.CmbRegresarConsulta = New System.Windows.Forms.ToolStripButton()
        CType(Me.XTTEmpaginacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTTEmpaginacion.SuspendLayout()
        Me.XTTPagina1.SuspendLayout()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenu.SuspendLayout()
        Me.XTTPagina2.SuspendLayout()
        CType(Me.PCTEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PCTEncabezado.SuspendLayout()
        CType(Me.XTTDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTTDatos.SuspendLayout()
        Me.XTPBasico.SuspendLayout()
        CType(Me.txtTarifa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSitio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'XTTEmpaginacion
        '
        Me.XTTEmpaginacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XTTEmpaginacion.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.XTTEmpaginacion.Location = New System.Drawing.Point(13, 13)
        Me.XTTEmpaginacion.Name = "XTTEmpaginacion"
        Me.XTTEmpaginacion.SelectedTabPage = Me.XTTPagina1
        Me.XTTEmpaginacion.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[False]
        Me.XTTEmpaginacion.Size = New System.Drawing.Size(610, 549)
        Me.XTTEmpaginacion.TabIndex = 12
        Me.XTTEmpaginacion.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XTTPagina1, Me.XTTPagina2})
        '
        'XTTPagina1
        '
        Me.XTTPagina1.Controls.Add(Me.gc)
        Me.XTTPagina1.Controls.Add(Me.tsMenu)
        Me.XTTPagina1.Name = "XTTPagina1"
        Me.XTTPagina1.Size = New System.Drawing.Size(604, 543)
        '
        'gc
        '
        Me.gc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gc.Location = New System.Drawing.Point(0, 56)
        Me.gc.MainView = Me.gv
        Me.gc.Name = "gc"
        Me.gc.Size = New System.Drawing.Size(601, 484)
        Me.gc.TabIndex = 11
        Me.gc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv})
        '
        'gv
        '
        Me.gv.GridControl = Me.gc
        Me.gv.Name = "gv"
        Me.gv.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.gv.OptionsFilter.UseNewCustomFilterDialog = True
        Me.gv.OptionsView.ShowAutoFilterRow = True
        Me.gv.OptionsView.ShowFooter = True
        Me.gv.OptionsView.ShowGroupPanel = False
        '
        'tsMenu
        '
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CmbEditar, Me.ToolStripSeparator1, Me.CmbNuevo, Me.CmbActualizarConsulta, Me.ToolStripSeparator3, Me.CmbEliminar})
        Me.tsMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(604, 53)
        Me.tsMenu.TabIndex = 10
        '
        'CmbEditar
        '
        Me.CmbEditar.AutoSize = False
        Me.CmbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmbEditar.Image = Global.ConsolaProgramas.My.Resources.Resources.page_edit
        Me.CmbEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmbEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmbEditar.Name = "CmbEditar"
        Me.CmbEditar.Size = New System.Drawing.Size(50, 50)
        Me.CmbEditar.Text = "Editar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 53)
        '
        'CmbNuevo
        '
        Me.CmbNuevo.AutoSize = False
        Me.CmbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmbNuevo.Image = Global.ConsolaProgramas.My.Resources.Resources.page
        Me.CmbNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmbNuevo.Name = "CmbNuevo"
        Me.CmbNuevo.Size = New System.Drawing.Size(50, 50)
        Me.CmbNuevo.Text = "Nuevo"
        '
        'CmbActualizarConsulta
        '
        Me.CmbActualizarConsulta.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.CmbActualizarConsulta.AutoSize = False
        Me.CmbActualizarConsulta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmbActualizarConsulta.Image = Global.ConsolaProgramas.My.Resources.Resources.arrow_refresh1
        Me.CmbActualizarConsulta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmbActualizarConsulta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmbActualizarConsulta.Name = "CmbActualizarConsulta"
        Me.CmbActualizarConsulta.Size = New System.Drawing.Size(50, 50)
        Me.CmbActualizarConsulta.Text = "Actualizar Consulta"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 53)
        '
        'CmbEliminar
        '
        Me.CmbEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.CmbEliminar.AutoSize = False
        Me.CmbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmbEliminar.Enabled = False
        Me.CmbEliminar.Image = Global.ConsolaProgramas.My.Resources.Resources.delete1
        Me.CmbEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmbEliminar.Name = "CmbEliminar"
        Me.CmbEliminar.Size = New System.Drawing.Size(50, 50)
        Me.CmbEliminar.Text = "Eliminar"
        '
        'XTTPagina2
        '
        Me.XTTPagina2.Controls.Add(Me.PCTEncabezado)
        Me.XTTPagina2.Controls.Add(Me.XTTDatos)
        Me.XTTPagina2.Controls.Add(Me.ToolStrip1)
        Me.XTTPagina2.Name = "XTTPagina2"
        Me.XTTPagina2.Size = New System.Drawing.Size(604, 543)
        Me.XTTPagina2.Text = "XtraTabPage2"
        '
        'PCTEncabezado
        '
        Me.PCTEncabezado.Controls.Add(Me.LblCodigoValor)
        Me.PCTEncabezado.Controls.Add(Me.LblCodigoRotulo)
        Me.PCTEncabezado.Controls.Add(Me.LblAccion)
        Me.PCTEncabezado.Location = New System.Drawing.Point(4, 57)
        Me.PCTEncabezado.Name = "PCTEncabezado"
        Me.PCTEncabezado.Size = New System.Drawing.Size(597, 48)
        Me.PCTEncabezado.TabIndex = 13
        '
        'LblCodigoValor
        '
        Me.LblCodigoValor.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblCodigoValor.Location = New System.Drawing.Point(51, 26)
        Me.LblCodigoValor.Name = "LblCodigoValor"
        Me.LblCodigoValor.Size = New System.Drawing.Size(82, 13)
        Me.LblCodigoValor.TabIndex = 2
        Me.LblCodigoValor.Text = "<NuevoValor>"
        '
        'LblCodigoRotulo
        '
        Me.LblCodigoRotulo.Location = New System.Drawing.Point(8, 26)
        Me.LblCodigoRotulo.Name = "LblCodigoRotulo"
        Me.LblCodigoRotulo.Size = New System.Drawing.Size(37, 13)
        Me.LblCodigoRotulo.TabIndex = 1
        Me.LblCodigoRotulo.Text = "Código:"
        '
        'LblAccion
        '
        Me.LblAccion.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblAccion.Location = New System.Drawing.Point(8, 6)
        Me.LblAccion.Name = "LblAccion"
        Me.LblAccion.Size = New System.Drawing.Size(37, 13)
        Me.LblAccion.TabIndex = 0
        Me.LblAccion.Text = "Acción"
        '
        'XTTDatos
        '
        Me.XTTDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XTTDatos.Location = New System.Drawing.Point(4, 111)
        Me.XTTDatos.Name = "XTTDatos"
        Me.XTTDatos.SelectedTabPage = Me.XTPBasico
        Me.XTTDatos.Size = New System.Drawing.Size(597, 432)
        Me.XTTDatos.TabIndex = 12
        Me.XTTDatos.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XTPBasico})
        '
        'XTPBasico
        '
        Me.XTPBasico.Controls.Add(Me.txtTarifa)
        Me.XTPBasico.Controls.Add(Me.txtCuenta)
        Me.XTPBasico.Controls.Add(Me.txtSitio)
        Me.XTPBasico.Controls.Add(Me.txtDescripcion)
        Me.XTPBasico.Controls.Add(Me.txtCodigo)
        Me.XTPBasico.Controls.Add(Me.Sitio)
        Me.XTPBasico.Controls.Add(Me.LblValoresPredeterminados)
        Me.XTPBasico.Controls.Add(Me.Cuenta)
        Me.XTPBasico.Controls.Add(Me.tarifa)
        Me.XTPBasico.Controls.Add(Me.LabelControl2)
        Me.XTPBasico.Controls.Add(Me.LblCodigo)
        Me.XTPBasico.Name = "XTPBasico"
        Me.XTPBasico.Size = New System.Drawing.Size(591, 404)
        Me.XTPBasico.Text = "Básico"
        '
        'txtTarifa
        '
        Me.txtTarifa.Location = New System.Drawing.Point(135, 134)
        Me.txtTarifa.Name = "txtTarifa"
        Me.txtTarifa.Size = New System.Drawing.Size(153, 20)
        Me.txtTarifa.TabIndex = 2
        '
        'txtCuenta
        '
        Me.txtCuenta.Location = New System.Drawing.Point(135, 170)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(153, 20)
        Me.txtCuenta.TabIndex = 3
        '
        'txtSitio
        '
        Me.txtSitio.Enabled = False
        Me.txtSitio.Location = New System.Drawing.Point(135, 208)
        Me.txtSitio.Name = "txtSitio"
        Me.txtSitio.Size = New System.Drawing.Size(153, 20)
        Me.txtSitio.TabIndex = 4
        Me.txtSitio.Tag = "SM"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(135, 55)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(404, 20)
        Me.txtDescripcion.TabIndex = 1
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(135, 20)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(205, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'Sitio
        '
        Me.Sitio.Location = New System.Drawing.Point(43, 212)
        Me.Sitio.Name = "Sitio"
        Me.Sitio.Size = New System.Drawing.Size(20, 13)
        Me.Sitio.TabIndex = 3
        Me.Sitio.Text = "Sitio"
        '
        'LblValoresPredeterminados
        '
        Me.LblValoresPredeterminados.Location = New System.Drawing.Point(46, 97)
        Me.LblValoresPredeterminados.Name = "LblValoresPredeterminados"
        Me.LblValoresPredeterminados.Size = New System.Drawing.Size(119, 13)
        Me.LblValoresPredeterminados.TabIndex = 2
        Me.LblValoresPredeterminados.Text = "Valores predeterminados"
        '
        'Cuenta
        '
        Me.Cuenta.Location = New System.Drawing.Point(43, 174)
        Me.Cuenta.Name = "Cuenta"
        Me.Cuenta.Size = New System.Drawing.Size(35, 13)
        Me.Cuenta.TabIndex = 2
        Me.Cuenta.Text = "Cuenta"
        '
        'tarifa
        '
        Me.tarifa.Location = New System.Drawing.Point(43, 138)
        Me.tarifa.Name = "tarifa"
        Me.tarifa.Size = New System.Drawing.Size(28, 13)
        Me.tarifa.TabIndex = 2
        Me.tarifa.Text = "Tarifa"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(43, 55)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Descripción"
        '
        'LblCodigo
        '
        Me.LblCodigo.Location = New System.Drawing.Point(43, 20)
        Me.LblCodigo.Name = "LblCodigo"
        Me.LblCodigo.Size = New System.Drawing.Size(33, 13)
        Me.LblCodigo.TabIndex = 0
        Me.LblCodigo.Text = "Código"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CmbGrabarNuevo, Me.ToolStripSeparator2, Me.CmbGrabarSalir, Me.CmbRegresarConsulta})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(604, 53)
        Me.ToolStrip1.TabIndex = 11
        '
        'CmbGrabarNuevo
        '
        Me.CmbGrabarNuevo.AutoSize = False
        Me.CmbGrabarNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmbGrabarNuevo.Image = Global.ConsolaProgramas.My.Resources.Resources.page_save
        Me.CmbGrabarNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmbGrabarNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmbGrabarNuevo.Name = "CmbGrabarNuevo"
        Me.CmbGrabarNuevo.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.CmbGrabarNuevo.Size = New System.Drawing.Size(50, 50)
        Me.CmbGrabarNuevo.Text = "Grabar y crear nuevo registro"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 53)
        '
        'CmbGrabarSalir
        '
        Me.CmbGrabarSalir.AutoSize = False
        Me.CmbGrabarSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmbGrabarSalir.Image = Global.ConsolaProgramas.My.Resources.Resources.disk
        Me.CmbGrabarSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmbGrabarSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmbGrabarSalir.Name = "CmbGrabarSalir"
        Me.CmbGrabarSalir.Size = New System.Drawing.Size(50, 50)
        Me.CmbGrabarSalir.Text = "Grabar cambios"
        '
        'CmbRegresarConsulta
        '
        Me.CmbRegresarConsulta.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.CmbRegresarConsulta.AutoSize = False
        Me.CmbRegresarConsulta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmbRegresarConsulta.Image = Global.ConsolaProgramas.My.Resources.Resources.arrow_rotate_clockwise
        Me.CmbRegresarConsulta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmbRegresarConsulta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmbRegresarConsulta.Name = "CmbRegresarConsulta"
        Me.CmbRegresarConsulta.Size = New System.Drawing.Size(50, 50)
        Me.CmbRegresarConsulta.Text = "Volver a la consulta"
        '
        'LaboresFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 575)
        Me.Controls.Add(Me.XTTEmpaginacion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LaboresFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Labores"
        CType(Me.XTTEmpaginacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTTEmpaginacion.ResumeLayout(False)
        Me.XTTPagina1.ResumeLayout(False)
        Me.XTTPagina1.PerformLayout()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.XTTPagina2.ResumeLayout(False)
        Me.XTTPagina2.PerformLayout()
        CType(Me.PCTEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PCTEncabezado.ResumeLayout(False)
        Me.PCTEncabezado.PerformLayout()
        CType(Me.XTTDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTTDatos.ResumeLayout(False)
        Me.XTPBasico.ResumeLayout(False)
        Me.XTPBasico.PerformLayout()
        CType(Me.txtTarifa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSitio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XTTEmpaginacion As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XTTPagina1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gc As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents CmbEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CmbNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents CmbActualizarConsulta As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CmbEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents XTTPagina2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PCTEncabezado As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LblCodigoValor As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblCodigoRotulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblAccion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XTTDatos As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XTPBasico As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Sitio As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblValoresPredeterminados As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Cuenta As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tarifa As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblCodigo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents CmbGrabarNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CmbGrabarSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents CmbRegresarConsulta As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtTarifa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCuenta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSitio As DevExpress.XtraEditors.TextEdit
End Class
