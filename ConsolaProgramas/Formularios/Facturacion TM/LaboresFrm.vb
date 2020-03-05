Imports System.Data.SqlClient
Public Class LaboresFrm
    Dim f As New Funciones
    Dim cnx As SqlConnection
    Dim emp As String
    Dim adp As SqlDataAdapter
    Dim adpMain As SqlDataAdapter
    Dim dtMain As New DataTable
    Dim dt As New DataTable
    Public Sub New(cnx As SqlConnection, user As String, pw As String, empresa As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.cnx = cnx
        f.Conexion = cnx
        emp = empresa
    End Sub
    Private Sub LaboresFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPrincipal()
        LoadGrid()

    End Sub
    Public Sub LoadPrincipal()
        dtMain.Clear()
        adpMain = New SqlDataAdapter("spFlaLaboresSelect 0, '" & emp & "'", cnx)
        adpMain.Fill(dtMain)
    End Sub
    Public Sub LoadGrid()
        f.InitGridControl(gc, gv, dtMain, "FlaLaborID", False)
        f.FormatColumnGridControl(gv, "Codigo", "Código", 70, DevExpress.Utils.FormatType.Custom, False)
        f.FormatColumnGridControl(gv, "Tarifa", "Tarifa", 70, DevExpress.Utils.FormatType.Custom, False)
        f.FormatColumnGridControl(gv, "Empresa", "Empresa", 140, DevExpress.Utils.FormatType.Custom, False)
        f.FormatColumnGridControl(gv, "Sitio", "Sitio", 50, DevExpress.Utils.FormatType.Custom, False)
        f.FormatColumnGridControl(gv, "Descripcion", "Descripción", 150, DevExpress.Utils.FormatType.Custom, False)
    End Sub
    Private Sub CmbNuevo_Click(sender As Object, e As EventArgs) Handles CmbNuevo.Click
        Edit(-1)
    End Sub
    Private Sub CmbEditar_Click(sender As Object, e As EventArgs) Handles CmbEditar.Click
        Edit(gv.GetRowCellValue(gv.FocusedRowHandle, "FlaLaborID"))
    End Sub
    Private Sub CmbRegresarConsulta_Click(sender As Object, e As EventArgs) Handles CmbRegresarConsulta.Click
        XTTEmpaginacion.SelectedTabPage = XTTPagina1
    End Sub
    Private Sub CmbGrabarNuevo_Click(sender As Object, e As EventArgs) Handles CmbGrabarNuevo.Click
        Salvar()
        XTTEmpaginacion.SelectedTabPage = XTTPagina1
    End Sub
    Private Sub CmbGrabarSalir_Click(sender As Object, e As EventArgs) Handles CmbGrabarSalir.Click
        Salvar()
    End Sub
    Public Sub Edit(ID As Integer)
        dt.Clear()
        XTTEmpaginacion.SelectedTabPage = XTTPagina2
        adp = New SqlDataAdapter("spFlaLaboresSelect " & ID & ", '" & emp & "'", cnx)
        adp.InsertCommand = f.getSQLComand("spFlaLaboresInsert")
        adp.UpdateCommand = f.getSQLComand("spFlaLaboresUpdate")
        adp.Fill(dt)

        If dt.Rows.Count = 0 Then
            dt.Rows.Add()
        End If


        txtCodigo.Text = dt.Rows(0).Item("codigo").ToString
        txtCuenta.Text = dt.Rows(0).Item("cuenta").ToString
        txtDescripcion.Text = dt.Rows(0).Item("Descripcion").ToString
        txtTarifa.Text = dt.Rows(0).Item("Tarifa").ToString
        txtSitio.Text = dt.Rows(0).Item("Empresa").ToString
        txtSitio.Tag = emp

    End Sub
    Public Sub Salvar()
        Dim err As New FrmError

        err.ClearError()

        Dim frm As New FrmError
        If txtCodigo.Text.Length = 0 Then frm.AddErr("Debe ingresar el código de la labor", 0)
        If txtCuenta.Text.Length = 0 Then frm.AddErr("Debe ingresar el número de la cuenta", 0)
        If txtDescripcion.Text.Length = 0 Then frm.AddErr("Debe ingresar la descripción de la labor", 0)
        If txtTarifa.Text.Length = 0 Then frm.AddErr("Debe ingresar el valor de la tarifa", 0)

        If frm.isErr Then
            frm.ShowDialog()
        Else
            dt.Rows(0).Item("codigo") = txtCodigo.Text
            dt.Rows(0).Item("cuenta") = txtCuenta.Text
            dt.Rows(0).Item("Descripcion") = txtDescripcion.Text
            dt.Rows(0).Item("Tarifa") = txtTarifa.Text
            dt.Rows(0).Item("Sitio") = txtSitio.Tag

            adp.Update(dt)
            MsgBox("registro ingresado exitosamente!", MsgBoxStyle.Information, "Labores")
            LoadPrincipal()
        End If

    End Sub
    Private Sub CmbActualizarConsulta_Click(sender As Object, e As EventArgs) Handles CmbActualizarConsulta.Click
        LoadPrincipal()
    End Sub
End Class