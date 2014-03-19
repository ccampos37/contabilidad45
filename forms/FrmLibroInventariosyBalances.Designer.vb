<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FrmLibroInventariosyBalances
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
	Public WithEvents Check1 As System.Windows.Forms.CheckBox
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents ListView2 As System.Windows.Forms.ListView
	Public WithEvents ListView1 As System.Windows.Forms.ListView
	Public WithEvents FrameCuentas As System.Windows.Forms.GroupBox
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmLibroInventariosyBalances))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Check1 = New System.Windows.Forms.CheckBox
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.FrameCuentas = New System.Windows.Forms.GroupBox
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.Command1 = New System.Windows.Forms.Button
		Me.Command2 = New System.Windows.Forms.Button
		Me.ListView2 = New System.Windows.Forms.ListView
		Me.ListView1 = New System.Windows.Forms.ListView
		Me.Frame1.SuspendLayout()
		Me.FrameCuentas.SuspendLayout()
		Me.Frame2.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.Text = "Libro de Inventarios y Balances"
		Me.ClientSize = New System.Drawing.Size(740, 565)
		Me.Location = New System.Drawing.Point(4, 30)
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
		Me.Name = "FrmLibroInventariosyBalances"
		Me.Check1.Text = "Imprimir"
		Me.Check1.Size = New System.Drawing.Size(81, 33)
		Me.Check1.Location = New System.Drawing.Point(64, 56)
		Me.Check1.TabIndex = 7
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
		Me.Frame1.Size = New System.Drawing.Size(649, 537)
		Me.Frame1.Location = New System.Drawing.Point(24, 8)
		Me.Frame1.TabIndex = 0
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.FrameCuentas.Size = New System.Drawing.Size(601, 449)
		Me.FrameCuentas.Location = New System.Drawing.Point(24, 64)
		Me.FrameCuentas.TabIndex = 1
		Me.FrameCuentas.BackColor = System.Drawing.SystemColors.Control
		Me.FrameCuentas.Enabled = True
		Me.FrameCuentas.ForeColor = System.Drawing.SystemColors.ControlText
		Me.FrameCuentas.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.FrameCuentas.Visible = True
		Me.FrameCuentas.Padding = New System.Windows.Forms.Padding(0)
		Me.FrameCuentas.Name = "FrameCuentas"
		Me.Frame2.Text = "Opciones"
		Me.Frame2.Size = New System.Drawing.Size(281, 81)
		Me.Frame2.Location = New System.Drawing.Point(176, 336)
		Me.Frame2.TabIndex = 2
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame2.Name = "Frame2"
		Me.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command1.Text = "Impprimir"
		Me.Command1.Size = New System.Drawing.Size(105, 41)
		Me.Command1.Location = New System.Drawing.Point(24, 16)
		Me.Command1.TabIndex = 4
		Me.Command1.BackColor = System.Drawing.SystemColors.Control
		Me.Command1.CausesValidation = True
		Me.Command1.Enabled = True
		Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command1.TabStop = True
		Me.Command1.Name = "Command1"
		Me.Command2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command2.Text = "Salir"
		Me.Command2.Size = New System.Drawing.Size(105, 41)
		Me.Command2.Location = New System.Drawing.Point(160, 16)
		Me.Command2.TabIndex = 3
		Me.Command2.BackColor = System.Drawing.SystemColors.Control
		Me.Command2.CausesValidation = True
		Me.Command2.Enabled = True
		Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command2.TabStop = True
		Me.Command2.Name = "Command2"
		Me.ListView2.Size = New System.Drawing.Size(2, 9)
		Me.ListView2.Location = New System.Drawing.Point(88, 104)
		Me.ListView2.TabIndex = 5
		Me.ListView2.LabelWrap = True
		Me.ListView2.HideSelection = True
		Me.ListView2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.ListView2.BackColor = System.Drawing.SystemColors.Window
		Me.ListView2.LabelEdit = True
		Me.ListView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.ListView2.Name = "ListView2"
		Me.ListView1.Size = New System.Drawing.Size(561, 305)
		Me.ListView1.Location = New System.Drawing.Point(8, 16)
		Me.ListView1.TabIndex = 6
		Me.ListView1.LabelWrap = True
		Me.ListView1.HideSelection = True
		Me.ListView1.Checkboxes = True
		Me.ListView1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.ListView1.BackColor = System.Drawing.SystemColors.Window
		Me.ListView1.LabelEdit = True
		Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.ListView1.Name = "ListView1"
		Me.Controls.Add(Check1)
		Me.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(FrameCuentas)
		Me.FrameCuentas.Controls.Add(Frame2)
		Me.FrameCuentas.Controls.Add(ListView2)
		Me.FrameCuentas.Controls.Add(ListView1)
		Me.Frame2.Controls.Add(Command1)
		Me.Frame2.Controls.Add(Command2)
		Me.Frame1.ResumeLayout(False)
		Me.FrameCuentas.ResumeLayout(False)
		Me.Frame2.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class