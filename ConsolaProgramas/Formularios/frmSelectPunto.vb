Imports System.Data
Imports System.Data.SqlClient
Public Class frmSelectPunto
    Dim usu, pw, empID As String
    Dim PerfilID, rPagIDF, CmbFXC, Tipo As Integer
    Dim cnx As SqlConnection
    Dim adp As SqlDataAdapter
    Dim dt As New DataTable

    Public Sub New(usu As String, pw As String, empID As String, Tipo As Integer, PerfilID As Integer, rPagIDF As String, CmbFXC As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        cnx = New SqlConnection("Persist Security Info=False;User ID=" & usu & ";Password=" & pw & ";Initial Catalog=Finanzas;Server=AMIGODB\AMIGODB")
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
                MsgBox("Error: El sistema ha detectado que La Fecha Limite de Emision de estos documentos " & _
                        "a caducado. Favor tramitar el nuevo CAI en la Direccion Ejecutiva de Ingresos... " & _
                        "Formulario de [" & Text & "] quedara inhabilitado", MsgBoxStyle.Critical, "ERROR")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        mdVariablesGlobales.cai = cbxPunto.EditValue.ToString()
        Factura(cbxPunto.EditValue.ToString())
        Me.Close()
    End Sub
    Private Sub cbxPunto_EditValueChanged(sender As Object, e As EventArgs) Handles cbxPunto.EditValueChanged
        If Not IsNothing(cbxPunto.EditValue) Then
            btnAceptar.Enabled = True
        End If
    End Sub
    Private Sub Factura(cai As String)
        Dim frmFinDFFacts As FinDFFactsFrm = New FinDFFactsFrm
        frmFinDFFacts.FuncionInicial(usu, pw, empID, Tipo, PerfilID, rPagIDF, CmbFXC, cai)
        frmFinDFFacts.ShowDialog()

        Close()
    End Sub
End Class