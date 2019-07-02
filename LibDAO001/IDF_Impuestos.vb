'------------------------------------------------------------------------------
' Clase IDF_Impuestos generada automáticamente con CrearClaseSQL
' de la tabla 'TmpDatos' de la base 'Finanzas'
' Fecha: 25/Mar/2015 07:35:37
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
Public Class IDF_Impuestos
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _TaxCat As System.String
    Private _Description As System.String
    Private _Percentage As System.Double
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
    Public Property TaxCat() As System.String
        Get
            Return ajustarAncho(_TaxCat,30)
        End Get
        Set(value As System.String)
            _TaxCat = value
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
    Public Property Percentage() As System.Double
        Get
            Return  _Percentage
        End Get
        Set(value As System.Double)
            _Percentage = value
        End Set
    End Property
    '
    Public Default Property Item(index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.TaxCat.ToString()
            ElseIf index = 1 Then
                Return Me.Description.ToString()
            ElseIf index = 2 Then
                Return Me.Percentage.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = 0 Then
                Me.TaxCat = value
            ElseIf index = 1 Then
                Me.Description = value
            ElseIf index = 2 Then
                Try
                    Me.Percentage = System.Double.Parse("0" & value)
                Catch
                    Me.Percentage = System.Double.Parse("0")
                End Try
            End If
        End Set
    End Property
    Public Default Property Item(index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde al nombre de la columna)
        Get
            If index = "TaxCat" Then
                Return Me.TaxCat.ToString()
            ElseIf index = "Description" Then
                Return Me.Description.ToString()
            ElseIf index = "Percentage" Then
                Return Me.Percentage.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = "TaxCat" Then
                Me.TaxCat = value
            ElseIf index = "Description" Then
                Me.Description = value
            ElseIf index = "Percentage" Then
                Try
                    Me.Percentage = System.Double.Parse("0" & value)
                Catch
                    Me.Percentage = System.Double.Parse("0")
                End Try
            End If
        End Set
    End Property
    '
    ' Campos y métodos compartidos (estáticos) para gestionar la base de datos
    '
    ' La cadena de conexión a la base de datos
    Private Shared cadenaConexion As String = ""
    ' La cadena de selección
    Public Shared CadenaSelect As String = "SELECT * FROM IDF_Impuestos"
    '
    Public Sub New()
    End Sub
    Public Sub New(conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto IDF_Impuestos
    Private Shared Function row2IDF_Impuestos(r As DataRow) As IDF_Impuestos
        ' asigna a un objeto IDF_Impuestos los datos del dataRow indicado
        Dim oIDF_Impuestos As New IDF_Impuestos
        '
        oIDF_Impuestos.TaxCat = r("TaxCat").ToString()
        oIDF_Impuestos.Description = r("Description").ToString()
        oIDF_Impuestos.Percentage = System.Double.Parse("0" & r("Percentage").ToString())
        '
        Return oIDF_Impuestos
    End Function
    '
    ' asigna un objeto IDF_Impuestos a la fila indicada
    Private Shared Sub IDF_Impuestos2Row(oIDF_Impuestos As IDF_Impuestos, r As DataRow)
        ' asigna un objeto IDF_Impuestos al dataRow indicado
        r("TaxCat") = oIDF_Impuestos.TaxCat
        r("Description") = oIDF_Impuestos.Description
        r("Percentage") = oIDF_Impuestos.Percentage
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto IDF_Impuestos
    Private Shared Sub nuevoIDF_Impuestos(dt As DataTable, oIDF_Impuestos As IDF_Impuestos)
        ' Crear un nuevo IDF_Impuestos
        Dim dr As DataRow = dt.NewRow()
        Dim oI As IDF_Impuestos = row2IDF_Impuestos(dr)
        '
        oI.TaxCat = oIDF_Impuestos.TaxCat
        oI.Description = oIDF_Impuestos.Description
        oI.Percentage = oIDF_Impuestos.Percentage
        '
        IDF_Impuestos2Row(oI, dr)
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
        Dim dt As New DataTable("IDF_Impuestos")
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
    Public Shared Function Buscar(sWhere As String) As IDF_Impuestos
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oIDF_Impuestos As IDF_Impuestos = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_Impuestos")
        Dim sel As String = "SELECT * FROM IDF_Impuestos WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oIDF_Impuestos = row2IDF_Impuestos(dt.Rows(0))
        End If
        Return oIDF_Impuestos
    End Function
End Class
