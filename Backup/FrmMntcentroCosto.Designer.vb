<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FrmMntcentroCosto
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
	Public WithEvents Command8 As System.Windows.Forms.Button
	Public WithEvents Command9 As System.Windows.Forms.Button
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
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
	Public WithEvents Check1 As System.Windows.Forms.CheckBox
	Public WithEvents txtclase9 As System.Windows.Forms.TextBox
	Public WithEvents txtnivel As System.Windows.Forms.TextBox
	Public WithEvents txtdescorta As System.Windows.Forms.TextBox
	Public WithEvents txtdescripcion As System.Windows.Forms.TextBox
	Public WithEvents txtcodigo As System.Windows.Forms.TextBox
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents DbGrid1 As AxMSDataGridLib.AxDataGrid
	Public WithEvents CrystalReport1 As AxCrystal.AxCrystalReport
	Public WithEvents mTablaBasica1 As System.Windows.Forms.Panel
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMntcentroCosto))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.mTablaBasica1 = New System.Windows.Forms.Panel
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.Command8 = New System.Windows.Forms.Button
        Me.Command9 = New System.Windows.Forms.Button
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
        Me.Check1 = New System.Windows.Forms.CheckBox
        Me.txtclase9 = New System.Windows.Forms.TextBox
        Me.txtnivel = New System.Windows.Forms.TextBox
        Me.txtdescorta = New System.Windows.Forms.TextBox
        Me.txtdescripcion = New System.Windows.Forms.TextBox
        Me.txtcodigo = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DbGrid1 = New AxMSDataGridLib.AxDataGrid
        Me.CrystalReport1 = New AxCrystal.AxCrystalReport
        Me.mTablaBasica1.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.Frame5.SuspendLayout()
        Me.Frame3.SuspendLayout()
        CType(Me.DbGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mTablaBasica1
        '
        Me.mTablaBasica1.BackColor = System.Drawing.Color.White
        Me.mTablaBasica1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.mTablaBasica1.Controls.Add(Me.Frame1)
        Me.mTablaBasica1.Controls.Add(Me.Frame2)
        Me.mTablaBasica1.Controls.Add(Me.Frame5)
        Me.mTablaBasica1.Controls.Add(Me.Frame3)
        Me.mTablaBasica1.Controls.Add(Me.DbGrid1)
        Me.mTablaBasica1.Controls.Add(Me.CrystalReport1)
        Me.mTablaBasica1.Cursor = System.Windows.Forms.Cursors.Default
        Me.mTablaBasica1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mTablaBasica1.Location = New System.Drawing.Point(24, 24)
        Me.mTablaBasica1.Name = "mTablaBasica1"
        Me.mTablaBasica1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.mTablaBasica1.Size = New System.Drawing.Size(585, 457)
        Me.mTablaBasica1.TabIndex = 0
        Me.mTablaBasica1.TabStop = True
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Frame1.Controls.Add(Me.Command8)
        Me.Frame1.Controls.Add(Me.Command9)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(27, 354)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(512, 71)
        Me.Frame1.TabIndex = 17
        Me.Frame1.TabStop = False
        Me.Frame1.Visible = False
        '
        'Command8
        '
        Me.Command8.BackColor = System.Drawing.SystemColors.Control
        Me.Command8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command8.Image = CType(resources.GetObject("Command8.Image"), System.Drawing.Image)
        Me.Command8.Location = New System.Drawing.Point(120, 16)
        Me.Command8.Name = "Command8"
        Me.Command8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command8.Size = New System.Drawing.Size(52, 45)
        Me.Command8.TabIndex = 19
        Me.Command8.Text = "&Grabar"
        Me.Command8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Command8.UseVisualStyleBackColor = False
        '
        'Command9
        '
        Me.Command9.BackColor = System.Drawing.SystemColors.Control
        Me.Command9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command9.Image = CType(resources.GetObject("Command9.Image"), System.Drawing.Image)
        Me.Command9.Location = New System.Drawing.Point(264, 16)
        Me.Command9.Name = "Command9"
        Me.Command9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command9.Size = New System.Drawing.Size(52, 45)
        Me.Command9.TabIndex = 18
        Me.Command9.Text = "&Cancelar"
        Me.Command9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Command9.UseVisualStyleBackColor = False
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.Command2)
        Me.Frame2.Controls.Add(Me.Command1)
        Me.Frame2.Controls.Add(Me.Command3)
        Me.Frame2.Controls.Add(Me.Command7)
        Me.Frame2.Controls.Add(Me.command5)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(19, 353)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(521, 81)
        Me.Frame2.TabIndex = 11
        Me.Frame2.TabStop = False
        '
        'Command2
        '
        Me.Command2.BackColor = System.Drawing.SystemColors.Control
        Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command2.Image = CType(resources.GetObject("Command2.Image"), System.Drawing.Image)
        Me.Command2.Location = New System.Drawing.Point(136, 16)
        Me.Command2.Name = "Command2"
        Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command2.Size = New System.Drawing.Size(52, 45)
        Me.Command2.TabIndex = 16
        Me.Command2.Text = "&Modificar"
        Me.Command2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Command2.UseVisualStyleBackColor = False
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Image = CType(resources.GetObject("Command1.Image"), System.Drawing.Image)
        Me.Command1.Location = New System.Drawing.Point(32, 16)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(52, 45)
        Me.Command1.TabIndex = 15
        Me.Command1.Text = "&Ingreso"
        Me.Command1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Command1.UseVisualStyleBackColor = False
        '
        'Command3
        '
        Me.Command3.BackColor = System.Drawing.SystemColors.Control
        Me.Command3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command3.Image = CType(resources.GetObject("Command3.Image"), System.Drawing.Image)
        Me.Command3.Location = New System.Drawing.Point(232, 16)
        Me.Command3.Name = "Command3"
        Me.Command3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command3.Size = New System.Drawing.Size(52, 45)
        Me.Command3.TabIndex = 14
        Me.Command3.Text = "&Eliminar"
        Me.Command3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Command3.UseVisualStyleBackColor = False
        '
        'Command7
        '
        Me.Command7.BackColor = System.Drawing.SystemColors.Control
        Me.Command7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command7.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Command7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command7.Image = CType(resources.GetObject("Command7.Image"), System.Drawing.Image)
        Me.Command7.Location = New System.Drawing.Point(440, 17)
        Me.Command7.Name = "Command7"
        Me.Command7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command7.Size = New System.Drawing.Size(52, 45)
        Me.Command7.TabIndex = 13
        Me.Command7.Text = "&Salir"
        Me.Command7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Command7.UseVisualStyleBackColor = False
        '
        'command5
        '
        Me.command5.BackColor = System.Drawing.SystemColors.Control
        Me.command5.Cursor = System.Windows.Forms.Cursors.Default
        Me.command5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.command5.Image = CType(resources.GetObject("command5.Image"), System.Drawing.Image)
        Me.command5.Location = New System.Drawing.Point(328, 16)
        Me.command5.Name = "command5"
        Me.command5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.command5.Size = New System.Drawing.Size(52, 45)
        Me.command5.TabIndex = 12
        Me.command5.Text = "&Reporte"
        Me.command5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.command5.UseVisualStyleBackColor = False
        '
        'Frame5
        '
        Me.Frame5.BackColor = System.Drawing.SystemColors.Control
        Me.Frame5.Controls.Add(Me.CmbOrden)
        Me.Frame5.Controls.Add(Me.TxFiltro)
        Me.Frame5.Controls.Add(Me.Label33)
        Me.Frame5.Controls.Add(Me.Label32)
        Me.Frame5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame5.Location = New System.Drawing.Point(16, 8)
        Me.Frame5.Name = "Frame5"
        Me.Frame5.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame5.Size = New System.Drawing.Size(529, 49)
        Me.Frame5.TabIndex = 6
        Me.Frame5.TabStop = False
        '
        'CmbOrden
        '
        Me.CmbOrden.BackColor = System.Drawing.SystemColors.Window
        Me.CmbOrden.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmbOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbOrden.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CmbOrden.Items.AddRange(New Object() {"    CODIGO", "DESCRIPCION"})
        Me.CmbOrden.Location = New System.Drawing.Point(336, 16)
        Me.CmbOrden.Name = "CmbOrden"
        Me.CmbOrden.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmbOrden.Size = New System.Drawing.Size(105, 21)
        Me.CmbOrden.TabIndex = 8
        '
        'TxFiltro
        '
        Me.TxFiltro.AcceptsReturn = True
        Me.TxFiltro.BackColor = System.Drawing.SystemColors.Window
        Me.TxFiltro.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxFiltro.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxFiltro.Location = New System.Drawing.Point(80, 16)
        Me.TxFiltro.MaxLength = 45
        Me.TxFiltro.Name = "TxFiltro"
        Me.TxFiltro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxFiltro.Size = New System.Drawing.Size(177, 20)
        Me.TxFiltro.TabIndex = 7
        Me.TxFiltro.Text = "TxFiltro"
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.SystemColors.Control
        Me.Label33.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label33.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label33.Location = New System.Drawing.Point(288, 16)
        Me.Label33.Name = "Label33"
        Me.Label33.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label33.Size = New System.Drawing.Size(41, 17)
        Me.Label33.TabIndex = 10
        Me.Label33.Text = "Orden :"
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.SystemColors.Control
        Me.Label32.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label32.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label32.Location = New System.Drawing.Point(16, 16)
        Me.Label32.Name = "Label32"
        Me.Label32.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label32.Size = New System.Drawing.Size(49, 17)
        Me.Label32.TabIndex = 9
        Me.Label32.Text = "Buscar  :"
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame3.Controls.Add(Me.Check1)
        Me.Frame3.Controls.Add(Me.txtclase9)
        Me.Frame3.Controls.Add(Me.txtnivel)
        Me.Frame3.Controls.Add(Me.txtdescorta)
        Me.Frame3.Controls.Add(Me.txtdescripcion)
        Me.Frame3.Controls.Add(Me.txtcodigo)
        Me.Frame3.Controls.Add(Me.Label5)
        Me.Frame3.Controls.Add(Me.Label4)
        Me.Frame3.Controls.Add(Me.Label1)
        Me.Frame3.Controls.Add(Me.Label3)
        Me.Frame3.Controls.Add(Me.Label2)
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(35, 56)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(489, 256)
        Me.Frame3.TabIndex = 1
        Me.Frame3.TabStop = False
        Me.Frame3.Visible = False
        '
        'Check1
        '
        Me.Check1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Check1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Check1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Check1.Location = New System.Drawing.Point(24, 208)
        Me.Check1.Name = "Check1"
        Me.Check1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Check1.Size = New System.Drawing.Size(137, 25)
        Me.Check1.TabIndex = 27
        Me.Check1.Text = "Estado  ANULADO"
        Me.Check1.UseVisualStyleBackColor = False
        '
        'txtclase9
        '
        Me.txtclase9.AcceptsReturn = True
        Me.txtclase9.BackColor = System.Drawing.SystemColors.Window
        Me.txtclase9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtclase9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtclase9.Location = New System.Drawing.Point(152, 176)
        Me.txtclase9.MaxLength = 20
        Me.txtclase9.Name = "txtclase9"
        Me.txtclase9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtclase9.Size = New System.Drawing.Size(233, 25)
        Me.txtclase9.TabIndex = 25
        '
        'txtnivel
        '
        Me.txtnivel.AcceptsReturn = True
        Me.txtnivel.BackColor = System.Drawing.SystemColors.Window
        Me.txtnivel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnivel.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtnivel.Location = New System.Drawing.Point(152, 144)
        Me.txtnivel.MaxLength = 2
        Me.txtnivel.Name = "txtnivel"
        Me.txtnivel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtnivel.Size = New System.Drawing.Size(233, 25)
        Me.txtnivel.TabIndex = 23
        '
        'txtdescorta
        '
        Me.txtdescorta.AcceptsReturn = True
        Me.txtdescorta.BackColor = System.Drawing.SystemColors.Window
        Me.txtdescorta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdescorta.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtdescorta.Location = New System.Drawing.Point(152, 112)
        Me.txtdescorta.MaxLength = 15
        Me.txtdescorta.Name = "txtdescorta"
        Me.txtdescorta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtdescorta.Size = New System.Drawing.Size(233, 25)
        Me.txtdescorta.TabIndex = 21
        '
        'txtdescripcion
        '
        Me.txtdescripcion.AcceptsReturn = True
        Me.txtdescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtdescripcion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdescripcion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtdescripcion.Location = New System.Drawing.Point(152, 80)
        Me.txtdescripcion.MaxLength = 30
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtdescripcion.Size = New System.Drawing.Size(313, 25)
        Me.txtdescripcion.TabIndex = 3
        '
        'txtcodigo
        '
        Me.txtcodigo.AcceptsReturn = True
        Me.txtcodigo.BackColor = System.Drawing.SystemColors.Window
        Me.txtcodigo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcodigo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtcodigo.Location = New System.Drawing.Point(152, 48)
        Me.txtcodigo.MaxLength = 10
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtcodigo.Size = New System.Drawing.Size(89, 25)
        Me.txtcodigo.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(32, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(113, 17)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Cuenta Clase 9"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(32, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(113, 17)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Nivel de C.costo"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(32, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(113, 17)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Descripción Corta:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(32, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(113, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Descripción     :"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(32, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(121, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Código             :"
        '
        'DbGrid1
        '
        Me.DbGrid1.DataSource = Nothing
        Me.DbGrid1.Location = New System.Drawing.Point(19, 64)
        Me.DbGrid1.Name = "DbGrid1"
        Me.DbGrid1.OcxState = CType(resources.GetObject("DbGrid1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.DbGrid1.Size = New System.Drawing.Size(529, 271)
        Me.DbGrid1.TabIndex = 20
        '
        'CrystalReport1
        '
        Me.CrystalReport1.Enabled = True
        Me.CrystalReport1.Location = New System.Drawing.Point(455, 32)
        Me.CrystalReport1.Name = "CrystalReport1"
        Me.CrystalReport1.OcxState = CType(resources.GetObject("CrystalReport1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CrystalReport1.Size = New System.Drawing.Size(28, 28)
        Me.CrystalReport1.TabIndex = 21
        '
        'FrmMntcentroCosto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.Command7
        Me.ClientSize = New System.Drawing.Size(635, 507)
        Me.Controls.Add(Me.mTablaBasica1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(8, 31)
        Me.Name = "FrmMntcentroCosto"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tabla Centro de Costos"
        Me.mTablaBasica1.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        Me.Frame5.ResumeLayout(False)
        Me.Frame3.ResumeLayout(False)
        CType(Me.DbGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class