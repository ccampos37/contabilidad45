<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmlogin
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
	Public WithEvents CmdAceptar As System.Windows.Forms.Button
	Public WithEvents CmdCancelar As System.Windows.Forms.Button
	Public WithEvents Combo1 As System.Windows.Forms.ComboBox
	Public WithEvents Combo2 As System.Windows.Forms.ComboBox
	Public WithEvents DTPfecha As AxMSComCtl2.AxDTPicker
	Public WithEvents TxUser As AxTextFer.AxTxFer
	Public WithEvents TxPwd As AxTextFer.AxTxFer
	Public WithEvents Lbgrupo As System.Windows.Forms.Label
	Public WithEvents Lbempresa As System.Windows.Forms.Label
	Public WithEvents _Label1_0 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents _Frame1_0 As System.Windows.Forms.GroupBox
	Public WithEvents Image1 As System.Windows.Forms.PictureBox
	Public WithEvents _Frame1_1 As System.Windows.Forms.GroupBox
	Public WithEvents Frame3 As System.Windows.Forms.Panel
	Public WithEvents cmdGenerar As System.Windows.Forms.Button
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents framaño As System.Windows.Forms.Panel
	Public WithEvents ImgList2 As System.Windows.Forms.ImageList
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Frame1 As Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray
	Public WithEvents Label1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmlogin))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me._Frame1_1 = New System.Windows.Forms.GroupBox
        Me._Frame1_0 = New System.Windows.Forms.GroupBox
        Me.CmdAceptar = New System.Windows.Forms.Button
        Me.CmdCancelar = New System.Windows.Forms.Button
        Me.Combo1 = New System.Windows.Forms.ComboBox
        Me.Combo2 = New System.Windows.Forms.ComboBox
        Me.DTPfecha = New AxMSComCtl2.AxDTPicker
        Me.TxUser = New AxTextFer.AxTxFer
        Me.TxPwd = New AxTextFer.AxTxFer
        Me.Lbgrupo = New System.Windows.Forms.Label
        Me.Lbempresa = New System.Windows.Forms.Label
        Me._Label1_0 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Image1 = New System.Windows.Forms.PictureBox
        Me.Frame3 = New System.Windows.Forms.Panel
        Me.framaño = New System.Windows.Forms.Panel
        Me.cmdGenerar = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.ImgList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Frame1 = New Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray(Me.components)
        Me.Label1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me._Frame1_1.SuspendLayout()
        Me._Frame1_0.SuspendLayout()
        CType(Me.DTPfecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxPwd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.framaño.SuspendLayout()
        CType(Me.Frame1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_Frame1_1
        '
        Me._Frame1_1.BackColor = System.Drawing.Color.White
        Me._Frame1_1.Controls.Add(Me._Frame1_0)
        Me._Frame1_1.Controls.Add(Me.Image1)
        Me._Frame1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.SetIndex(Me._Frame1_1, CType(1, Short))
        Me._Frame1_1.Location = New System.Drawing.Point(8, 8)
        Me._Frame1_1.Name = "_Frame1_1"
        Me._Frame1_1.Padding = New System.Windows.Forms.Padding(0)
        Me._Frame1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Frame1_1.Size = New System.Drawing.Size(569, 297)
        Me._Frame1_1.TabIndex = 13
        Me._Frame1_1.TabStop = False
        '
        '_Frame1_0
        '
        Me._Frame1_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._Frame1_0.Controls.Add(Me.CmdAceptar)
        Me._Frame1_0.Controls.Add(Me.CmdCancelar)
        Me._Frame1_0.Controls.Add(Me.Combo1)
        Me._Frame1_0.Controls.Add(Me.Combo2)
        Me._Frame1_0.Controls.Add(Me.DTPfecha)
        Me._Frame1_0.Controls.Add(Me.TxUser)
        Me._Frame1_0.Controls.Add(Me.TxPwd)
        Me._Frame1_0.Controls.Add(Me.Lbgrupo)
        Me._Frame1_0.Controls.Add(Me.Lbempresa)
        Me._Frame1_0.Controls.Add(Me._Label1_0)
        Me._Frame1_0.Controls.Add(Me.Label3)
        Me._Frame1_0.Controls.Add(Me.Label4)
        Me._Frame1_0.ForeColor = System.Drawing.Color.Red
        Me.Frame1.SetIndex(Me._Frame1_0, CType(0, Short))
        Me._Frame1_0.Location = New System.Drawing.Point(296, 24)
        Me._Frame1_0.Name = "_Frame1_0"
        Me._Frame1_0.Padding = New System.Windows.Forms.Padding(0)
        Me._Frame1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Frame1_0.Size = New System.Drawing.Size(262, 258)
        Me._Frame1_0.TabIndex = 14
        Me._Frame1_0.TabStop = False
        '
        'CmdAceptar
        '
        Me.CmdAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdAceptar.Location = New System.Drawing.Point(40, 168)
        Me.CmdAceptar.Name = "CmdAceptar"
        Me.CmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdAceptar.Size = New System.Drawing.Size(81, 71)
        Me.CmdAceptar.TabIndex = 6
        Me.CmdAceptar.Text = "&Aceptar"
        Me.CmdAceptar.UseVisualStyleBackColor = False
        '
        'CmdCancelar
        '
        Me.CmdCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdCancelar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdCancelar.Location = New System.Drawing.Point(161, 168)
        Me.CmdCancelar.Name = "CmdCancelar"
        Me.CmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdCancelar.Size = New System.Drawing.Size(81, 71)
        Me.CmdCancelar.TabIndex = 7
        Me.CmdCancelar.Text = "&Salir"
        Me.CmdCancelar.UseVisualStyleBackColor = False
        '
        'Combo1
        '
        Me.Combo1.BackColor = System.Drawing.SystemColors.Window
        Me.Combo1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Combo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Combo1.Location = New System.Drawing.Point(74, 16)
        Me.Combo1.Name = "Combo1"
        Me.Combo1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Combo1.Size = New System.Drawing.Size(177, 21)
        Me.Combo1.TabIndex = 1
        '
        'Combo2
        '
        Me.Combo2.BackColor = System.Drawing.SystemColors.Window
        Me.Combo2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Combo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Combo2.Location = New System.Drawing.Point(74, 50)
        Me.Combo2.Name = "Combo2"
        Me.Combo2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Combo2.Size = New System.Drawing.Size(177, 21)
        Me.Combo2.TabIndex = 2
        Me.Combo2.Visible = False
        '
        'DTPfecha
        '
        Me.DTPfecha.Location = New System.Drawing.Point(81, 131)
        Me.DTPfecha.Name = "DTPfecha"
        Me.DTPfecha.OcxState = CType(resources.GetObject("DTPfecha.OcxState"), System.Windows.Forms.AxHost.State)
        Me.DTPfecha.Size = New System.Drawing.Size(102, 19)
        Me.DTPfecha.TabIndex = 5
        '
        'TxUser
        '
        Me.TxUser.Enabled = True
        Me.TxUser.Location = New System.Drawing.Point(81, 79)
        Me.TxUser.Name = "TxUser"
        Me.TxUser.OcxState = CType(resources.GetObject("TxUser.OcxState"), System.Windows.Forms.AxHost.State)
        Me.TxUser.Size = New System.Drawing.Size(123, 21)
        Me.TxUser.TabIndex = 3
        '
        'TxPwd
        '
        Me.TxPwd.Enabled = True
        Me.TxPwd.Location = New System.Drawing.Point(81, 103)
        Me.TxPwd.Name = "TxPwd"
        Me.TxPwd.OcxState = CType(resources.GetObject("TxPwd.OcxState"), System.Windows.Forms.AxHost.State)
        Me.TxPwd.Size = New System.Drawing.Size(123, 21)
        Me.TxPwd.TabIndex = 4
        '
        'Lbgrupo
        '
        Me.Lbgrupo.AutoSize = True
        Me.Lbgrupo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lbgrupo.Cursor = System.Windows.Forms.Cursors.Default
        Me.Lbgrupo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Lbgrupo.Location = New System.Drawing.Point(10, 21)
        Me.Lbgrupo.Name = "Lbgrupo"
        Me.Lbgrupo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lbgrupo.Size = New System.Drawing.Size(36, 13)
        Me.Lbgrupo.TabIndex = 19
        Me.Lbgrupo.Text = "Grupo"
        '
        'Lbempresa
        '
        Me.Lbempresa.AutoSize = True
        Me.Lbempresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lbempresa.Cursor = System.Windows.Forms.Cursors.Default
        Me.Lbempresa.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Lbempresa.Location = New System.Drawing.Point(8, 55)
        Me.Lbempresa.Name = "Lbempresa"
        Me.Lbempresa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lbempresa.Size = New System.Drawing.Size(54, 13)
        Me.Lbempresa.TabIndex = 18
        Me.Lbempresa.Text = "Empresa :"
        Me.Lbempresa.Visible = False
        '
        '_Label1_0
        '
        Me._Label1_0.AutoSize = True
        Me._Label1_0.BackColor = System.Drawing.Color.Transparent
        Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_0, CType(0, Short))
        Me._Label1_0.Location = New System.Drawing.Point(17, 84)
        Me._Label1_0.Name = "_Label1_0"
        Me._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_0.Size = New System.Drawing.Size(49, 13)
        Me._Label1_0.TabIndex = 17
        Me._Label1_0.Text = "Usuario :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(17, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Password :"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(17, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(58, 29)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Fecha de Trabajo :"
        '
        'Image1
        '
        Me.Image1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Image1.Image = CType(resources.GetObject("Image1.Image"), System.Drawing.Image)
        Me.Image1.Location = New System.Drawing.Point(16, 24)
        Me.Image1.Name = "Image1"
        Me.Image1.Size = New System.Drawing.Size(419, 250)
        Me.Image1.TabIndex = 15
        Me.Image1.TabStop = False
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Frame3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(13, 75)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(260, 78)
        Me.Frame3.TabIndex = 10
        '
        'framaño
        '
        Me.framaño.BackColor = System.Drawing.SystemColors.HighlightText
        Me.framaño.Controls.Add(Me.cmdGenerar)
        Me.framaño.Controls.Add(Me.Label5)
        Me.framaño.Cursor = System.Windows.Forms.Cursors.Default
        Me.framaño.ForeColor = System.Drawing.SystemColors.ControlText
        Me.framaño.Location = New System.Drawing.Point(6, 435)
        Me.framaño.Name = "framaño"
        Me.framaño.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.framaño.Size = New System.Drawing.Size(259, 58)
        Me.framaño.TabIndex = 0
        Me.framaño.Visible = False
        '
        'cmdGenerar
        '
        Me.cmdGenerar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdGenerar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdGenerar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdGenerar.Location = New System.Drawing.Point(73, 29)
        Me.cmdGenerar.Name = "cmdGenerar"
        Me.cmdGenerar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdGenerar.Size = New System.Drawing.Size(119, 22)
        Me.cmdGenerar.TabIndex = 8
        Me.cmdGenerar.Text = "&Generar Año"
        Me.cmdGenerar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(19, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(237, 25)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "El año seleccionado no esta generado"
        '
        'ImgList2
        '
        Me.ImgList2.ImageStream = CType(resources.GetObject("ImgList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgList2.TransparentColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ImgList2.Images.SetKeyName(0, "Grabar")
        Me.ImgList2.Images.SetKeyName(1, "Imprimir")
        Me.ImgList2.Images.SetKeyName(2, "Modificar")
        Me.ImgList2.Images.SetKeyName(3, "Borrar")
        Me.ImgList2.Images.SetKeyName(4, "Cancelar")
        Me.ImgList2.Images.SetKeyName(5, "Retornar")
        Me.ImgList2.Images.SetKeyName(6, "Camara")
        Me.ImgList2.Images.SetKeyName(7, "Crear")
        Me.ImgList2.Images.SetKeyName(8, "Celular")
        Me.ImgList2.Images.SetKeyName(9, "Ver")
        Me.ImgList2.Images.SetKeyName(10, "Arbitrios")
        Me.ImgList2.Images.SetKeyName(11, "Autoav")
        Me.ImgList2.Images.SetKeyName(12, "Facturar")
        Me.ImgList2.Images.SetKeyName(13, "Entrar")
        Me.ImgList2.Images.SetKeyName(14, "Convenio")
        Me.ImgList2.Images.SetKeyName(15, "Generar")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label6.Location = New System.Drawing.Point(9, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(99, 18)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Iniciar sesion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label2.Location = New System.Drawing.Point(6, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(254, 24)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Sistema de Contabilidad"
        '
        'frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(577, 306)
        Me.ControlBox = False
        Me.Controls.Add(Me._Frame1_1)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.framaño)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmlogin"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario de Ingreso"
        Me._Frame1_1.ResumeLayout(False)
        Me._Frame1_0.ResumeLayout(False)
        Me._Frame1_0.PerformLayout()
        CType(Me.DTPfecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxPwd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.framaño.ResumeLayout(False)
        CType(Me.Frame1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region 
End Class