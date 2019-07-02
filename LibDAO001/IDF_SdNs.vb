'------------------------------------------------------------------------------
' Clase IDF_SdNs generada automáticamente con CrearClaseSQL
' de la tabla 'IDF_ItemsxDF' de la base 'Finanzas'
' Fecha: 20/May/2015 08:34:22
'
' ©Guillermo 'guille' Som, 2004-2015
'------------------------------------------------------------------------------
Option Strict On
Option Explicit On
'
Imports System
Imports System.Data
Imports System.Data.SqlClient
'
Public Class IDF_SdNs
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _TP As System.String
    Private _Description As System.String
    Private _KnownAsName As System.String
    Private _Tipo As System.String
    '
    ' Este método se usará para ajustar los anchos de las propiedades
    Private Function ajustarAncho(cadena As String, ancho As Integer) As String
        Dim sb As New System.Text.StringBuilder(New String(" "c, ancho))
        ' devolver la cadena quitando los espacios en blanco
        ' esto asegura que no se devolverá un tamaño mayor ni espacios "extras"
        Return (cadena & sb.ToString()).Substring(0, ancho).Trim()
    End Function
    '
    ' Las propiedades públicas
    ' TODO: Revisar los tipos de las propiedades
    Public Property TP() As System.String
        Get
            Return ajustarAncho(_TP,30)
        End Get
        Set(value As System.String)
            _TP = value
        End Set
    End Property
    Public Property Description() As System.String
        Get
            Return ajustarAncho(_Description,60)
        End Get
        Set(value As System.String)
            _Description = value
        End Set
    End Property
    Public Property KnownAsName() As System.String
        Get
            Return ajustarAncho(_KnownAsName,30)
        End Get
        Set(value As System.String)
            _KnownAsName = value
        End Set
    End Property
    Public Property Tipo() As System.String
        Get
            Return ajustarAncho(_Tipo,20)
        End Get
        Set(value As System.String)
            _Tipo = value
        End Set
    End Property
    '
    Public Default Property Item(index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.TP.ToString()
            ElseIf index = 1 Then
                Return Me.Description.ToString()
            ElseIf index = 2 Then
                Return Me.KnownAsName.ToString()
            ElseIf index = 3 Then
                Return Me.Tipo.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = 0 Then
                Me.TP = value
            ElseIf index = 1 Then
                Me.Description = value
            ElseIf index = 2 Then
                Me.KnownAsName = value
            ElseIf index = 3 Then
                Me.Tipo = value
            End If
        End Set
    End Property
    Public Default Property Item(index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde al nombre de la columna)
        Get
            If index = "TP" Then
                Return Me.TP.ToString()
            ElseIf index = "Description" Then
                Return Me.Description.ToString()
            ElseIf index = "KnownAsName" Then
                Return Me.KnownAsName.ToString()
            ElseIf index = "Tipo" Then
                Return Me.Tipo.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = "TP" Then
                Me.TP = value
            ElseIf index = "Description" Then
                Me.Description = value
            ElseIf index = "KnownAsName" Then
                Me.KnownAsName = value
            ElseIf index = "Tipo" Then
                Me.Tipo = value
            End If
        End Set
    End Property
    '
    ' Campos y métodos compartidos (estáticos) para gestionar la base de datos
    '
    ' La cadena de conexión a la base de datos
    Private Shared cadenaConexion As String = ""
    ' La cadena de selección
    Public Shared CadenaSelect As String = "SELECT * FROM IDF_SdNs"
    '
    Public Sub New()
    End Sub
    Public Sub New(conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto IDF_SdNs
    Private Shared Function row2IDF_SdNs(r As DataRow) As IDF_SdNs
        ' asigna a un objeto IDF_SdNs los datos del dataRow indicado
        Dim oIDF_SdNs As New IDF_SdNs
        '
        oIDF_SdNs.TP = r("TP").ToString()
        oIDF_SdNs.Description = r("Description").ToString()
        oIDF_SdNs.KnownAsName = r("KnownAsName").ToString()
        oIDF_SdNs.Tipo = r("Tipo").ToString()
        '
        Return oIDF_SdNs
    End Function
    '
    ' asigna un objeto IDF_SdNs a la fila indicada
    Private Shared Sub IDF_SdNs2Row(oIDF_SdNs As IDF_SdNs, r As DataRow)
        ' asigna un objeto IDF_SdNs al dataRow indicado
        r("TP") = oIDF_SdNs.TP
        r("Description") = oIDF_SdNs.Description
        r("KnownAsName") = oIDF_SdNs.KnownAsName
        r("Tipo") = oIDF_SdNs.Tipo
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto IDF_SdNs
    Private Shared Sub nuevoIDF_SdNs(dt As DataTable, oIDF_SdNs As IDF_SdNs)
        ' Crear un nuevo IDF_SdNs
        Dim dr As DataRow = dt.NewRow()
        Dim oI As IDF_SdNs = row2IDF_SdNs(dr)
        '
        oI.TP = oIDF_SdNs.TP
        oI.Description = oIDF_SdNs.Description
        oI.KnownAsName = oIDF_SdNs.KnownAsName
        oI.Tipo = oIDF_SdNs.Tipo
        '
        IDF_SdNs2Row(oI, dr)
        '
        dt.Rows.Add(dr)
    End Sub
    '
    ' Métodos públicos
    '
    ' devuelve una tabla con los datos indicados en la cadena de selección
    Public Shared Function Tabla() As DataTable
        Return Tabla(CadenaSelect)
    End Function
    Public Shared Function Tabla(sel As String) As DataTable
        ' devuelve una tabla con los datos de la tabla IDF_ItemsxDF
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_SdNs")
        '
        Try
            da = New SqlDataAdapter(sel, cadenaConexion)
            da.Fill(dt)
        Catch
            Return Nothing
        End Try
        '
        Return dt
    End Function
    '
    Public Shared Function Buscar(sWhere As String) As IDF_SdNs
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oIDF_SdNs As IDF_SdNs = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_SdNs")
        Dim sel As String = "SELECT * FROM IDF_SdNs WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oIDF_SdNs = row2IDF_SdNs(dt.Rows(0))
        End If
        Return oIDF_SdNs
    End Function
End Class
