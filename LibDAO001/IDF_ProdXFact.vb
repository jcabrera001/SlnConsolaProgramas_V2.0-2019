'------------------------------------------------------------------------------
' Clase IDF_ProdXFact generada automáticamente con CrearClaseSQL
' de la tabla 'IDF_ProdXFact' de la base 'Finanzas'
' Fecha: 23/Mar/2015 09:05:12
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
Public Class IDF_ProdXFact
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _ProdXFactID As System.Int32
    Private _ProdCodigo As System.String
    Private _DFFactID As System.Int32
    Private _ImptoCodigo As System.String
    Private _Cantidad As System.Decimal
    Private _Precio As System.Decimal
    Private _TotalBruto As System.Decimal
    Private _DesctoMonto As System.Decimal
    Private _TotalNeto As System.Decimal
    Private _UnidMedCodigo As System.String
    Private _Descrip1 As System.String
    Private _Descrip2 As System.String
    Private _ImptoMonto As System.Decimal
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
    Public Property ProdXFactID() As System.Int32
        Get
            Return  _ProdXFactID
        End Get
        Set(value As System.Int32)
            _ProdXFactID = value
        End Set
    End Property
    Public Property ProdCodigo() As System.String
        Get
            Return ajustarAncho(_ProdCodigo,10)
        End Get
        Set(value As System.String)
            _ProdCodigo = value
        End Set
    End Property
    Public Property DFFactID() As System.Int32
        Get
            Return  _DFFactID
        End Get
        Set(value As System.Int32)
            _DFFactID = value
        End Set
    End Property
    Public Property ImptoCodigo() As System.String
        Get
            Return ajustarAncho(_ImptoCodigo,10)
        End Get
        Set(value As System.String)
            _ImptoCodigo = value
        End Set
    End Property
    Public Property Cantidad() As System.Decimal
        Get
            Return  _Cantidad
        End Get
        Set(value As System.Decimal)
            _Cantidad = value
        End Set
    End Property
    Public Property Precio() As System.Decimal
        Get
            Return  _Precio
        End Get
        Set(value As System.Decimal)
            _Precio = value
        End Set
    End Property
    Public Property TotalBruto() As System.Decimal
        Get
            Return  _TotalBruto
        End Get
        Set(value As System.Decimal)
            _TotalBruto = value
        End Set
    End Property
    Public Property DesctoMonto() As System.Decimal
        Get
            Return  _DesctoMonto
        End Get
        Set(value As System.Decimal)
            _DesctoMonto = value
        End Set
    End Property
    Public Property TotalNeto() As System.Decimal
        Get
            Return  _TotalNeto
        End Get
        Set(value As System.Decimal)
            _TotalNeto = value
        End Set
    End Property
    Public Property UnidMedCodigo() As System.String
        Get
            Return ajustarAncho(_UnidMedCodigo,10)
        End Get
        Set(value As System.String)
            _UnidMedCodigo = value
        End Set
    End Property
    Public Property Descrip1() As System.String
        Get
            Return ajustarAncho(_Descrip1, 250)
        End Get
        Set(value As System.String)
            _Descrip1 = value
        End Set
    End Property
    Public Property Descrip2() As System.String
        Get
            Return ajustarAncho(_Descrip2, 250)
        End Get
        Set(value As System.String)
            _Descrip2 = value
        End Set
    End Property
    Public Property ImptoMonto() As System.Decimal
        Get
            Return  _ImptoMonto
        End Get
        Set(value As System.Decimal)
            _ImptoMonto = value
        End Set
    End Property
    '
    Public Default Property Item(index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.ProdXFactID.ToString()
            ElseIf index = 1 Then
                Return Me.ProdCodigo.ToString()
            ElseIf index = 2 Then
                Return Me.DFFactID.ToString()
            ElseIf index = 3 Then
                Return Me.ImptoCodigo.ToString()
            ElseIf index = 4 Then
                Return Me.Cantidad.ToString()
            ElseIf index = 5 Then
                Return Me.Precio.ToString()
            ElseIf index = 6 Then
                Return Me.TotalBruto.ToString()
            ElseIf index = 7 Then
                Return Me.DesctoMonto.ToString()
            ElseIf index = 8 Then
                Return Me.TotalNeto.ToString()
            ElseIf index = 9 Then
                Return Me.UnidMedCodigo.ToString()
            ElseIf index = 10 Then
                Return Me.Descrip1.ToString()
            ElseIf index = 11 Then
                Return Me.Descrip2.ToString()
            ElseIf index = 12 Then
                Return Me.ImptoMonto.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = 0 Then
                Try
                    Me.ProdXFactID = System.Int32.Parse("0" & value)
                Catch
                    Me.ProdXFactID = System.Int32.Parse("0")
                End Try
            ElseIf index = 1 Then
                Me.ProdCodigo = value
            ElseIf index = 2 Then
                Try
                    Me.DFFactID = System.Int32.Parse("0" & value)
                Catch
                    Me.DFFactID = System.Int32.Parse("0")
                End Try
            ElseIf index = 3 Then
                Me.ImptoCodigo = value
            ElseIf index = 4 Then
                Try
                    Me.Cantidad = System.Decimal.Parse("0" & value)
                Catch
                    Me.Cantidad = System.Decimal.Parse("0")
                End Try
            ElseIf index = 5 Then
                Try
                    Me.Precio = System.Decimal.Parse("0" & value)
                Catch
                    Me.Precio = System.Decimal.Parse("0")
                End Try
            ElseIf index = 6 Then
                Try
                    Me.TotalBruto = System.Decimal.Parse("0" & value)
                Catch
                    Me.TotalBruto = System.Decimal.Parse("0")
                End Try
            ElseIf index = 7 Then
                Try
                    Me.DesctoMonto = System.Decimal.Parse("0" & value)
                Catch
                    Me.DesctoMonto = System.Decimal.Parse("0")
                End Try
            ElseIf index = 8 Then
                Try
                    Me.TotalNeto = System.Decimal.Parse("0" & value)
                Catch
                    Me.TotalNeto = System.Decimal.Parse("0")
                End Try
            ElseIf index = 9 Then
                Me.UnidMedCodigo = value
            ElseIf index = 10 Then
                Me.Descrip1 = value
            ElseIf index = 11 Then
                Me.Descrip2 = value
            ElseIf index = 12 Then
                Try
                    Me.ImptoMonto = System.Decimal.Parse("0" & value)
                Catch
                    Me.ImptoMonto = System.Decimal.Parse("0")
                End Try
            End If
        End Set
    End Property
    Public Default Property Item(index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde al nombre de la columna)
        Get
            If index = "ProdXFactID" Then
                Return Me.ProdXFactID.ToString()
            ElseIf index = "ProdCodigo" Then
                Return Me.ProdCodigo.ToString()
            ElseIf index = "DFFactID" Then
                Return Me.DFFactID.ToString()
            ElseIf index = "ImptoCodigo" Then
                Return Me.ImptoCodigo.ToString()
            ElseIf index = "Cantidad" Then
                Return Me.Cantidad.ToString()
            ElseIf index = "Precio" Then
                Return Me.Precio.ToString()
            ElseIf index = "TotalBruto" Then
                Return Me.TotalBruto.ToString()
            ElseIf index = "DesctoMonto" Then
                Return Me.DesctoMonto.ToString()
            ElseIf index = "TotalNeto" Then
                Return Me.TotalNeto.ToString()
            ElseIf index = "UnidMedCodigo" Then
                Return Me.UnidMedCodigo.ToString()
            ElseIf index = "Descrip1" Then
                Return Me.Descrip1.ToString()
            ElseIf index = "Descrip2" Then
                Return Me.Descrip2.ToString()
            ElseIf index = "ImptoMonto" Then
                Return Me.ImptoMonto.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = "ProdXFactID" Then
                Try
                    Me.ProdXFactID = System.Int32.Parse("0" & value)
                Catch
                    Me.ProdXFactID = System.Int32.Parse("0")
                End Try
            ElseIf index = "ProdCodigo" Then
                Me.ProdCodigo = value
            ElseIf index = "DFFactID" Then
                Try
                    Me.DFFactID = System.Int32.Parse("0" & value)
                Catch
                    Me.DFFactID = System.Int32.Parse("0")
                End Try
            ElseIf index = "ImptoCodigo" Then
                Me.ImptoCodigo = value
            ElseIf index = "Cantidad" Then
                Try
                    Me.Cantidad = System.Decimal.Parse("0" & value)
                Catch
                    Me.Cantidad = System.Decimal.Parse("0")
                End Try
            ElseIf index = "Precio" Then
                Try
                    Me.Precio = System.Decimal.Parse("0" & value)
                Catch
                    Me.Precio = System.Decimal.Parse("0")
                End Try
            ElseIf index = "TotalBruto" Then
                Try
                    Me.TotalBruto = System.Decimal.Parse("0" & value)
                Catch
                    Me.TotalBruto = System.Decimal.Parse("0")
                End Try
            ElseIf index = "DesctoMonto" Then
                Try
                    Me.DesctoMonto = System.Decimal.Parse("0" & value)
                Catch
                    Me.DesctoMonto = System.Decimal.Parse("0")
                End Try
            ElseIf index = "TotalNeto" Then
                Try
                    Me.TotalNeto = System.Decimal.Parse("0" & value)
                Catch
                    Me.TotalNeto = System.Decimal.Parse("0")
                End Try
            ElseIf index = "UnidMedCodigo" Then
                Me.UnidMedCodigo = value
            ElseIf index = "Descrip1" Then
                Me.Descrip1 = value
            ElseIf index = "Descrip2" Then
                Me.Descrip2 = value
            ElseIf index = "ImptoMonto" Then
                Try
                    Me.ImptoMonto = System.Decimal.Parse("0" & value)
                Catch
                    Me.ImptoMonto = System.Decimal.Parse("0")
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
    Public Shared CadenaSelect As String = "SELECT * FROM IDF_ProdXFact"
    '
    Public Sub New()
    End Sub
    Public Sub New(conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto IDF_ProdXFact
    Private Shared Function row2IDF_ProdXFact(r As DataRow) As IDF_ProdXFact
        ' asigna a un objeto IDF_ProdXFact los datos del dataRow indicado
        Dim oIDF_ProdXFact As New IDF_ProdXFact
        '
        oIDF_ProdXFact.ProdXFactID = System.Int32.Parse("0" & r("ProdXFactID").ToString())
        oIDF_ProdXFact.ProdCodigo = r("ProdCodigo").ToString()
        oIDF_ProdXFact.DFFactID = System.Int32.Parse("0" & r("DFFactID").ToString())
        oIDF_ProdXFact.ImptoCodigo = r("ImptoCodigo").ToString()
        oIDF_ProdXFact.Cantidad = System.Decimal.Parse("0" & r("Cantidad").ToString())
        oIDF_ProdXFact.Precio = System.Decimal.Parse("0" & r("Precio").ToString())
        oIDF_ProdXFact.TotalBruto = System.Decimal.Parse("0" & r("TotalBruto").ToString())
        oIDF_ProdXFact.DesctoMonto = System.Decimal.Parse("0" & r("DesctoMonto").ToString())
        oIDF_ProdXFact.TotalNeto = System.Decimal.Parse("0" & r("TotalNeto").ToString())
        oIDF_ProdXFact.UnidMedCodigo = r("UnidMedCodigo").ToString()
        oIDF_ProdXFact.Descrip1 = r("Descrip1").ToString()
        oIDF_ProdXFact.Descrip2 = r("Descrip2").ToString()
        oIDF_ProdXFact.ImptoMonto = System.Decimal.Parse("0" & r("ImptoMonto").ToString())
        '
        Return oIDF_ProdXFact
    End Function
    '
    ' asigna un objeto IDF_ProdXFact a la fila indicada
    Private Shared Sub IDF_ProdXFact2Row(oIDF_ProdXFact As IDF_ProdXFact, r As DataRow)
        ' asigna un objeto IDF_ProdXFact al dataRow indicado
        ' TODO: Comprueba si esta asignación debe hacerse
        '       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        'r("ProdXFactID") = oIDF_ProdXFact.ProdXFactID
        r("ProdCodigo") = oIDF_ProdXFact.ProdCodigo
        r("DFFactID") = oIDF_ProdXFact.DFFactID
        r("ImptoCodigo") = oIDF_ProdXFact.ImptoCodigo
        r("Cantidad") = oIDF_ProdXFact.Cantidad
        r("Precio") = oIDF_ProdXFact.Precio
        r("TotalBruto") = oIDF_ProdXFact.TotalBruto
        r("DesctoMonto") = oIDF_ProdXFact.DesctoMonto
        r("TotalNeto") = oIDF_ProdXFact.TotalNeto
        r("UnidMedCodigo") = oIDF_ProdXFact.UnidMedCodigo
        r("Descrip1") = oIDF_ProdXFact.Descrip1
        r("Descrip2") = oIDF_ProdXFact.Descrip2
        r("ImptoMonto") = oIDF_ProdXFact.ImptoMonto
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto IDF_ProdXFact
    Private Shared Sub nuevoIDF_ProdXFact(dt As DataTable, oIDF_ProdXFact As IDF_ProdXFact)
        ' Crear un nuevo IDF_ProdXFact
        Dim dr As DataRow = dt.NewRow()
        Dim oI As IDF_ProdXFact = row2IDF_ProdXFact(dr)
        '
        oI.ProdXFactID = oIDF_ProdXFact.ProdXFactID
        oI.ProdCodigo = oIDF_ProdXFact.ProdCodigo
        oI.DFFactID = oIDF_ProdXFact.DFFactID
        oI.ImptoCodigo = oIDF_ProdXFact.ImptoCodigo
        oI.Cantidad = oIDF_ProdXFact.Cantidad
        oI.Precio = oIDF_ProdXFact.Precio
        oI.TotalBruto = oIDF_ProdXFact.TotalBruto
        oI.DesctoMonto = oIDF_ProdXFact.DesctoMonto
        oI.TotalNeto = oIDF_ProdXFact.TotalNeto
        oI.UnidMedCodigo = oIDF_ProdXFact.UnidMedCodigo
        oI.Descrip1 = oIDF_ProdXFact.Descrip1
        oI.Descrip2 = oIDF_ProdXFact.Descrip2
        oI.ImptoMonto = oIDF_ProdXFact.ImptoMonto
        '
        IDF_ProdXFact2Row(oI, dr)
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
        ' devuelve una tabla con los datos de la tabla IDF_ProdXFact
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_ProdXFact")
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
    Public Shared Function Buscar(sWhere As String) As IDF_ProdXFact
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oIDF_ProdXFact As IDF_ProdXFact = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_ProdXFact")
        Dim sel As String = "SELECT * FROM IDF_ProdXFact WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oIDF_ProdXFact = row2IDF_ProdXFact(dt.Rows(0))
        End If
        Return oIDF_ProdXFact
    End Function

    Public Shared Function TotalXFactID(nDFFactID As Integer, cValor As String) As Double

        If nDFFactID = 0 Then
            Return 0
        End If

        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim nRes As Double = 0.0
        Dim oIDF_ProdXFact As IDF_ProdXFact = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_ProdXFact")
        Dim sel As String = "SELECT Sum(TotalBruto) As TotalBruto, Sum(DesctoMonto) As DesctoMonto, Sum(ImptoMonto) As ImptoMonto, Sum(TotalNeto) As TotalNeto,ISNULL(SUM(CASE WHEN ImptoCodigo = 'ISV0' THEN TotalBruto END),0) AS TotalExento FROM IDF_ProdXFact WHERE DFFactID='" & nDFFactID & "'"
        '
        da = New SqlDataAdapter(sel, cadenaConexion) 'MANUEL ORTEGA - PENDIENTE - 11-08-2015 04:28:00
        da.Fill(dt)

        Try
            nRes = CDbl(IIf(cValor = "TotalBruto", dt.Rows(0).Item(0),
                            IIf(cValor = "DesctoMonto", dt.Rows(0).Item(1),
                                IIf(cValor = "ImptoMonto", dt.Rows(0).Item(2),
                                    IIf(cValor = "TotalNeto", dt.Rows(0).Item(3), dt.Rows(0).Item(4)
                                        )
                                    )
                                )
                            )
                        )
        Catch ex As Exception
            nRes = 0
        End Try

        Return nRes
    End Function
    '
    ' Actualizar: Actualiza los datos en la tabla usando la instancia actual
    '             Si la instancia no hace referencia a un registro existente, se creará uno nuevo
    '             Para comprobar si el objeto en memoria coincide con uno existente,
    '             se comprueba si el ProdXFactID existe en la tabla.
    '             TODO: Si en lugar de ProdXFactID usas otro campo, indicalo en la cadena SELECT
    '                   También puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    Public Function Actualizar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el ProdXFactID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_ProdXFact WHERE ProdXFactID = " & Me.ProdXFactID.ToString()
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(sel As String) As String
        ' Actualiza los datos indicados
        ' El parámetro, que es una cadena de selección, indicará el criterio de actualización
        '
        ' En caso de error, devolverá la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_ProdXFact")
        '
        cnn = New SqlConnection(cadenaConexion)
        'da = New SqlDataAdapter(CadenaSelect, cnn)
        da = New SqlDataAdapter(sel, cnn)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        '
        '-------------------------------------------
        ' Esta no es la más óptima, pero funcionará
        '-------------------------------------------
        Dim cb As New SqlCommandBuilder(da)
        da.UpdateCommand = cb.GetUpdateCommand()
        '
        '--------------------------------------------------------------------
        ' Esta está más optimizada pero debes comprobar que funciona bien...
        '--------------------------------------------------------------------
        'Dim sCommand As String
        ''
        '' El comando UPDATE
        '' TODO: Comprobar cual es el campo de índice principal (sin duplicados)
        ''       Yo compruebo que sea un campo llamado ProdXFactID, pero en tu caso puede ser otro
        ''       Ese campo, (en mi caso ProdXFactID) será el que hay que poner al final junto al WHERE.
        'sCommand = "UPDATE IDF_ProdXFact SET ProdCodigo = @ProdCodigo, DFFactID = @DFFactID, ImptoCodigo = @ImptoCodigo, Cantidad = @Cantidad, Precio = @Precio, TotalBruto = @TotalBruto, DesctoMonto = @DesctoMonto, TotalNeto = @TotalNeto, UnidMedCodigo = @UnidMedCodigo, Descrip1 = @Descrip1, Descrip2 = @Descrip2, ImptoMonto = @ImptoMonto  WHERE (ProdXFactID = @ProdXFactID)"
        'da.UpdateCommand = New SqlCommand(sCommand, cnn)
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@ProdXFactID", SqlDbType.Int, 0, "ProdXFactID")
        'da.UpdateCommand.Parameters.Add("@ProdCodigo", SqlDbType.NVarChar, 10, "ProdCodigo")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@DFFactID", SqlDbType.Int, 0, "DFFactID")
        'da.UpdateCommand.Parameters.Add("@ImptoCodigo", SqlDbType.NVarChar, 10, "ImptoCodigo")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@Cantidad", SqlDbType.Decimal, 0, "Cantidad")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@Precio", SqlDbType.Decimal, 0, "Precio")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@TotalBruto", SqlDbType.Decimal, 0, "TotalBruto")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@DesctoMonto", SqlDbType.Decimal, 0, "DesctoMonto")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@TotalNeto", SqlDbType.Decimal, 0, "TotalNeto")
        'da.UpdateCommand.Parameters.Add("@UnidMedCodigo", SqlDbType.NVarChar, 10, "UnidMedCodigo")
        'da.UpdateCommand.Parameters.Add("@Descrip1", SqlDbType.NVarChar, 50, "Descrip1")
        'da.UpdateCommand.Parameters.Add("@Descrip2", SqlDbType.NVarChar, 50, "Descrip2")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@ImptoMonto", SqlDbType.Decimal, 0, "ImptoMonto")
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        If dt.Rows.Count = 0 Then
            ' crear uno nuevo
            Return Crear()
        Else
            IDF_ProdXFact2Row(Me, dt.Rows(0))
        End If
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Actualizado correctamente"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Crear() As String
        ' Crear un nuevo registro
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_ProdXFact")
        '
        cnn = New SqlConnection(cadenaConexion)
        da = New SqlDataAdapter(CadenaSelect, cnn)
        'da = New SqlDataAdapter(CadenaSelect, cadenaConexion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        '
        '-------------------------------------------
        ' Esta no es la más óptima, pero funcionará
        '-------------------------------------------
        Dim cb As New SqlCommandBuilder(da)
        da.InsertCommand = cb.GetInsertCommand()
        '
        '--------------------------------------------------------------------
        ' Esta está más optimizada pero debes comprobar que funciona bien...
        '--------------------------------------------------------------------
        'Dim sCommand As String
        ''
        '' El comando INSERT
        '' TODO: No incluir el campo de clave primaria incremental
        ''       Yo compruebo que sea un campo llamado ProdXFactID, pero en tu caso puede ser otro
        'sCommand = "INSERT INTO IDF_ProdXFact (ProdCodigo, DFFactID, ImptoCodigo, Cantidad, Precio, TotalBruto, DesctoMonto, TotalNeto, UnidMedCodigo, Descrip1, Descrip2, ImptoMonto)  VALUES(@ProdCodigo, @DFFactID, @ImptoCodigo, @Cantidad, @Precio, @TotalBruto, @DesctoMonto, @TotalNeto, @UnidMedCodigo, @Descrip1, @Descrip2, @ImptoMonto)"
        'da.InsertCommand = New SqlCommand(sCommand, cnn)
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@ProdXFactID", SqlDbType.Int, 0, "ProdXFactID")
        'da.InsertCommand.Parameters.Add("@ProdCodigo", SqlDbType.NVarChar, 10, "ProdCodigo")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@DFFactID", SqlDbType.Int, 0, "DFFactID")
        'da.InsertCommand.Parameters.Add("@ImptoCodigo", SqlDbType.NVarChar, 10, "ImptoCodigo")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@Cantidad", SqlDbType.Decimal, 0, "Cantidad")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@Precio", SqlDbType.Decimal, 0, "Precio")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@TotalBruto", SqlDbType.Decimal, 0, "TotalBruto")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@DesctoMonto", SqlDbType.Decimal, 0, "DesctoMonto")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@TotalNeto", SqlDbType.Decimal, 0, "TotalNeto")
        'da.InsertCommand.Parameters.Add("@UnidMedCodigo", SqlDbType.NVarChar, 10, "UnidMedCodigo")
        'da.InsertCommand.Parameters.Add("@Descrip1", SqlDbType.NVarChar, 50, "Descrip1")
        'da.InsertCommand.Parameters.Add("@Descrip2", SqlDbType.NVarChar, 50, "Descrip2")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@ImptoMonto", SqlDbType.Decimal, 0, "ImptoMonto")
        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoIDF_ProdXFact(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo IDF_ProdXFact"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el ProdXFactID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_ProdXFact WHERE ProdXFactID = " & Me.ProdXFactID.ToString()
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_ProdXFact")
        '
        cnn = New SqlConnection(cadenaConexion)
        da = New SqlDataAdapter(sel, cnn)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        '
        '-------------------------------------------
        ' Esta no es la más óptima, pero funcionará
        '-------------------------------------------
        Dim cb As New SqlCommandBuilder(da)
        da.DeleteCommand = cb.GetDeleteCommand()
        '
        '
        '--------------------------------------------------------------------
        ' Esta está más optimizada pero debes comprobar que funciona bien...
        '--------------------------------------------------------------------
        'Dim sCommand As String
        ''
        '' El comando DELETE
        '' TODO: Sólo incluir el campo de clave primaria incremental
        ''       Yo compruebo que sea un campo llamado ProdXFactID, pero en tu caso puede ser otro
        'sCommand = "DELETE FROM IDF_ProdXFact WHERE (ProdXFactID = @p1)"
        'da.DeleteCommand = New SqlCommand(sCommand, cnn)
        '' TODO: Comprobar el tipo de datos a usar...
        'da.DeleteCommand.Parameters.Add("@p1", SqlDbType.Int, 0, "ProdXFactID")
        'da.DeleteCommand.Parameters.Add("@p2", SqlDbType.Int, 0, "")
        '
        '
        da.Fill(dt)
        '
        If dt.Rows.Count = 0 Then
            Return "ERROR: No hay datos"
        Else
            dt.Rows(0).Delete()
        End If
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Borrado satisfactoriamente"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
End Class
