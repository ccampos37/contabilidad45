<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FrmRepBalanceComp
#Region "C�digo generado por el Dise�ador de Windows Forms "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'Llamada necesaria para el Dise�ador de Windows Forms.
		InitializeComponent()
		'�ste es un formulario MDI secundario.
		'Este c�digo simula la funcionalidad de VB6 
		' de cargar autom�ticamente
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
	'Requerido por el Dise�ador de Windows Forms
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents ChkFiltcta As System.Windows.Forms.CheckBox
	Public WithEvents CtrAyu_Cuenta As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents Frame5 As System.Windows.Forms.GroupBox
	Public WithEvents cmbNivel As System.Windows.Forms.ComboBox
	Public WithEvents DTPicker1 As AxMSComCtl2.AxDTPicker
	Public WithEvents CtrAyu_Moneda As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Frame4 As System.Windows.Forms.GroupBox
	Public WithEvents DtCfiltro As AxMSDataListLib.AxDataCombo
	Public WithEvents CmdCancelar As System.Windows.Forms.Button
	Public WithEvents CmdAceptar As System.Windows.Forms.Button
	Public WithEvents _OpTipo_1 As System.Windows.Forms.RadioButton
	Public WithEvents _OpTipo_0 As System.Windows.Forms.RadioButton
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents ChkCascada As System.Windows.Forms.CheckBox
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents _OptForma_1 As System.Windows.Forms.RadioButton
	Public WithEvents _OptForma_0 As System.Windows.Forms.RadioButton
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents OpTipo As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	Public WithEvents OptForma As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	'NOTA: el Dise�ador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Dise�ador de Windows Forms.
	'No lo modifique con el editor de c�digo.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmRepBalanceComp))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Frame5 = New System.Windows.Forms.GroupBox
		Me.ChkFiltcta = New System.Windows.Forms.CheckBox
		Me.CtrAyu_Cuenta = New Axctrlayuda_f.AxCtr_Ayuda
		Me.Frame4 = New System.Windows.Forms.GroupBox
		Me.cmbNivel = New System.Windows.Forms.ComboBox
		Me.DTPicker1 = New AxMSComCtl2.AxDTPicker
		Me.CtrAyu_Moneda = New Axctrlayuda_f.AxCtr_Ayuda
		Me.Label1 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.DtCfiltro = New AxMSDataListLib.AxDataCombo
		Me.CmdCancelar = New System.Windows.Forms.Button
		Me.CmdAceptar = New System.Windows.Forms.Button
		Me.Frame3 = New System.Windows.Forms.GroupBox
		Me._OpTipo_1 = New System.Windows.Forms.RadioButton
		Me._OpTipo_0 = New System.Windows.Forms.RadioButton
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.ChkCascada = New System.Windows.Forms.CheckBox
		Me.Label2 = New System.Windows.Forms.Label
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me._OptForma_1 = New System.Windows.Forms.RadioButton
		Me._OptForma_0 = New System.Windows.Forms.RadioButton
		Me.Label5 = New System.Windows.Forms.Label
		Me.OpTipo = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.OptForma = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.Frame5.SuspendLayout()
		Me.Frame4.SuspendLayout()
		Me.Frame3.SuspendLayout()
		Me.Frame2.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.CtrAyu_Cuenta, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DTPicker1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CtrAyu_Moneda, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DtCfiltro, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.OpTipo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.OptForma, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Reporte Balance de Comprobancion"
		Me.ClientSize = New System.Drawing.Size(440, 367)
		Me.Location = New System.Drawing.Point(3, 22)
		Me.MaximizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
		Me.MinimizeBox = False
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "FrmRepBalanceComp"
		Me.Frame5.Text = "Filtro por Cuentas"
		Me.Frame5.Size = New System.Drawing.Size(405, 60)
		Me.Frame5.Location = New System.Drawing.Point(5, 148)
		Me.Frame5.TabIndex = 20
		Me.Frame5.BackColor = System.Drawing.SystemColors.Control
		Me.Frame5.Enabled = True
		Me.Frame5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame5.Visible = True
		Me.Frame5.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame5.Name = "Frame5"
		Me.ChkFiltcta.Size = New System.Drawing.Size(14, 20)
		Me.ChkFiltcta.Location = New System.Drawing.Point(98, -1)
		Me.ChkFiltcta.TabIndex = 21
		Me.ChkFiltcta.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ChkFiltcta.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.ChkFiltcta.BackColor = System.Drawing.SystemColors.Control
		Me.ChkFiltcta.Text = ""
		Me.ChkFiltcta.CausesValidation = True
		Me.ChkFiltcta.Enabled = True
		Me.ChkFiltcta.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ChkFiltcta.Cursor = System.Windows.Forms.Cursors.Default
		Me.ChkFiltcta.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ChkFiltcta.Appearance = System.Windows.Forms.Appearance.Normal
		Me.ChkFiltcta.TabStop = True
		Me.ChkFiltcta.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.ChkFiltcta.Visible = True
		Me.ChkFiltcta.Name = "ChkFiltcta"
		CtrAyu_Cuenta.OcxState = CType(resources.GetObject("CtrAyu_Cuenta.OcxState"), System.Windows.Forms.AxHost.State)
		Me.CtrAyu_Cuenta.Size = New System.Drawing.Size(390, 21)
		Me.CtrAyu_Cuenta.Location = New System.Drawing.Point(8, 25)
		Me.CtrAyu_Cuenta.TabIndex = 22
		Me.CtrAyu_Cuenta.Name = "CtrAyu_Cuenta"
		Me.Frame4.Size = New System.Drawing.Size(406, 72)
		Me.Frame4.Location = New System.Drawing.Point(4, 72)
		Me.Frame4.TabIndex = 13
		Me.Frame4.BackColor = System.Drawing.SystemColors.Control
		Me.Frame4.Enabled = True
		Me.Frame4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame4.Visible = True
		Me.Frame4.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame4.Name = "Frame4"
		Me.cmbNivel.Size = New System.Drawing.Size(128, 21)
		Me.cmbNivel.Location = New System.Drawing.Point(69, 15)
		Me.cmbNivel.TabIndex = 15
		Me.cmbNivel.Text = "Combo1"
		Me.cmbNivel.BackColor = System.Drawing.SystemColors.Window
		Me.cmbNivel.CausesValidation = True
		Me.cmbNivel.Enabled = True
		Me.cmbNivel.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbNivel.IntegralHeight = True
		Me.cmbNivel.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbNivel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbNivel.Sorted = False
		Me.cmbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cmbNivel.TabStop = True
		Me.cmbNivel.Visible = True
		Me.cmbNivel.Name = "cmbNivel"
		DTPicker1.OcxState = CType(resources.GetObject("DTPicker1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.DTPicker1.Size = New System.Drawing.Size(127, 19)
		Me.DTPicker1.Location = New System.Drawing.Point(70, 41)
		Me.DTPicker1.TabIndex = 14
		Me.DTPicker1.Name = "DTPicker1"
		CtrAyu_Moneda.OcxState = CType(resources.GetObject("CtrAyu_Moneda.OcxState"), System.Windows.Forms.AxHost.State)
		Me.CtrAyu_Moneda.Size = New System.Drawing.Size(144, 21)
		Me.CtrAyu_Moneda.Location = New System.Drawing.Point(255, 41)
		Me.CtrAyu_Moneda.TabIndex = 16
		Me.CtrAyu_Moneda.Name = "CtrAyu_Moneda"
		Me.Label1.Text = "Nivel :"
		Me.Label1.Size = New System.Drawing.Size(30, 13)
		Me.Label1.Location = New System.Drawing.Point(9, 18)
		Me.Label1.TabIndex = 19
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Enabled = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = True
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.Label3.Text = "Mes :"
		Me.Label3.Size = New System.Drawing.Size(26, 13)
		Me.Label3.Location = New System.Drawing.Point(8, 42)
		Me.Label3.TabIndex = 18
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label3.BackColor = System.Drawing.SystemColors.Control
		Me.Label3.Enabled = True
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = True
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.Label4.Text = "Moneda :"
		Me.Label4.Size = New System.Drawing.Size(45, 13)
		Me.Label4.Location = New System.Drawing.Point(208, 43)
		Me.Label4.TabIndex = 17
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label4.BackColor = System.Drawing.SystemColors.Control
		Me.Label4.Enabled = True
		Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.Visible = True
		Me.Label4.AutoSize = True
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.Name = "Label4"
		DtCfiltro.OcxState = CType(resources.GetObject("DtCfiltro.OcxState"), System.Windows.Forms.AxHost.State)
		Me.DtCfiltro.Size = New System.Drawing.Size(287, 21)
		Me.DtCfiltro.Location = New System.Drawing.Point(121, 263)
		Me.DtCfiltro.TabIndex = 11
		Me.DtCfiltro.Name = "DtCfiltro"
		Me.CmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.CmdCancelar.Text = "&Cancelar"
		Me.CmdCancelar.Size = New System.Drawing.Size(91, 24)
		Me.CmdCancelar.Location = New System.Drawing.Point(207, 294)
		Me.CmdCancelar.TabIndex = 10
		Me.CmdCancelar.BackColor = System.Drawing.SystemColors.Control
		Me.CmdCancelar.CausesValidation = True
		Me.CmdCancelar.Enabled = True
		Me.CmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.CmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
		Me.CmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CmdCancelar.TabStop = True
		Me.CmdCancelar.Name = "CmdCancelar"
		Me.CmdAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.CmdAceptar.Text = "&Aceptar"
		Me.CmdAceptar.Size = New System.Drawing.Size(91, 24)
		Me.CmdAceptar.Location = New System.Drawing.Point(118, 294)
		Me.CmdAceptar.TabIndex = 9
		Me.CmdAceptar.BackColor = System.Drawing.SystemColors.Control
		Me.CmdAceptar.CausesValidation = True
		Me.CmdAceptar.Enabled = True
		Me.CmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.CmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
		Me.CmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CmdAceptar.TabStop = True
		Me.CmdAceptar.Name = "CmdAceptar"
		Me.Frame3.Text = "Tipo"
		Me.Frame3.Size = New System.Drawing.Size(194, 45)
		Me.Frame3.Location = New System.Drawing.Point(6, 210)
		Me.Frame3.TabIndex = 6
		Me.Frame3.BackColor = System.Drawing.SystemColors.Control
		Me.Frame3.Enabled = True
		Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame3.Visible = True
		Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame3.Name = "Frame3"
		Me._OpTipo_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._OpTipo_1.Text = "Ajustado"
		Me._OpTipo_1.Enabled = False
		Me._OpTipo_1.Size = New System.Drawing.Size(66, 13)
		Me._OpTipo_1.Location = New System.Drawing.Point(104, 21)
		Me._OpTipo_1.TabIndex = 8
		Me._OpTipo_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._OpTipo_1.BackColor = System.Drawing.SystemColors.Control
		Me._OpTipo_1.CausesValidation = True
		Me._OpTipo_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._OpTipo_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._OpTipo_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._OpTipo_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._OpTipo_1.TabStop = True
		Me._OpTipo_1.Checked = False
		Me._OpTipo_1.Visible = True
		Me._OpTipo_1.Name = "_OpTipo_1"
		Me._OpTipo_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._OpTipo_0.Text = "Historico"
		Me._OpTipo_0.Size = New System.Drawing.Size(83, 13)
		Me._OpTipo_0.Location = New System.Drawing.Point(8, 21)
		Me._OpTipo_0.TabIndex = 7
		Me._OpTipo_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._OpTipo_0.BackColor = System.Drawing.SystemColors.Control
		Me._OpTipo_0.CausesValidation = True
		Me._OpTipo_0.Enabled = True
		Me._OpTipo_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._OpTipo_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._OpTipo_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._OpTipo_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._OpTipo_0.TabStop = True
		Me._OpTipo_0.Checked = False
		Me._OpTipo_0.Visible = True
		Me._OpTipo_0.Name = "_OpTipo_0"
		Me.Frame2.Size = New System.Drawing.Size(405, 71)
		Me.Frame2.Location = New System.Drawing.Point(4, 1)
		Me.Frame2.TabIndex = 3
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame2.Name = "Frame2"
		Me.ChkCascada.Text = "En Cascada"
		Me.ChkCascada.Size = New System.Drawing.Size(136, 21)
		Me.ChkCascada.Location = New System.Drawing.Point(86, 40)
		Me.ChkCascada.TabIndex = 5
		Me.ChkCascada.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ChkCascada.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.ChkCascada.BackColor = System.Drawing.SystemColors.Control
		Me.ChkCascada.CausesValidation = True
		Me.ChkCascada.Enabled = True
		Me.ChkCascada.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ChkCascada.Cursor = System.Windows.Forms.Cursors.Default
		Me.ChkCascada.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ChkCascada.Appearance = System.Windows.Forms.Appearance.Normal
		Me.ChkCascada.TabStop = True
		Me.ChkCascada.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.ChkCascada.Visible = True
		Me.ChkCascada.Name = "ChkCascada"
		Me.Label2.Text = "Balance de Comprobacion del mes Activo"
		Me.Label2.Size = New System.Drawing.Size(243, 21)
		Me.Label2.Location = New System.Drawing.Point(86, 22)
		Me.Label2.TabIndex = 4
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
		Me.Frame1.Text = "Forma"
		Me.Frame1.Size = New System.Drawing.Size(206, 45)
		Me.Frame1.Location = New System.Drawing.Point(203, 210)
		Me.Frame1.TabIndex = 0
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me._OptForma_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._OptForma_1.Text = "Acumulado "
		Me._OptForma_1.Size = New System.Drawing.Size(84, 21)
		Me._OptForma_1.Location = New System.Drawing.Point(111, 18)
		Me._OptForma_1.TabIndex = 2
		Me._OptForma_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._OptForma_1.BackColor = System.Drawing.SystemColors.Control
		Me._OptForma_1.CausesValidation = True
		Me._OptForma_1.Enabled = True
		Me._OptForma_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._OptForma_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._OptForma_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._OptForma_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._OptForma_1.TabStop = True
		Me._OptForma_1.Checked = False
		Me._OptForma_1.Visible = True
		Me._OptForma_1.Name = "_OptForma_1"
		Me._OptForma_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._OptForma_0.Text = "Mensual "
		Me._OptForma_0.Size = New System.Drawing.Size(63, 21)
		Me._OptForma_0.Location = New System.Drawing.Point(8, 18)
		Me._OptForma_0.TabIndex = 1
		Me._OptForma_0.Visible = False
		Me._OptForma_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._OptForma_0.BackColor = System.Drawing.SystemColors.Control
		Me._OptForma_0.CausesValidation = True
		Me._OptForma_0.Enabled = True
		Me._OptForma_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._OptForma_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._OptForma_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._OptForma_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._OptForma_0.TabStop = True
		Me._OptForma_0.Checked = False
		Me._OptForma_0.Name = "_OptForma_0"
		Me.Label5.Text = "Filtro de Movimientos :"
		Me.Label5.Size = New System.Drawing.Size(105, 13)
		Me.Label5.Location = New System.Drawing.Point(9, 266)
		Me.Label5.TabIndex = 12
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label5.BackColor = System.Drawing.SystemColors.Control
		Me.Label5.Enabled = True
		Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.UseMnemonic = True
		Me.Label5.Visible = True
		Me.Label5.AutoSize = True
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.Name = "Label5"
		Me.OpTipo.SetIndex(_OpTipo_1, CType(1, Short))
		Me.OpTipo.SetIndex(_OpTipo_0, CType(0, Short))
		Me.OptForma.SetIndex(_OptForma_1, CType(1, Short))
		Me.OptForma.SetIndex(_OptForma_0, CType(0, Short))
		CType(Me.OptForma, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.OpTipo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DtCfiltro, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CtrAyu_Moneda, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DTPicker1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CtrAyu_Cuenta, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Controls.Add(Frame5)
		Me.Controls.Add(Frame4)
		Me.Controls.Add(DtCfiltro)
		Me.Controls.Add(CmdCancelar)
		Me.Controls.Add(CmdAceptar)
		Me.Controls.Add(Frame3)
		Me.Controls.Add(Frame2)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(Label5)
		Me.Frame5.Controls.Add(ChkFiltcta)
		Me.Frame5.Controls.Add(CtrAyu_Cuenta)
		Me.Frame4.Controls.Add(cmbNivel)
		Me.Frame4.Controls.Add(DTPicker1)
		Me.Frame4.Controls.Add(CtrAyu_Moneda)
		Me.Frame4.Controls.Add(Label1)
		Me.Frame4.Controls.Add(Label3)
		Me.Frame4.Controls.Add(Label4)
		Me.Frame3.Controls.Add(_OpTipo_1)
		Me.Frame3.Controls.Add(_OpTipo_0)
		Me.Frame2.Controls.Add(ChkCascada)
		Me.Frame2.Controls.Add(Label2)
		Me.Frame1.Controls.Add(_OptForma_1)
		Me.Frame1.Controls.Add(_OptForma_0)
		Me.Frame5.ResumeLayout(False)
		Me.Frame4.ResumeLayout(False)
		Me.Frame3.ResumeLayout(False)
		Me.Frame2.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class