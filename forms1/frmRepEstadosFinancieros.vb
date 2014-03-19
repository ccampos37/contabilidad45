Option Strict Off
Option Explicit On
Friend Class frmRepEstadosFinancieros
	Inherits System.Windows.Forms.Form
	
	Private Sub frmRepEstadosFinancieros_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		DTPicker_Fecha.Value = DateAdd(Microsoft.VisualBasic.DateInterval.Day, -1, DateAdd(Microsoft.VisualBasic.DateInterval.Month, 1, CDate(VB6.Format("01/" & VGParamSistem.Mesproceso & "/" & CShort(VGParamSistem.Anoproceso), "dd/mm/yyyy"))))
		DTPicker_Fecha.MinDate = CDate(VB6.Format("01/01/" & VGParamSistem.Anoproceso, "dd/mm/yyyy"))
		DTPicker_Fecha.MaxDate = CDate(VB6.Format("31/12/" & VGParamSistem.Anoproceso, "dd/mm/yyyy"))
		Check1.CheckState = System.Windows.Forms.CheckState.Unchecked
		Frame3.Visible = False
	End Sub
	
	Sub ImpresionEFE()
		'FIXIT: Declare 'arrform' and 'arrparm' con un tipo de datos de enlace en tiempo de compilaci�n     FixIT90210ae-R1672-R1B8ZE
		Dim arrform(0) As Object
		Dim arrparm() As Object
		ReDim arrparm(5)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(0). Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(0) = VGParamSistem.BDEmpresa
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(1). Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(1) = VGParametros.empresacodigo
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(2). Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(2) = VGParamSistem.Anoproceso
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(3). Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(3) = VB6.Format(Month(DTPicker_Fecha.Value), "0#")
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(4). Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(4) = VGComputer
		Call ImpresionRptProc("ct_EstadoFlujoEfectivo.rpt", arrform, arrparm)
	End Sub
	
	Sub ImpresionBalanceGeneral()
		'FIXIT: Declare 'arrform' con un tipo de datos de enlace en tiempo de compilaci�n          FixIT90210ae-R1672-R1B8ZE
		Dim arrform(0) As Object
		Dim arrparm(7) As Object
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(0). Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(0) = VGParamSistem.BDEmpresa
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(1). Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(1) = VGParametros.empresacodigo
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(2). Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(2) = VGParamSistem.Anoproceso
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(3). Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(3) = VB6.Format(Month(DTPicker_Fecha.Value), "0#")
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(4). Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(4) = "2"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(5). Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(5) = VGComputer
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(6). Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(6) = Check1.CheckState
		Call ImpresionRptProc("ct_BalanceGeneral.rpt", arrform, arrparm)
		Call ImpresionRptProc("ct_balancegeneral_anexo.rpt", arrform, arrparm)
	End Sub
	
	Sub ImpresionEGPFuncion()
		Dim arrform(1) As Object
		Dim arrparm(6) As Object
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(0). Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(0) = VGParamSistem.BDEmpresa
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(1). Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(1) = VGParametros.empresacodigo
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(2). Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(2) = VGParamSistem.Anoproceso
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(3). Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(3) = VB6.Format(Month(CDate(VB6.Format(DTPicker_Fecha.Value, "dd/mm/yyyy"))), "0#")
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(4). Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(4) = VGComputer
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(5). Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(5) = "0"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrform(0). Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrform(0) = "@TituloReporte='" & "Estado de Gan�ncias y P�rdidas por FUNCION" & "'"
		Call ImpresionRptProc("ct_EstadoGanPedFun.rpt", arrform, arrparm)
	End Sub
	
	Sub ImpresionEGPNaturaleza()
		Dim arrform(1) As Object
		Dim arrparm(5) As Object
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(0). Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(0) = VGCNx.DefaultDatabase
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(1). Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(1) = VGParametros.empresacodigo
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(2). Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(2) = VGParamSistem.Anoproceso
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(3). Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(3) = VB6.Format(Month(CDate(VB6.Format(DTPicker_Fecha.Value, "dd/mm/yyyy"))), "0#")
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(4). Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(4) = VGComputer
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrform(0). Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrform(0) = "@TituloReporte='" & "Estado de Gan�ncias y P�rdidas por NATURALEZA" & "'"
		Call ImpresionRptProc("ct_EstadoGanPedNat.rpt", arrform, arrparm)
	End Sub
	
	Private Sub cmdBotones_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBotones.Click
		Dim Index As Short = cmdBotones.GetIndex(eventSender)
		
		If Index = 0 Then
			If optTipo(0).Checked = True Then
				Call ImpresionEGPFuncion()
			ElseIf optTipo(1).Checked = True Then 
				Call ImpresionEGPNaturaleza()
			ElseIf optTipo(2).Checked = True Then 
				Call ImpresionBalanceGeneral()
			Else
				Call ImpresionEFE()
			End If
		Else
			Me.Close()
		End If
	End Sub
	
	'UPGRADE_WARNING: El evento optTipo.CheckedChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optTipo_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optTipo.CheckedChanged
		If eventSender.Checked Then
			Dim Index As Short = optTipo.GetIndex(eventSender)
			Frame3.Visible = False
			If Index = 2 Then Frame3.Visible = True
		End If
	End Sub
End Class