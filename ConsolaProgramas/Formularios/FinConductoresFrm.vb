Imports LibDAO001

Public Class FinConductoresFrm
    Public strUsuario, strPassword As String
    Public ClsConexion As New ClsConexion
    Public ClsU As New ClsUtilitarios
    Public ClsConductores As IDF_Conductores
    Public RESULTADO As String

    Public Sub FuncionInicial(strU As String, strP As String)
        strUsuario = strU
        strPassword = strP
    End Sub


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.


    End Sub

    Private Sub CmbEditar_Click(sender As Object, e As EventArgs) Handles CmbEditar.Click
        Dim cCodigoRegistro As String
        cCodigoRegistro = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "ConductorID")

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
        cCodigoRegistro = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "ConductorID")

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
        Dim oRegistro As New IDF_Conductores(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Dim cCodigoRegistro As String
        cCodigoRegistro = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "ConductorID")

        oRegistro.ConductorID = cCodigoRegistro

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

        Dim oRegEdicion As New IDF_Conductores(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        oRegEdicion = IDF_Conductores.Buscar("ConductorID='" & cDato & "'")

        Me.TxtConductorID.Text = oRegEdicion.ConductorID

        Me.TxtConductorID.Enabled = False

        Me.TxtDescripcion.Text = oRegEdicion.Descripcion
        Me.TxtDescripcion.Focus()

        Me.TxtIdentificacion.Text = oRegEdicion.Identificacion
        Me.TxtLicencia.Text = oRegEdicion.Licencia
        Me.TxtMarcaPred.Text = oRegEdicion.MarcaPred
        Me.TxtPlacaPred.Text = oRegEdicion.PlacaPred

        Me.XTTEmpaginacion.SelectedTabPage = XTTPagina2
    End Sub

    Public Sub Nuevo()

        Me.LblAccion.Text = "Nuevo registro."
        Me.LblCodigoValor.Text = "<NuevoValor>"
        Me.XTTEmpaginacion.SelectedTabPage = XTTPagina2

        Dim oRegNuevo As New IDF_Conductores(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Me.TxtConductorID.Text = oRegNuevo.ConductorID

        Me.TxtConductorID.Enabled = True
        Me.TxtConductorID.Focus()

        Me.TxtDescripcion.Text = oRegNuevo.Descripcion
        Me.TxtIdentificacion.Text = oRegNuevo.Identificacion
        Me.TxtLicencia.Text = oRegNuevo.Licencia
        Me.TxtMarcaPred.Text = oRegNuevo.MarcaPred
        Me.TxtPlacaPred.Text = oRegNuevo.PlacaPred

    End Sub

    Public Sub CargarRegistros()
        Dim DtDatos As New DataTable

        ClsConductores = New IDF_Conductores(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Try
            DtDatos = IDF_Conductores.Tabla()
            Me.GrdConsulta.DataSource = DtDatos

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Monedas." & ex.Message, 16)
        End Try

    End Sub

    Public Sub Grabar(cAccion As String)
        Dim oRegistro As New IDF_Conductores(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        If Len(Me.TxtConductorID.Text) = 0 Then
            ClsU.NotaCompleta("Se requiere un código válido.", 16)
            Me.TxtConductorID.Focus()
            Exit Sub
        End If

        oRegistro.ConductorID = Me.TxtConductorID.Text
        oRegistro.Descripcion = Me.TxtDescripcion.Text
        oRegistro.Identificacion = Me.TxtIdentificacion.Text
        oRegistro.Licencia = Me.TxtLicencia.Text
        oRegistro.MarcaPred = Me.TxtMarcaPred.Text
        oRegistro.PlacaPred = Me.TxtPlacaPred.Text

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
                ClsU.NotaCompleta("Error en la creación del registro.", 16)
            End Try
        End If

    End Sub

#End Region

End Class