Imports LibDAO001
Public Class GenLoginFrm

    Public vistas As New ClsVistas
    Public indicador, idUser, idgrupo, idarea, empresaid As Int32
    Public usert, passt, grupo, area, empresat As String
    Public dta As New DataTable
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Validar()
    End Sub

    Private Sub Validar()
        usert = txtUsuario.Text
        passt = txtPassword.Text
        Dim ok As Integer
        'Dim dgv As New DataGridView
        Try
            dta = vistas.ObtenerInfoUsuarios(usert, passt, 1).Tables(0)
            'idUser = CInt(dta.Rows(0).Item(0))
            ok = dta.Rows.Count
        Catch ex As Exception
            MsgBox("Problema en validacion: " & ex.Message, MsgBoxStyle.Critical, "Acceso a Base de datos")
            ok = -1
        End Try

        If ok = 1 Then
            Try
                'Me.Hide()
                'LlamaPrincipal()
                indicador = 1
                empresaid = CInt(dta.Rows(0).Item(3))
                'idgrupo = CInt(dta.Rows(0).Item(0))
                'grupo = dta.Rows(0).Item(1).ToString
                'idarea = CInt(dta.Rows(0).Item(2))
                'area = dta.Rows(0).Item(3).ToString
                Close()
            Catch ex As Exception
                MsgBox("Ocurrio un error al llamar el formulario " & ex.Message, MsgBoxStyle.Critical, "Reporte")
            End Try
        Else
            'MsgBox("Debe ingresar un usuario y una clave valida para poder accesar", MsgBoxStyle.Information, "Usuario Invalido")
            'txtUsuario.Clear()
            txtPassword.Clear()
            txtUsuario.Focus()

        End If
    End Sub


    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        indicador = 0
        Me.Close()
    End Sub

    Private Sub GenLoginFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsuario.Text = Environment.UserName
        'txtUsuario.Focus()
        ''txtPassword.Clear()

        'Obtener lista de usuarios
        cbxUsuarios.EditValue = txtUsuario.Text
        CargarListaUsuarios()
    End Sub

    Public Sub CargarListaUsuarios()
        Dim dtTabla As DataTable = New DataTable()
        usert = "rptuser"
        passt = "8tdeosDCtLFo5L2dMZzREw==" 'Pendiente configurar en app.config - Ing. Manuel Ortega - 22/04/2015 - 13:46 pm
        dtTabla = vistas.ObtenerInfoUsuarios(usert, passt, 2).Tables(0)
        cbxUsuarios.Properties.DataSource = dtTabla
        cbxUsuarios.Properties.ValueMember = dtTabla.Columns(0).ToString()
        cbxUsuarios.Properties.DisplayMember = dtTabla.Columns(1).ToString()
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = "13" Then
            OK_Click(sender, e)
        End If
    End Sub
End Class
