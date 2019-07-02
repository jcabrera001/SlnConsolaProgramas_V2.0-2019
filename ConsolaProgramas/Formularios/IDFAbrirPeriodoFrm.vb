Imports LibDAO001
Public Class IDFAbrirPeriodoFrm
    Public strUsuario, strPassword, strEmpresa As String
    Public ClsConexion As New ClsConexion
    Public ClsU As New ClsUtilitarios
    Public ClsPeriodosXEmpresa As IDF_PeriodosXEmpresa
    Public RESULTADO As String

    Public Sub FuncionInicial(strU As String, strP As String, strE As String)
        strUsuario = strU
        strPassword = strP
        strEmpresa = strE
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.


    End Sub

    Private Sub CmbEditar_Click(sender As Object, e As EventArgs) Handles CmbEditar.Click
        Dim cCodigoRegistro As String
        cCodigoRegistro = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "PeriodoXEmpresaID")

        Try
            Editar(cCodigoRegistro)
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

    Private Sub GrdConsultaView_DoubleClick(sender As Object, e As EventArgs) Handles GrdConsultaView.DoubleClick
        Dim cCodigoRegistro As String
        cCodigoRegistro = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "PeriodoXEmpresaID")

        Try
            Editar(cCodigoRegistro)
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
        Dim oRegistro As New IDF_PeriodosXEmpresa(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Dim cCodigoRegistro As String
        cCodigoRegistro = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "PeriodoXEmpresaID")

        oRegistro.PeriodoID = cCodigoRegistro

        Try
            oRegistro.Borrar()
        Catch ex As Exception
            ClsU.NotaCompleta("Debe de elegir un registro para eliminar." & ex.Message, 16)
        End Try

    End Sub

#Region "Procedimientos Definidos por el usuario"
    Public Sub RegresarConsulta()
        Me.XTTEmpaginacion.SelectedTabPage = XTTPagina1
    End Sub

    Public Sub Editar(cDato As String)

        Me.LblAccion.Text = "Edición de datos."
        Me.LblCodigoValor.Text = cDato

        Dim oRegEdicion As New IDF_PeriodosXEmpresa(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        oRegEdicion = IDF_PeriodosXEmpresa.Buscar("PeriodoXEmpresaID='" & cDato & "'")

        Me.TxtPeriodoID.Text = oRegEdicion.PeriodoID

        Me.TxtPeriodoID.Enabled = False

        Me.TxtDescripcion.Text = oRegEdicion.PeriodoID
        Me.TxtDescripcion.Focus()

        'Me.TxtDesde.EditValue = oRegEdicion.Desde
        'Me.TxtHasta.EditValue = oRegEdicion.Hasta

        'Me.TxtUsuarioCreador.EditValue = oRegEdicion.UsuarioCreador
        'Me.TxtUsuarioEditor.EditValue = oRegEdicion.UsuarioEditor

        'Me.TxtFechaCreacion.EditValue = oRegEdicion.FechaCreacion
        'Me.TxtFechaEdicion.EditValue = oRegEdicion.FechaEdicion

        Me.XTTDatos.SelectedTabPage = XTPAvanzado
        Me.XTTEmpaginacion.SelectedTabPage = XTTPagina2
    End Sub

    Public Sub Nuevo()

        Me.LblAccion.Text = "Nuevo registro."
        Me.LblCodigoValor.Text = "<NuevoValor>"
        Me.XTTEmpaginacion.SelectedTabPage = XTTPagina2

        Dim oRegNuevo As New IDF_PeriodosXEmpresa(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Me.TxtPeriodoID.Text = oRegNuevo.PeriodoID

        'Me.TxtDescripcion.Text = oRegNuevo.Descripcion
        Me.TxtDescripcion.Focus()

        'Me.TxtDesde.EditValue = oRegNuevo.Desde
        'Me.TxtHasta.EditValue = oRegNuevo.Hasta

        'Me.TxtUsuarioCreador.EditValue = oRegNuevo.UsuarioCreador
        'Me.TxtUsuarioEditor.EditValue = oRegNuevo.UsuarioEditor

        'Me.TxtFechaCreacion.EditValue = oRegNuevo.FechaCreacion
        'Me.TxtFechaEdicion.EditValue = oRegNuevo.FechaEdicion

        Me.XTTDatos.SelectedTabPage = XTPAvanzado
    End Sub

    Public Sub CargarRegistros()
        Dim DtDatos As New DataTable

        ClsPeriodosXEmpresa = New IDF_PeriodosXEmpresa(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Try
            DtDatos = IDF_PeriodosXEmpresa.Tabla()
            Me.GrdConsulta.DataSource = DtDatos

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Periodos." & ex.Message, 16)
        End Try

    End Sub

    Public Sub Grabar(cAccion As String)
        Dim oRegistro As New IDF_PeriodosXEmpresa(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        If Len(Me.TxtDescripcion.Text) = 0 Then
            ClsU.NotaCompleta("Se requiere una descripción válida.", 16)
            Me.TxtDescripcion.Focus()
            Exit Sub
        End If

        'oRegistro.Descripcion = Me.TxtDescripcion.EditValue
        'oRegistro.Desde = Me.TxtDesde.EditValue
        'oRegistro.Hasta = Me.TxtHasta.EditValue
        'oRegistro.UsuarioCreador = Me.TxtUsuarioCreador.EditValue
        'oRegistro.UsuarioEditor = Me.TxtUsuarioEditor.EditValue
        'oRegistro.FechaCreacion = Me.TxtFechaCreacion.EditValue
        'oRegistro.FechaEdicion = Me.TxtFechaEdicion.EditValue

        If cAccion = "Edición de datos." Then

            Try
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
                RESULTADO = oRegistro.Crear()
                If RESULTADO Like "ERROR%" Then
                    ClsU.NotaCompleta("No se pudo crear el nuevo registro [" & RESULTADO & "]", 16)
                    Return
                End If
                ClsU.NotaCompleta("Registro creado satisfactoriamente!", 64)
            Catch ex As Exception
                ClsU.NotaCompleta("Error en la creación del registro." & ex.Message, 16)
            End Try
        End If

    End Sub

#End Region
End Class