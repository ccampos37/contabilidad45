<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRepMayor
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
	Public WithEvents chkAcumula As System.Windows.Forms.CheckBox
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents _cmdBotones_0 As System.Windows.Forms.Button
	Public WithEvents _cmdBotones_1 As System.Windows.Forms.Button
	Public WithEvents Ctr_AyudaSubAsiento As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents Ctr_AyudaAsiento As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents _Ctr_Ayucuenta_0 As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents DTPickerFecFinal As AxMSComCtl2.AxDTPicker
	Public WithEvents DTPickerFecInicio As AxMSComCtl2.AxDTPicker
	Public WithEvents _Ctr_Ayucuenta_1 As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents Ctr_AyudaEntidad As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents fraDetallado As System.Windows.Forms.GroupBox
	Public WithEvents Ctr_Ayucuenta As AxCtr_AyudaArray
	Public WithEvents cmdBotones As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRepMayor))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.chkAcumula = New System.Windows.Forms.CheckBox
		Me._cmdBotones_0 = New System.Windows.Forms.Button
		Me._cmdBotones_1 = New System.Windows.Forms.Button
		Me.fraDetallado = New System.Windows.Forms.GroupBox
		Me.Ctr_AyudaSubAsiento = New Axctrlayuda_f.AxCtr_Ayuda
		Me.Ctr_AyudaAsiento = New Axctrlayuda_f.AxCtr_Ayuda
		Me._Ctr_Ayucuenta_0 = New Axctrlayuda_f.AxCtr_Ayuda
		Me.DTPickerFecFinal = New AxMSComCtl2.AxDTPicker
		Me.DTPickerFecInicio = New AxMSComCtl2.AxDTPicker
		Me._Ctr_Ayucuenta_1 = New Axctrlayuda_f.AxCtr_Ayuda
		Me.Ctr_AyudaEntidad = New Axctrlayuda_f.AxCtr_Ayuda
		Me.Label8 = New System.Windows.Forms.Label
		Me.Label7 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Ctr_Ayucuenta = New AxCtr_AyudaArray(components)
		Me.cmdBotones = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(components)
		Me.Frame1.SuspendLayout()
		Me.fraDetallado.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.Ctr_AyudaSubAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Ctr_AyudaAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me._Ctr_Ayucuenta_0, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DTPickerFecFinal, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DTPickerFecInicio, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me._Ctr_Ayucuenta_1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Ctr_AyudaEntidad, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Ctr_Ayucuenta, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.cmdBotones, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "frmReporteParametro"
		Me.ClientSize = New System.Drawing.Size(419, 276)
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
		Me.Name = "frmRepMayor"
		Me.Frame1.Size = New System.Drawing.Size(397, 41)
		Me.Frame1.Location = New System.Drawing.Point(0, 1)
		Me.Frame1.TabIndex = 10
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.chkAcumula.Text = "Acumulado"
		Me.chkAcumula.Size = New System.Drawing.Size(115, 18)
		Me.chkAcumula.Location = New System.Drawing.Point(14, 12)
		Me.chkAcumula.TabIndex = 0
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
		Me._cmdBotones_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdBotones_0.Text = "&Aceptar"
		Me._cmdBotones_0.Size = New System.Drawing.Size(88, 25)
		Me._cmdBotones_0.Location = New System.Drawing.Point(111, 231)
		Me._cmdBotones_0.TabIndex = 4
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
		Me._cmdBotones_1.Size = New System.Drawing.Size(88, 25)
		Me._cmdBotones_1.Location = New System.Drawing.Point(201, 231)
		Me._cmdBotones_1.TabIndex = 5
		Me._cmdBotones_1.BackColor = System.Drawing.SystemColors.Control
		Me._cmdBotones_1.CausesValidation = True
		Me._cmdBotones_1.Enabled = True
		Me._cmdBotones_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdBotones_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdBotones_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdBotones_1.TabStop = True
		Me._cmdBotones_1.Name = "_cmdBotones_1"
		Me.fraDetallado.Size = New System.Drawing.Size(397, 175)
		Me.fraDetallado.Location = New System.Drawing.Point(0, 39)
		Me.fraDetallado.TabIndex = 6
		Me.fraDetallado.BackColor = System.Drawing.SystemColors.Control
		Me.fraDetallado.Enabled = True
		Me.fraDetallado.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraDetallado.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraDetallado.Visible = True
		Me.fraDetallado.Padding = New System.Windows.Forms.Padding(0)
		Me.fraDetallado.Name = "fraDetallado"
		Ctr_AyudaSubAsiento.OcxState = CType(resources.GetObject("Ctr_AyudaSubAsiento.OcxState"), System.Windows.Forms.AxHost.State)
		Me.Ctr_AyudaSubAsiento.Size = New System.Drawing.Size(323, 21)
		Me.Ctr_AyudaSubAsiento.Location = New System.Drawing.Point(69, 143)
		Me.Ctr_AyudaSubAsiento.TabIndex = 12
		Me.Ctr_AyudaSubAsiento.Name = "Ctr_AyudaSubAsiento"
		Ctr_AyudaAsiento.OcxState = CType(resources.GetObject("Ctr_AyudaAsiento.OcxState"), System.Windows.Forms.AxHost.State)
		Me.Ctr_AyudaAsiento.Size = New System.Drawing.Size(323, 20)
		Me.Ctr_AyudaAsiento.Location = New System.Drawing.Point(69, 113)
		Me.Ctr_AyudaAsiento.TabIndex = 11
		Me.Ctr_AyudaAsiento.Name = "Ctr_AyudaAsiento"
		_Ctr_Ayucuenta_0.OcxState = CType(resources.GetObject("_Ctr_Ayucuenta_0.OcxState"), System.Windows.Forms.AxHost.State)
		Me._Ctr_Ayucuenta_0.Size = New System.Drawing.Size(323, 24)
		Me._Ctr_Ayucuenta_0.Location = New System.Drawing.Point(69, 52)
		Me._Ctr_Ayucuenta_0.TabIndex = 3
		Me._Ctr_Ayucuenta_0.Name = "_Ctr_Ayucuenta_0"
		DTPickerFecFinal.OcxState = CType(resources.GetObject("DTPickerFecFinal.OcxState"), System.Windows.Forms.AxHost.State)
		Me.DTPickerFecFinal.Size = New System.Drawing.Size(123, 20)
		Me.DTPickerFecFinal.Location = New System.Drawing.Point(270, 18)
		Me.DTPickerFecFinal.TabIndex = 2
		Me.DTPickerFecFinal.Name = "DTPickerFecFinal"
		DTPickerFecInicio.OcxState = CType(resources.GetObject("DTPickerFecInicio.OcxState"), System.Windows.Forms.AxHost.State)
		Me.DTPickerFecInicio.Size = New System.Drawing.Size(123, 20)
		Me.DTPickerFecInicio.Location = New System.Drawing.Point(69, 18)
		Me.DTPickerFecInicio.TabIndex = 1
		Me.DTPickerFecInicio.Name = "DTPickerFecInicio"
		_Ctr_Ayucuenta_1.OcxState = CType(resources.GetObject("_Ctr_Ayucuenta_1.OcxState"), System.Windows.Forms.AxHost.State)
		Me._Ctr_Ayucuenta_1.Size = New System.Drawing.Size(323, 24)
		Me._Ctr_Ayucuenta_1.Location = New System.Drawing.Point(69, 75)
		Me._Ctr_Ayucuenta_1.TabIndex = 15
		Me._Ctr_Ayucuenta_1.Name = "_Ctr_Ayucuenta_1"
		Ctr_AyudaEntidad.OcxState = CType(resources.GetObject("Ctr_AyudaEntidad.OcxState"), System.Windows.Forms.AxHost.State)
		Me.Ctr_AyudaEntidad.Size = New System.Drawing.Size(323, 20)
		Me.Ctr_AyudaEntidad.Location = New System.Drawing.Point(69, 105)
		Me.Ctr_AyudaEntidad.TabIndex = 19
		Me.Ctr_AyudaEntidad.Visible = False
		Me.Ctr_AyudaEntidad.Name = "Ctr_AyudaEntidad"
		Me.Label8.Text = "Código Analítico"
		Me.Label8.Size = New System.Drawing.Size(58, 28)
		Me.Label8.Location = New System.Drawing.Point(6, 110)
		Me.Label8.TabIndex = 18
		Me.Label8.Visible = False
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label8.BackColor = System.Drawing.SystemColors.Control
		Me.Label8.Enabled = True
		Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label8.UseMnemonic = True
		Me.Label8.AutoSize = False
		Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label8.Name = "Label8"
		Me.Label7.Text = "Hasta"
		Me.Label7.Size = New System.Drawing.Size(31, 16)
		Me.Label7.Location = New System.Drawing.Point(33, 81)
		Me.Label7.TabIndex = 17
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label7.BackColor = System.Drawing.SystemColors.Control
		Me.Label7.Enabled = True
		Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label7.UseMnemonic = True
		Me.Label7.Visible = True
		Me.Label7.AutoSize = False
		Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label7.Name = "Label7"
		Me.Label6.Text = "Desde"
		Me.Label6.Size = New System.Drawing.Size(34, 13)
		Me.Label6.Location = New System.Drawing.Point(33, 57)
		Me.Label6.TabIndex = 16
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
		Me.Label5.Text = "Sub Asiento"
		Me.Label5.Size = New System.Drawing.Size(59, 19)
		Me.Label5.Location = New System.Drawing.Point(5, 148)
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
		Me.Label4.Text = "Asiento"
		Me.Label4.Size = New System.Drawing.Size(62, 17)
		Me.Label4.Location = New System.Drawing.Point(7, 109)
		Me.Label4.TabIndex = 13
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
		Me.Label3.Text = "Cuenta :"
		Me.Label3.Size = New System.Drawing.Size(42, 17)
		Me.Label3.Location = New System.Drawing.Point(5, 42)
		Me.Label3.TabIndex = 9
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
		Me.Label1.Text = "Fecha Inicial"
		Me.Label1.Size = New System.Drawing.Size(97, 20)
		Me.Label1.Location = New System.Drawing.Point(5, 20)
		Me.Label1.TabIndex = 8
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
		Me.Label2.Size = New System.Drawing.Size(56, 19)
		Me.Label2.Location = New System.Drawing.Point(210, 21)
		Me.Label2.TabIndex = 7
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
		Me.Ctr_Ayucuenta.SetIndex(_Ctr_Ayucuenta_0, CType(0, Short))
		Me.Ctr_Ayucuenta.SetIndex(_Ctr_Ayucuenta_1, CType(1, Short))
		Me.cmdBotones.SetIndex(_cmdBotones_0, CType(0, Short))
		Me.cmdBotones.SetIndex(_cmdBotones_1, CType(1, Short))
		CType(Me.cmdBotones, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Ctr_Ayucuenta, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Ctr_AyudaEntidad, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me._Ctr_Ayucuenta_1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DTPickerFecInicio, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DTPickerFecFinal, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me._Ctr_Ayucuenta_0, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Ctr_AyudaAsiento, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Ctr_AyudaSubAsiento, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Controls.Add(Frame1)
		Me.Controls.Add(_cmdBotones_0)
		Me.Controls.Add(_cmdBotones_1)
		Me.Controls.Add(fraDetallado)
		Me.Frame1.Controls.Add(chkAcumula)
		Me.fraDetallado.Controls.Add(Ctr_AyudaSubAsiento)
		Me.fraDetallado.Controls.Add(Ctr_AyudaAsiento)
		Me.fraDetallado.Controls.Add(_Ctr_Ayucuenta_0)
		Me.fraDetallado.Controls.Add(DTPickerFecFinal)
		Me.fraDetallado.Controls.Add(DTPickerFecInicio)
		Me.fraDetallado.Controls.Add(_Ctr_Ayucuenta_1)
		Me.fraDetallado.Controls.Add(Ctr_AyudaEntidad)
		Me.fraDetallado.Controls.Add(Label8)
		Me.fraDetallado.Controls.Add(Label7)
		Me.fraDetallado.Controls.Add(Label6)
		Me.fraDetallado.Controls.Add(Label5)
		Me.fraDetallado.Controls.Add(Label4)
		Me.fraDetallado.Controls.Add(Label3)
		Me.fraDetallado.Controls.Add(Label1)
		Me.fraDetallado.Controls.Add(Label2)
		Me.Frame1.ResumeLayout(False)
		Me.fraDetallado.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class