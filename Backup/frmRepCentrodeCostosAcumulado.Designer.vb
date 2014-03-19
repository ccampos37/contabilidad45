<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRepCentrodeCostosAcumulado
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
	Public WithEvents cmdCancelar As System.Windows.Forms.Button
	Public WithEvents CmdAceptar As System.Windows.Forms.Button
	Public WithEvents Option2 As System.Windows.Forms.RadioButton
	Public WithEvents Option1 As System.Windows.Forms.RadioButton
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents Option3 As System.Windows.Forms.RadioButton
	Public WithEvents Option4 As System.Windows.Forms.RadioButton
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents DTPicker1 As AxMSComCtl2.AxDTPicker
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRepCentrodeCostosAcumulado))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cmdCancelar = New System.Windows.Forms.Button
		Me.CmdAceptar = New System.Windows.Forms.Button
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.Option2 = New System.Windows.Forms.RadioButton
		Me.Option1 = New System.Windows.Forms.RadioButton
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.Option3 = New System.Windows.Forms.RadioButton
		Me.Option4 = New System.Windows.Forms.RadioButton
		Me.Frame3 = New System.Windows.Forms.GroupBox
		Me.DTPicker1 = New AxMSComCtl2.AxDTPicker
		Me.Label3 = New System.Windows.Forms.Label
		Me.Frame1.SuspendLayout()
		Me.Frame2.SuspendLayout()
		Me.Frame3.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.DTPicker1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Acumulados de Cuentas de gastos"
		Me.ClientSize = New System.Drawing.Size(388, 192)
		Me.Location = New System.Drawing.Point(4, 23)
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
		Me.Name = "frmRepCentrodeCostosAcumulado"
		Me.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCancelar.Text = "&Cancelar"
		Me.cmdCancelar.Size = New System.Drawing.Size(85, 24)
		Me.cmdCancelar.Location = New System.Drawing.Point(183, 150)
		Me.cmdCancelar.TabIndex = 10
		Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
		Me.cmdCancelar.CausesValidation = True
		Me.cmdCancelar.Enabled = True
		Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCancelar.TabStop = True
		Me.cmdCancelar.Name = "cmdCancelar"
		Me.CmdAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.CmdAceptar.Text = "&Aceptar"
		Me.CmdAceptar.Size = New System.Drawing.Size(85, 24)
		Me.CmdAceptar.Location = New System.Drawing.Point(93, 150)
		Me.CmdAceptar.TabIndex = 9
		Me.CmdAceptar.BackColor = System.Drawing.SystemColors.Control
		Me.CmdAceptar.CausesValidation = True
		Me.CmdAceptar.Enabled = True
		Me.CmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.CmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
		Me.CmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CmdAceptar.TabStop = True
		Me.CmdAceptar.Name = "CmdAceptar"
		Me.Frame1.Text = "Ordenado Por : "
		Me.Frame1.ForeColor = System.Drawing.Color.Red
		Me.Frame1.Size = New System.Drawing.Size(177, 77)
		Me.Frame1.Location = New System.Drawing.Point(201, 69)
		Me.Frame1.TabIndex = 6
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.Option2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Option2.Text = "Centro Costo"
		Me.Option2.Size = New System.Drawing.Size(137, 17)
		Me.Option2.Location = New System.Drawing.Point(24, 48)
		Me.Option2.TabIndex = 8
		Me.Option2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Option2.BackColor = System.Drawing.SystemColors.Control
		Me.Option2.CausesValidation = True
		Me.Option2.Enabled = True
		Me.Option2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Option2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Option2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Option2.Appearance = System.Windows.Forms.Appearance.Normal
		Me.Option2.TabStop = True
		Me.Option2.Checked = False
		Me.Option2.Visible = True
		Me.Option2.Name = "Option2"
		Me.Option1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Option1.Text = "Cuenta / Ccentro Costo"
		Me.Option1.Size = New System.Drawing.Size(145, 17)
		Me.Option1.Location = New System.Drawing.Point(24, 24)
		Me.Option1.TabIndex = 7
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
		Me.Frame2.Text = "Tipo de reporte"
		Me.Frame2.ForeColor = System.Drawing.Color.Red
		Me.Frame2.Size = New System.Drawing.Size(177, 77)
		Me.Frame2.Location = New System.Drawing.Point(7, 66)
		Me.Frame2.TabIndex = 3
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame2.Name = "Frame2"
		Me.Option3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Option3.Text = "Mensual/Acumulado"
		Me.Option3.Size = New System.Drawing.Size(121, 17)
		Me.Option3.Location = New System.Drawing.Point(24, 24)
		Me.Option3.TabIndex = 5
		Me.Option3.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Option3.BackColor = System.Drawing.SystemColors.Control
		Me.Option3.CausesValidation = True
		Me.Option3.Enabled = True
		Me.Option3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Option3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Option3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Option3.Appearance = System.Windows.Forms.Appearance.Normal
		Me.Option3.TabStop = True
		Me.Option3.Checked = False
		Me.Option3.Visible = True
		Me.Option3.Name = "Option3"
		Me.Option4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Option4.Text = "Mensualizado/Anual"
		Me.Option4.Size = New System.Drawing.Size(129, 17)
		Me.Option4.Location = New System.Drawing.Point(27, 48)
		Me.Option4.TabIndex = 4
		Me.Option4.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Option4.BackColor = System.Drawing.SystemColors.Control
		Me.Option4.CausesValidation = True
		Me.Option4.Enabled = True
		Me.Option4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Option4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Option4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Option4.Appearance = System.Windows.Forms.Appearance.Normal
		Me.Option4.TabStop = True
		Me.Option4.Checked = False
		Me.Option4.Visible = True
		Me.Option4.Name = "Option4"
		Me.Frame3.Size = New System.Drawing.Size(361, 49)
		Me.Frame3.Location = New System.Drawing.Point(6, 18)
		Me.Frame3.TabIndex = 0
		Me.Frame3.BackColor = System.Drawing.SystemColors.Control
		Me.Frame3.Enabled = True
		Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame3.Visible = True
		Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame3.Name = "Frame3"
		DTPicker1.OcxState = CType(resources.GetObject("DTPicker1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.DTPicker1.Size = New System.Drawing.Size(127, 19)
		Me.DTPicker1.Location = New System.Drawing.Point(94, 16)
		Me.DTPicker1.TabIndex = 1
		Me.DTPicker1.Name = "DTPicker1"
		Me.Label3.Text = "Mes :"
		Me.Label3.Size = New System.Drawing.Size(26, 13)
		Me.Label3.Location = New System.Drawing.Point(32, 17)
		Me.Label3.TabIndex = 2
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
		Me.Controls.Add(cmdCancelar)
		Me.Controls.Add(CmdAceptar)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(Frame2)
		Me.Controls.Add(Frame3)
		Me.Frame1.Controls.Add(Option2)
		Me.Frame1.Controls.Add(Option1)
		Me.Frame2.Controls.Add(Option3)
		Me.Frame2.Controls.Add(Option4)
		Me.Frame3.Controls.Add(DTPicker1)
		Me.Frame3.Controls.Add(Label3)
		CType(Me.DTPicker1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame1.ResumeLayout(False)
		Me.Frame2.ResumeLayout(False)
		Me.Frame3.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class