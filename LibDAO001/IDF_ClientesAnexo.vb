'------------------------------------------------------------------------------
' Clase IDF_ClientesAnexo generada automáticamente con CrearClaseSQL
' de la tabla 'IDF_ClientesAnexo' de la base 'Finanzas'
' Fecha: 10/Mar/2016 08:40:12
'
' ©Guillermo 'guille' Som, 2004-2016
'------------------------------------------------------------------------------
Option Strict On
Option Explicit On
'
Imports System
Imports System.Data
Imports System.Data.SqlClient
'
Public Class IDF_ClientesAnexo
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _TP As System.String
    Private _Direccion As System.String
    Private _EsOtrosComp As System.Boolean
    Private _RTN As System.String
    Private _DirCliente2 As System.String
    Private _DirCliente3 As System.String
    Private _TelCliente1 As System.String
    Private _TelCliente2 As System.String
    Private _EmailCliente1 As System.String
    Private _EmailCliente2 As System.String
    Private _RetencionID As System.String
    Private _ImptoCodigo As System.String
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
    Public Property Direccion() As System.String
        Get
            Return ajustarAncho(_Direccion,250)
        End Get
        Set(value As System.String)
            _Direccion = value
        End Set
    End Property
    Public Property EsOtrosComp() As System.Boolean
        Get
            Return  _EsOtrosComp
        End Get
        Set(value As System.Boolean)
            _EsOtrosComp = value
        End Set
    End Property
    Public Property RTN() As System.String
        Get
            Return ajustarAncho(_RTN,25)
        End Get
        Set(value As System.String)
            _RTN = value
        End Set
    End Property
    Public Property DirCliente2() As System.String
        Get
            Return ajustarAncho(_DirCliente2,250)
        End Get
        Set(value As System.String)
            _DirCliente2 = value
        End Set
    End Property
    Public Property DirCliente3() As System.String
        Get
            Return ajustarAncho(_DirCliente3,250)
        End Get
        Set(value As System.String)
            _DirCliente3 = value
        End Set
    End Property
    Public Property TelCliente1() As System.String
        Get
            Return ajustarAncho(_TelCliente1,25)
        End Get
        Set(value As System.String)
            _TelCliente1 = value
        End Set
    End Property
    Public Property TelCliente2() As System.String
        Get
            Return ajustarAncho(_TelCliente2,25)
        End Get
        Set(value As System.String)
            _TelCliente2 = value
        End Set
    End Property
    Public Property EmailCliente1() As System.String
        Get
            Return ajustarAncho(_EmailCliente1,100)
        End Get
        Set(value As System.String)
            _EmailCliente1 = value
        End Set
    End Property
    Public Property EmailCliente2() As System.String
        Get
            Return ajustarAncho(_EmailCliente2, 100)
        End Get
        Set(value As System.String)
            _EmailCliente2 = value
        End Set
    End Property
    Public Property RetencionID As String
        Get
            Return ajustarAncho(_RetencionID, 10)
        End Get
        Set(value As String)
            _RetencionID = value
        End Set
    End Property

    Public Property ImptoCodigo As String
        Get
            Return ajustarAncho(_ImptoCodigo, 10)
        End Get
        Set(value As String)
            _ImptoCodigo = value
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
                Return Me.Direccion.ToString()
            ElseIf index = 2 Then
                Return Me.EsOtrosComp.ToString()
            ElseIf index = 3 Then
                Return Me.RTN.ToString()
            ElseIf index = 4 Then
                Return Me.DirCliente2.ToString()
            ElseIf index = 5 Then
                Return Me.DirCliente3.ToString()
            ElseIf index = 6 Then
                Return Me.TelCliente1.ToString()
            ElseIf index = 7 Then
                Return Me.TelCliente2.ToString()
            ElseIf index = 8 Then
                Return Me.EmailCliente1.ToString()
            ElseIf index = 9 Then
                Return Me.EmailCliente2.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = 0 Then
                Me.TP = value
            ElseIf index = 1 Then
                Me.Direccion = value
            ElseIf index = 2 Then
                Try
                    Me.EsOtrosComp = System.Boolean.Parse(value)
                Catch
                    Me.EsOtrosComp = False
                End Try
            ElseIf index = 3 Then
                Me.RTN = value
            ElseIf index = 4 Then
                Me.DirCliente2 = value
            ElseIf index = 5 Then
                Me.DirCliente3 = value
            ElseIf index = 6 Then
                Me.TelCliente1 = value
            ElseIf index = 7 Then
                Me.TelCliente2 = value
            ElseIf index = 8 Then
                Me.EmailCliente1 = value
            ElseIf index = 9 Then
                Me.EmailCliente2 = value
            End If
        End Set
    End Property
    Public Default Property Item(index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde al nombre de la columna)
        Get
            If index = "TP" Then
                Return Me.TP.ToString()
            ElseIf index = "Direccion" Then
                Return Me.Direccion.ToString()
            ElseIf index = "EsOtrosComp" Then
                Return Me.EsOtrosComp.ToString()
            ElseIf index = "RTN" Then
                Return Me.RTN.ToString()
            ElseIf index = "DirCliente2" Then
                Return Me.DirCliente2.ToString()
            ElseIf index = "DirCliente3" Then
                Return Me.DirCliente3.ToString()
            ElseIf index = "TelCliente1" Then
                Return Me.TelCliente1.ToString()
            ElseIf index = "TelCliente2" Then
                Return Me.TelCliente2.ToString()
            ElseIf index = "EmailCliente1" Then
                Return Me.EmailCliente1.ToString()
            ElseIf index = "EmailCliente2" Then
                Return Me.EmailCliente2.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = "TP" Then
                Me.TP = value
            ElseIf index = "Direccion" Then
                Me.Direccion = value
            ElseIf index = "EsOtrosComp" Then
                Try
                    Me.EsOtrosComp = System.Boolean.Parse(value)
                Catch
                    Me.EsOtrosComp = False
                End Try
            ElseIf index = "RTN" Then
                Me.RTN = value
            ElseIf index = "DirCliente2" Then
                Me.DirCliente2 = value
            ElseIf index = "DirCliente3" Then
                Me.DirCliente3 = value
            ElseIf index = "TelCliente1" Then
                Me.TelCliente1 = value
            ElseIf index = "TelCliente2" Then
                Me.TelCliente2 = value
            ElseIf index = "EmailCliente1" Then
                Me.EmailCliente1 = value
            ElseIf index = "EmailCliente2" Then
                Me.EmailCliente2 = value
            End If
        End Set
    End Property

    '
    ' Campos y métodos compartidos (estáticos) para gestionar la base de datos
    '
    ' La cadena de conexión a la base de datos
    Private Shared cadenaConexion As String = "Data Source=amigodb\amigodb; Initial Catalog=Finanzas; user id=rptuser; password=MiTo1380"
    ' La cadena de selección
    Public Shared CadenaSelect As String = "SELECT * FROM IDF_ClientesAnexo"
    '
    Public Sub New()
    End Sub
    Public Sub New(conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto IDF_ClientesAnexo
    Private Shared Function row2IDF_ClientesAnexo(r As DataRow) As IDF_ClientesAnexo
        ' asigna a un objeto IDF_ClientesAnexo los datos del dataRow indicado
        Dim oIDF_ClientesAnexo As New IDF_ClientesAnexo
        '
        oIDF_ClientesAnexo.TP = r("TP").ToString()
        oIDF_ClientesAnexo.Direccion = r("Direccion").ToString()
        Try
            oIDF_ClientesAnexo.EsOtrosComp = System.Boolean.Parse(r("EsOtrosComp").ToString())
        Catch
            oIDF_ClientesAnexo.EsOtrosComp = False
        End Try
        oIDF_ClientesAnexo.RTN = r("RTN").ToString()
        oIDF_ClientesAnexo.DirCliente2 = r("DirCliente2").ToString()
        oIDF_ClientesAnexo.DirCliente3 = r("DirCliente3").ToString()
        oIDF_ClientesAnexo.TelCliente1 = r("TelCliente1").ToString()
        oIDF_ClientesAnexo.TelCliente2 = r("TelCliente2").ToString()
        oIDF_ClientesAnexo.EmailCliente1 = r("EmailCliente1").ToString()
        oIDF_ClientesAnexo.EmailCliente2 = r("EmailCliente2").ToString()
        oIDF_ClientesAnexo.RetencionID = r("RetencionID").ToString()
        oIDF_ClientesAnexo.ImptoCodigo = r("ImptoCodigo").ToString()
        '
        Return oIDF_ClientesAnexo
    End Function
    '
    ' asigna un objeto IDF_ClientesAnexo a la fila indicada
    Private Shared Sub IDF_ClientesAnexo2Row(oIDF_ClientesAnexo As IDF_ClientesAnexo, r As DataRow)
        ' asigna un objeto IDF_ClientesAnexo al dataRow indicado
        r("TP") = oIDF_ClientesAnexo.TP
        r("Direccion") = oIDF_ClientesAnexo.Direccion
        r("EsOtrosComp") = oIDF_ClientesAnexo.EsOtrosComp
        r("RTN") = oIDF_ClientesAnexo.RTN
        r("DirCliente2") = oIDF_ClientesAnexo.DirCliente2
        r("DirCliente3") = oIDF_ClientesAnexo.DirCliente3
        r("TelCliente1") = oIDF_ClientesAnexo.TelCliente1
        r("TelCliente2") = oIDF_ClientesAnexo.TelCliente2
        r("EmailCliente1") = oIDF_ClientesAnexo.EmailCliente1
        r("EmailCliente2") = oIDF_ClientesAnexo.EmailCliente2
        r("RetencionID") = oIDF_ClientesAnexo.RetencionID
        r("ImptoCodigo") = oIDF_ClientesAnexo.ImptoCodigo
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto IDF_ClientesAnexo
    Private Shared Sub nuevoIDF_ClientesAnexo(dt As DataTable, oIDF_ClientesAnexo As IDF_ClientesAnexo)
        ' Crear un nuevo IDF_ClientesAnexo
        Dim dr As DataRow = dt.NewRow()
        Dim oI As IDF_ClientesAnexo = row2IDF_ClientesAnexo(dr)
        '
        oI.TP = oIDF_ClientesAnexo.TP
        oI.Direccion = oIDF_ClientesAnexo.Direccion
        oI.EsOtrosComp = oIDF_ClientesAnexo.EsOtrosComp
        oI.RTN = oIDF_ClientesAnexo.RTN
        oI.DirCliente2 = oIDF_ClientesAnexo.DirCliente2
        oI.DirCliente3 = oIDF_ClientesAnexo.DirCliente3
        oI.TelCliente1 = oIDF_ClientesAnexo.TelCliente1
        oI.TelCliente2 = oIDF_ClientesAnexo.TelCliente2
        oI.EmailCliente1 = oIDF_ClientesAnexo.EmailCliente1
        oI.EmailCliente2 = oIDF_ClientesAnexo.EmailCliente2
        oI.RetencionID = oIDF_ClientesAnexo.RetencionID
        oI.ImptoCodigo = oIDF_ClientesAnexo.ImptoCodigo
        '
        IDF_ClientesAnexo2Row(oI, dr)
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
        ' devuelve una tabla con los datos de la tabla IDF_ClientesAnexo
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_ClientesAnexo")
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
    Public Shared Function Buscar(sWhere As String) As IDF_ClientesAnexo
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oIDF_ClientesAnexo As IDF_ClientesAnexo = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_ClientesAnexo")
        Dim sel As String = "SELECT * FROM IDF_ClientesAnexo WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oIDF_ClientesAnexo = row2IDF_ClientesAnexo(dt.Rows(0))
        End If
        Return oIDF_ClientesAnexo
    End Function
    '
    ' Actualizar: Actualiza los datos en la tabla usando la instancia actual
    '             Si la instancia no hace referencia a un registro existente, se creará uno nuevo
    '             Para comprobar si el objeto en memoria coincide con uno existente,
    '             se comprueba si el ID existe en la tabla.
    '             TODO: Si en lugar de ID usas otro campo, indicalo en la cadena SELECT
    '                   También puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    Public Function Actualizar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el ID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_ClientesAnexo WHERE TP = '" & Me.TP.ToString() + "'"
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(sel As String) As String
        ' Actualiza los datos indicados
        ' El parámetro, que es una cadena de selección, indicará el criterio de actualización
        '
        ' En caso de error, devolverá la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_ClientesAnexo")
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
        '       Yo compruebo que sea un campo llamado ID, pero en tu caso puede ser otro
        '       Ese campo, (en mi caso ID) será el que hay que poner al final junto al WHERE.
        sCommand = "UPDATE IDF_ClientesAnexo SET TP = @TP, Direccion = @Direccion, EsOtrosComp = @EsOtrosComp, RTN = @RTN, DirCliente2 = @DirCliente2, DirCliente3 = @DirCliente3, TelCliente1 = @TelCliente1, TelCliente2 = @TelCliente2, EmailCliente1 = @EmailCliente1, EmailCliente2 = @EmailCliente2, RetencionID = @RetencionID, ImptoCodigo = @ImptoCodigo  WHERE (TP = @TP)"
        da.UpdateCommand = New SqlCommand(sCommand, cnn)
        da.UpdateCommand.Parameters.Add("@TP", SqlDbType.NVarChar, 30, "TP")
        da.UpdateCommand.Parameters.Add("@Direccion", SqlDbType.NVarChar, 250, "Direccion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@EsOtrosComp", SqlDbType.Bit, 0, "EsOtrosComp")
        da.UpdateCommand.Parameters.Add("@RTN", SqlDbType.NVarChar, 25, "RTN")
        da.UpdateCommand.Parameters.Add("@DirCliente2", SqlDbType.NVarChar, 250, "DirCliente2")
        da.UpdateCommand.Parameters.Add("@DirCliente3", SqlDbType.NVarChar, 250, "DirCliente3")
        da.UpdateCommand.Parameters.Add("@TelCliente1", SqlDbType.NVarChar, 25, "TelCliente1")
        da.UpdateCommand.Parameters.Add("@TelCliente2", SqlDbType.NVarChar, 25, "TelCliente2")
        da.UpdateCommand.Parameters.Add("@EmailCliente1", SqlDbType.NVarChar, 100, "EmailCliente1")
        da.UpdateCommand.Parameters.Add("@EmailCliente2", SqlDbType.NVarChar, 100, "EmailCliente2")
        da.UpdateCommand.Parameters.Add("@RetencionID", SqlDbType.NVarChar, 100, "RetencionID")
        da.UpdateCommand.Parameters.Add("@ImptoCodigo", SqlDbType.NVarChar, 100, "ImptoCodigo")
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
            IDF_ClientesAnexo2Row(Me, dt.Rows(0))
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
        Dim dt As New DataTable("IDF_ClientesAnexo")
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
        '       Yo compruebo que sea un campo llamado ID, pero en tu caso puede ser otro
        sCommand = "INSERT INTO IDF_ClientesAnexo (TP, Direccion, EsOtrosComp, RTN, DirCliente2, DirCliente3, TelCliente1, TelCliente2, EmailCliente1, EmailCliente2, RetencionID, ImptoCodigo)  VALUES(@TP, @Direccion, @EsOtrosComp, @RTN, @DirCliente2, @DirCliente3, @TelCliente1, @TelCliente2, @EmailCliente1, @EmailCliente2, @RetencionID, @ImptoCodigo)"
        da.InsertCommand = New SqlCommand(sCommand, cnn)
        da.InsertCommand.Parameters.Add("@TP", SqlDbType.NVarChar, 30, "TP")
        da.InsertCommand.Parameters.Add("@Direccion", SqlDbType.NVarChar, 250, "Direccion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@EsOtrosComp", SqlDbType.Bit, 0, "EsOtrosComp")
        da.InsertCommand.Parameters.Add("@RTN", SqlDbType.NVarChar, 25, "RTN")
        da.InsertCommand.Parameters.Add("@DirCliente2", SqlDbType.NVarChar, 250, "DirCliente2")
        da.InsertCommand.Parameters.Add("@DirCliente3", SqlDbType.NVarChar, 250, "DirCliente3")
        da.InsertCommand.Parameters.Add("@TelCliente1", SqlDbType.NVarChar, 25, "TelCliente1")
        da.InsertCommand.Parameters.Add("@TelCliente2", SqlDbType.NVarChar, 25, "TelCliente2")
        da.InsertCommand.Parameters.Add("@EmailCliente1", SqlDbType.NVarChar, 100, "EmailCliente1")
        da.InsertCommand.Parameters.Add("@EmailCliente2", SqlDbType.NVarChar, 100, "EmailCliente2")
        da.InsertCommand.Parameters.Add("@RetencionID", SqlDbType.NVarChar, 100, "RetencionID")
        da.InsertCommand.Parameters.Add("@ImptoCodigo", SqlDbType.NVarChar, 100, "ImptoCodigo")
        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoIDF_ClientesAnexo(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo IDF_ClientesAnexo"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el ID que es el identificador único de cada registroT
        Dim sel As String = "SELECT * FROM IDF_ClientesAnexo WHERE TP = '" & Me.TP.ToString() & "'"
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_ClientesAnexo")
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
        '       Yo compruebo que sea un campo llamado ID, pero en tu caso puede ser otro
        sCommand = "DELETE FROM IDF_ClientesAnexo WHERE (ID = @p1)"
        da.DeleteCommand = New SqlCommand(sCommand, cnn)
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
