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
	Public WithEvents _cmdBotones_0 As System.Windows.Forms.Button
	Public WithEvents _cmdBotones_1 As System.Windows.Forms.Button
	Public WithEvents _optOpcion_2 As System.Windows.Forms.RadioButton
	Public WithEvents _optOpcion_0 As System.Windows.Forms.RadioButton
	Public WithEvents _optOpcion_1 As System.Windows.Forms.RadioButton
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents DTPickerFecFinal As AxMSComCtl2.AxDTPicker
	Public WithEvents DTPickerFecInicio As AxMSComCtl2.AxDTPicker
	Public WithEvents _Ctr_Ayuda2_0 As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents _Ctr_Ayuda2_1 As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents fraDetallado As System.Windows.Forms.GroupBox
	Public WithEvents _Ctr_Ayuda1_0 As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents _Ctr_Ayuda1_1 As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents fraResumido As System.Windows.Forms.GroupBox
	Public WithEvents Ctr_Ayuda1 As AxCtr_AyudaArray
	Public WithEvents Ctr_Ayuda2 As AxCtr_AyudaArray
	Public WithEvents cmdBotones As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
	Public WithEvents optOpcion As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRepDiarioGeneral))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.cboMes = New System.Windows.Forms.ComboBox()
        Me._cmdBotones_0 = New System.Windows.Forms.Button()
        Me._cmdBotones_1 = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me._optOpcion_2 = New System.Windows.Forms.RadioButton()
        Me._optOpcion_0 = New System.Windows.Forms.RadioButton()
        Me._optOpcion_1 = New System.Windows.Forms.RadioButton()
        Me.fraDetallado = New System.Windows.Forms.GroupBox()
        Me.DTPickerFecFinal = New AxMSComCtl2.AxDTPicker()
        Me.DTPickerFecInicio = New AxMSComCtl2.AxDTPicker()
        Me._Ctr_Ayuda2_0 = New Axctrlayuda_f.AxCtr_Ayuda()
        Me._Ctr_Ayuda2_1 = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fraResumido = New System.Windows.Forms.GroupBox()
        Me._Ctr_Ayuda1_0 = New Axctrlayuda_f.AxCtr_Ayuda()
        Me._Ctr_Ayuda1_1 = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdBotones = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(Me.components)
        Me.optOpcion = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
        Me.Frame2.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.fraDetallado.SuspendLayout()
        CType(Me.DTPickerFecFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTPickerFecInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Ctr_Ayuda2_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Ctr_Ayuda2_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraResumido.SuspendLayout()
        CType(Me._Ctr_Ayuda1_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Ctr_Ayuda1_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdBotones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.optOpcion, System.ComponentModel.ISupportInitialize).BeginInit()
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
        '_cmdBotones_0
        '
        Me._cmdBotones_0.BackColor = System.Drawing.SystemColors.Control
        Me._cmdBotones_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdBotones_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones.SetIndex(Me._cmdBotones_0, CType(0, Short))
        Me._cmdBotones_0.Location = New System.Drawing.Point(78, 284)
        Me._cmdBotones_0.Name = "_cmdBotones_0"
        Me._cmdBotones_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdBotones_0.Size = New System.Drawing.Size(82, 23)
        Me._cmdBotones_0.TabIndex = 16
        Me._cmdBotones_0.Text = "&Aceptar"
        Me._cmdBotones_0.UseVisualStyleBackColor = False
        '
        '_cmdBotones_1
        '
        Me._cmdBotones_1.BackColor = System.Drawing.SystemColors.Control
        Me._cmdBotones_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdBotones_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones.SetIndex(Me._cmdBotones_1, CType(1, Short))
        Me._cmdBotones_1.Location = New System.Drawing.Point(185, 284)
        Me._cmdBotones_1.Name = "_cmdBotones_1"
        Me._cmdBotones_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdBotones_1.Size = New System.Drawing.Size(82, 23)
        Me._cmdBotones_1.TabIndex = 15
        Me._cmdBotones_1.Text = "&Cancelar"
        Me._cmdBotones_1.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me._optOpcion_2)
        Me.Frame1.Controls.Add(Me._optOpcion_0)
        Me.Frame1.Controls.Add(Me._optOpcion_1)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(0, -4)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(342, 84)
        Me.Frame1.TabIndex = 9
        Me.Frame1.TabStop = False
        '
        '_optOpcion_2
        '
        Me._optOpcion_2.BackColor = System.Drawing.SystemColors.Control
        Me._optOpcion_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._optOpcion_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optOpcion.SetIndex(Me._optOpcion_2, CType(2, Short))
        Me._optOpcion_2.Location = New System.Drawing.Point(16, 56)
        Me._optOpcion_2.Name = "_optOpcion_2"
        Me._optOpcion_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optOpcion_2.Size = New System.Drawing.Size(177, 25)
        Me._optOpcion_2.TabIndex = 21
        Me._optOpcion_2.TabStop = True
        Me._optOpcion_2.Text = "Diario General Resumido Tipo 2"
        Me._optOpcion_2.UseVisualStyleBackColor = False
        '
        '_optOpcion_0
        '
        Me._optOpcion_0.BackColor = System.Drawing.SystemColors.Control
        Me._optOpcion_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._optOpcion_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optOpcion.SetIndex(Me._optOpcion_0, CType(0, Short))
        Me._optOpcion_0.Location = New System.Drawing.Point(16, 16)
        Me._optOpcion_0.Name = "_optOpcion_0"
        Me._optOpcion_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optOpcion_0.Size = New System.Drawing.Size(153, 25)
        Me._optOpcion_0.TabIndex = 0
        Me._optOpcion_0.TabStop = True
        Me._optOpcion_0.Text = "Diario General Detallado"
        Me._optOpcion_0.UseVisualStyleBackColor = False
        '
        '_optOpcion_1
        '
        Me._optOpcion_1.BackColor = System.Drawing.SystemColors.Control
        Me._optOpcion_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._optOpcion_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optOpcion.SetIndex(Me._optOpcion_1, CType(1, Short))
        Me._optOpcion_1.Location = New System.Drawing.Point(16, 40)
        Me._optOpcion_1.Name = "_optOpcion_1"
        Me._optOpcion_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._optOpcion_1.Size = New System.Drawing.Size(177, 17)
        Me._optOpcion_1.TabIndex = 1
        Me._optOpcion_1.TabStop = True
        Me._optOpcion_1.Text = "Diario General Resumido Tipo 1"
        Me._optOpcion_1.UseVisualStyleBackColor = False
        '
        'fraDetallado
        '
        Me.fraDetallado.BackColor = System.Drawing.SystemColors.Control
        Me.fraDetallado.Controls.Add(Me.DTPickerFecFinal)
        Me.fraDetallado.Controls.Add(Me.DTPickerFecInicio)
        Me.fraDetallado.Controls.Add(Me._Ctr_Ayuda2_0)
        Me.fraDetallado.Controls.Add(Me._Ctr_Ayuda2_1)
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
        '_Ctr_Ayuda2_0
        '
        Me._Ctr_Ayuda2_0.Enabled = True
        Me._Ctr_Ayuda2_0.Location = New System.Drawing.Point(85, 64)
        Me._Ctr_Ayuda2_0.Name = "_Ctr_Ayuda2_0"
        Me._Ctr_Ayuda2_0.OcxState = CType(resources.GetObject("_Ctr_Ayuda2_0.OcxState"), System.Windows.Forms.AxHost.State)
        Me._Ctr_Ayuda2_0.Size = New System.Drawing.Size(254, 22)
        Me._Ctr_Ayuda2_0.TabIndex = 6
        '
        '_Ctr_Ayuda2_1
        '
        Me._Ctr_Ayuda2_1.Enabled = True
        Me._Ctr_Ayuda2_1.Location = New System.Drawing.Point(85, 85)
        Me._Ctr_Ayuda2_1.Name = "_Ctr_Ayuda2_1"
        Me._Ctr_Ayuda2_1.OcxState = CType(resources.GetObject("_Ctr_Ayuda2_1.OcxState"), System.Windows.Forms.AxHost.State)
        Me._Ctr_Ayuda2_1.Size = New System.Drawing.Size(254, 22)
        Me._Ctr_Ayuda2_1.TabIndex = 7
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
        Me.fraResumido.Controls.Add(Me._Ctr_Ayuda1_0)
        Me.fraResumido.Controls.Add(Me._Ctr_Ayuda1_1)
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
        '_Ctr_Ayuda1_0
        '
        Me._Ctr_Ayuda1_0.Enabled = True
        Me._Ctr_Ayuda1_0.Location = New System.Drawing.Point(85, 29)
        Me._Ctr_Ayuda1_0.Name = "_Ctr_Ayuda1_0"
        Me._Ctr_Ayuda1_0.OcxState = CType(resources.GetObject("_Ctr_Ayuda1_0.OcxState"), System.Windows.Forms.AxHost.State)
        Me._Ctr_Ayuda1_0.Size = New System.Drawing.Size(254, 22)
        Me._Ctr_Ayuda1_0.TabIndex = 12
        '
        '_Ctr_Ayuda1_1
        '
        Me._Ctr_Ayuda1_1.Enabled = True
        Me._Ctr_Ayuda1_1.Location = New System.Drawing.Point(85, 50)
        Me._Ctr_Ayuda1_1.Name = "_Ctr_Ayuda1_1"
        Me._Ctr_Ayuda1_1.OcxState = CType(resources.GetObject("_Ctr_Ayuda1_1.OcxState"), System.Windows.Forms.AxHost.State)
        Me._Ctr_Ayuda1_1.Size = New System.Drawing.Size(254, 22)
        Me._Ctr_Ayuda1_1.TabIndex = 13
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
        'cmdBotones
        '
        '
        'optOpcion
        '
        '
        'frmRepDiarioGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(362, 329)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me._cmdBotones_0)
        Me.Controls.Add(Me._cmdBotones_1)
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
        CType(Me._Ctr_Ayuda2_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Ctr_Ayuda2_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraResumido.ResumeLayout(False)
        CType(Me._Ctr_Ayuda1_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Ctr_Ayuda1_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdBotones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.optOpcion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class