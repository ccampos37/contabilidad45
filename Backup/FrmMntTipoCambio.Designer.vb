<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FrmMntTipoCambio
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
	Public WithEvents _cmdBotones_0 As System.Windows.Forms.Button
	Public WithEvents _cmdBotones_1 As System.Windows.Forms.Button
	Public WithEvents _cmdBotones_2 As System.Windows.Forms.Button
	Public WithEvents _cmdBotones_4 As System.Windows.Forms.Button
	Public WithEvents _cmdBotones_3 As System.Windows.Forms.Button
	Public WithEvents frmbotones As System.Windows.Forms.GroupBox
	Public WithEvents lblNumReg As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents TDBGrid1 As AxTrueOleDBGrid70.AxTDBGrid
	Public WithEvents _SSTab1_TabPage0 As System.Windows.Forms.TabPage
	Public WithEvents cAcepta As System.Windows.Forms.Button
	Public WithEvents cCancela As System.Windows.Forms.Button
	Public WithEvents DTPicker1 As AxMSComCtl2.AxDTPicker
	Public WithEvents _txt_0 As AxTextFer.AxTxFer
	Public WithEvents _txt_1 As AxTextFer.AxTxFer
	Public WithEvents _txt_2 As AxTextFer.AxTxFer
	Public WithEvents _lbl_0 As System.Windows.Forms.Label
	Public WithEvents _lbl_1 As System.Windows.Forms.Label
	Public WithEvents _lbl_2 As System.Windows.Forms.Label
	Public WithEvents _lbl_3 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents _SSTab1_TabPage1 As System.Windows.Forms.TabPage
	Public WithEvents SSTab1 As System.Windows.Forms.TabControl
	Public WithEvents cmdBotones As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
	Public WithEvents lbl As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents txt As AxTxFerArray
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmMntTipoCambio))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.frmbotones = New System.Windows.Forms.GroupBox
		Me._cmdBotones_0 = New System.Windows.Forms.Button
		Me._cmdBotones_1 = New System.Windows.Forms.Button
		Me._cmdBotones_2 = New System.Windows.Forms.Button
		Me._cmdBotones_4 = New System.Windows.Forms.Button
		Me._cmdBotones_3 = New System.Windows.Forms.Button
		Me.SSTab1 = New System.Windows.Forms.TabControl
		Me._SSTab1_TabPage0 = New System.Windows.Forms.TabPage
		Me.lblNumReg = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.TDBGrid1 = New AxTrueOleDBGrid70.AxTDBGrid
		Me._SSTab1_TabPage1 = New System.Windows.Forms.TabPage
		Me.cAcepta = New System.Windows.Forms.Button
		Me.cCancela = New System.Windows.Forms.Button
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.DTPicker1 = New AxMSComCtl2.AxDTPicker
		Me._txt_0 = New AxTextFer.AxTxFer
		Me._txt_1 = New AxTextFer.AxTxFer
		Me._txt_2 = New AxTextFer.AxTxFer
		Me._lbl_0 = New System.Windows.Forms.Label
		Me._lbl_1 = New System.Windows.Forms.Label
		Me._lbl_2 = New System.Windows.Forms.Label
		Me._lbl_3 = New System.Windows.Forms.Label
		Me.cmdBotones = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(components)
		Me.lbl = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.txt = New AxTxFerArray(components)
		Me.frmbotones.SuspendLayout()
		Me.SSTab1.SuspendLayout()
		Me._SSTab1_TabPage0.SuspendLayout()
		Me._SSTab1_TabPage1.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.TDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DTPicker1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me._txt_0, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me._txt_1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me._txt_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.cmdBotones, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lbl, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txt, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me.Text = "Form2"
		Me.ClientSize = New System.Drawing.Size(484, 377)
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
		Me.Name = "FrmMntTipoCambio"
		Me.frmbotones.Size = New System.Drawing.Size(382, 37)
		Me.frmbotones.Location = New System.Drawing.Point(46, 314)
		Me.frmbotones.TabIndex = 0
		Me.frmbotones.BackColor = System.Drawing.SystemColors.Control
		Me.frmbotones.Enabled = True
		Me.frmbotones.ForeColor = System.Drawing.SystemColors.ControlText
		Me.frmbotones.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.frmbotones.Visible = True
		Me.frmbotones.Padding = New System.Windows.Forms.Padding(0)
		Me.frmbotones.Name = "frmbotones"
		Me._cmdBotones_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdBotones_0.Text = "&Nuevo"
		Me._cmdBotones_0.Size = New System.Drawing.Size(72, 22)
		Me._cmdBotones_0.Location = New System.Drawing.Point(4, 11)
		Me._cmdBotones_0.TabIndex = 5
		Me._cmdBotones_0.BackColor = System.Drawing.SystemColors.Control
		Me._cmdBotones_0.CausesValidation = True
		Me._cmdBotones_0.Enabled = True
		Me._cmdBotones_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdBotones_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdBotones_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdBotones_0.TabStop = True
		Me._cmdBotones_0.Name = "_cmdBotones_0"
		Me._cmdBotones_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdBotones_1.Text = "E&ditar"
		Me._cmdBotones_1.Size = New System.Drawing.Size(72, 22)
		Me._cmdBotones_1.Location = New System.Drawing.Point(79, 11)
		Me._cmdBotones_1.TabIndex = 4
		Me._cmdBotones_1.BackColor = System.Drawing.SystemColors.Control
		Me._cmdBotones_1.CausesValidation = True
		Me._cmdBotones_1.Enabled = True
		Me._cmdBotones_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdBotones_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdBotones_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdBotones_1.TabStop = True
		Me._cmdBotones_1.Name = "_cmdBotones_1"
		Me._cmdBotones_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdBotones_2.Text = "&Eliminar"
		Me._cmdBotones_2.Size = New System.Drawing.Size(72, 22)
		Me._cmdBotones_2.Location = New System.Drawing.Point(154, 11)
		Me._cmdBotones_2.TabIndex = 3
		Me._cmdBotones_2.BackColor = System.Drawing.SystemColors.Control
		Me._cmdBotones_2.CausesValidation = True
		Me._cmdBotones_2.Enabled = True
		Me._cmdBotones_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdBotones_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdBotones_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdBotones_2.TabStop = True
		Me._cmdBotones_2.Name = "_cmdBotones_2"
		Me._cmdBotones_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdBotones_4.Text = "&Salir"
		Me._cmdBotones_4.Size = New System.Drawing.Size(72, 22)
		Me._cmdBotones_4.Location = New System.Drawing.Point(304, 11)
		Me._cmdBotones_4.TabIndex = 2
		Me._cmdBotones_4.BackColor = System.Drawing.SystemColors.Control
		Me._cmdBotones_4.CausesValidation = True
		Me._cmdBotones_4.Enabled = True
		Me._cmdBotones_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdBotones_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdBotones_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdBotones_4.TabStop = True
		Me._cmdBotones_4.Name = "_cmdBotones_4"
		Me._cmdBotones_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdBotones_3.Text = "&Imprimir"
		Me._cmdBotones_3.Size = New System.Drawing.Size(72, 22)
		Me._cmdBotones_3.Location = New System.Drawing.Point(229, 11)
		Me._cmdBotones_3.TabIndex = 1
		Me._cmdBotones_3.BackColor = System.Drawing.SystemColors.Control
		Me._cmdBotones_3.CausesValidation = True
		Me._cmdBotones_3.Enabled = True
		Me._cmdBotones_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdBotones_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdBotones_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdBotones_3.TabStop = True
		Me._cmdBotones_3.Name = "_cmdBotones_3"
		Me.SSTab1.Size = New System.Drawing.Size(442, 302)
		Me.SSTab1.Location = New System.Drawing.Point(16, 8)
		Me.SSTab1.TabIndex = 6
		Me.SSTab1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
		Me.SSTab1.SelectedIndex = 1
		Me.SSTab1.ItemSize = New System.Drawing.Size(42, 18)
		Me.SSTab1.BackColor = System.Drawing.Color.White
		Me.SSTab1.Name = "SSTab1"
		Me._SSTab1_TabPage0.Text = "Consulta"
		Me.lblNumReg.BackColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me.lblNumReg.Text = "lblNumReg"
		Me.lblNumReg.ForeColor = System.Drawing.Color.Yellow
		Me.lblNumReg.Size = New System.Drawing.Size(61, 19)
		Me.lblNumReg.Location = New System.Drawing.Point(379, 364)
		Me.lblNumReg.TabIndex = 20
		Me.lblNumReg.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblNumReg.Enabled = True
		Me.lblNumReg.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblNumReg.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblNumReg.UseMnemonic = True
		Me.lblNumReg.Visible = True
		Me.lblNumReg.AutoSize = False
		Me.lblNumReg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblNumReg.Name = "lblNumReg"
		Me.Label1.Text = "Nº Registros"
		Me.Label1.Size = New System.Drawing.Size(60, 18)
		Me.Label1.Location = New System.Drawing.Point(316, 365)
		Me.Label1.TabIndex = 19
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
		TDBGrid1.OcxState = CType(resources.GetObject("TDBGrid1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.TDBGrid1.Size = New System.Drawing.Size(434, 274)
		Me.TDBGrid1.Location = New System.Drawing.Point(3, 24)
		Me.TDBGrid1.TabIndex = 18
		Me.TDBGrid1.Name = "TDBGrid1"
		Me._SSTab1_TabPage1.Text = "Mantenimiento"
		Me.cAcepta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cAcepta.Text = "&Aceptar"
		Me.cAcepta.Size = New System.Drawing.Size(76, 23)
		Me.cAcepta.Location = New System.Drawing.Point(135, 271)
		Me.cAcepta.TabIndex = 7
		Me.cAcepta.BackColor = System.Drawing.SystemColors.Control
		Me.cAcepta.CausesValidation = True
		Me.cAcepta.Enabled = True
		Me.cAcepta.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cAcepta.Cursor = System.Windows.Forms.Cursors.Default
		Me.cAcepta.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cAcepta.TabStop = True
		Me.cAcepta.Name = "cAcepta"
		Me.cCancela.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cCancela.Text = "&Cancelar"
		Me.cCancela.Size = New System.Drawing.Size(76, 23)
		Me.cCancela.Location = New System.Drawing.Point(231, 271)
		Me.cCancela.TabIndex = 8
		Me.cCancela.BackColor = System.Drawing.SystemColors.Control
		Me.cCancela.CausesValidation = True
		Me.cCancela.Enabled = True
		Me.cCancela.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cCancela.Cursor = System.Windows.Forms.Cursors.Default
		Me.cCancela.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cCancela.TabStop = True
		Me.cCancela.Name = "cCancela"
		Me.Frame1.BackColor = System.Drawing.Color.FromARGB(192, 192, 255)
		Me.Frame1.Size = New System.Drawing.Size(437, 243)
		Me.Frame1.Location = New System.Drawing.Point(2, 22)
		Me.Frame1.TabIndex = 9
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		DTPicker1.OcxState = CType(resources.GetObject("DTPicker1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.DTPicker1.Size = New System.Drawing.Size(251, 21)
		Me.DTPicker1.Location = New System.Drawing.Point(182, 9)
		Me.DTPicker1.TabIndex = 10
		Me.DTPicker1.Name = "DTPicker1"
		_txt_0.OcxState = CType(resources.GetObject("_txt_0.OcxState"), System.Windows.Forms.AxHost.State)
		Me._txt_0.Size = New System.Drawing.Size(252, 20)
		Me._txt_0.Location = New System.Drawing.Point(181, 30)
		Me._txt_0.TabIndex = 11
		Me._txt_0.CausesValidation = -1
		Me._txt_0.Name = "_txt_0"
		_txt_1.OcxState = CType(resources.GetObject("_txt_1.OcxState"), System.Windows.Forms.AxHost.State)
		Me._txt_1.Size = New System.Drawing.Size(253, 20)
		Me._txt_1.Location = New System.Drawing.Point(181, 51)
		Me._txt_1.TabIndex = 12
		Me._txt_1.CausesValidation = -1
		Me._txt_1.Name = "_txt_1"
		_txt_2.OcxState = CType(resources.GetObject("_txt_2.OcxState"), System.Windows.Forms.AxHost.State)
		Me._txt_2.Size = New System.Drawing.Size(253, 20)
		Me._txt_2.Location = New System.Drawing.Point(181, 72)
		Me._txt_2.TabIndex = 13
		Me._txt_2.CausesValidation = -1
		Me._txt_2.Name = "_txt_2"
		Me._lbl_0.BackColor = System.Drawing.Color.FromARGB(192, 192, 255)
		Me._lbl_0.Text = "Fecha"
		Me._lbl_0.Size = New System.Drawing.Size(154, 19)
		Me._lbl_0.Location = New System.Drawing.Point(8, 14)
		Me._lbl_0.TabIndex = 17
		Me._lbl_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lbl_0.Enabled = True
		Me._lbl_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lbl_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lbl_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lbl_0.UseMnemonic = True
		Me._lbl_0.Visible = True
		Me._lbl_0.AutoSize = False
		Me._lbl_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lbl_0.Name = "_lbl_0"
		Me._lbl_1.BackColor = System.Drawing.Color.FromARGB(192, 192, 255)
		Me._lbl_1.Text = "Tipo Cambio Compra"
		Me._lbl_1.Size = New System.Drawing.Size(154, 19)
		Me._lbl_1.Location = New System.Drawing.Point(8, 34)
		Me._lbl_1.TabIndex = 16
		Me._lbl_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lbl_1.Enabled = True
		Me._lbl_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lbl_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lbl_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lbl_1.UseMnemonic = True
		Me._lbl_1.Visible = True
		Me._lbl_1.AutoSize = False
		Me._lbl_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lbl_1.Name = "_lbl_1"
		Me._lbl_2.BackColor = System.Drawing.Color.FromARGB(192, 192, 255)
		Me._lbl_2.Text = "Tipo Cambio Venta"
		Me._lbl_2.Size = New System.Drawing.Size(154, 19)
		Me._lbl_2.Location = New System.Drawing.Point(9, 54)
		Me._lbl_2.TabIndex = 15
		Me._lbl_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lbl_2.Enabled = True
		Me._lbl_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lbl_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._lbl_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lbl_2.UseMnemonic = True
		Me._lbl_2.Visible = True
		Me._lbl_2.AutoSize = False
		Me._lbl_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lbl_2.Name = "_lbl_2"
		Me._lbl_3.BackColor = System.Drawing.Color.FromARGB(192, 192, 255)
		Me._lbl_3.Text = "Tipo Cambio Promedio"
		Me._lbl_3.Size = New System.Drawing.Size(154, 19)
		Me._lbl_3.Location = New System.Drawing.Point(8, 74)
		Me._lbl_3.TabIndex = 14
		Me._lbl_3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lbl_3.Enabled = True
		Me._lbl_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lbl_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._lbl_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lbl_3.UseMnemonic = True
		Me._lbl_3.Visible = True
		Me._lbl_3.AutoSize = False
		Me._lbl_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lbl_3.Name = "_lbl_3"
		Me.Controls.Add(frmbotones)
		Me.Controls.Add(SSTab1)
		Me.frmbotones.Controls.Add(_cmdBotones_0)
		Me.frmbotones.Controls.Add(_cmdBotones_1)
		Me.frmbotones.Controls.Add(_cmdBotones_2)
		Me.frmbotones.Controls.Add(_cmdBotones_4)
		Me.frmbotones.Controls.Add(_cmdBotones_3)
		Me.SSTab1.Controls.Add(_SSTab1_TabPage0)
		Me.SSTab1.Controls.Add(_SSTab1_TabPage1)
		Me._SSTab1_TabPage0.Controls.Add(lblNumReg)
		Me._SSTab1_TabPage0.Controls.Add(Label1)
		Me._SSTab1_TabPage0.Controls.Add(TDBGrid1)
		Me._SSTab1_TabPage1.Controls.Add(cAcepta)
		Me._SSTab1_TabPage1.Controls.Add(cCancela)
		Me._SSTab1_TabPage1.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(DTPicker1)
		Me.Frame1.Controls.Add(_txt_0)
		Me.Frame1.Controls.Add(_txt_1)
		Me.Frame1.Controls.Add(_txt_2)
		Me.Frame1.Controls.Add(_lbl_0)
		Me.Frame1.Controls.Add(_lbl_1)
		Me.Frame1.Controls.Add(_lbl_2)
		Me.Frame1.Controls.Add(_lbl_3)
		Me.cmdBotones.SetIndex(_cmdBotones_0, CType(0, Short))
		Me.cmdBotones.SetIndex(_cmdBotones_1, CType(1, Short))
		Me.cmdBotones.SetIndex(_cmdBotones_2, CType(2, Short))
		Me.cmdBotones.SetIndex(_cmdBotones_4, CType(4, Short))
		Me.cmdBotones.SetIndex(_cmdBotones_3, CType(3, Short))
		Me.lbl.SetIndex(_lbl_0, CType(0, Short))
		Me.lbl.SetIndex(_lbl_1, CType(1, Short))
		Me.lbl.SetIndex(_lbl_2, CType(2, Short))
		Me.lbl.SetIndex(_lbl_3, CType(3, Short))
		Me.txt.SetIndex(_txt_0, CType(0, Short))
		Me.txt.SetIndex(_txt_1, CType(1, Short))
		Me.txt.SetIndex(_txt_2, CType(2, Short))
		CType(Me.txt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lbl, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.cmdBotones, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me._txt_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me._txt_1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me._txt_0, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DTPicker1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.frmbotones.ResumeLayout(False)
		Me.SSTab1.ResumeLayout(False)
		Me._SSTab1_TabPage0.ResumeLayout(False)
		Me._SSTab1_TabPage1.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class