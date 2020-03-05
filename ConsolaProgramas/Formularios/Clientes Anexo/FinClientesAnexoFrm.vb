Imports LibDAO001

Public Class FinClientesAnexoFrm
    Public strUsuario, strPassword As String
    Public ClsConexion As New ClsConexion
    Public ClsU As New ClsUtilitarios
    Public ClsClientesAnexo As IDF_ClientesAnexo
    Public ClsClientes As IDF_Clientes
    Public ClsRetenciones As IDF_Retenciones
    Public ClsImpuesto As IDF_Impuestos
    Public int_error As Integer

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
        cCodigoRegistro = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "TP")

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
        cCodigoRegistro = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "TP")

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
            ClsU.NotaCompleta("El codigo de cliente o socio de negocio no existe en Protean. Verifique si el codigo es el correcto.", 16)
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
            ClsU.NotaCompleta("El codigo de cliente o socio de negocio no existe en Protean. Verifique si el codigo es el correcto.", 16)
            CmbGrabarNuevo.Enabled = False
            CmbGrabarSalir.Enabled = False
        End If
    End Sub

    Private Sub CmbEliminar_Click(sender As Object, e As EventArgs) Handles CmbEliminar.Click
        Dim oRegistro As New IDF_ClientesAnexo(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Dim cCodigoRegistro As String
        cCodigoRegistro = GrdConsultaView.GetRowCellValue(GrdConsultaView.FocusedRowHandle, "TP")

        oRegistro.TP = cCodigoRegistro

        Try
            oRegistro.Borrar()
        Catch ex As Exception
            ClsU.NotaCompleta("Debe de elegir un registro para eliminar." & ex.Message, 16)
        End Try

    End Sub
    Private Sub TxtTP_EditValueChanged(sender As Object, e As EventArgs) Handles TxtTP.Validated
        If TxtTP.Text.Length > 0 Then
            BuscarCliente(Me.TxtTP.Text)
        End If
    End Sub

#Region "Procedimientos Definidos por el usuario"
    Public Sub BuscarCliente(cTP As String)
        Dim cDescripcion As String
        Dim oRegConsulta As New IDF_Clientes
        Dim ClsClientes As New IDF_Clientes(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        oRegConsulta = IDF_Clientes.Buscar("TP='" & cTP & "'")
        'If String.IsNullOrEmpty(oRegConsulta.TP) = False Then
        '    cDescripcion = oRegConsulta.Description
        '    Me.TxtDescription.Text = cDescripcion
        '    Me.TxtDescription.Enabled = False
        '    Me.gbxInfo.Enabled = True
        'End If
        If (oRegConsulta Is Nothing) = False Then
            cDescripcion = oRegConsulta.Description
            Me.TxtDescription.Text = cDescripcion
            Me.TxtDescription.Enabled = False
            Me.gbxInfo.Enabled = True
        Else
            ClsU.NotaCompleta("Codigo de Cliente o Socio de Negocio, no existe en Protean. Verifique de nuevo", 16)
            CmbGrabarNuevo.Enabled = False
            CmbGrabarSalir.Enabled = False
        End If
    End Sub
    Public Sub RegresarConsulta()
        Me.XTTEmpaginacion.SelectedTabPage = XTTPagina1
    End Sub

    Public Sub Editar(cDato As String)

        Me.LblAccion.Text = "Edición de datos."
        Me.LblCodigoValor.Text = cDato

        Dim oRegEdicion As New IDF_ClientesAnexo(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        oRegEdicion = IDF_ClientesAnexo.Buscar("TP='" & cDato & "'")

        Me.TxtTP.Enabled = False
        Me.gbxInfo.Enabled = True

        If (oRegEdicion Is Nothing) = False Then
            Me.TxtTP.Text = oRegEdicion.TP

            Me.ChkEsOtrosComp.EditValue = oRegEdicion.EsOtrosComp
            Me.TxtDireccion.Text = oRegEdicion.Direccion
            Me.TxtDireccion.Focus()

            Me.TxtRTN.EditValue = oRegEdicion.RTN
            Me.TxtDirCliente2.EditValue = oRegEdicion.DirCliente2
            Me.TxtDirCliente3.EditValue = oRegEdicion.DirCliente3
            Me.TxtTelCliente1.EditValue = oRegEdicion.TelCliente1
            Me.TxtTelCliente2.EditValue = oRegEdicion.TelCliente2
            Me.TxtEmailCliente1.EditValue = oRegEdicion.EmailCliente1
            Me.TxtEmailCliente2.EditValue = oRegEdicion.EmailCliente2
            cbxRetencion.EditValue = oRegEdicion.RetencionID
            cbxImpuesto.EditValue = oRegEdicion.ImptoCodigo
        Else
            Me.ChkEsOtrosComp.Checked = False
            Me.TxtTP.Text = cDato
            Me.TxtDireccion.Text = ""
            Me.TxtRTN.EditValue = ""
            Me.TxtDirCliente2.EditValue = ""
            Me.TxtDirCliente3.EditValue = ""
            Me.TxtTelCliente1.EditValue = ""
            Me.TxtTelCliente2.EditValue = ""
            Me.TxtEmailCliente1.EditValue = ""
            Me.TxtEmailCliente2.EditValue = ""
            cbxRetencion.EditValue = Nothing
            cbxImpuesto.EditValue = Nothing
        End If

        'If Me.TxtTP.Text.Length > 0 Then
        '    BuscarCliente(Me.TxtTP.Text)
        'End If
        Me.XTTEmpaginacion.SelectedTabPage = XTTPagina2
        If cDato.Length > 0 Then
            BuscarCliente(cDato)
        End If

    End Sub

    Public Sub Nuevo()

        Me.LblAccion.Text = "Nuevo registro."
        Me.LblCodigoValor.Text = "<NuevoValor>"
        Me.XTTEmpaginacion.SelectedTabPage = XTTPagina2

        Dim oRegNuevo As New IDF_ClientesAnexo(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Me.TxtTP.Text = oRegNuevo.TP

        Me.TxtTP.Enabled = True
        Me.TxtTP.Focus()

        Me.ChkEsOtrosComp.Checked = False
        Me.TxtDescription.Text = ""
        Me.TxtDireccion.Text = oRegNuevo.Direccion
        Me.TxtRTN.EditValue = oRegNuevo.RTN
        Me.TxtDirCliente2.EditValue = oRegNuevo.DirCliente2
        Me.TxtDirCliente3.EditValue = oRegNuevo.DirCliente3
        Me.TxtTelCliente1.EditValue = oRegNuevo.TelCliente1
        Me.TxtTelCliente2.EditValue = oRegNuevo.TelCliente2
        Me.TxtEmailCliente1.EditValue = oRegNuevo.EmailCliente1
        Me.TxtEmailCliente2.EditValue = oRegNuevo.EmailCliente2
        cbxRetencion.EditValue = oRegNuevo.RetencionID
        cbxImpuesto.EditValue = oRegNuevo.ImptoCodigo

    End Sub

    Public Sub CargarRegistros()
        Dim DtDatos As New DataTable

        ClsClientesAnexo = New IDF_ClientesAnexo(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        Try
            'DtDatos = IDF_ClientesAnexo.Tabla("Select A.*, B.Description,B.Tipo From IDF_ClientesAnexo A outer Left Join IDF_SdNs B on A.TP=B.TP")
            DtDatos = IDF_ClientesAnexo.Tabla("Select B.TP,B.Description," &
                                              "A.TP AS TP2,A.Direccion,A.Direccion,a.RTN,A.DirCliente2,A.DirCliente3," &
                                              "A.TelCliente1, A.TelCliente2, A.EmailCliente1, A.EmailCliente2, B.Tipo, " &
                                              "a.RetencionID, a.ImptoCodigo " &
                                              "From IDF_ClientesAnexo A right join IDF_SdNs B on A.TP=B.TP")
            Me.GrdConsulta.DataSource = DtDatos


            ClsRetenciones = New IDF_Retenciones(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
            Dim dtRetencion As New DataTable
            dtRetencion = IDF_Retenciones.Tabla("Select * From IDF_Retenciones")
            Me.cbxRetencion.Properties.DataSource = dtRetencion
            Me.cbxRetencion.Properties.ValueMember = dtRetencion.Columns("RetencionID").ToString()
            Me.cbxRetencion.Properties.DisplayMember = dtRetencion.Columns("Descripcion").ToString()

            ClsImpuesto = New IDF_Impuestos(ClsConexion.CadenaFinanzas(strUsuario, strPassword))
            Dim dtImpuesto As New DataTable
            dtImpuesto = IDF_Impuestos.Tabla("Select * From IDF_Impuestos")
            Me.cbxImpuesto.Properties.DataSource = dtImpuesto
            Me.cbxImpuesto.Properties.ValueMember = dtImpuesto.Columns(0).ToString()
            Me.cbxImpuesto.Properties.DisplayMember = dtImpuesto.Columns(1).ToString()

        Catch ex As Exception
                ClsU.NotaCompleta("Problemas al consultar " & ex.Message, 16)
        End Try
    End Sub
    Private Sub FinClientesAnexoFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarRegistros()
    End Sub
    'Public Sub BuscarClienteAnexo()
    '    Dim DtDatos As New DataTable

    '    ClsClientesAnexo = New IDF_ClientesAnexo(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

    '    Try
    '        'DtDatos = IDF_ClientesAnexo.Tabla("Select A.*, B.Description,B.Tipo From IDF_ClientesAnexo A outer Left Join IDF_SdNs B on A.TP=B.TP")
    '        DtDatos = IDF_ClientesAnexo.Tabla("")
    '        Me.GrdConsulta.DataSource = DtDatos

    '    Catch ex As Exception
    '        ClsU.NotaCompleta("Problemas al consultar " & ex.Message, 16)
    '    End Try
    'End Sub
    Public Sub Grabar(cAccion As String)
        Dim oRegistro As New IDF_ClientesAnexo(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

        If Len(Me.TxtTP.Text) = 0 Then
            ClsU.NotaCompleta("Se requiere un código válido.", 16)
            Me.TxtTP.Focus()
            Exit Sub
        End If

        oRegistro.TP = Me.TxtTP.EditValue

        oRegistro.EsOtrosComp = Me.ChkEsOtrosComp.Checked
        oRegistro.Direccion = Me.TxtDireccion.Text
        oRegistro.RTN = Me.TxtRTN.EditValue
        oRegistro.DirCliente2 = Me.TxtDirCliente2.EditValue
        oRegistro.DirCliente3 = Me.TxtDirCliente3.EditValue
        oRegistro.TelCliente1 = Me.TxtTelCliente1.EditValue
        oRegistro.TelCliente2 = Me.TxtTelCliente2.EditValue
        oRegistro.EmailCliente1 = Me.TxtEmailCliente1.EditValue
        oRegistro.EmailCliente2 = Me.TxtEmailCliente2.EditValue
        oRegistro.RetencionID = cbxRetencion.EditValue.ToString()
        oRegistro.ImptoCodigo = cbxImpuesto.EditValue.ToString()

        If cAccion = "Edición de datos." Then

            Try
                oRegistro.Actualizar()
                ClsU.NotaCompleta("Registro actualizado satisfactoriamente!", 64)
            Catch ex As Exception
                ClsU.NotaCompleta("Error en la actualización." & ex.Message, 16)
            End Try
        End If

        If cAccion = "Nuevo registro." Then
            Try
                'Validar si ya existe el codigo de cliente en la tabla IDF_ClientesAnexo
                Dim DtDatos As New DataTable

                ClsClientesAnexo = New IDF_ClientesAnexo(ClsConexion.CadenaFinanzas(strUsuario, strPassword))

                'DtDatos = IDF_ClientesAnexo.Tabla("Select A.*, B.Description,B.Tipo From IDF_ClientesAnexo A outer Left Join IDF_SdNs B on A.TP=B.TP")
                DtDatos = IDF_ClientesAnexo.Tabla("SELECT A.* FROM IDF_ClientesAnexo A WHERE A.TP = '" & Me.TxtTP.Text & "' ")
                Me.GrdConsulta.DataSource = DtDatos

                If DtDatos.Rows.Count = 1 Then
                    ClsU.NotaCompleta("Error: El codigo de Socio de Negocio, ya existe en la base de datos. Intente de nuevo...", 16)
                Else
                    oRegistro.Crear()
                    ClsU.NotaCompleta("Registro creado satisfactoriamente!", 64)
                End If
            Catch ex As Exception
                ClsU.NotaCompleta("Error en la creación del registro." & ex.Message, 16)
            End Try
        End If

    End Sub

#End Region

End Class