Option Strict Off
Option Explicit On
Friend Class FrmLibroCajayBancos
	Inherits System.Windows.Forms.Form
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		Dim aparam(8) As Object
		Dim aform(1) As Object
		Dim RSQL As New ADODB.Recordset
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aform(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		aform(0) = "empresa='" & VGParametros.NomEmpresa & "'"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aparam(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		aparam(0) = VGCNx.DefaultDatabase
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aparam(1). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		aparam(1) = VGParametros.empresacodigo
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aparam(2). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		aparam(2) = VGParamSistem.Anoproceso
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aparam(3). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		aparam(3) = VGParamSistem.Mesproceso
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aparam(4). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        aparam(4) = Format(CDbl(VGParamSistem.Mesproceso) - 1, "00")
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aparam(6). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		aparam(6) = VGParametros.sistemactaajustedeb
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aparam(7). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		aparam(7) = VGParametros.sistemactaajustehab
		If Check1.CheckState = 1 Then
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aparam(5). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			aparam(5) = "FORMATO 01.01"
			'   Set RSQL = VGCNx.Execute("select formatocuentacomodin from ct_formatos where formatocodigo='" & aparam(5) & "'")
			'   aparam(6) = RSQL!formatocuentacomodin
			Call ImpresionRptProc("ct_LibroCajayBancos0101.rpt", aform, aparam,  , Check1.Text)
		End If
		If Check2.CheckState = 1 Then
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aparam(5). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			aparam(5) = "FORMATO 01.02"
			'   Set RSQL = VGCNx.Execute("select formatocuentacomodin from ct_formatos where formatocodigo='" & aparam(5) & "'")
			'   aparam(6) = RSQL!formatocuentacomodin
			Call ImpresionRptProc("ct_LibroCajayBancos0102.rpt", aform, aparam,  , Check2.Text)
		End If
		
	End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		Me.Close()
	End Sub
End Class