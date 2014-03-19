<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FrmMntDocumentos
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
	Public WithEvents TxFiltro As System.Windows.Forms.TextBox
	Public WithEvents CmbOrden As System.Windows.Forms.ComboBox
	Public WithEvents Label32 As System.Windows.Forms.Label
	Public WithEvents Label33 As System.Windows.Forms.Label
	Public WithEvents Frame5 As System.Windows.Forms.GroupBox
	Public WithEvents command5 As System.Windows.Forms.Button
	Public WithEvents Command7 As System.Windows.Forms.Button
	Public WithEvents Command3 As System.Windows.Forms.Button
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents Command9 As System.Windows.Forms.Button
	Public WithEvents Command8 As System.Windows.Forms.Button
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents CheckAnulado As System.Windows.Forms.CheckBox
	Public WithEvents TxtRefSunat As System.Windows.Forms.TextBox
	Public WithEvents Checkref As System.Windows.Forms.CheckBox
	Public WithEvents CheckNota As System.Windows.Forms.CheckBox
	Public WithEvents CheckcOMPRAS As System.Windows.Forms.CheckBox
	Public WithEvents CheckVTAS As System.Windows.Forms.CheckBox
	Public WithEvents txtcodigo As System.Windows.Forms.TextBox
	Public WithEvents txtdescripcion As System.Windows.Forms.TextBox
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents DbGrid1 As AxMSDataGridLib.AxDataGrid
	Public WithEvents Frame9 As System.Windows.Forms.GroupBox
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmMntDocumentos))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Frame9 = New System.Windows.Forms.GroupBox
		Me.Frame5 = New System.Windows.Forms.GroupBox
		Me.TxFiltro = New System.Windows.Forms.TextBox
		Me.CmbOrden = New System.Windows.Forms.ComboBox
		Me.Label32 = New System.Windows.Forms.Label
		Me.Label33 = New System.Windows.Forms.Label
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.command5 = New System.Windows.Forms.Button
		Me.Command7 = New System.Windows.Forms.Button
		Me.Command3 = New System.Windows.Forms.Button
		Me.Command1 = New System.Windows.Forms.Button
		Me.Command2 = New System.Windows.Forms.Button
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.Command9 = New System.Windows.Forms.Button
		Me.Command8 = New System.Windows.Forms.Button
		Me.Frame3 = New System.Windows.Forms.GroupBox
		Me.CheckAnulado = New System.Windows.Forms.CheckBox
		Me.TxtRefSunat = New System.Windows.Forms.TextBox
		Me.Checkref = New System.Windows.Forms.CheckBox
		Me.CheckNota = New System.Windows.Forms.CheckBox
		Me.CheckcOMPRAS = New System.Windows.Forms.CheckBox
		Me.CheckVTAS = New System.Windows.Forms.CheckBox
		Me.txtcodigo = New System.Windows.Forms.TextBox
		Me.txtdescripcion = New System.Windows.Forms.TextBox
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.DbGrid1 = New AxMSDataGridLib.AxDataGrid
		Me.Frame9.SuspendLayout()
		Me.Frame5.SuspendLayout()
		Me.Frame2.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.Frame3.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.DbGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Mantenimiento de tipo de documentos"
		Me.ClientSize = New System.Drawing.Size(589, 468)
		Me.Location = New System.Drawing.Point(8, 31)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
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
		Me.Name = "FrmMntDocumentos"
		Me.Frame9.BackColor = System.Drawing.Color.White
		Me.Frame9.Text = " "
		Me.Frame9.Size = New System.Drawing.Size(569, 441)
		Me.Frame9.Location = New System.Drawing.Point(8, 8)
		Me.Frame9.TabIndex = 0
		Me.Frame9.Enabled = True
		Me.Frame9.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame9.Visible = True
		Me.Frame9.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame9.Name = "Frame9"
		Me.Frame5.Size = New System.Drawing.Size(529, 49)
		Me.Frame5.Location = New System.Drawing.Point(24, 16)
		Me.Frame5.TabIndex = 10
		Me.Frame5.BackColor = System.Drawing.SystemColors.Control
		Me.Frame5.Enabled = True
		Me.Frame5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame5.Visible = True
		Me.Frame5.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame5.Name = "Frame5"
		Me.TxFiltro.AutoSize = False
		Me.TxFiltro.Size = New System.Drawing.Size(177, 20)
		Me.TxFiltro.Location = New System.Drawing.Point(80, 16)
		Me.TxFiltro.Maxlength = 45
		Me.TxFiltro.TabIndex = 12
		Me.TxFiltro.Text = "TxFiltro"
		Me.TxFiltro.AcceptsReturn = True
		Me.TxFiltro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.TxFiltro.BackColor = System.Drawing.SystemColors.Window
		Me.TxFiltro.CausesValidation = True
		Me.TxFiltro.Enabled = True
		Me.TxFiltro.ForeColor = System.Drawing.SystemColors.WindowText
		Me.TxFiltro.HideSelection = True
		Me.TxFiltro.ReadOnly = False
		Me.TxFiltro.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TxFiltro.MultiLine = False
		Me.TxFiltro.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TxFiltro.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.TxFiltro.TabStop = True
		Me.TxFiltro.Visible = True
		Me.TxFiltro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.TxFiltro.Name = "TxFiltro"
		Me.CmbOrden.Size = New System.Drawing.Size(105, 21)
		Me.CmbOrden.Location = New System.Drawing.Point(336, 16)
		Me.CmbOrden.Items.AddRange(New Object(){"    CODIGO", "DESCRIPCION"})
		Me.CmbOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CmbOrden.TabIndex = 11
		Me.CmbOrden.BackColor = System.Drawing.SystemColors.Window
		Me.CmbOrden.CausesValidation = True
		Me.CmbOrden.Enabled = True
		Me.CmbOrden.ForeColor = System.Drawing.SystemColors.WindowText
		Me.CmbOrden.IntegralHeight = True
		Me.CmbOrden.Cursor = System.Windows.Forms.Cursors.Default
		Me.CmbOrden.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CmbOrden.Sorted = False
		Me.CmbOrden.TabStop = True
		Me.CmbOrden.Visible = True
		Me.CmbOrden.Name = "CmbOrden"
		Me.Label32.Text = "Buscar  :"
		Me.Label32.Size = New System.Drawing.Size(49, 17)
		Me.Label32.Location = New System.Drawing.Point(16, 16)
		Me.Label32.TabIndex = 14
		Me.Label32.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label32.BackColor = System.Drawing.SystemColors.Control
		Me.Label32.Enabled = True
		Me.Label32.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label32.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label32.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label32.UseMnemonic = True
		Me.Label32.Visible = True
		Me.Label32.AutoSize = False
		Me.Label32.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label32.Name = "Label32"
		Me.Label33.Text = "Orden :"
		Me.Label33.Size = New System.Drawing.Size(41, 17)
		Me.Label33.Location = New System.Drawing.Point(288, 16)
		Me.Label33.TabIndex = 13
		Me.Label33.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label33.BackColor = System.Drawing.SystemColors.Control
		Me.Label33.Enabled = True
		Me.Label33.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label33.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label33.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label33.UseMnemonic = True
		Me.Label33.Visible = True
		Me.Label33.AutoSize = False
		Me.Label33.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label33.Name = "Label33"
		Me.Frame2.Size = New System.Drawing.Size(529, 81)
		Me.Frame2.Location = New System.Drawing.Point(24, 345)
		Me.Frame2.TabIndex = 4
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame2.Name = "Frame2"
		Me.command5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.command5.Text = "&Reporte"
		Me.command5.Size = New System.Drawing.Size(52, 45)
		Me.command5.Location = New System.Drawing.Point(328, 16)
		Me.command5.Image = CType(resources.GetObject("command5.Image"), System.Drawing.Image)
		Me.command5.TabIndex = 9
		Me.command5.Visible = False
		Me.command5.BackColor = System.Drawing.SystemColors.Control
		Me.command5.CausesValidation = True
		Me.command5.Enabled = True
		Me.command5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.command5.Cursor = System.Windows.Forms.Cursors.Default
		Me.command5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.command5.TabStop = True
		Me.command5.Name = "command5"
		Me.Command7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.CancelButton = Me.Command7
		Me.Command7.Text = "&Salir"
		Me.Command7.Size = New System.Drawing.Size(52, 45)
		Me.Command7.Location = New System.Drawing.Point(440, 17)
		Me.Command7.Image = CType(resources.GetObject("Command7.Image"), System.Drawing.Image)
		Me.Command7.TabIndex = 8
		Me.Command7.BackColor = System.Drawing.SystemColors.Control
		Me.Command7.CausesValidation = True
		Me.Command7.Enabled = True
		Me.Command7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command7.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command7.TabStop = True
		Me.Command7.Name = "Command7"
		Me.Command3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Command3.Text = "&Eliminar"
		Me.Command3.Size = New System.Drawing.Size(52, 45)
		Me.Command3.Location = New System.Drawing.Point(232, 16)
		Me.Command3.Image = CType(resources.GetObject("Command3.Image"), System.Drawing.Image)
		Me.Command3.TabIndex = 7
		Me.Command3.BackColor = System.Drawing.SystemColors.Control
		Me.Command3.CausesValidation = True
		Me.Command3.Enabled = True
		Me.Command3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command3.TabStop = True
		Me.Command3.Name = "Command3"
		Me.Command1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Command1.Text = "&Ingreso"
		Me.Command1.Size = New System.Drawing.Size(52, 45)
		Me.Command1.Location = New System.Drawing.Point(32, 16)
		Me.Command1.Image = CType(resources.GetObject("Command1.Image"), System.Drawing.Image)
		Me.Command1.TabIndex = 6
		Me.Command1.BackColor = System.Drawing.SystemColors.Control
		Me.Command1.CausesValidation = True
		Me.Command1.Enabled = True
		Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command1.TabStop = True
		Me.Command1.Name = "Command1"
		Me.Command2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Command2.Text = "&Modificar"
		Me.Command2.Size = New System.Drawing.Size(52, 45)
		Me.Command2.Location = New System.Drawing.Point(136, 16)
		Me.Command2.Image = CType(resources.GetObject("Command2.Image"), System.Drawing.Image)
		Me.Command2.TabIndex = 5
		Me.Command2.BackColor = System.Drawing.SystemColors.Control
		Me.Command2.CausesValidation = True
		Me.Command2.Enabled = True
		Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command2.TabStop = True
		Me.Command2.Name = "Command2"
		Me.Frame1.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me.Frame1.Size = New System.Drawing.Size(528, 71)
		Me.Frame1.Location = New System.Drawing.Point(27, 346)
		Me.Frame1.TabIndex = 1
		Me.Frame1.Visible = False
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.Command9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Command9.Text = "&Cancelar"
		Me.Command9.Size = New System.Drawing.Size(52, 45)
		Me.Command9.Location = New System.Drawing.Point(264, 16)
		Me.Command9.Image = CType(resources.GetObject("Command9.Image"), System.Drawing.Image)
		Me.Command9.TabIndex = 3
		Me.Command9.BackColor = System.Drawing.SystemColors.Control
		Me.Command9.CausesValidation = True
		Me.Command9.Enabled = True
		Me.Command9.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command9.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command9.TabStop = True
		Me.Command9.Name = "Command9"
		Me.Command8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Command8.Text = "&Grabar"
		Me.Command8.Size = New System.Drawing.Size(52, 45)
		Me.Command8.Location = New System.Drawing.Point(120, 16)
		Me.Command8.Image = CType(resources.GetObject("Command8.Image"), System.Drawing.Image)
		Me.Command8.TabIndex = 2
		Me.Command8.BackColor = System.Drawing.SystemColors.Control
		Me.Command8.CausesValidation = True
		Me.Command8.Enabled = True
		Me.Command8.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command8.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command8.TabStop = True
		Me.Command8.Name = "Command8"
		Me.Frame3.BackColor = System.Drawing.Color.FromARGB(192, 192, 255)
		Me.Frame3.Size = New System.Drawing.Size(529, 265)
		Me.Frame3.Location = New System.Drawing.Point(27, 72)
		Me.Frame3.TabIndex = 15
		Me.Frame3.Visible = False
		Me.Frame3.Enabled = True
		Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame3.Name = "Frame3"
		Me.CheckAnulado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.CheckAnulado.BackColor = System.Drawing.Color.FromARGB(192, 192, 255)
		Me.CheckAnulado.Text = "Estado Anulado"
		Me.CheckAnulado.Size = New System.Drawing.Size(137, 25)
		Me.CheckAnulado.Location = New System.Drawing.Point(32, 216)
		Me.CheckAnulado.TabIndex = 28
		Me.CheckAnulado.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.CheckAnulado.CausesValidation = True
		Me.CheckAnulado.Enabled = True
		Me.CheckAnulado.ForeColor = System.Drawing.SystemColors.ControlText
		Me.CheckAnulado.Cursor = System.Windows.Forms.Cursors.Default
		Me.CheckAnulado.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CheckAnulado.Appearance = System.Windows.Forms.Appearance.Normal
		Me.CheckAnulado.TabStop = True
		Me.CheckAnulado.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.CheckAnulado.Visible = True
		Me.CheckAnulado.Name = "CheckAnulado"
		Me.TxtRefSunat.AutoSize = False
		Me.TxtRefSunat.Size = New System.Drawing.Size(33, 25)
		Me.TxtRefSunat.Location = New System.Drawing.Point(152, 184)
		Me.TxtRefSunat.Maxlength = 3
		Me.TxtRefSunat.TabIndex = 27
		Me.TxtRefSunat.AcceptsReturn = True
		Me.TxtRefSunat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.TxtRefSunat.BackColor = System.Drawing.SystemColors.Window
		Me.TxtRefSunat.CausesValidation = True
		Me.TxtRefSunat.Enabled = True
		Me.TxtRefSunat.ForeColor = System.Drawing.SystemColors.WindowText
		Me.TxtRefSunat.HideSelection = True
		Me.TxtRefSunat.ReadOnly = False
		Me.TxtRefSunat.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TxtRefSunat.MultiLine = False
		Me.TxtRefSunat.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TxtRefSunat.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.TxtRefSunat.TabStop = True
		Me.TxtRefSunat.Visible = True
		Me.TxtRefSunat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.TxtRefSunat.Name = "TxtRefSunat"
		Me.Checkref.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Checkref.BackColor = System.Drawing.Color.FromARGB(192, 192, 255)
		Me.Checkref.Text = "Ingresa Nro. REFERENCIA"
		Me.Checkref.Size = New System.Drawing.Size(137, 25)
		Me.Checkref.Location = New System.Drawing.Point(32, 152)
		Me.Checkref.TabIndex = 26
		Me.Checkref.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.Checkref.CausesValidation = True
		Me.Checkref.Enabled = True
		Me.Checkref.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Checkref.Cursor = System.Windows.Forms.Cursors.Default
		Me.Checkref.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Checkref.Appearance = System.Windows.Forms.Appearance.Normal
		Me.Checkref.TabStop = True
		Me.Checkref.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.Checkref.Visible = True
		Me.Checkref.Name = "Checkref"
		Me.CheckNota.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.CheckNota.BackColor = System.Drawing.Color.FromARGB(192, 192, 255)
		Me.CheckNota.Text = "Documento NOTA CREDITO"
		Me.CheckNota.Size = New System.Drawing.Size(137, 25)
		Me.CheckNota.Location = New System.Drawing.Point(32, 120)
		Me.CheckNota.TabIndex = 25
		Me.CheckNota.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.CheckNota.CausesValidation = True
		Me.CheckNota.Enabled = True
		Me.CheckNota.ForeColor = System.Drawing.SystemColors.ControlText
		Me.CheckNota.Cursor = System.Windows.Forms.Cursors.Default
		Me.CheckNota.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CheckNota.Appearance = System.Windows.Forms.Appearance.Normal
		Me.CheckNota.TabStop = True
		Me.CheckNota.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.CheckNota.Visible = True
		Me.CheckNota.Name = "CheckNota"
		Me.CheckcOMPRAS.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.CheckcOMPRAS.BackColor = System.Drawing.Color.FromARGB(192, 192, 255)
		Me.CheckcOMPRAS.Text = "Registro Compras"
		Me.CheckcOMPRAS.Size = New System.Drawing.Size(137, 25)
		Me.CheckcOMPRAS.Location = New System.Drawing.Point(32, 96)
		Me.CheckcOMPRAS.TabIndex = 24
		Me.CheckcOMPRAS.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.CheckcOMPRAS.CausesValidation = True
		Me.CheckcOMPRAS.Enabled = True
		Me.CheckcOMPRAS.ForeColor = System.Drawing.SystemColors.ControlText
		Me.CheckcOMPRAS.Cursor = System.Windows.Forms.Cursors.Default
		Me.CheckcOMPRAS.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CheckcOMPRAS.Appearance = System.Windows.Forms.Appearance.Normal
		Me.CheckcOMPRAS.TabStop = True
		Me.CheckcOMPRAS.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.CheckcOMPRAS.Visible = True
		Me.CheckcOMPRAS.Name = "CheckcOMPRAS"
		Me.CheckVTAS.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.CheckVTAS.BackColor = System.Drawing.Color.FromARGB(192, 192, 255)
		Me.CheckVTAS.Text = "Registro Ventas"
		Me.CheckVTAS.Size = New System.Drawing.Size(137, 25)
		Me.CheckVTAS.Location = New System.Drawing.Point(32, 72)
		Me.CheckVTAS.TabIndex = 23
		Me.CheckVTAS.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.CheckVTAS.CausesValidation = True
		Me.CheckVTAS.Enabled = True
		Me.CheckVTAS.ForeColor = System.Drawing.SystemColors.ControlText
		Me.CheckVTAS.Cursor = System.Windows.Forms.Cursors.Default
		Me.CheckVTAS.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CheckVTAS.Appearance = System.Windows.Forms.Appearance.Normal
		Me.CheckVTAS.TabStop = True
		Me.CheckVTAS.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.CheckVTAS.Visible = True
		Me.CheckVTAS.Name = "CheckVTAS"
		Me.txtcodigo.AutoSize = False
		Me.txtcodigo.Size = New System.Drawing.Size(41, 25)
		Me.txtcodigo.Location = New System.Drawing.Point(152, 16)
		Me.txtcodigo.Maxlength = 10
		Me.txtcodigo.TabIndex = 17
		Me.txtcodigo.AcceptsReturn = True
		Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtcodigo.BackColor = System.Drawing.SystemColors.Window
		Me.txtcodigo.CausesValidation = True
		Me.txtcodigo.Enabled = True
		Me.txtcodigo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtcodigo.HideSelection = True
		Me.txtcodigo.ReadOnly = False
		Me.txtcodigo.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtcodigo.MultiLine = False
		Me.txtcodigo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtcodigo.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtcodigo.TabStop = True
		Me.txtcodigo.Visible = True
		Me.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtcodigo.Name = "txtcodigo"
		Me.txtdescripcion.AutoSize = False
		Me.txtdescripcion.Size = New System.Drawing.Size(313, 25)
		Me.txtdescripcion.Location = New System.Drawing.Point(152, 48)
		Me.txtdescripcion.Maxlength = 40
		Me.txtdescripcion.TabIndex = 16
		Me.txtdescripcion.AcceptsReturn = True
		Me.txtdescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtdescripcion.BackColor = System.Drawing.SystemColors.Window
		Me.txtdescripcion.CausesValidation = True
		Me.txtdescripcion.Enabled = True
		Me.txtdescripcion.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtdescripcion.HideSelection = True
		Me.txtdescripcion.ReadOnly = False
		Me.txtdescripcion.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtdescripcion.MultiLine = False
		Me.txtdescripcion.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtdescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtdescripcion.TabStop = True
		Me.txtdescripcion.Visible = True
		Me.txtdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtdescripcion.Name = "txtdescripcion"
		Me.Label2.BackColor = System.Drawing.Color.FromARGB(192, 192, 255)
		Me.Label2.Text = "Código             :"
		Me.Label2.Size = New System.Drawing.Size(121, 17)
		Me.Label2.Location = New System.Drawing.Point(32, 16)
		Me.Label2.TabIndex = 21
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.Enabled = True
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.Label3.BackColor = System.Drawing.Color.FromARGB(192, 192, 255)
		Me.Label3.Text = "Descripción     :"
		Me.Label3.Size = New System.Drawing.Size(113, 17)
		Me.Label3.Location = New System.Drawing.Point(32, 48)
		Me.Label3.TabIndex = 20
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label3.Enabled = True
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.Label1.BackColor = System.Drawing.Color.FromARGB(192, 192, 255)
		Me.Label1.Text = " "
		Me.Label1.Size = New System.Drawing.Size(113, 17)
		Me.Label1.Location = New System.Drawing.Point(56, 168)
		Me.Label1.TabIndex = 19
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
		Me.Label5.BackColor = System.Drawing.Color.FromARGB(192, 192, 255)
		Me.Label5.Text = "Referencia SUNAT-Pagos"
		Me.Label5.Size = New System.Drawing.Size(113, 25)
		Me.Label5.Location = New System.Drawing.Point(32, 184)
		Me.Label5.TabIndex = 18
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label5.Enabled = True
		Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.UseMnemonic = True
		Me.Label5.Visible = True
		Me.Label5.AutoSize = False
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.Name = "Label5"
		DbGrid1.OcxState = CType(resources.GetObject("DbGrid1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.DbGrid1.Size = New System.Drawing.Size(529, 271)
		Me.DbGrid1.Location = New System.Drawing.Point(27, 72)
		Me.DbGrid1.TabIndex = 22
		Me.DbGrid1.Name = "DbGrid1"
		Me.Controls.Add(Frame9)
		Me.Frame9.Controls.Add(Frame5)
		Me.Frame9.Controls.Add(Frame2)
		Me.Frame9.Controls.Add(Frame1)
		Me.Frame9.Controls.Add(Frame3)
		Me.Frame9.Controls.Add(DbGrid1)
		Me.Frame5.Controls.Add(TxFiltro)
		Me.Frame5.Controls.Add(CmbOrden)
		Me.Frame5.Controls.Add(Label32)
		Me.Frame5.Controls.Add(Label33)
		Me.Frame2.Controls.Add(command5)
		Me.Frame2.Controls.Add(Command7)
		Me.Frame2.Controls.Add(Command3)
		Me.Frame2.Controls.Add(Command1)
		Me.Frame2.Controls.Add(Command2)
		Me.Frame1.Controls.Add(Command9)
		Me.Frame1.Controls.Add(Command8)
		Me.Frame3.Controls.Add(CheckAnulado)
		Me.Frame3.Controls.Add(TxtRefSunat)
		Me.Frame3.Controls.Add(Checkref)
		Me.Frame3.Controls.Add(CheckNota)
		Me.Frame3.Controls.Add(CheckcOMPRAS)
		Me.Frame3.Controls.Add(CheckVTAS)
		Me.Frame3.Controls.Add(txtcodigo)
		Me.Frame3.Controls.Add(txtdescripcion)
		Me.Frame3.Controls.Add(Label2)
		Me.Frame3.Controls.Add(Label3)
		Me.Frame3.Controls.Add(Label1)
		Me.Frame3.Controls.Add(Label5)
		CType(Me.DbGrid1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame9.ResumeLayout(False)
		Me.Frame5.ResumeLayout(False)
		Me.Frame2.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.Frame3.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class