<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRepEstadosFinancieros
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
	Public WithEvents _cmdBotones_1 As System.Windows.Forms.Button
	Public WithEvents _cmdBotones_0 As System.Windows.Forms.Button
	Public WithEvents DTPicker_Fecha As AxMSComCtl2.AxDTPicker
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents Check1 As System.Windows.Forms.CheckBox
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents _optTipo_3 As System.Windows.Forms.RadioButton
	Public WithEvents _optTipo_2 As System.Windows.Forms.RadioButton
	Public WithEvents _optTipo_1 As System.Windows.Forms.RadioButton
	Public WithEvents _optTipo_0 As System.Windows.Forms.RadioButton
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cmdBotones As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
	Public WithEvents optTipo As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRepEstadosFinancieros))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me._cmdBotones_1 = New System.Windows.Forms.Button
		Me._cmdBotones_0 = New System.Windows.Forms.Button
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.DTPicker_Fecha = New AxMSComCtl2.AxDTPicker
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.Frame3 = New System.Windows.Forms.GroupBox
		Me.Check1 = New System.Windows.Forms.CheckBox
		Me._optTipo_3 = New System.Windows.Forms.RadioButton
		Me._optTipo_2 = New System.Windows.Forms.RadioButton
		Me._optTipo_1 = New System.Windows.Forms.RadioButton
		Me._optTipo_0 = New System.Windows.Forms.RadioButton
		Me.cmdBotones = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(components)
		Me.optTipo = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.Frame2.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.Frame3.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.DTPicker_Fecha, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.cmdBotones, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.optTipo, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Estados Financieros"
		Me.ClientSize = New System.Drawing.Size(393, 308)
		Me.Location = New System.Drawing.Point(3, 22)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
		Me.MinimizeBox = False
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MaximizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmRepEstadosFinancieros"
		Me._cmdBotones_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdBotones_1.Text = "&Cancelar"
		Me._cmdBotones_1.Size = New System.Drawing.Size(89, 25)
		Me._cmdBotones_1.Location = New System.Drawing.Point(207, 271)
		Me._cmdBotones_1.TabIndex = 7
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
		Me._cmdBotones_0.Size = New System.Drawing.Size(89, 25)
		Me._cmdBotones_0.Location = New System.Drawing.Point(96, 271)
		Me._cmdBotones_0.TabIndex = 6
		Me._cmdBotones_0.BackColor = System.Drawing.SystemColors.Control
		Me._cmdBotones_0.CausesValidation = True
		Me._cmdBotones_0.Enabled = True
		Me._cmdBotones_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdBotones_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdBotones_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdBotones_0.TabStop = True
		Me._cmdBotones_0.Name = "_cmdBotones_0"
		Me.Frame2.Text = "Seleccionar Período"
		Me.Frame2.Size = New System.Drawing.Size(391, 54)
		Me.Frame2.Location = New System.Drawing.Point(0, 187)
		Me.Frame2.TabIndex = 4
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame2.Name = "Frame2"
		DTPicker_Fecha.OcxState = CType(resources.GetObject("DTPicker_Fecha.OcxState"), System.Windows.Forms.AxHost.State)
		Me.DTPicker_Fecha.Size = New System.Drawing.Size(260, 22)
		Me.DTPicker_Fecha.Location = New System.Drawing.Point(8, 18)
		Me.DTPicker_Fecha.TabIndex = 5
		Me.DTPicker_Fecha.Name = "DTPicker_Fecha"
		Me.Frame1.Text = "Seleccionar Estado Financiero"
		Me.Frame1.Size = New System.Drawing.Size(391, 157)
		Me.Frame1.Location = New System.Drawing.Point(0, 12)
		Me.Frame1.TabIndex = 0
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.Frame3.Text = "Tipo de Balance"
		Me.Frame3.Size = New System.Drawing.Size(153, 73)
		Me.Frame3.Location = New System.Drawing.Point(208, 80)
		Me.Frame3.TabIndex = 9
		Me.Frame3.BackColor = System.Drawing.SystemColors.Control
		Me.Frame3.Enabled = True
		Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame3.Visible = True
		Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame3.Name = "Frame3"
		Me.Check1.Text = "Diferenciado por Afiliadas"
		Me.Check1.Size = New System.Drawing.Size(81, 33)
		Me.Check1.Location = New System.Drawing.Point(16, 24)
		Me.Check1.TabIndex = 10
		Me.Check1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Check1.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.Check1.BackColor = System.Drawing.SystemColors.Control
		Me.Check1.CausesValidation = True
		Me.Check1.Enabled = True
		Me.Check1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Check1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Check1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Check1.Appearance = System.Windows.Forms.Appearance.Normal
		Me.Check1.TabStop = True
		Me.Check1.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.Check1.Visible = True
		Me.Check1.Name = "Check1"
		Me._optTipo_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optTipo_3.Text = "Estados de Flujos de Efectivo"
		Me._optTipo_3.Size = New System.Drawing.Size(298, 32)
		Me._optTipo_3.Location = New System.Drawing.Point(8, 112)
		Me._optTipo_3.TabIndex = 8
		Me._optTipo_3.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optTipo_3.BackColor = System.Drawing.SystemColors.Control
		Me._optTipo_3.CausesValidation = True
		Me._optTipo_3.Enabled = True
		Me._optTipo_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optTipo_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._optTipo_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optTipo_3.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optTipo_3.TabStop = True
		Me._optTipo_3.Checked = False
		Me._optTipo_3.Visible = True
		Me._optTipo_3.Name = "_optTipo_3"
		Me._optTipo_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optTipo_2.Text = "Balance General"
		Me._optTipo_2.Size = New System.Drawing.Size(170, 32)
		Me._optTipo_2.Location = New System.Drawing.Point(8, 82)
		Me._optTipo_2.TabIndex = 3
		Me._optTipo_2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optTipo_2.BackColor = System.Drawing.SystemColors.Control
		Me._optTipo_2.CausesValidation = True
		Me._optTipo_2.Enabled = True
		Me._optTipo_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optTipo_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._optTipo_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optTipo_2.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optTipo_2.TabStop = True
		Me._optTipo_2.Checked = False
		Me._optTipo_2.Visible = True
		Me._optTipo_2.Name = "_optTipo_2"
		Me._optTipo_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optTipo_1.Text = "Estado de Ganancias y Pérdidas por Naturaleza"
		Me._optTipo_1.Size = New System.Drawing.Size(298, 32)
		Me._optTipo_1.Location = New System.Drawing.Point(8, 49)
		Me._optTipo_1.TabIndex = 2
		Me._optTipo_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optTipo_1.BackColor = System.Drawing.SystemColors.Control
		Me._optTipo_1.CausesValidation = True
		Me._optTipo_1.Enabled = True
		Me._optTipo_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optTipo_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._optTipo_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optTipo_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optTipo_1.TabStop = True
		Me._optTipo_1.Checked = False
		Me._optTipo_1.Visible = True
		Me._optTipo_1.Name = "_optTipo_1"
		Me._optTipo_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optTipo_0.Text = "Estado de Ganancias y Pérdidas por Función"
		Me._optTipo_0.Size = New System.Drawing.Size(298, 32)
		Me._optTipo_0.Location = New System.Drawing.Point(8, 17)
		Me._optTipo_0.TabIndex = 1
		Me._optTipo_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optTipo_0.BackColor = System.Drawing.SystemColors.Control
		Me._optTipo_0.CausesValidation = True
		Me._optTipo_0.Enabled = True
		Me._optTipo_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optTipo_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._optTipo_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optTipo_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optTipo_0.TabStop = True
		Me._optTipo_0.Checked = False
		Me._optTipo_0.Visible = True
		Me._optTipo_0.Name = "_optTipo_0"
		Me.cmdBotones.SetIndex(_cmdBotones_1, CType(1, Short))
		Me.cmdBotones.SetIndex(_cmdBotones_0, CType(0, Short))
		Me.optTipo.SetIndex(_optTipo_3, CType(3, Short))
		Me.optTipo.SetIndex(_optTipo_2, CType(2, Short))
		Me.optTipo.SetIndex(_optTipo_1, CType(1, Short))
		Me.optTipo.SetIndex(_optTipo_0, CType(0, Short))
		CType(Me.optTipo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.cmdBotones, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DTPicker_Fecha, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Controls.Add(_cmdBotones_1)
		Me.Controls.Add(_cmdBotones_0)
		Me.Controls.Add(Frame2)
		Me.Controls.Add(Frame1)
		Me.Frame2.Controls.Add(DTPicker_Fecha)
		Me.Frame1.Controls.Add(Frame3)
		Me.Frame1.Controls.Add(_optTipo_3)
		Me.Frame1.Controls.Add(_optTipo_2)
		Me.Frame1.Controls.Add(_optTipo_1)
		Me.Frame1.Controls.Add(_optTipo_0)
		Me.Frame3.Controls.Add(Check1)
		Me.Frame2.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.Frame3.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class