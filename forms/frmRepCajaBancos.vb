Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmRepCajaBancos
	Inherits System.Windows.Forms.Form
	'FIXIT: Utilice Option Explicit para evitar la creación implícita de variables de tipo Variant.     FixIT90210ae-R383-H1984
	Dim RSparVentas As ADODB.Recordset
	
	Private Sub axBAceptar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles axBAceptar.Click
		Call imprimir()
	End Sub
	
	Private Sub axBCancelar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles axBCancelar.Click
		Me.Close()
	End Sub
	
	Private Sub frmRepCajaBancos_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		RSparVentas = New ADODB.Recordset
		Ctr_Ayuda1.Conexion(VGCNx)
		Ctr_Ayuda1.Filtro = "cuentacodigo like '10%' AND empresacodigo ='" & VGParametros.empresacodigo & "' "
	End Sub
	
	Public Sub imprimir()
		'FIXIT: Declare 'arrform' con un tipo de datos de enlace en tiempo de compilación          FixIT90210ae-R1672-R1B8ZE
		Dim arrform(3) As Object
		Dim arrparm(7) As Object
		Dim NombreRep, CadOrden As String
		Dim mon As String
		VGvardllgen = New dllgeneral.dll_general
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(0) = VGParamSistem.BDEmpresa
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(1). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(1) = VGParametros.empresacodigo
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(2). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(2) = VGParamSistem.Anoproceso
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(3). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(3) = VB6.Format(CDbl(VGParamSistem.Mesproceso) - 1, "0#")
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(4). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(4) = VB6.Format(VGParamSistem.Mesproceso, "0#")
		'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(5). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(5) = IIf(IsNothing(Ctr_Ayuda1.xclave), "10%", Trim(Ctr_Ayuda1.xclave) & "%%")
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(6). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(6) = "%%"
		
		VGvardllgen = New dllgeneral.dll_general
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrform(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrform(0) = "@TituloReporte='" & "Libro Caja Bancos " & "'" 'Ctr_Ayuda1.xclave
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrform(1). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrform(1) = "@Mes='" & DesMes(VGParamSistem.Mesproceso) & "'"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrform(2). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrform(2) = "@anno='" & VGParamSistem.Anoproceso & "'"
		
		Call ImpresionRptProc("ct_LibroCajaBancos.rpt", arrform, arrparm)
		
	End Sub
	
	Private Function ArmaCriterio(ByRef cad As String, ByRef car As String, Optional ByRef campocrit As String = "") As String
		Dim pos As Short
		Dim cadaux, criterio As String
		Dim valor As String
		criterio = ""
		Do While True
			pos = InStr(1, cad, car, CompareMethod.Text)
			If pos = 0 Then Exit Do
			If campocrit = "" Or Trim(car) = "," Then
				valor = "''" & VB.Left(cad, pos - 1) & "''"
			Else
				valor = "''" & VB.Left(cad, pos) & "''"
			End If
			cad = VB.Right(cad, Len(cad) - pos)
			If campocrit <> "" Then
				criterio = criterio & campocrit & " like " & valor & " or "
			Else
				criterio = criterio & valor & car
			End If
		Loop 
		If campocrit <> "" Then
			ArmaCriterio = VB.Left(criterio, Len(criterio) - 3)
		Else
			ArmaCriterio = VB.Left(criterio, Len(criterio) - 1)
		End If
	End Function
End Class