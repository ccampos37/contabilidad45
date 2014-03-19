Option Strict Off
Option Explicit On
Friend Class frmRepListadoCtasDist
	Inherits System.Windows.Forms.Form
	
	Private Sub frmRepListadoCtasDist_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Ctr_Ayuda1.Conexion(VGCNx)
		
	End Sub
	
	Private Sub axBotones_Click(ByRef Index As Short)
		Select Case Index
			Case 0
				Call Impresion()
				
			Case 1 : Me.Close()
				
		End Select
		
	End Sub
	
	Sub Impresion()
		'FIXIT: Declare 'arrform' and 'arrparm' con un tipo de datos de enlace en tiempo de compilación     FixIT90210ae-R1672-R1B8ZE
		Dim arrform(2) As Object
		Dim arrparm() As Object
		ReDim arrparm(2)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(0) = VGParamSistem.BDEmpresa
		'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(1). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(1) = IIf(IsNothing(Ctr_Ayuda1.xclave), "%%", Trim(Ctr_Ayuda1.xclave))
		VGvardllgen = New dllgeneral.dll_general
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrform(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrform(0) = "@TituloReporte='" & "Listado de Cuentas Distribución" & "'"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrform(1). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrform(1) = "@Mes='" & DesMes(VGParamSistem.Mesproceso) & "'"
		Call ImpresionRptProc("rptListadoCtasDistribucion.rpt", arrform, arrparm)
	End Sub
End Class