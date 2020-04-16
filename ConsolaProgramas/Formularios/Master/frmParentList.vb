Imports System.Data.SqlClient

Public Class frmParentList
    'Protected ReadOnly cnx As SqlConnection
    'Protected ReadOnly Property Usuario As String
    'Protected ReadOnly Property emp As String


    Private ReadOnly Property dt As New DataTable
    Protected Property adaptador As SqlDataAdapter

    'Public Sub New() 'cnx As SqlConnection, Usuario As String, emp As String)
    '    ' This call is required by the designer.
    '    InitializeComponent()

    '    ' Add any initialization after the InitializeComponent() call.
    '    'Me.cnx = cnx
    '    'Me.Usuario = Usuario
    '    'Me.emp = emp

    'End Sub
    Private Sub frmParentList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init()


        adaptador.Fill(dt)
        gc.DataSource = dt
        gv.OptionsBehavior.Editable = False
        gv.OptionsCustomization.AllowFilter = False

        For i As Integer = 0 To gv.Columns.Count - 1
            gv.Columns(i).OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Next



    End Sub

    Public Overridable Sub Adicionar()
    End Sub

    Public Overridable Sub Modificar()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Adicionar()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Modificar()
    End Sub
    Protected Function getID(campo As String) As Integer
        Return gv.GetFocusedRowCellValue(campo)
    End Function
    Public Overridable Sub Init()

    End Sub
End Class