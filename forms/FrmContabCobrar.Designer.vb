<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FrmContabCobrar
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
	Public WithEvents ChkRest As System.Windows.Forms.CheckBox
	Public cmdg_archivoOpen As System.Windows.Forms.OpenFileDialog
	Public WithEvents CmdCancelar As System.Windows.Forms.Button
	Public WithEvents CmdProcesar As System.Windows.Forms.Button
	Public WithEvents DTPPerido As AxMSComCtl2.AxDTPicker
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents CmdArchivo As System.Windows.Forms.Button
	Public WithEvents TxArchivo As AxTextFer.AxTxFer
	Public WithEvents _Opt_1 As System.Windows.Forms.RadioButton
	Public WithEvents _Opt_0 As System.Windows.Forms.RadioButton
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents Opt As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmContabCobrar))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ChkRest = New System.Windows.Forms.CheckBox
		Me.cmdg_archivoOpen = New System.Windows.Forms.OpenFileDialog
		Me.CmdCancelar = New System.Windows.Forms.Button
		Me.CmdProcesar = New System.Windows.Forms.Button
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.DTPPerido = New AxMSComCtl2.AxDTPicker
		Me.Label1 = New System.Windows.Forms.Label
		Me.CmdArchivo = New System.Windows.Forms.Button
		Me.TxArchivo = New AxTextFer.AxTxFer
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me._Opt_1 = New System.Windows.Forms.RadioButton
		Me._Opt_0 = New System.Windows.Forms.RadioButton
		Me.Opt = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.Frame2.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.DTPPerido, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TxArchivo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Opt, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = "Importacion de Datos y Generacion de Asientos de Cobranzas"
		Me.ClientSize = New System.Drawing.Size(493, 186)
		Me.Location = New System.Drawing.Point(3, 22)
		Me.MaximizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "FrmContabCobrar"
		Me.ChkRest.Text = "Con Restauracion"
		Me.ChkRest.Size = New System.Drawing.Size(191, 16)
		Me.ChkRest.Location = New System.Drawing.Point(4, 77)
		Me.ChkRest.TabIndex = 10
		Me.ChkRest.Visible = False
		Me.ChkRest.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ChkRest.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.ChkRest.BackColor = System.Drawing.SystemColors.Control
		Me.ChkRest.CausesValidation = True
		Me.ChkRest.Enabled = True
		Me.ChkRest.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ChkRest.Cursor = System.Windows.Forms.Cursors.Default
		Me.ChkRest.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ChkRest.Appearance = System.Windows.Forms.Appearance.Normal
		Me.ChkRest.TabStop = True
		Me.ChkRest.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.ChkRest.Name = "ChkRest"
		Me.CmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.CmdCancelar.Text = "&Cancelar"
		Me.CmdCancelar.Size = New System.Drawing.Size(116, 21)
		Me.CmdCancelar.Location = New System.Drawing.Point(228, 125)
		Me.CmdCancelar.TabIndex = 7
		Me.CmdCancelar.BackColor = System.Drawing.SystemColors.Control
		Me.CmdCancelar.CausesValidation = True
		Me.CmdCancelar.Enabled = True
		Me.CmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.CmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
		Me.CmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CmdCancelar.TabStop = True
		Me.CmdCancelar.Name = "CmdCancelar"
		Me.CmdProcesar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.CmdProcesar.Text = "&Procesar"
		Me.CmdProcesar.Size = New System.Drawing.Size(116, 21)
		Me.CmdProcesar.Location = New System.Drawing.Point(112, 125)
		Me.CmdProcesar.TabIndex = 6
		Me.CmdProcesar.BackColor = System.Drawing.SystemColors.Control
		Me.CmdProcesar.CausesValidation = True
		Me.CmdProcesar.Enabled = True
		Me.CmdProcesar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.CmdProcesar.Cursor = System.Windows.Forms.Cursors.Default
		Me.CmdProcesar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CmdProcesar.TabStop = True
		Me.CmdProcesar.Name = "CmdProcesar"
		Me.Frame2.Text = "Periodo de Proceso"
		Me.Frame2.Size = New System.Drawing.Size(210, 67)
		Me.Frame2.Location = New System.Drawing.Point(228, 6)
		Me.Frame2.TabIndex = 5
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame2.Name = "Frame2"
		DTPPerido.OcxState = CType(resources.GetObject("DTPPerido.OcxState"), System.Windows.Forms.AxHost.State)
		Me.DTPPerido.Size = New System.Drawing.Size(137, 21)
		Me.DTPPerido.Location = New System.Drawing.Point(67, 28)
		Me.DTPPerido.TabIndex = 8
		Me.DTPPerido.Name = "DTPPerido"
		Me.Label1.Text = "Periodo :"
		Me.Label1.Size = New System.Drawing.Size(63, 18)
		Me.Label1.Location = New System.Drawing.Point(10, 32)
		Me.Label1.TabIndex = 9
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
		Me.CmdArchivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.CmdArchivo.Text = "..."
		Me.CmdArchivo.Enabled = False
		Me.CmdArchivo.Size = New System.Drawing.Size(25, 23)
		Me.CmdArchivo.Location = New System.Drawing.Point(442, 98)
		Me.CmdArchivo.TabIndex = 4
		Me.CmdArchivo.BackColor = System.Drawing.SystemColors.Control
		Me.CmdArchivo.CausesValidation = True
		Me.CmdArchivo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.CmdArchivo.Cursor = System.Windows.Forms.Cursors.Default
		Me.CmdArchivo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CmdArchivo.TabStop = True
		Me.CmdArchivo.Name = "CmdArchivo"
		TxArchivo.OcxState = CType(resources.GetObject("TxArchivo.OcxState"), System.Windows.Forms.AxHost.State)
		Me.TxArchivo.Size = New System.Drawing.Size(436, 24)
		Me.TxArchivo.Location = New System.Drawing.Point(3, 97)
		Me.TxArchivo.TabIndex = 3
		Me.TxArchivo.CausesValidation = -1
		Me.TxArchivo.Name = "TxArchivo"
		Me.Frame1.Text = "Tipo de Generacion"
		Me.Frame1.Size = New System.Drawing.Size(189, 65)
		Me.Frame1.Location = New System.Drawing.Point(4, 7)
		Me.Frame1.TabIndex = 0
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me._Opt_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._Opt_1.Text = "Data Original"
		Me._Opt_1.Size = New System.Drawing.Size(168, 14)
		Me._Opt_1.Location = New System.Drawing.Point(11, 43)
		Me._Opt_1.TabIndex = 2
		Me._Opt_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._Opt_1.BackColor = System.Drawing.SystemColors.Control
		Me._Opt_1.CausesValidation = True
		Me._Opt_1.Enabled = True
		Me._Opt_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Opt_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._Opt_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Opt_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._Opt_1.TabStop = True
		Me._Opt_1.Checked = False
		Me._Opt_1.Visible = True
		Me._Opt_1.Name = "_Opt_1"
		Me._Opt_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._Opt_0.Text = "Desde Archivo"
		Me._Opt_0.Size = New System.Drawing.Size(168, 14)
		Me._Opt_0.Location = New System.Drawing.Point(11, 20)
		Me._Opt_0.TabIndex = 1
		Me._Opt_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._Opt_0.BackColor = System.Drawing.SystemColors.Control
		Me._Opt_0.CausesValidation = True
		Me._Opt_0.Enabled = True
		Me._Opt_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Opt_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._Opt_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Opt_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._Opt_0.TabStop = True
		Me._Opt_0.Checked = False
		Me._Opt_0.Visible = True
		Me._Opt_0.Name = "_Opt_0"
		Me.Opt.SetIndex(_Opt_1, CType(1, Short))
		Me.Opt.SetIndex(_Opt_0, CType(0, Short))
		CType(Me.Opt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TxArchivo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DTPPerido, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Controls.Add(ChkRest)
		Me.Controls.Add(CmdCancelar)
		Me.Controls.Add(CmdProcesar)
		Me.Controls.Add(Frame2)
		Me.Controls.Add(CmdArchivo)
		Me.Controls.Add(TxArchivo)
		Me.Controls.Add(Frame1)
		Me.Frame2.Controls.Add(DTPPerido)
		Me.Frame2.Controls.Add(Label1)
		Me.Frame1.Controls.Add(_Opt_1)
		Me.Frame1.Controls.Add(_Opt_0)
		Me.Frame2.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class