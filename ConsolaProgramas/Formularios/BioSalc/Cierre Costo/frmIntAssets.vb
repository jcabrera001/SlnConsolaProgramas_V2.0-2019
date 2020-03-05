Imports System.Data.SqlClient
Public Class frmIntAssets
    Dim f As New Funciones
    Dim cnx As SqlConnection
    Dim emp As String


    Dim adp As SqlDataAdapter
    Dim dt As New DataTable
    Public Sub New(cnx As SqlConnection, emp As String, empresa As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.cnx = cnx
        f.Conexion = cnx

        Me.emp = emp
    End Sub
    Private Sub frmIntAssets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dt = f.getDataTable("spAssetsSelect")
            f.InitGridControl(gc, gv, dt, "", True)
            f.FormatColumnGridControl(gv, "Selector", "Selector", 60, DevExpress.Utils.FormatType.Custom, True)
            f.FormatColumnGridControl(gv, "Numero", "Numero", 150, DevExpress.Utils.FormatType.Custom, False)
            f.FormatColumnGridControl(gv, "Descripcion", "Descripcion", 150, DevExpress.Utils.FormatType.Custom, False)
            f.FormatColumnGridControl(gv, "Fecha", "Fecha", 100, DevExpress.Utils.FormatType.DateTime, False)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If MsgBox("Está seguro que desea continuar", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Continuar") = MsgBoxResult.Yes Then
            Dim cmd As SqlCommand
            Try
                For i As Integer = 0 To gv.RowCount - 1
                    If gv.GetRowCellValue(i, "Selector") Then
                        f.Conexion.Open()
                        cmd = New SqlCommand("exec spINT_Assets @Partida", f.Conexion)
                        cmd.Parameters.AddWithValue("@Partida", gv.GetRowCellValue(i, "Numero"))
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