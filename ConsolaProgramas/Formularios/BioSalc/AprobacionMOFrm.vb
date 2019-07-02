Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Columns
Imports System.Globalization
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraSplashScreen

Public Class AprobacionMOFrm
    Dim cnx As New SqlConnection
    Dim f As New Funciones
    Dim exist As Boolean = False

    Dim adp As New SqlDataAdapter
    Dim dt As New DataTable
    Dim time As Integer
    Dim bit As Integer = 0
    Public Sub New(user As String, pwd As String, tiempo As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        cnx = New SqlConnection("Persist Security Info=False;User ID=" & user & ";Password=" & pwd & ";Initial Catalog=Biosalc;Server=AMIGODB\AMIGODB")
        f.Conexion = cnx
        time = tiempo
    End Sub
    Private Sub AprobacionMOFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            f.NewTable("select * from REGIAO_AGR", "sitio")
            f.NewTable("SELECT ContratistaID,Nombre FROM VW_MAE_CONTRATISTAS WHERE 1=1 ORDER BY LEFT(ContratistaID,1) DESC ", "contratista")
            f.NewTable("SELECT CODIGO AS ZafraID,UPPER(NOME) AS Descripcion FROM SAFRAS WHERE CODIGO >= 2018", "zafra")
            f.NewTable("SELECT ZafraID AS Año,SemanaID,NOME AS RangoFecha FROM VW_SEMANAS WHERE ZafraID in (SELECT CODIGO  FROM SAFRAS WHERE CODIGO >= 2018)", "semana")

            f.SetGridLookUpEdit(cmbSitio, f.dsDesarrollo.Tables("sitio"), "CODIGO", "NOME", "CODIGO")
            f.SetGridLookUpEdit(cmbZafra, f.dsDesarrollo.Tables("zafra"), "ZafraID", "Descripcion", "ZafraID")
            f.SetGridLookUpEdit(cmbSemana, f.dsDesarrollo.Tables("semana"), "SemanaID", "RangoFecha")
            f.SetGridLookUpEdit(cmbContratista, f.dsDesarrollo.Tables("contratista"), "ContratistaID", "Nombre")

      
        Catch ex As Exception
            MsgBox("Error al buscar información de la base de datos: " & ex.Message & " " & ex.Source & " " & ex.StackTrace, MsgBoxStyle.Critical, "Atención:")
        End Try
        
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        SplashScreenManager.ShowForm(GetType(WaitForm1))

        Dim Total As Double = 0.0
        If rbAprobar.Checked Then bit = 1

     
        LoadPrincipal()

        If dt.Rows.Count = 0 Then
            MsgBox("No existen registros para la semana seleccionada!", MsgBoxStyle.Exclamation, "Información")
        Else
            f.InitGridControl(gcMostrar, gvMostrar, dt, "", True)
            f.FormatColumnGridControl(gvMostrar, "Selector", "Selecionar", 50, DevExpress.Utils.FormatType.Custom, False)
            f.FormatColumnGridControl(gvMostrar, "DistritoID", "Distrito", 50, DevExpress.Utils.FormatType.Custom, False)
            f.FormatColumnGridControl(gvMostrar, "FincaID", "FincaID", 60, DevExpress.Utils.FormatType.Custom, False)
            f.FormatColumnGridControl(gvMostrar, "Finca", "Finca", 140, DevExpress.Utils.FormatType.Custom, False)
            f.FormatColumnGridControl(gvMostrar, "LoteID", "Lote", 50, DevExpress.Utils.FormatType.Custom, False)
            f.FormatColumnGridControl(gvMostrar, "Total", "Total", 70, DevExpress.Utils.FormatType.Numeric, "{0:0,0.00}", False)



            If dt.Rows.Count > 0 Then
                chkSelecionar.Enabled = True
            End If

            If rbAprobar.Checked Then
                For Each row As DataRow In dt.Rows
                    row.Item("Selector") = 1
                Next
                btnAceptar.Enabled = True
            Else
                btnAceptar.Enabled = False
                For Each row As DataRow In dt.Rows
                    row.Item("Selector") = 0
                Next
                btnAceptar.Enabled = True
            End If

            Calcular()
        End If
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmbZafra_EditValueChanged(sender As Object, e As EventArgs) Handles cmbZafra.EditValueChanged
        f.dsDesarrollo.Tables("semana").DefaultView.RowFilter = "Año = " & cmbZafra.EditValue
        If Not IsNothing(cmbContratista.EditValue) And Not IsNothing(cmbSemana.EditValue) And Not IsNothing(cmbSitio.EditValue) And Not IsNothing(cmbZafra.EditValue) And (rbQuitar.Checked Or rbAprobar.Checked) Then
            btnMostrar.Enabled = True
        End If
    End Sub

    Private Sub rbAprobar_CheckedChanged(sender As Object, e As EventArgs) Handles rbAprobar.CheckedChanged
        If Not IsNothing(cmbContratista.EditValue) And Not IsNothing(cmbSemana.EditValue) And Not IsNothing(cmbSitio.EditValue) And Not IsNothing(cmbZafra.EditValue) And rbAprobar.Checked Then
            btnMostrar.Enabled = True

        End If
        chkSelecionar.Text = "Aprobar Todos"
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If MsgBox("¿Esta seguro que desea continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Anular asientos") = MsgBoxResult.Yes Then
            SplashScreenManager.ShowForm(GetType(WaitForm1))

            Dim cmd As SqlCommand
            Dim cadena As String = ""
            Dim bit As Integer = 0

            If rbAprobar.Checked Then bit = 1

            For Each row As DataRow In dt.Rows
                cadena += row.Item("DistritoID") & "," & row.Item("FincaID") & ","
            Next

            cnx.Open()
            Dim trsql = cnx.BeginTransaction()
            Try
                cmd = New SqlCommand("spWebAprobacion_MO_Contratada '" & cmbSitio.EditValue & "', '" & cmbContratista.EditValue & "', " & cmbZafra.EditValue & ", " & cmbSemana.EditValue & ", " & bit & ", '" & cadena & "'", cnx, trsql)
                cmd.CommandTimeout = time
                cmd.ExecuteNonQuery()

                trsql.Commit()
                cnx.Close()
                MsgBox("Proceso ejecutado exitosamente!")
                LoadPrincipal()
            Catch ex As Exception
                trsql.Rollback()
                cnx.Close()
                MsgBox(ex.Message & " " & trsql.ToString())
            End Try
            SplashScreenManager.CloseForm()
        End If
    End Sub
    Private Sub chkSelecionar_CheckedChanged(sender As Object, e As EventArgs) Handles chkSelecionar.CheckedChanged
    End Sub

    Private Sub rbQuitar_CheckedChanged(sender As Object, e As EventArgs) Handles rbQuitar.CheckedChanged
        If Not IsNothing(cmbContratista.EditValue) And Not IsNothing(cmbSemana.EditValue) And Not IsNothing(cmbSitio.EditValue) And Not IsNothing(cmbZafra.EditValue) And rbQuitar.Checked Then
            btnMostrar.Enabled = True
        End If
        chkSelecionar.Text = "Dasaprobar Todos"
    End Sub

    Private Sub cmbSitio_EditValueChanged(sender As Object, e As EventArgs) Handles cmbSitio.EditValueChanged
        If Not IsNothing(cmbContratista.EditValue) And Not IsNothing(cmbSemana.EditValue) And Not IsNothing(cmbSitio.EditValue) And Not IsNothing(cmbZafra.EditValue) And (rbQuitar.Checked Or rbAprobar.Checked) Then
            btnMostrar.Enabled = True
        End If
    End Sub
    Public Sub LoadPrincipal()
        dt.Clear()
        adp = New SqlDataAdapter("spTotal_MO_ExternoxDistrito_AprobServ '" & cmbSitio.EditValue & "', '" & cmbContratista.EditValue & "', " & cmbZafra.EditValue & ", " & cmbSemana.EditValue & ", " & bit, cnx)
        adp.SelectCommand.CommandTimeout = time
        adp.Fill(dt)
    End Sub


    Private Sub cmbSemana_EditValueChanged(sender As Object, e As EventArgs) Handles cmbSemana.EditValueChanged
        If Not IsNothing(cmbContratista.EditValue) And Not IsNothing(cmbSemana.EditValue) And Not IsNothing(cmbSitio.EditValue) And Not IsNothing(cmbZafra.EditValue) And (rbQuitar.Checked Or rbAprobar.Checked) Then
            btnMostrar.Enabled = True
        End If
    End Sub

    Private Sub cmbContratista_EditValueChanged(sender As Object, e As EventArgs) Handles cmbContratista.EditValueChanged
        If Not IsNothing(cmbContratista.EditValue) And Not IsNothing(cmbSemana.EditValue) And Not IsNothing(cmbSitio.EditValue) And Not IsNothing(cmbZafra.EditValue) And (rbQuitar.Checked Or rbAprobar.Checked) Then
            btnMostrar.Enabled = True
        End If
    End Sub
    Public Sub Calcular()
        Dim Total As Double = 0.0

        If rbAprobar.Checked Then
            For Each row As DataRow In dt.Rows
                If row.Item("Selector") Then
                    Total += row.Item("Total")
                End If
            Next
        Else
            For Each row As DataRow In dt.Rows
                If Not row.Item("Selector") Then
                    Total += row.Item("Total")
                End If
            Next
        End If


        txtTotal.Text = Format(Total, "###,###.0000")
    End Sub

    Private Sub gvMostrar_CellValueChanging(sender As Object, e As CellValueChangedEventArgs) Handles gvMostrar.CellValueChanging
        'Dim Total As Double = 0.0

        'If rbAprobar.Checked Then
        '    Total = 0.0
        '    For Each row As DataRow In dt.Rows
        '        If row.Item("Seleccionar") Then
        '            Total += row.Item("Total")
        '        End If
        '    Next
        'Else
        '    For Each row As DataRow In dt.Rows
        '        Total = 0.0
        '        If row.Item("Seleccionar") Then
        '            Total += row.Item("Total")
        '        End If
        '    Next
        'End If


        'txtTotal.Text = Format(Total, "###,###.0000")
    End Sub
End Class