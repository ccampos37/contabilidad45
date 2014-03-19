Option Strict Off
Option Explicit On
Friend Class FrmAjusDiferxDoc
	Inherits System.Windows.Forms.Form
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		If Not ValidaIngreso Then Exit Sub
		Call GenAjuste()
	End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		Me.Close()
	End Sub
	
	Private Sub FrmAjusDiferxDoc_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Call Ctr_AyudaCCosto.conexion(VGCNx) : Ctr_AyudaCCosto.Filtro = "empresacodigo ='" & VGParametros.empresacodigo & "'"
		DTPicker1.Value = Fecha(2, VGParamSistem.FechaTrabajo)
		'    DTPicker1.SetFocus
	End Sub
	Private Function ValidaIngreso() As Boolean
		'UPGRADE_NOTE: tipocambio se actualizó a tipocambio_Renamed. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim tipocambio_Renamed As Short
		tipocambio_Renamed = 0
		ValidaIngreso = False
		If Ctr_AyudaCCosto.xclave = "" Then
			MsgBox("Debe Ingresar un Centro de Costo", MsgBoxStyle.Exclamation)
			Ctr_AyudaCCosto.Focus()
			Exit Function
		End If
		tipocambio_Renamed = XRecuperaTipoCambio(DTPicker1._Value, ModificarCampos.tipocambio.Compra, VGcnxCT)
		If tipocambio_Renamed = 0 Then
			MsgBox("Fecha de Ajuste no tiene tipo de cambio", MsgBoxStyle.Exclamation)
			DTPicker1.Focus()
			Exit Function
		End If
		ValidaIngreso = True
	End Function
	Private Sub GenAjuste()
		On Error GoTo Ajuste
		VGGeneral.BeginTrans()
		'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		
		EliminaAjustes()
		'  Mayoriza
		
		Dim rs As ADODB.Recordset
		rs = New ADODB.Recordset
		VGCommandoSP = New ADODB.Command
		VGCommandoSP.let_ActiveConnection(VGGeneral)
		VGCommandoSP.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
		VGCommandoSP.CommandText = "Ct_AjusDifCambxDoc_pro"
		VGCommandoSP.Parameters.Refresh()
		With VGCommandoSP
			.Parameters("@base").Value = VGParamSistem.BDEmpresa
			.Parameters("@empresa").Value = VGParametros.empresacodigo
			.Parameters("@Ano").Value = Year(DTPicker1.Value)
			.Parameters("@Mes").Value = Month(DTPicker1.Value)
			.Parameters("@Asiento").Value = "055"
			.Parameters("@SubAsiento").Value = "0099"
			.Parameters("@AjusteDebe").Value = Trim(VGParametros.sistemactaajustedeb)
			.Parameters("@AjusteHaber").Value = Trim(VGParametros.sistemactaajustehab)
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto DTPicker1.Value. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@Fecha").Value = DTPicker1.Value
			.Parameters("@Usuario").Value = VGParamSistem.Usuario
			.Parameters("@NombrePC").Value = VGcomputer
			.Parameters("@TipoCambio1").Value = XRecuperaTipoCambio((DTPicker1.Value), 1, VGcnxCT)
			.Parameters("@TipoCambio2").Value = XRecuperaTipoCambio((DTPicker1.Value), 2, VGcnxCT)
			.Parameters("@CCosto").Value = Ctr_AyudaCCosto.xclave
			rs = .Execute
		End With
		
		Mayoriza()
		
		VGGeneral.CommitTrans()
		If rs.State = 0 Then
			MsgBox("El Ajuste de Diferencia de Cambio de Documentos " & Chr(13) & "Cancelados se Realizo Satisfactoriamente ", MsgBoxStyle.Information)
		Else
			MsgBox("El Ajuste de Diferencia de Cambio de Documentos " & Chr(13) & "Cancelados No se Realizará porque no Encontro " & Chr(13) & "Ni un Documento a Ajustar ", MsgBoxStyle.Exclamation)
			
		End If
		'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
		Exit Sub
		
Ajuste: 
		VGGeneral.RollbackTrans()
		'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
		MsgBox("No se genero el Ajuste " & Chr(13) & Err.Description, MsgBoxStyle.Exclamation)
	End Sub
	Private Sub EliminaAjustes()
		Dim rs1 As ADODB.Recordset
		Dim SQL As String
		rs1 = New ADODB.Recordset
		
		'Eliminando asientos de ajuste
		'Ajuste Ganancia
		SQL = "Delete From ct_cabcomprob" & Year(DTPicker1.Value) & " Where empresacodigo='" & VGParametros.empresacodigo & "' " & "And cabcomprobmes=" & Month(DTPicker1.Value) & " AND cabcomprobnumero='" & VB6.Format(Month(DTPicker1.Value), "00") & "05500001' " & " AND subasientocodigo='0099' AND asientocodigo='055'"
		rs1 = VGCNx.Execute(SQL)
		'UPGRADE_NOTE: El objeto rs1 no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rs1 = Nothing
		'Ajuste Perdida
		SQL = "Delete From ct_cabcomprob" & Year(DTPicker1.Value) & " Where empresacodigo='" & VGParametros.empresacodigo & "' " & "And cabcomprobmes=" & Month(DTPicker1.Value) & " AND cabcomprobnumero='" & VB6.Format(Month(DTPicker1.Value), "00") & "05500002' " & " AND subasientocodigo='0099' AND asientocodigo='055'"
		rs1 = VGCNx.Execute(SQL)
		'UPGRADE_NOTE: El objeto rs1 no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rs1 = Nothing
	End Sub
	Private Sub Mayoriza()
		VGCommandoSP = New ADODB.Command
		VGCommandoSP.let_ActiveConnection(VGGeneral)
		VGCommandoSP.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
		VGCommandoSP.CommandText = "ct_mayoriza_pro"
		VGCommandoSP.Parameters.Refresh()
		With VGCommandoSP
			.Parameters("@base").Value = VGParamSistem.BDEmpresa
			.Parameters("@empresa").Value = VGParametros.empresacodigo
			.Parameters("@anno").Value = Year(DTPicker1.Value)
			.Parameters("@mespro").Value = Month(DTPicker1.Value)
			.Parameters("@user").Value = VGParamSistem.Usuario
			.Execute()
		End With
	End Sub
End Class