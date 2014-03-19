<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRepCtaCteAnalitico
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
	Public WithEvents chkAjuste As System.Windows.Forms.CheckBox
	Public WithEvents _OptDetalle_0 As System.Windows.Forms.RadioButton
	Public WithEvents _OptDetalle_1 As System.Windows.Forms.RadioButton
	Public WithEvents Frame6 As System.Windows.Forms.GroupBox
	Public WithEvents _optOpcion_3 As System.Windows.Forms.RadioButton
	Public WithEvents _optOpcion_2 As System.Windows.Forms.RadioButton
	Public WithEvents Frame5 As System.Windows.Forms.GroupBox
	Public WithEvents lstTipoAnaliticoCodigo As System.Windows.Forms.ListBox
	Public WithEvents _cmdBotones_0 As System.Windows.Forms.Button
	Public WithEvents _cmdBotones_1 As System.Windows.Forms.Button
	Public WithEvents _optFiltro_2 As System.Windows.Forms.RadioButton
	Public WithEvents _optFiltro_1 As System.Windows.Forms.RadioButton
	Public WithEvents _optFiltro_0 As System.Windows.Forms.RadioButton
	Public WithEvents Frame4 As System.Windows.Forms.GroupBox
	Public WithEvents Ctr_Ayuda1 As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents cboTipoAnalitico As System.Windows.Forms.ComboBox
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents _optOpcion_4 As System.Windows.Forms.RadioButton
	Public WithEvents _optOpcion_0 As System.Windows.Forms.RadioButton
	Public WithEvents _optOpcion_1 As System.Windows.Forms.RadioButton
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents Ctr_AyudaEnt As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents Ctr_Ayuda2 As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents OptDetalle As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	Public WithEvents cmdBotones As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
	Public WithEvents optFiltro As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	Public WithEvents optOpcion As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRepCtaCteAnalitico))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.chkAjuste = New System.Windows.Forms.CheckBox
		Me.Frame6 = New System.Windows.Forms.GroupBox
		Me._OptDetalle_0 = New System.Windows.Forms.RadioButton
		Me._OptDetalle_1 = New System.Windows.Forms.RadioButton
		Me.Frame5 = New System.Windows.Forms.GroupBox
		Me._optOpcion_3 = New System.Windows.Forms.RadioButton
		Me._optOpcion_2 = New System.Windows.Forms.RadioButton
		Me.lstTipoAnaliticoCodigo = New System.Windows.Forms.ListBox
		Me._cmdBotones_0 = New System.Windows.Forms.Button
		Me._cmdBotones_1 = New System.Windows.Forms.Button
		Me.Frame4 = New System.Windows.Forms.GroupBox
		Me._optFiltro_2 = New System.Windows.Forms.RadioButton
		Me._optFiltro_1 = New System.Windows.Forms.RadioButton
		Me._optFiltro_0 = New System.Windows.Forms.RadioButton
		Me.Frame3 = New System.Windows.Forms.GroupBox
		Me.Ctr_Ayuda1 = New Axctrlayuda_f.AxCtr_Ayuda
		Me.Label1 = New System.Windows.Forms.Label
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.cboTipoAnalitico = New System.Windows.Forms.ComboBox
		Me.Label2 = New System.Windows.Forms.Label
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me._optOpcion_4 = New System.Windows.Forms.RadioButton
		Me._optOpcion_0 = New System.Windows.Forms.RadioButton
		Me._optOpcion_1 = New System.Windows.Forms.RadioButton
		Me.Ctr_AyudaEnt = New Axctrlayuda_f.AxCtr_Ayuda
		Me.Ctr_Ayuda2 = New Axctrlayuda_f.AxCtr_Ayuda
		Me.Label4 = New System.Windows.Forms.Label
		Me.OptDetalle = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.cmdBotones = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(components)
		Me.optFiltro = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.optOpcion = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.Frame6.SuspendLayout()
		Me.Frame5.SuspendLayout()
		Me.Frame4.SuspendLayout()
		Me.Frame3.SuspendLayout()
		Me.Frame2.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.Ctr_Ayuda1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Ctr_AyudaEnt, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Ctr_Ayuda2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.OptDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.cmdBotones, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.optFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.optOpcion, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Cuenta Corriente Entidades (Analíticos)"
		Me.ClientSize = New System.Drawing.Size(485, 411)
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
		Me.Name = "frmRepCtaCteAnalitico"
		Me.chkAjuste.Text = "Incluye ajuste por diferencia de cambio"
		Me.chkAjuste.Size = New System.Drawing.Size(121, 29)
		Me.chkAjuste.Location = New System.Drawing.Point(358, 234)
		Me.chkAjuste.TabIndex = 26
		Me.chkAjuste.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkAjuste.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkAjuste.BackColor = System.Drawing.SystemColors.Control
		Me.chkAjuste.CausesValidation = True
		Me.chkAjuste.Enabled = True
		Me.chkAjuste.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkAjuste.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkAjuste.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkAjuste.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkAjuste.TabStop = True
		Me.chkAjuste.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkAjuste.Visible = True
		Me.chkAjuste.Name = "chkAjuste"
		Me.Frame6.Text = "Seleccionar Detalle"
		Me.Frame6.Size = New System.Drawing.Size(346, 46)
		Me.Frame6.Location = New System.Drawing.Point(6, 222)
		Me.Frame6.TabIndex = 23
		Me.Frame6.BackColor = System.Drawing.SystemColors.Control
		Me.Frame6.Enabled = True
		Me.Frame6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame6.Visible = True
		Me.Frame6.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame6.Name = "Frame6"
		Me._OptDetalle_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._OptDetalle_0.Text = "Solo Saldos"
		Me._OptDetalle_0.Size = New System.Drawing.Size(94, 13)
		Me._OptDetalle_0.Location = New System.Drawing.Point(15, 21)
		Me._OptDetalle_0.TabIndex = 25
		Me._OptDetalle_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._OptDetalle_0.BackColor = System.Drawing.SystemColors.Control
		Me._OptDetalle_0.CausesValidation = True
		Me._OptDetalle_0.Enabled = True
		Me._OptDetalle_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._OptDetalle_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._OptDetalle_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._OptDetalle_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._OptDetalle_0.TabStop = True
		Me._OptDetalle_0.Checked = False
		Me._OptDetalle_0.Visible = True
		Me._OptDetalle_0.Name = "_OptDetalle_0"
		Me._OptDetalle_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._OptDetalle_1.Text = "Detalle por documento"
		Me._OptDetalle_1.Size = New System.Drawing.Size(133, 16)
		Me._OptDetalle_1.Location = New System.Drawing.Point(174, 18)
		Me._OptDetalle_1.TabIndex = 24
		Me._OptDetalle_1.Checked = True
		Me._OptDetalle_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._OptDetalle_1.BackColor = System.Drawing.SystemColors.Control
		Me._OptDetalle_1.CausesValidation = True
		Me._OptDetalle_1.Enabled = True
		Me._OptDetalle_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._OptDetalle_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._OptDetalle_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._OptDetalle_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._OptDetalle_1.TabStop = True
		Me._OptDetalle_1.Visible = True
		Me._OptDetalle_1.Name = "_OptDetalle_1"
		Me.Frame5.Text = "Ordenado por"
		Me.Frame5.Size = New System.Drawing.Size(147, 57)
		Me.Frame5.Location = New System.Drawing.Point(328, 8)
		Me.Frame5.TabIndex = 18
		Me.Frame5.BackColor = System.Drawing.SystemColors.Control
		Me.Frame5.Enabled = True
		Me.Frame5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame5.Visible = True
		Me.Frame5.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame5.Name = "Frame5"
		Me._optOpcion_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optOpcion_3.Text = "Cuenta Contable"
		Me._optOpcion_3.Size = New System.Drawing.Size(208, 15)
		Me._optOpcion_3.Location = New System.Drawing.Point(9, 36)
		Me._optOpcion_3.TabIndex = 20
		Me._optOpcion_3.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optOpcion_3.BackColor = System.Drawing.SystemColors.Control
		Me._optOpcion_3.CausesValidation = True
		Me._optOpcion_3.Enabled = True
		Me._optOpcion_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optOpcion_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._optOpcion_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optOpcion_3.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optOpcion_3.TabStop = True
		Me._optOpcion_3.Checked = False
		Me._optOpcion_3.Visible = True
		Me._optOpcion_3.Name = "_optOpcion_3"
		Me._optOpcion_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optOpcion_2.Text = "Entidad"
		Me._optOpcion_2.Size = New System.Drawing.Size(200, 15)
		Me._optOpcion_2.Location = New System.Drawing.Point(9, 19)
		Me._optOpcion_2.TabIndex = 19
		Me._optOpcion_2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optOpcion_2.BackColor = System.Drawing.SystemColors.Control
		Me._optOpcion_2.CausesValidation = True
		Me._optOpcion_2.Enabled = True
		Me._optOpcion_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optOpcion_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._optOpcion_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optOpcion_2.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optOpcion_2.TabStop = True
		Me._optOpcion_2.Checked = False
		Me._optOpcion_2.Visible = True
		Me._optOpcion_2.Name = "_optOpcion_2"
		Me.lstTipoAnaliticoCodigo.Size = New System.Drawing.Size(79, 20)
		Me.lstTipoAnaliticoCodigo.Location = New System.Drawing.Point(387, 330)
		Me.lstTipoAnaliticoCodigo.TabIndex = 14
		Me.lstTipoAnaliticoCodigo.Visible = False
		Me.lstTipoAnaliticoCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lstTipoAnaliticoCodigo.BackColor = System.Drawing.SystemColors.Window
		Me.lstTipoAnaliticoCodigo.CausesValidation = True
		Me.lstTipoAnaliticoCodigo.Enabled = True
		Me.lstTipoAnaliticoCodigo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lstTipoAnaliticoCodigo.IntegralHeight = True
		Me.lstTipoAnaliticoCodigo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lstTipoAnaliticoCodigo.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.lstTipoAnaliticoCodigo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lstTipoAnaliticoCodigo.Sorted = False
		Me.lstTipoAnaliticoCodigo.TabStop = True
		Me.lstTipoAnaliticoCodigo.MultiColumn = False
		Me.lstTipoAnaliticoCodigo.Name = "lstTipoAnaliticoCodigo"
		Me._cmdBotones_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdBotones_0.Text = "&Aceptar"
		Me._cmdBotones_0.Size = New System.Drawing.Size(98, 25)
		Me._cmdBotones_0.Location = New System.Drawing.Point(139, 332)
		Me._cmdBotones_0.TabIndex = 13
		Me._cmdBotones_0.BackColor = System.Drawing.SystemColors.Control
		Me._cmdBotones_0.CausesValidation = True
		Me._cmdBotones_0.Enabled = True
		Me._cmdBotones_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdBotones_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdBotones_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdBotones_0.TabStop = True
		Me._cmdBotones_0.Name = "_cmdBotones_0"
		Me._cmdBotones_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdBotones_1.Text = "&Cancelar"
		Me._cmdBotones_1.Size = New System.Drawing.Size(98, 25)
		Me._cmdBotones_1.Location = New System.Drawing.Point(251, 332)
		Me._cmdBotones_1.TabIndex = 12
		Me._cmdBotones_1.BackColor = System.Drawing.SystemColors.Control
		Me._cmdBotones_1.CausesValidation = True
		Me._cmdBotones_1.Enabled = True
		Me._cmdBotones_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdBotones_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdBotones_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdBotones_1.TabStop = True
		Me._cmdBotones_1.Name = "_cmdBotones_1"
		Me.Frame4.Text = "Seleccionar Filtro"
		Me.Frame4.Size = New System.Drawing.Size(475, 50)
		Me.Frame4.Location = New System.Drawing.Point(6, 273)
		Me.Frame4.TabIndex = 11
		Me.Frame4.BackColor = System.Drawing.SystemColors.Control
		Me.Frame4.Enabled = True
		Me.Frame4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame4.Visible = True
		Me.Frame4.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame4.Name = "Frame4"
		Me._optFiltro_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optFiltro_2.Text = "Todos"
		Me._optFiltro_2.Size = New System.Drawing.Size(101, 20)
		Me._optFiltro_2.Location = New System.Drawing.Point(363, 18)
		Me._optFiltro_2.TabIndex = 17
		Me._optFiltro_2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optFiltro_2.BackColor = System.Drawing.SystemColors.Control
		Me._optFiltro_2.CausesValidation = True
		Me._optFiltro_2.Enabled = True
		Me._optFiltro_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optFiltro_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._optFiltro_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optFiltro_2.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optFiltro_2.TabStop = True
		Me._optFiltro_2.Checked = False
		Me._optFiltro_2.Visible = True
		Me._optFiltro_2.Name = "_optFiltro_2"
		Me._optFiltro_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optFiltro_1.Text = "Documentos pendientes"
		Me._optFiltro_1.Size = New System.Drawing.Size(143, 20)
		Me._optFiltro_1.Location = New System.Drawing.Point(173, 18)
		Me._optFiltro_1.TabIndex = 16
		Me._optFiltro_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optFiltro_1.BackColor = System.Drawing.SystemColors.Control
		Me._optFiltro_1.CausesValidation = True
		Me._optFiltro_1.Enabled = True
		Me._optFiltro_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optFiltro_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._optFiltro_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optFiltro_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optFiltro_1.TabStop = True
		Me._optFiltro_1.Checked = False
		Me._optFiltro_1.Visible = True
		Me._optFiltro_1.Name = "_optFiltro_1"
		Me._optFiltro_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optFiltro_0.Text = "Documentos cancelados"
		Me._optFiltro_0.Size = New System.Drawing.Size(143, 20)
		Me._optFiltro_0.Location = New System.Drawing.Point(12, 18)
		Me._optFiltro_0.TabIndex = 15
		Me._optFiltro_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optFiltro_0.BackColor = System.Drawing.SystemColors.Control
		Me._optFiltro_0.CausesValidation = True
		Me._optFiltro_0.Enabled = True
		Me._optFiltro_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optFiltro_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._optFiltro_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optFiltro_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optFiltro_0.TabStop = True
		Me._optFiltro_0.Checked = False
		Me._optFiltro_0.Visible = True
		Me._optFiltro_0.Name = "_optFiltro_0"
		Me.Frame3.Text = "Seleccionar Cuentas"
		Me.Frame3.Size = New System.Drawing.Size(476, 63)
		Me.Frame3.Location = New System.Drawing.Point(3, 126)
		Me.Frame3.TabIndex = 9
		Me.Frame3.BackColor = System.Drawing.SystemColors.Control
		Me.Frame3.Enabled = True
		Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame3.Visible = True
		Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame3.Name = "Frame3"
		Ctr_Ayuda1.OcxState = CType(resources.GetObject("Ctr_Ayuda1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.Ctr_Ayuda1.Size = New System.Drawing.Size(359, 24)
		Me.Ctr_Ayuda1.Location = New System.Drawing.Point(112, 24)
		Me.Ctr_Ayuda1.TabIndex = 5
		Me.Ctr_Ayuda1.Name = "Ctr_Ayuda1"
		Me.Label1.Text = "Cuenta Contable"
		Me.Label1.Size = New System.Drawing.Size(89, 19)
		Me.Label1.Location = New System.Drawing.Point(9, 29)
		Me.Label1.TabIndex = 10
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
		Me.Frame2.Text = "Seleccionar Entidades (Analítico)"
		Me.Frame2.Size = New System.Drawing.Size(474, 48)
		Me.Frame2.Location = New System.Drawing.Point(2, 75)
		Me.Frame2.TabIndex = 3
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame2.Name = "Frame2"
		Me.cboTipoAnalitico.Size = New System.Drawing.Size(293, 21)
		Me.cboTipoAnalitico.Location = New System.Drawing.Point(126, 19)
		Me.cboTipoAnalitico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboTipoAnalitico.TabIndex = 4
		Me.cboTipoAnalitico.BackColor = System.Drawing.SystemColors.Window
		Me.cboTipoAnalitico.CausesValidation = True
		Me.cboTipoAnalitico.Enabled = True
		Me.cboTipoAnalitico.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboTipoAnalitico.IntegralHeight = True
		Me.cboTipoAnalitico.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboTipoAnalitico.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboTipoAnalitico.Sorted = False
		Me.cboTipoAnalitico.TabStop = True
		Me.cboTipoAnalitico.Visible = True
		Me.cboTipoAnalitico.Name = "cboTipoAnalitico"
		Me.Label2.Text = "Tipo Analítico"
		Me.Label2.Size = New System.Drawing.Size(67, 16)
		Me.Label2.Location = New System.Drawing.Point(12, 23)
		Me.Label2.TabIndex = 8
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
		Me.Frame1.Text = "Emitir por"
		Me.Frame1.Size = New System.Drawing.Size(315, 57)
		Me.Frame1.Location = New System.Drawing.Point(3, 7)
		Me.Frame1.TabIndex = 2
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me._optOpcion_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optOpcion_4.Text = "Saldos iniciales"
		Me._optOpcion_4.Size = New System.Drawing.Size(200, 15)
		Me._optOpcion_4.Location = New System.Drawing.Point(176, 24)
		Me._optOpcion_4.TabIndex = 21
		Me._optOpcion_4.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optOpcion_4.BackColor = System.Drawing.SystemColors.Control
		Me._optOpcion_4.CausesValidation = True
		Me._optOpcion_4.Enabled = True
		Me._optOpcion_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optOpcion_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._optOpcion_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optOpcion_4.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optOpcion_4.TabStop = True
		Me._optOpcion_4.Checked = False
		Me._optOpcion_4.Visible = True
		Me._optOpcion_4.Name = "_optOpcion_4"
		Me._optOpcion_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optOpcion_0.Text = "Movimiento Cuenta Corriente"
		Me._optOpcion_0.Size = New System.Drawing.Size(200, 15)
		Me._optOpcion_0.Location = New System.Drawing.Point(9, 19)
		Me._optOpcion_0.TabIndex = 0
		Me._optOpcion_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optOpcion_0.BackColor = System.Drawing.SystemColors.Control
		Me._optOpcion_0.CausesValidation = True
		Me._optOpcion_0.Enabled = True
		Me._optOpcion_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optOpcion_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._optOpcion_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optOpcion_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optOpcion_0.TabStop = True
		Me._optOpcion_0.Checked = False
		Me._optOpcion_0.Visible = True
		Me._optOpcion_0.Name = "_optOpcion_0"
		Me._optOpcion_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optOpcion_1.Text = "Saldos Cuenta Corriente"
		Me._optOpcion_1.Size = New System.Drawing.Size(200, 15)
		Me._optOpcion_1.Location = New System.Drawing.Point(9, 37)
		Me._optOpcion_1.TabIndex = 1
		Me._optOpcion_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optOpcion_1.BackColor = System.Drawing.SystemColors.Control
		Me._optOpcion_1.CausesValidation = True
		Me._optOpcion_1.Enabled = True
		Me._optOpcion_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optOpcion_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._optOpcion_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optOpcion_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optOpcion_1.TabStop = True
		Me._optOpcion_1.Checked = False
		Me._optOpcion_1.Visible = True
		Me._optOpcion_1.Name = "_optOpcion_1"
		Ctr_AyudaEnt.OcxState = CType(resources.GetObject("Ctr_AyudaEnt.OcxState"), System.Windows.Forms.AxHost.State)
		Me.Ctr_AyudaEnt.Size = New System.Drawing.Size(359, 22)
		Me.Ctr_AyudaEnt.Location = New System.Drawing.Point(111, 195)
		Me.Ctr_AyudaEnt.TabIndex = 7
		Me.Ctr_AyudaEnt.Name = "Ctr_AyudaEnt"
		Ctr_Ayuda2.OcxState = CType(resources.GetObject("Ctr_Ayuda2.OcxState"), System.Windows.Forms.AxHost.State)
		Me.Ctr_Ayuda2.Size = New System.Drawing.Size(359, 22)
		Me.Ctr_Ayuda2.Location = New System.Drawing.Point(111, 195)
		Me.Ctr_Ayuda2.TabIndex = 6
		Me.Ctr_Ayuda2.Visible = False
		Me.Ctr_Ayuda2.Name = "Ctr_Ayuda2"
		Me.Label4.Text = "Código Analítico"
		Me.Label4.Size = New System.Drawing.Size(100, 18)
		Me.Label4.Location = New System.Drawing.Point(12, 198)
		Me.Label4.TabIndex = 22
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label4.BackColor = System.Drawing.SystemColors.Control
		Me.Label4.Enabled = True
		Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.Visible = True
		Me.Label4.AutoSize = False
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.Name = "Label4"
		Me.OptDetalle.SetIndex(_OptDetalle_0, CType(0, Short))
		Me.OptDetalle.SetIndex(_OptDetalle_1, CType(1, Short))
		Me.cmdBotones.SetIndex(_cmdBotones_0, CType(0, Short))
		Me.cmdBotones.SetIndex(_cmdBotones_1, CType(1, Short))
		Me.optFiltro.SetIndex(_optFiltro_2, CType(2, Short))
		Me.optFiltro.SetIndex(_optFiltro_1, CType(1, Short))
		Me.optFiltro.SetIndex(_optFiltro_0, CType(0, Short))
		Me.optOpcion.SetIndex(_optOpcion_3, CType(3, Short))
		Me.optOpcion.SetIndex(_optOpcion_2, CType(2, Short))
		Me.optOpcion.SetIndex(_optOpcion_4, CType(4, Short))
		Me.optOpcion.SetIndex(_optOpcion_0, CType(0, Short))
		Me.optOpcion.SetIndex(_optOpcion_1, CType(1, Short))
		CType(Me.optOpcion, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.optFiltro, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.cmdBotones, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.OptDetalle, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Ctr_Ayuda2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Ctr_AyudaEnt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Ctr_Ayuda1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Controls.Add(chkAjuste)
		Me.Controls.Add(Frame6)
		Me.Controls.Add(Frame5)
		Me.Controls.Add(lstTipoAnaliticoCodigo)
		Me.Controls.Add(_cmdBotones_0)
		Me.Controls.Add(_cmdBotones_1)
		Me.Controls.Add(Frame4)
		Me.Controls.Add(Frame3)
		Me.Controls.Add(Frame2)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(Ctr_AyudaEnt)
		Me.Controls.Add(Ctr_Ayuda2)
		Me.Controls.Add(Label4)
		Me.Frame6.Controls.Add(_OptDetalle_0)
		Me.Frame6.Controls.Add(_OptDetalle_1)
		Me.Frame5.Controls.Add(_optOpcion_3)
		Me.Frame5.Controls.Add(_optOpcion_2)
		Me.Frame4.Controls.Add(_optFiltro_2)
		Me.Frame4.Controls.Add(_optFiltro_1)
		Me.Frame4.Controls.Add(_optFiltro_0)
		Me.Frame3.Controls.Add(Ctr_Ayuda1)
		Me.Frame3.Controls.Add(Label1)
		Me.Frame2.Controls.Add(cboTipoAnalitico)
		Me.Frame2.Controls.Add(Label2)
		Me.Frame1.Controls.Add(_optOpcion_4)
		Me.Frame1.Controls.Add(_optOpcion_0)
		Me.Frame1.Controls.Add(_optOpcion_1)
		Me.Frame6.ResumeLayout(False)
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