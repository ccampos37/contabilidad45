<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FrmGenerasaldosini
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
	Public WithEvents Ctr_AyudaCuenta As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTA: el Dise�ador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Dise�ador de Windows Forms.
	'No lo modifique con el editor de c�digo.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmGenerasaldosini))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Command2 = New System.Windows.Forms.Button
		Me.Command1 = New System.Windows.Forms.Button
		Me.Ctr_AyudaCuenta = New Axctrlayuda_f.AxCtr_Ayuda
		Me.Label1 = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.Ctr_AyudaCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Form1"
		Me.ClientSize = New System.Drawing.Size(364, 154)
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
		Me.Name = "FrmGenerasaldosini"
		Me.Command2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command2.Text = "Salir"
		Me.Command2.Size = New System.Drawing.Size(81, 33)
		Me.Command2.Location = New System.Drawing.Point(168, 88)
		Me.Command2.TabIndex = 3
		Me.Command2.BackColor = System.Drawing.SystemColors.Control
		Me.Command2.CausesValidation = True
		Me.Command2.Enabled = True
		Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command2.TabStop = True
		Me.Command2.Name = "Command2"
		Me.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command1.Text = "Aceptar"
		Me.Command1.Size = New System.Drawing.Size(81, 33)
		Me.Command1.Location = New System.Drawing.Point(40, 88)
		Me.Command1.TabIndex = 2
		Me.Command1.BackColor = System.Drawing.SystemColors.Control
		Me.Command1.CausesValidation = True
		Me.Command1.Enabled = True
		Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command1.TabStop = True
		Me.Command1.Name = "Command1"
		Ctr_AyudaCuenta.OcxState = CType(resources.GetObject("Ctr_AyudaCuenta.OcxState"), System.Windows.Forms.AxHost.State)
		Me.Ctr_AyudaCuenta.Size = New System.Drawing.Size(323, 24)
		Me.Ctr_AyudaCuenta.Location = New System.Drawing.Point(24, 48)
		Me.Ctr_AyudaCuenta.TabIndex = 0
		Me.Ctr_AyudaCuenta.Name = "Ctr_AyudaCuenta"
		Me.Label1.BackColor = System.Drawing.SystemColors.Menu
		Me.Label1.Text = "Cuenta de Resultados para el actual ejercicio"
		Me.Label1.Size = New System.Drawing.Size(321, 33)
		Me.Label1.Location = New System.Drawing.Point(24, 8)
		Me.Label1.TabIndex = 1
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
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
		Me.Controls.Add(Ctr_AyudaCuenta)
		Me.Controls.Add(Label1)
		CType(Me.Ctr_AyudaCuenta, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class