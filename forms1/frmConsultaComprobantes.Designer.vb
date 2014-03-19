<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmConsultaComprobantes
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
	Public WithEvents _txt_2 As AxTextFer.AxTxFer
	Public WithEvents CtrAyu_Libro As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents _txt_0 As AxTextFer.AxTxFer
	Public WithEvents _txt_1 As AxTextFer.AxTxFer
	Public WithEvents DTPicker1 As AxMSComCtl2.AxDTPicker
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents CtrAyu_SubAsiento As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents CtrAyu_Asiento As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents Label25 As System.Windows.Forms.Label
	Public WithEvents lbSubAsiento As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cmdConsultar As System.Windows.Forms.Button
	Public WithEvents TDBG_ConsultaDetalle As AxTrueOleDBGrid70.AxTDBGrid
	Public WithEvents TDBG_ConsultaCabecera As AxTrueOleDBGrid70.AxTDBGrid
	Public WithEvents lblNroReg_Det As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents lblNro_Reg As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents txt As AxTxFerArray
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmConsultaComprobantes))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Frame3 = New System.Windows.Forms.GroupBox
		Me._txt_2 = New AxTextFer.AxTxFer
		Me.CtrAyu_Libro = New Axctrlayuda_f.AxCtr_Ayuda
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me._txt_0 = New AxTextFer.AxTxFer
		Me._txt_1 = New AxTextFer.AxTxFer
		Me.DTPicker1 = New AxMSComCtl2.AxDTPicker
		Me.Label7 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.CtrAyu_SubAsiento = New Axctrlayuda_f.AxCtr_Ayuda
		Me.CtrAyu_Asiento = New Axctrlayuda_f.AxCtr_Ayuda
		Me.Label25 = New System.Windows.Forms.Label
		Me.lbSubAsiento = New System.Windows.Forms.Label
		Me.cmdConsultar = New System.Windows.Forms.Button
		Me.TDBG_ConsultaDetalle = New AxTrueOleDBGrid70.AxTDBGrid
		Me.TDBG_ConsultaCabecera = New AxTrueOleDBGrid70.AxTDBGrid
		Me.lblNroReg_Det = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.lblNro_Reg = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.txt = New AxTxFerArray(components)
		Me.Frame3.SuspendLayout()
		Me.Frame2.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me._txt_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CtrAyu_Libro, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me._txt_0, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me._txt_1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DTPicker1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CtrAyu_SubAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CtrAyu_Asiento, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TDBG_ConsultaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TDBG_ConsultaCabecera, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txt, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.BackColor = System.Drawing.Color.FromARGB(192, 192, 192)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = "Consulta Comprobantes"
		Me.ClientSize = New System.Drawing.Size(744, 519)
		Me.Location = New System.Drawing.Point(3, 22)
		Me.MaximizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmConsultaComprobantes"
		Me.Frame3.Text = "Consulta por Libro y/o Glosa"
		Me.Frame3.Size = New System.Drawing.Size(737, 43)
		Me.Frame3.Location = New System.Drawing.Point(0, 45)
		Me.Frame3.TabIndex = 19
		Me.Frame3.BackColor = System.Drawing.SystemColors.Control
		Me.Frame3.Enabled = True
		Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame3.Visible = True
		Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame3.Name = "Frame3"
		_txt_2.OcxState = CType(resources.GetObject("_txt_2.OcxState"), System.Windows.Forms.AxHost.State)
		Me._txt_2.Size = New System.Drawing.Size(350, 20)
		Me._txt_2.Location = New System.Drawing.Point(383, 16)
		Me._txt_2.TabIndex = 3
		Me._txt_2.CausesValidation = -1
		Me._txt_2.Name = "_txt_2"
		CtrAyu_Libro.OcxState = CType(resources.GetObject("CtrAyu_Libro.OcxState"), System.Windows.Forms.AxHost.State)
		Me.CtrAyu_Libro.Size = New System.Drawing.Size(247, 21)
		Me.CtrAyu_Libro.Location = New System.Drawing.Point(53, 16)
		Me.CtrAyu_Libro.TabIndex = 2
		Me.CtrAyu_Libro.Name = "CtrAyu_Libro"
		Me.Label3.Text = "Libro"
		Me.Label3.Size = New System.Drawing.Size(32, 19)
		Me.Label3.Location = New System.Drawing.Point(12, 20)
		Me.Label3.TabIndex = 21
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label3.BackColor = System.Drawing.SystemColors.Control
		Me.Label3.Enabled = True
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.Label4.Text = "Glosa"
		Me.Label4.Size = New System.Drawing.Size(36, 16)
		Me.Label4.Location = New System.Drawing.Point(317, 19)
		Me.Label4.TabIndex = 20
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label4.BackColor = System.Drawing.SystemColors.Control
		Me.Label4.Enabled = True
		Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.Visible = True
		Me.Label4.AutoSize = False
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.Name = "Label4"
		Me.Frame2.Text = "Consulta por Números de Control"
		Me.Frame2.Size = New System.Drawing.Size(673, 41)
		Me.Frame2.Location = New System.Drawing.Point(1, 94)
		Me.Frame2.TabIndex = 16
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame2.Name = "Frame2"
		_txt_0.OcxState = CType(resources.GetObject("_txt_0.OcxState"), System.Windows.Forms.AxHost.State)
		Me._txt_0.Size = New System.Drawing.Size(114, 20)
		Me._txt_0.Location = New System.Drawing.Point(102, 15)
		Me._txt_0.TabIndex = 4
		Me._txt_0.CausesValidation = -1
		Me._txt_0.Name = "_txt_0"
		_txt_1.OcxState = CType(resources.GetObject("_txt_1.OcxState"), System.Windows.Forms.AxHost.State)
		Me._txt_1.Size = New System.Drawing.Size(168, 20)
		Me._txt_1.Location = New System.Drawing.Point(291, 12)
		Me._txt_1.TabIndex = 5
		Me._txt_1.CausesValidation = -1
		Me._txt_1.Name = "_txt_1"
		DTPicker1.OcxState = CType(resources.GetObject("DTPicker1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.DTPicker1.Size = New System.Drawing.Size(142, 21)
		Me.DTPicker1.Location = New System.Drawing.Point(525, 12)
		Me.DTPicker1.TabIndex = 23
		Me.DTPicker1.Name = "DTPicker1"
		Me.Label7.Text = "Fecha:"
		Me.Label7.Size = New System.Drawing.Size(80, 18)
		Me.Label7.Location = New System.Drawing.Point(467, 15)
		Me.Label7.TabIndex = 22
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label7.BackColor = System.Drawing.SystemColors.Control
		Me.Label7.Enabled = True
		Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label7.UseMnemonic = True
		Me.Label7.Visible = True
		Me.Label7.AutoSize = False
		Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label7.Name = "Label7"
		Me.Label1.Text = "Nº Comprobante"
		Me.Label1.Size = New System.Drawing.Size(85, 17)
		Me.Label1.Location = New System.Drawing.Point(7, 19)
		Me.Label1.TabIndex = 18
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
		Me.Label2.Text = "Nº Libro"
		Me.Label2.Size = New System.Drawing.Size(47, 17)
		Me.Label2.Location = New System.Drawing.Point(235, 17)
		Me.Label2.TabIndex = 17
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
		Me.Frame1.Text = "Consulta por Asiento y/o SubAsiento"
		Me.Frame1.Size = New System.Drawing.Size(737, 43)
		Me.Frame1.Location = New System.Drawing.Point(0, 1)
		Me.Frame1.TabIndex = 11
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		CtrAyu_SubAsiento.OcxState = CType(resources.GetObject("CtrAyu_SubAsiento.OcxState"), System.Windows.Forms.AxHost.State)
		Me.CtrAyu_SubAsiento.Size = New System.Drawing.Size(349, 24)
		Me.CtrAyu_SubAsiento.Location = New System.Drawing.Point(385, 15)
		Me.CtrAyu_SubAsiento.TabIndex = 1
		Me.CtrAyu_SubAsiento.Name = "CtrAyu_SubAsiento"
		CtrAyu_Asiento.OcxState = CType(resources.GetObject("CtrAyu_Asiento.OcxState"), System.Windows.Forms.AxHost.State)
		Me.CtrAyu_Asiento.Size = New System.Drawing.Size(246, 22)
		Me.CtrAyu_Asiento.Location = New System.Drawing.Point(54, 16)
		Me.CtrAyu_Asiento.TabIndex = 0
		Me.CtrAyu_Asiento.Name = "CtrAyu_Asiento"
		Me.Label25.Text = "Asiento :"
		Me.Label25.ForeColor = System.Drawing.Color.Black
		Me.Label25.Size = New System.Drawing.Size(48, 17)
		Me.Label25.Location = New System.Drawing.Point(5, 18)
		Me.Label25.TabIndex = 13
		Me.Label25.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label25.BackColor = System.Drawing.Color.Transparent
		Me.Label25.Enabled = True
		Me.Label25.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label25.UseMnemonic = True
		Me.Label25.Visible = True
		Me.Label25.AutoSize = False
		Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label25.Name = "Label25"
		Me.lbSubAsiento.Text = "Subasiento :"
		Me.lbSubAsiento.ForeColor = System.Drawing.Color.Black
		Me.lbSubAsiento.Size = New System.Drawing.Size(68, 13)
		Me.lbSubAsiento.Location = New System.Drawing.Point(314, 19)
		Me.lbSubAsiento.TabIndex = 12
		Me.lbSubAsiento.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lbSubAsiento.BackColor = System.Drawing.Color.Transparent
		Me.lbSubAsiento.Enabled = True
		Me.lbSubAsiento.Cursor = System.Windows.Forms.Cursors.Default
		Me.lbSubAsiento.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lbSubAsiento.UseMnemonic = True
		Me.lbSubAsiento.Visible = True
		Me.lbSubAsiento.AutoSize = False
		Me.lbSubAsiento.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lbSubAsiento.Name = "lbSubAsiento"
		Me.cmdConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdConsultar.Text = "..."
		Me.cmdConsultar.Size = New System.Drawing.Size(45, 24)
		Me.cmdConsultar.Location = New System.Drawing.Point(685, 106)
		Me.cmdConsultar.TabIndex = 8
		Me.cmdConsultar.BackColor = System.Drawing.SystemColors.Control
		Me.cmdConsultar.CausesValidation = True
		Me.cmdConsultar.Enabled = True
		Me.cmdConsultar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdConsultar.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdConsultar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdConsultar.TabStop = True
		Me.cmdConsultar.Name = "cmdConsultar"
		TDBG_ConsultaDetalle.OcxState = CType(resources.GetObject("TDBG_ConsultaDetalle.OcxState"), System.Windows.Forms.AxHost.State)
		Me.TDBG_ConsultaDetalle.Size = New System.Drawing.Size(736, 152)
		Me.TDBG_ConsultaDetalle.Location = New System.Drawing.Point(3, 343)
		Me.TDBG_ConsultaDetalle.TabIndex = 6
		Me.TDBG_ConsultaDetalle.Name = "TDBG_ConsultaDetalle"
		TDBG_ConsultaCabecera.OcxState = CType(resources.GetObject("TDBG_ConsultaCabecera.OcxState"), System.Windows.Forms.AxHost.State)
		Me.TDBG_ConsultaCabecera.Size = New System.Drawing.Size(736, 174)
		Me.TDBG_ConsultaCabecera.Location = New System.Drawing.Point(1, 145)
		Me.TDBG_ConsultaCabecera.TabIndex = 7
		Me.TDBG_ConsultaCabecera.Name = "TDBG_ConsultaCabecera"
		Me.lblNroReg_Det.Size = New System.Drawing.Size(73, 17)
		Me.lblNroReg_Det.Location = New System.Drawing.Point(666, 497)
		Me.lblNroReg_Det.TabIndex = 15
		Me.lblNroReg_Det.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblNroReg_Det.BackColor = System.Drawing.SystemColors.Control
		Me.lblNroReg_Det.Enabled = True
		Me.lblNroReg_Det.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblNroReg_Det.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblNroReg_Det.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblNroReg_Det.UseMnemonic = True
		Me.lblNroReg_Det.Visible = True
		Me.lblNroReg_Det.AutoSize = False
		Me.lblNroReg_Det.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblNroReg_Det.Name = "lblNroReg_Det"
		Me.Label6.Text = "Nº Registros"
		Me.Label6.Size = New System.Drawing.Size(74, 16)
		Me.Label6.Location = New System.Drawing.Point(588, 496)
		Me.Label6.TabIndex = 14
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label6.BackColor = System.Drawing.SystemColors.Control
		Me.Label6.Enabled = True
		Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label6.UseMnemonic = True
		Me.Label6.Visible = True
		Me.Label6.AutoSize = False
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label6.Name = "Label6"
		Me.lblNro_Reg.Size = New System.Drawing.Size(80, 17)
		Me.lblNro_Reg.Location = New System.Drawing.Point(657, 320)
		Me.lblNro_Reg.TabIndex = 10
		Me.lblNro_Reg.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblNro_Reg.BackColor = System.Drawing.SystemColors.Control
		Me.lblNro_Reg.Enabled = True
		Me.lblNro_Reg.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblNro_Reg.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblNro_Reg.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblNro_Reg.UseMnemonic = True
		Me.lblNro_Reg.Visible = True
		Me.lblNro_Reg.AutoSize = False
		Me.lblNro_Reg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblNro_Reg.Name = "lblNro_Reg"
		Me.Label5.Text = "Nº Registros:"
		Me.Label5.Size = New System.Drawing.Size(70, 15)
		Me.Label5.Location = New System.Drawing.Point(583, 320)
		Me.Label5.TabIndex = 9
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label5.BackColor = System.Drawing.SystemColors.Control
		Me.Label5.Enabled = True
		Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.UseMnemonic = True
		Me.Label5.Visible = True
		Me.Label5.AutoSize = False
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.Name = "Label5"
		Me.txt.SetIndex(_txt_2, CType(2, Short))
		Me.txt.SetIndex(_txt_0, CType(0, Short))
		Me.txt.SetIndex(_txt_1, CType(1, Short))
		CType(Me.txt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TDBG_ConsultaCabecera, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TDBG_ConsultaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CtrAyu_Asiento, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CtrAyu_SubAsiento, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DTPicker1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me._txt_1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me._txt_0, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CtrAyu_Libro, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me._txt_2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Controls.Add(Frame3)
		Me.Controls.Add(Frame2)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(cmdConsultar)
		Me.Controls.Add(TDBG_ConsultaDetalle)
		Me.Controls.Add(TDBG_ConsultaCabecera)
		Me.Controls.Add(lblNroReg_Det)
		Me.Controls.Add(Label6)
		Me.Controls.Add(lblNro_Reg)
		Me.Controls.Add(Label5)
		Me.Frame3.Controls.Add(_txt_2)
		Me.Frame3.Controls.Add(CtrAyu_Libro)
		Me.Frame3.Controls.Add(Label3)
		Me.Frame3.Controls.Add(Label4)
		Me.Frame2.Controls.Add(_txt_0)
		Me.Frame2.Controls.Add(_txt_1)
		Me.Frame2.Controls.Add(DTPicker1)
		Me.Frame2.Controls.Add(Label7)
		Me.Frame2.Controls.Add(Label1)
		Me.Frame2.Controls.Add(Label2)
		Me.Frame1.Controls.Add(CtrAyu_SubAsiento)
		Me.Frame1.Controls.Add(CtrAyu_Asiento)
		Me.Frame1.Controls.Add(Label25)
		Me.Frame1.Controls.Add(lbSubAsiento)
		Me.Frame3.ResumeLayout(False)
		Me.Frame2.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class