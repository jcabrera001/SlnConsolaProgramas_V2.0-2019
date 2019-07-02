Imports System.Data
Imports System.Data.SqlClient
Public Class frmAddReporteXUsuario
    Dim cnx As New SqlConnection("Persist Security Info=False;User ID=rptuser;Password=MiTo1380;Initial Catalog=Produccion;Server=AMIGODB\AMIGODB")
    Dim dt As New DataTable
    Dim f As New Funciones

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        f.Conexion = cnx
    End Sub
    Private Sub frmAddReporteXUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt = f.getDataTable("Select idusuario, Usuario from J_Usuarios")
        gcUsuarios.DataSource = dt
    End Sub

    Private Sub gvUsuarios_DoubleClick(sender As Object, e As EventArgs) Handles gvUsuarios.DoubleClick
        Dim frm As New frmAddReporteXUsuarioDetail(cnx, CInt(gvUsuarios.GetFocusedRowCellValue("idusuario")), gvUsuarios.GetFocusedRowCellValue("Usuario").ToString)
        frm.ShowDialog()
    End Sub

End Class