Imports System.Data.SqlClient

Public Class frmParentList
    Private ReadOnly cnx As SqlConnection
    Public ReadOnly Property Usuario As String
    Private Property f As New Funciones
    Private ReadOnly Property dt As DataTable
    Private Property adp As SqlDataAdapter

    Public Sub New(cnx As SqlConnection, Usuario As String, parent As GenPrincipalFrm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.cnx = cnx
        Me.Usuario = Usuario
        f.Conexion = cnx

        Me.MdiParent = parent

    End Sub
    Private Sub frmParentList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTable()
    End Sub

    Public Overridable Sub LoadTable()
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
End Class