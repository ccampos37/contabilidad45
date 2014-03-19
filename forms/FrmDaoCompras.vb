Option Strict Off
Option Explicit On
Friend Class FrmDaoCompras
	Inherits System.Windows.Forms.Form
	Dim Asiento, cuenta As String
	
	Private Sub cmdAceptar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAceptar.Click
		Dim x As New ADODB.Recordset
		Dim analitico As String
		If Ctr_AyudaEntidad.xclave = "" Then
			analitico = "%%"
		Else
			analitico = Ctr_AyudaEntidad.xclave
		End If
		
		VGCommandoSP = New ADODB.Command
		VGCommandoSP.let_ActiveConnection(VGGeneral)
		VGCommandoSP.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
		VGCommandoSP.CommandText = "ct_DAOCompras_rpt"
		VGCommandoSP.Parameters.Refresh()
		With VGCommandoSP
			.Parameters("@Base").Value = VGParamSistem.BDEmpresa
			.Parameters("@empresa").Value = VGParametros.empresacodigo
			.Parameters("@Anno").Value = VGParamSistem.Anoproceso
			.Parameters("@Mes").Value = VGParamSistem.Mesproceso
			.Parameters("@ASIENTOSPLAN").Value = Asiento
			.Parameters("@CTASPLANCOMP").Value = cuenta
			.Parameters("@analitico").Value = analitico
			x = .Execute
		End With
		DataGrid1.DataSource = x
	End Sub
	
	Private Sub cmdCancelar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancelar.Click
		Me.Close()
		
	End Sub
	Private Sub CmdImprimir_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdImprimir.Click
		Dim analitico As Object
		Dim aform(1) As Object
		Dim aparam(7) As Object
		If Ctr_AyudaEntidad.xclave = "" Then
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto analitico. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			analitico = "%%"
		Else
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto analitico. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			analitico = Ctr_AyudaEntidad.xclave
		End If
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aform(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		aform(0) = "Titulo='" & Me.Text & "'"
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aparam(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		aparam(0) = VGParamSistem.BDEmpresa
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aparam(1). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		aparam(1) = VGParametros.empresacodigo
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aparam(2). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		aparam(2) = VGParamSistem.Anoproceso
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aparam(3). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		aparam(3) = VGParamSistem.Mesproceso
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aparam(4). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		aparam(4) = Asiento
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aparam(5). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		aparam(5) = cuenta
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto analitico. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto aparam(6). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		aparam(6) = analitico
		
		Call ImpresionRptProc("ct_DAOCompras.rpt", aform, aparam,  , " DAO")
	End Sub
	
	Private Sub FrmDaoCompras_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Dim RSparCompras As Object
		Me.Text = "DAO COMPRAS - SUNAT HASTA EL MES DE : " & DesMes(VGParamSistem.Mesproceso)
		CmdAceptar.Image = MDIPrincipal.ImgListIcono.Images.Item("Entrar")
		CmdImprimir.Image = MDIPrincipal.ImgListIcono.Images.Item("Imprimir")
		CmdCancelar.Image = MDIPrincipal.ImgListIcono.Images.Item("Retornar")
		Call Ctr_AyudaEntidad.Conexion(VGCNx)
		
		RSparCompras = New ADODB.Recordset
		SQL = "select * from ct_paramlibaux where paramlibauxtipo='CO'"
		RSparCompras = VGCNx.Execute(SQL)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto RSparCompras.RecordCount. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If RSparCompras.RecordCount = 0 Then
			MsgBox("No existen parametros para el registros de compras")
			Exit Sub
		End If
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto RSparCompras!paramlibauxasiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Asiento = RSparCompras!paramlibauxasiento
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto RSparCompras!paramlibauxcuenta. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cuenta = RSparCompras!paramlibauxcuenta
		
	End Sub
End Class