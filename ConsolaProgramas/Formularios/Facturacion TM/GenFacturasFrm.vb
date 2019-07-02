Imports System.Data.SqlClient
Imports DevExpress.XtraGrid
Imports DevExpress.Data

Public Class GenFacturasFrm
    Dim f As New Funciones
    Dim cnx As SqlConnection
    Dim emp As String
    Dim usuario As String
    Dim password As String

    Dim adp As SqlDataAdapter
    Dim adpDetalle As SqlDataAdapter
    Dim adpMain As SqlDataAdapter

    Dim dtMain As New DataTable
    Dim dt As New DataTable
    Dim dtDetalle As New DataTable
    Dim dtOt As New DataTable
    Dim dtOTDetalle As New DataTable

    Dim val As Boolean = False
    Dim fila As Boolean = False
    Public Sub New(user As String, pw As String, empresa As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        cnx = New SqlConnection("Persist Security Info=False;User ID=" & user & ";Password=" & pw & ";Initial Catalog=Produccion;Server=AMIGODB\AMIGODB")
        f.Conexion = cnx
        emp = empresa
        usuario = user
        password = pw

        'TablesSetGrid("select Codigo, Descripcion from fotccs where EsCCFacturador = 1", "CentroCosto", cmbDepto, "Descripcion", "Codigo")
    End Sub
    Private Sub GenFacturasFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPrincipal()
        LoadGrid()

        f.NewTable("select FlaLaborID , Codigo, Descripcion from FlaLabores where Sitio= '" & emp & "'", "Labor")
        f.NewTable("select Codigo, Descripcion from fotccs where EsCCFacturador = 1", "cc")

        'f.SetGridLookUpEdit(cmbLabor, f.dsDesarrollo.Tables("Labor"), "ID", "Descripcion")
        f.SetGridLookUpEdit(cmbDepto, f.dsDesarrollo.Tables("cc"), "Codigo", "Descripcion")
        f.SetGridLookUpEdit(cmbLabor, f.dsDesarrollo.Tables("Labor"), "FlaLaborID", "Descripcion")

      
    End Sub
    Public Sub LoadPrincipal()
        dtMain.Clear()
        adpMain = New SqlDataAdapter("spFlaFacturasSelect 0, '" & emp & "'", cnx)
        adpMain.Fill(dtMain)
    End Sub
    Public Sub LoadGrid()
        f.InitGridControl(gc, gv, dtMain, "Sitio,Empresa,FlaFacturaID,cc,UsuarioCreador", False)
        f.FormatColumnGridControl(gv, "Codigo", "Código", 70, DevExpress.Utils.FormatType.Custom, False)
        f.FormatColumnGridControl(gv, "Fecha", "Fecha", 70, DevExpress.Utils.FormatType.DateTime, False)
        f.FormatColumnGridControl(gv, "CentroCosto", "Centro Costo", 100, DevExpress.Utils.FormatType.Custom, False)
        f.FormatColumnGridControl(gv, "Aprobada", "Aprobada", 65, DevExpress.Utils.FormatType.Custom, False)
        f.FormatColumnGridControl(gv, "Contabilizada", "Contabilizada", 70, DevExpress.Utils.FormatType.Custom, False)
        f.FormatColumnGridControl(gv, "Usuario", "Usuario", 70, DevExpress.Utils.FormatType.Custom, False)
        f.FormatColumnGridControl(gv, "Total", "Total", 70, DevExpress.Utils.FormatType.Numeric, "{0:0,0.00}", False)
    End Sub
    Public Sub LoadGridDetalle()

        f.InitGridControl(gcDetalle, gvDetalle, dtDetalle, "FlaDetalleFacturaID,FlaFacturaID,FlaLaborID,Ajuste", False) 'FlaDetalleFacturaID,FlaFacturaID,FlaLaborID,Ajuste
        f.FormatColumnGridControl(gvDetalle, "Codigo", "Código", 70, DevExpress.Utils.FormatType.Custom, False)
        f.FormatColumnGridControl(gvDetalle, "Descripcion", "Descripción", 140, DevExpress.Utils.FormatType.Custom, True)
        f.FormatColumnGridControl(gvDetalle, "Cantidad", "Cantidad", 70, DevExpress.Utils.FormatType.Custom, True)
        f.FormatColumnGridControl(gvDetalle, "Costo", "Costo", 60, DevExpress.Utils.FormatType.Numeric, "{0:0,0.00}", False)
        f.FormatColumnGridControl(gvDetalle, "Ajuste", "Ajuste", 60, DevExpress.Utils.FormatType.Custom, True)
        f.FormatColumnGridControl(gvDetalle, "Observaciones", "Observaciones", 120, DevExpress.Utils.FormatType.Custom, True)
        f.FormatColumnGridControl(gvDetalle, "Cuenta", "Cuenta", 70, DevExpress.Utils.FormatType.Custom, False)
        f.FormatColumnGridControl(gvDetalle, "Total", "Total", 70, DevExpress.Utils.FormatType.Numeric, "{0:0,0.00}", False)

        'f.getGridLookUpEdit(gcDetalle, gvDetalle, f.dsDesarrollo.Tables("Labor"), "Descripcion", "Descripcion", "Descripcion", "Descripcion")

        If Not val Then
            f.AddSummary(SummaryItemType.Sum, gvDetalle, "Cantidad", "{0:0,0.00}")
            f.AddSummary(SummaryItemType.Sum, gvDetalle, "Costo", "{0:0,0.00}")
            f.AddSummary(SummaryItemType.Sum, gvDetalle, "Total", "{0:0,0.00}")
            f.AddSummary(SummaryItemType.Sum, gvDetalle, "Ajuste", "{0:0,0.00}")
            val = True
        End If
    End Sub
    Public Sub LoadOT()
        Dim ot As String = txtOt.Text
        dtOTDetalle = f.getDataTable("spOTDetalleSelect '" & ot & "', '" & emp & "'")
        dtOt = f.getDataTable("spOtSelect '" & ot & "', '" & emp & "'")


        f.InitGridControl(gcOT, GVOT, dtOTDetalle, "", False)

        If dtOt.Rows.Count > 0 Then
            txtOTDescrip.Text = dtOt.Rows(0).Item("Descripcion").ToString
            txtOTEntidad.Text = dtOt.Rows(0).Item("Entidad").ToString
            txtOTCuenta.Text = dtOt.Rows(0).Item("Cuenta").ToString
        End If
    End Sub
    Private Sub CmbNuevo_Click(sender As Object, e As EventArgs) Handles CmbNuevo.Click
        Edit(-1)
    End Sub
    Private Sub CmbEditar_Click(sender As Object, e As EventArgs) Handles CmbEditar.Click
        Edit(gv.GetRowCellValue(gv.FocusedRowHandle, "FlaFacturaID"))
    End Sub
    Private Sub CmbRegresarConsulta_Click(sender As Object, e As EventArgs) Handles CmbRegresarConsulta.Click
        XTTEmpaginacion.SelectedTabPage = XTTPagina1
        CmbGrabarNuevo.Enabled = True
        Clear()
        RegresarVista()
    End Sub
    Private Sub CmbGrabarNuevo_Click(sender As Object, e As EventArgs) Handles CmbGrabarNuevo.Click
        Salvar()

    End Sub
    Private Sub CmbGrabarSalir_Click(sender As Object, e As EventArgs) Handles CmbGrabarSalir.Click
        Salvar()
        XTTEmpaginacion.SelectedTabPage = XTTPagina1
    End Sub
    Public Sub Edit(ID As Integer)
        Clear()
        XTTEmpaginacion.SelectedTabPage = XTTPagina2

        'Detalle

        dt = New DataTable
        adp = New SqlDataAdapter("spFlaFacturasSelect " & ID & ",'" & emp & "'", cnx)
        adp.InsertCommand = f.getSQLComand("spFlaFacturasInsert")
        adp.InsertCommand.Parameters("@FlaFacturaID").Direction = ParameterDirection.InputOutput
        adp.UpdateCommand = f.getSQLComand("spFlaFacturasUpdate")

        dtDetalle = New DataTable
        adpDetalle = New SqlDataAdapter("spflaDetalleFacturaSelect " & ID, cnx)

        adpDetalle.InsertCommand = f.getSQLComand("spFlaDetalleFacturaInsert")
        adpDetalle.UpdateCommand = f.getSQLComand("spFlaDetalleFacturaUpdate")

        adp.Fill(dt)
        adpDetalle.Fill(dtDetalle)
        LoadGridDetalle()


        If dt.Rows.Count = 0 Then
            dt.Rows.Add()
            chkAprobado.Checked = False
            chkContabilizado.Checked = False
        Else
            dtFecha.EditValue = dt.Rows(0).Item("Fecha").ToString
            chkAprobado.Checked = (dt.Rows(0).Item("Aprobada").ToString)
            chkContabilizado.Checked = dt.Rows(0).Item("Contabilizada").ToString
            cmbDepto.EditValue = dt.Rows(0).Item("cc").ToString

            If dt.Rows(0).Item("Aprobada") Then  'Validar si la factura está aprobada no pueda ser modificada.
                CmbGrabarNuevo.Enabled = False
            End If
        End If

        txtOt.Text = dt.Rows(0).Item("OTID").ToString
        txtCodigo.Text = dt.Rows(0).Item("codigo").ToString
        txtUsuario.Text = dt.Rows(0).Item("Usuario").ToString
        txtUsuario.Tag = dt.Rows(0).Item("UsuarioCreador").ToString

        'LoadOT()
    End Sub
    Public Sub Salvar()
        Dim err As New frmErrors

        If txtOt.Text.Length = 0 Then err.NuevoError("Debe ingresar el número de OT", 0)
        If IsNothing(cmbDepto.EditValue) Then err.NuevoError("Debe seleccionar el departamento", 0)
        If IsNothing(dtFecha.EditValue) Then err.NuevoError("Debe ingresar la fecha del comprobante", 0)

        If err.Errores Then
            err.ShowDialog()
            If Not err.isOk Then
                Exit Sub
            End If
        End If

        dt.Rows(0).Item("OTID") = txtOt.Text
        'dt.Rows(0).Item("entidad") = txtEntidad.Text
        dt.Rows(0).Item("Fecha") = dtFecha.EditValue
        dt.Rows(0).Item("cc") = cmbDepto.EditValue
        dt.Rows(0).Item("Usuario") = usuario
        dt.Rows(0).Item("Sitio") = emp
        adp.Update(dt)

        Dim id As Integer = dt.Rows.Item(0).Item("FlaFacturaID")

        For Each row As DataRow In dtDetalle.Rows
            row.Item("FlaFacturaID") = id
        Next

        adpDetalle.Update(dtDetalle)
        MsgBox("registro ingresado exitosamente!", MsgBoxStyle.Information, "Labores")
        LoadPrincipal()
        XTTEmpaginacion.SelectedTabPage = XTTPagina1
    End Sub
    Private Sub CmbActualizarConsulta_Click(sender As Object, e As EventArgs) Handles CmbActualizarConsulta.Click
        LoadPrincipal()
    End Sub
    Public Sub Clear()
        dt.Clear()
        dtDetalle.Clear()
        dtOt.Clear()
        dtOTDetalle.Clear()
        txtOTDescrip.Text = ""
        txtOTEntidad.Text = ""
        txtOTCuenta.Text = ""
        dtFecha.EditValue = Nothing
        cmbDepto.EditValue = Nothing
    End Sub
    Private Sub txtOt_Leave(sender As Object, e As EventArgs) Handles txtOt.Leave
        If txtOt.Text.Length > 0 Then
            LoadOT()
            If dtOt.Rows.Count = 0 Then
                MsgBox("Número de OT no existe", MsgBoxStyle.Critical, "ERROR")
                dtOt.Clear()
                dtOTDetalle.Clear()
                txtOTEntidad.Text = ""
                txtOTCuenta.Text = ""
                txtOTDescrip.Text = ""
                txtOt.Focus()
            End If
        End If
    End Sub
    'Private Sub gvDetalle_CellValueChanged(sender As Object, e As Views.Base.CellValueChangedEventArgs) Handles gvDetalle.CellValueChanged
    '    Dim dtBusqueda As New DataTable
    '    Dim col As String = e.Column.Name.ToLower 'gv.Columns().Name.ToLower

    '    If col = "coldescripcion" And Not IsNothing(e.Value) Then
    '        dtBusqueda = f.getDataTable("select * from FlaLabores where descripcion = '" & e.Value & "'")

    '        dtDetalle.DefaultView.Item(e.RowHandle).Item("Codigo") = dtBusqueda.Rows(0).Item("codigo")
    '        dtDetalle.DefaultView.Item(e.RowHandle).Item("costo") = dtBusqueda.Rows(0).Item("Tarifa")
    '        dtDetalle.DefaultView.Item(e.RowHandle).Item("FlaLaborID") = dtBusqueda.Rows(0).Item("FlaLaborID")
    '        dtDetalle.DefaultView.Item(e.RowHandle).Item("cantidad") = 1
    '        dtDetalle.DefaultView.Item(e.RowHandle).Item("Total") = CDbl(dtBusqueda.Rows(0).Item("Tarifa")) * CDbl(dtDetalle.DefaultView.Item(e.RowHandle).Item("cantidad"))

    '    End If
    'End Sub
    Private Sub btnDetail_Click(sender As Object, e As EventArgs) Handles btnDetail.Click
        fila = False
        Detail()
    End Sub
    Private Sub btnEditDetail_Click(sender As Object, e As EventArgs) Handles btnEditDetail.Click
        Try 'Boton de Editar.
            fila = True
            txtCosto.Text = dtDetalle.DefaultView.Item(gvDetalle.FocusedRowHandle).Item("Costo").ToString
            txtCantidad.Text = dtDetalle.DefaultView.Item(gvDetalle.FocusedRowHandle).Item("Cantidad").ToString
            txtObservaciones.Text = dtDetalle.DefaultView.Item(gvDetalle.FocusedRowHandle).Item("Observaciones").ToString
            txtCuentaDet.Text = dtDetalle.DefaultView.Item(gvDetalle.FocusedRowHandle).Item("Cuenta").ToString
            cmbLabor.EditValue = dtDetalle.DefaultView.Item(gvDetalle.FocusedRowHandle).Item("FlaLaborID").ToString
            txtCosto.Tag = dtDetalle.DefaultView.Item(gvDetalle.FocusedRowHandle).Item("Codigo").ToString

            gcDetalle.Enabled = False
            Detail()
        Catch ex As Exception

            fila = False
        End Try
    End Sub
    Private Sub Detail() 'Ocultar Grupo de registro
        GrpRegistro.Visible = True
        btnDeleteDetail.Enabled = False
        btnEditDetail.Enabled = False
        btnDetail.Enabled = False
    End Sub
    Public Sub RegresarVista()  'Limpiar los datos del detalle
        GrpRegistro.Visible = False
        btnDeleteDetail.Enabled = True
        btnEditDetail.Enabled = True
        btnDetail.Enabled = True
        txtCantidad.Text = ""
        txtCosto.Text = ""
        txtCuentaDet.Text = ""
        txtObservaciones.Text = ""
        cmbLabor.EditValue = Nothing
    End Sub
    Private Sub CmbRegActualizar_Click(sender As Object, e As EventArgs)
        Dim err As New frmErrors

        If txtCantidad.Text.Length = 0 Then err.NuevoError("Debe Ingresar la cantidad", 0)
        If IsNothing(cmbLabor.EditValue) Then err.NuevoError("Debe seleccionar una Labor", 0)
        If txtObservaciones.Text.Length = 0 Then err.NuevoError("Campo de observaciones vacío", 1)

        If err.Errores Then
            err.ShowDialog()
            If Not err.isOk Then
                Exit Sub
            End If
        End If

        'Else
        If fila Then
            dtDetalle.DefaultView.Item(gvDetalle.FocusedRowHandle).Item("FlaLaborID") = cmbLabor.EditValue
            dtDetalle.DefaultView.Item(gvDetalle.FocusedRowHandle).Item("Cantidad") = txtCantidad.Text
            dtDetalle.DefaultView.Item(gvDetalle.FocusedRowHandle).Item("Cuenta") = txtCuentaDet.Text
            dtDetalle.DefaultView.Item(gvDetalle.FocusedRowHandle).Item("Costo") = txtCosto.Text
            dtDetalle.DefaultView.Item(gvDetalle.FocusedRowHandle).Item("Observaciones") = txtObservaciones.Text
            dtDetalle.DefaultView.Item(gvDetalle.FocusedRowHandle).Item("Descripcion") = cmbLabor.Text
            dtDetalle.DefaultView.Item(gvDetalle.FocusedRowHandle).Item("Total") = txtCantidad.Text * txtCosto.Text
            dtDetalle.DefaultView.Item(gvDetalle.FocusedRowHandle).Item("Codigo") = txtCosto.Tag
        Else

            Dim rnew = dtDetalle.NewRow  'Agregar un nuevo registro

            rnew.Item("FlaLaborID") = cmbLabor.EditValue
            rnew.Item("Cantidad") = txtCantidad.Text
            rnew.Item("Costo") = txtCosto.Text
            rnew.Item("Observaciones") = txtObservaciones.Text
            rnew.Item("Descripcion") = cmbLabor.Text
            rnew.Item("Cuenta") = txtCuentaDet.Text
            rnew.Item("Total") = txtCantidad.Text * txtCosto.Text
            rnew.Item("Codigo") = txtCosto.Tag

            dtDetalle.Rows.Add(rnew)
        End If
        RegresarVista()
        gcDetalle.Enabled = True
        'End If
    End Sub
    Private Sub cmbLabor_EditValueChanged(sender As Object, e As EventArgs) Handles cmbLabor.EditValueChanged
        If Not IsNothing(cmbLabor.EditValue) Then
            Dim dtBusqueda As New DataTable
            dtBusqueda = f.getDataTable("select * from FlaLabores where FlaLaborID = " & cmbLabor.EditValue)
            txtCosto.Text = dtBusqueda.Rows(0).Item("Tarifa").ToString
            txtCosto.Tag = dtBusqueda.Rows(0).Item("Codigo").ToString
            txtCuentaDet.Text = dtBusqueda.Rows(0).Item("cuenta").ToString
        End If
    End Sub
    Private Sub CmbRegCancelar_Click(sender As Object, e As EventArgs)
        RegresarVista()
        gcDetalle.Enabled = True
    End Sub
    Private Sub cmbPrint_Click(sender As Object, e As EventArgs) Handles cmbPrint.Click
        Dim v As New GenVistaPrevia

        v.info = "Vista Previa..."
        v.reporte = "\\AMIGOTS2\Reporteador\Reportes\FOT\crFacturacionTM"
        v.dataBase = "Produccion"
        v.user = usuario
        v.pass = password
        v.server = "amigodb\amigodb"
        v.usuarioSesion = usuario
        v.passwordSesion = password
        v.parametro = gv.GetRowCellValue(gv.FocusedRowHandle, "FlaFacturaID")
        v.Show()
    End Sub
End Class