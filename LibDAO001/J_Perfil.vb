'------------------------------------------------------------------------------
' Clase J_Perfil generada automáticamente con CrearClaseSQL
' de la tabla 'J_Perfil' de la base 'Produccion'
' Fecha: 16/Apr/2015 08:37:47
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
Public Class J_Perfil
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _id As System.Decimal
    Private _nombrePC As System.String
    Private _carpetaRaiz As System.String
    Private _activo As System.Boolean
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
    Public Property id() As System.Decimal
        Get
            Return  _id
        End Get
        Set(value As System.Decimal)
            _id = value
        End Set
    End Property
    Public Property nombrePC() As System.String
        Get
            Return ajustarAncho(_nombrePC,50)
        End Get
        Set(value As System.String)
            _nombrePC = value
        End Set
    End Property
    Public Property carpetaRaiz() As System.String
        Get
            Return ajustarAncho(_carpetaRaiz,50)
        End Get
        Set(value As System.String)
            _carpetaRaiz = value
        End Set
    End Property
    Public Property activo() As System.Boolean
        Get
            Return  _activo
        End Get
        Set(value As System.Boolean)
            _activo = value
        End Set
    End Property
    '
    Public Default Property Item(index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.id.ToString()
            ElseIf index = 1 Then
                Return Me.nombrePC.ToString()
            ElseIf index = 2 Then
                Return Me.carpetaRaiz.ToString()
            ElseIf index = 3 Then
                Return Me.activo.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = 0 Then
                Try
                    Me.id = System.Decimal.Parse("0" & value)
                Catch
                    Me.id = System.Decimal.Parse("0")
                End Try
            ElseIf index = 1 Then
                Me.nombrePC = value
            ElseIf index = 2 Then
                Me.carpetaRaiz = value
            ElseIf index = 3 Then
                Try
                    Me.activo = System.Boolean.Parse(value)
                Catch
                    Me.activo = False
                End Try
            End If
        End Set
    End Property
    Public Default Property Item(index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde al nombre de la columna)
        Get
            If index = "id" Then
                Return Me.id.ToString()
            ElseIf index = "nombrePC" Then
                Return Me.nombrePC.ToString()
            ElseIf index = "carpetaRaiz" Then
                Return Me.carpetaRaiz.ToString()
            ElseIf index = "activo" Then
                Return Me.activo.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = "id" Then
                Try
                    Me.id = System.Decimal.Parse("0" & value)
                Catch
                    Me.id = System.Decimal.Parse("0")
                End Try
            ElseIf index = "nombrePC" Then
                Me.nombrePC = value
            ElseIf index = "carpetaRaiz" Then
                Me.carpetaRaiz = value
            ElseIf index = "activo" Then
                Try
                    Me.activo = System.Boolean.Parse(value)
                Catch
                    Me.activo = False
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
    Public Shared CadenaSelect As String = "SELECT * FROM J_Perfil"
    '
    Public Sub New()
    End Sub
    Public Sub New(conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto J_Perfil
    Private Shared Function row2J_Perfil(r As DataRow) As J_Perfil
        ' asigna a un objeto J_Perfil los datos del dataRow indicado
        Dim oJ_Perfil As New J_Perfil
        '
        oJ_Perfil.id = System.Decimal.Parse("0" & r("id").ToString())
        oJ_Perfil.nombrePC = r("nombrePC").ToString()
        oJ_Perfil.carpetaRaiz = r("carpetaRaiz").ToString()
        Try
            oJ_Perfil.activo = System.Boolean.Parse(r("activo").ToString())
        Catch
            oJ_Perfil.activo = False
        End Try
        '
        Return oJ_Perfil
    End Function
    '
    ' asigna un objeto J_Perfil a la fila indicada
    Private Shared Sub J_Perfil2Row(oJ_Perfil As J_Perfil, r As DataRow)
        ' asigna un objeto J_Perfil al dataRow indicado
        ' TODO: Comprueba si esta asignación debe hacerse
        '       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        'r("id") = oJ_Perfil.id
        r("nombrePC") = oJ_Perfil.nombrePC
        r("carpetaRaiz") = oJ_Perfil.carpetaRaiz
        r("activo") = oJ_Perfil.activo
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto J_Perfil
    Private Shared Sub nuevoJ_Perfil(dt As DataTable, oJ_Perfil As J_Perfil)
        ' Crear un nuevo J_Perfil
        Dim dr As DataRow = dt.NewRow()
        Dim oJ As J_Perfil = row2J_Perfil(dr)
        '
        oJ.id = oJ_Perfil.id
        oJ.nombrePC = oJ_Perfil.nombrePC
        oJ.carpetaRaiz = oJ_Perfil.carpetaRaiz
        oJ.activo = oJ_Perfil.activo
        '
        J_Perfil2Row(oJ, dr)
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
        ' devuelve una tabla con los datos de la tabla J_Perfil
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("J_Perfil")
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
    Public Shared Function Buscar(sWhere As String) As J_Perfil
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oJ_Perfil As J_Perfil = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("J_Perfil")
        Dim sel As String = "SELECT * FROM J_Perfil WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oJ_Perfil = row2J_Perfil(dt.Rows(0))
        End If
        Return oJ_Perfil
    End Function
    '
    ' Actualizar: Actualiza los datos en la tabla usando la instancia actual
    '             Si la instancia no hace referencia a un registro existente, se creará uno nuevo
    '             Para comprobar si el objeto en memoria coincide con uno existente,
    '             se comprueba si el id existe en la tabla.
    '             TODO: Si en lugar de id usas otro campo, indicalo en la cadena SELECT
    '                   También puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    Public Function Actualizar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el id que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM J_Perfil WHERE id = " & Me.id.ToString()
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(sel As String) As String
        ' Actualiza los datos indicados
        ' El parámetro, que es una cadena de selección, indicará el criterio de actualización
        '
        ' En caso de error, devolverá la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("J_Perfil")
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
        ''       Yo compruebo que sea un campo llamado id, pero en tu caso puede ser otro
        ''       Ese campo, (en mi caso id) será el que hay que poner al final junto al WHERE.
        'sCommand = "UPDATE J_Perfil SET nombrePC = @nombrePC, carpetaRaiz = @carpetaRaiz, activo = @activo  WHERE (id = @id)"
        'da.UpdateCommand = New SqlCommand(sCommand, cnn)
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@id", SqlDbType.Decimal, 0, "id")
        'da.UpdateCommand.Parameters.Add("@nombrePC", SqlDbType.NVarChar, 50, "nombrePC")
        'da.UpdateCommand.Parameters.Add("@carpetaRaiz", SqlDbType.NVarChar, 50, "carpetaRaiz")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@activo", SqlDbType.Bit, 0, "activo")
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
            J_Perfil2Row(Me, dt.Rows(0))
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
        Dim dt As New DataTable("J_Perfil")
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
        ''       Yo compruebo que sea un campo llamado id, pero en tu caso puede ser otro
        'sCommand = "INSERT INTO J_Perfil (nombrePC, carpetaRaiz, activo)  VALUES(@nombrePC, @carpetaRaiz, @activo)"
        'da.InsertCommand = New SqlCommand(sCommand, cnn)
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@id", SqlDbType.Decimal, 0, "id")
        'da.InsertCommand.Parameters.Add("@nombrePC", SqlDbType.NVarChar, 50, "nombrePC")
        'da.InsertCommand.Parameters.Add("@carpetaRaiz", SqlDbType.NVarChar, 50, "carpetaRaiz")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@activo", SqlDbType.Bit, 0, "activo")
        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoJ_Perfil(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo J_Perfil"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el id que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM J_Perfil WHERE id = " & Me.id.ToString()
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("J_Perfil")
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
        ''       Yo compruebo que sea un campo llamado id, pero en tu caso puede ser otro
        'sCommand = "DELETE FROM J_Perfil WHERE (id = @p1)"
        'da.DeleteCommand = New SqlCommand(sCommand, cnn)
        '' TODO: Comprobar el tipo de datos a usar...
        'da.DeleteCommand.Parameters.Add("@p1", SqlDbType.Decimal, 0, "id")
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
