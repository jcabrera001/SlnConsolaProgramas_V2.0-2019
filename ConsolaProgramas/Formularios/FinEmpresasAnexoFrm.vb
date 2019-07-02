Imports LibDAO001
Imports System.IO
Imports System.Data.SqlClient

Public Class FinEmpresasAnexoFrm
    Public strUsuario, strPassword As String
    Public ClsConexion As New ClsConexion
    Public ClsU As New ClsUtilitarios
    Public ClsEmpresasAnexo As IDF_EmpresasAnexo
    Public ClsEmpresas As IDF_Empresas
    Public ClsRetenciones As IDF_Retenciones
    Public ClsConfigXEmp As IDF_ConfigxEmp
    Public ClsDetConfigXEmp As IDF_DetConfigxEmp
    Public RESULTADO, StrLogo As String
    Public VerificarLogo As Int16
    Public int_error As Integer
    Public xLG As Byte()
    Dim adp, adpDetalle, adpTipo As SqlDataAdapter
    Dim dt, dtDetalle, dtTipo As New DataTable
    Dim cnx As SqlConnection
    Dim cmd As SqlCommand
    Dim fila As Boolean = False
    Dim filaPadre As Boolean = False
    Dim empresa As String
    'Dim cmd As SqlCommand


    Public Sub FuncionInicial(strU As String, strP As String)
        strUsuario = strU
        strPassword = strP
    End Sub


    Public Sub New(empresa As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.empresa = empresa
    End Sub

    Private Sub CmbEditar_Click(sender As Object, e As EventArgs) Handles CmbEditar.Click
        Dim cCodigoRegistro As String
        StrLogo = Nothing
        cCodigoRegistro = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "EmpresaCodigo")
        StrLogo = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "LogoEmpresa").ToString
        If StrLogo.Count > 0 Then
            xLG = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "LogoEmpresa")
            VerificarLogo = 1
        Else
            VerificarLogo = -1
        End If
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
        CmbGrabarNuevo.Enabled = True
        CmbGrabarSalir.Enabled = True
        Me.gbxInfo.Enabled = True
    End Sub

    Private Sub CmbActualizarConsulta_Click(sender As Object, e As EventArgs) Handles CmbActualizarConsulta.Click
        CargarRegistros()
    End Sub

    Private Sub GrdConsultaView_DoubleClick(sender As Object, e As EventArgs) Handles GrdConsultaView.DoubleClick
        Dim cCodigoRegistro As String
        StrLogo = Nothing
        cCodigoRegistro = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "EmpresaCodigo")
        StrLogo = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "LogoEmpresa").ToString
        If StrLogo.Count > 0 Then
            xLG = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "LogoEmpresa")
            VerificarLogo = 1
        Else
            VerificarLogo = -1
        End If
        Try
            Editar(cCodigoRegistro)
        Catch ex As Exception
            ClsU.NotaCompleta("Debe de elegir un registro para editar." & ex.Message, 16)
        End Try
    End Sub

    Private Sub CmbGrabarNuevo_Click(sender As Object, e As EventArgs) Handles CmbGrabarNuevo.Click
        int_error = 1
        If String.IsNullOrEmpty(TxtDescription.Text) = False Then
            If String.IsNullOrWhiteSpace(TxtDescription.Text) = False Then
                Grabar(Me.LblAccion.Text)
                Nuevo()
                CargarRegistros()
            Else
                int_error = -1
            End If
            int_error = -1
        End If
        If int_error = -1 Then
            ClsU.NotaCompleta("El codigo de Empresa no existe en Protean. Verifique si el codigo es el correcto.", 16)
            CmbGrabarNuevo.Enabled = False
            CmbGrabarSalir.Enabled = False
        End If
    End Sub

    Private Sub CmbGrabarSalir_Click(sender As Object, e As EventArgs) Handles CmbGrabarSalir.Click
        int_error = 1
        If String.IsNullOrEmpty(TxtDescription.Text) = False Then
            If String.IsNullOrWhiteSpace(TxtDescription.Text) = False Then
                Grabar(Me.LblAccion.Text)
            Else
                int_error = -1
            End If
        Else
            int_error = -1
        End If

        If int_error = -1 Then
            ClsU.NotaCompleta("El codigo de Empresa no existe en Protean. Verifique si el codigo es el correcto.", 16)
            CmbGrabarNuevo.Enabled = False
            CmbGrabarSalir.Enabled = False
        End If
    End Sub

    Private Sub CmbEliminar_Click(sender As Object, e As EventArgs) Handles CmbEliminar.Click
        Dim oRegistro As New IDF_EmpresasAnexo(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Dim cCodigoRegistro As String
        cCodigoRegistro = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "EmpresaCodigo")

        oRegistro.EmpresaCodigo = cCodigoRegistro

        Try
            oRegistro.Borrar()
        Catch ex As Exception
            ClsU.NotaCompleta("Debe de elegir un registro para eliminar." & ex.Message, 16)
        End Try

    End Sub
    Private Sub TxtEmpresaCodigo_EditValueChanged(sender As Object, e As EventArgs) Handles TxtEmpresaCodigo.Validated
        If TxtEmpresaCodigo.Text.Length > 0 Then
            BuscarEmpresa(Me.TxtEmpresaCodigo.Text)
        End If
    End Sub
    Private Sub GrdItems_Click(sender As Object, e As EventArgs) Handles GrdItems.Click
        Dim cCAI As String
        cCAI = GrdVwItems.GetRowCellValue(GrdVwItems.FocusedRowHandle, "CAI")

        If cCAI.Length > 0 Then
            CargarDetConfiguraciones(cCAI)
        End If
    End Sub

#Region "Procedimientos Definidos por el usuario"
    Public Sub BuscarEmpresa(cTP As String)
        Dim cDescripcion As String
        Dim oRegConsulta As New IDF_Empresas
        Dim ClsEmpresas As New IDF_Empresas(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        oRegConsulta = IDF_Empresas.Buscar("TP='" & cTP & "'")
        If (oRegConsulta Is Nothing) = False Then
            cDescripcion = oRegConsulta.Description
            Me.TxtDescription.Text = cDescripcion
            Me.TxtDescription.Enabled = False
            Me.gbxInfo.Enabled = True
        Else
            ClsU.NotaCompleta("Codigo de Empresa, no existe en Protean. Verifique de nuevo", 16)
            CmbGrabarNuevo.Enabled = False
            CmbGrabarSalir.Enabled = False
        End If
    End Sub
    Public Sub RegresarConsulta()
        Me.XTTEmpaginacion.SelectedTabPage = XTTPagina1
        PictureBox1.Image = Nothing
    End Sub

    Public Sub Editar(cDato As String)

        Me.XTPConfiguracion.PageVisible = True

        Me.LblAccion.Text = "Edición de datos."
        Me.LblCodigoValor.Text = cDato

        Dim oRegEdicion As New IDF_EmpresasAnexo(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        oRegEdicion = IDF_EmpresasAnexo.Buscar("EmpresaCodigo='" & cDato & "'")

        Me.TxtEmpresaCodigo.Text = oRegEdicion.EmpresaCodigo

        Me.TxtEmpresaCodigo.Enabled = False
        Me.gbxInfo.Enabled = True

        Me.TxtDireccion.Text = oRegEdicion.Direccion
        Me.TxtDireccion.Focus()

        Me.TxtRTN.EditValue = oRegEdicion.RTN
        Me.TxtTelCliente1.EditValue = oRegEdicion.Telefono
        Me.TxtEmailCliente1.EditValue = oRegEdicion.Email
        Me.TxtFDA.EditValue = oRegEdicion.FDA
        Me.TxtRetencionID.EditValue = oRegEdicion.RetencionID
        Me.memoTxtNotaDoc1.Text = oRegEdicion.NotaDoc1

        If VerificarLogo > 0 Then
            'Dim xLogoEmpresa As Byte = New Byte()
            'xLogoEmpresa = oRegEdicion.LogoEmpresa
            'Leer la imagen en memoria
            Dim ms As New MemoryStream(xLG)
            PictureBox1.Image = Image.FromStream(ms)
        End If

        Me.XTTEmpaginacion.SelectedTabPage = XTTPagina2

        If Me.TxtEmpresaCodigo.Text.Length > 0 Then
            BuscarEmpresa(Me.TxtEmpresaCodigo.Text)
        End If

        CargarConfiguraciones()

    End Sub

    Public Sub Nuevo()

        Me.LblAccion.Text = "Nuevo registro."
        Me.LblCodigoValor.Text = "<NuevoValor>"
        Me.XTTEmpaginacion.SelectedTabPage = XTTPagina2
        Me.XTPConfiguracion.PageVisible = False

        Dim oRegNuevo As New IDF_EmpresasAnexo(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Me.TxtEmpresaCodigo.Text = oRegNuevo.EmpresaCodigo

        Me.TxtEmpresaCodigo.Enabled = True
        Me.TxtEmpresaCodigo.Focus()

        Me.TxtDescription.Text = ""
        Me.TxtDireccion.Text = oRegNuevo.Direccion
        Me.TxtRTN.EditValue = oRegNuevo.RTN
        Me.TxtTelCliente1.EditValue = oRegNuevo.Telefono
        Me.TxtEmailCliente1.EditValue = oRegNuevo.Email
        Me.TxtFDA.EditValue = oRegNuevo.FDA
        Me.TxtRetencionID.EditValue = oRegNuevo.RetencionID
        Me.memoTxtNotaDoc1.EditValue = oRegNuevo.NotaDoc1
    End Sub

    Public Sub CargarRegistros()
        Dim DtDatos As New DataTable
        Dim DtDatosRetenciones As New DataTable
        PictureBox1.Image = Nothing
        ClsEmpresasAnexo = New IDF_EmpresasAnexo(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        ClsRetenciones = New IDF_Retenciones(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Try
            DtDatos = IDF_EmpresasAnexo.Tabla("Select A.*, B.Description From IDF_EmpresasAnexo A Left Join IDF_Empresas B on A.EmpresaCodigo=B.TP where TP = '" & empresa & "'")
            Me.GrdConsulta.DataSource = DtDatos

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Empresas." & ex.Message, 16)
        End Try

        Try
            DtDatosRetenciones = IDF_Retenciones.Tabla()
            TxtRetencionID.Properties.DataSource = DtDatosRetenciones
            TxtRetencionID.Properties.ValueMember = DtDatosRetenciones.Columns(0).ToString()
            TxtRetencionID.Properties.DisplayMember = DtDatosRetenciones.Columns(1).ToString()

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Retenciones." & ex.Message, 16)
        End Try

    End Sub

    Public Sub CargarConfiguraciones()
        Dim DtDatos As New DataTable

        ClsConfigXEmp = New IDF_ConfigxEmp(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Try
            DtDatos = IDF_ConfigxEmp.Tabla("Select * From IDF_ConfigXEmp Where EmpresaCodigo='" & Me.TxtEmpresaCodigo.EditValue & "'")
            Me.GrdItems.DataSource = DtDatos

        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Configuraciones por Empresa." & ex.Message, 16)
        End Try

    End Sub

    Public Sub CargarDetConfiguraciones(cCAI As String)
        Dim DtDetalle As New DataTable

        ClsDetConfigXEmp = New IDF_DetConfigxEmp(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Try
            DtDetalle = IDF_DetConfigxEmp.Tabla("Select A.*, B.Descripcion As TiposDoctoDescrip, case when a.EsActual = 1 then 'Activo' else 'Inactivo' end Estado From IDF_DetConfigXEmp A Left Join IDF_TiposDoctos B on A.TiposDoctoID = B.TiposDoctoID Where A.CAI='" & cCAI & "' and B.TieneDetalle=1")
            Me.GrdDetalle.DataSource = DtDetalle
        Catch ex As Exception
            ClsU.NotaCompleta("Problemas al consultar Detalles de Configuraciones por Empresa." & ex.Message, 16)
        End Try

    End Sub


    Public Sub Grabar(cAccion As String)
        Dim oRegistro As New IDF_EmpresasAnexo(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        If Len(Me.TxtEmpresaCodigo.Text) = 0 Then
            ClsU.NotaCompleta("Se requiere un código válido.", 16)
            Me.TxtEmpresaCodigo.Focus()
            Exit Sub
        End If

        oRegistro.EmpresaCodigo = Me.TxtEmpresaCodigo.EditValue

        oRegistro.Direccion = Me.TxtDireccion.Text
        oRegistro.RTN = Me.TxtRTN.EditValue
        oRegistro.Telefono = Me.TxtTelCliente1.EditValue
        oRegistro.Email = Me.TxtEmailCliente1.EditValue
        oRegistro.FDA = Me.TxtFDA.EditValue
        oRegistro.RetencionID = Me.TxtRetencionID.EditValue
        oRegistro.NotaDoc1 = memoTxtNotaDoc1.EditValue

        If txtPathLogo.Text.Length > 0 Then
            oRegistro.LogoEmpresa = ClsU.FnxLocalLeerArchivoImagen(txtPathLogo.Text)
        ElseIf txtPathLogo.Text.Length = 0 Then
            oRegistro.LogoEmpresa = Nothing
        End If

        If cAccion = "Edición de datos." Then

            Try
                RESULTADO = oRegistro.Actualizar()
                If RESULTADO Like "ERROR%" Then
                    ClsU.Nota("No se pudo actualizar el nuevo registro [" & RESULTADO & "]")
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

    Private Sub CmbCargaLogo_Click(sender As Object, e As EventArgs) Handles CmbCargaLogo.Click

        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            txtPathLogo.Text = OpenFileDialog1.FileName.ToString
        End If
    End Sub

    Private Sub FinEmpresasAnexoFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarRegistros()
    End Sub

    Private Sub CmbNuevoItem_Click(sender As Object, e As EventArgs) Handles CmbNuevoItem.Click
        EditarCAI(-1)
        'filaPadre = False
    End Sub

   
    Public Sub EditarCAI(cDato As String)
        LimpiarCabecera()
        Me.XTTEmpaginacion.SelectedTabPage = XTTPagina3
        CmbGrabarSalir.Visible = False
        CmbGrabarNuevo.Visible = False

        cnx = New SqlConnection(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Me.XTPConfiguracion.PageVisible = True
        Me.lblAccionCAI.Text = "Edición de datos."
        Me.LblCai.Text = cDato


        adpTipo = New SqlDataAdapter("select TiposDoctoID, Descripcion from IDF_TiposDoctos", cnx)
        adpTipo.Fill(dtTipo)

        cbxTipo.Properties.DataSource = dtTipo
        cbxTipo.Properties.ValueMember = "TiposDoctoID"
        cbxTipo.Properties.DisplayMember = "Descripcion"
        cbxTipo.Properties.PopulateColumns()
        'cbxTipo.Properties.Columns("TiposDoctoID").Visible = False

      
        adp = New SqlDataAdapter("select * from IDF_ConfigXEmp where CAI='" & cDato & "'", cnx)
        adp.InsertCommand = New SqlCommand("spIDF_ConfigxEmpInsert", cnx)
        adp.InsertCommand.CommandType = CommandType.StoredProcedure
        adp.InsertCommand.Parameters.Add("@EmpresaCodigo", SqlDbType.VarChar, 50, "EmpresaCodigo")
        adp.InsertCommand.Parameters.Add("@FechaLimite", SqlDbType.Date, 20, "FechaLimite")
        adp.InsertCommand.Parameters.Add("@CAI", SqlDbType.VarChar, 50, "CAI")
        adp.InsertCommand.Parameters.Add("@Declaracion", SqlDbType.VarChar, 50, "Declaracion")
        adp.InsertCommand.Parameters.Add("@FechaRecepcion", SqlDbType.Date, 20, "FechaRecepcion")


        adp.UpdateCommand = New SqlCommand("spIDF_ConfigxEmpUpdate", cnx)
        adp.UpdateCommand.CommandType = CommandType.StoredProcedure
        adp.UpdateCommand.Parameters.Add("@EmpresaCodigo", SqlDbType.VarChar, 2, "EmpresaCodigo")
        adp.UpdateCommand.Parameters.Add("@FechaLimite", SqlDbType.Date, 20, "FechaLimite")
        adp.UpdateCommand.Parameters.Add("@FechaRecepcion", SqlDbType.Date, 20, "FechaRecepcion")
        adp.UpdateCommand.Parameters.Add("@CAI", SqlDbType.VarChar, 50, "CAI")
        adp.UpdateCommand.Parameters.Add("@Declaracion", SqlDbType.VarChar, 50, "Declaracion")
        adp.UpdateCommand.Parameters.Add("@ConfigxEmpID", SqlDbType.Int, 4, "ConfigxEmpID")

        adpDetalle = New SqlDataAdapter("spIDF_DetConfigXEmpSelect '" & cDato & "'", cnx)
        adpDetalle.InsertCommand = New SqlCommand("spIDF_DetConfigXEmpInsert", cnx)
        adpDetalle.InsertCommand.CommandType = CommandType.StoredProcedure
        adpDetalle.InsertCommand.Parameters.Add("@CAI", SqlDbType.VarChar, 40, "CAI")
        adpDetalle.InsertCommand.Parameters.Add("@TipoID", SqlDbType.Int, 4, "TipoID")
        adpDetalle.InsertCommand.Parameters.Add("@Solicitado", SqlDbType.Int, 5, "Solicitado")
        adpDetalle.InsertCommand.Parameters.Add("@Otorgado", SqlDbType.Int, 5, "Otorgado")
        adpDetalle.InsertCommand.Parameters.Add("@Inicial", SqlDbType.Int, 5, "Inicial")
        adpDetalle.InsertCommand.Parameters.Add("@Final", SqlDbType.Int, 5, "Final")
        adpDetalle.InsertCommand.Parameters.Add("@Punto", SqlDbType.VarChar, 5, "Punto")
        adpDetalle.InsertCommand.Parameters.Add("@Prefijo", SqlDbType.VarChar, 5, "Prefijo")
        adpDetalle.InsertCommand.Parameters.Add("@esActual", SqlDbType.Bit, 1, "esActual")
        adpDetalle.InsertCommand.Parameters.Add("@emp", SqlDbType.VarChar, 5, "Emp")
        adpDetalle.InsertCommand.Parameters.Add("@Usuario", SqlDbType.VarChar, 20, "Usuario")

        adpDetalle.UpdateCommand = New SqlCommand("spIDF_DetConfigXEmpUpdate", cnx)
        adpDetalle.UpdateCommand.CommandType = CommandType.StoredProcedure
        adpDetalle.UpdateCommand.Parameters.Add("@DetConfigxEmpID", SqlDbType.Int, 5, "DetConfigxEmpID")
        adpDetalle.UpdateCommand.Parameters.Add("@CAI", SqlDbType.VarChar, 40, "CAI")
        adpDetalle.UpdateCommand.Parameters.Add("@TipoID", SqlDbType.Int, 4, "TipoID")
        adpDetalle.UpdateCommand.Parameters.Add("@Solicitado", SqlDbType.Int, 5, "Solicitado")
        adpDetalle.UpdateCommand.Parameters.Add("@Otorgado", SqlDbType.Int, 5, "Otorgado")
        adpDetalle.UpdateCommand.Parameters.Add("@Inicial", SqlDbType.Int, 5, "Inicial")
        adpDetalle.UpdateCommand.Parameters.Add("@Final", SqlDbType.Int, 5, "Final")
        adpDetalle.UpdateCommand.Parameters.Add("@Punto", SqlDbType.VarChar, 5, "Punto")
        adpDetalle.UpdateCommand.Parameters.Add("@Prefijo", SqlDbType.VarChar, 5, "Prefijo")
        adpDetalle.UpdateCommand.Parameters.Add("@esActual", SqlDbType.Bit, 1, "esActual")
        adpDetalle.UpdateCommand.Parameters.Add("@emp", SqlDbType.VarChar, 5, "Emp")
        adpDetalle.UpdateCommand.Parameters.Add("@Usuario", SqlDbType.VarChar, 20, "Usuario")



        adpDetalle.DeleteCommand = New SqlCommand("spIDF_DetConfigXEmpDelete", cnx)

        adpDetalle.Fill(dtDetalle)
        adp.Fill(dt)
        gcDet.DataSource = dtDetalle

        GvDet.Columns(0).Visible = False
        GvDet.Columns(1).Visible = False
        GvDet.Columns(2).Visible = False
        GvDet.Columns("Punto").Visible = False
        GvDet.Columns("Prefijo").Visible = False
        GvDet.Columns("EsActual").Visible = False
        GvDet.Columns("Emp").Visible = False
        GvDet.Columns("Usuario").Visible = False

        If dt.Rows.Count = 0 Then
            dt.Rows.Add()
        Else
            dtFecha.EditValue = IIf(IsDBNull(CDate(dt.DefaultView.Item(0).Item("FechaLimite"))), Now, CDate(dt.DefaultView.Item(0).Item("FechaLimite")))
            dtRecepcion.EditValue = IIf(IsDBNull(CDate(dt.DefaultView.Item(0).Item("FechaREcepcion"))), Now, CDate(dt.DefaultView.Item(0).Item("FechaREcepcion")))
        End If

        txtCAI.Text = dt.DefaultView.Item(0).Item("CAI").ToString
        txtDeclaracion.Text = dt.DefaultView.Item(0).Item("Declaracion").ToString

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Me.XTTEmpaginacion.SelectedTabPage = XTTPagina2
        PictureBox1.Image = Nothing

        CmbGrabarNuevo.Enabled = True
        CmbGrabarSalir.Enabled = True
        Me.gbxInfo.Enabled = True
        dtTipo.Clear()
        RegresarVista()
    End Sub

    Private Sub cmbModificarItem_Click(sender As Object, e As EventArgs) Handles cmbModificarItem.Click
        'Modificar el CAI
        Dim cCodigoRegistro As String
        cCodigoRegistro = GrdVwItems.GetRowCellValue(GrdVwItems.FocusedRowHandle, "CAI")

        Try
            EditarCAI(cCodigoRegistro)
            'filaPadre = True
        Catch ex As Exception
            ClsU.NotaCompleta("Debe de elegir un registro para editar." & ex.Message, 16)
            ' filaPadre = False
        End Try
    End Sub

    Private Sub btnDetail_Click(sender As Object, e As EventArgs) Handles btnDetail.Click
        fila = False
        Detail()
    End Sub

    Private Sub Detail() 'Ocultar Grupo de registro
        GrpRegistro.Visible = True
        btnDeleteDetail.Enabled = False
        btnEditDetail.Enabled = False
        btnDetail.Enabled = False
    End Sub

    Private Sub CmbRegCancelar_Click(sender As Object, e As EventArgs)
        RegresarVista()
        gcDet.Enabled = True
    End Sub
    Public Sub RegresarVista()  'Limpiar los datos del detalle
        GrpRegistro.Visible = False
        btnDeleteDetail.Enabled = True
        btnEditDetail.Enabled = True
        btnDetail.Enabled = True
        txtIni.Text = ""
        txtFina.Text = ""
        txtSoli.Text = ""
        txtOtor.Text = ""
        txtPunto.Text = ""
        txtPrefijo.Text = ""

        chk.Checked = False
    End Sub

    Private Sub btnEditDetail_Click(sender As Object, e As EventArgs) Handles btnEditDetail.Click


        Try 'Boton de Editar.
            fila = True
            txtIni.Text = dtDetalle.DefaultView.Item(GvDet.FocusedRowHandle).Item("Inicial")
            txtSoli.Text = dtDetalle.DefaultView.Item(GvDet.FocusedRowHandle).Item("Solicitado")
            txtOtor.Text = dtDetalle.DefaultView.Item(GvDet.FocusedRowHandle).Item("Otorgado")
            txtFina.Text = dtDetalle.DefaultView.Item(GvDet.FocusedRowHandle).Item("Final")
            txtPrefijo.Text = dtDetalle.DefaultView.Item(GvDet.FocusedRowHandle).Item("Prefijo")
            txtPunto.Text = dtDetalle.DefaultView.Item(GvDet.FocusedRowHandle).Item("Punto")
            chk.Checked = dtDetalle.DefaultView.Item(GvDet.FocusedRowHandle).Item("EsActual")
            cbxTipo.EditValue = dtDetalle.DefaultView.Item(GvDet.FocusedRowHandle).Item("TipoID")

            Detail()
            gcDet.Enabled = False

        Catch ex As Exception
            ClsU.NotaCompleta("Debe de elegir un registro para editar." & ex.Message, 16)
            fila = False
        End Try
       
    End Sub

    Private Sub CmbRegActualizar_Click(sender As Object, e As EventArgs)
        Dim err As New FrmError
        If txtCAI.Text.Length = 0 Then err.AddErr("Debe Ingresar el CAI", 1)
        If txtDeclaracion.Text.Length = 0 Then err.AddErr("Debe Ingresar el número de declaración", 0)
        If txtPunto.Text.Length = 0 Then err.AddErr("Debe Ingresar el número del punto de emisión", 0)
        If txtPrefijo.Text.Length = 0 Then err.AddErr("Debe Ingresar el número de prefijo", 0)
        If txtIni.Text.Length = 0 Then err.AddErr("Debe Ingresar el número inicial", 0)
        If txtFina.Text.Length = 0 Then err.AddErr("Debe Ingresar el número de final", 0)
        If txtOtor.Text.Length = 0 Then err.AddErr("Debe Ingresar el número otorgado", 0)
        If txtSoli.Text.Length = 0 Then err.AddErr("Debe Ingresar el número de Solicitado", 0)
        If IsNothing(cbxTipo.EditValue) Then err.AddErr("Debe seleccionar un tipo de documento", 0)

        If err.isErr Then
            err.ShowDialog()
            Exit Sub
        Else
            If fila Then
                dtDetalle.DefaultView.Item(GvDet.FocusedRowHandle).Item("Inicial") = txtIni.Text
                dtDetalle.DefaultView.Item(GvDet.FocusedRowHandle).Item("Solicitado") = txtSoli.Text
                dtDetalle.DefaultView.Item(GvDet.FocusedRowHandle).Item("Otorgado") = txtOtor.Text
                dtDetalle.DefaultView.Item(GvDet.FocusedRowHandle).Item("Final") = txtFina.Text
                dtDetalle.DefaultView.Item(GvDet.FocusedRowHandle).Item("TipoID") = cbxTipo.EditValue
                dtDetalle.DefaultView.Item(GvDet.FocusedRowHandle).Item("Descripcion") = cbxTipo.Text
                dtDetalle.DefaultView.Item(GvDet.FocusedRowHandle).Item("CAI") = txtCAI.Text
                dtDetalle.DefaultView.Item(GvDet.FocusedRowHandle).Item("Punto") = txtPunto.Text
                dtDetalle.DefaultView.Item(GvDet.FocusedRowHandle).Item("Prefijo") = txtPrefijo.Text
                dtDetalle.DefaultView.Item(GvDet.FocusedRowHandle).Item("PrefijoNum") = "000-" & txtPunto.Text & "-" & txtPrefijo.Text & "-"
                dtDetalle.DefaultView.Item(GvDet.FocusedRowHandle).Item("EsActual") = chk.Checked
                dtDetalle.DefaultView.Item(GvDet.FocusedRowHandle).Item("Actual") = IIf(chk.Checked, "Activo", "Inactivo")
            Else

                Dim rnew = dtDetalle.NewRow  'Agregar un nuevo registro

                rnew.Item("Inicial") = txtIni.Text
                rnew.Item("Solicitado") = txtSoli.Text
                rnew.Item("Otorgado") = txtOtor.Text
                rnew.Item("Final") = txtFina.Text
                rnew.Item("TipoID") = cbxTipo.EditValue
                rnew.Item("Descripcion") = cbxTipo.Text
                rnew.Item("CAI") = txtCAI.Text
                rnew.Item("Punto") = txtPunto.Text
                rnew.Item("Prefijo") = txtPrefijo.Text
                rnew.Item("PrefijoNum") = "000-" & txtPunto.Text & "-" & txtPrefijo.Text & "-"
                rnew.Item("EsActual") = chk.Checked
                rnew.Item("Actual") = IIf(chk.Checked, "Activo", "Inactivo")

                dtDetalle.Rows.Add(rnew)
                txtIni.Text = ""
                txtOtor.Text = ""
                txtSoli.Text = ""
                txtFina.Text = ""
                txtPrefijo.Text = ""
                txtPunto.Text = ""
                chk.Checked = False
            End If
            RegresarVista()
            gcDet.Enabled = True
        End If
    End Sub
    Public Sub LimpiarCabecera()
        dt.Clear()
        dtDetalle.Clear()
        txtCAI.Text = ""
        txtDeclaracion.Text = ""
        cbxTipo.EditValue = Now()
    End Sub

    Private Sub SaveCAI_Click(sender As Object, e As EventArgs) Handles SaveCAI.Click

        dt.Rows(0).Item("EmpresaCodigo") = TxtEmpresaCodigo.Text
        dt.Rows(0).Item("CAI") = txtCAI.Text
        dt.Rows(0).Item("FechaLimite") = CDate(dtFecha.EditValue)
        dt.Rows(0).Item("FechaRecepcion") = CDate(dtRecepcion.EditValue)
        dt.Rows(0).Item("Declaracion") = txtDeclaracion.Text

        For Each row As DataRow In dtDetalle.Rows
            row.Item("emp") = TxtEmpresaCodigo.Text
            row.Item("Usuario") = strUsuario
        Next

         adp.Update(dt)
        adpDetalle.Update(dtDetalle)

        MsgBox("Registro creado exitosamente", MsgBoxStyle.Information, "Ingreso de CAI")
        CargarConfiguraciones()
    End Sub

    Private Sub btnDeleteDetail_Click(sender As Object, e As EventArgs) Handles btnDeleteDetail.Click

    End Sub

    Private Sub cmbAnular_Click(sender As Object, e As EventArgs) Handles cmbAnular.Click
        cnx = New SqlConnection(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
        cnx.Open()
        If GridView1.FocusedRowHandle < 0 Then
            MsgBox("Debe seleccionar un registro", MsgBoxStyle.Critical, "ERROR")
        Else
            If MsgBox("Seguro que desea anular el documento seleccionado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Anulación de documentos") = MsgBoxResult.Yes Then
                Try
                    cmd = New SqlCommand("spAnularCaiActual @emp, @CAI , @TipoID , @user ", cnx)
                    cmd.Parameters.AddWithValue("@emp", TxtEmpresaCodigo.Text)
                    cmd.Parameters.AddWithValue("@CAI", GrdVwItems.GetRowCellValue(GrdVwItems.FocusedRowHandle, "CAI").ToString())
                    cmd.Parameters.AddWithValue("@TipoID", GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "TiposDoctoID").ToString())
                    cmd.Parameters.AddWithValue("@user", strUsuario)

                    cmd.ExecuteNonQuery()
                    GridView1.SetFocusedRowCellValue("Estado", "Inactivo")
                    MsgBox("Documento anulado exitosamente!", MsgBoxStyle.Information, "Anulación de documentos")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
        cnx.Close()

    End Sub

End Class