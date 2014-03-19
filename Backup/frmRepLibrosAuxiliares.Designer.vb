<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRepLibrosAuxiliares
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
	Public WithEvents _optOpcionCajaBancos_1 As System.Windows.Forms.RadioButton
	Public WithEvents _optOpcionCajaBancos_0 As System.Windows.Forms.RadioButton
	Public WithEvents fraCajaBancos As System.Windows.Forms.GroupBox
	Public WithEvents cboLibroAuxiliar As System.Windows.Forms.ComboBox
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents DTPicker1 As AxMSComCtl2.AxDTPicker
	Public WithEvents DTPickerFecInicio As AxMSComCtl2.AxDTPicker
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents fraDetallado As System.Windows.Forms.GroupBox
	Public WithEvents Option1 As System.Windows.Forms.RadioButton
	Public WithEvents _optOpcion_3 As System.Windows.Forms.RadioButton
	Public WithEvents _optOpcion_2 As System.Windows.Forms.RadioButton
	Public WithEvents _optOpcion_1 As System.Windows.Forms.RadioButton
	Public WithEvents _optOpcion_0 As System.Windows.Forms.RadioButton
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents chkAcumula As System.Windows.Forms.CheckBox
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents _cmdBotones_1 As System.Windows.Forms.Button
	Public WithEvents _cmdBotones_0 As System.Windows.Forms.Button
	Public WithEvents cmdBotones As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
	Public WithEvents optOpcion As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	Public WithEvents optOpcionCajaBancos As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRepLibrosAuxiliares))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.fraCajaBancos = New System.Windows.Forms.GroupBox
		Me._optOpcionCajaBancos_1 = New System.Windows.Forms.RadioButton
		Me._optOpcionCajaBancos_0 = New System.Windows.Forms.RadioButton
		Me.Frame3 = New System.Windows.Forms.GroupBox
		Me.cboLibroAuxiliar = New System.Windows.Forms.ComboBox
		Me.fraDetallado = New System.Windows.Forms.GroupBox
		Me.DTPicker1 = New AxMSComCtl2.AxDTPicker
		Me.DTPickerFecInicio = New AxMSComCtl2.AxDTPicker
		Me.Label1 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.Option1 = New System.Windows.Forms.RadioButton
		Me._optOpcion_3 = New System.Windows.Forms.RadioButton
		Me._optOpcion_2 = New System.Windows.Forms.RadioButton
		Me._optOpcion_1 = New System.Windows.Forms.RadioButton
		Me._optOpcion_0 = New System.Windows.Forms.RadioButton
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.chkAcumula = New System.Windows.Forms.CheckBox
		Me._cmdBotones_1 = New System.Windows.Forms.Button
		Me._cmdBotones_0 = New System.Windows.Forms.Button
		Me.cmdBotones = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(components)
		Me.optOpcion = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.optOpcionCajaBancos = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.fraCajaBancos.SuspendLayout()
		Me.Frame3.SuspendLayout()
		Me.fraDetallado.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.Frame2.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.DTPicker1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DTPickerFecInicio, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.cmdBotones, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.optOpcion, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.optOpcionCajaBancos, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Libros Auxiliares"
		Me.ClientSize = New System.Drawing.Size(308, 379)
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
		Me.Name = "frmRepLibrosAuxiliares"
		Me.fraCajaBancos.Text = "Para Caja Bancos"
		Me.fraCajaBancos.Size = New System.Drawing.Size(308, 50)
		Me.fraCajaBancos.Location = New System.Drawing.Point(0, 169)
		Me.fraCajaBancos.TabIndex = 15
		Me.fraCajaBancos.BackColor = System.Drawing.SystemColors.Control
		Me.fraCajaBancos.Enabled = True
		Me.fraCajaBancos.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraCajaBancos.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraCajaBancos.Visible = True
		Me.fraCajaBancos.Padding = New System.Windows.Forms.Padding(0)
		Me.fraCajaBancos.Name = "fraCajaBancos"
		Me._optOpcionCajaBancos_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optOpcionCajaBancos_1.Text = "Registro Caja Resumido por Comprobante"
		Me._optOpcionCajaBancos_1.Size = New System.Drawing.Size(237, 13)
		Me._optOpcionCajaBancos_1.Location = New System.Drawing.Point(10, 30)
		Me._optOpcionCajaBancos_1.TabIndex = 17
		Me._optOpcionCajaBancos_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optOpcionCajaBancos_1.BackColor = System.Drawing.SystemColors.Control
		Me._optOpcionCajaBancos_1.CausesValidation = True
		Me._optOpcionCajaBancos_1.Enabled = True
		Me._optOpcionCajaBancos_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optOpcionCajaBancos_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._optOpcionCajaBancos_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optOpcionCajaBancos_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optOpcionCajaBancos_1.TabStop = True
		Me._optOpcionCajaBancos_1.Checked = False
		Me._optOpcionCajaBancos_1.Visible = True
		Me._optOpcionCajaBancos_1.Name = "_optOpcionCajaBancos_1"
		Me._optOpcionCajaBancos_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optOpcionCajaBancos_0.Text = "Registro Caja Resumido por Banco"
		Me._optOpcionCajaBancos_0.Size = New System.Drawing.Size(237, 13)
		Me._optOpcionCajaBancos_0.Location = New System.Drawing.Point(10, 15)
		Me._optOpcionCajaBancos_0.TabIndex = 16
		Me._optOpcionCajaBancos_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optOpcionCajaBancos_0.BackColor = System.Drawing.SystemColors.Control
		Me._optOpcionCajaBancos_0.CausesValidation = True
		Me._optOpcionCajaBancos_0.Enabled = True
		Me._optOpcionCajaBancos_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optOpcionCajaBancos_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._optOpcionCajaBancos_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optOpcionCajaBancos_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optOpcionCajaBancos_0.TabStop = True
		Me._optOpcionCajaBancos_0.Checked = False
		Me._optOpcionCajaBancos_0.Visible = True
		Me._optOpcionCajaBancos_0.Name = "_optOpcionCajaBancos_0"
		Me.Frame3.Text = "Seleccionar Libro Auxiliar"
		Me.Frame3.Size = New System.Drawing.Size(308, 48)
		Me.Frame3.Location = New System.Drawing.Point(0, 120)
		Me.Frame3.TabIndex = 13
		Me.Frame3.BackColor = System.Drawing.SystemColors.Control
		Me.Frame3.Enabled = True
		Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame3.Visible = True
		Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame3.Name = "Frame3"
		Me.cboLibroAuxiliar.Size = New System.Drawing.Size(249, 21)
		Me.cboLibroAuxiliar.Location = New System.Drawing.Point(5, 18)
		Me.cboLibroAuxiliar.TabIndex = 14
		Me.cboLibroAuxiliar.BackColor = System.Drawing.SystemColors.Window
		Me.cboLibroAuxiliar.CausesValidation = True
		Me.cboLibroAuxiliar.Enabled = True
		Me.cboLibroAuxiliar.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboLibroAuxiliar.IntegralHeight = True
		Me.cboLibroAuxiliar.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboLibroAuxiliar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboLibroAuxiliar.Sorted = False
		Me.cboLibroAuxiliar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboLibroAuxiliar.TabStop = True
		Me.cboLibroAuxiliar.Visible = True
		Me.cboLibroAuxiliar.Name = "cboLibroAuxiliar"
		Me.fraDetallado.Text = "Diario General Detallado"
		Me.fraDetallado.Size = New System.Drawing.Size(309, 62)
		Me.fraDetallado.Location = New System.Drawing.Point(0, 254)
		Me.fraDetallado.TabIndex = 7
		Me.fraDetallado.BackColor = System.Drawing.SystemColors.Control
		Me.fraDetallado.Enabled = True
		Me.fraDetallado.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraDetallado.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraDetallado.Visible = True
		Me.fraDetallado.Padding = New System.Windows.Forms.Padding(0)
		Me.fraDetallado.Name = "fraDetallado"
		DTPicker1.OcxState = CType(resources.GetObject("DTPicker1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.DTPicker1.Size = New System.Drawing.Size(172, 20)
		Me.DTPicker1.Location = New System.Drawing.Point(132, 39)
		Me.DTPicker1.TabIndex = 18
		Me.DTPicker1.Name = "DTPicker1"
		DTPickerFecInicio.OcxState = CType(resources.GetObject("DTPickerFecInicio.OcxState"), System.Windows.Forms.AxHost.State)
		Me.DTPickerFecInicio.Size = New System.Drawing.Size(172, 20)
		Me.DTPickerFecInicio.Location = New System.Drawing.Point(132, 15)
		Me.DTPickerFecInicio.TabIndex = 19
		Me.DTPickerFecInicio.Name = "DTPickerFecInicio"
		Me.Label1.Text = "Fecha Inicial"
		Me.Label1.Size = New System.Drawing.Size(97, 20)
		Me.Label1.Location = New System.Drawing.Point(16, 20)
		Me.Label1.TabIndex = 9
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
		Me.Label2.Text = "Fecha Final"
		Me.Label2.Size = New System.Drawing.Size(71, 19)
		Me.Label2.Location = New System.Drawing.Point(16, 41)
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
		Me.Frame1.Size = New System.Drawing.Size(308, 122)
		Me.Frame1.Location = New System.Drawing.Point(0, -5)
		Me.Frame1.TabIndex = 4
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.Option1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Option1.Text = "Letras x Cobrar"
		Me.Option1.Size = New System.Drawing.Size(120, 14)
		Me.Option1.Location = New System.Drawing.Point(9, 96)
		Me.Option1.TabIndex = 12
		Me.Option1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Option1.BackColor = System.Drawing.SystemColors.Control
		Me.Option1.CausesValidation = True
		Me.Option1.Enabled = True
		Me.Option1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Option1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Option1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Option1.Appearance = System.Windows.Forms.Appearance.Normal
		Me.Option1.TabStop = True
		Me.Option1.Checked = False
		Me.Option1.Visible = True
		Me.Option1.Name = "Option1"
		Me._optOpcion_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optOpcion_3.Text = "Letras x Pagar"
		Me._optOpcion_3.Size = New System.Drawing.Size(143, 18)
		Me._optOpcion_3.Location = New System.Drawing.Point(9, 73)
		Me._optOpcion_3.TabIndex = 11
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
		Me._optOpcion_2.Text = "Registro de Ventas"
		Me._optOpcion_2.Size = New System.Drawing.Size(143, 18)
		Me._optOpcion_2.Location = New System.Drawing.Point(9, 54)
		Me._optOpcion_2.TabIndex = 10
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
		Me._optOpcion_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optOpcion_1.Text = "Registro de Compras"
		Me._optOpcion_1.Size = New System.Drawing.Size(143, 18)
		Me._optOpcion_1.Location = New System.Drawing.Point(9, 33)
		Me._optOpcion_1.TabIndex = 6
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
		Me._optOpcion_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optOpcion_0.Text = "Caja y Bancos"
		Me._optOpcion_0.Size = New System.Drawing.Size(150, 18)
		Me._optOpcion_0.Location = New System.Drawing.Point(9, 15)
		Me._optOpcion_0.TabIndex = 5
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
		Me.Frame2.Size = New System.Drawing.Size(308, 33)
		Me.Frame2.Location = New System.Drawing.Point(0, 216)
		Me.Frame2.TabIndex = 2
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame2.Name = "Frame2"
		Me.chkAcumula.Text = "Acumulado"
		Me.chkAcumula.Size = New System.Drawing.Size(115, 18)
		Me.chkAcumula.Location = New System.Drawing.Point(14, 12)
		Me.chkAcumula.TabIndex = 3
		Me.chkAcumula.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkAcumula.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkAcumula.BackColor = System.Drawing.SystemColors.Control
		Me.chkAcumula.CausesValidation = True
		Me.chkAcumula.Enabled = True
		Me.chkAcumula.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkAcumula.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkAcumula.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkAcumula.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkAcumula.TabStop = True
		Me.chkAcumula.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkAcumula.Visible = True
		Me.chkAcumula.Name = "chkAcumula"
		Me._cmdBotones_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdBotones_1.Text = "&Cancelar"
		Me._cmdBotones_1.Size = New System.Drawing.Size(70, 23)
		Me._cmdBotones_1.Location = New System.Drawing.Point(159, 348)
		Me._cmdBotones_1.TabIndex = 1
		Me._cmdBotones_1.BackColor = System.Drawing.SystemColors.Control
		Me._cmdBotones_1.CausesValidation = True
		Me._cmdBotones_1.Enabled = True
		Me._cmdBotones_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdBotones_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdBotones_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdBotones_1.TabStop = True
		Me._cmdBotones_1.Name = "_cmdBotones_1"
		Me._cmdBotones_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdBotones_0.Text = "&Aceptar"
		Me._cmdBotones_0.Size = New System.Drawing.Size(70, 23)
		Me._cmdBotones_0.Location = New System.Drawing.Point(69, 348)
		Me._cmdBotones_0.TabIndex = 0
		Me._cmdBotones_0.BackColor = System.Drawing.SystemColors.Control
		Me._cmdBotones_0.CausesValidation = True
		Me._cmdBotones_0.Enabled = True
		Me._cmdBotones_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdBotones_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdBotones_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdBotones_0.TabStop = True
		Me._cmdBotones_0.Name = "_cmdBotones_0"
		Me.cmdBotones.SetIndex(_cmdBotones_1, CType(1, Short))
		Me.cmdBotones.SetIndex(_cmdBotones_0, CType(0, Short))
		Me.optOpcion.SetIndex(_optOpcion_3, CType(3, Short))
		Me.optOpcion.SetIndex(_optOpcion_2, CType(2, Short))
		Me.optOpcion.SetIndex(_optOpcion_1, CType(1, Short))
		Me.optOpcion.SetIndex(_optOpcion_0, CType(0, Short))
		Me.optOpcionCajaBancos.SetIndex(_optOpcionCajaBancos_1, CType(1, Short))
		Me.optOpcionCajaBancos.SetIndex(_optOpcionCajaBancos_0, CType(0, Short))
		CType(Me.optOpcionCajaBancos, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.optOpcion, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.cmdBotones, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DTPickerFecInicio, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DTPicker1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Controls.Add(fraCajaBancos)
		Me.Controls.Add(Frame3)
		Me.Controls.Add(fraDetallado)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(Frame2)
		Me.Controls.Add(_cmdBotones_1)
		Me.Controls.Add(_cmdBotones_0)
		Me.fraCajaBancos.Controls.Add(_optOpcionCajaBancos_1)
		Me.fraCajaBancos.Controls.Add(_optOpcionCajaBancos_0)
		Me.Frame3.Controls.Add(cboLibroAuxiliar)
		Me.fraDetallado.Controls.Add(DTPicker1)
		Me.fraDetallado.Controls.Add(DTPickerFecInicio)
		Me.fraDetallado.Controls.Add(Label1)
		Me.fraDetallado.Controls.Add(Label2)
		Me.Frame1.Controls.Add(Option1)
		Me.Frame1.Controls.Add(_optOpcion_3)
		Me.Frame1.Controls.Add(_optOpcion_2)
		Me.Frame1.Controls.Add(_optOpcion_1)
		Me.Frame1.Controls.Add(_optOpcion_0)
		Me.Frame2.Controls.Add(chkAcumula)
		Me.fraCajaBancos.ResumeLayout(False)
		Me.Frame3.ResumeLayout(False)
		Me.fraDetallado.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.Frame2.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class