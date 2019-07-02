'------------------------------------------------------------------------------
' Clase IDF_ItemsxDF generada automáticamente con CrearClaseSQL
' de la tabla 'IDF_ItemsxDF' de la base 'Finanzas'
' Fecha: 10/Apr/2015 13:24:41
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
Public Class IDF_ItemsxDF
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _ItemsxDFID As System.Int32
    Private _ItemID As System.Int32
    Private _DFDescripID As System.Int32
    Private _Descripcion1 As System.String
    Private _TotalBruto As System.Decimal
    Private _DescuentoMonto As System.Decimal
    Private _ImpuestoMonto As System.Decimal
    Private _TotalNeto As System.Decimal
    Private _ImptoCodigo As System.String
    Private _RetencionID As System.Int32
    Private _RetencionMonto As System.Decimal
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
    Public Property ItemsxDFID() As System.Int32
        Get
            Return  _ItemsxDFID
        End Get
        Set(value As System.Int32)
            _ItemsxDFID = value
        End Set
    End Property
    Public Property ItemID() As System.Int32
        Get
            Return  _ItemID
        End Get
        Set(value As System.Int32)
            _ItemID = value
        End Set
    End Property
    Public Property DFDescripID() As System.Int32
        Get
            Return  _DFDescripID
        End Get
        Set(value As System.Int32)
            _DFDescripID = value
        End Set
    End Property
    Public Property Descripcion1() As System.String
        Get
            Return ajustarAncho(_Descripcion1, 250)
        End Get
        Set(value As System.String)
            _Descripcion1 = value
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
    Public Property DescuentoMonto() As System.Decimal
        Get
            Return  _DescuentoMonto
        End Get
        Set(value As System.Decimal)
            _DescuentoMonto = value
        End Set
    End Property
    Public Property ImpuestoMonto() As System.Decimal
        Get
            Return  _ImpuestoMonto
        End Get
        Set(value As System.Decimal)
            _ImpuestoMonto = value
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
    Public Property ImptoCodigo() As System.String
        Get
            Return ajustarAncho(_ImptoCodigo,10)
        End Get
        Set(value As System.String)
            _ImptoCodigo = value
        End Set
    End Property
    Public Property RetencionID() As System.Int32
        Get
            Return  _RetencionID
        End Get
        Set(value As System.Int32)
            _RetencionID = value
        End Set
    End Property
    Public Property RetencionMonto() As System.Decimal
        Get
            Return  _RetencionMonto
        End Get
        Set(value As System.Decimal)
            _RetencionMonto = value
        End Set
    End Property
    '
    Public Default Property Item(index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.ItemsxDFID.ToString()
            ElseIf index = 1 Then
                Return Me.ItemID.ToString()
            ElseIf index = 2 Then
                Return Me.DFDescripID.ToString()
            ElseIf index = 3 Then
                Return Me.Descripcion1.ToString()
            ElseIf index = 4 Then
                Return Me.TotalBruto.ToString()
            ElseIf index = 5 Then
                Return Me.DescuentoMonto.ToString()
            ElseIf index = 6 Then
                Return Me.ImpuestoMonto.ToString()
            ElseIf index = 7 Then
                Return Me.TotalNeto.ToString()
            ElseIf index = 8 Then
                Return Me.ImptoCodigo.ToString()
            ElseIf index = 9 Then
                Return Me.RetencionID.ToString()
            ElseIf index = 10 Then
                Return Me.RetencionMonto.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = 0 Then
                Try
                    Me.ItemsxDFID = System.Int32.Parse("0" & value)
                Catch
                    Me.ItemsxDFID = System.Int32.Parse("0")
                End Try
            ElseIf index = 1 Then
                Try
                    Me.ItemID = System.Int32.Parse("0" & value)
                Catch
                    Me.ItemID = System.Int32.Parse("0")
                End Try
            ElseIf index = 2 Then
                Try
                    Me.DFDescripID = System.Int32.Parse("0" & value)
                Catch
                    Me.DFDescripID = System.Int32.Parse("0")
                End Try
            ElseIf index = 3 Then
                Me.Descripcion1 = value
            ElseIf index = 4 Then
                Try
                    Me.TotalBruto = System.Decimal.Parse("0" & value)
                Catch
                    Me.TotalBruto = System.Decimal.Parse("0")
                End Try
            ElseIf index = 5 Then
                Try
                    Me.DescuentoMonto = System.Decimal.Parse("0" & value)
                Catch
                    Me.DescuentoMonto = System.Decimal.Parse("0")
                End Try
            ElseIf index = 6 Then
                Try
                    Me.ImpuestoMonto = System.Decimal.Parse("0" & value)
                Catch
                    Me.ImpuestoMonto = System.Decimal.Parse("0")
                End Try
            ElseIf index = 7 Then
                Try
                    Me.TotalNeto = System.Decimal.Parse("0" & value)
                Catch
                    Me.TotalNeto = System.Decimal.Parse("0")
                End Try
            ElseIf index = 8 Then
                Me.ImptoCodigo = value
            ElseIf index = 9 Then
                Try
                    Me.RetencionID = System.Int32.Parse("0" & value)
                Catch
                    Me.RetencionID = System.Int32.Parse("0")
                End Try
            ElseIf index = 10 Then
                Try
                    Me.RetencionMonto = System.Decimal.Parse("0" & value)
                Catch
                    Me.RetencionMonto = System.Decimal.Parse("0")
                End Try
            End If
        End Set
    End Property
    Public Default Property Item(index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde al nombre de la columna)
        Get
            If index = "ItemsxDFID" Then
                Return Me.ItemsxDFID.ToString()
            ElseIf index = "ItemID" Then
                Return Me.ItemID.ToString()
            ElseIf index = "DFDescripID" Then
                Return Me.DFDescripID.ToString()
            ElseIf index = "Descripcion1" Then
                Return Me.Descripcion1.ToString()
            ElseIf index = "TotalBruto" Then
                Return Me.TotalBruto.ToString()
            ElseIf index = "DescuentoMonto" Then
                Return Me.DescuentoMonto.ToString()
            ElseIf index = "ImpuestoMonto" Then
                Return Me.ImpuestoMonto.ToString()
            ElseIf index = "TotalNeto" Then
                Return Me.TotalNeto.ToString()
            ElseIf index = "ImptoCodigo" Then
                Return Me.ImptoCodigo.ToString()
            ElseIf index = "RetencionID" Then
                Return Me.RetencionID.ToString()
            ElseIf index = "RetencionMonto" Then
                Return Me.RetencionMonto.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = "ItemsxDFID" Then
                Try
                    Me.ItemsxDFID = System.Int32.Parse("0" & value)
                Catch
                    Me.ItemsxDFID = System.Int32.Parse("0")
                End Try
            ElseIf index = "ItemID" Then
                Try
                    Me.ItemID = System.Int32.Parse("0" & value)
                Catch
                    Me.ItemID = System.Int32.Parse("0")
                End Try
            ElseIf index = "DFDescripID" Then
                Try
                    Me.DFDescripID = System.Int32.Parse("0" & value)
                Catch
                    Me.DFDescripID = System.Int32.Parse("0")
                End Try
            ElseIf index = "Descripcion1" Then
                Me.Descripcion1 = value
            ElseIf index = "TotalBruto" Then
                Try
                    Me.TotalBruto = System.Decimal.Parse("0" & value)
                Catch
                    Me.TotalBruto = System.Decimal.Parse("0")
                End Try
            ElseIf index = "DescuentoMonto" Then
                Try
                    Me.DescuentoMonto = System.Decimal.Parse("0" & value)
                Catch
                    Me.DescuentoMonto = System.Decimal.Parse("0")
                End Try
            ElseIf index = "ImpuestoMonto" Then
                Try
                    Me.ImpuestoMonto = System.Decimal.Parse("0" & value)
                Catch
                    Me.ImpuestoMonto = System.Decimal.Parse("0")
                End Try
            ElseIf index = "TotalNeto" Then
                Try
                    Me.TotalNeto = System.Decimal.Parse("0" & value)
                Catch
                    Me.TotalNeto = System.Decimal.Parse("0")
                End Try
            ElseIf index = "ImptoCodigo" Then
                Me.ImptoCodigo = value
            ElseIf index = "RetencionID" Then
                Try
                    Me.RetencionID = System.Int32.Parse("0" & value)
                Catch
                    Me.RetencionID = System.Int32.Parse("0")
                End Try
            ElseIf index = "RetencionMonto" Then
                Try
                    Me.RetencionMonto = System.Decimal.Parse("0" & value)
                Catch
                    Me.RetencionMonto = System.Decimal.Parse("0")
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
    Public Shared CadenaSelect As String = "SELECT * FROM IDF_ItemsxDF"
    '
    Public Sub New()
    End Sub
    Public Sub New(conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto IDF_ItemsxDF
    Private Shared Function row2IDF_ItemsxDF(r As DataRow) As IDF_ItemsxDF
        ' asigna a un objeto IDF_ItemsxDF los datos del dataRow indicado
        Dim oIDF_ItemsxDF As New IDF_ItemsxDF
        '
        oIDF_ItemsxDF.ItemsxDFID = System.Int32.Parse("0" & r("ItemsxDFID").ToString())
        oIDF_ItemsxDF.ItemID = System.Int32.Parse("0" & r("ItemID").ToString())
        oIDF_ItemsxDF.DFDescripID = System.Int32.Parse("0" & r("DFDescripID").ToString())
        oIDF_ItemsxDF.Descripcion1 = r("Descripcion1").ToString()
        oIDF_ItemsxDF.TotalBruto = System.Decimal.Parse("0" & r("TotalBruto").ToString())
        oIDF_ItemsxDF.DescuentoMonto = System.Decimal.Parse("0" & r("DescuentoMonto").ToString())
        oIDF_ItemsxDF.ImpuestoMonto = System.Decimal.Parse("0" & r("ImpuestoMonto").ToString())
        oIDF_ItemsxDF.TotalNeto = System.Decimal.Parse("0" & r("TotalNeto").ToString())
        oIDF_ItemsxDF.ImptoCodigo = r("ImptoCodigo").ToString()
        oIDF_ItemsxDF.RetencionID = System.Int32.Parse("0" & r("RetencionID").ToString())
        oIDF_ItemsxDF.RetencionMonto = System.Decimal.Parse("0" & r("RetencionMonto").ToString())
        '
        Return oIDF_ItemsxDF
    End Function
    '
    ' asigna un objeto IDF_ItemsxDF a la fila indicada
    Private Shared Sub IDF_ItemsxDF2Row(oIDF_ItemsxDF As IDF_ItemsxDF, r As DataRow)
        ' asigna un objeto IDF_ItemsxDF al dataRow indicado
        ' TODO: Comprueba si esta asignación debe hacerse
        '       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        'r("ItemsxDFID") = oIDF_ItemsxDF.ItemsxDFID
        r("ItemID") = oIDF_ItemsxDF.ItemID
        r("DFDescripID") = oIDF_ItemsxDF.DFDescripID
        r("Descripcion1") = oIDF_ItemsxDF.Descripcion1
        r("TotalBruto") = oIDF_ItemsxDF.TotalBruto
        r("DescuentoMonto") = oIDF_ItemsxDF.DescuentoMonto
        r("ImpuestoMonto") = oIDF_ItemsxDF.ImpuestoMonto
        r("TotalNeto") = oIDF_ItemsxDF.TotalNeto
        r("ImptoCodigo") = oIDF_ItemsxDF.ImptoCodigo
        r("RetencionID") = oIDF_ItemsxDF.RetencionID
        r("RetencionMonto") = oIDF_ItemsxDF.RetencionMonto
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto IDF_ItemsxDF
    Private Shared Sub nuevoIDF_ItemsxDF(dt As DataTable, oIDF_ItemsxDF As IDF_ItemsxDF)
        ' Crear un nuevo IDF_ItemsxDF
        Dim dr As DataRow = dt.NewRow()
        Dim oI As IDF_ItemsxDF = row2IDF_ItemsxDF(dr)
        '
        oI.ItemsxDFID = oIDF_ItemsxDF.ItemsxDFID
        oI.ItemID = oIDF_ItemsxDF.ItemID
        oI.DFDescripID = oIDF_ItemsxDF.DFDescripID
        oI.Descripcion1 = oIDF_ItemsxDF.Descripcion1
        oI.TotalBruto = oIDF_ItemsxDF.TotalBruto
        oI.DescuentoMonto = oIDF_ItemsxDF.DescuentoMonto
        oI.ImpuestoMonto = oIDF_ItemsxDF.ImpuestoMonto
        oI.TotalNeto = oIDF_ItemsxDF.TotalNeto
        oI.ImptoCodigo = oIDF_ItemsxDF.ImptoCodigo
        oI.RetencionID = oIDF_ItemsxDF.RetencionID
        oI.RetencionMonto = oIDF_ItemsxDF.RetencionMonto
        '
        IDF_ItemsxDF2Row(oI, dr)
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
        Dim dt As New DataTable("IDF_ItemsxDF")
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
    Public Shared Function Buscar(sWhere As String) As IDF_ItemsxDF
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oIDF_ItemsxDF As IDF_ItemsxDF = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_ItemsxDF")
        Dim sel As String = "SELECT * FROM IDF_ItemsxDF WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oIDF_ItemsxDF = row2IDF_ItemsxDF(dt.Rows(0))
        End If
        Return oIDF_ItemsxDF
    End Function
    '
    ' Actualizar: Actualiza los datos en la tabla usando la instancia actual
    '             Si la instancia no hace referencia a un registro existente, se creará uno nuevo
    '             Para comprobar si el objeto en memoria coincide con uno existente,
    '             se comprueba si el ItemsxDFID existe en la tabla.
    '             TODO: Si en lugar de ItemsxDFID usas otro campo, indicalo en la cadena SELECT
    '                   También puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    Public Function Actualizar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el ItemsxDFID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_ItemsxDF WHERE ItemsxDFID = " & Me.ItemsxDFID.ToString()
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(sel As String) As String
        ' Actualiza los datos indicados
        ' El parámetro, que es una cadena de selección, indicará el criterio de actualización
        '
        ' En caso de error, devolverá la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_ItemsxDF")
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
        ''       Yo compruebo que sea un campo llamado ItemsxDFID, pero en tu caso puede ser otro
        ''       Ese campo, (en mi caso ItemsxDFID) será el que hay que poner al final junto al WHERE.
        'sCommand = "UPDATE IDF_ItemsxDF SET ItemID = @ItemID, DFDescripID = @DFDescripID, Descripcion1 = @Descripcion1, TotalBruto = @TotalBruto, DescuentoMonto = @DescuentoMonto, ImpuestoMonto = @ImpuestoMonto, TotalNeto = @TotalNeto, ImptoCodigo = @ImptoCodigo, RetencionID = @RetencionID, RetencionMonto = @RetencionMonto  WHERE (ItemsxDFID = @ItemsxDFID)"
        'da.UpdateCommand = New SqlCommand(sCommand, cnn)
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@ItemsxDFID", SqlDbType.Int, 0, "ItemsxDFID")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@ItemID", SqlDbType.Int, 0, "ItemID")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@DFDescripID", SqlDbType.Int, 0, "DFDescripID")
        'da.UpdateCommand.Parameters.Add("@Descripcion1", SqlDbType.NVarChar, 50, "Descripcion1")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@TotalBruto", SqlDbType.Decimal, 0, "TotalBruto")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@DescuentoMonto", SqlDbType.Decimal, 0, "DescuentoMonto")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@ImpuestoMonto", SqlDbType.Decimal, 0, "ImpuestoMonto")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@TotalNeto", SqlDbType.Decimal, 0, "TotalNeto")
        'da.UpdateCommand.Parameters.Add("@ImptoCodigo", SqlDbType.NVarChar, 10, "ImptoCodigo")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@RetencionID", SqlDbType.Int, 0, "RetencionID")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@RetencionMonto", SqlDbType.Decimal, 0, "RetencionMonto")
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
            IDF_ItemsxDF2Row(Me, dt.Rows(0))
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
        Dim dt As New DataTable("IDF_ItemsxDF")
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
        ''       Yo compruebo que sea un campo llamado ItemsxDFID, pero en tu caso puede ser otro
        'sCommand = "INSERT INTO IDF_ItemsxDF (ItemID, DFDescripID, Descripcion1, TotalBruto, DescuentoMonto, ImpuestoMonto, TotalNeto, ImptoCodigo, RetencionID, RetencionMonto)  VALUES(@ItemID, @DFDescripID, @Descripcion1, @TotalBruto, @DescuentoMonto, @ImpuestoMonto, @TotalNeto, @ImptoCodigo, @RetencionID, @RetencionMonto)"
        'da.InsertCommand = New SqlCommand(sCommand, cnn)
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@ItemsxDFID", SqlDbType.Int, 0, "ItemsxDFID")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@ItemID", SqlDbType.Int, 0, "ItemID")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@DFDescripID", SqlDbType.Int, 0, "DFDescripID")
        'da.InsertCommand.Parameters.Add("@Descripcion1", SqlDbType.NVarChar, 50, "Descripcion1")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@TotalBruto", SqlDbType.Decimal, 0, "TotalBruto")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@DescuentoMonto", SqlDbType.Decimal, 0, "DescuentoMonto")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@ImpuestoMonto", SqlDbType.Decimal, 0, "ImpuestoMonto")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@TotalNeto", SqlDbType.Decimal, 0, "TotalNeto")
        'da.InsertCommand.Parameters.Add("@ImptoCodigo", SqlDbType.NVarChar, 10, "ImptoCodigo")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@RetencionID", SqlDbType.Int, 0, "RetencionID")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@RetencionMonto", SqlDbType.Decimal, 0, "RetencionMonto")
        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoIDF_ItemsxDF(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo IDF_ItemsxDF"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el ItemsxDFID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_ItemsxDF WHERE ItemsxDFID = " & Me.ItemsxDFID.ToString()
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_ItemsxDF")
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
        ''       Yo compruebo que sea un campo llamado ItemsxDFID, pero en tu caso puede ser otro
        'sCommand = "DELETE FROM IDF_ItemsxDF WHERE (ItemsxDFID = @p1)"
        'da.DeleteCommand = New SqlCommand(sCommand, cnn)
        '' TODO: Comprobar el tipo de datos a usar...
        'da.DeleteCommand.Parameters.Add("@p1", SqlDbType.Int, 0, "ItemsxDFID")
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
    Public Shared Function TotalXDFID(nDFDescripID As Integer, cValor As String) As Double

        If nDFDescripID = 0 Then
            Return 0
        End If

        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim nRes As Double = 0.0
        Dim oIDF_ProdXFact As IDF_ProdXFact = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_ItemsXDF")
        Dim sel As String = "SELECT Sum(TotalNeto) As TotalNeto FROM IDF_ItemsXDF WHERE DFDescripID='" & nDFDescripID & "'"
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)

        Try
            nRes = CDbl(IIf(cValor = "TotalNeto", dt.Rows(0).Item(0), 0))
        Catch ex As Exception
            nRes = 0
        End Try

        Return nRes
    End Function

End Class
