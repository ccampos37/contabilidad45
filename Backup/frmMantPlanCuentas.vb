Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmMantPlanCuentas
	Inherits System.Windows.Forms.Form
	
	Dim modoinsert As Boolean
	Dim modoedit As Boolean
	Dim i_filaorigen As Short
	Dim rs As New ADODB.Recordset
	Dim rsDist As New ADODB.Recordset
	Dim cCta As String
	Dim dCta As String
	Dim xcuenta As String
	Dim xdllgen As New dllgeneral.dll_general
	Dim FLAGMOVIMIENTODISTRI As Boolean
	Dim FLAGDISTRIBUCION As Boolean
	Dim l_error As String
	
	Private Sub frmMantPlanCuentas_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		l_error = CStr(Nothing)
		Call ConfiguraForm()
		Call MuestraDatos(CStr(Nothing))
		'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Call Arbol((txtBuscar.CtlText))
		xdllgen = New dllgeneral.dll_general
		If Len(l_error) > 0 Then
			frmError.RichError.Text = l_error
			'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
			System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
			frmError.ShowDialog()
		End If
		'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
		TDBGrid1.FetchRowStyle = True
		xcuenta = "%"
	End Sub
	
	Sub ConfiguraForm()
		SSTab1.SelectedIndex = 0
		SSTab1.TabPages.Item(1).Enabled = False
		SSTab1.TabPages.Item(2).Enabled = False
		Ctr_Ayuda1.Conexion(VGCNx)
		Ctr_Ayuda2.Conexion(VGCNx)
		Ctr_Ayuda3.Conexion(VGCNx)
		Ctr_Ayuda2.Filtro = "empresacodigo='" & VGParametros.empresacodigo & "' and cuentanivel=" & VGnumnivelescuenta
		Ctr_Ayuda3.Filtro = "empresacodigo='" & VGParametros.empresacodigo & "' and  cuentanivel=" & VGnumnivelescuenta
		Ctr_Ayuda4.Conexion(VGCNx)
		cAcepta.Enabled = False
		lblNumReg.Text = CStr(Nothing)
		FLAGMOVIMIENTODISTRI = False
		FLAGDISTRIBUCION = False
		Call IniciaGridDist()
	End Sub
	
	Public Function MuestraDatos(ByRef xCta As String) As Object
		Dim SQL As String
		SQL = "SELECT a.cuentacodigo, cuentadescripcion, cuentalineaactivo, cuentalineapasivo,cuentanatu,"
		SQL = SQL & "cuentalineaegp,cuentanategp, cuentaestadoanalitico,a.tipoanaliticocodigo, cuentaestadoccostos,"
		SQL = SQL & "cuentadocumento,cuentanivel,b.tipoanaliticodescripcion,cuentaestadodistribucion,cuentaestado,tipocuentacodigo,tipoajuste,cuentaadicionacargo "
		SQL = SQL & "FROM ct_cuenta a INNER JOIN  ct_tipoanalitico b ON a.tipoanaliticocodigo =b.tipoanaliticocodigo "
		SQL = SQL & "WHERE empresacodigo='" & VGParametros.empresacodigo & "' and cuentacodigo<>'00'"
		'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		If Not IsNothing(xCta) Then
			SQL = SQL & " AND a.cuentacodigo like '" & Trim(xCta) & "%' "
		End If
		SQL = SQL & " ORDER BY 1"
		rs = VGCNx.Execute(SQL)
		TDBGrid1.DataSource = rs
		Call ConfiguraTdbgrid()
		lblNumReg.Text = CStr(rs.RecordCount)
		SSTab1.SelectedIndex = 0
	End Function
	
	Private Sub txtBuscar_KeyDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTextFer.__TxFer_KeyDownEvent) Handles txtBuscar.KeyDownEvent
		If eventArgs.KeyCode = 13 Then
			Call cmdBuscar_Click(cmdBuscar, New System.EventArgs())
		End If
	End Sub
	
	Private Sub cmdBuscar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBuscar.Click
		VGvardllgen = New dllgeneral.dll_general
		'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txtBuscar.CtlText = ESNULO((txtBuscar.CtlText), "%")
		'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Call MuestraDatos((txtBuscar.CtlText))
		'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Call Arbol((txtBuscar.CtlText))
	End Sub
	
	Sub EditarValores()
		Dim I As Short
		With TDBGrid1
			For I = 0 To 6
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto xdllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
				txt(I).CtlText = Trim(xdllgen.ESNULO((.Columns(I).Text), Nothing))
			Next 
			chk(0).CheckState = IIf(CDbl(Trim(.Columns(7).Text)) = -1, 1, 0)
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto xdllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Ctr_Ayuda1.xclave = Trim(xdllgen.ESNULO((.Columns(8).Text), Nothing)) : Ctr_Ayuda1.Ejecutar()
			chk(1).CheckState = IIf(CDbl(Trim(.Columns(9).Text)) = -1, 1, 0)
			chk(2).CheckState = IIf(CDbl(Trim(.Columns(10).Text)) = -1, 1, 0)
			chk(3).CheckState = IIf(CDbl(Trim(.Columns(13).Text)) = -1, 1, 0)
			chk(4).CheckState = IIf(CDbl(Trim(.Columns(14).Text)) = -1, 1, 0)
			chk(5).CheckState = IIf(CDbl(Trim(.Columns(17).Text)) = 1, 1, 0)
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto xdllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			lblNivel.Text = Trim(xdllgen.ESNULO((.Columns(11).Text), Nothing))
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto xdllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Ctr_Ayuda4.xclave = xdllgen.ESNULO((.Columns(15).Text), Nothing) : Ctr_Ayuda4.Ejecutar()
			
			cboTipoAjuste.SelectedIndex = CShort(.Columns(16).Text)
			
		End With
		Call ConfiguraModoEdicion()
	End Sub
	
	Sub ConfiguraModoEdicion()
		'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		If IsNothing(lblNivel.Text) Then
			MsgBox("Debe registrar el Código de Cuenta Contable", MsgBoxStyle.Information, Text)
			Call ModoNormal() 'Deshabilitar todos los objetos de ingreso
			txt(0).Focus()
		Else
			If CDbl(lblNivel.Text) = 1 Then 'Preguntar por 1º Nivel
				'UPGRADE_NOTE: Enabled se actualizó a CtlEnabled. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
				Ctr_Ayuda4.CtlEnabled = True
			Else
				'UPGRADE_NOTE: Enabled se actualizó a CtlEnabled. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
				Ctr_Ayuda4.CtlEnabled = False
			End If
			
			If CDbl(lblNivel.Text) = VGnumnivelescuenta Then
				Call ModoEdicion(True)
			Else
				Call ModoEdicion(False)
			End If
		End If
	End Sub
	
	Public Function LimpiarValores() As Object
		Dim I As Short
		Ctr_Ayuda1.xclave = CStr(Nothing) : Ctr_Ayuda1.Ejecutar()
		Ctr_Ayuda4.xclave = CStr(Nothing) : Ctr_Ayuda4.Ejecutar()
		For I = 0 To 6
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			txt(I).CtlText = Nothing
		Next 
		For I = 0 To 3
			chk(I).CheckState = System.Windows.Forms.CheckState.Unchecked
		Next 
		chk(4).CheckState = System.Windows.Forms.CheckState.Checked
		lblNivel.Text = CStr(Nothing)
		'cboTipoAjuste.SelText = Empty
		
	End Function
	
	Private Sub cAcepta_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cAcepta.Click
		If ValidarData = True Then
			Call GrabarData()
		End If
	End Sub
	
	Private Sub cCancela_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cCancela.Click
		SSTab1.TabPages.Item(0).Enabled = True
		SSTab1.SelectedIndex = 0
		SSTab1.Focus()
		Toolbar1.Visible = True
		TreeView1.Enabled = True
		modoinsert = False
		modoedit = False
		i_filaorigen = -1
		FLAGDISTRIBUCION = False
	End Sub
	
	Sub GrabarData()
		Dim SQL As String
		'On Error GoTo X
		
		SSTab1.TabPages.Item(0).Enabled = True
		If cboTipoAjuste.SelectedIndex < 0 Then cboTipoAjuste.SelectedIndex = 0
		
		If modoinsert = True Then
			VGCNx.BeginTrans()
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			SQL = GrabarPlanCuenta(0, txt(0).CtlText, txt(1).CtlText, Val(txt(2).CtlText), Val(txt(3).CtlText), Val(txt(5).CtlText), txt(4).CtlText, txt(6).CtlText, chk(1).CheckState, chk(0).CheckState, chk(2).CheckState, CShort(lblNivel.Text), (Ctr_Ayuda1.xclave), chk(3).CheckState, (Ctr_Ayuda4.xclave), VB.Left(VB6.GetItemString(cboTipoAjuste, cboTipoAjuste.SelectedIndex), 2), CStr(chk(5).CheckState))
			VGCNx.Execute(SQL)
			
			If CShort(lblNivel.Text) = VGnumnivelescuenta And FLAGDISTRIBUCION = True Then
				Call GrabarCuentaDistribucion()
				Call GrabarTablaSaldos()
			End If
			
			VGCNx.CommitTrans()
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			Call Arbol((txtBuscar.CtlText))
			
		ElseIf modoedit = True Then 
			VGCNx.BeginTrans()
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			SQL = GrabarPlanCuenta(1, txt(0).CtlText, txt(1).CtlText, Val(txt(2).CtlText), Val(txt(3).CtlText), Val(txt(5).CtlText), txt(4).CtlText, txt(6).CtlText, chk(1).CheckState, chk(0).CheckState, chk(2).CheckState, CShort(lblNivel.Text), (Ctr_Ayuda1.xclave), chk(3).CheckState, (Ctr_Ayuda4.xclave), VB.Left(VB6.GetItemString(cboTipoAjuste, cboTipoAjuste.SelectedIndex), 2), CStr(chk(5).CheckState))
			VGCNx.Execute(SQL)
			
			If CShort(lblNivel.Text) = VGnumnivelescuenta And FLAGDISTRIBUCION = True Then
				Call GrabarCuentaDistribucion()
			End If
			If CDbl(lblNivel.Text) = 1 Then
				'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
				Call GrabaTipoCuenta(txt(0).CtlText, (Ctr_Ayuda4.xclave), CShort(lblNivel.Text))
			End If
			
			VGCNx.CommitTrans()
		End If
		
		Call MuestraDatos(VB.Right(Trim(cCta), CInt(Len(Trim(cCta))) - 1))
		Toolbar1.Visible = True : TreeView1.Enabled = True
		'UPGRADE_NOTE: Enabled se actualizó a CtlEnabled. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		txt(0).CtlEnabled = True
		modoinsert = False : modoedit = False
		i_filaorigen = -1
		'UPGRADE_NOTE: Enabled se actualizó a CtlEnabled. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Ctr_Ayuda1.CtlEnabled = False
		FLAGDISTRIBUCION = False
		FLAGMOVIMIENTODISTRI = False
		'UPGRADE_NOTE: El objeto rsDist no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsDist = Nothing
		Exit Sub
		
x: 
		If Err.Number = -2147217873 Then
			MsgBox("Esta intentando registrar uno Existente " & Err.Description, MsgBoxStyle.Information, Text)
		Else
			MsgBox("Error inesperado: " & Err.Number & " " & Err.Description, CDbl(Text))
		End If
		VGCNx.RollbackTrans()
		
	End Sub
	
	Function ValidarData() As Boolean
		Dim I As Short
		Dim SQL As String
		'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		If IsNothing(lblNivel.Text) Then
			MsgBox("No se ha podido registrar el Número de Nivel de la Cuenta Contable", MsgBoxStyle.Information, Text)
			ValidarData = False
			txt(0).Focus()
			Exit Function
		End If
		If CDbl(lblNivel.Text) - 2 < 0 Then
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			If VG_aNIVELES(CDbl(lblNivel.Text) - 1) < CInt(Len(txt(0).CtlText)) Then
				MsgBox("La Cuenta a registrar no corresponde con el Nivel de Cuenta", MsgBoxStyle.Information, Text)
				ValidarData = False
				txt(0).Focus()
				'    Exit Function
			End If
		Else
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			If VG_aNIVELES(CDbl(lblNivel.Text) - 1) < CInt(Len(txt(0).CtlText)) Or VG_aNIVELES(CDbl(lblNivel.Text) - 2) >= CInt(Len(txt(0).CtlText)) Then
				MsgBox("La Cuenta a registrar no corresponde con el Nivel de Cuenta", MsgBoxStyle.Information, Text)
				ValidarData = False
				txt(0).Focus()
				'    Exit Function
			End If
		End If
		
		If CInt(lblNivel.Text) > 1 Then
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			SQL = "SELECT cuentacodigo FROM CT_CUENTA WHERE cuentacodigo='" & VB.Left(txt(0).CtlText, VG_aNIVELES(CDbl(lblNivel.Text) - 2)) & "'"
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VerificaDatoExistente(VGCNx, SQL). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If VerificaDatoExistente(VGCNx, SQL) <= 0 Then
				MsgBox("La Cuenta a registrar no tiene la Cuenta Superior Correspondiente ", MsgBoxStyle.Information, Text)
				ValidarData = False
				txt(0).Focus()
				Exit Function
			End If
		End If
		
		'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		SQL = "SELECT cuentacodigo FROM CT_CUENTA WHERE cuentacodigo='" & txt(0).CtlText & "' and empresacodigo='" & VGParametros.empresacodigo & "'"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VerificaDatoExistente(VGCNx, SQL). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If modoinsert = True And VerificaDatoExistente(VGCNx, SQL) > 0 Then
			MsgBox("La Cuenta se encuentra registrada en la Base Datos, Debe registrar otra", MsgBoxStyle.Information, Text)
			ValidarData = False
			txt(0).Focus()
			Exit Function
		End If
		
		'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		If IsNothing(Ctr_Ayuda4.xclave) Then
			MsgBox("No existe Código de Tipo de Cuenta en el registro editado", MsgBoxStyle.Information, Text)
			If CDbl(lblNivel.Text) = 1 Then
				Ctr_Ayuda4.Focus()
			Else
				txt(0).Focus()
			End If
			ValidarData = False
			Exit Function
		End If
		
		If CInt(lblNivel.Text) > 1 Then
			'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			If chk(0).CheckState = 1 And IsNothing(Ctr_Ayuda1.xclave) Then
				MsgBox("Falta indicar el Tipo de Analítico", MsgBoxStyle.Information, Text)
				ValidarData = False
				Ctr_Ayuda1.Focus()
				Exit Function
			End If
		End If
		
		If chk(3).CheckState = 1 And FLAGDISTRIBUCION = False Then
			MsgBox("No Existe Porcentaje de Distribución para esta cuenta, Deshabilitar el check", MsgBoxStyle.Information, Text)
			ValidarData = False
			chk(3).Focus()
			Exit Function
		End If
		
		ValidarData = True
	End Function
	
	'UPGRADE_WARNING: El evento chk.CheckStateChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chk_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chk.CheckStateChanged
		Dim Index As Short = chk.GetIndex(eventSender)
		Select Case Index
			Case 0
				'UPGRADE_NOTE: Enabled se actualizó a CtlEnabled. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
				Ctr_Ayuda1.CtlEnabled = IIf(chk(0).CheckState = 0, False, True)
				If chk(0).CheckState = 0 Then Ctr_Ayuda1.xclave = CStr(Nothing) : Ctr_Ayuda1.xnombre = CStr(Nothing)
				
			Case 3
				If chk(3).CheckState = 1 Then
					If FLAGMOVIMIENTODISTRI = False Then
						cmdDistribucion.Visible = True
						SSTab1.TabPages.Item(2).Enabled = True
						SSTab1.SelectedIndex = 2
						FLAGMOVIMIENTODISTRI = False
						Call LlenarPorcentajes()
					End If
				Else
					cmdDistribucion.Visible = False
					SSTab1.TabPages.Item(2).Enabled = False
				End If
		End Select
		
		If modoedit = True Then
			cAcepta.Enabled = True
		End If
		
	End Sub
	
	Private Sub frmMantPlanCuentas_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		'UPGRADE_NOTE: El objeto rs no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rs = Nothing
		'UPGRADE_NOTE: El objeto rsDist no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsDist = Nothing
	End Sub
	
	Private Sub SSTab1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles SSTab1.SelectedIndexChanged
		Static PreviousTab As Short = SSTab1.SelectedIndex()
		SSTab1.TabPages.Item(PreviousTab).Enabled = False
		PreviousTab = SSTab1.SelectedIndex()
	End Sub
	
	Private Sub TDBGrid1_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TDBGrid1.DblClick
		If rs.RecordCount > 0 And (modoedit = False And modoinsert = False) Then Call Mantenimiento(1)
	End Sub
	
	'UPGRADE_NOTE: Split se actualizó a Split_Renamed. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub TDBGrid1_FetchRowStyle(ByVal Split_Renamed As Short, ByRef Bookmark As Object, ByVal RowStyle As TrueOleDBGrid70.StyleDisp)
		Dim rsX As ADODB.Recordset
		rsX = rs.Clone(ADODB.LockTypeEnum.adLockReadOnly)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Bookmark. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		rsX.Bookmark = Bookmark
		If rsX.Fields("cuentanivel").Value = 1 Then
			RowStyle.BackColor = System.Convert.ToUInt32(&H80000018)
		End If
		
	End Sub
	
	Private Sub TDBGrid1_HeadClick(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueOleDBGrid70.TrueDBGridEvents_HeadClickEvent) Handles TDBGrid1.HeadClick
		On Error Resume Next
		'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		If IsNothing(rs.Sort) Then
			rs.Sort = TDBGrid1.Columns.Item(eventArgs.ColIndex).DataField & " asc"
		ElseIf VB.Right(rs.Sort, 3) = "asc" Then 
			rs.Sort = TDBGrid1.Columns.Item(eventArgs.ColIndex).DataField & " desc"
		ElseIf VB.Right(rs.Sort, 4) = "desc" Then 
			rs.Sort = TDBGrid1.Columns.Item(eventArgs.ColIndex).DataField & " asc"
		End If
		Call ConfiguraTdbgrid()
		'UPGRADE_NOTE: Refresh se actualizó a CtlRefresh. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        TDBGrid1.Refresh()
    End Sub

    Private Sub ConfiguraTdbgrid()
        With TDBGrid1
            .Columns(0).Width = 900
            .Columns(1).Width = 4100
            .Columns(2).Width = 800
            .Columns(3).Width = 800
            .Columns(4).Width = 800
            .Columns(5).Width = 800
            .Columns(6).Width = 800
        End With

    End Sub

    Private Sub Toolbar1_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _Toolbar1_Button1.Click, _Toolbar1_Button2.Click, _Toolbar1_Button3.Click, _Toolbar1_Button4.Click, _Toolbar1_Button5.Click
        Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)
        Call Mantenimiento(Button.Owner.Items.IndexOf(Button) - 1)
    End Sub

    Sub Mantenimiento(ByRef indice As Short)
        Dim J As Short
        Dim spos As Short
        Dim SQL As String
        Dim aparam(3) As Object
        Dim aform(1) As Object
        Dim reporte As String
        On Error GoTo x
        SSTab1.TabPages.Item(1).Enabled = True

        Dim rs As ADODB.Recordset
        Select Case indice
            Case 0 'nuevo
                SSTab1.SelectedIndex = 1
                SSTab1.TabPages.Item(2).Enabled = False
                Call LimpiarValores()
                Call ModoNormal()
                Toolbar1.Visible = False
                TreeView1.Enabled = False
                modoinsert = True
                FLAGDISTRIBUCION = False

            Case 1 'modificar
                If TDBGrid1.Row < 0 Then
                    Exit Sub
                End If
                Call EditarValores()
                modoedit = True
                SSTab1.SelectedIndex = 1
                Toolbar1.Visible = False
                TreeView1.Enabled = False
                i_filaorigen = TDBGrid1.Row
                'UPGRADE_NOTE: Enabled se actualizó a CtlEnabled. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                txt(0).CtlEnabled = False
                cAcepta.Enabled = False
                FLAGDISTRIBUCION = False

            Case 2 'eliminar
                If MsgBox("Desea eliminar el registro?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "AVISO") = MsgBoxResult.Yes Then
                    rs = New ADODB.Recordset
                    SQL = "Select isnull(count(*),0) from ct_cuenta where empresacodigo='" & VGParametros.empresacodigo & "' and cuentacodigo like '" & Trim(TDBGrid1.Columns(0).Value) & "%'"
                    rs = VGCNx.Execute(SQL)
                    If rs.Fields(0).Value > 1 Then
                        MsgBox("La Cuenta a Eliminar tiene Cuentas Dependientes al Nivel Inferior" & Chr(10) & Chr(13) & "Deben Eliminarse primero las Cuentas de Nivel Inferior", MsgBoxStyle.Information, Text)
                        Exit Sub
                    End If
                    SQL = "DELETE FROM CT_CUENTA WHERE empresacodigo='" & VGParametros.empresacodigo & "' and cuentacodigo = '" & Trim(TDBGrid1.Columns(0).Value) & "'"
                    VGCNx.Execute(SQL)
                    Call MuestraDatos(Trim(TDBGrid1.Columns(0).Value))
                End If

            Case 3 'Imprimir
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aparam(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                aparam(0) = VGCNx.DefaultDatabase
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aparam(1). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                aparam(1) = VGParametros.empresacodigo
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aparam(2). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                aparam(2) = "%%"
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aform(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                aform(0) = "@Emp='" & VGParametros.NomEmpresa & "'"
                reporte = "ct_PlanCuentas.rpt"
                Call ImpresionRptProc(reporte, aform, aparam, , "Plan de cuentas")

            Case 4 ' salir
                Me.Close()
        End Select
        Exit Sub

x:
        If indice = 2 And Err.Number = -2147217873 Then
            MsgBox("Registro no podrá Eliminarse mientras exista Información en las Tablas Relacionadas", MsgBoxStyle.Information, Text)
        Else
            MsgBox("Error inesperado: " & Err.Description & "  " & Err.Number, MsgBoxStyle.Information, Text)
        End If
    End Sub

    Private Sub txt_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txt.Change
        Dim Index As Short = txt.GetIndex(eventSender)
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto xdllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        cAcepta.Enabled = IIf(xdllgen.ESNULO((lblNivel.Text), 0) = VGnumnivelescuenta, ValidarCuentaUltimoNivel(), ValidarCuentaNivel())
    End Sub

    Private Sub txt_KeyPressEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTextFer.__TxFer_KeyPressEvent) Handles txt.KeyPressEvent
        Dim Index As Short = txt.GetIndex(eventSender)
        'UPGRADE_ISSUE: CommandButton propiedad cAcepta.Value no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        If eventArgs.keyAscii = 13 And Index = 6 Then
            cAcepta.Focus()
            Call cAcepta_Click(cAcepta, New System.EventArgs())
        End If
    End Sub

    Private Sub txt_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txt.Leave
        Dim Index As Short = txt.GetIndex(eventSender)
        Dim I As Short
        Dim sw As Boolean
        'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        txt(Index).CtlText = UCase(txt(Index).CtlText)
        If modoinsert = True And Index = 0 Then
            For I = 1 To VGnumnivelescuenta
                If I > 1 Then
                    'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                    sw = VG_aNIVELES(I - 1) >= Len(Trim(txt(0).CtlText)) And VG_aNIVELES(I - 2) < Len(Trim(txt(0).CtlText))
                Else
                    'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                    sw = VG_aNIVELES(I - 1) = Len(Trim(txt(0).CtlText))
                End If
                If sw Then
                    lblNivel.Text = CStr(I)
                    Call ConfiguraModoEdicion()
                    cboTipoAjuste.SelectedIndex = 0

                    If I = 1 And UBound(VG_aNIVELES) > 1 Then
                        'UPGRADE_NOTE: Enabled se actualizó a CtlEnabled. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                        Ctr_Ayuda4.CtlEnabled = True
                    Else
                        'UPGRADE_NOTE: Enabled se actualizó a CtlEnabled. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                        Ctr_Ayuda4.CtlEnabled = False
                        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto DevuelveTipoCuenta(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        Ctr_Ayuda4.xclave = DevuelveTipoCuenta() : Ctr_Ayuda4.Ejecutar()
                    End If

                    Exit For
                Else
                    lblNivel.Text = CStr(Nothing)
                    Ctr_Ayuda4.xclave = CStr(Nothing) : Ctr_Ayuda4.Ejecutar()
                End If
            Next
        End If

        If Index = 1 Then Call ConfiguraModoEdicion()

    End Sub

    Private Sub Ctr_Ayuda4_AlDevolverDato(ByVal eventSender As System.Object, ByVal eventArgs As Axctrlayuda_f.__Ctr_Ayuda_AlDevolverDatoEvent) Handles Ctr_Ayuda4.AlDevolverDato
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto xdllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        cAcepta.Enabled = IIf(xdllgen.ESNULO((lblNivel.Text), 0) = VGnumnivelescuenta, ValidarCuentaUltimoNivel(), ValidarCuentaNivel())
    End Sub

    'UPGRADE_WARNING: El evento cboTipoAjuste.SelectedIndexChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cboTipoAjuste_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboTipoAjuste.SelectedIndexChanged
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto xdllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        cAcepta.Enabled = IIf(xdllgen.ESNULO((lblNivel.Text), 0) = VGnumnivelescuenta, ValidarCuentaUltimoNivel(), ValidarCuentaNivel())
    End Sub

    Function ValidarCuentaUltimoNivel() As Boolean
        Dim I As Short
        For I = 0 To 1
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
            If IsNothing(txt(I).CtlText) Then
                ValidarCuentaUltimoNivel = False
                Exit Function
            End If
        Next

        ValidarCuentaUltimoNivel = True
    End Function

    Function ValidarCuentaNivel() As Boolean
        Dim I As Short
        For I = 0 To 6
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
            If IsNothing(txt(I).CtlText) Then
                ValidarCuentaNivel = False
                Exit Function
            End If
        Next

        ValidarCuentaNivel = True
    End Function

    Sub ModoEdicion(ByRef flagULTIMONIVEL As Boolean) 'True: Ultimo Nivel  False:Otros Niveles
        Dim I As Short
        For I = 0 To 1
            'UPGRADE_NOTE: Enabled se actualizó a CtlEnabled. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            txt(I).CtlEnabled = True
        Next
        For I = 2 To 6
            'UPGRADE_NOTE: BackColor se actualizó a CtlBackColor. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            txt(I).CtlBackColor = System.Drawing.ColorTranslator.FromOle(IIf(flagULTIMONIVEL = True, ColorHabilitado, ColorDesHabilitado))
            'UPGRADE_NOTE: Enabled se actualizó a CtlEnabled. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            txt(I).CtlEnabled = Not flagULTIMONIVEL
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            txt(I).CtlText = 0
        Next
        For I = 0 To 3
            chk(I).Enabled = flagULTIMONIVEL
        Next
        cmdDistribucion.Visible = flagULTIMONIVEL
        'UPGRADE_NOTE: Enabled se actualizó a CtlEnabled. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        Ctr_Ayuda1.CtlEnabled = flagULTIMONIVEL
        cboTipoAjuste.Enabled = flagULTIMONIVEL

    End Sub

    Sub ModoNormal()
        Dim I As Short
        For I = 0 To 1
            'UPGRADE_NOTE: Enabled se actualizó a CtlEnabled. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            txt(I).CtlEnabled = True
        Next
        For I = 2 To 6
            'UPGRADE_NOTE: Enabled se actualizó a CtlEnabled. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            txt(I).CtlEnabled = True
        Next
        For I = 0 To 4
            chk(I).Enabled = True
        Next
        'UPGRADE_NOTE: Enabled se actualizó a CtlEnabled. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        Ctr_Ayuda1.CtlEnabled = True
        'UPGRADE_NOTE: Enabled se actualizó a CtlEnabled. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        Ctr_Ayuda4.CtlEnabled = True
        cboTipoAjuste.Enabled = True

    End Sub

    Function GrabarPlanCuenta(ByRef tipooperacion As Short, ByRef xCod As String, ByRef xDes As String, ByRef xLinAct As Double, ByRef xLinPas As Double, ByRef xLinEgp As Double, ByRef xNatu As String, ByRef xNatuegp As String, ByRef xCtaCostos As Short, ByRef xCtaAnalitico As Short, ByRef xCtaDoc As Short, ByRef xCtaNivel As Short, ByRef xTipoAnalitico As String, ByRef xCtaDist As Short, ByRef xTipoCuenta As String, ByRef xTipoAJuste As String, ByRef xAdicionaCargo As String) As String
        Dim strSQL As String

        'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        'UPGRADE_WARNING: Se detectó el uso de Null/IsNull(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
        xTipoAnalitico = IIf(IsDBNull(xTipoAnalitico) Or IsNothing(xTipoAnalitico), "00", xTipoAnalitico)
        Select Case tipooperacion
            Case 0
                strSQL = "INSERT INTO ct_cuenta (empresacodigo,cuentacodigo, cuentadescripcion, cuentalineaactivo,cuentalineapasivo, cuentalineaegp, cuentanatu, cuentanategp,"
                strSQL = strSQL & "cuentaestadoccostos, cuentaestadoanalitico,cuentadocumento, cuentanivel, tipoanaliticocodigo,cuentaestadodistribucion,tipocuentacodigo,usuariocodigo, fechaact, CUENTAGRUPO,tipoajuste,cuentaestado,cuentaadicionacargo) "
                strSQL = strSQL & " VALUES ('" & VGParametros.empresacodigo & "','" & xCod & "','" & xDes & "'," & xLinAct & "," & xLinPas & "," & xLinEgp & ",'" & xNatu & "','" & xNatuegp & "'," & xCtaCostos & "," & xCtaAnalitico & "," & xCtaDoc & "," & xCtaNivel & ",'" & xTipoAnalitico & "'," & xCtaDist & ",'" & xTipoCuenta & "','" & VGUsuario & "','" & VB6.Format(Now, "dd/mm/yyyy") & "','01','" & xTipoAJuste & "','1','" & xAdicionaCargo & "')"

            Case 1
                strSQL = "UPDATE CT_CUENTA SET "
                strSQL = strSQL & "cuentadescripcion='" & xDes & "',"
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto xdllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                strSQL = strSQL & "cuentalineaactivo=" & xdllgen.ESNULO(xLinAct, 0) & ","
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto xdllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                strSQL = strSQL & "cuentalineapasivo=" & xdllgen.ESNULO(xLinPas, 0) & ","
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto xdllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                strSQL = strSQL & "cuentalineaegp=" & xdllgen.ESNULO(xLinEgp, 0) & ","
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto xdllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                strSQL = strSQL & "cuentanatu='" & xdllgen.ESNULO(xNatu, "") & "',"
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto xdllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                strSQL = strSQL & "cuentanategp='" & xdllgen.ESNULO(xNatuegp, "") & "',"
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto xdllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                strSQL = strSQL & "cuentaestadoccostos=" & xdllgen.ESNULO(xCtaCostos, 0) & ","
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto xdllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                strSQL = strSQL & "cuentaestadoanalitico=" & xdllgen.ESNULO(xCtaAnalitico, 0) & ","
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto xdllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                strSQL = strSQL & "cuentadocumento=" & xdllgen.ESNULO(xCtaDoc, 0) & ","
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto xdllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                strSQL = strSQL & "cuentanivel=" & xdllgen.ESNULO(xCtaNivel, 0) & ","
                strSQL = strSQL & "tipoanaliticocodigo='" & xTipoAnalitico & "',"
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto xdllgen.ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                strSQL = strSQL & "cuentaestadodistribucion=" & xdllgen.ESNULO(xCtaDist, 0) & ","
                strSQL = strSQL & "tipocuentacodigo='" & xTipoCuenta & "',"
                strSQL = strSQL & "usuariocodigo='" & VGUsuario & "',"
                strSQL = strSQL & "fechaact='" & VB6.Format(Now, "dd/mm/yyyy") & "',"
                strSQL = strSQL & "cuentagrupo='01',"
                strSQL = strSQL & "tipoajuste='" & xTipoAJuste & "', "
                strSQL = strSQL & "cuentaadicionacargo='" & xAdicionaCargo & "' "
                strSQL = strSQL & "WHERE empresacodigo='" & VGParametros.empresacodigo & "' and cuentacodigo='" & xCod & "'"

        End Select
        GrabarPlanCuenta = strSQL

    End Function

    Function GrabarCuentaDistribucion() As Object
        Dim I As Integer
        Dim SQL As String

        If rsDist.RecordCount > 0 Then
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            SQL = "DELETE FROM ct_distribucion WHERE empresacodigo='" & VGParametros.empresacodigo & "' and cuentacodigo='" & txt(0).CtlText & "'"
            VGCNx.Execute(SQL)
            rsDist.MoveFirst()
            For I = 0 To rsDist.RecordCount - 1
                SQL = "INSERT ct_distribucion (empresacodigo,cuentacodigo,distribucioncargo,distribucionabono,distribucionporcen,usuariocodigo,fechaact) VALUES "
                SQL = SQL & "('" & VGParametros.empresacodigo & "','" & rsDist.Fields(0).Value & "','" & rsDist.Fields(1).Value & "','" & rsDist.Fields(2).Value & "'," & rsDist.Fields(3).Value & ",'" & VGUsuario & "','" & Today & "')"
                VGCNx.Execute(SQL)
                rsDist.MoveNext()
            Next
        End If

    End Function

    Function GrabarTablaSaldos() As Object
        Dim SQL As String
        Dim NombreTabla As String
        NombreTabla = "CT_SALDOS" & VGParamSistem.Anoproceso
        SQL = "INSERT " & NombreTabla & "(empresacodigo,cuentacodigo,usuariocodigo,fechaact)"
        'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        SQL = SQL & "VALUES ('" & VGParametros.empresacodigo & "','" & txt(0).CtlText & "','" & VGUsuario & "','" & Today & "')"
        VGCNx.Execute(SQL)

    End Function

    Private Sub cmdSigue_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSigue.Click
        If rsDist.RecordCount > 0 And CDbl(lblPorcen.Text) <> 100 Then
            MsgBox("El Total de % Distribución no se ha completado al 100%", MsgBoxStyle.Information, Text)
        Else
            cAcepta.Enabled = IIf(rsDist.RecordCount > 0 And FLAGMOVIMIENTODISTRI = True, True, False)
            chk(3).CheckState = IIf(rsDist.RecordCount > 0, 1, 0)
            SSTab1.SelectedIndex = 1
            SSTab1.TabPages.Item(1).Enabled = True
        End If

    End Sub

    Private Sub cmdDistribucion_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDistribucion.Click
        SSTab1.TabPages.Item(2).Enabled = True
        SSTab1.SelectedIndex = 2
        FLAGMOVIMIENTODISTRI = False
        Call LlenarPorcentajes()
    End Sub

    Sub LlenarPorcentajes()
        'UPGRADE_NOTE: El objeto rsDist no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsDist = Nothing
        Call IniciaGridDist()
        Call CargaGridDist()
        Call ConfigGridDist()
        FLAGDISTRIBUCION = True
    End Sub

    Private Function IniciaGridDist() As Object
        Call rsDist.Fields.Append("Cuenta", ADODB.DataTypeEnum.adVarChar, 20)
        Call rsDist.Fields.Append("Cuenta Cargo", ADODB.DataTypeEnum.adVarChar, 20)
        Call rsDist.Fields.Append("Cuenta Abono", ADODB.DataTypeEnum.adVarChar, 20)
        Call rsDist.Fields.Append("Porcentaje", ADODB.DataTypeEnum.adDouble)
        Call rsDist.Fields.Append("Item", ADODB.DataTypeEnum.adInteger)
        rsDist.Open()
    End Function

    Private Sub CargaGridDist()
        Dim xRs As ADODB.Recordset
        Dim nConta As Integer
        Dim SQL As String
        xRs = New ADODB.Recordset
        SQL = "SELECT cuentacodigo,distribucioncargo,distribucionabono,distribucionporcen "
        'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        SQL = SQL & "FROM ct_distribucion WHERE empresacodigo='" & VGParametros.empresacodigo & "' and cuentacodigo='" & txt(0).CtlText & "'"
        xRs = VGCNx.Execute(SQL)
        nConta = 1
        If xRs.RecordCount > 0 Then
            xRs.MoveFirst()
            Do While Not xRs.EOF
                rsDist.AddNew()
                rsDist.Fields(0).Value = xRs.Fields(0).Value
                rsDist.Fields(1).Value = xRs.Fields(1).Value
                rsDist.Fields(2).Value = xRs.Fields(2).Value
                rsDist.Fields(3).Value = xRs.Fields(3).Value
                rsDist.Fields(4).Value = nConta
                nConta = nConta + 1
                rsDist.Update()
                xRs.MoveNext()
            Loop
        End If
        'UPGRADE_NOTE: El objeto xRs no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        xRs = Nothing
    End Sub

    Private Function ConfigGridDist() As Object
        Dim I As Short
        TDBGrid2.DataSource = rsDist
        With TDBGrid2
            For I = 0 To 4
                .Columns(I).AllowSizing = False
            Next
            .Columns(0).Visible = False
            .Columns(0).Caption = "Cuenta"
            .Columns(1).Width = 1700
            .Columns(1).Caption = "Cuenta Cargo"
            .Columns(2).Width = 1700
            .Columns(2).Caption = "Cuenta Abono"
            .Columns(3).Width = 1900
            .Columns(3).Caption = "Distribución(%)"
            .Columns(4).Width = 800
            .Columns(4).Caption = "Item"
        End With
        lblPorcen.Text = CStr(DevuelveTotPor())
        'UPGRADE_NOTE: Refresh se actualizó a CtlRefresh. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        TDBGrid2.Refresh()
    End Function
	
	Private Function ActualizaGridDist() As Object
		Dim nReg As Integer
		nReg = DevuelveNumReg() + 1
		With rsDist
			.AddNew()
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			.Fields(0).Value = txt(0).CtlText
			.Fields(1).Value = Ctr_Ayuda2.xclave
			.Fields(2).Value = Ctr_Ayuda3.xclave
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			.Fields(3).Value = CDbl(txtPorcen.CtlText)
			.Fields(4).Value = CInt(nReg)
			.Update()
		End With
	End Function
	
	Private Sub txtbuscarcuenta_KeyPress(ByRef KeyAscii As Short)
		If KeyAscii = 13 Then
			Call cmdBuscar_Click(cmdBuscar, New System.EventArgs())
		End If
	End Sub
	
	
	Private Sub txtPorcen_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPorcen.Change
		'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		If Not IsNothing(Ctr_Ayuda2.xclave) And Not IsNothing(Ctr_Ayuda3.xclave) Then
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			If Not IsNothing(txtPorcen.CtlText) Then
				cmdAceptar.Enabled = True
				Exit Sub
			End If
		End If
		cmdAceptar.Enabled = False
	End Sub
	
	Function ValidarGridDist() As Boolean
		
		'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		If DevuelveTotPor() + Val(txtPorcen.CtlText) > 100 Then
			MsgBox("La Sumatoria de Porcentaje excede al 100%", MsgBoxStyle.Information, Text)
			txtPorcen.Focus()
			System.Windows.Forms.SendKeys.Send("{HOME}+{END}")
			ValidarGridDist = False
			Exit Function
		End If
		
		'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		If Val(txtPorcen.CtlText) = 0 Then
			MsgBox("Valor de Porcentaje  no permitido", MsgBoxStyle.Information, Text)
			txtPorcen.Focus()
			System.Windows.Forms.SendKeys.Send("{HOME}+{END}")
			ValidarGridDist = False
			Exit Function
		End If
		
		ValidarGridDist = True
	End Function
	
	Function DevuelveTotPor() As Double
		Dim I As Short
		Dim nSum As Double
		nSum = 0
		If rsDist.RecordCount > 0 Then
			rsDist.MoveFirst()
			Do While Not rsDist.EOF
				nSum = nSum + rsDist.Fields(3).Value
				rsDist.MoveNext()
			Loop 
		End If
		DevuelveTotPor = CDbl(VB6.Format(nSum, "###0.#0"))
	End Function
	
	Private Sub TDBGrid2_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TDBGrid2.ClickEvent
		TDBGrid2.Focus()
	End Sub
	
	Private Sub TDBGrid2_KeyDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueOleDBGrid70.TrueDBGridEvents_KeyDownEvent) Handles TDBGrid2.KeyDownEvent
		Dim nvalor As String
		If rsDist.RecordCount > 0 Then
			If eventArgs.KeyCode = 46 Then
				nvalor = TDBGrid2.Columns(4).Text
				If rsDist.RecordCount > 0 Then
					rsDist.MoveFirst()
					Do Until rsDist.EOF
						If rsDist.Fields(4).Value = nvalor Then
							rsDist.Delete(ADODB.AffectEnum.adAffectCurrent)
							rsDist.Update()
							Exit Do
						End If
						rsDist.MoveNext()
					Loop 
					ConfigGridDist()
					lblPorcen.Text = CStr(DevuelveTotPor)
				End If
			End If
		End If
	End Sub
	
	Function DevuelveNumReg() As Integer
		Dim nUlt As Integer
		If rsDist.RecordCount > 0 Then
			rsDist.MoveFirst()
			Do While Not rsDist.EOF
				nUlt = rsDist.Fields(4).Value
				rsDist.MoveNext()
			Loop 
			DevuelveNumReg = nUlt
		Else
			DevuelveNumReg = 0
		End If
	End Function
	
	Private Sub Arbol(ByRef xCta As String)
		On Error GoTo xx
		Dim rs As ADODB.Recordset
		Dim SQL As String
		Dim CodCan As String
		Dim I As Integer
		Dim k As Short
		Dim nodX As System.Windows.Forms.TreeNode
		
		VGvardllgen = New dllgeneral.dll_general
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		xCta = ESNULO(xCta, "%")
		
		SQL = "SELECT A.cuentacodigo,A.cuentadescripcion, A.cuentanivel FROM CT_CUENTA A "
		SQL = SQL & "WHERE empresacodigo='" & VGParametros.empresacodigo & "' and cuentacodigo<>'00' and A.cuentacodigo like '" & xCta & "%' "
		SQL = SQL & "ORDER BY 1"
		rs = New ADODB.Recordset
		rs = VGCNx.Execute(SQL)
		
		If (rs.EOF Or rs.BOF) Then
			Exit Sub
		End If
		TreeView1.Nodes.Clear()
		nodX = TreeView1.Nodes.Add("P", "Plan de Cuentas", 1)
		nodX.EnsureVisible()
		
		For I = 1 To rs.RecordCount
			cCta = "P" & Trim(rs.Fields(0).Value)
			If rs.Fields(2).Value > 1 Then
				'UPGRADE_WARNING: El comportamiento del método Add ha cambiado Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DBD08912-7C17-401D-9BE9-BA85E7772B99"'
				nodX = TreeView1.Nodes.Find("P" & Trim(Mid(cCta, 2, VG_aNIVELES(rs.Fields(2).Value - 2))), True)(0).Nodes.Add(cCta, rs.Fields(0).Value, 1)
			Else
				'UPGRADE_WARNING: El comportamiento del método Add ha cambiado Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DBD08912-7C17-401D-9BE9-BA85E7772B99"'
				nodX = TreeView1.Nodes.Find("P", True)(0).Nodes.Add(cCta, rs.Fields(0).Value, 1)
				nodX.EnsureVisible()
			End If
			rs.MoveNext()
		Next I
		rs.MoveFirst()
		Exit Sub
xx: 
		'MsgBox "Error de Inconsistencia en Base de Datos: " & "No existe Plan de Cuentas superior para la Cuenta " & rs(0) & " - " & rs(1), vbInformation, Caption
		l_error = l_error & "No existe Cuenta superior para la Cuenta " & rs.Fields(0).Value & " - " & rs.Fields(1).Value & Chr(13)
		Resume Next
	End Sub
	
	Private Sub TREEVIEW1_AfterExpand(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.TreeViewEventArgs) Handles TREEVIEW1.AfterExpand
		Dim NODE As System.Windows.Forms.TreeNode = eventArgs.Node
		NODE.ImageIndex = 2
	End Sub
	
	Private Sub TREEVIEW1_AfterCollapse(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.TreeViewEventArgs) Handles TREEVIEW1.AfterCollapse
		Dim NODE As System.Windows.Forms.TreeNode = eventArgs.Node
		NODE.ImageIndex = 1
	End Sub
	
	Private Sub TreeView1_NodeClick(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
		Dim NODE As System.Windows.Forms.TreeNode = eventArgs.Node
		'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		If Not IsNothing(NODE.Name) Then
			xcuenta = VB.Right(Trim(NODE.Name), Len(Trim(NODE.Name)) - 1)
			MuestraDatos(VB.Right(Trim(NODE.Name), Len(Trim(NODE.Name)) - 1))
		End If
	End Sub
	
	Private Sub cmdAceptar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAceptar.Click
		If ValidarGridDist = True Then
			Call ActualizaGridDist()
			Call ConfigGridDist()
			Ctr_Ayuda2.xclave = CStr(Nothing)
			Ctr_Ayuda3.xclave = CStr(Nothing)
			Ctr_Ayuda2.xnombre = CStr(Nothing)
			Ctr_Ayuda3.xnombre = CStr(Nothing)
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			txtPorcen.CtlText = Nothing
			FLAGMOVIMIENTODISTRI = True
		End If
	End Sub
	
	Function DevuelveTipoCuenta() As Object
		Dim rsX As New ADODB.Recordset
		Dim SQL As String
		
		rsX = New ADODB.Recordset
		'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		SQL = "Select tipocuentacodigo from ct_cuenta where empresacodigo='" & VGParametros.empresacodigo & "' and cuentacodigo=left('" & Trim(txt(0).CtlText) & "',2)"
		rsX = VGCNx.Execute(SQL)
		If rsX.RecordCount > 0 Then
			DevuelveTipoCuenta = rsX.Fields(0).Value
		Else
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto DevuelveTipoCuenta. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			DevuelveTipoCuenta = 0
		End If
		'UPGRADE_NOTE: El objeto rsX no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsX = Nothing
		
	End Function
	
	Sub GrabaTipoCuenta(ByRef xCta As String, ByRef xValor As String, ByRef xNivel As Short)
		Dim SQL As String
		SQL = "UPDATE ct_cuenta SET tipocuentacodigo='" & xValor & "' "
		SQL = SQL & "WHERE empresacodigo='" & VGParametros.empresacodigo & "' and left(cuentacodigo,2)='" & xCta & "' AND cuentanivel>" & xNivel
		VGCNx.Execute(SQL)
	End Sub
End Class