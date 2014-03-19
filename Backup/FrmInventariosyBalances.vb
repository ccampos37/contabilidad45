Option Strict Off
Option Explicit On
Friend Class FrmInventariosyBalances
	Inherits System.Windows.Forms.Form
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		Dim aparm(5) As Object
		Dim aform(2) As Object
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aparm(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		aparm(0) = VGCNx.DefaultDatabase
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aparm(1). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		aparm(1) = VGParametros.empresacodigo
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aparm(2). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		aparm(2) = VGParamSistem.Anoproceso
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aparm(3). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		aparm(3) = VGParamSistem.Mesproceso
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aparm(4). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		aparm(4) = "1"
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aform(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		aform(0) = "@mes='" & DesMes(Trim(VGParamSistem.Mesproceso)) & "'"
		
		If Option1.Checked = True Then
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aform(1). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			aform(1) = "@tituloreporte='LIBRO INVENTARIOS Y BALANCE - ANALITICO '"
			Call ImpresionRptProc("ct_LibroInventariosXAnalitico.rpt", aform, aparm,  , " Libro Inventarios y Balance ")
		ElseIf Option2.Checked = True Then 
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aparm(4). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			aparm(4) = "2"
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aform(1). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			aform(1) = "@tituloreporte='LIBRO INVENTARIOS Y BALANCE - DETALLADO '"
			Call ImpresionRptProc("ct_LibroInventarios.rpt", aform, aparm,  , " Libro Inventarios y Balance ")
		Else
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aform(1). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			aform(1) = "@tituloreporte='LIBRO INVENTARIOS Y BALANCE - RESUMIDO '"
			Call ImpresionRptProc("ct_LibroInventarios.rpt", aform, aparm,  , " Libro Inventarios y Balance ")
		End If
		
	End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		Me.Close()
	End Sub
End Class