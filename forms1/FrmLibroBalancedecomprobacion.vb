Option Strict Off
Option Explicit On
Friend Class FrmLibroBalancedeComprobacion
	Inherits System.Windows.Forms.Form
	'FIXIT: Utilice Option Explicit para evitar la creación implícita de variables de tipo Variant.     FixIT90210ae-R383-H1984
	Dim RsFiltro As ADODB.Recordset
	Dim lforma As Short
	
	'UPGRADE_WARNING: El evento ChkFiltcta.CheckStateChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub ChkFiltcta_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ChkFiltcta.CheckStateChanged
		If ChkFiltcta.CheckState = 1 Then
			'UPGRADE_NOTE: Enabled se actualizó a CtlEnabled. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			CtrAyu_Cuenta.CtlEnabled = True
		Else
			'UPGRADE_NOTE: Enabled se actualizó a CtlEnabled. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			CtrAyu_Cuenta.CtlEnabled = False
		End If
	End Sub
	Private Sub cmdAceptar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAceptar.Click
		'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		Call imprimir()
		'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
	End Sub
	
	Private Sub cmdCancelar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancelar.Click
		Me.Close()
	End Sub
	
	Private Sub FrmLibroBalancedeComprobacion_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Call CargaNivel()
		Call CargaRsFiltro()
		Call CtrAyu_Moneda.conexion(VGCNx)
		Call CtrAyu_Cuenta.conexion(VGCNx)
		CtrAyu_Moneda.xclave = VGParametros.monedabase : CtrAyu_Moneda.Ejecutar()
		OptForma(1).Checked = True
		OpTipo(0).Checked = True
		DTPicker1.Value = DateSerial(CShort(VGParamSistem.Anoproceso), CShort(VGParamSistem.Mesproceso), 1)
	End Sub
	Private Sub CargaNivel()
		Dim i As Short
		For i = 1 To VGnumnivelescuenta
			cmbNivel.Items.Add(VB6.Format(i, "0"))
		Next 
		cmbNivel.SelectedIndex = 0
	End Sub
	Private Sub CargaRsFiltro()
		RsFiltro = New ADODB.Recordset
		RsFiltro.Fields.Append("Cod", ADODB.DataTypeEnum.adVarChar, 2)
		RsFiltro.Fields.Append("Descr", ADODB.DataTypeEnum.adVarChar, 50)
		RsFiltro.Open()
		RsFiltro.AddNew()
		RsFiltro.Fields("Cod").Value = "0"
		RsFiltro.Fields("Descr").Value = "Todos las cuentas"
		RsFiltro.Update()
		RsFiltro.AddNew()
		RsFiltro.Fields("Cod").Value = "1"
		RsFiltro.Fields("Descr").Value = "Cuenta con Movimientos y Saldos Acumulados"
		RsFiltro.Update()
		DtCfiltro.RowSource = RsFiltro
		DtCfiltro.BoundText = "1"
	End Sub
	Public Sub imprimir()
		Dim arrform(2) As Object
		Dim arrparm(11) As Object
		Dim mon As String
		If CtrAyu_Moneda.xclave = "01" Then
			mon = CStr(1)
		Else
			mon = CStr(2)
		End If
		'@Base, @Anno, @Mes, @Nivel, @NoEnCascada, @Corden, @opvista
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(0) = VGParamSistem.BDEmpresa
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(1). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(1) = VGParametros.empresacodigo
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(2). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(2) = VGParamSistem.Anoproceso
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(3). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(3) = VB6.Format(Month(DTPicker1._Value), "0") 'VGParamSistem.Mesproceso
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(4). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(4) = CShort(cmbNivel.Text)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(5). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(5) = IIf(ChkCascada.CheckState = 1, 0, 1)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(6). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(6) = "left(Cuenta,2) Asc,Nivel Desc"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(7). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(7) = CShort(DtCfiltro.BoundText)
		If ChkFiltcta.CheckState = 1 Then
			If CtrAyu_Cuenta.xclave = "" Then
				MsgBox("Debe escoger una cuenta ", MsgBoxStyle.Information)
				Exit Sub
			End If
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(8). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			arrparm(8) = VB6.Format(Len(Trim(CtrAyu_Cuenta.xclave)), "0")
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(9). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			arrparm(9) = Trim(CtrAyu_Cuenta.xclave) & "%"
		Else
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(8). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			arrparm(8) = 0
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(9). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			arrparm(9) = 0
		End If
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(10). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(10) = IIf(VGParametros.sistemamonista, "1", "0")
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrform(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrform(0) = "pmon=" & mon
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrform(1). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrform(1) = "pforma=" & lforma
		Call ImpresionRptProc("ct_LibroBalancedeComprobacion.rpt", arrform, arrparm)
	End Sub
	
	'UPGRADE_WARNING: El evento OptForma.CheckedChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub OptForma_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles OptForma.CheckedChanged
		If eventSender.Checked Then
			Dim Index As Short = OptForma.GetIndex(eventSender)
			lforma = Index + 1
		End If
	End Sub
End Class