Imports LibDAO001

Public Class PLVLecturasFrm
    Public strUsuario, strPassword, strEmpresa As String
    Public ClsConexion As New ClsConexion
    Public ClsPluviometros As New y_Pluviometros
    Public ClsU As New ClsUtilitarios
    Public ClsLecturas As y_Lecturas
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
        cCodigoRegistro = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "idLectura")

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
        cCodigoRegistro = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "idLectura")

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
        Dim oRegistro As New y_Lecturas(ClsConexion.CadenaProduccion(strUsuario, strPassword))

        Dim cCodigoRegistro As String
        cCodigoRegistro = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "idLectura")

        oRegistro.idLectura = cCodigoRegistro

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

        Dim oRegEdicion As New y_Lecturas(ClsConexion.CadenaProduccion(strUsuario, strPassword))

        oRegEdicion = y_Lecturas.Buscar("IDLectura='" & cDato & "'")

        Me.TxtIDLectura.Text = oRegEdicion.idLectura

        Me.TxtIDLectura.Enabled = False

        Me.TxtIDPluviometro.Text = oRegEdicion.idPluviometro
        Me.TxtIDPluviometro.Focus()

        Me.TxtFecha.EditValue = oRegEdicion.fecha
        Me.TxtIDUsuario.EditValue = oRegEdicion.idUsuario
        Me.TxtEvaporacion.EditValue = oRegEdicion.evaporacion
        Me.TxtLectura.EditValue = oRegEdicion.lectura
        Me.TxtObservaciones.EditValue = oRegEdicion.observacion

        Me.TxtUsuarioCreador.EditValue = oRegEdicion.UsuarioCreador
        Me.TxtUsuarioEditor.EditValue = oRegEdicion.UsuarioEditor

        Me.TxtFechaCreacion.EditValue = oRegEdicion.FechaCreacion
        Me.TxtFechaEdicion.EditValue = oRegEdicion.FechaModificacion

        Me.XTTDatos.SelectedTabPage = XTPBasico
        Me.XTTEmpaginacion.SelectedTabPage = XTTPagina2
    End Sub

    Public Sub Nuevo()

        Me.LblAccion.Text = "Nuevo registro."
        Me.LblCodigoValor.Text = "<NuevoValor>"
        Me.XTTEmpaginacion.SelectedTabPage = XTTPagina2

        Dim oRegNuevo As New y_Lecturas(ClsConexion.CadenaProduccion(strUsuario, strPassword))

        Me.TxtIDLectura.Text = oRegNuevo.idLectura

        Me.TxtIDPluviometro.Text = oRegNuevo.idPluviometro
        Me.TxtIDPluviometro.Focus()

        Me.TxtFecha.EditValue = oRegNuevo.fecha
        Me.TxtLectura.EditValue = oRegNuevo.lectura
        Me.TxtEvaporacion.EditValue = oRegNuevo.evaporacion
        Me.TxtIDUsuario.EditValue = oRegNuevo.idUsuario
        Me.TxtObservaciones.EditValue = oRegNuevo.observacion

        Me.TxtUsuarioCreador.EditValue = oRegNuevo.UsuarioCreador
        Me.TxtUsuarioEditor.EditValue = oRegNuevo.UsuarioEditor

        Me.TxtFechaCreacion.EditValue = oRegNuevo.FechaCreacion
        Me.TxtFechaEdicion.EditValue = oRegNuevo.FechaModificacion

        Me.XTTDatos.SelectedTabPage = XTPBasico
    End Sub

    Public Sub CargarRegistros()
        Dim DtDatos As New DataTable
        Dim DtPluviometros As New DataTable

        ClsLecturas = New y_Lecturas(ClsConexion.CadenaProduccion(strUsuario, strPassword))

        Try
            DtDatos = y_Lecturas.Tabla()
            Me.GrdConsulta.DataSource = DtDatos

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Lecturas." & ex.Message, 16)
        End Try

        ClsPluviometros = New y_Pluviometros(ClsConexion.CadenaProduccion(strUsuario, strPassword))

        Try
            DtPluviometros = y_Pluviometros.Tabla()
            ''Me.GrdIDPluviometro.DataSource = 
            TxtIDPluviometro.Properties.DataSource = DtPluviometros
            TxtIDPluviometro.Properties.ValueMember = DtPluviometros.Columns(0).ToString()
            TxtIDPluviometro.Properties.DisplayMember = DtPluviometros.Columns(1).ToString()
        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Pluviómetros." & ex.Message, 16)
        End Try

    End Sub

    Public Sub Grabar(cAccion As String)
        Dim oRegistro As New y_Lecturas(ClsConexion.CadenaProduccion(strUsuario, strPassword))

        If Len(Me.TxtIDPluviometro.Text) = 0 Then
            ClsU.NotaCompleta("Se requiere una descripción válida.", 16)
            Me.TxtIDPluviometro.Focus()
            Exit Sub
        End If

        oRegistro.idPluviometro = Me.TxtIDPluviometro.EditValue
        oRegistro.fecha = Me.TxtFecha.EditValue

        oRegistro.idUsuario = Me.TxtIDUsuario.EditValue
        oRegistro.lectura = Me.TxtLectura.EditValue
        oRegistro.evaporacion = Me.TxtEvaporacion.EditValue
        oRegistro.observacion = Me.TxtObservaciones.EditValue

        oRegistro.UsuarioCreador = Me.TxtUsuarioCreador.EditValue
        oRegistro.UsuarioEditor = Me.TxtUsuarioEditor.EditValue
        oRegistro.FechaCreacion = Me.TxtFechaCreacion.EditValue
        oRegistro.FechaModificacion = Me.TxtFechaEdicion.EditValue
        oRegistro.idUsuarioModif = Me.TxtUsuarioEditor.EditValue

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