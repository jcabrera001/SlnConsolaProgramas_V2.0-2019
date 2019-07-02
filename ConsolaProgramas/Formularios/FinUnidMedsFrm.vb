Imports LibDAO001

Public Class FinUnidMedsFrm
    Public strUsuario, strPassword As String
    Public ClsConexion As New ClsConexion
    Public ClsU As New ClsUtilitarios
    Public ClsProductos As IDF_Productos
    Public ClsUnidMeds As IDF_UnidMeds
    Public ClsImpuestos As IDF_Impuestos

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
        Dim cRegistroCodigo As String
        cRegistroCodigo = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "UnidMedCodigo")

        Try
            Editar(cRegistroCodigo)
        Catch ex As Exception
            ClsU.Nota("Debe de elegir un registro para editar.")
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
        Dim cRegistroCodigo As String
        cRegistroCodigo = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "UnidMedCodigo")

        Try
            Editar(cRegistroCodigo)
        Catch ex As Exception
            ClsU.Nota("Debe de elegir un registro para editar.")
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
        cCodigoProd = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "UnidMedCodigo")

        cRegistroCodigo.ProdCodigo = cCodigoProd

        Try
            cRegistroCodigo.Borrar()
        Catch ex As Exception
            ClsU.Nota("Debe de elegir un registro para eliminar.")
        End Try

    End Sub



#Region "Procedimientos Definidos por el usuario"
    Public Sub RegresarConsulta()
        Me.XTTEmpaginacion.SelectedTabPage = XTTPagina1
    End Sub

    Public Sub Editar(cDato As String)

        Me.LblAccion.Text = "Edición de datos."
        Me.LblCodigoValor.Text = cDato

        Dim oRegistro As New IDF_UnidMeds(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        oRegistro = IDF_UnidMeds.Buscar("UnidMedCodigo='" & cDato & "'")

        Me.TxtUnidMedCodigo.Text = oRegistro.UnidMedCodigo

        Me.TxtUnidMedCodigo.Enabled = False

        Me.TxtDescripcion.Text = oRegistro.Descripcion

        Me.TxtDescripcion.Focus()

        Me.XTTEmpaginacion.SelectedTabPage = XTTPagina2
    End Sub

    Public Sub Nuevo()

        Me.LblAccion.Text = "Nuevo registro."
        Me.LblCodigoValor.Text = "<NuevoValor>"
        Me.XTTEmpaginacion.SelectedTabPage = XTTPagina2

        Dim oRegistroNuevo As New IDF_UnidMeds(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Me.TxtUnidMedCodigo.Text = oRegistroNuevo.UnidMedCodigo

        Me.TxtUnidMedCodigo.Enabled = True
        Me.TxtUnidMedCodigo.Focus()

        Me.TxtDescripcion.Text = oRegistroNuevo.Descripcion

    End Sub

    Public Sub CargarRegistros()
        Dim DtDatosUnidMeds As New DataTable

        ClsUnidMeds = New IDF_UnidMeds(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Try
            DtDatosUnidMeds = IDF_UnidMeds.Tabla()
            Me.GrdConsulta.DataSource = DtDatosUnidMeds

        Catch ex As Exception
            ClsU.Nota("Problemas al consultar Unidades de Medida.")
        End Try
    End Sub

    Public Sub Grabar(cAccion As String)
        Dim oRegistro As New IDF_UnidMeds(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        If Len(Me.TxtUnidMedCodigo.Text) = 0 Then
            ClsU.Nota("Se requiere un código válido.")
            Me.TxtUnidMedCodigo.Focus()
            Exit Sub
        End If

        oRegistro.UnidMedCodigo = Me.TxtUnidMedCodigo.EditValue
        oRegistro.Descripcion = Me.TxtDescripcion.EditValue

        If cAccion = "Edición de datos." Then

            Try
                oRegistro.Actualizar()
                ClsU.Nota("Registro actualizado satisfactoriamente!")
            Catch ex As Exception
                ClsU.Nota("Error en la actualización.")
            End Try
        End If

        If cAccion = "Nuevo registro." Then
            Try
                oRegistro.Crear()
                ClsU.Nota("Registro creado satisfactoriamente!")
            Catch ex As Exception
                ClsU.Nota("Error en la creación del registro.")
            End Try
        End If

    End Sub

#End Region
End Class