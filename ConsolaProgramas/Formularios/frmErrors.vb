Public Class frmErrors
    Dim Valido As Boolean = True
    Private _isOk As Boolean = False

    Public ReadOnly Property Errores As Integer
        Get
            Return lvErrores.Items.Count
        End Get
    End Property

    Public ReadOnly Property isOk As Boolean
        Get
            Return _isOk
        End Get
    End Property
    Public Sub NuevoError(Mensaje As String, Tipo As Integer)
        If Tipo = 0 Then
            lvErrores.Items.Add("  " & Mensaje, 0)
            Valido = False
        Else
            lvErrores.Items.Add("  " & Mensaje, 1)
        End If
    End Sub
    Private Sub frmErrors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Valido Then
            cmdAceptar.Visible = True
        Else
            cmdAceptar.Visible = False
        End If
    End Sub
    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        lvErrores.Clear()
        Valido = True
        Close()
    End Sub

    'Private Sub frmErrors_FormClosing(sender As Object, e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
    '    lvErrores.Clear()
    '    Valido = True
    'End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        _isOk = True
        Close()
    End Sub
End Class