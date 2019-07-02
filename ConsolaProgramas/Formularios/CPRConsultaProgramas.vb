Imports LibDAO001
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Public Class CPRConsultaProgramas
    Public apr As ClsAPR = New ClsAPR()
    Public EntiAPR As ClsEntiAPR.ClsAprGenerarOdtQuema = New ClsEntiAPR.ClsAprGenerarOdtQuema()
    Public strUsuario, strPassword, strSitio, strFinca, strArea, strLoteID, strFecha, strHora, strMensaje, strIdxMensaje, FechaHoy As String
    Public idxPeriodo, flagTipoCaña, flagAccidental, flagDoble, intPeriodoId, FrenteID, flagCargar As Integer
    Public ProgramaID, TipoProgramaID, EstadoProgramaID, TipoPeriodoID, empresaid, flagAutomatico As Integer
    Public ZafraID, DistritoID, mensaje, reutilizacion, fechaActual, fechaProyeccion, strPrograma As String
    Public flagGuardarModificar As Boolean
    Public dsTemp As DataSet = Nothing
    Public dtTemp As DataTable = Nothing

    'Variables Parametros de Busqueda Estimado de Produccion
    Public prmFrente, prmFecha, prmDistrito, prmZona, prmFinca, prmEdad1, prmEdad2, prmRendi1, prmRendi2, prmVariedad, prmCiclo1, prmCiclo2, prmTextura, prmDrenaje As String
    Public prmDistancia1, prmDistancia2, prmFecE1, prmFecE2 As String
    Public flagDistrito, flagDrenaje, flagZona, flagFinca, flagCiclo, flagDistancia, flagFechaEstimada, flagEdad, flagRendimiento, flagVariedad, flagTextura As Integer
    Public contadorT, contadorV, flagLimpiarPantalla As Integer

    Public Sub FuncionInicial(strU As String, strP As String, empresa As Integer, programaIde As Integer, prg As String)
        strUsuario = strU
        strPassword = strP
        empresaid = empresa
        ProgramaID = programaIde
        strPrograma = prg
    End Sub
    Private Sub cmbSalir_Click(sender As Object, e As EventArgs) Handles cmbSalir.Click
        Close()
    End Sub

    Private Sub txtFecha_Properties_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtFecha.Properties.Validating, txtFechaEHasta.Properties.Validating, txtFechaEDesde.Properties.Validating

    End Sub

    Private Sub CPRConsultaProgramas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If flagLimpiarPantalla = 1 Then
            flagLimpiarPantalla = 1
        Else
            flagLimpiarPantalla = 2
        End If
        flagAutomatico = 0
        contadorT = 1
        fechaActual = Format(Date.Now, "dd/MM/yyyy")
        lblRefFechaCalculoEdadCaña.Text = "Referencia: se usa la fecha actual " & fechaActual & " para calcular la Edad de la Caña..."
        CargarFrentes()
        CargarDistrito()
        CargarZonas()
        CargarVariedades()
        CargarCiclos1()
        CargarCiclos2()
        CargarTexturas()
        CargarDrenajes()
        CargarEstimadoProduccion(contadorT)
        CargarTotalesxEmpresa()
    End Sub

    Sub CargarFrentes()
        dsTemp = New DataSet()
        dsTemp = apr.ObtenerFrentes(strUsuario, strPassword, 3, 0, empresaid)
        cbxFrente.Properties.DataSource = dsTemp.Tables(0)
        cbxFrente.Properties.ValueMember = dsTemp.Tables(0).Columns(0).ToString()
        cbxFrente.Properties.DisplayMember = dsTemp.Tables(0).Columns(1).ToString()
    End Sub

    Sub CargarDistrito()
        dsTemp = New DataSet()
        dsTemp = apr.ObtenerDistritos(strUsuario, strPassword, 1, empresaid)
        cbxDistrito.Properties.DataSource = dsTemp.Tables(0)
        cbxDistrito.Properties.ValueMember = dsTemp.Tables(0).Columns(0).ToString()
        cbxDistrito.Properties.DisplayMember = dsTemp.Tables(0).Columns(1).ToString()
    End Sub

    Sub CargarZonas()
        dsTemp = New DataSet()
        dsTemp = apr.ObtenerZonas(strUsuario, strPassword, 1, empresaid)
        cbxZona.Properties.DataSource = dsTemp.Tables(0)
        cbxZona.Properties.ValueMember = dsTemp.Tables(0).Columns(0).ToString()
        cbxZona.Properties.DisplayMember = dsTemp.Tables(0).Columns(1).ToString()
    End Sub

    Sub CargarVariedades()
        dsTemp = New DataSet()
        dsTemp = apr.ObtenerVariedadesCaña(strUsuario, strPassword, 1)
        listaVariedades.DataSource = dsTemp.Tables(0)
        listaVariedades.DisplayMember = "Variedad"
        listaVariedades.ValueMember = "TipoCanaID"
    End Sub

    Sub CargarCiclos1()
        Try
            dsTemp = New DataSet()
            dsTemp = apr.ObtenerCiclos(strUsuario, strPassword, 1)
            cbxCicloDesde.DataSource = dsTemp.Tables(0)
            cbxCicloDesde.DisplayMember = "Descripcion"
            cbxCicloDesde.ValueMember = "CicloID"
            cbxCicloDesde.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message & "Error en la lista CicloDesde", MsgBoxStyle.Critical, "Error:")
        End Try
    End Sub

    Sub CargarCiclos2()
        Try
            dsTemp = New DataSet()
            dsTemp = apr.ObtenerCiclos(strUsuario, strPassword, 1)
            cbxCicloHasta.DataSource = dsTemp.Tables(0)
            cbxCicloHasta.DisplayMember = "Descripcion"
            cbxCicloHasta.ValueMember = "CicloID"
            cbxCicloHasta.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message & "Error en la lista CicloHasta", MsgBoxStyle.Critical, "Error:")
        End Try
    End Sub

    Sub CargarTexturas()
        dsTemp = New DataSet()
        dsTemp = apr.ObtenerTexturas(strUsuario, strPassword, 1)
        listaTextura.DataSource = dsTemp.Tables(0)
        listaTextura.DisplayMember = "Descripcion"
        listaTextura.ValueMember = "TipoSueloID"
    End Sub

    Sub CargarDrenajes()
        dsTemp = New DataSet()
        dsTemp = apr.ObtenerDrenajes(strUsuario, strPassword, 1)
        cbxDrenaje.Properties.DataSource = dsTemp.Tables(0)
        cbxDrenaje.Properties.ValueMember = dsTemp.Tables(0).Columns(0).ToString()
        cbxDrenaje.Properties.DisplayMember = dsTemp.Tables(0).Columns(1).ToString()
    End Sub

    Sub CargarEstimadoProduccion(intClaseFecha As Int16)
        dsTemp = New DataSet()
        Dim Enti As ClsEntiAPR.CPR_EstimadoProduccion = New ClsEntiAPR.CPR_EstimadoProduccion()
        If intClaseFecha = 1 Then
            reutilizacion = fechaActual
        End If
        If intClaseFecha = 2 Then
            reutilizacion = fechaProyeccion
        End If
        Enti.FechaCorte = apr.ArmarFecha(1, reutilizacion)
        dsTemp = apr.ObtenerEstimadoProduccion(strUsuario, strPassword, 1, Enti, empresaid, ProgramaID)
        gcDatos.DataSource = dsTemp.Tables(0)
    End Sub

    Private Sub cbxDistrito_EditValueChanged(sender As Object, e As EventArgs) Handles cbxDistrito.EditValueChanged
        Try
        DistritoID = cbxDistrito.EditValue.ToString()
        prmDistrito = DistritoID
            CargarFincas()
        Catch ex As Exception

        End Try
    End Sub

    Sub CargarFincas()
        dsTemp = New DataSet()
        dsTemp = apr.ObtenerFinca(strUsuario, strPassword, 2, DistritoID)
        cbxFinca.Properties.DataSource = dsTemp.Tables(0)
        cbxFinca.Properties.ValueMember = dsTemp.Tables(0).Columns(0).ToString()
        cbxFinca.Properties.DisplayMember = dsTemp.Tables(0).Columns(1).ToString()
    End Sub

    Sub CargarTotalesxEmpresa()
        dtTemp = New DataTable()
        dtTemp = apr.ObtenerTotalesxEmpresa(strUsuario, strPassword, 1, empresaid, ProgramaID)
        Dim ttons As Decimal = Convert.ToDecimal(dtTemp.Rows(0)(0))
        reutilizacion = Format(ttons, "###,###,##0.00")
        lblToneladas.Text = reutilizacion
        Dim treg As Decimal = Convert.ToDecimal(dtTemp.Rows(0)(1))
        reutilizacion = Format(treg, "##,##0")
        lblRegistros.Text = reutilizacion
        Dim tRegProcesados As Integer = Convert.ToInt32(dtTemp.Rows(0)(2))
        reutilizacion = Format(tRegProcesados, "##,##0")
        Text = "Formulario de Lotes a Programar - [" & reutilizacion & "] Items procesados para el Programa ID: " & ProgramaID & " - " & strPrograma
        Dim tTonsProcesadas As Decimal = Convert.ToDecimal(dtTemp.Rows(0)(3))
        reutilizacion = Format(tTonsProcesadas, "###,###,##0.00")
        lblTotalTonsxPrg.Text = reutilizacion

        'Recarlcular totales segun lotes seleccionados del GridControl DevExpress
        Dim contador As Integer = dgvDatos.RowCount
        Dim countLoteID As Integer = 0
        Dim sumTonsEstimadas As Decimal = 0
        For fila As Integer = 0 To contador - 1
            Dim marca As Boolean = dgvDatos.GetRowCellValue(fila, colSeleccion)
            If marca = True Then
                countLoteID = countLoteID + 1
                sumTonsEstimadas = sumTonsEstimadas + Convert.ToDecimal(dgvDatos.GetRowCellValue(fila, colToneladasEstimadas).ToString)
            End If
        Next

        reutilizacion = Format(countLoteID, "##,##0")
        lblTotalLotesAProcesar.Text = reutilizacion
        reutilizacion = Format(sumTonsEstimadas, "###,###,##0.00")
        lblTotalTonsAProcesar.Text = reutilizacion
    End Sub

    Private Sub cmbConsultar_Click(sender As Object, e As EventArgs) Handles cmbConsultar.Click
        Try
            mensaje = ValidarCampos()
            If mensaje.Equals("1") Then
                If flagLimpiarPantalla = 1 Then
                    CPRConsultaProgramas_Load(sender, e)
                End If
                If flagLimpiarPantalla = 2 Then
                    ProcesarConsultaSegunFiltros()
                End If
            Else
                MsgBox(mensaje, MsgBoxStyle.Critical, "Error:")
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " Error al validar los parametros de busqueda. Intente de nuevo.", MsgBoxStyle.Critical, "Error:")
        End Try
    End Sub

    Sub ProcesarConsultaSegunFiltros()
        Dim entidad As ClsEntiAPR.CPR_EstimadoProduccion = New ClsEntiAPR.CPR_EstimadoProduccion()
        dsTemp = New DataSet()
        prmFecha = txtFecha.Text
        prmEdad1 = txtEdadDesde.Text
        prmEdad2 = txtEdadHasta.Text
        prmRendi1 = txtRendimientoDesde.Text
        prmRendi2 = txtRendimientoHasta.Text
        prmDistancia1 = txtDistanciaDesde.Text
        prmDistancia2 = txtDistanciaHasta.Text
        prmFecE1 = txtFechaEDesde.Text
        prmFecE2 = txtFechaEHasta.Text
        reutilizacion = ""
        If contadorT = 1 Then
            reutilizacion = apr.ArmarFecha(1, fechaActual)
        End If
        If contadorT = 2 Then
            reutilizacion = apr.ArmarFecha(1, fechaProyeccion)
        End If
        entidad.FechaCorte = reutilizacion

        'Recorrer/Obtener lista seleccionada de Variedades
        prmVariedad = ""
        contadorV = 0
        Dim checkedRow As Data.DataRowView
        For i As Integer = 0 To Me.listaVariedades.CheckedIndices.Count - 1
            checkedRow = CType(Me.listaVariedades.CheckedItems.Item(i), Data.DataRowView)
            prmVariedad = prmVariedad & checkedRow.Item("TipoCanaID").ToString() & ","
        Next
        If listaVariedades.CheckedIndices.Count > 0 Then
            Dim ArregloV() As String = Split(prmVariedad, ",")
            prmVariedad = ""
            Dim cArregloV As Integer = ArregloV.Length - 1
            For fila = 0 To cArregloV
                If String.IsNullOrEmpty(ArregloV(fila)) = False Then
                    contadorV = contadorV + 1
                    If contadorV < (cArregloV) Then
                        ArregloV(fila) = ArregloV(fila) & ","
                    End If
                End If
            Next
            For fila = 0 To cArregloV
                If String.IsNullOrEmpty(ArregloV(fila)) = False Then
                    prmVariedad = prmVariedad + ArregloV(fila)
                End If
            Next
        Else
            prmVariedad = "-1"
        End If

        'Recorrer/Obtener lista seleccionada de Textura
        prmTextura = ""
        Dim xcontadorT As Integer = 0
        Dim checkedRow1 As Data.DataRowView
        For i As Integer = 0 To Me.listaTextura.CheckedIndices.Count - 1
            checkedRow1 = CType(Me.listaTextura.CheckedItems.Item(i), Data.DataRowView)
            prmTextura = prmTextura & checkedRow1.Item("TipoSueloID").ToString() & ","
        Next
        If listaTextura.CheckedIndices.Count > 0 Then
            'contadorT = 0
            Dim ArregloT() As String = Split(prmTextura, ",")
            prmTextura = ""
            Dim cArregloT As Integer = ArregloT.Length - 1
            For fila = 0 To cArregloT
                If String.IsNullOrEmpty(ArregloT(fila)) = False Then
                    xcontadorT = xcontadorT + 1
                    If xcontadorT < (cArregloT) Then
                        ArregloT(fila) = ArregloT(fila) & ","
                    End If
                End If
            Next
            For fila = 0 To cArregloT
                If String.IsNullOrEmpty(ArregloT(fila)) = False Then
                    prmTextura = prmTextura + ArregloT(fila)
                End If
            Next
        Else
            prmTextura = "-1"
        End If

        'Guardar datos en variebles tipo entidad
        entidad.FrenteID = Convert.ToInt32(prmFrente)
        entidad.FechaProyeccion = prmFecha
        If flagDistrito = 1 Then
            entidad.DistritoID = prmDistrito
        End If
        If flagZona = 1 Then
            entidad.ZonaID = Convert.ToInt32(prmZona)
        End If
        If flagFinca = 1 Then
            entidad.FincaID = prmFinca
        End If
        If flagEdad = 1 Then
            entidad.Edad1 = Convert.ToDecimal(prmEdad1)
            entidad.Edad2 = Convert.ToDecimal(prmEdad2)
        End If
        If flagRendimiento = 1 Then
            entidad.Rendi1 = Convert.ToDecimal(prmRendi1)
            entidad.Rendi2 = Convert.ToDecimal(prmRendi2)
        End If
        'Variedad
        If flagVariedad = 1 Then
            entidad.Variedad = prmVariedad
        End If
        If flagCiclo = 1 Then
            entidad.Ciclo1 = prmCiclo1
            entidad.Ciclo2 = prmCiclo2
        End If
        If flagTextura = 1 Then
            entidad.Textura = prmTextura
        End If
        If flagDrenaje = 1 Then
            entidad.DrenajeID = Convert.ToInt32(prmDrenaje)
        End If
        If flagDistancia = 1 Then
            entidad.Distancia1 = Convert.ToDecimal(prmDistancia1)
            entidad.Distancia2 = Convert.ToDecimal(prmDistancia2)
        End If
        If flagFechaEstimada = 1 Then
            entidad.FecE1 = prmFecE1
            entidad.FecE2 = prmFecE2
        End If

        'Obtener banderas de cada checkBox
        entidad.FDistrito = flagDistrito
        entidad.FDrenaje = flagDrenaje
        entidad.Fzona = flagZona
        entidad.FFinca = flagFinca
        entidad.FCiclo = flagCiclo
        entidad.FDistancia = flagDistancia
        entidad.FRendi = flagRendimiento
        entidad.FEdad = flagEdad
        entidad.FFecE = flagFechaEstimada
        entidad.FVariedad = flagVariedad
        entidad.FTextura = flagTextura

        'Enviar parametros a SQL
        dsTemp = apr.ObtenerEstimadoProduccion(strUsuario, strPassword, 2, entidad, empresaid, ProgramaID)
        gcDatos.DataSource = dsTemp.Tables(0)
    End Sub

    Function ValidarCampos() As String
        mensaje = "1"
        Return mensaje
    End Function

    Private Sub chkDistrito_CheckedChanged(sender As Object, e As EventArgs) Handles chkDistrito.CheckedChanged
        If chkDistrito.Checked Then
            flagDistrito = 1
        Else
            flagDistrito = 0
        End If
    End Sub

    Private Sub chkZona_CheckedChanged(sender As Object, e As EventArgs) Handles chkZona.CheckedChanged
        If chkZona.Checked Then
            flagZona = 1
        Else
            flagZona = 0
        End If
    End Sub

    Private Sub chkFinca_CheckedChanged(sender As Object, e As EventArgs) Handles chkFinca.CheckedChanged
        If chkFinca.Checked Then
            flagFinca = 1
        Else
            flagFinca = 0
        End If
    End Sub

    Private Sub chkEdadCaña_CheckedChanged(sender As Object, e As EventArgs) Handles chkEdadCaña.CheckedChanged
        If chkEdadCaña.Checked Then
            flagEdad = 1
        Else
            flagEdad = 0
        End If
    End Sub

    Private Sub chkRendimiento_CheckedChanged(sender As Object, e As EventArgs) Handles chkRendimiento.CheckedChanged
        If chkRendimiento.Checked Then
            flagRendimiento = 1
        Else
            flagRendimiento = 0
        End If
    End Sub

    Private Sub chkVariedades_CheckedChanged(sender As Object, e As EventArgs) Handles chkVariedades.CheckedChanged
        If chkVariedades.Checked Then
            flagVariedad = 1
        Else
            flagVariedad = 0
        End If
    End Sub

    Private Sub chkCiclo_CheckedChanged(sender As Object, e As EventArgs) Handles chkCiclo.CheckedChanged
        If chkCiclo.Checked Then
            flagCiclo = 1
        Else
            flagCiclo = 0
        End If
    End Sub

    Private Sub chkTextura_CheckedChanged(sender As Object, e As EventArgs) Handles chkTextura.CheckedChanged
        If chkTextura.Checked Then
            flagTextura = 1
        Else
            flagTextura = 0
        End If
    End Sub

    Private Sub chkDrenaje_CheckedChanged(sender As Object, e As EventArgs) Handles chkDrenaje.CheckedChanged
        If chkDrenaje.Checked Then
            flagDrenaje = 1
        Else
            flagDrenaje = 0
        End If
    End Sub

    Private Sub chkDistancia_CheckedChanged(sender As Object, e As EventArgs) Handles chkDistancia.CheckedChanged
        If chkDistancia.Checked Then
            flagDistancia = 1
        Else
            flagDistancia = 0
        End If
    End Sub

    Private Sub chkFechaEstimada_CheckedChanged(sender As Object, e As EventArgs) Handles chkFechaEstimada.CheckedChanged
        If chkFechaEstimada.Checked Then
            flagFechaEstimada = 1
        Else
            flagFechaEstimada = 0
        End If
    End Sub

    Private Sub cbxZona_EditValueChanged(sender As Object, e As EventArgs) Handles cbxZona.EditValueChanged
        Try
            prmZona = cbxZona.EditValue.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbxFinca_EditValueChanged(sender As Object, e As EventArgs) Handles cbxFinca.EditValueChanged
        Try
            prmFinca = cbxFinca.EditValue.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbxCicloDesde_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCicloDesde.SelectedIndexChanged
        prmCiclo1 = cbxCicloDesde.SelectedValue.ToString()
    End Sub

    Private Sub cbxCicloHasta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCicloHasta.SelectedIndexChanged
        prmCiclo2 = cbxCicloHasta.SelectedValue.ToString()
    End Sub

    Private Sub cbxDrenaje_EditValueChanged(sender As Object, e As EventArgs) Handles cbxDrenaje.EditValueChanged
        prmDrenaje = cbxDrenaje.EditValue.ToString()
    End Sub

    Private Sub cbxFrente_EditValueChanged(sender As Object, e As EventArgs) Handles cbxFrente.EditValueChanged
        prmFrente = cbxFrente.EditValue.ToString()
        dsTemp = New DataSet()
        Try
        dsTemp = apr.ObtenerFrentes(strUsuario, strPassword, 2, CInt(prmFrente), empresaid)
        Dim TotalMinutaxFrente As Decimal = Convert.ToDecimal(dsTemp.Tables(0).Rows(0)(5))
            lblTotalMinutaFrente.Text = TotalMinutaxFrente.ToString() & " Toneladas "
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtFecha_EditValueChanged(sender As Object, e As EventArgs) Handles txtFecha.EditValueChanged
        'Registrar fecha de proyeccion en Tabla CPR_Predeterminados, para obtener la edad de la caña para cada lote
        reutilizacion = txtFecha.Text
        If String.IsNullOrEmpty(reutilizacion) = False Then
            contadorT = 2
            fechaProyeccion = apr.ArmarFecha(1, reutilizacion)
            lblRefFechaCalculoEdadCaña.Text = "Referencia: se usa la fecha " & reutilizacion & " para calcular la Edad de la Caña..."
            CargarEstimadoProduccion(contadorT)
            'Actualizar tabla 
            'reutilizacion = apr.ActualizarPredeterminados(strUsuario, strPassword, 1, reutilizacion)
            'Cargar datos Estimados de Produccion
        End If
    End Sub

    Private Sub cmbSeleccionar_Click(sender As Object, e As EventArgs) Handles cmbSeleccionar.Click
        Try
        'Validar si el usuario selecciono Frente
        If String.IsNullOrEmpty(cbxFrente.Text) = False Then
            If String.IsNullOrWhiteSpace(cbxFrente.Text) = False Then
                Dim dtProduccion As New DataTable()
                dtProduccion.Columns.Add("ProgramaID")
                dtProduccion.Columns.Add("EstimadoProduccionID")
                dtProduccion.Columns.Add("FrenteID")
                dtProduccion.Columns.Add("FechaEstimada")
                dtProduccion.Columns.Add("ToneladasEstimadas")
                dtProduccion.Columns.Add("Usuario")
                dtProduccion.Columns.Add("EstimadoGrupoID")

                'Verificar si hay datos en el GridControl
                reutilizacion = ""
                Dim contador As Integer = dgvDatos.RowCount
                If contador > 0 Then
                    For fila As Integer = 0 To contador - 1
                        Dim marca As Boolean = dgvDatos.GetRowCellValue(fila, colSeleccion)
                        If marca = True Then
                            'MsgBox(dgvDatos.GetRowCellValue(fila, colLoteID).ToString, MsgBoxStyle.Critical, "Error:")
                            Dim xfila As DataRow = dtProduccion.NewRow()
                            xfila("ProgramaID") = ProgramaID
                            Dim rwEPID As Int32 = Convert.ToInt32(dgvDatos.GetRowCellValue(fila, colEstimadoProduccionID).ToString)
                            xfila("EstimadoProduccionID") = rwEPID
                            xfila("FrenteID") = Convert.ToInt32(prmFrente)
                            reutilizacion = dgvDatos.GetRowCellValue(fila, colFechaEstimada).ToString
                            reutilizacion = apr.ArmarFecha(1, reutilizacion)
                            xfila("FechaEstimada") = reutilizacion
                                'Dim rwTE As Decimal = Convert.ToDecimal(dgvDatos.GetRowCellValue(fila, colToneladasEstimadas).ToString)
                                Dim rwTE As Double = Convert.ToDouble(dgvDatos.GetRowCellValue(fila, colToneladasEstimadas).ToString)
                            xfila("ToneladasEstimadas") = rwTE
                            xfila("Usuario") = strUsuario
                                Dim rwEGID As Int32 = Convert.ToInt32(dgvDatos.GetRowCellValue(fila, colEstimadoGrupoID).ToString)
                            xfila("EstimadoGrupoID") = rwEGID
                            dtProduccion.Rows.Add(xfila)
                        End If
                    Next
                    If dtProduccion.Rows.Count > 0 Then
                        'Enviar dataTable a Procedimiento Almacenado spCPR_DetPrograma
                        reutilizacion = apr.InsertarDetProgramas(strUsuario, strPassword, 1, dtProduccion)
                        strIdxMensaje = reutilizacion.Substring(0, 1)
                        reutilizacion = reutilizacion.Replace(strIdxMensaje, "")
                        If strIdxMensaje.Equals("*") Then
                            flagAutomatico = 1 'Bandera que sirve para identificar, cuando el usuario desee salir de esta ventana y cargar de forma
                            'Automatica los lotes adiocionados al ProgramaID actual de la venta "Programacion de Cosecha"
                            MsgBox(reutilizacion, MsgBoxStyle.Information, "Mensaje:")
                            'Actualizar Estimado de Produccion: Excluir lotes enviados a Detalle de Programa
                            'If contadorT = 0 Then
                            '    contadorT = 2
                            'End If
                            CargarEstimadoProduccion(contadorT)
                            CargarTotalesxEmpresa()
                        Else
                            MsgBox(reutilizacion, MsgBoxStyle.Critical, "Error:")
                        End If
                    Else
                        MsgBox("Para que las filas marcadas se procesen correctamente, debera de seleccionar cualquier fila. Intente de nuevo. Para mayor informacion, comunicarse con el Departamento de IT", MsgBoxStyle.Exclamation, "Advertencia:")
                    End If
                Else
                    MsgBox("Error: Favor seleccionar datos...", MsgBoxStyle.Critical, "Error:")
                End If
            Else
                MsgBox("El dato de Frente es incorrecto, es nulo, favor verificar e intentar de nuevo", MsgBoxStyle.Critical, "Error:")
                cbxFrente.Focus()
            End If
        Else
            MsgBox("El dato de Frente es incorrecto, es nulo, favor verificar e intentar de nuevo", MsgBoxStyle.Critical, "Error:")
            cbxFrente.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error al procesar el envio de Lotes. Verifique si la informacion del Estimado de Produccion sean datos correctos. Si el error persiste, comuniquese con el Administrador del Sistema." & ex.Message, MsgBoxStyle.Critical, "Error:")
        End Try

    End Sub

    Private Sub cmbRestablecer_Click(sender As Object, e As EventArgs) Handles cmbRestablecer.Click
        LimpiarPantalla()
    End Sub

    Sub LimpiarPantalla()
        flagLimpiarPantalla = 1
        Dim chk As Boolean
        chk = False
        cbxFrente.Text = ""
        txtFecha.Text = ""
        cbxDistrito.Text = ""
        cbxZona.Text = ""
        cbxFinca.Text = ""
        txtEdadDesde.Text = "0.00"
        txtEdadHasta.Text = "0.00"
        txtRendimientoDesde.Text = "0.00"
        txtRendimientoHasta.Text = "0.00"
        cbxDrenaje.Text = ""
        txtDistanciaDesde.Text = "0.00"
        txtDistanciaHasta.Text = "0.00"
        txtFechaEDesde.Text = ""
        txtFechaEHasta.Text = ""
        lblTotalMinutaFrente.Text = "0"

        chkCiclo.Checked = chk
        chkDistancia.Checked = chk
        chkDistrito.Checked = chk
        chkDrenaje.Checked = chk
        chkEdadCaña.Checked = chk
        chkFechaEstimada.Checked = chk
        chkVariedades.Checked = chk
        chkTextura.Checked = chk
        chkRendimiento.Checked = chk
        chkZona.Checked = chk
        chkFinca.Checked = chk
    End Sub

    Private Sub cmbMarcarTodos_Click(sender As Object, e As EventArgs) Handles cmbMarcarTodos.Click
        MarcarDesmarcarTodos(1)
    End Sub

    Private Sub cmbQuitarTodos_Click(sender As Object, e As EventArgs) Handles cmbQuitarTodos.Click
        MarcarDesmarcarTodos(2)
    End Sub

    Sub MarcarDesmarcarTodos(bandera As Integer)
        flagCargar = dgvDatos.RowCount
        Dim mca As Boolean
        For fila As Integer = 0 To flagCargar - 1
            If bandera = 1 Then 'Marcar todos
                mca = True
            End If
            If bandera = 2 Then 'Desmarcar todos
                mca = False
            End If
            dgvDatos.SetRowCellValue(fila, colSeleccion, mca)
        Next
        CargarTotalesxEmpresa()
    End Sub

    Private Sub cmbRecalcular_Click(sender As Object, e As EventArgs) Handles cmbRecalcular.Click
        CargarTotalesxEmpresa()
    End Sub

    Private Sub dgvDatos_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles dgvDatos.RowCellStyle
        Dim View As GridView = sender
        If e.Column.FieldName = "LoteID" Then
            Dim inactivo As String = View.GetRowCellValue(e.RowHandle, gcolLoteTerminado)
            If inactivo = "1" Then 'Rojo
                e.Appearance.BackColor = Color.Red
                e.Appearance.BackColor2 = Color.Red
            End If
        End If
    End Sub
End Class