Public Class GenSplashFrm
    Sub New
        InitializeComponent()
    End Sub

    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
    End Sub

    Public Enum SplashScreenCommand
        SomeCommandId
    End Enum

    Private Sub GenSplashFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCopy.Text = "Copyright © 2013-" & Date.Now.Year.ToString()
    End Sub
End Class
