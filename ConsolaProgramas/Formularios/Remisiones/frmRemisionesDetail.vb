Imports System.Data.SqlClient
Public Class frmRemisionesDetail
    Private user As String
    Private emp As String

    Private ID, fila As Integer
    Private f As New Funciones
    Private adp As SqlDataAdapter
    Private dt As New DataTable
    Private adpDetalle As SqlDataAdapter
    Private dtDetalle As New DataTable
    Public Sub New(cnx As SqlConnection, ID As Integer, user As String, emp As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        f.Conexion = cnx
        Me.user = user
        Me.emp = emp
        Me.ID = ID

        Dim dtEmpresa As DataTable = f.getDataTable("select * from IDF_Empresas where Tp = '" & emp & "'")
        cmbEmpresa.Properties.NullText = dtEmpresa.Rows(0).Item("Description").ToString()
    End Sub
    Private Sub frmRemisionesDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTables()
        setCombos()
        Adapters()
        Init()
    End Sub
    Private Sub cmbConductor_EditValueChanged(sender As Object, e As EventArgs) Handles cmbConductor.EditValueChanged
        If ID = -1 Then
            If cmbConductor.EditValue.ToString.Length > 0 Then
                Try
                    Dim dtConductor As DataTable = f.getDataTable("spConductoresBiosalc '" & cmbConductor.SelectedText & "'")

                    txtMarca.Text = dtConductor.Rows(0).Item("MarcaPred").ToString
                    txtPlaca.Text = dtConductor.Rows(0).Item("PlacaPred").ToString
                    txtLicencia.Text = dtConductor.Rows(0).Item("Identificacion").ToString
                    txtIdentidad.Text = dtConductor.Rows(0).Item("Identificacion").ToString
                Catch ex As Exception
                    MsgBox("Erro al consultar la informacion del conductor!")
                End Try


            End If
        End If
    End Sub
    Private Sub cmbProductos_EditValueChanged(sender As Object, e As EventArgs) Handles cmbProductos.EditValueChanged
        If ID = -1 Then
            If cmbProductos.EditValue <> "" Then

                'cmbUnidad.EditValue = cmbProduct
            End If
        End If
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        gbDetalleRegistro(-1)
    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        gbDetalleRegistro(gvDetalle.FocusedRowHandle)

    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        CleangbDetalleRegistro()
    End Sub
    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        Dim err As New frmErrors

        If txtCantidad.Text.Length = 0 Then err.NuevoError("Debe Ingresar la cantidad", 0)
        If IsNothing(cmbProductos.EditValue) Then err.NuevoError("Debe seleccionar un Producto", 0)
        If IsNothing(cmbUnidades.EditValue) Then err.NuevoError("Debe seleccionar una unidad de medida", 0)
        If txtDes.Text.Length = 0 Then err.NuevoError("Campo de Descripción vacío", 1)
        'If txtDes2.Text.Length = 0 Then err.NuevoError("Campo de observaciones vacío", 1)

        If err.Errores Then
            err.ShowDialog()
            If Not err.isOk Then
                Exit Sub
            End If
        End If


        If fila < 0 Then
            dtDetalle.Rows.Add()
            fila = dtDetalle.Rows.Count - 1
        End If


        dtDetalle.Rows(fila).Item("ProdCodigo") = cmbProductos.EditValue
        dtDetalle.Rows(fila).Item("nomProducto") = cmbProductos.Text
        dtDetalle.Rows(fila).Item("UnidMedCodigo") = cmbUnidades.EditValue
        dtDetalle.Rows(fila).Item("nomUnidad") = cmbUnidades.Text
        dtDetalle.Rows(fila).Item("Cantidad") = txtCantidad.EditValue
        dtDetalle.Rows(fila).Item("Descrip1") = txtDes.Text
        dtDetalle.Rows(fila).Item("Descrip2") = txtDes2.Text
        'dtDetalle.Rows(fila).Item("ProdxRemID") = txtProxRemID.Text

        CleangbDetalleRegistro()
    End Sub
    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim err As New frmErrors

        If IsNothing(cmbCliente.EditValue) Then err.NuevoError("Debe seleccionar un cliente", 0)
        If IsNothing(cmbTransportista.EditValue) Then err.NuevoError("Debe seleccionar un Transportista", 0)
        If cmbConductor.Text.Length = 0 Then err.NuevoError("Debe seleccionar un Conductor", 0)
        If IsNothing(dtpFecha.EditValue) Then err.NuevoError("Debe seleccionar una fecha", 0)
        If IsNothing(dtpInicio.EditValue) Then err.NuevoError("Debe seleccionar una fecha de inicio", 0)
        If IsNothing(dtpTerminacion.EditValue) Then err.NuevoError("Debe seleccionar una fecha de terminacion", 0)
        If txtPuntoPartida.Text.Length = 0 Then err.NuevoError("Campo de Punto Partida vacío", 0)
        If txtPuntoDestino.Text.Length = 0 Then err.NuevoError("Campo de Punto Destino vacío", 0)
        If txtMarca.Text.Length = 0 Then err.NuevoError("Campo de Marca vacío", 1)
        If txtPlaca.Text.Length = 0 Then err.NuevoError("Campo de Placa vacío", 1)
        If txtLicencia.Text.Length = 0 Then err.NuevoError("Campo de Licencia vacío", 1)

        'If txtDes2.Text.Length = 0 Then err.NuevoError("Campo de observaciones vacío", 1)

        If err.Errores Then
            err.ShowDialog()
            If Not err.isOk Then
                Exit Sub
            End If
        End If

        dt.Rows(0).Item("Fecha") = dtpFecha.EditValue
        dt.Rows(0).Item("SdNCodigo") = cmbCliente.EditValue
        dt.Rows(0).Item("UsuEditor") = user
        dt.Rows(0).Item("ConductorID") = cmbConductor.EditValue
        dt.Rows(0).Item("TransportistaID") = cmbTransportista.EditValue

        If txtOrdenPeso.Text.Length > 0 Then
            dt.Rows(0).Item("NumOrdenPesoBiosalc") = txtOrdenPeso.Text
        End If

        dt.Rows(0).Item("CAI") = caiRemision

            dt.Rows(0).Item("Marca") = txtMarca.Text
        dt.Rows(0).Item("Placa") = txtPlaca.Text
        dt.Rows(0).Item("Licencia") = txtLicencia.Text
        dt.Rows(0).Item("Identidad") = txtIdentidad.Text
        dt.Rows(0).Item("NumCabezal") = txtCabezal.Text
        dt.Rows(0).Item("Marchamo1") = txtSello1.Text
        dt.Rows(0).Item("Marchamo2") = txtSello2.Text
        dt.Rows(0).Item("Marchamo3") = txtSello3.Text
        dt.Rows(0).Item("Marchamo4") = txtSello4.Text

        dt.Rows(0).Item("Motivo") = rbtMotivo.SelectedIndex
        dt.Rows(0).Item("OtroMotivo") = TxtOtroMotivo.Text
        dt.Rows(0).Item("FechaInicio") = dtpInicio.EditValue
        dt.Rows(0).Item("FechaFinal") = dtpTerminacion.EditValue
        dt.Rows(0).Item("PuntoPartida") = txtPuntoPartida.Text
        dt.Rows(0).Item("PuntoDestino") = txtPuntoDestino.Text
        dt.Rows(0).Item("EmpresaCodigo") = emp
        dt.Rows(0).Item("UsuCreador") = user


        adp.Update(dt)
        Dim RemisionID As Integer = dt.Rows(0).Item("RemisionID")

        For Each row As DataRow In dtDetalle.Rows
            If row.RowState <> DataRowState.Deleted Then
                row.Item("RemisionID") = RemisionID
            End If
        Next

        adpDetalle.Update(dtDetalle)

        MsgBox("Remisión creada exitosamente!", MsgBoxStyle.Information, "Guía de remisión")
        Me.Close()
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        'If IsNothing(gvDetalle.GetFocusedRowCellValue("FlaDetalleFacturaID")) Then  '("FlaDetalleFacturaID").ToString() =  Then
        gvDetalle.DeleteSelectedRows()
        'End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnProcesarOrdenBioSalc_Click(sender As Object, e As EventArgs) Handles btnProcesarOrdenBioSalc.Click
        If txtOrdenPeso.Text.Length = 0 Then
            MsgBox("Debe ingresar un número de Ticket", MsgBoxStyle.Critical, "Error")
        Else
            Dim dtBiosalc As DataTable = f.getDataTable("spRemisionBiosalcT '" & txtOrdenPeso.Text & "'")

            If dtBiosalc.Rows.Count = 0 Then
                MsgBox("Número de Ticket no es valido", MsgBoxStyle.Critical, "Error")
            Else
                cmbCliente.EditValue = dtBiosalc.Rows(0).Item("CodCliente")
                rbtMotivo.SelectedIndex = dtBiosalc.Rows(0).Item("MotivoRemision")
                cmbTransportista.EditValue = dtBiosalc.Rows(0).Item("TransportistaID")
                cmbConductor.EditValue = dtBiosalc.Rows(0).Item("ConductorID")
                txtMarca.Text = dtBiosalc.Rows(0).Item("MarcaVehiculo")
                txtPlaca.Text = dtBiosalc.Rows(0).Item("Placa")
                txtCabezal.Text = dtBiosalc.Rows(0).Item("VehiculoID")

                For Each row As DataRow In dtBiosalc.Rows
                    Dim nrow As DataRow = dtDetalle.NewRow
                    nrow.Item("ProdCodigo") = row.Item("CodProducto")
                    nrow.Item("Cantidad") = row.Item("Cantidad")
                    nrow.Item("UnidMedCodigo") = row.Item("UnidadMedidaID")
                    nrow.Item("CodEmpaqueBioSalc") = row.Item("CodEmpaque")
                    nrow.Item("nomProducto") = row.Item("nomProducto")
                    nrow.Item("nomUnidad") = row.Item("nomUnidad")

                    dtDetalle.Rows.Add(nrow)
                Next

            End If
        End If
    End Sub


#Region "Definidos propios"
    Private Sub gbDetalleRegistro(id As Integer)
        gbDetalle.Visible = True
        gcDetalle.Enabled = False
        fila = id 'Asigna la posición de la fila al campo.
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnNuevo.Enabled = False

        'Si la fila ya existe, se pasan los valores a los campos.
        If id >= 0 Then
            cmbProductos.EditValue = dtDetalle.Rows(id).Item("ProdCodigo")
            cmbUnidades.EditValue = dtDetalle.Rows(id).Item("UnidMedCodigo")
            txtCantidad.EditValue = dtDetalle.Rows(id).Item("Cantidad")
            ' cmbEmbalaje.EditValue = dtDetalle.Rows(id).Item("PesoEmbBioSalc")
            txtDes.Text = dtDetalle.Rows(id).Item("Descrip1").ToString()
            txtDes2.Text = dtDetalle.Rows(id).Item("Descrip2").ToString()
        End If

    End Sub
    Private Sub CleangbDetalleRegistro()
        gbDetalle.Visible = False
        gcDetalle.Enabled = True
        fila = Nothing
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        btnNuevo.Enabled = True

        cmbProductos.EditValue = Nothing
        cmbUnidades.EditValue = Nothing
        cmbEmbalaje.EditValue = Nothing
        txtCantidad.EditValue = Nothing
        txtDes.Text = Nothing
        txtDes2.Text = Nothing
    End Sub
    Private Sub Adapters()
        adp = New SqlDataAdapter("select * from IDF_Remisiones where RemisionID = " & ID, f.Conexion)
        adp.InsertCommand = f.getSQLComand("spIDF_RemisionesInsert")
        adp.InsertCommand.Parameters("@RemisionID").Direction = ParameterDirection.Output
        adp.UpdateCommand = f.getSQLComand("spIDF_RemisionesUpdate")
        adp.Fill(dt)

        adpDetalle = New SqlDataAdapter("spIDF_ProdxRemSelect " & ID, f.Conexion)
        adpDetalle.InsertCommand = f.getSQLComand("spIDF_ProdxRemInsert")
        adpDetalle.UpdateCommand = f.getSQLComand("spIDF_ProdxRemUpdate")
        adpDetalle.DeleteCommand = f.getSQLComand("spIDF_ProdxRemDelete")
        adpDetalle.Fill(dtDetalle)

        f.InitGridControl(gcDetalle, gvDetalle, dtDetalle, "", False)
    End Sub
    Private Sub Init()

        If dt.Rows.Count = 0 Then
            dt.Rows.Add()
        Else
            rbtMotivo.SelectedIndex = dt.Rows(0).Item("Motivo")
            dtpFecha.EditValue = dt.Rows(0).Item("Fecha")
            dtpInicio.EditValue = dt.Rows(0).Item("FechaInicio")
            dtpTerminacion.EditValue = dt.Rows(0).Item("FechaFinal")
        End If

        cmbTipoDoc.Properties.NullText = "Guía de Remisión"
        cmbCliente.EditValue = dt.Rows(0).Item("SdNCodigo").ToString
        cmbConductor.EditValue = dt.Rows(0).Item("ConductorID").ToString
        cmbTransportista.EditValue = dt.Rows(0).Item("TransportistaID").ToString
        txtOrdenPeso.Text = dt.Rows(0).Item("NumOrdenPesoBiosalc").ToString
        txtRemisionID.Text = dt.Rows(0).Item("RemisionID").ToString
        txtCai.Text = IIf(IsDBNull(dt.Rows(0).Item("CAI")), caiRemision, dt.Rows(0).Item("CAI"))
        txtNumeroRemision.Text = dt.Rows(0).Item("RemNum").ToString

        txtMarca.Text = dt.Rows(0).Item("Marca").ToString
        txtPlaca.Text = dt.Rows(0).Item("Placa").ToString
        txtLicencia.Text = dt.Rows(0).Item("Licencia").ToString
        txtIdentidad.Text = dt.Rows(0).Item("Identidad").ToString
        txtCabezal.Text = dt.Rows(0).Item("NumCabezal").ToString
        txtSello1.Text = dt.Rows(0).Item("Marchamo1").ToString
        txtSello2.Text = dt.Rows(0).Item("Marchamo2").ToString
        txtSello3.Text = dt.Rows(0).Item("Marchamo3").ToString
        txtSello4.Text = dt.Rows(0).Item("Marchamo4").ToString

        TxtOtroMotivo.Text = dt.Rows(0).Item("OtroMotivo").ToString
        txtPuntoPartida.Text = dt.Rows(0).Item("PuntoPartida").ToString
        txtPuntoDestino.Text = dt.Rows(0).Item("PuntoDestino").ToString


    End Sub
    Private Sub LoadTables()
        f.NewTable("select * from IDF_SdNs", "cliente")
        f.NewTable("select * from IDF_Conductores", "conductores")
        f.NewTable("select * from IDF_Transportistas", "transportistas")
        f.NewTable("select * from IDF_Productos", "productos")
        f.NewTable("select * from IDF_UnidMeds", "unidad")
    End Sub

    Private Sub TlSNotas_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles TlSNotas.ItemClicked

    End Sub

    Private Sub setCombos()
        f.SetGridLookUpEdit(cmbCliente, f.dsDesarrollo.Tables("cliente"), "TP", "Description")
        f.SetGridLookUpEdit(cmbConductor, f.dsDesarrollo.Tables("conductores"), "ConductorID", "Descripcion")
        f.SetGridLookUpEdit(cmbTransportista, f.dsDesarrollo.Tables("transportistas"), "TransportistaID", "Descripcion")
        f.SetGridLookUpEdit(cmbProductos, f.dsDesarrollo.Tables("productos"), "ProdCodigo", "Descripcion")
        f.SetGridLookUpEdit(cmbUnidades, f.dsDesarrollo.Tables("unidad"), "UnidMedCodigo", "Descripcion")
    End Sub
#End Region

End Class