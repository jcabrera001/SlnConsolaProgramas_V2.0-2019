Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows
Imports System.Windows.Forms
Imports System.Windows
Imports System.IO
Imports System.Text

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing

Public Class GenVistaPrevia
    Public reporte As String
    Public dataBase As String
    Public user, usuarioSesion As String
    Public pass As String
    Public server As String
    Public parametro As String = ""
    Public info, asunto, cuerpo As String
    Public passwordSesion As String
    Public idMensaje As Integer
    Private Sub GenVistaPrevia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ireport As New ReportDocument
        Dim iConnectionInfo As ConnectionInfo = New ConnectionInfo()

        'parametros = "2011-02-01 00:00:00;2011-03-01 23:59:59"
        Try
            Me.Text = info
            iConnectionInfo.DatabaseName = dataBase
            iConnectionInfo.UserID = user
            iConnectionInfo.Password = pass
            iConnectionInfo.ServerName = server

            iConnectionInfo.Type = ConnectionInfoType.SQL
            '
            'ireport.SetParameterValue()
            'ireport.SetParameterValue("@user", "sa")
            ireport.Load(reporte & ".rpt")

            SetDBLogonForReport(iConnectionInfo, ireport)

            If parametro = "" Then
            Else
                Me.CrystalReportViewer1.ShowRefreshButton = False
                ireport.SetParameterValue(0, parametro)
            End If
            Try
                Me.CrystalReportViewer1.ReportSource = ireport
                'Me.CrystalReportViewer1.ExportReport()
                'Threading.Thread.Sleep(10000)
                'MsgBox(ExportToPDF(CrystalReportViewer1.ReportSource, "tmp"))

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Catch ex As Exception
            MsgBox("Error visor: " & ex.Message)
        End Try
    End Sub

    Private Sub SetDBLogonForReport(ByVal myConnectionInfo As ConnectionInfo, ByVal myReportDocument As ReportDocument)
        Dim myTables As Tables = myReportDocument.Database.Tables
        For Each myTable As CrystalDecisions.CrystalReports.Engine.Table In myTables
            Dim myTableLogonInfo As TableLogOnInfo = myTable.LogOnInfo
            myTableLogonInfo.ConnectionInfo = myConnectionInfo
            myTable.ApplyLogOnInfo(myTableLogonInfo)
        Next
    End Sub

End Class