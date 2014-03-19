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
    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMntEstructuraBalance))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.CmdGrabar = New System.Windows.Forms.Button()
        Me.Cmdcancelar = New System.Windows.Forms.Button()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.CmdModificar = New System.Windows.Forms.Button()
        Me.CmdNuevo = New System.Windows.Forms.Button()
        Me.Cmdeliminar = New System.Windows.Forms.Button()
        Me.CmdSalir = New System.Windows.Forms.Button()
        Me.cmdImprimir = New System.Windows.Forms.Button()
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me.Framepasivo = New System.Windows.Forms.GroupBox()
        Me.Txtsigno2 = New System.Windows.Forms.TextBox()
        Me.ChkN2 = New System.Windows.Forms.CheckBox()
        Me.Txtdesc2 = New System.Windows.Forms.TextBox()
        Me.Txtctas2 = New System.Windows.Forms.TextBox()
        Me.Txttipolinea2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Frameactivo = New System.Windows.Forms.GroupBox()
        Me.txttipolinea1 = New System.Windows.Forms.TextBox()
        Me.txtCtas1 = New System.Windows.Forms.TextBox()
        Me.Txtdesc1 = New System.Windows.Forms.TextBox()
        Me.ChkN1 = New System.Windows.Forms.CheckBox()
        Me.Txtsigno1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Framelinea = New System.Windows.Forms.GroupBox()
        Me.ChKDual = New System.Windows.Forms.CheckBox()
        Me.txtlinea = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DbGrid1 = New AxMSDataGridLib.AxDataGrid()
        Me.frame5 = New System.Windows.Forms.GroupBox()
        Me.Frame1.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.Frame3.SuspendLayout()
        Me.Framepasivo.SuspendLayout()
        Me.Frameactivo.SuspendLayout()
        Me.Framelinea.SuspendLayout()
        CType(Me.DbGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frame5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Frame1.Controls.Add(Me.CmdGrabar)
        Me.Frame1.Controls.Add(Me.Cmdcancelar)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(8, 458)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(560, 71)
        Me.Frame1.TabIndex = 6
        Me.Frame1.TabStop = False
        Me.Frame1.Visible = False
        '
        'CmdGrabar
        '
        Me.CmdGrabar.BackColor = System.Drawing.SystemColors.Control
        Me.CmdGrabar.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdGrabar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdGrabar.Image = CType(resources.GetObject("CmdGrabar.Image"), System.Drawing.Image)
        Me.CmdGrabar.Location = New System.Drawing.Point(120, 14)
        Me.CmdGrabar.Name = "CmdGrabar"
        Me.CmdGrabar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdGrabar.Size = New System.Drawing.Size(61, 55)
        Me.CmdGrabar.TabIndex = 8
        Me.CmdGrabar.Text = "&Grabar"
        Me.CmdGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdGrabar.UseVisualStyleBackColor = False
        '
        'Cmdcancelar
        '
        Me.Cmdcancelar.BackColor = System.Drawing.SystemColors.Control
        Me.Cmdcancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmdcancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmdcancelar.Image = CType(resources.GetObject("Cmdcancelar.Image"), System.Drawing.Image)
        Me.Cmdcancelar.Location = New System.Drawing.Point(264, 14)
        Me.Cmdcancelar.Name = "Cmdcancelar"
        Me.Cmdcancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmdcancelar.Size = New System.Drawing.Size(61, 55)
        Me.Cmdcancelar.TabIndex = 7
        Me.Cmdcancelar.Text = "&Cancelar"
        Me.Cmdcancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmdcancelar.UseVisualStyleBackColor = False
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Frame2.Controls.Add(Me.CmdModificar)
        Me.Frame2.Controls.Add(Me.CmdNuevo)
        Me.Frame2.Controls.Add(Me.Cmdeliminar)
        Me.Frame2.Controls.Add(Me.CmdSalir)
        Me.Frame2.Controls.Add(Me.cmdImprimir)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(16, 464)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(553, 73)
        Me.Frame2.TabIndex = 0
        Me.Frame2.TabStop = False
        '
        'CmdModificar
        '
        Me.CmdModificar.BackColor = System.Drawing.SystemColors.Control
        Me.CmdModificar.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdModificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdModificar.Image = CType(resources.GetObject("CmdModificar.Image"), System.Drawing.Image)
        Me.CmdModificar.Location = New System.Drawing.Point(136, 16)
        Me.CmdModificar.Name = "CmdModificar"
        Me.CmdModificar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdModificar.Size = New System.Drawing.Size(61, 49)
        Me.CmdModificar.TabIndex = 5
        Me.CmdModificar.Text = "&Modificar"
        Me.CmdModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdModificar.UseVisualStyleBackColor = False
        '
        'CmdNuevo
        '
        Me.CmdNuevo.BackColor = System.Drawing.SystemColors.Control
        Me.CmdNuevo.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdNuevo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdNuevo.Image = CType(resources.GetObject("CmdNuevo.Image"), System.Drawing.Image)
        Me.CmdNuevo.Location = New System.Drawing.Point(32, 16)
        Me.CmdNuevo.Name = "CmdNuevo"
        Me.CmdNuevo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdNuevo.Size = New System.Drawing.Size(61, 49)
        Me.CmdNuevo.TabIndex = 4
        Me.CmdNuevo.Text = "&Ingreso"
        Me.CmdNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdNuevo.UseVisualStyleBackColor = False
        '
        'Cmdeliminar
        '
        Me.Cmdeliminar.BackColor = System.Drawing.SystemColors.Control
        Me.Cmdeliminar.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmdeliminar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmdeliminar.Image = CType(resources.GetObject("Cmdeliminar.Image"), System.Drawing.Image)
        Me.Cmdeliminar.Location = New System.Drawing.Point(232, 16)
        Me.Cmdeliminar.Name = "Cmdeliminar"
        Me.Cmdeliminar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmdeliminar.Size = New System.Drawing.Size(61, 49)
        Me.Cmdeliminar.TabIndex = 3
        Me.Cmdeliminar.Text = "&Eliminar"
        Me.Cmdeliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmdeliminar.UseVisualStyleBackColor = False
        '
        'CmdSalir
        '
        Me.CmdSalir.BackColor = System.Drawing.SystemColors.Control
        Me.CmdSalir.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdSalir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdSalir.Image = CType(resources.GetObject("CmdSalir.Image"), System.Drawing.Image)
        Me.CmdSalir.Location = New System.Drawing.Point(440, 16)
        Me.CmdSalir.Name = "CmdSalir"
        Me.CmdSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdSalir.Size = New System.Drawing.Size(61, 49)
        Me.CmdSalir.TabIndex = 2
        Me.CmdSalir.Text = "&Salir"
        Me.CmdSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdSalir.UseVisualStyleBackColor = False
        '
        'cmdImprimir
        '
        Me.cmdImprimir.BackColor = System.Drawing.SystemColors.Control
        Me.cmdImprimir.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdImprimir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.Location = New System.Drawing.Point(328, 16)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdImprimir.Size = New System.Drawing.Size(61, 49)
        Me.cmdImprimir.TabIndex = 1
        Me.cmdImprimir.Text = "&Reporte"
        Me.cmdImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdImprimir.UseVisualStyleBackColor = False
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.Add(Me.Framepasivo)
        Me.Frame3.Controls.Add(Me.Frameactivo)
        Me.Frame3.Controls.Add(Me.Framelinea)
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(8, 0)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(569, 457)
        Me.Frame3.TabIndex = 11
        Me.Frame3.TabStop = False
        '
        'Framepasivo
        '
        Me.Framepasivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Framepasivo.Controls.Add(Me.Txtsigno2)
        Me.Framepasivo.Controls.Add(Me.ChkN2)
        Me.Framepasivo.Controls.Add(Me.Txtdesc2)
        Me.Framepasivo.Controls.Add(Me.Txtctas2)
        Me.Framepasivo.Controls.Add(Me.Txttipolinea2)
        Me.Framepasivo.Controls.Add(Me.Label7)
        Me.Framepasivo.Controls.Add(Me.Label8)
        Me.Framepasivo.Controls.Add(Me.Label9)
        Me.Framepasivo.Controls.Add(Me.Label10)
        Me.Framepasivo.Controls.Add(Me.Label11)
        Me.Framepasivo.ForeColor = System.Drawing.Color.Blue
        Me.Framepasivo.Location = New System.Drawing.Point(8, 272)
        Me.Framepasivo.Name = "Framepasivo"
        Me.Framepasivo.Padding = New System.Windows.Forms.Padding(0)
        Me.Framepasivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Framepasivo.Size = New System.Drawing.Size(537, 169)
        Me.Framepasivo.TabIndex = 26
        Me.Framepasivo.TabStop = False
        Me.Framepasivo.Text = "PASIVO"
        '
        'Txtsigno2
        '
        Me.Txtsigno2.AcceptsReturn = True
        Me.Txtsigno2.BackColor = System.Drawing.SystemColors.Window
        Me.Txtsigno2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txtsigno2.ForeColor = System.Drawing.Color.Black
        Me.Txtsigno2.Location = New System.Drawing.Point(472, 56)
        Me.Txtsigno2.MaxLength = 60
        Me.Txtsigno2.Name = "Txtsigno2"
        Me.Txtsigno2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txtsigno2.Size = New System.Drawing.Size(25, 20)
        Me.Txtsigno2.TabIndex = 31
        '
        'ChkN2
        '
        Me.ChkN2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkN2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkN2.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkN2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkN2.Location = New System.Drawing.Point(8, 56)
        Me.ChkN2.Name = "ChkN2"
        Me.ChkN2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkN2.Size = New System.Drawing.Size(121, 25)
        Me.ChkN2.TabIndex = 30
        Me.ChkN2.Text = "Acepta Valor Negativo"
        Me.ChkN2.UseVisualStyleBackColor = False
        '
        'Txtdesc2
        '
        Me.Txtdesc2.AcceptsReturn = True
        Me.Txtdesc2.BackColor = System.Drawing.SystemColors.Window
        Me.Txtdesc2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txtdesc2.ForeColor = System.Drawing.Color.Black
        Me.Txtdesc2.Location = New System.Drawing.Point(120, 128)
        Me.Txtdesc2.MaxLength = 60
        Me.Txtdesc2.Name = "Txtdesc2"
        Me.Txtdesc2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txtdesc2.Size = New System.Drawing.Size(377, 20)
        Me.Txtdesc2.TabIndex = 29
        '
        'Txtctas2
        '
        Me.Txtctas2.AcceptsReturn = True
        Me.Txtctas2.BackColor = System.Drawing.SystemColors.Window
        Me.Txtctas2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txtctas2.ForeColor = System.Drawing.Color.Black
        Me.Txtctas2.Location = New System.Drawing.Point(120, 88)
        Me.Txtctas2.MaxLength = 60
        Me.Txtctas2.Name = "Txtctas2"
        Me.Txtctas2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txtctas2.Size = New System.Drawing.Size(377, 20)
        Me.Txtctas2.TabIndex = 28
        '
        'Txttipolinea2
        '
        Me.Txttipolinea2.AcceptsReturn = True
        Me.Txttipolinea2.BackColor = System.Drawing.SystemColors.Window
        Me.Txttipolinea2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txttipolinea2.ForeColor = System.Drawing.Color.Black
        Me.Txttipolinea2.Location = New System.Drawing.Point(120, 24)
        Me.Txttipolinea2.MaxLength = 1
        Me.Txttipolinea2.Name = "Txttipolinea2"
        Me.Txttipolinea2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txttipolinea2.Size = New System.Drawing.Size(25, 20)
        Me.Txttipolinea2.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Window
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(328, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(137, 17)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Signo (+/-) en reporte"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(8, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(113, 17)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Descripcion Linea"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(8, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(113, 17)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Cuentas Activo"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(8, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(113, 17)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Tipo Linea"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(152, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(369, 17)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "M: Datos, L: Linrea Division, E: Linea en Blanco, T: Totales"
        '
        'Frameactivo
        '
        Me.Frameactivo.BackColor = System.Drawing.Color.White
        Me.Frameactivo.Controls.Add(Me.txttipolinea1)
        Me.Frameactivo.Controls.Add(Me.txtCtas1)
        Me.Frameactivo.Controls.Add(Me.Txtdesc1)
        Me.Frameactivo.Controls.Add(Me.ChkN1)
        Me.Frameactivo.Controls.Add(Me.Txtsigno1)
        Me.Frameactivo.Controls.Add(Me.Label6)
        Me.Frameactivo.Controls.Add(Me.Label3)
        Me.Frameactivo.Controls.Add(Me.Label4)
        Me.Frameactivo.Controls.Add(Me.Label5)
        Me.Frameactivo.Controls.Add(Me.Label1)
        Me.Frameactivo.ForeColor = System.Drawing.Color.Blue
        Me.Frameactivo.Location = New System.Drawing.Point(16, 96)
        Me.Frameactivo.Name = "Frameactivo"
        Me.Frameactivo.Padding = New System.Windows.Forms.Padding(0)
        Me.Frameactivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frameactivo.Size = New System.Drawing.Size(529, 169)
        Me.Frameactivo.TabIndex = 15
        Me.Frameactivo.TabStop = False
        Me.Frameactivo.Text = "ACTIVO"
        '
        'txttipolinea1
        '
        Me.txttipolinea1.AcceptsReturn = True
        Me.txttipolinea1.BackColor = System.Drawing.SystemColors.Window
        Me.txttipolinea1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txttipolinea1.ForeColor = System.Drawing.Color.Black
        Me.txttipolinea1.Location = New System.Drawing.Point(120, 24)
        Me.txttipolinea1.MaxLength = 1
        Me.txttipolinea1.Name = "txttipolinea1"
        Me.txttipolinea1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txttipolinea1.Size = New System.Drawing.Size(25, 20)
        Me.txttipolinea1.TabIndex = 20
        '
        'txtCtas1
        '
        Me.txtCtas1.AcceptsReturn = True
        Me.txtCtas1.BackColor = System.Drawing.SystemColors.Window
        Me.txtCtas1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCtas1.ForeColor = System.Drawing.Color.Black
        Me.txtCtas1.Location = New System.Drawing.Point(120, 88)
        Me.txtCtas1.MaxLength = 60
        Me.txtCtas1.Name = "txtCtas1"
        Me.txtCtas1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCtas1.Size = New System.Drawing.Size(377, 20)
        Me.txtCtas1.TabIndex = 19
        '
        'Txtdesc1
        '
        Me.Txtdesc1.AcceptsReturn = True
        Me.Txtdesc1.BackColor = System.Drawing.SystemColors.Window
        Me.Txtdesc1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txtdesc1.ForeColor = System.Drawing.Color.Black
        Me.Txtdesc1.Location = New System.Drawing.Point(120, 128)
        Me.Txtdesc1.MaxLength = 60
        Me.Txtdesc1.Name = "Txtdesc1"
        Me.Txtdesc1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txtdesc1.Size = New System.Drawing.Size(377, 20)
        Me.Txtdesc1.TabIndex = 18
        '
        'ChkN1
        '
        Me.ChkN1.BackColor = System.Drawing.Color.White
        Me.ChkN1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkN1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkN1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkN1.Location = New System.Drawing.Point(8, 56)
        Me.ChkN1.Name = "ChkN1"
        Me.ChkN1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkN1.Size = New System.Drawing.Size(121, 25)
        Me.ChkN1.TabIndex = 17
        Me.ChkN1.Text = "Acepta Valor Negativo"
        Me.ChkN1.UseVisualStyleBackColor = False
        '
        'Txtsigno1
        '
        Me.Txtsigno1.AcceptsReturn = True
        Me.Txtsigno1.BackColor = System.Drawing.SystemColors.Window
        Me.Txtsigno1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txtsigno1.ForeColor = System.Drawing.Color.Black
        Me.Txtsigno1.Location = New System.Drawing.Point(472, 56)
        Me.Txtsigno1.MaxLength = 60
        Me.Txtsigno1.Name = "Txtsigno1"
        Me.Txtsigno1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txtsigno1.Size = New System.Drawing.Size(25, 20)
        Me.Txtsigno1.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(152, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(369, 17)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "M: Datos, L: Linrea Division, E: Linea en Blanco, T: Totales"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(8, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(113, 17)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Tipo Linea"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(8, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(113, 17)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Cuentas Activo"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(8, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(113, 17)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Descripcion Linea"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(328, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(137, 17)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Signo (+/-) en reporte"
        '
        'Framelinea
        '
        Me.Framelinea.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Framelinea.Controls.Add(Me.ChKDual)
        Me.Framelinea.Controls.Add(Me.txtlinea)
        Me.Framelinea.Controls.Add(Me.Label2)
        Me.Framelinea.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Framelinea.Location = New System.Drawing.Point(16, 24)
        Me.Framelinea.Name = "Framelinea"
        Me.Framelinea.Padding = New System.Windows.Forms.Padding(0)
        Me.Framelinea.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Framelinea.Size = New System.Drawing.Size(529, 57)
        Me.Framelinea.TabIndex = 12
        Me.Framelinea.TabStop = False
        '
        'ChKDual
        '
        Me.ChKDual.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChKDual.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChKDual.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChKDual.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChKDual.Location = New System.Drawing.Point(288, 16)
        Me.ChKDual.Name = "ChKDual"
        Me.ChKDual.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChKDual.Size = New System.Drawing.Size(201, 25)
        Me.ChKDual.TabIndex = 37
        Me.ChKDual.Text = "Linea en ACTIVO y PASIVO"
        Me.ChKDual.UseVisualStyleBackColor = False
        '
        'txtlinea
        '
        Me.txtlinea.AcceptsReturn = True
        Me.txtlinea.BackColor = System.Drawing.SystemColors.Window
        Me.txtlinea.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtlinea.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtlinea.Location = New System.Drawing.Point(120, 16)
        Me.txtlinea.MaxLength = 2
        Me.txtlinea.Name = "txtlinea"
        Me.txtlinea.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtlinea.Size = New System.Drawing.Size(33, 20)
        Me.txtlinea.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(16, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(89, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Numero Linea        :"
        '
        'DbGrid1
        '
        Me.DbGrid1.DataSource = Nothing
        Me.DbGrid1.Location = New System.Drawing.Point(8, 16)
        Me.DbGrid1.Name = "DbGrid1"
        Me.DbGrid1.OcxState = CType(resources.GetObject("DbGrid1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.DbGrid1.Size = New System.Drawing.Size(521, 391)
        Me.DbGrid1.TabIndex = 10
        '
        'frame5
        '
        Me.frame5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.frame5.Controls.Add(Me.DbGrid1)
        Me.frame5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frame5.Location = New System.Drawing.Point(16, 8)
        Me.frame5.Name = "frame5"
        Me.frame5.Padding = New System.Windows.Forms.Padding(0)
        Me.frame5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frame5.Size = New System.Drawing.Size(553, 433)
        Me.frame5.TabIndex = 9
        Me.frame5.TabStop = False
        Me.frame5.Visible = False
        '
        'FrmMntEstructuraBalance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.CmdSalir
        Me.ClientSize = New System.Drawing.Size(611, 546)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.frame5)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.ForeColor = System.Drawing.Color.Red
        Me.Location = New System.Drawing.Point(8, 31)
        Me.Name = "FrmMntEstructuraBalance"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estructura del Balance General"
        Me.Frame1.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        Me.Frame3.ResumeLayout(False)
        Me.Framepasivo.ResumeLayout(False)
        Me.Framepasivo.PerformLayout()
        Me.Frameactivo.ResumeLayout(False)
        Me.Frameactivo.PerformLayout()
        Me.Framelinea.ResumeLayout(False)
        Me.Framelinea.PerformLayout()
        CType(Me.DbGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frame5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents DbGrid1 As AxMSDataGridLib.AxDataGrid
    Public WithEvents frame5 As System.Windows.Forms.GroupBox
#End Region 
End Class