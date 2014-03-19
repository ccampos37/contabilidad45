<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FrmLibroDiarioSimplificado
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
	Public WithEvents cboMes As System.Windows.Forms.ComboBox
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents cmdImprimir As System.Windows.Forms.Button
	Public WithEvents cmdSalir As System.Windows.Forms.Button
	Public WithEvents _optOpcion_0 As System.Windows.Forms.RadioButton
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents DTPickerFecFinal As AxMSComCtl2.AxDTPicker
	Public WithEvents DTPickerFecInicio As AxMSComCtl2.AxDTPicker
	Public WithEvents _Ctr_Ayuda2_0 As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents _Ctr_Ayuda2_1 As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents fraDetallado As System.Windows.Forms.GroupBox
	Public WithEvents Ctr_Ayuda2 As AxCtr_AyudaArray
	Public WithEvents optOpcion As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmLibroDiarioSimplificado))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.cboMes = New System.Windows.Forms.ComboBox
		Me.cmdImprimir = New System.Windows.Forms.Button
		Me.cmdSalir = New System.Windows.Forms.Button
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me._optOpcion_0 = New System.Windows.Forms.RadioButton
		Me.fraDetallado = New System.Windows.Forms.GroupBox
		Me.DTPickerFecFinal = New AxMSComCtl2.AxDTPicker
		Me.DTPickerFecInicio = New AxMSComCtl2.AxDTPicker
		Me._Ctr_Ayuda2_0 = New Axctrlayuda_f.AxCtr_Ayuda
		Me._Ctr_Ayuda2_1 = New Axctrlayuda_f.AxCtr_Ayuda
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Ctr_Ayuda2 = New AxCtr_AyudaArray(components)
		Me.optOpcion = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.Frame2.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.fraDetallado.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.DTPickerFecFinal, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DTPickerFecInicio, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me._Ctr_Ayuda2_0, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me._Ctr_Ayuda2_1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Ctr_Ayuda2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.optOpcion, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me.Text = "Libro diario simplificado"
		Me.ClientSize = New System.Drawing.Size(386, 303)
		Me.Location = New System.Drawing.Point(8, 31)
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
		Me.Name = "FrmLibroDiarioSimplificado"
		Me.Frame2.BackColor = System.Drawing.Color.White
		Me.Frame2.Text = "Seleccionar Mes"
		Me.Frame2.Size = New System.Drawing.Size(342, 47)
		Me.Frame2.Location = New System.Drawing.Point(16, 61)
		Me.Frame2.TabIndex = 13
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame2.Name = "Frame2"
		Me.cboMes.Size = New System.Drawing.Size(330, 21)
		Me.cboMes.Location = New System.Drawing.Point(6, 17)
		Me.cboMes.TabIndex = 14
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
		Me.cmdImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdImprimir.BackColor = System.Drawing.SystemColors.Control
		Me.cmdImprimir.Text = "&Aceptar"
		Me.cmdImprimir.Size = New System.Drawing.Size(82, 23)
		Me.cmdImprimir.Location = New System.Drawing.Point(94, 248)
		Me.cmdImprimir.TabIndex = 12
		Me.cmdImprimir.CausesValidation = True
		Me.cmdImprimir.Enabled = True
		Me.cmdImprimir.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdImprimir.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdImprimir.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdImprimir.TabStop = True
		Me.cmdImprimir.Name = "cmdImprimir"
		Me.cmdSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdSalir.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSalir.Text = "&Cancelar"
		Me.cmdSalir.Size = New System.Drawing.Size(82, 23)
		Me.cmdSalir.Location = New System.Drawing.Point(201, 248)
		Me.cmdSalir.TabIndex = 11
		Me.cmdSalir.CausesValidation = True
		Me.cmdSalir.Enabled = True
		Me.cmdSalir.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSalir.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSalir.TabStop = True
		Me.cmdSalir.Name = "cmdSalir"
		Me.Frame1.BackColor = System.Drawing.Color.White
		Me.Frame1.Size = New System.Drawing.Size(342, 44)
		Me.Frame1.Location = New System.Drawing.Point(16, 16)
		Me.Frame1.TabIndex = 9
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me._optOpcion_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optOpcion_0.BackColor = System.Drawing.Color.White
		Me._optOpcion_0.Text = "Diario General Detallado"
		Me._optOpcion_0.Size = New System.Drawing.Size(153, 25)
		Me._optOpcion_0.Location = New System.Drawing.Point(16, 16)
		Me._optOpcion_0.TabIndex = 10
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
		Me.fraDetallado.BackColor = System.Drawing.Color.White
		Me.fraDetallado.Text = "Diario General Detallado"
		Me.fraDetallado.Size = New System.Drawing.Size(343, 121)
		Me.fraDetallado.Location = New System.Drawing.Point(16, 109)
		Me.fraDetallado.TabIndex = 0
		Me.fraDetallado.Enabled = True
		Me.fraDetallado.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraDetallado.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraDetallado.Visible = True
		Me.fraDetallado.Padding = New System.Windows.Forms.Padding(0)
		Me.fraDetallado.Name = "fraDetallado"
		DTPickerFecFinal.OcxState = CType(resources.GetObject("DTPickerFecFinal.OcxState"), System.Windows.Forms.AxHost.State)
		Me.DTPickerFecFinal.Size = New System.Drawing.Size(165, 20)
		Me.DTPickerFecFinal.Location = New System.Drawing.Point(86, 37)
		Me.DTPickerFecFinal.TabIndex = 1
		Me.DTPickerFecFinal.Name = "DTPickerFecFinal"
		DTPickerFecInicio.OcxState = CType(resources.GetObject("DTPickerFecInicio.OcxState"), System.Windows.Forms.AxHost.State)
		Me.DTPickerFecInicio.Size = New System.Drawing.Size(164, 20)
		Me.DTPickerFecInicio.Location = New System.Drawing.Point(87, 15)
		Me.DTPickerFecInicio.TabIndex = 2
		Me.DTPickerFecInicio.Name = "DTPickerFecInicio"
		_Ctr_Ayuda2_0.OcxState = CType(resources.GetObject("_Ctr_Ayuda2_0.OcxState"), System.Windows.Forms.AxHost.State)
		Me._Ctr_Ayuda2_0.Size = New System.Drawing.Size(254, 22)
		Me._Ctr_Ayuda2_0.Location = New System.Drawing.Point(85, 64)
		Me._Ctr_Ayuda2_0.TabIndex = 3
		Me._Ctr_Ayuda2_0.Name = "_Ctr_Ayuda2_0"
		_Ctr_Ayuda2_1.OcxState = CType(resources.GetObject("_Ctr_Ayuda2_1.OcxState"), System.Windows.Forms.AxHost.State)
		Me._Ctr_Ayuda2_1.Size = New System.Drawing.Size(254, 22)
		Me._Ctr_Ayuda2_1.Location = New System.Drawing.Point(85, 85)
		Me._Ctr_Ayuda2_1.TabIndex = 4
		Me._Ctr_Ayuda2_1.Name = "_Ctr_Ayuda2_1"
		Me.Label6.Text = "SubAsiento"
		Me.Label6.Size = New System.Drawing.Size(69, 18)
		Me.Label6.Location = New System.Drawing.Point(12, 89)
		Me.Label6.TabIndex = 8
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
		Me.Label5.Text = "Asiento"
		Me.Label5.Size = New System.Drawing.Size(69, 15)
		Me.Label5.Location = New System.Drawing.Point(13, 67)
		Me.Label5.TabIndex = 7
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
		Me.Label2.Text = "Fecha Final"
		Me.Label2.Size = New System.Drawing.Size(71, 19)
		Me.Label2.Location = New System.Drawing.Point(13, 41)
		Me.Label2.TabIndex = 6
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
		Me.Label1.Text = "Fecha Inicial"
		Me.Label1.Size = New System.Drawing.Size(97, 20)
		Me.Label1.Location = New System.Drawing.Point(13, 20)
		Me.Label1.TabIndex = 5
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
		Me.Controls.Add(Frame2)
		Me.Controls.Add(cmdImprimir)
		Me.Controls.Add(cmdSalir)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(fraDetallado)
		Me.Frame2.Controls.Add(cboMes)
		Me.Frame1.Controls.Add(_optOpcion_0)
		Me.fraDetallado.Controls.Add(DTPickerFecFinal)
		Me.fraDetallado.Controls.Add(DTPickerFecInicio)
		Me.fraDetallado.Controls.Add(_Ctr_Ayuda2_0)
		Me.fraDetallado.Controls.Add(_Ctr_Ayuda2_1)
		Me.fraDetallado.Controls.Add(Label6)
		Me.fraDetallado.Controls.Add(Label5)
		Me.fraDetallado.Controls.Add(Label2)
		Me.fraDetallado.Controls.Add(Label1)
		Me.Ctr_Ayuda2.SetIndex(_Ctr_Ayuda2_0, CType(0, Short))
		Me.Ctr_Ayuda2.SetIndex(_Ctr_Ayuda2_1, CType(1, Short))
		Me.optOpcion.SetIndex(_optOpcion_0, CType(0, Short))
		CType(Me.optOpcion, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Ctr_Ayuda2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me._Ctr_Ayuda2_1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me._Ctr_Ayuda2_0, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DTPickerFecInicio, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DTPickerFecFinal, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame2.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.fraDetallado.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class