'------------------------------------------------------------------------------
' Clase IDF_DFs generada automáticamente con CrearClaseSQL
' de la tabla 'TmpDatos' de la base 'Finanzas'
' Fecha: 24/Mar/2015 13:10:57
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
Public Class IDF_DFs
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _ObjectID As System.Int32
    Private _SrcDoc As System.String
    Private _DocDate As System.DateTime
    Private _DueDate As System.DateTime
    Private _DocAmt As System.Double
    Private _Status As System.Int32
    Private _SDRepos As System.String
    Private _Description As System.String
    Private _OpenAmt As System.Double
    Private _Recipient As System.String
    Private _Memo As System.String
    Private _Company As System.String
    Private _SrcDocCreator As System.String
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
    Public Property ObjectID() As System.Int32
        Get
            Return  _ObjectID
        End Get
        Set(value As System.Int32)
            _ObjectID = value
        End Set
    End Property
    Public Property SrcDoc() As System.String
        Get
            Return ajustarAncho(_SrcDoc,40)
        End Get
        Set(value As System.String)
            _SrcDoc = value
        End Set
    End Property
    Public Property DocDate() As System.DateTime
        Get
            Return  _DocDate
        End Get
        Set(value As System.DateTime)
            _DocDate = value
        End Set
    End Property
    Public Property DueDate() As System.DateTime
        Get
            Return  _DueDate
        End Get
        Set(value As System.DateTime)
            _DueDate = value
        End Set
    End Property
    Public Property DocAmt() As System.Double
        Get
            Return  _DocAmt
        End Get
        Set(value As System.Double)
            _DocAmt = value
        End Set
    End Property
    Public Property Status() As System.Int32
        Get
            Return  _Status
        End Get
        Set(value As System.Int32)
            _Status = value
        End Set
    End Property
    Public Property SDRepos() As System.String
        Get
            Return ajustarAncho(_SDRepos,40)
        End Get
        Set(value As System.String)
            _SDRepos = value
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
    Public Property OpenAmt() As System.Double
        Get
            Return  _OpenAmt
        End Get
        Set(value As System.Double)
            _OpenAmt = value
        End Set
    End Property
    Public Property Recipient() As System.String
        Get
            Return ajustarAncho(_Recipient,30)
        End Get
        Set(value As System.String)
            _Recipient = value
        End Set
    End Property
    Public Property Memo() As System.String
        Get
            Return ajustarAncho(_Memo,40)
        End Get
        Set(value As System.String)
            _Memo = value
        End Set
    End Property
    Public Property Company() As System.String
        Get
            Return ajustarAncho(_Company,30)
        End Get
        Set(value As System.String)
            _Company = value
        End Set
    End Property
    Public Property SrcDocCreator() As System.String
        Get
            Return ajustarAncho(_SrcDocCreator,30)
        End Get
        Set(value As System.String)
            _SrcDocCreator = value
        End Set
    End Property
    '
    Public Default Property Item(index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.ObjectID.ToString()
            ElseIf index = 1 Then
                Return Me.SrcDoc.ToString()
            ElseIf index = 2 Then
                Return Me.DocDate.ToString()
            ElseIf index = 3 Then
                Return Me.DueDate.ToString()
            ElseIf index = 4 Then
                Return Me.DocAmt.ToString()
            ElseIf index = 5 Then
                Return Me.Status.ToString()
            ElseIf index = 6 Then
                Return Me.SDRepos.ToString()
            ElseIf index = 7 Then
                Return Me.Description.ToString()
            ElseIf index = 8 Then
                Return Me.OpenAmt.ToString()
            ElseIf index = 9 Then
                Return Me.Recipient.ToString()
            ElseIf index = 10 Then
                Return Me.Memo.ToString()
            ElseIf index = 11 Then
                Return Me.Company.ToString()
            ElseIf index = 12 Then
                Return Me.SrcDocCreator.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = 0 Then
                Try
                    Me.ObjectID = System.Int32.Parse("0" & value)
                Catch
                    Me.ObjectID = System.Int32.Parse("0")
                End Try
            ElseIf index = 1 Then
                Me.SrcDoc = value
            ElseIf index = 2 Then
                Try
                    Me.DocDate = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.DocDate = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.DocDate = System.DateTime.Now
                End Try
            ElseIf index = 3 Then
                Try
                    Me.DueDate = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.DueDate = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.DueDate = System.DateTime.Now
                End Try
            ElseIf index = 4 Then
                Try
                    Me.DocAmt = System.Double.Parse("0" & value)
                Catch
                    Me.DocAmt = System.Double.Parse("0")
                End Try
            ElseIf index = 5 Then
                Try
                    Me.Status = System.Int32.Parse("0" & value)
                Catch
                    Me.Status = System.Int32.Parse("0")
                End Try
            ElseIf index = 6 Then
                Me.SDRepos = value
            ElseIf index = 7 Then
                Me.Description = value
            ElseIf index = 8 Then
                Try
                    Me.OpenAmt = System.Double.Parse("0" & value)
                Catch
                    Me.OpenAmt = System.Double.Parse("0")
                End Try
            ElseIf index = 9 Then
                Me.Recipient = value
            ElseIf index = 10 Then
                Me.Memo = value
            ElseIf index = 11 Then
                Me.Company = value
            ElseIf index = 12 Then
                Me.SrcDocCreator = value
            End If
        End Set
    End Property
    Public Default Property Item(index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde al nombre de la columna)
        Get
            If index = "ObjectID" Then
                Return Me.ObjectID.ToString()
            ElseIf index = "SrcDoc" Then
                Return Me.SrcDoc.ToString()
            ElseIf index = "DocDate" Then
                Return Me.DocDate.ToString()
            ElseIf index = "DueDate" Then
                Return Me.DueDate.ToString()
            ElseIf index = "DocAmt" Then
                Return Me.DocAmt.ToString()
            ElseIf index = "Status" Then
                Return Me.Status.ToString()
            ElseIf index = "SDRepos" Then
                Return Me.SDRepos.ToString()
            ElseIf index = "Description" Then
                Return Me.Description.ToString()
            ElseIf index = "OpenAmt" Then
                Return Me.OpenAmt.ToString()
            ElseIf index = "Recipient" Then
                Return Me.Recipient.ToString()
            ElseIf index = "Memo" Then
                Return Me.Memo.ToString()
            ElseIf index = "Company" Then
                Return Me.Company.ToString()
            ElseIf index = "SrcDocCreator" Then
                Return Me.SrcDocCreator.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = "ObjectID" Then
                Try
                    Me.ObjectID = System.Int32.Parse("0" & value)
                Catch
                    Me.ObjectID = System.Int32.Parse("0")
                End Try
            ElseIf index = "SrcDoc" Then
                Me.SrcDoc = value
            ElseIf index = "DocDate" Then
                Try
                    Me.DocDate = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.DocDate = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.DocDate = System.DateTime.Now
                End Try
            ElseIf index = "DueDate" Then
                Try
                    Me.DueDate = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.DueDate = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.DueDate = System.DateTime.Now
                End Try
            ElseIf index = "DocAmt" Then
                Try
                    Me.DocAmt = System.Double.Parse("0" & value)
                Catch
                    Me.DocAmt = System.Double.Parse("0")
                End Try
            ElseIf index = "Status" Then
                Try
                    Me.Status = System.Int32.Parse("0" & value)
                Catch
                    Me.Status = System.Int32.Parse("0")
                End Try
            ElseIf index = "SDRepos" Then
                Me.SDRepos = value
            ElseIf index = "Description" Then
                Me.Description = value
            ElseIf index = "OpenAmt" Then
                Try
                    Me.OpenAmt = System.Double.Parse("0" & value)
                Catch
                    Me.OpenAmt = System.Double.Parse("0")
                End Try
            ElseIf index = "Recipient" Then
                Me.Recipient = value
            ElseIf index = "Memo" Then
                Me.Memo = value
            ElseIf index = "Company" Then
                Me.Company = value
            ElseIf index = "SrcDocCreator" Then
                Me.SrcDocCreator = value
            End If
        End Set
    End Property
    '
    ' Campos y métodos compartidos (estáticos) para gestionar la base de datos
    '
    ' La cadena de conexión a la base de datos
    Private Shared cadenaConexion As String = ""
    ' La cadena de selección
    Public Shared CadenaSelect As String = "SELECT * FROM IDF_DFs"
    '
    Public Sub New()
    End Sub
    Public Sub New(conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto IDF_DFs
    Private Shared Function row2IDF_DFs(r As DataRow) As IDF_DFs
        ' asigna a un objeto IDF_DFs los datos del dataRow indicado
        Dim oIDF_DFs As New IDF_DFs
        '
        oIDF_DFs.ObjectID = System.Int32.Parse("0" & r("ObjectID").ToString())
        oIDF_DFs.SrcDoc = r("SrcDoc").ToString()
        Try
            oIDF_DFs.DocDate = DateTime.Parse(r("DocDate").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oIDF_DFs.DocDate = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oIDF_DFs.DocDate = DateTime.Now
        End Try
        Try
            oIDF_DFs.DueDate = DateTime.Parse(r("DueDate").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oIDF_DFs.DueDate = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oIDF_DFs.DueDate = DateTime.Now
        End Try
        oIDF_DFs.DocAmt = System.Double.Parse("0" & r("DocAmt").ToString())
        oIDF_DFs.Status = System.Int32.Parse("0" & r("Status").ToString())
        oIDF_DFs.SDRepos = r("SDRepos").ToString()
        oIDF_DFs.Description = r("Description").ToString()
        oIDF_DFs.OpenAmt = System.Double.Parse("0" & r("OpenAmt").ToString())
        oIDF_DFs.Recipient = r("Recipient").ToString()
        oIDF_DFs.Memo = r("Memo").ToString()
        oIDF_DFs.Company = r("Company").ToString()
        oIDF_DFs.SrcDocCreator = r("SrcDocCreator").ToString()
        '
        Return oIDF_DFs
    End Function
    '
    ' asigna un objeto IDF_DFs a la fila indicada
    Private Shared Sub IDF_DFs2Row(oIDF_DFs As IDF_DFs, r As DataRow)
        ' asigna un objeto IDF_DFs al dataRow indicado
        r("ObjectID") = oIDF_DFs.ObjectID
        r("SrcDoc") = oIDF_DFs.SrcDoc
        r("DocDate") = oIDF_DFs.DocDate
        r("DueDate") = oIDF_DFs.DueDate
        r("DocAmt") = oIDF_DFs.DocAmt
        r("Status") = oIDF_DFs.Status
        r("SDRepos") = oIDF_DFs.SDRepos
        r("Description") = oIDF_DFs.Description
        r("OpenAmt") = oIDF_DFs.OpenAmt
        r("Recipient") = oIDF_DFs.Recipient
        r("Memo") = oIDF_DFs.Memo
        r("Company") = oIDF_DFs.Company
        r("SrcDocCreator") = oIDF_DFs.SrcDocCreator
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto IDF_DFs
    Private Shared Sub nuevoIDF_DFs(dt As DataTable, oIDF_DFs As IDF_DFs)
        ' Crear un nuevo IDF_DFs
        Dim dr As DataRow = dt.NewRow()
        Dim oI As IDF_DFs = row2IDF_DFs(dr)
        '
        oI.ObjectID = oIDF_DFs.ObjectID
        oI.SrcDoc = oIDF_DFs.SrcDoc
        oI.DocDate = oIDF_DFs.DocDate
        oI.DueDate = oIDF_DFs.DueDate
        oI.DocAmt = oIDF_DFs.DocAmt
        oI.Status = oIDF_DFs.Status
        oI.SDRepos = oIDF_DFs.SDRepos
        oI.Description = oIDF_DFs.Description
        oI.OpenAmt = oIDF_DFs.OpenAmt
        oI.Recipient = oIDF_DFs.Recipient
        oI.Memo = oIDF_DFs.Memo
        oI.Company = oIDF_DFs.Company
        oI.SrcDocCreator = oIDF_DFs.SrcDocCreator
        '
        IDF_DFs2Row(oI, dr)
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
        Dim dt As New DataTable("IDF_DFs")
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
    Public Shared Function Buscar(sWhere As String) As IDF_DFs
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oIDF_DFs As IDF_DFs = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_DFs")
        Dim sel As String = "SELECT * FROM IDF_DFs WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oIDF_DFs = row2IDF_DFs(dt.Rows(0))
        End If
        Return oIDF_DFs
    End Function
End Class
