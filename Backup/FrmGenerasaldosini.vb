Option Strict Off
Option Explicit On
Friend Class FrmGenerasaldosini
	Inherits System.Windows.Forms.Form
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		If Not ValidaIngreso Then Exit Sub
		Call GenSaldos()
	End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		Me.Close()
	End Sub
	
	Private Sub FrmGenerasaldosini_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Call Ctr_AyudaCuenta.Conexion(VGCNx) : Ctr_AyudaCuenta.Filtro = "empresacodigo ='" & VGParametros.empresacodigo & "'"
	End Sub
	Private Function ValidaIngreso() As Boolean
		ValidaIngreso = False
		If Ctr_AyudaCuenta.xclave = "" Then
			MsgBox("Debe Ingresar un Cuenta de resultados de ejercicio", MsgBoxStyle.Exclamation)
			Ctr_AyudaCuenta.Focus()
			Exit Function
		End If
		ValidaIngreso = True
		If MsgBox("Desea Continuar con el proceso ", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
			ValidaIngreso = False
		End If
	End Function
	Private Sub GenSaldos()
		On Error GoTo SaldosIniciales
		'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		VGCNx.BeginTrans()
		VGCommandoSP = New ADODB.Command
		VGCommandoSP.let_ActiveConnection(VGGeneral)
		VGCommandoSP.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
		VGCommandoSP.CommandText = "ct_GenerarSaldoIniciales_pro"
		VGCommandoSP.Parameters.Refresh()
		With VGCommandoSP
			.Parameters("@base").Value = VGParamSistem.BDEmpresa
			.Parameters("@empresa").Value = VGParametros.empresacodigo
			.Parameters("@annoact").Value = VGParamSistem.Anoproceso
			.Parameters("@annoant").Value = CDbl(VGParamSistem.Anoproceso) - 1
			.Parameters("@ultnivel").Value = VG_aNIVELES(VGnumnivelescuenta - 1)
			.Parameters("@CuentaResEjer").Value = Ctr_AyudaCuenta.xclave
			.Execute()
		End With
		VGCNx.CommitTrans()
		
		'Recalcular Saldos
		VGCommandoSP = New ADODB.Command
		VGCommandoSP.let_ActiveConnection(VGGeneral)
		VGCommandoSP.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
		VGCommandoSP.CommandText = "ct_recalacum_pro"
		VGCommandoSP.Parameters.Refresh()
		With VGCommandoSP
			.Parameters("@base").Value = VGParamSistem.BDEmpresa
			.Parameters("@empresa").Value = VGParametros.empresacodigo
			.Parameters("@anno").Value = VGParamSistem.Anoproceso
			.Parameters("@mespro").Value = "01"
			.Parameters("@user").Value = VGParamSistem.Usuario
		End With
		VGCommandoSP.Execute()
		
		'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
		MsgBox("Se Generaron Saldos Iniciales del año " & VGParamSistem.Anoproceso & " Satisfactoriamente ", MsgBoxStyle.Information)
		Me.Close()
		Exit Sub
SaldosIniciales: 
		'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
		VGCNx.RollbackTrans()
		MsgBox("ERROR : No se actualizarón los Saldos Iniciales del año " & VGParamSistem.Anoproceso & " " & Chr(13) & Err.Description, MsgBoxStyle.Exclamation)
	End Sub
End Class