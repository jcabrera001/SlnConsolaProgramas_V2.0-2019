'------------------------------------------------------------------------------
' Clase IDF_Productos generada automáticamente con CrearClaseSQL
' de la tabla 'IDF_Productos' de la base 'Finanzas'
' Fecha: 25/Mar/2015 07:59:28
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
Public Class IDF_Productos
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _ProdCodigo As System.String
    Private _Descripcion As System.String
    Private _UnidMed As System.String
    Private _Precio As System.Decimal
    Private _ImptoCodigo As System.String
    Private _CategoriaID As System.Int32
    Public query As String
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
    Public Property ProdCodigo() As System.String
        Get
            Return ajustarAncho(_ProdCodigo, 10)
        End Get
        Set(value As System.String)
            _ProdCodigo = value
        End Set
    End Property
    Public Property Descripcion() As System.String
        Get
            Return ajustarAncho(_Descripcion, 50)
        End Get
        Set(value As System.String)
            _Descripcion = value
        End Set
    End Property
    Public Property UnidMed() As System.String
        Get
            Return ajustarAncho(_UnidMed, 10)
        End Get
        Set(value As System.String)
            _UnidMed = value
        End Set
    End Property
    Public Property Precio() As System.Decimal
        Get
            Return _Precio
        End Get
        Set(value As System.Decimal)
            _Precio = value
        End Set
    End Property
    Public Property ImptoCodigo() As System.String
        Get
            Return ajustarAncho(_ImptoCodigo, 30)
        End Get
        Set(value As System.String)
            _ImptoCodigo = value
        End Set
    End Property

    Public Property CategoriaID() As System.Int32
        Get
            Return _CategoriaID
        End Get
        Set(value As System.Int32)
            _CategoriaID = value
        End Set
    End Property
    '
    Default Public Property Item(index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.ProdCodigo.ToString()
            ElseIf index = 1 Then
                Return Me.Descripcion.ToString()
            ElseIf index = 2 Then
                Return Me.UnidMed.ToString()
            ElseIf index = 3 Then
                Return Me.Precio.ToString()
            ElseIf index = 4 Then
                Return Me.ImptoCodigo.ToString()
            ElseIf index = 5 Then
                Return Me.CategoriaID.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = 0 Then
                Me.ProdCodigo = value
            ElseIf index = 1 Then
                Me.Descripcion = value
            ElseIf index = 2 Then
                Me.UnidMed = value
            ElseIf index = 3 Then
                Try
                    Me.Precio = System.Decimal.Parse("0" & value)
                Catch
                    Me.Precio = System.Decimal.Parse("0")
                End Try
            ElseIf index = 4 Then
                Me.ImptoCodigo = value
            ElseIf index = 5 Then
                Try
                    Me.CategoriaID = System.Int32.Parse(value)
                Catch
                    Me.CategoriaID = System.Int32.Parse("0")
                End Try
            End If
        End Set
    End Property
    Default Public Property Item(index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde al nombre de la columna)
        Get
            If index = "ProdCodigo" Then
                Return Me.ProdCodigo.ToString()
            ElseIf index = "Descripcion" Then
                Return Me.Descripcion.ToString()
            ElseIf index = "UnidMed" Then
                Return Me.UnidMed.ToString()
            ElseIf index = "Precio" Then
                Return Me.Precio.ToString()
            ElseIf index = "ImptoCodigo" Then
                Return Me.ImptoCodigo.ToString()
            ElseIf index = "CategoriaID" Then
                Return Me.CategoriaID.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = "ProdCodigo" Then
                Me.ProdCodigo = value
            ElseIf index = "Descripcion" Then
                Me.Descripcion = value
            ElseIf index = "UnidMed" Then
                Me.UnidMed = value
            ElseIf index = "Precio" Then
                Try
                    Me.Precio = System.Decimal.Parse("0" & value)
                Catch
                    Me.Precio = System.Decimal.Parse("0")
                End Try
            ElseIf index = "ImptoCodigo" Then
                Me.ImptoCodigo = value
            ElseIf index = "CategoriaID" Then
                Try
                    Me.CategoriaID = System.Int32.Parse(value)
                Catch
                    Me.CategoriaID = System.Int32.Parse("0")
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
    Public Shared CadenaSelect As String = "SELECT * FROM IDF_Productos"
    '
    Public Sub New()
    End Sub
    Public Sub New(conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto IDF_Productos
    Private Shared Function row2IDF_Productos(r As DataRow) As IDF_Productos
        ' asigna a un objeto IDF_Productos los datos del dataRow indicado
        Dim oIDF_Productos As New IDF_Productos
        '
        oIDF_Productos.ProdCodigo = r("ProdCodigo").ToString()
        oIDF_Productos.Descripcion = r("Descripcion").ToString()
        oIDF_Productos.UnidMed = r("UnidMed").ToString()
        oIDF_Productos.Precio = System.Decimal.Parse("0" & r("Precio").ToString())
        oIDF_Productos.ImptoCodigo = r("ImptoCodigo").ToString()
        oIDF_Productos.CategoriaID = System.Int32.Parse("0" & r("CategoriaID").ToString())
        '
        Return oIDF_Productos
    End Function
    '
    ' asigna un objeto IDF_Productos a la fila indicada
    Private Shared Sub IDF_Productos2Row(oIDF_Productos As IDF_Productos, r As DataRow)
        ' asigna un objeto IDF_Productos al dataRow indicado
        r("ProdCodigo") = oIDF_Productos.ProdCodigo
        r("Descripcion") = oIDF_Productos.Descripcion
        r("UnidMed") = oIDF_Productos.UnidMed
        r("Precio") = oIDF_Productos.Precio
        r("ImptoCodigo") = oIDF_Productos.ImptoCodigo
        r("CategoriaID") = oIDF_Productos.CategoriaID
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto IDF_Productos
    Private Shared Sub nuevoIDF_Productos(dt As DataTable, oIDF_Productos As IDF_Productos)
        ' Crear un nuevo IDF_Productos
        Dim dr As DataRow = dt.NewRow()
        Dim oI As IDF_Productos = row2IDF_Productos(dr)
        '
        oI.ProdCodigo = oIDF_Productos.ProdCodigo
        oI.Descripcion = oIDF_Productos.Descripcion
        oI.UnidMed = oIDF_Productos.UnidMed
        oI.Precio = oIDF_Productos.Precio
        oI.ImptoCodigo = oIDF_Productos.ImptoCodigo
        oI.CategoriaID = oIDF_Productos.CategoriaID
        '
        IDF_Productos2Row(oI, dr)
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
        ' devuelve una tabla con los datos de la tabla IDF_Productos
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_Productos")
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

    Public Function TablaProdCategorias(idx As Integer) As DataTable
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_Productos")
        '
        Try
            If idx = 1 Then
                'query = "SELECT a.*,b.Descripcion AS Categoria " & _
                '        "FROM IDF_Productos a LEFT OUTER JOIN IDF_CatProductos b ON " & _
                '        "a.CategoriaID = b.CategoriaID"
                query = "SELECT dbo.IDF_Productos.ProdCodigo, dbo.IDF_Productos.Descripcion, dbo.IDF_Productos.UnidMed," & _
                        "dbo.IDF_Productos.Precio, dbo.IDF_Productos.ImptoCodigo, " & _
                        "dbo.IDF_Productos.CategoriaID, dbo.IDF_CatProductos.Descripcion AS Categoria," & _
                        "dbo.IDF_UnidMeds.Descripcion AS UnidMedida " & _
                        "FROM dbo.IDF_Productos INNER JOIN " & _
                        "dbo.IDF_CatProductos ON dbo.IDF_Productos.CategoriaID = dbo.IDF_CatProductos.CategoriaID " & _
                        "LEFT OUTER JOIN dbo.IDF_UnidMeds ON dbo.IDF_Productos.UnidMed = dbo.IDF_UnidMeds.UnidMedCodigo "
            End If

            da = New SqlDataAdapter(query, cadenaConexion)
            da.Fill(dt)
        Catch
            Return Nothing
        End Try
        '
        Return dt
    End Function
    '
    Public Shared Function Buscar(sWhere As String) As IDF_Productos
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oIDF_Productos As IDF_Productos = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_Productos")
        Dim sel As String = "SELECT * FROM IDF_Productos WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oIDF_Productos = row2IDF_Productos(dt.Rows(0))
        End If
        Return oIDF_Productos
    End Function
    '
    ' Actualizar: Actualiza los datos en la tabla usando la instancia actual
    '             Si la instancia no hace referencia a un registro existente, se creará uno nuevo
    '             Para comprobar si el objeto en memoria coincide con uno existente,
    '             se comprueba si el ProdCodigo existe en la tabla.
    '             TODO: Si en lugar de ProdCodigo usas otro campo, indicalo en la cadena SELECT
    '                   También puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    Public Function Actualizar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el ProdCodigo que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_Productos WHERE ProdCodigo = '" & Me.ProdCodigo & "'"
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(sel As String) As String
        ' Actualiza los datos indicados
        ' El parámetro, que es una cadena de selección, indicará el criterio de actualización
        '
        ' En caso de error, devolverá la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_Productos")
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
        ''       Yo compruebo que sea un campo llamado ProdCodigo, pero en tu caso puede ser otro
        ''       Ese campo, (en mi caso ProdCodigo) será el que hay que poner al final junto al WHERE.
        'sCommand = "UPDATE IDF_Productos SET Descripcion = @Descripcion, UnidMed = @UnidMed, Precio = @Precio, ImptoCodigo = @ImptoCodigo  WHERE (ProdCodigo = @ProdCodigo)"
        'da.UpdateCommand = New SqlCommand(sCommand, cnn)
        'da.UpdateCommand.Parameters.Add("@ProdCodigo", SqlDbType.NVarChar, 10, "ProdCodigo")
        'da.UpdateCommand.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 50, "Descripcion")
        'da.UpdateCommand.Parameters.Add("@UnidMed", SqlDbType.NVarChar, 10, "UnidMed")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@Precio", SqlDbType.Decimal, 0, "Precio")
        'da.UpdateCommand.Parameters.Add("@ImptoCodigo", SqlDbType.NVarChar, 30, "ImptoCodigo")
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
            IDF_Productos2Row(Me, dt.Rows(0))
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
        Dim dt As New DataTable("IDF_Productos")
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
        ''       Yo compruebo que sea un campo llamado ProdCodigo, pero en tu caso puede ser otro
        'sCommand = "INSERT INTO IDF_Productos (ProdCodigo, Descripcion, UnidMed, Precio, ImptoCodigo)  VALUES(@ProdCodigo, @Descripcion, @UnidMed, @Precio, @ImptoCodigo)"
        'da.InsertCommand = New SqlCommand(sCommand, cnn)
        'da.InsertCommand.Parameters.Add("@ProdCodigo", SqlDbType.NVarChar, 10, "ProdCodigo")
        'da.InsertCommand.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 50, "Descripcion")
        'da.InsertCommand.Parameters.Add("@UnidMed", SqlDbType.NVarChar, 10, "UnidMed")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@Precio", SqlDbType.Decimal, 0, "Precio")
        'da.InsertCommand.Parameters.Add("@ImptoCodigo", SqlDbType.NVarChar, 30, "ImptoCodigo")
        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoIDF_Productos(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo IDF_Productos"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el ProdCodigo que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_Productos WHERE ProdCodigo = '" & Me.ProdCodigo & "'"
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_Productos")
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
        ''       Yo compruebo que sea un campo llamado ProdCodigo, pero en tu caso puede ser otro
        'sCommand = "DELETE FROM IDF_Productos WHERE (ProdCodigo = @p1)"
        'da.DeleteCommand = New SqlCommand(sCommand, cnn)
        'da.DeleteCommand.Parameters.Add("@p1", SqlDbType.NVarChar, 10, "ProdCodigo")
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
