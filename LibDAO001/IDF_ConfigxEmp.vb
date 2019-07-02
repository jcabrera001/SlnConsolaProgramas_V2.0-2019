'------------------------------------------------------------------------------
' Clase IDF_ConfigxEmp generada automáticamente con CrearClaseSQL
' de la tabla 'IDF_ConfigxEmp' de la base 'Finanzas'
' Fecha: 07/Apr/2015 11:24:37
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
Public Class IDF_ConfigxEmp
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _ConfigxEmpID As System.Int32
    Private _EmpresaCodigo As System.String
    Private _esActual As System.Boolean
    Private _CAI As System.String
    Private _FechaLimite As System.DateTime
    Private _Email As System.String
    Private _RTN As System.String
    Private _Declaracion As System.String
    Private _Telefono As System.String
    Private _Direccion As System.String
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
    Public Property ConfigxEmpID() As System.Int32
        Get
            Return  _ConfigxEmpID
        End Get
        Set(value As System.Int32)
            _ConfigxEmpID = value
        End Set
    End Property
    Public Property EmpresaCodigo() As System.String
        Get
            Return ajustarAncho(_EmpresaCodigo,5)
        End Get
        Set(value As System.String)
            _EmpresaCodigo = value
        End Set
    End Property
    Public Property esActual() As System.Boolean
        Get
            Return  _esActual
        End Get
        Set(value As System.Boolean)
            _esActual = value
        End Set
    End Property
    Public Property CAI() As System.String
        Get
            Return ajustarAncho(_CAI,60)
        End Get
        Set(value As System.String)
            _CAI = value
        End Set
    End Property
    Public Property FechaLimite() As System.DateTime
        Get
            Return  _FechaLimite
        End Get
        Set(value As System.DateTime)
            _FechaLimite = value
        End Set
    End Property
    Public Property Email() As System.String
        Get
            Return ajustarAncho(_Email,100)
        End Get
        Set(value As System.String)
            _Email = value
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
    Public Property Declaracion() As System.String
        Get
            Return ajustarAncho(_Declaracion,50)
        End Get
        Set(value As System.String)
            _Declaracion = value
        End Set
    End Property
    Public Property Telefono() As System.String
        Get
            Return ajustarAncho(_Telefono,15)
        End Get
        Set(value As System.String)
            _Telefono = value
        End Set
    End Property
    Public Property Direccion() As System.String
        Get
            Return ajustarAncho(_Direccion,100)
        End Get
        Set(value As System.String)
            _Direccion = value
        End Set
    End Property
    '
    Public Default Property Item(index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.ConfigxEmpID.ToString()
            ElseIf index = 1 Then
                Return Me.EmpresaCodigo.ToString()
            ElseIf index = 2 Then
                Return Me.esActual.ToString()
            ElseIf index = 3 Then
                Return Me.CAI.ToString()
            ElseIf index = 4 Then
                Return Me.FechaLimite.ToString()
            ElseIf index = 5 Then
                Return Me.Email.ToString()
            ElseIf index = 6 Then
                Return Me.RTN.ToString()
            ElseIf index = 7 Then
                Return Me.Declaracion.ToString()
            ElseIf index = 8 Then
                Return Me.Telefono.ToString()
            ElseIf index = 9 Then
                Return Me.Direccion.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = 0 Then
                Try
                    Me.ConfigxEmpID = System.Int32.Parse("0" & value)
                Catch
                    Me.ConfigxEmpID = System.Int32.Parse("0")
                End Try
            ElseIf index = 1 Then
                Me.EmpresaCodigo = value
            ElseIf index = 2 Then
                Try
                    Me.esActual = System.Boolean.Parse(value)
                Catch
                    Me.esActual = False
                End Try
            ElseIf index = 3 Then
                Me.CAI = value
            ElseIf index = 4 Then
                Try
                    Me.FechaLimite = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaLimite = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaLimite = System.DateTime.Now
                End Try
            ElseIf index = 5 Then
                Me.Email = value
            ElseIf index = 6 Then
                Me.RTN = value
            ElseIf index = 7 Then
                Me.Declaracion = value
            ElseIf index = 8 Then
                Me.Telefono = value
            ElseIf index = 9 Then
                Me.Direccion = value
            End If
        End Set
    End Property
    Public Default Property Item(index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde al nombre de la columna)
        Get
            If index = "ConfigxEmpID" Then
                Return Me.ConfigxEmpID.ToString()
            ElseIf index = "EmpresaCodigo" Then
                Return Me.EmpresaCodigo.ToString()
            ElseIf index = "esActual" Then
                Return Me.esActual.ToString()
            ElseIf index = "CAI" Then
                Return Me.CAI.ToString()
            ElseIf index = "FechaLimite" Then
                Return Me.FechaLimite.ToString()
            ElseIf index = "Email" Then
                Return Me.Email.ToString()
            ElseIf index = "RTN" Then
                Return Me.RTN.ToString()
            ElseIf index = "Declaracion" Then
                Return Me.Declaracion.ToString()
            ElseIf index = "Telefono" Then
                Return Me.Telefono.ToString()
            ElseIf index = "Direccion" Then
                Return Me.Direccion.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = "ConfigxEmpID" Then
                Try
                    Me.ConfigxEmpID = System.Int32.Parse("0" & value)
                Catch
                    Me.ConfigxEmpID = System.Int32.Parse("0")
                End Try
            ElseIf index = "EmpresaCodigo" Then
                Me.EmpresaCodigo = value
            ElseIf index = "esActual" Then
                Try
                    Me.esActual = System.Boolean.Parse(value)
                Catch
                    Me.esActual = False
                End Try
            ElseIf index = "CAI" Then
                Me.CAI = value
            ElseIf index = "FechaLimite" Then
                Try
                    Me.FechaLimite = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaLimite = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaLimite = System.DateTime.Now
                End Try
            ElseIf index = "Email" Then
                Me.Email = value
            ElseIf index = "RTN" Then
                Me.RTN = value
            ElseIf index = "Declaracion" Then
                Me.Declaracion = value
            ElseIf index = "Telefono" Then
                Me.Telefono = value
            ElseIf index = "Direccion" Then
                Me.Direccion = value
            End If
        End Set
    End Property
    '
    ' Campos y métodos compartidos (estáticos) para gestionar la base de datos
    '
    ' La cadena de conexión a la base de datos
    Private Shared cadenaConexion As String = ""
    ' La cadena de selección
    Public Shared CadenaSelect As String = "SELECT * FROM IDF_ConfigxEmp"
    '
    Public Sub New()
    End Sub
    Public Sub New(conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto IDF_ConfigxEmp
    Private Shared Function row2IDF_ConfigxEmp(r As DataRow) As IDF_ConfigxEmp
        ' asigna a un objeto IDF_ConfigxEmp los datos del dataRow indicado
        Dim oIDF_ConfigxEmp As New IDF_ConfigxEmp
        '
        oIDF_ConfigxEmp.ConfigxEmpID = System.Int32.Parse("0" & r("ConfigxEmpID").ToString())
        oIDF_ConfigxEmp.EmpresaCodigo = r("EmpresaCodigo").ToString()
        Try
            oIDF_ConfigxEmp.esActual = System.Boolean.Parse(r("esActual").ToString())
        Catch
            oIDF_ConfigxEmp.esActual = False
        End Try
        oIDF_ConfigxEmp.CAI = r("CAI").ToString()
        Try
            oIDF_ConfigxEmp.FechaLimite = DateTime.Parse(r("FechaLimite").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oIDF_ConfigxEmp.FechaLimite = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oIDF_ConfigxEmp.FechaLimite = DateTime.Now
        End Try
        oIDF_ConfigxEmp.Email = r("Email").ToString()
        oIDF_ConfigxEmp.RTN = r("RTN").ToString()
        oIDF_ConfigxEmp.Declaracion = r("Declaracion").ToString()
        oIDF_ConfigxEmp.Telefono = r("Telefono").ToString()
        oIDF_ConfigxEmp.Direccion = r("Direccion").ToString()
        '
        Return oIDF_ConfigxEmp
    End Function
    '
    ' asigna un objeto IDF_ConfigxEmp a la fila indicada
    Private Shared Sub IDF_ConfigxEmp2Row(oIDF_ConfigxEmp As IDF_ConfigxEmp, r As DataRow)
        ' asigna un objeto IDF_ConfigxEmp al dataRow indicado
        r("ConfigxEmpID") = oIDF_ConfigxEmp.ConfigxEmpID
        r("EmpresaCodigo") = oIDF_ConfigxEmp.EmpresaCodigo
        r("esActual") = oIDF_ConfigxEmp.esActual
        r("CAI") = oIDF_ConfigxEmp.CAI
        r("FechaLimite") = oIDF_ConfigxEmp.FechaLimite
        r("Email") = oIDF_ConfigxEmp.Email
        r("RTN") = oIDF_ConfigxEmp.RTN
        r("Declaracion") = oIDF_ConfigxEmp.Declaracion
        r("Telefono") = oIDF_ConfigxEmp.Telefono
        r("Direccion") = oIDF_ConfigxEmp.Direccion
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto IDF_ConfigxEmp
    Private Shared Sub nuevoIDF_ConfigxEmp(dt As DataTable, oIDF_ConfigxEmp As IDF_ConfigxEmp)
        ' Crear un nuevo IDF_ConfigxEmp
        Dim dr As DataRow = dt.NewRow()
        Dim oI As IDF_ConfigxEmp = row2IDF_ConfigxEmp(dr)
        '
        oI.ConfigxEmpID = oIDF_ConfigxEmp.ConfigxEmpID
        oI.EmpresaCodigo = oIDF_ConfigxEmp.EmpresaCodigo
        oI.esActual = oIDF_ConfigxEmp.esActual
        oI.CAI = oIDF_ConfigxEmp.CAI
        oI.FechaLimite = oIDF_ConfigxEmp.FechaLimite
        oI.Email = oIDF_ConfigxEmp.Email
        oI.RTN = oIDF_ConfigxEmp.RTN
        oI.Declaracion = oIDF_ConfigxEmp.Declaracion
        oI.Telefono = oIDF_ConfigxEmp.Telefono
        oI.Direccion = oIDF_ConfigxEmp.Direccion
        '
        IDF_ConfigxEmp2Row(oI, dr)
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
        ' devuelve una tabla con los datos de la tabla IDF_ConfigxEmp
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_ConfigxEmp")
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
    Public Shared Function Buscar(sWhere As String) As IDF_ConfigxEmp
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oIDF_ConfigxEmp As IDF_ConfigxEmp = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_ConfigxEmp")
        Dim sel As String = "SELECT A.ConfigxEmpID, A.EmpresaCodigo, B.EsActual, A.CAI, A.FechaLimite, A.Email, A.RTN, A.Declaracion, A.Telefono, A.Direccion " +
            "FROM IDF_ConfigxEmp A Left Join IDF_DetConfigXEmp B on A.CAI=B.CAI " +
            "WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oIDF_ConfigxEmp = row2IDF_ConfigxEmp(dt.Rows(0))
        End If
        Return oIDF_ConfigxEmp
    End Function
    '
    ' Actualizar: Actualiza los datos en la tabla usando la instancia actual
    '             Si la instancia no hace referencia a un registro existente, se creará uno nuevo
    '             Para comprobar si el objeto en memoria coincide con uno existente,
    '             se comprueba si el ConfigxEmpID existe en la tabla.
    '             TODO: Si en lugar de ConfigxEmpID usas otro campo, indicalo en la cadena SELECT
    '                   También puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    Public Function Actualizar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el ConfigxEmpID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_ConfigxEmp WHERE ConfigxEmpID = " & Me.ConfigxEmpID.ToString()
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(sel As String) As String
        ' Actualiza los datos indicados
        ' El parámetro, que es una cadena de selección, indicará el criterio de actualización
        '
        ' En caso de error, devolverá la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_ConfigxEmp")
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
        ''       Yo compruebo que sea un campo llamado ConfigxEmpID, pero en tu caso puede ser otro
        ''       Ese campo, (en mi caso ConfigxEmpID) será el que hay que poner al final junto al WHERE.
        'sCommand = "UPDATE IDF_ConfigxEmp SET EmpresaCodigo = @EmpresaCodigo, esActual = @esActual, CAI = @CAI, FechaLimite = @FechaLimite, Email = @Email, RTN = @RTN, Declaracion = @Declaracion, Telefono = @Telefono, Direccion = @Direccion  WHERE (ConfigxEmpID = @ConfigxEmpID)"
        'da.UpdateCommand = New SqlCommand(sCommand, cnn)
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@ConfigxEmpID", SqlDbType.Int, 0, "ConfigxEmpID")
        'da.UpdateCommand.Parameters.Add("@EmpresaCodigo", SqlDbType.NVarChar, 5, "EmpresaCodigo")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@esActual", SqlDbType.Bit, 0, "esActual")
        'da.UpdateCommand.Parameters.Add("@CAI", SqlDbType.NVarChar, 60, "CAI")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@FechaLimite", SqlDbType.DateTime, 0, "FechaLimite")
        'da.UpdateCommand.Parameters.Add("@Email", SqlDbType.NVarChar, 100, "Email")
        'da.UpdateCommand.Parameters.Add("@RTN", SqlDbType.NVarChar, 25, "RTN")
        'da.UpdateCommand.Parameters.Add("@Declaracion", SqlDbType.NVarChar, 50, "Declaracion")
        'da.UpdateCommand.Parameters.Add("@Telefono", SqlDbType.NVarChar, 15, "Telefono")
        'da.UpdateCommand.Parameters.Add("@Direccion", SqlDbType.NVarChar, 100, "Direccion")
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
            IDF_ConfigxEmp2Row(Me, dt.Rows(0))
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
        Dim dt As New DataTable("IDF_ConfigxEmp")
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
        ''       Yo compruebo que sea un campo llamado ConfigxEmpID, pero en tu caso puede ser otro
        'sCommand = "INSERT INTO IDF_ConfigxEmp (ConfigxEmpID, EmpresaCodigo, esActual, CAI, FechaLimite, Email, RTN, Declaracion, Telefono, Direccion)  VALUES(@ConfigxEmpID, @EmpresaCodigo, @esActual, @CAI, @FechaLimite, @Email, @RTN, @Declaracion, @Telefono, @Direccion)"
        'da.InsertCommand = New SqlCommand(sCommand, cnn)
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@ConfigxEmpID", SqlDbType.Int, 0, "ConfigxEmpID")
        'da.InsertCommand.Parameters.Add("@EmpresaCodigo", SqlDbType.NVarChar, 5, "EmpresaCodigo")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@esActual", SqlDbType.Bit, 0, "esActual")
        'da.InsertCommand.Parameters.Add("@CAI", SqlDbType.NVarChar, 60, "CAI")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@FechaLimite", SqlDbType.DateTime, 0, "FechaLimite")
        'da.InsertCommand.Parameters.Add("@Email", SqlDbType.NVarChar, 100, "Email")
        'da.InsertCommand.Parameters.Add("@RTN", SqlDbType.NVarChar, 25, "RTN")
        'da.InsertCommand.Parameters.Add("@Declaracion", SqlDbType.NVarChar, 50, "Declaracion")
        'da.InsertCommand.Parameters.Add("@Telefono", SqlDbType.NVarChar, 15, "Telefono")
        'da.InsertCommand.Parameters.Add("@Direccion", SqlDbType.NVarChar, 100, "Direccion")
        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoIDF_ConfigxEmp(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo IDF_ConfigxEmp"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el ConfigxEmpID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_ConfigxEmp WHERE ConfigxEmpID = " & Me.ConfigxEmpID.ToString()
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_ConfigxEmp")
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
        ''       Yo compruebo que sea un campo llamado ConfigxEmpID, pero en tu caso puede ser otro
        'sCommand = "DELETE FROM IDF_ConfigxEmp WHERE (ConfigxEmpID = @p1)"
        'da.DeleteCommand = New SqlCommand(sCommand, cnn)
        '' TODO: Comprobar el tipo de datos a usar...
        'da.DeleteCommand.Parameters.Add("@p1", SqlDbType.Int, 0, "ConfigxEmpID")
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
