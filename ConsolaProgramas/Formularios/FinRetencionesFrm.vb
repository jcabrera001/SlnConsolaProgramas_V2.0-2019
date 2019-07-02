Imports LibDAO001
Public Class FinRetencionesFrm
    Public strUsuario, strPassword As String
    Public ClsConexion As New ClsConexion
    Public ClsU As New ClsUtilitarios
    Public ClsItems As IDF_Retenciones
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
        cCodigoRegistro = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "RetencionID")

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
        cCodigoRegistro = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "RetencionID")

        Try
            Editar(cCodigoRegistro)
        Catch ex As Exception
            ClsU.NotaCompleta("Debe de elegir un registro para editar." & ex.Message, 16)
        End Try
    End Sub

    Private Sub CmbGrabarNuevo_Click(sender As Object, e As EventArgs) Handles CmbGrabarNuevo.Click
        Dim por As Double = Convert.ToDouble(TxtPorcentaje.Text.Replace("%", ""))
        If por >= 0 Then
            Grabar(Me.LblAccion.Text)
            Nuevo()
            CargarRegistros()
        Else
            MessageBox.Show("Error: El sistema no permite porcentaje menor a cero. Favor verifique", "Atencion:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub CmbGrabarSalir_Click(sender As Object, e As EventArgs) Handles CmbGrabarSalir.Click
        Dim por As Double = Convert.ToDouble(TxtPorcentaje.Text.Replace("%", ""))
        If por >= 0 Then
            Grabar(Me.LblAccion.Text)
        Else
            MessageBox.Show("Error: El sistema no permite porcentaje menor a cero. Favor verifique", "Atencion:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub CmbEliminar_Click(sender As Object, e As EventArgs) Handles CmbEliminar.Click
        Dim oRegistro As New IDF_Retenciones(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Dim cCodigoRegistro As String
        cCodigoRegistro = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "RetencionID")

        oRegistro.RetencionID = cCodigoRegistro

        Try
            oRegistro.Borrar()
            CmbActualizarConsulta_Click(sender, e)
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

        Dim oRegEdicion As New IDF_Retenciones(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        oRegEdicion = IDF_Retenciones.Buscar("RetencionID='" & cDato & "'")

        Me.TxtRetencionID.Text = oRegEdicion.RetencionID

        Me.TxtRetencionID.Enabled = False

        Me.TxtDescripcion.Text = oRegEdicion.Descripcion
        Me.TxtDescripcion.Focus()

        Me.TxtPorcentaje.EditValue = oRegEdicion.Porcentaje

        Me.XTTEmpaginacion.SelectedTabPage = XTTPagina2
    End Sub

    Public Sub Nuevo()

        Me.LblAccion.Text = "Nuevo registro."
        Me.LblCodigoValor.Text = "<NuevoValor>"
        Me.XTTEmpaginacion.SelectedTabPage = XTTPagina2

        Dim oRegNuevo As New IDF_Retenciones(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Me.TxtRetencionID.Text = oRegNuevo.RetencionID

        Me.TxtRetencionID.Enabled = True
        Me.TxtRetencionID.Focus()

        Me.TxtDescripcion.Text = oRegNuevo.Descripcion
        Me.TxtPorcentaje.EditValue = oRegNuevo.Porcentaje

    End Sub

    Public Sub CargarRegistros()
        Dim DtDatos As New DataTable

        ClsRetenciones = New IDF_Retenciones(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Try
            DtDatos = IDF_Retenciones.Tabla()
            Me.GrdConsulta.DataSource = DtDatos

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Retenciones." & ex.Message, 16)
        End Try

    End Sub

    Public Sub Grabar(cAccion As String)
        Dim oRegistro As New IDF_Retenciones(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        If Len(Me.TxtRetencionID.Text) = 0 Then
            ClsU.NotaCompleta("Se requiere un código válido.", 16)
            Me.TxtRetencionID.Focus()
            Exit Sub
        End If

        oRegistro.RetencionID = Me.TxtRetencionID.EditValue
        oRegistro.Descripcion = Me.TxtDescripcion.EditValue
        oRegistro.Porcentaje = Me.TxtPorcentaje.EditValue

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