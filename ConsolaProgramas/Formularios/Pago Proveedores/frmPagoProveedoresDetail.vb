Imports System.Data.SqlClient
Imports System.Net
Imports System.IO
Imports System.Text
Imports ConsolaProgramasCS

Public Class frmPagoProveedoresDetail

    Private cnx As SqlConnection
    Private Usuario As String
    Private ID As Integer
    Dim f As New Funciones
    Dim FileName, root, RutaFinal As String
    Dim File As String = ""

    Dim dtResult, dtPlan As DataTable
    Dim dtPrincipal, dt As New DataTable
    Dim adpPrincipal, adp As SqlDataAdapter


    Public Sub New(cnx As SqlConnection, Usuario As String, ID As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.cnx = cnx
        Me.ID = ID
        Me.Usuario = Usuario
        f.Conexion = cnx

    End Sub
    Private Sub frmPagoProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        adpPrincipal = New SqlDataAdapter("select * from TOLPago where TOLPagoID = " & ID, cnx)
        adpPrincipal.InsertCommand = f.getSQLComand("spTOLPagoInsert")

        adpPrincipal.Fill(dtPrincipal)

        If dtPrincipal.Rows.Count = 0 Then
            dtPrincipal.Rows.Add()
            txtUsuario.Text = Usuario
            dtpFecha.EditValue = Now()
        Else
            'Mostrar los que fueron pagados en este movimiento
            adp = New SqlDataAdapter("spTolPagoDetSelect " & ID, cnx)
            adp.Fill(dt)
            f.InitGridControl(gc, gv, dt, "", True)

            dtpFecha.EditValue = dtPrincipal.DefaultView.Item(0).Item("Fecha").ToString()
            txtUsuario.Text = dtPrincipal.DefaultView.Item(0).Item("Usuario").ToString()
        End If

        If ID > 0 Then
            btnEnviar.Enabled = False
            btnPago.Enabled = False
            dtpDesde.ReadOnly = True
            dtpHasta.ReadOnly = True
            btnBuscar.Enabled = False
        End If
    End Sub



    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        adp = New SqlDataAdapter("spTransaccionesSelect", cnx)
        adp.SelectCommand.CommandType = CommandType.StoredProcedure
        adp.SelectCommand.Parameters.AddWithValue("@des", dtpDesde.EditValue)
        adp.SelectCommand.Parameters.AddWithValue("@has", dtpHasta.EditValue)

        dt.Clear()
        adp.Fill(dt)
        f.InitGridControl(gc, gv, dt, "", True)

        If dt.Rows.Count > 0 Then
            btnPago.Enabled = True
        End If

    End Sub

    Private Sub btnPago_Click(sender As Object, e As EventArgs) Handles btnPago.Click
        Dim Obj As Object
        Dim Archivo As Object
        Dim valor As String = ""

        Dim nPlan As Integer

        Try

            'Obtener el número de plan y código del Banco
            dtPlan = f.getDataTable("Select NombreArchivo, RutaArchivo, NumeroPlan from TOLBancos where ID = 3")
            nPlan = dtPlan.DefaultView.Item(0).Item("NumeroPlan")

            'Creación del archivo
            root = dtPlan.DefaultView.Item(0).Item("RutaArchivo").ToString() 'Ruta del archivo
            FileName = dtPlan.DefaultView.Item(0).Item("NombreArchivo").ToString() & Date.Now.ToString() & ".txt" 'Nombre del archivo
            FileName = Replace(Replace(Replace(FileName, " ", ""), "/", ""), ":", "")
            RutaFinal = root + FileName

            Obj = CreateObject("Scripting.FileSystemObject")
            Archivo = Obj.CreateTextFile(RutaFinal, True)

            'Obtener todas las transacciones a generar.
            For i As Integer = 0 To dt.Rows.Count - 1
                If dt.DefaultView.Item(i).Item("Selector") Then
                    valor += dt.DefaultView.Item(i).Item("Numero") + ","
                End If
            Next

            'Procedimiento que regresa en filas la estructura del archivo
            dtResult = f.getDataTable("spPagoProveedores '" & valor & "', " & nPlan)

            For Each row As DataRow In dtResult.Rows
                Archivo.WriteLine(row.Item("Row")) 'Ingresa la linea en el Archivo
            Next

            'Insert a las tablas de Bítacora. TOLPago, TOlPagoDet
            dtPrincipal.DefaultView.Item(0).Item("Usuario") = Usuario
            dtPrincipal.DefaultView.Item(0).Item("Fecha") = dtpFecha.EditValue
            dtPrincipal.DefaultView.Item(0).Item("Ruta") = RutaFinal
            dtPrincipal.DefaultView.Item(0).Item("NumeroPlan") = nPlan
            dtPrincipal.DefaultView.Item(0).Item("Comentarios") = valor  'Listado de números
            adpPrincipal.Update(dtPrincipal)

            ' ***************************************************************************** '

            MsgBox("Archivo creado exitosamente!", MsgBoxStyle.Information, "Pago Proveedores")
            btnPago.Enabled = False
            btnEnviar.Enabled = True
            Archivo.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Close()
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim cs As New H2H_BAC()

        Try
            'cs.UploadFTP("ftp://ftp.dlptest.com/done/", FileName, "dlpuser@dlptest.com", "SzMf7rTE4pCrf9dV286GuNe4N", RutaFinal)
            cs.connectSftpServer("h2h.credomatic.com", 222, "H2H_CAHSAHND_HN", "Hkvjrfa7", 50000)
            cs.uploadFile(RutaFinal, "/in/ppp/" & FileName & "/", True)

            If cs.getErrorDes.Length > 0 Then
                MsgBox(cs.getErrorDes, MsgBoxStyle.Critical, "Error al momento de enviar Archivo")
                Exit Sub
            End If

            MsgBox("Archivo enviado exitosamente!", MsgBoxStyle.Information, "Pago Proveedores")

            Close()
        Catch ex As Exception
            MsgBox(cs.getErrorDes + vbNewLine + ex.Message, MsgBoxStyle.Critical, "Error al momento de enviar Archivo")
        End Try

    End Sub
End Class