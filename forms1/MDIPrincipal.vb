Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class MDIPrincipal
	Inherits System.Windows.Forms.Form
	
	
	Private Sub MDIPrincipal_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		Call ADOConectar()
		Call ADOConectarReport("CONTABILIDAD")
		MainContab.VGtipo = ModificarCampos.TIPOSISTEMA.contab
		
		mensaje1 = "Prueba "
		
		frmlogin.ShowDialog()
		Me.Text = "Sistema de Contabilidad Empresa : " & VGParametros.NomEmpresa & "   Base de datos --> " & VGParamSistem.BDEmpresa
		
		If VGSalir Then
			If VGCNx.State = 1 Then VGCNx.Close()
			If VGCnxCT.State = 1 Then VGCnxCT.Close()
			Me.Visible = False
			Me.Close()
			Exit Sub
		Else
			Call CargarParametrosContabilidad()
		End If
		
		Exit Sub
		
err_Renamed: 
		MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Aviso")
		Exit Sub
		Resume 
Xmain: 
		MsgBox(Err.Description, MsgBoxStyle.Exclamation)
		
	End Sub
	
	Public Sub mnu00_01_01_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu00_01_01.Click
		Dim Index As Short = mnu00_01_01.GetIndex(eventSender)

	End Sub
	
	Public Sub mnu00_01_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu00_01.Click
		Dim Index As Short = mnu00_01.GetIndex(eventSender)

	End Sub
	
	Public Sub mnu01_01_02_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu01_01_02.Click
        frmMantOperacion.Show()
	End Sub
	
	Public Sub mnu01_01_03_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu01_01_03.Click
        frmMntCentroCosto.Show()
	End Sub
	
	
	Public Sub mnu01_02_02_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu01_02_02.Click
		FrmMntIndicadorOportunidad.Show()
	End Sub
	
	Public Sub mnu01_04_01_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu01_04_01.Click
		FrmMantTipoAnalitico.Show()
	End Sub
	
	Public Sub mnu01_04_02_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu01_04_02.Click
		frmMantEntidad.Show()
	End Sub
	
	Private Sub mnu01_01_05_Click()
		frmMantLibro.Show()
	End Sub
	
	Public Sub mnu01_06_01_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu01_06_01.Click
		frmMantAsiento.Show()
	End Sub
	
	Public Sub mnu01_06_02_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu01_06_02.Click
		If ValidaAsientos = True Then
			frmMantSubAsiento.Show()
		End If
	End Sub
	
	Public Sub mnu01_06_03_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu01_06_03.Click
		If ValidaAsientos = True Then
			If ValidaSubAsientos("%") = True Then frmMantPlantillaAsiento.Show()
		End If
	End Sub
	
	Public Sub mnu01_07_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu01_07.Click
		'    frmPassword.Show
        FrmMntTipocambio.Show()
	End Sub
	
	Public Sub mnu01_01_08_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu01_01_08.Click
        Try
            FrmMntDocumentos.Show()
        Catch ex As Exception

        End Try
    End Sub
	
	Public Sub mnu01_01_09_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu01_01_09.Click
		'  frmMantEstComprobante.Show
	End Sub
	
	Public Sub mnu01_01_10_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu01_01_10.Click
		'   frmMantAplicacion.Show
	End Sub
	
	Public Sub mnu01_11_01_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu01_11_01.Click
        FrmMntEstructuraBalance.Show()
	End Sub
	
	Public Sub mnu01_11_02_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu01_11_02.Click
        frmEstructuraMantEstadoGanPer.Show()
	End Sub
	
	Public Sub mnu01_11_03_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu01_11_03.Click
        frmEstructuraMantTotalLineaEGP.Show()
	End Sub
	
	Public Sub mnu01_11_05_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu01_11_05.Click
        frmEstructuraMantParametrosGastos.Show()
	End Sub
	
	Public Sub mnu01_11_06_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu01_11_06.Click
        frmEstructuraMantParamLibAux.Show()
	End Sub
	
	Public Sub mnu01_12_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu01_12.Click
		frmMantPlanCuentas.Show()
	End Sub
	
	Public Sub mnu01_13_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu01_13.Click
		frmMantSaldosInicialPlan.Show()
	End Sub
	
	Public Sub mnu01_01_14_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu01_01_14.Click
        FrmMantMoneda.Show()
	End Sub
	
	Public Sub mnu01_01_15_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu01_01_15.Click
        FrmTipocuenta.Show()
	End Sub
	
	Public Sub mnu02_01_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu02_01.Click
		frmConsultaComprobantes.Show()
	End Sub
	
	Public Sub mnu02_02_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu02_02.Click
		'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		frmantcomprobantes.Show()
		'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
	End Sub
	
	
	Public Sub mnu02_04_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu02_04.Click
		frmMant_CtaCteAnalitico.ShowDialog()
	End Sub
	
	Public Sub mnu03_01_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu03_01.Click
		On Error GoTo Mayor
		'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		VGCNx.BeginTrans()
		VGCommandoSP = New ADODB.Command
		VGCommandoSP.let_ActiveConnection(VGGeneral)
		VGCommandoSP.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
		VGCommandoSP.CommandText = "ct_mayoriza_pro"
		VGCommandoSP.Parameters.Refresh()
		With VGCommandoSP
			.Parameters("@base").Value = VGParamSistem.BDEmpresa
			.Parameters("@empresa").Value = VGParametros.empresacodigo
			.Parameters("@anno").Value = VGParamSistem.Anoproceso
			.Parameters("@mespro").Value = VGParamSistem.Mesproceso
			.Parameters("@user").Value = VGParamSistem.Usuario
			.Parameters("@tipo").Value = 1
			.Execute()
		End With
		'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		VGCommandoSP = New ADODB.Command
		VGCommandoSP.let_ActiveConnection(VGGeneral)
		VGCommandoSP.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
		VGCommandoSP.CommandText = "ct_mayoriza_pro"
		VGCommandoSP.Parameters.Refresh()
		With VGCommandoSP
			.Parameters("@base").Value = VGParamSistem.BDEmpresa
			.Parameters("@empresa").Value = VGParametros.empresacodigo
			.Parameters("@anno").Value = VGParamSistem.Anoproceso
			.Parameters("@mespro").Value = VGParamSistem.Mesproceso
			.Parameters("@user").Value = VGParamSistem.Usuario
			.Parameters("@tipo").Value = 2
			.Execute()
		End With
		VGCNx.CommitTrans()
		'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
		MsgBox("Se Mayorizo Satisfactoriamente ", MsgBoxStyle.Information)
		Exit Sub
Mayor: 
		'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
		VGCNx.RollbackTrans()
		MsgBox("No se pudo mayorizar " & Chr(13) & Err.Description, MsgBoxStyle.Exclamation)
		Exit Sub
		Resume 
	End Sub
	Private Sub mnu03_03_Click()
		Call CancelaDocumentos()
	End Sub
	Public Sub mnu03_02_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu03_02.Click
		FrmAjusDiferxDoc.Show()
	End Sub
	
	Public Sub mnu03_04_01_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu03_04_01.Click
		FrmImportDataFac.Show()
	End Sub
	
	Public Sub mnu03_04_02_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu03_04_02.Click
		FrmContabCobrar.Show()
	End Sub
	
	Public Sub mnu03_07_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu03_07.Click
		FrmgenerasaldosAnaliticos.Show()
	End Sub
	
	Public Sub mnu03_04_03_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu03_04_03.Click
		FrmContabPagar.ShowDialog()
	End Sub
	
	Public Sub mnu03_09_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu03_09.Click
		FrmGenerasaldosini.ShowDialog()
	End Sub
	
	Public Sub mnu04_01_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu04_01.Click
		frmRepDiarioGeneral.Show()
	End Sub
	
	Public Sub mnu04_02_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu04_02.Click
		FrmRepBalanceComp.Show()
	End Sub
	
	Public Sub mnu04_03_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu04_03.Click
		frmRepMayor.Caso = "1"
		frmRepMayor.tituloreporte = "Reporte de Mayor Analítico"
		frmRepMayor.Show()
	End Sub
	
	Public Sub mnu04_04_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu04_04.Click
		frmRepMayor.Caso = "2"
		frmRepMayor.tituloreporte = "Reporte de Mayor General"
		frmRepMayor.Show()
	End Sub
	
	Public Sub mnu04_05_01_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu04_05_01.Click
		FrmRepCompras.Show()
	End Sub
	
	Public Sub mnu04_05_02_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu04_05_02.Click
		frmRepVentas.Show()
	End Sub
	
	Public Sub mnu04_05_03_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu04_05_03.Click
		frmRepHonorarios.Show()
	End Sub
	
	Public Sub mnu04_05_04_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu04_05_04.Click
		frmRepCajaBancos.Show()
	End Sub
	
	Public Sub mnu04_06_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu04_06.Click
		frmRepCtaCteAnalitico.Show()
	End Sub
	
	Public Sub mnu04_07_01_01_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu04_07_01_01.Click
		frmRepPlanCuentasSaldosIniciales.Show()
	End Sub
	
	Public Sub mnu04_07_01_02_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu04_07_01_02.Click
		Dim SQL As String
		On Error GoTo xx
		Dim arrform(0) As Object
		Dim arrparm(4) As Object
		Dim NombreRep, CadOrden As String
		arrparm(0) = VGParamSistem.BDEmpresa
		arrparm(1) = VGParametros.empresacodigo
		arrparm(2) = VGParamSistem.Anoproceso
		arrparm(3) = Trim(VGParamSistem.Mesproceso)
		NombreRep = "rptAsientosDescuadrados.rpt"
        Call ImpresionRptProc(NombreRep, arrform, arrparm, "", "Descuadre de Asientos")
		Exit Sub
xx: 
		MsgBox("No se pudo Abrir el Reporte " & Chr(13) & Err.Description, MsgBoxStyle.Exclamation)
	End Sub
	
	
	Public Sub mnu04_07_01_04_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu04_07_01_04.Click
		FrmRepCuentasVsAnaliticos.Show()
	End Sub
	
	Public Sub mnu04_07_02_01_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu04_07_02_01.Click
		frmRepPlantillaSubAsientos.Show()
	End Sub
	
	Public Sub mnu04_07_02_02_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu04_07_02_02.Click
		frmRepListadoCtasDist.Show()
	End Sub
	
	
	Private Sub mnu04_07_03_Click()
		frmRepPlanCuentas.Show()
	End Sub
	
	Public Sub mnu04_07_02_04_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu04_07_02_04.Click
		frmRepEstructuras.Show()
	End Sub
	
	Public Sub mnu04_07_04_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu04_07_04.Click
		frmRepComprob.Show()
	End Sub
	
	
	Public Sub mnu04_07_07_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu04_07_07.Click
		frmRepEstadosFinancieros.Show()
	End Sub
	
	
	Public Sub mnu04_07_09_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu04_07_09.Click
		frmRepMovimientoCuentas.Show()
	End Sub

	Public Sub mnu04_08_01_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu04_08_01.Click
		frmRepCentrodeCostos.Show()
	End Sub
	
	Public Sub mnu04_08_02_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu04_08_02.Click
		frmRepCentrodeCostosAcumulado.ShowDialog()
	End Sub
	Public Sub mnu04_09_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu04_09.Click
		FrmInventariosyBalances.Show()
	End Sub
	
	
	Public Sub mnu04_10_02_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu04_10_02.Click
		FrmLibroBalancedeComprobacion.Show()
	End Sub
	
	Public Sub mnu04_10_03_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu04_10_03.Click
		FrmLibroInventariosyBalances.Show()
	End Sub
	
	Public Sub mnu04_10_05_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu04_10_05.Click
		FrmLibroDiario.Show()
	End Sub
	
	Public Sub mnu04_10_06_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu04_10_06.Click
		FrmLibroMayor.Caso = "1"
		FrmLibroMayor.tituloreporte = "Reporte de LIBRO MAYOR"
		FrmLibroMayor.Show()
	End Sub
	
	Public Sub mnu04_10_07_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu04_10_07.Click
		FrmLibroCajayBancos.Show()
	End Sub
	
	Public Sub mnu04_10_08_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu04_10_08.Click
		FrmLibroRegistrodeCompras.Show()
	End Sub
	
	Public Sub mnu04_10_10_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu04_10_10.Click
		frmRepEstadosFinancieros.Show()
	End Sub
	
	Public Sub mnu04_10_14_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu04_10_14.Click
		FrmLibroRegistrodeventas.Show()
	End Sub
	
	Private Sub mnu04_10_15_Click()
		FrmLibroInventarios.Show()
	End Sub
	
	Public Sub mnu04_10_16_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu04_10_16.Click
		FrmLibroDiarioSimplificado.Show()
	End Sub
	
	Public Sub mnu05_01_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu05_01.Click
		frmannos.Show()
	End Sub
	Public Sub mnu05_02_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu05_02.Click
		frmParametros.Show()
	End Sub
	Public Sub mnu05_03_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu05_03.Click
		Frmusuarios.Show()
	End Sub
	
	Public Sub mnu05_04_01_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu05_04_01.Click
		FrmCreacionEmpresa.Show()
	End Sub
	
	Public Sub mnu05_04_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu05_04.Click
		MainContab.VGtipo = ModificarCampos.TIPOSISTEMA.contab
		'FrmCfgEmpresa.Show
	End Sub
	
	Public Sub mnu05_05_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu05_05.Click
		'  FrmCierremensual.Show 1
	End Sub
	
	Public Sub mnu06_01_01_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu06_01_01.Click
		FrmSunat682.Show()
	End Sub
	
	Public Sub mnu06_02_01_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu06_02_01.Click
		FrmLibrosElectPrincipales.Show()
	End Sub
	
	Public Sub mnu06_04_01_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu06_04_01.Click
		FrmDaoCompras.Show()
	End Sub
	Public Sub mnu06_04_03_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu06_04_03.Click
		FrmDaoVentas.Show()
	End Sub
	
	Public Sub mnu08_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnu08.Click
		If MsgBox("Desea salir del Sistema de CONTABILIDAD ", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
			Me.Close()
		End If
	End Sub
	
	Private Sub StatusBar1_PanelDblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _StatusBar1_Panel1.DoubleClick, _StatusBar1_Panel2.DoubleClick, _StatusBar1_Panel3.DoubleClick, _StatusBar1_Panel4.DoubleClick, _StatusBar1_Panel5.DoubleClick, _StatusBar1_Panel6.DoubleClick
		Dim Panel As System.Windows.Forms.ToolStripStatusLabel = CType(eventSender, System.Windows.Forms.ToolStripStatusLabel)
		'UPGRADE_ISSUE: MSComctlLib.Panel propiedad Panel.Index no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        Select Case 1
            Case 1, 2
                frmselanomes.ShowDialog()
        End Select
	End Sub
	Private Sub ToolComprob_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _ToolComprob_Button1.Click, _ToolComprob_Button2.Click, _ToolComprob_Button3.Click, _ToolComprob_Button4.Click, _ToolComprob_Button5.Click, _ToolComprob_Button6.Click, _ToolComprob_Button7.Click, _ToolComprob_Button8.Click, _ToolComprob_Button9.Click, _ToolComprob_Button10.Click
		Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)
		Select Case CShort(VB.Right(Trim(Button.Name), Len(Trim(Button.Name)) - 1))
			Case 1 'Nuevo
				Call mnu00_01_Click(mnu00_01.Item(1), New System.EventArgs())
			Case 2 'grabar
				Call mnu00_01_Click(mnu00_01.Item(2), New System.EventArgs())
			Case 3 'Eliminar
				Call mnu00_01_Click(mnu00_01.Item(3), New System.EventArgs())
			Case 4 'Modificar
				Call mnu00_01_Click(mnu00_01.Item(4), New System.EventArgs())
			Case 5
				Call mnu00_01_Click(mnu00_01.Item(5), New System.EventArgs())
			Case 6
				Call mnu00_01_Click(mnu00_01.Item(6), New System.EventArgs())
			Case 7
				Call mnu00_01_Click(mnu00_01.Item(7), New System.EventArgs())
			Case 8
				Call mnu00_01_Click(mnu00_01.Item(8), New System.EventArgs())
		End Select
	End Sub

End Class