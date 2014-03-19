Option Strict Off
Option Explicit On
Friend Class Frmusuarios
	Inherits System.Windows.Forms.Form
	Dim Adoreg1 As New ADODB.Recordset
	Dim AdoReg2 As New ADODB.Recordset
	Dim AdoUsu As New ADODB.Recordset
	Dim ADOMen As New ADODB.Recordset
	Dim cCad As String
	Dim RegActual As Short
	Dim nFra As Short
	Dim nTipo As Short
	Dim nI As Short
	Dim mNode As System.Windows.Forms.TreeNode
	
	Private Sub Frmusuarios_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		central(Me)
		ADOConectar()
		' Init_ControlDataGrid DataGrid1
		If Adoreg1.RecordCount = 0 Then
			Botones_Init(True)
		Else
			Botones_Set(True)
		End If
		SetDataGrid()
		
		Frame1.Visible = False
		Frame0.Visible = True
		nFra = 0
		nTipo = 1
		
		' Configura el control TreeView
		TreeView1.Sorted = False
		TreeView1.CheckBoxes = True
		mNode = TreeView1.Nodes.Add("")
		mNode.Text = "Menu"
		mNode.Tag = VGConfig.ConnectionString
		mNode.ImageKey = "Abrir"
		mNode.Checked = True
		TreeView1.LabelEdit = False
		Cargar_Opc()
	End Sub
	
	Private Sub ADOConectar()
		'UPGRADE_NOTE: El objeto Adoreg1 no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		Adoreg1 = Nothing
		'UPGRADE_NOTE: El objeto AdoReg2 no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		AdoReg2 = Nothing
		'UPGRADE_NOTE: El objeto AdoUsu no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		AdoUsu = Nothing
		
		'Adoreg1.CursorType = adOpenDynamic           NO USAR CAMBIAR BOOKMARK
		
		Adoreg1.Open("Select usuariocodigo,usuarioNombre from si_USUARIO ", VGConfig, ADODB.CursorTypeEnum.adOpenStatic)
		AdoReg2.Open("Select * from si_USUARIO ", VGConfig, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
		AdoUsu.Open("Select * From si_menuusuarios where tipodesistema=" & MainContab.vgtipo & "", VGConfig, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
		
		DataGrid1.DataSource = Adoreg1
	End Sub
	
	Public Sub SetDataGrid()
		'UPGRADE_NOTE: Refresh se actualizó a CtlRefresh. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        DataGrid1.Refresh()
		DataGrid1.Columns(0).Caption = "           Código"
		DataGrid1.Columns(1).Caption = "                            Nombre"
		DataGrid1.Columns(0).Width = VB6.TwipsToPixelsX(1800)
		DataGrid1.Columns(1).Width = VB6.TwipsToPixelsX(4500)
		DataGrid1.ScrollBars = MSDataGridLib.ScrollBarsConstants.dbgVertical
	End Sub
	
	Private Sub cmdBotones_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBotones.Click
		Dim Index As Short = cmdBotones.GetIndex(eventSender)
		Dim nIi As Short
		Dim tempi As Short
		Dim temps As String
		Dim otext As System.Windows.Forms.TextBox
		Dim flag As Boolean
		Dim OTEXT1 As System.Windows.Forms.TextBox
		Dim op As Short
		Select Case Index
			Case 0 'Nuevo
				nTipo = 1

				Call Carga_Valor(1, TreeView1.Nodes.Count, True, 1)
				TreeView1.Refresh()
				'UPGRADE_WARNING: El límite inferior de la colección TreeView1.Nodes cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				If TreeView1.Nodes.Item(1).Checked Then
					'UPGRADE_WARNING: El límite inferior de la colección TreeView1.Nodes cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
					TreeView1.Nodes.Item(1).Expand()
				Else
					'UPGRADE_WARNING: El límite inferior de la colección TreeView1.Nodes cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
					TreeView1.Nodes.Item(1).Collapse()
				End If
				
				nFra = 1
				For	Each otext In Me.Text1
					otext.Text = ""
				Next otext
				Frame1.Text = "Nuevo Usuario"
				Frame1.Visible = True
				Frame0.Visible = False
				Botones_Set(False)
				Text1(0).Enabled = True
				Text1(0).Focus()
				
			Case 1 'Grabar
				If Text1(0).Text = "" Then
					MsgBox("Ingrese el codigo de usuario", MsgBoxStyle.Exclamation, mensaje1)
					Text1(0).Focus()
					Exit Sub
				End If
				If Text1(1).Text = "" Then
					MsgBox("Ingrese el nombre de usuario", MsgBoxStyle.Exclamation, mensaje1)
					Text1(1).Focus()
					Exit Sub
				End If
				If Text1(2).Text = "" Then
					MsgBox("Ingrese el password del usuario", MsgBoxStyle.Exclamation, mensaje1)
					Text1(2).Focus()
					Exit Sub
				End If
				If Text1(3).Text = "" Then
					MsgBox("Ingrese la confirmación del usuario", MsgBoxStyle.Exclamation, mensaje1)
					Text1(3).Focus()
					Exit Sub
				End If
				If Text1(2).Text <> Text1(3).Text Then
					MsgBox("El password no coincide con la confirnación", MsgBoxStyle.Exclamation, mensaje1)
					Text1(3).Focus()
					Exit Sub
				End If
				
				'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
				System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
				'Ingreso
				If nTipo = 1 Then
					flag = False
					'buscar igual codigo
					With Adoreg1
						If .RecordCount <> 0 Then
							.MoveFirst()
							.Find("usuariocodigo= '" & UCase(Text1(0).Text) & "'")
							If Not .EOF Then
								flag = True
								Text1(0).Text = ""
								MsgBox("El Usuario ya existe:  Ingrese de nuevo", MsgBoxStyle.Information, "Ingreso de Datos")
								Text1(0).Focus()
							End If
						End If
					End With
					If Not flag Then
						If Text1(2).Text = "" Then
							MsgBox("Ud. No ha ingresado su Password", MsgBoxStyle.Information, "Ingreso de Datos")
							Text1(2).Focus()
						ElseIf Text1(3).Text = "" Then 
							MsgBox("Ud. No ha ingresado su confirmación", MsgBoxStyle.Information, "Ingreso de Datos")
							Text1(3).Focus()
						ElseIf Text1(2).Text = Text1(3).Text Then 
							'pasa
							AdoReg2.AddNew()
							AdoReg2.Fields("usuariocodigo").Value = (RTrim(Text1(0).Text))
							If CDbl(VGTipoCod) = 1 Then
								AdoReg2.Fields("UsuarioPassword").Value = CODIFICASQL(RTrim(Text1(2).Text)) 'password
							Else
								AdoReg2.Fields("UsuarioPassword").Value = CODIFICA(RTrim(Text1(2).Text), NUMMAGICO) 'password
							End If
							AdoReg2.Fields("usuarioNombre").Value = (RTrim(Text1(1).Text))
							AdoReg2.UpdateBatch()
							If RTrim(Text1(1).Text) <> "" Then AdoReg2.Fields("usuarioNombre").Value = (RTrim(Text1(1).Text))
							'                     AdoReg2.Update
							Adoreg1.Requery()
							Call Grab_Men(UCase(RTrim(Text1(0).Text)))
							
							Frame0.Visible = True
							nFra = 0
							Botones_Set(True)
						Else
							MsgBox("Nombre de Password y la Confirmación no coinciden", MsgBoxStyle.Information, "Ingreso de datos")
							Text1(2).Text = ""
							Text1(3).Text = ""
							Text1(2).Focus()
						End If
					End If
				End If
				
				If nTipo = 2 Then
					
					AdoReg2.Fields("usuariocodigo").Value = (RTrim(Text1(0).Text))
					If CDbl(VGTipoCod) = 0 Then
						AdoReg2.Fields("UsuarioPassword").Value = CODIFICA(RTrim(Text1(2).Text), NUMMAGICO)
					Else
						AdoReg2.Fields("UsuarioPassword").Value = CODIFICASQL(RTrim(Text1(2).Text))
					End If
					If RTrim(Text1(1).Text) <> "" Then AdoReg2.Fields("usuarioNombre").Value = (RTrim(Text1(1).Text))
					AdoReg2.UpdateBatch()
					Adoreg1.Requery()
					AdoReg2.Requery()
					
					Call Grab_Men(UCase(RTrim(Text1(0).Text)))
					
					Frame1.Visible = False
					Frame0.Visible = True
					nFra = 0
					Botones_Set(True)
				End If
				Frame1.Visible = False
				Frame0.Visible = True
				SetDataGrid()
				'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
				System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
				
			Case 2 'Editar
				If Adoreg1.Bookmark Then
					'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
					System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
					nTipo = 2
					'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Adoreg1.Bookmark. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					AdoReg2.Bookmark = Adoreg1.Bookmark
					nFra = 2
					For	Each OTEXT1 In Me.Text1
						OTEXT1.Text = ""
					Next OTEXT1
					Text1(0).Text = AdoReg2.Fields("usuariocodigo").Value
					If CDbl(VGTipoCod) = 1 Then
						Text1(2).Text = DECODIFICASQL(AdoReg2.Fields("usuariopassword").Value)
						Text1(3).Text = DECODIFICASQL(AdoReg2.Fields("usuariopassword").Value)
					Else
						Text1(2).Text = DECODIFICA(AdoReg2.Fields("usuariopassword").Value, NUMMAGICO)
						Text1(3).Text = DECODIFICA(AdoReg2.Fields("usuariopassword").Value, NUMMAGICO)
					End If
					'UPGRADE_WARNING: Se detectó el uso de Null/IsNull(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
					If Not IsDbNull(AdoReg2.Fields("usuarioNombre").Value) Then Text1(1).Text = AdoReg2.Fields("usuarioNombre").Value
					
					Frame1.Text = "Modificar Usuario"
					Frame0.Visible = False
					Frame1.Visible = True
					TreeView1.Visible = True
					TreeView1.Refresh()
					Botones_Set(False)
					Text1(0).Enabled = False
					Text1(1).Focus()
					Call Edit_Men(AdoReg2.Fields("usuariocodigo").Value)
					
					'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
					System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
				Else
					MsgBox("Debe seleccionar un Registro para editarlo", MsgBoxStyle.Information)
					Botones_Set(False)
					cmdBotones_Click(cmdBotones.Item(5), New System.EventArgs())
				End If
				
			Case 3 'Eliminar
				op = MsgBox("Esta Seguro que desea Eliminar el registro actual ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Eliminación de Registro")
				If op = MsgBoxResult.Yes Then
					'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Adoreg1.Bookmark. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					AdoReg2.Bookmark = Adoreg1.Bookmark
					VGConfig.Execute("Delete From si_menuusuarios Where tipodesistema=" & MainContab.vgtipo & " and  usuariocodigo = '" & AdoReg2.Fields("usuariocodigo").Value & "'")
					AdoReg2.Delete()
					AdoReg2.UpdateBatch()
					AdoReg2.Requery()
					Adoreg1.Requery()
					If Adoreg1.RecordCount = 0 Then
						Botones_Init(True)
					Else
						Botones_Set(True)
					End If
				End If
				SetDataGrid()
				
			Case 5 'Salir , Cancelar
				If cmdBotones(5).Text = "&Salir" Then
					Me.Close()
				Else
					cmdBotones(5).Text = "&Salir"
					Frame1.Visible = False
					Frame0.Visible = True
					nFra = 0
					If Adoreg1.RecordCount = 0 Then
						Botones_Init(True)
					Else
						Botones_Set(True)
					End If
				End If
		End Select
	End Sub
	
	Private Sub Text1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Text1.Enter
		Dim Index As Short = Text1.GetIndex(eventSender)
		With Text1(Index)
			.SelectionStart = 0
			.SelectionLength = Len(.Text)
		End With
	End Sub
	
	
	Private Sub Text1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Text1.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Dim Index As Short = Text1.GetIndex(eventSender)
		If KeyAscii = 13 Then
			If Index = 0 Then
				With Adoreg1
					If .RecordCount <> 0 Then
						.MoveFirst()
						.Find("usuariocodigo= '" & UCase(Text1(0).Text) & "'")
						If Not .EOF Then
							Text1(0).Text = ""
							MsgBox("El Usuario ya existe:  Ingrese de nuevo", MsgBoxStyle.Information, "Ingreso de Datos")
							Text1(0).Focus() : GoTo EventExitSub
						End If
					End If
				End With
			End If
			If Index = 2 And Text1(2).Text = "" Then
				MsgBox("No ha ingresado el password", MsgBoxStyle.Information, "Ingreso de Datos")
				Text1(2).Focus() : GoTo EventExitSub
			End If
			If Index = 3 And Text1(3).Text = "" Then
				MsgBox("No ha confirmado el password", MsgBoxStyle.Information, "Ingreso de Datos")
				Text1(3).Focus() : GoTo EventExitSub
			End If
			If RTrim(Text1(3).Text) <> "" Then
				If Text1(2).Text <> Text1(3).Text Then
					MsgBox("La confirmación del password no es mismo", MsgBoxStyle.Information, "Ingreso de Datos")
					Text1(3).Focus() : GoTo EventExitSub
				End If
			End If
			System.Windows.Forms.SendKeys.Send("{tab}")
			KeyAscii = 0
		End If
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Public Sub Botones_Set(ByRef flag As Boolean)
		'flag=false Nuevo; flag=true .etc...
		cmdBotones(0).Enabled = flag 'Nuevo
		cmdBotones(1).Enabled = Not flag 'Grabar
		cmdBotones(2).Enabled = flag 'Editar
		cmdBotones(3).Enabled = flag 'Eliminar
		If flag Then
			cmdBotones(5).Text = "&Salir" 'Salir
		Else
			cmdBotones(5).Text = "&Cancelar"
		End If
	End Sub
	
	Public Sub Botones_Init(ByRef flag As Boolean)
		'flag=false Nuevo; flag=true .etc...
		cmdBotones(0).Enabled = flag 'Nuevo
		cmdBotones(1).Enabled = Not flag 'Grabar
		cmdBotones(2).Enabled = Not flag 'Editar
		cmdBotones(3).Enabled = Not flag 'Eliminar
		cmdBotones(5).Text = "&Salir" 'Salir
	End Sub
	
	Private Sub DataGrid1_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles DataGrid1.ClickEvent
		'UPGRADE_WARNING: Se detectó el uso de Null/IsNull(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
		RegActual = IIf(IsDbNull(DataGrid1.Bookmark), 0, DataGrid1.Bookmark)
	End Sub
	
	Private Sub Cargar_Opc()
		Dim intIndex01 As Object ' Variable para el índice del nodo actual.
		Dim intIndex02 As Object ' Variable para el índice del nodo actual.
		Dim intIndex03 As Object ' Variable para el índice del nodo actual.
		Dim bolVisibleP As Boolean
		Dim bolVisibleS As Boolean
		
		bolVisibleP = True
		bolVisibleS = True
		On Error GoTo err1
		
		ADOMen = New ADODB.Recordset
		SQL = "SELECT * FROM si_menu where tipodesistema=" & MainContab.vgtipo & " ORDER BY MEN_CODIGO"
		ADOMen = VGConfig.Execute(SQL)
		ADOMen.MoveFirst()
		Do While Not ADOMen.EOF
			If Len(ADOMen.Fields("Men_Codigo").Value) = 2 And ADOMen.Fields("Men_Visible").Value Then
				' Agrega un nodo al TreeView y establece sus propiedades.
				'UPGRADE_WARNING: No se puede determinar la ubicación del nodo Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="196D987F-2118-46D0-80D2-92FB2909C206"'
				mNode = TreeView1.Nodes.Insert(1, ADOMen.Fields("Men_Codigo").Value & " ID", ADOMen.Fields("Men_Descri").Value, "Cerrar")
				mNode.Tag = "SI_Menu" ' Identifica la tabla.
				' Establece en la variable intIndex la propiedad Index del
				' objeto Node recién creado. Use esta variable para agregar
				' objetos Node hijos al objeto Node actual.
				
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto intIndex01. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				intIndex01 = mNode.Index
				bolVisibleP = True
				ADOMen.MoveNext()
				
			ElseIf Len(ADOMen.Fields("Men_Codigo").Value) = 2 And ADOMen.Fields("Men_Visible").Value = False Then 
				bolVisibleP = False
				ADOMen.MoveNext()
			End If
			
			If Len(ADOMen.Fields("Men_Codigo").Value) = 4 And ADOMen.Fields("Men_Visible").Value And bolVisibleP Then
				'UPGRADE_WARNING: El comportamiento del método Add ha cambiado Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DBD08912-7C17-401D-9BE9-BA85E7772B99"'
				mNode = TreeView1.Nodes.Find(intIndex01, True)(0).Nodes.Add("")
				mNode.Text = ADOMen.Fields("Men_Descri").Value ' Texto.
				mNode.Name = ADOMen.Fields("Men_Codigo").Value & " ID" ' ID único.
				mNode.ImageKey = "Cerrar" ' Imagen de ImageList.
				
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto intIndex02. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				intIndex02 = mNode.Index
				bolVisibleP = True
				bolVisibleS = True
				
				ADOMen.MoveNext()
				
			Else
				If Len(ADOMen.Fields("Men_Codigo").Value) = 4 And ADOMen.Fields("Men_Visible").Value = False Then
					bolVisibleS = False
					ADOMen.MoveNext()
					If ADOMen.EOF Then Exit Do
					If Len(ADOMen.Fields("Men_Codigo").Value) > 4 Then
						bolVisibleS = False
					ElseIf Len(ADOMen.Fields("Men_Codigo").Value) <= 4 Or bolVisibleP Then 
						bolVisibleS = True
					End If
				ElseIf Len(ADOMen.Fields("Men_Codigo").Value) = 4 And ADOMen.Fields("Men_Visible").Value And bolVisibleP = False Then 
					ADOMen.MoveNext()
				End If
			End If
			
			If Len(ADOMen.Fields("Men_Codigo").Value) = 6 And ADOMen.Fields("Men_Visible").Value And bolVisibleP Then
				If bolVisibleS = True Then
					'UPGRADE_WARNING: El comportamiento del método Add ha cambiado Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DBD08912-7C17-401D-9BE9-BA85E7772B99"'
					mNode = TreeView1.Nodes.Find(intIndex02, True)(0).Nodes.Add("")
					mNode.Text = ADOMen.Fields("Men_Descri").Value ' Texto.
					mNode.Name = ADOMen.Fields("Men_Codigo").Value & " ID" ' ID único.
					mNode.ImageKey = "Cerrar" ' Imagen de ImageList.
					'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto intIndex03. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					intIndex03 = mNode.Index
					bolVisibleS = True
				End If
				ADOMen.MoveNext()
				
			Else
				If Len(ADOMen.Fields("Men_Codigo").Value) = 6 And ADOMen.Fields("Men_Visible").Value = False Then
					bolVisibleS = False
					ADOMen.MoveNext()
					If ADOMen.EOF Then Exit Do
					If Len(ADOMen.Fields("Men_Codigo").Value) > 6 Then
						bolVisibleS = False
					ElseIf Len(ADOMen.Fields("Men_Codigo").Value) <= 6 Or bolVisibleP Then 
						bolVisibleS = True
					End If
				ElseIf Len(ADOMen.Fields("Men_Codigo").Value) = 6 And ADOMen.Fields("Men_Visible").Value And bolVisibleP = False Then 
					ADOMen.MoveNext()
				End If
			End If
			
			If Len(ADOMen.Fields("Men_Codigo").Value) = 8 And ADOMen.Fields("Men_Visible").Value And bolVisibleP Then
				If bolVisibleS = True Then
					'UPGRADE_WARNING: El comportamiento del método Add ha cambiado Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DBD08912-7C17-401D-9BE9-BA85E7772B99"'
					mNode = TreeView1.Nodes.Find(intIndex03, True)(0).Nodes.Add("")
					mNode.Text = ADOMen.Fields("Men_Descri").Value ' Texto.
					mNode.Name = ADOMen.Fields("Men_Codigo").Value & " ID" ' ID único.
					mNode.ImageKey = "Cerrar" ' Imagen de ImageList.
					
					bolVisibleS = True
				End If
				ADOMen.MoveNext()
				
			Else
				If Len(ADOMen.Fields("Men_Codigo").Value) = 8 And ADOMen.Fields("Men_Visible").Value = False Then
					If ADOMen.Fields("Men_Visible").Value = False Then bolVisibleS = False
					ADOMen.MoveNext()
					If ADOMen.EOF Then Exit Do
					If Len(ADOMen.Fields("Men_Codigo").Value) > 8 Then
						bolVisibleS = False
					ElseIf Len(ADOMen.Fields("Men_Codigo").Value) <= 8 Or bolVisibleP Then 
						bolVisibleS = True
					End If
				ElseIf Len(ADOMen.Fields("Men_Codigo").Value) = 8 And ADOMen.Fields("Men_Visible").Value And bolVisibleP = False Then 
					ADOMen.MoveNext()
				End If
			End If
		Loop 
		Exit Sub
err1: 
		'MsgBox err.Description
		Resume Next
	End Sub
	
	Private Sub TREEVIEW1_AfterCollapse(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.TreeViewEventArgs) Handles TREEVIEW1.AfterCollapse
		Dim NODE As System.Windows.Forms.TreeNode = eventArgs.Node
		If NODE.Text = "Menu" Or NODE.Index > 1 Then
			NODE.ImageKey = "Cerrar"
		End If
	End Sub
	
	Private Sub TREEVIEW1_AfterExpand(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.TreeViewEventArgs) Handles TREEVIEW1.AfterExpand
		Dim NODE As System.Windows.Forms.TreeNode = eventArgs.Node
		If NODE.Text = "Menu" Or NODE.Index > 1 Then
			'UPGRADE_WARNING: El límite inferior de la colección TreeView1.Nodes cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
			If TreeView1.Nodes.Item(NODE.Index).GetNodeCount(False) > 0 Then
				If NODE.Checked = False Then
					NODE.ImageKey = "Cerrar"
					NODE.Collapse()
				Else
					NODE.ImageKey = "Abrir"
				End If
			End If

		End If
	End Sub
	
	Private Sub Carga_Valor(ByRef nIni As Short, ByRef nfin As Short, ByRef bFlag As Boolean, ByRef nG As Short, Optional ByRef cCod As String = "")
		If nG = 1 Then
			For nI = nIni To nfin
				'UPGRADE_WARNING: El límite inferior de la colección TreeView1.Nodes cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				TreeView1.Nodes.Item(nI).Checked = bFlag
			Next nI
		ElseIf nG = 2 Then 
			For nI = nIni To nfin
				'UPGRADE_WARNING: El límite inferior de la colección TreeView1.Nodes cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				If Mid(TreeView1.Nodes.Item(nI).Name, 1, Len(RTrim(cCod))) = RTrim(cCod) Then
					'UPGRADE_WARNING: El límite inferior de la colección TreeView1.Nodes cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
					TreeView1.Nodes.Item(nI).Checked = bFlag
				End If
			Next nI
		End If
	End Sub
	
	Private Sub TreeView1_AfterCheck(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterCheck
		Dim NODE As System.Windows.Forms.TreeNode = eventArgs.Node
		If NODE.Index = 1 Then
			'UPGRADE_ISSUE: MSComctlLib.NODE propiedad NODE.Root no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            If NODE.Checked = True Then
                'UPGRADE_ISSUE: MSComctlLib.NODE propiedad NODE.Root no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                Call Carga_Valor(1, TreeView1.Nodes.Count, NODE.Checked, 1)
                NODE.Expand()
            Else
                NODE.Collapse()
            End If
		Else
			'UPGRADE_WARNING: El límite inferior de la colección TreeView1.Nodes cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
			If TreeView1.Nodes.Item(NODE.Index).GetNodeCount(False) > 0 Then
				If NODE.Checked = False Then
					'UPGRADE_WARNING: El límite inferior de la colección TreeView1.Nodes cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
					Call Carga_Valor(NODE.Index + 1, TreeView1.Nodes.Count, False, 2, Mid(TreeView1.Nodes.Item(NODE.Index).Name, 1, InStr(TreeView1.Nodes.Item(NODE.Index).Name, " ID")))
					NODE.Collapse()
				Else
					'UPGRADE_WARNING: El límite inferior de la colección TreeView1.Nodes cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
					Call Carga_Valor(NODE.Index + 1, TreeView1.Nodes.Count, True, 2, Mid(TreeView1.Nodes.Item(NODE.Index).Name, 1, InStr(TreeView1.Nodes.Item(NODE.Index).Name, " ID")))
					NODE.Expand()
				End If
			End If
		End If
	End Sub
	
	
	Private Sub Grab_Men(ByRef cCod As String)
		Dim cCad As String
		Dim nIi As Short
		Dim nOp As Short
		On Error GoTo err1
		nIi = 2
		ADOMen.MoveFirst()
		AdoUsu = New ADODB.Recordset
		SQL = "delete si_menuusuarios Where tipodesistema=" & MainContab.vgtipo & " and usuariocodigo = '" & cCod & "'"
		AdoUsu = VGConfig.Execute(SQL)
		Do While Not ADOMen.EOF
			'UPGRADE_WARNING: El límite inferior de la colección TreeView1.Nodes cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
			If TreeView1.Nodes.Item(1).Checked Then 'Raiz
				'UPGRADE_WARNING: El límite inferior de la colección TreeView1.Nodes cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				If TreeView1.Nodes.Item(nIi).Name = ADOMen.Fields("Men_Codigo").Value & " ID" And ADOMen.Fields("Men_Visible").Value Then
					nOp = 2
					SQL = "Select * From si_menuusuarios Where tipodesistema=" & MainContab.vgtipo & " and usuariocodigo = '" & cCod & "' and Men_Codigo = '" & ADOMen.Fields("Men_Codigo").Value & "'"
					AdoUsu.Open(SQL, VGConfig, ADODB.CursorTypeEnum.adOpenStatic)
					If AdoUsu.RecordCount > 0 Then
						nOp = 1
					End If
					AdoUsu.Close()
					
					If nOp = 2 Then
						SQL = "Insert Into si_menuusuarios (usuariocodigo,tipodesistema,Men_Codigo,Men_Hab) Values ('" & cCod & "'," & MainContab.vgtipo & ",'" & ADOMen.Fields("Men_Codigo").Value & "',"
						'UPGRADE_WARNING: El límite inferior de la colección TreeView1.Nodes cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
						If TreeView1.Nodes.Item(nIi).Checked = True Then
							SQL = SQL & "1" & ")"
						Else
							SQL = SQL & "0" & ")"
						End If
					Else
						SQL = "Update si_menuusuarios Set Men_Hab = "
						'UPGRADE_WARNING: El límite inferior de la colección TreeView1.Nodes cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
						If TreeView1.Nodes.Item(nIi).Checked = True Then
							SQL = SQL & "1"
						Else
							SQL = SQL & "0"
						End If
						SQL = SQL & " Where tipodesistema=" & MainContab.vgtipo & " and usuariocodigo = '" & cCod & "' and Men_Codigo = '" & ADOMen.Fields("Men_Codigo").Value & "'"
					End If
					VGConfig.Execute(SQL)
					nIi = nIi + 1
					ADOMen.MoveNext()
					
				Else
					'UPGRADE_WARNING: El límite inferior de la colección TreeView1.Nodes cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
					If TreeView1.Nodes.Item(nIi).Name = "" Then
						nIi = nIi + 1
					Else
						ADOMen.MoveNext()
					End If
				End If
				
			Else
				nIi = 0
				Exit Do
			End If
			
			
		Loop 
		If nIi >= 2 Then
			MsgBox("Se ha grabado completamente las opciones escogidas", MsgBoxStyle.Information, "Mensaje")
		Else
			MsgBox("No se ha grabado las opciones", MsgBoxStyle.Information, "Verificar")
		End If
		Exit Sub
err1: 
		MsgBox(Err.Description)
		Exit Sub
		Resume 
	End Sub
	
	Private Sub Edit_Men(ByRef cCodU As String)
		Dim ADOUsMe As ADODB.Recordset
		Dim nJ As Short
		ADOUsMe = New ADODB.Recordset
		
		For nJ = 1 To TreeView1.Nodes.Count
			'UPGRADE_WARNING: El límite inferior de la colección TreeView1.Nodes cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
			TreeView1.Nodes.Item(nJ).Checked = False
			'UPGRADE_WARNING: El límite inferior de la colección TreeView1.Nodes cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
			TreeView1.Nodes.Item(nJ).Collapse()
		Next nJ
		
		ADOUsMe.Open("SELECT * FROM si_menuusuarios  WHERE tipodesistema=" & MainContab.vgtipo & " and usuariocodigo = '" & cCodU & "' ", VGConfig, ADODB.CursorTypeEnum.adOpenStatic)
		If ADOUsMe.RecordCount > 0 Then ADOUsMe.MoveFirst()
		If Not ADOUsMe.EOF Then
			'UPGRADE_WARNING: El límite inferior de la colección TreeView1.Nodes cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
			TreeView1.Nodes.Item(1).Checked = True 'Raiz
			Do While Not ADOUsMe.EOF
				For nJ = 2 To TreeView1.Nodes.Count
					'UPGRADE_WARNING: El límite inferior de la colección TreeView1.Nodes cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
					If TreeView1.Nodes.Item(nJ).Name = ADOUsMe.Fields("MEN_CODIGO").Value & " ID" Then
						If ADOUsMe.Fields("Men_Hab").Value Then
							'UPGRADE_WARNING: El límite inferior de la colección TreeView1.Nodes cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
							TreeView1.Nodes.Item(nJ).Checked = True
						Else
							'UPGRADE_WARNING: El límite inferior de la colección TreeView1.Nodes cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
							TreeView1.Nodes.Item(nJ).Checked = False
						End If
						Exit For
					End If
				Next nJ
				ADOUsMe.MoveNext()
				If ADOUsMe.EOF Then Exit Do
			Loop 
		Else
			'UPGRADE_WARNING: El límite inferior de la colección TreeView1.Nodes cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
			TreeView1.Nodes.Item(1).Checked = False
		End If
		'UPGRADE_WARNING: El límite inferior de la colección TreeView1.Nodes cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
		If TreeView1.Nodes.Item(1).Checked Then
			'UPGRADE_WARNING: El límite inferior de la colección TreeView1.Nodes cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
			TreeView1.Nodes.Item(1).Expand()
		Else
			'UPGRADE_WARNING: El límite inferior de la colección TreeView1.Nodes cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
			TreeView1.Nodes.Item(1).Collapse()
		End If
		TreeView1.Refresh()
	End Sub
End Class