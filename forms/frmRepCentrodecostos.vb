Option Strict Off
Option Explicit On
Friend Class frmRepCentrodeCostos
	Inherits System.Windows.Forms.Form
	'FIXIT: Utilice Option Explicit para evitar la creación implícita de variables de tipo Variant.     FixIT90210ae-R383-H1984
	
	Private Sub cmdAceptar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAceptar.Click
		'FIXIT: Declare 'arrform' con un tipo de datos de enlace en tiempo de compilación          FixIT90210ae-R1672-R1B8ZE
		Dim arrform(2) As Object
		Dim arrparm(6) As Object
        '  VGvardllgen = New dllgeneral.dll_general
		
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(0) = VGParamSistem.BDEmpresa
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(1). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(1) = VGParametros.empresacodigo
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(2). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(2) = VGParamSistem.Anoproceso
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(3). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        arrparm(3) = Format(Month(DTPicker1.Value), "00")
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(4). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(4) = 1
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrform(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrform(0) = "@mes='" & DesMes(VGParamSistem.Mesproceso) & "'"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrform(1). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrform(1) = "@Tituloreporte='Movimientos por Centro de Costos '"
		
		If Option3.Checked = True Then
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(4). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			arrparm(4) = 0
			If Option1.Checked = True Then
				Call ImpresionRptProc("ct_listacentrocostodetallado.rpt", arrform, arrparm,  , "Reporte detallado ")
			Else
				Call ImpresionRptProc("ct_cuentaxcentrocostodetallado.rpt", arrform, arrparm,  , "Reporte detallado ")
			End If
		Else
			If Option1.Checked = True Then
				Call ImpresionRptProc("ct_listacentrocostoresumido.rpt", arrform, arrparm,  , "Reporte resumido ")
			Else
				Call ImpresionRptProc("ct_cuentaxcentrocostoresumido.rpt", arrform, arrparm,  , "Reporte resumido ")
			End If
		End If
	End Sub
	
	Private Sub cmdCancelar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancelar.Click
		Me.Close()
	End Sub
	
	Private Sub frmRepCentrodeCostos_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Option1.Checked = True
		Option3.Checked = True
		
		DTPicker1.Value = DateSerial(CShort(VGParamSistem.Anoproceso), CShort(VGParamSistem.Mesproceso), 1)
		
	End Sub
End Class