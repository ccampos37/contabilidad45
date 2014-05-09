<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FrmLibroDiario
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
    Public WithEvents ctr_ayuAsiento As Axctrlayuda_f.AxCtr_Ayuda
    Public WithEvents ctr_ayuSubasiento As Axctrlayuda_f.AxCtr_Ayuda
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents fraResumido As System.Windows.Forms.GroupBox
    Public WithEvents DTPickerFecFinal As AxMSComCtl2.AxDTPicker
    Public WithEvents DTPickerFecInicio As AxMSComCtl2.AxDTPicker
    Public WithEvents Ctr_Ayuda20 As Axctrlayuda_f.AxCtr_Ayuda
    Public WithEvents Ctr_Ayuda21 As Axctrlayuda_f.AxCtr_Ayuda
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents fraDetallado As System.Windows.Forms.GroupBox
    Public WithEvents optOpcion1 As System.Windows.Forms.RadioButton
    Public WithEvents optOpcion0 As System.Windows.Forms.RadioButton
    Public WithEvents optOpcion2 As System.Windows.Forms.RadioButton
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents cmdBotones1 As System.Windows.Forms.Button
    Public WithEvents cmdBotones0 As System.Windows.Forms.Button
    Public WithEvents cboMes As System.Windows.Forms.ComboBox
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents Ctr_Ayuda1 As AxCtr_AyudaArray
    Public WithEvents Ctr_Ayuda2 As AxCtr_AyudaArray
    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLibroDiario))
        Me.fraResumido = New System.Windows.Forms.GroupBox()
        Me.ctr_ayuAsiento = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.ctr_ayuSubasiento = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fraDetallado = New System.Windows.Forms.GroupBox()
        Me.DTPickerFecFinal = New AxMSComCtl2.AxDTPicker()
        Me.DTPickerFecInicio = New AxMSComCtl2.AxDTPicker()
        Me.Ctr_Ayuda20 = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Ctr_Ayuda21 = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.optOpcion1 = New System.Windows.Forms.RadioButton()
        Me.optOpcion0 = New System.Windows.Forms.RadioButton()
        Me.optOpcion2 = New System.Windows.Forms.RadioButton()
        Me.cmdBotones1 = New System.Windows.Forms.Button()
        Me.cmdBotones0 = New System.Windows.Forms.Button()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.cboMes = New System.Windows.Forms.ComboBox()
        Me.fraResumido.SuspendLayout()
        CType(Me.ctr_ayuAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ctr_ayuSubasiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraDetallado.SuspendLayout()
        CType(Me.DTPickerFecFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTPickerFecInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ctr_Ayuda20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ctr_Ayuda21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.SuspendLayout()
        '
        'fraResumido
        '
        Me.fraResumido.BackColor = System.Drawing.Color.White
        Me.fraResumido.Controls.Add(Me.ctr_ayuAsiento)
        Me.fraResumido.Controls.Add(Me.ctr_ayuSubasiento)
        Me.fraResumido.Controls.Add(Me.Label4)
        Me.fraResumido.Controls.Add(Me.Label3)
        Me.fraResumido.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraResumido.Location = New System.Drawing.Point(6, 169)
        Me.fraResumido.Name = "fraResumido"
        Me.fraResumido.Padding = New System.Windows.Forms.Padding(0)
        Me.fraResumido.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraResumido.Size = New System.Drawing.Size(343, 121)
        Me.fraResumido.TabIndex = 17
        Me.fraResumido.TabStop = False
        Me.fraResumido.Text = "Diario General Resumido"
        '
        'ctr_ayuAsiento
        '
        Me.ctr_ayuAsiento.Enabled = True
        Me.ctr_ayuAsiento.Location = New System.Drawing.Point(88, 25)
        Me.ctr_ayuAsiento.Name = "ctr_ayuAsiento"
        Me.ctr_ayuAsiento.OcxState = CType(resources.GetObject("ctr_ayuAsiento.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ctr_ayuAsiento.Size = New System.Drawing.Size(254, 22)
        Me.ctr_ayuAsiento.TabIndex = 18
        '
        'ctr_ayuSubasiento
        '
        Me.ctr_ayuSubasiento.Enabled = True
        Me.ctr_ayuSubasiento.Location = New System.Drawing.Point(85, 57)
        Me.ctr_ayuSubasiento.Name = "ctr_ayuSubasiento"
        Me.ctr_ayuSubasiento.OcxState = CType(resources.GetObject("ctr_ayuSubasiento.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ctr_ayuSubasiento.Size = New System.Drawing.Size(254, 22)
        Me.ctr_ayuSubasiento.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(12, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Asiento"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(12, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(64, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "SubAsiento"
        '
        'fraDetallado
        '
        Me.fraDetallado.BackColor = System.Drawing.SystemColors.Control
        Me.fraDetallado.Controls.Add(Me.DTPickerFecFinal)
        Me.fraDetallado.Controls.Add(Me.DTPickerFecInicio)
        Me.fraDetallado.Controls.Add(Me.Ctr_Ayuda20)
        Me.fraDetallado.Controls.Add(Me.Ctr_Ayuda21)
        Me.fraDetallado.Controls.Add(Me.Label1)
        Me.fraDetallado.Controls.Add(Me.Label2)
        Me.fraDetallado.Controls.Add(Me.Label5)
        Me.fraDetallado.Controls.Add(Me.Label6)
        Me.fraDetallado.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraDetallado.Location = New System.Drawing.Point(9, 169)
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
        Me.DTPickerFecFinal.TabIndex = 9
        '
        'DTPickerFecInicio
        '
        Me.DTPickerFecInicio.Location = New System.Drawing.Point(87, 15)
        Me.DTPickerFecInicio.Name = "DTPickerFecInicio"
        Me.DTPickerFecInicio.OcxState = CType(resources.GetObject("DTPickerFecInicio.OcxState"), System.Windows.Forms.AxHost.State)
        Me.DTPickerFecInicio.Size = New System.Drawing.Size(164, 20)
        Me.DTPickerFecInicio.TabIndex = 10
        '
        'Ctr_Ayuda20
        '
        Me.Ctr_Ayuda20.Enabled = True
        Me.Ctr_Ayuda20.Location = New System.Drawing.Point(85, 64)
        Me.Ctr_Ayuda20.Name = "Ctr_Ayuda20"
        Me.Ctr_Ayuda20.OcxState = CType(resources.GetObject("Ctr_Ayuda20.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Ctr_Ayuda20.Size = New System.Drawing.Size(254, 22)
        Me.Ctr_Ayuda20.TabIndex = 11
        '
        'Ctr_Ayuda21
        '
        Me.Ctr_Ayuda21.Enabled = True
        Me.Ctr_Ayuda21.Location = New System.Drawing.Point(85, 85)
        Me.Ctr_Ayuda21.Name = "Ctr_Ayuda21"
        Me.Ctr_Ayuda21.OcxState = CType(resources.GetObject("Ctr_Ayuda21.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Ctr_Ayuda21.Size = New System.Drawing.Size(254, 22)
        Me.Ctr_Ayuda21.TabIndex = 12
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
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Fecha Inicial"
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
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Fecha Final"
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
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Asiento"
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
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "SubAsiento"
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.White
        Me.Frame1.Controls.Add(Me.optOpcion1)
        Me.Frame1.Controls.Add(Me.optOpcion0)
        Me.Frame1.Controls.Add(Me.optOpcion2)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(6, 8)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(342, 98)
        Me.Frame1.TabIndex = 4
        Me.Frame1.TabStop = False
        '
        'optOpcion1
        '
        Me.optOpcion1.BackColor = System.Drawing.Color.White
        Me.optOpcion1.Cursor = System.Windows.Forms.Cursors.Default
        Me.optOpcion1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optOpcion1.Location = New System.Drawing.Point(16, 40)
        Me.optOpcion1.Name = "optOpcion1"
        Me.optOpcion1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optOpcion1.Size = New System.Drawing.Size(177, 17)
        Me.optOpcion1.TabIndex = 7
        Me.optOpcion1.TabStop = True
        Me.optOpcion1.Text = "Diario General Resumido Tipo 1"
        Me.optOpcion1.UseVisualStyleBackColor = False
        '
        'optOpcion0
        '
        Me.optOpcion0.BackColor = System.Drawing.Color.White
        Me.optOpcion0.Cursor = System.Windows.Forms.Cursors.Default
        Me.optOpcion0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optOpcion0.Location = New System.Drawing.Point(16, 9)
        Me.optOpcion0.Name = "optOpcion0"
        Me.optOpcion0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optOpcion0.Size = New System.Drawing.Size(153, 25)
        Me.optOpcion0.TabIndex = 6
        Me.optOpcion0.TabStop = True
        Me.optOpcion0.Text = "Diario General Detallado"
        Me.optOpcion0.UseVisualStyleBackColor = False
        '
        'optOpcion2
        '
        Me.optOpcion2.BackColor = System.Drawing.Color.White
        Me.optOpcion2.Cursor = System.Windows.Forms.Cursors.Default
        Me.optOpcion2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optOpcion2.Location = New System.Drawing.Point(16, 63)
        Me.optOpcion2.Name = "optOpcion2"
        Me.optOpcion2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optOpcion2.Size = New System.Drawing.Size(177, 25)
        Me.optOpcion2.TabIndex = 5
        Me.optOpcion2.TabStop = True
        Me.optOpcion2.Text = "Diario General Resumido Tipo 2"
        Me.optOpcion2.UseVisualStyleBackColor = False
        '
        'cmdBotones1
        '
        Me.cmdBotones1.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBotones1.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBotones1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones1.Location = New System.Drawing.Point(198, 296)
        Me.cmdBotones1.Name = "cmdBotones1"
        Me.cmdBotones1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBotones1.Size = New System.Drawing.Size(82, 48)
        Me.cmdBotones1.TabIndex = 3
        Me.cmdBotones1.Text = "&Cancelar"
        Me.cmdBotones1.UseVisualStyleBackColor = False
        '
        'cmdBotones0
        '
        Me.cmdBotones0.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBotones0.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBotones0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones0.Location = New System.Drawing.Point(91, 296)
        Me.cmdBotones0.Name = "cmdBotones0"
        Me.cmdBotones0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBotones0.Size = New System.Drawing.Size(82, 48)
        Me.cmdBotones0.TabIndex = 2
        Me.cmdBotones0.Text = "&Aceptar"
        Me.cmdBotones0.UseVisualStyleBackColor = False
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.Color.White
        Me.Frame2.Controls.Add(Me.cboMes)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(7, 111)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(342, 47)
        Me.Frame2.TabIndex = 0
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Seleccionar Mes"
        '
        'cboMes
        '
        Me.cboMes.BackColor = System.Drawing.SystemColors.Window
        Me.cboMes.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboMes.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboMes.Location = New System.Drawing.Point(8, 17)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboMes.Size = New System.Drawing.Size(330, 21)
        Me.cboMes.TabIndex = 1
        '
        'FrmLibroDiario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(367, 357)
        Me.Controls.Add(Me.fraResumido)
        Me.Controls.Add(Me.fraDetallado)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.cmdBotones1)
        Me.Controls.Add(Me.cmdBotones0)
        Me.Controls.Add(Me.Frame2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "FrmLibroDiario"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Libro Diario"
        Me.fraResumido.ResumeLayout(False)
        CType(Me.ctr_ayuAsiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ctr_ayuSubasiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraDetallado.ResumeLayout(False)
        CType(Me.DTPickerFecFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTPickerFecInicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ctr_Ayuda20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ctr_Ayuda21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class