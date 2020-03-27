Imports System.Data
Imports System.Data.SqlClient
Public Class frmSelectPunto
    Dim usu, pw, empID As String
    Dim PerfilID, rPagIDF, CmbFXC, Tipo As Integer

    Dim cnx As SqlConnection
    Dim adp As SqlDataAdapter
    Dim dt As New DataTable

    Public Sub New(cnx As SqlConnection, usu As String, emp As String, Tipo As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ' Add any initialization after the InitializeComponent() call.
        Me.cnx = cnx
        Me.usu = usu
        Me.empID = emp
        Me.Tipo = Tipo
        Me.pw = mdVariablesGlobales.pwd
    End Sub
    Public Sub New(cnx As SqlConnection, usu As String, pw As String, Tipo As Integer, empID As String, PerfilID As Integer, rPagIDF As String, CmbFXC As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.cnx = cnx
        Me.Tipo = Tipo
        Me.usu = usu
        Me.pw = pw
        Me.empID = empID
        Me.PerfilID = PerfilID
        Me.rPagIDF = CInt(rPagIDF)
        Me.CmbFXC = CInt(CmbFXC)

    End Sub
    Private Sub frmSelectPunto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            adp = New SqlDataAdapter("spValidarCAIActual '" & empID & "' , " & Tipo, cnx)
            adp.Fill(dt)

            cbxPunto.Properties.DataSource = dt
            cbxPunto.Properties.ValueMember = "CAI"
            cbxPunto.Properties.DisplayMember = "PuntoEmision"
            cbxPunto.Properties.AutoHeight = True

            If dt.Rows.Count = 1 Then 'Si solo existe un CAI, no pide el punto
                Factura(dt.DefaultView.Item(0).Item("CAI").ToString())
                'If Tipo = 4 Then
                '    If dt.Rows.Count > 1 And Not IsNothing(mdVariablesGlobales.caiRemision) Then 'Si existen más de un CAI disponible y ya se ha seleccionado uno, no lo pide nuevamente.
                '        Factura(mdVariablesGlobales.caiRemision)
                '    ElseIf dt.Rows.Count > 1 And Not IsNothing(mdVariablesGlobales.cai) Then
                '        Factura(mdVariablesGlobales.cai)
                '    End If
                'End If
            ElseIf dt.Rows.Count = 0 Then 'dt.Rows.Count > 1 And IsNothing(mdVariablesGlobales.cai) Then
                    MsgBox("Error: El sistema ha detectado que La Fecha Limite de Emisión de estos documentos " &
                        "a caducado. Favor tramitar el nuevo CAI en la Dirección Ejecutiva de Ingresos... " &
                        "Formulario de [" & Text & "] quedara inhabilitado", MsgBoxStyle.Critical, "ERROR")
                Factura("0")
            End If

            'Me.Size = New Size(358, 96)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If Tipo = 4 Then
            mdVariablesGlobales.caiRemision = cbxPunto.EditValue.ToString()
        ElseIf Tipo = 9 Then
            mdVariablesGlobales.caiBolCompra = cbxPunto.EditValue.ToString()
        ElseIf Tipo = 8 Then
            mdVariablesGlobales.caiBolVenta = cbxPunto.EditValue.ToString()
        ElseIf Tipo = 1 Or Tipo = 7 Then
            mdVariablesGlobales.caiFactura = cbxPunto.EditValue.ToString()
        End If

        Me.Close()
        Factura(cbxPunto.EditValue.ToString())

    End Sub
    Private Sub cbxPunto_EditValueChanged(sender As Object, e As EventArgs) Handles cbxPunto.EditValueChanged
        If Not IsNothing(cbxPunto.EditValue) Then
            btnAceptar.Enabled = True
        End If
    End Sub
    Private Sub Factura(cai As String)


        If Tipo = 4 Then
            caiRemision = cai
            Dim frm As New frmRemisionesList(cnx, usu, empID)
            Me.Close()
            frm.ShowDialog()
        ElseIf tipo = 1 Or Tipo = 7 Then
            caiFactura = cai
            Dim frm As FinDFFactsFrm = New FinDFFactsFrm(usu, pw)
            frm.FuncionInicial(usu, pw, empID, Tipo, PerfilID, rPagIDF, CmbFXC, caiFactura)
            Close()
            frm.ShowDialog()
        ElseIf tipo = 8 Then
            caiBolVenta = cai
            Dim frm As FinDFFactsFrm = New FinDFFactsFrm(usu, pw)
            frm.FuncionInicial(usu, pw, empID, Tipo, PerfilID, rPagIDF, CmbFXC, caiBolVenta)
            Close()
            frm.ShowDialog()
        ElseIf tipo = 9 Then
            caiBolCompra = cai
            Dim frm As FinDFFactsFrm = New FinDFFactsFrm(usu, pw)
            frm.FuncionInicial(usu, pw, empID, Tipo, PerfilID, rPagIDF, CmbFXC, caiBolCompra)
            Close()
            frm.ShowDialog()
        End If

        'Dim frmFinDFFacts As FinDFFactsFrm = New FinDFFactsFrm(usu, pw)
        'frmFinDFFacts.FuncionInicial(usu, pw, empID, Tipo, PerfilID, rPagIDF, CmbFXC, cai)

        'Close()
        'frmFinDFFacts.ShowDialog()

    End Sub
End Class