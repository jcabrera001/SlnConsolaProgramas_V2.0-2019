Option Strict On
Option Explicit On
'
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Linq
Imports System.Text
Imports System.Threading

Public Class ClsConexion
    Dim cnx As SqlConnection = Nothing

    Public Function Abrir() As SqlConnection
        cnx.Open()
        Return cnx
    End Function

    Public Function conectar(stru As String, strp As String) As SqlConnection
        Dim appConfig As String = ConfigurationManager.ConnectionStrings("CnxStringSQL").ConnectionString
        'appConfig = appConfig + "Initial Catalog=" + strBD + ";User ID=" + stru + ";Password=" + strp
        appConfig = appConfig + "User ID=" + stru + ";Password=" + strp
        cnx = New SqlConnection(appConfig)
        Return cnx
    End Function

    Public Function conectarAmigoDbBascula(stru As String, strp As String) As SqlConnection
        Dim appConfig As String = ConfigurationManager.ConnectionStrings("CnxStringSQLBascula").ConnectionString
        appConfig = appConfig + "User ID=" + stru + ";Password=" + strp
        cnx = New SqlConnection(appConfig)
        Return cnx
    End Function

    Public Function conectarAmigoDbPruebas(stru As String, strp As String) As SqlConnection
        Dim appConfig As String = ConfigurationManager.ConnectionStrings("CnxStringSQLPruebas").ConnectionString
        'appConfig = appConfig + "Initial Catalog=" + strBD + ";User ID=" + stru + ";Password=" + strp
        stru = "sa"
        strp = "Tansasa2013"
        appConfig = appConfig + "User ID=" + stru + ";Password=" + strp
        cnx = New SqlConnection(appConfig)
        Return cnx
    End Function

    Public Function conectarAmigoDbBioSalc(stru As String, strp As String) As SqlConnection
        Dim appConfig As String = ConfigurationManager.ConnectionStrings("CnxStringSQLBioSalc").ConnectionString
        'appConfig = appConfig + "Initial Catalog=" + strBD + ";User ID=" + stru + ";Password=" + strp
        'stru = "rptuser"

        appConfig = appConfig + "User ID=" + stru + ";Password=" + strp
        cnx = New SqlConnection(appConfig)
        Return cnx
    End Function

    Public Function conectarAmigoDbFinanzas(stru As String, strp As String) As SqlConnection
        Dim appConfig As String = ConfigurationManager.ConnectionStrings("CnxStringSQLFinanzas").ConnectionString
        'appConfig = appConfig + "Initial Catalog=" + strBD + ";User ID=" + stru + ";Password=" + strp
        'stru = "rptuser"

        appConfig = appConfig + "User ID=" + stru + ";Password=" + strp
        cnx = New SqlConnection(appConfig)
        Return cnx
    End Function

    Public Function CadenaFinanzas(stru As String, strp As String) As String
        Dim appConfig As String = ConfigurationManager.ConnectionStrings("CnxStringSQLFinanzas").ConnectionString
        'appConfig = appConfig + "Initial Catalog=" + strBD + ";User ID=" + stru + ";Password=" + strp
        appConfig = appConfig + "User ID=" + stru + ";Password=" + strp
        Return appConfig
    End Function

    Public Function CadenaFinanzasSQLConnection(stru As String, strp As String) As SqlConnection
        Dim appConfig As String = ConfigurationManager.ConnectionStrings("CnxStringSQLFinanzas").ConnectionString
        'appConfig = appConfig + "Initial Catalog=" + strBD + ";User ID=" + stru + ";Password=" + strp
        appConfig = appConfig + "User ID=" + stru + ";Password=" + strp
        cnx = New SqlConnection(appConfig)
        Return cnx
    End Function

    Public Function CadenaProduccion(stru As String, strp As String) As String
        Dim appConfig As String = ConfigurationManager.ConnectionStrings("CnxStringSQL").ConnectionString
        'appConfig = appConfig + "Initial Catalog=" + strBD + ";User ID=" + stru + ";Password=" + strp
        appConfig = appConfig + "User ID=" + stru + ";Password=" + strp
        Return appConfig
    End Function

End Class
