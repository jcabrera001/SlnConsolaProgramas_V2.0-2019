Imports System.Data
Imports System.Data.SqlClient
Public Class frmAddReporteXUsuarioDetail
    Dim f As New Funciones
    Dim adp As SqlDataAdapter
    Dim dt As New DataTable

    Dim userid As Integer
    Dim cmd As SqlCommand
    Public Sub New(cnx As SqlConnection, userid As Integer, user As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        f.Conexion = cnx
        Me.userid = userid

    End Sub
    Private Sub frmAddReporteXUsuarioDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'f.Conexion.Open()
            'cmd = New SqlCommand("spUsuarioReporteSelect " & userid, f.Conexion)
            'dt.Load(cmd.ExecuteReader())
            adp = New SqlDataAdapter("spUsuarioReporteSelect " & userid, f.Conexion)
            adp.Fill(dt)


            f.InitGridControl(gcReporte, gvReporte, dt, "idReporte", True)
            f.FormatColumnGridControl(gvReporte, "Nombre", "Nombre", 200, DevExpress.Utils.FormatType.Custom, True)
            f.FormatColumnGridControl(gvReporte, "Aplicar", "Aplicar", 30, DevExpress.Utils.FormatType.Custom, True)
            f.FormatColumnGridControl(gvReporte, "Descripcion", "Descripcion", 200, DevExpress.Utils.FormatType.Custom, True)
            'f.Conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Private Sub gvReporte_CellValueChanging(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs)
    '    Dim col As String = gvReporte.FocusedColumn.Name.ToLower

    '    If col = "seleccionar" And CBool(e.Value) Then
    '        f.Conexion.Open()
    '        cmd = New SqlCommand("spUsuarioReporteInsert", f.Conexion)
    '        cmd.Parameters.AddWithValue("idusuario", userid)
    '        cmd.Parameters.AddWithValue("idReporte", gvReporte.GetFocusedRowCellValue("idreporte"))
    '        cmd.ExecuteNonQuery()
    '        f.Conexion.Close()
    '    End If

    'End Sub
End Class