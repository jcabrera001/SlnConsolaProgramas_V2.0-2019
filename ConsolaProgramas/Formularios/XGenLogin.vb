Imports LibDAO001
Public Class XGenLogin
    Public vistas As New ClsVistas
    Public indicador, idUser, idgrupo, idarea, empresaid As Int32
    Public usert, passt, grupo, area, empresat, UsuarioID, XEmpresaID, XEmpresa, DescPerfil As String
    Public dta As New DataTable
    Public dtEmpxU As New DataTable
    Private Sub XGenLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CleanVariables() 'Funcion para limpiar las variables globales.


        'txtUsuario.Focus()
        txtPassword.Text = Nothing

        'Obtener lista de usuarios
        Dim cVariable As String = Environment.UserName.ToString

        cbxUsuarios.EditValue = cVariable
        cbxEmpresasxUsuario.EditValue = cbxEmpresasxUsuario.Properties.GetKeyValue(0)
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

    Public Sub CargarEmpresasxUsuario()
        Dim dtExU As DataTable = New DataTable()
        usert = "rptuser"
        passt = "8tdeosDCtLFo5L2dMZzREw==" 'Pendiente configurar en app.config - Ing. Manuel Ortega - 22/04/2015 - 13:46 pm
        dtExU = vistas.ObtenerEmpresasxUsuario(usert, passt, UsuarioID, 1).Tables(0)



        Dim countTabla As Int16 = dtExU.Rows.Count
        Dim StrEmpresaID As String = dtExU.Rows(0)(0).ToString
        If countTabla = 1 Then
            cbxEmpresasxUsuario.EditValue = StrEmpresaID
        Else
            cbxEmpresasxUsuario.EditValue = ""
        End If
        cbxEmpresasxUsuario.Properties.DataSource = dtExU
        cbxEmpresasxUsuario.Properties.ValueMember = dtExU.Columns(0).ToString()
        cbxEmpresasxUsuario.Properties.DisplayMember = dtExU.Columns(1).ToString()
    End Sub

    Private Sub Validar()
        usert = UsuarioID
        passt = txtPassword.Text
        Dim ok As Integer
        'Dim dgv As New DataGridView
        Try
            dta = vistas.ObtenerInfoUsuarios(usert, passt, 1).Tables(0)
            'idUser = CInt(dta.Rows(0).Item(0))
            ok = dta.Rows.Count + 0
        Catch ex As Exception
            MsgBox("Problema en validacion: " & ex.Message, MsgBoxStyle.Critical, "Acceso a Base de datos")
            ok = -1
        End Try

        If ok = 1 Then
            Try
                'Me.Hide()
                'LlamaPrincipal()
                indicador = 1
                XEmpresaID = cbxEmpresasxUsuario.EditValue.ToString() 'CInt(dta.Rows(0).Item(3))
                XEmpresa = cbxEmpresasxUsuario.Text
                DescPerfil = dta.Rows(0)(15).ToString

                'Agregando valores a las variables Globales
                mdVariablesGlobales.user = usert
                mdVariablesGlobales.pwd = passt
                mdVariablesGlobales.empresa = cbxEmpresasxUsuario.EditValue.ToString()
                Close()
            Catch ex As Exception
                MsgBox("Ocurrio un error al llamar el formulario " & ex.Message, MsgBoxStyle.Critical, "Reporte")
            End Try
        Else
            'MsgBox("Debe ingresar un usuario y una clave valida para poder accesar", MsgBoxStyle.Information, "Usuario Invalido")
            'txtUsuario.Clear()
            txtPassword.Clear()
            'txtUsuario.Focus()

        End If
    End Sub


    Private Sub Cancel_Click(sender As Object, e As EventArgs)
        indicador = 0
        Me.Close()
    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs)
        Validar()
    End Sub

    Private Sub cbxUsuarios_EditValueChanged(sender As Object, e As EventArgs) Handles cbxUsuarios.EditValueChanged
        Try
            UsuarioID = cbxUsuarios.EditValue.ToString()
            'Cargar empresas del usuario
            If String.IsNullOrEmpty(UsuarioID) = False Then
                CargarEmpresasxUsuario()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Validar()
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        indicador = 0
        Me.Close()
    End Sub
End Class