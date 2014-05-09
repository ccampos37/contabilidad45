<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmMantPlantillaAsiento
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
    Public WithEvents TDBGrid1 As AxTrueOleDBGrid70.AxTDBGrid
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents TDBGrid3 As AxTrueOleDBGrid70.AxTDBGrid
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents lblNumRegAsientos As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents lblNumRegSubAs As System.Windows.Forms.Label
	Public WithEvents _SSTab1_TabPage0 As System.Windows.Forms.TabPage
	Public WithEvents lblMensaje As System.Windows.Forms.Label
	Public WithEvents ChkAjuste As System.Windows.Forms.CheckBox
	Public WithEvents TDBGrid2 As AxTrueOleDBGrid70.AxTDBGrid
	Public WithEvents chk As System.Windows.Forms.CheckBox
    Public WithEvents txt0 As AxTextFer.AxTxFer
    Public WithEvents txt1 As AxTextFer.AxTxFer
    Public WithEvents txt2 As AxTextFer.AxTxFer
    Public WithEvents txt3 As AxTextFer.AxTxFer
    Public WithEvents Ctr_Ayuda2 As Axctrlayuda_f.AxCtr_Ayuda
    Public WithEvents Ctr_Ayuda1 As Axctrlayuda_f.AxCtr_Ayuda
    Public WithEvents Ctr_Ayucuenta As Axctrlayuda_f.AxCtr_Ayuda
    Public WithEvents Ctr_Ayuda3 As Axctrlayuda_f.AxCtr_Ayuda
    Public WithEvents Ctr_Ayuda5 As Axctrlayuda_f.AxCtr_Ayuda
    Public WithEvents _lbl_7 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents _lbl_6 As System.Windows.Forms.Label
    Public WithEvents _lbl_5 As System.Windows.Forms.Label
    Public WithEvents _lbl_4 As System.Windows.Forms.Label
    Public WithEvents _lbl_3 As System.Windows.Forms.Label
    Public WithEvents _lbl_2 As System.Windows.Forms.Label
    Public WithEvents _lbl_1 As System.Windows.Forms.Label
    Public WithEvents _lbl_0 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents cAcepta As System.Windows.Forms.Button
    Public WithEvents cCancela As System.Windows.Forms.Button
    Public WithEvents cmdBotones0 As System.Windows.Forms.Button
    Public WithEvents cmdBotones1 As System.Windows.Forms.Button
    Public WithEvents cmdBotones2 As System.Windows.Forms.Button
    Public WithEvents cmdBotones4 As System.Windows.Forms.Button
    Public WithEvents cmdBotones3 As System.Windows.Forms.Button
    Public WithEvents frmbotones As System.Windows.Forms.GroupBox
    Public WithEvents _SSTab1_TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents SSTab1 As System.Windows.Forms.TabControl
    Public WithEvents txt As AxTxFerArray
    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMantPlantillaAsiento))
        Me.SSTab1 = New System.Windows.Forms.TabControl()
        Me._SSTab1_TabPage0 = New System.Windows.Forms.TabPage()
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me.TDBGrid1 = New AxTrueOleDBGrid70.AxTDBGrid()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.TDBGrid3 = New AxTrueOleDBGrid70.AxTDBGrid()
        Me.lblNumRegAsientos = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNumRegSubAs = New System.Windows.Forms.Label()
        Me._SSTab1_TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.ChkAjuste = New System.Windows.Forms.CheckBox()
        Me.TDBGrid2 = New AxTrueOleDBGrid70.AxTDBGrid()
        Me.chk = New System.Windows.Forms.CheckBox()
        Me.txt0 = New AxTextFer.AxTxFer()
        Me.txt1 = New AxTextFer.AxTxFer()
        Me.txt2 = New AxTextFer.AxTxFer()
        Me.txt3 = New AxTextFer.AxTxFer()
        Me.Ctr_Ayuda2 = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Ctr_Ayuda1 = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Ctr_Ayucuenta = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Ctr_Ayuda3 = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Ctr_Ayuda5 = New Axctrlayuda_f.AxCtr_Ayuda()
        Me._lbl_7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me._lbl_6 = New System.Windows.Forms.Label()
        Me._lbl_5 = New System.Windows.Forms.Label()
        Me._lbl_4 = New System.Windows.Forms.Label()
        Me._lbl_3 = New System.Windows.Forms.Label()
        Me._lbl_2 = New System.Windows.Forms.Label()
        Me._lbl_1 = New System.Windows.Forms.Label()
        Me._lbl_0 = New System.Windows.Forms.Label()
        Me.cAcepta = New System.Windows.Forms.Button()
        Me.cCancela = New System.Windows.Forms.Button()
        Me.frmbotones = New System.Windows.Forms.GroupBox()
        Me.cmdBotones0 = New System.Windows.Forms.Button()
        Me.cmdBotones1 = New System.Windows.Forms.Button()
        Me.cmdBotones2 = New System.Windows.Forms.Button()
        Me.cmdBotones4 = New System.Windows.Forms.Button()
        Me.cmdBotones3 = New System.Windows.Forms.Button()
        Me.SSTab1.SuspendLayout()
        Me._SSTab1_TabPage0.SuspendLayout()
        Me.Frame3.SuspendLayout()
        CType(Me.TDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame2.SuspendLayout()
        CType(Me.TDBGrid3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._SSTab1_TabPage1.SuspendLayout()
        Me.Frame1.SuspendLayout()
        CType(Me.TDBGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ctr_Ayuda2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ctr_Ayuda1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ctr_Ayucuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ctr_Ayuda3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ctr_Ayuda5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmbotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'SSTab1
        '
        Me.SSTab1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage0)
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage1)
        Me.SSTab1.ItemSize = New System.Drawing.Size(42, 18)
        Me.SSTab1.Location = New System.Drawing.Point(2, 0)
        Me.SSTab1.Name = "SSTab1"
        Me.SSTab1.SelectedIndex = 1
        Me.SSTab1.Size = New System.Drawing.Size(451, 523)
        Me.SSTab1.TabIndex = 10
        '
        '_SSTab1_TabPage0
        '
        Me._SSTab1_TabPage0.Controls.Add(Me.Frame3)
        Me._SSTab1_TabPage0.Controls.Add(Me.Frame2)
        Me._SSTab1_TabPage0.Controls.Add(Me.lblNumRegAsientos)
        Me._SSTab1_TabPage0.Controls.Add(Me.Label2)
        Me._SSTab1_TabPage0.Controls.Add(Me.Label1)
        Me._SSTab1_TabPage0.Controls.Add(Me.lblNumRegSubAs)
        Me._SSTab1_TabPage0.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage0.Name = "_SSTab1_TabPage0"
        Me._SSTab1_TabPage0.Size = New System.Drawing.Size(443, 497)
        Me._SSTab1_TabPage0.TabIndex = 0
        Me._SSTab1_TabPage0.Text = "Consulta"
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.Add(Me.TDBGrid1)
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(4, 232)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(439, 192)
        Me.Frame3.TabIndex = 35
        Me.Frame3.TabStop = False
        Me.Frame3.Text = "Seleccionar SubAsientos"
        '
        'TDBGrid1
        '
        Me.TDBGrid1.DataSource = Nothing
        Me.TDBGrid1.Location = New System.Drawing.Point(2, 14)
        Me.TDBGrid1.Name = "TDBGrid1"
        Me.TDBGrid1.OcxState = CType(resources.GetObject("TDBGrid1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.TDBGrid1.Size = New System.Drawing.Size(434, 176)
        Me.TDBGrid1.TabIndex = 36
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.TDBGrid3)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(3, 34)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(438, 165)
        Me.Frame2.TabIndex = 33
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Seleccionar Asientos"
        '
        'TDBGrid3
        '
        Me.TDBGrid3.DataSource = Nothing
        Me.TDBGrid3.Location = New System.Drawing.Point(2, 14)
        Me.TDBGrid3.Name = "TDBGrid3"
        Me.TDBGrid3.OcxState = CType(resources.GetObject("TDBGrid3.OcxState"), System.Windows.Forms.AxHost.State)
        Me.TDBGrid3.Size = New System.Drawing.Size(433, 148)
        Me.TDBGrid3.TabIndex = 34
        '
        'lblNumRegAsientos
        '
        Me.lblNumRegAsientos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblNumRegAsientos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNumRegAsientos.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNumRegAsientos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblNumRegAsientos.Location = New System.Drawing.Point(378, 204)
        Me.lblNumRegAsientos.Name = "lblNumRegAsientos"
        Me.lblNumRegAsientos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNumRegAsientos.Size = New System.Drawing.Size(61, 18)
        Me.lblNumRegAsientos.TabIndex = 32
        Me.lblNumRegAsientos.Text = "lblNumReg"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(319, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(63, 17)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Nº Asientos"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(248, 429)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(124, 18)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Nº SubAsientos x Asiento"
        '
        'lblNumRegSubAs
        '
        Me.lblNumRegSubAs.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblNumRegSubAs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNumRegSubAs.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNumRegSubAs.ForeColor = System.Drawing.Color.Yellow
        Me.lblNumRegSubAs.Location = New System.Drawing.Point(380, 428)
        Me.lblNumRegSubAs.Name = "lblNumRegSubAs"
        Me.lblNumRegSubAs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNumRegSubAs.Size = New System.Drawing.Size(62, 19)
        Me.lblNumRegSubAs.TabIndex = 20
        Me.lblNumRegSubAs.Text = "lblNumReg"
        '
        '_SSTab1_TabPage1
        '
        Me._SSTab1_TabPage1.Controls.Add(Me.lblMensaje)
        Me._SSTab1_TabPage1.Controls.Add(Me.Frame1)
        Me._SSTab1_TabPage1.Controls.Add(Me.cAcepta)
        Me._SSTab1_TabPage1.Controls.Add(Me.cCancela)
        Me._SSTab1_TabPage1.Controls.Add(Me.frmbotones)
        Me._SSTab1_TabPage1.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage1.Name = "_SSTab1_TabPage1"
        Me._SSTab1_TabPage1.Size = New System.Drawing.Size(443, 497)
        Me._SSTab1_TabPage1.TabIndex = 1
        Me._SSTab1_TabPage1.Text = "Mantenimiento"
        '
        'lblMensaje
        '
        Me.lblMensaje.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblMensaje.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMensaje.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMensaje.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblMensaje.Location = New System.Drawing.Point(130, 429)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMensaje.Size = New System.Drawing.Size(196, 20)
        Me.lblMensaje.TabIndex = 30
        Me.lblMensaje.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.ChkAjuste)
        Me.Frame1.Controls.Add(Me.TDBGrid2)
        Me.Frame1.Controls.Add(Me.chk)
        Me.Frame1.Controls.Add(Me.txt0)
        Me.Frame1.Controls.Add(Me.txt1)
        Me.Frame1.Controls.Add(Me.txt2)
        Me.Frame1.Controls.Add(Me.txt3)
        Me.Frame1.Controls.Add(Me.Ctr_Ayuda2)
        Me.Frame1.Controls.Add(Me.Ctr_Ayuda1)
        Me.Frame1.Controls.Add(Me.Ctr_Ayucuenta)
        Me.Frame1.Controls.Add(Me.Ctr_Ayuda3)
        Me.Frame1.Controls.Add(Me.Ctr_Ayuda5)
        Me.Frame1.Controls.Add(Me._lbl_7)
        Me.Frame1.Controls.Add(Me.Label5)
        Me.Frame1.Controls.Add(Me.Label4)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.Controls.Add(Me._lbl_6)
        Me.Frame1.Controls.Add(Me._lbl_5)
        Me.Frame1.Controls.Add(Me._lbl_4)
        Me.Frame1.Controls.Add(Me._lbl_3)
        Me.Frame1.Controls.Add(Me._lbl_2)
        Me.Frame1.Controls.Add(Me._lbl_1)
        Me.Frame1.Controls.Add(Me._lbl_0)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(4, 21)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(439, 369)
        Me.Frame1.TabIndex = 11
        Me.Frame1.TabStop = False
        '
        'ChkAjuste
        '
        Me.ChkAjuste.BackColor = System.Drawing.SystemColors.Control
        Me.ChkAjuste.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkAjuste.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkAjuste.Location = New System.Drawing.Point(419, 137)
        Me.ChkAjuste.Name = "ChkAjuste"
        Me.ChkAjuste.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkAjuste.Size = New System.Drawing.Size(16, 16)
        Me.ChkAjuste.TabIndex = 40
        Me.ChkAjuste.UseVisualStyleBackColor = False
        '
        'TDBGrid2
        '
        Me.TDBGrid2.DataSource = Nothing
        Me.TDBGrid2.Location = New System.Drawing.Point(3, 207)
        Me.TDBGrid2.Name = "TDBGrid2"
        Me.TDBGrid2.OcxState = CType(resources.GetObject("TDBGrid2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.TDBGrid2.Size = New System.Drawing.Size(431, 163)
        Me.TDBGrid2.TabIndex = 23
        '
        'chk
        '
        Me.chk.BackColor = System.Drawing.SystemColors.Control
        Me.chk.Cursor = System.Windows.Forms.Cursors.Default
        Me.chk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chk.Location = New System.Drawing.Point(167, 139)
        Me.chk.Name = "chk"
        Me.chk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chk.Size = New System.Drawing.Size(35, 16)
        Me.chk.TabIndex = 7
        Me.chk.UseVisualStyleBackColor = False
        '
        'txt0
        '
        Me.txt0.Enabled = True
        Me.txt0.Location = New System.Drawing.Point(167, 50)
        Me.txt0.Name = "txt0"
        Me.txt0.OcxState = CType(resources.GetObject("txt0.OcxState"), System.Windows.Forms.AxHost.State)
        Me.txt0.Size = New System.Drawing.Size(267, 21)
        Me.txt0.TabIndex = 2
        '
        'txt1
        '
        Me.txt1.Enabled = True
        Me.txt1.Location = New System.Drawing.Point(165, 113)
        Me.txt1.Name = "txt1"
        Me.txt1.OcxState = CType(resources.GetObject("txt1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.txt1.Size = New System.Drawing.Size(21, 20)
        Me.txt1.TabIndex = 5
        '
        'txt2
        '
        Me.txt2.Enabled = True
        Me.txt2.Location = New System.Drawing.Point(165, 177)
        Me.txt2.Name = "txt2"
        Me.txt2.OcxState = CType(resources.GetObject("txt2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.txt2.Size = New System.Drawing.Size(75, 20)
        Me.txt2.TabIndex = 9
        '
        'txt3
        '
        Me.txt3.Enabled = True
        Me.txt3.Location = New System.Drawing.Point(260, 113)
        Me.txt3.Name = "txt3"
        Me.txt3.OcxState = CType(resources.GetObject("txt3.OcxState"), System.Windows.Forms.AxHost.State)
        Me.txt3.Size = New System.Drawing.Size(174, 20)
        Me.txt3.TabIndex = 6
        '
        'Ctr_Ayuda2
        '
        Me.Ctr_Ayuda2.Enabled = True
        Me.Ctr_Ayuda2.Location = New System.Drawing.Point(169, 30)
        Me.Ctr_Ayuda2.Name = "Ctr_Ayuda2"
        Me.Ctr_Ayuda2.OcxState = CType(resources.GetObject("Ctr_Ayuda2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Ctr_Ayuda2.Size = New System.Drawing.Size(266, 33)
        Me.Ctr_Ayuda2.TabIndex = 1
        '
        'Ctr_Ayuda1
        '
        Me.Ctr_Ayuda1.Enabled = True
        Me.Ctr_Ayuda1.Location = New System.Drawing.Point(169, 9)
        Me.Ctr_Ayuda1.Name = "Ctr_Ayuda1"
        Me.Ctr_Ayuda1.OcxState = CType(resources.GetObject("Ctr_Ayuda1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Ctr_Ayuda1.Size = New System.Drawing.Size(266, 21)
        Me.Ctr_Ayuda1.TabIndex = 0
        '
        'Ctr_Ayucuenta
        '
        Me.Ctr_Ayucuenta.Enabled = True
        Me.Ctr_Ayucuenta.Location = New System.Drawing.Point(167, 91)
        Me.Ctr_Ayucuenta.Name = "Ctr_Ayucuenta"
        Me.Ctr_Ayucuenta.OcxState = CType(resources.GetObject("Ctr_Ayucuenta.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Ctr_Ayucuenta.Size = New System.Drawing.Size(268, 24)
        Me.Ctr_Ayucuenta.TabIndex = 4
        '
        'Ctr_Ayuda3
        '
        Me.Ctr_Ayuda3.Enabled = True
        Me.Ctr_Ayuda3.Location = New System.Drawing.Point(167, 71)
        Me.Ctr_Ayuda3.Name = "Ctr_Ayuda3"
        Me.Ctr_Ayuda3.OcxState = CType(resources.GetObject("Ctr_Ayuda3.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Ctr_Ayuda3.Size = New System.Drawing.Size(268, 23)
        Me.Ctr_Ayuda3.TabIndex = 3
        '
        'Ctr_Ayuda5
        '
        Me.Ctr_Ayuda5.Enabled = True
        Me.Ctr_Ayuda5.Location = New System.Drawing.Point(166, 156)
        Me.Ctr_Ayuda5.Name = "Ctr_Ayuda5"
        Me.Ctr_Ayuda5.OcxState = CType(resources.GetObject("Ctr_Ayuda5.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Ctr_Ayuda5.Size = New System.Drawing.Size(269, 24)
        Me.Ctr_Ayuda5.TabIndex = 8
        '
        '_lbl_7
        '
        Me._lbl_7.AutoSize = True
        Me._lbl_7.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_7.Location = New System.Drawing.Point(314, 138)
        Me._lbl_7.Name = "_lbl_7"
        Me._lbl_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_7.Size = New System.Drawing.Size(91, 13)
        Me._lbl_7.TabIndex = 41
        Me._lbl_7.Text = "Cuenta de Ajuste "
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(197, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(60, 20)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Cta Comodin"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(9, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(94, 18)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "IGV (%)"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(8, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Cuenta con IGV"
        '
        '_lbl_6
        '
        Me._lbl_6.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_6.Location = New System.Drawing.Point(8, 141)
        Me._lbl_6.Name = "_lbl_6"
        Me._lbl_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_6.Size = New System.Drawing.Size(152, 19)
        Me._lbl_6.TabIndex = 22
        Me._lbl_6.Text = "Cuenta Inafecta"
        '
        '_lbl_5
        '
        Me._lbl_5.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_5.Location = New System.Drawing.Point(9, 119)
        Me._lbl_5.Name = "_lbl_5"
        Me._lbl_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_5.Size = New System.Drawing.Size(154, 19)
        Me._lbl_5.TabIndex = 17
        Me._lbl_5.Text = "Debe/Haber"
        '
        '_lbl_4
        '
        Me._lbl_4.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_4.Location = New System.Drawing.Point(9, 98)
        Me._lbl_4.Name = "_lbl_4"
        Me._lbl_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_4.Size = New System.Drawing.Size(152, 19)
        Me._lbl_4.TabIndex = 16
        Me._lbl_4.Text = "Cuenta"
        '
        '_lbl_3
        '
        Me._lbl_3.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_3.Location = New System.Drawing.Point(9, 77)
        Me._lbl_3.Name = "_lbl_3"
        Me._lbl_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_3.Size = New System.Drawing.Size(154, 19)
        Me._lbl_3.TabIndex = 15
        Me._lbl_3.Text = "Operación"
        '
        '_lbl_2
        '
        Me._lbl_2.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_2.Location = New System.Drawing.Point(9, 55)
        Me._lbl_2.Name = "_lbl_2"
        Me._lbl_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_2.Size = New System.Drawing.Size(154, 19)
        Me._lbl_2.TabIndex = 14
        Me._lbl_2.Text = "Correlativo Plantilla"
        '
        '_lbl_1
        '
        Me._lbl_1.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_1.Location = New System.Drawing.Point(9, 33)
        Me._lbl_1.Name = "_lbl_1"
        Me._lbl_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_1.Size = New System.Drawing.Size(154, 19)
        Me._lbl_1.TabIndex = 13
        Me._lbl_1.Text = "Sub Asiento"
        '
        '_lbl_0
        '
        Me._lbl_0.BackColor = System.Drawing.SystemColors.Control
        Me._lbl_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbl_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbl_0.Location = New System.Drawing.Point(9, 12)
        Me._lbl_0.Name = "_lbl_0"
        Me._lbl_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbl_0.Size = New System.Drawing.Size(154, 19)
        Me._lbl_0.TabIndex = 12
        Me._lbl_0.Text = "Asiento"
        '
        'cAcepta
        '
        Me.cAcepta.BackColor = System.Drawing.SystemColors.Control
        Me.cAcepta.Cursor = System.Windows.Forms.Cursors.Default
        Me.cAcepta.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cAcepta.Location = New System.Drawing.Point(130, 404)
        Me.cAcepta.Name = "cAcepta"
        Me.cAcepta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cAcepta.Size = New System.Drawing.Size(76, 23)
        Me.cAcepta.TabIndex = 18
        Me.cAcepta.Text = "&Aceptar"
        Me.cAcepta.UseVisualStyleBackColor = False
        '
        'cCancela
        '
        Me.cCancela.BackColor = System.Drawing.SystemColors.Control
        Me.cCancela.Cursor = System.Windows.Forms.Cursors.Default
        Me.cCancela.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cCancela.Location = New System.Drawing.Point(226, 404)
        Me.cCancela.Name = "cCancela"
        Me.cCancela.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cCancela.Size = New System.Drawing.Size(76, 23)
        Me.cCancela.TabIndex = 19
        Me.cCancela.Text = "&Cancelar"
        Me.cCancela.UseVisualStyleBackColor = False
        '
        'frmbotones
        '
        Me.frmbotones.BackColor = System.Drawing.SystemColors.Control
        Me.frmbotones.Controls.Add(Me.cmdBotones0)
        Me.frmbotones.Controls.Add(Me.cmdBotones1)
        Me.frmbotones.Controls.Add(Me.cmdBotones2)
        Me.frmbotones.Controls.Add(Me.cmdBotones4)
        Me.frmbotones.Controls.Add(Me.cmdBotones3)
        Me.frmbotones.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frmbotones.Location = New System.Drawing.Point(39, 452)
        Me.frmbotones.Name = "frmbotones"
        Me.frmbotones.Padding = New System.Windows.Forms.Padding(0)
        Me.frmbotones.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frmbotones.Size = New System.Drawing.Size(382, 37)
        Me.frmbotones.TabIndex = 24
        Me.frmbotones.TabStop = False
        '
        'cmdBotones0
        '
        Me.cmdBotones0.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBotones0.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBotones0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones0.Location = New System.Drawing.Point(4, 11)
        Me.cmdBotones0.Name = "cmdBotones0"
        Me.cmdBotones0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBotones0.Size = New System.Drawing.Size(72, 22)
        Me.cmdBotones0.TabIndex = 29
        Me.cmdBotones0.Text = "&Nuevo"
        Me.cmdBotones0.UseVisualStyleBackColor = False
        '
        'cmdBotones1
        '
        Me.cmdBotones1.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBotones1.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBotones1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones1.Location = New System.Drawing.Point(79, 11)
        Me.cmdBotones1.Name = "cmdBotones1"
        Me.cmdBotones1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBotones1.Size = New System.Drawing.Size(72, 22)
        Me.cmdBotones1.TabIndex = 28
        Me.cmdBotones1.Text = "E&ditar"
        Me.cmdBotones1.UseVisualStyleBackColor = False
        '
        'cmdBotones2
        '
        Me.cmdBotones2.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBotones2.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBotones2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones2.Location = New System.Drawing.Point(154, 11)
        Me.cmdBotones2.Name = "cmdBotones2"
        Me.cmdBotones2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBotones2.Size = New System.Drawing.Size(72, 22)
        Me.cmdBotones2.TabIndex = 27
        Me.cmdBotones2.Text = "&Eliminar"
        Me.cmdBotones2.UseVisualStyleBackColor = False
        '
        'cmdBotones4
        '
        Me.cmdBotones4.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBotones4.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBotones4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones4.Location = New System.Drawing.Point(304, 11)
        Me.cmdBotones4.Name = "cmdBotones4"
        Me.cmdBotones4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBotones4.Size = New System.Drawing.Size(72, 22)
        Me.cmdBotones4.TabIndex = 26
        Me.cmdBotones4.Text = "&Salir"
        Me.cmdBotones4.UseVisualStyleBackColor = False
        '
        'cmdBotones3
        '
        Me.cmdBotones3.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBotones3.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBotones3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones3.Location = New System.Drawing.Point(229, 11)
        Me.cmdBotones3.Name = "cmdBotones3"
        Me.cmdBotones3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBotones3.Size = New System.Drawing.Size(72, 22)
        Me.cmdBotones3.TabIndex = 25
        Me.cmdBotones3.Text = "&Imprimir"
        Me.cmdBotones3.UseVisualStyleBackColor = False
        '
        'frmMantPlantillaAsiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(465, 523)
        Me.Controls.Add(Me.SSTab1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMantPlantillaAsiento"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Plantilla de Sub Asientos"
        Me.SSTab1.ResumeLayout(False)
        Me._SSTab1_TabPage0.ResumeLayout(False)
        Me.Frame3.ResumeLayout(False)
        CType(Me.TDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame2.ResumeLayout(False)
        CType(Me.TDBGrid3, System.ComponentModel.ISupportInitialize).EndInit()
        Me._SSTab1_TabPage1.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.TDBGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ctr_Ayuda2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ctr_Ayuda1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ctr_Ayucuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ctr_Ayuda3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ctr_Ayuda5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmbotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class