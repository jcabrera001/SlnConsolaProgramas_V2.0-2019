Imports System.Data
Imports System.Data.SqlClient
Public Class frmSelectPunto
    Dim usu, pw, empID As String
    Dim PerfilID, rPagIDF, CmbFXC, Tipo As Integer

    Dim cnx As SqlConnection
    Dim adp As SqlDataAdapter
    Dim dt As New DataTable

    Public Sub New(cnx As SqlConnection, usu As String, pw As String, empID As String, Tipo As Integer, PerfilID As Integer, rPagIDF As String, CmbFXC As String)

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
            ElseIf dt.Rows.Count > 1 And Not IsNothing(mdVariablesGlobales.cai) Then 'Si existen más de un CAI disponible y ya se ha seleccionado uno, no lo pide nuevamente.
                Factura(mdVariablesGlobales.cai)
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
        mdVariablesGlobales.cai = cbxPunto.EditValue.ToString()
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
            Dim frm As FinRemisionFrm = New FinRemisionFrm(cnx, cai)
            frm.FuncionInicial(usu, pw, empID, Tipo, PerfilID, rPagIDF, CmbFXC)

            Close()
            frm.ShowDialog()
        Else
            Dim frm As FinDFFactsFrm = New FinDFFactsFrm(usu, pw)
            frm.FuncionInicial(usu, pw, empID, Tipo, PerfilID, rPagIDF, CmbFXC, cai)

            Close()
            frm.ShowDialog()
        End If

        'Dim frmFinDFFacts As FinDFFactsFrm = New FinDFFactsFrm(usu, pw)
        'frmFinDFFacts.FuncionInicial(usu, pw, empID, Tipo, PerfilID, rPagIDF, CmbFXC, cai)

        'Close()
        'frmFinDFFacts.ShowDialog()

    End Sub
End Class