'------------------------------------------------------------------------------
' Clase IDF_Clientes generada automáticamente con CrearClaseSQL
' de la tabla 'TmpDatos' de la base 'Finanzas'
' Fecha: 24/Mar/2015 10:04:58
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
Public Class IDF_Clientes
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
            Return ajustarAncho(_Description,30)
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
            Return ajustarAncho(_Tipo, 30)
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
    Public Shared CadenaSelect As String = "SELECT * FROM IDF_SdNs "
    '
    Public Sub New()
    End Sub
    Public Sub New(conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto IDF_Clientes
    Private Shared Function row2IDF_Clientes(r As DataRow) As IDF_Clientes
        ' asigna a un objeto IDF_Clientes los datos del dataRow indicado
        Dim oIDF_Clientes As New IDF_Clientes
        '
        oIDF_Clientes.TP = r("TP").ToString()
        oIDF_Clientes.Description = r("Description").ToString()
        oIDF_Clientes.KnownAsName = r("KnownAsName").ToString()
        '
        Return oIDF_Clientes
    End Function
    '
    ' asigna un objeto IDF_Clientes a la fila indicada
    Private Shared Sub IDF_Clientes2Row(oIDF_Clientes As IDF_Clientes, r As DataRow)
        ' asigna un objeto IDF_Clientes al dataRow indicado
        r("TP") = oIDF_Clientes.TP
        r("Description") = oIDF_Clientes.Description
        r("KnownAsName") = oIDF_Clientes.KnownAsName
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto IDF_Clientes
    Private Shared Sub nuevoIDF_Clientes(dt As DataTable, oIDF_Clientes As IDF_Clientes)
        ' Crear un nuevo IDF_Clientes
        Dim dr As DataRow = dt.NewRow()
        Dim oI As IDF_Clientes = row2IDF_Clientes(dr)
        '
        oI.TP = oIDF_Clientes.TP
        oI.Description = oIDF_Clientes.Description
        oI.KnownAsName = oIDF_Clientes.KnownAsName
        '
        IDF_Clientes2Row(oI, dr)
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
        ' devuelve una tabla con los datos de la tabla TmpDatos
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
    Public Shared Function Buscar(sWhere As String) As IDF_Clientes
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oIDF_Clientes As IDF_Clientes = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_SdNs")
        Dim sel As String = "SELECT * FROM IDF_SdNs WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oIDF_Clientes = row2IDF_Clientes(dt.Rows(0))
        End If
        Return oIDF_Clientes
    End Function

End Class
