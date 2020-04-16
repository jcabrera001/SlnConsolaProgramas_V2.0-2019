Module mdVariablesGlobales
    Public caiFactura As String = Nothing
    Public caiRemision As String = Nothing
    Public caiBolVenta As String = Nothing
    Public caiBolCompra As String = Nothing
    Public empresa As String = Nothing
    Public user As String = Nothing
    Public pwd As String = Nothing


    Public Sub CleanVariables()
        caiFactura = Nothing
        caiRemision = Nothing
        caiBolCompra = Nothing
        caiBolVenta = Nothing
        user = Nothing
        pwd = Nothing
        empresa = Nothing
    End Sub
End Module
