Imports LibDAO001
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class CDPFormatosFrm

    Public strUsuario, strPassword, StrEmpresa As String
    Public ClsConexion As New ClsConexion
    Public ClsU As New ClsUtilitarios
    Public ClsAPR As ClsAPR = New ClsAPR()
    Public ClsAccesos As New ClsVistas()
    Public dtOpciones, dtConfigxEmpresa As DataTable
    Public contador, OpcionConsultar, OpcionModificar As Integer
    Public ClsEmpresas As New IDF_Empresas()
    Public ClsFormatos As New CDP_Formatos

    Public Sub FuncionInicial(strU As String, strP As String, StrE As String)
        strUsuario = strU
        strPassword = strP
        StrEmpresa = StrE

    End Sub

    Private Sub CmbActualizarConsulta_Click(sender As Object, e As EventArgs) Handles CmbActualizarConsulta.Click
        CargarConsulta()
    End Sub

    Private Sub CmbEditar_Click(sender As Object, e As EventArgs) Handles CmbEditar.Click
        Me.XTTDatos.SelectedTabPage = Me.XTPBasico

        Dim nFormatoID As String
        nFormatoID = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "FormatoID")

        Try
            Editar(nFormatoID)

        Catch ex As Exception
            ClsU.NotaCompleta("Debe de elegir un registro para editar. " & ex.Message, 16)
        End Try

    End Sub

    Private Sub GrdConsulta_DoubleClick(sender As Object, e As EventArgs) Handles GrdConsulta.DoubleClick
        Dim nFormatoID As Integer
        nFormatoID = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "FormatoID")

        Try
            Editar(nFormatoID)

        Catch ex As Exception
            ClsU.NotaCompleta("Debe de elegir un registro para editar. " & ex.Message, 16)
        End Try
    End Sub

    Private Sub CmbRegresarConsulta_Click(sender As Object, e As EventArgs) Handles CmbRegresarConsulta.Click
        RegresarConsulta()
    End Sub

    Private Sub CmbGrabarNuevo_Click(sender As Object, e As EventArgs) Handles CmbGrabarNuevo.Click
        Grabar(Me.LblAccion.Text)
        Nuevo()

    End Sub

    Private Sub CmbGrabarSalir_Click(sender As Object, e As EventArgs) Handles CmbGrabarSalir.Click
        Grabar(Me.LblAccion.Text)
    End Sub

    Private Sub CDPFormatosFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargarRegistros()
        Personalizar()
    End Sub

    Private Sub CmbImprimir_Click(sender As Object, e As EventArgs) Handles CmbImprimir.Click
        Dim nFormatoID As Integer
        nFormatoID = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "FormatoID")

        Try
            Imprimir(nFormatoID)

        Catch ex As Exception
            ClsU.NotaCompleta("Debe de elegir un registro para imprimir. " & ex.Message, 16)
        End Try
    End Sub

    Private Sub CmbNuevo_Click(sender As Object, e As EventArgs) Handles CmbNuevo.Click
        Nuevo()
    End Sub

    Private Sub CmbEliminar_Click(sender As Object, e As EventArgs) Handles CmbEliminar.Click
        Dim nFormatoID As Integer
        nFormatoID = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "FormatoID")

        Try
            Eliminar(nFormatoID)

        Catch ex As Exception
            ClsU.NotaCompleta("Debe de elegir un registro para eliminar. " & ex.Message, 16)
        End Try
    End Sub
#Region "Procedimientos Definidos por el usuario"
    Public Sub Personalizar()

    End Sub

    Public Sub CargarConsulta()
        Dim DtDatosFormatos As New DataTable

        ClsFormatos = New CDP_Formatos(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Try
            DtDatosFormatos = CDP_Formatos.Tabla()

            Me.GrdConsulta.DataSource = DtDatosFormatos

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Documentos Fuente. " & ex.Message, 16)
        End Try

    End Sub
    Public Sub CargarRegistros()
        Dim DtDatosEmpresas As New DataTable
        Dim DtDatosUsuarioR As New DataTable
        Dim DtDatosUsuarioS As New DataTable

        ClsEmpresas = New IDF_Empresas(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Try
            DtDatosEmpresas = IDF_Empresas.Tabla("Select * From IDF_Empresas Where TP='" & StrEmpresa & "'")
            Me.TxtEmpresaCodigo.Properties.DataSource = DtDatosEmpresas
            Me.TxtEmpresaCodigo.Properties.ValueMember = DtDatosEmpresas.Columns(0).ToString()
            Me.TxtEmpresaCodigo.Properties.DisplayMember = DtDatosEmpresas.Columns(1).ToString()

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Empresas. " & ex.Message, 16)
        End Try

        DtDatosUsuarioR = ClsAccesos.ObtenerInfoUsuarios(strUsuario, strPassword, 3).Tables(0)
        DtDatosUsuarioS = ClsAccesos.ObtenerInfoUsuarios(strUsuario, strPassword, 3).Tables(0)

        Try
            Me.TxtUsuarioResponsable.Properties.DataSource = DtDatosUsuarioR
            Me.TxtUsuarioResponsable.Properties.ValueMember = DtDatosUsuarioR.Columns(0).ToString()
            Me.TxtUsuarioResponsable.Properties.DisplayMember = DtDatosUsuarioR.Columns(1).ToString()

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Usuarios Responsables. " & ex.Message, 16)
        End Try

        Try
            Me.TxtUsuarioSolicitador.Properties.DataSource = DtDatosUsuarioS
            Me.TxtUsuarioSolicitador.Properties.ValueMember = DtDatosUsuarioS.Columns(0).ToString()
            Me.TxtUsuarioSolicitador.Properties.DisplayMember = DtDatosUsuarioS.Columns(1).ToString()

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Usuarios Solicitadores. " & ex.Message, 16)
        End Try
    End Sub

    Public Sub Nuevo()

        Me.LblAccion.Text = "Nuevo registro."
        Me.LblCodigoValor.Text = "<NuevoValor>"
        Me.XTTEmpaginacion.SelectedTabPage = XTTPagina2

        Dim oFormatoNuevo As New CDP_Formatos(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Me.TxtFormatoID.Text = oFormatoNuevo.FormatoID
        Me.TxtEmpresaCodigo.Text = oFormatoNuevo.EmpresaCodigo
        Me.TxtDescripcion.Text = oFormatoNuevo.Descripcion
        Me.ChkAplicaNumeracion.Checked = oFormatoNuevo.AplicaNumeracion
        Me.ChkAplicaCtaBancaria.Checked = oFormatoNuevo.AplicaCtaBancaria
        Me.ChkAplicaImpDespacho.Checked = oFormatoNuevo.AplicaImpDespacho
        Me.TxtEspecificaciones.Text = oFormatoNuevo.Especificaciones
        Me.TxtUtilizacion.Text = oFormatoNuevo.Utilizacion
        Me.TxtUsuarioResponsable.Text = oFormatoNuevo.UsuarioResponsable
        Me.TxtUsuarioSolicitador.Text = oFormatoNuevo.UsuarioSolicitador

    End Sub
    Public Sub Editar(nDato As Integer)

        Me.LblAccion.Text = "Edición de datos."

        Dim oRegistro As New CDP_Formatos(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        oRegistro = CDP_Formatos.Buscar("FormatoID='" & nDato & "'")

        Me.LblCodigoValor.Text = oRegistro.FormatoID

        Me.TxtFormatoID.Text = oRegistro.FormatoID
        Me.TxtFormatoID.Enabled = False

        Me.TxtFormatoID.Text = oRegistro.FormatoID
        Me.TxtEmpresaCodigo.Text = oRegistro.EmpresaCodigo
        Me.TxtDescripcion.Text = oRegistro.Descripcion
        Me.ChkAplicaNumeracion.Checked = oRegistro.AplicaNumeracion
        Me.ChkAplicaCtaBancaria.Checked = oRegistro.AplicaCtaBancaria
        Me.ChkAplicaImpDespacho.Checked = oRegistro.AplicaImpDespacho
        Me.TxtEspecificaciones.Text = oRegistro.Especificaciones
        Me.TxtUtilizacion.Text = oRegistro.Utilizacion
        Me.TxtUsuarioResponsable.Text = oRegistro.UsuarioResponsable
        Me.TxtUsuarioSolicitador.Text = oRegistro.UsuarioSolicitador

        Me.XTTEmpaginacion.SelectedTabPage = XTTPagina2

    End Sub
    Public Sub RegresarConsulta()
        Me.XTTEmpaginacion.SelectedTabPage = XTTPagina1
    End Sub

    Public Sub Grabar(cAccion As String)
        Dim cResultado As String

        Dim oFormatoRegistro As New CDP_Formatos(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        Dim oFormatoRegistroCopia As New CDP_Formatos(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        If Len(Me.TxtFormatoID.Text) = 0 Then
            ClsU.NotaCompleta("Se requiere un identificador de formato válido.", 16)
            Me.TxtFormatoID.Focus()
            Exit Sub
        End If

        oFormatoRegistro.FormatoID = Me.TxtFormatoID.EditValue
        oFormatoRegistro.EmpresaCodigo = Me.TxtEmpresaCodigo.EditValue
        oFormatoRegistro.Descripcion = Me.TxtDescripcion.EditValue
        oFormatoRegistro.AplicaNumeracion = Me.ChkAplicaNumeracion.EditValue
        oFormatoRegistro.AplicaCtaBancaria = Me.ChkAplicaImpDespacho.EditValue
        oFormatoRegistro.AplicaImpDespacho = Me.ChkAplicaImpDespacho.EditValue
        oFormatoRegistro.Especificaciones = Me.TxtEspecificaciones.EditValue
        oFormatoRegistro.Utilizacion = Me.TxtUtilizacion.EditValue
        oFormatoRegistro.UsuarioResponsable = Me.TxtUsuarioResponsable.EditValue
        oFormatoRegistro.UsuarioSolicitador = Me.TxtUsuarioSolicitador.EditValue

        If cAccion = "Edición de datos." Then

            Try

                oFormatoRegistro.UsuarioEditor = strUsuario
                oFormatoRegistro.FechaEdicion = Now()

                'Recuperar el FormatoID para seguir registrando productos bajo ese código
                oFormatoRegistroCopia = CDP_Formatos.Buscar("FormatoID='" & oFormatoRegistro.FormatoID & "'")
                oFormatoRegistro.UsuarioCreador = oFormatoRegistroCopia.UsuarioCreador
                oFormatoRegistro.FechaCreacion = oFormatoRegistroCopia.FechaCreacion

                cResultado = oFormatoRegistro.Actualizar()
                If cResultado Like "ERROR%" Then
                    ClsU.NotaCompleta("No se pudo actualizar el nuevo registro [" & cResultado & "]", 16)
                    Return
                End If

                ClsU.NotaCompleta("Registro actualizado satisfactoriamente!", 64)
            Catch ex As Exception
                ClsU.NotaCompleta("Error en la actualización. " + ex.Message, 16)
            End Try
        End If

        If cAccion = "Nuevo registro." Then
            Try

                oFormatoRegistro.UsuarioCreador = strUsuario
                oFormatoRegistro.FechaCreacion = Now()
                oFormatoRegistro.UsuarioEditor = strUsuario
                oFormatoRegistro.FechaEdicion = Now()

                cResultado = oFormatoRegistro.Crear()

                If cResultado Like "ERROR%" Then
                    ClsU.NotaCompleta("No se pudo crear el nuevo registro [" & cResultado & "]", 16)
                    Return
                End If

            Catch ex As Exception
                ClsU.NotaCompleta("Error en la creación del registro. " + ex.Message, 16)
            End Try
        End If

    End Sub

    Public Sub Imprimir(nFormatoID As Integer)
        Dim cReporte, cServidor, cBDD, cBusqueda As String

        Dim oRegistro As New CDP_Formatos(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        oRegistro = CDP_Formatos.Buscar("FormatoID='" & nFormatoID & "'")

        Dim oPerfilReg As New J_Perfil(ClsConexion.CadenaProduccion(strUsuario, strPassword))
        Dim oRepReg As New J_Reportes(ClsConexion.CadenaProduccion(strUsuario, strPassword))

        oPerfilReg = J_Perfil.Buscar("ID=1")

        cBusqueda = "255"

        oRepReg = J_Reportes.Buscar("idReporte='" & cBusqueda & "'")

        cReporte = "\\" & oPerfilReg.nombrePC & "\" & oPerfilReg.carpetaRaiz & "\" & oRepReg.reporte & ".rpt"
        cServidor = oRepReg.server
        cBDD = oRepReg.jDataBase

        Dim ocInforme As New ReportDocument

        Try
            ocInforme.Load(cReporte, OpenReportMethod.OpenReportByDefault) '"\\amigots2\Reportes\IDF\FinDFFactsRpt.rpt"

            ocInforme.SetParameterValue("@FormatoID", nFormatoID)

            ocInforme.SetDatabaseLogon(strUsuario, strPassword, "amigodb\amigodb", "Finanzas")


            ocInforme.PrintToPrinter(1, False, 0, 0)

        Catch ex As Exception
            ClsU.NotaCompleta("No se puede imprimir [" & ex.Message & "]", 16)
        End Try

    End Sub

    Public Sub Eliminar(nFormatoID As Integer)
        Dim cResultado As String = ""

        Dim oRegistro As New CDP_Formatos(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        oRegistro = CDP_Formatos.Buscar("FormatoID='" & nFormatoID & "'")

        Try
            cResultado = oRegistro.Borrar()

        Catch ex As Exception
            ClsU.NotaCompleta("No se puede eliminar [" & ex.Message & "]", 16)
        End Try

        If cResultado Like "%Satisfact%" Then
            ClsU.NotaCompleta("Eliminado satisfactoriamente", 64)
        End If

    End Sub

#End Region

End Class