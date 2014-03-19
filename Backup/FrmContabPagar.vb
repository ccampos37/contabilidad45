Option Strict Off
Option Explicit On
Friend Class FrmContabPagar
	Inherits System.Windows.Forms.Form
	'FIXIT: Utilice Option Explicit para evitar la creación implícita de variables de tipo Variant.     FixIT90210ae-R383-H1984
	Dim sqlcad As String
	Dim cnxtrans As ADODB.Connection
	Dim rstrans As ADODB.Recordset
	Dim NombreArchivo As String
	
	Private Sub FrmContabPagar_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		DTPPerido.Month = CShort(VGParamSistem.Mesproceso)
		DTPPerido.Year = CShort(VGParamSistem.Anoproceso)
		Opt(0).Enabled = False
		Opt(1).Checked = True
	End Sub
	
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
		Dim Comando As Object
		Dim rsparimpo As ADODB.Recordset
		Dim BaseOrigen As String
		Dim paso1 As Short
		On Error GoTo Proceso
		'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		
		paso1 = 0
		
		rsparimpo = New ADODB.Recordset
		rsparimpo.Open("ct_importarPagar", VGCNx, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
		If rsparimpo.RecordCount = 0 Then Exit Sub
		If Opt(0).Checked = True Then
			If ChkRest.CheckState = 1 Then
				If Not Restaurar Then
					'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
					System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
					Exit Sub
				End If
			End If
			BaseOrigen = "TRANSFER"
		End If
		
		
		Call DeleteDataPlanillaCobrar(rsparimpo.Fields("asientocodigo").Value, rsparimpo.Fields("subasientocodigo").Value, CShort(VB6.Format(Month(DTPPerido._Value), "00")), CStr(Year(DTPPerido._Value)))
		
		'  MsgBox (" Contabilizando Aplicaciones ")
		
		VGGeneral.BeginTrans()
		Comando = New ADODB.Command
		With Comando
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.CommandType. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.CommandText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.CommandText = "cp_GeneraAsientoPagarenLinea_pro"
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.ActiveConnection. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.ActiveConnection = VGGeneral.ConnectionString
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters.Refresh()
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@BaseConta") = VGParamSistem.BDEmpresa
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@BaseVenta") = VGParamSistem.BDEmpresa
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@empresa") = VGParametros.empresacodigo
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@Asiento") = rsparimpo.Fields("asientocodigo").Value
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@SubAsiento") = rsparimpo.Fields("subasientocodigo").Value
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@Libro") = rsparimpo.Fields("Librocodigo").Value
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@Mes") = VB6.Format(Month(DTPPerido._Value), "00")
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@Ano") = Year(DTPPerido._Value)
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@tipanal") = "001"
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@Compu") = VGcomputer
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@Usuario") = VGParamSistem.Usuario
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@ajustedebe") = VGParametros.sistemactaajustedeb
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@ajustehaber") = VGParametros.sistemactaajustehab
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Execute. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Execute()
		End With
		VGGeneral.CommitTrans()
		
		' MsgBox (" Contabilizando Canjes  ")
		
		VGGeneral.BeginTrans()
		Comando = New ADODB.Command
		With Comando
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.CommandType. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.CommandText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.CommandText = "cp_GeneraAsientoPagarenLinea1_pro"
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.ActiveConnection. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.ActiveConnection = VGGeneral.ConnectionString
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters.Refresh()
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@BaseConta") = VGParamSistem.BDEmpresa
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@BaseVenta") = VGParamSistem.BDEmpresa
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@empresa") = VGParametros.empresacodigo
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@Asiento") = rsparimpo.Fields("asientocodigo").Value
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@SubAsiento") = rsparimpo.Fields("subasientocodigo").Value
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@Libro") = rsparimpo.Fields("Librocodigo").Value
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@Mes") = VB6.Format(Month(DTPPerido._Value), "00")
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@Ano") = Year(DTPPerido._Value)
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@tipanal") = "001"
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@Compu") = VGcomputer
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@Usuario") = VGParamSistem.Usuario
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@ajustedebe") = VGParametros.sistemactaajustedeb
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@ajustehaber") = VGParametros.sistemactaajustehab
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Execute. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Execute()
		End With
		VGGeneral.CommitTrans()
		
		' MsgBox (" Contabilizando Compensaciones ")
		
		VGGeneral.BeginTrans()
		Comando = New ADODB.Command
		With Comando
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.CommandType. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.CommandText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.CommandText = "cp_GeneraAsientoPagarenLinea2_pro"
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.ActiveConnection. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.ActiveConnection = VGGeneral.ConnectionString
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters.Refresh()
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@BaseConta") = VGParamSistem.BDEmpresa
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@BaseVenta") = VGParamSistem.BDEmpresa
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@empresa") = VGParametros.empresacodigo
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@Asiento") = rsparimpo.Fields("asientocodigo").Value
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@SubAsiento") = rsparimpo.Fields("subasientocodigo").Value
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@Libro") = rsparimpo.Fields("Librocodigo").Value
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@Mes") = VB6.Format(Month(DTPPerido._Value), "00")
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@Ano") = Year(DTPPerido._Value)
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@tipanal") = "001"
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@Compu") = VGcomputer
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@Usuario") = VGParamSistem.Usuario
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@ajustedebe") = VGParametros.sistemactaajustedeb
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Parameters. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Parameters("@ajustehaber") = VGParametros.sistemactaajustehab
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Comando.Execute. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.Execute()
		End With
		VGGeneral.CommitTrans()
		'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
		MsgBox("La Operacion se Realizo Satisfactoriamente", MsgBoxStyle.Information, "Sistema de Ventas")
		Me.Close()
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
		Dim i As Short
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
	
	'UPGRADE_WARNING: El evento Opt.CheckedChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub Opt_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Opt.CheckedChanged
		If eventSender.Checked Then
			Dim Index As Short = Opt.GetIndex(eventSender)
			Select Case Index
				Case 0
					CmdArchivo.Enabled = True
				Case 1
					CmdArchivo.Enabled = False
			End Select
		End If
	End Sub
	
	Sub DeleteDataPlanillaCobrar(ByRef Asiento As String, ByRef SubAsiento As String, ByRef mes As Short, ByRef anno As String)
		Dim SQL As String
		
		SQL = "DELETE FROM ct_cabcomprob" & anno & " where asientocodigo='" & Asiento & "' AND "
		SQL = SQL & "subasientocodigo='" & SubAsiento & "' AND "
		SQL = SQL & "cabcomprobmes=" & mes & " and empresacodigo='" & VGParametros.empresacodigo & "'"
		VGCNx.Execute(SQL)
		
	End Sub
End Class