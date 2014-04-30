<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FrmRepBalanceComp
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
    Public WithEvents ChkFiltcta As System.Windows.Forms.CheckBox
	Public WithEvents CtrAyu_Cuenta As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents Frame5 As System.Windows.Forms.GroupBox
	Public WithEvents cmbNivel As System.Windows.Forms.ComboBox
	Public WithEvents DTPicker1 As AxMSComCtl2.AxDTPicker
	Public WithEvents CtrAyu_Moneda As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Frame4 As System.Windows.Forms.GroupBox
	Public WithEvents DtCfiltro As AxMSDataListLib.AxDataCombo
	Public WithEvents CmdCancelar As System.Windows.Forms.Button
	Public WithEvents CmdAceptar As System.Windows.Forms.Button
    Public WithEvents OpTipo1 As System.Windows.Forms.RadioButton
    Public WithEvents OpTipo0 As System.Windows.Forms.RadioButton
    Public WithEvents Frame3 As System.Windows.Forms.GroupBox
    Public WithEvents ChkCascada As System.Windows.Forms.CheckBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents OptForma1 As System.Windows.Forms.RadioButton
    Public WithEvents OptForma0 As System.Windows.Forms.RadioButton
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents Label5 As System.Windows.Forms.Label
    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRepBalanceComp))
        Me.Frame5 = New System.Windows.Forms.GroupBox()
        Me.ChkFiltcta = New System.Windows.Forms.CheckBox()
        Me.CtrAyu_Cuenta = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Frame4 = New System.Windows.Forms.GroupBox()
        Me.cmbNivel = New System.Windows.Forms.ComboBox()
        Me.DTPicker1 = New AxMSComCtl2.AxDTPicker()
        Me.CtrAyu_Moneda = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DtCfiltro = New AxMSDataListLib.AxDataCombo()
        Me.CmdCancelar = New System.Windows.Forms.Button()
        Me.CmdAceptar = New System.Windows.Forms.Button()
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me.OpTipo1 = New System.Windows.Forms.RadioButton()
        Me.OpTipo0 = New System.Windows.Forms.RadioButton()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.ChkCascada = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.OptForma1 = New System.Windows.Forms.RadioButton()
        Me.OptForma0 = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Frame5.SuspendLayout
        CType(Me.CtrAyu_Cuenta,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Frame4.SuspendLayout
        CType(Me.DTPicker1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.CtrAyu_Moneda,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DtCfiltro,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Frame3.SuspendLayout
        Me.Frame2.SuspendLayout
        Me.Frame1.SuspendLayout
        Me.SuspendLayout
        '
        'Frame5
        '
        Me.Frame5.BackColor = System.Drawing.SystemColors.Control
        Me.Frame5.Controls.Add(Me.ChkFiltcta)
        Me.Frame5.Controls.Add(Me.CtrAyu_Cuenta)
        Me.Frame5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame5.Location = New System.Drawing.Point(5, 148)
        Me.Frame5.Name = "Frame5"
        Me.Frame5.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame5.Size = New System.Drawing.Size(405, 60)
        Me.Frame5.TabIndex = 20
        Me.Frame5.TabStop = false
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
        Me.ChkFiltcta.TabIndex = 21
        Me.ChkFiltcta.UseVisualStyleBackColor = false
        '
        'CtrAyu_Cuenta
        '
        Me.CtrAyu_Cuenta.Enabled = true
        Me.CtrAyu_Cuenta.Location = New System.Drawing.Point(8, 25)
        Me.CtrAyu_Cuenta.Name = "CtrAyu_Cuenta"
        Me.CtrAyu_Cuenta.OcxState = CType(resources.GetObject("CtrAyu_Cuenta.OcxState"),System.Windows.Forms.AxHost.State)
        Me.CtrAyu_Cuenta.Size = New System.Drawing.Size(390, 21)
        Me.CtrAyu_Cuenta.TabIndex = 22
        '
        'Frame4
        '
        Me.Frame4.BackColor = System.Drawing.SystemColors.Control
        Me.Frame4.Controls.Add(Me.cmbNivel)
        Me.Frame4.Controls.Add(Me.DTPicker1)
        Me.Frame4.Controls.Add(Me.CtrAyu_Moneda)
        Me.Frame4.Controls.Add(Me.Label1)
        Me.Frame4.Controls.Add(Me.Label3)
        Me.Frame4.Controls.Add(Me.Label4)
        Me.Frame4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame4.Location = New System.Drawing.Point(4, 72)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame4.Size = New System.Drawing.Size(406, 72)
        Me.Frame4.TabIndex = 13
        Me.Frame4.TabStop = false
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
        Me.cmbNivel.TabIndex = 15
        Me.cmbNivel.Text = "Combo1"
        '
        'DTPicker1
        '
        Me.DTPicker1.Location = New System.Drawing.Point(70, 41)
        Me.DTPicker1.Name = "DTPicker1"
        Me.DTPicker1.OcxState = CType(resources.GetObject("DTPicker1.OcxState"),System.Windows.Forms.AxHost.State)
        Me.DTPicker1.Size = New System.Drawing.Size(127, 19)
        Me.DTPicker1.TabIndex = 14
        '
        'CtrAyu_Moneda
        '
        Me.CtrAyu_Moneda.Enabled = true
        Me.CtrAyu_Moneda.Location = New System.Drawing.Point(255, 41)
        Me.CtrAyu_Moneda.Name = "CtrAyu_Moneda"
        Me.CtrAyu_Moneda.OcxState = CType(resources.GetObject("CtrAyu_Moneda.OcxState"),System.Windows.Forms.AxHost.State)
        Me.CtrAyu_Moneda.Size = New System.Drawing.Size(144, 21)
        Me.CtrAyu_Moneda.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(9, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Nivel :"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(8, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Mes :"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(208, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Moneda :"
        '
        'DtCfiltro
        '
        Me.DtCfiltro.Location = New System.Drawing.Point(121, 263)
        Me.DtCfiltro.Name = "DtCfiltro"
        Me.DtCfiltro.OcxState = CType(resources.GetObject("DtCfiltro.OcxState"),System.Windows.Forms.AxHost.State)
        Me.DtCfiltro.RowSource = Nothing
        Me.DtCfiltro.Size = New System.Drawing.Size(287, 21)
        Me.DtCfiltro.TabIndex = 11
        '
        'CmdCancelar
        '
        Me.CmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.CmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdCancelar.Location = New System.Drawing.Point(259, 294)
        Me.CmdCancelar.Name = "CmdCancelar"
        Me.CmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdCancelar.Size = New System.Drawing.Size(106, 43)
        Me.CmdCancelar.TabIndex = 10
        Me.CmdCancelar.Text = "&Cancelar"
        Me.CmdCancelar.UseVisualStyleBackColor = false
        '
        'CmdAceptar
        '
        Me.CmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.CmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdAceptar.Location = New System.Drawing.Point(118, 294)
        Me.CmdAceptar.Name = "CmdAceptar"
        Me.CmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdAceptar.Size = New System.Drawing.Size(106, 43)
        Me.CmdAceptar.TabIndex = 9
        Me.CmdAceptar.Text = "&Aceptar"
        Me.CmdAceptar.UseVisualStyleBackColor = false
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.Add(Me.OpTipo1)
        Me.Frame3.Controls.Add(Me.OpTipo0)
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(6, 210)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(194, 45)
        Me.Frame3.TabIndex = 6
        Me.Frame3.TabStop = false
        Me.Frame3.Text = "Tipo"
        '
        'OpTipo1
        '
        Me.OpTipo1.BackColor = System.Drawing.SystemColors.Control
        Me.OpTipo1.Cursor = System.Windows.Forms.Cursors.Default
        Me.OpTipo1.Enabled = false
        Me.OpTipo1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OpTipo1.Location = New System.Drawing.Point(104, 21)
        Me.OpTipo1.Name = "OpTipo1"
        Me.OpTipo1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OpTipo1.Size = New System.Drawing.Size(66, 18)
        Me.OpTipo1.TabIndex = 8
        Me.OpTipo1.TabStop = true
        Me.OpTipo1.Text = "Ajustado"
        Me.OpTipo1.UseVisualStyleBackColor = false
        '
        'OpTipo0
        '
        Me.OpTipo0.BackColor = System.Drawing.SystemColors.Control
        Me.OpTipo0.Cursor = System.Windows.Forms.Cursors.Default
        Me.OpTipo0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OpTipo0.Location = New System.Drawing.Point(8, 21)
        Me.OpTipo0.Name = "OpTipo0"
        Me.OpTipo0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OpTipo0.Size = New System.Drawing.Size(83, 18)
        Me.OpTipo0.TabIndex = 7
        Me.OpTipo0.TabStop = true
        Me.OpTipo0.Text = "Historico"
        Me.OpTipo0.UseVisualStyleBackColor = false
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.ChkCascada)
        Me.Frame2.Controls.Add(Me.Label2)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(4, 1)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(405, 71)
        Me.Frame2.TabIndex = 3
        Me.Frame2.TabStop = false
        '
        'ChkCascada
        '
        Me.ChkCascada.BackColor = System.Drawing.SystemColors.Control
        Me.ChkCascada.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkCascada.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkCascada.Location = New System.Drawing.Point(86, 40)
        Me.ChkCascada.Name = "ChkCascada"
        Me.ChkCascada.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkCascada.Size = New System.Drawing.Size(136, 21)
        Me.ChkCascada.TabIndex = 5
        Me.ChkCascada.Text = "En Cascada"
        Me.ChkCascada.UseVisualStyleBackColor = false
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(86, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(243, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Balance de Comprobacion del mes Activo"
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.OptForma1)
        Me.Frame1.Controls.Add(Me.OptForma0)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(203, 210)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(206, 45)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = false
        Me.Frame1.Text = "Forma"
        '
        'OptForma1
        '
        Me.OptForma1.BackColor = System.Drawing.SystemColors.Control
        Me.OptForma1.Cursor = System.Windows.Forms.Cursors.Default
        Me.OptForma1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptForma1.Location = New System.Drawing.Point(111, 18)
        Me.OptForma1.Name = "OptForma1"
        Me.OptForma1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OptForma1.Size = New System.Drawing.Size(84, 21)
        Me.OptForma1.TabIndex = 2
        Me.OptForma1.TabStop = true
        Me.OptForma1.Text = "Acumulado "
        Me.OptForma1.UseVisualStyleBackColor = false
        '
        'OptForma0
        '
        Me.OptForma0.BackColor = System.Drawing.SystemColors.Control
        Me.OptForma0.Cursor = System.Windows.Forms.Cursors.Default
        Me.OptForma0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptForma0.Location = New System.Drawing.Point(8, 18)
        Me.OptForma0.Name = "OptForma0"
        Me.OptForma0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OptForma0.Size = New System.Drawing.Size(63, 21)
        Me.OptForma0.TabIndex = 1
        Me.OptForma0.TabStop = true
        Me.OptForma0.Text = "Mensual "
        Me.OptForma0.UseVisualStyleBackColor = false
        Me.OptForma0.Visible = false
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(9, 266)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(112, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Filtro de Movimientos :"
        '
        'FrmRepBalanceComp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(440, 367)
        Me.Controls.Add(Me.Frame5)
        Me.Controls.Add(Me.Frame4)
        Me.Controls.Add(Me.DtCfiltro)
        Me.Controls.Add(Me.CmdCancelar)
        Me.Controls.Add(Me.CmdAceptar)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Label5)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "FrmRepBalanceComp"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Reporte Balance de Comprobancion"
        Me.Frame5.ResumeLayout(false)
        CType(Me.CtrAyu_Cuenta,System.ComponentModel.ISupportInitialize).EndInit
        Me.Frame4.ResumeLayout(false)
        Me.Frame4.PerformLayout
        CType(Me.DTPicker1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CtrAyu_Moneda,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DtCfiltro,System.ComponentModel.ISupportInitialize).EndInit
        Me.Frame3.ResumeLayout(false)
        Me.Frame2.ResumeLayout(false)
        Me.Frame1.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
#End Region 
End Class