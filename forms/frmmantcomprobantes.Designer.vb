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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmantcomprobantes))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ShapeContainer7 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Shape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Shape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer6 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Shape10 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Shape9 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer5 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Shape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Shape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer4 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Shilu1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Shilu2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Shape8 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Shape7 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Shape5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Shape6 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.SSTabMant = New System.Windows.Forms.TabControl()
        Me._SSTabMant_TabPage0 = New System.Windows.Forms.TabPage()
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me.DTPFechaContab = New AxMSComCtl2.AxDTPicker()
        Me.CtrAyu_SubAsiento = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.CtrAyu_Asiento = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Image1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lbSubAsiento = New System.Windows.Forms.Label()
        Me.FrameConsulta = New System.Windows.Forms.GroupBox()
        Me.TxEjecutar = New AxTextFer.AxTxFer()
        Me.ChkTodos = New System.Windows.Forms.CheckBox()
        Me.Dtc_Campo = New AxMSDataListLib.AxDataCombo()
        Me.TDBG_Consulta = New AxTrueOleDBGrid70.AxTDBGrid()
        Me.lbl_nregconsulta = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me._SSTabMant_TabPage1 = New System.Windows.Forms.TabPage()
        Me.SSTab2 = New System.Windows.Forms.TabControl()
        Me._SSTab2_TabPage0 = New System.Windows.Forms.TabPage()
        Me.FramDetalle = New System.Windows.Forms.GroupBox()
        Me.CmdDocPend = New System.Windows.Forms.Button()
        Me.ChkInafecto = New System.Windows.Forms.CheckBox()
        Me.TxValor = New AxTextFer.AxTxFer()
        Me.ChkAjusta = New System.Windows.Forms.CheckBox()
        Me.TxMonto = New AxTextFer.AxTxFer()
        Me.TxNdoc = New AxTextFer.AxTxFer()
        Me.TxSerie = New AxTextFer.AxTxFer()
        Me.txRuc = New AxTextFer.AxTxFer()
        Me.CtrAyu_Moneda = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.CtrAyu_TipDoc = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.CtrAyu_Analitico = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.CtrAyu_TipAnal = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.CtrAyu_CCosto = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.CtrAyu_Cuenta = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.CtrAyu_Opera = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.CmbID = New System.Windows.Forms.ComboBox()
        Me.CmbTcambio = New System.Windows.Forms.ComboBox()
        Me.Dtp_FechaDoc = New AxMSComCtl2.AxDTPicker()
        Me.DtpFech_Ven = New AxMSComCtl2.AxDTPicker()
        Me.TxGlosa = New AxTextFer.AxTxFer()
        Me.CtrAyu_TipRef = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.TxNref = New AxTextFer.AxTxFer()
        Me.Dtp_FechaDocRef = New AxMSComCtl2.AxDTPicker()
        Me.lbnref = New System.Windows.Forms.Label()
        Me.lbtipref = New System.Windows.Forms.Label()
        Me.lbconv = New System.Windows.Forms.Label()
        Me.lb_vcambio = New System.Windows.Forms.Label()
        Me._lbTipAnal_0 = New System.Windows.Forms.Label()
        Me.lbAnalitico = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbccosto = New System.Windows.Forms.Label()
        Me.lbruc = New System.Windows.Forms.Label()
        Me.lbtipdoc = New System.Windows.Forms.Label()
        Me.lbndocum = New System.Windows.Forms.Label()
        Me.lbFechaDoc = New System.Windows.Forms.Label()
        Me.lbFechVen = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.StBar = New System.Windows.Forms.StatusStrip()
        Me._StBar_Panel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me._StBar_Panel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me._StBar_Panel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me._StBar_Panel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.frameGrid = New System.Windows.Forms.GroupBox()
        Me.TDBG_Det = New AxTrueOleDBGrid70.AxTDBGrid()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbnregdetalle = New System.Windows.Forms.Label()
        Me.FrameCabecera = New System.Windows.Forms.GroupBox()
        Me.ChkGrabado = New System.Windows.Forms.CheckBox()
        Me.DTPFechaComprobCab = New AxMSComCtl2.AxDTPicker()
        Me.TxGlosaComprobCab = New AxTextFer.AxTxFer()
        Me.TxObsComprobCab = New AxTextFer.AxTxFer()
        Me.TxCtrNref = New AxTextFer.AxTxFer()
        Me.lbNumComprobCablibro = New System.Windows.Forms.Label()
        Me._leNComprob_0 = New System.Windows.Forms.Label()
        Me.lbnemoref = New System.Windows.Forms.Label()
        Me.leDebe = New System.Windows.Forms.Label()
        Me.leHaber = New System.Windows.Forms.Label()
        Me.leSoles = New System.Windows.Forms.Label()
        Me.LeDolares = New System.Windows.Forms.Label()
        Me._LbTotales_0 = New System.Windows.Forms.Label()
        Me._LbTotales_1 = New System.Windows.Forms.Label()
        Me._LbTotales_3 = New System.Windows.Forms.Label()
        Me._LbTotales_4 = New System.Windows.Forms.Label()
        Me.leDifer = New System.Windows.Forms.Label()
        Me._LbTotales_2 = New System.Windows.Forms.Label()
        Me._LbTotales_5 = New System.Windows.Forms.Label()
        Me._leNComprob_1 = New System.Windows.Forms.Label()
        Me.lbNumComprobCab = New System.Windows.Forms.Label()
        Me._leFechaComprob_7 = New System.Windows.Forms.Label()
        Me.leGlosa = New System.Windows.Forms.Label()
        Me.leObservaciones = New System.Windows.Forms.Label()
        Me.FrameIngreso = New System.Windows.Forms.GroupBox()
        Me.FrameCcosto = New System.Windows.Forms.GroupBox()
        Me.TDBGrid1 = New AxTrueOleDBGrid70.AxTDBGrid()
        Me.Frame5 = New System.Windows.Forms.GroupBox()
        Me.Cmdsalir = New System.Windows.Forms.Button()
        Me.CmdAceptar = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.Txtimpo = New System.Windows.Forms.TextBox()
        Me.TxtIgv = New System.Windows.Forms.TextBox()
        Me.TxtInaf = New System.Windows.Forms.TextBox()
        Me.TxtTot = New System.Windows.Forms.TextBox()
        Me.TxtPerc = New System.Windows.Forms.TextBox()
        Me.Labelimpo = New System.Windows.Forms.Label()
        Me.Labeligv = New System.Windows.Forms.Label()
        Me.Labelinaf = New System.Windows.Forms.Label()
        Me.Labeltot = New System.Windows.Forms.Label()
        Me.Labelperc = New System.Windows.Forms.Label()
        Me.Frame4 = New System.Windows.Forms.GroupBox()
        Me.CtrAyu_Analitico1 = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.CtrAyu_Cuenta1 = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.CtrAyu_Cuenta2 = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.TxNdoc1 = New AxTextFer.AxTxFer()
        Me.TxSerie1 = New AxTextFer.AxTxFer()
        Me.DTP_fecha1 = New AxMSComCtl2.AxDTPicker()
        Me.CtrAyu_Moneda1 = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.CtrAyu_TipDoc1 = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.TxFer1 = New AxTextFer.AxTxFer()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LbTotales = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.lbTipAnal = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.leFechaComprob = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.leNComprob = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.SSTabMant.SuspendLayout()
        Me._SSTabMant_TabPage0.SuspendLayout()
        Me.Frame3.SuspendLayout()
        CType(Me.DTPFechaContab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CtrAyu_SubAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CtrAyu_Asiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FrameConsulta.SuspendLayout()
        CType(Me.TxEjecutar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtc_Campo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TDBG_Consulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._SSTabMant_TabPage1.SuspendLayout()
        Me.SSTab2.SuspendLayout()
        Me._SSTab2_TabPage0.SuspendLayout()
        Me.FramDetalle.SuspendLayout()
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
        Me.StBar.SuspendLayout()
        Me.frameGrid.SuspendLayout()
        CType(Me.TDBG_Det, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FrameCabecera.SuspendLayout()
        CType(Me.DTPFechaComprobCab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxGlosaComprobCab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxObsComprobCab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxCtrNref, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FrameIngreso.SuspendLayout()
        Me.FrameCcosto.SuspendLayout()
        CType(Me.TDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame5.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.Frame4.SuspendLayout()
        CType(Me.CtrAyu_Analitico1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CtrAyu_Cuenta1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CtrAyu_Cuenta2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame2.SuspendLayout()
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
        Me.SuspendLayout()
        '
        'ShapeContainer7
        '
        Me.ShapeContainer7.Location = New System.Drawing.Point(0, 13)
        Me.ShapeContainer7.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer7.Name = "ShapeContainer7"
        Me.ShapeContainer7.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.Shape1, Me.Shape2})
        Me.ShapeContainer7.Size = New System.Drawing.Size(817, 127)
        Me.ShapeContainer7.TabIndex = 94
        Me.ShapeContainer7.TabStop = False
        '
        'Shape1
        '
        Me.Shape1.BackColor = System.Drawing.SystemColors.Window
        Me.Shape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Shape1.CornerRadius = 14
        Me.Shape1.FillColor = System.Drawing.Color.Black
        Me.Shape1.Location = New System.Drawing.Point(432, 1)
        Me.Shape1.Name = "Shape1"
        Me.Shape1.Size = New System.Drawing.Size(304, 119)
        '
        'Shape2
        '
        Me.Shape2.BackColor = System.Drawing.SystemColors.Window
        Me.Shape2.BorderColor = System.Drawing.Color.White
        Me.Shape2.CornerRadius = 14
        Me.Shape2.FillColor = System.Drawing.Color.Black
        Me.Shape2.Location = New System.Drawing.Point(433, -1)
        Me.Shape2.Name = "Shape2"
        Me.Shape2.Size = New System.Drawing.Size(304, 120)
        '
        'ShapeContainer6
        '
        Me.ShapeContainer6.Location = New System.Drawing.Point(0, 13)
        Me.ShapeContainer6.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer6.Name = "ShapeContainer6"
        Me.ShapeContainer6.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.Shape10, Me.Shape9})
        Me.ShapeContainer6.Size = New System.Drawing.Size(817, 182)
        Me.ShapeContainer6.TabIndex = 84
        Me.ShapeContainer6.TabStop = False
        '
        'Shape10
        '
        Me.Shape10.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Shape10.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.Shape10.BorderColor = System.Drawing.SystemColors.WindowText
        Me.Shape10.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.Shape10.FillColor = System.Drawing.Color.Black
        Me.Shape10.Location = New System.Drawing.Point(0, -13)
        Me.Shape10.Name = "Shape10"
        Me.Shape10.Size = New System.Drawing.Size(751, 6)
        '
        'Shape9
        '
        Me.Shape9.BackColor = System.Drawing.SystemColors.Window
        Me.Shape9.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Shape9.FillColor = System.Drawing.Color.Black
        Me.Shape9.Location = New System.Drawing.Point(732, 159)
        Me.Shape9.Name = "Shape9"
        Me.Shape9.Size = New System.Drawing.Size(73, 19)
        '
        'ShapeContainer5
        '
        Me.ShapeContainer5.Location = New System.Drawing.Point(0, 13)
        Me.ShapeContainer5.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer5.Name = "ShapeContainer5"
        Me.ShapeContainer5.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.Shape3, Me.Shape4})
        Me.ShapeContainer5.Size = New System.Drawing.Size(819, 169)
        Me.ShapeContainer5.TabIndex = 92
        Me.ShapeContainer5.TabStop = False
        '
        'Shape3
        '
        Me.Shape3.BackColor = System.Drawing.SystemColors.Window
        Me.Shape3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Shape3.FillColor = System.Drawing.Color.Black
        Me.Shape3.Location = New System.Drawing.Point(552, 2)
        Me.Shape3.Name = "Shape3"
        Me.Shape3.Size = New System.Drawing.Size(1, 159)
        '
        'Shape4
        '
        Me.Shape4.BackColor = System.Drawing.SystemColors.Window
        Me.Shape4.BorderColor = System.Drawing.Color.White
        Me.Shape4.FillColor = System.Drawing.Color.Black
        Me.Shape4.Location = New System.Drawing.Point(577, 2)
        Me.Shape4.Name = "Shape4"
        Me.Shape4.Size = New System.Drawing.Size(1, 159)
        '
        'ShapeContainer4
        '
        Me.ShapeContainer4.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer4.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer4.Name = "ShapeContainer4"
        Me.ShapeContainer4.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.Shilu1})
        Me.ShapeContainer4.Size = New System.Drawing.Size(813, 187)
        Me.ShapeContainer4.TabIndex = 3
        Me.ShapeContainer4.TabStop = False
        '
        'Shilu1
        '
        Me.Shilu1.BackColor = System.Drawing.SystemColors.Window
        Me.Shilu1.BorderColor = System.Drawing.Color.Green
        Me.Shilu1.FillColor = System.Drawing.Color.Black
        Me.Shilu1.Location = New System.Drawing.Point(105, 1)
        Me.Shilu1.Name = "Shilu1"
        Me.Shilu1.Size = New System.Drawing.Size(642, 2)
        Me.Shilu1.Visible = False
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.Shilu2})
        Me.ShapeContainer3.Size = New System.Drawing.Size(824, 573)
        Me.ShapeContainer3.TabIndex = 95
        Me.ShapeContainer3.TabStop = False
        '
        'Shilu2
        '
        Me.Shilu2.BackColor = System.Drawing.SystemColors.Window
        Me.Shilu2.BorderColor = System.Drawing.Color.Green
        Me.Shilu2.FillColor = System.Drawing.Color.Black
        Me.Shilu2.Location = New System.Drawing.Point(801, 166)
        Me.Shilu2.Name = "Shilu2"
        Me.Shilu2.Size = New System.Drawing.Size(2, 191)
        Me.Shilu2.Visible = False
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 13)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.Shape8, Me.Shape7})
        Me.ShapeContainer2.Size = New System.Drawing.Size(750, 436)
        Me.ShapeContainer2.TabIndex = 86
        Me.ShapeContainer2.TabStop = False
        '
        'Shape8
        '
        Me.Shape8.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Shape8.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.Shape8.BorderColor = System.Drawing.SystemColors.WindowText
        Me.Shape8.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.Shape8.FillColor = System.Drawing.Color.Black
        Me.Shape8.Location = New System.Drawing.Point(0, -13)
        Me.Shape8.Name = "Shape8"
        Me.Shape8.Size = New System.Drawing.Size(751, 6)
        '
        'Shape7
        '
        Me.Shape7.BackColor = System.Drawing.SystemColors.Window
        Me.Shape7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Shape7.FillColor = System.Drawing.Color.Black
        Me.Shape7.Location = New System.Drawing.Point(671, 410)
        Me.Shape7.Name = "Shape7"
        Me.Shape7.Size = New System.Drawing.Size(73, 19)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 13)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.Shape5, Me.Shape6})
        Me.ShapeContainer1.Size = New System.Drawing.Size(750, 106)
        Me.ShapeContainer1.TabIndex = 89
        Me.ShapeContainer1.TabStop = False
        '
        'Shape5
        '
        Me.Shape5.BackColor = System.Drawing.SystemColors.Window
        Me.Shape5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Shape5.FillColor = System.Drawing.Color.Black
        Me.Shape5.Location = New System.Drawing.Point(4, 47)
        Me.Shape5.Name = "Shape5"
        Me.Shape5.Size = New System.Drawing.Size(742, 1)
        '
        'Shape6
        '
        Me.Shape6.BackColor = System.Drawing.SystemColors.Window
        Me.Shape6.BorderColor = System.Drawing.Color.White
        Me.Shape6.FillColor = System.Drawing.Color.Black
        Me.Shape6.Location = New System.Drawing.Point(4, 48)
        Me.Shape6.Name = "Shape6"
        Me.Shape6.Size = New System.Drawing.Size(742, 1)
        '
        'SSTabMant
        '
        Me.SSTabMant.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.SSTabMant.Controls.Add(Me._SSTabMant_TabPage0)
        Me.SSTabMant.Controls.Add(Me._SSTabMant_TabPage1)
        Me.SSTabMant.ItemSize = New System.Drawing.Size(42, 18)
        Me.SSTabMant.Location = New System.Drawing.Point(4, 4)
        Me.SSTabMant.Name = "SSTabMant"
        Me.SSTabMant.SelectedIndex = 1
        Me.SSTabMant.Size = New System.Drawing.Size(832, 599)
        Me.SSTabMant.TabIndex = 0
        '
        '_SSTabMant_TabPage0
        '
        Me._SSTabMant_TabPage0.Controls.Add(Me.Frame3)
        Me._SSTabMant_TabPage0.Controls.Add(Me.FrameConsulta)
        Me._SSTabMant_TabPage0.Location = New System.Drawing.Point(4, 22)
        Me._SSTabMant_TabPage0.Name = "_SSTabMant_TabPage0"
        Me._SSTabMant_TabPage0.Size = New System.Drawing.Size(824, 573)
        Me._SSTabMant_TabPage0.TabIndex = 0
        Me._SSTabMant_TabPage0.Text = "Consulta"
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Frame3.Controls.Add(Me.DTPFechaContab)
        Me.Frame3.Controls.Add(Me.CtrAyu_SubAsiento)
        Me.Frame3.Controls.Add(Me.CtrAyu_Asiento)
        Me.Frame3.Controls.Add(Me.Label5)
        Me.Frame3.Controls.Add(Me.Image1)
        Me.Frame3.Controls.Add(Me.Label3)
        Me.Frame3.Controls.Add(Me.Label1)
        Me.Frame3.Controls.Add(Me.Label25)
        Me.Frame3.Controls.Add(Me.lbSubAsiento)
        Me.Frame3.Controls.Add(Me.ShapeContainer1)
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(6, 26)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(750, 119)
        Me.Frame3.TabIndex = 54
        Me.Frame3.TabStop = False
        '
        'DTPFechaContab
        '
        Me.DTPFechaContab.Location = New System.Drawing.Point(644, 34)
        Me.DTPFechaContab.Name = "DTPFechaContab"
        Me.DTPFechaContab.OcxState = CType(resources.GetObject("DTPFechaContab.OcxState"), System.Windows.Forms.AxHost.State)
        Me.DTPFechaContab.Size = New System.Drawing.Size(98, 20)
        Me.DTPFechaContab.TabIndex = 87
        '
        'CtrAyu_SubAsiento
        '
        Me.CtrAyu_SubAsiento.Enabled = True
        Me.CtrAyu_SubAsiento.Location = New System.Drawing.Point(335, 90)
        Me.CtrAyu_SubAsiento.Name = "CtrAyu_SubAsiento"
        Me.CtrAyu_SubAsiento.OcxState = CType(resources.GetObject("CtrAyu_SubAsiento.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CtrAyu_SubAsiento.Size = New System.Drawing.Size(409, 21)
        Me.CtrAyu_SubAsiento.TabIndex = 56
        '
        'CtrAyu_Asiento
        '
        Me.CtrAyu_Asiento.Enabled = True
        Me.CtrAyu_Asiento.Location = New System.Drawing.Point(13, 90)
        Me.CtrAyu_Asiento.Name = "CtrAyu_Asiento"
        Me.CtrAyu_Asiento.OcxState = CType(resources.GetObject("CtrAyu_Asiento.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CtrAyu_Asiento.Size = New System.Drawing.Size(299, 20)
        Me.CtrAyu_Asiento.TabIndex = 55
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(502, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(130, 15)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Fecha de Contabilizacion :"
        '
        'Image1
        '
        Me.Image1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Image1.Image = CType(resources.GetObject("Image1.Image"), System.Drawing.Image)
        Me.Image1.Location = New System.Drawing.Point(9, 14)
        Me.Image1.Name = "Image1"
        Me.Image1.Size = New System.Drawing.Size(30, 31)
        Me.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Image1.TabIndex = 88
        Me.Image1.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(46, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(329, 18)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = " Consulta e Ingreso de Comprobantes Contables"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(743, 49)
        Me.Label1.TabIndex = 79
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(13, 76)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label25.Size = New System.Drawing.Size(129, 17)
        Me.Label25.TabIndex = 58
        Me.Label25.Text = "Asiento :"
        '
        'lbSubAsiento
        '
        Me.lbSubAsiento.BackColor = System.Drawing.Color.Transparent
        Me.lbSubAsiento.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbSubAsiento.ForeColor = System.Drawing.Color.Black
        Me.lbSubAsiento.Location = New System.Drawing.Point(335, 76)
        Me.lbSubAsiento.Name = "lbSubAsiento"
        Me.lbSubAsiento.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbSubAsiento.Size = New System.Drawing.Size(106, 13)
        Me.lbSubAsiento.TabIndex = 57
        Me.lbSubAsiento.Text = "Subasiento :"
        '
        'FrameConsulta
        '
        Me.FrameConsulta.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.FrameConsulta.Controls.Add(Me.TxEjecutar)
        Me.FrameConsulta.Controls.Add(Me.ChkTodos)
        Me.FrameConsulta.Controls.Add(Me.Dtc_Campo)
        Me.FrameConsulta.Controls.Add(Me.TDBG_Consulta)
        Me.FrameConsulta.Controls.Add(Me.lbl_nregconsulta)
        Me.FrameConsulta.Controls.Add(Me.Label6)
        Me.FrameConsulta.Controls.Add(Me.Label2)
        Me.FrameConsulta.Controls.Add(Me.Label4)
        Me.FrameConsulta.Controls.Add(Me.ShapeContainer2)
        Me.FrameConsulta.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FrameConsulta.Location = New System.Drawing.Point(6, 144)
        Me.FrameConsulta.Name = "FrameConsulta"
        Me.FrameConsulta.Padding = New System.Windows.Forms.Padding(0)
        Me.FrameConsulta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FrameConsulta.Size = New System.Drawing.Size(750, 449)
        Me.FrameConsulta.TabIndex = 71
        Me.FrameConsulta.TabStop = False
        '
        'TxEjecutar
        '
        Me.TxEjecutar.Enabled = True
        Me.TxEjecutar.Location = New System.Drawing.Point(8, 31)
        Me.TxEjecutar.Name = "TxEjecutar"
        Me.TxEjecutar.OcxState = CType(resources.GetObject("TxEjecutar.OcxState"), System.Windows.Forms.AxHost.State)
        Me.TxEjecutar.Size = New System.Drawing.Size(499, 20)
        Me.TxEjecutar.TabIndex = 85
        '
        'ChkTodos
        '
        Me.ChkTodos.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ChkTodos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkTodos.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkTodos.ForeColor = System.Drawing.Color.White
        Me.ChkTodos.Location = New System.Drawing.Point(510, 32)
        Me.ChkTodos.Name = "ChkTodos"
        Me.ChkTodos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkTodos.Size = New System.Drawing.Size(57, 18)
        Me.ChkTodos.TabIndex = 78
        Me.ChkTodos.Text = "Todos"
        Me.ChkTodos.UseVisualStyleBackColor = False
        '
        'Dtc_Campo
        '
        Me.Dtc_Campo.Location = New System.Drawing.Point(625, 29)
        Me.Dtc_Campo.Name = "Dtc_Campo"
        Me.Dtc_Campo.OcxState = CType(resources.GetObject("Dtc_Campo.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Dtc_Campo.RowSource = Nothing
        Me.Dtc_Campo.Size = New System.Drawing.Size(119, 21)
        Me.Dtc_Campo.TabIndex = 77
        '
        'TDBG_Consulta
        '
        Me.TDBG_Consulta.DataSource = Nothing
        Me.TDBG_Consulta.Location = New System.Drawing.Point(8, 54)
        Me.TDBG_Consulta.Name = "TDBG_Consulta"
        Me.TDBG_Consulta.OcxState = CType(resources.GetObject("TDBG_Consulta.OcxState"), System.Windows.Forms.AxHost.State)
        Me.TDBG_Consulta.Size = New System.Drawing.Size(736, 364)
        Me.TDBG_Consulta.TabIndex = 72
        '
        'lbl_nregconsulta
        '
        Me.lbl_nregconsulta.BackColor = System.Drawing.Color.White
        Me.lbl_nregconsulta.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl_nregconsulta.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_nregconsulta.Location = New System.Drawing.Point(672, 423)
        Me.lbl_nregconsulta.Name = "lbl_nregconsulta"
        Me.lbl_nregconsulta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_nregconsulta.Size = New System.Drawing.Size(72, 19)
        Me.lbl_nregconsulta.TabIndex = 76
        Me.lbl_nregconsulta.Text = "0 "
        Me.lbl_nregconsulta.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(600, 426)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "Nº Registros :"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(8, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(139, 18)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Valor :"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(581, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(38, 14)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Criterio :"
        '
        '_SSTabMant_TabPage1
        '
        Me._SSTabMant_TabPage1.Controls.Add(Me.SSTab2)
        Me._SSTabMant_TabPage1.Controls.Add(Me.StBar)
        Me._SSTabMant_TabPage1.Controls.Add(Me.frameGrid)
        Me._SSTabMant_TabPage1.Controls.Add(Me.FrameCabecera)
        Me._SSTabMant_TabPage1.Controls.Add(Me.FrameIngreso)
        Me._SSTabMant_TabPage1.Controls.Add(Me.ShapeContainer3)
        Me._SSTabMant_TabPage1.Location = New System.Drawing.Point(4, 22)
        Me._SSTabMant_TabPage1.Name = "_SSTabMant_TabPage1"
        Me._SSTabMant_TabPage1.Size = New System.Drawing.Size(824, 573)
        Me._SSTabMant_TabPage1.TabIndex = 1
        Me._SSTabMant_TabPage1.Text = "Mantenimiento"
        '
        'SSTab2
        '
        Me.SSTab2.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.SSTab2.Controls.Add(Me._SSTab2_TabPage0)
        Me.SSTab2.ItemSize = New System.Drawing.Size(42, 18)
        Me.SSTab2.Location = New System.Drawing.Point(8, 357)
        Me.SSTab2.Name = "SSTab2"
        Me.SSTab2.SelectedIndex = 0
        Me.SSTab2.Size = New System.Drawing.Size(821, 213)
        Me.SSTab2.TabIndex = 1
        '
        '_SSTab2_TabPage0
        '
        Me._SSTab2_TabPage0.Controls.Add(Me.FramDetalle)
        Me._SSTab2_TabPage0.Controls.Add(Me.ShapeContainer4)
        Me._SSTab2_TabPage0.Location = New System.Drawing.Point(4, 22)
        Me._SSTab2_TabPage0.Name = "_SSTab2_TabPage0"
        Me._SSTab2_TabPage0.Size = New System.Drawing.Size(813, 187)
        Me._SSTab2_TabPage0.TabIndex = 0
        Me._SSTab2_TabPage0.Text = "&Ingreso del detalle"
        '
        'FramDetalle
        '
        Me.FramDetalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FramDetalle.Controls.Add(Me.CmdDocPend)
        Me.FramDetalle.Controls.Add(Me.ChkInafecto)
        Me.FramDetalle.Controls.Add(Me.TxValor)
        Me.FramDetalle.Controls.Add(Me.ChkAjusta)
        Me.FramDetalle.Controls.Add(Me.TxMonto)
        Me.FramDetalle.Controls.Add(Me.TxNdoc)
        Me.FramDetalle.Controls.Add(Me.TxSerie)
        Me.FramDetalle.Controls.Add(Me.txRuc)
        Me.FramDetalle.Controls.Add(Me.CtrAyu_Moneda)
        Me.FramDetalle.Controls.Add(Me.CtrAyu_TipDoc)
        Me.FramDetalle.Controls.Add(Me.CtrAyu_Analitico)
        Me.FramDetalle.Controls.Add(Me.CtrAyu_TipAnal)
        Me.FramDetalle.Controls.Add(Me.CtrAyu_CCosto)
        Me.FramDetalle.Controls.Add(Me.CtrAyu_Cuenta)
        Me.FramDetalle.Controls.Add(Me.CtrAyu_Opera)
        Me.FramDetalle.Controls.Add(Me.CmbID)
        Me.FramDetalle.Controls.Add(Me.CmbTcambio)
        Me.FramDetalle.Controls.Add(Me.Dtp_FechaDoc)
        Me.FramDetalle.Controls.Add(Me.DtpFech_Ven)
        Me.FramDetalle.Controls.Add(Me.TxGlosa)
        Me.FramDetalle.Controls.Add(Me.CtrAyu_TipRef)
        Me.FramDetalle.Controls.Add(Me.TxNref)
        Me.FramDetalle.Controls.Add(Me.Dtp_FechaDocRef)
        Me.FramDetalle.Controls.Add(Me.lbnref)
        Me.FramDetalle.Controls.Add(Me.lbtipref)
        Me.FramDetalle.Controls.Add(Me.lbconv)
        Me.FramDetalle.Controls.Add(Me.lb_vcambio)
        Me.FramDetalle.Controls.Add(Me._lbTipAnal_0)
        Me.FramDetalle.Controls.Add(Me.lbAnalitico)
        Me.FramDetalle.Controls.Add(Me.Label11)
        Me.FramDetalle.Controls.Add(Me.Label12)
        Me.FramDetalle.Controls.Add(Me.lbccosto)
        Me.FramDetalle.Controls.Add(Me.lbruc)
        Me.FramDetalle.Controls.Add(Me.lbtipdoc)
        Me.FramDetalle.Controls.Add(Me.lbndocum)
        Me.FramDetalle.Controls.Add(Me.lbFechaDoc)
        Me.FramDetalle.Controls.Add(Me.lbFechVen)
        Me.FramDetalle.Controls.Add(Me.Label19)
        Me.FramDetalle.Controls.Add(Me.Label20)
        Me.FramDetalle.Controls.Add(Me.Label21)
        Me.FramDetalle.Controls.Add(Me.Label22)
        Me.FramDetalle.Controls.Add(Me.Label23)
        Me.FramDetalle.Controls.Add(Me.Label24)
        Me.FramDetalle.Controls.Add(Me.ShapeContainer5)
        Me.FramDetalle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FramDetalle.Location = New System.Drawing.Point(5, 23)
        Me.FramDetalle.Name = "FramDetalle"
        Me.FramDetalle.Padding = New System.Windows.Forms.Padding(0)
        Me.FramDetalle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FramDetalle.Size = New System.Drawing.Size(819, 182)
        Me.FramDetalle.TabIndex = 2
        Me.FramDetalle.TabStop = False
        '
        'CmdDocPend
        '
        Me.CmdDocPend.BackColor = System.Drawing.SystemColors.Control
        Me.CmdDocPend.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdDocPend.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdDocPend.Location = New System.Drawing.Point(417, 94)
        Me.CmdDocPend.Name = "CmdDocPend"
        Me.CmdDocPend.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdDocPend.Size = New System.Drawing.Size(22, 20)
        Me.CmdDocPend.TabIndex = 91
        Me.CmdDocPend.Text = "..."
        Me.CmdDocPend.UseVisualStyleBackColor = False
        Me.CmdDocPend.Visible = False
        '
        'ChkInafecto
        '
        Me.ChkInafecto.BackColor = System.Drawing.SystemColors.Control
        Me.ChkInafecto.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkInafecto.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkInafecto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkInafecto.Location = New System.Drawing.Point(444, 138)
        Me.ChkInafecto.Name = "ChkInafecto"
        Me.ChkInafecto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkInafecto.Size = New System.Drawing.Size(60, 17)
        Me.ChkInafecto.TabIndex = 39
        Me.ChkInafecto.Text = "Inafecto"
        Me.ChkInafecto.UseVisualStyleBackColor = False
        '
        'TxValor
        '
        Me.TxValor.Enabled = True
        Me.TxValor.Location = New System.Drawing.Point(657, 152)
        Me.TxValor.Name = "TxValor"
        Me.TxValor.OcxState = CType(resources.GetObject("TxValor.OcxState"), System.Windows.Forms.AxHost.State)
        Me.TxValor.Size = New System.Drawing.Size(147, 22)
        Me.TxValor.TabIndex = 47
        Me.TxValor.Visible = False
        '
        'ChkAjusta
        '
        Me.ChkAjusta.BackColor = System.Drawing.SystemColors.Control
        Me.ChkAjusta.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkAjusta.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkAjusta.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkAjusta.Location = New System.Drawing.Point(656, 137)
        Me.ChkAjusta.Name = "ChkAjusta"
        Me.ChkAjusta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkAjusta.Size = New System.Drawing.Size(147, 14)
        Me.ChkAjusta.TabIndex = 46
        Me.ChkAjusta.Text = "Ajustar por el Usuario"
        Me.ChkAjusta.UseVisualStyleBackColor = False
        '
        'TxMonto
        '
        Me.TxMonto.Enabled = True
        Me.TxMonto.Location = New System.Drawing.Point(656, 104)
        Me.TxMonto.Name = "TxMonto"
        Me.TxMonto.OcxState = CType(resources.GetObject("TxMonto.OcxState"), System.Windows.Forms.AxHost.State)
        Me.TxMonto.Size = New System.Drawing.Size(149, 21)
        Me.TxMonto.TabIndex = 44
        '
        'TxNdoc
        '
        Me.TxNdoc.Enabled = True
        Me.TxNdoc.Location = New System.Drawing.Point(301, 94)
        Me.TxNdoc.Name = "TxNdoc"
        Me.TxNdoc.OcxState = CType(resources.GetObject("TxNdoc.OcxState"), System.Windows.Forms.AxHost.State)
        Me.TxNdoc.Size = New System.Drawing.Size(114, 20)
        Me.TxNdoc.TabIndex = 33
        '
        'TxSerie
        '
        Me.TxSerie.Enabled = True
        Me.TxSerie.Location = New System.Drawing.Point(260, 94)
        Me.TxSerie.Name = "TxSerie"
        Me.TxSerie.OcxState = CType(resources.GetObject("TxSerie.OcxState"), System.Windows.Forms.AxHost.State)
        Me.TxSerie.Size = New System.Drawing.Size(37, 20)
        Me.TxSerie.TabIndex = 32
        '
        'txRuc
        '
        Me.txRuc.Enabled = True
        Me.txRuc.Location = New System.Drawing.Point(388, 73)
        Me.txRuc.Name = "txRuc"
        Me.txRuc.OcxState = CType(resources.GetObject("txRuc.OcxState"), System.Windows.Forms.AxHost.State)
        Me.txRuc.Size = New System.Drawing.Size(116, 21)
        Me.txRuc.TabIndex = 30
        '
        'CtrAyu_Moneda
        '
        Me.CtrAyu_Moneda.Enabled = True
        Me.CtrAyu_Moneda.Location = New System.Drawing.Point(657, 34)
        Me.CtrAyu_Moneda.Name = "CtrAyu_Moneda"
        Me.CtrAyu_Moneda.OcxState = CType(resources.GetObject("CtrAyu_Moneda.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CtrAyu_Moneda.Size = New System.Drawing.Size(146, 21)
        Me.CtrAyu_Moneda.TabIndex = 42
        '
        'CtrAyu_TipDoc
        '
        Me.CtrAyu_TipDoc.Enabled = True
        Me.CtrAyu_TipDoc.Location = New System.Drawing.Point(75, 93)
        Me.CtrAyu_TipDoc.Name = "CtrAyu_TipDoc"
        Me.CtrAyu_TipDoc.OcxState = CType(resources.GetObject("CtrAyu_TipDoc.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CtrAyu_TipDoc.Size = New System.Drawing.Size(138, 21)
        Me.CtrAyu_TipDoc.TabIndex = 31
        '
        'CtrAyu_Analitico
        '
        Me.CtrAyu_Analitico.Enabled = True
        Me.CtrAyu_Analitico.Location = New System.Drawing.Point(75, 73)
        Me.CtrAyu_Analitico.Name = "CtrAyu_Analitico"
        Me.CtrAyu_Analitico.OcxState = CType(resources.GetObject("CtrAyu_Analitico.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CtrAyu_Analitico.Size = New System.Drawing.Size(271, 20)
        Me.CtrAyu_Analitico.TabIndex = 29
        '
        'CtrAyu_TipAnal
        '
        Me.CtrAyu_TipAnal.Enabled = True
        Me.CtrAyu_TipAnal.Location = New System.Drawing.Point(345, 53)
        Me.CtrAyu_TipAnal.Name = "CtrAyu_TipAnal"
        Me.CtrAyu_TipAnal.OcxState = CType(resources.GetObject("CtrAyu_TipAnal.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CtrAyu_TipAnal.Size = New System.Drawing.Size(160, 21)
        Me.CtrAyu_TipAnal.TabIndex = 28
        '
        'CtrAyu_CCosto
        '
        Me.CtrAyu_CCosto.Enabled = True
        Me.CtrAyu_CCosto.Location = New System.Drawing.Point(75, 53)
        Me.CtrAyu_CCosto.Name = "CtrAyu_CCosto"
        Me.CtrAyu_CCosto.OcxState = CType(resources.GetObject("CtrAyu_CCosto.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CtrAyu_CCosto.Size = New System.Drawing.Size(189, 22)
        Me.CtrAyu_CCosto.TabIndex = 27
        '
        'CtrAyu_Cuenta
        '
        Me.CtrAyu_Cuenta.Enabled = True
        Me.CtrAyu_Cuenta.Location = New System.Drawing.Point(75, 33)
        Me.CtrAyu_Cuenta.Name = "CtrAyu_Cuenta"
        Me.CtrAyu_Cuenta.OcxState = CType(resources.GetObject("CtrAyu_Cuenta.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CtrAyu_Cuenta.Size = New System.Drawing.Size(430, 21)
        Me.CtrAyu_Cuenta.TabIndex = 26
        '
        'CtrAyu_Opera
        '
        Me.CtrAyu_Opera.Enabled = True
        Me.CtrAyu_Opera.Location = New System.Drawing.Point(75, 12)
        Me.CtrAyu_Opera.Name = "CtrAyu_Opera"
        Me.CtrAyu_Opera.OcxState = CType(resources.GetObject("CtrAyu_Opera.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CtrAyu_Opera.Size = New System.Drawing.Size(431, 21)
        Me.CtrAyu_Opera.TabIndex = 25
        '
        'CmbID
        '
        Me.CmbID.BackColor = System.Drawing.SystemColors.Window
        Me.CmbID.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmbID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CmbID.Items.AddRange(New Object() {"D - Debe", "H - Haber"})
        Me.CmbID.Location = New System.Drawing.Point(656, 13)
        Me.CmbID.Name = "CmbID"
        Me.CmbID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmbID.Size = New System.Drawing.Size(148, 21)
        Me.CmbID.TabIndex = 41
        '
        'CmbTcambio
        '
        Me.CmbTcambio.BackColor = System.Drawing.SystemColors.Window
        Me.CmbTcambio.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmbTcambio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTcambio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CmbTcambio.Items.AddRange(New Object() {"01 - Compra", "02 - Venta", "03 - Promedio"})
        Me.CmbTcambio.Location = New System.Drawing.Point(657, 57)
        Me.CmbTcambio.Name = "CmbTcambio"
        Me.CmbTcambio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmbTcambio.Size = New System.Drawing.Size(148, 21)
        Me.CmbTcambio.TabIndex = 43
        '
        'Dtp_FechaDoc
        '
        Me.Dtp_FechaDoc.Location = New System.Drawing.Point(76, 135)
        Me.Dtp_FechaDoc.Name = "Dtp_FechaDoc"
        Me.Dtp_FechaDoc.OcxState = CType(resources.GetObject("Dtp_FechaDoc.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Dtp_FechaDoc.Size = New System.Drawing.Size(86, 21)
        Me.Dtp_FechaDoc.TabIndex = 37
        '
        'DtpFech_Ven
        '
        Me.DtpFech_Ven.Location = New System.Drawing.Point(253, 136)
        Me.DtpFech_Ven.Name = "DtpFech_Ven"
        Me.DtpFech_Ven.OcxState = CType(resources.GetObject("DtpFech_Ven.OcxState"), System.Windows.Forms.AxHost.State)
        Me.DtpFech_Ven.Size = New System.Drawing.Size(112, 21)
        Me.DtpFech_Ven.TabIndex = 38
        '
        'TxGlosa
        '
        Me.TxGlosa.Enabled = True
        Me.TxGlosa.Location = New System.Drawing.Point(75, 157)
        Me.TxGlosa.Name = "TxGlosa"
        Me.TxGlosa.OcxState = CType(resources.GetObject("TxGlosa.OcxState"), System.Windows.Forms.AxHost.State)
        Me.TxGlosa.Size = New System.Drawing.Size(429, 20)
        Me.TxGlosa.TabIndex = 40
        '
        'CtrAyu_TipRef
        '
        Me.CtrAyu_TipRef.Enabled = True
        Me.CtrAyu_TipRef.Location = New System.Drawing.Point(75, 113)
        Me.CtrAyu_TipRef.Name = "CtrAyu_TipRef"
        Me.CtrAyu_TipRef.OcxState = CType(resources.GetObject("CtrAyu_TipRef.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CtrAyu_TipRef.Size = New System.Drawing.Size(138, 21)
        Me.CtrAyu_TipRef.TabIndex = 34
        '
        'TxNref
        '
        Me.TxNref.Enabled = True
        Me.TxNref.Location = New System.Drawing.Point(259, 113)
        Me.TxNref.Name = "TxNref"
        Me.TxNref.OcxState = CType(resources.GetObject("TxNref.OcxState"), System.Windows.Forms.AxHost.State)
        Me.TxNref.Size = New System.Drawing.Size(137, 20)
        Me.TxNref.TabIndex = 35
        '
        'Dtp_FechaDocRef
        '
        Me.Dtp_FechaDocRef.Location = New System.Drawing.Point(405, 115)
        Me.Dtp_FechaDocRef.Name = "Dtp_FechaDocRef"
        Me.Dtp_FechaDocRef.OcxState = CType(resources.GetObject("Dtp_FechaDocRef.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Dtp_FechaDocRef.Size = New System.Drawing.Size(100, 19)
        Me.Dtp_FechaDocRef.TabIndex = 36
        '
        'lbnref
        '
        Me.lbnref.AutoSize = True
        Me.lbnref.BackColor = System.Drawing.SystemColors.Control
        Me.lbnref.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbnref.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbnref.Location = New System.Drawing.Point(216, 117)
        Me.lbnref.Name = "lbnref"
        Me.lbnref.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbnref.Size = New System.Drawing.Size(31, 13)
        Me.lbnref.TabIndex = 89
        Me.lbnref.Text = "Nº . :"
        '
        'lbtipref
        '
        Me.lbtipref.BackColor = System.Drawing.SystemColors.Control
        Me.lbtipref.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbtipref.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbtipref.Location = New System.Drawing.Point(8, 116)
        Me.lbtipref.Name = "lbtipref"
        Me.lbtipref.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbtipref.Size = New System.Drawing.Size(68, 17)
        Me.lbtipref.TabIndex = 88
        Me.lbtipref.Text = "T.D. Ref. :"
        '
        'lbconv
        '
        Me.lbconv.BackColor = System.Drawing.SystemColors.Control
        Me.lbconv.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbconv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbconv.Location = New System.Drawing.Point(591, 157)
        Me.lbconv.Name = "lbconv"
        Me.lbconv.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbconv.Size = New System.Drawing.Size(66, 16)
        Me.lbconv.TabIndex = 84
        Me.lbconv.Text = "Conversión :"
        Me.lbconv.Visible = False
        '
        'lb_vcambio
        '
        Me.lb_vcambio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.lb_vcambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_vcambio.Cursor = System.Windows.Forms.Cursors.Default
        Me.lb_vcambio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lb_vcambio.Location = New System.Drawing.Point(657, 82)
        Me.lb_vcambio.Name = "lb_vcambio"
        Me.lb_vcambio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lb_vcambio.Size = New System.Drawing.Size(148, 18)
        Me.lb_vcambio.TabIndex = 70
        Me.lb_vcambio.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lbTipAnal_0
        '
        Me._lbTipAnal_0.AutoSize = True
        Me._lbTipAnal_0.BackColor = System.Drawing.SystemColors.Control
        Me._lbTipAnal_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbTipAnal_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbTipAnal.SetIndex(Me._lbTipAnal_0, CType(0, Short))
        Me._lbTipAnal_0.Location = New System.Drawing.Point(268, 58)
        Me._lbTipAnal_0.Name = "_lbTipAnal_0"
        Me._lbTipAnal_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbTipAnal_0.Size = New System.Drawing.Size(77, 13)
        Me._lbTipAnal_0.TabIndex = 19
        Me._lbTipAnal_0.Text = "Tipo Analitico :"
        '
        'lbAnalitico
        '
        Me.lbAnalitico.AutoSize = True
        Me.lbAnalitico.BackColor = System.Drawing.SystemColors.Control
        Me.lbAnalitico.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbAnalitico.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbAnalitico.Location = New System.Drawing.Point(8, 78)
        Me.lbAnalitico.Name = "lbAnalitico"
        Me.lbAnalitico.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbAnalitico.Size = New System.Drawing.Size(53, 13)
        Me.lbAnalitico.TabIndex = 17
        Me.lbAnalitico.Text = "Analitico :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(8, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Cod Oper. :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(8, 37)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(47, 13)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Cuenta :"
        '
        'lbccosto
        '
        Me.lbccosto.AutoSize = True
        Me.lbccosto.BackColor = System.Drawing.SystemColors.Control
        Me.lbccosto.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbccosto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbccosto.Location = New System.Drawing.Point(8, 57)
        Me.lbccosto.Name = "lbccosto"
        Me.lbccosto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbccosto.Size = New System.Drawing.Size(50, 13)
        Me.lbccosto.TabIndex = 14
        Me.lbccosto.Text = "C.Costo :"
        '
        'lbruc
        '
        Me.lbruc.AutoSize = True
        Me.lbruc.BackColor = System.Drawing.SystemColors.Control
        Me.lbruc.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbruc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbruc.Location = New System.Drawing.Point(349, 78)
        Me.lbruc.Name = "lbruc"
        Me.lbruc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbruc.Size = New System.Drawing.Size(45, 13)
        Me.lbruc.TabIndex = 13
        Me.lbruc.Text = "R.U.C. :"
        '
        'lbtipdoc
        '
        Me.lbtipdoc.BackColor = System.Drawing.SystemColors.Control
        Me.lbtipdoc.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbtipdoc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbtipdoc.Location = New System.Drawing.Point(8, 96)
        Me.lbtipdoc.Name = "lbtipdoc"
        Me.lbtipdoc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbtipdoc.Size = New System.Drawing.Size(68, 17)
        Me.lbtipdoc.TabIndex = 12
        Me.lbtipdoc.Text = "Tipo doc. :"
        '
        'lbndocum
        '
        Me.lbndocum.AutoSize = True
        Me.lbndocum.BackColor = System.Drawing.SystemColors.Control
        Me.lbndocum.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbndocum.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbndocum.Location = New System.Drawing.Point(216, 97)
        Me.lbndocum.Name = "lbndocum"
        Me.lbndocum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbndocum.Size = New System.Drawing.Size(49, 13)
        Me.lbndocum.TabIndex = 11
        Me.lbndocum.Text = "Nº doc. :"
        '
        'lbFechaDoc
        '
        Me.lbFechaDoc.AutoSize = True
        Me.lbFechaDoc.BackColor = System.Drawing.SystemColors.Control
        Me.lbFechaDoc.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbFechaDoc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbFechaDoc.Location = New System.Drawing.Point(8, 141)
        Me.lbFechaDoc.Name = "lbFechaDoc"
        Me.lbFechaDoc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbFechaDoc.Size = New System.Drawing.Size(67, 13)
        Me.lbFechaDoc.TabIndex = 10
        Me.lbFechaDoc.Text = "Fecha doc. :"
        '
        'lbFechVen
        '
        Me.lbFechVen.AutoSize = True
        Me.lbFechVen.BackColor = System.Drawing.SystemColors.Control
        Me.lbFechVen.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbFechVen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbFechVen.Location = New System.Drawing.Point(167, 140)
        Me.lbFechVen.Name = "lbFechVen"
        Me.lbFechVen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbFechVen.Size = New System.Drawing.Size(89, 13)
        Me.lbFechVen.TabIndex = 9
        Me.lbFechVen.Text = "Fecha de Venc. :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.SystemColors.Control
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(590, 15)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label19.Size = New System.Drawing.Size(57, 13)
        Me.Label19.TabIndex = 8
        Me.Label19.Text = "Indicador :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.SystemColors.Control
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(590, 62)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(60, 13)
        Me.Label20.TabIndex = 7
        Me.Label20.Text = "T/Cambio :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(592, 85)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(60, 13)
        Me.Label21.TabIndex = 6
        Me.Label21.Text = "V/Cambio :"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.SystemColors.Control
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(591, 107)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(43, 13)
        Me.Label22.TabIndex = 5
        Me.Label22.Text = "Monto :"
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.SystemColors.Control
        Me.Label23.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(8, 160)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label23.Size = New System.Drawing.Size(33, 13)
        Me.Label23.TabIndex = 4
        Me.Label23.Text = "Glosa :"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.SystemColors.Control
        Me.Label24.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(592, 41)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24.Size = New System.Drawing.Size(52, 13)
        Me.Label24.TabIndex = 3
        Me.Label24.Text = "Moneda :"
        '
        'StBar
        '
        Me.StBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._StBar_Panel1, Me._StBar_Panel2, Me._StBar_Panel3, Me._StBar_Panel4})
        Me.StBar.Location = New System.Drawing.Point(0, 551)
        Me.StBar.Name = "StBar"
        Me.StBar.Size = New System.Drawing.Size(824, 22)
        Me.StBar.TabIndex = 53
        '
        '_StBar_Panel1
        '
        Me._StBar_Panel1.AutoSize = False
        Me._StBar_Panel1.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me._StBar_Panel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me._StBar_Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me._StBar_Panel1.Name = "_StBar_Panel1"
        Me._StBar_Panel1.Size = New System.Drawing.Size(204, 22)
        Me._StBar_Panel1.Text = "Asiento : "
        Me._StBar_Panel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '_StBar_Panel2
        '
        Me._StBar_Panel2.AutoSize = False
        Me._StBar_Panel2.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me._StBar_Panel2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me._StBar_Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me._StBar_Panel2.Name = "_StBar_Panel2"
        Me._StBar_Panel2.Size = New System.Drawing.Size(297, 22)
        Me._StBar_Panel2.Text = "Sub Asiento :"
        Me._StBar_Panel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '_StBar_Panel3
        '
        Me._StBar_Panel3.AutoSize = False
        Me._StBar_Panel3.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me._StBar_Panel3.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me._StBar_Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me._StBar_Panel3.Name = "_StBar_Panel3"
        Me._StBar_Panel3.Size = New System.Drawing.Size(96, 22)
        Me._StBar_Panel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '_StBar_Panel4
        '
        Me._StBar_Panel4.AutoSize = False
        Me._StBar_Panel4.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me._StBar_Panel4.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me._StBar_Panel4.Image = CType(resources.GetObject("_StBar_Panel4.Image"), System.Drawing.Image)
        Me._StBar_Panel4.Margin = New System.Windows.Forms.Padding(0)
        Me._StBar_Panel4.Name = "_StBar_Panel4"
        Me._StBar_Panel4.Size = New System.Drawing.Size(212, 22)
        Me._StBar_Panel4.Spring = True
        Me._StBar_Panel4.Text = "Estado :"
        Me._StBar_Panel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me._StBar_Panel4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'frameGrid
        '
        Me.frameGrid.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.frameGrid.Controls.Add(Me.TDBG_Det)
        Me.frameGrid.Controls.Add(Me.Label7)
        Me.frameGrid.Controls.Add(Me.lbnregdetalle)
        Me.frameGrid.Controls.Add(Me.ShapeContainer6)
        Me.frameGrid.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frameGrid.Location = New System.Drawing.Point(8, 160)
        Me.frameGrid.Name = "frameGrid"
        Me.frameGrid.Padding = New System.Windows.Forms.Padding(0)
        Me.frameGrid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frameGrid.Size = New System.Drawing.Size(817, 195)
        Me.frameGrid.TabIndex = 81
        Me.frameGrid.TabStop = False
        '
        'TDBG_Det
        '
        Me.TDBG_Det.DataSource = Nothing
        Me.TDBG_Det.Location = New System.Drawing.Point(5, 12)
        Me.TDBG_Det.Name = "TDBG_Det"
        Me.TDBG_Det.OcxState = CType(resources.GetObject("TDBG_Det.OcxState"), System.Windows.Forms.AxHost.State)
        Me.TDBG_Det.Size = New System.Drawing.Size(808, 152)
        Me.TDBG_Det.TabIndex = 45
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(596, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 83
        Me.Label7.Text = "Nº Registros :"
        '
        'lbnregdetalle
        '
        Me.lbnregdetalle.BackColor = System.Drawing.Color.White
        Me.lbnregdetalle.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbnregdetalle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbnregdetalle.Location = New System.Drawing.Point(733, 173)
        Me.lbnregdetalle.Name = "lbnregdetalle"
        Me.lbnregdetalle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbnregdetalle.Size = New System.Drawing.Size(70, 17)
        Me.lbnregdetalle.TabIndex = 82
        Me.lbnregdetalle.Text = "0 "
        Me.lbnregdetalle.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FrameCabecera
        '
        Me.FrameCabecera.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FrameCabecera.Controls.Add(Me.ChkGrabado)
        Me.FrameCabecera.Controls.Add(Me.DTPFechaComprobCab)
        Me.FrameCabecera.Controls.Add(Me.TxGlosaComprobCab)
        Me.FrameCabecera.Controls.Add(Me.TxObsComprobCab)
        Me.FrameCabecera.Controls.Add(Me.TxCtrNref)
        Me.FrameCabecera.Controls.Add(Me.lbNumComprobCablibro)
        Me.FrameCabecera.Controls.Add(Me._leNComprob_0)
        Me.FrameCabecera.Controls.Add(Me.lbnemoref)
        Me.FrameCabecera.Controls.Add(Me.leDebe)
        Me.FrameCabecera.Controls.Add(Me.leHaber)
        Me.FrameCabecera.Controls.Add(Me.leSoles)
        Me.FrameCabecera.Controls.Add(Me.LeDolares)
        Me.FrameCabecera.Controls.Add(Me._LbTotales_0)
        Me.FrameCabecera.Controls.Add(Me._LbTotales_1)
        Me.FrameCabecera.Controls.Add(Me._LbTotales_3)
        Me.FrameCabecera.Controls.Add(Me._LbTotales_4)
        Me.FrameCabecera.Controls.Add(Me.leDifer)
        Me.FrameCabecera.Controls.Add(Me._LbTotales_2)
        Me.FrameCabecera.Controls.Add(Me._LbTotales_5)
        Me.FrameCabecera.Controls.Add(Me._leNComprob_1)
        Me.FrameCabecera.Controls.Add(Me.lbNumComprobCab)
        Me.FrameCabecera.Controls.Add(Me._leFechaComprob_7)
        Me.FrameCabecera.Controls.Add(Me.leGlosa)
        Me.FrameCabecera.Controls.Add(Me.leObservaciones)
        Me.FrameCabecera.Controls.Add(Me.ShapeContainer7)
        Me.FrameCabecera.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FrameCabecera.Location = New System.Drawing.Point(7, 21)
        Me.FrameCabecera.Name = "FrameCabecera"
        Me.FrameCabecera.Padding = New System.Windows.Forms.Padding(0)
        Me.FrameCabecera.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FrameCabecera.Size = New System.Drawing.Size(817, 140)
        Me.FrameCabecera.TabIndex = 24
        Me.FrameCabecera.TabStop = False
        '
        'ChkGrabado
        '
        Me.ChkGrabado.BackColor = System.Drawing.SystemColors.Control
        Me.ChkGrabado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkGrabado.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkGrabado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ChkGrabado.Location = New System.Drawing.Point(10, 116)
        Me.ChkGrabado.Name = "ChkGrabado"
        Me.ChkGrabado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkGrabado.Size = New System.Drawing.Size(114, 15)
        Me.ChkGrabado.TabIndex = 22
        Me.ChkGrabado.Text = "Oper. Grabada"
        Me.ChkGrabado.UseVisualStyleBackColor = False
        '
        'DTPFechaComprobCab
        '
        Me.DTPFechaComprobCab.Location = New System.Drawing.Point(111, 36)
        Me.DTPFechaComprobCab.Name = "DTPFechaComprobCab"
        Me.DTPFechaComprobCab.OcxState = CType(resources.GetObject("DTPFechaComprobCab.OcxState"), System.Windows.Forms.AxHost.State)
        Me.DTPFechaComprobCab.Size = New System.Drawing.Size(102, 20)
        Me.DTPFechaComprobCab.TabIndex = 18
        '
        'TxGlosaComprobCab
        '
        Me.TxGlosaComprobCab.Enabled = True
        Me.TxGlosaComprobCab.Location = New System.Drawing.Point(110, 57)
        Me.TxGlosaComprobCab.Name = "TxGlosaComprobCab"
        Me.TxGlosaComprobCab.OcxState = CType(resources.GetObject("TxGlosaComprobCab.OcxState"), System.Windows.Forms.AxHost.State)
        Me.TxGlosaComprobCab.Size = New System.Drawing.Size(307, 20)
        Me.TxGlosaComprobCab.TabIndex = 20
        '
        'TxObsComprobCab
        '
        Me.TxObsComprobCab.Enabled = True
        Me.TxObsComprobCab.Location = New System.Drawing.Point(110, 78)
        Me.TxObsComprobCab.Name = "TxObsComprobCab"
        Me.TxObsComprobCab.OcxState = CType(resources.GetObject("TxObsComprobCab.OcxState"), System.Windows.Forms.AxHost.State)
        Me.TxObsComprobCab.Size = New System.Drawing.Size(307, 36)
        Me.TxObsComprobCab.TabIndex = 21
        '
        'TxCtrNref
        '
        Me.TxCtrNref.Enabled = True
        Me.TxCtrNref.Location = New System.Drawing.Point(283, 115)
        Me.TxCtrNref.Name = "TxCtrNref"
        Me.TxCtrNref.OcxState = CType(resources.GetObject("TxCtrNref.OcxState"), System.Windows.Forms.AxHost.State)
        Me.TxCtrNref.Size = New System.Drawing.Size(134, 20)
        Me.TxCtrNref.TabIndex = 23
        '
        'lbNumComprobCablibro
        '
        Me.lbNumComprobCablibro.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.lbNumComprobCablibro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbNumComprobCablibro.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbNumComprobCablibro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbNumComprobCablibro.Location = New System.Drawing.Point(318, 16)
        Me.lbNumComprobCablibro.Name = "lbNumComprobCablibro"
        Me.lbNumComprobCablibro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbNumComprobCablibro.Size = New System.Drawing.Size(101, 19)
        Me.lbNumComprobCablibro.TabIndex = 93
        Me.lbNumComprobCablibro.Text = "000001"
        Me.lbNumComprobCablibro.Visible = False
        '
        '_leNComprob_0
        '
        Me._leNComprob_0.AutoSize = True
        Me._leNComprob_0.BackColor = System.Drawing.SystemColors.Control
        Me._leNComprob_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._leNComprob_0.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.leNComprob.SetIndex(Me._leNComprob_0, CType(0, Short))
        Me._leNComprob_0.Location = New System.Drawing.Point(223, 19)
        Me._leNComprob_0.Name = "_leNComprob_0"
        Me._leNComprob_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._leNComprob_0.Size = New System.Drawing.Size(87, 13)
        Me._leNComprob_0.TabIndex = 92
        Me._leNComprob_0.Text = "Nº. Comp. Libro :"
        Me._leNComprob_0.Visible = False
        '
        'lbnemoref
        '
        Me.lbnemoref.AutoSize = True
        Me.lbnemoref.BackColor = System.Drawing.SystemColors.Control
        Me.lbnemoref.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbnemoref.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbnemoref.Location = New System.Drawing.Point(133, 117)
        Me.lbnemoref.Name = "lbnemoref"
        Me.lbnemoref.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbnemoref.Size = New System.Drawing.Size(73, 13)
        Me.lbnemoref.TabIndex = 90
        Me.lbnemoref.Text = "Nemotecnico "
        Me.lbnemoref.Visible = False
        '
        'leDebe
        '
        Me.leDebe.AutoSize = True
        Me.leDebe.BackColor = System.Drawing.SystemColors.Control
        Me.leDebe.Cursor = System.Windows.Forms.Cursors.Default
        Me.leDebe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.leDebe.Location = New System.Drawing.Point(444, 50)
        Me.leDebe.Name = "leDebe"
        Me.leDebe.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.leDebe.Size = New System.Drawing.Size(36, 13)
        Me.leDebe.TabIndex = 69
        Me.leDebe.Text = "DEBE"
        '
        'leHaber
        '
        Me.leHaber.AutoSize = True
        Me.leHaber.BackColor = System.Drawing.SystemColors.Control
        Me.leHaber.Cursor = System.Windows.Forms.Cursors.Default
        Me.leHaber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.leHaber.Location = New System.Drawing.Point(444, 70)
        Me.leHaber.Name = "leHaber"
        Me.leHaber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.leHaber.Size = New System.Drawing.Size(44, 13)
        Me.leHaber.TabIndex = 68
        Me.leHaber.Text = "HABER"
        '
        'leSoles
        '
        Me.leSoles.AutoSize = True
        Me.leSoles.BackColor = System.Drawing.SystemColors.Control
        Me.leSoles.Cursor = System.Windows.Forms.Cursors.Default
        Me.leSoles.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.leSoles.Location = New System.Drawing.Point(518, 24)
        Me.leSoles.Name = "leSoles"
        Me.leSoles.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.leSoles.Size = New System.Drawing.Size(60, 13)
        Me.leSoles.TabIndex = 67
        Me.leSoles.Text = "SOLES S/."
        '
        'LeDolares
        '
        Me.LeDolares.AutoSize = True
        Me.LeDolares.BackColor = System.Drawing.SystemColors.Control
        Me.LeDolares.Cursor = System.Windows.Forms.Cursors.Default
        Me.LeDolares.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LeDolares.Location = New System.Drawing.Point(630, 24)
        Me.LeDolares.Name = "LeDolares"
        Me.LeDolares.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LeDolares.Size = New System.Drawing.Size(82, 13)
        Me.LeDolares.TabIndex = 66
        Me.LeDolares.Text = "DOLARES US$"
        '
        '_LbTotales_0
        '
        Me._LbTotales_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(251, Byte), Integer))
        Me._LbTotales_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._LbTotales_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTotales_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LbTotales.SetIndex(Me._LbTotales_0, CType(0, Short))
        Me._LbTotales_0.Location = New System.Drawing.Point(502, 47)
        Me._LbTotales_0.Name = "_LbTotales_0"
        Me._LbTotales_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._LbTotales_0.Size = New System.Drawing.Size(109, 18)
        Me._LbTotales_0.TabIndex = 65
        Me._LbTotales_0.Text = "0.00 "
        Me._LbTotales_0.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_LbTotales_1
        '
        Me._LbTotales_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(251, Byte), Integer))
        Me._LbTotales_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._LbTotales_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTotales_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LbTotales.SetIndex(Me._LbTotales_1, CType(1, Short))
        Me._LbTotales_1.Location = New System.Drawing.Point(502, 67)
        Me._LbTotales_1.Name = "_LbTotales_1"
        Me._LbTotales_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._LbTotales_1.Size = New System.Drawing.Size(109, 18)
        Me._LbTotales_1.TabIndex = 64
        Me._LbTotales_1.Text = "0.00 "
        Me._LbTotales_1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_LbTotales_3
        '
        Me._LbTotales_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(231, Byte), Integer))
        Me._LbTotales_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._LbTotales_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTotales_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LbTotales.SetIndex(Me._LbTotales_3, CType(3, Short))
        Me._LbTotales_3.Location = New System.Drawing.Point(621, 46)
        Me._LbTotales_3.Name = "_LbTotales_3"
        Me._LbTotales_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._LbTotales_3.Size = New System.Drawing.Size(109, 18)
        Me._LbTotales_3.TabIndex = 63
        Me._LbTotales_3.Text = "0.00 "
        Me._LbTotales_3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_LbTotales_4
        '
        Me._LbTotales_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(231, Byte), Integer))
        Me._LbTotales_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._LbTotales_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTotales_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LbTotales.SetIndex(Me._LbTotales_4, CType(4, Short))
        Me._LbTotales_4.Location = New System.Drawing.Point(620, 67)
        Me._LbTotales_4.Name = "_LbTotales_4"
        Me._LbTotales_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._LbTotales_4.Size = New System.Drawing.Size(109, 18)
        Me._LbTotales_4.TabIndex = 62
        Me._LbTotales_4.Text = "0.00 "
        Me._LbTotales_4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'leDifer
        '
        Me.leDifer.AutoSize = True
        Me.leDifer.BackColor = System.Drawing.SystemColors.Control
        Me.leDifer.Cursor = System.Windows.Forms.Cursors.Default
        Me.leDifer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.leDifer.Location = New System.Drawing.Point(445, 104)
        Me.leDifer.Name = "leDifer"
        Me.leDifer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.leDifer.Size = New System.Drawing.Size(42, 13)
        Me.leDifer.TabIndex = 61
        Me.leDifer.Text = "DIFER."
        '
        '_LbTotales_2
        '
        Me._LbTotales_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(242, Byte), Integer))
        Me._LbTotales_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._LbTotales_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTotales_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LbTotales.SetIndex(Me._LbTotales_2, CType(2, Short))
        Me._LbTotales_2.Location = New System.Drawing.Point(502, 101)
        Me._LbTotales_2.Name = "_LbTotales_2"
        Me._LbTotales_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._LbTotales_2.Size = New System.Drawing.Size(109, 18)
        Me._LbTotales_2.TabIndex = 60
        Me._LbTotales_2.Text = "0.00 "
        Me._LbTotales_2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_LbTotales_5
        '
        Me._LbTotales_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(242, Byte), Integer))
        Me._LbTotales_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._LbTotales_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._LbTotales_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LbTotales.SetIndex(Me._LbTotales_5, CType(5, Short))
        Me._LbTotales_5.Location = New System.Drawing.Point(621, 101)
        Me._LbTotales_5.Name = "_LbTotales_5"
        Me._LbTotales_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._LbTotales_5.Size = New System.Drawing.Size(109, 18)
        Me._LbTotales_5.TabIndex = 59
        Me._LbTotales_5.Text = "0.00 "
        Me._LbTotales_5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_leNComprob_1
        '
        Me._leNComprob_1.AutoSize = True
        Me._leNComprob_1.BackColor = System.Drawing.SystemColors.Control
        Me._leNComprob_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._leNComprob_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.leNComprob.SetIndex(Me._leNComprob_1, CType(1, Short))
        Me._leNComprob_1.Location = New System.Drawing.Point(11, 15)
        Me._leNComprob_1.Name = "_leNComprob_1"
        Me._leNComprob_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._leNComprob_1.Size = New System.Drawing.Size(94, 13)
        Me._leNComprob_1.TabIndex = 52
        Me._leNComprob_1.Text = "Nº. Comprobante :"
        '
        'lbNumComprobCab
        '
        Me.lbNumComprobCab.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.lbNumComprobCab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbNumComprobCab.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbNumComprobCab.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbNumComprobCab.Location = New System.Drawing.Point(111, 15)
        Me.lbNumComprobCab.Name = "lbNumComprobCab"
        Me.lbNumComprobCab.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbNumComprobCab.Size = New System.Drawing.Size(101, 19)
        Me.lbNumComprobCab.TabIndex = 51
        Me.lbNumComprobCab.Text = "0000010000"
        '
        '_leFechaComprob_7
        '
        Me._leFechaComprob_7.AutoSize = True
        Me._leFechaComprob_7.BackColor = System.Drawing.SystemColors.Control
        Me._leFechaComprob_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._leFechaComprob_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.leFechaComprob.SetIndex(Me._leFechaComprob_7, CType(7, Short))
        Me._leFechaComprob_7.Location = New System.Drawing.Point(11, 37)
        Me._leFechaComprob_7.Name = "_leFechaComprob_7"
        Me._leFechaComprob_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._leFechaComprob_7.Size = New System.Drawing.Size(91, 13)
        Me._leFechaComprob_7.TabIndex = 50
        Me._leFechaComprob_7.Text = "Fecha Comprob. :"
        Me._leFechaComprob_7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'leGlosa
        '
        Me.leGlosa.BackColor = System.Drawing.SystemColors.Control
        Me.leGlosa.Cursor = System.Windows.Forms.Cursors.Default
        Me.leGlosa.ForeColor = System.Drawing.SystemColors.ControlText
        Me.leGlosa.Location = New System.Drawing.Point(11, 60)
        Me.leGlosa.Name = "leGlosa"
        Me.leGlosa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.leGlosa.Size = New System.Drawing.Size(95, 23)
        Me.leGlosa.TabIndex = 49
        Me.leGlosa.Text = "Glosa Comprob. :"
        '
        'leObservaciones
        '
        Me.leObservaciones.AutoSize = True
        Me.leObservaciones.BackColor = System.Drawing.SystemColors.Control
        Me.leObservaciones.Cursor = System.Windows.Forms.Cursors.Default
        Me.leObservaciones.ForeColor = System.Drawing.SystemColors.ControlText
        Me.leObservaciones.Location = New System.Drawing.Point(11, 87)
        Me.leObservaciones.Name = "leObservaciones"
        Me.leObservaciones.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.leObservaciones.Size = New System.Drawing.Size(84, 13)
        Me.leObservaciones.TabIndex = 48
        Me.leObservaciones.Text = "Observaciones :"
        '
        'FrameIngreso
        '
        Me.FrameIngreso.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FrameIngreso.Controls.Add(Me.FrameCcosto)
        Me.FrameIngreso.Controls.Add(Me.Frame5)
        Me.FrameIngreso.Controls.Add(Me.Frame1)
        Me.FrameIngreso.Controls.Add(Me.Frame4)
        Me.FrameIngreso.Controls.Add(Me.Frame2)
        Me.FrameIngreso.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FrameIngreso.Location = New System.Drawing.Point(8, 360)
        Me.FrameIngreso.Name = "FrameIngreso"
        Me.FrameIngreso.Padding = New System.Windows.Forms.Padding(0)
        Me.FrameIngreso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FrameIngreso.Size = New System.Drawing.Size(817, 209)
        Me.FrameIngreso.TabIndex = 94
        Me.FrameIngreso.TabStop = False
        '
        'FrameCcosto
        '
        Me.FrameCcosto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FrameCcosto.Controls.Add(Me.TDBGrid1)
        Me.FrameCcosto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FrameCcosto.Location = New System.Drawing.Point(432, 8)
        Me.FrameCcosto.Name = "FrameCcosto"
        Me.FrameCcosto.Padding = New System.Windows.Forms.Padding(0)
        Me.FrameCcosto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FrameCcosto.Size = New System.Drawing.Size(217, 201)
        Me.FrameCcosto.TabIndex = 127
        Me.FrameCcosto.TabStop = False
        Me.FrameCcosto.Text = "Centro de Costos"
        '
        'TDBGrid1
        '
        Me.TDBGrid1.DataSource = Nothing
        Me.TDBGrid1.Location = New System.Drawing.Point(0, 16)
        Me.TDBGrid1.Name = "TDBGrid1"
        Me.TDBGrid1.OcxState = CType(resources.GetObject("TDBGrid1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.TDBGrid1.Size = New System.Drawing.Size(209, 129)
        Me.TDBGrid1.TabIndex = 128
        '
        'Frame5
        '
        Me.Frame5.BackColor = System.Drawing.SystemColors.Control
        Me.Frame5.Controls.Add(Me.Cmdsalir)
        Me.Frame5.Controls.Add(Me.CmdAceptar)
        Me.Frame5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame5.Location = New System.Drawing.Point(648, 160)
        Me.Frame5.Name = "Frame5"
        Me.Frame5.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame5.Size = New System.Drawing.Size(161, 49)
        Me.Frame5.TabIndex = 124
        Me.Frame5.TabStop = False
        '
        'Cmdsalir
        '
        Me.Cmdsalir.BackColor = System.Drawing.SystemColors.Control
        Me.Cmdsalir.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmdsalir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmdsalir.Location = New System.Drawing.Point(80, 24)
        Me.Cmdsalir.Name = "Cmdsalir"
        Me.Cmdsalir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmdsalir.Size = New System.Drawing.Size(65, 17)
        Me.Cmdsalir.TabIndex = 126
        Me.Cmdsalir.Text = "Salir"
        Me.Cmdsalir.UseVisualStyleBackColor = False
        '
        'CmdAceptar
        '
        Me.CmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.CmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdAceptar.Location = New System.Drawing.Point(8, 24)
        Me.CmdAceptar.Name = "CmdAceptar"
        Me.CmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdAceptar.Size = New System.Drawing.Size(65, 17)
        Me.CmdAceptar.TabIndex = 125
        Me.CmdAceptar.Text = "Aceptar"
        Me.CmdAceptar.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.White
        Me.Frame1.Controls.Add(Me.Txtimpo)
        Me.Frame1.Controls.Add(Me.TxtIgv)
        Me.Frame1.Controls.Add(Me.TxtInaf)
        Me.Frame1.Controls.Add(Me.TxtTot)
        Me.Frame1.Controls.Add(Me.TxtPerc)
        Me.Frame1.Controls.Add(Me.Labelimpo)
        Me.Frame1.Controls.Add(Me.Labeligv)
        Me.Frame1.Controls.Add(Me.Labelinaf)
        Me.Frame1.Controls.Add(Me.Labeltot)
        Me.Frame1.Controls.Add(Me.Labelperc)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(648, 8)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(161, 153)
        Me.Frame1.TabIndex = 113
        Me.Frame1.TabStop = False
        '
        'Txtimpo
        '
        Me.Txtimpo.AcceptsReturn = True
        Me.Txtimpo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txtimpo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txtimpo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txtimpo.Location = New System.Drawing.Point(64, 16)
        Me.Txtimpo.MaxLength = 12
        Me.Txtimpo.Name = "Txtimpo"
        Me.Txtimpo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txtimpo.Size = New System.Drawing.Size(81, 19)
        Me.Txtimpo.TabIndex = 118
        '
        'TxtIgv
        '
        Me.TxtIgv.AcceptsReturn = True
        Me.TxtIgv.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtIgv.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtIgv.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtIgv.Location = New System.Drawing.Point(64, 40)
        Me.TxtIgv.MaxLength = 12
        Me.TxtIgv.Name = "TxtIgv"
        Me.TxtIgv.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtIgv.Size = New System.Drawing.Size(81, 19)
        Me.TxtIgv.TabIndex = 117
        '
        'TxtInaf
        '
        Me.TxtInaf.AcceptsReturn = True
        Me.TxtInaf.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtInaf.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtInaf.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtInaf.Location = New System.Drawing.Point(64, 64)
        Me.TxtInaf.MaxLength = 12
        Me.TxtInaf.Name = "TxtInaf"
        Me.TxtInaf.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtInaf.Size = New System.Drawing.Size(81, 19)
        Me.TxtInaf.TabIndex = 116
        '
        'TxtTot
        '
        Me.TxtTot.AcceptsReturn = True
        Me.TxtTot.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtTot.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtTot.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtTot.Location = New System.Drawing.Point(64, 112)
        Me.TxtTot.MaxLength = 12
        Me.TxtTot.Name = "TxtTot"
        Me.TxtTot.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtTot.Size = New System.Drawing.Size(81, 19)
        Me.TxtTot.TabIndex = 115
        '
        'TxtPerc
        '
        Me.TxtPerc.AcceptsReturn = True
        Me.TxtPerc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtPerc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPerc.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtPerc.Location = New System.Drawing.Point(64, 88)
        Me.TxtPerc.MaxLength = 12
        Me.TxtPerc.Name = "TxtPerc"
        Me.TxtPerc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtPerc.Size = New System.Drawing.Size(81, 19)
        Me.TxtPerc.TabIndex = 114
        '
        'Labelimpo
        '
        Me.Labelimpo.BackColor = System.Drawing.Color.White
        Me.Labelimpo.Cursor = System.Windows.Forms.Cursors.Default
        Me.Labelimpo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Labelimpo.Location = New System.Drawing.Point(8, 24)
        Me.Labelimpo.Name = "Labelimpo"
        Me.Labelimpo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Labelimpo.Size = New System.Drawing.Size(57, 17)
        Me.Labelimpo.TabIndex = 123
        Me.Labelimpo.Text = "Imponible"
        '
        'Labeligv
        '
        Me.Labeligv.BackColor = System.Drawing.Color.White
        Me.Labeligv.Cursor = System.Windows.Forms.Cursors.Default
        Me.Labeligv.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Labeligv.Location = New System.Drawing.Point(8, 48)
        Me.Labeligv.Name = "Labeligv"
        Me.Labeligv.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Labeligv.Size = New System.Drawing.Size(57, 17)
        Me.Labeligv.TabIndex = 122
        Me.Labeligv.Text = "Igv"
        '
        'Labelinaf
        '
        Me.Labelinaf.BackColor = System.Drawing.Color.White
        Me.Labelinaf.Cursor = System.Windows.Forms.Cursors.Default
        Me.Labelinaf.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Labelinaf.Location = New System.Drawing.Point(8, 72)
        Me.Labelinaf.Name = "Labelinaf"
        Me.Labelinaf.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Labelinaf.Size = New System.Drawing.Size(57, 17)
        Me.Labelinaf.TabIndex = 121
        Me.Labelinaf.Text = "Inafecto"
        '
        'Labeltot
        '
        Me.Labeltot.BackColor = System.Drawing.Color.White
        Me.Labeltot.Cursor = System.Windows.Forms.Cursors.Default
        Me.Labeltot.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Labeltot.Location = New System.Drawing.Point(8, 120)
        Me.Labeltot.Name = "Labeltot"
        Me.Labeltot.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Labeltot.Size = New System.Drawing.Size(25, 17)
        Me.Labeltot.TabIndex = 120
        Me.Labeltot.Text = "Total"
        '
        'Labelperc
        '
        Me.Labelperc.BackColor = System.Drawing.Color.White
        Me.Labelperc.Cursor = System.Windows.Forms.Cursors.Default
        Me.Labelperc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Labelperc.Location = New System.Drawing.Point(8, 96)
        Me.Labelperc.Name = "Labelperc"
        Me.Labelperc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Labelperc.Size = New System.Drawing.Size(57, 17)
        Me.Labelperc.TabIndex = 119
        Me.Labelperc.Text = "Percepcion"
        '
        'Frame4
        '
        Me.Frame4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Frame4.Controls.Add(Me.CtrAyu_Analitico1)
        Me.Frame4.Controls.Add(Me.CtrAyu_Cuenta1)
        Me.Frame4.Controls.Add(Me.CtrAyu_Cuenta2)
        Me.Frame4.Controls.Add(Me.Label27)
        Me.Frame4.Controls.Add(Me.Label14)
        Me.Frame4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame4.Location = New System.Drawing.Point(8, 8)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame4.Size = New System.Drawing.Size(425, 89)
        Me.Frame4.TabIndex = 105
        Me.Frame4.TabStop = False
        '
        'CtrAyu_Analitico1
        '
        Me.CtrAyu_Analitico1.Enabled = True
        Me.CtrAyu_Analitico1.Location = New System.Drawing.Point(64, 64)
        Me.CtrAyu_Analitico1.Name = "CtrAyu_Analitico1"
        Me.CtrAyu_Analitico1.OcxState = CType(resources.GetObject("CtrAyu_Analitico1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CtrAyu_Analitico1.Size = New System.Drawing.Size(329, 17)
        Me.CtrAyu_Analitico1.TabIndex = 106
        '
        'CtrAyu_Cuenta1
        '
        Me.CtrAyu_Cuenta1.Enabled = True
        Me.CtrAyu_Cuenta1.Location = New System.Drawing.Point(64, 16)
        Me.CtrAyu_Cuenta1.Name = "CtrAyu_Cuenta1"
        Me.CtrAyu_Cuenta1.OcxState = CType(resources.GetObject("CtrAyu_Cuenta1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CtrAyu_Cuenta1.Size = New System.Drawing.Size(329, 17)
        Me.CtrAyu_Cuenta1.TabIndex = 107
        '
        'CtrAyu_Cuenta2
        '
        Me.CtrAyu_Cuenta2.Enabled = True
        Me.CtrAyu_Cuenta2.Location = New System.Drawing.Point(64, 40)
        Me.CtrAyu_Cuenta2.Name = "CtrAyu_Cuenta2"
        Me.CtrAyu_Cuenta2.OcxState = CType(resources.GetObject("CtrAyu_Cuenta2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CtrAyu_Cuenta2.Size = New System.Drawing.Size(329, 17)
        Me.CtrAyu_Cuenta2.TabIndex = 108
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label27.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label27.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label27.Location = New System.Drawing.Point(8, 24)
        Me.Label27.Name = "Label27"
        Me.Label27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label27.Size = New System.Drawing.Size(57, 17)
        Me.Label27.TabIndex = 110
        Me.Label27.Text = "Cuenta"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(8, 64)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(57, 17)
        Me.Label14.TabIndex = 109
        Me.Label14.Text = "Analitico"
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Frame2.Controls.Add(Me.TxNdoc1)
        Me.Frame2.Controls.Add(Me.TxSerie1)
        Me.Frame2.Controls.Add(Me.DTP_fecha1)
        Me.Frame2.Controls.Add(Me.CtrAyu_Moneda1)
        Me.Frame2.Controls.Add(Me.CtrAyu_TipDoc1)
        Me.Frame2.Controls.Add(Me.TxFer1)
        Me.Frame2.Controls.Add(Me.Label26)
        Me.Frame2.Controls.Add(Me.Label28)
        Me.Frame2.Controls.Add(Me.Label17)
        Me.Frame2.Controls.Add(Me.Label16)
        Me.Frame2.Controls.Add(Me.Label15)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(8, 96)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(425, 113)
        Me.Frame2.TabIndex = 95
        Me.Frame2.TabStop = False
        '
        'TxNdoc1
        '
        Me.TxNdoc1.Enabled = True
        Me.TxNdoc1.Location = New System.Drawing.Point(320, 8)
        Me.TxNdoc1.Name = "TxNdoc1"
        Me.TxNdoc1.OcxState = CType(resources.GetObject("TxNdoc1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.TxNdoc1.Size = New System.Drawing.Size(97, 20)
        Me.TxNdoc1.TabIndex = 96
        '
        'TxSerie1
        '
        Me.TxSerie1.Enabled = True
        Me.TxSerie1.Location = New System.Drawing.Point(280, 8)
        Me.TxSerie1.Name = "TxSerie1"
        Me.TxSerie1.OcxState = CType(resources.GetObject("TxSerie1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.TxSerie1.Size = New System.Drawing.Size(41, 20)
        Me.TxSerie1.TabIndex = 97
        '
        'DTP_fecha1
        '
        Me.DTP_fecha1.Location = New System.Drawing.Point(72, 32)
        Me.DTP_fecha1.Name = "DTP_fecha1"
        Me.DTP_fecha1.OcxState = CType(resources.GetObject("DTP_fecha1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.DTP_fecha1.Size = New System.Drawing.Size(89, 25)
        Me.DTP_fecha1.TabIndex = 98
        '
        'CtrAyu_Moneda1
        '
        Me.CtrAyu_Moneda1.Enabled = True
        Me.CtrAyu_Moneda1.Location = New System.Drawing.Point(272, 32)
        Me.CtrAyu_Moneda1.Name = "CtrAyu_Moneda1"
        Me.CtrAyu_Moneda1.OcxState = CType(resources.GetObject("CtrAyu_Moneda1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CtrAyu_Moneda1.Size = New System.Drawing.Size(145, 17)
        Me.CtrAyu_Moneda1.TabIndex = 99
        '
        'CtrAyu_TipDoc1
        '
        Me.CtrAyu_TipDoc1.Enabled = True
        Me.CtrAyu_TipDoc1.Location = New System.Drawing.Point(72, 8)
        Me.CtrAyu_TipDoc1.Name = "CtrAyu_TipDoc1"
        Me.CtrAyu_TipDoc1.OcxState = CType(resources.GetObject("CtrAyu_TipDoc1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CtrAyu_TipDoc1.Size = New System.Drawing.Size(145, 25)
        Me.CtrAyu_TipDoc1.TabIndex = 100
        '
        'TxFer1
        '
        Me.TxFer1.Enabled = True
        Me.TxFer1.Location = New System.Drawing.Point(72, 88)
        Me.TxFer1.Name = "TxFer1"
        Me.TxFer1.OcxState = CType(resources.GetObject("TxFer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.TxFer1.Size = New System.Drawing.Size(345, 20)
        Me.TxFer1.TabIndex = 111
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label26.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label26.Location = New System.Drawing.Point(8, 88)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label26.Size = New System.Drawing.Size(57, 17)
        Me.Label26.TabIndex = 112
        Me.Label26.Text = "Glosa"
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label28.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label28.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.Location = New System.Drawing.Point(216, 40)
        Me.Label28.Name = "Label28"
        Me.Label28.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label28.Size = New System.Drawing.Size(49, 17)
        Me.Label28.TabIndex = 104
        Me.Label28.Text = "Moneda"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(8, 40)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(73, 17)
        Me.Label17.TabIndex = 103
        Me.Label17.Text = "Fecha Doc."
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(224, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(57, 17)
        Me.Label16.TabIndex = 102
        Me.Label16.Text = "Nro. Doc."
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(8, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(57, 17)
        Me.Label15.TabIndex = 101
        Me.Label15.Text = "Tipo Doc."
        '
        'frmantcomprobantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(843, 606)
        Me.Controls.Add(Me.SSTabMant)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 26)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmantcomprobantes"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "  "
        Me.SSTabMant.ResumeLayout(False)
        Me._SSTabMant_TabPage0.ResumeLayout(False)
        Me.Frame3.ResumeLayout(False)
        CType(Me.DTPFechaContab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CtrAyu_SubAsiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CtrAyu_Asiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FrameConsulta.ResumeLayout(False)
        Me.FrameConsulta.PerformLayout()
        CType(Me.TxEjecutar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtc_Campo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TDBG_Consulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me._SSTabMant_TabPage1.ResumeLayout(False)
        Me._SSTabMant_TabPage1.PerformLayout()
        Me.SSTab2.ResumeLayout(False)
        Me._SSTab2_TabPage0.ResumeLayout(False)
        Me.FramDetalle.ResumeLayout(False)
        Me.FramDetalle.PerformLayout()
        CType(Me.TxValor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxNdoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxSerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txRuc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CtrAyu_Moneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CtrAyu_TipDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CtrAyu_Analitico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CtrAyu_TipAnal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CtrAyu_CCosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CtrAyu_Cuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CtrAyu_Opera, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtp_FechaDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtpFech_Ven, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CtrAyu_TipRef, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxNref, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtp_FechaDocRef, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StBar.ResumeLayout(False)
        Me.StBar.PerformLayout()
        Me.frameGrid.ResumeLayout(False)
        Me.frameGrid.PerformLayout()
        CType(Me.TDBG_Det, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FrameCabecera.ResumeLayout(False)
        Me.FrameCabecera.PerformLayout()
        CType(Me.DTPFechaComprobCab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxGlosaComprobCab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxObsComprobCab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxCtrNref, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FrameIngreso.ResumeLayout(False)
        Me.FrameCcosto.ResumeLayout(False)
        CType(Me.TDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame5.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.Frame4.ResumeLayout(False)
        CType(Me.CtrAyu_Analitico1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CtrAyu_Cuenta1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CtrAyu_Cuenta2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame2.ResumeLayout(False)
        CType(Me.TxNdoc1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxSerie1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTP_fecha1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CtrAyu_Moneda1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CtrAyu_TipDoc1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxFer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LbTotales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbTipAnal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leFechaComprob, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leNComprob, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class