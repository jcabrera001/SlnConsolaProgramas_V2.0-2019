﻿Imports System.Data.SqlClient

Public Class frmPagoProveedoresList

    Private Usuario As String
    Private time As Integer
    Dim f As New Funciones

    Dim dt As New DataTable
    Dim adp As SqlDataAdapter

    Public Sub New(cnx As SqlConnection, Usuario As String, parent As GenPrincipalFrm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.Usuario = Usuario
        f.Conexion = cnx

        ' Me.MdiParent = parent

    End Sub
    Private Sub frmPagoProveedoresList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadTable()
        f.InitGridControl(gc, gv, dt, "", False)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim frm As New frmPagoProveedoresDetail(f.Conexion, Usuario, 0)
        frm.ShowDialog()
        LoadTable()
    End Sub
    Private Sub btnDetalle_Click(sender As Object, e As EventArgs) Handles btnDetalle.Click

        Dim frm As New frmPagoProveedoresDetail(f.Conexion, Usuario, gv.GetFocusedRowCellValue("TOLpagoID"))
        frm.ShowDialog()
    End Sub
    Private Sub LoadTable()
        dt.Clear()
        adp = New SqlDataAdapter("spTOLPAgoSelect", f.Conexion)
        adp.Fill(dt)
    End Sub
    Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
        If gv.GetFocusedRowCellValue("Estado") = "A" Then
            MsgBox("Transacción ya se encuentra anulada", MsgBoxStyle.Information, "Anulación")
        Else
            If MsgBox("¿Está seguro que desea anular el pago seleccionadas?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Desaprobar") = MsgBoxResult.Yes Then
                f.ExecuteQuery("update TOLPago set estado = 'A' where TOLPagoID = " & gv.GetFocusedRowCellValue("TOLpagoID"))
                MsgBox("Pago anulado exitosamente!", MsgBoxStyle.Information, "Anulación")
                LoadTable()
            End If
        End If
    End Sub
End Class