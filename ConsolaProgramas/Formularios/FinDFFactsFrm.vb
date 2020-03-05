
Imports System.Data.SqlClient
Imports LibDAO001
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class FinDFFactsFrm
    Public strUsuario, strPassword, StrEmpresa, Acumular_ID, VerificarAcumulado As String
    Public IntTipoDocto As Integer
    Public ClsConexion As New ClsConexion
    Public ClsU As New ClsUtilitarios
    Public ClsDFFacts As IDF_DFFacts
    Public ClsProductos As IDF_Productos
    Public ClsUnidMeds As IDF_UnidMeds
    Public ClsClientes As IDF_Clientes
    Public ClsRetenciones As IDF_Retenciones
    Public ClsTerminos As IDF_Terminos
    Public ClsEmpresas As IDF_Empresas
    Public ClsImpuestos As IDF_Impuestos
    Public ClsTiposDoctos As IDF_TiposDoctos
    Public ClsProdXFact As IDF_ProdXFact
    Public ClsCatProductos As IDF_CatProductos
    Public ClsDFs As IDF_DFs
    Public ClsMonedas As IDF_Monedas
    Public ClsAPR As ClsAPR = New ClsAPR()
    Public ClsAccesos As ClsVistas = Nothing
    Public dtOpciones, dtConfigxEmpresa, dtCxE_Nuevo, dtCxE_Guardar, dtCantMinima, dtIDF_ConfigEmp002 As DataTable
    Public dtIDF_EmpresaAnexo, dtBasculaBoletaBoletaPeso, dtBasculaIDF_DFFacts As DataTable
    Public contador, OpcionConsultar, OpcionModificar, flagCargar As Integer
    Public aplicaBascula As Boolean
    Public msgResultado As MsgBoxResult = New MsgBoxResult()
    Public DialogoResult As DialogResult = New DialogResult()
    Public EsExtendida As Boolean
    Public xFechaLimiteExtendidaCaducada As Integer
    Dim CAI As String
    Dim cnx As SqlConnection
    Dim DtDatosImpuestos As New DataTable
    Dim f As New Funciones()

    Public Sub New(usu As String, pwd As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.


        'Validación si el usuario tiene permisos para anular el botón se muestra habilitado.
        Dim dtUSu As New DataTable
        cnx = New SqlConnection("Persist Security Info=False;User ID=" & usu & ";Password=" & pwd & ";Initial Catalog=Produccion;Server=AMIGODB\AMIGODB")
        f.Conexion = cnx

        dtUSu = f.getDataTable("select * from AAA_listaUSuarios where usuarioID ='" & usu & "' and anulacionFactura = 1")

        If dtUSu.Rows.Count = 0 Then
            CmbAnular.Enabled = False
        End If
    End Sub
    Public Sub FuncionInicial(strU As String, strP As String, StrE As String, IntT As Integer,
                              PerfilID As Integer, PrgID As Integer, FormID As Integer, CAI As String)
        strUsuario = strU
        strPassword = strP
        StrEmpresa = StrE
        IntTipoDocto = IntT
        Me.CAI = CAI

        'Validar que el tipo de documento pertenece a la Empresa y CAI Actual
        ClsAccesos = New ClsVistas()
        dtConfigxEmpresa = ClsAccesos.ObtenerInfoConfigxEmpresa(strUsuario, strPassword, 1, CInt(StrE), IntT)

        Dim oTipoDocto As New IDF_TiposDoctos(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        oTipoDocto = IDF_TiposDoctos.Buscar("TiposDoctoID='" & IntT & "'")
        Me.Text = oTipoDocto.Descripcion

        contador = 0
        contador = dtConfigxEmpresa.Rows.Count
        If contador > 0 Then
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
                    If xTipoOpcionID = CInt(CmbNuevo.Tag.ToString) And xActivo = True Then 'Crear
                        CmbNuevo.Enabled = True
                        CmbGrabarNuevo.Enabled = True
                        CmbGrabarSalir.Enabled = True
                    End If
                    If xTipoOpcionID = CInt(CmbEditar.Tag.ToString) And xActivo = True Then 'Modificar
                        CmbEditar.Enabled = True
                        GrdConsulta.Enabled = True
                        OpcionModificar = 3
                    End If
                    'If xTipoOpcionID = CInt(CmbAnular.Tag.ToString) And xActivo = True Then 'Anular
                    '    CmbAnular.Enabled = True
                    'End If
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
        Else
            ClsU.NotaCompleta("El tipo de documento " & Text & " no esta asignado a esta empresa. Verifique el CAI actual", 48)
        End If
    End Sub

    Private Sub CmbActualizarConsulta_Click(sender As Object, e As EventArgs) Handles CmbActualizarConsulta.Click
        CargarConsulta()
    End Sub

    Public Function ValidarFechaLimiteEmisionCAI() As Integer

        Dim oDetConfigXEmp As New IDF_DetConfigxEmp(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        oDetConfigXEmp = IDF_DetConfigxEmp.BuscarCAI("B.EmpresaCodigo='" & StrEmpresa & "' and A.EsActual=1 and A.TiposDoctoID in (" + Str(IntTipoDocto) + ")")

        'Validar: cantidad de documentos disponible segun CAI actual.
        Dim intEmpresa As Integer = CInt(StrEmpresa)

        dtIDF_ConfigEmp002 = ClsAccesos.ObtenerInfoIDF_ConfigxEmp(strUsuario, strPassword, 1, intEmpresa, oDetConfigXEmp.CAI, IntTipoDocto)
        Dim xFechaLimiteCaducada As Integer = CInt(dtIDF_ConfigEmp002.Rows(0)(5))

        EsExtendida = Convert.ToBoolean(dtIDF_ConfigEmp002.Rows(0)(6))
        xFechaLimiteExtendidaCaducada = CInt(dtIDF_ConfigEmp002.Rows(0)(8))

        'Dim xFechaLimite As String = dtIDF_ConfigEmp002.Rows(0)(3).ToString
        'Dim xFechaHoy As String = dtIDF_ConfigEmp002.Rows(0)(4).ToString

        Return xFechaLimiteCaducada
    End Function

    Public Function ValidarCantidadMinDisponibleCAIxDoc() As Integer
        'Validar: cantidad de documentos disponible segun CAI actual.
        Dim intEmpresa As Integer = CInt(StrEmpresa)

        dtCxE_Nuevo = ClsAccesos.ObtenerInfoConfigxEmpresa2_Fac(strUsuario, strPassword, 1, intEmpresa, IntTipoDocto)
        'Obtener datos de cada columna del DataTable
        Dim xCantOtor As Integer = CInt(dtCxE_Nuevo.Rows(0)(4))
        Dim xNumInicial As Integer = CInt(dtCxE_Nuevo.Rows(0)(5))
        Dim xNumFinal As Integer = CInt(dtCxE_Nuevo.Rows(0)(6))
        Dim xNumActual As Integer = CInt(dtCxE_Nuevo.Rows(0)(7))
        Dim xCAI As String = dtCxE_Nuevo.Rows(0)(9).ToString()
        Dim xCantMinima As Integer = CInt(dtCxE_Nuevo.Rows(0)(11))
        'Dim xTotalFacEmiActualxDoc As Integer = CInt(dtCxE_Nuevo.Rows(0)(23))

        'Validar cantidades
        Dim Resultado As Integer
        Dim TotalFacXEmitirSegunCAI As Integer = (xNumFinal - xNumInicial)

        'Dim TotalFacPendientesxEmitir As Integer = (TotalFacXEmitirSegunCAI - xTotalFacEmiActualxDoc)
        'If (xTotalFacEmiActualxDoc >= xCantMinima) And (xTotalFacEmiActualxDoc <= TotalFacXEmitirSegunCAI) Then
        '    ClsU.NotaCompleta("Aviso: El Sistema ha detectado que este tipo de Documento [" & Text & "]," & _
        '                     " ha rebasado la cantidad minima establecida para esta Empresa de acuerdo al CAI actual [" & xCAI & "]. " &
        '                     "Total de facturas pendientes por emitir: " & TotalFacPendientesxEmitir, 48)
        '    Resultado = 0
        'ElseIf xTotalFacEmiActualxDoc > TotalFacXEmitirSegunCAI Then
        '    ClsU.NotaCompleta("Error: El sistema ha detectado que no tiene cantidad disponible de numeros " & _
        '                      "de facturas para el CAI asignado a esta Empresa. Favor intente de nuevo. " & _
        '                      "Formulario de [" & Text & "] quedara inhabilitado. Se recomienda iniciar el tramite del nuevo CAI en la DEI.", 16)
        '    Resultado = 1
        'End If

        'dtCantMinima = ClsAccesos.ObtenerMaximoDocxEmpresa(strUsuario, strPassword, 1, intEmpresa, IntTipoDocto, xCAI)
        'Dim xCantFacturas As Integer = CInt(dtCantMinima.Rows(0)(0))

        'Validar si el conteo es igual a la cantidad minima
        'Lanzar mensaje de Advertencia
        'Bloqueado por Ing. Manuel Ortega - Martes, 16 de Junio del 2015 - 10:30 am
        'If (xNumActual >= xCantMinima) And (xNumActual < xNumFinal) Then
        '    ClsU.NotaCompleta("Aviso: El Sistema ha detectado que este tipo de Documento [" & Text & "]," & _
        '                      " ha rebasado la cantidad minima establecida segun CAI actual para esta Empresa. " & _
        '                      "Favor iniciar con el tramite de un Nuevo CAI en la Direccion Ejecutiva de Ingresos.", 48)
        '    Me.XTTDatos.SelectedTabPage = Me.XTPEncBasico
        '    Me.XTPEncTotales.PageVisible = False
        '    Nuevo()
        '    CargarItems()
        'ElseIf (xNumActual >= xNumFinal) Then
        '    ClsU.NotaCompleta("Error: El sistema ha detectado que no tiene cantidad disponible de numeros " & _
        '                      "de facturas para el CAI Actual asignado a esta Empresa. Favor intente de nuevo. " & _
        '                      "Formulario de [" & Text & "] quedara inhabilitado", 16)
        '    Me.Enabled = False
        'End If

        Return Resultado
    End Function

    Private Sub CmbNuevo_Click(sender As Object, e As EventArgs) Handles CmbNuevo.Click

        '           Ariel cabrera 19/06/2019
        'contador = ValidarFechaLimiteEmisionCAI()

        'If contador = 1 And EsExtendida = False Then
        '    ClsU.NotaCompleta("Error: El sistema ha detectado que La Fecha Limite de Emision de estos documentos " & _
        '                        "a caducado. Favor tramitar el nuevo CAI en la Direccion Ejecutiva de Ingresos... " & _
        '                            "Formulario de [" & Text & "] quedara inhabilitado", 16)
        'End If

        'If contador = 1 Then
        '    'Si el CAI, tiene fecha extendida (Solicitud de Prorroga Facturacion)
        '    If EsExtendida = True And xFechaLimiteExtendidaCaducada = 1 Then
        '        ClsU.NotaCompleta("Error: El sistema ha detectado que La Fecha Limite de Emision Extendida de estos documentos " & _
        '                         "a caducado. Favor tramitar el nuevo CAI en la Direccion Ejecutiva de Ingresos... " & _
        '                             "Formulario de [" & Text & "] quedara inhabilitado", 16)
        '    End If
        '    If EsExtendida = True And xFechaLimiteExtendidaCaducada = 0 Then
        '        contador = 0
        '    End If
        'End If     
        'If contador = 0 Then

        '    'If contador = 0 Then
        '    Me.XTTDatos.SelectedTabPage = Me.XTPEncBasico
        '    Me.XTPEncTotales.PageVisible = False

        '    Nuevo()
        '    CargarItems()
        '    'End If
        'End If
        'If contador = 1 Then
        '    Me.Close()
        'End If
        'End If

        ' Ariel cabrera 19/06/2019
        Me.XTTDatos.SelectedTabPage = Me.XTPEncBasico
        Me.XTPEncTotales.PageVisible = False

        Nuevo()
        CargarItems()

    End Sub
    Private Sub CmbEditar_Click(sender As Object, e As EventArgs) Handles CmbEditar.Click
        If FacturaEstado() Then
            MsgBox("Factura Anulada no puede ser editada!", MsgBoxStyle.Information, "Factura Anulada")
        Else
            Dim nDFFactID As String

            'Validar si el tipo de impresion es "Multiple filas"
            contador = VerificarCantidadFilasSelector(GrdConsultaView.RowCount)
            If contador >= 0 And contador < 2 Then
                nDFFactID = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "DFFactID")

                Try
                    If OpcionModificar = 3 Then
                        CmbGrabarNuevo.Enabled = True
                        CmbGrabarSalir.Enabled = True
                        CmbNuevoItem.Enabled = True
                        CmbEliminarItem.Enabled = True
                        cmbModificarItem.Enabled = True
                        Editar(nDFFactID)
                        CargarItems()
                    End If

                Catch ex As Exception
                    ClsU.NotaCompleta("Debe de elegir un registro para editar. " & ex.Message, 16)
                    'ClsU.Nota("Debe de elegir un registro para editar.")
                End Try
            End If
            If contador >= 2 Then
                ClsU.NotaCompleta("No se permite editar multiples documentos a la vez, intente de nuevo", 16)
            End If
        End If
    End Sub

    Private Sub CmbNuevoItem_Click(sender As Object, e As EventArgs) Handles CmbNuevoItem.Click
        NuevoItem()
    End Sub
    Private Sub CmbEliminarItem_Click(sender As Object, e As EventArgs) Handles CmbEliminarItem.Click
        Try
            Dim nProdXFactID As Integer
            nProdXFactID = Me.GrdVwItems.GetRowCellValue(Me.GrdVwItems.FocusedRowHandle, "ProdXFactID")

            EliminarItem(nProdXFactID)
            CargarItems()

            Totalizar(Me.TxtDFFactID.Text)

        Catch ex As Exception
            ClsU.NotaCompleta("Debe de elegir un registro para eliminar. [" & ex.Message & "]", 16)
        End Try
    End Sub
    Private Sub cmbModificarItem_Click(sender As Object, e As EventArgs) Handles cmbModificarItem.Click
        Try
            Dim nProdXFactID As Integer
            nProdXFactID = Me.GrdVwItems.GetRowCellValue(Me.GrdVwItems.FocusedRowHandle, "ProdXFactID")

            ModificarItem(nProdXFactID)

        Catch ex As Exception

            ClsU.NotaCompleta("Debe de elegir un registro para modificar. [" & ex.Message & "]", 16)

        End Try
    End Sub
    Private Sub CmbRegActualizar_Click(sender As Object, e As EventArgs)
        'Intento para salvar el encabezado de la factura, solo cuando el DFFACTID=0
        Try
            Dim resultado_mensaje As String = VerificarCamposObligatorios()
            If resultado_mensaje.Equals("1") Then
                If Me.TxtDFFactID.Text = 0 Then
                    Grabar(Me.LblAccion.Text)
                End If

                GrabarItem(Me.GrpRegistro.Text)
                CargarItems()

                Totalizar(Me.TxtDFFactID.Text)
            Else
                ClsU.NotaCompleta(resultado_mensaje, 16)
            End If

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al actualizar registro. [" & ex.Message & "]", 16)
        End Try

    End Sub

    Private Sub CmbRegCancelar_Click(sender As Object, e As EventArgs)
        CancelarItem()
    End Sub

    Private Sub GrdConsulta_DoubleClick(sender As Object, e As EventArgs) Handles GrdConsulta.DoubleClick
        If FacturaEstado() Then 'Validación, sí la factura está anulada no se puede modificar.
            MsgBox("Factura Anulada no puede ser editada!", MsgBoxStyle.Information, "Factura Anulada")
        Else
            Dim nDFFactID As Integer
            nDFFactID = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "DFFactID")

            Try
                If OpcionConsultar = 2 Then
                    CmbGrabarNuevo.Enabled = False
                    CmbGrabarSalir.Enabled = False
                    CmbNuevoItem.Enabled = False
                    CmbEliminarItem.Enabled = False
                    cmbModificarItem.Enabled = False
                    'CmbRegActualizar.Enabled = False
                    Editar(nDFFactID)
                    CargarItems()
                End If
            Catch ex As Exception
                ClsU.NotaCompleta("Debe de elegir un registro para editar. " & ex.Message, 16)
            End Try
        End If
    End Sub

    Private Sub CmbRegresarConsulta_Click(sender As Object, e As EventArgs) Handles CmbRegresarConsulta.Click
        RegresarConsulta()
    End Sub

    Private Sub CmbGrabarNuevo_Click(sender As Object, e As EventArgs) Handles CmbGrabarNuevo.Click
        Dim resultado_mensaje As String = VerificarCamposObligatorios()
        If resultado_mensaje.Equals("1") Then
            Grabar(Me.LblAccion.Text)
            Nuevo()
            CargarItems()
        Else
            ClsU.NotaCompleta(resultado_mensaje, 16)
        End If
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
        If TxtSdNCodigo.Text.Equals("") = True Then
            strMensaje = "Codigo de cliente vacio o nulo. Favor revisar..."
        ElseIf TxtSdNCodigo.Text.Length = 0 Then
            strMensaje = "Codigo de cliente vacio o nulo. Favor revisar..."
        ElseIf TxtSdNCodigo.EditValue.ToString.Length = 0 Then
            strMensaje = "Codigo de cliente vacio o nulo. Favor revisar..."
        ElseIf IsNothing(TxtSdNCodigo.Text) Then
            strMensaje = "Codigo de cliente vacio o nulo. Favor revisar..."
        ElseIf TxtMonedaCodigo.Text.Equals("") = True Then
            strMensaje = "Error: codigo de moneda vacio. Favor intente de nuevo"
        ElseIf TxtMonedaCodigo.Text.Length = 0 Then
            strMensaje = "Error: codigo de moneda vacio. Favor intente de nuevo"
        ElseIf TxtMonedaCodigo.EditValue.ToString.Length = 0 Then
            strMensaje = "Error: codigo de moneda vacio. Favor intente de nuevo"
        ElseIf IsNothing(TxtMonedaCodigo.Text) Then
            strMensaje = "Error: codigo de moneda vacio. Favor intente de nuevo"
        ElseIf TxtTerminoCodigo.Text.Equals("") = True Then
            strMensaje = "Error: Favor seleccionar termino de pago. Intente de nuevo"
        ElseIf TxtTerminoCodigo.Text.Length = 0 Then
            strMensaje = "Error: Favor seleccionar termino de pago. Intente de nuevo"
        ElseIf IsNothing(TxtTerminoCodigo.Text) Then
            strMensaje = "Error: Favor seleccionar termino de pago. Intente de nuevo"
        ElseIf TxtTerminoCodigo.EditValue.ToString.Length = 0 Then
            strMensaje = "Error: Favor seleccionar termino de pago. Intente de nuevo"
        ElseIf TxtRegImptoCodigo.Text.Length = 0 Then
            strMensaje = "Error: Favor seleccionar una categoria de impuesto. Intente de nuevo"
        Else
            strMensaje = "1"
        End If

        Return strMensaje
    End Function

    Private Sub TxtRegProdCodigo_EditValueChanged(sender As Object, e As EventArgs) Handles TxtRegProdCodigo.EditValueChanged
        If Me.TxtRegProdCodigo.Text.Length > 0 Then
            UbicarProducto()
            CalcImptoDescto()
        End If
    End Sub

    Private Sub TxtRegImptoCodigo_EditValueChanged(sender As Object, e As EventArgs) Handles TxtRegImptoCodigo.EditValueChanged
        CalcImptoDescto()
    End Sub

    Private Sub TxtRegDesctoMonto_LostFocus(sender As Object, e As EventArgs) Handles TxtRegDesctoMonto.LostFocus
        CalcImptoDescto()
    End Sub

    Private Sub TxtRegCantidad_LostFocus(sender As Object, e As EventArgs) Handles TxtRegCantidad.LostFocus
        CalcImptoDescto()
    End Sub

    Private Sub TxtRegPrecio_LostFocus(sender As Object, e As EventArgs) Handles TxtRegPrecio.LostFocus
        CalcImptoDescto()
    End Sub

    Private Sub CmbAnular_Click(sender As Object, e As EventArgs) Handles CmbAnular.Click
        If FacturaEstado() Then
            MsgBox("Factura ya se encuentra anulada!", MsgBoxStyle.Information, "Factura Anulada")
        Else
            msgResultado = ClsU.NotaCompletaPregunta("¿Desea anular este documento?", 128)
            If msgResultado = MsgBoxResult.Yes Then
                Dim nDFFactID As Integer
                nDFFactID = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "DFFactID")
                Try
                    Anular(nDFFactID, 2) '2=Anulado
                    CargarConsulta()
                Catch ex As Exception
                    ClsU.NotaCompleta("Debe de elegir un registro para anular. " & ex.Message, 16)
                End Try
            End If
        End If
    End Sub

    Private Sub FinDFFactsFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargarConsulta()
        CargarRegistros()
        Personalizar()
    End Sub

    Private Sub CmbImprimir_Click(sender As Object, e As EventArgs) Handles CmbImprimir.Click
        Dim nDFFactID, nRespuesta As Integer

        'Validar si el usurio selecciono mas de una fila para la impresion previa
        Dim contador As Integer = GrdConsultaView.RowCount
        If contador > 0 Then

            'Confirmación de impresión 1 fila a la vez
            If CmbOpcImpresion.SelectedIndex = 0 Then

                nDFFactID = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "DFFactID")
                Try
                    Imprimir(nDFFactID, "-1", PrintDialog1)

                Catch ex As Exception
                    ClsU.NotaCompleta("Debe de elegir un registro para imprimir. " & ex.Message, 16)
                End Try
            Else
                nRespuesta = VerificarCantidadFilasSelector(contador)
                If nRespuesta = 0 Then
                    ClsU.NotaCompleta("Debe de elegir registros para imprimir. ", 16)
                Else
                    'Impresion multiples filas
                    nRespuesta = ClsU.NotaCompletaPregunta("Iniciando proceso de impresión masiva. Favor revisar los documentos antes de realizar esta accion... " & _
                                                           "¿Desea continuar?", 128)

                    If nRespuesta = 7 Then
                        Exit Sub
                    End If

                    Acumular_ID = ""
                    If (txtFrecuenciaImpresion.Text.Equals("") = True) Or (Len(txtFrecuenciaImpresion.Text) = 0) Then
                        ClsU.NotaCompleta("Valor de tiempo de frecuencia invalido o nulo... Favor intente de nuevo.", 16)
                        txtFrecuenciaImpresion.Focus()
                        txtFrecuenciaImpresion.Text = "1"
                    Else
                        Dim Frecuencia As Integer = CInt(txtFrecuenciaImpresion.Text)

                        If Frecuencia > 0 Then
                            PrintDialog1.ShowDialog()
                            Dim ThreadSleep As Integer = (Frecuencia * 1000)
                            For fila As Integer = 0 To contador - 1
                                Dim marca As Boolean = GrdConsultaView.GetRowCellValue(fila, colSelector)
                                If marca = True Then
                                    Dim id As String = GrdConsultaView.GetRowCellValue(fila, colDFFactID).ToString
                                    Acumular_ID = Acumular_ID & id & ","
                                    Imprimir(id, "1", PrintDialog1)
                                    System.Threading.Thread.Sleep(ThreadSleep)
                                End If
                            Next

                            'Quitar las marcas
                            CmbQuitarSelector_Click(sender, e)
                        Else
                            ClsU.NotaCompleta("Valor de tiempo de impresion cero... Intente de nuevo. Es permitido valores de 1 a 9 segundos.", 16)
                        End If

                    End If

                End If
            End If
        End If
    End Sub

    Public Function VerificarCantidadFilasSelector(zcont As Integer) As Integer
        Dim x_contador As Integer
        x_contador = 0
        For fila As Integer = 0 To zcont - 1
            Dim marca As Boolean = GrdConsultaView.GetRowCellValue(fila, colSelector)
            If marca = True Then
                x_contador = x_contador + 1
            End If
        Next
        Return x_contador
    End Function

    Public Function xGetSelectedDataRows() As Integer()
        Dim result As List(Of Integer) = GrdConsultaView.GetSelectedRows().ToList()
        result.RemoveAll(Function(x) x < 0)
        Return result.ToArray()
    End Function

    Private Sub TxtSdNCodigo_EditValueChanged(sender As Object, e As EventArgs) Handles TxtSdNCodigo.EditValueChanged
        CargarDFs(Me.TxtSdNCodigo.EditValue)
    End Sub

#Region "Procedimientos Definidos por el usuario"
    Public Sub Personalizar()
        CmbOpcImpresion.SelectedIndex = 0
        'Exportaciones
        Me.XTPEncExport.PageVisible = False

        Select Case IntTipoDocto
            Case 7
                Me.XTPEncExport.PageVisible = True
            Case 9
                LblFactNum.Text = "N°. Boleta Compra:"
                LblCodigoRotulo.Text = "N°. Boleta Compra:"
                LblSdN.Text = "Proveedor:"
        End Select
    End Sub
    Public Sub UbicarProducto()

        Dim oProdRegistro As New IDF_Productos(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        oProdRegistro = IDF_Productos.Buscar("ProdCodigo='" & TxtRegProdCodigo.EditValue & "'")

        Me.TxtRegUnidMedCodigo.Text = oProdRegistro.UnidMed
        Me.TxtRegPrecio.EditValue = oProdRegistro.Precio

        'En el caso que la empresa no necesite obtener el peso desde bascula por medio de una Orden.
        If aplicaBascula = False Then
            Me.TxtRegCantidad.EditValue = 1
        End If

        Me.TxtRegImptoCodigo.EditValue = oProdRegistro.ImptoCodigo

        'Ariel Cabrera
        ''Filtrado de listado de impuesto, por el impuesto seleccionado al aseleccionar el producto.
        'DtDatosImpuestos.DefaultView.RowFilter = "TaxCat = '" & TxtRegImptoCodigo.EditValue & "'"
    End Sub
    Public Sub CalcImptoDescto()
        Dim nCantidad, nPrecio, nTotalBruto, nDescuento, nImpuesto, nTotalNeto As Double
        Dim oImptoRegistro As New IDF_Impuestos(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        nCantidad = Me.TxtRegCantidad.EditValue
        nPrecio = Me.TxtRegPrecio.EditValue
        nTotalBruto = nCantidad * nPrecio
        nDescuento = Me.TxtRegDesctoMonto.EditValue
        nImpuesto = 0

        Me.TxtRegTotalBruto.EditValue = nCantidad * nPrecio

        If Me.TxtRegImptoCodigo.EditValue.ToString.Length > 0 Then

            Try
                oImptoRegistro = IDF_Impuestos.Buscar("TaxCat='" & Me.TxtRegImptoCodigo.EditValue & "'")
                nImpuesto = (nTotalBruto - nDescuento) * oImptoRegistro.Percentage

            Catch ex As Exception

                Me.TxtRegImptoCodigo.Focus()
                ClsU.NotaCompleta("Error con registro del impuesto [" & Me.TxtRegImptoCodigo.EditValue & "] " & ex.Message, 16)

            End Try
        End If

        nTotalNeto = nTotalBruto - nDescuento + nImpuesto

        Me.TxtRegImptoMonto.Text = nImpuesto
        Me.TxtRegTotalNeto.Text = nTotalNeto

    End Sub
    Public Sub CargarConsulta()
        Dim DtDatosDFFacts As New DataTable

        ClsDFFacts = New IDF_DFFacts(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Try
            'DtDatosDFFacts = IDF_DFFacts.Tabla("SELECT dbo.IDF_DFFacts.*,(dbo.IDF_DFFacts.SdNCodigo + ' - ' + dbo.IDF_SdNs.Description) AS NombreCliente,(SELECT u.UsuarioID + ' - ' + u.Nombre FROM Produccion.dbo.AAA_ListaUsuarios u WHERE u.UsuarioID = dbo.IDF_DFFacts.UsuCreador) AS CreadoPor " & _
            '                                   "FROM dbo.IDF_DFFacts LEFT OUTER JOIN " & _
            '                                   "dbo.IDF_SdNs ON dbo.IDF_DFFacts.SdNCodigo = dbo.IDF_SdNs.TP Where TiposDoctoID in (" & IntTipoDocto & ") and EmpresaCodigo = '" & StrEmpresa & "' Order by FactNum")

            DtDatosDFFacts = IDF_DFFacts.Tabla("SELECT cast(0 AS Bit) AS Seleccionar,a.* FROM vwIDFObtenerFacturasxCliente a " & _
                                                " WHERE a.TiposDoctoID IN (" & IntTipoDocto & ") AND a.EmpresaCodigo = '" & StrEmpresa & "' ORDER BY a.FactNum ")

            Me.GrdConsulta.DataSource = DtDatosDFFacts

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Documentos Fuente. " & ex.Message, 16)
        End Try

    End Sub
    Public Sub CargarRegistros()
        Dim DtDatosProductos As New DataTable
        Dim DtDatosUnidMeds As New DataTable
        Dim DtDatosClientes As New DataTable
        Dim DtDatosRetenciones As New DataTable
        Dim DtDatosTerminos As New DataTable
        Dim DtDatosEmpresas As New DataTable
        Dim DtDatosDFs As New DataTable
        Dim DtDatosTiposDoctos As New DataTable
        Dim DtMonedas As New DataTable
        Dim DtCatProductos As New DataTable

        ClsProductos = New IDF_Productos(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        ClsUnidMeds = New IDF_UnidMeds(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        ClsClientes = New IDF_Clientes(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        ClsRetenciones = New IDF_Retenciones(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        ClsTerminos = New IDF_Terminos(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        ClsEmpresas = New IDF_Empresas(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        ClsDFs = New IDF_DFs(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        ClsImpuestos = New IDF_Impuestos(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        ClsTiposDoctos = New IDF_TiposDoctos(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        ClsMonedas = New IDF_Monedas(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

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
            DtDatosRetenciones = IDF_Retenciones.Tabla()
            Me.TxtRetencionID.Properties.DataSource = DtDatosRetenciones
            Me.TxtRetencionID.Properties.ValueMember = DtDatosRetenciones.Columns(0).ToString()
            Me.TxtRetencionID.Properties.DisplayMember = DtDatosRetenciones.Columns(1).ToString()

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Retenciones. " & ex.Message, 16)
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
            DtDatosTerminos = IDF_Terminos.Tabla()
            Me.TxtTerminoCodigo.Properties.DataSource = DtDatosTerminos
            Me.TxtTerminoCodigo.Properties.ValueMember = DtDatosTerminos.Columns(0).ToString()
            Me.TxtTerminoCodigo.Properties.DisplayMember = DtDatosTerminos.Columns(1).ToString()

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Términos. " & ex.Message, 16)
        End Try

        Try
            'DtDatosImpuestos = IDF_Impuestos.Tabla("Select * From IDF_Impuestos Where Right(TaxCat,2)='" & StrEmpresa & "' or TaxCat='ISV0'") 'Ariel cabrera, 
            DtDatosImpuestos = IDF_Impuestos.Tabla("spIDF_ImpuestosSelect '" & StrEmpresa & "'") ' Where Right(TaxCat,2)='" & StrEmpresa & "' or TaxCat='ISV0'")
            Me.TxtRegImptoCodigo.Properties.DataSource = DtDatosImpuestos
            Me.TxtRegImptoCodigo.Properties.ValueMember = DtDatosImpuestos.Columns(0).ToString()
            Me.TxtRegImptoCodigo.Properties.DisplayMember = DtDatosImpuestos.Columns(1).ToString()

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Impuestos. " & ex.Message, 16)
        End Try

        Try
            DtDatosTiposDoctos = IDF_TiposDoctos.Tabla("Select * From IDF_TiposDoctos Where EsFacturaXVta = 1")
            Me.TxtTiposDoctoID.Properties.DataSource = DtDatosTiposDoctos
            Me.TxtTiposDoctoID.Properties.ValueMember = DtDatosTiposDoctos.Columns(0).ToString()
            Me.TxtTiposDoctoID.Properties.DisplayMember = DtDatosTiposDoctos.Columns(1).ToString()

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Tipos de Documentos. " & ex.Message, 16)
        End Try

        Try
            DtMonedas = IDF_TiposDoctos.Tabla("Select * From IDF_Monedas")
            Me.TxtMonedaCodigo.Properties.DataSource = DtMonedas
            Me.TxtMonedaCodigo.Properties.ValueMember = DtMonedas.Columns(0).ToString()
            Me.TxtMonedaCodigo.Properties.DisplayMember = DtMonedas.Columns(1).ToString()

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Monedas. " & ex.Message, 16)
        End Try

    End Sub
    Public Sub CargarDFs(cCliente As String)
        Dim DtDatosDFs As New DataTable
        ClsDFs = New IDF_DFs(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Try
            DtDatosDFs = IDF_DFs.Tabla("Select * From IDF_DFs Where Company='" & StrEmpresa & "' and Recipient = '" & cCliente & "'")
            Me.TxtDFID.Properties.DataSource = DtDatosDFs
            Me.TxtDFID.Properties.ValueMember = DtDatosDFs.Columns(0).ToString()
            Me.TxtDFID.Properties.DisplayMember = DtDatosDFs.Columns(1).ToString()

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Documentos Fuentes. " & ex.Message, 16)
        End Try
    End Sub
    Public Sub CargarItems()
        ClsProdXFact = New IDF_ProdXFact(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Dim DtDatosProdXFact As New DataTable

        Try
            DtDatosProdXFact = IDF_ProdXFact.Tabla("SELECT * FROM IDF_ProdXFact WHERE DFFactID='" & Me.TxtDFFactID.Text & "'")
            Me.GrdItems.DataSource = DtDatosProdXFact

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Líneas de la Factura. " & ex.Message, 16)
        End Try

    End Sub
    Public Sub Nuevo()
        Dim nDFFactNum As Integer

        Me.lblEstado.Text = "En Proceso"
        Me.LblAccion.Text = "Nuevo registro."
        Me.LblCodigoValor.Text = "<NuevoValor>"
        Me.XTTEmpaginacion.SelectedTabPage = XTTPagina2

        Dim oDFFactNuevo As New IDF_DFFacts(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        Dim oConfigXEmp As New IDF_ConfigxEmp(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        Dim oEmpAnexo As New IDF_EmpresasAnexo(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        Dim oDetConfigXEmp As New IDF_DetConfigxEmp(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        oConfigXEmp = IDF_ConfigxEmp.Buscar("A.EmpresaCodigo='" & StrEmpresa & "' and B.EsActual=1 and B.TiposDoctoID in (Select TiposDoctoID From IDF_TiposDoctos Where esFacturaXVta=1)")
        If IntTipoDocto = 9 Then
            oConfigXEmp = IDF_ConfigxEmp.Buscar("A.EmpresaCodigo='" & StrEmpresa & "' and B.EsActual=1 and B.TiposDoctoID in (Select TiposDoctoID From IDF_TiposDoctos Where esBoletaCompra=1)")
        End If

        'nDFFactNum = IDF_DFFacts.SigDFFact(IntTipoDocto, StrEmpresa)
        nDFFactNum = IDF_DFFacts.SigDFFactCAI(IntTipoDocto, StrEmpresa, oConfigXEmp.CAI)
        oEmpAnexo = IDF_EmpresasAnexo.Buscar("EmpresaCodigo='" & StrEmpresa & "'")

        'Ariel Cabrera 19/06/2019
        oDetConfigXEmp = IDF_DetConfigxEmp.BuscarCAI("b.CAI = '" & CAI & "'") 'IDF_DetConfigxEmp.BuscarCAI("B.EmpresaCodigo='" & StrEmpresa & "' and A.EsActual=1 and A.TiposDoctoID in (" + Str(IntTipoDocto) + ")")

        'contador = ValidarCantidadMinDisponibleCAIxDoc()
        'Validar: cantidad de documentos disponible segun CAI actual.
        Dim intEmpresa As Integer = CInt(StrEmpresa)

        dtCxE_Nuevo = ClsAccesos.ObtenerInfoConfigxEmpresa2_Fac(strUsuario, strPassword, 1, intEmpresa, IntTipoDocto)
        'Obtener datos de cada columna del DataTable
        Dim xCantOtor As Integer = CInt(dtCxE_Nuevo.Rows(0)(4))
        Dim xNumInicial As Integer = CInt(dtCxE_Nuevo.Rows(0)(5))
        Dim xNumFinal As Integer = CInt(dtCxE_Nuevo.Rows(0)(6))
        Dim xNumActual As Integer = CInt(dtCxE_Nuevo.Rows(0)(7))
        Dim xCAI As String = dtCxE_Nuevo.Rows(0)(9).ToString()
        Dim xCantMinima As Integer = CInt(dtCxE_Nuevo.Rows(0)(11))
        'Dim xTotalFacEmiActualxDoc As Integer = CInt(dtCxE_Nuevo.Rows(0)(23))

        'Validar cantidades
        Dim TotalFacXEmitirSegunCAI As Integer = (xNumFinal - xNumInicial)
        If nDFFactNum >= xNumInicial And nDFFactNum <= xNumFinal Then
            Me.TxtFactNum.Text = Format(nDFFactNum, "00000000") 'Número de factura.

            Me.TxtDescripcion.Focus()

            Me.TxtDFFactID.Text = oDFFactNuevo.DFFactID
            'Me.TxtCAI.Text = oConfigXEmp.CAI --Bloqueado por Ing. Manuel Ortega - Sabado, 07-05-2016 - 10:52AM
            Me.TxtCAI.Text = CAI 'oDetConfigXEmp.CAI 'cambio Ariel Cabrera 18/06/2019
            'Me.TxtCAI.Text = cbxPunto.EditValue
            Me.TxtFecha.Text = Now()
            Me.TxtDescripcion.Text = oDFFactNuevo.Descripcion
            Me.TxtSdNCodigo.Text = oDFFactNuevo.SdNCodigo
            Me.TxtRetencionID.EditValue = oEmpAnexo.RetencionID
            Me.TxtEmpresaCodigo.Text = StrEmpresa
            Me.TxtTotalBruto.Text = oDFFactNuevo.TotalBruto
            Me.TxtDesctoMonto.Text = oDFFactNuevo.DesctoMonto
            Me.TxtImptoMonto.Text = oDFFactNuevo.ImptoMonto
            Me.TxtTotalNeto.Text = oDFFactNuevo.TotalNeto
            Me.TxtTerminoCodigo.Text = oDFFactNuevo.TerminoCodigo
            Me.TxtDFID.Text = oDFFactNuevo.DFID
            Me.TxtTiposDoctoID.EditValue = IntTipoDocto

            Me.TxtBarco.Text = oDFFactNuevo.Barco
            Me.TxtAcuerdo.Text = oDFFactNuevo.Acuerdo
            Me.TxtFechaEmbarque.Text = Now()
            Me.TxtPuertoCarga.Text = oDFFactNuevo.PuertoCarga
            Me.TxtPuertoDescarga.Text = oDFFactNuevo.PuertoDescarga
            Me.TxtConocimientoEmbarque.Text = oDFFactNuevo.ConocimEmbarque
            Me.TxtCambioDolar.Text = 1
            Me.TxtFDA.Text = oEmpAnexo.FDA
            Me.memoTxtNotificarA.Text = oDFFactNuevo.NotificarA

            Me.TxtMonedaCodigo.EditValue = oDFFactNuevo.MonedaCodigo
            Me.TxtNConstancia.Text = oDFFactNuevo.NConstancia
            Me.TxtNOCExenta.Text = oDFFactNuevo.NOCExenta
            Me.TxtNSAG.Text = oDFFactNuevo.NSAG

            Me.CmbNuevoItem.Enabled = True
            Me.CmbEliminarItem.Enabled = False
            Me.cmbModificarItem.Enabled = False
            Me.XTPEncTotales.PageVisible = False
            TlSNotas.Enabled = True
            XTTDatos.Enabled = True
            XTTDetalle.Enabled = True
            CmbNuevoItem.Enabled = True
            CmbEliminarItem.Enabled = True
            cmbModificarItem.Enabled = True
            GrpRegistro.Enabled = True
        Else
            ClsU.NotaCompleta("Error: El sistema ha detectado que no tiene cantidad disponible de numeros " & _
                              "de facturas para el CAI asignado a esta Empresa. Favor intente de nuevo. " & _
                              "Formulario de [" & Text & "] quedara inhabilitado. Se recomienda iniciar el tramite del nuevo CAI (SAR).", 16)
            TlSNotas.Enabled = False
            XTTDatos.Enabled = False
            XTTDetalle.Enabled = False
            CmbNuevoItem.Enabled = False
            CmbEliminarItem.Enabled = False
            cmbModificarItem.Enabled = False
            GrpRegistro.Enabled = False

        End If

    End Sub
    Public Sub Editar(nDato As Integer)

        Me.LblAccion.Text = "Edición de datos."

        Dim oFactEdicion As New IDF_DFFacts(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        oFactEdicion = IDF_DFFacts.Buscar("DFFactID='" & nDato & "'")

        Me.LblCodigoValor.Text = oFactEdicion.FactNum
        Me.TxtFactNum.Text = oFactEdicion.FactNum

        Me.TxtFactNum.Enabled = False

        Me.TxtDFFactID.Text = oFactEdicion.DFFactID
        Me.TxtCAI.Text = oFactEdicion.CAI
        Me.TxtFecha.Text = oFactEdicion.Fecha
        Me.TxtDescripcion.Text = oFactEdicion.Descripcion
        Me.TxtSdNCodigo.Text = oFactEdicion.SdNCodigo
        Me.TxtRetencionID.Text = oFactEdicion.RetencionID
        Me.TxtEmpresaCodigo.Text = oFactEdicion.EmpresaCodigo
        Me.TxtTotalBruto.Text = oFactEdicion.TotalBruto
        Me.TxtDesctoMonto.Text = oFactEdicion.DesctoMonto
        Me.TxtImptoMonto.Text = oFactEdicion.ImptoMonto
        Me.TxtTotalNeto.Text = oFactEdicion.TotalNeto
        Me.TxtTotalExento.Text = oFactEdicion.TotalExento
        Me.TxtTerminoCodigo.Text = oFactEdicion.TerminoCodigo
        Me.TxtRetencionID.Text = oFactEdicion.RetencionID
        Me.TxtDFID.Text = oFactEdicion.DFID
        Me.TxtTiposDoctoID.EditValue = oFactEdicion.TiposDoctoID

        Me.TxtBarco.Text = oFactEdicion.Barco
        Me.TxtAcuerdo.Text = oFactEdicion.Acuerdo
        Me.TxtFechaEmbarque.Text = oFactEdicion.FechaEmbarque
        Me.TxtPuertoCarga.Text = oFactEdicion.PuertoCarga
        Me.TxtPuertoDescarga.Text = oFactEdicion.PuertoDescarga
        Me.TxtConocimientoEmbarque.Text = oFactEdicion.ConocimEmbarque
        Me.TxtCambioDolar.Text = oFactEdicion.CambioDolar
        Me.TxtFDA.Text = oFactEdicion.FDA
        Me.memoTxtNotificarA.Text = oFactEdicion.NotificarA
        Me.TxtNumeroOrden.Text = oFactEdicion.NumeroOrden
        Me.memoTxtInfoExtra.Text = oFactEdicion.InfoExtra
        Me.TxtNConstancia.Text = oFactEdicion.NConstancia
        Me.TxtNOCExenta.Text = oFactEdicion.NOCExenta
        Me.TxtNSAG.Text = oFactEdicion.NSAG

        Me.TxtMonedaCodigo.EditValue = oFactEdicion.MonedaCodigo

        Me.lblEstado.Text = IIf(oFactEdicion.Estado = 0, "En Proceso", IIf(oFactEdicion.Estado = 1, "Aprobado", "Anulado"))

        Me.XTTEmpaginacion.SelectedTabPage = XTTPagina2
        Me.XTPEncTotales.PageVisible = True

    End Sub
    Public Sub NuevoItem()
        Me.XTTDetalle.SelectedTabPage = XTTRegPagina1
        Me.GrpRegistro.Text = "Nuevo registro."

        Dim oProdXDFFactReg As New IDF_ProdXFact(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        'En el caso que la empresa no necesite conectarse al Sistema de Bascula.
        If aplicaBascula = False Then
            Me.TxtRegProdXFactID.Text = oProdXDFFactReg.ProdXFactID
            Me.TxtRegImptoCodigo.EditValue = oProdXDFFactReg.ImptoCodigo

            Me.TxtRegCantidad.EditValue = oProdXDFFactReg.Cantidad
            Me.TxtRegProdCodigo.EditValue = oProdXDFFactReg.ProdCodigo

            Me.TxtRegPrecio.EditValue = oProdXDFFactReg.Precio
            Me.TxtRegTotalBruto.EditValue = oProdXDFFactReg.TotalBruto
            Me.TxtRegDesctoMonto.EditValue = oProdXDFFactReg.DesctoMonto
            Me.TxtRegTotalNeto.EditValue = oProdXDFFactReg.TotalNeto
            Me.TxtRegUnidMedCodigo.EditValue = oProdXDFFactReg.UnidMedCodigo
            Me.TxtRegDescrip1.Text = oProdXDFFactReg.Descrip1
            Me.TxtRegDescrip2.Text = oProdXDFFactReg.Descrip2
            Me.TxtRegImptoMonto.EditValue = oProdXDFFactReg.ImptoMonto
        End If

        ActivarItem()
    End Sub
    Public Sub EliminarItem(nDato As Integer)
        Dim oProdXFact As New IDF_ProdXFact(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        oProdXFact.ProdXFactID = nDato

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

        Dim oProdXDFFactReg As New IDF_ProdXFact(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        oProdXDFFactReg = IDF_ProdXFact.Buscar("ProdXFactID='" & nDato & "'")

        Me.TxtRegProdXFactID.Text = oProdXDFFactReg.ProdXFactID
        Me.TxtRegProdCodigo.EditValue = oProdXDFFactReg.ProdCodigo
        Me.TxtRegImptoCodigo.EditValue = oProdXDFFactReg.ImptoCodigo
        Me.TxtRegCantidad.EditValue = oProdXDFFactReg.Cantidad
        Me.TxtRegPrecio.EditValue = oProdXDFFactReg.Precio
        Me.TxtRegTotalBruto.EditValue = oProdXDFFactReg.TotalBruto
        Me.TxtRegDesctoMonto.EditValue = oProdXDFFactReg.DesctoMonto
        Me.TxtRegTotalNeto.EditValue = oProdXDFFactReg.TotalNeto
        Me.TxtRegUnidMedCodigo.EditValue = oProdXDFFactReg.UnidMedCodigo
        Me.TxtRegDescrip1.Text = oProdXDFFactReg.Descrip1
        Me.TxtRegDescrip2.Text = oProdXDFFactReg.Descrip2
        Me.TxtRegImptoMonto.EditValue = oProdXDFFactReg.ImptoMonto

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

    Public Sub RegresarConsulta()
        Me.XTTEmpaginacion.SelectedTabPage = XTTPagina1
        LblConexionBascula.Text = "..."
    End Sub

    Public Sub Grabar(cAccion As String)

        Dim cFactNum, cEmpresaCodigo As String

        Dim oDFFactRegistro As New IDF_DFFacts(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        Dim oDFFactRegistroCopia As New IDF_DFFacts(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        If Len(Me.TxtFactNum.Text) = 0 Then
            'ClsU.Nota("Se requiere un Nmero de Factura válido.")
            If IntTipoDocto = 1 Or IntTipoDocto = 7 Then
                ClsU.NotaCompleta("Se requiere un Nmero de Factura válido.", 16)
            Else
                ClsU.NotaCompleta("Se requiere un Nmero de Boleta de Compra válido.", 16)
            End If
            Me.TxtFactNum.Focus()
            Exit Sub
        End If

        oDFFactRegistro.DFFactID = Me.TxtDFFactID.Text
        oDFFactRegistro.CAI = Me.TxtCAI.EditValue
        oDFFactRegistro.Fecha = Me.TxtFecha.EditValue
        oDFFactRegistro.Descripcion = Me.TxtDescripcion.Text
        oDFFactRegistro.EmpresaCodigo = Me.TxtEmpresaCodigo.EditValue
        oDFFactRegistro.SdNCodigo = Me.TxtSdNCodigo.EditValue
        oDFFactRegistro.TotalBruto = Me.TxtTotalBruto.Text
        oDFFactRegistro.DesctoMonto = Me.TxtDesctoMonto.EditValue
        oDFFactRegistro.ImptoMonto = Me.TxtImptoMonto.EditValue
        oDFFactRegistro.TotalNeto = Me.TxtTotalNeto.EditValue
        oDFFactRegistro.TotalExento = Me.TxtTotalExento.EditValue
        oDFFactRegistro.TerminoCodigo = Me.TxtTerminoCodigo.EditValue
        oDFFactRegistro.Estado = 0 'Siempre

        oDFFactRegistro.RetencionID = Me.TxtRetencionID.EditValue
        oDFFactRegistro.DFID = Me.TxtDFID.EditValue

        oDFFactRegistro.Barco = Me.TxtBarco.Text
        oDFFactRegistro.Acuerdo = Me.TxtAcuerdo.Text
        Dim StrFechaEmbargue As String = Me.TxtFechaEmbarque.EditValue.ToString()
        StrFechaEmbargue = ClsAPR.ArmarFecha(3, StrFechaEmbargue)
        'StrFechaEmbargue = Microsoft.VisualBasic.Format(StrFechaEmbargue, "MM/dd/yyyy")
        'Dim dateFecha As DateTime = DateTime.ParseExact(StrFechaEmbargue, "yyyy-MM-dd", Nothing)
        oDFFactRegistro.FechaEmbarque = StrFechaEmbargue
        oDFFactRegistro.PuertoCarga = Me.TxtPuertoCarga.Text
        oDFFactRegistro.PuertoDescarga = Me.TxtPuertoDescarga.Text
        oDFFactRegistro.ConocimEmbarque = Me.TxtConocimientoEmbarque.Text
        oDFFactRegistro.CambioDolar = IIf(Me.TxtCambioDolar.EditValue <= 0, 1, Me.TxtCambioDolar.EditValue)
        oDFFactRegistro.FDA = Me.TxtFDA.Text
        oDFFactRegistro.NotificarA = Me.memoTxtNotificarA.Text
        oDFFactRegistro.TiposDoctoID = Me.TxtTiposDoctoID.EditValue

        oDFFactRegistro.MonedaCodigo = Me.TxtMonedaCodigo.EditValue
        oDFFactRegistro.NumeroOrden = Me.TxtNumeroOrden.EditValue
        oDFFactRegistro.InfoExtra = Me.memoTxtInfoExtra.Text

        oDFFactRegistro.NConstancia = Me.TxtNConstancia.Text
        oDFFactRegistro.NOCExenta = Me.TxtNOCExenta.Text
        oDFFactRegistro.NSAG = Me.TxtNSAG.Text

        If cAccion = "Edición de datos." Then

            Try
                oDFFactRegistro.FactNum = Me.TxtFactNum.Text

                oDFFactRegistro.UsuEditor = strUsuario
                oDFFactRegistro.FechaEdicion = Now()

                'Recuperar el DFFactID para seguir registrando productos bajo ese código
                oDFFactRegistroCopia = IDF_DFFacts.Buscar("DFFactID='" & oDFFactRegistro.DFFactID & "'")
                oDFFactRegistro.UsuCreador = oDFFactRegistroCopia.UsuCreador
                oDFFactRegistro.FechaCreacion = oDFFactRegistroCopia.FechaCreacion
                oDFFactRegistro.UsuAnulacion = oDFFactRegistroCopia.UsuAnulacion
                oDFFactRegistro.FechaAnulacion = oDFFactRegistroCopia.FechaAnulacion
                oDFFactRegistro.UsuImpresion = oDFFactRegistroCopia.UsuImpresion
                oDFFactRegistro.FechaImpresion = oDFFactRegistroCopia.FechaImpresion
                'oDFFactRegistro.FechaEmbarque = oDFFactRegistroCopia.FechaEmbarque

                Dim RESULTADO As String = oDFFactRegistro.Actualizar()
                Dim xResultado As Integer = InStr(RESULTADO, "ERROR", CompareMethod.Text)
                If xResultado > 0 Then
                    ClsU.NotaCompleta("No se pudo actualizar el nuevo registro [" & RESULTADO & "]", 16)
                    Return
                End If

                'If RESULTADO Like "ERROR%" Then
                '    'ClsU.Nota("No se pudo actualizar el nuevo registro [" & RESULTADO & "]")
                '    ClsU.NotaCompleta("No se pudo actualizar el nuevo registro [" & RESULTADO & "]", 16)
                '    Return
                'End If

                'ClsU.Nota("Registro actualizado satisfactoriamente!")
                ClsU.NotaCompleta("Registro actualizado satisfactoriamente!", 64)
            Catch ex As Exception
                'ClsU.Nota("Error en la actualización. " + ex.Message)
                ClsU.NotaCompleta("Error en la actualización. " + ex.Message, 16)
            End Try
        End If

        If cAccion = "Nuevo registro." Then
            Try

                'oDFFactRegistro.FactNum = Format(IDF_DFFacts.SigDFFact(IntTipoDocto, StrEmpresa), "00000000")
                oDFFactRegistro.FactNum = Format(IDF_DFFacts.SigDFFactCAI(IntTipoDocto, StrEmpresa, TxtCAI.Text), "00000000")

                oDFFactRegistro.UsuCreador = strUsuario
                oDFFactRegistro.FechaCreacion = Now()
                oDFFactRegistro.UsuEditor = strUsuario
                oDFFactRegistro.FechaEdicion = Now()
                oDFFactRegistro.UsuAnulacion = ""
                oDFFactRegistro.FechaAnulacion = Now() 'Bloqueado temporalmente - Ing. Manuel Ortega - 12/08/2015 - 02:42:00 pm
                oDFFactRegistro.UsuImpresion = ""
                oDFFactRegistro.FechaImpresion = Now()
                oDFFactRegistro.FechaEmbarque = Now()

                oDFFactRegistro.Crear()
                'Dim cResultado As String = oDFFactRegistro.Crear()
                'Dim xResultado As Integer = InStr(cResultado, "ERROR", CompareMethod.Text)
                'If xResultado > 0 Then
                '    ClsU.NotaCompleta("No se pudo crear el nuevo registro [" & cResultado & "]", 16)
                '    Return
                'End If

                Me.CmbNuevoItem.Enabled = True
                Me.CmbEliminarItem.Enabled = True
                Me.cmbModificarItem.Enabled = True
                Me.XTPEncTotales.PageVisible = False

                Try
                    'Variables para rastreo de la factura
                    cFactNum = oDFFactRegistro.FactNum
                    cEmpresaCodigo = oDFFactRegistro.EmpresaCodigo

                    'Recuperar el DFFactID para seguir registrando productos bajo ese código
                    oDFFactRegistro = IDF_DFFacts.Buscar("FactNum='" & cFactNum & "' and EmpresaCodigo='" & cEmpresaCodigo & "' and TiposDoctoID='" & IntTipoDocto & "' and CAI ='" & TxtCAI.Text & "'")
                    Me.TxtDFFactID.Text = oDFFactRegistro.DFFactID
                    Editar(oDFFactRegistro.DFFactID)

                Catch ex As Exception
                    ClsU.Nota(ex.Message)
                End Try

                Try
                    'Pendiente modificar Detalle del CAI - 20/03/2017 - 04:08 PM
                    'Ing. Manuel Ortega
                    Dim oConfigEmpRegistro As New IDF_DetConfigxEmp(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

                    oConfigEmpRegistro = IDF_DetConfigxEmp.Buscar("TiposDoctoID='" & oDFFactRegistro.TiposDoctoID & "' and CAI='" & oDFFactRegistro.CAI & "'")
                    oConfigEmpRegistro.NumActual = oDFFactRegistro.FactNum
                    oConfigEmpRegistro.Actualizar()

                Catch ex As Exception
                    'ClsU.Nota("No se pudo actualizar la numeración en la tabla del CAI [" & ex.Message & "]")
                    ClsU.NotaCompleta("No se pudo actualizar la numeración en la tabla del CAI [" & ex.Message & "]", 16)
                End Try

            Catch ex As Exception
                'ClsU.Nota("Error en la creación del registro. " + ex.Message)
                ClsU.NotaCompleta("Error en la creación del registro. " + ex.Message, 16)
            End Try
        End If

    End Sub

    Public Sub GrabarItem(cAccion As String)
        Dim oProdXFactRegistro As New IDF_ProdXFact(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        If Len(Me.TxtFactNum.Text) = 0 Then
            'ClsU.Nota("Se requiere un Número de Factura válido.")
            ClsU.NotaCompleta("Se requiere un Número de Factura válido.", 16)
            Me.TxtFactNum.Focus()
            Exit Sub
        End If

        oProdXFactRegistro.DFFactID = Me.TxtDFFactID.Text
        oProdXFactRegistro.ProdXFactID = Me.TxtRegProdXFactID.EditValue
        oProdXFactRegistro.ProdCodigo = Me.TxtRegProdCodigo.EditValue
        oProdXFactRegistro.ImptoCodigo = Me.TxtRegImptoCodigo.EditValue
        oProdXFactRegistro.Cantidad = Me.TxtRegCantidad.EditValue
        oProdXFactRegistro.Precio = Me.TxtRegPrecio.EditValue
        oProdXFactRegistro.TotalBruto = Me.TxtRegTotalBruto.EditValue
        oProdXFactRegistro.DesctoMonto = Me.TxtRegDesctoMonto.EditValue
        oProdXFactRegistro.TotalNeto = Me.TxtRegTotalNeto.EditValue
        oProdXFactRegistro.UnidMedCodigo = Me.TxtRegUnidMedCodigo.EditValue
        oProdXFactRegistro.Descrip1 = Me.TxtRegDescrip1.Text
        oProdXFactRegistro.Descrip2 = Me.TxtRegDescrip2.Text
        oProdXFactRegistro.ImptoMonto = Me.TxtRegImptoMonto.EditValue

        If cAccion = "Edición de datos." Then

            Try
                oProdXFactRegistro.Actualizar()
            Catch ex As Exception
                'ClsU.Nota("Error en la actualización.")
                ClsU.NotaCompleta("Error en la actualización. " & ex.Message, 16)
            End Try
        End If

        If cAccion = "Nuevo registro." Then
            Try
                oProdXFactRegistro.Crear()
            Catch ex As Exception
                'ClsU.Nota("Error en la creación del registro.")
                ClsU.NotaCompleta("Error en la creación del registro. " & ex.Message, 16)
            End Try
        End If

        CancelarItem()

    End Sub

    Public Sub Anular(nDFFactID As Integer, nEstado As Integer)
        Dim oDFFact As New IDF_DFFacts(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        oDFFact.DFFactID = nDFFactID

        Try
            oDFFact = IDF_DFFacts.Buscar("DFFactID='" & nDFFactID & "'")
            oDFFact.Estado = nEstado

            oDFFact.Actualizar()
        Catch ex As Exception
            'ClsU.Nota("Debe de elegir un registro para eliminar.")
            ClsU.NotaCompleta("Debe de elegir un registro para eliminar.", 16)
        End Try

        CargarItems()

    End Sub

    Public Sub Totalizar(nDFFactID As Integer)
        If nDFFactID = 0 Then
            Exit Sub
        End If

        Dim nTotalBruto, nDesctoMonto, nImptoMonto, nTotalNeto, nTotalExento As Double
        Dim oProdXDFFactReg As New IDF_ProdXFact(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        Dim oDFFactReg As New IDF_DFFacts(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        nTotalBruto = IDF_ProdXFact.TotalXFactID(nDFFactID, "TotalBruto")
        nDesctoMonto = IDF_ProdXFact.TotalXFactID(nDFFactID, "DesctoMonto")
        nImptoMonto = IDF_ProdXFact.TotalXFactID(nDFFactID, "ImptoMonto")
        nTotalNeto = IDF_ProdXFact.TotalXFactID(nDFFactID, "TotalNeto")
        nTotalExento = IDF_ProdXFact.TotalXFactID(nDFFactID, "TotalExento")

        Me.TxtTotalBruto.EditValue = nTotalBruto
        Me.TxtDesctoMonto.EditValue = nDesctoMonto
        Me.TxtImptoMonto.EditValue = nImptoMonto
        Me.TxtTotalNeto.EditValue = nTotalNeto
        Me.TxtTotalExento.EditValue = nTotalExento

        oDFFactReg = IDF_DFFacts.Buscar("DFFactID='" & Me.TxtDFFactID.EditValue & "'")

        oDFFactReg.TotalBruto = nTotalBruto
        oDFFactReg.DesctoMonto = nDesctoMonto
        oDFFactReg.ImptoMonto = nImptoMonto
        oDFFactReg.TotalNeto = nTotalNeto

        Try

            oDFFactReg.Actualizar()

        Catch ex As Exception

        End Try

        Me.XTPEncTotales.PageVisible = True

    End Sub

    Public Sub Imprimir(nDFFactID As Integer, AcumuladoID As String, x_print As PrintDialog)
        Dim cReporte, cServidor, cBDD, cBusqueda As String

        Dim oDFFactReg As New IDF_DFFacts(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        If nDFFactID = -1 Then
            VerificarAcumulado = "DFFactID IN " & AcumuladoID & ""
        ElseIf nDFFactID > -1 Then
            VerificarAcumulado = "DFFactID='" & nDFFactID & "'"
        End If
        oDFFactReg = IDF_DFFacts.Buscar(VerificarAcumulado)

        Dim oPerfilReg As New J_Perfil(ClsConexion.CadenaProduccion(strUsuario, strPassword))
        Dim oRepReg As New J_Reportes(ClsConexion.CadenaProduccion(strUsuario, strPassword))

        oPerfilReg = J_Perfil.Buscar("ID=1")

        cBusqueda = IIf(oDFFactReg.TiposDoctoID = 1, "246",
                        IIf(oDFFactReg.TiposDoctoID = 7, "245",
                            IIf(oDFFactReg.TiposDoctoID = 8, "253",
                                IIf(oDFFactReg.TiposDoctoID = 9, "322", ""))))

        oRepReg = J_Reportes.Buscar("idReporte='" & cBusqueda & "'")

        cReporte = "\\" & oPerfilReg.nombrePC & "\" & oPerfilReg.carpetaRaiz & "\" & oRepReg.reporte & ".rpt"
        cServidor = oRepReg.server
        cBDD = oRepReg.jDataBase

        Dim ocInforme As New ReportDocument

        Try
            If AcumuladoID.Equals("1") Then
                ocInforme.Load(cReporte, OpenReportMethod.OpenReportByDefault) '"\\amigots2\Reportes\IDF\FinDFFactsRpt.rpt"
                ocInforme.SetParameterValue("@DFFactID", nDFFactID)
                ocInforme.SetDatabaseLogon(strUsuario, strPassword, "amigodb\amigodb", "Finanzas")

                ocInforme.PrintOptions.PrinterName = x_print.PrinterSettings.PrinterName
                'ocInforme.PrintOptions.CustomPaperSource = PrintDialog1.Document.DefaultPageSettings.PaperSource
                ocInforme.PrintToPrinter(x_print.PrinterSettings.Copies, False, 0, 0)

                ocInforme.Close()
                ocInforme.Dispose()
            End If

            If AcumuladoID.Equals("-1") Then 'Vista previa para 1 factura
                'Dim VistaPrevia As New CrystalDecisions.Windows.Forms.CrystalReportViewer
                Dim v As GenVistaPrevia

                v = New GenVistaPrevia
                v.info = "Vista Previa..."
                v.reporte = "\\" & oPerfilReg.nombrePC & "\" & oPerfilReg.carpetaRaiz & "\" & oRepReg.reporte
                v.dataBase = "Finanzas"
                v.user = strUsuario 'usuario  'user
                v.pass = strPassword 'password 'pass
                v.server = "amigodb\amigodb"
                v.usuarioSesion = strUsuario
                v.passwordSesion = strPassword
                v.parametro = nDFFactID
                'If Convert.ToBoolean(dgvReportes.GetRowCellValue(dgvReportes.FocusedRowHandle, colSolicitar)) Then
                '    v.parametro = si
                'End If

                v.Show()
            End If

        Catch ex As Exception
            'ClsU.Nota("No se puede imprimir [" & ex.Message & "]")
            ClsU.NotaCompleta("No se puede imprimir [" & ex.Message & "]", 16)
        End Try


        Try
            oDFFactReg.EstaImpreso = True
            oDFFactReg.Actualizar()

        Catch ex As Exception
            'ClsU.Nota("No se puede actualizar marcador de impresión [" & ex.Message & "]")
            ClsU.NotaCompleta("No se puede actualizar marcador de impresión [" & ex.Message & "]", 16)
        End Try
    End Sub

#End Region

    Private Sub XTTEmpaginacion_Click(sender As Object, e As EventArgs) Handles XTTEmpaginacion.Click

    End Sub
    Private Sub XTTPagina2_Paint(sender As Object, e As PaintEventArgs) Handles XTTPagina2.Paint

    End Sub

    Private Sub TxtBoletaPeso_EditValueChanged(sender As Object, e As EventArgs) Handles TxtBoletaPeso.EditValueChanged
        'Calcular cantidad de barriles

    End Sub
    Sub MarcarDesmarcarTodos(bandera As Integer)
        flagCargar = GrdConsultaView.RowCount
        Dim mca As Boolean
        For fila As Integer = 0 To flagCargar - 1
            If bandera = 1 Then 'Marcar todos
                mca = True
            End If
            If bandera = 2 Then 'Desmarcar todos
                mca = False
            End If
            GrdConsultaView.SetRowCellValue(fila, colSelector, mca)
        Next
    End Sub

    Private Sub CmbOpcImpresion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbOpcImpresion.SelectedIndexChanged
        If CmbOpcImpresion.SelectedIndex = 0 Then
            lblFrecuenciaImpresion.Enabled = False
            lblFrecuenciaImpresion.Visible = False
            txtFrecuenciaImpresion.Enabled = False
            txtFrecuenciaImpresion.Visible = False
            CmbSelectorTodos.Enabled = False
            CmbQuitarSelector.Enabled = False
            CmbQuitarSelector_Click(sender, e)
            colSelector.Visible = False
        Else
            lblFrecuenciaImpresion.Enabled = True
            lblFrecuenciaImpresion.Visible = True
            txtFrecuenciaImpresion.Enabled = True
            txtFrecuenciaImpresion.Visible = True
            CmbSelectorTodos.Enabled = True
            CmbQuitarSelector.Enabled = True
            colSelector.Visible = True
        End If
    End Sub

    Private Sub CmbSelectorTodos_Click(sender As Object, e As EventArgs) Handles CmbSelectorTodos.Click
        MarcarDesmarcarTodos(1)
    End Sub

    Private Sub CmbQuitarSelector_Click(sender As Object, e As EventArgs) Handles CmbQuitarSelector.Click
        MarcarDesmarcarTodos(2)
    End Sub

    Private Sub txtCantidadCopias_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFrecuenciaImpresion.KeyPress
        'If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
        '    e.Handled = True
        'End If
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub txtFrecuenciaImpresion_TextChanged(sender As Object, e As EventArgs) Handles txtFrecuenciaImpresion.TextChanged
        If CInt(txtFrecuenciaImpresion.Text) <= 0 And CInt(txtFrecuenciaImpresion.Text) > 9 Then
            ClsU.NotaCompleta("Para la frecuencia de impresion, solo se permiten ingresar de 1 a 9 segundos. Favor intente de nuevo...", 16)
        End If
    End Sub

    Private Sub TxtNumeroOrden_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtNumeroOrden.KeyDown

        'Al presionar la tecla enter verifica si la empresa usa la bascula para procesar la factura por medio de una orden
        If e.KeyCode = Keys.Enter And LblAccion.Text = "Nuevo registro." Then
            validarNumeroOrdenBasculaBoleta(sender, e)
        End If
    End Sub

    Public Sub validarNumeroOrdenBasculaBoleta(xsender As Object, e As KeyEventArgs)
        dtIDF_EmpresaAnexo = ClsAccesos.obtenerInformacionAnexoPorEmpresa(strUsuario, strPassword, 1, CInt(StrEmpresa))
        contador = 0
        contador = dtIDF_EmpresaAnexo.Rows.Count
        If contador > 0 Then

            'Validar si el numero de orden, ya esta asignado a un numero de factura
            Dim verificarNumeroOrden As Boolean = ClsAccesos.verificarNumeroOrdenAsignadoAFactura(strUsuario,
                                                             strPassword, 1, CInt(StrEmpresa), TxtNumeroOrden.Text)

            aplicaBascula = Convert.ToBoolean(dtIDF_EmpresaAnexo.Rows(0)(9))
            If aplicaBascula And (verificarNumeroOrden = False) Then
                'Obtener peso de la melaza en barriles (Total neto en libras / 640)
                dtBasculaBoletaBoletaPeso = ClsAccesos.obtenerCantidadBarrilesDesdeBascula(strUsuario,
                                            strPassword, 1, TxtNumeroOrden.Text)
                If dtBasculaBoletaBoletaPeso.Rows.Count > 0 Then
                    LblConexionBascula.Text = "Conexion a Sistema de Bascula: en linea..."
                    LblConexionBascula.ForeColor = Color.Green

                    Dim Neto As Double = Convert.ToDouble(dtBasculaBoletaBoletaPeso.Rows(0)(0).ToString())
                    TxtRegCantidad.EditValue = Neto

                    'Asignar codigo de producto de Bascula
                    Dim xProductoID As Integer = Convert.ToInt32(dtBasculaBoletaBoletaPeso.Rows(0)(1).ToString)
                    Dim xProdCodigo As String = dtBasculaBoletaBoletaPeso.Rows(0)(2).ToString()
                    TxtRegProdCodigo.EditValue = xProdCodigo

                    'Habilitar linea del detalle para ingreso del producto
                    CmbNuevoItem_Click(xsender, e)
                End If
            Else
                'LblConexionBascula.Text = "Conexion a Sistema de Bascula: bloqueado"
                'LblConexionBascula.ForeColor = Color.Red
                ClsU.NotaCompleta("Advertencia: Numero de orden " & TxtNumeroOrden.Text & " ya esta facturada. Favor intente de nuevo", 48)
            End If
        End If
    End Sub

    'Función para validar el estado de una factura
    Private Function FacturaEstado() As Boolean
        If GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, GridColumn45) = "ANULADO" Then 'Validación, sí la factura está anulada no se puede modificar.
            Return True
        Else
            Return False
        End If
    End Function

End Class