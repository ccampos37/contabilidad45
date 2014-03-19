<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmMantPlanCuentas
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
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents lblNumReg As System.Windows.Forms.Label
	Public WithEvents TDBGrid1 As AxTrueOleDBGrid70.AxTDBGrid
	Public WithEvents _SSTab1_TabPage0 As System.Windows.Forms.TabPage
	Public WithEvents cAcepta As System.Windows.Forms.Button
	Public WithEvents _chk_5 As System.Windows.Forms.CheckBox
	Public WithEvents cboTipoAjuste As System.Windows.Forms.ComboBox
	Public WithEvents Ctr_Ayuda4 As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents cmdDistribucion As System.Windows.Forms.Button
	Public WithEvents _chk_4 As System.Windows.Forms.CheckBox
	Public WithEvents _chk_3 As System.Windows.Forms.CheckBox
	Public WithEvents _chk_1 As System.Windows.Forms.CheckBox
	Public WithEvents _chk_0 As System.Windows.Forms.CheckBox
	Public WithEvents Ctr_Ayuda1 As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents _txt_0 As AxTextFer.AxTxFer
	Public WithEvents _txt_1 As AxTextFer.AxTxFer
	Public WithEvents _txt_2 As AxTextFer.AxTxFer
	Public WithEvents _txt_3 As AxTextFer.AxTxFer
	Public WithEvents _txt_4 As AxTextFer.AxTxFer
	Public WithEvents _txt_5 As AxTextFer.AxTxFer
	Public WithEvents _txt_6 As AxTextFer.AxTxFer
	Public WithEvents _chk_2 As System.Windows.Forms.CheckBox
	Public WithEvents _lbl_16 As System.Windows.Forms.Label
	Public WithEvents _lbl_15 As System.Windows.Forms.Label
	Public WithEvents _lbl_14 As System.Windows.Forms.Label
	Public WithEvents _lbl_11 As System.Windows.Forms.Label
	Public WithEvents _lbl_10 As System.Windows.Forms.Label
	Public WithEvents lblNivel As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents _lbl_9 As System.Windows.Forms.Label
	Public WithEvents _lbl_8 As System.Windows.Forms.Label
	Public WithEvents _lbl_7 As System.Windows.Forms.Label
	Public WithEvents _lbl_6 As System.Windows.Forms.Label
	Public WithEvents _lbl_5 As System.Windows.Forms.Label
	Public WithEvents _lbl_4 As System.Windows.Forms.Label
	Public WithEvents _lbl_3 As System.Windows.Forms.Label
	Public WithEvents _lbl_2 As System.Windows.Forms.Label
	Public WithEvents _lbl_1 As System.Windows.Forms.Label
	Public WithEvents _lbl_0 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents cCancela As System.Windows.Forms.Button
	Public WithEvents _SSTab1_TabPage1 As System.Windows.Forms.TabPage
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents _lbl_12 As System.Windows.Forms.Label
	Public WithEvents _lbl_13 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents lblPorcen As System.Windows.Forms.Label
	Public WithEvents TDBGrid2 As AxTrueOleDBGrid70.AxTDBGrid
	Public WithEvents Ctr_Ayuda2 As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents Ctr_Ayuda3 As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents cmdAceptar As System.Windows.Forms.Button
	Public WithEvents txtPorcen As AxTextFer.AxTxFer
	Public WithEvents cmdSigue As System.Windows.Forms.Button
	Public WithEvents _SSTab1_TabPage2 As System.Windows.Forms.TabPage
	Public WithEvents SSTab1 As System.Windows.Forms.TabControl
	Public WithEvents _Toolbar1_Button1 As System.Windows.Forms.ToolStripButton
	Public WithEvents _Toolbar1_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents _Toolbar1_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents _Toolbar1_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents _Toolbar1_Button5 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
	Public WithEvents txtBuscar As AxTextFer.AxTxFer
	Public WithEvents ImageList1 As System.Windows.Forms.ImageList
	Public WithEvents cmdBuscar As System.Windows.Forms.Button
	Public WithEvents TreeView1 As System.Windows.Forms.TreeView
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents chk As Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray
	Public WithEvents lbl As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents txt As AxTxFerArray
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMantPlanCuentas))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.SSTab1 = New System.Windows.Forms.TabControl
		Me._SSTab1_TabPage0 = New System.Windows.Forms.TabPage
		Me.Label1 = New System.Windows.Forms.Label
		Me.lblNumReg = New System.Windows.Forms.Label
		Me.TDBGrid1 = New AxTrueOleDBGrid70.AxTDBGrid
		Me._SSTab1_TabPage1 = New System.Windows.Forms.TabPage
		Me.cAcepta = New System.Windows.Forms.Button
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me._chk_5 = New System.Windows.Forms.CheckBox
		Me.cboTipoAjuste = New System.Windows.Forms.ComboBox
		Me.Ctr_Ayuda4 = New Axctrlayuda_f.AxCtr_Ayuda
		Me.cmdDistribucion = New System.Windows.Forms.Button
		Me._chk_4 = New System.Windows.Forms.CheckBox
		Me._chk_3 = New System.Windows.Forms.CheckBox
		Me._chk_1 = New System.Windows.Forms.CheckBox
		Me._chk_0 = New System.Windows.Forms.CheckBox
		Me.Ctr_Ayuda1 = New Axctrlayuda_f.AxCtr_Ayuda
		Me._txt_0 = New AxTextFer.AxTxFer
		Me._txt_1 = New AxTextFer.AxTxFer
		Me._txt_2 = New AxTextFer.AxTxFer
		Me._txt_3 = New AxTextFer.AxTxFer
		Me._txt_4 = New AxTextFer.AxTxFer
		Me._txt_5 = New AxTextFer.AxTxFer
		Me._txt_6 = New AxTextFer.AxTxFer
		Me._chk_2 = New System.Windows.Forms.CheckBox
		Me._lbl_16 = New System.Windows.Forms.Label
		Me._lbl_15 = New System.Windows.Forms.Label
		Me._lbl_14 = New System.Windows.Forms.Label
		Me._lbl_11 = New System.Windows.Forms.Label
		Me._lbl_10 = New System.Windows.Forms.Label
		Me.lblNivel = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me._lbl_9 = New System.Windows.Forms.Label
		Me._lbl_8 = New System.Windows.Forms.Label
		Me._lbl_7 = New System.Windows.Forms.Label
		Me._lbl_6 = New System.Windows.Forms.Label
		Me._lbl_5 = New System.Windows.Forms.Label
		Me._lbl_4 = New System.Windows.Forms.Label
		Me._lbl_3 = New System.Windows.Forms.Label
		Me._lbl_2 = New System.Windows.Forms.Label
		Me._lbl_1 = New System.Windows.Forms.Label
		Me._lbl_0 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.cCancela = New System.Windows.Forms.Button
		Me._SSTab1_TabPage2 = New System.Windows.Forms.TabPage
		Me.Label4 = New System.Windows.Forms.Label
		Me._lbl_12 = New System.Windows.Forms.Label
		Me._lbl_13 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.lblPorcen = New System.Windows.Forms.Label
		Me.TDBGrid2 = New AxTrueOleDBGrid70.AxTDBGrid
		Me.Ctr_Ayuda2 = New Axctrlayuda_f.AxCtr_Ayuda
		Me.Ctr_Ayuda3 = New Axctrlayuda_f.AxCtr_Ayuda
		Me.cmdAceptar = New System.Windows.Forms.Button
		Me.txtPorcen = New AxTextFer.AxTxFer
		Me.cmdSigue = New System.Windows.Forms.Button
		Me.Toolbar1 = New System.Windows.Forms.ToolStrip
		Me._Toolbar1_Button1 = New System.Windows.Forms.ToolStripButton
		Me._Toolbar1_Button2 = New System.Windows.Forms.ToolStripButton
		Me._Toolbar1_Button3 = New System.Windows.Forms.ToolStripButton
		Me._Toolbar1_Button4 = New System.Windows.Forms.ToolStripButton
		Me._Toolbar1_Button5 = New System.Windows.Forms.ToolStripButton
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.txtBuscar = New AxTextFer.AxTxFer
		Me.ImageList1 = New System.Windows.Forms.ImageList
		Me.cmdBuscar = New System.Windows.Forms.Button
		Me.TreeView1 = New System.Windows.Forms.TreeView
		Me.chk = New Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray(components)
		Me.lbl = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.txt = New AxTxFerArray(components)
		Me.SSTab1.SuspendLayout()
		Me._SSTab1_TabPage0.SuspendLayout()
		Me._SSTab1_TabPage1.SuspendLayout()
		Me.Frame2.SuspendLayout()
		Me._SSTab1_TabPage2.SuspendLayout()
		Me.Toolbar1.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.TDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Ctr_Ayuda4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Ctr_Ayuda1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me._txt_0, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me._txt_1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me._txt_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me._txt_3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me._txt_4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me._txt_5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me._txt_6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TDBGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Ctr_Ayuda2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Ctr_Ayuda3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtPorcen, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.chk, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lbl, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txt, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Plan de Cuentas"
		Me.ClientSize = New System.Drawing.Size(764, 508)
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
		Me.Name = "frmMantPlanCuentas"
		Me.SSTab1.Size = New System.Drawing.Size(438, 439)
		Me.SSTab1.Location = New System.Drawing.Point(306, 42)
		Me.SSTab1.TabIndex = 19
		Me.SSTab1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
		Me.SSTab1.SelectedIndex = 1
		Me.SSTab1.ItemSize = New System.Drawing.Size(42, 18)
		Me.SSTab1.Name = "SSTab1"
		Me._SSTab1_TabPage0.Text = "Consulta"
		Me.Label1.Text = "Nº Registros"
		Me.Label1.Size = New System.Drawing.Size(60, 18)
		Me.Label1.Location = New System.Drawing.Point(310, 416)
		Me.Label1.TabIndex = 39
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
		Me.lblNumReg.BackColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me.lblNumReg.Text = "lblNumReg"
		Me.lblNumReg.ForeColor = System.Drawing.Color.Yellow
		Me.lblNumReg.Size = New System.Drawing.Size(61, 19)
		Me.lblNumReg.Location = New System.Drawing.Point(373, 415)
		Me.lblNumReg.TabIndex = 40
		Me.lblNumReg.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblNumReg.Enabled = True
		Me.lblNumReg.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblNumReg.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblNumReg.UseMnemonic = True
		Me.lblNumReg.Visible = True
		Me.lblNumReg.AutoSize = False
		Me.lblNumReg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblNumReg.Name = "lblNumReg"
		TDBGrid1.OcxState = CType(resources.GetObject("TDBGrid1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.TDBGrid1.Size = New System.Drawing.Size(432, 366)
		Me.TDBGrid1.Location = New System.Drawing.Point(2, 45)
		Me.TDBGrid1.TabIndex = 38
		Me.TDBGrid1.Name = "TDBGrid1"
		Me._SSTab1_TabPage1.Text = "Mantenimiento"
		Me.cAcepta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cAcepta.Text = "&Aceptar"
		Me.cAcepta.Size = New System.Drawing.Size(75, 24)
		Me.cAcepta.Location = New System.Drawing.Point(134, 382)
		Me.cAcepta.TabIndex = 37
		Me.cAcepta.BackColor = System.Drawing.SystemColors.Control
		Me.cAcepta.CausesValidation = True
		Me.cAcepta.Enabled = True
		Me.cAcepta.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cAcepta.Cursor = System.Windows.Forms.Cursors.Default
		Me.cAcepta.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cAcepta.TabStop = True
		Me.cAcepta.Name = "cAcepta"
		Me.Frame2.Size = New System.Drawing.Size(432, 332)
		Me.Frame2.Location = New System.Drawing.Point(2, 42)
		Me.Frame2.TabIndex = 21
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame2.Name = "Frame2"
		Me._chk_5.Size = New System.Drawing.Size(14, 13)
		Me._chk_5.Location = New System.Drawing.Point(182, 312)
		Me._chk_5.TabIndex = 56
		Me._chk_5.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chk_5.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chk_5.BackColor = System.Drawing.SystemColors.Control
		Me._chk_5.Text = ""
		Me._chk_5.CausesValidation = True
		Me._chk_5.Enabled = True
		Me._chk_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chk_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._chk_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chk_5.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chk_5.TabStop = True
		Me._chk_5.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chk_5.Visible = True
		Me._chk_5.Name = "_chk_5"
		Me.cboTipoAjuste.Size = New System.Drawing.Size(246, 21)
		Me.cboTipoAjuste.Location = New System.Drawing.Point(182, 175)
		Me.cboTipoAjuste.Items.AddRange(New Object(){"00 - Ninguno", "01 - Ajuste Diferencia Cambio", "02 - Ajuste ACM"})
		Me.cboTipoAjuste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboTipoAjuste.TabIndex = 8
		Me.cboTipoAjuste.BackColor = System.Drawing.SystemColors.Window
		Me.cboTipoAjuste.CausesValidation = True
		Me.cboTipoAjuste.Enabled = True
		Me.cboTipoAjuste.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboTipoAjuste.IntegralHeight = True
		Me.cboTipoAjuste.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboTipoAjuste.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboTipoAjuste.Sorted = False
		Me.cboTipoAjuste.TabStop = True
		Me.cboTipoAjuste.Visible = True
		Me.cboTipoAjuste.Name = "cboTipoAjuste"
		Ctr_Ayuda4.OcxState = CType(resources.GetObject("Ctr_Ayuda4.OcxState"), System.Windows.Forms.AxHost.State)
		Me.Ctr_Ayuda4.Size = New System.Drawing.Size(244, 22)
		Me.Ctr_Ayuda4.Location = New System.Drawing.Point(183, 154)
		Me.Ctr_Ayuda4.TabIndex = 7
		Me.Ctr_Ayuda4.Name = "Ctr_Ayuda4"
		Me.cmdDistribucion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdDistribucion.Text = "..."
		Me.cmdDistribucion.Size = New System.Drawing.Size(17, 14)
		Me.cmdDistribucion.Location = New System.Drawing.Point(199, 274)
		Me.cmdDistribucion.TabIndex = 15
		Me.cmdDistribucion.BackColor = System.Drawing.SystemColors.Control
		Me.cmdDistribucion.CausesValidation = True
		Me.cmdDistribucion.Enabled = True
		Me.cmdDistribucion.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdDistribucion.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdDistribucion.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdDistribucion.TabStop = True
		Me.cmdDistribucion.Name = "cmdDistribucion"
		Me._chk_4.Size = New System.Drawing.Size(14, 13)
		Me._chk_4.Location = New System.Drawing.Point(182, 293)
		Me._chk_4.TabIndex = 14
		Me._chk_4.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chk_4.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chk_4.BackColor = System.Drawing.SystemColors.Control
		Me._chk_4.Text = ""
		Me._chk_4.CausesValidation = True
		Me._chk_4.Enabled = True
		Me._chk_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chk_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._chk_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chk_4.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chk_4.TabStop = True
		Me._chk_4.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chk_4.Visible = True
		Me._chk_4.Name = "_chk_4"
		Me._chk_3.Size = New System.Drawing.Size(13, 13)
		Me._chk_3.Location = New System.Drawing.Point(182, 274)
		Me._chk_3.TabIndex = 13
		Me._chk_3.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chk_3.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chk_3.BackColor = System.Drawing.SystemColors.Control
		Me._chk_3.Text = ""
		Me._chk_3.CausesValidation = True
		Me._chk_3.Enabled = True
		Me._chk_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chk_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._chk_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chk_3.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chk_3.TabStop = True
		Me._chk_3.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chk_3.Visible = True
		Me._chk_3.Name = "_chk_3"
		Me._chk_1.Size = New System.Drawing.Size(19, 13)
		Me._chk_1.Location = New System.Drawing.Point(182, 238)
		Me._chk_1.TabIndex = 11
		Me._chk_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chk_1.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chk_1.BackColor = System.Drawing.SystemColors.Control
		Me._chk_1.Text = ""
		Me._chk_1.CausesValidation = True
		Me._chk_1.Enabled = True
		Me._chk_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chk_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._chk_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chk_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chk_1.TabStop = True
		Me._chk_1.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chk_1.Visible = True
		Me._chk_1.Name = "_chk_1"
		Me._chk_0.Size = New System.Drawing.Size(15, 14)
		Me._chk_0.Location = New System.Drawing.Point(182, 199)
		Me._chk_0.TabIndex = 9
		Me._chk_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chk_0.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chk_0.BackColor = System.Drawing.SystemColors.Control
		Me._chk_0.Text = ""
		Me._chk_0.CausesValidation = True
		Me._chk_0.Enabled = True
		Me._chk_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chk_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._chk_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chk_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chk_0.TabStop = True
		Me._chk_0.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chk_0.Visible = True
		Me._chk_0.Name = "_chk_0"
		Ctr_Ayuda1.OcxState = CType(resources.GetObject("Ctr_Ayuda1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.Ctr_Ayuda1.Size = New System.Drawing.Size(244, 21)
		Me.Ctr_Ayuda1.Location = New System.Drawing.Point(182, 212)
		Me.Ctr_Ayuda1.TabIndex = 10
		Me.Ctr_Ayuda1.Name = "Ctr_Ayuda1"
		_txt_0.OcxState = CType(resources.GetObject("_txt_0.OcxState"), System.Windows.Forms.AxHost.State)
		Me._txt_0.Size = New System.Drawing.Size(116, 20)
		Me._txt_0.Location = New System.Drawing.Point(183, 10)
		Me._txt_0.TabIndex = 0
		Me._txt_0.CausesValidation = -1
		Me._txt_0.Name = "_txt_0"
		_txt_1.OcxState = CType(resources.GetObject("_txt_1.OcxState"), System.Windows.Forms.AxHost.State)
		Me._txt_1.Size = New System.Drawing.Size(242, 20)
		Me._txt_1.Location = New System.Drawing.Point(183, 32)
		Me._txt_1.TabIndex = 1
		Me._txt_1.CausesValidation = -1
		Me._txt_1.Name = "_txt_1"
		_txt_2.OcxState = CType(resources.GetObject("_txt_2.OcxState"), System.Windows.Forms.AxHost.State)
		Me._txt_2.Size = New System.Drawing.Size(242, 20)
		Me._txt_2.Location = New System.Drawing.Point(183, 54)
		Me._txt_2.TabIndex = 2
		Me._txt_2.CausesValidation = -1
		Me._txt_2.Name = "_txt_2"
		_txt_3.OcxState = CType(resources.GetObject("_txt_3.OcxState"), System.Windows.Forms.AxHost.State)
		Me._txt_3.Size = New System.Drawing.Size(242, 20)
		Me._txt_3.Location = New System.Drawing.Point(183, 74)
		Me._txt_3.TabIndex = 3
		Me._txt_3.CausesValidation = -1
		Me._txt_3.Name = "_txt_3"
		_txt_4.OcxState = CType(resources.GetObject("_txt_4.OcxState"), System.Windows.Forms.AxHost.State)
		Me._txt_4.Size = New System.Drawing.Size(55, 20)
		Me._txt_4.Location = New System.Drawing.Point(182, 94)
		Me._txt_4.TabIndex = 4
		Me._txt_4.CausesValidation = -1
		Me._txt_4.Name = "_txt_4"
		_txt_5.OcxState = CType(resources.GetObject("_txt_5.OcxState"), System.Windows.Forms.AxHost.State)
		Me._txt_5.Size = New System.Drawing.Size(242, 20)
		Me._txt_5.Location = New System.Drawing.Point(182, 114)
		Me._txt_5.TabIndex = 5
		Me._txt_5.CausesValidation = -1
		Me._txt_5.Name = "_txt_5"
		_txt_6.OcxState = CType(resources.GetObject("_txt_6.OcxState"), System.Windows.Forms.AxHost.State)
		Me._txt_6.Size = New System.Drawing.Size(55, 20)
		Me._txt_6.Location = New System.Drawing.Point(182, 134)
		Me._txt_6.TabIndex = 6
		Me._txt_6.CausesValidation = -1
		Me._txt_6.Name = "_txt_6"
		Me._chk_2.Size = New System.Drawing.Size(16, 13)
		Me._chk_2.Location = New System.Drawing.Point(182, 256)
		Me._chk_2.TabIndex = 12
		Me._chk_2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chk_2.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me._chk_2.BackColor = System.Drawing.SystemColors.Control
		Me._chk_2.Text = ""
		Me._chk_2.CausesValidation = True
		Me._chk_2.Enabled = True
		Me._chk_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chk_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._chk_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chk_2.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chk_2.TabStop = True
		Me._chk_2.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chk_2.Visible = True
		Me._chk_2.Name = "_chk_2"
		Me._lbl_16.Text = "Adiciona Cargo"
		Me._lbl_16.Size = New System.Drawing.Size(155, 16)
		Me._lbl_16.Location = New System.Drawing.Point(10, 310)
		Me._lbl_16.TabIndex = 57
		Me._lbl_16.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lbl_16.BackColor = System.Drawing.SystemColors.Control
		Me._lbl_16.Enabled = True
		Me._lbl_16.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lbl_16.Cursor = System.Windows.Forms.Cursors.Default
		Me._lbl_16.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lbl_16.UseMnemonic = True
		Me._lbl_16.Visible = True
		Me._lbl_16.AutoSize = False
		Me._lbl_16.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lbl_16.Name = "_lbl_16"
		Me._lbl_15.Text = "Tipo de Ajuste"
		Me._lbl_15.Size = New System.Drawing.Size(155, 16)
		Me._lbl_15.Location = New System.Drawing.Point(9, 180)
		Me._lbl_15.TabIndex = 55
		Me._lbl_15.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lbl_15.BackColor = System.Drawing.SystemColors.Control
		Me._lbl_15.Enabled = True
		Me._lbl_15.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lbl_15.Cursor = System.Windows.Forms.Cursors.Default
		Me._lbl_15.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lbl_15.UseMnemonic = True
		Me._lbl_15.Visible = True
		Me._lbl_15.AutoSize = False
		Me._lbl_15.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lbl_15.Name = "_lbl_15"
		Me._lbl_14.Text = "Tipo Cuenta"
		Me._lbl_14.Size = New System.Drawing.Size(155, 16)
		Me._lbl_14.Location = New System.Drawing.Point(9, 160)
		Me._lbl_14.TabIndex = 53
		Me._lbl_14.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lbl_14.BackColor = System.Drawing.SystemColors.Control
		Me._lbl_14.Enabled = True
		Me._lbl_14.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lbl_14.Cursor = System.Windows.Forms.Cursors.Default
		Me._lbl_14.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lbl_14.UseMnemonic = True
		Me._lbl_14.Visible = True
		Me._lbl_14.AutoSize = False
		Me._lbl_14.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lbl_14.Name = "_lbl_14"
		Me._lbl_11.Text = "Cuenta Activa"
		Me._lbl_11.Size = New System.Drawing.Size(155, 16)
		Me._lbl_11.Location = New System.Drawing.Point(10, 294)
		Me._lbl_11.TabIndex = 45
		Me._lbl_11.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lbl_11.BackColor = System.Drawing.SystemColors.Control
		Me._lbl_11.Enabled = True
		Me._lbl_11.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lbl_11.Cursor = System.Windows.Forms.Cursors.Default
		Me._lbl_11.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lbl_11.UseMnemonic = True
		Me._lbl_11.Visible = True
		Me._lbl_11.AutoSize = False
		Me._lbl_11.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lbl_11.Name = "_lbl_11"
		Me._lbl_10.Text = "Asiento Automático"
		Me._lbl_10.Size = New System.Drawing.Size(155, 16)
		Me._lbl_10.Location = New System.Drawing.Point(10, 276)
		Me._lbl_10.TabIndex = 44
		Me._lbl_10.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lbl_10.BackColor = System.Drawing.SystemColors.Control
		Me._lbl_10.Enabled = True
		Me._lbl_10.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lbl_10.Cursor = System.Windows.Forms.Cursors.Default
		Me._lbl_10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lbl_10.UseMnemonic = True
		Me._lbl_10.Visible = True
		Me._lbl_10.AutoSize = False
		Me._lbl_10.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lbl_10.Name = "_lbl_10"
		Me.lblNivel.Size = New System.Drawing.Size(40, 18)
		Me.lblNivel.Location = New System.Drawing.Point(384, 12)
		Me.lblNivel.TabIndex = 43
		Me.lblNivel.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblNivel.BackColor = System.Drawing.SystemColors.Control
		Me.lblNivel.Enabled = True
		Me.lblNivel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblNivel.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblNivel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblNivel.UseMnemonic = True
		Me.lblNivel.Visible = True
		Me.lblNivel.AutoSize = False
		Me.lblNivel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblNivel.Name = "lblNivel"
		Me.Label3.Text = "Nivel Cuenta"
		Me.Label3.Size = New System.Drawing.Size(63, 18)
		Me.Label3.Location = New System.Drawing.Point(314, 14)
		Me.Label3.TabIndex = 42
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
		Me._lbl_9.Text = "Controla Documento"
		Me._lbl_9.Size = New System.Drawing.Size(155, 16)
		Me._lbl_9.Location = New System.Drawing.Point(10, 257)
		Me._lbl_9.TabIndex = 41
		Me._lbl_9.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lbl_9.BackColor = System.Drawing.SystemColors.Control
		Me._lbl_9.Enabled = True
		Me._lbl_9.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lbl_9.Cursor = System.Windows.Forms.Cursors.Default
		Me._lbl_9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lbl_9.UseMnemonic = True
		Me._lbl_9.Visible = True
		Me._lbl_9.AutoSize = False
		Me._lbl_9.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lbl_9.Name = "_lbl_9"
		Me._lbl_8.Text = "Controla Centro Costo"
		Me._lbl_8.Size = New System.Drawing.Size(171, 16)
		Me._lbl_8.Location = New System.Drawing.Point(10, 238)
		Me._lbl_8.TabIndex = 35
		Me._lbl_8.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lbl_8.BackColor = System.Drawing.SystemColors.Control
		Me._lbl_8.Enabled = True
		Me._lbl_8.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lbl_8.Cursor = System.Windows.Forms.Cursors.Default
		Me._lbl_8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lbl_8.UseMnemonic = True
		Me._lbl_8.Visible = True
		Me._lbl_8.AutoSize = False
		Me._lbl_8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lbl_8.Name = "_lbl_8"
		Me._lbl_7.Text = "Tipo Analítico"
		Me._lbl_7.Size = New System.Drawing.Size(170, 13)
		Me._lbl_7.Location = New System.Drawing.Point(9, 219)
		Me._lbl_7.TabIndex = 34
		Me._lbl_7.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lbl_7.BackColor = System.Drawing.SystemColors.Control
		Me._lbl_7.Enabled = True
		Me._lbl_7.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lbl_7.Cursor = System.Windows.Forms.Cursors.Default
		Me._lbl_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lbl_7.UseMnemonic = True
		Me._lbl_7.Visible = True
		Me._lbl_7.AutoSize = False
		Me._lbl_7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lbl_7.Name = "_lbl_7"
		Me._lbl_6.Text = "Controla Código Análisis"
		Me._lbl_6.Size = New System.Drawing.Size(170, 22)
		Me._lbl_6.Location = New System.Drawing.Point(9, 200)
		Me._lbl_6.TabIndex = 33
		Me._lbl_6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lbl_6.BackColor = System.Drawing.SystemColors.Control
		Me._lbl_6.Enabled = True
		Me._lbl_6.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lbl_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._lbl_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lbl_6.UseMnemonic = True
		Me._lbl_6.Visible = True
		Me._lbl_6.AutoSize = False
		Me._lbl_6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lbl_6.Name = "_lbl_6"
		Me._lbl_5.Text = "Naturaleza de Estado Gan. y Pérd."
		Me._lbl_5.Size = New System.Drawing.Size(170, 22)
		Me._lbl_5.Location = New System.Drawing.Point(9, 141)
		Me._lbl_5.TabIndex = 32
		Me._lbl_5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lbl_5.BackColor = System.Drawing.SystemColors.Control
		Me._lbl_5.Enabled = True
		Me._lbl_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lbl_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._lbl_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lbl_5.UseMnemonic = True
		Me._lbl_5.Visible = True
		Me._lbl_5.AutoSize = False
		Me._lbl_5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lbl_5.Name = "_lbl_5"
		Me._lbl_4.Text = "Línea de Estado de Gan. y Pérd."
		Me._lbl_4.Size = New System.Drawing.Size(170, 22)
		Me._lbl_4.Location = New System.Drawing.Point(9, 121)
		Me._lbl_4.TabIndex = 31
		Me._lbl_4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lbl_4.BackColor = System.Drawing.SystemColors.Control
		Me._lbl_4.Enabled = True
		Me._lbl_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lbl_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._lbl_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lbl_4.UseMnemonic = True
		Me._lbl_4.Visible = True
		Me._lbl_4.AutoSize = False
		Me._lbl_4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lbl_4.Name = "_lbl_4"
		Me._lbl_3.Text = "Naturaleza de Balance"
		Me._lbl_3.Size = New System.Drawing.Size(170, 22)
		Me._lbl_3.Location = New System.Drawing.Point(9, 100)
		Me._lbl_3.TabIndex = 30
		Me._lbl_3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lbl_3.BackColor = System.Drawing.SystemColors.Control
		Me._lbl_3.Enabled = True
		Me._lbl_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lbl_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._lbl_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lbl_3.UseMnemonic = True
		Me._lbl_3.Visible = True
		Me._lbl_3.AutoSize = False
		Me._lbl_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lbl_3.Name = "_lbl_3"
		Me._lbl_2.Text = "Línea de Balance de Pasivo"
		Me._lbl_2.Size = New System.Drawing.Size(170, 22)
		Me._lbl_2.Location = New System.Drawing.Point(9, 80)
		Me._lbl_2.TabIndex = 29
		Me._lbl_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lbl_2.BackColor = System.Drawing.SystemColors.Control
		Me._lbl_2.Enabled = True
		Me._lbl_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lbl_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._lbl_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lbl_2.UseMnemonic = True
		Me._lbl_2.Visible = True
		Me._lbl_2.AutoSize = False
		Me._lbl_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lbl_2.Name = "_lbl_2"
		Me._lbl_1.Text = "Línea de Balance de Activo"
		Me._lbl_1.Size = New System.Drawing.Size(170, 22)
		Me._lbl_1.Location = New System.Drawing.Point(9, 60)
		Me._lbl_1.TabIndex = 28
		Me._lbl_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lbl_1.BackColor = System.Drawing.SystemColors.Control
		Me._lbl_1.Enabled = True
		Me._lbl_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lbl_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lbl_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lbl_1.UseMnemonic = True
		Me._lbl_1.Visible = True
		Me._lbl_1.AutoSize = False
		Me._lbl_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lbl_1.Name = "_lbl_1"
		Me._lbl_0.Text = "Descripción Cuenta"
		Me._lbl_0.Size = New System.Drawing.Size(170, 15)
		Me._lbl_0.Location = New System.Drawing.Point(9, 38)
		Me._lbl_0.TabIndex = 27
		Me._lbl_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lbl_0.BackColor = System.Drawing.SystemColors.Control
		Me._lbl_0.Enabled = True
		Me._lbl_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lbl_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lbl_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lbl_0.UseMnemonic = True
		Me._lbl_0.Visible = True
		Me._lbl_0.AutoSize = False
		Me._lbl_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lbl_0.Name = "_lbl_0"
		Me.Label2.Text = "Código Cuenta"
		Me.Label2.Size = New System.Drawing.Size(170, 21)
		Me.Label2.Location = New System.Drawing.Point(9, 16)
		Me.Label2.TabIndex = 26
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
		Me.cCancela.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cCancela.Text = "&Cancelar"
		Me.cCancela.Size = New System.Drawing.Size(75, 24)
		Me.cCancela.Location = New System.Drawing.Point(253, 382)
		Me.cCancela.TabIndex = 36
		Me.cCancela.BackColor = System.Drawing.SystemColors.Control
		Me.cCancela.CausesValidation = True
		Me.cCancela.Enabled = True
		Me.cCancela.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cCancela.Cursor = System.Windows.Forms.Cursors.Default
		Me.cCancela.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cCancela.TabStop = True
		Me.cCancela.Name = "cCancela"
		Me._SSTab1_TabPage2.Text = "Cuentas Distribución"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label4.BackColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me.Label4.Text = "Porcentaje de Distribución (%)"
		Me.Label4.ForeColor = System.Drawing.Color.FromARGB(255, 255, 128)
		Me.Label4.Size = New System.Drawing.Size(193, 20)
		Me.Label4.Location = New System.Drawing.Point(3, 174)
		Me.Label4.TabIndex = 47
		Me.Label4.Enabled = True
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.Visible = True
		Me.Label4.AutoSize = False
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Label4.Name = "Label4"
		Me._lbl_12.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._lbl_12.Text = "Seleccionar Cuenta al Abono"
		Me._lbl_12.Size = New System.Drawing.Size(273, 17)
		Me._lbl_12.Location = New System.Drawing.Point(11, 109)
		Me._lbl_12.TabIndex = 48
		Me._lbl_12.BackColor = System.Drawing.SystemColors.Control
		Me._lbl_12.Enabled = True
		Me._lbl_12.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lbl_12.Cursor = System.Windows.Forms.Cursors.Default
		Me._lbl_12.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lbl_12.UseMnemonic = True
		Me._lbl_12.Visible = True
		Me._lbl_12.AutoSize = False
		Me._lbl_12.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lbl_12.Name = "_lbl_12"
		Me._lbl_13.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._lbl_13.Text = "Seleccionar Cuenta al Cargo"
		Me._lbl_13.Size = New System.Drawing.Size(269, 17)
		Me._lbl_13.Location = New System.Drawing.Point(14, 60)
		Me._lbl_13.TabIndex = 49
		Me._lbl_13.BackColor = System.Drawing.SystemColors.Control
		Me._lbl_13.Enabled = True
		Me._lbl_13.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lbl_13.Cursor = System.Windows.Forms.Cursors.Default
		Me._lbl_13.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lbl_13.UseMnemonic = True
		Me._lbl_13.Visible = True
		Me._lbl_13.AutoSize = False
		Me._lbl_13.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lbl_13.Name = "_lbl_13"
		Me.Label5.Text = "Total (%)"
		Me.Label5.Size = New System.Drawing.Size(51, 17)
		Me.Label5.Location = New System.Drawing.Point(304, 316)
		Me.Label5.TabIndex = 50
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label5.BackColor = System.Drawing.SystemColors.Control
		Me.Label5.Enabled = True
		Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.UseMnemonic = True
		Me.Label5.Visible = True
		Me.Label5.AutoSize = False
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.Name = "Label5"
		Me.lblPorcen.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.lblPorcen.Size = New System.Drawing.Size(81, 20)
		Me.lblPorcen.Location = New System.Drawing.Point(353, 313)
		Me.lblPorcen.TabIndex = 51
		Me.lblPorcen.BackColor = System.Drawing.SystemColors.Control
		Me.lblPorcen.Enabled = True
		Me.lblPorcen.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPorcen.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPorcen.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPorcen.UseMnemonic = True
		Me.lblPorcen.Visible = True
		Me.lblPorcen.AutoSize = False
		Me.lblPorcen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblPorcen.Name = "lblPorcen"
		TDBGrid2.OcxState = CType(resources.GetObject("TDBGrid2.OcxState"), System.Windows.Forms.AxHost.State)
		Me.TDBGrid2.Size = New System.Drawing.Size(432, 109)
		Me.TDBGrid2.Location = New System.Drawing.Point(2, 201)
		Me.TDBGrid2.TabIndex = 46
		Me.TDBGrid2.Name = "TDBGrid2"
		Ctr_Ayuda2.OcxState = CType(resources.GetObject("Ctr_Ayuda2.OcxState"), System.Windows.Forms.AxHost.State)
		Me.Ctr_Ayuda2.Size = New System.Drawing.Size(290, 23)
		Me.Ctr_Ayuda2.Location = New System.Drawing.Point(11, 77)
		Me.Ctr_Ayuda2.TabIndex = 22
		Me.Ctr_Ayuda2.Name = "Ctr_Ayuda2"
		Ctr_Ayuda3.OcxState = CType(resources.GetObject("Ctr_Ayuda3.OcxState"), System.Windows.Forms.AxHost.State)
		Me.Ctr_Ayuda3.Size = New System.Drawing.Size(292, 30)
		Me.Ctr_Ayuda3.Location = New System.Drawing.Point(10, 125)
		Me.Ctr_Ayuda3.TabIndex = 23
		Me.Ctr_Ayuda3.Name = "Ctr_Ayuda3"
		Me.cmdAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdAceptar.Text = "..."
		Me.cmdAceptar.Size = New System.Drawing.Size(18, 20)
		Me.cmdAceptar.Location = New System.Drawing.Point(285, 174)
		Me.cmdAceptar.TabIndex = 25
		Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
		Me.cmdAceptar.CausesValidation = True
		Me.cmdAceptar.Enabled = True
		Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdAceptar.TabStop = True
		Me.cmdAceptar.Name = "cmdAceptar"
		txtPorcen.OcxState = CType(resources.GetObject("txtPorcen.OcxState"), System.Windows.Forms.AxHost.State)
		Me.txtPorcen.Size = New System.Drawing.Size(87, 21)
		Me.txtPorcen.Location = New System.Drawing.Point(195, 173)
		Me.txtPorcen.TabIndex = 24
		Me.txtPorcen.CausesValidation = -1
		Me.txtPorcen.Name = "txtPorcen"
		Me.cmdSigue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdSigue.Text = "&Aceptar"
		Me.cmdSigue.Size = New System.Drawing.Size(75, 24)
		Me.cmdSigue.Location = New System.Drawing.Point(168, 345)
		Me.cmdSigue.TabIndex = 52
		Me.cmdSigue.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSigue.CausesValidation = True
		Me.cmdSigue.Enabled = True
		Me.cmdSigue.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSigue.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSigue.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSigue.TabStop = True
		Me.cmdSigue.Name = "cmdSigue"
		Me.Toolbar1.ShowItemToolTips = True
		Me.Toolbar1.Dock = System.Windows.Forms.DockStyle.Top
		Me.Toolbar1.Size = New System.Drawing.Size(764, 40)
		Me.Toolbar1.Location = New System.Drawing.Point(0, 0)
		Me.Toolbar1.TabIndex = 18
		Me.Toolbar1.Name = "Toolbar1"
		Me._Toolbar1_Button1.Size = New System.Drawing.Size(64, 39)
		Me._Toolbar1_Button1.AutoSize = False
		Me._Toolbar1_Button1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._Toolbar1_Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._Toolbar1_Button1.Text = "&Nuevo"
		Me._Toolbar1_Button1.ToolTipText = "Añadir registro al Plan Cuentas"
		Me._Toolbar1_Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._Toolbar1_Button2.Size = New System.Drawing.Size(64, 39)
		Me._Toolbar1_Button2.AutoSize = False
		Me._Toolbar1_Button2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._Toolbar1_Button2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._Toolbar1_Button2.Text = "E&ditar"
		Me._Toolbar1_Button2.ToolTipText = "Modificar Plan de Cuentas"
		Me._Toolbar1_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._Toolbar1_Button3.Size = New System.Drawing.Size(64, 39)
		Me._Toolbar1_Button3.AutoSize = False
		Me._Toolbar1_Button3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._Toolbar1_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._Toolbar1_Button3.Text = "&Eliminar"
		Me._Toolbar1_Button3.ToolTipText = "Eliminar Plan de Cuentas"
		Me._Toolbar1_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._Toolbar1_Button4.Size = New System.Drawing.Size(64, 39)
		Me._Toolbar1_Button4.AutoSize = False
		Me._Toolbar1_Button4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._Toolbar1_Button4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._Toolbar1_Button4.Text = "&Imprimir"
		Me._Toolbar1_Button4.ToolTipText = "Listar Plan de Cuentas"
		Me._Toolbar1_Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._Toolbar1_Button5.Size = New System.Drawing.Size(64, 39)
		Me._Toolbar1_Button5.AutoSize = False
		Me._Toolbar1_Button5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Me._Toolbar1_Button5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me._Toolbar1_Button5.Text = "&Salir"
		Me._Toolbar1_Button5.ToolTipText = "Cerrar la Ventana "
		Me._Toolbar1_Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Frame1.Size = New System.Drawing.Size(305, 487)
		Me.Frame1.Location = New System.Drawing.Point(-1, -7)
		Me.Frame1.TabIndex = 16
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		txtBuscar.OcxState = CType(resources.GetObject("txtBuscar.OcxState"), System.Windows.Forms.AxHost.State)
		Me.txtBuscar.Size = New System.Drawing.Size(280, 20)
		Me.txtBuscar.Location = New System.Drawing.Point(3, 51)
		Me.txtBuscar.TabIndex = 54
		Me.txtBuscar.CausesValidation = -1
		Me.txtBuscar.Name = "txtBuscar"
		Me.ImageList1.ImageSize = New System.Drawing.Size(13, 13)
		Me.ImageList1.TransparentColor = System.Drawing.Color.FromARGB(192, 192, 192)
		Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.cmdBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdBuscar.Text = "..."
		Me.cmdBuscar.Enabled = False
		Me.cmdBuscar.Size = New System.Drawing.Size(19, 20)
		Me.cmdBuscar.Location = New System.Drawing.Point(284, 52)
		Me.cmdBuscar.TabIndex = 20
		Me.cmdBuscar.BackColor = System.Drawing.SystemColors.Control
		Me.cmdBuscar.CausesValidation = True
		Me.cmdBuscar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdBuscar.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdBuscar.TabStop = True
		Me.cmdBuscar.Name = "cmdBuscar"
		Me.TreeView1.CausesValidation = True
		Me.TreeView1.Size = New System.Drawing.Size(299, 414)
		Me.TreeView1.Location = New System.Drawing.Point(3, 72)
		Me.TreeView1.TabIndex = 17
		Me.TreeView1.HideSelection = False
		Me.TreeView1.Indent = 24
		Me.TreeView1.LabelEdit = False
		Me.TreeView1.ImageList = ImageList1
		Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TreeView1.Name = "TreeView1"
		Me.chk.SetIndex(_chk_5, CType(5, Short))
		Me.chk.SetIndex(_chk_4, CType(4, Short))
		Me.chk.SetIndex(_chk_3, CType(3, Short))
		Me.chk.SetIndex(_chk_1, CType(1, Short))
		Me.chk.SetIndex(_chk_0, CType(0, Short))
		Me.chk.SetIndex(_chk_2, CType(2, Short))
		Me.lbl.SetIndex(_lbl_16, CType(16, Short))
		Me.lbl.SetIndex(_lbl_15, CType(15, Short))
		Me.lbl.SetIndex(_lbl_14, CType(14, Short))
		Me.lbl.SetIndex(_lbl_11, CType(11, Short))
		Me.lbl.SetIndex(_lbl_10, CType(10, Short))
		Me.lbl.SetIndex(_lbl_9, CType(9, Short))
		Me.lbl.SetIndex(_lbl_8, CType(8, Short))
		Me.lbl.SetIndex(_lbl_7, CType(7, Short))
		Me.lbl.SetIndex(_lbl_6, CType(6, Short))
		Me.lbl.SetIndex(_lbl_5, CType(5, Short))
		Me.lbl.SetIndex(_lbl_4, CType(4, Short))
		Me.lbl.SetIndex(_lbl_3, CType(3, Short))
		Me.lbl.SetIndex(_lbl_2, CType(2, Short))
		Me.lbl.SetIndex(_lbl_1, CType(1, Short))
		Me.lbl.SetIndex(_lbl_0, CType(0, Short))
		Me.lbl.SetIndex(_lbl_13, CType(13, Short))
		Me.lbl.SetIndex(_lbl_12, CType(12, Short))
		Me.txt.SetIndex(_txt_0, CType(0, Short))
		Me.txt.SetIndex(_txt_1, CType(1, Short))
		Me.txt.SetIndex(_txt_2, CType(2, Short))
		Me.txt.SetIndex(_txt_3, CType(3, Short))
		Me.txt.SetIndex(_txt_4, CType(4, Short))
		Me.txt.SetIndex(_txt_5, CType(5, Short))
		Me.txt.SetIndex(_txt_6, CType(6, Short))
		CType(Me.txt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lbl, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.chk, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtBuscar, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtPorcen, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Ctr_Ayuda3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Ctr_Ayuda2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TDBGrid2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me._txt_6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me._txt_5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me._txt_4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me._txt_3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me._txt_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me._txt_1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me._txt_0, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Ctr_Ayuda1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Ctr_Ayuda4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Controls.Add(SSTab1)
		Me.Controls.Add(Toolbar1)
		Me.Controls.Add(Frame1)
		Me.SSTab1.Controls.Add(_SSTab1_TabPage0)
		Me.SSTab1.Controls.Add(_SSTab1_TabPage1)
		Me.SSTab1.Controls.Add(_SSTab1_TabPage2)
		Me._SSTab1_TabPage0.Controls.Add(Label1)
		Me._SSTab1_TabPage0.Controls.Add(lblNumReg)
		Me._SSTab1_TabPage0.Controls.Add(TDBGrid1)
		Me._SSTab1_TabPage1.Controls.Add(cAcepta)
		Me._SSTab1_TabPage1.Controls.Add(Frame2)
		Me._SSTab1_TabPage1.Controls.Add(cCancela)
		Me.Frame2.Controls.Add(_chk_5)
		Me.Frame2.Controls.Add(cboTipoAjuste)
		Me.Frame2.Controls.Add(Ctr_Ayuda4)
		Me.Frame2.Controls.Add(cmdDistribucion)
		Me.Frame2.Controls.Add(_chk_4)
		Me.Frame2.Controls.Add(_chk_3)
		Me.Frame2.Controls.Add(_chk_1)
		Me.Frame2.Controls.Add(_chk_0)
		Me.Frame2.Controls.Add(Ctr_Ayuda1)
		Me.Frame2.Controls.Add(_txt_0)
		Me.Frame2.Controls.Add(_txt_1)
		Me.Frame2.Controls.Add(_txt_2)
		Me.Frame2.Controls.Add(_txt_3)
		Me.Frame2.Controls.Add(_txt_4)
		Me.Frame2.Controls.Add(_txt_5)
		Me.Frame2.Controls.Add(_txt_6)
		Me.Frame2.Controls.Add(_chk_2)
		Me.Frame2.Controls.Add(_lbl_16)
		Me.Frame2.Controls.Add(_lbl_15)
		Me.Frame2.Controls.Add(_lbl_14)
		Me.Frame2.Controls.Add(_lbl_11)
		Me.Frame2.Controls.Add(_lbl_10)
		Me.Frame2.Controls.Add(lblNivel)
		Me.Frame2.Controls.Add(Label3)
		Me.Frame2.Controls.Add(_lbl_9)
		Me.Frame2.Controls.Add(_lbl_8)
		Me.Frame2.Controls.Add(_lbl_7)
		Me.Frame2.Controls.Add(_lbl_6)
		Me.Frame2.Controls.Add(_lbl_5)
		Me.Frame2.Controls.Add(_lbl_4)
		Me.Frame2.Controls.Add(_lbl_3)
		Me.Frame2.Controls.Add(_lbl_2)
		Me.Frame2.Controls.Add(_lbl_1)
		Me.Frame2.Controls.Add(_lbl_0)
		Me.Frame2.Controls.Add(Label2)
		Me._SSTab1_TabPage2.Controls.Add(Label4)
		Me._SSTab1_TabPage2.Controls.Add(_lbl_12)
		Me._SSTab1_TabPage2.Controls.Add(_lbl_13)
		Me._SSTab1_TabPage2.Controls.Add(Label5)
		Me._SSTab1_TabPage2.Controls.Add(lblPorcen)
		Me._SSTab1_TabPage2.Controls.Add(TDBGrid2)
		Me._SSTab1_TabPage2.Controls.Add(Ctr_Ayuda2)
		Me._SSTab1_TabPage2.Controls.Add(Ctr_Ayuda3)
		Me._SSTab1_TabPage2.Controls.Add(cmdAceptar)
		Me._SSTab1_TabPage2.Controls.Add(txtPorcen)
		Me._SSTab1_TabPage2.Controls.Add(cmdSigue)
		Me.Toolbar1.Items.Add(_Toolbar1_Button1)
		Me.Toolbar1.Items.Add(_Toolbar1_Button2)
		Me.Toolbar1.Items.Add(_Toolbar1_Button3)
		Me.Toolbar1.Items.Add(_Toolbar1_Button4)
		Me.Toolbar1.Items.Add(_Toolbar1_Button5)
		Me.Frame1.Controls.Add(txtBuscar)
		Me.Frame1.Controls.Add(cmdBuscar)
		Me.Frame1.Controls.Add(TreeView1)
		Me.SSTab1.ResumeLayout(False)
		Me._SSTab1_TabPage0.ResumeLayout(False)
		Me._SSTab1_TabPage1.ResumeLayout(False)
		Me.Frame2.ResumeLayout(False)
		Me._SSTab1_TabPage2.ResumeLayout(False)
		Me.Toolbar1.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class