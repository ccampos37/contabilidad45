<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRepCtaCteAnalitico
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
    Public WithEvents chkAjuste As System.Windows.Forms.CheckBox
    Public WithEvents OptDetalle0 As System.Windows.Forms.RadioButton
    Public WithEvents OptDetalle1 As System.Windows.Forms.RadioButton
    Public WithEvents Frame6 As System.Windows.Forms.GroupBox
    Public WithEvents optOpcion3 As System.Windows.Forms.RadioButton
    Public WithEvents optOpcion2 As System.Windows.Forms.RadioButton
    Public WithEvents Frame5 As System.Windows.Forms.GroupBox
    Public WithEvents lstTipoAnaliticoCodigo As System.Windows.Forms.ListBox
    Public WithEvents cmdBotones0 As System.Windows.Forms.Button
    Public WithEvents cmdBotones1 As System.Windows.Forms.Button
    Public WithEvents optFiltro2 As System.Windows.Forms.RadioButton
    Public WithEvents optFiltro1 As System.Windows.Forms.RadioButton
    Public WithEvents optFiltro0 As System.Windows.Forms.RadioButton
    Public WithEvents Frame4 As System.Windows.Forms.GroupBox
    Public WithEvents Ctr_Ayuda1 As Axctrlayuda_f.AxCtr_Ayuda
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Frame3 As System.Windows.Forms.GroupBox
    Public WithEvents cboTipoAnalitico As System.Windows.Forms.ComboBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents optOpcion4 As System.Windows.Forms.RadioButton
    Public WithEvents optOpcion0 As System.Windows.Forms.RadioButton
    Public WithEvents optOpcion1 As System.Windows.Forms.RadioButton
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents Ctr_AyudaEnt As Axctrlayuda_f.AxCtr_Ayuda
    Public WithEvents Ctr_Ayuda2 As Axctrlayuda_f.AxCtr_Ayuda
    Public WithEvents Label4 As System.Windows.Forms.Label
    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRepCtaCteAnalitico))
        Me.chkAjuste = New System.Windows.Forms.CheckBox()
        Me.Frame6 = New System.Windows.Forms.GroupBox()
        Me.OptDetalle0 = New System.Windows.Forms.RadioButton()
        Me.OptDetalle1 = New System.Windows.Forms.RadioButton()
        Me.Frame5 = New System.Windows.Forms.GroupBox()
        Me.optOpcion3 = New System.Windows.Forms.RadioButton()
        Me.optOpcion2 = New System.Windows.Forms.RadioButton()
        Me.lstTipoAnaliticoCodigo = New System.Windows.Forms.ListBox()
        Me.cmdBotones0 = New System.Windows.Forms.Button()
        Me.cmdBotones1 = New System.Windows.Forms.Button()
        Me.Frame4 = New System.Windows.Forms.GroupBox()
        Me.optFiltro2 = New System.Windows.Forms.RadioButton()
        Me.optFiltro1 = New System.Windows.Forms.RadioButton()
        Me.optFiltro0 = New System.Windows.Forms.RadioButton()
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me.Ctr_Ayuda1 = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.cboTipoAnalitico = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.optOpcion4 = New System.Windows.Forms.RadioButton()
        Me.optOpcion0 = New System.Windows.Forms.RadioButton()
        Me.optOpcion1 = New System.Windows.Forms.RadioButton()
        Me.Ctr_AyudaEnt = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Ctr_Ayuda2 = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Frame6.SuspendLayout
        Me.Frame5.SuspendLayout
        Me.Frame4.SuspendLayout
        Me.Frame3.SuspendLayout
        CType(Me.Ctr_Ayuda1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Frame2.SuspendLayout
        Me.Frame1.SuspendLayout
        CType(Me.Ctr_AyudaEnt,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Ctr_Ayuda2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'chkAjuste
        '
        Me.chkAjuste.BackColor = System.Drawing.SystemColors.Control
        Me.chkAjuste.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAjuste.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAjuste.Location = New System.Drawing.Point(358, 234)
        Me.chkAjuste.Name = "chkAjuste"
        Me.chkAjuste.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAjuste.Size = New System.Drawing.Size(121, 29)
        Me.chkAjuste.TabIndex = 26
        Me.chkAjuste.Text = "Incluye ajuste por diferencia de cambio"
        Me.chkAjuste.UseVisualStyleBackColor = false
        '
        'Frame6
        '
        Me.Frame6.BackColor = System.Drawing.SystemColors.Control
        Me.Frame6.Controls.Add(Me.OptDetalle0)
        Me.Frame6.Controls.Add(Me.OptDetalle1)
        Me.Frame6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame6.Location = New System.Drawing.Point(6, 222)
        Me.Frame6.Name = "Frame6"
        Me.Frame6.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame6.Size = New System.Drawing.Size(346, 46)
        Me.Frame6.TabIndex = 23
        Me.Frame6.TabStop = false
        Me.Frame6.Text = "Seleccionar Detalle"
        '
        'OptDetalle0
        '
        Me.OptDetalle0.BackColor = System.Drawing.SystemColors.Control
        Me.OptDetalle0.Cursor = System.Windows.Forms.Cursors.Default
        Me.OptDetalle0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptDetalle0.Location = New System.Drawing.Point(15, 21)
        Me.OptDetalle0.Name = "OptDetalle0"
        Me.OptDetalle0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OptDetalle0.Size = New System.Drawing.Size(94, 17)
        Me.OptDetalle0.TabIndex = 25
        Me.OptDetalle0.TabStop = true
        Me.OptDetalle0.Text = "Solo Saldos"
        Me.OptDetalle0.UseVisualStyleBackColor = false
        '
        'OptDetalle1
        '
        Me.OptDetalle1.BackColor = System.Drawing.SystemColors.Control
        Me.OptDetalle1.Checked = true
        Me.OptDetalle1.Cursor = System.Windows.Forms.Cursors.Default
        Me.OptDetalle1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptDetalle1.Location = New System.Drawing.Point(174, 18)
        Me.OptDetalle1.Name = "OptDetalle1"
        Me.OptDetalle1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OptDetalle1.Size = New System.Drawing.Size(133, 16)
        Me.OptDetalle1.TabIndex = 24
        Me.OptDetalle1.TabStop = true
        Me.OptDetalle1.Text = "Detalle por documento"
        Me.OptDetalle1.UseVisualStyleBackColor = false
        '
        'Frame5
        '
        Me.Frame5.BackColor = System.Drawing.SystemColors.Control
        Me.Frame5.Controls.Add(Me.optOpcion3)
        Me.Frame5.Controls.Add(Me.optOpcion2)
        Me.Frame5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame5.Location = New System.Drawing.Point(328, 8)
        Me.Frame5.Name = "Frame5"
        Me.Frame5.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame5.Size = New System.Drawing.Size(147, 57)
        Me.Frame5.TabIndex = 18
        Me.Frame5.TabStop = false
        Me.Frame5.Text = "Ordenado por"
        '
        'optOpcion3
        '
        Me.optOpcion3.BackColor = System.Drawing.SystemColors.Control
        Me.optOpcion3.Cursor = System.Windows.Forms.Cursors.Default
        Me.optOpcion3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optOpcion3.Location = New System.Drawing.Point(9, 36)
        Me.optOpcion3.Name = "optOpcion3"
        Me.optOpcion3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optOpcion3.Size = New System.Drawing.Size(136, 15)
        Me.optOpcion3.TabIndex = 20
        Me.optOpcion3.TabStop = true
        Me.optOpcion3.Text = "Cuenta Contable"
        Me.optOpcion3.UseVisualStyleBackColor = false
        '
        'optOpcion2
        '
        Me.optOpcion2.BackColor = System.Drawing.SystemColors.Control
        Me.optOpcion2.Cursor = System.Windows.Forms.Cursors.Default
        Me.optOpcion2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optOpcion2.Location = New System.Drawing.Point(9, 19)
        Me.optOpcion2.Name = "optOpcion2"
        Me.optOpcion2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optOpcion2.Size = New System.Drawing.Size(138, 15)
        Me.optOpcion2.TabIndex = 19
        Me.optOpcion2.TabStop = true
        Me.optOpcion2.Text = "Entidad"
        Me.optOpcion2.UseVisualStyleBackColor = false
        '
        'lstTipoAnaliticoCodigo
        '
        Me.lstTipoAnaliticoCodigo.BackColor = System.Drawing.SystemColors.Window
        Me.lstTipoAnaliticoCodigo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstTipoAnaliticoCodigo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstTipoAnaliticoCodigo.Location = New System.Drawing.Point(387, 330)
        Me.lstTipoAnaliticoCodigo.Name = "lstTipoAnaliticoCodigo"
        Me.lstTipoAnaliticoCodigo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstTipoAnaliticoCodigo.Size = New System.Drawing.Size(79, 17)
        Me.lstTipoAnaliticoCodigo.TabIndex = 14
        Me.lstTipoAnaliticoCodigo.Visible = false
        '
        'cmdBotones0
        '
        Me.cmdBotones0.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBotones0.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBotones0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones0.Location = New System.Drawing.Point(139, 332)
        Me.cmdBotones0.Name = "cmdBotones0"
        Me.cmdBotones0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBotones0.Size = New System.Drawing.Size(98, 25)
        Me.cmdBotones0.TabIndex = 13
        Me.cmdBotones0.Text = "&Aceptar"
        Me.cmdBotones0.UseVisualStyleBackColor = false
        '
        'cmdBotones1
        '
        Me.cmdBotones1.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBotones1.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBotones1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones1.Location = New System.Drawing.Point(251, 332)
        Me.cmdBotones1.Name = "cmdBotones1"
        Me.cmdBotones1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBotones1.Size = New System.Drawing.Size(98, 25)
        Me.cmdBotones1.TabIndex = 12
        Me.cmdBotones1.Text = "&Cancelar"
        Me.cmdBotones1.UseVisualStyleBackColor = false
        '
        'Frame4
        '
        Me.Frame4.BackColor = System.Drawing.SystemColors.Control
        Me.Frame4.Controls.Add(Me.optFiltro2)
        Me.Frame4.Controls.Add(Me.optFiltro1)
        Me.Frame4.Controls.Add(Me.optFiltro0)
        Me.Frame4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame4.Location = New System.Drawing.Point(6, 273)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame4.Size = New System.Drawing.Size(475, 50)
        Me.Frame4.TabIndex = 11
        Me.Frame4.TabStop = false
        Me.Frame4.Text = "Seleccionar Filtro"
        '
        'optFiltro2
        '
        Me.optFiltro2.BackColor = System.Drawing.SystemColors.Control
        Me.optFiltro2.Cursor = System.Windows.Forms.Cursors.Default
        Me.optFiltro2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optFiltro2.Location = New System.Drawing.Point(363, 18)
        Me.optFiltro2.Name = "optFiltro2"
        Me.optFiltro2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optFiltro2.Size = New System.Drawing.Size(101, 20)
        Me.optFiltro2.TabIndex = 17
        Me.optFiltro2.TabStop = true
        Me.optFiltro2.Text = "Todos"
        Me.optFiltro2.UseVisualStyleBackColor = false
        '
        'optFiltro1
        '
        Me.optFiltro1.BackColor = System.Drawing.SystemColors.Control
        Me.optFiltro1.Cursor = System.Windows.Forms.Cursors.Default
        Me.optFiltro1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optFiltro1.Location = New System.Drawing.Point(173, 18)
        Me.optFiltro1.Name = "optFiltro1"
        Me.optFiltro1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optFiltro1.Size = New System.Drawing.Size(143, 20)
        Me.optFiltro1.TabIndex = 16
        Me.optFiltro1.TabStop = true
        Me.optFiltro1.Text = "Documentos pendientes"
        Me.optFiltro1.UseVisualStyleBackColor = false
        '
        'optFiltro0
        '
        Me.optFiltro0.BackColor = System.Drawing.SystemColors.Control
        Me.optFiltro0.Cursor = System.Windows.Forms.Cursors.Default
        Me.optFiltro0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optFiltro0.Location = New System.Drawing.Point(12, 18)
        Me.optFiltro0.Name = "optFiltro0"
        Me.optFiltro0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optFiltro0.Size = New System.Drawing.Size(143, 20)
        Me.optFiltro0.TabIndex = 15
        Me.optFiltro0.TabStop = true
        Me.optFiltro0.Text = "Documentos cancelados"
        Me.optFiltro0.UseVisualStyleBackColor = false
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.Add(Me.Ctr_Ayuda1)
        Me.Frame3.Controls.Add(Me.Label1)
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(3, 126)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(476, 63)
        Me.Frame3.TabIndex = 9
        Me.Frame3.TabStop = false
        Me.Frame3.Text = "Seleccionar Cuentas"
        '
        'Ctr_Ayuda1
        '
        Me.Ctr_Ayuda1.Enabled = true
        Me.Ctr_Ayuda1.Location = New System.Drawing.Point(112, 24)
        Me.Ctr_Ayuda1.Name = "Ctr_Ayuda1"
        Me.Ctr_Ayuda1.OcxState = CType(resources.GetObject("Ctr_Ayuda1.OcxState"),System.Windows.Forms.AxHost.State)
        Me.Ctr_Ayuda1.Size = New System.Drawing.Size(359, 24)
        Me.Ctr_Ayuda1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(9, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(89, 19)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Cuenta Contable"
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.cboTipoAnalitico)
        Me.Frame2.Controls.Add(Me.Label2)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(2, 75)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(474, 48)
        Me.Frame2.TabIndex = 3
        Me.Frame2.TabStop = false
        Me.Frame2.Text = "Seleccionar Entidades (Analítico)"
        '
        'cboTipoAnalitico
        '
        Me.cboTipoAnalitico.BackColor = System.Drawing.SystemColors.Window
        Me.cboTipoAnalitico.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboTipoAnalitico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoAnalitico.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboTipoAnalitico.Location = New System.Drawing.Point(126, 19)
        Me.cboTipoAnalitico.Name = "cboTipoAnalitico"
        Me.cboTipoAnalitico.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboTipoAnalitico.Size = New System.Drawing.Size(293, 21)
        Me.cboTipoAnalitico.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(12, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Tipo Analítico"
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.optOpcion4)
        Me.Frame1.Controls.Add(Me.optOpcion0)
        Me.Frame1.Controls.Add(Me.optOpcion1)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(3, 7)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(315, 57)
        Me.Frame1.TabIndex = 2
        Me.Frame1.TabStop = false
        Me.Frame1.Text = "Emitir por"
        '
        'optOpcion4
        '
        Me.optOpcion4.BackColor = System.Drawing.SystemColors.Control
        Me.optOpcion4.Cursor = System.Windows.Forms.Cursors.Default
        Me.optOpcion4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optOpcion4.Location = New System.Drawing.Point(176, 24)
        Me.optOpcion4.Name = "optOpcion4"
        Me.optOpcion4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optOpcion4.Size = New System.Drawing.Size(141, 15)
        Me.optOpcion4.TabIndex = 21
        Me.optOpcion4.TabStop = true
        Me.optOpcion4.Text = "Saldos iniciales"
        Me.optOpcion4.UseVisualStyleBackColor = false
        '
        'optOpcion0
        '
        Me.optOpcion0.BackColor = System.Drawing.SystemColors.Control
        Me.optOpcion0.Cursor = System.Windows.Forms.Cursors.Default
        Me.optOpcion0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optOpcion0.Location = New System.Drawing.Point(9, 19)
        Me.optOpcion0.Name = "optOpcion0"
        Me.optOpcion0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optOpcion0.Size = New System.Drawing.Size(163, 15)
        Me.optOpcion0.TabIndex = 0
        Me.optOpcion0.TabStop = true
        Me.optOpcion0.Text = "Movimiento Cuenta Corriente"
        Me.optOpcion0.UseVisualStyleBackColor = false
        '
        'optOpcion1
        '
        Me.optOpcion1.BackColor = System.Drawing.SystemColors.Control
        Me.optOpcion1.Cursor = System.Windows.Forms.Cursors.Default
        Me.optOpcion1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optOpcion1.Location = New System.Drawing.Point(9, 37)
        Me.optOpcion1.Name = "optOpcion1"
        Me.optOpcion1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optOpcion1.Size = New System.Drawing.Size(159, 15)
        Me.optOpcion1.TabIndex = 1
        Me.optOpcion1.TabStop = true
        Me.optOpcion1.Text = "Saldos Cuenta Corriente"
        Me.optOpcion1.UseVisualStyleBackColor = false
        '
        'Ctr_AyudaEnt
        '
        Me.Ctr_AyudaEnt.Enabled = true
        Me.Ctr_AyudaEnt.Location = New System.Drawing.Point(111, 195)
        Me.Ctr_AyudaEnt.Name = "Ctr_AyudaEnt"
        Me.Ctr_AyudaEnt.OcxState = CType(resources.GetObject("Ctr_AyudaEnt.OcxState"),System.Windows.Forms.AxHost.State)
        Me.Ctr_AyudaEnt.Size = New System.Drawing.Size(359, 22)
        Me.Ctr_AyudaEnt.TabIndex = 7
        '
        'Ctr_Ayuda2
        '
        Me.Ctr_Ayuda2.Enabled = true
        Me.Ctr_Ayuda2.Location = New System.Drawing.Point(111, 195)
        Me.Ctr_Ayuda2.Name = "Ctr_Ayuda2"
        Me.Ctr_Ayuda2.OcxState = CType(resources.GetObject("Ctr_Ayuda2.OcxState"),System.Windows.Forms.AxHost.State)
        Me.Ctr_Ayuda2.Size = New System.Drawing.Size(359, 22)
        Me.Ctr_Ayuda2.TabIndex = 6
        Me.Ctr_Ayuda2.Visible = false
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(12, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(100, 18)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Código Analítico"
        '
        'frmRepCtaCteAnalitico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(485, 411)
        Me.Controls.Add(Me.chkAjuste)
        Me.Controls.Add(Me.Frame6)
        Me.Controls.Add(Me.Frame5)
        Me.Controls.Add(Me.lstTipoAnaliticoCodigo)
        Me.Controls.Add(Me.cmdBotones0)
        Me.Controls.Add(Me.cmdBotones1)
        Me.Controls.Add(Me.Frame4)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Ctr_AyudaEnt)
        Me.Controls.Add(Me.Ctr_Ayuda2)
        Me.Controls.Add(Me.Label4)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmRepCtaCteAnalitico"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Cuenta Corriente Entidades (Analíticos)"
        Me.Frame6.ResumeLayout(false)
        Me.Frame5.ResumeLayout(false)
        Me.Frame4.ResumeLayout(false)
        Me.Frame3.ResumeLayout(false)
        CType(Me.Ctr_Ayuda1,System.ComponentModel.ISupportInitialize).EndInit
        Me.Frame2.ResumeLayout(false)
        Me.Frame1.ResumeLayout(false)
        CType(Me.Ctr_AyudaEnt,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Ctr_Ayuda2,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
#End Region 
End Class