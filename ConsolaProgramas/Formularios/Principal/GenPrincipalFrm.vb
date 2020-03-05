'Proyecto      : Consola de Programas
'Descripcion   : 
'Objetivos     : 
'Version       : 
'Tecnologias de la Informacion Grupo CAHSA
'Fecha         : Octubre/2014

Imports DevExpress.Utils
Imports DevExpress.Skins
Imports DevExpress.XtraEditors
Imports System.Threading
Imports System.ComponentModel
Imports System.Text
Imports System.Globalization
Imports LibDAO001
Imports System.Data.SqlClient
Imports DevExpress.XtraSplashScreen

Public Class GenPrincipalFrm
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    Public ClsU As New ClsUtilitarios
    Public FnxAccesos As ClsVistas = Nothing
    Public dtUsuarios, dtFormxPerfil As DataTable
    Public usuario, carpetaRaiz, nombreServidorRep, perfil, grupo, pw, xEmpresaID, Password As String 'perfil = area
    Public idusuario, idgrupo, idarea, EmpresaID, PerfilID, contador As Int32

    Dim cnxProduccion, cnxFinanzas, cnxBiosalc, cnxProteanERP, cnxBiosalcTest, cnxFinanzasTest, cnxAssetsTest As SqlConnection
    Dim adp As SqlDataAdapter
    Dim dt As New DataTable
    Dim tiempo As Integer = 480

    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub GenPrincipalFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'xCultureInfo()
        Thread.Sleep(2000) 'Ejecutar formulario Splash Screen
        CargarComboSkins() 'Cargar lista de bonus Skin
        Me.WindowState = FormWindowState.Maximized
        cmbLogin.PerformClick()

    End Sub

    Sub xCultureInfo()
        Dim cultura As CultureInfo
        For Each cultura In CultureInfo.GetCultures(CultureTypes.InstalledWin32Cultures)
            Console.WriteLine("Cultura: " & cultura.Name)
            Console.WriteLine(vbTab & "Nombre: " & cultura.DisplayName)
            Console.WriteLine(vbTab & "Símbolo de la moneda: " & cultura.NumberFormat.CurrencySymbol)
            Console.WriteLine(vbTab & "Formato de la fecha: " & cultura.DateTimeFormat.FullDateTimePattern)
        Next
    End Sub

    Public Sub CargarComboSkins()
        Dim combo As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Dim barManager1 As New DevExpress.XtraBars.BarManager()
        barManager1.ForceInitialize()

        combo = TryCast(barManager1.RepositoryItems.Add("ComboBoxEdit"), 
                        DevExpress.XtraEditors.Repository.RepositoryItemComboBox)

        For Each cnt As SkinContainer In SkinManager.Default.Skins
            combo.Items.Add(cnt.SkinName)
        Next cnt

        cbxSkins.Edit = combo
        'bxSkins.EditValue = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName
        cbxSkins.EditValue = "The Asphalt World"
    End Sub

    Private Sub cmbCalculadora_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmbCalculadora.ItemClick
        'Ejecutar la Calculadora
        Shell("C:\WINDOWS\system32\calc.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub cmbNotepad_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmbNotepad.ItemClick
        'Ejecutar el BLoc de notas
        Shell("C:\WINDOWS\system32\notepad.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub cmbEnvioCorreos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmbEnvioCorreos.ItemClick
        MsgBox("Opcion no disponible", MsgBoxStyle.Exclamation, "Atencion:")
    End Sub

    Private Sub cmbCalendario_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmbCalendario.ItemClick
        GenCalendarioFrm.ShowDialog()
    End Sub

    Private Sub cmbHerSkinDef_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmbHerSkinDef.ItemClick
        rcPrincipal.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Default
    End Sub

    Private Sub cmbHerSkin2007_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmbHerSkin2007.ItemClick
        rcPrincipal.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007
    End Sub

    Private Sub cmbHerSkin2010_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmbHerSkin2010.ItemClick
        rcPrincipal.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
    End Sub

    Private Sub cmbHerSkin2013_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmbHerSkin2013.ItemClick
        rcPrincipal.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
    End Sub

    Private Sub cmbHerSkinMac_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmbHerSkinMac.ItemClick
        rcPrincipal.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice
    End Sub

    Private Sub cmbHerSkinTablet_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmbHerSkinTablet.ItemClick
        rcPrincipal.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.TabletOffice
    End Sub

    Private Sub cmbHerSkinTabletEx_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmbHerSkinTabletEx.ItemClick
        'rcPrincipal.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.TabletOfficeEx
    End Sub

    Private Sub cbxSkins_EditValueChanged(sender As Object, e As EventArgs) Handles cbxSkins.EditValueChanged
        Dim skinName As String = cbxSkins.EditValue.ToString
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = skinName
    End Sub

    Private Sub cmbAcercaDe_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmbAcercaDe.ItemClick
        GenAcercaDeFrm.ShowDialog()
    End Sub

    Public Sub CerrarFormulariosActivos()

        Dim ProgramacionCosecha As CPRProgramacionCosecha = CType(Application.OpenForms("CPRProgramacionCosecha"), CPRProgramacionCosecha)
        If Not ProgramacionCosecha Is Nothing Then
            ProgramacionCosecha.Close()
        End If

        Dim OrdenQuema As AprOrdenQuemaFrm = CType(Application.OpenForms("AprOrdenQuemaFrm"), AprOrdenQuemaFrm)
        If Not OrdenQuema Is Nothing Then
            OrdenQuema.Close()
        End If

        Dim AvanceCosecha As BprAvanceCosechaFrm = CType(Application.OpenForms("BprAvanceCosechaFrm"), BprAvanceCosechaFrm)
        If Not AvanceCosecha Is Nothing Then
            AvanceCosecha.Close()
        End If
        'Dim areas As AdmMtoAreasFrm = CType(Application.OpenForms("AdmMtoAreasFrm"), AdmMtoAreasFrm)
        'If Not areas Is Nothing Then
        '    areas.Close()
        'End If
        'Dim visor As AdmVisorRepFrm = CType(Application.OpenForms("AdmVisorRepFrm"), AdmVisorRepFrm)
        'If Not visor Is Nothing Then
        '    visor.Close()
        'End If
        'Dim cr As RptVisorCRFrm = CType(Application.OpenForms("RptVisorCRFrm"), RptVisorCRFrm)
        'If Not cr Is Nothing Then
        '    cr.Close()
        'End If
    End Sub
    Private Sub cmbLogin_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmbLogin.ItemClick
        CerrarFormulariosActivos()
        Dim frmLoginx As XGenLogin = New XGenLogin
        'XGenLogin.ShowDialog() 'GenLoginFrm.ShowDialog()
        frmLoginx.ShowDialog()
        'If frmLoginx.indicador = 1 Then
        '    'Obtener la informacion del usuario (Grupo/Area)
        '    idgrupo = GenLoginFrm.idgrupo
        '    grupo = GenLoginFrm.grupo
        '    idarea = GenLoginFrm.idarea
        '    perfil = GenLoginFrm.area
        xEmpresaID = frmLoginx.XEmpresaID
        EmpresaID = CInt(xEmpresaID)
        usuario = frmLoginx.usert
        idusuario = frmLoginx.idUser
        barTxtPerfil.Caption = frmLoginx.DescPerfil
        barTxtUsuario.Caption = usuario
        barTxtEmpresa.Caption = frmLoginx.XEmpresa
        frmLoginx.txtPassword.Focus()

        dtUsuarios = frmLoginx.dta
        pw = frmLoginx.passt
        PerfilID = Convert.ToInt32(dtUsuarios.Rows(0)(2).ToString())

        'Verifica perfil del usuario, para desbloquear las opciones del menu de acuerdo a permisos
        'fnxValidarPermisosOpcionesMenu(PerfilID)
        ValidarListaPermisos_Sistema_FactDEI(PerfilID)

        'HabilitarEtiquetas()
        'cmbProgramacionCosecha.Enabled = True
        'cmbAvanceCosecha.Enabled = True
        'cmbAgregadosBoletaPeso.Enabled = True
        'Else
        '    cmbProgramacionCosecha.Enabled = False
        '    cmbAvanceCosecha.Enabled = False
        '    cmbAgregadosBoletaPeso.Enabled = False
        'End If
    End Sub

    Public Sub ValidarListaPermisos_Sistema_FactDEI(id As Int32)
        'Desde Aqui
        ''Botones del Sistema Fact.DEI
        'CmbEmpresas.Enabled = False
        'CmbClientes.Enabled = False
        'CmbTiposDoctos.Enabled = False
        'CmbMonedas.Enabled = False
        'CmbProductos.Enabled = False
        'CmbUnidadesMedida.Enabled = False
        'CmbItems.Enabled = False
        'CmbRetenciones.Enabled = False
        'CmbConductores.Enabled = False
        'CmbTransportistas.Enabled = False
        'CmbFXC.Enabled = False
        'CmbFactExp.Enabled = False
        'CmbND.Enabled = False
        'CmbNC.Enabled = False
        'CmbBoletasRemision.Enabled = False
        'CmbComprobRet.Enabled = False
        'CmbBolVen.Enabled = False
        'CmbCAIXSdN.Enabled = False
        'CmbRegCompras.Enabled = False
        'CmbImportaciones.Enabled = False
        'CmbFactBoletaCompra.Enabled = False
        'CmbGenRemision.Enabled = False

        ''Botones BioSalc - Servicios Agricolas Asientos Contables
        ''Modificado por: Ing. Manuel Ortega | 28/03/2019 - 05:19 pm
        'CmbSerExtAprobacionMO.Enabled = False
        'CmbSerExtGenAsientosMO.Enabled = False
        'CmbServAprobMAQ.Enabled = False
        'CmbServGenAsientosMAQ.Enabled = False
        'CmbServAprobARG.Enabled = False
        'CmbServGenAsientosARG.Enabled = False

        'Try
        '    cnx = New SqlClient.SqlConnection("Persist Security Info=False;User ID=" & usuario & ";Password=" & pw & ";Initial Catalog=Finanzas;Server=AMIGODB\AMIGODB")
        '    adp = New SqlClient.SqlDataAdapter("select AplicaGenRemisiones, AplicaAnulacionCAI from Produccion.dbo.aaa_ListaUsuarios	where UsuarioID = '" & usuario & "'", cnx)
        '    adp.Fill(dt)


        '    If dt.DefaultView.Item(0).Item("AplicaGenRemisiones") Then
        '        CmbGenRemision.Enabled = True
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        'If id = 1 Then 'Perfil Administrador Sistema Fact.DEI
        '    CmbEmpresas.Enabled = True
        '    CmbClientes.Enabled = True
        '    CmbTiposDoctos.Enabled = True
        '    CmbMonedas.Enabled = True
        '    CmbProductos.Enabled = True
        '    CmbUnidadesMedida.Enabled = True
        '    CmbItems.Enabled = True
        '    CmbRetenciones.Enabled = True
        '    CmbConductores.Enabled = True
        '    CmbTransportistas.Enabled = True
        '    CmbFXC.Enabled = True
        '    CmbFactExp.Enabled = True
        '    CmbND.Enabled = True
        '    CmbNC.Enabled = True
        '    CmbBoletasRemision.Enabled = True
        '    CmbComprobRet.Enabled = True
        '    CmbBolVen.Enabled = True
        '    CmbCAIXSdN.Enabled = True
        '    CmbRegCompras.Enabled = True
        '    CmbImportaciones.Enabled = True
        '    CmbFactBoletaCompra.Enabled = True

        '    CmbSerExtAprobacionMO.Enabled = True
        '    CmbSerExtGenAsientosMO.Enabled = True
        '    CmbServAprobMAQ.Enabled = True
        '    CmbServGenAsientosMAQ.Enabled = True
        '    CmbServAprobARG.Enabled = True
        '    CmbServGenAsientosARG.Enabled = True
        'Else
        '    If PerfilID = 18 Then 'Perfil 18 - Operador de Bascula - Actualizacion QuemaID en BoletaCana
        '        'Para obtener toneladas cortadas por quema accidental - Sistema de Gestion Calidad
        '        'Gerencia | Calidad - 25/01/2017
        '        cmbAgregadosBoletaPeso.Enabled = True
        '    Else
        '        'Habilitar formularios segun perfil de usuario
        '        FnxAccesos = New ClsVistas()
        '        dtFormxPerfil = FnxAccesos.ObtenerFormxPerfil(usuario, pw, 1, PerfilID)
        '        contador = dtFormxPerfil.Rows.Count
        '        If contador > 0 Then
        '            'Recorrer lista de formularios segun perfil
        '            For Each fila As DataRow In dtFormxPerfil.Rows
        '                Dim xPrgID As Integer = CInt(fila(1))
        '                Dim xFormID As Integer = CInt(fila(2))
        '                If xPrgID = CInt(rPagIDF.Tag.ToString) Then 'Acceso a Modulo IDF
        '                    If xFormID = CInt(CmbEmpresas.Tag.ToString()) Then
        '                        CmbEmpresas.Enabled = True
        '                    End If
        '                    If xFormID = CInt(CmbClientes.Tag.ToString()) Then
        '                        CmbClientes.Enabled = True
        '                    End If
        '                    If xFormID = CInt(CmbTiposDoctos.Tag.ToString()) Then
        '                        CmbTiposDoctos.Enabled = True
        '                    End If
        '                    If xFormID = CInt(CmbMonedas.Tag.ToString()) Then
        '                        CmbMonedas.Enabled = True
        '                    End If
        '                    If xFormID = CInt(CmbProductos.Tag.ToString()) Then
        '                        CmbProductos.Enabled = True
        '                    End If
        '                    If xFormID = CInt(CmbUnidadesMedida.Tag.ToString()) Then
        '                        CmbUnidadesMedida.Enabled = True
        '                    End If
        '                    If xFormID = CInt(CmbItems.Tag.ToString()) Then
        '                        CmbItems.Enabled = True
        '                    End If
        '                    If xFormID = CInt(CmbRetenciones.Tag.ToString()) Then
        '                        CmbRetenciones.Enabled = True
        '                    End If
        '                    If xFormID = CInt(CmbConductores.Tag.ToString()) Then
        '                        CmbConductores.Enabled = True
        '                    End If
        '                    If xFormID = CInt(CmbTransportistas.Tag.ToString()) Then
        '                        CmbTransportistas.Enabled = True
        '                    End If
        '                    If xFormID = CInt(CmbFXC.Tag.ToString()) Then
        '                        CmbFXC.Enabled = True
        '                    End If
        '                    If xFormID = CInt(CmbFactExp.Tag.ToString()) Then
        '                        CmbFactExp.Enabled = True
        '                    End If
        '                    If xFormID = CInt(CmbND.Tag.ToString()) Then
        '                        CmbND.Enabled = True
        '                    End If
        '                    If xFormID = CInt(CmbNC.Tag.ToString()) Then
        '                        CmbNC.Enabled = True
        '                    End If
        '                    If xFormID = CInt(CmbBoletasRemision.Tag.ToString()) Then
        '                        CmbBoletasRemision.Enabled = True
        '                    End If
        '                    If xFormID = CInt(CmbComprobRet.Tag.ToString()) Then
        '                        CmbComprobRet.Enabled = True
        '                    End If
        '                    If xFormID = CInt(CmbBolVen.Tag.ToString()) Then
        '                        CmbBolVen.Enabled = True
        '                    End If
        '                    If xFormID = CInt(CmbFactBoletaCompra.Tag.ToString()) Then
        '                        CmbFactBoletaCompra.Enabled = True

        '                    End If
        '                End If
        '            Next

        '            'Validar el Acceso al formulario de empresa y generació y anulación de documentos CAI
        '            If dt.Rows(0).Item("AplicaAnulacionCAI") Then
        '                CmbEmpresas.Enabled = True
        '            End If


        '            'Validacion Temporal para usar el sistema BioSalc - Aprobacion Servicios Agricolas Contable
        '            'Fecha: Jueves, 28/03/2019 - 05:38 pm
        '            'Este proceso es mientras Lic. Jeffry Cabrera realiza las configuraciones respectivas

        '            If usuario = "slara" Then '--Silvia Lara Contabilidad AYSA
        '                CmbSerExtAprobacionMO.Enabled = False
        '                CmbSerExtGenAsientosMO.Enabled = True
        '                CmbServAprobMAQ.Enabled = True
        '                CmbServGenAsientosMAQ.Enabled = True
        '                CmbServAprobARG.Enabled = False
        '                CmbServGenAsientosARG.Enabled = False
        '            End If

        '            If usuario = "aavila" Then '--Alfredo Avila Contabilidad CAHSA
        '                CmbSerExtAprobacionMO.Enabled = False
        '                CmbSerExtGenAsientosMO.Enabled = True
        '                CmbServAprobMAQ.Enabled = True
        '                CmbServGenAsientosMAQ.Enabled = True
        '                CmbServAprobARG.Enabled = False
        '                CmbServGenAsientosARG.Enabled = False
        '            End If
        '            If usuario = "ccastellanos" Then '--Caren Castellanos Contabilidad AYSA
        '                CmbSerExtAprobacionMO.Enabled = False
        '                CmbSerExtGenAsientosMO.Enabled = False
        '                CmbServAprobMAQ.Enabled = True
        '                CmbServGenAsientosMAQ.Enabled = True
        '                CmbServAprobARG.Enabled = False
        '                CmbServGenAsientosARG.Enabled = False
        '            End If
        '            If usuario = "nmadrid" Then '--Nahun Madrid Contabilidad CAHSA
        '                CmbSerExtAprobacionMO.Enabled = False
        '                CmbSerExtGenAsientosMO.Enabled = False
        '                CmbServAprobMAQ.Enabled = True
        '                CmbServGenAsientosMAQ.Enabled = True
        '                CmbServAprobARG.Enabled = True
        '                CmbServGenAsientosARG.Enabled = True
        '            End If
        '        Else
        '            If usuario = "nfunes" Then '--Nancy Funes Auditoria Produccion CAHSA
        '                CmbSerExtAprobacionMO.Enabled = True
        '                CmbSerExtGenAsientosMO.Enabled = False
        '                CmbServAprobMAQ.Enabled = True
        '                CmbServGenAsientosMAQ.Enabled = False
        '                CmbServAprobARG.Enabled = False
        '                CmbServGenAsientosARG.Enabled = False
        '            End If
        '            ClsU.NotaCompleta("El perfil del usuario # " & barTxtPerfil.Caption & " no tiene los permisos respectivos. ID Usuario: " & idusuario, 16)
        '        End If
        '    End If
        'End If

        'Nuevo método para Validar Accesos
        Dim dtAcceso As New DataTable
        Dim adpAcceso As SqlDataAdapter

        cnxProduccion = New SqlConnection("Persist Security Info=False;User ID=" & usuario & ";Password=" & pw & ";Initial Catalog=Produccion;Server=AMIGODB\AMIGODB")
        cnxFinanzas = New SqlConnection("Persist Security Info=False;User ID=" & usuario & ";Password=" & pw & ";Initial Catalog=Finanzas;Server=AMIGODB\AMIGODB")
        cnxBiosalc = New SqlConnection("Persist Security Info=False;User ID=" & usuario & ";Password=" & pw & ";Initial Catalog=Biosalc;Server=AMIGODB\AMIGODB")
        cnxBiosalcTest = New SqlConnection("Persist Security Info=False;User ID=" & usuario & ";Password=" & pw & ";Initial Catalog=Biosalc;Server=10.1.1.34\developerdb")
        cnxFinanzasTest = New SqlConnection("Persist Security Info=False;User ID=" & usuario & ";Password=" & pw & ";Initial Catalog=Finanzas;Server=10.1.1.34\developerdb")
        cnxAssetsTest = New SqlConnection("Persist Security Info=False;User ID=" & usuario & ";Password=" & pw & ";Initial Catalog=Assets;Server=10.1.1.34\developerdb")
        cnxProteanERP = New SqlConnection("Persist Security Info=False;User ID=" & usuario & ";Password=" & pw & ";Initial Catalog=ProteanERP;Server=AMIGODB\AMIGODB")
        Try
            adpAcceso = New SqlDataAdapter("spAccesosXUsuario", cnxProduccion)
            adpAcceso.SelectCommand.CommandType = CommandType.StoredProcedure
            adpAcceso.SelectCommand.Parameters.AddWithValue("@user", usuario)
            adpAcceso.Fill(dtAcceso)

            For Each control As DevExpress.XtraBars.BarItem In rcPrincipal.Items
                For i As Integer = 0 To dtAcceso.Rows.Count - 1
                    If dtAcceso.Rows(i).Item("codigo") = control.Name Then
                        control.Enabled = True
                    End If
                Next

            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try


    End Sub

    'Public Sub ValidarListaPermisos_Sistema_Produccion(id As Int32)
    '    'Botones del Sistema
    '    cmbAvanceCosecha.Enabled = False
    '    cmbProgramacionCosecha.Enabled = False
    '    cmbCargarEstimadosProd.Enabled = False
    '    cmbMtoProgramasCosecha.Enabled = False
    '    cmbMtoPlanesCosecha.Enabled = False
    '    CmbMtoLecturaPluv.Enabled = False

    '    If id = 17 Then 'Perfil Administrador Sistema Produccion
    '        cmbAvanceCosecha.Enabled = True
    '        cmbProgramacionCosecha.Enabled = True
    '        cmbCargarEstimadosProd.Enabled = True
    '        cmbMtoProgramasCosecha.Enabled = True
    '        cmbMtoPlanesCosecha.Enabled = True
    '        CmbMtoLecturaPluv.Enabled = True
    '    Else
    '        'Habilitar formularios segun perfil de usuario
    '        FnxAccesos = New ClsVistas()
    '        dtFormxPerfil = FnxAccesos.ObtenerFormxPerfil(usuario, pw, 1, PerfilID)
    '        contador = dtFormxPerfil.Rows.Count
    '        If contador > 0 Then
    '            'Recorrer lista de formularios segun perfil
    '            For Each fila As DataRow In dtFormxPerfil.Rows
    '                Dim xPrgID As Integer = CInt(fila(1))
    '                Dim xFormID As Integer = CInt(fila(2))
    '                If xPrgID = CInt(rPagIDF.Tag.ToString) Then 'Acceso a Modulo
    '                    If xFormID = CInt(cmbAvanceCosecha.Tag.ToString()) Then
    '                        cmbAvanceCosecha.Enabled = True
    '                    End If
    '                    If xFormID = CInt(cmbProgramacionCosecha.Tag.ToString()) Then
    '                        cmbProgramacionCosecha.Enabled = True
    '                    End If
    '                    If xFormID = CInt(cmbCargarEstimadosProd.Tag.ToString()) Then
    '                        cmbCargarEstimadosProd.Enabled = True
    '                    End If
    '                    If xFormID = CInt(cmbMtoProgramasCosecha.Tag.ToString()) Then
    '                        cmbMtoProgramasCosecha.Enabled = True
    '                    End If
    '                    If xFormID = CInt(cmbMtoPlanesCosecha.Tag.ToString()) Then
    '                        cmbMtoPlanesCosecha.Enabled = True
    '                    End If
    '                    If xFormID = CInt(CmbMtoLecturaPluv.Tag.ToString()) Then
    '                        CmbMtoLecturaPluv.Enabled = True
    '                    End If
    '                End If
    '            Next
    '        Else
    '            ClsU.NotaCompleta("El perfil del usuario # " & barTxtPerfil.Caption & " no tiene los permisos respectivos. ID Usuario: " & idusuario, 16)
    '        End If
    '    End If
    'End Sub

    'Public Sub ValidarListaPermisos_Sistema_Bascula(id As Int32)
    '    'Botones del Sistema
    '    cmbAgregadosBoletaPeso.Enabled = False
    '    If id = 19 Then 'Perfil Administrador Sistema Bascula
    '        cmbAgregadosBoletaPeso.Enabled = True
    '    Else
    '        'Habilitar formularios segun perfil de usuario
    '        FnxAccesos = New ClsVistas()
    '        dtFormxPerfil = FnxAccesos.ObtenerFormxPerfil(usuario, pw, 1, PerfilID)
    '        contador = dtFormxPerfil.Rows.Count
    '        If contador > 0 Then
    '            'Recorrer lista de formularios segun perfil
    '            For Each fila As DataRow In dtFormxPerfil.Rows
    '                Dim xPrgID As Integer = CInt(fila(1))
    '                Dim xFormID As Integer = CInt(fila(2))
    '                If xPrgID = CInt(rPagIDF.Tag.ToString) Then 'Acceso a Modulo IDF
    '                    If xFormID = CInt(cmbAgregadosBoletaPeso.Tag.ToString()) Then
    '                        cmbAgregadosBoletaPeso.Enabled = True
    '                    End If

    '                End If
    '            Next
    '        Else
    '            ClsU.NotaCompleta("El perfil del usuario # " & barTxtPerfil.Caption & " no tiene los permisos respectivos. ID Usuario: " & idusuario, 16)
    '        End If
    '    End If
    'End Sub
    'Hasta Aqui
    'Public Sub fnxValidarPermisosOpcionesMenu(id As Int32)
    '    ValidarListaPermisos_Sistema_FactDEI(id)
    '    'ValidarListaPermisos_Sistema_Produccion(id)
    '    'ValidarListaPermisos_Sistema_Bascula(id)
    'End Sub

    Private Sub cmbOrdenQuema_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmbOrdenQuema.ItemClick
        AprOrdenQuemaFrm.FuncionInicial(usuario, pw)
        AprOrdenQuemaFrm.MdiParent = Me
        'AprOrdenQuemaFrm.strUsuario = usuario
        'AprOrdenQuemaFrm.strPassword = pw
        AprOrdenQuemaFrm.Show()
    End Sub

    Private Sub cmbAvanceCosecha_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmbAvanceCosecha.ItemClick
        'BprAvanceCosechaFrm.FuncionInicial(usuario, pw)
        'BprAvanceCosechaFrm.MdiParent = Me
        'BprAvanceCosechaFrm.Show()
        Dim frm As BprAvanceCosechaFrm = New BprAvanceCosechaFrm()
        frm.FuncionInicial(usuario, pw)
        frm.ShowDialog()
        'Dim frm As BprAvanceCosechaDetalle = New BprAvanceCosechaDetalle()
        'frm.FuncionInicial(usuario, pw)
        'frm.ShowDialog()
    End Sub

    Private Sub cmbProgramacionCosecha_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmbProgramacionCosecha.ItemClick
        Dim frm As CPRProgramacionCosecha = New CPRProgramacionCosecha()
        frm.FuncionInicial(usuario, pw, EmpresaID)
        frm.ShowDialog()
    End Sub

    Private Sub cmbMtoPlanesCosecha_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmbMtoPlanesCosecha.ItemClick
        Dim PlanesCosecha As CPRPlanesCosechaFrm = New CPRPlanesCosechaFrm()
        PlanesCosecha.FuncionInicial(usuario, pw)
        PlanesCosecha.ShowDialog()
    End Sub

    Private Sub cmbCargarEstimadosProd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmbCargarEstimadosProd.ItemClick
        Dim CargarEP As CPRCargarEstimadoProduccion = New CPRCargarEstimadoProduccion()
        CargarEP.FuncionInicial(usuario, pw)
        CargarEP.ShowDialog()
    End Sub

    Private Sub cmbAgregadosBoletaPeso_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmbAgregadosBoletaPeso.ItemClick
        Dim frmABP As BprAgregadosBoletaCanaFrm = New BprAgregadosBoletaCanaFrm
        frmABP.FuncionInicial(usuario, pw)
        frmABP.ShowDialog()
    End Sub

    Private Sub CmbProductos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CmbProductos.ItemClick
        Dim frmFinProductos As FinProductosFrm = New FinProductosFrm
        frmFinProductos.FuncionInicial(usuario, pw)
        frmFinProductos.ShowDialog()
    End Sub

    Private Sub CmbFXC_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CmbFXC.ItemClick
        Dim frm As New frmSelectPunto(cnxFinanzas, usuario, pw, xEmpresaID, 1, PerfilID, rPagIDF.Tag.ToString, CmbFXC.Tag.ToString)
        frm.ShowDialog()
    End Sub

    Private Sub CmbFactExp_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CmbFactExp.ItemClick
        Dim frm As New frmSelectPunto(cnxFinanzas, usuario, pw, xEmpresaID, 7, PerfilID, rPagIDF.Tag.ToString, CmbFXC.Tag.ToString)
        frm.ShowDialog()
    End Sub

    Private Sub CmbBolVen_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CmbBolVen.ItemClick
        Dim frm As New frmSelectPunto(cnxFinanzas, usuario, pw, xEmpresaID, 8, PerfilID, rPagIDF.Tag.ToString, CmbFXC.Tag.ToString)
        frm.ShowDialog()
    End Sub
    Private Sub CmbND_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CmbND.ItemClick
        Dim frmFinDFDescrip As FinDFDescripFrm = New FinDFDescripFrm(cnxFinanzas)
        frmFinDFDescrip.FuncionInicial(usuario, pw, xEmpresaID, 2, PerfilID, CInt(rPagIDF.Tag.ToString), CInt(CmbND.Tag.ToString))
        frmFinDFDescrip.ShowDialog()
    End Sub

    Private Sub CmbNC_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CmbNC.ItemClick
        Dim frmFinDFDescrip As FinDFDescripFrm = New FinDFDescripFrm(cnxFinanzas)
        frmFinDFDescrip.FuncionInicial(usuario, pw, xEmpresaID, 3, PerfilID, CInt(rPagIDF.Tag.ToString), CInt(CmbNC.Tag.ToString))
        frmFinDFDescrip.ShowDialog()
    End Sub
    Private Sub CmbComprobRet_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CmbComprobRet.ItemClick
        Dim FrmComprobRet As FinDFDescripFrm = New FinDFDescripFrm(cnxFinanzas)
        FrmComprobRet.FuncionInicial(usuario, pw, xEmpresaID, 5, PerfilID, CInt(rPagIDF.Tag.ToString), CInt(CmbComprobRet.Tag.ToString))
        FrmComprobRet.ShowDialog()
    End Sub

    Private Sub CmbUnidadesMedida_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CmbUnidadesMedida.ItemClick
        Dim FrmFinUnidMed As FinUnidMedsFrm = New FinUnidMedsFrm
        FrmFinUnidMed.FuncionInicial(usuario, pw)
        FrmFinUnidMed.ShowDialog()
    End Sub

    Private Sub CmbItems_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CmbItems.ItemClick
        Dim FrmFinItems As FinItemsFrm = New FinItemsFrm
        FrmFinItems.FuncionInicial(usuario, pw)
        FrmFinItems.ShowDialog()
    End Sub

    Private Sub CmbRetenciones_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CmbRetenciones.ItemClick
        Dim FrmFinRetenciones As FinRetencionesFrm = New FinRetencionesFrm
        FrmFinRetenciones.FuncionInicial(usuario, pw)
        FrmFinRetenciones.ShowDialog()

    End Sub

    Private Sub CmbTiposDoctos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CmbTiposDoctos.ItemClick
        Dim FrmFinTiposDoctos As FinTiposDoctosFrm = New FinTiposDoctosFrm
        FrmFinTiposDoctos.FuncionInicial(usuario, pw)
        FrmFinTiposDoctos.ShowDialog()

    End Sub

    Private Sub CmbClientes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CmbClientes.ItemClick
        Dim FrmFinClientesAnexo As FinClientesAnexoFrm = New FinClientesAnexoFrm
        FrmFinClientesAnexo.FuncionInicial(usuario, pw)
        FrmFinClientesAnexo.ShowDialog()
    End Sub

    Private Sub CmbEmpresas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CmbEmpresas.ItemClick
        Dim FrmFinEmpresasAnexo As FinEmpresasAnexoFrm = New FinEmpresasAnexoFrm(xEmpresaID)
        FrmFinEmpresasAnexo.FuncionInicial(usuario, pw)
        FrmFinEmpresasAnexo.ShowDialog()
    End Sub

    Private Sub CmbMonedas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CmbMonedas.ItemClick
        Dim FrmFinMonedas As FinMonedasFrm = New FinMonedasFrm
        FrmFinMonedas.FuncionInicial(usuario, pw)
        FrmFinMonedas.ShowDialog()
    End Sub

    Private Sub CmbBoletasRemision_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CmbBoletasRemision.ItemClick
        'Dim FrmFinRemision As FinRemisionFrm = New FinRemisionFrm(cnxFinanzas, "30C292-628B09-6840A5-BFC210-0923F3-4B")
        'FrmFinRemision.FuncionInicial(usuario, pw, xEmpresaID, 4, PerfilID, CInt(rPagIDF.Tag.ToString), CInt(CmbBoletasRemision.Tag.ToString))
        'FrmFinRemision.ShowDialog()
        Dim frm As New frmSelectPunto(cnxFinanzas, usuario, pw, xEmpresaID, 4, PerfilID, rPagIDF.Tag.ToString, CmbFXC.Tag.ToString)
        frm.ShowDialog()
    End Sub

    Private Sub CmbConductores_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CmbConductores.ItemClick
        Dim FrmFinConductores As FinConductoresFrm = New FinConductoresFrm
        FrmFinConductores.FuncionInicial(usuario, pw)
        FrmFinConductores.ShowDialog()

    End Sub

    Private Sub CmbTransportistas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CmbTransportistas.ItemClick
        Dim FrmFinTransportistas As FinTransportistasFrm = New FinTransportistasFrm
        FrmFinTransportistas.FuncionInicial(usuario, pw)
        FrmFinTransportistas.ShowDialog()
    End Sub

    Private Sub CmbFormatos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CmbFormatos.ItemClick
        Dim FrmFinFormatos As CDPFormatosFrm = New CDPFormatosFrm
        FrmFinFormatos.FuncionInicial(usuario, pw, xEmpresaID)
        FrmFinFormatos.ShowDialog()

    End Sub

    Private Sub CmbPeriodos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CmbPeriodos.ItemClick
        Dim FrmFinPeriodos As FinPeriodosFrm = New FinPeriodosFrm
        FrmFinPeriodos.FuncionInicial(usuario, pw)
        FrmFinPeriodos.ShowDialog()

    End Sub

    Private Sub CmbMtoLecturaPluv_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CmbMtoLecturaPluv.ItemClick
        Dim FrmPLVLecturas As PLVLecturasFrm = New PLVLecturasFrm
        FrmPLVLecturas.FuncionInicial(usuario, pw, xEmpresaID)
        FrmPLVLecturas.ShowDialog()

    End Sub

    Private Sub CmbCAIXSdN_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CmbCAIXSdN.ItemClick
        Dim FrmIDFCAIXSdN As IDFCAIXSdNFrm = New IDFCAIXSdNFrm
        FrmIDFCAIXSdN.FuncionInicial(usuario, pw, xEmpresaID)
        FrmIDFCAIXSdN.ShowDialog()
    End Sub

    Private Sub CmbRegCompras_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CmbRegCompras.ItemClick
        Dim FrmIDFFactComp As IDFFactCompFrm = New IDFFactCompFrm
        FrmIDFFactComp.FuncionInicial(usuario, pw, xEmpresaID, 0, PerfilID, 0, 0)
        FrmIDFFactComp.ShowDialog()
    End Sub

    Private Sub BarButtonItem20_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CmbImportaciones.ItemClick
        '--Creditos: Amador, Quiroz, Stwolinsky, Ortega :D
        Dim FrmIDFImport As IDFImportFrm = New IDFImportFrm
        FrmIDFImport.FuncionInicial(usuario, pw, xEmpresaID)
        FrmIDFImport.ShowDialog()
    End Sub

    Private Sub bbiIntereses_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiIntereses.ItemClick
        '--Creditos: Amador, Quiroz, Stwolinsky, Ortega :D
        Dim FrmInteresesCaneros As CoFInteresesCanerosFrm = New CoFInteresesCanerosFrm
        FrmInteresesCaneros.FuncionInicial(usuario, pw, xEmpresaID)
        FrmInteresesCaneros.ShowDialog()
    End Sub

    Private Sub CmbFactBoletaCompra_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CmbFactBoletaCompra.ItemClick
        Dim frm As New frmSelectPunto(cnxFinanzas, usuario, pw, xEmpresaID, 9, PerfilID, rPagIDF.Tag.ToString, CmbFXC.Tag.ToString)
        frm.ShowDialog()
    End Sub

    Private Sub cmbFactMasiva_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmbFactMasiva.ItemClick
        Dim frm As New frmFacturasProtean(cnxFinanzas, usuario)
        frm.ShowDialog()
    End Sub

    Private Sub cmbPagos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmbPagos.ItemClick
        Dim frm As New frmPagoProveedoresList(cnxFinanzas, usuario, Me)
        frm.ShowDialog()
    End Sub

    Private Sub CmbGenRemision_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CmbGenRemision.ItemClick
        Dim frm As New GenGuiasRemisionFrm(cnxFinanzas, usuario, pw, tiempo)
        frm.ShowDialog()

    End Sub

    Private Sub BarButtonItem24_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CmbSerExtAprobacionMO.ItemClick
        Dim frm As New AprobacionMOFrm(cnxBiosalc, usuario, pw, tiempo)
        frm.ShowDialog()
    End Sub

    Private Sub BarButtonItem26_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CmbSerExtGenAsientosMO.ItemClick
        Dim frm As New GenAsientosMOFrm(cnxBiosalc, usuario, pw, xEmpresaID, tiempo)
        frm.ShowDialog()
    End Sub

    Private Sub BarButtonItem27_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CmbServAprobMAQ.ItemClick
        Dim frm As New AprobacionMQFrm(cnxBiosalc, usuario, pw, xEmpresaID, tiempo)
        frm.ShowDialog()
    End Sub

    Private Sub BarButtonItem28_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CmbServGenAsientosMAQ.ItemClick
        Dim frm As New GenAsientosMQFrm(cnxBiosalc, usuario, pw, xEmpresaID, tiempo)
        frm.ShowDialog()
    End Sub

    Private Sub BarButtonItem29_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CmbServAprobARG.ItemClick
        Dim frm As New AprobacionARGRFrm(cnxBiosalc, usuario, pw, xEmpresaID, tiempo)
        frm.ShowDialog()
    End Sub

    Private Sub BarButtonItem30_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CmbServGenAsientosARG.ItemClick
        Dim frm As New GenAsientosARGFrm(cnxBiosalc, usuario, pw, xEmpresaID, tiempo)
        frm.ShowDialog()
    End Sub
    Private Sub CmbLaboresTM_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CmbLaboresTM.ItemClick
        Dim frm As New LaboresFrm(cnxProduccion, usuario, pw, xEmpresaID)
        frm.ShowDialog()
    End Sub

    Private Sub BarButtonItem24_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CmbFacturaSE.ItemClick
        Dim frm As New GenFacturasFrm(cnxProduccion, usuario, pw, xEmpresaID)
        frm.ShowDialog()
    End Sub

    Private Sub BarButtonItem26_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CmbAproFacSE.ItemClick
        Dim frm As New AprFacturasSIFrm(cnxProduccion, usuario, pw, xEmpresaID, False)
        frm.ShowDialog()
    End Sub

    Private Sub BarButtonItem27_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmbDesFacSE.ItemClick
        Dim frm As New AprFacturasSIFrm(cnxProduccion, usuario, pw, xEmpresaID, True)
        frm.ShowDialog()
    End Sub

    Private Sub cmbRoles_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmbRoles.ItemClick
        Dim frm As New rolFrm(cnxProduccion, usuario, pw)
        frm.ShowDialog()
    End Sub

    Private Sub BarButtonItem26_ItemClick_2(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem26.ItemClick
        Dim frm As New frmAddReporteXUsuario()
        frm.Show()
    End Sub


    'Private Sub btnNewFactura_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNewFactura.ItemClick
    '    'Dim frm As New frmSelectPunto(cnxFinanzas, usuario, pw, xEmpresaID, 1, PerfilID, rPagIDF.Tag.ToString, CmbFXC.Tag.ToString)
    '    Dim frm As New frmFacturas(cnxFinanzas, usuario, Password, EmpresaID)
    '    frm.ShowDialog()
    'End Sub

    Private Sub cmbDuplicados_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmbDuplicados.ItemClick
        Dim frm As New DuplicadosMOfrm(cnxBiosalc, tiempo)
        frm.ShowDialog()
    End Sub

    Private Sub rcPrincipal_Click(sender As Object, e As EventArgs) Handles rcPrincipal.Click

    End Sub

    Private Sub cmbArrendamientos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmbArrendamientos.ItemClick
        Dim frm As New frmArrendamientos(cnxFinanzasTest, xEmpresaID)
        frm.ShowDialog()
    End Sub

    Private Sub cmbAssets_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmbAssets.ItemClick
        Dim frm As New frmIntAssets(cnxAssetsTest, xEmpresaID, EmpresaID)
        frm.ShowDialog()
    End Sub

    Private Sub cmdOtrosCostos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdOtrosCostos.ItemClick
        If MsgBox("Esta seguro que desea continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Continuar") = MsgBoxResult.Yes Then
            Try
                SplashScreenManager.ShowForm(GetType(WaitForm1))

                cnxFinanzasTest.Open()
                Dim cmd As New SqlCommand("spINT_BOtCo", cnxFinanzasTest)
                cmd.ExecuteNonQuery()
                cnxFinanzasTest.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                SplashScreenManager.CloseForm()
            End Try

        End If


    End Sub
End Class