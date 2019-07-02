Imports LibDAO001

Public Class IDFImportFrm
    Public strUsuario, strPassword, strEmpresa As String
    Public ClsConexion As New ClsConexion
    Public ClsU As New ClsUtilitarios
    Public ClsSdNs As IDF_SdNs
    Public ClsImport As IDF_Import
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
        cRegistroCodigo = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "ImportID")

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
        cRegistroCodigo = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "ImportID")

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
        Dim resultado_mensaje As String = VerificarCamposObligatorios()
        If resultado_mensaje.Equals("1") Then
            Grabar(Me.LblAccion.Text)
        Else
            ClsU.NotaCompleta(resultado_mensaje, 16)
        End If
    End Sub

    Public Function VerificarCamposObligatorios() As String
        Dim strMensaje As String = ""
        If txtAnioAReportar.EditValue = 0 Then
            strMensaje = "Error en campo de texto Año a Reportar, valor = 0. Verifique o intente de nuevo"
        Else
            strMensaje = "1"
        End If

        Return strMensaje
    End Function

    Private Sub CmbEliminar_Click(sender As Object, e As EventArgs) Handles CmbEliminar.Click
        Dim cRegistroCodigo As New IDF_Productos(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Dim cCodigoProd As String
        cCodigoProd = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "ImportID")

        cRegistroCodigo.ProdCodigo = cCodigoProd

        Try
            cRegistroCodigo.Borrar()
        Catch ex As Exception
            ClsU.NotaCompleta("Debe de elegir un registro para eliminar." & ex.Message, 16)
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

        Dim oRegistro As New IDF_Import(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        oRegistro = IDF_Import.Buscar("ImportID='" & cDato & "'")

        Me.TxtImportID.EditValue = oRegistro.ImportID

        Me.TxtImportID.Enabled = False

        Me.TxtSdN.EditValue = oRegistro.SdN
        Me.TxtNumDUA.EditValue = oRegistro.NumDua
        Me.TxtNumLiq.EditValue = oRegistro.NumLiq
        Me.TxtExoNum.EditValue = oRegistro.ExoNum
        Me.TxtExoFec.EditValue = oRegistro.ExoFec
        Me.TxtFecha.EditValue = oRegistro.Fecha

        Me.txtAnioAReportar.EditValue = oRegistro.AnioAReportar
        Dim Mes As Integer = oRegistro.MesAReportar - 1
        If Mes < 0 Then
            Mes = 0
        End If
        Me.cbxMesAReportar.SelectedIndex = Mes

        Me.TxtSdN.Focus()

        Me.XTTEmpaginacion.SelectedTabPage = XTTPagina2
    End Sub

    Public Sub Nuevo()

        CargarItems()

        Me.LblAccion.Text = "Nuevo registro."
        Me.LblCodigoValor.Text = "<NuevoValor>"
        Me.XTTEmpaginacion.SelectedTabPage = XTTPagina2

        Dim oRegistroNuevo As New IDF_Import(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Me.TxtImportID.Text = oRegistroNuevo.ImportID

        Me.TxtImportID.Enabled = False
        Me.TxtImportID.Focus()

        Me.TxtSdN.Text = oRegistroNuevo.SdN
        Me.TxtFecha.EditValue = Now
        Me.TxtNumDUA.EditValue = oRegistroNuevo.NumDua
        Me.TxtNumLiq.EditValue = oRegistroNuevo.NumLiq
        Me.TxtExoNum.EditValue = oRegistroNuevo.ExoNum
        Me.TxtExoFec.EditValue = oRegistroNuevo.ExoFec

        'Inicializar año y mes a reportar
        txtAnioAReportar.EditValue = Today.Year
        cbxMesAReportar.SelectedIndex = Today.Month - 1

    End Sub

    Public Sub CargarRegistros()
        Dim DtImport As New DataTable

        ClsImport = New IDF_Import(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Try
            DtImport = IDF_Import.Tabla("Select A.*, B.Description As SdNDescrip From IDF_Import A Left Join IDF_SdNs B on A.SdN = B.TP Where A.EmpresaCodigo='" & strEmpresa & "'")
            Me.GrdConsulta.DataSource = DtImport

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar códigos CAI." & ex.Message, 16)
        End Try

    End Sub

    Public Sub CargarItems()
        Dim DtSdNs As New DataTable

        ClsSdNs = New IDF_SdNs(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Try
            DtSdNs = IDF_SdNs.Tabla("Select * From IDF_SdNs Where Left(TP,1) in ('P','R','G')")
            TxtSdN.Properties.DataSource = DtSdNs
            TxtSdN.Properties.ValueMember = DtSdNs.Columns(0).ToString()
            TxtSdN.Properties.DisplayMember = DtSdNs.Columns(1).ToString()

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Socios de Negocios." & ex.Message, 16)
        End Try
    End Sub

    Public Sub Grabar(cAccion As String)
        Dim oRegistro As New IDF_Import(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        Dim oRegistroViejo As New IDF_Import(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        If Len(Me.TxtImportID.Text) = 0 Then
            ClsU.NotaCompleta("Se requiere un código válido.", 16)
            Me.TxtImportID.Focus()
            Exit Sub
        End If

        oRegistro.ImportID = Me.TxtImportID.EditValue
        oRegistro.SdN = Me.TxtSdN.EditValue
        oRegistro.Fecha = Me.TxtFecha.EditValue
        oRegistro.NumDua = Me.TxtNumDUA.EditValue
        oRegistro.NumLiq = Me.TxtNumLiq.EditValue
        oRegistro.ExoNum = Me.TxtExoNum.EditValue
        oRegistro.ExoFec = Me.TxtExoFec.EditValue
        oRegistro.AnioAReportar = Me.txtAnioAReportar.EditValue
        Dim Mes As Integer = Me.cbxMesAReportar.SelectedIndex + 1
        oRegistro.MesAReportar = Mes

        If cAccion = "Edición de datos." Then

            Try
                'Datos del registro anterior
                oRegistroViejo = IDF_Import.Buscar("ImportID='" & oRegistro.ImportID.ToString & "'")

                oRegistro.EmpresaCodigo = oRegistroViejo.EmpresaCodigo
                oRegistro.UsuEdicion = strUsuario
                oRegistro.FechaEdicion = Now
                oRegistro.UsuCreacion = oRegistroViejo.UsuCreacion
                oRegistro.FechaCreacion = oRegistroViejo.FechaCreacion

                RESULTADO = oRegistro.Actualizar()

                Dim xResultado As Integer = InStr(RESULTADO, "ERROR", CompareMethod.Text)
                If xResultado > 0 Then
                    ClsU.NotaCompleta("No se pudo actualizar el nuevo registro [" & RESULTADO & "]", 16)
                    Return
                End If

                'If RESULTADO Like "%ERROR%" Then
                '    ClsU.NotaCompleta("No se pudo actualizar el nuevo registro [" & RESULTADO & "]", 16)
                '    Return
                'End If
                ClsU.NotaCompleta("Registro actualizado satisfactoriamente!", 64)
            Catch ex As Exception
                ClsU.NotaCompleta("Error en la actualización." & ex.Message, 16)
            End Try
        End If

        If cAccion = "Nuevo registro." Then
            Try

                oRegistro.EmpresaCodigo = strEmpresa
                oRegistro.UsuCreacion = strUsuario
                oRegistro.FechaCreacion = Now
                oRegistro.UsuEdicion = strUsuario
                oRegistro.FechaEdicion = Now

                RESULTADO = oRegistro.Crear()
                'If RESULTADO Like "ERROR%" Then
                '    ClsU.NotaCompleta("No se pudo crear el nuevo registro [" & RESULTADO & "]", 16)
                '    Return
                'End If
                Dim xResultado As Integer = InStr(RESULTADO, "ERROR", CompareMethod.Text)
                If xResultado > 0 Then
                    ClsU.NotaCompleta("No se pudo crear el nuevo registro [" & RESULTADO & "]", 16)
                    Return
                End If

                'Recuperar el ImportID para seguir registrando productos bajo ese código
                oRegistroViejo = IDF_Import.Buscar("NumDUA='" & oRegistro.NumDua & "' and SdN='" & oRegistro.SdN & "' and NumLiq='" & oRegistro.NumLiq & "'")
                Me.TxtImportID.EditValue = oRegistroViejo.ImportID
                Editar(oRegistroViejo.ImportID)

                ClsU.NotaCompleta("Registro creado satisfactoriamente!", 64)
            Catch ex As Exception
                ClsU.NotaCompleta("Error en la creación del registro." & ex.Message, 16)
            End Try
        End If

    End Sub

#End Region


End Class