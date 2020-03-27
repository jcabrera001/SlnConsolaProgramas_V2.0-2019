Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmRemisionesList
    Private cnx As SqlConnection
    Private user, emp As String
    Private f As New Funciones
    Private adp As SqlDataAdapter
    Private dt As New DataTable

    Public Sub New(cnx As SqlConnection, user As String, emp As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.cnx = cnx
        Me.user = user
        Me.emp = emp
        f.Conexion = cnx
    End Sub
    Private Sub frmRemisiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbOpcImpresion.SelectedIndex = 0
        LoadPrincipal()
        gc.DataSource = dt 'f.getDataTable("spIDF_RemisionesSelect '" & emp & "', '" & caiRemision & "'")
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim frm As New frmRemisionesDetail(cnx, -1, user, emp)
        frm.ShowDialog()
        LoadPrincipal()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim frm As New frmRemisionesDetail(cnx, gv.GetFocusedRowCellValue("RemisionID"), user, emp)
        If IsNumeric(gv.GetFocusedRowCellValue("RemisionID")) Then
            frm.ShowDialog()
            LoadPrincipal()
        Else
            MsgBox("Debe seleccionar un registro!", MsgBoxStyle.Information, "Editar")
        End If

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadPrincipal()
    End Sub
    Private Sub LoadPrincipal()
        dt.Clear()
        adp = New SqlDataAdapter("spIDF_RemisionesSelect '" & emp & "', '" & caiRemision & "'", cnx)
        adp.Fill(dt)
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim CantImprimir As Integer
        Dim nRemisionID As Integer = 0
        Dim nRemisionUltID As Integer = 1
        nRemisionID = gv.GetFocusedRowCellValue("RemisionID")

        Dim nRespuesta As Integer

        'Confirmación de impresión masiva
        If CmbOpcImpresion.SelectedIndex = 0 Then

            'Try
            Imprimir(nRemisionID, 1)
            f.ExecuteQuery("update IDF_Remisiones set estaImpreso =1, usuImpresion ='" & user & "', fechaImpresion = getdate()  where RemisionID = " & nRemisionID) 'Anular el documento.

        Else
            nRespuesta = MsgBox("La impresión masiva es automática, desea continuar?", MsgBoxStyle.YesNo, "Consola de Programas")

            If nRespuesta = 7 Then
                Exit Sub
            End If

            While nRemisionID <> 0 And nRemisionID <> nRemisionUltID

                'Si es CAHSA se imprime 1, si es AYSA 2
                If emp = "01" Then
                    CantImprimir = 1
                ElseIf emp = "20" Then
                    CantImprimir = 2
                Else
                    CantImprimir = 3
                End If

                Imprimir(nRemisionID, CantImprimir)
                nRemisionUltID = nRemisionID


                gv.FocusedRowHandle = gv.FocusedRowHandle + 1
                Try
                    nRemisionID = gv.GetFocusedRowCellValue("RemisionID")
                Catch ex As Exception
                    nRemisionID = 0
                End Try

            End While
        End If

    End Sub

    Private Sub CmbOpcImpresion_Click(sender As Object, e As EventArgs) Handles CmbOpcImpresion.Click

    End Sub

    Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
        If Not IsNumeric(gv.GetFocusedRowCellValue("RemisionID")) Then
            MsgBox("Debe seleccionar un registro", MsgBoxStyle.Information, "Guías de remisión")
            Exit Sub

        End If

        If gv.GetRowCellValue(gv.FocusedRowHandle, "Estado") = 2 Then
            MsgBox("Documento ya se encuentra anulado", MsgBoxStyle.Information, "Guías de remisión")
        Else
            If MsgBox("Seguro que desea anular este documento?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Guías de remisión") = MsgBoxResult.Yes Then
                Dim nRemisionID As Integer
                nRemisionID = gv.GetRowCellValue(gv.FocusedRowHandle, "RemisionID")
                f.ExecuteQuery("update IDF_Remisiones set estado = 2, usuAnulacion ='" & user & "'  where RemisionID = " & nRemisionID) 'Anular el documento.

                MsgBox("Remisión anulada exitosamente!", MsgBoxStyle.Information, "Guías de remisión")

            End If
        End If
    End Sub
    Public Sub Imprimir(ID As Integer, cant As Integer)


        Dim Reporte = "\\AMIGOTS2\Reporteador\Reportes\IDF\FinDFRemision.rpt"

        If cant = 1 Then
            Try
                Dim v As GenVistaPrevia
                v = New GenVistaPrevia
                v.info = "Vista Previa..."
                v.reporte = "\\AMIGOTS2\Reporteador\Reportes\IDF\FinDFRemision"
                v.dataBase = "Finanzas"
                v.user = mdVariablesGlobales.user 'usuario  'user
                v.pass = mdVariablesGlobales.pwd 'password 'pass
                v.server = "amigodb\amigodb"
                v.usuarioSesion = mdVariablesGlobales.user
                v.passwordSesion = mdVariablesGlobales.pwd
                v.parametro = ID
                v.Show()

            Catch ex As Exception
                MsgBox("No se puede imprimir [" & ex.Message & "]", MsgBoxStyle.Critical, "Remisión")
            End Try
        Else
            Dim ocInforme As New ReportDocument
            Try
                ocInforme.Load(Reporte, OpenReportMethod.OpenReportByDefault) '"\\amigots2\Reportes\IDF\FinDFFactsRpt.rpt"
                ocInforme.SetParameterValue("@RemisionID", ID)
                ocInforme.SetDatabaseLogon(mdVariablesGlobales.user, mdVariablesGlobales.pwd, "amigodb\amigodb", "Finanzas")
                ocInforme.PrintToPrinter(cant, False, 0, 0)
                ocInforme.Close()
                ocInforme.Dispose()

            Catch ex As Exception
                MsgBox("No se puede imprimir [" & ex.Message & "]", MsgBoxStyle.Critical, "Remisión")
            End Try
        End If


    End Sub

End Class