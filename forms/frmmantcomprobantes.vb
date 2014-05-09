Option Strict Off
Option Explicit On
Imports Func = Contabilidad.ModFuncionesGen
Imports Microsoft.VisualBasic.PowerPacks
Friend Class frmantcomprobantes
	Inherits System.Windows.Forms.Form
	Dim ClsMM1 As ClsMantMov1
	Dim rscampo As ADODB.Recordset
	Dim rscabecera As ADODB.Recordset
	Dim WithEvents rsmantenimiento As ADODB.Recordset
	Public IMant As Short
	Dim adReasonAux As ADODB.EventReasonEnum
	Public VPAsiento, VPSubAsiento As String
	Dim VlUltAccion As Short
	Public VlGrabada As Boolean
	Public VlNref As Boolean
	Public Vllabelsref As String
	'FIXIT: Declare 'VlCtaAjuste' con un tipo de datos de enlace en tiempo de compilación      FixIT90210ae-R1672-R1B8ZE
	Dim VlCtaAjuste As Object
	Dim VlLibro As String
	Dim VlNotaCredito As Boolean
	Dim VlExisteRef As Boolean
	Dim m_CodComprob As String
	
	'UPGRADE_WARNING: El evento ChkAjusta.CheckStateChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub ChkAjusta_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ChkAjusta.CheckStateChanged
		If ChkAjusta.CheckState = 1 Then
			lbconv.Visible = True
			TxValor.Visible = True
			If CtrAyu_Moneda.xclave = VGParametros.monedabase Then
				'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                TxValor.Text = Format(rsmantenimiento.Fields("montouss").Value, "###,###,###.00")
                TxValor.valor = rsmantenimiento.Fields("montouss")
            Else
                'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                TxValor.Text = Format(rsmantenimiento.Fields("montosol").Value, "###,###,###.00")
                TxValor.valor = rsmantenimiento.Fields("montosol")
            End If
        Else
            lbconv.Visible = False
            TxValor.Visible = False
        End If
        If Not VGflaglimpia Then Exit Sub
        ClsMM1 = New ClsMantMov1
        If VGMoverRegistro Then Exit Sub
        Call ClsMM1.ActualizarDetalle(rsmantenimiento, ClsMantMov1.Campos.Montos)
        Call CalcularTotales(rsmantenimiento)
    End Sub

    Private Sub ChkGrabado_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles ChkGrabado.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = 13 Then Call System.Windows.Forms.SendKeys.Send("{TAB}")
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    'UPGRADE_WARNING: El evento ChkInafecto.CheckStateChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub ChkInafecto_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ChkInafecto.CheckStateChanged
        ClsMM1 = New ClsMantMov1
        Call ClsMM1.ActualizarDetalle(rsmantenimiento, ClsMantMov1.Campos.plantillaasientoinafecto)
    End Sub

    Private Sub ChkInafecto_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles ChkInafecto.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = 13 Then Call System.Windows.Forms.SendKeys.Send("{TAB}")
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    'UPGRADE_WARNING: El evento ChkTodos.CheckStateChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub ChkTodos_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ChkTodos.CheckStateChanged
        If ChkTodos.CheckState = 1 Then
            Call EjecutarConsulta("", True)
        Else
            Call EjecutarConsulta("", False)
        End If
    End Sub
    'UPGRADE_WARNING: El evento CmbID.SelectedIndexChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub CmbID_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmbID.SelectedIndexChanged
        If Not VGflaglimpia Then Exit Sub
        If VGMoverRegistro Then Exit Sub
        ClsMM1 = New ClsMantMov1
        Call ClsMM1.ActualizarDetalle(rsmantenimiento, ClsMantMov1.Campos.indicador)
        Call ClsMM1.CalculoIGV(rsmantenimiento)
        Call ClsMM1.CalculodeAjuste(rsmantenimiento)
        Call CalcularTotales(rsmantenimiento)
    End Sub

    Private Sub CmbID_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles CmbID.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000
        If KeyCode = 13 Then Call System.Windows.Forms.SendKeys.Send("{TAB}")
    End Sub
    'UPGRADE_WARNING: El evento CmbTcambio.SelectedIndexChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub CmbTcambio_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmbTcambio.SelectedIndexChanged
        If Not VGflaglimpia Then Exit Sub
        If VGMoverRegistro Then Exit Sub
        ClsMM1 = New ClsMantMov1
        ClsMM1 = New ClsMantMov1
        VGValorCambio = ClsMM1.RecuperaTipoCambio(Format(Dtp_FechaDoc._Value, "dd/mm/yyyy"), CmbTcambio.SelectedIndex + 1)
        lb_vcambio.Text = Format(VGValorCambio, "#.000 ")
        Call ClsMM1.ActualizarDetalle(rsmantenimiento, ClsMantMov1.Campos.Montos)
        Call ClsMM1.CalculoIGV(rsmantenimiento)
        Call ClsMM1.CalculodeAjuste(rsmantenimiento)
        Call CalcularTotales(rsmantenimiento)
    End Sub
    Private Sub CmbTcambio_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles CmbTcambio.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000
        If KeyCode = 13 Then Call System.Windows.Forms.SendKeys.Send("{TAB}")
    End Sub

    Private Sub cmdAceptar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAceptar.Click
        ClsMM1 = New ClsMantMov1
        Call ClsMM1.ActualizaIngresorapido(rsmantenimiento, Me)
        Call CalcularTotales(rsmantenimiento)

    End Sub

    Private Sub CmdDocPend_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdDocPend.Click
        Call MuestraDocPend()
    End Sub

    Private Sub CmdSalir_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdSalir.Click
        FrameIngreso.Visible = False
    End Sub

    Private Sub CtrAyu_Analitico_AlDevolverDato(ByVal eventSender As System.Object, ByVal eventArgs As Axctrlayuda_f.__Ctr_Ayuda_AlDevolverDatoEvent) Handles CtrAyu_Analitico.AlDevolverDato
        If Not VGflaglimpia Then Exit Sub
        ClsMM1 = New ClsMantMov1
        Call ClsMM1.ActualizarDetalle(rsmantenimiento, ClsMantMov1.Campos.analiticocodigo)
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        txRuc.Text = ESNULO(Trim(eventArgs.ColecCampos("entidadruc").Value), "") : txRuc.Locked = True

    End Sub

    Private Sub CtrAyu_Analitico_AlNoDevolverNada(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CtrAyu_Analitico.AlNoDevolverNada
        If Not VGflaglimpia Then Exit Sub
        ClsMM1 = New ClsMantMov1
        Call ClsMM1.ActualizarDetalle(rsmantenimiento, ClsMantMov1.Campos.analiticocodigo)
        'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        txRuc.Text = "" : txRuc.Locked = False

    End Sub

    Private Sub CtrAyu_Asiento_AlDevolverDato(ByVal eventSender As System.Object, ByVal eventArgs As Axctrlayuda_f.__Ctr_Ayuda_AlDevolverDatoEvent) Handles CtrAyu_Asiento.AlDevolverDato
        CtrAyu_SubAsiento.Filtro = "asientocodigo='" & Trim(CtrAyu_Asiento.xclave) & "'"
        CtrAyu_SubAsiento.xclave = "" : CtrAyu_SubAsiento.xnombre = ""

        '    CtrAyu_SubAsiento.Enabled = True
        '    lbSubAsiento.Enabled = True
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        VlGrabada = ESNULO((eventArgs.ColecCampos("flaggrabado").Value), 0)
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        VlNref = ESNULO((eventArgs.ColecCampos("controlnref").Value), 0)
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Vllabelsref = ESNULO((eventArgs.ColecCampos("nemotecref").Value), "")
        VlLibro = eventArgs.ColecCampos("librocodigo").Value
    End Sub

    Private Sub CtrAyu_Asiento_AlNoDevolverNada(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CtrAyu_Asiento.AlNoDevolverNada
        CtrAyu_SubAsiento.xclave = "" : CtrAyu_SubAsiento.xnombre = ""
        VlGrabada = False
        VlNref = False
        Vllabelsref = ""
        VlLibro = ""
        '    CtrAyu_SubAsiento.Enabled = False
        '    lbSubAsiento.Enabled = False
    End Sub

    Private Sub CtrAyu_CCosto_AlDevolverDato(ByVal eventSender As System.Object, ByVal eventArgs As Axctrlayuda_f.__Ctr_Ayuda_AlDevolverDatoEvent) Handles CtrAyu_CCosto.AlDevolverDato
        If Not VGflaglimpia Then Exit Sub
        ClsMM1 = New ClsMantMov1
        Call ClsMM1.ActualizarDetalle(rsmantenimiento, ClsMantMov1.Campos.centrocostocodigo)
    End Sub

    Private Sub CtrAyu_CCosto_AlNoDevolverNada(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CtrAyu_CCosto.AlNoDevolverNada
        If Not VGflaglimpia Then Exit Sub
        ClsMM1 = New ClsMantMov1
        Call ClsMM1.ActualizarDetalle(rsmantenimiento, ClsMantMov1.Campos.centrocostocodigo)
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VlCtaAjuste. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        VlCtaAjuste = ""
    End Sub

    Private Sub CtrAyu_Cuenta_AlDevolverDato(ByVal eventSender As System.Object, ByVal eventArgs As Axctrlayuda_f.__Ctr_Ayuda_AlDevolverDatoEvent) Handles CtrAyu_Cuenta.AlDevolverDato
        If Not VGflaglimpia Then Exit Sub
        Call HabilitarSegunCuenta((eventArgs.ColecCampos("cuentaestadoccostos").Value), (eventArgs.ColecCampos("cuentaestadoanalitico").Value), (eventArgs.ColecCampos("cuentadocumento").Value))
        ClsMM1 = New ClsMantMov1
        Call ClsMM1.ActualizarDetalle(rsmantenimiento, ClsMantMov1.Campos.cuentacodigo)
        '  VGvardllgen = New dllgeneral.dll_general
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        CtrAyu_TipAnal.xclave = Trim(ESNULO((eventArgs.ColecCampos("tipoanaliticocodigo").Value), ""))
        CtrAyu_TipAnal.Ejecutar()
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VlCtaAjuste. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        VlCtaAjuste = Trim(ESNULO((eventArgs.ColecCampos("tipoajuste").Value), ""))


    End Sub
    Private Sub HabilitarSegunCuenta(ByRef SiCCostos As Boolean, ByRef SiAnalitico As Boolean, ByRef SiDocumento As Boolean)
        CtrAyu_CCosto.Visible = SiCCostos
        lbccosto.Visible = SiCCostos
        If Not SiCCostos Then
            CtrAyu_CCosto.xclave = "00" : CtrAyu_CCosto.xnombre = "(Ninguno)"
        End If
        CtrAyu_TipAnal.Visible = SiAnalitico
        'UPGRADE_NOTE: Enabled se actualizó a CtlEnabled. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        CtrAyu_TipAnal.CtlEnabled = Not SiAnalitico
        lbTipAnal0.Visible = SiAnalitico
        CtrAyu_Analitico.Visible = SiAnalitico
        lbAnalitico.Visible = SiAnalitico
        If Not SiAnalitico Then
            CtrAyu_TipAnal.xclave = "00" : CtrAyu_TipAnal.xnombre = "(Ninguno)"
            CtrAyu_Analitico.xclave = "00" : CtrAyu_Analitico.xnombre = "(Ninguno)"
        Else
            CtrAyu_TipAnal.xclave = "" : CtrAyu_TipAnal.xnombre = ""
            CtrAyu_Analitico.xclave = "" : CtrAyu_Analitico.xnombre = ""
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            txRuc.Text = ""
        End If
        txRuc.Visible = SiAnalitico
        lbruc.Visible = SiAnalitico
        CtrAyu_TipDoc.Visible = SiDocumento
        lbtipdoc.Visible = SiDocumento
        lbtipref.Visible = SiDocumento
        CtrAyu_TipRef.Visible = SiDocumento
        If Not SiDocumento Then
            CtrAyu_TipDoc.xclave = "00" : CtrAyu_TipDoc.xnombre = "(Ninguno)"
            CtrAyu_TipRef.xclave = "00" : CtrAyu_TipRef.xnombre = "(Ninguno)"
        Else
            CtrAyu_TipDoc.xclave = "" : CtrAyu_TipDoc.xnombre = ""
            CtrAyu_TipRef.xclave = "" : CtrAyu_TipRef.xnombre = ""
        End If
        TxSerie.Visible = SiDocumento
        TxNdoc.Visible = SiDocumento
        lbndocum.Visible = SiDocumento
        TxNref.Visible = SiDocumento
        lbnref.Visible = SiDocumento
        CmdDocPend.Visible = SiDocumento
        Dtp_FechaDoc.Visible = SiDocumento
        '    lbFechaDoc.Visible = SiDocumento
        DtpFech_Ven.Visible = SiDocumento
        lbFechVen.Visible = SiDocumento
        Dtp_FechaDocRef.Visible = SiDocumento
    End Sub


    Private Sub CtrAyu_Cuenta_AlNoDevolverNada(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CtrAyu_Cuenta.AlNoDevolverNada
        If Not VGflaglimpia Then Exit Sub
        Call HabilitarSegunCuenta(False, False, False)
        ClsMM1 = New ClsMantMov1
        Call ClsMM1.ActualizarDetalle(rsmantenimiento, ClsMantMov1.Campos.cuentacodigo)
    End Sub



    Private Sub CtrAyu_Cuenta2_AlDevolverDato(ByVal eventSender As System.Object, ByVal eventArgs As Axctrlayuda_f.__Ctr_Ayuda_AlDevolverDatoEvent) Handles CtrAyu_Cuenta2.AlDevolverDato
        Dim tipoanali As String
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        tipoanali = Trim(ESNULO((eventArgs.ColecCampos("tipoanaliticocodigo").Value), ""))
        CtrAyu_Analitico1.Filtro = "tipoanaliticocodigo='" & tipoanali & "'"
    End Sub

    Private Sub CtrAyu_Moneda_AlDevolverDato(ByVal eventSender As System.Object, ByVal eventArgs As Axctrlayuda_f.__Ctr_Ayuda_AlDevolverDatoEvent) Handles CtrAyu_Moneda.AlDevolverDato
        If Not VGflaglimpia Then Exit Sub
        If VGMoverRegistro Then Exit Sub
        ClsMM1 = New ClsMantMov1
        Call ClsMM1.ActualizarDetalle(rsmantenimiento, ClsMantMov1.Campos.monedacodigo)
        'Poner un flag para que no entre cuando es recursivo
        If vgcont = 2 Then Exit Sub
        Call ClsMM1.CalculoIGV(rsmantenimiento)
        Call ClsMM1.CalculodeAjuste(rsmantenimiento)
        Call CalcularTotales(rsmantenimiento)
    End Sub

    Private Sub CtrAyu_Moneda_AlNoDevolverNada(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CtrAyu_Moneda.AlNoDevolverNada
        If Not VGflaglimpia Then Exit Sub
        ClsMM1 = New ClsMantMov1
        Call ClsMM1.ActualizarDetalle(rsmantenimiento, ClsMantMov1.Campos.monedacodigo)
    End Sub

    Private Sub CtrAyu_Opera_AlDevolverDato(ByVal eventSender As System.Object, ByVal eventArgs As Axctrlayuda_f.__Ctr_Ayuda_AlDevolverDatoEvent) Handles CtrAyu_Opera.AlDevolverDato
        If Not VGflaglimpia Then Exit Sub
        ClsMM1 = New ClsMantMov1
        Call ClsMM1.ActualizarDetalle(rsmantenimiento, ClsMantMov1.Campos.operacioncodigo)
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Vgdocumentoanulado = IIf(ESNULO(eventArgs.ColecCampos.Item("operaciondocumentoanulado"), False), eventArgs.ColecCampos.Item("operacioncodigo").Value, "")
    End Sub

    Private Sub CtrAyu_Opera_AlNoDevolverNada(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CtrAyu_Opera.AlNoDevolverNada
        If Not VGflaglimpia Then Exit Sub
        ClsMM1 = New ClsMantMov1
        Call ClsMM1.ActualizarDetalle(rsmantenimiento, ClsMantMov1.Campos.operacioncodigo)
    End Sub

    Private Sub CtrAyu_SubAsiento_AlDevolverDato(ByVal eventSender As System.Object, ByVal eventArgs As Axctrlayuda_f.__Ctr_Ayuda_AlDevolverDatoEvent) Handles CtrAyu_SubAsiento.AlDevolverDato
        VGGlosa = eventArgs.ColecCampos("subasientoglosa").Value
        VGRepiteDoc = eventArgs.ColecCampos("subasientorepitedoc").Value
        VGMonSubAsiento = eventArgs.ColecCampos("monedacodigo").Value
    End Sub

    Private Sub CtrAyu_TipAnal_AlDevolverDato(ByVal eventSender As System.Object, ByVal eventArgs As Axctrlayuda_f.__Ctr_Ayuda_AlDevolverDatoEvent) Handles CtrAyu_TipAnal.AlDevolverDato
        CtrAyu_Analitico.Filtro = "tipoanaliticocodigo='" & Trim(CtrAyu_TipAnal.xclave) & "'"
        If Not VGflaglimpia Then Exit Sub
        ClsMM1 = New ClsMantMov1
        Call ClsMM1.ActualizarDetalle(rsmantenimiento, ClsMantMov1.Campos.tipoanaliticocodigo)
    End Sub

    Private Sub CtrAyu_TipAnal_AlNoDevolverNada(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CtrAyu_TipAnal.AlNoDevolverNada
        If Not VGflaglimpia Then Exit Sub
        ClsMM1 = New ClsMantMov1
        Call ClsMM1.ActualizarDetalle(rsmantenimiento, ClsMantMov1.Campos.tipoanaliticocodigo)
    End Sub

    Private Sub CtrAyu_TipDoc_AlDevolverDato(ByVal eventSender As System.Object, ByVal eventArgs As Axctrlayuda_f.__Ctr_Ayuda_AlDevolverDatoEvent) Handles CtrAyu_TipDoc.AlDevolverDato
        If Not VGflaglimpia Then Exit Sub
        ClsMM1 = New ClsMantMov1
        Call ClsMM1.ActualizarDetalle(rsmantenimiento, ClsMantMov1.Campos.documentocodigo)
        VlNotaCredito = eventArgs.ColecCampos("documentonotacredito").Value
    End Sub

    Private Sub CtrAyu_TipDoc_AlNoDevolverNada(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CtrAyu_TipDoc.AlNoDevolverNada
        If Not VGflaglimpia Then Exit Sub
        ClsMM1 = New ClsMantMov1
        Call ClsMM1.ActualizarDetalle(rsmantenimiento, ClsMantMov1.Campos.documentocodigo)
        VlNotaCredito = False
    End Sub

    Private Sub CtrAyu_TipRef_AlDevolverDato(ByVal eventSender As System.Object, ByVal eventArgs As Axctrlayuda_f.__Ctr_Ayuda_AlDevolverDatoEvent) Handles CtrAyu_TipRef.AlDevolverDato
        If Not VGflaglimpia Then Exit Sub
        ClsMM1 = New ClsMantMov1
        Call ClsMM1.ActualizarDetalle(rsmantenimiento, ClsMantMov1.Campos.documentocodigo)
    End Sub

    Private Sub CtrAyu_TipRef_AlNoDevolverNada(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CtrAyu_TipRef.AlNoDevolverNada
        If Not VGflaglimpia Then Exit Sub
        ClsMM1 = New ClsMantMov1
        Call ClsMM1.ActualizarDetalle(rsmantenimiento, ClsMantMov1.Campos.documentocodigo)
    End Sub

    Private Sub Dtc_Campo_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Dtc_Campo.Change
        'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        Label2.Text = Dtc_Campo.Text
    End Sub

    Public Sub Dtp_FechaDoc_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Dtp_FechaDoc.Change
        If Not VGflaglimpia Then Exit Sub
        ClsMM1 = New ClsMantMov1
        Dim POSANTERIOR As Short
        Dim flagcambio As Boolean
        If Not VlNotaCredito Then
            VGValorCambio = ClsMM1.RecuperaTipoCambio(Format(Dtp_FechaDoc._Value, "dd/mm/yyyy"), CmbTcambio.SelectedIndex + 1)
            lb_vcambio.Text = Format(VGValorCambio, "#.000 ")
            flagcambio = False
            If VGValorCambio = 0 Then
                MsgBox("No Existe tipo cambio para esta fecha", MsgBoxStyle.Information)
                Dtp_FechaDoc.Focus()
                flagcambio = True
            End If
        End If
        Call ClsMM1.ActualizarDetalle(rsmantenimiento, ClsMantMov1.Campos.detcomprobfechaemision)
        If VGMoverRegistro Then Exit Sub
        Call ClsMM1.ActualizarDetalle(rsmantenimiento, ClsMantMov1.Campos.documentocodigo)
        If VGRepiteDoc Then
            With rsmantenimiento
                POSANTERIOR = .AbsolutePosition
                .MoveFirst()
                While Not .EOF
                    'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Dtp_FechaDoc._Value. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    .Fields("detcomprobfechaemision").Value = Dtp_FechaDoc._Value
                    '            !documentocodigo = frmantcomprobantes.CtrAyu_TipDoc.xclave
                    .Update()
                    .MoveNext()
                End While
                .AbsolutePosition = POSANTERIOR
            End With
            'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
        End If

        Call ClsMM1.ActualizarDetalle(rsmantenimiento, ClsMantMov1.Campos.Montos)
        If vgcont = 2 Then Exit Sub
        Call ClsMM1.CalculoIGV(rsmantenimiento)
        Call ClsMM1.CalculodeAjuste(rsmantenimiento, flagcambio)
        Call CalcularTotales(rsmantenimiento)
    End Sub

    Private Sub Dtp_FechaDoc_KeyDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSComCtl2.DDTPickerEvents_KeyDownEvent) Handles Dtp_FechaDoc.KeyDownEvent
        If eventArgs.KeyCode = 13 Then Call System.Windows.Forms.SendKeys.Send("{TAB}")
    End Sub

    Private Sub Dtp_FechaDocRef_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Dtp_FechaDocRef.Change
        If Not VGflaglimpia Then Exit Sub
        If VGMoverRegistro Then Exit Sub
        Call ClsMM1.ActualizarDetalle(rsmantenimiento, ClsMantMov1.Campos.detcomprobfecharef)
        If Not VlNotaCredito Then Exit Sub
        Call DTPFechaComprobCab_Change(DTPFechaComprobCab, New System.EventArgs())


    End Sub

    Private Sub Dtp_FechaDocRef_KeyDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSComCtl2.DDTPickerEvents_KeyDownEvent) Handles Dtp_FechaDocRef.KeyDownEvent
        If eventArgs.KeyCode = 13 Then Call System.Windows.Forms.SendKeys.Send("{TAB}")
    End Sub

    Private Sub DtpFech_Ven_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles DtpFech_Ven.Change
        If Not VGflaglimpia Then Exit Sub
        If VGMoverRegistro Then Exit Sub
        Call ClsMM1.ActualizarDetalle(rsmantenimiento, ClsMantMov1.Campos.detcomprobfechavencimiento)
    End Sub

    Private Sub DtpFech_Ven_KeyDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSComCtl2.DDTPickerEvents_KeyDownEvent) Handles DtpFech_Ven.KeyDownEvent
        If eventArgs.KeyCode = 13 Then Call System.Windows.Forms.SendKeys.Send("{TAB}")
    End Sub

    Private Sub DTPFechaComprobCab_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles DTPFechaComprobCab.Change
        ClsMM1 = New ClsMantMov1
        Dim fecha As Date

        If Not VlNotaCredito Then
            VGValorCambio = ClsMM1.RecuperaTipoCambio(Format(DTPFechaComprobCab._Value, "dd/mm/yyyy"), tipocambio.Venta)
            lb_vcambio.Text = Format(VGValorCambio, "#.000 ")
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto DTPFechaComprobCab._Value. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            fecha = DTPFechaComprobCab._Value
        Else
            VGValorCambio = ClsMM1.RecuperaTipoCambio(Format(Dtp_FechaDocRef._Value, "dd/mm/yyyy"), CmbTcambio.SelectedIndex + 1)
            lb_vcambio.Text = Format(VGValorCambio, "#.000 ")
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Dtp_FechaDocRef._Value. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            fecha = Dtp_FechaDocRef._Value
        End If
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto DTPFechaComprobCab._Value. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        DTP_fecha1._Value = DTPFechaComprobCab._Value
        If rsmantenimiento Is Nothing Then Exit Sub
        If rsmantenimiento.RecordCount = 0 Then Exit Sub
        If Not VGflaglimpia Then Exit Sub
        ClsMM1 = New ClsMantMov1
        If Not VlNotaCredito Then Dtp_FechaDoc.Value = DTPFechaComprobCab
        rsmantenimiento.MoveFirst()
        While Not rsmantenimiento.EOF
            With rsmantenimiento
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto DTPFechaComprobCab._Value. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                .Fields("detcomprobfechaemision").Value = DTPFechaComprobCab._Value
                .Update()
                .MoveNext()
            End With
        End While
        rsmantenimiento.MoveFirst()
        Call ClsMM1.ActualizarDetalle(rsmantenimiento, ClsMantMov1.Campos.monedacodigo, True, fecha)
        Call ClsMM1.CalculoIGV(rsmantenimiento)
        Call ClsMM1.CalculodeAjuste(rsmantenimiento)
        Call CalcularTotales(rsmantenimiento)
    End Sub

    Private Sub DTPFechaComprobCab_KeyDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSComCtl2.DDTPickerEvents_KeyDownEvent) Handles DTPFechaComprobCab.KeyDownEvent
        If eventArgs.KeyCode = 13 Then Call System.Windows.Forms.SendKeys.Send("{TAB}")
    End Sub

    Private Sub DTPFechaComprobCab_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles DTPFechaComprobCab.Leave
        '  VGvardllgen = New dllgeneral.dll_general
        If VGValorCambio = 0 And IMant = 1 Then
            MsgBox("No se encuentra el tipo de cambio para esta fecha " & "Por lo tanto no se podra realizar niguna transaccion", MsgBoxStyle.Information)
            Call Cancelar()
            Call PBoton(VlUltAccion)
            'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Exit Sub
        End If
    End Sub


    Private Sub DTPFechaContab_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles DTPFechaContab.Change
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto DTPFechaContab.Value. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        DTPFechaComprobCab.Value = DTPFechaContab.Value
    End Sub

    'UPGRADE_WARNING: Form evento frmantcomprobantes.Activate tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
    Private Sub frmantcomprobantes_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        MDIPrincipal.ToolComprob.Visible = True
        MDIPrincipal.mnu00.Visible = True
        Call PBoton(VlUltAccion)
    End Sub

    Private Sub frmantcomprobantes_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        Dim Shift As Short = eventArgs.KeyData \ &H10000
        If KeyCode = 27 Then Me.Close()
    End Sub

    Private Sub frmantcomprobantes_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        DTPFechaContab.Value = VGParamSistem.FechaTrabajo
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto DTPFechaContab.Value. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Dtp_FechaDoc.Value = DTPFechaContab.Value
        IMant = 0
        VlUltAccion = 0
        '  VGvardllgen = New dllgeneral.dll_general
        rscabecera = New ADODB.Recordset
        ClsMM1 = New ClsMantMov1
        ClsMM1.CargarAyudas()
        'UPGRADE_NOTE: El objeto TDBG_Consulta.DataSource no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        TDBG_Consulta.DataSource = Nothing
        TDBG_Det.FetchRowStyle = True
        Call PrepararTemporalDetalle()
        If rsmantenimiento.RecordCount = 0 Then
            Call HabilitarDetalleContab(False, FramDetalle, Me)
        Else
            Call HabilitarDetalleContab(True, FramDetalle, Me)
        End If
        Call ActivaTab(0, 1, SSTabMant)
        Call GetCamposdeConsulta()

        'UPGRADE_WARNING: IsEmpty se actualizó a IsNothing y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        If Not IsNothing(m_CodComprob) Then
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            TxEjecutar.Text = m_CodComprob
            System.Windows.Forms.SendKeys.Send("{ENTER}")
        End If
        ' Label2.Caption = Dtc_Campo.Text
        'Cargar los tools
    End Sub
    Public Sub AlMoverRegistro()
        Dim pos As Short
        If VGactulizodoc Then Exit Sub 'Estoy Actualizando documentos
        VGMoverRegistro = True
        On Error Resume Next
        With rsmantenimiento
            FramDetalle.Enabled = Not (.Fields("detcomprobauto").Value Or VGParametros.cierremes = True)
            CtrAyu_Opera.xclave = .Fields("operacioncodigo").Value : CtrAyu_Opera.Ejecutar()
            CtrAyu_TipAnal.xclave = .Fields("tipoanaliticocodigo").Value : CtrAyu_TipAnal.Ejecutar()
            CtrAyu_Cuenta.xclave = .Fields("cuentacodigo").Value : CtrAyu_Cuenta.Ejecutar()
            CtrAyu_CCosto.xclave = .Fields("centrocostocodigo").Value : CtrAyu_CCosto.Ejecutar()
            CtrAyu_Analitico.xclave = Trim(.Fields("analiticocodigo").Value) : CtrAyu_Analitico.Ejecutar()
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(rsmantenimiento!cuentacodigo, ). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If .Fields("cuentacodigo").Value = "00" Or ESNULO(.Fields("cuentacodigo"), "") = "" Then
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(rsmantenimiento!comodin, ). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                If ESNULO(.Fields("comodin"), "") <> "" Then
                    CtrAyu_Cuenta.Filtro = "(empresacodigo='" & VGParametros.empresacodigo & "' and (cuentanivel=" & VGnumnivelescuenta & ") and (cuentacodigo<>'00') and (" & .Fields("comodin").Value & "))"
                Else
                    CtrAyu_Cuenta.Filtro = "(empresacodigo='" & VGParametros.empresacodigo & "' and (cuentacodigo<>'00')" & " and (cuentanivel=" & VGnumnivelescuenta & "))"
                End If
            Else
                CtrAyu_Cuenta.Filtro = "(empresacodigo='" & VGParametros.empresacodigo & "' and (cuentacodigo<>'00')" & " and (cuentanivel=" & VGnumnivelescuenta & "))"
            End If
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            txRuc.Text = .Fields("detcomprobruc").Value
            CtrAyu_TipDoc.xclave = .Fields("documentocodigo").Value : CtrAyu_TipDoc.Ejecutar()
            '        pos = InStr(1, !detcomprobnumdocumento, "-", vbTextCompare)
            If Len(.Fields("detcomprobnumdocumento").Value) > 4 Then
                'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                TxSerie.Text = Func.Left(.Fields("detcomprobnumdocumento").Value, TxSerie.MaxLength)
                'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                TxNdoc.Text = Mid(.Fields("detcomprobnumdocumento").Value, TxSerie.MaxLength + 1, Len(.Fields("detcomprobnumdocumento").Value) - TxSerie.MaxLength)
            Else
                'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                TxSerie.Text = .Fields("detcomprobnumdocumento").Value
                'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                TxNdoc.Text = ""
            End If
            Dtp_FechaDoc._Value = Format(.Fields("detcomprobfechaemision").Value, "dd/mm/yyyy")
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            DtpFech_Ven._Value = Format(ESNULO(.Fields("detcomprobfechavencimiento"), .Fields("detcomprobfechaemision")), "dd/mm/yyyy")
            Dtp_FechaDocRef._Value = .Fields("detcomprobfecharef").Value
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            TxGlosa.Text = .Fields("detcomprobglosa").Value
            CmbID.SelectedIndex = IIf(.Fields("indicador").Value = "D", 0, 1)
            CtrAyu_Moneda.xclave = .Fields("monedacodigo").Value : CtrAyu_Moneda.Ejecutar()
            Select Case .Fields("tcambio").Value
                Case "01" 'Compra
                    CmbTcambio.SelectedIndex = 0
                Case "02" 'Venta
                    CmbTcambio.SelectedIndex = 1
                Case "03" 'Promedio
                    CmbTcambio.SelectedIndex = 2
            End Select
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            lb_vcambio.Text = Format(ESNULO(.Fields("valcambio"), 0), "#.000 ")

            If .Fields("monedacodigo").Value = VGParametros.monedabase Then
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                TxMonto.Text = Format(ESNULO(.Fields("montosol"), 0), "#.00")
            Else
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
                TxMonto.Text = Format(ESNULO(.Fields("montouss"), 0), "#.00")
            End If
            ChkAjusta.CheckState = IIf(.Fields("detcomprobajusteuser").Value, 1, 0)
            'ChkInafecto.Visible = !plantillaasientoinafecto
            ChkInafecto.CheckState = IIf(.Fields("plantillaasientoinafecto").Value, 1, 0)
            CtrAyu_TipRef.xclave = .Fields("tipdocref").Value : CtrAyu_TipRef.Ejecutar()
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            TxNref.Text = .Fields("detcomprobnumref").Value
        End With
        VGMoverRegistro = False
    End Sub

    Private Sub frmantcomprobantes_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        MDIPrincipal.ToolComprob.Visible = False
        MDIPrincipal.mnu00.Visible = False
    End Sub



    Private Sub rsmantenimiento_MoveComplete(ByVal adReason As ADODB.EventReasonEnum, ByVal pError As ADODB.Error, ByRef adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset) Handles rsmantenimiento.MoveComplete
        If (adReason = ADODB.EventReasonEnum.adRsnMove Or adReason = ADODB.EventReasonEnum.adRsnMoveNext) And pRecordset.RecordCount > 0 And adReasonAux <> ADODB.EventReasonEnum.adRsnAddNew Then
            Call AlMoverRegistro()
        End If
        If adReasonAux = ADODB.EventReasonEnum.adRsnAddNew Then adReasonAux = ADODB.EventReasonEnum.adRsnMove
    End Sub

    Private Sub rsmantenimiento_RecordChangeComplete(ByVal adReason As ADODB.EventReasonEnum, ByVal cRecords As Integer, ByVal pError As ADODB.Error, ByRef adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset) Handles rsmantenimiento.RecordChangeComplete
        adReasonAux = adReason
    End Sub

    Private Sub SSTabMant_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles SSTabMant.SelectedIndexChanged
        Static PreviousTab As Short = SSTabMant.SelectedIndex()
        Dim Existelibro As Boolean
        If PreviousTab = 0 Then
            CtrAyu_Opera.Requerido = True
            CtrAyu_Cuenta.Requerido = True
            CtrAyu_CCosto.Requerido = True
            CtrAyu_TipAnal.Requerido = True
            CtrAyu_Analitico.Requerido = True
            CtrAyu_TipDoc.Requerido = True
            CtrAyu_TipRef.Requerido = False
            CtrAyu_Moneda.Requerido = True
            '      CtrAyu_Moneda.Enabled = True
            MDIPrincipal.mnu00_01(9).Visible = True
            If VlGrabada Then
                ChkGrabado.Visible = True
            Else
                ChkGrabado.Visible = False
            End If
            If VlNref Then
                lbnemoref.Visible = True
                lbnemoref.Text = Vllabelsref
                TxCtrNref.Visible = True
            Else
                lbnemoref.Visible = False
                TxCtrNref.Visible = False
            End If
            Existelibro = ExisteSQL(VGCNx, "Select flagcontrol From ct_libro where librocodigo='" & Trim(VlLibro) & "' and flagcontrol <> 0 ")
            If Existelibro Then
                leNComprob0.Visible = True
                lbNumComprobCablibro.Visible = True
            Else
                leNComprob0.Visible = False
                lbNumComprobCablibro.Visible = False
            End If
            VlNotaCredito = False
        Else
            CtrAyu_Opera.Requerido = False
            CtrAyu_Cuenta.Requerido = False
            CtrAyu_CCosto.Requerido = False
            CtrAyu_TipAnal.Requerido = False
            CtrAyu_Analitico.Requerido = False
            CtrAyu_TipDoc.Requerido = False
            CtrAyu_TipRef.Requerido = False
            CtrAyu_Moneda.Requerido = False
            MDIPrincipal.mnu00_01(9).Visible = False
        End If
        PreviousTab = SSTabMant.SelectedIndex()
    End Sub

    Private Sub TDBG_Consulta_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TDBG_Consulta.DblClick
        If rscabecera.RecordCount > 0 Then Call modificar()
    End Sub

    Private Sub TDBG_Consulta_KeyDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueOleDBGrid70.TrueDBGridEvents_KeyDownEvent) Handles TDBG_Consulta.KeyDownEvent
        If eventArgs.KeyCode = 13 Then
            Call modificar()
        End If
    End Sub

    'FIXIT: Declare 'LastRow' con un tipo de datos de enlace en tiempo de compilación          FixIT90210ae-R1672-R1B8ZE
    Private Sub TDBG_Consulta_RowColChange(ByVal eventSender As System.Object, ByVal eventArgs As AxTrueOleDBGrid70.TrueDBGridEvents_RowColChangeEvent) Handles TDBG_Consulta.RowColChange
        If rscabecera.State = 0 Then Exit Sub
        If rscabecera.RecordCount = 0 Then Exit Sub
        CtrAyu_Asiento.xclave = rscabecera.Fields("asientocodigo").Value : CtrAyu_Asiento.Ejecutar()
        CtrAyu_SubAsiento.xclave = rscabecera.Fields("subasientocodigo").Value : CtrAyu_SubAsiento.Ejecutar()
    End Sub


    Private Sub TDBG_Det_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TDBG_Det.DblClick
        MsgBox(rsmantenimiento.Fields("Index").Value)
    End Sub

    'FIXIT: Declare 'Bookmark' con un tipo de datos de enlace en tiempo de compilación         FixIT90210ae-R1672-R1B8ZE
    'UPGRADE_NOTE: Split se actualizó a Split_Renamed. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
    Private Sub TDBG_Det_FetchRowStyle(ByVal Split_Renamed As Short, ByRef Bookmark As Object, ByVal RowStyle As TrueOleDBGrid70.StyleDisp)
        Dim rsclone As New ADODB.Recordset
        On Error Resume Next
        rsclone = rsmantenimiento.Clone(ADODB.LockTypeEnum.adLockReadOnly)
        If rsclone.RecordCount = 0 Then Exit Sub
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Bookmark. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        rsclone.Bookmark = Bookmark
        If rsclone.Fields("detcomprobauto").Value Then
            RowStyle.BackColor = System.Convert.ToUInt32(RGB(185, 251, 236))
        End If
    End Sub

    Private Sub TDBG_Det_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TDBG_Det.Enter
        'frameGrid.BackColor = &H628837
        Shilu1.Visible = True : Shilu2.Visible = True
    End Sub

    Private Sub TDBG_Det_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TDBG_Det.Leave
        Shilu1.Visible = False : Shilu2.Visible = False
        'frameGrid.BackColor = &H808080
    End Sub

    Private Sub TxEjecutar_KeyDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxTextFer.__TxFer_KeyDownEvent) Handles TxEjecutar.KeyDownEvent
        Dim cad As String
        If eventArgs.KeyCode = 13 Then
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            cad = Dtc_Campo.BoundText & " like '" & Trim(TxEjecutar.Text) & "%'"
            Call EjecutarConsulta(cad, False)
        End If
    End Sub

    Private Sub TxGlosa_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TxGlosa.Change
        If Not VGflaglimpia Then Exit Sub
        ClsMM1 = New ClsMantMov1
        Call ClsMM1.ActualizarDetalle(rsmantenimiento, ClsMantMov1.Campos.detcomprobglosa)
    End Sub

    Private Sub TxGlosaComprobCab_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TxGlosaComprobCab.Change
        If rsmantenimiento Is Nothing Then Exit Sub
        If rsmantenimiento.RecordCount = 0 Then Exit Sub
        If Not VGflaglimpia Then Exit Sub
        ClsMM1 = New ClsMantMov1
        Call ClsMM1.ActualizarDetalle(rsmantenimiento, 0)
    End Sub

    Private Sub TxMonto_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TxMonto.Change
        If Not VGflaglimpia Then Exit Sub
        If VGMoverRegistro Then Exit Sub
        ClsMM1 = New ClsMantMov1
        Call ClsMM1.ActualizarDetalle(rsmantenimiento, ClsMantMov1.Campos.Montos)
        If FrameIngreso.Visible = False Then Call ClsMM1.CalculoIGV(rsmantenimiento)
        Call ClsMM1.CalculodeAjuste(rsmantenimiento)
        Call CalcularTotales(rsmantenimiento)
    End Sub

    Private Sub TxMonto_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TxMonto.Enter
        If Trim(CtrAyu_Moneda.xclave) = "" Or CtrAyu_Moneda.xclave = "00" Then
            MsgBox("Antes de colocar el monto debe elegir la moneda ", MsgBoxStyle.Information)
            CtrAyu_Moneda.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub TxNdoc_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TxNdoc.Change
        If Not VGflaglimpia Then Exit Sub
        ClsMM1 = New ClsMantMov1
        Call ClsMM1.ActualizarDetalle(rsmantenimiento, ClsMantMov1.Campos.detcomprobnumdocumento)
    End Sub

    Private Sub TxNdoc_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TxNdoc.Leave
        Dim rrvalidadoc As New ADODB.Recordset
        Dim doc1 As String
        Dim doc2 As String
        If CtrAyu_Opera.xclave <> "01" Then Exit Sub
        'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        If IsNumeric(TxSerie.Text) = True Then
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            doc1 = Format(TxSerie.Text, "0000")
        Else
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            doc1 = TxSerie.Text
        End If
        'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        If IsNumeric(TxNdoc.Text) Then
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            doc2 = Format(TxNdoc.Text, "0000000000")
        Else
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            doc2 = TxNdoc.Text
        End If
        'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        TxNdoc.Text = doc2
        SQL = "select * from ct_detcomprob" & VGParamSistem.Anoproceso & " where documentocodigo='" & CtrAyu_TipDoc.xclave & "'"
        SQL = SQL & " and detcomprobnumdocumento='" & doc1 & "' and analiticocodigo='" & Trim(CtrAyu_Analitico.xclave) & "'"
        SQL = SQL & " and operacioncodigo='01'"
        rrvalidadoc = VGCNx.Execute(SQL)
        If rrvalidadoc.RecordCount > 0 Then
            MsgBox("existe documento en el comprobante : " & rrvalidadoc.Fields("cabcomprobnumero").Value & "")
            TxNdoc.Focus()
        End If
    End Sub



    Private Sub TxNdoc1_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TxNdoc1.Leave
        Dim rrvalidadoc As New ADODB.Recordset
        Dim doc1 As String
        Dim doc2 As String
        If CtrAyu_Opera.xclave <> "01" Then Exit Sub
        'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        If IsNumeric(TxSerie1.Text) = True Then
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            doc1 = Format(TxSerie1.Text, "0000")
        Else
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            doc1 = TxSerie1.Text
        End If
        'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        If IsNumeric(TxNdoc1.Text) Then
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            doc2 = Format(TxNdoc1.Text, "0000000000")
        Else
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            doc2 = TxNdoc1.Text
        End If
        'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        TxNdoc1.Text = doc2
        SQL = "select * from ct_detcomprob" & VGParamSistem.Anoproceso & " where documentocodigo='" & CtrAyu_TipDoc1.xclave & "'"
        SQL = SQL & " and detcomprobnumdocumento='" & doc1 & "' and analiticocodigo='" & Trim(CtrAyu_Analitico1.xclave) & "'"
        SQL = SQL & " and operacioncodigo='01'"
        rrvalidadoc = VGCNx.Execute(SQL)
        If rrvalidadoc.RecordCount > 0 Then
            MsgBox("existe documento en el comprobante : " & rrvalidadoc.Fields("cabcomprobnumero").Value & "")
            TxNdoc1.Focus()
        End If
    End Sub

    Private Sub TxNref_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TxNref.Change
        If Not VGflaglimpia Then Exit Sub
        ClsMM1 = New ClsMantMov1
        Call ClsMM1.ActualizarDetalle(rsmantenimiento, ClsMantMov1.Campos.detcomprobnumdocumento)
    End Sub

    Private Sub TxNref_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TxNref.Leave
        Dim rsfecha As ADODB.Recordset
        If Not VlNotaCredito Then Exit Sub
        'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Dtp_FechaDoc.Value. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Dtp_FechaDocRef.Value = Dtp_FechaDoc.Value
        rsfecha = New ADODB.Recordset
        'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        rsfecha.Open("select detcomprobfechaemision from ct_detcomprob" & VGParamSistem.Anoproceso & " where documentocodigo='" & CtrAyu_TipRef.xclave & "' and " & "       detcomprobnumdocumento='" & Trim(TxNref.Text) & "' and " & "       analiticocodigo='" & Trim(CtrAyu_Analitico.xclave) & "'", VGCNx, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If rsfecha.RecordCount = 0 Then
            MsgBox("No se encuentro el documento de referencia", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Dtp_FechaDocRef.Value = rsfecha.Fields("detcomprobfechaemision")
        Call Dtp_FechaDocRef_Change(Dtp_FechaDocRef, New System.EventArgs())
    End Sub

    Private Sub txRuc_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txRuc.Change
        If Not VGflaglimpia Then Exit Sub
        ClsMM1 = New ClsMantMov1
        Call ClsMM1.ActualizarDetalle(rsmantenimiento, ClsMantMov1.Campos.detcomprobruc)
    End Sub
    Private Sub TxSerie_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TxSerie.Change
        If Not VGflaglimpia Then Exit Sub
        ClsMM1 = New ClsMantMov1
        Call ClsMM1.ActualizarDetalle(rsmantenimiento, ClsMantMov1.Campos.detcomprobnumdocumento)
    End Sub
    Public Sub CalcularTotales(ByVal rs As ADODB.Recordset)
        On Error GoTo ERRX
        Dim rsaux As ADODB.Recordset
        rsaux = rs.Clone(ADODB.LockTypeEnum.adLockReadOnly)
        Dim montosoles, montodolares As Double
        Dim difsoles, difdolares As Double
        Dim montosolesDebe, montodolaresDebe As Double
        Dim montosolesHaber, montodolaresHaber As Double

        montosolesDebe = 0 : montodolaresDebe = 0
        montosolesHaber = 0 : montodolaresHaber = 0
        difsoles = 0 : difdolares = 0
        rsaux.MoveFirst()
        While Not rsaux.EOF
            If rsaux.Fields("indicador").Value = "D" Then
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                montosolesDebe = montosolesDebe + System.Math.Round(ESNULO(rsaux.Fields("montosol"), 0), 2)
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                montodolaresDebe = montodolaresDebe + System.Math.Round(ESNULO(rsaux.Fields("montouss"), 0), 2)
            Else
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                montosolesHaber = montosolesHaber + System.Math.Round(ESNULO(rsaux.Fields("montosol"), 0), 2)
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                montodolaresHaber = montodolaresHaber + System.Math.Round(ESNULO(rsaux.Fields("montouss"), 0), 2)
            End If
            rsaux.MoveNext()
        End While
        difsoles = montosolesDebe - montosolesHaber
        difdolares = montodolaresDebe - montodolaresHaber
        'Soles
        LbTotales0.Text = Format(montosolesDebe, "###,###,###,###.00 ") ' Debe
        LbTotales1.Text = Format(montosolesHaber, "###,###,###,###.00 ") ' Haber
        LbTotales2.Text = Format(difsoles, "###,###,###,###.00 ") ' Diferencia
        'Dolares
        LbTotales3.Text = Format(montodolaresDebe, "###,###,###,###.00 ") ' Debe
        LbTotales4.Text = Format(montodolaresHaber, "###,###,###,###.00 ") ' Haber
        LbTotales5.Text = Format(difdolares, "###,###,###,###.00 ") ' Diferencia

ERRX:
    End Sub

    Private Sub GetCamposdeConsulta()
        rscampo = New ADODB.Recordset
        Call rscampo.Fields.Append("codigo", ADODB.DataTypeEnum.adVarChar, 60)
        Call rscampo.Fields.Append("Nombre", ADODB.DataTypeEnum.adVarChar, 50)
        rscampo.Open()
        rscampo.AddNew()
        rscampo.Fields("codigo").Value = "cabcomprobnumero"
        rscampo.Fields("nombre").Value = "Nro. Comprobante"
        rscampo.Update()
        rscampo.AddNew()
        rscampo.Fields("codigo").Value = "convert(varchar(10),cabcomprobfeccontable,103)"
        rscampo.Fields("nombre").Value = "Fecha de Comprobante"
        rscampo.Update()
        Dtc_Campo.RowSource = rscampo
        Dtc_Campo.BoundText = "cabcomprobnumero"
    End Sub
    Private Sub EjecutarConsulta(ByVal criterio As String, Optional ByVal todos As Boolean = False)
        Dim cad As String
        Dim xasiento, sqlcad, xsubasiento As String
        rscabecera = New ADODB.Recordset
        '  VGvardllgen = New dllgeneral.dll_general
        xasiento = Trim(CtrAyu_Asiento.xclave) : xsubasiento = Trim(CtrAyu_SubAsiento.xclave)
        If criterio = "" Then
            cad = " where empresacodigo='" & VGParametros.empresacodigo & "'"
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(xsubasiento, %%). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(xasiento, %%). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            cad = cad & " and cabcomprobmes=" & CShort(VGParamSistem.Mesproceso) & " and  asientocodigo like '" & ESNULO(xasiento, "%%") & "' and  subasientocodigo='" & ESNULO(xsubasiento, "%%") & "' and 1=0 "
        Else
            cad = " where empresacodigo='" & VGParametros.empresacodigo & "'"
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(xsubasiento, %%). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ESNULO(xasiento, %%). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            cad = cad & " and cabcomprobmes=" & CShort(VGParamSistem.Mesproceso) & " and asientocodigo like '" & ESNULO(xasiento, "%%") & "' and  subasientocodigo like '" & ESNULO(xsubasiento, "%%") & "' and "
        End If
        If todos Then cad = " where empresacodigo='" & VGParametros.empresacodigo & "' and cabcomprobmes=" & CShort(VGParamSistem.Mesproceso) & "  "
        sqlcad = "select * from " & VGParamSistem.TablaCabcomprob & " " & cad & criterio
        rscabecera.Open(sqlcad, VGCNx, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If rscabecera.RecordCount > 0 Then
            lbl_nregconsulta.Text = Format(rscabecera.RecordCount, "0 ")
            TDBG_Consulta.Focus()
        Else
            lbl_nregconsulta.Text = Format(0, "0 ")
            TxEjecutar.Focus()
        End If
        TDBG_Consulta.DataSource = rscabecera
    End Sub
    Private Sub Mostrar()
        If rscabecera.State = 0 Then Exit Sub
        If rscabecera.RecordCount = 0 Then Exit Sub
        ClsMM1 = New ClsMantMov1
        '  VGvardllgen = New dllgeneral.dll_general
        Call ClearControlsInframe(FrameCabecera, Me)

        Call ClsMM1.MostrarCabecera(rscabecera.Fields)
        Call ClsMM1.Limpia()
        Call PrepararTemporalDetalle()
        Call ClsMM1.MostrarDetalle(rsmantenimiento)
        Call HabilitarDetalleContab(True, FramDetalle, Me)
        Call ActivaTab(1, 1, SSTabMant)
        VlUltAccion = 4
        Call PBoton(VlUltAccion)
    End Sub
    Private Sub PrepararTemporalDetalle()
        rsmantenimiento = New ADODB.Recordset
        Call ClsMM1.CreaRsTempDetalle(rsmantenimiento)
        rsmantenimiento.Open()
        rsmantenimiento.Sort = "detcomprobitem asc,index asc"
        TDBG_Det.DataSource = rsmantenimiento
    End Sub
    Public Sub Botones(ByRef tool As System.Windows.Forms.ToolStrip, ByRef Nuevo As Boolean, ByRef grabar As Boolean, ByRef eliminar As Boolean, ByRef modificar As Boolean, ByRef Cancelar As Boolean, ByRef Anadet As Boolean, ByRef EliDet As Boolean)
        With tool.Items
            'UPGRADE_WARNING: El límite inferior de la colección tool.Buttons cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            .Item(1).Enabled = Nuevo
            'UPGRADE_WARNING: El límite inferior de la colección tool.Buttons cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            .Item(2).Enabled = grabar
            'UPGRADE_WARNING: El límite inferior de la colección tool.Buttons cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            .Item(3).Enabled = eliminar
            'UPGRADE_WARNING: El límite inferior de la colección tool.Buttons cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            .Item(4).Enabled = modificar
            'UPGRADE_WARNING: El límite inferior de la colección tool.Buttons cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            .Item(5).Enabled = Cancelar
            'UPGRADE_WARNING: El límite inferior de la colección tool.Buttons cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            .Item(6).Visible = True
            'UPGRADE_WARNING: El límite inferior de la colección tool.Buttons cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            .Item(7).Visible = True
            'UPGRADE_WARNING: El límite inferior de la colección tool.Buttons cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            .Item(8).Visible = True
            'UPGRADE_WARNING: El límite inferior de la colección tool.Buttons cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            .Item(7).Enabled = Anadet
            'UPGRADE_WARNING: El límite inferior de la colección tool.Buttons cambió de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            .Item(8).Enabled = EliDet
        End With
        With MDIPrincipal
            .mnu00_01(1).Enabled = Nuevo
            .mnu00_01(2).Enabled = grabar
            .mnu00_01(3).Enabled = eliminar
            .mnu00_01(4).Enabled = modificar
            .mnu00_01(5).Enabled = Cancelar
            .mnu00_01(6).Visible = True
            .mnu00_01(7).Visible = True
            .mnu00_01(6).Enabled = Anadet
            .mnu00_01(7).Enabled = EliDet
        End With
    End Sub
    Public Sub Xnuevo()
        'Validacion

        Call PrepararTemporalDetalle()
        If Trim(CtrAyu_Asiento.xclave) = "" Or Trim(CtrAyu_SubAsiento.xclave) = "" Then
            MsgBox("Necesita seleccionar el Asiento y el SubAsiento para poder ingresar " & Chr(13) & "Un Nuevo Comprobante", MsgBoxStyle.Information)
            Exit Sub
        End If
        '  VGvardllgen = New dllgeneral.dll_general
        Call ClearControlsInframe(FrameCabecera, Me)
        Call DTPFechaComprobCab_Change(DTPFechaComprobCab, New System.EventArgs())
        VPAsiento = CtrAyu_Asiento.xclave
        VPSubAsiento = CtrAyu_SubAsiento.xclave
        lbnregdetalle.Text = "0 "
        ClsMM1 = New ClsMantMov1
        Call ClsMM1.Limpia()
        Call ActivaTab(1, 1, SSTabMant)
        DTPFechaComprobCab.Focus()
        If ClsMM1.CargarPlantillaAsiento(rsmantenimiento, VPAsiento, VPSubAsiento) Then
            Call HabilitarDetalleContab(True, FramDetalle, Me)
        Else
            Call HabilitarDetalleContab(False, FramDetalle, Me)
        End If
        'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        TxGlosaComprobCab.Text = VGGlosa
        lbNumComprobCab.Text = ClsMM1.NumeroComprob(CShort(VGParamSistem.Mesproceso))
        Dim Existelibro As Boolean

        Existelibro = ExisteSQL(VGCNx, "Select flagcontrol From ct_libro where librocodigo='" & Trim(VlLibro) & "' and flagcontrol <> 0 ")
        lbNumComprobCablibro.Text = ClsMM1.NumeroComprobLibro(CShort(VGParamSistem.Mesproceso), VlLibro)

        ChkGrabado.CheckState = System.Windows.Forms.CheckState.Checked
        IMant = 1
        VlUltAccion = 1
        FrameIngreso.Visible = False

        If VGParametros.ingresoformatorapido And rsmantenimiento.RecordCount > 0 Then
            Call ClsMM1.ActivaIngresorapido(rsmantenimiento, Me)
            FrameIngreso.Visible = True
        End If
    End Sub

    Public Sub grabar()
        Dim xnumerocompro As String
        Dim nnumerocorrcomprob As Double
        Dim xnumerocomprolibro As String
        Dim nnumerocorrcomproblibro As Integer
        Dim Existelibro As Boolean

        Dim varnerror As Short
        '  VGvardllgen = New dllgeneral.dll_general
        On Error GoTo ErrorGrabar
        Dim xcon As Integer
        xnumerocomprolibro = "" : nnumerocorrcomproblibro = 0
        VGvarVerifica = True
        VGErrorString = ""
        varnerror = 0
        rsmantenimiento.Filter = 0
        ClsMM1 = New ClsMantMov1
        If Not ClsMM1.ValidarGrabarCabecera((rsmantenimiento.RecordCount)) Then Exit Sub
        If Not ClsMM1.ValidarRsDetalle(rsmantenimiento) Then Exit Sub

        xcon = rsmantenimiento.RecordCount

        If Vgdocumentoanulado <> "" Then
            rsmantenimiento.Filter = "operacioncodigo='" & Vgdocumentoanulado & "'"
        Else
            rsmantenimiento.Filter = "(montosol<>0 or montouss <> 0)"
        End If
        If rsmantenimiento.RecordCount <= 1 Then
            MsgBox("Por lo Menos debe Existir dos registro con valores ", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If rsmantenimiento.RecordCount <> xcon Then
            If MsgBox("Esta Seguro de Grabar ? " & Chr(13) & "Al momento de grabar se eliminaran lo registro ceros ", MsgBoxStyle.Question + MsgBoxStyle.OKCancel) = MsgBoxResult.Cancel Then
                rsmantenimiento.Filter = 0
                Exit Sub
            End If
        End If
        Existelibro = ExisteSQL(VGCNx, "Select flagcontrol From ct_libro where librocodigo='" & Trim(VlLibro) & "' and flagcontrol <> 0 ")


        VGGeneral.BeginTrans() 'Inicio la transaccion
        'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        '1=>Paso Genera el Correlativo del Comprobante
        If IMant = 1 Then
            xnumerocompro = ClsMM1.NumeroComprob(CShort(VGParamSistem.Mesproceso), nnumerocorrcomprob)
            If Existelibro Then
                xnumerocomprolibro = ClsMM1.NumeroComprobLibro(CShort(VGParamSistem.Mesproceso), VlLibro, nnumerocorrcomproblibro)
            End If
            '6=>Paso Actualizo el Correlativo en la Tabla SubAsiento si es que ingrese un nuevo
            'Comprobante
            If IMant = 1 Then
                Call ClsMM1.ActualizaCorrelComprob(nnumerocorrcomprob)
                If Existelibro Then Call ClsMM1.ActualizaCorrelComprobLibro(nnumerocorrcomproblibro, VlLibro)
            End If
            If Not VGvarVerifica Then varnerror = 6 : GoTo ErrorGrabar
        Else
            xnumerocompro = Trim(lbNumComprobCab.Text)
            xnumerocomprolibro = Trim(lbNumComprobCablibro.Text)
        End If
        If Not VGvarVerifica Then varnerror = 1 : GoTo ErrorGrabar
        '2=>Paso Grabo la Cabecera del Comprobante
        Call ClsMM1.GrabarCabecera(IMant, xnumerocompro, xnumerocomprolibro)
        If Not VGvarVerifica Then varnerror = 2 : GoTo ErrorGrabar
        '3=>Paso Grabo los Detalle del Comprobante


        Call ClsMM1.GrabarDetalle(rsmantenimiento, xnumerocompro, xnumerocomprolibro)
        If Not VGvarVerifica Then varnerror = 3 : GoTo ErrorGrabar
        '4=>Generar Asientos Automaticos
        Call ClsMM1.GrabaAsientoAuto(xnumerocompro)
        If Not VGvarVerifica Then varnerror = 4 : GoTo ErrorGrabar

        '5=>Calcular el total de Cabecera de Comprobante
        Call ClsMM1.CalculaComprob(xnumerocompro)
        If Not VGvarVerifica Then varnerror = 5 : GoTo ErrorGrabar

        VGGeneral.CommitTrans() 'Acepto toda la transaccion porque es correcta
        If IMant = 1 Then
            MsgBox("Se grabo Satisfactoriamente  El numero de Comprobante Generado Es :" & Chr(13) & "Nro: " & xnumerocompro & IIf(Existelibro, Chr(13) & "El Numero de Libro es : " & xnumerocomprolibro, ""), MsgBoxStyle.Information)
            If VGParametros.ImpresionAsiento Then
                Call ImprimirComprob(xnumerocompro, VPAsiento, VPSubAsiento)
            End If
        Else
            MsgBox("Se Actualizo Satisfactoriamente  ", MsgBoxStyle.Information)
        End If
        'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        IMant = 0
        If rscabecera.State = 1 Then
            rscabecera.Requery()
        End If
        Call Cancelar()
        'Esta Forma es grabar y Actualizar
        '    rscabecera.Filter = "cabcomprobmes=" & Month(DTPFechaComprobCab) & " and cabcomprobnumero='" & Trim$(xnumerocompro) & "' and " & _
        ''                    "subasientocodigo='" & Trim$(VPSubAsiento) & "' and  asientocodigo='" & VPAsiento & "'"
        '    Call Modificar
        '    rscabecera.Filter = 0

        Exit Sub
        'Validando Errores
ErrorGrabar:
        Select Case varnerror
            Case 1
                MsgBox("No se Genero Correctamente el numero del Comprobante" & Chr(13) & VGErrorString, MsgBoxStyle.Exclamation)
            Case 2, 3, 4, 5, 6
                VGGeneral.RollbackTrans()
                MsgBox("Hubo Errores al Grabar" & Chr(13) & VGErrorString, MsgBoxStyle.Exclamation)
                Call Cancelar()
            Case Else
                MsgBox("Errores Desconocidos " & Chr(13) & Err.Description)
        End Select
        'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Exit Sub
        Resume Next
    End Sub
    Public Sub modificar()
        IMant = 2
        Call Mostrar()
    End Sub
    Public Sub eliminar()

        If MsgBox("Esta Seguro que desea Eliminar este Comprobante", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        ClsMM1 = New ClsMantMov1
        VGGeneral.BeginTrans()
        'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Call ClsMM1.GrabarCabecera(3, Trim(lbNumComprobCab.Text))
        'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        VGGeneral.CommitTrans()
        If rscabecera.State = 1 Then
            rscabecera.Requery()
        End If

        MsgBox("El Registro se Elimino Correctamente")
        Call Cancelar()
        'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        VlUltAccion = 3
    End Sub
    Public Sub Cancelar()
        '  VGvardllgen = New dllgeneral.dll_general
        If SSTabMant.SelectedIndex = 1 Then
            Call ActivaTab(0, 1, SSTabMant)
            VlUltAccion = 5
            'UPGRADE_NOTE: El objeto rsmantenimiento no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            rsmantenimiento = Nothing
        End If

    End Sub
    Public Sub AñadirDetalle()
        ClsMM1 = New ClsMantMov1
        If rsmantenimiento.RecordCount > 0 Then
            If Not ClsMM1.ValidarGrabarDetalle Then Exit Sub
        End If
        Call HabilitarDetalleContab(True, FramDetalle, Me)
        Call ClsMM1.AñadiralDetalle(rsmantenimiento)
        lbnregdetalle.Text = Format(rsmantenimiento.RecordCount, "0 ")
        CtrAyu_Opera.Focus()
        Call HabilitarSegunCuenta(False, False, False)
    End Sub
    Public Sub EliminarDetalle()
        Dim num As Short
        Dim reg As Integer
        On Error Resume Next
        If rsmantenimiento.State = 0 Then Exit Sub
        If rsmantenimiento.RecordCount = 0 Then Exit Sub
        If IMant = 1 Then
            If VerificaItemPlant(rsmantenimiento.Fields("NumPlantilla").Value) Then
                MsgBox("Este item corresponde a una plantilla " & Chr(13) & "por lo tanto no se podra Eliminar ", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        End If
        If rsmantenimiento.Fields("detcomprobauto").Value Then
            MsgBox("No se puede eliminar los asientos automaticos", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        ClsMM1 = New ClsMantMov1
        If rsmantenimiento.RecordCount = 1 Then
            ClsMM1.Limpia()
        End If
        num = CShort(rsmantenimiento.Fields("detcomprobitem").Value)
        reg = rsmantenimiento.RecordCount
        rsmantenimiento.Delete()
        If num = reg Then
            rsmantenimiento.MoveNext()
        Else
            Call ClsMM1.ActualizaNumItems(rsmantenimiento, num)
        End If
        Call ClsMM1.VerfiSiEsPlantilla(rsmantenimiento)
    End Sub
    Private Function VerificaItemPlant(ByRef dato As Short) As Boolean
        Dim rsaux As ADODB.Recordset
        rsaux = New ADODB.Recordset
        VerificaItemPlant = False
        Dim sqlcad As String
        sqlcad = "Select * from ct_plantillaasiento where subasientocodigo='" & Trim(VPSubAsiento) & "' and " & "asientocodigo='" & Trim(VPAsiento) & "' and plantillaasientocorrela=" & dato & " and (plantillaasientoctaajuste =0 and plantillaasientoinafecto = 0)"
        rsaux.Open(sqlcad, VGCNx, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If rsaux.RecordCount > 0 Then
            VerificaItemPlant = True
        End If
    End Function

    Private Sub TxSerie_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TxSerie.Leave
        'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        If IsNumeric(TxSerie.Text) Then
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            TxSerie.Text = Format(TxSerie.Text, "0000")
        Else
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            TxSerie.Text = TxSerie.Text & Func.Left("    ", TxSerie.MaxLength - Len(TxSerie.Text))
        End If
    End Sub



    Private Sub TxSerie1_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TxSerie1.Leave
        'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        If IsNumeric(TxSerie1.Text) Then
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            TxSerie1.Text = Format(TxSerie1.Text, "0000")
        Else
            'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            TxSerie1.Text = TxSerie1.Text & Func.Left("    ", TxSerie1.MaxLength - Len(TxSerie1.Text))
        End If
    End Sub
	
	
	
	
	Private Sub TxtIgv_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TxtIgv.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = 13 Then
			TxtTot.Text = CStr(Val(Txtimpo.Text) + Val(TxtIgv.Text))
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub Txtimpo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Txtimpo.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = 13 Then
			TxtIgv.Text = CStr(System.Math.Round(CDbl(Txtimpo.Text) * VGParametros.IGV / 100, 2))
			TxtTot.Text = CStr(Val(Txtimpo.Text) + Val(TxtIgv.Text))
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	
	
	
	Private Sub TxtInaf_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TxtInaf.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = 13 Then
			TxtTot.Text = CStr(Val(Txtimpo.Text) + Val(TxtIgv.Text) + Val(TxtInaf.Text))
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub TxtPerc_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TxtPerc.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = 13 Then
			TxtTot.Text = CStr(Val(Txtimpo.Text) + Val(TxtIgv.Text) + Val(TxtInaf.Text) + Val(TxtPerc.Text))
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub TxValor_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TxValor.Change
		If Not VGflaglimpia Then Exit Sub
		If VGMoverRegistro Then Exit Sub
		ClsMM1 = New ClsMantMov1
		Call ClsMM1.ActualizarDetalle(rsmantenimiento, ClsMantMov1.Campos.Montos)
		Call CalcularTotales(rsmantenimiento)
	End Sub
	Public Sub imprimir()
		If rscabecera Is Nothing Then Exit Sub
		If rscabecera.State = 0 Then Exit Sub
		If rscabecera.RecordCount = 0 Then Exit Sub
		Call ImprimirComprob(rscabecera.Fields("cabcomprobnumero").Value, rscabecera.Fields("asientocodigo").Value, rscabecera.Fields("subasientocodigo").Value)
	End Sub
	Private Sub ImprimirComprob(ByRef Ncomprob As String, ByRef Asiento As String, ByRef SubAsiento As String)
		'FIXIT: Declare 'arrform' con un tipo de datos de enlace en tiempo de compilación          FixIT90210ae-R1672-R1B8ZE
		Dim arrform(0) As Object
		Dim arrparm(7) As Object
		'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(0) = Trim(VGParamSistem.BDEmpresa)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(1). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(1) = VGParametros.empresacodigo
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(2). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(2) = Trim(VGParamSistem.Anoproceso)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(3). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(3) = Trim(VGParamSistem.Mesproceso)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(4). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(4) = Trim(Ncomprob)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(5). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(5) = Trim(Asiento)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrparm(6). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrparm(6) = Trim(SubAsiento)
		Call ImpresionRptProc("rptVoucherComprob.rpt", arrform, arrparm)
		'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
	End Sub
	
	Public Sub PMant(ByRef Index As Short)
		Select Case Index
			Case 1
				Call Xnuevo()
			Case 2
				Call grabar()
			Case 3 'Eliminar
				Call eliminar()
			Case 4 'Modificar
				Call modificar()
			Case 5
				Call Cancelar()
			Case 6
				Call AñadirDetalle()
			Case 7
				Call EliminarDetalle()
			Case 8
				Call imprimir()
		End Select
		Call PBoton(VlUltAccion)
	End Sub
	Public Sub Pavant(ByRef Index As Short)
		If rsmantenimiento.RecordCount = 0 Then
			MsgBox("No puede utilizar esta funcion porque no " & Chr(13) & "Existe ningun registro en el comprobante", MsgBoxStyle.Information)
		End If
		Select Case Index
			Case 1
				Me.TxMonto.Focus()
			Case 2
				Me.CtrAyu_Opera.Focus()
		End Select
	End Sub
	Private Sub PBoton(ByRef Index As Short)
		Select Case Index
			Case 0, 5
				Call Botones((MDIPrincipal.ToolComprob), True, False, False, True, False, False, False)
			Case 1 'nuevo
				Call Botones((MDIPrincipal.ToolComprob), False, True, False, False, True, True, True)
			Case 3 'Eliminar
				Call Botones((MDIPrincipal.ToolComprob), True, False, False, True, False, False, False)
			Case 4 'Modificar
				Call Botones((MDIPrincipal.ToolComprob), False, True, True, False, True, True, True)
		End Select
	End Sub
	Private Sub MuestraDocPend()
		Dim RsPend As ADODB.Recordset
		Dim CamposPend As ADODB.Fields
		Dim dato As String
		On Error GoTo DocPend
		If Not (CtrAyu_Opera.xclave <> "00" And CtrAyu_Opera.xclave <> "01") Then
			MsgBox("Aqui se ven documentos pendientes a un analitico " & Chr(13) & "cuando el tipo de operacion es diferente de una provisión", MsgBoxStyle.Information)
			Exit Sub
		End If
		If CtrAyu_Cuenta.xclave <> "00" And CtrAyu_Cuenta.xclave = "" Then
			MsgBox("Tiene que seleccionar un cuenta ", MsgBoxStyle.Information)
			Exit Sub
		End If
		If CtrAyu_Analitico.xclave <> "00" And CtrAyu_Analitico.xclave = "" Then
			MsgBox("Tiene que seleccionar un Analitico ", MsgBoxStyle.Information)
			Exit Sub
		End If
		'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		RsPend = New ADODB.Recordset
		VGCommandoSP = New ADODB.Command
		VGCommandoSP.let_ActiveConnection(VGGeneral)
		VGCommandoSP.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
		VGCommandoSP.CommandText = "ct_MuestraPend_pro"
		VGCommandoSP.Parameters.Refresh()
		With VGCommandoSP
			.Parameters("@base").Value = VGParamSistem.BDEmpresa
			.Parameters("@empresa").Value = VGParametros.empresacodigo
			.Parameters("@Ano").Value = VGParamSistem.Anoproceso
			.Parameters("@mes").Value = VGParamSistem.Mesproceso
			.Parameters("@cuenta").Value = CtrAyu_Cuenta.xclave
			.Parameters("@analitico").Value = RTrim(CtrAyu_Analitico.xclave)
			RsPend = .Execute
		End With
		'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
		If RsPend.RecordCount = 0 Then
			MsgBox("No existe es registro de Documentos Pendientes")
			Exit Sub
		End If
		Call FrmDocPend.RecibeRs(RsPend, CamposPend)
		If Not (CamposPend Is Nothing) Then
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			TxNdoc.Text = ""
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			TxSerie.Text = ""
			CtrAyu_TipDoc.xclave = Trim(CamposPend("DocumentoCodigo").Value) : CtrAyu_TipDoc.Ejecutar()
			dato = RTrim(CamposPend("ctacteanaliticonumdocumento").Value)
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			TxSerie.Text = Mid(dato, 1, TxSerie.MaxLength)
			If Len(dato) > TxSerie.MaxLength Then
				'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
				TxNdoc.Text = Mid(dato, TxSerie.MaxLength + 1, Len(dato) - TxSerie.MaxLength)
			Else
				'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
				TxNdoc.Text = ""
			End If
			Dtp_FechaDoc.Value = CamposPend("ctacteanaliticofechadoc").Value
			Call Dtp_FechaDoc_Change(Dtp_FechaDoc, New System.EventArgs())
			'      CmbTcambio.ListIndex = CInt(CamposPend("detcomprobformacambio").Value) - 1
			'      VGValorCambio = CamposPend("detcomprobtipocambio").Value
			'     lb_vcambio.Caption = Format(VGValorCambio, "#.000 ")
			CtrAyu_Moneda.xclave = CamposPend("monedacodigo").Value : CtrAyu_Moneda.Ejecutar()
			TxMonto.valor = CamposPend("Saldo").Value
			'UPGRADE_NOTE: Text se actualizó a CtlText. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			TxMonto.Text = CamposPend("Saldo").Value
			
		End If
		Exit Sub
DocPend: 
		'UPGRADE_WARNING: Screen propiedad Screen.MousePointer tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow
		MsgBox("No se Puede mostrar los Documentos Pendientes " & Chr(13) & Err.Description, MsgBoxStyle.Exclamation)
	End Sub
	
	WriteOnly Property CodComprob() As String
		Set(ByVal Value As String)
			m_CodComprob = Value
		End Set
	End Property
	
	Private Function VerififcaAdicionCargo() As Boolean
		Dim rsX As ADODB.Recordset
		Dim sqlcad As String

		Dim CuentaCargo As String
		
		rsX = New ADODB.Recordset
		VerififcaAdicionCargo = False
		
		sqlcad = "Select cuentaadicionacargo from ct_cuenta where cuentacodigo='" & CtrAyu_Cuenta.xclave & "' "
		rsX.Open(sqlcad, VGCNx, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
		If rsX.RecordCount > 0 Then
			CuentaCargo = rsX.Fields("cuentaadicionacargo").Value
		End If
	End Function
End Class