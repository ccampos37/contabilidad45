Option Strict Off
Option Explicit On
Friend Class frmMntSaldosInicialPlan
    Inherits System.Windows.Forms.Form
    Dim rs As ADODB.Recordset
    Dim rsSaldo As ADODB.Recordset
    Dim NombreTabla As String
    Dim FlagGrabado As Boolean

    Private Sub frmMntSaldosInicialPlan_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim SQL As String

        rs = New ADODB.Recordset
        rsSaldo = New ADODB.Recordset
        SQL = "SELECT cuentacodigo,cuentadescripcion FROM ct_cuenta WHERE empresacodigo='" & VGParametros.empresacodigo & "' and cuentanivel=" & VGnumnivelescuenta & " AND cuentacodigo<>'00' order by 1"
        rs = VGCNx.Execute(SQL)
        If rs.RecordCount <= 0 Then
            MsgBox("Faltan las Cuentas para los Saldos", MsgBoxStyle.Information, Text)
            Exit Sub
        End If

        TDBGrid1.DataSource = rs
        Call Config_TDBGrid1()
        NombreTabla = "CT_SALDOS" & VGParamSistem.Anoproceso
        cmdBotones0.Enabled = False
        FlagGrabado = False
    End Sub

    Sub Editar()
        Dim SQL As String
        If rs.RecordCount > 0 Then
            SQL = "SELECT saldodebe00,saldohaber00,saldoussdebe00,saldousshaber00 "
            SQL = SQL & "FROM " & NombreTabla & " WHERE empresacodigo='" & VGParametros.empresacodigo & "' and cuentacodigo='" & TDBGrid1.Columns(0).Text & "'"
            rsSaldo = VGCNx.Execute(SQL)
            If rsSaldo.RecordCount > 0 Then
                txt0.Text = rsSaldo.Fields(0).Value
                txt1.Text = rsSaldo.Fields(1).Value
                txt2.Text = rsSaldo.Fields(2).Value
                txt3.Text = rsSaldo.Fields(3).Value
            Else
                txt0.Text = "0"
                txt1.Text = "0"
                txt2.Text = "0"
                txt3.Text = "0"
            End If

            lbl2.Text = "Saldos de " & TDBGrid1.Columns(0).Text & " - " & TDBGrid1.Columns(1).Text
        End If
    End Sub

    Sub GrabarData()
        Dim rs As ADODB.Recordset
        Dim SQL As String
        rs = New ADODB.Recordset
        '  VGvardllgen = New dllgeneral.dll_general

        SQL = "SELECT cuentacodigo FROM " & NombreTabla & " WHERE empresacodigo='" & VGParametros.empresacodigo & "' and  cuentacodigo='" & TDBGrid1.Columns(0).Text & "'"
        If VerificaDatoExistente(VGCNx, SQL) > 0 Then
            SQL = "UPDATE " & NombreTabla & " SET "
            SQL = SQL & "saldodebe00=" & Val(ESNULO(txt0.Text, 0)) & ","
            SQL = SQL & "saldohaber00=" & Val(ESNULO(txt1.Text, 0)) & ","
            SQL = SQL & "saldoussdebe00=" & Val(ESNULO(txt2.Text, 0)) & ","
            SQL = SQL & "saldousshaber00=" & Val(ESNULO(txt3.Text, 0)) & ","
            SQL = SQL & "usuariocodigo='" & VGusuario & "',"
            SQL = SQL & "fechaact='" & Today & "' "
            SQL = SQL & "WHERE empresacodigo='" & VGParametros.empresacodigo & "' and cuentacodigo='" & TDBGrid1.Columns(0).Text & "'"
            VGCNx.Execute(SQL)
            FlagGrabado = True
        Else
            SQL = "INSERT " & NombreTabla & " (empresacodigo,cuentacodigo,saldodebe00,saldohaber00,saldoussdebe00,saldousshaber00,usuariocodigo,fechaact) "
            SQL = SQL & "VALUES ('" & VGParametros.empresacodigo & "','" & TDBGrid1.Columns(0).Text & "'," & Val(ESNULO(txt0.Text, 0)) & "," & Val(ESNULO(txt1.Text, 0)) & "," & Val(ESNULO(txt2.Text, 0)) & ","
            SQL = SQL & Val(ESNULO(txt3.Text, 0)) & ",'" & VGusuario & "','" & Today & "')"
            VGCNx.Execute(SQL)
            FlagGrabado = True
        End If
    End Sub

    Private Sub frmMantSaldosInicialPlan_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If FlagGrabado = True Then Call RecalcularAcumulados()
    End Sub

    Private Sub TDBGrid1_RowColChange(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueOleDBGrid70.TrueDBGridEvents_RowColChangeEvent) Handles TDBGrid1.RowColChange
        If rs.RecordCount > 0 Then
            Call Editar()
        End If
    End Sub

    Sub Config_TDBGrid1()
        TDBGrid1.Columns(0).Width = 80
        TDBGrid1.Columns(1).Width = 360
    End Sub

    Sub Buscar()
        Dim SQL As String
        If IsNumeric(txtBuscar.Text) = True Then
            rs.Filter = "cuentacodigo like '" & Trim(txtBuscar.Text) & "%'"
            TDBGrid1.DataSource = rs
        Else
            If IsNothing(Trim(txtBuscar.Text)) Then
                SQL = "select cuentacodigo,cuentadescripcion from ct_cuenta where cuentanivel=" & VGnumnivelescuenta & " AND cuentacodigo<>'00'"
                rs = VGCNx.Execute(SQL)
            Else
                rs.Filter = "cuentadescripcion like '%" & Trim(txtBuscar.Text) & "%'"
            End If
            TDBGrid1.DataSource = rs
        End If
    End Sub

    Private Sub txtBuscar_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtBuscar.Change
        Call Buscar()
    End Sub

    Sub RecalcularAcumulados()
        VGCommandoSP = New ADODB.Command
        VGCommandoSP.let_ActiveConnection(VGGeneral)
        VGCommandoSP.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
        VGCommandoSP.CommandText = "ct_recalacum_pro"
        VGCommandoSP.Parameters.Refresh()
        With VGCommandoSP
            .Parameters("@base").Value = VGParamSistem.BDEmpresa
            .Parameters("@anno").Value = VGParamSistem.Anoproceso
            .Parameters("@empresa").Value = VGParametros.empresacodigo
            .Parameters("@mespro").Value = "01"
            .Parameters("@user").Value = VGParamSistem.Usuario
        End With
        VGCommandoSP.Execute()

    End Sub
    Private Sub cmdBotones1_Click(sender As Object, e As EventArgs) Handles cmdBotones1.Click
        Me.Close()
        rs = Nothing
        rsSaldo = Nothing
    End Sub
    Private Sub txt0_Change(sender As Object, e As EventArgs) Handles txt0.Change
        cmdBotones0.Enabled = True
    End Sub

    Private Sub txt1_Change(sender As Object, e As EventArgs) Handles txt1.Change
        cmdBotones0.Enabled = True
    End Sub

    Private Sub txt2_Change(sender As Object, e As EventArgs) Handles txt2.Change
        cmdBotones0.Enabled = True
    End Sub

    Private Sub txt3_Change(sender As Object, e As EventArgs) Handles txt3.Change
        cmdBotones0.Enabled = True
    End Sub

    Private Sub cmdBotones0_Click(sender As Object, e As EventArgs) Handles cmdBotones0.Click
        Call GrabarData()
        cmdBotones0.Enabled = False
    End Sub
End Class