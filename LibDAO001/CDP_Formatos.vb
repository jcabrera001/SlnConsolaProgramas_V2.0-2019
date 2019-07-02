'------------------------------------------------------------------------------
' Clase CDP_Formatos generada autom�ticamente con CrearClaseSQL
' de la tabla 'CDP_Formatos' de la base 'Finanzas'
' Fecha: 25/Jun/2015 10:08:37
'
' �Guillermo 'guille' Som, 2004-2015
'------------------------------------------------------------------------------
Option Strict On
Option Explicit On
'
Imports System
Imports System.Data
Imports System.Data.SqlClient
'
Public Class CDP_Formatos
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _FormatoID As System.Int32
    Private _EmpresaCodigo As System.String
    Private _Descripcion As System.String
    Private _AplicaNumeracion As System.Boolean
    Private _AplicaCtaBancaria As System.Boolean
    Private _AplicaImpDespacho As System.Boolean
    Private _Especificaciones As System.String
    Private _Utilizacion As System.String
    Private _UsuarioResponsable As System.String
    Private _UsuarioSolicitador As System.String
    Private _UsuarioCreador As System.String
    Private _FechaCreacion As System.DateTime
    Private _UsuarioEditor As System.String
    Private _FechaEdicion As System.DateTime
    '
    ' Este m�todo se usar� para ajustar los anchos de las propiedades
    Private Function ajustarAncho(cadena As String, ancho As Integer) As String
        Dim sb As New System.Text.StringBuilder(New String(" "c, ancho))
        ' devolver la cadena quitando los espacios en blanco
        ' esto asegura que no se devolver� un tama�o mayor ni espacios "extras"
        Return (cadena & sb.ToString()).Substring(0, ancho).Trim()
    End Function
    '
    ' Las propiedades p�blicas
    ' TODO: Revisar los tipos de las propiedades
    Public Property FormatoID() As System.Int32
        Get
            Return _FormatoID
        End Get
        Set(value As System.Int32)
            _FormatoID = value
        End Set
    End Property
    Public Property EmpresaCodigo() As System.String
        Get
            Return ajustarAncho(_EmpresaCodigo, 2)
        End Get
        Set(value As System.String)
            _EmpresaCodigo = value
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
    Public Property AplicaNumeracion() As System.Boolean
        Get
            Return _AplicaNumeracion
        End Get
        Set(value As System.Boolean)
            _AplicaNumeracion = value
        End Set
    End Property
    Public Property AplicaCtaBancaria() As System.Boolean
        Get
            Return _AplicaCtaBancaria
        End Get
        Set(value As System.Boolean)
            _AplicaCtaBancaria = value
        End Set
    End Property
    Public Property AplicaImpDespacho() As System.Boolean
        Get
            Return _AplicaImpDespacho
        End Get
        Set(value As System.Boolean)
            _AplicaImpDespacho = value
        End Set
    End Property
    Public Property Especificaciones() As System.String
        Get
            Return ajustarAncho(_Especificaciones, 200)
        End Get
        Set(value As System.String)
            _Especificaciones = value
        End Set
    End Property
    Public Property Utilizacion() As System.String
        Get
            Return ajustarAncho(_Utilizacion, 200)
        End Get
        Set(value As System.String)
            _Utilizacion = value
        End Set
    End Property
    Public Property UsuarioResponsable() As System.String
        Get
            Return ajustarAncho(_UsuarioResponsable, 25)
        End Get
        Set(value As System.String)
            _UsuarioResponsable = value
        End Set
    End Property
    Public Property UsuarioSolicitador() As System.String
        Get
            Return ajustarAncho(_UsuarioSolicitador, 25)
        End Get
        Set(value As System.String)
            _UsuarioSolicitador = value
        End Set
    End Property
    Public Property UsuarioCreador() As System.String
        Get
            Return ajustarAncho(_UsuarioCreador, 25)
        End Get
        Set(value As System.String)
            _UsuarioCreador = value
        End Set
    End Property
    Public Property FechaCreacion() As System.DateTime
        Get
            Return _FechaCreacion
        End Get
        Set(value As System.DateTime)
            _FechaCreacion = value
        End Set
    End Property
    Public Property UsuarioEditor() As System.String
        Get
            Return ajustarAncho(_UsuarioEditor, 25)
        End Get
        Set(value As System.String)
            _UsuarioEditor = value
        End Set
    End Property
    Public Property FechaEdicion() As System.DateTime
        Get
            Return _FechaEdicion
        End Get
        Set(value As System.DateTime)
            _FechaEdicion = value
        End Set
    End Property
    '
    Default Public Property Item(index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el �ndice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.FormatoID.ToString()
            ElseIf index = 1 Then
                Return Me.EmpresaCodigo.ToString()
            ElseIf index = 2 Then
                Return Me.Descripcion.ToString()
            ElseIf index = 3 Then
                Return Me.AplicaNumeracion.ToString()
            ElseIf index = 4 Then
                Return Me.AplicaCtaBancaria.ToString()
            ElseIf index = 5 Then
                Return Me.AplicaImpDespacho.ToString()
            ElseIf index = 6 Then
                Return Me.Especificaciones.ToString()
            ElseIf index = 7 Then
                Return Me.Utilizacion.ToString()
            ElseIf index = 8 Then
                Return Me.UsuarioResponsable.ToString()
            ElseIf index = 9 Then
                Return Me.UsuarioSolicitador.ToString()
            ElseIf index = 10 Then
                Return Me.UsuarioCreador.ToString()
            ElseIf index = 11 Then
                Return Me.FechaCreacion.ToString()
            ElseIf index = 12 Then
                Return Me.UsuarioEditor.ToString()
            ElseIf index = 13 Then
                Return Me.FechaEdicion.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = 0 Then
                Try
                    Me.FormatoID = System.Int32.Parse("0" & value)
                Catch
                    Me.FormatoID = System.Int32.Parse("0")
                End Try
            ElseIf index = 1 Then
                Me.EmpresaCodigo = value
            ElseIf index = 2 Then
                Me.Descripcion = value
            ElseIf index = 3 Then
                Try
                    Me.AplicaNumeracion = System.Boolean.Parse(value)
                Catch
                    Me.AplicaNumeracion = False
                End Try
            ElseIf index = 4 Then
                Try
                    Me.AplicaCtaBancaria = System.Boolean.Parse(value)
                Catch
                    Me.AplicaCtaBancaria = False
                End Try
            ElseIf index = 5 Then
                Try
                    Me.AplicaImpDespacho = System.Boolean.Parse(value)
                Catch
                    Me.AplicaImpDespacho = False
                End Try
            ElseIf index = 6 Then
                Me.Especificaciones = value
            ElseIf index = 7 Then
                Me.Utilizacion = value
            ElseIf index = 8 Then
                Me.UsuarioResponsable = value
            ElseIf index = 9 Then
                Me.UsuarioSolicitador = value
            ElseIf index = 10 Then
                Me.UsuarioCreador = value
            ElseIf index = 11 Then
                Try
                    Me.FechaCreacion = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaCreacion = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaCreacion = System.DateTime.Now
                End Try
            ElseIf index = 12 Then
                Me.UsuarioEditor = value
            ElseIf index = 13 Then
                Try
                    Me.FechaEdicion = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaEdicion = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaEdicion = System.DateTime.Now
                End Try
            End If
        End Set
    End Property
    Default Public Property Item(index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el �ndice corresponde al nombre de la columna)
        Get
            If index = "FormatoID" Then
                Return Me.FormatoID.ToString()
            ElseIf index = "EmpresaCodigo" Then
                Return Me.EmpresaCodigo.ToString()
            ElseIf index = "Descripcion" Then
                Return Me.Descripcion.ToString()
            ElseIf index = "AplicaNumeracion" Then
                Return Me.AplicaNumeracion.ToString()
            ElseIf index = "AplicaCtaBancaria" Then
                Return Me.AplicaCtaBancaria.ToString()
            ElseIf index = "AplicaImpDespacho" Then
                Return Me.AplicaImpDespacho.ToString()
            ElseIf index = "Especificaciones" Then
                Return Me.Especificaciones.ToString()
            ElseIf index = "Utilizacion" Then
                Return Me.Utilizacion.ToString()
            ElseIf index = "UsuarioResponsable" Then
                Return Me.UsuarioResponsable.ToString()
            ElseIf index = "UsuarioSolicitador" Then
                Return Me.UsuarioSolicitador.ToString()
            ElseIf index = "UsuarioCreador" Then
                Return Me.UsuarioCreador.ToString()
            ElseIf index = "FechaCreacion" Then
                Return Me.FechaCreacion.ToString()
            ElseIf index = "UsuarioEditor" Then
                Return Me.UsuarioEditor.ToString()
            ElseIf index = "FechaEdicion" Then
                Return Me.FechaEdicion.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = "FormatoID" Then
                Try
                    Me.FormatoID = System.Int32.Parse("0" & value)
                Catch
                    Me.FormatoID = System.Int32.Parse("0")
                End Try
            ElseIf index = "EmpresaCodigo" Then
                Me.EmpresaCodigo = value
            ElseIf index = "Descripcion" Then
                Me.Descripcion = value
            ElseIf index = "AplicaNumeracion" Then
                Try
                    Me.AplicaNumeracion = System.Boolean.Parse(value)
                Catch
                    Me.AplicaNumeracion = False
                End Try
            ElseIf index = "AplicaCtaBancaria" Then
                Try
                    Me.AplicaCtaBancaria = System.Boolean.Parse(value)
                Catch
                    Me.AplicaCtaBancaria = False
                End Try
            ElseIf index = "AplicaImpDespacho" Then
                Try
                    Me.AplicaImpDespacho = System.Boolean.Parse(value)
                Catch
                    Me.AplicaImpDespacho = False
                End Try
            ElseIf index = "Especificaciones" Then
                Me.Especificaciones = value
            ElseIf index = "Utilizacion" Then
                Me.Utilizacion = value
            ElseIf index = "UsuarioResponsable" Then
                Me.UsuarioResponsable = value
            ElseIf index = "UsuarioSolicitador" Then
                Me.UsuarioSolicitador = value
            ElseIf index = "UsuarioCreador" Then
                Me.UsuarioCreador = value
            ElseIf index = "FechaCreacion" Then
                Try
                    Me.FechaCreacion = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaCreacion = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaCreacion = System.DateTime.Now
                End Try
            ElseIf index = "UsuarioEditor" Then
                Me.UsuarioEditor = value
            ElseIf index = "FechaEdicion" Then
                Try
                    Me.FechaEdicion = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.FechaEdicion = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.FechaEdicion = System.DateTime.Now
                End Try
            End If
        End Set
    End Property
    '
    ' Campos y m�todos compartidos (est�ticos) para gestionar la base de datos
    '
    ' La cadena de conexi�n a la base de datos
    Private Shared cadenaConexion As String = ""
    ' La cadena de selecci�n
    Public Shared CadenaSelect As String = "SELECT * FROM CDP_Formatos"
    '
    Public Sub New()
    End Sub
    Public Sub New(conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' M�todos compartidos (est�ticos) privados
    '
    ' asigna una fila de la tabla a un objeto CDP_Formatos
    Private Shared Function row2CDP_Formatos(r As DataRow) As CDP_Formatos
        ' asigna a un objeto CDP_Formatos los datos del dataRow indicado
        Dim oCDP_Formatos As New CDP_Formatos
        '
        oCDP_Formatos.FormatoID = System.Int32.Parse("0" & r("FormatoID").ToString())
        oCDP_Formatos.EmpresaCodigo = r("EmpresaCodigo").ToString()
        oCDP_Formatos.Descripcion = r("Descripcion").ToString()
        Try
            oCDP_Formatos.AplicaNumeracion = System.Boolean.Parse(r("AplicaNumeracion").ToString())
        Catch
            oCDP_Formatos.AplicaNumeracion = False
        End Try
        Try
            oCDP_Formatos.AplicaCtaBancaria = System.Boolean.Parse(r("AplicaCtaBancaria").ToString())
        Catch
            oCDP_Formatos.AplicaCtaBancaria = False
        End Try
        Try
            oCDP_Formatos.AplicaImpDespacho = System.Boolean.Parse(r("AplicaImpDespacho").ToString())
        Catch
            oCDP_Formatos.AplicaImpDespacho = False
        End Try
        oCDP_Formatos.Especificaciones = r("Especificaciones").ToString()
        oCDP_Formatos.Utilizacion = r("Utilizacion").ToString()
        oCDP_Formatos.UsuarioResponsable = r("UsuarioResponsable").ToString()
        oCDP_Formatos.UsuarioSolicitador = r("UsuarioSolicitador").ToString()
        oCDP_Formatos.UsuarioCreador = r("UsuarioCreador").ToString()
        Try
            oCDP_Formatos.FechaCreacion = DateTime.Parse(r("FechaCreacion").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oCDP_Formatos.FechaCreacion = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oCDP_Formatos.FechaCreacion = DateTime.Now
        End Try
        oCDP_Formatos.UsuarioEditor = r("UsuarioEditor").ToString()
        Try
            oCDP_Formatos.FechaEdicion = DateTime.Parse(r("FechaEdicion").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oCDP_Formatos.FechaEdicion = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oCDP_Formatos.FechaEdicion = DateTime.Now
        End Try
        '
        Return oCDP_Formatos
    End Function
    '
    ' asigna un objeto CDP_Formatos a la fila indicada
    Private Shared Sub CDP_Formatos2Row(oCDP_Formatos As CDP_Formatos, r As DataRow)
        ' asigna un objeto CDP_Formatos al dataRow indicado
        ' TODO: Comprueba si esta asignaci�n debe hacerse
        '       pero mejor lo dejas comentado ya que es un campo autoincremental o �nico
        'r("FormatoID") = oCDP_Formatos.FormatoID
        r("EmpresaCodigo") = oCDP_Formatos.EmpresaCodigo
        r("Descripcion") = oCDP_Formatos.Descripcion
        r("AplicaNumeracion") = oCDP_Formatos.AplicaNumeracion
        r("AplicaCtaBancaria") = oCDP_Formatos.AplicaCtaBancaria
        r("AplicaImpDespacho") = oCDP_Formatos.AplicaImpDespacho
        r("Especificaciones") = oCDP_Formatos.Especificaciones
        r("Utilizacion") = oCDP_Formatos.Utilizacion
        r("UsuarioResponsable") = oCDP_Formatos.UsuarioResponsable
        r("UsuarioSolicitador") = oCDP_Formatos.UsuarioSolicitador
        r("UsuarioCreador") = oCDP_Formatos.UsuarioCreador
        r("FechaCreacion") = oCDP_Formatos.FechaCreacion
        r("UsuarioEditor") = oCDP_Formatos.UsuarioEditor
        r("FechaEdicion") = oCDP_Formatos.FechaEdicion
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto CDP_Formatos
    Private Shared Sub nuevoCDP_Formatos(dt As DataTable, oCDP_Formatos As CDP_Formatos)
        ' Crear un nuevo CDP_Formatos
        Dim dr As DataRow = dt.NewRow()
        Dim oC As CDP_Formatos = row2CDP_Formatos(dr)
        '
        oC.FormatoID = oCDP_Formatos.FormatoID
        oC.EmpresaCodigo = oCDP_Formatos.EmpresaCodigo
        oC.Descripcion = oCDP_Formatos.Descripcion
        oC.AplicaNumeracion = oCDP_Formatos.AplicaNumeracion
        oC.AplicaCtaBancaria = oCDP_Formatos.AplicaCtaBancaria
        oC.AplicaImpDespacho = oCDP_Formatos.AplicaImpDespacho
        oC.Especificaciones = oCDP_Formatos.Especificaciones
        oC.Utilizacion = oCDP_Formatos.Utilizacion
        oC.UsuarioResponsable = oCDP_Formatos.UsuarioResponsable
        oC.UsuarioSolicitador = oCDP_Formatos.UsuarioSolicitador
        oC.UsuarioCreador = oCDP_Formatos.UsuarioCreador
        oC.FechaCreacion = oCDP_Formatos.FechaCreacion
        oC.UsuarioEditor = oCDP_Formatos.UsuarioEditor
        oC.FechaEdicion = oCDP_Formatos.FechaEdicion
        '
        CDP_Formatos2Row(oC, dr)
        '
        dt.Rows.Add(dr)
    End Sub
    '
    ' M�todos p�blicos
    '
    ' devuelve una tabla con los datos indicados en la cadena de selecci�n
    Public Shared Function Tabla() As DataTable
        Return Tabla(CadenaSelect)
    End Function
    Public Shared Function Tabla(sel As String) As DataTable
        ' devuelve una tabla con los datos de la tabla CDP_Formatos
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("CDP_Formatos")
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
    Public Shared Function Buscar(sWhere As String) As CDP_Formatos
        ' Busca en la tabla los datos indicados en el par�metro
        ' el par�metro contendr� lo que se usar� despu�s del WHERE
        Dim oCDP_Formatos As CDP_Formatos = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("CDP_Formatos")
        Dim sel As String = "SELECT * FROM CDP_Formatos WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oCDP_Formatos = row2CDP_Formatos(dt.Rows(0))
        End If
        Return oCDP_Formatos
    End Function
    '
    ' Actualizar: Actualiza los datos en la tabla usando la instancia actual
    '             Si la instancia no hace referencia a un registro existente, se crear� uno nuevo
    '             Para comprobar si el objeto en memoria coincide con uno existente,
    '             se comprueba si el FormatoID existe en la tabla.
    '             TODO: Si en lugar de FormatoID usas otro campo, indicalo en la cadena SELECT
    '                   Tambi�n puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    Public Function Actualizar() As String
        ' TODO: Poner aqu� la selecci�n a realizar para acceder a este registro
        '       yo uso el FormatoID que es el identificador �nico de cada registro
        Dim sel As String = "SELECT * FROM CDP_Formatos WHERE FormatoID = " & Me.FormatoID.ToString()
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(sel As String) As String
        ' Actualiza los datos indicados
        ' El par�metro, que es una cadena de selecci�n, indicar� el criterio de actualizaci�n
        '
        ' En caso de error, devolver� la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("CDP_Formatos")
        '
        cnn = New SqlConnection(cadenaConexion)
        'da = New SqlDataAdapter(CadenaSelect, cnn)
        da = New SqlDataAdapter(sel, cnn)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        '
        '-------------------------------------------
        ' Esta no es la m�s �ptima, pero funcionar�
        '-------------------------------------------
        'Dim cb As New SqlCommandBuilder(da)
        'da.UpdateCommand = cb.GetUpdateCommand()
        '
        '--------------------------------------------------------------------
        ' Esta est� m�s optimizada pero debes comprobar que funciona bien...
        '--------------------------------------------------------------------
        Dim sCommand As String
        '
        ' El comando UPDATE
        ' TODO: Comprobar cual es el campo de �ndice principal (sin duplicados)
        '       Yo compruebo que sea un campo llamado FormatoID, pero en tu caso puede ser otro
        '       Ese campo, (en mi caso FormatoID) ser� el que hay que poner al final junto al WHERE.
        sCommand = "UPDATE CDP_Formatos SET EmpresaCodigo = @EmpresaCodigo, Descripcion = @Descripcion, AplicaNumeracion = @AplicaNumeracion, AplicaCtaBancaria = @AplicaCtaBancaria, AplicaImpDespacho = @AplicaImpDespacho, Especificaciones = @Especificaciones, Utilizacion = @Utilizacion, UsuarioResponsable = @UsuarioResponsable, UsuarioSolicitador = @UsuarioSolicitador, UsuarioCreador = @UsuarioCreador, FechaCreacion = @FechaCreacion, UsuarioEditor = @UsuarioEditor, FechaEdicion = @FechaEdicion  WHERE (FormatoID = @FormatoID)"
        da.UpdateCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@FormatoID", SqlDbType.Int, 0, "FormatoID")
        da.UpdateCommand.Parameters.Add("@EmpresaCodigo", SqlDbType.NVarChar, 2, "EmpresaCodigo")
        da.UpdateCommand.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 50, "Descripcion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@AplicaNumeracion", SqlDbType.Bit, 0, "AplicaNumeracion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@AplicaCtaBancaria", SqlDbType.Bit, 0, "AplicaCtaBancaria")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@AplicaImpDespacho", SqlDbType.Bit, 0, "AplicaImpDespacho")
        da.UpdateCommand.Parameters.Add("@Especificaciones", SqlDbType.NVarChar, 200, "Especificaciones")
        da.UpdateCommand.Parameters.Add("@Utilizacion", SqlDbType.NVarChar, 200, "Utilizacion")
        da.UpdateCommand.Parameters.Add("@UsuarioResponsable", SqlDbType.NVarChar, 25, "UsuarioResponsable")
        da.UpdateCommand.Parameters.Add("@UsuarioSolicitador", SqlDbType.NVarChar, 25, "UsuarioSolicitador")
        da.UpdateCommand.Parameters.Add("@UsuarioCreador", SqlDbType.NVarChar, 25, "UsuarioCreador")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 0, "FechaCreacion")
        da.UpdateCommand.Parameters.Add("@UsuarioEditor", SqlDbType.NVarChar, 25, "UsuarioEditor")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@FechaEdicion", SqlDbType.DateTime, 0, "FechaEdicion")
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
            CDP_Formatos2Row(Me, dt.Rows(0))
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
        ' En caso de error, devolver� la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("CDP_Formatos")
        '
        cnn = New SqlConnection(cadenaConexion)
        da = New SqlDataAdapter(CadenaSelect, cnn)
        'da = New SqlDataAdapter(CadenaSelect, cadenaConexion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        '
        '-------------------------------------------
        ' Esta no es la m�s �ptima, pero funcionar�
        '-------------------------------------------
        'Dim cb As New SqlCommandBuilder(da)
        'da.InsertCommand = cb.GetInsertCommand()
        '
        '--------------------------------------------------------------------
        ' Esta est� m�s optimizada pero debes comprobar que funciona bien...
        '--------------------------------------------------------------------
        Dim sCommand As String
        '
        ' El comando INSERT
        ' TODO: No incluir el campo de clave primaria incremental
        '       Yo compruebo que sea un campo llamado FormatoID, pero en tu caso puede ser otro
        sCommand = "INSERT INTO CDP_Formatos (EmpresaCodigo, Descripcion, AplicaNumeracion, AplicaCtaBancaria, AplicaImpDespacho, Especificaciones, Utilizacion, UsuarioResponsable, UsuarioSolicitador, UsuarioCreador, FechaCreacion, UsuarioEditor, FechaEdicion)  VALUES(@EmpresaCodigo, @Descripcion, @AplicaNumeracion, @AplicaCtaBancaria, @AplicaImpDespacho, @Especificaciones, @Utilizacion, @UsuarioResponsable, @UsuarioSolicitador, @UsuarioCreador, @FechaCreacion, @UsuarioEditor, @FechaEdicion)"
        da.InsertCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@FormatoID", SqlDbType.Int, 0, "FormatoID")
        da.InsertCommand.Parameters.Add("@EmpresaCodigo", SqlDbType.NVarChar, 2, "EmpresaCodigo")
        da.InsertCommand.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 50, "Descripcion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@AplicaNumeracion", SqlDbType.Bit, 0, "AplicaNumeracion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@AplicaCtaBancaria", SqlDbType.Bit, 0, "AplicaCtaBancaria")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@AplicaImpDespacho", SqlDbType.Bit, 0, "AplicaImpDespacho")
        da.InsertCommand.Parameters.Add("@Especificaciones", SqlDbType.NVarChar, 200, "Especificaciones")
        da.InsertCommand.Parameters.Add("@Utilizacion", SqlDbType.NVarChar, 200, "Utilizacion")
        da.InsertCommand.Parameters.Add("@UsuarioResponsable", SqlDbType.NVarChar, 25, "UsuarioResponsable")
        da.InsertCommand.Parameters.Add("@UsuarioSolicitador", SqlDbType.NVarChar, 25, "UsuarioSolicitador")
        da.InsertCommand.Parameters.Add("@UsuarioCreador", SqlDbType.NVarChar, 25, "UsuarioCreador")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 0, "FechaCreacion")
        da.InsertCommand.Parameters.Add("@UsuarioEditor", SqlDbType.NVarChar, 25, "UsuarioEditor")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@FechaEdicion", SqlDbType.DateTime, 0, "FechaEdicion")
        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoCDP_Formatos(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo CDP_Formatos"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aqu� la selecci�n a realizar para acceder a este registro
        '       yo uso el FormatoID que es el identificador �nico de cada registro
        Dim sel As String = "SELECT * FROM CDP_Formatos WHERE FormatoID = " & Me.FormatoID.ToString()
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolver� la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("CDP_Formatos")
        '
        cnn = New SqlConnection(cadenaConexion)
        da = New SqlDataAdapter(sel, cnn)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        '
        '-------------------------------------------
        ' Esta no es la m�s �ptima, pero funcionar�
        '-------------------------------------------
        'Dim cb As New SqlCommandBuilder(da)
        'da.DeleteCommand = cb.GetDeleteCommand()
        '
        '
        '--------------------------------------------------------------------
        ' Esta est� m�s optimizada pero debes comprobar que funciona bien...
        '--------------------------------------------------------------------
        Dim sCommand As String
        '
        ' El comando DELETE
        ' TODO: S�lo incluir el campo de clave primaria incremental
        '       Yo compruebo que sea un campo llamado FormatoID, pero en tu caso puede ser otro
        sCommand = "DELETE FROM CDP_Formatos WHERE (FormatoID = @p1)"
        da.DeleteCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.DeleteCommand.Parameters.Add("@p1", SqlDbType.Int, 0, "FormatoID")
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
