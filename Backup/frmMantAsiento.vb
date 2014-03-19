Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmMantAsiento
	Inherits System.Windows.Forms.Form
	
	Dim modoinsert As Boolean
	Dim modoedit As Boolean
	Dim rs As New ADODB.Recordset
	Dim rsAsiento As ADODB.Recordset
	
	'UPGRADE_WARNING: El evento ChkCargo.CheckStateChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub ChkCargo_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ChkCargo.CheckStateChanged
		If modoinsert = True Or modoedit = True Then cAcepta.Enabled = ValidaDataIngreso()
	End Sub
	
	Private Sub frmMantAsiento_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Ctr_Ayuda1.Conexion(VGCNx)
		Call ConfiguraForm()
		Call MuestraDatosAsiento()
	End Sub
	
	Private Sub frmMantAsiento_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		'UPGRADE_NOTE: El objeto rs no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rs = Nothing
		'UPGRADE_NOTE: El objeto rsAsiento no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsAsiento = Nothing
		'UPGRADE_NOTE: El objeto VGvardllgen no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		VGvardllgen = Nothing
	End Sub
	
	Sub ConfiguraForm()
		SSTab1.SelectedIndex = 0
		SSTab1.TabPages.Item(1).Enabled = False
		SSTab1.TabPages.Item(2).Enabled = False
		cAcepta.Enabled = False
		lblNumReg.Text = CStr(Nothing)
		Me.Width = VB6.TwipsToPixelsX(7050)
		Me.Height = VB6.TwipsToPixelsY(6255)
	End Sub
	
	'FIXIT: Declare 'MuestraDatosAsiento' con un tipo de datos de enlace en tiempo de compilación     FixIT90210ae-R1672-R1B8ZE
	Public Function MuestraDatosAsiento() As Object
		Dim SQL As String
		
		SQL = "SELECT A.asientocodigo, A.asientodescripcion,A.flaggrabado,A.controlnref,A.nemotecref,"
		SQL = SQL & "B.asientonumcorr01, B.asientonumcorr02, B.asientonumcorr03, B.asientonumcorr04,"
		SQL = SQL & "B.asientonumcorr05, B.asientonumcorr06, B.asientonumcorr07, B.asientonumcorr08,"
		SQL = SQL & "B.asientonumcorr09, B.asientonumcorr10, B.asientonumcorr11, B.asientonumcorr12,"
		SQL = SQL & "A.librocodigo,asientoadicionacargo=Isnull(A.asientoadicionacargo,0) "
		SQL = SQL & "FROM  ct_asiento A, ct_asientocorre B  WHERE A.asientocodigo<>'00'"
		SQL = SQL & "and b.empresacodigo='" & VGParametros.empresacodigo & "'"
		SQL = SQL & " and A.asientocodigo=B.asientocodigo and B.asientoanno='" & VGParamSistem.Anoproceso & "'"
		
		rs = VGCNx.Execute(SQL)
		TDBGridAsientos.DataSource = rs
		Call ConfiguraGridAsientos()
		lblNumReg.Text = CStr(rs.RecordCount)
		
	End Function
	
	Private Sub cmdBotones_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBotones.Click
		Dim Index As Short = cmdBotones.GetIndex(eventSender)
		Dim J As Short
		Dim spos As Short
		Dim SQL As String
		Dim SQL1 As String
		
		On Error GoTo x
		
		Select Case Index
			Case 0 'nuevo
				SSTab1.SelectedIndex = 1
				SSTab1.TabPages.Item(1).Enabled = True
				SSTab1.TabPages.Item(2).Enabled = True
				Call LimpiarForm(Me, "")
				txt(0).Focus()
				Call ModoEditable(True, Me, "")
				frmbotones.Visible = False
				modoinsert = True
				
			Case 1 'modificar
				If TDBGridAsientos.Row < 0 Then
					Exit Sub
				End If
				SSTab1.SelectedIndex = 1
				SSTab1.TabPages.Item(1).Enabled = True
				SSTab1.TabPages.Item(2).Enabled = True
				modoedit = True
				frmbotones.Visible = False
				Call EditarAsiento()
				Call ModoEditable(True, Me, "")
				
			Case 2 'eliminar
				If MsgBox("Desea eliminar el registro de SubAsiento Nº " & TDBGridAsientos.Columns(0).Value & "?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "AVISO") = MsgBoxResult.Yes Then
					'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
					SQL = "DELETE FROM CT_ASIENTO WHERE asientocodigo='" & txt(0).CtlText & "'"
					SQL1 = "DELETE FROM CT_ASIENTOCorre WHERE "
					'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
					SQL1 = SQL1 & " empresacodigo='" & VGParametros.empresacodigo & "' and asientocodigo='" & txt(0).CtlText & "' AND asientoanno='" & VGParamSistem.Anoproceso & "'"
					VGCNx.Execute(SQL)
					VGCNx.Execute(SQL1)
					Call MuestraDatosAsiento()
				End If
				
			Case 3 'imprimir
				Call Impresion("rptAsiento.rpt")
				
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
	
	Private Sub cAcepta_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cAcepta.Click
		Dim SQL As String
		Dim SQL1 As String
		'On Error GoTo X
		
		VGvardllgen = New dllgeneral.dll_general
		VGCNx.BeginTrans()
		
		If modoinsert = True Then
			SQL = "INSERT INTO CT_ASIENTO (asientocodigo,asientodescripcion,flaggrabado,controlnref,nemotecref,"
			SQL = SQL & "asientonumcorr01,asientonumcorr02,asientonumcorr03,asientonumcorr04,asientonumcorr05,asientonumcorr06,asientonumcorr07,asientonumcorr08,asientonumcorr09,asientonumcorr10,asientonumcorr11,asientonumcorr12,usuariocodigo,fechaact,librocodigo,asientoadicionacargo) "
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			SQL = SQL & "VALUES ('" & txt(0).CtlText & "','" & txt(1).CtlText & "'," & chk(0).CheckState & "," & chk(1).CheckState & ",'" & Trim(UCase(txt(2).CtlText)) & "',"
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(txt(5).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(txt(4).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			SQL = SQL & ESNULO(txt(3).CtlText, 0) & "," & ESNULO(txt(4).CtlText, 0) & "," & ESNULO(txt(5).CtlText, 0) & ","
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(txt(8).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(txt(7).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			SQL = SQL & ESNULO(txt(6).CtlText, 0) & "," & ESNULO(txt(7).CtlText, 0) & "," & ESNULO(txt(8).CtlText, 0) & ","
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(txt(14).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(txt(13).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(txt(12).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(txt(11).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(txt(10).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			SQL = SQL & ESNULO(txt(9).CtlText, 0) & "," & ESNULO(txt(10).CtlText, 0) & "," & ESNULO(txt(11).CtlText, 0) & "," & ESNULO(txt(12).CtlText, 0) & "," & ESNULO(txt(13).CtlText, 0) & "," & ESNULO(txt(14).CtlText, 0) & ",'"
			'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			SQL = SQL & VGUsuario & "','" & VB6.Format(Today, "dd/mm/yyyy") & "','" & IIf(Not IsNothing(Ctr_Ayuda1.xclave), Trim(Ctr_Ayuda1.xclave), "00") & "','" & ChkCargo.CheckState & "')"
			
			SQL1 = "INSERT INTO CT_ASIENTOCORRE (empresacodigo,asientocodigo,asientoanno,"
			SQL1 = SQL1 & "asientonumcorr01,asientonumcorr02,asientonumcorr03,asientonumcorr04,asientonumcorr05,asientonumcorr06,asientonumcorr07,asientonumcorr08,asientonumcorr09,asientonumcorr10,asientonumcorr11,asientonumcorr12,usuariocodigo,fechaact) "
			SQL1 = SQL1 & "VALUES ('" & VGParametros.empresacodigo & "',"
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			SQL1 = SQL1 & "'" & txt(0).CtlText & " ','" & VGParamSistem.Anoproceso & "',"
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(txt(5).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(txt(4).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			SQL1 = SQL1 & ESNULO(txt(3).CtlText, 0) & "," & ESNULO(txt(4).CtlText, 0) & "," & ESNULO(txt(5).CtlText, 0) & ","
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(txt(8).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(txt(7).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			SQL1 = SQL1 & ESNULO(txt(6).CtlText, 0) & "," & ESNULO(txt(7).CtlText, 0) & "," & ESNULO(txt(8).CtlText, 0) & ","
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(txt(14).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(txt(13).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(txt(12).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(txt(11).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(txt(10).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			SQL1 = SQL1 & ESNULO(txt(9).CtlText, 0) & "," & ESNULO(txt(10).CtlText, 0) & "," & ESNULO(txt(11).CtlText, 0) & "," & ESNULO(txt(12).CtlText, 0) & "," & ESNULO(txt(13).CtlText, 0) & "," & ESNULO(txt(14).CtlText, 0) & ",'"
			SQL1 = SQL1 & VGUsuario & "','" & VB6.Format(Today, "dd/mm/yyyy") & "')"
			
			
		ElseIf modoedit = True Then 
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			SQL = "UPDATE CT_ASIENTO SET asientodescripcion='" & Trim(UCase(txt(1).CtlText)) & "',"
			SQL = SQL & "flaggrabado=" & chk(0).CheckState & ","
			SQL = SQL & "controlnref=" & chk(1).CheckState & ","
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			SQL = SQL & "nemotecref='" & txt(2).CtlText & "',"
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(txt(5).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(txt(4).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			SQL = SQL & "asientonumcorr01=" & ESNULO(txt(3).CtlText, 0) & ",asientonumcorr02=" & ESNULO(txt(4).CtlText, 0) & ",asientonumcorr03=" & ESNULO(txt(5).CtlText, 0) & ","
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(txt(8).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(txt(7).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			SQL = SQL & "asientonumcorr04=" & ESNULO(txt(6).CtlText, 0) & ",asientonumcorr05=" & ESNULO(txt(7).CtlText, 0) & ",asientonumcorr06=" & ESNULO(txt(8).CtlText, 0) & ","
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(txt(11).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(txt(10).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			SQL = SQL & "asientonumcorr07=" & ESNULO(txt(9).CtlText, 0) & ",asientonumcorr08=" & ESNULO(txt(10).CtlText, 0) & ",asientonumcorr09=" & ESNULO(txt(11).CtlText, 0) & ","
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(txt(14).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(txt(13).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			SQL = SQL & "asientonumcorr10=" & ESNULO(txt(12).CtlText, 0) & ",asientonumcorr11=" & ESNULO(txt(13).CtlText, 0) & ",asientonumcorr12=" & ESNULO(txt(14).CtlText, 0) & ","
			SQL = SQL & "usuariocodigo='" & VGUsuario & "',fechaact='" & VB6.Format(Today, "dd/mm/yyyy") & "',"
			'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			SQL = SQL & "librocodigo='" & IIf(Not IsNothing(Ctr_Ayuda1.xclave), Trim(Ctr_Ayuda1.xclave), "00") & "', "
			SQL = SQL & "asientoadicionacargo='" & ChkCargo.CheckState & "' "
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			SQL = SQL & "WHERE asientocodigo='" & txt(0).CtlText & "'"
			
			SQL1 = "UPDATE CT_ASIENTOCORRE SET "
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(txt(5).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(txt(4).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			SQL1 = SQL1 & "asientonumcorr01=" & ESNULO(txt(3).CtlText, 0) & "0,asientonumcorr02=" & ESNULO(txt(4).CtlText, 0) & ",asientonumcorr03=" & ESNULO(txt(5).CtlText, 0) & ","
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(txt(8).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(txt(7).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			SQL1 = SQL1 & "asientonumcorr04=" & ESNULO(txt(6).CtlText, 0) & ",asientonumcorr05=" & ESNULO(txt(7).CtlText, 0) & ",asientonumcorr06=" & ESNULO(txt(8).CtlText, 0) & ","
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(txt(11).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(txt(10).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			SQL1 = SQL1 & "asientonumcorr07=" & ESNULO(txt(9).CtlText, 0) & ",asientonumcorr08=" & ESNULO(txt(10).CtlText, 0) & ",asientonumcorr09=" & ESNULO(txt(11).CtlText, 0) & ","
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(txt(14).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(txt(13).Text, 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			SQL1 = SQL1 & "asientonumcorr10=" & ESNULO(txt(12).CtlText, 0) & ",asientonumcorr11=" & ESNULO(txt(13).CtlText, 0) & ",asientonumcorr12=" & ESNULO(txt(14).CtlText, 0) & ","
			SQL1 = SQL1 & "usuariocodigo='" & VGUsuario & "',fechaact='" & VB6.Format(Today, "dd/mm/yyyy") & "' "
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			SQL1 = SQL1 & "WHERE empresacodigo='" & VGParametros.empresacodigo & "' and  asientocodigo='" & txt(0).CtlText & "' AND "
			SQL1 = SQL1 & "asientoanno='" & VGParamSistem.Anoproceso & "'"
			
		End If
		
		VGCNx.Execute(SQL)
		VGCNx.Execute(SQL1)
		VGCNx.CommitTrans()
		
		'UPGRADE_NOTE: El objeto VGvardllgen no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		VGvardllgen = Nothing
		frmbotones.Visible = True
		modoinsert = False : modoedit = False
		Call MuestraDatosAsiento()
		cAcepta.Enabled = False
		'UPGRADE_NOTE: El objeto VGvardllgen no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		VGvardllgen = Nothing
		Call ModoEditable(False, Me, "")
		SSTab1.SelectedIndex = 0
		SSTab1.TabPages.Item(1).Enabled = False
		SSTab1.TabPages.Item(2).Enabled = False
		Exit Sub
		
x: 
		If Err.Number = -2147217873 Then
			MsgBox("Esta intentando registrar Código de Asiento Existente ", MsgBoxStyle.Information, Text)
			txt(0).Focus()
		Else
			MsgBox("Error inesperado: " & Err.Number & " " & Err.Description, MsgBoxStyle.Information, Text)
		End If
		VGCNx.RollbackTrans()
		
	End Sub
	
	Private Sub cCancela_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cCancela.Click
		frmbotones.Visible = True
		modoinsert = False : modoedit = False
		cAcepta.Enabled = False
		SSTab1.SelectedIndex = 0
		SSTab1.TabPages.Item(0).Enabled = True
		SSTab1.TabPages.Item(1).Enabled = False
		SSTab1.TabPages.Item(2).Enabled = False
	End Sub
	
	Private Sub SSTab1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles SSTab1.SelectedIndexChanged
		Static PreviousTab As Short = SSTab1.SelectedIndex()
		If PreviousTab = 0 Then SSTab1.TabPages.Item(PreviousTab).Enabled = False
		PreviousTab = SSTab1.SelectedIndex()
	End Sub
	
	Private Sub TDBGridAsientos_HeadClick(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueOleDBGrid70.TrueDBGridEvents_HeadClickEvent) Handles TDBGridAsientos.HeadClick
		On Error Resume Next
		'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		If IsNothing(rs.Sort) Then
			rs.Sort = TDBGridAsientos.Columns.Item(eventArgs.ColIndex).DataField & " asc"
		ElseIf VB.Right(rs.Sort, 3) = "asc" Then 
			rs.Sort = TDBGridAsientos.Columns.Item(eventArgs.ColIndex).DataField & " desc"
		ElseIf VB.Right(rs.Sort, 4) = "desc" Then 
			rs.Sort = TDBGridAsientos.Columns.Item(eventArgs.ColIndex).DataField & " asc"
		End If
		'UPGRADE_NOTE: Refresh se actualizó a CtlRefresh. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        TDBGridAsientos.Refresh()
	End Sub
	
	Private Sub TDBGridAsientos_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TDBGridAsientos.DblClick
		If rs.RecordCount > 0 Then Call cmdBotones_Click(cmdBotones.Item(1), New System.EventArgs())
	End Sub
	
	'FIXIT: Declare 'LastRow' con un tipo de datos de enlace en tiempo de compilación          FixIT90210ae-R1672-R1B8ZE
	Private Sub TDBGridAsientos_RowColChange(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueOleDBGrid70.TrueDBGridEvents_RowColChangeEvent) Handles TDBGridAsientos.RowColChange
		Call EditarAsiento()
	End Sub
	
	Private Sub txt_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txt.Change
		Dim Index As Short = txt.GetIndex(eventSender)
		If modoinsert = True Or modoedit = True Then
			cAcepta.Enabled = ValidaDataIngreso()
		End If
	End Sub
	
	'UPGRADE_WARNING: El evento chk.CheckStateChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chk_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chk.CheckStateChanged
		Dim Index As Short = chk.GetIndex(eventSender)
		If modoinsert = True Or modoedit = True Then cAcepta.Enabled = ValidaDataIngreso()
	End Sub
	
	Private Sub txt_KeyDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTextFer.__TxFer_KeyDownEvent) Handles txt.KeyDownEvent
		Dim Index As Short = txt.GetIndex(eventSender)
		If Index = 2 And eventArgs.KeyCode = 13 Then
			cAcepta.Focus()
		End If
		
	End Sub
	
	Private Sub txt_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txt.Leave
		Dim Index As Short = txt.GetIndex(eventSender)
		If Index = 0 Then
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			'UPGRADE_WARNING: Se detectó el uso de Null/IsNull(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			If Not IsDbNull(txt(0).CtlText) Then txt(0).CtlText = VB6.Format(txt(0).CtlText, "000")
		Else
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			txt(Index).CtlText = UCase(txt(Index).CtlText)
		End If
	End Sub
	
	Sub EditarAsiento()
		Dim I As Short
		
		If rs.RecordCount > 0 Then
			With TDBGridAsientos
				'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
				txt(0).CtlText = .Columns(0).Value
				'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
				txt(1).CtlText = .Columns(1).Value
				chk(0).CheckState = IIf(.Columns(2).Value = 0, 0, 1)
				chk(1).CheckState = IIf(.Columns(3).Value = 0, 0, 1)
				ChkCargo.CheckState = IIf(.Columns(18).Text = "", 0, .Columns(18).Text)
				For I = 3 To 14
					'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
					txt(I).CtlText = .Columns(I + 2).Value
				Next 
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto TDBGridAsientos.Columns().Value. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Ctr_Ayuda1.xclave = .Columns(17).Value : Ctr_Ayuda1.Ejecutar()
			End With
			
		End If
	End Sub
	
	Sub ConfiguraGridAsientos()
		Dim I As Short
		With TDBGridAsientos
			.Columns(0).Width = 700
			.Columns(1).Width = 2500
			.Columns(2).Width = 1000
			.Columns(3).Width = 1000
			.Columns(4).Width = 3500
			For I = 5 To 16
				.Columns(I).Visible = False
			Next 
		End With
		
	End Sub
	
	Function ValidaDataIngreso() As Boolean
		Dim I As Short
		
		For I = 0 To 1
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			If IsNothing(txt(I).CtlText) Then
				ValidaDataIngreso = False
				Exit Function
			End If
			
		Next 
		
		ValidaDataIngreso = True
	End Function
End Class