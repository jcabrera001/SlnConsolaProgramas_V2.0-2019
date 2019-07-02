Imports System.Data.SqlClient
Public Class GenGuiasRemisionFrm
    Dim cnx As New SqlConnection
    Dim adp As New SqlDataAdapter
    Dim dt As New DataTable
    Dim cmd As New SqlCommand
    Dim user As String
    Dim time As Integer

    Public Sub New(Usuario As String, Password As String, tiempo As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        cnx = New SqlConnection("Persist Security Info=False;User ID=" & Usuario & ";Password=" & Password & ";Initial Catalog=Finanzas;Server=AMIGODB\AMIGODB")
        user = Usuario
        time = tiempo
    End Sub
    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub GenGuiasRemisionFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        adp = New SqlDataAdapter("select * from Finanzas..IDF_Empresas where TP in('01','20')", cnx)
        adp.Fill(dt)

        cbxEmpresa.Properties.DataSource = dt
        cbxEmpresa.Properties.ValueMember = "TP"
        cbxEmpresa.Properties.DisplayMember = "Description"
        cbxEmpresa.Properties.PopulateColumns()
        cbxEmpresa.Properties.Columns("TP").Visible = False
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Dim adpBusqueda As SqlDataAdapter
        Dim dtBusqueda As New DataTable


        Dim frm As New FrmError
        If IsNothing(cbxEmpresa.EditValue) Then frm.AddErr("Debe seleccionar una empresa", 0)
        If IsNothing(dtpInicio.EditValue) Then frm.AddErr("Debe seleccionar la fecha inicial", 0)
        If IsNothing(dtpFinal.EditValue) Then frm.AddErr("Debe seleccionar la fecha final", 0)
        If txtCantidad.Text.Length = 0 Then frm.AddErr("Debe ingresar la cantidad", 0)

        If frm.isErr Then
            frm.ShowDialog()
            Exit Sub
        Else
            If Not IsNothing(cbxEmpresa.EditValue) Then

                adpBusqueda = New SqlDataAdapter("spValidacionCAI '" & cbxEmpresa.EditValue & "', '" & Format(CDate(dtpFinal.EditValue), "MM/dd/yyyy") & "'", cnx)
                adpBusqueda.Fill(dtBusqueda)

                Dim frmerr As New FrmError(dtBusqueda.DefaultView.Item(0).Item("CAI"))
                If dtBusqueda.DefaultView.Item(0).Item("LimiteActual") = 0 Then frmerr.AddErr("Fecha límite de emisión ha expirado (" & dtBusqueda.DefaultView.Item(0).Item("Limite") & ")", 0)
                If dtBusqueda.DefaultView.Item(0).Item("LimiteIngresado") = 0 Then frmerr.AddErr("Fecha ingresada (" & dtBusqueda.DefaultView.Item(0).Item("FechaIngresada") & "), es mayor a la fecha límite de emisión (" & dtBusqueda.DefaultView.Item(0).Item("Limite") & ")", 0)

                If CInt(dtBusqueda.DefaultView.Item(0).Item("NumActual")) + CInt(txtCantidad.Text) > dtBusqueda.DefaultView.Item(0).Item("NumFinal") Then
                    frmerr.AddErr("Cantidad Solicitada(" & txtCantidad.Text & "), supera la cantidad disponible(" & CInt(dtBusqueda.DefaultView.Item(0).Item("Dis")) & ")", 0)
                End If

                If frmerr.isErr Then
                    frmerr.ShowDialog()
                    Exit Sub
                Else
                    cnx.Open()
                    cmd = New SqlCommand("_IDFGenGR '" & cbxEmpresa.EditValue & "', '', '" & Format(CDate(dtpInicio.EditValue), "MM/dd/yyyy") & "', '" & Format(CDate(dtpFinal.EditValue), "MM/dd/yyyy") & "', " & txtCantidad.Text & ", '" & user & "'", cnx)
                    cmd.CommandTimeout = time
                    cmd.ExecuteNonQuery()

                    MsgBox("Guias generadas exitosamente!" + vbNewLine & " Inicial: " & CInt(dtBusqueda.DefaultView.Item(0).Item("NumActual")) + 1 & vbNewLine &
                           " Final: " & CInt(dtBusqueda.DefaultView.Item(0).Item("NumActual")) + CInt(txtCantidad.Text), MsgBoxStyle.Information, "Guias de Remisión")
                    cnx.Close()
                    Close()
                End If
            End If
        End If
    End Sub
End Class