Imports LibDAO001
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient

Public Class FinRemisionFrm
    Public strUsuario, strPassword, StrEmpresa As String
    Public IntTipoDocto As Integer
    Public ClsConexion As New ClsConexion
    Public ClsU As New ClsUtilitarios
    Public ClsRemisiones As IDF_Remisiones
    Public ClsProductos As IDF_Productos
    Public ClsUnidMeds As IDF_UnidMeds
    Public ClsClientes As IDF_Clientes
    Public ClsEmpresas As IDF_Empresas
    Public ClsTiposDoctos As IDF_TiposDoctos
    Public ClsProdXRem As IDF_ProdxRem
    Public ClsAPR As ClsAPR = New ClsAPR()
    Public ClsConductores As IDF_Conductores
    Public ClsTransportistas As IDF_Transportistas
    Public ClsDFFacts As IDF_DFFacts
    Public ClsAccesos As ClsVistas = Nothing
    Public ClsVista As ClsVistas = Nothing
    Public ClsBioSalc As ClsBioSalc
    Public EstadoPesajeBioSalc As String
    Public dtOpciones, dtConfigxEmpresa, dtIDF_ConfigEmp002, dtDetalleProductosBioSalc, dtOrdenPesoTaraBioSalc As DataTable
    Public PesoNetoKG, PesoTaraKG, PesoBrutoKG As Double
    Public PesoTaraEmpaque, PesoNetoLbs, PesoTaraLbs, PesoBrutoLbs As Double
    Public contador, OpcionConsultar, OpcionModificar, AplicaCancelarItem As Integer
    Public msgResultado As MsgBoxResult = New MsgBoxResult()
    Public DialogoResult As DialogResult = New DialogResult()

    Public dtValidacion As New DataTable
    Private CantImprimir As Integer
    Public f As New Funciones

    Public ReadOnly Property Cai As String

    Public Sub New(cnx As SqlConnection, cai As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        f.Conexion = cnx
        Me.Cai = cai

        If cai = "0" Then
            CmbNuevo.Enabled = False
        End If
    End Sub
    Public Sub FuncionInicial(strU As String, strP As String, StrE As String, IntT As Integer,
                               PerfilID As Integer, PrgID As Integer, FormID As Integer)

        'dtValidacion = f.getDataTable("spValidacionDocumentos '" & StrE & "', " & IntT)

        strUsuario = strU
        strPassword = strP
        StrEmpresa = StrE
        IntTipoDocto = IntT

        'Validar que el tipo de documento pertenece a la Empresa y CAI Actual
        ClsAccesos = New ClsVistas()
        ' dtConfigxEmpresa = ClsAccesos.ObtenerInfoConfigxEmpresa(strUsuario, strPassword, 1, CInt(StrE), IntT)

        Dim oTipoDocto As New IDF_TiposDoctos(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        oTipoDocto = IDF_TiposDoctos.Buscar("TiposDoctoID='" & IntT & "'")
        Me.Text = oTipoDocto.Descripcion

        'If dtValidacion.Rows(0).Item("Valor") = -2 Then
        '    ClsU.NotaCompleta("El tipo de documento " & Text & " no está disponible. Verifique el CAI actual", 48)
        'Else
        'Obtener lista de Opciones segun formulario por Perfil
        dtOpciones = ClsAccesos.ObtenerOpcionesxForm(strUsuario, strPassword, 1, PerfilID, PrgID, FormID)
            contador = dtOpciones.Rows.Count
            If contador > 0 Then
                'Habilitar opciones del formulario
                For Each fila As DataRow In dtOpciones.Rows
                    Dim xTipoOpcionID As Integer = CInt(fila(4))
                    Dim xActivo As Boolean = Convert.ToBoolean(fila(5))

                    'Verificar opciones
                    If xTipoOpcionID = CInt(tsMenu.Tag.ToString) And xActivo = True Then 'Accesar
                        tsMenu.Enabled = True
                    End If
                    If xTipoOpcionID = CInt(CmbActualizarConsulta.Tag.ToString) And xActivo = True Then 'Consultar
                        CmbActualizarConsulta.Enabled = True
                        GrdConsulta.Enabled = True
                        OpcionConsultar = 2
                    End If
                'If xTipoOpcionID = CInt(CmbNuevo.Tag.ToString) And xActivo = True Then 'Crear
                '    CmbNuevo.Enabled = True
                '    CmbGrabarNuevo.Enabled = True
                '    CmbGrabarSalir.Enabled = True
                'End If
                If xTipoOpcionID = CInt(CmbEditar.Tag.ToString) And xActivo = True Then 'Modificar
                        CmbEditar.Enabled = True
                        GrdConsulta.Enabled = True
                        OpcionModificar = 3
                    End If
                    If xTipoOpcionID = CInt(CmbAnular.Tag.ToString) And xActivo = True Then 'Anular
                        CmbAnular.Enabled = True
                    End If
                    If xTipoOpcionID = CInt(CmbImprimir.Tag.ToString) And xActivo = True Then 'Imprimir
                        CmbImprimir.Enabled = True
                    End If
                    If xTipoOpcionID = CInt(CmbGrabarNuevo.Tag.ToString) And xActivo = True Then 'Procesar/Guardar
                        CmbGrabarNuevo.Enabled = True
                        CmbGrabarSalir.Enabled = True
                    End If
                Next
            Else
                ClsU.NotaCompleta("El perfil del usuario # " & PerfilID & " no tiene los permisos respectivos. ID Usuario: " & strUsuario, 16)
            End If
        'End If
    End Sub

    Private Sub CmbActualizarConsulta_Click(sender As Object, e As EventArgs) Handles CmbActualizarConsulta.Click
        CargarConsulta()
    End Sub

    'Public Function ValidarFechaLimiteEmisionCAI() As Integer

    '    Dim oDetConfigXEmp As New IDF_DetConfigxEmp(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
    '    oDetConfigXEmp = IDF_DetConfigxEmp.BuscarCAI("B.EmpresaCodigo='" & StrEmpresa & "' and A.EsActual=1 and A.TiposDoctoID in (" + Str(IntTipoDocto) + ")")

    '    'Validar: cantidad de documentos disponible segun CAI actual.
    '    Dim intEmpresa As Integer = CInt(StrEmpresa)

    '    dtIDF_ConfigEmp002 = ClsAccesos.ObtenerInfoIDF_ConfigxEmp(strUsuario, strPassword, 1, intEmpresa, oDetConfigXEmp.CAI, IntTipoDocto)
    '    Dim xFechaLimiteCaducada As Integer = CInt(dtIDF_ConfigEmp002.Rows(0)(5))
    '    'Dim xFechaLimite As String = dtIDF_ConfigEmp002.Rows(0)(3).ToString
    '    'Dim xFechaHoy As String = dtIDF_ConfigEmp002.Rows(0)(4).ToString

    '    If xFechaLimiteCaducada = 1 Then
    '        ClsU.NotaCompleta("Error: El sistema ha detectado que La Fecha Limite de Emision de estos documentos " & _
    '                         "a caducado. Favor tramitar el nuevo CAI en la Direccion Ejecutiva de Ingresos... " & _
    '                             "Formulario de [" & Text & "] quedara inhabilitado", 16)

    '    End If

    '    Return xFechaLimiteCaducada
    'End Function

    Private Sub CmbNuevo_Click(sender As Object, e As EventArgs) Handles CmbNuevo.Click
        'dtValidacion = Nothing             'Ariel Cabrera 25/2/2020, desde que se selecciona el punto esta validado la fecha limite y la cantidad disponible.
        'dtValidacion = f.getDataTable("spValidacionDocumentos '" & StrEmpresa & "', " & IntTipoDocto)

        'If dtValidacion.Rows(0).Item("Valor") = -1 Then
        '    MsgBox("Fecha límite de emisión ha caducado", MsgBoxStyle.Critical, "ERROR")
        'Else
        Me.XTTDatos.SelectedTabPage = Me.XTPEncBasico
            Nuevo()
            CargarItems()
        'End If
    End Sub
    Private Sub CmbEditar_Click(sender As Object, e As EventArgs) Handles CmbEditar.Click
        If GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "Estado") = 2 Then
            MsgBox("Documento ya se encuentra anulado", MsgBoxStyle.Information, "Guías de remisión")
        Else

            Me.XTTDatos.SelectedTabPage = Me.XTPEncBasico

            Dim nRemisionID As String
            nRemisionID = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "RemisionID")

            Try
                Editar(nRemisionID)
                CargarItems()

            Catch ex As Exception
                ClsU.NotaCompleta("Debe de elegir un registro para editar. " & ex.Message, 16)
            End Try
        End If
    End Sub

    Private Sub CmbNuevoItem_Click(sender As Object, e As EventArgs) Handles CmbNuevoItem.Click
        NuevoItem("N")
    End Sub
    Private Sub CmbEliminarItem_Click(sender As Object, e As EventArgs) Handles CmbEliminarItem.Click
        Try
            Dim nProdxRemID As Integer
            nProdxRemID = Me.GrdVwItems.GetRowCellValue(Me.GrdVwItems.FocusedRowHandle, "ProdxRemID")

            EliminarItem(nProdxRemID)
            CargarItems()

        Catch ex As Exception
            ClsU.NotaCompleta("Debe de elegir un registro para eliminar. [" & ex.Message & "]", 16)
        End Try
    End Sub
    Private Sub cmbModificarItem_Click(sender As Object, e As EventArgs) Handles cmbModificarItem.Click
        Try
            Dim nProdxRemID As Integer
            nProdxRemID = Me.GrdVwItems.GetRowCellValue(Me.GrdVwItems.FocusedRowHandle, "ProdxRemID")

            ModificarItem(nProdxRemID)

        Catch ex As Exception

            ClsU.NotaCompleta("Debe de elegir un registro para modificar. [" & ex.Message & "]", 16)

        End Try
    End Sub
    Private Sub CmbRegActualizar_Click(sender As Object, e As EventArgs) Handles CmbRegActualizar.Click
        'Intento para salvar el encabezado de la factura, solo cuando el RemisionID=0
        Try

            If Me.TxtRemisionID.Text = 0 Then
                Grabar(Me.LblAccion.Text)
            End If

            GrabarItem(Me.GrpRegistro.Text)
            CargarItems()

            'Si es EstadoPesaje = NETO, entonces, se actualiza este campo directamente en la tabla
            'IDF_Remisiones
            If EstadoPesajeBioSalc.Equals("NETO") Then
                CmbGrabarSalir_Click(sender, e)
            End If

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al actualizar registro. [" & ex.Message & "]", 16)
        End Try

    End Sub

    Private Sub CmbRegCancelar_Click(sender As Object, e As EventArgs) Handles CmbRegCancelar.Click
        CancelarItem()
    End Sub

    Private Sub GrdConsulta_DoubleClick(sender As Object, e As EventArgs)
        Dim nRemisionID As Integer
        nRemisionID = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "RemisionID")

        Try
            Editar(nRemisionID)
            CargarItems()
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
        CargarItems()
    End Sub

    Private Sub CmbGrabarSalir_Click(sender As Object, e As EventArgs) Handles CmbGrabarSalir.Click
        Grabar(Me.LblAccion.Text)
    End Sub

    Private Sub TxtRegProdCodigo_EditValueChanged(sender As Object, e As EventArgs) Handles TxtRegProdCodigo.EditValueChanged
        If Me.TxtRegProdCodigo.Text.Length > 0 Then
            UbicarProducto()
        End If
    End Sub

    Private Sub CmbAnular_Click(sender As Object, e As EventArgs) Handles CmbAnular.Click

        If GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "Estado") = 2 Then
            MsgBox("Documento ya se encuentra anulado", MsgBoxStyle.Information, "Guías de remisión")
        Else
            If MsgBox("Seguro que desea anular este documento?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Guías de remisión") = MsgBoxResult.Yes Then
                Dim nRemisionID As Integer
                nRemisionID = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "RemisionID")
                f.ExecuteQuery("update IDF_Remisiones set estado = 2, usuAnulacion ='" & strUsuario & "'  where RemisionID = " & nRemisionID) 'Anular el documento.

                MsgBox("Remisión anulada exitosamente!", MsgBoxStyle.Information, "Guías de remisión")
                CargarConsulta() 'Refrescar el grid
                'Try
                '    Anular(nRemisionID, 2) '2=Anulado
                'Catch ex As Exception
                '    ClsU.NotaCompleta("Debe de elegir un registro para anular. " & ex.Message, 16)
                'End Try
            End If
        End If


    End Sub

    Private Sub FinDFFactsFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargarRegistros()
        CmbActualizarConsulta_Click(sender, e)
        Personalizar()
    End Sub

    Sub VerificarEliminarDetalleRemEnZero()
        'Si existe detalle de remisiones con remisionId = 0
        ClsVista = New ClsVistas()
        Dim dt As DataTable = New DataTable()
        dt = ClsVista.VerificarRemisionIDDetalleZero(strUsuario, strPassword, 1, 0, 0)
        Dim intCount As Integer = Integer.Parse(dt.Rows(0)(0).ToString)
        If intCount = 0 Then
            Dim dt1 As DataTable = New DataTable()
            dt1 = ClsVista.VerificarRemisionIDDetalleZero(strUsuario, strPassword, 2, 0, 0)
        End If
    End Sub

    Private Sub CmbImprimir_Click(sender As Object, e As EventArgs) Handles CmbImprimir.Click
        Dim nRemisionID As Integer = 0
        Dim nRemisionUltID As Integer = 1
        nRemisionID = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "RemisionID")

        Dim nRespuesta As Integer

        'Confirmación de impresión masiva
        If CmbOpcImpresion.SelectedIndex = 0 Then

            'Try
            Imprimir(nRemisionID)
            System.Threading.Thread.Sleep(9000)
            nRemisionUltID = nRemisionID
            'Catch ex As Exception
            '    ClsU.NotaCompleta("Debe de elegir un registro para imprimir. " & ex.Message, 16)
            'End Try

        Else
            nRespuesta = MsgBox("La impresión masiva es automática, desea continuar?", MsgBoxStyle.YesNo, "Consola de Programas")

            If nRespuesta = 7 Then
                Exit Sub
            End If

            While nRemisionID <> 0 And nRemisionID <> nRemisionUltID

                'Si es CAHSA se imprime 1, si es AYSA 2
                If StrEmpresa = "01" Then
                    CantImprimir = 1
                ElseIf StrEmpresa = "20" Then
                    CantImprimir = 2
                Else
                    CantImprimir = 3
                End If

                ImprimirVarias(nRemisionID, CantImprimir)
                'Threading.Thread.Sleep(9000)
                nRemisionUltID = nRemisionID
                'Catch ex As Exception
                '    ClsU.NotaCompleta("Debe de elegir un registro para imprimir. " & ex.Message, 16)
                'End Try

                GrdConsultaView.FocusedRowHandle = GrdConsultaView.FocusedRowHandle + 1
                Try
                    nRemisionID = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "RemisionID")
                Catch ex As Exception
                    nRemisionID = 0
                End Try

            End While
        End If

    End Sub

    Private Sub TxtSdNCodigo_EditValueChanged(sender As Object, e As EventArgs) Handles TxtSdNCodigo.EditValueChanged
        CargarDFs(Me.TxtSdNCodigo.EditValue)
    End Sub

#Region "Procedimientos Definidos por el usuario"
    Public Sub Personalizar()

    End Sub
    Public Sub UbicarProducto()

        Dim oProdRegistro As New IDF_Productos(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        oProdRegistro = IDF_Productos.Buscar("ProdCodigo='" & TxtRegProdCodigo.EditValue & "'")

        Me.TxtRegUnidMedCodigo.Text = oProdRegistro.UnidMed
        Me.TxtRegCantidad.EditValue = 1

    End Sub
    Public Sub CargarConsulta()

        Dim DtDatosDFFacts As New DataTable

        ClsRemisiones = New IDF_Remisiones(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Try
            DtDatosDFFacts = f.getDataTable("spIDF_RemisionesSelect '" & StrEmpresa & "', '" & Cai & "'")  'IDF_Remisiones.Tabla("Select A.*, B.Descripcion As CondNombre From IDF_Remisiones A Left Join IDF_Conductores B on A.ConductorID=B.ConductorID  Where A.TiposDoctoID in (" & IntTipoDocto & ") and A.EmpresaCodigo = '" & StrEmpresa & "' Order by RemNum")

            Me.GrdConsulta.DataSource = DtDatosDFFacts

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Documentos Fuente. " & ex.Message, 16)
        End Try

    End Sub
    Public Sub CargarRegistros()

        CmbOpcImpresion.SelectedIndex = 0

        Dim DtDatosProductos As New DataTable
        Dim DtDatosUnidMeds As New DataTable
        Dim DtDatosClientes As New DataTable
        Dim DtDatosEmpresas As New DataTable
        Dim DtDatosDFFacts As New DataTable
        Dim DtDatosTiposDoctos As New DataTable
        Dim DtDatosTransportistas As New DataTable
        Dim DtDatosConductores As New DataTable

        'BioSalc
        Dim DtDatosEmbalajes As New DataTable
        ClsBioSalc = New ClsBioSalc

        ClsProductos = New IDF_Productos(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        ClsUnidMeds = New IDF_UnidMeds(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        ClsClientes = New IDF_Clientes(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        ClsEmpresas = New IDF_Empresas(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        ClsDFFacts = New IDF_DFFacts(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        ClsTiposDoctos = New IDF_TiposDoctos(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Try
            DtDatosUnidMeds = IDF_UnidMeds.Tabla()
            Me.TxtRegUnidMedCodigo.Properties.DataSource = DtDatosUnidMeds
            Me.TxtRegUnidMedCodigo.Properties.ValueMember = DtDatosUnidMeds.Columns(0).ToString()
            Me.TxtRegUnidMedCodigo.Properties.DisplayMember = DtDatosUnidMeds.Columns(1).ToString()

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Unidades de Medida. " & ex.Message, 16)
        End Try

        Try
            DtDatosClientes = IDF_Clientes.Tabla()
            Me.TxtSdNCodigo.Properties.DataSource = DtDatosClientes
            Me.TxtSdNCodigo.Properties.ValueMember = DtDatosClientes.Columns(0).ToString()
            Me.TxtSdNCodigo.Properties.DisplayMember = DtDatosClientes.Columns(1).ToString()

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Clientes. " & ex.Message, 16)
        End Try

        Try
            DtDatosProductos = IDF_Productos.Tabla()
            Me.TxtRegProdCodigo.Properties.DataSource = DtDatosProductos
            Me.TxtRegProdCodigo.Properties.ValueMember = DtDatosProductos.Columns(0).ToString()
            Me.TxtRegProdCodigo.Properties.DisplayMember = DtDatosProductos.Columns(1).ToString()

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Productos. " & ex.Message, 16)
        End Try


        Try
            DtDatosEmpresas = IDF_Empresas.Tabla("Select * From IDF_Empresas Where TP='" & StrEmpresa & "'")
            Me.TxtEmpresaCodigo.Properties.DataSource = DtDatosEmpresas
            Me.TxtEmpresaCodigo.Properties.ValueMember = DtDatosEmpresas.Columns(0).ToString()
            Me.TxtEmpresaCodigo.Properties.DisplayMember = DtDatosEmpresas.Columns(1).ToString()

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Empresas. " & ex.Message, 16)
        End Try

        Try
            DtDatosTiposDoctos = IDF_TiposDoctos.Tabla("Select * From IDF_TiposDoctos Where TiposDoctoID=4")
            Me.TxtTiposDoctoID.Properties.DataSource = DtDatosTiposDoctos
            Me.TxtTiposDoctoID.Properties.ValueMember = DtDatosTiposDoctos.Columns(0).ToString()
            Me.TxtTiposDoctoID.Properties.DisplayMember = DtDatosTiposDoctos.Columns(1).ToString()

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Tipos de Documentos. " & ex.Message, 16)
        End Try

        Try
            DtDatosTransportistas = IDF_TiposDoctos.Tabla("Select * From IDF_Transportistas")
            Me.TxtTransportistaID.Properties.DataSource = DtDatosTransportistas
            Me.TxtTransportistaID.Properties.ValueMember = DtDatosTransportistas.Columns(0).ToString()
            Me.TxtTransportistaID.Properties.DisplayMember = DtDatosTransportistas.Columns(1).ToString()

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Transportistas. " & ex.Message, 16)
        End Try

        Try
            DtDatosConductores = IDF_TiposDoctos.Tabla("Select * From IDF_Conductores")
            Me.TxtConductorID.Properties.DataSource = DtDatosConductores
            Me.TxtConductorID.Properties.ValueMember = DtDatosConductores.Columns(0).ToString()
            Me.TxtConductorID.Properties.DisplayMember = DtDatosConductores.Columns(1).ToString()

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Conductores. " & ex.Message, 16)
        End Try

        Try
            DtDatosEmbalajes = ClsBioSalc.ObtenerEmbalajes(strUsuario, strPassword)
            Me.TxtRegEmbalajes.Properties.DataSource = DtDatosEmbalajes
            Me.TxtRegEmbalajes.Properties.ValueMember = DtDatosEmbalajes.Columns(0).ToString()
            Me.TxtRegEmbalajes.Properties.DisplayMember = DtDatosEmbalajes.Columns(1).ToString()

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Embalajes. " & ex.Message, 16)
        End Try

        TxtFechaInicio.EditValue = DateTime.Now
        TxtFechaFinal.EditValue = DateTime.Now

    End Sub

    Public Sub CargarDFs(cCliente As String)
        Dim DtDatosDFFacts As New DataTable
        ClsDFFacts = New IDF_DFFacts(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Try
            DtDatosDFFacts = IDF_DFFacts.Tabla("Select * From IDF_Remisiones Where EmpresaCodigo='" & StrEmpresa & "' and SdNCodigo = '" & cCliente & "' and TiposDoctoID in (1,7)")
            Me.TxtDFFactID.Properties.DataSource = DtDatosDFFacts
            Me.TxtDFFactID.Properties.ValueMember = DtDatosDFFacts.Columns(0).ToString()
            Me.TxtDFFactID.Properties.DisplayMember = DtDatosDFFacts.Columns(1).ToString()

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Facturas por Ventas. " & ex.Message, 16)
        End Try
    End Sub

    Public Sub CargarItems()
        ClsProdXRem = New IDF_ProdxRem(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Dim DtDatosProdXRem As New DataTable

        Try
            DtDatosProdXRem = IDF_ProdxRem.Tabla("SELECT * FROM IDF_ProdXRem WHERE RemisionID='" & Me.TxtRemisionID.Text & "'")
            dtDetalleProductosBioSalc = DtDatosProdXRem
            Me.GrdItems.DataSource = DtDatosProdXRem

            If dtDetalleProductosBioSalc.Rows.Count = 1 Then
                Dim xprod As String = dtDetalleProductosBioSalc.Rows(0)(0).ToString
                If EstadoPesajeBioSalc.Equals("TARA") And xprod.Equals("AZUSULJB") Then
                    'GroupControl1.Text = GroupControl1.Text & " - " & "Proceso Pesaje#2 [PESO NETO]"
                    btnProcesarOrdenBioSalc.Enabled = True
                    btnProcesarOrdenBioSalc.Text = "Procesar Cierre Peso Neto SACJ"
                Else
                    'GroupControl1.Text = GroupControl1.Text & " - " & "Proceso Pesaje#2 [PESO NETO]"
                    btnProcesarOrdenBioSalc.Enabled = True
                    btnProcesarOrdenBioSalc.Text = "ProcesarCierre PesoNeto Opcional"
                End If
            End If
        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Líneas de la Remisión. " & ex.Message, 16)
        End Try

    End Sub

    Public Sub Nuevo()
        Dim nDFRemNum As Integer

        Me.lblEstado.Text = "En Proceso"
        Me.LblAccion.Text = "Nuevo registro."
        Me.LblCodigoValor.Text = "<NuevoValor>"
        Me.XTTEmpaginacion.SelectedTabPage = XTTPagina2

        Dim oRemisionNuevo As New IDF_Remisiones(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        Dim oConfigXEmp As New IDF_ConfigxEmp(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        Dim oEmpAnexo As New IDF_EmpresasAnexo(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        'Dim oDetConfigXEmp As New IDF_DetConfigxEmp(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        oConfigXEmp = IDF_ConfigxEmp.Buscar("A.EmpresaCodigo='" & StrEmpresa & "' and B.EsActual=1 and B.TiposDoctoID in (" + Str(IntTipoDocto) + ")")
        'nDFRemNum = IDF_Remisiones.SigRemision(IntTipoDocto, StrEmpresa)
        nDFRemNum = IDF_Remisiones.SigRemisionCAI(IntTipoDocto, StrEmpresa, oConfigXEmp.CAI)
        oEmpAnexo = IDF_EmpresasAnexo.Buscar("EmpresaCodigo='" & StrEmpresa & "'")

        'oDetConfigXEmp = IDF_DetConfigxEmp.BuscarCAI("B.EmpresaCodigo='" & StrEmpresa & "' and A.EsActual=1 and A.TiposDoctoID in (" + Str(IntTipoDocto) + ")")

        Me.TxtRemNum.Text = Format(nDFRemNum, "00000000")

        Me.TxtRemisionID.Text = oRemisionNuevo.RemisionID
        Me.TxtCAI.Text = Cai 'oDetConfigXEmp.CAI
        Me.TxtFecha.Text = Now()
        Me.TxtEmpresaCodigo.Text = StrEmpresa
        Me.TxtSdNCodigo.Text = oRemisionNuevo.SdNCodigo
        Me.TxtDFFactID.Text = oRemisionNuevo.DFFactID
        Me.TxtMotivo.Text = oRemisionNuevo.OtroMotivo
        Me.TxtTransportistaID.EditValue = oRemisionNuevo.TransportistaID
        Me.TxtConductorID.EditValue = oRemisionNuevo.ConductorID
        Me.TxtMarca.Text = oRemisionNuevo.Marca
        Me.TxtPlaca.Text = oRemisionNuevo.Placa
        Me.TxtLicencia.Text = oRemisionNuevo.Licencia
        Me.TxtIdentidad.Text = oRemisionNuevo.Identidad
        Me.TxtTiposDoctoID.EditValue = IntTipoDocto
        Me.TxtPuntoPartida.Text = oRemisionNuevo.PuntoPartida
        Me.TxtPuntoDestino.Text = oRemisionNuevo.PuntoDestino
        Me.TxtFechaInicio.EditValue = Now() 'oRemisionNuevo.FechaInicio
        Me.TxtFechaFinal.EditValue = Now() 'oRemisionNuevo.FechaFinal
        Me.TxtMarchamo1.EditValue = oRemisionNuevo.Marchamo1
        Me.TxtMarchamo2.EditValue = oRemisionNuevo.Marchamo2
        Me.TxtMarchamo3.EditValue = oRemisionNuevo.Marchamo3
        Me.TxtMarchamo4.EditValue = oRemisionNuevo.Marchamo4
        Me.TxtMotivo.SelectedIndex = oRemisionNuevo.Motivo
        Me.TxtOtroMotivo.Text = oRemisionNuevo.OtroMotivo
        TxtOrdenPesoBioSalc.Text = oRemisionNuevo.NumOrdenPesoBioSalc

        Me.CmbNuevoItem.Enabled = True
        Me.CmbEliminarItem.Enabled = False
        Me.cmbModificarItem.Enabled = False

    End Sub
    Public Sub Editar(nDato As Integer)

        Me.LblAccion.Text = "Edición de datos."

        Dim oRemEdicion As New IDF_Remisiones(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        oRemEdicion = IDF_Remisiones.Buscar("RemisionID='" & nDato & "'")

        Me.LblCodigoValor.Text = oRemEdicion.RemNum
        Me.TxtRemNum.Text = oRemEdicion.RemNum

        Me.TxtRemNum.Enabled = False

        Me.TxtRemisionID.Text = oRemEdicion.RemisionID
        Me.TxtCAI.Text = oRemEdicion.CAI
        Me.TxtFecha.Text = oRemEdicion.Fecha
        Me.TxtEmpresaCodigo.Text = oRemEdicion.EmpresaCodigo
        Me.TxtSdNCodigo.Text = oRemEdicion.SdNCodigo
        Me.TxtDFFactID.Text = oRemEdicion.DFFactID
        Me.TxtTransportistaID.EditValue = oRemEdicion.TransportistaID
        Me.TxtConductorID.EditValue = oRemEdicion.ConductorID
        Me.TxtMarca.Text = oRemEdicion.Marca
        Me.TxtPlaca.Text = oRemEdicion.Placa
        Me.TxtLicencia.Text = oRemEdicion.Licencia
        Me.TxtIdentidad.Text = oRemEdicion.Identidad
        Me.TxtTiposDoctoID.EditValue = oRemEdicion.TiposDoctoID
        Me.TxtPuntoPartida.Text = oRemEdicion.PuntoPartida
        Me.TxtPuntoDestino.Text = oRemEdicion.PuntoDestino
        Me.TxtFechaInicio.EditValue = oRemEdicion.FechaInicio
        Me.TxtFechaFinal.EditValue = oRemEdicion.FechaFinal
        Me.TxtMarchamo1.EditValue = oRemEdicion.Marchamo1
        Me.TxtMarchamo2.EditValue = oRemEdicion.Marchamo2
        Me.TxtMarchamo3.EditValue = oRemEdicion.Marchamo3
        Me.TxtMarchamo4.EditValue = oRemEdicion.Marchamo4
        Me.TxtMotivo.SelectedIndex = oRemEdicion.Motivo
        Me.TxtOtroMotivo.Text = oRemEdicion.OtroMotivo

        Me.TxtNumCabezal.Text = oRemEdicion.NumCabezal
        EstadoPesajeBioSalc = oRemEdicion.EstadoPesaje
        Me.TxtOrdenPesoBioSalc.Text = oRemEdicion.NumOrdenPesoBioSalc

        Me.lblEstado.Text = IIf(oRemEdicion.Estado = 0, "VIGENTE", IIf(oRemEdicion.Estado = 1, "Aprobado", "ANULADO"))

        Me.XTTEmpaginacion.SelectedTabPage = XTTPagina2

    End Sub

    Public Sub NuevoItem(aplicaBioSalc As String)
        Me.XTTDetalle.SelectedTabPage = XTTRegPagina1
        Me.GrpRegistro.Text = "Nuevo registro."

        Dim oProdXDFFactReg As New IDF_ProdxRem(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        If aplicaBioSalc.Equals("N") Then
            Me.TxtRegProdXRemID.Text = oProdXDFFactReg.ProdxRemID
            Me.TxtRegProdCodigo.EditValue = oProdXDFFactReg.ProdCodigo
            Me.TxtRegCantidad.EditValue = oProdXDFFactReg.Cantidad
            Me.TxtRegUnidMedCodigo.EditValue = oProdXDFFactReg.UnidMedCodigo
            Me.TxtRegDescrip1.Text = oProdXDFFactReg.Descrip1
            Me.TxtRegDescrip2.Text = oProdXDFFactReg.Descrip2

            ActivarItem()
        End If

        If aplicaBioSalc.Equals("S") Then 'Peso tara - estado pesaje #1
            Me.TxtRegProdXRemID.Text = oProdXDFFactReg.ProdxRemID
            Me.TxtRegProdCodigo.EditValue = dtOrdenPesoTaraBioSalc.Rows(0)(19).ToString
            Me.TxtRegCantidad.EditValue = dtOrdenPesoTaraBioSalc.Rows(0)(20).ToString
            'Me.TxtRegUnidMedCodigo.EditValue = dtOrdenPesoTaraBioSalc.Rows(0)(21).ToString
            Me.TxtRegEmbalajes.EditValue = dtOrdenPesoTaraBioSalc.Rows(0)(32).ToString
            Me.TxtRegDescrip1.Text = oProdXDFFactReg.Descrip1
            Me.TxtRegDescrip2.Text = oProdXDFFactReg.Descrip2

            ActivarItem()
        End If

        If aplicaBioSalc.Equals("S2") Then 'Peso tara  | peso neto - estado pesaje #2
            Dim xProdCod As String = dtOrdenPesoTaraBioSalc.Rows(0)(19).ToString
            Try
                Dim nProdxRemID As Integer
                nProdxRemID = Me.GrdVwItems.GetRowCellValue(Me.GrdVwItems.FocusedRowHandle, "ProdxRemID")

                ModificarItem(nProdxRemID)

                If xProdCod.Equals("AZUSULJB") Then 'AZUCAR SULFITADA BLANCA JUMBO

                    PesoNetoLbs = Convert.ToDouble(dtOrdenPesoTaraBioSalc.Rows(0)(24).ToString)
                    PesoNetoKG = ((PesoNetoLbs * 0.46008) / 50)
                    EstadoPesajeBioSalc = "NETO"
                    Me.TxtRegCantidad.EditValue = PesoNetoKG.ToString()
                Else
                    Me.TxtRegProdCodigo.EditValue = dtOrdenPesoTaraBioSalc.Rows(0)(19).ToString
                End If

            Catch ex As Exception

                ClsU.NotaCompleta("Debe de elegir un registro para modificar. [" & ex.Message & "]", 16)

            End Try
        End If
    End Sub

    Private Sub TxtOrdenPesoBioSalc_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtOrdenPesoBioSalc.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Verificar si el comprobante de peso tiene tara
            Dim NumOrdenPesoBioSalc As Integer = Convert.ToInt32(TxtOrdenPesoBioSalc.EditValue)
            Dim res As Int16
            res = VerificarOrdenPesoTara(NumOrdenPesoBioSalc)
            If res <> 0 Then
                'GroupControl1.Text = GroupControl1.Text & " - " & "Proceso Pesaje#1 [TARA]"
                btnProcesarOrdenBioSalc.Enabled = True
                EstadoPesajeBioSalc = "TARA"
                btnProcesarOrdenBioSalc.Text = "Procesar Encabezado Ticket..."
            Else
                ClsU.NotaCompleta("No existen datos del peso tara de la transaccion: #" + NumOrdenPesoBioSalc.ToString(), 16)
            End If
        End If
    End Sub

    Private Sub CmbOpcImpresion_Click(sender As Object, e As EventArgs) Handles CmbOpcImpresion.Click

    End Sub

    Public Function VerificarOrdenPesoTara(NumOrdenPeso As Integer) As Integer
        ClsBioSalc = New ClsBioSalc()
        Dim resultado As Integer
        Dim dt As DataTable
        dt = ClsBioSalc.ObtenerOrdenPesoOtrosProductosBioSalc(strUsuario, strPassword, "vT", NumOrdenPeso)
        resultado = Convert.ToInt32(dt.Rows(0)(0).ToString)

        Return resultado
    End Function

    Public Sub EliminarItem(nDato As Integer)
        Dim oProdXFact As New IDF_ProdxRem(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        oProdXFact.ProdxRemID = nDato

        Try
            oProdXFact.Borrar()
        Catch ex As Exception
            ClsU.NotaCompleta("Debe de elegir un registro para eliminar. " & ex.Message, 16)
        End Try

        CargarItems()

    End Sub

    Public Sub ModificarItem(nDato As Integer)
        Me.GrpRegistro.Text = "Edición de datos."
        ActivarItem()

        Dim oProdXDFFactReg As New IDF_ProdxRem(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        oProdXDFFactReg = IDF_ProdxRem.Buscar("ProdxRemID='" & nDato & "'")

        Me.TxtRegProdXRemID.Text = oProdXDFFactReg.ProdxRemID
        Me.TxtRegProdCodigo.EditValue = oProdXDFFactReg.ProdCodigo
        Me.TxtRegCantidad.EditValue = oProdXDFFactReg.Cantidad
        Me.TxtRegUnidMedCodigo.EditValue = oProdXDFFactReg.UnidMedCodigo
        Me.TxtRegDescrip1.Text = oProdXDFFactReg.Descrip1
        Me.TxtRegDescrip2.Text = oProdXDFFactReg.Descrip2

    End Sub

    Public Sub ActivarItem()
        GrpRegistro.Visible = True

        CmbNuevoItem.Enabled = False
        cmbModificarItem.Enabled = False
        CmbEliminarItem.Enabled = False

        CmbRegresarConsulta.Enabled = False
        CmbGrabarNuevo.Enabled = False
        CmbGrabarSalir.Enabled = False
    End Sub

    Public Sub CancelarItem()
        GrpRegistro.Visible = False

        CmbNuevoItem.Enabled = True
        cmbModificarItem.Enabled = True
        CmbEliminarItem.Enabled = True

        CmbRegresarConsulta.Enabled = True
        CmbGrabarNuevo.Enabled = True
        CmbGrabarSalir.Enabled = True
    End Sub

    Private Sub btnProcesarOrdenBioSalc_Click(sender As Object, e As EventArgs) Handles btnProcesarOrdenBioSalc.Click
        'Proceso para obtener Pesaje desde Biosalc.
        If EstadoPesajeBioSalc.Equals("TARA") And Me.LblAccion.Text = "Edición de datos." Then
            ObtenerPesoNeto()
        Else
            ObtenerPesoTara()
        End If
    End Sub
    Public Sub ObtenerPesoNeto()
        ClsBioSalc = New ClsBioSalc()
        Dim resultado As Integer = 0
        Dim NumOrdenPesoBioSalc As Integer = Convert.ToInt32(TxtOrdenPesoBioSalc.EditValue)
        dtOrdenPesoTaraBioSalc = ClsBioSalc.ObtenerOrdenPesoOtrosProductosBioSalc(strUsuario, strPassword, "N", NumOrdenPesoBioSalc)
        resultado = dtOrdenPesoTaraBioSalc.Rows.Count
        If resultado > 0 Then
            'Asignacion de datos a campos local - Encabezado
            'TxtSdNCodigo.EditValue = dtOrdenPesoTaraBioSalc.Rows(0)(0).ToString
            'GroupControl1.Text = "Info. Comprobante Peso|BD:BioSalc"
            'Asignacion de datos en campos local - detalle
            NuevoItem("S2")
        End If
    End Sub
    Public Sub ObtenerPesoTara()
        ClsBioSalc = New ClsBioSalc()
        Dim resultado As Integer = 0
        Dim NumOrdenPesoBioSalc As Integer = Convert.ToInt32(TxtOrdenPesoBioSalc.EditValue)
        dtOrdenPesoTaraBioSalc = ClsBioSalc.ObtenerOrdenPesoOtrosProductosBioSalc(strUsuario, strPassword, "T", NumOrdenPesoBioSalc)
        resultado = dtOrdenPesoTaraBioSalc.Rows.Count
        If resultado > 0 Then
            'Asignacion de datos a campos local - Encabezado
            TxtSdNCodigo.EditValue = dtOrdenPesoTaraBioSalc.Rows(0)(0).ToString
            TxtTransportistaID.EditValue = dtOrdenPesoTaraBioSalc.Rows(0)(9).ToString
            TxtConductorID.EditValue = dtOrdenPesoTaraBioSalc.Rows(0)(10).ToString
            TxtMarca.EditValue = dtOrdenPesoTaraBioSalc.Rows(0)(13).ToString
            TxtPlaca.EditValue = dtOrdenPesoTaraBioSalc.Rows(0)(14).ToString
            TxtNumCabezal.EditValue = dtOrdenPesoTaraBioSalc.Rows(0)(11).ToString
            TxtMarchamo1.EditValue = dtOrdenPesoTaraBioSalc.Rows(0)(18).ToString
            TxtMarchamo2.EditValue = dtOrdenPesoTaraBioSalc.Rows(0)(17).ToString
            TxtMotivo.SelectedIndex = dtOrdenPesoTaraBioSalc.Rows(0)(8).ToString
            TxtPuntoPartida.EditValue = dtOrdenPesoTaraBioSalc.Rows(0)(4).ToString
            TxtPuntoDestino.EditValue = dtOrdenPesoTaraBioSalc.Rows(0)(5).ToString

            'GroupControl1.Text = "Info. Comprobante Peso|BD:BioSalc"

            'Asignacion de datos en campos local - detalle
            NuevoItem("S")
        End If
    End Sub

    Public Sub RegresarConsulta()
        Me.XTTEmpaginacion.SelectedTabPage = XTTPagina1
    End Sub

    Public Sub Grabar(cAccion As String)

        dtValidacion = Nothing
        dtValidacion = f.getDataTable("spValidacionDocumentos '" & StrEmpresa & "', " & IntTipoDocto)

        If dtValidacion.Rows(0).Item("Valor") = 0 And cAccion <> "Edición de datos." Then 'Validar la numeracion disponible.
            MsgBox("Número máximo disponible alcanzado." + vbNewLine + "Tramitar un nuevo documento CAI para " + Text, MsgBoxStyle.Critical, "ERROR")
            Exit Sub
        End If

        Dim cRemNum, cEmpresaCodigo As String
        Dim cResultado As String

        Dim oRemisionRegistro As New IDF_Remisiones(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        Dim oRemisionRegistroCopia As New IDF_Remisiones(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        If Len(Me.TxtRemNum.Text) = 0 Then
            ClsU.NotaCompleta("Se requiere un Número de remisión válido.", 16)
            Me.TxtRemNum.Focus()
            Exit Sub
        End If

        ''MsgBox(Me.TxtFecha.EditValue)
        oRemisionRegistro.RemisionID = Me.TxtRemisionID.Text
        oRemisionRegistro.CAI = Me.TxtCAI.Text
        oRemisionRegistro.Fecha = Me.TxtFecha.EditValue 'Format(CDate(Me.TxtFecha.EditValue), "MM/dd/yyyy")
        'MsgBox(oRemisionRegistro.Fecha)
        oRemisionRegistro.EmpresaCodigo = Me.TxtEmpresaCodigo.EditValue
        oRemisionRegistro.SdNCodigo = Me.TxtSdNCodigo.EditValue
        oRemisionRegistro.DFFactID = Me.TxtDFFactID.EditValue
        oRemisionRegistro.TransportistaID = Me.TxtTransportistaID.EditValue
        oRemisionRegistro.ConductorID = Me.TxtConductorID.EditValue
        oRemisionRegistro.Marca = Me.TxtMarca.Text
        oRemisionRegistro.Placa = Me.TxtPlaca.Text
        oRemisionRegistro.Licencia = Me.TxtLicencia.Text
        oRemisionRegistro.Identidad = Me.TxtIdentidad.Text
        oRemisionRegistro.TiposDoctoID = Me.TxtTiposDoctoID.EditValue
        oRemisionRegistro.Marchamo1 = Me.TxtMarchamo1.EditValue
        oRemisionRegistro.Marchamo2 = Me.TxtMarchamo2.EditValue
        oRemisionRegistro.Marchamo3 = Me.TxtMarchamo3.EditValue
        oRemisionRegistro.Marchamo4 = Me.TxtMarchamo4.EditValue
        oRemisionRegistro.PuntoPartida = Me.TxtPuntoPartida.EditValue
        oRemisionRegistro.PuntoDestino = Me.TxtPuntoDestino.EditValue
        oRemisionRegistro.FechaInicio = Me.TxtFechaInicio.EditValue
        oRemisionRegistro.FechaFinal = Me.TxtFechaFinal.EditValue
        oRemisionRegistro.Motivo = Me.TxtMotivo.SelectedIndex
        oRemisionRegistro.OtroMotivo = Me.TxtOtroMotivo.Text
        oRemisionRegistro.NumCabezal = Me.TxtNumCabezal.Text

        'Datos de BioSalc
        oRemisionRegistro.NumCabezal = Me.TxtNumCabezal.Text

        If TxtOrdenPesoBioSalc.Text.Length > 0 Then
            If EstadoPesajeBioSalc.Equals("TARA") Then
                oRemisionRegistro.EstadoPesaje = EstadoPesajeBioSalc
            Else
                oRemisionRegistro.EstadoPesaje = EstadoPesajeBioSalc 'NETO
            End If
            oRemisionRegistro.NumOrdenPesoBioSalc = TxtOrdenPesoBioSalc.Text
        End If


        If cAccion = "Edición de datos." Then

            Try
                oRemisionRegistro.RemNum = Me.TxtRemNum.Text

                oRemisionRegistro.UsuEditor = strUsuario
                oRemisionRegistro.FechaEdicion = Now()

                'Recuperar el RemisionID para seguir registrando productos bajo ese código
                oRemisionRegistroCopia = IDF_Remisiones.Buscar("RemisionID='" & oRemisionRegistro.RemisionID & "'")
                oRemisionRegistro.UsuCreador = oRemisionRegistroCopia.UsuCreador
                oRemisionRegistro.FechaCreacion = oRemisionRegistroCopia.FechaCreacion
                oRemisionRegistro.UsuAnulacion = oRemisionRegistroCopia.UsuAnulacion
                oRemisionRegistro.FechaAnulacion = oRemisionRegistroCopia.FechaAnulacion
                oRemisionRegistro.UsuImpresion = oRemisionRegistroCopia.UsuImpresion
                oRemisionRegistro.FechaImpresion = oRemisionRegistroCopia.FechaImpresion

                cResultado = oRemisionRegistro.Actualizar()
                Dim xResultado As Integer = InStr(cResultado, "ERROR", CompareMethod.Text)
                If xResultado > 0 Then
                    ClsU.NotaCompleta("No se pudo actualizar el nuevo registro [" & cResultado & "]", 16)
                    Return
                End If
                'If cResultado Like "ERROR%" Then
                '    ClsU.NotaCompleta("No se pudo actualizar el nuevo registro [" & cResultado & "]", 16)
                '    Return
                'End If

                ClsU.NotaCompleta("Registro actualizado satisfactoriamente!", 64)
            Catch ex As Exception
                ClsU.NotaCompleta("Error en la actualización. " + ex.Message, 16)
            End Try
        End If

        If cAccion = "Nuevo registro." Then
            Try

                'oRemisionRegistro.RemNum = Format(IDF_Remisiones.SigRemision(IntTipoDocto, StrEmpresa), "00000000")
                oRemisionRegistro.RemNum = Format(IDF_Remisiones.SigRemisionCAI(IntTipoDocto, StrEmpresa, TxtCAI.Text), "00000000")

                oRemisionRegistro.UsuCreador = strUsuario
                'oRemisionRegistro.FechaCreacion = Now()
                oRemisionRegistro.UsuEditor = strUsuario
                'oRemisionRegistro.FechaEdicion = Now()
                oRemisionRegistro.UsuAnulacion = ""
                'oRemisionRegistro.FechaAnulacion = Now()
                oRemisionRegistro.UsuImpresion = ""
                'oRemisionRegistro.FechaImpresion = Now()

                cResultado = oRemisionRegistro.Crear()
                Dim xResultado As Integer = InStr(cResultado, "ERROR", CompareMethod.Text)
                If xResultado > 0 Then
                    ClsU.NotaCompleta("No se pudo crear el nuevo registro [" & cResultado & "]", 16)
                    Return
                End If


                Me.CmbNuevoItem.Enabled = True
                Me.CmbEliminarItem.Enabled = True
                Me.cmbModificarItem.Enabled = True

                Try
                    'Variables para rastreo de la factura
                    cRemNum = oRemisionRegistro.RemNum
                    cEmpresaCodigo = oRemisionRegistro.EmpresaCodigo

                    'Recuperar el RemisionID para seguir registrando productos bajo ese código
                    oRemisionRegistro = IDF_Remisiones.Buscar("RemNum='" & cRemNum & "' and EmpresaCodigo='" & cEmpresaCodigo & "' and TiposDoctoID='" & IntTipoDocto & "'")
                    Me.TxtRemisionID.Text = oRemisionRegistro.RemisionID
                    Editar(oRemisionRegistro.RemisionID)

                Catch ex As Exception
                    ClsU.Nota(ex.Message)
                End Try

                Try
                    Dim oConfigEmpRegistro As New IDF_DetConfigxEmp(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

                    oConfigEmpRegistro = IDF_DetConfigxEmp.Buscar("TiposDoctoID='" & oRemisionRegistro.TiposDoctoID & "' and CAI='" & oRemisionRegistro.CAI & "'")
                    oConfigEmpRegistro.NumActual = oRemisionRegistro.RemNum

                    cResultado = oConfigEmpRegistro.Actualizar()

                    If cResultado Like "ERROR%" Then
                        ClsU.NotaCompleta("No se pudo actualizar el nuevo registro [" & cResultado & "]", 16)
                        Return
                    End If

                Catch ex As Exception
                    ClsU.NotaCompleta("No se pudo actualizar la numeración en la tabla del CAI [" & ex.Message & "]", 16)
                End Try

            Catch ex As Exception
                ClsU.NotaCompleta("Error en la creación del registro. " + ex.Message, 16)
            End Try
        End If


    End Sub

    Public Sub GrabarItem(cAccion As String)
        Dim oProdXFactRegistro As New IDF_ProdxRem(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        If Len(Me.TxtRemNum.Text) = 0 Then
            ClsU.NotaCompleta("Se requiere un Número de Factura válido.", 16)
            Me.TxtRemNum.Focus()
            Exit Sub
        End If

        oProdXFactRegistro.RemisionID = Me.TxtRemisionID.Text
        oProdXFactRegistro.ProdxRemID = Me.TxtRegProdXRemID.EditValue
        oProdXFactRegistro.ProdCodigo = Me.TxtRegProdCodigo.EditValue
        oProdXFactRegistro.Cantidad = Me.TxtRegCantidad.EditValue
        oProdXFactRegistro.UnidMedCodigo = Me.TxtRegUnidMedCodigo.EditValue
        oProdXFactRegistro.Descrip1 = Me.TxtRegDescrip1.Text
        oProdXFactRegistro.Descrip2 = Me.TxtRegDescrip2.Text

        'Codigo y peso de embalaje. Tabla: EMPAQUE. Base de Datos: BioSalc
        oProdXFactRegistro.CodEmpaqueBioSalc = TxtRegEmbalajes.EditValue
        oProdXFactRegistro.PesoEmbBioSalc = PesoTaraEmpaque

        If cAccion = "Edición de datos." Then
            Try
                oProdXFactRegistro.Actualizar()
            Catch ex As Exception
                ClsU.NotaCompleta("Error en la actualización. " & ex.Message, 16)
            End Try
        End If

        If cAccion = "Nuevo registro." Then
            Try
                'Si el codigo de producto es 2000 - Azucar a despachar
                'Debera de generar un mensaje de alerta o advertencia
                If TxtRegProdCodigo.EditValue.ToString.Equals("2000") Then
                    ClsU.NotaCompleta("Error: favor seleccionar el codigo de producto segun tipo de azucar. (REFINO | MORENA | SULFITADA JUMBO | ETC)." &
                                      "Para buscar un producto, debera desplegar el grid y en la columna Producto, digitar las letras AZU, de esta forma, solo se visualizara los productos de la categoria AZUCAR...", 16)
                    AplicaCancelarItem = -1
                Else
                    'Si el codigo de embalaje esta vacio
                    If TxtRegEmbalajes.EditValue.ToString.Length = 0 Then
                        ClsU.NotaCompleta("Error: Codigo de embalaje o empaque vacio o nulo... Favor verifique e intente de nuevo", 16)
                        AplicaCancelarItem = -1
                    Else
                        AplicaCancelarItem = 1
                        oProdXFactRegistro.Crear()


                        ClsBioSalc = New ClsBioSalc()
                        Dim mensaje As String = ""
                        Dim xTicket As Integer = 0
                        xTicket = Convert.ToInt32(Me.TxtOrdenPesoBioSalc.EditValue)
                        mensaje = ClsBioSalc.GuardarModificarOrdenPesoBioSalc_TARA(strUsuario, strPassword, True,
                                                                                    Me.TxtRegEmbalajes.EditValue,
                                                                                    Me.TxtRegProdCodigo.EditValue,
                                                                                    Me.TxtRegUnidMedCodigo.EditValue,
                                                                                    xTicket)
                        Dim resultadoMensaje As String
                        resultadoMensaje = mensaje.Substring(0, 1)
                        If resultadoMensaje.Equals("+") Then
                            mensaje = mensaje.Replace(resultadoMensaje, "")
                            ClsU.NotaCompleta(mensaje & " " &
                                              "Tabla: OPROD_MOV_PROD", 64)
                        Else
                            ClsU.NotaCompleta(mensaje, 16)
                            AplicaCancelarItem = -1
                        End If
                    End If

                End If
            Catch ex As Exception
                ClsU.NotaCompleta("Error en la creación del registro. " & ex.Message, 16)
                AplicaCancelarItem = -1
            End Try
        End If

        If AplicaCancelarItem = 1 Then
            CancelarItem()
        End If

    End Sub

    'Public Sub Anular(nRemisionID As Integer, nEstado As Integer)
    '    Dim oDFFact As New IDF_Remisiones(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

    '    oDFFact.RemisionID = nRemisionID

    '    Try
    '        oDFFact = IDF_Remisiones.Buscar("RemisionID='" & nRemisionID & "'")
    '        oDFFact.Estado = nEstado

    '        oDFFact.Actualizar()
    '    Catch ex As Exception
    '        ClsU.NotaCompleta("Debe de elegir un registro para eliminar. " & ex.Message, 16)
    '    End Try

    '    CargarItems()

    'End Sub

    Public Sub Imprimir(nRemisionID As Integer)
        Dim cReporte, cServidor, cBDD, cBusqueda As String

        Dim oDFFactReg As New IDF_Remisiones(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        oDFFactReg = IDF_Remisiones.Buscar("RemisionID='" & nRemisionID & "'")

        Dim oPerfilReg As New J_Perfil(ClsConexion.CadenaProduccion(strUsuario, strPassword))
        Dim oRepReg As New J_Reportes(ClsConexion.CadenaProduccion(strUsuario, strPassword))

        oPerfilReg = J_Perfil.Buscar("ID=1")

        cBusqueda = "255"

        oRepReg = J_Reportes.Buscar("idReporte='" & cBusqueda & "'")

        cReporte = "\\" & oPerfilReg.nombrePC & "\" & oPerfilReg.carpetaRaiz & "\" & oRepReg.reporte & ".rpt"
        cServidor = oRepReg.server
        cBDD = oRepReg.jDataBase

        'Dim ocInforme As New ReportDocument
        Dim v As GenVistaPrevia

        Try
            'ocInforme.Load(cReporte, OpenReportMethod.OpenReportByDefault) '"\\amigots2\Reportes\IDF\FinDFFactsRpt.rpt"
            'ocInforme.SetParameterValue("@RemisionID", nRemisionID)
            'ocInforme.SetDatabaseLogon(strUsuario, strPassword, "amigodb\amigodb", "Finanzas")
            'ocInforme.PrintToPrinter(1, False, 0, 0)

            v = New GenVistaPrevia
            v.info = "Vista Previa..."
            v.reporte = "\\" & oPerfilReg.nombrePC & "\" & oPerfilReg.carpetaRaiz & "\" & oRepReg.reporte
            v.dataBase = "Finanzas"
            v.user = strUsuario 'usuario  'user
            v.pass = strPassword 'password 'pass
            v.server = "amigodb\amigodb"
            v.usuarioSesion = strUsuario
            v.passwordSesion = strPassword
            v.parametro = nRemisionID
            'If Convert.ToBoolean(dgvReportes.GetRowCellValue(dgvReportes.FocusedRowHandle, colSolicitar)) Then
            '    v.parametro = si
            'End If

            v.Show()

        Catch ex As Exception
            ClsU.NotaCompleta("No se puede imprimir [" & ex.Message & "]", 16)
        End Try


        Try
            oDFFactReg.estaImpreso = True
            oDFFactReg.Actualizar()

        Catch ex As Exception
            ClsU.NotaCompleta("No se puede actualizar marcador de impresión [" & ex.Message & "]", 16)
        End Try
    End Sub

    Public Sub ImprimirVarias(nRemisionID As Integer, nCantidad As Integer)


        Dim cReporte, cServidor, cBDD, cBusqueda As String

        Dim oDFFactReg As New IDF_Remisiones(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        oDFFactReg = IDF_Remisiones.Buscar("RemisionID='" & nRemisionID & "'")

        Dim oPerfilReg As New J_Perfil(ClsConexion.CadenaProduccion(strUsuario, strPassword))
        Dim oRepReg As New J_Reportes(ClsConexion.CadenaProduccion(strUsuario, strPassword))

        oPerfilReg = J_Perfil.Buscar("ID=1")

        cBusqueda = "255"

        oRepReg = J_Reportes.Buscar("idReporte='" & cBusqueda & "'")

        cReporte = "\\" & oPerfilReg.nombrePC & "\" & oPerfilReg.carpetaRaiz & "\" & oRepReg.reporte & ".rpt"
        cServidor = oRepReg.server
        cBDD = oRepReg.jDataBase

        Dim ocInforme As New ReportDocument
        'Dim v As GenVistaPrevia

        Try
            ocInforme.Load(cReporte, OpenReportMethod.OpenReportByDefault) '"\\amigots2\Reportes\IDF\FinDFFactsRpt.rpt"
            ocInforme.SetParameterValue("@RemisionID", nRemisionID)
            ocInforme.SetDatabaseLogon(strUsuario, strPassword, "amigodb\amigodb", "Finanzas")
            ocInforme.PrintToPrinter(nCantidad, False, 0, 0)
            ocInforme.Close()
            ocInforme.Dispose()

            'v = New GenVistaPrevia
            'v.info = "Vista Previa..."
            'v.reporte = "\\" & oPerfilReg.nombrePC & "\" & oPerfilReg.carpetaRaiz & "\" & oRepReg.reporte
            'v.dataBase = "Finanzas"
            'v.user = strUsuario 'usuario  'user
            'v.pass = strPassword 'password 'pass
            'v.server = "amigodb\amigodb"
            'v.usuarioSesion = strUsuario
            'v.passwordSesion = strPassword
            'v.parametro = nRemisionID
            'If Convert.ToBoolean(dgvReportes.GetRowCellValue(dgvReportes.FocusedRowHandle, colSolicitar)) Then
            '    v.parametro = si
            'End If


            'ocInforme.PrintToPrinter(3, False, 1, 1)

        Catch ex As Exception
            ClsU.NotaCompleta("No se puede imprimir [" & ex.Message & "]", 16)
        End Try

        Try
            oDFFactReg.estaImpreso = True
            oDFFactReg.Actualizar()

        Catch ex As Exception
            ClsU.NotaCompleta("No se puede actualizar marcador de impresión [" & ex.Message & "]", 16)
        End Try
    End Sub

#End Region

    Private Sub TxtConductorID_EditValueChanged(sender As Object, e As EventArgs) Handles TxtConductorID.EditValueChanged
        Try
            Dim xConductorID As Integer = CInt(TxtConductorID.EditValue)

            Dim DtDatosCon As DataTable = New DataTable()

            DtDatosCon = IDF_TiposDoctos.Tabla("Select * From IDF_Conductores WHERE ConductorID = " & xConductorID & " ")

            Dim intCount As Integer = DtDatosCon.Rows.Count()
            TxtMarca.Text = DtDatosCon.Rows(0)(4).ToString
            TxtPlaca.Text = DtDatosCon.Rows(0)(5).ToString
            TxtIdentidad.Text = DtDatosCon.Rows(0)(2).ToString
            TxtLicencia.Text = DtDatosCon.Rows(0)(3).ToString

        Catch ex As Exception

        End Try
    End Sub
End Class