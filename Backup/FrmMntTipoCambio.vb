Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class FrmMntTipoCambio
	Inherits System.Windows.Forms.Form
	
	Dim modoinsert As Boolean
	Dim modoedit As Boolean
	Dim i_filaorigen As Short
	Dim rs As New ADODB.Recordset
	Dim FLAG_CHECK As Boolean
	
	Private Sub FrmMntTipoCambio_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		If IsNumeric(VGParamSistem.AnoProceso) Then
			DTPicker1.MinDate = CDate(VB6.Format("01/" & VGParamSistem.mesproceso & "/" & CShort(VGParamSistem.AnoProceso), "dd/mm/yyyy"))
			DTPicker1.MaxDate = DateAdd(Microsoft.VisualBasic.DateInterval.Day, -1, DateAdd(Microsoft.VisualBasic.DateInterval.Month, 1, DTPicker1.MinDate))
			'DTPicker1.MaxDate = DateAdd("d", 1, DateAdd("m", 1, DTPicker1.MinDate))
			If Month(Now) = Month(DTPicker1.Value) And Year(Now) = Year(DTPicker1.Value) Then
				DTPicker1.Value = Now
			End If
		End If
		Call ConfiguraForm()
		Call MuestraDatos()
	End Sub
	
	Sub ConfiguraForm()
		SSTab1.SelectedIndex = 0
		SSTab1.TabPages.Item(1).Enabled = False
		cAcepta.Enabled = False
		lblNumReg.Text = CStr(Nothing)
		FLAG_CHECK = False
		
	End Sub
	
	Private Function MuestraDatos() As Object
		Dim SQL As String
		SQL = "SELECT tipocambiofecha, tipocambiocompra, tipocambioventa, tipocambiopromedio "
		SQL = SQL & "FROM CT_TIPOCAMBIO WHERE MONTH(tipocambiofecha)=" & VGParamSistem.mesproceso & " And Year(tipocambiofecha) =" & VGParamSistem.AnoProceso & " "
		SQL = SQL & "ORDER BY 1"
		rs = VGCNx.Execute(SQL)
		TDBGrid1.DataSource = rs
		lblNumReg.Text = CStr(rs.RecordCount)
		SSTab1.SelectedIndex = 0
	End Function
	
	Private Sub cCancela_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cCancela.Click
		SSTab1.TabPages.Item(0).Enabled = True
		SSTab1.SelectedIndex = 0
		SSTab1.Focus()
		frmbotones.Visible = True
		modoinsert = False
		modoedit = False
		i_filaorigen = -1
	End Sub
	
	Private Sub cmdBotones_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBotones.Click
		Dim Index As Short = cmdBotones.GetIndex(eventSender)
		Dim J As Short
		Dim spos As Short
		Dim SQL As String
		
		'On Error GoTo X
		SSTab1.TabPages.Item(1).Enabled = True
		
		Select Case Index
			Case 0 'nuevo
				modoinsert = True
				frmbotones.Visible = False
				SSTab1.SelectedIndex = 1
				Call LimpiarValores()
				DTPicker1.Focus()
				
			Case 1 'editar
				If TDBGrid1.Row < 0 Then
					Exit Sub
				End If
				modoedit = True
				frmbotones.Visible = False
				SSTab1.SelectedIndex = 1
				Call EditarValores()
				
			Case 2 'eliminar
				If MsgBox("Desea eliminar el registro de Fecha " & TDBGrid1.Columns(0).Value, MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "AVISO") = MsgBoxResult.Yes Then
					SQL = "DELETE FROM ct_tipocambio WHERE convert(varchar(10),tipocambiofecha,103)='" & TDBGrid1.Columns(0).Value & "'"
					VGCNx.Execute(SQL)
					Call MuestraDatos()
				End If
				
			Case 3 'imprimir
				Call impresion("rptTipoCambio.rpt")
				
			Case 4 ' salir
				Me.Close()
		End Select
		
		Exit Sub
		
x: 
		If Index = 2 And Err.Number = -2147217873 Then
			MsgBox("Registro no podrá Eliminarse mientras exista Información en la Tablas Relacionadas", MsgBoxStyle.Information, Text)
		Else
			MsgBox("Error inesperado: " & Err.Description & "  " & Err.Number, MsgBoxStyle.Information, Text)
		End If
		
	End Sub
	
	Sub EditarValores()
		Dim i As Short
		With TDBGrid1
			DTPicker1.Value = .Columns(0).text
			For i = 1 To 3
				'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
				txt(i - 1).CtlText = Trim(.Columns(i).text)
			Next 
		End With
	End Sub
	
	Public Function LimpiarValores() As Object
		Dim i As Short
		If Month(Now) = Month(DTPicker1.Value) And Year(Now) = Year(DTPicker1.Value) Then
			DTPicker1.Value = Now
		End If
		For i = 0 To 2
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			txt(i).CtlText = Nothing
		Next 
	End Function
	
	Private Sub cAcepta_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cAcepta.Click
		If ValidaData() = True Then
			Call GrabaData()
		End If
		
	End Sub
	
	Sub GrabaData()
		Dim SQL As String
		On Error GoTo x
		
		SSTab1.TabPages.Item(0).Enabled = True
		
		If modoinsert = True Then
			SQL = "INSERT CT_TIPOCAMBIO(tipocambiofecha, tipocambiocompra, tipocambioventa, tipocambiopromedio,usuariocodigo,fechaact) "
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			SQL = SQL & "VALUES ('" & DateSQL(DTPicker1.Value) & "'," & txt(0).CtlText & "," & txt(1).CtlText & "," & txt(2).CtlText & ",'" & VGUsuario & "','" & DateSQL(CStr(Today)) & "')"
			VGCNx.BeginTrans()
			VGCNx.Execute(SQL)
			VGCNx.CommitTrans()
			
		ElseIf modoedit = True Then 
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			SQL = "UPDATE CT_TIPOCAMBIO SET tipocambiocompra=" & txt(0).CtlText & ","
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			SQL = SQL & "tipocambioventa =" & txt(1).CtlText & ","
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			SQL = SQL & "tipocambiopromedio=" & txt(2).CtlText & ","
			SQL = SQL & "usuariocodigo='" & VGUsuario & "',fechaact=" & DateSQL(CStr(Today)) & " "
			SQL = SQL & "WHERE tipocambiofecha='" & DateSQL(DTPicker1.Value) & "'"
			VGCNx.BeginTrans()
			VGCNx.Execute(SQL)
			VGCNx.CommitTrans()
			
		End If
		
		Call MuestraDatos()
		frmbotones.Visible = True
		modoinsert = False : modoedit = False : FLAG_CHECK = False
		i_filaorigen = -1
		Exit Sub
		
x: 
		If Err.Number = -2147217873 Then
			MsgBox("Esta intentando registrar uno Existente " & Err.Description, MsgBoxStyle.Information, Text)
		Else
			MsgBox("Error inesperado: " & Err.Number & " " & Err.Description)
		End If
		VGCNx.RollbackTrans()
		
	End Sub
	
	Function ValidaData() As Boolean
		Dim rsX As ADODB.Recordset
		Dim SQL As String
		Dim i As Short
		
		SQL = "select tipocambiofecha from ct_tipocambio where convert(varchar(10),tipocambiofecha,103)='" & VB6.Format(DTPicker1.Value, "dd/mm/yyyy") & "'"
		VGvardllgen = New dllgeneral.dll_general
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VerificaDatoExistente(VGCNx, SQL). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If VerificaDatoExistente(VGCNx, SQL) > 0 And modoinsert = True Then
			MsgBox("La Fecha de Tipo Cambio a Registrar Existe en la Base", MsgBoxStyle.Information, Text)
			ValidaData = False
			Exit Function
		End If
		
		ValidaData = True
	End Function
	
	Private Sub FrmMntTipoCambio_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		'UPGRADE_NOTE: El objeto rs no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rs = Nothing
	End Sub
	
	Private Sub SSTab1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles SSTab1.SelectedIndexChanged
		Static PreviousTab As Short = SSTab1.SelectedIndex()
		SSTab1.TabPages.Item(PreviousTab).Enabled = False
		cAcepta.Enabled = False
		PreviousTab = SSTab1.SelectedIndex()
	End Sub
	
	Private Sub TDBGrid1_HeadClick(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueOleDBGrid70.TrueDBGridEvents_HeadClickEvent) Handles TDBGrid1.HeadClick
		On Error Resume Next
		'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		If IsNothing(rs.Sort) Then
			rs.Sort = TDBGrid1.Columns.item(eventArgs.ColIndex).DataField & " asc"
		ElseIf VB.Right(rs.Sort, 3) = "asc" Then 
			rs.Sort = TDBGrid1.Columns.item(eventArgs.ColIndex).DataField & " desc"
		ElseIf VB.Right(rs.Sort, 4) = "desc" Then 
			rs.Sort = TDBGrid1.Columns.item(eventArgs.ColIndex).DataField & " asc"
		End If
		Call ConfiguraTdbgrid()
		'UPGRADE_NOTE: Refresh se actualizó a CtlRefresh. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        TDBGrid1.Refresh()
	End Sub
	
	Private Sub TDBGrid1_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TDBGrid1.DblClick
		If rs.RecordCount > 0 And (modoedit = False And modoinsert = False) Then
			Call cmdBotones_Click(cmdBotones.Item(1), New System.EventArgs())
		End If
	End Sub
	
	Private Sub ConfiguraTdbgrid()
		Dim i As Short
		Dim i_total As Short
		Dim i_width As Short
		'  TDBGrid1.Columns(1).Visible = False
		'  TDBGrid1.Columns(2).Visible = False
		TDBGrid1.Columns(0).Width = 800
		TDBGrid1.Columns(1).Width = 1000
		TDBGrid1.Columns(2).Width = 1000
		TDBGrid1.Columns(3).Width = 1000
		
	End Sub
	
	Function ValidaDataIngreso() As Boolean
		Dim i As Short
		For i = 0 To 2
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			If IsNothing(txt(i).CtlText) Then
				ValidaDataIngreso = False
				Exit Function
			End If
		Next 
		
		ValidaDataIngreso = True
	End Function
	
	Private Sub txt_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txt.Change
		Dim Index As Short = txt.GetIndex(eventSender)
		cAcepta.Enabled = ValidaDataIngreso()
	End Sub
	
	Private Sub txt_KeyPressEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTextFer.__TxFer_KeyPressEvent) Handles txt.KeyPressEvent
		Dim Index As Short = txt.GetIndex(eventSender)
		If eventArgs.KeyAscii = 13 And Index = 2 Then
			cAcepta.Focus()
			Call cAcepta_Click(cAcepta, New System.EventArgs())
		End If
	End Sub
End Class