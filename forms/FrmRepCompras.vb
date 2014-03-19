Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class FrmRepCompras
	Inherits System.Windows.Forms.Form
	'FIXIT: Utilice Option Explicit para evitar la creación implícita de variables de tipo Variant.     FixIT90210ae-R383-H1984
	Dim RSparCompras As ADODB.Recordset
	
	Private Sub axBAceptar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles axBAceptar.Click
		Call imprimir()
	End Sub
	
	Private Sub axBCancelar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles axBCancelar.Click
		Me.Close()
	End Sub
	
	'UPGRADE_WARNING: El evento CmbTipo.SelectedIndexChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub CmbTipo_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmbTipo.SelectedIndexChanged
		If CmbTipo.SelectedIndex = 2 Then
			Label2.Enabled = False
			CmbOrden.Enabled = False
		Else
			Label2.Enabled = True
			CmbOrden.Enabled = True
		End If
	End Sub
	
	Private Sub FrmRepCompras_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		RSparCompras = New ADODB.Recordset
		CmbTipo.SelectedIndex = 0
		CmbOrden.SelectedIndex = 0
	End Sub
	
	Public Sub imprimir()
		'FIXIT: Declare 'arrform' con un tipo de datos de enlace en tiempo de compilación          FixIT90210ae-R1672-R1B8ZE
		Dim arrform(1) As Object
		Dim arrparm(9) As Object
		Dim NombreRep, CadOrden As String
		Dim mon As String
		'@BASE, @ANNO, @MES, @ASIENTOSPLAN, @CTASPLANCOMP, @CTASIGV
		RSparCompras = New ADODB.Recordset
		RSparCompras.Open("select * from ct_paramlibaux where paramlibauxtipo='CO'", VGCNx, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
		If RSparCompras.RecordCount = 0 Then
			MsgBox("No existen parametros para el registros de compras")
			Exit Sub
		End If
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(0) = VGParamSistem.BDEmpresa
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(1). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(1) = VGParametros.empresacodigo
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(2). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(2) = VGParamSistem.Anoproceso
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(3). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(3) = Trim(VGParamSistem.Mesproceso)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(4). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(4) = RSparCompras.Fields("paramlibauxasiento").Value
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(5). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(5) = RSparCompras.Fields("paramlibauxcuenta").Value
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(6). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(6) = RSparCompras.Fields("paramlibauxigv").Value
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(7). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(7) = RSparCompras.Fields("paramlibauxies").Value
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(8). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(8) = RSparCompras.Fields("paramlibauxirenta").Value
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrform(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrform(0) = "periodo='" & DesMes(Trim(VGParamSistem.Mesproceso)) & "'"
		Select Case CmbTipo.SelectedIndex
			Case 0
				NombreRep = "rptRegistroCompras.Rpt"
			Case 1
				NombreRep = "rptRegistroComprasprov.Rpt"
			Case 2
				NombreRep = "rptRegistroComprasSunat.rpt"
		End Select
		CadOrden = ""
		
		Select Case CmbOrden.SelectedIndex
			Case 0
				CadOrden = "+{ct_registrocompras_rpt.detcomprobfechaemision},"
			Case 1
				CadOrden = "+{ct_registrocompras_rpt.cabcomprobnumero},"
			Case 2
				CadOrden = "+{ct_registrocompras_rpt.numauxiliar},"
				
		End Select
		If CmbTipo.SelectedIndex = 2 Then CadOrden = ""
		Call ImpresionRptProc(NombreRep, arrform, arrparm, CadOrden, "Registro de Compras ")
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