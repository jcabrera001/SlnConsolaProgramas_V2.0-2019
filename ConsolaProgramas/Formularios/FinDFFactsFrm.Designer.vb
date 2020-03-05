<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinDFFactsFrm
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
        Dim CmbRegCancelar As DevExpress.XtraEditors.SimpleButton
        Dim CmbRegActualizar As DevExpress.XtraEditors.SimpleButton
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FinDFFactsFrm))
        Me.XTTEmpaginacion = New DevExpress.XtraTab.XtraTabControl()
        Me.XTTPagina1 = New DevExpress.XtraTab.XtraTabPage()
        Me.GrdConsulta = New DevExpress.XtraGrid.GridControl()
        Me.GrdConsultaView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSelector = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkSelector = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colDFFactID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn44 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn45 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.CmbNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CmbEditar = New System.Windows.Forms.ToolStripButton()
        Me.CmbActualizarConsulta = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CmbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.CmbAnular = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblTipoProcesoImpresion = New System.Windows.Forms.ToolStripLabel()
        Me.CmbOpcImpresion = New System.Windows.Forms.ToolStripComboBox()
        Me.lblFrecuenciaImpresion = New System.Windows.Forms.ToolStripLabel()
        Me.txtFrecuenciaImpresion = New System.Windows.Forms.ToolStripTextBox()
        Me.lblTituloSegundos = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.CmbSelectorTodos = New System.Windows.Forms.ToolStripButton()
        Me.CmbQuitarSelector = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.XTTPagina2 = New DevExpress.XtraTab.XtraTabPage()
        Me.CmbEliminarItem = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbModificarItem = New DevExpress.XtraEditors.SimpleButton()
        Me.CmbNuevoItem = New DevExpress.XtraEditors.SimpleButton()
        Me.GrpRegistro = New System.Windows.Forms.GroupBox()
        Me.XTTDetalle = New DevExpress.XtraTab.XtraTabControl()
        Me.XTTRegPagina1 = New DevExpress.XtraTab.XtraTabPage()
        Me.TxtBoletaPeso = New DevExpress.XtraEditors.CalcEdit()
        Me.lblPesoBoletaBascula = New DevExpress.XtraEditors.LabelControl()
        Me.LblRegUnidMedCodigo = New DevExpress.XtraEditors.LabelControl()
        Me.LblRegTotalNeto = New DevExpress.XtraEditors.LabelControl()
        Me.LblRegCosto = New DevExpress.XtraEditors.LabelControl()
        Me.LblRegCantidad = New DevExpress.XtraEditors.LabelControl()
        Me.LblRegProdCodigo = New DevExpress.XtraEditors.LabelControl()
        Me.TxtRegUnidMedCodigo = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TxtRegProdCodigo = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TxtRegCantidad = New DevExpress.XtraEditors.CalcEdit()
        Me.TxtRegPrecio = New DevExpress.XtraEditors.CalcEdit()
        Me.TxtRegTotalNeto = New DevExpress.XtraEditors.CalcEdit()
        Me.XTTRegPagina2 = New DevExpress.XtraTab.XtraTabPage()
        Me.LblDescrip2 = New DevExpress.XtraEditors.LabelControl()
        Me.LblRegDescrip1 = New DevExpress.XtraEditors.LabelControl()
        Me.LblRegDesctoMonto = New DevExpress.XtraEditors.LabelControl()
        Me.LblRegTotalBruto = New DevExpress.XtraEditors.LabelControl()
        Me.LblRegImptoMonto = New DevExpress.XtraEditors.LabelControl()
        Me.LblImptoCodigo = New DevExpress.XtraEditors.LabelControl()
        Me.TxtRegProdXFactID = New DevExpress.XtraEditors.TextEdit()
        Me.LblProdXFactID = New DevExpress.XtraEditors.LabelControl()
        Me.TxtRegImptoCodigo = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TxtRegTotalBruto = New DevExpress.XtraEditors.CalcEdit()
        Me.TxtRegDesctoMonto = New DevExpress.XtraEditors.CalcEdit()
        Me.TxtRegImptoMonto = New DevExpress.XtraEditors.CalcEdit()
        Me.TxtRegDescrip1 = New DevExpress.XtraEditors.MemoEdit()
        Me.TxtRegDescrip2 = New DevExpress.XtraEditors.MemoEdit()
        Me.GrdItems = New DevExpress.XtraGrid.GridControl()
        Me.GrdVwItems = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PCTEncabezado = New DevExpress.XtraEditors.PanelControl()
        Me.LblConexionBascula = New DevExpress.XtraEditors.LabelControl()
        Me.lblEstado = New DevExpress.XtraEditors.LabelControl()
        Me.LblCodigoValor = New DevExpress.XtraEditors.LabelControl()
        Me.LblCodigoRotulo = New DevExpress.XtraEditors.LabelControl()
        Me.LblAccion = New DevExpress.XtraEditors.LabelControl()
        Me.XTTDatos = New DevExpress.XtraTab.XtraTabControl()
        Me.XTPEncBasico = New DevExpress.XtraTab.XtraTabPage()
        Me.LblMonedaCodigo = New DevExpress.XtraEditors.LabelControl()
        Me.TxtDescripcion = New DevExpress.XtraEditors.TextEdit()
        Me.LblDescripcion = New DevExpress.XtraEditors.LabelControl()
        Me.TxtFactNum = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LblSdN = New DevExpress.XtraEditors.LabelControl()
        Me.LblFecha = New DevExpress.XtraEditors.LabelControl()
        Me.LblFactNum = New DevExpress.XtraEditors.LabelControl()
        Me.TxtSdNCodigo = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GLEClientes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TxtFecha = New DevExpress.XtraEditors.DateEdit()
        Me.TxtRetencionID = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TxtMonedaCodigo = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn42 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn43 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XTPEncAvanzado = New DevExpress.XtraTab.XtraTabPage()
        Me.TxtNSAG = New DevExpress.XtraEditors.TextEdit()
        Me.TxtNOCExenta = New DevExpress.XtraEditors.TextEdit()
        Me.TxtNConstancia = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtNumeroOrden = New DevExpress.XtraEditors.TextEdit()
        Me.LblNumeroOrden = New DevExpress.XtraEditors.LabelControl()
        Me.LblEmpresaCodigo = New DevExpress.XtraEditors.LabelControl()
        Me.TxtCAI = New DevExpress.XtraEditors.TextEdit()
        Me.LblTipoDoctoID = New DevExpress.XtraEditors.LabelControl()
        Me.LblDFID = New DevExpress.XtraEditors.LabelControl()
        Me.LblCAI = New DevExpress.XtraEditors.LabelControl()
        Me.LblTerminoCodigo = New DevExpress.XtraEditors.LabelControl()
        Me.TxtDFFactID = New DevExpress.XtraEditors.TextEdit()
        Me.LblDFFactID = New DevExpress.XtraEditors.LabelControl()
        Me.TxtTerminoCodigo = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn28 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn29 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TxtDFID = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn30 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn31 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn32 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn33 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn34 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn35 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn36 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn37 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn38 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TxtEmpresaCodigo = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn27 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TxtTiposDoctoID = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn40 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn41 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XTPEncExport = New DevExpress.XtraTab.XtraTabPage()
        Me.memoTxtInfoExtra = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.memoTxtNotificarA = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LblConEmbarque = New DevExpress.XtraEditors.LabelControl()
        Me.LblFechaEmbarque = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtPuertoDescarga = New DevExpress.XtraEditors.TextEdit()
        Me.LblPuertoDescarga = New DevExpress.XtraEditors.LabelControl()
        Me.TxtFDA = New DevExpress.XtraEditors.TextEdit()
        Me.TxtAcuerdo = New DevExpress.XtraEditors.TextEdit()
        Me.TxtPuertoCarga = New DevExpress.XtraEditors.TextEdit()
        Me.LblFDA = New DevExpress.XtraEditors.LabelControl()
        Me.lblAcuerdo = New DevExpress.XtraEditors.LabelControl()
        Me.LblPuertoCarga = New DevExpress.XtraEditors.LabelControl()
        Me.TxtBarco = New DevExpress.XtraEditors.TextEdit()
        Me.LblBarco = New DevExpress.XtraEditors.LabelControl()
        Me.TxtFechaEmbarque = New DevExpress.XtraEditors.DateEdit()
        Me.TxtConocimientoEmbarque = New DevExpress.XtraEditors.TextEdit()
        Me.TxtCambioDolar = New DevExpress.XtraEditors.CalcEdit()
        Me.XTPEncTotales = New DevExpress.XtraTab.XtraTabPage()
        Me.TxtTotalExento = New DevExpress.XtraEditors.CalcEdit()
        Me.LblTotalExento = New DevExpress.XtraEditors.LabelControl()
        Me.LblMontoImpuesto = New DevExpress.XtraEditors.LabelControl()
        Me.LblMontoDescto = New DevExpress.XtraEditors.LabelControl()
        Me.LblTotalNeto = New DevExpress.XtraEditors.LabelControl()
        Me.LblTotalBruto = New DevExpress.XtraEditors.LabelControl()
        Me.TxtTotalNeto = New DevExpress.XtraEditors.CalcEdit()
        Me.TxtTotalBruto = New DevExpress.XtraEditors.CalcEdit()
        Me.TxtDesctoMonto = New DevExpress.XtraEditors.CalcEdit()
        Me.TxtImptoMonto = New DevExpress.XtraEditors.CalcEdit()
        Me.TlSNotas = New System.Windows.Forms.ToolStrip()
        Me.CmbGrabarNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CmbGrabarSalir = New System.Windows.Forms.ToolStripButton()
        Me.CmbRegresarConsulta = New System.Windows.Forms.ToolStripButton()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        CmbRegCancelar = New DevExpress.XtraEditors.SimpleButton()
        CmbRegActualizar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.XTTEmpaginacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTTEmpaginacion.SuspendLayout()
        Me.XTTPagina1.SuspendLayout()
        CType(Me.GrdConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdConsultaView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSelector, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenu.SuspendLayout()
        Me.XTTPagina2.SuspendLayout()
        Me.GrpRegistro.SuspendLayout()
        CType(Me.XTTDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTTDetalle.SuspendLayout()
        Me.XTTRegPagina1.SuspendLayout()
        CType(Me.TxtBoletaPeso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtRegUnidMedCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtRegProdCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtRegCantidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtRegPrecio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtRegTotalNeto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTTRegPagina2.SuspendLayout()
        CType(Me.TxtRegProdXFactID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtRegImptoCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtRegTotalBruto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtRegDesctoMonto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtRegImptoMonto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtRegDescrip1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtRegDescrip2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdVwItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCTEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PCTEncabezado.SuspendLayout()
        CType(Me.XTTDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTTDatos.SuspendLayout()
        Me.XTPEncBasico.SuspendLayout()
        CType(Me.TxtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFactNum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSdNCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GLEClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtRetencionID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMonedaCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTPEncAvanzado.SuspendLayout()
        CType(Me.TxtNSAG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNOCExenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNConstancia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNumeroOrden.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCAI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDFFactID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTerminoCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDFID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtEmpresaCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTiposDoctoID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTPEncExport.SuspendLayout()
        CType(Me.memoTxtInfoExtra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memoTxtNotificarA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPuertoDescarga.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFDA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtAcuerdo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPuertoCarga.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtBarco.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFechaEmbarque.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFechaEmbarque.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtConocimientoEmbarque.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCambioDolar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTPEncTotales.SuspendLayout()
        CType(Me.TxtTotalExento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTotalNeto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTotalBruto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDesctoMonto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtImptoMonto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TlSNotas.SuspendLayout()
        Me.SuspendLayout()
        '
        'CmbRegCancelar
        '
        CmbRegCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CmbRegCancelar.Image = Global.ConsolaProgramas.My.Resources.Resources.arrow_undo
        CmbRegCancelar.Location = New System.Drawing.Point(697, 76)
        CmbRegCancelar.Name = "CmbRegCancelar"
        CmbRegCancelar.Size = New System.Drawing.Size(50, 50)
        CmbRegCancelar.TabIndex = 15
        CmbRegCancelar.ToolTip = "Cancelar cambios"
        AddHandler CmbRegCancelar.Click, AddressOf Me.CmbRegCancelar_Click
        '
        'CmbRegActualizar
        '
        CmbRegActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CmbRegActualizar.Image = Global.ConsolaProgramas.My.Resources.Resources.database_save
        CmbRegActualizar.Location = New System.Drawing.Point(697, 20)
        CmbRegActualizar.Name = "CmbRegActualizar"
        CmbRegActualizar.Size = New System.Drawing.Size(50, 50)
        CmbRegActualizar.TabIndex = 14
        CmbRegActualizar.ToolTip = "Actualizar cambios"
        AddHandler CmbRegActualizar.Click, AddressOf Me.CmbRegActualizar_Click
        '
        'XTTEmpaginacion
        '
        Me.XTTEmpaginacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XTTEmpaginacion.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.XTTEmpaginacion.Location = New System.Drawing.Point(12, 12)
        Me.XTTEmpaginacion.Name = "XTTEmpaginacion"
        Me.XTTEmpaginacion.SelectedTabPage = Me.XTTPagina1
        Me.XTTEmpaginacion.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[False]
        Me.XTTEmpaginacion.Size = New System.Drawing.Size(788, 578)
        Me.XTTEmpaginacion.TabIndex = 11
        Me.XTTEmpaginacion.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XTTPagina1, Me.XTTPagina2})
        '
        'XTTPagina1
        '
        Me.XTTPagina1.Controls.Add(Me.GrdConsulta)
        Me.XTTPagina1.Controls.Add(Me.tsMenu)
        Me.XTTPagina1.Name = "XTTPagina1"
        Me.XTTPagina1.Size = New System.Drawing.Size(782, 572)
        '
        'GrdConsulta
        '
        Me.GrdConsulta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdConsulta.Enabled = False
        Me.GrdConsulta.Location = New System.Drawing.Point(0, 56)
        Me.GrdConsulta.MainView = Me.GrdConsultaView
        Me.GrdConsulta.Name = "GrdConsulta"
        Me.GrdConsulta.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.chkSelector})
        Me.GrdConsulta.Size = New System.Drawing.Size(782, 484)
        Me.GrdConsulta.TabIndex = 11
        Me.GrdConsulta.Tag = "0"
        Me.GrdConsulta.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GrdConsultaView})
        '
        'GrdConsultaView
        '
        Me.GrdConsultaView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSelector, Me.colDFFactID, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn44, Me.GridColumn45})
        Me.GrdConsultaView.GridControl = Me.GrdConsulta
        Me.GrdConsultaView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "ProdCodigo", Me.GridColumn1, "###,###", 0)})
        Me.GrdConsultaView.Name = "GrdConsultaView"
        Me.GrdConsultaView.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GrdConsultaView.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GrdConsultaView.OptionsView.ShowAutoFilterRow = True
        Me.GrdConsultaView.OptionsView.ShowFooter = True
        Me.GrdConsultaView.OptionsView.ShowGroupPanel = False
        '
        'colSelector
        '
        Me.colSelector.Caption = "Selector"
        Me.colSelector.ColumnEdit = Me.chkSelector
        Me.colSelector.FieldName = "Seleccionar"
        Me.colSelector.Name = "colSelector"
        Me.colSelector.Visible = True
        Me.colSelector.VisibleIndex = 0
        '
        'chkSelector
        '
        Me.chkSelector.AutoHeight = False
        Me.chkSelector.Caption = "Check"
        Me.chkSelector.Name = "chkSelector"
        '
        'colDFFactID
        '
        Me.colDFFactID.Caption = "DFFactID"
        Me.colDFFactID.FieldName = "DFFactID"
        Me.colDFFactID.Name = "colDFFactID"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Factura"
        Me.GridColumn1.FieldName = "FactNum"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 133
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Fecha"
        Me.GridColumn2.FieldName = "Fecha"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        Me.GridColumn2.Width = 95
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Cliente"
        Me.GridColumn3.FieldName = "NombreCliente"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        Me.GridColumn3.Width = 145
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Total Neto"
        Me.GridColumn4.DisplayFormat.FormatString = "###,###,###.##"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "TotalNeto"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 4
        Me.GridColumn4.Width = 145
        '
        'GridColumn44
        '
        Me.GridColumn44.Caption = "Creado por"
        Me.GridColumn44.FieldName = "CreadoPor"
        Me.GridColumn44.Name = "GridColumn44"
        Me.GridColumn44.OptionsColumn.AllowEdit = False
        Me.GridColumn44.OptionsColumn.ReadOnly = True
        Me.GridColumn44.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn44.Visible = True
        Me.GridColumn44.VisibleIndex = 5
        Me.GridColumn44.Width = 150
        '
        'GridColumn45
        '
        Me.GridColumn45.Caption = "Estado"
        Me.GridColumn45.FieldName = "EstadoDescripcion"
        Me.GridColumn45.Name = "GridColumn45"
        Me.GridColumn45.OptionsColumn.AllowEdit = False
        Me.GridColumn45.OptionsColumn.ReadOnly = True
        Me.GridColumn45.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn45.Visible = True
        Me.GridColumn45.VisibleIndex = 6
        '
        'tsMenu
        '
        Me.tsMenu.Enabled = False
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CmbNuevo, Me.ToolStripSeparator1, Me.CmbEditar, Me.CmbActualizarConsulta, Me.ToolStripSeparator3, Me.CmbImprimir, Me.CmbAnular, Me.ToolStripSeparator4, Me.lblTipoProcesoImpresion, Me.CmbOpcImpresion, Me.lblFrecuenciaImpresion, Me.txtFrecuenciaImpresion, Me.lblTituloSegundos, Me.ToolStripSeparator6, Me.CmbSelectorTodos, Me.CmbQuitarSelector, Me.ToolStripSeparator5})
        Me.tsMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(782, 53)
        Me.tsMenu.TabIndex = 10
        Me.tsMenu.Tag = "0"
        '
        'CmbNuevo
        '
        Me.CmbNuevo.AutoSize = False
        Me.CmbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmbNuevo.Enabled = False
        Me.CmbNuevo.Image = Global.ConsolaProgramas.My.Resources.Resources.page
        Me.CmbNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmbNuevo.Name = "CmbNuevo"
        Me.CmbNuevo.Size = New System.Drawing.Size(50, 50)
        Me.CmbNuevo.Tag = "2"
        Me.CmbNuevo.Text = "Nueva factura"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 53)
        '
        'CmbEditar
        '
        Me.CmbEditar.AutoSize = False
        Me.CmbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmbEditar.Enabled = False
        Me.CmbEditar.Image = Global.ConsolaProgramas.My.Resources.Resources.page_edit
        Me.CmbEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmbEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmbEditar.Name = "CmbEditar"
        Me.CmbEditar.Size = New System.Drawing.Size(50, 50)
        Me.CmbEditar.Tag = "3"
        Me.CmbEditar.Text = "Editar factura"
        '
        'CmbActualizarConsulta
        '
        Me.CmbActualizarConsulta.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.CmbActualizarConsulta.AutoSize = False
        Me.CmbActualizarConsulta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmbActualizarConsulta.Enabled = False
        Me.CmbActualizarConsulta.Image = Global.ConsolaProgramas.My.Resources.Resources.arrow_refresh1
        Me.CmbActualizarConsulta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmbActualizarConsulta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmbActualizarConsulta.Name = "CmbActualizarConsulta"
        Me.CmbActualizarConsulta.Size = New System.Drawing.Size(50, 50)
        Me.CmbActualizarConsulta.Tag = "1"
        Me.CmbActualizarConsulta.Text = "Actualizar Consulta"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 53)
        '
        'CmbImprimir
        '
        Me.CmbImprimir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.CmbImprimir.AutoSize = False
        Me.CmbImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmbImprimir.Enabled = False
        Me.CmbImprimir.Image = Global.ConsolaProgramas.My.Resources.Resources.printer
        Me.CmbImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmbImprimir.Name = "CmbImprimir"
        Me.CmbImprimir.Size = New System.Drawing.Size(50, 50)
        Me.CmbImprimir.Tag = "6"
        Me.CmbImprimir.Text = "Imprimir factura"
        '
        'CmbAnular
        '
        Me.CmbAnular.AutoSize = False
        Me.CmbAnular.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmbAnular.Image = Global.ConsolaProgramas.My.Resources.Resources.layout_delete
        Me.CmbAnular.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmbAnular.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmbAnular.Name = "CmbAnular"
        Me.CmbAnular.Size = New System.Drawing.Size(50, 50)
        Me.CmbAnular.Tag = "8"
        Me.CmbAnular.Text = "Anular factura"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 53)
        '
        'lblTipoProcesoImpresion
        '
        Me.lblTipoProcesoImpresion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblTipoProcesoImpresion.Name = "lblTipoProcesoImpresion"
        Me.lblTipoProcesoImpresion.Size = New System.Drawing.Size(116, 50)
        Me.lblTipoProcesoImpresion.Text = "Proceso Impresión:"
        '
        'CmbOpcImpresion
        '
        Me.CmbOpcImpresion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbOpcImpresion.DropDownWidth = 150
        Me.CmbOpcImpresion.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CmbOpcImpresion.IntegralHeight = False
        Me.CmbOpcImpresion.Items.AddRange(New Object() {"Una fila", "Multiples filas"})
        Me.CmbOpcImpresion.Name = "CmbOpcImpresion"
        Me.CmbOpcImpresion.Size = New System.Drawing.Size(150, 53)
        '
        'lblFrecuenciaImpresion
        '
        Me.lblFrecuenciaImpresion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblFrecuenciaImpresion.Name = "lblFrecuenciaImpresion"
        Me.lblFrecuenciaImpresion.Size = New System.Drawing.Size(52, 50)
        Me.lblFrecuenciaImpresion.Text = "Tiempo:"
        '
        'txtFrecuenciaImpresion
        '
        Me.txtFrecuenciaImpresion.MaxLength = 1
        Me.txtFrecuenciaImpresion.Name = "txtFrecuenciaImpresion"
        Me.txtFrecuenciaImpresion.Size = New System.Drawing.Size(40, 53)
        Me.txtFrecuenciaImpresion.Text = "1"
        '
        'lblTituloSegundos
        '
        Me.lblTituloSegundos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblTituloSegundos.Name = "lblTituloSegundos"
        Me.lblTituloSegundos.Size = New System.Drawing.Size(31, 50)
        Me.lblTituloSegundos.Text = "Seg."
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 53)
        '
        'CmbSelectorTodos
        '
        Me.CmbSelectorTodos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmbSelectorTodos.Enabled = False
        Me.CmbSelectorTodos.Image = Global.ConsolaProgramas.My.Resources.Resources.wishlist_add
        Me.CmbSelectorTodos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmbSelectorTodos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmbSelectorTodos.Name = "CmbSelectorTodos"
        Me.CmbSelectorTodos.Size = New System.Drawing.Size(36, 50)
        Me.CmbSelectorTodos.Text = "Seleccionar Todos"
        '
        'CmbQuitarSelector
        '
        Me.CmbQuitarSelector.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmbQuitarSelector.Enabled = False
        Me.CmbQuitarSelector.Image = Global.ConsolaProgramas.My.Resources.Resources.application_side_boxes
        Me.CmbQuitarSelector.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmbQuitarSelector.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmbQuitarSelector.Name = "CmbQuitarSelector"
        Me.CmbQuitarSelector.Size = New System.Drawing.Size(36, 50)
        Me.CmbQuitarSelector.Text = "Quitar Todos"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 53)
        '
        'XTTPagina2
        '
        Me.XTTPagina2.Controls.Add(Me.CmbEliminarItem)
        Me.XTTPagina2.Controls.Add(Me.cmbModificarItem)
        Me.XTTPagina2.Controls.Add(Me.CmbNuevoItem)
        Me.XTTPagina2.Controls.Add(Me.GrpRegistro)
        Me.XTTPagina2.Controls.Add(Me.GrdItems)
        Me.XTTPagina2.Controls.Add(Me.PCTEncabezado)
        Me.XTTPagina2.Controls.Add(Me.XTTDatos)
        Me.XTTPagina2.Controls.Add(Me.TlSNotas)
        Me.XTTPagina2.Name = "XTTPagina2"
        Me.XTTPagina2.Size = New System.Drawing.Size(782, 572)
        Me.XTTPagina2.Text = "XtraTabPage2"
        '
        'CmbEliminarItem
        '
        Me.CmbEliminarItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbEliminarItem.Enabled = False
        Me.CmbEliminarItem.Image = Global.ConsolaProgramas.My.Resources.Resources.delete1
        Me.CmbEliminarItem.Location = New System.Drawing.Point(701, 301)
        Me.CmbEliminarItem.Name = "CmbEliminarItem"
        Me.CmbEliminarItem.Size = New System.Drawing.Size(50, 48)
        Me.CmbEliminarItem.TabIndex = 7
        Me.CmbEliminarItem.ToolTip = "Eliminar item"
        '
        'cmbModificarItem
        '
        Me.cmbModificarItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbModificarItem.Enabled = False
        Me.cmbModificarItem.Image = Global.ConsolaProgramas.My.Resources.Resources.script_edit
        Me.cmbModificarItem.Location = New System.Drawing.Point(701, 353)
        Me.cmbModificarItem.Name = "cmbModificarItem"
        Me.cmbModificarItem.Size = New System.Drawing.Size(50, 50)
        Me.cmbModificarItem.TabIndex = 8
        Me.cmbModificarItem.ToolTip = "Modificar item"
        '
        'CmbNuevoItem
        '
        Me.CmbNuevoItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbNuevoItem.Enabled = False
        Me.CmbNuevoItem.Image = Global.ConsolaProgramas.My.Resources.Resources.add
        Me.CmbNuevoItem.Location = New System.Drawing.Point(701, 252)
        Me.CmbNuevoItem.Name = "CmbNuevoItem"
        Me.CmbNuevoItem.Size = New System.Drawing.Size(50, 43)
        Me.CmbNuevoItem.TabIndex = 6
        Me.CmbNuevoItem.ToolTip = "Agregar item"
        '
        'GrpRegistro
        '
        Me.GrpRegistro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpRegistro.Controls.Add(CmbRegCancelar)
        Me.GrpRegistro.Controls.Add(CmbRegActualizar)
        Me.GrpRegistro.Controls.Add(Me.XTTDetalle)
        Me.GrpRegistro.Location = New System.Drawing.Point(4, 401)
        Me.GrpRegistro.Name = "GrpRegistro"
        Me.GrpRegistro.Size = New System.Drawing.Size(755, 168)
        Me.GrpRegistro.TabIndex = 16
        Me.GrpRegistro.TabStop = False
        Me.GrpRegistro.Text = "Registro"
        Me.GrpRegistro.Visible = False
        '
        'XTTDetalle
        '
        Me.XTTDetalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XTTDetalle.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Right
        Me.XTTDetalle.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal
        Me.XTTDetalle.Location = New System.Drawing.Point(8, 20)
        Me.XTTDetalle.Name = "XTTDetalle"
        Me.XTTDetalle.SelectedTabPage = Me.XTTRegPagina1
        Me.XTTDetalle.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[True]
        Me.XTTDetalle.Size = New System.Drawing.Size(683, 142)
        Me.XTTDetalle.TabIndex = 0
        Me.XTTDetalle.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XTTRegPagina1, Me.XTTRegPagina2})
        '
        'XTTRegPagina1
        '
        Me.XTTRegPagina1.Controls.Add(Me.TxtBoletaPeso)
        Me.XTTRegPagina1.Controls.Add(Me.lblPesoBoletaBascula)
        Me.XTTRegPagina1.Controls.Add(Me.LblRegUnidMedCodigo)
        Me.XTTRegPagina1.Controls.Add(Me.LblRegTotalNeto)
        Me.XTTRegPagina1.Controls.Add(Me.LblRegCosto)
        Me.XTTRegPagina1.Controls.Add(Me.LblRegCantidad)
        Me.XTTRegPagina1.Controls.Add(Me.LblRegProdCodigo)
        Me.XTTRegPagina1.Controls.Add(Me.TxtRegUnidMedCodigo)
        Me.XTTRegPagina1.Controls.Add(Me.TxtRegProdCodigo)
        Me.XTTRegPagina1.Controls.Add(Me.TxtRegCantidad)
        Me.XTTRegPagina1.Controls.Add(Me.TxtRegPrecio)
        Me.XTTRegPagina1.Controls.Add(Me.TxtRegTotalNeto)
        Me.XTTRegPagina1.Name = "XTTRegPagina1"
        Me.XTTRegPagina1.Size = New System.Drawing.Size(595, 136)
        Me.XTTRegPagina1.Text = "Detalle"
        '
        'TxtBoletaPeso
        '
        Me.TxtBoletaPeso.Enabled = False
        Me.TxtBoletaPeso.Location = New System.Drawing.Point(113, 74)
        Me.TxtBoletaPeso.Name = "TxtBoletaPeso"
        Me.TxtBoletaPeso.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtBoletaPeso.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.TxtBoletaPeso.Size = New System.Drawing.Size(237, 20)
        Me.TxtBoletaPeso.TabIndex = 15
        Me.TxtBoletaPeso.Visible = False
        '
        'lblPesoBoletaBascula
        '
        Me.lblPesoBoletaBascula.Location = New System.Drawing.Point(16, 77)
        Me.lblPesoBoletaBascula.Name = "lblPesoBoletaBascula"
        Me.lblPesoBoletaBascula.Size = New System.Drawing.Size(71, 13)
        Me.lblPesoBoletaBascula.TabIndex = 14
        Me.lblPesoBoletaBascula.Text = "Boleta de Peso"
        Me.lblPesoBoletaBascula.Visible = False
        '
        'LblRegUnidMedCodigo
        '
        Me.LblRegUnidMedCodigo.Location = New System.Drawing.Point(16, 44)
        Me.LblRegUnidMedCodigo.Name = "LblRegUnidMedCodigo"
        Me.LblRegUnidMedCodigo.Size = New System.Drawing.Size(85, 13)
        Me.LblRegUnidMedCodigo.TabIndex = 7
        Me.LblRegUnidMedCodigo.Text = "Unidad de Medida"
        '
        'LblRegTotalNeto
        '
        Me.LblRegTotalNeto.Location = New System.Drawing.Point(370, 75)
        Me.LblRegTotalNeto.Name = "LblRegTotalNeto"
        Me.LblRegTotalNeto.Size = New System.Drawing.Size(50, 13)
        Me.LblRegTotalNeto.TabIndex = 5
        Me.LblRegTotalNeto.Text = "Total Neto"
        '
        'LblRegCosto
        '
        Me.LblRegCosto.Location = New System.Drawing.Point(383, 45)
        Me.LblRegCosto.Name = "LblRegCosto"
        Me.LblRegCosto.Size = New System.Drawing.Size(29, 13)
        Me.LblRegCosto.TabIndex = 5
        Me.LblRegCosto.Text = "Precio"
        '
        'LblRegCantidad
        '
        Me.LblRegCantidad.Location = New System.Drawing.Point(369, 16)
        Me.LblRegCantidad.Name = "LblRegCantidad"
        Me.LblRegCantidad.Size = New System.Drawing.Size(43, 13)
        Me.LblRegCantidad.TabIndex = 5
        Me.LblRegCantidad.Text = "Cantidad"
        '
        'LblRegProdCodigo
        '
        Me.LblRegProdCodigo.Location = New System.Drawing.Point(16, 14)
        Me.LblRegProdCodigo.Name = "LblRegProdCodigo"
        Me.LblRegProdCodigo.Size = New System.Drawing.Size(43, 13)
        Me.LblRegProdCodigo.TabIndex = 5
        Me.LblRegProdCodigo.Text = "Producto"
        '
        'TxtRegUnidMedCodigo
        '
        Me.TxtRegUnidMedCodigo.Location = New System.Drawing.Point(113, 44)
        Me.TxtRegUnidMedCodigo.Name = "TxtRegUnidMedCodigo"
        Me.TxtRegUnidMedCodigo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtRegUnidMedCodigo.Properties.NullText = ""
        Me.TxtRegUnidMedCodigo.Properties.View = Me.GridLookUpEdit1View
        Me.TxtRegUnidMedCodigo.Size = New System.Drawing.Size(237, 20)
        Me.TxtRegUnidMedCodigo.TabIndex = 10
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn21, Me.GridColumn22})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GridLookUpEdit1View.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "Código"
        Me.GridColumn21.FieldName = "UnidMedCodigo"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.OptionsColumn.AllowEdit = False
        Me.GridColumn21.OptionsColumn.ReadOnly = True
        Me.GridColumn21.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 0
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "Descripción"
        Me.GridColumn22.FieldName = "Descripcion"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.OptionsColumn.AllowEdit = False
        Me.GridColumn22.OptionsColumn.ReadOnly = True
        Me.GridColumn22.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 1
        '
        'TxtRegProdCodigo
        '
        Me.TxtRegProdCodigo.Location = New System.Drawing.Point(113, 14)
        Me.TxtRegProdCodigo.Name = "TxtRegProdCodigo"
        Me.TxtRegProdCodigo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtRegProdCodigo.Properties.NullText = ""
        Me.TxtRegProdCodigo.Properties.View = Me.GridView6
        Me.TxtRegProdCodigo.Size = New System.Drawing.Size(237, 20)
        Me.TxtRegProdCodigo.TabIndex = 9
        '
        'GridView6
        '
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17})
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GridView6.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowAutoFilterRow = True
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Código"
        Me.GridColumn14.FieldName = "ProdCodigo"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.AllowEdit = False
        Me.GridColumn14.OptionsColumn.ReadOnly = True
        Me.GridColumn14.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 0
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Descripción"
        Me.GridColumn15.FieldName = "Descripcion"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.AllowEdit = False
        Me.GridColumn15.OptionsColumn.ReadOnly = True
        Me.GridColumn15.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 1
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Unidad de Medida"
        Me.GridColumn16.FieldName = "UnidMed"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.OptionsColumn.AllowEdit = False
        Me.GridColumn16.OptionsColumn.ReadOnly = True
        Me.GridColumn16.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 2
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Precio"
        Me.GridColumn17.DisplayFormat.FormatString = "###,###,###.##"
        Me.GridColumn17.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn17.FieldName = "Precio"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.OptionsColumn.AllowEdit = False
        Me.GridColumn17.OptionsColumn.ReadOnly = True
        Me.GridColumn17.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 3
        '
        'TxtRegCantidad
        '
        Me.TxtRegCantidad.Location = New System.Drawing.Point(429, 16)
        Me.TxtRegCantidad.Name = "TxtRegCantidad"
        Me.TxtRegCantidad.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtRegCantidad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.TxtRegCantidad.Size = New System.Drawing.Size(151, 20)
        Me.TxtRegCantidad.TabIndex = 11
        '
        'TxtRegPrecio
        '
        Me.TxtRegPrecio.Location = New System.Drawing.Point(429, 43)
        Me.TxtRegPrecio.Name = "TxtRegPrecio"
        Me.TxtRegPrecio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtRegPrecio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.TxtRegPrecio.Size = New System.Drawing.Size(151, 20)
        Me.TxtRegPrecio.TabIndex = 12
        '
        'TxtRegTotalNeto
        '
        Me.TxtRegTotalNeto.Location = New System.Drawing.Point(429, 75)
        Me.TxtRegTotalNeto.Name = "TxtRegTotalNeto"
        Me.TxtRegTotalNeto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtRegTotalNeto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.TxtRegTotalNeto.Properties.ReadOnly = True
        Me.TxtRegTotalNeto.Size = New System.Drawing.Size(151, 20)
        Me.TxtRegTotalNeto.TabIndex = 13
        '
        'XTTRegPagina2
        '
        Me.XTTRegPagina2.Controls.Add(Me.LblDescrip2)
        Me.XTTRegPagina2.Controls.Add(Me.LblRegDescrip1)
        Me.XTTRegPagina2.Controls.Add(Me.LblRegDesctoMonto)
        Me.XTTRegPagina2.Controls.Add(Me.LblRegTotalBruto)
        Me.XTTRegPagina2.Controls.Add(Me.LblRegImptoMonto)
        Me.XTTRegPagina2.Controls.Add(Me.LblImptoCodigo)
        Me.XTTRegPagina2.Controls.Add(Me.TxtRegProdXFactID)
        Me.XTTRegPagina2.Controls.Add(Me.LblProdXFactID)
        Me.XTTRegPagina2.Controls.Add(Me.TxtRegImptoCodigo)
        Me.XTTRegPagina2.Controls.Add(Me.TxtRegTotalBruto)
        Me.XTTRegPagina2.Controls.Add(Me.TxtRegDesctoMonto)
        Me.XTTRegPagina2.Controls.Add(Me.TxtRegImptoMonto)
        Me.XTTRegPagina2.Controls.Add(Me.TxtRegDescrip1)
        Me.XTTRegPagina2.Controls.Add(Me.TxtRegDescrip2)
        Me.XTTRegPagina2.Name = "XTTRegPagina2"
        Me.XTTRegPagina2.Size = New System.Drawing.Size(595, 136)
        Me.XTTRegPagina2.Text = "Generalidades"
        '
        'LblDescrip2
        '
        Me.LblDescrip2.Location = New System.Drawing.Point(370, 88)
        Me.LblDescrip2.Name = "LblDescrip2"
        Me.LblDescrip2.Size = New System.Drawing.Size(23, 13)
        Me.LblDescrip2.TabIndex = 17
        Me.LblDescrip2.Text = "Nota"
        '
        'LblRegDescrip1
        '
        Me.LblRegDescrip1.Location = New System.Drawing.Point(8, 57)
        Me.LblRegDescrip1.Name = "LblRegDescrip1"
        Me.LblRegDescrip1.Size = New System.Drawing.Size(54, 13)
        Me.LblRegDescrip1.TabIndex = 17
        Me.LblRegDescrip1.Text = "Descripción"
        '
        'LblRegDesctoMonto
        '
        Me.LblRegDesctoMonto.Location = New System.Drawing.Point(327, 33)
        Me.LblRegDesctoMonto.Name = "LblRegDesctoMonto"
        Me.LblRegDesctoMonto.Size = New System.Drawing.Size(66, 13)
        Me.LblRegDesctoMonto.TabIndex = 15
        Me.LblRegDesctoMonto.Text = "Descto Monto"
        '
        'LblRegTotalBruto
        '
        Me.LblRegTotalBruto.Location = New System.Drawing.Point(340, 10)
        Me.LblRegTotalBruto.Name = "LblRegTotalBruto"
        Me.LblRegTotalBruto.Size = New System.Drawing.Size(53, 13)
        Me.LblRegTotalBruto.TabIndex = 13
        Me.LblRegTotalBruto.Text = "Total Bruto"
        '
        'LblRegImptoMonto
        '
        Me.LblRegImptoMonto.Location = New System.Drawing.Point(317, 58)
        Me.LblRegImptoMonto.Name = "LblRegImptoMonto"
        Me.LblRegImptoMonto.Size = New System.Drawing.Size(78, 13)
        Me.LblRegImptoMonto.TabIndex = 11
        Me.LblRegImptoMonto.Text = "Impuesto Monto"
        '
        'LblImptoCodigo
        '
        Me.LblImptoCodigo.Location = New System.Drawing.Point(8, 33)
        Me.LblImptoCodigo.Name = "LblImptoCodigo"
        Me.LblImptoCodigo.Size = New System.Drawing.Size(45, 13)
        Me.LblImptoCodigo.TabIndex = 9
        Me.LblImptoCodigo.Text = "Impuesto"
        '
        'TxtRegProdXFactID
        '
        Me.TxtRegProdXFactID.Location = New System.Drawing.Point(68, 10)
        Me.TxtRegProdXFactID.Name = "TxtRegProdXFactID"
        Me.TxtRegProdXFactID.Properties.ReadOnly = True
        Me.TxtRegProdXFactID.Size = New System.Drawing.Size(210, 20)
        Me.TxtRegProdXFactID.TabIndex = 16
        '
        'LblProdXFactID
        '
        Me.LblProdXFactID.Location = New System.Drawing.Point(8, 10)
        Me.LblProdXFactID.Name = "LblProdXFactID"
        Me.LblProdXFactID.Size = New System.Drawing.Size(48, 13)
        Me.LblProdXFactID.TabIndex = 7
        Me.LblProdXFactID.Text = "ID interno"
        '
        'TxtRegImptoCodigo
        '
        Me.TxtRegImptoCodigo.Location = New System.Drawing.Point(68, 33)
        Me.TxtRegImptoCodigo.Name = "TxtRegImptoCodigo"
        Me.TxtRegImptoCodigo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtRegImptoCodigo.Properties.NullText = ""
        Me.TxtRegImptoCodigo.Properties.View = Me.GridView7
        Me.TxtRegImptoCodigo.Size = New System.Drawing.Size(210, 20)
        Me.TxtRegImptoCodigo.TabIndex = 16
        '
        'GridView7
        '
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn23, Me.GridColumn24, Me.GridColumn25})
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GridView7.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridView7.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView7.OptionsView.ShowAutoFilterRow = True
        Me.GridView7.OptionsView.ShowGroupPanel = False
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "Código"
        Me.GridColumn23.FieldName = "TaxCat"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.OptionsColumn.AllowEdit = False
        Me.GridColumn23.OptionsColumn.ReadOnly = True
        Me.GridColumn23.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn23.Visible = True
        Me.GridColumn23.VisibleIndex = 0
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "Descripción"
        Me.GridColumn24.FieldName = "Description"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.OptionsColumn.AllowEdit = False
        Me.GridColumn24.OptionsColumn.ReadOnly = True
        Me.GridColumn24.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn24.Visible = True
        Me.GridColumn24.VisibleIndex = 1
        '
        'GridColumn25
        '
        Me.GridColumn25.Caption = "Porcentaje"
        Me.GridColumn25.FieldName = "Percentage"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.OptionsColumn.AllowEdit = False
        Me.GridColumn25.OptionsColumn.ReadOnly = True
        Me.GridColumn25.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn25.Visible = True
        Me.GridColumn25.VisibleIndex = 2
        '
        'TxtRegTotalBruto
        '
        Me.TxtRegTotalBruto.Location = New System.Drawing.Point(399, 7)
        Me.TxtRegTotalBruto.Name = "TxtRegTotalBruto"
        Me.TxtRegTotalBruto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtRegTotalBruto.Properties.Mask.EditMask = "n"
        Me.TxtRegTotalBruto.Properties.ReadOnly = True
        Me.TxtRegTotalBruto.Size = New System.Drawing.Size(193, 20)
        Me.TxtRegTotalBruto.TabIndex = 14
        '
        'TxtRegDesctoMonto
        '
        Me.TxtRegDesctoMonto.Location = New System.Drawing.Point(399, 30)
        Me.TxtRegDesctoMonto.Name = "TxtRegDesctoMonto"
        Me.TxtRegDesctoMonto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtRegDesctoMonto.Properties.Mask.EditMask = "n"
        Me.TxtRegDesctoMonto.Size = New System.Drawing.Size(193, 20)
        Me.TxtRegDesctoMonto.TabIndex = 19
        '
        'TxtRegImptoMonto
        '
        Me.TxtRegImptoMonto.Location = New System.Drawing.Point(399, 57)
        Me.TxtRegImptoMonto.Name = "TxtRegImptoMonto"
        Me.TxtRegImptoMonto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtRegImptoMonto.Properties.Mask.EditMask = "n"
        Me.TxtRegImptoMonto.Properties.ReadOnly = True
        Me.TxtRegImptoMonto.Size = New System.Drawing.Size(193, 20)
        Me.TxtRegImptoMonto.TabIndex = 12
        '
        'TxtRegDescrip1
        '
        Me.TxtRegDescrip1.Location = New System.Drawing.Point(68, 57)
        Me.TxtRegDescrip1.Name = "TxtRegDescrip1"
        Me.TxtRegDescrip1.Properties.MaxLength = 250
        Me.TxtRegDescrip1.Size = New System.Drawing.Size(210, 76)
        Me.TxtRegDescrip1.TabIndex = 17
        Me.TxtRegDescrip1.UseOptimizedRendering = True
        '
        'TxtRegDescrip2
        '
        Me.TxtRegDescrip2.Location = New System.Drawing.Point(399, 85)
        Me.TxtRegDescrip2.Name = "TxtRegDescrip2"
        Me.TxtRegDescrip2.Properties.MaxLength = 250
        Me.TxtRegDescrip2.Size = New System.Drawing.Size(193, 48)
        Me.TxtRegDescrip2.TabIndex = 18
        Me.TxtRegDescrip2.UseOptimizedRendering = True
        '
        'GrdItems
        '
        Me.GrdItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        GridLevelNode1.RelationName = "Level1"
        GridLevelNode2.RelationName = "Level2"
        Me.GrdItems.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1, GridLevelNode2})
        Me.GrdItems.Location = New System.Drawing.Point(4, 252)
        Me.GrdItems.MainView = Me.GrdVwItems
        Me.GrdItems.Name = "GrdItems"
        Me.GrdItems.Size = New System.Drawing.Size(691, 303)
        Me.GrdItems.TabIndex = 5
        Me.GrdItems.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GrdVwItems})
        '
        'GrdVwItems
        '
        Me.GrdVwItems.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn12, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11})
        Me.GrdVwItems.GridControl = Me.GrdItems
        Me.GrdVwItems.Name = "GrdVwItems"
        Me.GrdVwItems.OptionsView.ShowGroupPanel = False
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "ProdXFactID"
        Me.GridColumn12.FieldName = "ProdXFactID"
        Me.GridColumn12.Name = "GridColumn12"
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Producto"
        Me.GridColumn7.FieldName = "ProdCodigo"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 0
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Unidad de medida"
        Me.GridColumn8.FieldName = "UnidMedCodigo"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 1
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Precio"
        Me.GridColumn9.DisplayFormat.FormatString = "###,###,###.####"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn9.FieldName = "Precio"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 2
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Cantidad"
        Me.GridColumn10.DisplayFormat.FormatString = "###,###,###.##"
        Me.GridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn10.FieldName = "Cantidad"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 3
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Total Neto"
        Me.GridColumn11.DisplayFormat.FormatString = "###,###,###.##"
        Me.GridColumn11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn11.FieldName = "TotalNeto"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 4
        '
        'PCTEncabezado
        '
        Me.PCTEncabezado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PCTEncabezado.Controls.Add(Me.LblConexionBascula)
        Me.PCTEncabezado.Controls.Add(Me.lblEstado)
        Me.PCTEncabezado.Controls.Add(Me.LblCodigoValor)
        Me.PCTEncabezado.Controls.Add(Me.LblCodigoRotulo)
        Me.PCTEncabezado.Controls.Add(Me.LblAccion)
        Me.PCTEncabezado.Location = New System.Drawing.Point(4, 57)
        Me.PCTEncabezado.Name = "PCTEncabezado"
        Me.PCTEncabezado.Size = New System.Drawing.Size(770, 28)
        Me.PCTEncabezado.TabIndex = 13
        '
        'LblConexionBascula
        '
        Me.LblConexionBascula.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.LblConexionBascula.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LblConexionBascula.Location = New System.Drawing.Point(381, 8)
        Me.LblConexionBascula.Name = "LblConexionBascula"
        Me.LblConexionBascula.Size = New System.Drawing.Size(9, 13)
        Me.LblConexionBascula.TabIndex = 27
        Me.LblConexionBascula.Text = "..."
        '
        'lblEstado
        '
        Me.lblEstado.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblEstado.Location = New System.Drawing.Point(686, 5)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(61, 13)
        Me.lblEstado.TabIndex = 4
        Me.lblEstado.Text = "En proceso"
        '
        'LblCodigoValor
        '
        Me.LblCodigoValor.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!, System.Drawing.FontStyle.Bold)
        Me.LblCodigoValor.Location = New System.Drawing.Point(153, 6)
        Me.LblCodigoValor.Name = "LblCodigoValor"
        Me.LblCodigoValor.Size = New System.Drawing.Size(89, 14)
        Me.LblCodigoValor.TabIndex = 2
        Me.LblCodigoValor.Text = "<NuevoValor>"
        '
        'LblCodigoRotulo
        '
        Me.LblCodigoRotulo.Location = New System.Drawing.Point(51, 7)
        Me.LblCodigoRotulo.Name = "LblCodigoRotulo"
        Me.LblCodigoRotulo.Size = New System.Drawing.Size(96, 13)
        Me.LblCodigoRotulo.TabIndex = 1
        Me.LblCodigoRotulo.Text = "Número de Factura:"
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
        Me.XTTDatos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XTTDatos.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom
        Me.XTTDatos.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal
        Me.XTTDatos.Location = New System.Drawing.Point(4, 91)
        Me.XTTDatos.Name = "XTTDatos"
        Me.XTTDatos.SelectedTabPage = Me.XTPEncBasico
        Me.XTTDatos.Size = New System.Drawing.Size(775, 155)
        Me.XTTDatos.TabIndex = 12
        Me.XTTDatos.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XTPEncBasico, Me.XTPEncAvanzado, Me.XTPEncExport, Me.XTPEncTotales})
        '
        'XTPEncBasico
        '
        Me.XTPEncBasico.Controls.Add(Me.LblMonedaCodigo)
        Me.XTPEncBasico.Controls.Add(Me.TxtDescripcion)
        Me.XTPEncBasico.Controls.Add(Me.LblDescripcion)
        Me.XTPEncBasico.Controls.Add(Me.TxtFactNum)
        Me.XTPEncBasico.Controls.Add(Me.LabelControl4)
        Me.XTPEncBasico.Controls.Add(Me.LblSdN)
        Me.XTPEncBasico.Controls.Add(Me.LblFecha)
        Me.XTPEncBasico.Controls.Add(Me.LblFactNum)
        Me.XTPEncBasico.Controls.Add(Me.TxtSdNCodigo)
        Me.XTPEncBasico.Controls.Add(Me.TxtFecha)
        Me.XTPEncBasico.Controls.Add(Me.TxtRetencionID)
        Me.XTPEncBasico.Controls.Add(Me.TxtMonedaCodigo)
        Me.XTPEncBasico.Name = "XTPEncBasico"
        Me.XTPEncBasico.Size = New System.Drawing.Size(769, 127)
        Me.XTPEncBasico.Text = "Básico"
        '
        'LblMonedaCodigo
        '
        Me.LblMonedaCodigo.Location = New System.Drawing.Point(398, 72)
        Me.LblMonedaCodigo.Name = "LblMonedaCodigo"
        Me.LblMonedaCodigo.Size = New System.Drawing.Size(38, 13)
        Me.LblMonedaCodigo.TabIndex = 5
        Me.LblMonedaCodigo.Text = "Moneda"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(120, 65)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Properties.MaxLength = 50
        Me.TxtDescripcion.Size = New System.Drawing.Size(230, 20)
        Me.TxtDescripcion.TabIndex = 2
        '
        'LblDescripcion
        '
        Me.LblDescripcion.Location = New System.Drawing.Point(7, 72)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(54, 13)
        Me.LblDescripcion.TabIndex = 5
        Me.LblDescripcion.Text = "Descripción"
        '
        'TxtFactNum
        '
        Me.TxtFactNum.Location = New System.Drawing.Point(120, 7)
        Me.TxtFactNum.Name = "TxtFactNum"
        Me.TxtFactNum.Properties.ReadOnly = True
        Me.TxtFactNum.Size = New System.Drawing.Size(230, 20)
        Me.TxtFactNum.TabIndex = 100
        Me.TxtFactNum.Visible = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(398, 42)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(83, 13)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Aplica Retención:"
        '
        'LblSdN
        '
        Me.LblSdN.Location = New System.Drawing.Point(398, 7)
        Me.LblSdN.Name = "LblSdN"
        Me.LblSdN.Size = New System.Drawing.Size(37, 13)
        Me.LblSdN.TabIndex = 2
        Me.LblSdN.Text = "Cliente:"
        '
        'LblFecha
        '
        Me.LblFecha.Location = New System.Drawing.Point(7, 43)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(29, 13)
        Me.LblFecha.TabIndex = 1
        Me.LblFecha.Text = "Fecha"
        '
        'LblFactNum
        '
        Me.LblFactNum.Location = New System.Drawing.Point(8, 7)
        Me.LblFactNum.Name = "LblFactNum"
        Me.LblFactNum.Size = New System.Drawing.Size(96, 13)
        Me.LblFactNum.TabIndex = 0
        Me.LblFactNum.Text = "Número de Factura:"
        Me.LblFactNum.Visible = False
        '
        'TxtSdNCodigo
        '
        Me.TxtSdNCodigo.Location = New System.Drawing.Point(495, 7)
        Me.TxtSdNCodigo.Name = "TxtSdNCodigo"
        Me.TxtSdNCodigo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtSdNCodigo.Properties.NullText = ""
        Me.TxtSdNCodigo.Properties.ShowNullValuePromptWhenFocused = True
        Me.TxtSdNCodigo.Properties.View = Me.GLEClientes
        Me.TxtSdNCodigo.Size = New System.Drawing.Size(230, 20)
        Me.TxtSdNCodigo.TabIndex = 3
        '
        'GLEClientes
        '
        Me.GLEClientes.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn5, Me.GridColumn6, Me.GridColumn13})
        Me.GLEClientes.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GLEClientes.Name = "GLEClientes"
        Me.GLEClientes.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GLEClientes.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GLEClientes.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GLEClientes.OptionsView.ShowAutoFilterRow = True
        Me.GLEClientes.OptionsView.ShowGroupPanel = False
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Código"
        Me.GridColumn5.FieldName = "TP"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Descripción"
        Me.GridColumn6.FieldName = "Description"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        Me.GridColumn6.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 1
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Conocido como"
        Me.GridColumn13.FieldName = "KnownAsName"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.AllowEdit = False
        Me.GridColumn13.OptionsColumn.ReadOnly = True
        Me.GridColumn13.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 2
        '
        'TxtFecha
        '
        Me.TxtFecha.EditValue = Nothing
        Me.TxtFecha.Location = New System.Drawing.Point(120, 39)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtFecha.Properties.Mask.EditMask = ""
        Me.TxtFecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.TxtFecha.Size = New System.Drawing.Size(230, 20)
        Me.TxtFecha.TabIndex = 1
        '
        'TxtRetencionID
        '
        Me.TxtRetencionID.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.TxtRetencionID.Location = New System.Drawing.Point(495, 39)
        Me.TxtRetencionID.Name = "TxtRetencionID"
        Me.TxtRetencionID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtRetencionID.Properties.NullText = ""
        Me.TxtRetencionID.Properties.View = Me.GridView2
        Me.TxtRetencionID.Size = New System.Drawing.Size(230, 20)
        Me.TxtRetencionID.TabIndex = 4
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn18, Me.GridColumn19, Me.GridColumn20})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GridView2.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowAutoFilterRow = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Código"
        Me.GridColumn18.FieldName = "RetencionID"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.OptionsColumn.AllowEdit = False
        Me.GridColumn18.OptionsColumn.ReadOnly = True
        Me.GridColumn18.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 0
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "Descripción"
        Me.GridColumn19.FieldName = "Descripcion"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.OptionsColumn.AllowEdit = False
        Me.GridColumn19.OptionsColumn.ReadOnly = True
        Me.GridColumn19.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 1
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "Porcentaje"
        Me.GridColumn20.FieldName = "Porcentaje"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.OptionsColumn.AllowEdit = False
        Me.GridColumn20.OptionsColumn.ReadOnly = True
        Me.GridColumn20.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn20.Visible = True
        Me.GridColumn20.VisibleIndex = 2
        '
        'TxtMonedaCodigo
        '
        Me.TxtMonedaCodigo.Location = New System.Drawing.Point(495, 65)
        Me.TxtMonedaCodigo.Name = "TxtMonedaCodigo"
        Me.TxtMonedaCodigo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtMonedaCodigo.Properties.MaxLength = 50
        Me.TxtMonedaCodigo.Properties.NullText = ""
        Me.TxtMonedaCodigo.Properties.View = Me.GridView8
        Me.TxtMonedaCodigo.Size = New System.Drawing.Size(230, 20)
        Me.TxtMonedaCodigo.TabIndex = 2
        '
        'GridView8
        '
        Me.GridView8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn42, Me.GridColumn43})
        Me.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView8.OptionsView.ShowGroupPanel = False
        '
        'GridColumn42
        '
        Me.GridColumn42.Caption = "Moneda"
        Me.GridColumn42.FieldName = "MonedaCodigo"
        Me.GridColumn42.Name = "GridColumn42"
        Me.GridColumn42.Visible = True
        Me.GridColumn42.VisibleIndex = 0
        '
        'GridColumn43
        '
        Me.GridColumn43.Caption = "Descripcion"
        Me.GridColumn43.FieldName = "Descripcion"
        Me.GridColumn43.Name = "GridColumn43"
        Me.GridColumn43.Visible = True
        Me.GridColumn43.VisibleIndex = 1
        '
        'XTPEncAvanzado
        '
        Me.XTPEncAvanzado.Controls.Add(Me.TxtNSAG)
        Me.XTPEncAvanzado.Controls.Add(Me.TxtNOCExenta)
        Me.XTPEncAvanzado.Controls.Add(Me.TxtNConstancia)
        Me.XTPEncAvanzado.Controls.Add(Me.LabelControl7)
        Me.XTPEncAvanzado.Controls.Add(Me.LabelControl6)
        Me.XTPEncAvanzado.Controls.Add(Me.LabelControl5)
        Me.XTPEncAvanzado.Controls.Add(Me.TxtNumeroOrden)
        Me.XTPEncAvanzado.Controls.Add(Me.LblNumeroOrden)
        Me.XTPEncAvanzado.Controls.Add(Me.LblEmpresaCodigo)
        Me.XTPEncAvanzado.Controls.Add(Me.TxtCAI)
        Me.XTPEncAvanzado.Controls.Add(Me.LblTipoDoctoID)
        Me.XTPEncAvanzado.Controls.Add(Me.LblDFID)
        Me.XTPEncAvanzado.Controls.Add(Me.LblCAI)
        Me.XTPEncAvanzado.Controls.Add(Me.LblTerminoCodigo)
        Me.XTPEncAvanzado.Controls.Add(Me.TxtDFFactID)
        Me.XTPEncAvanzado.Controls.Add(Me.LblDFFactID)
        Me.XTPEncAvanzado.Controls.Add(Me.TxtTerminoCodigo)
        Me.XTPEncAvanzado.Controls.Add(Me.TxtDFID)
        Me.XTPEncAvanzado.Controls.Add(Me.TxtEmpresaCodigo)
        Me.XTPEncAvanzado.Controls.Add(Me.TxtTiposDoctoID)
        Me.XTPEncAvanzado.Name = "XTPEncAvanzado"
        Me.XTPEncAvanzado.Size = New System.Drawing.Size(769, 127)
        Me.XTPEncAvanzado.Text = "Avanzado"
        '
        'TxtNSAG
        '
        Me.TxtNSAG.Location = New System.Drawing.Point(508, 106)
        Me.TxtNSAG.Name = "TxtNSAG"
        Me.TxtNSAG.Size = New System.Drawing.Size(230, 20)
        Me.TxtNSAG.TabIndex = 31
        '
        'TxtNOCExenta
        '
        Me.TxtNOCExenta.Location = New System.Drawing.Point(107, 106)
        Me.TxtNOCExenta.Name = "TxtNOCExenta"
        Me.TxtNOCExenta.Size = New System.Drawing.Size(251, 20)
        Me.TxtNOCExenta.TabIndex = 30
        '
        'TxtNConstancia
        '
        Me.TxtNConstancia.Location = New System.Drawing.Point(107, 83)
        Me.TxtNConstancia.Name = "TxtNConstancia"
        Me.TxtNConstancia.Size = New System.Drawing.Size(251, 20)
        Me.TxtNConstancia.TabIndex = 29
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(411, 106)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl7.TabIndex = 28
        Me.LabelControl7.Text = "No Registro SAG"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(10, 106)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl6.TabIndex = 27
        Me.LabelControl6.Text = "No O. C. Exenta"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(10, 86)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl5.TabIndex = 26
        Me.LabelControl5.Text = "No Constancia"
        '
        'TxtNumeroOrden
        '
        Me.TxtNumeroOrden.Location = New System.Drawing.Point(508, 83)
        Me.TxtNumeroOrden.Name = "TxtNumeroOrden"
        Me.TxtNumeroOrden.Properties.MaxLength = 50
        Me.TxtNumeroOrden.Size = New System.Drawing.Size(230, 20)
        Me.TxtNumeroOrden.TabIndex = 24
        '
        'LblNumeroOrden
        '
        Me.LblNumeroOrden.Location = New System.Drawing.Point(411, 88)
        Me.LblNumeroOrden.Name = "LblNumeroOrden"
        Me.LblNumeroOrden.Size = New System.Drawing.Size(42, 13)
        Me.LblNumeroOrden.TabIndex = 25
        Me.LblNumeroOrden.Text = "Orden#:"
        '
        'LblEmpresaCodigo
        '
        Me.LblEmpresaCodigo.Location = New System.Drawing.Point(10, 39)
        Me.LblEmpresaCodigo.Name = "LblEmpresaCodigo"
        Me.LblEmpresaCodigo.Size = New System.Drawing.Size(41, 13)
        Me.LblEmpresaCodigo.TabIndex = 9
        Me.LblEmpresaCodigo.Text = "Empresa"
        '
        'TxtCAI
        '
        Me.TxtCAI.Location = New System.Drawing.Point(107, 61)
        Me.TxtCAI.Name = "TxtCAI"
        Me.TxtCAI.Properties.ReadOnly = True
        Me.TxtCAI.Size = New System.Drawing.Size(251, 20)
        Me.TxtCAI.TabIndex = 20
        '
        'LblTipoDoctoID
        '
        Me.LblTipoDoctoID.Location = New System.Drawing.Point(411, 37)
        Me.LblTipoDoctoID.Name = "LblTipoDoctoID"
        Me.LblTipoDoctoID.Size = New System.Drawing.Size(91, 13)
        Me.LblTipoDoctoID.TabIndex = 9
        Me.LblTipoDoctoID.Text = "Tipo de documento"
        '
        'LblDFID
        '
        Me.LblDFID.Location = New System.Drawing.Point(411, 63)
        Me.LblDFID.Name = "LblDFID"
        Me.LblDFID.Size = New System.Drawing.Size(91, 13)
        Me.LblDFID.TabIndex = 9
        Me.LblDFID.Text = "Documento Fuente"
        '
        'LblCAI
        '
        Me.LblCAI.Location = New System.Drawing.Point(10, 65)
        Me.LblCAI.Name = "LblCAI"
        Me.LblCAI.Size = New System.Drawing.Size(18, 13)
        Me.LblCAI.TabIndex = 9
        Me.LblCAI.Text = "CAI"
        '
        'LblTerminoCodigo
        '
        Me.LblTerminoCodigo.Location = New System.Drawing.Point(411, 11)
        Me.LblTerminoCodigo.Name = "LblTerminoCodigo"
        Me.LblTerminoCodigo.Size = New System.Drawing.Size(80, 13)
        Me.LblTerminoCodigo.TabIndex = 7
        Me.LblTerminoCodigo.Text = "Término de pago"
        '
        'TxtDFFactID
        '
        Me.TxtDFFactID.Location = New System.Drawing.Point(107, 9)
        Me.TxtDFFactID.Name = "TxtDFFactID"
        Me.TxtDFFactID.Properties.ReadOnly = True
        Me.TxtDFFactID.Size = New System.Drawing.Size(251, 20)
        Me.TxtDFFactID.TabIndex = 8
        '
        'LblDFFactID
        '
        Me.LblDFFactID.Location = New System.Drawing.Point(10, 13)
        Me.LblDFFactID.Name = "LblDFFactID"
        Me.LblDFFactID.Size = New System.Drawing.Size(85, 13)
        Me.LblDFFactID.TabIndex = 7
        Me.LblDFFactID.Text = "ID del Documento"
        '
        'TxtTerminoCodigo
        '
        Me.TxtTerminoCodigo.Location = New System.Drawing.Point(508, 7)
        Me.TxtTerminoCodigo.Name = "TxtTerminoCodigo"
        Me.TxtTerminoCodigo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.TxtTerminoCodigo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtTerminoCodigo.Properties.NullText = ""
        Me.TxtTerminoCodigo.Properties.View = Me.GridView3
        Me.TxtTerminoCodigo.Size = New System.Drawing.Size(230, 20)
        Me.TxtTerminoCodigo.TabIndex = 21
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn28, Me.GridColumn29})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GridView3.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowAutoFilterRow = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'GridColumn28
        '
        Me.GridColumn28.Caption = "Código"
        Me.GridColumn28.FieldName = "PayTerms"
        Me.GridColumn28.Name = "GridColumn28"
        Me.GridColumn28.OptionsColumn.AllowEdit = False
        Me.GridColumn28.OptionsColumn.ReadOnly = True
        Me.GridColumn28.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn28.Visible = True
        Me.GridColumn28.VisibleIndex = 0
        '
        'GridColumn29
        '
        Me.GridColumn29.Caption = "Descripción"
        Me.GridColumn29.FieldName = "Description"
        Me.GridColumn29.Name = "GridColumn29"
        Me.GridColumn29.OptionsColumn.AllowEdit = False
        Me.GridColumn29.OptionsColumn.ReadOnly = True
        Me.GridColumn29.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn29.Visible = True
        Me.GridColumn29.VisibleIndex = 1
        '
        'TxtDFID
        '
        Me.TxtDFID.Location = New System.Drawing.Point(508, 59)
        Me.TxtDFID.Name = "TxtDFID"
        Me.TxtDFID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtDFID.Properties.NullText = ""
        Me.TxtDFID.Properties.PopupFormSize = New System.Drawing.Size(1000, 500)
        Me.TxtDFID.Properties.View = Me.GridView4
        Me.TxtDFID.Size = New System.Drawing.Size(230, 20)
        Me.TxtDFID.TabIndex = 23
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn30, Me.GridColumn31, Me.GridColumn32, Me.GridColumn33, Me.GridColumn34, Me.GridColumn35, Me.GridColumn36, Me.GridColumn37, Me.GridColumn38})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsEditForm.PopupEditFormWidth = 1000
        Me.GridView4.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GridView4.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowAutoFilterRow = True
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'GridColumn30
        '
        Me.GridColumn30.Caption = "Documento Fuente"
        Me.GridColumn30.FieldName = "SrcDoc"
        Me.GridColumn30.Name = "GridColumn30"
        Me.GridColumn30.OptionsColumn.AllowEdit = False
        Me.GridColumn30.OptionsColumn.ReadOnly = True
        Me.GridColumn30.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn30.Visible = True
        Me.GridColumn30.VisibleIndex = 0
        '
        'GridColumn31
        '
        Me.GridColumn31.Caption = "Descripción"
        Me.GridColumn31.FieldName = "Description"
        Me.GridColumn31.Name = "GridColumn31"
        Me.GridColumn31.OptionsColumn.AllowEdit = False
        Me.GridColumn31.OptionsColumn.ReadOnly = True
        Me.GridColumn31.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn31.Visible = True
        Me.GridColumn31.VisibleIndex = 1
        '
        'GridColumn32
        '
        Me.GridColumn32.Caption = "ID Interno"
        Me.GridColumn32.FieldName = "ObjectID"
        Me.GridColumn32.Name = "GridColumn32"
        '
        'GridColumn33
        '
        Me.GridColumn33.Caption = "Fecha"
        Me.GridColumn33.FieldName = "DocDate"
        Me.GridColumn33.Name = "GridColumn33"
        Me.GridColumn33.OptionsColumn.AllowEdit = False
        Me.GridColumn33.OptionsColumn.ReadOnly = True
        Me.GridColumn33.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn33.Visible = True
        Me.GridColumn33.VisibleIndex = 2
        '
        'GridColumn34
        '
        Me.GridColumn34.Caption = "Monto"
        Me.GridColumn34.FieldName = "DocAmt"
        Me.GridColumn34.Name = "GridColumn34"
        Me.GridColumn34.OptionsColumn.AllowEdit = False
        Me.GridColumn34.OptionsColumn.ReadOnly = True
        Me.GridColumn34.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn34.Visible = True
        Me.GridColumn34.VisibleIndex = 3
        '
        'GridColumn35
        '
        Me.GridColumn35.Caption = "Creador"
        Me.GridColumn35.FieldName = "Creator"
        Me.GridColumn35.Name = "GridColumn35"
        '
        'GridColumn36
        '
        Me.GridColumn36.Caption = "Receptor"
        Me.GridColumn36.FieldName = "Recipient"
        Me.GridColumn36.Name = "GridColumn36"
        '
        'GridColumn37
        '
        Me.GridColumn37.Caption = "Nota"
        Me.GridColumn37.FieldName = "Memo"
        Me.GridColumn37.Name = "GridColumn37"
        '
        'GridColumn38
        '
        Me.GridColumn38.Caption = "Empresa"
        Me.GridColumn38.FieldName = "Company"
        Me.GridColumn38.Name = "GridColumn38"
        '
        'TxtEmpresaCodigo
        '
        Me.TxtEmpresaCodigo.Enabled = False
        Me.TxtEmpresaCodigo.Location = New System.Drawing.Point(107, 35)
        Me.TxtEmpresaCodigo.Name = "TxtEmpresaCodigo"
        Me.TxtEmpresaCodigo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtEmpresaCodigo.Properties.NullText = ""
        Me.TxtEmpresaCodigo.Properties.ReadOnly = True
        Me.TxtEmpresaCodigo.Properties.View = Me.GridView5
        Me.TxtEmpresaCodigo.Size = New System.Drawing.Size(251, 20)
        Me.TxtEmpresaCodigo.TabIndex = 5
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn26, Me.GridColumn27})
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowAutoFilterRow = True
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'GridColumn26
        '
        Me.GridColumn26.Caption = "Código"
        Me.GridColumn26.FieldName = "TP"
        Me.GridColumn26.Name = "GridColumn26"
        Me.GridColumn26.Visible = True
        Me.GridColumn26.VisibleIndex = 0
        '
        'GridColumn27
        '
        Me.GridColumn27.Caption = "Descripción"
        Me.GridColumn27.FieldName = "Description"
        Me.GridColumn27.Name = "GridColumn27"
        Me.GridColumn27.Visible = True
        Me.GridColumn27.VisibleIndex = 1
        '
        'TxtTiposDoctoID
        '
        Me.TxtTiposDoctoID.Location = New System.Drawing.Point(508, 33)
        Me.TxtTiposDoctoID.Name = "TxtTiposDoctoID"
        Me.TxtTiposDoctoID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtTiposDoctoID.Properties.NullText = ""
        Me.TxtTiposDoctoID.Properties.ReadOnly = True
        Me.TxtTiposDoctoID.Properties.View = Me.GridView1
        Me.TxtTiposDoctoID.Size = New System.Drawing.Size(230, 20)
        Me.TxtTiposDoctoID.TabIndex = 22
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn40, Me.GridColumn41})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn40
        '
        Me.GridColumn40.Caption = "Código"
        Me.GridColumn40.FieldName = "TiposDoctoID"
        Me.GridColumn40.Name = "GridColumn40"
        Me.GridColumn40.Visible = True
        Me.GridColumn40.VisibleIndex = 0
        '
        'GridColumn41
        '
        Me.GridColumn41.Caption = "Descripción"
        Me.GridColumn41.FieldName = "Descripcion"
        Me.GridColumn41.Name = "GridColumn41"
        Me.GridColumn41.Visible = True
        Me.GridColumn41.VisibleIndex = 1
        '
        'XTPEncExport
        '
        Me.XTPEncExport.Controls.Add(Me.memoTxtInfoExtra)
        Me.XTPEncExport.Controls.Add(Me.LabelControl3)
        Me.XTPEncExport.Controls.Add(Me.memoTxtNotificarA)
        Me.XTPEncExport.Controls.Add(Me.LabelControl1)
        Me.XTPEncExport.Controls.Add(Me.LblConEmbarque)
        Me.XTPEncExport.Controls.Add(Me.LblFechaEmbarque)
        Me.XTPEncExport.Controls.Add(Me.LabelControl2)
        Me.XTPEncExport.Controls.Add(Me.TxtPuertoDescarga)
        Me.XTPEncExport.Controls.Add(Me.LblPuertoDescarga)
        Me.XTPEncExport.Controls.Add(Me.TxtFDA)
        Me.XTPEncExport.Controls.Add(Me.TxtAcuerdo)
        Me.XTPEncExport.Controls.Add(Me.TxtPuertoCarga)
        Me.XTPEncExport.Controls.Add(Me.LblFDA)
        Me.XTPEncExport.Controls.Add(Me.lblAcuerdo)
        Me.XTPEncExport.Controls.Add(Me.LblPuertoCarga)
        Me.XTPEncExport.Controls.Add(Me.TxtBarco)
        Me.XTPEncExport.Controls.Add(Me.LblBarco)
        Me.XTPEncExport.Controls.Add(Me.TxtFechaEmbarque)
        Me.XTPEncExport.Controls.Add(Me.TxtConocimientoEmbarque)
        Me.XTPEncExport.Controls.Add(Me.TxtCambioDolar)
        Me.XTPEncExport.Name = "XTPEncExport"
        Me.XTPEncExport.PageVisible = False
        Me.XTPEncExport.Size = New System.Drawing.Size(769, 127)
        Me.XTPEncExport.Text = "Exportación"
        '
        'memoTxtInfoExtra
        '
        Me.memoTxtInfoExtra.Location = New System.Drawing.Point(598, 4)
        Me.memoTxtInfoExtra.Name = "memoTxtInfoExtra"
        Me.memoTxtInfoExtra.Properties.MaxLength = 600
        Me.memoTxtInfoExtra.Size = New System.Drawing.Size(163, 119)
        Me.memoTxtInfoExtra.TabIndex = 35
        Me.memoTxtInfoExtra.UseOptimizedRendering = True
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(535, 6)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl3.TabIndex = 34
        Me.LabelControl3.Text = "Info. Extra:"
        '
        'memoTxtNotificarA
        '
        Me.memoTxtNotificarA.Location = New System.Drawing.Point(355, 69)
        Me.memoTxtNotificarA.Name = "memoTxtNotificarA"
        Me.memoTxtNotificarA.Properties.MaxLength = 600
        Me.memoTxtNotificarA.Size = New System.Drawing.Size(233, 55)
        Me.memoTxtNotificarA.TabIndex = 33
        Me.memoTxtNotificarA.UseOptimizedRendering = True
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(271, 72)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl1.TabIndex = 32
        Me.LabelControl1.Text = "Notificar A:"
        '
        'LblConEmbarque
        '
        Me.LblConEmbarque.Location = New System.Drawing.Point(271, 51)
        Me.LblConEmbarque.Name = "LblConEmbarque"
        Me.LblConEmbarque.Size = New System.Drawing.Size(59, 13)
        Me.LblConEmbarque.TabIndex = 11
        Me.LblConEmbarque.Text = "Bill of Lading"
        '
        'LblFechaEmbarque
        '
        Me.LblFechaEmbarque.Location = New System.Drawing.Point(15, 55)
        Me.LblFechaEmbarque.Name = "LblFechaEmbarque"
        Me.LblFechaEmbarque.Size = New System.Drawing.Size(80, 13)
        Me.LblFechaEmbarque.TabIndex = 11
        Me.LblFechaEmbarque.Text = "Fecha Embarque"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(14, 107)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl2.TabIndex = 11
        Me.LabelControl2.Text = "Cambio del USD$"
        '
        'TxtPuertoDescarga
        '
        Me.TxtPuertoDescarga.Location = New System.Drawing.Point(355, 26)
        Me.TxtPuertoDescarga.Name = "TxtPuertoDescarga"
        Me.TxtPuertoDescarga.Size = New System.Drawing.Size(156, 20)
        Me.TxtPuertoDescarga.TabIndex = 28
        '
        'LblPuertoDescarga
        '
        Me.LblPuertoDescarga.Location = New System.Drawing.Point(271, 27)
        Me.LblPuertoDescarga.Name = "LblPuertoDescarga"
        Me.LblPuertoDescarga.Size = New System.Drawing.Size(79, 13)
        Me.LblPuertoDescarga.TabIndex = 11
        Me.LblPuertoDescarga.Text = "Puerto descarga"
        '
        'TxtFDA
        '
        Me.TxtFDA.Location = New System.Drawing.Point(98, 79)
        Me.TxtFDA.Name = "TxtFDA"
        Me.TxtFDA.Properties.ReadOnly = True
        Me.TxtFDA.Size = New System.Drawing.Size(156, 20)
        Me.TxtFDA.TabIndex = 30
        '
        'TxtAcuerdo
        '
        Me.TxtAcuerdo.Location = New System.Drawing.Point(99, 28)
        Me.TxtAcuerdo.Name = "TxtAcuerdo"
        Me.TxtAcuerdo.Size = New System.Drawing.Size(155, 20)
        Me.TxtAcuerdo.TabIndex = 25
        '
        'TxtPuertoCarga
        '
        Me.TxtPuertoCarga.Location = New System.Drawing.Point(355, 3)
        Me.TxtPuertoCarga.Name = "TxtPuertoCarga"
        Me.TxtPuertoCarga.Size = New System.Drawing.Size(156, 20)
        Me.TxtPuertoCarga.TabIndex = 27
        '
        'LblFDA
        '
        Me.LblFDA.Location = New System.Drawing.Point(15, 83)
        Me.LblFDA.Name = "LblFDA"
        Me.LblFDA.Size = New System.Drawing.Size(20, 13)
        Me.LblFDA.TabIndex = 11
        Me.LblFDA.Text = "FDA"
        '
        'lblAcuerdo
        '
        Me.lblAcuerdo.Location = New System.Drawing.Point(15, 29)
        Me.lblAcuerdo.Name = "lblAcuerdo"
        Me.lblAcuerdo.Size = New System.Drawing.Size(43, 13)
        Me.lblAcuerdo.TabIndex = 11
        Me.lblAcuerdo.Text = "Contrato"
        '
        'LblPuertoCarga
        '
        Me.LblPuertoCarga.Location = New System.Drawing.Point(271, 3)
        Me.LblPuertoCarga.Name = "LblPuertoCarga"
        Me.LblPuertoCarga.Size = New System.Drawing.Size(62, 13)
        Me.LblPuertoCarga.TabIndex = 11
        Me.LblPuertoCarga.Text = "Puerto carga"
        '
        'TxtBarco
        '
        Me.TxtBarco.Location = New System.Drawing.Point(99, 3)
        Me.TxtBarco.Name = "TxtBarco"
        Me.TxtBarco.Size = New System.Drawing.Size(155, 20)
        Me.TxtBarco.TabIndex = 24
        '
        'LblBarco
        '
        Me.LblBarco.Location = New System.Drawing.Point(15, 3)
        Me.LblBarco.Name = "LblBarco"
        Me.LblBarco.Size = New System.Drawing.Size(27, 13)
        Me.LblBarco.TabIndex = 11
        Me.LblBarco.Text = "Barco"
        '
        'TxtFechaEmbarque
        '
        Me.TxtFechaEmbarque.EditValue = Nothing
        Me.TxtFechaEmbarque.Location = New System.Drawing.Point(99, 54)
        Me.TxtFechaEmbarque.Name = "TxtFechaEmbarque"
        Me.TxtFechaEmbarque.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtFechaEmbarque.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtFechaEmbarque.Properties.Mask.EditMask = "G"
        Me.TxtFechaEmbarque.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.TxtFechaEmbarque.Size = New System.Drawing.Size(155, 20)
        Me.TxtFechaEmbarque.TabIndex = 26
        '
        'TxtConocimientoEmbarque
        '
        Me.TxtConocimientoEmbarque.Location = New System.Drawing.Point(355, 49)
        Me.TxtConocimientoEmbarque.Name = "TxtConocimientoEmbarque"
        Me.TxtConocimientoEmbarque.Size = New System.Drawing.Size(156, 20)
        Me.TxtConocimientoEmbarque.TabIndex = 29
        '
        'TxtCambioDolar
        '
        Me.TxtCambioDolar.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.TxtCambioDolar.Location = New System.Drawing.Point(98, 103)
        Me.TxtCambioDolar.Name = "TxtCambioDolar"
        Me.TxtCambioDolar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtCambioDolar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.TxtCambioDolar.Size = New System.Drawing.Size(156, 20)
        Me.TxtCambioDolar.TabIndex = 31
        '
        'XTPEncTotales
        '
        Me.XTPEncTotales.Controls.Add(Me.TxtTotalExento)
        Me.XTPEncTotales.Controls.Add(Me.LblTotalExento)
        Me.XTPEncTotales.Controls.Add(Me.LblMontoImpuesto)
        Me.XTPEncTotales.Controls.Add(Me.LblMontoDescto)
        Me.XTPEncTotales.Controls.Add(Me.LblTotalNeto)
        Me.XTPEncTotales.Controls.Add(Me.LblTotalBruto)
        Me.XTPEncTotales.Controls.Add(Me.TxtTotalNeto)
        Me.XTPEncTotales.Controls.Add(Me.TxtTotalBruto)
        Me.XTPEncTotales.Controls.Add(Me.TxtDesctoMonto)
        Me.XTPEncTotales.Controls.Add(Me.TxtImptoMonto)
        Me.XTPEncTotales.Name = "XTPEncTotales"
        Me.XTPEncTotales.Size = New System.Drawing.Size(769, 127)
        Me.XTPEncTotales.Text = "Totales"
        '
        'TxtTotalExento
        '
        Me.TxtTotalExento.Location = New System.Drawing.Point(479, 47)
        Me.TxtTotalExento.Name = "TxtTotalExento"
        Me.TxtTotalExento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtTotalExento.Properties.Mask.EditMask = "n2"
        Me.TxtTotalExento.Properties.ReadOnly = True
        Me.TxtTotalExento.Size = New System.Drawing.Size(230, 20)
        Me.TxtTotalExento.TabIndex = 37
        '
        'LblTotalExento
        '
        Me.LblTotalExento.Location = New System.Drawing.Point(382, 50)
        Me.LblTotalExento.Name = "LblTotalExento"
        Me.LblTotalExento.Size = New System.Drawing.Size(61, 13)
        Me.LblTotalExento.TabIndex = 36
        Me.LblTotalExento.Text = "Total Exento"
        '
        'LblMontoImpuesto
        '
        Me.LblMontoImpuesto.Location = New System.Drawing.Point(9, 67)
        Me.LblMontoImpuesto.Name = "LblMontoImpuesto"
        Me.LblMontoImpuesto.Size = New System.Drawing.Size(78, 13)
        Me.LblMontoImpuesto.TabIndex = 11
        Me.LblMontoImpuesto.Text = "Monto Impuesto"
        '
        'LblMontoDescto
        '
        Me.LblMontoDescto.Location = New System.Drawing.Point(9, 43)
        Me.LblMontoDescto.Name = "LblMontoDescto"
        Me.LblMontoDescto.Size = New System.Drawing.Size(84, 13)
        Me.LblMontoDescto.TabIndex = 11
        Me.LblMontoDescto.Text = "Monto Descuento"
        '
        'LblTotalNeto
        '
        Me.LblTotalNeto.Location = New System.Drawing.Point(382, 17)
        Me.LblTotalNeto.Name = "LblTotalNeto"
        Me.LblTotalNeto.Size = New System.Drawing.Size(50, 13)
        Me.LblTotalNeto.TabIndex = 5
        Me.LblTotalNeto.Text = "Total Neto"
        '
        'LblTotalBruto
        '
        Me.LblTotalBruto.Location = New System.Drawing.Point(9, 17)
        Me.LblTotalBruto.Name = "LblTotalBruto"
        Me.LblTotalBruto.Size = New System.Drawing.Size(53, 13)
        Me.LblTotalBruto.TabIndex = 5
        Me.LblTotalBruto.Text = "Total Bruto"
        '
        'TxtTotalNeto
        '
        Me.TxtTotalNeto.Location = New System.Drawing.Point(479, 17)
        Me.TxtTotalNeto.Name = "TxtTotalNeto"
        Me.TxtTotalNeto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtTotalNeto.Properties.Mask.EditMask = "n2"
        Me.TxtTotalNeto.Properties.ReadOnly = True
        Me.TxtTotalNeto.Size = New System.Drawing.Size(230, 20)
        Me.TxtTotalNeto.TabIndex = 35
        '
        'TxtTotalBruto
        '
        Me.TxtTotalBruto.Location = New System.Drawing.Point(106, 17)
        Me.TxtTotalBruto.Name = "TxtTotalBruto"
        Me.TxtTotalBruto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtTotalBruto.Properties.Mask.EditMask = "n2"
        Me.TxtTotalBruto.Properties.ReadOnly = True
        Me.TxtTotalBruto.Size = New System.Drawing.Size(230, 20)
        Me.TxtTotalBruto.TabIndex = 32
        '
        'TxtDesctoMonto
        '
        Me.TxtDesctoMonto.Location = New System.Drawing.Point(106, 43)
        Me.TxtDesctoMonto.Name = "TxtDesctoMonto"
        Me.TxtDesctoMonto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtDesctoMonto.Properties.Mask.EditMask = "n2"
        Me.TxtDesctoMonto.Properties.ReadOnly = True
        Me.TxtDesctoMonto.Size = New System.Drawing.Size(230, 20)
        Me.TxtDesctoMonto.TabIndex = 33
        '
        'TxtImptoMonto
        '
        Me.TxtImptoMonto.Location = New System.Drawing.Point(106, 67)
        Me.TxtImptoMonto.Name = "TxtImptoMonto"
        Me.TxtImptoMonto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtImptoMonto.Properties.Mask.EditMask = "n2"
        Me.TxtImptoMonto.Properties.ReadOnly = True
        Me.TxtImptoMonto.Size = New System.Drawing.Size(230, 20)
        Me.TxtImptoMonto.TabIndex = 34
        '
        'TlSNotas
        '
        Me.TlSNotas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CmbGrabarNuevo, Me.ToolStripSeparator2, Me.CmbGrabarSalir, Me.CmbRegresarConsulta})
        Me.TlSNotas.Location = New System.Drawing.Point(0, 0)
        Me.TlSNotas.Name = "TlSNotas"
        Me.TlSNotas.Size = New System.Drawing.Size(782, 53)
        Me.TlSNotas.TabIndex = 11
        '
        'CmbGrabarNuevo
        '
        Me.CmbGrabarNuevo.AutoSize = False
        Me.CmbGrabarNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmbGrabarNuevo.Enabled = False
        Me.CmbGrabarNuevo.Image = Global.ConsolaProgramas.My.Resources.Resources.page_save
        Me.CmbGrabarNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmbGrabarNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmbGrabarNuevo.Name = "CmbGrabarNuevo"
        Me.CmbGrabarNuevo.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.CmbGrabarNuevo.Size = New System.Drawing.Size(50, 50)
        Me.CmbGrabarNuevo.Tag = "5"
        Me.CmbGrabarNuevo.Text = "Grabar y crear nuevo registro vacío"
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
        Me.CmbGrabarSalir.Enabled = False
        Me.CmbGrabarSalir.Image = Global.ConsolaProgramas.My.Resources.Resources.disk
        Me.CmbGrabarSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmbGrabarSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmbGrabarSalir.Name = "CmbGrabarSalir"
        Me.CmbGrabarSalir.Size = New System.Drawing.Size(50, 50)
        Me.CmbGrabarSalir.Tag = "5"
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
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'FinDFFactsFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 602)
        Me.Controls.Add(Me.XTTEmpaginacion)
        Me.Name = "FinDFFactsFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Documentos Fuente: Facturas por Venta"
        CType(Me.XTTEmpaginacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTTEmpaginacion.ResumeLayout(False)
        Me.XTTPagina1.ResumeLayout(False)
        Me.XTTPagina1.PerformLayout()
        CType(Me.GrdConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdConsultaView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSelector, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.XTTPagina2.ResumeLayout(False)
        Me.XTTPagina2.PerformLayout()
        Me.GrpRegistro.ResumeLayout(False)
        CType(Me.XTTDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTTDetalle.ResumeLayout(False)
        Me.XTTRegPagina1.ResumeLayout(False)
        Me.XTTRegPagina1.PerformLayout()
        CType(Me.TxtBoletaPeso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtRegUnidMedCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtRegProdCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtRegCantidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtRegPrecio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtRegTotalNeto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTTRegPagina2.ResumeLayout(False)
        Me.XTTRegPagina2.PerformLayout()
        CType(Me.TxtRegProdXFactID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtRegImptoCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtRegTotalBruto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtRegDesctoMonto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtRegImptoMonto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtRegDescrip1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtRegDescrip2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdVwItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCTEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PCTEncabezado.ResumeLayout(False)
        Me.PCTEncabezado.PerformLayout()
        CType(Me.XTTDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTTDatos.ResumeLayout(False)
        Me.XTPEncBasico.ResumeLayout(False)
        Me.XTPEncBasico.PerformLayout()
        CType(Me.TxtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFactNum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSdNCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GLEClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtRetencionID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMonedaCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTPEncAvanzado.ResumeLayout(False)
        Me.XTPEncAvanzado.PerformLayout()
        CType(Me.TxtNSAG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNOCExenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNConstancia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNumeroOrden.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCAI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDFFactID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTerminoCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDFID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtEmpresaCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTiposDoctoID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTPEncExport.ResumeLayout(False)
        Me.XTPEncExport.PerformLayout()
        CType(Me.memoTxtInfoExtra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memoTxtNotificarA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPuertoDescarga.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFDA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtAcuerdo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPuertoCarga.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtBarco.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFechaEmbarque.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFechaEmbarque.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtConocimientoEmbarque.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCambioDolar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTPEncTotales.ResumeLayout(False)
        Me.XTPEncTotales.PerformLayout()
        CType(Me.TxtTotalExento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTotalNeto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTotalBruto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDesctoMonto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtImptoMonto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TlSNotas.ResumeLayout(False)
        Me.TlSNotas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XTTEmpaginacion As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XTTPagina1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GrdConsulta As DevExpress.XtraGrid.GridControl
    Friend WithEvents GrdConsultaView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents CmbEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CmbNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents CmbActualizarConsulta As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CmbImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents XTTPagina2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PCTEncabezado As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LblCodigoValor As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblCodigoRotulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblAccion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XTTDatos As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XTPEncBasico As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TxtFactNum As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblSdN As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblFecha As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblFactNum As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtSdNCodigo As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GLEClientes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TlSNotas As System.Windows.Forms.ToolStrip
    Friend WithEvents CmbGrabarNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CmbGrabarSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents CmbRegresarConsulta As System.Windows.Forms.ToolStripButton
    Friend WithEvents CmbAnular As System.Windows.Forms.ToolStripButton
    Friend WithEvents TxtFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GrdItems As DevExpress.XtraGrid.GridControl
    Friend WithEvents GrdVwItems As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GrpRegistro As System.Windows.Forms.GroupBox
    Friend WithEvents XTTDetalle As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XTTRegPagina1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XTTRegPagina2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents CmbEliminarItem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbModificarItem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CmbNuevoItem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XTPEncTotales As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XTPEncAvanzado As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LblTotalBruto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtDFFactID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblDFFactID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtCAI As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblCAI As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblEmpresaCodigo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblDFID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblTerminoCodigo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblMontoDescto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblMontoImpuesto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblTotalNeto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblRegTotalNeto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblRegCosto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblRegCantidad As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblRegProdCodigo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblRegUnidMedCodigo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblImptoCodigo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtRegProdXFactID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblProdXFactID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblRegTotalBruto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblRegImptoMonto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblDescrip2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblRegDescrip1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblRegDesctoMonto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtRetencionID As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TxtTerminoCodigo As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TxtDFID As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TxtEmpresaCodigo As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TxtRegUnidMedCodigo As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TxtRegProdCodigo As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TxtRegImptoCodigo As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn28 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn29 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn30 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn31 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn32 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn33 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn34 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn35 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn36 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn37 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn38 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn27 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TxtRegCantidad As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents TxtRegPrecio As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents TxtRegTotalNeto As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents TxtRegTotalBruto As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents TxtRegDesctoMonto As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents TxtRegImptoMonto As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents TxtTotalNeto As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents TxtTotalBruto As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents TxtDesctoMonto As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents TxtImptoMonto As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents colDFFactID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblEstado As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtDescripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblDescripcion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XTPEncExport As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LblTipoDoctoID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtTiposDoctoID As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn40 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn41 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TxtAcuerdo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblAcuerdo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtBarco As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblBarco As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblConEmbarque As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblFechaEmbarque As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtPuertoDescarga As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblPuertoDescarga As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtPuertoCarga As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblPuertoCarga As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtFechaEmbarque As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtFDA As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblFDA As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtConocimientoEmbarque As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtCambioDolar As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LblMonedaCodigo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtMonedaCodigo As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn42 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn43 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents memoTxtNotificarA As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents TxtRegDescrip1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents TxtRegDescrip2 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents GridColumn44 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LblTotalExento As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtTotalExento As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents TxtBoletaPeso As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents lblPesoBoletaBascula As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridColumn45 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents colSelector As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkSelector As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents CmbOpcImpresion As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblFrecuenciaImpresion As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtFrecuenciaImpresion As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents lblTipoProcesoImpresion As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CmbSelectorTodos As System.Windows.Forms.ToolStripButton
    Friend WithEvents CmbQuitarSelector As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblTituloSegundos As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TxtNumeroOrden As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblNumeroOrden As DevExpress.XtraEditors.LabelControl
    Friend WithEvents memoTxtInfoExtra As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblConexionBascula As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtNSAG As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtNOCExenta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtNConstancia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
End Class
