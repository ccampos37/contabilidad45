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
     Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMant_CtaCteAnalitico))
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Shape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Shape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.SSTab1 = New System.Windows.Forms.TabControl()
        Me._SSTab1_TabPage0 = New System.Windows.Forms.TabPage()
        Me.framebotones = New System.Windows.Forms.GroupBox()
        Me._cmdBotones_0 = New System.Windows.Forms.Button()
        Me._cmdBotones_1 = New System.Windows.Forms.Button()
        Me._cmdBotones_2 = New System.Windows.Forms.Button()
        Me._cmdBotones_4 = New System.Windows.Forms.Button()
        Me._cmdBotones_3 = New System.Windows.Forms.Button()
        Me.TDBG_CtaCte = New AxTrueOleDBGrid70.AxTDBGrid()
        Me._SSTab1_TabPage1 = New System.Windows.Forms.TabPage()
        Me.FramDetalle = New System.Windows.Forms.GroupBox()
        Me.CmbID = New System.Windows.Forms.ComboBox()
        Me.CmbTcambio = New System.Windows.Forms.ComboBox()
        Me.TxMonto = New AxTextFer.AxTxFer()
        Me.TxNdoc = New AxTextFer.AxTxFer()
        Me.TxSerie = New AxTextFer.AxTxFer()
        Me.CtrAyu_Moneda = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.CtrAyu_TipDoc = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.CtrAyu_TipAnal = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.CtrAyu_Opera = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Dtp_FechaDoc = New AxMSComCtl2.AxDTPicker()
        Me.DtpFech_Ven = New AxMSComCtl2.AxDTPicker()
        Me.TxGlosa = New AxTextFer.AxTxFer()
        Me.CtrAy_Asiento = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lb_vcambio = New System.Windows.Forms.Label()
        Me._lbTipAnal_0 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbccosto = New System.Windows.Forms.Label()
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
        Me.lblNroComprobante = New System.Windows.Forms.Label()
        Me.cCancela = New System.Windows.Forms.Button()
        Me.cAcepta = New System.Windows.Forms.Button()
        Me.Ctr_CtaCtble = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Ctr_Analitico = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SSTab1.SuspendLayout()
        Me._SSTab1_TabPage0.SuspendLayout()
        Me.framebotones.SuspendLayout()
        CType(Me.TDBG_CtaCte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._SSTab1_TabPage1.SuspendLayout()
        Me.FramDetalle.SuspendLayout()
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
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 13)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.Shape3, Me.Shape4})
        Me.ShapeContainer1.Size = New System.Drawing.Size(689, 151)
        Me.ShapeContainer1.TabIndex = 44
        Me.ShapeContainer1.TabStop = False
        '
        'Shape3
        '
        Me.Shape3.BackColor = System.Drawing.SystemColors.Window
        Me.Shape3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Shape3.FillColor = System.Drawing.Color.Black
        Me.Shape3.Location = New System.Drawing.Point(512, 2)
        Me.Shape3.Name = "Shape3"
        Me.Shape3.Size = New System.Drawing.Size(1, 159)
        '
        'Shape4
        '
        Me.Shape4.BackColor = System.Drawing.SystemColors.Window
        Me.Shape4.BorderColor = System.Drawing.Color.White
        Me.Shape4.FillColor = System.Drawing.Color.Black
        Me.Shape4.Location = New System.Drawing.Point(513, 2)
        Me.Shape4.Name = "Shape4"
        Me.Shape4.Size = New System.Drawing.Size(1, 159)
        '
        'SSTab1
        '
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage0)
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage1)
        Me.SSTab1.ItemSize = New System.Drawing.Size(42, 18)
        Me.SSTab1.Location = New System.Drawing.Point(7, 28)
        Me.SSTab1.Name = "SSTab1"
        Me.SSTab1.SelectedIndex = 1
        Me.SSTab1.Size = New System.Drawing.Size(761, 398)
        Me.SSTab1.TabIndex = 0
        '
        '_SSTab1_TabPage0
        '
        Me._SSTab1_TabPage0.Controls.Add(Me.framebotones)
        Me._SSTab1_TabPage0.Controls.Add(Me.TDBG_CtaCte)
        Me._SSTab1_TabPage0.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage0.Name = "_SSTab1_TabPage0"
        Me._SSTab1_TabPage0.Size = New System.Drawing.Size(753, 372)
        Me._SSTab1_TabPage0.TabIndex = 0
        Me._SSTab1_TabPage0.Text = "Consulta"
        '
        'framebotones
        '
        Me.framebotones.BackColor = System.Drawing.SystemColors.Control
        Me.framebotones.Controls.Add(Me._cmdBotones_0)
        Me.framebotones.Controls.Add(Me._cmdBotones_1)
        Me.framebotones.Controls.Add(Me._cmdBotones_2)
        Me.framebotones.Controls.Add(Me._cmdBotones_4)
        Me.framebotones.Controls.Add(Me._cmdBotones_3)
        Me.framebotones.ForeColor = System.Drawing.SystemColors.ControlText
        Me.framebotones.Location = New System.Drawing.Point(95, 283)
        Me.framebotones.Name = "framebotones"
        Me.framebotones.Padding = New System.Windows.Forms.Padding(0)
        Me.framebotones.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.framebotones.Size = New System.Drawing.Size(529, 73)
        Me.framebotones.TabIndex = 35
        Me.framebotones.TabStop = False
        '
        '_cmdBotones_0
        '
        Me._cmdBotones_0.BackColor = System.Drawing.SystemColors.Control
        Me._cmdBotones_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdBotones_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdBotones_0.Location = New System.Drawing.Point(27, 13)
        Me._cmdBotones_0.Name = "_cmdBotones_0"
        Me._cmdBotones_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdBotones_0.Size = New System.Drawing.Size(92, 41)
        Me._cmdBotones_0.TabIndex = 40
        Me._cmdBotones_0.Text = "&Nuevo"
        Me._cmdBotones_0.UseVisualStyleBackColor = False
        '
        '_cmdBotones_1
        '
        Me._cmdBotones_1.BackColor = System.Drawing.SystemColors.Control
        Me._cmdBotones_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdBotones_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdBotones_1.Location = New System.Drawing.Point(125, 13)
        Me._cmdBotones_1.Name = "_cmdBotones_1"
        Me._cmdBotones_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdBotones_1.Size = New System.Drawing.Size(92, 41)
        Me._cmdBotones_1.TabIndex = 39
        Me._cmdBotones_1.Text = "E&ditar"
        Me._cmdBotones_1.UseVisualStyleBackColor = False
        '
        '_cmdBotones_2
        '
        Me._cmdBotones_2.BackColor = System.Drawing.SystemColors.Control
        Me._cmdBotones_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdBotones_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdBotones_2.Location = New System.Drawing.Point(223, 13)
        Me._cmdBotones_2.Name = "_cmdBotones_2"
        Me._cmdBotones_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdBotones_2.Size = New System.Drawing.Size(92, 44)
        Me._cmdBotones_2.TabIndex = 38
        Me._cmdBotones_2.Text = "&Eliminar"
        Me._cmdBotones_2.UseVisualStyleBackColor = False
        '
        '_cmdBotones_4
        '
        Me._cmdBotones_4.BackColor = System.Drawing.SystemColors.Control
        Me._cmdBotones_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdBotones_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdBotones_4.Location = New System.Drawing.Point(419, 13)
        Me._cmdBotones_4.Name = "_cmdBotones_4"
        Me._cmdBotones_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdBotones_4.Size = New System.Drawing.Size(92, 41)
        Me._cmdBotones_4.TabIndex = 37
        Me._cmdBotones_4.Text = "&Salir"
        Me._cmdBotones_4.UseVisualStyleBackColor = False
        '
        '_cmdBotones_3
        '
        Me._cmdBotones_3.BackColor = System.Drawing.SystemColors.Control
        Me._cmdBotones_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdBotones_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdBotones_3.Location = New System.Drawing.Point(321, 13)
        Me._cmdBotones_3.Name = "_cmdBotones_3"
        Me._cmdBotones_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdBotones_3.Size = New System.Drawing.Size(92, 41)
        Me._cmdBotones_3.TabIndex = 36
        Me._cmdBotones_3.Text = "&Imprimir"
        Me._cmdBotones_3.UseVisualStyleBackColor = False
        Me._cmdBotones_3.Visible = False
        '
        'TDBG_CtaCte
        '
        Me.TDBG_CtaCte.DataSource = Nothing
        Me.TDBG_CtaCte.Location = New System.Drawing.Point(7, 33)
        Me.TDBG_CtaCte.Name = "TDBG_CtaCte"
        Me.TDBG_CtaCte.OcxState = CType(resources.GetObject("TDBG_CtaCte.OcxState"), System.Windows.Forms.AxHost.State)
        Me.TDBG_CtaCte.Size = New System.Drawing.Size(723, 244)
        Me.TDBG_CtaCte.TabIndex = 1
        '
        '_SSTab1_TabPage1
        '
        Me._SSTab1_TabPage1.Controls.Add(Me.FramDetalle)
        Me._SSTab1_TabPage1.Controls.Add(Me.cCancela)
        Me._SSTab1_TabPage1.Controls.Add(Me.cAcepta)
        Me._SSTab1_TabPage1.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage1.Name = "_SSTab1_TabPage1"
        Me._SSTab1_TabPage1.Size = New System.Drawing.Size(753, 372)
        Me._SSTab1_TabPage1.TabIndex = 1
        Me._SSTab1_TabPage1.Text = "Mantenimiento"
        '
        'FramDetalle
        '
        Me.FramDetalle.BackColor = System.Drawing.SystemColors.Control
        Me.FramDetalle.Controls.Add(Me.CmbID)
        Me.FramDetalle.Controls.Add(Me.CmbTcambio)
        Me.FramDetalle.Controls.Add(Me.TxMonto)
        Me.FramDetalle.Controls.Add(Me.TxNdoc)
        Me.FramDetalle.Controls.Add(Me.TxSerie)
        Me.FramDetalle.Controls.Add(Me.CtrAyu_Moneda)
        Me.FramDetalle.Controls.Add(Me.CtrAyu_TipDoc)
        Me.FramDetalle.Controls.Add(Me.CtrAyu_TipAnal)
        Me.FramDetalle.Controls.Add(Me.CtrAyu_Opera)
        Me.FramDetalle.Controls.Add(Me.Dtp_FechaDoc)
        Me.FramDetalle.Controls.Add(Me.DtpFech_Ven)
        Me.FramDetalle.Controls.Add(Me.TxGlosa)
        Me.FramDetalle.Controls.Add(Me.CtrAy_Asiento)
        Me.FramDetalle.Controls.Add(Me.Label3)
        Me.FramDetalle.Controls.Add(Me.lb_vcambio)
        Me.FramDetalle.Controls.Add(Me._lbTipAnal_0)
        Me.FramDetalle.Controls.Add(Me.Label11)
        Me.FramDetalle.Controls.Add(Me.lbccosto)
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
        Me.FramDetalle.Controls.Add(Me.lblNroComprobante)
        Me.FramDetalle.Controls.Add(Me.ShapeContainer1)
        Me.FramDetalle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FramDetalle.Location = New System.Drawing.Point(13, 81)
        Me.FramDetalle.Name = "FramDetalle"
        Me.FramDetalle.Padding = New System.Windows.Forms.Padding(0)
        Me.FramDetalle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FramDetalle.Size = New System.Drawing.Size(689, 164)
        Me.FramDetalle.TabIndex = 4
        Me.FramDetalle.TabStop = False
        '
        'CmbID
        '
        Me.CmbID.BackColor = System.Drawing.SystemColors.Window
        Me.CmbID.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmbID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CmbID.Items.AddRange(New Object() {"D - Debe", "H - Haber"})
        Me.CmbID.Location = New System.Drawing.Point(584, 12)
        Me.CmbID.Name = "CmbID"
        Me.CmbID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmbID.Size = New System.Drawing.Size(96, 21)
        Me.CmbID.TabIndex = 6
        '
        'CmbTcambio
        '
        Me.CmbTcambio.BackColor = System.Drawing.SystemColors.Window
        Me.CmbTcambio.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmbTcambio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTcambio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CmbTcambio.Items.AddRange(New Object() {"01 - Compra", "02 - Venta", "03 - Promedio"})
        Me.CmbTcambio.Location = New System.Drawing.Point(585, 57)
        Me.CmbTcambio.Name = "CmbTcambio"
        Me.CmbTcambio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmbTcambio.Size = New System.Drawing.Size(96, 21)
        Me.CmbTcambio.TabIndex = 5
        '
        'TxMonto
        '
        Me.TxMonto.Enabled = True
        Me.TxMonto.Location = New System.Drawing.Point(584, 104)
        Me.TxMonto.Name = "TxMonto"
        Me.TxMonto.OcxState = CType(resources.GetObject("TxMonto.OcxState"), System.Windows.Forms.AxHost.State)
        Me.TxMonto.Size = New System.Drawing.Size(98, 21)
        Me.TxMonto.TabIndex = 7
        '
        'TxNdoc
        '
        Me.TxNdoc.Enabled = True
        Me.TxNdoc.Location = New System.Drawing.Point(305, 90)
        Me.TxNdoc.Name = "TxNdoc"
        Me.TxNdoc.OcxState = CType(resources.GetObject("TxNdoc.OcxState"), System.Windows.Forms.AxHost.State)
        Me.TxNdoc.Size = New System.Drawing.Size(114, 20)
        Me.TxNdoc.TabIndex = 8
        '
        'TxSerie
        '
        Me.TxSerie.Enabled = True
        Me.TxSerie.Location = New System.Drawing.Point(260, 90)
        Me.TxSerie.Name = "TxSerie"
        Me.TxSerie.OcxState = CType(resources.GetObject("TxSerie.OcxState"), System.Windows.Forms.AxHost.State)
        Me.TxSerie.Size = New System.Drawing.Size(44, 20)
        Me.TxSerie.TabIndex = 9
        '
        'CtrAyu_Moneda
        '
        Me.CtrAyu_Moneda.Enabled = True
        Me.CtrAyu_Moneda.Location = New System.Drawing.Point(585, 34)
        Me.CtrAyu_Moneda.Name = "CtrAyu_Moneda"
        Me.CtrAyu_Moneda.OcxState = CType(resources.GetObject("CtrAyu_Moneda.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CtrAyu_Moneda.Size = New System.Drawing.Size(96, 21)
        Me.CtrAyu_Moneda.TabIndex = 10
        '
        'CtrAyu_TipDoc
        '
        Me.CtrAyu_TipDoc.Enabled = True
        Me.CtrAyu_TipDoc.Location = New System.Drawing.Point(75, 89)
        Me.CtrAyu_TipDoc.Name = "CtrAyu_TipDoc"
        Me.CtrAyu_TipDoc.OcxState = CType(resources.GetObject("CtrAyu_TipDoc.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CtrAyu_TipDoc.Size = New System.Drawing.Size(138, 21)
        Me.CtrAyu_TipDoc.TabIndex = 11
        '
        'CtrAyu_TipAnal
        '
        Me.CtrAyu_TipAnal.Enabled = True
        Me.CtrAyu_TipAnal.Location = New System.Drawing.Point(345, 63)
        Me.CtrAyu_TipAnal.Name = "CtrAyu_TipAnal"
        Me.CtrAyu_TipAnal.OcxState = CType(resources.GetObject("CtrAyu_TipAnal.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CtrAyu_TipAnal.Size = New System.Drawing.Size(160, 28)
        Me.CtrAyu_TipAnal.TabIndex = 12
        '
        'CtrAyu_Opera
        '
        Me.CtrAyu_Opera.Enabled = True
        Me.CtrAyu_Opera.Location = New System.Drawing.Point(75, 35)
        Me.CtrAyu_Opera.Name = "CtrAyu_Opera"
        Me.CtrAyu_Opera.OcxState = CType(resources.GetObject("CtrAyu_Opera.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CtrAyu_Opera.Size = New System.Drawing.Size(431, 21)
        Me.CtrAyu_Opera.TabIndex = 13
        '
        'Dtp_FechaDoc
        '
        Me.Dtp_FechaDoc.Location = New System.Drawing.Point(76, 112)
        Me.Dtp_FechaDoc.Name = "Dtp_FechaDoc"
        Me.Dtp_FechaDoc.OcxState = CType(resources.GetObject("Dtp_FechaDoc.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Dtp_FechaDoc.Size = New System.Drawing.Size(86, 21)
        Me.Dtp_FechaDoc.TabIndex = 14
        '
        'DtpFech_Ven
        '
        Me.DtpFech_Ven.Location = New System.Drawing.Point(253, 113)
        Me.DtpFech_Ven.Name = "DtpFech_Ven"
        Me.DtpFech_Ven.OcxState = CType(resources.GetObject("DtpFech_Ven.OcxState"), System.Windows.Forms.AxHost.State)
        Me.DtpFech_Ven.Size = New System.Drawing.Size(112, 21)
        Me.DtpFech_Ven.TabIndex = 15
        '
        'TxGlosa
        '
        Me.TxGlosa.Enabled = True
        Me.TxGlosa.Location = New System.Drawing.Point(74, 136)
        Me.TxGlosa.Name = "TxGlosa"
        Me.TxGlosa.OcxState = CType(resources.GetObject("TxGlosa.OcxState"), System.Windows.Forms.AxHost.State)
        Me.TxGlosa.Size = New System.Drawing.Size(429, 20)
        Me.TxGlosa.TabIndex = 16
        '
        'CtrAy_Asiento
        '
        Me.CtrAy_Asiento.Enabled = True
        Me.CtrAy_Asiento.Location = New System.Drawing.Point(75, 63)
        Me.CtrAy_Asiento.Name = "CtrAy_Asiento"
        Me.CtrAy_Asiento.OcxState = CType(resources.GetObject("CtrAy_Asiento.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CtrAy_Asiento.Size = New System.Drawing.Size(192, 27)
        Me.CtrAy_Asiento.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(8, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(57, 21)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Nro. Comp."
        '
        'lb_vcambio
        '
        Me.lb_vcambio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.lb_vcambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_vcambio.Cursor = System.Windows.Forms.Cursors.Default
        Me.lb_vcambio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lb_vcambio.Location = New System.Drawing.Point(585, 82)
        Me.lb_vcambio.Name = "lb_vcambio"
        Me.lb_vcambio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lb_vcambio.Size = New System.Drawing.Size(96, 18)
        Me.lb_vcambio.TabIndex = 30
        Me.lb_vcambio.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lbTipAnal_0
        '
        Me._lbTipAnal_0.AutoSize = True
        Me._lbTipAnal_0.BackColor = System.Drawing.SystemColors.Control
        Me._lbTipAnal_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbTipAnal_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbTipAnal_0.Location = New System.Drawing.Point(268, 68)
        Me._lbTipAnal_0.Name = "_lbTipAnal_0"
        Me._lbTipAnal_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbTipAnal_0.Size = New System.Drawing.Size(77, 13)
        Me._lbTipAnal_0.TabIndex = 29
        Me._lbTipAnal_0.Text = "Tipo Analitico :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(8, 42)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Cod Oper. :"
        '
        'lbccosto
        '
        Me.lbccosto.AutoSize = True
        Me.lbccosto.BackColor = System.Drawing.SystemColors.Control
        Me.lbccosto.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbccosto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbccosto.Location = New System.Drawing.Point(8, 67)
        Me.lbccosto.Name = "lbccosto"
        Me.lbccosto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbccosto.Size = New System.Drawing.Size(42, 13)
        Me.lbccosto.TabIndex = 27
        Me.lbccosto.Text = "Asiento"
        '
        'lbtipdoc
        '
        Me.lbtipdoc.BackColor = System.Drawing.SystemColors.Control
        Me.lbtipdoc.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbtipdoc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbtipdoc.Location = New System.Drawing.Point(8, 92)
        Me.lbtipdoc.Name = "lbtipdoc"
        Me.lbtipdoc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbtipdoc.Size = New System.Drawing.Size(68, 17)
        Me.lbtipdoc.TabIndex = 26
        Me.lbtipdoc.Text = "Tipo doc. :"
        '
        'lbndocum
        '
        Me.lbndocum.AutoSize = True
        Me.lbndocum.BackColor = System.Drawing.SystemColors.Control
        Me.lbndocum.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbndocum.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbndocum.Location = New System.Drawing.Point(216, 93)
        Me.lbndocum.Name = "lbndocum"
        Me.lbndocum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbndocum.Size = New System.Drawing.Size(49, 13)
        Me.lbndocum.TabIndex = 25
        Me.lbndocum.Text = "Nº doc. :"
        '
        'lbFechaDoc
        '
        Me.lbFechaDoc.AutoSize = True
        Me.lbFechaDoc.BackColor = System.Drawing.SystemColors.Control
        Me.lbFechaDoc.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbFechaDoc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbFechaDoc.Location = New System.Drawing.Point(8, 118)
        Me.lbFechaDoc.Name = "lbFechaDoc"
        Me.lbFechaDoc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbFechaDoc.Size = New System.Drawing.Size(67, 13)
        Me.lbFechaDoc.TabIndex = 24
        Me.lbFechaDoc.Text = "Fecha doc. :"
        '
        'lbFechVen
        '
        Me.lbFechVen.AutoSize = True
        Me.lbFechVen.BackColor = System.Drawing.SystemColors.Control
        Me.lbFechVen.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbFechVen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbFechVen.Location = New System.Drawing.Point(167, 117)
        Me.lbFechVen.Name = "lbFechVen"
        Me.lbFechVen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbFechVen.Size = New System.Drawing.Size(89, 13)
        Me.lbFechVen.TabIndex = 23
        Me.lbFechVen.Text = "Fecha de Venc. :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.SystemColors.Control
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(518, 15)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label19.Size = New System.Drawing.Size(57, 13)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "Indicador :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.SystemColors.Control
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(518, 62)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(60, 13)
        Me.Label20.TabIndex = 21
        Me.Label20.Text = "T/Cambio :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(520, 85)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(60, 13)
        Me.Label21.TabIndex = 20
        Me.Label21.Text = "V/Cambio :"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.SystemColors.Control
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(519, 107)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(43, 13)
        Me.Label22.TabIndex = 19
        Me.Label22.Text = "Monto :"
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.SystemColors.Control
        Me.Label23.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(8, 140)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label23.Size = New System.Drawing.Size(33, 13)
        Me.Label23.TabIndex = 18
        Me.Label23.Text = "Glosa :"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.SystemColors.Control
        Me.Label24.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(520, 41)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24.Size = New System.Drawing.Size(52, 13)
        Me.Label24.TabIndex = 17
        Me.Label24.Text = "Moneda :"
        '
        'lblNroComprobante
        '
        Me.lblNroComprobante.BackColor = System.Drawing.SystemColors.Control
        Me.lblNroComprobante.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNroComprobante.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNroComprobante.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNroComprobante.Location = New System.Drawing.Point(76, 11)
        Me.lblNroComprobante.Name = "lblNroComprobante"
        Me.lblNroComprobante.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNroComprobante.Size = New System.Drawing.Size(182, 20)
        Me.lblNroComprobante.TabIndex = 43
        '
        'cCancela
        '
        Me.cCancela.BackColor = System.Drawing.SystemColors.Control
        Me.cCancela.Cursor = System.Windows.Forms.Cursors.Default
        Me.cCancela.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cCancela.Location = New System.Drawing.Point(381, 255)
        Me.cCancela.Name = "cCancela"
        Me.cCancela.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cCancela.Size = New System.Drawing.Size(86, 23)
        Me.cCancela.TabIndex = 41
        Me.cCancela.Text = "&Cancelar"
        Me.cCancela.UseVisualStyleBackColor = False
        '
        'cAcepta
        '
        Me.cAcepta.BackColor = System.Drawing.SystemColors.Control
        Me.cAcepta.Cursor = System.Windows.Forms.Cursors.Default
        Me.cAcepta.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cAcepta.Location = New System.Drawing.Point(278, 255)
        Me.cAcepta.Name = "cAcepta"
        Me.cAcepta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cAcepta.Size = New System.Drawing.Size(86, 23)
        Me.cAcepta.TabIndex = 42
        Me.cAcepta.Text = "&Aceptar"
        Me.cAcepta.UseVisualStyleBackColor = False
        '
        'Ctr_CtaCtble
        '
        Me.Ctr_CtaCtble.Enabled = True
        Me.Ctr_CtaCtble.Location = New System.Drawing.Point(106, 4)
        Me.Ctr_CtaCtble.Name = "Ctr_CtaCtble"
        Me.Ctr_CtaCtble.OcxState = CType(resources.GetObject("Ctr_CtaCtble.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Ctr_CtaCtble.Size = New System.Drawing.Size(271, 23)
        Me.Ctr_CtaCtble.TabIndex = 3
        '
        'Ctr_Analitico
        '
        Me.Ctr_Analitico.Enabled = True
        Me.Ctr_Analitico.Location = New System.Drawing.Point(469, 4)
        Me.Ctr_Analitico.Name = "Ctr_Analitico"
        Me.Ctr_Analitico.OcxState = CType(resources.GetObject("Ctr_Analitico.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Ctr_Analitico.Size = New System.Drawing.Size(271, 20)
        Me.Ctr_Analitico.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(383, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(50, 18)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Analitico"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(18, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(98, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cuenta Contable"
        '
        'frmMant_CtaCteAnalitico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(780, 438)
        Me.Controls.Add(Me.SSTab1)
        Me.Controls.Add(Me.Ctr_CtaCtble)
        Me.Controls.Add(Me.Ctr_Analitico)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Name = "frmMant_CtaCteAnalitico"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Cta Cte Analiticos - Apertura"
        Me.SSTab1.ResumeLayout(False)
        Me._SSTab1_TabPage0.ResumeLayout(False)
        Me.framebotones.ResumeLayout(False)
        CType(Me.TDBG_CtaCte, System.ComponentModel.ISupportInitialize).EndInit()
        Me._SSTab1_TabPage1.ResumeLayout(False)
        Me.FramDetalle.ResumeLayout(False)
        Me.FramDetalle.PerformLayout()
        CType(Me.TxMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxNdoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxSerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CtrAyu_Moneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CtrAyu_TipDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CtrAyu_TipAnal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CtrAyu_Opera, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtp_FechaDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtpFech_Ven, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CtrAy_Asiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ctr_CtaCtble, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ctr_Analitico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class