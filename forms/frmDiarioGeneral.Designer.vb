<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRepDiarioGeneral
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
	Public WithEvents cboMes As System.Windows.Forms.ComboBox
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents cmdBotones0 As System.Windows.Forms.Button
    Public WithEvents cmdBotones1 As System.Windows.Forms.Button
    Public WithEvents optOpcion2 As System.Windows.Forms.RadioButton
    Public WithEvents optOpcion0 As System.Windows.Forms.RadioButton
    Public WithEvents optOpcion1 As System.Windows.Forms.RadioButton
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents DTPickerFecFinal As AxMSComCtl2.AxDTPicker
    Public WithEvents DTPickerFecInicio As AxMSComCtl2.AxDTPicker
    Public WithEvents Ctr_Ayuda20 As Axctrlayuda_f.AxCtr_Ayuda
    Public WithEvents Ctr_Ayuda21 As Axctrlayuda_f.AxCtr_Ayuda
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents fraDetallado As System.Windows.Forms.GroupBox
    Public WithEvents Ctr_Ayuda10 As Axctrlayuda_f.AxCtr_Ayuda
    Public WithEvents Ctr_Ayuda11 As Axctrlayuda_f.AxCtr_Ayuda
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents fraResumido As System.Windows.Forms.GroupBox
    Public WithEvents Ctr_Ayuda1 As AxCtr_AyudaArray
    Public WithEvents Ctr_Ayuda2 As AxCtr_AyudaArray
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRepDiarioGeneral))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.cboMes = New System.Windows.Forms.ComboBox()
        Me.cmdBotones0 = New System.Windows.Forms.Button()
        Me.cmdBotones1 = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.optOpcion2 = New System.Windows.Forms.RadioButton()
        Me.optOpcion0 = New System.Windows.Forms.RadioButton()
        Me.optOpcion1 = New System.Windows.Forms.RadioButton()
        Me.fraDetallado = New System.Windows.Forms.GroupBox()
        Me.DTPickerFecFinal = New AxMSComCtl2.AxDTPicker()
        Me.DTPickerFecInicio = New AxMSComCtl2.AxDTPicker()
        Me.Ctr_Ayuda20 = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Ctr_Ayuda21 = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fraResumido = New System.Windows.Forms.GroupBox()
        Me.Ctr_Ayuda10 = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Ctr_Ayuda11 = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Frame2.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.fraDetallado.SuspendLayout()
        CType(Me.DTPickerFecFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTPickerFecInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ctr_Ayuda20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ctr_Ayuda21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraResumido.SuspendLayout()
        CType(Me.Ctr_Ayuda10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ctr_Ayuda11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.cboMes)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(0, 81)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(342, 47)
        Me.Frame2.TabIndex = 18
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Seleccionar Mes"
        '
        'cboMes
        '
        Me.cboMes.BackColor = System.Drawing.SystemColors.Window
        Me.cboMes.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboMes.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboMes.Location = New System.Drawing.Point(6, 17)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboMes.Size = New System.Drawing.Size(330, 21)
        Me.cboMes.TabIndex = 2
        '
        'cmdBotones0
        '
        Me.cmdBotones0.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBotones0.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBotones0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones0.Location = New System.Drawing.Point(78, 284)
        Me.cmdBotones0.Name = "cmdBotones0"
        Me.cmdBotones0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBotones0.Size = New System.Drawing.Size(82, 23)
        Me.cmdBotones0.TabIndex = 16
        Me.cmdBotones0.Text = "&Aceptar"
        Me.cmdBotones0.UseVisualStyleBackColor = False
        '
        'cmdBotones1
        '
        Me.cmdBotones1.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBotones1.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBotones1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones1.Location = New System.Drawing.Point(185, 284)
        Me.cmdBotones1.Name = "cmdBotones1"
        Me.cmdBotones1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBotones1.Size = New System.Drawing.Size(82, 23)
        Me.cmdBotones1.TabIndex = 15
        Me.cmdBotones1.Text = "&Cancelar"
        Me.cmdBotones1.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.optOpcion2)
        Me.Frame1.Controls.Add(Me.optOpcion0)
        Me.Frame1.Controls.Add(Me.optOpcion1)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(0, -4)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(342, 84)
        Me.Frame1.TabIndex = 9
        Me.Frame1.TabStop = False
        '
        'optOpcion2
        '
        Me.optOpcion2.BackColor = System.Drawing.SystemColors.Control
        Me.optOpcion2.Cursor = System.Windows.Forms.Cursors.Default
        Me.optOpcion2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optOpcion2.Location = New System.Drawing.Point(16, 56)
        Me.optOpcion2.Name = "optOpcion2"
        Me.optOpcion2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optOpcion2.Size = New System.Drawing.Size(177, 25)
        Me.optOpcion2.TabIndex = 21
        Me.optOpcion2.TabStop = True
        Me.optOpcion2.Text = "Diario General Resumido Tipo 2"
        Me.optOpcion2.UseVisualStyleBackColor = False
        '
        'optOpcion0
        '
        Me.optOpcion0.BackColor = System.Drawing.SystemColors.Control
        Me.optOpcion0.Cursor = System.Windows.Forms.Cursors.Default
        Me.optOpcion0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optOpcion0.Location = New System.Drawing.Point(16, 16)
        Me.optOpcion0.Name = "optOpcion0"
        Me.optOpcion0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optOpcion0.Size = New System.Drawing.Size(153, 25)
        Me.optOpcion0.TabIndex = 0
        Me.optOpcion0.TabStop = True
        Me.optOpcion0.Text = "Diario General Detallado"
        Me.optOpcion0.UseVisualStyleBackColor = False
        '
        'optOpcion1
        '
        Me.optOpcion1.BackColor = System.Drawing.SystemColors.Control
        Me.optOpcion1.Cursor = System.Windows.Forms.Cursors.Default
        Me.optOpcion1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optOpcion1.Location = New System.Drawing.Point(16, 40)
        Me.optOpcion1.Name = "optOpcion1"
        Me.optOpcion1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optOpcion1.Size = New System.Drawing.Size(177, 17)
        Me.optOpcion1.TabIndex = 1
        Me.optOpcion1.TabStop = True
        Me.optOpcion1.Text = "Diario General Resumido Tipo 1"
        Me.optOpcion1.UseVisualStyleBackColor = False
        '
        'fraDetallado
        '
        Me.fraDetallado.BackColor = System.Drawing.SystemColors.Control
        Me.fraDetallado.Controls.Add(Me.DTPickerFecFinal)
        Me.fraDetallado.Controls.Add(Me.DTPickerFecInicio)
        Me.fraDetallado.Controls.Add(Me.Ctr_Ayuda20)
        Me.fraDetallado.Controls.Add(Me.Ctr_Ayuda21)
        Me.fraDetallado.Controls.Add(Me.Label6)
        Me.fraDetallado.Controls.Add(Me.Label5)
        Me.fraDetallado.Controls.Add(Me.Label2)
        Me.fraDetallado.Controls.Add(Me.Label1)
        Me.fraDetallado.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraDetallado.Location = New System.Drawing.Point(0, 137)
        Me.fraDetallado.Name = "fraDetallado"
        Me.fraDetallado.Padding = New System.Windows.Forms.Padding(0)
        Me.fraDetallado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraDetallado.Size = New System.Drawing.Size(343, 121)
        Me.fraDetallado.TabIndex = 8
        Me.fraDetallado.TabStop = False
        Me.fraDetallado.Text = "Diario General Detallado"
        '
        'DTPickerFecFinal
        '
        Me.DTPickerFecFinal.Location = New System.Drawing.Point(86, 37)
        Me.DTPickerFecFinal.Name = "DTPickerFecFinal"
        Me.DTPickerFecFinal.OcxState = CType(resources.GetObject("DTPickerFecFinal.OcxState"), System.Windows.Forms.AxHost.State)
        Me.DTPickerFecFinal.Size = New System.Drawing.Size(165, 20)
        Me.DTPickerFecFinal.TabIndex = 5
        '
        'DTPickerFecInicio
        '
        Me.DTPickerFecInicio.Location = New System.Drawing.Point(87, 15)
        Me.DTPickerFecInicio.Name = "DTPickerFecInicio"
        Me.DTPickerFecInicio.OcxState = CType(resources.GetObject("DTPickerFecInicio.OcxState"), System.Windows.Forms.AxHost.State)
        Me.DTPickerFecInicio.Size = New System.Drawing.Size(164, 20)
        Me.DTPickerFecInicio.TabIndex = 4
        '
        'Ctr_Ayuda20
        '
        Me.Ctr_Ayuda20.Enabled = True
        Me.Ctr_Ayuda20.Location = New System.Drawing.Point(85, 64)
        Me.Ctr_Ayuda20.Name = "Ctr_Ayuda20"
        Me.Ctr_Ayuda20.OcxState = CType(resources.GetObject("Ctr_Ayuda20.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Ctr_Ayuda20.Size = New System.Drawing.Size(254, 22)
        Me.Ctr_Ayuda20.TabIndex = 6
        '
        'Ctr_Ayuda21
        '
        Me.Ctr_Ayuda21.Enabled = True
        Me.Ctr_Ayuda21.Location = New System.Drawing.Point(85, 85)
        Me.Ctr_Ayuda21.Name = "Ctr_Ayuda21"
        Me.Ctr_Ayuda21.OcxState = CType(resources.GetObject("Ctr_Ayuda21.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Ctr_Ayuda21.Size = New System.Drawing.Size(254, 22)
        Me.Ctr_Ayuda21.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(12, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(69, 18)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "SubAsiento"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(13, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(69, 15)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Asiento"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(13, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(71, 19)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Fecha Final"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(13, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Fecha Inicial"
        '
        'fraResumido
        '
        Me.fraResumido.BackColor = System.Drawing.SystemColors.Control
        Me.fraResumido.Controls.Add(Me.Ctr_Ayuda10)
        Me.fraResumido.Controls.Add(Me.Ctr_Ayuda11)
        Me.fraResumido.Controls.Add(Me.Label3)
        Me.fraResumido.Controls.Add(Me.Label4)
        Me.fraResumido.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraResumido.Location = New System.Drawing.Point(0, 137)
        Me.fraResumido.Name = "fraResumido"
        Me.fraResumido.Padding = New System.Windows.Forms.Padding(0)
        Me.fraResumido.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraResumido.Size = New System.Drawing.Size(343, 121)
        Me.fraResumido.TabIndex = 3
        Me.fraResumido.TabStop = False
        Me.fraResumido.Text = "Diario General Resumido"
        '
        'Ctr_Ayuda10
        '
        Me.Ctr_Ayuda10.Enabled = True
        Me.Ctr_Ayuda10.Location = New System.Drawing.Point(85, 29)
        Me.Ctr_Ayuda10.Name = "Ctr_Ayuda10"
        Me.Ctr_Ayuda10.OcxState = CType(resources.GetObject("Ctr_Ayuda10.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Ctr_Ayuda10.Size = New System.Drawing.Size(254, 22)
        Me.Ctr_Ayuda10.TabIndex = 12
        '
        'Ctr_Ayuda11
        '
        Me.Ctr_Ayuda11.Enabled = True
        Me.Ctr_Ayuda11.Location = New System.Drawing.Point(85, 50)
        Me.Ctr_Ayuda11.Name = "Ctr_Ayuda11"
        Me.Ctr_Ayuda11.OcxState = CType(resources.GetObject("Ctr_Ayuda11.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Ctr_Ayuda11.Size = New System.Drawing.Size(254, 22)
        Me.Ctr_Ayuda11.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(12, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(64, 20)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "SubAsiento"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(12, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Asiento"
        '
        'frmRepDiarioGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(362, 329)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.cmdBotones0)
        Me.Controls.Add(Me.cmdBotones1)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.fraDetallado)
        Me.Controls.Add(Me.fraResumido)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRepDiarioGeneral"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Diario General"
        Me.Frame2.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.fraDetallado.ResumeLayout(False)
        CType(Me.DTPickerFecFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTPickerFecInicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ctr_Ayuda20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ctr_Ayuda21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraResumido.ResumeLayout(False)
        CType(Me.Ctr_Ayuda10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ctr_Ayuda11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class