Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmMantEntidad
	Inherits System.Windows.Forms.Form
	
	Dim modoinsert As Boolean
	Dim modoedit As Boolean
	Dim i_filaorigen As Short
	Dim rs As New ADODB.Recordset
	Dim FLAG_CHECK As Boolean
	
	Private Sub frmMantEntidad_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Call ConfiguraForm()
		Call MuestraDatos("%")
		Call CargaLista()
	End Sub
	
	Sub ConfiguraForm()
		SSTab1.SelectedIndex = 0
		SSTab1.TabPages.Item(1).Enabled = False
		cAcepta.Enabled = False
		lblNumReg.Text = CStr(Nothing)
		FLAG_CHECK = False
	End Sub
	
	'FIXIT: Declare 'MuestraDatos' con un tipo de datos de enlace en tiempo de compilación     FixIT90210ae-R1672-R1B8ZE
	Private Function MuestraDatos(ByRef xCod As String) As Object
		Dim SQL As String
		SQL = "SELECT entidadcodigo,entidadrazonsocial,entidaddireccion,entidadtelefono,entidadruc,entidadtipocontri,proyectocierre From ct_entidad "
		'  SQL = SQL & "  AND WHERE entidadcodigo<>'00' "
		
		If IsNumeric(xCod) = True Then
			SQL = SQL & " WHERE entidadcodigo LIKE '" & xCod & "%'"
		Else
			SQL = SQL & " WHERE  entidadrazonsocial LIKE '" & xCod & "%'"
		End If
		rs = VGCNx.Execute(SQL)
		TDBGrid1.DataSource = rs
		Call ConfiguraTdbgrid()
		lblNumReg.Text = CStr(rs.RecordCount)
		SSTab1.SelectedIndex = 0
	End Function
	
	Sub CargaLista()
		' Declara una variable para agregar objetos ListItem.
		Dim rsX As ADODB.Recordset
		Dim itmX As System.Windows.Forms.ListViewItem
		Dim SQL As String
		rsX = New ADODB.Recordset
		
		ListView1.Columns.Clear()
		ListView1.Items.Clear()
		ListView1.Columns.Add("", "Codigo Tipo Analítico", CInt(VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(ListView1.Width) / 3)))
		ListView1.Columns.Add("Descripción Tipo Analítico", CInt(VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(ListView1.Width) * 2 / 3)), System.Windows.Forms.HorizontalAlignment.Center)
		ListView1.View = System.Windows.Forms.View.Details
		
		SQL = "select tipoanaliticocodigo,tipoanaliticodescripcion FROM ct_tipoanalitico WHERE tipoanaliticocodigo<>'00'"
		rsX = VGCNx.Execute(SQL)
		While Not rsX.EOF
			itmX = ListView1.Items.Add(rsX.Fields(0).Value)
			'UPGRADE_WARNING: El límite inferior de la colección itmX cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
			If itmX.SubItems.Count > 1 Then
				itmX.SubItems(1).Text = rsX.Fields(1).Value
			Else
				itmX.SubItems.Insert(1, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, rsX.Fields(1).Value))
			End If
			rsX.MoveNext()
		End While
		'UPGRADE_NOTE: El objeto rsX no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsX = Nothing
		
	End Sub
	
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
		Dim rsql As New ADODB.Recordset
		On Error GoTo x
		SSTab1.TabPages.Item(1).Enabled = True
		
		Select Case Index
			Case 0 'nuevo
				modoinsert = True
				frmbotones.Visible = False
				SSTab1.SelectedIndex = 1
				Call LimpiarValores()
				Call CargaLista()
				'UPGRADE_NOTE: Enabled se actualizó a CtlEnabled. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
				txt(0).CtlEnabled = True
				txt(0).Focus()
				
			Case 1 'editar
				If TDBGrid1.Row < 0 Then
					Exit Sub
				End If
				modoedit = True
				frmbotones.Visible = False
				SSTab1.SelectedIndex = 1
				Call EditarValores()
				Call MuestraCheckTipoAnalitico()
				cAcepta.Enabled = False
				'UPGRADE_NOTE: Enabled se actualizó a CtlEnabled. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
				txt(0).CtlEnabled = False
				
			Case 2 'eliminar
				If MsgBox("Desea eliminar el registro de Código Entidad " & Trim(TDBGrid1.Columns(0).Value), MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "AVISO") = MsgBoxResult.Yes Then
					VGCNx.BeginTrans()
					SQL = "DELETE FROM ct_analitico WHERE entidadcodigo='" & Trim(TDBGrid1.Columns(0).Value) & "'"
					VGCNx.Execute(SQL)
					SQL = "DELETE FROM ct_entidad WHERE entidadcodigo='" & Trim(TDBGrid1.Columns(0).Value) & "'"
					VGCNx.Execute(SQL)
					VGCNx.CommitTrans()
					'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
					Call MuestraDatos((txtBuscar.CtlText))
				End If
				
			Case 3 'imprimir
				Call Impresion("rptEntidad.rpt")
				
			Case 4 ' salir
				SQL = "update ct_entidad SET identidadcodigo=case when len(rtrim(entidadruc))=11 and "
				SQL = SQL & " left(entidadruc,2) in ('20','15','10') then 6 "
				SQL = SQL & " else case when len(rtrim(entidadruc))=8 then 1 else 0 end end "
				VGCNx.Execute(SQL)
				Me.Close()
		End Select
		
		Exit Sub
		
x: 
		If Index = 2 And Err.Number = -2147217873 Then
			MsgBox("Registro no podrá Eliminarse mientras exista Información en la Tablas Relacionadas", MsgBoxStyle.Information, Text)
			VGCNx.RollbackTrans()
		Else
			MsgBox("Error inesperado: " & Err.Description & "  " & Err.Number, MsgBoxStyle.Information, Text)
		End If
		
	End Sub
	
	Sub EditarValores()
		Dim I As Short
		With TDBGrid1
			For I = 0 To 4
				'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
				txt(I).CtlText = Trim(.Columns(I).Text)
			Next 
			
			'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			If Not IsNothing(Trim(.Columns(5).Text)) Then
				cboTipoCont.Text = VB6.GetItemString(cboTipoCont, CShort(.Columns(5).Text) - 1)
			Else
				cboTipoCont.Text = CStr(Nothing)
			End If
			Check1.CheckState = .Columns(6).Value
		End With
	End Sub
	
	'FIXIT: Declare 'LimpiarValores' con un tipo de datos de enlace en tiempo de compilación     FixIT90210ae-R1672-R1B8ZE
	Public Function LimpiarValores() As Object
		Dim I As Short
		For I = 0 To 4
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			txt(I).CtlText = Nothing
		Next 
		cboTipoCont.Text = CStr(Nothing)
	End Function
	
	Private Sub cAcepta_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cAcepta.Click
		If ValidaData() = True Then
			Call GrabaData()
		End If
		
	End Sub
	
	Function ValidaData() As Boolean
		Dim rsX As ADODB.Recordset
		Dim SQL As String
		Dim I As Short
		
		
		'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		If IsNothing(txt(0).CtlText) Then
			MsgBox("Debe Registrar el Código de Analítico", MsgBoxStyle.Information, Text)
			ValidaData = False
			txt(4).Focus()
			Exit Function
		End If
		
		'    If Len(Trim$(txt(0).Text)) <> 11 And Trim$(txt(0).Text) <> "00" Then
		'        MsgBox "El Código de Analítico debe tener 11 caracteres", vbInformation, Caption
		'        ValidaData = False
		'        txt(4).SetFocus
		'        Exit Function
		'    End If
		
		'    If txt(4).Text = Empty Then
		'        MsgBox "Debe Registrar el Nº de RUC", vbInformation, Caption
		'        ValidaData = False
		'        txt(4).SetFocus
		'        Exit Function
		'    End If
		
		For I = 1 To ListView1.Items.Count
			'UPGRADE_WARNING: El límite inferior de la colección ListView1.ListItems cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
			If ListView1.Items.Item(I).Checked = True Then
				ValidaData = True
				Exit For
			Else
				ValidaData = False
				If I = ListView1.Items.Count Then
					MsgBox("Falta Completar el Tipo de Analítico", MsgBoxStyle.Information, Text)
					Exit Function
				End If
			End If
		Next 
		
		'  If txt(4).Text <> Empty And Len(Trim$(txt(4).Text)) <> 11 Then
		'    MsgBox "El número de RUC tiene 11 dígitos", vbInformation, Caption
		'    ValidaData = False
		'    txt(4).SetFocus
		'    Exit Function
		'  End If
		
		'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		If Not IsNothing(txt(4).CtlText) Then
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			SQL = "SELECT count(entidadruc) FROM ct_entidad WHERE entidadruc='" & txt(4).CtlText & "'"
			rsX = New ADODB.Recordset
			rsX = VGCNx.Execute(SQL)
			VGvardllgen = New dllgeneral.dll_general
			
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(rsX(0), 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If modoedit = True And ESNULO(rsX.Fields(0), 0) = 1 Then
				ValidaData = True
				'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
				SQL = "SELECT count(entidadruc) FROM ct_entidad WHERE entidadruc='" & txt(4).CtlText & "'"
				'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
				SQL = SQL & " AND entidadcodigo<>'" & txt(0).CtlText & "'"
				rsX = VGCNx.Execute(SQL)
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(rsX(0), 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If ESNULO(rsX.Fields(0), 0) > 0 Then
					MsgBox("Esta intentando registrar un numero de RUC existente", MsgBoxStyle.Information, Text)
					ValidaData = False
					txt(4).Focus()
					Exit Function
				End If
			Else
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(rsX(0), 0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If ESNULO(rsX.Fields(0), 0) > 0 Then
					MsgBox("Esta intentando registrar un número de RUC existente", MsgBoxStyle.Information, Text)
					ValidaData = False
					txt(4).Focus()
					Exit Function
				Else
					ValidaData = True
				End If
			End If
		End If
		
		ValidaData = True
	End Function
	
	Sub GrabaData()
		Dim xVarCbo As String
		Dim SQL As String
		On Error GoTo x
		
		SSTab1.TabPages.Item(0).Enabled = True
		
		xVarCbo = Trim(VB.Left(VB6.GetItemString(cboTipoCont, cboTipoCont.SelectedIndex), 2))
		
		If modoinsert = True Then
			SQL = "INSERT CT_ENTIDAD(entidadcodigo,entidadrazonsocial,entidaddireccion,entidadtelefono,entidadruc,entidadtipocontri,usuariocodigo,fechaact) "
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			SQL = SQL & "VALUES ('" & UCase(txt(0).CtlText) & "','" & UCase(txt(1).CtlText) & "','" & UCase(txt(2).CtlText) & "','" & txt(3).CtlText & "','" & txt(4).CtlText & "','" & xVarCbo & "','" & VGUsuario & "','" & Today & "')"
			VGCNx.BeginTrans()
			VGCNx.Execute(SQL)
			Call GrabaCheckTipoAnalitico()
			VGCNx.CommitTrans()
			
		ElseIf modoedit = True Then 
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			SQL = "UPDATE CT_ENTIDAD SET entidadrazonsocial='" & Trim(UCase(txt(1).CtlText)) & "',"
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			SQL = SQL & "entidaddireccion='" & Trim(UCase(txt(2).CtlText)) & "',"
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			SQL = SQL & "entidadtelefono='" & txt(3).CtlText & "',"
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			SQL = SQL & "entidadruc='" & txt(4).CtlText & "',"
			SQL = SQL & "entidadtipocontri='" & xVarCbo & "',"
			SQL = SQL & "proyectocierre='" & Check1.CheckState & "',"
			SQL = SQL & "usuariocodigo='" & VGUsuario & "',fechaact='" & VB6.Format(Today, "dd/mm/yyyy") & "' "
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			SQL = SQL & "WHERE entidadcodigo='" & txt(0).CtlText & "'"
			VGCNx.BeginTrans()
			VGCNx.Execute(SQL)
			
			If FLAG_CHECK = True Then
				'Call DeleteCheckTipoAnalitico
				Call GrabaCheckTipoAnalitico()
			End If
			
			VGCNx.CommitTrans()
			
		End If
		
		'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Call MuestraDatos((txtBuscar.CtlText))
		frmbotones.Visible = True
		modoinsert = False : modoedit = False : FLAG_CHECK = False
		i_filaorigen = -1
		Exit Sub
		
x: 
		If Err.Number = -2147217873 Then
			MsgBox("Esta intentando registrar Código Analítico Existente " & Err.Description, MsgBoxStyle.Information, Text)
		Else
			MsgBox("Error inesperado: " & Err.Number & " " & Err.Description)
		End If
		VGCNx.RollbackTrans()
		
	End Sub
	
	Sub MuestraCheckTipoAnalitico()
		Dim rsX As ADODB.Recordset
		Dim I As Integer
		Dim SQL As String
		Dim tipo As String
		For I = 1 To ListView1.Items.Count
			'UPGRADE_WARNING: El límite inferior de la colección ListView1.ListItems cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
			tipo = ListView1.Items.Item(I).Text
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			SQL = "select * FROM ct_analitico WHERE entidadcodigo='" & txt(0).CtlText & "'"
			SQL = SQL & " and tipoanaliticocodigo='" & tipo & "'"
			rsX = VGCNx.Execute(SQL)
			If rsX.RecordCount = 0 Then
				'UPGRADE_WARNING: El límite inferior de la colección ListView1.ListItems cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				ListView1.Items.Item(I).Checked = False
			Else
				'UPGRADE_WARNING: El límite inferior de la colección ListView1.ListItems cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				ListView1.Items.Item(I).Checked = True
			End If
		Next 
		'UPGRADE_NOTE: El objeto rsX no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsX = Nothing
		
	End Sub
	
	Sub DeleteCheckTipoAnalitico()
		Dim SQL As String
		'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		SQL = "DELETE FROM ct_analitico WHERE entidadcodigo='" & txt(0).CtlText & "'"
		VGCNx.Execute(SQL)
	End Sub
	
	Sub GrabaCheckTipoAnalitico()
		Dim SQL As String
		Dim I As Integer
		Dim xCodAnalitico As String
		Dim rsX As New ADODB.Recordset
		rsX = New ADODB.Recordset
		For I = 1 To ListView1.Items.Count
			'UPGRADE_WARNING: El límite inferior de la colección ListView1.ListItems cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
			If ListView1.Items.Item(I).Checked = True Then
				'UPGRADE_WARNING: El límite inferior de la colección ListView1.ListItems cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
				xCodAnalitico = Trim(txt(0).CtlText) & Trim(ListView1.Items.Item(I).Text)
				SQL = "select count(*) from ct_analitico where analiticocodigo='" & xCodAnalitico & "'"
				rsX = VGCNx.Execute(SQL)
				If rsX.Fields(0).Value = 0 Then
					SQL = "INSERT ct_analitico (analiticocodigo,entidadcodigo,tipoanaliticocodigo,usuariocodigo,fechaact) "
					'UPGRADE_WARNING: El límite inferior de la colección ListView1.ListItems cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
					'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
					SQL = SQL & "VALUES ('" & xCodAnalitico & "','" & Trim(txt(0).CtlText) & "','" & Trim(ListView1.Items.Item(I).Text) & "','" & VGUsuario & "','" & Today & "')"
					VGCNx.Execute(SQL)
				End If
			End If
		Next 
	End Sub
	
	Private Sub frmMantEntidad_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		'UPGRADE_NOTE: El objeto rs no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rs = Nothing
	End Sub
	
	Private Sub ListView1_ColumnClick(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.ColumnClickEventArgs) Handles ListView1.ColumnClick
		Dim ColumnHeader As System.Windows.Forms.ColumnHeader = ListView1.Columns(eventArgs.Column)
		'UPGRADE_ISSUE: MSComctlLib.ListView propiedad ListView1.SortKey no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        ListView1.Sorting = ColumnHeader.Index - 1
		ListView1.Sort()
	End Sub
	
	Private Sub ListView1_ItemCheck(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.ItemCheckEventArgs) Handles ListView1.ItemCheck
		Dim Item As System.Windows.Forms.ListViewItem = ListView1.Items(eventArgs.Index)
		FLAG_CHECK = True
		cAcepta.Enabled = ValidaDataIngreso()
	End Sub
	
	Private Sub SSTab1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles SSTab1.SelectedIndexChanged
		Static PreviousTab As Short = SSTab1.SelectedIndex()
		SSTab1.TabPages.Item(PreviousTab).Enabled = False
		cAcepta.Enabled = False
		If PreviousTab = 0 Then
			txtBuscar.Visible = False
		Else
			txtBuscar.Visible = True
		End If
		PreviousTab = SSTab1.SelectedIndex()
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
	
	Private Sub TDBGrid1_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TDBGrid1.DblClick
		If rs.RecordCount > 0 And (modoedit = False And modoinsert = False) Then
			Call cmdBotones_Click(cmdBotones.Item(1), New System.EventArgs())
		End If
	End Sub
	
	Private Sub ConfiguraTdbgrid()
		TDBGrid1.Columns(0).Width = 1100
		TDBGrid1.Columns(1).Width = 3500
		TDBGrid1.Columns(2).Width = 1800
		TDBGrid1.Columns(3).Width = 900
		TDBGrid1.Columns(4).Width = 1100
		
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
	
	Private Sub txt_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txt.Change
		Dim Index As Short = txt.GetIndex(eventSender)
		cAcepta.Enabled = ValidaDataIngreso()
	End Sub
	
	Private Sub txt_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txt.Leave
		Dim Index As Short = txt.GetIndex(eventSender)
		'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		txt(Index).CtlText = UCase(txt(Index).CtlText)
		'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		If Index = 0 And modoedit = False Then txt(4).CtlText = txt(0).CtlText
	End Sub
	
	'UPGRADE_WARNING: El evento cboTipoCont.SelectedIndexChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cboTipoCont_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboTipoCont.SelectedIndexChanged
		cAcepta.Enabled = ValidaDataIngreso()
	End Sub
	
	Private Sub txt_KeyPressEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTextFer.__TxFer_KeyPressEvent) Handles txt.KeyPressEvent
		Dim Index As Short = txt.GetIndex(eventSender)
		If eventArgs.KeyAscii = 13 And Index = 15 Then
			cAcepta.Focus()
			Call cAcepta_Click(cAcepta, New System.EventArgs())
		End If
	End Sub
	
	Private Sub txtBuscar_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtBuscar.Change
		'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Call MuestraDatos((txtBuscar.CtlText))
	End Sub
End Class