Option Strict Off
Option Explicit On
Friend Class ClassMenu
	Public TablaUsu As String
	Public TabaMenuDet As String
	Public TablaMenu As String
	Public Conexion As New ADODB.Connection
	Dim Contr As System.Windows.Forms.Control
	Public Sub CrearTablasSeguridad()
		Dim SQL As String
		'Crear Tabla Usuarios
		If Not ExisteElem(0, Conexion, TablaUsu) Then
			SQL = "" & " Create Table " & TablaUsu & " ( " & " usuariocodigo Text(5)  , Emp_Codigo Text(15) , UsuarioPassword Text(8), " & " Usu_Nivel Text(1), usuarioNombre Text(32), " & " CONSTRAINT Clave " & " PRIMARY KEY (usuariocodigo, Emp_Codigo)) "
			Conexion.Execute(SQL)
		End If
		'Crea Tabla Detalle de Menu Usuarios
		If Not ExisteElem(0, Conexion, TabaMenuDet) Then
			SQL = "" & " Create Table " & TabaMenuDet & " ( " & " usuariocodigo Text(5)  , Emp_Codigo Text(15) , Men_Codigo Text(10), " & " Men_Hab bit, " & " CONSTRAINT Clave " & " PRIMARY KEY (usuariocodigo, Emp_Codigo,Men_Codigo)) "
			Conexion.Execute(SQL)
		End If
	End Sub
	Public Sub CrearTablaMenu()
		Dim SQL As String
		Dim Contr As System.Windows.Forms.Control
		Dim rsaux As New ADODB.Recordset
		Dim ContNiv() As Short
		Dim I, Niv, J As Short
		Dim CodigoMenu As String
		On Error GoTo errortab
		'*------------------------------------------------------------------*
		If Not ExisteElem(0, VGConfig, TablaMenu) Then
			SQL = " Create Table " & TablaMenu & " (tipodesistema int,Men_Codigo varchar(20),Men_Descri varchar(64), " & " Men_CodEdit varchar(48),  " & " CONSTRAINT Clave PRIMARY KEY (tipodesistema,Men_Codigo))"
			VGConfig.Execute(SQL)
		Else
			VGConfig.Execute("Delete From " & TablaMenu & " where tipodesistema=" & MainContab.VGtipo)
		End If
		'Redimensionando los Niveles
		ReDim ContNiv(MaxNivel + 1) 'MaxNivel : Funcion que determina el maximo nivel en el menu
		'*Armando El Menu
		'UPGRADE_NOTE: El objeto rsaux no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rsaux = Nothing
		rsaux.Open(TablaMenu, VGConfig, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
		For	Each Contr In MDIPrincipal.Controls
			'UPGRADE_WARNING: TypeOf tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
            If TypeOf Contr Is System.Windows.Forms.MenuStrip Then
                If Contr.Visible And RTrim(Contr.Text) <> "-" And UCase(RTrim(Contr.Text)) <> "Salir" Then
                    Niv = NumChar((Contr.Name), "_")
                    For I = Niv To Niv
                        ContNiv(I) = ContNiv(I) + 1
                        For J = Niv + 1 To UBound(ContNiv) - 1
                            ContNiv(J) = 0
                        Next
                    Next
                    rsaux.AddNew()
                    CodigoMenu = ""
                    For I = 0 To UBound(ContNiv) - 1
                        CodigoMenu = CodigoMenu & IIf(ContNiv(I) > 0, VB6.Format(ContNiv(I), "00"), "")
                    Next
                    rsaux.Fields("tipodesistema").Value = MainContab.VGtipo
                    rsaux.Fields("Men_CodIGO").Value = RTrim(CodigoMenu)
                    'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto DevCad(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    rsaux.Fields("Men_Descri").Value = DevCad("&", (Contr.Text))
                    rsaux.Fields("Men_CodEdit").Value = RTrim(Contr.Name)

                    rsaux.Fields("Men_Visible").Value = -1

                    rsaux.Update()
                End If
            End If
		Next Contr
		Exit Sub
errortab: 
		'MsgBox "Error : " & Err.Number & "  " & Err.Description, vbExclamation
		Resume Next
	End Sub
	Private Function MaxNivel() As Short
		Dim Cont, Aux As Short
		MaxNivel = 0
		'*---------------------------------*
		For	Each Contr In MDIPrincipal.Controls
			'UPGRADE_WARNING: TypeOf tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
            If TypeOf Contr Is System.Windows.Forms.MenuStrip Then
                If Contr.Visible And RTrim(Contr.Text) <> "-" And UCase(RTrim(Contr.Text)) <> "SALIR" Then
                    Aux = NumChar((Contr.Name), "_")
                    If MaxNivel < Aux Then MaxNivel = Aux
                End If
            End If
		Next Contr
	End Function
	Public Function NumChar(ByRef cadena As String, ByRef Caracter As String) As Short
		'Funcion Creada por Fernando Cossio
		Dim I, Cont As Short
		Cont = 0
		For I = 1 To Len(cadena)
			If UCase(Caracter) = Mid(cadena, I, 1) Then
				Cont = Cont + 1
			End If
		Next 
		NumChar = Cont
	End Function
	Public Function DevCad(ByRef CaraterNo As String, ByRef cadena As String) As Object
		'Devuelve toda la cadena sin el caracter espcificado en el parametro
		'Funcion creada por fernando cossio
		Dim I As Short
		Dim acum As Object
		Dim Cont As String
		
		For I = 1 To Len(cadena)
			If UCase(CaraterNo) <> Mid(cadena, I, 1) Then
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto acum. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				acum = acum + Mid(cadena, I, 1)
			End If
		Next 
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto acum. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto DevCad. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		DevCad = acum
	End Function
	Public Sub HabilitarMenuNom(ByRef Usuario As String)
		'Procedimiento creado por Fernando Cossio
		Dim RsMenUsu As New ADODB.Recordset
		Dim SQL As String
		SQL = " SELECT a.usuariocodigo, b.Men_CodEdit, a.MEN_HAB From " & TabaMenuDet & " a "
		SQL = SQL & " left join " & TablaMenu & " b on a.tipodesistema=b.tipodesistema and a.MEN_CODIGO=b.Men_Codigo "
		SQL = SQL & " where a.usuariocodigo='" & Usuario & "' and a.tipodesistema=" & MainContab.VGtipo & ""
		RsMenUsu = VGConfig.Execute(SQL)
		Dim n As String
		If RsMenUsu.RecordCount = 0 Then Exit Sub
		RsMenUsu.MoveFirst()
		Do While Not RsMenUsu.EOF
			For	Each Contr In MDIPrincipal.Controls
				'UPGRADE_WARNING: TypeOf tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
                If TypeOf Contr Is System.Windows.Forms.MenuStrip Then
                    n = Contr.Name
                    'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    If UCase(n) = UCase(ESNULO(RsMenUsu.Fields("Men_CodEdit"), 1)) Then
                        Contr.Enabled = IIf(RsMenUsu.Fields("MEN_HAB").Value, True, False)
                        Exit For
                    End If
                End If
			Next Contr
			RsMenUsu.MoveNext()
		Loop 
	End Sub
	Public Sub MenuTrue()
		'Procedimiento creado por Fernando Cossio
		For	Each Contr In MDIPrincipal.Controls
			'UPGRADE_WARNING: TypeOf tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
            If TypeOf Contr Is System.Windows.Forms.MenuStrip Then
                Contr.Enabled = True
            End If
		Next Contr
	End Sub
End Class