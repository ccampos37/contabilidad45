<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FrmLibroBalancedeComprobacion
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
	Public WithEvents _OptForma_0 As System.Windows.Forms.RadioButton
	Public WithEvents _OptForma_1 As System.Windows.Forms.RadioButton
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents ChkCascada As System.Windows.Forms.CheckBox
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents _OpTipo_0 As System.Windows.Forms.RadioButton
	Public WithEvents _OpTipo_1 As System.Windows.Forms.RadioButton
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents CmdAceptar As System.Windows.Forms.Button
	Public WithEvents CmdCancelar As System.Windows.Forms.Button
	Public WithEvents cmbNivel As System.Windows.Forms.ComboBox
	Public WithEvents DTPicker1 As AxMSComCtl2.AxDTPicker
	Public WithEvents CtrAyu_Moneda As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame4 As System.Windows.Forms.GroupBox
	Public WithEvents ChkFiltcta As System.Windows.Forms.CheckBox
	Public WithEvents CtrAyu_Cuenta As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents Frame5 As System.Windows.Forms.GroupBox
	Public WithEvents DtCfiltro As AxMSDataListLib.AxDataCombo
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents OpTipo As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	Public WithEvents OptForma As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLibroBalancedeComprobacion))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me._OptForma_0 = New System.Windows.Forms.RadioButton()
        Me._OptForma_1 = New System.Windows.Forms.RadioButton()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.ChkCascada = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me._OpTipo_0 = New System.Windows.Forms.RadioButton()
        Me._OpTipo_1 = New System.Windows.Forms.RadioButton()
        Me.CmdAceptar = New System.Windows.Forms.Button()
        Me.CmdCancelar = New System.Windows.Forms.Button()
        Me.Frame4 = New System.Windows.Forms.GroupBox()
        Me.cmbNivel = New System.Windows.Forms.ComboBox()
        Me.DTPicker1 = New AxMSComCtl2.AxDTPicker()
        Me.CtrAyu_Moneda = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Frame5 = New System.Windows.Forms.GroupBox()
        Me.ChkFiltcta = New System.Windows.Forms.CheckBox()
        Me.CtrAyu_Cuenta = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.DtCfiltro = New AxMSDataListLib.AxDataCombo()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OpTipo = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
        Me.OptForma = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
        Me.Frame1.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.Frame3.SuspendLayout()
        Me.Frame4.SuspendLayout()
        CType(Me.DTPicker1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CtrAyu_Moneda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame5.SuspendLayout()
        CType(Me.CtrAyu_Cuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtCfiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OptForma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame1.Controls.Add(Me._OptForma_0)
        Me.Frame1.Controls.Add(Me._OptForma_1)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(231, 233)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(206, 45)
        Me.Frame1.TabIndex = 19
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Forma"
        '
        '_OptForma_0
        '
        Me._OptForma_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._OptForma_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptForma_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptForma.SetIndex(Me._OptForma_0, CType(0, Short))
        Me._OptForma_0.Location = New System.Drawing.Point(8, 18)
        Me._OptForma_0.Name = "_OptForma_0"
        Me._OptForma_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._OptForma_0.Size = New System.Drawing.Size(63, 21)
        Me._OptForma_0.TabIndex = 21
        Me._OptForma_0.TabStop = True
        Me._OptForma_0.Text = "Mensual "
        Me._OptForma_0.UseVisualStyleBackColor = False
        Me._OptForma_0.Visible = False
        '
        '_OptForma_1
        '
        Me._OptForma_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._OptForma_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._OptForma_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptForma.SetIndex(Me._OptForma_1, CType(1, Short))
        Me._OptForma_1.Location = New System.Drawing.Point(111, 18)
        Me._OptForma_1.Name = "_OptForma_1"
        Me._OptForma_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._OptForma_1.Size = New System.Drawing.Size(84, 21)
        Me._OptForma_1.TabIndex = 20
        Me._OptForma_1.TabStop = True
        Me._OptForma_1.Text = "Acumulado "
        Me._OptForma_1.UseVisualStyleBackColor = False
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame2.Controls.Add(Me.ChkCascada)
        Me.Frame2.Controls.Add(Me.Label2)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(32, 24)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(405, 71)
        Me.Frame2.TabIndex = 16
        Me.Frame2.TabStop = False
        '
        'ChkCascada
        '
        Me.ChkCascada.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkCascada.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkCascada.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkCascada.Location = New System.Drawing.Point(86, 40)
        Me.ChkCascada.Name = "ChkCascada"
        Me.ChkCascada.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkCascada.Size = New System.Drawing.Size(136, 21)
        Me.ChkCascada.TabIndex = 17
        Me.ChkCascada.Text = "En Cascada"
        Me.ChkCascada.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(86, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(243, 21)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Balance de Comprobacion del mes Activo"
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame3.Controls.Add(Me._OpTipo_0)
        Me.Frame3.Controls.Add(Me._OpTipo_1)
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(34, 233)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(194, 45)
        Me.Frame3.TabIndex = 13
        Me.Frame3.TabStop = False
        Me.Frame3.Text = "Tipo"
        '
        '_OpTipo_0
        '
        Me._OpTipo_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._OpTipo_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._OpTipo_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OpTipo.SetIndex(Me._OpTipo_0, CType(0, Short))
        Me._OpTipo_0.Location = New System.Drawing.Point(8, 18)
        Me._OpTipo_0.Name = "_OpTipo_0"
        Me._OpTipo_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._OpTipo_0.Size = New System.Drawing.Size(83, 16)
        Me._OpTipo_0.TabIndex = 15
        Me._OpTipo_0.TabStop = True
        Me._OpTipo_0.Text = "Historico"
        Me._OpTipo_0.UseVisualStyleBackColor = False
        '
        '_OpTipo_1
        '
        Me._OpTipo_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._OpTipo_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._OpTipo_1.Enabled = False
        Me._OpTipo_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OpTipo.SetIndex(Me._OpTipo_1, CType(1, Short))
        Me._OpTipo_1.Location = New System.Drawing.Point(104, 18)
        Me._OpTipo_1.Name = "_OpTipo_1"
        Me._OpTipo_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._OpTipo_1.Size = New System.Drawing.Size(66, 16)
        Me._OpTipo_1.TabIndex = 14
        Me._OpTipo_1.TabStop = True
        Me._OpTipo_1.Text = "Ajustado"
        Me._OpTipo_1.UseVisualStyleBackColor = False
        '
        'CmdAceptar
        '
        Me.CmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.CmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdAceptar.Location = New System.Drawing.Point(145, 317)
        Me.CmdAceptar.Name = "CmdAceptar"
        Me.CmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdAceptar.Size = New System.Drawing.Size(91, 24)
        Me.CmdAceptar.TabIndex = 12
        Me.CmdAceptar.Text = "&Aceptar"
        Me.CmdAceptar.UseVisualStyleBackColor = False
        '
        'CmdCancelar
        '
        Me.CmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.CmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdCancelar.Location = New System.Drawing.Point(235, 317)
        Me.CmdCancelar.Name = "CmdCancelar"
        Me.CmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdCancelar.Size = New System.Drawing.Size(91, 24)
        Me.CmdCancelar.TabIndex = 11
        Me.CmdCancelar.Text = "&Cancelar"
        Me.CmdCancelar.UseVisualStyleBackColor = False
        '
        'Frame4
        '
        Me.Frame4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame4.Controls.Add(Me.cmbNivel)
        Me.Frame4.Controls.Add(Me.DTPicker1)
        Me.Frame4.Controls.Add(Me.CtrAyu_Moneda)
        Me.Frame4.Controls.Add(Me.Label4)
        Me.Frame4.Controls.Add(Me.Label3)
        Me.Frame4.Controls.Add(Me.Label1)
        Me.Frame4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame4.Location = New System.Drawing.Point(32, 95)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame4.Size = New System.Drawing.Size(406, 72)
        Me.Frame4.TabIndex = 3
        Me.Frame4.TabStop = False
        '
        'cmbNivel
        '
        Me.cmbNivel.BackColor = System.Drawing.SystemColors.Window
        Me.cmbNivel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbNivel.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbNivel.Location = New System.Drawing.Point(69, 15)
        Me.cmbNivel.Name = "cmbNivel"
        Me.cmbNivel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbNivel.Size = New System.Drawing.Size(128, 21)
        Me.cmbNivel.TabIndex = 4
        Me.cmbNivel.Text = "Combo1"
        '
        'DTPicker1
        '
        Me.DTPicker1.Location = New System.Drawing.Point(70, 41)
        Me.DTPicker1.Name = "DTPicker1"
        Me.DTPicker1.OcxState = CType(resources.GetObject("DTPicker1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.DTPicker1.Size = New System.Drawing.Size(127, 19)
        Me.DTPicker1.TabIndex = 5
        '
        'CtrAyu_Moneda
        '
        Me.CtrAyu_Moneda.Enabled = True
        Me.CtrAyu_Moneda.Location = New System.Drawing.Point(255, 41)
        Me.CtrAyu_Moneda.Name = "CtrAyu_Moneda"
        Me.CtrAyu_Moneda.OcxState = CType(resources.GetObject("CtrAyu_Moneda.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CtrAyu_Moneda.Size = New System.Drawing.Size(144, 21)
        Me.CtrAyu_Moneda.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(208, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Moneda :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(8, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Mes :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(9, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nivel :"
        '
        'Frame5
        '
        Me.Frame5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame5.Controls.Add(Me.ChkFiltcta)
        Me.Frame5.Controls.Add(Me.CtrAyu_Cuenta)
        Me.Frame5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame5.Location = New System.Drawing.Point(33, 171)
        Me.Frame5.Name = "Frame5"
        Me.Frame5.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame5.Size = New System.Drawing.Size(405, 60)
        Me.Frame5.TabIndex = 0
        Me.Frame5.TabStop = False
        Me.Frame5.Text = "Filtro por Cuentas"
        '
        'ChkFiltcta
        '
        Me.ChkFiltcta.BackColor = System.Drawing.SystemColors.Control
        Me.ChkFiltcta.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkFiltcta.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkFiltcta.Location = New System.Drawing.Point(98, -1)
        Me.ChkFiltcta.Name = "ChkFiltcta"
        Me.ChkFiltcta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkFiltcta.Size = New System.Drawing.Size(14, 20)
        Me.ChkFiltcta.TabIndex = 1
        Me.ChkFiltcta.UseVisualStyleBackColor = False
        '
        'CtrAyu_Cuenta
        '
        Me.CtrAyu_Cuenta.Enabled = True
        Me.CtrAyu_Cuenta.Location = New System.Drawing.Point(8, 25)
        Me.CtrAyu_Cuenta.Name = "CtrAyu_Cuenta"
        Me.CtrAyu_Cuenta.OcxState = CType(resources.GetObject("CtrAyu_Cuenta.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CtrAyu_Cuenta.Size = New System.Drawing.Size(390, 21)
        Me.CtrAyu_Cuenta.TabIndex = 2
        '
        'DtCfiltro
        '
        Me.DtCfiltro.Location = New System.Drawing.Point(149, 286)
        Me.DtCfiltro.Name = "DtCfiltro"
        Me.DtCfiltro.OcxState = CType(resources.GetObject("DtCfiltro.OcxState"), System.Windows.Forms.AxHost.State)
        Me.DtCfiltro.RowSource = Nothing
        Me.DtCfiltro.Size = New System.Drawing.Size(287, 21)
        Me.DtCfiltro.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(37, 289)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(112, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Filtro de Movimientos :"
        '
        'OptForma
        '
        '
        'FrmLibroBalancedeComprobacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(470, 388)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.CmdAceptar)
        Me.Controls.Add(Me.CmdCancelar)
        Me.Controls.Add(Me.Frame4)
        Me.Controls.Add(Me.Frame5)
        Me.Controls.Add(Me.DtCfiltro)
        Me.Controls.Add(Me.Label5)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "FrmLibroBalancedeComprobacion"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Balance de Comprobacion"
        Me.Frame1.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        Me.Frame3.ResumeLayout(False)
        Me.Frame4.ResumeLayout(False)
        Me.Frame4.PerformLayout()
        CType(Me.DTPicker1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CtrAyu_Moneda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame5.ResumeLayout(False)
        CType(Me.CtrAyu_Cuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtCfiltro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpTipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OptForma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region 
End Class