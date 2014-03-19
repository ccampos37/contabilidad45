Option Strict Off
Option Explicit On
Friend Class frmMantSaldosInicialPlan
	Inherits System.Windows.Forms.Form
	Dim rs As ADODB.Recordset
	Dim rsSaldo As ADODB.Recordset
	Dim NombreTabla As String
	Dim FlagGrabado As Boolean
	
	Private Sub frmMantSaldosInicialPlan_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
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
        Me.Height = VB6.TwipsToPixelsY(5865)
        Me.Width = VB6.TwipsToPixelsX(6390)
        cmdBotones(0).Enabled = False
        FlagGrabado = False
    End Sub

    Sub Editar()
        Dim SQL As String
        If rs.RecordCount > 0 Then
            SQL = "SELECT saldodebe00,saldohaber00,saldoussdebe00,saldousshaber00 "
            SQL = SQL & "FROM " & NombreTabla & " WHERE empresacodigo='" & VGParametros.empresacodigo & "' and cuentacodigo='" & TDBGrid1.Columns(0).Text & "'"
            rsSaldo = VGCNx.Execute(SQL)
            If rsSaldo.RecordCount > 0 Then
                'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                txt(0).CtlText = rsSaldo.Fields(0).Value
                'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                txt(1).CtlText = rsSaldo.Fields(1).Value
                'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                txt(2).CtlText = rsSaldo.Fields(2).Value
                'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                txt(3).CtlText = rsSaldo.Fields(3).Value
            Else
                'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                txt(0).CtlText = 0
                'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                txt(1).CtlText = 0
                'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                txt(2).CtlText = 0
                'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                txt(3).CtlText = 0
            End If

            lbl(2).Text = "Saldos de " & TDBGrid1.Columns(0).Text & " - " & TDBGrid1.Columns(1).Text
        End If
    End Sub

    Sub GrabarData()
        Dim rs As ADODB.Recordset
        Dim SQL As String
        rs = New ADODB.Recordset
        VGvardllgen = New dllgeneral.dll_general

        SQL = "SELECT cuentacodigo FROM " & NombreTabla & " WHERE empresacodigo='" & VGParametros.empresacodigo & "' and  cuentacodigo='" & TDBGrid1.Columns(0).Text & "'"
        If VGvardllgen.VerificaDatoExistente(VGCNx, SQL) > 0 Then
            SQL = "UPDATE " & NombreTabla & " SET "
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            SQL = SQL & "saldodebe00=" & Val(VGvardllgen.ESNULO(txt(0).CtlText, 0)) & ","
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            SQL = SQL & "saldohaber00=" & Val(VGvardllgen.ESNULO(txt(1).CtlText, 0)) & ","
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            SQL = SQL & "saldoussdebe00=" & Val(VGvardllgen.ESNULO(txt(2).CtlText, 0)) & ","
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            SQL = SQL & "saldousshaber00=" & Val(VGvardllgen.ESNULO(txt(3).CtlText, 0)) & ","
            SQL = SQL & "usuariocodigo='" & VGusuario & "',"
            SQL = SQL & "fechaact='" & Today & "' "
            SQL = SQL & "WHERE empresacodigo='" & VGParametros.empresacodigo & "' and cuentacodigo='" & TDBGrid1.Columns(0).Text & "'"
            VGCNx.Execute(SQL)
            FlagGrabado = True
        Else
            SQL = "INSERT " & NombreTabla & " (empresacodigo,cuentacodigo,saldodebe00,saldohaber00,saldoussdebe00,saldousshaber00,usuariocodigo,fechaact) "
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            SQL = SQL & "VALUES ('" & VGParametros.empresacodigo & "','" & TDBGrid1.Columns(0).Text & "'," & Val(VGvardllgen.ESNULO(txt(0).CtlText, 0)) & "," & Val(VGvardllgen.ESNULO(txt(1).CtlText, 0)) & "," & Val(VGvardllgen.ESNULO(txt(2).CtlText, 0)) & ","
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VGvardllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            SQL = SQL & Val(VGvardllgen.ESNULO(txt(3).CtlText, 0)) & ",'" & VGusuario & "','" & Today & "')"
            VGCNx.Execute(SQL)
            FlagGrabado = True
        End If
    End Sub

    Private Sub frmMantSaldosInicialPlan_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If FlagGrabado = True Then Call RecalcularAcumulados()
    End Sub

    'FIXIT: Declare 'LastRow' con un tipo de datos de enlace en tiempo de compilación          FixIT90210ae-R1672-R1B8ZE
    Private Sub TDBGrid1_RowColChange(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueOleDBGrid70.TrueDBGridEvents_RowColChangeEvent) Handles TDBGrid1.RowColChange
        If rs.RecordCount > 0 Then
            Call Editar()
        End If
    End Sub

    Private Sub cmdBotones_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBotones.Click
        Dim Index As Short = cmdBotones.GetIndex(eventSender)
        Select Case Index
            Case 0
                Call GrabarData()
                cmdBotones(0).Enabled = False
            Case 1
                Me.Close()
                'UPGRADE_NOTE: El objeto rs no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
                rs = Nothing
                'UPGRADE_NOTE: El objeto rsSaldo no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
                rsSaldo = Nothing
        End Select
    End Sub

    Sub Config_TDBGrid1()
        TDBGrid1.Columns(0).Width = 900
        TDBGrid1.Columns(1).Width = 4800
    End Sub

    'FIXIT: Declare 'Buscar' con un tipo de datos de enlace en tiempo de compilación           FixIT90210ae-R1672-R1B8ZE
    Function Buscar() As Object
        Dim SQL As String
        'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        If IsNumeric(txtBuscar.CtlText) = True Then
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            rs.Filter = "cuentacodigo like '" & Trim(txtBuscar.CtlText) & "%'"
            TDBGrid1.DataSource = rs
        Else
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
            If IsNothing(Trim(txtBuscar.CtlText)) Then
                SQL = "select cuentacodigo,cuentadescripcion from ct_cuenta where cuentanivel=" & VGnumnivelescuenta & " AND cuentacodigo<>'00'"
                rs = VGCNx.Execute(SQL)
            Else
                'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                rs.Filter = "cuentadescripcion like '%" & Trim(txtBuscar.CtlText) & "%'"
            End If
            TDBGrid1.DataSource = rs
        End If
    End Function

    Private Sub txt_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txt.Change
        Dim Index As Short = txt.GetIndex(eventSender)
        cmdBotones(0).Enabled = True
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
End Class