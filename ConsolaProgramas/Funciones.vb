
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.Data

Public Class Funciones
    Private cnx As New SqlConnection
    Private str As String = ""

    Private contador As Integer = 0
    Public dsDesarrollo As New DataSet
    Dim siTotal As New GridColumnSummaryItem()

    Public Property Conexion() As SqlConnection
        Get
            Return cnx
        End Get
        Set(ByVal value As SqlConnection)
            cnx = value
        End Set
    End Property

    'Metodo Para cargar tablas.
    Public Sub NewTable(ByVal sel As String, ByVal nombre As String)
        Dim adp As New SqlDataAdapter(sel, cnx)

        adp.Fill(dsDesarrollo)
        dsDesarrollo.Tables(contador).TableName = nombre
        contador = contador + 1

    End Sub
    'Metodo para cargar Comboboxes
    Public Sub SetCombo(ByVal cmb As Windows.Forms.ComboBox, ByVal tabla As DataTable, ByVal Display As String, ByVal Value As String, ByVal posicion As Integer)

        cmb.DataSource = tabla
        cmb.DisplayMember = Display
        cmb.ValueMember = Value
        cmb.SelectedIndex = posicion
        cmb.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub
    Public Sub initGrid(ByVal dg As DataGridView, ByVal tabla As DataTable, ByVal add As Boolean, ByVal del As Boolean, ByVal hide As String, ByVal align As DataGridViewContentAlignment)
        Dim column As String = ""
        dg.DataSource = tabla

        For i As Integer = 0 To hide.Length - 1
            If hide.Chars(i) <> "," Then
                column = column + hide.Chars(i)
            Else
                dg.Columns(column).Visible = False
                column = ""
            End If

            If i = hide.Length - 1 Then

                dg.Columns(column).Visible = False
            End If
        Next

        dg.AllowUserToAddRows = add
        dg.AllowUserToDeleteRows = del
        dg.AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue
        dg.ColumnHeadersDefaultCellStyle.Alignment = align
    End Sub
    Public Sub InitGridControl(ByVal gc As GridControl, ByVal gv As GridView, ByVal tabla As DataTable, ByVal hide As String, ByVal edit As Boolean)
        Dim column As String = ""
        gc.DataSource = tabla

        For i As Integer = 0 To hide.Length - 1
            If hide.Chars(i) <> "," Then
                column = column + hide.Chars(i)
            Else
                gv.Columns(column).Visible = False
                column = ""
            End If

            If i = hide.Length - 1 Then

                gv.Columns(column).Visible = False
            End If

        Next

        gv.OptionsBehavior.Editable = edit
        gv.OptionsCustomization.AllowFilter = False

    End Sub
    Public Sub InitGridControl(ByVal gc As GridControl, ByVal gv As Views.Card.CardView, ByVal tabla As DataTable, ByVal hide As String, ByVal edit As Boolean)
        Dim column As String = ""
        gc.DataSource = tabla

        'For i As Integer = 0 To hide.Length - 1
        '    If hide.Chars(i) <> "," Then
        '        column = column + hide.Chars(i)
        '    Else
        '        gv.Columns(column).Visible = False
        '        column = ""
        '    End If

        '    If i = hide.Length - 1 Then

        '        gv.Columns(column).Visible = False
        '    End If

        'Next

        ' gv.OptionsBehavior.Editable = edit
        ' gv.OptionsCustomization.AllowFilter = False
    End Sub
    Public Sub FormatColumnGridControl(ByVal gv As Views.Card.CardView, ByVal Column As String, ByVal title As String, ByVal wid As Integer, ByVal format As DevExpress.Utils.FormatType, ByVal read As Boolean)
        gv.Columns(Column).Caption = title
        gv.Columns(Column).Width = wid
        gv.Columns(Column).OptionsColumn.AllowEdit = read
        gv.Columns(Column).DisplayFormat.FormatType = format

    End Sub
    Public Sub FormatColumnGridControl(ByVal gv As GridView, ByVal Column As String, ByVal title As String, ByVal wid As Integer, ByVal format As DevExpress.Utils.FormatType, ByVal Edit As Boolean)
        gv.Columns(Column).Caption = title
        gv.Columns(Column).Width = wid
        gv.Columns(Column).OptionsColumn.AllowEdit = Edit
        gv.Columns(Column).DisplayFormat.FormatType = format
    End Sub
    Public Sub FormatColumnGridControl(ByVal gv As GridView, ByVal Column As String, ByVal title As String, ByVal wid As Integer, ByVal formaType As DevExpress.Utils.FormatType, format As String, ByVal Edit As Boolean)
        'Dim colModelPrice As GridColumn = gv.Columns(Column)

        gv.Columns(Column).Caption = title
        gv.Columns(Column).Width = wid
        gv.Columns(Column).OptionsColumn.AllowEdit = Edit
        gv.Columns(Column).DisplayFormat.FormatType = formaType
        gv.Columns(Column).DisplayFormat.FormatString = format
    End Sub
    Public Sub FormatColumn(ByVal dg As DataGridView, ByVal Column As String, ByVal title As String, ByVal wid As Integer, ByVal align As String, ByVal read As Boolean)
        dg.Columns(Column).HeaderText = title
        dg.Columns(Column).Width = wid
        dg.Columns(Column).ReadOnly = read
        If align = "R" Then

            dg.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft

        Else
            dg.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        End If

    End Sub
    Public Function getDataTable(ByVal sel As String) As DataTable
        Dim dt As New DataTable
        Dim adp As New SqlDataAdapter(sel, cnx)
        adp.Fill(dt)

        Return dt
    End Function
    Public Function getComboBoxColumn(ByVal Name As String, ByVal table As DataTable, ByVal pro As String, ByVal Display As String, ByVal value As String, ByVal title As String, ByVal wid As Integer) As DataGridViewComboBoxColumn
        Dim combo As New DataGridViewComboBoxColumn

        combo.DataSource = table
        combo.DisplayMember = Display
        combo.ValueMember = value
        combo.DisplayStyleForCurrentCellOnly = True
        combo.HeaderText = title
        combo.DataPropertyName = pro
        combo.Width = wid

        Return combo
    End Function
    Public Sub AutoCompletar(ByVal txtTextbox As TextBox, ByVal table As String, ByVal field As String, ByVal CompleteMode As AutoCompleteMode)

        Dim dr As SqlDataReader
        Dim cmd As SqlCommand
        cmd = New SqlCommand("Select " & field & " from " & table, cnx)

        txtTextbox.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtTextbox.AutoCompleteMode = CompleteMode
        dr = cmd.ExecuteReader()
        Try
            While (dr.Read()) 'La propiedad Read contien las filas del campo que se recupero
                txtTextbox.AutoCompleteCustomSource.Add(dr(field))
            End While
            dr.Close()

        Catch ex As Exception

        End Try
    End Sub
    Public Function getSQLType(ByVal txt As String) As SqlDbType
        Dim tipo = New SqlDbType()
        If txt = "varchar" Then
            tipo = SqlDbType.VarChar

        ElseIf txt = "int" Then
            tipo = SqlDbType.Int

        ElseIf txt = "datetime" Then
            tipo = SqlDbType.DateTime

        ElseIf txt = "bit" Then
            tipo = SqlDbType.Bit

        ElseIf txt = "time" Then
            tipo = SqlDbType.Time

        ElseIf txt = "image" Then
            tipo = SqlDbType.Image
        End If


        Return tipo
    End Function

    'Public Function GetID(column As String) As Integer

    '    Dim valor As Integer
    '    valor = Convert.ToInt32(gv1.GetFocusedRowCellDisplayText(column))
    '    Return valor
    '    'gridView.GetRowCellValue(gridView.FocusedRowHandle, "ArticuloID").ToString()
    'End Function

    Public Function getSQLComand(ByVal txt As String) As SqlCommand
        Dim cmd As SqlCommand
        Dim adp As New SqlDataAdapter("spGetParametroDB " & txt, cnx)
        Dim dtb As New DataTable()

        adp.Fill(dtb)


        cmd = New SqlCommand(txt, cnx)
        cmd.CommandType = CommandType.StoredProcedure

        For i As Integer = 0 To dtb.Rows.Count - 1
            cmd.Parameters.Add(dtb.Rows(i).Item("Pname"), getSQLType(dtb.Rows(i).Item("Tname")), dtb.Rows(i).Item("Size"), dtb.Rows(i).Item("Columna"))
        Next

        Return cmd
    End Function
    Public Function getSQLComand(ByVal txt As String, prm As SqlParameter) As SqlCommand

        Dim cmd As SqlCommand
        Dim adp As New SqlDataAdapter("spGetParametroDB " & txt, cnx)
        Dim dtb As New DataTable()

        adp.Fill(dtb)

        cmd = New SqlCommand(txt, cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(prm)

        For i As Integer = 0 To dtb.Rows.Count - 1
            If prm.ParameterName.ToString().ToLower() = dtb.Rows(i).Item("Columna").ToString().ToLower() Then
                dtb.Rows.Remove(dtb.Rows(i))

            End If
        Next


        For i As Integer = 0 To dtb.Rows.Count - 1
            cmd.Parameters.Add(dtb.Rows(i).Item("Pname"), getSQLType(dtb.Rows(i).Item("Tname")), dtb.Rows(i).Item("Size"), dtb.Rows(i).Item("Columna"))
        Next

        Return cmd
    End Function
    Public Sub getLookUpEdit(ByVal gc As GridControl, ByVal gv As GridView, ByVal Table As DataTable, ByVal Display As String, ByVal value As String, ByVal Name As String, ByVal ColumnName As String)
        Dim edit As RepositoryItemLookUpEdit = New RepositoryItemLookUpEdit()
        edit.DataSource = Table
        edit.ValueMember = value
        edit.DisplayMember = Display
        edit.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo(Name))
        gc.RepositoryItems.Add(edit)
        gv.Columns(ColumnName).ColumnEdit = edit

    End Sub
    Public Sub getGridLookUpEdit(ByVal gc As GridControl, ByVal gv As GridView, ByVal Table As DataTable, ByVal Display As String, ByVal value As String, ByVal Name As String, ByVal ColumnName As String)
        Dim edit As RepositoryItemGridLookUpEdit = New RepositoryItemGridLookUpEdit()
        edit.DataSource = Table
        edit.ValueMember = value
        edit.DisplayMember = Display
        edit.View.OptionsView.ShowAutoFilterRow = True
        gc.RepositoryItems.Add(edit)
        gv.Columns(ColumnName).ColumnEdit = edit

    End Sub

    Public Sub getTimeEdit(ByVal gc As GridControl, ByVal gv As GridView, ByVal ColumnName As String)
        Dim edit As RepositoryItemTimeEdit = New RepositoryItemTimeEdit()

        gc.RepositoryItems.Add(edit)
        gv.Columns(ColumnName).ColumnEdit = edit

    End Sub

    Public Sub SetGridLookUpEdit(cmb As LookUpEdit, dt As DataTable, valueMember As String, Display As String)

        cmb.Properties.DataSource = dt
        cmb.Properties.ValueMember = valueMember
        cmb.Properties.DisplayMember = Display
        cmb.Properties.PopulateColumns()
    End Sub

    Public Sub SetGridLookUpEdit(cmb As LookUpEdit, dt As DataTable, valueMember As String, Display As String, hide As String)
        cmb.Properties.DataSource = dt
        cmb.Properties.ValueMember = valueMember
        cmb.Properties.DisplayMember = Display
        cmb.Properties.PopulateColumns()
        cmb.Properties.Columns(hide).Visible = False
    End Sub
    Public Sub SetGridLookUpEdit(cmb As GridLookUpEdit, dt As DataTable, valueMember As String, Display As String, hide As String)
        cmb.Properties.View.OptionsView.ShowAutoFilterRow = True
        cmb.Properties.DataSource = dt
        cmb.Properties.ValueMember = valueMember
        cmb.Properties.DisplayMember = Display
        cmb.Properties.View.Columns(hide).Visible = False

    End Sub
    Public Sub SetGridLookUpEdit(cmb As GridLookUpEdit, dt As DataTable, valueMember As String, Display As String)
        cmb.Properties.View.OptionsView.ShowAutoFilterRow = True
        cmb.Properties.DataSource = dt
        cmb.Properties.ValueMember = valueMember
        cmb.Properties.DisplayMember = Display
    End Sub
    Public Sub AddSummary(type As SummaryItemType, gv As GridView, column As String, format As String)
        siTotal = New GridColumnSummaryItem()
        siTotal.SummaryType = type
        siTotal.DisplayFormat = format
        gv.Columns(column).Summary.Add(siTotal)
    End Sub
    Public Sub RemoveSummary(gv As GridView, Column As String)
        gv.Columns(Column).Summary.Remove(siTotal)
    End Sub
   
End Class
