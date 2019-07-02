'------------------------------------------------------------------------------
' Clase IDF_EmpresasAnexo generada automáticamente con CrearClaseSQL
' de la tabla 'IDF_EmpresasAnexo' de la base 'Finanzas'
' Fecha: 08/Apr/2015 14:12:05
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
Public Class IDF_EmpresasAnexo
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _EmpresaCodigo As System.String
    Private _Telefono As System.String
    Private _Direccion As System.String
    Private _RTN As System.String
    Private _Email As System.String
    Private _FDA As System.String
    Private _RetencionID As System.Int32
    Private _LogoEmpresa As System.Byte()
    Private _NotaDoc1 As System.String
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
    Public Property EmpresaCodigo() As System.String
        Get
            Return ajustarAncho(_EmpresaCodigo, 5)
        End Get
        Set(value As System.String)
            _EmpresaCodigo = value
        End Set
    End Property
    Public Property Telefono() As System.String
        Get
            Return ajustarAncho(_Telefono, 25)
        End Get
        Set(value As System.String)
            _Telefono = value
        End Set
    End Property
    Public Property Direccion() As System.String
        Get
            Return ajustarAncho(_Direccion, 100)
        End Get
        Set(value As System.String)
            _Direccion = value
        End Set
    End Property
    Public Property RTN() As System.String
        Get
            Return ajustarAncho(_RTN, 25)
        End Get
        Set(value As System.String)
            _RTN = value
        End Set
    End Property
    Public Property Email() As System.String
        Get
            Return ajustarAncho(_Email, 100)
        End Get
        Set(value As System.String)
            _Email = value
        End Set
    End Property
    Public Property FDA() As System.String
        Get
            Return ajustarAncho(_FDA, 30)
        End Get
        Set(value As System.String)
            _FDA = value
        End Set
    End Property
    Public Property RetencionID() As System.Int32
        Get
            Return _RetencionID
        End Get
        Set(value As System.Int32)
            _RetencionID = value
        End Set
    End Property
    Public Property LogoEmpresa() As System.Byte()
        Get
            Return _LogoEmpresa
        End Get
        Set(value As System.Byte())
            _LogoEmpresa = value
        End Set
    End Property

    Public Property NotaDoc1() As System.String
        Get
            Return ajustarAncho(_NotaDoc1, 250)
        End Get
        Set(value As System.String)
            _NotaDoc1 = value
        End Set
    End Property
    '
    Default Public Property Item(index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.EmpresaCodigo.ToString()
            ElseIf index = 1 Then
                Return Me.Telefono.ToString()
            ElseIf index = 2 Then
                Return Me.Direccion.ToString()
            ElseIf index = 3 Then
                Return Me.RTN.ToString()
            ElseIf index = 4 Then
                Return Me.Email.ToString()
            ElseIf index = 5 Then
                Return Me.FDA.ToString()
            ElseIf index = 6 Then
                Return Me.RetencionID.ToString()
            ElseIf index = 7 Then
                Return Me.LogoEmpresa.ToString
            ElseIf index = 8 Then
                Return Me.NotaDoc1.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = 0 Then
                Me.EmpresaCodigo = value
            ElseIf index = 1 Then
                Me.Telefono = value
            ElseIf index = 2 Then
                Me.Direccion = value
            ElseIf index = 3 Then
                Me.RTN = value
            ElseIf index = 4 Then
                Me.Email = value
            ElseIf index = 5 Then
                Me.FDA = value
            ElseIf index = 6 Then
                Try
                    Me.RetencionID = System.Int32.Parse("0" & value)
                Catch
                    Me.RetencionID = System.Int32.Parse("0")
                End Try
            ElseIf index = 7 Then
                Me.LogoEmpresa = System.Text.Encoding.ASCII.GetBytes(value)
            ElseIf index = 8 Then
                Me.NotaDoc1 = value
            End If
        End Set
    End Property
    Default Public Property Item(index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde al nombre de la columna)
        Get
            If index = "EmpresaCodigo" Then
                Return Me.EmpresaCodigo.ToString()
            ElseIf index = "Telefono" Then
                Return Me.Telefono.ToString()
            ElseIf index = "Direccion" Then
                Return Me.Direccion.ToString()
            ElseIf index = "RTN" Then
                Return Me.RTN.ToString()
            ElseIf index = "Email" Then
                Return Me.Email.ToString()
            ElseIf index = "FDA" Then
                Return Me.FDA.ToString()
            ElseIf index = "RetencionID" Then
                Return Me.RetencionID.ToString()
            ElseIf index = "LogoEmpresa" Then
                Return Me.LogoEmpresa.ToString()
            ElseIf index = "NotaDoc1" Then
                Return Me.NotaDoc1.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = "EmpresaCodigo" Then
                Me.EmpresaCodigo = value
            ElseIf index = "Telefono" Then
                Me.Telefono = value
            ElseIf index = "Direccion" Then
                Me.Direccion = value
            ElseIf index = "RTN" Then
                Me.RTN = value
            ElseIf index = "Email" Then
                Me.Email = value
            ElseIf index = "FDA" Then
                Me.FDA = value
            ElseIf index = "RetencionID" Then
                Try
                    Me.RetencionID = System.Int32.Parse("0" & value)
                Catch
                    Me.RetencionID = System.Int32.Parse("0")
                End Try
            ElseIf index = "LogoEmpresa" Then
                Me.LogoEmpresa = System.Text.Encoding.ASCII.GetBytes(value)
            ElseIf index = "NotaDoc1" Then
                Me.NotaDoc1 = value
            End If
        End Set
    End Property
    '
    ' Campos y métodos compartidos (estáticos) para gestionar la base de datos
    '
    ' La cadena de conexión a la base de datos
    Private Shared cadenaConexion As String = ""
    ' La cadena de selección
    Public Shared CadenaSelect As String = "SELECT * FROM IDF_EmpresasAnexo"
    '
    Public Sub New()
    End Sub
    Public Sub New(conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto IDF_EmpresasAnexo
    Private Shared Function row2IDF_EmpresasAnexo(r As DataRow) As IDF_EmpresasAnexo
        ' asigna a un objeto IDF_EmpresasAnexo los datos del dataRow indicado
        Dim oIDF_EmpresasAnexo As New IDF_EmpresasAnexo
        '
        oIDF_EmpresasAnexo.EmpresaCodigo = r("EmpresaCodigo").ToString()
        oIDF_EmpresasAnexo.Telefono = r("Telefono").ToString()
        oIDF_EmpresasAnexo.Direccion = r("Direccion").ToString()
        oIDF_EmpresasAnexo.RTN = r("RTN").ToString()
        oIDF_EmpresasAnexo.Email = r("Email").ToString()
        oIDF_EmpresasAnexo.FDA = r("FDA").ToString()
        oIDF_EmpresasAnexo.RetencionID = System.Int32.Parse("0" & r("RetencionID").ToString())
        oIDF_EmpresasAnexo.NotaDoc1 = r("NotaDoc1").ToString()
        'oIDF_EmpresasAnexo.LogoEmpresa = 0 'System.Text.Encoding.ASCII.GetBytes(r("LogoEmpresa").ToString)
        '
        Return oIDF_EmpresasAnexo
    End Function
    '
    ' asigna un objeto IDF_EmpresasAnexo a la fila indicada
    Private Shared Sub IDF_EmpresasAnexo2Row(oIDF_EmpresasAnexo As IDF_EmpresasAnexo, r As DataRow)
        ' asigna un objeto IDF_EmpresasAnexo al dataRow indicado
        r("EmpresaCodigo") = oIDF_EmpresasAnexo.EmpresaCodigo
        r("Telefono") = oIDF_EmpresasAnexo.Telefono
        r("Direccion") = oIDF_EmpresasAnexo.Direccion
        r("RTN") = oIDF_EmpresasAnexo.RTN
        r("Email") = oIDF_EmpresasAnexo.Email
        r("FDA") = oIDF_EmpresasAnexo.FDA
        r("RetencionID") = oIDF_EmpresasAnexo.RetencionID
        r("LogoEmpresa") = oIDF_EmpresasAnexo.LogoEmpresa
        r("NotaDoc1") = oIDF_EmpresasAnexo.NotaDoc1
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto IDF_EmpresasAnexo
    Private Shared Sub nuevoIDF_EmpresasAnexo(dt As DataTable, oIDF_EmpresasAnexo As IDF_EmpresasAnexo)
        ' Crear un nuevo IDF_EmpresasAnexo
        Dim dr As DataRow = dt.NewRow()
        Dim oI As IDF_EmpresasAnexo = row2IDF_EmpresasAnexo(dr)
        '
        oI.EmpresaCodigo = oIDF_EmpresasAnexo.EmpresaCodigo
        oI.Telefono = oIDF_EmpresasAnexo.Telefono
        oI.Direccion = oIDF_EmpresasAnexo.Direccion
        oI.RTN = oIDF_EmpresasAnexo.RTN
        oI.Email = oIDF_EmpresasAnexo.Email
        oI.FDA = oIDF_EmpresasAnexo.FDA
        oI.RetencionID = oIDF_EmpresasAnexo.RetencionID
        oI.LogoEmpresa = oIDF_EmpresasAnexo.LogoEmpresa
        oI.NotaDoc1 = oIDF_EmpresasAnexo.NotaDoc1
        '
        IDF_EmpresasAnexo2Row(oI, dr)
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
        ' devuelve una tabla con los datos de la tabla IDF_EmpresasAnexo
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_EmpresasAnexo")
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
    Public Shared Function Buscar(sWhere As String) As IDF_EmpresasAnexo
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oIDF_EmpresasAnexo As IDF_EmpresasAnexo = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_EmpresasAnexo")
        Dim sel As String = "SELECT * FROM IDF_EmpresasAnexo WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oIDF_EmpresasAnexo = row2IDF_EmpresasAnexo(dt.Rows(0))
        End If
        Return oIDF_EmpresasAnexo
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
        Dim sel As String = "SELECT * FROM IDF_EmpresasAnexo WHERE EmpresaCodigo = " & Me.EmpresaCodigo.ToString()
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(sel As String) As String
        ' Actualiza los datos indicados
        ' El parámetro, que es una cadena de selección, indicará el criterio de actualización
        '
        ' En caso de error, devolverá la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_EmpresasAnexo")
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
        sCommand = "UPDATE IDF_EmpresasAnexo SET Telefono = @Telefono, Direccion = @Direccion, RTN = @RTN, Email = @Email, FDA = @FDA, RetencionID = @RetencionID, LogoEmpresa = @LogoEmpresa, NotaDoc1 = @NotaDoc1 WHERE (EmpresaCodigo = @EmpresaCodigo)"
        da.UpdateCommand = New SqlCommand(sCommand, cnn)
        da.UpdateCommand.Parameters.Add("@EmpresaCodigo", SqlDbType.NVarChar, 5, "EmpresaCodigo")
        da.UpdateCommand.Parameters.Add("@Telefono", SqlDbType.NVarChar, 25, "Telefono")
        da.UpdateCommand.Parameters.Add("@Direccion", SqlDbType.NVarChar, 100, "Direccion")
        da.UpdateCommand.Parameters.Add("@RTN", SqlDbType.NVarChar, 25, "RTN")
        da.UpdateCommand.Parameters.Add("@Email", SqlDbType.NVarChar, 100, "Email")
        da.UpdateCommand.Parameters.Add("@FDA", SqlDbType.NVarChar, 30, "FDA")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@RetencionID", SqlDbType.Int, 0, "RetencionID")
        da.UpdateCommand.Parameters.Add("@LogoEmpresa", SqlDbType.Image, 0, "LogoEmpresa")
        da.UpdateCommand.Parameters.Add("@NotaDoc1", SqlDbType.NVarChar, 250, "NotaDoc1")
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
            IDF_EmpresasAnexo2Row(Me, dt.Rows(0))
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
        Dim dt As New DataTable("IDF_EmpresasAnexo")
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
        ''       Yo compruebo que sea un campo llamado ID, pero en tu caso puede ser otro
        'sCommand = "INSERT INTO IDF_EmpresasAnexo (EmpresaCodigo, Telefono, Direccion, RTN, Email, FDA, RetencionID)  VALUES(@EmpresaCodigo, @Telefono, @Direccion, @RTN, @Email, @FDA, @RetencionID)"
        'da.InsertCommand = New SqlCommand(sCommand, cnn)
        'da.InsertCommand.Parameters.Add("@EmpresaCodigo", SqlDbType.NVarChar, 5, "EmpresaCodigo")
        'da.InsertCommand.Parameters.Add("@Telefono", SqlDbType.NVarChar, 15, "Telefono")
        'da.InsertCommand.Parameters.Add("@Direccion", SqlDbType.NVarChar, 100, "Direccion")
        'da.InsertCommand.Parameters.Add("@RTN", SqlDbType.NVarChar, 25, "RTN")
        'da.InsertCommand.Parameters.Add("@Email", SqlDbType.NVarChar, 100, "Email")
        'da.InsertCommand.Parameters.Add("@FDA", SqlDbType.NVarChar, 30, "FDA")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@RetencionID", SqlDbType.Int, 0, "RetencionID")
        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoIDF_EmpresasAnexo(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo IDF_EmpresasAnexo"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el ID que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM IDF_EmpresasAnexo WHERE EmpresaCodigo = " & Me.EmpresaCodigo.ToString()
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("IDF_EmpresasAnexo")
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
        ''       Yo compruebo que sea un campo llamado ID, pero en tu caso puede ser otro
        'sCommand = "DELETE FROM IDF_EmpresasAnexo WHERE (ID = @p1)"
        'da.DeleteCommand = New SqlCommand(sCommand, cnn)
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
