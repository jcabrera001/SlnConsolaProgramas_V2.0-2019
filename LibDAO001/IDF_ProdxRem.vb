'------------------------------------------------------------------------------
' Clase IDF_ProdxRem generada automáticamente con CrearClaseSQL
' de la tabla 'IDF_ProdxRem' de la base 'Finanzas'
' Fecha: 06/May/2015 08:54:26
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
Public Class IDF_ProdxRem
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _ProdxRemID As System.Int32
    Private _ProdCodigo As System.String
    Private _RemisionID As System.Int32
    Private _Cantidad As System.Double
    Private _UnidMedCodigo As System.String
    Private _Descrip1 As System.String
    Private _Descrip2 As System.String
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
    Public Property ProdxRemID() As System.Int32
        Get
            Return  _ProdxRemID
        End Get
        Set(value As System.Int32)
            _ProdxRemID = value
        End Set
    End Property
    Public Property ProdCodigo() As System.String
        Get
            Return ajustarAncho(_ProdCodigo,25)
        End Get
        Set(value As System.String)
            _ProdCodigo = value
        End Set
    End Property
    Public Property RemisionID() As System.Int32
        Get
            Return  _RemisionID
        End Get
        Set(value As System.Int32)
            _RemisionID = value
        End Set
    End Property
    Public Property Cantidad() As System.Double
        Get
            Return  _Cantidad
        End Get
        Set(value As System.Double)
            _Cantidad = value
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
            Return ajustarAncho(_Descrip1,100)
        End Get
        Set(value As System.String)
            _Descrip1 = value
        End Set
    End Property
    Public Property Descrip2() As System.String
        Get
            Return ajustarAncho(_Descrip2,100)
        End Get
        Set(value As System.String)
            _Descrip2 = value
        End Set
    End Property
    '
    Public Default Property Item(index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.ProdxRemID.ToString()
            ElseIf index = 1 Then
                Return Me.ProdCodigo.ToString()
            ElseIf index = 2 Then
                Return Me.RemisionID.ToString()
            ElseIf index = 3 Then
                Return Me.Cantidad.ToString()
            ElseIf index = 4 Then
                Return Me.UnidMedCodigo.ToString()
            ElseIf index = 5 Then
                Return Me.Descrip1.ToString()
            ElseIf index = 6 Then
                Return Me.Descrip2.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = 0 Then
                Try
                    Me.ProdxRemID = System.Int32.Parse("0" & value)
                Catch
                    Me.ProdxRemID = System.Int32.Parse("0")
                End Try
            ElseIf index = 1 Then
                Me.ProdCodigo = value
            ElseIf index = 2 Then
                Try
                    Me.RemisionID = System.Int32.Parse("0" & value)
                Catch
                    Me.RemisionID = System.Int32.Parse("0")
                End Try
            ElseIf index = 3 Then
                Try
                    Me.Cantidad = System.Double.Parse("0" & value)
                Catch
                    Me.Cantidad = System.Double.Parse("0")
                End Try
            ElseIf index = 4 Then
                Me.UnidMedCodigo = value
            ElseIf index = 5 Then
                Me.Descrip1 = value
            ElseIf index = 6 Then
                Me.Descrip2 = value
            End If
        End Set
    End Property
    Public Default Property Item(index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde al nombre de la columna)
        Get
            If index = "ProdxRemID" Then
                Return Me.ProdxRemID.ToString()
            ElseIf index = "ProdCodigo" Then
                Return Me.ProdCodigo.ToString()
            ElseIf index = "RemisionID" Then
                Return Me.RemisionID.ToString()
            ElseIf index = "Cantidad" Then
                Return Me.Cantidad.ToString()
            ElseIf index = "UnidMedCodigo" Then
                Return Me.UnidMedCodigo.ToString()
            ElseIf index = "Descrip1" Then
                Return Me.Descrip1.ToString()
            ElseIf index = "Descrip2" Then
                Return Me.Descrip2.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = "ProdxRemID" Then
                Try
                    Me.ProdxRemID = System.Int32.Parse("0" & value)
                Catch
                    Me.ProdxRemID = System.Int32.Parse("0")
                End Try
            ElseIf index = "ProdCodigo" Then
                Me.ProdCodigo = value
            ElseIf index = "RemisionID" Then
                Try
                    Me.RemisionID = System.Int32.Parse("0" & value)
                Catch
                    Me.RemisionID = System.Int32.Parse("0")
                End Try
            ElseIf index = "Cantidad" Then
                Try
                    Me.Cantidad = System.Double.Parse("0" & value)
                Catch
                    Me.Cantidad = System.Double.Parse("0")
                End Try
            ElseIf index = "UnidMedCodigo" Then
                Me.UnidMedCodigo = value
            ElseIf index = "Descrip1" Then
                Me.Descrip1 = value
            ElseIf index = "Descrip2" Then
                Me.Descrip2 = value
            End If
        End Set
    End Property
    '
    ' Campos y métodos compartidos (estáticos) para gestionar la base de datos
    '
    ' La cadena de conexión a la base de datos
    Private Shared cadenaConexion As String = "Data Source=amigodb\amigodb; Initial Catalog=Finanzas; user id=rptuser; password=MiTo1380"
    ' La cadena de selección
    Public Shared CadenaSelect As String = "SELECT * FROM IDF_ProdxRem"
    '
    Public Sub New()
    End Sub
    Public Sub New(conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto IDF_ProdxRem
    Private Shared Function row2IDF_ProdxRem(r As DataRow) As IDF_ProdxRem
        ' asigna a un objeto IDF_ProdxRem los datos del dataRow indicado
        Dim oIDF_ProdxRem As New IDF_ProdxRem
        '
        oIDF_ProdxRem.ProdxRemID = System.Int32.Parse("0" & r("ProdxRemID").ToString())
        oIDF_ProdxRem.ProdCodigo = r("ProdCodigo").ToString()
        oIDF_ProdxRem.RemisionID = System.Int32.Parse("0" & r("RemisionID").ToString())
        oIDF_ProdxRem.Cantidad = System.Double.Parse("0" & r("Cantidad").ToString())
        oIDF_ProdxRem.UnidMedCodigo = r("UnidMedCodigo").ToString()
        oIDF_ProdxRem.Descrip1 = r("Descrip1").ToString()
        oIDF_ProdxRem.Descrip2 = r("Descrip2").ToString()
        '
        Return oIDF_ProdxRem
    End Function
    '
    ' asigna un objeto IDF_ProdxRem a la fila indicada
    Private Shared Sub IDF_ProdxRem2Row(oIDF_ProdxRem As IDF_ProdxRem, r As DataRow)
        ' asigna un objeto IDF_ProdxRem al dataRow indicado
        ' TODO: Comprueba si esta asignación debe hacerse
        '       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        'r("ProdxRemID") = oIDF_ProdxRem.ProdxRemID
        r("ProdCodigo") = oIDF_ProdxRem.ProdCodigo
        r("RemisionID") = oIDF_ProdxRem.RemisionID
        r("Cantidad") = oIDF_ProdxRem.Cantidad
        r("UnidMedCodigo") = oIDF_ProdxRem.UnidMedCodigo
        r("Descrip1") = oIDF_ProdxRem.Descrip1
        r("Descrip2") = oIDF_ProdxRem.Descrip2
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto IDF_ProdxRem
    Private Shared Sub nuevoIDF_ProdxRem(dt As DataTable, oIDF_ProdxRem As IDF_ProdxRem)
        ' Crear un nuevo IDF_ProdxRem
        Dim dr As DataRow = dt.NewRow()
        Dim oI As IDF_ProdxRem = row2IDF_ProdxRem(dr)
        '
        oI.ProdxRemID = oIDF_ProdxRem.ProdxRemID
        oI.ProdCodigo = oIDF_ProdxRem.ProdCodigo
        oI.RemisionID = oIDF_ProdxRem.RemisionID
        oI.Cantidad = oIDF_ProdxRem.Cantidad
        oI.UnidMedCodigo = oIDF_ProdxRem.UnidMedCodigo
        oI.Descrip1 = oIDF_ProdxRem.Descrip1
        oI.Descrip2 = oIDF_ProdxRem.Descrip2
        '
        IDF_ProdxRem2Row(oI, dr)
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
        ' devuelve una tabla con los datos de la tabla IDF_ProdxRem
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_ProdxRem")
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
    Public Shared Function Buscar(sWhere As String) As IDF_ProdxRem
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oIDF_ProdxRem As IDF_ProdxRem = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_ProdxRem")
        Dim sel As String = "SELECT * FROM IDF_ProdxRem WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oIDF_ProdxRem = row2IDF_ProdxRem(dt.Rows(0))
        End If
        Return oIDF_ProdxRem
    End Function
    '
    ' Actualizar: Actualiza los datos en la tabla usando la instancia actual
    '             Si la instancia no hace referencia a un registro existente, se creará uno nuevo
    '             Para comprobar si el objeto en memoria coincide con uno existente,
    '             se comprueba si el ProdxRemID existe en la tabla.
    '             TODO: Si en lugar de ProdxRemID usas otro campo, indicalo en la cadena SELECT
    '                   También puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    Public Function Actualizar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el ProdxRemID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_ProdxRem WHERE ProdxRemID = " & Me.ProdxRemID.ToString()
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(sel As String) As String
        ' Actualiza los datos indicados
        ' El parámetro, que es una cadena de selección, indicará el criterio de actualización
        '
        ' En caso de error, devolverá la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_ProdxRem")
        '
        cnn = New SqlConnection(cadenaConexion)
        'da = New SqlDataAdapter(CadenaSelect, cnn)
        da = New SqlDataAdapter(sel, cnn)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        '
        '-------------------------------------------
        ' Esta no es la más óptima, pero funcionará
        '-------------------------------------------
        'Dim cb As New SqlCommandBuilder(da)
        'da.UpdateCommand = cb.GetUpdateCommand()
        '
        '--------------------------------------------------------------------
        ' Esta está más optimizada pero debes comprobar que funciona bien...
        '--------------------------------------------------------------------
        Dim sCommand As String
        '
        ' El comando UPDATE
        ' TODO: Comprobar cual es el campo de índice principal (sin duplicados)
        '       Yo compruebo que sea un campo llamado ProdxRemID, pero en tu caso puede ser otro
        '       Ese campo, (en mi caso ProdxRemID) será el que hay que poner al final junto al WHERE.
        sCommand = "UPDATE IDF_ProdxRem SET ProdCodigo = @ProdCodigo, RemisionID = @RemisionID, Cantidad = @Cantidad, UnidMedCodigo = @UnidMedCodigo, Descrip1 = @Descrip1, Descrip2 = @Descrip2  WHERE (ProdxRemID = @ProdxRemID)"
        da.UpdateCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@ProdxRemID", SqlDbType.Int, 0, "ProdxRemID")
        da.UpdateCommand.Parameters.Add("@ProdCodigo", SqlDbType.NVarChar, 25, "ProdCodigo")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@RemisionID", SqlDbType.Int, 0, "RemisionID")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@Cantidad", SqlDbType.Float, 0, "Cantidad")
        da.UpdateCommand.Parameters.Add("@UnidMedCodigo", SqlDbType.NVarChar, 10, "UnidMedCodigo")
        da.UpdateCommand.Parameters.Add("@Descrip1", SqlDbType.NVarChar, 100, "Descrip1")
        da.UpdateCommand.Parameters.Add("@Descrip2", SqlDbType.NVarChar, 100, "Descrip2")
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
            IDF_ProdxRem2Row(Me, dt.Rows(0))
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
        Dim dt As New DataTable("IDF_ProdxRem")
        '
        cnn = New SqlConnection(cadenaConexion)
        da = New SqlDataAdapter(CadenaSelect, cnn)
        'da = New SqlDataAdapter(CadenaSelect, cadenaConexion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        '
        '-------------------------------------------
        ' Esta no es la más óptima, pero funcionará
        '-------------------------------------------
        'Dim cb As New SqlCommandBuilder(da)
        'da.InsertCommand = cb.GetInsertCommand()
        '
        '--------------------------------------------------------------------
        ' Esta está más optimizada pero debes comprobar que funciona bien...
        '--------------------------------------------------------------------
        Dim sCommand As String
        '
        ' El comando INSERT
        ' TODO: No incluir el campo de clave primaria incremental
        '       Yo compruebo que sea un campo llamado ProdxRemID, pero en tu caso puede ser otro
        sCommand = "INSERT INTO IDF_ProdxRem (ProdCodigo, RemisionID, Cantidad, UnidMedCodigo, Descrip1, Descrip2)  VALUES(@ProdCodigo, @RemisionID, @Cantidad, @UnidMedCodigo, @Descrip1, @Descrip2)"
        da.InsertCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@ProdxRemID", SqlDbType.Int, 0, "ProdxRemID")
        da.InsertCommand.Parameters.Add("@ProdCodigo", SqlDbType.NVarChar, 25, "ProdCodigo")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@RemisionID", SqlDbType.Int, 0, "RemisionID")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@Cantidad", SqlDbType.Float, 0, "Cantidad")
        da.InsertCommand.Parameters.Add("@UnidMedCodigo", SqlDbType.NVarChar, 10, "UnidMedCodigo")
        da.InsertCommand.Parameters.Add("@Descrip1", SqlDbType.NVarChar, 100, "Descrip1")
        da.InsertCommand.Parameters.Add("@Descrip2", SqlDbType.NVarChar, 100, "Descrip2")
        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoIDF_ProdxRem(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo IDF_ProdxRem"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el ProdxRemID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_ProdxRem WHERE ProdxRemID = " & Me.ProdxRemID.ToString()
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_ProdxRem")
        '
        cnn = New SqlConnection(cadenaConexion)
        da = New SqlDataAdapter(sel, cnn)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        '
        '-------------------------------------------
        ' Esta no es la más óptima, pero funcionará
        '-------------------------------------------
        'Dim cb As New SqlCommandBuilder(da)
        'da.DeleteCommand = cb.GetDeleteCommand()
        '
        '
        '--------------------------------------------------------------------
        ' Esta está más optimizada pero debes comprobar que funciona bien...
        '--------------------------------------------------------------------
        Dim sCommand As String
        '
        ' El comando DELETE
        ' TODO: Sólo incluir el campo de clave primaria incremental
        '       Yo compruebo que sea un campo llamado ProdxRemID, pero en tu caso puede ser otro
        sCommand = "DELETE FROM IDF_ProdxRem WHERE (ProdxRemID = @p1)"
        da.DeleteCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.DeleteCommand.Parameters.Add("@p1", SqlDbType.Int, 0, "ProdxRemID")
        da.DeleteCommand.Parameters.Add("@p2", SqlDbType.Int, 0, "")
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
