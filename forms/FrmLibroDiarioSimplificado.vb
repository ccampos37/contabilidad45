Option Strict Off
Option Explicit On
Friend Class FrmLibroDiarioSimplificado
	Inherits System.Windows.Forms.Form
	Private Sub cmdImprimir_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdImprimir.Click
		Dim cMes As String
		Dim arrparm(6) As Object 'Store Procedure:CT_DIARIO2_REP
		Dim arrform(3) As Object
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(0) = VGParamSistem.BDEmpresa
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(1). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(1) = VGParametros.empresacodigo
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(2). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(2) = VGParamSistem.Anoproceso
		If cboMes.SelectedIndex >= 0 Then
			cMes = VB6.Format(cboMes.SelectedIndex + 1, "0#")
		Else
			cMes = VB6.Format(VGParamSistem.Mesproceso, "0#")
		End If
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(3). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(3) = cMes
		'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(4). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(4) = IIf(IsNothing(Ctr_Ayuda2(0).xclave), "%%", Ctr_Ayuda2(0).xclave)
		'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(5). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(5) = IIf(IsNothing(Ctr_Ayuda2(1).xclave), "%%", Ctr_Ayuda2(1).xclave)
		VGvardllgen = New dllgeneral.dll_general
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrform(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrform(0) = "TituloReporte='" & "FORMATO 05.02 - Libro Diario Simplificado '"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrform(1). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrform(1) = "periodo='" & VGParamSistem.Anoproceso & "'" 'VGvardllgen.DESMES(VGParamSistem.Mesproceso)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrform(2). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrform(2) = "Mes='" & DesMes(cMes) & "'" 'VGvardllgen.DESMES(VGParamSistem.Mesproceso)
		
		Call ImpresionRptProc("ct_LibroDiarioSimplificado.rpt", arrform, arrparm)
		
	End Sub
	
	Private Sub cmdSalir_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSalir.Click
		Me.Close()
	End Sub
	
	Private Sub FrmLibroDiarioSimplificado_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Dim NombreTabla As Object
		Call ConfiguraForm()
		Call Llenacbomes()
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto NombreTabla. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		NombreTabla = "CT_CABCOMPROB" & VGParamSistem.Anoproceso
		If IsNumeric(VGParamSistem.Anoproceso) Then
			Call SeleccionarMes(CShort(VGParamSistem.Mesproceso), CShort(VGParamSistem.Anoproceso))
		End If
	End Sub
	
	Sub ConfiguraForm()
		optOpcion(0).Checked = True
		
		Ctr_Ayuda2(0).Conexion(VGCNx)
		Ctr_Ayuda2(1).Conexion(VGCNx)
		
	End Sub
	
	'UPGRADE_WARNING: El evento optOpcion.CheckedChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optOpcion_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optOpcion.CheckedChanged
		If eventSender.Checked Then
			Dim Index As Short = optOpcion.GetIndex(eventSender)
			
			fraDetallado.Visible = True
			
			
			
		End If
	End Sub
	
	
	Sub Llenacbomes()
		Dim I As Short
		VGvardllgen = New dllgeneral.dll_general
		cboMes.Items.Clear()
		For I = 1 To 12
			cboMes.Items.Add(DesMes(Str(I)))
		Next 
		'UPGRADE_NOTE: El objeto VGvardllgen no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		VGvardllgen = Nothing
		
	End Sub
	
	Sub SeleccionarMes(ByRef nMes As Short, ByRef nAnno As Short)
		cboMes.Text = VB6.GetItemString(cboMes, nMes - 1)
		DTPickerFecInicio.Value = VB6.Format("01/" & nMes & "/" & nAnno, "dd/mm/yyyy")
		DTPickerFecFinal.Value = DateAdd(Microsoft.VisualBasic.DateInterval.Day, -1, DateAdd(Microsoft.VisualBasic.DateInterval.Month, 1, DTPickerFecInicio.Value))
	End Sub
	
	'UPGRADE_WARNING: El evento cboMes.SelectedIndexChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cboMes_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboMes.SelectedIndexChanged
		Call SeleccionarMes(cboMes.SelectedIndex + 1, CShort(VGParamSistem.Anoproceso))
	End Sub
	
	Function ValidaData() As Boolean
		Dim NombreTabla As Object
		Dim SQL As String
		VGvardllgen = New dllgeneral.dll_general
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto DTPickerFecFinal.Value. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto DTPickerFecInicio.Value. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If DTPickerFecInicio.Value > DTPickerFecFinal.Value Then
			MsgBox("La Fecha de Término es menor a la Fecha de Inicio", MsgBoxStyle.Information, Text)
			DTPickerFecInicio.Focus()
			ValidaData = False
			Exit Function
		End If
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto NombreTabla. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		SQL = "select name from sysobjects where name='" & NombreTabla & "'"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VerificaDatoExistente(VGCNx, SQL). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If VerificaDatoExistente(VGCNx, SQL) > 0 Then
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto NombreTabla. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			SQL = "select asientocodigo from " & NombreTabla & " "
			SQL = SQL & "WHERE  asientocodigo='" & Ctr_Ayuda2(0).xclave & "' "
			
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VerificaDatoExistente(VGCNx, SQL). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If VerificaDatoExistente(VGCNx, SQL) = 0 Then
				MsgBox("No existe Información para Mostrar", MsgBoxStyle.Information, Text)
				ValidaData = False
				Exit Function
			End If
		Else
			MsgBox("No existen las Tablas para el Año de Proceso Actual: " & VGParamSistem.Anoproceso & vbCrLf & "Consulte con el Administrador del Sistema Contable", MsgBoxStyle.Exclamation, Text)
			ValidaData = False
			Exit Function
		End If
		
		ValidaData = True
	End Function
	
	Private Sub DTPickerFecInicio_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles DTPickerFecInicio.Enter
		DTPickerFecInicio.CalendarBackColor = System.Drawing.ColorTranslator.FromOle(&HE2FDFE)
	End Sub
	
	Private Sub DTPickerFecFinal_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles DTPickerFecFinal.Enter
		DTPickerFecFinal.CalendarBackColor = System.Drawing.ColorTranslator.FromOle(&HE2FDFE)
	End Sub
	
	
	
	Private Sub Ctr_Ayuda2_AlDevolverDato(ByVal eventSender As System.Object, ByVal eventArgs As Axctrlayuda_f.__Ctr_Ayuda_AlDevolverDatoEvent) Handles Ctr_Ayuda2.AlDevolverDato
		Dim Index As Short = Ctr_Ayuda2.GetIndex(eventSender)
		If Index = 0 Then
			Ctr_Ayuda2(1).Filtro = "asientocodigo='" & Trim(Ctr_Ayuda2(0).xclave) & "'"
		End If
		
	End Sub
End Class