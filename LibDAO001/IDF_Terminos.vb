'------------------------------------------------------------------------------
' Clase IDF_Terminos generada automáticamente con CrearClaseSQL
' de la tabla 'TmpDatos' de la base 'Finanzas'
' Fecha: 24/Mar/2015 10:08:57
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
Public Class IDF_Terminos
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _PayTerms As System.String
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
    Public Property PayTerms() As System.String
        Get
            Return ajustarAncho(_PayTerms,40)
        End Get
        Set(value As System.String)
            _PayTerms = value
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
                Return Me.PayTerms.ToString()
            ElseIf index = 1 Then
                Return Me.Description.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = 0 Then
                Me.PayTerms = value
            ElseIf index = 1 Then
                Me.Description = value
            End If
        End Set
    End Property
    Public Default Property Item(index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde al nombre de la columna)
        Get
            If index = "PayTerms" Then
                Return Me.PayTerms.ToString()
            ElseIf index = "Description" Then
                Return Me.Description.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = "PayTerms" Then
                Me.PayTerms = value
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
    Public Shared CadenaSelect As String = "SELECT * FROM IDF_Terminos"
    '
    Public Sub New()
    End Sub
    Public Sub New(conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto IDF_Terminos
    Private Shared Function row2IDF_Terminos(r As DataRow) As IDF_Terminos
        ' asigna a un objeto IDF_Terminos los datos del dataRow indicado
        Dim oIDF_Terminos As New IDF_Terminos
        '
        oIDF_Terminos.PayTerms = r("PayTerms").ToString()
        oIDF_Terminos.Description = r("Description").ToString()
        '
        Return oIDF_Terminos
    End Function
    '
    ' asigna un objeto IDF_Terminos a la fila indicada
    Private Shared Sub IDF_Terminos2Row(oIDF_Terminos As IDF_Terminos, r As DataRow)
        ' asigna un objeto IDF_Terminos al dataRow indicado
        r("PayTerms") = oIDF_Terminos.PayTerms
        r("Description") = oIDF_Terminos.Description
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto IDF_Terminos
    Private Shared Sub nuevoIDF_Terminos(dt As DataTable, oIDF_Terminos As IDF_Terminos)
        ' Crear un nuevo IDF_Terminos
        Dim dr As DataRow = dt.NewRow()
        Dim oI As IDF_Terminos = row2IDF_Terminos(dr)
        '
        oI.PayTerms = oIDF_Terminos.PayTerms
        oI.Description = oIDF_Terminos.Description
        '
        IDF_Terminos2Row(oI, dr)
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
        Dim dt As New DataTable("IDF_Terminos")
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
    Public Shared Function Buscar(sWhere As String) As IDF_Terminos
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oIDF_Terminos As IDF_Terminos = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_Terminos")
        Dim sel As String = "SELECT * FROM IDF_Terminos WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oIDF_Terminos = row2IDF_Terminos(dt.Rows(0))
        End If
        Return oIDF_Terminos
    End Function
End Class
