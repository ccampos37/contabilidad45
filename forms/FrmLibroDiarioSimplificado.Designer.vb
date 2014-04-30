<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FrmLibroDiarioSimplificado
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
    Public WithEvents cboMes As System.Windows.Forms.ComboBox
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents cmdImprimir As System.Windows.Forms.Button
	Public WithEvents cmdSalir As System.Windows.Forms.Button
    Public WithEvents optOpcion0 As System.Windows.Forms.RadioButton
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
    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLibroDiarioSimplificado))
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.cboMes = New System.Windows.Forms.ComboBox()
        Me.cmdImprimir = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.optOpcion0 = New System.Windows.Forms.RadioButton()
        Me.fraDetallado = New System.Windows.Forms.GroupBox()
        Me.DTPickerFecFinal = New AxMSComCtl2.AxDTPicker()
        Me.DTPickerFecInicio = New AxMSComCtl2.AxDTPicker()
        Me.Ctr_Ayuda20 = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Ctr_Ayuda21 = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Frame2.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.fraDetallado.SuspendLayout()
        CType(Me.DTPickerFecFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTPickerFecInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ctr_Ayuda20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ctr_Ayuda21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.Color.White
        Me.Frame2.Controls.Add(Me.cboMes)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(16, 61)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(342, 47)
        Me.Frame2.TabIndex = 13
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
        Me.cboMes.TabIndex = 14
        '
        'cmdImprimir
        '
        Me.cmdImprimir.BackColor = System.Drawing.SystemColors.Control
        Me.cmdImprimir.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdImprimir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdImprimir.Location = New System.Drawing.Point(94, 248)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdImprimir.Size = New System.Drawing.Size(82, 23)
        Me.cmdImprimir.TabIndex = 12
        Me.cmdImprimir.Text = "&Aceptar"
        Me.cmdImprimir.UseVisualStyleBackColor = False
        '
        'cmdSalir
        '
        Me.cmdSalir.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSalir.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSalir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSalir.Location = New System.Drawing.Point(201, 248)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSalir.Size = New System.Drawing.Size(82, 23)
        Me.cmdSalir.TabIndex = 11
        Me.cmdSalir.Text = "&Cancelar"
        Me.cmdSalir.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.White
        Me.Frame1.Controls.Add(Me.optOpcion0)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(16, 16)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(342, 44)
        Me.Frame1.TabIndex = 9
        Me.Frame1.TabStop = False
        '
        'optOpcion0
        '
        Me.optOpcion0.BackColor = System.Drawing.Color.White
        Me.optOpcion0.Cursor = System.Windows.Forms.Cursors.Default
        Me.optOpcion0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optOpcion0.Location = New System.Drawing.Point(16, 16)
        Me.optOpcion0.Name = "optOpcion0"
        Me.optOpcion0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optOpcion0.Size = New System.Drawing.Size(153, 25)
        Me.optOpcion0.TabIndex = 10
        Me.optOpcion0.TabStop = True
        Me.optOpcion0.Text = "Diario General Detallado"
        Me.optOpcion0.UseVisualStyleBackColor = False
        '
        'fraDetallado
        '
        Me.fraDetallado.BackColor = System.Drawing.Color.White
        Me.fraDetallado.Controls.Add(Me.DTPickerFecFinal)
        Me.fraDetallado.Controls.Add(Me.DTPickerFecInicio)
        Me.fraDetallado.Controls.Add(Me.Ctr_Ayuda20)
        Me.fraDetallado.Controls.Add(Me.Ctr_Ayuda21)
        Me.fraDetallado.Controls.Add(Me.Label6)
        Me.fraDetallado.Controls.Add(Me.Label5)
        Me.fraDetallado.Controls.Add(Me.Label2)
        Me.fraDetallado.Controls.Add(Me.Label1)
        Me.fraDetallado.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraDetallado.Location = New System.Drawing.Point(16, 109)
        Me.fraDetallado.Name = "fraDetallado"
        Me.fraDetallado.Padding = New System.Windows.Forms.Padding(0)
        Me.fraDetallado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraDetallado.Size = New System.Drawing.Size(343, 121)
        Me.fraDetallado.TabIndex = 0
        Me.fraDetallado.TabStop = False
        Me.fraDetallado.Text = "Diario General Detallado"
        '
        'DTPickerFecFinal
        '
        Me.DTPickerFecFinal.Location = New System.Drawing.Point(86, 37)
        Me.DTPickerFecFinal.Name = "DTPickerFecFinal"
        Me.DTPickerFecFinal.OcxState = CType(resources.GetObject("DTPickerFecFinal.OcxState"), System.Windows.Forms.AxHost.State)
        Me.DTPickerFecFinal.Size = New System.Drawing.Size(165, 20)
        Me.DTPickerFecFinal.TabIndex = 1
        '
        'DTPickerFecInicio
        '
        Me.DTPickerFecInicio.Location = New System.Drawing.Point(87, 15)
        Me.DTPickerFecInicio.Name = "DTPickerFecInicio"
        Me.DTPickerFecInicio.OcxState = CType(resources.GetObject("DTPickerFecInicio.OcxState"), System.Windows.Forms.AxHost.State)
        Me.DTPickerFecInicio.Size = New System.Drawing.Size(164, 20)
        Me.DTPickerFecInicio.TabIndex = 2
        '
        'Ctr_Ayuda20
        '
        Me.Ctr_Ayuda20.Enabled = True
        Me.Ctr_Ayuda20.Location = New System.Drawing.Point(85, 64)
        Me.Ctr_Ayuda20.Name = "Ctr_Ayuda20"
        Me.Ctr_Ayuda20.OcxState = CType(resources.GetObject("Ctr_Ayuda20.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Ctr_Ayuda20.Size = New System.Drawing.Size(254, 22)
        Me.Ctr_Ayuda20.TabIndex = 3
        '
        'Ctr_Ayuda21
        '
        Me.Ctr_Ayuda21.Enabled = True
        Me.Ctr_Ayuda21.Location = New System.Drawing.Point(85, 85)
        Me.Ctr_Ayuda21.Name = "Ctr_Ayuda21"
        Me.Ctr_Ayuda21.OcxState = CType(resources.GetObject("Ctr_Ayuda21.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Ctr_Ayuda21.Size = New System.Drawing.Size(254, 22)
        Me.Ctr_Ayuda21.TabIndex = 4
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
        Me.Label6.TabIndex = 8
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
        Me.Label5.TabIndex = 7
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
        Me.Label2.TabIndex = 6
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
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Fecha Inicial"
        '
        'FrmLibroDiarioSimplificado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(386, 303)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.cmdImprimir)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.fraDetallado)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(8, 31)
        Me.Name = "FrmLibroDiarioSimplificado"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Libro diario simplificado"
        Me.Frame2.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.fraDetallado.ResumeLayout(False)
        CType(Me.DTPickerFecFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTPickerFecInicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ctr_Ayuda20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ctr_Ayuda21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class