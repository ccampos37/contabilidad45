<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmlogin
#Region "C�digo generado por el Dise�ador de Windows Forms "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'Llamada necesaria para el Dise�ador de Windows Forms.
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
	'Requerido por el Dise�ador de Windows Forms
	Private components As System.ComponentModel.IContainer
    Public WithEvents CmdAceptar As System.Windows.Forms.Button
	Public WithEvents CmdCancelar As System.Windows.Forms.Button
	Public WithEvents Combo1 As System.Windows.Forms.ComboBox
	Public WithEvents Combo2 As System.Windows.Forms.ComboBox
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
	Public WithEvents frama�o As System.Windows.Forms.Panel
    Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
    'NOTA: el Dise�ador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Dise�ador de Windows Forms.
    'No lo modifique con el editor de c�digo.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmlogin))
        Me._Frame1_1 = New System.Windows.Forms.GroupBox()
        Me._Frame1_0 = New System.Windows.Forms.GroupBox()
        Me.DTPfecha = New System.Windows.Forms.DateTimePicker()
        Me.CmdAceptar = New System.Windows.Forms.Button()
        Me.CmdCancelar = New System.Windows.Forms.Button()
        Me.Combo1 = New System.Windows.Forms.ComboBox()
        Me.Combo2 = New System.Windows.Forms.ComboBox()
        Me.Lbgrupo = New System.Windows.Forms.Label()
        Me.Lbempresa = New System.Windows.Forms.Label()
        Me._Label1_0 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Image1 = New System.Windows.Forms.PictureBox()
        Me.Frame3 = New System.Windows.Forms.Panel()
        Me.frama�o = New System.Windows.Forms.Panel()
        Me.cmdGenerar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxUser = New Jck_txt.Jck_Txt()
        Me.TxPwd = New System.Windows.Forms.TextBox()
        Me._Frame1_1.SuspendLayout()
        Me._Frame1_0.SuspendLayout()
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frama�o.SuspendLayout()
        Me.SuspendLayout()
        '
        '_Frame1_1
        '
        Me._Frame1_1.BackColor = System.Drawing.Color.White
        Me._Frame1_1.Controls.Add(Me._Frame1_0)
        Me._Frame1_1.Controls.Add(Me.Image1)
        Me._Frame1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Frame1_1.Location = New System.Drawing.Point(10, 12)
        Me._Frame1_1.Name = "_Frame1_1"
        Me._Frame1_1.Padding = New System.Windows.Forms.Padding(0)
        Me._Frame1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Frame1_1.Size = New System.Drawing.Size(568, 276)
        Me._Frame1_1.TabIndex = 13
        Me._Frame1_1.TabStop = False
        '
        '_Frame1_0
        '
        Me._Frame1_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._Frame1_0.Controls.Add(Me.TxPwd)
        Me._Frame1_0.Controls.Add(Me.TxUser)
        Me._Frame1_0.Controls.Add(Me.DTPfecha)
        Me._Frame1_0.Controls.Add(Me.CmdAceptar)
        Me._Frame1_0.Controls.Add(Me.CmdCancelar)
        Me._Frame1_0.Controls.Add(Me.Combo1)
        Me._Frame1_0.Controls.Add(Me.Combo2)
        Me._Frame1_0.Controls.Add(Me.Lbgrupo)
        Me._Frame1_0.Controls.Add(Me.Lbempresa)
        Me._Frame1_0.Controls.Add(Me._Label1_0)
        Me._Frame1_0.Controls.Add(Me.Label3)
        Me._Frame1_0.Controls.Add(Me.Label4)
        Me._Frame1_0.ForeColor = System.Drawing.Color.Red
        Me._Frame1_0.Location = New System.Drawing.Point(296, 24)
        Me._Frame1_0.Name = "_Frame1_0"
        Me._Frame1_0.Padding = New System.Windows.Forms.Padding(0)
        Me._Frame1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Frame1_0.Size = New System.Drawing.Size(262, 234)
        Me._Frame1_0.TabIndex = 14
        Me._Frame1_0.TabStop = False
        '
        'DTPfecha
        '
        Me.DTPfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPfecha.Location = New System.Drawing.Point(75, 136)
        Me.DTPfecha.Name = "DTPfecha"
        Me.DTPfecha.Size = New System.Drawing.Size(124, 20)
        Me.DTPfecha.TabIndex = 20
        '
        'CmdAceptar
        '
        Me.CmdAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdAceptar.Image = CType(resources.GetObject("CmdAceptar.Image"), System.Drawing.Image)
        Me.CmdAceptar.Location = New System.Drawing.Point(63, 184)
        Me.CmdAceptar.Name = "CmdAceptar"
        Me.CmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdAceptar.Size = New System.Drawing.Size(65, 50)
        Me.CmdAceptar.TabIndex = 6
        Me.CmdAceptar.UseVisualStyleBackColor = False
        '
        'CmdCancelar
        '
        Me.CmdCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdCancelar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdCancelar.Image = CType(resources.GetObject("CmdCancelar.Image"), System.Drawing.Image)
        Me.CmdCancelar.Location = New System.Drawing.Point(157, 184)
        Me.CmdCancelar.Name = "CmdCancelar"
        Me.CmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdCancelar.Size = New System.Drawing.Size(78, 49)
        Me.CmdCancelar.TabIndex = 7
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
        Me.Combo2.Location = New System.Drawing.Point(74, 43)
        Me.Combo2.Name = "Combo2"
        Me.Combo2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Combo2.Size = New System.Drawing.Size(177, 21)
        Me.Combo2.TabIndex = 2
        Me.Combo2.Visible = False
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
        Me.Lbempresa.Location = New System.Drawing.Point(8, 46)
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
        Me._Label1_0.Location = New System.Drawing.Point(17, 78)
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
        Me.Label3.Location = New System.Drawing.Point(17, 102)
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
        Me.Label4.Location = New System.Drawing.Point(17, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(52, 29)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Fecha de Trabajo :"
        '
        'Image1
        '
        Me.Image1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Image1.Image = CType(resources.GetObject("Image1.Image"), System.Drawing.Image)
        Me.Image1.Location = New System.Drawing.Point(16, 24)
        Me.Image1.Name = "Image1"
        Me.Image1.Size = New System.Drawing.Size(282, 234)
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
        'frama�o
        '
        Me.frama�o.BackColor = System.Drawing.SystemColors.HighlightText
        Me.frama�o.Controls.Add(Me.cmdGenerar)
        Me.frama�o.Controls.Add(Me.Label5)
        Me.frama�o.Cursor = System.Windows.Forms.Cursors.Default
        Me.frama�o.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frama�o.Location = New System.Drawing.Point(6, 435)
        Me.frama�o.Name = "frama�o"
        Me.frama�o.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frama�o.Size = New System.Drawing.Size(259, 58)
        Me.frama�o.TabIndex = 0
        Me.frama�o.Visible = False
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
        Me.cmdGenerar.Text = "&Generar A�o"
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
        Me.Label5.Text = "El a�o seleccionado no esta generado"
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
        'TxUser
        '
        Me.TxUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TxUser.BackColor = System.Drawing.Color.White
        Me.TxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TxUser.decimales = 0
        Me.TxUser.formato = " "
        Me.TxUser.Location = New System.Drawing.Point(75, 76)
        Me.TxUser.longitud = 8
        Me.TxUser.Name = "TxUser"
        Me.TxUser.negativos = False
        Me.TxUser.Requerido = True
        Me.TxUser.Size = New System.Drawing.Size(122, 21)
        Me.TxUser.TabIndex = 25
        Me.TxUser.tipoCaracter = 3
        Me.TxUser.tipoletra = 3
        '
        'TxPwd
        '
        Me.TxPwd.Location = New System.Drawing.Point(75, 103)
        Me.TxPwd.Name = "TxPwd"
        Me.TxPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxPwd.Size = New System.Drawing.Size(124, 20)
        Me.TxPwd.TabIndex = 26
        Me.TxPwd.UseSystemPasswordChar = True
        '
        'frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(588, 301)
        Me.ControlBox = False
        Me.Controls.Add(Me._Frame1_1)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.frama�o)
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
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frama�o.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DTPfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxPwd As System.Windows.Forms.TextBox
    Friend WithEvents TxUser As Jck_txt.Jck_Txt
#End Region
End Class