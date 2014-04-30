<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRepMayor
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
    Public WithEvents chkAcumula As System.Windows.Forms.CheckBox
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents cmdBotones0 As System.Windows.Forms.Button
    Public WithEvents cmdBotones1 As System.Windows.Forms.Button
    Public WithEvents Ctr_AyudaSubAsiento As Axctrlayuda_f.AxCtr_Ayuda
    Public WithEvents Ctr_AyudaAsiento As Axctrlayuda_f.AxCtr_Ayuda
    Public WithEvents Ctr_Ayucuenta0 As Axctrlayuda_f.AxCtr_Ayuda
    Public WithEvents DTPickerFecFinal As AxMSComCtl2.AxDTPicker
    Public WithEvents DTPickerFecInicio As AxMSComCtl2.AxDTPicker
    Public WithEvents Ctr_Ayucuenta1 As Axctrlayuda_f.AxCtr_Ayuda
    Public WithEvents Ctr_AyudaEntidad As Axctrlayuda_f.AxCtr_Ayuda
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents fraDetallado As System.Windows.Forms.GroupBox
    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRepMayor))
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.chkAcumula = New System.Windows.Forms.CheckBox()
        Me.cmdBotones0 = New System.Windows.Forms.Button()
        Me.cmdBotones1 = New System.Windows.Forms.Button()
        Me.fraDetallado = New System.Windows.Forms.GroupBox()
        Me.Ctr_AyudaSubAsiento = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Ctr_AyudaAsiento = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Ctr_Ayucuenta0 = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.DTPickerFecFinal = New AxMSComCtl2.AxDTPicker()
        Me.DTPickerFecInicio = New AxMSComCtl2.AxDTPicker()
        Me.Ctr_Ayucuenta1 = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Ctr_AyudaEntidad = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Frame1.SuspendLayout
        Me.fraDetallado.SuspendLayout
        CType(Me.Ctr_AyudaSubAsiento,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Ctr_AyudaAsiento,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Ctr_Ayucuenta0,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DTPickerFecFinal,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DTPickerFecInicio,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Ctr_Ayucuenta1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Ctr_AyudaEntidad,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.chkAcumula)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(0, 1)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(397, 41)
        Me.Frame1.TabIndex = 10
        Me.Frame1.TabStop = false
        '
        'chkAcumula
        '
        Me.chkAcumula.BackColor = System.Drawing.SystemColors.Control
        Me.chkAcumula.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAcumula.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAcumula.Location = New System.Drawing.Point(14, 12)
        Me.chkAcumula.Name = "chkAcumula"
        Me.chkAcumula.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAcumula.Size = New System.Drawing.Size(115, 18)
        Me.chkAcumula.TabIndex = 0
        Me.chkAcumula.Text = "Acumulado"
        Me.chkAcumula.UseVisualStyleBackColor = false
        '
        'cmdBotones0
        '
        Me.cmdBotones0.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBotones0.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBotones0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones0.Location = New System.Drawing.Point(89, 220)
        Me.cmdBotones0.Name = "cmdBotones0"
        Me.cmdBotones0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBotones0.Size = New System.Drawing.Size(106, 36)
        Me.cmdBotones0.TabIndex = 4
        Me.cmdBotones0.Text = "&Aceptar"
        Me.cmdBotones0.UseVisualStyleBackColor = false
        '
        'cmdBotones1
        '
        Me.cmdBotones1.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBotones1.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBotones1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones1.Location = New System.Drawing.Point(213, 220)
        Me.cmdBotones1.Name = "cmdBotones1"
        Me.cmdBotones1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBotones1.Size = New System.Drawing.Size(106, 36)
        Me.cmdBotones1.TabIndex = 5
        Me.cmdBotones1.Text = "&Cancelar"
        Me.cmdBotones1.UseVisualStyleBackColor = false
        '
        'fraDetallado
        '
        Me.fraDetallado.BackColor = System.Drawing.SystemColors.Control
        Me.fraDetallado.Controls.Add(Me.Ctr_AyudaSubAsiento)
        Me.fraDetallado.Controls.Add(Me.Ctr_AyudaAsiento)
        Me.fraDetallado.Controls.Add(Me.Ctr_Ayucuenta0)
        Me.fraDetallado.Controls.Add(Me.DTPickerFecFinal)
        Me.fraDetallado.Controls.Add(Me.DTPickerFecInicio)
        Me.fraDetallado.Controls.Add(Me.Ctr_Ayucuenta1)
        Me.fraDetallado.Controls.Add(Me.Ctr_AyudaEntidad)
        Me.fraDetallado.Controls.Add(Me.Label8)
        Me.fraDetallado.Controls.Add(Me.Label7)
        Me.fraDetallado.Controls.Add(Me.Label6)
        Me.fraDetallado.Controls.Add(Me.Label5)
        Me.fraDetallado.Controls.Add(Me.Label4)
        Me.fraDetallado.Controls.Add(Me.Label3)
        Me.fraDetallado.Controls.Add(Me.Label1)
        Me.fraDetallado.Controls.Add(Me.Label2)
        Me.fraDetallado.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraDetallado.Location = New System.Drawing.Point(0, 39)
        Me.fraDetallado.Name = "fraDetallado"
        Me.fraDetallado.Padding = New System.Windows.Forms.Padding(0)
        Me.fraDetallado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraDetallado.Size = New System.Drawing.Size(397, 175)
        Me.fraDetallado.TabIndex = 6
        Me.fraDetallado.TabStop = false
        '
        'Ctr_AyudaSubAsiento
        '
        Me.Ctr_AyudaSubAsiento.Enabled = true
        Me.Ctr_AyudaSubAsiento.Location = New System.Drawing.Point(69, 143)
        Me.Ctr_AyudaSubAsiento.Name = "Ctr_AyudaSubAsiento"
        Me.Ctr_AyudaSubAsiento.OcxState = CType(resources.GetObject("Ctr_AyudaSubAsiento.OcxState"),System.Windows.Forms.AxHost.State)
        Me.Ctr_AyudaSubAsiento.Size = New System.Drawing.Size(323, 21)
        Me.Ctr_AyudaSubAsiento.TabIndex = 12
        '
        'Ctr_AyudaAsiento
        '
        Me.Ctr_AyudaAsiento.Enabled = true
        Me.Ctr_AyudaAsiento.Location = New System.Drawing.Point(69, 113)
        Me.Ctr_AyudaAsiento.Name = "Ctr_AyudaAsiento"
        Me.Ctr_AyudaAsiento.OcxState = CType(resources.GetObject("Ctr_AyudaAsiento.OcxState"),System.Windows.Forms.AxHost.State)
        Me.Ctr_AyudaAsiento.Size = New System.Drawing.Size(323, 20)
        Me.Ctr_AyudaAsiento.TabIndex = 11
        '
        'Ctr_Ayucuenta0
        '
        Me.Ctr_Ayucuenta0.Enabled = true
        Me.Ctr_Ayucuenta0.Location = New System.Drawing.Point(69, 52)
        Me.Ctr_Ayucuenta0.Name = "Ctr_Ayucuenta0"
        Me.Ctr_Ayucuenta0.OcxState = CType(resources.GetObject("Ctr_Ayucuenta0.OcxState"),System.Windows.Forms.AxHost.State)
        Me.Ctr_Ayucuenta0.Size = New System.Drawing.Size(323, 24)
        Me.Ctr_Ayucuenta0.TabIndex = 3
        '
        'DTPickerFecFinal
        '
        Me.DTPickerFecFinal.Location = New System.Drawing.Point(270, 18)
        Me.DTPickerFecFinal.Name = "DTPickerFecFinal"
        Me.DTPickerFecFinal.OcxState = CType(resources.GetObject("DTPickerFecFinal.OcxState"),System.Windows.Forms.AxHost.State)
        Me.DTPickerFecFinal.Size = New System.Drawing.Size(123, 20)
        Me.DTPickerFecFinal.TabIndex = 2
        '
        'DTPickerFecInicio
        '
        Me.DTPickerFecInicio.Location = New System.Drawing.Point(69, 18)
        Me.DTPickerFecInicio.Name = "DTPickerFecInicio"
        Me.DTPickerFecInicio.OcxState = CType(resources.GetObject("DTPickerFecInicio.OcxState"),System.Windows.Forms.AxHost.State)
        Me.DTPickerFecInicio.Size = New System.Drawing.Size(123, 20)
        Me.DTPickerFecInicio.TabIndex = 1
        '
        'Ctr_Ayucuenta1
        '
        Me.Ctr_Ayucuenta1.Enabled = true
        Me.Ctr_Ayucuenta1.Location = New System.Drawing.Point(69, 75)
        Me.Ctr_Ayucuenta1.Name = "Ctr_Ayucuenta1"
        Me.Ctr_Ayucuenta1.OcxState = CType(resources.GetObject("Ctr_Ayucuenta1.OcxState"),System.Windows.Forms.AxHost.State)
        Me.Ctr_Ayucuenta1.Size = New System.Drawing.Size(323, 24)
        Me.Ctr_Ayucuenta1.TabIndex = 15
        '
        'Ctr_AyudaEntidad
        '
        Me.Ctr_AyudaEntidad.Enabled = true
        Me.Ctr_AyudaEntidad.Location = New System.Drawing.Point(69, 105)
        Me.Ctr_AyudaEntidad.Name = "Ctr_AyudaEntidad"
        Me.Ctr_AyudaEntidad.OcxState = CType(resources.GetObject("Ctr_AyudaEntidad.OcxState"),System.Windows.Forms.AxHost.State)
        Me.Ctr_AyudaEntidad.Size = New System.Drawing.Size(323, 20)
        Me.Ctr_AyudaEntidad.TabIndex = 19
        Me.Ctr_AyudaEntidad.Visible = false
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(6, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(58, 28)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Código Analítico"
        Me.Label8.Visible = false
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(33, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(31, 16)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Hasta"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(33, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Desde"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(5, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(59, 19)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Sub Asiento"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(7, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(62, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Asiento"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(5, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(42, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Cuenta :"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(5, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Fecha Inicial"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(210, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(56, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Fecha Final"
        '
        'frmRepMayor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(419, 276)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.cmdBotones0)
        Me.Controls.Add(Me.cmdBotones1)
        Me.Controls.Add(Me.fraDetallado)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmRepMayor"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "frmReporteParametro"
        Me.Frame1.ResumeLayout(false)
        Me.fraDetallado.ResumeLayout(false)
        CType(Me.Ctr_AyudaSubAsiento,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Ctr_AyudaAsiento,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Ctr_Ayucuenta0,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DTPickerFecFinal,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DTPickerFecInicio,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Ctr_Ayucuenta1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Ctr_AyudaEntidad,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
#End Region 
End Class