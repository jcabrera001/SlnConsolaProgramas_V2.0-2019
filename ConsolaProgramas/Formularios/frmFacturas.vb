Imports System.Data.SqlClient
Public Class frmFacturas
    Dim usu, pas, emp As String
    Dim f As New Funciones
    Dim cnx As New SqlConnection
    Public Sub New(cnx As SqlConnection, usu As String, pas As String, emp As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.cnx = cnx
        Me.usu = usu
        Me.pas = pas
        Me.emp = emp
        f.Conexion = cnx
    End Sub
    Private Sub frmFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'f.NewTable("")
    End Sub
End Class