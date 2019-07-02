Imports LibDAO001

Public Class FinProductosFrm
    Public strUsuario, strPassword As String
    Public ClsConexion As New ClsConexion
    Public ClsU As New ClsUtilitarios
    Public ClsProductos As IDF_Productos
    Public ClsUnidMeds As IDF_UnidMeds
    Public ClsImpuestos As IDF_Impuestos
    Public ClsCatProductos As IDF_CatProductos
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
        Dim cCodigoProd As String
        cCodigoProd = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "ProdCodigo")

        Try
            Editar(cCodigoProd)
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
        Dim cCodigoProd As String
        cCodigoProd = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "ProdCodigo")

        Try
            Editar(cCodigoProd)
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
        Dim oProdRegistro As New IDF_Productos(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Dim cCodigoProd As String
        cCodigoProd = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "ProdCodigo")

        oProdRegistro.ProdCodigo = cCodigoProd

        Try
            oProdRegistro.Borrar()
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

        Dim oProdEdicion As New IDF_Productos(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        oProdEdicion = IDF_Productos.Buscar("ProdCodigo='" & cDato & "'")

        Me.TxtCodigo.Text = oProdEdicion.ProdCodigo

        Me.TxtCodigo.Enabled = False

        Me.TxtDescripcion.Text = oProdEdicion.Descripcion
        Me.TxtDescripcion.Focus()

        Me.TxtUnidMed.EditValue = oProdEdicion.UnidMed
        Me.TxtPrecio.EditValue = oProdEdicion.Precio
        Me.TxtImptoCodigo.EditValue = oProdEdicion.ImptoCodigo

        Me.XTTEmpaginacion.SelectedTabPage = XTTPagina2
    End Sub

    Public Sub Nuevo()

        Me.LblAccion.Text = "Nuevo registro."
        Me.LblCodigoValor.Text = "<NuevoValor>"
        Me.XTTEmpaginacion.SelectedTabPage = XTTPagina2

        Dim oProdNuevo As New IDF_Productos(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Me.TxtCodigo.Text = oProdNuevo.ProdCodigo

        Me.TxtCodigo.Enabled = True
        Me.TxtCodigo.Focus()

        Me.TxtDescripcion.Text = oProdNuevo.Descripcion
        Me.TxtUnidMed.EditValue = oProdNuevo.UnidMed
        Me.TxtPrecio.EditValue = oProdNuevo.Precio
        Me.TxtImptoCodigo.EditValue = oProdNuevo.ImptoCodigo

    End Sub

    Public Sub CargarRegistros()
        Dim DtDatos As New DataTable
        Dim DtDatosUnidMeds As New DataTable
        Dim DtImpuestos As New DataTable
        Dim DtCatProductos As New DataTable

        ClsProductos = New IDF_Productos(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        ClsUnidMeds = New IDF_UnidMeds(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        ClsImpuestos = New IDF_Impuestos(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        ClsCatProductos = New IDF_CatProductos(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Try
            'DtDatos = IDF_Productos.Tabla()
            DtDatos = ClsProductos.TablaProdCategorias(1)
            Me.GrdConsulta.DataSource = DtDatos

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Productos." & ex.Message, 16)
        End Try

        Try
            DtDatosUnidMeds = IDF_UnidMeds.Tabla()
            TxtUnidMed.Properties.DataSource = DtDatosUnidMeds
            TxtUnidMed.Properties.ValueMember = DtDatosUnidMeds.Columns(0).ToString()
            TxtUnidMed.Properties.DisplayMember = DtDatosUnidMeds.Columns(1).ToString()

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Unidades de Medida." & ex.Message, 16)
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
            DtCatProductos = IDF_CatProductos.Tabla()
            TxtCategoriaID.Properties.DataSource = DtCatProductos
            TxtCategoriaID.Properties.ValueMember = DtCatProductos.Columns(0).ToString()
            TxtCategoriaID.Properties.DisplayMember = DtCatProductos.Columns(1).ToString()
            TxtCategoriaID.EditValue = 2 'CATEGORIA POR OMISION: SERVICIOS
        Catch ex As Exception

        End Try

    End Sub

    Public Sub Grabar(cAccion As String)
        Dim oProdRegistro As New IDF_Productos(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        If Len(Me.TxtCodigo.Text) = 0 Then
            ClsU.NotaCompleta("Se requiere un código válido.", 16)
            Me.TxtCodigo.Focus()
            Exit Sub
        End If

        oProdRegistro.ProdCodigo = Me.TxtCodigo.EditValue
        oProdRegistro.Descripcion = Me.TxtDescripcion.EditValue
        oProdRegistro.UnidMed = Me.TxtUnidMed.EditValue
        oProdRegistro.Precio = Me.TxtPrecio.EditValue
        oProdRegistro.ImptoCodigo = Me.TxtImptoCodigo.EditValue
        oProdRegistro.CategoriaID = Me.TxtCategoriaID.EditValue

        If cAccion = "Edición de datos." Then

            Try
                RESULTADO = oProdRegistro.Actualizar()
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
                RESULTADO = oProdRegistro.Crear()
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

    Private Sub FinProductosFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class