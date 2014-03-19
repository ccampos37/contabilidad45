<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FrmMntEstructuraBalance
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
	Public WithEvents CmdGrabar As System.Windows.Forms.Button
	Public WithEvents Cmdcancelar As System.Windows.Forms.Button
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents CmdModificar As System.Windows.Forms.Button
	Public WithEvents CmdNuevo As System.Windows.Forms.Button
	Public WithEvents Cmdeliminar As System.Windows.Forms.Button
	Public WithEvents CmdSalir As System.Windows.Forms.Button
	Public WithEvents cmdImprimir As System.Windows.Forms.Button
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents Txtsigno2 As System.Windows.Forms.TextBox
	Public WithEvents ChkN2 As System.Windows.Forms.CheckBox
	Public WithEvents Txtdesc2 As System.Windows.Forms.TextBox
	Public WithEvents Txtctas2 As System.Windows.Forms.TextBox
	Public WithEvents Txttipolinea2 As System.Windows.Forms.TextBox
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents Framepasivo As System.Windows.Forms.GroupBox
	Public WithEvents txttipolinea1 As System.Windows.Forms.TextBox
	Public WithEvents txtCtas1 As System.Windows.Forms.TextBox
	Public WithEvents Txtdesc1 As System.Windows.Forms.TextBox
	Public WithEvents ChkN1 As System.Windows.Forms.CheckBox
	Public WithEvents Txtsigno1 As System.Windows.Forms.TextBox
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frameactivo As System.Windows.Forms.GroupBox
	Public WithEvents ChKDual As System.Windows.Forms.CheckBox
	Public WithEvents txtlinea As System.Windows.Forms.TextBox
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Framelinea As System.Windows.Forms.GroupBox
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents DbGrid1 As AxMSDataGridLib.AxDataGrid
	Public WithEvents frame5 As System.Windows.Forms.GroupBox
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmMntEstructuraBalance))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.CmdGrabar = New System.Windows.Forms.Button
		Me.Cmdcancelar = New System.Windows.Forms.Button
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.CmdModificar = New System.Windows.Forms.Button
		Me.CmdNuevo = New System.Windows.Forms.Button
		Me.Cmdeliminar = New System.Windows.Forms.Button
		Me.CmdSalir = New System.Windows.Forms.Button
		Me.cmdImprimir = New System.Windows.Forms.Button
		Me.Frame3 = New System.Windows.Forms.GroupBox
		Me.Framepasivo = New System.Windows.Forms.GroupBox
		Me.Txtsigno2 = New System.Windows.Forms.TextBox
		Me.ChkN2 = New System.Windows.Forms.CheckBox
		Me.Txtdesc2 = New System.Windows.Forms.TextBox
		Me.Txtctas2 = New System.Windows.Forms.TextBox
		Me.Txttipolinea2 = New System.Windows.Forms.TextBox
		Me.Label7 = New System.Windows.Forms.Label
		Me.Label8 = New System.Windows.Forms.Label
		Me.Label9 = New System.Windows.Forms.Label
		Me.Label10 = New System.Windows.Forms.Label
		Me.Label11 = New System.Windows.Forms.Label
		Me.Frameactivo = New System.Windows.Forms.GroupBox
		Me.txttipolinea1 = New System.Windows.Forms.TextBox
		Me.txtCtas1 = New System.Windows.Forms.TextBox
		Me.Txtdesc1 = New System.Windows.Forms.TextBox
		Me.ChkN1 = New System.Windows.Forms.CheckBox
		Me.Txtsigno1 = New System.Windows.Forms.TextBox
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Framelinea = New System.Windows.Forms.GroupBox
		Me.ChKDual = New System.Windows.Forms.CheckBox
		Me.txtlinea = New System.Windows.Forms.TextBox
		Me.Label2 = New System.Windows.Forms.Label
		Me.frame5 = New System.Windows.Forms.GroupBox
		Me.DbGrid1 = New AxMSDataGridLib.AxDataGrid
		Me.Frame1.SuspendLayout()
		Me.Frame2.SuspendLayout()
		Me.Frame3.SuspendLayout()
		Me.Framepasivo.SuspendLayout()
		Me.Frameactivo.SuspendLayout()
		Me.Framelinea.SuspendLayout()
		Me.frame5.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.DbGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Estructura del Balance General"
		Me.ClientSize = New System.Drawing.Size(611, 546)
		Me.Location = New System.Drawing.Point(8, 31)
		Me.ForeColor = System.Drawing.Color.Red
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
		Me.Name = "FrmMntEstructuraBalance"
		Me.Frame1.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me.Frame1.Size = New System.Drawing.Size(560, 71)
		Me.Frame1.Location = New System.Drawing.Point(8, 466)
		Me.Frame1.TabIndex = 6
		Me.Frame1.Visible = False
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.CmdGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.CmdGrabar.Text = "&Grabar"
		Me.CmdGrabar.Size = New System.Drawing.Size(52, 45)
		Me.CmdGrabar.Location = New System.Drawing.Point(120, 16)
		Me.CmdGrabar.Image = CType(resources.GetObject("CmdGrabar.Image"), System.Drawing.Image)
		Me.CmdGrabar.TabIndex = 8
		Me.CmdGrabar.BackColor = System.Drawing.SystemColors.Control
		Me.CmdGrabar.CausesValidation = True
		Me.CmdGrabar.Enabled = True
		Me.CmdGrabar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.CmdGrabar.Cursor = System.Windows.Forms.Cursors.Default
		Me.CmdGrabar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CmdGrabar.TabStop = True
		Me.CmdGrabar.Name = "CmdGrabar"
		Me.Cmdcancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Cmdcancelar.Text = "&Cancelar"
		Me.Cmdcancelar.Size = New System.Drawing.Size(52, 45)
		Me.Cmdcancelar.Location = New System.Drawing.Point(264, 16)
		Me.Cmdcancelar.Image = CType(resources.GetObject("Cmdcancelar.Image"), System.Drawing.Image)
		Me.Cmdcancelar.TabIndex = 7
		Me.Cmdcancelar.BackColor = System.Drawing.SystemColors.Control
		Me.Cmdcancelar.CausesValidation = True
		Me.Cmdcancelar.Enabled = True
		Me.Cmdcancelar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Cmdcancelar.Cursor = System.Windows.Forms.Cursors.Default
		Me.Cmdcancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Cmdcancelar.TabStop = True
		Me.Cmdcancelar.Name = "Cmdcancelar"
		Me.Frame2.BackColor = System.Drawing.Color.FromARGB(224, 224, 224)
		Me.Frame2.Size = New System.Drawing.Size(553, 73)
		Me.Frame2.Location = New System.Drawing.Point(16, 464)
		Me.Frame2.TabIndex = 0
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame2.Name = "Frame2"
		Me.CmdModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.CmdModificar.Text = "&Modificar"
		Me.CmdModificar.Size = New System.Drawing.Size(52, 45)
		Me.CmdModificar.Location = New System.Drawing.Point(136, 16)
		Me.CmdModificar.Image = CType(resources.GetObject("CmdModificar.Image"), System.Drawing.Image)
		Me.CmdModificar.TabIndex = 5
		Me.CmdModificar.BackColor = System.Drawing.SystemColors.Control
		Me.CmdModificar.CausesValidation = True
		Me.CmdModificar.Enabled = True
		Me.CmdModificar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.CmdModificar.Cursor = System.Windows.Forms.Cursors.Default
		Me.CmdModificar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CmdModificar.TabStop = True
		Me.CmdModificar.Name = "CmdModificar"
		Me.CmdNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.CmdNuevo.Text = "&Ingreso"
		Me.CmdNuevo.Size = New System.Drawing.Size(52, 45)
		Me.CmdNuevo.Location = New System.Drawing.Point(32, 16)
		Me.CmdNuevo.Image = CType(resources.GetObject("CmdNuevo.Image"), System.Drawing.Image)
		Me.CmdNuevo.TabIndex = 4
		Me.CmdNuevo.BackColor = System.Drawing.SystemColors.Control
		Me.CmdNuevo.CausesValidation = True
		Me.CmdNuevo.Enabled = True
		Me.CmdNuevo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.CmdNuevo.Cursor = System.Windows.Forms.Cursors.Default
		Me.CmdNuevo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CmdNuevo.TabStop = True
		Me.CmdNuevo.Name = "CmdNuevo"
		Me.Cmdeliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Cmdeliminar.Text = "&Eliminar"
		Me.Cmdeliminar.Size = New System.Drawing.Size(52, 45)
		Me.Cmdeliminar.Location = New System.Drawing.Point(232, 16)
		Me.Cmdeliminar.Image = CType(resources.GetObject("Cmdeliminar.Image"), System.Drawing.Image)
		Me.Cmdeliminar.TabIndex = 3
		Me.Cmdeliminar.BackColor = System.Drawing.SystemColors.Control
		Me.Cmdeliminar.CausesValidation = True
		Me.Cmdeliminar.Enabled = True
		Me.Cmdeliminar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Cmdeliminar.Cursor = System.Windows.Forms.Cursors.Default
		Me.Cmdeliminar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Cmdeliminar.TabStop = True
		Me.Cmdeliminar.Name = "Cmdeliminar"
		Me.CmdSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.CancelButton = Me.CmdSalir
		Me.CmdSalir.Text = "&Salir"
		Me.CmdSalir.Size = New System.Drawing.Size(52, 45)
		Me.CmdSalir.Location = New System.Drawing.Point(440, 16)
		Me.CmdSalir.Image = CType(resources.GetObject("CmdSalir.Image"), System.Drawing.Image)
		Me.CmdSalir.TabIndex = 2
		Me.CmdSalir.BackColor = System.Drawing.SystemColors.Control
		Me.CmdSalir.CausesValidation = True
		Me.CmdSalir.Enabled = True
		Me.CmdSalir.ForeColor = System.Drawing.SystemColors.ControlText
		Me.CmdSalir.Cursor = System.Windows.Forms.Cursors.Default
		Me.CmdSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CmdSalir.TabStop = True
		Me.CmdSalir.Name = "CmdSalir"
		Me.cmdImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdImprimir.Text = "&Reporte"
		Me.cmdImprimir.Size = New System.Drawing.Size(52, 45)
		Me.cmdImprimir.Location = New System.Drawing.Point(328, 16)
		Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
		Me.cmdImprimir.TabIndex = 1
		Me.cmdImprimir.BackColor = System.Drawing.SystemColors.Control
		Me.cmdImprimir.CausesValidation = True
		Me.cmdImprimir.Enabled = True
		Me.cmdImprimir.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdImprimir.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdImprimir.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdImprimir.TabStop = True
		Me.cmdImprimir.Name = "cmdImprimir"
		Me.Frame3.Size = New System.Drawing.Size(569, 457)
		Me.Frame3.Location = New System.Drawing.Point(8, 0)
		Me.Frame3.TabIndex = 11
		Me.Frame3.BackColor = System.Drawing.SystemColors.Control
		Me.Frame3.Enabled = True
		Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame3.Visible = True
		Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame3.Name = "Frame3"
		Me.Framepasivo.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me.Framepasivo.Text = "PASIVO"
		Me.Framepasivo.ForeColor = System.Drawing.Color.Blue
		Me.Framepasivo.Size = New System.Drawing.Size(537, 169)
		Me.Framepasivo.Location = New System.Drawing.Point(8, 272)
		Me.Framepasivo.TabIndex = 26
		Me.Framepasivo.Enabled = True
		Me.Framepasivo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Framepasivo.Visible = True
		Me.Framepasivo.Padding = New System.Windows.Forms.Padding(0)
		Me.Framepasivo.Name = "Framepasivo"
		Me.Txtsigno2.AutoSize = False
		Me.Txtsigno2.ForeColor = System.Drawing.Color.Black
		Me.Txtsigno2.Size = New System.Drawing.Size(25, 25)
		Me.Txtsigno2.Location = New System.Drawing.Point(472, 56)
		Me.Txtsigno2.Maxlength = 60
		Me.Txtsigno2.TabIndex = 31
		Me.Txtsigno2.AcceptsReturn = True
		Me.Txtsigno2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Txtsigno2.BackColor = System.Drawing.SystemColors.Window
		Me.Txtsigno2.CausesValidation = True
		Me.Txtsigno2.Enabled = True
		Me.Txtsigno2.HideSelection = True
		Me.Txtsigno2.ReadOnly = False
		Me.Txtsigno2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Txtsigno2.MultiLine = False
		Me.Txtsigno2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Txtsigno2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Txtsigno2.TabStop = True
		Me.Txtsigno2.Visible = True
		Me.Txtsigno2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Txtsigno2.Name = "Txtsigno2"
		Me.ChkN2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.ChkN2.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me.ChkN2.Text = "Acepta Valor Negativo"
		Me.ChkN2.Size = New System.Drawing.Size(121, 25)
		Me.ChkN2.Location = New System.Drawing.Point(8, 56)
		Me.ChkN2.TabIndex = 30
		Me.ChkN2.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.ChkN2.CausesValidation = True
		Me.ChkN2.Enabled = True
		Me.ChkN2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ChkN2.Cursor = System.Windows.Forms.Cursors.Default
		Me.ChkN2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ChkN2.Appearance = System.Windows.Forms.Appearance.Normal
		Me.ChkN2.TabStop = True
		Me.ChkN2.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.ChkN2.Visible = True
		Me.ChkN2.Name = "ChkN2"
		Me.Txtdesc2.AutoSize = False
		Me.Txtdesc2.ForeColor = System.Drawing.Color.Black
		Me.Txtdesc2.Size = New System.Drawing.Size(377, 25)
		Me.Txtdesc2.Location = New System.Drawing.Point(120, 128)
		Me.Txtdesc2.Maxlength = 60
		Me.Txtdesc2.TabIndex = 29
		Me.Txtdesc2.AcceptsReturn = True
		Me.Txtdesc2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Txtdesc2.BackColor = System.Drawing.SystemColors.Window
		Me.Txtdesc2.CausesValidation = True
		Me.Txtdesc2.Enabled = True
		Me.Txtdesc2.HideSelection = True
		Me.Txtdesc2.ReadOnly = False
		Me.Txtdesc2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Txtdesc2.MultiLine = False
		Me.Txtdesc2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Txtdesc2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Txtdesc2.TabStop = True
		Me.Txtdesc2.Visible = True
		Me.Txtdesc2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Txtdesc2.Name = "Txtdesc2"
		Me.Txtctas2.AutoSize = False
		Me.Txtctas2.ForeColor = System.Drawing.Color.Black
		Me.Txtctas2.Size = New System.Drawing.Size(377, 25)
		Me.Txtctas2.Location = New System.Drawing.Point(120, 88)
		Me.Txtctas2.Maxlength = 60
		Me.Txtctas2.TabIndex = 28
		Me.Txtctas2.AcceptsReturn = True
		Me.Txtctas2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Txtctas2.BackColor = System.Drawing.SystemColors.Window
		Me.Txtctas2.CausesValidation = True
		Me.Txtctas2.Enabled = True
		Me.Txtctas2.HideSelection = True
		Me.Txtctas2.ReadOnly = False
		Me.Txtctas2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Txtctas2.MultiLine = False
		Me.Txtctas2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Txtctas2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Txtctas2.TabStop = True
		Me.Txtctas2.Visible = True
		Me.Txtctas2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Txtctas2.Name = "Txtctas2"
		Me.Txttipolinea2.AutoSize = False
		Me.Txttipolinea2.ForeColor = System.Drawing.Color.Black
		Me.Txttipolinea2.Size = New System.Drawing.Size(25, 25)
		Me.Txttipolinea2.Location = New System.Drawing.Point(120, 24)
		Me.Txttipolinea2.Maxlength = 1
		Me.Txttipolinea2.TabIndex = 27
		Me.Txttipolinea2.AcceptsReturn = True
		Me.Txttipolinea2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Txttipolinea2.BackColor = System.Drawing.SystemColors.Window
		Me.Txttipolinea2.CausesValidation = True
		Me.Txttipolinea2.Enabled = True
		Me.Txttipolinea2.HideSelection = True
		Me.Txttipolinea2.ReadOnly = False
		Me.Txttipolinea2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Txttipolinea2.MultiLine = False
		Me.Txttipolinea2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Txttipolinea2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Txttipolinea2.TabStop = True
		Me.Txttipolinea2.Visible = True
		Me.Txttipolinea2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Txttipolinea2.Name = "Txttipolinea2"
		Me.Label7.BackColor = System.Drawing.SystemColors.Window
		Me.Label7.Text = "Signo (+/-) en reporte"
		Me.Label7.ForeColor = System.Drawing.Color.Black
		Me.Label7.Size = New System.Drawing.Size(137, 17)
		Me.Label7.Location = New System.Drawing.Point(328, 56)
		Me.Label7.TabIndex = 36
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label7.Enabled = True
		Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label7.UseMnemonic = True
		Me.Label7.Visible = True
		Me.Label7.AutoSize = False
		Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label7.Name = "Label7"
		Me.Label8.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me.Label8.Text = "Descripcion Linea"
		Me.Label8.ForeColor = System.Drawing.Color.Black
		Me.Label8.Size = New System.Drawing.Size(113, 17)
		Me.Label8.Location = New System.Drawing.Point(8, 128)
		Me.Label8.TabIndex = 35
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label8.Enabled = True
		Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label8.UseMnemonic = True
		Me.Label8.Visible = True
		Me.Label8.AutoSize = False
		Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label8.Name = "Label8"
		Me.Label9.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me.Label9.Text = "Cuentas Activo"
		Me.Label9.ForeColor = System.Drawing.Color.Black
		Me.Label9.Size = New System.Drawing.Size(113, 17)
		Me.Label9.Location = New System.Drawing.Point(8, 96)
		Me.Label9.TabIndex = 34
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label9.Enabled = True
		Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label9.UseMnemonic = True
		Me.Label9.Visible = True
		Me.Label9.AutoSize = False
		Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label9.Name = "Label9"
		Me.Label10.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me.Label10.Text = "Tipo Linea"
		Me.Label10.ForeColor = System.Drawing.Color.Black
		Me.Label10.Size = New System.Drawing.Size(113, 17)
		Me.Label10.Location = New System.Drawing.Point(8, 24)
		Me.Label10.TabIndex = 33
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label10.Enabled = True
		Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label10.UseMnemonic = True
		Me.Label10.Visible = True
		Me.Label10.AutoSize = False
		Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label10.Name = "Label10"
		Me.Label11.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me.Label11.Text = "M: Datos, L: Linrea Division, E: Linea en Blanco, T: Totales"
		Me.Label11.ForeColor = System.Drawing.Color.FromARGB(0, 128, 128)
		Me.Label11.Size = New System.Drawing.Size(369, 17)
		Me.Label11.Location = New System.Drawing.Point(152, 32)
		Me.Label11.TabIndex = 32
		Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label11.Enabled = True
		Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label11.UseMnemonic = True
		Me.Label11.Visible = True
		Me.Label11.AutoSize = False
		Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label11.Name = "Label11"
		Me.Frameactivo.BackColor = System.Drawing.Color.White
		Me.Frameactivo.Text = "ACTIVO"
		Me.Frameactivo.ForeColor = System.Drawing.Color.Blue
		Me.Frameactivo.Size = New System.Drawing.Size(529, 169)
		Me.Frameactivo.Location = New System.Drawing.Point(16, 96)
		Me.Frameactivo.TabIndex = 15
		Me.Frameactivo.Enabled = True
		Me.Frameactivo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frameactivo.Visible = True
		Me.Frameactivo.Padding = New System.Windows.Forms.Padding(0)
		Me.Frameactivo.Name = "Frameactivo"
		Me.txttipolinea1.AutoSize = False
		Me.txttipolinea1.ForeColor = System.Drawing.Color.Black
		Me.txttipolinea1.Size = New System.Drawing.Size(25, 25)
		Me.txttipolinea1.Location = New System.Drawing.Point(120, 24)
		Me.txttipolinea1.Maxlength = 1
		Me.txttipolinea1.TabIndex = 20
		Me.txttipolinea1.AcceptsReturn = True
		Me.txttipolinea1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txttipolinea1.BackColor = System.Drawing.SystemColors.Window
		Me.txttipolinea1.CausesValidation = True
		Me.txttipolinea1.Enabled = True
		Me.txttipolinea1.HideSelection = True
		Me.txttipolinea1.ReadOnly = False
		Me.txttipolinea1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txttipolinea1.MultiLine = False
		Me.txttipolinea1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txttipolinea1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txttipolinea1.TabStop = True
		Me.txttipolinea1.Visible = True
		Me.txttipolinea1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txttipolinea1.Name = "txttipolinea1"
		Me.txtCtas1.AutoSize = False
		Me.txtCtas1.ForeColor = System.Drawing.Color.Black
		Me.txtCtas1.Size = New System.Drawing.Size(377, 25)
		Me.txtCtas1.Location = New System.Drawing.Point(120, 88)
		Me.txtCtas1.Maxlength = 60
		Me.txtCtas1.TabIndex = 19
		Me.txtCtas1.AcceptsReturn = True
		Me.txtCtas1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtCtas1.BackColor = System.Drawing.SystemColors.Window
		Me.txtCtas1.CausesValidation = True
		Me.txtCtas1.Enabled = True
		Me.txtCtas1.HideSelection = True
		Me.txtCtas1.ReadOnly = False
		Me.txtCtas1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCtas1.MultiLine = False
		Me.txtCtas1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCtas1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCtas1.TabStop = True
		Me.txtCtas1.Visible = True
		Me.txtCtas1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCtas1.Name = "txtCtas1"
		Me.Txtdesc1.AutoSize = False
		Me.Txtdesc1.ForeColor = System.Drawing.Color.Black
		Me.Txtdesc1.Size = New System.Drawing.Size(377, 25)
		Me.Txtdesc1.Location = New System.Drawing.Point(120, 128)
		Me.Txtdesc1.Maxlength = 60
		Me.Txtdesc1.TabIndex = 18
		Me.Txtdesc1.AcceptsReturn = True
		Me.Txtdesc1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Txtdesc1.BackColor = System.Drawing.SystemColors.Window
		Me.Txtdesc1.CausesValidation = True
		Me.Txtdesc1.Enabled = True
		Me.Txtdesc1.HideSelection = True
		Me.Txtdesc1.ReadOnly = False
		Me.Txtdesc1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Txtdesc1.MultiLine = False
		Me.Txtdesc1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Txtdesc1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Txtdesc1.TabStop = True
		Me.Txtdesc1.Visible = True
		Me.Txtdesc1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Txtdesc1.Name = "Txtdesc1"
		Me.ChkN1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.ChkN1.BackColor = System.Drawing.Color.White
		Me.ChkN1.Text = "Acepta Valor Negativo"
		Me.ChkN1.Size = New System.Drawing.Size(121, 25)
		Me.ChkN1.Location = New System.Drawing.Point(8, 56)
		Me.ChkN1.TabIndex = 17
		Me.ChkN1.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.ChkN1.CausesValidation = True
		Me.ChkN1.Enabled = True
		Me.ChkN1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ChkN1.Cursor = System.Windows.Forms.Cursors.Default
		Me.ChkN1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ChkN1.Appearance = System.Windows.Forms.Appearance.Normal
		Me.ChkN1.TabStop = True
		Me.ChkN1.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.ChkN1.Visible = True
		Me.ChkN1.Name = "ChkN1"
		Me.Txtsigno1.AutoSize = False
		Me.Txtsigno1.ForeColor = System.Drawing.Color.Black
		Me.Txtsigno1.Size = New System.Drawing.Size(25, 25)
		Me.Txtsigno1.Location = New System.Drawing.Point(472, 56)
		Me.Txtsigno1.Maxlength = 60
		Me.Txtsigno1.TabIndex = 16
		Me.Txtsigno1.AcceptsReturn = True
		Me.Txtsigno1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Txtsigno1.BackColor = System.Drawing.SystemColors.Window
		Me.Txtsigno1.CausesValidation = True
		Me.Txtsigno1.Enabled = True
		Me.Txtsigno1.HideSelection = True
		Me.Txtsigno1.ReadOnly = False
		Me.Txtsigno1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Txtsigno1.MultiLine = False
		Me.Txtsigno1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Txtsigno1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Txtsigno1.TabStop = True
		Me.Txtsigno1.Visible = True
		Me.Txtsigno1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Txtsigno1.Name = "Txtsigno1"
		Me.Label6.BackColor = System.Drawing.Color.White
		Me.Label6.Text = "M: Datos, L: Linrea Division, E: Linea en Blanco, T: Totales"
		Me.Label6.ForeColor = System.Drawing.Color.FromARGB(0, 128, 128)
		Me.Label6.Size = New System.Drawing.Size(369, 17)
		Me.Label6.Location = New System.Drawing.Point(152, 32)
		Me.Label6.TabIndex = 25
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label6.Enabled = True
		Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label6.UseMnemonic = True
		Me.Label6.Visible = True
		Me.Label6.AutoSize = False
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label6.Name = "Label6"
		Me.Label3.BackColor = System.Drawing.SystemColors.Window
		Me.Label3.Text = "Tipo Linea"
		Me.Label3.ForeColor = System.Drawing.Color.Black
		Me.Label3.Size = New System.Drawing.Size(113, 17)
		Me.Label3.Location = New System.Drawing.Point(8, 24)
		Me.Label3.TabIndex = 24
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label3.Enabled = True
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.Label4.BackColor = System.Drawing.SystemColors.Window
		Me.Label4.Text = "Cuentas Activo"
		Me.Label4.ForeColor = System.Drawing.Color.Black
		Me.Label4.Size = New System.Drawing.Size(113, 17)
		Me.Label4.Location = New System.Drawing.Point(8, 96)
		Me.Label4.TabIndex = 23
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label4.Enabled = True
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.Visible = True
		Me.Label4.AutoSize = False
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.Name = "Label4"
		Me.Label5.BackColor = System.Drawing.SystemColors.Window
		Me.Label5.Text = "Descripcion Linea"
		Me.Label5.ForeColor = System.Drawing.Color.Black
		Me.Label5.Size = New System.Drawing.Size(113, 17)
		Me.Label5.Location = New System.Drawing.Point(8, 128)
		Me.Label5.TabIndex = 22
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label5.Enabled = True
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.UseMnemonic = True
		Me.Label5.Visible = True
		Me.Label5.AutoSize = False
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.Name = "Label5"
		Me.Label1.BackColor = System.Drawing.SystemColors.Window
		Me.Label1.Text = "Signo (+/-) en reporte"
		Me.Label1.ForeColor = System.Drawing.Color.Black
		Me.Label1.Size = New System.Drawing.Size(137, 17)
		Me.Label1.Location = New System.Drawing.Point(328, 56)
		Me.Label1.TabIndex = 21
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.Enabled = True
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.Framelinea.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me.Framelinea.Size = New System.Drawing.Size(529, 57)
		Me.Framelinea.Location = New System.Drawing.Point(16, 24)
		Me.Framelinea.TabIndex = 12
		Me.Framelinea.Enabled = True
		Me.Framelinea.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Framelinea.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Framelinea.Visible = True
		Me.Framelinea.Padding = New System.Windows.Forms.Padding(0)
		Me.Framelinea.Name = "Framelinea"
		Me.ChKDual.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.ChKDual.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me.ChKDual.Text = "Linea en ACTIVO y PASIVO"
		Me.ChKDual.Size = New System.Drawing.Size(201, 25)
		Me.ChKDual.Location = New System.Drawing.Point(288, 16)
		Me.ChKDual.TabIndex = 37
		Me.ChKDual.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.ChKDual.CausesValidation = True
		Me.ChKDual.Enabled = True
		Me.ChKDual.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ChKDual.Cursor = System.Windows.Forms.Cursors.Default
		Me.ChKDual.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ChKDual.Appearance = System.Windows.Forms.Appearance.Normal
		Me.ChKDual.TabStop = True
		Me.ChKDual.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.ChKDual.Visible = True
		Me.ChKDual.Name = "ChKDual"
		Me.txtlinea.AutoSize = False
		Me.txtlinea.Size = New System.Drawing.Size(33, 25)
		Me.txtlinea.Location = New System.Drawing.Point(120, 16)
		Me.txtlinea.Maxlength = 2
		Me.txtlinea.TabIndex = 13
		Me.txtlinea.AcceptsReturn = True
		Me.txtlinea.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtlinea.BackColor = System.Drawing.SystemColors.Window
		Me.txtlinea.CausesValidation = True
		Me.txtlinea.Enabled = True
		Me.txtlinea.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtlinea.HideSelection = True
		Me.txtlinea.ReadOnly = False
		Me.txtlinea.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtlinea.MultiLine = False
		Me.txtlinea.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtlinea.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtlinea.TabStop = True
		Me.txtlinea.Visible = True
		Me.txtlinea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtlinea.Name = "txtlinea"
		Me.Label2.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me.Label2.Text = "Numero Linea        :"
		Me.Label2.Size = New System.Drawing.Size(89, 17)
		Me.Label2.Location = New System.Drawing.Point(16, 24)
		Me.Label2.TabIndex = 14
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.Enabled = True
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.frame5.BackColor = System.Drawing.Color.FromARGB(192, 192, 255)
		Me.frame5.Size = New System.Drawing.Size(553, 433)
		Me.frame5.Location = New System.Drawing.Point(16, 8)
		Me.frame5.TabIndex = 9
		Me.frame5.Visible = False
		Me.frame5.Enabled = True
		Me.frame5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.frame5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.frame5.Padding = New System.Windows.Forms.Padding(0)
		Me.frame5.Name = "frame5"
		DbGrid1.OcxState = CType(resources.GetObject("DbGrid1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.DbGrid1.Size = New System.Drawing.Size(521, 391)
		Me.DbGrid1.Location = New System.Drawing.Point(8, 16)
		Me.DbGrid1.TabIndex = 10
		Me.DbGrid1.Name = "DbGrid1"
		Me.Controls.Add(Frame1)
		Me.Controls.Add(Frame2)
		Me.Controls.Add(Frame3)
		Me.Controls.Add(frame5)
		Me.Frame1.Controls.Add(CmdGrabar)
		Me.Frame1.Controls.Add(Cmdcancelar)
		Me.Frame2.Controls.Add(CmdModificar)
		Me.Frame2.Controls.Add(CmdNuevo)
		Me.Frame2.Controls.Add(Cmdeliminar)
		Me.Frame2.Controls.Add(CmdSalir)
		Me.Frame2.Controls.Add(cmdImprimir)
		Me.Frame3.Controls.Add(Framepasivo)
		Me.Frame3.Controls.Add(Frameactivo)
		Me.Frame3.Controls.Add(Framelinea)
		Me.Framepasivo.Controls.Add(Txtsigno2)
		Me.Framepasivo.Controls.Add(ChkN2)
		Me.Framepasivo.Controls.Add(Txtdesc2)
		Me.Framepasivo.Controls.Add(Txtctas2)
		Me.Framepasivo.Controls.Add(Txttipolinea2)
		Me.Framepasivo.Controls.Add(Label7)
		Me.Framepasivo.Controls.Add(Label8)
		Me.Framepasivo.Controls.Add(Label9)
		Me.Framepasivo.Controls.Add(Label10)
		Me.Framepasivo.Controls.Add(Label11)
		Me.Frameactivo.Controls.Add(txttipolinea1)
		Me.Frameactivo.Controls.Add(txtCtas1)
		Me.Frameactivo.Controls.Add(Txtdesc1)
		Me.Frameactivo.Controls.Add(ChkN1)
		Me.Frameactivo.Controls.Add(Txtsigno1)
		Me.Frameactivo.Controls.Add(Label6)
		Me.Frameactivo.Controls.Add(Label3)
		Me.Frameactivo.Controls.Add(Label4)
		Me.Frameactivo.Controls.Add(Label5)
		Me.Frameactivo.Controls.Add(Label1)
		Me.Framelinea.Controls.Add(ChKDual)
		Me.Framelinea.Controls.Add(txtlinea)
		Me.Framelinea.Controls.Add(Label2)
		Me.frame5.Controls.Add(DbGrid1)
		CType(Me.DbGrid1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame1.ResumeLayout(False)
		Me.Frame2.ResumeLayout(False)
		Me.Frame3.ResumeLayout(False)
		Me.Framepasivo.ResumeLayout(False)
		Me.Frameactivo.ResumeLayout(False)
		Me.Framelinea.ResumeLayout(False)
		Me.frame5.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class