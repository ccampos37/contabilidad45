<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRepComprob
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
	Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents TxCompIni As AxTextFer.AxTxFer
	Public WithEvents Txcomprfin As AxTextFer.AxTxFer
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	'NOTA: el Dise�ador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Dise�ador de Windows Forms.
	'No lo modifique con el editor de c�digo.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRepComprob))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Command2 = New System.Windows.Forms.Button
		Me.Command1 = New System.Windows.Forms.Button
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.TxCompIni = New AxTextFer.AxTxFer
		Me.Txcomprfin = New AxTextFer.AxTxFer
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.TxCompIni, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Txcomprfin, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Reporte de Comprobantes"
		Me.ClientSize = New System.Drawing.Size(268, 156)
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
		Me.Name = "frmRepComprob"
		Me.Command2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command2.Text = "&Aceptar"
		Me.Command2.Size = New System.Drawing.Size(76, 24)
		Me.Command2.Location = New System.Drawing.Point(136, 127)
		Me.Command2.TabIndex = 2
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
		Me.Command1.Size = New System.Drawing.Size(76, 24)
		Me.Command1.Location = New System.Drawing.Point(56, 127)
		Me.Command1.TabIndex = 1
		Me.Command1.BackColor = System.Drawing.SystemColors.Control
		Me.Command1.CausesValidation = True
		Me.Command1.Enabled = True
		Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command1.TabStop = True
		Me.Command1.Name = "Command1"
		Me.Frame1.Text = "Rango de Comprobantes"
		Me.Frame1.Size = New System.Drawing.Size(257, 114)
		Me.Frame1.Location = New System.Drawing.Point(6, 5)
		Me.Frame1.TabIndex = 0
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		TxCompIni.OcxState = CType(resources.GetObject("TxCompIni.OcxState"), System.Windows.Forms.AxHost.State)
		Me.TxCompIni.Size = New System.Drawing.Size(228, 22)
		Me.TxCompIni.Location = New System.Drawing.Point(11, 33)
		Me.TxCompIni.TabIndex = 4
		Me.TxCompIni.CausesValidation = -1
		Me.TxCompIni.Name = "TxCompIni"
		Txcomprfin.OcxState = CType(resources.GetObject("Txcomprfin.OcxState"), System.Windows.Forms.AxHost.State)
		Me.Txcomprfin.Size = New System.Drawing.Size(228, 22)
		Me.Txcomprfin.Location = New System.Drawing.Point(11, 76)
		Me.Txcomprfin.TabIndex = 5
		Me.Txcomprfin.CausesValidation = -1
		Me.Txcomprfin.Name = "Txcomprfin"
		Me.Label2.Text = "Comprobante Final :"
		Me.Label2.Size = New System.Drawing.Size(146, 15)
		Me.Label2.Location = New System.Drawing.Point(12, 61)
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
		Me.Label1.Text = "Comprobante Inicial :"
		Me.Label1.Size = New System.Drawing.Size(146, 15)
		Me.Label1.Location = New System.Drawing.Point(12, 17)
		Me.Label1.TabIndex = 3
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
		CType(Me.Txcomprfin, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TxCompIni, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Controls.Add(Command2)
		Me.Controls.Add(Command1)
		Me.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(TxCompIni)
		Me.Frame1.Controls.Add(Txcomprfin)
		Me.Frame1.Controls.Add(Label2)
		Me.Frame1.Controls.Add(Label1)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class