Imports LibDAO001
Public Class BprAvanceCosechaDetalle

    Public apr As ClsAPR = New ClsAPR()
    Public EntiAPR As ClsEntiAPR.ClsAprGenerarOdtQuema = New ClsEntiAPR.ClsAprGenerarOdtQuema()
    Public strUsuario, strPassword, strSitio, strFinca, strArea, strLoteID, strFecha, strHora, strMensaje, strIdxMensaje, FechaHoy As String
    Public idxPeriodo, flagTipoCaña, flagAccidental, flagDoble, intPeriodoId, FrenteID, flagCargar, valor As Integer
    Public flagGuardarModificar As Boolean

    Public Sub FuncionInicial(strU As String, strP As String)
        strUsuario = strU
        strPassword = strP
    End Sub
    Private Sub BprAvanceCosechaDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SpinEdit1.Value = 15
    End Sub
    Private Sub cmbSalir_Click(sender As Object, e As EventArgs) Handles cmbSalir.Click
        Close()
    End Sub

    Public Sub CargarDatos(tipo As Integer)
        Dim ds As DataSet
        Timer1.Enabled = False
        If tipo = 1 Then 'Obtener Periodos
            ds = apr.ObtenerPeriodo(strUsuario, strPassword, 1)
            cbxPeriodo.DataSource = ds.Tables(0)
            cbxPeriodo.DisplayMember = "titulo"
            cbxPeriodo.ValueMember = "sitio"
        End If
        If tipo = 2 Then
            Dim dsDatos As DataSet = New DataSet()
            'Tipo cnx #2 = AmigoDBPruebas -- Pendiente cambiar a conexion servidor amigodb - Ing. Manuel Ortega - 06/01/2015
            strFecha = txtFecha.EditValue
            dsDatos = apr.ObtenerAvanceCosecha(strUsuario, strPassword, 2, intPeriodoId, strFecha)
            GridControl1.DataSource = dsDatos.Tables(0)
            Timer1.Enabled = True
        End If
        If tipo = 3 Then
            Dim dsDatos As DataSet = New DataSet()
            'Tipo cnx #2 = AmigoDBPruebas -- Pendiente cambiar a conexion servidor amigodb - Ing. Manuel Ortega - 06/01/2015
            strFecha = txtFecha.EditValue
            dsDatos = apr.ObtenerAvanceCosecha(strUsuario, strPassword, 2, intPeriodoId, strFecha)
            GridControl1.DataSource = dsDatos.Tables(0)
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'MsgBox(Timer1.Interval.ToString(), MsgBoxStyle.Information, "Mensaje:")
        CargarDatos(2)
    End Sub

    Private Sub cmbFrecuencia_Click(sender As Object, e As EventArgs) Handles cmbFrecuencia.Click
        Timer1.Enabled = True
        SplitControl.SplitterPosition = 2
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
        CargarDatos(3)
    End Sub

    Private Sub trackBar_EditValueChanged(sender As Object, e As EventArgs) Handles trackBar.EditValueChanged
        If Me.valor = 0 Then
            Me.valor = 1
        End If
        Me.Timer1.Interval = (1 + Me.valor) * 60000
    End Sub

    Private Sub cmbCambiarFecha_Click(sender As Object, e As EventArgs) Handles cmbCambiarFecha.Click
        SplitControl.SplitterPosition = 96
    End Sub

    Private Sub cmbImprimir_Click(sender As Object, e As EventArgs) Handles cmbImprimir.Click
        dgvDatos.Print()
    End Sub
End Class