<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRepPlanCuentas
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
    Public WithEvents cmdBotones0 As System.Windows.Forms.Button
    Public WithEvents cmdBotones1 As System.Windows.Forms.Button
    Public WithEvents Ctr_Ayuda1 As Axctrlayuda_f.AxCtr_Ayuda
    Public WithEvents Frame3 As System.Windows.Forms.GroupBox
    Public WithEvents cboNiveles As System.Windows.Forms.ComboBox
    Public WithEvents Option21 As System.Windows.Forms.RadioButton
    Public WithEvents Option20 As System.Windows.Forms.RadioButton
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents Option10 As System.Windows.Forms.RadioButton
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRepPlanCuentas))
        Me.cmdBotones0 = New System.Windows.Forms.Button()
        Me.cmdBotones1 = New System.Windows.Forms.Button()
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me.Ctr_Ayuda1 = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.cboNiveles = New System.Windows.Forms.ComboBox()
        Me.Option21 = New System.Windows.Forms.RadioButton()
        Me.Option20 = New System.Windows.Forms.RadioButton()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.Option10 = New System.Windows.Forms.RadioButton()
        Me.Frame3.SuspendLayout()
        CType(Me.Ctr_Ayuda1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame2.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdBotones0
        '
        Me.cmdBotones0.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBotones0.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBotones0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones0.Location = New System.Drawing.Point(105, 231)
        Me.cmdBotones0.Name = "cmdBotones0"
        Me.cmdBotones0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBotones0.Size = New System.Drawing.Size(74, 23)
        Me.cmdBotones0.TabIndex = 9
        Me.cmdBotones0.Text = "&Aceptar"
        Me.cmdBotones0.UseVisualStyleBackColor = False
        '
        'cmdBotones1
        '
        Me.cmdBotones1.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBotones1.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBotones1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones1.Location = New System.Drawing.Point(192, 231)
        Me.cmdBotones1.Name = "cmdBotones1"
        Me.cmdBotones1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBotones1.Size = New System.Drawing.Size(74, 23)
        Me.cmdBotones1.TabIndex = 8
        Me.cmdBotones1.Text = "&Cancelar"
        Me.cmdBotones1.UseVisualStyleBackColor = False
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.Add(Me.Ctr_Ayuda1)
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(0, 166)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(370, 45)
        Me.Frame3.TabIndex = 7
        Me.Frame3.TabStop = False
        Me.Frame3.Text = "Cuenta Contable"
        '
        'Ctr_Ayuda1
        '
        Me.Ctr_Ayuda1.Enabled = True
        Me.Ctr_Ayuda1.Location = New System.Drawing.Point(4, 16)
        Me.Ctr_Ayuda1.Name = "Ctr_Ayuda1"
        Me.Ctr_Ayuda1.OcxState = CType(resources.GetObject("Ctr_Ayuda1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Ctr_Ayuda1.Size = New System.Drawing.Size(360, 22)
        Me.Ctr_Ayuda1.TabIndex = 10
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.cboNiveles)
        Me.Frame2.Controls.Add(Me.Option21)
        Me.Frame2.Controls.Add(Me.Option20)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(0, 92)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(370, 61)
        Me.Frame2.TabIndex = 3
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Parámetros de Impresión"
        '
        'cboNiveles
        '
        Me.cboNiveles.BackColor = System.Drawing.SystemColors.Window
        Me.cboNiveles.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboNiveles.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboNiveles.Location = New System.Drawing.Point(134, 16)
        Me.cboNiveles.Name = "cboNiveles"
        Me.cboNiveles.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboNiveles.Size = New System.Drawing.Size(221, 21)
        Me.cboNiveles.TabIndex = 6
        '
        'Option21
        '
        Me.Option21.BackColor = System.Drawing.SystemColors.Control
        Me.Option21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Option21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Option21.Location = New System.Drawing.Point(6, 38)
        Me.Option21.Name = "Option21"
        Me.Option21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Option21.Size = New System.Drawing.Size(143, 20)
        Me.Option21.TabIndex = 5
        Me.Option21.TabStop = True
        Me.Option21.Text = "Estructurado"
        Me.Option21.UseVisualStyleBackColor = False
        '
        'Option20
        '
        Me.Option20.BackColor = System.Drawing.SystemColors.Control
        Me.Option20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Option20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Option20.Location = New System.Drawing.Point(7, 17)
        Me.Option20.Name = "Option20"
        Me.Option20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Option20.Size = New System.Drawing.Size(143, 20)
        Me.Option20.TabIndex = 4
        Me.Option20.TabStop = True
        Me.Option20.Text = "Niveles"
        Me.Option20.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.Option10)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(0, 16)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(369, 63)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Tipo de Impresión"
        '
        'Option10
        '
        Me.Option10.BackColor = System.Drawing.SystemColors.Control
        Me.Option10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Option10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Option10.Location = New System.Drawing.Point(8, 22)
        Me.Option10.Name = "Option10"
        Me.Option10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Option10.Size = New System.Drawing.Size(154, 16)
        Me.Option10.TabIndex = 1
        Me.Option10.TabStop = True
        Me.Option10.Text = "Plan de Cuentas Total"
        Me.Option10.UseVisualStyleBackColor = True
        '
        'frmRepPlanCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(370, 265)
        Me.Controls.Add(Me.cmdBotones0)
        Me.Controls.Add(Me.cmdBotones1)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRepPlanCuentas"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Plan de Cuentas"
        Me.Frame3.ResumeLayout(False)
        CType(Me.Ctr_Ayuda1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame2.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class