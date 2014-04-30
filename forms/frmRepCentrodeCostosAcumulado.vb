Option Strict Off
Option Explicit On
Friend Class frmRepCentrodeCostosAcumulado
	Inherits System.Windows.Forms.Form
	Private Sub cmdAceptar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAceptar.Click
		If Option3.Checked = True Then
			Call imprimir3()
		ElseIf Option4.Checked = True Then 
			Call imprimir4()
		End If
	End Sub
	Private Sub imprimir3()
		Dim arrform(2) As Object
		Dim arrparm(4) As Object
        '  VGvardllgen = New dllgeneral.dll_general
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(0) = VGParamSistem.BDEmpresa
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(1). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(1) = VGParametros.empresacodigo
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(2). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(2) = VGParamSistem.Anoproceso
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(3). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(3) = VB6.Format(Month(DTPicker1.Value), "00")

        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrform(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrform(0) = "@mes='" & DesMes(VGParamSistem.Mesproceso) & "'"
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrform(1). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrform(1) = "@Tituloreporte='Acumulados por Centro de Costos '"

        If Option1.Checked = True Then
            Call ImpresionRptProc("ct_listacentrocostosresumen.rpt", arrform, arrparm, , "Reporte Centro de Costos x Cuentas Acumulado ")
        Else
            Call ImpresionRptProc("ct_cuentaxcentrocostodetallado.rpt", arrform, arrparm, , "Reporte acumulado ")
        End If
    End Sub

    Private Sub imprimir4()
        Dim arrform(2) As Object
        Dim arrparm(5) As Object
        '  VGvardllgen = New dllgeneral.dll_general
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(0) = VGParamSistem.BDEmpresa
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(1). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(1) = VGParametros.empresacodigo
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(2). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(2) = VGParamSistem.Anoproceso
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(3). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(3) = VB6.Format(Month(DTPicker1.Value), "00")

        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrform(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrform(0) = "@mes='" & DesMes(VGParamSistem.Mesproceso) & "'"
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrform(1). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrform(1) = "@Tituloreporte='Acumulados por Centro de Costos '"

        If Option1.Checked = True Then
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(4). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            arrparm(4) = 0
            Call ImpresionRptProc("ct_listacentrocostoAcumMes.rpt", arrform, arrparm, , "Reporte resumido ")
        Else
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(4). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            arrparm(4) = 1
            Call ImpresionRptProc("ct_listacentrocostoAcumxMeses.rpt", arrform, arrparm, , "Reporte resumido ")
        End If
    End Sub
	
	Private Sub cmdCancelar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancelar.Click
		Me.Close()
	End Sub
	
	Private Sub frmRepCentrodeCostosAcumulado_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Option1.Checked = True
		Option3.Checked = True
		
		DTPicker1.Value = DateSerial(CShort(VGParamSistem.Anoproceso), CShort(VGParamSistem.Mesproceso), 1)
		
	End Sub
	
	
	'UPGRADE_WARNING: El evento Option3.CheckedChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub Option3_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Option3.CheckedChanged
		If eventSender.Checked Then
			If Option3.Checked = True Then
				Option2.Enabled = False
			End If
		End If
	End Sub
	
	'UPGRADE_WARNING: El evento Option4.CheckedChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub Option4_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Option4.CheckedChanged
		If eventSender.Checked Then
			If Option4.Checked = True Then
				Option2.Enabled = True
			End If
		End If
	End Sub
End Class