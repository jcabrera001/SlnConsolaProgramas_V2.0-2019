'------------------------------------------------------------------------------
' Clase IDF_Empresas generada automáticamente con CrearClaseSQL
' de la tabla 'TmpDatos' de la base 'Finanzas'
' Fecha: 24/Mar/2015 07:58:04
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
Public Class IDF_Empresas
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _TP As System.String
    Private _Description As System.String
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
    '
    Public Default Property Item(index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.TP.ToString()
            ElseIf index = 1 Then
                Return Me.Description.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = 0 Then
                Me.TP = value
            ElseIf index = 1 Then
                Me.Description = value
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
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = "TP" Then
                Me.TP = value
            ElseIf index = "Description" Then
                Me.Description = value
            End If
        End Set
    End Property
    '
    ' Campos y métodos compartidos (estáticos) para gestionar la base de datos
    '
    ' La cadena de conexión a la base de datos
    Private Shared cadenaConexion As String = ""
    ' La cadena de selección
    Public Shared CadenaSelect As String = "SELECT * FROM IDF_Empresas"
    '
    Public Sub New()
    End Sub
    Public Sub New(conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto IDF_Empresas
    Private Shared Function row2IDF_Empresas(r As DataRow) As IDF_Empresas
        ' asigna a un objeto IDF_Empresas los datos del dataRow indicado
        Dim oIDF_Empresas As New IDF_Empresas
        '
        oIDF_Empresas.TP = r("TP").ToString()
        oIDF_Empresas.Description = r("Description").ToString()
        '
        Return oIDF_Empresas
    End Function
    '
    ' asigna un objeto IDF_Empresas a la fila indicada
    Private Shared Sub IDF_Empresas2Row(oIDF_Empresas As IDF_Empresas, r As DataRow)
        ' asigna un objeto IDF_Empresas al dataRow indicado
        r("TP") = oIDF_Empresas.TP
        r("Description") = oIDF_Empresas.Description
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
        Dim dt As New DataTable("IDF_Empresas")
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
    Public Shared Function Buscar(sWhere As String) As IDF_Empresas
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oIDF_Empresas As IDF_Empresas = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_Empresas")
        Dim sel As String = "SELECT * FROM IDF_Empresas WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oIDF_Empresas = row2IDF_Empresas(dt.Rows(0))
        End If
        Return oIDF_Empresas
    End Function

End Class
