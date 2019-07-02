Imports LibDAO001
Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class BprAgregadosBoletaCanaFrm
    Dim cCadena As String
    Dim BoletaID As String
    Dim QuemaID As String
    Dim Pochota, mensajes, strIdxMensaje As String
    Dim objConn As New SqlConnection

    Public Datos As ClsAPR = New ClsAPR()
    Public strUsuario, strPassword, temp As String

    Private Sub TxtBoletaID_Click(sender As Object, e As EventArgs) Handles TxtBoletaID.Click
        TxtBoletaID.SelectionStart = 0
        TxtBoletaID.SelectionLength = TxtBoletaID.Text.Length

    End Sub

    Private Sub TxtBoletaID_GotFocus(sender As Object, e As EventArgs) Handles TxtBoletaID.GotFocus
        TxtBoletaID.SelectionStart = 0
        TxtBoletaID.SelectionLength = TxtBoletaID.Text.Length
    End Sub

    Private Sub TextEdit1_LostFocus(sender As Object, e As EventArgs) Handles TxtBoletaID.LostFocus
        Try
        If Me.TxtBoletaID.Text.Length > 100 Then
            'Lectura vía escaneo
            cCadena = Me.TxtBoletaID.Text
            Me.TxtBoletaID.Text = Mid(cCadena, 12, 9)
            If Mid(Me.TxtBoletaID.Text, 9, 1) = "." Then
                Me.TxtBoletaID.Text = "0" + Mid(Me.TxtBoletaID.Text, 1, 8)
            End If

            Me.TxtQuemaID.Text = Mid(cCadena, 1, 10)

            Dim punto As String
            punto = Mid(cCadena, 137, 1)
            If punto.Equals(".") Then
                Me.TxtPochota.Text = Mid(cCadena, 138, 1)
            End If

            If ChkAutoSalvar.Checked Then
                BtnActualizar_Click(Nothing, System.EventArgs.Empty)
            End If

        Else
            'Lectura de datos ya existentes
            Dim sConnectionString As String = "User ID=" & Me.strUsuario & ";Password=" & strPassword & ";Initial Catalog=BasculaBoleta;Data Source=amigodb\amigodb"
            Dim objConn As New SqlConnection(sConnectionString)
            Dim Reader As SqlDataReader
            objConn.Open()

            Dim cSQL As String
            cSQL = "Select QuemaID, Bulteo From BoletaCana Where BoletaID = '" & Me.TxtBoletaID.Text & "'"
            Dim objCmd As New SqlCommand(cSQL, objConn)

            Reader = objCmd.ExecuteReader()

            If Reader.HasRows Then
                Reader.Read()
                Me.TxtQuemaID.Text = Reader.GetInt32(0)
                Me.TxtPochota.Text = Reader.GetInt32(1)
            Else
                Me.TxtBoletaID.Select()
                Me.TxtBoletaID_Click(Nothing, System.EventArgs.Empty)
            End If

            objConn.Close()

        End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error:")
            TxtQuemaID.Focus()
            TxtQuemaID.SelectAll()
        End Try
    End Sub

    Public Sub FuncionInicial(strU As String, strP As String)
        strUsuario = strU
        strPassword = strP
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Try
            Dim sConnectionString As String = "User ID=" & Me.strUsuario & ";Password=" & strPassword & ";Initial Catalog=BasculaBoleta;Data Source=amigodb\amigodb"
            Dim objConn As New SqlConnection(sConnectionString)
            objConn.Open()

            Me.BoletaID = Me.TxtBoletaID.Text
            Me.QuemaID = Me.TxtQuemaID.Text
            Me.Pochota = Me.TxtPochota.Text

            If Me.BoletaID.Length = 0 Or Me.QuemaID.Length = 0 Or Me.Pochota.Length = 0 Then
                objConn.Close()
                Exit Sub
            End If

            'mensajes = Datos.ActualizarBoletaCana(strUsuario, strPassword, 1, BoletaID, QuemaID, Pochota)
            'strIdxMensaje = mensajes.Substring(0, 1)
            'mensajes = mensajes.Replace(strIdxMensaje, "")
            'If strIdxMensaje.Equals("+") Then
            '    Me.Text = "Actualizado: " & Me.TxtBoletaID.Text
            '    BtnLimpiar_Click(Nothing, System.EventArgs.Empty)
            'End If

            Dim cSQL As String
            cSQL = "Update BoletaCana Set QuemaID = '" & Me.QuemaID & "', Bulteo = '" & Me.Pochota & "' From BoletaCana Where BoletaID = '" & Me.BoletaID & "'"
            Dim objCmd As New SqlCommand(cSQL, objConn)

            objCmd.ExecuteNonQuery()
            objConn.Close()
            Me.Text = "Actualizado: " & Me.TxtBoletaID.Text
            BtnLimpiar_Click(Nothing, System.EventArgs.Empty)
        Catch ex As Exception
            MsgBox(mensajes & " " & ex.Message, MsgBoxStyle.Critical, "Mensaje:")
        End Try
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Me.TxtBoletaID.Text = ""
        Me.TxtQuemaID.Text = ""
        Me.TxtPochota.Text = ""
        Me.TxtBoletaID.Select()
    End Sub
End Class