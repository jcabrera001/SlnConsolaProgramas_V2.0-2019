Imports System.Data.SqlClient
Public Class AprFacturasSIFrm
    Dim f As New Funciones
    Dim cnx As SqlConnection
    Dim emp As String
    Dim use As String
    Dim pw As String
    Dim apr As Boolean

    Dim adp As SqlDataAdapter
    Dim dt As New DataTable
    Dim prm As SqlParameter
    Public Sub New(cnx As SqlConnection, use As String, pw As String, emp As String, apr As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.cnx = cnx
        f.Conexion = cnx

        Me.emp = emp
        Me.use = use
        Me.pw = pw
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

        'Dim prm As New SqlParameter("aprobadorid", use)
        adp = New SqlDataAdapter("spAprobarFacturasSelect '" & emp & "', " & apr, cnx)
        'adp.UpdateCommand = f.getSQLComand("spAprobarFacturasUpdate", prm)
        adp.Fill(dt)

        f.InitGridControl(gc, gv, dt, "FlaFacturaID,cc,Contabilizada", True)
        f.FormatColumnGridControl(gv, "Seleccionar", "Seleccionar", 60, DevExpress.Utils.FormatType.Custom, True)
        f.FormatColumnGridControl(gv, "Codigo", "Código", 90, DevExpress.Utils.FormatType.Custom, False)
        f.FormatColumnGridControl(gv, "Fecha", "Fecha", 90, DevExpress.Utils.FormatType.Custom, False)
        f.FormatColumnGridControl(gv, "CentroCosto", "Centro Costo", 120, DevExpress.Utils.FormatType.Custom, False)
        f.FormatColumnGridControl(gv, "OTID", "Número de OT", 80, DevExpress.Utils.FormatType.Custom, False)
        f.FormatColumnGridControl(gv, "Creador", "Creador", 90, DevExpress.Utils.FormatType.Custom, False)
        f.FormatColumnGridControl(gv, "Aprobador", "Aprobador", 90, DevExpress.Utils.FormatType.Custom, False)
        f.FormatColumnGridControl(gv, "Total", "Total", 90, DevExpress.Utils.FormatType.Custom, "{0:0,0.00}", False)
    End Sub
    Private Sub CmbActualizarConsulta_Click(sender As Object, e As EventArgs) Handles CmbActualizarConsulta.Click
        LoadPrincipal()
    End Sub
    Private Sub CmbEditar_Click(sender As Object, e As EventArgs) Handles CmbEditar.Click
        Dim cmd As SqlCommand
        If apr Then
            If MsgBox("¿Está seguro que desea desaprobar las facturas seleccionadas?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Desaprobar") = MsgBoxResult.Yes Then
                Try
                    For i As Integer = 0 To gv.RowCount - 1
                        If Not gv.GetRowCellValue(i, "Seleccionar") Then
                            f.Conexion.Open()
                            cmd = New SqlCommand("spAprobarFacturasUpdate  @FlaFacturaID, @Seleccionar, @aprobadorid", f.Conexion)
                            cmd.Parameters.AddWithValue("@FlaFacturaID", gv.GetRowCellValue(i, "FlaFacturaID"))
                            cmd.Parameters.AddWithValue("@Seleccionar", gv.GetRowCellValue(i, "Seleccionar"))
                            cmd.Parameters.AddWithValue("@aprobadorid", use)
                            cmd.ExecuteNonQuery()
                            f.Conexion.Close()
                        End If
                    Next

                    MsgBox("Facturas desaprobadas exitosamente!")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                'adp.Update(dt)

            End If

        Else
            If MsgBox("¿Está seguro que desea aprobar las facturas seleccionadas?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Aprobar") = MsgBoxResult.Yes Then
                Try
                    For i As Integer = 0 To gv.RowCount - 1
                        If gv.GetRowCellValue(i, "Seleccionar") Then
                            f.Conexion.Open()
                            cmd = New SqlCommand("spAprobarFacturasUpdate @FlaFacturaID, @Seleccionar, @aprobadorid", f.Conexion)
                            cmd.Parameters.AddWithValue("@FlaFacturaID", gv.GetRowCellValue(i, "FlaFacturaID"))
                            cmd.Parameters.AddWithValue("@Seleccionar", gv.GetRowCellValue(i, "Seleccionar"))
                            cmd.Parameters.AddWithValue("@aprobadorid", use)
                            cmd.ExecuteNonQuery()
                            f.Conexion.Close()
                        End If
                    Next

                    MsgBox("Facturas Aprobadas exitosamente!")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                'adp.Update(dt)

            End If
        End If

        LoadPrincipal()
    End Sub
End Class