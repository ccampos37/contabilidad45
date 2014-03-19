Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports Microsoft.VisualBasic.PowerPacks
Friend Class frmMant_CtaCteAnalitico
	Inherits System.Windows.Forms.Form
	Dim modoinsert As Boolean
	Dim modoedit As Boolean
	Dim ClsMM1 As ClsMantMov1
	Dim rs As New ADODB.Recordset
	
	Private Sub Ctr_Analitico_AlDevolverDato(ByVal eventSender As System.Object, ByVal eventArgs As Axctrlayuda_f.__Ctr_Ayuda_AlDevolverDatoEvent) Handles Ctr_Analitico.AlDevolverDato
		Dim dato As String
		If Ctr_CtaCtble.xclave <> "" Then
			dato = "empresacodigo='" & VGParametros.empresacodigo & "' and cuentacodigo='" & Ctr_CtaCtble.xclave & "'and year(ctacteanaliticofechaconta) < " & VGParamSistem.Anoproceso & ""
			dato = dato & " and analiticocodigo='" & Ctr_Analitico.xclave & "'"
			Mostrar((dato))
		End If
	End Sub
	
	Private Sub Ctr_CtaCtble_AlDevolverDato(ByVal eventSender As System.Object, ByVal eventArgs As Axctrlayuda_f.__Ctr_Ayuda_AlDevolverDatoEvent) Handles Ctr_CtaCtble.AlDevolverDato
		Dim dato As String
		dato = "empresacodigo='" & VGParametros.empresacodigo & "' and cuentacodigo='" & Ctr_CtaCtble.xclave & "'and year(ctacteanaliticofechaconta) < " & VGParamSistem.Anoproceso & ""
		
		Mostrar((dato))
		
	End Sub
	
	Private Sub frmMant_CtaCteAnalitico_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Ctr_CtaCtble.Conexion(VGCNx)
		Ctr_CtaCtble.Filtro = " cuentanivel=" & VGnumnivelescuenta & " and cuentaestadoanalitico=1 and empresacodigo='" & VGParametros.empresacodigo & "'"
		Ctr_Analitico.Conexion(VGCNx)
		CtrAy_Asiento.Conexion(VGCNx)
		CtrAyu_Moneda.Conexion(VGCNx)
		CtrAyu_Opera.Conexion(VGCNx)
		CtrAyu_TipAnal.Conexion(VGCNx)
		CtrAyu_TipDoc.Conexion(VGCNx)
		SSTab1.SelectedIndex = 0
		SSTab1.TabPages.Item(1).Enabled = False
		framebotones.Visible = False
	End Sub
	
	Private Sub cmdBotones_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBotones.Click
		Dim Index As Short = cmdBotones.GetIndex(eventSender)
		Select Case Index
			Case 0
				Call Limpiar()
				modoedit = False
				modoinsert = True
				SSTab1.TabPages.Item(1).Enabled = True
				SSTab1.SelectedIndex = 1
				
			Case 1
				If TDBG_CtaCte.Row < 0 Then
					Exit Sub
				End If
				modoedit = True
				SSTab1.TabPages.Item(1).Enabled = True
				SSTab1.SelectedIndex = 1
				Call Edicion()
				
			Case 2
				Call eliminar()
				
			Case 3
				'Impresion
				
			Case 4 : Me.Close()
				
		End Select
		
	End Sub
	Sub eliminar()
		Dim rssql As New ADODB.Recordset
		SQL = "delete from  dbo.ct_ctacteanalitico" & VGParamSistem.Anoproceso & " where "
		SQL = SQL & " empresacodigo='" & VGParametros.empresacodigo & "'"
		SQL = SQL & " and cuentacodigo+asientocodigo+subasientocodigo='" & rs.Fields("cuentacodigo").Value & rs.Fields("asientocodigo").Value & rs.Fields("subasientocodigo").Value & "'"
		SQL = SQL & " and analiticocodigo='" & rs.Fields("analiticocodigo").Value & "'"
		SQL = SQL & " and documentocodigo+ctacteanaliticonumdocumento='" & rs.Fields("documentocodigo").Value & rs.Fields("ctacteanaliticonumdocumento").Value & "'"
		SQL = SQL & " and cabcomprobmes=0 "
		rssql = VGCNx.Execute(SQL)
		If modoedit = False Then Call Ctr_Analitico.Ejecutar()
	End Sub
	Sub Limpiar()
		CtrAy_Asiento.xclave = CStr(Nothing) : CtrAy_Asiento.Ejecutar()
		CtrAyu_Moneda.xclave = CStr(Nothing) : CtrAyu_Moneda.Ejecutar()
		CtrAyu_Opera.xclave = CStr(Nothing) : CtrAyu_Opera.Ejecutar()
		CtrAyu_TipAnal.xclave = CStr(Nothing) : CtrAyu_TipAnal.Ejecutar()
		CtrAyu_TipDoc.xclave = CStr(Nothing) : CtrAyu_TipDoc.Ejecutar()
		'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		TxGlosa.CtlText = Nothing
		'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		TxMonto.CtlText = Nothing
		'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		TxSerie.CtlText = Nothing
		'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		TxNdoc.CtlText = Nothing
	End Sub
	
	Sub Edicion()
		Dim i As Short
		'cabcomprobmes , detcomprobitem, cabcomprobnumero, subasientocodigo, asientocodigo, documentocodigo, operacioncodigo, cuentacodigo, ""
		'SQL = SQL & "ctacteanaliticofechaconta, analiticocodigo, ctacteanaliticonumdocumento, ctacteanaliticofechadoc, ctacteanaliticoglosa, ctacteanaliticodebe,"
		'SQL = SQL & "ctacteanaliticoussdebe, ctacteanaliticohaber, ctacteanaliticousshaber, ctacteanaliticocancel, ctacteanaliticofechaven,monedacodigo,ctacteanaliticosaldo "
		
		If rs.RecordCount > 0 Then
			With rs
				lblNroComprobante.Text = .Fields("cabcomprobnumero").Value
				CtrAyu_Opera.xclave = .Fields("operacioncodigo").Value : CtrAyu_Opera.Ejecutar()
				Ctr_CtaCtble.xclave = .Fields("cuentacodigo").Value : Ctr_CtaCtble.Ejecutar()
				CtrAy_Asiento.xclave = .Fields("asientocodigo").Value : CtrAy_Asiento.Ejecutar()
				CtrAyu_TipAnal.xclave = VB.Right(Trim(.Fields("analiticocodigo").Value), 3) : CtrAyu_TipAnal.Ejecutar()
				Ctr_Analitico.xclave = .Fields("analiticocodigo").Value : Ctr_Analitico.Ejecutar()
				CtrAyu_TipDoc.xclave = .Fields("documentocodigo").Value : CtrAyu_TipDoc.Ejecutar()
				'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
				TxSerie.CtlText = VB.Left(Trim(.Fields("ctacteanaliticonumdocumento").Value), 4)
				'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
				TxNdoc.CtlText = VB.Right(.Fields("ctacteanaliticonumdocumento").Value, Len(.Fields("ctacteanaliticonumdocumento").Value) - 4)
				Dtp_FechaDoc.Value = VB6.Format(.Fields("ctacteanaliticofechadoc").Value, "dd/mm/yyyy")
				DtpFech_Ven.Value = VB6.Format(.Fields("ctacteanaliticofechaven").Value, "dd/mm/yyyy")
				'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
				TxGlosa.CtlText = .Fields("ctacteanaliticoglosa").Value
				CtrAyu_Moneda.xclave = .Fields("monedacodigo").Value : CtrAyu_Moneda.Ejecutar()
				If .Fields("ctacteanaliticodebe").Value > 0 Then
					CmbID.SelectedIndex = 0
					'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
					TxMonto.CtlText = System.Math.Round(.Fields("ctacteanaliticodebe").Value, 2)
					lb_vcambio.Text = CStr(System.Math.Round(.Fields("ctacteanaliticodebe").Value / .Fields("ctacteanaliticoussdebe").Value, 4))
				Else
					CmbID.SelectedIndex = 1
					'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
					TxMonto.CtlText = System.Math.Round(.Fields("ctacteanaliticohaber").Value, 2)
					lb_vcambio.Text = CStr(System.Math.Round(.Fields("ctacteanaliticohaber").Value / .Fields("ctacteanaliticousshaber").Value, 4))
				End If
			End With
		End If
		
	End Sub
	
	Private Sub cmdVisualizar_Click()
		Dim SQL As String
		
		SQL = "Select cabcomprobmes, detcomprobitem, cabcomprobnumero, subasientocodigo, asientocodigo, documentocodigo, operacioncodigo, cuentacodigo,"
		SQL = SQL & "ctacteanaliticofechaconta, analiticocodigo, ctacteanaliticonumdocumento, ctacteanaliticofechadoc, ctacteanaliticoglosa, ctacteanaliticodebe,"
		SQL = SQL & "ctacteanaliticoussdebe, ctacteanaliticohaber, ctacteanaliticousshaber, ctacteanaliticocancel, ctacteanaliticofechaven,monedacodigo,ctacteanaliticosaldo "
		SQL = SQL & "from  dbo.ct_ctacteanalitico" & VGParamSistem.Anoproceso & " where ctacteanaliticosaldo='" & (CDbl(VGParamSistem.Anoproceso) - 1) & "' AND "
		SQL = SQL & "cuentacodigo like '" & Trim(Ctr_CtaCtble.xclave) & "%' and "
		SQL = SQL & "analiticocodigo like '" & Trim(Ctr_Analitico.xclave) & "%'"
		
		rs = New ADODB.Recordset
		rs = VGCNx.Execute(SQL)
		
		TDBG_CtaCte.DataSource = rs
		
	End Sub
	
	Sub GrabarCtacteAnalitico()
		On Error GoTo xx
		'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		VGCNx.BeginTrans()
		VGCommandoSP = New ADODB.Command
		VGCommandoSP.let_ActiveConnection(VGGeneral)
		VGCommandoSP.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
		VGCommandoSP.CommandText = "ct_IngresaCtacteAnalitico_pro"
		VGCommandoSP.Parameters.Refresh()
		With VGCommandoSP
			.Parameters("@base").Value = VGParamSistem.BDEmpresa
			.Parameters("@tabla").Value = "ct_ctacteanalitico" & VGParamSistem.Anoproceso
			.Parameters("@empresa").Value = VGParametros.empresacodigo
			.Parameters("@op").Value = 1
			.Parameters("@cabcomprobmes").Value = 0
			.Parameters("@cabcomprobnumero").Value = 0
			.Parameters("@subasientocodigo").Value = "0001"
			.Parameters("@asientocodigo").Value = Trim(CtrAy_Asiento.xclave)
			.Parameters("@detcomprobitem").Value = 0
			.Parameters("@analiticocodigo").Value = Trim(Ctr_Analitico.xclave)
			.Parameters("@monedacodigo").Value = Trim(CtrAyu_Moneda.xclave)
			.Parameters("@documentocodigo").Value = Trim(CtrAyu_TipDoc.xclave)
			.Parameters("@operacioncodigo").Value = Trim(CtrAyu_Opera.xclave)
			.Parameters("@cuentacodigo").Value = Trim(Ctr_CtaCtble.xclave)
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			.Parameters("@detcomprobnumdocumento").Value = VB6.Format(Trim(TxSerie.CtlText), "0000") & VB6.Format(Trim(TxNdoc.CtlText), "0000000000")
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Dtp_FechaDoc.Value. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@detcomprobfechaemision").Value = Dtp_FechaDoc.Value
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto DtpFech_Ven.Value. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@detcomprobfechavencimiento").Value = DtpFech_Ven.Value
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Dtp_FechaDoc.Value. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@ctacteanaliticofechacontable").Value = Dtp_FechaDoc.Value
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			.Parameters("@detcomprobglosa").Value = Trim(TxGlosa.CtlText)
			If CmbID.SelectedIndex = 0 Then
				'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
				.Parameters("@detcomprobdebe").Value = IIf(Trim(CtrAyu_Moneda.xclave) = "01", TxMonto.CtlText, CDbl(TxMonto.CtlText) * CDbl(lb_vcambio.Text))
				'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
				.Parameters("@detcomprobussdebe").Value = IIf(Trim(CtrAyu_Moneda.xclave) = "02", TxMonto.CtlText, CDbl(TxMonto.CtlText) / CDbl(lb_vcambio.Text))
				.Parameters("@detcomprobhaber").Value = 0
				.Parameters("@detcomprobusshaber").Value = 0
			ElseIf CmbID.SelectedIndex > 0 Then 
				'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
				.Parameters("@detcomprobhaber").Value = IIf(Trim(CtrAyu_Moneda.xclave) = "01", TxMonto.CtlText, CDbl(TxMonto.CtlText) * CDbl(lb_vcambio.Text))
				'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
				.Parameters("@detcomprobusshaber").Value = IIf(Trim(CtrAyu_Moneda.xclave) = "02", TxMonto.CtlText, CDbl(TxMonto.CtlText) / CDbl(lb_vcambio.Text))
				.Parameters("@detcomprobdebe").Value = 0
				.Parameters("@detcomprobussdebe").Value = 0
			End If
			.Parameters("@detcomprobtipocambio").Value = lb_vcambio.Text
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Dtp_FechaDoc.Value. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@ctacteanaliticofechacontable").Value = Dtp_FechaDoc.Value
			.Execute()
		End With
		
		VGCNx.CommitTrans()
		Ctr_Analitico.Ejecutar()
		'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
		MsgBox("Se Actualizó Satisfactoriamente la Cuenta Corriente de Apertura del Año " & VGParamSistem.Anoproceso, MsgBoxStyle.Information)
		Exit Sub
xx: 
		'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
		VGCNx.RollbackTrans()
		MsgBox("No se pudo Grabar la Cuenta Corriente " & Chr(13) & Err.Description, MsgBoxStyle.Exclamation)
	End Sub
	
	Function RecuperaTipoCambio(ByRef fecha As String, ByRef tipo As ModificarCampos.tipocambio) As Double
		Dim RSAUX As ADODB.Recordset
		RSAUX = New ADODB.Recordset
		Dim Campo As String
		RecuperaTipoCambio = 0
		Select Case tipo
			Case ModificarCampos.tipocambio.Compra
				Campo = "tipocambiocompra"
			Case ModificarCampos.tipocambio.Venta
				Campo = "tipocambioventa"
			Case ModificarCampos.tipocambio.Promedio
				Campo = "tipocambiopromedio"
			Case Else
				Campo = "tipocambioventa"
		End Select
		RSAUX.Open("Select Valor=isnull(" & Campo & ",0)  from ct_tipocambio where tipocambiofecha ='" & fecha & "'", VGCNx, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
		If RSAUX.RecordCount > 0 Then
			RecuperaTipoCambio = RSAUX.Fields("valor").Value
		End If
	End Function
	
	Private Sub cAcepta_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cAcepta.Click
		If modoedit = True Then Call eliminar()
		Call GrabarCtacteAnalitico()
		modoedit = False
		modoinsert = False
		Ctr_Analitico.Ejecutar()
		SSTab1.SelectedIndex = 0
		SSTab1.TabPages.Item(1).Enabled = False
	End Sub
	
	Private Sub cCancela_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cCancela.Click
		SSTab1.SelectedIndex = 0
	End Sub
	
	'UPGRADE_WARNING: El evento CmbTcambio.SelectedIndexChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub CmbTcambio_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmbTcambio.SelectedIndexChanged
		ClsMM1 = New ClsMantMov1
		VGValorCambio = RecuperaTipoCambio(VB6.Format(Dtp_FechaDoc._Value, "dd/mm/yyyy"), CmbTcambio.SelectedIndex + 1)
		lb_vcambio.Text = VB6.Format(VGValorCambio, "#.000 ")
	End Sub
	
	Private Sub Mostrar(ByRef dato As String)
		Dim RSQL As New ADODB.Recordset
		Dim SQL As String
		SQL = "Select * from ct_ctacteanalitico" & VGParamSistem.Anoproceso & " where " & dato & ""
		rs = VGCNx.Execute(SQL)
		TDBG_CtaCte.DataSource = rs
		'UPGRADE_NOTE: Refresh se actualizó a CtlRefresh. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        TDBG_CtaCte.Refresh()
		If Ctr_CtaCtble.xclave <> "" And Ctr_Analitico.xclave <> "" Then
			framebotones.Visible = True
		Else
			framebotones.Visible = False
		End If
		
	End Sub
End Class