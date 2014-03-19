<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmMant_CtaCteAnalitico
#Region "Código generado por el Diseñador de Windows Forms "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'Llamada necesaria para el Diseñador de Windows Forms.
		InitializeComponent()
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
	Public WithEvents _cmdBotones_0 As System.Windows.Forms.Button
	Public WithEvents _cmdBotones_1 As System.Windows.Forms.Button
	Public WithEvents _cmdBotones_2 As System.Windows.Forms.Button
	Public WithEvents _cmdBotones_4 As System.Windows.Forms.Button
	Public WithEvents _cmdBotones_3 As System.Windows.Forms.Button
	Public WithEvents framebotones As System.Windows.Forms.GroupBox
	Public WithEvents TDBG_CtaCte As AxTrueOleDBGrid70.AxTDBGrid
	Public WithEvents _SSTab1_TabPage0 As System.Windows.Forms.TabPage
	Public WithEvents CmbID As System.Windows.Forms.ComboBox
	Public WithEvents CmbTcambio As System.Windows.Forms.ComboBox
	Public WithEvents TxMonto As AxTextFer.AxTxFer
	Public WithEvents TxNdoc As AxTextFer.AxTxFer
	Public WithEvents TxSerie As AxTextFer.AxTxFer
	Public WithEvents CtrAyu_Moneda As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents CtrAyu_TipDoc As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents CtrAyu_TipAnal As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents CtrAyu_Opera As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents Dtp_FechaDoc As AxMSComCtl2.AxDTPicker
	Public WithEvents DtpFech_Ven As AxMSComCtl2.AxDTPicker
	Public WithEvents TxGlosa As AxTextFer.AxTxFer
	Public WithEvents CtrAy_Asiento As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents lb_vcambio As System.Windows.Forms.Label
	Public WithEvents _lbTipAnal_0 As System.Windows.Forms.Label
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents lbccosto As System.Windows.Forms.Label
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
	Public WithEvents lblNroComprobante As System.Windows.Forms.Label
	Public WithEvents FramDetalle As System.Windows.Forms.GroupBox
	Public WithEvents cCancela As System.Windows.Forms.Button
	Public WithEvents cAcepta As System.Windows.Forms.Button
	Public WithEvents _SSTab1_TabPage1 As System.Windows.Forms.TabPage
	Public WithEvents SSTab1 As System.Windows.Forms.TabControl
	Public WithEvents Ctr_CtaCtble As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents Ctr_Analitico As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents cmdBotones As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
	Public WithEvents lbTipAnal As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMant_CtaCteAnalitico))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
		Me.SSTab1 = New System.Windows.Forms.TabControl
		Me._SSTab1_TabPage0 = New System.Windows.Forms.TabPage
		Me.framebotones = New System.Windows.Forms.GroupBox
		Me._cmdBotones_0 = New System.Windows.Forms.Button
		Me._cmdBotones_1 = New System.Windows.Forms.Button
		Me._cmdBotones_2 = New System.Windows.Forms.Button
		Me._cmdBotones_4 = New System.Windows.Forms.Button
		Me._cmdBotones_3 = New System.Windows.Forms.Button
		Me.TDBG_CtaCte = New AxTrueOleDBGrid70.AxTDBGrid
		Me._SSTab1_TabPage1 = New System.Windows.Forms.TabPage
		Me.FramDetalle = New System.Windows.Forms.GroupBox
		Me.CmbID = New System.Windows.Forms.ComboBox
		Me.CmbTcambio = New System.Windows.Forms.ComboBox
		Me.TxMonto = New AxTextFer.AxTxFer
		Me.TxNdoc = New AxTextFer.AxTxFer
		Me.TxSerie = New AxTextFer.AxTxFer
		Me.CtrAyu_Moneda = New Axctrlayuda_f.AxCtr_Ayuda
		Me.CtrAyu_TipDoc = New Axctrlayuda_f.AxCtr_Ayuda
		Me.CtrAyu_TipAnal = New Axctrlayuda_f.AxCtr_Ayuda
		Me.CtrAyu_Opera = New Axctrlayuda_f.AxCtr_Ayuda
		Me.Dtp_FechaDoc = New AxMSComCtl2.AxDTPicker
		Me.DtpFech_Ven = New AxMSComCtl2.AxDTPicker
		Me.TxGlosa = New AxTextFer.AxTxFer
		Me.CtrAy_Asiento = New Axctrlayuda_f.AxCtr_Ayuda
		Me.Label3 = New System.Windows.Forms.Label
		Me.lb_vcambio = New System.Windows.Forms.Label
		Me._lbTipAnal_0 = New System.Windows.Forms.Label
		Me.Label11 = New System.Windows.Forms.Label
		Me.lbccosto = New System.Windows.Forms.Label
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
		Me.lblNroComprobante = New System.Windows.Forms.Label
		Me.cCancela = New System.Windows.Forms.Button
		Me.cAcepta = New System.Windows.Forms.Button
		Me.Ctr_CtaCtble = New Axctrlayuda_f.AxCtr_Ayuda
		Me.Ctr_Analitico = New Axctrlayuda_f.AxCtr_Ayuda
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.cmdBotones = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(components)
		Me.lbTipAnal = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.SSTab1.SuspendLayout()
		Me._SSTab1_TabPage0.SuspendLayout()
		Me.framebotones.SuspendLayout()
		Me._SSTab1_TabPage1.SuspendLayout()
		Me.FramDetalle.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.TDBG_CtaCte, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TxMonto, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TxNdoc, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TxSerie, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CtrAyu_Moneda, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CtrAyu_TipDoc, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CtrAyu_TipAnal, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CtrAyu_Opera, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Dtp_FechaDoc, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DtpFech_Ven, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TxGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CtrAy_Asiento, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Ctr_CtaCtble, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Ctr_Analitico, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.cmdBotones, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lbTipAnal, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Mantenimiento de Cta Cte Analiticos - Apertura"
		Me.ClientSize = New System.Drawing.Size(751, 355)
		Me.Location = New System.Drawing.Point(4, 23)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmMant_CtaCteAnalitico"
		Me.SSTab1.Size = New System.Drawing.Size(734, 320)
		Me.SSTab1.Location = New System.Drawing.Point(7, 28)
		Me.SSTab1.TabIndex = 0
		Me.SSTab1.SelectedIndex = 1
		Me.SSTab1.ItemSize = New System.Drawing.Size(42, 18)
		Me.SSTab1.Name = "SSTab1"
		Me._SSTab1_TabPage0.Text = "Consulta"
		Me.framebotones.Size = New System.Drawing.Size(382, 37)
		Me.framebotones.Location = New System.Drawing.Point(176, 275)
		Me.framebotones.TabIndex = 35
		Me.framebotones.BackColor = System.Drawing.SystemColors.Control
		Me.framebotones.Enabled = True
		Me.framebotones.ForeColor = System.Drawing.SystemColors.ControlText
		Me.framebotones.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.framebotones.Visible = True
		Me.framebotones.Padding = New System.Windows.Forms.Padding(0)
		Me.framebotones.Name = "framebotones"
		Me._cmdBotones_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdBotones_0.Text = "&Nuevo"
		Me._cmdBotones_0.Size = New System.Drawing.Size(72, 22)
		Me._cmdBotones_0.Location = New System.Drawing.Point(7, 11)
		Me._cmdBotones_0.TabIndex = 40
		Me._cmdBotones_0.BackColor = System.Drawing.SystemColors.Control
		Me._cmdBotones_0.CausesValidation = True
		Me._cmdBotones_0.Enabled = True
		Me._cmdBotones_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdBotones_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdBotones_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdBotones_0.TabStop = True
		Me._cmdBotones_0.Name = "_cmdBotones_0"
		Me._cmdBotones_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdBotones_1.Text = "E&ditar"
		Me._cmdBotones_1.Size = New System.Drawing.Size(72, 22)
		Me._cmdBotones_1.Location = New System.Drawing.Point(79, 11)
		Me._cmdBotones_1.TabIndex = 39
		Me._cmdBotones_1.BackColor = System.Drawing.SystemColors.Control
		Me._cmdBotones_1.CausesValidation = True
		Me._cmdBotones_1.Enabled = True
		Me._cmdBotones_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdBotones_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdBotones_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdBotones_1.TabStop = True
		Me._cmdBotones_1.Name = "_cmdBotones_1"
		Me._cmdBotones_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdBotones_2.Text = "&Eliminar"
		Me._cmdBotones_2.Size = New System.Drawing.Size(72, 22)
		Me._cmdBotones_2.Location = New System.Drawing.Point(154, 11)
		Me._cmdBotones_2.TabIndex = 38
		Me._cmdBotones_2.BackColor = System.Drawing.SystemColors.Control
		Me._cmdBotones_2.CausesValidation = True
		Me._cmdBotones_2.Enabled = True
		Me._cmdBotones_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdBotones_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdBotones_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdBotones_2.TabStop = True
		Me._cmdBotones_2.Name = "_cmdBotones_2"
		Me._cmdBotones_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdBotones_4.Text = "&Salir"
		Me._cmdBotones_4.Size = New System.Drawing.Size(72, 22)
		Me._cmdBotones_4.Location = New System.Drawing.Point(304, 11)
		Me._cmdBotones_4.TabIndex = 37
		Me._cmdBotones_4.BackColor = System.Drawing.SystemColors.Control
		Me._cmdBotones_4.CausesValidation = True
		Me._cmdBotones_4.Enabled = True
		Me._cmdBotones_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdBotones_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdBotones_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdBotones_4.TabStop = True
		Me._cmdBotones_4.Name = "_cmdBotones_4"
		Me._cmdBotones_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdBotones_3.Text = "&Imprimir"
		Me._cmdBotones_3.Size = New System.Drawing.Size(72, 22)
		Me._cmdBotones_3.Location = New System.Drawing.Point(229, 11)
		Me._cmdBotones_3.TabIndex = 36
		Me._cmdBotones_3.Visible = False
		Me._cmdBotones_3.BackColor = System.Drawing.SystemColors.Control
		Me._cmdBotones_3.CausesValidation = True
		Me._cmdBotones_3.Enabled = True
		Me._cmdBotones_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdBotones_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdBotones_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdBotones_3.TabStop = True
		Me._cmdBotones_3.Name = "_cmdBotones_3"
		TDBG_CtaCte.OcxState = CType(resources.GetObject("TDBG_CtaCte.OcxState"), System.Windows.Forms.AxHost.State)
		Me.TDBG_CtaCte.Size = New System.Drawing.Size(723, 244)
		Me.TDBG_CtaCte.Location = New System.Drawing.Point(7, 33)
		Me.TDBG_CtaCte.TabIndex = 1
		Me.TDBG_CtaCte.Name = "TDBG_CtaCte"
		Me._SSTab1_TabPage1.Text = "Mantenimiento"
		Me.FramDetalle.Size = New System.Drawing.Size(689, 164)
		Me.FramDetalle.Location = New System.Drawing.Point(13, 81)
		Me.FramDetalle.TabIndex = 4
		Me.FramDetalle.BackColor = System.Drawing.SystemColors.Control
		Me.FramDetalle.Enabled = True
		Me.FramDetalle.ForeColor = System.Drawing.SystemColors.ControlText
		Me.FramDetalle.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.FramDetalle.Visible = True
		Me.FramDetalle.Padding = New System.Windows.Forms.Padding(0)
		Me.FramDetalle.Name = "FramDetalle"
		Me.CmbID.Size = New System.Drawing.Size(96, 21)
		Me.CmbID.Location = New System.Drawing.Point(584, 12)
		Me.CmbID.Items.AddRange(New Object(){"D - Debe", "H - Haber"})
		Me.CmbID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CmbID.TabIndex = 6
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
		Me.CmbTcambio.Size = New System.Drawing.Size(96, 21)
		Me.CmbTcambio.Location = New System.Drawing.Point(585, 57)
		Me.CmbTcambio.Items.AddRange(New Object(){"01 - Compra", "02 - Venta", "03 - Promedio"})
		Me.CmbTcambio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CmbTcambio.TabIndex = 5
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
		TxMonto.OcxState = CType(resources.GetObject("TxMonto.OcxState"), System.Windows.Forms.AxHost.State)
		Me.TxMonto.Size = New System.Drawing.Size(98, 21)
		Me.TxMonto.Location = New System.Drawing.Point(584, 104)
		Me.TxMonto.TabIndex = 7
		Me.TxMonto.CausesValidation = -1
		Me.TxMonto.Name = "TxMonto"
		TxNdoc.OcxState = CType(resources.GetObject("TxNdoc.OcxState"), System.Windows.Forms.AxHost.State)
		Me.TxNdoc.Size = New System.Drawing.Size(114, 20)
		Me.TxNdoc.Location = New System.Drawing.Point(305, 90)
		Me.TxNdoc.TabIndex = 8
		Me.TxNdoc.CausesValidation = -1
		Me.TxNdoc.Name = "TxNdoc"
		TxSerie.OcxState = CType(resources.GetObject("TxSerie.OcxState"), System.Windows.Forms.AxHost.State)
		Me.TxSerie.Size = New System.Drawing.Size(44, 20)
		Me.TxSerie.Location = New System.Drawing.Point(260, 90)
		Me.TxSerie.TabIndex = 9
		Me.TxSerie.CausesValidation = -1
		Me.TxSerie.Name = "TxSerie"
		CtrAyu_Moneda.OcxState = CType(resources.GetObject("CtrAyu_Moneda.OcxState"), System.Windows.Forms.AxHost.State)
		Me.CtrAyu_Moneda.Size = New System.Drawing.Size(96, 21)
		Me.CtrAyu_Moneda.Location = New System.Drawing.Point(585, 34)
		Me.CtrAyu_Moneda.TabIndex = 10
		Me.CtrAyu_Moneda.Name = "CtrAyu_Moneda"
		CtrAyu_TipDoc.OcxState = CType(resources.GetObject("CtrAyu_TipDoc.OcxState"), System.Windows.Forms.AxHost.State)
		Me.CtrAyu_TipDoc.Size = New System.Drawing.Size(138, 21)
		Me.CtrAyu_TipDoc.Location = New System.Drawing.Point(75, 89)
		Me.CtrAyu_TipDoc.TabIndex = 11
		Me.CtrAyu_TipDoc.Name = "CtrAyu_TipDoc"
		CtrAyu_TipAnal.OcxState = CType(resources.GetObject("CtrAyu_TipAnal.OcxState"), System.Windows.Forms.AxHost.State)
		Me.CtrAyu_TipAnal.Size = New System.Drawing.Size(160, 28)
		Me.CtrAyu_TipAnal.Location = New System.Drawing.Point(345, 63)
		Me.CtrAyu_TipAnal.TabIndex = 12
		Me.CtrAyu_TipAnal.Name = "CtrAyu_TipAnal"
		CtrAyu_Opera.OcxState = CType(resources.GetObject("CtrAyu_Opera.OcxState"), System.Windows.Forms.AxHost.State)
		Me.CtrAyu_Opera.Size = New System.Drawing.Size(431, 21)
		Me.CtrAyu_Opera.Location = New System.Drawing.Point(75, 35)
		Me.CtrAyu_Opera.TabIndex = 13
		Me.CtrAyu_Opera.Name = "CtrAyu_Opera"
		Dtp_FechaDoc.OcxState = CType(resources.GetObject("Dtp_FechaDoc.OcxState"), System.Windows.Forms.AxHost.State)
		Me.Dtp_FechaDoc.Size = New System.Drawing.Size(86, 21)
		Me.Dtp_FechaDoc.Location = New System.Drawing.Point(76, 112)
		Me.Dtp_FechaDoc.TabIndex = 14
		Me.Dtp_FechaDoc.Name = "Dtp_FechaDoc"
		DtpFech_Ven.OcxState = CType(resources.GetObject("DtpFech_Ven.OcxState"), System.Windows.Forms.AxHost.State)
		Me.DtpFech_Ven.Size = New System.Drawing.Size(112, 21)
		Me.DtpFech_Ven.Location = New System.Drawing.Point(253, 113)
		Me.DtpFech_Ven.TabIndex = 15
		Me.DtpFech_Ven.Name = "DtpFech_Ven"
		TxGlosa.OcxState = CType(resources.GetObject("TxGlosa.OcxState"), System.Windows.Forms.AxHost.State)
		Me.TxGlosa.Size = New System.Drawing.Size(429, 20)
		Me.TxGlosa.Location = New System.Drawing.Point(74, 136)
		Me.TxGlosa.TabIndex = 16
		Me.TxGlosa.CausesValidation = -1
		Me.TxGlosa.Name = "TxGlosa"
		CtrAy_Asiento.OcxState = CType(resources.GetObject("CtrAy_Asiento.OcxState"), System.Windows.Forms.AxHost.State)
		Me.CtrAy_Asiento.Size = New System.Drawing.Size(192, 27)
		Me.CtrAy_Asiento.Location = New System.Drawing.Point(75, 63)
		Me.CtrAy_Asiento.TabIndex = 33
		Me.CtrAy_Asiento.Name = "CtrAy_Asiento"
		Me.Label3.Text = "Nro. Comp."
		Me.Label3.Size = New System.Drawing.Size(57, 21)
		Me.Label3.Location = New System.Drawing.Point(8, 16)
		Me.Label3.TabIndex = 34
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label3.BackColor = System.Drawing.SystemColors.Control
		Me.Label3.Enabled = True
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.lb_vcambio.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.lb_vcambio.BackColor = System.Drawing.Color.FromARGB(255, 254, 242)
		Me.lb_vcambio.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lb_vcambio.Size = New System.Drawing.Size(96, 18)
		Me.lb_vcambio.Location = New System.Drawing.Point(585, 82)
		Me.lb_vcambio.TabIndex = 30
		Me.lb_vcambio.Enabled = True
		Me.lb_vcambio.Cursor = System.Windows.Forms.Cursors.Default
		Me.lb_vcambio.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lb_vcambio.UseMnemonic = True
		Me.lb_vcambio.Visible = True
		Me.lb_vcambio.AutoSize = False
		Me.lb_vcambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lb_vcambio.Name = "lb_vcambio"
		Me._lbTipAnal_0.Text = "Tipo Analitico :"
		Me._lbTipAnal_0.Size = New System.Drawing.Size(70, 27)
		Me._lbTipAnal_0.Location = New System.Drawing.Point(268, 68)
		Me._lbTipAnal_0.TabIndex = 29
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
		Me.Label11.Text = "Cod Oper. :"
		Me.Label11.Size = New System.Drawing.Size(54, 13)
		Me.Label11.Location = New System.Drawing.Point(8, 42)
		Me.Label11.TabIndex = 28
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
		Me.lbccosto.Text = "Asiento"
		Me.lbccosto.Size = New System.Drawing.Size(35, 27)
		Me.lbccosto.Location = New System.Drawing.Point(8, 67)
		Me.lbccosto.TabIndex = 27
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
		Me.Shape3.BorderColor = System.Drawing.Color.FromARGB(128, 128, 128)
		Me.Shape3.Size = New System.Drawing.Size(1, 159)
		Me.Shape3.Location = New System.Drawing.Point(512, 2)
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
		Me.Shape4.Location = New System.Drawing.Point(513, 2)
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
		Me.lbtipdoc.Location = New System.Drawing.Point(8, 92)
		Me.lbtipdoc.TabIndex = 26
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
		Me.lbndocum.Location = New System.Drawing.Point(216, 93)
		Me.lbndocum.TabIndex = 25
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
		Me.lbFechaDoc.Location = New System.Drawing.Point(8, 118)
		Me.lbFechaDoc.TabIndex = 24
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
		Me.lbFechVen.Location = New System.Drawing.Point(167, 117)
		Me.lbFechVen.TabIndex = 23
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
		Me.Label19.Location = New System.Drawing.Point(518, 15)
		Me.Label19.TabIndex = 22
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
		Me.Label20.Location = New System.Drawing.Point(518, 62)
		Me.Label20.TabIndex = 21
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
		Me.Label21.Location = New System.Drawing.Point(520, 85)
		Me.Label21.TabIndex = 20
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
		Me.Label22.Location = New System.Drawing.Point(519, 107)
		Me.Label22.TabIndex = 19
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
		Me.Label23.Location = New System.Drawing.Point(8, 140)
		Me.Label23.TabIndex = 18
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
		Me.Label24.Location = New System.Drawing.Point(520, 41)
		Me.Label24.TabIndex = 17
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
		Me.lblNroComprobante.Size = New System.Drawing.Size(182, 20)
		Me.lblNroComprobante.Location = New System.Drawing.Point(76, 11)
		Me.lblNroComprobante.TabIndex = 43
		Me.lblNroComprobante.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblNroComprobante.BackColor = System.Drawing.SystemColors.Control
		Me.lblNroComprobante.Enabled = True
		Me.lblNroComprobante.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblNroComprobante.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblNroComprobante.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblNroComprobante.UseMnemonic = True
		Me.lblNroComprobante.Visible = True
		Me.lblNroComprobante.AutoSize = False
		Me.lblNroComprobante.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblNroComprobante.Name = "lblNroComprobante"
		Me.cCancela.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cCancela.Text = "&Cancelar"
		Me.cCancela.Size = New System.Drawing.Size(86, 23)
		Me.cCancela.Location = New System.Drawing.Point(381, 255)
		Me.cCancela.TabIndex = 41
		Me.cCancela.BackColor = System.Drawing.SystemColors.Control
		Me.cCancela.CausesValidation = True
		Me.cCancela.Enabled = True
		Me.cCancela.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cCancela.Cursor = System.Windows.Forms.Cursors.Default
		Me.cCancela.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cCancela.TabStop = True
		Me.cCancela.Name = "cCancela"
		Me.cAcepta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cAcepta.Text = "&Aceptar"
		Me.cAcepta.Size = New System.Drawing.Size(86, 23)
		Me.cAcepta.Location = New System.Drawing.Point(278, 255)
		Me.cAcepta.TabIndex = 42
		Me.cAcepta.BackColor = System.Drawing.SystemColors.Control
		Me.cAcepta.CausesValidation = True
		Me.cAcepta.Enabled = True
		Me.cAcepta.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cAcepta.Cursor = System.Windows.Forms.Cursors.Default
		Me.cAcepta.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cAcepta.TabStop = True
		Me.cAcepta.Name = "cAcepta"
		Ctr_CtaCtble.OcxState = CType(resources.GetObject("Ctr_CtaCtble.OcxState"), System.Windows.Forms.AxHost.State)
		Me.Ctr_CtaCtble.Size = New System.Drawing.Size(271, 23)
		Me.Ctr_CtaCtble.Location = New System.Drawing.Point(106, 4)
		Me.Ctr_CtaCtble.TabIndex = 3
		Me.Ctr_CtaCtble.Name = "Ctr_CtaCtble"
		Ctr_Analitico.OcxState = CType(resources.GetObject("Ctr_Analitico.OcxState"), System.Windows.Forms.AxHost.State)
		Me.Ctr_Analitico.Size = New System.Drawing.Size(271, 20)
		Me.Ctr_Analitico.Location = New System.Drawing.Point(469, 4)
		Me.Ctr_Analitico.TabIndex = 31
		Me.Ctr_Analitico.Name = "Ctr_Analitico"
		Me.Label2.Text = "Analitico"
		Me.Label2.Size = New System.Drawing.Size(50, 18)
		Me.Label2.Location = New System.Drawing.Point(383, 8)
		Me.Label2.TabIndex = 32
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.BackColor = System.Drawing.SystemColors.Control
		Me.Label2.Enabled = True
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.Label1.Text = "Cuenta Contable"
		Me.Label1.Size = New System.Drawing.Size(98, 18)
		Me.Label1.Location = New System.Drawing.Point(18, 9)
		Me.Label1.TabIndex = 2
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Enabled = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.Controls.Add(SSTab1)
		Me.Controls.Add(Ctr_CtaCtble)
		Me.Controls.Add(Ctr_Analitico)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.SSTab1.Controls.Add(_SSTab1_TabPage0)
		Me.SSTab1.Controls.Add(_SSTab1_TabPage1)
		Me._SSTab1_TabPage0.Controls.Add(framebotones)
		Me._SSTab1_TabPage0.Controls.Add(TDBG_CtaCte)
		Me.framebotones.Controls.Add(_cmdBotones_0)
		Me.framebotones.Controls.Add(_cmdBotones_1)
		Me.framebotones.Controls.Add(_cmdBotones_2)
		Me.framebotones.Controls.Add(_cmdBotones_4)
		Me.framebotones.Controls.Add(_cmdBotones_3)
		Me._SSTab1_TabPage1.Controls.Add(FramDetalle)
		Me._SSTab1_TabPage1.Controls.Add(cCancela)
		Me._SSTab1_TabPage1.Controls.Add(cAcepta)
		Me.FramDetalle.Controls.Add(CmbID)
		Me.FramDetalle.Controls.Add(CmbTcambio)
		Me.FramDetalle.Controls.Add(TxMonto)
		Me.FramDetalle.Controls.Add(TxNdoc)
		Me.FramDetalle.Controls.Add(TxSerie)
		Me.FramDetalle.Controls.Add(CtrAyu_Moneda)
		Me.FramDetalle.Controls.Add(CtrAyu_TipDoc)
		Me.FramDetalle.Controls.Add(CtrAyu_TipAnal)
		Me.FramDetalle.Controls.Add(CtrAyu_Opera)
		Me.FramDetalle.Controls.Add(Dtp_FechaDoc)
		Me.FramDetalle.Controls.Add(DtpFech_Ven)
		Me.FramDetalle.Controls.Add(TxGlosa)
		Me.FramDetalle.Controls.Add(CtrAy_Asiento)
		Me.FramDetalle.Controls.Add(Label3)
		Me.FramDetalle.Controls.Add(lb_vcambio)
		Me.FramDetalle.Controls.Add(_lbTipAnal_0)
		Me.FramDetalle.Controls.Add(Label11)
		Me.FramDetalle.Controls.Add(lbccosto)
		Me.ShapeContainer1.Shapes.Add(Shape3)
		Me.ShapeContainer1.Shapes.Add(Shape4)
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
		Me.FramDetalle.Controls.Add(lblNroComprobante)
		Me.FramDetalle.Controls.Add(ShapeContainer1)
		Me.cmdBotones.SetIndex(_cmdBotones_0, CType(0, Short))
		Me.cmdBotones.SetIndex(_cmdBotones_1, CType(1, Short))
		Me.cmdBotones.SetIndex(_cmdBotones_2, CType(2, Short))
		Me.cmdBotones.SetIndex(_cmdBotones_4, CType(4, Short))
		Me.cmdBotones.SetIndex(_cmdBotones_3, CType(3, Short))
		Me.lbTipAnal.SetIndex(_lbTipAnal_0, CType(0, Short))
		CType(Me.lbTipAnal, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.cmdBotones, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Ctr_Analitico, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Ctr_CtaCtble, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CtrAy_Asiento, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TxGlosa, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DtpFech_Ven, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Dtp_FechaDoc, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CtrAyu_Opera, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CtrAyu_TipAnal, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CtrAyu_TipDoc, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CtrAyu_Moneda, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TxSerie, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TxNdoc, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TxMonto, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TDBG_CtaCte, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SSTab1.ResumeLayout(False)
		Me._SSTab1_TabPage0.ResumeLayout(False)
		Me.framebotones.ResumeLayout(False)
		Me._SSTab1_TabPage1.ResumeLayout(False)
		Me.FramDetalle.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class