<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRepPlanCuentasSaldosIniciales
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
    Public WithEvents Option10 As System.Windows.Forms.RadioButton
    Public WithEvents Option11 As System.Windows.Forms.RadioButton
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents Ctr_Ayuda1 As Axctrlayuda_f.AxCtr_Ayuda
    Public WithEvents Frame3 As System.Windows.Forms.GroupBox
    Public WithEvents cboNiveles As System.Windows.Forms.ComboBox
    Public WithEvents Option20 As System.Windows.Forms.RadioButton
    Public WithEvents Option21 As System.Windows.Forms.RadioButton
    Public WithEvents Frame4 As System.Windows.Forms.GroupBox
    Public WithEvents _cmdBotones_0 As System.Windows.Forms.Button
    Public WithEvents _cmdBotones_1 As System.Windows.Forms.Button
    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRepPlanCuentasSaldosIniciales))
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.Option10 = New System.Windows.Forms.RadioButton()
        Me.Option11 = New System.Windows.Forms.RadioButton()
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me.Ctr_Ayuda1 = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Frame4 = New System.Windows.Forms.GroupBox()
        Me.cboNiveles = New System.Windows.Forms.ComboBox()
        Me.Option20 = New System.Windows.Forms.RadioButton()
        Me.Option21 = New System.Windows.Forms.RadioButton()
        Me._cmdBotones_0 = New System.Windows.Forms.Button()
        Me._cmdBotones_1 = New System.Windows.Forms.Button()
        Me.Frame1.SuspendLayout()
        Me.Frame3.SuspendLayout()
        CType(Me.Ctr_Ayuda1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.Option10)
        Me.Frame1.Controls.Add(Me.Option11)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(0, 17)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(376, 59)
        Me.Frame1.TabIndex = 8
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Tipo Impresión"
        '
        'Option10
        '
        Me.Option10.BackColor = System.Drawing.SystemColors.Control
        Me.Option10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Option10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Option10.Location = New System.Drawing.Point(9, 18)
        Me.Option10.Name = "Option10"
        Me.Option10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Option10.Size = New System.Drawing.Size(161, 15)
        Me.Option10.TabIndex = 10
        Me.Option10.TabStop = True
        Me.Option10.Text = "Plan de Cuentas Total"
        Me.Option10.UseVisualStyleBackColor = False
        '
        'Option11
        '
        Me.Option11.BackColor = System.Drawing.SystemColors.Control
        Me.Option11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Option11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Option11.Location = New System.Drawing.Point(8, 36)
        Me.Option11.Name = "Option11"
        Me.Option11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Option11.Size = New System.Drawing.Size(161, 15)
        Me.Option11.TabIndex = 9
        Me.Option11.TabStop = True
        Me.Option11.Text = "Plan de Cuentas Resumido"
        Me.Option11.UseVisualStyleBackColor = False
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.Add(Me.Ctr_Ayuda1)
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(0, 170)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(376, 47)
        Me.Frame3.TabIndex = 6
        Me.Frame3.TabStop = False
        Me.Frame3.Text = "Cuenta Contable"
        '
        'Ctr_Ayuda1
        '
        Me.Ctr_Ayuda1.Enabled = True
        Me.Ctr_Ayuda1.Location = New System.Drawing.Point(4, 15)
        Me.Ctr_Ayuda1.Name = "Ctr_Ayuda1"
        Me.Ctr_Ayuda1.OcxState = CType(resources.GetObject("Ctr_Ayuda1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Ctr_Ayuda1.Size = New System.Drawing.Size(368, 22)
        Me.Ctr_Ayuda1.TabIndex = 7
        '
        'Frame4
        '
        Me.Frame4.BackColor = System.Drawing.SystemColors.Control
        Me.Frame4.Controls.Add(Me.cboNiveles)
        Me.Frame4.Controls.Add(Me.Option20)
        Me.Frame4.Controls.Add(Me.Option21)
        Me.Frame4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame4.Location = New System.Drawing.Point(0, 98)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame4.Size = New System.Drawing.Size(376, 61)
        Me.Frame4.TabIndex = 2
        Me.Frame4.TabStop = False
        Me.Frame4.Text = "Parámetros de Impresión"
        '
        'cboNiveles
        '
        Me.cboNiveles.BackColor = System.Drawing.SystemColors.Window
        Me.cboNiveles.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboNiveles.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboNiveles.Location = New System.Drawing.Point(156, 18)
        Me.cboNiveles.Name = "cboNiveles"
        Me.cboNiveles.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboNiveles.Size = New System.Drawing.Size(216, 21)
        Me.cboNiveles.TabIndex = 5
        '
        'Option20
        '
        Me.Option20.BackColor = System.Drawing.SystemColors.Control
        Me.Option20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Option20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Option20.Location = New System.Drawing.Point(7, 20)
        Me.Option20.Name = "Option20"
        Me.Option20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Option20.Size = New System.Drawing.Size(106, 16)
        Me.Option20.TabIndex = 4
        Me.Option20.TabStop = True
        Me.Option20.Text = "Niveles"
        Me.Option20.UseVisualStyleBackColor = False
        '
        'Option21
        '
        Me.Option21.BackColor = System.Drawing.SystemColors.Control
        Me.Option21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Option21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Option21.Location = New System.Drawing.Point(6, 37)
        Me.Option21.Name = "Option21"
        Me.Option21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Option21.Size = New System.Drawing.Size(106, 16)
        Me.Option21.TabIndex = 3
        Me.Option21.TabStop = True
        Me.Option21.Text = "Estructurado"
        Me.Option21.UseVisualStyleBackColor = False
        '
        '_cmdBotones_0
        '
        Me._cmdBotones_0.BackColor = System.Drawing.SystemColors.Control
        Me._cmdBotones_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdBotones_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdBotones_0.Location = New System.Drawing.Point(109, 232)
        Me._cmdBotones_0.Name = "_cmdBotones_0"
        Me._cmdBotones_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdBotones_0.Size = New System.Drawing.Size(71, 22)
        Me._cmdBotones_0.TabIndex = 1
        Me._cmdBotones_0.Text = "&Aceptar"
        Me._cmdBotones_0.UseVisualStyleBackColor = False
        '
        '_cmdBotones_1
        '
        Me._cmdBotones_1.BackColor = System.Drawing.SystemColors.Control
        Me._cmdBotones_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdBotones_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._cmdBotones_1.Location = New System.Drawing.Point(196, 232)
        Me._cmdBotones_1.Name = "_cmdBotones_1"
        Me._cmdBotones_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdBotones_1.Size = New System.Drawing.Size(71, 22)
        Me._cmdBotones_1.TabIndex = 0
        Me._cmdBotones_1.Text = "&Cancelar"
        Me._cmdBotones_1.UseVisualStyleBackColor = False
        '
        'frmRepPlanCuentasSaldosIniciales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(376, 265)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.Frame4)
        Me.Controls.Add(Me._cmdBotones_0)
        Me.Controls.Add(Me._cmdBotones_1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRepPlanCuentasSaldosIniciales"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Saldos Iniciales"
        Me.Frame1.ResumeLayout(False)
        Me.Frame3.ResumeLayout(False)
        CType(Me.Ctr_Ayuda1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class