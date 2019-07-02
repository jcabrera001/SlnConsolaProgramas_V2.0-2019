Imports LibDAO001
Public Class FinItemsFrm
    Public strUsuario, strPassword As String
    Public ClsConexion As New ClsConexion
    Public ClsU As New ClsUtilitarios
    Public ClsItems As IDF_Items
    Public ClsUnidMeds As IDF_UnidMeds
    Public ClsImpuestos As IDF_Impuestos
    Public ClsTiposDocto As IDF_TiposDoctos
    Public ClsRetenciones As IDF_Retenciones
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
        cCodigoRegistro = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "ItemID")

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
        cCodigoRegistro = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "ItemID")

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
        Dim oRegistro As New IDF_Items(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Dim cCodigoRegistro As String
        cCodigoRegistro = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "ItemID")

        oRegistro.ItemID = cCodigoRegistro

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

        Dim oRegEdicion As New IDF_Items(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        oRegEdicion = IDF_Items.Buscar("ItemID='" & cDato & "'")

        Me.TxtItemID.Text = oRegEdicion.ItemID

        Me.TxtItemID.Enabled = False

        Me.TxtDescripcion.Text = oRegEdicion.Descripcion
        Me.TxtDescripcion.Focus()

        Me.TxtTiposDoctoID.EditValue = oRegEdicion.TiposDoctoID
        Me.TxtRetencionID.EditValue = oRegEdicion.RetencionID
        Me.TxtImptoCodigo.EditValue = oRegEdicion.ImptoCodigo

        Me.XTTEmpaginacion.SelectedTabPage = XTTPagina2
    End Sub

    Public Sub Nuevo()

        Me.LblAccion.Text = "Nuevo registro."
        Me.LblCodigoValor.Text = "<NuevoValor>"
        Me.XTTEmpaginacion.SelectedTabPage = XTTPagina2

        Dim oRegNuevo As New IDF_Items(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Me.TxtItemID.Text = oRegNuevo.ItemID

        Me.TxtItemID.Enabled = True
        Me.TxtItemID.Focus()

        Me.TxtDescripcion.Text = oRegNuevo.Descripcion
        Me.TxtTiposDoctoID.EditValue = oRegNuevo.TiposDoctoID
        Me.TxtRetencionID.EditValue = oRegNuevo.RetencionID
        Me.TxtImptoCodigo.EditValue = oRegNuevo.ImptoCodigo

    End Sub

    Public Sub CargarRegistros()
        Dim DtDatos As New DataTable
        Dim DtDatosRetenciones As New DataTable
        Dim DtImpuestos As New DataTable
        Dim DtTiposDocto As New DataTable

        ClsItems = New IDF_Items(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        ClsRetenciones = New IDF_Retenciones(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        ClsImpuestos = New IDF_Impuestos(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        ClsTiposDocto = New IDF_TiposDoctos(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Try
            DtDatos = IDF_Items.Tabla("Select A.*, B.Descripcion As TipoDocto From IDF_Items A Left Join IDF_TiposDoctos B on A.TiposDoctoID=B.TiposDoctoID")
            Me.GrdConsulta.DataSource = DtDatos

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Items." & ex.Message, 16)
        End Try

        Try
            DtDatosRetenciones = IDF_Retenciones.Tabla()
            TxtRetencionID.Properties.DataSource = DtDatosRetenciones
            TxtRetencionID.Properties.ValueMember = DtDatosRetenciones.Columns(0).ToString()
            TxtRetencionID.Properties.DisplayMember = DtDatosRetenciones.Columns(1).ToString()

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Retenciones." & ex.Message, 16)
        End Try

        Try
            DtImpuestos = IDF_Impuestos.Tabla()
            TxtImptoCodigo.Properties.DataSource = DtImpuestos
            TxtImptoCodigo.Properties.ValueMember = DtImpuestos.Columns(0).ToString()
            TxtImptoCodigo.Properties.DisplayMember = DtImpuestos.Columns(1).ToString()

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Impuestos." & ex.Message, 16)
        End Try

        Try
            DtTiposDocto = IDF_TiposDoctos.Tabla()
            TxtTiposDoctoID.Properties.DataSource = DtTiposDocto
            TxtTiposDoctoID.Properties.ValueMember = DtTiposDocto.Columns(0).ToString()
            TxtTiposDoctoID.Properties.DisplayMember = DtTiposDocto.Columns(1).ToString()

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Tipos de Documentos Fuente." & ex.Message, 16)
        End Try

    End Sub

    Public Sub Grabar(cAccion As String)
        Dim oRegistro As New IDF_Items(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        If Len(Me.TxtItemID.Text) = 0 Then
            ClsU.NotaCompleta("Se requiere un código válido.", 16)
            Me.TxtItemID.Focus()
            Exit Sub
        End If

        oRegistro.ItemID = Me.TxtItemID.EditValue
        oRegistro.Descripcion = Me.TxtDescripcion.EditValue
        oRegistro.TiposDoctoID = Me.TxtTiposDoctoID.EditValue
        oRegistro.RetencionID = Me.TxtRetencionID.EditValue
        oRegistro.ImptoCodigo = Me.TxtImptoCodigo.EditValue

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