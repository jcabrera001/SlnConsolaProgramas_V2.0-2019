Imports System.Data.SqlClient

Public Class frmFacturasProtean
    Private cnx As SqlConnection
    Private ReadOnly Usuario As String
    Dim f As New Funciones
    Private fila As Boolean = False

    Dim dt As New DataTable
    Dim adp As SqlDataAdapter



    Public Sub New(cnx As SqlConnection, Usuario As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.cnx = cnx
        Me.Usuario = Usuario
        f.Conexion = cnx

    End Sub
    Private Sub frmFacturasProtean_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        f.NewTable("spValidarCAIActual '01', 1", "Punto")
        f.SetGridLookUpEdit(cbxPunto, f.dsDesarrollo.Tables("Punto"), "CAI", "PuntoEmision")
    End Sub


    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click

        'Validar que haya al menos un registro seleccionado.
        If Not fila Then
            MsgBox("Ningún registro seleccionado!", MsgBoxStyle.Critical, "Genereación Facturas")
            Exit Sub
        End If

        Try
            cnx.Open()
            Dim cmd As SqlCommand

            For Each row As DataRow In dt.Rows
                If row.Item("Selector") Then
                    cmd = New SqlCommand("spFacturasProteanInsert", cnx)
                    cmd.CommandType = CommandType.StoredProcedure

                    cmd.Parameters.AddWithValue("@des", dtpDesde.EditValue)
                    cmd.Parameters.AddWithValue("@has", dtpHasta.EditValue)
                    cmd.Parameters.AddWithValue("@cai", cbxPunto.EditValue)
                    cmd.Parameters.AddWithValue("@desc", txtDescripcion.EditValue)
                    cmd.Parameters.AddWithValue("@fecha", dtpFecha.EditValue)
                    cmd.Parameters.AddWithValue("@con", row.Item("codSocio").ToString())

                    cmd.ExecuteNonQuery()
                End If
            Next

            MsgBox("Facturas generadas exitosamente!", MsgBoxStyle.Information, "Facturación")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al generar factura")
        Finally
            cnx.Close()
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        adp = New SqlDataAdapter("spFacturasProteanSelect", cnx)
        adp.SelectCommand.CommandType = CommandType.StoredProcedure
        adp.SelectCommand.Parameters.AddWithValue("@des", dtpDesde.EditValue)
        adp.SelectCommand.Parameters.AddWithValue("@has", dtpHasta.EditValue)

        'adp.InsertCommand = f.getSQLComand("spFacturasProteanInsert")

        dt.Clear()
        adp.Fill(dt)
        f.InitGridControl(gc, gv, dt, "", True)

        If dt.Rows.Count > 0 Then
            btnGenerar.Enabled = True
        End If
    End Sub

    Private Sub gv_CellValueChanging(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gv.CellValueChanging
        If e.Value Then
            fila = True
        Else
            fila = False
        End If
    End Sub
End Class