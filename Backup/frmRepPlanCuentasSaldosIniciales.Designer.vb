<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRepPlanCuentasSaldosIniciales
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
	Public WithEvents _Option1_0 As System.Windows.Forms.RadioButton
	Public WithEvents _Option1_1 As System.Windows.Forms.RadioButton
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents Ctr_Ayuda1 As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents cboNiveles As System.Windows.Forms.ComboBox
	Public WithEvents _Option2_0 As System.Windows.Forms.RadioButton
	Public WithEvents _Option2_1 As System.Windows.Forms.RadioButton
	Public WithEvents Frame4 As System.Windows.Forms.GroupBox
	Public WithEvents _cmdBotones_0 As System.Windows.Forms.Button
	Public WithEvents _cmdBotones_1 As System.Windows.Forms.Button
	Public WithEvents Option1 As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	Public WithEvents Option2 As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	Public WithEvents cmdBotones As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
	'NOTA: el Dise�ador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Dise�ador de Windows Forms.
	'No lo modifique con el editor de c�digo.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRepPlanCuentasSaldosIniciales))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me._Option1_0 = New System.Windows.Forms.RadioButton
		Me._Option1_1 = New System.Windows.Forms.RadioButton
		Me.Frame3 = New System.Windows.Forms.GroupBox
		Me.Ctr_Ayuda1 = New Axctrlayuda_f.AxCtr_Ayuda
		Me.Frame4 = New System.Windows.Forms.GroupBox
		Me.cboNiveles = New System.Windows.Forms.ComboBox
		Me._Option2_0 = New System.Windows.Forms.RadioButton
		Me._Option2_1 = New System.Windows.Forms.RadioButton
		Me._cmdBotones_0 = New System.Windows.Forms.Button
		Me._cmdBotones_1 = New System.Windows.Forms.Button
		Me.Option1 = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.Option2 = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.cmdBotones = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(components)
		Me.Frame1.SuspendLayout()
		Me.Frame3.SuspendLayout()
		Me.Frame4.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.Ctr_Ayuda1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Option1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Option2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.cmdBotones, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Saldos Iniciales"
		Me.ClientSize = New System.Drawing.Size(376, 265)
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
		Me.Name = "frmRepPlanCuentasSaldosIniciales"
		Me.Frame1.Text = "Tipo Impresi�n"
		Me.Frame1.Size = New System.Drawing.Size(376, 59)
		Me.Frame1.Location = New System.Drawing.Point(0, 17)
		Me.Frame1.TabIndex = 8
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me._Option1_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._Option1_0.Text = "Plan de Cuentas Total"
		Me._Option1_0.Size = New System.Drawing.Size(161, 15)
		Me._Option1_0.Location = New System.Drawing.Point(9, 18)
		Me._Option1_0.TabIndex = 10
		Me._Option1_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._Option1_0.BackColor = System.Drawing.SystemColors.Control
		Me._Option1_0.CausesValidation = True
		Me._Option1_0.Enabled = True
		Me._Option1_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Option1_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._Option1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Option1_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._Option1_0.TabStop = True
		Me._Option1_0.Checked = False
		Me._Option1_0.Visible = True
		Me._Option1_0.Name = "_Option1_0"
		Me._Option1_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._Option1_1.Text = "Plan de Cuentas Resumido"
		Me._Option1_1.Size = New System.Drawing.Size(161, 15)
		Me._Option1_1.Location = New System.Drawing.Point(8, 36)
		Me._Option1_1.TabIndex = 9
		Me._Option1_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._Option1_1.BackColor = System.Drawing.SystemColors.Control
		Me._Option1_1.CausesValidation = True
		Me._Option1_1.Enabled = True
		Me._Option1_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Option1_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._Option1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Option1_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._Option1_1.TabStop = True
		Me._Option1_1.Checked = False
		Me._Option1_1.Visible = True
		Me._Option1_1.Name = "_Option1_1"
		Me.Frame3.Text = "Cuenta Contable"
		Me.Frame3.Size = New System.Drawing.Size(376, 47)
		Me.Frame3.Location = New System.Drawing.Point(0, 170)
		Me.Frame3.TabIndex = 6
		Me.Frame3.BackColor = System.Drawing.SystemColors.Control
		Me.Frame3.Enabled = True
		Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame3.Visible = True
		Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame3.Name = "Frame3"
		Ctr_Ayuda1.OcxState = CType(resources.GetObject("Ctr_Ayuda1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.Ctr_Ayuda1.Size = New System.Drawing.Size(368, 22)
		Me.Ctr_Ayuda1.Location = New System.Drawing.Point(4, 15)
		Me.Ctr_Ayuda1.TabIndex = 7
		Me.Ctr_Ayuda1.Name = "Ctr_Ayuda1"
		Me.Frame4.Text = "Par�metros de Impresi�n"
		Me.Frame4.Size = New System.Drawing.Size(376, 61)
		Me.Frame4.Location = New System.Drawing.Point(0, 98)
		Me.Frame4.TabIndex = 2
		Me.Frame4.BackColor = System.Drawing.SystemColors.Control
		Me.Frame4.Enabled = True
		Me.Frame4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame4.Visible = True
		Me.Frame4.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame4.Name = "Frame4"
		Me.cboNiveles.Size = New System.Drawing.Size(216, 21)
		Me.cboNiveles.Location = New System.Drawing.Point(156, 18)
		Me.cboNiveles.TabIndex = 5
		Me.cboNiveles.BackColor = System.Drawing.SystemColors.Window
		Me.cboNiveles.CausesValidation = True
		Me.cboNiveles.Enabled = True
		Me.cboNiveles.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboNiveles.IntegralHeight = True
		Me.cboNiveles.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboNiveles.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboNiveles.Sorted = False
		Me.cboNiveles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboNiveles.TabStop = True
		Me.cboNiveles.Visible = True
		Me.cboNiveles.Name = "cboNiveles"
		Me._Option2_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._Option2_0.Text = "Niveles"
		Me._Option2_0.Size = New System.Drawing.Size(106, 16)
		Me._Option2_0.Location = New System.Drawing.Point(7, 20)
		Me._Option2_0.TabIndex = 4
		Me._Option2_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._Option2_0.BackColor = System.Drawing.SystemColors.Control
		Me._Option2_0.CausesValidation = True
		Me._Option2_0.Enabled = True
		Me._Option2_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Option2_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._Option2_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Option2_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._Option2_0.TabStop = True
		Me._Option2_0.Checked = False
		Me._Option2_0.Visible = True
		Me._Option2_0.Name = "_Option2_0"
		Me._Option2_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._Option2_1.Text = "Estructurado"
		Me._Option2_1.Size = New System.Drawing.Size(106, 16)
		Me._Option2_1.Location = New System.Drawing.Point(6, 37)
		Me._Option2_1.TabIndex = 3
		Me._Option2_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._Option2_1.BackColor = System.Drawing.SystemColors.Control
		Me._Option2_1.CausesValidation = True
		Me._Option2_1.Enabled = True
		Me._Option2_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Option2_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._Option2_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Option2_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._Option2_1.TabStop = True
		Me._Option2_1.Checked = False
		Me._Option2_1.Visible = True
		Me._Option2_1.Name = "_Option2_1"
		Me._cmdBotones_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdBotones_0.Text = "&Aceptar"
		Me._cmdBotones_0.Size = New System.Drawing.Size(71, 22)
		Me._cmdBotones_0.Location = New System.Drawing.Point(109, 232)
		Me._cmdBotones_0.TabIndex = 1
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
		Me._cmdBotones_1.Size = New System.Drawing.Size(71, 22)
		Me._cmdBotones_1.Location = New System.Drawing.Point(196, 232)
		Me._cmdBotones_1.TabIndex = 0
		Me._cmdBotones_1.BackColor = System.Drawing.SystemColors.Control
		Me._cmdBotones_1.CausesValidation = True
		Me._cmdBotones_1.Enabled = True
		Me._cmdBotones_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdBotones_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdBotones_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdBotones_1.TabStop = True
		Me._cmdBotones_1.Name = "_cmdBotones_1"
		Me.Option1.SetIndex(_Option1_0, CType(0, Short))
		Me.Option1.SetIndex(_Option1_1, CType(1, Short))
		Me.Option2.SetIndex(_Option2_0, CType(0, Short))
		Me.Option2.SetIndex(_Option2_1, CType(1, Short))
		Me.cmdBotones.SetIndex(_cmdBotones_0, CType(0, Short))
		Me.cmdBotones.SetIndex(_cmdBotones_1, CType(1, Short))
		CType(Me.cmdBotones, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Option2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Option1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Ctr_Ayuda1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Controls.Add(Frame1)
		Me.Controls.Add(Frame3)
		Me.Controls.Add(Frame4)
		Me.Controls.Add(_cmdBotones_0)
		Me.Controls.Add(_cmdBotones_1)
		Me.Frame1.Controls.Add(_Option1_0)
		Me.Frame1.Controls.Add(_Option1_1)
		Me.Frame3.Controls.Add(Ctr_Ayuda1)
		Me.Frame4.Controls.Add(cboNiveles)
		Me.Frame4.Controls.Add(_Option2_0)
		Me.Frame4.Controls.Add(_Option2_1)
		Me.Frame1.ResumeLayout(False)
		Me.Frame3.ResumeLayout(False)
		Me.Frame4.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class