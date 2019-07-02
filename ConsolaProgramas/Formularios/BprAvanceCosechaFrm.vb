Imports LibDAO001
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Globalization
Public Class BprAvanceCosechaFrm

    Public apr As ClsAPR = New ClsAPR()
    Public EntiAPR As ClsEntiAPR.ClsAprGenerarOdtQuema = New ClsEntiAPR.ClsAprGenerarOdtQuema()
    Public strUsuario, strPassword, strSitio, strFinca, strArea, strLoteID, strFecha, strHora, strMensaje, strIdxMensaje, FechaHoy As String
    Public idxPeriodo, flagTipoCaña, flagAccidental, flagDoble, intPeriodoId, FrenteID, flagCargar, valor As Integer
    Public flagGuardarModificar As Boolean

    Public Sub FuncionInicial(strU As String, strP As String)
        strUsuario = strU
        strPassword = strP
    End Sub

    Private Sub cmbSalir_Click(sender As Object, e As EventArgs) Handles cmbSalir.Click
        Close()
    End Sub

    Private Sub BprAvanceCosechaFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SpinVisualizacion.Value = 15
        'Dim fecha As String
        FechaHoy = Date.Now.Day.ToString & "/" & Date.Now.Month.ToString() & "/" & Date.Now.Year.ToString()
        gbxDatosMolienda.Text = "Datos de Molienda de fecha actual: " & FechaHoy & " - Sistema de Bascula CAHSA"
        CargarMolienda()
    End Sub

    Public Sub CargarMolienda()
        'Obtener datos de la Molienda
        Dim dtMolienda As DataTable = New DataTable()
        Dim ci As New CultureInfo("en-us")
        dtMolienda = apr.ObtenerMoliendaCaña(strUsuario, strPassword, 1, "GETDATE()")
        If dtMolienda.Rows.Count > 0 Then
            'txtAcumuladoDiario.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", dtMolienda.Rows(0)(0).ToString())
            'txtProyeccionDiaria.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", dtMolienda.Rows(0)(1).ToString())
            'txtTonsFecha.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", dtMolienda.Rows(0)(2).ToString())
            Dim ad, pd, tf As Decimal

            If dtMolienda.Rows(0)(0).ToString().Length = 0 Then
                ad = 0
            Else
                ad = Convert.ToDouble(dtMolienda.Rows(0)(0))
            End If

            If dtMolienda.Rows(0)(1).ToString().Length = 0 Then
                pd = 0
            Else
                pd = Convert.ToDouble(dtMolienda.Rows(0)(1))
            End If

            If dtMolienda.Rows(0)(2).ToString().Length = 0 Then
                tf = 0
            Else
                tf = Convert.ToDouble(dtMolienda.Rows(0)(2))
            End If
            txtAcumuladoDiario.Text = FormatNumber(ad, 2, , , TriState.True)
            txtProyeccionDiaria.Text = FormatNumber(pd, 2, , , TriState.True)
            txtTonsFecha.Text = FormatNumber(tf, 2, , , TriState.True)
        Else
            MsgBox("Error: no existen datos de Molienda.", MsgBoxStyle.Critical, "Sistema:")
        End If
    End Sub

    Public Sub CargarDatos(tipo As Integer)
        Try
            Dim ds As DataSet
        Timer1.Enabled = False
        If tipo = 1 Then 'Obtener Periodos
            ds = apr.ObtenerPeriodo(strUsuario, strPassword, 1)
            cbxPeriodo.DataSource = ds.Tables(0)
            cbxPeriodo.DisplayMember = "titulo"
            cbxPeriodo.ValueMember = "sitio"
        End If
        If tipo = 2 Then
            Dim dsDatos2 As DataSet = New DataSet()
            Dim dtMaestro2 As DataTable = New DataTable()
            Dim dtDetalle2 As DataTable = New DataTable()
            'Tipo cnx #2 = AmigoDBPruebas -- Pendiente cambiar a conexion servidor amigodb - Ing. Manuel Ortega - 06/01/2015
            strFecha = txtFecha.EditValue
                dtMaestro2 = apr.ObtenerAvanceCosecha(strUsuario, strPassword, 4, intPeriodoId, strFecha).Tables(0)
            'El numero 3 representa, el detalle del maestro
            dtDetalle2 = apr.ObtenerAvanceCosecha(strUsuario, strPassword, 3, 0, "").Tables(0)

            'Adicionar el maestro al dataset principal
            dsDatos2.Tables.Add(dtMaestro2.Copy)
            'Adicionar el detalle al dataset principal
            dsDatos2.Tables.Add(dtDetalle2.Copy)

            'Relacionar tabla maestra con detalle en el DataSet
            dsDatos2.Relations.Add("Detalle", dsDatos2.Tables("VW_CANAAVANCECOS").Columns("OrdenCorte"), _
                                             dsDatos2.Tables("VW_CANAAVANCECOSDETALLE").Columns("OrdenCorte"), False)
            'dsDatos2 = apr.ObtenerAvanceCosecha(strUsuario, strPassword, 2, intPeriodoId, strFecha)
            GridControl1.DataSource = dsDatos2.Tables(0)
            ExpandAllRows()
            Timer1.Enabled = True
        End If
        If tipo = 3 Then
            Dim dsDatos3 As DataSet = New DataSet()
            Dim dtMaestro As DataTable = New DataTable()
            Dim dtDetalle As DataTable = New DataTable()
            'Tipo cnx #2 = AmigoDBPruebas -- Pendiente cambiar a conexion servidor amigodb - Ing. Manuel Ortega - 06/01/2015
            strFecha = txtFecha.EditValue
                dtMaestro = apr.ObtenerAvanceCosecha(strUsuario, strPassword, 4, intPeriodoId, strFecha).Tables(0)
            'El numero 3 representa, el detalle del maestro
            dtDetalle = apr.ObtenerAvanceCosecha(strUsuario, strPassword, 3, 0, "").Tables(0)

            'Adicionar el maestro al dataset principal
            dsDatos3.Tables.Add(dtMaestro.Copy)
            'Adicionar el detalle al dataset principal
            dsDatos3.Tables.Add(dtDetalle.Copy)

            'Relacionar tabla maestra con detalle en el DataSet
            dsDatos3.Relations.Add("Detalle", dsDatos3.Tables("VW_CANAAVANCECOS").Columns("OrdenCorte"), _
                                             dsDatos3.Tables("VW_CANAAVANCECOSDETALLE").Columns("OrdenCorte"), False)
            GridControl1.DataSource = dsDatos3.Tables(0)
            ExpandAllRows()
            Timer1.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Error al generar el reporte: Excepcion controlada - " & ex.Message, MsgBoxStyle.Critical, "Sistema:")
        End Try
    End Sub

    Public Sub ExpandAllRows()
        dgvDatos.BeginUpdate()
        Try
            Dim dataRowCount As Integer = dgvDatos.DataRowCount
            Dim rHandle As Integer
            For rHandle = 0 To dataRowCount - 1
                dgvDatos.SetMasterRowExpanded(rHandle, True)
            Next
        Finally
            dgvDatos.EndUpdate()
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'MsgBox(Timer1.Interval.ToString(), MsgBoxStyle.Information, "Mensaje:")
        CargarDatos(2)
        CargarMolienda()
    End Sub

    Private Sub cmbFrecuencia_Click(sender As Object, e As EventArgs) Handles cmbFrecuencia.Click
        valor = Convert.ToInt32(SpinVisualizacion.Value)
        If valor > 0 Then
            Me.Timer1.Interval = (valor) * 60000
            Timer1.Enabled = True
            'SplitControl.SplitterPosition = 2
        End If
    End Sub

    Private Sub cbxPeriodo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxPeriodo.SelectedIndexChanged
        Try
            strSitio = cbxPeriodo.SelectedValue.ToString()
            If (strSitio.Equals("System.Data.DataRowView") = False) Then
                Dim TestArray() As String = Split(strSitio)
                intPeriodoId = CInt(TestArray(0))
                strSitio = TestArray(1)
                'CargarDatos(2)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbRefrescar_Click(sender As Object, e As EventArgs) Handles cmbRefrescar.Click
        CargarMolienda()
        CargarDatos(3)
    End Sub

    'Private Sub trackBar_EditValueChanged(sender As Object, e As EventArgs) Handles trackBar.EditValueChanged
    '    If Me.valor = 0 Then
    '        Me.valor = 1
    '    End If
    '    Me.Timer1.Interval = (1 + Me.valor) * 60000
    'End Sub

    Private Sub cmbCambiarFecha_Click(sender As Object, e As EventArgs) Handles cmbCambiarFecha.Click
        'SplitControl.SplitterPosition = 96
    End Sub


    Private Sub dgvDatos_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles dgvDatos.RowCellStyle
        Dim View As GridView = sender
        If e.Column.FieldName = "NumPorcAvance" Then
            Dim inactivo As String = View.GetRowCellValue(e.RowHandle, gcolInactividad)
            Dim zero As String = View.GetRowCellValue(e.RowHandle, gcolNumPorAvance)
            If inactivo = "-1" Then 'Rojo
                'e.Appearance.BackColor = Color.Red
                e.Appearance.ForeColor = Color.Red
            End If

            If inactivo = "1" Then 'Verde
                'e.Appearance.BackColor = Color.Green
                e.Appearance.ForeColor = Color.Green
            End If

            If inactivo = "2" Then 'Amarillo
                'e.Appearance.BackColor = Color.LightYellow
                e.Appearance.ForeColor = Color.Orange
            End If

            If inactivo = "0" Then 'Azul
                'e.Appearance.BackColor = Color.LightYellow
                If zero.Equals("0%") Then
                    e.Appearance.ForeColor = Color.Black
                Else
                    e.Appearance.ForeColor = Color.Blue
                End If
            End If
        End If
    End Sub

    Private Sub cmbImprimir_Click(sender As Object, e As EventArgs) Handles cmbImprimir.Click
        dgvDatos.ShowPrintPreview()
    End Sub

    Private Sub dgvDatos_CustomDrawCell(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles dgvDatos.CustomDrawCell
        Dim view As GridView = TryCast(sender, GridView)
        Dim r As Rectangle = e.Bounds
        If e.Column.FieldName = "PorcAvance" Then
        Dim v As Integer = Convert.ToInt32(e.CellValue)
        v = v * e.Bounds.Width / 100
        Dim h As Integer = e.Bounds.Height
            Dim rect As Rectangle = New Rectangle(e.Bounds.X, e.Bounds.Y, v, 40)
        Dim inactivo As String = view.GetRowCellValue(e.RowHandle, gcolInactividad)
        If inactivo = "-1" Then 'Rojo
            e.Graphics.FillRectangle(Brushes.Red, rect)
        End If

        If inactivo = "1" Then 'Verde
            e.Graphics.FillRectangle(Brushes.Green, rect)
        End If

        If inactivo = "2" Then 'Amarillo
            e.Graphics.FillRectangle(Brushes.Yellow, rect)
        End If

            If inactivo = "0" Then 'Azul
                e.Graphics.FillRectangle(Brushes.Blue, rect)
            End If

        ''If (v > 80) Then
        ''    e.Graphics.FillRectangle(Brushes.Red, rect)
        ''Else
        ''    e.Graphics.FillRectangle(Brushes.Green, rect)
        ''End If
        'e.Handled = True
            e.Handled = True
        End If

    End Sub

End Class