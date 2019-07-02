Imports LibDAO001

Public Class IDFCAIXSdNFrm
    Public strUsuario, strPassword, strEmpresa As String
    Public ClsConexion As New ClsConexion
    Public ClsU As New ClsUtilitarios
    Public ClsCAIXSdN As New IDF_CAIXSdN
    Public ClsSdNs As IDF_SdNs
    Public ClsImpuestos As IDF_Impuestos
    Public RESULTADO As String

    Public Sub FuncionInicial(strU As String, strP As String, StrE As String)
        strUsuario = strU
        strPassword = strP
        strEmpresa = StrE
    End Sub


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.


    End Sub

    Private Sub CmbEditar_Click(sender As Object, e As EventArgs) Handles CmbEditar.Click
        Dim cRegistroCodigo As String
        cRegistroCodigo = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "CAIXSdNID")

        Try
            Editar(cRegistroCodigo)
        Catch ex As Exception
            ClsU.NotaCompleta("Debe de elegir un registro para editar." & ex.Message, 16)
        End Try
    End Sub

    Private Sub CmbNuevo_Click(sender As Object, e As EventArgs) Handles CmbNuevo.Click
        Nuevo()
    End Sub

    Private Sub CmbRegresarConsulta_Click(sender As Object, e As EventArgs) Handles CmbRegresarConsulta.Click
        RegresarConsulta()
    End Sub

    Private Sub CmbActualizarConsulta_Click(sender As Object, e As EventArgs) Handles CmbActualizarConsulta.Click
        CargarRegistros()
    End Sub

    Private Sub GrdConsultaView_DoubleClick(sender As Object, e As EventArgs)
        Dim cRegistroCodigo As String
        cRegistroCodigo = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "CAIXSdNID")

        Try
            Editar(cRegistroCodigo)
        Catch ex As Exception
            ClsU.NotaCompleta("Debe de elegir un registro para editar." & ex.Message, 16)
        End Try
    End Sub

    Private Sub CmbGrabarNuevo_Click(sender As Object, e As EventArgs) Handles CmbGrabarNuevo.Click
        Grabar(Me.LblAccion.Text)
        Nuevo()
        CargarRegistros()
    End Sub

    Private Sub CmbGrabarSalir_Click(sender As Object, e As EventArgs) Handles CmbGrabarSalir.Click
        Grabar(Me.LblAccion.Text)
    End Sub

    Private Sub CmbEliminar_Click(sender As Object, e As EventArgs) Handles CmbEliminar.Click
        Dim cRegistroCodigo As New IDF_Productos(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Dim cCodigoProd As String
        cCodigoProd = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "CAIXSdNID")

        cRegistroCodigo.ProdCodigo = cCodigoProd

        Try
            cRegistroCodigo.Borrar()
        Catch ex As Exception
            ClsU.NotaCompleta("Debe de elegir un registro para eliminar." & ex.Message, 16)
        End Try

    End Sub

    Private Sub IDFCAIXSdNFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            My.Computer.Clipboard.SetText(Me.TxtCAIXSdNID.Text)
        Catch ex As Exception

        End Try

    End Sub

#Region "Procedimientos Definidos por el usuario"
    Public Sub RegresarConsulta()
        Me.XTTEmpaginacion.SelectedTabPage = XTTPagina1
    End Sub

    Public Sub Editar(cDato As String)

        CargarItems()

        Me.LblAccion.Text = "Edición de datos."
        Me.LblCodigoValor.Text = cDato

        Dim oRegistro As New IDF_CAIXSdN(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        oRegistro = IDF_CAIXSdN.Buscar("CAIXSdNID='" & cDato & "'")

        Me.TxtCAIXSdNID.EditValue = oRegistro.CAIXSdNID

        Me.TxtCAIXSdNID.Enabled = False

        Me.TxtSdN.EditValue = oRegistro.SdN
        Me.TxtCAI.EditValue = oRegistro.CAI
        Me.TxtFechaLimite.EditValue = oRegistro.FechaLimite
        Me.TxtRangoIni.EditValue = oRegistro.RangoIni
        Me.TxtRangoFin.EditValue = oRegistro.RangoFin

        Me.TxtSdN.Focus()

        Me.XTTEmpaginacion.SelectedTabPage = XTTPagina2
    End Sub

    Public Sub Nuevo()

        CargarItems()

        Me.LblAccion.Text = "Nuevo registro."
        Me.LblCodigoValor.Text = "<NuevoValor>"
        Me.XTTEmpaginacion.SelectedTabPage = XTTPagina2

        Dim oRegistroNuevo As New IDF_CAIXSdN(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Me.TxtCAIXSdNID.Text = oRegistroNuevo.CAIXSdNID

        Me.TxtCAIXSdNID.Enabled = False
        Me.TxtCAIXSdNID.Focus()

        Me.TxtSdN.Text = oRegistroNuevo.SdN
        Me.TxtCAI.EditValue = oRegistroNuevo.CAI
        Me.TxtFechaLimite.EditValue = Now
        Me.TxtRangoIni.EditValue = oRegistroNuevo.RangoIni
        Me.TxtRangoFin.EditValue = oRegistroNuevo.RangoFin
        'P','R','G','K'
    End Sub

    Public Sub CargarRegistros()
        Dim DtCAIXSdN As New DataTable

        ClsCAIXSdN = New IDF_CAIXSdN(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Try
            DtCAIXSdN = IDF_CAIXSdN.Tabla("Select A.*, B.Description As SdNDescription From IDF_CAIXSdN A Left Join IDF_SdNs B on A.SdN=B.TP")
            Me.GrdConsulta.DataSource = DtCAIXSdN

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar códigos CAI." & ex.Message, 16)
        End Try

    End Sub

    Public Sub CargarItems()
        Dim DtSdNs As New DataTable

        ClsSdNs = New IDF_SdNs(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Try
            DtSdNs = IDF_SdNs.Tabla("SELECT * " & _
                                   "FROM IDF_SdNs " & _
                                   "WHERE LEFT(TP,1) IN (SELECT TipoSdN From idf_TiposDFCXS) " & _
                                   "UNION ALL " & _
                                   "SELECT TP,[Description],[Description],'EMPRESA' " & _
                                   "FROM IDF_Empresas")
            TxtSdN.Properties.DataSource = DtSdNs
            TxtSdN.Properties.ValueMember = DtSdNs.Columns(0).ToString()
            TxtSdN.Properties.DisplayMember = DtSdNs.Columns(1).ToString()

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Socios de Negocios." & ex.Message, 16)
        End Try
    End Sub

    Public Sub Grabar(cAccion As String)
        Dim oRegistro As New IDF_CAIXSdN(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        Dim oRegistroViejo As New IDF_CAIXSdN(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        If Len(Me.TxtCAIXSdNID.Text) = 0 Then
            ClsU.NotaCompleta("Se requiere un código válido.", 16)
            Me.TxtCAIXSdNID.Focus()
            Exit Sub
        End If

        oRegistro.CAIXSdNID = Me.TxtCAIXSdNID.EditValue
        oRegistro.SdN = Me.TxtSdN.EditValue
        oRegistro.CAI = Me.TxtCAI.EditValue
        oRegistro.FechaLimite = Me.TxtFechaLimite.EditValue
        oRegistro.RangoIni = Me.TxtRangoIni.EditValue
        oRegistro.RangoFin = Me.TxtRangoFin.EditValue

        If cAccion = "Edición de datos." Then

            Try
                'Datos del registro anterior
                oRegistroViejo = IDF_CAIXSdN.Buscar("CAIXSdNID='" & oRegistro.CAIXSdNID.ToString & "'")

                oRegistro.UsuEdicion = strUsuario
                oRegistro.FechaEdicion = Now
                oRegistro.UsuCreacion = oRegistroViejo.UsuCreacion
                oRegistro.FechaCreacion = oRegistroViejo.FechaCreacion

                RESULTADO = oRegistro.Actualizar()
                If RESULTADO Like "ERROR%" Then
                    ClsU.NotaCompleta("No se pudo actualizar el nuevo registro [" & RESULTADO & "]", 16)
                    Return
                End If
                ClsU.NotaCompleta("Registro actualizado satisfactoriamente!", 64)
            Catch ex As Exception
                ClsU.NotaCompleta("Error en la actualización." & ex.Message, 16)
            End Try
        End If

        If cAccion = "Nuevo registro." Then
            Try
                oRegistro.UsuCreacion = strUsuario
                oRegistro.FechaCreacion = Now
                oRegistro.UsuEdicion = strUsuario
                oRegistro.FechaEdicion = Now

                RESULTADO = oRegistro.Crear()
                If RESULTADO Like "ERROR%" Then
                    ClsU.NotaCompleta("No se pudo crear el nuevo registro [" & RESULTADO & "]", 16)
                    Return
                End If

                'Recuperar el CAIXSdNID para seguir registrando productos bajo ese código
                oRegistroViejo = IDF_CAIXSdN.Buscar("CAI='" & oRegistro.CAI & "' and SdN='" & oRegistro.SdN & "' and FechaLimite='" & Format(oRegistro.FechaLimite, "MM/dd/yyyy") & "'")
                Me.TxtCAIXSdNID.EditValue = oRegistroViejo.CAIXSdNID
                Editar(oRegistroViejo.CAIXSdNID)

                ClsU.NotaCompleta("Registro creado satisfactoriamente!", 64)
            Catch ex As Exception
                ClsU.NotaCompleta("Error en la creación del registro." & ex.Message, 16)
            End Try
        End If

    End Sub

#End Region

End Class