Imports System.Data.SqlClient
Public Class AprFacturasSIFrm
    Dim f As New Funciones
    Dim cnx As SqlConnection
    Private ReadOnly emp As String
    Private ReadOnly use As String
    Dim apr As Boolean

    Dim adp As SqlDataAdapter
    Dim dt As New DataTable

    Public Sub New(cnx As SqlConnection, use As String, emp As String, apr As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.cnx = cnx
        f.Conexion = cnx

        Me.emp = emp
        Me.use = use
        Me.apr = apr

        If apr Then
            Me.Text = "Desaprobar Facturas"
        Else
            Me.Text = "Aprobar Facturas"
        End If
    End Sub
    Private Sub AprFacturasSIFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPrincipal()
    End Sub
    Public Sub LoadPrincipal()
        dt.Clear()

        adp = New SqlDataAdapter("spAprobarFacturasSelect '" & emp & "', " & apr, cnx)
        adp.Fill(dt)

        f.InitGridControl(gc, gv, dt, "FlaFacturaID,cc,Contabilizada", True)
        'f.FormatColumnGridControl(gv, "Seleccionar", "Seleccionar", 60, DevExpress.Utils.FormatType.Custom, True)
        'f.FormatColumnGridControl(gv, "Codigo", "Código", 90, DevExpress.Utils.FormatType.Custom, False)
        'f.FormatColumnGridControl(gv, "Fecha", "Fecha", 90, DevExpress.Utils.FormatType.Custom, False)
        'f.FormatColumnGridControl(gv, "CentroCosto", "Centro Costo", 120, DevExpress.Utils.FormatType.Custom, False)
        'f.FormatColumnGridControl(gv, "OTID", "Número de OT", 80, DevExpress.Utils.FormatType.Custom, False)
        'f.FormatColumnGridControl(gv, "Creador", "Creador", 90, DevExpress.Utils.FormatType.Custom, False)
        'f.FormatColumnGridControl(gv, "Aprobador", "Aprobador", 90, DevExpress.Utils.FormatType.Custom, False)
        'f.FormatColumnGridControl(gv, "Total", "Total", 90, DevExpress.Utils.FormatType.Custom, "{0:0,0.00}", False)
    End Sub
    Private Sub CmbActualizarConsulta_Click(sender As Object, e As EventArgs) Handles CmbActualizarConsulta.Click
        LoadPrincipal()
    End Sub
    Private Sub CmbEditar_Click(sender As Object, e As EventArgs) Handles CmbEditar.Click

        If apr Then
            If MsgBox("¿Está seguro que desea desaprobar las facturas seleccionadas?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Desaprobar") = MsgBoxResult.Yes Then
                Try
                    For i As Integer = 0 To gv.RowCount - 1
                        If Not gv.GetRowCellValue(i, "Seleccionar") Then
                            ExecuteQuery(gv.GetRowCellValue(i, "FlaFacturaID"), gv.GetRowCellValue(i, "Seleccionar"))
                        End If
                    Next

                    MsgBox("Facturas desaprobadas exitosamente!")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

        Else
            If MsgBox("¿Está seguro que desea aprobar las facturas seleccionadas?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Aprobar") = MsgBoxResult.Yes Then
                Try
                    For i As Integer = 0 To gv.RowCount - 1
                        If gv.GetRowCellValue(i, "Seleccionar") Then
                            ExecuteQuery(gv.GetRowCellValue(i, "FlaFacturaID"), gv.GetRowCellValue(i, "Seleccionar"))
                        End If
                    Next

                    MsgBox("Facturas Aprobadas exitosamente!")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If

        LoadPrincipal()
    End Sub
    Private Sub ExecuteQuery(ID As Integer, opcion As Integer)
        Dim cmd As SqlCommand
        cnx.Open()
        cmd = New SqlCommand("spAprobarFacturasUpdate @FlaFacturaID, @Seleccionar, @aprobadorid", f.Conexion)
        cmd.Parameters.AddWithValue("@FlaFacturaID", ID)
        cmd.Parameters.AddWithValue("@Seleccionar", opcion)
        cmd.Parameters.AddWithValue("@aprobadorid", use)
        cmd.ExecuteNonQuery()
        cnx.Close()
    End Sub
End Class