Imports System.Data.SqlClient
Imports DevExpress.XtraSplashScreen
Public Class DuplicadosMOfrm
    Dim cnx As New SqlConnection
    Dim f As New Funciones


    Dim adp As New SqlDataAdapter
    Dim dt As New DataTable
    Dim time As Integer

    Public Sub New(cnx As SqlConnection, time As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.cnx = cnx
        f.Conexion = cnx
        Me.time = time
    End Sub
    Private Sub DuplicadosMOfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.NewTable("SELECT ContratistaID,Nombre FROM VW_MAE_CONTRATISTAS ORDER BY LEFT(ContratistaID,1) DESC ", "contratista")
        f.SetGridLookUpEdit(cmbContratista, f.dsDesarrollo.Tables("contratista"), "ContratistaID", "Nombre")
        dtpDesde.EditValue = Now()
        dtpHasta.EditValue = Now()
    End Sub


    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click


        Try
            SplashScreenManager.ShowForm(GetType(WaitForm1))

            LoadData()

            f.InitGridControl(gc, gv, dt, "ID,idReg,OS,Actividad,Valor", True)
            f.FormatColumnGridControl(gv, "Selector", "Selecionar", 50, DevExpress.Utils.FormatType.Custom, True)
            f.FormatColumnGridControl(gv, "Distrito", "Distrito", 50, DevExpress.Utils.FormatType.Custom, False)
            f.FormatColumnGridControl(gv, "Finca", "Finca", 60, DevExpress.Utils.FormatType.Custom, False)
            f.FormatColumnGridControl(gv, "Lote", "Lote", 50, DevExpress.Utils.FormatType.Custom, False)
            'f.FormatColumnGridControl(gv, "OS", "OS", 40, DevExpress.Utils.FormatType.Custom, False)
            f.FormatColumnGridControl(gv, "Numero", "Numero", 70, DevExpress.Utils.FormatType.Custom, False)
            'f.FormatColumnGridControl(gv, "Actividad", "Actividad", 70, DevExpress.Utils.FormatType.Custom, False)
            f.FormatColumnGridControl(gv, "Horas", "Horas", 70, DevExpress.Utils.FormatType.Custom, False)
            'f.FormatColumnGridControl(gv, "Valor", "Valor", 50, DevExpress.Utils.FormatType.Numeric, "{0:0,0.00}", False)
            f.FormatColumnGridControl(gv, "Total", "Total", 60, DevExpress.Utils.FormatType.Numeric, "{0:0,0.00}", False)

            If dt.Rows.Count > 0 Then
                btnDelete.Enabled = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            SplashScreenManager.CloseForm()
        End Try

    End Sub

    Private Sub cmbContratista_EditValueChanged(sender As Object, e As EventArgs) Handles cmbContratista.EditValueChanged
        btnMostrar.Enabled = True
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("¿Está seguro que desea eliminar los registros seleccionados ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminar") = MsgBoxResult.Yes Then

            Try
                SplashScreenManager.ShowForm(GetType(WaitForm1))
                Dim cmd As SqlCommand

                For Each row As DataRow In dt.Rows
                    If row.Item("Selector") Then
                        cnx.Open()
                        cmd = New SqlCommand("spOs_Mao_Det_DuplicadosDelete '" & row.Item("idReg") & "'", cnx)
                        cmd.CommandTimeout = time
                        cmd.ExecuteNonQuery()
                        cnx.Close()
                    End If
                Next

                MsgBox("Registros eliminados exitosamente!", MsgBoxStyle.Information, "Registros Eliminados")

                LoadData()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                SplashScreenManager.CloseForm()
            End Try
        End If

    End Sub

    Private Sub LoadData()
        dt.Clear()
        adp = New SqlDataAdapter("spOs_Mao_Det_DuplicadosSelect '" & cmbContratista.EditValue & "', '" & CDate(dtpDesde.EditValue) & "', '" & CDate(dtpHasta.EditValue) & "'", cnx)
        adp.Fill(dt)
    End Sub

End Class