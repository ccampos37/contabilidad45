Option Strict Off
Option Explicit On
Friend Class FrmLibroMayor
	Inherits System.Windows.Forms.Form
	Public m_tituloreporte As String
	Public m_caso As String
	
	'UPGRADE_WARNING: El evento chkAcumula.CheckStateChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkAcumula_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkAcumula.CheckStateChanged
		If chkAcumula.CheckState = 0 Then
			Call SeleccionarMes(CShort(VGParamSistem.Mesproceso), CShort(VGParamSistem.Anoproceso))
			DTPickerFecInicio.Enabled = False
			DTPickerFecFinal.Enabled = False
		Else
			DTPickerFecInicio.Enabled = True
			DTPickerFecFinal.Enabled = True
		End If
	End Sub
	
	Private Sub Ctr_AyudaAsiento_AlDevolverDato(ByVal eventSender As System.Object, ByVal eventArgs As Axctrlayuda_f.__Ctr_Ayuda_AlDevolverDatoEvent) Handles Ctr_AyudaAsiento.AlDevolverDato
		Ctr_AyudaSubAsiento.Filtro = "asientocodigo='" & Ctr_AyudaAsiento.xclave & "'"
	End Sub
	
	Private Sub FrmLibroMayor_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Call ConfiguraForm()
		Call SeleccionarMes(CShort(VGParamSistem.Mesproceso), CShort(VGParamSistem.Anoproceso))
		DTPickerFecInicio.Enabled = False
		DTPickerFecFinal.Enabled = False
	End Sub
	
	Sub ConfiguraForm()
		Me.Text = m_tituloreporte
		Ctr_Ayucuenta(0).Conexion(VGCNx)
		Ctr_Ayucuenta(1).Conexion(VGCNx)
		Ctr_AyudaAsiento.Conexion(VGCNx)
		Ctr_AyudaSubAsiento.Conexion(VGCNx)
		Ctr_AyudaEntidad.Conexion(VGCNx)
		Ctr_Ayucuenta(0).Filtro = "empresacodigo='" & VGParametros.empresacodigo & "' and cuentacodigo<>'00'"
		Ctr_Ayucuenta(1).Filtro = "empresacodigo='" & VGParametros.empresacodigo & "' and cuentacodigo<>'00'"
		Ctr_AyudaAsiento.Filtro = "asientocodigo<>'00'"
		Ctr_AyudaSubAsiento.Filtro = "subasientocodigo<>'00'"
		If m_caso = "1" Then
			Ctr_AyudaAsiento.Visible = False
			Ctr_AyudaSubAsiento.Visible = False
			Label4.Visible = False : Label5.Text = " Analitico"
			Ctr_AyudaEntidad.Visible = True
		Else
			Ctr_AyudaAsiento.Visible = True
			Ctr_AyudaSubAsiento.Visible = True
			Label4.Visible = True
			Label5.Visible = True
			
			Ctr_AyudaEntidad.Visible = False
		End If
	End Sub
	
	WriteOnly Property tituloreporte() As String
		Set(ByVal Value As String)
			m_tituloreporte = Value
		End Set
	End Property
	
	WriteOnly Property Caso() As String
		Set(ByVal Value As String)
			m_caso = Value
		End Set
	End Property
	
	Private Sub cmdBotones_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBotones.Click
		Dim Index As Short = cmdBotones.GetIndex(eventSender)
		Select Case Index
			Case 0
				Select Case m_caso
					Case "1" 'Imprimir Libro Mayor Analítico
						If ValidarImpresion = True Then
							Call ImpresionMayorAnalitico()
						End If
					Case "2" 'Imprimir Libro Mayor General
						Call ImpresionMayorGeneral()
				End Select
				
			Case 1 : Me.Close()
				
		End Select
		
	End Sub
	
	Sub SeleccionarMes(ByRef nMes As Short, ByRef nAnno As Short)
		DTPickerFecInicio.Value = VB6.Format("01/" & nMes & "/" & nAnno, "dd/mm/yyyy")
		DTPickerFecFinal.Value = DateAdd(Microsoft.VisualBasic.DateInterval.Day, -1, DateAdd(Microsoft.VisualBasic.DateInterval.Month, 1, DTPickerFecInicio.Value))
	End Sub
	
	Function ValidarImpresion() As Boolean
		If VB6.Format(DTPickerFecInicio.Value, "dd/mm/yyyy") > VB6.Format(DTPickerFecFinal.Value, "dd/mm/yyyy") Then
			MsgBox("La fecha de Término no puede ser mayor a la Fecha de Inicio", MsgBoxStyle.Information, Text)
			ValidarImpresion = False
			DTPickerFecInicio.Focus()
			Exit Function
		End If
		
		ValidarImpresion = True
	End Function
	
	Sub ImpresionMayorAnalitico()
		'FIXIT: Declare 'arrform' and 'arrparm' con un tipo de datos de enlace en tiempo de compilación     FixIT90210ae-R1672-R1B8ZE
		Dim arrform(2) As Object
		Dim arrparm() As Object
		ReDim arrparm(11)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(0) = VGParamSistem.BDEmpresa
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(1). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(1) = VGParametros.empresacodigo
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(2). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(2) = VGParamSistem.Anoproceso
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(3). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(3) = VB6.Format(Month(DTPickerFecInicio.Value) - 1, "0#")
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(4). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(4) = VB6.Format(Month(DTPickerFecInicio.Value), "0#")
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(5). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(5) = VB6.Format(Month(DTPickerFecFinal.Value), "0#")
		'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(6). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(6) = IIf(IsNothing(Ctr_Ayucuenta(0).xclave), "%%", Trim(Ctr_Ayucuenta(0).xclave))
		If Ctr_Ayucuenta(0).xclave = Ctr_Ayucuenta(1).xclave Then
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(7). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			arrparm(7) = "%%"
		Else
			'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(7). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			arrparm(7) = IIf(IsNothing(Ctr_Ayucuenta(1).xclave), "%%", Trim(Ctr_Ayucuenta(1).xclave))
		End If
		'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(8). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(8) = IIf(IsNothing(Ctr_AyudaEntidad.xclave), "%%", Trim(Ctr_AyudaEntidad.xclave) & "%")
		'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		If IsNothing(Ctr_AyudaEntidad.xclave) Then
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(9). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			arrparm(9) = "TODOS"
		Else
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(9). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			arrparm(9) = Ctr_AyudaEntidad.xnombre
		End If
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(10). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(10) = "FORMATO 06.01"
		VGvardllgen = New dllgeneral.dll_general
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrform(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrform(0) = "@TituloReporte='" & "Libro Mayor Analítico Cuenta: " & "'" 'Ctr_Ayuda1.xclave
		If Month(DTPickerFecInicio.Value) <> Month(DTPickerFecFinal.Value) And Year(DTPickerFecInicio.Value) = Year(DTPickerFecFinal.Value) Then
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrform(1). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			arrform(1) = "@Mes='" & DesMes(CStr(Month(DTPickerFecInicio.Value))) & " - " & DesMes(CStr(Month(DTPickerFecFinal.Value))) & "'"
		Else
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrform(1). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			arrform(1) = "@Mes='" & DesMes(CStr(Month(DTPickerFecInicio.Value))) & "'"
		End If
		Call ImpresionRptProc("ct_libromayor.rpt", arrform, arrparm,  , "Libro Mayor ")
	End Sub
	
	Sub ImpresionMayorGeneral()
		'FIXIT: Declare 'arrform' and 'arrparm' con un tipo de datos de enlace en tiempo de compilación     FixIT90210ae-R1672-R1B8ZE
		Dim arrform(2) As Object
		Dim arrparm() As Object
		ReDim arrparm(10)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(0) = VGParamSistem.BDEmpresa
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(1). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(1) = VGParametros.empresacodigo
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(2). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(2) = VGParamSistem.Anoproceso
		If chkAcumula.CheckState = 1 Then
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(3). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			arrparm(3) = VB6.Format(Month(DTPickerFecInicio.Value), "00")
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(4). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			arrparm(4) = VB6.Format(Month(DTPickerFecFinal.Value), "00")
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(9). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			arrparm(9) = 1
		Else
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(3). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			arrparm(3) = VB6.Format(CDbl(VGParamSistem.Mesproceso) - 1, "00")
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(4). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			arrparm(4) = VB6.Format(VGParamSistem.Mesproceso, "00")
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(9). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			arrparm(9) = 0
		End If
		'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(5). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(5) = IIf(IsNothing(Ctr_Ayucuenta(0).xclave), "%%", Trim(Ctr_Ayucuenta(0).xclave))
		'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(6). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(6) = IIf(IsNothing(Ctr_AyudaAsiento.xclave), "%%", Ctr_AyudaAsiento.xclave)
		'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(7). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(7) = IIf(IsNothing(Ctr_AyudaSubAsiento.xclave), "%%", Ctr_AyudaSubAsiento.xclave)
		'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(8). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(8) = IIf(IsNothing(Ctr_Ayucuenta(1).xclave), "%%", Trim(Ctr_Ayucuenta(1).xclave))
		VGvardllgen = New dllgeneral.dll_general
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrform(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrform(0) = "@TituloReporte='" & "Libro Mayor General " & Ctr_Ayucuenta(0).xclave & " " & Ctr_Ayucuenta(0).xnombre & "'"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrform(1). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrform(1) = "@Mes='" & DesMes(VGParamSistem.Mesproceso) & " - " & VGParamSistem.Anoproceso & "'"
		Call ImpresionRptProc("ct_MayorGeneral.rpt", arrform, arrparm)
	End Sub
End Class