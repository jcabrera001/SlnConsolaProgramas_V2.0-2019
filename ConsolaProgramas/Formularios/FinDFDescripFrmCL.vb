Public Class FinDFDescripFrmCL
    '    Imports LibDAO001
    'Imports CrystalDecisions.CrystalReports.Engine
    'Imports CrystalDecisions.Shared
    'Imports System.Data.SqlClient

    '    Public Class FinDFDescripFrm

    '        Public strUsuario, strPassword, StrEmpresa As String
    '        Public IntTipoDocto As Integer

    '        Public ClsConexion As New ClsConexion
    '        Public ClsU As New ClsUtilitarios
    '        Public ClsDFDescrip As IDF_DFDescrip
    '        Public ClsItems As IDF_Items
    '        Public ClsUnidMeds As IDF_UnidMeds
    '        Public ClsClientes As IDF_Clientes
    '        Public ClsSdNs As IDF_SdNs
    '        Public ClsRetenciones As IDF_Retenciones
    '        Public ClsTerminos As IDF_Terminos
    '        Public ClsEmpresas As IDF_Empresas
    '        Public ClsEmpresaAnexo As IDF_EmpresasAnexo
    '        Public ClsImpuestos As IDF_Impuestos
    '        Public ClsTiposDoctos As IDF_TiposDoctos
    '        Public ClsItemsXDF As IDF_ItemsxDF
    '        Public ClsMonedas As IDF_Monedas
    '        Public ClsDFs As IDF_DFs
    '        Public ClsAccesos As ClsVistas = Nothing
    '        Public dtOpciones, dtConfigxEmpresa, dtIDF_ConfigEmp002, dtCxE_Nuevo, dtBuscarFacCompras As DataTable
    '        Public dtEmpresaAnexos As DataTable
    '        Public contador, OpcionConsultar, OpcionModificar, xRetencionID, FactCompID, flagCargar As Integer
    '        Public Acumular_ID As String
    '        Public montoGravado As Double
    '        Public aplicaGenAutoRetenciones As Boolean
    '        Public msgResultado As MsgBoxResult = New MsgBoxResult()
    '        Public DialogoResult As DialogResult = New DialogResult()
    '        Public EsExtendida As Boolean
    '        Public xFechaLimiteExtendidaCaducada As Integer

    '        Dim f As New Funciones
    '        Dim dtValidacion As New DataTable
    '        'Dim cmd As SqlCommand
    '        'Dim cnx As SqlConnection


    '        Private Function ValidarCAI(emp As String, doc As Integer) As Boolean
    '            Dim cmd As New SqlClient.SqlCommand
    '            Return False
    '        End Function

    '        Public Sub New(cnx As SqlConnection)

    '            ' This call is required by the designer.
    '            InitializeComponent()

    '            ' Add any initialization after the InitializeComponent() call.
    '            f.Conexion = cnx
    '        End Sub
    '        Public Sub FuncionInicial(strU As String, strP As String, StrE As String, IntT As Integer, PerfilID As Integer, PrgID As Integer, FormID As Integer)

    '            dtValidacion = f.getDataTable("spValidacionDocumentos '" & StrE & "', " & IntT)

    '            ClsAccesos = New ClsVistas()
    '            strUsuario = strU
    '            strPassword = strP
    '            StrEmpresa = StrE
    '            IntTipoDocto = IntT

    '            'Validar que el tipo de documento pertenece a la Empresa y CAI Actual


    '            Dim oTipoDocto As New IDF_TiposDoctos(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
    '            oTipoDocto = IDF_TiposDoctos.Buscar("TiposDoctoID='" & IntT & "'")
    '            Me.Text = oTipoDocto.Descripcion

    '            'MsgBox(dtConfigxEmpresa.Rows(0).Item(0))
    '            If dtValidacion.Rows(0).Item("Valor") = -2 Then
    '                ClsU.NotaCompleta("El tipo de documento " & Text & " no está disponible. Verifique el CAI actual", 48)
    '            Else
    '                'Obtener lista de Opciones segun formulario por Perfil
    '                dtOpciones = ClsAccesos.ObtenerOpcionesxForm(strUsuario, strPassword, 1, PerfilID, PrgID, FormID)
    '                contador = dtOpciones.Rows.Count
    '                If contador > 0 Then
    '                    'Habilitar opciones del formulario
    '                    For Each fila As DataRow In dtOpciones.Rows
    '                        Dim xTipoOpcionID As Integer = CInt(fila(4))
    '                        Dim xActivo As Boolean = Convert.ToBoolean(fila(5))

    '                        'Verificar opciones
    '                        If xTipoOpcionID = CInt(tsMenu.Tag.ToString) And xActivo = True Then 'Accesar
    '                            tsMenu.Enabled = True
    '                        End If
    '                        If xTipoOpcionID = CInt(CmbActualizarConsulta.Tag.ToString) And xActivo = True Then 'Consultar
    '                            CmbActualizarConsulta.Enabled = True
    '                            GrdConsulta.Enabled = True
    '                            OpcionConsultar = 2
    '                        End If
    '                        If xTipoOpcionID = CInt(CmbNuevo.Tag.ToString) And xActivo = True Then 'Crear
    '                            CmbNuevo.Enabled = True
    '                            CmbGrabarNuevo.Enabled = True
    '                            CmbGrabarSalir.Enabled = True
    '                        End If
    '                        If xTipoOpcionID = CInt(CmbEditar.Tag.ToString) And xActivo = True Then 'Modificar
    '                            CmbEditar.Enabled = True
    '                            GrdConsulta.Enabled = True
    '                            OpcionModificar = 3
    '                        End If
    '                        If xTipoOpcionID = CInt(CmbAnular.Tag.ToString) And xActivo = True Then 'Anular
    '                            CmbAnular.Enabled = True
    '                        End If
    '                        If xTipoOpcionID = CInt(CmbImprimir.Tag.ToString) And xActivo = True Then 'Imprimir
    '                            CmbImprimir.Enabled = True
    '                        End If
    '                        If xTipoOpcionID = CInt(CmbGrabarNuevo.Tag.ToString) And xActivo = True Then 'Procesar/Guardar
    '                            CmbGrabarNuevo.Enabled = True
    '                            CmbGrabarSalir.Enabled = True
    '                        End If
    '                    Next
    '                Else
    '                    ClsU.NotaCompleta("El perfil del usuario # " & PerfilID & " no tiene los permisos respectivos. ID Usuario: " & strUsuario, 16)
    '                End If
    '            End If
    '        End Sub


    '        Private Sub CmbActualizarConsulta_Click(sender As Object, e As EventArgs) Handles CmbActualizarConsulta.Click
    '            CargarConsulta()
    '        End Sub

    '        'Public Function ValidarFechaLimiteEmisionCAI() As Integer
    '        '    Dim oDetConfigXEmp As New IDF_DetConfigxEmp(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
    '        '    oDetConfigXEmp = IDF_DetConfigxEmp.BuscarCAI("B.EmpresaCodigo='" & StrEmpresa & "' and A.EsActual=1 and A.TiposDoctoID in (" + Str(IntTipoDocto) + ")")
    '        '    'Validar: cantidad de documentos disponible segun CAI actual.
    '        '    Dim intEmpresa As Integer = CInt(StrEmpresa)

    '        '    dtIDF_ConfigEmp002 = ClsAccesos.ObtenerInfoIDF_ConfigxEmp(strUsuario, strPassword, 1, intEmpresa, oDetConfigXEmp.CAI, IntTipoDocto)
    '        '    Dim xFechaLimiteCaducada As Integer = CInt(dtIDF_ConfigEmp002.Rows(0)(5))
    '        '    'Dim xFechaLimite As String = dtIDF_ConfigEmp002.Rows(0)(3).ToString
    '        '    'Dim xFechaHoy As String = dtIDF_ConfigEmp002.Rows(0)(4).ToString

    '        '    If xFechaLimiteCaducada = 1 Then
    '        '        ClsU.NotaCompleta("Error: El sistema ha detectado que La Fecha Limite de Emision de estos documentos " & _
    '        '                         "a caducado. Favor tramitar el nuevo CAI en la Direccion Ejecutiva de Ingresos... " & _
    '        '                             "Formulario de [" & Text & "] quedara inhabilitado", 16)

    '        '    End If

    '        '    Return xFechaLimiteCaducada
    '        'End Function

    '        'cambiar a la nueva validación
    '        'Public Function ValidarFechaLimiteEmisionCAI() As Integer

    '        '    Dim oDetConfigXEmp As New IDF_DetConfigxEmp(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
    '        '    oDetConfigXEmp = IDF_DetConfigxEmp.BuscarCAI("B.EmpresaCodigo='" & StrEmpresa & "' and A.EsActual=1 and A.TiposDoctoID in (" + Str(IntTipoDocto) + ")")

    '        '    'Validar: cantidad de documentos disponible segun CAI actual.
    '        '    Dim intEmpresa As Integer = CInt(StrEmpresa)

    '        '    dtIDF_ConfigEmp002 = ClsAccesos.ObtenerInfoIDF_ConfigxEmp(strUsuario, strPassword, 1, intEmpresa, oDetConfigXEmp.CAI, IntTipoDocto)
    '        '    Dim xFechaLimiteCaducada As Integer = CInt(dtIDF_ConfigEmp002.Rows(0)(5))

    '        '    EsExtendida = Convert.ToBoolean(dtIDF_ConfigEmp002.Rows(0)(6))
    '        '    xFechaLimiteExtendidaCaducada = CInt(dtIDF_ConfigEmp002.Rows(0)(8))

    '        '    'Dim xFechaLimite As String = dtIDF_ConfigEmp002.Rows(0)(3).ToString
    '        '    'Dim xFechaHoy As String = dtIDF_ConfigEmp002.Rows(0)(4).ToString

    '        '    Return xFechaLimiteCaducada
    '        'End Function

    '        'Public Function ValidarCantidadMinDisponibleCAIxDoc() As Integer
    '        '    'Validar: cantidad de documentos disponible segun CAI actual.
    '        '    Dim intEmpresa As Integer = CInt(StrEmpresa)

    '        '    dtCxE_Nuevo = ClsAccesos.ObtenerInfoConfigxEmpresa2_Fac(strUsuario, strPassword, 2, intEmpresa, IntTipoDocto)
    '        '    'Obtener datos de cada columna del DataTable
    '        '    Dim xCantOtor As Integer = CInt(dtCxE_Nuevo.Rows(0)(4))
    '        '    Dim xNumInicial As Integer = CInt(dtCxE_Nuevo.Rows(0)(5))
    '        '    Dim xNumFinal As Integer = CInt(dtCxE_Nuevo.Rows(0)(6))
    '        '    Dim xNumActual As Integer = CInt(dtCxE_Nuevo.Rows(0)(7))
    '        '    Dim xCAI As String = dtCxE_Nuevo.Rows(0)(9).ToString()
    '        '    Dim xCantMinima As Integer = CInt(dtCxE_Nuevo.Rows(0)(11))
    '        '    Dim xTotalFacEmiActualxDoc As Integer = CInt(dtCxE_Nuevo.Rows(0)(12))

    '        '    'Validar cantidades
    '        '    Dim Resultado As Integer
    '        '    Dim TotalFacXEmitirSegunCAI As Integer = (xNumFinal - xNumInicial)
    '        '    Dim TotalFacPendientesxEmitir As Integer = (TotalFacXEmitirSegunCAI - xTotalFacEmiActualxDoc)
    '        '    If (xTotalFacEmiActualxDoc >= xCantMinima) And (xTotalFacEmiActualxDoc <= TotalFacXEmitirSegunCAI) Then
    '        '        ClsU.NotaCompleta("Aviso: El Sistema ha detectado que este tipo de Documento [" & Text & "]," & _
    '        '                         " ha rebasado la cantidad minima establecida para esta Empresa de acuerdo al CAI actual [" & xCAI & "]. " &
    '        '                         "Total de facturas pendientes por emitir: " & TotalFacPendientesxEmitir, 48)
    '        '        Resultado = 0
    '        '    ElseIf xTotalFacEmiActualxDoc > TotalFacXEmitirSegunCAI Then
    '        '        ClsU.NotaCompleta("Error: El sistema ha detectado que no tiene cantidad disponible de numeros " & _
    '        '                          "de facturas para el CAI asignado a esta Empresa. Favor intente de nuevo. " & _
    '        '                          "Formulario de [" & Text & "] quedara inhabilitado. Se recomienda iniciar el tramite del nuevo CAI en la DEI.", 16)
    '        '        Resultado = 1
    '        '    End If

    '        'dtCantMinima = ClsAccesos.ObtenerMaximoDocxEmpresa(strUsuario, strPassword, 1, intEmpresa, IntTipoDocto, xCAI)
    '        'Dim xCantFacturas As Integer = CInt(dtCantMinima.Rows(0)(0))

    '        'Validar si el conteo es igual a la cantidad minima
    '        'Lanzar mensaje de Advertencia
    '        'Bloqueado por Ing. Manuel Ortega - Martes, 16 de Junio del 2015 - 10:30 am
    '        'If (xNumActual >= xCantMinima) And (xNumActual < xNumFinal) Then
    '        '    ClsU.NotaCompleta("Aviso: El Sistema ha detectado que este tipo de Documento [" & Text & "]," & _
    '        '                      " ha rebasado la cantidad minima establecida segun CAI actual para esta Empresa. " & _
    '        '                      "Favor iniciar con el tramite de un Nuevo CAI en la Direccion Ejecutiva de Ingresos.", 48)
    '        '    Me.XTTDatos.SelectedTabPage = Me.XTPEncBasico
    '        '    Me.XTPEncTotales.PageVisible = False
    '        '    Nuevo()
    '        '    CargarItems()
    '        'ElseIf (xNumActual >= xNumFinal) Then
    '        '    ClsU.NotaCompleta("Error: El sistema ha detectado que no tiene cantidad disponible de numeros " & _
    '        '                      "de facturas para el CAI Actual asignado a esta Empresa. Favor intente de nuevo. " & _
    '        '                      "Formulario de [" & Text & "] quedara inhabilitado", 16)
    '        '    Me.Enabled = False
    '        'End If

    '        '    Return Resultado
    '        'End Function

    '        Private Sub CmbNuevo_Click(sender As Object, e As EventArgs) Handles CmbNuevo.Click
    '            'contador = ValidarFechaLimiteEmisionCAI()

    '            'If contador >= 0 And contador < 2 Then
    '            'contador = ValidarFechaLimiteEmisionCAI()

    '            'If contador = 1 And EsExtendida = False Then
    '            '    ClsU.NotaCompleta("Error: El sistema ha detectado que La Fecha Limite de Emision de estos documentos " & _
    '            '                        "a caducado. Favor tramitar el nuevo CAI en la Direccion Ejecutiva de Ingresos... " & _
    '            '                            "Formulario de [" & Text & "] quedara inhabilitado", 16)
    '            '    Me.Close()
    '            'ElseIf contador = 1 And EsExtendida = True And xFechaLimiteExtendidaCaducada = 1 Then
    '            '    ClsU.NotaCompleta("Error: El sistema ha detectado que La Fecha Limite de Emision Extendida de estos documentos " & _
    '            '                     "a caducado. Favor tramitar el nuevo CAI en la Direccion Ejecutiva de Ingresos... " & _
    '            '                         "Formulario de [" & Text & "] quedara inhabilitado", 16)
    '            '    Me.Close()
    '            'ElseIf EsExtendida = True And xFechaLimiteExtendidaCaducada = 0 Then

    '            'End If

    '            dtValidacion = Nothing
    '            dtValidacion = f.getDataTable("spValidacionDocumentos '" & StrEmpresa & "', " & IntTipoDocto)

    '            If dtValidacion.Rows(0).Item("Valor") = -1 Then
    '                MsgBox("Fecha límite de emisión ha caducado", MsgBoxStyle.Critical, "ERROR")
    '            Else
    '                Me.XTTDatos.SelectedTabPage = Me.XTPEncBasico
    '                Me.XTPEncTotales.PageVisible = False
    '                Nuevo()
    '                CargarItems()
    '            End If

    '        End Sub
    '        Private Sub CmbEditar_Click(sender As Object, e As EventArgs) Handles CmbEditar.Click
    '            Dim nDFDescripID As String
    '            nDFDescripID = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "DFDescripID")
    '            'Validar si el tipo de impresion es "Multiple filas"
    '            Dim contador As Integer = VerificarCantidadFilasSelector(GrdConsultaView.RowCount)
    '            If contador >= 0 And contador < 2 Then
    '                Try

    '                    Editar(nDFDescripID)
    '                    CargarItems()

    '                Catch ex As Exception
    '                    ClsU.NotaCompleta("Debe de elegir un registro para editar. " & ex.Message, 16)
    '                End Try
    '            End If
    '            If contador >= 2 Then
    '                ClsU.NotaCompleta("No se permite editar multiples documentos a la vez, intente de nuevo", 16)
    '            End If

    '        End Sub

    '        Private Sub CmbNuevoItem_Click(sender As Object, e As EventArgs) Handles CmbNuevoItem.Click
    '            NuevoItem()
    '        End Sub
    '        Private Sub CmbEliminarItem_Click(sender As Object, e As EventArgs) Handles CmbEliminarItem.Click
    '            Try
    '                Dim nItemsXDFID As Integer
    '                nItemsXDFID = Me.GrdVwItems.GetRowCellValue(Me.GrdVwItems.FocusedRowHandle, ItemsxDFID)

    '                EliminarItem(nItemsXDFID)
    '                CargarItems()

    '                Totalizar(Me.TxtDFDescripID.Text)

    '            Catch ex As Exception
    '                ClsU.NotaCompleta("Debe de elegir un registro para eliminar. [" & ex.Message & "]", 16)
    '            End Try
    '        End Sub
    '        Private Sub cmbModificarItem_Click(sender As Object, e As EventArgs) Handles cmbModificarItem.Click
    '            Try
    '                Dim nItemsXDFID As Integer
    '                nItemsXDFID = Me.GrdVwItems.GetRowCellValue(Me.GrdVwItems.FocusedRowHandle, ItemsxDFID)

    '                ModificarItem(nItemsXDFID)

    '            Catch ex As Exception

    '                ClsU.NotaCompleta("Debe de elegir un registro para modificar. [" & ex.Message & "]", 16)

    '            End Try
    '        End Sub
    '        Private Sub CmbRegActualizar_Click(sender As Object, e As EventArgs) Handles CmbRegActualizar.Click
    '            'Intento para salvar el encabezado de la factura, solo cuando el DFFACTID=0
    '            Try

    '                If Me.TxtDFDescripID.Text = 0 Then
    '                    Grabar(Me.LblAccion.Text)
    '                End If

    '                GrabarItem(Me.GrpRegistro.Text)
    '                CargarItems()

    '                Totalizar(Me.TxtDFDescripID.Text)

    '            Catch ex As Exception
    '                ClsU.NotaCompleta("Problemas al actualizar registro. [" & ex.Message & "]", 16)
    '            End Try

    '        End Sub

    '        Private Sub CmbRegCancelar_Click(sender As Object, e As EventArgs) Handles CmbRegCancelar.Click
    '            CancelarItem()
    '        End Sub

    '        Private Sub GrdConsulta_DoubleClick(sender As Object, e As EventArgs) Handles GrdConsulta.DoubleClick
    '            Dim nDFDescripID As Integer
    '            nDFDescripID = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "DFDescripID")

    '            Try
    '                Editar(nDFDescripID)
    '                CargarItems()
    '            Catch ex As Exception
    '                ClsU.NotaCompleta("Debe de elegir un registro para editar.", 16)
    '            End Try
    '        End Sub

    '        Private Sub CmbRegresarConsulta_Click(sender As Object, e As EventArgs) Handles CmbRegresarConsulta.Click
    '            RegresarConsulta()
    '        End Sub

    '        Public Function VerificarCamposObligatorios() As String
    '            Dim strMensaje As String = ""
    '            If TxtSdNCodigo.Text.Equals("") = True Then
    '                strMensaje = "Codigo de cliente vacio o nulo. Favor revisar..."
    '            ElseIf TxtSdNCodigo.Text.Length = 0 Then
    '                strMensaje = "Codigo de cliente vacio o nulo. Favor revisar..."
    '            ElseIf TxtSdNCodigo.EditValue.ToString.Length = 0 Then
    '                strMensaje = "Codigo de cliente vacio o nulo. Favor revisar..."
    '            ElseIf IsNothing(TxtSdNCodigo.Text) Then
    '                strMensaje = "Codigo de cliente vacio o nulo. Favor revisar..."
    '            ElseIf TxtMonedaCodigo.Text.Equals("") = True Then
    '                strMensaje = "Error: codigo de moneda vacio. Favor intente de nuevo"
    '            ElseIf TxtMonedaCodigo.Text.Length = 0 Then
    '                strMensaje = "Error: codigo de moneda vacio. Favor intente de nuevo"
    '            ElseIf TxtMonedaCodigo.EditValue.ToString.Length = 0 Then
    '                strMensaje = "Error: codigo de moneda vacio. Favor intente de nuevo"
    '            ElseIf IsNothing(TxtMonedaCodigo.Text) Then
    '                strMensaje = "Error: codigo de moneda vacio. Favor intente de nuevo"
    '            ElseIf TxtMonedaCodigo.Text.Equals("") = True Then
    '                strMensaje = "Error: Favor seleccionar moneda. Intente de nuevo"
    '            ElseIf TxtMonedaCodigo.Text.Length = 0 Then
    '                strMensaje = "Error: Favor seleccionar moneda. Intente de nuevo"
    '            ElseIf IsNothing(TxtMonedaCodigo.Text) Then
    '                strMensaje = "Error: Favor seleccionar moneda. Intente de nuevo"
    '            ElseIf TxtMonedaCodigo.EditValue.ToString.Length = 0 Then
    '                strMensaje = "Error: Favor seleccionar moneda. Intente de nuevo"
    '            Else
    '                strMensaje = "1"
    '            End If

    '            Return strMensaje
    '        End Function

    '        Private Sub CmbGrabarNuevo_Click(sender As Object, e As EventArgs) Handles CmbGrabarNuevo.Click
    '            Dim resultado_mensaje As String = VerificarCamposObligatorios()
    '            If resultado_mensaje.Equals("1") Then
    '                Grabar(Me.LblAccion.Text)
    '                Nuevo()
    '                CargarItems()
    '            Else
    '                ClsU.NotaCompleta(resultado_mensaje, 16)
    '            End If
    '        End Sub

    '        Private Sub CmbGrabarSalir_Click(sender As Object, e As EventArgs) Handles CmbGrabarSalir.Click
    '            Dim resultado_mensaje As String = VerificarCamposObligatorios()
    '            If resultado_mensaje.Equals("1") Then
    '                Grabar(Me.LblAccion.Text)
    '            Else
    '                ClsU.NotaCompleta(resultado_mensaje, 16)
    '            End If
    '        End Sub

    '        Private Sub TxtRegItemID_EditValueChanged(sender As Object, e As EventArgs) Handles TxtRegItemID.EditValueChanged
    '            If Me.TxtRegItemID.Text.Length > 0 Then
    '                UbicarItem()
    '                CalcImptoDescto()
    '            End If
    '        End Sub

    '        Private Sub TxtRegImptoCodigo_EditValueChanged(sender As Object, e As EventArgs) Handles TxtRegImptoCodigo.EditValueChanged
    '            CalcImptoDescto()
    '        End Sub

    '        Private Sub CmbAnular_Click(sender As Object, e As EventArgs) Handles CmbAnular.Click
    '            msgResultado = ClsU.NotaCompletaPregunta("¿Desea anular este documento?", 128)
    '            If msgResultado = MsgBoxResult.Yes Then
    '                Dim nDFDescripID As Integer
    '                nDFDescripID = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "DFDescripID")

    '                Try
    '                    Anular(nDFDescripID, 2) '2=Anulado
    '                Catch ex As Exception

    '                End Try
    '            End If
    '        End Sub

    '        Private Sub FinDFFactsFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
    '            CargarRegistros()
    '            Personalizar()
    '        End Sub

    '        Public Function VerificarCantidadFilasSelector(zcont As Integer) As Integer
    '            Dim x_contador As Integer
    '            x_contador = 0
    '            For fila As Integer = 0 To zcont - 1
    '                Dim marca As Boolean = GrdConsultaView.GetRowCellValue(fila, colSelector)
    '                If marca = True Then
    '                    x_contador = x_contador + 1
    '                End If
    '            Next
    '            Return x_contador
    '        End Function
    '        Private Sub CmbImprimir_Click(sender As Object, e As EventArgs) Handles CmbImprimir.Click
    '            Dim nDFDescripID, nRespuesta As Integer

    '            'Validar si el usurio selecciono mas de una fila para la impresion previa
    '            Dim contador As Integer = GrdConsultaView.RowCount
    '            If contador > 0 Then
    '                'Confirmación de impresión 1 fila a la vez
    '                If CmbOpcImpresion.SelectedIndex = 0 Then
    '                    nDFDescripID = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "DFDescripID")

    '                    Try
    '                        Imprimir(nDFDescripID, "-1", PrintDialog1)

    '                    Catch ex As Exception
    '                        ClsU.NotaCompleta("Problema al imprimir registro. [" & ex.Message & "]", 16)
    '                    End Try
    '                Else
    '                    nRespuesta = VerificarCantidadFilasSelector(contador)
    '                    If nRespuesta = 0 Then
    '                        ClsU.NotaCompleta("Debe de elegir registros para imprimir. ", 16)
    '                    Else
    '                        'Impresion multiples filas
    '                        nRespuesta = ClsU.NotaCompletaPregunta("Iniciando proceso de impresión masiva. Favor revisar los documentos antes de realizar esta accion... " & _
    '                                                               "¿Desea continuar?", 128)

    '                        If nRespuesta = 7 Then
    '                            Exit Sub
    '                        End If

    '                        Acumular_ID = ""
    '                        If (txtFrecuenciaImpresion.Text.Equals("") = True) Or (Len(txtFrecuenciaImpresion.Text) = 0) Then
    '                            ClsU.NotaCompleta("Valor de tiempo de frecuencia invalido o nulo... Favor intente de nuevo.", 16)
    '                            txtFrecuenciaImpresion.Focus()
    '                            txtFrecuenciaImpresion.Text = "1"
    '                        Else
    '                            Dim Frecuencia As Integer = CInt(txtFrecuenciaImpresion.Text)

    '                            If Frecuencia > 0 Then
    '                                PrintDialog1.ShowDialog()
    '                                Dim ThreadSleep As Integer = (Frecuencia * 1000)
    '                                For fila As Integer = 0 To contador - 1
    '                                    Dim marca As Boolean = GrdConsultaView.GetRowCellValue(fila, colSelector)
    '                                    If marca = True Then
    '                                        Dim id As String = GrdConsultaView.GetRowCellValue(fila, colDFDescripID).ToString
    '                                        Acumular_ID = Acumular_ID & id & ","
    '                                        Imprimir(id, "1", PrintDialog1)
    '                                        System.Threading.Thread.Sleep(ThreadSleep)
    '                                    End If
    '                                Next

    '                                'Quitar las marcas
    '                                CmbQuitarSelector_Click(sender, e)
    '                            Else
    '                                ClsU.NotaCompleta("Valor de tiempo de impresion cero... Intente de nuevo. Es permitido valores de 1 a 9 segundos.", 16)
    '                            End If

    '                        End If

    '                    End If
    '                End If
    '            End If
    '        End Sub

    '        Private Sub TxtSdNCodigo_EditValueChanged(sender As Object, e As EventArgs) Handles TxtSdNCodigo.EditValueChanged
    '            CargarDFs(Me.TxtSdNCodigo.EditValue)
    '        End Sub

    '        Private Sub TxtRegTotalBruto_EditValueChanged(sender As Object, e As EventArgs) Handles TxtRegTotalBruto.EditValueChanged
    '            CalcImptoDescto()
    '        End Sub

    '        Private Sub TxtRegRetencionID_EditValueChanged(sender As Object, e As EventArgs) Handles TxtRegRetencionID.EditValueChanged
    '            CalcImptoDescto()
    '        End Sub


    '#Region "Procedimientos Definidos por el usuario"
    '        Public Sub Personalizar()
    '            CmbOpcImpresion.SelectedIndex = 0
    '            'Concepto del documento
    '            Me.TxtConcepto.Visible = False

    '            Select Case IntTipoDocto
    '                Case 3
    '                    Me.TxtConcepto.Visible = True
    '            End Select
    '        End Sub
    '        Public Sub UbicarItem()

    '            Dim oItemRegistro As New IDF_Items(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

    '            oItemRegistro = IDF_Items.Buscar("ItemID='" & TxtRegItemID.EditValue & "'")

    '            Me.TxtRegRetencionID.Text = oItemRegistro.RetencionID
    '            Me.TxtRegImptoCodigo.EditValue = oItemRegistro.ImptoCodigo

    '        End Sub
    '        Public Sub CalcImptoDescto()
    '            Dim nTotalBruto, nRetencion, nImpuesto, nTotalNeto As Double

    '            Dim oImptoRegistro As New IDF_Impuestos(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
    '            Dim oRetencionRegistro As New IDF_Retenciones(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

    '            nTotalBruto = Me.TxtRegTotalBruto.EditValue
    '            nTotalNeto = 0

    '            Try
    '                If Me.TxtRegImptoCodigo.EditValue.ToString.Length > 0 Then

    '                    Try
    '                        oImptoRegistro = IDF_Impuestos.Buscar("TaxCat='" & Me.TxtRegImptoCodigo.EditValue & "'")
    '                        nImpuesto = nTotalBruto * oImptoRegistro.Percentage

    '                    Catch ex As Exception

    '                        ClsU.NotaCompleta("Error con registro del impuesto [" & ex.Message & "]", 16)

    '                    End Try
    '                End If

    '            Catch ex As Exception

    '                nImpuesto = 0

    '            End Try

    '            Try
    '                If Me.TxtRegRetencionID.EditValue.ToString.Length > 0 Then

    '                    Try
    '                        Dim ridValue As String = Me.TxtRegRetencionID.EditValue.ToString
    '                        If CInt(ridValue) > 0 Then
    '                            oRetencionRegistro = IDF_Retenciones.Buscar("RetencionID='" & Me.TxtRegRetencionID.EditValue & "'")
    '                            nRetencion = nTotalBruto * oRetencionRegistro.Porcentaje
    '                        End If

    '                    Catch ex As Exception

    '                        ClsU.NotaCompleta("Error con registro de la retención [" & ex.Message & "]", 16)

    '                    End Try
    '                End If

    '            Catch ex As Exception

    '                nRetencion = 0

    '            End Try


    '            nTotalNeto = nTotalBruto + nImpuesto + nRetencion

    '            Me.TxtRegImptoMonto.Text = nImpuesto
    '            Me.TxtRegRetencionMonto.Text = nRetencion
    '            Me.TxtRegTotalNeto.Text = nTotalNeto

    '        End Sub
    '        Public Sub CargarConsulta()
    '            Dim DtDatosDFDescrip As New DataTable

    '            ClsDFDescrip = New IDF_DFDescrip(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

    '            Try
    '                Dim qry As String = "Select cast(0 AS Bit) AS Seleccionar," & _
    '                                    "*,CASE WHEN Estado = 0 THEN 'En Proceso' WHEN Estado = 2 THEN 'Anulado' END EstadoDescripcion " & _
    '                                    "From IDF_DFDescrip Where TiposDoctoID='" & IntTipoDocto & "' and EmpresaCodigo = '" & StrEmpresa & "' Order by DFNum"
    '                DtDatosDFDescrip = IDF_DFDescrip.Tabla(qry)
    '                Me.GrdConsulta.DataSource = DtDatosDFDescrip

    '            Catch ex As Exception
    '                ClsU.NotaCompleta("Problemas al consultar Documentos Fuente." & ex.Message, 16)
    '            End Try

    '        End Sub
    '        Public Sub CargarRegistros()
    '            Dim DtDatosItems As New DataTable
    '            Dim DtDatosUnidMeds As New DataTable
    '            Dim DtDatosClientes As New DataTable
    '            Dim DtDatosSdNs As New DataTable
    '            Dim DtDatosRetenciones As New DataTable
    '            Dim DtDatosTerminos As New DataTable
    '            Dim DtDatosEmpresas As New DataTable
    '            Dim DtDatosDFs As New DataTable
    '            Dim DtDatosImpuestos As New DataTable
    '            Dim DtDatosTiposDoctos As New DataTable
    '            Dim DtDatosMonedas As New DataTable

    '            CmbGenerarAutoRetenciones.Enabled = False

    '            ClsItems = New IDF_Items(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
    '            ClsUnidMeds = New IDF_UnidMeds(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
    '            ClsClientes = New IDF_Clientes(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
    '            ClsSdNs = New IDF_SdNs(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
    '            ClsRetenciones = New IDF_Retenciones(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
    '            ClsTerminos = New IDF_Terminos(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
    '            ClsEmpresas = New IDF_Empresas(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
    '            ClsEmpresaAnexo = New IDF_EmpresasAnexo(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
    '            ClsDFs = New IDF_DFs(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
    '            ClsImpuestos = New IDF_Impuestos(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
    '            ClsTiposDoctos = New IDF_TiposDoctos(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
    '            ClsMonedas = New IDF_Monedas()

    '            Try
    '                DtDatosUnidMeds = IDF_UnidMeds.Tabla()
    '                Me.TxtRegRetencionID.Properties.DataSource = DtDatosUnidMeds
    '                Me.TxtRegRetencionID.Properties.ValueMember = DtDatosUnidMeds.Columns(0).ToString()
    '                Me.TxtRegRetencionID.Properties.DisplayMember = DtDatosUnidMeds.Columns(1).ToString()

    '            Catch ex As Exception
    '                ClsU.NotaCompleta("Problemas al consultar Unidades de Medida. " & ex.Message, 16)
    '            End Try

    '            If IntTipoDocto = 5 Then

    '                Try
    '                    DtDatosSdNs = IDF_SdNs.Tabla()
    '                    Me.TxtSdNCodigo.Properties.DataSource = DtDatosSdNs
    '                    Me.TxtSdNCodigo.Properties.ValueMember = DtDatosSdNs.Columns(0).ToString()
    '                    Me.TxtSdNCodigo.Properties.DisplayMember = DtDatosSdNs.Columns(1).ToString()

    '                Catch ex As Exception
    '                    ClsU.NotaCompleta("Problemas al consultar Socios de negocios. " & ex.Message, 16)
    '                End Try

    '            Else

    '                Try
    '                    DtDatosClientes = IDF_Clientes.Tabla()
    '                    Me.TxtSdNCodigo.Properties.DataSource = DtDatosClientes
    '                    Me.TxtSdNCodigo.Properties.ValueMember = DtDatosClientes.Columns(0).ToString()
    '                    Me.TxtSdNCodigo.Properties.DisplayMember = DtDatosClientes.Columns(1).ToString()

    '                Catch ex As Exception
    '                    ClsU.NotaCompleta("Problemas al consultar Clientes. " & ex.Message, 16)
    '                End Try

    '            End If

    '            Try
    '                DtDatosItems = IDF_Items.Tabla("Select * From IDF_Items Where TiposDoctoID='" & IntTipoDocto & "'")
    '                Me.TxtRegItemID.Properties.DataSource = DtDatosItems
    '                Me.TxtRegItemID.Properties.ValueMember = DtDatosItems.Columns(0).ToString()
    '                Me.TxtRegItemID.Properties.DisplayMember = DtDatosItems.Columns(1).ToString()

    '            Catch ex As Exception
    '                ClsU.NotaCompleta("Problemas al consultar Items. " & ex.Message, 16)
    '            End Try

    '            Try
    '                DtDatosRetenciones = IDF_Retenciones.Tabla()
    '                Me.TxtRegRetencionID.Properties.DataSource = DtDatosRetenciones
    '                Me.TxtRegRetencionID.Properties.ValueMember = DtDatosRetenciones.Columns(0).ToString()
    '                Me.TxtRegRetencionID.Properties.DisplayMember = DtDatosRetenciones.Columns(1).ToString()

    '            Catch ex As Exception
    '                ClsU.NotaCompleta("Problemas al consultar Retenciones. " & ex.Message, 16)
    '            End Try

    '            Try
    '                DtDatosEmpresas = IDF_Empresas.Tabla("Select * From IDF_Empresas Where TP='" & StrEmpresa & "'")
    '                Me.TxtEmpresaCodigo.Properties.DataSource = DtDatosEmpresas
    '                Me.TxtEmpresaCodigo.Properties.ValueMember = DtDatosEmpresas.Columns(0).ToString()
    '                Me.TxtEmpresaCodigo.Properties.DisplayMember = DtDatosEmpresas.Columns(1).ToString()

    '            Catch ex As Exception
    '                ClsU.NotaCompleta("Problemas al consultar Empresas. " & ex.Message, 16)
    '            End Try

    '            Try
    '                dtEmpresaAnexos = New DataTable()
    '                dtEmpresaAnexos = IDF_EmpresasAnexo.Tabla("Select * From IDF_EmpresasAnexo Where EmpresaCodigo='" & StrEmpresa & "'")
    '                aplicaGenAutoRetenciones = Convert.ToBoolean(dtEmpresaAnexos.Rows(0)(10))
    '                If aplicaGenAutoRetenciones Then
    '                    CmbGenerarAutoRetenciones.Enabled = True
    '                    CmbBuscarFacturas.Enabled = True
    '                End If
    '            Catch ex As Exception
    '                ClsU.NotaCompleta("Problemas al consultar Empresas. " & ex.Message, 16)
    '            End Try


    '            Try
    '                DtDatosImpuestos = IDF_Impuestos.Tabla("Select * From IDF_Impuestos Where Right(TaxCat,2)='" & StrEmpresa & "' or TaxCat='ISV0'")
    '                Me.TxtRegImptoCodigo.Properties.DataSource = DtDatosImpuestos
    '                Me.TxtRegImptoCodigo.Properties.ValueMember = DtDatosImpuestos.Columns(0).ToString()
    '                Me.TxtRegImptoCodigo.Properties.DisplayMember = DtDatosImpuestos.Columns(1).ToString()

    '            Catch ex As Exception
    '                ClsU.NotaCompleta("Problemas al consultar Impuestos. " & ex.Message, 16)
    '            End Try

    '            Try
    '                DtDatosTiposDoctos = IDF_TiposDoctos.Tabla("Select * From IDF_TiposDoctos Where EsFacturaXVta <> 1")
    '                Me.TxtTiposDoctoID.Properties.DataSource = DtDatosTiposDoctos
    '                Me.TxtTiposDoctoID.Properties.ValueMember = DtDatosTiposDoctos.Columns(0).ToString()
    '                Me.TxtTiposDoctoID.Properties.DisplayMember = DtDatosTiposDoctos.Columns(1).ToString()

    '            Catch ex As Exception
    '                ClsU.NotaCompleta("Problemas al consultar Tipos de Documentos. " & ex.Message, 16)
    '            End Try

    '            Try
    '                DtDatosMonedas = IDF_TiposDoctos.Tabla("Select * From IDF_Monedas")
    '                Me.TxtMonedaCodigo.Properties.DataSource = DtDatosMonedas
    '                Me.TxtMonedaCodigo.Properties.ValueMember = DtDatosMonedas.Columns(0).ToString()
    '                Me.TxtMonedaCodigo.Properties.DisplayMember = DtDatosMonedas.Columns(1).ToString()

    '            Catch ex As Exception
    '                ClsU.NotaCompleta("Problemas al consultar Monedas. " & ex.Message, 16)
    '            End Try
    '        End Sub

    '        Public Sub CargarDFs(cCliente As String)
    '            Dim DtDatosDFs As New DataTable
    '            ClsDFs = New IDF_DFs(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

    '            Try
    '                DtDatosDFs = IDF_DFs.Tabla("Select * From IDF_DFs Where Company='" & StrEmpresa & "' and Recipient = '" & cCliente & "'")
    '                Me.TxtDFID.Properties.DataSource = DtDatosDFs
    '                Me.TxtDFID.Properties.ValueMember = DtDatosDFs.Columns(0).ToString()
    '                Me.TxtDFID.Properties.DisplayMember = DtDatosDFs.Columns(1).ToString()

    '            Catch ex As Exception
    '                ClsU.NotaCompleta("Problemas al consultar Documentos Fuentes. " & ex.Message, 16)
    '            End Try
    '        End Sub

    '        Public Sub CargarItems()
    '            ClsItemsXDF = New IDF_ItemsxDF(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

    '            Dim DtDatosItemsXDF As New DataTable

    '            Try
    '                DtDatosItemsXDF = IDF_ItemsxDF.Tabla("SELECT * FROM IDF_ItemsXDF WHERE DFDescripID='" & Me.TxtDFDescripID.Text & "'")
    '                Me.GrdItems.DataSource = DtDatosItemsXDF

    '            Catch ex As Exception
    '                ClsU.NotaCompleta("Problemas al consultar Líneas del Documento Fuente. " & ex.Message, 16)
    '            End Try

    '        End Sub

    '        Public Sub Nuevo()
    '            Dim nDFNum As Integer

    '            Me.lblEstado.Text = "En Proceso"
    '            Me.LblAccion.Text = "Nuevo registro."
    '            Me.LblCodigoValor.Text = "<NuevoValor>"
    '            Me.XTTEmpaginacion.SelectedTabPage = XTTPagina2

    '            Dim oDFDescripNuevo As New IDF_DFDescrip(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
    '            Dim oConfigXEmp As New IDF_ConfigxEmp(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
    '            Dim oEmpAnexo As New IDF_EmpresasAnexo(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
    '            Dim oDetConfigXEmp As New IDF_DetConfigxEmp(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

    '            oConfigXEmp = IDF_ConfigxEmp.Buscar("A.EmpresaCodigo='" & StrEmpresa & "' and B.EsActual=1 and B.TiposDoctoID in (" + Str(IntTipoDocto) + ")")

    '            'nDFNum = IDF_DFDescrip.SigDFDescrip(IntTipoDocto, StrEmpresa)
    '            nDFNum = IDF_DFDescrip.SigDFDescripCAI(IntTipoDocto, StrEmpresa, oConfigXEmp.CAI)

    '            oEmpAnexo = IDF_EmpresasAnexo.Buscar("EmpresaCodigo='" & StrEmpresa & "'")

    '            oDetConfigXEmp = IDF_DetConfigxEmp.BuscarCAI("B.EmpresaCodigo='" & StrEmpresa & "' and A.EsActual=1 and A.TiposDoctoID in (" + Str(IntTipoDocto) + ")")

    '            Me.TxtDFNum.Text = Format(nDFNum, "00000000")

    '            Me.TxtDescripcion.Focus()

    '            Me.TxtDFDescripID.Text = oDFDescripNuevo.DFDescripID
    '            'Me.TxtCAI.Text = oConfigXEmp.CAI --Bloqueado por Ing. Manuel Ortega - Sabado, 07-05-2016 - 10:52AM
    '            Me.TxtCAI.Text = oDetConfigXEmp.CAI

    '            Me.TxtFecha.Text = Now()
    '            Me.TxtDescripcion.Text = oDFDescripNuevo.Descripcion
    '            Me.TxtSdNCodigo.Text = oDFDescripNuevo.SdNCodigo
    '            Me.TxtEmpresaCodigo.Text = StrEmpresa
    '            Me.TxtTotalNeto.Text = oDFDescripNuevo.TotalNeto
    '            Me.TxtDFDescripID.Text = oDFDescripNuevo.DFDescripID
    '            Me.TxtTiposDoctoID.EditValue = IntTipoDocto
    '            Me.TxtConcepto.SelectedIndex = oDFDescripNuevo.Concepto
    '            Me.TxtCAIComprobante.Text = oDFDescripNuevo.CAIComprobante
    '            Me.TxtNumComprobante.Text = oDFDescripNuevo.NumComprobante
    '            Me.TxtFechaEmisionComp.Text = Now() 'oDFDescripNuevo.FechaEmisionComp

    '            Me.TxtMonedaCodigo.EditValue = oDFDescripNuevo.MonedaCodigo

    '            Me.CmbNuevoItem.Enabled = True
    '            Me.CmbEliminarItem.Enabled = False
    '            Me.cmbModificarItem.Enabled = False
    '            Me.XTPEncTotales.PageVisible = False

    '        End Sub
    '        Public Sub Editar(nDato As Integer)

    '            Me.LblAccion.Text = "Edición de datos."

    '            Dim oDescripEdicion As New IDF_DFDescrip(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

    '            oDescripEdicion = IDF_DFDescrip.Buscar("DFDescripID='" & nDato & "'")

    '            TxtFecha.Enabled = True
    '            TxtDescripcion.Enabled = True
    '            TxtSdNCodigo.Enabled = True
    '            TxtNumComprobante.Enabled = True
    '            TxtCAIComprobante.Enabled = True
    '            TxtFechaEmisionComp.Enabled = True
    '            CmbBuscarFacturas.Enabled = True
    '            CmbGenerarAutoRetenciones.Enabled = True
    '            CmbNuevoItem.Enabled = True
    '            CmbEliminarItem.Enabled = True
    '            cmbModificarItem.Enabled = True
    '            CmbGrabarNuevo.Enabled = True
    '            CmbGrabarSalir.Enabled = True

    '            dtEmpresaAnexos = New DataTable()
    '            dtEmpresaAnexos = IDF_EmpresasAnexo.Tabla("Select * From IDF_EmpresasAnexo Where EmpresaCodigo='" & StrEmpresa & "'")
    '            aplicaGenAutoRetenciones = Convert.ToBoolean(dtEmpresaAnexos.Rows(0)(10))
    '            CmbGenerarAutoRetenciones.Enabled = False
    '            CmbBuscarFacturas.Enabled = False
    '            If aplicaGenAutoRetenciones Then
    '                CmbGenerarAutoRetenciones.Enabled = True
    '                CmbBuscarFacturas.Enabled = True
    '            End If

    '            If oDescripEdicion.Estado = 2 Then
    '                TxtFecha.Enabled = False
    '                TxtDescripcion.Enabled = False
    '                TxtSdNCodigo.Enabled = False
    '                TxtNumComprobante.Enabled = False
    '                TxtCAIComprobante.Enabled = False
    '                TxtFechaEmisionComp.Enabled = False
    '                CmbBuscarFacturas.Enabled = False
    '                CmbGenerarAutoRetenciones.Enabled = False
    '                CmbNuevoItem.Enabled = False
    '                CmbEliminarItem.Enabled = False
    '                cmbModificarItem.Enabled = False
    '                CmbGrabarNuevo.Enabled = False
    '                CmbGrabarSalir.Enabled = False
    '            End If

    '            Me.LblCodigoValor.Text = oDescripEdicion.DFNum
    '            Me.TxtDFNum.Text = oDescripEdicion.DFNum

    '            Me.TxtDFNum.Enabled = False

    '            Me.TxtDFDescripID.Text = oDescripEdicion.DFDescripID
    '            Me.TxtCAI.Text = oDescripEdicion.CAI
    '            Me.TxtFecha.Text = oDescripEdicion.Fecha
    '            Me.TxtDescripcion.Text = oDescripEdicion.Descripcion
    '            Me.TxtSdNCodigo.Text = oDescripEdicion.SdNCodigo
    '            Me.TxtEmpresaCodigo.Text = oDescripEdicion.EmpresaCodigo
    '            Me.TxtTotalNeto.Text = oDescripEdicion.TotalNeto
    '            Me.TxtTiposDoctoID.EditValue = oDescripEdicion.TiposDoctoID
    '            Me.TxtConcepto.SelectedIndex = oDescripEdicion.Concepto

    '            Me.TxtCAIComprobante.Text = oDescripEdicion.CAIComprobante
    '            Me.TxtNumComprobante.Text = oDescripEdicion.NumComprobante
    '            Me.TxtFechaEmisionComp.EditValue = oDescripEdicion.FechaEmisionComp
    '            Me.memoTxtInfoExtra.Text = oDescripEdicion.InfoExtra

    '            Me.TxtMonedaCodigo.EditValue = oDescripEdicion.MonedaCodigo

    '            Me.lblEstado.Text = IIf(oDescripEdicion.Estado = 0, "En Proceso", IIf(oDescripEdicion.Estado = 1, "Aprobado", "Anulado"))

    '            Me.XTTEmpaginacion.SelectedTabPage = XTTPagina2
    '            Me.XTPEncTotales.PageVisible = True

    '        End Sub

    '        Public Sub NuevoItem()
    '            Me.XTTDetalle.SelectedTabPage = XTTRegPagina1
    '            Me.GrpRegistro.Text = "Nuevo registro."

    '            Dim oItemsXDFReg As New IDF_ItemsxDF(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

    '            Me.TxtRegItemsXDFID.Text = oItemsXDFReg.ItemsxDFID
    '            Me.TxtRegItemID.EditValue = oItemsXDFReg.ItemID
    '            Me.TxtRegImptoCodigo.EditValue = oItemsXDFReg.ImptoCodigo
    '            Me.TxtRegDescrip1.Text = oItemsXDFReg.Descripcion1
    '            Me.TxtRegImptoMonto.EditValue = oItemsXDFReg.ImpuestoMonto
    '            Me.TxtRegRetencionID.EditValue = oItemsXDFReg.RetencionID
    '            Me.TxtRegRetencionMonto.EditValue = oItemsXDFReg.RetencionMonto
    '            Me.TxtRegTotalBruto.EditValue = oItemsXDFReg.TotalBruto
    '            Me.TxtRegTotalNeto.EditValue = oItemsXDFReg.TotalNeto

    '            ActivarItem()
    '        End Sub

    '        Public Sub EliminarItem(nDato As Integer)
    '            Dim oItemsXDF As New IDF_ItemsxDF(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

    '            oItemsXDF.ItemsxDFID = nDato

    '            Try
    '                oItemsXDF.Borrar()

    '                CargarItems()

    '            Catch ex As Exception
    '                ClsU.NotaCompleta("Debe de elegir un registro para eliminar. " & ex.Message, 16)
    '            End Try


    '        End Sub

    '        Public Sub ModificarItem(nDato As Integer)
    '            Me.GrpRegistro.Text = "Edición de datos."
    '            ActivarItem()

    '            Dim oItemsXDFReg As New IDF_ItemsxDF(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

    '            oItemsXDFReg = IDF_ItemsxDF.Buscar("ItemsXDFID='" & nDato & "'")

    '            Me.TxtRegItemsXDFID.Text = oItemsXDFReg.ItemsxDFID
    '            Me.TxtRegItemID.EditValue = oItemsXDFReg.ItemID
    '            Me.TxtRegImptoCodigo.EditValue = oItemsXDFReg.ImptoCodigo
    '            Me.TxtRegDescrip1.Text = oItemsXDFReg.Descripcion1
    '            Me.TxtRegImptoMonto.EditValue = oItemsXDFReg.ImpuestoMonto
    '            Me.TxtRegRetencionID.EditValue = oItemsXDFReg.RetencionID
    '            Me.TxtRegRetencionMonto.EditValue = oItemsXDFReg.RetencionMonto
    '            Me.TxtRegTotalBruto.EditValue = oItemsXDFReg.TotalBruto
    '            Me.TxtRegTotalNeto.EditValue = oItemsXDFReg.TotalNeto

    '        End Sub

    '        Public Sub ActivarItem()
    '            GrpRegistro.Visible = True

    '            CmbNuevoItem.Enabled = False
    '            cmbModificarItem.Enabled = False
    '            CmbEliminarItem.Enabled = False

    '            CmbRegresarConsulta.Enabled = False
    '            CmbGrabarNuevo.Enabled = False
    '            CmbGrabarSalir.Enabled = False
    '        End Sub

    '        Public Sub CancelarItem()
    '            GrpRegistro.Visible = False

    '            CmbNuevoItem.Enabled = True
    '            cmbModificarItem.Enabled = True
    '            CmbEliminarItem.Enabled = True

    '            CmbRegresarConsulta.Enabled = True
    '            CmbGrabarNuevo.Enabled = True
    '            CmbGrabarSalir.Enabled = True
    '            aplicaGenAutoRetenciones = Convert.ToBoolean(dtEmpresaAnexos.Rows(0)(10))
    '            If aplicaGenAutoRetenciones Then
    '                CmbGenerarAutoRetenciones.Enabled = True
    '                CmbBuscarFacturas.Enabled = True
    '            End If
    '        End Sub

    '        Public Sub RegresarConsulta()
    '            Me.XTTEmpaginacion.SelectedTabPage = XTTPagina1
    '        End Sub

    '        Public Sub Grabar(cAccion As String)
    '            If cAccion <> "Edición de datos." Then
    '                dtValidacion = Nothing
    '                dtValidacion = f.getDataTable("spValidacionDocumentos '" & StrEmpresa & "', " & IntTipoDocto)

    '                If dtValidacion.Rows(0).Item("Valor") = 0 Then 'Validar la numeracion disponible.
    '                    MsgBox("Número máximo disponible alcanzado." + vbNewLine + "Tramitar un nuevo documento CAI para " + Text, MsgBoxStyle.Critical, "ERROR")
    '                End If

    '            Else
    '                Dim cDFNum, cEmpresaCodigo As String

    '                Dim oDFDescripRegistro As New IDF_DFDescrip(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
    '                Dim oDFDescripRegistroCopia As New IDF_DFDescrip(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

    '                If Len(Me.TxtDFNum.Text) = 0 Then
    '                    ClsU.NotaCompleta("Se requiere un Número de Documento Fuente válido. ", 16)
    '                    Me.TxtDFNum.Focus()
    '                    Exit Sub
    '                End If

    '                oDFDescripRegistro.DFDescripID = Me.TxtDFDescripID.Text
    '                oDFDescripRegistro.CAI = Me.TxtCAI.EditValue
    '                oDFDescripRegistro.Fecha = Me.TxtFecha.EditValue
    '                oDFDescripRegistro.Descripcion = Me.TxtDescripcion.Text
    '                oDFDescripRegistro.EmpresaCodigo = Me.TxtEmpresaCodigo.EditValue
    '                oDFDescripRegistro.SdNCodigo = Me.TxtSdNCodigo.EditValue
    '                oDFDescripRegistro.TotalNeto = Me.TxtTotalNeto.EditValue
    '                oDFDescripRegistro.TiposDoctoID = Me.TxtTiposDoctoID.EditValue
    '                oDFDescripRegistro.Concepto = Me.TxtConcepto.SelectedIndex
    '                oDFDescripRegistro.CAIComprobante = Me.TxtCAIComprobante.Text
    '                oDFDescripRegistro.NumComprobante = Me.TxtNumComprobante.Text
    '                oDFDescripRegistro.FechaEmisionComp = Me.TxtFechaEmisionComp.EditValue
    '                oDFDescripRegistro.InfoExtra = Me.memoTxtInfoExtra.Text

    '                oDFDescripRegistro.MonedaCodigo = Me.TxtMonedaCodigo.EditValue

    '                If cAccion = "Edición de datos." Then

    '                    Try
    '                        oDFDescripRegistro.DFNum = Me.TxtDFNum.Text

    '                        oDFDescripRegistro.UsuEditor = strUsuario
    '                        oDFDescripRegistro.FechaEdicion = Now()

    '                        'Recuperar el DFDescripID para seguir registrando Items bajo ese código
    '                        oDFDescripRegistroCopia = IDF_DFDescrip.Buscar("DFDescripID='" & oDFDescripRegistro.DFDescripID & "'")
    '                        oDFDescripRegistro.Estado = oDFDescripRegistroCopia.Estado
    '                        oDFDescripRegistro.UsuCreador = oDFDescripRegistroCopia.UsuCreador
    '                        oDFDescripRegistro.FechaCreacion = oDFDescripRegistroCopia.FechaCreacion
    '                        oDFDescripRegistro.UsuAnulacion = oDFDescripRegistroCopia.UsuAnulacion
    '                        oDFDescripRegistro.FechaAnulacion = oDFDescripRegistroCopia.FechaAnulacion
    '                        oDFDescripRegistro.UsuImpresion = oDFDescripRegistroCopia.UsuImpresion
    '                        oDFDescripRegistro.FechaImpresion = oDFDescripRegistroCopia.FechaImpresion

    '                        Dim RESULTADO As String = oDFDescripRegistro.Actualizar()
    '                        Dim xResultado As Integer = InStr(RESULTADO, "ERROR", CompareMethod.Text)
    '                        If xResultado > 0 Then
    '                            ClsU.NotaCompleta("No se pudo actualizar el nuevo registro [" & RESULTADO & "]", 16)
    '                            Return
    '                        End If
    '                        'If RESULTADO Like "ERROR%" Then
    '                        '    ClsU.NotaCompleta("No se pudo actualizar el nuevo registro [" & RESULTADO & "]", 16)
    '                        '    Return
    '                        'End If
    '                        ClsU.NotaCompleta("Actualizado satisfactoriamente!", 64)
    '                    Catch ex As Exception
    '                        ClsU.NotaCompleta("Error en la actualización. " & ex.Message, 16)
    '                    End Try
    '                End If

    '                If cAccion = "Nuevo registro." Then
    '                    Try

    '                        'oDFDescripRegistro.DFNum = Format(IDF_DFDescrip.SigDFDescrip(IntTipoDocto, StrEmpresa), "00000000")
    '                        oDFDescripRegistro.DFNum = Format(IDF_DFDescrip.SigDFDescripCAI(IntTipoDocto, StrEmpresa, TxtCAI.Text), "00000000")

    '                        oDFDescripRegistro.Estado = 0 'Siempre

    '                        oDFDescripRegistro.UsuCreador = strUsuario
    '                        oDFDescripRegistro.FechaCreacion = Now()
    '                        oDFDescripRegistro.UsuEditor = strUsuario
    '                        oDFDescripRegistro.FechaEdicion = Now()
    '                        oDFDescripRegistro.UsuAnulacion = ""
    '                        oDFDescripRegistro.FechaAnulacion = Now()
    '                        oDFDescripRegistro.UsuImpresion = ""
    '                        oDFDescripRegistro.FechaImpresion = Now()

    '                        oDFDescripRegistro.Crear()

    '                        Me.CmbNuevoItem.Enabled = True
    '                        Me.CmbEliminarItem.Enabled = True
    '                        Me.cmbModificarItem.Enabled = True
    '                        Me.XTPEncTotales.PageVisible = False

    '                        Try
    '                            'Variables para rastreo de la factura
    '                            cDFNum = oDFDescripRegistro.DFNum
    '                            cEmpresaCodigo = oDFDescripRegistro.EmpresaCodigo

    '                            'Recuperar el DFDescripID para seguir registrando Items bajo ese código
    '                            oDFDescripRegistro = IDF_DFDescrip.Buscar("DFNum='" & cDFNum & "' and EmpresaCodigo='" & cEmpresaCodigo & "' and TiposDoctoID='" & IntTipoDocto & "'")
    '                            Me.TxtDFDescripID.Text = oDFDescripRegistro.DFDescripID
    '                            Editar(oDFDescripRegistro.DFDescripID)

    '                        Catch ex As Exception
    '                            ClsU.Nota(ex.Message)
    '                        End Try

    '                        Try
    '                            Dim oConfigEmpRegistro As New IDF_DetConfigxEmp(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

    '                            oConfigEmpRegistro = IDF_DetConfigxEmp.Buscar("TiposDoctoID='" & oDFDescripRegistro.TiposDoctoID & "' and CAI='" & oDFDescripRegistro.CAI & "'")
    '                            oConfigEmpRegistro.NumActual = oDFDescripRegistro.DFNum
    '                            oConfigEmpRegistro.Actualizar()
    '                            ClsU.NotaCompleta("Registrado satisfactoriamente!", 64)
    '                        Catch ex As Exception
    '                            ClsU.NotaCompleta("No se pudo actualizar la numeración en la tabla del CAI [" & ex.Message & "]", 16)
    '                        End Try

    '                    Catch ex As Exception
    '                        ClsU.NotaCompleta("Error en la creación del registro. " + ex.Message, 16)
    '                    End Try
    '                End If
    '            End If
    '        End If
    '        End Sub

    '        Public Sub GrabarItem(cAccion As String)
    '            Dim oItemsXDFRegistro As New IDF_ItemsxDF(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

    '            If Len(Me.TxtDFNum.Text) = 0 Then
    '                ClsU.NotaCompleta("Se requiere un Número de Factura válido.", 16)
    '                Me.TxtDFNum.Focus()
    '                Exit Sub
    '            End If

    '            oItemsXDFRegistro.DFDescripID = Me.TxtDFDescripID.EditValue
    '            oItemsXDFRegistro.ItemID = Me.TxtRegItemID.EditValue
    '            oItemsXDFRegistro.ImptoCodigo = Me.TxtRegImptoCodigo.EditValue
    '            oItemsXDFRegistro.RetencionID = Me.TxtRegRetencionID.EditValue
    '            oItemsXDFRegistro.ImpuestoMonto = Me.TxtRegImptoMonto.EditValue
    '            oItemsXDFRegistro.TotalBruto = Me.TxtRegTotalBruto.EditValue
    '            oItemsXDFRegistro.RetencionMonto = Me.TxtRegRetencionMonto.EditValue
    '            oItemsXDFRegistro.TotalNeto = Me.TxtRegTotalNeto.EditValue
    '            oItemsXDFRegistro.Descripcion1 = Me.TxtRegDescrip1.Text

    '            If cAccion = "Edición de datos." Then

    '                oItemsXDFRegistro.ItemsxDFID = Me.TxtRegItemsXDFID.Text

    '                Try
    '                    oItemsXDFRegistro.Actualizar()
    '                Catch ex As Exception
    '                    ClsU.NotaCompleta("Error en la actualización.", 16)
    '                End Try
    '            End If

    '            If cAccion = "Nuevo registro." Then
    '                Try
    '                    oItemsXDFRegistro.Crear()
    '                Catch ex As Exception
    '                    ClsU.NotaCompleta("Error en la creación del registro. " & ex.Message, 16)
    '                End Try
    '            End If

    '            CancelarItem()

    '        End Sub

    '        Public Sub Anular(nDFDescripID As Integer, nEstado As Integer)
    '            Dim oDFDescrip As New IDF_DFDescrip(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

    '            oDFDescrip.DFDescripID = nDFDescripID

    '            Try
    '                oDFDescrip = IDF_DFDescrip.Buscar("DFDescripID='" & nDFDescripID & "'")
    '                oDFDescrip.Estado = nEstado

    '                oDFDescrip.Actualizar()
    '            Catch ex As Exception
    '                ClsU.NotaCompleta("Debe de elegir un registro para eliminar. " & ex.Message, 16)
    '            End Try

    '            CargarItems()

    '        End Sub

    '        Public Sub Totalizar(nDFDescripID As Integer)
    '            If nDFDescripID = 0 Then
    '                Exit Sub
    '            End If

    '            Dim nTotalNeto As Double
    '            Dim oProdXDFFactReg As New IDF_ItemsxDF(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
    '            Dim oDFFactReg As New IDF_DFDescrip(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

    '            nTotalNeto = IDF_ItemsxDF.TotalXDFID(nDFDescripID, "TotalNeto")

    '            Me.TxtTotalNeto.EditValue = nTotalNeto

    '            oDFFactReg = IDF_DFDescrip.Buscar("DFDescripID='" & Me.TxtDFDescripID.EditValue & "'")

    '            oDFFactReg.TotalNeto = nTotalNeto

    '            Try

    '                oDFFactReg.Actualizar()

    '            Catch ex As Exception

    '            End Try

    '            Me.XTPEncTotales.PageVisible = True

    '        End Sub

    '        Public Sub Imprimir(nDFDescripID As Integer, AcumuladoID As String, x_print As PrintDialog)

    '            Dim cReporte, cServidor, cBDD, cBusqueda As String

    '            Dim oDFDescripReg As New IDF_DFDescrip(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
    '            oDFDescripReg = IDF_DFDescrip.Buscar("DFDescripID='" & nDFDescripID & "'")

    '            Dim oPerfilReg As New J_Perfil(ClsConexion.CadenaProduccion(strUsuario, strPassword))
    '            Dim oRepReg As New J_Reportes(ClsConexion.CadenaProduccion(strUsuario, strPassword))

    '            oPerfilReg = J_Perfil.Buscar("ID=1")

    '            cBusqueda = IIf(oDFDescripReg.TiposDoctoID = 2, "249", IIf(oDFDescripReg.TiposDoctoID = 3, "248", IIf(oDFDescripReg.TiposDoctoID = 5, "250", "")))

    '            oRepReg = J_Reportes.Buscar("idReporte='" & cBusqueda & "'")

    '            cReporte = "\\" & oPerfilReg.nombrePC & "\" & oPerfilReg.carpetaRaiz & "\" & oRepReg.reporte & ".rpt"
    '            cServidor = oRepReg.server
    '            cBDD = oRepReg.jDataBase

    '            Dim ocInforme As New ReportDocument
    '            Dim v As GenVistaPrevia

    '            Try
    '                If AcumuladoID.Equals("1") Then
    '                    ocInforme.Load(cReporte, OpenReportMethod.OpenReportByDefault) '"\\amigots2\Reportes\IDF\FinDFFactsRpt.rpt"
    '                    ocInforme.SetParameterValue("@DFDescripID", nDFDescripID)
    '                    'ocInforme.SetDatabaseLogon(strUsuario, strPassword, cServidor, cBDD)
    '                    ocInforme.SetDatabaseLogon(strUsuario, strPassword, "amigodb\amigodb", "Finanzas")
    '                    ocInforme.PrintToPrinter(x_print.PrinterSettings.Copies, False, 0, 0)

    '                    ocInforme.Close()
    '                    ocInforme.Dispose()
    '                End If

    '                If AcumuladoID.Equals("-1") Then
    '                    v = New GenVistaPrevia
    '                    v.info = "Vista Previa..."
    '                    v.reporte = "\\" & oPerfilReg.nombrePC & "\" & oPerfilReg.carpetaRaiz & "\" & oRepReg.reporte
    '                    v.dataBase = "Finanzas"
    '                    v.user = strUsuario 'usuario  'user
    '                    v.pass = strPassword 'password 'pass
    '                    v.server = "amigodb\amigodb"
    '                    v.usuarioSesion = strUsuario
    '                    v.passwordSesion = strPassword
    '                    v.parametro = nDFDescripID
    '                    'If Convert.ToBoolean(dgvReportes.GetRowCellValue(dgvReportes.FocusedRowHandle, colSolicitar)) Then
    '                    '    v.parametro = si
    '                    'End If

    '                    v.Show()
    '                End If

    '            Catch ex As Exception
    '                ClsU.NotaCompleta("No se puede imprimir [" & ex.Message & "]", 16)
    '            End Try


    '            Try
    '                oDFDescripReg.estaImpreso = True
    '                oDFDescripReg.Actualizar()

    '            Catch ex As Exception
    '                ClsU.NotaCompleta("No se puede actualizar marcador de impresión [" & ex.Message & "]", 16)
    '            End Try
    '        End Sub

    '#End Region

    '        Private Sub CmbBuscarFacturas_Click(sender As Object, e As EventArgs) Handles CmbBuscarFacturas.Click
    '            Try
    '                'Obtener datos de la factura por compra
    '                Dim Socio As String = TxtSdNCodigo.EditValue
    '                Dim FrmXtraBuscarFacCompras As FinXtraBuscarFacCompras = New FinXtraBuscarFacCompras()
    '                FrmXtraBuscarFacCompras.FuncionInicial(strUsuario, strPassword,
    '                                                       StrEmpresa, IntTipoDocto, 0, 0, 0, Socio)
    '                FrmXtraBuscarFacCompras.ShowDialog()

    '                If FrmXtraBuscarFacCompras.contador > 0 Then
    '                    'Desplegar datos en los campos de texto
    '                    TxtNumComprobante.Text = FrmXtraBuscarFacCompras.xCorrelativo
    '                    TxtCAIComprobante.Text = FrmXtraBuscarFacCompras.xCAI
    '                    TxtFechaEmisionComp.Text = FrmXtraBuscarFacCompras.xFecha
    '                    xRetencionID = FrmXtraBuscarFacCompras.RetencionID
    '                    FactCompID = FrmXtraBuscarFacCompras.FactCompID
    '                    CmbGenerarAutoRetenciones.Enabled = True
    '                End If
    '            Catch ex As Exception

    '            End Try
    '        End Sub

    '        Private Sub CmbGenerarAutoRetenciones_Click(sender As Object, e As EventArgs) Handles CmbGenerarAutoRetenciones.Click
    '            Try
    '                Dim resultado_mensaje As String = VerificarCamposObligatorios()
    '                If resultado_mensaje.Equals("1") Then
    '                    CmbBuscarFacturas.Enabled = False
    '                    CmbGenerarAutoRetenciones.Enabled = False

    '                    'Obtener detalle de la factura por compra del proveedor
    '                    Dim dtIDF_DetFactComp As DataTable = New DataTable()
    '                    dtIDF_DetFactComp = ClsAccesos.obtenerDetalleFacCompras(strUsuario, strPassword, 1, FactCompID)
    '                    Dim filas As Integer = dtIDF_DetFactComp.Rows.Count
    '                    If filas > 0 Then
    '                        'Recorrer cada fila del datatable para sumar el monto gravado segun impuesto
    '                        montoGravado = 0
    '                        For Each fila As DataRow In dtIDF_DetFactComp.Rows
    '                            Dim xImpuestoCodigo As String
    '                            xImpuestoCodigo = fila(2)
    '                            Dim xResultado As Integer = InStr(xImpuestoCodigo, "ISV", CompareMethod.Text)
    '                            If xResultado = 1 Then
    '                                'Obtener MontoGravado
    '                                montoGravado = montoGravado + Convert.ToDouble(fila(3))
    '                            End If
    '                        Next

    '                        'Recorrer cada fila del datatable
    '                        For Each fila As DataRow In dtIDF_DetFactComp.Rows
    '                            Dim xImpuestoCodigo As String
    '                            xImpuestoCodigo = fila(2)
    '                            Dim xRetencionID As String = xImpuestoCodigo
    '                            xImpuestoCodigo = xImpuestoCodigo.Replace("RET", "")
    '                            Dim xResultado As Integer = InStr(xRetencionID, "RET", CompareMethod.Text)
    '                            If xResultado = 1 Then
    '                                CmbNuevoItem_Click(sender, e)

    '                                TxtRegItemID.EditValue = 11
    '                                TxtRegRetencionID.EditValue = CInt(xImpuestoCodigo)
    '                                TxtRegTotalBruto.EditValue = montoGravado
    '                                TxtRegDescrip1.Text = "*.*Generacion automatica de retencion desde modulo DMC*.*"

    '                                'Guardar encabezado y detalle de retencion
    '                                CmbRegActualizar_Click(sender, e)
    '                            End If
    '                        Next
    '                    Else
    '                        ClsU.NotaCompleta("No existen datos en detalle de la factura de compra... Favor verifique", 16)
    '                        CmbBuscarFacturas.Enabled = True
    '                        CmbGenerarAutoRetenciones.Enabled = True
    '                    End If
    '                Else
    '                    ClsU.NotaCompleta(resultado_mensaje, 16)
    '                End If
    '            Catch ex As Exception

    '            End Try
    '        End Sub

    '        Private Sub txtFrecuenciaImpresion_TextChanged(sender As Object, e As EventArgs) Handles txtFrecuenciaImpresion.TextChanged
    '            If CInt(txtFrecuenciaImpresion.Text) <= 0 And CInt(txtFrecuenciaImpresion.Text) > 9 Then
    '                ClsU.NotaCompleta("Para la frecuencia de impresion, solo se permiten ingresar de 1 a 9 segundos. Favor intente de nuevo...", 16)
    '            End If
    '        End Sub

    '        Sub MarcarDesmarcarTodos(bandera As Integer)
    '            flagCargar = GrdConsultaView.RowCount
    '            Dim mca As Boolean
    '            For fila As Integer = 0 To flagCargar - 1
    '                If bandera = 1 Then 'Marcar todos
    '                    mca = True
    '                End If
    '                If bandera = 2 Then 'Desmarcar todos
    '                    mca = False
    '                End If
    '                GrdConsultaView.SetRowCellValue(fila, colSelector, mca)
    '            Next
    '        End Sub

    '        Private Sub CmbSelectorTodos_Click(sender As Object, e As EventArgs) Handles CmbSelectorTodos.Click
    '            MarcarDesmarcarTodos(1)
    '        End Sub

    '        Private Sub CmbQuitarSelector_Click(sender As Object, e As EventArgs) Handles CmbQuitarSelector.Click
    '            MarcarDesmarcarTodos(2)
    '        End Sub

    '        Private Sub CmbOpcImpresion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbOpcImpresion.SelectedIndexChanged
    '            If CmbOpcImpresion.SelectedIndex = 0 Then
    '                lblFrecuenciaImpresion.Enabled = False
    '                lblFrecuenciaImpresion.Visible = False
    '                txtFrecuenciaImpresion.Enabled = False
    '                txtFrecuenciaImpresion.Visible = False
    '                CmbSelectorTodos.Enabled = False
    '                CmbQuitarSelector.Enabled = False
    '                CmbQuitarSelector_Click(sender, e)
    '                colSelector.Visible = False
    '            Else
    '                lblFrecuenciaImpresion.Enabled = True
    '                lblFrecuenciaImpresion.Visible = True
    '                txtFrecuenciaImpresion.Enabled = True
    '                txtFrecuenciaImpresion.Visible = True
    '                CmbSelectorTodos.Enabled = True
    '                CmbQuitarSelector.Enabled = True
    '                colSelector.Visible = True
    '            End If
    '        End Sub
    '    End Class
End Class
