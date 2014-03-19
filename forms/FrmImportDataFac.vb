Option Strict Off
Option Explicit On
Friend Class FrmImportDataFac
	Inherits System.Windows.Forms.Form
	'FIXIT: Utilice Option Explicit para evitar la creación implícita de variables de tipo Variant.     FixIT90210ae-R383-H1984
	Dim sqlcad As String
	Dim cnxtrans As ADODB.Connection
	Dim rstrans As ADODB.Recordset
	Dim NombreArchivo As String
	Dim SerieSubAsiento(10) As String
	Private Sub CmdArchivo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdArchivo.Click
		'UPGRADE_WARNING: Filter tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		cmdg_archivoOpen.Filter = "Archivos de Exportacion|EXPO*.EX"
		cmdg_archivoOpen.ShowDialog()
		NombreArchivo = cmdg_archivoOpen.FileName
		'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		TxArchivo.CtlText = NombreArchivo
	End Sub
	Private Sub cmdCancelar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancelar.Click
		Me.Close()
	End Sub
	Private Sub CmdProcesar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdProcesar.Click
		Dim paso As Object
		Dim Comando As Object
		Dim procedimiento As Object
		Dim rsparimpo As ADODB.Recordset
        Dim BaseOrigen As String = ""
		Dim paso1 As Short
		Dim procedimento As String
		On Error GoTo Proceso
		'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		
		paso1 = 1
		
		rsparimpo = New ADODB.Recordset
		rsparimpo = VGCNx.Execute(" select * from ct_importarventas")
		If Opt(0).Checked = True Then
			If ChkRest.CheckState = 1 Then
				If Not Restaurar Then
					'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
					System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
					Exit Sub
				End If
			End If
			BaseOrigen = "TRANSFER" & Trim(Mid(VB6.GetItemString(cboSerie, cboSerie.SelectedIndex), 7, 3))
		End If
		If rsparimpo.RecordCount = 0 Then Exit Sub
		If Opt(1).Checked = True Then
			BaseOrigen = rsparimpo.Fields("BaseVenta").Value
		End If
		paso1 = rsparimpo.Fields("asientofacturacion").Value
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto procedimiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		procedimiento = ESNULO(rsparimpo.Fields("procedimientoasiento"), "")
		Comando = New ADODB.Command
		'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		'@BaseConta, @BaseVenta, @Ano, @Mes, @tipanal, @User
		VGGeneral.BeginTrans()
		With Comando
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.CommandType. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.CommandText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.CommandText = "vt_insertacliente"
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.ActiveConnection. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.ActiveConnection = VGGeneral.ConnectionString
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters.Refresh()
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@BaseConta") = VGParamSistem.BDEmpresa
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@BaseVenta") = BaseOrigen
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@Mes") = VB6.Format(Month(DTPPerido.Value), "00")
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@Ano") = Year(DTPPerido.Value)
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@tipanal") = rsparimpo.Fields("tipanal").Value
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@User") = VGParamSistem.Usuario
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Execute. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Execute()
		End With
		Comando = New ADODB.Command
		If paso1 = 1 Then
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto procedimiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If procedimiento = "" Then procedimiento = "vt_generaasiento1_pro"
			With Comando
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.CommandType. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.CommandText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto procedimiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.CommandText = "" & procedimiento & "" ' "vt_generaasiento1_pro"
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.ActiveConnection. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.ActiveConnection = VGGeneral.ConnectionString
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.Parameters.Refresh()
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.Parameters("@BaseConta") = VGParamSistem.BDEmpresa
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.Parameters("@BaseVenta") = VGParamSistem.BDEmpresa
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.Parameters("@BaseParam") = rsparimpo.Fields("BaseVenta").Value
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.Parameters("@empresa") = VGParametros.empresacodigo
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.Parameters("@Libro") = rsparimpo.Fields("Libro").Value
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.Parameters("@Mes") = VB6.Format(Month(DTPPerido._Value), "00")
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.Parameters("@Ano") = Year(DTPPerido._Value)
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.Parameters("@ctasoles") = rsparimpo.Fields("cuentasoles").Value
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.Parameters("@ctadolares") = rsparimpo.Fields("cuentadolares").Value
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.Parameters("@ctaIGV") = rsparimpo.Fields("ctaigv").Value
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.Parameters("@tipanal") = rsparimpo.Fields("tipanal").Value
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.Parameters("@Compu") = VGcomputer
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.Parameters("@Usuario") = VGParamSistem.Usuario
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Execute. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.Execute()
			End With
		Else
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto procedimiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If procedimiento = "" Then procedimiento = "vt_generaasiento_pro"
			With Comando
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.CommandType. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.CommandText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto procedimiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.CommandText = "" & procedimiento & "" '  "vt_generaasiento_pro"
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.ActiveConnection. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.ActiveConnection = VGGeneral.ConnectionString
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.Parameters.Refresh()
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.Parameters("@BaseConta") = VGParamSistem.BDEmpresa
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.Parameters("@BaseVenta") = BaseOrigen
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.Parameters("@BaseParam") = rsparimpo.Fields("BaseVenta").Value
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.Parameters("@empresa") = VGParametros.empresacodigo
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.Parameters("@Libro") = rsparimpo.Fields("Libro").Value
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.Parameters("@Mes") = VB6.Format(Month(DTPPerido._Value), "00")
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.Parameters("@Ano") = Year(DTPPerido._Value)
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.Parameters("@ctatotal") = rsparimpo.Fields("ctatotal").Value
				'        .Parameters("@ctasoles") = rsparimpo!cuentasoles
				'        .Parameters("@ctadolares") = rsparimpo!cuentadolares
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.Parameters("@ctaIGV") = rsparimpo.Fields("ctaigv").Value
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.Parameters("@tipanal") = rsparimpo.Fields("tipanal").Value
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.Parameters("@Compu") = VGcomputer
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.Parameters("@Usuario") = VGParamSistem.Usuario
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Execute. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				.Execute()
			End With
		End If
		VGGeneral.CommitTrans()
		'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
		MsgBox("La Operacion se Realizo Satisfactoriamente", MsgBoxStyle.Information, "Sistema de Ventas")
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto paso. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		paso = 0
		Exit Sub
Proceso: 
		'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
		MsgBox(Err.Description)
		VGGeneral.RollbackTrans()
		Exit Sub
		Resume 
	End Sub
	Private Function Restaurar() As Boolean
		Dim Data(1) As String
		Dim Log(1) As String
		Dim I As Short
		Restaurar = False
		On Error GoTo restarurar
		cnxtrans = New ADODB.Connection
		With cnxtrans
			.CursorLocation = ADODB.CursorLocationEnum.adUseClient
			.CommandTimeout = 0
			.ConnectionTimeout = 0
			.ConnectionString = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=" & VGParamSistem.Usuario & ";Password=" & VGParamSistem.Pwd & ";Initial Catalog=TRANSFER;Data Source=" & VGParamSistem.Servidor
			.Open()
		End With
		rstrans = New ADODB.Recordset
		rstrans.Open("Select name,filename From SysFiles ", cnxtrans, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
		rstrans.MoveFirst()
		Data(0) = rstrans.Fields("Name").Value : Data(1) = rstrans.Fields("FileName").Value
		rstrans.MoveNext()
		Log(0) = rstrans.Fields("Name").Value : Log(1) = rstrans.Fields("FileName").Value
Reintento: 
		MsgBox("Se procede a Restaurar", MsgBoxStyle.Information)
		'UPGRADE_NOTE: El objeto cnxtrans no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		cnxtrans = Nothing
		'UPGRADE_NOTE: El objeto rstrans no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		rstrans = Nothing
		MsgBox("Se procede a Restaurar", MsgBoxStyle.Information)
		sqlcad = " RESTORE DATABASE TRANSFER " & " FROM DISK='" & NombreArchivo & "'" & " WITH RECOVERY,  " & " Move '" & Trim(Data(0)) & "' TO '" & Trim(Data(1)) & "', " & " Move '" & Trim(Log(0)) & "' TO  '" & Trim(Log(1)) & "' "
		VGGeneral.Execute(sqlcad)
		Restaurar = True
		MsgBox("Se Restauro Satisfactoriamente", MsgBoxStyle.Information)
		Exit Function
restarurar: 
		If MsgBox("Desea Reintentar la Restauracion", MsgBoxStyle.Question + MsgBoxStyle.RetryCancel) = MsgBoxResult.Retry Then
			GoTo Reintento
		End If
		Restaurar = False
		MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Error al restauar")
	End Function
	
	Private Sub FrmImportDataFac_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		DTPPerido.Month = CShort(VGParamSistem.Mesproceso)
		DTPPerido.Year = CShort(VGParamSistem.Anoproceso)
		Opt(1).Checked = True
		Call LlenarCboSeries()
	End Sub
	
	'UPGRADE_WARNING: El evento Opt.CheckedChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub Opt_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Opt.CheckedChanged
		If eventSender.Checked Then
			Dim Index As Short = Opt.GetIndex(eventSender)
			Select Case Index
				Case 0
					CmdArchivo.Enabled = True
					cboSerie.Enabled = True
				Case 1
					CmdArchivo.Enabled = False
					cboSerie.Enabled = False
			End Select
		End If
	End Sub
	
	Sub LlenarCboSeries()
		cboSerie.Items.Add("Serie 001")
		cboSerie.Items.Add("Serie 002")
		cboSerie.Items.Add("Serie 003")
		cboSerie.Items.Add("Serie 004")
		cboSerie.Items.Add("Serie 006")
		cboSerie.Items.Add("Serie 008")
		cboSerie.Items.Add("Serie 009")
		cboSerie.Items.Add("Serie 011")
		cboSerie.Items.Add("Serie 012")
		cboSerie.Items.Add("Serie 013")
		
		SerieSubAsiento(0) = "0010"
		SerieSubAsiento(1) = "0009"
		SerieSubAsiento(2) = "0004"
		SerieSubAsiento(3) = "0001"
		SerieSubAsiento(4) = "0002"
		SerieSubAsiento(5) = "0008"
		SerieSubAsiento(6) = "0007"
		SerieSubAsiento(7) = "0003"
		SerieSubAsiento(8) = "0005"
		SerieSubAsiento(9) = "0006"
		cboSerie.SelectedIndex = -1
		
	End Sub
End Class