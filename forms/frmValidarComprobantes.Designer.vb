<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmValidarComprobantes
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
	Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents Opt As System.Windows.Forms.RadioButton
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents Option2 As System.Windows.Forms.RadioButton
	Public WithEvents Option1 As System.Windows.Forms.RadioButton
	Public WithEvents OptValidar As System.Windows.Forms.RadioButton
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents DTPicker1 As AxMSComCtl2.AxDTPicker
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmValidarComprobantes))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Command2 = New System.Windows.Forms.Button
		Me.Command1 = New System.Windows.Forms.Button
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.Opt = New System.Windows.Forms.RadioButton
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.Option2 = New System.Windows.Forms.RadioButton
		Me.Option1 = New System.Windows.Forms.RadioButton
		Me.OptValidar = New System.Windows.Forms.RadioButton
		Me.DTPicker1 = New AxMSComCtl2.AxDTPicker
		Me.Label1 = New System.Windows.Forms.Label
		Me.Frame2.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.DTPicker1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Errores en Comprobantes"
		Me.ClientSize = New System.Drawing.Size(410, 312)
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
		Me.Name = "frmValidarComprobantes"
		Me.Command2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command2.Text = "&Cancelar"
		Me.Command2.Size = New System.Drawing.Size(94, 24)
		Me.Command2.Location = New System.Drawing.Point(216, 269)
		Me.Command2.TabIndex = 9
		Me.Command2.BackColor = System.Drawing.SystemColors.Control
		Me.Command2.CausesValidation = True
		Me.Command2.Enabled = True
		Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command2.TabStop = True
		Me.Command2.Name = "Command2"
		Me.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command1.Text = "&Aceptar"
		Me.Command1.Size = New System.Drawing.Size(90, 24)
		Me.Command1.Location = New System.Drawing.Point(100, 269)
		Me.Command1.TabIndex = 8
		Me.Command1.BackColor = System.Drawing.SystemColors.Control
		Me.Command1.CausesValidation = True
		Me.Command1.Enabled = True
		Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command1.TabStop = True
		Me.Command1.Name = "Command1"
		Me.Frame2.Size = New System.Drawing.Size(388, 53)
		Me.Frame2.Location = New System.Drawing.Point(11, 45)
		Me.Frame2.TabIndex = 3
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame2.Name = "Frame2"
		Me.Opt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Opt.Text = "Asientos Descuadrados"
		Me.Opt.Size = New System.Drawing.Size(142, 25)
		Me.Opt.Location = New System.Drawing.Point(11, 16)
		Me.Opt.TabIndex = 4
		Me.Opt.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Opt.BackColor = System.Drawing.SystemColors.Control
		Me.Opt.CausesValidation = True
		Me.Opt.Enabled = True
		Me.Opt.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Opt.Cursor = System.Windows.Forms.Cursors.Default
		Me.Opt.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Opt.Appearance = System.Windows.Forms.Appearance.Normal
		Me.Opt.TabStop = True
		Me.Opt.Checked = False
		Me.Opt.Visible = True
		Me.Opt.Name = "Opt"
		Me.Frame1.Text = "Validación de Cuentas en Comprobantes"
		Me.Frame1.Size = New System.Drawing.Size(389, 130)
		Me.Frame1.Location = New System.Drawing.Point(10, 115)
		Me.Frame1.TabIndex = 2
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.Option2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Option2.Text = "Cruce de la Clase 6 con la 9"
		Me.Option2.Size = New System.Drawing.Size(189, 24)
		Me.Option2.Location = New System.Drawing.Point(12, 81)
		Me.Option2.TabIndex = 7
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
		Me.Option1.Text = "Cruce de la Clase 6 con la 9"
		Me.Option1.Size = New System.Drawing.Size(189, 24)
		Me.Option1.Location = New System.Drawing.Point(12, 55)
		Me.Option1.TabIndex = 6
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
		Me.OptValidar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.OptValidar.Text = "Cruce de la Clase 6 con la 9"
		Me.OptValidar.Size = New System.Drawing.Size(189, 24)
		Me.OptValidar.Location = New System.Drawing.Point(12, 28)
		Me.OptValidar.TabIndex = 5
		Me.OptValidar.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.OptValidar.BackColor = System.Drawing.SystemColors.Control
		Me.OptValidar.CausesValidation = True
		Me.OptValidar.Enabled = True
		Me.OptValidar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.OptValidar.Cursor = System.Windows.Forms.Cursors.Default
		Me.OptValidar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.OptValidar.Appearance = System.Windows.Forms.Appearance.Normal
		Me.OptValidar.TabStop = True
		Me.OptValidar.Checked = False
		Me.OptValidar.Visible = True
		Me.OptValidar.Name = "OptValidar"
		DTPicker1.OcxState = CType(resources.GetObject("DTPicker1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.DTPicker1.Size = New System.Drawing.Size(133, 21)
		Me.DTPicker1.Location = New System.Drawing.Point(121, 14)
		Me.DTPicker1.TabIndex = 1
		Me.DTPicker1.Name = "DTPicker1"
		Me.Label1.Text = "Seleccionar Mes"
		Me.Label1.Size = New System.Drawing.Size(90, 21)
		Me.Label1.Location = New System.Drawing.Point(18, 17)
		Me.Label1.TabIndex = 0
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
		Me.Controls.Add(Command2)
		Me.Controls.Add(Command1)
		Me.Controls.Add(Frame2)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(DTPicker1)
		Me.Controls.Add(Label1)
		Me.Frame2.Controls.Add(Opt)
		Me.Frame1.Controls.Add(Option2)
		Me.Frame1.Controls.Add(Option1)
		Me.Frame1.Controls.Add(OptValidar)
		CType(Me.DTPicker1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame2.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class