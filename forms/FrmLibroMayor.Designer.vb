<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FrmLibroMayor
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
    Public WithEvents Ctr_AyudaSubAsiento As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents Ctr_AyudaAsiento As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents _Ctr_Ayucuenta_0 As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents DTPickerFecFinal As AxMSComCtl2.AxDTPicker
	Public WithEvents DTPickerFecInicio As AxMSComCtl2.AxDTPicker
	Public WithEvents _Ctr_Ayucuenta_1 As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents Ctr_AyudaEntidad As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents fraDetallado As System.Windows.Forms.GroupBox
    Public WithEvents cmdBotones1 As System.Windows.Forms.Button
    Public WithEvents cmdBotones0 As System.Windows.Forms.Button
    Public WithEvents chkAcumula As System.Windows.Forms.CheckBox
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents Ctr_Ayucuenta As AxCtr_AyudaArray
    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLibroMayor))
        Me.fraDetallado = New System.Windows.Forms.GroupBox()
        Me.Ctr_AyudaSubAsiento = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Ctr_AyudaAsiento = New Axctrlayuda_f.AxCtr_Ayuda()
        Me._Ctr_Ayucuenta_0 = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.DTPickerFecFinal = New AxMSComCtl2.AxDTPicker()
        Me.DTPickerFecInicio = New AxMSComCtl2.AxDTPicker()
        Me._Ctr_Ayucuenta_1 = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Ctr_AyudaEntidad = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdBotones1 = New System.Windows.Forms.Button()
        Me.cmdBotones0 = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.chkAcumula = New System.Windows.Forms.CheckBox()
        Me.Ctr_Ayucuenta = New Contabilidad.AxCtr_AyudaArray(Me.components)
        Me.fraDetallado.SuspendLayout()
        CType(Me.Ctr_AyudaSubAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ctr_AyudaAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Ctr_Ayucuenta_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTPickerFecFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTPickerFecInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Ctr_Ayucuenta_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ctr_AyudaEntidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        CType(Me.Ctr_Ayucuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fraDetallado
        '
        Me.fraDetallado.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fraDetallado.Controls.Add(Me.Ctr_AyudaSubAsiento)
        Me.fraDetallado.Controls.Add(Me.Ctr_AyudaAsiento)
        Me.fraDetallado.Controls.Add(Me._Ctr_Ayucuenta_0)
        Me.fraDetallado.Controls.Add(Me.DTPickerFecFinal)
        Me.fraDetallado.Controls.Add(Me.DTPickerFecInicio)
        Me.fraDetallado.Controls.Add(Me._Ctr_Ayucuenta_1)
        Me.fraDetallado.Controls.Add(Me.Ctr_AyudaEntidad)
        Me.fraDetallado.Controls.Add(Me.Label2)
        Me.fraDetallado.Controls.Add(Me.Label1)
        Me.fraDetallado.Controls.Add(Me.Label3)
        Me.fraDetallado.Controls.Add(Me.Label4)
        Me.fraDetallado.Controls.Add(Me.Label5)
        Me.fraDetallado.Controls.Add(Me.Label6)
        Me.fraDetallado.Controls.Add(Me.Label7)
        Me.fraDetallado.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraDetallado.Location = New System.Drawing.Point(16, 62)
        Me.fraDetallado.Name = "fraDetallado"
        Me.fraDetallado.Padding = New System.Windows.Forms.Padding(0)
        Me.fraDetallado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraDetallado.Size = New System.Drawing.Size(397, 159)
        Me.fraDetallado.TabIndex = 4
        Me.fraDetallado.TabStop = False
        '
        'Ctr_AyudaSubAsiento
        '
        Me.Ctr_AyudaSubAsiento.Enabled = True
        Me.Ctr_AyudaSubAsiento.Location = New System.Drawing.Point(69, 127)
        Me.Ctr_AyudaSubAsiento.Name = "Ctr_AyudaSubAsiento"
        Me.Ctr_AyudaSubAsiento.OcxState = CType(resources.GetObject("Ctr_AyudaSubAsiento.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Ctr_AyudaSubAsiento.Size = New System.Drawing.Size(323, 21)
        Me.Ctr_AyudaSubAsiento.TabIndex = 5
        '
        'Ctr_AyudaAsiento
        '
        Me.Ctr_AyudaAsiento.Enabled = True
        Me.Ctr_AyudaAsiento.Location = New System.Drawing.Point(69, 105)
        Me.Ctr_AyudaAsiento.Name = "Ctr_AyudaAsiento"
        Me.Ctr_AyudaAsiento.OcxState = CType(resources.GetObject("Ctr_AyudaAsiento.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Ctr_AyudaAsiento.Size = New System.Drawing.Size(323, 20)
        Me.Ctr_AyudaAsiento.TabIndex = 6
        '
        '_Ctr_Ayucuenta_0
        '
        Me._Ctr_Ayucuenta_0.Enabled = True
        Me.Ctr_Ayucuenta.SetIndex(Me._Ctr_Ayucuenta_0, CType(0, Short))
        Me._Ctr_Ayucuenta_0.Location = New System.Drawing.Point(69, 52)
        Me._Ctr_Ayucuenta_0.Name = "_Ctr_Ayucuenta_0"
        Me._Ctr_Ayucuenta_0.OcxState = CType(resources.GetObject("_Ctr_Ayucuenta_0.OcxState"), System.Windows.Forms.AxHost.State)
        Me._Ctr_Ayucuenta_0.Size = New System.Drawing.Size(323, 24)
        Me._Ctr_Ayucuenta_0.TabIndex = 7
        '
        'DTPickerFecFinal
        '
        Me.DTPickerFecFinal.Location = New System.Drawing.Point(270, 18)
        Me.DTPickerFecFinal.Name = "DTPickerFecFinal"
        Me.DTPickerFecFinal.OcxState = CType(resources.GetObject("DTPickerFecFinal.OcxState"), System.Windows.Forms.AxHost.State)
        Me.DTPickerFecFinal.Size = New System.Drawing.Size(123, 20)
        Me.DTPickerFecFinal.TabIndex = 8
        '
        'DTPickerFecInicio
        '
        Me.DTPickerFecInicio.Location = New System.Drawing.Point(69, 18)
        Me.DTPickerFecInicio.Name = "DTPickerFecInicio"
        Me.DTPickerFecInicio.OcxState = CType(resources.GetObject("DTPickerFecInicio.OcxState"), System.Windows.Forms.AxHost.State)
        Me.DTPickerFecInicio.Size = New System.Drawing.Size(123, 20)
        Me.DTPickerFecInicio.TabIndex = 9
        '
        '_Ctr_Ayucuenta_1
        '
        Me._Ctr_Ayucuenta_1.Enabled = True
        Me.Ctr_Ayucuenta.SetIndex(Me._Ctr_Ayucuenta_1, CType(1, Short))
        Me._Ctr_Ayucuenta_1.Location = New System.Drawing.Point(69, 75)
        Me._Ctr_Ayucuenta_1.Name = "_Ctr_Ayucuenta_1"
        Me._Ctr_Ayucuenta_1.OcxState = CType(resources.GetObject("_Ctr_Ayucuenta_1.OcxState"), System.Windows.Forms.AxHost.State)
        Me._Ctr_Ayucuenta_1.Size = New System.Drawing.Size(323, 24)
        Me._Ctr_Ayucuenta_1.TabIndex = 10
        '
        'Ctr_AyudaEntidad
        '
        Me.Ctr_AyudaEntidad.Enabled = True
        Me.Ctr_AyudaEntidad.Location = New System.Drawing.Point(69, 105)
        Me.Ctr_AyudaEntidad.Name = "Ctr_AyudaEntidad"
        Me.Ctr_AyudaEntidad.OcxState = CType(resources.GetObject("Ctr_AyudaEntidad.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Ctr_AyudaEntidad.Size = New System.Drawing.Size(323, 20)
        Me.Ctr_AyudaEntidad.TabIndex = 11
        Me.Ctr_AyudaEntidad.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(210, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(56, 19)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Fecha Final"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(5, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Fecha Inicial"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(5, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(42, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Cuenta :"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(7, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(62, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Asiento"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(5, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(59, 19)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Sub Asiento"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(33, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Desde"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(33, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(31, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Hasta"
        '
        'cmdBotones1
        '
        Me.cmdBotones1.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBotones1.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBotones1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones1.Location = New System.Drawing.Point(229, 247)
        Me.cmdBotones1.Name = "cmdBotones1"
        Me.cmdBotones1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBotones1.Size = New System.Drawing.Size(112, 44)
        Me.cmdBotones1.TabIndex = 3
        Me.cmdBotones1.Text = "&Cancelar"
        Me.cmdBotones1.UseVisualStyleBackColor = False
        '
        'cmdBotones0
        '
        Me.cmdBotones0.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBotones0.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBotones0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones0.Location = New System.Drawing.Point(52, 247)
        Me.cmdBotones0.Name = "cmdBotones0"
        Me.cmdBotones0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBotones0.Size = New System.Drawing.Size(112, 44)
        Me.cmdBotones0.TabIndex = 2
        Me.cmdBotones0.Text = "&Aceptar"
        Me.cmdBotones0.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame1.Controls.Add(Me.chkAcumula)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(16, 24)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(397, 41)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        '
        'chkAcumula
        '
        Me.chkAcumula.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkAcumula.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAcumula.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAcumula.Location = New System.Drawing.Point(14, 12)
        Me.chkAcumula.Name = "chkAcumula"
        Me.chkAcumula.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAcumula.Size = New System.Drawing.Size(115, 18)
        Me.chkAcumula.TabIndex = 1
        Me.chkAcumula.Text = "Acumulado"
        Me.chkAcumula.UseVisualStyleBackColor = False
        '
        'FrmLibroMayor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(439, 309)
        Me.Controls.Add(Me.fraDetallado)
        Me.Controls.Add(Me.cmdBotones1)
        Me.Controls.Add(Me.cmdBotones0)
        Me.Controls.Add(Me.Frame1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "FrmLibroMayor"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Libro Mayor"
        Me.fraDetallado.ResumeLayout(False)
        CType(Me.Ctr_AyudaSubAsiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ctr_AyudaAsiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Ctr_Ayucuenta_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTPickerFecFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTPickerFecInicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Ctr_Ayucuenta_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ctr_AyudaEntidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        CType(Me.Ctr_Ayucuenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class