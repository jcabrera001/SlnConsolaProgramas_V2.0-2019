Imports System.Data.SqlClient
Imports DevExpress.XtraSplashScreen

Public Class AprobacionMQFrm
    Dim cnx As New SqlConnection
    Dim f As New Funciones
    Dim exist As Boolean = False
    Dim emp As String

    Dim adp As New SqlDataAdapter
    Dim dt As New DataTable
    Dim time As Integer
    Public Sub New(cnx As SqlConnection, user As String, pwd As String, empresa As String, tiempo As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.cnx = cnx
        f.Conexion = cnx
        emp = empresa
        time = tiempo
    End Sub
    Private Sub AprobacionMQFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.NewTable("spMTP_Categoria_MQ '" & emp & "'", "categoria")
        f.NewTable("SELECT CODIGO AS ZafraID,UPPER(NOME) AS Descripcion FROM SAFRAS WHERE CODIGO >= 2018", "zafra")
        f.NewTable("SELECT ZafraID AS Año,SemanaID,NOME AS RangoFecha FROM VW_SEMANAS WHERE ZafraID in (SELECT CODIGO  FROM SAFRAS WHERE CODIGO >= 2018)", "semana")
        f.NewTable("select * from vSitio where CodigoNum ='" & emp & "'", "sitio")

        f.SetGridLookUpEdit(cmbSitio, f.dsDesarrollo.Tables("sitio"), "CodigoNum", "NOME", "CODIGO")
        f.SetGridLookUpEdit(cmbCategoria, f.dsDesarrollo.Tables("categoria"), "ID", "Categoria", "ID")
        f.SetGridLookUpEdit(cmbZafra, f.dsDesarrollo.Tables("zafra"), "ZafraID", "Descripcion", "ZafraID")
        f.SetGridLookUpEdit(cmbSemana, f.dsDesarrollo.Tables("semana"), "SemanaID", "RangoFecha")
    End Sub
    Private Sub rbQuitar_CheckedChanged(sender As Object, e As EventArgs) Handles rbQuitar.CheckedChanged
        If Not IsNothing(cmbSemana.EditValue) And Not IsNothing(cmbCategoria.EditValue) And Not IsNothing(cmbZafra.EditValue) And rbQuitar.Checked Then
            btnMostrar.Enabled = True
        End If
        chkSelecionar.Text = "Dasaprobar Todos"

        If dt.Rows.Count > 0 Then
            dt.DefaultView.RowFilter = "Aprob =" & Not rbAprobar.Checked
            'CalcularTotal()
            chkSelecionar.CheckState = CheckState.Unchecked
        End If
    End Sub
    Private Sub cmbCategoria_EditValueChanged(sender As Object, e As EventArgs) Handles cmbCategoria.EditValueChanged
        If Not IsNothing(cmbSemana.EditValue) And Not IsNothing(cmbCategoria.EditValue) And Not IsNothing(cmbZafra.EditValue) And (rbQuitar.Checked Or rbAprobar.Checked) Then
            btnMostrar.Enabled = True
        End If

        If cmbCategoria.EditValue = "01" Or cmbCategoria.EditValue = "20" Then
            cmbSitio.Enabled = True
        Else
            cmbSitio.Enabled = False
            cmbSitio.EditValue = Nothing
        End If
    End Sub
    Private Sub cmbZafra_EditValueChanged(sender As Object, e As EventArgs) Handles cmbZafra.EditValueChanged
        f.dsDesarrollo.Tables("semana").DefaultView.RowFilter = "Año = " & cmbZafra.EditValue
        If Not IsNothing(cmbSemana.EditValue) And Not IsNothing(cmbCategoria.EditValue) And Not IsNothing(cmbZafra.EditValue) And (rbQuitar.Checked Or rbAprobar.Checked) Then
            btnMostrar.Enabled = True
        End If
    End Sub
    Private Sub rbAprobar_CheckedChanged(sender As Object, e As EventArgs) Handles rbAprobar.CheckedChanged
        If Not IsNothing(cmbSemana.EditValue) And Not IsNothing(cmbCategoria.EditValue) And Not IsNothing(cmbZafra.EditValue) And rbAprobar.Checked Then
            btnMostrar.Enabled = True
            chkSelecionar.Visible = True
        End If

        chkSelecionar.Text = "Aprobar Todos"

        If dt.Rows.Count > 0 Then
            dt.DefaultView.RowFilter = "Aprob =" & Not rbAprobar.Checked
            'CalcularTotal()
            chkSelecionar.CheckState = CheckState.Unchecked
        End If
    End Sub
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click

        SplashScreenManager.ShowForm(GetType(WaitForm1))

        LoadPrincipal()

        If dt.Rows.Count = 0 Then
            MsgBox("No existen registros para la semana seleccionada!", MsgBoxStyle.Exclamation, "Información")
        Else
            f.InitGridControl(gcMostrar, gvMostrar, dt, "", True)
            'f.FormatColumnGridControl(gvMostrar, "Selector", "Seleccionar", 50, DevExpress.Utils.FormatType.Custom, True)
            'f.FormatColumnGridControl(gvMostrar, "Factura", "Factura", 60, DevExpress.Utils.FormatType.Custom, False)
            'f.FormatColumnGridControl(gvMostrar, "Empresa", "Empresa", 60, DevExpress.Utils.FormatType.Custom, False)
            'f.FormatColumnGridControl(gvMostrar, "Total", "Total", 70, DevExpress.Utils.FormatType.Numeric, "{0:0,0.00}", False)
            'f.FormatColumnGridControl(gvMostrar, "TotalAdmon", "Cobrar", 70, DevExpress.Utils.FormatType.Numeric, "{0:0,0.00}", False)
            'f.FormatColumnGridControl(gvMostrar, "Categ", "Categoria", 70, DevExpress.Utils.FormatType.Custom, False)

            chkSelecionar.Checked = False
            btnAceptar.Enabled = True
            dt.DefaultView.RowFilter = "Aprob =" & Not rbAprobar.Checked
            'CalcularTotal()
        End If
        SplashScreenManager.CloseForm()
    End Sub
    Private Sub chkSelecionar_CheckedChanged(sender As Object, e As EventArgs) Handles chkSelecionar.CheckedChanged
        If rbAprobar.Checked And chkSelecionar.Checked Then
            For Each row As DataRow In dt.Rows
                row.Item("Selector") = 1
            Next
        ElseIf rbAprobar.Checked And Not chkSelecionar.Checked Then
            For Each row As DataRow In dt.Rows
                row.Item("Selector") = 0
            Next
        End If

        If rbQuitar.Checked And chkSelecionar.Checked Then
            For Each row As DataRow In dt.Rows
                row.Item("Selector") = 0
            Next
        ElseIf rbQuitar.Checked And Not chkSelecionar.Checked Then
            For Each row As DataRow In dt.Rows
                row.Item("Selector") = 1
            Next
        End If
    End Sub
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If MsgBox("¿Esta seguro que desea continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Anular asientos") = MsgBoxResult.Yes Then
            Dim cmd As SqlCommand
            Dim cadena As String = ""
            Dim bit As Integer = 0
            Dim msg As String

            If rbAprobar.Checked Then
                bit = 1
                msg = "Facturas aprobadas exitosamente!"
                For i As Integer = 0 To dt.DefaultView.Count - 1
                    If dt.DefaultView.Item(i).Item("Selector") Then
                        cadena += dt.DefaultView.Item(i).Item("Factura") & "," & dt.DefaultView.Item(i).Item("Empresa") & ","
                    End If
                Next
            Else
                msg = "Facturas desaprobadas exitosamente!"
                For i As Integer = 0 To dt.DefaultView.Count - 1
                    If Not dt.DefaultView.Item(i).Item("Selector") Then
                        cadena += dt.DefaultView.Item(i).Item("Factura") & "," & dt.DefaultView.Item(i).Item("Empresa") & ","
                    End If
                Next
            End If

            cnx.Open()
            Dim trsql = cnx.BeginTransaction()
            SplashScreenManager.ShowForm(GetType(WaitForm1))

            Try
                cmd = New SqlCommand("spWebAprobacion_MAQ " & cmbZafra.EditValue & ", " & cmbSemana.EditValue & ", " & bit & ", '" & cadena & "'", cnx, trsql)
                cmd.ExecuteNonQuery()

                trsql.Commit()
                cnx.Close()
                MsgBox(msg, MsgBoxStyle.Information, "Facturas")
                LoadPrincipal()
            Catch ex As Exception
                trsql.Rollback()
                cnx.Close()
                MsgBox(ex.Message)
            End Try

            SplashScreenManager.CloseForm()
        End If
    End Sub
    Public Sub CalcularTotal()
        Dim Total As Double = 0.0
        For i As Integer = 0 To dt.DefaultView.Count - 1
            Total += dt.DefaultView.Item(i).Item("Total")
        Next

        txtTotal.Text = Format(Total, "###,###.0000")

        If dt.Rows.Count > 0 Then
            chkSelecionar.Enabled = True
        End If

    End Sub
    Public Sub LoadPrincipal()
        dt.Clear()
        adp.SelectCommand = New SqlCommand("spMTP_ObtenerFacturas_MQ " & cmbZafra.EditValue & ", " & cmbSemana.EditValue & ", '" & cmbCategoria.EditValue & "', '" & IIf(IsNothing(cmbSitio.EditValue), "null", cmbSitio.EditValue) & "'", cnx)
        adp.SelectCommand.CommandTimeout = time
        adp.Fill(dt)
    End Sub
    Private Sub cmbSemana_EditValueChanged(sender As Object, e As EventArgs) Handles cmbSemana.EditValueChanged
        If Not IsNothing(cmbSemana.EditValue) And Not IsNothing(cmbCategoria.EditValue) And Not IsNothing(cmbZafra.EditValue) And (rbQuitar.Checked Or rbAprobar.Checked) Then
            btnMostrar.Enabled = True
        End If
    End Sub

    Private Sub gvMostrar_CellValueChanging(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs)
    End Sub

    Private Sub gvMostrar_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs)
        Dim Total As Double = 0.0

        If rbAprobar.Checked Then
            For i = 0 To dt.Rows.Count
                If gvMostrar.GetRowCellValue(i, "Selector") Then
                    Total += gvMostrar.GetRowCellValue(i, "Total")
                End If
            Next

        Else
            For i = 0 To dt.Rows.Count
                If gvMostrar.GetRowCellValue(i, "Selector") Then
                    Total += gvMostrar.GetRowCellValue(i, "Total")
                End If
            Next
        End If


        txtTotal.Text = Format(Total, "###,###.0000")
    End Sub
End Class