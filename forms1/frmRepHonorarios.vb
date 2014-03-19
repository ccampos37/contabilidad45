Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmRepHonorarios
	Inherits System.Windows.Forms.Form
	Dim RSparHonorario As ADODB.Recordset
	
	Private Sub axBAceptar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles axBAceptar.Click
		If ValidaParametros = True Then
			Call imprimir()
		End If
	End Sub
	
	Private Sub axBCancelar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles axBCancelar.Click
		Me.Close()
	End Sub
	
	Private Sub frmRepHonorarios_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		RSparHonorario = New ADODB.Recordset
		CmbOrden.SelectedIndex = 0
		Ctr_Ayuda2.Conexion(VGCNx)
	End Sub
	
	Public Sub imprimir()
		'FIXIT: Declare 'arrform' con un tipo de datos de enlace en tiempo de compilación          FixIT90210ae-R1672-R1B8ZE
		Dim arrform(2) As Object
		Dim arrparm(9) As Object
		Dim NombreRep, CadOrden As String
		Dim mon As String
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(0) = VGParamSistem.BDEmpresa
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(1). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(1) = VGParametros.empresacodigo
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(2). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(2) = VGParamSistem.Anoproceso
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(3). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(3) = Trim(VGParamSistem.Mesproceso)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(4). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(4) = RSparHonorario.Fields("paramlibauxasiento").Value
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(5). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(5) = RSparHonorario.Fields("paramlibauxcuenta").Value
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(6). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(6) = RSparHonorario.Fields("paramlibauxies").Value
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(7). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(7) = RSparHonorario.Fields("paramlibauxirenta").Value
		'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(8). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(8) = IIf(IsNothing(Ctr_Ayuda2.xclave), "%%", Trim(Ctr_Ayuda2.xclave))
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrform(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrform(0) = "@TituloReporte='" & "Reporte de Honorarios" & "'"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrform(1). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrform(1) = "@mes='MES DE " & DesMes(VGParamSistem.Mesproceso) & " - " & VGParamSistem.Anoproceso & "'"
		NombreRep = "rptHonorarios.rpt"
		CadOrden = CStr(Nothing)
		Select Case CmbOrden.SelectedIndex
			Case 0
				CadOrden = "+{ct_registroHonorarios_rpt.cabcomprobnumero},"
			Case 1
				CadOrden = "+{ct_registroHonorarios_rpt.detcomprobfechaemision},"
			Case 2
				CadOrden = "+{ct_registroHonorarios_rpt.detcomprobnumdocumento},"
			Case 3
				CadOrden = "+{ct_registroHonorarios_rpt.entidadrazonsocial},+{ct_registroHonorarios_rpt.detcomprobnumdocumento},"
		End Select
		Call ImpresionRptProc(NombreRep, arrform, arrparm, CadOrden, "Reporte de Honorarios")
	End Sub
	Public Sub CapturaParm(ByRef Asientos As String, ByRef CtasComp As String, ByRef CtasIGV As String)
		'SET @ASIENTOSPLAN=' (''064'') '
		'SET @CTASPLANCOMP=' (A.cuentacodigo like ''94%'' or A.cuentacodigo like ''33%'') '
		'SET @CTASIGV1=' (A.cuentacodigo like ''401174'') '*/
		'SET @CTASIGV2=' (A.cuentacodigo like ''403140'') '*/
		'paramlibauxasiento --> Asientos de Honorarios
		'paramlibauxcuenta  --> Cuentas de Honorarios
		'paramlibauxigv --> cuentas de Impuesto Renta e IES
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
	
	Function ValidaParametros() As Boolean
		VGvardllgen = New dllgeneral.dll_general
		RSparHonorario = New ADODB.Recordset
		RSparHonorario.Open("select * from ct_paramlibaux where paramlibauxtipo='HO'", VGCNx, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
		If RSparHonorario.RecordCount = 0 Then
			MsgBox("No existen parametros para el Reporte de Honorarios", MsgBoxStyle.Information, Text)
			ValidaParametros = False
			Exit Function
		End If
		
		'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		If IsNothing(RSparHonorario.Fields("paramlibauxirenta").Value) Or IsNothing(RSparHonorario.Fields("paramlibauxies").Value) Then
			MsgBox("Faltan los Parámetros de Impuesto a la Renta ó IES", MsgBoxStyle.Information, Text)
			ValidaParametros = False
			Exit Function
		End If
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(RSparHonorario!paramlibauxies, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(RSparHonorario!paramlibauxirenta, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If ESNULO(RSparHonorario.Fields("paramlibauxirenta"), 0) = 0 Or ESNULO(RSparHonorario.Fields("paramlibauxies"), 0) = 0 Then
			MsgBox("Faltan los Parámetros de Impuesto a la Renta ó IES", MsgBoxStyle.Information, Text)
			ValidaParametros = False
			Exit Function
		End If
		
		ValidaParametros = True
		
	End Function
End Class