<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FrmMantTipoAnalitico
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
	Public WithEvents Command3 As System.Windows.Forms.Button
	Public WithEvents Command7 As System.Windows.Forms.Button
	Public WithEvents command5 As System.Windows.Forms.Button
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents CmbOrden As System.Windows.Forms.ComboBox
	Public WithEvents TxFiltro As System.Windows.Forms.TextBox
	Public WithEvents Label33 As System.Windows.Forms.Label
	Public WithEvents Label32 As System.Windows.Forms.Label
	Public WithEvents Frame5 As System.Windows.Forms.GroupBox
	Public WithEvents Text2 As System.Windows.Forms.TextBox
	Public WithEvents Text1 As System.Windows.Forms.TextBox
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents DbGrid1 As AxMSDataGridLib.AxDataGrid
	Public WithEvents Command8 As System.Windows.Forms.Button
	Public WithEvents Command9 As System.Windows.Forms.Button
	Public WithEvents Frame4 As System.Windows.Forms.GroupBox
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmMantTipoAnalitico))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.Command2 = New System.Windows.Forms.Button
		Me.Command1 = New System.Windows.Forms.Button
		Me.Command3 = New System.Windows.Forms.Button
		Me.Command7 = New System.Windows.Forms.Button
		Me.command5 = New System.Windows.Forms.Button
		Me.Frame5 = New System.Windows.Forms.GroupBox
		Me.CmbOrden = New System.Windows.Forms.ComboBox
		Me.TxFiltro = New System.Windows.Forms.TextBox
		Me.Label33 = New System.Windows.Forms.Label
		Me.Label32 = New System.Windows.Forms.Label
		Me.Frame3 = New System.Windows.Forms.GroupBox
		Me.Text2 = New System.Windows.Forms.TextBox
		Me.Text1 = New System.Windows.Forms.TextBox
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.DbGrid1 = New AxMSDataGridLib.AxDataGrid
		Me.Frame4 = New System.Windows.Forms.GroupBox
		Me.Command8 = New System.Windows.Forms.Button
		Me.Command9 = New System.Windows.Forms.Button
		Me.Frame1.SuspendLayout()
		Me.Frame2.SuspendLayout()
		Me.Frame5.SuspendLayout()
		Me.Frame3.SuspendLayout()
		Me.Frame4.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.DbGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Form1"
		Me.ClientSize = New System.Drawing.Size(477, 357)
		Me.Location = New System.Drawing.Point(8, 31)
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
		Me.Name = "FrmMantTipoAnalitico"
		Me.Frame1.BackColor = System.Drawing.Color.White
		Me.Frame1.Size = New System.Drawing.Size(481, 361)
		Me.Frame1.Location = New System.Drawing.Point(0, 0)
		Me.Frame1.TabIndex = 0
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.Frame2.Size = New System.Drawing.Size(457, 73)
		Me.Frame2.Location = New System.Drawing.Point(8, 273)
		Me.Frame2.TabIndex = 11
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame2.Name = "Frame2"
		Me.Command2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Command2.Text = "&Modificar"
		Me.Command2.Size = New System.Drawing.Size(52, 45)
		Me.Command2.Location = New System.Drawing.Point(120, 16)
		Me.Command2.Image = CType(resources.GetObject("Command2.Image"), System.Drawing.Image)
		Me.Command2.TabIndex = 16
		Me.Command2.BackColor = System.Drawing.SystemColors.Control
		Me.Command2.CausesValidation = True
		Me.Command2.Enabled = True
		Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command2.TabStop = True
		Me.Command2.Name = "Command2"
		Me.Command1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Command1.Text = "&Ingreso"
		Me.Command1.Size = New System.Drawing.Size(52, 45)
		Me.Command1.Location = New System.Drawing.Point(24, 16)
		Me.Command1.Image = CType(resources.GetObject("Command1.Image"), System.Drawing.Image)
		Me.Command1.TabIndex = 15
		Me.Command1.BackColor = System.Drawing.SystemColors.Control
		Me.Command1.CausesValidation = True
		Me.Command1.Enabled = True
		Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command1.TabStop = True
		Me.Command1.Name = "Command1"
		Me.Command3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Command3.Text = "&Eliminar"
		Me.Command3.Size = New System.Drawing.Size(52, 45)
		Me.Command3.Location = New System.Drawing.Point(208, 16)
		Me.Command3.Image = CType(resources.GetObject("Command3.Image"), System.Drawing.Image)
		Me.Command3.TabIndex = 14
		Me.Command3.BackColor = System.Drawing.SystemColors.Control
		Me.Command3.CausesValidation = True
		Me.Command3.Enabled = True
		Me.Command3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command3.TabStop = True
		Me.Command3.Name = "Command3"
		Me.Command7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.CancelButton = Me.Command7
		Me.Command7.Text = "&Salir"
		Me.Command7.Size = New System.Drawing.Size(52, 45)
		Me.Command7.Location = New System.Drawing.Point(384, 17)
		Me.Command7.Image = CType(resources.GetObject("Command7.Image"), System.Drawing.Image)
		Me.Command7.TabIndex = 13
		Me.Command7.BackColor = System.Drawing.SystemColors.Control
		Me.Command7.CausesValidation = True
		Me.Command7.Enabled = True
		Me.Command7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command7.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command7.TabStop = True
		Me.Command7.Name = "Command7"
		Me.command5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.command5.Text = "&Reporte"
		Me.command5.Size = New System.Drawing.Size(52, 45)
		Me.command5.Location = New System.Drawing.Point(296, 16)
		Me.command5.Image = CType(resources.GetObject("command5.Image"), System.Drawing.Image)
		Me.command5.TabIndex = 12
		Me.command5.Visible = False
		Me.command5.BackColor = System.Drawing.SystemColors.Control
		Me.command5.CausesValidation = True
		Me.command5.Enabled = True
		Me.command5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.command5.Cursor = System.Windows.Forms.Cursors.Default
		Me.command5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.command5.TabStop = True
		Me.command5.Name = "command5"
		Me.Frame5.Size = New System.Drawing.Size(457, 49)
		Me.Frame5.Location = New System.Drawing.Point(8, 8)
		Me.Frame5.TabIndex = 6
		Me.Frame5.BackColor = System.Drawing.SystemColors.Control
		Me.Frame5.Enabled = True
		Me.Frame5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame5.Visible = True
		Me.Frame5.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame5.Name = "Frame5"
		Me.CmbOrden.Size = New System.Drawing.Size(105, 21)
		Me.CmbOrden.Location = New System.Drawing.Point(336, 16)
		Me.CmbOrden.Items.AddRange(New Object(){"    CODIGO", "DESCRIPCION"})
		Me.CmbOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CmbOrden.TabIndex = 8
		Me.CmbOrden.BackColor = System.Drawing.SystemColors.Window
		Me.CmbOrden.CausesValidation = True
		Me.CmbOrden.Enabled = True
		Me.CmbOrden.ForeColor = System.Drawing.SystemColors.WindowText
		Me.CmbOrden.IntegralHeight = True
		Me.CmbOrden.Cursor = System.Windows.Forms.Cursors.Default
		Me.CmbOrden.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CmbOrden.Sorted = False
		Me.CmbOrden.TabStop = True
		Me.CmbOrden.Visible = True
		Me.CmbOrden.Name = "CmbOrden"
		Me.TxFiltro.AutoSize = False
		Me.TxFiltro.Size = New System.Drawing.Size(177, 20)
		Me.TxFiltro.Location = New System.Drawing.Point(80, 16)
		Me.TxFiltro.Maxlength = 45
		Me.TxFiltro.TabIndex = 7
		Me.TxFiltro.Text = "TxFiltro"
		Me.TxFiltro.AcceptsReturn = True
		Me.TxFiltro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.TxFiltro.BackColor = System.Drawing.SystemColors.Window
		Me.TxFiltro.CausesValidation = True
		Me.TxFiltro.Enabled = True
		Me.TxFiltro.ForeColor = System.Drawing.SystemColors.WindowText
		Me.TxFiltro.HideSelection = True
		Me.TxFiltro.ReadOnly = False
		Me.TxFiltro.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TxFiltro.MultiLine = False
		Me.TxFiltro.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TxFiltro.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.TxFiltro.TabStop = True
		Me.TxFiltro.Visible = True
		Me.TxFiltro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.TxFiltro.Name = "TxFiltro"
		Me.Label33.Text = "Orden :"
		Me.Label33.Size = New System.Drawing.Size(41, 17)
		Me.Label33.Location = New System.Drawing.Point(288, 16)
		Me.Label33.TabIndex = 10
		Me.Label33.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label33.BackColor = System.Drawing.SystemColors.Control
		Me.Label33.Enabled = True
		Me.Label33.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label33.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label33.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label33.UseMnemonic = True
		Me.Label33.Visible = True
		Me.Label33.AutoSize = False
		Me.Label33.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label33.Name = "Label33"
		Me.Label32.Text = "Buscar  :"
		Me.Label32.Size = New System.Drawing.Size(49, 17)
		Me.Label32.Location = New System.Drawing.Point(16, 16)
		Me.Label32.TabIndex = 9
		Me.Label32.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label32.BackColor = System.Drawing.SystemColors.Control
		Me.Label32.Enabled = True
		Me.Label32.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label32.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label32.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label32.UseMnemonic = True
		Me.Label32.Visible = True
		Me.Label32.AutoSize = False
		Me.Label32.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label32.Name = "Label32"
		Me.Frame3.BackColor = System.Drawing.Color.FromARGB(128, 128, 255)
		Me.Frame3.Size = New System.Drawing.Size(457, 161)
		Me.Frame3.Location = New System.Drawing.Point(8, 56)
		Me.Frame3.TabIndex = 1
		Me.Frame3.Visible = False
		Me.Frame3.Enabled = True
		Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame3.Name = "Frame3"
		Me.Text2.AutoSize = False
		Me.Text2.Size = New System.Drawing.Size(233, 19)
		Me.Text2.Location = New System.Drawing.Point(152, 93)
		Me.Text2.Maxlength = 40
		Me.Text2.TabIndex = 3
		Me.Text2.AcceptsReturn = True
		Me.Text2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Text2.BackColor = System.Drawing.SystemColors.Window
		Me.Text2.CausesValidation = True
		Me.Text2.Enabled = True
		Me.Text2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Text2.HideSelection = True
		Me.Text2.ReadOnly = False
		Me.Text2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text2.MultiLine = False
		Me.Text2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Text2.TabStop = True
		Me.Text2.Visible = True
		Me.Text2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Text2.Name = "Text2"
		Me.Text1.AutoSize = False
		Me.Text1.Size = New System.Drawing.Size(89, 19)
		Me.Text1.Location = New System.Drawing.Point(151, 45)
		Me.Text1.Maxlength = 3
		Me.Text1.TabIndex = 2
		Me.Text1.AcceptsReturn = True
		Me.Text1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Text1.BackColor = System.Drawing.SystemColors.Window
		Me.Text1.CausesValidation = True
		Me.Text1.Enabled = True
		Me.Text1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Text1.HideSelection = True
		Me.Text1.ReadOnly = False
		Me.Text1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text1.MultiLine = False
		Me.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Text1.TabStop = True
		Me.Text1.Visible = True
		Me.Text1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Text1.Name = "Text1"
		Me.Label3.Text = "Descripción     :"
		Me.Label3.Size = New System.Drawing.Size(89, 17)
		Me.Label3.Location = New System.Drawing.Point(47, 93)
		Me.Label3.TabIndex = 5
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
		Me.Label2.Text = "Código             :"
		Me.Label2.Size = New System.Drawing.Size(96, 17)
		Me.Label2.Location = New System.Drawing.Point(47, 45)
		Me.Label2.TabIndex = 4
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
		DbGrid1.OcxState = CType(resources.GetObject("DbGrid1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.DbGrid1.Size = New System.Drawing.Size(457, 217)
		Me.DbGrid1.Location = New System.Drawing.Point(8, 56)
		Me.DbGrid1.TabIndex = 20
		Me.DbGrid1.Name = "DbGrid1"
		Me.Frame4.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me.Frame4.Size = New System.Drawing.Size(456, 71)
		Me.Frame4.Location = New System.Drawing.Point(8, 274)
		Me.Frame4.TabIndex = 17
		Me.Frame4.Visible = False
		Me.Frame4.Enabled = True
		Me.Frame4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame4.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame4.Name = "Frame4"
		Me.Command8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Command8.Text = "&Grabar"
		Me.Command8.Size = New System.Drawing.Size(52, 45)
		Me.Command8.Location = New System.Drawing.Point(120, 16)
		Me.Command8.Image = CType(resources.GetObject("Command8.Image"), System.Drawing.Image)
		Me.Command8.TabIndex = 19
		Me.Command8.BackColor = System.Drawing.SystemColors.Control
		Me.Command8.CausesValidation = True
		Me.Command8.Enabled = True
		Me.Command8.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command8.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command8.TabStop = True
		Me.Command8.Name = "Command8"
		Me.Command9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Command9.Text = "&Cancelar"
		Me.Command9.Size = New System.Drawing.Size(52, 45)
		Me.Command9.Location = New System.Drawing.Point(264, 16)
		Me.Command9.Image = CType(resources.GetObject("Command9.Image"), System.Drawing.Image)
		Me.Command9.TabIndex = 18
		Me.Command9.BackColor = System.Drawing.SystemColors.Control
		Me.Command9.CausesValidation = True
		Me.Command9.Enabled = True
		Me.Command9.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command9.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command9.TabStop = True
		Me.Command9.Name = "Command9"
		Me.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(Frame2)
		Me.Frame1.Controls.Add(Frame5)
		Me.Frame1.Controls.Add(Frame3)
		Me.Frame1.Controls.Add(DbGrid1)
		Me.Frame1.Controls.Add(Frame4)
		Me.Frame2.Controls.Add(Command2)
		Me.Frame2.Controls.Add(Command1)
		Me.Frame2.Controls.Add(Command3)
		Me.Frame2.Controls.Add(Command7)
		Me.Frame2.Controls.Add(command5)
		Me.Frame5.Controls.Add(CmbOrden)
		Me.Frame5.Controls.Add(TxFiltro)
		Me.Frame5.Controls.Add(Label33)
		Me.Frame5.Controls.Add(Label32)
		Me.Frame3.Controls.Add(Text2)
		Me.Frame3.Controls.Add(Text1)
		Me.Frame3.Controls.Add(Label3)
		Me.Frame3.Controls.Add(Label2)
		Me.Frame4.Controls.Add(Command8)
		Me.Frame4.Controls.Add(Command9)
		CType(Me.DbGrid1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame1.ResumeLayout(False)
		Me.Frame2.ResumeLayout(False)
		Me.Frame5.ResumeLayout(False)
		Me.Frame3.ResumeLayout(False)
		Me.Frame4.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class