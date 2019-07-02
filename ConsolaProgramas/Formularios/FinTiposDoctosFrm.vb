Imports LibDAO001

Public Class FinTiposDoctosFrm
    Public strUsuario, strPassword As String
    Public ClsConexion As New ClsConexion
    Public ClsU As New ClsUtilitarios
    Public ClsTiposDoctos As IDF_TiposDoctos
    Public ClsMonedas As IDF_Monedas
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
        cCodigoRegistro = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "TiposDoctoID")

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
        cCodigoRegistro = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "TiposDoctoID")

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
        Dim oRegistro As New IDF_TiposDoctos(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Dim cCodigoRegistro As String
        cCodigoRegistro = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "TiposDoctoID")

        oRegistro.TiposDoctoID = cCodigoRegistro

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

        Dim oRegEdicion As New IDF_TiposDoctos(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        oRegEdicion = IDF_TiposDoctos.Buscar("TiposDoctoID='" & cDato & "'")

        Me.TxtTiposDoctoID.Text = oRegEdicion.TiposDoctoID

        Me.TxtTiposDoctoID.Enabled = False

        Me.TxtDescripcion.Text = oRegEdicion.Descripcion
        Me.TxtDescripcion.Focus()

        Me.TxtMonedaCodigo.EditValue = oRegEdicion.MonedaCodigo
        Me.TxtIDReporte.EditValue = oRegEdicion.idReporte
        Me.ChkEsFacturaxVta.Checked = oRegEdicion.esFacturaxVta
        Me.ChkEsCompRet.Checked = oRegEdicion.esCompret
        Me.ChkEsNCredito.Checked = oRegEdicion.esNCredito
        Me.ChkEsNDebito.Checked = oRegEdicion.esNDebito
        Me.ChkEsGuiaRem.Checked = oRegEdicion.esGuiaRem
        Me.ChkEsFactXCompra.Checked = oRegEdicion.esFactxCompra
        Me.ChkEsFactExp.Checked = oRegEdicion.esFactExp
        Me.ChkTieneDetalle.Checked = oRegEdicion.TieneDetalle
        Me.ChkEsBoletaVta.Checked = oRegEdicion.EsBoletaVta

        Me.XTTEmpaginacion.SelectedTabPage = XTTPagina2
    End Sub

    Public Sub Nuevo()

        Me.LblAccion.Text = "Nuevo registro."
        Me.LblCodigoValor.Text = "<NuevoValor>"
        Me.XTTEmpaginacion.SelectedTabPage = XTTPagina2

        Dim oRegNuevo As New IDF_TiposDoctos(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Me.TxtTiposDoctoID.Text = oRegNuevo.TiposDoctoID

        Me.TxtTiposDoctoID.Enabled = True
        Me.TxtTiposDoctoID.Focus()

        Me.TxtDescripcion.Text = oRegNuevo.Descripcion
        Me.TxtMonedaCodigo.EditValue = oRegNuevo.MonedaCodigo
        Me.TxtIDReporte.EditValue = oRegNuevo.idReporte
        Me.ChkEsFacturaxVta.Checked = oRegNuevo.esFacturaxVta
        Me.ChkEsCompRet.Checked = oRegNuevo.esCompret
        Me.ChkEsNCredito.Checked = oRegNuevo.esNCredito
        Me.ChkEsNDebito.Checked = oRegNuevo.esNDebito
        Me.ChkEsGuiaRem.Checked = oRegNuevo.esGuiaRem
        Me.ChkEsFactXCompra.Checked = oRegNuevo.esFactxCompra
        Me.ChkEsFactExp.Checked = oRegNuevo.esFactExp
        Me.ChkTieneDetalle.Checked = oRegNuevo.TieneDetalle
        Me.ChkEsBoletaVta.Checked = oRegNuevo.EsBoletaVta

    End Sub

    Public Sub CargarRegistros()
        Dim DtDatos As New DataTable
        Dim DtMonedas As New DataTable

        ClsTiposDoctos = New IDF_TiposDoctos(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        ClsMonedas = New IDF_Monedas(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Try
            DtDatos = IDF_TiposDoctos.Tabla()
            Me.GrdConsulta.DataSource = DtDatos

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Tipos de Documentos." & ex.Message, 16)
        End Try

        Try
            DtMonedas = IDF_Monedas.Tabla()
            Me.TxtMonedaCodigo.Properties.DataSource = DtMonedas
            Me.TxtMonedaCodigo.Properties.ValueMember = DtMonedas.Columns(0).ToString()
            Me.TxtMonedaCodigo.Properties.DisplayMember = DtMonedas.Columns(1).ToString()

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Monedas." & ex.Message, 16)
        End Try

    End Sub

    Public Sub Grabar(cAccion As String)
        Dim oRegistro As New IDF_TiposDoctos(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        If Len(Me.TxtTiposDoctoID.Text) = 0 Then
            ClsU.NotaCompleta("Se requiere un código válido.", 16)
            Me.TxtTiposDoctoID.Focus()
            Exit Sub
        End If

        oRegistro.TiposDoctoID = Me.TxtTiposDoctoID.EditValue
        oRegistro.Descripcion = Me.TxtDescripcion.EditValue

        oRegistro.MonedaCodigo = Me.TxtMonedaCodigo.EditValue
        oRegistro.idReporte = Me.TxtIDReporte.EditValue
        oRegistro.esFacturaxVta = Me.ChkEsFacturaxVta.Checked
        oRegistro.esCompret = Me.ChkEsCompRet.Checked
        oRegistro.esNCredito = Me.ChkEsNCredito.Checked
        oRegistro.esNDebito = Me.ChkEsNDebito.Checked
        oRegistro.esGuiaRem = Me.ChkEsGuiaRem.Checked
        oRegistro.esFactxCompra = Me.ChkEsFactXCompra.Checked
        oRegistro.esFactExp = Me.ChkEsFactExp.Checked
        oRegistro.TieneDetalle = Me.ChkTieneDetalle.Checked
        oRegistro.EsBoletaVta = Me.ChkEsBoletaVta.Checked

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