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
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents _cmdBotones_0 As System.Windows.Forms.Button
	Public WithEvents _cmdBotones_1 As System.Windows.Forms.Button
	Public WithEvents Ctr_Ayuda1 As Axctrlayuda_f.AxCtr_Ayuda
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents cboNiveles As System.Windows.Forms.ComboBox
	Public WithEvents _Option2_1 As System.Windows.Forms.RadioButton
	Public WithEvents _Option2_0 As System.Windows.Forms.RadioButton
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents _Option1_1 As System.Windows.Forms.RadioButton
	Public WithEvents _Option1_0 As System.Windows.Forms.RadioButton
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents Option1 As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	Public WithEvents Option2 As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	Public WithEvents cmdBotones As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRepPlanCuentas))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me._cmdBotones_0 = New System.Windows.Forms.Button()
        Me._cmdBotones_1 = New System.Windows.Forms.Button()
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me.Ctr_Ayuda1 = New Axctrlayuda_f.AxCtr_Ayuda()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.cboNiveles = New System.Windows.Forms.ComboBox()
        Me._Option2_1 = New System.Windows.Forms.RadioButton()
        Me._Option2_0 = New System.Windows.Forms.RadioButton()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me._Option1_1 = New System.Windows.Forms.RadioButton()
        Me._Option1_0 = New System.Windows.Forms.RadioButton()
        Me.Option1 = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
        Me.Option2 = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
        Me.cmdBotones = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(Me.components)
        Me.Frame3.SuspendLayout()
        CType(Me.Ctr_Ayuda1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame2.SuspendLayout()
        Me.Frame1.SuspendLayout()
        CType(Me.Option1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Option2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdBotones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_cmdBotones_0
        '
        Me._cmdBotones_0.BackColor = System.Drawing.SystemColors.Control
        Me._cmdBotones_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdBotones_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones.SetIndex(Me._cmdBotones_0, CType(0, Short))
        Me._cmdBotones_0.Location = New System.Drawing.Point(105, 231)
        Me._cmdBotones_0.Name = "_cmdBotones_0"
        Me._cmdBotones_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdBotones_0.Size = New System.Drawing.Size(74, 23)
        Me._cmdBotones_0.TabIndex = 9
        Me._cmdBotones_0.Text = "&Aceptar"
        Me._cmdBotones_0.UseVisualStyleBackColor = False
        '
        '_cmdBotones_1
        '
        Me._cmdBotones_1.BackColor = System.Drawing.SystemColors.Control
        Me._cmdBotones_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._cmdBotones_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBotones.SetIndex(Me._cmdBotones_1, CType(1, Short))
        Me._cmdBotones_1.Location = New System.Drawing.Point(192, 231)
        Me._cmdBotones_1.Name = "_cmdBotones_1"
        Me._cmdBotones_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._cmdBotones_1.Size = New System.Drawing.Size(74, 23)
        Me._cmdBotones_1.TabIndex = 8
        Me._cmdBotones_1.Text = "&Cancelar"
        Me._cmdBotones_1.UseVisualStyleBackColor = False
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
        Me.Frame2.Controls.Add(Me._Option2_1)
        Me.Frame2.Controls.Add(Me._Option2_0)
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
        '_Option2_1
        '
        Me._Option2_1.BackColor = System.Drawing.SystemColors.Control
        Me._Option2_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Option2_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Option2.SetIndex(Me._Option2_1, CType(1, Short))
        Me._Option2_1.Location = New System.Drawing.Point(6, 34)
        Me._Option2_1.Name = "_Option2_1"
        Me._Option2_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Option2_1.Size = New System.Drawing.Size(143, 20)
        Me._Option2_1.TabIndex = 5
        Me._Option2_1.TabStop = True
        Me._Option2_1.Text = "Estructurado"
        Me._Option2_1.UseVisualStyleBackColor = False
        '
        '_Option2_0
        '
        Me._Option2_0.BackColor = System.Drawing.SystemColors.Control
        Me._Option2_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Option2_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Option2.SetIndex(Me._Option2_0, CType(0, Short))
        Me._Option2_0.Location = New System.Drawing.Point(7, 17)
        Me._Option2_0.Name = "_Option2_0"
        Me._Option2_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Option2_0.Size = New System.Drawing.Size(143, 20)
        Me._Option2_0.TabIndex = 4
        Me._Option2_0.TabStop = True
        Me._Option2_0.Text = "Niveles"
        Me._Option2_0.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me._Option1_1)
        Me.Frame1.Controls.Add(Me._Option1_0)
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
        '_Option1_1
        '
        Me._Option1_1.BackColor = System.Drawing.SystemColors.Control
        Me._Option1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Option1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Option1.SetIndex(Me._Option1_1, CType(1, Short))
        Me._Option1_1.Location = New System.Drawing.Point(7, 44)
        Me._Option1_1.Name = "_Option1_1"
        Me._Option1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Option1_1.Size = New System.Drawing.Size(154, 16)
        Me._Option1_1.TabIndex = 2
        Me._Option1_1.TabStop = True
        Me._Option1_1.Text = "Plan de Cuentas Resumido"
        Me._Option1_1.UseVisualStyleBackColor = False
        '
        '_Option1_0
        '
        Me._Option1_0.BackColor = System.Drawing.SystemColors.Control
        Me._Option1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Option1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Option1.SetIndex(Me._Option1_0, CType(0, Short))
        Me._Option1_0.Location = New System.Drawing.Point(8, 22)
        Me._Option1_0.Name = "_Option1_0"
        Me._Option1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Option1_0.Size = New System.Drawing.Size(154, 16)
        Me._Option1_0.TabIndex = 1
        Me._Option1_0.TabStop = True
        Me._Option1_0.Text = "Plan de Cuentas Total"
        Me._Option1_0.UseVisualStyleBackColor = False
        '
        'Option2
        '
        '
        'cmdBotones
        '
        '
        'frmRepPlanCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(370, 265)
        Me.Controls.Add(Me._cmdBotones_0)
        Me.Controls.Add(Me._cmdBotones_1)
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
        CType(Me.Option1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Option2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdBotones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class