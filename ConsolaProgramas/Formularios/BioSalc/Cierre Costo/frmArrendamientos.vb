Imports System.Data.SqlClient
Public Class frmArrendamientos
    Dim f As New Funciones
    Dim cnx As SqlConnection
    Dim emp As String


    Dim adp As SqlDataAdapter
    Dim dt As New DataTable
    'Dim prm As SqlParameter
    Public Sub New(cnx As SqlConnection, emp As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.cnx = cnx
        f.Conexion = cnx

        Me.emp = emp
    End Sub
    Private Sub frmArrendamientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dt = f.getDataTable("spArrendamientoSelect '" & emp & "'")
            f.InitGridControl(gc, gv, dt, "PeriodoEmpresaID,PadreID,AnteriorID,PeriodoID", True)
            f.FormatColumnGridControl(gv, "Selector", "Selector", 60, DevExpress.Utils.FormatType.Custom, True)
            f.FormatColumnGridControl(gv, "Firmante", "Firmante", 150, DevExpress.Utils.FormatType.Custom, False, DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains)
            f.FormatColumnGridControl(gv, "FirmaCargo", "FirmaCargo", 150, DevExpress.Utils.FormatType.Custom, False, DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains)
            f.FormatColumnGridControl(gv, "SacosVendidos", "SacosVendidos", 100, DevExpress.Utils.FormatType.Numeric, False, DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains)
            f.FormatColumnGridControl(gv, "EmpresaID", "EmpresaID", 100, DevExpress.Utils.FormatType.Numeric, False, DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains)
            f.FormatColumnGridControl(gv, "PeriodoDescrip", "PeriodoDescrip", 200, DevExpress.Utils.FormatType.Custom, False, DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


  
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If MsgBox("Esta seguro que desea continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Continuar") = MsgBoxResult.Yes Then
            Dim cmd As SqlCommand
            Try
                For i As Integer = 0 To gv.RowCount - 1
                    If gv.GetRowCellValue(i, "Selector") Then
                        f.Conexion.Open()
                        cmd = New SqlCommand("spNewINT_Arrend @PeriodoEmpresaID", f.Conexion)
                        MsgBox(gv.GetRowCellValue(i, "PeriodoEmpresaID"))
                        cmd.Parameters.AddWithValue("@PeriodoEmpresaID", gv.GetRowCellValue(i, "PeriodoEmpresaID"))
                        cmd.ExecuteNonQuery()
                        f.Conexion.Close()
                    End If
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class