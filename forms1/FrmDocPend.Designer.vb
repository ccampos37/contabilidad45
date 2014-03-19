<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FrmDocPend
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
	Public WithEvents CmdCancelar As System.Windows.Forms.Button
	Public WithEvents CmdAceptar As System.Windows.Forms.Button
	Public WithEvents TDBG_DocPend As AxTrueOleDBGrid70.AxTDBGrid
	Public WithEvents lbnregdetalle As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Picture1 As System.Windows.Forms.Panel
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmDocPend))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.CmdCancelar = New System.Windows.Forms.Button
		Me.CmdAceptar = New System.Windows.Forms.Button
		Me.Picture1 = New System.Windows.Forms.Panel
		Me.TDBG_DocPend = New AxTrueOleDBGrid70.AxTDBGrid
		Me.lbnregdetalle = New System.Windows.Forms.Label
		Me.Label7 = New System.Windows.Forms.Label
		Me.Picture1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.TDBG_DocPend, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Documentos Pendientes "
		Me.ClientSize = New System.Drawing.Size(756, 274)
		Me.Location = New System.Drawing.Point(4, 23)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
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
		Me.Name = "FrmDocPend"
		Me.CmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.CmdCancelar.Text = "&Cancelar"
		Me.CmdCancelar.Size = New System.Drawing.Size(77, 22)
		Me.CmdCancelar.Location = New System.Drawing.Point(302, 248)
		Me.CmdCancelar.TabIndex = 5
		Me.CmdCancelar.BackColor = System.Drawing.SystemColors.Control
		Me.CmdCancelar.CausesValidation = True
		Me.CmdCancelar.Enabled = True
		Me.CmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.CmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
		Me.CmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CmdCancelar.TabStop = True
		Me.CmdCancelar.Name = "CmdCancelar"
		Me.CmdAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.CmdAceptar.Text = "&Aceptar"
		Me.CmdAceptar.Size = New System.Drawing.Size(77, 22)
		Me.CmdAceptar.Location = New System.Drawing.Point(225, 248)
		Me.CmdAceptar.TabIndex = 4
		Me.CmdAceptar.BackColor = System.Drawing.SystemColors.Control
		Me.CmdAceptar.CausesValidation = True
		Me.CmdAceptar.Enabled = True
		Me.CmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.CmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
		Me.CmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CmdAceptar.TabStop = True
		Me.CmdAceptar.Name = "CmdAceptar"
		Me.Picture1.BackColor = System.Drawing.Color.FromARGB(128, 128, 128)
		Me.Picture1.Size = New System.Drawing.Size(752, 237)
		Me.Picture1.Location = New System.Drawing.Point(3, 6)
		Me.Picture1.TabIndex = 0
		Me.Picture1.Dock = System.Windows.Forms.DockStyle.None
		Me.Picture1.CausesValidation = True
		Me.Picture1.Enabled = True
		Me.Picture1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Picture1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Picture1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Picture1.TabStop = True
		Me.Picture1.Visible = True
		Me.Picture1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Picture1.Name = "Picture1"
		TDBG_DocPend.OcxState = CType(resources.GetObject("TDBG_DocPend.OcxState"), System.Windows.Forms.AxHost.State)
		Me.TDBG_DocPend.Size = New System.Drawing.Size(736, 195)
		Me.TDBG_DocPend.Location = New System.Drawing.Point(4, 4)
		Me.TDBG_DocPend.TabIndex = 1
		Me.TDBG_DocPend.Name = "TDBG_DocPend"
		Me.lbnregdetalle.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.lbnregdetalle.BackColor = System.Drawing.Color.White
		Me.lbnregdetalle.Text = "0 "
		Me.lbnregdetalle.Size = New System.Drawing.Size(70, 17)
		Me.lbnregdetalle.Location = New System.Drawing.Point(517, 204)
		Me.lbnregdetalle.TabIndex = 3
		Me.lbnregdetalle.Enabled = True
		Me.lbnregdetalle.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lbnregdetalle.Cursor = System.Windows.Forms.Cursors.Default
		Me.lbnregdetalle.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lbnregdetalle.UseMnemonic = True
		Me.lbnregdetalle.Visible = True
		Me.lbnregdetalle.AutoSize = False
		Me.lbnregdetalle.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lbnregdetalle.Name = "lbnregdetalle"
		Me.Label7.Text = "Nº Registros :"
		Me.Label7.ForeColor = System.Drawing.Color.White
		Me.Label7.Size = New System.Drawing.Size(65, 13)
		Me.Label7.Location = New System.Drawing.Point(444, 206)
		Me.Label7.TabIndex = 2
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label7.BackColor = System.Drawing.Color.Transparent
		Me.Label7.Enabled = True
		Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label7.UseMnemonic = True
		Me.Label7.Visible = True
		Me.Label7.AutoSize = True
		Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label7.Name = "Label7"
		Me.Controls.Add(CmdCancelar)
		Me.Controls.Add(CmdAceptar)
		Me.Controls.Add(Picture1)
		Me.Picture1.Controls.Add(TDBG_DocPend)
		Me.Picture1.Controls.Add(lbnregdetalle)
		Me.Picture1.Controls.Add(Label7)
		CType(Me.TDBG_DocPend, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Picture1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class