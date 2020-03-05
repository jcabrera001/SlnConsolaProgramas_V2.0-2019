Imports System.Data.SqlClient
Public Class rolFrm
    Dim f As New Funciones()
    Dim cnx As SqlConnection
    Dim adp As SqlDataAdapter
    Dim dt As New DataTable
    Dim adpMain As SqlDataAdapter
    Dim dtMain As New DataTable
    Dim adpAcceso As SqlDataAdapter
    Dim dtAcceso As New DataTable
    Public Sub New(cnx As SqlConnection, user As String, pw As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.cnx = cnx
        f.Conexion = cnx
    End Sub
    Private Sub rolFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPrincipal()
    End Sub
    Public Sub LoadPrincipal()
        Try
            dtMain.Clear()
            adpMain = New SqlDataAdapter("select * from AAA_rol", cnx)
            adpMain.Fill(dtMain)
            f.InitGridControl(gc, gv, dtMain, "RolID", False)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub CmbNuevo_Click(sender As Object, e As EventArgs) Handles CmbNuevo.Click
        Edit(-1)
    End Sub
    Private Sub CmbEditar_Click(sender As Object, e As EventArgs) Handles CmbEditar.Click
        Edit(gv.GetRowCellValue(gv.FocusedRowHandle, "RolID"))
    End Sub
    Private Sub CmbRegresarConsulta_Click(sender As Object, e As EventArgs) Handles CmbRegresarConsulta.Click
        XTTEmpaginacion.SelectedTabPage = XTTPagina1
    End Sub
    Private Sub CmbGrabarNuevo_Click(sender As Object, e As EventArgs) Handles CmbGrabarNuevo.Click
        Salvar()
        XTTEmpaginacion.SelectedTabPage = XTTPagina1
    End Sub

    Public Sub Edit(ID As Integer)
        dt.Clear()
        dtAcceso.Clear()

        XTTEmpaginacion.SelectedTabPage = XTTPagina2
        adp = New SqlDataAdapter("select * from AAA_rol where rolID = " & ID, cnx)
        adp.InsertCommand = f.getSQLComand("spRolInsert")
        adp.UpdateCommand = f.getSQLComand("spRolUpdate")
        adp.Fill(dt)

        Dim prm As New SqlParameter("rolid", ID)
        adpAcceso = New SqlDataAdapter("spAccesoRolSelect " & ID, cnx)
        adpAcceso.UpdateCommand = f.getSQLComand("spAccesoRolInsert", prm)
        adpAcceso.Fill(dtAcceso)

        'Iniciar el grid
        f.InitGridControl(gcDetalle, gvDetalle, dtAcceso, "AccesoRolID,AccesoID,RolID", True)
        f.FormatColumnGridControl(gvDetalle, "Aplicar", "Aplicar", 30, DevExpress.Utils.FormatType.Custom, True)
        f.FormatColumnGridControl(gvDetalle, "Codigo", "Código", 100, DevExpress.Utils.FormatType.Custom, False)
        f.FormatColumnGridControl(gvDetalle, "Descripcion", "Descrcipción", 110, DevExpress.Utils.FormatType.Custom, False)

        If dt.Rows.Count = 0 Then
            dt.Rows.Add()
        End If


        txtNombre.Text = dt.Rows(0).Item("Nombre").ToString
        txtDescripcion.Text = dt.Rows(0).Item("Descripcion").ToString
  

    End Sub
    Public Sub Salvar()
        Dim err As New FrmError

        err.ClearError()

        Dim frm As New FrmError
        If txtNombre.Text.Length = 0 Then frm.AddErr("Debe ingresar el código de la labor", 0)
        If txtDescripcion.Text.Length = 0 Then frm.AddErr("Debe ingresar la descripción de la labor", 0)

        If frm.isErr Then
            frm.ShowDialog()

        Else
            dt.Rows(0).Item("Nombre") = txtNombre.Text
            dt.Rows(0).Item("Descripcion") = txtDescripcion.Text


            adp.Update(dt)
            adpAcceso.Update(dtAcceso)

            MsgBox("Registro ingresado exitosamente!", MsgBoxStyle.Information, "Labores")
            LoadPrincipal()
        End If

    End Sub
End Class