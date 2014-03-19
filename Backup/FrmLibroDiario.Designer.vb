<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FrmLibroDiario
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
	Public WithEvents _Ctr_Ayuda1_0 As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents _Ctr_Ayuda1_1 As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents fraResumido As System.Windows.Forms.GroupBox
	Public WithEvents DTPickerFecFinal As AxMSComCtl2.AxDTPicker
	Public WithEvents DTPickerFecInicio As AxMSComCtl2.AxDTPicker
	Public WithEvents _Ctr_Ayuda2_0 As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents _Ctr_Ayuda2_1 As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents fraDetallado As System.Windows.Forms.GroupBox
	Public WithEvents _optOpcion_1 As System.Windows.Forms.RadioButton
	Public WithEvents _optOpcion_0 As System.Windows.Forms.RadioButton
	Public WithEvents _optOpcion_2 As System.Windows.Forms.RadioButton
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents _cmdBotones_1 As System.Windows.Forms.Button
	Public WithEvents _cmdBotones_0 As System.Windows.Forms.Button
	Public WithEvents cboMes As System.Windows.Forms.ComboBox
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents Ctr_Ayuda1 As AxCtr_AyudaArray
	Public WithEvents Ctr_Ayuda2 As AxCtr_AyudaArray
	Public WithEvents cmdBotones As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
	Public WithEvents optOpcion As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmLibroDiario))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.fraResumido = New System.Windows.Forms.GroupBox
		Me._Ctr_Ayuda1_0 = New Axctrlayuda_f.AxCtr_Ayuda
		Me._Ctr_Ayuda1_1 = New Axctrlayuda_f.AxCtr_Ayuda
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.fraDetallado = New System.Windows.Forms.GroupBox
		Me.DTPickerFecFinal = New AxMSComCtl2.AxDTPicker
		Me.DTPickerFecInicio = New AxMSComCtl2.AxDTPicker
		Me._Ctr_Ayuda2_0 = New Axctrlayuda_f.AxCtr_Ayuda
		Me._Ctr_Ayuda2_1 = New Axctrlayuda_f.AxCtr_Ayuda
		Me.Label1 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me._optOpcion_1 = New System.Windows.Forms.RadioButton
		Me._optOpcion_0 = New System.Windows.Forms.RadioButton
		Me._optOpcion_2 = New System.Windows.Forms.RadioButton
		Me._cmdBotones_1 = New System.Windows.Forms.Button
		Me._cmdBotones_0 = New System.Windows.Forms.Button
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.cboMes = New System.Windows.Forms.ComboBox
		Me.Ctr_Ayuda1 = New AxCtr_AyudaArray(components)
		Me.Ctr_Ayuda2 = New AxCtr_AyudaArray(components)
		Me.cmdBotones = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(components)
		Me.optOpcion = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.fraResumido.SuspendLayout()
		Me.fraDetallado.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.Frame2.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me._Ctr_Ayuda1_0, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me._Ctr_Ayuda1_1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DTPickerFecFinal, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DTPickerFecInicio, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me._Ctr_Ayuda2_0, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me._Ctr_Ayuda2_1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Ctr_Ayuda1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Ctr_Ayuda2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.cmdBotones, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.optOpcion, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.BackColor = System.Drawing.Color.FromARGB(192, 192, 255)
		Me.Text = "Libro Diario"
		Me.ClientSize = New System.Drawing.Size(411, 345)
		Me.Location = New System.Drawing.Point(4, 30)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
		Me.Name = "FrmLibroDiario"
		Me.fraResumido.BackColor = System.Drawing.Color.FromARGB(192, 255, 255)
		Me.fraResumido.Text = "Diario General Resumido"
		Me.fraResumido.Size = New System.Drawing.Size(343, 121)
		Me.fraResumido.Location = New System.Drawing.Point(32, 149)
		Me.fraResumido.TabIndex = 17
		Me.fraResumido.Enabled = True
		Me.fraResumido.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraResumido.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraResumido.Visible = True
		Me.fraResumido.Padding = New System.Windows.Forms.Padding(0)
		Me.fraResumido.Name = "fraResumido"
		_Ctr_Ayuda1_0.OcxState = CType(resources.GetObject("_Ctr_Ayuda1_0.OcxState"), System.Windows.Forms.AxHost.State)
		Me._Ctr_Ayuda1_0.Size = New System.Drawing.Size(254, 22)
		Me._Ctr_Ayuda1_0.Location = New System.Drawing.Point(85, 29)
		Me._Ctr_Ayuda1_0.TabIndex = 18
		Me._Ctr_Ayuda1_0.Name = "_Ctr_Ayuda1_0"
		_Ctr_Ayuda1_1.OcxState = CType(resources.GetObject("_Ctr_Ayuda1_1.OcxState"), System.Windows.Forms.AxHost.State)
		Me._Ctr_Ayuda1_1.Size = New System.Drawing.Size(254, 22)
		Me._Ctr_Ayuda1_1.Location = New System.Drawing.Point(85, 50)
		Me._Ctr_Ayuda1_1.TabIndex = 19
		Me._Ctr_Ayuda1_1.Name = "_Ctr_Ayuda1_1"
		Me.Label4.BackColor = System.Drawing.Color.FromARGB(192, 255, 255)
		Me.Label4.Text = "Asiento"
		Me.Label4.Size = New System.Drawing.Size(59, 16)
		Me.Label4.Location = New System.Drawing.Point(12, 31)
		Me.Label4.TabIndex = 21
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label4.Enabled = True
		Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.Visible = True
		Me.Label4.AutoSize = False
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.Name = "Label4"
		Me.Label3.BackColor = System.Drawing.Color.FromARGB(192, 255, 255)
		Me.Label3.Text = "SubAsiento"
		Me.Label3.Size = New System.Drawing.Size(64, 20)
		Me.Label3.Location = New System.Drawing.Point(12, 53)
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
		Me.fraDetallado.Text = "Diario General Detallado"
		Me.fraDetallado.Size = New System.Drawing.Size(343, 121)
		Me.fraDetallado.Location = New System.Drawing.Point(32, 149)
		Me.fraDetallado.TabIndex = 8
		Me.fraDetallado.BackColor = System.Drawing.SystemColors.Control
		Me.fraDetallado.Enabled = True
		Me.fraDetallado.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraDetallado.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraDetallado.Visible = True
		Me.fraDetallado.Padding = New System.Windows.Forms.Padding(0)
		Me.fraDetallado.Name = "fraDetallado"
		DTPickerFecFinal.OcxState = CType(resources.GetObject("DTPickerFecFinal.OcxState"), System.Windows.Forms.AxHost.State)
		Me.DTPickerFecFinal.Size = New System.Drawing.Size(165, 20)
		Me.DTPickerFecFinal.Location = New System.Drawing.Point(86, 37)
		Me.DTPickerFecFinal.TabIndex = 9
		Me.DTPickerFecFinal.Name = "DTPickerFecFinal"
		DTPickerFecInicio.OcxState = CType(resources.GetObject("DTPickerFecInicio.OcxState"), System.Windows.Forms.AxHost.State)
		Me.DTPickerFecInicio.Size = New System.Drawing.Size(164, 20)
		Me.DTPickerFecInicio.Location = New System.Drawing.Point(87, 15)
		Me.DTPickerFecInicio.TabIndex = 10
		Me.DTPickerFecInicio.Name = "DTPickerFecInicio"
		_Ctr_Ayuda2_0.OcxState = CType(resources.GetObject("_Ctr_Ayuda2_0.OcxState"), System.Windows.Forms.AxHost.State)
		Me._Ctr_Ayuda2_0.Size = New System.Drawing.Size(254, 22)
		Me._Ctr_Ayuda2_0.Location = New System.Drawing.Point(85, 64)
		Me._Ctr_Ayuda2_0.TabIndex = 11
		Me._Ctr_Ayuda2_0.Name = "_Ctr_Ayuda2_0"
		_Ctr_Ayuda2_1.OcxState = CType(resources.GetObject("_Ctr_Ayuda2_1.OcxState"), System.Windows.Forms.AxHost.State)
		Me._Ctr_Ayuda2_1.Size = New System.Drawing.Size(254, 22)
		Me._Ctr_Ayuda2_1.Location = New System.Drawing.Point(85, 85)
		Me._Ctr_Ayuda2_1.TabIndex = 12
		Me._Ctr_Ayuda2_1.Name = "_Ctr_Ayuda2_1"
		Me.Label1.Text = "Fecha Inicial"
		Me.Label1.Size = New System.Drawing.Size(97, 20)
		Me.Label1.Location = New System.Drawing.Point(13, 20)
		Me.Label1.TabIndex = 16
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
		Me.Label2.Location = New System.Drawing.Point(13, 41)
		Me.Label2.TabIndex = 15
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
		Me.Label5.Text = "Asiento"
		Me.Label5.Size = New System.Drawing.Size(69, 15)
		Me.Label5.Location = New System.Drawing.Point(13, 67)
		Me.Label5.TabIndex = 14
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
		Me.Label6.Text = "SubAsiento"
		Me.Label6.Size = New System.Drawing.Size(69, 18)
		Me.Label6.Location = New System.Drawing.Point(12, 89)
		Me.Label6.TabIndex = 13
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label6.BackColor = System.Drawing.SystemColors.Control
		Me.Label6.Enabled = True
		Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label6.UseMnemonic = True
		Me.Label6.Visible = True
		Me.Label6.AutoSize = False
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label6.Name = "Label6"
		Me.Frame1.BackColor = System.Drawing.Color.FromARGB(192, 255, 255)
		Me.Frame1.Size = New System.Drawing.Size(342, 84)
		Me.Frame1.Location = New System.Drawing.Point(32, 8)
		Me.Frame1.TabIndex = 4
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me._optOpcion_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optOpcion_1.BackColor = System.Drawing.Color.FromARGB(192, 255, 255)
		Me._optOpcion_1.Text = "Diario General Resumido Tipo 1"
		Me._optOpcion_1.Size = New System.Drawing.Size(177, 13)
		Me._optOpcion_1.Location = New System.Drawing.Point(16, 40)
		Me._optOpcion_1.TabIndex = 7
		Me._optOpcion_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
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
		Me._optOpcion_0.BackColor = System.Drawing.Color.FromARGB(192, 255, 255)
		Me._optOpcion_0.Text = "Diario General Detallado"
		Me._optOpcion_0.Size = New System.Drawing.Size(153, 25)
		Me._optOpcion_0.Location = New System.Drawing.Point(16, 16)
		Me._optOpcion_0.TabIndex = 6
		Me._optOpcion_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
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
		Me._optOpcion_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optOpcion_2.BackColor = System.Drawing.Color.FromARGB(192, 255, 255)
		Me._optOpcion_2.Text = "Diario General Resumido Tipo 2"
		Me._optOpcion_2.Size = New System.Drawing.Size(177, 25)
		Me._optOpcion_2.Location = New System.Drawing.Point(16, 56)
		Me._optOpcion_2.TabIndex = 5
		Me._optOpcion_2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
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
		Me._cmdBotones_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdBotones_1.Text = "&Cancelar"
		Me._cmdBotones_1.Size = New System.Drawing.Size(82, 23)
		Me._cmdBotones_1.Location = New System.Drawing.Point(217, 296)
		Me._cmdBotones_1.TabIndex = 3
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
		Me._cmdBotones_0.Size = New System.Drawing.Size(82, 23)
		Me._cmdBotones_0.Location = New System.Drawing.Point(110, 296)
		Me._cmdBotones_0.TabIndex = 2
		Me._cmdBotones_0.BackColor = System.Drawing.SystemColors.Control
		Me._cmdBotones_0.CausesValidation = True
		Me._cmdBotones_0.Enabled = True
		Me._cmdBotones_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdBotones_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdBotones_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdBotones_0.TabStop = True
		Me._cmdBotones_0.Name = "_cmdBotones_0"
		Me.Frame2.BackColor = System.Drawing.Color.FromARGB(192, 255, 255)
		Me.Frame2.Text = "Seleccionar Mes"
		Me.Frame2.Size = New System.Drawing.Size(342, 47)
		Me.Frame2.Location = New System.Drawing.Point(32, 93)
		Me.Frame2.TabIndex = 0
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame2.Name = "Frame2"
		Me.cboMes.Size = New System.Drawing.Size(330, 21)
		Me.cboMes.Location = New System.Drawing.Point(6, 17)
		Me.cboMes.TabIndex = 1
		Me.cboMes.BackColor = System.Drawing.SystemColors.Window
		Me.cboMes.CausesValidation = True
		Me.cboMes.Enabled = True
		Me.cboMes.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboMes.IntegralHeight = True
		Me.cboMes.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboMes.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboMes.Sorted = False
		Me.cboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboMes.TabStop = True
		Me.cboMes.Visible = True
		Me.cboMes.Name = "cboMes"
		Me.Controls.Add(fraResumido)
		Me.Controls.Add(fraDetallado)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(_cmdBotones_1)
		Me.Controls.Add(_cmdBotones_0)
		Me.Controls.Add(Frame2)
		Me.fraResumido.Controls.Add(_Ctr_Ayuda1_0)
		Me.fraResumido.Controls.Add(_Ctr_Ayuda1_1)
		Me.fraResumido.Controls.Add(Label4)
		Me.fraResumido.Controls.Add(Label3)
		Me.fraDetallado.Controls.Add(DTPickerFecFinal)
		Me.fraDetallado.Controls.Add(DTPickerFecInicio)
		Me.fraDetallado.Controls.Add(_Ctr_Ayuda2_0)
		Me.fraDetallado.Controls.Add(_Ctr_Ayuda2_1)
		Me.fraDetallado.Controls.Add(Label1)
		Me.fraDetallado.Controls.Add(Label2)
		Me.fraDetallado.Controls.Add(Label5)
		Me.fraDetallado.Controls.Add(Label6)
		Me.Frame1.Controls.Add(_optOpcion_1)
		Me.Frame1.Controls.Add(_optOpcion_0)
		Me.Frame1.Controls.Add(_optOpcion_2)
		Me.Frame2.Controls.Add(cboMes)
		Me.Ctr_Ayuda1.SetIndex(_Ctr_Ayuda1_0, CType(0, Short))
		Me.Ctr_Ayuda1.SetIndex(_Ctr_Ayuda1_1, CType(1, Short))
		Me.Ctr_Ayuda2.SetIndex(_Ctr_Ayuda2_0, CType(0, Short))
		Me.Ctr_Ayuda2.SetIndex(_Ctr_Ayuda2_1, CType(1, Short))
		Me.cmdBotones.SetIndex(_cmdBotones_1, CType(1, Short))
		Me.cmdBotones.SetIndex(_cmdBotones_0, CType(0, Short))
		Me.optOpcion.SetIndex(_optOpcion_1, CType(1, Short))
		Me.optOpcion.SetIndex(_optOpcion_0, CType(0, Short))
		Me.optOpcion.SetIndex(_optOpcion_2, CType(2, Short))
		CType(Me.optOpcion, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.cmdBotones, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Ctr_Ayuda2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Ctr_Ayuda1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me._Ctr_Ayuda2_1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me._Ctr_Ayuda2_0, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DTPickerFecInicio, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DTPickerFecFinal, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me._Ctr_Ayuda1_1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me._Ctr_Ayuda1_0, System.ComponentModel.ISupportInitialize).EndInit()
		Me.fraResumido.ResumeLayout(False)
		Me.fraDetallado.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.Frame2.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class