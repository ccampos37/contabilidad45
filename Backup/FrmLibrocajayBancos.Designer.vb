<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FrmLibroCajayBancos
#Region "C�digo generado por el Dise�ador de Windows Forms "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'Llamada necesaria para el Dise�ador de Windows Forms.
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
	'Requerido por el Dise�ador de Windows Forms
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents Check2 As System.Windows.Forms.CheckBox
	Public WithEvents Check1 As System.Windows.Forms.CheckBox
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	'NOTA: el Dise�ador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Dise�ador de Windows Forms.
	'No lo modifique con el editor de c�digo.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmLibroCajayBancos))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.Command2 = New System.Windows.Forms.Button
		Me.Command1 = New System.Windows.Forms.Button
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.Check2 = New System.Windows.Forms.CheckBox
		Me.Check1 = New System.Windows.Forms.CheckBox
		Me.Frame2.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.BackColor = System.Drawing.Color.FromARGB(192, 192, 255)
		Me.Text = "Imprimir Libro Caja y Bancos"
		Me.ClientSize = New System.Drawing.Size(448, 283)
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
		Me.Name = "FrmLibroCajayBancos"
		Me.Frame2.BackColor = System.Drawing.Color.FromARGB(192, 255, 255)
		Me.Frame2.Size = New System.Drawing.Size(265, 81)
		Me.Frame2.Location = New System.Drawing.Point(80, 152)
		Me.Frame2.TabIndex = 3
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame2.Name = "Frame2"
		Me.Command2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command2.BackColor = System.Drawing.SystemColors.Control
		Me.Command2.Text = "Salir"
		Me.Command2.Size = New System.Drawing.Size(81, 33)
		Me.Command2.Location = New System.Drawing.Point(144, 24)
		Me.Command2.TabIndex = 5
		Me.Command2.CausesValidation = True
		Me.Command2.Enabled = True
		Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command2.TabStop = True
		Me.Command2.Name = "Command2"
		Me.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command1.Text = "Imprimir"
		Me.Command1.Size = New System.Drawing.Size(81, 33)
		Me.Command1.Location = New System.Drawing.Point(16, 24)
		Me.Command1.TabIndex = 4
		Me.Command1.BackColor = System.Drawing.SystemColors.Control
		Me.Command1.CausesValidation = True
		Me.Command1.Enabled = True
		Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command1.TabStop = True
		Me.Command1.Name = "Command1"
		Me.Frame1.BackColor = System.Drawing.Color.FromARGB(192, 255, 255)
		Me.Frame1.Size = New System.Drawing.Size(369, 113)
		Me.Frame1.Location = New System.Drawing.Point(32, 32)
		Me.Frame1.TabIndex = 0
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.Check2.BackColor = System.Drawing.Color.FromARGB(192, 255, 255)
		Me.Check2.Text = "Detalle de los movimeintos de cuenta corriente"
		Me.Check2.Size = New System.Drawing.Size(257, 33)
		Me.Check2.Location = New System.Drawing.Point(32, 56)
		Me.Check2.TabIndex = 2
		Me.Check2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Check2.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.Check2.CausesValidation = True
		Me.Check2.Enabled = True
		Me.Check2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Check2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Check2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Check2.Appearance = System.Windows.Forms.Appearance.Normal
		Me.Check2.TabStop = True
		Me.Check2.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.Check2.Visible = True
		Me.Check2.Name = "Check2"
		Me.Check1.BackColor = System.Drawing.Color.FromARGB(192, 255, 255)
		Me.Check1.Text = "Detalle de los movimientos de efectivo"
		Me.Check1.Size = New System.Drawing.Size(241, 33)
		Me.Check1.Location = New System.Drawing.Point(32, 24)
		Me.Check1.TabIndex = 1
		Me.Check1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Check1.FlatStyle = System.Windows.Forms.FlatStyle.Standard
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
		Me.Controls.Add(Frame2)
		Me.Controls.Add(Frame1)
		Me.Frame2.Controls.Add(Command2)
		Me.Frame2.Controls.Add(Command1)
		Me.Frame1.Controls.Add(Check2)
		Me.Frame1.Controls.Add(Check1)
		Me.Frame2.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class