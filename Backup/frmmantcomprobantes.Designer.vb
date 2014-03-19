<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmantcomprobantes
#Region "Código generado por el Diseñador de Windows Forms "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'Llamada necesaria para el Diseñador de Windows Forms.
		InitializeComponent()
		'Éste es un formulario MDI secundario.
		'Este código simula la funcionalidad de VB6 
		' de cargar automáticamente
		' y mostrar el formulario primario de
		' un MDI secundario.
		Me.MDIParent = Contabilidad.MDIPrincipal
		Contabilidad.MDIPrincipal.Show
	End Sub
	'Form invalida a Dispose para limpiar la lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Requerido por el Diseñador de Windows Forms
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents DTPFechaContab As AxMSComCtl2.AxDTPicker
	Public WithEvents CtrAyu_SubAsiento As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents CtrAyu_Asiento As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Image1 As System.Windows.Forms.PictureBox
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Shape5 As Microsoft.VisualBasic.PowerPacks.RectangleShape
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label25 As System.Windows.Forms.Label
	Public WithEvents lbSubAsiento As System.Windows.Forms.Label
	Public WithEvents Shape6 As Microsoft.VisualBasic.PowerPacks.RectangleShape
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents TxEjecutar As AxTextFer.AxTxFer
	Public WithEvents ChkTodos As System.Windows.Forms.CheckBox
	Public WithEvents Dtc_Campo As AxMSDataListLib.AxDataCombo
	Public WithEvents TDBG_Consulta As AxTrueOleDBGrid70.AxTDBGrid
	Public WithEvents Shape8 As Microsoft.VisualBasic.PowerPacks.RectangleShape
	Public WithEvents Shape7 As Microsoft.VisualBasic.PowerPacks.RectangleShape
	Public WithEvents lbl_nregconsulta As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents FrameConsulta As System.Windows.Forms.GroupBox
	Public WithEvents _SSTabMant_TabPage0 As System.Windows.Forms.TabPage
	Public WithEvents Shilu2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
	Public WithEvents Shilu1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
	Public WithEvents CmdDocPend As System.Windows.Forms.Button
	Public WithEvents ChkInafecto As System.Windows.Forms.CheckBox
	Public WithEvents TxValor As AxTextFer.AxTxFer
	Public WithEvents ChkAjusta As System.Windows.Forms.CheckBox
	Public WithEvents TxMonto As AxTextFer.AxTxFer
	Public WithEvents TxNdoc As AxTextFer.AxTxFer
	Public WithEvents TxSerie As AxTextFer.AxTxFer
	Public WithEvents txRuc As AxTextFer.AxTxFer
	Public WithEvents CtrAyu_Moneda As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents CtrAyu_TipDoc As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents CtrAyu_Analitico As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents CtrAyu_TipAnal As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents CtrAyu_CCosto As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents CtrAyu_Cuenta As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents CtrAyu_Opera As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents CmbID As System.Windows.Forms.ComboBox
	Public WithEvents CmbTcambio As System.Windows.Forms.ComboBox
	Public WithEvents Dtp_FechaDoc As AxMSComCtl2.AxDTPicker
	Public WithEvents DtpFech_Ven As AxMSComCtl2.AxDTPicker
	Public WithEvents TxGlosa As AxTextFer.AxTxFer
	Public WithEvents CtrAyu_TipRef As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents TxNref As AxTextFer.AxTxFer
	Public WithEvents Dtp_FechaDocRef As AxMSComCtl2.AxDTPicker
	Public WithEvents lbnref As System.Windows.Forms.Label
	Public WithEvents lbtipref As System.Windows.Forms.Label
	Public WithEvents lbconv As System.Windows.Forms.Label
	Public WithEvents lb_vcambio As System.Windows.Forms.Label
	Public WithEvents _lbTipAnal_0 As System.Windows.Forms.Label
	Public WithEvents lbAnalitico As System.Windows.Forms.Label
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents Label12 As System.Windows.Forms.Label
	Public WithEvents lbccosto As System.Windows.Forms.Label
	Public WithEvents lbruc As System.Windows.Forms.Label
	Public WithEvents Shape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
	Public WithEvents Shape4 As Microsoft.VisualBasic.PowerPacks.RectangleShape
	Public WithEvents lbtipdoc As System.Windows.Forms.Label
	Public WithEvents lbndocum As System.Windows.Forms.Label
	Public WithEvents lbFechaDoc As System.Windows.Forms.Label
	Public WithEvents lbFechVen As System.Windows.Forms.Label
	Public WithEvents Label19 As System.Windows.Forms.Label
	Public WithEvents Label20 As System.Windows.Forms.Label
	Public WithEvents Label21 As System.Windows.Forms.Label
	Public WithEvents Label22 As System.Windows.Forms.Label
	Public WithEvents Label23 As System.Windows.Forms.Label
	Public WithEvents Label24 As System.Windows.Forms.Label
	Public WithEvents FramDetalle As System.Windows.Forms.GroupBox
	Public WithEvents _SSTab2_TabPage0 As System.Windows.Forms.TabPage
	Public WithEvents SSTab2 As System.Windows.Forms.TabControl
	Public WithEvents _StBar_Panel1 As System.Windows.Forms.ToolStripStatusLabel
	Public WithEvents _StBar_Panel2 As System.Windows.Forms.ToolStripStatusLabel
	Public WithEvents _StBar_Panel3 As System.Windows.Forms.ToolStripStatusLabel
	Public WithEvents _StBar_Panel4 As System.Windows.Forms.ToolStripStatusLabel
	Public WithEvents StBar As System.Windows.Forms.StatusStrip
	Public WithEvents TDBG_Det As AxTrueOleDBGrid70.AxTDBGrid
	Public WithEvents Shape10 As Microsoft.VisualBasic.PowerPacks.RectangleShape
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents lbnregdetalle As System.Windows.Forms.Label
	Public WithEvents Shape9 As Microsoft.VisualBasic.PowerPacks.RectangleShape
	Public WithEvents frameGrid As System.Windows.Forms.GroupBox
	Public WithEvents ChkGrabado As System.Windows.Forms.CheckBox
	Public WithEvents DTPFechaComprobCab As AxMSComCtl2.AxDTPicker
	Public WithEvents TxGlosaComprobCab As AxTextFer.AxTxFer
	Public WithEvents TxObsComprobCab As AxTextFer.AxTxFer
	Public WithEvents TxCtrNref As AxTextFer.AxTxFer
	Public WithEvents lbNumComprobCablibro As System.Windows.Forms.Label
	Public WithEvents _leNComprob_0 As System.Windows.Forms.Label
	Public WithEvents lbnemoref As System.Windows.Forms.Label
	Public WithEvents Shape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
	Public WithEvents leDebe As System.Windows.Forms.Label
	Public WithEvents Shape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
	Public WithEvents leHaber As System.Windows.Forms.Label
	Public WithEvents leSoles As System.Windows.Forms.Label
	Public WithEvents LeDolares As System.Windows.Forms.Label
	Public WithEvents _LbTotales_0 As System.Windows.Forms.Label
	Public WithEvents _LbTotales_1 As System.Windows.Forms.Label
	Public WithEvents _LbTotales_3 As System.Windows.Forms.Label
	Public WithEvents _LbTotales_4 As System.Windows.Forms.Label
	Public WithEvents leDifer As System.Windows.Forms.Label
	Public WithEvents _LbTotales_2 As System.Windows.Forms.Label
	Public WithEvents _LbTotales_5 As System.Windows.Forms.Label
	Public WithEvents _leNComprob_1 As System.Windows.Forms.Label
	Public WithEvents lbNumComprobCab As System.Windows.Forms.Label
	Public WithEvents _leFechaComprob_7 As System.Windows.Forms.Label
	Public WithEvents leGlosa As System.Windows.Forms.Label
	Public WithEvents leObservaciones As System.Windows.Forms.Label
	Public WithEvents FrameCabecera As System.Windows.Forms.GroupBox
	Public WithEvents TDBGrid1 As AxTrueOleDBGrid70.AxTDBGrid
	Public WithEvents FrameCcosto As System.Windows.Forms.GroupBox
	Public WithEvents Cmdsalir As System.Windows.Forms.Button
	Public WithEvents CmdAceptar As System.Windows.Forms.Button
	Public WithEvents Frame5 As System.Windows.Forms.GroupBox
	Public WithEvents Txtimpo As System.Windows.Forms.TextBox
	Public WithEvents TxtIgv As System.Windows.Forms.TextBox
	Public WithEvents TxtInaf As System.Windows.Forms.TextBox
	Public WithEvents TxtTot As System.Windows.Forms.TextBox
	Public WithEvents TxtPerc As System.Windows.Forms.TextBox
	Public WithEvents Labelimpo As System.Windows.Forms.Label
	Public WithEvents Labeligv As System.Windows.Forms.Label
	Public WithEvents Labelinaf As System.Windows.Forms.Label
	Public WithEvents Labeltot As System.Windows.Forms.Label
	Public WithEvents Labelperc As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents CtrAyu_Analitico1 As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents CtrAyu_Cuenta1 As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents CtrAyu_Cuenta2 As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents Label27 As System.Windows.Forms.Label
	Public WithEvents Label14 As System.Windows.Forms.Label
	Public WithEvents Frame4 As System.Windows.Forms.GroupBox
	Public WithEvents TxNdoc1 As AxTextFer.AxTxFer
	Public WithEvents TxSerie1 As AxTextFer.AxTxFer
	Public WithEvents DTP_fecha1 As AxMSComCtl2.AxDTPicker
	Public WithEvents CtrAyu_Moneda1 As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents CtrAyu_TipDoc1 As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents TxFer1 As AxTextFer.AxTxFer
	Public WithEvents Label26 As System.Windows.Forms.Label
	Public WithEvents Label28 As System.Windows.Forms.Label
	Public WithEvents Label17 As System.Windows.Forms.Label
	Public WithEvents Label16 As System.Windows.Forms.Label
	Public WithEvents Label15 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents FrameIngreso As System.Windows.Forms.GroupBox
	Public WithEvents _SSTabMant_TabPage1 As System.Windows.Forms.TabPage
	Public WithEvents SSTabMant As System.Windows.Forms.TabControl
	Public WithEvents LbTotales As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents lbTipAnal As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents leFechaComprob As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents leNComprob As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents ShapeContainer7 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	Public WithEvents ShapeContainer6 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	Public WithEvents ShapeContainer5 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	Public WithEvents ShapeContainer4 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	Public WithEvents ShapeContainer3 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	Public WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmantcomprobantes))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ShapeContainer7 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
		Me.ShapeContainer6 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
		Me.ShapeContainer5 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
		Me.ShapeContainer4 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
		Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
		Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
		Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
		Me.SSTabMant = New System.Windows.Forms.TabControl
		Me._SSTabMant_TabPage0 = New System.Windows.Forms.TabPage
		Me.Frame3 = New System.Windows.Forms.GroupBox
		Me.DTPFechaContab = New AxMSComCtl2.AxDTPicker
		Me.CtrAyu_SubAsiento = New Axctrlayuda_f.AxCtr_Ayuda
		Me.CtrAyu_Asiento = New Axctrlayuda_f.AxCtr_Ayuda
		Me.Label5 = New System.Windows.Forms.Label
		Me.Image1 = New System.Windows.Forms.PictureBox
		Me.Label3 = New System.Windows.Forms.Label
		Me.Shape5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
		Me.Label1 = New System.Windows.Forms.Label
		Me.Label25 = New System.Windows.Forms.Label
		Me.lbSubAsiento = New System.Windows.Forms.Label
		Me.Shape6 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
		Me.FrameConsulta = New System.Windows.Forms.GroupBox
		Me.TxEjecutar = New AxTextFer.AxTxFer
		Me.ChkTodos = New System.Windows.Forms.CheckBox
		Me.Dtc_Campo = New AxMSDataListLib.AxDataCombo
		Me.TDBG_Consulta = New AxTrueOleDBGrid70.AxTDBGrid
		Me.Shape8 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
		Me.Shape7 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
		Me.lbl_nregconsulta = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me._SSTabMant_TabPage1 = New System.Windows.Forms.TabPage
		Me.Shilu2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
		Me.SSTab2 = New System.Windows.Forms.TabControl
		Me._SSTab2_TabPage0 = New System.Windows.Forms.TabPage
		Me.Shilu1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
		Me.FramDetalle = New System.Windows.Forms.GroupBox
		Me.CmdDocPend = New System.Windows.Forms.Button
		Me.ChkInafecto = New System.Windows.Forms.CheckBox
		Me.TxValor = New AxTextFer.AxTxFer
		Me.ChkAjusta = New System.Windows.Forms.CheckBox
		Me.TxMonto = New AxTextFer.AxTxFer
		Me.TxNdoc = New AxTextFer.AxTxFer
		Me.TxSerie = New AxTextFer.AxTxFer
		Me.txRuc = New AxTextFer.AxTxFer
		Me.CtrAyu_Moneda = New Axctrlayuda_f.AxCtr_Ayuda
		Me.CtrAyu_TipDoc = New Axctrlayuda_f.AxCtr_Ayuda
		Me.CtrAyu_Analitico = New Axctrlayuda_f.AxCtr_Ayuda
		Me.CtrAyu_TipAnal = New Axctrlayuda_f.AxCtr_Ayuda
		Me.CtrAyu_CCosto = New Axctrlayuda_f.AxCtr_Ayuda
		Me.CtrAyu_Cuenta = New Axctrlayuda_f.AxCtr_Ayuda
		Me.CtrAyu_Opera = New Axctrlayuda_f.AxCtr_Ayuda
		Me.CmbID = New System.Windows.Forms.ComboBox
		Me.CmbTcambio = New System.Windows.Forms.ComboBox
		Me.Dtp_FechaDoc = New AxMSComCtl2.AxDTPicker
		Me.DtpFech_Ven = New AxMSComCtl2.AxDTPicker
		Me.TxGlosa = New AxTextFer.AxTxFer
		Me.CtrAyu_TipRef = New Axctrlayuda_f.AxCtr_Ayuda
		Me.TxNref = New AxTextFer.AxTxFer
		Me.Dtp_FechaDocRef = New AxMSComCtl2.AxDTPicker
		Me.lbnref = New System.Windows.Forms.Label
		Me.lbtipref = New System.Windows.Forms.Label
		Me.lbconv = New System.Windows.Forms.Label
		Me.lb_vcambio = New System.Windows.Forms.Label
		Me._lbTipAnal_0 = New System.Windows.Forms.Label
		Me.lbAnalitico = New System.Windows.Forms.Label
		Me.Label11 = New System.Windows.Forms.Label
		Me.Label12 = New System.Windows.Forms.Label
		Me.lbccosto = New System.Windows.Forms.Label
		Me.lbruc = New System.Windows.Forms.Label
		Me.Shape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
		Me.Shape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
		Me.lbtipdoc = New System.Windows.Forms.Label
		Me.lbndocum = New System.Windows.Forms.Label
		Me.lbFechaDoc = New System.Windows.Forms.Label
		Me.lbFechVen = New System.Windows.Forms.Label
		Me.Label19 = New System.Windows.Forms.Label
		Me.Label20 = New System.Windows.Forms.Label
		Me.Label21 = New System.Windows.Forms.Label
		Me.Label22 = New System.Windows.Forms.Label
		Me.Label23 = New System.Windows.Forms.Label
		Me.Label24 = New System.Windows.Forms.Label
		Me.StBar = New System.Windows.Forms.StatusStrip
		Me._StBar_Panel1 = New System.Windows.Forms.ToolStripStatusLabel
		Me._StBar_Panel2 = New System.Windows.Forms.ToolStripStatusLabel
		Me._StBar_Panel3 = New System.Windows.Forms.ToolStripStatusLabel
		Me._StBar_Panel4 = New System.Windows.Forms.ToolStripStatusLabel
		Me.frameGrid = New System.Windows.Forms.GroupBox
		Me.TDBG_Det = New AxTrueOleDBGrid70.AxTDBGrid
		Me.Shape10 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
		Me.Label7 = New System.Windows.Forms.Label
		Me.lbnregdetalle = New System.Windows.Forms.Label
		Me.Shape9 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
		Me.FrameCabecera = New System.Windows.Forms.GroupBox
		Me.ChkGrabado = New System.Windows.Forms.CheckBox
		Me.DTPFechaComprobCab = New AxMSComCtl2.AxDTPicker
		Me.TxGlosaComprobCab = New AxTextFer.AxTxFer
		Me.TxObsComprobCab = New AxTextFer.AxTxFer
		Me.TxCtrNref = New AxTextFer.AxTxFer
		Me.lbNumComprobCablibro = New System.Windows.Forms.Label
		Me._leNComprob_0 = New System.Windows.Forms.Label
		Me.lbnemoref = New System.Windows.Forms.Label
		Me.Shape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
		Me.leDebe = New System.Windows.Forms.Label
		Me.Shape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
		Me.leHaber = New System.Windows.Forms.Label
		Me.leSoles = New System.Windows.Forms.Label
		Me.LeDolares = New System.Windows.Forms.Label
		Me._LbTotales_0 = New System.Windows.Forms.Label
		Me._LbTotales_1 = New System.Windows.Forms.Label
		Me._LbTotales_3 = New System.Windows.Forms.Label
		Me._LbTotales_4 = New System.Windows.Forms.Label
		Me.leDifer = New System.Windows.Forms.Label
		Me._LbTotales_2 = New System.Windows.Forms.Label
		Me._LbTotales_5 = New System.Windows.Forms.Label
		Me._leNComprob_1 = New System.Windows.Forms.Label
		Me.lbNumComprobCab = New System.Windows.Forms.Label
		Me._leFechaComprob_7 = New System.Windows.Forms.Label
		Me.leGlosa = New System.Windows.Forms.Label
		Me.leObservaciones = New System.Windows.Forms.Label
		Me.FrameIngreso = New System.Windows.Forms.GroupBox
		Me.FrameCcosto = New System.Windows.Forms.GroupBox
		Me.TDBGrid1 = New AxTrueOleDBGrid70.AxTDBGrid
		Me.Frame5 = New System.Windows.Forms.GroupBox
		Me.Cmdsalir = New System.Windows.Forms.Button
		Me.CmdAceptar = New System.Windows.Forms.Button
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.Txtimpo = New System.Windows.Forms.TextBox
		Me.TxtIgv = New System.Windows.Forms.TextBox
		Me.TxtInaf = New System.Windows.Forms.TextBox
		Me.TxtTot = New System.Windows.Forms.TextBox
		Me.TxtPerc = New System.Windows.Forms.TextBox
		Me.Labelimpo = New System.Windows.Forms.Label
		Me.Labeligv = New System.Windows.Forms.Label
		Me.Labelinaf = New System.Windows.Forms.Label
		Me.Labeltot = New System.Windows.Forms.Label
		Me.Labelperc = New System.Windows.Forms.Label
		Me.Frame4 = New System.Windows.Forms.GroupBox
		Me.CtrAyu_Analitico1 = New Axctrlayuda_f.AxCtr_Ayuda
		Me.CtrAyu_Cuenta1 = New Axctrlayuda_f.AxCtr_Ayuda
		Me.CtrAyu_Cuenta2 = New Axctrlayuda_f.AxCtr_Ayuda
		Me.Label27 = New System.Windows.Forms.Label
		Me.Label14 = New System.Windows.Forms.Label
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.TxNdoc1 = New AxTextFer.AxTxFer
		Me.TxSerie1 = New AxTextFer.AxTxFer
		Me.DTP_fecha1 = New AxMSComCtl2.AxDTPicker
		Me.CtrAyu_Moneda1 = New Axctrlayuda_f.AxCtr_Ayuda
		Me.CtrAyu_TipDoc1 = New Axctrlayuda_f.AxCtr_Ayuda
		Me.TxFer1 = New AxTextFer.AxTxFer
		Me.Label26 = New System.Windows.Forms.Label
		Me.Label28 = New System.Windows.Forms.Label
		Me.Label17 = New System.Windows.Forms.Label
		Me.Label16 = New System.Windows.Forms.Label
		Me.Label15 = New System.Windows.Forms.Label
		Me.LbTotales = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.lbTipAnal = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.leFechaComprob = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.leNComprob = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.SSTabMant.SuspendLayout()
		Me._SSTabMant_TabPage0.SuspendLayout()
		Me.Frame3.SuspendLayout()
		Me.FrameConsulta.SuspendLayout()
		Me._SSTabMant_TabPage1.SuspendLayout()
		Me.SSTab2.SuspendLayout()
		Me._SSTab2_TabPage0.SuspendLayout()
		Me.FramDetalle.SuspendLayout()
		Me.StBar.SuspendLayout()
		Me.frameGrid.SuspendLayout()
		Me.FrameCabecera.SuspendLayout()
		Me.FrameIngreso.SuspendLayout()
		Me.FrameCcosto.SuspendLayout()
		Me.Frame5.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.Frame4.SuspendLayout()
		Me.Frame2.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.DTPFechaContab, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CtrAyu_SubAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CtrAyu_Asiento, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TxEjecutar, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Dtc_Campo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TDBG_Consulta, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TxValor, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TxMonto, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TxNdoc, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TxSerie, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txRuc, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CtrAyu_Moneda, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CtrAyu_TipDoc, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CtrAyu_Analitico, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CtrAyu_TipAnal, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CtrAyu_CCosto, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CtrAyu_Cuenta, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CtrAyu_Opera, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Dtp_FechaDoc, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DtpFech_Ven, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TxGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CtrAyu_TipRef, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TxNref, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Dtp_FechaDocRef, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TDBG_Det, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DTPFechaComprobCab, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TxGlosaComprobCab, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TxObsComprobCab, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TxCtrNref, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CtrAyu_Analitico1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CtrAyu_Cuenta1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CtrAyu_Cuenta2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TxNdoc1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TxSerie1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DTP_fecha1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CtrAyu_Moneda1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CtrAyu_TipDoc1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TxFer1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LbTotales, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lbTipAnal, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.leFechaComprob, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.leNComprob, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.BackColor = System.Drawing.Color.FromARGB(192, 255, 255)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Text = "Mantenimiento de Comprobantes Contables"
		Me.ClientSize = New System.Drawing.Size(843, 606)
		Me.Location = New System.Drawing.Point(3, 26)
		Me.Icon = CType(resources.GetObject("frmantcomprobantes.Icon"), System.Drawing.Icon)
		Me.KeyPreview = True
		Me.MaximizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ControlBox = True
		Me.Enabled = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmantcomprobantes"
		Me.SSTabMant.Size = New System.Drawing.Size(832, 599)
		Me.SSTabMant.Location = New System.Drawing.Point(4, 4)
		Me.SSTabMant.TabIndex = 0
		Me.SSTabMant.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
		Me.SSTabMant.SelectedIndex = 1
		Me.SSTabMant.ItemSize = New System.Drawing.Size(42, 18)
		Me.SSTabMant.BackColor = System.Drawing.Color.White
		Me.SSTabMant.Name = "SSTabMant"
		Me._SSTabMant_TabPage0.Text = "Consulta"
		Me.Frame3.BackColor = System.Drawing.SystemColors.InactiveBorder
		Me.Frame3.Size = New System.Drawing.Size(750, 119)
		Me.Frame3.Location = New System.Drawing.Point(6, 26)
		Me.Frame3.TabIndex = 54
		Me.Frame3.Enabled = True
		Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame3.Visible = True
		Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame3.Name = "Frame3"
		DTPFechaContab.OcxState = CType(resources.GetObject("DTPFechaContab.OcxState"), System.Windows.Forms.AxHost.State)
		Me.DTPFechaContab.Size = New System.Drawing.Size(98, 20)
		Me.DTPFechaContab.Location = New System.Drawing.Point(644, 34)
		Me.DTPFechaContab.TabIndex = 87
		Me.DTPFechaContab.Name = "DTPFechaContab"
		CtrAyu_SubAsiento.OcxState = CType(resources.GetObject("CtrAyu_SubAsiento.OcxState"), System.Windows.Forms.AxHost.State)
		Me.CtrAyu_SubAsiento.Size = New System.Drawing.Size(409, 21)
		Me.CtrAyu_SubAsiento.Location = New System.Drawing.Point(335, 90)
		Me.CtrAyu_SubAsiento.TabIndex = 56
		Me.CtrAyu_SubAsiento.Name = "CtrAyu_SubAsiento"
		CtrAyu_Asiento.OcxState = CType(resources.GetObject("CtrAyu_Asiento.OcxState"), System.Windows.Forms.AxHost.State)
		Me.CtrAyu_Asiento.Size = New System.Drawing.Size(299, 20)
		Me.CtrAyu_Asiento.Location = New System.Drawing.Point(13, 90)
		Me.CtrAyu_Asiento.TabIndex = 55
		Me.CtrAyu_Asiento.Name = "CtrAyu_Asiento"
		Me.Label5.Text = "Fecha de Contabilizacion :"
		Me.Label5.Size = New System.Drawing.Size(130, 15)
		Me.Label5.Location = New System.Drawing.Point(502, 39)
		Me.Label5.TabIndex = 86
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label5.BackColor = System.Drawing.Color.Transparent
		Me.Label5.Enabled = True
		Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.UseMnemonic = True
		Me.Label5.Visible = True
		Me.Label5.AutoSize = False
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.Name = "Label5"
		Me.Image1.Size = New System.Drawing.Size(30, 31)
		Me.Image1.Location = New System.Drawing.Point(9, 14)
		Me.Image1.Image = CType(resources.GetObject("Image1.Image"), System.Drawing.Image)
		Me.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.Image1.Enabled = True
		Me.Image1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Image1.Visible = True
		Me.Image1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Image1.Name = "Image1"
		Me.Label3.Text = " Consulta e Ingreso de Comprobantes Contables"
		Me.Label3.ForeColor = System.Drawing.Color.Black
		Me.Label3.Size = New System.Drawing.Size(329, 18)
		Me.Label3.Location = New System.Drawing.Point(46, 33)
		Me.Label3.TabIndex = 80
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.Enabled = True
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.Shape5.BorderColor = System.Drawing.Color.FromARGB(128, 128, 128)
		Me.Shape5.Size = New System.Drawing.Size(742, 1)
		Me.Shape5.Location = New System.Drawing.Point(4, 47)
		Me.Shape5.BackColor = System.Drawing.SystemColors.Window
		Me.Shape5.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent
		Me.Shape5.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Shape5.BorderWidth = 1
		Me.Shape5.FillColor = System.Drawing.Color.Black
		Me.Shape5.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent
		Me.Shape5.Visible = True
		Me.Shape5.Name = "Shape5"
		Me.Label1.BackColor = System.Drawing.Color.White
		Me.Label1.Size = New System.Drawing.Size(743, 49)
		Me.Label1.Location = New System.Drawing.Point(3, 9)
		Me.Label1.TabIndex = 79
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.Enabled = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.Label25.Text = "Asiento :"
		Me.Label25.ForeColor = System.Drawing.Color.Black
		Me.Label25.Size = New System.Drawing.Size(129, 17)
		Me.Label25.Location = New System.Drawing.Point(13, 76)
		Me.Label25.TabIndex = 58
		Me.Label25.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label25.BackColor = System.Drawing.Color.Transparent
		Me.Label25.Enabled = True
		Me.Label25.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label25.UseMnemonic = True
		Me.Label25.Visible = True
		Me.Label25.AutoSize = False
		Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label25.Name = "Label25"
		Me.lbSubAsiento.Text = "Subasiento :"
		Me.lbSubAsiento.ForeColor = System.Drawing.Color.Black
		Me.lbSubAsiento.Size = New System.Drawing.Size(106, 13)
		Me.lbSubAsiento.Location = New System.Drawing.Point(335, 76)
		Me.lbSubAsiento.TabIndex = 57
		Me.lbSubAsiento.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lbSubAsiento.BackColor = System.Drawing.Color.Transparent
		Me.lbSubAsiento.Enabled = True
		Me.lbSubAsiento.Cursor = System.Windows.Forms.Cursors.Default
		Me.lbSubAsiento.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lbSubAsiento.UseMnemonic = True
		Me.lbSubAsiento.Visible = True
		Me.lbSubAsiento.AutoSize = False
		Me.lbSubAsiento.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lbSubAsiento.Name = "lbSubAsiento"
		Me.Shape6.BorderColor = System.Drawing.Color.White
		Me.Shape6.Size = New System.Drawing.Size(742, 1)
		Me.Shape6.Location = New System.Drawing.Point(4, 48)
		Me.Shape6.BackColor = System.Drawing.SystemColors.Window
		Me.Shape6.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent
		Me.Shape6.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Shape6.BorderWidth = 1
		Me.Shape6.FillColor = System.Drawing.Color.Black
		Me.Shape6.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent
		Me.Shape6.Visible = True
		Me.Shape6.Name = "Shape6"
		Me.FrameConsulta.BackColor = System.Drawing.Color.FromARGB(128, 128, 128)
		Me.FrameConsulta.Size = New System.Drawing.Size(750, 449)
		Me.FrameConsulta.Location = New System.Drawing.Point(6, 144)
		Me.FrameConsulta.TabIndex = 71
		Me.FrameConsulta.Enabled = True
		Me.FrameConsulta.ForeColor = System.Drawing.SystemColors.ControlText
		Me.FrameConsulta.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.FrameConsulta.Visible = True
		Me.FrameConsulta.Padding = New System.Windows.Forms.Padding(0)
		Me.FrameConsulta.Name = "FrameConsulta"
		TxEjecutar.OcxState = CType(resources.GetObject("TxEjecutar.OcxState"), System.Windows.Forms.AxHost.State)
		Me.TxEjecutar.Size = New System.Drawing.Size(499, 20)
		Me.TxEjecutar.Location = New System.Drawing.Point(8, 31)
		Me.TxEjecutar.TabIndex = 85
		Me.TxEjecutar.CausesValidation = -1
		Me.TxEjecutar.Name = "TxEjecutar"
		Me.ChkTodos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.ChkTodos.BackColor = System.Drawing.Color.FromARGB(128, 128, 128)
		Me.ChkTodos.Text = "Todos"
		Me.ChkTodos.ForeColor = System.Drawing.Color.White
		Me.ChkTodos.Size = New System.Drawing.Size(57, 18)
		Me.ChkTodos.Location = New System.Drawing.Point(510, 32)
		Me.ChkTodos.TabIndex = 78
		Me.ChkTodos.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.ChkTodos.CausesValidation = True
		Me.ChkTodos.Enabled = True
		Me.ChkTodos.Cursor = System.Windows.Forms.Cursors.Default
		Me.ChkTodos.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ChkTodos.Appearance = System.Windows.Forms.Appearance.Normal
		Me.ChkTodos.TabStop = True
		Me.ChkTodos.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.ChkTodos.Visible = True
		Me.ChkTodos.Name = "ChkTodos"
		Dtc_Campo.OcxState = CType(resources.GetObject("Dtc_Campo.OcxState"), System.Windows.Forms.AxHost.State)
		Me.Dtc_Campo.Size = New System.Drawing.Size(119, 21)
		Me.Dtc_Campo.Location = New System.Drawing.Point(625, 29)
		Me.Dtc_Campo.TabIndex = 77
		Me.Dtc_Campo.Name = "Dtc_Campo"
		TDBG_Consulta.OcxState = CType(resources.GetObject("TDBG_Consulta.OcxState"), System.Windows.Forms.AxHost.State)
		Me.TDBG_Consulta.Size = New System.Drawing.Size(736, 364)
		Me.TDBG_Consulta.Location = New System.Drawing.Point(8, 54)
		Me.TDBG_Consulta.TabIndex = 72
		Me.TDBG_Consulta.Name = "TDBG_Consulta"
		Me.Shape8.BackColor = System.Drawing.SystemColors.InactiveBorder
		Me.Shape8.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
		Me.Shape8.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
		Me.Shape8.Size = New System.Drawing.Size(751, 6)
		Me.Shape8.Location = New System.Drawing.Point(0, -13)
		Me.Shape8.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Shape8.BorderWidth = 1
		Me.Shape8.FillColor = System.Drawing.Color.Black
		Me.Shape8.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent
		Me.Shape8.Visible = True
		Me.Shape8.Name = "Shape8"
		Me.Shape7.BorderColor = System.Drawing.Color.FromARGB(64, 64, 64)
		Me.Shape7.Size = New System.Drawing.Size(73, 19)
		Me.Shape7.Location = New System.Drawing.Point(671, 410)
		Me.Shape7.BackColor = System.Drawing.SystemColors.Window
		Me.Shape7.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent
		Me.Shape7.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Shape7.BorderWidth = 1
		Me.Shape7.FillColor = System.Drawing.Color.Black
		Me.Shape7.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent
		Me.Shape7.Visible = True
		Me.Shape7.Name = "Shape7"
		Me.lbl_nregconsulta.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.lbl_nregconsulta.BackColor = System.Drawing.Color.White
		Me.lbl_nregconsulta.Text = "0 "
		Me.lbl_nregconsulta.Size = New System.Drawing.Size(72, 19)
		Me.lbl_nregconsulta.Location = New System.Drawing.Point(672, 423)
		Me.lbl_nregconsulta.TabIndex = 76
		Me.lbl_nregconsulta.Enabled = True
		Me.lbl_nregconsulta.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lbl_nregconsulta.Cursor = System.Windows.Forms.Cursors.Default
		Me.lbl_nregconsulta.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lbl_nregconsulta.UseMnemonic = True
		Me.lbl_nregconsulta.Visible = True
		Me.lbl_nregconsulta.AutoSize = False
		Me.lbl_nregconsulta.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lbl_nregconsulta.Name = "lbl_nregconsulta"
		Me.Label6.Text = "Nº Registros :"
		Me.Label6.ForeColor = System.Drawing.Color.White
		Me.Label6.Size = New System.Drawing.Size(65, 13)
		Me.Label6.Location = New System.Drawing.Point(600, 426)
		Me.Label6.TabIndex = 75
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label6.BackColor = System.Drawing.Color.Transparent
		Me.Label6.Enabled = True
		Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label6.UseMnemonic = True
		Me.Label6.Visible = True
		Me.Label6.AutoSize = True
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label6.Name = "Label6"
		Me.Label2.BackColor = System.Drawing.Color.FromARGB(128, 128, 128)
		Me.Label2.Text = "Valor :"
		Me.Label2.ForeColor = System.Drawing.Color.White
		Me.Label2.Size = New System.Drawing.Size(139, 18)
		Me.Label2.Location = New System.Drawing.Point(8, 14)
		Me.Label2.TabIndex = 74
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.Enabled = True
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.Label4.BackColor = System.Drawing.Color.FromARGB(128, 128, 128)
		Me.Label4.Text = "Criterio :"
		Me.Label4.ForeColor = System.Drawing.Color.White
		Me.Label4.Size = New System.Drawing.Size(38, 14)
		Me.Label4.Location = New System.Drawing.Point(581, 34)
		Me.Label4.TabIndex = 73
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label4.Enabled = True
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.Visible = True
		Me.Label4.AutoSize = False
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.Name = "Label4"
		Me._SSTabMant_TabPage1.Text = "Mantenimiento"
		Me.Shilu2.BorderColor = System.Drawing.Color.Green
		Me.Shilu2.BorderWidth = 2
		Me.Shilu2.Size = New System.Drawing.Size(2, 191)
		Me.Shilu2.Location = New System.Drawing.Point(801, 166)
		Me.Shilu2.Visible = False
		Me.Shilu2.BackColor = System.Drawing.SystemColors.Window
		Me.Shilu2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent
		Me.Shilu2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Shilu2.FillColor = System.Drawing.Color.Black
		Me.Shilu2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent
		Me.Shilu2.Name = "Shilu2"
		Me.SSTab2.Size = New System.Drawing.Size(821, 213)
		Me.SSTab2.Location = New System.Drawing.Point(8, 357)
		Me.SSTab2.TabIndex = 1
		Me.SSTab2.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
		Me.SSTab2.ItemSize = New System.Drawing.Size(42, 18)
		Me.SSTab2.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me.SSTab2.Name = "SSTab2"
		Me._SSTab2_TabPage0.Text = "&Ingreso del detalle"
		Me.Shilu1.BorderColor = System.Drawing.Color.Green
		Me.Shilu1.BorderWidth = 2
		Me.Shilu1.Size = New System.Drawing.Size(642, 2)
		Me.Shilu1.Location = New System.Drawing.Point(105, 1)
		Me.Shilu1.Visible = False
		Me.Shilu1.BackColor = System.Drawing.SystemColors.Window
		Me.Shilu1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent
		Me.Shilu1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Shilu1.FillColor = System.Drawing.Color.Black
		Me.Shilu1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent
		Me.Shilu1.Name = "Shilu1"
		Me.FramDetalle.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me.FramDetalle.Size = New System.Drawing.Size(819, 182)
		Me.FramDetalle.Location = New System.Drawing.Point(5, 23)
		Me.FramDetalle.TabIndex = 2
		Me.FramDetalle.Enabled = True
		Me.FramDetalle.ForeColor = System.Drawing.SystemColors.ControlText
		Me.FramDetalle.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.FramDetalle.Visible = True
		Me.FramDetalle.Padding = New System.Windows.Forms.Padding(0)
		Me.FramDetalle.Name = "FramDetalle"
		Me.CmdDocPend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.CmdDocPend.Text = "..."
		Me.CmdDocPend.Size = New System.Drawing.Size(22, 20)
		Me.CmdDocPend.Location = New System.Drawing.Point(417, 94)
		Me.CmdDocPend.TabIndex = 91
		Me.CmdDocPend.Visible = False
		Me.CmdDocPend.BackColor = System.Drawing.SystemColors.Control
		Me.CmdDocPend.CausesValidation = True
		Me.CmdDocPend.Enabled = True
		Me.CmdDocPend.ForeColor = System.Drawing.SystemColors.ControlText
		Me.CmdDocPend.Cursor = System.Windows.Forms.Cursors.Default
		Me.CmdDocPend.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CmdDocPend.TabStop = True
		Me.CmdDocPend.Name = "CmdDocPend"
		Me.ChkInafecto.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.ChkInafecto.Text = "Inafecto"
		Me.ChkInafecto.Size = New System.Drawing.Size(60, 17)
		Me.ChkInafecto.Location = New System.Drawing.Point(444, 138)
		Me.ChkInafecto.TabIndex = 39
		Me.ChkInafecto.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.ChkInafecto.BackColor = System.Drawing.SystemColors.Control
		Me.ChkInafecto.CausesValidation = True
		Me.ChkInafecto.Enabled = True
		Me.ChkInafecto.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ChkInafecto.Cursor = System.Windows.Forms.Cursors.Default
		Me.ChkInafecto.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ChkInafecto.Appearance = System.Windows.Forms.Appearance.Normal
		Me.ChkInafecto.TabStop = True
		Me.ChkInafecto.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.ChkInafecto.Visible = True
		Me.ChkInafecto.Name = "ChkInafecto"
		TxValor.OcxState = CType(resources.GetObject("TxValor.OcxState"), System.Windows.Forms.AxHost.State)
		Me.TxValor.Size = New System.Drawing.Size(147, 22)
		Me.TxValor.Location = New System.Drawing.Point(657, 152)
		Me.TxValor.TabIndex = 47
		Me.TxValor.Visible = False
		Me.TxValor.CausesValidation = -1
		Me.TxValor.Name = "TxValor"
		Me.ChkAjusta.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.ChkAjusta.Text = "Ajustar por el Usuario"
		Me.ChkAjusta.Size = New System.Drawing.Size(147, 14)
		Me.ChkAjusta.Location = New System.Drawing.Point(656, 137)
		Me.ChkAjusta.TabIndex = 46
		Me.ChkAjusta.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.ChkAjusta.BackColor = System.Drawing.SystemColors.Control
		Me.ChkAjusta.CausesValidation = True
		Me.ChkAjusta.Enabled = True
		Me.ChkAjusta.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ChkAjusta.Cursor = System.Windows.Forms.Cursors.Default
		Me.ChkAjusta.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ChkAjusta.Appearance = System.Windows.Forms.Appearance.Normal
		Me.ChkAjusta.TabStop = True
		Me.ChkAjusta.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.ChkAjusta.Visible = True
		Me.ChkAjusta.Name = "ChkAjusta"
		TxMonto.OcxState = CType(resources.GetObject("TxMonto.OcxState"), System.Windows.Forms.AxHost.State)
		Me.TxMonto.Size = New System.Drawing.Size(149, 21)
		Me.TxMonto.Location = New System.Drawing.Point(656, 104)
		Me.TxMonto.TabIndex = 44
		Me.TxMonto.CausesValidation = -1
		Me.TxMonto.Name = "TxMonto"
		TxNdoc.OcxState = CType(resources.GetObject("TxNdoc.OcxState"), System.Windows.Forms.AxHost.State)
		Me.TxNdoc.Size = New System.Drawing.Size(114, 20)
		Me.TxNdoc.Location = New System.Drawing.Point(301, 94)
		Me.TxNdoc.TabIndex = 33
		Me.TxNdoc.CausesValidation = -1
		Me.TxNdoc.Name = "TxNdoc"
		TxSerie.OcxState = CType(resources.GetObject("TxSerie.OcxState"), System.Windows.Forms.AxHost.State)
		Me.TxSerie.Size = New System.Drawing.Size(37, 20)
		Me.TxSerie.Location = New System.Drawing.Point(260, 94)
		Me.TxSerie.TabIndex = 32
		Me.TxSerie.CausesValidation = -1
		Me.TxSerie.Name = "TxSerie"
		txRuc.OcxState = CType(resources.GetObject("txRuc.OcxState"), System.Windows.Forms.AxHost.State)
		Me.txRuc.Size = New System.Drawing.Size(116, 21)
		Me.txRuc.Location = New System.Drawing.Point(388, 73)
		Me.txRuc.TabIndex = 30
		Me.txRuc.CausesValidation = -1
		Me.txRuc.Name = "txRuc"
		CtrAyu_Moneda.OcxState = CType(resources.GetObject("CtrAyu_Moneda.OcxState"), System.Windows.Forms.AxHost.State)
		Me.CtrAyu_Moneda.Size = New System.Drawing.Size(146, 21)
		Me.CtrAyu_Moneda.Location = New System.Drawing.Point(657, 34)
		Me.CtrAyu_Moneda.TabIndex = 42
		Me.CtrAyu_Moneda.Name = "CtrAyu_Moneda"
		CtrAyu_TipDoc.OcxState = CType(resources.GetObject("CtrAyu_TipDoc.OcxState"), System.Windows.Forms.AxHost.State)
		Me.CtrAyu_TipDoc.Size = New System.Drawing.Size(138, 21)
		Me.CtrAyu_TipDoc.Location = New System.Drawing.Point(75, 93)
		Me.CtrAyu_TipDoc.TabIndex = 31
		Me.CtrAyu_TipDoc.Name = "CtrAyu_TipDoc"
		CtrAyu_Analitico.OcxState = CType(resources.GetObject("CtrAyu_Analitico.OcxState"), System.Windows.Forms.AxHost.State)
		Me.CtrAyu_Analitico.Size = New System.Drawing.Size(271, 20)
		Me.CtrAyu_Analitico.Location = New System.Drawing.Point(75, 73)
		Me.CtrAyu_Analitico.TabIndex = 29
		Me.CtrAyu_Analitico.Name = "CtrAyu_Analitico"
		CtrAyu_TipAnal.OcxState = CType(resources.GetObject("CtrAyu_TipAnal.OcxState"), System.Windows.Forms.AxHost.State)
		Me.CtrAyu_TipAnal.Size = New System.Drawing.Size(160, 21)
		Me.CtrAyu_TipAnal.Location = New System.Drawing.Point(345, 53)
		Me.CtrAyu_TipAnal.TabIndex = 28
		Me.CtrAyu_TipAnal.Name = "CtrAyu_TipAnal"
		CtrAyu_CCosto.OcxState = CType(resources.GetObject("CtrAyu_CCosto.OcxState"), System.Windows.Forms.AxHost.State)
		Me.CtrAyu_CCosto.Size = New System.Drawing.Size(189, 22)
		Me.CtrAyu_CCosto.Location = New System.Drawing.Point(75, 53)
		Me.CtrAyu_CCosto.TabIndex = 27
		Me.CtrAyu_CCosto.Name = "CtrAyu_CCosto"
		CtrAyu_Cuenta.OcxState = CType(resources.GetObject("CtrAyu_Cuenta.OcxState"), System.Windows.Forms.AxHost.State)
		Me.CtrAyu_Cuenta.Size = New System.Drawing.Size(430, 21)
		Me.CtrAyu_Cuenta.Location = New System.Drawing.Point(75, 33)
		Me.CtrAyu_Cuenta.TabIndex = 26
		Me.CtrAyu_Cuenta.Name = "CtrAyu_Cuenta"
		CtrAyu_Opera.OcxState = CType(resources.GetObject("CtrAyu_Opera.OcxState"), System.Windows.Forms.AxHost.State)
		Me.CtrAyu_Opera.Size = New System.Drawing.Size(431, 21)
		Me.CtrAyu_Opera.Location = New System.Drawing.Point(75, 12)
		Me.CtrAyu_Opera.TabIndex = 25
		Me.CtrAyu_Opera.Name = "CtrAyu_Opera"
		Me.CmbID.Size = New System.Drawing.Size(148, 21)
		Me.CmbID.Location = New System.Drawing.Point(656, 13)
		Me.CmbID.Items.AddRange(New Object(){"D - Debe", "H - Haber"})
		Me.CmbID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CmbID.TabIndex = 41
		Me.CmbID.BackColor = System.Drawing.SystemColors.Window
		Me.CmbID.CausesValidation = True
		Me.CmbID.Enabled = True
		Me.CmbID.ForeColor = System.Drawing.SystemColors.WindowText
		Me.CmbID.IntegralHeight = True
		Me.CmbID.Cursor = System.Windows.Forms.Cursors.Default
		Me.CmbID.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CmbID.Sorted = False
		Me.CmbID.TabStop = True
		Me.CmbID.Visible = True
		Me.CmbID.Name = "CmbID"
		Me.CmbTcambio.Size = New System.Drawing.Size(148, 21)
		Me.CmbTcambio.Location = New System.Drawing.Point(657, 57)
		Me.CmbTcambio.Items.AddRange(New Object(){"01 - Compra", "02 - Venta", "03 - Promedio"})
		Me.CmbTcambio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CmbTcambio.TabIndex = 43
		Me.CmbTcambio.BackColor = System.Drawing.SystemColors.Window
		Me.CmbTcambio.CausesValidation = True
		Me.CmbTcambio.Enabled = True
		Me.CmbTcambio.ForeColor = System.Drawing.SystemColors.WindowText
		Me.CmbTcambio.IntegralHeight = True
		Me.CmbTcambio.Cursor = System.Windows.Forms.Cursors.Default
		Me.CmbTcambio.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CmbTcambio.Sorted = False
		Me.CmbTcambio.TabStop = True
		Me.CmbTcambio.Visible = True
		Me.CmbTcambio.Name = "CmbTcambio"
		Dtp_FechaDoc.OcxState = CType(resources.GetObject("Dtp_FechaDoc.OcxState"), System.Windows.Forms.AxHost.State)
		Me.Dtp_FechaDoc.Size = New System.Drawing.Size(86, 21)
		Me.Dtp_FechaDoc.Location = New System.Drawing.Point(76, 135)
		Me.Dtp_FechaDoc.TabIndex = 37
		Me.Dtp_FechaDoc.Name = "Dtp_FechaDoc"
		DtpFech_Ven.OcxState = CType(resources.GetObject("DtpFech_Ven.OcxState"), System.Windows.Forms.AxHost.State)
		Me.DtpFech_Ven.Size = New System.Drawing.Size(112, 21)
		Me.DtpFech_Ven.Location = New System.Drawing.Point(253, 136)
		Me.DtpFech_Ven.TabIndex = 38
		Me.DtpFech_Ven.Name = "DtpFech_Ven"
		TxGlosa.OcxState = CType(resources.GetObject("TxGlosa.OcxState"), System.Windows.Forms.AxHost.State)
		Me.TxGlosa.Size = New System.Drawing.Size(429, 20)
		Me.TxGlosa.Location = New System.Drawing.Point(75, 157)
		Me.TxGlosa.TabIndex = 40
		Me.TxGlosa.CausesValidation = -1
		Me.TxGlosa.Name = "TxGlosa"
		CtrAyu_TipRef.OcxState = CType(resources.GetObject("CtrAyu_TipRef.OcxState"), System.Windows.Forms.AxHost.State)
		Me.CtrAyu_TipRef.Size = New System.Drawing.Size(138, 21)
		Me.CtrAyu_TipRef.Location = New System.Drawing.Point(75, 113)
		Me.CtrAyu_TipRef.TabIndex = 34
		Me.CtrAyu_TipRef.Name = "CtrAyu_TipRef"
		TxNref.OcxState = CType(resources.GetObject("TxNref.OcxState"), System.Windows.Forms.AxHost.State)
		Me.TxNref.Size = New System.Drawing.Size(137, 20)
		Me.TxNref.Location = New System.Drawing.Point(259, 113)
		Me.TxNref.TabIndex = 35
		Me.TxNref.CausesValidation = -1
		Me.TxNref.Name = "TxNref"
		Dtp_FechaDocRef.OcxState = CType(resources.GetObject("Dtp_FechaDocRef.OcxState"), System.Windows.Forms.AxHost.State)
		Me.Dtp_FechaDocRef.Size = New System.Drawing.Size(100, 19)
		Me.Dtp_FechaDocRef.Location = New System.Drawing.Point(405, 115)
		Me.Dtp_FechaDocRef.TabIndex = 36
		Me.Dtp_FechaDocRef.Name = "Dtp_FechaDocRef"
		Me.lbnref.Text = "Nº . :"
		Me.lbnref.Size = New System.Drawing.Size(24, 13)
		Me.lbnref.Location = New System.Drawing.Point(216, 117)
		Me.lbnref.TabIndex = 89
		Me.lbnref.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lbnref.BackColor = System.Drawing.SystemColors.Control
		Me.lbnref.Enabled = True
		Me.lbnref.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lbnref.Cursor = System.Windows.Forms.Cursors.Default
		Me.lbnref.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lbnref.UseMnemonic = True
		Me.lbnref.Visible = True
		Me.lbnref.AutoSize = True
		Me.lbnref.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lbnref.Name = "lbnref"
		Me.lbtipref.Text = "T.D. Ref. :"
		Me.lbtipref.Size = New System.Drawing.Size(68, 17)
		Me.lbtipref.Location = New System.Drawing.Point(8, 116)
		Me.lbtipref.TabIndex = 88
		Me.lbtipref.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lbtipref.BackColor = System.Drawing.SystemColors.Control
		Me.lbtipref.Enabled = True
		Me.lbtipref.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lbtipref.Cursor = System.Windows.Forms.Cursors.Default
		Me.lbtipref.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lbtipref.UseMnemonic = True
		Me.lbtipref.Visible = True
		Me.lbtipref.AutoSize = False
		Me.lbtipref.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lbtipref.Name = "lbtipref"
		Me.lbconv.Text = "Conversión :"
		Me.lbconv.ForeColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me.lbconv.Size = New System.Drawing.Size(66, 16)
		Me.lbconv.Location = New System.Drawing.Point(591, 157)
		Me.lbconv.TabIndex = 84
		Me.lbconv.Visible = False
		Me.lbconv.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lbconv.BackColor = System.Drawing.SystemColors.Control
		Me.lbconv.Enabled = True
		Me.lbconv.Cursor = System.Windows.Forms.Cursors.Default
		Me.lbconv.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lbconv.UseMnemonic = True
		Me.lbconv.AutoSize = False
		Me.lbconv.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lbconv.Name = "lbconv"
		Me.lb_vcambio.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.lb_vcambio.BackColor = System.Drawing.Color.FromARGB(255, 254, 242)
		Me.lb_vcambio.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lb_vcambio.Size = New System.Drawing.Size(148, 18)
		Me.lb_vcambio.Location = New System.Drawing.Point(657, 82)
		Me.lb_vcambio.TabIndex = 70
		Me.lb_vcambio.Enabled = True
		Me.lb_vcambio.Cursor = System.Windows.Forms.Cursors.Default
		Me.lb_vcambio.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lb_vcambio.UseMnemonic = True
		Me.lb_vcambio.Visible = True
		Me.lb_vcambio.AutoSize = False
		Me.lb_vcambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lb_vcambio.Name = "lb_vcambio"
		Me._lbTipAnal_0.Text = "Tipo Analitico :"
		Me._lbTipAnal_0.Size = New System.Drawing.Size(70, 13)
		Me._lbTipAnal_0.Location = New System.Drawing.Point(268, 58)
		Me._lbTipAnal_0.TabIndex = 19
		Me._lbTipAnal_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lbTipAnal_0.BackColor = System.Drawing.SystemColors.Control
		Me._lbTipAnal_0.Enabled = True
		Me._lbTipAnal_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lbTipAnal_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lbTipAnal_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lbTipAnal_0.UseMnemonic = True
		Me._lbTipAnal_0.Visible = True
		Me._lbTipAnal_0.AutoSize = True
		Me._lbTipAnal_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lbTipAnal_0.Name = "_lbTipAnal_0"
		Me.lbAnalitico.Text = "Analitico :"
		Me.lbAnalitico.Size = New System.Drawing.Size(46, 13)
		Me.lbAnalitico.Location = New System.Drawing.Point(8, 78)
		Me.lbAnalitico.TabIndex = 17
		Me.lbAnalitico.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lbAnalitico.BackColor = System.Drawing.SystemColors.Control
		Me.lbAnalitico.Enabled = True
		Me.lbAnalitico.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lbAnalitico.Cursor = System.Windows.Forms.Cursors.Default
		Me.lbAnalitico.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lbAnalitico.UseMnemonic = True
		Me.lbAnalitico.Visible = True
		Me.lbAnalitico.AutoSize = True
		Me.lbAnalitico.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lbAnalitico.Name = "lbAnalitico"
		Me.Label11.Text = "Cod Oper. :"
		Me.Label11.Size = New System.Drawing.Size(54, 13)
		Me.Label11.Location = New System.Drawing.Point(8, 18)
		Me.Label11.TabIndex = 16
		Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label11.BackColor = System.Drawing.SystemColors.Control
		Me.Label11.Enabled = True
		Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label11.UseMnemonic = True
		Me.Label11.Visible = True
		Me.Label11.AutoSize = True
		Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label11.Name = "Label11"
		Me.Label12.Text = "Cuenta :"
		Me.Label12.Size = New System.Drawing.Size(40, 13)
		Me.Label12.Location = New System.Drawing.Point(8, 37)
		Me.Label12.TabIndex = 15
		Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label12.BackColor = System.Drawing.SystemColors.Control
		Me.Label12.Enabled = True
		Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label12.UseMnemonic = True
		Me.Label12.Visible = True
		Me.Label12.AutoSize = True
		Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label12.Name = "Label12"
		Me.lbccosto.Text = "C.Costo :"
		Me.lbccosto.Size = New System.Drawing.Size(43, 13)
		Me.lbccosto.Location = New System.Drawing.Point(8, 57)
		Me.lbccosto.TabIndex = 14
		Me.lbccosto.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lbccosto.BackColor = System.Drawing.SystemColors.Control
		Me.lbccosto.Enabled = True
		Me.lbccosto.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lbccosto.Cursor = System.Windows.Forms.Cursors.Default
		Me.lbccosto.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lbccosto.UseMnemonic = True
		Me.lbccosto.Visible = True
		Me.lbccosto.AutoSize = True
		Me.lbccosto.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lbccosto.Name = "lbccosto"
		Me.lbruc.Text = "R.U.C. :"
		Me.lbruc.Size = New System.Drawing.Size(38, 13)
		Me.lbruc.Location = New System.Drawing.Point(349, 78)
		Me.lbruc.TabIndex = 13
		Me.lbruc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lbruc.BackColor = System.Drawing.SystemColors.Control
		Me.lbruc.Enabled = True
		Me.lbruc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lbruc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lbruc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lbruc.UseMnemonic = True
		Me.lbruc.Visible = True
		Me.lbruc.AutoSize = True
		Me.lbruc.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lbruc.Name = "lbruc"
		Me.Shape3.BorderColor = System.Drawing.Color.FromARGB(128, 128, 128)
		Me.Shape3.Size = New System.Drawing.Size(1, 159)
		Me.Shape3.Location = New System.Drawing.Point(552, 2)
		Me.Shape3.BackColor = System.Drawing.SystemColors.Window
		Me.Shape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent
		Me.Shape3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Shape3.BorderWidth = 1
		Me.Shape3.FillColor = System.Drawing.Color.Black
		Me.Shape3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent
		Me.Shape3.Visible = True
		Me.Shape3.Name = "Shape3"
		Me.Shape4.BorderColor = System.Drawing.Color.White
		Me.Shape4.Size = New System.Drawing.Size(1, 159)
		Me.Shape4.Location = New System.Drawing.Point(577, 2)
		Me.Shape4.BackColor = System.Drawing.SystemColors.Window
		Me.Shape4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent
		Me.Shape4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Shape4.BorderWidth = 1
		Me.Shape4.FillColor = System.Drawing.Color.Black
		Me.Shape4.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent
		Me.Shape4.Visible = True
		Me.Shape4.Name = "Shape4"
		Me.lbtipdoc.Text = "Tipo doc. :"
		Me.lbtipdoc.Size = New System.Drawing.Size(68, 17)
		Me.lbtipdoc.Location = New System.Drawing.Point(8, 96)
		Me.lbtipdoc.TabIndex = 12
		Me.lbtipdoc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lbtipdoc.BackColor = System.Drawing.SystemColors.Control
		Me.lbtipdoc.Enabled = True
		Me.lbtipdoc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lbtipdoc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lbtipdoc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lbtipdoc.UseMnemonic = True
		Me.lbtipdoc.Visible = True
		Me.lbtipdoc.AutoSize = False
		Me.lbtipdoc.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lbtipdoc.Name = "lbtipdoc"
		Me.lbndocum.Text = "Nº doc. :"
		Me.lbndocum.Size = New System.Drawing.Size(42, 13)
		Me.lbndocum.Location = New System.Drawing.Point(216, 97)
		Me.lbndocum.TabIndex = 11
		Me.lbndocum.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lbndocum.BackColor = System.Drawing.SystemColors.Control
		Me.lbndocum.Enabled = True
		Me.lbndocum.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lbndocum.Cursor = System.Windows.Forms.Cursors.Default
		Me.lbndocum.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lbndocum.UseMnemonic = True
		Me.lbndocum.Visible = True
		Me.lbndocum.AutoSize = True
		Me.lbndocum.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lbndocum.Name = "lbndocum"
		Me.lbFechaDoc.Text = "Fecha doc. :"
		Me.lbFechaDoc.Size = New System.Drawing.Size(60, 13)
		Me.lbFechaDoc.Location = New System.Drawing.Point(8, 141)
		Me.lbFechaDoc.TabIndex = 10
		Me.lbFechaDoc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lbFechaDoc.BackColor = System.Drawing.SystemColors.Control
		Me.lbFechaDoc.Enabled = True
		Me.lbFechaDoc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lbFechaDoc.Cursor = System.Windows.Forms.Cursors.Default
		Me.lbFechaDoc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lbFechaDoc.UseMnemonic = True
		Me.lbFechaDoc.Visible = True
		Me.lbFechaDoc.AutoSize = True
		Me.lbFechaDoc.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lbFechaDoc.Name = "lbFechaDoc"
		Me.lbFechVen.Text = "Fecha de Venc. :"
		Me.lbFechVen.Size = New System.Drawing.Size(82, 13)
		Me.lbFechVen.Location = New System.Drawing.Point(167, 140)
		Me.lbFechVen.TabIndex = 9
		Me.lbFechVen.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lbFechVen.BackColor = System.Drawing.SystemColors.Control
		Me.lbFechVen.Enabled = True
		Me.lbFechVen.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lbFechVen.Cursor = System.Windows.Forms.Cursors.Default
		Me.lbFechVen.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lbFechVen.UseMnemonic = True
		Me.lbFechVen.Visible = True
		Me.lbFechVen.AutoSize = True
		Me.lbFechVen.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lbFechVen.Name = "lbFechVen"
		Me.Label19.Text = "Indicador :"
		Me.Label19.Size = New System.Drawing.Size(50, 13)
		Me.Label19.Location = New System.Drawing.Point(590, 15)
		Me.Label19.TabIndex = 8
		Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label19.BackColor = System.Drawing.SystemColors.Control
		Me.Label19.Enabled = True
		Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label19.UseMnemonic = True
		Me.Label19.Visible = True
		Me.Label19.AutoSize = True
		Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label19.Name = "Label19"
		Me.Label20.Text = "T/Cambio :"
		Me.Label20.Size = New System.Drawing.Size(53, 13)
		Me.Label20.Location = New System.Drawing.Point(590, 62)
		Me.Label20.TabIndex = 7
		Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label20.BackColor = System.Drawing.SystemColors.Control
		Me.Label20.Enabled = True
		Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label20.UseMnemonic = True
		Me.Label20.Visible = True
		Me.Label20.AutoSize = True
		Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label20.Name = "Label20"
		Me.Label21.Text = "V/Cambio :"
		Me.Label21.Size = New System.Drawing.Size(53, 13)
		Me.Label21.Location = New System.Drawing.Point(592, 85)
		Me.Label21.TabIndex = 6
		Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label21.BackColor = System.Drawing.SystemColors.Control
		Me.Label21.Enabled = True
		Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label21.UseMnemonic = True
		Me.Label21.Visible = True
		Me.Label21.AutoSize = True
		Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label21.Name = "Label21"
		Me.Label22.Text = "Monto :"
		Me.Label22.ForeColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me.Label22.Size = New System.Drawing.Size(36, 13)
		Me.Label22.Location = New System.Drawing.Point(591, 107)
		Me.Label22.TabIndex = 5
		Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label22.BackColor = System.Drawing.SystemColors.Control
		Me.Label22.Enabled = True
		Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label22.UseMnemonic = True
		Me.Label22.Visible = True
		Me.Label22.AutoSize = True
		Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label22.Name = "Label22"
		Me.Label23.Text = "Glosa :"
		Me.Label23.Size = New System.Drawing.Size(33, 13)
		Me.Label23.Location = New System.Drawing.Point(8, 160)
		Me.Label23.TabIndex = 4
		Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label23.BackColor = System.Drawing.SystemColors.Control
		Me.Label23.Enabled = True
		Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label23.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label23.UseMnemonic = True
		Me.Label23.Visible = True
		Me.Label23.AutoSize = False
		Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label23.Name = "Label23"
		Me.Label24.Text = "Moneda :"
		Me.Label24.Size = New System.Drawing.Size(45, 13)
		Me.Label24.Location = New System.Drawing.Point(592, 41)
		Me.Label24.TabIndex = 3
		Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label24.BackColor = System.Drawing.SystemColors.Control
		Me.Label24.Enabled = True
		Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label24.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label24.UseMnemonic = True
		Me.Label24.Visible = True
		Me.Label24.AutoSize = True
		Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label24.Name = "Label24"
		Me.StBar.Size = New System.Drawing.Size(748, 19)
		Me.StBar.Location = New System.Drawing.Point(6, 572)
		Me.StBar.TabIndex = 53
		Me.StBar.Name = "StBar"
		Me._StBar_Panel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
		Me._StBar_Panel1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me._StBar_Panel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._StBar_Panel1.Size = New System.Drawing.Size(204, 19)
		Me._StBar_Panel1.Text = "Asiento : "
		Me._StBar_Panel1.AutoSize = True
		Me._StBar_Panel1.BorderSides = CType(System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom, System.Windows.Forms.ToolStripStatusLabelBorderSides)
		Me._StBar_Panel1.Margin = New System.Windows.Forms.Padding(0)
		Me._StBar_Panel1.AutoSize = False
		Me._StBar_Panel2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
		Me._StBar_Panel2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me._StBar_Panel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._StBar_Panel2.Size = New System.Drawing.Size(297, 19)
		Me._StBar_Panel2.Text = "Sub Asiento :"
		Me._StBar_Panel2.BorderSides = CType(System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom, System.Windows.Forms.ToolStripStatusLabelBorderSides)
		Me._StBar_Panel2.Margin = New System.Windows.Forms.Padding(0)
		Me._StBar_Panel2.AutoSize = False
		Me._StBar_Panel3.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
		Me._StBar_Panel3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me._StBar_Panel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._StBar_Panel3.BorderSides = CType(System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom, System.Windows.Forms.ToolStripStatusLabelBorderSides)
		Me._StBar_Panel3.Margin = New System.Windows.Forms.Padding(0)
		Me._StBar_Panel3.Size = New System.Drawing.Size(96, 19)
		Me._StBar_Panel3.AutoSize = False
		Me._StBar_Panel4.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
		Me._StBar_Panel4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
		Me._StBar_Panel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me._StBar_Panel4.Size = New System.Drawing.Size(149, 19)
		Me._StBar_Panel4.Image = resources.GetObject("_StBar_Panel4.Image")
		Me._StBar_Panel4.Text = "Estado :"
		Me._StBar_Panel4.Spring = True
		Me._StBar_Panel4.AutoSize = True
		Me._StBar_Panel4.BorderSides = CType(System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom, System.Windows.Forms.ToolStripStatusLabelBorderSides)
		Me._StBar_Panel4.Margin = New System.Windows.Forms.Padding(0)
		Me._StBar_Panel4.AutoSize = False
		Me.frameGrid.BackColor = System.Drawing.Color.FromARGB(192, 255, 255)
		Me.frameGrid.Size = New System.Drawing.Size(817, 195)
		Me.frameGrid.Location = New System.Drawing.Point(8, 160)
		Me.frameGrid.TabIndex = 81
		Me.frameGrid.Enabled = True
		Me.frameGrid.ForeColor = System.Drawing.SystemColors.ControlText
		Me.frameGrid.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.frameGrid.Visible = True
		Me.frameGrid.Padding = New System.Windows.Forms.Padding(0)
		Me.frameGrid.Name = "frameGrid"
		TDBG_Det.OcxState = CType(resources.GetObject("TDBG_Det.OcxState"), System.Windows.Forms.AxHost.State)
		Me.TDBG_Det.Size = New System.Drawing.Size(808, 152)
		Me.TDBG_Det.Location = New System.Drawing.Point(5, 12)
		Me.TDBG_Det.TabIndex = 45
		Me.TDBG_Det.Name = "TDBG_Det"
		Me.Shape10.BackColor = System.Drawing.SystemColors.InactiveBorder
		Me.Shape10.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
		Me.Shape10.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
		Me.Shape10.Size = New System.Drawing.Size(751, 6)
		Me.Shape10.Location = New System.Drawing.Point(0, -13)
		Me.Shape10.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Shape10.BorderWidth = 1
		Me.Shape10.FillColor = System.Drawing.Color.Black
		Me.Shape10.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent
		Me.Shape10.Visible = True
		Me.Shape10.Name = "Shape10"
		Me.Label7.Text = "Nº Registros :"
		Me.Label7.ForeColor = System.Drawing.Color.White
		Me.Label7.Size = New System.Drawing.Size(65, 13)
		Me.Label7.Location = New System.Drawing.Point(596, 175)
		Me.Label7.TabIndex = 83
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label7.BackColor = System.Drawing.Color.Transparent
		Me.Label7.Enabled = True
		Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label7.UseMnemonic = True
		Me.Label7.Visible = True
		Me.Label7.AutoSize = True
		Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label7.Name = "Label7"
		Me.lbnregdetalle.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.lbnregdetalle.BackColor = System.Drawing.Color.White
		Me.lbnregdetalle.Text = "0 "
		Me.lbnregdetalle.Size = New System.Drawing.Size(70, 17)
		Me.lbnregdetalle.Location = New System.Drawing.Point(733, 173)
		Me.lbnregdetalle.TabIndex = 82
		Me.lbnregdetalle.Enabled = True
		Me.lbnregdetalle.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lbnregdetalle.Cursor = System.Windows.Forms.Cursors.Default
		Me.lbnregdetalle.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lbnregdetalle.UseMnemonic = True
		Me.lbnregdetalle.Visible = True
		Me.lbnregdetalle.AutoSize = False
		Me.lbnregdetalle.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lbnregdetalle.Name = "lbnregdetalle"
		Me.Shape9.BorderColor = System.Drawing.Color.FromARGB(64, 64, 64)
		Me.Shape9.Size = New System.Drawing.Size(73, 19)
		Me.Shape9.Location = New System.Drawing.Point(732, 159)
		Me.Shape9.BackColor = System.Drawing.SystemColors.Window
		Me.Shape9.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent
		Me.Shape9.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Shape9.BorderWidth = 1
		Me.Shape9.FillColor = System.Drawing.Color.Black
		Me.Shape9.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent
		Me.Shape9.Visible = True
		Me.Shape9.Name = "Shape9"
		Me.FrameCabecera.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me.FrameCabecera.Size = New System.Drawing.Size(817, 140)
		Me.FrameCabecera.Location = New System.Drawing.Point(7, 21)
		Me.FrameCabecera.TabIndex = 24
		Me.FrameCabecera.Enabled = True
		Me.FrameCabecera.ForeColor = System.Drawing.SystemColors.ControlText
		Me.FrameCabecera.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.FrameCabecera.Visible = True
		Me.FrameCabecera.Padding = New System.Windows.Forms.Padding(0)
		Me.FrameCabecera.Name = "FrameCabecera"
		Me.ChkGrabado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.ChkGrabado.Text = "Oper. Grabada"
		Me.ChkGrabado.ForeColor = System.Drawing.Color.FromARGB(192, 0, 0)
		Me.ChkGrabado.Size = New System.Drawing.Size(114, 15)
		Me.ChkGrabado.Location = New System.Drawing.Point(10, 116)
		Me.ChkGrabado.TabIndex = 22
		Me.ChkGrabado.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.ChkGrabado.BackColor = System.Drawing.SystemColors.Control
		Me.ChkGrabado.CausesValidation = True
		Me.ChkGrabado.Enabled = True
		Me.ChkGrabado.Cursor = System.Windows.Forms.Cursors.Default
		Me.ChkGrabado.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ChkGrabado.Appearance = System.Windows.Forms.Appearance.Normal
		Me.ChkGrabado.TabStop = True
		Me.ChkGrabado.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.ChkGrabado.Visible = True
		Me.ChkGrabado.Name = "ChkGrabado"
		DTPFechaComprobCab.OcxState = CType(resources.GetObject("DTPFechaComprobCab.OcxState"), System.Windows.Forms.AxHost.State)
		Me.DTPFechaComprobCab.Size = New System.Drawing.Size(102, 20)
		Me.DTPFechaComprobCab.Location = New System.Drawing.Point(111, 36)
		Me.DTPFechaComprobCab.TabIndex = 18
		Me.DTPFechaComprobCab.Name = "DTPFechaComprobCab"
		TxGlosaComprobCab.OcxState = CType(resources.GetObject("TxGlosaComprobCab.OcxState"), System.Windows.Forms.AxHost.State)
		Me.TxGlosaComprobCab.Size = New System.Drawing.Size(307, 20)
		Me.TxGlosaComprobCab.Location = New System.Drawing.Point(110, 57)
		Me.TxGlosaComprobCab.TabIndex = 20
		Me.TxGlosaComprobCab.CausesValidation = -1
		Me.TxGlosaComprobCab.Name = "TxGlosaComprobCab"
		TxObsComprobCab.OcxState = CType(resources.GetObject("TxObsComprobCab.OcxState"), System.Windows.Forms.AxHost.State)
		Me.TxObsComprobCab.Size = New System.Drawing.Size(307, 36)
		Me.TxObsComprobCab.Location = New System.Drawing.Point(110, 78)
		Me.TxObsComprobCab.TabIndex = 21
		Me.TxObsComprobCab.CausesValidation = -1
		Me.TxObsComprobCab.Name = "TxObsComprobCab"
		TxCtrNref.OcxState = CType(resources.GetObject("TxCtrNref.OcxState"), System.Windows.Forms.AxHost.State)
		Me.TxCtrNref.Size = New System.Drawing.Size(134, 20)
		Me.TxCtrNref.Location = New System.Drawing.Point(283, 115)
		Me.TxCtrNref.TabIndex = 23
		Me.TxCtrNref.CausesValidation = -1
		Me.TxCtrNref.Name = "TxCtrNref"
		Me.lbNumComprobCablibro.BackColor = System.Drawing.Color.FromARGB(254, 253, 226)
		Me.lbNumComprobCablibro.Text = "000001"
		Me.lbNumComprobCablibro.ForeColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me.lbNumComprobCablibro.Size = New System.Drawing.Size(101, 19)
		Me.lbNumComprobCablibro.Location = New System.Drawing.Point(318, 16)
		Me.lbNumComprobCablibro.TabIndex = 93
		Me.lbNumComprobCablibro.Visible = False
		Me.lbNumComprobCablibro.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lbNumComprobCablibro.Enabled = True
		Me.lbNumComprobCablibro.Cursor = System.Windows.Forms.Cursors.Default
		Me.lbNumComprobCablibro.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lbNumComprobCablibro.UseMnemonic = True
		Me.lbNumComprobCablibro.AutoSize = False
		Me.lbNumComprobCablibro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lbNumComprobCablibro.Name = "lbNumComprobCablibro"
		Me._leNComprob_0.Text = "Nº. Comp. Libro :"
		Me._leNComprob_0.ForeColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me._leNComprob_0.Size = New System.Drawing.Size(80, 13)
		Me._leNComprob_0.Location = New System.Drawing.Point(223, 19)
		Me._leNComprob_0.TabIndex = 92
		Me._leNComprob_0.Visible = False
		Me._leNComprob_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._leNComprob_0.BackColor = System.Drawing.SystemColors.Control
		Me._leNComprob_0.Enabled = True
		Me._leNComprob_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._leNComprob_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._leNComprob_0.UseMnemonic = True
		Me._leNComprob_0.AutoSize = True
		Me._leNComprob_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._leNComprob_0.Name = "_leNComprob_0"
		Me.lbnemoref.Text = "Nemotecnico "
		Me.lbnemoref.Size = New System.Drawing.Size(138, 13)
		Me.lbnemoref.Location = New System.Drawing.Point(133, 117)
		Me.lbnemoref.TabIndex = 90
		Me.lbnemoref.Visible = False
		Me.lbnemoref.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lbnemoref.BackColor = System.Drawing.SystemColors.Control
		Me.lbnemoref.Enabled = True
		Me.lbnemoref.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lbnemoref.Cursor = System.Windows.Forms.Cursors.Default
		Me.lbnemoref.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lbnemoref.UseMnemonic = True
		Me.lbnemoref.AutoSize = True
		Me.lbnemoref.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lbnemoref.Name = "lbnemoref"
		Me.Shape1.BorderColor = System.Drawing.Color.FromARGB(128, 128, 128)
		Me.Shape1.Size = New System.Drawing.Size(304, 119)
		Me.Shape1.Location = New System.Drawing.Point(432, 1)
		Me.Shape1.CornerRadius = 14
		Me.Shape1.BackColor = System.Drawing.SystemColors.Window
		Me.Shape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent
		Me.Shape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Shape1.BorderWidth = 1
		Me.Shape1.FillColor = System.Drawing.Color.Black
		Me.Shape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent
		Me.Shape1.Visible = True
		Me.Shape1.Name = "Shape1"
		Me.leDebe.Text = "DEBE"
		Me.leDebe.ForeColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me.leDebe.Size = New System.Drawing.Size(34, 13)
		Me.leDebe.Location = New System.Drawing.Point(444, 50)
		Me.leDebe.TabIndex = 69
		Me.leDebe.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.leDebe.BackColor = System.Drawing.SystemColors.Control
		Me.leDebe.Enabled = True
		Me.leDebe.Cursor = System.Windows.Forms.Cursors.Default
		Me.leDebe.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.leDebe.UseMnemonic = True
		Me.leDebe.Visible = True
		Me.leDebe.AutoSize = True
		Me.leDebe.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.leDebe.Name = "leDebe"
		Me.Shape2.BorderColor = System.Drawing.Color.White
		Me.Shape2.Size = New System.Drawing.Size(304, 120)
		Me.Shape2.Location = New System.Drawing.Point(433, -1)
		Me.Shape2.CornerRadius = 14
		Me.Shape2.BackColor = System.Drawing.SystemColors.Window
		Me.Shape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent
		Me.Shape2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Shape2.BorderWidth = 1
		Me.Shape2.FillColor = System.Drawing.Color.Black
		Me.Shape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent
		Me.Shape2.Visible = True
		Me.Shape2.Name = "Shape2"
		Me.leHaber.Text = "HABER"
		Me.leHaber.ForeColor = System.Drawing.Color.FromARGB(128, 0, 0)
		Me.leHaber.Size = New System.Drawing.Size(43, 13)
		Me.leHaber.Location = New System.Drawing.Point(444, 70)
		Me.leHaber.TabIndex = 68
		Me.leHaber.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.leHaber.BackColor = System.Drawing.SystemColors.Control
		Me.leHaber.Enabled = True
		Me.leHaber.Cursor = System.Windows.Forms.Cursors.Default
		Me.leHaber.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.leHaber.UseMnemonic = True
		Me.leHaber.Visible = True
		Me.leHaber.AutoSize = True
		Me.leHaber.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.leHaber.Name = "leHaber"
		Me.leSoles.Text = "SOLES S/."
		Me.leSoles.ForeColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me.leSoles.Size = New System.Drawing.Size(63, 13)
		Me.leSoles.Location = New System.Drawing.Point(518, 24)
		Me.leSoles.TabIndex = 67
		Me.leSoles.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.leSoles.BackColor = System.Drawing.SystemColors.Control
		Me.leSoles.Enabled = True
		Me.leSoles.Cursor = System.Windows.Forms.Cursors.Default
		Me.leSoles.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.leSoles.UseMnemonic = True
		Me.leSoles.Visible = True
		Me.leSoles.AutoSize = True
		Me.leSoles.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.leSoles.Name = "leSoles"
		Me.LeDolares.Text = "DOLARES US$"
		Me.LeDolares.ForeColor = System.Drawing.Color.FromARGB(0, 128, 0)
		Me.LeDolares.Size = New System.Drawing.Size(87, 13)
		Me.LeDolares.Location = New System.Drawing.Point(630, 24)
		Me.LeDolares.TabIndex = 66
		Me.LeDolares.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.LeDolares.BackColor = System.Drawing.SystemColors.Control
		Me.LeDolares.Enabled = True
		Me.LeDolares.Cursor = System.Windows.Forms.Cursors.Default
		Me.LeDolares.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.LeDolares.UseMnemonic = True
		Me.LeDolares.Visible = True
		Me.LeDolares.AutoSize = True
		Me.LeDolares.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.LeDolares.Name = "LeDolares"
		Me._LbTotales_0.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me._LbTotales_0.BackColor = System.Drawing.Color.FromARGB(217, 227, 251)
		Me._LbTotales_0.Text = "0.00 "
		Me._LbTotales_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._LbTotales_0.Size = New System.Drawing.Size(109, 18)
		Me._LbTotales_0.Location = New System.Drawing.Point(502, 47)
		Me._LbTotales_0.TabIndex = 65
		Me._LbTotales_0.Enabled = True
		Me._LbTotales_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._LbTotales_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._LbTotales_0.UseMnemonic = True
		Me._LbTotales_0.Visible = True
		Me._LbTotales_0.AutoSize = False
		Me._LbTotales_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me._LbTotales_0.Name = "_LbTotales_0"
		Me._LbTotales_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me._LbTotales_1.BackColor = System.Drawing.Color.FromARGB(217, 227, 251)
		Me._LbTotales_1.Text = "0.00 "
		Me._LbTotales_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._LbTotales_1.Size = New System.Drawing.Size(109, 18)
		Me._LbTotales_1.Location = New System.Drawing.Point(502, 67)
		Me._LbTotales_1.TabIndex = 64
		Me._LbTotales_1.Enabled = True
		Me._LbTotales_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._LbTotales_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._LbTotales_1.UseMnemonic = True
		Me._LbTotales_1.Visible = True
		Me._LbTotales_1.AutoSize = False
		Me._LbTotales_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me._LbTotales_1.Name = "_LbTotales_1"
		Me._LbTotales_3.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me._LbTotales_3.BackColor = System.Drawing.Color.FromARGB(224, 235, 231)
		Me._LbTotales_3.Text = "0.00 "
		Me._LbTotales_3.ForeColor = System.Drawing.SystemColors.WindowText
		Me._LbTotales_3.Size = New System.Drawing.Size(109, 18)
		Me._LbTotales_3.Location = New System.Drawing.Point(621, 46)
		Me._LbTotales_3.TabIndex = 63
		Me._LbTotales_3.Enabled = True
		Me._LbTotales_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._LbTotales_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._LbTotales_3.UseMnemonic = True
		Me._LbTotales_3.Visible = True
		Me._LbTotales_3.AutoSize = False
		Me._LbTotales_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me._LbTotales_3.Name = "_LbTotales_3"
		Me._LbTotales_4.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me._LbTotales_4.BackColor = System.Drawing.Color.FromARGB(224, 235, 231)
		Me._LbTotales_4.Text = "0.00 "
		Me._LbTotales_4.ForeColor = System.Drawing.SystemColors.WindowText
		Me._LbTotales_4.Size = New System.Drawing.Size(109, 18)
		Me._LbTotales_4.Location = New System.Drawing.Point(620, 67)
		Me._LbTotales_4.TabIndex = 62
		Me._LbTotales_4.Enabled = True
		Me._LbTotales_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._LbTotales_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._LbTotales_4.UseMnemonic = True
		Me._LbTotales_4.Visible = True
		Me._LbTotales_4.AutoSize = False
		Me._LbTotales_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me._LbTotales_4.Name = "_LbTotales_4"
		Me.leDifer.Text = "DIFER."
		Me.leDifer.ForeColor = System.Drawing.Color.FromARGB(64, 64, 64)
		Me.leDifer.Size = New System.Drawing.Size(42, 13)
		Me.leDifer.Location = New System.Drawing.Point(445, 104)
		Me.leDifer.TabIndex = 61
		Me.leDifer.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.leDifer.BackColor = System.Drawing.SystemColors.Control
		Me.leDifer.Enabled = True
		Me.leDifer.Cursor = System.Windows.Forms.Cursors.Default
		Me.leDifer.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.leDifer.UseMnemonic = True
		Me.leDifer.Visible = True
		Me.leDifer.AutoSize = True
		Me.leDifer.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.leDifer.Name = "leDifer"
		Me._LbTotales_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me._LbTotales_2.BackColor = System.Drawing.Color.FromARGB(255, 254, 242)
		Me._LbTotales_2.Text = "0.00 "
		Me._LbTotales_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._LbTotales_2.Size = New System.Drawing.Size(109, 18)
		Me._LbTotales_2.Location = New System.Drawing.Point(502, 101)
		Me._LbTotales_2.TabIndex = 60
		Me._LbTotales_2.Enabled = True
		Me._LbTotales_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._LbTotales_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._LbTotales_2.UseMnemonic = True
		Me._LbTotales_2.Visible = True
		Me._LbTotales_2.AutoSize = False
		Me._LbTotales_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me._LbTotales_2.Name = "_LbTotales_2"
		Me._LbTotales_5.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me._LbTotales_5.BackColor = System.Drawing.Color.FromARGB(255, 254, 242)
		Me._LbTotales_5.Text = "0.00 "
		Me._LbTotales_5.ForeColor = System.Drawing.SystemColors.WindowText
		Me._LbTotales_5.Size = New System.Drawing.Size(109, 18)
		Me._LbTotales_5.Location = New System.Drawing.Point(621, 101)
		Me._LbTotales_5.TabIndex = 59
		Me._LbTotales_5.Enabled = True
		Me._LbTotales_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._LbTotales_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._LbTotales_5.UseMnemonic = True
		Me._LbTotales_5.Visible = True
		Me._LbTotales_5.AutoSize = False
		Me._LbTotales_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me._LbTotales_5.Name = "_LbTotales_5"
		Me._leNComprob_1.Text = "Nº. Comprobante :"
		Me._leNComprob_1.Size = New System.Drawing.Size(87, 13)
		Me._leNComprob_1.Location = New System.Drawing.Point(11, 15)
		Me._leNComprob_1.TabIndex = 52
		Me._leNComprob_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._leNComprob_1.BackColor = System.Drawing.SystemColors.Control
		Me._leNComprob_1.Enabled = True
		Me._leNComprob_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._leNComprob_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._leNComprob_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._leNComprob_1.UseMnemonic = True
		Me._leNComprob_1.Visible = True
		Me._leNComprob_1.AutoSize = True
		Me._leNComprob_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._leNComprob_1.Name = "_leNComprob_1"
		Me.lbNumComprobCab.BackColor = System.Drawing.Color.FromARGB(254, 253, 226)
		Me.lbNumComprobCab.Text = "0000010000"
		Me.lbNumComprobCab.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lbNumComprobCab.Size = New System.Drawing.Size(101, 19)
		Me.lbNumComprobCab.Location = New System.Drawing.Point(111, 15)
		Me.lbNumComprobCab.TabIndex = 51
		Me.lbNumComprobCab.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lbNumComprobCab.Enabled = True
		Me.lbNumComprobCab.Cursor = System.Windows.Forms.Cursors.Default
		Me.lbNumComprobCab.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lbNumComprobCab.UseMnemonic = True
		Me.lbNumComprobCab.Visible = True
		Me.lbNumComprobCab.AutoSize = False
		Me.lbNumComprobCab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lbNumComprobCab.Name = "lbNumComprobCab"
		Me._leFechaComprob_7.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me._leFechaComprob_7.Text = "Fecha Comprob. :"
		Me._leFechaComprob_7.Size = New System.Drawing.Size(84, 13)
		Me._leFechaComprob_7.Location = New System.Drawing.Point(11, 37)
		Me._leFechaComprob_7.TabIndex = 50
		Me._leFechaComprob_7.BackColor = System.Drawing.SystemColors.Control
		Me._leFechaComprob_7.Enabled = True
		Me._leFechaComprob_7.ForeColor = System.Drawing.SystemColors.ControlText
		Me._leFechaComprob_7.Cursor = System.Windows.Forms.Cursors.Default
		Me._leFechaComprob_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._leFechaComprob_7.UseMnemonic = True
		Me._leFechaComprob_7.Visible = True
		Me._leFechaComprob_7.AutoSize = True
		Me._leFechaComprob_7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._leFechaComprob_7.Name = "_leFechaComprob_7"
		Me.leGlosa.Text = "Glosa Comprob. :"
		Me.leGlosa.Size = New System.Drawing.Size(95, 23)
		Me.leGlosa.Location = New System.Drawing.Point(11, 60)
		Me.leGlosa.TabIndex = 49
		Me.leGlosa.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.leGlosa.BackColor = System.Drawing.SystemColors.Control
		Me.leGlosa.Enabled = True
		Me.leGlosa.ForeColor = System.Drawing.SystemColors.ControlText
		Me.leGlosa.Cursor = System.Windows.Forms.Cursors.Default
		Me.leGlosa.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.leGlosa.UseMnemonic = True
		Me.leGlosa.Visible = True
		Me.leGlosa.AutoSize = False
		Me.leGlosa.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.leGlosa.Name = "leGlosa"
		Me.leObservaciones.Text = "Observaciones :"
		Me.leObservaciones.Size = New System.Drawing.Size(77, 13)
		Me.leObservaciones.Location = New System.Drawing.Point(11, 87)
		Me.leObservaciones.TabIndex = 48
		Me.leObservaciones.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.leObservaciones.BackColor = System.Drawing.SystemColors.Control
		Me.leObservaciones.Enabled = True
		Me.leObservaciones.ForeColor = System.Drawing.SystemColors.ControlText
		Me.leObservaciones.Cursor = System.Windows.Forms.Cursors.Default
		Me.leObservaciones.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.leObservaciones.UseMnemonic = True
		Me.leObservaciones.Visible = True
		Me.leObservaciones.AutoSize = True
		Me.leObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.leObservaciones.Name = "leObservaciones"
		Me.FrameIngreso.BackColor = System.Drawing.Color.FromARGB(192, 192, 255)
		Me.FrameIngreso.Size = New System.Drawing.Size(817, 209)
		Me.FrameIngreso.Location = New System.Drawing.Point(8, 360)
		Me.FrameIngreso.TabIndex = 94
		Me.FrameIngreso.Enabled = True
		Me.FrameIngreso.ForeColor = System.Drawing.SystemColors.ControlText
		Me.FrameIngreso.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.FrameIngreso.Visible = True
		Me.FrameIngreso.Padding = New System.Windows.Forms.Padding(0)
		Me.FrameIngreso.Name = "FrameIngreso"
		Me.FrameCcosto.BackColor = System.Drawing.Color.FromARGB(192, 192, 255)
		Me.FrameCcosto.Text = "Centro de Costos"
		Me.FrameCcosto.Size = New System.Drawing.Size(217, 201)
		Me.FrameCcosto.Location = New System.Drawing.Point(432, 8)
		Me.FrameCcosto.TabIndex = 127
		Me.FrameCcosto.Enabled = True
		Me.FrameCcosto.ForeColor = System.Drawing.SystemColors.ControlText
		Me.FrameCcosto.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.FrameCcosto.Visible = True
		Me.FrameCcosto.Padding = New System.Windows.Forms.Padding(0)
		Me.FrameCcosto.Name = "FrameCcosto"
		TDBGrid1.OcxState = CType(resources.GetObject("TDBGrid1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.TDBGrid1.Size = New System.Drawing.Size(209, 129)
		Me.TDBGrid1.Location = New System.Drawing.Point(0, 16)
		Me.TDBGrid1.TabIndex = 128
		Me.TDBGrid1.Name = "TDBGrid1"
		Me.Frame5.Size = New System.Drawing.Size(161, 49)
		Me.Frame5.Location = New System.Drawing.Point(648, 160)
		Me.Frame5.TabIndex = 124
		Me.Frame5.BackColor = System.Drawing.SystemColors.Control
		Me.Frame5.Enabled = True
		Me.Frame5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame5.Visible = True
		Me.Frame5.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame5.Name = "Frame5"
		Me.Cmdsalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Cmdsalir.BackColor = System.Drawing.SystemColors.Control
		Me.Cmdsalir.Text = "Salir"
		Me.Cmdsalir.Size = New System.Drawing.Size(65, 17)
		Me.Cmdsalir.Location = New System.Drawing.Point(80, 24)
		Me.Cmdsalir.TabIndex = 126
		Me.Cmdsalir.CausesValidation = True
		Me.Cmdsalir.Enabled = True
		Me.Cmdsalir.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Cmdsalir.Cursor = System.Windows.Forms.Cursors.Default
		Me.Cmdsalir.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Cmdsalir.TabStop = True
		Me.Cmdsalir.Name = "Cmdsalir"
		Me.CmdAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.CmdAceptar.BackColor = System.Drawing.SystemColors.Control
		Me.CmdAceptar.Text = "Aceptar"
		Me.CmdAceptar.Size = New System.Drawing.Size(65, 17)
		Me.CmdAceptar.Location = New System.Drawing.Point(8, 24)
		Me.CmdAceptar.TabIndex = 125
		Me.CmdAceptar.CausesValidation = True
		Me.CmdAceptar.Enabled = True
		Me.CmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.CmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
		Me.CmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CmdAceptar.TabStop = True
		Me.CmdAceptar.Name = "CmdAceptar"
		Me.Frame1.BackColor = System.Drawing.Color.White
		Me.Frame1.Size = New System.Drawing.Size(161, 153)
		Me.Frame1.Location = New System.Drawing.Point(648, 8)
		Me.Frame1.TabIndex = 113
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.Txtimpo.AutoSize = False
		Me.Txtimpo.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me.Txtimpo.Size = New System.Drawing.Size(81, 19)
		Me.Txtimpo.Location = New System.Drawing.Point(64, 16)
		Me.Txtimpo.Maxlength = 12
		Me.Txtimpo.TabIndex = 118
		Me.Txtimpo.AcceptsReturn = True
		Me.Txtimpo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Txtimpo.CausesValidation = True
		Me.Txtimpo.Enabled = True
		Me.Txtimpo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Txtimpo.HideSelection = True
		Me.Txtimpo.ReadOnly = False
		Me.Txtimpo.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Txtimpo.MultiLine = False
		Me.Txtimpo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Txtimpo.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Txtimpo.TabStop = True
		Me.Txtimpo.Visible = True
		Me.Txtimpo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Txtimpo.Name = "Txtimpo"
		Me.TxtIgv.AutoSize = False
		Me.TxtIgv.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me.TxtIgv.Size = New System.Drawing.Size(81, 19)
		Me.TxtIgv.Location = New System.Drawing.Point(64, 40)
		Me.TxtIgv.Maxlength = 12
		Me.TxtIgv.TabIndex = 117
		Me.TxtIgv.AcceptsReturn = True
		Me.TxtIgv.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.TxtIgv.CausesValidation = True
		Me.TxtIgv.Enabled = True
		Me.TxtIgv.ForeColor = System.Drawing.SystemColors.WindowText
		Me.TxtIgv.HideSelection = True
		Me.TxtIgv.ReadOnly = False
		Me.TxtIgv.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TxtIgv.MultiLine = False
		Me.TxtIgv.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TxtIgv.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.TxtIgv.TabStop = True
		Me.TxtIgv.Visible = True
		Me.TxtIgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.TxtIgv.Name = "TxtIgv"
		Me.TxtInaf.AutoSize = False
		Me.TxtInaf.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me.TxtInaf.Size = New System.Drawing.Size(81, 19)
		Me.TxtInaf.Location = New System.Drawing.Point(64, 64)
		Me.TxtInaf.Maxlength = 12
		Me.TxtInaf.TabIndex = 116
		Me.TxtInaf.AcceptsReturn = True
		Me.TxtInaf.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.TxtInaf.CausesValidation = True
		Me.TxtInaf.Enabled = True
		Me.TxtInaf.ForeColor = System.Drawing.SystemColors.WindowText
		Me.TxtInaf.HideSelection = True
		Me.TxtInaf.ReadOnly = False
		Me.TxtInaf.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TxtInaf.MultiLine = False
		Me.TxtInaf.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TxtInaf.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.TxtInaf.TabStop = True
		Me.TxtInaf.Visible = True
		Me.TxtInaf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.TxtInaf.Name = "TxtInaf"
		Me.TxtTot.AutoSize = False
		Me.TxtTot.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me.TxtTot.Size = New System.Drawing.Size(81, 19)
		Me.TxtTot.Location = New System.Drawing.Point(64, 112)
		Me.TxtTot.Maxlength = 12
		Me.TxtTot.TabIndex = 115
		Me.TxtTot.AcceptsReturn = True
		Me.TxtTot.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.TxtTot.CausesValidation = True
		Me.TxtTot.Enabled = True
		Me.TxtTot.ForeColor = System.Drawing.SystemColors.WindowText
		Me.TxtTot.HideSelection = True
		Me.TxtTot.ReadOnly = False
		Me.TxtTot.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TxtTot.MultiLine = False
		Me.TxtTot.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TxtTot.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.TxtTot.TabStop = True
		Me.TxtTot.Visible = True
		Me.TxtTot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.TxtTot.Name = "TxtTot"
		Me.TxtPerc.AutoSize = False
		Me.TxtPerc.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me.TxtPerc.Size = New System.Drawing.Size(81, 19)
		Me.TxtPerc.Location = New System.Drawing.Point(64, 88)
		Me.TxtPerc.Maxlength = 12
		Me.TxtPerc.TabIndex = 114
		Me.TxtPerc.AcceptsReturn = True
		Me.TxtPerc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.TxtPerc.CausesValidation = True
		Me.TxtPerc.Enabled = True
		Me.TxtPerc.ForeColor = System.Drawing.SystemColors.WindowText
		Me.TxtPerc.HideSelection = True
		Me.TxtPerc.ReadOnly = False
		Me.TxtPerc.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TxtPerc.MultiLine = False
		Me.TxtPerc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TxtPerc.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.TxtPerc.TabStop = True
		Me.TxtPerc.Visible = True
		Me.TxtPerc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.TxtPerc.Name = "TxtPerc"
		Me.Labelimpo.BackColor = System.Drawing.Color.White
		Me.Labelimpo.Text = "Imponible"
		Me.Labelimpo.Size = New System.Drawing.Size(57, 17)
		Me.Labelimpo.Location = New System.Drawing.Point(8, 24)
		Me.Labelimpo.TabIndex = 123
		Me.Labelimpo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Labelimpo.Enabled = True
		Me.Labelimpo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Labelimpo.Cursor = System.Windows.Forms.Cursors.Default
		Me.Labelimpo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Labelimpo.UseMnemonic = True
		Me.Labelimpo.Visible = True
		Me.Labelimpo.AutoSize = False
		Me.Labelimpo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Labelimpo.Name = "Labelimpo"
		Me.Labeligv.BackColor = System.Drawing.Color.White
		Me.Labeligv.Text = "Igv"
		Me.Labeligv.Size = New System.Drawing.Size(57, 17)
		Me.Labeligv.Location = New System.Drawing.Point(8, 48)
		Me.Labeligv.TabIndex = 122
		Me.Labeligv.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Labeligv.Enabled = True
		Me.Labeligv.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Labeligv.Cursor = System.Windows.Forms.Cursors.Default
		Me.Labeligv.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Labeligv.UseMnemonic = True
		Me.Labeligv.Visible = True
		Me.Labeligv.AutoSize = False
		Me.Labeligv.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Labeligv.Name = "Labeligv"
		Me.Labelinaf.BackColor = System.Drawing.Color.White
		Me.Labelinaf.Text = "Inafecto"
		Me.Labelinaf.Size = New System.Drawing.Size(57, 17)
		Me.Labelinaf.Location = New System.Drawing.Point(8, 72)
		Me.Labelinaf.TabIndex = 121
		Me.Labelinaf.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Labelinaf.Enabled = True
		Me.Labelinaf.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Labelinaf.Cursor = System.Windows.Forms.Cursors.Default
		Me.Labelinaf.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Labelinaf.UseMnemonic = True
		Me.Labelinaf.Visible = True
		Me.Labelinaf.AutoSize = False
		Me.Labelinaf.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Labelinaf.Name = "Labelinaf"
		Me.Labeltot.BackColor = System.Drawing.Color.White
		Me.Labeltot.Text = "Total"
		Me.Labeltot.Size = New System.Drawing.Size(25, 17)
		Me.Labeltot.Location = New System.Drawing.Point(8, 120)
		Me.Labeltot.TabIndex = 120
		Me.Labeltot.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Labeltot.Enabled = True
		Me.Labeltot.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Labeltot.Cursor = System.Windows.Forms.Cursors.Default
		Me.Labeltot.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Labeltot.UseMnemonic = True
		Me.Labeltot.Visible = True
		Me.Labeltot.AutoSize = False
		Me.Labeltot.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Labeltot.Name = "Labeltot"
		Me.Labelperc.BackColor = System.Drawing.Color.White
		Me.Labelperc.Text = "Percepcion"
		Me.Labelperc.Size = New System.Drawing.Size(57, 17)
		Me.Labelperc.Location = New System.Drawing.Point(8, 96)
		Me.Labelperc.TabIndex = 119
		Me.Labelperc.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Labelperc.Enabled = True
		Me.Labelperc.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Labelperc.Cursor = System.Windows.Forms.Cursors.Default
		Me.Labelperc.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Labelperc.UseMnemonic = True
		Me.Labelperc.Visible = True
		Me.Labelperc.AutoSize = False
		Me.Labelperc.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Labelperc.Name = "Labelperc"
		Me.Frame4.BackColor = System.Drawing.Color.FromARGB(255, 192, 128)
		Me.Frame4.Size = New System.Drawing.Size(425, 89)
		Me.Frame4.Location = New System.Drawing.Point(8, 8)
		Me.Frame4.TabIndex = 105
		Me.Frame4.Enabled = True
		Me.Frame4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame4.Visible = True
		Me.Frame4.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame4.Name = "Frame4"
		CtrAyu_Analitico1.OcxState = CType(resources.GetObject("CtrAyu_Analitico1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.CtrAyu_Analitico1.Size = New System.Drawing.Size(329, 17)
		Me.CtrAyu_Analitico1.Location = New System.Drawing.Point(64, 64)
		Me.CtrAyu_Analitico1.TabIndex = 106
		Me.CtrAyu_Analitico1.Name = "CtrAyu_Analitico1"
		CtrAyu_Cuenta1.OcxState = CType(resources.GetObject("CtrAyu_Cuenta1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.CtrAyu_Cuenta1.Size = New System.Drawing.Size(329, 17)
		Me.CtrAyu_Cuenta1.Location = New System.Drawing.Point(64, 16)
		Me.CtrAyu_Cuenta1.TabIndex = 107
		Me.CtrAyu_Cuenta1.Name = "CtrAyu_Cuenta1"
		CtrAyu_Cuenta2.OcxState = CType(resources.GetObject("CtrAyu_Cuenta2.OcxState"), System.Windows.Forms.AxHost.State)
		Me.CtrAyu_Cuenta2.Size = New System.Drawing.Size(329, 17)
		Me.CtrAyu_Cuenta2.Location = New System.Drawing.Point(64, 40)
		Me.CtrAyu_Cuenta2.TabIndex = 108
		Me.CtrAyu_Cuenta2.Name = "CtrAyu_Cuenta2"
		Me.Label27.BackColor = System.Drawing.Color.FromARGB(255, 192, 128)
		Me.Label27.Text = "Cuenta"
		Me.Label27.Size = New System.Drawing.Size(57, 17)
		Me.Label27.Location = New System.Drawing.Point(8, 24)
		Me.Label27.TabIndex = 110
		Me.Label27.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label27.Enabled = True
		Me.Label27.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label27.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label27.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label27.UseMnemonic = True
		Me.Label27.Visible = True
		Me.Label27.AutoSize = False
		Me.Label27.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label27.Name = "Label27"
		Me.Label14.BackColor = System.Drawing.Color.FromARGB(255, 192, 128)
		Me.Label14.Text = "Analitico"
		Me.Label14.Size = New System.Drawing.Size(57, 17)
		Me.Label14.Location = New System.Drawing.Point(8, 64)
		Me.Label14.TabIndex = 109
		Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label14.Enabled = True
		Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label14.UseMnemonic = True
		Me.Label14.Visible = True
		Me.Label14.AutoSize = False
		Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label14.Name = "Label14"
		Me.Frame2.BackColor = System.Drawing.Color.FromARGB(192, 255, 192)
		Me.Frame2.Size = New System.Drawing.Size(425, 113)
		Me.Frame2.Location = New System.Drawing.Point(8, 96)
		Me.Frame2.TabIndex = 95
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame2.Name = "Frame2"
		TxNdoc1.OcxState = CType(resources.GetObject("TxNdoc1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.TxNdoc1.Size = New System.Drawing.Size(97, 20)
		Me.TxNdoc1.Location = New System.Drawing.Point(320, 8)
		Me.TxNdoc1.TabIndex = 96
		Me.TxNdoc1.CausesValidation = -1
		Me.TxNdoc1.Name = "TxNdoc1"
		TxSerie1.OcxState = CType(resources.GetObject("TxSerie1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.TxSerie1.Size = New System.Drawing.Size(41, 20)
		Me.TxSerie1.Location = New System.Drawing.Point(280, 8)
		Me.TxSerie1.TabIndex = 97
		Me.TxSerie1.CausesValidation = -1
		Me.TxSerie1.Name = "TxSerie1"
		DTP_fecha1.OcxState = CType(resources.GetObject("DTP_fecha1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.DTP_fecha1.Size = New System.Drawing.Size(89, 25)
		Me.DTP_fecha1.Location = New System.Drawing.Point(72, 32)
		Me.DTP_fecha1.TabIndex = 98
		Me.DTP_fecha1.Name = "DTP_fecha1"
		CtrAyu_Moneda1.OcxState = CType(resources.GetObject("CtrAyu_Moneda1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.CtrAyu_Moneda1.Size = New System.Drawing.Size(145, 17)
		Me.CtrAyu_Moneda1.Location = New System.Drawing.Point(272, 32)
		Me.CtrAyu_Moneda1.TabIndex = 99
		Me.CtrAyu_Moneda1.Name = "CtrAyu_Moneda1"
		CtrAyu_TipDoc1.OcxState = CType(resources.GetObject("CtrAyu_TipDoc1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.CtrAyu_TipDoc1.Size = New System.Drawing.Size(145, 25)
		Me.CtrAyu_TipDoc1.Location = New System.Drawing.Point(72, 8)
		Me.CtrAyu_TipDoc1.TabIndex = 100
		Me.CtrAyu_TipDoc1.Name = "CtrAyu_TipDoc1"
		TxFer1.OcxState = CType(resources.GetObject("TxFer1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.TxFer1.Size = New System.Drawing.Size(345, 20)
		Me.TxFer1.Location = New System.Drawing.Point(72, 88)
		Me.TxFer1.TabIndex = 111
		Me.TxFer1.CausesValidation = -1
		Me.TxFer1.Name = "TxFer1"
		Me.Label26.BackColor = System.Drawing.Color.FromARGB(192, 255, 192)
		Me.Label26.Text = "Glosa"
		Me.Label26.Size = New System.Drawing.Size(57, 17)
		Me.Label26.Location = New System.Drawing.Point(8, 88)
		Me.Label26.TabIndex = 112
		Me.Label26.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label26.Enabled = True
		Me.Label26.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label26.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label26.UseMnemonic = True
		Me.Label26.Visible = True
		Me.Label26.AutoSize = False
		Me.Label26.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label26.Name = "Label26"
		Me.Label28.BackColor = System.Drawing.Color.FromARGB(192, 255, 192)
		Me.Label28.Text = "Moneda"
		Me.Label28.Size = New System.Drawing.Size(49, 17)
		Me.Label28.Location = New System.Drawing.Point(216, 40)
		Me.Label28.TabIndex = 104
		Me.Label28.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label28.Enabled = True
		Me.Label28.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label28.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label28.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label28.UseMnemonic = True
		Me.Label28.Visible = True
		Me.Label28.AutoSize = False
		Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label28.Name = "Label28"
		Me.Label17.BackColor = System.Drawing.Color.FromARGB(192, 255, 192)
		Me.Label17.Text = "Fecha Doc."
		Me.Label17.Size = New System.Drawing.Size(73, 17)
		Me.Label17.Location = New System.Drawing.Point(8, 40)
		Me.Label17.TabIndex = 103
		Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label17.Enabled = True
		Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label17.UseMnemonic = True
		Me.Label17.Visible = True
		Me.Label17.AutoSize = False
		Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label17.Name = "Label17"
		Me.Label16.BackColor = System.Drawing.Color.FromARGB(192, 255, 192)
		Me.Label16.Text = "Nro. Doc."
		Me.Label16.Size = New System.Drawing.Size(57, 17)
		Me.Label16.Location = New System.Drawing.Point(224, 16)
		Me.Label16.TabIndex = 102
		Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label16.Enabled = True
		Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label16.UseMnemonic = True
		Me.Label16.Visible = True
		Me.Label16.AutoSize = False
		Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label16.Name = "Label16"
		Me.Label15.BackColor = System.Drawing.Color.FromARGB(192, 255, 192)
		Me.Label15.Text = "Tipo Doc."
		Me.Label15.Size = New System.Drawing.Size(57, 17)
		Me.Label15.Location = New System.Drawing.Point(8, 16)
		Me.Label15.TabIndex = 101
		Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label15.Enabled = True
		Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label15.UseMnemonic = True
		Me.Label15.Visible = True
		Me.Label15.AutoSize = False
		Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label15.Name = "Label15"
		Me.LbTotales.SetIndex(_LbTotales_0, CType(0, Short))
		Me.LbTotales.SetIndex(_LbTotales_1, CType(1, Short))
		Me.LbTotales.SetIndex(_LbTotales_3, CType(3, Short))
		Me.LbTotales.SetIndex(_LbTotales_4, CType(4, Short))
		Me.LbTotales.SetIndex(_LbTotales_2, CType(2, Short))
		Me.LbTotales.SetIndex(_LbTotales_5, CType(5, Short))
		Me.lbTipAnal.SetIndex(_lbTipAnal_0, CType(0, Short))
		Me.leFechaComprob.SetIndex(_leFechaComprob_7, CType(7, Short))
		Me.leNComprob.SetIndex(_leNComprob_0, CType(0, Short))
		Me.leNComprob.SetIndex(_leNComprob_1, CType(1, Short))
		CType(Me.leNComprob, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.leFechaComprob, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lbTipAnal, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LbTotales, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TxFer1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CtrAyu_TipDoc1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CtrAyu_Moneda1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DTP_fecha1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TxSerie1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TxNdoc1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CtrAyu_Cuenta2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CtrAyu_Cuenta1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CtrAyu_Analitico1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TxCtrNref, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TxObsComprobCab, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TxGlosaComprobCab, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DTPFechaComprobCab, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TDBG_Det, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Dtp_FechaDocRef, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TxNref, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CtrAyu_TipRef, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TxGlosa, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DtpFech_Ven, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Dtp_FechaDoc, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CtrAyu_Opera, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CtrAyu_Cuenta, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CtrAyu_CCosto, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CtrAyu_TipAnal, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CtrAyu_Analitico, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CtrAyu_TipDoc, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CtrAyu_Moneda, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txRuc, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TxSerie, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TxNdoc, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TxMonto, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TxValor, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TDBG_Consulta, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Dtc_Campo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TxEjecutar, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CtrAyu_Asiento, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CtrAyu_SubAsiento, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DTPFechaContab, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Controls.Add(SSTabMant)
		Me.SSTabMant.Controls.Add(_SSTabMant_TabPage0)
		Me.SSTabMant.Controls.Add(_SSTabMant_TabPage1)
		Me._SSTabMant_TabPage0.Controls.Add(Frame3)
		Me._SSTabMant_TabPage0.Controls.Add(FrameConsulta)
		Me.Frame3.Controls.Add(DTPFechaContab)
		Me.Frame3.Controls.Add(CtrAyu_SubAsiento)
		Me.Frame3.Controls.Add(CtrAyu_Asiento)
		Me.Frame3.Controls.Add(Label5)
		Me.Frame3.Controls.Add(Image1)
		Me.Frame3.Controls.Add(Label3)
		Me.ShapeContainer1.Shapes.Add(Shape5)
		Me.Frame3.Controls.Add(Label1)
		Me.Frame3.Controls.Add(Label25)
		Me.Frame3.Controls.Add(lbSubAsiento)
		Me.ShapeContainer1.Shapes.Add(Shape6)
		Me.Frame3.Controls.Add(ShapeContainer1)
		Me.FrameConsulta.Controls.Add(TxEjecutar)
		Me.FrameConsulta.Controls.Add(ChkTodos)
		Me.FrameConsulta.Controls.Add(Dtc_Campo)
		Me.FrameConsulta.Controls.Add(TDBG_Consulta)
		Me.ShapeContainer2.Shapes.Add(Shape8)
		Me.ShapeContainer2.Shapes.Add(Shape7)
		Me.FrameConsulta.Controls.Add(lbl_nregconsulta)
		Me.FrameConsulta.Controls.Add(Label6)
		Me.FrameConsulta.Controls.Add(Label2)
		Me.FrameConsulta.Controls.Add(Label4)
		Me.FrameConsulta.Controls.Add(ShapeContainer2)
		Me.ShapeContainer3.Shapes.Add(Shilu2)
		Me._SSTabMant_TabPage1.Controls.Add(SSTab2)
		Me._SSTabMant_TabPage1.Controls.Add(StBar)
		Me._SSTabMant_TabPage1.Controls.Add(frameGrid)
		Me._SSTabMant_TabPage1.Controls.Add(FrameCabecera)
		Me._SSTabMant_TabPage1.Controls.Add(FrameIngreso)
		Me._SSTabMant_TabPage1.Controls.Add(ShapeContainer3)
		Me.SSTab2.Controls.Add(_SSTab2_TabPage0)
		Me.ShapeContainer4.Shapes.Add(Shilu1)
		Me._SSTab2_TabPage0.Controls.Add(FramDetalle)
		Me._SSTab2_TabPage0.Controls.Add(ShapeContainer4)
		Me.FramDetalle.Controls.Add(CmdDocPend)
		Me.FramDetalle.Controls.Add(ChkInafecto)
		Me.FramDetalle.Controls.Add(TxValor)
		Me.FramDetalle.Controls.Add(ChkAjusta)
		Me.FramDetalle.Controls.Add(TxMonto)
		Me.FramDetalle.Controls.Add(TxNdoc)
		Me.FramDetalle.Controls.Add(TxSerie)
		Me.FramDetalle.Controls.Add(txRuc)
		Me.FramDetalle.Controls.Add(CtrAyu_Moneda)
		Me.FramDetalle.Controls.Add(CtrAyu_TipDoc)
		Me.FramDetalle.Controls.Add(CtrAyu_Analitico)
		Me.FramDetalle.Controls.Add(CtrAyu_TipAnal)
		Me.FramDetalle.Controls.Add(CtrAyu_CCosto)
		Me.FramDetalle.Controls.Add(CtrAyu_Cuenta)
		Me.FramDetalle.Controls.Add(CtrAyu_Opera)
		Me.FramDetalle.Controls.Add(CmbID)
		Me.FramDetalle.Controls.Add(CmbTcambio)
		Me.FramDetalle.Controls.Add(Dtp_FechaDoc)
		Me.FramDetalle.Controls.Add(DtpFech_Ven)
		Me.FramDetalle.Controls.Add(TxGlosa)
		Me.FramDetalle.Controls.Add(CtrAyu_TipRef)
		Me.FramDetalle.Controls.Add(TxNref)
		Me.FramDetalle.Controls.Add(Dtp_FechaDocRef)
		Me.FramDetalle.Controls.Add(lbnref)
		Me.FramDetalle.Controls.Add(lbtipref)
		Me.FramDetalle.Controls.Add(lbconv)
		Me.FramDetalle.Controls.Add(lb_vcambio)
		Me.FramDetalle.Controls.Add(_lbTipAnal_0)
		Me.FramDetalle.Controls.Add(lbAnalitico)
		Me.FramDetalle.Controls.Add(Label11)
		Me.FramDetalle.Controls.Add(Label12)
		Me.FramDetalle.Controls.Add(lbccosto)
		Me.FramDetalle.Controls.Add(lbruc)
		Me.ShapeContainer5.Shapes.Add(Shape3)
		Me.ShapeContainer5.Shapes.Add(Shape4)
		Me.FramDetalle.Controls.Add(lbtipdoc)
		Me.FramDetalle.Controls.Add(lbndocum)
		Me.FramDetalle.Controls.Add(lbFechaDoc)
		Me.FramDetalle.Controls.Add(lbFechVen)
		Me.FramDetalle.Controls.Add(Label19)
		Me.FramDetalle.Controls.Add(Label20)
		Me.FramDetalle.Controls.Add(Label21)
		Me.FramDetalle.Controls.Add(Label22)
		Me.FramDetalle.Controls.Add(Label23)
		Me.FramDetalle.Controls.Add(Label24)
		Me.FramDetalle.Controls.Add(ShapeContainer5)
		Me.StBar.Items.AddRange(New System.Windows.Forms.ToolStripItem(){Me._StBar_Panel1})
		Me.StBar.Items.AddRange(New System.Windows.Forms.ToolStripItem(){Me._StBar_Panel2})
		Me.StBar.Items.AddRange(New System.Windows.Forms.ToolStripItem(){Me._StBar_Panel3})
		Me.StBar.Items.AddRange(New System.Windows.Forms.ToolStripItem(){Me._StBar_Panel4})
		Me.frameGrid.Controls.Add(TDBG_Det)
		Me.ShapeContainer6.Shapes.Add(Shape10)
		Me.frameGrid.Controls.Add(Label7)
		Me.frameGrid.Controls.Add(lbnregdetalle)
		Me.ShapeContainer6.Shapes.Add(Shape9)
		Me.frameGrid.Controls.Add(ShapeContainer6)
		Me.FrameCabecera.Controls.Add(ChkGrabado)
		Me.FrameCabecera.Controls.Add(DTPFechaComprobCab)
		Me.FrameCabecera.Controls.Add(TxGlosaComprobCab)
		Me.FrameCabecera.Controls.Add(TxObsComprobCab)
		Me.FrameCabecera.Controls.Add(TxCtrNref)
		Me.FrameCabecera.Controls.Add(lbNumComprobCablibro)
		Me.FrameCabecera.Controls.Add(_leNComprob_0)
		Me.FrameCabecera.Controls.Add(lbnemoref)
		Me.ShapeContainer7.Shapes.Add(Shape1)
		Me.FrameCabecera.Controls.Add(leDebe)
		Me.ShapeContainer7.Shapes.Add(Shape2)
		Me.FrameCabecera.Controls.Add(leHaber)
		Me.FrameCabecera.Controls.Add(leSoles)
		Me.FrameCabecera.Controls.Add(LeDolares)
		Me.FrameCabecera.Controls.Add(_LbTotales_0)
		Me.FrameCabecera.Controls.Add(_LbTotales_1)
		Me.FrameCabecera.Controls.Add(_LbTotales_3)
		Me.FrameCabecera.Controls.Add(_LbTotales_4)
		Me.FrameCabecera.Controls.Add(leDifer)
		Me.FrameCabecera.Controls.Add(_LbTotales_2)
		Me.FrameCabecera.Controls.Add(_LbTotales_5)
		Me.FrameCabecera.Controls.Add(_leNComprob_1)
		Me.FrameCabecera.Controls.Add(lbNumComprobCab)
		Me.FrameCabecera.Controls.Add(_leFechaComprob_7)
		Me.FrameCabecera.Controls.Add(leGlosa)
		Me.FrameCabecera.Controls.Add(leObservaciones)
		Me.FrameCabecera.Controls.Add(ShapeContainer7)
		Me.FrameIngreso.Controls.Add(FrameCcosto)
		Me.FrameIngreso.Controls.Add(Frame5)
		Me.FrameIngreso.Controls.Add(Frame1)
		Me.FrameIngreso.Controls.Add(Frame4)
		Me.FrameIngreso.Controls.Add(Frame2)
		Me.FrameCcosto.Controls.Add(TDBGrid1)
		Me.Frame5.Controls.Add(Cmdsalir)
		Me.Frame5.Controls.Add(CmdAceptar)
		Me.Frame1.Controls.Add(Txtimpo)
		Me.Frame1.Controls.Add(TxtIgv)
		Me.Frame1.Controls.Add(TxtInaf)
		Me.Frame1.Controls.Add(TxtTot)
		Me.Frame1.Controls.Add(TxtPerc)
		Me.Frame1.Controls.Add(Labelimpo)
		Me.Frame1.Controls.Add(Labeligv)
		Me.Frame1.Controls.Add(Labelinaf)
		Me.Frame1.Controls.Add(Labeltot)
		Me.Frame1.Controls.Add(Labelperc)
		Me.Frame4.Controls.Add(CtrAyu_Analitico1)
		Me.Frame4.Controls.Add(CtrAyu_Cuenta1)
		Me.Frame4.Controls.Add(CtrAyu_Cuenta2)
		Me.Frame4.Controls.Add(Label27)
		Me.Frame4.Controls.Add(Label14)
		Me.Frame2.Controls.Add(TxNdoc1)
		Me.Frame2.Controls.Add(TxSerie1)
		Me.Frame2.Controls.Add(DTP_fecha1)
		Me.Frame2.Controls.Add(CtrAyu_Moneda1)
		Me.Frame2.Controls.Add(CtrAyu_TipDoc1)
		Me.Frame2.Controls.Add(TxFer1)
		Me.Frame2.Controls.Add(Label26)
		Me.Frame2.Controls.Add(Label28)
		Me.Frame2.Controls.Add(Label17)
		Me.Frame2.Controls.Add(Label16)
		Me.Frame2.Controls.Add(Label15)
		Me.SSTabMant.ResumeLayout(False)
		Me._SSTabMant_TabPage0.ResumeLayout(False)
		Me.Frame3.ResumeLayout(False)
		Me.FrameConsulta.ResumeLayout(False)
		Me._SSTabMant_TabPage1.ResumeLayout(False)
		Me.SSTab2.ResumeLayout(False)
		Me._SSTab2_TabPage0.ResumeLayout(False)
		Me.FramDetalle.ResumeLayout(False)
		Me.StBar.ResumeLayout(False)
		Me.frameGrid.ResumeLayout(False)
		Me.FrameCabecera.ResumeLayout(False)
		Me.FrameIngreso.ResumeLayout(False)
		Me.FrameCcosto.ResumeLayout(False)
		Me.Frame5.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.Frame4.ResumeLayout(False)
		Me.Frame2.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class